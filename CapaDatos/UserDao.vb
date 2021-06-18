Imports System.Data
Imports Oracle.ManagedDataAccess.Client
Imports Common

Public Class UserDao
    Inherits ConnectionToOracle

    Dim tabla As DataTable = New DataTable()
    Dim tabla2 As Integer = New Integer
    Dim leer As OracleDataReader

    Public Function registrarPI3(script As String) As DataTable
        Using connection = GetConnection()
            connection.Open()
            Using command = New OracleCommand()
                command.Connection = connection
                command.CommandText = script
                Console.WriteLine("REGISTRAR PI3: " & script)
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

    Public Function referenciaTabla113() As Boolean
        Using connection = GetConnection()
            connection.Open()
            Using command = New OracleCommand()
                command.Connection = connection
                command.CommandText = "SELECT id FROM ac_tpivote_sui WHERE numero = 113 ORDER BY codigo"
                Console.WriteLine("CONSOLA: " & command.CommandText)
                command.CommandType = CommandType.Text
                Dim reader = command.ExecuteReader()
                Dim i As Integer
                i = 0
                If reader.HasRows Then
                    While reader.Read()
                        tablaSUI.vector113(i) = reader.GetInt32(0)
                        i = i + 1
                    End While
                    reader.Dispose()
                    Return True
                Else
                    Return False
                End If
            End Using
        End Using
    End Function

    Public Function referenciaTabla114() As Boolean
        Using connection = GetConnection()
            connection.Open()
            Using command = New OracleCommand()
                command.Connection = connection
                command.CommandText = "SELECT id FROM ac_tpivote_sui WHERE numero = 114 ORDER BY codigo"
                Console.WriteLine("CONSOLA: " & command.CommandText)
                command.CommandType = CommandType.Text
                Dim reader = command.ExecuteReader()
                Dim i As Integer
                i = 0
                If reader.HasRows Then
                    While reader.Read
                        tablaSUI.vector114(i) = reader.GetInt32(0)
                        i = i + 1
                    End While
                    reader.Dispose()
                    Return True
                Else
                    Return False
                End If
            End Using
        End Using
    End Function

    'Public Function referenciaTabla114(act_relacionadas_proyecto As Integer) As Boolean
    '    Using connection = GetConnection()
    '        connection.Open()
    '        Using command = New OracleCommand()
    '            command.Connection = connection
    '            command.CommandText = "SELECT id FROM ac_tpivote_sui WHERE numero = 114 AND codigo = " & act_relacionadas_proyecto & ""
    '            Console.WriteLine("CONSOLA: " & command.CommandText)
    '            command.CommandType = CommandType.Text
    '            Dim reader = command.ExecuteReader()
    '            If reader.HasRows Then
    '                While reader.Read()
    '                    tablaSUI.identificador = reader.GetInt32(0)
    '                End While
    '                reader.Dispose()
    '                Return True
    '            Else
    '                Return False
    '            End If
    '        End Using
    '    End Using
    'End Function

End Class


