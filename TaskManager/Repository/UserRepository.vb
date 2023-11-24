Imports System.Data.Common
Imports Microsoft.VisualBasic.ApplicationServices
Imports TaskManager.TaskManager.Repository.Contracts
Imports TaskManager.TaskManager.Repository.DALFactory
Imports TaskManager.TaskManager.Services

Namespace TaskManager.Repository
    Public Class UserRepository
        Implements IRepository(Of Entitys.User)



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

        Public Sub Update(entity As Entitys.User) Implements IRepository(Of Entitys.User).Update
            Throw New NotImplementedException()
        End Sub

        Public Function Delete(id As Integer) As Boolean Implements IRepository(Of Entitys.User).Delete
            Throw New NotImplementedException()
        End Function

        Public Function GetAll(userId As Integer) As IEnumerable(Of Entitys.User) Implements IRepository(Of Entitys.User).GetAll
            Throw New NotImplementedException()
        End Function

        Public Function GetById(id As Integer) As Entitys.User Implements IRepository(Of Entitys.User).GetById
            Throw New NotImplementedException()
        End Function
    End Class


End Namespace


