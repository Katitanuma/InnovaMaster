<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmVenta
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.DgvVenta = New System.Windows.Forms.DataGridView()
        Me.GbVenta = New System.Windows.Forms.GroupBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.BtnBusquedaCliente = New System.Windows.Forms.Button()
        Me.LblNombre = New System.Windows.Forms.Label()
        Me.TxtIdCliente = New System.Windows.Forms.TextBox()
        Me.TxtFechaVencimientos = New System.Windows.Forms.DateTimePicker()
        Me.LblIdUsuario = New System.Windows.Forms.Label()
        Me.TxtDescuentoExtra = New DevExpress.XtraEditors.CalcEdit()
        Me.CboTipoVenta = New System.Windows.Forms.ComboBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.CboFormaVenta = New System.Windows.Forms.ComboBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TxtFechaVenta = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.TxtIdVenta = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.TxtBusqueda = New System.Windows.Forms.TextBox()
        Me.CboBusqueda = New System.Windows.Forms.ComboBox()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.BtnNuevoEditar = New System.Windows.Forms.Button()
        Me.BtnCancelar = New System.Windows.Forms.Button()
        Me.BtnNuevo = New System.Windows.Forms.Button()
        Me.BtnInsertar = New System.Windows.Forms.Button()
        Me.BtnEditar = New System.Windows.Forms.Button()
        Me.HelpProvider1 = New System.Windows.Forms.HelpProvider()
        CType(Me.DgvVenta, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GbVenta.SuspendLayout()
        CType(Me.TxtDescuentoExtra.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold)
        Me.Label11.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label11.Location = New System.Drawing.Point(890, 269)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(98, 24)
        Me.Label11.TabIndex = 35
        Me.Label11.Text = "Sin Datos"
        Me.Label11.Visible = False
        '
        'DgvVenta
        '
        Me.DgvVenta.AllowUserToAddRows = False
        Me.DgvVenta.AllowUserToDeleteRows = False
        Me.DgvVenta.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.DgvVenta.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DgvVenta.BackgroundColor = System.Drawing.Color.White
        Me.DgvVenta.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DgvVenta.Location = New System.Drawing.Point(489, 74)
        Me.DgvVenta.Name = "DgvVenta"
        Me.DgvVenta.ReadOnly = True
        Me.DgvVenta.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DgvVenta.Size = New System.Drawing.Size(830, 464)
        Me.DgvVenta.TabIndex = 32
        '
        'GbVenta
        '
        Me.GbVenta.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.GbVenta.BackColor = System.Drawing.Color.Transparent
        Me.GbVenta.Controls.Add(Me.Button1)
        Me.GbVenta.Controls.Add(Me.BtnBusquedaCliente)
        Me.GbVenta.Controls.Add(Me.LblNombre)
        Me.GbVenta.Controls.Add(Me.TxtIdCliente)
        Me.GbVenta.Controls.Add(Me.TxtFechaVencimientos)
        Me.GbVenta.Controls.Add(Me.LblIdUsuario)
        Me.GbVenta.Controls.Add(Me.TxtDescuentoExtra)
        Me.GbVenta.Controls.Add(Me.CboTipoVenta)
        Me.GbVenta.Controls.Add(Me.Label5)
        Me.GbVenta.Controls.Add(Me.CboFormaVenta)
        Me.GbVenta.Controls.Add(Me.Label7)
        Me.GbVenta.Controls.Add(Me.Label8)
        Me.GbVenta.Controls.Add(Me.Label3)
        Me.GbVenta.Controls.Add(Me.TxtFechaVenta)
        Me.GbVenta.Controls.Add(Me.Label4)
        Me.GbVenta.Controls.Add(Me.TxtIdVenta)
        Me.GbVenta.Controls.Add(Me.Label2)
        Me.GbVenta.Controls.Add(Me.Label1)
        Me.GbVenta.Font = New System.Drawing.Font("Comic Sans MS", 9.0!, System.Drawing.FontStyle.Bold)
        Me.GbVenta.ForeColor = System.Drawing.Color.Black
        Me.GbVenta.Location = New System.Drawing.Point(27, 67)
        Me.GbVenta.Name = "GbVenta"
        Me.GbVenta.Size = New System.Drawing.Size(430, 319)
        Me.GbVenta.TabIndex = 31
        Me.GbVenta.TabStop = False
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(328, 146)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(61, 21)
        Me.Button1.TabIndex = 40
        Me.Button1.Text = "15 Días"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'BtnBusquedaCliente
        '
        Me.BtnBusquedaCliente.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnBusquedaCliente.Location = New System.Drawing.Point(328, 66)
        Me.BtnBusquedaCliente.Name = "BtnBusquedaCliente"
        Me.BtnBusquedaCliente.Size = New System.Drawing.Size(33, 24)
        Me.BtnBusquedaCliente.TabIndex = 39
        Me.BtnBusquedaCliente.Text = " ..."
        Me.BtnBusquedaCliente.UseVisualStyleBackColor = True
        '
        'LblNombre
        '
        Me.LblNombre.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.LblNombre.AutoSize = True
        Me.LblNombre.Location = New System.Drawing.Point(166, 49)
        Me.LblNombre.Name = "LblNombre"
        Me.LblNombre.Size = New System.Drawing.Size(0, 16)
        Me.LblNombre.TabIndex = 38
        '
        'TxtIdCliente
        '
        Me.TxtIdCliente.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.TxtIdCliente.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.TxtIdCliente.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource
        Me.TxtIdCliente.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtIdCliente.Location = New System.Drawing.Point(167, 67)
        Me.TxtIdCliente.Name = "TxtIdCliente"
        Me.TxtIdCliente.Size = New System.Drawing.Size(155, 21)
        Me.TxtIdCliente.TabIndex = 37
        Me.TxtIdCliente.Tag = ""
        '
        'TxtFechaVencimientos
        '
        Me.TxtFechaVencimientos.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.TxtFechaVencimientos.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtFechaVencimientos.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.TxtFechaVencimientos.Location = New System.Drawing.Point(167, 146)
        Me.TxtFechaVencimientos.Name = "TxtFechaVencimientos"
        Me.TxtFechaVencimientos.Size = New System.Drawing.Size(155, 21)
        Me.TxtFechaVencimientos.TabIndex = 36
        '
        'LblIdUsuario
        '
        Me.LblIdUsuario.AutoSize = True
        Me.LblIdUsuario.Location = New System.Drawing.Point(404, 20)
        Me.LblIdUsuario.Name = "LblIdUsuario"
        Me.LblIdUsuario.Size = New System.Drawing.Size(15, 16)
        Me.LblIdUsuario.TabIndex = 35
        Me.LblIdUsuario.Text = "3"
        Me.LblIdUsuario.Visible = False
        '
        'TxtDescuentoExtra
        '
        Me.TxtDescuentoExtra.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.TxtDescuentoExtra.Location = New System.Drawing.Point(167, 278)
        Me.TxtDescuentoExtra.Name = "TxtDescuentoExtra"
        Me.TxtDescuentoExtra.Properties.Appearance.BackColor = System.Drawing.Color.White
        Me.TxtDescuentoExtra.Properties.Appearance.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtDescuentoExtra.Properties.Appearance.Options.UseBackColor = True
        Me.TxtDescuentoExtra.Properties.Appearance.Options.UseFont = True
        Me.TxtDescuentoExtra.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.TxtDescuentoExtra.Size = New System.Drawing.Size(155, 22)
        Me.TxtDescuentoExtra.TabIndex = 34
        '
        'CboTipoVenta
        '
        Me.CboTipoVenta.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.CboTipoVenta.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CboTipoVenta.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CboTipoVenta.FormattingEnabled = True
        Me.CboTipoVenta.Items.AddRange(New Object() {"Contado", "Crédito"})
        Me.CboTipoVenta.Location = New System.Drawing.Point(167, 233)
        Me.CboTipoVenta.Name = "CboTipoVenta"
        Me.CboTipoVenta.Size = New System.Drawing.Size(167, 23)
        Me.CboTipoVenta.TabIndex = 31
        '
        'Label5
        '
        Me.Label5.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Comic Sans MS", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label5.Location = New System.Drawing.Point(54, 278)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(113, 19)
        Me.Label5.TabIndex = 28
        Me.Label5.Text = "Descuento Extra"
        '
        'CboFormaVenta
        '
        Me.CboFormaVenta.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.CboFormaVenta.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CboFormaVenta.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CboFormaVenta.FormattingEnabled = True
        Me.CboFormaVenta.Items.AddRange(New Object() {"Mayoreo", "Unitario"})
        Me.CboFormaVenta.Location = New System.Drawing.Point(167, 189)
        Me.CboFormaVenta.Name = "CboFormaVenta"
        Me.CboFormaVenta.Size = New System.Drawing.Size(167, 23)
        Me.CboFormaVenta.TabIndex = 23
        '
        'Label7
        '
        Me.Label7.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Comic Sans MS", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label7.Location = New System.Drawing.Point(68, 234)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(99, 19)
        Me.Label7.TabIndex = 10
        Me.Label7.Text = "Tipo de Venta"
        '
        'Label8
        '
        Me.Label8.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Comic Sans MS", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label8.Location = New System.Drawing.Point(57, 189)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(110, 19)
        Me.Label8.TabIndex = 8
        Me.Label8.Text = "Forma de Venta"
        '
        'Label3
        '
        Me.Label3.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Comic Sans MS", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label3.Location = New System.Drawing.Point(19, 146)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(148, 19)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "Fecha de Vencimiento"
        '
        'TxtFechaVenta
        '
        Me.TxtFechaVenta.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.TxtFechaVenta.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtFechaVenta.Location = New System.Drawing.Point(167, 107)
        Me.TxtFechaVenta.Name = "TxtFechaVenta"
        Me.TxtFechaVenta.ReadOnly = True
        Me.TxtFechaVenta.Size = New System.Drawing.Size(155, 21)
        Me.TxtFechaVenta.TabIndex = 5
        '
        'Label4
        '
        Me.Label4.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Comic Sans MS", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label4.Location = New System.Drawing.Point(57, 107)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(109, 19)
        Me.Label4.TabIndex = 4
        Me.Label4.Text = "Fecha de Venta"
        '
        'TxtIdVenta
        '
        Me.TxtIdVenta.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.TxtIdVenta.Enabled = False
        Me.TxtIdVenta.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtIdVenta.Location = New System.Drawing.Point(167, 27)
        Me.TxtIdVenta.Name = "TxtIdVenta"
        Me.TxtIdVenta.Size = New System.Drawing.Size(155, 21)
        Me.TxtIdVenta.TabIndex = 3
        Me.TxtIdVenta.Tag = ""
        '
        'Label2
        '
        Me.Label2.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Comic Sans MS", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label2.Location = New System.Drawing.Point(42, 66)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(124, 19)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Código del Cliente"
        '
        'Label1
        '
        Me.Label1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Comic Sans MS", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label1.Location = New System.Drawing.Point(53, 26)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(113, 19)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Código de Venta"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Monotype Corsiva", 26.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(76, 19)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(100, 43)
        Me.Label13.TabIndex = 84
        Me.Label13.Text = "Venta"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Comic Sans MS", 9.75!, System.Drawing.FontStyle.Bold)
        Me.Label12.ForeColor = System.Drawing.Color.Black
        Me.Label12.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label12.Location = New System.Drawing.Point(839, 54)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(114, 19)
        Me.Label12.TabIndex = 88
        Me.Label12.Text = "Lista de Ventas "
        '
        'TxtBusqueda
        '
        Me.TxtBusqueda.Font = New System.Drawing.Font("Arial", 9.0!)
        Me.TxtBusqueda.Location = New System.Drawing.Point(801, 21)
        Me.TxtBusqueda.Name = "TxtBusqueda"
        Me.TxtBusqueda.Size = New System.Drawing.Size(518, 21)
        Me.TxtBusqueda.TabIndex = 87
        '
        'CboBusqueda
        '
        Me.CboBusqueda.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CboBusqueda.Font = New System.Drawing.Font("Arial", 9.0!)
        Me.CboBusqueda.FormattingEnabled = True
        Me.CboBusqueda.Items.AddRange(New Object() {"IdVenta", "IdCliente", "FormaVenta", "TipoVenta", "Usuario"})
        Me.CboBusqueda.Location = New System.Drawing.Point(521, 19)
        Me.CboBusqueda.Name = "CboBusqueda"
        Me.CboBusqueda.Size = New System.Drawing.Size(203, 23)
        Me.CboBusqueda.TabIndex = 86
        '
        'PictureBox3
        '
        Me.PictureBox3.BackgroundImage = Global.INNOVAMASTER.My.Resources.Resources.lapiz1
        Me.PictureBox3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox3.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.PictureBox3.Location = New System.Drawing.Point(767, 15)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(32, 32)
        Me.PictureBox3.TabIndex = 90
        Me.PictureBox3.TabStop = False
        '
        'PictureBox1
        '
        Me.PictureBox1.BackgroundImage = Global.INNOVAMASTER.My.Resources.Resources.search
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox1.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.PictureBox1.Location = New System.Drawing.Point(489, 14)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(32, 32)
        Me.PictureBox1.TabIndex = 89
        Me.PictureBox1.TabStop = False
        '
        'PictureBox2
        '
        Me.PictureBox2.BackgroundImage = Global.INNOVAMASTER.My.Resources.Resources.purse_256
        Me.PictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox2.Location = New System.Drawing.Point(25, 12)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(59, 59)
        Me.PictureBox2.TabIndex = 85
        Me.PictureBox2.TabStop = False
        '
        'BtnNuevoEditar
        '
        Me.BtnNuevoEditar.BackColor = System.Drawing.Color.LightSeaGreen
        Me.BtnNuevoEditar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BtnNuevoEditar.FlatAppearance.BorderSize = 0
        Me.BtnNuevoEditar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnNuevoEditar.Font = New System.Drawing.Font("Comic Sans MS", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnNuevoEditar.Image = Global.INNOVAMASTER.My.Resources.Resources.editar1
        Me.BtnNuevoEditar.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.BtnNuevoEditar.Location = New System.Drawing.Point(153, 445)
        Me.BtnNuevoEditar.Name = "BtnNuevoEditar"
        Me.BtnNuevoEditar.Size = New System.Drawing.Size(82, 86)
        Me.BtnNuevoEditar.TabIndex = 75
        Me.BtnNuevoEditar.Text = "&Editar"
        Me.BtnNuevoEditar.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.BtnNuevoEditar.UseVisualStyleBackColor = False
        '
        'BtnCancelar
        '
        Me.BtnCancelar.BackColor = System.Drawing.Color.LightSeaGreen
        Me.BtnCancelar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BtnCancelar.FlatAppearance.BorderSize = 0
        Me.BtnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnCancelar.Font = New System.Drawing.Font("Comic Sans MS", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnCancelar.Image = Global.INNOVAMASTER.My.Resources.Resources.cancelb
        Me.BtnCancelar.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.BtnCancelar.Location = New System.Drawing.Point(334, 446)
        Me.BtnCancelar.Name = "BtnCancelar"
        Me.BtnCancelar.Size = New System.Drawing.Size(82, 86)
        Me.BtnCancelar.TabIndex = 76
        Me.BtnCancelar.Text = "&Cancelar"
        Me.BtnCancelar.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.BtnCancelar.UseVisualStyleBackColor = False
        Me.BtnCancelar.Visible = False
        '
        'BtnNuevo
        '
        Me.BtnNuevo.BackColor = System.Drawing.Color.LightSeaGreen
        Me.BtnNuevo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BtnNuevo.FlatAppearance.BorderSize = 0
        Me.BtnNuevo.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnNuevo.Font = New System.Drawing.Font("Comic Sans MS", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnNuevo.Image = Global.INNOVAMASTER.My.Resources.Resources.nuevo
        Me.BtnNuevo.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.BtnNuevo.Location = New System.Drawing.Point(58, 445)
        Me.BtnNuevo.Name = "BtnNuevo"
        Me.BtnNuevo.Size = New System.Drawing.Size(82, 86)
        Me.BtnNuevo.TabIndex = 74
        Me.BtnNuevo.Text = "&Nuevo"
        Me.BtnNuevo.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.BtnNuevo.UseVisualStyleBackColor = False
        '
        'BtnInsertar
        '
        Me.BtnInsertar.BackColor = System.Drawing.Color.LightSeaGreen
        Me.BtnInsertar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BtnInsertar.FlatAppearance.BorderSize = 0
        Me.BtnInsertar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnInsertar.Font = New System.Drawing.Font("Comic Sans MS", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnInsertar.Image = Global.INNOVAMASTER.My.Resources.Resources.guardar
        Me.BtnInsertar.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.BtnInsertar.Location = New System.Drawing.Point(244, 445)
        Me.BtnInsertar.Name = "BtnInsertar"
        Me.BtnInsertar.Size = New System.Drawing.Size(82, 86)
        Me.BtnInsertar.TabIndex = 77
        Me.BtnInsertar.Text = "&Guardar"
        Me.BtnInsertar.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.BtnInsertar.UseVisualStyleBackColor = False
        Me.BtnInsertar.Visible = False
        '
        'BtnEditar
        '
        Me.BtnEditar.BackColor = System.Drawing.Color.LightSeaGreen
        Me.BtnEditar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BtnEditar.FlatAppearance.BorderSize = 0
        Me.BtnEditar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnEditar.Font = New System.Drawing.Font("Comic Sans MS", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnEditar.Image = Global.INNOVAMASTER.My.Resources.Resources.actualizarb
        Me.BtnEditar.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.BtnEditar.Location = New System.Drawing.Point(244, 445)
        Me.BtnEditar.Name = "BtnEditar"
        Me.BtnEditar.Size = New System.Drawing.Size(82, 86)
        Me.BtnEditar.TabIndex = 78
        Me.BtnEditar.Text = "&Actualizar"
        Me.BtnEditar.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.BtnEditar.UseVisualStyleBackColor = False
        Me.BtnEditar.Visible = False
        '
        'FrmVenta
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.LightSeaGreen
        Me.ClientSize = New System.Drawing.Size(1354, 571)
        Me.Controls.Add(Me.PictureBox3)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.TxtBusqueda)
        Me.Controls.Add(Me.CboBusqueda)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.BtnNuevoEditar)
        Me.Controls.Add(Me.BtnCancelar)
        Me.Controls.Add(Me.BtnNuevo)
        Me.Controls.Add(Me.BtnInsertar)
        Me.Controls.Add(Me.BtnEditar)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.DgvVenta)
        Me.Controls.Add(Me.GbVenta)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.HelpButton = True
        Me.HelpProvider1.SetHelpNavigator(Me, System.Windows.Forms.HelpNavigator.TableOfContents)
        Me.Name = "FrmVenta"
        Me.HelpProvider1.SetShowHelp(Me, True)
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Venta"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.DgvVenta, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GbVenta.ResumeLayout(False)
        Me.GbVenta.PerformLayout()
        CType(Me.TxtDescuentoExtra.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label11 As Label
    Friend WithEvents DgvVenta As DataGridView
    Friend WithEvents GbVenta As GroupBox
    Friend WithEvents CboTipoVenta As ComboBox
    Friend WithEvents Label5 As Label
    Friend WithEvents CboFormaVenta As ComboBox
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents TxtFechaVenta As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents TxtIdVenta As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents TxtDescuentoExtra As DevExpress.XtraEditors.CalcEdit
    Friend WithEvents LblIdUsuario As Label
    Friend WithEvents TxtFechaVencimientos As DateTimePicker
    Friend WithEvents TxtIdCliente As TextBox
    Friend WithEvents LblNombre As Label
    Friend WithEvents BtnBusquedaCliente As Button
    Friend WithEvents BtnNuevoEditar As Button
    Friend WithEvents BtnCancelar As Button
    Friend WithEvents BtnNuevo As Button
    Friend WithEvents BtnInsertar As Button
    Friend WithEvents BtnEditar As Button
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents Label13 As Label
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label12 As Label
    Friend WithEvents TxtBusqueda As TextBox
    Friend WithEvents CboBusqueda As ComboBox
    Friend WithEvents Button1 As Button
    Friend WithEvents HelpProvider1 As HelpProvider
End Class
