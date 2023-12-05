<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmHome
    Inherits System.Windows.Forms.Form

    'Descartar substituições de formulário para limpar a lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Exigido pelo Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'OBSERVAÇÃO: o procedimento a seguir é exigido pelo Windows Form Designer
    'Pode ser modificado usando o Windows Form Designer.  
    'Não o modifique usando o editor de códigos.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.dgvTask = New System.Windows.Forms.DataGridView()
        Me.lbltTrefas = New System.Windows.Forms.Label()
        Me.lblBoaVindas = New System.Windows.Forms.Label()
        Me.btnNova = New System.Windows.Forms.Button()
        Me.btnAvancarStatus = New System.Windows.Forms.Button()
        Me.btnExcluir = New System.Windows.Forms.Button()
        CType(Me.dgvTask, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dgvTask
        '
        Me.dgvTask.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvTask.Location = New System.Drawing.Point(4, 189)
        Me.dgvTask.Name = "dgvTask"
        Me.dgvTask.Size = New System.Drawing.Size(309, 175)
        Me.dgvTask.TabIndex = 0
        '
        'lbltTrefas
        '
        Me.lbltTrefas.AutoSize = True
        Me.lbltTrefas.Location = New System.Drawing.Point(12, 163)
        Me.lbltTrefas.Name = "lbltTrefas"
        Me.lbltTrefas.Size = New System.Drawing.Size(43, 13)
        Me.lbltTrefas.TabIndex = 1
        Me.lbltTrefas.Text = "Tarefas"
        '
        'lblBoaVindas
        '
        Me.lblBoaVindas.AutoSize = True
        Me.lblBoaVindas.Location = New System.Drawing.Point(16, 9)
        Me.lblBoaVindas.Name = "lblBoaVindas"
        Me.lblBoaVindas.Size = New System.Drawing.Size(35, 13)
        Me.lblBoaVindas.TabIndex = 2
        Me.lblBoaVindas.Text = "Olá ..."
        '
        'btnNova
        '
        Me.btnNova.Location = New System.Drawing.Point(15, 108)
        Me.btnNova.Name = "btnNova"
        Me.btnNova.Size = New System.Drawing.Size(75, 23)
        Me.btnNova.TabIndex = 3
        Me.btnNova.Text = "Nova"
        Me.btnNova.UseVisualStyleBackColor = True
        '
        'btnAvancarStatus
        '
        Me.btnAvancarStatus.Location = New System.Drawing.Point(120, 108)
        Me.btnAvancarStatus.Name = "btnAvancarStatus"
        Me.btnAvancarStatus.Size = New System.Drawing.Size(75, 23)
        Me.btnAvancarStatus.TabIndex = 4
        Me.btnAvancarStatus.Text = "Avançar"
        Me.btnAvancarStatus.UseVisualStyleBackColor = True
        '
        'btnExcluir
        '
        Me.btnExcluir.Location = New System.Drawing.Point(229, 108)
        Me.btnExcluir.Name = "btnExcluir"
        Me.btnExcluir.Size = New System.Drawing.Size(75, 23)
        Me.btnExcluir.TabIndex = 5
        Me.btnExcluir.Text = "Excluir"
        Me.btnExcluir.UseVisualStyleBackColor = True
        '
        'frmHome
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(325, 390)
        Me.Controls.Add(Me.btnExcluir)
        Me.Controls.Add(Me.btnAvancarStatus)
        Me.Controls.Add(Me.btnNova)
        Me.Controls.Add(Me.lblBoaVindas)
        Me.Controls.Add(Me.lbltTrefas)
        Me.Controls.Add(Me.dgvTask)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.Name = "frmHome"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Home"
        CType(Me.dgvTask, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents dgvTask As DataGridView
    Friend WithEvents lbltTrefas As Label
    Friend WithEvents lblBoaVindas As Label
    Friend WithEvents btnNova As Button
    Friend WithEvents btnAvancarStatus As Button
    Friend WithEvents btnExcluir As Button
End Class
