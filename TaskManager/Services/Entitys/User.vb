Namespace TaskManager.Services.Entitys

    Public Class User

        ReadOnly Property Name As String

        ReadOnly Property PasswordHash As String


        Sub New(name As String, passwordHash As String)
            Me.Name = name
            Me.PasswordHash = passwordHash
        End Sub




    End Class

End Namespace


