<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormBRA
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
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.lbl3 = New System.Windows.Forms.Label()
        Me.lbl2 = New System.Windows.Forms.Label()
        Me.lbl1 = New System.Windows.Forms.Label()
        Me.lblresponsable = New System.Windows.Forms.Label()
        Me.lblperiodicidad = New System.Windows.Forms.Label()
        Me.lbldescripcion = New System.Windows.Forms.Label()
        Me.cmbBRA = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.lbl3)
        Me.Panel1.Controls.Add(Me.lbl2)
        Me.Panel1.Controls.Add(Me.lbl1)
        Me.Panel1.Controls.Add(Me.lblresponsable)
        Me.Panel1.Controls.Add(Me.lblperiodicidad)
        Me.Panel1.Controls.Add(Me.lbldescripcion)
        Me.Panel1.Controls.Add(Me.cmbBRA)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(684, 60)
        Me.Panel1.TabIndex = 13
        '
        'lbl3
        '
        Me.lbl3.AutoSize = True
        Me.lbl3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl3.Location = New System.Drawing.Point(226, 32)
        Me.lbl3.Name = "lbl3"
        Me.lbl3.Size = New System.Drawing.Size(84, 13)
        Me.lbl3.TabIndex = 7
        Me.lbl3.Text = "Responsable:"
        Me.lbl3.Visible = False
        '
        'lbl2
        '
        Me.lbl2.AutoSize = True
        Me.lbl2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl2.Location = New System.Drawing.Point(226, 19)
        Me.lbl2.Name = "lbl2"
        Me.lbl2.Size = New System.Drawing.Size(81, 13)
        Me.lbl2.TabIndex = 6
        Me.lbl2.Text = "Periodicidad:"
        Me.lbl2.Visible = False
        '
        'lbl1
        '
        Me.lbl1.AutoSize = True
        Me.lbl1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl1.Location = New System.Drawing.Point(226, 6)
        Me.lbl1.Name = "lbl1"
        Me.lbl1.Size = New System.Drawing.Size(54, 13)
        Me.lbl1.TabIndex = 5
        Me.lbl1.Text = "Nombre:"
        Me.lbl1.Visible = False
        '
        'lblresponsable
        '
        Me.lblresponsable.AutoSize = True
        Me.lblresponsable.Location = New System.Drawing.Point(309, 32)
        Me.lblresponsable.Name = "lblresponsable"
        Me.lblresponsable.Size = New System.Drawing.Size(64, 13)
        Me.lblresponsable.TabIndex = 4
        Me.lblresponsable.Text = "responsable"
        Me.lblresponsable.Visible = False
        '
        'lblperiodicidad
        '
        Me.lblperiodicidad.AutoSize = True
        Me.lblperiodicidad.Location = New System.Drawing.Point(309, 19)
        Me.lblperiodicidad.Name = "lblperiodicidad"
        Me.lblperiodicidad.Size = New System.Drawing.Size(64, 13)
        Me.lblperiodicidad.TabIndex = 3
        Me.lblperiodicidad.Text = "periodicidad"
        Me.lblperiodicidad.Visible = False
        '
        'lbldescripcion
        '
        Me.lbldescripcion.AutoSize = True
        Me.lbldescripcion.Location = New System.Drawing.Point(309, 6)
        Me.lbldescripcion.Name = "lbldescripcion"
        Me.lbldescripcion.Size = New System.Drawing.Size(61, 13)
        Me.lbldescripcion.TabIndex = 2
        Me.lbldescripcion.Text = "descripcion"
        Me.lbldescripcion.Visible = False
        '
        'cmbBRA
        '
        Me.cmbBRA.FormattingEnabled = True
        Me.cmbBRA.Items.AddRange(New Object() {"BRA 1", "BRA 2", "BRA 3", "BRA 4", "BRA 5", "BRA 6", "BRA 7", "BRA 8", "BRA 9", "BRA 10", "BRA 11", "BRA 12", "BRA 13"})
        Me.cmbBRA.Location = New System.Drawing.Point(98, 9)
        Me.cmbBRA.Name = "cmbBRA"
        Me.cmbBRA.Size = New System.Drawing.Size(121, 21)
        Me.cmbBRA.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(3, 12)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(88, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "FORMATO BRA:"
        '
        'Panel2
        '
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel2.Location = New System.Drawing.Point(0, 60)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(684, 461)
        Me.Panel2.TabIndex = 14
        '
        'FormBRA
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(684, 521)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "FormBRA"
        Me.Text = "Formatos BRA"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents cmbBRA As ComboBox
    Friend WithEvents Label1 As Label
    Friend WithEvents lblresponsable As Label
    Friend WithEvents lblperiodicidad As Label
    Friend WithEvents lbldescripcion As Label
    Friend WithEvents lbl3 As Label
    Friend WithEvents lbl2 As Label
    Friend WithEvents lbl1 As Label
End Class
