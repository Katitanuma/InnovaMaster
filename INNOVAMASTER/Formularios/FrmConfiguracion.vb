Imports System.ComponentModel
Imports System.Data.SqlClient
Public Class FrmConfiguracion
    Dim conec As New Conexion
    Dim EC As Estado_Conexion
    Dim CSBuilder As New SqlConnectionStringBuilder
    Private Enum Estado_Conexion
        NoComprobada
        Establecida
        NoEstablecida
    End Enum
    Private Sub txts_TextChanged(sender As Object, e As EventArgs) Handles _
        txtServer.TextChanged, txtDB.TextChanged, txtUsername.TextChanged, txtPassword.TextChanged
        EC = Estado_Conexion.NoComprobada
        lblConnStatus.Text = "Conexión no comprobada."
        If Not String.IsNullOrWhiteSpace(txtServer.Text) And Not String.IsNullOrWhiteSpace(txtDB.Text) And
                Not String.IsNullOrWhiteSpace(txtUsername.Text) And Not String.IsNullOrWhiteSpace(txtPassword.Text) Then
            btnTestConnection.Enabled = True
        Else
            btnTestConnection.Enabled = False
        End If
    End Sub
    Private Sub btnTestConnection_Click(sender As Object, e As EventArgs) Handles btnTestConnection.Click
        btnTestConnection.Enabled = False
        lblConnStatus.Text = "Comprobando la conexión..."
        lblConnStatus.Refresh()
        With CSBuilder
            .DataSource = txtServer.Text : .InitialCatalog = txtDB.Text : .IntegratedSecurity = False
            .UserID = txtUsername.Text : .Password = txtPassword.Text
        End With
        Dim Cnx As New SqlConnection(CSBuilder.ConnectionString)
        Try
            Cnx.Open()
            EC = Estado_Conexion.Establecida
            lblConnStatus.Text = "Conexión establecida exitosamente."
            Dim nuevaCadenaConexion As String = "Data Source=" & txtServer.Text & ";Initial Catalog=" & txtDB.Text & ";Persist Security Info=True;User ID=" & txtUsername.Text & ";Password=" & txtPassword.Text & ""
            My.Settings.CadenaConexion = nuevaCadenaConexion

            My.Settings.Servidor = txtServer.Text
            My.Settings.BaseDatos = txtDB.Text
            My.Settings.Usuario = txtUsername.Text
            My.Settings.Contraseña = txtPassword.Text
            My.Settings.Save()
            My.Settings.Reload()
        Catch ex As Exception
            MessageBox.Show(ex.ToString, "Error en la conexión", MessageBoxButtons.OK, MessageBoxIcon.Error)
            EC = Estado_Conexion.NoEstablecida
            lblConnStatus.Text = "Error en la conexión"
        Finally
            btnTestConnection.Enabled = True
            Cnx.Close()
        End Try

    End Sub
    Private Sub FrmConfiguracion_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        My.Settings.Reload()
        txtServer.Text = My.Settings.Servidor
        txtDB.Text = My.Settings.BaseDatos
        txtUsername.Text = My.Settings.Usuario
        txtPassword.Text = My.Settings.Contraseña
    End Sub
    Private Sub FrmConfiguracion_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
        My.Settings.Save()
    End Sub



End Class