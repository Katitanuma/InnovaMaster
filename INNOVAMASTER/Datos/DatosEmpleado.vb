Public Class DatosEmpleado
    'Miembros y metodos de la clase DatosEmpleado
    Dim IdEmpleado, NombreEmpleado, ApellidoEmpleado, DireccionEmpleado, TelefonoEmpleado, CelularEmpleado As String
    Dim FechaNacimiento, FechaContratacion As Date
    Dim IdSexo, IdMunicipio, IdEstadoCivil, IdCargo, IdSucursal, IdProfesion As Integer
    Dim Imagen As Byte()
    Public Property gIdEmpleado
        Get
            Return IdEmpleado
        End Get
        Set(value)
            IdEmpleado = value
        End Set
    End Property

    Public Property gNombreEmpleado
        Get
            Return NombreEmpleado
        End Get
        Set(value)
            NombreEmpleado = value
        End Set
    End Property

    Public Property gApellidoEmpleado
        Get
            Return ApellidoEmpleado
        End Get
        Set(value)
            ApellidoEmpleado = value
        End Set
    End Property

    Public Property gDireccionEmpleado
        Get
            Return DireccionEmpleado
        End Get
        Set(value)
            DireccionEmpleado = value
        End Set
    End Property


    Public Property gTelefonoEmpleado
        Get
            Return TelefonoEmpleado
        End Get
        Set(value)
            TelefonoEmpleado = value
        End Set
    End Property

    Public Property gCelularEmpleado
        Get
            Return CelularEmpleado
        End Get
        Set(value)
            CelularEmpleado = value
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
    Public Property gFechaContratacion
        Get
            Return FechaContratacion
        End Get
        Set(value)
            FechaContratacion = value
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

    Public Property gIdCargo
        Get
            Return IdCargo
        End Get
        Set(value)
            IdCargo = value
        End Set
    End Property

    Public Property gIdProfesion
        Get
            Return IdProfesion
        End Get
        Set(value)
            IdProfesion = value
        End Set
    End Property

    Public Property gIdSucursal
        Get
            Return IdSucursal
        End Get
        Set(value)
            IdSucursal = value
        End Set
    End Property
    Public Property gImagen
        Get
            Return Imagen
        End Get
        Set(value)
            Imagen = value
        End Set
    End Property



    Public Sub New()

    End Sub
    Public Sub New(ByVal IdEmpleado As String, ByVal NombreEmpleado As String, ByVal ApellidoEmpleado As String, ByVal DireccionEmpleado As String, ByVal TelefonoEmpleado As String, ByVal CelularEmpleado As String, ByVal FechaNacimiento As Date, ByVal FechaContratacion As Date, ByVal IdMunicipio As Integer, ByVal IdCargo As Integer, ByVal IdEstadoCivil As Integer, ByVal IdProfesion As Integer, ByVal IdSexo As Integer, ByVal IdSucursal As Integer, ByVal Imagen As Byte())
        gIdEmpleado = IdEmpleado
        gNombreEmpleado = NombreEmpleado
        gApellidoEmpleado = ApellidoEmpleado
        gDireccionEmpleado = DireccionEmpleado
        gTelefonoEmpleado = TelefonoEmpleado
        gCelularEmpleado = CelularEmpleado
        gFechaNacimiento = FechaNacimiento
        gFechaContratacion = FechaContratacion
        gIdMunicipio = IdMunicipio
        gIdCargo = IdCargo
        gIdEstadoCivil = gIdEstadoCivil
        gIdProfesion = IdProfesion
        gIdSexo = IdSexo
        gIdSucursal = IdSucursal
        gImagen = Imagen
    End Sub


End Class
