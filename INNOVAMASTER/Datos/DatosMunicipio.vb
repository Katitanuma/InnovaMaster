Public Class DatosMunicipio
    Dim IdMunicipio, IdDepartamento As Integer
    Dim Municipio As String

    Public Property gIdMunicipio
        Get
            Return IdMunicipio
        End Get
        Set(value)
            IdMunicipio = value
        End Set
    End Property
    Public Property gMunicipio
        Get
            Return Municipio
        End Get
        Set(value)
            Municipio = value
        End Set
    End Property
    Public Property gIdDepartamento
        Get
            Return IdDepartamento
        End Get
        Set(value)
            IdDepartamento = value
        End Set
    End Property
End Class
