<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormPrincipal
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormPrincipal))
        Me.PanelMenu = New System.Windows.Forms.Panel()
        Me.btnIncentivosCompensaciones = New FontAwesome.Sharp.IconButton()
        Me.PanelSubMenuVerificacionInformacion = New System.Windows.Forms.Panel()
        Me.btnCREG025 = New FontAwesome.Sharp.IconButton()
        Me.btnParticularOR = New FontAwesome.Sharp.IconButton()
        Me.btnVerificacionInformacion = New FontAwesome.Sharp.IconButton()
        Me.PanelSubMenuCDL = New System.Windows.Forms.Panel()
        Me.btnGestionMetas = New FontAwesome.Sharp.IconButton()
        Me.btnGestionTraslapes = New FontAwesome.Sharp.IconButton()
        Me.btnCDL = New FontAwesome.Sharp.IconButton()
        Me.PanelSubMenuIndicadores = New System.Windows.Forms.Panel()
        Me.btnSAIDISAIFI = New FontAwesome.Sharp.IconButton()
        Me.btnIndicadores = New FontAwesome.Sharp.IconButton()
        Me.PanelSubMenuSUI = New System.Windows.Forms.Panel()
        Me.btnBRA = New FontAwesome.Sharp.IconButton()
        Me.btnCS = New FontAwesome.Sharp.IconButton()
        Me.btnTT = New FontAwesome.Sharp.IconButton()
        Me.btnTC = New FontAwesome.Sharp.IconButton()
        Me.btnGeneracionSUI = New FontAwesome.Sharp.IconButton()
        Me.PanelSubMenuLAC = New System.Windows.Forms.Panel()
        Me.btnFormatoAltoImpacto = New FontAwesome.Sharp.IconButton()
        Me.btnFormatoAjuste = New FontAwesome.Sharp.IconButton()
        Me.btnFormatoDiario = New FontAwesome.Sharp.IconButton()
        Me.btnGeneracionLAC = New FontAwesome.Sharp.IconButton()
        Me.PanelSubMenuArchivo = New System.Windows.Forms.Panel()
        Me.btnCerrarPrograma = New FontAwesome.Sharp.IconButton()
        Me.btnCargarInsumos = New FontAwesome.Sharp.IconButton()
        Me.btnArchivo = New FontAwesome.Sharp.IconButton()
        Me.PanelLogo = New System.Windows.Forms.Panel()
        Me.imgHome = New System.Windows.Forms.PictureBox()
        Me.PanelHead = New System.Windows.Forms.Panel()
        Me.imgMaximizar = New System.Windows.Forms.PictureBox()
        Me.imgRestaurar = New System.Windows.Forms.PictureBox()
        Me.imgMinimizar = New System.Windows.Forms.PictureBox()
        Me.imgCerrar = New System.Windows.Forms.PictureBox()
        Me.lblFormTitle = New System.Windows.Forms.Label()
        Me.IconCurrentForm = New FontAwesome.Sharp.IconPictureBox()
        Me.PanelChildForm = New System.Windows.Forms.Panel()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.PanelMenu.SuspendLayout()
        Me.PanelSubMenuVerificacionInformacion.SuspendLayout()
        Me.PanelSubMenuCDL.SuspendLayout()
        Me.PanelSubMenuIndicadores.SuspendLayout()
        Me.PanelSubMenuSUI.SuspendLayout()
        Me.PanelSubMenuLAC.SuspendLayout()
        Me.PanelSubMenuArchivo.SuspendLayout()
        Me.PanelLogo.SuspendLayout()
        CType(Me.imgHome, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelHead.SuspendLayout()
        CType(Me.imgMaximizar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.imgRestaurar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.imgMinimizar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.imgCerrar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.IconCurrentForm, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelChildForm.SuspendLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PanelMenu
        '
        Me.PanelMenu.AutoScroll = True
        Me.PanelMenu.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.PanelMenu.Controls.Add(Me.btnIncentivosCompensaciones)
        Me.PanelMenu.Controls.Add(Me.PanelSubMenuVerificacionInformacion)
        Me.PanelMenu.Controls.Add(Me.btnVerificacionInformacion)
        Me.PanelMenu.Controls.Add(Me.PanelSubMenuCDL)
        Me.PanelMenu.Controls.Add(Me.btnCDL)
        Me.PanelMenu.Controls.Add(Me.PanelSubMenuIndicadores)
        Me.PanelMenu.Controls.Add(Me.btnIndicadores)
        Me.PanelMenu.Controls.Add(Me.PanelSubMenuSUI)
        Me.PanelMenu.Controls.Add(Me.btnGeneracionSUI)
        Me.PanelMenu.Controls.Add(Me.PanelSubMenuLAC)
        Me.PanelMenu.Controls.Add(Me.btnGeneracionLAC)
        Me.PanelMenu.Controls.Add(Me.PanelSubMenuArchivo)
        Me.PanelMenu.Controls.Add(Me.btnArchivo)
        Me.PanelMenu.Controls.Add(Me.PanelLogo)
        Me.PanelMenu.Dock = System.Windows.Forms.DockStyle.Left
        Me.PanelMenu.Location = New System.Drawing.Point(0, 0)
        Me.PanelMenu.Name = "PanelMenu"
        Me.PanelMenu.Size = New System.Drawing.Size(250, 748)
        Me.PanelMenu.TabIndex = 2
        '
        'btnIncentivosCompensaciones
        '
        Me.btnIncentivosCompensaciones.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btnIncentivosCompensaciones.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnIncentivosCompensaciones.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnIncentivosCompensaciones.FlatAppearance.BorderSize = 0
        Me.btnIncentivosCompensaciones.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnIncentivosCompensaciones.ForeColor = System.Drawing.Color.Gainsboro
        Me.btnIncentivosCompensaciones.IconChar = FontAwesome.Sharp.IconChar.DollarSign
        Me.btnIncentivosCompensaciones.IconColor = System.Drawing.Color.Gainsboro
        Me.btnIncentivosCompensaciones.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.btnIncentivosCompensaciones.IconSize = 32
        Me.btnIncentivosCompensaciones.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnIncentivosCompensaciones.Location = New System.Drawing.Point(0, 1102)
        Me.btnIncentivosCompensaciones.Name = "btnIncentivosCompensaciones"
        Me.btnIncentivosCompensaciones.Padding = New System.Windows.Forms.Padding(5, 0, 20, 0)
        Me.btnIncentivosCompensaciones.Size = New System.Drawing.Size(233, 48)
        Me.btnIncentivosCompensaciones.TabIndex = 12
        Me.btnIncentivosCompensaciones.Text = "Incentivos y Compensaciones"
        Me.btnIncentivosCompensaciones.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnIncentivosCompensaciones.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnIncentivosCompensaciones.UseVisualStyleBackColor = False
        '
        'PanelSubMenuVerificacionInformacion
        '
        Me.PanelSubMenuVerificacionInformacion.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.PanelSubMenuVerificacionInformacion.Controls.Add(Me.btnCREG025)
        Me.PanelSubMenuVerificacionInformacion.Controls.Add(Me.btnParticularOR)
        Me.PanelSubMenuVerificacionInformacion.Dock = System.Windows.Forms.DockStyle.Top
        Me.PanelSubMenuVerificacionInformacion.Location = New System.Drawing.Point(0, 994)
        Me.PanelSubMenuVerificacionInformacion.Name = "PanelSubMenuVerificacionInformacion"
        Me.PanelSubMenuVerificacionInformacion.Size = New System.Drawing.Size(233, 108)
        Me.PanelSubMenuVerificacionInformacion.TabIndex = 11
        '
        'btnCREG025
        '
        Me.btnCREG025.BackColor = System.Drawing.Color.FromArgb(CType(CType(5, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(39, Byte), Integer))
        Me.btnCREG025.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnCREG025.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnCREG025.FlatAppearance.BorderSize = 0
        Me.btnCREG025.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCREG025.ForeColor = System.Drawing.Color.Gainsboro
        Me.btnCREG025.IconChar = FontAwesome.Sharp.IconChar.NetworkWired
        Me.btnCREG025.IconColor = System.Drawing.Color.Gainsboro
        Me.btnCREG025.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.btnCREG025.IconSize = 32
        Me.btnCREG025.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnCREG025.Location = New System.Drawing.Point(0, 42)
        Me.btnCREG025.Name = "btnCREG025"
        Me.btnCREG025.Padding = New System.Windows.Forms.Padding(25, 0, 20, 0)
        Me.btnCREG025.Size = New System.Drawing.Size(233, 42)
        Me.btnCREG025.TabIndex = 2
        Me.btnCREG025.Text = "CREG 025"
        Me.btnCREG025.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnCREG025.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnCREG025.UseVisualStyleBackColor = False
        '
        'btnParticularOR
        '
        Me.btnParticularOR.BackColor = System.Drawing.Color.FromArgb(CType(CType(5, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(39, Byte), Integer))
        Me.btnParticularOR.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnParticularOR.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnParticularOR.FlatAppearance.BorderSize = 0
        Me.btnParticularOR.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnParticularOR.ForeColor = System.Drawing.Color.Gainsboro
        Me.btnParticularOR.IconChar = FontAwesome.Sharp.IconChar.NetworkWired
        Me.btnParticularOR.IconColor = System.Drawing.Color.Gainsboro
        Me.btnParticularOR.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.btnParticularOR.IconSize = 32
        Me.btnParticularOR.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnParticularOR.Location = New System.Drawing.Point(0, 0)
        Me.btnParticularOR.Name = "btnParticularOR"
        Me.btnParticularOR.Padding = New System.Windows.Forms.Padding(25, 0, 20, 0)
        Me.btnParticularOR.Size = New System.Drawing.Size(233, 42)
        Me.btnParticularOR.TabIndex = 1
        Me.btnParticularOR.Text = "Particular OR"
        Me.btnParticularOR.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnParticularOR.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnParticularOR.UseVisualStyleBackColor = False
        '
        'btnVerificacionInformacion
        '
        Me.btnVerificacionInformacion.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btnVerificacionInformacion.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnVerificacionInformacion.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnVerificacionInformacion.FlatAppearance.BorderSize = 0
        Me.btnVerificacionInformacion.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnVerificacionInformacion.ForeColor = System.Drawing.Color.Gainsboro
        Me.btnVerificacionInformacion.IconChar = FontAwesome.Sharp.IconChar.Check
        Me.btnVerificacionInformacion.IconColor = System.Drawing.Color.Gainsboro
        Me.btnVerificacionInformacion.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.btnVerificacionInformacion.IconSize = 32
        Me.btnVerificacionInformacion.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnVerificacionInformacion.Location = New System.Drawing.Point(0, 946)
        Me.btnVerificacionInformacion.Name = "btnVerificacionInformacion"
        Me.btnVerificacionInformacion.Padding = New System.Windows.Forms.Padding(5, 0, 20, 0)
        Me.btnVerificacionInformacion.Size = New System.Drawing.Size(233, 48)
        Me.btnVerificacionInformacion.TabIndex = 10
        Me.btnVerificacionInformacion.Text = "Verificación de la información"
        Me.btnVerificacionInformacion.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnVerificacionInformacion.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnVerificacionInformacion.UseVisualStyleBackColor = False
        '
        'PanelSubMenuCDL
        '
        Me.PanelSubMenuCDL.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.PanelSubMenuCDL.Controls.Add(Me.btnGestionMetas)
        Me.PanelSubMenuCDL.Controls.Add(Me.btnGestionTraslapes)
        Me.PanelSubMenuCDL.Dock = System.Windows.Forms.DockStyle.Top
        Me.PanelSubMenuCDL.Location = New System.Drawing.Point(0, 838)
        Me.PanelSubMenuCDL.Name = "PanelSubMenuCDL"
        Me.PanelSubMenuCDL.Size = New System.Drawing.Size(233, 108)
        Me.PanelSubMenuCDL.TabIndex = 9
        '
        'btnGestionMetas
        '
        Me.btnGestionMetas.BackColor = System.Drawing.Color.FromArgb(CType(CType(5, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(39, Byte), Integer))
        Me.btnGestionMetas.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnGestionMetas.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnGestionMetas.FlatAppearance.BorderSize = 0
        Me.btnGestionMetas.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnGestionMetas.ForeColor = System.Drawing.Color.Gainsboro
        Me.btnGestionMetas.IconChar = FontAwesome.Sharp.IconChar.NetworkWired
        Me.btnGestionMetas.IconColor = System.Drawing.Color.Gainsboro
        Me.btnGestionMetas.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.btnGestionMetas.IconSize = 32
        Me.btnGestionMetas.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnGestionMetas.Location = New System.Drawing.Point(0, 42)
        Me.btnGestionMetas.Name = "btnGestionMetas"
        Me.btnGestionMetas.Padding = New System.Windows.Forms.Padding(25, 0, 20, 0)
        Me.btnGestionMetas.Size = New System.Drawing.Size(233, 42)
        Me.btnGestionMetas.TabIndex = 2
        Me.btnGestionMetas.Text = "Gestión de metas 360"
        Me.btnGestionMetas.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnGestionMetas.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnGestionMetas.UseVisualStyleBackColor = False
        '
        'btnGestionTraslapes
        '
        Me.btnGestionTraslapes.BackColor = System.Drawing.Color.FromArgb(CType(CType(5, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(39, Byte), Integer))
        Me.btnGestionTraslapes.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnGestionTraslapes.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnGestionTraslapes.FlatAppearance.BorderSize = 0
        Me.btnGestionTraslapes.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnGestionTraslapes.ForeColor = System.Drawing.Color.Gainsboro
        Me.btnGestionTraslapes.IconChar = FontAwesome.Sharp.IconChar.NetworkWired
        Me.btnGestionTraslapes.IconColor = System.Drawing.Color.Gainsboro
        Me.btnGestionTraslapes.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.btnGestionTraslapes.IconSize = 32
        Me.btnGestionTraslapes.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnGestionTraslapes.Location = New System.Drawing.Point(0, 0)
        Me.btnGestionTraslapes.Name = "btnGestionTraslapes"
        Me.btnGestionTraslapes.Padding = New System.Windows.Forms.Padding(25, 0, 20, 0)
        Me.btnGestionTraslapes.Size = New System.Drawing.Size(233, 42)
        Me.btnGestionTraslapes.TabIndex = 1
        Me.btnGestionTraslapes.Text = "Gestión de traslapes"
        Me.btnGestionTraslapes.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnGestionTraslapes.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnGestionTraslapes.UseVisualStyleBackColor = False
        '
        'btnCDL
        '
        Me.btnCDL.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btnCDL.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnCDL.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnCDL.FlatAppearance.BorderSize = 0
        Me.btnCDL.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCDL.ForeColor = System.Drawing.Color.Gainsboro
        Me.btnCDL.IconChar = FontAwesome.Sharp.IconChar.NetworkWired
        Me.btnCDL.IconColor = System.Drawing.Color.Gainsboro
        Me.btnCDL.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.btnCDL.IconSize = 32
        Me.btnCDL.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnCDL.Location = New System.Drawing.Point(0, 790)
        Me.btnCDL.Name = "btnCDL"
        Me.btnCDL.Padding = New System.Windows.Forms.Padding(5, 0, 20, 0)
        Me.btnCDL.Size = New System.Drawing.Size(233, 48)
        Me.btnCDL.TabIndex = 8
        Me.btnCDL.Text = "Procesos de operación CDL"
        Me.btnCDL.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnCDL.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnCDL.UseVisualStyleBackColor = False
        '
        'PanelSubMenuIndicadores
        '
        Me.PanelSubMenuIndicadores.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.PanelSubMenuIndicadores.Controls.Add(Me.btnSAIDISAIFI)
        Me.PanelSubMenuIndicadores.Dock = System.Windows.Forms.DockStyle.Top
        Me.PanelSubMenuIndicadores.Location = New System.Drawing.Point(0, 728)
        Me.PanelSubMenuIndicadores.Name = "PanelSubMenuIndicadores"
        Me.PanelSubMenuIndicadores.Size = New System.Drawing.Size(233, 62)
        Me.PanelSubMenuIndicadores.TabIndex = 7
        '
        'btnSAIDISAIFI
        '
        Me.btnSAIDISAIFI.BackColor = System.Drawing.Color.FromArgb(CType(CType(5, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(39, Byte), Integer))
        Me.btnSAIDISAIFI.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnSAIDISAIFI.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnSAIDISAIFI.FlatAppearance.BorderSize = 0
        Me.btnSAIDISAIFI.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSAIDISAIFI.ForeColor = System.Drawing.Color.Gainsboro
        Me.btnSAIDISAIFI.IconChar = FontAwesome.Sharp.IconChar.ChartLine
        Me.btnSAIDISAIFI.IconColor = System.Drawing.Color.Gainsboro
        Me.btnSAIDISAIFI.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.btnSAIDISAIFI.IconSize = 32
        Me.btnSAIDISAIFI.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnSAIDISAIFI.Location = New System.Drawing.Point(0, 0)
        Me.btnSAIDISAIFI.Name = "btnSAIDISAIFI"
        Me.btnSAIDISAIFI.Padding = New System.Windows.Forms.Padding(25, 0, 20, 0)
        Me.btnSAIDISAIFI.Size = New System.Drawing.Size(233, 42)
        Me.btnSAIDISAIFI.TabIndex = 1
        Me.btnSAIDISAIFI.Text = "Seguimiento SAID-SAIFI"
        Me.btnSAIDISAIFI.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnSAIDISAIFI.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnSAIDISAIFI.UseVisualStyleBackColor = False
        '
        'btnIndicadores
        '
        Me.btnIndicadores.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btnIndicadores.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnIndicadores.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnIndicadores.FlatAppearance.BorderSize = 0
        Me.btnIndicadores.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnIndicadores.ForeColor = System.Drawing.Color.Gainsboro
        Me.btnIndicadores.IconChar = FontAwesome.Sharp.IconChar.Cogs
        Me.btnIndicadores.IconColor = System.Drawing.Color.Gainsboro
        Me.btnIndicadores.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.btnIndicadores.IconSize = 32
        Me.btnIndicadores.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnIndicadores.Location = New System.Drawing.Point(0, 680)
        Me.btnIndicadores.Name = "btnIndicadores"
        Me.btnIndicadores.Padding = New System.Windows.Forms.Padding(5, 0, 20, 0)
        Me.btnIndicadores.Size = New System.Drawing.Size(233, 48)
        Me.btnIndicadores.TabIndex = 6
        Me.btnIndicadores.Text = "Indicadores de Seguimiento"
        Me.btnIndicadores.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnIndicadores.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnIndicadores.UseVisualStyleBackColor = False
        '
        'PanelSubMenuSUI
        '
        Me.PanelSubMenuSUI.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.PanelSubMenuSUI.Controls.Add(Me.btnBRA)
        Me.PanelSubMenuSUI.Controls.Add(Me.btnCS)
        Me.PanelSubMenuSUI.Controls.Add(Me.btnTT)
        Me.PanelSubMenuSUI.Controls.Add(Me.btnTC)
        Me.PanelSubMenuSUI.Dock = System.Windows.Forms.DockStyle.Top
        Me.PanelSubMenuSUI.Location = New System.Drawing.Point(0, 492)
        Me.PanelSubMenuSUI.Name = "PanelSubMenuSUI"
        Me.PanelSubMenuSUI.Size = New System.Drawing.Size(233, 188)
        Me.PanelSubMenuSUI.TabIndex = 5
        '
        'btnBRA
        '
        Me.btnBRA.BackColor = System.Drawing.Color.FromArgb(CType(CType(5, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(39, Byte), Integer))
        Me.btnBRA.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnBRA.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnBRA.FlatAppearance.BorderSize = 0
        Me.btnBRA.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnBRA.ForeColor = System.Drawing.Color.Gainsboro
        Me.btnBRA.IconChar = FontAwesome.Sharp.IconChar.Table
        Me.btnBRA.IconColor = System.Drawing.Color.Gainsboro
        Me.btnBRA.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.btnBRA.IconSize = 32
        Me.btnBRA.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnBRA.Location = New System.Drawing.Point(0, 126)
        Me.btnBRA.Name = "btnBRA"
        Me.btnBRA.Padding = New System.Windows.Forms.Padding(25, 0, 20, 0)
        Me.btnBRA.Size = New System.Drawing.Size(233, 42)
        Me.btnBRA.TabIndex = 4
        Me.btnBRA.Text = "Base regulatoria de activos (BRA)"
        Me.btnBRA.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnBRA.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnBRA.UseVisualStyleBackColor = False
        '
        'btnCS
        '
        Me.btnCS.BackColor = System.Drawing.Color.FromArgb(CType(CType(5, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(39, Byte), Integer))
        Me.btnCS.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnCS.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnCS.FlatAppearance.BorderSize = 0
        Me.btnCS.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCS.ForeColor = System.Drawing.Color.Gainsboro
        Me.btnCS.IconChar = FontAwesome.Sharp.IconChar.Table
        Me.btnCS.IconColor = System.Drawing.Color.Gainsboro
        Me.btnCS.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.btnCS.IconSize = 32
        Me.btnCS.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnCS.Location = New System.Drawing.Point(0, 84)
        Me.btnCS.Name = "btnCS"
        Me.btnCS.Padding = New System.Windows.Forms.Padding(25, 0, 20, 0)
        Me.btnCS.Size = New System.Drawing.Size(233, 42)
        Me.btnCS.TabIndex = 3
        Me.btnCS.Text = "Calidad de servicio (CS)"
        Me.btnCS.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnCS.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnCS.UseVisualStyleBackColor = False
        '
        'btnTT
        '
        Me.btnTT.BackColor = System.Drawing.Color.FromArgb(CType(CType(5, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(39, Byte), Integer))
        Me.btnTT.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnTT.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnTT.FlatAppearance.BorderSize = 0
        Me.btnTT.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnTT.ForeColor = System.Drawing.Color.Gainsboro
        Me.btnTT.IconChar = FontAwesome.Sharp.IconChar.Table
        Me.btnTT.IconColor = System.Drawing.Color.Gainsboro
        Me.btnTT.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.btnTT.IconSize = 32
        Me.btnTT.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnTT.Location = New System.Drawing.Point(0, 42)
        Me.btnTT.Name = "btnTT"
        Me.btnTT.Padding = New System.Windows.Forms.Padding(25, 0, 20, 0)
        Me.btnTT.Size = New System.Drawing.Size(233, 42)
        Me.btnTT.TabIndex = 2
        Me.btnTT.Text = "Transversal - Técnica (TT)"
        Me.btnTT.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnTT.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnTT.UseVisualStyleBackColor = False
        '
        'btnTC
        '
        Me.btnTC.BackColor = System.Drawing.Color.FromArgb(CType(CType(5, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(39, Byte), Integer))
        Me.btnTC.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnTC.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnTC.FlatAppearance.BorderSize = 0
        Me.btnTC.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnTC.ForeColor = System.Drawing.Color.Gainsboro
        Me.btnTC.IconChar = FontAwesome.Sharp.IconChar.Table
        Me.btnTC.IconColor = System.Drawing.Color.Gainsboro
        Me.btnTC.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.btnTC.IconSize = 32
        Me.btnTC.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnTC.Location = New System.Drawing.Point(0, 0)
        Me.btnTC.Name = "btnTC"
        Me.btnTC.Padding = New System.Windows.Forms.Padding(25, 0, 20, 0)
        Me.btnTC.Size = New System.Drawing.Size(233, 42)
        Me.btnTC.TabIndex = 1
        Me.btnTC.Text = "Transversal - Comercial (TC)"
        Me.btnTC.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnTC.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnTC.UseVisualStyleBackColor = False
        '
        'btnGeneracionSUI
        '
        Me.btnGeneracionSUI.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btnGeneracionSUI.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnGeneracionSUI.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnGeneracionSUI.FlatAppearance.BorderSize = 0
        Me.btnGeneracionSUI.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnGeneracionSUI.ForeColor = System.Drawing.Color.Gainsboro
        Me.btnGeneracionSUI.IconChar = FontAwesome.Sharp.IconChar.PlusCircle
        Me.btnGeneracionSUI.IconColor = System.Drawing.Color.Gainsboro
        Me.btnGeneracionSUI.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.btnGeneracionSUI.IconSize = 32
        Me.btnGeneracionSUI.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnGeneracionSUI.Location = New System.Drawing.Point(0, 444)
        Me.btnGeneracionSUI.Name = "btnGeneracionSUI"
        Me.btnGeneracionSUI.Padding = New System.Windows.Forms.Padding(5, 0, 20, 0)
        Me.btnGeneracionSUI.Size = New System.Drawing.Size(233, 48)
        Me.btnGeneracionSUI.TabIndex = 4
        Me.btnGeneracionSUI.Text = "Generacion de formatos SUI"
        Me.btnGeneracionSUI.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnGeneracionSUI.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnGeneracionSUI.UseVisualStyleBackColor = False
        '
        'PanelSubMenuLAC
        '
        Me.PanelSubMenuLAC.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.PanelSubMenuLAC.Controls.Add(Me.btnFormatoAltoImpacto)
        Me.PanelSubMenuLAC.Controls.Add(Me.btnFormatoAjuste)
        Me.PanelSubMenuLAC.Controls.Add(Me.btnFormatoDiario)
        Me.PanelSubMenuLAC.Dock = System.Windows.Forms.DockStyle.Top
        Me.PanelSubMenuLAC.Location = New System.Drawing.Point(0, 298)
        Me.PanelSubMenuLAC.Name = "PanelSubMenuLAC"
        Me.PanelSubMenuLAC.Size = New System.Drawing.Size(233, 146)
        Me.PanelSubMenuLAC.TabIndex = 3
        '
        'btnFormatoAltoImpacto
        '
        Me.btnFormatoAltoImpacto.BackColor = System.Drawing.Color.FromArgb(CType(CType(5, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(39, Byte), Integer))
        Me.btnFormatoAltoImpacto.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnFormatoAltoImpacto.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnFormatoAltoImpacto.FlatAppearance.BorderSize = 0
        Me.btnFormatoAltoImpacto.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnFormatoAltoImpacto.ForeColor = System.Drawing.Color.Gainsboro
        Me.btnFormatoAltoImpacto.IconChar = FontAwesome.Sharp.IconChar.Table
        Me.btnFormatoAltoImpacto.IconColor = System.Drawing.Color.Gainsboro
        Me.btnFormatoAltoImpacto.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.btnFormatoAltoImpacto.IconSize = 32
        Me.btnFormatoAltoImpacto.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnFormatoAltoImpacto.Location = New System.Drawing.Point(0, 84)
        Me.btnFormatoAltoImpacto.Name = "btnFormatoAltoImpacto"
        Me.btnFormatoAltoImpacto.Padding = New System.Windows.Forms.Padding(25, 0, 20, 0)
        Me.btnFormatoAltoImpacto.Size = New System.Drawing.Size(233, 42)
        Me.btnFormatoAltoImpacto.TabIndex = 3
        Me.btnFormatoAltoImpacto.Text = "Formato de alto impacto"
        Me.btnFormatoAltoImpacto.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnFormatoAltoImpacto.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnFormatoAltoImpacto.UseVisualStyleBackColor = False
        '
        'btnFormatoAjuste
        '
        Me.btnFormatoAjuste.BackColor = System.Drawing.Color.FromArgb(CType(CType(5, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(39, Byte), Integer))
        Me.btnFormatoAjuste.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnFormatoAjuste.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnFormatoAjuste.FlatAppearance.BorderSize = 0
        Me.btnFormatoAjuste.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnFormatoAjuste.ForeColor = System.Drawing.Color.Gainsboro
        Me.btnFormatoAjuste.IconChar = FontAwesome.Sharp.IconChar.Table
        Me.btnFormatoAjuste.IconColor = System.Drawing.Color.Gainsboro
        Me.btnFormatoAjuste.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.btnFormatoAjuste.IconSize = 32
        Me.btnFormatoAjuste.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnFormatoAjuste.Location = New System.Drawing.Point(0, 42)
        Me.btnFormatoAjuste.Name = "btnFormatoAjuste"
        Me.btnFormatoAjuste.Padding = New System.Windows.Forms.Padding(25, 0, 20, 0)
        Me.btnFormatoAjuste.Size = New System.Drawing.Size(233, 42)
        Me.btnFormatoAjuste.TabIndex = 2
        Me.btnFormatoAjuste.Text = "Formato de ajuste"
        Me.btnFormatoAjuste.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnFormatoAjuste.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnFormatoAjuste.UseVisualStyleBackColor = False
        '
        'btnFormatoDiario
        '
        Me.btnFormatoDiario.BackColor = System.Drawing.Color.FromArgb(CType(CType(5, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(39, Byte), Integer))
        Me.btnFormatoDiario.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnFormatoDiario.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnFormatoDiario.FlatAppearance.BorderSize = 0
        Me.btnFormatoDiario.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnFormatoDiario.ForeColor = System.Drawing.Color.Gainsboro
        Me.btnFormatoDiario.IconChar = FontAwesome.Sharp.IconChar.Table
        Me.btnFormatoDiario.IconColor = System.Drawing.Color.Gainsboro
        Me.btnFormatoDiario.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.btnFormatoDiario.IconSize = 32
        Me.btnFormatoDiario.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnFormatoDiario.Location = New System.Drawing.Point(0, 0)
        Me.btnFormatoDiario.Name = "btnFormatoDiario"
        Me.btnFormatoDiario.Padding = New System.Windows.Forms.Padding(25, 0, 20, 0)
        Me.btnFormatoDiario.Size = New System.Drawing.Size(233, 42)
        Me.btnFormatoDiario.TabIndex = 1
        Me.btnFormatoDiario.Text = "Formato diario"
        Me.btnFormatoDiario.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnFormatoDiario.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnFormatoDiario.UseVisualStyleBackColor = False
        '
        'btnGeneracionLAC
        '
        Me.btnGeneracionLAC.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btnGeneracionLAC.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnGeneracionLAC.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnGeneracionLAC.FlatAppearance.BorderSize = 0
        Me.btnGeneracionLAC.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnGeneracionLAC.ForeColor = System.Drawing.Color.Gainsboro
        Me.btnGeneracionLAC.IconChar = FontAwesome.Sharp.IconChar.PlusCircle
        Me.btnGeneracionLAC.IconColor = System.Drawing.Color.Gainsboro
        Me.btnGeneracionLAC.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.btnGeneracionLAC.IconSize = 32
        Me.btnGeneracionLAC.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnGeneracionLAC.Location = New System.Drawing.Point(0, 250)
        Me.btnGeneracionLAC.Name = "btnGeneracionLAC"
        Me.btnGeneracionLAC.Padding = New System.Windows.Forms.Padding(5, 0, 20, 0)
        Me.btnGeneracionLAC.Size = New System.Drawing.Size(233, 48)
        Me.btnGeneracionLAC.TabIndex = 2
        Me.btnGeneracionLAC.Text = "Generacion de formatos LAC"
        Me.btnGeneracionLAC.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnGeneracionLAC.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnGeneracionLAC.UseVisualStyleBackColor = False
        '
        'PanelSubMenuArchivo
        '
        Me.PanelSubMenuArchivo.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.PanelSubMenuArchivo.Controls.Add(Me.btnCerrarPrograma)
        Me.PanelSubMenuArchivo.Controls.Add(Me.btnCargarInsumos)
        Me.PanelSubMenuArchivo.Dock = System.Windows.Forms.DockStyle.Top
        Me.PanelSubMenuArchivo.Location = New System.Drawing.Point(0, 142)
        Me.PanelSubMenuArchivo.Name = "PanelSubMenuArchivo"
        Me.PanelSubMenuArchivo.Size = New System.Drawing.Size(233, 108)
        Me.PanelSubMenuArchivo.TabIndex = 1
        '
        'btnCerrarPrograma
        '
        Me.btnCerrarPrograma.BackColor = System.Drawing.Color.FromArgb(CType(CType(5, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(39, Byte), Integer))
        Me.btnCerrarPrograma.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnCerrarPrograma.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnCerrarPrograma.FlatAppearance.BorderSize = 0
        Me.btnCerrarPrograma.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCerrarPrograma.ForeColor = System.Drawing.Color.Gainsboro
        Me.btnCerrarPrograma.IconChar = FontAwesome.Sharp.IconChar.SignOutAlt
        Me.btnCerrarPrograma.IconColor = System.Drawing.Color.Gainsboro
        Me.btnCerrarPrograma.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.btnCerrarPrograma.IconSize = 32
        Me.btnCerrarPrograma.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnCerrarPrograma.Location = New System.Drawing.Point(0, 42)
        Me.btnCerrarPrograma.Name = "btnCerrarPrograma"
        Me.btnCerrarPrograma.Padding = New System.Windows.Forms.Padding(25, 0, 20, 0)
        Me.btnCerrarPrograma.Size = New System.Drawing.Size(233, 42)
        Me.btnCerrarPrograma.TabIndex = 2
        Me.btnCerrarPrograma.Text = "Cerrar programa"
        Me.btnCerrarPrograma.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnCerrarPrograma.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnCerrarPrograma.UseVisualStyleBackColor = False
        '
        'btnCargarInsumos
        '
        Me.btnCargarInsumos.BackColor = System.Drawing.Color.FromArgb(CType(CType(5, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(39, Byte), Integer))
        Me.btnCargarInsumos.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnCargarInsumos.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnCargarInsumos.FlatAppearance.BorderSize = 0
        Me.btnCargarInsumos.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCargarInsumos.ForeColor = System.Drawing.Color.Gainsboro
        Me.btnCargarInsumos.IconChar = FontAwesome.Sharp.IconChar.Upload
        Me.btnCargarInsumos.IconColor = System.Drawing.Color.Gainsboro
        Me.btnCargarInsumos.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.btnCargarInsumos.IconSize = 32
        Me.btnCargarInsumos.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnCargarInsumos.Location = New System.Drawing.Point(0, 0)
        Me.btnCargarInsumos.Name = "btnCargarInsumos"
        Me.btnCargarInsumos.Padding = New System.Windows.Forms.Padding(25, 0, 20, 0)
        Me.btnCargarInsumos.Size = New System.Drawing.Size(233, 42)
        Me.btnCargarInsumos.TabIndex = 1
        Me.btnCargarInsumos.Text = "Cargar insumos"
        Me.btnCargarInsumos.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnCargarInsumos.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnCargarInsumos.UseVisualStyleBackColor = False
        '
        'btnArchivo
        '
        Me.btnArchivo.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btnArchivo.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnArchivo.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnArchivo.FlatAppearance.BorderSize = 0
        Me.btnArchivo.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnArchivo.ForeColor = System.Drawing.Color.Gainsboro
        Me.btnArchivo.IconChar = FontAwesome.Sharp.IconChar.Archive
        Me.btnArchivo.IconColor = System.Drawing.Color.Gainsboro
        Me.btnArchivo.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.btnArchivo.IconSize = 32
        Me.btnArchivo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnArchivo.Location = New System.Drawing.Point(0, 94)
        Me.btnArchivo.Name = "btnArchivo"
        Me.btnArchivo.Padding = New System.Windows.Forms.Padding(5, 0, 20, 0)
        Me.btnArchivo.Size = New System.Drawing.Size(233, 48)
        Me.btnArchivo.TabIndex = 0
        Me.btnArchivo.Text = "Archivo"
        Me.btnArchivo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnArchivo.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnArchivo.UseVisualStyleBackColor = False
        '
        'PanelLogo
        '
        Me.PanelLogo.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.PanelLogo.Controls.Add(Me.imgHome)
        Me.PanelLogo.Dock = System.Windows.Forms.DockStyle.Top
        Me.PanelLogo.ForeColor = System.Drawing.SystemColors.WindowFrame
        Me.PanelLogo.Location = New System.Drawing.Point(0, 0)
        Me.PanelLogo.Name = "PanelLogo"
        Me.PanelLogo.Size = New System.Drawing.Size(233, 94)
        Me.PanelLogo.TabIndex = 0
        '
        'imgHome
        '
        Me.imgHome.Cursor = System.Windows.Forms.Cursors.Hand
        Me.imgHome.Image = CType(resources.GetObject("imgHome.Image"), System.Drawing.Image)
        Me.imgHome.Location = New System.Drawing.Point(38, 3)
        Me.imgHome.Name = "imgHome"
        Me.imgHome.Size = New System.Drawing.Size(159, 82)
        Me.imgHome.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.imgHome.TabIndex = 1
        Me.imgHome.TabStop = False
        '
        'PanelHead
        '
        Me.PanelHead.BackColor = System.Drawing.Color.FromArgb(CType(CType(3, Byte), Integer), CType(CType(21, Byte), Integer), CType(CType(32, Byte), Integer))
        Me.PanelHead.Controls.Add(Me.imgMaximizar)
        Me.PanelHead.Controls.Add(Me.imgRestaurar)
        Me.PanelHead.Controls.Add(Me.imgMinimizar)
        Me.PanelHead.Controls.Add(Me.imgCerrar)
        Me.PanelHead.Controls.Add(Me.lblFormTitle)
        Me.PanelHead.Controls.Add(Me.IconCurrentForm)
        Me.PanelHead.Cursor = System.Windows.Forms.Cursors.SizeAll
        Me.PanelHead.Dock = System.Windows.Forms.DockStyle.Top
        Me.PanelHead.Location = New System.Drawing.Point(250, 0)
        Me.PanelHead.Name = "PanelHead"
        Me.PanelHead.Size = New System.Drawing.Size(935, 41)
        Me.PanelHead.TabIndex = 3
        '
        'imgMaximizar
        '
        Me.imgMaximizar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.imgMaximizar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.imgMaximizar.Image = Global.CapaPresentacion.My.Resources.Resources.Icono_Maximizar
        Me.imgMaximizar.Location = New System.Drawing.Point(869, 3)
        Me.imgMaximizar.Name = "imgMaximizar"
        Me.imgMaximizar.Size = New System.Drawing.Size(29, 27)
        Me.imgMaximizar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.imgMaximizar.TabIndex = 9
        Me.imgMaximizar.TabStop = False
        '
        'imgRestaurar
        '
        Me.imgRestaurar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.imgRestaurar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.imgRestaurar.Image = Global.CapaPresentacion.My.Resources.Resources.Icono_Restaurar
        Me.imgRestaurar.Location = New System.Drawing.Point(869, 3)
        Me.imgRestaurar.Name = "imgRestaurar"
        Me.imgRestaurar.Size = New System.Drawing.Size(29, 27)
        Me.imgRestaurar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.imgRestaurar.TabIndex = 8
        Me.imgRestaurar.TabStop = False
        Me.imgRestaurar.Visible = False
        '
        'imgMinimizar
        '
        Me.imgMinimizar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.imgMinimizar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.imgMinimizar.Image = Global.CapaPresentacion.My.Resources.Resources.Icono_Minimizar
        Me.imgMinimizar.Location = New System.Drawing.Point(834, 3)
        Me.imgMinimizar.Name = "imgMinimizar"
        Me.imgMinimizar.Size = New System.Drawing.Size(29, 27)
        Me.imgMinimizar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.imgMinimizar.TabIndex = 7
        Me.imgMinimizar.TabStop = False
        '
        'imgCerrar
        '
        Me.imgCerrar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.imgCerrar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.imgCerrar.Image = Global.CapaPresentacion.My.Resources.Resources.Icono_cerrar_FN
        Me.imgCerrar.Location = New System.Drawing.Point(904, 3)
        Me.imgCerrar.Name = "imgCerrar"
        Me.imgCerrar.Size = New System.Drawing.Size(29, 27)
        Me.imgCerrar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.imgCerrar.TabIndex = 6
        Me.imgCerrar.TabStop = False
        '
        'lblFormTitle
        '
        Me.lblFormTitle.AutoSize = True
        Me.lblFormTitle.ForeColor = System.Drawing.Color.Gainsboro
        Me.lblFormTitle.Location = New System.Drawing.Point(44, 11)
        Me.lblFormTitle.Name = "lblFormTitle"
        Me.lblFormTitle.Size = New System.Drawing.Size(36, 17)
        Me.lblFormTitle.TabIndex = 1
        Me.lblFormTitle.Text = "QoS"
        '
        'IconCurrentForm
        '
        Me.IconCurrentForm.BackColor = System.Drawing.Color.FromArgb(CType(CType(3, Byte), Integer), CType(CType(21, Byte), Integer), CType(CType(32, Byte), Integer))
        Me.IconCurrentForm.ForeColor = System.Drawing.SystemColors.ActiveCaption
        Me.IconCurrentForm.IconChar = FontAwesome.Sharp.IconChar.Home
        Me.IconCurrentForm.IconColor = System.Drawing.SystemColors.ActiveCaption
        Me.IconCurrentForm.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.IconCurrentForm.Location = New System.Drawing.Point(6, 5)
        Me.IconCurrentForm.Name = "IconCurrentForm"
        Me.IconCurrentForm.Size = New System.Drawing.Size(32, 32)
        Me.IconCurrentForm.TabIndex = 0
        Me.IconCurrentForm.TabStop = False
        '
        'PanelChildForm
        '
        Me.PanelChildForm.BackColor = System.Drawing.Color.FromArgb(CType(CType(2, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(45, Byte), Integer))
        Me.PanelChildForm.Controls.Add(Me.PictureBox2)
        Me.PanelChildForm.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanelChildForm.Location = New System.Drawing.Point(250, 41)
        Me.PanelChildForm.Name = "PanelChildForm"
        Me.PanelChildForm.Size = New System.Drawing.Size(935, 707)
        Me.PanelChildForm.TabIndex = 4
        '
        'PictureBox2
        '
        Me.PictureBox2.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), System.Drawing.Image)
        Me.PictureBox2.Location = New System.Drawing.Point(389, 309)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(213, 82)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.PictureBox2.TabIndex = 3
        Me.PictureBox2.TabStop = False
        '
        'FormPrincipal
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1185, 748)
        Me.Controls.Add(Me.PanelChildForm)
        Me.Controls.Add(Me.PanelHead)
        Me.Controls.Add(Me.PanelMenu)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.MinimumSize = New System.Drawing.Size(950, 600)
        Me.Name = "FormPrincipal"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
        Me.Text = "FormPrincipal2"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.PanelMenu.ResumeLayout(False)
        Me.PanelSubMenuVerificacionInformacion.ResumeLayout(False)
        Me.PanelSubMenuCDL.ResumeLayout(False)
        Me.PanelSubMenuIndicadores.ResumeLayout(False)
        Me.PanelSubMenuSUI.ResumeLayout(False)
        Me.PanelSubMenuLAC.ResumeLayout(False)
        Me.PanelSubMenuArchivo.ResumeLayout(False)
        Me.PanelLogo.ResumeLayout(False)
        CType(Me.imgHome, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelHead.ResumeLayout(False)
        Me.PanelHead.PerformLayout()
        CType(Me.imgMaximizar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.imgRestaurar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.imgMinimizar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.imgCerrar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.IconCurrentForm, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelChildForm.ResumeLayout(False)
        Me.PanelChildForm.PerformLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents PanelMenu As Panel
    Friend WithEvents PanelLogo As Panel
    Friend WithEvents imgHome As PictureBox
    Friend WithEvents PanelHead As Panel
    Friend WithEvents PanelChildForm As Panel
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents PanelSubMenuArchivo As Panel
    Friend WithEvents btnCerrarPrograma As FontAwesome.Sharp.IconButton
    Friend WithEvents btnCargarInsumos As FontAwesome.Sharp.IconButton
    Friend WithEvents btnArchivo As FontAwesome.Sharp.IconButton
    Friend WithEvents PanelSubMenuLAC As Panel
    Friend WithEvents btnFormatoAltoImpacto As FontAwesome.Sharp.IconButton
    Friend WithEvents btnFormatoAjuste As FontAwesome.Sharp.IconButton
    Friend WithEvents btnFormatoDiario As FontAwesome.Sharp.IconButton
    Friend WithEvents btnGeneracionLAC As FontAwesome.Sharp.IconButton
    Friend WithEvents PanelSubMenuSUI As Panel
    Friend WithEvents btnCS As FontAwesome.Sharp.IconButton
    Friend WithEvents btnTT As FontAwesome.Sharp.IconButton
    Friend WithEvents btnTC As FontAwesome.Sharp.IconButton
    Friend WithEvents btnGeneracionSUI As FontAwesome.Sharp.IconButton
    Friend WithEvents PanelSubMenuCDL As Panel
    Friend WithEvents btnGestionMetas As FontAwesome.Sharp.IconButton
    Friend WithEvents btnGestionTraslapes As FontAwesome.Sharp.IconButton
    Friend WithEvents btnCDL As FontAwesome.Sharp.IconButton
    Friend WithEvents PanelSubMenuIndicadores As Panel
    Friend WithEvents btnSAIDISAIFI As FontAwesome.Sharp.IconButton
    Friend WithEvents btnIndicadores As FontAwesome.Sharp.IconButton
    Friend WithEvents btnBRA As FontAwesome.Sharp.IconButton
    Friend WithEvents btnIncentivosCompensaciones As FontAwesome.Sharp.IconButton
    Friend WithEvents PanelSubMenuVerificacionInformacion As Panel
    Friend WithEvents btnCREG025 As FontAwesome.Sharp.IconButton
    Friend WithEvents btnParticularOR As FontAwesome.Sharp.IconButton
    Friend WithEvents btnVerificacionInformacion As FontAwesome.Sharp.IconButton
    Friend WithEvents lblFormTitle As Label
    Friend WithEvents IconCurrentForm As FontAwesome.Sharp.IconPictureBox
    Friend WithEvents imgRestaurar As PictureBox
    Friend WithEvents imgMinimizar As PictureBox
    Friend WithEvents imgCerrar As PictureBox
    Friend WithEvents imgMaximizar As PictureBox
End Class
