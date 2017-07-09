Imports System.Data.SqlClient
Public Class FrmEmpleado
    Dim conec As New Conexion
    Dim dt As New DataTable
    Dim cmd As SqlCommand
    Private Sub FrmEmpleado_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CboBusqueda.Text = CboBusqueda.Items(0).ToString
        Mostrar()
        LlenarComboMunicipio()
        LlenarComboEstadoCivil()
        LlenarComboCargo()
        LlenarComboProfesion()
        LlenarComboSucursal()
        llenarComboAñosN()
        llenarComboAñosC()
        BtnInsertar.Visible = False
        BtnCancelar.Visible = False
        BtnEditar.Visible = False
        GbEmpleado.Enabled = False
        DgvEmpleado.AlternatingRowsDefaultCellStyle.BackColor = Color.PapayaWhip
        DgvEmpleado.RowsDefaultCellStyle.BackColor = Color.Honeydew
        DgvEmpleado.RowsDefaultCellStyle.SelectionBackColor = Color.Coral

        Dim NombreArchivo As String = HTMLHelpClass.GetLocalHelpFileName("InnovaMasterAyuda2017.chm")
        HelpProvider1.HelpNamespace = NombreArchivo
        HelpProvider1.SetHelpNavigator(Me, HelpNavigator.KeywordIndex)
        HelpProvider1.SetHelpKeyword(Me, "Registro Empleado")

    End Sub
    Private Sub Mostrar()
        Try
            Dim funcion As New Fempleado
            dt = funcion.MostrarEmpleado

            If dt.Rows.Count <> 0 Then
                DgvEmpleado.DataSource = dt
                Label11.Visible = False
                TxtBusqueda.Enabled = True
                CboBusqueda.Enabled = True
                DgvEmpleado.Columns(14).Visible = False
            Else
                DgvEmpleado.DataSource = Nothing
                Label11.Visible = True
                TxtBusqueda.Enabled = False
                CboBusqueda.Enabled = False
            End If
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub
    Private Sub TxtBusqueda_TextChanged(sender As Object, e As EventArgs) Handles TxtBusqueda.TextChanged
        Dim ds As New DataSet
        ds.Tables.Add(dt.Copy)
        Dim dv As New DataView(ds.Tables(0))

        dv.RowFilter = CboBusqueda.Text & " like '" & TxtBusqueda.Text & "%'"

        If dv.Count <> 0 Then
            Label11.Visible = False
            DgvEmpleado.DataSource = dv
            DgvEmpleado.Columns(14).Visible = False
        Else
            Label11.Visible = True
            DgvEmpleado.DataSource = Nothing
        End If
    End Sub
    Public Sub LlenarComboMunicipio()
        CmbMunicipio.Items.Clear()
        Try
            conec.Conectarse()
            cmd = New SqlCommand("Select Municipio from Municipio")
            cmd.CommandType = CommandType.Text
            cmd.Connection = conec.Con
            Dim dr As SqlDataReader
            dr = cmd.ExecuteReader

            If dr.HasRows Then
                While dr.Read
                    CmbMunicipio.Items.Add(dr(0))
                End While
            End If
            dr.Close()
        Catch ex As Exception
            MsgBox(ex.ToString)
        Finally
            conec.Desconectarse()
        End Try
    End Sub
    Private Sub LlenarComboEstadoCivil()
        CmbEstadoCivil.Items.Clear()
        Try
            conec.Conectarse()
            cmd = New SqlCommand("Select EstadoCivil From EstadoCivil")
            cmd.CommandType = CommandType.Text
            cmd.Connection = conec.Con
            Dim dr As SqlDataReader
            dr = cmd.ExecuteReader

            If dr.HasRows Then
                While dr.Read
                    CmbEstadoCivil.Items.Add(dr(0))
                End While
            End If
            dr.Close()
        Catch ex As Exception
            MsgBox(ex.ToString)
        Finally
            conec.Desconectarse()
        End Try
    End Sub
    Public Sub LlenarComboCargo()
        CboCargo.Items.Clear()
        Try
            conec.Conectarse()
            cmd = New SqlCommand("Select Cargo from Cargo")
            cmd.CommandType = CommandType.Text
            cmd.Connection = conec.Con
            Dim dr As SqlDataReader
            dr = cmd.ExecuteReader

            If dr.HasRows Then
                While dr.Read
                    CboCargo.Items.Add(dr(0))
                End While
            End If
            dr.Close()
        Catch ex As Exception
            MsgBox(ex.ToString)
        Finally
            conec.Desconectarse()
        End Try
    End Sub
    Public Sub LlenarComboProfesion()
        CboProfesion.Items.Clear()
        Try
            conec.Conectarse()
            cmd = New SqlCommand("Select Profesion from Profesion")
            cmd.CommandType = CommandType.Text
            cmd.Connection = conec.Con
            Dim dr As SqlDataReader
            dr = cmd.ExecuteReader

            If dr.HasRows Then
                While dr.Read
                    CboProfesion.Items.Add(dr(0))
                End While
            End If
            dr.Close()
        Catch ex As Exception
            MsgBox(ex.ToString)
        Finally
            conec.Desconectarse()
        End Try
    End Sub
    Private Sub LlenarComboSucursal()
        CboSucursal.Items.Clear()
        Try
            conec.Conectarse()
            Dim cmd As New SqlCommand

            cmd.CommandType = CommandType.Text
            cmd = New SqlCommand("Select Sucursal from Sucursal")
            cmd.Connection = conec.Con
            Dim dr As SqlDataReader
            dr = cmd.ExecuteReader

            If dr.HasRows Then
                While dr.Read
                    CboSucursal.Items.Add(dr(0))
                End While
            End If
            dr.Close()
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub
    Private Sub llenarComboAñosN()
        Dim n As Integer
        For n = 1920 To 3000
            CmbAñoN.Items.Add(n)
        Next
    End Sub
    Private Sub llenarComboAñosC()
        Dim n As Integer
        For n = 1920 To 3000
            CboAñoC.Items.Add(n)
        Next
    End Sub
    Private Sub BtnNuevo_Click(sender As Object, e As EventArgs) Handles BtnNuevo.Click
        'Habilitar y deshabilitar controles del formulario
        GbEmpleado.Enabled = True
        BtnNuevo.Visible = False
        BtnInsertar.Visible = True
        BtnCancelar.Visible = True
        BtnEditar.Visible = False
        DgvEmpleado.Enabled = False
        BtnNuevoEditar.Visible = False
        TxtIdEmpleado.Enabled = True
        TxtIdEmpleado.Text = Nothing
        TxtNombres.Clear()
        TxtDireccion.Clear()
        TxtApellidos.Clear()
        TxtCelular.Clear()
        TxtTelefono.Clear()
        RdbMasculino.Checked = False
        CmbDiaN.Text = "Dia"
        CmbMesN.Text = "Mes"
        CmbAñoN.Text = "Año"
        CboDiaC.Text = "Dia"
        CboMesC.Text = "Mes"
        CboAñoC.Text = "Año"
        CmbMunicipio.Text = Nothing
        CmbEstadoCivil.Text = Nothing
        CboSucursal.Text = Nothing
        CboCargo.Text = Nothing
        LlenarComboMunicipio()
        LlenarComboEstadoCivil()
        LlenarComboCargo()
        LlenarComboProfesion()
        LlenarComboSucursal()
        PbEmpleado.Image = Nothing

    End Sub
    Private Sub DgvEmpleado_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DgvEmpleado.CellClick
        TxtIdEmpleado.Text = DgvEmpleado.SelectedCells.Item(0).Value
        TxtNombres.Text = DgvEmpleado.SelectedCells.Item(1).Value.ToString
        TxtApellidos.Text = DgvEmpleado.SelectedCells.Item(2).Value.ToString
        TxtDireccion.Text = DgvEmpleado.SelectedCells.Item(3).Value
        TxtTelefono.Text = DgvEmpleado.SelectedCells.Item(4).Value
        TxtCelular.Text = DgvEmpleado.SelectedCells.Item(5).Value
        CboCargo.Text = DgvEmpleado.SelectedCells.Item(8).Value
        CmbMunicipio.Text = DgvEmpleado.SelectedCells.Item(9).Value
        CmbEstadoCivil.Text = DgvEmpleado.SelectedCells.Item(10).Value
        CboProfesion.Text = DgvEmpleado.SelectedCells.Item(11).Value
        CboSucursal.Text = DgvEmpleado.SelectedCells.Item(13).Value
        PbEmpleado.Image = DgvEmpleado.SelectedCells.Item(14).FormattedValue
        If DgvEmpleado.SelectedCells.Item(12).Value = "Masculino" Then
            RdbMasculino.Select()
        Else
            RdbFemenino.Select()
        End If

        Dim cadena As String = DgvEmpleado.SelectedCells.Item(6).Value
        Dim c As String() = cadena.Split("/")
        CmbDiaN.Text = c(0)
        Select Case c(1)
            Case "01" Or "01"
                CmbMesN.Text = "Enero"
            Case "02" Or "02"
                CmbMesN.Text = "Febrero"
            Case "03" Or "03"
                CmbMesN.Text = "Marzo"
            Case "04" Or "04"
                CmbMesN.Text = "Abril"
            Case "05" Or "05"
                CmbMesN.Text = "Mayo"
            Case "06" Or "06"
                CmbMesN.Text = "Junio"
            Case "07" Or "07"
                CmbMesN.Text = "Julio"
            Case "08" Or "08"
                CmbMesN.Text = "Agosto"
            Case "09" Or "09"
                CmbMesN.Text = "Septiembre"
            Case "10"
                CmbMesN.Text = "Octubre"
            Case "11"
                CmbMesN.Text = "Noviembre"
            Case "12"
                CmbMesN.Text = "Diciembre"
        End Select
        Dim cadena2 As String = DgvEmpleado.SelectedCells.Item(7).Value
        Dim c2 As String() = cadena2.Split("/")
        CboDiaC.Text = c2(0)
        Select Case c2(1)
            Case "01" Or "01"
                CboMesC.Text = "Enero"
            Case "02" Or "02"
                CboMesC.Text = "Febrero"
            Case "03" Or "03"
                CboMesC.Text = "Marzo"
            Case "04" Or "04"
                CboMesC.Text = "Abril"
            Case "05" Or "05"
                CboMesC.Text = "Mayo"
            Case "06" Or "06"
                CboMesC.Text = "Junio"
            Case "07" Or "07"
                CboMesC.Text = "Julio"
            Case "08" Or "08"
                CboMesC.Text = "Agosto"
            Case "09" Or "09"
                CboMesC.Text = "Septiembre"
            Case "10"
                CboMesC.Text = "Octubre"
            Case "11"
                CboMesC.Text = "Noviembre"
            Case "12"
                CboMesC.Text = "Diciembre"
        End Select
        CmbAñoN.Text = c(2)
        CboAñoC.Text = c2(2)
    End Sub
    Private Sub BtnCancelar_Click(sender As Object, e As EventArgs) Handles BtnCancelar.Click
        'Cancelar el procesos realizados por el usuario
        Dim R As DialogResult
        R = MessageBox.Show("¿Desea Cancelar el Proceso?", "INNOVAMASTER", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

        If R = DialogResult.Yes Then
            Limpiar()
        End If

    End Sub
    Private Sub BtnInsertar_Click(sender As Object, e As EventArgs) Handles BtnInsertar.Click
        'Metodo del evento click del boton insetar, el cual realizar las operación correspondiente
        If TxtIdEmpleado.Text = Nothing Then
            MsgBox("Ingrese el Numero de Identidad del Empleado", MsgBoxStyle.Critical, "Error")
        ElseIf TxtNombres.Text = Nothing Then
            MsgBox("Ingrese el Nombre del Empleado", MsgBoxStyle.Critical, "Error")
        ElseIf TxtApellidos.Text = Nothing Then
            MsgBox("Ingrese los Apellidos del Empleado", MsgBoxStyle.Critical, "Error")
        ElseIf TxtDireccion.Text = Nothing Then
            MsgBox("Ingrese la Dirección del Empleado", MsgBoxStyle.Critical, "Error")
        ElseIf CmbDiaN.Text = "Dia" Then
            MsgBox("Seleccione el Dia de Nacimiento del Empleado", MsgBoxStyle.Critical, "Error")
        ElseIf CmbMesN.Text = "Mes" Then
            MsgBox("Seleccione el Mes de Nacimiento del Empleado", MsgBoxStyle.Critical, "Error")
        ElseIf CmbAñoN.Text = "Año" Then
            MsgBox("Seleccione el Año de Nacimiento del Empleado", MsgBoxStyle.Critical, "Error")
        ElseIf CboDiaC.Text = "Dia" Then
            MsgBox("Seleccione el Dia de Nacimiento del Empleado", MsgBoxStyle.Critical, "Error")
        ElseIf CboMesC.Text = "Mes" Then
            MsgBox("Seleccione el Mes de Nacimiento del Empleado", MsgBoxStyle.Critical, "Error")
        ElseIf CboAñoC.Text = "Año" Then
            MsgBox("Seleccione el Año de Nacimiento del Empleado", MsgBoxStyle.Critical, "Error")
        ElseIf RdbMasculino.Checked = False And RdbFemenino.Checked = False Then
            MsgBox("Seleccione el Sexo del Cliente", MsgBoxStyle.Critical, "Error")
        ElseIf CmbMunicipio.SelectedItem = Nothing Then
            MsgBox("Seleccione el Municipio del Empleado", MsgBoxStyle.Critical, "Error")
        ElseIf CmbEstadoCivil.Text = Nothing Then
            MsgBox("Seleccione el Estado Civil del Empleado", MsgBoxStyle.Critical, "Error")
        ElseIf CboCargo.SelectedItem = Nothing Then
            MsgBox("Seleccione el Municipio del Empleado", MsgBoxStyle.Critical, "Error")
        ElseIf CboProfesion.SelectedItem = Nothing Then
            MsgBox("Seleccione el Estado Civil del Empleado", MsgBoxStyle.Critical, "Error")
        ElseIf CboSucursal.Text = Nothing Then
            MsgBox("Seleccione el Estado Civil del Empleado", MsgBoxStyle.Critical, "Error")
        Else
            'Envio de datos a la Clase DatosEmpleado 
            Try
                Dim datos As New DatosEmpleado
                Dim funcion As New Fempleado

                datos.gIdEmpleado = TxtIdEmpleado.Text
                datos.gNombreEmpleado = TxtNombres.Text
                datos.gApellidoEmpleado = TxtApellidos.Text
                datos.gDireccionEmpleado = TxtDireccion.Text
                datos.gTelefonoEmpleado = TxtTelefono.Text
                datos.gCelularEmpleado = TxtCelular.Text

                Dim ms As New System.IO.MemoryStream

                If PbEmpleado.Image Is Nothing Then
                    PbEmpleado.Image = INNOVAMASTER.My.Resources.NULLA
                End If
                PbEmpleado.Image.Save(ms, PbEmpleado.Image.RawFormat)

                datos.gImagen = ms.GetBuffer

                Dim Mes As Integer

                If CmbMesN.Text = "Enero" Then
                    Mes = "1" Or "01"
                ElseIf CmbMesN.Text = "Febrero" Then
                    Mes = "2" Or "02"
                ElseIf CmbMesN.Text = "Marzo" Then
                    Mes = "3" Or "03"
                ElseIf CmbMesN.Text = "Abril" Then
                    Mes = "4" Or "04"
                ElseIf CmbMesN.Text = "Mayo" Then
                    Mes = "5" Or "05"
                ElseIf CmbMesN.Text = "Junio" Then
                    Mes = "6" Or "06"
                ElseIf CmbMesN.Text = "Julio" Then
                    Mes = "7" Or "07"
                ElseIf CmbMesN.Text = "Agosto" Then
                    Mes = "8" Or "09"
                ElseIf CmbMesN.Text = "Septiembre" Then
                    Mes = "9" Or "09"
                ElseIf CmbMesN.Text = "Octubre" Then
                    Mes = "10"
                ElseIf CmbMesN.Text = "Noviembre" Then
                    Mes = "11"
                ElseIf CmbMesN.Text = "Diciembre" Then
                    Mes = "12"
                End If
                Dim Mes2 As Integer

                If CboMesC.Text = "Enero" Then
                    Mes2 = "1"
                ElseIf CboMesC.Text = "Febrero" Then
                    Mes2 = "2"
                ElseIf CboMesC.Text = "Marzo" Then
                    Mes2 = "3"
                ElseIf CboMesC.Text = "Abril" Then
                    Mes2 = "4"
                ElseIf CboMesC.Text = "Mayo" Then
                    Mes2 = "5"
                ElseIf CboMesC.Text = "Junio" Then
                    Mes2 = "6"
                ElseIf CboMesC.Text = "Julio" Then
                    Mes2 = "7"
                ElseIf CboMesC.Text = "Agosto" Then
                    Mes2 = "8"
                ElseIf CboMesC.Text = "Septiembre" Then
                    Mes2 = "9"
                ElseIf CboMesC.Text = "Octubre" Then
                    Mes2 = "10"
                ElseIf CboMesC.Text = "Noviembre" Then
                    Mes2 = "11"
                ElseIf CboMesC.Text = "Diciembre" Then
                    Mes2 = "12"
                End If
                datos.gFechaNacimiento = CmbAñoN.Text & "-" & Mes.ToString & "-" & CmbDiaN.Text
                datos.gFechaContratacion = CboAñoC.Text & "-" & Mes2.ToString & "-" & CboDiaC.Text
                If RdbMasculino.Checked = True Then
                    datos.gIdSexo = 1
                Else
                    datos.gIdSexo = 2
                End If
                Try
                    conec.Conectarse()
                    cmd = New SqlCommand("Select IdMunicipio From Municipio Where Municipio= '" & CmbMunicipio.Text & "'")
                    cmd.CommandType = CommandType.Text
                    cmd.Connection = conec.Con
                    Dim dr As SqlDataReader
                    dr = cmd.ExecuteReader

                    If dr.Read Then
                        datos.gIdMunicipio = Int(dr(0))
                    End If
                    dr.Close()
                Catch ex As Exception
                    MsgBox(ex.Message)
                End Try
                Try
                    cmd = New SqlCommand("Select IdEstadoCivil From EstadoCivil Where EstadoCivil= '" & CmbEstadoCivil.Text & "'")
                    cmd.CommandType = CommandType.Text
                    cmd.Connection = conec.Con
                    Dim dr2 As SqlDataReader
                    dr2 = cmd.ExecuteReader

                    If dr2.Read Then
                        datos.gIdEstadoCivil = dr2(0)
                    End If
                    dr2.Close()
                Catch ex As Exception
                    MsgBox(ex.Message)
                End Try
                Try
                    cmd = New SqlCommand("Select IdCargo From Cargo Where Cargo= '" & CboCargo.Text & "'")
                    cmd.CommandType = CommandType.Text
                    cmd.Connection = conec.Con
                    Dim dr3 As SqlDataReader
                    dr3 = cmd.ExecuteReader

                    If dr3.Read Then
                        datos.gIdCargo = dr3(0)
                    End If
                    dr3.Close()
                Catch ex As Exception
                    MsgBox(ex.Message)
                End Try

                Try
                    cmd = New SqlCommand("Select IdProfesion From Profesion Where Profesion= '" & CboProfesion.Text & "'")

                    cmd.CommandType = CommandType.Text
                    cmd.Connection = conec.Con
                    Dim dr4 As SqlDataReader
                    dr4 = cmd.ExecuteReader

                    If dr4.Read Then
                        datos.gIdProfesion = dr4(0)

                    End If
                    dr4.Close()
                Catch ex As Exception
                    MsgBox(ex.Message)
                End Try

                Try
                    cmd = New SqlCommand("Select IdSucursal From Sucursal Where Sucursal= '" & CboSucursal.Text & "'")
                    cmd.CommandType = CommandType.Text
                    cmd.Connection = conec.Con
                    Dim dr5 As SqlDataReader
                    dr5 = cmd.ExecuteReader

                    If dr5.Read Then
                        datos.gIdSucursal = dr5(0)
                    End If
                    dr5.Close()
                Catch ex As Exception
                    MsgBox(ex.Message)
                End Try
                'Ejecucion del proceso para la manipulación de datos de la base de datos
                If funcion.InsertarEmpleado(datos) Then
                    MsgBox("Empleado Ingresado con Éxito", MsgBoxStyle.Information)
                    Limpiar()
                    Mostrar()
                    PbEmpleado.Image = Nothing
                End If

            Catch ex As Exception
                MsgBox(ex.ToString)
            Finally
                conec.Desconectarse()
            End Try

        End If

    End Sub
    Private Sub Limpiar()
        'Metodo para limpiar
        GbEmpleado.Enabled = False
        BtnInsertar.Visible = False
        BtnNuevo.Visible = True
        BtnEditar.Visible = False
        BtnNuevoEditar.Visible = True
        BtnCancelar.Visible = False
        DgvEmpleado.Enabled = True
        TxtIdEmpleado.Clear()
        TxtNombres.Clear()
        TxtDireccion.Clear()
        TxtApellidos.Clear()
        TxtCelular.Clear()
        TxtTelefono.Clear()
        RdbMasculino.Checked = False
        RdbFemenino.Checked = False
        CmbDiaN.Text = "Dia"
        CmbMesN.Text = "Mes"
        CmbAñoN.Text = "Año"
        CboDiaC.Text = "Dia"
        CboMesC.Text = "Mes"
        CboAñoC.Text = "Año"
        CmbMunicipio.Text = Nothing
        CmbEstadoCivil.Text = Nothing
        CboSucursal.Text = Nothing
        CboCargo.Text = Nothing
        CboProfesion.Text = Nothing

    End Sub
    Private Sub BtnNuevoEditar_Click(sender As Object, e As EventArgs) Handles BtnNuevoEditar.Click
        'Limpieza de los controles TextBox y habilitar varios controles
        If TxtNombres.Text <> Nothing Then
            GbEmpleado.Enabled = True
            BtnNuevo.Visible = False
            BtnInsertar.Visible = False
            BtnEditar.Visible = True
            BtnNuevoEditar.Visible = False
            BtnCancelar.Visible = True
            DgvEmpleado.Enabled = False
            TxtIdEmpleado.Enabled = False
        Else
            MessageBox.Show("Seleccione el Cliente a Editar", "Seleccionar", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If


    End Sub
    Private Sub BtnEditar_Click(sender As Object, e As EventArgs) Handles BtnEditar.Click
        'Metodo del evento click del boton editar, para realizar la opeacion conrrespondiente
        If TxtIdEmpleado.Text = Nothing Then
            MsgBox("Ingrese el Numero de Identidad del Empleado", MsgBoxStyle.Critical, "Error")
        ElseIf TxtNombres.Text = Nothing Then
            MsgBox("Ingrese el Nombre del Empleado", MsgBoxStyle.Critical, "Error")
        ElseIf TxtApellidos.Text = Nothing Then
            MsgBox("Ingrese los Apellidos del Empleado", MsgBoxStyle.Critical, "Error")
        ElseIf TxtDireccion.Text = Nothing Then
            MsgBox("Ingrese la Dirección del Empleado", MsgBoxStyle.Critical, "Error")
        ElseIf CmbDiaN.Text = "Dia" Then
            MsgBox("Seleccione el Dia de Nacimiento del Empleado", MsgBoxStyle.Critical, "Error")
        ElseIf CmbMesN.Text = "Mes" Then
            MsgBox("Seleccione el Mes de Nacimiento del Empleado", MsgBoxStyle.Critical, "Error")
        ElseIf CmbAñoN.Text = "Año" Then
            MsgBox("Seleccione el Año de Nacimiento del Empleado", MsgBoxStyle.Critical, "Error")
        ElseIf CboDiaC.Text = "Dia" Then
            MsgBox("Seleccione el Dia de Nacimiento del Empleado", MsgBoxStyle.Critical, "Error")
        ElseIf CboMesC.Text = "Mes" Then
            MsgBox("Seleccione el Mes de Nacimiento del Empleado", MsgBoxStyle.Critical, "Error")
        ElseIf CboAñoC.Text = "Año" Then
            MsgBox("Seleccione el Año de Nacimiento del Empleado", MsgBoxStyle.Critical, "Error")
        ElseIf RdbMasculino.Checked = False And RdbFemenino.Checked = False Then
            MsgBox("Seleccione el Sexo del Cliente", MsgBoxStyle.Critical, "Error")
        ElseIf CmbMunicipio.SelectedItem = Nothing Then
            MsgBox("Seleccione el Municipio del Empleado", MsgBoxStyle.Critical, "Error")
        ElseIf CmbEstadoCivil.Text = Nothing Then
            MsgBox("Seleccione el Estado Civil del Empleado", MsgBoxStyle.Critical, "Error")
        ElseIf CboCargo.SelectedItem = Nothing Then
            MsgBox("Seleccione el Municipio del Empleado", MsgBoxStyle.Critical, "Error")
        ElseIf CboProfesion.SelectedItem = Nothing Then
            MsgBox("Seleccione la Profesión del Empleado", MsgBoxStyle.Critical, "Error")
        ElseIf CboSucursal.Text = Nothing Then
            MsgBox("Seleccione la Sucursal del Empleado", MsgBoxStyle.Critical, "Error")
        Else
            'Envio de datos a la clase DatosEmpleado
            Try

                Dim datos As New DatosEmpleado
                Dim funcion As New Fempleado

                datos.gIdEmpleado = TxtIdEmpleado.Text
                datos.gNombreEmpleado = TxtNombres.Text
                datos.gApellidoEmpleado = TxtApellidos.Text
                datos.gDireccionEmpleado = TxtDireccion.Text
                datos.gTelefonoEmpleado = TxtTelefono.Text
                datos.gCelularEmpleado = TxtCelular.Text

                Dim ms As New System.IO.MemoryStream

                If PbEmpleado.Image Is Nothing Then
                    'PbEmpleado.Image = Image.FromFile("C:\Archivo.PNG")
                    PbEmpleado.Image = INNOVAMASTER.My.Resources.NULLA


                End If
                PbEmpleado.Image.Save(ms, PbEmpleado.Image.RawFormat)

                datos.gImagen = ms.GetBuffer
                Dim Mes As Integer

                If CmbMesN.Text = "Enero" Then
                    Mes = "1" Or "01"
                ElseIf CmbMesN.Text = "Febrero" Then
                    Mes = "2" Or "02"
                ElseIf CmbMesN.Text = "Marzo" Then
                    Mes = "3" Or "03"
                ElseIf CmbMesN.Text = "Abril" Then
                    Mes = "4" Or "04"
                ElseIf CmbMesN.Text = "Mayo" Then
                    Mes = "5" Or "05"
                ElseIf CmbMesN.Text = "Junio" Then
                    Mes = "6" Or "06"
                ElseIf CmbMesN.Text = "Julio" Then
                    Mes = "7" Or "07"
                ElseIf CmbMesN.Text = "Agosto" Then
                    Mes = "8" Or "09"
                ElseIf CmbMesN.Text = "Septiembre" Then
                    Mes = "9" Or "09"
                ElseIf CmbMesN.Text = "Octubre" Then
                    Mes = "10"
                ElseIf CmbMesN.Text = "Noviembre" Then
                    Mes = "11"
                ElseIf CmbMesN.Text = "Diciembre" Then
                    Mes = "12"
                End If

                Dim Mes2 As Integer

                If CboMesC.Text = "Enero" Then
                    Mes2 = "1"
                ElseIf CboMesC.Text = "Febrero" Then
                    Mes2 = "2"
                ElseIf CboMesC.Text = "Marzo" Then
                    Mes2 = "3"
                ElseIf CboMesC.Text = "Abril" Then
                    Mes2 = "4"
                ElseIf CboMesC.Text = "Mayo" Then
                    Mes2 = "5"
                ElseIf CboMesC.Text = "Junio" Then
                    Mes2 = "6"
                ElseIf CboMesC.Text = "Julio" Then
                    Mes2 = "7"
                ElseIf CboMesC.Text = "Agosto" Then
                    Mes2 = "8"
                ElseIf CboMesC.Text = "Septiembre" Then
                    Mes2 = "9"
                ElseIf CboMesC.Text = "Octubre" Then
                    Mes2 = "10"
                ElseIf CboMesC.Text = "Noviembre" Then
                    Mes2 = "11"
                ElseIf CboMesC.Text = "Diciembre" Then
                    Mes2 = "12"
                End If


                datos.gFechaNacimiento = CmbAñoN.Text & "-" & Mes.ToString & "-" & CmbDiaN.Text
                datos.gFechaContratacion = CboAñoC.Text & "-" & Mes2.ToString & "-" & CboDiaC.Text
                If RdbMasculino.Checked = True Then
                    datos.gIdSexo = 1
                Else
                    datos.gIdSexo = 2
                End If

                conec.Conectarse()
                Try
                    conec.Conectarse()
                    cmd = New SqlCommand("Select IdMunicipio From Municipio Where Municipio= '" & CmbMunicipio.Text & "'")
                    cmd.CommandType = CommandType.Text
                    cmd.Connection = conec.Con
                    Dim dr As SqlDataReader
                    dr = cmd.ExecuteReader

                    If dr.Read Then
                        datos.gIdMunicipio = Int(dr(0))
                    End If
                    dr.Close()
                Catch ex As Exception
                    MsgBox(ex.Message)
                End Try
                Try
                    cmd = New SqlCommand("Select IdEstadoCivil From EstadoCivil Where EstadoCivil= '" & CmbEstadoCivil.Text & "'")
                    cmd.CommandType = CommandType.Text
                    cmd.Connection = conec.Con
                    Dim dr2 As SqlDataReader
                    dr2 = cmd.ExecuteReader

                    If dr2.Read Then
                        datos.gIdEstadoCivil = dr2(0)
                    End If
                    dr2.Close()
                Catch ex As Exception
                    MsgBox(ex.Message)
                End Try
                Try
                    cmd = New SqlCommand("Select IdCargo From Cargo Where Cargo= '" & CboCargo.Text & "'")
                    cmd.CommandType = CommandType.Text
                    cmd.Connection = conec.Con
                    Dim dr3 As SqlDataReader
                    dr3 = cmd.ExecuteReader

                    If dr3.Read Then
                        datos.gIdCargo = dr3(0)
                    End If
                    dr3.Close()
                Catch ex As Exception
                    MsgBox(ex.Message)
                End Try

                Try
                    cmd = New SqlCommand("Select IdProfesion From Profesion Where Profesion= '" & CboProfesion.Text & "'")

                    cmd.CommandType = CommandType.Text
                    cmd.Connection = conec.Con
                    Dim dr4 As SqlDataReader
                    dr4 = cmd.ExecuteReader

                    If dr4.Read Then
                        datos.gIdProfesion = dr4(0)

                    End If
                    dr4.Close()
                Catch ex As Exception
                    MsgBox(ex.Message)
                End Try

                Try
                    cmd = New SqlCommand("Select IdSucursal From Sucursal Where Sucursal= '" & CboSucursal.Text & "'")
                    cmd.CommandType = CommandType.Text
                    cmd.Connection = conec.Con
                    Dim dr5 As SqlDataReader
                    dr5 = cmd.ExecuteReader

                    If dr5.Read Then
                        datos.gIdSucursal = dr5(0)
                    End If
                    dr5.Close()
                Catch ex As Exception
                    MsgBox(ex.Message)
                End Try

                'Ejecución de la accion para la manipulación de los datos
                If funcion.EditarEmpleado(datos) Then
                    MsgBox("Empleado editado con éxito", MsgBoxStyle.Information)
                    Limpiar()
                    Mostrar()
                    PbEmpleado.Image = Nothing
                End If

            Catch ex As Exception
                MsgBox(ex.ToString)
            Finally
                conec.Desconectarse()
            End Try

        End If

    End Sub


    Private Sub BtnAgregarImagen_Click(sender As Object, e As EventArgs) Handles BtnAgregarImagen.Click
        'Agregar imagen al PictureBox
        OpenFileDialog1.Filter = "Imagenes JPG|*.jpg|Imagenes GIF|*.gif|Imagenes Bitmasps|*.bmp"
        If OpenFileDialog1.ShowDialog() = DialogResult.OK Then
            PbEmpleado.Image = Image.FromFile(OpenFileDialog1.FileName)
        End If
    End Sub
    Private Sub BtnEliminarImagen_Click(sender As Object, e As EventArgs) Handles BtnEliminarImagen.Click
        PbEmpleado.Image = Nothing
    End Sub

    Private Sub DgvEmpleado_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DgvEmpleado.CellContentClick

    End Sub

    Private Sub TxtNombres_TextChanged(sender As Object, e As EventArgs) Handles TxtNombres.TextChanged

    End Sub

    Private Sub GbEmpleado_Enter(sender As Object, e As EventArgs) Handles GbEmpleado.Enter

    End Sub




    Private Sub BtnBusquedaCliente_Click(sender As Object, e As EventArgs) Handles BtnBusquedaCliente.Click
        With FrmMunicipio
            FrmMunicipio.var = 2
            .MdiParent = MenuPrincipal
            .Dock = DockStyle.Fill
            .Show()
        End With
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        With frmCargo
            frmCargo.var = 1
            .MdiParent = MenuPrincipal
            .Dock = DockStyle.Fill
            .Show()
        End With
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        With FrmProfesiones
            FrmProfesiones.var = 1
            .MdiParent = MenuPrincipal
            .Dock = DockStyle.Fill
            .Show()
        End With
    End Sub


End Class