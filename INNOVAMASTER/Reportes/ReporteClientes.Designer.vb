﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ReporteClientes
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
        Me.DgvReporteClientes = New System.Windows.Forms.DataGridView()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.CmsReporteCliente = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.VisualizarReporteToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ImprimirReporteToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        CType(Me.DgvReporteClientes, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.CmsReporteCliente.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Monotype Corsiva", 26.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle))
        Me.Label13.ForeColor = System.Drawing.Color.Black
        Me.Label13.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label13.Location = New System.Drawing.Point(261, 14)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(272, 43)
        Me.Label13.TabIndex = 58
        Me.Label13.Text = "Reporte de Clientes"
        '
        'TxtBusqueda
        '
        Me.TxtBusqueda.Location = New System.Drawing.Point(81, 78)
        Me.TxtBusqueda.Name = "TxtBusqueda"
        Me.TxtBusqueda.Size = New System.Drawing.Size(652, 20)
        Me.TxtBusqueda.TabIndex = 57
        '
        'DgvReporteClientes
        '
        Me.DgvReporteClientes.AllowUserToAddRows = False
        Me.DgvReporteClientes.AllowUserToDeleteRows = False
        Me.DgvReporteClientes.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DgvReporteClientes.BackgroundColor = System.Drawing.Color.White
        Me.DgvReporteClientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DgvReporteClientes.ContextMenuStrip = Me.CmsReporteCliente
        Me.DgvReporteClientes.Location = New System.Drawing.Point(43, 122)
        Me.DgvReporteClientes.Name = "DgvReporteClientes"
        Me.DgvReporteClientes.ReadOnly = True
        Me.DgvReporteClientes.Size = New System.Drawing.Size(690, 234)
        Me.DgvReporteClientes.TabIndex = 55
        '
        'PictureBox1
        '
        Me.PictureBox1.BackgroundImage = Global.INNOVAMASTER.My.Resources.Resources.search
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox1.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.PictureBox1.Location = New System.Drawing.Point(43, 71)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(32, 32)
        Me.PictureBox1.TabIndex = 56
        Me.PictureBox1.TabStop = False
        '
        'CmsReporteCliente
        '
        Me.CmsReporteCliente.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.VisualizarReporteToolStripMenuItem, Me.ImprimirReporteToolStripMenuItem})
        Me.CmsReporteCliente.Name = "CmsReporteCliente"
        Me.CmsReporteCliente.Size = New System.Drawing.Size(168, 48)
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
        'ReporteClientes
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.LightSeaGreen
        Me.ClientSize = New System.Drawing.Size(776, 396)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.TxtBusqueda)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.DgvReporteClientes)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Name = "ReporteClientes"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Clientes"
        CType(Me.DgvReporteClientes, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.CmsReporteCliente.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label13 As Label
    Friend WithEvents TxtBusqueda As TextBox
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents DgvReporteClientes As DataGridView
    Friend WithEvents CmsReporteCliente As ContextMenuStrip
    Friend WithEvents VisualizarReporteToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ImprimirReporteToolStripMenuItem As ToolStripMenuItem
End Class
