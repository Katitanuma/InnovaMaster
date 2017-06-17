Imports System.Data.SqlClient
Public Class FrmUsuario

    Dim dt As New DataTable
    Dim Conec As New Conexion
    Dim cmd As SqlCommand
    Private Sub FrmUsuario_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CboBusqueda.Text = CboBusqueda.Items(0).ToString
        MostrarUsuario()
        LlenarCombos()
    End Sub
    Private Sub MostrarUsuario()
        Try
            Dim datos As New Fusuario
            dt = datos.MostrarUsuario
            If dt.Rows.Count <> 0 Then
                LblFilas.Visible = False
                DgvUsuario.DataSource = dt
                CboBusqueda.Enabled = True
                TxtBusqueda.Enabled = True
                DgvUsuario.Columns(2).Visible = False
            Else
                LblFilas.Visible = True
                DgvUsuario.DataSource = Nothing
                CboBusqueda.Enabled = False
                TxtBusqueda.Enabled = False
            End If
        Catch ex As Exception

        End Try
    End Sub
    Private Sub DgvUsuario_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DgvUsuario.CellClick
        TxtIdUsuario.Text = DgvUsuario.SelectedCells.Item(0).Value
        TxtUsuario.Text = DgvUsuario.SelectedCells.Item(1).Value
        TxtContra.Text = DgvUsuario.SelectedCells.Item(2).Value
        TxtContra2.Text = DgvUsuario.SelectedCells.Item(2).Value
        CboEmpleado.Text = DgvUsuario.SelectedCells.Item(3).Value
        CboTipoAcceso.Text = DgvUsuario.SelectedCells.Item(4).Value
        LblRespaldo.Text = DgvUsuario.SelectedCells.Item(2).Value
        If DgvUsuario.SelectedCells.Item(5).Value.ToString = "Activo" Then
            RdbActivo.Checked = True
        Else
            RdbInactivo.Checked = True
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
            DgvUsuario.DataSource = dv
            DgvUsuario.Columns(2).Visible = False
        Else
            LblFilas.Visible = True
            DgvUsuario.DataSource = Nothing
        End If



    End Sub
    Private Sub BtnNuevo_Click(sender As Object, e As EventArgs) Handles BtnNuevo.Click
        GbUsuario.Enabled = True
        TxtIdUsuario.Clear()
        TxtUsuario.Clear()
        TxtContra.Clear()
        TxtContra2.Clear()
        CboEmpleado.Text = Nothing
        CboTipoAcceso.Text = Nothing
        BtnCancelar.Visible = True
        BtnInsertar.Visible = True
        BtnNuevoEditar.Visible = False
        BtnNuevo.Visible = False
        DgvUsuario.Enabled = True
        RdbActivo.Checked = True
    End Sub
    Private Sub BtnCancelar_Click(sender As Object, e As EventArgs) Handles BtnCancelar.Click
        Dim r As DialogResult = MessageBox.Show("¿Desea Cancelar el Proceso?", "INNOVAMASTER", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If r = DialogResult.Yes Then
            DgvUsuario.Enabled = True
            GbUsuario.Enabled = False
            TxtIdUsuario.Clear()
            TxtUsuario.Clear()
            TxtContra.Clear()
            TxtContra2.Clear()
            CboEmpleado.Text = Nothing
            CboTipoAcceso.Text = Nothing
            BtnCancelar.Visible = False
            BtnInsertar.Visible = False
            BtnEditar.Visible = False
            BtnNuevoEditar.Visible = True
            BtnNuevo.Visible = True
            ChkVer.Checked = False

        End If


    End Sub
    Private Sub BtnNuevoEditar_Click(sender As Object, e As EventArgs) Handles BtnNuevoEditar.Click
        If TxtIdUsuario.Text <> Nothing Then
            TxtIdUsuario.Enabled = False
            GbUsuario.Enabled = True
            BtnCancelar.Visible = True
            BtnInsertar.Visible = False
            BtnEditar.Visible = True
            BtnNuevo.Visible = False
            BtnNuevoEditar.Visible = False
            DgvUsuario.Enabled = False
            TxtContra.Clear()
            TxtContra2.Clear()
            ChkVer.Checked = False
        Else
            MessageBox.Show("Seleccione el Usuario a Editar", "INNOVAMASTER", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End If


    End Sub
    Private Sub ChkVer_CheckedChanged(sender As Object, e As EventArgs) Handles ChkVer.CheckedChanged
        If ChkVer.Checked = True Then
            TxtContra.UseSystemPasswordChar = False
            TxtContra2.UseSystemPasswordChar = False
        Else
            TxtContra.UseSystemPasswordChar = True
            TxtContra2.UseSystemPasswordChar = True

        End If
    End Sub
    Private Sub BtnInsertar_Click(sender As Object, e As EventArgs) Handles BtnInsertar.Click
        If TxtUsuario.Text = Nothing Then
            MessageBox.Show("Ingrese el Usuario", "INNOVAMASTER", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        ElseIf TxtContra.Text = Nothing Then
            MessageBox.Show("Ingrese la Contraseña", "INNOVAMASTER", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        ElseIf TxtContra2.Text = Nothing Then
            MessageBox.Show("Ingrese la Confirmarcion de la Contraseña", "INNOVAMASTER", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        ElseIf CboEmpleado.Text = Nothing Then
            MessageBox.Show("Seleccione el Empleado", "INNOVAMASTER", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        ElseIf CboTipoAcceso.Text = Nothing Then
            MessageBox.Show("Selecciones el Tipo Acceso", "INNOVAMASTER", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        Else
            Try

                Dim datos As New DatosUsuario
                Dim funcion As New Fusuario
                datos.gUsuario = TxtUsuario.Text
                datos.gContrasena = SHA1(TxtContra.Text)
                datos.gIdEmpleado = CboId.Items(CboEmpleado.SelectedIndex)
                If RdbActivo.Checked = True Then
                    datos.gEstado = "Activo"
                Else
                    datos.gEstado = "Inactivo"
                End If
                Conec.Conectarse()
                Try

                    Dim dr2 As SqlDataReader
                    cmd = New SqlCommand("Select IdTipoAcceso from TipoAcceso Where TipoAcceso= '" & CboTipoAcceso.Text & "'")
                    cmd.CommandType = CommandType.Text
                    cmd.Connection = Conec.Con

                    dr2 = cmd.ExecuteReader

                    If dr2.Read Then
                        datos.gIdTipoAcceso = dr2(0)
                    End If

                    dr2.Close()
                Catch ex As Exception
                    MsgBox(ex.Message)
                End Try
                If funcion.InsertarUsuario(datos) Then
                    MessageBox.Show("Usuario Insertado Con Exito", "INNOVAMASTER", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    GbUsuario.Enabled = False
                    TxtIdUsuario.Clear()
                    TxtUsuario.Clear()
                    TxtContra.Clear()
                    TxtContra2.Clear()
                    CboEmpleado.Text = Nothing
                    CboTipoAcceso.Text = Nothing
                    BtnCancelar.Visible = False
                    BtnInsertar.Visible = False
                    BtnEditar.Visible = False
                    BtnNuevoEditar.Visible = True
                    BtnNuevo.Visible = True
                    DgvUsuario.Enabled = True
                    MostrarUsuario()
                    ChkVer.Checked = False
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
            CboTipoAcceso.Items.Clear()
            CboEmpleado.Items.Clear()
            CboId.Items.Clear()
            Dim dr As SqlDataReader
            cmd = New SqlCommand("Select NombreEmpleado, ApellidoEmpleado,IdEmpleado from Empleado")
            cmd.CommandType = CommandType.Text
            cmd.Connection = Conec.Con

            dr = cmd.ExecuteReader
            If dr.HasRows Then
                While dr.Read
                    CboEmpleado.Items.Add(dr(0).ToString + " " + dr(1).ToString)
                    CboId.Items.Add(dr(2).ToString)
                End While
            End If

            dr.Close()
            Dim dr2 As SqlDataReader
            cmd = New SqlCommand("Select TipoAcceso from TipoAcceso ")
            cmd.CommandType = CommandType.Text
            cmd.Connection = Conec.Con
            dr2 = cmd.ExecuteReader
            If dr2.HasRows Then
                While dr2.Read
                    CboTipoAcceso.Items.Add(dr2(0))
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
        If TxtUsuario.Text = Nothing Then
            MessageBox.Show("Ingrese el Usuario", "INNOVAMASTER", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        ElseIf CboEmpleado.Text = Nothing Then
            MessageBox.Show("Seleccione el Empleado", "INNOVAMASTER", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        ElseIf CboTipoAcceso.Text = Nothing Then
            MessageBox.Show("Selecciones el Tipo Acceso", "INNOVAMASTER", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        ElseIf TxtContra.Text <> TxtContra2.Text Then
            MessageBox.Show("Las Contraseñas no son Iguales", "INNOVAMASTER", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        Else
            Try
                Dim datos As New DatosUsuario
                Dim funcion As New Fusuario
                datos.gIdUsuario = TxtIdUsuario.Text
                datos.gUsuario = TxtUsuario.Text
                If TxtContra.Text = Nothing And TxtContra2.Text = TxtContra.Text Then
                    datos.gContrasena = LblRespaldo.Text
                Else
                    datos.gContrasena = SHA1(TxtContra.Text)
                End If
                datos.gIdEmpleado = CboId.Items(CboEmpleado.SelectedIndex)
                If RdbActivo.Checked = True Then
                    datos.gEstado = "Activo"
                Else
                    datos.gEstado = "Inactivo"
                End If
                Conec.Conectarse()
                Try
                    Dim dr2 As SqlDataReader
                    cmd = New SqlCommand("Select IdTipoAcceso from TipoAcceso Where TipoAcceso= '" & CboTipoAcceso.Text & "'")
                    cmd.CommandType = CommandType.Text
                    cmd.Connection = Conec.Con

                    dr2 = cmd.ExecuteReader

                    If dr2.Read Then
                        datos.gIdTipoAcceso = dr2(0)
                    End If

                    dr2.Close()
                Catch ex As Exception
                    MsgBox(ex.Message)
                End Try

                If funcion.EditarUsuario(datos) Then
                    MessageBox.Show("Usuario Editado Con Exito", "INNOVAMASTER", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    GbUsuario.Enabled = False
                    TxtIdUsuario.Clear()
                    TxtUsuario.Clear()
                    TxtContra.Clear()
                    TxtContra2.Clear()
                    CboEmpleado.Text = Nothing
                    CboTipoAcceso.Text = Nothing
                    BtnCancelar.Visible = False
                    BtnInsertar.Visible = False
                    BtnEditar.Visible = False
                    BtnNuevoEditar.Visible = True
                    BtnNuevo.Visible = True
                    DgvUsuario.Enabled = True
                    MostrarUsuario()
                    ChkVer.Checked = False

                End If

            Catch ex As Exception
                MsgBox(ex.ToString)
            Finally
                Conec.Desconectarse()
            End Try

        End If
    End Sub
    Private Sub CboEmpleado_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CboEmpleado.SelectedIndexChanged
        If TxtContra.Text <> TxtContra2.Text Then
            MessageBox.Show("Las Contraseñas no son Iguales", "INNOVAMASTER", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End If
    End Sub
End Class