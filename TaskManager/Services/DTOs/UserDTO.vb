Namespace TaskManager.Services.DTOs
    Public Class UserDTO

        Property Name As String

        Property Password As String

        Property RepeatPassword As String

        Sub New(name As String, password As String, repeatPassword As String)

            Me.Name = name
            Me.Password = password
            Me.RepeatPassword = repeatPassword

        End Sub

        Sub New(name As String, password As String)
            Me.Name = name
            Me.Password = password
            Me.RepeatPassword = password
        End Sub



    End Class
End Namespace



