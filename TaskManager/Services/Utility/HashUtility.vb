Imports System.Security.Cryptography
Imports System.Text
Namespace TaskManager.Services.Utility

    Module HashUtility

        Public Function HashPassword(password As String) As String
            Dim data = Encoding.UTF8.GetBytes(password)
            Dim sha256 As SHA256 = SHA256.Create()
            Dim hashbytes As Byte() = sha256.ComputeHash(data)
            Dim stringBuilder As New StringBuilder()
            For Each b In hashbytes
                stringBuilder.Append(b.ToString("x2"))
            Next
            Return stringBuilder.ToString()

        End Function

        Public Function verifyHash(password As String, hash As String) As Boolean
            Dim hashOfInput = HashPassword(password)
            Dim comparer As StringComparer = StringComparer.OrdinalIgnoreCase
            Return comparer.Compare(hashOfInput, hash) = 0
        End Function

    End Module

End Namespace
