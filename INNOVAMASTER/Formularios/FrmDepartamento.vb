Imports System.ComponentModel
Imports System.Data.SqlClient
Public Class FrmDepartamento
    Dim dt As New DataTable
    Dim conec As New Conexion
    Public var As Integer = 0
    Private Sub FrmDepartamento_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CboBusqueda.Text = CboBusqueda.Items(0).ToString
        MostrarDepartamento()
        GbDepartamento.Enabled = False
        TxtIdDepartamento.Enabled = False
        DgvDepartamento.Enabled = True
        Call LlenarComboboxPais()

        Dim NombreArchivo As String = HTMLHelpClass.GetLocalHelpFileName("InnovaMasterAyuda2017.chm")
        HelpProvider1.HelpNamespace = NombreArchivo
        HelpProvider1.SetHelpNavigator(Me, HelpNavigator.KeywordIndex)
        HelpProvider1.SetHelpKeyword(Me, "Departamento")
    End Sub
    Private Sub DgvDepartamento_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DgvDepartamento.CellClick
        TxtIdDepartamento.Text = DgvDepartamento.SelectedCells.Item(0).Value
        TxtDepartamento.Text = DgvDepartamento.SelectedCells.Item(1).Value
        CboPais.Text = DgvDepartamento.SelectedCells.Item(2).Value
    End Sub
    Private Sub MostrarDepartamento()
        Try
            Dim datos As New FDepartamento
            dt = datos.MostrarDepartamento

            If dt.Rows.Count <> 0 Then
                LblFilas.Visible = False
                DgvDepartamento.DataSource = dt

                TxtBusqueda.Enabled = True
            Else
                LblFilas.Visible = True
                DgvDepartamento.DataSource = Nothing

                TxtBusqueda.Enabled = False
            End If
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub
    Public Sub LlenarComboboxPais()
        CboPais.Items.Clear()

        Try
            conec.Conectarse()
            Dim cmd As New SqlCommand
            cmd = New SqlCommand("select Pais from Pais")
            cmd.CommandType = CommandType.Text
            cmd.Connection = conec.Con
            Dim dr As SqlDataReader
            dr = cmd.ExecuteReader

            While dr.Read
                CboPais.Items.Add(dr(0))
            End While

        Catch ex As Exception
            MsgBox(ex.ToString)
        Finally
            conec.Desconectarse()
        End Try

    End Sub
    Private Sub txtBusqueda_TextChanged(sender As Object, e As EventArgs) Handles TxtBusqueda.TextChanged
        Dim ds As New DataSet
        Dim dv As New DataView

        ds.Tables.Add(dt.Copy)
        dv = New DataView(ds.Tables(0))

        dv.RowFilter = CboBusqueda.Text & " like '" & TxtBusqueda.Text & "%'"

        If dv.Count <> 0 Then
            LblFilas.Visible = False
            DgvDepartamento.DataSource = dv
        Else
            LblFilas.Visible = True
            DgvDepartamento.DataSource = Nothing
        End If
    End Sub




    Private Sub BtnNuevo_Click(sender As Object, e As EventArgs) Handles BtnNuevo.Click
        GbDepartamento.Enabled = True
        TxtIdDepartamento.Clear()
        TxtDepartamento.Clear()
        CboPais.Text = Nothing
        BtnNuevo.Visible = False
        BtnEditar.Visible = False
        BtnInsertar.Visible = True
        BtnCancelar.Visible = True
        DgvDepartamento.Enabled = False
    End Sub

    Private Sub BtnEditar_Click(sender As Object, e As EventArgs) Handles BtnEditar.Click
        If TxtIdDepartamento.Text <> Nothing Then

            GbDepartamento.Enabled = True
            BtnNuevo.Visible = False
            BtnEditar.Visible = False
            BtnActualizar.Visible = True
            BtnCancelar.Visible = True
            BtnInsertar.Visible = False
            TxtIdDepartamento.Visible = True
            DgvDepartamento.Enabled = False


        Else
            MessageBox.Show("Seleccione el Departamento a Actualizar", "INNOVAMASTER", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub

    Private Sub BtnActualizar_Click(sender As Object, e As EventArgs) Handles BtnActualizar.Click
        If TxtDepartamento.Text = Nothing Then
            MessageBox.Show("Ingrese el Nombre del Departamento", "INNOVAMASTER", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            TxtDepartamento.Focus()
        ElseIf CboPais.SelectedItem = Nothing Then
            MessageBox.Show("Seleccione el País", "INNOVAMASTER", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

        Else
            Try
                conec.Conectarse()
                Dim datos As New DatosDepartamento
                Dim funcion As New FDepartamento

                datos.gDepartamento = TxtDepartamento.Text
                datos.gIdDepartamento = CInt(TxtIdDepartamento.Text)
                Dim cmd As SqlCommand
                Dim dr As SqlDataReader
                cmd = New SqlCommand(" Select IdPais from Pais where Pais='" & CboPais.Text & "'")
                cmd.CommandType = CommandType.Text
                cmd.Connection = conec.Con
                dr = cmd.ExecuteReader

                If dr.Read Then
                    datos.gIdPais = dr(0)
                End If


                If funcion.Actualizar(datos) Then
                    MessageBox.Show("Departamento Modificado con Exito", "INNOVAMASTER", MessageBoxButtons.OK, MessageBoxIcon.Information)

                    GbDepartamento.Enabled = False
                    TxtIdDepartamento.Clear()
                    TxtDepartamento.Clear()
                    CboPais.Text = Nothing
                    BtnNuevo.Visible = True
                    BtnEditar.Visible = True
                    BtnInsertar.Visible = False
                    BtnCancelar.Visible = False
                    BtnActualizar.Visible = False
                    DgvDepartamento.Enabled = True

                    MostrarDepartamento()

                End If

            Catch ex As Exception

                MsgBox(ex.ToString)

            End Try
        End If
    End Sub

    Private Sub BtnCancelar_Click(sender As Object, e As EventArgs) Handles BtnCancelar.Click
        Dim r As DialogResult = MessageBox.Show("¿Desea Cancelar el Proceso?", "INNOVAMASTER ", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

        If r = DialogResult.Yes Then
            GbDepartamento.Enabled = False
            TxtIdDepartamento.Clear()
            TxtDepartamento.Clear()
            CboPais.Text = Nothing
            BtnNuevo.Visible = True
            BtnEditar.Visible = True
            BtnInsertar.Visible = False
            BtnCancelar.Visible = False
            BtnActualizar.Visible = False
            DgvDepartamento.Enabled = True

        End If
    End Sub

    Private Sub Btninsertar_Click(sender As Object, e As EventArgs) Handles BtnInsertar.Click
        If TxtDepartamento.Text = Nothing Then
            MessageBox.Show("Ingrese el Nombre del Departamento", "INNOVAMASTER", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            TxtDepartamento.Focus()
        ElseIf CboPais.SelectedItem = Nothing Then
            MessageBox.Show("Seleccione el País", "INNOVAMASTER", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

        Else
            Try
                conec.Conectarse()
                Dim datos As New DatosDepartamento
                Dim funcion As New FDepartamento

                datos.gDepartamento = TxtDepartamento.Text
                Dim cmd As SqlCommand
                Dim dr As SqlDataReader
                cmd = New SqlCommand(" Select IdPais from Pais where Pais='" & CboPais.Text & "'")
                cmd.CommandType = CommandType.Text
                cmd.Connection = conec.Con
                dr = cmd.ExecuteReader

                If dr.Read Then
                    datos.gIdPais = dr(0)
                End If



                If funcion.Insertar(datos) Then
                    MessageBox.Show("Departamento Insertado con Exito", "INNOVAMASTER", MessageBoxButtons.OK, MessageBoxIcon.Information)

                    GbDepartamento.Enabled = False
                    TxtIdDepartamento.Clear()
                    TxtDepartamento.Clear()
                    CboPais.Text = Nothing
                    BtnNuevo.Visible = True
                    BtnEditar.Visible = True
                    BtnInsertar.Visible = False
                    BtnCancelar.Visible = False
                    BtnActualizar.Visible = False
                    DgvDepartamento.Enabled = True

                    MostrarDepartamento()


                End If

            Catch ex As Exception

                MsgBox(ex.ToString)

            End Try
        End If
    End Sub





    Private Sub BtnBusquedaCliente_Click(sender As Object, e As EventArgs) Handles BtnBusquedaCliente.Click
        With FrmPais
            FrmPais.var = 1
            .MdiParent = MenuPrincipal
            .Dock = DockStyle.Fill
            .Show()
        End With
    End Sub


    Private Sub DgvDepartamento_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles DgvDepartamento.CellDoubleClick
        If var = 1 Then
            FrmMunicipio.LlenarComboboxDepartamento()
            FrmMunicipio.CboDepartamento.Text = DgvDepartamento.CurrentRow.Cells(1).Value.ToString
            Me.Close()
        End If
    End Sub
End Class