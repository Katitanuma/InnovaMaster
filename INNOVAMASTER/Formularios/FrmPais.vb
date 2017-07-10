Imports System.Data.SqlClient
Public Class FrmPais
    Dim dt As New DataTable
    Dim conec As New Conexion
    Public var As Integer = 0
    Private Sub FrmPais_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call MostrarPais()
        GboPais.Enabled = False

        Dim NombreArchivo As String = HTMLHelpClass.GetLocalHelpFileName("InnovaMasterAyuda2017.chm")
        HelpProvider1.HelpNamespace = NombreArchivo
        HelpProvider1.SetHelpNavigator(Me, HelpNavigator.KeywordIndex)
        HelpProvider1.SetHelpKeyword(Me, "País")

    End Sub
    Private Sub MostrarPais()
        Try
            Dim datos As New FPais
            dt = datos.MostrarPais

            If dt.Rows.Count <> 0 Then
                LblFilas.Visible = False
                DgvPais.DataSource = dt

                TxtBusqueda.Enabled = True
            Else
                LblFilas.Visible = True
                DgvPais.DataSource = Nothing

                TxtBusqueda.Enabled = False
            End If
        Catch ex As Exception

        End Try
    End Sub
    Private Sub DgvPais_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DgvPais.CellClick
        TxtIdPais.Text = DgvPais.SelectedCells.Item(0).Value
        TxtPais.Text = DgvPais.SelectedCells.Item(1).Value

    End Sub

    Private Sub BtnNuevo_Click(sender As Object, e As EventArgs) Handles BtnNuevo.Click
        GboPais.Enabled = True
        TxtIdPais.Clear()
        TxtPais.Clear()
        DgvPais.Enabled = False
        BtnInsertar.Visible = True
        BtnCancelar.Visible = True
        BtnNuevo.Visible = False
        BtnEditar.Visible = False
        BtnActualizar.Visible = False
        TxtIdPais.Enabled = False
    End Sub

    Private Sub BtnEditar_Click(sender As Object, e As EventArgs) Handles BtnEditar.Click
        If TxtIdPais.Text = Nothing Then
            MessageBox.Show("Seleccione el País a Actualizar", "INNOVAMASTER", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Else
            BtnNuevo.Visible = False
            BtnEditar.Visible = False
            BtnInsertar.Visible = False
            BtnCancelar.Visible = True
            BtnActualizar.Visible = True
            DgvPais.Enabled = False
            GboPais.Enabled = True
            TxtIdPais.Enabled = False
        End If
    End Sub
    Private Sub BtnCancelar_Click(sender As Object, e As EventArgs) Handles BtnCancelar.Click
        Dim r As DialogResult = MessageBox.Show("¿Desea Cancelar el Proceso?", "INNOVAMASTER ", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

        If r = DialogResult.Yes Then
            GboPais.Enabled = False
            TxtIdPais.Clear()
            TxtPais.Clear()
            BtnNuevo.Visible = True
            BtnEditar.Visible = True
            BtnInsertar.Visible = False
            BtnCancelar.Visible = False
            BtnActualizar.Visible = False
            DgvPais.Enabled = True
            MostrarPais()

        End If

    End Sub

    Private Sub Btninsertar_Click(sender As Object, e As EventArgs) Handles BtnInsertar.Click
        If TxtPais.Text = Nothing Then
            MessageBox.Show("Ingrese el País", "INNOVAMASTER", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            TxtPais.Focus()
        Else
            Try
                conec.Conectarse()
                Dim datos As New DatosPais
                Dim funcion As New FPais

                datos.gPais = TxtPais.Text


                If funcion.Insertar(datos) Then
                    MessageBox.Show("Pais Insertado con éxito", "INNOVAMASTER", MessageBoxButtons.OK, MessageBoxIcon.Information)

                    GboPais.Enabled = False
                    TxtIdPais.Clear()
                    TxtPais.Clear()

                    BtnNuevo.Visible = True
                    BtnEditar.Visible = True
                    BtnInsertar.Visible = False
                    BtnCancelar.Visible = False
                    BtnActualizar.Visible = False
                    DgvPais.Enabled = True

                    MostrarPais()


                End If

            Catch ex As Exception

                MsgBox(ex.ToString)

            End Try
        End If
    End Sub
    Private Sub BtnActualizar_Click(sender As Object, e As EventArgs) Handles BtnActualizar.Click
        If TxtPais.Text = Nothing Then
            MessageBox.Show("Ingrese el Nombre del País", "INNOVAMASTER", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            TxtPais.Focus()

        Else
            Try
                conec.Conectarse()
                Dim datos As New DatosPais
                Dim funcion As New FPais

                datos.gPais = TxtPais.Text
                datos.gIdPais = Int(TxtIdPais.Text)


                If funcion.Actualizar(datos) Then
                    MessageBox.Show("País Modificado con éxito", "INNOVAMASTER", MessageBoxButtons.OK, MessageBoxIcon.Information)

                    GboPais.Enabled = False
                    TxtIdPais.Clear()
                    TxtPais.Clear()

                    BtnNuevo.Visible = True
                    BtnEditar.Visible = True
                    BtnInsertar.Visible = False
                    BtnCancelar.Visible = False
                    BtnActualizar.Visible = False
                    DgvPais.Enabled = True

                    MostrarPais()


                End If

            Catch ex As Exception

                MsgBox(ex.ToString)

            End Try
        End If


    End Sub
    Private Sub txtBusqueda_TextChanged(sender As Object, e As EventArgs) Handles TxtBusqueda.TextChanged
        Dim ds As New DataSet
        Dim dv As New DataView

        ds.Tables.Add(dt.Copy)
        dv = New DataView(ds.Tables(0))

        dv.RowFilter = "Pais" & " like '" & TxtBusqueda.Text & "%'"

        If dv.Count <> 0 Then
            LblFilas.Visible = False
            DgvPais.DataSource = dv
        Else
            LblFilas.Visible = True
            DgvPais.DataSource = Nothing
        End If
    End Sub



    Private Sub DgvPais_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles DgvPais.CellDoubleClick
        If var = 1 Then
            FrmDepartamento.LlenarComboboxPais()
            FrmDepartamento.CboPais.Text = DgvPais.CurrentRow.Cells(1).Value.ToString
            Me.Close()
        End If
    End Sub
End Class