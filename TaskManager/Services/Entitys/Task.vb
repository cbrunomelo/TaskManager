Namespace TaskManager.Services.Entitys

    Public Class Task

        ReadOnly Property Id As Integer?

        ReadOnly Property Title As String

        ReadOnly Property Created As DateTime

        ReadOnly Property LastUpdate As String

        ReadOnly Property DueDate As DateTime

        ReadOnly Property Status As EStatus

        Sub New(title As String, dueDate As DateTime)
            Me.Title = title
            Me.Created = DateTime.Now
            Me.LastUpdate = DateTime.Now
            Me.Status = EStatus.Pending
            Me.DueDate = dueDate

        End Sub
    End Class
End Namespace
