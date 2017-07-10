<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmBackup
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmBackup))
        Me.gbDBInfo = New System.Windows.Forms.GroupBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.btnBackup = New System.Windows.Forms.Button()
        Me.txtBackupName = New System.Windows.Forms.TextBox()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.btnSelectDir = New System.Windows.Forms.Button()
        Me.txtPath = New System.Windows.Forms.TextBox()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.lblUnallocatedSize = New System.Windows.Forms.Label()
        Me.lblDBSize = New System.Windows.Forms.Label()
        Me.lblDBName = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.HelpProvider1 = New System.Windows.Forms.HelpProvider()
        Me.gbDBInfo.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'gbDBInfo
        '
        Me.gbDBInfo.Controls.Add(Me.PictureBox1)
        Me.gbDBInfo.Controls.Add(Me.btnBackup)
        Me.gbDBInfo.Controls.Add(Me.txtBackupName)
        Me.gbDBInfo.Controls.Add(Me.Label17)
        Me.gbDBInfo.Controls.Add(Me.btnSelectDir)
        Me.gbDBInfo.Controls.Add(Me.txtPath)
        Me.gbDBInfo.Controls.Add(Me.Label16)
        Me.gbDBInfo.Controls.Add(Me.lblUnallocatedSize)
        Me.gbDBInfo.Controls.Add(Me.lblDBSize)
        Me.gbDBInfo.Controls.Add(Me.lblDBName)
        Me.gbDBInfo.Controls.Add(Me.Label7)
        Me.gbDBInfo.Controls.Add(Me.Label8)
        Me.gbDBInfo.Controls.Add(Me.Label9)
        Me.gbDBInfo.Font = New System.Drawing.Font("Comic Sans MS", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gbDBInfo.Location = New System.Drawing.Point(46, 69)
        Me.gbDBInfo.Name = "gbDBInfo"
        Me.gbDBInfo.Size = New System.Drawing.Size(509, 265)
        Me.gbDBInfo.TabIndex = 7
        Me.gbDBInfo.TabStop = False
        '
        'PictureBox1
        '
        Me.PictureBox1.BackgroundImage = Global.INNOVAMASTER.My.Resources.Resources.WhatsApp_Image_2017_03_10_at_3_05
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox1.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.PictureBox1.Location = New System.Drawing.Point(184, 205)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(40, 39)
        Me.PictureBox1.TabIndex = 57
        Me.PictureBox1.TabStop = False
        '
        'btnBackup
        '
        Me.btnBackup.BackColor = System.Drawing.Color.White
        Me.btnBackup.Enabled = False
        Me.btnBackup.FlatAppearance.BorderSize = 0
        Me.btnBackup.Location = New System.Drawing.Point(225, 209)
        Me.btnBackup.Name = "btnBackup"
        Me.btnBackup.Size = New System.Drawing.Size(120, 33)
        Me.btnBackup.TabIndex = 17
        Me.btnBackup.Text = "&Respaldar"
        Me.btnBackup.UseVisualStyleBackColor = False
        '
        'txtBackupName
        '
        Me.txtBackupName.Enabled = False
        Me.txtBackupName.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtBackupName.Location = New System.Drawing.Point(158, 165)
        Me.txtBackupName.Name = "txtBackupName"
        Me.txtBackupName.Size = New System.Drawing.Size(257, 21)
        Me.txtBackupName.TabIndex = 16
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Font = New System.Drawing.Font("Comic Sans MS", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.Location = New System.Drawing.Point(22, 164)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(134, 19)
        Me.Label17.TabIndex = 15
        Me.Label17.Text = "Nombre del archivo"
        '
        'btnSelectDir
        '
        Me.btnSelectDir.Enabled = False
        Me.btnSelectDir.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSelectDir.Location = New System.Drawing.Point(421, 127)
        Me.btnSelectDir.Name = "btnSelectDir"
        Me.btnSelectDir.Size = New System.Drawing.Size(29, 21)
        Me.btnSelectDir.TabIndex = 14
        Me.btnSelectDir.Text = "..."
        Me.btnSelectDir.UseVisualStyleBackColor = True
        '
        'txtPath
        '
        Me.txtPath.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPath.Location = New System.Drawing.Point(158, 127)
        Me.txtPath.Name = "txtPath"
        Me.txtPath.Size = New System.Drawing.Size(257, 21)
        Me.txtPath.TabIndex = 12
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Font = New System.Drawing.Font("Comic Sans MS", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.Location = New System.Drawing.Point(67, 126)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(89, 19)
        Me.Label16.TabIndex = 11
        Me.Label16.Text = "Respaldar en"
        '
        'lblUnallocatedSize
        '
        Me.lblUnallocatedSize.AutoSize = True
        Me.lblUnallocatedSize.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblUnallocatedSize.ForeColor = System.Drawing.Color.White
        Me.lblUnallocatedSize.Location = New System.Drawing.Point(161, 92)
        Me.lblUnallocatedSize.Name = "lblUnallocatedSize"
        Me.lblUnallocatedSize.Size = New System.Drawing.Size(16, 15)
        Me.lblUnallocatedSize.TabIndex = 11
        Me.lblUnallocatedSize.Text = "..."
        '
        'lblDBSize
        '
        Me.lblDBSize.AutoSize = True
        Me.lblDBSize.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDBSize.ForeColor = System.Drawing.Color.White
        Me.lblDBSize.Location = New System.Drawing.Point(161, 61)
        Me.lblDBSize.Name = "lblDBSize"
        Me.lblDBSize.Size = New System.Drawing.Size(16, 15)
        Me.lblDBSize.TabIndex = 10
        Me.lblDBSize.Text = "..."
        '
        'lblDBName
        '
        Me.lblDBName.AutoSize = True
        Me.lblDBName.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDBName.ForeColor = System.Drawing.Color.White
        Me.lblDBName.Location = New System.Drawing.Point(161, 28)
        Me.lblDBName.Name = "lblDBName"
        Me.lblDBName.Size = New System.Drawing.Size(16, 15)
        Me.lblDBName.TabIndex = 9
        Me.lblDBName.Text = "..."
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Comic Sans MS", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(23, 89)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(134, 19)
        Me.Label7.TabIndex = 6
        Me.Label7.Text = "Espacio no asignado"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Comic Sans MS", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(64, 58)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(92, 19)
        Me.Label8.TabIndex = 5
        Me.Label8.Text = "Tamaño total"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Comic Sans MS", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(99, 25)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(58, 19)
        Me.Label9.TabIndex = 4
        Me.Label9.Text = "Nombre"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Monotype Corsiva", 24.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.ForeColor = System.Drawing.Color.Black
        Me.Label13.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label13.Location = New System.Drawing.Point(68, 19)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(525, 39)
        Me.Label13.TabIndex = 56
        Me.Label13.Text = "Información y Configuración de Respaldo"
        '
        'PictureBox2
        '
        Me.PictureBox2.BackgroundImage = Global.INNOVAMASTER.My.Resources.Resources.backup
        Me.PictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox2.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.PictureBox2.Location = New System.Drawing.Point(12, 12)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(59, 59)
        Me.PictureBox2.TabIndex = 57
        Me.PictureBox2.TabStop = False
        '
        'FrmBackup
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.LightSeaGreen
        Me.ClientSize = New System.Drawing.Size(608, 363)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.gbDBInfo)
        Me.Controls.Add(Me.Label13)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.HelpButton = True
        Me.HelpProvider1.SetHelpNavigator(Me, System.Windows.Forms.HelpNavigator.TableOfContents)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "FrmBackup"
        Me.HelpProvider1.SetShowHelp(Me, True)
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "BackUp"
        Me.gbDBInfo.ResumeLayout(False)
        Me.gbDBInfo.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents gbDBInfo As GroupBox
    Friend WithEvents btnBackup As Button
    Friend WithEvents txtBackupName As TextBox
    Friend WithEvents Label17 As Label
    Friend WithEvents btnSelectDir As Button
    Friend WithEvents txtPath As TextBox
    Friend WithEvents Label16 As Label
    Friend WithEvents lblUnallocatedSize As Label
    Friend WithEvents lblDBSize As Label
    Friend WithEvents lblDBName As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents Label13 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents HelpProvider1 As HelpProvider
End Class
