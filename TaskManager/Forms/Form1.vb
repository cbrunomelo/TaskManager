Imports TaskManager.TaskManager.Services
Imports TaskManager.TaskManager.Services.DTOs
Imports TaskManager.TaskManager.Services.Entitys.Enums

Public Class Form1
    Private _taskService As TaskService
    Sub New()

        InitializeComponent()

        _taskService = New TaskService()


    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        _taskService.CreateTask("Teste3", DateTime.Now, 24)

    End Sub

    Private Sub btnCreateUser_Click(sender As Object, e As EventArgs) Handles btnCreateUser.Click
        Dim userService As UserService = New UserService()
        userService.CreateUser("Batman", "senha")


    End Sub

    Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click


        Dim taskDTO As TaskDTO = New TaskDTO(1, "TesteUpdate", DateTime.Now, EStatus.Done, 1)

        Dim result = _taskService.UpdateTask(taskDTO)

        If result.Success Then
            MessageBox.Show("Tarefa atualizada com sucesso")
        Else
            MessageBox.Show(result.Erros(0))
        End If

    End Sub

    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        Dim Result As ResultViewModel(Of TaskDTO) = _taskService.DeleteTask(2)
        If Result.Success Then
            MessageBox.Show(Result.Erros(0))
        Else
            MessageBox.Show("Tarefa excluída com sucesso")
        End If
    End Sub

    Private Sub btnGetbyId_Click(sender As Object, e As EventArgs) Handles btnGetbyId.Click
        Dim result = _taskService.GetTask(2)

        If result.Success Then
            MessageBox.Show(result.Data.Title)
        Else
            MessageBox.Show(result.Erros(0))
        End If

    End Sub

    Private Sub btnGetAll_Click(sender As Object, e As EventArgs) Handles btnGetAll.Click
        Dim message As String = ""
        For Each item In _taskService.GetTasks(24).Data
            message += item.Title + vbCrLf
        Next

        MessageBox.Show(message)

    End Sub
End Class
