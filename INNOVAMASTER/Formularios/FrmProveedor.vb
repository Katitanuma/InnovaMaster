Imports System.ComponentModel
Imports System.Data.SqlClient
Public Class FrmProveedor

    Dim dt As New DataTable
    Dim Conec As New Conexion
    Dim cmd As SqlCommand
    Public var As Integer = 0
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CboBusqueda.Text = CboBusqueda.Items(0).ToString
        Focus()
        Mostrar()
        LlenarComboMunicipio()
        BtnInsertar.Visible = False
        BtnCancelar.Visible = False
        BtnEditar.Visible = False
        GbProveedor.Enabled = False
        DgvProveedor.AlternatingRowsDefaultCellStyle.BackColor = Color.PapayaWhip
        DgvProveedor.RowsDefaultCellStyle.BackColor = Color.Honeydew
        DgvProveedor.RowsDefaultCellStyle.SelectionBackColor = Color.Coral
    End Sub
    Private Sub Mostrar()
        Try
            Dim funcion As New Fproveedores
            dt = funcion.MostrarProveedores

            If dt.Rows.Count <> 0 Then
                DgvProveedor.DataSource = dt
                Label11.Visible = False
                TxtBusqueda.Enabled = True
                CboBusqueda.Enabled = True
            Else
                DgvProveedor.DataSource = Nothing
                Label11.Visible = True
                TxtBusqueda.Enabled = False
                CboBusqueda.Enabled = False
            End If
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub
    Private Sub TxtBusqueda_TextChanged(sender As Object, e As EventArgs) Handles TxtBusqueda.TextChanged
        Dim ds As New DataSet
        ds.Tables.Add(dt.Copy)
        Dim dv As New DataView(ds.Tables(0))

        dv.RowFilter = CboBusqueda.Text & " like '" & TxtBusqueda.Text & "%'"

        If dv.Count <> 0 Then
            Label11.Visible = False
            DgvProveedor.DataSource = dv
        Else
            Label11.Visible = True
            DgvProveedor.DataSource = Nothing
        End If

    End Sub
    Public Sub LlenarComboMunicipio()
        CboMunicipio.Items.Clear()
        Try
            Conec.Conectarse()
            cmd = New SqlCommand("Select Municipio from Municipio")
            cmd.CommandType = CommandType.Text
            cmd.Connection = Conec.Con
            Dim dr As SqlDataReader
            dr = cmd.ExecuteReader

            If dr.HasRows Then
                While dr.Read
                    CboMunicipio.Items.Add(dr(0).ToString)
                End While
            End If
            dr.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            Conec.Desconectarse()
        End Try
    End Sub

    Private Sub BtnNuevo_Click(sender As Object, e As EventArgs) Handles BtnNuevo.Click
        TxtIdProveedor.Enabled = True
        TxtRTN.Enabled = True
        GbProveedor.Enabled = True
        BtnNuevo.Visible = False
        BtnInsertar.Visible = True
        BtnCancelar.Visible = True
        BtnEditar.Visible = False
        DgvProveedor.Enabled = False
        BtnNuevoEditar.Visible = False
        TxtIdProveedor.Clear()
        TxtRTN.Clear()
        TxtNombreContacto.Clear()
        TxtDireccionEmpresa.Clear()
        TxtNombreContacto.Clear()
        TxtApellidosContacto.Clear()
        TxtDireccionContacto.Clear()
        TxtTelefono.Clear()
        TxtCorreo.Clear()
        RdbMasculino.Checked = False
        RdbFemenino.Checked = False
    End Sub
    Private Sub DgvCliente_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DgvProveedor.CellClick
        TxtIdProveedor.Text = DgvProveedor.SelectedCells.Item(0).Value
        TxtRTN.Text = DgvProveedor.SelectedCells.Item(1).Value
        TxtNombreEmpresa.Text = DgvProveedor.SelectedCells.Item(2).Value
        TxtDireccionEmpresa.Text = DgvProveedor.SelectedCells.Item(3).Value
        TxtNombreContacto.Text = DgvProveedor.SelectedCells.Item(4).Value
        TxtApellidosContacto.Text = DgvProveedor.SelectedCells.Item(5).Value
        TxtDireccionContacto.Text = DgvProveedor.SelectedCells.Item(6).Value
        TxtTelefono.Text = DgvProveedor.SelectedCells.Item(7).FormattedValue
        TxtCorreo.Text = DgvProveedor.SelectedCells.Item(8).FormattedValue
        CboMunicipio.Text = DgvProveedor.SelectedCells.Item(9).Value
        If DgvProveedor.SelectedCells.Item(10).Value = "Masculino" Then
            RdbMasculino.Select()
        Else
            RdbFemenino.Select()
        End If



    End Sub
    Private Sub BtnCancelar_Click(sender As Object, e As EventArgs) Handles BtnCancelar.Click
        Dim R As DialogResult
        R = MessageBox.Show("¿Desea Cancelar el Proceso?", "INNOVAMASTER", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

        If R = DialogResult.Yes Then
            Limpiar()
            Me.Focus()
        End If

    End Sub
    Private Sub BtnInsertar_Click(sender As Object, e As EventArgs) Handles BtnInsertar.Click
        If TxtIdProveedor.Text = Nothing Then
            MsgBox("Ingrese el Numero de Identidad del Contacto", MsgBoxStyle.Critical, "Error")
        ElseIf TxtNombreEmpresa.Text = Nothing Then
            MsgBox("Ingrese el Nombre de la Empresa", MsgBoxStyle.Critical, "Error")
        ElseIf TxtDireccionEmpresa.Text = Nothing Then
            MsgBox("Ingrese la Direccion de la Empresa", MsgBoxStyle.Critical, "Error")
        ElseIf TxtNombreContacto.Text = Nothing Then
            MsgBox("Ingrese el Nombre del Contacto", MsgBoxStyle.Critical, "Error")
        ElseIf TxtApellidosContacto.Text = Nothing Then
            MsgBox("Ingrese el Apellido del Contacto", MsgBoxStyle.Critical, "Error")
        ElseIf TxtDireccionContacto.Text = Nothing Then
            MsgBox("Ingrese la Dirección del Contacto", MsgBoxStyle.Critical, "Error")
        ElseIf RdbMasculino.Checked = False And RdbFemenino.Checked = False Then
            MsgBox("Seleccione el Sexo del Contacto", MsgBoxStyle.Critical, "Error")
        ElseIf CboMunicipio.SelectedItem = Nothing Then
            MsgBox("Seleccione el Municipio del Contacto", MsgBoxStyle.Critical, "Error")
        Else
            Try
                Dim datos As New DatosProveedor
                Dim funcion As New Fproveedores

                datos.gIdProveedor = TxtIdProveedor.Text
                datos.gRTN = TxtRTN.Text
                datos.gNombreEmpresa = TxtNombreEmpresa.Text
                datos.gDireccionEmpresa = TxtDireccionEmpresa.Text
                datos.gNombreContacto = TxtNombreContacto.Text
                datos.gApellidoContacto = TxtApellidosContacto.Text
                datos.gDireccionContacto = TxtDireccionContacto.Text
                datos.gTelefonoContacto = TxtTelefono.Text
                datos.gCorreoContacto = TxtCorreo.Text


                If RdbMasculino.Checked = True Then
                    datos.gIdSexo = 1
                Else
                    datos.gIdSexo = 2
                End If
                Conec.Conectarse()
                Try
                    cmd = New SqlCommand("Select IdMunicipio From Municipio Where Municipio= '" & CboMunicipio.Text & "'")
                    cmd.CommandType = CommandType.Text
                    cmd.Connection = Conec.Con
                    Dim dr As SqlDataReader
                    dr = cmd.ExecuteReader

                    If dr.Read Then
                        datos.gIdMunicipio = dr(0)
                    End If
                    dr.Close()
                Catch ex As Exception
                    MsgBox(ex.Message)
                End Try



                If funcion.InsertarProveedor(datos) Then
                    MsgBox("Cliente Ingresado con Éxito", MsgBoxStyle.Information)
                    Limpiar()
                    Mostrar()
                    Focus()
                End If

            Catch ex As Exception
                MsgBox(ex.ToString)
            Finally
                Conec.Desconectarse()
            End Try

        End If

    End Sub
    Private Sub Limpiar()
        GbProveedor.Enabled = False
        BtnInsertar.Visible = False
        BtnNuevo.Visible = True
        BtnEditar.Visible = False
        BtnNuevoEditar.Visible = True
        BtnCancelar.Visible = False
        DgvProveedor.Enabled = True
        TxtIdProveedor.Clear()
        TxtRTN.Clear()
        TxtNombreContacto.Clear()
        TxtDireccionEmpresa.Clear()
        TxtNombreContacto.Clear()
        TxtApellidosContacto.Clear()
        TxtDireccionContacto.Clear()
        TxtTelefono.Clear()
        TxtCorreo.Clear()
        RdbMasculino.Checked = False
        RdbFemenino.Checked = False
    End Sub
    Private Sub BtnNuevoEditar_Click(sender As Object, e As EventArgs) Handles BtnNuevoEditar.Click
        If TxtNombreEmpresa.Text <> Nothing Then
            GbProveedor.Enabled = True
            BtnNuevo.Visible = False
            BtnInsertar.Visible = False
            BtnEditar.Visible = True
            BtnNuevoEditar.Visible = False
            BtnCancelar.Visible = True
            DgvProveedor.Enabled = False
            TxtIdProveedor.Enabled = False
            Focus()
        Else
            MessageBox.Show("Seleccione el Proveedor a Editar", "Seleccionar", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If


    End Sub
    Private Sub BtnEditar_Click(sender As Object, e As EventArgs) Handles BtnEditar.Click
        If TxtIdProveedor.Text = Nothing Then
            MsgBox("Ingrese el Numero de Identidad del Contacto", MsgBoxStyle.Critical, "Error")
        ElseIf TxtNombreEmpresa.Text = Nothing Then
            MsgBox("Ingrese el Nombre de la Empresa", MsgBoxStyle.Critical, "Error")
        ElseIf TxtDireccionEmpresa.Text = Nothing Then
            MsgBox("Ingrese la Direccion de la Empresa", MsgBoxStyle.Critical, "Error")
        ElseIf TxtNombreContacto.Text = Nothing Then
            MsgBox("Ingrese el Nombre del Contacto", MsgBoxStyle.Critical, "Error")
        ElseIf TxtApellidosContacto.Text = Nothing Then
            MsgBox("Ingrese el Apellido del Contacto", MsgBoxStyle.Critical, "Error")
        ElseIf TxtDireccionContacto.Text = Nothing Then
            MsgBox("Ingrese la Dirección del Contacto", MsgBoxStyle.Critical, "Error")
        ElseIf RdbMasculino.Checked = False And RdbFemenino.Checked = False Then
            MsgBox("Seleccione el Sexo del Contacto", MsgBoxStyle.Critical, "Error")
        ElseIf CboMunicipio.SelectedItem = Nothing Then
            MsgBox("Seleccione el Municipio del Contacto", MsgBoxStyle.Critical, "Error")
        Else
            Try
                Dim datos As New DatosProveedor
                Dim funcion As New Fproveedores

                datos.gIdProveedor = TxtIdProveedor.Text
                datos.gRTN = TxtRTN.Text
                datos.gNombreEmpresa = TxtNombreEmpresa.Text
                datos.gDireccionEmpresa = TxtDireccionEmpresa.Text
                datos.gNombreContacto = TxtNombreContacto.Text
                datos.gApellidoContacto = TxtApellidosContacto.Text
                datos.gDireccionContacto = TxtDireccionContacto.Text
                datos.gTelefonoContacto = TxtTelefono.Text
                datos.gCorreoContacto = TxtCorreo.Text


                If RdbMasculino.Checked = True Then
                    datos.gIdSexo = 1
                Else
                    datos.gIdSexo = 2
                End If
                Conec.Conectarse()
                Try
                    cmd = New SqlCommand("Select IdMunicipio From Municipio Where Municipio= '" & CboMunicipio.Text & "'")
                    cmd.CommandType = CommandType.Text
                    cmd.Connection = Conec.Con
                    Dim dr As SqlDataReader
                    dr = cmd.ExecuteReader

                    If dr.Read Then
                        datos.gIdMunicipio = dr(0)
                    End If
                    dr.Close()
                Catch ex As Exception
                    MsgBox(ex.Message)
                End Try



                If funcion.EditarProveedor(datos) Then
                    MsgBox("Proveedor editado con Éxito", MsgBoxStyle.Information)
                    Limpiar()
                    Mostrar()
                    Focus()
                End If

            Catch ex As Exception
                MsgBox(ex.ToString)
            Finally
                Conec.Desconectarse()
            End Try

        End If

    End Sub
    Private Sub DgvCliente_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles DgvProveedor.CellDoubleClick
        If var = 2 Then
            FrmPedidos.LlenarComboBoxProveedor()
            FrmPedidos.CboProveedor.Text = DgvProveedor.CurrentRow.Cells(4).Value.ToString + " " + DgvProveedor.CurrentRow.Cells(5).Value.ToString
            Me.Close()
        End If
    End Sub
    Private Sub FrmCliente_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
        LblRelacionClienteVenta.Text = "0"
    End Sub



    Private Sub BtnBusquedaCliente_Click(sender As Object, e As EventArgs) Handles BtnBusquedaMunicipio.Click
        With FrmMunicipio
            FrmMunicipio.var = 3
            .MdiParent = MenuPrincipal
            .Dock = DockStyle.Fill
            .Show()
        End With
    End Sub


End Class