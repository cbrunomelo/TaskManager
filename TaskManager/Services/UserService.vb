Imports TaskManager.TaskManager.Repository
Imports TaskManager.TaskManager.Repository.Contracts
Imports TaskManager.TaskManager.Repository.DALFactory
Imports TaskManager.TaskManager.Services.Contracts
Imports TaskManager.TaskManager.Services.Entitys

Namespace TaskManager.Services
    Public Class UserService
        Implements IUserService

        Private _repository As IRepository(Of User)

        Sub New()

            _repository = New UserRepository()



        End Sub
        Public Sub CreateUser(name As String, password As String) Implements IUserService.CreateUser
            Dim user As User = New User(name, password)
            _repository.Add(user)

        End Sub

        Public Sub UpdateUser(id As Integer, name As String, password As String) Implements IUserService.UpdateUser
            Throw New NotImplementedException()
        End Sub

        Public Sub DeleteUser(id As Integer) Implements IUserService.DeleteUser
            Throw New NotImplementedException()
        End Sub

        Public Function GetUser(id As Integer) As User Implements IUserService.GetUser
            Throw New NotImplementedException()
        End Function

        Public Function GetUsers() As IEnumerable Implements IUserService.GetUsers
            Throw New NotImplementedException()
        End Function
    End Class


End Namespace


