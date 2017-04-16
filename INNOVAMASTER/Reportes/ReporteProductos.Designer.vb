<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ReporteProductos
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
        Me.components = New System.ComponentModel.Container()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.TxtBusqueda = New System.Windows.Forms.TextBox()
        Me.DgvReporteProductos = New System.Windows.Forms.DataGridView()
        Me.CmsReporteProductos = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.VisualizarReporteToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ImprimirReporteToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        CType(Me.DgvReporteProductos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.CmsReporteProductos.SuspendLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Monotype Corsiva", 26.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle))
        Me.Label13.ForeColor = System.Drawing.Color.Black
        Me.Label13.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label13.Location = New System.Drawing.Point(248, 15)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(299, 43)
        Me.Label13.TabIndex = 66
        Me.Label13.Text = "Reporte de Productos"
        '
        'TxtBusqueda
        '
        Me.TxtBusqueda.Location = New System.Drawing.Point(81, 76)
        Me.TxtBusqueda.Name = "TxtBusqueda"
        Me.TxtBusqueda.Size = New System.Drawing.Size(652, 20)
        Me.TxtBusqueda.TabIndex = 65
        '
        'DgvReporteProductos
        '
        Me.DgvReporteProductos.AllowUserToAddRows = False
        Me.DgvReporteProductos.AllowUserToDeleteRows = False
        Me.DgvReporteProductos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DgvReporteProductos.BackgroundColor = System.Drawing.Color.White
        Me.DgvReporteProductos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DgvReporteProductos.ContextMenuStrip = Me.CmsReporteProductos
        Me.DgvReporteProductos.Location = New System.Drawing.Point(43, 111)
        Me.DgvReporteProductos.Name = "DgvReporteProductos"
        Me.DgvReporteProductos.ReadOnly = True
        Me.DgvReporteProductos.Size = New System.Drawing.Size(690, 234)
        Me.DgvReporteProductos.TabIndex = 63
        '
        'CmsReporteProductos
        '
        Me.CmsReporteProductos.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.VisualizarReporteToolStripMenuItem, Me.ImprimirReporteToolStripMenuItem})
        Me.CmsReporteProductos.Name = "CmsReporteProductos"
        Me.CmsReporteProductos.Size = New System.Drawing.Size(168, 48)
        '
        'VisualizarReporteToolStripMenuItem
        '
        Me.VisualizarReporteToolStripMenuItem.Name = "VisualizarReporteToolStripMenuItem"
        Me.VisualizarReporteToolStripMenuItem.Size = New System.Drawing.Size(167, 22)
        Me.VisualizarReporteToolStripMenuItem.Text = "Visualizar Reporte"
        '
        'ImprimirReporteToolStripMenuItem
        '
        Me.ImprimirReporteToolStripMenuItem.Name = "ImprimirReporteToolStripMenuItem"
        Me.ImprimirReporteToolStripMenuItem.Size = New System.Drawing.Size(167, 22)
        Me.ImprimirReporteToolStripMenuItem.Text = "Imprimir Reporte"
        '
        'PictureBox2
        '
        Me.PictureBox2.BackgroundImage = Global.INNOVAMASTER.My.Resources.Resources.stock
        Me.PictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox2.Location = New System.Drawing.Point(200, 12)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(50, 51)
        Me.PictureBox2.TabIndex = 67
        Me.PictureBox2.TabStop = False
        '
        'PictureBox1
        '
        Me.PictureBox1.BackgroundImage = Global.INNOVAMASTER.My.Resources.Resources.search
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox1.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.PictureBox1.Location = New System.Drawing.Point(43, 64)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(32, 32)
        Me.PictureBox1.TabIndex = 64
        Me.PictureBox1.TabStop = False
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.Button2.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.Location = New System.Drawing.Point(494, 348)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(117, 32)
        Me.Button2.TabIndex = 72
        Me.Button2.Text = "Imprimir"
        Me.Button2.UseVisualStyleBackColor = False
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.Button1.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(617, 348)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(117, 32)
        Me.Button1.TabIndex = 71
        Me.Button1.Text = "Ver Reporte"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'ReporteProductos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.LightSeaGreen
        Me.ClientSize = New System.Drawing.Size(776, 383)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.TxtBusqueda)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.DgvReporteProductos)
        Me.Name = "ReporteProductos"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
        Me.Text = "Productos"
        CType(Me.DgvReporteProductos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.CmsReporteProductos.ResumeLayout(False)
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label13 As Label
    Friend WithEvents TxtBusqueda As TextBox
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents DgvReporteProductos As DataGridView
    Friend WithEvents CmsReporteProductos As ContextMenuStrip
    Friend WithEvents VisualizarReporteToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ImprimirReporteToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents Button2 As Button
    Friend WithEvents Button1 As Button
End Class
