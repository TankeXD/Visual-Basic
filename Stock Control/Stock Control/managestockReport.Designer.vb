<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class managestockReport
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
        Me.CrystalReportViewer1 = New CrystalDecisions.Windows.Forms.CrystalReportViewer()
        Me.CrystalReport11 = New Stock_Control.CrystalReport1()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.TableLayoutPanel2 = New System.Windows.Forms.TableLayoutPanel()
        Me.Radio_ZeroStock = New Guna.UI2.WinForms.Guna2RadioButton()
        Me.Radio_NagativeStock = New Guna.UI2.WinForms.Guna2RadioButton()
        Me.combo_productGroup = New Guna.UI2.WinForms.Guna2ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.TableLayoutPanel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'CrystalReportViewer1
        '
        Me.CrystalReportViewer1.ActiveViewIndex = 0
        Me.CrystalReportViewer1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.CrystalReportViewer1.Cursor = System.Windows.Forms.Cursors.Default
        Me.CrystalReportViewer1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.CrystalReportViewer1.Location = New System.Drawing.Point(229, 3)
        Me.CrystalReportViewer1.Name = "CrystalReportViewer1"
        Me.CrystalReportViewer1.ReportSource = Me.CrystalReport11
        Me.CrystalReportViewer1.Size = New System.Drawing.Size(895, 499)
        Me.CrystalReportViewer1.TabIndex = 0
        Me.CrystalReportViewer1.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.ColumnCount = 2
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20.14197!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 79.85803!))
        Me.TableLayoutPanel1.Controls.Add(Me.CrystalReportViewer1, 1, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.TableLayoutPanel2, 0, 0)
        Me.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(0, 0)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 1
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(1127, 505)
        Me.TableLayoutPanel1.TabIndex = 1
        '
        'TableLayoutPanel2
        '
        Me.TableLayoutPanel2.ColumnCount = 1
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel2.Controls.Add(Me.Radio_ZeroStock, 0, 3)
        Me.TableLayoutPanel2.Controls.Add(Me.Radio_NagativeStock, 0, 4)
        Me.TableLayoutPanel2.Controls.Add(Me.combo_productGroup, 0, 2)
        Me.TableLayoutPanel2.Controls.Add(Me.Label1, 0, 1)
        Me.TableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel2.Location = New System.Drawing.Point(3, 3)
        Me.TableLayoutPanel2.Name = "TableLayoutPanel2"
        Me.TableLayoutPanel2.RowCount = 6
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40.0!))
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40.0!))
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40.0!))
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40.0!))
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40.0!))
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 293.0!))
        Me.TableLayoutPanel2.Size = New System.Drawing.Size(220, 499)
        Me.TableLayoutPanel2.TabIndex = 1
        '
        'Radio_ZeroStock
        '
        Me.Radio_ZeroStock.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom), System.Windows.Forms.AnchorStyles)
        Me.Radio_ZeroStock.AutoSize = True
        Me.Radio_ZeroStock.CheckedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Radio_ZeroStock.CheckedState.BorderThickness = 0
        Me.Radio_ZeroStock.CheckedState.FillColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Radio_ZeroStock.CheckedState.InnerColor = System.Drawing.Color.White
        Me.Radio_ZeroStock.CheckedState.InnerOffset = -4
        Me.Radio_ZeroStock.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Radio_ZeroStock.ForeColor = System.Drawing.Color.Gray
        Me.Radio_ZeroStock.Location = New System.Drawing.Point(58, 123)
        Me.Radio_ZeroStock.Name = "Radio_ZeroStock"
        Me.Radio_ZeroStock.Size = New System.Drawing.Size(103, 34)
        Me.Radio_ZeroStock.TabIndex = 0
        Me.Radio_ZeroStock.Text = "Zero Stock        "
        Me.Radio_ZeroStock.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.Radio_ZeroStock.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(125, Byte), Integer), CType(CType(137, Byte), Integer), CType(CType(149, Byte), Integer))
        Me.Radio_ZeroStock.UncheckedState.BorderThickness = 2
        Me.Radio_ZeroStock.UncheckedState.FillColor = System.Drawing.Color.Transparent
        Me.Radio_ZeroStock.UncheckedState.InnerColor = System.Drawing.Color.Transparent
        '
        'Radio_NagativeStock
        '
        Me.Radio_NagativeStock.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom), System.Windows.Forms.AnchorStyles)
        Me.Radio_NagativeStock.AutoSize = True
        Me.Radio_NagativeStock.CheckedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Radio_NagativeStock.CheckedState.BorderThickness = 0
        Me.Radio_NagativeStock.CheckedState.FillColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Radio_NagativeStock.CheckedState.InnerColor = System.Drawing.Color.White
        Me.Radio_NagativeStock.CheckedState.InnerOffset = -4
        Me.Radio_NagativeStock.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Radio_NagativeStock.ForeColor = System.Drawing.Color.Gray
        Me.Radio_NagativeStock.Location = New System.Drawing.Point(59, 163)
        Me.Radio_NagativeStock.Name = "Radio_NagativeStock"
        Me.Radio_NagativeStock.Size = New System.Drawing.Size(101, 34)
        Me.Radio_NagativeStock.TabIndex = 1
        Me.Radio_NagativeStock.Text = "Negative Stock"
        Me.Radio_NagativeStock.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.Radio_NagativeStock.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(125, Byte), Integer), CType(CType(137, Byte), Integer), CType(CType(149, Byte), Integer))
        Me.Radio_NagativeStock.UncheckedState.BorderThickness = 2
        Me.Radio_NagativeStock.UncheckedState.FillColor = System.Drawing.Color.Transparent
        Me.Radio_NagativeStock.UncheckedState.InnerColor = System.Drawing.Color.Transparent
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
        Me.combo_productGroup.Location = New System.Drawing.Point(3, 83)
        Me.combo_productGroup.Name = "combo_productGroup"
        Me.combo_productGroup.ShadowDecoration.Parent = Me.combo_productGroup
        Me.combo_productGroup.Size = New System.Drawing.Size(214, 36)
        Me.combo_productGroup.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material
        Me.combo_productGroup.TabIndex = 9
        Me.combo_productGroup.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label1
        '
        Me.Label1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom), System.Windows.Forms.AnchorStyles)
        Me.Label1.AutoSize = True
        Me.Label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label1.Font = New System.Drawing.Font("Nirmala UI Semilight", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.DimGray
        Me.Label1.Location = New System.Drawing.Point(40, 40)
        Me.Label1.Name = "Label1"
        Me.Label1.Padding = New System.Windows.Forms.Padding(10)
        Me.Label1.Size = New System.Drawing.Size(140, 40)
        Me.Label1.TabIndex = 10
        Me.Label1.Text = "Filter by Group"
        '
        'managestockReport
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1127, 505)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.Name = "managestockReport"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.TableLayoutPanel2.ResumeLayout(False)
        Me.TableLayoutPanel2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents CrystalReportViewer1 As CrystalDecisions.Windows.Forms.CrystalReportViewer
    Friend WithEvents CrystalReport11 As Stock_Control.CrystalReport1
    Friend WithEvents TableLayoutPanel1 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents TableLayoutPanel2 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents Radio_ZeroStock As Guna.UI2.WinForms.Guna2RadioButton
    Friend WithEvents Radio_NagativeStock As Guna.UI2.WinForms.Guna2RadioButton
    Friend WithEvents combo_productGroup As Guna.UI2.WinForms.Guna2ComboBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
End Class
