<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class inboundsearchfrm
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
        Me.Guna2ShadowForm1 = New Guna.UI2.WinForms.Guna2ShadowForm(Me.components)
        Me.Guna2DragControl1 = New Guna.UI2.WinForms.Guna2DragControl(Me.components)
        Me.txt_inboundno = New Guna.UI2.WinForms.Guna2TextBox()
        Me.lbl_exit = New System.Windows.Forms.Label()
        Me.SuspendLayout()
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
        'txt_inboundno
        '
        Me.txt_inboundno.Animated = True
        Me.txt_inboundno.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txt_inboundno.DefaultText = ""
        Me.txt_inboundno.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txt_inboundno.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txt_inboundno.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txt_inboundno.DisabledState.Parent = Me.txt_inboundno
        Me.txt_inboundno.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txt_inboundno.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txt_inboundno.FocusedState.Parent = Me.txt_inboundno
        Me.txt_inboundno.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.txt_inboundno.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txt_inboundno.HoverState.Parent = Me.txt_inboundno
        Me.txt_inboundno.Location = New System.Drawing.Point(29, 38)
        Me.txt_inboundno.Margin = New System.Windows.Forms.Padding(80, 3, 3, 3)
        Me.txt_inboundno.Name = "txt_inboundno"
        Me.txt_inboundno.Padding = New System.Windows.Forms.Padding(5, 0, 0, 0)
        Me.txt_inboundno.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txt_inboundno.PlaceholderText = "Inbound No"
        Me.txt_inboundno.SelectedText = ""
        Me.txt_inboundno.ShadowDecoration.Parent = Me.txt_inboundno
        Me.txt_inboundno.Size = New System.Drawing.Size(259, 36)
        Me.txt_inboundno.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material
        Me.txt_inboundno.TabIndex = 16
        '
        'lbl_exit
        '
        Me.lbl_exit.AutoSize = True
        Me.lbl_exit.Cursor = System.Windows.Forms.Cursors.Hand
        Me.lbl_exit.Font = New System.Drawing.Font("Segoe UI Emoji", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_exit.ForeColor = System.Drawing.Color.Gray
        Me.lbl_exit.Location = New System.Drawing.Point(239, 13)
        Me.lbl_exit.Name = "lbl_exit"
        Me.lbl_exit.Size = New System.Drawing.Size(45, 15)
        Me.lbl_exit.TabIndex = 17
        Me.lbl_exit.Text = "[ close ]"
        '
        'inboundsearchfrm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(309, 117)
        Me.Controls.Add(Me.lbl_exit)
        Me.Controls.Add(Me.txt_inboundno)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "inboundsearchfrm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Guna2ShadowForm1 As Guna.UI2.WinForms.Guna2ShadowForm
    Friend WithEvents Guna2DragControl1 As Guna.UI2.WinForms.Guna2DragControl
    Friend WithEvents txt_inboundno As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents lbl_exit As System.Windows.Forms.Label
End Class
