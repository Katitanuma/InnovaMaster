Imports System.Data.SqlClient
Public Class Fproducto
    Inherits Conexion
    Dim cmd As New SqlCommand

    Public Function MostrarProducto() As DataTable
        Try
            Conectarse()
            cmd = New SqlCommand("MostrarProducto")
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Connection = Con
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

    Public Function Insertar(ByVal Datos As DatosProducto) As Boolean

        Try
            Conectarse()
            cmd = New SqlCommand("InsertarProducto")
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Connection = Con

            cmd.Parameters.AddWithValue("@Idproducto", Datos.gIdProducto)
            cmd.Parameters.AddWithValue("@Descripcion", Datos.gDescripcion)
            cmd.Parameters.AddWithValue("@Costo", Datos.gCosto)
            cmd.Parameters.AddWithValue("@Gravado", Datos.gGravado)
            cmd.Parameters.AddWithValue("@PrecioUnitario", Datos.gPrecioUnitario)
            cmd.Parameters.AddWithValue("@PrecioMayorista", Datos.gPrecioMayorista)
            cmd.Parameters.AddWithValue("@Existencia", Datos.gExistecia)
            cmd.Parameters.AddWithValue("@IdCategoria", Datos.gIdCategoria)
            cmd.Parameters.AddWithValue("@IdModelo", Datos.gIdModelo)
            cmd.Parameters.AddWithValue("@Estado", Datos.gEstado)


            cmd.Parameters.AddWithValue("@Imagen", Datos.gImagen)



            If cmd.ExecuteNonQuery Then
                Return True
            Else
                Return False
            End If
        Catch ex As Exception
            If ex.ToString.Contains("The duplicate key value is") Then
                MsgBox("Ese Producto ya Esta Registrado", MsgBoxStyle.Critical, "INNOVAMASTER")
            ElseIf ex.ToString.Contains("'IdModelo'.") Then
                MsgBox("El Modelo No esta Registrado")
            Else
                MsgBox(ex.ToString)
            End If

            Return False
        Finally
            Desconectarse()
        End Try
    End Function

    Public Function Editar(ByVal Datos As DatosProducto) As Boolean

        Try
            Conectarse()
            cmd = New SqlCommand("EditarProducto")
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Connection = Con

            cmd.Parameters.AddWithValue("@Idproducto", Datos.gIdProducto)
            cmd.Parameters.AddWithValue("@Descripcion", Datos.gDescripcion)
            cmd.Parameters.AddWithValue("@Costo", Datos.gCosto)
            cmd.Parameters.AddWithValue("@Gravado", Datos.gGravado)
            cmd.Parameters.AddWithValue("@PrecioUnitario", Datos.gPrecioUnitario)
            cmd.Parameters.AddWithValue("@PrecioMayorista", Datos.gPrecioMayorista)
            cmd.Parameters.AddWithValue("@Existencia", Datos.gExistecia)
            cmd.Parameters.AddWithValue("@IdCategoria", Datos.gIdCategoria)
            cmd.Parameters.AddWithValue("@IdModelo", Datos.gIdModelo)
            cmd.Parameters.AddWithValue("@Estado", Datos.gEstado)
            cmd.Parameters.AddWithValue("@Imagen", Datos.gImagen)
            If cmd.ExecuteNonQuery Then
                Return True
            Else
                Return False
            End If
        Catch ex As Exception
            If ex.ToString.Contains("'IdModelo'.") Then
                MsgBox("El Modelo No esta Registrado")
            Else
                MsgBox(ex.ToString)
            End If

            Return False
        Finally
            Desconectarse()
        End Try
    End Function

End Class
