Imports System.Data.SqlClient
Public Class FrmCategoria
    Dim dt As New DataTable
    Public var As Integer = 0
    Private Sub FrmCategorias_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        MostrarCategoria()
        GbDatos.Enabled = False
        TxtIdCategoria.Enabled = False
        DgvCategoria.Enabled = True
    End Sub
    Private Sub MostrarCategoria()
        Try
            Dim datos As New Fcategoria
            dt = datos.MostrarCategoria

            If dt.Rows.Count <> 0 Then
                LblFilas.Visible = False
                DgvCategoria.DataSource = dt

                TxtBusqueda.Enabled = True
            Else
                LblFilas.Visible = True
                DgvCategoria.DataSource = Nothing

                TxtBusqueda.Enabled = False
            End If
        Catch ex As Exception

        End Try
    End Sub
    Private Sub DgvCategoria_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DgvCategoria.CellClick
        TxtIdCategoria.Text = DgvCategoria.SelectedCells.Item(0).Value
        TxtCategoria.Text = DgvCategoria.SelectedCells.Item(1).Value
    End Sub
    Private Sub txtBusqueda_TextChanged(sender As Object, e As EventArgs) Handles TxtBusqueda.TextChanged
        Dim ds As New DataSet
        Dim dv As New DataView

        ds.Tables.Add(dt.Copy)
        dv = New DataView(ds.Tables(0))

        dv.RowFilter = "Categoria" & " like '" & TxtBusqueda.Text & "%'"

        If dv.Count <> 0 Then
            LblFilas.Visible = False
            DgvCategoria.DataSource = dv
        Else
            LblFilas.Visible = True
            DgvCategoria.DataSource = Nothing
        End If
    End Sub
    Private Sub BtnNuevo_Click(sender As Object, e As EventArgs) Handles BtnNuevo.Click
        GbDatos.Enabled = True
        TxtIdCategoria.Clear()
        TxtCategoria.Clear()
        BtnNuevo.Visible = False
        BtnEditar.Visible = False
        BtnInsertar.Visible = True
        BtnCancelar.Visible = True
        DgvCategoria.Enabled = False



    End Sub
    Private Sub BtnEditar_Click(sender As Object, e As EventArgs) Handles BtnEditar.Click
        If TxtIdCategoria.Text <> Nothing Then

            GbDatos.Enabled = True
            BtnNuevo.Visible = False
            BtnEditar.Visible = False
            BtnActualizar.Visible = True
            BtnCancelar.Visible = True
            BtnInsertar.Visible = False
            TxtIdCategoria.Visible = True
            GbDatos.Enabled = True
            DgvCategoria.Enabled = False


        Else
            MessageBox.Show("Seleccione la Categoria a Actualizar", "INNOVAMASTER", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If



    End Sub
    Private Sub BtnCancelar_Click(sender As Object, e As EventArgs) Handles BtnCancelar.Click
        Dim r As DialogResult = MessageBox.Show("¿Desea Cancelar el Proceso?", "INNOVAMASTER ", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

        If r = DialogResult.Yes Then
            GbDatos.Enabled = False
            TxtIdCategoria.Clear()
            TxtCategoria.Clear()
            BtnNuevo.Visible = True
            BtnEditar.Visible = True
            BtnInsertar.Visible = False
            BtnCancelar.Visible = False
            BtnActualizar.Visible = False
            DgvCategoria.Enabled = True


        End If

    End Sub
    Private Sub Btninsertar_Click(sender As Object, e As EventArgs) Handles BtnInsertar.Click
        If TxtCategoria.Text = Nothing Then

            MessageBox.Show("Ingrese el Nombre de la Categoría", "INNOVAMASTER", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            TxtCategoria.Focus()
        Else
            Try

                Dim datos As New DatosProfesion
                Dim funcion As New Fcategoria

                datos.gcategoria = TxtCategoria.Text

                If funcion.Insertar(datos) Then
                    MessageBox.Show("Categoria Insertada con Exito", "INNOVAMASTER", MessageBoxButtons.OK, MessageBoxIcon.Information)

                    GbDatos.Enabled = False
                    TxtIdCategoria.Clear()
                    TxtCategoria.Clear()
                    BtnNuevo.Visible = True
                    BtnEditar.Visible = True
                    BtnInsertar.Visible = False
                    BtnCancelar.Visible = False
                    BtnActualizar.Visible = False
                    DgvCategoria.Enabled = True

                    MostrarCategoria()


                End If

            Catch ex As Exception

                MsgBox(ex.ToString)

            End Try
        End If


    End Sub
    Private Sub BtnActualizar_Click(sender As Object, e As EventArgs) Handles BtnActualizar.Click
        If TxtCategoria.Text = Nothing Then

            MessageBox.Show("Ingrese el Nombre de la Categoría", "INNOVAMASTER", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            TxtCategoria.Focus()
        Else
            Try

                Dim datos As New DatosProfesion
                Dim funcion As New Fcategoria

                datos.gcategoria = TxtCategoria.Text
                datos.gidcategoria = TxtIdCategoria.Text

                If funcion.Actualizar(datos) Then
                    MessageBox.Show("Categoria Insertada con Exito", "INNOVAMASTER", MessageBoxButtons.OK, MessageBoxIcon.Information)

                    GbDatos.Enabled = False
                    TxtIdCategoria.Clear()
                    TxtCategoria.Clear()
                    BtnNuevo.Visible = True
                    BtnEditar.Visible = True
                    BtnInsertar.Visible = False
                    BtnCancelar.Visible = False
                    BtnActualizar.Visible = False
                    DgvCategoria.Enabled = True

                    MostrarCategoria()


                End If

            Catch ex As Exception

                MsgBox(ex.ToString)

            End Try
        End If


    End Sub



    Private Sub DgvCategoria_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles DgvCategoria.CellDoubleClick
        If var = 1 Then
            FrmProducto.LlenarCombos()
            FrmProducto.CboCategoria.Text = DgvCategoria.CurrentRow.Cells(1).Value.ToString
            Me.Close()
        End If
    End Sub
End Class
