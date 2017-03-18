Public Class DatosCliente
    Dim IdCliente, NombreCliente, ApellidoCliente, DireccionCliente, TelefonoCliente, CorreoCliente As String
    Dim FechaNacimiento As Date
    Dim IdSexo, IdMunicipio, IdEstadoCivil As Integer

    Public Property gIdCliente
        Get
            Return IdCliente
        End Get
        Set(value)
            IdCliente = value
        End Set
    End Property

    Public Property gNombreCliente
        Get
            Return NombreCliente
        End Get
        Set(value)
            NombreCliente = value
        End Set
    End Property

    Public Property gApellidoCliente
        Get
            Return ApellidoCliente
        End Get
        Set(value)
            ApellidoCliente = value
        End Set
    End Property

    Public Property gDireccionCliente
        Get
            Return DireccionCliente
        End Get
        Set(value)
            DireccionCliente = value
        End Set
    End Property


    Public Property gTelefonoCliente
        Get
            Return TelefonoCliente
        End Get
        Set(value)
            TelefonoCliente = value
        End Set
    End Property

    Public Property gCorreoCliente
        Get
            Return CorreoCliente
        End Get
        Set(value)
            CorreoCliente = value
        End Set
    End Property

    Public Property gFechaNacimiento
        Get
            Return FechaNacimiento
        End Get
        Set(value)
            FechaNacimiento = value
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

    Public Property gIdEstadoCivil
        Get
            Return IdEstadoCivil
        End Get
        Set(value)
            IdEstadoCivil = value
        End Set
    End Property

    Public Sub New()

    End Sub
    Public Sub New(ByVal IdCliente As String, ByVal NombreCliente As String, ByVal ApellidoCliente As String, ByVal DireccionCliente As String, ByVal TelefonoCliente As String, ByVal CorreoCliente As String, ByVal FechaNacimiento As Date, ByVal IdSexo As Integer, ByVal IdMunicipio As Integer, ByVal IdEstadoCivil As Integer)
        gIdCliente = IdCliente
        gNombreCliente = NombreCliente
        gApellidoCliente = ApellidoCliente
        gDireccionCliente = DireccionCliente
        gTelefonoCliente = TelefonoCliente
        gCorreoCliente = CorreoCliente
        gFechaNacimiento = FechaNacimiento
        gIdSexo = IdSexo
        gIdMunicipio = IdMunicipio
        gIdEstadoCivil = gIdEstadoCivil

    End Sub




End Class
