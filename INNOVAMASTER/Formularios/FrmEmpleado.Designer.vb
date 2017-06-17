<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmEmpleado
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
        Me.components = New System.ComponentModel.Container()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.TxtBusqueda = New System.Windows.Forms.TextBox()
        Me.CboBusqueda = New System.Windows.Forms.ComboBox()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.DgvEmpleado = New System.Windows.Forms.DataGridView()
        Me.GbEmpleado = New System.Windows.Forms.GroupBox()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.BtnBusquedaCliente = New System.Windows.Forms.Button()
        Me.TxtIdEmpleado = New System.Windows.Forms.MaskedTextBox()
        Me.TxtApellidos = New System.Windows.Forms.TextBox()
        Me.TxtNombres = New System.Windows.Forms.TextBox()
        Me.TxtCelular = New System.Windows.Forms.MaskedTextBox()
        Me.TxtTelefono = New System.Windows.Forms.MaskedTextBox()
        Me.PbEmpleado = New System.Windows.Forms.PictureBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.BtnEliminarImagen = New System.Windows.Forms.Button()
        Me.BtnAgregarImagen = New System.Windows.Forms.Button()
        Me.CboProfesion = New System.Windows.Forms.ComboBox()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.CboSucursal = New System.Windows.Forms.ComboBox()
        Me.CboCargo = New System.Windows.Forms.ComboBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.CboAñoC = New System.Windows.Forms.ComboBox()
        Me.CboMesC = New System.Windows.Forms.ComboBox()
        Me.CboDiaC = New System.Windows.Forms.ComboBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.RdbFemenino = New System.Windows.Forms.RadioButton()
        Me.CmbAñoN = New System.Windows.Forms.ComboBox()
        Me.RdbMasculino = New System.Windows.Forms.RadioButton()
        Me.CmbMesN = New System.Windows.Forms.ComboBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.CmbDiaN = New System.Windows.Forms.ComboBox()
        Me.CmbEstadoCivil = New System.Windows.Forms.ComboBox()
        Me.CmbMunicipio = New System.Windows.Forms.ComboBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.TxtDireccion = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.BtnNuevoEditar = New System.Windows.Forms.Button()
        Me.BtnCancelar = New System.Windows.Forms.Button()
        Me.BtnNuevo = New System.Windows.Forms.Button()
        Me.BtnEditar = New System.Windows.Forms.Button()
        Me.BtnInsertar = New System.Windows.Forms.Button()
        CType(Me.DgvEmpleado, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GbEmpleado.SuspendLayout()
        CType(Me.PbEmpleado, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Font = New System.Drawing.Font("Comic Sans MS", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.ForeColor = System.Drawing.Color.Black
        Me.Label17.Location = New System.Drawing.Point(876, 41)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(130, 19)
        Me.Label17.TabIndex = 61
        Me.Label17.Text = "Lista de Empleados"
        '
        'TxtBusqueda
        '
        Me.TxtBusqueda.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtBusqueda.Location = New System.Drawing.Point(865, 11)
        Me.TxtBusqueda.Name = "TxtBusqueda"
        Me.TxtBusqueda.Size = New System.Drawing.Size(456, 21)
        Me.TxtBusqueda.TabIndex = 54
        '
        'CboBusqueda
        '
        Me.CboBusqueda.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CboBusqueda.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CboBusqueda.FormattingEnabled = True
        Me.CboBusqueda.Items.AddRange(New Object() {"IdEmpleado", "NombreEmpleado", "ApellidoEmpleado", "Municipio", "Cargo", "Profesion", "Sexo"})
        Me.CboBusqueda.Location = New System.Drawing.Point(603, 9)
        Me.CboBusqueda.Name = "CboBusqueda"
        Me.CboBusqueda.Size = New System.Drawing.Size(203, 23)
        Me.CboBusqueda.TabIndex = 53
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Font = New System.Drawing.Font("Monotype Corsiva", 26.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.Location = New System.Drawing.Point(69, 2)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(280, 43)
        Me.Label16.TabIndex = 59
        Me.Label16.Text = "Perfil del Empleado"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(885, 265)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(98, 24)
        Me.Label11.TabIndex = 57
        Me.Label11.Text = "Sin Datos"
        Me.Label11.Visible = False
        '
        'DgvEmpleado
        '
        Me.DgvEmpleado.AllowUserToAddRows = False
        Me.DgvEmpleado.AllowUserToDeleteRows = False
        Me.DgvEmpleado.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DgvEmpleado.BackgroundColor = System.Drawing.Color.White
        Me.DgvEmpleado.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DgvEmpleado.Location = New System.Drawing.Point(571, 61)
        Me.DgvEmpleado.Name = "DgvEmpleado"
        Me.DgvEmpleado.ReadOnly = True
        Me.DgvEmpleado.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DgvEmpleado.Size = New System.Drawing.Size(779, 485)
        Me.DgvEmpleado.TabIndex = 56
        '
        'GbEmpleado
        '
        Me.GbEmpleado.BackColor = System.Drawing.Color.Transparent
        Me.GbEmpleado.Controls.Add(Me.Button2)
        Me.GbEmpleado.Controls.Add(Me.Button1)
        Me.GbEmpleado.Controls.Add(Me.BtnBusquedaCliente)
        Me.GbEmpleado.Controls.Add(Me.TxtIdEmpleado)
        Me.GbEmpleado.Controls.Add(Me.TxtApellidos)
        Me.GbEmpleado.Controls.Add(Me.TxtNombres)
        Me.GbEmpleado.Controls.Add(Me.TxtCelular)
        Me.GbEmpleado.Controls.Add(Me.TxtTelefono)
        Me.GbEmpleado.Controls.Add(Me.PbEmpleado)
        Me.GbEmpleado.Controls.Add(Me.Panel1)
        Me.GbEmpleado.Controls.Add(Me.CboProfesion)
        Me.GbEmpleado.Controls.Add(Me.Label15)
        Me.GbEmpleado.Controls.Add(Me.CboSucursal)
        Me.GbEmpleado.Controls.Add(Me.CboCargo)
        Me.GbEmpleado.Controls.Add(Me.Label13)
        Me.GbEmpleado.Controls.Add(Me.Label14)
        Me.GbEmpleado.Controls.Add(Me.CboAñoC)
        Me.GbEmpleado.Controls.Add(Me.CboMesC)
        Me.GbEmpleado.Controls.Add(Me.CboDiaC)
        Me.GbEmpleado.Controls.Add(Me.Label12)
        Me.GbEmpleado.Controls.Add(Me.RdbFemenino)
        Me.GbEmpleado.Controls.Add(Me.CmbAñoN)
        Me.GbEmpleado.Controls.Add(Me.RdbMasculino)
        Me.GbEmpleado.Controls.Add(Me.CmbMesN)
        Me.GbEmpleado.Controls.Add(Me.Label5)
        Me.GbEmpleado.Controls.Add(Me.CmbDiaN)
        Me.GbEmpleado.Controls.Add(Me.CmbEstadoCivil)
        Me.GbEmpleado.Controls.Add(Me.CmbMunicipio)
        Me.GbEmpleado.Controls.Add(Me.Label10)
        Me.GbEmpleado.Controls.Add(Me.Label9)
        Me.GbEmpleado.Controls.Add(Me.Label6)
        Me.GbEmpleado.Controls.Add(Me.Label7)
        Me.GbEmpleado.Controls.Add(Me.Label8)
        Me.GbEmpleado.Controls.Add(Me.TxtDireccion)
        Me.GbEmpleado.Controls.Add(Me.Label3)
        Me.GbEmpleado.Controls.Add(Me.Label4)
        Me.GbEmpleado.Controls.Add(Me.Label2)
        Me.GbEmpleado.Controls.Add(Me.Label1)
        Me.GbEmpleado.Font = New System.Drawing.Font("Comic Sans MS", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GbEmpleado.ForeColor = System.Drawing.Color.Black
        Me.GbEmpleado.Location = New System.Drawing.Point(16, 42)
        Me.GbEmpleado.Name = "GbEmpleado"
        Me.GbEmpleado.Size = New System.Drawing.Size(530, 430)
        Me.GbEmpleado.TabIndex = 55
        Me.GbEmpleado.TabStop = False
        '
        'Button2
        '
        Me.Button2.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.Location = New System.Drawing.Point(292, 341)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(33, 24)
        Me.Button2.TabIndex = 53
        Me.Button2.Text = " ..."
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(495, 268)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(33, 24)
        Me.Button1.TabIndex = 52
        Me.Button1.Text = " ..."
        Me.Button1.UseVisualStyleBackColor = True
        '
        'BtnBusquedaCliente
        '
        Me.BtnBusquedaCliente.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnBusquedaCliente.Location = New System.Drawing.Point(298, 269)
        Me.BtnBusquedaCliente.Name = "BtnBusquedaCliente"
        Me.BtnBusquedaCliente.Size = New System.Drawing.Size(33, 24)
        Me.BtnBusquedaCliente.TabIndex = 51
        Me.BtnBusquedaCliente.Text = " ..."
        Me.BtnBusquedaCliente.UseVisualStyleBackColor = True
        '
        'TxtIdEmpleado
        '
        Me.TxtIdEmpleado.Font = New System.Drawing.Font("Arial", 9.0!)
        Me.TxtIdEmpleado.Location = New System.Drawing.Point(155, 25)
        Me.TxtIdEmpleado.Mask = "0000-0000-00000"
        Me.TxtIdEmpleado.Name = "TxtIdEmpleado"
        Me.TxtIdEmpleado.PromptChar = Global.Microsoft.VisualBasic.ChrW(32)
        Me.TxtIdEmpleado.Size = New System.Drawing.Size(131, 21)
        Me.TxtIdEmpleado.TabIndex = 48
        Me.TxtIdEmpleado.Tag = ""
        '
        'TxtApellidos
        '
        Me.TxtApellidos.Font = New System.Drawing.Font("Arial", 9.0!)
        Me.TxtApellidos.Location = New System.Drawing.Point(155, 92)
        Me.TxtApellidos.Name = "TxtApellidos"
        Me.TxtApellidos.Size = New System.Drawing.Size(219, 21)
        Me.TxtApellidos.TabIndex = 50
        '
        'TxtNombres
        '
        Me.TxtNombres.Font = New System.Drawing.Font("Arial", 9.0!)
        Me.TxtNombres.Location = New System.Drawing.Point(155, 58)
        Me.TxtNombres.Name = "TxtNombres"
        Me.TxtNombres.Size = New System.Drawing.Size(219, 21)
        Me.TxtNombres.TabIndex = 49
        '
        'TxtCelular
        '
        Me.TxtCelular.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtCelular.Location = New System.Drawing.Point(386, 199)
        Me.TxtCelular.Mask = "0000-0000"
        Me.TxtCelular.Name = "TxtCelular"
        Me.TxtCelular.PromptChar = Global.Microsoft.VisualBasic.ChrW(32)
        Me.TxtCelular.Size = New System.Drawing.Size(113, 21)
        Me.TxtCelular.TabIndex = 6
        '
        'TxtTelefono
        '
        Me.TxtTelefono.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtTelefono.Location = New System.Drawing.Point(154, 199)
        Me.TxtTelefono.Mask = "0000-0000"
        Me.TxtTelefono.Name = "TxtTelefono"
        Me.TxtTelefono.PromptChar = Global.Microsoft.VisualBasic.ChrW(32)
        Me.TxtTelefono.Size = New System.Drawing.Size(107, 21)
        Me.TxtTelefono.TabIndex = 5
        '
        'PbEmpleado
        '
        Me.PbEmpleado.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PbEmpleado.Location = New System.Drawing.Point(388, 23)
        Me.PbEmpleado.Name = "PbEmpleado"
        Me.PbEmpleado.Size = New System.Drawing.Size(130, 131)
        Me.PbEmpleado.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PbEmpleado.TabIndex = 47
        Me.PbEmpleado.TabStop = False
        '
        'Panel1
        '
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.BtnEliminarImagen)
        Me.Panel1.Controls.Add(Me.BtnAgregarImagen)
        Me.Panel1.Location = New System.Drawing.Point(388, 153)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(130, 39)
        Me.Panel1.TabIndex = 47
        '
        'BtnEliminarImagen
        '
        Me.BtnEliminarImagen.BackgroundImage = Global.INNOVAMASTER.My.Resources.Resources.image_remove
        Me.BtnEliminarImagen.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BtnEliminarImagen.Location = New System.Drawing.Point(76, 3)
        Me.BtnEliminarImagen.Name = "BtnEliminarImagen"
        Me.BtnEliminarImagen.Size = New System.Drawing.Size(30, 30)
        Me.BtnEliminarImagen.TabIndex = 46
        Me.ToolTip1.SetToolTip(Me.BtnEliminarImagen, "Eliminar Imagen")
        Me.BtnEliminarImagen.UseVisualStyleBackColor = True
        '
        'BtnAgregarImagen
        '
        Me.BtnAgregarImagen.BackgroundImage = Global.INNOVAMASTER.My.Resources.Resources.image_add1
        Me.BtnAgregarImagen.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BtnAgregarImagen.Location = New System.Drawing.Point(23, 3)
        Me.BtnAgregarImagen.Name = "BtnAgregarImagen"
        Me.BtnAgregarImagen.Size = New System.Drawing.Size(30, 30)
        Me.BtnAgregarImagen.TabIndex = 45
        Me.BtnAgregarImagen.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.ToolTip1.SetToolTip(Me.BtnAgregarImagen, "Agregar Imagen")
        Me.BtnAgregarImagen.UseVisualStyleBackColor = True
        '
        'CboProfesion
        '
        Me.CboProfesion.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CboProfesion.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CboProfesion.FormattingEnabled = True
        Me.CboProfesion.Location = New System.Drawing.Point(154, 342)
        Me.CboProfesion.Name = "CboProfesion"
        Me.CboProfesion.Size = New System.Drawing.Size(132, 23)
        Me.CboProfesion.TabIndex = 15
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Comic Sans MS", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.Location = New System.Drawing.Point(86, 343)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(67, 19)
        Me.Label15.TabIndex = 39
        Me.Label15.Text = "Profesión"
        '
        'CboSucursal
        '
        Me.CboSucursal.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CboSucursal.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CboSucursal.FormattingEnabled = True
        Me.CboSucursal.Location = New System.Drawing.Point(386, 343)
        Me.CboSucursal.Name = "CboSucursal"
        Me.CboSucursal.Size = New System.Drawing.Size(133, 23)
        Me.CboSucursal.TabIndex = 16
        '
        'CboCargo
        '
        Me.CboCargo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CboCargo.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CboCargo.FormattingEnabled = True
        Me.CboCargo.Location = New System.Drawing.Point(386, 269)
        Me.CboCargo.Name = "CboCargo"
        Me.CboCargo.Size = New System.Drawing.Size(105, 23)
        Me.CboCargo.TabIndex = 11
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Comic Sans MS", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(324, 343)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(62, 19)
        Me.Label13.TabIndex = 36
        Me.Label13.Text = "Sucursal"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Comic Sans MS", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.Location = New System.Drawing.Point(341, 271)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(44, 19)
        Me.Label14.TabIndex = 35
        Me.Label14.Text = "Cargo"
        '
        'CboAñoC
        '
        Me.CboAñoC.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CboAñoC.FormattingEnabled = True
        Me.CboAñoC.Location = New System.Drawing.Point(337, 306)
        Me.CboAñoC.Name = "CboAñoC"
        Me.CboAñoC.Size = New System.Drawing.Size(73, 23)
        Me.CboAñoC.TabIndex = 14
        Me.CboAñoC.Text = "Año"
        '
        'CboMesC
        '
        Me.CboMesC.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CboMesC.FormattingEnabled = True
        Me.CboMesC.Items.AddRange(New Object() {"Enero", "Febrero", "Marzo", "Abril", "Mayo", "Junio", "Julio", "Agosto", "Septiembre", "Octubre", "Noviembre", "Diciembre"})
        Me.CboMesC.Location = New System.Drawing.Point(218, 306)
        Me.CboMesC.Name = "CboMesC"
        Me.CboMesC.Size = New System.Drawing.Size(113, 23)
        Me.CboMesC.TabIndex = 13
        Me.CboMesC.Text = "Mes"
        '
        'CboDiaC
        '
        Me.CboDiaC.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CboDiaC.FormattingEnabled = True
        Me.CboDiaC.Items.AddRange(New Object() {"01", "02", "03", "04", "05", "06", "07", "08", "09", "10", "11", "12", "13", "14", "15", "16", "17", "18", "19", "20", "21", "22", "23", "24", "25", "26", "27", "28", "29", "30", "31"})
        Me.CboDiaC.Location = New System.Drawing.Point(154, 306)
        Me.CboDiaC.Name = "CboDiaC"
        Me.CboDiaC.Size = New System.Drawing.Size(58, 23)
        Me.CboDiaC.TabIndex = 12
        Me.CboDiaC.Text = "Dia"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Comic Sans MS", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(2, 306)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(152, 19)
        Me.Label12.TabIndex = 31
        Me.Label12.Text = "Fecha de Contratación"
        '
        'RdbFemenino
        '
        Me.RdbFemenino.AutoSize = True
        Me.RdbFemenino.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RdbFemenino.Location = New System.Drawing.Point(247, 406)
        Me.RdbFemenino.Name = "RdbFemenino"
        Me.RdbFemenino.Size = New System.Drawing.Size(81, 19)
        Me.RdbFemenino.TabIndex = 19
        Me.RdbFemenino.TabStop = True
        Me.RdbFemenino.Text = "Femenino"
        Me.RdbFemenino.UseVisualStyleBackColor = True
        '
        'CmbAñoN
        '
        Me.CmbAñoN.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CmbAñoN.FormattingEnabled = True
        Me.CmbAñoN.Location = New System.Drawing.Point(337, 233)
        Me.CmbAñoN.Name = "CmbAñoN"
        Me.CmbAñoN.Size = New System.Drawing.Size(73, 23)
        Me.CmbAñoN.TabIndex = 9
        Me.CmbAñoN.Text = "Año"
        '
        'RdbMasculino
        '
        Me.RdbMasculino.AutoSize = True
        Me.RdbMasculino.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RdbMasculino.Location = New System.Drawing.Point(160, 406)
        Me.RdbMasculino.Name = "RdbMasculino"
        Me.RdbMasculino.Size = New System.Drawing.Size(81, 19)
        Me.RdbMasculino.TabIndex = 18
        Me.RdbMasculino.TabStop = True
        Me.RdbMasculino.Text = "Masculino"
        Me.RdbMasculino.UseVisualStyleBackColor = True
        '
        'CmbMesN
        '
        Me.CmbMesN.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CmbMesN.FormattingEnabled = True
        Me.CmbMesN.Items.AddRange(New Object() {"Enero", "Febrero", "Marzo", "Abril", "Mayo", "Junio", "Julio", "Agosto", "Septiembre", "Octubre", "Noviembre", "Diciembre"})
        Me.CmbMesN.Location = New System.Drawing.Point(218, 233)
        Me.CmbMesN.Name = "CmbMesN"
        Me.CmbMesN.Size = New System.Drawing.Size(113, 23)
        Me.CmbMesN.TabIndex = 8
        Me.CmbMesN.Text = "Mes"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Comic Sans MS", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(114, 405)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(40, 19)
        Me.Label5.TabIndex = 28
        Me.Label5.Text = "Sexo"
        '
        'CmbDiaN
        '
        Me.CmbDiaN.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CmbDiaN.FormattingEnabled = True
        Me.CmbDiaN.Items.AddRange(New Object() {"01", "02", "03", "04", "05", "06", "07", "08", "09", "10", "11", "12", "13", "14", "15", "16", "17", "18", "19", "20", "21", "22", "23", "24", "25", "26", "27", "28", "29", "30", "31"})
        Me.CmbDiaN.Location = New System.Drawing.Point(154, 233)
        Me.CmbDiaN.Name = "CmbDiaN"
        Me.CmbDiaN.Size = New System.Drawing.Size(58, 23)
        Me.CmbDiaN.TabIndex = 7
        Me.CmbDiaN.Text = "Dia"
        '
        'CmbEstadoCivil
        '
        Me.CmbEstadoCivil.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CmbEstadoCivil.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CmbEstadoCivil.FormattingEnabled = True
        Me.CmbEstadoCivil.Location = New System.Drawing.Point(155, 378)
        Me.CmbEstadoCivil.Name = "CmbEstadoCivil"
        Me.CmbEstadoCivil.Size = New System.Drawing.Size(149, 23)
        Me.CmbEstadoCivil.TabIndex = 17
        '
        'CmbMunicipio
        '
        Me.CmbMunicipio.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CmbMunicipio.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CmbMunicipio.FormattingEnabled = True
        Me.CmbMunicipio.Location = New System.Drawing.Point(154, 269)
        Me.CmbMunicipio.Name = "CmbMunicipio"
        Me.CmbMunicipio.Size = New System.Drawing.Size(138, 23)
        Me.CmbMunicipio.TabIndex = 10
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Comic Sans MS", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(72, 379)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(83, 19)
        Me.Label10.TabIndex = 18
        Me.Label10.Text = "Estado Civil"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Comic Sans MS", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(86, 269)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(67, 19)
        Me.Label9.TabIndex = 16
        Me.Label9.Text = "Municipio"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Comic Sans MS", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(11, 234)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(143, 19)
        Me.Label6.TabIndex = 12
        Me.Label6.Text = "Fecha de Nacimiento"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Comic Sans MS", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(334, 199)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(52, 19)
        Me.Label7.TabIndex = 10
        Me.Label7.Text = "Celular"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Comic Sans MS", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(89, 199)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(64, 19)
        Me.Label8.TabIndex = 8
        Me.Label8.Text = "Teléfono"
        '
        'TxtDireccion
        '
        Me.TxtDireccion.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtDireccion.Location = New System.Drawing.Point(155, 121)
        Me.TxtDireccion.Multiline = True
        Me.TxtDireccion.Name = "TxtDireccion"
        Me.TxtDireccion.Size = New System.Drawing.Size(219, 71)
        Me.TxtDireccion.TabIndex = 4
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Comic Sans MS", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(85, 121)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(67, 19)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "Dirección"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Comic Sans MS", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(86, 86)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(66, 19)
        Me.Label4.TabIndex = 4
        Me.Label4.Text = "Apellidos"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Comic Sans MS", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(88, 55)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(64, 19)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Nombres"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Comic Sans MS", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(40, 23)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(114, 19)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Código Empleado"
        '
        'PictureBox2
        '
        Me.PictureBox2.BackgroundImage = Global.INNOVAMASTER.My.Resources.Resources._2
        Me.PictureBox2.Location = New System.Drawing.Point(16, -1)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(59, 51)
        Me.PictureBox2.TabIndex = 64
        Me.PictureBox2.TabStop = False
        '
        'PictureBox3
        '
        Me.PictureBox3.BackgroundImage = Global.INNOVAMASTER.My.Resources.Resources.lapiz1
        Me.PictureBox3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox3.Location = New System.Drawing.Point(829, 5)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(32, 32)
        Me.PictureBox3.TabIndex = 63
        Me.PictureBox3.TabStop = False
        '
        'PictureBox1
        '
        Me.PictureBox1.BackgroundImage = Global.INNOVAMASTER.My.Resources.Resources.search
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox1.Location = New System.Drawing.Point(571, 4)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(32, 32)
        Me.PictureBox1.TabIndex = 62
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
        Me.BtnNuevoEditar.Location = New System.Drawing.Point(186, 473)
        Me.BtnNuevoEditar.Name = "BtnNuevoEditar"
        Me.BtnNuevoEditar.Size = New System.Drawing.Size(82, 86)
        Me.BtnNuevoEditar.TabIndex = 50
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
        Me.BtnCancelar.Location = New System.Drawing.Point(376, 473)
        Me.BtnCancelar.Name = "BtnCancelar"
        Me.BtnCancelar.Size = New System.Drawing.Size(82, 86)
        Me.BtnCancelar.TabIndex = 51
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
        Me.BtnNuevo.Font = New System.Drawing.Font("Comic Sans MS", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnNuevo.Image = Global.INNOVAMASTER.My.Resources.Resources.nuevo
        Me.BtnNuevo.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.BtnNuevo.Location = New System.Drawing.Point(91, 473)
        Me.BtnNuevo.Name = "BtnNuevo"
        Me.BtnNuevo.Size = New System.Drawing.Size(82, 86)
        Me.BtnNuevo.TabIndex = 49
        Me.BtnNuevo.Text = "&Nuevo"
        Me.BtnNuevo.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.BtnNuevo.UseVisualStyleBackColor = False
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
        Me.BtnEditar.Location = New System.Drawing.Point(282, 473)
        Me.BtnEditar.Name = "BtnEditar"
        Me.BtnEditar.Size = New System.Drawing.Size(82, 86)
        Me.BtnEditar.TabIndex = 58
        Me.BtnEditar.Text = "&Actualizar"
        Me.BtnEditar.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.BtnEditar.UseVisualStyleBackColor = False
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
        Me.BtnInsertar.Location = New System.Drawing.Point(282, 473)
        Me.BtnInsertar.Name = "BtnInsertar"
        Me.BtnInsertar.Size = New System.Drawing.Size(82, 86)
        Me.BtnInsertar.TabIndex = 52
        Me.BtnInsertar.Text = "&Guardar"
        Me.BtnInsertar.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.BtnInsertar.UseVisualStyleBackColor = False
        '
        'FrmEmpleado
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.LightSeaGreen
        Me.ClientSize = New System.Drawing.Size(1362, 589)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.PictureBox3)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Label17)
        Me.Controls.Add(Me.TxtBusqueda)
        Me.Controls.Add(Me.CboBusqueda)
        Me.Controls.Add(Me.Label16)
        Me.Controls.Add(Me.BtnNuevoEditar)
        Me.Controls.Add(Me.BtnCancelar)
        Me.Controls.Add(Me.BtnNuevo)
        Me.Controls.Add(Me.BtnEditar)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.DgvEmpleado)
        Me.Controls.Add(Me.GbEmpleado)
        Me.Controls.Add(Me.BtnInsertar)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Name = "FrmEmpleado"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Empleados"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.DgvEmpleado, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GbEmpleado.ResumeLayout(False)
        Me.GbEmpleado.PerformLayout()
        CType(Me.PbEmpleado, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents OpenFileDialog1 As OpenFileDialog
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label17 As Label
    Friend WithEvents TxtBusqueda As TextBox
    Friend WithEvents CboBusqueda As ComboBox
    Friend WithEvents Label16 As Label
    Friend WithEvents BtnNuevoEditar As Button
    Friend WithEvents BtnCancelar As Button
    Friend WithEvents BtnNuevo As Button
    Friend WithEvents BtnInsertar As Button
    Friend WithEvents BtnEditar As Button
    Friend WithEvents Label11 As Label
    Friend WithEvents DgvEmpleado As DataGridView
    Friend WithEvents GbEmpleado As GroupBox
    Friend WithEvents TxtCelular As MaskedTextBox
    Friend WithEvents TxtTelefono As MaskedTextBox
    Friend WithEvents PbEmpleado As PictureBox
    Friend WithEvents Panel1 As Panel
    Friend WithEvents BtnEliminarImagen As Button
    Friend WithEvents BtnAgregarImagen As Button
    Friend WithEvents CboProfesion As ComboBox
    Friend WithEvents Label15 As Label
    Friend WithEvents CboSucursal As ComboBox
    Friend WithEvents CboCargo As ComboBox
    Friend WithEvents Label13 As Label
    Friend WithEvents Label14 As Label
    Friend WithEvents CboAñoC As ComboBox
    Friend WithEvents CboMesC As ComboBox
    Friend WithEvents CboDiaC As ComboBox
    Friend WithEvents Label12 As Label
    Friend WithEvents RdbFemenino As RadioButton
    Friend WithEvents CmbAñoN As ComboBox
    Friend WithEvents RdbMasculino As RadioButton
    Friend WithEvents CmbMesN As ComboBox
    Friend WithEvents Label5 As Label
    Friend WithEvents CmbDiaN As ComboBox
    Friend WithEvents CmbEstadoCivil As ComboBox
    Friend WithEvents CmbMunicipio As ComboBox
    Friend WithEvents Label10 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents TxtDireccion As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents TxtIdEmpleado As MaskedTextBox
    Friend WithEvents TxtApellidos As TextBox
    Friend WithEvents TxtNombres As TextBox
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents ToolTip1 As ToolTip
    Friend WithEvents Button2 As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents BtnBusquedaCliente As Button
End Class
