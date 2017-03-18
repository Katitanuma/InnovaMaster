Imports System.Data.SqlClient

Public Class FModelo
    Inherits conexion

    Dim cmd As New SqlCommand

    Public Function MostrarModelo() As DataTable
        Try
            Conectarse()
            cmd = New SqlCommand("MostrarModeloVehiculo")
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

    Public Function Insertar(ByVal Datos As DatosModelo) As Boolean

        Try
            Conectarse()
            cmd = New SqlCommand("InsertarModeloVehiculo")
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Connection = con

            cmd.Parameters.AddWithValue("@Modelo", Datos.gModelo)
            cmd.Parameters.AddWithValue("@IdMarca", Datos.gIdMarca)

            If cmd.ExecuteNonQuery Then
                Return True
            Else
                Return False

            End If
        Catch ex As Exception


            MsgBox(ex.Message)

            Return False
        Finally
            Desconectarse()

        End Try
    End Function

    Public Function Actualizar(ByVal Datos As DatosModelo) As Boolean

        Try
            Conectarse()
            cmd = New SqlCommand("EditarModeloVehiculo")
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Connection = con

            cmd.Parameters.AddWithValue("@IdModelo", Datos.gIdModelo)
            cmd.Parameters.AddWithValue("@Modelo", Datos.gModelo)
            cmd.Parameters.AddWithValue("@IdMarca", Datos.gIdMarca)

            If cmd.ExecuteNonQuery Then
                Return True
            Else
                Return False

            End If
        Catch ex As Exception


            MsgBox(ex.Message)

            Return False
        Finally
            Desconectarse()

        End Try
    End Function
End Class
