Imports System.Data
Imports Oracle.ManagedDataAccess.Client

Public Class Tc1Dao
    Inherits ConnectionToOracle

    Dim tabla As DataTable = New DataTable()
    Dim leer As OracleDataReader

    'CONSULTA MASTER QUE VA A TRAER TODOS LOS USUARIOS CON LOS CAMPOS EN EL TC1 (AUN ESTA EN CONSTRUCCION)

    Dim sql_TC1 As String = "select C.CODE AS NIU,C.TPARENT,2 AS TIPO_CONEXION,'TENSION DE USUARIO (FALTA)' ,T.NIVEL_TENSION_PRIMARIA , T.PROPIEDAD_ACTIVO, T.TIPO_CON AS CONEXION_RED,'ID_COMER (FALTA)',
161 AS ID_MERCADO,T.GRUPOCALIDADTT2 AS GRUPO_CALIDAD, 'FRONTERA (FALTA)' AS FR_COMERCIAL, T.COD_CIRCUITO AS COD_CIRCUITO,T.IUA, 
C.LONGITUD AS LONGITUD,C.ADDRESS , 'CONDICIONES ESPECIALES (FALTA) ', 
from SPARD.custmetr C
JOIN (SELECT TR.CODE AS TCODE, CASE WHEN MVEL.KVNOM < 1 THEN '1'
                                    WHEN MVEL.KVNOM >= 1 And MVEL.KVNOM < 30 THEN '2'
                                    WHEN MVEL.KVNOM >= 30 And MVEL.KVNOM < 57.5 THEN '3'
                                    WHEN MVEL.KVNOM >= 57.5 And MVEL.KVNOM < 220 THEN '4'
                                    Else '***'
    End As NIVEL_TENSION_PRIMARIA ,                            
                                    Case WHEN OWNER = 'COMPARTIDO' THEN 50
                                    WHEN OWNER = 'EMPRESA' THEN 100 
                                    WHEN OWNER = 'PARTICULAR' THEN 0 END AS PROPIEDAD_ACTIVO ,                                   
                                    Case WHEN TR.TIPO_RED = 'A' THEN 1 ELSE 2 END AS TIPO_CON ,                                  
                                    TR.GRUPO015 AS GRUPO_CALIDAD,                              
                                    TT1.TT1_CODIGOCIRCUITO AS COD_CIRCUITO,                                    
                                    TT2.IUA AS IUA,                                 
                                    TT2.GRUPOCALIDAD AS GRUPOCALIDADTT2
                                    FROM SPARD.TRANSFOR TR                                    
                                    JOIN BRAE.QA_TTT1_REGISTRO TT1 On TT1.TT1_NOMBRECIRCUITO = TR.FPARENT                             
                                    JOIN  (SELECT TT2R.TT2_CODE_TRAFO AS TRAFO, TT2R.TT2_CODE_IUA AS IUA , TT2R.TT2_GRUPOCALIDAD AS GRUPOCALIDAD                                    
                                    FROM BRAE.QA_TTT2_REPORTE TT2R where TT2R.TT2_PERIODO = '01/05/2021'
                                    )TT2 ON TT2.TRAFO = TR.CODE           
                                    LEFT JOIN SPARD.MVELNODE MVEL On MVEL.CODE = TR.ELNODE 
                                    
            ) T ON T.TCODE = TPARENT
            
            LEFT JOIN(SELECT QA_TMUNDANE.MUND_MUNDANE, QA_TS4.TIP_AREA, QA_TS4.COD_AREA  FROM QA_TS4 JOIN QA_TMUNDANE ON TRIM(MUND_DESCRIPCION) = Trim(QA_TS4.NOM_AREA))"








    Public Function InsertMasterTc1(periodo As Date, estado As String)
        Using connection = GetConnection()
            connection.Open()
            Using command = New OracleCommand()
                Dim sql As String = "insert into QA_TTC1_SUI (PERIODO, ESTADO) VALUES ( '" & periodo & " ','" & estado & "')"
                command.Connection = connection
                command.CommandText = sql
                Console.WriteLine("Registrar Calps: " & sql)
                command.CommandType = CommandType.Text
                command.ExecuteNonQuery()
                Return tabla
            End Using
        End Using

    End Function


    Public Function getEstadoTc1(periodo As Date)
        Dim tabla_ins As DataTable = New DataTable()
        Dim estado As String
        Using connection = GetConnection()
            connection.Open()
            Using command = New OracleCommand()
                command.Connection = connection
                command.CommandText = "select estado from QA_TTC1_SUI where PERIODO = '" & periodo & "'"
                Console.WriteLine("CONSOLA: " & command.CommandText)
                command.CommandType = CommandType.Text
                leer = command.ExecuteReader()  'Devuelve filas.
                tabla_ins.Load(leer)
                estado = tabla_ins.Rows(0).Item(1)
                leer.Dispose()
                connection.Close()
                Return tabla_ins
            End Using
        End Using

    End Function
End Class
