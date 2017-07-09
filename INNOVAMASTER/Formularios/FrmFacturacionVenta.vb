Imports System.ComponentModel
Imports System.Data.SqlClient
Public Class FrmFacturacionVenta
    Dim Conec As New Conexion
    Dim cmd As SqlCommand
    Dim x As Integer = 0

    Private Sub DataGridView1_CellEndEdit(sender As Object, e As DataGridViewCellEventArgs) Handles DgvDetalle.CellEndEdit
        Dim column As Integer = DgvDetalle.CurrentCell.ColumnIndex
        If column = 1 Then
            If CboFormaVenta.SelectedItem <> Nothing Then

                Try
                    If DgvDetalle.Rows(e.RowIndex).Cells(1).Value <> Nothing Then

                        Conec.Conectarse()
                        Dim c As String = DgvDetalle.Rows(e.RowIndex).Cells(1).Value.ToString
                        Dim c2 As String() = c.Split("/")
                        DgvDetalle.Rows(e.RowIndex).Cells(1).Value = c2(0).ToString

                        Dim dr As SqlDataReader
                        cmd = New SqlCommand("Select Descripcion,Gravado,Gravado,PrecioUnitario, PrecioMayorista, Existencia, Estado from Producto Where IdProducto='" & DgvDetalle.Rows(e.RowIndex).Cells(1).Value & "'")
                        cmd.CommandType = CommandType.Text
                        cmd.Connection = Conec.Con
                        dr = cmd.ExecuteReader

                        If dr.Read Then
                            If dr.GetValue(6).ToString = "Activo" Then
                                DgvDetalle.Rows(e.RowIndex).Cells(2).Value = dr(0).ToString

                                Dim ex As Integer
                                ex = CInt(dr.GetValue(5)) - 5
                                If ex = 0 Then
                                    MsgBox("No hay existencia de ese producto", MsgBoxStyle.Critical)
                                    DgvDetalle.Rows.Remove(DgvDetalle.CurrentRow)
                                    LlenarTextBox()
                                Else
                                    DgvDetalle.Rows(e.RowIndex).Cells(3).Value = 1
                                    If CboFormaVenta.SelectedItem = "Mayoreo" Then
                                        DgvDetalle.Rows(e.RowIndex).Cells(4).Value = FormatCurrency(CDbl(dr(4)))
                                    Else
                                        DgvDetalle.Rows(e.RowIndex).Cells(4).Value = FormatCurrency(CDbl(dr(3)))
                                    End If

                                    DgvDetalle.Rows(e.RowIndex).Cells(5).Value = 0
                                    DgvDetalle.Rows(e.RowIndex).Cells(6).Value = FormatCurrency(0)
                                    DgvDetalle.Rows(e.RowIndex).Cells(7).Value = FormatCurrency(CDbl(dr.GetValue(1)), 2)
                                    DgvDetalle.Rows(e.RowIndex).Cells(8).Value = FormatCurrency((DgvDetalle.Rows(e.RowIndex).Cells(3).Value) * CDbl(DgvDetalle.Rows(e.RowIndex).Cells(4).Value), 2)
                                    dr.Close()
                                    DgvDetalle.CurrentRow.Cells(1).ErrorText = ""
                                    DgvDetalle.CurrentRow.Cells(2).ErrorText = ""
                                    cmd = New SqlCommand("ReducirInventario", Conec.Con)
                                    cmd.CommandType = CommandType.StoredProcedure
                                    cmd.Parameters.AddWithValue("@IdProducto", DgvDetalle.Rows(e.RowIndex).Cells(1).Value.ToString)
                                    cmd.Parameters.AddWithValue("@Cantidad", CDbl(DgvDetalle.Rows(e.RowIndex).Cells(3).Value))
                                    cmd.ExecuteNonQuery()
                                    DgvDetalle.CurrentRow.Cells(1).ReadOnly = True
                                    DgvDetalle.CurrentRow.Cells(2).ReadOnly = True

                                End If
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
                        Dim a, b As Integer
                        a = DgvDetalle.Rows.Count
                        b = e.RowIndex + 1

                        If a = b Then
                        Else
                            DgvDetalle.Rows.Remove(DgvDetalle.CurrentRow)
                            LlenarTextBox()
                        End If
                    End If

                Catch ex As Exception
                    MsgBox(ex.ToString)
                Finally
                    Conec.Desconectarse()

                End Try
            Else
                MsgBox("Seleccione la Forma de Venta", MsgBoxStyle.Information, "INNOVAMASTER")
                Dim a, b As Integer
                a = DgvDetalle.Rows.Count
                b = e.RowIndex + 1

                If a = b Then
                Else
                    DgvDetalle.Rows.Remove(DgvDetalle.CurrentRow)
                    LlenarTextBox()
                End If

            End If

        ElseIf column = 2 Then
            If CboFormaVenta.SelectedItem <> Nothing Then

                Try
                    If DgvDetalle.Rows(e.RowIndex).Cells(2).Value <> Nothing Then

                        Conec.Conectarse()
                        Dim c As String = DgvDetalle.Rows(e.RowIndex).Cells(2).Value.ToString

                        Dim c2 As String() = c.Split("/")
                        DgvDetalle.Rows(e.RowIndex).Cells(1).Value = c2(1).ToString
                        DgvDetalle.Rows(e.RowIndex).Cells(2).Value = c2(0).ToString


                        Dim dr As SqlDataReader
                        cmd = New SqlCommand("Select IdProducto,Gravado,Gravado,PrecioUnitario, PrecioMayorista, Existencia, Estado from Producto Where IdProducto='" & DgvDetalle.Rows(e.RowIndex).Cells(1).Value & "'")
                        cmd.CommandType = CommandType.Text
                        cmd.Connection = Conec.Con
                        dr = cmd.ExecuteReader

                        If dr.Read Then
                            If dr.GetValue(6).ToString = "Activo" Then



                                Dim ex As Integer
                                ex = CInt(dr.GetValue(5)) - 5
                                If ex = 0 Then
                                    MsgBox("No hay existencia de ese producto", MsgBoxStyle.Critical)
                                    DgvDetalle.Rows.Remove(DgvDetalle.CurrentRow)
                                    LlenarTextBox()
                                Else
                                    DgvDetalle.Rows(e.RowIndex).Cells(3).Value = 1
                                    If CboFormaVenta.Text = "Mayoreo" Then
                                        DgvDetalle.Rows(e.RowIndex).Cells(4).Value = FormatCurrency(CDbl(dr(4)))
                                    Else
                                        DgvDetalle.Rows(e.RowIndex).Cells(4).Value = FormatCurrency(CDbl(dr(3)))
                                    End If

                                    DgvDetalle.Rows(e.RowIndex).Cells(5).Value = 0
                                    DgvDetalle.Rows(e.RowIndex).Cells(6).Value = FormatCurrency(0)
                                    DgvDetalle.Rows(e.RowIndex).Cells(7).Value = FormatCurrency(CDbl(dr.GetValue(1)), 2)
                                    DgvDetalle.Rows(e.RowIndex).Cells(8).Value = FormatCurrency((DgvDetalle.Rows(e.RowIndex).Cells(3).Value) * CDbl(DgvDetalle.Rows(e.RowIndex).Cells(4).Value), 2)
                                    DgvDetalle.CurrentRow.Cells(1).ErrorText = ""
                                    DgvDetalle.CurrentRow.Cells(2).ErrorText = ""
                                    dr.Close()
                                    cmd = New SqlCommand("ReducirInventario", Conec.Con)
                                    cmd.CommandType = CommandType.StoredProcedure
                                    cmd.Parameters.AddWithValue("@IdProducto", DgvDetalle.Rows(e.RowIndex).Cells(1).Value.ToString)
                                    cmd.Parameters.AddWithValue("@Cantidad", CDbl(DgvDetalle.Rows(e.RowIndex).Cells(3).Value))
                                    cmd.ExecuteNonQuery()
                                    DgvDetalle.CurrentRow.Cells(1).ReadOnly = True
                                    DgvDetalle.CurrentRow.Cells(2).ReadOnly = True

                                End If
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
                        Dim a, b As Integer
                        a = DgvDetalle.Rows.Count
                        b = e.RowIndex + 1

                        If a = b Then
                        Else
                            DgvDetalle.Rows.Remove(DgvDetalle.CurrentRow)
                            LlenarTextBox()
                        End If
                    End If

                Catch ex As Exception
                    DgvDetalle.Rows(e.RowIndex).Cells(1).Value = Nothing
                    DgvDetalle.Rows(e.RowIndex).Cells(2).Value = Nothing
                    MsgBox("Producto no registrado", MsgBoxStyle.Information)
                    DgvDetalle.Rows.Remove(DgvDetalle.CurrentRow)

                Finally
                    Conec.Desconectarse()
                End Try
            Else




                MsgBox("Seleccione la Forma de Venta", MsgBoxStyle.Information, "INNOVAMASTER")
                Dim a, b As Integer
                a = DgvDetalle.Rows.Count
                b = e.RowIndex + 1

                If a = b Then
                Else
                    DgvDetalle.Rows.Remove(DgvDetalle.CurrentRow)
                    LlenarTextBox()
                End If


            End If
        ElseIf column = 3 Then
            Conec.Conectarse()
            Dim dr2 As SqlDataReader

            cmd = New SqlCommand("Select Gravado from Producto Where IdProducto='" & DgvDetalle.Rows(e.RowIndex).Cells(1).Value & "'")
            cmd.CommandType = CommandType.Text
            cmd.Connection = Conec.Con
            dr2 = cmd.ExecuteReader
            If dr2.Read() Then
                DgvDetalle.Rows(e.RowIndex).Cells(7).Value = FormatCurrency(CDbl(DgvDetalle.Rows(e.RowIndex).Cells(3).Value) * CDbl(dr2.GetValue(0)), 2)
            End If


            DgvDetalle.Rows(e.RowIndex).Cells(8).Value = FormatCurrency(CDbl(DgvDetalle.Rows(e.RowIndex).Cells(3).Value) * CDbl(DgvDetalle.Rows(e.RowIndex).Cells(4).Value), 2)
            If DgvDetalle.CurrentRow.Cells(3).Value = Nothing Or DgvDetalle.CurrentRow.Cells(3).Value = 0 Then
                DgvDetalle.Rows(e.RowIndex).Cells(3).Value = 1

            End If
            Conec.Conectarse()
            Dim dr As SqlDataReader
            cmd = New SqlCommand("Select Existencia from Producto Where IdProducto='" & DgvDetalle.Rows(e.RowIndex).Cells(1).Value & "'", Conec.Con)
            cmd.CommandType = CommandType.Text
            dr = cmd.ExecuteReader
            Dim existencia, existencia2 As Integer

            If dr.Read Then
                existencia = CInt(dr.GetValue(0)) - 5
                existencia2 = CInt(dr.GetValue(0)) - 10
                If (DgvDetalle.Rows(e.RowIndex).Cells(3).Value - CDbl(LblCant.Text)) > existencia Then
                    MsgBox("Se sobrepasa de la existencia estimada. Existencia= " + Str(existencia + CDbl(LblCant.Text)), MsgBoxStyle.Critical)
                    DgvDetalle.Rows(e.RowIndex).Cells(3).Value = existencia + CDbl(LblCant.Text)

                ElseIf DgvDetalle.Rows(e.RowIndex).Cells(3).Value > existencia2 Then

                    MsgBox("Advertencia. Hay poca existencia", MsgBoxStyle.Information)
                    DgvDetalle.Rows(e.RowIndex).Cells(3).Value = DgvDetalle.Rows(e.RowIndex).Cells(3).Value
                Else
                    DgvDetalle.Rows(e.RowIndex).Cells(3).Value = DgvDetalle.Rows(e.RowIndex).Cells(3).Value
                End If

            End If
            dr.Close()

            DgvDetalle.Rows(e.RowIndex).Cells(8).Value = FormatCurrency(CDbl(DgvDetalle.Rows(e.RowIndex).Cells(3).Value) * CDbl(DgvDetalle.Rows(e.RowIndex).Cells(4).Value), 2)
            DgvDetalle.Rows(e.RowIndex).Cells(7).Value = FormatCurrency(CDbl(DgvDetalle.Rows(e.RowIndex).Cells(3).Value) * CDbl(dr2.GetValue(0)), 2)
            dr2.Close()
            DgvDetalle.Rows(e.RowIndex).Cells(6).Value = FormatCurrency((DgvDetalle.Rows(e.RowIndex).Cells(5).Value / 100) * DgvDetalle.CurrentRow.Cells(8).Value)

            If DgvDetalle.CurrentRow.Cells(3).Value = CDbl(LblCant.Text) Then
            ElseIf DgvDetalle.CurrentRow.Cells(3).Value > CDbl(LblCant.Text) Then
                Dim cant As Double = CDbl(LblCant.Text)
                cmd = New SqlCommand("ReducirInventario", Conec.Con)
                cmd.CommandType = CommandType.StoredProcedure
                cmd.Parameters.AddWithValue("@IdProducto", DgvDetalle.Rows(e.RowIndex).Cells(1).Value.ToString)
                cmd.Parameters.AddWithValue("@Cantidad", CDbl(DgvDetalle.Rows(e.RowIndex).Cells(3).Value) - cant)
                cmd.ExecuteNonQuery()
            ElseIf DgvDetalle.CurrentRow.Cells(3).Value < CDbl(LblCant.Text) Then
                Dim cant As Double = CDbl(LblCant.Text)
                cmd = New SqlCommand("AumentarInventario", Conec.Con)
                cmd.CommandType = CommandType.StoredProcedure
                cmd.Parameters.AddWithValue("@IdProducto", DgvDetalle.Rows(e.RowIndex).Cells(1).Value.ToString)
                cmd.Parameters.AddWithValue("@Cantidad", cant - CDbl(DgvDetalle.Rows(e.RowIndex).Cells(3).Value))
                cmd.ExecuteNonQuery()

            End If
        ElseIf column = 5 Then
            If DgvDetalle.CurrentRow.Cells(5).Value = Nothing Then
                DgvDetalle.Rows(e.RowIndex).Cells(5).Value = 0
            End If
            DgvDetalle.Rows(e.RowIndex).Cells(6).Value = FormatCurrency((DgvDetalle.Rows(e.RowIndex).Cells(5).Value / 100) * DgvDetalle.CurrentRow.Cells(8).Value)

        ElseIf column = 6 Then
            If DgvDetalle.CurrentRow.Cells(6).Value = Nothing Then
                DgvDetalle.Rows(e.RowIndex).Cells(6).Value = FormatCurrency(0)
            End If
            DgvDetalle.Rows(e.RowIndex).Cells(5).Value = FormatNumber(((DgvDetalle.CurrentRow.Cells(6).Value / DgvDetalle.CurrentRow.Cells(8).Value) * 100), 2)
            DgvDetalle.Rows(e.RowIndex).Cells(6).Value = FormatCurrency(DgvDetalle.Rows(e.RowIndex).Cells(6).Value)


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
                        Conec.Conectarse()
                        cmd = New SqlCommand("AumentarInventario", Conec.Con)
                        cmd.CommandType = CommandType.StoredProcedure
                        cmd.Parameters.AddWithValue("@IdProducto", DgvDetalle.Rows(e.RowIndex).Cells(1).Value.ToString)
                        cmd.Parameters.AddWithValue("@Cantidad", CDbl(DgvDetalle.Rows(e.RowIndex).Cells(3).Value))
                        cmd.ExecuteNonQuery()
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
            a += CDbl(Fila.Cells(8).Value)
            b += CDbl(Fila.Cells(7).Value)
            c += CDbl(Fila.Cells(6).Value)

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


        TxtDescuento.Text = FormatCurrency(c + d, 2)
        TxtTotal.Text = FormatCurrency((a + b) - (c + d), 2)
        TxtImpuesto.Text = FormatCurrency(b, 2)



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
        If x = 1 Then
            If DgvDetalle.RowCount = 1 Then
                MsgBox("Ingresar al menos un producto para facturar la venta", MsgBoxStyle.Information, "INNOVAMASTER")

            Else


                Dim re As Object = InputBox("Ingrese el Monto de Pago:", "INNOVAMASTER", "0")
                Dim monto As Double
                If re = vbNullString Then

                    MsgBox("Campo no Valido", MsgBoxStyle.Critical, "INNOVAMASTER")
                    Exit Sub
                ElseIf IsNumeric(re) Then
                    monto = CDbl(re)
                Else

                    MsgBox("Campo no Valido", MsgBoxStyle.Critical, "INNOVAMASTER")
                    Exit Sub
                End If
                If monto < CDbl(TxtTotal.Text) Then

                    MsgBox("El Monto de Pago es muy bajo para Facturar", MsgBoxStyle.Critical, "INNOVAMASTER")
                    Exit Sub
                Else
                    LblCambio.Text = monto - CDbl(TxtTotal.Text)
                End If
                Conec.Conectarse()
                Dim estado As Boolean = True
                DgvDetalle.AllowUserToAddRows = False
                For Each fila As DataGridViewRow In DgvDetalle.Rows
                    Try
                        If fila.Cells(1).Value <> Nothing And fila.Cells(1).ErrorText = "" Then
                            cmd = New SqlCommand("InsertarDetalleVenta", Conec.Con)
                            cmd.CommandType = CommandType.StoredProcedure
                            cmd.Parameters.AddWithValue("@IdVenta", TxtIdVenta.Text.ToString)
                            cmd.Parameters.AddWithValue("@IdProducto", fila.Cells(1).Value.ToString)
                            cmd.Parameters.AddWithValue("@Cantidad", CDbl(fila.Cells(3).Value))
                            cmd.Parameters.AddWithValue("@Precio", CDbl(fila.Cells(4).Value))
                            cmd.Parameters.AddWithValue("@DescuentoProducto", CDbl(fila.Cells(6).Value))
                            cmd.Parameters.AddWithValue("@Impuesto", CDbl(fila.Cells(7).Value))
                            cmd.ExecuteNonQuery()

                        Else
                            estado = False
                            fila.Cells(1).ErrorText = "Ingrese el Codigo del Producto"
                        End If

                    Catch ex As Exception
                        MsgBox(ex.Message)
                    End Try


                Next
                If estado = True Then

                    Try
                        cmd = New SqlCommand("ActualizarDescuentoExtra", Conec.Con)
                        cmd.CommandType = CommandType.StoredProcedure
                        cmd.Parameters.AddWithValue("@IdVenta", TxtIdVenta.Text.ToString)
                        If TxtDescuentoExtra.Value = Nothing Then
                            cmd.Parameters.AddWithValue("@DescuentoExtra", CDbl(0))
                        Else
                            cmd.Parameters.AddWithValue("@DescuentoExtra", CDbl(TxtDescuentoExtra.Value))
                        End If

                        cmd.ExecuteNonQuery()

                    Catch ex As Exception
                        MsgBox(ex.Message)
                    End Try
                    Label7.Text = "1"

                    MsgBox("Productos facturados con éxito, Vamos a Imprimir la Factura", MsgBoxStyle.Information)
                    Dim r As DialogResult = MessageBox.Show("¿Desea Visualizar la Factura", "INNOVAMASTER", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
                    If r = DialogResult.Yes Then
                        FrmFactura.var = 1
                        EditarCambio(CDbl(LblCambio.Text))
                        FrmFactura.ShowDialog()
                    Else
                        Dim ds As New DsReportes
                        Dim rpt As New ReporteVenta
                        Try
                            EditarCambio(CDbl(LblCambio.Text))
                            Conec.Conectarse()
                            cmd = New SqlCommand("ReporteVenta", Conec.Con)
                            cmd.CommandType = CommandType.StoredProcedure
                            cmd.Parameters.Add("@IdVenta", SqlDbType.NVarChar, 50).Value = TxtIdVenta.Text
                            cmd.ExecuteNonQuery()
                            Dim da As New SqlDataAdapter(cmd)
                            da.Fill(ds, "ReporteVenta")
                            rpt.SetDataSource(ds)
                            rpt.SetParameterValue("Cambio", LblCambio.Text)
                            rpt.PrintToPrinter(1, False, 0, 0)
                            Me.Close()
                        Catch ex As Exception

                        End Try

                    End If



                Else

                    DgvDetalle.AllowUserToAddRows = True
                    MsgBox("Tiene que Ingresar algunos Códigos de Producto", MsgBoxStyle.Critical, "INNOVAMASTER")

                End If





            End If
            Exit Sub
        End If
        If GuardarVenta() = True Then
            x = 1

            If DgvDetalle.RowCount = 1 Then
                MsgBox("Ingresar al menos un producto para facturar la venta", MsgBoxStyle.Information, "INNOVAMASTER")

            Else
                If EditarVenta() = True Then

                    Dim re As Object = InputBox("Ingrese el Monto de Pago:", "INNOVAMASTER", "0")
                    Dim monto As Double
                    If re = vbNullString Then

                        MsgBox("Campo no Valido", MsgBoxStyle.Critical, "INNOVAMASTER")
                        Exit Sub
                    ElseIf IsNumeric(re) Then
                        monto = CDbl(re)
                    Else

                        MsgBox("Campo no Valido", MsgBoxStyle.Critical, "INNOVAMASTER")
                        Exit Sub
                    End If
                    If monto < CDbl(TxtTotal.Text) Then

                        MsgBox("El Monto de Pago es muy bajo para Facturar", MsgBoxStyle.Critical, "INNOVAMASTER")
                        Exit Sub
                    Else
                        LblCambio.Text = monto - CDbl(TxtTotal.Text)
                    End If
                    Conec.Conectarse()
                    Dim estado As Boolean = True
                    DgvDetalle.AllowUserToAddRows = False
                    For Each fila As DataGridViewRow In DgvDetalle.Rows
                        Try
                            If fila.Cells(1).Value <> Nothing And fila.Cells(1).ErrorText = "" Then
                                cmd = New SqlCommand("InsertarDetalleVenta", Conec.Con)
                                cmd.CommandType = CommandType.StoredProcedure
                                cmd.Parameters.AddWithValue("@IdVenta", TxtIdVenta.Text.ToString)
                                cmd.Parameters.AddWithValue("@IdProducto", fila.Cells(1).Value.ToString)
                                cmd.Parameters.AddWithValue("@Cantidad", CDbl(fila.Cells(3).Value))
                                cmd.Parameters.AddWithValue("@Precio", CDbl(fila.Cells(4).Value))
                                cmd.Parameters.AddWithValue("@DescuentoProducto", CDbl(fila.Cells(6).Value))
                                cmd.Parameters.AddWithValue("@Impuesto", CDbl(fila.Cells(7).Value))
                                cmd.ExecuteNonQuery()

                            Else
                                estado = False
                                fila.Cells(1).ErrorText = "Ingrese el Codigo del Producto"
                            End If

                        Catch ex As Exception
                            MsgBox(ex.Message)
                        End Try


                    Next
                    If estado = True Then

                        Try
                            cmd = New SqlCommand("ActualizarDescuentoExtra", Conec.Con)
                            cmd.CommandType = CommandType.StoredProcedure
                            cmd.Parameters.AddWithValue("@IdVenta", TxtIdVenta.Text.ToString)
                            If TxtDescuentoExtra.Value = Nothing Then
                                cmd.Parameters.AddWithValue("@DescuentoExtra", CDbl(0))
                            Else
                                cmd.Parameters.AddWithValue("@DescuentoExtra", CDbl(TxtDescuentoExtra.Value))
                            End If

                            cmd.ExecuteNonQuery()

                        Catch ex As Exception
                            MsgBox(ex.Message)
                        End Try
                        Label7.Text = "1"

                        MsgBox("Productos facturados con éxito, Vamos a Imprimir la Factura", MsgBoxStyle.Information)
                        Dim r As DialogResult = MessageBox.Show("¿Desea Visualizar la Factura", "INNOVAMASTER", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
                        If r = DialogResult.Yes Then
                            FrmFactura.var = 1
                            EditarCambio(CDbl(LblCambio.Text))
                            FrmFactura.ShowDialog()
                        Else
                            Dim ds As New DsReportes
                            Dim rpt As New ReporteVenta
                            Try
                                EditarCambio(CDbl(LblCambio.Text))
                                Conec.Conectarse()
                                cmd = New SqlCommand("ReporteVenta", Conec.Con)
                                cmd.CommandType = CommandType.StoredProcedure
                                cmd.Parameters.Add("@IdVenta", SqlDbType.NVarChar, 50).Value = TxtIdVenta.Text
                                cmd.ExecuteNonQuery()
                                Dim da As New SqlDataAdapter(cmd)
                                da.Fill(ds, "ReporteVenta")
                                rpt.SetDataSource(ds)
                                rpt.SetParameterValue("Cambio", LblCambio.Text)
                                rpt.PrintToPrinter(1, False, 0, 0)
                                Me.Close()
                            Catch ex As Exception

                            End Try

                        End If



                    Else

                        DgvDetalle.AllowUserToAddRows = True
                        MsgBox("Tiene que Ingresar algunos Códigos de Producto", MsgBoxStyle.Critical, "INNOVAMASTER")

                    End If




                End If
            End If
        End If
    End Sub

    Private Sub FrmDetalleVenta_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        DgvDetalle.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Sunken
        TxtDescuentoExtra.Value = 0


        GenerarCodigoVenta()

        TxtFechaVenta.Text = DateTime.Now.ToString("dd/MM/yyyy")
        LlenarIdCliente()

        TxtIdCliente.Clear()
        CboFormaVenta.Text = Nothing
        CboTipoVenta.Text = Nothing
        TxtDescuentoExtra.Text = Nothing

        Dim NombreArchivo As String = HTMLHelpClass.GetLocalHelpFileName("InnovaMasterAyuda2017.chm")
        HelpProvider1.HelpNamespace = NombreArchivo
        HelpProvider1.SetHelpNavigator(Me, HelpNavigator.KeywordIndex)
        HelpProvider1.SetHelpKeyword(Me, "Factura")

    End Sub
    Private Sub LlenarIdCliente()
        Try
            Conec.Conectarse()
            cmd = New SqlCommand("Select IdCliente from Cliente", Conec.Con)
            cmd.CommandType = CommandType.Text
            Dim dr As SqlDataReader
            dr = cmd.ExecuteReader
            If dr.HasRows Then
                While dr.Read
                    TxtIdCliente.AutoCompleteCustomSource.Add(dr.GetValue(0).ToString)
                End While
            End If
            dr.Close()

        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            Conec.Desconectarse()
        End Try
    End Sub
    Private Sub GenerarCodigoVenta()
        Try
            Conec.Conectarse()
            Dim dr As SqlDataReader
            cmd = New SqlCommand("Select Count(*) as Total From Venta", Conec.Con)
            cmd.CommandType = CommandType.Text
            dr = cmd.ExecuteReader

            If dr.Read Then
                If dr.GetValue(0) < 10 Then
                    TxtIdVenta.Text = "00000000" + Str(Int(dr.GetValue(0)) + 1)
                ElseIf dr.GetValue(0) < 100 Then
                    TxtIdVenta.Text = "0000000" + Str(Int(dr.GetValue(0)) + 1)
                ElseIf dr.GetValue(0) < 1000 Then
                    TxtIdVenta.Text = "000000" + Str(Int(dr.GetValue(0)) + 1)
                ElseIf dr.GetValue(0) < 10000 Then
                    TxtIdVenta.Text = "00000" + Str(Int(dr.GetValue(0)) + 1)
                ElseIf dr.GetValue(0) < 100000 Then
                    TxtIdVenta.Text = "0000" + Str(Int(dr.GetValue(0)) + 1)
                ElseIf dr.GetValue(0) < 1000000 Then
                    TxtIdVenta.Text = "000" + Str(Int(dr.GetValue(0)) + 1)
                ElseIf dr.GetValue(0) < 10000000 Then
                    TxtIdVenta.Text = "00" + Str(Int(dr.GetValue(0)) + 1)
                ElseIf dr.GetValue(0) < 100000000 Then
                    TxtIdVenta.Text = "0" + Str(Int(dr.GetValue(0)) + 1)
                End If
            End If
            dr.Close()
            TxtIdVenta.Text = Replace(TxtIdVenta.Text, " ", "")
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub DgvDetalle_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DgvDetalle.CellClick
        If e.ColumnIndex = 3 Then
            LblCant.Text = DgvDetalle.CurrentCell.Value
        ElseIf e.ColumnIndex = 1 Then
            Label10.Text = "1"
        Else
            Label10.Text = "0"
            LblCant.Text = 0
        End If


    End Sub

    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles Button1.Click
        Dim r As DialogResult = MessageBox.Show("¿Desea Cancelar la Venta?", "INNOVAMASTER", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If r = DialogResult.Yes Then

            Conec.Conectarse()
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
            cmd = New SqlCommand("Delete from Venta Where IdVenta= '" & TxtIdVenta.Text & "'", Conec.Con)
            cmd.CommandType = CommandType.Text
            cmd.ExecuteNonQuery()
            Me.Close()

        End If


    End Sub

    Private Sub FrmDetalleVenta_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
        If Label7.Text = "0" Then
            Dim r As DialogResult = MessageBox.Show("¿Desea Cancelar la Venta?", "INNOVAMASTER", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
            If r = DialogResult.Yes Then
                Conec.Conectarse()
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
                cmd = New SqlCommand("Delete from Venta Where IdVenta= '" & TxtIdVenta.Text & "'", Conec.Con)
                cmd.CommandType = CommandType.Text
                cmd.ExecuteNonQuery()
            Else
                e.Cancel = True
            End If



        End If


    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim r As DialogResult = MessageBox.Show("¿Desea Eliminar Todos los Productos de la Venta?", "INNOVAMASTER", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If r = DialogResult.Yes Then
            Conec.Conectarse()
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
            LlenarTextBox()
            DgvDetalle.Rows.Clear()
        End If
    End Sub

    Private Sub TxtIdCliente_TextChanged(sender As Object, e As EventArgs) Handles TxtIdCliente.TextChanged
        Try
            Conec.Conectarse()
            cmd = New SqlCommand("Select NombreCliente, ApellidoCliente from Cliente Where IdCliente= '" & TxtIdCliente.Text & "'", Conec.Con)
            cmd.CommandType = CommandType.Text
            Dim dr As SqlDataReader
            dr = cmd.ExecuteReader
            If dr.Read Then
                LblNombre.Text = dr.GetValue(0).ToString + " " + dr.GetValue(1).ToString
            Else
                LblNombre.Text = "0"
            End If
            If LblNombre.Text = "0" Then
                LblNombre.Text = ""
            End If
            dr.Close()

        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            Conec.Desconectarse()
        End Try
    End Sub

    Private Sub BtnBusquedaCliente_Click(sender As Object, e As EventArgs) Handles BtnBusquedaCliente.Click
        FrmCliente.LblRelacionClienteVenta.Text = "2"
        FrmCliente.MdiParent = MenuPrincipal
        FrmCliente.Dock = DockStyle.Fill
        FrmCliente.Show()
        FrmCliente.Focus()
    End Sub

    Private Function GuardarVenta() As Boolean
        Dim estado As Boolean
        If TxtIdVenta.Text = Nothing Then
            estado = False
        ElseIf TxtIdCliente.Text = Nothing Then
            MsgBox("Ingrese el Código de Cliente", MsgBoxStyle.Critical, "Error")
            estado = False
        ElseIf TxtFechaVenta.Text = Nothing Then
            estado = False
        ElseIf TxtFechaVencimientos.Text = Nothing Then
            MsgBox("Ingrese la Fecha de Vencimiento de la Venta", MsgBoxStyle.Critical, "Error")
            estado = False
        ElseIf CboFormaVenta.Text = Nothing Then
            MsgBox("Seleccione la Forma de la Venta", MsgBoxStyle.Critical, "Error")
            estado = False
        ElseIf CboTipoVenta.Text = Nothing Then
            MsgBox("Seleccione el Tipo de Venta", MsgBoxStyle.Critical, "Error")
            estado = False
        ElseIf MenuPrincipal.LblIdUsuario.Text = Nothing Then
            estado = False
        ElseIf LblNombre.Text = "0" Then
            MsgBox("El Cliente No esta Registrado", MsgBoxStyle.Critical, "Error")
            estado = False
        Else
            Try
                Dim datos As New DatosVenta
                Dim funcion As New Fventa
                If TxtDescuentoExtra.Value = Nothing Then
                    TxtDescuentoExtra.Value = 0
                End If
                datos.gDescuentoExtra = CDbl(TxtDescuentoExtra.Text)
                datos.gIdVenta = TxtIdVenta.Text
                datos.gIdCliente = TxtIdCliente.Text
                datos.gFechaVenta = TxtFechaVenta.Text
                datos.gFechaVencimiento = TxtFechaVencimientos.Text
                If CboFormaVenta.Text = "Mayoreo" Then
                    datos.gIdFormaVenta = 1
                Else
                    datos.gIdFormaVenta = 2
                End If
                datos.gCambio = 0
                If CboTipoVenta.Text = "Contado" Then
                    datos.gIdTipoVenta = 1
                Else
                    datos.gIdTipoVenta = 2
                End If

                datos.gDescuentoExtra = CDbl(TxtDescuentoExtra.Text)
                datos.gIdUsuario = Int(MenuPrincipal.LblIdUsuario.Text)

                If funcion.InsertarVenta(datos) Then
                    estado = True
                Else
                    estado = False
                End If

            Catch ex As Exception
                MsgBox(ex.ToString)
                estado = False
            Finally
                Conec.Desconectarse()
            End Try

        End If
        Return estado
    End Function
    Private Sub EditarCambio(ByVal Cambio As Double)
        Using cmd As New SqlCommand
            Try
                Conec.Conectarse()
                With cmd
                    .CommandText = "EditarCambio"
                    .CommandType = CommandType.StoredProcedure
                    .Connection = Conec.Con
                    .Parameters.Add("@IdVenta", SqlDbType.NVarChar, 50).Value = TxtIdVenta.Text.Trim
                    .Parameters.Add("@Cambio", SqlDbType.Money).Value = Cambio
                    .ExecuteNonQuery()
                End With

            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        End Using

    End Sub
    Private Function EditarVenta() As Boolean
        Dim estado As Boolean
        If TxtIdVenta.Text = Nothing Then
            estado = False
        ElseIf TxtIdCliente.Text = Nothing Then
            MsgBox("Ingrese el Código de Cliente", MsgBoxStyle.Critical, "Error")
            estado = False
        ElseIf TxtFechaVenta.Text = Nothing Then
            estado = False
        ElseIf TxtFechaVencimientos.Text = Nothing Then
            MsgBox("Ingrese la Fecha de Vencimiento de la Venta", MsgBoxStyle.Critical, "Error")
            estado = False
        ElseIf CboFormaVenta.Text = Nothing Then
            MsgBox("Seleccione la Forma de la Venta", MsgBoxStyle.Critical, "Error")
            estado = False
        ElseIf CboTipoVenta.Text = Nothing Then
            MsgBox("Seleccione el Tipo de Venta", MsgBoxStyle.Critical, "Error")
            estado = False
        ElseIf MenuPrincipal.LblIdUsuario.Text = Nothing Then
            estado = False
        ElseIf LblNombre.Text = "0" Then
            MsgBox("El Cliente No esta Registrado", MsgBoxStyle.Critical, "Error")
            estado = False
        Else
            Try
                Dim datos As New DatosVenta
                Dim funcion As New Fventa
                If TxtDescuentoExtra.Value = Nothing Then
                    TxtDescuentoExtra.Value = 0
                End If
                datos.gDescuentoExtra = CDbl(TxtDescuentoExtra.Text)
                datos.gIdVenta = TxtIdVenta.Text
                datos.gIdCliente = TxtIdCliente.Text
                datos.gFechaVenta = TxtFechaVenta.Text
                datos.gFechaVencimiento = TxtFechaVencimientos.Text
                If CboFormaVenta.Text = "Mayoreo" Then
                    datos.gIdFormaVenta = 1
                Else
                    datos.gIdFormaVenta = 2
                End If

                If CboTipoVenta.Text = "Contado" Then
                    datos.gIdTipoVenta = 1
                Else
                    datos.gIdTipoVenta = 2
                End If

                datos.gDescuentoExtra = CDbl(TxtDescuentoExtra.Text)
                datos.gIdUsuario = Int(MenuPrincipal.LblIdUsuario.Text)

                If funcion.EditarVenta(datos) Then
                    estado = True
                Else
                    estado = False
                End If

            Catch ex As Exception
                MsgBox(ex.ToString)
                estado = False
            Finally
                Conec.Desconectarse()
            End Try

        End If
        Return estado
    End Function

    Private Sub DgvDetalle_CellValueChanged(sender As Object, e As DataGridViewCellEventArgs) Handles DgvDetalle.CellValueChanged

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        TxtFechaVencimientos.Value = DateTime.Now.AddDays(15)
    End Sub

    Private Sub GroupBox1_Enter(sender As Object, e As EventArgs) Handles GroupBox1.Enter

    End Sub

    Private Sub CboFormaVenta_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CboFormaVenta.SelectedIndexChanged

        For Each Fila As DataGridViewRow In DgvDetalle.Rows
            If Fila.Cells(1).Value <> Nothing And Fila.Cells(2).Value <> Nothing And Fila.Cells(1).ErrorText = "" And Fila.Cells(2).ErrorText = "" Then

                Conec.Conectarse()
                Dim dr As SqlDataReader
                cmd = New SqlCommand("Select IdProducto, Gravado, Gravado, PrecioUnitario, PrecioMayorista, Existencia, Estado from Producto Where IdProducto='" & Fila.Cells(1).Value & "'")
                    cmd.CommandType = CommandType.Text
                cmd.Connection = Conec.Con
                dr = cmd.ExecuteReader

                If dr.Read Then



                    If CboFormaVenta.Text = "Mayoreo" Then
                        Fila.Cells(4).Value = FormatCurrency(CDbl(dr(4)))
                    Else
                        Fila.Cells(4).Value = FormatCurrency(CDbl(dr(3)))
                    End If




                    Fila.Cells(8).Value = FormatCurrency((Fila.Cells(3).Value) * CDbl(Fila.Cells(4).Value), 2)

                    Fila.Cells(6).Value = FormatCurrency((Fila.Cells(5).Value / 100) * Fila.Cells(8).Value)
                    Fila.Cells(5).Value = FormatNumber(((Fila.Cells(6).Value / Fila.Cells(8).Value) * 100), 2)

                    Fila.Cells(1).ErrorText = ""
                    Fila.Cells(2).ErrorText = ""
                    dr.Close()
                End If

            End If
        Next
        LlenarTextBox()


    End Sub
End Class