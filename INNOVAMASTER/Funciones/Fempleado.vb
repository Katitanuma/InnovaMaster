Imports System.Data.SqlClient
Public Class Fempleado
    Inherits Conexion
    Dim cmd As New SqlCommand
    'Funciones para la manipulación y consultas a la base de datos de la relación Empleado
    Public Function InsertarEmpleado(ByVal Datos As DatosEmpleado) As Boolean
        Try
            Conectarse()
            cmd = New SqlCommand("InsertarEmpleado")
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Connection = Con

            cmd.Parameters.AddWithValue("@IdEmpleado", Datos.gIdEmpleado)
            cmd.Parameters.AddWithValue("@NombreEmpleado", Datos.gNombreEmpleado)
            cmd.Parameters.AddWithValue("@ApellidoEmpleado", Datos.gApellidoEmpleado)
            cmd.Parameters.AddWithValue("@DireccionEmpleado", Datos.gDireccionEmpleado)
            cmd.Parameters.AddWithValue("@TelefonoEmpleado", Datos.gTelefonoEmpleado)
            cmd.Parameters.AddWithValue("@CelularEmpleado", Datos.gCelularEmpleado)
            cmd.Parameters.AddWithValue("@FechaNacimiento", Datos.gFechaNacimiento)
            cmd.Parameters.AddWithValue("@FechaContratacion", Datos.gFechaContratacion)
            cmd.Parameters.AddWithValue("@Idmunicipio ", Datos.gIdMunicipio)
            cmd.Parameters.AddWithValue("@IdCargo", Datos.gIdCargo)
            cmd.Parameters.AddWithValue("@IdSucursal", Datos.gIdSucursal)
            cmd.Parameters.AddWithValue("@IdEstadoCivil", Datos.gIdEstadoCivil)
            cmd.Parameters.AddWithValue("@IdProfesion", Datos.gIdProfesion)
            cmd.Parameters.AddWithValue("@IdSexo", Datos.gIdSexo)
            cmd.Parameters.AddWithValue("@Imagen", Datos.gImagen)
            If cmd.ExecuteNonQuery Then
                Return True
            Else
                Return False
            End If

        Catch ex As Exception
            If ex.ToString.Contains("The duplicate key value is") Then
                MsgBox("Ese Empleado ya Esta Registrado", MsgBoxStyle.Critical, "INNOVAMASTER")
            Else
                MsgBox(ex.ToString)
            End If
            Return False
        Finally
            Desconectarse()
        End Try

    End Function

    Public Function EditarEmpleado(ByVal Datos As DatosEmpleado) As Boolean
        Try
            Conectarse()
            cmd = New SqlCommand("EditarEmpleado")
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Connection = Con

            cmd.Parameters.AddWithValue("@IdEmpleado", Datos.gIdEmpleado)
            cmd.Parameters.AddWithValue("@NombreEmpleado", Datos.gNombreEmpleado)
            cmd.Parameters.AddWithValue("@ApellidoEmpleado", Datos.gApellidoEmpleado)
            cmd.Parameters.AddWithValue("@DireccionEmpleado", Datos.gDireccionEmpleado)
            cmd.Parameters.AddWithValue("@TelefonoEmpleado", Datos.gTelefonoEmpleado)
            cmd.Parameters.AddWithValue("@CelularEmpleado", Datos.gCelularEmpleado)
            cmd.Parameters.AddWithValue("@FechaNacimiento", Datos.gFechaNacimiento)
            cmd.Parameters.AddWithValue("@FechaContratacion", Datos.gFechaContratacion)
            cmd.Parameters.AddWithValue("@IdMunicipio", Datos.gIdMunicipio)
            cmd.Parameters.AddWithValue("@IdCargo", Datos.gIdCargo)
            cmd.Parameters.AddWithValue("@IdSucursal", Datos.gIdSucursal)
            cmd.Parameters.AddWithValue("@IdEstadoCivil", Datos.gIdEstadoCivil)
            cmd.Parameters.AddWithValue("@IdProfesion", Datos.gIdProfesion)
            cmd.Parameters.AddWithValue("@IdSexo", Datos.gIdSexo)
            cmd.Parameters.AddWithValue("@Imagen", Datos.gImagen)
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

    Public Function MostrarEmpleado() As DataTable
        Try
            Conectarse()


            cmd = New SqlCommand("MostrarEmpleado")
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
