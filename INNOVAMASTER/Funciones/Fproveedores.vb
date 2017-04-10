Imports System.Data.SqlClient
Public Class Fproveedores
    Inherits Conexion
    Dim cmd As New SqlCommand
    Public Function InsertarProveedor(ByVal Datos As DatosProveedor) As Boolean
        Try
            Conectarse()
            cmd = New SqlCommand("InsertarProveedor")
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Connection = Con

            cmd.Parameters.AddWithValue("@IdProveedor", Datos.gIdProveedor)
            cmd.Parameters.AddWithValue("@RTN", Datos.gRTN)
            cmd.Parameters.AddWithValue("@NombreEmpresa", Datos.gNombreEmpresa)
            cmd.Parameters.AddWithValue("@DireccionEmpresa", Datos.gDireccionEmpresa)
            cmd.Parameters.AddWithValue("@NombreContacto", Datos.gNombreContacto)
            cmd.Parameters.AddWithValue("@ApellidoContacto", Datos.gApellidoContacto)
            cmd.Parameters.AddWithValue("@DireccionContacto", Datos.gDireccionContacto)
            cmd.Parameters.AddWithValue("@TelefonoContacto", Datos.gTelefonoContacto)
            cmd.Parameters.AddWithValue("@CorreoContacto", Datos.gCorreoContacto)
            cmd.Parameters.AddWithValue("@IdMunicipio", Datos.gIdMunicipio)
            cmd.Parameters.AddWithValue("@IdSexo", Datos.gIdSexo)

            If cmd.ExecuteNonQuery Then
                Return True
            Else
                Return False
            End If

        Catch ex As Exception
            If ex.ToString.Contains("The duplicate key value is") Then
                MsgBox("Ese Proveedor ya Esta Registrado", MsgBoxStyle.Critical, "INNOVAMASTER")
            Else
                MsgBox(ex.ToString)
            End If

            Return False
        Finally
            Desconectarse()
        End Try

    End Function
    Public Function EditarProveedor(ByVal Datos As DatosProveedor) As Boolean
        Try
            Conectarse()
            cmd = New SqlCommand("EditarProveedor")
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Connection = Con

            cmd.Parameters.AddWithValue("@IdProveedor", Datos.gIdProveedor)
            cmd.Parameters.AddWithValue("@RTN", Datos.gRTN)
            cmd.Parameters.AddWithValue("@NombreEmpresa", Datos.gNombreEmpresa)
            cmd.Parameters.AddWithValue("@DireccionEmpresa", Datos.gDireccionEmpresa)
            cmd.Parameters.AddWithValue("@NombreContacto", Datos.gNombreContacto)
            cmd.Parameters.AddWithValue("@ApellidoContacto", Datos.gApellidoContacto)
            cmd.Parameters.AddWithValue("@DireccionContacto", Datos.gDireccionContacto)
            cmd.Parameters.AddWithValue("@TelefonoContacto", Datos.gTelefonoContacto)
            cmd.Parameters.AddWithValue("@CorreoContacto", Datos.gCorreoContacto)
            cmd.Parameters.AddWithValue("@IdMunicipio", Datos.gIdMunicipio)
            cmd.Parameters.AddWithValue("@IdSexo", Datos.gIdSexo)

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
    Public Function MostrarProveedores() As DataTable
        Try
            Conectarse()


            cmd = New SqlCommand("MostrarProveedor")
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
