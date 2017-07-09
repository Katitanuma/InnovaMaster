Imports System.ComponentModel

Public Class FrmLogin

    Dim Conec As New Conexion


    Private Function Validar() As Boolean
        Dim estado As Boolean
        If TxtUsuario.Text = Nothing And TxtContrasena.Text = Nothing Then
            TxtUsuario.Focus()
            EpMensaje.SetError(TxtUsuario, "Ingrese el Usuario")
            EpMensaje.SetError(TxtContrasena, "Ingrese la Contraseña")
            estado = False
        ElseIf TxtUsuario.Text = Nothing Then
            TxtUsuario.Focus()
            EpMensaje.SetError(TxtUsuario, "Ingrese el Usuario")
            EpMensaje.SetError(TxtContrasena, "")
            estado = False
        ElseIf TxtContrasena.Text = Nothing Then
            TxtContrasena.Focus()
            EpMensaje.SetError(TxtUsuario, "")
            EpMensaje.SetError(TxtContrasena, "Ingrese la Contraseña")
            estado = False
        Else
            EpMensaje.SetError(TxtUsuario, "")
            EpMensaje.SetError(TxtContrasena, "")
            estado = True
        End If
        Return estado
    End Function
    Private Sub FrmLogin_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim cone As New Conexion
        If cone.Conectarse() = False Then
            FrmConfiguracion.Label5.Text = "1"
            FrmConfiguracion.txtUsername.Text = Nothing
            FrmConfiguracion.txtPassword.Text = Nothing
            FrmConfiguracion.txtDB.Text = Nothing
            FrmConfiguracion.txtserver.Text = Nothing
            FrmConfiguracion.Show()
            Me.Close()
            Exit Sub
        End If
        Me.Focus()

        Dim NombreArchivo As String = HTMLHelpClass.GetLocalHelpFileName("InnovaMasterAyuda2017.chm")
        HelpProvider1.HelpNamespace = NombreArchivo

        HelpProvider1.SetHelpNavigator(Me, HelpNavigator.KeywordIndex)
        HelpProvider1.SetHelpKeyword(Me, "Inicio de Sesión")
    End Sub


    Private Sub BtnCerrar_Click(sender As Object, e As EventArgs) Handles BtnCerrar.Click
        Application.Exit()
        My.Settings.Save()
    End Sub

    Private Sub BtnIniciar_Click(sender As Object, e As EventArgs) Handles BtnIniciar.Click
        If Validar() Then
            Try
                Conec.Conectarse()
                Dim dr As SqlClient.SqlDataReader
                Dim cmd As New SqlClient.SqlCommand("Logeo", Conec.Con)
                cmd.CommandType = CommandType.StoredProcedure
                cmd.Parameters.AddWithValue("@Usuario", Replace(TxtUsuario.Text, "'", ""))
                cmd.Parameters.AddWithValue("@Contrasena", Replace(SHA1(TxtContrasena.Text), "'", ""))


                dr = cmd.ExecuteReader
                If dr.Read Then
                    If dr("Estado").ToString = "Activo" Then
                        MenuPrincipal.LblIdUsuario.Text = dr.GetValue(0).ToString
                        If dr.GetValue(1).ToString = "Administrador" Then
                            MenuPrincipal.PagEmpleados.Enabled = True
                            MenuPrincipal.PagUsuarios.Enabled = True
                            MenuPrincipal.PagProductos.Enabled = True
                            MenuPrincipal.PagUbicacion.Enabled = True
                            MenuPrincipal.PagConfiguracion.Enabled = True
                            MenuPrincipal.PgProveedores.Enabled = True
                            MenuPrincipal.PgAuditoria.Visible = True
                            MenuPrincipal.PgCompra.Enabled = True
                            MenuPrincipal.PgPedido.Enabled = True
                        Else
                            MenuPrincipal.PgAuditoria.Visible = False
                            MenuPrincipal.PgCompra.Enabled = False
                            MenuPrincipal.PgPedido.Enabled = False
                            MenuPrincipal.PagEmpleados.Enabled = False
                            MenuPrincipal.PagUsuarios.Enabled = False
                            MenuPrincipal.PagProductos.Enabled = False
                            MenuPrincipal.PagUbicacion.Enabled = False
                            MenuPrincipal.PagConfiguracion.Enabled = False
                            MenuPrincipal.PgProveedores.Enabled = False
                            frmCargo.Close()
                            FrmBackup.Close()
                            FrmConfiguracion.Close()
                            FrmMunicipio.Close()
                            FrmDepartamento.Close()
                            FrmPais.Close()
                            FrmProducto.Close()
                            FrmCategoria.Close()
                            FrmMarca.Close()
                            FrmModelo.Close()
                            FrmUsuario.Close()
                            FrmEmpleado.Close()
                            FrmProfesiones.Close()
                            FrmProveedor.Close()
                        End If

                        Me.Hide()
                        MenuPrincipal.Show()
                    Else
                        MsgBox("Usuario Inactivo", MsgBoxStyle.Exclamation)
                    End If

                Else
                        MsgBox("Usuario o Contraseña No Valido", MsgBoxStyle.Critical)
                End If

            Catch ex As Exception
                MsgBox(ex.ToString)
            End Try
        End If
    End Sub

    Private Sub BtnConfiguracion_Click(sender As Object, e As EventArgs) Handles BtnConfiguracion.Click
        FrmConfiguracion.Show()
    End Sub

    Private Sub ChkVer_CheckedChanged_1(sender As Object, e As EventArgs) Handles ChkVer.CheckedChanged
        If ChkVer.Checked = True Then
            TxtContrasena.UseSystemPasswordChar = False
        Else
            TxtContrasena.UseSystemPasswordChar = True
        End If
    End Sub



    Private Sub TxtContrasena_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TxtContrasena.KeyPress
        If Asc(e.KeyChar) = 13 Then
            BtnIniciar.PerformClick()
        End If
    End Sub
End Class