Imports TaskManager.TaskManager.Services.Entitys.Enums

Namespace TaskManager.Services.Entitys

    Public NotInheritable Class Task
        Inherits Entity

        ReadOnly Property Id As Integer?

        ReadOnly Property Title As String

        ReadOnly Property Created As DateTime

        ReadOnly Property LastUpdate As String

        ReadOnly Property DueDate As DateTime

        ReadOnly Property Status As EStatus

        Property UserId As Integer?
        ReadOnly Property User As User



        Sub New(title As String, dueDate As DateTime, userId As Integer)
            Me.Title = title
            Me.Created = DateTime.Now
            Me.LastUpdate = DateTime.Now
            Me.Status = EStatus.Pending
            Me.DueDate = dueDate
            Me.UserId = userId

        End Sub
    End Class
End Namespace
