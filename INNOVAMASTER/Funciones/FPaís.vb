Imports System.Data.SqlClient

Public Class FPais
    Inherits conexion

    Dim cmd As New SqlCommand

    Public Function MostrarPais() As DataTable
        Try
            Conectarse()
            cmd = New SqlCommand("MostrarPais")
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
    Public Function Insertar(ByVal Datos As DatosPais) As Boolean

        Try
            Conectarse()
            cmd = New SqlCommand("InsertarPais")
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Connection = con

            cmd.Parameters.AddWithValue("@Pais", Datos.gPais)

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
    Public Function Actualizar(ByVal Datos As DatosPais) As Boolean

        Try
            Conectarse()
            cmd = New SqlCommand("EditarPais")
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Connection = con

            cmd.Parameters.AddWithValue("@IdPais", Datos.gIdPais)
            cmd.Parameters.AddWithValue("@Pais", Datos.gPais)


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
