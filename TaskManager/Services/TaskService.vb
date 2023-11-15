Imports TaskManager.TaskManager.Repository.Contracts
Imports TaskManager.TaskManager.Services.Contracts
Imports TaskManager.TaskManager.Services.Entitys.Enums
Imports TaskManager.TaskManager.Repository
Imports TaskManager.TaskManager.Services.DTOs

Namespace TaskManager.Services
    Public Class TaskService
        Implements ITaskService

        Private _repository As IRepository(Of Entitys.Task)


        Sub New()
            _repository = New TaskRepository()
        End Sub

        Public Function CreateTask(title As String, dueDate As DateTime, userId As Int32) As Boolean Implements ITaskService.CreateTask
            Dim task As Entitys.Task = New Entitys.Task(title, dueDate, userId)
            _repository.Add(task)

        End Function

        Public Function UpdateTask(taskDTO As TaskDTO) As Boolean Implements ITaskService.UpdateTask
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



