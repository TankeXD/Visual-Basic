<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class manageProduct
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
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.btn_back = New Guna.UI2.WinForms.Guna2Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txt_productname = New Guna.UI2.WinForms.Guna2TextBox()
        Me.txt_productcode = New Guna.UI2.WinForms.Guna2TextBox()
        Me.combo_productGroup = New Guna.UI2.WinForms.Guna2ComboBox()
        Me.btm_addproductgroup = New Guna.UI2.WinForms.Guna2Button()
        Me.Guna2Button1 = New Guna.UI2.WinForms.Guna2Button()
        Me.combo_UOM = New Guna.UI2.WinForms.Guna2ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.btn_delete = New Guna.UI2.WinForms.Guna2Button()
        Me.btn_edit = New Guna.UI2.WinForms.Guna2Button()
        Me.btm_save = New Guna.UI2.WinForms.Guna2Button()
        Me.txt_price = New Guna.UI2.WinForms.Guna2TextBox()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column8 = New System.Windows.Forms.DataGridViewImageColumn()
        Me.pic_barcode = New Guna.UI2.WinForms.Guna2PictureBox()
        Me.txt_location = New Guna.UI2.WinForms.Guna2TextBox()
        Me.txt_search = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Panel1.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pic_barcode, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.btn_back)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(921, 60)
        Me.Panel1.TabIndex = 9
        '
        'btn_back
        '
        Me.btn_back.Animated = True
        Me.btn_back.AutoRoundedCorners = True
        Me.btn_back.BorderRadius = 13
        Me.btn_back.CheckedState.Parent = Me.btn_back
        Me.btn_back.Cursor = System.Windows.Forms.Cursors.Hand
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
        Me.btn_back.Location = New System.Drawing.Point(40, 16)
        Me.btn_back.Name = "btn_back"
        Me.btn_back.ShadowDecoration.Parent = Me.btn_back
        Me.btn_back.Size = New System.Drawing.Size(28, 28)
        Me.btn_back.TabIndex = 16
        Me.btn_back.Text = "<"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label1.Font = New System.Drawing.Font("Nirmala UI Semilight", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.DimGray
        Me.Label1.Location = New System.Drawing.Point(110, 7)
        Me.Label1.Name = "Label1"
        Me.Label1.Padding = New System.Windows.Forms.Padding(10)
        Me.Label1.Size = New System.Drawing.Size(186, 48)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "Manage Product"
        '
        'txt_productname
        '
        Me.txt_productname.Animated = True
        Me.txt_productname.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txt_productname.DefaultText = ""
        Me.txt_productname.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txt_productname.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txt_productname.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txt_productname.DisabledState.Parent = Me.txt_productname
        Me.txt_productname.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txt_productname.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txt_productname.FocusedState.Parent = Me.txt_productname
        Me.txt_productname.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.txt_productname.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txt_productname.HoverState.Parent = Me.txt_productname
        Me.txt_productname.Location = New System.Drawing.Point(467, 112)
        Me.txt_productname.Name = "txt_productname"
        Me.txt_productname.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txt_productname.PlaceholderText = "Product Name"
        Me.txt_productname.SelectedText = ""
        Me.txt_productname.ShadowDecoration.Parent = Me.txt_productname
        Me.txt_productname.Size = New System.Drawing.Size(267, 36)
        Me.txt_productname.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material
        Me.txt_productname.TabIndex = 1
        '
        'txt_productcode
        '
        Me.txt_productcode.Animated = True
        Me.txt_productcode.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txt_productcode.DefaultText = ""
        Me.txt_productcode.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txt_productcode.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txt_productcode.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txt_productcode.DisabledState.Parent = Me.txt_productcode
        Me.txt_productcode.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txt_productcode.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txt_productcode.FocusedState.Parent = Me.txt_productcode
        Me.txt_productcode.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.txt_productcode.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txt_productcode.HoverState.Parent = Me.txt_productcode
        Me.txt_productcode.Location = New System.Drawing.Point(115, 112)
        Me.txt_productcode.Margin = New System.Windows.Forms.Padding(80, 3, 3, 3)
        Me.txt_productcode.Name = "txt_productcode"
        Me.txt_productcode.Padding = New System.Windows.Forms.Padding(5, 0, 0, 0)
        Me.txt_productcode.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txt_productcode.PlaceholderText = "Product Code"
        Me.txt_productcode.SelectedText = ""
        Me.txt_productcode.ShadowDecoration.Parent = Me.txt_productcode
        Me.txt_productcode.Size = New System.Drawing.Size(267, 36)
        Me.txt_productcode.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material
        Me.txt_productcode.TabIndex = 0
        '
        'combo_productGroup
        '
        Me.combo_productGroup.BackColor = System.Drawing.Color.Transparent
        Me.combo_productGroup.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.combo_productGroup.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.combo_productGroup.FocusedColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.combo_productGroup.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.combo_productGroup.FocusedState.Parent = Me.combo_productGroup
        Me.combo_productGroup.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.combo_productGroup.ForeColor = System.Drawing.Color.DimGray
        Me.combo_productGroup.FormattingEnabled = True
        Me.combo_productGroup.HoverState.Parent = Me.combo_productGroup
        Me.combo_productGroup.ItemHeight = 30
        Me.combo_productGroup.ItemsAppearance.Parent = Me.combo_productGroup
        Me.combo_productGroup.Location = New System.Drawing.Point(115, 163)
        Me.combo_productGroup.Name = "combo_productGroup"
        Me.combo_productGroup.ShadowDecoration.Parent = Me.combo_productGroup
        Me.combo_productGroup.Size = New System.Drawing.Size(230, 36)
        Me.combo_productGroup.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material
        Me.combo_productGroup.TabIndex = 8
        Me.combo_productGroup.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'btm_addproductgroup
        '
        Me.btm_addproductgroup.Animated = True
        Me.btm_addproductgroup.AnimatedGIF = True
        Me.btm_addproductgroup.AutoRoundedCorners = True
        Me.btm_addproductgroup.BorderRadius = 14
        Me.btm_addproductgroup.CheckedState.Parent = Me.btm_addproductgroup
        Me.btm_addproductgroup.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btm_addproductgroup.CustomImages.Parent = Me.btm_addproductgroup
        Me.btm_addproductgroup.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btm_addproductgroup.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btm_addproductgroup.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btm_addproductgroup.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btm_addproductgroup.DisabledState.Parent = Me.btm_addproductgroup
        Me.btm_addproductgroup.FillColor = System.Drawing.Color.FromArgb(CType(CType(67, Byte), Integer), CType(CType(195, Byte), Integer), CType(CType(248, Byte), Integer))
        Me.btm_addproductgroup.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        Me.btm_addproductgroup.ForeColor = System.Drawing.Color.White
        Me.btm_addproductgroup.HoverState.Parent = Me.btm_addproductgroup
        Me.btm_addproductgroup.Location = New System.Drawing.Point(351, 167)
        Me.btm_addproductgroup.Name = "btm_addproductgroup"
        Me.btm_addproductgroup.ShadowDecoration.Parent = Me.btm_addproductgroup
        Me.btm_addproductgroup.Size = New System.Drawing.Size(31, 32)
        Me.btm_addproductgroup.TabIndex = 10
        Me.btm_addproductgroup.Text = "+"
        '
        'Guna2Button1
        '
        Me.Guna2Button1.Animated = True
        Me.Guna2Button1.AnimatedGIF = True
        Me.Guna2Button1.AutoRoundedCorners = True
        Me.Guna2Button1.BorderRadius = 14
        Me.Guna2Button1.CheckedState.Parent = Me.Guna2Button1
        Me.Guna2Button1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Guna2Button1.CustomImages.Parent = Me.Guna2Button1
        Me.Guna2Button1.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.Guna2Button1.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.Guna2Button1.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.Guna2Button1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.Guna2Button1.DisabledState.Parent = Me.Guna2Button1
        Me.Guna2Button1.FillColor = System.Drawing.Color.FromArgb(CType(CType(67, Byte), Integer), CType(CType(195, Byte), Integer), CType(CType(248, Byte), Integer))
        Me.Guna2Button1.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        Me.Guna2Button1.ForeColor = System.Drawing.Color.White
        Me.Guna2Button1.HoverState.Parent = Me.Guna2Button1
        Me.Guna2Button1.Location = New System.Drawing.Point(703, 163)
        Me.Guna2Button1.Name = "Guna2Button1"
        Me.Guna2Button1.ShadowDecoration.Parent = Me.Guna2Button1
        Me.Guna2Button1.Size = New System.Drawing.Size(31, 32)
        Me.Guna2Button1.TabIndex = 12
        Me.Guna2Button1.Text = "+"
        '
        'combo_UOM
        '
        Me.combo_UOM.BackColor = System.Drawing.Color.Transparent
        Me.combo_UOM.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.combo_UOM.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.combo_UOM.FocusedColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.combo_UOM.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.combo_UOM.FocusedState.Parent = Me.combo_UOM
        Me.combo_UOM.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.combo_UOM.ForeColor = System.Drawing.Color.DimGray
        Me.combo_UOM.FormattingEnabled = True
        Me.combo_UOM.HoverState.Parent = Me.combo_UOM
        Me.combo_UOM.ItemHeight = 30
        Me.combo_UOM.Items.AddRange(New Object() {"Nos"})
        Me.combo_UOM.ItemsAppearance.Parent = Me.combo_UOM
        Me.combo_UOM.Location = New System.Drawing.Point(467, 163)
        Me.combo_UOM.Name = "combo_UOM"
        Me.combo_UOM.ShadowDecoration.Parent = Me.combo_UOM
        Me.combo_UOM.Size = New System.Drawing.Size(230, 36)
        Me.combo_UOM.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material
        Me.combo_UOM.TabIndex = 11
        Me.combo_UOM.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.DarkGray
        Me.Label2.Location = New System.Drawing.Point(118, 172)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(40, 13)
        Me.Label2.TabIndex = 13
        Me.Label2.Text = "Group"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.DarkGray
        Me.Label3.Location = New System.Drawing.Point(474, 172)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(34, 13)
        Me.Label3.TabIndex = 14
        Me.Label3.Text = "UOM"
        '
        'btn_delete
        '
        Me.btn_delete.Animated = True
        Me.btn_delete.AnimatedGIF = True
        Me.btn_delete.BorderRadius = 5
        Me.btn_delete.CheckedState.Parent = Me.btn_delete
        Me.btn_delete.CustomImages.Parent = Me.btn_delete
        Me.btn_delete.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btn_delete.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btn_delete.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btn_delete.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btn_delete.DisabledState.Parent = Me.btn_delete
        Me.btn_delete.FillColor = System.Drawing.Color.FromArgb(CType(CType(67, Byte), Integer), CType(CType(195, Byte), Integer), CType(CType(248, Byte), Integer))
        Me.btn_delete.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        Me.btn_delete.ForeColor = System.Drawing.Color.White
        Me.btn_delete.HoverState.Parent = Me.btn_delete
        Me.btn_delete.Location = New System.Drawing.Point(656, 286)
        Me.btn_delete.Name = "btn_delete"
        Me.btn_delete.ShadowDecoration.Parent = Me.btn_delete
        Me.btn_delete.Size = New System.Drawing.Size(75, 32)
        Me.btn_delete.TabIndex = 22
        Me.btn_delete.Text = "Delete"
        '
        'btn_edit
        '
        Me.btn_edit.Animated = True
        Me.btn_edit.AnimatedGIF = True
        Me.btn_edit.BorderRadius = 5
        Me.btn_edit.CheckedState.Parent = Me.btn_edit
        Me.btn_edit.CustomImages.Parent = Me.btn_edit
        Me.btn_edit.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btn_edit.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btn_edit.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btn_edit.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btn_edit.DisabledState.Parent = Me.btn_edit
        Me.btn_edit.FillColor = System.Drawing.Color.FromArgb(CType(CType(67, Byte), Integer), CType(CType(195, Byte), Integer), CType(CType(248, Byte), Integer))
        Me.btn_edit.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        Me.btn_edit.ForeColor = System.Drawing.Color.White
        Me.btn_edit.HoverState.Parent = Me.btn_edit
        Me.btn_edit.Location = New System.Drawing.Point(564, 286)
        Me.btn_edit.Name = "btn_edit"
        Me.btn_edit.ShadowDecoration.Parent = Me.btn_edit
        Me.btn_edit.Size = New System.Drawing.Size(86, 32)
        Me.btn_edit.TabIndex = 21
        Me.btn_edit.Text = "Edit"
        '
        'btm_save
        '
        Me.btm_save.Animated = True
        Me.btm_save.AnimatedGIF = True
        Me.btm_save.BorderRadius = 5
        Me.btm_save.CheckedState.Parent = Me.btm_save
        Me.btm_save.CustomImages.Parent = Me.btm_save
        Me.btm_save.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btm_save.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btm_save.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btm_save.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btm_save.DisabledState.Parent = Me.btm_save
        Me.btm_save.FillColor = System.Drawing.Color.FromArgb(CType(CType(67, Byte), Integer), CType(CType(195, Byte), Integer), CType(CType(248, Byte), Integer))
        Me.btm_save.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        Me.btm_save.ForeColor = System.Drawing.Color.White
        Me.btm_save.HoverState.Parent = Me.btm_save
        Me.btm_save.Location = New System.Drawing.Point(472, 286)
        Me.btm_save.Name = "btm_save"
        Me.btm_save.ShadowDecoration.Parent = Me.btm_save
        Me.btm_save.Size = New System.Drawing.Size(86, 32)
        Me.btm_save.TabIndex = 20
        Me.btm_save.Text = "Save"
        '
        'txt_price
        '
        Me.txt_price.Animated = True
        Me.txt_price.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txt_price.DefaultText = ""
        Me.txt_price.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txt_price.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txt_price.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txt_price.DisabledState.Parent = Me.txt_price
        Me.txt_price.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txt_price.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txt_price.FocusedState.Parent = Me.txt_price
        Me.txt_price.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.txt_price.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txt_price.HoverState.Parent = Me.txt_price
        Me.txt_price.Location = New System.Drawing.Point(115, 216)
        Me.txt_price.Name = "txt_price"
        Me.txt_price.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txt_price.PlaceholderText = "Price"
        Me.txt_price.SelectedText = ""
        Me.txt_price.ShadowDecoration.Parent = Me.txt_price
        Me.txt_price.Size = New System.Drawing.Size(267, 36)
        Me.txt_price.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material
        Me.txt_price.TabIndex = 23
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.BackgroundColor = System.Drawing.Color.White
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.Color.DimGray
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.DimGray
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridView1.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle3
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column1, Me.Column2, Me.Column3, Me.Column4, Me.Column5, Me.Column6, Me.Column7, Me.Column8})
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle4.ForeColor = System.Drawing.Color.DimGray
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.ControlDarkDark
        DataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DataGridView1.DefaultCellStyle = DataGridViewCellStyle4
        Me.DataGridView1.Location = New System.Drawing.Point(115, 385)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.RowHeadersVisible = False
        Me.DataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DataGridView1.Size = New System.Drawing.Size(619, 208)
        Me.DataGridView1.TabIndex = 25
        '
        'Column1
        '
        Me.Column1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.Column1.HeaderText = "ID"
        Me.Column1.Name = "Column1"
        Me.Column1.ReadOnly = True
        Me.Column1.Visible = False
        '
        'Column2
        '
        Me.Column2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.Column2.HeaderText = "ProductCode"
        Me.Column2.Name = "Column2"
        Me.Column2.ReadOnly = True
        Me.Column2.Width = 112
        '
        'Column3
        '
        Me.Column3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.Column3.HeaderText = "ProductName"
        Me.Column3.Name = "Column3"
        Me.Column3.ReadOnly = True
        '
        'Column4
        '
        Me.Column4.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.Column4.HeaderText = "Group"
        Me.Column4.Name = "Column4"
        Me.Column4.ReadOnly = True
        Me.Column4.Width = 71
        '
        'Column5
        '
        Me.Column5.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.Column5.HeaderText = "UOM"
        Me.Column5.Name = "Column5"
        Me.Column5.ReadOnly = True
        Me.Column5.Width = 64
        '
        'Column6
        '
        Me.Column6.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.Column6.HeaderText = "Price"
        Me.Column6.Name = "Column6"
        Me.Column6.ReadOnly = True
        Me.Column6.Width = 62
        '
        'Column7
        '
        Me.Column7.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.Column7.HeaderText = "Location"
        Me.Column7.Name = "Column7"
        Me.Column7.ReadOnly = True
        Me.Column7.Width = 84
        '
        'Column8
        '
        Me.Column8.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.Column8.HeaderText = "Barcode"
        Me.Column8.Name = "Column8"
        Me.Column8.ReadOnly = True
        Me.Column8.Visible = False
        '
        'pic_barcode
        '
        Me.pic_barcode.BackColor = System.Drawing.Color.Transparent
        Me.pic_barcode.ImageRotate = 0.0!
        Me.pic_barcode.Location = New System.Drawing.Point(121, 276)
        Me.pic_barcode.Margin = New System.Windows.Forms.Padding(50, 3, 3, 3)
        Me.pic_barcode.Name = "pic_barcode"
        Me.pic_barcode.ShadowDecoration.Parent = Me.pic_barcode
        Me.pic_barcode.Size = New System.Drawing.Size(261, 42)
        Me.pic_barcode.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pic_barcode.TabIndex = 26
        Me.pic_barcode.TabStop = False
        Me.pic_barcode.UseTransparentBackground = True
        '
        'txt_location
        '
        Me.txt_location.Animated = True
        Me.txt_location.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txt_location.DefaultText = ""
        Me.txt_location.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txt_location.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txt_location.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txt_location.DisabledState.Parent = Me.txt_location
        Me.txt_location.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txt_location.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txt_location.FocusedState.Parent = Me.txt_location
        Me.txt_location.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.txt_location.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txt_location.HoverState.Parent = Me.txt_location
        Me.txt_location.Location = New System.Drawing.Point(467, 216)
        Me.txt_location.Name = "txt_location"
        Me.txt_location.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txt_location.PlaceholderText = "Location"
        Me.txt_location.SelectedText = ""
        Me.txt_location.ShadowDecoration.Parent = Me.txt_location
        Me.txt_location.Size = New System.Drawing.Size(267, 36)
        Me.txt_location.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material
        Me.txt_location.TabIndex = 27
        '
        'txt_search
        '
        Me.txt_search.Animated = True
        Me.txt_search.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txt_search.DefaultText = ""
        Me.txt_search.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txt_search.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txt_search.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txt_search.DisabledState.Parent = Me.txt_search
        Me.txt_search.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txt_search.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txt_search.FocusedState.Parent = Me.txt_search
        Me.txt_search.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.txt_search.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txt_search.HoverState.Parent = Me.txt_search
        Me.txt_search.Location = New System.Drawing.Point(115, 343)
        Me.txt_search.Name = "txt_search"
        Me.txt_search.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txt_search.PlaceholderText = "Search Here ..."
        Me.txt_search.SelectedText = ""
        Me.txt_search.ShadowDecoration.Parent = Me.txt_search
        Me.txt_search.Size = New System.Drawing.Size(267, 36)
        Me.txt_search.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material
        Me.txt_search.TabIndex = 28
        '
        'manageProduct
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(921, 605)
        Me.Controls.Add(Me.txt_search)
        Me.Controls.Add(Me.txt_location)
        Me.Controls.Add(Me.pic_barcode)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.txt_price)
        Me.Controls.Add(Me.btn_delete)
        Me.Controls.Add(Me.btn_edit)
        Me.Controls.Add(Me.btm_save)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Guna2Button1)
        Me.Controls.Add(Me.combo_UOM)
        Me.Controls.Add(Me.btm_addproductgroup)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.txt_productcode)
        Me.Controls.Add(Me.combo_productGroup)
        Me.Controls.Add(Me.txt_productname)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "manageProduct"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pic_barcode, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents btn_back As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txt_productname As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents txt_productcode As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents combo_productGroup As Guna.UI2.WinForms.Guna2ComboBox
    Friend WithEvents btm_addproductgroup As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents Guna2Button1 As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents combo_UOM As Guna.UI2.WinForms.Guna2ComboBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents btn_delete As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents btn_edit As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents btm_save As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents txt_price As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents pic_barcode As Guna.UI2.WinForms.Guna2PictureBox
    Friend WithEvents txt_location As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Column1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column4 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column5 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column6 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column7 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column8 As System.Windows.Forms.DataGridViewImageColumn
    Friend WithEvents txt_search As Guna.UI2.WinForms.Guna2TextBox
End Class
