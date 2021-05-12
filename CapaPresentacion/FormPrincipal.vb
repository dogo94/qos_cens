'Imports CapaNegocio
Imports System.Runtime.InteropServices                  'utilizada para permitir las librerias nativas del Sistema Operativo
Imports FontAwesome.Sharp                               'libreria para usar iconos de fontawesome

Public Class FormPrincipal

    'Fields
    Private currentBtn As IconButton
    Private leftBorderBtn As Panel
    Private currentChildForm As Form

    Private currentForm As Form = Nothing

    'Constructor
    Public Sub New()
        ' This call is required by the designer.'
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.'
        leftBorderBtn = New Panel
        leftBorderBtn.Size = New Size(7, 60)
        PanelMenu.Controls.Add(leftBorderBtn)

        'Form'
        Me.Text = String.Empty
        Me.ControlBox = False
        Me.DoubleBuffered = True
        Me.MaximizedBounds = Screen.PrimaryScreen.WorkingArea
    End Sub

    Private Sub FormPrincipal2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        hideSubmenu()
    End Sub

#Region "Metodos"
    'Metodo para resaltar el boton activo (recibe un objeto y un color)
    Private Sub ActivarBoton(senderBtn As Object, customColor As Color)
        If senderBtn IsNot Nothing Then     'verificamos que el boton sea diferente a nulo
            DesactivarBoton()
            'Boton
            currentBtn = CType(senderBtn, IconButton)   'asignamos el boton actual al boton remitente
            currentBtn.BackColor = Color.FromArgb(37, 36, 81)   'cambiar el color de fondo del boton
            currentBtn.ForeColor = customColor  'cambiar el color del texto del boton
            currentBtn.IconColor = customColor  'cambiar el color del icono
            currentBtn.TextAlign = ContentAlignment.MiddleCenter    'alinear el texto al centro
            currentBtn.ImageAlign = ContentAlignment.MiddleRight    'alinear icono a la derecha
            currentBtn.TextImageRelation = TextImageRelation.TextBeforeImage    'poner relacion texto antes de imagen
            'Panel borde izquierdo del boton
            leftBorderBtn.BackColor = customColor
            leftBorderBtn.Location = New Point(0, currentBtn.Location.Y)    'obtener localización del eje y del boton
            leftBorderBtn.Visible = True
            leftBorderBtn.BringToFront()
            'Cambiar el ciono de la barra del titulo'
            IconCurrentForm.IconChar = currentBtn.IconChar
            IconCurrentForm.IconColor = customColor
        End If
    End Sub

    'Metodo par descativar el resaltado del boton, se colocaran los valores por defecto
    Private Sub DesactivarBoton()
        If currentBtn IsNot Nothing Then
            currentBtn.BackColor = Color.FromArgb(31, 30, 68)
            currentBtn.ForeColor = Color.Gainsboro
            currentBtn.IconColor = Color.Gainsboro
            currentBtn.TextAlign = ContentAlignment.MiddleLeft
            currentBtn.ImageAlign = ContentAlignment.MiddleLeft
            currentBtn.TextImageRelation = TextImageRelation.ImageBeforeText
        End If
    End Sub

    Private Sub hideSubmenu()                           'Utilizado para ocultar los paneles de los submenu
        PanelSubMenuArchivo.Visible = False
        PanelSubMenuLAC.Visible = False
        PanelSubMenuSUI.Visible = False
        PanelSubMenuIndicadores.Visible = False
        PanelSubMenuCDL.Visible = False
        PanelSubMenuVerificacionInformacion.Visible = False
    End Sub

    Private Sub showSubmenu(submenu As Panel)           'utilizado para mostrar el panel submenu
        If submenu.Visible = False Then                 'si panel submenu esta oculto, entonces se muestra el submenu
            hideSubmenu()
            submenu.Visible = True
        Else                                            'si el submenu esta visible, se oculta el submenu
            submenu.Visible = False
        End If
    End Sub

    Private Sub openChildForm(childForm As Form)                        'abrir formularios hijos en el panel contenedor
        If currentForm IsNot Nothing Then                               'si existe un formulario abirto, entonces se cierra.
            currentForm.Close()
        End If
        currentForm = childForm                                         'formulario actual sera igual al formulario hijo
        childForm.TopLevel = False                                      'el formulario hijo no es de nivel superior, se comportara igual que un control
        childForm.FormBorderStyle = FormBorderStyle.None                'quitar el borde del formulario
        childForm.Dock = DockStyle.Fill                                 'rellenar todo el contenedor
        PanelChildForm.Controls.Add(childForm)
        PanelChildForm.Tag = childForm
        childForm.BringToFront()
        childForm.Show()
        lblFormTitle.Text = childForm.Text
    End Sub

    'metodo para reiniciar todos los valores por defecto
    Private Sub Reset()
        DesactivarBoton()
        leftBorderBtn.Visible = False
        IconCurrentForm.IconChar = IconChar.Home
        IconCurrentForm.IconColor = Color.GreenYellow
        lblFormTitle.Text = "QoS"
    End Sub

    'Arrastrar formulario desde el panel superior
    <DllImport("user32.DLL", EntryPoint:="ReleaseCapture")>
    Private Shared Sub ReleaseCapture()
    End Sub
    <DllImport("user32.DLL", EntryPoint:="SendMessage")>
    Private Shared Sub SendMessage(ByVal hWnd As System.IntPtr, ByVal wMsg As Integer, ByVal wParam As Integer, ByVal lParam As Integer)
    End Sub
#End Region

    Private Sub btnArchivo_Click(sender As Object, e As EventArgs) Handles btnArchivo.Click
        showSubmenu(PanelSubMenuArchivo)
    End Sub

    Private Sub btnGeneracionLAC_Click(sender As Object, e As EventArgs) Handles btnGeneracionLAC.Click
        showSubmenu(PanelSubMenuLAC)
    End Sub

    Private Sub btnGeneracionSUI_Click(sender As Object, e As EventArgs) Handles btnGeneracionSUI.Click
        showSubmenu(PanelSubMenuSUI)
    End Sub

    Private Sub btnIndicadoresSeguimiento_Click(sender As Object, e As EventArgs) Handles btnIndicadores.Click
        showSubmenu(PanelSubMenuIndicadores)
    End Sub

    Private Sub btnCDL_Click(sender As Object, e As EventArgs) Handles btnCDL.Click
        showSubmenu(PanelSubMenuCDL)
    End Sub

    Private Sub btnVerificacionInformacion_Click(sender As Object, e As EventArgs) Handles btnVerificacionInformacion.Click
        showSubmenu(PanelSubMenuVerificacionInformacion)
    End Sub

    Private Sub btnIncentivosCompensaciones_Click(sender As Object, e As EventArgs) Handles btnIncentivosCompensaciones.Click

        '...
        'mi codigo
        '...
        hideSubmenu()
    End Sub

    Private Sub btnCargarInsumos_Click(sender As Object, e As EventArgs) Handles btnCargarInsumos.Click
        ActivarBoton(sender, RGBColors.color1)   'selecciona un color de la estructura creada RGBColors
        openChildForm(New FormCargarInsumos)    'abrir formulario hijo dentro del contenedor
        '...
        'mi codigo
        '...
        hideSubmenu()
    End Sub

    Private Sub btnCerrarPrograma_Click(sender As Object, e As EventArgs) Handles btnCerrarPrograma.Click
        Application.Exit()
    End Sub

    Private Sub btnFormatoDiario_Click(sender As Object, e As EventArgs) Handles btnFormatoDiario.Click
        ActivarBoton(sender, RGBColors.color2)   'selecciona un color de la estructura creada RGBColors
        openChildForm(New FormFormatoDiario)    'abrir formulario hijo dentro del contenedor
        '...
        'mi codigo
        '...
        hideSubmenu()
    End Sub

    Private Sub btnFormatoAjuste_Click(sender As Object, e As EventArgs) Handles btnFormatoAjuste.Click
        '...
        'mi codigo
        '...
        hideSubmenu()
    End Sub

    Private Sub btnFormatoAltoImpacto_Click(sender As Object, e As EventArgs) Handles btnFormatoAltoImpacto.Click
        '...
        'mi codigo
        '...
        hideSubmenu()
    End Sub

    Private Sub btnTC_Click(sender As Object, e As EventArgs) Handles btnTC.Click
        '...
        'mi codigo
        '...
        hideSubmenu()
    End Sub

    Private Sub btnTT_Click(sender As Object, e As EventArgs) Handles btnTT.Click
        '...
        'mi codigo
        '...
        hideSubmenu()
    End Sub

    Private Sub btnCS_Click(sender As Object, e As EventArgs) Handles btnCS.Click
        '...
        'mi codigo
        '...
        hideSubmenu()
    End Sub

    Private Sub btnBRA_Click(sender As Object, e As EventArgs) Handles btnBRA.Click
        ActivarBoton(sender, RGBColors.color3)   'selecciona un color de la estructura creada RGBColors
        openChildForm(New FormBRA)    'abrir formulario hijo dentro del contenedor
        '...
        'mi codigo
        '...
        hideSubmenu()
    End Sub

    Private Sub btnSAIDISAIFI_Click(sender As Object, e As EventArgs) Handles btnSAIDISAIFI.Click
        '...
        'mi codigo
        '...
        hideSubmenu()
    End Sub

    Private Sub btnGestionTraslapes_Click(sender As Object, e As EventArgs) Handles btnGestionTraslapes.Click
        '...
        'mi codigo
        '...
        hideSubmenu()
    End Sub

    Private Sub btnGestionMetas_Click(sender As Object, e As EventArgs) Handles btnGestionMetas.Click
        '...
        'mi codigo
        '...
        hideSubmenu()
    End Sub

    Private Sub btnParticularOR_Click(sender As Object, e As EventArgs) Handles btnParticularOR.Click
        '...
        'mi codigo
        '...
        hideSubmenu()
    End Sub

    Private Sub btnCREG025_Click(sender As Object, e As EventArgs) Handles btnCREG025.Click
        '...
        'mi codigo
        '...
        hideSubmenu()
    End Sub

    Private Sub imgHome_Click(sender As Object, e As EventArgs) Handles imgHome.Click
        If currentChildForm IsNot Nothing Then  'cerrar el form secundario actual siempre que el formluario actual no este vacio
            currentChildForm.Close()
        End If
        Reset()
    End Sub

    Private Sub PanelHead_MouseDown(sender As Object, e As MouseEventArgs) Handles PanelHead.MouseDown
        ReleaseCapture()
        SendMessage(Me.Handle, &H112&, &HF012&, 0)
    End Sub

    Private Sub FormPrincipal2_Resize(sender As Object, e As EventArgs) Handles Me.Resize
        If WindowState = FormWindowState.Maximized Then
            FormBorderStyle = FormBorderStyle.None
        Else
            FormBorderStyle = FormBorderStyle.Sizable
        End If
    End Sub

    Private Sub imgCerrar_Click(sender As Object, e As EventArgs) Handles imgCerrar.Click
        Application.Exit()
    End Sub

    Private Sub imgMaximizar_Click(sender As Object, e As EventArgs) Handles imgMaximizar.Click
        WindowState = FormWindowState.Maximized
        imgRestaurar.Visible = True
        imgMaximizar.Visible = False
    End Sub

    Private Sub imgMinimizar_Click(sender As Object, e As EventArgs) Handles imgMinimizar.Click
        WindowState = FormWindowState.Minimized
    End Sub

    Private Sub imgRestaurar_Click(sender As Object, e As EventArgs) Handles imgRestaurar.Click
        WindowState = FormWindowState.Normal
        imgMaximizar.Visible = True
        imgRestaurar.Visible = False
    End Sub

End Class