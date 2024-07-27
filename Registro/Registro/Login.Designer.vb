<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Login
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
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

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.Labelusername = New System.Windows.Forms.Label()
        Me.TextUser = New System.Windows.Forms.TextBox()
        Me.LabelPassword = New System.Windows.Forms.Label()
        Me.TextPassword = New System.Windows.Forms.TextBox()
        Me.BtnConect = New System.Windows.Forms.Button()
        Me.LblResult = New System.Windows.Forms.Label()
        Me.BtnRegistro = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Labelusername
        '
        Me.Labelusername.AutoSize = True
        Me.Labelusername.Location = New System.Drawing.Point(216, 101)
        Me.Labelusername.Name = "Labelusername"
        Me.Labelusername.Size = New System.Drawing.Size(64, 20)
        Me.Labelusername.TabIndex = 4
        Me.Labelusername.Text = "Usuario"
        '
        'TextUser
        '
        Me.TextUser.Location = New System.Drawing.Point(163, 152)
        Me.TextUser.Name = "TextUser"
        Me.TextUser.Size = New System.Drawing.Size(154, 26)
        Me.TextUser.TabIndex = 5
        '
        'LabelPassword
        '
        Me.LabelPassword.AutoSize = True
        Me.LabelPassword.Location = New System.Drawing.Point(188, 228)
        Me.LabelPassword.Name = "LabelPassword"
        Me.LabelPassword.Size = New System.Drawing.Size(92, 20)
        Me.LabelPassword.TabIndex = 6
        Me.LabelPassword.Text = "Contraseña"
        '
        'TextPassword
        '
        Me.TextPassword.Location = New System.Drawing.Point(163, 281)
        Me.TextPassword.Name = "TextPassword"
        Me.TextPassword.Size = New System.Drawing.Size(154, 26)
        Me.TextPassword.TabIndex = 7
        '
        'BtnConect
        '
        Me.BtnConect.Location = New System.Drawing.Point(322, 337)
        Me.BtnConect.Name = "BtnConect"
        Me.BtnConect.Size = New System.Drawing.Size(104, 32)
        Me.BtnConect.TabIndex = 8
        Me.BtnConect.Text = "Conectar"
        Me.BtnConect.UseVisualStyleBackColor = True
        '
        'LblResult
        '
        Me.LblResult.AutoSize = True
        Me.LblResult.Location = New System.Drawing.Point(279, 395)
        Me.LblResult.Name = "LblResult"
        Me.LblResult.Size = New System.Drawing.Size(57, 20)
        Me.LblResult.TabIndex = 9
        Me.LblResult.Text = "Label1"
        '
        'BtnRegistro
        '
        Me.BtnRegistro.Location = New System.Drawing.Point(358, 28)
        Me.BtnRegistro.Name = "BtnRegistro"
        Me.BtnRegistro.Size = New System.Drawing.Size(137, 36)
        Me.BtnRegistro.TabIndex = 10
        Me.BtnRegistro.Text = "Registrarse"
        Me.BtnRegistro.UseVisualStyleBackColor = True
        '
        'Login
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(516, 450)
        Me.Controls.Add(Me.BtnRegistro)
        Me.Controls.Add(Me.LblResult)
        Me.Controls.Add(Me.BtnConect)
        Me.Controls.Add(Me.TextPassword)
        Me.Controls.Add(Me.LabelPassword)
        Me.Controls.Add(Me.TextUser)
        Me.Controls.Add(Me.Labelusername)
        Me.Name = "Login"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Labelusername As Label
    Friend WithEvents TextUser As TextBox
    Friend WithEvents LabelPassword As Label
    Friend WithEvents TextPassword As TextBox
    Friend WithEvents BtnConect As Button
    Friend WithEvents LblResult As Label
    Friend WithEvents BtnRegistro As Button
End Class
