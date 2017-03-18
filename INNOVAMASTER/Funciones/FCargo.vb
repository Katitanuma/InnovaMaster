Imports System.Data.SqlClient
Public Class Fcargo
    Inherits Conexion
    Dim cmd As SqlCommand
    Public Function MostrarCargo() As DataTable
        Try
            Conectarse()
            cmd = New SqlCommand("MostrarCargo")
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
    Public Function InsertarCargo(ByVal Datos As DatosCargo) As Boolean

        Try
            Conectarse()
            cmd = New SqlCommand("InsertarCargo")
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Connection = Con

            cmd.Parameters.AddWithValue("@Cargo", Datos.gcargo)

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
    Public Function Actualizar(ByVal Datos As DatosCargo) As Boolean

        Try
            Conectarse()
            cmd = New SqlCommand("EditarCargo")
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Connection = Con

            cmd.Parameters.AddWithValue("@IdCargo", Datos.gidcargo)
            cmd.Parameters.AddWithValue("@Cargo", Datos.gcargo)

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
