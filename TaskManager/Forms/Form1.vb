Imports TaskManager.TaskManager.Services
Imports TaskManager.TaskManager.Services.DTOs
Imports TaskManager.TaskManager.Services.Entitys.Enums

Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim taskService As TaskService = New TaskService()
        taskService.CreateTask("Teste", DateTime.Now, 24)

    End Sub

    Private Sub btnCreateUser_Click(sender As Object, e As EventArgs) Handles btnCreateUser.Click
        Dim userService As UserService = New UserService()
        userService.CreateUser("Batman", "senha")


    End Sub

    Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click

        Dim taskService As TaskService = New TaskService()
        Dim taskDTO As TaskDTO = New TaskDTO(1, "TesteUpdate", DateTime.Now, EStatus.Done, 1)

        Dim result = taskService.UpdateTask(taskDTO)

        If result.Success Then
            MessageBox.Show("Tarefa atualizada com sucesso")
        Else
            MessageBox.Show(result.Erros(0))
        End If

    End Sub
End Class
