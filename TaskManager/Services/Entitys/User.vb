Imports System.Runtime.InteropServices
Imports System.Security.Cryptography
Imports System.Text
Imports TaskManager.TaskManager.Services.Utility

Namespace TaskManager.Services.Entitys

    Public NotInheritable Class User
        Inherits Entity

        Private _id As Integer
        Property Id As Integer
            Get
                Return _id
            End Get
            Private Set(value As Integer)
                _id = value
            End Set
        End Property

        Private _name As String
        Property Name As String
            Get
                Return _name
            End Get
            Private Set(value As String)
                _name = value
            End Set
        End Property

        Private _passwordHash As String
        Property PasswordHash As String
            Get
                Return _passwordHash
            End Get
            Private Set(value As String)
                _passwordHash = value
            End Set
        End Property

        Sub New()

        End Sub
        Sub New(id As Integer, name As String, passwordHash As String)
            Me.Id = id
            Me.Name = name
            Me.PasswordHash = HashUtility.HashPassword(passwordHash)
        End Sub

        Sub New(name As String, passwordHash As String)
            Me.Name = name
            Me.PasswordHash = HashUtility.HashPassword(passwordHash)
        End Sub

        Public Sub LoadFromDb(id As Integer, name As String, passwordHash As String)
            Me.Id = id
            Me.Name = name
            Me.PasswordHash = passwordHash
        End Sub



    End Class

End Namespace


