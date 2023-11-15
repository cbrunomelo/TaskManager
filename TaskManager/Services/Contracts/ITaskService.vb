Imports TaskManager.TaskManager.Services.DTOs
Imports TaskManager.TaskManager.Services.Entitys.Enums

Namespace TaskManager.Services.Contracts
    Public Interface ITaskService

        Function CreateTask(title As String, dueDate As DateTime, userId As Int32) As ResultViewModel(Of TaskDTO)

        Function UpdateTask(taskDTO As TaskDTO) As ResultViewModel(Of TaskDTO)

        Function DeleteTask(id As Integer) As ResultViewModel(Of TaskDTO)

        Function GetTask(id As Integer) As ResultViewModel(Of TaskDTO)

        Function GetTasks() As ResultViewModel(Of IEnumerable(Of TaskDTO))



    End Interface
End Namespace


