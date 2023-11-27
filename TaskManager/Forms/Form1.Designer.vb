<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Dim btnUppdate As System.Windows.Forms.Button
        Me.Button1 = New System.Windows.Forms.Button()
        Me.btnCreateUser = New System.Windows.Forms.Button()
        Me.btnUpdate = New System.Windows.Forms.Button()
        Me.btnDelete = New System.Windows.Forms.Button()
        Me.btnGetbyId = New System.Windows.Forms.Button()
        Me.btnGetAll = New System.Windows.Forms.Button()
        Me.grpTaskService = New System.Windows.Forms.GroupBox()
        Me.grpUserService = New System.Windows.Forms.GroupBox()
        Me.btnDelete2 = New System.Windows.Forms.Button()
        btnUppdate = New System.Windows.Forms.Button()
        Me.grpTaskService.SuspendLayout()
        Me.grpUserService.SuspendLayout()
        Me.SuspendLayout()
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(6, 92)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 0
        Me.Button1.Text = "Criar tarefa"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'btnCreateUser
        '
        Me.btnCreateUser.Location = New System.Drawing.Point(6, 34)
        Me.btnCreateUser.Name = "btnCreateUser"
        Me.btnCreateUser.Size = New System.Drawing.Size(75, 23)
        Me.btnCreateUser.TabIndex = 1
        Me.btnCreateUser.Text = "Criar usuario"
        Me.btnCreateUser.UseVisualStyleBackColor = True
        '
        'btnUpdate
        '
        Me.btnUpdate.Location = New System.Drawing.Point(6, 63)
        Me.btnUpdate.Name = "btnUpdate"
        Me.btnUpdate.Size = New System.Drawing.Size(75, 23)
        Me.btnUpdate.TabIndex = 2
        Me.btnUpdate.Text = "update"
        Me.btnUpdate.UseVisualStyleBackColor = True
        '
        'btnDelete
        '
        Me.btnDelete.Location = New System.Drawing.Point(6, 121)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Size = New System.Drawing.Size(75, 23)
        Me.btnDelete.TabIndex = 3
        Me.btnDelete.Text = "Excluir"
        Me.btnDelete.UseVisualStyleBackColor = True
        '
        'btnGetbyId
        '
        Me.btnGetbyId.Location = New System.Drawing.Point(6, 34)
        Me.btnGetbyId.Name = "btnGetbyId"
        Me.btnGetbyId.Size = New System.Drawing.Size(75, 23)
        Me.btnGetbyId.TabIndex = 4
        Me.btnGetbyId.Text = "GetTask1"
        Me.btnGetbyId.UseVisualStyleBackColor = True
        '
        'btnGetAll
        '
        Me.btnGetAll.Location = New System.Drawing.Point(6, 150)
        Me.btnGetAll.Name = "btnGetAll"
        Me.btnGetAll.Size = New System.Drawing.Size(75, 23)
        Me.btnGetAll.TabIndex = 5
        Me.btnGetAll.Text = "Get all"
        Me.btnGetAll.UseVisualStyleBackColor = True
        '
        'grpTaskService
        '
        Me.grpTaskService.Controls.Add(Me.btnGetbyId)
        Me.grpTaskService.Controls.Add(Me.btnGetAll)
        Me.grpTaskService.Controls.Add(Me.btnUpdate)
        Me.grpTaskService.Controls.Add(Me.btnDelete)
        Me.grpTaskService.Controls.Add(Me.Button1)
        Me.grpTaskService.Location = New System.Drawing.Point(533, 60)
        Me.grpTaskService.Name = "grpTaskService"
        Me.grpTaskService.Size = New System.Drawing.Size(98, 187)
        Me.grpTaskService.TabIndex = 6
        Me.grpTaskService.TabStop = False
        Me.grpTaskService.Text = "TaskService"
        '
        'grpUserService
        '
        Me.grpUserService.Controls.Add(Me.btnDelete2)
        Me.grpUserService.Controls.Add(btnUppdate)
        Me.grpUserService.Controls.Add(Me.btnCreateUser)
        Me.grpUserService.Location = New System.Drawing.Point(164, 60)
        Me.grpUserService.Name = "grpUserService"
        Me.grpUserService.Size = New System.Drawing.Size(119, 187)
        Me.grpUserService.TabIndex = 7
        Me.grpUserService.TabStop = False
        Me.grpUserService.Text = "UserService"
        '
        'btnUppdate
        '
        btnUppdate.Location = New System.Drawing.Point(7, 64)
        btnUppdate.Name = "btnUppdate"
        btnUppdate.Size = New System.Drawing.Size(75, 23)
        btnUppdate.TabIndex = 2
        btnUppdate.Text = "Update"
        btnUppdate.UseVisualStyleBackColor = True
        AddHandler btnUppdate.Click, AddressOf Me.btnUppdate_Click
        '
        'btnDelete2
        '
        Me.btnDelete2.Location = New System.Drawing.Point(7, 91)
        Me.btnDelete2.Name = "btnDelete2"
        Me.btnDelete2.Size = New System.Drawing.Size(75, 23)
        Me.btnDelete2.TabIndex = 3
        Me.btnDelete2.Text = "Delete"
        Me.btnDelete2.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.grpUserService)
        Me.Controls.Add(Me.grpTaskService)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.grpTaskService.ResumeLayout(False)
        Me.grpUserService.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Button1 As Button
    Friend WithEvents btnCreateUser As Button
    Friend WithEvents btnUpdate As Button
    Friend WithEvents btnDelete As Button
    Friend WithEvents btnGetbyId As Button
    Friend WithEvents btnGetAll As Button
    Friend WithEvents grpTaskService As GroupBox
    Friend WithEvents grpUserService As GroupBox
    Friend WithEvents btnDelete2 As Button
End Class
