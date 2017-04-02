Imports System.ComponentModel
Imports CrystalDecisions.Shared
Imports System.Data.SqlClient
Public Class FrmFactura
    Dim conec As New Conexion

    Private Sub FrmFactura_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
        FrmDetalleVenta.Close()
    End Sub

    Private Sub FrmFactura_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim cmd As SqlCommand
        Dim ds As New DsReportes
        Dim rpt As New ReporteVenta
        conec.Conectarse()
        cmd = New SqlCommand("ReporteVenta", Conec.Con)
        cmd.CommandType = CommandType.StoredProcedure
        cmd.Parameters.Add("@IdVenta", SqlDbType.NVarChar, 50).Value = FrmDetalleVenta.LblCodigoVenta.Text
        cmd.ExecuteNonQuery()
        Dim da As New SqlDataAdapter(cmd)
        da.Fill(ds, "ReporteVenta")
        rpt.SetDataSource(ds)
        rpt.SetParameterValue("Cambio", FrmDetalleVenta.LblCambio.Text)
        CrystalReportViewer1.ReportSource = rpt
    End Sub
End Class