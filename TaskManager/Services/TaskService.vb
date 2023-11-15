Imports TaskManager.TaskManager.Repository.Contracts
Imports TaskManager.TaskManager.Services.Contracts
Imports TaskManager.TaskManager.Services.Entitys.Enums
Imports TaskManager.TaskManager.Repository
Imports TaskManager.TaskManager.Services.DTOs
Imports TaskManager.TaskManager.Services.DTOs.Validations

Namespace TaskManager.Services
    Public Class TaskService
        Implements ITaskService

        Private _repository As IRepository(Of Entitys.Task)


        Sub New()
            _repository = New TaskRepository()
        End Sub

        Public Function CreateTask(title As String, dueDate As DateTime, userId As Int32) As ResultViewModel(Of TaskDTO) Implements ITaskService.CreateTask
            Dim task As Entitys.Task = New Entitys.Task(title, dueDate, userId)
            _repository.Add(task)

        End Function

        Public Function UpdateTask(taskDTO As TaskDTO) As ResultViewModel(Of TaskDTO) Implements ITaskService.UpdateTask

            Dim taskValidator As TaskValidator = New TaskValidator()
            Dim result = taskValidator.Validate(taskDTO)
            If Not result.IsValid Then
                Return New ResultViewModel(Of TaskDTO)(result.ToListErros())

            End If

            Dim task As Entitys.Task = _repository.GetById(taskDTO.Id)


            task.Update(taskDTO.Title, taskDTO.DueDate, taskDTO.Status)
            If task.IsValid = False Then
                Return New ResultViewModel(Of TaskDTO)(task.ErrorList)
            End If

            _repository.Update(task)

            Return New ResultViewModel(Of TaskDTO)(New TaskDTO(task.UserId, task.Title, task.DueDate, task.Status, task.Id))
        End Function

        Public Function DeleteTask(id As Integer) As ResultViewModel(Of TaskDTO) Implements ITaskService.DeleteTask
            Throw New NotImplementedException()
        End Function

        Public Function GetTask(id As Integer) As ResultViewModel(Of TaskDTO) Implements ITaskService.GetTask
            Throw New NotImplementedException()
        End Function

        Public Function GetTasks() As ResultViewModel(Of IEnumerable(Of TaskDTO)) Implements ITaskService.GetTasks
            Throw New NotImplementedException()
        End Function
    End Class

End Namespace



