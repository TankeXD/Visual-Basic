<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class searchfrm
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
        Me.txt_outbound = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Guna2ShadowForm1 = New Guna.UI2.WinForms.Guna2ShadowForm(Me.components)
        Me.Guna2DragControl1 = New Guna.UI2.WinForms.Guna2DragControl(Me.components)
        Me.SuspendLayout()
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
        Me.txt_outbound.Location = New System.Drawing.Point(68, 58)
        Me.txt_outbound.Margin = New System.Windows.Forms.Padding(80, 3, 3, 3)
        Me.txt_outbound.Name = "txt_outbound"
        Me.txt_outbound.Padding = New System.Windows.Forms.Padding(5, 0, 0, 0)
        Me.txt_outbound.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txt_outbound.PlaceholderText = "Enter Outbound No"
        Me.txt_outbound.SelectedText = ""
        Me.txt_outbound.ShadowDecoration.Parent = Me.txt_outbound
        Me.txt_outbound.Size = New System.Drawing.Size(288, 36)
        Me.txt_outbound.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material
        Me.txt_outbound.TabIndex = 32
        '
        'Guna2ShadowForm1
        '
        Me.Guna2ShadowForm1.ShadowColor = System.Drawing.Color.Silver
        Me.Guna2ShadowForm1.TargetForm = Me
        '
        'Guna2DragControl1
        '
        Me.Guna2DragControl1.TargetControl = Me
        '
        'searchfrm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(419, 152)
        Me.Controls.Add(Me.txt_outbound)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "searchfrm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents txt_outbound As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Guna2ShadowForm1 As Guna.UI2.WinForms.Guna2ShadowForm
    Friend WithEvents Guna2DragControl1 As Guna.UI2.WinForms.Guna2DragControl
End Class
