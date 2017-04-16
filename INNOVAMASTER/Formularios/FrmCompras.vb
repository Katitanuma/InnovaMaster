Imports System.ComponentModel
Imports System.Data.SqlClient

Public Class FrmCompras
    Dim Conec As New Conexion
    Dim cmd As SqlCommand
    Dim x As Integer = 0
    Public var As Integer = 1
    Dim s As Integer = 0

    Private Sub DataGridView1_CellEndEdit(sender As Object, e As DataGridViewCellEventArgs) Handles DgvDetalle.CellEndEdit
        Dim column As Integer = DgvDetalle.CurrentCell.ColumnIndex
        If column = 1 Then


            Try
                If DgvDetalle.Rows(e.RowIndex).Cells(1).Value <> Nothing Then

                    Conec.Conectarse()
                    Dim c As String = DgvDetalle.Rows(e.RowIndex).Cells(1).Value.ToString
                    Dim c2 As String() = c.Split("/")
                    DgvDetalle.Rows(e.RowIndex).Cells(1).Value = c2(0).ToString

                    Dim dr As SqlDataReader
                    cmd = New SqlCommand("Select Descripcion,Gravado,Gravado,Costo, PrecioMayorista, Existencia, Estado from Producto Where IdProducto='" & DgvDetalle.Rows(e.RowIndex).Cells(1).Value & "'")
                    cmd.CommandType = CommandType.Text
                    cmd.Connection = Conec.Con
                    dr = cmd.ExecuteReader

                    If dr.Read Then
                        If dr.GetValue(6).ToString = "Activo" Then
                            DgvDetalle.Rows(e.RowIndex).Cells(2).Value = dr(0).ToString

                            DgvDetalle.Rows(e.RowIndex).Cells(3).Value = 1

                            DgvDetalle.Rows(e.RowIndex).Cells(5).Value = FormatCurrency(CDbl(dr.GetValue(1)), 2)
                            DgvDetalle.Rows(e.RowIndex).Cells(4).Value = FormatCurrency(CDbl(dr.GetValue(3)), 2)

                            DgvDetalle.Rows(e.RowIndex).Cells(6).Value = FormatCurrency((DgvDetalle.Rows(e.RowIndex).Cells(4).Value) * CDbl(DgvDetalle.Rows(e.RowIndex).Cells(3).Value), 2)


                            DgvDetalle.CurrentRow.Cells(1).ReadOnly = True
                            DgvDetalle.CurrentRow.Cells(2).ReadOnly = True
                            DgvDetalle.Rows(e.RowIndex).Cells(2).ErrorText = ""
                            DgvDetalle.Rows(e.RowIndex).Cells(1).ErrorText = ""

                        Else
                            MsgBox("El estado del producto está inactivo", MsgBoxStyle.Exclamation)
                            DgvDetalle.Rows.Remove(DgvDetalle.CurrentRow)
                            LlenarTextBox()

                        End If

                    Else
                        DgvDetalle.Rows(e.RowIndex).Cells(1).Value = Nothing
                        MsgBox("Producto no registrado", MsgBoxStyle.Information)
                        DgvDetalle.Rows.Remove(DgvDetalle.CurrentRow)
                    End If
                    dr.Close()
                Else
                    DgvDetalle.Rows(e.RowIndex).Cells(1).ErrorText = "Ingrese el Codigo del Producto"
                End If

            Catch ex As Exception
                MsgBox(ex.ToString)
            Finally
                Conec.Desconectarse()

            End Try


        ElseIf column = 2 Then
            Try
                If DgvDetalle.Rows(e.RowIndex).Cells(2).Value <> Nothing Then

                    Conec.Conectarse()

                    Dim c As String = DgvDetalle.Rows(e.RowIndex).Cells(2).Value.ToString

                    Dim c2 As String() = c.Split("/")
                    DgvDetalle.Rows(e.RowIndex).Cells(2).Value = c2(0).ToString
                    DgvDetalle.Rows(e.RowIndex).Cells(1).Value = c2(1).ToString



                    Dim dr As SqlDataReader
                    cmd = New SqlCommand("Select IdProducto,Gravado,Gravado,Costo, PrecioMayorista, Existencia, Estado,Descripcion from Producto Where IdProducto='" & DgvDetalle.Rows(e.RowIndex).Cells(1).Value & "'")
                    cmd.CommandType = CommandType.Text
                    cmd.Connection = Conec.Con
                    dr = cmd.ExecuteReader

                    If dr.Read Then
                        If dr.GetValue(6).ToString = "Activo" Then




                            DgvDetalle.Rows(e.RowIndex).Cells(3).Value = 1

                            DgvDetalle.Rows(e.RowIndex).Cells(5).Value = FormatCurrency(CDbl(dr.GetValue(1)), 2)
                            DgvDetalle.Rows(e.RowIndex).Cells(4).Value = FormatCurrency(CDbl(dr.GetValue(3)), 2)

                            DgvDetalle.Rows(e.RowIndex).Cells(6).Value = FormatCurrency((DgvDetalle.Rows(e.RowIndex).Cells(4).Value) * CDbl(DgvDetalle.Rows(e.RowIndex).Cells(3).Value), 2)


                            DgvDetalle.CurrentRow.Cells(1).ReadOnly = True
                            DgvDetalle.CurrentRow.Cells(2).ReadOnly = True
                            DgvDetalle.Rows(e.RowIndex).Cells(2).ErrorText = ""
                            DgvDetalle.Rows(e.RowIndex).Cells(1).ErrorText = ""

                        Else
                            MsgBox("El estado del producto está inactivo", MsgBoxStyle.Exclamation)
                            DgvDetalle.Rows.Remove(DgvDetalle.CurrentRow)
                            LlenarTextBox()

                        End If

                    Else

                        DgvDetalle.Rows(e.RowIndex).Cells(1).Value = Nothing
                        DgvDetalle.Rows(e.RowIndex).Cells(2).Value = Nothing
                        MsgBox("Producto no registrado", MsgBoxStyle.Information)
                        DgvDetalle.Rows(e.RowIndex).Cells(2).ErrorText = "Producto No Registrado"
                        DgvDetalle.Rows.Remove(DgvDetalle.CurrentRow)
                    End If
                    dr.Close()
                Else
                    DgvDetalle.Rows(e.RowIndex).Cells(2).ErrorText = "Ingrese el Nombre del Producto"

                End If

            Catch ex As Exception
                DgvDetalle.Rows(e.RowIndex).Cells(1).Value = Nothing
                DgvDetalle.Rows(e.RowIndex).Cells(2).Value = Nothing
                MsgBox("Producto no registrado", MsgBoxStyle.Information)
                DgvDetalle.Rows.Remove(DgvDetalle.CurrentRow)

            Finally
                Conec.Desconectarse()
            End Try

        ElseIf column = 3 Then
            Conec.Conectarse()
            Dim dr2 As SqlDataReader

            cmd = New SqlCommand("Select Gravado from Producto Where IdProducto='" & DgvDetalle.Rows(e.RowIndex).Cells(1).Value & "'")
            cmd.CommandType = CommandType.Text
            cmd.Connection = Conec.Con
            dr2 = cmd.ExecuteReader
            If dr2.Read() Then
                DgvDetalle.Rows(e.RowIndex).Cells(5).Value = FormatCurrency(CDbl(DgvDetalle.Rows(e.RowIndex).Cells(3).Value) * CDbl(dr2.GetValue(0)), 2)
            End If


            DgvDetalle.Rows(e.RowIndex).Cells(6).Value = FormatCurrency(CDbl(DgvDetalle.Rows(e.RowIndex).Cells(3).Value) * CDbl(DgvDetalle.Rows(e.RowIndex).Cells(4).Value), 2)
            If DgvDetalle.CurrentRow.Cells(3).Value = Nothing Or DgvDetalle.CurrentRow.Cells(3).Value = 0 Then
                DgvDetalle.Rows(e.RowIndex).Cells(3).Value = 1
            End If
            If dr2.Read() Then
                DgvDetalle.Rows(e.RowIndex).Cells(5).Value = FormatCurrency(CDbl(DgvDetalle.Rows(e.RowIndex).Cells(3).Value) * CDbl(dr2.GetValue(0)), 2)
            End If
            DgvDetalle.Rows(e.RowIndex).Cells(6).Value = FormatCurrency(CDbl(DgvDetalle.Rows(e.RowIndex).Cells(3).Value) * CDbl(DgvDetalle.Rows(e.RowIndex).Cells(4).Value), 2)

        ElseIf column = 4 Then
            Conec.Conectarse()
            Dim dr2 As SqlDataReader

            cmd = New SqlCommand("Select Costo from Producto Where IdProducto='" & DgvDetalle.Rows(e.RowIndex).Cells(1).Value & "'")
            cmd.CommandType = CommandType.Text
            cmd.Connection = Conec.Con
            dr2 = cmd.ExecuteReader




            If DgvDetalle.CurrentRow.Cells(4).Value = Nothing Or DgvDetalle.CurrentRow.Cells(4).Value = 0 Then
                If dr2.Read() Then
                    DgvDetalle.Rows(e.RowIndex).Cells(4).Value = FormatCurrency(CDbl(dr2.GetValue(0)), 2)
                End If
            End If
            DgvDetalle.Rows(e.RowIndex).Cells(6).Value = FormatCurrency(CDbl(DgvDetalle.Rows(e.RowIndex).Cells(3).Value) * CDbl(DgvDetalle.Rows(e.RowIndex).Cells(4).Value), 2)
        End If
        LlenarTextBox()

    End Sub
    Private Sub DataGridView1_EditingControlShowing(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewEditingControlShowingEventArgs) Handles DgvDetalle.EditingControlShowing
        Dim column As Integer = DgvDetalle.CurrentCell.ColumnIndex
        If column = 1 Then

            Dim autoText As TextBox = TryCast(e.Control, TextBox)
            If autoText IsNot Nothing Then
                autoText.AutoCompleteMode = AutoCompleteMode.SuggestAppend
                autoText.AutoCompleteSource = AutoCompleteSource.CustomSource
                Dim DataCollection As New AutoCompleteStringCollection()
                addItems(DataCollection)
                autoText.AutoCompleteCustomSource = DataCollection
                If DgvDetalle.CurrentRow.Cells(1).Value = Nothing Then
                    DgvDetalle.CurrentRow.Cells(1).ErrorText = "Ingrese el Código del Producto"
                Else
                    DgvDetalle.CurrentRow.Cells(1).ErrorText = ""
                End If

            End If
        ElseIf column = 2 Then

            Dim autoText2 As TextBox = TryCast(e.Control, TextBox)
            If autoText2 IsNot Nothing Then
                autoText2.AutoCompleteMode = AutoCompleteMode.SuggestAppend
                autoText2.AutoCompleteSource = AutoCompleteSource.CustomSource
                Dim DataCollection2 As New AutoCompleteStringCollection()
                addItems2(DataCollection2)
                autoText2.AutoCompleteCustomSource = DataCollection2


                If DgvDetalle.CurrentRow.Cells(2).Value = Nothing Then
                    DgvDetalle.CurrentRow.Cells(2).ErrorText = "Ingrese el Nombre del Producto"
                Else
                    DgvDetalle.CurrentRow.Cells(2).ErrorText = ""

                End If
            End If

        Else
            Dim autoText As TextBox = TryCast(e.Control, TextBox)
            autoText.AutoCompleteMode = AutoCompleteMode.None
        End If



    End Sub
    Public Sub addItems(ByVal col As AutoCompleteStringCollection)
        Try
            Conec.Conectarse()

            Dim dr As SqlDataReader
            cmd = New SqlCommand("Select  IdProducto+'/'+ Descripcion from Producto")
            cmd.CommandType = CommandType.Text
            cmd.Connection = Conec.Con
            dr = cmd.ExecuteReader

            If dr.HasRows Then
                While dr.Read
                    col.Add(Convert.ToString(dr(0)))
                End While

            End If
            dr.Close()


        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            Conec.Desconectarse()
        End Try
    End Sub
    Public Sub addItems2(ByVal col As AutoCompleteStringCollection)
        Try
            Conec.Conectarse()

            Dim dr As SqlDataReader
            cmd = New SqlCommand("Select  Descripcion+'/'+ IdProducto from Producto")
            cmd.CommandType = CommandType.Text
            cmd.Connection = Conec.Con
            dr = cmd.ExecuteReader

            If dr.HasRows Then
                While dr.Read
                    col.Add(Convert.ToString(dr(0)))
                End While

            End If
            dr.Close()


        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            Conec.Desconectarse()
        End Try
    End Sub
    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DgvDetalle.CellContentClick
        If e.ColumnIndex = 0 Then
            If (DgvDetalle.CurrentRow.Cells(1).Value <> Nothing And (DgvDetalle.CurrentRow.Cells(2).Value <> Nothing)) Then
                If ((DgvDetalle.CurrentRow.Cells(1) IsNot Nothing)) Then
                    If DgvDetalle.CurrentCell.Value <> Nothing Then

                        DgvDetalle.Rows.Remove(DgvDetalle.CurrentRow)
                        LlenarTextBox()

                    Else
                        DgvDetalle.Rows.Remove(DgvDetalle.CurrentRow)
                        LlenarTextBox()

                    End If
                Else
                    DgvDetalle.Rows.Remove(DgvDetalle.CurrentRow)
                    LlenarTextBox()
                End If
            Else
                Dim a, b As Integer
                a = DgvDetalle.Rows.Count
                b = e.RowIndex + 1

                If a = b Then
                Else
                    DgvDetalle.Rows.Remove(DgvDetalle.CurrentRow)
                    LlenarTextBox()
                End If

            End If

        End If

    End Sub
    Private Sub LlenarTextBox()
        TxtTotal.Clear()
        TxtTotal.Text = 0
        TxtSubtotal.Clear()
        TxtSubtotal.Text = 0
        TxtDescuento.Clear()
        TxtDescuento.Text = 0
        TxtImpuesto.Clear()
        TxtImpuesto.Text = 0

        Dim a, b, c, d As Double
        For Each Fila As DataGridViewRow In DgvDetalle.Rows
            a += CDbl(Fila.Cells(6).Value)

            c += CDbl(Fila.Cells(5).Value)

        Next
        TxtSubtotal.Text = FormatCurrency(a, 2)
        If RdbPorcentaje.Checked = True Then
            Dim q, w As Double
            If TxtP.Text = Nothing Then
                q = 0
            Else

                q = CDbl(TxtP.Text)
            End If

            w = CDbl(TxtSubtotal.Text)
            TxtDescuentoExtra.Value = (q / 100) * w
        End If

        If TxtDescuentoExtra.Text = Nothing Then
            d = 0
        Else
            d = CDbl(TxtDescuentoExtra.Text)
        End If


        TxtDescuento.Text = FormatCurrency(d, 2)
        TxtTotal.Text = FormatCurrency((a + c) - (d), 2)
        TxtImpuesto.Text = FormatCurrency(c, 2)



    End Sub

    Private Sub TxtDescuentoExtra_EditValueChanged(sender As Object, e As EventArgs) Handles TxtDescuentoExtra.EditValueChanged
        LlenarTextBox()
    End Sub

    Private Sub RdbPorcentaje_CheckedChanged(sender As Object, e As EventArgs) Handles RdbPorcentaje.CheckedChanged
        If RdbPorcentaje.Checked = True Then
            TxtP.Visible = True
            LblP.Visible = True
            TxtDescuentoExtra.Enabled = False
            TxtDescuentoExtra.Text = 0
        Else
            TxtP.Visible = False
            LblP.Visible = False
            TxtDescuentoExtra.Enabled = True
            TxtDescuentoExtra.Text = 0
        End If
    End Sub

    Private Sub TxtP_TextChanged(sender As Object, e As EventArgs) Handles TxtP.TextChanged
        Dim a, b As Double
        If TxtP.Text = Nothing Then
            a = 0
        Else

            a = CDbl(TxtP.Text)
        End If
        If TxtSubtotal.Text <> Nothing Then
            b = CDbl(TxtSubtotal.Text)
        End If

        TxtDescuentoExtra.Value = (a / 100) * b

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles BtnFacturar.Click




        If DgvDetalle.RowCount = 1 Then
                MsgBox("Ingresar al menos un producto para realizar la compra", MsgBoxStyle.Information, "INNOVAMASTER")

            Else
            If GuardarCompra() = True Then
                Conec.Conectarse()


                For Each fila As DataGridViewRow In DgvDetalle.Rows
                    Try
                        If fila.Cells(1).Value <> Nothing Then


                            cmd = New SqlCommand("ActualizarPrecioCosto", Conec.Con)
                            cmd.CommandType = CommandType.StoredProcedure
                            cmd.Parameters.AddWithValue("@IdProducto", fila.Cells(1).Value.ToString)
                            cmd.Parameters.AddWithValue("@Costo", CDbl(fila.Cells(4).Value))
                            cmd.ExecuteNonQuery()
                        End If

                    Catch ex As Exception
                        MsgBox(ex.Message)
                    End Try
                Next

                For Each fila As DataGridViewRow In DgvDetalle.Rows
                    Try
                        If fila.Cells(1).Value <> Nothing Then


                            cmd = New SqlCommand("AumentarInventario", Conec.Con)
                            cmd.CommandType = CommandType.StoredProcedure
                            cmd.Parameters.AddWithValue("@IdProducto", fila.Cells(1).Value.ToString)
                            cmd.Parameters.AddWithValue("@Cantidad", CDbl(fila.Cells(3).Value))
                            cmd.ExecuteNonQuery()
                        End If

                    Catch ex As Exception
                        MsgBox(ex.Message)
                    End Try


                Next
                Dim a As Integer
                Try
                    cmd = New SqlCommand("Select Top 1 IdCompra From Compra Order by IdCompra Desc")
                    cmd.CommandType = CommandType.Text
                    cmd.Connection = Conec.Con
                    a = cmd.ExecuteScalar
                Catch ex As Exception
                    MsgBox(ex.Message)
                End Try
                LblId.Text = a

                For Each fila As DataGridViewRow In DgvDetalle.Rows
                    Try
                        If fila.Cells(1).Value <> Nothing Then


                            cmd = New SqlCommand("InsertarDetalleCompra", Conec.Con)
                            cmd.CommandType = CommandType.StoredProcedure
                            cmd.Parameters.AddWithValue("@IdCompra", CInt(a))
                            cmd.Parameters.AddWithValue("@IdProducto", fila.Cells(1).Value.ToString)
                            cmd.Parameters.AddWithValue("@CantidadCompra", CDbl(fila.Cells(3).Value))
                            cmd.Parameters.AddWithValue("@ImpuestoCompra", CDbl(fila.Cells(5).Value))
                            cmd.Parameters.AddWithValue("@PrecioCompra", CDbl(fila.Cells(4).Value))
                            cmd.ExecuteNonQuery()
                        End If

                    Catch ex As Exception
                        MsgBox(ex.Message)
                    End Try


                Next
                MsgBox("Compra realizada correctamente", MsgBoxStyle.Information, "INNOVAMASTER")
                var = 0
                If MessageBox.Show("¿Desea imprimir el reporte de la compra", "INNOVAMASTER", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) = DialogResult.Yes Then
                    If MessageBox.Show("¿Desea visualizar el reporte", "INNOVAMASTER", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) = DialogResult.Yes Then

                        FrmRptCompra.var = 2
                        FrmRptCompra.ShowDialog()
                    Else
                        Dim ds As New DsReportes
                        Dim rpt As New RptCompra
                        Try

                            Conec.Conectarse()
                            Dim cmd As New SqlCommand
                            cmd = New SqlCommand("ReporteCompra", Conec.Con)
                            cmd.CommandType = CommandType.StoredProcedure
                            cmd.Parameters.Add("@IdCompra", SqlDbType.Int).Value = CInt(LblId.Text)
                            cmd.ExecuteNonQuery()
                            Dim da As New SqlDataAdapter(cmd)
                            da.Fill(ds, "ReporteCompra")
                            rpt.SetDataSource(ds)
                            rpt.PrintToPrinter(1, False, 0, 0)
                        Catch ex As Exception

                        End Try
                        var = 0
                        Me.Close()

                    End If
                Else
                    var = 0
                    Close()
                End If

            End If
        End If

    End Sub

    Private Sub FrmDetalleVenta_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        DgvDetalle.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Sunken
        TxtDescuentoExtra.Value = 0
        TxtFechaCompra.Text = DateTime.Now.ToString("dd/MM/yyyy")
        TxtDescuentoExtra.Text = Nothing

    End Sub




    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles Button1.Click
        Dim r As DialogResult = MessageBox.Show("¿Desea Cancelar la Compra?", "INNOVAMASTER", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If r = DialogResult.Yes Then

            If s = 1 Then
                Conec.Conectarse()
                Dim a As Integer

                cmd = New SqlCommand("Select Top 1 IdCompra From Compra Order by IdCompra Desc")
                cmd.CommandType = CommandType.Text
                cmd.Connection = Conec.Con
                a = cmd.ExecuteScalar
                Try
                    cmd = New SqlCommand("Delete From Compra Where IdCompra= " & a & "")
                    cmd.CommandType = CommandType.Text
                    cmd.Connection = Conec.Con
                    cmd.ExecuteNonQuery()
                Catch ex As Exception
                    MsgBox(ex.Message)
                End Try
            End If
            var = 0
            Me.Close()

        End If



    End Sub



    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim r As DialogResult = MessageBox.Show("¿Desea Eliminar Todos los Productos de la Compra?", "INNOVAMASTER", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If r = DialogResult.Yes Then
            LlenarTextBox()
            DgvDetalle.Rows.Clear()
        End If
    End Sub





    Private Function GuardarCompra() As Boolean
        Dim estado As Boolean
        If TxtTotal.Text = Nothing Then
            estado = False
        Else
            Conec.Conectarse()

            Using cmd As New SqlCommand
                Try
                    With cmd
                        .CommandText = "InsertarCompra"
                        .CommandType = CommandType.StoredProcedure
                        .Connection = Conec.Con
                        .Parameters.Add("@Descuento", SqlDbType.Money).Value = CDbl(TxtDescuento.Text)
                        .Parameters.Add("@IdUsuario", SqlDbType.Int).Value = CInt(MenuPrincipal.LblIdUsuario.Text)
                        .Parameters.Add("@FechaCompra", SqlDbType.Date).Value = TxtFechaCompra.Text
                        .ExecuteNonQuery()
                    End With
                    estado = True
                    s = 1
                Catch ex As Exception
                    MsgBox(ex.Message)
                    estado = False
                End Try
            End Using

        End If
        Return estado
    End Function

    Private Sub FrmCompras_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
        If var = 0 Then

        Else
            Dim r As DialogResult = MessageBox.Show("¿Desea Cancelar la Compra?", "INNOVAMASTER", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
            If r = DialogResult.Yes Then
                If s = 1 Then
                    Conec.Conectarse()
                    Dim a As Integer

                    cmd = New SqlCommand("Select Top 1 IdCompra From Compra Order by IdCompra Desc")
                    cmd.CommandType = CommandType.Text
                    cmd.Connection = Conec.Con
                    a = cmd.ExecuteScalar
                    Try
                        cmd = New SqlCommand("Delete From Compra Where IdCompra= " & a & "")
                        cmd.CommandType = CommandType.Text
                        cmd.Connection = Conec.Con
                        cmd.ExecuteNonQuery()
                    Catch ex As Exception
                        MsgBox(ex.Message)
                    End Try
                End If
            Else
                e.Cancel = True
            End If
        End If

    End Sub
End Class