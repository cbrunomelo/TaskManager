Imports System.Data.Common
Imports Microsoft.VisualBasic.ApplicationServices
Imports TaskManager.TaskManager.Repository.Contracts
Imports TaskManager.TaskManager.Repository.DALFactory
Imports TaskManager.TaskManager.Services
Imports TaskManager.TaskManager.TaskManager.Repository.Contracts

Namespace TaskManager.Repository
    Public Class UserRepository
        Implements IUserrepository

        Sub New()
            ConexaoDB.getAcesso(ETipoAcesso.SQLite)

        End Sub

        Public Sub Add(entity As Entitys.User) Implements IRepository(Of Entitys.User).Add

            Dim command As String = "Insert into Users (NAME, PasswordHash) VALUES (@VAL1, @VAL2)"
            Dim paramtros As List(Of DbParameter) = New List(Of DbParameter)
            paramtros.Add(DALFactory.DALFactory.CriarParametro("@VAL1", DbType.String, entity.Name))
            paramtros.Add(DALFactory.DALFactory.CriarParametro("@VAL2", DbType.String, entity.PasswordHash))

            DALFactory.DALFactory.ExecutarComando(command, CommandType.Text, paramtros, TipoDeComando.ExecuteNonQuery)
        End Sub

        Public Function Update(entity As Entitys.User) As Integer Implements IRepository(Of Entitys.User).Update
            Dim Command As String = "Update Users set NAME = @VAL1, PasswordHash = @VAL2 where id = @VAL3"
            Dim paramtros As List(Of DbParameter) = New List(Of DbParameter)
            paramtros.Add(DALFactory.DALFactory.CriarParametro("@VAL1", DbType.String, entity.Name))
            paramtros.Add(DALFactory.DALFactory.CriarParametro("@VAL2", DbType.String, entity.PasswordHash))
            paramtros.Add(DALFactory.DALFactory.CriarParametro("@VAL3", DbType.Int32, entity.Id))


            Return DALFactory.DALFactory.ExecutarComando(Command, CommandType.Text, paramtros, TipoDeComando.ExecuteNonQuery)



        End Function

        Public Function Delete(id As Integer) As Boolean Implements IRepository(Of Entitys.User).Delete
            Throw New NotImplementedException()
        End Function

        Public Function GetAll(userId As Integer) As IEnumerable(Of Entitys.User) Implements IRepository(Of Entitys.User).GetAll
            Throw New NotImplementedException()
        End Function

        Public Function GetById(id As Integer) As Entitys.User Implements IRepository(Of Entitys.User).GetById
            Throw New NotImplementedException()
        End Function

        Public Function GetByName(name As String) As Integer? Implements IUserrepository.GetByName
            Dim command = "Select id from USERS where NAME = @VAL1"
            Dim paramtros As List(Of DbParameter) = New List(Of DbParameter)
            paramtros.Add(DALFactory.DALFactory.CriarParametro("@VAL1", DbType.String, name))
            Dim result = DALFactory.DALFactory.ExecutarComando(command, CommandType.Text, paramtros, TipoDeComando.ExecuteScalar)
            If result Is Nothing Then
                Return Nothing
            End If

            Return Convert.ToInt32(result)


        End Function
    End Class


End Namespace


