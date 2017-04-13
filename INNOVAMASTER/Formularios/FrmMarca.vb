Imports System.Data.SqlClient
Public Class FrmMarca

    Dim dt As New DataTable
    Public var As Integer = 0
    Private Sub FrmMarca_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        MostrarMarca()
        GbMarca.Enabled = False
        TxtIdMarca.Enabled = False
        DgvMarca.Enabled = True

    End Sub
    Private Sub MostrarMarca()
        Try
            Dim datos As New FMarca
            dt = datos.MostrarMarca

            If dt.Rows.Count <> 0 Then
                LblFilas.Visible = False
                DgvMarca.DataSource = dt

                TxtBusqueda.Enabled = True
            Else
                LblFilas.Visible = True
                DgvMarca.DataSource = Nothing

                TxtBusqueda.Enabled = False
            End If
        Catch ex As Exception

        End Try
    End Sub
    Private Sub DgvMarca_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DgvMarca.CellClick
        TxtIdMarca.Text = DgvMarca.SelectedCells.Item(0).Value
        TxtMarca.Text = DgvMarca.SelectedCells.Item(1).Value
    End Sub

    Private Sub txtBusqueda_TextChanged(sender As Object, e As EventArgs) Handles TxtBusqueda.TextChanged
        Dim ds As New DataSet
        Dim dv As New DataView

        ds.Tables.Add(dt.Copy)
        dv = New DataView(ds.Tables(0))

        dv.RowFilter = "Marca" & " like '" & TxtBusqueda.Text & "%'"

        If dv.Count <> 0 Then
            LblFilas.Visible = False
            DgvMarca.DataSource = dv
        Else
            LblFilas.Visible = True
            DgvMarca.DataSource = Nothing
        End If
    End Sub

    Private Sub BtnNuevo_Click(sender As Object, e As EventArgs) Handles BtnNuevo.Click
        GbMarca.Enabled = True
        TxtIdMarca.Clear()
        TxtMarca.Clear()
        BtnNuevo.Visible = False
        BtnEditar.Visible = False
        BtnInsertar.Visible = True
        BtnCancelar.Visible = True
        DgvMarca.Enabled = False

    End Sub

    Private Sub BtnEditar_Click(sender As Object, e As EventArgs) Handles BtnEditar.Click
        If TxtMarca.Text <> Nothing Then

            GbMarca.Enabled = True
            BtnNuevo.Visible = False
            BtnEditar.Visible = False
            BtnActualizar.Visible = True
            BtnCancelar.Visible = True
            BtnInsertar.Visible = False
            TxtIdMarca.Visible = True
            GbMarca.Enabled = True
            DgvMarca.Enabled = False


        Else
            MessageBox.Show("Seleccione la Marca a Actualizar", "INNOVAMASTER", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If



    End Sub

    Private Sub BtnCancelar_Click(sender As Object, e As EventArgs) Handles BtnCancelar.Click
        Dim r As DialogResult = MessageBox.Show("¿Desea Cancelar el Proceso?", "INNOVAMASTER ", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

        If r = DialogResult.Yes Then
            GbMarca.Enabled = False
            TxtIdMarca.Clear()
            TxtMarca.Clear()
            BtnNuevo.Visible = True
            BtnEditar.Visible = True
            BtnInsertar.Visible = False
            BtnCancelar.Visible = False
            BtnActualizar.Visible = False
            DgvMarca.Enabled = True


        End If

    End Sub

    Private Sub Btninsertar_Click(sender As Object, e As EventArgs) Handles BtnInsertar.Click
        If TxtMarca.Text = Nothing Then

            MessageBox.Show("Ingrese el Nombre de la Marca", "INNOVAMASTER", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            TxtMarca.Focus()
        Else
            Try

                Dim datos As New DatosMarca
                Dim funcion As New FMarca

                datos.gMarca = TxtMarca.Text

                If funcion.Insertar(datos) Then
                    MessageBox.Show("Marca Insertada con éxito", "INNOVAMASTER", MessageBoxButtons.OK, MessageBoxIcon.Information)

                    GbMarca.Enabled = False
                    TxtIdMarca.Clear()
                    TxtMarca.Clear()
                    BtnNuevo.Visible = True
                    BtnEditar.Visible = True
                    BtnInsertar.Visible = False
                    BtnCancelar.Visible = False
                    BtnActualizar.Visible = False
                    DgvMarca.Enabled = True

                    MostrarMarca()


                End If

            Catch ex As Exception

                MsgBox(ex.ToString)

            End Try
        End If


    End Sub

    Private Sub BtnActualizar_Click(sender As Object, e As EventArgs) Handles BtnActualizar.Click
        If TxtMarca.Text = Nothing Then

            MessageBox.Show("Ingrese el Nombre de la Marca", "INNOVAMASTER", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            TxtMarca.Focus()
        Else
            Try

                Dim datos As New DatosMarca
                Dim funcion As New FMarca

                datos.gMarca = TxtMarca.Text
                datos.gIdMarca = TxtIdMarca.Text

                If funcion.Actualizar(datos) Then
                    MessageBox.Show("Marca Insertada con éxito", "INNOVAMASTER", MessageBoxButtons.OK, MessageBoxIcon.Information)

                    GbMarca.Enabled = False
                    TxtIdMarca.Clear()
                    TxtMarca.Clear()
                    BtnNuevo.Visible = True
                    BtnEditar.Visible = True
                    BtnInsertar.Visible = False
                    BtnCancelar.Visible = False
                    BtnActualizar.Visible = False
                    DgvMarca.Enabled = True

                    MostrarMarca()

                End If

            Catch ex As Exception

                MsgBox(ex.ToString)

            End Try
        End If


    End Sub


    Private Sub DgvMarca_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles DgvMarca.CellDoubleClick
        If var = 1 Then
            FrmModelo.LlenarComboboxMarca()
            FrmModelo.CboMarca.Text = DgvMarca.CurrentRow.Cells(1).Value.ToString
            Me.Close()
        End If
    End Sub
End Class