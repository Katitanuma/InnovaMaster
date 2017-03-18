<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmModelo
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.GbModelo = New System.Windows.Forms.GroupBox()
        Me.BtnBusquedaCliente = New System.Windows.Forms.Button()
        Me.CboMarca = New System.Windows.Forms.ComboBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TxtModelo = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TxtIdModelo = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.LblFilas = New System.Windows.Forms.Label()
        Me.DgvModelo = New System.Windows.Forms.DataGridView()
        Me.BtnEditar = New System.Windows.Forms.Button()
        Me.BtnNuevo = New System.Windows.Forms.Button()
        Me.BtnCancelar = New System.Windows.Forms.Button()
        Me.BtnActualizar = New System.Windows.Forms.Button()
        Me.BtnInsertar = New System.Windows.Forms.Button()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.TxtBusqueda = New System.Windows.Forms.TextBox()
        Me.CboBusqueda = New System.Windows.Forms.ComboBox()
        Me.GbModelo.SuspendLayout()
        CType(Me.DgvModelo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Comic Sans MS", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.ForeColor = System.Drawing.Color.Black
        Me.Label12.Location = New System.Drawing.Point(836, 69)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(116, 19)
        Me.Label12.TabIndex = 65
        Me.Label12.Text = "Lista de Modelos"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Monotype Corsiva", 26.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(85, 33)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(117, 43)
        Me.Label13.TabIndex = 63
        Me.Label13.Text = "Modelo"
        '
        'GbModelo
        '
        Me.GbModelo.Controls.Add(Me.BtnBusquedaCliente)
        Me.GbModelo.Controls.Add(Me.CboMarca)
        Me.GbModelo.Controls.Add(Me.Label3)
        Me.GbModelo.Controls.Add(Me.TxtModelo)
        Me.GbModelo.Controls.Add(Me.Label2)
        Me.GbModelo.Controls.Add(Me.TxtIdModelo)
        Me.GbModelo.Controls.Add(Me.Label1)
        Me.GbModelo.Location = New System.Drawing.Point(34, 84)
        Me.GbModelo.Name = "GbModelo"
        Me.GbModelo.Size = New System.Drawing.Size(406, 165)
        Me.GbModelo.TabIndex = 62
        Me.GbModelo.TabStop = False
        '
        'BtnBusquedaCliente
        '
        Me.BtnBusquedaCliente.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnBusquedaCliente.Location = New System.Drawing.Point(333, 108)
        Me.BtnBusquedaCliente.Name = "BtnBusquedaCliente"
        Me.BtnBusquedaCliente.Size = New System.Drawing.Size(33, 24)
        Me.BtnBusquedaCliente.TabIndex = 51
        Me.BtnBusquedaCliente.Text = " ..."
        Me.BtnBusquedaCliente.UseVisualStyleBackColor = True
        '
        'CboMarca
        '
        Me.CboMarca.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CboMarca.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CboMarca.FormattingEnabled = True
        Me.CboMarca.Location = New System.Drawing.Point(121, 109)
        Me.CboMarca.Name = "CboMarca"
        Me.CboMarca.Size = New System.Drawing.Size(206, 23)
        Me.CboMarca.TabIndex = 3
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Comic Sans MS", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(68, 110)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(47, 19)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Marca"
        '
        'TxtModelo
        '
        Me.TxtModelo.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtModelo.Location = New System.Drawing.Point(121, 68)
        Me.TxtModelo.Name = "TxtModelo"
        Me.TxtModelo.Size = New System.Drawing.Size(241, 21)
        Me.TxtModelo.TabIndex = 2
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Comic Sans MS", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(62, 68)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(53, 19)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Modelo"
        '
        'TxtIdModelo
        '
        Me.TxtIdModelo.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtIdModelo.Location = New System.Drawing.Point(121, 29)
        Me.TxtIdModelo.Name = "TxtIdModelo"
        Me.TxtIdModelo.Size = New System.Drawing.Size(199, 21)
        Me.TxtIdModelo.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Comic Sans MS", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(15, 29)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(100, 19)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Código Modelo"
        '
        'LblFilas
        '
        Me.LblFilas.AutoSize = True
        Me.LblFilas.Location = New System.Drawing.Point(993, 332)
        Me.LblFilas.Name = "LblFilas"
        Me.LblFilas.Size = New System.Drawing.Size(65, 13)
        Me.LblFilas.TabIndex = 61
        Me.LblFilas.Text = "SIN DATOS"
        Me.LblFilas.Visible = False
        '
        'DgvModelo
        '
        Me.DgvModelo.AllowUserToAddRows = False
        Me.DgvModelo.AllowUserToDeleteRows = False
        Me.DgvModelo.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DgvModelo.BackgroundColor = System.Drawing.Color.White
        Me.DgvModelo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DgvModelo.Location = New System.Drawing.Point(490, 91)
        Me.DgvModelo.Name = "DgvModelo"
        Me.DgvModelo.ReadOnly = True
        Me.DgvModelo.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DgvModelo.Size = New System.Drawing.Size(828, 457)
        Me.DgvModelo.TabIndex = 60
        '
        'BtnEditar
        '
        Me.BtnEditar.BackColor = System.Drawing.Color.LightSeaGreen
        Me.BtnEditar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BtnEditar.FlatAppearance.BorderSize = 0
        Me.BtnEditar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnEditar.Font = New System.Drawing.Font("Comic Sans MS", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnEditar.Image = Global.INNOVAMASTER.My.Resources.Resources.editar1
        Me.BtnEditar.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.BtnEditar.Location = New System.Drawing.Point(148, 462)
        Me.BtnEditar.Name = "BtnEditar"
        Me.BtnEditar.Size = New System.Drawing.Size(82, 86)
        Me.BtnEditar.TabIndex = 91
        Me.BtnEditar.Text = "&Editar"
        Me.BtnEditar.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.BtnEditar.UseVisualStyleBackColor = False
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
        Me.BtnNuevo.Location = New System.Drawing.Point(53, 462)
        Me.BtnNuevo.Name = "BtnNuevo"
        Me.BtnNuevo.Size = New System.Drawing.Size(82, 86)
        Me.BtnNuevo.TabIndex = 90
        Me.BtnNuevo.Text = "&Nuevo"
        Me.BtnNuevo.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.BtnNuevo.UseVisualStyleBackColor = False
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
        Me.BtnCancelar.Location = New System.Drawing.Point(347, 462)
        Me.BtnCancelar.Name = "BtnCancelar"
        Me.BtnCancelar.Size = New System.Drawing.Size(82, 86)
        Me.BtnCancelar.TabIndex = 93
        Me.BtnCancelar.Text = "&Cancelar"
        Me.BtnCancelar.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.BtnCancelar.UseVisualStyleBackColor = False
        Me.BtnCancelar.Visible = False
        '
        'BtnActualizar
        '
        Me.BtnActualizar.BackColor = System.Drawing.Color.LightSeaGreen
        Me.BtnActualizar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BtnActualizar.FlatAppearance.BorderSize = 0
        Me.BtnActualizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnActualizar.Font = New System.Drawing.Font("Comic Sans MS", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnActualizar.Image = Global.INNOVAMASTER.My.Resources.Resources.actualizarb
        Me.BtnActualizar.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.BtnActualizar.Location = New System.Drawing.Point(246, 462)
        Me.BtnActualizar.Name = "BtnActualizar"
        Me.BtnActualizar.Size = New System.Drawing.Size(82, 86)
        Me.BtnActualizar.TabIndex = 94
        Me.BtnActualizar.Text = "&Actualizar"
        Me.BtnActualizar.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.BtnActualizar.UseVisualStyleBackColor = False
        Me.BtnActualizar.Visible = False
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
        Me.BtnInsertar.Location = New System.Drawing.Point(246, 462)
        Me.BtnInsertar.Name = "BtnInsertar"
        Me.BtnInsertar.Size = New System.Drawing.Size(82, 86)
        Me.BtnInsertar.TabIndex = 92
        Me.BtnInsertar.Text = "&Guardar"
        Me.BtnInsertar.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.BtnInsertar.UseVisualStyleBackColor = False
        Me.BtnInsertar.Visible = False
        '
        'PictureBox2
        '
        Me.PictureBox2.BackgroundImage = Global.INNOVAMASTER.My.Resources.Resources.product_icon
        Me.PictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox2.Location = New System.Drawing.Point(34, 23)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(59, 59)
        Me.PictureBox2.TabIndex = 64
        Me.PictureBox2.TabStop = False
        '
        'PictureBox3
        '
        Me.PictureBox3.BackgroundImage = Global.INNOVAMASTER.My.Resources.Resources.lapiz1
        Me.PictureBox3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox3.Location = New System.Drawing.Point(756, 19)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(32, 32)
        Me.PictureBox3.TabIndex = 98
        Me.PictureBox3.TabStop = False
        '
        'PictureBox1
        '
        Me.PictureBox1.BackgroundImage = Global.INNOVAMASTER.My.Resources.Resources.search_12841
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox1.Location = New System.Drawing.Point(491, 18)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(32, 33)
        Me.PictureBox1.TabIndex = 97
        Me.PictureBox1.TabStop = False
        '
        'TxtBusqueda
        '
        Me.TxtBusqueda.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtBusqueda.Location = New System.Drawing.Point(792, 25)
        Me.TxtBusqueda.Name = "TxtBusqueda"
        Me.TxtBusqueda.Size = New System.Drawing.Size(505, 21)
        Me.TxtBusqueda.TabIndex = 96
        '
        'CboBusqueda
        '
        Me.CboBusqueda.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CboBusqueda.FormattingEnabled = True
        Me.CboBusqueda.Items.AddRange(New Object() {"Modelo", "Marca"})
        Me.CboBusqueda.Location = New System.Drawing.Point(523, 23)
        Me.CboBusqueda.Name = "CboBusqueda"
        Me.CboBusqueda.Size = New System.Drawing.Size(198, 23)
        Me.CboBusqueda.TabIndex = 95
        Me.CboBusqueda.Text = "Modelo"
        '
        'FrmModelo
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.LightSeaGreen
        Me.ClientSize = New System.Drawing.Size(1352, 573)
        Me.Controls.Add(Me.PictureBox3)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.TxtBusqueda)
        Me.Controls.Add(Me.CboBusqueda)
        Me.Controls.Add(Me.BtnEditar)
        Me.Controls.Add(Me.BtnNuevo)
        Me.Controls.Add(Me.BtnCancelar)
        Me.Controls.Add(Me.BtnActualizar)
        Me.Controls.Add(Me.BtnInsertar)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.GbModelo)
        Me.Controls.Add(Me.LblFilas)
        Me.Controls.Add(Me.DgvModelo)
        Me.Name = "FrmModelo"
        Me.Text = "Modelo"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.GbModelo.ResumeLayout(False)
        Me.GbModelo.PerformLayout()
        CType(Me.DgvModelo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ToolTip1 As ToolTip
    Friend WithEvents Label12 As Label
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents Label13 As Label
    Friend WithEvents GbModelo As GroupBox
    Friend WithEvents CboMarca As ComboBox
    Friend WithEvents Label3 As Label
    Friend WithEvents TxtModelo As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents TxtIdModelo As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents LblFilas As Label
    Friend WithEvents DgvModelo As DataGridView
    Friend WithEvents BtnEditar As Button
    Friend WithEvents BtnNuevo As Button
    Friend WithEvents BtnCancelar As Button
    Friend WithEvents BtnActualizar As Button
    Friend WithEvents BtnInsertar As Button
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents TxtBusqueda As TextBox
    Friend WithEvents CboBusqueda As ComboBox
    Friend WithEvents BtnBusquedaCliente As Button
End Class
