Imports System.Data.SqlClient
Public Class Fusuario
    Inherits Conexion
    Dim cmd As New SqlCommand

    Public Function InsertarUsuario(ByVal Datos As DatosUsuario) As Boolean
        Try
            Conectarse()
            cmd = New SqlCommand("InsertarUsuario")
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Connection = Con

            cmd.Parameters.AddWithValue("@Usiario", Datos.gUsuario)
            cmd.Parameters.AddWithValue("@Contrasena", Datos.gContrasena)
            cmd.Parameters.AddWithValue("@IdEmpleado", Datos.gIdEmpleado)
            cmd.Parameters.AddWithValue("@IdTipoAcceso", Datos.gIdTipoAcceso)
            cmd.Parameters.AddWithValue("@Estado", Datos.gEstado)
            If cmd.ExecuteNonQuery Then
                Return True
            Else
                Return False
            End If

        Catch ex As Exception
            MsgBox(ex.ToString)
            Return False
        Finally
            Desconectarse()
        End Try

    End Function

    Public Function EditarUsuario(ByVal Datos As DatosUsuario) As Boolean
        Try
            Conectarse()
            cmd = New SqlCommand("EditarUsuario")
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Connection = Con

            cmd.Parameters.AddWithValue("@IdUsuario", Datos.gIdUsuario)
            cmd.Parameters.AddWithValue("@Usuario", Datos.gUsuario)
            cmd.Parameters.AddWithValue("@Contrasena", Datos.gContrasena)
            cmd.Parameters.AddWithValue("@IdEmpleado", Datos.gIdEmpleado)
            cmd.Parameters.AddWithValue("@IdTipoAcceso", Datos.gIdTipoAcceso)
            cmd.Parameters.AddWithValue("@Estado", Datos.gEstado)
            If cmd.ExecuteNonQuery Then
                Return True
            Else
                Return False
            End If

        Catch ex As Exception
            MsgBox(ex.ToString)
            Return False
        Finally
            Desconectarse()
        End Try

    End Function

    Public Function MostrarUsuario() As DataTable
        Try
            Conectarse()


            cmd = New SqlCommand("MostrarUsuario")
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
