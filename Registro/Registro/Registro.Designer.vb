<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Registro
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.LabelUsername = New System.Windows.Forms.Label()
        Me.TextUser = New System.Windows.Forms.TextBox()
        Me.LabelPassword = New System.Windows.Forms.Label()
        Me.TextPassword = New System.Windows.Forms.TextBox()
        Me.LabelEmail = New System.Windows.Forms.Label()
        Me.TextEmail = New System.Windows.Forms.TextBox()
        Me.LabelRol = New System.Windows.Forms.Label()
        Me.TextTipo = New System.Windows.Forms.TextBox()
        Me.BtnRegistro = New System.Windows.Forms.Button()
        Me.BtnEditar = New System.Windows.Forms.Button()
        Me.BtnEliminar = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TextFecha = New System.Windows.Forms.TextBox()
        Me.TableUsers = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.TabPage3 = New System.Windows.Forms.TabPage()
        Me.TabPage4 = New System.Windows.Forms.TabPage()
        Me.TabPage5 = New System.Windows.Forms.TabPage()
        Me.TabPage6 = New System.Windows.Forms.TabPage()
        Me.MySqlCommand1 = New MySql.Data.MySqlClient.MySqlCommand()
        Me.TableUsers.SuspendLayout()
        Me.SuspendLayout()
        '
        'LabelUsername
        '
        Me.LabelUsername.AutoSize = True
        Me.LabelUsername.Location = New System.Drawing.Point(119, 84)
        Me.LabelUsername.Name = "LabelUsername"
        Me.LabelUsername.Size = New System.Drawing.Size(154, 20)
        Me.LabelUsername.TabIndex = 1
        Me.LabelUsername.Text = "Nombre de Usuario: "
        '
        'TextUser
        '
        Me.TextUser.Location = New System.Drawing.Point(300, 81)
        Me.TextUser.Name = "TextUser"
        Me.TextUser.Size = New System.Drawing.Size(161, 26)
        Me.TextUser.TabIndex = 6
        '
        'LabelPassword
        '
        Me.LabelPassword.AutoSize = True
        Me.LabelPassword.Location = New System.Drawing.Point(173, 142)
        Me.LabelPassword.Name = "LabelPassword"
        Me.LabelPassword.Size = New System.Drawing.Size(100, 20)
        Me.LabelPassword.TabIndex = 7
        Me.LabelPassword.Text = "Contraseña: "
        '
        'TextPassword
        '
        Me.TextPassword.Location = New System.Drawing.Point(300, 136)
        Me.TextPassword.Name = "TextPassword"
        Me.TextPassword.Size = New System.Drawing.Size(161, 26)
        Me.TextPassword.TabIndex = 8
        '
        'LabelEmail
        '
        Me.LabelEmail.AutoSize = True
        Me.LabelEmail.Location = New System.Drawing.Point(125, 195)
        Me.LabelEmail.Name = "LabelEmail"
        Me.LabelEmail.Size = New System.Drawing.Size(148, 20)
        Me.LabelEmail.TabIndex = 9
        Me.LabelEmail.Text = "Correo Electronico: "
        '
        'TextEmail
        '
        Me.TextEmail.Location = New System.Drawing.Point(300, 192)
        Me.TextEmail.Name = "TextEmail"
        Me.TextEmail.Size = New System.Drawing.Size(161, 26)
        Me.TextEmail.TabIndex = 10
        '
        'LabelRol
        '
        Me.LabelRol.AutoSize = True
        Me.LabelRol.Location = New System.Drawing.Point(145, 293)
        Me.LabelRol.Name = "LabelRol"
        Me.LabelRol.Size = New System.Drawing.Size(128, 20)
        Me.LabelRol.TabIndex = 11
        Me.LabelRol.Text = "Tipo de Usuario: "
        '
        'TextTipo
        '
        Me.TextTipo.Location = New System.Drawing.Point(300, 293)
        Me.TextTipo.Name = "TextTipo"
        Me.TextTipo.Size = New System.Drawing.Size(161, 26)
        Me.TextTipo.TabIndex = 12
        '
        'BtnRegistro
        '
        Me.BtnRegistro.Location = New System.Drawing.Point(300, 381)
        Me.BtnRegistro.Name = "BtnRegistro"
        Me.BtnRegistro.Size = New System.Drawing.Size(113, 37)
        Me.BtnRegistro.TabIndex = 13
        Me.BtnRegistro.Text = "Registrarse"
        Me.BtnRegistro.UseVisualStyleBackColor = True
        '
        'BtnEditar
        '
        Me.BtnEditar.Location = New System.Drawing.Point(546, 378)
        Me.BtnEditar.Name = "BtnEditar"
        Me.BtnEditar.Size = New System.Drawing.Size(91, 40)
        Me.BtnEditar.TabIndex = 14
        Me.BtnEditar.Text = "Editar"
        Me.BtnEditar.UseVisualStyleBackColor = True
        '
        'BtnEliminar
        '
        Me.BtnEliminar.Location = New System.Drawing.Point(546, 424)
        Me.BtnEliminar.Name = "BtnEliminar"
        Me.BtnEliminar.Size = New System.Drawing.Size(90, 40)
        Me.BtnEliminar.TabIndex = 15
        Me.BtnEliminar.Text = "Eliminar"
        Me.BtnEliminar.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(106, 245)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(167, 20)
        Me.Label1.TabIndex = 16
        Me.Label1.Text = "Fecha de Nacimiento: "
        '
        'TextFecha
        '
        Me.TextFecha.Location = New System.Drawing.Point(300, 242)
        Me.TextFecha.Name = "TextFecha"
        Me.TextFecha.Size = New System.Drawing.Size(161, 26)
        Me.TextFecha.TabIndex = 17
        '
        'TableUsers
        '
        Me.TableUsers.Controls.Add(Me.TabPage1)
        Me.TableUsers.Controls.Add(Me.TabPage2)
        Me.TableUsers.Controls.Add(Me.TabPage3)
        Me.TableUsers.Controls.Add(Me.TabPage4)
        Me.TableUsers.Controls.Add(Me.TabPage5)
        Me.TableUsers.Controls.Add(Me.TabPage6)
        Me.TableUsers.Location = New System.Drawing.Point(12, 480)
        Me.TableUsers.Name = "TableUsers"
        Me.TableUsers.SelectedIndex = 0
        Me.TableUsers.Size = New System.Drawing.Size(647, 157)
        Me.TableUsers.TabIndex = 18
        '
        'TabPage1
        '
        Me.TabPage1.Location = New System.Drawing.Point(4, 29)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(639, 124)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "ID"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'TabPage2
        '
        Me.TabPage2.Location = New System.Drawing.Point(4, 29)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(639, 124)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Username"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'TabPage3
        '
        Me.TabPage3.Location = New System.Drawing.Point(4, 29)
        Me.TabPage3.Name = "TabPage3"
        Me.TabPage3.Size = New System.Drawing.Size(639, 124)
        Me.TabPage3.TabIndex = 2
        Me.TabPage3.Text = "Password"
        Me.TabPage3.UseVisualStyleBackColor = True
        '
        'TabPage4
        '
        Me.TabPage4.Location = New System.Drawing.Point(4, 29)
        Me.TabPage4.Name = "TabPage4"
        Me.TabPage4.Size = New System.Drawing.Size(639, 67)
        Me.TabPage4.TabIndex = 3
        Me.TabPage4.Text = "Email"
        Me.TabPage4.UseVisualStyleBackColor = True
        '
        'TabPage5
        '
        Me.TabPage5.Location = New System.Drawing.Point(4, 29)
        Me.TabPage5.Name = "TabPage5"
        Me.TabPage5.Size = New System.Drawing.Size(639, 67)
        Me.TabPage5.TabIndex = 4
        Me.TabPage5.Text = "Fecha de Nacimiento"
        Me.TabPage5.UseVisualStyleBackColor = True
        '
        'TabPage6
        '
        Me.TabPage6.Location = New System.Drawing.Point(4, 29)
        Me.TabPage6.Name = "TabPage6"
        Me.TabPage6.Size = New System.Drawing.Size(639, 124)
        Me.TabPage6.TabIndex = 5
        Me.TabPage6.Text = "Cargo"
        Me.TabPage6.UseVisualStyleBackColor = True
        '
        'MySqlCommand1
        '
        Me.MySqlCommand1.CacheAge = 0
        Me.MySqlCommand1.Connection = Nothing
        Me.MySqlCommand1.EnableCaching = False
        Me.MySqlCommand1.Transaction = Nothing
        '
        'Registro
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(671, 675)
        Me.Controls.Add(Me.TableUsers)
        Me.Controls.Add(Me.TextFecha)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.BtnEliminar)
        Me.Controls.Add(Me.BtnEditar)
        Me.Controls.Add(Me.BtnRegistro)
        Me.Controls.Add(Me.TextTipo)
        Me.Controls.Add(Me.LabelRol)
        Me.Controls.Add(Me.TextEmail)
        Me.Controls.Add(Me.LabelEmail)
        Me.Controls.Add(Me.TextPassword)
        Me.Controls.Add(Me.LabelPassword)
        Me.Controls.Add(Me.TextUser)
        Me.Controls.Add(Me.LabelUsername)
        Me.Name = "Registro"
        Me.Text = "Form2"
        Me.TableUsers.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents LabelUsername As Label
    Friend WithEvents TextUser As TextBox
    Friend WithEvents LabelPassword As Label
    Friend WithEvents TextPassword As TextBox
    Friend WithEvents LabelEmail As Label
    Friend WithEvents TextEmail As TextBox
    Friend WithEvents LabelRol As Label
    Friend WithEvents TextTipo As TextBox
    Friend WithEvents BtnRegistro As Button
    Friend WithEvents BtnEditar As Button
    Friend WithEvents BtnEliminar As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents TextFecha As TextBox
    Friend WithEvents TableUsers As TabControl
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents TabPage2 As TabPage
    Friend WithEvents TabPage3 As TabPage
    Friend WithEvents TabPage4 As TabPage
    Friend WithEvents TabPage5 As TabPage
    Friend WithEvents TabPage6 As TabPage
    Friend WithEvents MySqlCommand1 As MySql.Data.MySqlClient.MySqlCommand
End Class
