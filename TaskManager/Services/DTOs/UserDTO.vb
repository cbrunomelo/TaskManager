﻿Namespace TaskManager.Services.DTOs
    Public Class UserDTO
        Private _useCase As EUseCase
        Public ReadOnly Property UseCase As EUseCase
            Get
                Return _useCase
            End Get
        End Property
        ReadOnly Property Id As Integer
        ReadOnly Property Name As String
        ReadOnly Property Password As String
        ReadOnly Property RepeatPassword As String

        Private Sub New(name As String, password As String, repeatPassword As String)

            Me.Name = name
            Me.Password = password
            Me.RepeatPassword = repeatPassword

        End Sub

        Private Sub New(id As Integer, name As String, password As String, repeatPassword As String)
            Me.Id = id
            Me.Name = name
            Me.Password = password
            Me.RepeatPassword = repeatPassword
        End Sub

        Private Sub New(id As Integer, name As String)
            Me.Id = id
            Me.Name = name
        End Sub

        Private Sub New(name As String, password As String)
            Me.Name = name
            Me.Password = password

        End Sub

        Public Shared Function OnUpdate(id As Integer, name As String, password As String, repeatPassword As String) As UserDTO
            Return New UserDTO(id, name, password, repeatPassword) With {
                            ._useCase = EUseCase.EditarRegistro
                        }
        End Function

        Public Shared Function OnCreate(name As String, password As String, reapeatPassword As String) As UserDTO
            Return New UserDTO(name, password, reapeatPassword) With {
                ._useCase = EUseCase.NovoRegistro
            }


        End Function

        Public Shared Function OnLogin(name As String, password As String) As UserDTO
            Return New UserDTO(name, password) With {
                ._useCase = EUseCase.Login
            }
        End Function

        Public Shared Function LoadUserFromDb(id As Integer, name As String) As UserDTO

            Return New UserDTO(id, name)

        End Function


    End Class
End Namespace



