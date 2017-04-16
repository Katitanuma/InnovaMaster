Imports System.Data.SqlClient
Public Class FrmRptCliente
    Dim conec As New Conexion
    Private Sub FrmRptCliente_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim cmd As SqlCommand
        Dim ds As New DsReportes
        Dim rpt As New RptCliente
        conec.Conectarse()
        cmd = New SqlCommand("ReporteCliente", conec.Con)
        cmd.CommandType = CommandType.StoredProcedure
        cmd.ExecuteNonQuery()
        Dim da As New SqlDataAdapter(cmd)
        da.Fill(ds, "ReporteCliente")
        rpt.SetDataSource(ds)
        CrystalReportViewer1.ReportSource = rpt
    End Sub
End Class