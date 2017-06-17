<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmProveedor
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
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.BtnNuevoEditar = New System.Windows.Forms.Button()
        Me.BtnCancelar = New System.Windows.Forms.Button()
        Me.BtnNuevo = New System.Windows.Forms.Button()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.TxtBusqueda = New System.Windows.Forms.TextBox()
        Me.CboBusqueda = New System.Windows.Forms.ComboBox()
        Me.DgvProveedor = New System.Windows.Forms.DataGridView()
        Me.GbProveedor = New System.Windows.Forms.GroupBox()
        Me.TxtDireccionContacto = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.TxtNombreContacto = New System.Windows.Forms.TextBox()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.TxtDireccionEmpresa = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TxtRTN = New System.Windows.Forms.MaskedTextBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.BtnBusquedaMunicipio = New System.Windows.Forms.Button()
        Me.TxtIdProveedor = New System.Windows.Forms.MaskedTextBox()
        Me.TxtTelefono = New System.Windows.Forms.MaskedTextBox()
        Me.RdbFemenino = New System.Windows.Forms.RadioButton()
        Me.RdbMasculino = New System.Windows.Forms.RadioButton()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.CboMunicipio = New System.Windows.Forms.ComboBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.TxtCorreo = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.TxtApellidosContacto = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.TxtNombreEmpresa = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.LblRelacionClienteVenta = New System.Windows.Forms.Label()
        Me.BtnInsertar = New System.Windows.Forms.Button()
        Me.BtnEditar = New System.Windows.Forms.Button()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DgvProveedor, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GbProveedor.SuspendLayout()
        Me.SuspendLayout()
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = Global.INNOVAMASTER.My.Resources.Resources.user
        Me.PictureBox2.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.PictureBox2.Location = New System.Drawing.Point(12, 12)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(59, 59)
        Me.PictureBox2.TabIndex = 69
        Me.PictureBox2.TabStop = False
        '
        'PictureBox3
        '
        Me.PictureBox3.BackgroundImage = Global.INNOVAMASTER.My.Resources.Resources.lapiz1
        Me.PictureBox3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox3.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.PictureBox3.Location = New System.Drawing.Point(758, 13)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(32, 32)
        Me.PictureBox3.TabIndex = 68
        Me.PictureBox3.TabStop = False
        '
        'PictureBox1
        '
        Me.PictureBox1.BackgroundImage = Global.INNOVAMASTER.My.Resources.Resources.search
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox1.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.PictureBox1.Location = New System.Drawing.Point(480, 12)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(32, 32)
        Me.PictureBox1.TabIndex = 67
        Me.PictureBox1.TabStop = False
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Monotype Corsiva", 26.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle))
        Me.Label13.ForeColor = System.Drawing.Color.Black
        Me.Label13.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label13.Location = New System.Drawing.Point(63, 19)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(279, 43)
        Me.Label13.TabIndex = 66
        Me.Label13.Text = "Perfil del Proveedor"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Comic Sans MS", 9.75!, System.Drawing.FontStyle.Bold)
        Me.Label12.ForeColor = System.Drawing.Color.Black
        Me.Label12.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label12.Location = New System.Drawing.Point(829, 53)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(140, 19)
        Me.Label12.TabIndex = 65
        Me.Label12.Text = "Lista de Proveedores"
        '
        'BtnNuevoEditar
        '
        Me.BtnNuevoEditar.BackColor = System.Drawing.Color.LightSeaGreen
        Me.BtnNuevoEditar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BtnNuevoEditar.FlatAppearance.BorderSize = 0
        Me.BtnNuevoEditar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnNuevoEditar.Font = New System.Drawing.Font("Comic Sans MS", 9.75!, System.Drawing.FontStyle.Bold)
        Me.BtnNuevoEditar.Image = Global.INNOVAMASTER.My.Resources.Resources.editar1
        Me.BtnNuevoEditar.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.BtnNuevoEditar.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.BtnNuevoEditar.Location = New System.Drawing.Point(133, 466)
        Me.BtnNuevoEditar.Name = "BtnNuevoEditar"
        Me.BtnNuevoEditar.Size = New System.Drawing.Size(82, 86)
        Me.BtnNuevoEditar.TabIndex = 58
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
        Me.BtnCancelar.Font = New System.Drawing.Font("Comic Sans MS", 9.75!, System.Drawing.FontStyle.Bold)
        Me.BtnCancelar.Image = Global.INNOVAMASTER.My.Resources.Resources.cancelb
        Me.BtnCancelar.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.BtnCancelar.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.BtnCancelar.Location = New System.Drawing.Point(319, 465)
        Me.BtnCancelar.Name = "BtnCancelar"
        Me.BtnCancelar.Size = New System.Drawing.Size(82, 86)
        Me.BtnCancelar.TabIndex = 60
        Me.BtnCancelar.Text = "&Cancelar"
        Me.BtnCancelar.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.BtnCancelar.UseVisualStyleBackColor = False
        '
        'BtnNuevo
        '
        Me.BtnNuevo.BackColor = System.Drawing.Color.LightSeaGreen
        Me.BtnNuevo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BtnNuevo.FlatAppearance.BorderSize = 0
        Me.BtnNuevo.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnNuevo.Font = New System.Drawing.Font("Comic Sans MS", 9.75!, System.Drawing.FontStyle.Bold)
        Me.BtnNuevo.Image = Global.INNOVAMASTER.My.Resources.Resources.nuevo
        Me.BtnNuevo.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.BtnNuevo.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.BtnNuevo.Location = New System.Drawing.Point(38, 466)
        Me.BtnNuevo.Name = "BtnNuevo"
        Me.BtnNuevo.Size = New System.Drawing.Size(82, 86)
        Me.BtnNuevo.TabIndex = 57
        Me.BtnNuevo.Text = "&Nuevo"
        Me.BtnNuevo.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.BtnNuevo.UseVisualStyleBackColor = False
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold)
        Me.Label11.ForeColor = System.Drawing.Color.Black
        Me.Label11.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label11.Location = New System.Drawing.Point(871, 257)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(98, 24)
        Me.Label11.TabIndex = 63
        Me.Label11.Text = "Sin Datos"
        Me.Label11.Visible = False
        '
        'TxtBusqueda
        '
        Me.TxtBusqueda.Font = New System.Drawing.Font("Arial", 9.0!)
        Me.TxtBusqueda.Location = New System.Drawing.Point(792, 19)
        Me.TxtBusqueda.Name = "TxtBusqueda"
        Me.TxtBusqueda.Size = New System.Drawing.Size(518, 21)
        Me.TxtBusqueda.TabIndex = 62
        '
        'CboBusqueda
        '
        Me.CboBusqueda.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CboBusqueda.Font = New System.Drawing.Font("Arial", 9.0!)
        Me.CboBusqueda.FormattingEnabled = True
        Me.CboBusqueda.Items.AddRange(New Object() {"IdProveedor", "RTN", "NombreEmpresa", "NombreContacto", "Municipio"})
        Me.CboBusqueda.Location = New System.Drawing.Point(512, 17)
        Me.CboBusqueda.Name = "CboBusqueda"
        Me.CboBusqueda.Size = New System.Drawing.Size(203, 23)
        Me.CboBusqueda.TabIndex = 61
        '
        'DgvProveedor
        '
        Me.DgvProveedor.AllowUserToAddRows = False
        Me.DgvProveedor.AllowUserToDeleteRows = False
        Me.DgvProveedor.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DgvProveedor.BackgroundColor = System.Drawing.Color.White
        Me.DgvProveedor.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DgvProveedor.Location = New System.Drawing.Point(480, 73)
        Me.DgvProveedor.Name = "DgvProveedor"
        Me.DgvProveedor.ReadOnly = True
        Me.DgvProveedor.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DgvProveedor.Size = New System.Drawing.Size(830, 467)
        Me.DgvProveedor.TabIndex = 56
        '
        'GbProveedor
        '
        Me.GbProveedor.BackColor = System.Drawing.Color.Transparent
        Me.GbProveedor.Controls.Add(Me.TxtDireccionContacto)
        Me.GbProveedor.Controls.Add(Me.Label6)
        Me.GbProveedor.Controls.Add(Me.TxtNombreContacto)
        Me.GbProveedor.Controls.Add(Me.Label15)
        Me.GbProveedor.Controls.Add(Me.TxtDireccionEmpresa)
        Me.GbProveedor.Controls.Add(Me.Label3)
        Me.GbProveedor.Controls.Add(Me.TxtRTN)
        Me.GbProveedor.Controls.Add(Me.Label14)
        Me.GbProveedor.Controls.Add(Me.BtnBusquedaMunicipio)
        Me.GbProveedor.Controls.Add(Me.TxtIdProveedor)
        Me.GbProveedor.Controls.Add(Me.TxtTelefono)
        Me.GbProveedor.Controls.Add(Me.RdbFemenino)
        Me.GbProveedor.Controls.Add(Me.RdbMasculino)
        Me.GbProveedor.Controls.Add(Me.Label5)
        Me.GbProveedor.Controls.Add(Me.CboMunicipio)
        Me.GbProveedor.Controls.Add(Me.Label9)
        Me.GbProveedor.Controls.Add(Me.TxtCorreo)
        Me.GbProveedor.Controls.Add(Me.Label7)
        Me.GbProveedor.Controls.Add(Me.Label8)
        Me.GbProveedor.Controls.Add(Me.TxtApellidosContacto)
        Me.GbProveedor.Controls.Add(Me.Label4)
        Me.GbProveedor.Controls.Add(Me.TxtNombreEmpresa)
        Me.GbProveedor.Controls.Add(Me.Label2)
        Me.GbProveedor.Controls.Add(Me.Label1)
        Me.GbProveedor.Enabled = False
        Me.GbProveedor.Font = New System.Drawing.Font("Comic Sans MS", 9.75!, System.Drawing.FontStyle.Bold)
        Me.GbProveedor.ForeColor = System.Drawing.Color.Black
        Me.GbProveedor.Location = New System.Drawing.Point(12, 64)
        Me.GbProveedor.Name = "GbProveedor"
        Me.GbProveedor.Size = New System.Drawing.Size(440, 402)
        Me.GbProveedor.TabIndex = 55
        Me.GbProveedor.TabStop = False
        '
        'TxtDireccionContacto
        '
        Me.TxtDireccionContacto.Font = New System.Drawing.Font("Arial", 9.0!)
        Me.TxtDireccionContacto.Location = New System.Drawing.Point(133, 209)
        Me.TxtDireccionContacto.Multiline = True
        Me.TxtDireccionContacto.Name = "TxtDireccionContacto"
        Me.TxtDireccionContacto.Size = New System.Drawing.Size(291, 38)
        Me.TxtDireccionContacto.TabIndex = 61
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Comic Sans MS", 9.75!, System.Drawing.FontStyle.Bold)
        Me.Label6.ForeColor = System.Drawing.Color.Black
        Me.Label6.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label6.Location = New System.Drawing.Point(8, 205)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(128, 19)
        Me.Label6.TabIndex = 62
        Me.Label6.Text = "Dirección Contacto"
        '
        'TxtNombreContacto
        '
        Me.TxtNombreContacto.Font = New System.Drawing.Font("Arial", 9.0!)
        Me.TxtNombreContacto.Location = New System.Drawing.Point(133, 155)
        Me.TxtNombreContacto.Name = "TxtNombreContacto"
        Me.TxtNombreContacto.Size = New System.Drawing.Size(256, 21)
        Me.TxtNombreContacto.TabIndex = 59
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Comic Sans MS", 9.75!, System.Drawing.FontStyle.Bold)
        Me.Label15.ForeColor = System.Drawing.Color.Black
        Me.Label15.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label15.Location = New System.Drawing.Point(11, 155)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(125, 19)
        Me.Label15.TabIndex = 60
        Me.Label15.Text = "Nombres Contacto"
        '
        'TxtDireccionEmpresa
        '
        Me.TxtDireccionEmpresa.Font = New System.Drawing.Font("Arial", 9.0!)
        Me.TxtDireccionEmpresa.Location = New System.Drawing.Point(133, 111)
        Me.TxtDireccionEmpresa.Multiline = True
        Me.TxtDireccionEmpresa.Name = "TxtDireccionEmpresa"
        Me.TxtDireccionEmpresa.Size = New System.Drawing.Size(291, 38)
        Me.TxtDireccionEmpresa.TabIndex = 57
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Comic Sans MS", 9.75!, System.Drawing.FontStyle.Bold)
        Me.Label3.ForeColor = System.Drawing.Color.Black
        Me.Label3.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label3.Location = New System.Drawing.Point(8, 107)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(124, 19)
        Me.Label3.TabIndex = 58
        Me.Label3.Text = "Dirección Empresa"
        '
        'TxtRTN
        '
        Me.TxtRTN.Font = New System.Drawing.Font("Arial", 9.0!)
        Me.TxtRTN.Location = New System.Drawing.Point(133, 54)
        Me.TxtRTN.Mask = "0000-0000-00000"
        Me.TxtRTN.Name = "TxtRTN"
        Me.TxtRTN.PromptChar = Global.Microsoft.VisualBasic.ChrW(32)
        Me.TxtRTN.Size = New System.Drawing.Size(131, 21)
        Me.TxtRTN.TabIndex = 56
        Me.TxtRTN.Tag = ""
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Comic Sans MS", 9.75!, System.Drawing.FontStyle.Bold)
        Me.Label14.ForeColor = System.Drawing.Color.Black
        Me.Label14.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label14.Location = New System.Drawing.Point(93, 55)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(37, 19)
        Me.Label14.TabIndex = 55
        Me.Label14.Text = "RTN"
        '
        'BtnBusquedaMunicipio
        '
        Me.BtnBusquedaMunicipio.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold)
        Me.BtnBusquedaMunicipio.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.BtnBusquedaMunicipio.Location = New System.Drawing.Point(347, 310)
        Me.BtnBusquedaMunicipio.Name = "BtnBusquedaMunicipio"
        Me.BtnBusquedaMunicipio.Size = New System.Drawing.Size(33, 24)
        Me.BtnBusquedaMunicipio.TabIndex = 54
        Me.BtnBusquedaMunicipio.Text = " ..."
        Me.BtnBusquedaMunicipio.UseVisualStyleBackColor = True
        '
        'TxtIdProveedor
        '
        Me.TxtIdProveedor.Font = New System.Drawing.Font("Arial", 9.0!)
        Me.TxtIdProveedor.Location = New System.Drawing.Point(133, 25)
        Me.TxtIdProveedor.Mask = "0000-0000-00000"
        Me.TxtIdProveedor.Name = "TxtIdProveedor"
        Me.TxtIdProveedor.PromptChar = Global.Microsoft.VisualBasic.ChrW(32)
        Me.TxtIdProveedor.Size = New System.Drawing.Size(131, 21)
        Me.TxtIdProveedor.TabIndex = 1
        Me.TxtIdProveedor.Tag = ""
        '
        'TxtTelefono
        '
        Me.TxtTelefono.Font = New System.Drawing.Font("Arial", 9.0!)
        Me.TxtTelefono.Location = New System.Drawing.Point(133, 253)
        Me.TxtTelefono.Mask = "0000-0000"
        Me.TxtTelefono.Name = "TxtTelefono"
        Me.TxtTelefono.PromptChar = Global.Microsoft.VisualBasic.ChrW(32)
        Me.TxtTelefono.Size = New System.Drawing.Size(81, 21)
        Me.TxtTelefono.TabIndex = 5
        '
        'RdbFemenino
        '
        Me.RdbFemenino.AutoSize = True
        Me.RdbFemenino.Font = New System.Drawing.Font("Arial", 9.0!)
        Me.RdbFemenino.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.RdbFemenino.Location = New System.Drawing.Point(221, 346)
        Me.RdbFemenino.Name = "RdbFemenino"
        Me.RdbFemenino.Size = New System.Drawing.Size(81, 19)
        Me.RdbFemenino.TabIndex = 13
        Me.RdbFemenino.TabStop = True
        Me.RdbFemenino.Text = "Femenino"
        Me.RdbFemenino.UseVisualStyleBackColor = True
        '
        'RdbMasculino
        '
        Me.RdbMasculino.AutoSize = True
        Me.RdbMasculino.Font = New System.Drawing.Font("Arial", 9.0!)
        Me.RdbMasculino.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.RdbMasculino.Location = New System.Drawing.Point(135, 346)
        Me.RdbMasculino.Name = "RdbMasculino"
        Me.RdbMasculino.Size = New System.Drawing.Size(81, 19)
        Me.RdbMasculino.TabIndex = 12
        Me.RdbMasculino.TabStop = True
        Me.RdbMasculino.Text = "Masculino"
        Me.RdbMasculino.UseVisualStyleBackColor = True
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Comic Sans MS", 9.75!, System.Drawing.FontStyle.Bold)
        Me.Label5.ForeColor = System.Drawing.Color.Black
        Me.Label5.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label5.Location = New System.Drawing.Point(28, 345)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(101, 19)
        Me.Label5.TabIndex = 28
        Me.Label5.Text = "Sexo Contacto"
        '
        'CboMunicipio
        '
        Me.CboMunicipio.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CboMunicipio.Font = New System.Drawing.Font("Arial", 9.0!)
        Me.CboMunicipio.FormattingEnabled = True
        Me.CboMunicipio.Location = New System.Drawing.Point(133, 311)
        Me.CboMunicipio.Name = "CboMunicipio"
        Me.CboMunicipio.Size = New System.Drawing.Size(208, 23)
        Me.CboMunicipio.TabIndex = 10
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Comic Sans MS", 9.75!, System.Drawing.FontStyle.Bold)
        Me.Label9.ForeColor = System.Drawing.Color.Black
        Me.Label9.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label9.Location = New System.Drawing.Point(63, 312)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(67, 19)
        Me.Label9.TabIndex = 16
        Me.Label9.Text = "Municipio"
        '
        'TxtCorreo
        '
        Me.TxtCorreo.Font = New System.Drawing.Font("Arial", 9.0!)
        Me.TxtCorreo.Location = New System.Drawing.Point(133, 284)
        Me.TxtCorreo.Name = "TxtCorreo"
        Me.TxtCorreo.Size = New System.Drawing.Size(291, 21)
        Me.TxtCorreo.TabIndex = 6
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Comic Sans MS", 9.75!, System.Drawing.FontStyle.Bold)
        Me.Label7.ForeColor = System.Drawing.Color.Black
        Me.Label7.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label7.Location = New System.Drawing.Point(81, 283)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(50, 19)
        Me.Label7.TabIndex = 10
        Me.Label7.Text = "Correo"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Comic Sans MS", 9.75!, System.Drawing.FontStyle.Bold)
        Me.Label8.ForeColor = System.Drawing.Color.Black
        Me.Label8.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label8.Location = New System.Drawing.Point(68, 253)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(64, 19)
        Me.Label8.TabIndex = 8
        Me.Label8.Text = "Teléfono"
        '
        'TxtApellidosContacto
        '
        Me.TxtApellidosContacto.Font = New System.Drawing.Font("Arial", 9.0!)
        Me.TxtApellidosContacto.Location = New System.Drawing.Point(133, 182)
        Me.TxtApellidosContacto.Name = "TxtApellidosContacto"
        Me.TxtApellidosContacto.Size = New System.Drawing.Size(256, 21)
        Me.TxtApellidosContacto.TabIndex = 3
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Comic Sans MS", 9.75!, System.Drawing.FontStyle.Bold)
        Me.Label4.ForeColor = System.Drawing.Color.Black
        Me.Label4.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label4.Location = New System.Drawing.Point(5, 182)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(127, 19)
        Me.Label4.TabIndex = 4
        Me.Label4.Text = "Apellidos Contacto"
        '
        'TxtNombreEmpresa
        '
        Me.TxtNombreEmpresa.Font = New System.Drawing.Font("Arial", 9.0!)
        Me.TxtNombreEmpresa.Location = New System.Drawing.Point(133, 84)
        Me.TxtNombreEmpresa.Name = "TxtNombreEmpresa"
        Me.TxtNombreEmpresa.Size = New System.Drawing.Size(256, 21)
        Me.TxtNombreEmpresa.TabIndex = 2
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Comic Sans MS", 9.75!, System.Drawing.FontStyle.Bold)
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label2.Location = New System.Drawing.Point(17, 84)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(115, 19)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Nombre Empresa"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Comic Sans MS", 9.75!, System.Drawing.FontStyle.Bold)
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label1.Location = New System.Drawing.Point(19, 26)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(117, 19)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Código Proveedor"
        '
        'LblRelacionClienteVenta
        '
        Me.LblRelacionClienteVenta.AutoSize = True
        Me.LblRelacionClienteVenta.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.LblRelacionClienteVenta.Location = New System.Drawing.Point(460, 39)
        Me.LblRelacionClienteVenta.Name = "LblRelacionClienteVenta"
        Me.LblRelacionClienteVenta.Size = New System.Drawing.Size(13, 13)
        Me.LblRelacionClienteVenta.TabIndex = 54
        Me.LblRelacionClienteVenta.Text = "0"
        Me.LblRelacionClienteVenta.Visible = False
        '
        'BtnInsertar
        '
        Me.BtnInsertar.BackColor = System.Drawing.Color.LightSeaGreen
        Me.BtnInsertar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BtnInsertar.FlatAppearance.BorderSize = 0
        Me.BtnInsertar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnInsertar.Font = New System.Drawing.Font("Comic Sans MS", 9.75!, System.Drawing.FontStyle.Bold)
        Me.BtnInsertar.Image = Global.INNOVAMASTER.My.Resources.Resources.guardar
        Me.BtnInsertar.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.BtnInsertar.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.BtnInsertar.Location = New System.Drawing.Point(229, 464)
        Me.BtnInsertar.Name = "BtnInsertar"
        Me.BtnInsertar.Size = New System.Drawing.Size(82, 86)
        Me.BtnInsertar.TabIndex = 59
        Me.BtnInsertar.Text = "&Guardar"
        Me.BtnInsertar.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.BtnInsertar.UseVisualStyleBackColor = False
        '
        'BtnEditar
        '
        Me.BtnEditar.BackColor = System.Drawing.Color.LightSeaGreen
        Me.BtnEditar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BtnEditar.FlatAppearance.BorderSize = 0
        Me.BtnEditar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnEditar.Font = New System.Drawing.Font("Comic Sans MS", 9.75!, System.Drawing.FontStyle.Bold)
        Me.BtnEditar.Image = Global.INNOVAMASTER.My.Resources.Resources.actualizarb
        Me.BtnEditar.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.BtnEditar.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.BtnEditar.Location = New System.Drawing.Point(229, 464)
        Me.BtnEditar.Name = "BtnEditar"
        Me.BtnEditar.Size = New System.Drawing.Size(82, 86)
        Me.BtnEditar.TabIndex = 64
        Me.BtnEditar.Text = "&Actualizar"
        Me.BtnEditar.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.BtnEditar.UseVisualStyleBackColor = False
        '
        'FrmProveedor
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.LightSeaGreen
        Me.ClientSize = New System.Drawing.Size(1362, 579)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.PictureBox3)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.BtnNuevoEditar)
        Me.Controls.Add(Me.BtnCancelar)
        Me.Controls.Add(Me.BtnNuevo)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.TxtBusqueda)
        Me.Controls.Add(Me.CboBusqueda)
        Me.Controls.Add(Me.DgvProveedor)
        Me.Controls.Add(Me.GbProveedor)
        Me.Controls.Add(Me.LblRelacionClienteVenta)
        Me.Controls.Add(Me.BtnInsertar)
        Me.Controls.Add(Me.BtnEditar)
        Me.Name = "FrmProveedor"
        Me.Text = "Proveedor"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DgvProveedor, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GbProveedor.ResumeLayout(False)
        Me.GbProveedor.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label13 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents BtnNuevoEditar As Button
    Friend WithEvents BtnCancelar As Button
    Friend WithEvents BtnNuevo As Button
    Friend WithEvents Label11 As Label
    Friend WithEvents TxtBusqueda As TextBox
    Friend WithEvents CboBusqueda As ComboBox
    Friend WithEvents DgvProveedor As DataGridView
    Friend WithEvents GbProveedor As GroupBox
    Friend WithEvents TxtDireccionEmpresa As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents TxtRTN As MaskedTextBox
    Friend WithEvents Label14 As Label
    Friend WithEvents BtnBusquedaMunicipio As Button
    Friend WithEvents TxtIdProveedor As MaskedTextBox
    Friend WithEvents TxtTelefono As MaskedTextBox
    Friend WithEvents RdbFemenino As RadioButton
    Friend WithEvents RdbMasculino As RadioButton
    Friend WithEvents Label5 As Label
    Friend WithEvents CboMunicipio As ComboBox
    Friend WithEvents Label9 As Label
    Friend WithEvents TxtCorreo As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents TxtApellidosContacto As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents TxtNombreEmpresa As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents LblRelacionClienteVenta As Label
    Friend WithEvents BtnInsertar As Button
    Friend WithEvents BtnEditar As Button
    Friend WithEvents TxtNombreContacto As TextBox
    Friend WithEvents Label15 As Label
    Friend WithEvents TxtDireccionContacto As TextBox
    Friend WithEvents Label6 As Label
End Class
