Partial Public Class MenuPrincipal
    ''' <summary>
    ''' Required designer variable.
    ''' </summary>
    Private components As System.ComponentModel.IContainer = Nothing

    ''' <summary>
    ''' Clean up any resources being used.
    ''' </summary>
    ''' <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing AndAlso (components IsNot Nothing) Then
            components.Dispose()
        End If
        MyBase.Dispose(disposing)
    End Sub

#Region "Windows Form Designer generated code"

    ''' <summary>
    ''' Required method for Designer support - do not modify
    ''' the contents of this method with the code editor.
    ''' </summary>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MenuPrincipal))
        Me.mainRibbonControl = New DevExpress.XtraBars.Ribbon.RibbonControl()
        Me.bbiSave = New DevExpress.XtraBars.BarButtonItem()
        Me.bbiSaveAndClose = New DevExpress.XtraBars.BarButtonItem()
        Me.bbiSaveAndNew = New DevExpress.XtraBars.BarButtonItem()
        Me.bbiReset = New DevExpress.XtraBars.BarButtonItem()
        Me.bbiDelete = New DevExpress.XtraBars.BarButtonItem()
        Me.bbiClose = New DevExpress.XtraBars.BarButtonItem()
        Me.BtnRegistroClientes = New DevExpress.XtraBars.BarButtonItem()
        Me.BarButtonItem2 = New DevExpress.XtraBars.BarButtonItem()
        Me.BtnRegistroEmpleado = New DevExpress.XtraBars.BarButtonItem()
        Me.BarButtonItem4 = New DevExpress.XtraBars.BarButtonItem()
        Me.BtnRegistroUsuarios = New DevExpress.XtraBars.BarButtonItem()
        Me.BtnReportesUsuarios = New DevExpress.XtraBars.BarButtonItem()
        Me.BarButtonItem7 = New DevExpress.XtraBars.BarButtonItem()
        Me.BarButtonItem8 = New DevExpress.XtraBars.BarButtonItem()
        Me.BarButtonItem9 = New DevExpress.XtraBars.BarButtonItem()
        Me.BarButtonItem10 = New DevExpress.XtraBars.BarButtonItem()
        Me.BtnRegistroVenta = New DevExpress.XtraBars.BarButtonItem()
        Me.BarButtonItem12 = New DevExpress.XtraBars.BarButtonItem()
        Me.BarButtonItem13 = New DevExpress.XtraBars.BarButtonItem()
        Me.BarButtonItem14 = New DevExpress.XtraBars.BarButtonItem()
        Me.BarButtonItem15 = New DevExpress.XtraBars.BarButtonItem()
        Me.BtnCambiarUsuario = New DevExpress.XtraBars.BarButtonItem()
        Me.BarButtonItem17 = New DevExpress.XtraBars.BarButtonItem()
        Me.BarButtonItem18 = New DevExpress.XtraBars.BarButtonItem()
        Me.BarButtonItem19 = New DevExpress.XtraBars.BarButtonItem()
        Me.BarButtonItem20 = New DevExpress.XtraBars.BarButtonItem()
        Me.BtnProfesion = New DevExpress.XtraBars.BarButtonItem()
        Me.BtnCargo = New DevExpress.XtraBars.BarButtonItem()
        Me.BarButtonItem23 = New DevExpress.XtraBars.BarButtonItem()
        Me.BarButtonItem24 = New DevExpress.XtraBars.BarButtonItem()
        Me.BtnF = New DevExpress.XtraBars.BarButtonItem()
        Me.BarButtonItem1 = New DevExpress.XtraBars.BarButtonItem()
        Me.BarButtonItem3 = New DevExpress.XtraBars.BarButtonItem()
        Me.BarButtonItem5 = New DevExpress.XtraBars.BarButtonItem()
        Me.BarButtonItem6 = New DevExpress.XtraBars.BarButtonItem()
        Me.BarButtonItem11 = New DevExpress.XtraBars.BarButtonItem()
        Me.BarButtonItem16 = New DevExpress.XtraBars.BarButtonItem()
        Me.BarButtonItem21 = New DevExpress.XtraBars.BarButtonItem()
        Me.BarButtonItem22 = New DevExpress.XtraBars.BarButtonItem()
        Me.mainRibbonPage = New DevExpress.XtraBars.Ribbon.RibbonPage()
        Me.mainRibbonPageGroup = New DevExpress.XtraBars.Ribbon.RibbonPageGroup()
        Me.RibbonPage6 = New DevExpress.XtraBars.Ribbon.RibbonPage()
        Me.RibbonPageGroup6 = New DevExpress.XtraBars.Ribbon.RibbonPageGroup()
        Me.RibbonPage1 = New DevExpress.XtraBars.Ribbon.RibbonPage()
        Me.RibbonPageGroup1 = New DevExpress.XtraBars.Ribbon.RibbonPageGroup()
        Me.RibbonPage2 = New DevExpress.XtraBars.Ribbon.RibbonPage()
        Me.PagEmpleados = New DevExpress.XtraBars.Ribbon.RibbonPageGroup()
        Me.RibbonPage3 = New DevExpress.XtraBars.Ribbon.RibbonPage()
        Me.PagUsuarios = New DevExpress.XtraBars.Ribbon.RibbonPageGroup()
        Me.RibbonPage5 = New DevExpress.XtraBars.Ribbon.RibbonPage()
        Me.PagProductos = New DevExpress.XtraBars.Ribbon.RibbonPageGroup()
        Me.RibbonPage9 = New DevExpress.XtraBars.Ribbon.RibbonPage()
        Me.RibbonPageGroup2 = New DevExpress.XtraBars.Ribbon.RibbonPageGroup()
        Me.RibbonPage10 = New DevExpress.XtraBars.Ribbon.RibbonPage()
        Me.RibbonPageGroup4 = New DevExpress.XtraBars.Ribbon.RibbonPageGroup()
        Me.RibbonPage4 = New DevExpress.XtraBars.Ribbon.RibbonPage()
        Me.PgProveedores = New DevExpress.XtraBars.Ribbon.RibbonPageGroup()
        Me.RibbonPage8 = New DevExpress.XtraBars.Ribbon.RibbonPage()
        Me.PagUbicacion = New DevExpress.XtraBars.Ribbon.RibbonPageGroup()
        Me.RibbonPage7 = New DevExpress.XtraBars.Ribbon.RibbonPage()
        Me.PagConfiguracion = New DevExpress.XtraBars.Ribbon.RibbonPageGroup()
        Me.DefaultLookAndFeel1 = New DevExpress.LookAndFeel.DefaultLookAndFeel(Me.components)
        Me.Label1 = New System.Windows.Forms.Label()
        Me.LblIdUsuario = New System.Windows.Forms.Label()
        Me.RibbonPageGroup3 = New DevExpress.XtraBars.Ribbon.RibbonPageGroup()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.RibbonPage11 = New DevExpress.XtraBars.Ribbon.RibbonPage()
        Me.BarManager1 = New DevExpress.XtraBars.BarManager(Me.components)
        Me.barDockControlTop = New DevExpress.XtraBars.BarDockControl()
        Me.barDockControlBottom = New DevExpress.XtraBars.BarDockControl()
        Me.barDockControlLeft = New DevExpress.XtraBars.BarDockControl()
        Me.barDockControlRight = New DevExpress.XtraBars.BarDockControl()
        Me.RibbonPageGroup5 = New DevExpress.XtraBars.Ribbon.RibbonPageGroup()
        Me.BarButtonItem25 = New DevExpress.XtraBars.BarButtonItem()
        CType(Me.mainRibbonControl, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BarManager1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'mainRibbonControl
        '
        Me.mainRibbonControl.ExpandCollapseItem.Id = 0
        Me.mainRibbonControl.Items.AddRange(New DevExpress.XtraBars.BarItem() {Me.mainRibbonControl.ExpandCollapseItem, Me.bbiSave, Me.bbiSaveAndClose, Me.bbiSaveAndNew, Me.bbiReset, Me.bbiDelete, Me.bbiClose, Me.BtnRegistroClientes, Me.BarButtonItem2, Me.BtnRegistroEmpleado, Me.BarButtonItem4, Me.BtnRegistroUsuarios, Me.BtnReportesUsuarios, Me.BarButtonItem7, Me.BarButtonItem8, Me.BarButtonItem9, Me.BarButtonItem10, Me.BtnRegistroVenta, Me.BarButtonItem12, Me.BarButtonItem13, Me.BarButtonItem14, Me.BarButtonItem15, Me.BtnCambiarUsuario, Me.BarButtonItem17, Me.BarButtonItem18, Me.BarButtonItem19, Me.BarButtonItem20, Me.BtnProfesion, Me.BtnCargo, Me.BarButtonItem23, Me.BarButtonItem24, Me.BtnF, Me.BarButtonItem1, Me.BarButtonItem3, Me.BarButtonItem5, Me.BarButtonItem6, Me.BarButtonItem11, Me.BarButtonItem16, Me.BarButtonItem21, Me.BarButtonItem22, Me.BarButtonItem25})
        Me.mainRibbonControl.Location = New System.Drawing.Point(0, 0)
        Me.mainRibbonControl.MaxItemId = 44
        Me.mainRibbonControl.Name = "mainRibbonControl"
        Me.mainRibbonControl.Pages.AddRange(New DevExpress.XtraBars.Ribbon.RibbonPage() {Me.mainRibbonPage, Me.RibbonPage6, Me.RibbonPage1, Me.RibbonPage2, Me.RibbonPage3, Me.RibbonPage5, Me.RibbonPage9, Me.RibbonPage10, Me.RibbonPage4, Me.RibbonPage8, Me.RibbonPage7, Me.RibbonPage11})
        Me.mainRibbonControl.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonControlStyle.Office2013
        Me.mainRibbonControl.ShowApplicationButton = DevExpress.Utils.DefaultBoolean.[False]
        Me.mainRibbonControl.Size = New System.Drawing.Size(798, 147)
        Me.mainRibbonControl.ToolbarLocation = DevExpress.XtraBars.Ribbon.RibbonQuickAccessToolbarLocation.Hidden
        '
        'bbiSave
        '
        Me.bbiSave.Caption = "Save"
        Me.bbiSave.Id = 2
        Me.bbiSave.ImageUri.Uri = "Save"
        Me.bbiSave.Name = "bbiSave"
        '
        'bbiSaveAndClose
        '
        Me.bbiSaveAndClose.Caption = "Save And Close"
        Me.bbiSaveAndClose.Id = 3
        Me.bbiSaveAndClose.ImageUri.Uri = "SaveAndClose"
        Me.bbiSaveAndClose.Name = "bbiSaveAndClose"
        '
        'bbiSaveAndNew
        '
        Me.bbiSaveAndNew.Caption = "Save And New"
        Me.bbiSaveAndNew.Id = 4
        Me.bbiSaveAndNew.ImageUri.Uri = "SaveAndNew"
        Me.bbiSaveAndNew.Name = "bbiSaveAndNew"
        '
        'bbiReset
        '
        Me.bbiReset.Caption = "Reset Changes"
        Me.bbiReset.Id = 5
        Me.bbiReset.ImageUri.Uri = "Reset"
        Me.bbiReset.Name = "bbiReset"
        '
        'bbiDelete
        '
        Me.bbiDelete.Caption = "Delete"
        Me.bbiDelete.Id = 6
        Me.bbiDelete.ImageUri.Uri = "Delete"
        Me.bbiDelete.Name = "bbiDelete"
        '
        'bbiClose
        '
        Me.bbiClose.Caption = "Close"
        Me.bbiClose.Id = 7
        Me.bbiClose.ImageUri.Uri = "Close"
        Me.bbiClose.Name = "bbiClose"
        '
        'BtnRegistroClientes
        '
        Me.BtnRegistroClientes.Caption = "Registro Clientes"
        Me.BtnRegistroClientes.Id = 10
        Me.BtnRegistroClientes.LargeGlyph = Global.INNOVAMASTER.My.Resources.Resources.user
        Me.BtnRegistroClientes.Name = "BtnRegistroClientes"
        '
        'BarButtonItem2
        '
        Me.BarButtonItem2.Caption = "Reporte Clientes"
        Me.BarButtonItem2.Id = 11
        Me.BarButtonItem2.ImageUri.Uri = "Chart"
        Me.BarButtonItem2.Name = "BarButtonItem2"
        '
        'BtnRegistroEmpleado
        '
        Me.BtnRegistroEmpleado.Caption = "Registro Empleados"
        Me.BtnRegistroEmpleado.Id = 12
        Me.BtnRegistroEmpleado.LargeGlyph = Global.INNOVAMASTER.My.Resources.Resources._2
        Me.BtnRegistroEmpleado.Name = "BtnRegistroEmpleado"
        '
        'BarButtonItem4
        '
        Me.BarButtonItem4.Caption = "Cargo"
        Me.BarButtonItem4.Id = 13
        Me.BarButtonItem4.ImageUri.Uri = "Chart"
        Me.BarButtonItem4.LargeGlyph = Global.INNOVAMASTER.My.Resources.Resources._3
        Me.BarButtonItem4.Name = "BarButtonItem4"
        '
        'BtnRegistroUsuarios
        '
        Me.BtnRegistroUsuarios.Caption = "Registro Usuarios"
        Me.BtnRegistroUsuarios.Id = 14
        Me.BtnRegistroUsuarios.LargeGlyph = Global.INNOVAMASTER.My.Resources.Resources.users
        Me.BtnRegistroUsuarios.Name = "BtnRegistroUsuarios"
        '
        'BtnReportesUsuarios
        '
        Me.BtnReportesUsuarios.Caption = "Reportes Usuarios"
        Me.BtnReportesUsuarios.Id = 15
        Me.BtnReportesUsuarios.ImageUri.Uri = "Chart"
        Me.BtnReportesUsuarios.Name = "BtnReportesUsuarios"
        '
        'BarButtonItem7
        '
        Me.BarButtonItem7.Caption = "Registro Proveedores"
        Me.BarButtonItem7.Id = 16
        Me.BarButtonItem7.ImageUri.Uri = "CustomizeGrid"
        Me.BarButtonItem7.Name = "BarButtonItem7"
        '
        'BarButtonItem8
        '
        Me.BarButtonItem8.Caption = "Reportes Proveedores"
        Me.BarButtonItem8.Id = 17
        Me.BarButtonItem8.ImageUri.Uri = "Chart"
        Me.BarButtonItem8.Name = "BarButtonItem8"
        '
        'BarButtonItem9
        '
        Me.BarButtonItem9.Caption = "Registro Productos"
        Me.BarButtonItem9.Id = 18
        Me.BarButtonItem9.LargeGlyph = Global.INNOVAMASTER.My.Resources.Resources.WhatsApp_Image_2017_03_10_at_6311
        Me.BarButtonItem9.Name = "BarButtonItem9"
        '
        'BarButtonItem10
        '
        Me.BarButtonItem10.Caption = "Marca"
        Me.BarButtonItem10.Id = 19
        Me.BarButtonItem10.ImageUri.Uri = "Chart"
        Me.BarButtonItem10.Name = "BarButtonItem10"
        '
        'BtnRegistroVenta
        '
        Me.BtnRegistroVenta.Caption = "Registro de Ventas"
        Me.BtnRegistroVenta.Id = 20
        Me.BtnRegistroVenta.LargeGlyph = Global.INNOVAMASTER.My.Resources.Resources.factur
        Me.BtnRegistroVenta.Name = "BtnRegistroVenta"
        '
        'BarButtonItem12
        '
        Me.BarButtonItem12.Caption = "Detalle Venta"
        Me.BarButtonItem12.Id = 21
        Me.BarButtonItem12.ImageUri.Uri = "Edit"
        Me.BarButtonItem12.Name = "BarButtonItem12"
        '
        'BarButtonItem13
        '
        Me.BarButtonItem13.Caption = "BarButtonItem13"
        Me.BarButtonItem13.Id = 22
        Me.BarButtonItem13.Name = "BarButtonItem13"
        '
        'BarButtonItem14
        '
        Me.BarButtonItem14.Caption = "Servidor"
        Me.BarButtonItem14.Id = 23
        Me.BarButtonItem14.LargeGlyph = Global.INNOVAMASTER.My.Resources.Resources.base_de_datos
        Me.BarButtonItem14.Name = "BarButtonItem14"
        '
        'BarButtonItem15
        '
        Me.BarButtonItem15.Caption = "Raspaldo Base de Datos"
        Me.BarButtonItem15.Id = 24
        Me.BarButtonItem15.LargeGlyph = Global.INNOVAMASTER.My.Resources.Resources.backup
        Me.BarButtonItem15.Name = "BarButtonItem15"
        '
        'BtnCambiarUsuario
        '
        Me.BtnCambiarUsuario.Caption = "Cambiar Usuario"
        Me.BtnCambiarUsuario.Id = 25
        Me.BtnCambiarUsuario.LargeGlyph = Global.INNOVAMASTER.My.Resources.Resources.cambiar_de_usuario
        Me.BtnCambiarUsuario.Name = "BtnCambiarUsuario"
        '
        'BarButtonItem17
        '
        Me.BarButtonItem17.Caption = "Categoría"
        Me.BarButtonItem17.Id = 26
        Me.BarButtonItem17.LargeGlyph = Global.INNOVAMASTER.My.Resources.Resources.image52
        Me.BarButtonItem17.Name = "BarButtonItem17"
        '
        'BarButtonItem18
        '
        Me.BarButtonItem18.Caption = "País"
        Me.BarButtonItem18.Id = 27
        Me.BarButtonItem18.LargeGlyph = Global.INNOVAMASTER.My.Resources.Resources._03a_photo_NewsBriefs2
        Me.BarButtonItem18.Name = "BarButtonItem18"
        '
        'BarButtonItem19
        '
        Me.BarButtonItem19.Caption = "Departamento"
        Me.BarButtonItem19.Id = 28
        Me.BarButtonItem19.LargeGlyph = Global.INNOVAMASTER.My.Resources.Resources.Francisco_Morazan
        Me.BarButtonItem19.Name = "BarButtonItem19"
        '
        'BarButtonItem20
        '
        Me.BarButtonItem20.Caption = "Municipio"
        Me.BarButtonItem20.Id = 29
        Me.BarButtonItem20.LargeGlyph = Global.INNOVAMASTER.My.Resources.Resources.aguascalientes
        Me.BarButtonItem20.Name = "BarButtonItem20"
        '
        'BtnProfesion
        '
        Me.BtnProfesion.Caption = "Profesión"
        Me.BtnProfesion.Id = 30
        Me.BtnProfesion.LargeGlyph = Global.INNOVAMASTER.My.Resources.Resources.egresado1
        Me.BtnProfesion.Name = "BtnProfesion"
        '
        'BtnCargo
        '
        Me.BtnCargo.Caption = "Cargo"
        Me.BtnCargo.Id = 31
        Me.BtnCargo.LargeGlyph = Global.INNOVAMASTER.My.Resources.Resources._3
        Me.BtnCargo.Name = "BtnCargo"
        '
        'BarButtonItem23
        '
        Me.BarButtonItem23.Caption = "Marca"
        Me.BarButtonItem23.Id = 32
        Me.BarButtonItem23.LargeGlyph = Global.INNOVAMASTER.My.Resources.Resources.box1
        Me.BarButtonItem23.Name = "BarButtonItem23"
        '
        'BarButtonItem24
        '
        Me.BarButtonItem24.Caption = "Modelo"
        Me.BarButtonItem24.Id = 33
        Me.BarButtonItem24.LargeGlyph = Global.INNOVAMASTER.My.Resources.Resources.product_icon1
        Me.BarButtonItem24.Name = "BarButtonItem24"
        '
        'BtnF
        '
        Me.BtnF.Caption = "Facturación"
        Me.BtnF.Id = 34
        Me.BtnF.LargeGlyph = Global.INNOVAMASTER.My.Resources.Resources.electronic_billing_machine_256
        Me.BtnF.Name = "BtnF"
        '
        'BarButtonItem1
        '
        Me.BarButtonItem1.Caption = "Registro Proveedores"
        Me.BarButtonItem1.Id = 35
        Me.BarButtonItem1.LargeGlyph = Global.INNOVAMASTER.My.Resources.Resources.user
        Me.BarButtonItem1.Name = "BarButtonItem1"
        '
        'BarButtonItem3
        '
        Me.BarButtonItem3.Caption = "Registro de Compras"
        Me.BarButtonItem3.Id = 36
        Me.BarButtonItem3.LargeGlyph = Global.INNOVAMASTER.My.Resources.Resources.f15039a22a397b8d72599899f10c9cbd1
        Me.BarButtonItem3.Name = "BarButtonItem3"
        '
        'BarButtonItem5
        '
        Me.BarButtonItem5.Caption = "Registro de Pedidos"
        Me.BarButtonItem5.Id = 37
        Me.BarButtonItem5.LargeGlyph = Global.INNOVAMASTER.My.Resources.Resources.ef469d7feb7cd58c486a7d18c52245e7
        Me.BarButtonItem5.Name = "BarButtonItem5"
        '
        'BarButtonItem6
        '
        Me.BarButtonItem6.Caption = "Registro de Pedidos"
        Me.BarButtonItem6.Id = 38
        Me.BarButtonItem6.LargeGlyph = Global.INNOVAMASTER.My.Resources.Resources.ef469d7feb7cd58c486a7d18c52245e7
        Me.BarButtonItem6.Name = "BarButtonItem6"
        '
        'BarButtonItem11
        '
        Me.BarButtonItem11.Caption = "Reporte Productos"
        Me.BarButtonItem11.Glyph = CType(resources.GetObject("BarButtonItem11.Glyph"), System.Drawing.Image)
        Me.BarButtonItem11.Id = 39
        Me.BarButtonItem11.LargeGlyph = CType(resources.GetObject("BarButtonItem11.LargeGlyph"), System.Drawing.Image)
        Me.BarButtonItem11.Name = "BarButtonItem11"
        '
        'BarButtonItem16
        '
        Me.BarButtonItem16.Caption = "Reporte Compras"
        Me.BarButtonItem16.Glyph = CType(resources.GetObject("BarButtonItem16.Glyph"), System.Drawing.Image)
        Me.BarButtonItem16.Id = 40
        Me.BarButtonItem16.LargeGlyph = CType(resources.GetObject("BarButtonItem16.LargeGlyph"), System.Drawing.Image)
        Me.BarButtonItem16.Name = "BarButtonItem16"
        '
        'BarButtonItem21
        '
        Me.BarButtonItem21.Caption = "Reporte Pedidos"
        Me.BarButtonItem21.Glyph = CType(resources.GetObject("BarButtonItem21.Glyph"), System.Drawing.Image)
        Me.BarButtonItem21.Id = 41
        Me.BarButtonItem21.LargeGlyph = CType(resources.GetObject("BarButtonItem21.LargeGlyph"), System.Drawing.Image)
        Me.BarButtonItem21.Name = "BarButtonItem21"
        '
        'BarButtonItem22
        '
        Me.BarButtonItem22.Caption = "Reporte Ventas"
        Me.BarButtonItem22.Glyph = CType(resources.GetObject("BarButtonItem22.Glyph"), System.Drawing.Image)
        Me.BarButtonItem22.Id = 42
        Me.BarButtonItem22.LargeGlyph = CType(resources.GetObject("BarButtonItem22.LargeGlyph"), System.Drawing.Image)
        Me.BarButtonItem22.Name = "BarButtonItem22"
        '
        'mainRibbonPage
        '
        Me.mainRibbonPage.Groups.AddRange(New DevExpress.XtraBars.Ribbon.RibbonPageGroup() {Me.mainRibbonPageGroup})
        Me.mainRibbonPage.MergeOrder = 0
        Me.mainRibbonPage.Name = "mainRibbonPage"
        Me.mainRibbonPage.Text = "Archivo"
        '
        'mainRibbonPageGroup
        '
        Me.mainRibbonPageGroup.AllowTextClipping = False
        Me.mainRibbonPageGroup.ItemLinks.Add(Me.BtnCambiarUsuario)
        Me.mainRibbonPageGroup.Name = "mainRibbonPageGroup"
        Me.mainRibbonPageGroup.ShowCaptionButton = False
        Me.mainRibbonPageGroup.Text = "Tareas"
        '
        'RibbonPage6
        '
        Me.RibbonPage6.Groups.AddRange(New DevExpress.XtraBars.Ribbon.RibbonPageGroup() {Me.RibbonPageGroup6})
        Me.RibbonPage6.Name = "RibbonPage6"
        Me.RibbonPage6.Text = "Ventas"
        '
        'RibbonPageGroup6
        '
        Me.RibbonPageGroup6.ItemLinks.Add(Me.BtnF)
        Me.RibbonPageGroup6.ItemLinks.Add(Me.BtnRegistroVenta)
        Me.RibbonPageGroup6.ItemLinks.Add(Me.BarButtonItem22)
        Me.RibbonPageGroup6.Name = "RibbonPageGroup6"
        Me.RibbonPageGroup6.Text = "Acciones"
        '
        'RibbonPage1
        '
        Me.RibbonPage1.Groups.AddRange(New DevExpress.XtraBars.Ribbon.RibbonPageGroup() {Me.RibbonPageGroup1})
        Me.RibbonPage1.Name = "RibbonPage1"
        Me.RibbonPage1.Text = "Clientes"
        '
        'RibbonPageGroup1
        '
        Me.RibbonPageGroup1.ItemLinks.Add(Me.BtnRegistroClientes)
        Me.RibbonPageGroup1.ItemLinks.Add(Me.BarButtonItem2)
        Me.RibbonPageGroup1.Name = "RibbonPageGroup1"
        Me.RibbonPageGroup1.Text = "Acciones"
        '
        'RibbonPage2
        '
        Me.RibbonPage2.Groups.AddRange(New DevExpress.XtraBars.Ribbon.RibbonPageGroup() {Me.PagEmpleados})
        Me.RibbonPage2.Name = "RibbonPage2"
        Me.RibbonPage2.Text = "Empleados"
        '
        'PagEmpleados
        '
        Me.PagEmpleados.ItemLinks.Add(Me.BtnRegistroEmpleado)
        Me.PagEmpleados.ItemLinks.Add(Me.BtnCargo)
        Me.PagEmpleados.ItemLinks.Add(Me.BtnProfesion)
        Me.PagEmpleados.Name = "PagEmpleados"
        Me.PagEmpleados.Text = "Acciones"
        '
        'RibbonPage3
        '
        Me.RibbonPage3.Groups.AddRange(New DevExpress.XtraBars.Ribbon.RibbonPageGroup() {Me.PagUsuarios})
        Me.RibbonPage3.Name = "RibbonPage3"
        Me.RibbonPage3.Text = "Usuarios"
        '
        'PagUsuarios
        '
        Me.PagUsuarios.ItemLinks.Add(Me.BtnRegistroUsuarios)
        Me.PagUsuarios.Name = "PagUsuarios"
        Me.PagUsuarios.Text = "Acciones"
        '
        'RibbonPage5
        '
        Me.RibbonPage5.Groups.AddRange(New DevExpress.XtraBars.Ribbon.RibbonPageGroup() {Me.PagProductos})
        Me.RibbonPage5.Name = "RibbonPage5"
        Me.RibbonPage5.Text = "Productos"
        '
        'PagProductos
        '
        Me.PagProductos.ItemLinks.Add(Me.BarButtonItem9)
        Me.PagProductos.ItemLinks.Add(Me.BarButtonItem17)
        Me.PagProductos.ItemLinks.Add(Me.BarButtonItem23)
        Me.PagProductos.ItemLinks.Add(Me.BarButtonItem24)
        Me.PagProductos.ItemLinks.Add(Me.BarButtonItem11)
        Me.PagProductos.Name = "PagProductos"
        Me.PagProductos.Text = "Acciones"
        '
        'RibbonPage9
        '
        Me.RibbonPage9.Groups.AddRange(New DevExpress.XtraBars.Ribbon.RibbonPageGroup() {Me.RibbonPageGroup2})
        Me.RibbonPage9.Name = "RibbonPage9"
        Me.RibbonPage9.Text = "Compras"
        '
        'RibbonPageGroup2
        '
        Me.RibbonPageGroup2.ItemLinks.Add(Me.BarButtonItem3)
        Me.RibbonPageGroup2.ItemLinks.Add(Me.BarButtonItem16)
        Me.RibbonPageGroup2.Name = "RibbonPageGroup2"
        Me.RibbonPageGroup2.Text = "Acciones"
        '
        'RibbonPage10
        '
        Me.RibbonPage10.Groups.AddRange(New DevExpress.XtraBars.Ribbon.RibbonPageGroup() {Me.RibbonPageGroup4})
        Me.RibbonPage10.Name = "RibbonPage10"
        Me.RibbonPage10.Text = "Pedidos"
        '
        'RibbonPageGroup4
        '
        Me.RibbonPageGroup4.ItemLinks.Add(Me.BarButtonItem6)
        Me.RibbonPageGroup4.ItemLinks.Add(Me.BarButtonItem21)
        Me.RibbonPageGroup4.Name = "RibbonPageGroup4"
        Me.RibbonPageGroup4.Text = "Acciones"
        '
        'RibbonPage4
        '
        Me.RibbonPage4.Groups.AddRange(New DevExpress.XtraBars.Ribbon.RibbonPageGroup() {Me.PgProveedores})
        Me.RibbonPage4.Name = "RibbonPage4"
        Me.RibbonPage4.Text = "Proveedores"
        '
        'PgProveedores
        '
        Me.PgProveedores.ItemLinks.Add(Me.BarButtonItem1)
        Me.PgProveedores.Name = "PgProveedores"
        Me.PgProveedores.Text = "Acciones"
        '
        'RibbonPage8
        '
        Me.RibbonPage8.Groups.AddRange(New DevExpress.XtraBars.Ribbon.RibbonPageGroup() {Me.PagUbicacion})
        Me.RibbonPage8.Name = "RibbonPage8"
        Me.RibbonPage8.Text = "Ubicación"
        '
        'PagUbicacion
        '
        Me.PagUbicacion.ItemLinks.Add(Me.BarButtonItem18)
        Me.PagUbicacion.ItemLinks.Add(Me.BarButtonItem19)
        Me.PagUbicacion.ItemLinks.Add(Me.BarButtonItem20)
        Me.PagUbicacion.Name = "PagUbicacion"
        Me.PagUbicacion.Text = "Acciones"
        '
        'RibbonPage7
        '
        Me.RibbonPage7.Groups.AddRange(New DevExpress.XtraBars.Ribbon.RibbonPageGroup() {Me.PagConfiguracion})
        Me.RibbonPage7.Name = "RibbonPage7"
        Me.RibbonPage7.Text = "Configuración"
        '
        'PagConfiguracion
        '
        Me.PagConfiguracion.ItemLinks.Add(Me.BarButtonItem14)
        Me.PagConfiguracion.ItemLinks.Add(Me.BarButtonItem15)
        Me.PagConfiguracion.Name = "PagConfiguracion"
        Me.PagConfiguracion.Text = "Acciones"
        '
        'DefaultLookAndFeel1
        '
        Me.DefaultLookAndFeel1.LookAndFeel.SkinName = "Office 2007 Silver"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Location = New System.Drawing.Point(620, 64)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(80, 13)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Usuario Actual:"
        Me.Label1.Visible = False
        '
        'LblIdUsuario
        '
        Me.LblIdUsuario.AutoSize = True
        Me.LblIdUsuario.BackColor = System.Drawing.Color.Transparent
        Me.LblIdUsuario.Location = New System.Drawing.Point(704, 64)
        Me.LblIdUsuario.Name = "LblIdUsuario"
        Me.LblIdUsuario.Size = New System.Drawing.Size(13, 13)
        Me.LblIdUsuario.TabIndex = 3
        Me.LblIdUsuario.Text = "3"
        Me.LblIdUsuario.Visible = False
        '
        'RibbonPageGroup3
        '
        Me.RibbonPageGroup3.Name = "RibbonPageGroup3"
        Me.RibbonPageGroup3.Text = "Acciones"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.DarkGray
        Me.Panel1.BackgroundImage = Global.INNOVAMASTER.My.Resources.Resources.LOGOINNOVAMASTERINTENTO
        Me.Panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Panel1.Location = New System.Drawing.Point(271, 215)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(363, 385)
        Me.Panel1.TabIndex = 6
        '
        'RibbonPage11
        '
        Me.RibbonPage11.Groups.AddRange(New DevExpress.XtraBars.Ribbon.RibbonPageGroup() {Me.RibbonPageGroup5})
        Me.RibbonPage11.Name = "RibbonPage11"
        Me.RibbonPage11.Text = "Acerca de Nosotros"
        '
        'BarManager1
        '
        Me.BarManager1.DockControls.Add(Me.barDockControlTop)
        Me.BarManager1.DockControls.Add(Me.barDockControlBottom)
        Me.BarManager1.DockControls.Add(Me.barDockControlLeft)
        Me.BarManager1.DockControls.Add(Me.barDockControlRight)
        Me.BarManager1.Form = Me
        Me.BarManager1.MaxItemId = 0
        '
        'barDockControlTop
        '
        Me.barDockControlTop.CausesValidation = False
        Me.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top
        Me.barDockControlTop.Location = New System.Drawing.Point(0, 0)
        Me.barDockControlTop.Size = New System.Drawing.Size(798, 0)
        '
        'barDockControlBottom
        '
        Me.barDockControlBottom.CausesValidation = False
        Me.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.barDockControlBottom.Location = New System.Drawing.Point(0, 599)
        Me.barDockControlBottom.Size = New System.Drawing.Size(798, 0)
        '
        'barDockControlLeft
        '
        Me.barDockControlLeft.CausesValidation = False
        Me.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left
        Me.barDockControlLeft.Location = New System.Drawing.Point(0, 0)
        Me.barDockControlLeft.Size = New System.Drawing.Size(0, 599)
        '
        'barDockControlRight
        '
        Me.barDockControlRight.CausesValidation = False
        Me.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right
        Me.barDockControlRight.Location = New System.Drawing.Point(798, 0)
        Me.barDockControlRight.Size = New System.Drawing.Size(0, 599)
        '
        'RibbonPageGroup5
        '
        Me.RibbonPageGroup5.ItemLinks.Add(Me.BarButtonItem25)
        Me.RibbonPageGroup5.Name = "RibbonPageGroup5"
        Me.RibbonPageGroup5.Text = "Acciones"
        '
        'BarButtonItem25
        '
        Me.BarButtonItem25.Caption = "Información"
        Me.BarButtonItem25.Glyph = CType(resources.GetObject("BarButtonItem25.Glyph"), System.Drawing.Image)
        Me.BarButtonItem25.Id = 43
        Me.BarButtonItem25.LargeGlyph = CType(resources.GetObject("BarButtonItem25.LargeGlyph"), System.Drawing.Image)
        Me.BarButtonItem25.Name = "BarButtonItem25"
        '
        'MenuPrincipal
        '
        Me.Appearance.BackColor = System.Drawing.Color.White
        Me.Appearance.Options.UseBackColor = True
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoValidate = System.Windows.Forms.AutoValidate.EnableAllowFocusChange
        Me.ClientSize = New System.Drawing.Size(798, 599)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.LblIdUsuario)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.mainRibbonControl)
        Me.Controls.Add(Me.barDockControlLeft)
        Me.Controls.Add(Me.barDockControlRight)
        Me.Controls.Add(Me.barDockControlBottom)
        Me.Controls.Add(Me.barDockControlTop)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.IsMdiContainer = True
        Me.Name = "MenuPrincipal"
        Me.Ribbon = Me.mainRibbonControl
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.mainRibbonControl, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BarManager1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

#End Region
    Private mainRibbonControl As DevExpress.XtraBars.Ribbon.RibbonControl
    Private mainRibbonPage As DevExpress.XtraBars.Ribbon.RibbonPage
    Private mainRibbonPageGroup As DevExpress.XtraBars.Ribbon.RibbonPageGroup
    Private bbiSave As DevExpress.XtraBars.BarButtonItem
    Private bbiSaveAndClose As DevExpress.XtraBars.BarButtonItem
    Private bbiSaveAndNew As DevExpress.XtraBars.BarButtonItem
    Private bbiReset As DevExpress.XtraBars.BarButtonItem
    Private bbiDelete As DevExpress.XtraBars.BarButtonItem
    Private bbiClose As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents DefaultLookAndFeel1 As DevExpress.LookAndFeel.DefaultLookAndFeel
    Friend WithEvents RibbonPage1 As DevExpress.XtraBars.Ribbon.RibbonPage
    Friend WithEvents RibbonPage2 As DevExpress.XtraBars.Ribbon.RibbonPage
    Friend WithEvents RibbonPage3 As DevExpress.XtraBars.Ribbon.RibbonPage
    Friend WithEvents RibbonPage5 As DevExpress.XtraBars.Ribbon.RibbonPage
    Friend WithEvents BtnRegistroClientes As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents BarButtonItem2 As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents BtnRegistroEmpleado As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents BarButtonItem4 As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents BtnRegistroUsuarios As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents BtnReportesUsuarios As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents BarButtonItem7 As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents BarButtonItem8 As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents BarButtonItem9 As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents BarButtonItem10 As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents RibbonPageGroup1 As DevExpress.XtraBars.Ribbon.RibbonPageGroup
    Friend WithEvents PagEmpleados As DevExpress.XtraBars.Ribbon.RibbonPageGroup
    Friend WithEvents PagUsuarios As DevExpress.XtraBars.Ribbon.RibbonPageGroup
    Friend WithEvents PagProductos As DevExpress.XtraBars.Ribbon.RibbonPageGroup
    Friend WithEvents BtnRegistroVenta As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents RibbonPage6 As DevExpress.XtraBars.Ribbon.RibbonPage
    Friend WithEvents RibbonPageGroup6 As DevExpress.XtraBars.Ribbon.RibbonPageGroup
    Friend WithEvents BarButtonItem12 As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents BarButtonItem13 As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents Label1 As Label
    Friend WithEvents LblIdUsuario As Label
    Friend WithEvents BarButtonItem14 As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents BarButtonItem15 As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents RibbonPage7 As DevExpress.XtraBars.Ribbon.RibbonPage
    Friend WithEvents PagConfiguracion As DevExpress.XtraBars.Ribbon.RibbonPageGroup
    Friend WithEvents BtnCambiarUsuario As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents BarButtonItem17 As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents RibbonPage8 As DevExpress.XtraBars.Ribbon.RibbonPage
    Friend WithEvents BarButtonItem18 As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents BarButtonItem19 As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents BarButtonItem20 As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents PagUbicacion As DevExpress.XtraBars.Ribbon.RibbonPageGroup
    Friend WithEvents BtnProfesion As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents BtnCargo As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents BarButtonItem23 As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents BarButtonItem24 As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents BtnF As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents RibbonPage4 As DevExpress.XtraBars.Ribbon.RibbonPage
    Friend WithEvents BarButtonItem1 As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents PgProveedores As DevExpress.XtraBars.Ribbon.RibbonPageGroup
    Friend WithEvents BarButtonItem3 As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents RibbonPage9 As DevExpress.XtraBars.Ribbon.RibbonPage
    Friend WithEvents RibbonPageGroup2 As DevExpress.XtraBars.Ribbon.RibbonPageGroup
    Friend WithEvents BarButtonItem5 As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents BarButtonItem6 As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents RibbonPage10 As DevExpress.XtraBars.Ribbon.RibbonPage
    Friend WithEvents RibbonPageGroup4 As DevExpress.XtraBars.Ribbon.RibbonPageGroup
    Friend WithEvents RibbonPageGroup3 As DevExpress.XtraBars.Ribbon.RibbonPageGroup
    Friend WithEvents BarButtonItem11 As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents BarButtonItem16 As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents BarButtonItem21 As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents BarButtonItem22 As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents Panel1 As Panel
    Friend WithEvents BarButtonItem25 As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents RibbonPage11 As DevExpress.XtraBars.Ribbon.RibbonPage
    Friend WithEvents RibbonPageGroup5 As DevExpress.XtraBars.Ribbon.RibbonPageGroup
    Friend WithEvents BarManager1 As DevExpress.XtraBars.BarManager
    Friend WithEvents barDockControlTop As DevExpress.XtraBars.BarDockControl
    Friend WithEvents barDockControlBottom As DevExpress.XtraBars.BarDockControl
    Friend WithEvents barDockControlLeft As DevExpress.XtraBars.BarDockControl
    Friend WithEvents barDockControlRight As DevExpress.XtraBars.BarDockControl
End Class
