<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmLogin
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
        Me.EpMensaje = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.BtnConfiguracion = New System.Windows.Forms.Button()
        Me.ChkVer = New System.Windows.Forms.CheckBox()
        Me.BtnIniciar = New System.Windows.Forms.Button()
        Me.BtnCerrar = New System.Windows.Forms.Button()
        Me.TxtContrasena = New System.Windows.Forms.TextBox()
        Me.TxtUsuario = New System.Windows.Forms.TextBox()
        Me.HelpProvider1 = New System.Windows.Forms.HelpProvider()
        CType(Me.EpMensaje, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'EpMensaje
        '
        Me.EpMensaje.ContainerControl = Me
        '
        'BtnConfiguracion
        '
        Me.BtnConfiguracion.BackColor = System.Drawing.Color.White
        Me.BtnConfiguracion.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnConfiguracion.Location = New System.Drawing.Point(229, 211)
        Me.BtnConfiguracion.Name = "BtnConfiguracion"
        Me.BtnConfiguracion.Size = New System.Drawing.Size(104, 30)
        Me.BtnConfiguracion.TabIndex = 0
        Me.BtnConfiguracion.Text = "&Configuración"
        Me.BtnConfiguracion.UseVisualStyleBackColor = False
        Me.BtnConfiguracion.Visible = False
        '
        'ChkVer
        '
        Me.ChkVer.AutoSize = True
        Me.ChkVer.BackColor = System.Drawing.Color.Transparent
        Me.ChkVer.Location = New System.Drawing.Point(534, 186)
        Me.ChkVer.Name = "ChkVer"
        Me.ChkVer.Size = New System.Drawing.Size(42, 17)
        Me.ChkVer.TabIndex = 3
        Me.ChkVer.Text = "Ver"
        Me.ChkVer.UseVisualStyleBackColor = False
        '
        'BtnIniciar
        '
        Me.BtnIniciar.BackColor = System.Drawing.Color.White
        Me.BtnIniciar.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnIniciar.Location = New System.Drawing.Point(418, 210)
        Me.BtnIniciar.Name = "BtnIniciar"
        Me.BtnIniciar.Size = New System.Drawing.Size(75, 30)
        Me.BtnIniciar.TabIndex = 4
        Me.BtnIniciar.Text = "&Iniciar"
        Me.BtnIniciar.UseVisualStyleBackColor = False
        '
        'BtnCerrar
        '
        Me.BtnCerrar.BackColor = System.Drawing.Color.White
        Me.BtnCerrar.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnCerrar.Location = New System.Drawing.Point(499, 210)
        Me.BtnCerrar.Name = "BtnCerrar"
        Me.BtnCerrar.Size = New System.Drawing.Size(75, 30)
        Me.BtnCerrar.TabIndex = 5
        Me.BtnCerrar.Text = "&Cerrar"
        Me.BtnCerrar.UseVisualStyleBackColor = False
        '
        'TxtContrasena
        '
        Me.TxtContrasena.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TxtContrasena.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtContrasena.Location = New System.Drawing.Point(399, 157)
        Me.TxtContrasena.Name = "TxtContrasena"
        Me.TxtContrasena.Size = New System.Drawing.Size(176, 19)
        Me.TxtContrasena.TabIndex = 2
        Me.TxtContrasena.UseSystemPasswordChar = True
        '
        'TxtUsuario
        '
        Me.TxtUsuario.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TxtUsuario.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtUsuario.Location = New System.Drawing.Point(399, 102)
        Me.TxtUsuario.Name = "TxtUsuario"
        Me.TxtUsuario.Size = New System.Drawing.Size(176, 19)
        Me.TxtUsuario.TabIndex = 1
        '
        'FrmLogin
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.BackgroundImage = Global.INNOVAMASTER.My.Resources.Resources.login22
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(608, 254)
        Me.Controls.Add(Me.BtnConfiguracion)
        Me.Controls.Add(Me.ChkVer)
        Me.Controls.Add(Me.BtnIniciar)
        Me.Controls.Add(Me.BtnCerrar)
        Me.Controls.Add(Me.TxtContrasena)
        Me.Controls.Add(Me.TxtUsuario)
        Me.DoubleBuffered = True
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.HelpButton = True
        Me.HelpProvider1.SetHelpNavigator(Me, System.Windows.Forms.HelpNavigator.TableOfContents)
        Me.Name = "FrmLogin"
        Me.HelpProvider1.SetShowHelp(Me, True)
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.TransparencyKey = System.Drawing.SystemColors.Control
        CType(Me.EpMensaje, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents EpMensaje As ErrorProvider
    Friend WithEvents BtnConfiguracion As Button
    Friend WithEvents ChkVer As CheckBox
    Friend WithEvents BtnIniciar As Button
    Friend WithEvents BtnCerrar As Button
    Friend WithEvents TxtContrasena As TextBox
    Friend WithEvents TxtUsuario As TextBox
    Friend WithEvents HelpProvider1 As HelpProvider
End Class
