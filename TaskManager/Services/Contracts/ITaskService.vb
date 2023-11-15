Imports TaskManager.TaskManager.Services.DTOs
Imports TaskManager.TaskManager.Services.Entitys.Enums

Namespace TaskManager.Services.Contracts
    Public Interface ITaskService

        Function CreateTask(title As String, dueDate As DateTime, userId As Int32) As Boolean

        Function UpdateTask(taskDTO As TaskDTO) As Boolean

        Function DeleteTask(id As Integer) As Boolean

        Function GetTask(id As Integer) As Task

        Function GetTasks() As IEnumerable



    End Interface
End Namespace


