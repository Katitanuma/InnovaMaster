Imports System.ComponentModel
Imports System.Data.SqlClient
Public Class FrmMunicipio

    Dim dt As New DataTable
    Dim conec As New Conexion

    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.

    End Sub
    Public var As Integer = 0
    Private Sub FrmModelo_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CboBusqueda.Text = CboBusqueda.Items(0).ToString
        MostrarMunicipio()
        GbMunicipio.Enabled = False
        TxtIdMunicipio.Enabled = False
        DgvMunicipio.Enabled = True
        Call LlenarComboboxDepartamento()


    End Sub
    Private Sub MostrarMunicipio()
        Try
            Dim datos As New FMunicipio
            dt = datos.MostrarMunicipio

            If dt.Rows.Count <> 0 Then
                LblFilas.Visible = False
                DgvMunicipio.DataSource = dt

                TxtBusqueda.Enabled = True
            Else
                LblFilas.Visible = True
                DgvMunicipio.DataSource = Nothing

                TxtBusqueda.Enabled = False
            End If
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub

    Private Sub DgvMunicipio_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DgvMunicipio.CellClick
        TxtIdMunicipio.Text = DgvMunicipio.SelectedCells.Item(0).Value
        TxtMunicipio.Text = DgvMunicipio.SelectedCells.Item(1).Value
        CboDepartamento.Text = DgvMunicipio.SelectedCells.Item(2).Value
    End Sub
    Public Sub LlenarComboboxDepartamento()
        CboDepartamento.Items.Clear()

        Try
            conec.Conectarse()
            Dim cmd As New SqlCommand
            cmd = New SqlCommand("select Departamento from Departamento")
            cmd.CommandType = CommandType.Text
            cmd.Connection = conec.Con
            Dim dr As SqlDataReader
            dr = cmd.ExecuteReader

            While dr.Read
                CboDepartamento.Items.Add(dr(0))
            End While

        Catch ex As Exception
            MsgBox(ex.ToString)
        Finally
            conec.Desconectarse()
        End Try

    End Sub

    Private Sub BtnNuevo_Click(sender As Object, e As EventArgs) Handles BtnNuevo.Click
        GbMunicipio.Enabled = True
        TxtIdMunicipio.Clear()
        TxtMunicipio.Clear()
        CboDepartamento.Text = Nothing
        BtnNuevo.Visible = False
        BtnEditar.Visible = False
        BtnInsertar.Visible = True
        BtnCancelar.Visible = True
        DgvMunicipio.Enabled = False
    End Sub

    Private Sub txtBusqueda_TextChanged(sender As Object, e As EventArgs) Handles TxtBusqueda.TextChanged
        Dim ds As New DataSet
        Dim dv As New DataView

        ds.Tables.Add(dt.Copy)
        dv = New DataView(ds.Tables(0))

        dv.RowFilter = CboBusqueda.Text & " like '" & TxtBusqueda.Text & "%'"

        If dv.Count <> 0 Then
            LblFilas.Visible = False
            DgvMunicipio.DataSource = dv
        Else
            LblFilas.Visible = True
            DgvMunicipio.DataSource = Nothing
        End If
    End Sub

    Private Sub BtnEditar_Click(sender As Object, e As EventArgs) Handles BtnEditar.Click
        If TxtIdMunicipio.Text <> Nothing Then

            GbMunicipio.Enabled = True
            BtnNuevo.Visible = False
            BtnEditar.Visible = False
            BtnActualizar.Visible = True
            BtnCancelar.Visible = True
            BtnInsertar.Visible = False
            TxtIdMunicipio.Visible = True
            DgvMunicipio.Enabled = False


        Else
            MessageBox.Show("Seleccione el Municipio a Actualizar", "INNOVAMASTER", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub

    Private Sub BtnCancelar_Click(sender As Object, e As EventArgs) Handles BtnCancelar.Click
        Dim r As DialogResult = MessageBox.Show("¿Desea Cancelar el Proceso?", "INNOVAMASTER ", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

        If r = DialogResult.Yes Then
            GbMunicipio.Enabled = False
            TxtIdMunicipio.Clear()
            TxtMunicipio.Clear()
            CboDepartamento.Text = Nothing
            BtnNuevo.Visible = True
            BtnEditar.Visible = True
            BtnInsertar.Visible = False
            BtnCancelar.Visible = False
            BtnActualizar.Visible = False
            DgvMunicipio.Enabled = True

        End If
    End Sub

    Private Sub Btninsertar_Click(sender As Object, e As EventArgs) Handles BtnInsertar.Click
        If TxtMunicipio.Text = Nothing Then
            MessageBox.Show("Ingrese el Nombre del Municipio", "INNOVAMASTER", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            TxtMunicipio.Focus()
        ElseIf CboDepartamento.SelectedItem = Nothing Then
            MessageBox.Show("Seleccione el Departamento del Municipio", "INNOVAMASTER", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

        Else
            Try
                conec.Conectarse()
                Dim datos As New DatosMunicipio
                Dim funcion As New FMunicipio

                datos.gMunicipio = TxtMunicipio.Text
                Dim cmd As SqlCommand
                Dim dr As SqlDataReader
                cmd = New SqlCommand(" Select IdDepartamento from Departamento where Departamento='" & CboDepartamento.Text & "'")
                cmd.CommandType = CommandType.Text
                cmd.Connection = conec.Con
                dr = cmd.ExecuteReader

                If dr.Read Then
                    datos.gIdDepartamento = dr(0)
                End If



                If funcion.Insertar(datos) Then
                    MessageBox.Show("Municipio Insertado con éxito", "INNOVAMASTER", MessageBoxButtons.OK, MessageBoxIcon.Information)

                    GbMunicipio.Enabled = False
                    TxtIdMunicipio.Clear()
                    TxtMunicipio.Clear()
                    CboDepartamento.Text = "Departamento"
                    BtnNuevo.Visible = True
                    BtnEditar.Visible = True
                    BtnInsertar.Visible = False
                    BtnCancelar.Visible = False
                    BtnActualizar.Visible = False
                    DgvMunicipio.Enabled = True

                    MostrarMunicipio()


                End If

            Catch ex As Exception

                MsgBox(ex.ToString)

            End Try
        End If
    End Sub

    Private Sub BtnActualizar_Click(sender As Object, e As EventArgs) Handles BtnActualizar.Click
        If TxtMunicipio.Text = Nothing Then
            MessageBox.Show("Ingrese el Nombre del Municipio", "INNOVAMASTER", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            TxtMunicipio.Focus()
        ElseIf CboDepartamento.SelectedItem = Nothing Then
            MessageBox.Show("Seleccione el Departamento del Municipio", "INNOVAMASTER", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

        Else
            Try
                conec.Conectarse()
                Dim datos As New DatosMunicipio
                Dim funcion As New FMunicipio

                datos.gMunicipio = TxtMunicipio.Text
                datos.gIdMunicipio = Int(TxtIdMunicipio.Text)
                Dim cmd As SqlCommand
                Dim dr As SqlDataReader
                cmd = New SqlCommand(" Select IdDepartamento from Departamento where Departamento='" & CboDepartamento.Text & "'")
                cmd.CommandType = CommandType.Text
                cmd.Connection = conec.Con
                dr = cmd.ExecuteReader

                If dr.Read Then
                    datos.gIdDepartamento = dr(0)
                End If


                If funcion.Actualizar(datos) Then
                    MessageBox.Show("Municipio Modificado con éxito", "INNOVAMASTER", MessageBoxButtons.OK, MessageBoxIcon.Information)

                    GbMunicipio.Enabled = False
                    TxtIdMunicipio.Clear()
                    TxtMunicipio.Clear()
                    CboDepartamento.Text = "Municipio"
                    BtnNuevo.Visible = True
                    BtnEditar.Visible = True
                    BtnInsertar.Visible = False
                    BtnCancelar.Visible = False
                    BtnActualizar.Visible = False
                    DgvMunicipio.Enabled = True

                    MostrarMunicipio()

                End If

            Catch ex As Exception

                MsgBox(ex.ToString)

            End Try
        End If
    End Sub





    Private Sub BtnBusquedaCliente_Click(sender As Object, e As EventArgs) Handles BtnBusquedaCliente.Click
        With FrmDepartamento
            FrmDepartamento.var = 1
            .MdiParent = MenuPrincipal
            .Dock = DockStyle.Fill
            .Show()
        End With
    End Sub



    Private Sub DgvMunicipio_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles DgvMunicipio.CellDoubleClick
        If var = 1 Then
            FrmCliente.LlenarComboMunicipio()
            FrmCliente.CboMunicipio.Text = DgvMunicipio.CurrentRow.Cells(1).Value.ToString
            Me.Close()
        ElseIf var = 2 Then
            FrmEmpleado.LlenarComboMunicipio()
            FrmEmpleado.CmbMunicipio.Text = DgvMunicipio.CurrentRow.Cells(1).Value.ToString
            Me.Close()
        ElseIf var = 3 Then
            FrmProveedor.LlenarComboMunicipio()
            FrmProveedor.CboMunicipio.Text = DgvMunicipio.CurrentRow.Cells(1).Value.ToString
            Me.Close()
        End If
    End Sub



End Class