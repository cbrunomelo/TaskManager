Imports TaskManager.TaskManager.Repository.Contracts
Imports TaskManager.TaskManager.Services.Entitys
Imports System.Data.Common
Imports TaskManager.TaskManager.Repository.DALFactory

Namespace TaskManager.Repository
    Public Class TaskRepository
        Implements IRepository(Of TaskManager.Services.Entitys.Task)

        Public Sub Add(entity As Task) Implements IRepository(Of Task).Add

            ConexaoDB.getAcesso(ETipoAcesso.SQLite)


            Dim comando As String = "INSERT INTO Tasks (TITLE, CREATED, LASTUPDATE, DUEDATE, STATUS, USERID) VALUES (@VAL1, @VAL2, @VAL3, @VAL4, @VAL5, @VAL6)"
            Dim paramtros As List(Of DbParameter) = New List(Of DbParameter)
            paramtros.Add(DALFactory.DALFactory.CriarParametro("@VAL1", DbType.String, entity.Title))
            paramtros.Add(DALFactory.DALFactory.CriarParametro("@VAL2", DbType.DateTime2, entity.Created))
            paramtros.Add(DALFactory.DALFactory.CriarParametro("@VAL3", DbType.DateTime2, entity.LastUpdate))
            paramtros.Add(DALFactory.DALFactory.CriarParametro("@VAL4", DbType.DateTime2, entity.DueDate))
            paramtros.Add(DALFactory.DALFactory.CriarParametro("@VAL5", DbType.String, entity.Status.ToString))
            paramtros.Add(DALFactory.DALFactory.CriarParametro("@VAL6", DbType.Int32, entity.UserId))

            DALFactory.DALFactory.ExecutarComando(ETipoAcesso.SQLite, comando, CommandType.Text, paramtros, DALFactory.DALFactory.TipoDeComando.ExecuteNonQuery)



        End Sub

        Public Sub Update(entity As Task) Implements IRepository(Of Task).Update
            Throw New NotImplementedException()
        End Sub

        Public Sub Delete(entity As Task) Implements IRepository(Of Task).Delete
            Throw New NotImplementedException()
        End Sub

        Public Function GetAll() As IEnumerable(Of Task) Implements IRepository(Of Task).GetAll
            Throw New NotImplementedException()
        End Function

        Public Function GetById(id As Integer) As Task Implements IRepository(Of Task).GetById
            Throw New NotImplementedException()
        End Function
    End Class
End Namespace


