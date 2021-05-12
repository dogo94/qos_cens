Imports System.Data
Imports Oracle.ManagedDataAccess.Client

Public Class UserDao
    Inherits ConnectionToOracle

    Dim tabla As DataTable = New DataTable()
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

End Class
