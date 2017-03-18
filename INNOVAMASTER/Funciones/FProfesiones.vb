Imports System.Data.SqlClient

Public Class FProfesiones
    Inherits conexion
    Dim cmd As New SqlCommand

    Public Function MostrarProfesion() As DataTable
        Try
            Conectarse()
            cmd = New SqlCommand("MostrarProfesion")
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Connection = con

            Dim da As New SqlDataAdapter
            Dim dt As New DataTable

            If cmd.ExecuteNonQuery Then
                da = New SqlDataAdapter(cmd)
                da.Fill(dt)
                Return dt
            Else
                Return Nothing
            End If


        Catch ex As Exception
            MsgBox(ex.ToString)
            Return Nothing
        Finally
            Desconectarse()
        End Try
    End Function

    Public Function Insertar(ByVal Datos As DatosProfesiones) As Boolean

        Try
            Conectarse()
            cmd = New SqlCommand("InsertarProfesion")
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Connection = con

            cmd.Parameters.AddWithValue("@Profesion", Datos.gprofesion)

            If cmd.ExecuteNonQuery Then
                Return True
            Else
                Return False

            End If
        Catch ex As Exception
            Return False
            MsgBox(ex.ToString)

        Finally
            Desconectarse()

        End Try
    End Function


    Public Function Actualizar(ByVal Datos As DatosProfesiones) As Boolean

        Try
            Conectarse()
            cmd = New SqlCommand("EditarProfesion")
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Connection = con

            cmd.Parameters.AddWithValue("@idprofesion", Datos.gidprofesion)
            cmd.Parameters.AddWithValue("@Profesion", Datos.gprofesion)

            If cmd.ExecuteNonQuery Then
                Return True
            Else
                Return False

            End If
        Catch ex As Exception
            Return False
            MsgBox(ex.ToString)

        Finally
            Desconectarse()

        End Try
    End Function
End Class
