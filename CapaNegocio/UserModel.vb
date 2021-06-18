Imports CapaDatos

Public Class UserModel
    Dim userDao As New UserDao()

    Public Function registrarPI3(script As String)
        userDao.registrarPI3(script)
    End Function


    Public Function eliminarPI3()
        userDao.eliminarPI3()
    End Function


    Public Function referenciaTabla113()
        Return userDao.referenciaTabla113()
    End Function

    Public Function referenciaTabla114()
        Return userDao.referenciaTabla114()
    End Function

End Class