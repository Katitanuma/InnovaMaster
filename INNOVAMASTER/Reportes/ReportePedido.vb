Imports System.Data.SqlClient
Public Class ReportePedido
    Private Sub ReportePedido_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Call MostrarDatosReportePedidos()

    End Sub
    Dim Connect As New Conexion

    Private Sub MostrarDatosReportePedidos()

        Using cmd As New SqlCommand
            Try
                Connect.Conectarse()
                With cmd
                    .CommandText = "MostrarDatosPedidoReporte"
                    .CommandType = CommandType.StoredProcedure
                    .Connection = Connect.Con
                End With

                Dim AdaptadorReportePedidos As New SqlDataAdapter(cmd)
                Dim dt As New DataTable
                AdaptadorReportePedidos.Fill(dt)
                DgvReportePedidos.DataSource = dt

            Catch ex As Exception
                MessageBox.Show("Error al mostrar el reporte de los pedidos " + ex.Message)
            Finally
                Connect.Desconectarse()
            End Try

        End Using
    End Sub

    Private Sub BusquedaFiltradaPedidos()
        Using cmd As New SqlCommand
            Try
                Connect.Conectarse()
                With cmd
                    .CommandText = "Sp_BusquedaCiudad"
                    .CommandType = CommandType.StoredProcedure
                    .Parameters.Add("@Parametro", SqlDbType.NVarChar, 50).Value = TxtBusqueda.Text.Trim
                    .Connection = Connect.Con
                End With

                Dim AdaptadorBusqueda As New SqlDataAdapter(cmd)
                Dim dt As New DataTable
                AdaptadorBusqueda.Fill(dt)
                DgvReportePedidos.DataSource = dt


            Catch ex As Exception
                MessageBox.Show("Error al mostrar los datos " + ex.Message)
            Finally
                Connect.Desconectarse()
            End Try

        End Using
    End Sub

    Private Sub TxtBusqueda_TextChanged(sender As Object, e As EventArgs) Handles TxtBusqueda.TextChanged
        If TxtBusqueda.Text = Nothing Then
            MostrarDatosReportePedidos()
        Else
            BusquedaFiltradaPedidos()
        End If
    End Sub
End Class