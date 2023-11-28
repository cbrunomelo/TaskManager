Imports System.Runtime.InteropServices
Imports System.Security.Cryptography
Imports System.Text
Imports TaskManager.TaskManager.Services.Utility

Namespace TaskManager.Services.Entitys

    Public NotInheritable Class User
        Inherits Entity

        ReadOnly Property Id As Integer

        ReadOnly Property Name As String

        ReadOnly Property PasswordHash As String


        Sub New(id As Integer, name As String, passwordHash As String)
            Me.Id = id
            Me.Name = name
            Me.PasswordHash = HashUtility.HashPassword(passwordHash)
        End Sub

        Sub New(name As String, passwordHash As String)
            Me.Name = name
            Me.PasswordHash = HashUtility.HashPassword(passwordHash)
        End Sub





    End Class

End Namespace


