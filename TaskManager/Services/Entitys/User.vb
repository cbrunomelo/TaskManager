Namespace TaskManager.Services.Entitys

    Public NotInheritable Class User
        Inherits Entity

        ReadOnly Property Id As Integer

        ReadOnly Property Name As String

        ReadOnly Property PasswordHash As String


        Sub New(id As Integer, name As String, passwordHash As String)
            Me.Id = id
            Me.Name = name
            Me.PasswordHash = passwordHash
        End Sub

        Sub New(name As String, passwordHash As String)
            Me.Name = name
            Me.PasswordHash = passwordHash
        End Sub



    End Class

End Namespace


