Imports System.ComponentModel
Imports System.Data.SqlClient
Public Class FrmCliente
    Dim dt As New DataTable
    Dim Conec As New Conexion
    Dim cmd As SqlCommand
    Public Var As Integer = 0
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CboBusqueda.Text = CboBusqueda.Items(0).ToString
        Focus()
        Mostrar()
        LlenarComboMunicipio()
        LlenarComboEstadoCivil()
        llenarComboAños()
        BtnInsertar.Visible = False
        BtnCancelar.Visible = False
        BtnEditar.Visible = False
        GbCliente.Enabled = False
        DgvCliente.AlternatingRowsDefaultCellStyle.BackColor = Color.PapayaWhip
        DgvCliente.RowsDefaultCellStyle.BackColor = Color.Honeydew
        DgvCliente.RowsDefaultCellStyle.SelectionBackColor = Color.Coral

        Dim NombreArchivo As String = HTMLHelpClass.GetLocalHelpFileName("InnovaMasterAyuda2017.chm")
        HelpProvider1.HelpNamespace = NombreArchivo
        HelpProvider1.SetHelpNavigator(Me, HelpNavigator.KeywordIndex)
        HelpProvider1.SetHelpKeyword(Me, "Registro Cliente")
    End Sub
    Private Sub Mostrar()
        Try
            Dim funcion As New Fcliente
            dt = funcion.MostrarCliente

            If dt.Rows.Count <> 0 Then
                DgvCliente.DataSource = dt
                Label11.Visible = False
                TxtBusqueda.Enabled = True
                CboBusqueda.Enabled = True
            Else
                DgvCliente.DataSource = Nothing
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
            DgvCliente.DataSource = dv
        Else
            Label11.Visible = True
            DgvCliente.DataSource = Nothing
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
    Private Sub LlenarComboEstadoCivil()
        CboEstadoCivil.Items.Clear()
        Try
            Conec.Conectarse()
            cmd.CommandType = CommandType.Text
            cmd = New SqlCommand("Select EstadoCivil From EstadoCivil")
            cmd.Connection = Conec.Con
            Dim dr As SqlDataReader
            dr = cmd.ExecuteReader

            If dr.HasRows Then
                While dr.Read
                    CboEstadoCivil.Items.Add(dr(0))
                End While
            End If
            dr.Close()

        Catch ex As Exception
            MsgBox(ex.ToString)
        Finally
            Conec.Desconectarse()
        End Try
    End Sub
    Private Sub llenarComboAños()
        Dim n As Integer
        For n = 1920 To 3000
            CboAño.Items.Add(n)
        Next
    End Sub
    Private Sub BtnNuevo_Click(sender As Object, e As EventArgs) Handles BtnNuevo.Click
        TxtIdCliente.Enabled = True
        GbCliente.Enabled = True
        BtnNuevo.Visible = False
        BtnInsertar.Visible = True
        BtnCancelar.Visible = True
        BtnEditar.Visible = False
        DgvCliente.Enabled = False
        BtnNuevoEditar.Visible = False
        TxtIdCliente.Clear()
        TxtNombres.Clear()
        TxtDireccion.Clear()
        TxtApellidos.Clear()
        TxtCorreo.Clear()
        TxtTelefono.Clear()
        RdbMasculino.Checked = False
        RdbFemenino.Checked = False
        CboDia.Text = "Dia"
        CboMes.Text = "Mes"
        CboAño.Text = "Año"
        CboMunicipio.Text = Nothing
        CboEstadoCivil.Text = Nothing

    End Sub
    Private Sub DgvCliente_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DgvCliente.CellClick
        TxtIdCliente.Text = DgvCliente.SelectedCells.Item(0).Value
        TxtDireccion.Text = DgvCliente.SelectedCells.Item(2).Value
        TxtTelefono.Text = DgvCliente.SelectedCells.Item(3).Value
        TxtCorreo.Text = DgvCliente.SelectedCells.Item(4).Value
        CboMunicipio.Text = DgvCliente.SelectedCells.Item(7).Value
        CboEstadoCivil.Text = DgvCliente.SelectedCells.Item(8).Value

        If DgvCliente.SelectedCells.Item(6).Value = "Masculino" Then
            RdbMasculino.Select()
        Else
            RdbFemenino.Select()
        End If

        Dim cadena As String = DgvCliente.SelectedCells.Item(5).Value
        Dim c As String() = cadena.Split("/")
        CboDia.Text = c(0)
        Select Case c(1)
            Case "01" Or "1"
                CboMes.Text = "Enero"
            Case "02" Or "2"
                CboMes.Text = "Febrero"
            Case "03" Or "3"
                CboMes.Text = "Marzo"
            Case "04" Or "4"
                CboMes.Text = "Abril"
            Case "05" Or "5"
                CboMes.Text = "Mayo"
            Case "06" Or "6"
                CboMes.Text = "Junio"
            Case "07" Or "7"
                CboMes.Text = "Julio"
            Case "08" Or "8"
                CboMes.Text = "Agosto"
            Case "09" Or "9"
                CboMes.Text = "Septiembre"
            Case "10"
                CboMes.Text = "Octubre"
            Case "11"
                CboMes.Text = "Noviembre"
            Case "12"
                CboMes.Text = "Diciembre"
        End Select
        CboAño.Text = c(2)
        Try
            Conec.Conectarse()
            cmd.CommandType = CommandType.Text
            cmd = New SqlCommand("Select NombreCliente, ApellidoCliente from Cliente Where IdCliente = '" & DgvCliente.SelectedCells.Item(0).Value & "'")
            cmd.Connection = Conec.Con
            Dim dr As SqlDataReader

            dr = cmd.ExecuteReader

            If dr.Read Then
                TxtNombres.Text = dr(0)
                TxtApellidos.Text = dr(1)
            End If
            dr.Close()

        Catch ex As Exception
        Finally
            Conec.Desconectarse()
        End Try
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
        If TxtIdCliente.MaskFull = False Then
            MsgBox("Ingrese el Numero de Identidad del Cliente", MsgBoxStyle.Critical, "Error")
        ElseIf TxtNombres.Text = Nothing Then
            MsgBox("Ingrese el Nombre del Cliente", MsgBoxStyle.Critical, "Error")
        ElseIf TxtApellidos.Text = Nothing Then
            MsgBox("Ingrese los Apellidos del Cliente", MsgBoxStyle.Critical, "Error")
        ElseIf TxtDireccion.Text = Nothing Then
            MsgBox("Ingrese la Dirección del Cliente", MsgBoxStyle.Critical, "Error")
        ElseIf CboDia.Text = "Dia" Then
            MsgBox("Seleccione el Dia de Nacimiento del Cliente", MsgBoxStyle.Critical, "Error")
        ElseIf CboMes.Text = "Mes" Then
            MsgBox("Seleccione el Mes de Nacimiento del Cliente", MsgBoxStyle.Critical, "Error")
        ElseIf CboAño.Text = "Año" Then
            MsgBox("Seleccione el Año de Nacimiento del Cliente", MsgBoxStyle.Critical, "Error")
        ElseIf RdbMasculino.Checked = False And RdbFemenino.Checked = False Then
            MsgBox("Seleccione el Sexo del Cliente", MsgBoxStyle.Critical, "Error")
        ElseIf CboMunicipio.SelectedItem = Nothing Then
            MsgBox("Seleccione el Municipio del Cliente", MsgBoxStyle.Critical, "Error")
        ElseIf CboEstadoCivil.Text = Nothing Then
            MsgBox("Seleccione el Estado Civil del Cliente", MsgBoxStyle.Critical, "Error")
        Else
            Try
                Dim datos As New DatosCliente
                Dim funcion As New Fcliente
                Dim Mes As Integer
                datos.gIdCliente = TxtIdCliente.Text
                datos.gNombreCliente = TxtNombres.Text
                datos.gApellidoCliente = TxtApellidos.Text
                datos.gDireccionCliente = TxtDireccion.Text
                datos.gTelefonoCliente = TxtTelefono.Text
                datos.gCorreoCliente = TxtCorreo.Text
                If CboMes.Text = "Enero" Then
                    Mes = "1"
                ElseIf CboMes.Text = "Febrero" Then
                    Mes = "2"
                ElseIf CboMes.Text = "Marzo" Then
                    Mes = "3"
                ElseIf CboMes.Text = "Abril" Then
                    Mes = "4"
                ElseIf CboMes.Text = "Mayo" Then
                    Mes = "5"
                ElseIf CboMes.Text = "Junio" Then
                    Mes = "6"
                ElseIf CboMes.Text = "Julio" Then
                    Mes = "7"
                ElseIf CboMes.Text = "Agosto" Then
                    Mes = "8"
                ElseIf CboMes.Text = "Septiembre" Then
                    Mes = "9"
                ElseIf CboMes.Text = "Octubre" Then
                    Mes = "10"
                ElseIf CboMes.Text = "Noviembre" Then
                    Mes = "11"
                ElseIf CboMes.Text = "Diciembre" Then
                    Mes = "12"
                End If
                datos.gFechaNacimiento = CboAño.Text & "-" & Mes.ToString & "-" & CboDia.Text

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

                Try
                    cmd = New SqlCommand("Select IdEstadoCivil From EstadoCivil Where EstadoCivil= '" & CboEstadoCivil.Text & "'")
                    cmd.CommandType = CommandType.Text
                    cmd.Connection = Conec.Con
                    Dim dr2 As SqlDataReader
                    dr2 = cmd.ExecuteReader

                    If dr2.Read Then
                        datos.gIdEstadoCivil = dr2(0)
                    End If
                    dr2.Close()
                Catch ex As Exception
                    MsgBox(ex.Message)
                End Try

                If funcion.InsertarCliente(datos) Then
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
        GbCliente.Enabled = False
        BtnInsertar.Visible = False
        BtnNuevo.Visible = True
        BtnEditar.Visible = False
        BtnNuevoEditar.Visible = True
        BtnCancelar.Visible = False
        DgvCliente.Enabled = True
        TxtIdCliente.Clear()
        TxtNombres.Clear()
        TxtDireccion.Clear()
        TxtApellidos.Clear()
        TxtCorreo.Clear()
        TxtTelefono.Clear()
        RdbMasculino.Checked = False
        RdbFemenino.Checked = False
        CboDia.Text = "Dia"
        CboMes.Text = "Mes"
        CboAño.Text = "Año"
        CboMunicipio.Text = Nothing
        CboEstadoCivil.Text = Nothing
    End Sub
    Private Sub BtnNuevoEditar_Click(sender As Object, e As EventArgs) Handles BtnNuevoEditar.Click
        If TxtNombres.Text <> Nothing Then
            GbCliente.Enabled = True
            BtnNuevo.Visible = False
            BtnInsertar.Visible = False
            BtnEditar.Visible = True
            BtnNuevoEditar.Visible = False
            BtnCancelar.Visible = True
            DgvCliente.Enabled = False
            TxtIdCliente.Enabled = False
            Focus()
        Else
            MessageBox.Show("Seleccione el Cliente a Editar", "Seleccionar", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If


    End Sub
    Private Sub BtnEditar_Click(sender As Object, e As EventArgs) Handles BtnEditar.Click
        If TxtNombres.Text = Nothing Then
            MsgBox("Ingrese el Nombre del Cliente", MsgBoxStyle.Critical, "Error")
        ElseIf TxtApellidos.Text = Nothing Then
            MsgBox("Ingrese los Apellidos del Cliente", MsgBoxStyle.Critical, "Error")
        ElseIf TxtDireccion.Text = Nothing Then
            MsgBox("Ingrese la Dirección del Cliente", MsgBoxStyle.Critical, "Error")
        ElseIf TxtApellidos.Text = Nothing Then
            MsgBox("Ingrese los Apellidos del Cliente", MsgBoxStyle.Critical, "Error")
        ElseIf CboDia.Text = "Dia" Then
            MsgBox("Ingrese el Dia de Nacimiento del Cliente", MsgBoxStyle.Critical, "Error")
        ElseIf CboMes.Text = "Mes" Then
            MsgBox("Ingrese el Mes de Nacimiento del Cliente", MsgBoxStyle.Critical, "Error")
        ElseIf CboAño.Text = "Año" Then
            MsgBox("Ingrese el Año de Nacimiento del Cliente", MsgBoxStyle.Critical, "Error")
        ElseIf RdbMasculino.Checked = False And RdbFemenino.Checked = False Then
            MsgBox("Ingrese el Sexo del Cliente", MsgBoxStyle.Critical, "Error")
        ElseIf CboMunicipio.SelectedItem = Nothing Then
            MsgBox("Seleccione el Municipio del Cliente", MsgBoxStyle.Critical, "Error")
        ElseIf CboEstadoCivil.Text = Nothing Then
            MsgBox("Ingrese el Estado Civil del Cliente", MsgBoxStyle.Critical, "Error")
        Else

            Try
                Dim datos As New DatosCliente
                Dim funcion As New Fcliente

                datos.gIdCliente = TxtIdCliente.Text
                datos.gNombreCliente = TxtNombres.Text
                datos.gApellidoCliente = TxtApellidos.Text
                datos.gDireccionCliente = TxtDireccion.Text
                datos.gTelefonoCliente = TxtTelefono.Text
                datos.gCorreoCliente = TxtCorreo.Text

                Dim Mes As String

                If CboMes.Text = "Enero" Then
                    Mes = "1"
                ElseIf CboMes.Text = "Febrero" Then
                    Mes = "2"
                ElseIf CboMes.Text = "Marzo" Then
                    Mes = "3"
                ElseIf CboMes.Text = "Abril" Then
                    Mes = "4"
                ElseIf CboMes.Text = "Mayo" Then
                    Mes = "5"
                ElseIf CboMes.Text = "Junio" Then
                    Mes = "6"
                ElseIf CboMes.Text = "Julio" Then
                    Mes = "7"
                ElseIf CboMes.Text = "Agosto" Then
                    Mes = "8"
                ElseIf CboMes.Text = "Septiembre" Then
                    Mes = "9"
                ElseIf CboMes.Text = "Octubre" Then
                    Mes = "10"
                ElseIf CboMes.Text = "Noviembre" Then
                    Mes = "11"
                ElseIf CboMes.Text = "Diciembre" Then
                    Mes = "12"
                End If
                datos.gFechaNacimiento = CboAño.Text & "-" & Mes.ToString & "-" & CboDia.Text

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
                Try
                    cmd = New SqlCommand("Select IdEstadoCivil From EstadoCivil Where EstadoCivil= '" & CboEstadoCivil.Text & "'")
                    cmd.CommandType = CommandType.Text
                    cmd.Connection = Conec.Con
                    Dim dr2 As SqlDataReader
                    dr2 = cmd.ExecuteReader

                    If dr2.Read Then
                        datos.gIdEstadoCivil = dr2(0)
                    End If
                    dr2.Close()
                Catch ex As Exception
                    MsgBox(ex.Message)
                End Try
                If funcion.EditarCliente(datos) Then
                    MsgBox("Cliente Editado con Éxito", MsgBoxStyle.Information)
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
    Private Sub DgvCliente_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles DgvCliente.CellDoubleClick
        If LblRelacionClienteVenta.Text = "1" Then
            FrmVenta.TxtIdCliente.Text = DgvCliente.CurrentRow.Cells(0).Value.ToString
            LblRelacionClienteVenta.Text = "0"
            Me.Close()
        ElseIf LblRelacionClienteVenta.Text = "2" Then
            FrmFacturacionVenta.TxtIdCliente.Text = DgvCliente.CurrentRow.Cells(0).Value.ToString
            LblRelacionClienteVenta.Text = "0"
            Me.Close()

        End If
    End Sub
    Private Sub FrmCliente_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
        LblRelacionClienteVenta.Text = "0"
    End Sub



    Private Sub BtnBusquedaCliente_Click(sender As Object, e As EventArgs) Handles BtnBusquedaCliente.Click
        With FrmMunicipio
            FrmMunicipio.var = 1
            .MdiParent = MenuPrincipal
            .Dock = DockStyle.Fill
            .Show()
        End With
    End Sub

    Private Sub CboMunicipio_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CboMunicipio.SelectedIndexChanged

    End Sub
End Class
