<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormCargarInsumos
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
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

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnCargar = New System.Windows.Forms.Button()
        Me.btnGuardar = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtRuta = New System.Windows.Forms.TextBox()
        Me.cmbInsumo = New System.Windows.Forms.ComboBox()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.cmbsheets = New System.Windows.Forms.ComboBox()
        Me.PanelHead = New System.Windows.Forms.Panel()
        Me.PanelBody = New System.Windows.Forms.Panel()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelHead.SuspendLayout()
        Me.PanelBody.SuspendLayout()
        Me.SuspendLayout()
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DataGridView1.Location = New System.Drawing.Point(0, 0)
        Me.DataGridView1.Margin = New System.Windows.Forms.Padding(4)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(684, 428)
        Me.DataGridView1.TabIndex = 3
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(4, 18)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(41, 13)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Insumo"
        '
        'btnCargar
        '
        Me.btnCargar.BackColor = System.Drawing.SystemColors.Control
        Me.btnCargar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnCargar.Enabled = False
        Me.btnCargar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(28, Byte), Integer), CType(CType(28, Byte), Integer), CType(CType(28, Byte), Integer))
        Me.btnCargar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btnCargar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCargar.ForeColor = System.Drawing.Color.Black
        Me.btnCargar.Location = New System.Drawing.Point(397, 8)
        Me.btnCargar.Name = "btnCargar"
        Me.btnCargar.Size = New System.Drawing.Size(96, 33)
        Me.btnCargar.TabIndex = 5
        Me.btnCargar.Text = "Cargar"
        Me.btnCargar.UseVisualStyleBackColor = False
        '
        'btnGuardar
        '
        Me.btnGuardar.BackColor = System.Drawing.SystemColors.Control
        Me.btnGuardar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnGuardar.Enabled = False
        Me.btnGuardar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(28, Byte), Integer), CType(CType(28, Byte), Integer), CType(CType(28, Byte), Integer))
        Me.btnGuardar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btnGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnGuardar.ForeColor = System.Drawing.Color.Black
        Me.btnGuardar.Location = New System.Drawing.Point(499, 8)
        Me.btnGuardar.Name = "btnGuardar"
        Me.btnGuardar.Size = New System.Drawing.Size(110, 33)
        Me.btnGuardar.TabIndex = 6
        Me.btnGuardar.Text = "Guardar Formato"
        Me.btnGuardar.UseVisualStyleBackColor = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(11, 57)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(30, 13)
        Me.Label2.TabIndex = 8
        Me.Label2.Text = "Ruta"
        '
        'txtRuta
        '
        Me.txtRuta.Enabled = False
        Me.txtRuta.Location = New System.Drawing.Point(51, 54)
        Me.txtRuta.Name = "txtRuta"
        Me.txtRuta.Size = New System.Drawing.Size(335, 20)
        Me.txtRuta.TabIndex = 9
        '
        'cmbInsumo
        '
        Me.cmbInsumo.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.cmbInsumo.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cmbInsumo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbInsumo.FormattingEnabled = True
        Me.cmbInsumo.Items.AddRange(New Object() {"EI1 Encuesta de inventarios", "PI1 Inventario planes", "PI3 Inventario proyectos"})
        Me.cmbInsumo.Location = New System.Drawing.Point(51, 15)
        Me.cmbInsumo.Name = "cmbInsumo"
        Me.cmbInsumo.Size = New System.Drawing.Size(335, 21)
        Me.cmbInsumo.TabIndex = 10
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(394, 57)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(29, 13)
        Me.Label3.TabIndex = 11
        Me.Label3.Text = "Hoja"
        '
        'cmbsheets
        '
        Me.cmbsheets.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.cmbsheets.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cmbsheets.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbsheets.Enabled = False
        Me.cmbsheets.FormattingEnabled = True
        Me.cmbsheets.Location = New System.Drawing.Point(432, 53)
        Me.cmbsheets.Name = "cmbsheets"
        Me.cmbsheets.Size = New System.Drawing.Size(121, 21)
        Me.cmbsheets.TabIndex = 63
        '
        'PanelHead
        '
        Me.PanelHead.Controls.Add(Me.cmbsheets)
        Me.PanelHead.Controls.Add(Me.Label1)
        Me.PanelHead.Controls.Add(Me.Label3)
        Me.PanelHead.Controls.Add(Me.btnCargar)
        Me.PanelHead.Controls.Add(Me.cmbInsumo)
        Me.PanelHead.Controls.Add(Me.btnGuardar)
        Me.PanelHead.Controls.Add(Me.txtRuta)
        Me.PanelHead.Controls.Add(Me.Label2)
        Me.PanelHead.Dock = System.Windows.Forms.DockStyle.Top
        Me.PanelHead.Location = New System.Drawing.Point(0, 0)
        Me.PanelHead.Name = "PanelHead"
        Me.PanelHead.Size = New System.Drawing.Size(684, 93)
        Me.PanelHead.TabIndex = 64
        '
        'PanelBody
        '
        Me.PanelBody.Controls.Add(Me.DataGridView1)
        Me.PanelBody.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanelBody.Location = New System.Drawing.Point(0, 93)
        Me.PanelBody.Name = "PanelBody"
        Me.PanelBody.Size = New System.Drawing.Size(684, 428)
        Me.PanelBody.TabIndex = 65
        '
        'FormCargarInsumos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(684, 521)
        Me.Controls.Add(Me.PanelBody)
        Me.Controls.Add(Me.PanelHead)
        Me.Name = "FormCargarInsumos"
        Me.Text = "Cargar Insumos"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelHead.ResumeLayout(False)
        Me.PanelHead.PerformLayout()
        Me.PanelBody.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents Label1 As Label
    Friend WithEvents btnCargar As Button
    Friend WithEvents btnGuardar As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents txtRuta As TextBox
    Friend WithEvents cmbInsumo As ComboBox
    Friend WithEvents OpenFileDialog1 As OpenFileDialog
    Friend WithEvents Label3 As Label
    Friend WithEvents cmbsheets As ComboBox
    Friend WithEvents PanelHead As Panel
    Friend WithEvents PanelBody As Panel
End Class
