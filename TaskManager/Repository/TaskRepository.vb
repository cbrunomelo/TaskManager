Imports TaskManager.TaskManager.Repository.Contracts
Imports TaskManager.TaskManager.Services.Entitys
Imports System.Data.Common
Imports TaskManager.TaskManager.Repository.DALFactory

Namespace TaskManager.Repository
    Public Class TaskRepository
        Implements IRepository(Of TaskManager.Services.Entitys.Task)

        Sub New()
            ConexaoDB.getAcesso(ETipoAcesso.SQLite)
        End Sub

        Public Sub Add(entity As Task) Implements IRepository(Of Task).Add

            Dim comando As String = "INSERT INTO Tasks (TITLE, CREATED, LASTUPDATE, DUEDATE, STATUS, USERID) VALUES (@VAL1, @VAL2, @VAL3, @VAL4, @VAL5, @VAL6)"
            Dim paramtros As List(Of DbParameter) = New List(Of DbParameter)
            paramtros.Add(DALFactory.DALFactory.CriarParametro("@VAL1", DbType.String, entity.Title))
            paramtros.Add(DALFactory.DALFactory.CriarParametro("@VAL2", DbType.DateTime2, entity.Created))
            paramtros.Add(DALFactory.DALFactory.CriarParametro("@VAL3", DbType.DateTime2, entity.LastUpdate))
            paramtros.Add(DALFactory.DALFactory.CriarParametro("@VAL4", DbType.DateTime2, entity.DueDate))
            paramtros.Add(DALFactory.DALFactory.CriarParametro("@VAL5", DbType.String, entity.Status.ToString))
            paramtros.Add(DALFactory.DALFactory.CriarParametro("@VAL6", DbType.Int32, entity.UserId))

            DALFactory.DALFactory.ExecutarComando(comando, CommandType.Text, paramtros, TipoDeComando.ExecuteNonQuery)



        End Sub

        Public Sub Update(entity As Task) Implements IRepository(Of Task).Update
            Dim comand As String = "UPDATE Tasks SET TITLE = @VAL1, LASTUPDATE = @VAL2, DUEDATE = @VAL3, STATUS = @VAL4 WHERE ID = @VAL5"
            Dim paramtros As List(Of DbParameter) = New List(Of DbParameter)
            paramtros.Add(DALFactory.DALFactory.CriarParametro("@VAL1", DbType.String, entity.Title))
            paramtros.Add(DALFactory.DALFactory.CriarParametro("@VAL2", DbType.DateTime2, entity.LastUpdate))
            paramtros.Add(DALFactory.DALFactory.CriarParametro("@VAL3", DbType.DateTime2, entity.DueDate))
            paramtros.Add(DALFactory.DALFactory.CriarParametro("@VAL4", DbType.String, entity.Status.ToString))
            paramtros.Add(DALFactory.DALFactory.CriarParametro("@VAL5", DbType.Int32, entity.Id))

            DALFactory.DALFactory.ExecutarComando(comand, CommandType.Text, paramtros, TipoDeComando.ExecuteNonQuery)
        End Sub

        Public Function Delete(id As Integer) As Boolean Implements IRepository(Of Task).Delete
            Dim comando As String = "DELETE FROM Tasks WHERE ID = @VAL1"
            Dim paramtros As List(Of DbParameter) = New List(Of DbParameter)
            paramtros.Add(DALFactory.DALFactory.CriarParametro("@VAL1", DbType.Int32, id))
            Dim result = DALFactory.DALFactory.ExecutarComando(comando, CommandType.Text, paramtros, TipoDeComando.ExecuteNonQuery)

            Return Integer.Parse(result) > 0


        End Function

        Public Function GetAll() As IEnumerable(Of Task) Implements IRepository(Of Task).GetAll
            Throw New NotImplementedException()
        End Function

        Public Function GetById(id As Integer) As Task Implements IRepository(Of Task).GetById
            Dim comando As String = "SELECT * FROM Tasks WHERE ID = @VAL1"
            Dim paramtros As List(Of DbParameter) = New List(Of DbParameter)
            paramtros.Add(DALFactory.DALFactory.CriarParametro("@VAL1", DbType.Int32, id))
            Dim reader = DALFactory.DALFactory.ExecutarComando(comando, CommandType.Text, paramtros, TipoDeComando.ExecuteReader)

            While reader.Read

                Return New Task(reader("ID"), reader("Title"), reader("Created"), reader("LastUpdate"), reader("DueDate"),
                                reader("Status"), reader("UserId"))

            End While


        End Function
    End Class
End Namespace


