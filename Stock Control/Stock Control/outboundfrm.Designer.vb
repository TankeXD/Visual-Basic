<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class outboundfrm
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
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.btn_back = New Guna.UI2.WinForms.Guna2Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btm_save = New Guna.UI2.WinForms.Guna2Button()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column8 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.txt_qty = New Guna.UI2.WinForms.Guna2TextBox()
        Me.txt_proname = New Guna.UI2.WinForms.Guna2TextBox()
        Me.txt_outbound = New Guna.UI2.WinForms.Guna2TextBox()
        Me.datetime_picker = New Guna.UI2.WinForms.Guna2DateTimePicker()
        Me.txt_search = New Guna.UI2.WinForms.Guna2Button()
        Me.Btn_Delete = New Guna.UI2.WinForms.Guna2Button()
        Me.Btn_Edit = New Guna.UI2.WinForms.Guna2Button()
        Me.Btn_Print = New Guna.UI2.WinForms.Guna2Button()
        Me.Panel1.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.Panel1.TabIndex = 10
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
        Me.Label1.Location = New System.Drawing.Point(122, 7)
        Me.Label1.Name = "Label1"
        Me.Label1.Padding = New System.Windows.Forms.Padding(10)
        Me.Label1.Size = New System.Drawing.Size(211, 48)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "Stock Outbounding"
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
        Me.btm_save.Location = New System.Drawing.Point(214, 506)
        Me.btm_save.Name = "btm_save"
        Me.btm_save.ShadowDecoration.Parent = Me.btm_save
        Me.btm_save.Size = New System.Drawing.Size(104, 32)
        Me.btm_save.TabIndex = 36
        Me.btm_save.Text = "&Save"
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.BackgroundColor = System.Drawing.Color.White
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.Gray
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.DimGray
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridView1.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column1, Me.Column2, Me.Column6, Me.Column5, Me.Column8, Me.Column4, Me.Column3})
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.Gray
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.ControlDarkDark
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DataGridView1.DefaultCellStyle = DataGridViewCellStyle2
        Me.DataGridView1.GridColor = System.Drawing.SystemColors.ControlLight
        Me.DataGridView1.Location = New System.Drawing.Point(104, 193)
        Me.DataGridView1.Margin = New System.Windows.Forms.Padding(5)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.RowHeadersVisible = False
        Me.DataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DataGridView1.Size = New System.Drawing.Size(713, 294)
        Me.DataGridView1.TabIndex = 34
        '
        'Column1
        '
        Me.Column1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.Column1.HeaderText = "Product Code"
        Me.Column1.Name = "Column1"
        Me.Column1.Width = 116
        '
        'Column2
        '
        Me.Column2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.Column2.HeaderText = "Product Name"
        Me.Column2.Name = "Column2"
        '
        'Column6
        '
        Me.Column6.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.Column6.HeaderText = "Group"
        Me.Column6.Name = "Column6"
        Me.Column6.Width = 71
        '
        'Column5
        '
        Me.Column5.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.Column5.HeaderText = "UOM"
        Me.Column5.Name = "Column5"
        Me.Column5.Width = 64
        '
        'Column8
        '
        Me.Column8.HeaderText = "Stock"
        Me.Column8.Name = "Column8"
        '
        'Column4
        '
        Me.Column4.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.Column4.HeaderText = "Quantity"
        Me.Column4.Name = "Column4"
        Me.Column4.Width = 86
        '
        'Column3
        '
        Me.Column3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.Column3.HeaderText = "Balance Stock"
        Me.Column3.Name = "Column3"
        Me.Column3.Width = 106
        '
        'txt_qty
        '
        Me.txt_qty.Animated = True
        Me.txt_qty.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txt_qty.DefaultText = ""
        Me.txt_qty.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txt_qty.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txt_qty.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txt_qty.DisabledState.Parent = Me.txt_qty
        Me.txt_qty.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txt_qty.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txt_qty.FocusedState.Parent = Me.txt_qty
        Me.txt_qty.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.txt_qty.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txt_qty.HoverState.Parent = Me.txt_qty
        Me.txt_qty.Location = New System.Drawing.Point(418, 127)
        Me.txt_qty.Margin = New System.Windows.Forms.Padding(80, 3, 3, 3)
        Me.txt_qty.Name = "txt_qty"
        Me.txt_qty.Padding = New System.Windows.Forms.Padding(5, 0, 0, 0)
        Me.txt_qty.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txt_qty.PlaceholderText = "Quantity"
        Me.txt_qty.SelectedText = ""
        Me.txt_qty.ShadowDecoration.Parent = Me.txt_qty
        Me.txt_qty.Size = New System.Drawing.Size(267, 36)
        Me.txt_qty.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material
        Me.txt_qty.TabIndex = 33
        '
        'txt_proname
        '
        Me.txt_proname.Animated = True
        Me.txt_proname.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.txt_proname.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource
        Me.txt_proname.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txt_proname.DefaultText = ""
        Me.txt_proname.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txt_proname.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txt_proname.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txt_proname.DisabledState.Parent = Me.txt_proname
        Me.txt_proname.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txt_proname.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txt_proname.FocusedState.Parent = Me.txt_proname
        Me.txt_proname.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.txt_proname.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txt_proname.HoverState.Parent = Me.txt_proname
        Me.txt_proname.Location = New System.Drawing.Point(106, 127)
        Me.txt_proname.Margin = New System.Windows.Forms.Padding(80, 3, 3, 3)
        Me.txt_proname.Name = "txt_proname"
        Me.txt_proname.Padding = New System.Windows.Forms.Padding(5, 0, 0, 0)
        Me.txt_proname.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txt_proname.PlaceholderText = "Product Name / Code"
        Me.txt_proname.SelectedText = ""
        Me.txt_proname.ShadowDecoration.Parent = Me.txt_proname
        Me.txt_proname.Size = New System.Drawing.Size(267, 36)
        Me.txt_proname.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material
        Me.txt_proname.TabIndex = 32
        '
        'txt_outbound
        '
        Me.txt_outbound.Animated = True
        Me.txt_outbound.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txt_outbound.DefaultText = ""
        Me.txt_outbound.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txt_outbound.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txt_outbound.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txt_outbound.DisabledState.Parent = Me.txt_outbound
        Me.txt_outbound.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txt_outbound.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txt_outbound.FocusedState.Parent = Me.txt_outbound
        Me.txt_outbound.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.txt_outbound.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txt_outbound.HoverState.Parent = Me.txt_outbound
        Me.txt_outbound.Location = New System.Drawing.Point(104, 75)
        Me.txt_outbound.Margin = New System.Windows.Forms.Padding(80, 3, 3, 3)
        Me.txt_outbound.Name = "txt_outbound"
        Me.txt_outbound.Padding = New System.Windows.Forms.Padding(5, 0, 0, 0)
        Me.txt_outbound.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txt_outbound.PlaceholderText = "Outbound No"
        Me.txt_outbound.SelectedText = ""
        Me.txt_outbound.ShadowDecoration.Parent = Me.txt_outbound
        Me.txt_outbound.Size = New System.Drawing.Size(267, 36)
        Me.txt_outbound.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material
        Me.txt_outbound.TabIndex = 31
        '
        'datetime_picker
        '
        Me.datetime_picker.CheckedState.Parent = Me.datetime_picker
        Me.datetime_picker.FillColor = System.Drawing.Color.White
        Me.datetime_picker.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.datetime_picker.ForeColor = System.Drawing.Color.DimGray
        Me.datetime_picker.Format = System.Windows.Forms.DateTimePickerFormat.[Long]
        Me.datetime_picker.HoverState.Parent = Me.datetime_picker
        Me.datetime_picker.IndicateFocus = True
        Me.datetime_picker.Location = New System.Drawing.Point(433, 75)
        Me.datetime_picker.MaxDate = New Date(2040, 12, 31, 0, 0, 0, 0)
        Me.datetime_picker.MinDate = New Date(2000, 1, 1, 0, 0, 0, 0)
        Me.datetime_picker.Name = "datetime_picker"
        Me.datetime_picker.ShadowDecoration.Parent = Me.datetime_picker
        Me.datetime_picker.Size = New System.Drawing.Size(252, 36)
        Me.datetime_picker.TabIndex = 30
        Me.datetime_picker.Value = New Date(2021, 6, 15, 12, 45, 55, 655)
        '
        'txt_search
        '
        Me.txt_search.Animated = True
        Me.txt_search.AnimatedGIF = True
        Me.txt_search.BorderRadius = 5
        Me.txt_search.CheckedState.Parent = Me.txt_search
        Me.txt_search.CustomImages.Parent = Me.txt_search
        Me.txt_search.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.txt_search.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.txt_search.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.txt_search.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.txt_search.DisabledState.Parent = Me.txt_search
        Me.txt_search.FillColor = System.Drawing.Color.FromArgb(CType(CType(67, Byte), Integer), CType(CType(195, Byte), Integer), CType(CType(248, Byte), Integer))
        Me.txt_search.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        Me.txt_search.ForeColor = System.Drawing.Color.White
        Me.txt_search.HoverState.Parent = Me.txt_search
        Me.txt_search.Location = New System.Drawing.Point(340, 506)
        Me.txt_search.Name = "txt_search"
        Me.txt_search.ShadowDecoration.Parent = Me.txt_search
        Me.txt_search.Size = New System.Drawing.Size(104, 32)
        Me.txt_search.TabIndex = 37
        Me.txt_search.Text = "Se&arch"
        '
        'Btn_Delete
        '
        Me.Btn_Delete.Animated = True
        Me.Btn_Delete.AnimatedGIF = True
        Me.Btn_Delete.BorderRadius = 5
        Me.Btn_Delete.CheckedState.Parent = Me.Btn_Delete
        Me.Btn_Delete.CustomImages.Parent = Me.Btn_Delete
        Me.Btn_Delete.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.Btn_Delete.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.Btn_Delete.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.Btn_Delete.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.Btn_Delete.DisabledState.Parent = Me.Btn_Delete
        Me.Btn_Delete.FillColor = System.Drawing.Color.FromArgb(CType(CType(67, Byte), Integer), CType(CType(195, Byte), Integer), CType(CType(248, Byte), Integer))
        Me.Btn_Delete.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        Me.Btn_Delete.ForeColor = System.Drawing.Color.White
        Me.Btn_Delete.HoverState.Parent = Me.Btn_Delete
        Me.Btn_Delete.Location = New System.Drawing.Point(468, 506)
        Me.Btn_Delete.Name = "Btn_Delete"
        Me.Btn_Delete.ShadowDecoration.Parent = Me.Btn_Delete
        Me.Btn_Delete.Size = New System.Drawing.Size(104, 32)
        Me.Btn_Delete.TabIndex = 38
        Me.Btn_Delete.Text = "&Delete"
        '
        'Btn_Edit
        '
        Me.Btn_Edit.Animated = True
        Me.Btn_Edit.AnimatedGIF = True
        Me.Btn_Edit.BorderRadius = 5
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
        Me.Btn_Edit.Location = New System.Drawing.Point(591, 506)
        Me.Btn_Edit.Name = "Btn_Edit"
        Me.Btn_Edit.ShadowDecoration.Parent = Me.Btn_Edit
        Me.Btn_Edit.Size = New System.Drawing.Size(104, 32)
        Me.Btn_Edit.TabIndex = 39
        Me.Btn_Edit.Text = "&Edit"
        '
        'Btn_Print
        '
        Me.Btn_Print.Animated = True
        Me.Btn_Print.AnimatedGIF = True
        Me.Btn_Print.BorderRadius = 5
        Me.Btn_Print.CheckedState.Parent = Me.Btn_Print
        Me.Btn_Print.CustomImages.Parent = Me.Btn_Print
        Me.Btn_Print.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.Btn_Print.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.Btn_Print.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.Btn_Print.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.Btn_Print.DisabledState.Parent = Me.Btn_Print
        Me.Btn_Print.FillColor = System.Drawing.Color.FromArgb(CType(CType(67, Byte), Integer), CType(CType(195, Byte), Integer), CType(CType(248, Byte), Integer))
        Me.Btn_Print.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        Me.Btn_Print.ForeColor = System.Drawing.Color.White
        Me.Btn_Print.HoverState.Parent = Me.Btn_Print
        Me.Btn_Print.Location = New System.Drawing.Point(710, 506)
        Me.Btn_Print.Name = "Btn_Print"
        Me.Btn_Print.ShadowDecoration.Parent = Me.Btn_Print
        Me.Btn_Print.Size = New System.Drawing.Size(104, 32)
        Me.Btn_Print.TabIndex = 40
        Me.Btn_Print.Text = "&Print"
        '
        'outboundfrm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(921, 605)
        Me.Controls.Add(Me.Btn_Print)
        Me.Controls.Add(Me.Btn_Edit)
        Me.Controls.Add(Me.Btn_Delete)
        Me.Controls.Add(Me.txt_search)
        Me.Controls.Add(Me.btm_save)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.txt_qty)
        Me.Controls.Add(Me.txt_proname)
        Me.Controls.Add(Me.txt_outbound)
        Me.Controls.Add(Me.datetime_picker)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "outboundfrm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents btn_back As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents btm_save As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents txt_qty As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents txt_proname As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents txt_outbound As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents datetime_picker As Guna.UI2.WinForms.Guna2DateTimePicker
    Friend WithEvents Column1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column6 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column5 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column8 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column4 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents txt_search As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents Btn_Delete As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents Btn_Edit As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents Btn_Print As Guna.UI2.WinForms.Guna2Button
End Class
