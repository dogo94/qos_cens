Imports CapaDatos

Public Class UserModel
    Dim userDao As New UserDao()

    Public Function mostrarAlgo() As DataTable
        Dim tabla As DataTable = New DataTable()
        tabla = userDao.mostrarAlgo()
        Return tabla
    End Function

    Public Function registrarPI3()
        userDao.registrarPI3()
    End Function

    Public Function registrarPI3Temp(id_plan As String, id_proyecto As String, id_proyecto_plan_interior As String, tipo_proyecto As String, objetivo_proyecto_codigo As String, act_relacionadas_proyecto As String, descripcion_proyecto As String, beneficios_esperados As String, valor_regulatorio_aprobado As String, relacion_beneficio_costo As String, fecha_inicio_ejecucion As String, fecha_final_ejecucion As String, aprobacion_upme As String, observaciones As String, id_mercado As String)
        userDao.registrarPI3Temp(Convert.ToInt32(id_plan), id_proyecto, id_proyecto_plan_interior, Convert.ToInt32(tipo_proyecto), objetivo_proyecto_codigo, Convert.ToInt32(act_relacionadas_proyecto), descripcion_proyecto, beneficios_esperados, Convert.ToDouble(valor_regulatorio_aprobado), Convert.ToDouble(relacion_beneficio_costo), Convert.ToDateTime(fecha_inicio_ejecucion), Convert.ToDateTime(fecha_final_ejecucion), aprobacion_upme, observaciones, Convert.ToInt32(id_mercado))
    End Function

    Public Function eliminarPI3()
        userDao.eliminarPI3()
    End Function

    Public Function eliminarPI3Temp()
        userDao.eliminarPI3Temp()
    End Function

    Public Function referenciaTabla113(tipo_proyecto As String)
        Return userDao.referenciaTabla113(Convert.ToInt32(tipo_proyecto))
    End Function

    Public Function referenciaTabla114(act_relacionadas_proyecto As String)
        Return userDao.referenciaTabla114(Convert.ToInt32(act_relacionadas_proyecto))
    End Function

End Class