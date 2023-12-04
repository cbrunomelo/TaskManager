Imports TaskManager.TaskManager.Services.DTOs

Public Class frmHome
    Private _userLogado As UserDTO

    Sub New(userLogado As UserDTO)
        _userLogado = userLogado

        InitializeComponent()
        AtualizarControles()
    End Sub



    Private Sub AtualizarControles()
        Me.lblBoaVindas.Text += _userLogado.Name
    End Sub
End Class