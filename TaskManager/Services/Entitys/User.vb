Imports System.Runtime.InteropServices
Imports System.Security.Cryptography
Imports System.Text

Namespace TaskManager.Services.Entitys

    Public NotInheritable Class User
        Inherits Entity

        ReadOnly Property Id As Integer

        ReadOnly Property Name As String

        ReadOnly Property PasswordHash As String


        Sub New(id As Integer, name As String, passwordHash As String)
            Me.Id = id
            Me.Name = name
            Me.PasswordHash = HashPassword(passwordHash)
        End Sub

        Sub New(name As String, passwordHash As String)
            Me.Name = name
            Me.PasswordHash = passwordHash
        End Sub


        Private Function HashPassword(password As String) As String
            Dim data = Encoding.UTF8.GetBytes(password)
            Dim sha256 As SHA256 = SHA256.Create()
            Dim hashbytes As Byte() = sha256.ComputeHash(data)
            Dim stringBuilder As New StringBuilder()
            For Each b In hashbytes
                stringBuilder.Append(b.ToString("x2"))
            Next
            Return stringBuilder.ToString()

        End Function


    End Class

End Namespace


