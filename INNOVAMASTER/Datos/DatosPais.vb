Public Class DatosPais
    Dim IdPais As Integer
    Dim Pais As String

    Public Property gIdPais
        Get
            Return IdPais
        End Get
        Set(value)
            IdPais = value
        End Set
    End Property
    Public Property gPais
        Get
            Return Pais
        End Get
        Set(value)
            Pais = value
        End Set
    End Property
End Class
