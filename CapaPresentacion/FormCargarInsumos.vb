Imports CapaNegocio
Imports System.ComponentModel
Imports System.Data.OleDb
Imports Microsoft.Office.Core
Imports System.IO
Imports ExcelDataReader


Public Class FormCargarInsumos

    Dim tables As DataTableCollection

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim objeto As UserModel = New UserModel
        DataGridView1.DataSource = objeto.mostrarAlgo()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles btnCargar.Click
        Using ofd As OpenFileDialog = New OpenFileDialog() With {.Filter = "Excel Workbook|*.xlsx|Excel 97-2003 Workbook|*xls"}
            If ofd.ShowDialog() = DialogResult.OK Then
                txtRuta.Text = ofd.FileName
                Try
                    Using stream = File.Open(ofd.FileName, FileMode.Open, FileAccess.Read)
                        Using reader As IExcelDataReader = ExcelReaderFactory.CreateReader(stream)
                            Dim result As DataSet = reader.AsDataSet(New ExcelDataSetConfiguration() With {
                                                                     .ConfigureDataTable = Function(__) New ExcelDataTableConfiguration() With {
                                                                     .UseHeaderRow = True}})
                            tables = result.Tables
                            cmbsheets.Items.Clear()
                            For Each table As DataTable In tables
                                cmbsheets.Items.Add(table.TableName)
                            Next
                        End Using
                    End Using
                Catch ex As Exception
                    txtRuta.Text = ""
                    cmbsheets.Enabled = False
                    MessageBox.Show("Error al cargar el archivo, por favor vuelva a intenarlo.")
                End Try
            End If
        End Using


    End Sub

    Private Sub cmbsheets_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbsheets.SelectedIndexChanged
        Dim dt As DataTable = tables(cmbsheets.SelectedItem.ToString())
        DataGridView1.DataSource = dt
        If cmbsheets.Text <> String.Empty Then
            btnGuardar.Enabled = True
        Else
            btnGuardar.Enabled = False
        End If
        'If txtRuta.Text <> String.Empty And cmbsheets.Text <> String.Empty Then
        '    btnexportar.Enabled = True
        'Else
        '    btnexportar.Enabled = False
        'End If
    End Sub

    Private Sub txtRuta_TextChanged(sender As Object, e As EventArgs) Handles txtRuta.TextChanged
        If txtRuta.Text <> String.Empty Then
            cmbsheets.Enabled = True
        Else
            cmbsheets.Enabled = False
        End If
    End Sub

    Private Sub btnGuardar_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click
        Dim contador As Integer = 0
        Dim cadenaError As String = Nothing
        Dim cantErrores As Integer = 0
        Dim capturoCatch As Integer = 0

        If cmbInsumo.Text = "EI1 Encuesta de inventarios" Then
            If File.Exists("C:\Users\aortizri\Downloads\prueba\EI1_ENCUESTA_INVENTARIOS.xlsx") Then
                If MessageBox.Show("El formato ya se encuentra cargado en el sistema, desea reemplazarlo?", "Confirmar", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then

                End If
            Else
                MessageBox.Show("No existe")
            End If

        ElseIf cmbInsumo.Text = "PI1 Inventario planes" Then
            If File.Exists("C:\Users\aortizri\Downloads\prueba\EI1_ENCUESTA_INVENTARIOS.xlsx") Then
                If MessageBox.Show("El formato ya se encuentra cargado en el sistema, desea reemplazarlo?", "Confirmar", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
                    For i As Integer = 0 To DataGridView1.Rows.Count - 2 Step +1
                        If DataGridView1.Rows(i).Cells(0).Value.ToString <> "" And IsNumeric(DataGridView1.Rows(i).Cells(0).Value.ToString) And (DataGridView1.Rows(i).Cells(0).Value.ToString.Length = 8) Then
                            If DataGridView1.Rows(i).Cells(1).Value.ToString <> "" And IsNumeric(DataGridView1.Rows(i).Cells(1).Value.ToString) And (DataGridView1.Rows(i).Cells(1).Value.ToString.Length = 1) Then
                                If DataGridView1.Rows(i).Cells(2).Value.ToString <> "" And IsNumeric(DataGridView1.Rows(i).Cells(2).Value.ToString) Then
                                    If DataGridView1.Rows(i).Cells(3).Value.ToString <> "" And (DataGridView1.Rows(i).Cells(3).Value.ToString.Length < 20) Then
                                        contador = contador + 1
                                    Else
                                        cantErrores = cantErrores + 1
                                        cadenaError = cadenaError & cantErrores & " - El registro del campo NUM_RESOLUCION en la columna 4 y fila " & i + 1 & " no corresponde con los datos esperados. Valor recibido: " & DataGridView1.Rows(i).Cells(3).Value.ToString + vbCrLf
                                    End If
                                Else
                                    cantErrores = cantErrores + 1
                                    cadenaError = cadenaError & cantErrores & " - El registro del campo COSTO_REPOSICION en la columna 3 y fila " & i + 1 & " no corresponde con los datos esperados. Valor recibido: " & DataGridView1.Rows(i).Cells(2).Value.ToString + vbCrLf
                                End If
                            Else
                                cantErrores = cantErrores + 1
                                cadenaError = cadenaError & cantErrores & " - El registro del campo TIPOS_PLAN en la columna 2 y fila " & i + 1 & " no corresponde con los datos esperados. Valor recibido: " & DataGridView1.Rows(i).Cells(1).Value.ToString + vbCrLf
                            End If
                        Else
                            cantErrores = cantErrores + 1
                            cadenaError = cadenaError & cantErrores & " - El registro del campo ID_PLAN en la columna 1 y fila " & i + 1 & " no corresponde con los datos esperados. Valor recibido: " & DataGridView1.Rows(i).Cells(0).Value.ToString + vbCrLf
                        End If
                    Next
                    If cantErrores = 0 Then
                        Dim destino As String = "C:\Users\aortizri\Downloads\prueba\PI1_INVENTARIO_PLANES.xlsx"
                        Try
                            IO.File.Delete(destino)
                            IO.File.Copy(txtRuta.Text, destino)

                            cmbsheets.Items.Clear()

                        Catch ex As Exception
                            MessageBox.Show(ex.Message)
                            capturoCatch = capturoCatch + 1
                        End Try
                    End If
                    If capturoCatch = 0 Then
                        MessageBox.Show("Registros cargados: " & contador + cantErrores & vbCrLf & "Registro sin errores: " & contador & vbCrLf & "Errores encontrados: " & cantErrores & vbCrLf & cadenaError)
                        txtRuta.Text = ""
                        cmbsheets.Text = ""
                        DataGridView1.DataSource = ""
                        btnGuardar.Enabled = False
                    End If
                Else
                    MessageBox.Show("No paso nada de nada")
                End If
            End If

        ElseIf cmbInsumo.Text = "PI3 Inventario proyectos" Then
            For i As Integer = 0 To DataGridView1.Rows.Count - 2 Step +1
                If DataGridView1.Rows(i).Cells(0).Value.ToString <> "" And DataGridView1.Rows(i).Cells(0).Value.ToString.Length <= 20 Then  'ID_PLAN
                    If DataGridView1.Rows(i).Cells(1).Value.ToString <> "" And DataGridView1.Rows(i).Cells(1).Value.ToString.Length <= 20 Then  'ID_PROYECTO
                        If DataGridView1.Rows(i).Cells(2).Value.ToString <> "" And DataGridView1.Rows(i).Cells(2).Value.ToString.Length <= 20 Then  'ID_PROYECTO_PLAN_ANTERIOR
                            If IsNumeric(DataGridView1.Rows(i).Cells(3).Value.ToString) And DataGridView1.Rows(i).Cells(3).Value.ToString.Length <= 1 Then  'TIPO_PROYECTO
                                If DataGridView1.Rows(i).Cells(4).Value.ToString.Length <= 400 Then 'OBJETIVO_PROYECTO_CODIGO
                                    If IsNumeric(DataGridView1.Rows(i).Cells(5).Value.ToString) And DataGridView1.Rows(i).Cells(5).Value.ToString.Length <= 1 Then  'ACTIVIDADES_RELACIONADAS_PROYECTO
                                        If DataGridView1.Rows(i).Cells(6).Value.ToString.Length <= 400 Then 'DESCRIPCION_PROYECTO
                                            If DataGridView1.Rows(i).Cells(7).Value.ToString.Length <= 400 Then 'BENEFICIOS_ESPERADOS
                                                If IsNumeric(DataGridView1.Rows(i).Cells(8).Value.ToString) And DataGridView1.Rows(i).Cells(8).Value.ToString.Length <= 13 Then 'VALOR_REGULATORIO_APROBADO
                                                    If IsNumeric(DataGridView1.Rows(i).Cells(9).Value.ToString) And DataGridView1.Rows(i).Cells(9).Value.ToString.Length <= 14 Then 'RELACION_BENEFICIO_COSTO
                                                        If DataGridView1.Rows(i).Cells(12).Value.ToString.Length <= 20 Then 'APROBACION_UPME
                                                            If DataGridView1.Rows(i).Cells(13).Value.ToString.Length <= 500 Then    'OBSERVACIONES
                                                                If DataGridView1.Rows(i).Cells(14).Value.ToString <> "" And DataGridView1.Rows(i).Cells(14).Value.ToString.Length <= 3 Then 'ID_MERCADO
                                                                    contador = contador + 1
                                                                Else
                                                                    cantErrores = cantErrores + 1
                                                                    cadenaError = cadenaError & cantErrores & " - El registro del campo ID MERCADO en la columna 15 y fila " & i + 1 & " no corresponde con los datos esperados. Valor recibido: " & DataGridView1.Rows(i).Cells(14).Value.ToString + vbCrLf
                                                                End If
                                                            Else
                                                                    cantErrores = cantErrores + 1
                                                                cadenaError = cadenaError & cantErrores & " - El registro del campo OBSERVACIONES en la columna 14 y fila " & i + 1 & " excede el número de caracteres esperados (500). Valor recibido: " & DataGridView1.Rows(i).Cells(13).Value.ToString + vbCrLf
                                                            End If
                                                        Else
                                                            cantErrores = cantErrores + 1
                                                            cadenaError = cadenaError & cantErrores & " - El registro del campo APROBACION UPME en la columna 13 y fila " & i + 1 & " excede el número de caracteres esperados (20). Valor recibido: " & DataGridView1.Rows(i).Cells(12).Value.ToString + vbCrLf
                                                        End If
                                                    Else
                                                        cantErrores = cantErrores + 1
                                                        cadenaError = cadenaError & cantErrores & " - El registro del campo RELACIÓN BENEFICIO COSTO en la columna 10 y fila " & i + 1 & " no corresponde con los datos esperados. Valor recibido: " & DataGridView1.Rows(i).Cells(9).Value.ToString + vbCrLf
                                                    End If
                                                Else
                                                    cantErrores = cantErrores + 1
                                                    cadenaError = cadenaError & cantErrores & " - El registro del campo VALOR REGULATORIO APROBADO en la columna 9 y fila " & i + 1 & " no corresponde con los datos esperados. Valor recibido: " & DataGridView1.Rows(i).Cells(8).Value.ToString + vbCrLf
                                                End If
                                            Else
                                                cantErrores = cantErrores + 1
                                                cadenaError = cadenaError & cantErrores & " - El registro del campo BENEFICIOS ESPERADOS en la columna 8 y fila " & i + 1 & " excede el número de caracteres esperados (400). Valor recibido: " & DataGridView1.Rows(i).Cells(7).Value.ToString + vbCrLf
                                            End If
                                        Else
                                            cantErrores = cantErrores + 1
                                            cadenaError = cadenaError & cantErrores & " - El registro del campo DESCRIPCIÓN DEL PROYECTO en la columna 7 y fila " & i + 1 & " excede el número de caracteres esperados (400). Valor recibido: " & DataGridView1.Rows(i).Cells(6).Value.ToString + vbCrLf
                                        End If
                                    Else
                                        cantErrores = cantErrores + 1
                                        cadenaError = cadenaError & cantErrores & " - El registro del campo ACTIVIDADES RELACIONADAS AL PROYECTO en la columna 6 y fila " & i + 1 & " no corresponde con los datos esperados. Valor recibido: " & DataGridView1.Rows(i).Cells(5).Value.ToString + vbCrLf
                                    End If
                                Else
                                    cantErrores = cantErrores + 1
                                    cadenaError = cadenaError & cantErrores & " - El registro del campo OBJETIVO PROYECTO CÓDIGO en la columna 5 y fila " & i + 1 & " excede el número de caracteres esperados (400). Valor recibido: " & DataGridView1.Rows(i).Cells(4).Value.ToString + vbCrLf
                                End If
                            Else
                                cantErrores = cantErrores + 1
                                cadenaError = cadenaError & cantErrores & " - El registro del campo TIPO PROYECTO en la columna 4 y fila " & i + 1 & " no corresponde con los datos esperados. Valor recibido: " & DataGridView1.Rows(i).Cells(3).Value.ToString + vbCrLf
                            End If
                        Else
                            cantErrores = cantErrores + 1
                            cadenaError = cadenaError & cantErrores & " - El registro del campo ID PROYECTO PLAN ANTERIOR en la columna 3 y fila " & i + 1 & " no corresponde con los datos esperados. Valor recibido: " & DataGridView1.Rows(i).Cells(2).Value.ToString + vbCrLf
                        End If
                    Else
                        cantErrores = cantErrores + 1
                        cadenaError = cadenaError & cantErrores & " - El registro del campo ID PROYECTO en la columna 2 y fila " & i + 1 & " no corresponde con los datos esperados. Valor recibido: " & DataGridView1.Rows(i).Cells(1).Value.ToString + vbCrLf
                    End If
                Else
                    cantErrores = cantErrores + 1
                    cadenaError = cadenaError & cantErrores & " - El registro del campo ID PROYECTO en la columna 1 y fila " & i + 1 & " no corresponde con los datos esperados. Valor recibido: " & DataGridView1.Rows(i).Cells(0).Value.ToString + vbCrLf
                End if
            Next
            If cantErrores = 0 Then
                Dim destino As String = "C:\Users\aortizri\Downloads\prueba\PI3_INVENTARIO_PROYECTOS.xlsx"
                Try
                    IO.File.Delete(destino)
                    IO.File.Copy(txtRuta.Text, destino)
                    cmbsheets.Items.Clear()
                Catch ex As Exception
                    MessageBox.Show(ex.Message)
                    capturoCatch = capturoCatch + 1
                End Try
            End If
            If capturoCatch = 0 Then
                MessageBox.Show("Registros cargados: " & contador + cantErrores & vbCrLf & "Registro sin errores: " & contador & vbCrLf & "Errores encontrados: " & cantErrores & vbCrLf & cadenaError)
                txtRuta.Text = ""
                cmbsheets.Text = ""
                DataGridView1.DataSource = ""
                btnGuardar.Enabled = False
            End If
        End If
    End Sub

    Private Sub cmbInsumo_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbInsumo.SelectedIndexChanged
        If cmbInsumo.Text <> "" Then
            btnCargar.Enabled = True
            btnEliminar.Enabled = True
        Else
            btnCargar.Enabled = False
            btnEliminar.Enabled = False
        End If
    End Sub
End Class