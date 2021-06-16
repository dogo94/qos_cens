Imports System.Data
Imports Oracle.ManagedDataAccess.Client
Imports Common

Public Class UserDao
    Inherits ConnectionToOracle

    Dim tabla As DataTable = New DataTable()
    Dim tabla2 As Integer = New Integer
    Dim leer As OracleDataReader

    Public Function mostrarAlgo() As DataTable
        Using connection = GetConnection()
            connection.Open()
            Using command = New OracleCommand()
                command.Connection = connection
                command.CommandText = "SELECT * FROM AC_TBRA11"
                Console.WriteLine("CONSOLA: " & command.CommandText)
                command.CommandType = CommandType.Text
                leer = command.ExecuteReader()  'Devuelve filas.
                tabla.Load(leer)
                leer.Dispose()
                connection.Close()
                Return tabla
            End Using
        End Using
    End Function

    Public Function registrarPI3() As DataTable
        Using connection = GetConnection()
            connection.Open()
            Using command = New OracleCommand()
                command.Connection = connection
                command.CommandText = "INSERT INTO ac_tpi3 SELECT * FROM ac_tpi3_temp"
                Console.WriteLine("REGISTRAR PI3: " & command.CommandText)
                command.CommandType = CommandType.Text
                command.ExecuteNonQuery()
                Return tabla
            End Using
        End Using
    End Function

    Public Function registrarPI3Temp(id_plan As Integer, id_proyecto As String, id_proyecto_plan_interior As String, tipo_proyecto As Integer, objetivo_proyecto_codigo As String, act_relacionadas_proyecto As Integer, descripcion_proyecto As String, beneficios_esperados As String, valor_regulatorio_aprobado As Double, relacion_beneficio_costo As Double, fecha_inicio_ejecucion As Date, fecha_final_ejecucion As Date, aprobacion_upme As String, observaciones As String, id_mercado As String) As DataTable
        Using connection = GetConnection()
            connection.Open()
            Using command = New OracleCommand()
                command.Connection = connection
                command.CommandText = "INSERT INTO ac_tpi3_temp values (" & id_plan & ", '" & id_proyecto & "', '" & id_proyecto_plan_interior & "', " & tipo_proyecto & ", '" & objetivo_proyecto_codigo & "', " & act_relacionadas_proyecto & ", '" & descripcion_proyecto & "', '" & beneficios_esperados & "', " & valor_regulatorio_aprobado & ", " & relacion_beneficio_costo & ", TO_DATE ('" & fecha_inicio_ejecucion & "', 'DD/MM/YYYY HH24:MI'), TO_DATE ('" & fecha_final_ejecucion & "', 'DD/MM/YYYY HH24:MI'), '" & aprobacion_upme & "', '" & observaciones & "', " & id_mercado & ")"
                Console.WriteLine("REGISTRAR PI3_TEMP: " & command.CommandText)
                command.CommandType = CommandType.Text
                command.ExecuteNonQuery()
                Return tabla
            End Using
        End Using
    End Function

    Public Function eliminarPI3() As DataTable
        Using connection = GetConnection()
            connection.Open()
            Using command = New OracleCommand()
                command.Connection = connection
                command.CommandText = "DELETE ac_tpi3"
                Console.WriteLine("ELIMINAR PI3: " & command.CommandText)
                command.CommandType = CommandType.Text
                command.ExecuteNonQuery()
                Return tabla
            End Using
        End Using
    End Function

    Public Function eliminarPI3Temp() As DataTable
        Using connection = GetConnection()
            connection.Open()
            Using command = New OracleCommand()
                command.Connection = connection
                command.CommandText = "DELETE ac_tpi3_temp"
                Console.WriteLine("ELIMINAR PI3_TEMP: " & command.CommandText)
                command.CommandType = CommandType.Text
                command.ExecuteNonQuery()
                Return tabla
            End Using
        End Using
    End Function

    Public Function referenciaTabla113(tipo_proyecto As Integer) As Boolean
        Using connection = GetConnection()
            connection.Open()
            Using command = New OracleCommand()
                command.Connection = connection
                command.CommandText = "SELECT id FROM ac_tpivote_sui WHERE numero = 113 AND codigo = " & tipo_proyecto & ""
                Console.WriteLine("CONSOLA: " & command.CommandText)
                command.CommandType = CommandType.Text
                Dim reader = command.ExecuteReader()
                If reader.HasRows Then
                    While reader.Read()
                        tablaSUI.identificador = reader.GetInt32(0)
                    End While
                    reader.Dispose()
                    Return True
                Else
                    Return False
                End If
            End Using
        End Using
    End Function

    Public Function referenciaTabla114(act_relacionadas_proyecto As Integer) As Boolean
        Using connection = GetConnection()
            connection.Open()
            Using command = New OracleCommand()
                command.Connection = connection
                command.CommandText = "SELECT id FROM ac_tpivote_sui WHERE numero = 114 AND codigo = " & act_relacionadas_proyecto & ""
                Console.WriteLine("CONSOLA: " & command.CommandText)
                command.CommandType = CommandType.Text
                Dim reader = command.ExecuteReader()
                If reader.HasRows Then
                    While reader.Read()
                        tablaSUI.identificador = reader.GetInt32(0)
                    End While
                    reader.Dispose()
                    Return True
                Else
                    Return False
                End If
            End Using
        End Using
    End Function

End Class


