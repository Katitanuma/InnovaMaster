<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmCliente
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmCliente))
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.LblRelacionClienteVenta = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.TxtBusqueda = New System.Windows.Forms.TextBox()
        Me.CboBusqueda = New System.Windows.Forms.ComboBox()
        Me.DgvCliente = New System.Windows.Forms.DataGridView()
        Me.GbCliente = New System.Windows.Forms.GroupBox()
        Me.BtnBusquedaCliente = New System.Windows.Forms.Button()
        Me.TxtIdCliente = New System.Windows.Forms.MaskedTextBox()
        Me.TxtTelefono = New System.Windows.Forms.MaskedTextBox()
        Me.CboEstadoCivil = New System.Windows.Forms.ComboBox()
        Me.RdbFemenino = New System.Windows.Forms.RadioButton()
        Me.CboAño = New System.Windows.Forms.ComboBox()
        Me.RdbMasculino = New System.Windows.Forms.RadioButton()
        Me.CboMes = New System.Windows.Forms.ComboBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.CboDia = New System.Windows.Forms.ComboBox()
        Me.CboMunicipio = New System.Windows.Forms.ComboBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.TxtCorreo = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.TxtDireccion = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TxtApellidos = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.TxtNombres = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.BtnNuevoEditar = New System.Windows.Forms.Button()
        Me.BtnCancelar = New System.Windows.Forms.Button()
        Me.BtnNuevo = New System.Windows.Forms.Button()
        Me.BtnEditar = New System.Windows.Forms.Button()
        Me.BtnInsertar = New System.Windows.Forms.Button()
        Me.HelpProvider1 = New System.Windows.Forms.HelpProvider()
        CType(Me.DgvCliente, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GbCliente.SuspendLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'LblRelacionClienteVenta
        '
        resources.ApplyResources(Me.LblRelacionClienteVenta, "LblRelacionClienteVenta")
        Me.LblRelacionClienteVenta.Name = "LblRelacionClienteVenta"
        '
        'Label13
        '
        resources.ApplyResources(Me.Label13, "Label13")
        Me.Label13.ForeColor = System.Drawing.Color.Black
        Me.Label13.Name = "Label13"
        '
        'Label12
        '
        resources.ApplyResources(Me.Label12, "Label12")
        Me.Label12.ForeColor = System.Drawing.Color.Black
        Me.Label12.Name = "Label12"
        '
        'Label11
        '
        resources.ApplyResources(Me.Label11, "Label11")
        Me.Label11.ForeColor = System.Drawing.Color.Black
        Me.Label11.Name = "Label11"
        '
        'TxtBusqueda
        '
        resources.ApplyResources(Me.TxtBusqueda, "TxtBusqueda")
        Me.TxtBusqueda.Name = "TxtBusqueda"
        '
        'CboBusqueda
        '
        Me.CboBusqueda.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        resources.ApplyResources(Me.CboBusqueda, "CboBusqueda")
        Me.CboBusqueda.FormattingEnabled = True
        Me.CboBusqueda.Items.AddRange(New Object() {resources.GetString("CboBusqueda.Items"), resources.GetString("CboBusqueda.Items1"), resources.GetString("CboBusqueda.Items2"), resources.GetString("CboBusqueda.Items3"), resources.GetString("CboBusqueda.Items4")})
        Me.CboBusqueda.Name = "CboBusqueda"
        '
        'DgvCliente
        '
        Me.DgvCliente.AllowUserToAddRows = False
        Me.DgvCliente.AllowUserToDeleteRows = False
        Me.DgvCliente.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DgvCliente.BackgroundColor = System.Drawing.Color.White
        Me.DgvCliente.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        resources.ApplyResources(Me.DgvCliente, "DgvCliente")
        Me.DgvCliente.Name = "DgvCliente"
        Me.DgvCliente.ReadOnly = True
        Me.DgvCliente.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        '
        'GbCliente
        '
        Me.GbCliente.BackColor = System.Drawing.Color.Transparent
        Me.GbCliente.Controls.Add(Me.BtnBusquedaCliente)
        Me.GbCliente.Controls.Add(Me.TxtIdCliente)
        Me.GbCliente.Controls.Add(Me.TxtTelefono)
        Me.GbCliente.Controls.Add(Me.CboEstadoCivil)
        Me.GbCliente.Controls.Add(Me.RdbFemenino)
        Me.GbCliente.Controls.Add(Me.CboAño)
        Me.GbCliente.Controls.Add(Me.RdbMasculino)
        Me.GbCliente.Controls.Add(Me.CboMes)
        Me.GbCliente.Controls.Add(Me.Label5)
        Me.GbCliente.Controls.Add(Me.CboDia)
        Me.GbCliente.Controls.Add(Me.CboMunicipio)
        Me.GbCliente.Controls.Add(Me.Label10)
        Me.GbCliente.Controls.Add(Me.Label9)
        Me.GbCliente.Controls.Add(Me.Label6)
        Me.GbCliente.Controls.Add(Me.TxtCorreo)
        Me.GbCliente.Controls.Add(Me.Label7)
        Me.GbCliente.Controls.Add(Me.Label8)
        Me.GbCliente.Controls.Add(Me.TxtDireccion)
        Me.GbCliente.Controls.Add(Me.Label3)
        Me.GbCliente.Controls.Add(Me.TxtApellidos)
        Me.GbCliente.Controls.Add(Me.Label4)
        Me.GbCliente.Controls.Add(Me.TxtNombres)
        Me.GbCliente.Controls.Add(Me.Label2)
        Me.GbCliente.Controls.Add(Me.Label1)
        resources.ApplyResources(Me.GbCliente, "GbCliente")
        Me.GbCliente.ForeColor = System.Drawing.Color.Black
        Me.GbCliente.Name = "GbCliente"
        Me.GbCliente.TabStop = False
        '
        'BtnBusquedaCliente
        '
        resources.ApplyResources(Me.BtnBusquedaCliente, "BtnBusquedaCliente")
        Me.BtnBusquedaCliente.Name = "BtnBusquedaCliente"
        Me.BtnBusquedaCliente.UseVisualStyleBackColor = True
        '
        'TxtIdCliente
        '
        resources.ApplyResources(Me.TxtIdCliente, "TxtIdCliente")
        Me.TxtIdCliente.Name = "TxtIdCliente"
        Me.TxtIdCliente.Tag = ""
        '
        'TxtTelefono
        '
        resources.ApplyResources(Me.TxtTelefono, "TxtTelefono")
        Me.TxtTelefono.Name = "TxtTelefono"
        '
        'CboEstadoCivil
        '
        Me.CboEstadoCivil.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        resources.ApplyResources(Me.CboEstadoCivil, "CboEstadoCivil")
        Me.CboEstadoCivil.FormattingEnabled = True
        Me.CboEstadoCivil.Name = "CboEstadoCivil"
        '
        'RdbFemenino
        '
        resources.ApplyResources(Me.RdbFemenino, "RdbFemenino")
        Me.RdbFemenino.Name = "RdbFemenino"
        Me.RdbFemenino.TabStop = True
        Me.RdbFemenino.UseVisualStyleBackColor = True
        '
        'CboAño
        '
        resources.ApplyResources(Me.CboAño, "CboAño")
        Me.CboAño.FormattingEnabled = True
        Me.CboAño.Name = "CboAño"
        '
        'RdbMasculino
        '
        resources.ApplyResources(Me.RdbMasculino, "RdbMasculino")
        Me.RdbMasculino.Name = "RdbMasculino"
        Me.RdbMasculino.TabStop = True
        Me.RdbMasculino.UseVisualStyleBackColor = True
        '
        'CboMes
        '
        resources.ApplyResources(Me.CboMes, "CboMes")
        Me.CboMes.FormattingEnabled = True
        Me.CboMes.Items.AddRange(New Object() {resources.GetString("CboMes.Items"), resources.GetString("CboMes.Items1"), resources.GetString("CboMes.Items2"), resources.GetString("CboMes.Items3"), resources.GetString("CboMes.Items4"), resources.GetString("CboMes.Items5"), resources.GetString("CboMes.Items6"), resources.GetString("CboMes.Items7"), resources.GetString("CboMes.Items8"), resources.GetString("CboMes.Items9"), resources.GetString("CboMes.Items10"), resources.GetString("CboMes.Items11")})
        Me.CboMes.Name = "CboMes"
        '
        'Label5
        '
        resources.ApplyResources(Me.Label5, "Label5")
        Me.Label5.ForeColor = System.Drawing.Color.Black
        Me.Label5.Name = "Label5"
        '
        'CboDia
        '
        resources.ApplyResources(Me.CboDia, "CboDia")
        Me.CboDia.FormattingEnabled = True
        Me.CboDia.Items.AddRange(New Object() {resources.GetString("CboDia.Items"), resources.GetString("CboDia.Items1"), resources.GetString("CboDia.Items2"), resources.GetString("CboDia.Items3"), resources.GetString("CboDia.Items4"), resources.GetString("CboDia.Items5"), resources.GetString("CboDia.Items6"), resources.GetString("CboDia.Items7"), resources.GetString("CboDia.Items8"), resources.GetString("CboDia.Items9"), resources.GetString("CboDia.Items10"), resources.GetString("CboDia.Items11"), resources.GetString("CboDia.Items12"), resources.GetString("CboDia.Items13"), resources.GetString("CboDia.Items14"), resources.GetString("CboDia.Items15"), resources.GetString("CboDia.Items16"), resources.GetString("CboDia.Items17"), resources.GetString("CboDia.Items18"), resources.GetString("CboDia.Items19"), resources.GetString("CboDia.Items20"), resources.GetString("CboDia.Items21"), resources.GetString("CboDia.Items22"), resources.GetString("CboDia.Items23"), resources.GetString("CboDia.Items24"), resources.GetString("CboDia.Items25"), resources.GetString("CboDia.Items26"), resources.GetString("CboDia.Items27"), resources.GetString("CboDia.Items28"), resources.GetString("CboDia.Items29"), resources.GetString("CboDia.Items30")})
        Me.CboDia.Name = "CboDia"
        '
        'CboMunicipio
        '
        Me.CboMunicipio.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        resources.ApplyResources(Me.CboMunicipio, "CboMunicipio")
        Me.CboMunicipio.FormattingEnabled = True
        Me.CboMunicipio.Name = "CboMunicipio"
        '
        'Label10
        '
        resources.ApplyResources(Me.Label10, "Label10")
        Me.Label10.ForeColor = System.Drawing.Color.Black
        Me.Label10.Name = "Label10"
        '
        'Label9
        '
        resources.ApplyResources(Me.Label9, "Label9")
        Me.Label9.ForeColor = System.Drawing.Color.Black
        Me.Label9.Name = "Label9"
        '
        'Label6
        '
        resources.ApplyResources(Me.Label6, "Label6")
        Me.Label6.ForeColor = System.Drawing.Color.Black
        Me.Label6.Name = "Label6"
        '
        'TxtCorreo
        '
        resources.ApplyResources(Me.TxtCorreo, "TxtCorreo")
        Me.TxtCorreo.Name = "TxtCorreo"
        '
        'Label7
        '
        resources.ApplyResources(Me.Label7, "Label7")
        Me.Label7.ForeColor = System.Drawing.Color.Black
        Me.Label7.Name = "Label7"
        '
        'Label8
        '
        resources.ApplyResources(Me.Label8, "Label8")
        Me.Label8.ForeColor = System.Drawing.Color.Black
        Me.Label8.Name = "Label8"
        '
        'TxtDireccion
        '
        resources.ApplyResources(Me.TxtDireccion, "TxtDireccion")
        Me.TxtDireccion.Name = "TxtDireccion"
        '
        'Label3
        '
        resources.ApplyResources(Me.Label3, "Label3")
        Me.Label3.ForeColor = System.Drawing.Color.Black
        Me.Label3.Name = "Label3"
        '
        'TxtApellidos
        '
        resources.ApplyResources(Me.TxtApellidos, "TxtApellidos")
        Me.TxtApellidos.Name = "TxtApellidos"
        '
        'Label4
        '
        resources.ApplyResources(Me.Label4, "Label4")
        Me.Label4.ForeColor = System.Drawing.Color.Black
        Me.Label4.Name = "Label4"
        '
        'TxtNombres
        '
        resources.ApplyResources(Me.TxtNombres, "TxtNombres")
        Me.TxtNombres.Name = "TxtNombres"
        '
        'Label2
        '
        resources.ApplyResources(Me.Label2, "Label2")
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.Name = "Label2"
        '
        'Label1
        '
        resources.ApplyResources(Me.Label1, "Label1")
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Name = "Label1"
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = Global.INNOVAMASTER.My.Resources.Resources.user
        resources.ApplyResources(Me.PictureBox2, "PictureBox2")
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.TabStop = False
        '
        'PictureBox3
        '
        Me.PictureBox3.BackgroundImage = Global.INNOVAMASTER.My.Resources.Resources.lapiz1
        resources.ApplyResources(Me.PictureBox3, "PictureBox3")
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.TabStop = False
        '
        'PictureBox1
        '
        Me.PictureBox1.BackgroundImage = Global.INNOVAMASTER.My.Resources.Resources.search
        resources.ApplyResources(Me.PictureBox1, "PictureBox1")
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.TabStop = False
        '
        'BtnNuevoEditar
        '
        Me.BtnNuevoEditar.BackColor = System.Drawing.Color.LightSeaGreen
        resources.ApplyResources(Me.BtnNuevoEditar, "BtnNuevoEditar")
        Me.BtnNuevoEditar.FlatAppearance.BorderSize = 0
        Me.BtnNuevoEditar.Image = Global.INNOVAMASTER.My.Resources.Resources.editar1
        Me.BtnNuevoEditar.Name = "BtnNuevoEditar"
        Me.BtnNuevoEditar.UseVisualStyleBackColor = False
        '
        'BtnCancelar
        '
        Me.BtnCancelar.BackColor = System.Drawing.Color.LightSeaGreen
        resources.ApplyResources(Me.BtnCancelar, "BtnCancelar")
        Me.BtnCancelar.FlatAppearance.BorderSize = 0
        Me.BtnCancelar.Image = Global.INNOVAMASTER.My.Resources.Resources.cancelb
        Me.BtnCancelar.Name = "BtnCancelar"
        Me.BtnCancelar.UseVisualStyleBackColor = False
        '
        'BtnNuevo
        '
        Me.BtnNuevo.BackColor = System.Drawing.Color.LightSeaGreen
        resources.ApplyResources(Me.BtnNuevo, "BtnNuevo")
        Me.BtnNuevo.FlatAppearance.BorderSize = 0
        Me.BtnNuevo.Image = Global.INNOVAMASTER.My.Resources.Resources.nuevo
        Me.BtnNuevo.Name = "BtnNuevo"
        Me.BtnNuevo.UseVisualStyleBackColor = False
        '
        'BtnEditar
        '
        Me.BtnEditar.BackColor = System.Drawing.Color.LightSeaGreen
        resources.ApplyResources(Me.BtnEditar, "BtnEditar")
        Me.BtnEditar.FlatAppearance.BorderSize = 0
        Me.BtnEditar.Image = Global.INNOVAMASTER.My.Resources.Resources.actualizarb
        Me.BtnEditar.Name = "BtnEditar"
        Me.BtnEditar.UseVisualStyleBackColor = False
        '
        'BtnInsertar
        '
        Me.BtnInsertar.BackColor = System.Drawing.Color.LightSeaGreen
        resources.ApplyResources(Me.BtnInsertar, "BtnInsertar")
        Me.BtnInsertar.FlatAppearance.BorderSize = 0
        Me.BtnInsertar.Image = Global.INNOVAMASTER.My.Resources.Resources.guardar
        Me.BtnInsertar.Name = "BtnInsertar"
        Me.BtnInsertar.UseVisualStyleBackColor = False
        '
        'FrmCliente
        '
        resources.ApplyResources(Me, "$this")
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.LightSeaGreen
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.PictureBox3)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.BtnNuevoEditar)
        Me.Controls.Add(Me.BtnCancelar)
        Me.Controls.Add(Me.BtnNuevo)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.TxtBusqueda)
        Me.Controls.Add(Me.CboBusqueda)
        Me.Controls.Add(Me.DgvCliente)
        Me.Controls.Add(Me.GbCliente)
        Me.Controls.Add(Me.LblRelacionClienteVenta)
        Me.Controls.Add(Me.BtnInsertar)
        Me.Controls.Add(Me.BtnEditar)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.HelpButton = True
        Me.HelpProvider1.SetHelpNavigator(Me, CType(resources.GetObject("$this.HelpNavigator"), System.Windows.Forms.HelpNavigator))
        Me.Name = "FrmCliente"
        Me.HelpProvider1.SetShowHelp(Me, CType(resources.GetObject("$this.ShowHelp"), Boolean))
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.DgvCliente, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GbCliente.ResumeLayout(False)
        Me.GbCliente.PerformLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ToolTip1 As ToolTip
    Friend WithEvents LblRelacionClienteVenta As Label
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label13 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents BtnNuevoEditar As Button
    Friend WithEvents BtnCancelar As Button
    Friend WithEvents BtnNuevo As Button
    Friend WithEvents Label11 As Label
    Friend WithEvents TxtBusqueda As TextBox
    Friend WithEvents CboBusqueda As ComboBox
    Friend WithEvents DgvCliente As DataGridView
    Friend WithEvents GbCliente As GroupBox
    Friend WithEvents TxtIdCliente As MaskedTextBox
    Friend WithEvents TxtTelefono As MaskedTextBox
    Friend WithEvents CboEstadoCivil As ComboBox
    Friend WithEvents RdbFemenino As RadioButton
    Friend WithEvents CboAño As ComboBox
    Friend WithEvents RdbMasculino As RadioButton
    Friend WithEvents CboMes As ComboBox
    Friend WithEvents Label5 As Label
    Friend WithEvents CboDia As ComboBox
    Friend WithEvents CboMunicipio As ComboBox
    Friend WithEvents Label10 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents TxtCorreo As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents TxtDireccion As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents TxtApellidos As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents TxtNombres As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents BtnInsertar As Button
    Friend WithEvents BtnEditar As Button
    Friend WithEvents BtnBusquedaCliente As Button
    Friend WithEvents HelpProvider1 As HelpProvider
End Class
