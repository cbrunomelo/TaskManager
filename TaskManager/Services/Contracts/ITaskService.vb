Imports TaskManager.TaskManager.Services.Entitys.Enums

Namespace TaskManager.Services.Contracts
    Public Interface ITaskService

        Function CreateTask(title As String, dueDate As DateTime, userId As Int32) As Boolean

        Function UpdateTask(id As Integer, title As String, dueDate As DateTime, status As EStatus) As Boolean

        Function DeleteTask(id As Integer) As Boolean

        Function GetTask(id As Integer) As Task

        Function GetTasks() As IEnumerable



    End Interface
End Namespace


