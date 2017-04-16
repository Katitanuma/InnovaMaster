Imports System.Data.SqlClient
Public Class FrmRptProducto
    Dim conec As New Conexion
    Private Sub FrmRptProducto_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim cmd As SqlCommand
        Dim ds As New DsReportes
        Dim rpt As New RptProducto
        conec.Conectarse()
        cmd = New SqlCommand("ReporteProducto", conec.Con)
        cmd.CommandType = CommandType.StoredProcedure
        cmd.ExecuteNonQuery()
        Dim da As New SqlDataAdapter(cmd)
        da.Fill(ds, "ReporteProducto")
        rpt.SetDataSource(ds)
        CrystalReportViewer1.ReportSource = rpt
    End Sub
End Class