﻿Imports System.Data.SqlClient
Public Class ReporteProductos
    Private Sub ReporteProductos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call MostrarDatosReporteProdcutos()
    End Sub
    Dim Connect As New Conexion

    Private Sub MostrarDatosReporteProdcutos()

        Using cmd As New SqlCommand
            Try
                Connect.Conectarse()
                With cmd
                    .CommandText = "MostrarDatosProductoReporte"
                    .CommandType = CommandType.StoredProcedure
                    .Connection = Connect.Con
                End With

                Dim AdaptadorReporteProductos As New SqlDataAdapter(cmd)
                Dim dt As New DataTable
                AdaptadorReporteProductos.Fill(dt)
                DgvReporteProductos.DataSource = dt

            Catch ex As Exception
                MessageBox.Show("Error al mostrar el reporte de los productos " + ex.Message)
            Finally
                Connect.Desconectarse()
            End Try

        End Using
    End Sub

    Private Sub BusquedaFiltradaProductos()
        Using cmd As New SqlCommand
            Try
                Connect.Conectarse()
                With cmd
                    .CommandText = "Sp_BusquedaCiudad"
                    .CommandType = CommandType.StoredProcedure
                    .Parameters.Add("@Parametro", SqlDbType.NVarChar, 50).Value = TxtBusqueda.Text.Trim
                    .Connection = Connect.Con
                End With

                Dim AdaptadorBusqueda As New SqlDataAdapter(cmd)
                Dim dt As New DataTable
                AdaptadorBusqueda.Fill(dt)
                DgvReporteProductos.DataSource = dt


            Catch ex As Exception
                MessageBox.Show("Error al mostrar los datos " + ex.Message)
            Finally
                Connect.Desconectarse()
            End Try

        End Using
    End Sub

    Private Sub TxtBusqueda_TextChanged(sender As Object, e As EventArgs) Handles TxtBusqueda.TextChanged
        If TxtBusqueda.Text = Nothing Then
            MostrarDatosReporteProdcutos()
        Else
            BusquedaFiltradaProductos()
        End If
    End Sub
End Class