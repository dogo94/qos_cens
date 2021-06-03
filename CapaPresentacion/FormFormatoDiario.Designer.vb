<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormFormatoDiario
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
        Me.ComboACCION = New System.Windows.Forms.ComboBox()
        Me.ComboSUBTIPO = New System.Windows.Forms.ComboBox()
        Me.ComboTIPO = New System.Windows.Forms.ComboBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.FDD_PERIODO_OP = New System.Windows.Forms.DateTimePicker()
        Me.ProgressBar = New System.Windows.Forms.ProgressBar()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ComboACCION
        '
        Me.ComboACCION.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ComboACCION.FormattingEnabled = True
        Me.ComboACCION.Location = New System.Drawing.Point(924, 11)
        Me.ComboACCION.Name = "ComboACCION"
        Me.ComboACCION.Size = New System.Drawing.Size(240, 28)
        Me.ComboACCION.TabIndex = 75
        '
        'ComboSUBTIPO
        '
        Me.ComboSUBTIPO.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ComboSUBTIPO.FormattingEnabled = True
        Me.ComboSUBTIPO.Location = New System.Drawing.Point(678, 12)
        Me.ComboSUBTIPO.Name = "ComboSUBTIPO"
        Me.ComboSUBTIPO.Size = New System.Drawing.Size(240, 28)
        Me.ComboSUBTIPO.TabIndex = 74
        '
        'ComboTIPO
        '
        Me.ComboTIPO.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ComboTIPO.FormattingEnabled = True
        Me.ComboTIPO.Location = New System.Drawing.Point(501, 11)
        Me.ComboTIPO.Name = "ComboTIPO"
        Me.ComboTIPO.Size = New System.Drawing.Size(171, 28)
        Me.ComboTIPO.TabIndex = 73
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(1170, 6)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(37, 36)
        Me.Button1.TabIndex = 72
        Me.Button1.Text = ">>"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(12, 14)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(157, 20)
        Me.Label1.TabIndex = 71
        Me.Label1.Text = "Fecha de Operación "
        '
        'FDD_PERIODO_OP
        '
        Me.FDD_PERIODO_OP.CalendarFont = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FDD_PERIODO_OP.CustomFormat = ""
        Me.FDD_PERIODO_OP.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FDD_PERIODO_OP.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.FDD_PERIODO_OP.Location = New System.Drawing.Point(174, 12)
        Me.FDD_PERIODO_OP.Name = "FDD_PERIODO_OP"
        Me.FDD_PERIODO_OP.Size = New System.Drawing.Size(321, 26)
        Me.FDD_PERIODO_OP.TabIndex = 70
        Me.FDD_PERIODO_OP.Value = New Date(2019, 6, 6, 7, 47, 0, 0)
        '
        'ProgressBar
        '
        Me.ProgressBar.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ProgressBar.Location = New System.Drawing.Point(17, 48)
        Me.ProgressBar.Name = "ProgressBar"
        Me.ProgressBar.Size = New System.Drawing.Size(1283, 10)
        Me.ProgressBar.TabIndex = 76
        '
        'DataGridView1
        '
        Me.DataGridView1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.DataGridView1.BackgroundColor = System.Drawing.SystemColors.Control
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(17, 64)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(1283, 445)
        Me.DataGridView1.TabIndex = 77
        '
        'FormFormatoDiario
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1311, 521)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.ProgressBar)
        Me.Controls.Add(Me.ComboACCION)
        Me.Controls.Add(Me.ComboSUBTIPO)
        Me.Controls.Add(Me.ComboTIPO)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.FDD_PERIODO_OP)
        Me.Name = "FormFormatoDiario"
        Me.Text = "Formato diario"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ComboACCION As ComboBox
    Friend WithEvents ComboSUBTIPO As ComboBox
    Friend WithEvents ComboTIPO As ComboBox
    Friend WithEvents Button1 As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents FDD_PERIODO_OP As DateTimePicker
    Friend WithEvents ProgressBar As ProgressBar
    Friend WithEvents DataGridView1 As DataGridView
End Class
