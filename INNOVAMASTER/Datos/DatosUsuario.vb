Public Class DatosUsuario

    Dim IdEmpleado, Usuario, Contrasena, Estado As String
    Dim IdUsuario, IdTipoAcceso As Integer

    Public Property gIdEmpleado
        Get
            Return IdEmpleado
        End Get
        Set(value)
            IdEmpleado = value
        End Set
    End Property

    Public Property gUsuario
        Get
            Return Usuario
        End Get
        Set(value)
            Usuario = value
        End Set
    End Property

    Public Property gContrasena
        Get
            Return Contrasena
        End Get
        Set(value)
            Contrasena = value
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


    Public Property gIdTipoAcceso
        Get
            Return IdTipoAcceso
        End Get
        Set(value)
            IdTipoAcceso = value
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

    Public Sub New()

    End Sub
    Public Sub New(ByVal IdEmpleado As String, ByVal Usuario As String, ByVal Contrasena As String, ByVal IdUsuario As Integer, ByVal IdTipoAcceso As Integer, ByVal Estado As String)
        gIdEmpleado = IdEmpleado
        gIdUsuario = Usuario
        gContrasena = Contrasena
        gIdUsuario = IdUsuario
        gIdTipoAcceso = IdTipoAcceso
        gEstado = Estado
    End Sub
End Class
