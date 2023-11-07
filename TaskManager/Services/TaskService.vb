Imports TaskManager.TaskManager.Services.Contracts
Imports TaskManager.TaskManager.Services.Entitys.Enums

Namespace TaskManager.Services
    Public Class TaskService
        Implements ITaskService



        Sub New()

        End Sub

        Public Function CreateTask(title As String, dueDate As Date) As Boolean Implements ITaskService.CreateTask
            Throw New NotImplementedException()
        End Function

        Public Function UpdateTask(id As Integer, title As String, dueDate As Date, status As EStatus) As Boolean Implements ITaskService.UpdateTask
            Throw New NotImplementedException()
        End Function

        Public Function DeleteTask(id As Integer) As Boolean Implements ITaskService.DeleteTask
            Throw New NotImplementedException()
        End Function

        Public Function GetTask(id As Integer) As Task Implements ITaskService.GetTask
            Throw New NotImplementedException()
        End Function

        Public Function GetTasks() As IEnumerable Implements ITaskService.GetTasks
            Throw New NotImplementedException()
        End Function
    End Class

End Namespace



