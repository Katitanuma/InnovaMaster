Imports System.ComponentModel
Imports CrystalDecisions.Shared
Public Class FrmFactura
    Dim p1 As New ParameterFields()

    Dim p2 As New ParameterField()

    Dim valor As New ParameterDiscreteValue

    Private Sub FrmFactura_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
        FrmDetalleVenta.Close()
    End Sub

    Private Sub FrmFactura_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        p2.ParameterValueType = ParameterValueKind.StringParameter
        p2.ParameterFieldName = "@IdVenta"
        valor.Value = FrmDetalleVenta.LblCodigoVenta.Text
        p2.CurrentValues.Add(valor)
        p1.Add(p2)
        CrystalReportViewer1.ParameterFieldInfo = p1
        Dim info As New ReporteVenta
        CrystalReportViewer1.ReportSource = info
    End Sub
End Class