Imports CapaDatos

Public Class UserModel
    Dim userDao As New UserDao()

    Public Function mostrarAlgo() As DataTable
        Dim tabla As DataTable = New DataTable()
        tabla = userDao.mostrarAlgo()
        Return tabla
    End Function

End Class
