Imports TaskManager.TaskManager.Services.Entitys.Enums

Namespace TaskManager.Services.DTOs
    Public Class TaskDTO
        Public Property UserId As Integer

        Public Property Title As String

        Public Property DueDate As DateTime?

        Public Property Status As EStatus?

        Public Property Id As Integer

        Sub New(userId As Integer, title As String, dueDate As DateTime, status As EStatus)

            Me.UserId = userId
            Me.Title = title
            Me.DueDate = dueDate
            Me.Status = status

        End Sub


    End Class

End Namespace

