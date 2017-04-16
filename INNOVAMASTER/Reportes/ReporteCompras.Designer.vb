<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ReporteCompras
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ReporteCompras))
        Me.Label13 = New System.Windows.Forms.Label()
        Me.TxtBusqueda = New System.Windows.Forms.TextBox()
        Me.DgvReporteCompra = New System.Windows.Forms.DataGridView()
        Me.CmsReporteCompras = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.VisualizarReporteToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ImprimirReporteToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        CType(Me.DgvReporteCompra, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.CmsReporteCompras.SuspendLayout()
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
        Me.Label13.Location = New System.Drawing.Point(261, 20)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(280, 43)
        Me.Label13.TabIndex = 62
        Me.Label13.Text = "Reporte de Compras"
        '
        'TxtBusqueda
        '
        Me.TxtBusqueda.Location = New System.Drawing.Point(81, 91)
        Me.TxtBusqueda.Name = "TxtBusqueda"
        Me.TxtBusqueda.Size = New System.Drawing.Size(652, 20)
        Me.TxtBusqueda.TabIndex = 61
        '
        'DgvReporteCompra
        '
        Me.DgvReporteCompra.AllowUserToAddRows = False
        Me.DgvReporteCompra.AllowUserToDeleteRows = False
        Me.DgvReporteCompra.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DgvReporteCompra.BackgroundColor = System.Drawing.Color.White
        Me.DgvReporteCompra.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DgvReporteCompra.ContextMenuStrip = Me.CmsReporteCompras
        Me.DgvReporteCompra.Location = New System.Drawing.Point(43, 135)
        Me.DgvReporteCompra.Name = "DgvReporteCompra"
        Me.DgvReporteCompra.ReadOnly = True
        Me.DgvReporteCompra.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DgvReporteCompra.Size = New System.Drawing.Size(690, 234)
        Me.DgvReporteCompra.TabIndex = 59
        '
        'CmsReporteCompras
        '
        Me.CmsReporteCompras.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.VisualizarReporteToolStripMenuItem, Me.ImprimirReporteToolStripMenuItem})
        Me.CmsReporteCompras.Name = "CmsReporteCompras"
        Me.CmsReporteCompras.Size = New System.Drawing.Size(165, 48)
        '
        'VisualizarReporteToolStripMenuItem
        '
        Me.VisualizarReporteToolStripMenuItem.Image = Global.INNOVAMASTER.My.Resources.Resources.icon_checklist
        Me.VisualizarReporteToolStripMenuItem.Name = "VisualizarReporteToolStripMenuItem"
        Me.VisualizarReporteToolStripMenuItem.Size = New System.Drawing.Size(164, 22)
        Me.VisualizarReporteToolStripMenuItem.Text = "Visualizar reporte"
        '
        'ImprimirReporteToolStripMenuItem
        '
        Me.ImprimirReporteToolStripMenuItem.Image = Global.INNOVAMASTER.My.Resources.Resources.imprimir
        Me.ImprimirReporteToolStripMenuItem.Name = "ImprimirReporteToolStripMenuItem"
        Me.ImprimirReporteToolStripMenuItem.Size = New System.Drawing.Size(164, 22)
        Me.ImprimirReporteToolStripMenuItem.Text = "Imprimir reporte"
        '
        'PictureBox2
        '
        Me.PictureBox2.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox2.BackgroundImage = Global.INNOVAMASTER.My.Resources.Resources.business_sales_payment_paymentcard_card_money_2352
        Me.PictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox2.Location = New System.Drawing.Point(216, 17)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(50, 51)
        Me.PictureBox2.TabIndex = 68
        Me.PictureBox2.TabStop = False
        '
        'PictureBox1
        '
        Me.PictureBox1.BackgroundImage = Global.INNOVAMASTER.My.Resources.Resources.search
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox1.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.PictureBox1.Location = New System.Drawing.Point(43, 84)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(32, 32)
        Me.PictureBox1.TabIndex = 60
        Me.PictureBox1.TabStop = False
        '
        'ReporteCompras
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.LightSeaGreen
        Me.ClientSize = New System.Drawing.Size(776, 396)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.TxtBusqueda)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.DgvReporteCompra)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "ReporteCompras"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
        Me.Text = "Compras"
        CType(Me.DgvReporteCompra, System.ComponentModel.ISupportInitialize).EndInit()
        Me.CmsReporteCompras.ResumeLayout(False)
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label13 As Label
    Friend WithEvents TxtBusqueda As TextBox
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents DgvReporteCompra As DataGridView
    Friend WithEvents CmsReporteCompras As ContextMenuStrip
    Friend WithEvents VisualizarReporteToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ImprimirReporteToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents PictureBox2 As PictureBox
End Class
