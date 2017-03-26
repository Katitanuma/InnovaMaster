Imports System.Data.SqlClient
Public Class Conexion
    Public Con As New SqlConnection
    Public Function Conectarse()
        Try
            Con = New SqlConnection(My.Settings.Conect1)
            Con.Open()
            Return True
        Catch ex As Exception

            Return False
        End Try
    End Function
    Public Function Desconectarse()
        Try
            If Con.State = ConnectionState.Open Then
                Con.Close()
                Return True
            Else
                Return False
            End If
        Catch ex As Exception
            MsgBox(ex.ToString)
            Return False
        End Try

    End Function
End Class
