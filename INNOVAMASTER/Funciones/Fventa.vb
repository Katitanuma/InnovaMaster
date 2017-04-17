Imports System.Data.SqlClient
Public Class Fventa
    Inherits Conexion
    Dim cmd As New SqlCommand

    Public Function InsertarVenta(ByVal Datos As DatosVenta) As Boolean
        Try
            Conectarse()
            cmd = New SqlCommand("InsertarVenta")
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Connection = Con

            cmd.Parameters.AddWithValue("@IdVenta", Datos.gIdVenta)
            cmd.Parameters.AddWithValue("@IdCliente", Datos.gIdCliente)
            cmd.Parameters.AddWithValue("@FechaVenta", Datos.gFechaVenta)
            cmd.Parameters.AddWithValue("@FechaVencimiento", Datos.gFechaVencimiento)
            cmd.Parameters.AddWithValue("@IdFormaVenta", Datos.gIdFormaVenta)
            cmd.Parameters.AddWithValue("@IdTipoVenta", Datos.gIdTipoVenta)
            cmd.Parameters.AddWithValue("@IdUsuario", Datos.gIdUsuario)
            cmd.Parameters.AddWithValue("@DescuentoExtra", Datos.gDescuentoExtra)
            cmd.Parameters.AddWithValue("@Cambio", Datos.gCambio)

            If cmd.ExecuteNonQuery Then
                Return True
            Else
                Return False
            End If

        Catch ex As Exception
            If ex.ToString.Contains("'IdCliente'.") Then
                MsgBox("El Cliente No esta Registrado")
            Else
                MsgBox(ex.Message)
            End If

            Return False
        Finally
            Desconectarse()
        End Try

    End Function

    Public Function EditarVenta(ByVal Datos As DatosVenta) As Boolean
        Try
            Conectarse()
            cmd = New SqlCommand("EditarVenta")
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Connection = Con

            cmd.Parameters.AddWithValue("@IdVenta", Datos.gIdVenta)
            cmd.Parameters.AddWithValue("@IdCliente", Datos.gIdCliente)
            cmd.Parameters.AddWithValue("@FechaVenta", Datos.gFechaVenta)
            cmd.Parameters.AddWithValue("@FechaVencimiento", Datos.gFechaVencimiento)
            cmd.Parameters.AddWithValue("@IdFormaVenta", Datos.gIdFormaVenta)
            cmd.Parameters.AddWithValue("@IdTipoVenta", Datos.gIdTipoVenta)
            cmd.Parameters.AddWithValue("@DescuentoExtra", Datos.gDescuentoExtra)

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

    Public Function MostrarVenta() As DataTable
        Try
            Conectarse()


            cmd = New SqlCommand("MostrarVenta")
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Connection = Con

            If cmd.ExecuteNonQuery Then
                Dim dt As New DataTable
                Dim da As New SqlDataAdapter
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



End Class
