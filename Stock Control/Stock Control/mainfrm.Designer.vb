<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class mainfrm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(mainfrm))
        Me.Guna2DragControl1 = New Guna.UI2.WinForms.Guna2DragControl(Me.components)
        Me.Guna2Panel1 = New Guna.UI2.WinForms.Guna2Panel()
        Me.lbl_role = New System.Windows.Forms.Label()
        Me.lbl_user = New System.Windows.Forms.Label()
        Me.Guna2ControlBox2 = New Guna.UI2.WinForms.Guna2ControlBox()
        Me.Guna2ControlBox1 = New Guna.UI2.WinForms.Guna2ControlBox()
        Me.Guna2CirclePictureBox2 = New Guna.UI2.WinForms.Guna2CirclePictureBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.main_picturebox = New Guna.UI2.WinForms.Guna2CirclePictureBox()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.btn_outbound = New Guna.UI2.WinForms.Guna2Button()
        Me.btn_inbound = New Guna.UI2.WinForms.Guna2Button()
        Me.btn_stockmaster = New Guna.UI2.WinForms.Guna2Button()
        Me.btn_ProductMaster = New Guna.UI2.WinForms.Guna2Button()
        Me.btn_customerMaster = New Guna.UI2.WinForms.Guna2Button()
        Me.btn_Dashboard = New Guna.UI2.WinForms.Guna2Button()
        Me.btn_logout = New Guna.UI2.WinForms.Guna2Button()
        Me.btn_manageuser = New Guna.UI2.WinForms.Guna2Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Guna2Panel1.SuspendLayout()
        CType(Me.Guna2CirclePictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.main_picturebox, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Guna2DragControl1
        '
        Me.Guna2DragControl1.TargetControl = Me.Guna2Panel1
        '
        'Guna2Panel1
        '
        Me.Guna2Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(67, Byte), Integer), CType(CType(195, Byte), Integer), CType(CType(248, Byte), Integer))
        Me.Guna2Panel1.Controls.Add(Me.lbl_role)
        Me.Guna2Panel1.Controls.Add(Me.lbl_user)
        Me.Guna2Panel1.Controls.Add(Me.Guna2ControlBox2)
        Me.Guna2Panel1.Controls.Add(Me.Guna2ControlBox1)
        Me.Guna2Panel1.Controls.Add(Me.Guna2CirclePictureBox2)
        Me.Guna2Panel1.Controls.Add(Me.Label1)
        Me.Guna2Panel1.Controls.Add(Me.main_picturebox)
        Me.Guna2Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Guna2Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Guna2Panel1.Name = "Guna2Panel1"
        Me.Guna2Panel1.ShadowDecoration.Parent = Me.Guna2Panel1
        Me.Guna2Panel1.Size = New System.Drawing.Size(1107, 56)
        Me.Guna2Panel1.TabIndex = 1
        '
        'lbl_role
        '
        Me.lbl_role.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lbl_role.AutoSize = True
        Me.lbl_role.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.lbl_role.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_role.ForeColor = System.Drawing.Color.White
        Me.lbl_role.Location = New System.Drawing.Point(930, 30)
        Me.lbl_role.Name = "lbl_role"
        Me.lbl_role.Size = New System.Drawing.Size(79, 15)
        Me.lbl_role.TabIndex = 10
        Me.lbl_role.Text = "Stock Control"
        '
        'lbl_user
        '
        Me.lbl_user.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lbl_user.AutoSize = True
        Me.lbl_user.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.lbl_user.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_user.ForeColor = System.Drawing.Color.White
        Me.lbl_user.Location = New System.Drawing.Point(930, 12)
        Me.lbl_user.Name = "lbl_user"
        Me.lbl_user.Size = New System.Drawing.Size(79, 15)
        Me.lbl_user.TabIndex = 9
        Me.lbl_user.Text = "Stock Control"
        '
        'Guna2ControlBox2
        '
        Me.Guna2ControlBox2.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Guna2ControlBox2.Animated = True
        Me.Guna2ControlBox2.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Guna2ControlBox2.FillColor = System.Drawing.Color.FromArgb(CType(CType(67, Byte), Integer), CType(CType(195, Byte), Integer), CType(CType(248, Byte), Integer))
        Me.Guna2ControlBox2.HoverState.Parent = Me.Guna2ControlBox2
        Me.Guna2ControlBox2.IconColor = System.Drawing.Color.White
        Me.Guna2ControlBox2.Location = New System.Drawing.Point(1082, 18)
        Me.Guna2ControlBox2.Name = "Guna2ControlBox2"
        Me.Guna2ControlBox2.ShadowDecoration.Parent = Me.Guna2ControlBox2
        Me.Guna2ControlBox2.Size = New System.Drawing.Size(17, 18)
        Me.Guna2ControlBox2.TabIndex = 8
        '
        'Guna2ControlBox1
        '
        Me.Guna2ControlBox1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Guna2ControlBox1.Animated = True
        Me.Guna2ControlBox1.ControlBoxType = Guna.UI2.WinForms.Enums.ControlBoxType.MaximizeBox
        Me.Guna2ControlBox1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Guna2ControlBox1.FillColor = System.Drawing.Color.FromArgb(CType(CType(67, Byte), Integer), CType(CType(195, Byte), Integer), CType(CType(248, Byte), Integer))
        Me.Guna2ControlBox1.HoverState.Parent = Me.Guna2ControlBox1
        Me.Guna2ControlBox1.IconColor = System.Drawing.Color.White
        Me.Guna2ControlBox1.Location = New System.Drawing.Point(1053, 18)
        Me.Guna2ControlBox1.Name = "Guna2ControlBox1"
        Me.Guna2ControlBox1.ShadowDecoration.Parent = Me.Guna2ControlBox1
        Me.Guna2ControlBox1.Size = New System.Drawing.Size(17, 18)
        Me.Guna2ControlBox1.TabIndex = 7
        '
        'Guna2CirclePictureBox2
        '
        Me.Guna2CirclePictureBox2.BackColor = System.Drawing.Color.Transparent
        Me.Guna2CirclePictureBox2.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Guna2CirclePictureBox2.Image = CType(resources.GetObject("Guna2CirclePictureBox2.Image"), System.Drawing.Image)
        Me.Guna2CirclePictureBox2.ImageRotate = 0.0!
        Me.Guna2CirclePictureBox2.Location = New System.Drawing.Point(23, 13)
        Me.Guna2CirclePictureBox2.Name = "Guna2CirclePictureBox2"
        Me.Guna2CirclePictureBox2.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle
        Me.Guna2CirclePictureBox2.ShadowDecoration.Parent = Me.Guna2CirclePictureBox2
        Me.Guna2CirclePictureBox2.Size = New System.Drawing.Size(34, 31)
        Me.Guna2CirclePictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.Guna2CirclePictureBox2.TabIndex = 6
        Me.Guna2CirclePictureBox2.TabStop = False
        Me.Guna2CirclePictureBox2.UseTransparentBackground = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label1.Font = New System.Drawing.Font("Nirmala UI Semilight", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(66, 13)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(262, 28)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Stock Management System"
        '
        'main_picturebox
        '
        Me.main_picturebox.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.main_picturebox.BackColor = System.Drawing.Color.Transparent
        Me.main_picturebox.ImageRotate = 0.0!
        Me.main_picturebox.Location = New System.Drawing.Point(873, 7)
        Me.main_picturebox.Name = "main_picturebox"
        Me.main_picturebox.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle
        Me.main_picturebox.ShadowDecoration.Parent = Me.main_picturebox
        Me.main_picturebox.Size = New System.Drawing.Size(44, 41)
        Me.main_picturebox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.main_picturebox.TabIndex = 3
        Me.main_picturebox.TabStop = False
        Me.main_picturebox.UseTransparentBackground = True
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(245, Byte), Integer), CType(CType(245, Byte), Integer), CType(CType(243, Byte), Integer))
        Me.TableLayoutPanel1.ColumnCount = 1
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.btn_outbound, 0, 5)
        Me.TableLayoutPanel1.Controls.Add(Me.btn_inbound, 0, 4)
        Me.TableLayoutPanel1.Controls.Add(Me.btn_stockmaster, 0, 3)
        Me.TableLayoutPanel1.Controls.Add(Me.btn_ProductMaster, 0, 2)
        Me.TableLayoutPanel1.Controls.Add(Me.btn_customerMaster, 0, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.btn_Dashboard, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.btn_logout, 0, 9)
        Me.TableLayoutPanel1.Controls.Add(Me.btn_manageuser, 0, 6)
        Me.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Left
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(0, 56)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 11
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 9.090909!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 9.090909!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 9.090909!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 9.090909!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 9.090909!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 9.090909!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 9.090909!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 9.090909!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 9.090909!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 9.090909!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 9.090909!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(186, 605)
        Me.TableLayoutPanel1.TabIndex = 2
        '
        'btn_outbound
        '
        Me.btn_outbound.Animated = True
        Me.btn_outbound.CheckedState.Parent = Me.btn_outbound
        Me.btn_outbound.CustomImages.Parent = Me.btn_outbound
        Me.btn_outbound.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btn_outbound.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btn_outbound.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btn_outbound.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btn_outbound.DisabledState.Parent = Me.btn_outbound
        Me.btn_outbound.Dock = System.Windows.Forms.DockStyle.Fill
        Me.btn_outbound.FillColor = System.Drawing.Color.Transparent
        Me.btn_outbound.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        Me.btn_outbound.ForeColor = System.Drawing.Color.FromArgb(CType(CType(135, Byte), Integer), CType(CType(133, Byte), Integer), CType(CType(133, Byte), Integer))
        Me.btn_outbound.HoverState.Parent = Me.btn_outbound
        Me.btn_outbound.Image = CType(resources.GetObject("btn_outbound.Image"), System.Drawing.Image)
        Me.btn_outbound.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.btn_outbound.ImageOffset = New System.Drawing.Point(10, 0)
        Me.btn_outbound.Location = New System.Drawing.Point(3, 273)
        Me.btn_outbound.Name = "btn_outbound"
        Me.btn_outbound.ShadowDecoration.Parent = Me.btn_outbound
        Me.btn_outbound.Size = New System.Drawing.Size(180, 48)
        Me.btn_outbound.TabIndex = 5
        Me.btn_outbound.Text = "Outbound"
        Me.btn_outbound.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.btn_outbound.TextOffset = New System.Drawing.Point(10, 0)
        '
        'btn_inbound
        '
        Me.btn_inbound.Animated = True
        Me.btn_inbound.CheckedState.Parent = Me.btn_inbound
        Me.btn_inbound.CustomImages.Parent = Me.btn_inbound
        Me.btn_inbound.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btn_inbound.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btn_inbound.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btn_inbound.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btn_inbound.DisabledState.Parent = Me.btn_inbound
        Me.btn_inbound.Dock = System.Windows.Forms.DockStyle.Fill
        Me.btn_inbound.FillColor = System.Drawing.Color.Transparent
        Me.btn_inbound.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        Me.btn_inbound.ForeColor = System.Drawing.Color.FromArgb(CType(CType(135, Byte), Integer), CType(CType(133, Byte), Integer), CType(CType(133, Byte), Integer))
        Me.btn_inbound.HoverState.Parent = Me.btn_inbound
        Me.btn_inbound.Image = CType(resources.GetObject("btn_inbound.Image"), System.Drawing.Image)
        Me.btn_inbound.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.btn_inbound.ImageOffset = New System.Drawing.Point(10, 0)
        Me.btn_inbound.Location = New System.Drawing.Point(3, 219)
        Me.btn_inbound.Name = "btn_inbound"
        Me.btn_inbound.ShadowDecoration.Parent = Me.btn_inbound
        Me.btn_inbound.Size = New System.Drawing.Size(180, 48)
        Me.btn_inbound.TabIndex = 4
        Me.btn_inbound.Text = "Inbound"
        Me.btn_inbound.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.btn_inbound.TextOffset = New System.Drawing.Point(10, 0)
        '
        'btn_stockmaster
        '
        Me.btn_stockmaster.Animated = True
        Me.btn_stockmaster.CheckedState.Parent = Me.btn_stockmaster
        Me.btn_stockmaster.CustomImages.Parent = Me.btn_stockmaster
        Me.btn_stockmaster.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btn_stockmaster.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btn_stockmaster.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btn_stockmaster.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btn_stockmaster.DisabledState.Parent = Me.btn_stockmaster
        Me.btn_stockmaster.Dock = System.Windows.Forms.DockStyle.Fill
        Me.btn_stockmaster.FillColor = System.Drawing.Color.Transparent
        Me.btn_stockmaster.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        Me.btn_stockmaster.ForeColor = System.Drawing.Color.FromArgb(CType(CType(135, Byte), Integer), CType(CType(133, Byte), Integer), CType(CType(133, Byte), Integer))
        Me.btn_stockmaster.HoverState.Parent = Me.btn_stockmaster
        Me.btn_stockmaster.Image = CType(resources.GetObject("btn_stockmaster.Image"), System.Drawing.Image)
        Me.btn_stockmaster.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.btn_stockmaster.ImageOffset = New System.Drawing.Point(10, 0)
        Me.btn_stockmaster.Location = New System.Drawing.Point(3, 165)
        Me.btn_stockmaster.Name = "btn_stockmaster"
        Me.btn_stockmaster.ShadowDecoration.Parent = Me.btn_stockmaster
        Me.btn_stockmaster.Size = New System.Drawing.Size(180, 48)
        Me.btn_stockmaster.TabIndex = 3
        Me.btn_stockmaster.Text = "Manage Stock"
        Me.btn_stockmaster.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.btn_stockmaster.TextOffset = New System.Drawing.Point(10, 0)
        '
        'btn_ProductMaster
        '
        Me.btn_ProductMaster.Animated = True
        Me.btn_ProductMaster.CheckedState.Parent = Me.btn_ProductMaster
        Me.btn_ProductMaster.CustomImages.Parent = Me.btn_ProductMaster
        Me.btn_ProductMaster.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btn_ProductMaster.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btn_ProductMaster.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btn_ProductMaster.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btn_ProductMaster.DisabledState.Parent = Me.btn_ProductMaster
        Me.btn_ProductMaster.Dock = System.Windows.Forms.DockStyle.Fill
        Me.btn_ProductMaster.FillColor = System.Drawing.Color.Transparent
        Me.btn_ProductMaster.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        Me.btn_ProductMaster.ForeColor = System.Drawing.Color.FromArgb(CType(CType(135, Byte), Integer), CType(CType(133, Byte), Integer), CType(CType(133, Byte), Integer))
        Me.btn_ProductMaster.HoverState.Parent = Me.btn_ProductMaster
        Me.btn_ProductMaster.Image = CType(resources.GetObject("btn_ProductMaster.Image"), System.Drawing.Image)
        Me.btn_ProductMaster.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.btn_ProductMaster.ImageOffset = New System.Drawing.Point(10, 0)
        Me.btn_ProductMaster.Location = New System.Drawing.Point(3, 111)
        Me.btn_ProductMaster.Name = "btn_ProductMaster"
        Me.btn_ProductMaster.ShadowDecoration.Parent = Me.btn_ProductMaster
        Me.btn_ProductMaster.Size = New System.Drawing.Size(180, 48)
        Me.btn_ProductMaster.TabIndex = 2
        Me.btn_ProductMaster.Text = "Manage Product"
        Me.btn_ProductMaster.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.btn_ProductMaster.TextOffset = New System.Drawing.Point(10, 0)
        '
        'btn_customerMaster
        '
        Me.btn_customerMaster.Animated = True
        Me.btn_customerMaster.CheckedState.Parent = Me.btn_customerMaster
        Me.btn_customerMaster.CustomImages.Parent = Me.btn_customerMaster
        Me.btn_customerMaster.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btn_customerMaster.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btn_customerMaster.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btn_customerMaster.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btn_customerMaster.DisabledState.Parent = Me.btn_customerMaster
        Me.btn_customerMaster.Dock = System.Windows.Forms.DockStyle.Fill
        Me.btn_customerMaster.FillColor = System.Drawing.Color.Transparent
        Me.btn_customerMaster.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        Me.btn_customerMaster.ForeColor = System.Drawing.Color.FromArgb(CType(CType(135, Byte), Integer), CType(CType(133, Byte), Integer), CType(CType(133, Byte), Integer))
        Me.btn_customerMaster.HoverState.Parent = Me.btn_customerMaster
        Me.btn_customerMaster.Image = CType(resources.GetObject("btn_customerMaster.Image"), System.Drawing.Image)
        Me.btn_customerMaster.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.btn_customerMaster.ImageOffset = New System.Drawing.Point(10, 0)
        Me.btn_customerMaster.Location = New System.Drawing.Point(3, 57)
        Me.btn_customerMaster.Name = "btn_customerMaster"
        Me.btn_customerMaster.ShadowDecoration.Parent = Me.btn_customerMaster
        Me.btn_customerMaster.Size = New System.Drawing.Size(180, 48)
        Me.btn_customerMaster.TabIndex = 1
        Me.btn_customerMaster.Text = "Manage Customer"
        Me.btn_customerMaster.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.btn_customerMaster.TextOffset = New System.Drawing.Point(10, 0)
        '
        'btn_Dashboard
        '
        Me.btn_Dashboard.Animated = True
        Me.btn_Dashboard.CheckedState.Parent = Me.btn_Dashboard
        Me.btn_Dashboard.CustomImages.Parent = Me.btn_Dashboard
        Me.btn_Dashboard.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btn_Dashboard.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btn_Dashboard.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btn_Dashboard.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btn_Dashboard.DisabledState.Parent = Me.btn_Dashboard
        Me.btn_Dashboard.Dock = System.Windows.Forms.DockStyle.Fill
        Me.btn_Dashboard.FillColor = System.Drawing.Color.Transparent
        Me.btn_Dashboard.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        Me.btn_Dashboard.ForeColor = System.Drawing.Color.FromArgb(CType(CType(135, Byte), Integer), CType(CType(133, Byte), Integer), CType(CType(133, Byte), Integer))
        Me.btn_Dashboard.HoverState.Parent = Me.btn_Dashboard
        Me.btn_Dashboard.Image = CType(resources.GetObject("btn_Dashboard.Image"), System.Drawing.Image)
        Me.btn_Dashboard.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.btn_Dashboard.ImageOffset = New System.Drawing.Point(10, 0)
        Me.btn_Dashboard.Location = New System.Drawing.Point(3, 3)
        Me.btn_Dashboard.Name = "btn_Dashboard"
        Me.btn_Dashboard.ShadowDecoration.Parent = Me.btn_Dashboard
        Me.btn_Dashboard.Size = New System.Drawing.Size(180, 48)
        Me.btn_Dashboard.TabIndex = 0
        Me.btn_Dashboard.Text = "DashBoard"
        Me.btn_Dashboard.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.btn_Dashboard.TextOffset = New System.Drawing.Point(10, 0)
        '
        'btn_logout
        '
        Me.btn_logout.Animated = True
        Me.btn_logout.CheckedState.Parent = Me.btn_logout
        Me.btn_logout.CustomImages.Parent = Me.btn_logout
        Me.btn_logout.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btn_logout.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btn_logout.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btn_logout.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btn_logout.DisabledState.Parent = Me.btn_logout
        Me.btn_logout.Dock = System.Windows.Forms.DockStyle.Fill
        Me.btn_logout.FillColor = System.Drawing.Color.Transparent
        Me.btn_logout.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        Me.btn_logout.ForeColor = System.Drawing.Color.FromArgb(CType(CType(135, Byte), Integer), CType(CType(133, Byte), Integer), CType(CType(133, Byte), Integer))
        Me.btn_logout.HoverState.Parent = Me.btn_logout
        Me.btn_logout.Image = CType(resources.GetObject("btn_logout.Image"), System.Drawing.Image)
        Me.btn_logout.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.btn_logout.ImageOffset = New System.Drawing.Point(10, 0)
        Me.btn_logout.Location = New System.Drawing.Point(3, 489)
        Me.btn_logout.Name = "btn_logout"
        Me.btn_logout.ShadowDecoration.Parent = Me.btn_logout
        Me.btn_logout.Size = New System.Drawing.Size(180, 48)
        Me.btn_logout.TabIndex = 7
        Me.btn_logout.Text = "Logout"
        Me.btn_logout.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.btn_logout.TextOffset = New System.Drawing.Point(10, 0)
        '
        'btn_manageuser
        '
        Me.btn_manageuser.Animated = True
        Me.btn_manageuser.CheckedState.Parent = Me.btn_manageuser
        Me.btn_manageuser.CustomImages.Parent = Me.btn_manageuser
        Me.btn_manageuser.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btn_manageuser.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btn_manageuser.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btn_manageuser.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btn_manageuser.DisabledState.Parent = Me.btn_manageuser
        Me.btn_manageuser.FillColor = System.Drawing.Color.Transparent
        Me.btn_manageuser.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        Me.btn_manageuser.ForeColor = System.Drawing.Color.FromArgb(CType(CType(135, Byte), Integer), CType(CType(133, Byte), Integer), CType(CType(133, Byte), Integer))
        Me.btn_manageuser.HoverState.Parent = Me.btn_manageuser
        Me.btn_manageuser.Image = CType(resources.GetObject("btn_manageuser.Image"), System.Drawing.Image)
        Me.btn_manageuser.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.btn_manageuser.ImageOffset = New System.Drawing.Point(10, 0)
        Me.btn_manageuser.Location = New System.Drawing.Point(3, 327)
        Me.btn_manageuser.Name = "btn_manageuser"
        Me.btn_manageuser.ShadowDecoration.Parent = Me.btn_manageuser
        Me.btn_manageuser.Size = New System.Drawing.Size(180, 48)
        Me.btn_manageuser.TabIndex = 7
        Me.btn_manageuser.Text = "Manage Users"
        Me.btn_manageuser.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.btn_manageuser.TextOffset = New System.Drawing.Point(10, 0)
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.White
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel1.Location = New System.Drawing.Point(186, 56)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(921, 605)
        Me.Panel1.TabIndex = 3
        '
        'mainfrm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1107, 661)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.Controls.Add(Me.Guna2Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "mainfrm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.Guna2Panel1.ResumeLayout(False)
        Me.Guna2Panel1.PerformLayout()
        CType(Me.Guna2CirclePictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.main_picturebox, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Guna2DragControl1 As Guna.UI2.WinForms.Guna2DragControl
    Friend WithEvents main_picturebox As Guna.UI2.WinForms.Guna2CirclePictureBox
    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents Guna2Panel1 As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents Guna2CirclePictureBox2 As Guna.UI2.WinForms.Guna2CirclePictureBox
    Friend WithEvents btn_Dashboard As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents btn_logout As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents btn_outbound As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents btn_inbound As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents btn_stockmaster As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents btn_ProductMaster As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents btn_customerMaster As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Guna2ControlBox1 As Guna.UI2.WinForms.Guna2ControlBox
    Friend WithEvents Guna2ControlBox2 As Guna.UI2.WinForms.Guna2ControlBox
    Friend WithEvents btn_manageuser As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents lbl_role As System.Windows.Forms.Label
    Friend WithEvents lbl_user As System.Windows.Forms.Label
End Class
