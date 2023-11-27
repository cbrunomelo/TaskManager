Imports TaskManager.TaskManager.Services.DTOs
Imports TaskManager.TaskManager.Services.Entitys

Namespace TaskManager.Services.Contracts
    Public Interface IUserService

        Function CreateUser(userDto As UserDTO) As ResultViewModel(Of UserDTO)

        Function UpdateUser(userDTO As UserDTO) As ResultViewModel(Of UserDTO)

        Sub DeleteUser(id As Integer)
        Function GetUser(id As Integer) As User

        Function GetUsers() As IEnumerable

        Function IsNameInUse(name As String) As Boolean

    End Interface


End Namespace



