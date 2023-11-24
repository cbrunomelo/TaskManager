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

            Dim taskValidator As TaskDTOValidator = New TaskDTOValidator()
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
            Dim result = _repository.Delete(id)
            If result = False Then
                Return New ResultViewModel(Of TaskDTO)("Não foi possível excluir a tarefa")
            End If

            Return New ResultViewModel(Of TaskDTO)(New TaskDTO(0, "", Date.Now, EStatus.Done, 0))

        End Function

        Public Function GetTask(id As Integer) As ResultViewModel(Of TaskDTO) Implements ITaskService.GetTask
            Dim result = _repository.GetById(id)
            If result IsNot Nothing Then
                Return New ResultViewModel(Of TaskDTO)(New TaskDTO(result.UserId, result.Title, result.DueDate, result.Status, result.Id))
            End If

            Return New ResultViewModel(Of TaskDTO)("Tarefa não encontrada")

        End Function

        Public Function GetTasks(userId As Integer) As ResultViewModel(Of IEnumerable(Of TaskDTO)) Implements ITaskService.GetTasks
            Dim list As List(Of TaskDTO) = New List(Of TaskDTO)

            For Each item In _repository.GetAll(userId)
                Dim taskDTO As TaskDTO = New TaskDTO(item.UserId, item.Title, item.DueDate, item.Status, item.Id)
                list.Add(taskDTO)
            Next
            Return New ResultViewModel(Of IEnumerable(Of TaskDTO))(list)
        End Function
    End Class

End Namespace



