Imports System.Data.SqlClient
Public Class FrmLogAuditoria
    Dim conec As New Conexion
    Private Sub MostrarTodosLogAuditoria()

        Using cmd As New SqlCommand
            Try
                conec.Conectarse()

                With cmd
                    .CommandText = "Sp_MostrarTodoLogAuditoria"
                    .CommandType = CommandType.StoredProcedure
                    .Connection = conec.Con
                End With

                Dim AdaptadorLog As New SqlDataAdapter(cmd)
                Dim dt As New DataTable
                AdaptadorLog.Fill(dt)
                DgvLogAuditoria.DataSource = dt

            Catch ex As Exception
                MessageBox.Show("Error al mostrar los datos del log de auditoria" + ex.Message)
            Finally
                conec.Conectarse()
            End Try

        End Using
    End Sub
    Private Sub BusquedaFiltradasLogAuditoria()


        Using cmd As New SqlCommand
            Try
                conec.Conectarse()

                With cmd
                    .CommandText = "Sp_BusquedaLogAuditoria"
                    .CommandType = CommandType.StoredProcedure
                    .Parameters.Add("@Parametro", SqlDbType.NVarChar, 50).Value = TxtBusqueda.Text.Trim
                    .Connection = conec.Con
                End With

                Dim AdaptadorBusqueda As New SqlDataAdapter(cmd)
                Dim dt As New DataTable
                AdaptadorBusqueda.Fill(dt)
                DgvLogAuditoria.DataSource = dt


            Catch ex As Exception
                MessageBox.Show("Error al mostrar los datos " + ex.Message)
            Finally
                conec.Desconectarse()
            End Try

        End Using
    End Sub

    Private Sub TxtBusqueda_TextChanged(sender As Object, e As EventArgs) Handles TxtBusqueda.TextChanged
        If TxtBusqueda.Text = Nothing Then
            MostrarTodosLogAuditoria()
        Else
            BusquedaFiltradasLogAuditoria()
        End If
    End Sub

    Private Sub FrmLogAuditoria_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        MostrarTodosLogAuditoria()
    End Sub
End Class