Imports System.Data.SqlClient
Public Class Fcliente
    Inherits Conexion
    Dim cmd As New SqlCommand
    Public Function InsertarCliente(ByVal Datos As DatosCliente) As Boolean
        Try
            Conectarse()
            cmd = New SqlCommand("InsertarCliente")
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Connection = Con

            cmd.Parameters.AddWithValue("@IdCliente", Datos.gIdCliente)
            cmd.Parameters.AddWithValue("@Nombre", Datos.gNombreCliente)
            cmd.Parameters.AddWithValue("@Apellido", Datos.gApellidoCliente)
            cmd.Parameters.AddWithValue("@Direccion", Datos.gDireccionCliente)
            cmd.Parameters.AddWithValue("@Telefono", Datos.gTelefonoCliente)
            cmd.Parameters.AddWithValue("@CorreoCliente", Datos.gCorreoCliente)
            cmd.Parameters.AddWithValue("@FechaNacimiento", Datos.gFechaNacimiento)
            cmd.Parameters.AddWithValue("@IdSexo", Datos.gIdSexo)
            cmd.Parameters.AddWithValue("@IdMunicipio", Datos.gIdMunicipio)
            cmd.Parameters.AddWithValue("@IdEstadoCivil", Datos.gIdEstadoCivil)

            If cmd.ExecuteNonQuery Then
                Return True
            Else
                Return False
            End If

        Catch ex As Exception
            If ex.ToString.Contains("The duplicate key value is") Then
                MsgBox("Ese Cliente ya Esta Registrado", MsgBoxStyle.Critical, "INNOVAMASTER")
            Else
                MsgBox(ex.ToString)
            End If

            Return False
        Finally
            Desconectarse()
        End Try

    End Function
    Public Function EditarCliente(ByVal Datos As DatosCliente) As Boolean
        Try
            Conectarse()
            cmd = New SqlCommand("EditarCliente")
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Connection = Con

            cmd.Parameters.AddWithValue("@IdCliente", Datos.gIdCliente)
            cmd.Parameters.AddWithValue("@Nombre", Datos.gNombreCliente)
            cmd.Parameters.AddWithValue("@Apellido", Datos.gApellidoCliente)
            cmd.Parameters.AddWithValue("@Direccion", Datos.gDireccionCliente)
            cmd.Parameters.AddWithValue("@Telefono", Datos.gTelefonoCliente)
            cmd.Parameters.AddWithValue("@CorreoCliente", Datos.gCorreoCliente)
            cmd.Parameters.AddWithValue("@FechaNacimiento", Datos.gFechaNacimiento)
            cmd.Parameters.AddWithValue("@IdSexo", Datos.gIdSexo)
            cmd.Parameters.AddWithValue("@IdMunicipio", Datos.gIdMunicipio)
            cmd.Parameters.AddWithValue("@IdEstadoCivil", Datos.gIdEstadoCivil)

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
    Public Function MostrarCliente() As DataTable
        Try
            Conectarse()


            cmd = New SqlCommand("MostrarCliente")
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
