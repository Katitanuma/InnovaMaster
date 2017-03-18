Public Class DatosCargo
    Dim IdCargo As Integer
    Dim Cargo As String

    Public Property gidcargo
        Get
            Return IdCargo
        End Get
        Set(value)
            IdCargo = value
        End Set
    End Property

    Public Property gcargo
        Get
            Return Cargo
        End Get
        Set(value)
            Cargo = value
        End Set
    End Property

    Public Sub New()

    End Sub
    Public Sub New(ByVal Idcargo As Integer, ByVal cargo As String)
        gidcargo = Idcargo
        gcargo = cargo
    End Sub
End Class
