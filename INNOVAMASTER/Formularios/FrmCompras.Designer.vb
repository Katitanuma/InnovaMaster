﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmCompras
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.LblNombre = New System.Windows.Forms.Label()
        Me.LblCambio = New System.Windows.Forms.Label()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.BtnFacturar = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.TxtDescuentoExtra = New DevExpress.XtraEditors.CalcEdit()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.RdbCantidad = New System.Windows.Forms.RadioButton()
        Me.RdbPorcentaje = New System.Windows.Forms.RadioButton()
        Me.TxtP = New System.Windows.Forms.TextBox()
        Me.LblP = New System.Windows.Forms.Label()
        Me.TxtFechaCompra = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.TxtTotal = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.TxtImpuesto = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TxtDescuento = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TxtSubtotal = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.DgvDetalle = New System.Windows.Forms.DataGridView()
        Me.Eliminar = New System.Windows.Forms.DataGridViewButtonColumn()
        Me.Codigo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Descripcion = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Cantidad = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Precio = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ISV = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Total = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.LblId = New System.Windows.Forms.Label()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.Panel1.SuspendLayout()
        CType(Me.TxtDescuentoExtra.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DgvDetalle, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'LblNombre
        '
        Me.LblNombre.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.LblNombre.AutoSize = True
        Me.LblNombre.Font = New System.Drawing.Font("Comic Sans MS", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblNombre.Location = New System.Drawing.Point(312, 18)
        Me.LblNombre.Name = "LblNombre"
        Me.LblNombre.Size = New System.Drawing.Size(0, 23)
        Me.LblNombre.TabIndex = 110
        '
        'LblCambio
        '
        Me.LblCambio.AutoSize = True
        Me.LblCambio.Location = New System.Drawing.Point(1015, 515)
        Me.LblCambio.Name = "LblCambio"
        Me.LblCambio.Size = New System.Drawing.Size(39, 13)
        Me.LblCambio.TabIndex = 109
        Me.LblCambio.Text = "Label9"
        Me.LblCambio.Visible = False
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.White
        Me.Button2.Font = New System.Drawing.Font("Comic Sans MS", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.Location = New System.Drawing.Point(977, 522)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(206, 27)
        Me.Button2.TabIndex = 108
        Me.Button2.Text = "&Eliminar Todos los Productos"
        Me.Button2.UseVisualStyleBackColor = False
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.White
        Me.Button1.Font = New System.Drawing.Font("Comic Sans MS", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(1189, 522)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(123, 27)
        Me.Button1.TabIndex = 106
        Me.Button1.Text = "&Cancelar Compra"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'PictureBox2
        '
        Me.PictureBox2.BackgroundImage = Global.INNOVAMASTER.My.Resources.Resources.f15039a22a397b8d72599899f10c9cbd
        Me.PictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox2.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.PictureBox2.Location = New System.Drawing.Point(12, 5)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(62, 51)
        Me.PictureBox2.TabIndex = 104
        Me.PictureBox2.TabStop = False
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Monotype Corsiva", 24.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.Black
        Me.Label6.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label6.Location = New System.Drawing.Point(70, 9)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(275, 39)
        Me.Label6.TabIndex = 103
        Me.Label6.Text = "Compra de Productos"
        '
        'BtnFacturar
        '
        Me.BtnFacturar.BackColor = System.Drawing.Color.White
        Me.BtnFacturar.Font = New System.Drawing.Font("Comic Sans MS", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnFacturar.Location = New System.Drawing.Point(830, 523)
        Me.BtnFacturar.Name = "BtnFacturar"
        Me.BtnFacturar.Size = New System.Drawing.Size(85, 27)
        Me.BtnFacturar.TabIndex = 102
        Me.BtnFacturar.Text = "&Registrar"
        Me.BtnFacturar.UseVisualStyleBackColor = False
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Panel1)
        Me.GroupBox1.Controls.Add(Me.TxtFechaCompra)
        Me.GroupBox1.Controls.Add(Me.Label9)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 51)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(1300, 90)
        Me.GroupBox1.TabIndex = 101
        Me.GroupBox1.TabStop = False
        '
        'Panel1
        '
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel1.Controls.Add(Me.TxtDescuentoExtra)
        Me.Panel1.Controls.Add(Me.Label13)
        Me.Panel1.Controls.Add(Me.RdbCantidad)
        Me.Panel1.Controls.Add(Me.RdbPorcentaje)
        Me.Panel1.Controls.Add(Me.TxtP)
        Me.Panel1.Controls.Add(Me.LblP)
        Me.Panel1.Location = New System.Drawing.Point(6, 19)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(518, 60)
        Me.Panel1.TabIndex = 81
        '
        'TxtDescuentoExtra
        '
        Me.TxtDescuentoExtra.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.TxtDescuentoExtra.Location = New System.Drawing.Point(3, 28)
        Me.TxtDescuentoExtra.Name = "TxtDescuentoExtra"
        Me.TxtDescuentoExtra.Properties.Appearance.BackColor = System.Drawing.Color.White
        Me.TxtDescuentoExtra.Properties.Appearance.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtDescuentoExtra.Properties.Appearance.Options.UseBackColor = True
        Me.TxtDescuentoExtra.Properties.Appearance.Options.UseFont = True
        Me.TxtDescuentoExtra.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.TxtDescuentoExtra.Size = New System.Drawing.Size(179, 22)
        Me.TxtDescuentoExtra.TabIndex = 35
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Comic Sans MS", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(9, 5)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(78, 19)
        Me.Label13.TabIndex = 12
        Me.Label13.Text = "Descuento "
        '
        'RdbCantidad
        '
        Me.RdbCantidad.AutoSize = True
        Me.RdbCantidad.Font = New System.Drawing.Font("Comic Sans MS", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RdbCantidad.Location = New System.Drawing.Point(191, 29)
        Me.RdbCantidad.Name = "RdbCantidad"
        Me.RdbCantidad.Size = New System.Drawing.Size(108, 23)
        Me.RdbCantidad.TabIndex = 36
        Me.RdbCantidad.TabStop = True
        Me.RdbCantidad.Text = "Por Cantidad"
        Me.RdbCantidad.UseVisualStyleBackColor = True
        '
        'RdbPorcentaje
        '
        Me.RdbPorcentaje.AutoSize = True
        Me.RdbPorcentaje.Font = New System.Drawing.Font("Comic Sans MS", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RdbPorcentaje.Location = New System.Drawing.Point(304, 29)
        Me.RdbPorcentaje.Name = "RdbPorcentaje"
        Me.RdbPorcentaje.Size = New System.Drawing.Size(119, 23)
        Me.RdbPorcentaje.TabIndex = 37
        Me.RdbPorcentaje.TabStop = True
        Me.RdbPorcentaje.Text = "Por Porcentaje"
        Me.RdbPorcentaje.UseVisualStyleBackColor = True
        '
        'TxtP
        '
        Me.TxtP.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtP.Location = New System.Drawing.Point(420, 30)
        Me.TxtP.Name = "TxtP"
        Me.TxtP.Size = New System.Drawing.Size(54, 21)
        Me.TxtP.TabIndex = 38
        Me.TxtP.Text = "0"
        Me.TxtP.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.TxtP.Visible = False
        '
        'LblP
        '
        Me.LblP.AutoSize = True
        Me.LblP.Font = New System.Drawing.Font("Comic Sans MS", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblP.Location = New System.Drawing.Point(476, 35)
        Me.LblP.Name = "LblP"
        Me.LblP.Size = New System.Drawing.Size(20, 19)
        Me.LblP.TabIndex = 39
        Me.LblP.Text = "%"
        Me.LblP.Visible = False
        '
        'TxtFechaCompra
        '
        Me.TxtFechaCompra.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.TxtFechaCompra.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtFechaCompra.Location = New System.Drawing.Point(530, 36)
        Me.TxtFechaCompra.Name = "TxtFechaCompra"
        Me.TxtFechaCompra.ReadOnly = True
        Me.TxtFechaCompra.Size = New System.Drawing.Size(155, 21)
        Me.TxtFechaCompra.TabIndex = 82
        Me.TxtFechaCompra.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label9
        '
        Me.Label9.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Comic Sans MS", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label9.Location = New System.Drawing.Point(544, 16)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(118, 19)
        Me.Label9.TabIndex = 81
        Me.Label9.Text = "Fecha de Compra"
        '
        'TxtTotal
        '
        Me.TxtTotal.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtTotal.Location = New System.Drawing.Point(629, 528)
        Me.TxtTotal.Name = "TxtTotal"
        Me.TxtTotal.ReadOnly = True
        Me.TxtTotal.Size = New System.Drawing.Size(164, 21)
        Me.TxtTotal.TabIndex = 100
        Me.TxtTotal.Text = "0.00"
        Me.TxtTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Comic Sans MS", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(626, 508)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(42, 19)
        Me.Label4.TabIndex = 99
        Me.Label4.Text = "Total"
        '
        'TxtImpuesto
        '
        Me.TxtImpuesto.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtImpuesto.Location = New System.Drawing.Point(423, 528)
        Me.TxtImpuesto.Name = "TxtImpuesto"
        Me.TxtImpuesto.ReadOnly = True
        Me.TxtImpuesto.Size = New System.Drawing.Size(164, 21)
        Me.TxtImpuesto.TabIndex = 98
        Me.TxtImpuesto.Text = "0.00"
        Me.TxtImpuesto.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Comic Sans MS", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(420, 508)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(66, 19)
        Me.Label3.TabIndex = 97
        Me.Label3.Text = "Impuesto"
        '
        'TxtDescuento
        '
        Me.TxtDescuento.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtDescuento.Location = New System.Drawing.Point(216, 528)
        Me.TxtDescuento.Name = "TxtDescuento"
        Me.TxtDescuento.ReadOnly = True
        Me.TxtDescuento.Size = New System.Drawing.Size(164, 21)
        Me.TxtDescuento.TabIndex = 96
        Me.TxtDescuento.Text = "0.00"
        Me.TxtDescuento.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Comic Sans MS", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(213, 508)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(72, 19)
        Me.Label2.TabIndex = 95
        Me.Label2.Text = "Descuento"
        '
        'TxtSubtotal
        '
        Me.TxtSubtotal.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtSubtotal.Location = New System.Drawing.Point(10, 528)
        Me.TxtSubtotal.Name = "TxtSubtotal"
        Me.TxtSubtotal.ReadOnly = True
        Me.TxtSubtotal.Size = New System.Drawing.Size(164, 21)
        Me.TxtSubtotal.TabIndex = 94
        Me.TxtSubtotal.Text = "0.00"
        Me.TxtSubtotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Comic Sans MS", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(7, 508)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(63, 19)
        Me.Label1.TabIndex = 93
        Me.Label1.Text = "Subtotal"
        '
        'DgvDetalle
        '
        Me.DgvDetalle.BackgroundColor = System.Drawing.Color.White
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.White
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Blue
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DgvDetalle.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.DgvDetalle.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DgvDetalle.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Eliminar, Me.Codigo, Me.Descripcion, Me.Cantidad, Me.Precio, Me.ISV, Me.Total})
        Me.DgvDetalle.Location = New System.Drawing.Point(10, 159)
        Me.DgvDetalle.Name = "DgvDetalle"
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.Gray
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DgvDetalle.RowHeadersDefaultCellStyle = DataGridViewCellStyle2
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White
        Me.DgvDetalle.RowsDefaultCellStyle = DataGridViewCellStyle3
        Me.DgvDetalle.Size = New System.Drawing.Size(1302, 343)
        Me.DgvDetalle.TabIndex = 92
        '
        'Eliminar
        '
        Me.Eliminar.Frozen = True
        Me.Eliminar.HeaderText = "Eliminar"
        Me.Eliminar.Name = "Eliminar"
        Me.Eliminar.Text = "Eliminar"
        Me.Eliminar.ToolTipText = "Eliminar"
        Me.Eliminar.UseColumnTextForButtonValue = True
        '
        'Codigo
        '
        Me.Codigo.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        Me.Codigo.Frozen = True
        Me.Codigo.HeaderText = "Código"
        Me.Codigo.Name = "Codigo"
        Me.Codigo.Width = 163
        '
        'Descripcion
        '
        Me.Descripcion.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        Me.Descripcion.Frozen = True
        Me.Descripcion.HeaderText = "Descripción"
        Me.Descripcion.Name = "Descripcion"
        Me.Descripcion.Width = 230
        '
        'Cantidad
        '
        Me.Cantidad.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.Cantidad.HeaderText = "Cantidad"
        Me.Cantidad.Name = "Cantidad"
        Me.Cantidad.Width = 82
        '
        'Precio
        '
        Me.Precio.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.Precio.HeaderText = "Costo"
        Me.Precio.Name = "Precio"
        '
        'ISV
        '
        Me.ISV.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.ISV.HeaderText = "ISV"
        Me.ISV.Name = "ISV"
        Me.ISV.ReadOnly = True
        '
        'Total
        '
        Me.Total.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.Total.HeaderText = "Total"
        Me.Total.Name = "Total"
        Me.Total.ReadOnly = True
        '
        'LblId
        '
        Me.LblId.AutoSize = True
        Me.LblId.Location = New System.Drawing.Point(418, 26)
        Me.LblId.Name = "LblId"
        Me.LblId.Size = New System.Drawing.Size(39, 13)
        Me.LblId.TabIndex = 111
        Me.LblId.Text = "Label5"
        Me.LblId.Visible = False
        '
        'FrmCompras
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.LightSeaGreen
        Me.ClientSize = New System.Drawing.Size(1354, 573)
        Me.Controls.Add(Me.LblId)
        Me.Controls.Add(Me.LblNombre)
        Me.Controls.Add(Me.LblCambio)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.BtnFacturar)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.TxtTotal)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.TxtImpuesto)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.TxtDescuento)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.TxtSubtotal)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.DgvDetalle)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Name = "FrmCompras"
        Me.Text = "Compras"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.TxtDescuentoExtra.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DgvDetalle, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents LblNombre As Label
    Friend WithEvents LblCambio As Label
    Friend WithEvents Button2 As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents Label6 As Label
    Friend WithEvents BtnFacturar As Button
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Panel1 As Panel
    Friend WithEvents TxtDescuentoExtra As DevExpress.XtraEditors.CalcEdit
    Friend WithEvents Label13 As Label
    Friend WithEvents RdbCantidad As RadioButton
    Friend WithEvents RdbPorcentaje As RadioButton
    Friend WithEvents TxtP As TextBox
    Friend WithEvents LblP As Label
    Friend WithEvents TxtFechaCompra As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents TxtTotal As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents TxtImpuesto As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents TxtDescuento As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents TxtSubtotal As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents DgvDetalle As DataGridView
    Friend WithEvents Eliminar As DataGridViewButtonColumn
    Friend WithEvents Codigo As DataGridViewTextBoxColumn
    Friend WithEvents Descripcion As DataGridViewTextBoxColumn
    Friend WithEvents Cantidad As DataGridViewTextBoxColumn
    Friend WithEvents Precio As DataGridViewTextBoxColumn
    Friend WithEvents ISV As DataGridViewTextBoxColumn
    Friend WithEvents Total As DataGridViewTextBoxColumn
    Friend WithEvents LblId As Label
End Class
