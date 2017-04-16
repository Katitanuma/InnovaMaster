Imports System.ComponentModel
Imports CrystalDecisions.Shared
Imports System.Data.SqlClient
Public Class FrmFactura
    Dim conec As New Conexion
    Public var As Integer = 0
    Private Sub FrmFactura_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing

        If var = 1 Then
            FrmFacturacionVenta.Close()
        ElseIf var = 2 Then
            FrmDetalleVenta.Close()

        End If

    End Sub

    Private Sub FrmFactura_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If var = 1 Then
            Dim cmd As SqlCommand
            Dim ds As New DsReportes
            Dim rpt As New ReporteVenta
            conec.Conectarse()
            cmd = New SqlCommand("ReporteVenta", conec.Con)
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Parameters.Add("@IdVenta", SqlDbType.NVarChar, 50).Value = FrmFacturacionVenta.TxtIdVenta.Text
            cmd.ExecuteNonQuery()
            Dim da As New SqlDataAdapter(cmd)
            da.Fill(ds, "ReporteVenta")
            rpt.SetDataSource(ds)
            rpt.SetParameterValue("Cambio", FrmFacturacionVenta.LblCambio.Text)
            CrystalReportViewer1.ReportSource = rpt
        ElseIf var = 2 Then
            Dim cmd As SqlCommand
            Dim ds As New DsReportes
            Dim rpt As New ReporteVenta
            conec.Conectarse()
            cmd = New SqlCommand("ReporteVenta", conec.Con)
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Parameters.Add("@IdVenta", SqlDbType.NVarChar, 50).Value = FrmDetalleVenta.LblCodigoVenta.Text
            cmd.ExecuteNonQuery()
            Dim da As New SqlDataAdapter(cmd)
            da.Fill(ds, "ReporteVenta")
            rpt.SetDataSource(ds)
            rpt.SetParameterValue("Cambio", FrmDetalleVenta.LblCambio.Text)
            CrystalReportViewer1.ReportSource = rpt
        ElseIf var = 3 Then
            Dim cmd As SqlCommand
            Dim ds As New DsReportes
            Dim rpt As New ReporteVenta
            conec.Conectarse()
            cmd = New SqlCommand("ReporteVenta", conec.Con)
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Parameters.Add("@IdVenta", SqlDbType.NVarChar, 50).Value = ReporteVentas.DgvReporteVentas.CurrentRow.Cells(0).Value.ToString
            cmd.ExecuteNonQuery()
            Dim da As New SqlDataAdapter(cmd)
            da.Fill(ds, "ReporteVenta")
            rpt.SetDataSource(ds)
            If ReporteVentas.DgvReporteVentas.CurrentRow.Cells(7).Value.ToString <> Nothing Then
                rpt.SetParameterValue("Cambio", ReporteVentas.DgvReporteVentas.CurrentRow.Cells(7).Value.ToString)
            Else
                rpt.SetParameterValue("Cambio", "0.00")
            End If

            CrystalReportViewer1.ReportSource = rpt
        End If

    End Sub
End Class