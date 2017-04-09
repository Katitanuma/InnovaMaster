<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmUsuario
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
        Me.Label12 = New System.Windows.Forms.Label()
        Me.TxtBusqueda = New System.Windows.Forms.TextBox()
        Me.CboBusqueda = New System.Windows.Forms.ComboBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.LblRespaldo = New System.Windows.Forms.Label()
        Me.CboId = New System.Windows.Forms.ComboBox()
        Me.GbUsuario = New System.Windows.Forms.GroupBox()
        Me.ChkVer = New System.Windows.Forms.CheckBox()
        Me.CboTipoAcceso = New System.Windows.Forms.ComboBox()
        Me.CboEmpleado = New System.Windows.Forms.ComboBox()
        Me.TxtContra2 = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TxtContra = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.TxtUsuario = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TxtIdUsuario = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.LblFilas = New System.Windows.Forms.Label()
        Me.DgvUsuario = New System.Windows.Forms.DataGridView()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.BtnNuevoEditar = New System.Windows.Forms.Button()
        Me.BtnCancelar = New System.Windows.Forms.Button()
        Me.BtnNuevo = New System.Windows.Forms.Button()
        Me.BtnInsertar = New System.Windows.Forms.Button()
        Me.BtnEditar = New System.Windows.Forms.Button()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.RdbActivo = New System.Windows.Forms.RadioButton()
        Me.RdbInactivo = New System.Windows.Forms.RadioButton()
        Me.GbUsuario.SuspendLayout()
        CType(Me.DgvUsuario, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Comic Sans MS", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.ForeColor = System.Drawing.Color.Black
        Me.Label12.Location = New System.Drawing.Point(854, 61)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(119, 19)
        Me.Label12.TabIndex = 74
        Me.Label12.Text = "Lista de Usuarios"
        '
        'TxtBusqueda
        '
        Me.TxtBusqueda.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtBusqueda.Location = New System.Drawing.Point(803, 25)
        Me.TxtBusqueda.Name = "TxtBusqueda"
        Me.TxtBusqueda.Size = New System.Drawing.Size(530, 21)
        Me.TxtBusqueda.TabIndex = 66
        '
        'CboBusqueda
        '
        Me.CboBusqueda.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CboBusqueda.FormattingEnabled = True
        Me.CboBusqueda.Items.AddRange(New Object() {"Usuario", "Nombre_Completo", "TipoAcceso"})
        Me.CboBusqueda.Location = New System.Drawing.Point(525, 23)
        Me.CboBusqueda.Name = "CboBusqueda"
        Me.CboBusqueda.Size = New System.Drawing.Size(198, 23)
        Me.CboBusqueda.TabIndex = 65
        Me.CboBusqueda.Text = "Usuario"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Monotype Corsiva", 26.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(81, 24)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(256, 43)
        Me.Label13.TabIndex = 71
        Me.Label13.Text = "Perfil del Usuario"
        '
        'LblRespaldo
        '
        Me.LblRespaldo.AutoSize = True
        Me.LblRespaldo.Location = New System.Drawing.Point(400, 22)
        Me.LblRespaldo.Name = "LblRespaldo"
        Me.LblRespaldo.Size = New System.Drawing.Size(0, 13)
        Me.LblRespaldo.TabIndex = 70
        Me.LblRespaldo.Visible = False
        '
        'CboId
        '
        Me.CboId.FormattingEnabled = True
        Me.CboId.Location = New System.Drawing.Point(171, 388)
        Me.CboId.Name = "CboId"
        Me.CboId.Size = New System.Drawing.Size(178, 21)
        Me.CboId.TabIndex = 60
        Me.CboId.Visible = False
        '
        'GbUsuario
        '
        Me.GbUsuario.BackColor = System.Drawing.Color.Transparent
        Me.GbUsuario.Controls.Add(Me.RdbInactivo)
        Me.GbUsuario.Controls.Add(Me.RdbActivo)
        Me.GbUsuario.Controls.Add(Me.Label6)
        Me.GbUsuario.Controls.Add(Me.ChkVer)
        Me.GbUsuario.Controls.Add(Me.CboTipoAcceso)
        Me.GbUsuario.Controls.Add(Me.CboEmpleado)
        Me.GbUsuario.Controls.Add(Me.TxtContra2)
        Me.GbUsuario.Controls.Add(Me.Label5)
        Me.GbUsuario.Controls.Add(Me.Label8)
        Me.GbUsuario.Controls.Add(Me.Label3)
        Me.GbUsuario.Controls.Add(Me.TxtContra)
        Me.GbUsuario.Controls.Add(Me.Label4)
        Me.GbUsuario.Controls.Add(Me.TxtUsuario)
        Me.GbUsuario.Controls.Add(Me.Label2)
        Me.GbUsuario.Controls.Add(Me.TxtIdUsuario)
        Me.GbUsuario.Controls.Add(Me.Label1)
        Me.GbUsuario.Enabled = False
        Me.GbUsuario.Font = New System.Drawing.Font("Comic Sans MS", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GbUsuario.ForeColor = System.Drawing.Color.Black
        Me.GbUsuario.Location = New System.Drawing.Point(30, 74)
        Me.GbUsuario.Name = "GbUsuario"
        Me.GbUsuario.Size = New System.Drawing.Size(435, 296)
        Me.GbUsuario.TabIndex = 69
        Me.GbUsuario.TabStop = False
        '
        'ChkVer
        '
        Me.ChkVer.AutoSize = True
        Me.ChkVer.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ChkVer.Location = New System.Drawing.Point(352, 106)
        Me.ChkVer.Name = "ChkVer"
        Me.ChkVer.Size = New System.Drawing.Size(43, 19)
        Me.ChkVer.TabIndex = 4
        Me.ChkVer.Text = "Ver"
        Me.ChkVer.UseVisualStyleBackColor = True
        '
        'CboTipoAcceso
        '
        Me.CboTipoAcceso.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CboTipoAcceso.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CboTipoAcceso.FormattingEnabled = True
        Me.CboTipoAcceso.Location = New System.Drawing.Point(142, 221)
        Me.CboTipoAcceso.Name = "CboTipoAcceso"
        Me.CboTipoAcceso.Size = New System.Drawing.Size(177, 23)
        Me.CboTipoAcceso.TabIndex = 7
        '
        'CboEmpleado
        '
        Me.CboEmpleado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CboEmpleado.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CboEmpleado.FormattingEnabled = True
        Me.CboEmpleado.Location = New System.Drawing.Point(141, 182)
        Me.CboEmpleado.Name = "CboEmpleado"
        Me.CboEmpleado.Size = New System.Drawing.Size(278, 23)
        Me.CboEmpleado.TabIndex = 6
        '
        'TxtContra2
        '
        Me.TxtContra2.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtContra2.Location = New System.Drawing.Point(141, 144)
        Me.TxtContra2.Name = "TxtContra2"
        Me.TxtContra2.Size = New System.Drawing.Size(204, 21)
        Me.TxtContra2.TabIndex = 5
        Me.TxtContra2.UseSystemPasswordChar = True
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Comic Sans MS", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(9, 146)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(128, 19)
        Me.Label5.TabIndex = 21
        Me.Label5.Text = "Repetir Contraseña"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Comic Sans MS", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(31, 225)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(107, 19)
        Me.Label8.TabIndex = 8
        Me.Label8.Text = "Tipo de Acceso"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Comic Sans MS", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(71, 185)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(67, 19)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "Empleado"
        '
        'TxtContra
        '
        Me.TxtContra.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtContra.Location = New System.Drawing.Point(141, 104)
        Me.TxtContra.Name = "TxtContra"
        Me.TxtContra.Size = New System.Drawing.Size(204, 21)
        Me.TxtContra.TabIndex = 3
        Me.TxtContra.UseSystemPasswordChar = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Comic Sans MS", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(60, 107)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(77, 19)
        Me.Label4.TabIndex = 4
        Me.Label4.Text = "Contraseña"
        '
        'TxtUsuario
        '
        Me.TxtUsuario.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtUsuario.Location = New System.Drawing.Point(141, 66)
        Me.TxtUsuario.Name = "TxtUsuario"
        Me.TxtUsuario.Size = New System.Drawing.Size(204, 21)
        Me.TxtUsuario.TabIndex = 2
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Comic Sans MS", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(82, 64)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(56, 19)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Usuario"
        '
        'TxtIdUsuario
        '
        Me.TxtIdUsuario.Enabled = False
        Me.TxtIdUsuario.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtIdUsuario.Location = New System.Drawing.Point(141, 28)
        Me.TxtIdUsuario.MaxLength = 15
        Me.TxtIdUsuario.Name = "TxtIdUsuario"
        Me.TxtIdUsuario.Size = New System.Drawing.Size(178, 21)
        Me.TxtIdUsuario.TabIndex = 1
        Me.TxtIdUsuario.Tag = ""
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Comic Sans MS", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(35, 27)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(103, 19)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Código Usuario"
        '
        'LblFilas
        '
        Me.LblFilas.AutoSize = True
        Me.LblFilas.Location = New System.Drawing.Point(919, 328)
        Me.LblFilas.Name = "LblFilas"
        Me.LblFilas.Size = New System.Drawing.Size(65, 13)
        Me.LblFilas.TabIndex = 68
        Me.LblFilas.Text = "SIN DATOS"
        Me.LblFilas.Visible = False
        '
        'DgvUsuario
        '
        Me.DgvUsuario.AllowUserToAddRows = False
        Me.DgvUsuario.AllowUserToDeleteRows = False
        Me.DgvUsuario.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DgvUsuario.BackgroundColor = System.Drawing.Color.White
        Me.DgvUsuario.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DgvUsuario.Location = New System.Drawing.Point(493, 82)
        Me.DgvUsuario.Name = "DgvUsuario"
        Me.DgvUsuario.ReadOnly = True
        Me.DgvUsuario.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DgvUsuario.Size = New System.Drawing.Size(840, 456)
        Me.DgvUsuario.TabIndex = 67
        '
        'PictureBox3
        '
        Me.PictureBox3.BackgroundImage = Global.INNOVAMASTER.My.Resources.Resources.lapiz1
        Me.PictureBox3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox3.Location = New System.Drawing.Point(769, 19)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(32, 32)
        Me.PictureBox3.TabIndex = 76
        Me.PictureBox3.TabStop = False
        '
        'PictureBox1
        '
        Me.PictureBox1.BackgroundImage = Global.INNOVAMASTER.My.Resources.Resources.search
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox1.Location = New System.Drawing.Point(495, 18)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(32, 32)
        Me.PictureBox1.TabIndex = 75
        Me.PictureBox1.TabStop = False
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
        Me.BtnNuevoEditar.Location = New System.Drawing.Point(155, 469)
        Me.BtnNuevoEditar.Name = "BtnNuevoEditar"
        Me.BtnNuevoEditar.Size = New System.Drawing.Size(82, 86)
        Me.BtnNuevoEditar.TabIndex = 62
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
        Me.BtnCancelar.Location = New System.Drawing.Point(336, 470)
        Me.BtnCancelar.Name = "BtnCancelar"
        Me.BtnCancelar.Size = New System.Drawing.Size(82, 86)
        Me.BtnCancelar.TabIndex = 63
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
        Me.BtnNuevo.Location = New System.Drawing.Point(60, 469)
        Me.BtnNuevo.Name = "BtnNuevo"
        Me.BtnNuevo.Size = New System.Drawing.Size(82, 86)
        Me.BtnNuevo.TabIndex = 61
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
        Me.BtnInsertar.Location = New System.Drawing.Point(246, 469)
        Me.BtnInsertar.Name = "BtnInsertar"
        Me.BtnInsertar.Size = New System.Drawing.Size(82, 86)
        Me.BtnInsertar.TabIndex = 64
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
        Me.BtnEditar.Location = New System.Drawing.Point(246, 469)
        Me.BtnEditar.Name = "BtnEditar"
        Me.BtnEditar.Size = New System.Drawing.Size(82, 86)
        Me.BtnEditar.TabIndex = 73
        Me.BtnEditar.Text = "&Actualizar"
        Me.BtnEditar.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.BtnEditar.UseVisualStyleBackColor = False
        Me.BtnEditar.Visible = False
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = Global.INNOVAMASTER.My.Resources.Resources.users
        Me.PictureBox2.Location = New System.Drawing.Point(30, 17)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(59, 59)
        Me.PictureBox2.TabIndex = 72
        Me.PictureBox2.TabStop = False
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Comic Sans MS", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(82, 254)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(51, 19)
        Me.Label6.TabIndex = 22
        Me.Label6.Text = "Estado"
        '
        'RdbActivo
        '
        Me.RdbActivo.AutoSize = True
        Me.RdbActivo.Location = New System.Drawing.Point(142, 254)
        Me.RdbActivo.Name = "RdbActivo"
        Me.RdbActivo.Size = New System.Drawing.Size(62, 20)
        Me.RdbActivo.TabIndex = 23
        Me.RdbActivo.TabStop = True
        Me.RdbActivo.Text = "Activo"
        Me.RdbActivo.UseVisualStyleBackColor = True
        '
        'RdbInactivo
        '
        Me.RdbInactivo.AutoSize = True
        Me.RdbInactivo.Location = New System.Drawing.Point(210, 254)
        Me.RdbInactivo.Name = "RdbInactivo"
        Me.RdbInactivo.Size = New System.Drawing.Size(73, 20)
        Me.RdbInactivo.TabIndex = 24
        Me.RdbInactivo.TabStop = True
        Me.RdbInactivo.Text = "Inactivo"
        Me.RdbInactivo.UseVisualStyleBackColor = True
        '
        'FrmUsuario
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.LightSeaGreen
        Me.ClientSize = New System.Drawing.Size(1362, 573)
        Me.Controls.Add(Me.PictureBox3)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.TxtBusqueda)
        Me.Controls.Add(Me.CboBusqueda)
        Me.Controls.Add(Me.BtnNuevoEditar)
        Me.Controls.Add(Me.BtnCancelar)
        Me.Controls.Add(Me.BtnNuevo)
        Me.Controls.Add(Me.BtnInsertar)
        Me.Controls.Add(Me.BtnEditar)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.LblRespaldo)
        Me.Controls.Add(Me.CboId)
        Me.Controls.Add(Me.GbUsuario)
        Me.Controls.Add(Me.LblFilas)
        Me.Controls.Add(Me.DgvUsuario)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Name = "FrmUsuario"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Usuario"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.GbUsuario.ResumeLayout(False)
        Me.GbUsuario.PerformLayout()
        CType(Me.DgvUsuario, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label12 As Label
    Friend WithEvents TxtBusqueda As TextBox
    Friend WithEvents CboBusqueda As ComboBox
    Friend WithEvents BtnNuevoEditar As Button
    Friend WithEvents BtnCancelar As Button
    Friend WithEvents BtnNuevo As Button
    Friend WithEvents BtnInsertar As Button
    Friend WithEvents BtnEditar As Button
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents Label13 As Label
    Friend WithEvents LblRespaldo As Label
    Friend WithEvents CboId As ComboBox
    Friend WithEvents GbUsuario As GroupBox
    Friend WithEvents ChkVer As CheckBox
    Friend WithEvents CboTipoAcceso As ComboBox
    Friend WithEvents CboEmpleado As ComboBox
    Friend WithEvents TxtContra2 As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents TxtContra As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents TxtUsuario As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents TxtIdUsuario As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents LblFilas As Label
    Friend WithEvents DgvUsuario As DataGridView
    Friend WithEvents RdbInactivo As RadioButton
    Friend WithEvents RdbActivo As RadioButton
    Friend WithEvents Label6 As Label
End Class
