Public Class DatosDepartamento
    Dim IdDepartamento, IdPais As Integer
    Dim Departamento As String

    Public Property gIdDepartamento
        Get
            Return IdDepartamento
        End Get
        Set(value)
            IdDepartamento = value
        End Set
    End Property
    Public Property gDepartamento
        Get
            Return Departamento
        End Get
        Set(value)
            Departamento = value
        End Set
    End Property

    Public Property gIdPais
        Get
            Return IdPais
        End Get
        Set(value)
            IdPais = value
        End Set
    End Property
End Class
