Imports System.Data.SqlClient
Public Class FrmProductoProveedor
    Dim conec As New Conexion
    Private Sub FrmProductoProveedor_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LlenarComboBox()
        TxtCodigoProducto.Clear()
        CboProveedor.Text = Nothing
        MostrarDatos()
    End Sub
    Public Sub LlenarComboBox()
        Using Cmd As New SqlCommand
            Try
                conec.Conectarse()
                With Cmd
                    .CommandText = "MostrarIdentificacionProveedor"
                    .CommandType = CommandType.StoredProcedure
                    .Parameters.Add("@IdProducto", SqlDbType.NVarChar, 50).Value = FrmProducto.TxtIdProducto.Text.Trim
                    .Connection = conec.Con
                    .ExecuteNonQuery()
                End With
                Dim Adaptador As New SqlDataAdapter(Cmd)
                Dim dt As New DataTable
                Adaptador.Fill(dt)
                CboProveedor.DataSource = dt
                CboProveedor.DisplayMember = dt.Columns("Nombre").ToString
                CboProveedor.ValueMember = dt.Columns("IdProveedor").ToString
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        End Using
    End Sub
    Private Sub MostrarDatos()
        Using Cmd As New SqlCommand
            Try
                conec.Conectarse()
                With Cmd
                    .CommandText = "MostrarProductoProveedor"
                    .CommandType = CommandType.StoredProcedure
                    .Parameters.Add("@IdProducto", SqlDbType.NVarChar, 50).Value = FrmProducto.TxtIdProducto.Text.Trim
                    .Connection = conec.Con
                    .ExecuteNonQuery()
                End With
                Dim Adaptador As New SqlDataAdapter(Cmd)
                Dim dt As New DataTable
                Adaptador.Fill(dt)
                DgvProductoProveedor.DataSource = dt
                DgvProductoProveedor.Columns(3).Visible = False
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        End Using
    End Sub

    Private Sub EliminarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EliminarToolStripMenuItem.Click
        Using Cmd As New SqlCommand
            Try
                conec.Conectarse()
                With Cmd
                    .CommandText = "EliminarProductoProveedor"
                    .CommandType = CommandType.StoredProcedure
                    .Parameters.Add("@IdProductoProveedor", SqlDbType.NVarChar, 50).Value = DgvProductoProveedor.CurrentRow.Cells(0).Value.ToString
                    .Parameters.Add("@IdProveedor", SqlDbType.VarChar, 15).Value = DgvProductoProveedor.CurrentRow.Cells(3).Value.ToString
                    .Connection = conec.Con
                    .ExecuteNonQuery()
                End With
                MostrarDatos()
                LlenarComboBox()
                TxtCodigoProducto.Clear()
                CboProveedor.Text = Nothing
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        End Using
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If TxtCodigoProducto.Text <> Nothing And CboProveedor.Text <> Nothing Then
            Using Cmd As New SqlCommand
                Try
                    conec.Conectarse()
                    With Cmd
                        .CommandText = "InsertarProductoProveedor"
                        .CommandType = CommandType.StoredProcedure
                        .Parameters.Add("@IdProductoProveedor", SqlDbType.NVarChar, 50).Value = TxtCodigoProducto.Text.Trim
                        .Parameters.Add("@IdProducto", SqlDbType.NVarChar, 50).Value = FrmProducto.TxtIdProducto.Text.Trim
                        .Parameters.Add("@IdProveedor", SqlDbType.VarChar, 15).Value = CboProveedor.SelectedValue.ToString
                        .Connection = conec.Con
                        .ExecuteNonQuery()
                    End With
                    MostrarDatos()
                    LlenarComboBox()
                    TxtCodigoProducto.Clear()
                    CboProveedor.Text = Nothing
                Catch ex As Exception
                    MsgBox(ex.Message)
                End Try
            End Using
        Else
            MsgBox("Ingrese o seleccione los valores", MsgBoxStyle.Information, "INNOVAMASTER")
        End If
    End Sub


End Class