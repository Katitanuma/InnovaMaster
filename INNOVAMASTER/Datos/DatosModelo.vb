Public Class DatosModelo
    Dim IdModelo, IdMarca As Integer
    Dim Modelo As String

    Public Property gIdModelo
        Get
            Return IdModelo
        End Get
        Set(value)
            IdModelo = value
        End Set
    End Property

    Public Property gModelo
        Get
            Return Modelo
        End Get
        Set(value)
            Modelo = value
        End Set
    End Property

    Public Property gIdMarca
        Get
            Return IdMarca
        End Get
        Set(value)
            IdMarca = value
        End Set
    End Property

    Public Sub New()

    End Sub
    Public Sub New(ByVal Idcategoria As Integer, ByVal categoria As String)
        gIdModelo = IdModelo
        gModelo = Modelo
        gIdMarca = IdMarca
    End Sub
End Class
