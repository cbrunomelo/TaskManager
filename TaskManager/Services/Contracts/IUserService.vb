Imports TaskManager.TaskManager.Services.DTOs
Imports TaskManager.TaskManager.Services.Entitys

Namespace TaskManager.Services.Contracts
    Public Interface IUserService

        Function CreateUser(userDto As UserDTO) As ResultViewModel(Of UserDTO)

        Sub UpdateUser(id As Integer, name As String, password As String)

        Sub DeleteUser(id As Integer)
        Function GetUser(id As Integer) As User

        Function GetUsers() As IEnumerable

    End Interface


End Namespace



