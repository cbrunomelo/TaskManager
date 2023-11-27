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
        Public Function Create(userDto As UserDTO) As ResultViewModel(Of UserDTO) Implements IUserService.Create
            Dim result = _validator.Validate(userDto)
            If result.IsValid Then
                Dim user = New User(userDto.Name, userDto.Password)
                _repository.Add(user)
                Return New ResultViewModel(Of UserDTO)(userDto)
            Else
                Return New ResultViewModel(Of UserDTO)(result.ToListErros)
            End If

        End Function

        Public Function Update(userDTO As UserDTO) As ResultViewModel(Of UserDTO) Implements IUserService.Update

            Dim result = _validator.Validate(userDTO)
            If Not result.IsValid Then
                Return New ResultViewModel(Of UserDTO)(result.ToListErros)
            End If

            Dim user = New User(userDTO.Id, userDTO.Name, userDTO.Password)
            If _repository.Update(user) > 0 Then
                Return New ResultViewModel(Of UserDTO)(userDTO)
            End If

            Return New ResultViewModel(Of UserDTO)("Não foi possivel atualizar o registro")
        End Function

        Public Function Delete(id As Integer) As Boolean Implements IUserService.Delete
            Return _repository.Delete(id)
        End Function

        Public Function GetById(id As Integer) As User Implements IUserService.GetById
            Throw New NotImplementedException()
        End Function

        Public Function GetAll() As IEnumerable Implements IUserService.GetAll
            Throw New NotImplementedException()
        End Function


        Private Function IsNameInUse(name As String) As Boolean Implements IUserService.IsNameInUse
            Dim result = _repository.GetByName(name)
            Return result IsNot Nothing

        End Function
    End Class


End Namespace


