<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frm_settings
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.txtunit = New System.Windows.Forms.TextBox()
        Me.btnusave = New System.Windows.Forms.Button()
        Me.btncdel = New System.Windows.Forms.Button()
        Me.btntypeupdate = New System.Windows.Forms.Button()
        Me.btntypeLoad = New System.Windows.Forms.Button()
        Me.dtgtypelist = New System.Windows.Forms.DataGridView()
        Me.txtCategory = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnuupdate = New System.Windows.Forms.Button()
        Me.btnuload = New System.Windows.Forms.Button()
        Me.dtgulist = New System.Windows.Forms.DataGridView()
        Me.btnTypesave = New System.Windows.Forms.Button()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.btnunit = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.btndeletebrand = New System.Windows.Forms.Button()
        Me.btnupdatebrand = New System.Windows.Forms.Button()
        Me.btnloadbrand = New System.Windows.Forms.Button()
        Me.dtglistbrand = New System.Windows.Forms.DataGridView()
        Me.txtbrand = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.btnsavebrand = New System.Windows.Forms.Button()
        CType(Me.dtgtypelist, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dtgulist, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        CType(Me.dtglistbrand, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txtunit
        '
        Me.txtunit.Location = New System.Drawing.Point(108, 43)
        Me.txtunit.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txtunit.Name = "txtunit"
        Me.txtunit.Size = New System.Drawing.Size(316, 26)
        Me.txtunit.TabIndex = 2
        '
        'btnusave
        '
        Me.btnusave.BackColor = System.Drawing.Color.White
        Me.btnusave.ForeColor = System.Drawing.Color.Black
        Me.btnusave.Location = New System.Drawing.Point(435, 83)
        Me.btnusave.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btnusave.Name = "btnusave"
        Me.btnusave.Size = New System.Drawing.Size(112, 35)
        Me.btnusave.TabIndex = 0
        Me.btnusave.Text = "Guardar"
        Me.btnusave.UseVisualStyleBackColor = False
        '
        'btncdel
        '
        Me.btncdel.BackColor = System.Drawing.Color.White
        Me.btncdel.ForeColor = System.Drawing.Color.Black
        Me.btncdel.Location = New System.Drawing.Point(434, 177)
        Me.btncdel.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btncdel.Name = "btncdel"
        Me.btncdel.Size = New System.Drawing.Size(112, 35)
        Me.btncdel.TabIndex = 6
        Me.btncdel.Text = "Eliminar"
        Me.btncdel.UseVisualStyleBackColor = False
        '
        'btntypeupdate
        '
        Me.btntypeupdate.BackColor = System.Drawing.Color.White
        Me.btntypeupdate.ForeColor = System.Drawing.Color.Black
        Me.btntypeupdate.Location = New System.Drawing.Point(434, 132)
        Me.btntypeupdate.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btntypeupdate.Name = "btntypeupdate"
        Me.btntypeupdate.Size = New System.Drawing.Size(112, 35)
        Me.btntypeupdate.TabIndex = 5
        Me.btntypeupdate.Text = "Actualizar"
        Me.btntypeupdate.UseVisualStyleBackColor = False
        '
        'btntypeLoad
        '
        Me.btntypeLoad.BackColor = System.Drawing.Color.White
        Me.btntypeLoad.ForeColor = System.Drawing.Color.Black
        Me.btntypeLoad.Location = New System.Drawing.Point(435, 219)
        Me.btntypeLoad.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btntypeLoad.Name = "btntypeLoad"
        Me.btntypeLoad.Size = New System.Drawing.Size(112, 63)
        Me.btntypeLoad.TabIndex = 4
        Me.btntypeLoad.Text = "Cargar Lista"
        Me.btntypeLoad.UseVisualStyleBackColor = False
        '
        'dtgtypelist
        '
        Me.dtgtypelist.AllowUserToAddRows = False
        Me.dtgtypelist.AllowUserToDeleteRows = False
        Me.dtgtypelist.AllowUserToResizeColumns = False
        Me.dtgtypelist.AllowUserToResizeRows = False
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black
        Me.dtgtypelist.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.dtgtypelist.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dtgtypelist.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically
        Me.dtgtypelist.Location = New System.Drawing.Point(9, 83)
        Me.dtgtypelist.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.dtgtypelist.Name = "dtgtypelist"
        Me.dtgtypelist.RowHeadersVisible = False
        Me.dtgtypelist.RowHeadersWidth = 62
        Me.dtgtypelist.Size = New System.Drawing.Size(417, 480)
        Me.dtgtypelist.TabIndex = 3
        '
        'txtCategory
        '
        Me.txtCategory.Location = New System.Drawing.Point(108, 43)
        Me.txtCategory.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txtCategory.Name = "txtCategory"
        Me.txtCategory.Size = New System.Drawing.Size(316, 26)
        Me.txtCategory.TabIndex = 2
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(5, 49)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(102, 20)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Categoria :"
        '
        'btnuupdate
        '
        Me.btnuupdate.BackColor = System.Drawing.Color.White
        Me.btnuupdate.ForeColor = System.Drawing.Color.Black
        Me.btnuupdate.Location = New System.Drawing.Point(435, 132)
        Me.btnuupdate.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btnuupdate.Name = "btnuupdate"
        Me.btnuupdate.Size = New System.Drawing.Size(112, 35)
        Me.btnuupdate.TabIndex = 5
        Me.btnuupdate.Text = "Actualizar"
        Me.btnuupdate.UseVisualStyleBackColor = False
        '
        'btnuload
        '
        Me.btnuload.BackColor = System.Drawing.Color.White
        Me.btnuload.ForeColor = System.Drawing.Color.Black
        Me.btnuload.Location = New System.Drawing.Point(435, 222)
        Me.btnuload.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btnuload.Name = "btnuload"
        Me.btnuload.Size = New System.Drawing.Size(112, 60)
        Me.btnuload.TabIndex = 4
        Me.btnuload.Text = "Cargar Lista"
        Me.btnuload.UseVisualStyleBackColor = False
        '
        'dtgulist
        '
        Me.dtgulist.AllowUserToAddRows = False
        Me.dtgulist.AllowUserToDeleteRows = False
        Me.dtgulist.AllowUserToResizeColumns = False
        Me.dtgulist.AllowUserToResizeRows = False
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black
        Me.dtgulist.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle2
        Me.dtgulist.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dtgulist.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically
        Me.dtgulist.Location = New System.Drawing.Point(9, 83)
        Me.dtgulist.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.dtgulist.Name = "dtgulist"
        Me.dtgulist.RowHeadersVisible = False
        Me.dtgulist.RowHeadersWidth = 62
        Me.dtgulist.Size = New System.Drawing.Size(417, 480)
        Me.dtgulist.TabIndex = 3
        '
        'btnTypesave
        '
        Me.btnTypesave.BackColor = System.Drawing.Color.White
        Me.btnTypesave.ForeColor = System.Drawing.Color.Black
        Me.btnTypesave.Location = New System.Drawing.Point(435, 83)
        Me.btnTypesave.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btnTypesave.Name = "btnTypesave"
        Me.btnTypesave.Size = New System.Drawing.Size(112, 35)
        Me.btnTypesave.TabIndex = 0
        Me.btnTypesave.Text = "Guardar"
        Me.btnTypesave.UseVisualStyleBackColor = False
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.btnunit)
        Me.GroupBox2.Controls.Add(Me.btnuupdate)
        Me.GroupBox2.Controls.Add(Me.btnuload)
        Me.GroupBox2.Controls.Add(Me.dtgulist)
        Me.GroupBox2.Controls.Add(Me.txtunit)
        Me.GroupBox2.Controls.Add(Me.Label2)
        Me.GroupBox2.Controls.Add(Me.btnusave)
        Me.GroupBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.ForeColor = System.Drawing.Color.Black
        Me.GroupBox2.Location = New System.Drawing.Point(588, 18)
        Me.GroupBox2.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Padding = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.GroupBox2.Size = New System.Drawing.Size(561, 572)
        Me.GroupBox2.TabIndex = 12
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Agregar Nueva Unidad"
        '
        'btnunit
        '
        Me.btnunit.BackColor = System.Drawing.Color.White
        Me.btnunit.ForeColor = System.Drawing.Color.Black
        Me.btnunit.Location = New System.Drawing.Point(434, 177)
        Me.btnunit.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btnunit.Name = "btnunit"
        Me.btnunit.Size = New System.Drawing.Size(112, 35)
        Me.btnunit.TabIndex = 7
        Me.btnunit.Text = "Eliminar"
        Me.btnunit.UseVisualStyleBackColor = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.Location = New System.Drawing.Point(21, 49)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(79, 20)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Unidad :"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.btncdel)
        Me.GroupBox1.Controls.Add(Me.btntypeupdate)
        Me.GroupBox1.Controls.Add(Me.btntypeLoad)
        Me.GroupBox1.Controls.Add(Me.dtgtypelist)
        Me.GroupBox1.Controls.Add(Me.txtCategory)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.btnTypesave)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.ForeColor = System.Drawing.Color.Black
        Me.GroupBox1.Location = New System.Drawing.Point(18, 18)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.GroupBox1.Size = New System.Drawing.Size(561, 572)
        Me.GroupBox1.TabIndex = 11
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Agregar Nueva Categoria"
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.btndeletebrand)
        Me.GroupBox3.Controls.Add(Me.btnupdatebrand)
        Me.GroupBox3.Controls.Add(Me.btnloadbrand)
        Me.GroupBox3.Controls.Add(Me.dtglistbrand)
        Me.GroupBox3.Controls.Add(Me.txtbrand)
        Me.GroupBox3.Controls.Add(Me.Label3)
        Me.GroupBox3.Controls.Add(Me.btnsavebrand)
        Me.GroupBox3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox3.ForeColor = System.Drawing.Color.Black
        Me.GroupBox3.Location = New System.Drawing.Point(1157, 18)
        Me.GroupBox3.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Padding = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.GroupBox3.Size = New System.Drawing.Size(561, 572)
        Me.GroupBox3.TabIndex = 13
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Agregar Nueva Marca"
        '
        'btndeletebrand
        '
        Me.btndeletebrand.BackColor = System.Drawing.Color.White
        Me.btndeletebrand.ForeColor = System.Drawing.Color.Black
        Me.btndeletebrand.Location = New System.Drawing.Point(434, 177)
        Me.btndeletebrand.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btndeletebrand.Name = "btndeletebrand"
        Me.btndeletebrand.Size = New System.Drawing.Size(112, 35)
        Me.btndeletebrand.TabIndex = 7
        Me.btndeletebrand.Text = "Eliminar"
        Me.btndeletebrand.UseVisualStyleBackColor = False
        '
        'btnupdatebrand
        '
        Me.btnupdatebrand.BackColor = System.Drawing.Color.White
        Me.btnupdatebrand.ForeColor = System.Drawing.Color.Black
        Me.btnupdatebrand.Location = New System.Drawing.Point(435, 132)
        Me.btnupdatebrand.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btnupdatebrand.Name = "btnupdatebrand"
        Me.btnupdatebrand.Size = New System.Drawing.Size(112, 35)
        Me.btnupdatebrand.TabIndex = 5
        Me.btnupdatebrand.Text = "Actualizar"
        Me.btnupdatebrand.UseVisualStyleBackColor = False
        '
        'btnloadbrand
        '
        Me.btnloadbrand.BackColor = System.Drawing.Color.White
        Me.btnloadbrand.ForeColor = System.Drawing.Color.Black
        Me.btnloadbrand.Location = New System.Drawing.Point(435, 222)
        Me.btnloadbrand.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btnloadbrand.Name = "btnloadbrand"
        Me.btnloadbrand.Size = New System.Drawing.Size(112, 60)
        Me.btnloadbrand.TabIndex = 4
        Me.btnloadbrand.Text = "Cargar Lista"
        Me.btnloadbrand.UseVisualStyleBackColor = False
        '
        'dtglistbrand
        '
        Me.dtglistbrand.AllowUserToAddRows = False
        Me.dtglistbrand.AllowUserToDeleteRows = False
        Me.dtglistbrand.AllowUserToResizeColumns = False
        Me.dtglistbrand.AllowUserToResizeRows = False
        DataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black
        Me.dtglistbrand.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle3
        Me.dtglistbrand.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dtglistbrand.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically
        Me.dtglistbrand.Location = New System.Drawing.Point(9, 83)
        Me.dtglistbrand.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.dtglistbrand.Name = "dtglistbrand"
        Me.dtglistbrand.RowHeadersVisible = False
        Me.dtglistbrand.RowHeadersWidth = 62
        Me.dtglistbrand.Size = New System.Drawing.Size(417, 480)
        Me.dtglistbrand.TabIndex = 3
        '
        'txtbrand
        '
        Me.txtbrand.Location = New System.Drawing.Point(108, 43)
        Me.txtbrand.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txtbrand.Name = "txtbrand"
        Me.txtbrand.Size = New System.Drawing.Size(316, 26)
        Me.txtbrand.TabIndex = 2
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Black
        Me.Label3.Location = New System.Drawing.Point(31, 48)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(73, 20)
        Me.Label3.TabIndex = 1
        Me.Label3.Text = "Marca :"
        '
        'btnsavebrand
        '
        Me.btnsavebrand.BackColor = System.Drawing.Color.White
        Me.btnsavebrand.ForeColor = System.Drawing.Color.Black
        Me.btnsavebrand.Location = New System.Drawing.Point(435, 83)
        Me.btnsavebrand.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btnsavebrand.Name = "btnsavebrand"
        Me.btnsavebrand.Size = New System.Drawing.Size(112, 35)
        Me.btnsavebrand.TabIndex = 0
        Me.btnsavebrand.Text = "Guardar"
        Me.btnsavebrand.UseVisualStyleBackColor = False
        '
        'frm_settings
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1734, 626)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Name = "frm_settings"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Añadir Categorias y Unidades"
        CType(Me.dtgtypelist, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dtgulist, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        CType(Me.dtglistbrand, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents txtunit As TextBox
    Friend WithEvents btnusave As Button
    Friend WithEvents btncdel As Button
    Friend WithEvents btntypeupdate As Button
    Friend WithEvents btntypeLoad As Button
    Friend WithEvents dtgtypelist As DataGridView
    Friend WithEvents txtCategory As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents btnuupdate As Button
    Friend WithEvents btnuload As Button
    Friend WithEvents dtgulist As DataGridView
    Friend WithEvents btnTypesave As Button
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents btnunit As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents btndeletebrand As Button
    Friend WithEvents btnupdatebrand As Button
    Friend WithEvents btnloadbrand As Button
    Friend WithEvents dtglistbrand As DataGridView
    Friend WithEvents txtbrand As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents btnsavebrand As Button
End Class
