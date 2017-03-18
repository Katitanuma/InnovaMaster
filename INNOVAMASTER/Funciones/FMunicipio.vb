Imports System.Data.SqlClient
Public Class FMunicipio
    Inherits conexion

    Dim cmd As New SqlCommand
    Public Function MostrarMunicipio() As DataTable
        Try
            Conectarse()
            cmd = New SqlCommand("MostrarMunicipio")
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

    Public Function Insertar(ByVal Datos As DatosMunicipio) As Boolean

        Try
            Conectarse()
            cmd = New SqlCommand("InsertarMunicipio")
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Connection = con

            cmd.Parameters.AddWithValue("@Municipio", Datos.gMunicipio)
            cmd.Parameters.AddWithValue("@IdDepartamento", Datos.gIdDepartamento)

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
    Public Function Actualizar(ByVal Datos As DatosMunicipio) As Boolean

        Try
            Conectarse()
            cmd = New SqlCommand("EditarMunicipio")
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Connection = con

            cmd.Parameters.AddWithValue("@IdMunicipio", Datos.gIdMunicipio)
            cmd.Parameters.AddWithValue("@Municipio", Datos.gMunicipio)
            cmd.Parameters.AddWithValue("@IdDepartamento", Datos.gIdDepartamento)

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

