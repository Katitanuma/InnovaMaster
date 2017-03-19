Imports System.Data.SqlClient
Public Class FrmProfesiones
    Dim dt As New DataTable

    Private Sub FrmProfesiones_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        MostrarProfesiones()
        GbDatos.Enabled = False
        TxtIdProfesion.Enabled = False
        DgvProfesion.Enabled = True
    End Sub

    Private Sub MostrarProfesiones()
        Try
            Dim datos As New FProfesiones
            dt = datos.MostrarProfesion

            If dt.Rows.Count <> 0 Then
                LblFilas.Visible = False
                DgvProfesion.DataSource = dt

                TxtBusqueda.Enabled = True
            Else
                LblFilas.Visible = True
                DgvProfesion.DataSource = Nothing

                TxtBusqueda.Enabled = False
            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub Dgvprofesion_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DgvProfesion.CellClick
        TxtIdProfesion.Text = DgvProfesion.SelectedCells.Item(0).Value
        TxtProfesion.Text = DgvProfesion.SelectedCells.Item(1).Value
    End Sub

    Private Sub txtBusqueda_TextChanged(sender As Object, e As EventArgs) Handles TxtBusqueda.TextChanged
        Dim ds As New DataSet
        Dim dv As New DataView

        ds.Tables.Add(dt.Copy)
        dv = New DataView(ds.Tables(0))

        dv.RowFilter = "Profesion" & " like '" & TxtBusqueda.Text & "%'"

        If dv.Count <> 0 Then
            LblFilas.Visible = False
            DgvProfesion.DataSource = dv
        Else
            LblFilas.Visible = True
            DgvProfesion.DataSource = Nothing
        End If
    End Sub

    Private Sub BtnNuevo_Click(sender As Object, e As EventArgs) Handles BtnNuevo.Click
        GbDatos.Enabled = True
        TxtIdProfesion.Clear()
        TxtProfesion.Clear()
        BtnNuevo.Visible = False
        BtnEditar.Visible = False
        BtnInsertar.Visible = True
        BtnCancelar.Visible = True
        DgvProfesion.Enabled = False



    End Sub

    Private Sub BtnEditar_Click(sender As Object, e As EventArgs) Handles BtnEditar.Click
        If TxtIdProfesion.Text <> Nothing Then

            GbDatos.Enabled = True
            BtnNuevo.Visible = False
            BtnEditar.Visible = False
            BtnActualizar.Visible = True
            BtnCancelar.Visible = True
            BtnInsertar.Visible = False
            TxtIdProfesion.Visible = True
            GbDatos.Enabled = True
            DgvProfesion.Enabled = False


        Else
            MessageBox.Show("Seleccione la Profesion a Actualizar", "INNOVAMASTER", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If



    End Sub

    Private Sub BtnCancelar_Click(sender As Object, e As EventArgs) Handles BtnCancelar.Click
        Dim r As DialogResult = MessageBox.Show("¿Desea Cancelar el Proceso?", "INNOVAMASTER ", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

        If r = DialogResult.Yes Then
            GbDatos.Enabled = False
            TxtIdProfesion.Clear()
            TxtProfesion.Clear()
            BtnNuevo.Visible = True
            BtnEditar.Visible = True
            BtnInsertar.Visible = False
            BtnCancelar.Visible = False
            BtnActualizar.Visible = False
            DgvProfesion.Enabled = True


        End If

    End Sub

    Private Sub Btninsertar_Click(sender As Object, e As EventArgs) Handles BtnInsertar.Click
        If TxtProfesion.Text = Nothing Then

            MessageBox.Show("Ingrese el Nombre de la Profesion", "INNOVAMASTER", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            TxtProfesion.Focus()
        Else
            Try

                Dim datos As New DatosProfesiones
                Dim funcion As New FProfesiones

                datos.gprofesion = TxtProfesion.Text

                If funcion.Insertar(datos) Then
                    MessageBox.Show("Profesion Insertada con éxito", "INNOVAMASTER", MessageBoxButtons.OK, MessageBoxIcon.Information)

                    GbDatos.Enabled = False
                    TxtIdProfesion.Clear()
                    TxtProfesion.Clear()
                    BtnNuevo.Visible = True
                    BtnEditar.Visible = True
                    BtnInsertar.Visible = False
                    BtnCancelar.Visible = False
                    BtnActualizar.Visible = False
                    DgvProfesion.Enabled = True

                    MostrarProfesiones()


                End If

            Catch ex As Exception

                MsgBox(ex.ToString)

            End Try
        End If


    End Sub

    Private Sub BtnActualizar_Click(sender As Object, e As EventArgs) Handles BtnActualizar.Click
        If TxtProfesion.Text = Nothing Then

            MessageBox.Show("Ingrese el Nombre de la profesion", "INNOVAMASTER", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            TxtProfesion.Focus()
        Else
            Try

                Dim datos As New DatosProfesiones
                Dim funcion As New FProfesiones

                datos.gprofesion = TxtProfesion.Text
                datos.gidprofesion = TxtIdProfesion.Text

                If funcion.Actualizar(datos) Then
                    MessageBox.Show("Profesion Insertada con éxito", "INNOVAMASTER", MessageBoxButtons.OK, MessageBoxIcon.Information)

                    GbDatos.Enabled = False
                    TxtIdProfesion.Clear()
                    TxtProfesion.Clear()
                    BtnNuevo.Visible = True
                    BtnEditar.Visible = True
                    BtnInsertar.Visible = False
                    BtnCancelar.Visible = False
                    BtnActualizar.Visible = False
                    DgvProfesion.Enabled = True

                    MostrarProfesiones()


                End If

            Catch ex As Exception

                MsgBox(ex.ToString)

            End Try
        End If


    End Sub
End Class