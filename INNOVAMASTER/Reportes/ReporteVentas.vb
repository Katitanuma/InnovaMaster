Imports System.Data.SqlClient
Public Class ReporteVentas
    Private Sub ReporteVentas_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call MostrarDatosReporteVentas()
        Dim NombreArchivo As String = HTMLHelpClass.GetLocalHelpFileName("InnovaMasterAyuda2017.chm")
        HelpProvider1.HelpNamespace = NombreArchivo
        HelpProvider1.SetHelpNavigator(Me, HelpNavigator.KeywordIndex)
        HelpProvider1.SetHelpKeyword(Me, "Reporte Venta")

    End Sub
    Dim Connect As New Conexion
    Dim conec As New Conexion
    Dim cmd As New SqlCommand

    Private Sub MostrarDatosReporteVentas()

        Using cmd As New SqlCommand
            Try
                Connect.Conectarse()
                With cmd
                    .CommandText = "MostrarDatosVentaReporte"
                    .CommandType = CommandType.StoredProcedure
                    .Connection = Connect.Con
                End With

                Dim AdaptadorReporteVentas As New SqlDataAdapter(cmd)
                Dim dt As New DataTable
                AdaptadorReporteVentas.Fill(dt)
                DgvReporteVentas.DataSource = dt
                DgvReporteVentas.Columns(7).Visible = False

            Catch ex As Exception
                MessageBox.Show("Error al mostrar el reporte de las ventas " + ex.Message)
            Finally
                Connect.Desconectarse()
            End Try

        End Using
    End Sub

    Private Sub BusquedaFiltradaVentas()
        Using cmd As New SqlCommand
            Try
                Connect.Conectarse()
                With cmd
                    .CommandText = "BusquedaVentaReporte"
                    .CommandType = CommandType.StoredProcedure
                    .Parameters.Add("@Parametro", SqlDbType.NVarChar, 50).Value = TxtBusqueda.Text.Trim
                    .Connection = Connect.Con
                End With

                Dim AdaptadorBusqueda As New SqlDataAdapter(cmd)
                Dim dt As New DataTable
                AdaptadorBusqueda.Fill(dt)
                DgvReporteVentas.DataSource = dt
                DgvReporteVentas.Columns(7).Visible = False

            Catch ex As Exception
                MessageBox.Show("Error al mostrar los datos " + ex.Message)
            Finally
                Connect.Desconectarse()
            End Try

        End Using
    End Sub

    Private Sub TxtBusqueda_TextChanged(sender As Object, e As EventArgs) Handles TxtBusqueda.TextChanged
        If TxtBusqueda.Text = Nothing Then
            MostrarDatosReporteVentas()
        Else
            BusquedaFiltradaVentas()
        End If
    End Sub

    Private Sub ImprimirToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ImprimirToolStripMenuItem.Click
        Dim ds As New DsReportes
        Dim rpt As New ReporteVenta
        Try

            conec.Conectarse()
            cmd = New SqlCommand("ReporteVenta", Conec.Con)
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Parameters.Add("@IdVenta", SqlDbType.NVarChar, 50).Value = DgvReporteVentas.CurrentRow.Cells(0).Value.ToString
            cmd.ExecuteNonQuery()
            Dim da As New SqlDataAdapter(cmd)
            da.Fill(ds, "ReporteVenta")
            rpt.SetDataSource(ds)
            If DgvReporteVentas.CurrentRow.Cells(7).Value.ToString <> Nothing Then
                rpt.SetParameterValue("Cambio", DgvReporteVentas.CurrentRow.Cells(7).Value.ToString)
            Else
                rpt.SetParameterValue("Cambio", "0.00")
            End If

            rpt.PrintToPrinter(1, False, 0, 0)

        Catch ex As Exception

        End Try
    End Sub

    Private Sub VerReporeToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles VerReporeToolStripMenuItem.Click
        FrmFactura.var = 3
        FrmFactura.ShowDialog()
    End Sub
End Class