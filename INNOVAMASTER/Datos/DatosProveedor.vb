Public Class DatosProveedor
    Dim IdProveedor, RTN, NombreEmpresa, DireccionEmpresa, NombreContacto, ApellidoContacto, DireccionContacto, TelefonoContacto, CorreoContacto As String
    Dim IdSexo, IdMunicipio As Integer

    Public Property gIdProveedor
        Get
            Return IdProveedor
        End Get
        Set(value)
            IdProveedor = value
        End Set
    End Property

    Public Property gRTN
        Get
            Return RTN
        End Get
        Set(value)
            RTN = value
        End Set
    End Property

    Public Property gNombreEmpresa
        Get
            Return NombreEmpresa
        End Get
        Set(value)
            NombreEmpresa = value
        End Set
    End Property

    Public Property gDireccionEmpresa
        Get
            Return DireccionEmpresa
        End Get
        Set(value)
            DireccionEmpresa = value
        End Set
    End Property


    Public Property gNombreContacto
        Get
            Return NombreContacto
        End Get
        Set(value)
            NombreContacto = value
        End Set
    End Property

    Public Property gApellidoContacto
        Get
            Return ApellidoContacto
        End Get
        Set(value)
            ApellidoContacto = value
        End Set
    End Property

    Public Property gDireccionContacto
        Get
            Return DireccionContacto
        End Get
        Set(value)
            DireccionContacto = value
        End Set
    End Property

    Public Property gTelefonoContacto
        Get
            Return TelefonoContacto
        End Get
        Set(value)
            TelefonoContacto = value
        End Set
    End Property


    Public Property gCorreoContacto
        Get
            Return CorreoContacto
        End Get
        Set(value)
            CorreoContacto = value
        End Set
    End Property

    Public Property gIdSexo
        Get
            Return IdSexo
        End Get
        Set(value)
            IdSexo = value
        End Set
    End Property

    Public Property gIdMunicipio
        Get
            Return IdMunicipio
        End Get
        Set(value)
            IdMunicipio = value
        End Set
    End Property



    Public Sub New()

    End Sub
    Public Sub New(ByVal IdProveedor As String, ByVal RTN As String, ByVal NombreEmpresa As String, ByVal DireccionEmpresa As String, ByVal NombreContacto As String, ByVal ApellidoContacto As String, ByVal DireccionContacto As String, ByVal TelefonoContacto As String, ByVal CorreoContacto As String, ByVal IdSexo As Integer, ByVal IdMunicipio As Integer)
        gIdProveedor = IdProveedor
        gRTN = RTN
        gNombreEmpresa = NombreEmpresa
        gDireccionEmpresa = DireccionEmpresa
        gNombreContacto = NombreContacto
        gApellidoContacto = ApellidoContacto
        gDireccionContacto = DireccionContacto
        gTelefonoContacto = TelefonoContacto
        gCorreoContacto = CorreoContacto
        gIdSexo = IdSexo
        gIdMunicipio = IdMunicipio
    End Sub

End Class
