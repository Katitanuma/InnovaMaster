Imports System.ComponentModel
Imports System.Data.SqlClient
Public Class FrmRptPedido
    Public var As Integer = 0
    Dim conec As New Conexion
    Private Sub FrmRptPedido_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
        If var = 2 Then
            FrmPedidos.var = 0
            FrmPedidos.Close()
        End If
    End Sub

    Private Sub FrmRptPedido_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If var = 1 Then
            Dim cmd As SqlCommand
            Dim ds As New DsReportes
            Dim rpt As New RptPedido
            conec.Conectarse()
            cmd = New SqlCommand("ReportePedido", conec.Con)
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Parameters.Add("@IdPedido", SqlDbType.Int).Value = CInt(ReportePedido.DgvReportePedidos.CurrentRow.Cells(0).Value.ToString)
            cmd.ExecuteNonQuery()
            Dim da As New SqlDataAdapter(cmd)
            da.Fill(ds, "ReportePedido")
            rpt.SetDataSource(ds)
            CrystalReportViewer1.ReportSource = rpt
        ElseIf var = 2 Then
            Dim cmd As SqlCommand
            Dim ds As New DsReportes
            Dim rpt As New RptPedido
            conec.Conectarse()
            cmd = New SqlCommand("ReportePedido", conec.Con)
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Parameters.Add("@IdPedido", SqlDbType.Int).Value = CInt(FrmPedidos.LblId.Text.ToString)
            cmd.ExecuteNonQuery()
            Dim da As New SqlDataAdapter(cmd)
            da.Fill(ds, "ReportePedido")
            rpt.SetDataSource(ds)
            CrystalReportViewer1.ReportSource = rpt
        End If
    End Sub
End Class