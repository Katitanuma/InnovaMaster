Imports System.Data.SqlClient
Public Class Fcategoria
    Inherits Conexion
    Dim cmd As SqlCommand
    Public Function MostrarCategoria() As DataTable
        Try
            Conectarse()
            cmd = New SqlCommand("MostrarCategoria")
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
    Public Function Insertar(ByVal Datos As DatosProfesion) As Boolean

        Try
            Conectarse()
            cmd = New SqlCommand("InsertarCategoria")
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Connection = con

            cmd.Parameters.AddWithValue("@Categoria", Datos.gcategoria)

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
    Public Function Actualizar(ByVal Datos As DatosProfesion) As Boolean

        Try
            Conectarse()
            cmd = New SqlCommand("EditarCategoria")
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Connection = con

            cmd.Parameters.AddWithValue("@IdCategoria", Datos.gidcategoria)
            cmd.Parameters.AddWithValue("@Categoria", Datos.gcategoria)

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
