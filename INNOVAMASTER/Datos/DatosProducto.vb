Public Class DatosProducto
    Dim IdProducto, Descripcion, Estado As String
    Dim Costo, Gravado, PrecioUnitario, PrecioMayorista As Double
    Dim Existencia, IdCategoria, IdModelo, Entero As Integer
    Dim Imagen As Byte()


    Public Property gIdProducto
        Get
            Return IdProducto
        End Get
        Set(value)
            IdProducto = value
        End Set
    End Property

    Public Property gDescripcion
        Get
            Return Descripcion
        End Get
        Set(value)
            Descripcion = value
        End Set
    End Property

    Public Property gCosto
        Get
            Return Costo
        End Get
        Set(value)
            Costo = value
        End Set
    End Property



    Public Property gGravado
        Get
            Return Gravado
        End Get
        Set(value)
            Gravado = value
        End Set
    End Property

    Public Property gPrecioUnitario
        Get
            Return PrecioUnitario
        End Get
        Set(value)
            PrecioUnitario = value
        End Set
    End Property

    Public Property gPrecioMayorista
        Get
            Return PrecioMayorista
        End Get
        Set(value)
            PrecioMayorista = value
        End Set
    End Property

    Public Property gExistecia
        Get
            Return Existencia
        End Get
        Set(value)
            Existencia = value
        End Set
    End Property

    Public Property gIdCategoria
        Get
            Return IdCategoria
        End Get
        Set(value)
            IdCategoria = value
        End Set
    End Property

    Public Property gIdModelo
        Get
            Return IdModelo
        End Get
        Set(value)
            IdModelo = value
        End Set
    End Property
    Public Property gEstado
        Get
            Return Estado
        End Get
        Set(value)
            Estado = value
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


    Public Property gEntero
        Get
            Return Entero
        End Get
        Set(value)
            Entero = value
        End Set
    End Property

    Public Sub New()

    End Sub

    Public Sub New(ByVal IdProducto As String, ByVal Descripcion As String, ByVal Costo As Double, ByVal Gravado As Double, ByVal PrecioUnitario As Double, ByVal PrecioMayorista As Double, ByVal Existencia As Integer, ByVal IdCategoria As Integer, ByVal IdModelo As Integer, ByVal Estado As Integer, ByVal Imagen As Byte(), ByVal Entero As Integer)
        gIdCategoria = IdCategoria
        gDescripcion = Descripcion
        gCosto = Costo

        gGravado = Gravado
        gPrecioUnitario = PrecioUnitario
        gPrecioMayorista = PrecioMayorista
        gExistecia = Existencia
        gIdCategoria = IdCategoria
        gIdModelo = IdModelo
        gEstado = Estado
        gImagen = Imagen
        gEntero = Entero

    End Sub

End Class
