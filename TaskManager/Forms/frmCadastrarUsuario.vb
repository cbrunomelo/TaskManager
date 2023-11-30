Imports TaskManager.TaskManager.Services
Imports TaskManager.TaskManager.Services.Contracts
Imports TaskManager.TaskManager.Services.DTOs

Public Class frmCadastrarUsuario

    Private _userService As IUserService
    Private _frmLogin As frmLogin
    Sub New(form As frmLogin)
        _frmLogin = form
        InitializeComponent()
        _userService = New UserService()
    End Sub

    Private Sub btnCriar_Click(sender As Object, e As EventArgs) Handles btnCriar.Click
        Dim userDTO As UserDTO = userDTO.OnCreate(Me.txtLogin.Text, Me.txtSenha.Text, Me.txtConfirmarSenha.Text)
        Dim result = _userService.Create(userDTO)
        If result.Success Then
            MessageBox.Show("Usuário criado com sucesso")
            Me.Close()
            _frmLogin.Show()
        Else
            Dim message As String = String.Empty
            For Each item In result.Erros
                message += item + vbCrLf
            Next
            MessageBox.Show(message)
        End If

    End Sub

    Private Sub btnCancelar_Click(sender As Object, e As EventArgs) Handles btnCancelar.Click
        Me.Close()
        _frmLogin.Show()
    End Sub
End Class