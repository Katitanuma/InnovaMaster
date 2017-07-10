Imports System.Data.SqlClient
Public Class ReportePedido
    Private Sub ReportePedido_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Call MostrarDatosReportePedidos()

        Dim NombreArchivo As String = HTMLHelpClass.GetLocalHelpFileName("InnovaMasterAyuda2017.chm")
        HelpProvider1.HelpNamespace = NombreArchivo
        HelpProvider1.SetHelpNavigator(Me, HelpNavigator.KeywordIndex)
        HelpProvider1.SetHelpKeyword(Me, "Reporte Pedidos")

    End Sub
    Dim Connect As New Conexion
    Dim conec As New Conexion

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
                    .CommandText = "BusquedaPedidoReporte"
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

    Private Sub VisualizarReporteToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles VisualizarReporteToolStripMenuItem.Click
        FrmRptPedido.var = 1
        FrmRptPedido.Show()
    End Sub

    Private Sub ImprimirReporteToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ImprimirReporteToolStripMenuItem.Click
        Dim ds As New DsReportes
        Dim rpt As New RptPedido
        Try

            conec.Conectarse()
            Dim cmd As New SqlCommand
            cmd = New SqlCommand("ReportePedido", conec.Con)
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Parameters.Add("@IdPedido", SqlDbType.Int).Value = CInt(DgvReportePedidos.CurrentRow.Cells(0).Value.ToString)
            cmd.ExecuteNonQuery()
            Dim da As New SqlDataAdapter(cmd)
            da.Fill(ds, "ReportePedido")
            rpt.SetDataSource(ds)
            rpt.PrintToPrinter(1, False, 0, 0)

        Catch ex As Exception

        End Try
    End Sub
End Class