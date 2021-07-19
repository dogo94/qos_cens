Imports CapaNegocio

Public Class FormCkeckListTC1
    Dim CalpObj As CalpModel = New CalpModel()
    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs) Handles Panel1.Paint

    End Sub

    Private Sub FormCkeckListTC1_Load(sender As Object, e As EventArgs) Handles MyBase.Load


    End Sub

    Private Sub Generador_Click(sender As Object, e As EventArgs) Handles Generador.Click
        Console.WriteLine("BTN GENERAR")
        CalpObj.UpdateCalpTC1()

        If CheckedListBox1.GetItemChecked(1) = True Then
            Console.WriteLine("TT2 ESTOY SELECCIONADO")
        End If

        If CheckedListBox1.CheckedItems.Count = 3 Then
            'CalpObj.UpdateCalpTC1()
            Console.WriteLine("estan todos SELECCIONADOs")
        End If
    End Sub

    Private Sub CheckedListBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CheckedListBox1.SelectedIndexChanged

    End Sub
End Class