Imports System.ComponentModel
Imports System.Data.SqlClient
Public Class FrmRptCompra
    Public var As Integer = 0
    Dim conec As New Conexion

    Private Sub FrmRptCompra_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
        If var = 2 Then
            FrmCompras.var = 0
            FrmCompras.Close()
        End If
    End Sub

    Private Sub FrmRptCompra_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If var = 1 Then
            Dim cmd As SqlCommand
            Dim ds As New DsReportes
            Dim rpt As New RptCompra
            conec.Conectarse()
            cmd = New SqlCommand("ReporteCompra", conec.Con)
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Parameters.Add("@IdCompra", SqlDbType.Int).Value = CInt(ReporteCompras.DgvReporteCompra.CurrentRow.Cells(0).Value.ToString)
            cmd.ExecuteNonQuery()
            Dim da As New SqlDataAdapter(cmd)
            da.Fill(ds, "ReporteCompra")
            rpt.SetDataSource(ds)
            CrystalReportViewer1.ReportSource = rpt
        ElseIf var = 2 Then
            Dim cmd As SqlCommand
            Dim ds As New DsReportes
            Dim rpt As New RptCompra
            conec.Conectarse()
            cmd = New SqlCommand("ReporteCompra", conec.Con)
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Parameters.Add("@IdCompra", SqlDbType.Int).Value = CInt(FrmCompras.LblId.Text.ToString)
            cmd.ExecuteNonQuery()
            Dim da As New SqlDataAdapter(cmd)
            da.Fill(ds, "ReporteCompra")
            rpt.SetDataSource(ds)
            CrystalReportViewer1.ReportSource = rpt
        End If
    End Sub
End Class