<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmCadastrarUsuario
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
        Me.txtSenha = New System.Windows.Forms.TextBox()
        Me.txtLogin = New System.Windows.Forms.TextBox()
        Me.lblSenha = New System.Windows.Forms.Label()
        Me.lblLogin = New System.Windows.Forms.Label()
        Me.txtConfirmarSenha = New System.Windows.Forms.TextBox()
        Me.lblRepeteSenha = New System.Windows.Forms.Label()
        Me.btnCancelar = New System.Windows.Forms.Button()
        Me.btnCriar = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'txtSenha
        '
        Me.txtSenha.Location = New System.Drawing.Point(106, 115)
        Me.txtSenha.Name = "txtSenha"
        Me.txtSenha.Size = New System.Drawing.Size(146, 20)
        Me.txtSenha.TabIndex = 7
        '
        'txtLogin
        '
        Me.txtLogin.Location = New System.Drawing.Point(106, 80)
        Me.txtLogin.Name = "txtLogin"
        Me.txtLogin.Size = New System.Drawing.Size(146, 20)
        Me.txtLogin.TabIndex = 6
        '
        'lblSenha
        '
        Me.lblSenha.AutoSize = True
        Me.lblSenha.Location = New System.Drawing.Point(67, 115)
        Me.lblSenha.Name = "lblSenha"
        Me.lblSenha.Size = New System.Drawing.Size(38, 13)
        Me.lblSenha.TabIndex = 5
        Me.lblSenha.Text = "Senha"
        '
        'lblLogin
        '
        Me.lblLogin.AutoSize = True
        Me.lblLogin.Location = New System.Drawing.Point(67, 83)
        Me.lblLogin.Name = "lblLogin"
        Me.lblLogin.Size = New System.Drawing.Size(33, 13)
        Me.lblLogin.TabIndex = 4
        Me.lblLogin.Text = "Login"
        '
        'txtConfirmarSenha
        '
        Me.txtConfirmarSenha.Location = New System.Drawing.Point(106, 152)
        Me.txtConfirmarSenha.Name = "txtConfirmarSenha"
        Me.txtConfirmarSenha.Size = New System.Drawing.Size(146, 20)
        Me.txtConfirmarSenha.TabIndex = 9
        '
        'lblRepeteSenha
        '
        Me.lblRepeteSenha.AutoSize = True
        Me.lblRepeteSenha.Location = New System.Drawing.Point(21, 155)
        Me.lblRepeteSenha.Name = "lblRepeteSenha"
        Me.lblRepeteSenha.Size = New System.Drawing.Size(85, 13)
        Me.lblRepeteSenha.TabIndex = 8
        Me.lblRepeteSenha.Text = "Confirmar Senha"
        '
        'btnCancelar
        '
        Me.btnCancelar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.btnCancelar.FlatAppearance.BorderSize = 0
        Me.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCancelar.Location = New System.Drawing.Point(106, 260)
        Me.btnCancelar.Name = "btnCancelar"
        Me.btnCancelar.Size = New System.Drawing.Size(146, 23)
        Me.btnCancelar.TabIndex = 11
        Me.btnCancelar.Text = "Cancelar"
        Me.btnCancelar.UseVisualStyleBackColor = True
        '
        'btnCriar
        '
        Me.btnCriar.Location = New System.Drawing.Point(133, 220)
        Me.btnCriar.Name = "btnCriar"
        Me.btnCriar.Size = New System.Drawing.Size(87, 23)
        Me.btnCriar.TabIndex = 10
        Me.btnCriar.Text = "Criar"
        Me.btnCriar.UseVisualStyleBackColor = True
        '
        'frmCadastrarUsuario
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(318, 295)
        Me.Controls.Add(Me.btnCancelar)
        Me.Controls.Add(Me.btnCriar)
        Me.Controls.Add(Me.txtConfirmarSenha)
        Me.Controls.Add(Me.lblRepeteSenha)
        Me.Controls.Add(Me.txtSenha)
        Me.Controls.Add(Me.txtLogin)
        Me.Controls.Add(Me.lblSenha)
        Me.Controls.Add(Me.lblLogin)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.Name = "frmCadastrarUsuario"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frmCadastrarUsuario"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txtSenha As TextBox
    Friend WithEvents txtLogin As TextBox
    Friend WithEvents lblSenha As Label
    Friend WithEvents lblLogin As Label
    Friend WithEvents txtConfirmarSenha As TextBox
    Friend WithEvents lblRepeteSenha As Label
    Friend WithEvents btnCancelar As Button
    Friend WithEvents btnCriar As Button
End Class
