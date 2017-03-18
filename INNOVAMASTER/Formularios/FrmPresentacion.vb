Public Class FrmPresentacion
    Dim i As Integer
    Private Sub FrmPresentacion_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Timer1.Interval = 200
        Timer1.Start()
        i = 0
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        i += 1
        If i = 1 Then
            LblProgreso.Text = "Estableciendo Procesos..."
        ElseIf i = 2 Then
            LblProgreso.Text = "Estableciendo Procesos......."
        ElseIf i = 3 Then
            LblProgreso.Text = "Estableciendo Procesos..."
        ElseIf i = 4 Then
            LblProgreso.Text = "Inicializando Procesos..."
        ElseIf i = 5 Then
            LblProgreso.Text = "Inicializando Procesos......."
        ElseIf i = 6 Then
            LblProgreso.Text = "Inicializando Procesos..."
        ElseIf i = 7 Then
            LblProgreso.Text = "Estableciendo Estructuras..."
        ElseIf i = 8 Then
            LblProgreso.Text = "Estableciendo Estructuras......"
        ElseIf i = 9 Then
            LblProgreso.Text = "Estableciendo Estructuras..."
        ElseIf i = 10 Then
            LblProgreso.Text = "Implementanto Estructuras..."
        ElseIf i = 11 Then
            LblProgreso.Text = "Implementanto Estructuras......."
        ElseIf i = 12 Then
            LblProgreso.Text = "Implementanto Estructuras..."
        ElseIf i = 13 Then
            LblProgreso.Text = "Recopilando Datos..."
        ElseIf i = 14 Then
            LblProgreso.Text = "Recopilando Datos......."
        ElseIf i = 15 Then
            LblProgreso.Text = "Recopilando Datos..."
        ElseIf i = 16 Then
            LblProgreso.Text = "Finalizando Procesos..."
        ElseIf i = 17 Then
            LblProgreso.Text = "Finalizando Procesos......"
        ElseIf i = 18 Then
            LblProgreso.Text = "Finalizando Procesos..."
        ElseIf i = 19 Then
            LblProgreso.Text = "Listo..."
        ElseIf i = 20 Then
            LblProgreso.Text = "Listo..."
        ElseIf i = 21 Then
            LblProgreso.Text = "DISFRUTA DE NUESTROS SERVICIOS"
        ElseIf i = 22 Then
            LblProgreso.Text = "DISFRUTA DE NUESTROS SERVICIOS"
        ElseIf i = 23 Then
            LblProgreso.Text = "DISFRUTA DE NUESTROS SERVICIOS"
        ElseIf i = 24 Then
            LblProgreso.Text = "DISFRUTA DE NUESTROS SERVICIOS"
        ElseIf i = 25 Then
            LblProgreso.Text = "DISFRUTA DE NUESTROS SERVICIOS"
            Timer1.Stop()
            Me.Hide()
            FrmLogin.Show()
        End If
    End Sub
End Class