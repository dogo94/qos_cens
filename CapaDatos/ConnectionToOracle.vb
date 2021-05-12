Imports Oracle.ManagedDataAccess.Client

Public MustInherit Class ConnectionToOracle
    Private connectionString, connectionStringPruebas As String

    'constructor de forma protegida
    Protected Sub New()
        'connectionString = "Data Source=10.42.10.13:1521/SPARD; User Id=BRAE; Password=Bra968*+-; "    'cadena de conexión a la BD Produccion
        connectionString = "Data Source=10.46.3.19:1521/SPARD; User Id=BRAE; Password=iKEjvbvP; "    'cadena de conexión a la BD Pruebas
    End Sub

    'metodo protegido para obtener la conexión
    Protected Function GetConnection() As OracleConnection
        Return New OracleConnection(connectionString)
    End Function
End Class
