Imports System.Data
Imports Oracle.ManagedDataAccess.Client

Public Class CalpDao
    Inherits ConnectionToOracle

    Dim tabla As DataTable = New DataTable()
    Dim leer As OracleDataReader


    Public Function GetCalpToDelete() As DataTable
        Dim tabla_ins As DataTable = New DataTable()
        Using connection = GetConnection()
            connection.Open()
            Using command = New OracleCommand()
                command.Connection = connection
                command.CommandText = "SELECT QC.CONSECUTIVO, QC.NIU FROM BRAE.QA_CALP QC
LEFT JOIN (
SELECT TPARENT AS CODIGOELEMENTO, SUM(KW) AS KVA, T.MUNICIPIO AS DANE,M.DESCRIPCION AS MUNICIPIO, CASE WHEN T.MUNICIPIO LIKE '54001%' THEN 'EMPRESAS PUBLICAS DE MEDELLIN E.S.P.'
                                                               WHEN T.MUNICIPIO LIKE '54874%' THEN 'EMPRESAS PUBLICAS DE MEDELLIN E.S.P.'
                                                               WHEN T.MUNICIPIO LIKE '54405%' THEN 'EMPRESAS PUBLICAS DE MEDELLIN E.S.P.'
                                                               ELSE 'CENTRALES ELECTRICAS DEL NORTE DE SANTANDER S.A. ESP' END AS COMER,
                                                               CASE WHEN T.MUNICIPIO LIKE '54001%' THEN 564
                                                               WHEN T.MUNICIPIO LIKE '54874%' THEN 564
                                                               WHEN T.MUNICIPIO LIKE '54405%' THEN 564
                                                               ELSE 604 END AS ID_COMER
FROM SPARD.STREETLG
LEFT OUTER JOIN TRANSFOR T ON T.CODE=TPARENT
LEFT OUTER JOIN MUN_DANE M ON M.MUN_ID=T.MUNICIPIO
WHERE TPARENT IS NOT NULL
GROUP BY TPARENT, T.MUNICIPIO, M.DESCRIPCION, CASE WHEN T.MUNICIPIO LIKE '54001%' THEN 'EMPRESAS PUBLICAS DE MEDELLIN E.S.P.' WHEN T.MUNICIPIO LIKE '54874%' THEN 'EMPRESAS PUBLICAS DE MEDELLIN E.S.P.' WHEN T.MUNICIPIO LIKE '54405%' THEN 'EMPRESAS PUBLICAS DE MEDELLIN E.S.P.' ELSE 'CENTRALES ELECTRICAS DEL NORTE DE SANTANDER S.A. ESP' END, CASE WHEN T.MUNICIPIO LIKE '54001%' THEN 564 WHEN T.MUNICIPIO LIKE '54874%' THEN 564 WHEN T.MUNICIPIO LIKE '54405%' THEN 564 ELSE 604 END)
JOINCALP ON JOINCALP.CODIGOELEMENTO = QC.CODIGOELEMENTO WHERE JOINCALP.CODIGOELEMENTO IS NULL"

                Console.WriteLine("CONSOLA: " & command.CommandText)
                command.CommandType = CommandType.Text
                leer = command.ExecuteReader()  'Devuelve filas.
                tabla_ins.Load(leer)
                'Console.WriteLine("daniel " & tabla.Rows(0).Item(1))
                leer.Dispose()
                connection.Close()
                ContruirCadenaDeleteCalp(tabla_ins)
                Return tabla_ins
            End Using
        End Using
    End Function



    Public Function GetCalpToInsert() As DataTable
        Using connection = GetConnection()
            connection.Open()
            Using command = New OracleCommand()
                command.Connection = connection
                command.CommandText = "
   SELECT TPARENT AS CODIGOELEMENTO, SUM(KW) AS KVA, T.MUNICIPIO AS DANE,M.DESCRIPCION AS MUNICIPIO, CASE WHEN T.MUNICIPIO LIKE '54001%' THEN 'EMPRESAS PUBLICAS DE MEDELLIN E.S.P.'
                                                               WHEN T.MUNICIPIO LIKE '54874%' THEN 'EMPRESAS PUBLICAS DE MEDELLIN E.S.P.'
                                                               WHEN T.MUNICIPIO LIKE '54405%' THEN 'EMPRESAS PUBLICAS DE MEDELLIN E.S.P.'
                                                               ELSE 'CENTRALES ELECTRICAS DEL NORTE DE SANTANDER S.A. ESP' END AS COMER,
                                                               CASE WHEN T.MUNICIPIO LIKE '54001%' THEN 564
                                                               WHEN T.MUNICIPIO LIKE '54874%' THEN 564
                                                               WHEN T.MUNICIPIO LIKE '54405%' THEN 564
                                                               ELSE 604 END AS ID_COMER
                                FROM SPARD.STREETLG
                                LEFT OUTER JOIN TRANSFOR T ON T.CODE=TPARENT
                                LEFT OUTER JOIN MUN_DANE M ON M.MUN_ID=T.MUNICIPIO
                                LEFT JOIN  BRAE.QA_CALP QC ON QC.CODIGOELEMENTO = T.CODE
                                WHERE TPARENT IS NOT NULL AND QC.CODIGOELEMENTO IS NULL
                                GROUP BY TPARENT, T.MUNICIPIO, M.DESCRIPCION, CASE WHEN T.MUNICIPIO LIKE '54001%' THEN 'EMPRESAS PUBLICAS DE MEDELLIN E.S.P.' WHEN T.MUNICIPIO LIKE '54874%' THEN 'EMPRESAS PUBLICAS DE MEDELLIN E.S.P.' WHEN T.MUNICIPIO LIKE '54405%' THEN 'EMPRESAS PUBLICAS DE MEDELLIN E.S.P.' ELSE 'CENTRALES ELECTRICAS DEL NORTE DE SANTANDER S.A. ESP' END, CASE WHEN T.MUNICIPIO LIKE '54001%' THEN 564 WHEN T.MUNICIPIO LIKE '54874%' THEN 564 WHEN T.MUNICIPIO LIKE '54405%' THEN 564 ELSE 604 END"
                Console.WriteLine("CONSOLA: " & command.CommandText)
                command.CommandType = CommandType.Text
                leer = command.ExecuteReader()  'Devuelve filas.
                tabla.Load(leer)
                leer.Dispose()
                connection.Close()
                ContruirCadenaInsertCalp(tabla)
                Return tabla
            End Using
        End Using
    End Function


    Public Function DeleteCalp(cadena As String) As DataTable
        Using connection = GetConnection()
            connection.Open()
            Using command = New OracleCommand()
                command.Connection = connection
                command.CommandText = "DELETE FROM BRAE.QA_CALP WHERE NIU in (" & cadena & ")"
                Console.WriteLine("CONSOLA: " & command.CommandText)
                command.CommandType = CommandType.Text
                command.ExecuteNonQuery()
                connection.Close()
                Return tabla
            End Using
        End Using
    End Function

    Public Function InsertCalp(script As String) As DataTable


        Using connection = GetConnection()
            connection.Open()
            Using command = New OracleCommand()
                command.Connection = connection
                command.CommandText = script
                Console.WriteLine("Registrar Calps: " & script)
                command.CommandType = CommandType.Text
                command.ExecuteNonQuery()
                Return tabla
            End Using
        End Using


    End Function

    Public Function ContruirCadenaInsertCalp(reader As DataTable) As String
        Dim Cadena As String = "INSERT ALL  "
        Dim thisDate As Date = Today
        Dim fec = Convert.ToDateTime(thisDate.ToString("dd'/'MM'/'yyyy"))

        For Each row As DataRow In reader.Rows
            Dim arr() As String = GetConsecutivoCalp()
            Dim consecutivo As Integer = Convert.ToInt32(arr(0))
            Dim calp As String = arr(1)
            Dim codigoelemento As String = row.Item(0)
            Dim kva As Double = Convert.ToDouble(row.Item(1))
            Dim dane As Integer = Convert.ToInt32(row.Item(2))
            Dim municipio As String = row.Item(3)
            Dim comer As String = row.Item(4)
            Dim id_comer As String = Convert.ToInt32(row.Item(5))

            Cadena = Cadena & " INTO QA_CALP (CONSECUTIVO,NIU,KVA,ID_COMER,COMER,MUNICIPIO,DANE,CODIGOELEMENTO,FEC_UPDATE) VALUES (" & consecutivo & ",'" & calp & "'," & kva & "," & id_comer & ",'" & comer & "','" & municipio & "'," & dane & ",'" & codigoelemento & "','" & fec & "')  "

        Next
        Cadena = Cadena & " SELECT * FROM dual"
        'Console.WriteLine("Cadena" & Cadena)

        If Len(Cadena) > 50 Then

            InsertCalp(Cadena)

        End If

        Return Cadena

    End Function


    Public Function GetConsecutivoCalp() As String()
        Using connection = GetConnection()
            Dim tabla1 As DataTable = New DataTable()
            connection.Open()
            Using command = New OracleCommand()
                Dim Cons(2) As String
                command.Connection = connection
                command.CommandText = "SELECT CONSECUTIVO+1 AS CONSECUTIVO , 'CALP'||LPAD((CONSECUTIVO+1),9,'0')AS CALP FROM(
                                        SELECT  CONSECUTIVO AS CONSECUTIVO FROM QA_CALP 
                                        UNION
                                        SELECT  CONSECUTIVO AS CONSECUTIVO FROM QA_CALP_DELETED
                                        order by 1 desc) WHERE ROWNUM=1"

                Console.WriteLine("CONSOLA: " & command.CommandText)
                command.CommandType = CommandType.Text
                leer = command.ExecuteReader()  'Devuelve filas.
                tabla1.Load(leer)
                leer.Dispose()
                connection.Close()
                Cons(0) = tabla1.Rows(0).Item(0)
                Cons(1) = tabla1.Rows(0).Item(1)

                Console.WriteLine("New Consecutivo: " & Cons(0) & "- " & Cons(1))
                Return Cons
            End Using
        End Using

    End Function


    Public Function ContruirCadenaDeleteCalp(reader As DataTable) As String
        Dim Cadena, CadenaRet As String
        Cadena = ""
        CadenaRet = ""
        For Each row As DataRow In reader.Rows
            Dim niu As String = row.Item(1)
            Cadena = Cadena & "'" & niu & "',"
        Next

        If Len(Cadena) > 0 Then
            CadenaRet = Left(Cadena, Len(Cadena) - 1)
            Console.WriteLine("CadenaRet" & CadenaRet)
            DeleteCalp(CadenaRet)
        End If
        Return CadenaRet
    End Function
End Class
