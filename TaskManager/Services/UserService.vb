Imports TaskManager.TaskManager.Repository
Imports TaskManager.TaskManager.Repository.Contracts
Imports TaskManager.TaskManager.Repository.DALFactory
Imports TaskManager.TaskManager.Services.Contracts
Imports TaskManager.TaskManager.Services.DTOs
Imports TaskManager.TaskManager.Services.Entitys

Namespace TaskManager.Services
    Public Class UserService
        Implements IUserService

        Private _repository As IRepository(Of User)

        Sub New()

            _repository = New UserRepository()



        End Sub
        Public Function CreateUser(userDto As UserDTO) As ResultViewModel(Of UserDTO) Implements IUserService.CreateUser
            Dim validator = New UserDTOValidator()
            Dim result = validator.Validate(userDto)
            If result.IsValid Then
                Dim user = New User(userDto.Name, userDto.Password)
                _repository.Add(user)
                Return New ResultViewModel(Of UserDTO)(userDto)
            Else
                Return New ResultViewModel(Of UserDTO)(result.ToListErros)
            End If

        End Function

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


