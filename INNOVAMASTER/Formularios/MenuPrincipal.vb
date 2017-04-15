Imports DevExpress.XtraLayout
Imports DevExpress.XtraLayout.Helpers
Imports System.ComponentModel.DataAnnotations
Imports System.IO
Imports System.ComponentModel

Partial Public Class MenuPrincipal
    Inherits DevExpress.XtraBars.Ribbon.RibbonForm

    Public Sub New()
        InitializeComponent()
    End Sub
    Private Sub MenuPrincipal_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        DevExpress.Skins.SkinManager.EnableMdiFormSkins()
        DevExpress.UserSkins.BonusSkins.Register()

        Panel1.Show()
        Panel1.Location = New Point(490, 245)
        Me.LookAndFeel.SkinName = "Office 2007 Silver"
        Me.DefaultLookAndFeel1.LookAndFeel.SkinName = "Office 2007 Silver"
    End Sub
    Private Sub BarButtonItem1_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BtnRegistroClientes.ItemClick
        Panel1.Visible = False
        FrmCliente.MdiParent = Me
        FrmCliente.Dock = DockStyle.Fill
        FrmCliente.Show()
        FrmCliente.Focus()
    End Sub
    Private Sub BarButtonItem3_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BtnRegistroEmpleado.ItemClick
        Panel1.Visible = False
        FrmEmpleado.MdiParent = Me
        FrmEmpleado.Dock = DockStyle.Fill
        FrmEmpleado.Show()
    End Sub
    Private Sub BarButtonItem5_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BtnRegistroUsuarios.ItemClick
        Panel1.Visible = False
        FrmUsuario.MdiParent = Me
        FrmUsuario.Dock = DockStyle.Fill
        FrmUsuario.Show()
    End Sub
    Private Sub BarButtonItem7_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem7.ItemClick

    End Sub
    Private Sub BarButtonItem9_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem9.ItemClick
        Panel1.Visible = False
        FrmProducto.MdiParent = Me
        FrmProducto.Dock = DockStyle.Fill
        FrmProducto.Show()
    End Sub
    Private Sub BarButtonItem11_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BtnRegistroVenta.ItemClick
        Panel1.Visible = False
        FrmVenta.MdiParent = Me
        FrmVenta.Dock = DockStyle.Fill
        FrmVenta.Show()
    End Sub
    Private Sub BarButtonItem14_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem14.ItemClick

        Panel1.Visible = False
        FrmConfiguracion.ShowDialog()


    End Sub
    Private Sub BarButtonItem15_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem15.ItemClick
        Panel1.Visible = False
        FrmBackup.ShowDialog()
    End Sub
    Private Sub BarButtonItem16_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BtnCambiarUsuario.ItemClick
        Panel1.Visible = False
        FrmLogin.Show()
        FrmLogin.TxtUsuario.Text = Nothing
        FrmLogin.TxtContrasena.Clear()
        FrmLogin.ChkVer.Checked = False
        FrmLogin.TxtUsuario.Focus()

        Me.Hide()

    End Sub


    Private Sub BarButtonItem17_ItemClick_1(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem17.ItemClick
        Panel1.Visible = False
        FrmCategoria.MdiParent = Me
        FrmCategoria.Dock = DockStyle.Fill
        FrmCategoria.Show()
    End Sub

    Private Sub BarButtonItem18_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem18.ItemClick
        Panel1.Visible = False
        FrmPais.MdiParent = Me
        FrmPais.Dock = DockStyle.Fill
        FrmPais.Show()
    End Sub

    Private Sub BarButtonItem19_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem19.ItemClick
        Panel1.Visible = False
        FrmDepartamento.MdiParent = Me
        FrmDepartamento.Dock = DockStyle.Fill
        FrmDepartamento.Show()
    End Sub

    Private Sub BarButtonItem20_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem20.ItemClick
        Panel1.Visible = False
        FrmMunicipio.MdiParent = Me
        FrmMunicipio.Dock = DockStyle.Fill
        FrmMunicipio.Show()
    End Sub

    Private Sub BarButtonItem22_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BtnCargo.ItemClick
        Panel1.Visible = False
        frmCargo.MdiParent = Me
        frmCargo.Dock = DockStyle.Fill
        frmCargo.Show()
    End Sub

    Private Sub BarButtonItem21_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BtnProfesion.ItemClick
        Panel1.Visible = False
        FrmProfesiones.MdiParent = Me
        FrmProfesiones.Dock = DockStyle.Fill
        FrmProfesiones.Show()
    End Sub

    Private Sub BarButtonItem23_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem23.ItemClick
        Panel1.Visible = False
        FrmMarca.MdiParent = Me
        FrmMarca.Dock = DockStyle.Fill
        FrmMarca.Show()
    End Sub

    Private Sub BarButtonItem24_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem24.ItemClick
        Panel1.Visible = False
        FrmModelo.MdiParent = Me
        FrmModelo.Dock = DockStyle.Fill
        FrmModelo.Show()
    End Sub

    Private Sub MenuPrincipal_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing

        If EstaAbierto(FrmDetalleVenta) Then
            FrmDetalleVenta.Button1.PerformClick()
            e.Cancel = True
        ElseIf EstaAbierto(FrmCompras) Then
            FrmCompras.Button1.PerformClick()
            e.Cancel = True
        ElseIf EstaAbierto(FrmPedidos) Then
            FrmPedidos.Button1.PerformClick()
            e.Cancel = True
        ElseIf MessageBox.Show("¿Desea Salir del Sistema?", "INNOVAMASTER", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) = DialogResult.No Then
            e.Cancel = True
        Else

            Application.Exit()
        End If


    End Sub
    Public Function EstaAbierto(ByVal Myform As Form)
        Dim objForm As Form
        Dim blnAbierto As Boolean = False
        blnAbierto = False
        For Each objForm In My.Application.OpenForms
            If (Trim(objForm.Name) = Trim(Myform.Name)) Then
                blnAbierto = True
            End If
        Next
        Return blnAbierto
    End Function

    Private Sub BtnF_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BtnF.ItemClick
        Panel1.Visible = False
        FrmFacturacionVenta.MdiParent = Me
        FrmFacturacionVenta.Dock = DockStyle.Fill
        FrmFacturacionVenta.Show()
    End Sub

    Private Sub BarButtonItem1_ItemClick_1(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem1.ItemClick
        Panel1.Visible = False
        FrmProveedor.MdiParent = Me
        FrmProveedor.Dock = DockStyle.Fill
        FrmProveedor.Show()
    End Sub

    Private Sub BarButtonItem3_ItemClick_1(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem3.ItemClick
        Panel1.Visible = False
        FrmCompras.MdiParent = Me
        FrmCompras.Dock = DockStyle.Fill
        FrmCompras.Show()
    End Sub



    Private Sub BarButtonItem6_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem6.ItemClick
        Panel1.Visible = False
        FrmPedidos.MdiParent = Me
        FrmPedidos.Dock = DockStyle.Fill
        FrmPedidos.Show()
    End Sub

    Private Sub BarButtonItem2_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem2.ItemClick
        Panel1.Visible = False
        ReporteClientes.Show()
    End Sub

    Private Sub BarButtonItem21_ItemClick_1(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem21.ItemClick
        Panel1.Visible = False
        ReportePedido.Show()
    End Sub

    Private Sub BarButtonItem16_ItemClick_1(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem16.ItemClick
        Panel1.Visible = False
        ReporteCompras.Show()
    End Sub

    Private Sub BarButtonItem22_ItemClick_1(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem22.ItemClick
        Panel1.Visible = False
        ReporteVentas.Show()
    End Sub

    Private Sub BarButtonItem11_ItemClick_1(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem11.ItemClick
        Panel1.Visible = False
        ReporteProductos.Show()
    End Sub
End Class
