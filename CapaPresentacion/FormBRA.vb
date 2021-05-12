Public Class FormBRA
    Private Sub cmbBRA_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbBRA.SelectedIndexChanged
        If cmbBRA.Text <> String.Empty Then
            lbl1.Visible = True
            lbl2.Visible = True
            lbl3.Visible = True
            lbldescripcion.Visible = True
            lblperiodicidad.Visible = True
            lblresponsable.Visible = True
            If cmbBRA.Text = "BRA 1" Then
                lbldescripcion.Text = "Infomación General de Subestaciones"
                lblperiodicidad.Text = "Mensual por demanda"
                lblresponsable.Text = "Orlando Qintana"
            ElseIf cmbBRA.Text = "BRA 2" Then
                lbldescripcion.Text = "Unidades Constructivas de Subestaciones"
                lblperiodicidad.Text = "Anual"
                lblresponsable.Text = "Orlando Qintana"
            ElseIf cmbBRA.Text = "BRA 3" Then
                lbldescripcion.Text = "Unidades Constructivas de Equipos de Subestación"
                lblperiodicidad.Text = "Mensual por demanda"
                lblresponsable.Text = "Orlando Qintana"
            ElseIf cmbBRA.Text = "BRA 4" Then
                lbldescripcion.Text = "Unidades Constructivas de Transformadores en Subestaciones"
                lblperiodicidad.Text = "Anual"
                lblresponsable.Text = "Orlando Qintana"
            ElseIf cmbBRA.Text = "BRA 5" Then
                lbldescripcion.Text = "Unidades Constructivas de Compensación Reactivas en Subestaciones"
                lblperiodicidad.Text = "Anual por demanda"
                lblresponsable.Text = "Orlando Qintana"
            ElseIf cmbBRA.Text = "BRA 6" Then
                lbldescripcion.Text = "Unidades Constructivas de Centros de Control"
                lblperiodicidad.Text = "Anual por demanda"
                lblresponsable.Text = "Orlando Qintana"
            ElseIf cmbBRA.Text = "BRA 7" Then
                lbldescripcion.Text = "Información General Circuitos"
                lblperiodicidad.Text = "Mensual por demanda"
                lblresponsable.Text = "Dany Arevalo"
            ElseIf cmbBRA.Text = "BRA 8" Then
                lbldescripcion.Text = "Unidades Constructivas de Lineas"
                lblperiodicidad.Text = "Mensual por demanda"
                lblresponsable.Text = "Leonardo Astudillo"
            ElseIf cmbBRA.Text = "BRA 9" Then
                lbldescripcion.Text = "Unidades Constructivas de Equipos de Lineas"
                lblperiodicidad.Text = "Anual por demanda"
                lblresponsable.Text = "Dany Arevalo"
            ElseIf cmbBRA.Text = "BRA 10" Then
                lbldescripcion.Text = "Unidades Constructivas de Redes de Distribución - Despues de 015"
                lblperiodicidad.Text = "Anual por demanda"
                lblresponsable.Text = "Leonardo Astudillo"
            ElseIf cmbBRA.Text = "BRA 11" Then
                lbldescripcion.Text = "Unidades Constructivas de Transformadores de Distribución - Despues de 015"
                lblperiodicidad.Text = "Mensual por demanda"
                lblresponsable.Text = "Edward Orduz"
            ElseIf cmbBRA.Text = "BRA 12" Then
                lbldescripcion.Text = "Unidades Constructivas Especiales"
                lblperiodicidad.Text = "Anual por demanda"
                lblresponsable.Text = "Orlando Qintana"
            ElseIf cmbBRA.Text = "BRA 13" Then
                lbldescripcion.Text = "Unidades Constructivas Transformadores y Redes de Baja Tensión - BRA"
                lblperiodicidad.Text = "Anual por demanda"
                lblresponsable.Text = "Edward Orduz"
            End If
        Else
            lbl1.Visible = False
            lbl2.Visible = False
            lbl3.Visible = False
            lbldescripcion.Visible = False
            lblperiodicidad.Visible = False
            lblresponsable.Visible = False
        End If


    End Sub
End Class