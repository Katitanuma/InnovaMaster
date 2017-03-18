<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmMarca
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.TxtBusqueda = New System.Windows.Forms.TextBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.GbMarca = New System.Windows.Forms.GroupBox()
        Me.TxtMarca = New System.Windows.Forms.TextBox()
        Me.LblMarca = New System.Windows.Forms.Label()
        Me.TxtIdMarca = New System.Windows.Forms.TextBox()
        Me.lblIdMarca = New System.Windows.Forms.Label()
        Me.LblFilas = New System.Windows.Forms.Label()
        Me.DgvMarca = New System.Windows.Forms.DataGridView()
        Me.BtnEditar = New System.Windows.Forms.Button()
        Me.BtnNuevo = New System.Windows.Forms.Button()
        Me.BtnCancelar = New System.Windows.Forms.Button()
        Me.BtnActualizar = New System.Windows.Forms.Button()
        Me.BtnInsertar = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.GbMarca.SuspendLayout()
        CType(Me.DgvMarca, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Comic Sans MS", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.ForeColor = System.Drawing.Color.Black
        Me.Label12.Location = New System.Drawing.Point(850, 68)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(110, 19)
        Me.Label12.TabIndex = 58
        Me.Label12.Text = "Lista de Marcas"
        '
        'TxtBusqueda
        '
        Me.TxtBusqueda.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtBusqueda.Location = New System.Drawing.Point(520, 44)
        Me.TxtBusqueda.Name = "TxtBusqueda"
        Me.TxtBusqueda.Size = New System.Drawing.Size(518, 21)
        Me.TxtBusqueda.TabIndex = 52
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Monotype Corsiva", 26.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(96, 33)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(105, 43)
        Me.Label13.TabIndex = 56
        Me.Label13.Text = "Marca"
        '
        'GbMarca
        '
        Me.GbMarca.Controls.Add(Me.TxtMarca)
        Me.GbMarca.Controls.Add(Me.LblMarca)
        Me.GbMarca.Controls.Add(Me.TxtIdMarca)
        Me.GbMarca.Controls.Add(Me.lblIdMarca)
        Me.GbMarca.Location = New System.Drawing.Point(36, 85)
        Me.GbMarca.Name = "GbMarca"
        Me.GbMarca.Size = New System.Drawing.Size(403, 100)
        Me.GbMarca.TabIndex = 55
        Me.GbMarca.TabStop = False
        '
        'TxtMarca
        '
        Me.TxtMarca.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtMarca.Location = New System.Drawing.Point(115, 55)
        Me.TxtMarca.Name = "TxtMarca"
        Me.TxtMarca.Size = New System.Drawing.Size(241, 21)
        Me.TxtMarca.TabIndex = 2
        '
        'LblMarca
        '
        Me.LblMarca.AutoSize = True
        Me.LblMarca.Font = New System.Drawing.Font("Comic Sans MS", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblMarca.Location = New System.Drawing.Point(64, 54)
        Me.LblMarca.Name = "LblMarca"
        Me.LblMarca.Size = New System.Drawing.Size(47, 19)
        Me.LblMarca.TabIndex = 2
        Me.LblMarca.Text = "Marca"
        '
        'TxtIdMarca
        '
        Me.TxtIdMarca.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtIdMarca.Location = New System.Drawing.Point(115, 20)
        Me.TxtIdMarca.Name = "TxtIdMarca"
        Me.TxtIdMarca.Size = New System.Drawing.Size(241, 21)
        Me.TxtIdMarca.TabIndex = 1
        '
        'lblIdMarca
        '
        Me.lblIdMarca.AutoSize = True
        Me.lblIdMarca.Font = New System.Drawing.Font("Comic Sans MS", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblIdMarca.Location = New System.Drawing.Point(17, 19)
        Me.lblIdMarca.Name = "lblIdMarca"
        Me.lblIdMarca.Size = New System.Drawing.Size(94, 19)
        Me.lblIdMarca.TabIndex = 0
        Me.lblIdMarca.Text = "Código Marca"
        '
        'LblFilas
        '
        Me.LblFilas.AutoSize = True
        Me.LblFilas.Location = New System.Drawing.Point(1002, 335)
        Me.LblFilas.Name = "LblFilas"
        Me.LblFilas.Size = New System.Drawing.Size(65, 13)
        Me.LblFilas.TabIndex = 54
        Me.LblFilas.Text = "SIN DATOS"
        Me.LblFilas.Visible = False
        '
        'DgvMarca
        '
        Me.DgvMarca.AllowUserToAddRows = False
        Me.DgvMarca.AllowUserToDeleteRows = False
        Me.DgvMarca.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DgvMarca.BackgroundColor = System.Drawing.Color.White
        Me.DgvMarca.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DgvMarca.Location = New System.Drawing.Point(480, 90)
        Me.DgvMarca.Name = "DgvMarca"
        Me.DgvMarca.ReadOnly = True
        Me.DgvMarca.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DgvMarca.Size = New System.Drawing.Size(845, 457)
        Me.DgvMarca.TabIndex = 53
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
        Me.BtnEditar.Location = New System.Drawing.Point(147, 461)
        Me.BtnEditar.Name = "BtnEditar"
        Me.BtnEditar.Size = New System.Drawing.Size(82, 86)
        Me.BtnEditar.TabIndex = 96
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
        Me.BtnNuevo.Location = New System.Drawing.Point(52, 461)
        Me.BtnNuevo.Name = "BtnNuevo"
        Me.BtnNuevo.Size = New System.Drawing.Size(82, 86)
        Me.BtnNuevo.TabIndex = 95
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
        Me.BtnCancelar.Location = New System.Drawing.Point(346, 461)
        Me.BtnCancelar.Name = "BtnCancelar"
        Me.BtnCancelar.Size = New System.Drawing.Size(82, 86)
        Me.BtnCancelar.TabIndex = 98
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
        Me.BtnActualizar.Location = New System.Drawing.Point(245, 461)
        Me.BtnActualizar.Name = "BtnActualizar"
        Me.BtnActualizar.Size = New System.Drawing.Size(82, 86)
        Me.BtnActualizar.TabIndex = 99
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
        Me.BtnInsertar.Location = New System.Drawing.Point(245, 461)
        Me.BtnInsertar.Name = "BtnInsertar"
        Me.BtnInsertar.Size = New System.Drawing.Size(82, 86)
        Me.BtnInsertar.TabIndex = 97
        Me.BtnInsertar.Text = "&Guardar"
        Me.BtnInsertar.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.BtnInsertar.UseVisualStyleBackColor = False
        Me.BtnInsertar.Visible = False
        '
        'PictureBox1
        '
        Me.PictureBox1.BackgroundImage = Global.INNOVAMASTER.My.Resources.Resources.search
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox1.Location = New System.Drawing.Point(482, 38)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(32, 32)
        Me.PictureBox1.TabIndex = 59
        Me.PictureBox1.TabStop = False
        '
        'PictureBox2
        '
        Me.PictureBox2.BackgroundImage = Global.INNOVAMASTER.My.Resources.Resources.box
        Me.PictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox2.Location = New System.Drawing.Point(36, 30)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(59, 49)
        Me.PictureBox2.TabIndex = 57
        Me.PictureBox2.TabStop = False
        '
        'FrmMarca
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.LightSeaGreen
        Me.ClientSize = New System.Drawing.Size(1362, 573)
        Me.Controls.Add(Me.BtnEditar)
        Me.Controls.Add(Me.BtnNuevo)
        Me.Controls.Add(Me.BtnCancelar)
        Me.Controls.Add(Me.BtnActualizar)
        Me.Controls.Add(Me.BtnInsertar)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.TxtBusqueda)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.GbMarca)
        Me.Controls.Add(Me.LblFilas)
        Me.Controls.Add(Me.DgvMarca)
        Me.Name = "FrmMarca"
        Me.Text = "Marca"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.GbMarca.ResumeLayout(False)
        Me.GbMarca.PerformLayout()
        CType(Me.DgvMarca, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label12 As Label
    Friend WithEvents TxtBusqueda As TextBox
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents Label13 As Label
    Friend WithEvents GbMarca As GroupBox
    Friend WithEvents TxtMarca As TextBox
    Friend WithEvents LblMarca As Label
    Friend WithEvents TxtIdMarca As TextBox
    Friend WithEvents lblIdMarca As Label
    Friend WithEvents LblFilas As Label
    Friend WithEvents DgvMarca As DataGridView
    Friend WithEvents BtnEditar As Button
    Friend WithEvents BtnNuevo As Button
    Friend WithEvents BtnCancelar As Button
    Friend WithEvents BtnActualizar As Button
    Friend WithEvents BtnInsertar As Button
End Class
