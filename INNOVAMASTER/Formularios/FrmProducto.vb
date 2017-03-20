Imports System.Data.SqlClient
Imports System.IO
Public Class FrmProducto
    Dim dt As New DataTable
    Dim Conec As New Conexion
    Dim cmd As SqlCommand
    Private Sub FrmProducto_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        MostrarProducto()
        Focus()
        LlenarCombos()
    End Sub
    Private Sub MostrarProducto()
        Try
            Dim datos As New Fproducto
            dt = datos.MostrarProducto

            If dt.Rows.Count <> 0 Then
                LblFilas.Visible = False
                DgvProducto.DataSource = dt
                DgvProducto.Columns(11).Visible = False
                CboBusqueda.Enabled = True
                TxtBusqueda.Enabled = True
            Else
                LblFilas.Visible = True
                DgvProducto.DataSource = Nothing
                CboBusqueda.Enabled = False
                TxtBusqueda.Enabled = False
            End If
        Catch ex As Exception

        End Try
    End Sub
    Private Sub DgvProducto_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DgvProducto.CellClick
        TxtIdProducto.Text = DgvProducto.SelectedCells.Item(0).Value
        TxtDescripcion.Text = DgvProducto.SelectedCells.Item(1).Value
        TxtCosto.Text = DgvProducto.SelectedCells.Item(2).Value

        TxtGravado.Text = DgvProducto.SelectedCells.Item(3).Value
        TxtPrecioUnitario.Text = DgvProducto.SelectedCells.Item(4).Value
        TxtPrecioMayorista.Text = DgvProducto.SelectedCells.Item(5).Value
        NumericUpDown1.Text = DgvProducto.SelectedCells.Item(6).Value
        CboCategoria.Text = DgvProducto.SelectedCells.Item(7).Value
        TxtModelo.Text = DgvProducto.SelectedCells.Item(8).Value
        PbProducto.Image = DgvProducto.SelectedCells.Item(10).FormattedValue

        If DgvProducto.SelectedCells.Item(9).Value = "Activo" Then
            ChkEstado.Checked = True
        Else
            ChkEstado.Checked = False
        End If

    End Sub
    Private Sub TxtBusqueda_TextChanged(sender As Object, e As EventArgs) Handles TxtBusqueda.TextChanged
        Dim ds As New DataSet
        Dim dv As New DataView
        ds.Tables.Add(dt.Copy)
        dv = New DataView(ds.Tables(0))

        dv.RowFilter = CboBusqueda.Text & " Like '" & TxtBusqueda.Text & "%'"

        If dv.Count <> 0 Then
            LblFilas.Visible = False
            DgvProducto.DataSource = dv
            DgvProducto.Columns(10).Visible = False
        Else
            LblFilas.Visible = True
            DgvProducto.DataSource = Nothing
        End If

    End Sub
    Private Sub BtnNuevo_Click(sender As Object, e As EventArgs) Handles BtnNuevo.Click
        TxtIdProducto.Enabled = True
        LlenarCombos()
        ChkEstado.Checked = True
        GbProducto.Enabled = True
        TxtIdProducto.Clear()
        TxtDescripcion.Clear()
        TxtCosto.Clear()
        TxtGravado.Value = 0
        TxtPrecioUnitario.Clear()
        TxtPrecioMayorista.Clear()
        NumericUpDown1.Value = 0
        CboCategoria.Text = Nothing
        TxtModelo.Clear()
        BtnCancelar.Visible = True
        BtnInsertar.Visible = True
        BtnNuevoEditar.Visible = False
        BtnNuevo.Visible = False
        DgvProducto.Enabled = False
        PbProducto.Image = Nothing
    End Sub
    Private Sub BtnCancelar_Click(sender As Object, e As EventArgs) Handles BtnCancelar.Click
        Dim r As DialogResult = MessageBox.Show("¿Desea Cancelar el Proceso?", "INNOVAMASTER", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If r = DialogResult.Yes Then
            DgvProducto.Enabled = True
            GbProducto.Enabled = False
            TxtIdProducto.Clear()
            TxtDescripcion.Clear()
            TxtCosto.Clear()

            TxtGravado.Value = 0
            TxtPrecioUnitario.Clear()
            TxtPrecioMayorista.Clear()
            NumericUpDown1.Value = 0
            CboCategoria.Text = Nothing
            TxtModelo.Clear()
            BtnCancelar.Visible = False
            BtnInsertar.Visible = False
            BtnEditar.Visible = False
            BtnNuevoEditar.Visible = True
            BtnNuevo.Visible = True
            ChkEstado.Checked = True
            Focus()
        End If


    End Sub
    Private Sub BtnNuevoEditar_Click(sender As Object, e As EventArgs) Handles BtnNuevoEditar.Click
        If TxtIdProducto.Text <> Nothing Then
            TxtIdProducto.Enabled = False
            GbProducto.Enabled = True
            BtnCancelar.Visible = True
            BtnInsertar.Visible = False
            BtnEditar.Visible = True
            BtnNuevo.Visible = False
            BtnNuevoEditar.Visible = False
            DgvProducto.Enabled = False
        Else
            MessageBox.Show("Seleccione el Producto a Editar", "INNOVAMASTER", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End If


    End Sub
    Private Sub BtnInsertar_Click(sender As Object, e As EventArgs) Handles BtnInsertar.Click
        If TxtIdProducto.Text = Nothing Then
            MessageBox.Show("Ingrese el Código del Producto", "INNOVAMASTER", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        ElseIf TxtDescripcion.Text = Nothing Then
            MessageBox.Show("Ingrese la Descripción del Producto", "INNOVAMASTER", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        ElseIf TxtCosto.Text = Nothing Then
            MessageBox.Show("Ingrese el Costo del Producto", "INNOVAMASTER", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        ElseIf TxtPrecioUnitario.Text = Nothing Then
            MessageBox.Show("Ingrese el Precio Unitario del Producto", "INNOVAMASTER", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        ElseIf CboCategoria.SelectedItem = Nothing Then
            MessageBox.Show("Seleccione la Categoria del Producto", "INNOVAMASTER", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        ElseIf TxtModelo.Text = Nothing Then
            MessageBox.Show("Ingrese el Modelo del Producto", "INNOVAMASTER", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        ElseIf NumericUpDown1.Value <= 5 Then
            MessageBox.Show("No se Puede Ingresar Menor de 5 Productos en Existencia", "INNOVAMASTER", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        Else
            Try
                Dim datos As New DatosProducto
                Dim funcion As New Fproducto
                datos.gIdProducto = TxtIdProducto.Text
                datos.gDescripcion = TxtDescripcion.Text
                datos.gCosto = CDbl(TxtCosto.Text)
                If TxtGravado.Text = Nothing Then
                    datos.gGravado = 0
                Else
                    datos.gGravado = CDbl(TxtGravado.Value)
                End If

                datos.gPrecioUnitario = CDbl(TxtPrecioUnitario.Text)
                datos.gPrecioMayorista = CDbl(TxtPrecioMayorista.Text)
                datos.gExistecia = Int(NumericUpDown1.Value)

                Dim ms As New MemoryStream

                If PbProducto.Image Is Nothing Then
                    PbProducto.Image = Image.FromFile("C:\Archivo.PNG")
                End If
                PbProducto.Image.Save(ms, PbProducto.Image.RawFormat)
                datos.gImagen = ms.GetBuffer
                If ChkEstado.Checked = True Then
                    datos.gEstado = "Activo"
                Else
                    datos.gEstado = "Inactivo"
                End If
                Conec.Conectarse()
                Try
                    Dim dr As SqlDataReader
                    cmd = New SqlCommand("Select IdCategoria from Categoria Where Categoria= '" & CboCategoria.Text & "'")
                    cmd.CommandType = CommandType.Text
                    cmd.Connection = Conec.Con

                    dr = cmd.ExecuteReader

                    If dr.Read Then
                        datos.gIdCategoria = dr(0)
                    End If

                    dr.Close()
                Catch ex As Exception
                    MsgBox(ex.Message)
                End Try

                Try
                    Dim dr2 As SqlDataReader
                    cmd = New SqlCommand("Select IdModelo from ModeloVehiculo Where Modelo= '" & TxtModelo.Text & "'")
                    cmd.CommandType = CommandType.Text
                    cmd.Connection = Conec.Con

                    dr2 = cmd.ExecuteReader

                    If dr2.Read Then
                        datos.gIdModelo = dr2(0)
                    End If

                    dr2.Close()

                Catch ex As Exception
                    MsgBox(ex.Message)
                End Try


                If funcion.Insertar(datos) Then
                    MessageBox.Show("Producto Insertado Con éxito", "INNOVAMASTER", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    GbProducto.Enabled = False
                    TxtIdProducto.Clear()
                    TxtDescripcion.Clear()
                    TxtCosto.Clear()
                    TxtGravado.Value = 0
                    TxtPrecioUnitario.Clear()
                    TxtPrecioMayorista.Clear()
                    NumericUpDown1.Value = 0
                    CboCategoria.Text = Nothing
                    TxtModelo.Text = Nothing
                    BtnCancelar.Visible = False
                    BtnInsertar.Visible = False
                    BtnEditar.Visible = False
                    BtnNuevoEditar.Visible = True
                    BtnNuevo.Visible = True
                    ChkEstado.Checked = True
                    DgvProducto.Enabled = True
                    MostrarProducto()
                    PbProducto.Image = Nothing
                End If

            Catch ex As Exception

                MsgBox(ex.ToString)


            Finally
                Conec.Desconectarse()
            End Try

        End If
    End Sub
    Private Sub LlenarCombos()
        Try
            Conec.Conectarse()
            CboCategoria.Items.Clear()
            TxtModelo.AutoCompleteCustomSource.Clear()
            Dim dr As SqlDataReader
            cmd = New SqlCommand("Select Categoria from Categoria")
            cmd.CommandType = CommandType.Text
            cmd.Connection = Conec.Con
            dr = cmd.ExecuteReader
            If dr.HasRows Then
                While dr.Read
                    CboCategoria.Items.Add(dr(0))
                End While
            End If

            dr.Close()
            Dim dr2 As SqlDataReader
            cmd = New SqlCommand("Select Modelo from ModeloVehiculo ")
            cmd.CommandType = CommandType.Text
            cmd.Connection = Conec.Con

            dr2 = cmd.ExecuteReader

            If dr2.HasRows Then
                While dr2.Read
                    TxtModelo.AutoCompleteCustomSource.Add(dr2(0))
                End While
            End If

            dr2.Close()

        Catch ex As Exception
            MsgBox(ex.ToString)
        Finally
            Conec.Desconectarse()
        End Try
    End Sub
    Private Sub BtnEditar_Click(sender As Object, e As EventArgs) Handles BtnEditar.Click
        If TxtIdProducto.Text = Nothing Then
            MessageBox.Show("Ingrese el Código del Producto", "INNOVAMASTER", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        ElseIf TxtDescripcion.Text = Nothing Then
            MessageBox.Show("Ingrese la Descripción del Producto", "INNOVAMASTER", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        ElseIf TxtCosto.Text = Nothing Then
            MessageBox.Show("Ingrese el Costo del Producto", "INNOVAMASTER", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        ElseIf TxtPrecioUnitario.Text = Nothing Then
            MessageBox.Show("Ingrese el Precio Unitario del Producto", "INNOVAMASTER", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        ElseIf CboCategoria.SelectedItem = Nothing Then
            MessageBox.Show("Seleccione la Categoria del Producto", "INNOVAMASTER", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        ElseIf TxtModelo.Text = "Seleccionar Modelo" Then
            MessageBox.Show("Ingrese el Modelo del Producto", "INNOVAMASTER", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        ElseIf NumericUpDown1.Value <= 5 Then
            MessageBox.Show("No se Puede Ingresar Menor de 5 Productos en Existencia", "INNOVAMASTER", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        Else
            Try
                Dim datos As New DatosProducto
                Dim funcion As New Fproducto

                datos.gIdProducto = TxtIdProducto.Text
                datos.gDescripcion = TxtDescripcion.Text
                datos.gCosto = CDbl(TxtCosto.Text)
                If TxtGravado.Text = Nothing Then
                    datos.gGravado = 0
                Else
                    datos.gGravado = CDbl(TxtGravado.Value)
                End If


                datos.gPrecioUnitario = CDbl(TxtPrecioUnitario.Text)
                datos.gPrecioMayorista = CDbl(TxtPrecioMayorista.Text)
                datos.gExistecia = Int(NumericUpDown1.Value)
                Dim ms As New MemoryStream

                If PbProducto.Image Is Nothing Then
                    PbProducto.Image = Image.FromFile("C:\Archivo.PNG")
                End If
                PbProducto.Image.Save(ms, PbProducto.Image.RawFormat)
                datos.gImagen = ms.GetBuffer
                If ChkEstado.Checked = True Then
                    datos.gEstado = "Activo"
                Else
                    datos.gEstado = "Inactivo"
                End If
                Conec.Conectarse()
                Try
                    Dim dr As SqlDataReader
                    cmd = New SqlCommand("Select IdCategoria from Categoria Where Categoria= '" & CboCategoria.Text & "'")
                    cmd.CommandType = CommandType.Text
                    cmd.Connection = Conec.Con

                    dr = cmd.ExecuteReader

                    If dr.Read Then
                        datos.gIdCategoria = dr(0)
                    End If

                    dr.Close()
                Catch ex As Exception
                    MsgBox(ex.Message)
                End Try

                Try
                    Dim dr2 As SqlDataReader
                    cmd = New SqlCommand("Select IdModelo from ModeloVehiculo Where Modelo= '" & TxtModelo.Text & "'")
                    cmd.CommandType = CommandType.Text
                    cmd.Connection = Conec.Con

                    dr2 = cmd.ExecuteReader

                    If dr2.Read Then
                        datos.gIdModelo = dr2(0)
                    End If

                    dr2.Close()

                Catch ex As Exception
                    MsgBox(ex.Message)
                End Try

                If funcion.Editar(datos) Then
                    MessageBox.Show("Producto Editado Con éxito", "INNOVAMASTER", MessageBoxButtons.OK, MessageBoxIcon.Information)

                    GbProducto.Enabled = False
                    TxtIdProducto.Clear()
                    TxtDescripcion.Clear()
                    TxtCosto.Clear()

                    TxtGravado.Value = 0
                    TxtPrecioUnitario.Clear()
                    TxtPrecioMayorista.Clear()
                    NumericUpDown1.Value = 0
                    CboCategoria.Text = Nothing
                    TxtModelo.Clear()
                    BtnCancelar.Visible = False
                    BtnInsertar.Visible = False
                    BtnEditar.Visible = False
                    BtnNuevoEditar.Visible = True
                    BtnNuevo.Visible = True
                    TxtIdProducto.Enabled = True
                    DgvProducto.Enabled = True
                    ChkEstado.Checked = True
                    MostrarProducto()
                    PbProducto.Image = Nothing
                End If

            Catch ex As Exception
                MsgBox(ex.ToString)
            Finally
                Conec.Desconectarse()
            End Try

        End If
    End Sub
    Private Sub ChkEstado_CheckedChanged(sender As Object, e As EventArgs) Handles ChkEstado.CheckedChanged
        If ChkEstado.Checked = False Then
            ChkEstado.Text = "Inactivo"
        Else
            ChkEstado.Text = "Activo"
        End If
    End Sub
    Private Sub BtnAgregarImagen_Click(sender As Object, e As EventArgs) Handles BtnAgregarImagen.Click
        OpenFileDialog1.Filter = "Imagenes JPG|*.jpg|Imagenes GIF|*.gif|Imagenes Bitmasps|*.bmp"
        If OpenFileDialog1.ShowDialog() = DialogResult.OK Then
            PbProducto.Image = Image.FromFile(OpenFileDialog1.FileName)
        End If
    End Sub
    Private Sub BtnEliminarImagen_Click(sender As Object, e As EventArgs) Handles BtnEliminarImagen.Click
        PbProducto.Image = Nothing
    End Sub

    Private Sub BtnBusquedaCliente_Click(sender As Object, e As EventArgs) Handles BtnBusquedaCliente.Click
        With FrmCategoria
            .MdiParent = MenuPrincipal
            .Dock = DockStyle.Fill
            .Show()
        End With
    End Sub


    Private Sub CboCategoria_DropDown(sender As Object, e As EventArgs) Handles CboCategoria.DropDown
        LlenarCombos()
    End Sub
End Class