<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmCategoria
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
        Me.Label12 = New System.Windows.Forms.Label()
        Me.TxtBusqueda = New System.Windows.Forms.TextBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.GbDatos = New System.Windows.Forms.GroupBox()
        Me.TxtCategoria = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TxtIdCategoria = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.LblFilas = New System.Windows.Forms.Label()
        Me.DgvCategoria = New System.Windows.Forms.DataGridView()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.BtnEditar = New System.Windows.Forms.Button()
        Me.BtnNuevo = New System.Windows.Forms.Button()
        Me.BtnCancelar = New System.Windows.Forms.Button()
        Me.BtnActualizar = New System.Windows.Forms.Button()
        Me.BtnInsertar = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.GbDatos.SuspendLayout()
        CType(Me.DgvCategoria, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Comic Sans MS", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.ForeColor = System.Drawing.Color.Black
        Me.Label12.Location = New System.Drawing.Point(838, 78)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(131, 19)
        Me.Label12.TabIndex = 58
        Me.Label12.Text = "Lista de Categorías"
        '
        'TxtBusqueda
        '
        Me.TxtBusqueda.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtBusqueda.Location = New System.Drawing.Point(515, 41)
        Me.TxtBusqueda.Name = "TxtBusqueda"
        Me.TxtBusqueda.Size = New System.Drawing.Size(506, 21)
        Me.TxtBusqueda.TabIndex = 55
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Monotype Corsiva", 26.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(87, 34)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(320, 43)
        Me.Label13.TabIndex = 56
        Me.Label13.Text = "Categoría del Producto"
        '
        'GbDatos
        '
        Me.GbDatos.Controls.Add(Me.TxtCategoria)
        Me.GbDatos.Controls.Add(Me.Label2)
        Me.GbDatos.Controls.Add(Me.TxtIdCategoria)
        Me.GbDatos.Controls.Add(Me.Label1)
        Me.GbDatos.Location = New System.Drawing.Point(37, 93)
        Me.GbDatos.Name = "GbDatos"
        Me.GbDatos.Size = New System.Drawing.Size(405, 122)
        Me.GbDatos.TabIndex = 53
        Me.GbDatos.TabStop = False
        '
        'TxtCategoria
        '
        Me.TxtCategoria.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtCategoria.Location = New System.Drawing.Point(144, 68)
        Me.TxtCategoria.Name = "TxtCategoria"
        Me.TxtCategoria.Size = New System.Drawing.Size(241, 21)
        Me.TxtCategoria.TabIndex = 2
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Comic Sans MS", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(69, 67)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(74, 19)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = " Categoría"
        '
        'TxtIdCategoria
        '
        Me.TxtIdCategoria.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtIdCategoria.Location = New System.Drawing.Point(144, 28)
        Me.TxtIdCategoria.Name = "TxtIdCategoria"
        Me.TxtIdCategoria.Size = New System.Drawing.Size(241, 21)
        Me.TxtIdCategoria.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Comic Sans MS", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(7, 27)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(136, 19)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Código de Categoría"
        '
        'LblFilas
        '
        Me.LblFilas.AutoSize = True
        Me.LblFilas.Location = New System.Drawing.Point(998, 336)
        Me.LblFilas.Name = "LblFilas"
        Me.LblFilas.Size = New System.Drawing.Size(65, 13)
        Me.LblFilas.TabIndex = 52
        Me.LblFilas.Text = "SIN DATOS"
        Me.LblFilas.Visible = False
        '
        'DgvCategoria
        '
        Me.DgvCategoria.AllowUserToAddRows = False
        Me.DgvCategoria.AllowUserToDeleteRows = False
        Me.DgvCategoria.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DgvCategoria.BackgroundColor = System.Drawing.Color.White
        Me.DgvCategoria.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DgvCategoria.Location = New System.Drawing.Point(478, 99)
        Me.DgvCategoria.Name = "DgvCategoria"
        Me.DgvCategoria.ReadOnly = True
        Me.DgvCategoria.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DgvCategoria.Size = New System.Drawing.Size(848, 447)
        Me.DgvCategoria.TabIndex = 51
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = Global.INNOVAMASTER.My.Resources.Resources.WhatsApp_Image_2017_03_10_at8_3
        Me.PictureBox2.Location = New System.Drawing.Point(37, 25)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(59, 59)
        Me.PictureBox2.TabIndex = 110
        Me.PictureBox2.TabStop = False
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
        Me.BtnEditar.Location = New System.Drawing.Point(132, 450)
        Me.BtnEditar.Name = "BtnEditar"
        Me.BtnEditar.Size = New System.Drawing.Size(82, 86)
        Me.BtnEditar.TabIndex = 106
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
        Me.BtnNuevo.Location = New System.Drawing.Point(37, 450)
        Me.BtnNuevo.Name = "BtnNuevo"
        Me.BtnNuevo.Size = New System.Drawing.Size(82, 86)
        Me.BtnNuevo.TabIndex = 105
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
        Me.BtnCancelar.Location = New System.Drawing.Point(331, 450)
        Me.BtnCancelar.Name = "BtnCancelar"
        Me.BtnCancelar.Size = New System.Drawing.Size(82, 86)
        Me.BtnCancelar.TabIndex = 108
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
        Me.BtnActualizar.Location = New System.Drawing.Point(230, 450)
        Me.BtnActualizar.Name = "BtnActualizar"
        Me.BtnActualizar.Size = New System.Drawing.Size(82, 86)
        Me.BtnActualizar.TabIndex = 109
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
        Me.BtnInsertar.Location = New System.Drawing.Point(230, 450)
        Me.BtnInsertar.Name = "BtnInsertar"
        Me.BtnInsertar.Size = New System.Drawing.Size(82, 86)
        Me.BtnInsertar.TabIndex = 107
        Me.BtnInsertar.Text = "&Guardar"
        Me.BtnInsertar.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.BtnInsertar.UseVisualStyleBackColor = False
        Me.BtnInsertar.Visible = False
        '
        'PictureBox1
        '
        Me.PictureBox1.BackgroundImage = Global.INNOVAMASTER.My.Resources.Resources.search
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox1.Location = New System.Drawing.Point(478, 37)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(32, 32)
        Me.PictureBox1.TabIndex = 59
        Me.PictureBox1.TabStop = False
        '
        'FrmCategoria
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.LightSeaGreen
        Me.ClientSize = New System.Drawing.Size(1362, 573)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.BtnEditar)
        Me.Controls.Add(Me.BtnNuevo)
        Me.Controls.Add(Me.BtnCancelar)
        Me.Controls.Add(Me.BtnActualizar)
        Me.Controls.Add(Me.BtnInsertar)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.TxtBusqueda)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.GbDatos)
        Me.Controls.Add(Me.LblFilas)
        Me.Controls.Add(Me.DgvCategoria)
        Me.Name = "FrmCategoria"
        Me.Text = "Categoría"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.GbDatos.ResumeLayout(False)
        Me.GbDatos.PerformLayout()
        CType(Me.DgvCategoria, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label12 As Label
    Friend WithEvents TxtBusqueda As TextBox
    Friend WithEvents Label13 As Label
    Friend WithEvents GbDatos As GroupBox
    Friend WithEvents TxtCategoria As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents TxtIdCategoria As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents LblFilas As Label
    Friend WithEvents DgvCategoria As DataGridView
    Friend WithEvents BtnEditar As Button
    Friend WithEvents BtnNuevo As Button
    Friend WithEvents BtnCancelar As Button
    Friend WithEvents BtnActualizar As Button
    Friend WithEvents BtnInsertar As Button
    Friend WithEvents PictureBox2 As PictureBox
End Class
