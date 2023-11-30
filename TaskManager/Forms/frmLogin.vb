Imports TaskManager.TaskManager.Services
Imports TaskManager.TaskManager.Services.Contracts
Imports TaskManager.TaskManager.Services.DTOs

Public Class frmLogin
    Private _userService As IUserService
    Sub New()
        _userService = New UserService()
        InitializeComponent()

    End Sub
    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        Dim login As String = Me.txtLogin.Text
        Dim password As String = Me.txtSenha.Text

        Dim userDto As UserDTO = UserDTO.OnLogin(login, password)
        Dim result = _userService.Login(userDto)
        If result.Success Then
            MessageBox.Show("Login realizado com sucesso")
        Else
            Dim message As String = String.Empty
            For Each item In result.Erros
                message += item + vbCrLf
            Next
            MessageBox.Show(message)
        End If

    End Sub
End Class