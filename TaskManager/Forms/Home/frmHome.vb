Imports TaskManager.TaskManager.Services
Imports TaskManager.TaskManager.Services.Contracts
Imports TaskManager.TaskManager.Services.DTOs

Public Class frmHome
    Private _userLogado As UserDTO
    Private _taskSerivce As ITaskService
    Sub New(userLogado As UserDTO)
        _userLogado = userLogado
        _taskSerivce = New TaskService()

        InitializeComponent()
        AtualizarControles()
    End Sub



    Private Sub AtualizarControles()
        Me.lblBoaVindas.Text += _userLogado.Name
    End Sub

    Private Sub frmHome_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        AtualizarGrid()
    End Sub

    Private Sub AtualizarGrid()
        Dim BuscarTarefas = _taskSerivce.GetTasks(_userLogado.Id)
        If BuscarTarefas.Success Then
            Me.dgvTask.DataSource = BuscarTarefas.Data
            Me.dgvTask.Columns("Id").Visible = False
            Me.dgvTask.Columns("UserId").Visible = False
            Me.dgvTask.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.None
            Me.dgvTask.ScrollBars = ScrollBars.None
        Else
            MessageBox.Show("Não foi possivel carregar as tarefas")
        End If
    End Sub
End Class