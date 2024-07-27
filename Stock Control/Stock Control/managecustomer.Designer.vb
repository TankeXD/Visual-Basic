<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class managecustomer
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.btn_back = New Guna.UI2.WinForms.Guna2Button()
        Me.btm_save = New Guna.UI2.WinForms.Guna2Button()
        Me.btn_edit = New Guna.UI2.WinForms.Guna2Button()
        Me.btn_delete = New Guna.UI2.WinForms.Guna2Button()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column8 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column9 = New System.Windows.Forms.DataGridViewImageColumn()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.txt_panno = New Guna.UI2.WinForms.Guna2TextBox()
        Me.txt_gstno = New Guna.UI2.WinForms.Guna2TextBox()
        Me.txt_phone = New Guna.UI2.WinForms.Guna2TextBox()
        Me.txt_pincode = New Guna.UI2.WinForms.Guna2TextBox()
        Me.txt_address = New Guna.UI2.WinForms.Guna2TextBox()
        Me.txt_custname = New Guna.UI2.WinForms.Guna2TextBox()
        Me.txt_custID = New Guna.UI2.WinForms.Guna2TextBox()
        Me.pic_barcode = New Guna.UI2.WinForms.Guna2PictureBox()
        Me.txt_search = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Panel1.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TableLayoutPanel1.SuspendLayout()
        CType(Me.pic_barcode, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label1.Font = New System.Drawing.Font("Nirmala UI Semilight", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.DimGray
        Me.Label1.Location = New System.Drawing.Point(124, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Padding = New System.Windows.Forms.Padding(10)
        Me.Label1.Size = New System.Drawing.Size(203, 48)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "Manage Customer"
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.btn_back)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(921, 60)
        Me.Panel1.TabIndex = 8
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
        Me.btm_save.Location = New System.Drawing.Point(467, 273)
        Me.btm_save.Name = "btm_save"
        Me.btm_save.ShadowDecoration.Parent = Me.btm_save
        Me.btm_save.Size = New System.Drawing.Size(99, 32)
        Me.btm_save.TabIndex = 9
        Me.btm_save.Text = "Save"
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
        Me.btn_edit.Location = New System.Drawing.Point(591, 273)
        Me.btn_edit.Name = "btn_edit"
        Me.btn_edit.ShadowDecoration.Parent = Me.btn_edit
        Me.btn_edit.Size = New System.Drawing.Size(99, 32)
        Me.btn_edit.TabIndex = 10
        Me.btn_edit.Text = "Edit"
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
        Me.btn_delete.Location = New System.Drawing.Point(711, 273)
        Me.btn_delete.Name = "btn_delete"
        Me.btn_delete.ShadowDecoration.Parent = Me.btn_delete
        Me.btn_delete.Size = New System.Drawing.Size(99, 32)
        Me.btn_delete.TabIndex = 11
        Me.btn_delete.Text = "Delete"
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.BackgroundColor = System.Drawing.Color.White
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.DimGray
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.DimGray
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridView1.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column1, Me.Column2, Me.Column3, Me.Column4, Me.Column5, Me.Column6, Me.Column7, Me.Column8, Me.Column9})
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.DimGray
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.ControlDarkDark
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DataGridView1.DefaultCellStyle = DataGridViewCellStyle2
        Me.DataGridView1.Location = New System.Drawing.Point(129, 381)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.RowHeadersVisible = False
        Me.DataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DataGridView1.Size = New System.Drawing.Size(681, 212)
        Me.DataGridView1.TabIndex = 12
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
        Me.Column2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.Column2.HeaderText = "CustomerID"
        Me.Column2.Name = "Column2"
        Me.Column2.ReadOnly = True
        Me.Column2.Width = 105
        '
        'Column3
        '
        Me.Column3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.Column3.HeaderText = "CustomerName"
        Me.Column3.Name = "Column3"
        Me.Column3.ReadOnly = True
        '
        'Column4
        '
        Me.Column4.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.Column4.HeaderText = "Address"
        Me.Column4.Name = "Column4"
        Me.Column4.ReadOnly = True
        Me.Column4.Width = 82
        '
        'Column5
        '
        Me.Column5.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.Column5.HeaderText = "Pincode"
        Me.Column5.Name = "Column5"
        Me.Column5.ReadOnly = True
        Me.Column5.Visible = False
        '
        'Column6
        '
        Me.Column6.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.Column6.HeaderText = "Phone"
        Me.Column6.Name = "Column6"
        Me.Column6.ReadOnly = True
        Me.Column6.Visible = False
        '
        'Column7
        '
        Me.Column7.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.Column7.HeaderText = "GST NO"
        Me.Column7.Name = "Column7"
        Me.Column7.ReadOnly = True
        Me.Column7.Width = 80
        '
        'Column8
        '
        Me.Column8.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.Column8.HeaderText = "PAN NO"
        Me.Column8.Name = "Column8"
        Me.Column8.ReadOnly = True
        Me.Column8.Width = 83
        '
        'Column9
        '
        Me.Column9.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.Column9.HeaderText = "BARCODE"
        Me.Column9.Name = "Column9"
        Me.Column9.ReadOnly = True
        Me.Column9.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.Column9.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.Column9.Visible = False
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.ColumnCount = 2
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.txt_panno, 0, 3)
        Me.TableLayoutPanel1.Controls.Add(Me.txt_gstno, 1, 2)
        Me.TableLayoutPanel1.Controls.Add(Me.txt_phone, 0, 2)
        Me.TableLayoutPanel1.Controls.Add(Me.txt_pincode, 1, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.txt_address, 0, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.txt_custname, 1, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.txt_custID, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.pic_barcode, 1, 3)
        Me.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(0, 60)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 4
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(921, 186)
        Me.TableLayoutPanel1.TabIndex = 13
        '
        'txt_panno
        '
        Me.txt_panno.Animated = True
        Me.txt_panno.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txt_panno.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txt_panno.DefaultText = ""
        Me.txt_panno.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txt_panno.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txt_panno.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txt_panno.DisabledState.Parent = Me.txt_panno
        Me.txt_panno.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txt_panno.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txt_panno.FocusedState.Parent = Me.txt_panno
        Me.txt_panno.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.txt_panno.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txt_panno.HoverState.Parent = Me.txt_panno
        Me.txt_panno.Location = New System.Drawing.Point(140, 141)
        Me.txt_panno.Margin = New System.Windows.Forms.Padding(140, 3, 3, 3)
        Me.txt_panno.MaxLength = 15
        Me.txt_panno.Name = "txt_panno"
        Me.txt_panno.Padding = New System.Windows.Forms.Padding(5, 0, 0, 0)
        Me.txt_panno.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txt_panno.PlaceholderText = "PAN NO"
        Me.txt_panno.SelectedText = ""
        Me.txt_panno.ShadowDecoration.Parent = Me.txt_panno
        Me.txt_panno.Size = New System.Drawing.Size(267, 36)
        Me.txt_panno.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material
        Me.txt_panno.TabIndex = 6
        '
        'txt_gstno
        '
        Me.txt_gstno.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txt_gstno.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txt_gstno.DefaultText = ""
        Me.txt_gstno.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txt_gstno.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txt_gstno.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txt_gstno.DisabledState.Parent = Me.txt_gstno
        Me.txt_gstno.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txt_gstno.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txt_gstno.FocusedState.Parent = Me.txt_gstno
        Me.txt_gstno.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.txt_gstno.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txt_gstno.HoverState.Parent = Me.txt_gstno
        Me.txt_gstno.Location = New System.Drawing.Point(510, 95)
        Me.txt_gstno.Margin = New System.Windows.Forms.Padding(50, 3, 3, 3)
        Me.txt_gstno.MaxLength = 15
        Me.txt_gstno.Name = "txt_gstno"
        Me.txt_gstno.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txt_gstno.PlaceholderText = "GST NO"
        Me.txt_gstno.SelectedText = ""
        Me.txt_gstno.ShadowDecoration.Parent = Me.txt_gstno
        Me.txt_gstno.Size = New System.Drawing.Size(300, 36)
        Me.txt_gstno.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material
        Me.txt_gstno.TabIndex = 5
        '
        'txt_phone
        '
        Me.txt_phone.Animated = True
        Me.txt_phone.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txt_phone.DefaultText = ""
        Me.txt_phone.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txt_phone.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txt_phone.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txt_phone.DisabledState.Parent = Me.txt_phone
        Me.txt_phone.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txt_phone.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txt_phone.FocusedState.Parent = Me.txt_phone
        Me.txt_phone.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.txt_phone.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txt_phone.HoverState.Parent = Me.txt_phone
        Me.txt_phone.Location = New System.Drawing.Point(140, 95)
        Me.txt_phone.Margin = New System.Windows.Forms.Padding(140, 3, 3, 3)
        Me.txt_phone.Name = "txt_phone"
        Me.txt_phone.Padding = New System.Windows.Forms.Padding(5, 0, 0, 0)
        Me.txt_phone.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txt_phone.PlaceholderText = "Phone"
        Me.txt_phone.SelectedText = ""
        Me.txt_phone.ShadowDecoration.Parent = Me.txt_phone
        Me.txt_phone.Size = New System.Drawing.Size(267, 36)
        Me.txt_phone.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material
        Me.txt_phone.TabIndex = 4
        '
        'txt_pincode
        '
        Me.txt_pincode.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txt_pincode.DefaultText = ""
        Me.txt_pincode.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txt_pincode.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txt_pincode.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txt_pincode.DisabledState.Parent = Me.txt_pincode
        Me.txt_pincode.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txt_pincode.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txt_pincode.FocusedState.Parent = Me.txt_pincode
        Me.txt_pincode.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.txt_pincode.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txt_pincode.HoverState.Parent = Me.txt_pincode
        Me.txt_pincode.Location = New System.Drawing.Point(510, 49)
        Me.txt_pincode.Margin = New System.Windows.Forms.Padding(50, 3, 3, 3)
        Me.txt_pincode.MaxLength = 6
        Me.txt_pincode.Name = "txt_pincode"
        Me.txt_pincode.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txt_pincode.PlaceholderText = "Pincode"
        Me.txt_pincode.SelectedText = ""
        Me.txt_pincode.ShadowDecoration.Parent = Me.txt_pincode
        Me.txt_pincode.Size = New System.Drawing.Size(300, 36)
        Me.txt_pincode.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material
        Me.txt_pincode.TabIndex = 3
        '
        'txt_address
        '
        Me.txt_address.Animated = True
        Me.txt_address.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txt_address.DefaultText = ""
        Me.txt_address.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txt_address.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txt_address.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txt_address.DisabledState.Parent = Me.txt_address
        Me.txt_address.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txt_address.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txt_address.FocusedState.Parent = Me.txt_address
        Me.txt_address.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.txt_address.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txt_address.HoverState.Parent = Me.txt_address
        Me.txt_address.Location = New System.Drawing.Point(140, 49)
        Me.txt_address.Margin = New System.Windows.Forms.Padding(140, 3, 3, 3)
        Me.txt_address.Name = "txt_address"
        Me.txt_address.Padding = New System.Windows.Forms.Padding(5, 0, 0, 0)
        Me.txt_address.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txt_address.PlaceholderText = "Address"
        Me.txt_address.SelectedText = ""
        Me.txt_address.ShadowDecoration.Parent = Me.txt_address
        Me.txt_address.Size = New System.Drawing.Size(267, 36)
        Me.txt_address.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material
        Me.txt_address.TabIndex = 2
        '
        'txt_custname
        '
        Me.txt_custname.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txt_custname.DefaultText = ""
        Me.txt_custname.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txt_custname.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txt_custname.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txt_custname.DisabledState.Parent = Me.txt_custname
        Me.txt_custname.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txt_custname.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txt_custname.FocusedState.Parent = Me.txt_custname
        Me.txt_custname.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.txt_custname.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txt_custname.HoverState.Parent = Me.txt_custname
        Me.txt_custname.Location = New System.Drawing.Point(510, 3)
        Me.txt_custname.Margin = New System.Windows.Forms.Padding(50, 3, 3, 3)
        Me.txt_custname.Name = "txt_custname"
        Me.txt_custname.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txt_custname.PlaceholderText = "Customer Name"
        Me.txt_custname.SelectedText = ""
        Me.txt_custname.ShadowDecoration.Parent = Me.txt_custname
        Me.txt_custname.Size = New System.Drawing.Size(300, 36)
        Me.txt_custname.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material
        Me.txt_custname.TabIndex = 1
        '
        'txt_custID
        '
        Me.txt_custID.Animated = True
        Me.txt_custID.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txt_custID.DefaultText = ""
        Me.txt_custID.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txt_custID.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txt_custID.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txt_custID.DisabledState.Parent = Me.txt_custID
        Me.txt_custID.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txt_custID.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txt_custID.FocusedState.Parent = Me.txt_custID
        Me.txt_custID.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.txt_custID.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txt_custID.HoverState.Parent = Me.txt_custID
        Me.txt_custID.Location = New System.Drawing.Point(140, 3)
        Me.txt_custID.Margin = New System.Windows.Forms.Padding(140, 3, 3, 3)
        Me.txt_custID.Name = "txt_custID"
        Me.txt_custID.Padding = New System.Windows.Forms.Padding(5, 0, 0, 0)
        Me.txt_custID.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txt_custID.PlaceholderText = "Customer ID"
        Me.txt_custID.SelectedText = ""
        Me.txt_custID.ShadowDecoration.Parent = Me.txt_custID
        Me.txt_custID.Size = New System.Drawing.Size(267, 36)
        Me.txt_custID.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material
        Me.txt_custID.TabIndex = 0
        '
        'pic_barcode
        '
        Me.pic_barcode.BackColor = System.Drawing.Color.Transparent
        Me.pic_barcode.ImageRotate = 0.0!
        Me.pic_barcode.Location = New System.Drawing.Point(510, 141)
        Me.pic_barcode.Margin = New System.Windows.Forms.Padding(50, 3, 3, 3)
        Me.pic_barcode.Name = "pic_barcode"
        Me.pic_barcode.ShadowDecoration.Parent = Me.pic_barcode
        Me.pic_barcode.Size = New System.Drawing.Size(300, 42)
        Me.pic_barcode.TabIndex = 7
        Me.pic_barcode.TabStop = False
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
        Me.txt_search.Location = New System.Drawing.Point(129, 327)
        Me.txt_search.Margin = New System.Windows.Forms.Padding(80, 3, 3, 3)
        Me.txt_search.Name = "txt_search"
        Me.txt_search.Padding = New System.Windows.Forms.Padding(5, 0, 0, 0)
        Me.txt_search.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txt_search.PlaceholderText = "Search...."
        Me.txt_search.SelectedText = ""
        Me.txt_search.ShadowDecoration.Parent = Me.txt_search
        Me.txt_search.Size = New System.Drawing.Size(278, 36)
        Me.txt_search.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material
        Me.txt_search.TabIndex = 14
        '
        'managecustomer
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(921, 605)
        Me.Controls.Add(Me.txt_search)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.btn_delete)
        Me.Controls.Add(Me.btn_edit)
        Me.Controls.Add(Me.btm_save)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "managecustomer"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TableLayoutPanel1.ResumeLayout(False)
        CType(Me.pic_barcode, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents btm_save As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents btn_edit As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents btn_delete As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents TableLayoutPanel1 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents txt_panno As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents txt_gstno As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents txt_phone As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents txt_pincode As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents txt_address As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents txt_custname As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents txt_custID As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents pic_barcode As Guna.UI2.WinForms.Guna2PictureBox
    Friend WithEvents btn_back As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents Column1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column4 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column5 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column6 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column7 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column8 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column9 As System.Windows.Forms.DataGridViewImageColumn
    Friend WithEvents txt_search As Guna.UI2.WinForms.Guna2TextBox
End Class
