<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.Guna2DragControl1 = New Guna.UI2.WinForms.Guna2DragControl(Me.components)
        Me.combo_user = New Guna.UI2.WinForms.Guna2ComboBox()
        Me.txt_password = New Guna.UI2.WinForms.Guna2TextBox()
        Me.btm_login = New Guna.UI2.WinForms.Guna2Button()
        Me.Check_showpass = New Guna.UI2.WinForms.Guna2CheckBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.SuspendLayout()
        '
        'Guna2DragControl1
        '
        Me.Guna2DragControl1.TargetControl = Me
        '
        'combo_user
        '
        Me.combo_user.BackColor = System.Drawing.Color.Transparent
        Me.combo_user.BorderRadius = 5
        Me.combo_user.BorderThickness = 0
        Me.combo_user.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.combo_user.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.combo_user.FillColor = System.Drawing.SystemColors.Menu
        Me.combo_user.FocusedColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.combo_user.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.combo_user.FocusedState.Parent = Me.combo_user
        Me.combo_user.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.combo_user.ForeColor = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(112, Byte), Integer))
        Me.combo_user.HoverState.Parent = Me.combo_user
        Me.combo_user.ItemHeight = 30
        Me.combo_user.ItemsAppearance.Parent = Me.combo_user
        Me.combo_user.Location = New System.Drawing.Point(58, 113)
        Me.combo_user.Name = "combo_user"
        Me.combo_user.ShadowDecoration.Parent = Me.combo_user
        Me.combo_user.Size = New System.Drawing.Size(200, 36)
        Me.combo_user.TabIndex = 1
        Me.combo_user.TextOffset = New System.Drawing.Point(5, 0)
        '
        'txt_password
        '
        Me.txt_password.BorderRadius = 5
        Me.txt_password.BorderThickness = 0
        Me.txt_password.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txt_password.DefaultText = ""
        Me.txt_password.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txt_password.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txt_password.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txt_password.DisabledState.Parent = Me.txt_password
        Me.txt_password.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txt_password.FillColor = System.Drawing.SystemColors.Menu
        Me.txt_password.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txt_password.FocusedState.Parent = Me.txt_password
        Me.txt_password.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.txt_password.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txt_password.HoverState.Parent = Me.txt_password
        Me.txt_password.Location = New System.Drawing.Point(58, 178)
        Me.txt_password.Name = "txt_password"
        Me.txt_password.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txt_password.PlaceholderText = ""
        Me.txt_password.SelectedText = ""
        Me.txt_password.ShadowDecoration.Parent = Me.txt_password
        Me.txt_password.Size = New System.Drawing.Size(200, 36)
        Me.txt_password.TabIndex = 2
        Me.txt_password.TextOffset = New System.Drawing.Point(5, 0)
        Me.txt_password.UseSystemPasswordChar = True
        '
        'btm_login
        '
        Me.btm_login.Animated = True
        Me.btm_login.AnimatedGIF = True
        Me.btm_login.BorderRadius = 5
        Me.btm_login.CheckedState.Parent = Me.btm_login
        Me.btm_login.CustomImages.Parent = Me.btm_login
        Me.btm_login.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btm_login.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btm_login.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btm_login.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btm_login.DisabledState.Parent = Me.btm_login
        Me.btm_login.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        Me.btm_login.ForeColor = System.Drawing.Color.White
        Me.btm_login.HoverState.Parent = Me.btm_login
        Me.btm_login.Location = New System.Drawing.Point(100, 246)
        Me.btm_login.Name = "btm_login"
        Me.btm_login.ShadowDecoration.Parent = Me.btm_login
        Me.btm_login.Size = New System.Drawing.Size(122, 32)
        Me.btm_login.TabIndex = 3
        Me.btm_login.Text = "Login"
        '
        'Check_showpass
        '
        Me.Check_showpass.Animated = True
        Me.Check_showpass.AutoSize = True
        Me.Check_showpass.CheckedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Check_showpass.CheckedState.BorderRadius = 3
        Me.Check_showpass.CheckedState.BorderThickness = 0
        Me.Check_showpass.CheckedState.FillColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Check_showpass.Location = New System.Drawing.Point(234, 190)
        Me.Check_showpass.Name = "Check_showpass"
        Me.Check_showpass.Size = New System.Drawing.Size(15, 14)
        Me.Check_showpass.TabIndex = 4
        Me.Check_showpass.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(125, Byte), Integer), CType(CType(137, Byte), Integer), CType(CType(149, Byte), Integer))
        Me.Check_showpass.UncheckedState.BorderRadius = 3
        Me.Check_showpass.UncheckedState.BorderThickness = 0
        Me.Check_showpass.UncheckedState.FillColor = System.Drawing.Color.Silver
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Gray
        Me.Label1.Location = New System.Drawing.Point(96, 35)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(102, 21)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "Login Here !"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Gray
        Me.Label2.Location = New System.Drawing.Point(67, 93)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(60, 15)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "Username"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Gray
        Me.Label3.Location = New System.Drawing.Point(67, 160)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(57, 15)
        Me.Label3.TabIndex = 7
        Me.Label3.Text = "Password"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.DodgerBlue
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(310, 5)
        Me.Panel1.TabIndex = 8
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(310, 321)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Check_showpass)
        Me.Controls.Add(Me.btm_login)
        Me.Controls.Add(Me.txt_password)
        Me.Controls.Add(Me.combo_user)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Guna2DragControl1 As Guna.UI2.WinForms.Guna2DragControl
    Friend WithEvents combo_user As Guna.UI2.WinForms.Guna2ComboBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Check_showpass As Guna.UI2.WinForms.Guna2CheckBox
    Friend WithEvents btm_login As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents txt_password As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
End Class
