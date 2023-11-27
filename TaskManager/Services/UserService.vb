Imports TaskManager.TaskManager.Repository
Imports TaskManager.TaskManager.Repository.Contracts
Imports TaskManager.TaskManager.Repository.DALFactory
Imports TaskManager.TaskManager.Services.Contracts
Imports TaskManager.TaskManager.Services.DTOs
Imports TaskManager.TaskManager.Services.Entitys
Imports TaskManager.TaskManager.TaskManager.Repository.Contracts

Namespace TaskManager.Services
    Public Class UserService
        Implements IUserService

        Private _repository As IUserrepository
        Private _validator As UserDTOValidator
        Sub New()

            _repository = New UserRepository()
            _validator = New UserDTOValidator(Me)


        End Sub
        Public Function CreateUser(userDto As UserDTO) As ResultViewModel(Of UserDTO) Implements IUserService.CreateUser
            Dim result = _validator.Validate(userDto)
            If result.IsValid Then
                Dim user = New User(userDto.Name, userDto.Password)
                _repository.Add(user)
                Return New ResultViewModel(Of UserDTO)(userDto)
            Else
                Return New ResultViewModel(Of UserDTO)(result.ToListErros)
            End If

        End Function

        Public Function UpdateUser(userDTO As UserDTO) As ResultViewModel(Of UserDTO) Implements IUserService.UpdateUser

            Dim result = _validator.Validate(userDTO)
            If result.IsValid Then
                Dim user = New User(userDTO.Name, userDTO.Password)
                _repository.Update(user)
                Return New ResultViewModel(Of UserDTO)(userDTO)
            Else
                Return New ResultViewModel(Of UserDTO)(result.ToListErros)
            End If
        End Function

        Public Sub DeleteUser(id As Integer) Implements IUserService.DeleteUser
            Throw New NotImplementedException()
        End Sub

        Public Function GetUser(id As Integer) As User Implements IUserService.GetUser
            Throw New NotImplementedException()
        End Function

        Public Function GetUsers() As IEnumerable Implements IUserService.GetUsers
            Throw New NotImplementedException()
        End Function


        Private Function IsNameInUse(name As String) As Boolean Implements IUserService.IsNameInUse
            Dim result = _repository.GetByName(name)
            Return result IsNot Nothing

        End Function
    End Class


End Namespace


