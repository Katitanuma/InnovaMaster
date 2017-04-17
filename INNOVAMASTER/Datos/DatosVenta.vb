Public Class DatosVenta
    Dim IdVenta, IdCliente As String
    Dim FechaVenta, FechaVencimiento As Date
    Dim IdFormaVenta, IdTipoVenta, IdUsuario As Integer
    Dim DescuentoExtra, Cambio As Double

    Public Property gIdVenta
        Get
            Return IdVenta
        End Get
        Set(value)
            IdVenta = value
        End Set
    End Property

    Public Property gIdCliente
        Get
            Return IdCliente
        End Get
        Set(value)
            IdCliente = value
        End Set
    End Property

    Public Property gFechaVenta
        Get
            Return FechaVenta
        End Get
        Set(value)
            FechaVenta = value
        End Set
    End Property
    Public Property gFechaVencimiento
        Get
            Return FechaVencimiento
        End Get
        Set(value)
            FechaVencimiento = value
        End Set
    End Property
    Public Property gIdFormaVenta
        Get
            Return IdFormaVenta
        End Get
        Set(value)
            IdFormaVenta = value
        End Set
    End Property
    Public Property gIdTipoVenta
        Get
            Return IdTipoVenta
        End Get
        Set(value)
            IdTipoVenta = value
        End Set
    End Property
    Public Property gIdUsuario
        Get
            Return IdUsuario
        End Get
        Set(value)
            IdUsuario = value
        End Set
    End Property
    Public Property gDescuentoExtra
        Get
            Return DescuentoExtra
        End Get
        Set(value)
            DescuentoExtra = value
        End Set
    End Property

    Public Property gCambio
        Get
            Return Cambio
        End Get
        Set(value)
            Cambio = value
        End Set
    End Property


    Public Sub New()

    End Sub
    Public Sub New(ByVal IdVenta As String, ByVal IdCliente As String, ByVal FechaVenta As Date, ByVal FechaVencimiento As Date, ByVal IdFormaVenta As Integer, ByVal IdTipoVenta As Integer, ByVal IdUsuario As Integer, ByVal DescuentoExtra As Double, ByVal Cambio As Double)
        gIdVenta = IdVenta
        gIdCliente = IdCliente
        gFechaVenta = FechaVenta
        gFechaVencimiento = FechaVencimiento
        gIdFormaVenta = IdFormaVenta
        gIdTipoVenta = IdTipoVenta
        gIdUsuario = IdUsuario
        gDescuentoExtra = DescuentoExtra
        gCambio = Cambio
    End Sub


End Class
