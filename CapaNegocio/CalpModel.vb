Imports CapaDatos

Public Class CalpModel
    Dim CalpDao As New CalpDao()

    Public Function GetCalpToDelete() As DataTable
        Dim tabla As DataTable = New DataTable()
        tabla = CalpDao.GetCalpToDelete

        Return tabla
    End Function

    Public Function GetCalpToInsert() As DataTable
        Dim tabla As DataTable = New DataTable()
        tabla = CalpDao.GetCalpToInsert
        Return tabla
    End Function

    Public Sub UpdateCalpTC1()
        GetCalpToDelete()
        GetCalpToInsert()
    End Sub

End Class
