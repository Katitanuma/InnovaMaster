Public Class DatosProfesion

    Dim IdCategoria As Integer
    Dim Categoria As String

    Public Property gidcategoria
        Get
            Return IdCategoria
        End Get
        Set(value)
            IdCategoria = value
        End Set
    End Property

    Public Property gcategoria
        Get
            Return Categoria
        End Get
        Set(value)
            Categoria = value
        End Set
    End Property

    Public Sub New()

    End Sub
    Public Sub New(ByVal Idcategoria As Integer, ByVal categoria As String)
        gidcategoria = Idcategoria
        gcategoria = categoria
    End Sub

End Class
