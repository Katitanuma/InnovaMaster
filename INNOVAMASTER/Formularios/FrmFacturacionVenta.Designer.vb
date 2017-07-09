<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmFacturacionVenta
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.LblCambio = New System.Windows.Forms.Label()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.LblCant = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.BtnFacturar = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.TxtDescuentoExtra = New DevExpress.XtraEditors.CalcEdit()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.RdbCantidad = New System.Windows.Forms.RadioButton()
        Me.RdbPorcentaje = New System.Windows.Forms.RadioButton()
        Me.TxtP = New System.Windows.Forms.TextBox()
        Me.LblP = New System.Windows.Forms.Label()
        Me.CboTipoVenta = New System.Windows.Forms.ComboBox()
        Me.CboFormaVenta = New System.Windows.Forms.ComboBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.TxtFechaVencimientos = New System.Windows.Forms.DateTimePicker()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.TxtFechaVenta = New System.Windows.Forms.TextBox()
        Me.BtnBusquedaCliente = New System.Windows.Forms.Button()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.TxtIdCliente = New System.Windows.Forms.TextBox()
        Me.TxtIdVenta = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.TxtTotal = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.TxtImpuesto = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TxtDescuento = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TxtSubtotal = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.DgvDetalle = New System.Windows.Forms.DataGridView()
        Me.Eliminar = New System.Windows.Forms.DataGridViewButtonColumn()
        Me.Codigo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Descripcion = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Cantidad = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Precio = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Descuento = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TotalDescuento = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ISV = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Total = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.LblNombre = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.HelpProvider1 = New System.Windows.Forms.HelpProvider()
        Me.GroupBox1.SuspendLayout()
        Me.Panel1.SuspendLayout()
        CType(Me.TxtDescuentoExtra.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DgvDetalle, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'LblCambio
        '
        Me.LblCambio.AutoSize = True
        Me.LblCambio.Location = New System.Drawing.Point(1025, 495)
        Me.LblCambio.Name = "LblCambio"
        Me.LblCambio.Size = New System.Drawing.Size(39, 13)
        Me.LblCambio.TabIndex = 80
        Me.LblCambio.Text = "Label9"
        Me.LblCambio.Visible = False
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.White
        Me.Button2.Font = New System.Drawing.Font("Comic Sans MS", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.Location = New System.Drawing.Point(987, 510)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(206, 27)
        Me.Button2.TabIndex = 79
        Me.Button2.Text = "&Eliminar Todos los Productos"
        Me.Button2.UseVisualStyleBackColor = False
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(1027, 29)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(13, 13)
        Me.Label7.TabIndex = 78
        Me.Label7.Text = "0"
        Me.Label7.Visible = False
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.White
        Me.Button1.Font = New System.Drawing.Font("Comic Sans MS", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(1199, 510)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(123, 27)
        Me.Button1.TabIndex = 77
        Me.Button1.Text = "&Cancelar Venta"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'LblCant
        '
        Me.LblCant.AutoSize = True
        Me.LblCant.Location = New System.Drawing.Point(1130, 29)
        Me.LblCant.Name = "LblCant"
        Me.LblCant.Size = New System.Drawing.Size(39, 13)
        Me.LblCant.TabIndex = 76
        Me.LblCant.Text = "Label7"
        Me.LblCant.Visible = False
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Monotype Corsiva", 24.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.Black
        Me.Label6.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label6.Location = New System.Drawing.Point(80, 3)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(224, 39)
        Me.Label6.TabIndex = 74
        Me.Label6.Text = "Detalle de Venta"
        '
        'BtnFacturar
        '
        Me.BtnFacturar.BackColor = System.Drawing.Color.White
        Me.BtnFacturar.Font = New System.Drawing.Font("Comic Sans MS", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnFacturar.Location = New System.Drawing.Point(840, 511)
        Me.BtnFacturar.Name = "BtnFacturar"
        Me.BtnFacturar.Size = New System.Drawing.Size(85, 27)
        Me.BtnFacturar.TabIndex = 73
        Me.BtnFacturar.Text = "&Facturar"
        Me.BtnFacturar.UseVisualStyleBackColor = False
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Button3)
        Me.GroupBox1.Controls.Add(Me.Panel1)
        Me.GroupBox1.Controls.Add(Me.CboTipoVenta)
        Me.GroupBox1.Controls.Add(Me.CboFormaVenta)
        Me.GroupBox1.Controls.Add(Me.Label14)
        Me.GroupBox1.Controls.Add(Me.Label15)
        Me.GroupBox1.Controls.Add(Me.TxtFechaVencimientos)
        Me.GroupBox1.Controls.Add(Me.Label11)
        Me.GroupBox1.Controls.Add(Me.TxtFechaVenta)
        Me.GroupBox1.Controls.Add(Me.BtnBusquedaCliente)
        Me.GroupBox1.Controls.Add(Me.Label9)
        Me.GroupBox1.Controls.Add(Me.TxtIdCliente)
        Me.GroupBox1.Controls.Add(Me.TxtIdVenta)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Location = New System.Drawing.Point(22, 45)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(1300, 102)
        Me.GroupBox1.TabIndex = 72
        Me.GroupBox1.TabStop = False
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(1169, 31)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(89, 21)
        Me.Button3.TabIndex = 89
        Me.Button3.Text = "15 Dias"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Panel1
        '
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel1.Controls.Add(Me.TxtDescuentoExtra)
        Me.Panel1.Controls.Add(Me.Label13)
        Me.Panel1.Controls.Add(Me.RdbCantidad)
        Me.Panel1.Controls.Add(Me.RdbPorcentaje)
        Me.Panel1.Controls.Add(Me.TxtP)
        Me.Panel1.Controls.Add(Me.LblP)
        Me.Panel1.Location = New System.Drawing.Point(426, 19)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(570, 74)
        Me.Panel1.TabIndex = 81
        '
        'TxtDescuentoExtra
        '
        Me.TxtDescuentoExtra.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.TxtDescuentoExtra.Location = New System.Drawing.Point(3, 34)
        Me.TxtDescuentoExtra.Name = "TxtDescuentoExtra"
        Me.TxtDescuentoExtra.Properties.Appearance.BackColor = System.Drawing.Color.White
        Me.TxtDescuentoExtra.Properties.Appearance.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtDescuentoExtra.Properties.Appearance.Options.UseBackColor = True
        Me.TxtDescuentoExtra.Properties.Appearance.Options.UseFont = True
        Me.TxtDescuentoExtra.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.TxtDescuentoExtra.Size = New System.Drawing.Size(179, 22)
        Me.TxtDescuentoExtra.TabIndex = 35
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Comic Sans MS", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(9, 9)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(113, 19)
        Me.Label13.TabIndex = 12
        Me.Label13.Text = "Descuento Extra"
        '
        'RdbCantidad
        '
        Me.RdbCantidad.AutoSize = True
        Me.RdbCantidad.Font = New System.Drawing.Font("Comic Sans MS", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RdbCantidad.Location = New System.Drawing.Point(191, 33)
        Me.RdbCantidad.Name = "RdbCantidad"
        Me.RdbCantidad.Size = New System.Drawing.Size(108, 23)
        Me.RdbCantidad.TabIndex = 36
        Me.RdbCantidad.TabStop = True
        Me.RdbCantidad.Text = "Por Cantidad"
        Me.RdbCantidad.UseVisualStyleBackColor = True
        '
        'RdbPorcentaje
        '
        Me.RdbPorcentaje.AutoSize = True
        Me.RdbPorcentaje.Font = New System.Drawing.Font("Comic Sans MS", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RdbPorcentaje.Location = New System.Drawing.Point(304, 33)
        Me.RdbPorcentaje.Name = "RdbPorcentaje"
        Me.RdbPorcentaje.Size = New System.Drawing.Size(119, 23)
        Me.RdbPorcentaje.TabIndex = 37
        Me.RdbPorcentaje.TabStop = True
        Me.RdbPorcentaje.Text = "Por Porcentaje"
        Me.RdbPorcentaje.UseVisualStyleBackColor = True
        '
        'TxtP
        '
        Me.TxtP.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtP.Location = New System.Drawing.Point(420, 34)
        Me.TxtP.Name = "TxtP"
        Me.TxtP.Size = New System.Drawing.Size(54, 21)
        Me.TxtP.TabIndex = 38
        Me.TxtP.Text = "0"
        Me.TxtP.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.TxtP.Visible = False
        '
        'LblP
        '
        Me.LblP.AutoSize = True
        Me.LblP.Font = New System.Drawing.Font("Comic Sans MS", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblP.Location = New System.Drawing.Point(476, 35)
        Me.LblP.Name = "LblP"
        Me.LblP.Size = New System.Drawing.Size(20, 19)
        Me.LblP.TabIndex = 39
        Me.LblP.Text = "%"
        Me.LblP.Visible = False
        '
        'CboTipoVenta
        '
        Me.CboTipoVenta.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.CboTipoVenta.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CboTipoVenta.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CboTipoVenta.FormattingEnabled = True
        Me.CboTipoVenta.Items.AddRange(New Object() {"Contado", "Crédito"})
        Me.CboTipoVenta.Location = New System.Drawing.Point(233, 74)
        Me.CboTipoVenta.Name = "CboTipoVenta"
        Me.CboTipoVenta.Size = New System.Drawing.Size(167, 23)
        Me.CboTipoVenta.TabIndex = 88
        '
        'CboFormaVenta
        '
        Me.CboFormaVenta.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.CboFormaVenta.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CboFormaVenta.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CboFormaVenta.FormattingEnabled = True
        Me.CboFormaVenta.Items.AddRange(New Object() {"Mayoreo", "Unitario"})
        Me.CboFormaVenta.Location = New System.Drawing.Point(234, 30)
        Me.CboFormaVenta.Name = "CboFormaVenta"
        Me.CboFormaVenta.Size = New System.Drawing.Size(167, 23)
        Me.CboFormaVenta.TabIndex = 87
        '
        'Label14
        '
        Me.Label14.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Comic Sans MS", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label14.Location = New System.Drawing.Point(228, 55)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(99, 19)
        Me.Label14.TabIndex = 86
        Me.Label14.Text = "Tipo de Venta"
        '
        'Label15
        '
        Me.Label15.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Comic Sans MS", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label15.Location = New System.Drawing.Point(230, 11)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(110, 19)
        Me.Label15.TabIndex = 85
        Me.Label15.Text = "Forma de Venta"
        '
        'TxtFechaVencimientos
        '
        Me.TxtFechaVencimientos.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.TxtFechaVencimientos.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtFechaVencimientos.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.TxtFechaVencimientos.Location = New System.Drawing.Point(1008, 32)
        Me.TxtFechaVencimientos.Name = "TxtFechaVencimientos"
        Me.TxtFechaVencimientos.Size = New System.Drawing.Size(155, 21)
        Me.TxtFechaVencimientos.TabIndex = 84
        '
        'Label11
        '
        Me.Label11.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Comic Sans MS", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label11.Location = New System.Drawing.Point(1002, 14)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(148, 19)
        Me.Label11.TabIndex = 83
        Me.Label11.Text = "Fecha de Vencimiento"
        '
        'TxtFechaVenta
        '
        Me.TxtFechaVenta.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.TxtFechaVenta.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtFechaVenta.Location = New System.Drawing.Point(1008, 72)
        Me.TxtFechaVenta.Name = "TxtFechaVenta"
        Me.TxtFechaVenta.ReadOnly = True
        Me.TxtFechaVenta.Size = New System.Drawing.Size(155, 21)
        Me.TxtFechaVenta.TabIndex = 82
        '
        'BtnBusquedaCliente
        '
        Me.BtnBusquedaCliente.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnBusquedaCliente.Location = New System.Drawing.Point(168, 74)
        Me.BtnBusquedaCliente.Name = "BtnBusquedaCliente"
        Me.BtnBusquedaCliente.Size = New System.Drawing.Size(33, 24)
        Me.BtnBusquedaCliente.TabIndex = 42
        Me.BtnBusquedaCliente.Text = " ..."
        Me.BtnBusquedaCliente.UseVisualStyleBackColor = True
        '
        'Label9
        '
        Me.Label9.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Comic Sans MS", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label9.Location = New System.Drawing.Point(1004, 52)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(109, 19)
        Me.Label9.TabIndex = 81
        Me.Label9.Text = "Fecha de Venta"
        '
        'TxtIdCliente
        '
        Me.TxtIdCliente.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.TxtIdCliente.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.TxtIdCliente.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource
        Me.TxtIdCliente.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtIdCliente.Location = New System.Drawing.Point(7, 75)
        Me.TxtIdCliente.Name = "TxtIdCliente"
        Me.TxtIdCliente.Size = New System.Drawing.Size(155, 21)
        Me.TxtIdCliente.TabIndex = 41
        Me.TxtIdCliente.Tag = ""
        '
        'TxtIdVenta
        '
        Me.TxtIdVenta.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.TxtIdVenta.Enabled = False
        Me.TxtIdVenta.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtIdVenta.Location = New System.Drawing.Point(6, 30)
        Me.TxtIdVenta.Name = "TxtIdVenta"
        Me.TxtIdVenta.ReadOnly = True
        Me.TxtIdVenta.Size = New System.Drawing.Size(126, 21)
        Me.TxtIdVenta.TabIndex = 40
        Me.TxtIdVenta.Tag = ""
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Comic Sans MS", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(6, 54)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(52, 19)
        Me.Label8.TabIndex = 2
        Me.Label8.Text = "Cliente"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Comic Sans MS", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(6, 8)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(130, 19)
        Me.Label5.TabIndex = 0
        Me.Label5.Text = "Código de la Venta"
        '
        'TxtTotal
        '
        Me.TxtTotal.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtTotal.Location = New System.Drawing.Point(639, 516)
        Me.TxtTotal.Name = "TxtTotal"
        Me.TxtTotal.ReadOnly = True
        Me.TxtTotal.Size = New System.Drawing.Size(164, 21)
        Me.TxtTotal.TabIndex = 71
        Me.TxtTotal.Text = "0.00"
        Me.TxtTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Comic Sans MS", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(636, 496)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(42, 19)
        Me.Label4.TabIndex = 70
        Me.Label4.Text = "Total"
        '
        'TxtImpuesto
        '
        Me.TxtImpuesto.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtImpuesto.Location = New System.Drawing.Point(433, 516)
        Me.TxtImpuesto.Name = "TxtImpuesto"
        Me.TxtImpuesto.ReadOnly = True
        Me.TxtImpuesto.Size = New System.Drawing.Size(164, 21)
        Me.TxtImpuesto.TabIndex = 69
        Me.TxtImpuesto.Text = "0.00"
        Me.TxtImpuesto.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Comic Sans MS", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(430, 496)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(66, 19)
        Me.Label3.TabIndex = 68
        Me.Label3.Text = "Impuesto"
        '
        'TxtDescuento
        '
        Me.TxtDescuento.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtDescuento.Location = New System.Drawing.Point(226, 516)
        Me.TxtDescuento.Name = "TxtDescuento"
        Me.TxtDescuento.ReadOnly = True
        Me.TxtDescuento.Size = New System.Drawing.Size(164, 21)
        Me.TxtDescuento.TabIndex = 67
        Me.TxtDescuento.Text = "0.00"
        Me.TxtDescuento.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Comic Sans MS", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(223, 496)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(72, 19)
        Me.Label2.TabIndex = 66
        Me.Label2.Text = "Descuento"
        '
        'TxtSubtotal
        '
        Me.TxtSubtotal.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtSubtotal.Location = New System.Drawing.Point(20, 516)
        Me.TxtSubtotal.Name = "TxtSubtotal"
        Me.TxtSubtotal.ReadOnly = True
        Me.TxtSubtotal.Size = New System.Drawing.Size(164, 21)
        Me.TxtSubtotal.TabIndex = 65
        Me.TxtSubtotal.Text = "0.00"
        Me.TxtSubtotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Comic Sans MS", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(17, 496)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(63, 19)
        Me.Label1.TabIndex = 64
        Me.Label1.Text = "Subtotal"
        '
        'DgvDetalle
        '
        Me.DgvDetalle.BackgroundColor = System.Drawing.Color.White
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.White
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Blue
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DgvDetalle.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.DgvDetalle.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DgvDetalle.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Eliminar, Me.Codigo, Me.Descripcion, Me.Cantidad, Me.Precio, Me.Descuento, Me.TotalDescuento, Me.ISV, Me.Total})
        Me.DgvDetalle.Location = New System.Drawing.Point(20, 153)
        Me.DgvDetalle.Name = "DgvDetalle"
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.Gray
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DgvDetalle.RowHeadersDefaultCellStyle = DataGridViewCellStyle2
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White
        Me.DgvDetalle.RowsDefaultCellStyle = DataGridViewCellStyle3
        Me.DgvDetalle.Size = New System.Drawing.Size(1302, 343)
        Me.DgvDetalle.TabIndex = 63
        '
        'Eliminar
        '
        Me.Eliminar.Frozen = True
        Me.Eliminar.HeaderText = "Eliminar"
        Me.Eliminar.Name = "Eliminar"
        Me.Eliminar.Text = "Eliminar"
        Me.Eliminar.ToolTipText = "Eliminar"
        Me.Eliminar.UseColumnTextForButtonValue = True
        '
        'Codigo
        '
        Me.Codigo.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        Me.Codigo.Frozen = True
        Me.Codigo.HeaderText = "Código"
        Me.Codigo.Name = "Codigo"
        Me.Codigo.Width = 163
        '
        'Descripcion
        '
        Me.Descripcion.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        Me.Descripcion.Frozen = True
        Me.Descripcion.HeaderText = "Descripción"
        Me.Descripcion.Name = "Descripcion"
        Me.Descripcion.Width = 163
        '
        'Cantidad
        '
        Me.Cantidad.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.Cantidad.HeaderText = "Cantidad"
        Me.Cantidad.Name = "Cantidad"
        Me.Cantidad.Width = 82
        '
        'Precio
        '
        Me.Precio.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.Precio.HeaderText = "Precio"
        Me.Precio.Name = "Precio"
        Me.Precio.ReadOnly = True
        '
        'Descuento
        '
        Me.Descuento.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.Descuento.HeaderText = "Descuento %"
        Me.Descuento.Name = "Descuento"
        '
        'TotalDescuento
        '
        Me.TotalDescuento.HeaderText = "Total Descuento"
        Me.TotalDescuento.Name = "TotalDescuento"
        '
        'ISV
        '
        Me.ISV.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.ISV.HeaderText = "ISV"
        Me.ISV.Name = "ISV"
        Me.ISV.ReadOnly = True
        '
        'Total
        '
        Me.Total.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.Total.HeaderText = "Total"
        Me.Total.Name = "Total"
        Me.Total.ReadOnly = True
        '
        'PictureBox2
        '
        Me.PictureBox2.BackgroundImage = Global.INNOVAMASTER.My.Resources.Resources.factur
        Me.PictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox2.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.PictureBox2.Location = New System.Drawing.Point(22, -1)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(62, 51)
        Me.PictureBox2.TabIndex = 75
        Me.PictureBox2.TabStop = False
        '
        'LblNombre
        '
        Me.LblNombre.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.LblNombre.AutoSize = True
        Me.LblNombre.Font = New System.Drawing.Font("Comic Sans MS", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblNombre.Location = New System.Drawing.Point(322, 12)
        Me.LblNombre.Name = "LblNombre"
        Me.LblNombre.Size = New System.Drawing.Size(0, 23)
        Me.LblNombre.TabIndex = 89
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(850, 29)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(45, 13)
        Me.Label10.TabIndex = 90
        Me.Label10.Text = "Label10"
        Me.Label10.Visible = False
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(590, 24)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(45, 13)
        Me.Label12.TabIndex = 91
        Me.Label12.Text = "Label12"
        Me.Label12.Visible = False
        '
        'FrmFacturacionVenta
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.LightSeaGreen
        Me.ClientSize = New System.Drawing.Size(1338, 563)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.LblNombre)
        Me.Controls.Add(Me.LblCambio)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.LblCant)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.BtnFacturar)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.TxtTotal)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.TxtImpuesto)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.TxtDescuento)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.TxtSubtotal)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.DgvDetalle)
        Me.HelpButton = True
        Me.HelpProvider1.SetHelpNavigator(Me, System.Windows.Forms.HelpNavigator.TableOfContents)
        Me.Name = "FrmFacturacionVenta"
        Me.HelpProvider1.SetShowHelp(Me, True)
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Facturación de Venta"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.TxtDescuentoExtra.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DgvDetalle, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents LblCambio As Label
    Friend WithEvents Button2 As Button
    Friend WithEvents Label7 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents LblCant As Label
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents Label6 As Label
    Friend WithEvents BtnFacturar As Button
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents LblP As Label
    Friend WithEvents TxtP As TextBox
    Friend WithEvents RdbPorcentaje As RadioButton
    Friend WithEvents RdbCantidad As RadioButton
    Friend WithEvents TxtDescuentoExtra As DevExpress.XtraEditors.CalcEdit
    Friend WithEvents Label13 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents TxtTotal As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents TxtImpuesto As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents TxtDescuento As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents TxtSubtotal As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents DgvDetalle As DataGridView
    Friend WithEvents Eliminar As DataGridViewButtonColumn
    Friend WithEvents Codigo As DataGridViewTextBoxColumn
    Friend WithEvents Descripcion As DataGridViewTextBoxColumn
    Friend WithEvents Cantidad As DataGridViewTextBoxColumn
    Friend WithEvents Precio As DataGridViewTextBoxColumn
    Friend WithEvents Descuento As DataGridViewTextBoxColumn
    Friend WithEvents TotalDescuento As DataGridViewTextBoxColumn
    Friend WithEvents ISV As DataGridViewTextBoxColumn
    Friend WithEvents Total As DataGridViewTextBoxColumn
    Friend WithEvents TxtIdVenta As TextBox
    Friend WithEvents BtnBusquedaCliente As Button
    Friend WithEvents TxtIdCliente As TextBox
    Friend WithEvents TxtFechaVenta As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents TxtFechaVencimientos As DateTimePicker
    Friend WithEvents Label11 As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents CboTipoVenta As ComboBox
    Friend WithEvents CboFormaVenta As ComboBox
    Friend WithEvents Label14 As Label
    Friend WithEvents Label15 As Label
    Friend WithEvents LblNombre As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Button3 As Button
    Friend WithEvents Label12 As Label
    Friend WithEvents HelpProvider1 As HelpProvider
End Class
