<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class manageuserfrm
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(manageuserfrm))
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txt_firstname = New Guna.UI2.WinForms.Guna2TextBox()
        Me.txt_lastname = New Guna.UI2.WinForms.Guna2TextBox()
        Me.txt_username = New Guna.UI2.WinForms.Guna2TextBox()
        Me.txt_password = New Guna.UI2.WinForms.Guna2TextBox()
        Me.combo_role = New Guna.UI2.WinForms.Guna2ComboBox()
        Me.pic_box = New Guna.UI2.WinForms.Guna2CirclePictureBox()
        Me.Btn_Save = New Guna.UI2.WinForms.Guna2Button()
        Me.Check_showpass = New Guna.UI2.WinForms.Guna2CustomCheckBox()
        Me.Guna2DragControl1 = New Guna.UI2.WinForms.Guna2DragControl(Me.components)
        Me.btn_back = New Guna.UI2.WinForms.Guna2Button()
        Me.btn_browse = New Guna.UI2.WinForms.Guna2CirclePictureBox()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column7 = New System.Windows.Forms.DataGridViewImageColumn()
        Me.colDelete = New System.Windows.Forms.DataGridViewButtonColumn()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.Btn_Edit = New Guna.UI2.WinForms.Guna2Button()
        CType(Me.pic_box, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btn_browse, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(67, Byte), Integer), CType(CType(195, Byte), Integer), CType(CType(248, Byte), Integer))
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(720, 5)
        Me.Panel1.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label1.Font = New System.Drawing.Font("Nirmala UI Semilight", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Gray
        Me.Label1.Location = New System.Drawing.Point(74, 33)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(144, 28)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "Manage Users"
        '
        'txt_firstname
        '
        Me.txt_firstname.Animated = True
        Me.txt_firstname.BackColor = System.Drawing.Color.FromArgb(CType(CType(234, Byte), Integer), CType(CType(234, Byte), Integer), CType(CType(234, Byte), Integer))
        Me.txt_firstname.BorderThickness = 0
        Me.txt_firstname.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txt_firstname.DefaultText = ""
        Me.txt_firstname.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txt_firstname.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txt_firstname.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txt_firstname.DisabledState.Parent = Me.txt_firstname
        Me.txt_firstname.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txt_firstname.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txt_firstname.FocusedState.Parent = Me.txt_firstname
        Me.txt_firstname.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.txt_firstname.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txt_firstname.HoverState.Parent = Me.txt_firstname
        Me.txt_firstname.Location = New System.Drawing.Point(268, 70)
        Me.txt_firstname.Name = "txt_firstname"
        Me.txt_firstname.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txt_firstname.PlaceholderText = "First Name"
        Me.txt_firstname.SelectedText = ""
        Me.txt_firstname.ShadowDecoration.Parent = Me.txt_firstname
        Me.txt_firstname.Size = New System.Drawing.Size(97, 36)
        Me.txt_firstname.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material
        Me.txt_firstname.TabIndex = 6
        Me.txt_firstname.TextOffset = New System.Drawing.Point(5, 0)
        '
        'txt_lastname
        '
        Me.txt_lastname.Animated = True
        Me.txt_lastname.BackColor = System.Drawing.Color.FromArgb(CType(CType(234, Byte), Integer), CType(CType(234, Byte), Integer), CType(CType(234, Byte), Integer))
        Me.txt_lastname.BorderThickness = 0
        Me.txt_lastname.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txt_lastname.DefaultText = ""
        Me.txt_lastname.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txt_lastname.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txt_lastname.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txt_lastname.DisabledState.Parent = Me.txt_lastname
        Me.txt_lastname.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txt_lastname.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txt_lastname.FocusedState.Parent = Me.txt_lastname
        Me.txt_lastname.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.txt_lastname.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txt_lastname.HoverState.Parent = Me.txt_lastname
        Me.txt_lastname.Location = New System.Drawing.Point(387, 70)
        Me.txt_lastname.Name = "txt_lastname"
        Me.txt_lastname.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txt_lastname.PlaceholderText = "Last Name"
        Me.txt_lastname.SelectedText = ""
        Me.txt_lastname.ShadowDecoration.Parent = Me.txt_lastname
        Me.txt_lastname.Size = New System.Drawing.Size(93, 36)
        Me.txt_lastname.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material
        Me.txt_lastname.TabIndex = 7
        Me.txt_lastname.TextOffset = New System.Drawing.Point(5, 0)
        '
        'txt_username
        '
        Me.txt_username.Animated = True
        Me.txt_username.BackColor = System.Drawing.Color.FromArgb(CType(CType(234, Byte), Integer), CType(CType(234, Byte), Integer), CType(CType(234, Byte), Integer))
        Me.txt_username.BorderThickness = 0
        Me.txt_username.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txt_username.DefaultText = ""
        Me.txt_username.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txt_username.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txt_username.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txt_username.DisabledState.Parent = Me.txt_username
        Me.txt_username.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txt_username.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txt_username.FocusedState.Parent = Me.txt_username
        Me.txt_username.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.txt_username.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txt_username.HoverState.Parent = Me.txt_username
        Me.txt_username.Location = New System.Drawing.Point(268, 112)
        Me.txt_username.Name = "txt_username"
        Me.txt_username.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txt_username.PlaceholderText = "Username"
        Me.txt_username.SelectedText = ""
        Me.txt_username.ShadowDecoration.Parent = Me.txt_username
        Me.txt_username.Size = New System.Drawing.Size(212, 36)
        Me.txt_username.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material
        Me.txt_username.TabIndex = 8
        Me.txt_username.TextOffset = New System.Drawing.Point(5, 0)
        '
        'txt_password
        '
        Me.txt_password.Animated = True
        Me.txt_password.BackColor = System.Drawing.Color.FromArgb(CType(CType(234, Byte), Integer), CType(CType(234, Byte), Integer), CType(CType(234, Byte), Integer))
        Me.txt_password.BorderThickness = 0
        Me.txt_password.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txt_password.DefaultText = ""
        Me.txt_password.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txt_password.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txt_password.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txt_password.DisabledState.Parent = Me.txt_password
        Me.txt_password.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txt_password.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txt_password.FocusedState.Parent = Me.txt_password
        Me.txt_password.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.txt_password.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txt_password.HoverState.Parent = Me.txt_password
        Me.txt_password.Location = New System.Drawing.Point(268, 154)
        Me.txt_password.Name = "txt_password"
        Me.txt_password.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txt_password.PlaceholderText = "Password"
        Me.txt_password.SelectedText = ""
        Me.txt_password.ShadowDecoration.Parent = Me.txt_password
        Me.txt_password.Size = New System.Drawing.Size(212, 36)
        Me.txt_password.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material
        Me.txt_password.TabIndex = 9
        Me.txt_password.TextOffset = New System.Drawing.Point(5, 0)
        Me.txt_password.UseSystemPasswordChar = True
        '
        'combo_role
        '
        Me.combo_role.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource
        Me.combo_role.BackColor = System.Drawing.Color.Transparent
        Me.combo_role.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.combo_role.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.combo_role.FocusedColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.combo_role.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.combo_role.FocusedState.Parent = Me.combo_role
        Me.combo_role.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.combo_role.ForeColor = System.Drawing.Color.DimGray
        Me.combo_role.HoverState.Parent = Me.combo_role
        Me.combo_role.ItemHeight = 30
        Me.combo_role.Items.AddRange(New Object() {"Administrator", "Manager", "Staff", "Labour"})
        Me.combo_role.ItemsAppearance.Parent = Me.combo_role
        Me.combo_role.Location = New System.Drawing.Point(268, 196)
        Me.combo_role.Name = "combo_role"
        Me.combo_role.ShadowDecoration.Parent = Me.combo_role
        Me.combo_role.Size = New System.Drawing.Size(212, 36)
        Me.combo_role.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material
        Me.combo_role.TabIndex = 10
        Me.combo_role.TextOffset = New System.Drawing.Point(5, 0)
        '
        'pic_box
        '
        Me.pic_box.FillColor = System.Drawing.Color.WhiteSmoke
        Me.pic_box.ImageRotate = 0.0!
        Me.pic_box.Location = New System.Drawing.Point(119, 95)
        Me.pic_box.Name = "pic_box"
        Me.pic_box.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle
        Me.pic_box.ShadowDecoration.Parent = Me.pic_box
        Me.pic_box.Size = New System.Drawing.Size(94, 94)
        Me.pic_box.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pic_box.TabIndex = 11
        Me.pic_box.TabStop = False
        '
        'Btn_Save
        '
        Me.Btn_Save.Animated = True
        Me.Btn_Save.AutoRoundedCorners = True
        Me.Btn_Save.BorderRadius = 18
        Me.Btn_Save.CheckedState.Parent = Me.Btn_Save
        Me.Btn_Save.CustomImages.Parent = Me.Btn_Save
        Me.Btn_Save.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.Btn_Save.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.Btn_Save.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.Btn_Save.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.Btn_Save.DisabledState.Parent = Me.Btn_Save
        Me.Btn_Save.FillColor = System.Drawing.Color.FromArgb(CType(CType(67, Byte), Integer), CType(CType(195, Byte), Integer), CType(CType(248, Byte), Integer))
        Me.Btn_Save.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        Me.Btn_Save.ForeColor = System.Drawing.Color.White
        Me.Btn_Save.HoverState.Parent = Me.Btn_Save
        Me.Btn_Save.Location = New System.Drawing.Point(522, 86)
        Me.Btn_Save.Name = "Btn_Save"
        Me.Btn_Save.ShadowDecoration.Parent = Me.Btn_Save
        Me.Btn_Save.Size = New System.Drawing.Size(99, 38)
        Me.Btn_Save.TabIndex = 12
        Me.Btn_Save.Text = "Save"
        '
        'Check_showpass
        '
        Me.Check_showpass.Animated = True
        Me.Check_showpass.CheckedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Check_showpass.CheckedState.BorderRadius = 2
        Me.Check_showpass.CheckedState.BorderThickness = 0
        Me.Check_showpass.CheckedState.FillColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Check_showpass.CheckedState.Parent = Me.Check_showpass
        Me.Check_showpass.Location = New System.Drawing.Point(461, 166)
        Me.Check_showpass.Name = "Check_showpass"
        Me.Check_showpass.ShadowDecoration.Parent = Me.Check_showpass
        Me.Check_showpass.Size = New System.Drawing.Size(15, 15)
        Me.Check_showpass.TabIndex = 13
        Me.Check_showpass.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(125, Byte), Integer), CType(CType(137, Byte), Integer), CType(CType(149, Byte), Integer))
        Me.Check_showpass.UncheckedState.BorderRadius = 2
        Me.Check_showpass.UncheckedState.BorderThickness = 0
        Me.Check_showpass.UncheckedState.FillColor = System.Drawing.Color.FromArgb(CType(CType(125, Byte), Integer), CType(CType(137, Byte), Integer), CType(CType(149, Byte), Integer))
        Me.Check_showpass.UncheckedState.Parent = Me.Check_showpass
        '
        'Guna2DragControl1
        '
        Me.Guna2DragControl1.TargetControl = Me
        '
        'btn_back
        '
        Me.btn_back.Animated = True
        Me.btn_back.AutoRoundedCorners = True
        Me.btn_back.BorderRadius = 13
        Me.btn_back.CheckedState.Parent = Me.btn_back
        Me.btn_back.CustomImages.Parent = Me.btn_back
        Me.btn_back.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btn_back.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btn_back.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btn_back.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btn_back.DisabledState.Parent = Me.btn_back
        Me.btn_back.FillColor = System.Drawing.Color.FromArgb(CType(CType(67, Byte), Integer), CType(CType(195, Byte), Integer), CType(CType(248, Byte), Integer))
        Me.btn_back.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        Me.btn_back.ForeColor = System.Drawing.Color.White
        Me.btn_back.HoverState.Parent = Me.btn_back
        Me.btn_back.Location = New System.Drawing.Point(29, 35)
        Me.btn_back.Name = "btn_back"
        Me.btn_back.ShadowDecoration.Parent = Me.btn_back
        Me.btn_back.Size = New System.Drawing.Size(28, 28)
        Me.btn_back.TabIndex = 15
        Me.btn_back.Text = "<"
        '
        'btn_browse
        '
        Me.btn_browse.BackColor = System.Drawing.Color.Transparent
        Me.btn_browse.FillColor = System.Drawing.Color.Transparent
        Me.btn_browse.Image = CType(resources.GetObject("btn_browse.Image"), System.Drawing.Image)
        Me.btn_browse.ImageRotate = 0.0!
        Me.btn_browse.Location = New System.Drawing.Point(206, 165)
        Me.btn_browse.Name = "btn_browse"
        Me.btn_browse.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle
        Me.btn_browse.ShadowDecoration.Parent = Me.btn_browse
        Me.btn_browse.Size = New System.Drawing.Size(22, 22)
        Me.btn_browse.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.btn_browse.TabIndex = 16
        Me.btn_browse.TabStop = False
        Me.btn_browse.UseTransparentBackground = True
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.BackgroundColor = System.Drawing.Color.White
        Me.DataGridView1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.DimGray
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.ControlDarkDark
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridView1.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column1, Me.Column2, Me.Column3, Me.Column4, Me.Column5, Me.Column6, Me.Column7, Me.colDelete})
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.Color.DimGray
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.ControlDarkDark
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DataGridView1.DefaultCellStyle = DataGridViewCellStyle3
        Me.DataGridView1.GridColor = System.Drawing.Color.DarkGray
        Me.DataGridView1.Location = New System.Drawing.Point(119, 268)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        Me.DataGridView1.RowHeadersVisible = False
        Me.DataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DataGridView1.Size = New System.Drawing.Size(502, 217)
        Me.DataGridView1.TabIndex = 17
        '
        'Column1
        '
        Me.Column1.HeaderText = "ID"
        Me.Column1.Name = "Column1"
        Me.Column1.ReadOnly = True
        Me.Column1.Visible = False
        '
        'Column2
        '
        Me.Column2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.Column2.HeaderText = "First Name"
        Me.Column2.Name = "Column2"
        Me.Column2.ReadOnly = True
        '
        'Column3
        '
        Me.Column3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.Column3.HeaderText = "Last Name"
        Me.Column3.Name = "Column3"
        Me.Column3.ReadOnly = True
        Me.Column3.Width = 97
        '
        'Column4
        '
        Me.Column4.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.Column4.HeaderText = "Username"
        Me.Column4.Name = "Column4"
        Me.Column4.ReadOnly = True
        Me.Column4.Width = 94
        '
        'Column5
        '
        Me.Column5.HeaderText = "Password"
        Me.Column5.Name = "Column5"
        Me.Column5.ReadOnly = True
        Me.Column5.Visible = False
        '
        'Column6
        '
        Me.Column6.HeaderText = "Role"
        Me.Column6.Name = "Column6"
        Me.Column6.ReadOnly = True
        Me.Column6.Visible = False
        '
        'Column7
        '
        Me.Column7.HeaderText = "PIC"
        Me.Column7.Name = "Column7"
        Me.Column7.ReadOnly = True
        Me.Column7.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.Column7.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.Column7.Visible = False
        '
        'colDelete
        '
        Me.colDelete.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.DarkOrange
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.White
        Me.colDelete.DefaultCellStyle = DataGridViewCellStyle2
        Me.colDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.colDelete.HeaderText = ""
        Me.colDelete.Name = "colDelete"
        Me.colDelete.ReadOnly = True
        Me.colDelete.Text = "Delete"
        Me.colDelete.UseColumnTextForButtonValue = True
        Me.colDelete.Width = 5
        '
        'Btn_Edit
        '
        Me.Btn_Edit.Animated = True
        Me.Btn_Edit.AutoRoundedCorners = True
        Me.Btn_Edit.BorderRadius = 18
        Me.Btn_Edit.CheckedState.Parent = Me.Btn_Edit
        Me.Btn_Edit.CustomImages.Parent = Me.Btn_Edit
        Me.Btn_Edit.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.Btn_Edit.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.Btn_Edit.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.Btn_Edit.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.Btn_Edit.DisabledState.Parent = Me.Btn_Edit
        Me.Btn_Edit.FillColor = System.Drawing.Color.FromArgb(CType(CType(67, Byte), Integer), CType(CType(195, Byte), Integer), CType(CType(248, Byte), Integer))
        Me.Btn_Edit.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        Me.Btn_Edit.ForeColor = System.Drawing.Color.White
        Me.Btn_Edit.HoverState.Parent = Me.Btn_Edit
        Me.Btn_Edit.Location = New System.Drawing.Point(522, 143)
        Me.Btn_Edit.Name = "Btn_Edit"
        Me.Btn_Edit.ShadowDecoration.Parent = Me.Btn_Edit
        Me.Btn_Edit.Size = New System.Drawing.Size(99, 38)
        Me.Btn_Edit.TabIndex = 18
        Me.Btn_Edit.Text = "Edit"
        '
        'manageuserfrm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(720, 509)
        Me.Controls.Add(Me.Btn_Edit)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.btn_browse)
        Me.Controls.Add(Me.btn_back)
        Me.Controls.Add(Me.Check_showpass)
        Me.Controls.Add(Me.Btn_Save)
        Me.Controls.Add(Me.pic_box)
        Me.Controls.Add(Me.combo_role)
        Me.Controls.Add(Me.txt_password)
        Me.Controls.Add(Me.txt_username)
        Me.Controls.Add(Me.txt_lastname)
        Me.Controls.Add(Me.txt_firstname)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "manageuserfrm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        CType(Me.pic_box, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btn_browse, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents txt_firstname As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents txt_lastname As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents txt_username As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents txt_password As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents combo_role As Guna.UI2.WinForms.Guna2ComboBox
    Friend WithEvents pic_box As Guna.UI2.WinForms.Guna2CirclePictureBox
    Friend WithEvents Btn_Save As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents Check_showpass As Guna.UI2.WinForms.Guna2CustomCheckBox
    Friend WithEvents Guna2DragControl1 As Guna.UI2.WinForms.Guna2DragControl
    Friend WithEvents btn_back As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents btn_browse As Guna.UI2.WinForms.Guna2CirclePictureBox
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents OpenFileDialog1 As System.Windows.Forms.OpenFileDialog
    Friend WithEvents Btn_Edit As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents Column1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column4 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column5 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column6 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column7 As System.Windows.Forms.DataGridViewImageColumn
    Friend WithEvents colDelete As System.Windows.Forms.DataGridViewButtonColumn
End Class
