Public Class frmCargo
    Dim dt As New DataTable
    Public var As Integer = 0
    Private Sub frmCargo_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        MostrarCargo()
        GbDatos.Enabled = False
        TxtIdCargo.Enabled = False
        DgvCargo.Enabled = True
    End Sub
    Private Sub MostrarCargo()
        Try
            Dim datos As New Fcargo
            dt = datos.MostrarCargo
            If dt.Rows.Count <> 0 Then
                LblFilas.Visible = False
                DgvCargo.DataSource = dt

                TxtBusqueda.Enabled = True
            Else
                LblFilas.Visible = True
                DgvCargo.DataSource = Nothing

                TxtBusqueda.Enabled = False
            End If
        Catch ex As Exception

        End Try
    End Sub
    Private Sub DgvCargo_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DgvCargo.CellClick
        TxtIdCargo.Text = DgvCargo.SelectedCells.Item(0).Value
        TxtCargo.Text = DgvCargo.SelectedCells.Item(1).Value
    End Sub
    Private Sub txtBusqueda_TextChanged(sender As Object, e As EventArgs) Handles TxtBusqueda.TextChanged
        Dim ds As New DataSet
        Dim dv As New DataView

        ds.Tables.Add(dt.Copy)
        dv = New DataView(ds.Tables(0))

        dv.RowFilter = "Cargo" & " like '" & TxtBusqueda.Text & "%'"

        If dv.Count <> 0 Then
            LblFilas.Visible = False
            DgvCargo.DataSource = dv
        Else
            LblFilas.Visible = True
            DgvCargo.DataSource = Nothing
        End If
    End Sub
    Private Sub BtnNuevo_Click(sender As Object, e As EventArgs) Handles BtnNuevo.Click
        GbDatos.Enabled = True
        TxtIdCargo.Clear()
        TxtCargo.Clear()
        BtnNuevo.Visible = False
        BtnEditar.Visible = False
        BtnInsertar.Visible = True
        BtnCancelar.Visible = True
        DgvCargo.Enabled = False
    End Sub
    Private Sub BtnEditar_Click(sender As Object, e As EventArgs) Handles BtnEditar.Click
        If TxtIdCargo.Text <> Nothing Then
            GbDatos.Enabled = True
            BtnNuevo.Visible = False
            BtnEditar.Visible = False
            BtnActualizar.Visible = True
            BtnCancelar.Visible = True
            BtnInsertar.Visible = False
            TxtIdCargo.Visible = True
            GbDatos.Enabled = True
            DgvCargo.Enabled = False
        Else
            MessageBox.Show("Seleccione el cargo a actualizar", "INNOVAMASTER", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub
    Private Sub BtnCancelar_Click(sender As Object, e As EventArgs) Handles BtnCancelar.Click
        Dim r As DialogResult = MessageBox.Show("¿Desea cancelar el proceso?", "INNOVAMASTER ", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

        If r = DialogResult.Yes Then
            GbDatos.Enabled = False
            TxtIdCargo.Clear()
            TxtCargo.Clear()
            BtnNuevo.Visible = True
            BtnEditar.Visible = True
            BtnInsertar.Visible = False
            BtnCancelar.Visible = False
            BtnActualizar.Visible = False
            DgvCargo.Enabled = True


        End If

    End Sub
    Private Sub Btninsertar_Click(sender As Object, e As EventArgs) Handles BtnInsertar.Click
        If TxtCargo.Text = Nothing Then

            MessageBox.Show("Ingrese el Nombre del Cargo", "INNOVAMASTER", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            TxtCargo.Focus()
        Else
            Try

                Dim datos As New DatosCargo
                Dim funcion As New Fcargo

                datos.gcargo = TxtCargo.Text

                If funcion.InsertarCargo(datos) Then
                    MessageBox.Show("Cargo insertado con éxito", "INNOVAMASTER", MessageBoxButtons.OK, MessageBoxIcon.Information)

                    GbDatos.Enabled = False
                    TxtIdCargo.Clear()
                    TxtCargo.Clear()
                    BtnNuevo.Visible = True
                    BtnEditar.Visible = True
                    BtnInsertar.Visible = False
                    BtnCancelar.Visible = False
                    BtnActualizar.Visible = False
                    DgvCargo.Enabled = True

                    MostrarCargo()
                End If

            Catch ex As Exception

                MsgBox(ex.ToString)

            End Try
        End If
    End Sub
    Private Sub BtnActualizar_Click(sender As Object, e As EventArgs) Handles BtnActualizar.Click
        If TxtCargo.Text = Nothing Then

            MessageBox.Show("Ingrese el Nombre del Cargo", "INNOVAMASTER", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            TxtCargo.Focus()
        Else
            Try

                Dim datos As New DatosCargo
                Dim funcion As New Fcargo

                datos.gcargo = TxtCargo.Text
                datos.gidcargo = TxtIdCargo.Text

                If funcion.Actualizar(datos) Then
                    MessageBox.Show("Cargo actualizado con éxito", "INNOVAMASTER", MessageBoxButtons.OK, MessageBoxIcon.Information)

                    GbDatos.Enabled = False
                    TxtIdCargo.Clear()
                    TxtCargo.Clear()
                    BtnNuevo.Visible = True
                    BtnEditar.Visible = True
                    BtnInsertar.Visible = False
                    BtnCancelar.Visible = False
                    BtnActualizar.Visible = False
                    DgvCargo.Enabled = True

                    MostrarCargo()
                End If

            Catch ex As Exception

                MsgBox(ex.ToString)

            End Try
        End If


    End Sub



    Private Sub DgvCargo_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles DgvCargo.CellDoubleClick
        If var = 1 Then
            FrmEmpleado.LlenarComboCargo()
            FrmEmpleado.CboCargo.Text = DgvCargo.CurrentRow.Cells(1).Value.ToString
            Me.Close()

        End If
    End Sub
End Class