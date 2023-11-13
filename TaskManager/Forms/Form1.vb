Imports TaskManager.TaskManager.Services

Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim taskService As TaskService = New TaskService()
        taskService.CreateTask("Teste", DateTime.Now, 24)

    End Sub

    Private Sub btnCreateUser_Click(sender As Object, e As EventArgs) Handles btnCreateUser.Click
        Dim userService As UserService = New UserService()
        userService.CreateUser("Batman", "senha")


    End Sub
End Class
