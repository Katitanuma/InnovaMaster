﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ReporteVentas
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
        Me.Label13 = New System.Windows.Forms.Label()
        Me.TxtBusqueda = New System.Windows.Forms.TextBox()
        Me.DgvReporteVentas = New System.Windows.Forms.DataGridView()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        CType(Me.DgvReporteVentas, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.Label13.Size = New System.Drawing.Size(261, 43)
        Me.Label13.TabIndex = 66
        Me.Label13.Text = "Reporte de Ventas"
        '
        'TxtBusqueda
        '
        Me.TxtBusqueda.Location = New System.Drawing.Point(81, 83)
        Me.TxtBusqueda.Name = "TxtBusqueda"
        Me.TxtBusqueda.Size = New System.Drawing.Size(652, 20)
        Me.TxtBusqueda.TabIndex = 65
        '
        'DgvReporteVentas
        '
        Me.DgvReporteVentas.AllowUserToAddRows = False
        Me.DgvReporteVentas.AllowUserToDeleteRows = False
        Me.DgvReporteVentas.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DgvReporteVentas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DgvReporteVentas.Location = New System.Drawing.Point(43, 122)
        Me.DgvReporteVentas.Name = "DgvReporteVentas"
        Me.DgvReporteVentas.ReadOnly = True
        Me.DgvReporteVentas.Size = New System.Drawing.Size(690, 234)
        Me.DgvReporteVentas.TabIndex = 63
        '
        'PictureBox1
        '
        Me.PictureBox1.BackgroundImage = Global.INNOVAMASTER.My.Resources.Resources.search
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox1.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.PictureBox1.Location = New System.Drawing.Point(43, 71)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(32, 32)
        Me.PictureBox1.TabIndex = 64
        Me.PictureBox1.TabStop = False
        '
        'ReporteVentas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.LightSeaGreen
        Me.ClientSize = New System.Drawing.Size(776, 371)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.TxtBusqueda)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.DgvReporteVentas)
        Me.Name = "ReporteVentas"
        Me.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Text = "ReporteVentas"
        CType(Me.DgvReporteVentas, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label13 As Label
    Friend WithEvents TxtBusqueda As TextBox
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents DgvReporteVentas As DataGridView
End Class