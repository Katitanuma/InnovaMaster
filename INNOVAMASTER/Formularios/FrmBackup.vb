Imports System.Data.SqlClient
Public Class FrmBackup
    Dim cmd As SqlCommand
    Dim conec As New Conexion
    Private Sub FrmBackup_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            conec.Conectarse()
            cmd = New SqlCommand("sp_spaceused", conec.Con)
            cmd.CommandType = CommandType.StoredProcedure

            Dim Dt As New DataTable
            Dim Da As SqlDataAdapter = New SqlDataAdapter(cmd)

            Da.Fill(Dt)

            Dim Dr As DataRow = Dt.Rows.Item(0)

            lblDBName.Text = Dr.Item("database_name").ToString.Trim
            lblDBSize.Text = Dr.Item("database_size").ToString.Trim
            lblUnallocatedSize.Text = Dr.Item("unallocated space").ToString.Trim

            btnSelectDir.Enabled = True
            txtBackupName.Enabled = True
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub
    Private Sub btnBackup_Click(sender As Object, e As EventArgs) Handles btnBackup.Click
        btnBackup.Text = "Respaldando..."
        btnBackup.Enabled = False
        btnBackup.Refresh()
        Dim Query As String = "BACKUP DATABASE " & "INNOVAMASTERBD".Trim & "
                                TO DISK = '" & txtPath.Text & "\" & txtBackupName.Text & ".bak'
                                   WITH FORMAT,
                                      MEDIANAME = '" & txtBackupName.Text & "',
                                      NAME = '" & txtBackupName.Text & "'"
        Try
            conec.Conectarse()
            cmd = New SqlCommand(Query, conec.Con)
            cmd.ExecuteNonQuery()
            MessageBox.Show("Se ha respaldado la base de datos correctamente.", "Respaldo",
                                MessageBoxButtons.OK, MessageBoxIcon.Information)
        Catch ex As Exception
            MessageBox.Show(ex.ToString, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)

        Finally

            btnBackup.Text = "Respaldar"
            btnBackup.Enabled = True
        End Try
    End Sub
    Private Sub btnSelectDir_Click(sender As Object, e As EventArgs) Handles btnSelectDir.Click
        Dim FBD As New FolderBrowserDialog
        If FBD.ShowDialog() = DialogResult.OK Then
            txtPath.Text = FBD.SelectedPath
        End If
    End Sub
    Private Sub txtBackupName_TextChanged(sender As Object, e As EventArgs) Handles txtBackupName.TextChanged
        If Not String.IsNullOrWhiteSpace(txtBackupName.Text) Then
            btnBackup.Enabled = True
        Else
            btnBackup.Enabled = False
        End If
    End Sub
End Class