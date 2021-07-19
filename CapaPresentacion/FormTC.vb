Imports CapaNegocio

Public Class FormTC

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub FormTC_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim thisDate As Date
        Dim MyMonth, mes, MesUpper
        thisDate = Today
        MyMonth = (Month(thisDate)) - 1
        mes = MonthName(MyMonth)
        MesUpper = StrConv(mes, vbUpperCase)
        Label1.Text = "MES DE GENERACION : " & MesUpper





    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs)


    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim Formchek As New FormCkeckListTC1()
        Formchek.ShowDialog()
        'CalpObj.UpdateCalpTC1()
    End Sub

    Private Sub TabPage1_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub GroupBox1_Enter(sender As Object, e As EventArgs) Handles GroupBox1.Enter

    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs)

    End Sub

    Private Sub PanelInterno_Paint(sender As Object, e As PaintEventArgs) Handles PanelInterno.Paint

    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged

    End Sub
End Class