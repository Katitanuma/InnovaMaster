Imports System.Data.SqlClient
Public Class FrmVenta
    Dim dt As New DataTable
    Dim Conec As New Conexion
    Dim cmd As SqlCommand
    Private Sub FrmVenta_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Mostrar()
        BtnInsertar.Visible = False
        BtnCancelar.Visible = False
        BtnEditar.Visible = False
        GbVenta.Enabled = False
        DgvVenta.AlternatingRowsDefaultCellStyle.BackColor = Color.PapayaWhip
        DgvVenta.RowsDefaultCellStyle.BackColor = Color.Honeydew
        DgvVenta.RowsDefaultCellStyle.SelectionBackColor = Color.Coral
    End Sub
    Private Sub Mostrar()
        Try
            Dim funcion As New Fventa
            dt = funcion.MostrarVenta

            If dt.Rows.Count <> 0 Then
                DgvVenta.DataSource = dt
                Label11.Visible = False
                TxtBusqueda.Enabled = True
                CboBusqueda.Enabled = True
            Else
                DgvVenta.DataSource = Nothing
                Label11.Visible = True
                TxtBusqueda.Enabled = False
                CboBusqueda.Enabled = False
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub TxtBusqueda_TextChanged(sender As Object, e As EventArgs) Handles TxtBusqueda.TextChanged

        Dim ds As New DataSet
        ds.Tables.Add(dt.Copy)
        Dim dv As New DataView(ds.Tables(0))

        dv.RowFilter = CboBusqueda.Text & " like '" & TxtBusqueda.Text & "%'"

        If dv.Count <> 0 Then
            Label11.Visible = False
            DgvVenta.DataSource = dv
        Else
            Label11.Visible = True
            DgvVenta.DataSource = Nothing
        End If

    End Sub
    Private Sub BtnNuevo_Click_1(sender As Object, e As EventArgs) Handles BtnNuevo.Click
        GenerarCodigoVenta()

        TxtFechaVenta.Text = DateTime.Now.ToString("dd/MM/yyyy")
        LlenarIdCliente()
        GbVenta.Enabled = True
        BtnNuevo.Visible = False
        BtnInsertar.Visible = True
        BtnCancelar.Visible = True
        BtnEditar.Visible = False
        DgvVenta.Enabled = False
        BtnNuevoEditar.Visible = False
        TxtIdCliente.Clear()
        CboFormaVenta.Text = Nothing
        CboTipoVenta.Text = Nothing
        TxtDescuentoExtra.Text = Nothing
    End Sub
    Private Sub BtnNuevoEditar_Click_1(sender As Object, e As EventArgs) Handles BtnNuevoEditar.Click

        If TxtIdVenta.Text <> Nothing Then
            GbVenta.Enabled = True
            BtnNuevo.Visible = False
            BtnInsertar.Visible = False
            BtnEditar.Visible = True
            BtnNuevoEditar.Visible = False
            BtnCancelar.Visible = True
            DgvVenta.Enabled = False
            LlenarIdCliente()
        Else
            MessageBox.Show("Seleccione la Venta a Editar", "Seleccionar", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub
    Private Sub BtnCancelar_Click(sender As Object, e As EventArgs) Handles BtnCancelar.Click
        Dim R As DialogResult
        R = MessageBox.Show("¿Desea Cancelar el Proceso?", "INNOVAMASTER", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

        If R = DialogResult.Yes Then
            Limpiar()
        End If
    End Sub
    Private Sub Limpiar()
        LblNombre.Text = "0"
        GbVenta.Enabled = False
        BtnInsertar.Visible = False
        BtnNuevo.Visible = True
        BtnEditar.Visible = False
        BtnNuevoEditar.Visible = True
        BtnCancelar.Visible = False
        DgvVenta.Enabled = True
        TxtIdCliente.Clear()
        TxtIdVenta.Clear()
        CboFormaVenta.Text = Nothing
        CboTipoVenta.Text = Nothing
        TxtDescuentoExtra.Text = Nothing
    End Sub
    Private Sub DgvVenta_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DgvVenta.CellClick
        TxtIdVenta.Text = DgvVenta.CurrentRow.Cells(0).Value
        TxtIdCliente.Text = DgvVenta.CurrentRow.Cells(1).Value
        TxtFechaVenta.Text = DgvVenta.CurrentRow.Cells(2).Value
        TxtFechaVencimientos.Text = DgvVenta.CurrentRow.Cells(3).Value
        CboFormaVenta.Text = DgvVenta.CurrentRow.Cells(4).Value
        CboTipoVenta.Text = DgvVenta.CurrentRow.Cells(5).Value
        LblIdUsuario.Text = DgvVenta.CurrentRow.Cells(6).Value
        TxtDescuentoExtra.Text = DgvVenta.CurrentRow.Cells(7).Value
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
    Private Sub BtnInsertar_Click(sender As Object, e As EventArgs) Handles BtnInsertar.Click
        If TxtIdVenta.Text = Nothing Then
        ElseIf TxtIdCliente.Text = Nothing Then
            MsgBox("Ingrese el Código de Cliente", MsgBoxStyle.Critical, "Error")
        ElseIf TxtFechaVenta.Text = Nothing Then
        ElseIf TxtFechaVencimientos.Text = Nothing Then
            MsgBox("Ingrese la Fecha de Vencimiento de la Venta", MsgBoxStyle.Critical, "Error")
        ElseIf CboFormaVenta.Text = Nothing Then
            MsgBox("Seleccione la Forma de la Venta", MsgBoxStyle.Critical, "Error")
        ElseIf CboTipoVenta.Text = Nothing Then
            MsgBox("Seleccione el Tipo de Venta", MsgBoxStyle.Critical, "Error")
        ElseIf MenuPrincipal.LblIdUsuario.Text = Nothing Then
        ElseIf LblNombre.Text = "0" Then
            MsgBox("El Cliente No esta Registrado", MsgBoxStyle.Critical, "Error")
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

                If funcion.InsertarVenta(datos) Then
                    MsgBox("Venta Ingresada con éxito, ahora hay que ingresar los Productos a la Venta", MsgBoxStyle.Information, "Registro con Exito")
                    FrmDetalleVenta.LblCodigoVenta.Text = TxtIdVenta.Text
                    FrmDetalleVenta.LblCliente.Text = LblNombre.Text
                    FrmDetalleVenta.LblFormaVenta.Text = CboFormaVenta.Text
                    FrmDetalleVenta.LblTipoVenta.Text = CboTipoVenta.Text
                    FrmDetalleVenta.TxtDescuentoExtra.Text = TxtDescuentoExtra.Text
                    FrmDetalleVenta.RdbCantidad.Checked = True

                    Me.Close()
                    FrmDetalleVenta.MdiParent = MenuPrincipal
                    FrmDetalleVenta.Dock = DockStyle.Fill
                    FrmDetalleVenta.Show()
                    Limpiar()
                    Mostrar()

                End If

            Catch ex As Exception
                MsgBox(ex.ToString)
            Finally
                Conec.Desconectarse()
            End Try

        End If
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
    Private Sub BtnEditar_Click(sender As Object, e As EventArgs) Handles BtnEditar.Click
        If TxtIdVenta.Text = Nothing Then
        ElseIf TxtIdCliente.Text = Nothing Then
            MsgBox("Ingrese el Código de Cliente", MsgBoxStyle.Critical, "Error")
        ElseIf TxtFechaVenta.Text = Nothing Then
        ElseIf TxtFechaVencimientos.Text = Nothing Then
            MsgBox("Ingrese la Fecha de Vencimiento de la Venta", MsgBoxStyle.Critical, "Error")
        ElseIf CboFormaVenta.Text = Nothing Then
            MsgBox("Seleccione la Forma de la Venta", MsgBoxStyle.Critical, "Error")
        ElseIf CboTipoVenta.Text = Nothing Then
            MsgBox("Seleccione el Tipo de Venta", MsgBoxStyle.Critical, "Error")
        ElseIf LblIdUsuario.Text = Nothing Then
        ElseIf LblNombre.Text = "" Then
            MsgBox("El Cliente No esta Registrado", MsgBoxStyle.Critical, "Error")
        Else
            Try
                Dim datos As New DatosVenta
                Dim funcion As New Fventa

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


                If funcion.EditarVenta(datos) Then
                    MsgBox("Venta Editada con éxito", MsgBoxStyle.Information, "Registro con Exito")
                    Limpiar()
                    Mostrar()
                End If

            Catch ex As Exception
                MsgBox(ex.ToString)
            Finally
                Conec.Desconectarse()
            End Try

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
        FrmCliente.LblRelacionClienteVenta.Text = "1"
        FrmCliente.MdiParent = MenuPrincipal
        FrmCliente.Dock = DockStyle.Fill
        FrmCliente.Show()
        FrmCliente.Focus()



    End Sub
End Class