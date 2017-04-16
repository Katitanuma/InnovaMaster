Imports System.Data.SqlClient
Public Class ReporteClientes
    Private Sub ReporteClientes_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call MostrarDatosReporteClientes()
    End Sub
    Dim Connect As New Conexion
    Dim conec As New Conexion

    Private Sub MostrarDatosReporteClientes()

        Using cmd As New SqlCommand
            Try
                Connect.Conectarse()
                With cmd
                    .CommandText = "MostrarDatosClienteReporte"
                    .CommandType = CommandType.StoredProcedure
                    .Connection = Connect.Con
                End With

                Dim AdaptadorReporteClientes As New SqlDataAdapter(cmd)
                Dim dt As New DataTable
                AdaptadorReporteClientes.Fill(dt)
                DgvReporteClientes.DataSource = dt

            Catch ex As Exception
                MessageBox.Show("Error al mostrar el reporte de los clientes " + ex.Message)
            Finally
                Connect.Desconectarse()
            End Try

        End Using
    End Sub

    Private Sub BusquedaFiltradaClientes()
        Using cmd As New SqlCommand
            Try
                Connect.Conectarse()
                With cmd
                    .CommandText = "BusquedaClienteReporte"
                    .CommandType = CommandType.StoredProcedure
                    .Parameters.Add("@Parametro", SqlDbType.NVarChar, 50).Value = TxtBusqueda.Text.Trim
                    .Connection = Connect.Con
                End With

                Dim AdaptadorBusqueda As New SqlDataAdapter(cmd)
                Dim dt As New DataTable
                AdaptadorBusqueda.Fill(dt)
                DgvReporteClientes.DataSource = dt


            Catch ex As Exception
                MessageBox.Show("Error al mostrar los datos " + ex.Message)
            Finally
                Connect.Desconectarse()
            End Try

        End Using
    End Sub

    Private Sub TxtBusqueda_TextChanged(sender As Object, e As EventArgs) Handles TxtBusqueda.TextChanged
        If TxtBusqueda.Text = Nothing Then
            MostrarDatosReporteClientes()
        Else
            BusquedaFiltradaClientes()
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        FrmRptCliente.ShowDialog()
    End Sub


    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim ds As New DsReportes
        Dim rpt As New RptCliente
        Try

            conec.Conectarse()
            Dim cmd As New SqlCommand("ReporteCliente", conec.Con)
            cmd.CommandType = CommandType.StoredProcedure
            cmd.ExecuteNonQuery()
            Dim da As New SqlDataAdapter(cmd)
            da.Fill(ds, "ReporteCliente")
            rpt.SetDataSource(ds)
            rpt.PrintToPrinter(1, False, 0, 0)

        Catch ex As Exception

        End Try
    End Sub
End Class