Public Class DatosProfesiones
    Dim IdProfesion As Integer
    Dim Profesion As String

    Public Property gidprofesion
        Get
            Return IdProfesion
        End Get
        Set(value)
            IdProfesion = value
        End Set
    End Property

    Public Property gprofesion
        Get
            Return Profesion
        End Get
        Set(value)
            Profesion = value
        End Set
    End Property

    Public Sub New()

    End Sub
    Public Sub New(ByVal Idprofesion As Integer, ByVal profesion As String)
        gidprofesion = Idprofesion
        gprofesion = profesion
    End Sub
End Class
