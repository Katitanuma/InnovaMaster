Imports System.Data.SqlClient
Public Class FrmModelo
    Dim dt As New DataTable
    Dim conec As New Conexion
    Public var As Integer = 0
    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.

    End Sub

    Private Sub FrmModelo_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CboBusqueda.Text = CboBusqueda.Items(0).ToString
        MostrarModelo()
        GbModelo.Enabled = False
        TxtIdModelo.Enabled = False
        DgvModelo.Enabled = True
        Call LlenarComboboxMarca()


    End Sub
    Private Sub MostrarModelo()
        Try
            Dim datos As New FModelo
            dt = datos.MostrarModelo

            If dt.Rows.Count <> 0 Then
                LblFilas.Visible = False
                DgvModelo.DataSource = dt

                TxtBusqueda.Enabled = True
            Else
                LblFilas.Visible = True
                DgvModelo.DataSource = Nothing

                TxtBusqueda.Enabled = False
            End If
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub

    Private Sub DgvModelo_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DgvModelo.CellClick
        TxtIdModelo.Text = DgvModelo.SelectedCells.Item(0).Value
        TxtModelo.Text = DgvModelo.SelectedCells.Item(1).Value
        CboMarca.Text = DgvModelo.SelectedCells.Item(2).Value
    End Sub

    Private Sub txtBusqueda_TextChanged(sender As Object, e As EventArgs) Handles TxtBusqueda.TextChanged
        Dim ds As New DataSet
        Dim dv As New DataView

        ds.Tables.Add(dt.Copy)
        dv = New DataView(ds.Tables(0))

        dv.RowFilter = CboBusqueda.Text & " like '" & TxtBusqueda.Text & "%'"

        If dv.Count <> 0 Then
            LblFilas.Visible = False
            DgvModelo.DataSource = dv
        Else
            LblFilas.Visible = True
            DgvModelo.DataSource = Nothing
        End If
    End Sub

    Private Sub BtnNuevo_Click(sender As Object, e As EventArgs) Handles BtnNuevo.Click
        GbModelo.Enabled = True
        TxtIdModelo.Clear()
        TxtModelo.Clear()
        CboMarca.Text = Nothing
        BtnNuevo.Visible = False
        BtnEditar.Visible = False
        BtnInsertar.Visible = True
        BtnCancelar.Visible = True
        DgvModelo.Enabled = False
    End Sub



    Private Sub BtnEditar_Click(sender As Object, e As EventArgs) Handles BtnEditar.Click
        If TxtIdModelo.Text <> Nothing Then

            GbModelo.Enabled = True
            BtnNuevo.Visible = False
            BtnEditar.Visible = False
            BtnActualizar.Visible = True
            BtnCancelar.Visible = True
            BtnInsertar.Visible = False
            TxtIdModelo.Visible = True
            DgvModelo.Enabled = False


        Else
            MessageBox.Show("Seleccione el Modelo a Actualizar", "INNOVAMASTER", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub

    Private Sub BtnCancelar_Click(sender As Object, e As EventArgs) Handles BtnCancelar.Click
        Dim r As DialogResult = MessageBox.Show("¿Desea Cancelar el Proceso?", "INNOVAMASTER ", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

        If r = DialogResult.Yes Then
            GbModelo.Enabled = False
            TxtIdModelo.Clear()
            TxtModelo.Clear()
            CboMarca.Text = Nothing
            BtnNuevo.Visible = True
            BtnEditar.Visible = True
            BtnInsertar.Visible = False
            BtnCancelar.Visible = False
            BtnActualizar.Visible = False
            DgvModelo.Enabled = True

        End If

    End Sub

    Private Sub Btninsertar_Click(sender As Object, e As EventArgs) Handles BtnInsertar.Click
        If TxtModelo.Text = Nothing Then
            MessageBox.Show("Ingrese el Nombre del Modelo", "INNOVAMASTER", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            TxtModelo.Focus()
        ElseIf CboMarca.SelectedItem = Nothing Then
            MessageBox.Show("Seleccione la Marca del Modelo", "INNOVAMASTER", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

        Else
            Try
                conec.Conectarse()
                Dim datos As New DatosModelo
                Dim funcion As New FModelo

                datos.gModelo = TxtModelo.Text
                Dim cmd As SqlCommand
                Dim dr As SqlDataReader
                cmd = New SqlCommand(" Select IdMarca from MarcaVehiculo where Marca='" & CboMarca.Text & "'")
                cmd.CommandType = CommandType.Text
                cmd.Connection = conec.Con
                dr = cmd.ExecuteReader

                If dr.Read Then
                    datos.gIdMarca = dr(0)
                End If



                If funcion.Insertar(datos) Then
                    MessageBox.Show("Modelo Insertado con Exito", "INNOVAMASTER", MessageBoxButtons.OK, MessageBoxIcon.Information)

                    GbModelo.Enabled = False
                    TxtIdModelo.Clear()
                    TxtModelo.Clear()
                    CboMarca.Text = Nothing
                    BtnNuevo.Visible = True
                    BtnEditar.Visible = True
                    BtnInsertar.Visible = False
                    BtnCancelar.Visible = False
                    BtnActualizar.Visible = False
                    DgvModelo.Enabled = True

                    MostrarModelo()


                End If

            Catch ex As Exception

                MsgBox(ex.ToString)

            End Try
        End If


    End Sub
    Private Sub BtnActualizar_Click(sender As Object, e As EventArgs) Handles BtnActualizar.Click
        If TxtModelo.Text = Nothing Then
            MessageBox.Show("Ingrese el Nombre del Modelo", "INNOVAMASTER", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            TxtModelo.Focus()
        ElseIf CboMarca.SelectedItem = Nothing Then
            MessageBox.Show("Seleccione la Marca del Modelo", "INNOVAMASTER", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

        Else
            Try
                conec.Conectarse()
                Dim datos As New DatosModelo
                Dim funcion As New FModelo

                datos.gModelo = TxtModelo.Text
                datos.gIdModelo = Int(TxtIdModelo.Text)
                Dim cmd As SqlCommand
                Dim dr As SqlDataReader
                cmd = New SqlCommand(" Select IdMarca from MarcaVehiculo where Marca='" & CboMarca.Text & "'")
                cmd.CommandType = CommandType.Text
                cmd.Connection = conec.Con
                dr = cmd.ExecuteReader

                If dr.Read Then
                    datos.gIdMarca = dr(0)
                End If



                If funcion.Actualizar(datos) Then
                    MessageBox.Show("Modelo Modificado con éxito", "INNOVAMASTER", MessageBoxButtons.OK, MessageBoxIcon.Information)

                    GbModelo.Enabled = False
                    TxtIdModelo.Clear()
                    TxtModelo.Clear()
                    CboMarca.Text = Nothing
                    BtnNuevo.Visible = True
                    BtnEditar.Visible = True
                    BtnInsertar.Visible = False
                    BtnCancelar.Visible = False
                    BtnActualizar.Visible = False
                    DgvModelo.Enabled = True

                    MostrarModelo()


                End If

            Catch ex As Exception

                MsgBox(ex.ToString)

            End Try
        End If


    End Sub

    Public Sub LlenarComboboxMarca()
        CboMarca.Items.Clear()

        Try
            conec.Conectarse()
            Dim cmd As New SqlCommand
            cmd = New SqlCommand("select Marca from MarcaVehiculo")
            cmd.CommandType = CommandType.Text
            cmd.Connection = conec.Con
            Dim dr As SqlDataReader
            dr = cmd.ExecuteReader

            While dr.Read
                CboMarca.Items.Add(dr(0))
            End While

        Catch ex As Exception
            MsgBox(ex.ToString)
        Finally
            conec.Desconectarse()
        End Try

    End Sub




    Private Sub BtnBusquedaCliente_Click(sender As Object, e As EventArgs) Handles BtnBusquedaCliente.Click
        With FrmMarca
            FrmMarca.var = 1
            .MdiParent = MenuPrincipal
            .Dock = DockStyle.Fill
            .Show()
        End With
    End Sub

    Private Sub DgvModelo_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DgvModelo.CellContentClick
        If var = 1 Then
            FrmProducto.LlenarCombos()
            FrmProducto.TxtModelo.Text = DgvModelo.CurrentRow.Cells(1).Value.ToString
            Me.Close()
        End If
    End Sub
End Class