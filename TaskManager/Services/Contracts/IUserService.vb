Imports TaskManager.TaskManager.Services.DTOs
Imports TaskManager.TaskManager.Services.Entitys

Namespace TaskManager.Services.Contracts
    Public Interface IUserService

        Function Create(userDto As UserDTO) As ResultViewModel(Of UserDTO)

        Function Update(userDTO As UserDTO) As ResultViewModel(Of UserDTO)

        Function Delete(id As Integer) As Boolean
        Function GetById(id As Integer) As User

        Function GetAll() As IEnumerable

        Function IsNameInUse(name As String) As Boolean

        Function Login(userDto As UserDTO) As ResultViewModel(Of UserDTO)

    End Interface


End Namespace



