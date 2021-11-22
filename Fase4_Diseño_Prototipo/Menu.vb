Imports System.IO

Public Class Menu

    Dim lBrowser As New WebBrowser()
    'Aqui tenemos los eventos de Los paneles'
    Private Sub Menu_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'BdAlumnoDataSet.Alumno' Puede moverla o quitarla según sea necesario.
        Me.AlumnoTableAdapter.Fill(Me.BdAlumnoDataSet.Alumno)
        ClientSize = New Size(951, 599)
        StartPosition = FormStartPosition.CenterScreen
        btnMenu.Visible = True
        pnlMenu.Width = 50
        btnConsulta.Visible = False
        btnTemas.Visible = False
        BtnRegistro.Visible = False
        btnSalir.Visible = False
        lbltituloMenu.Visible = False
        PnlContenido.Visible = False
        PnlConsulta.Visible = False
        Pnltemas.Visible = False
        PnlPdf.Visible = False
        PnlVidos.Visible = False
        PnlAudio.Visible = False
        lblTemadescription.Visible = False
        lblFecha.Text = DateTime.Now.ToLongDateString()
        BorrarCamposs()

    End Sub

    Private Sub pnlMenu_MouseMove(sender As Object, e As MouseEventArgs) Handles pnlMenu.MouseMove
        btnMenu.Visible = False
        pnlMenu.Width = 180
        btnConsulta.Visible = True
        btnTemas.Visible = True
        BtnRegistro.Visible = True
        btnSalir.Visible = True
        lbltituloMenu.Text = "Menu"
        lbltituloMenu.Visible = True
        PnlContenido.Location = New Point(186, 67)
        PnlConsulta.Location = New Point(186, 67)
        Pnltemas.Location = New Point(186, 67)
        PnlPdf.Location = New Point(186, 67)
        PnlVidos.Location = New Point(186, 67)
        PnlAudio.Location = New Point(186, 67)

    End Sub

    Private Sub Menu_MouseMove(sender As Object, e As MouseEventArgs) Handles MyBase.MouseMove
        btnMenu.Visible = True
        pnlMenu.Width = 50
        btnConsulta.Visible = False
        btnTemas.Visible = False
        BtnRegistro.Visible = False
        btnSalir.Visible = False
        lbltituloMenu.Visible = False
        PnlContenido.Location = New Point(130, 67)
        PnlConsulta.Location = New Point(130, 67)
        Pnltemas.Location = New Point(130, 67)
        PnlPdf.Location = New Point(130, 67)
        PnlVidos.Location = New Point(130, 67)
        PnlAudio.Location = New Point(130, 67)
    End Sub
    'Aqui tenemos los Botones de la barra de menu '
    Private Sub BtnRegistro_Click(sender As Object, e As EventArgs) Handles BtnRegistro.Click
        lblTitulo.Location = New Point(368, 9)
        lblTitulo.Text = "Datos Alumno"
        PnlContenido.Visible = True
        PnlConsulta.Visible = False
        PnlVidos.Visible = False
        Pnltemas.Visible = False
        PnlPdf.Visible = False
        PnlAudio.Visible = False
    End Sub

    Private Sub btnConsulta_Click(sender As Object, e As EventArgs) Handles btnConsulta.Click
        lblTitulo.Location = New Point(270, 9)
        lblTitulo.Text = "Consulta Tabla Alumno"
        PnlConsulta.Location = New Point(186, 67)
        PnlContenido.Visible = False
        PnlConsulta.Visible = True
        PnlVidos.Visible = False
        Pnltemas.Visible = False
        PnlPdf.Visible = False
        PnlAudio.Visible = False
    End Sub

    Private Sub btnTemas_Click(sender As Object, e As EventArgs) Handles btnTemas.Click
        lblTitulo.Location = New Point(350, 9)
        lblTitulo.Text = "Temas de Estudio"
        Pnltemas.Location = New Point(186, 67)
        Pnltemas.Visible = True
        PnlContenido.Visible = False
        PnlConsulta.Visible = False
        PnlPdf.Visible = False
        PnlAudio.Visible = False


    End Sub

    'Aqui realizaremos la visualizacion de los Videos'

    Private Sub TmsVd1_Click(sender As Object, e As EventArgs) Handles TmsVd1.Click
        'ESTUDIANTE NN VIDEO TEMA 1'
        lblTemadescription.Visible = False
        PnlVidos.Location = New Point(186, 81)
        lblTemadescription.Visible = True
        lblTemadescription.Text = "Tema 1 : Realidad Virtual"
        PnlVidos.Visible = True
        PnlAudio.Visible = False
        PnlPdf.Visible = False
        PnlVidos.Controls.Add(lBrowser)
        lBrowser.Location = New Point(150, 85)
        lBrowser.Size = New Size(500, 300)
        lBrowser.Navigate("https://youtu.be/YpZbGBjC5yA")


    End Sub

    Private Sub TmsVd2_Click(sender As Object, e As EventArgs) Handles TmsVd2.Click
        'ESTUDIANTE ANGY VIDEO TEMA 2'
        lblTemadescription.Visible = False
        PnlVidos.Location = New Point(186, 81)
        lblTemadescription.Visible = True
        lblTemadescription.Text = "Tema 2 : Seguridad Informatica"
        PnlVidos.Visible = True
        PnlAudio.Visible = False
        PnlPdf.Visible = False
        PnlVidos.Controls.Add(lBrowser)
        lBrowser.Location = New Point(150, 85)
        lBrowser.Size = New Size(500, 300)
        lBrowser.Navigate("https://youtu.be/JXDUKotmsWQ")

    End Sub

    Private Sub TmsVd3_Click(sender As Object, e As EventArgs) Handles TmsVd3.Click
        'ESTUDIANTE CARLOS MARQUEZ VIDEO TEMA 3'
        lblTemadescription.Visible = False
        PnlVidos.Location = New Point(186, 81)
        lblTemadescription.Visible = True
        lblTemadescription.Text = "Tema 3 : Condicionales para Programación"
        PnlVidos.Visible = True
        PnlAudio.Visible = False
        PnlPdf.Visible = False
        PnlVidos.Controls.Add(lBrowser)
        lBrowser.Location = New Point(150, 85)
        lBrowser.Size = New Size(500, 300)
        lBrowser.Navigate("https://youtu.be/SodnVtmOrlw")


    End Sub

    'Aqui empizan los archivos PDF con los temas a Presentar'

    Private Sub TsmTema1_Click(sender As Object, e As EventArgs) Handles TsmTema1.Click
        lblTemadescription.Visible = False
        Dim nombreArchivo As String = "PdfTemas\Tema1.pdf"
        Dim rutaCompleta As String
        Dim dato As String
        rutaCompleta = Path.Combine(Directory.GetCurrentDirectory(), nombreArchivo)
        dato = rutaCompleta.ToString()

        AxAcroPDF1.Visible = True
        AxAcroPDF1.src = dato
        lblTemadescription.Visible = True
        lblTemadescription.Text = "Tema 1 : Realidad Virtual"

        PnlPdf.Location = New Point(186, 81)
        PnlPdf.Visible = True
        PnlVidos.Visible = False
        PnlAudio.Visible = False
        lBrowser.Stop()

    End Sub

    Private Sub TsmAbriPdf_Click(sender As Object, e As EventArgs) Handles TsmAbriPdf.Click
        lblTemadescription.Visible = False
        OpenFileDialog1.ShowDialog()
        AxAcroPDF1.src = OpenFileDialog1.FileName
        PnlPdf.Location = New Point(186, 81)
        PnlPdf.Visible = True
        PnlVidos.Visible = False
        PnlAudio.Visible = False
        lBrowser.Stop()
    End Sub

    Private Sub TsmTema2_Click(sender As Object, e As EventArgs) Handles TsmTema2.Click

        Dim nombreArchivo As String = "PdfTemas\Tema2.pdf"
        Dim rutaCompleta As String
        Dim dato As String
        rutaCompleta = Path.Combine(Directory.GetCurrentDirectory(), nombreArchivo)
        dato = rutaCompleta.ToString()
        lblTemadescription.Visible = True
        lblTemadescription.Text = "Tema 2 : Seguridad Informatica"
        AxAcroPDF1.Visible = True
        AxAcroPDF1.src = dato
        PnlPdf.Location = New Point(186, 81)
        PnlPdf.Visible = True
        PnlVidos.Visible = False
        PnlAudio.Visible = False
        lBrowser.Stop()
    End Sub

    Private Sub TsmTema3_Click(sender As Object, e As EventArgs) Handles TsmTema3.Click

        Dim nombreArchivo As String = "PdfTemas\Tema3.pdf"
        Dim rutaCompleta As String
        Dim dato As String
        rutaCompleta = Path.Combine(Directory.GetCurrentDirectory(), nombreArchivo)
        dato = rutaCompleta.ToString()
        lblTemadescription.Visible = True
        lblTemadescription.Text = "Tema 3 : Condicionales para Programación"
        AxAcroPDF1.Visible = True
        PnlPdf.Location = New Point(186, 81)
        PnlPdf.Visible = True
        PnlVidos.Visible = False
        PnlAudio.Visible = False
        lBrowser.Stop()

    End Sub
    'Aqui empesamos con los audios'
    Private Sub TmsAud1_Click(sender As Object, e As EventArgs) Handles TmsAud1.Click
        PnlAudio.Location = New Point(186, 81)
        PnlAudio.Visible = True
        PnlPdf.Visible = False
        PnlVidos.Visible = False
        lblTemadescription.Visible = True
        lblTemadescription.Text = "Tema 1 : Realidad Virtual"
        Dim nombreArchivo As String = "Audio\Tema1.wav"
        Dim rutaCompleta As String
        Dim dato As String

        rutaCompleta = Path.Combine(Directory.GetCurrentDirectory(), nombreArchivo)
        dato = rutaCompleta.ToString()

        AxWindowsMediaPlayer1.URL = dato

    End Sub

    Private Sub TmsAud3_Click(sender As Object, e As EventArgs) Handles TmsAud3.Click
        PnlAudio.Location = New Point(186, 81)
        PnlAudio.Visible = True
        PnlPdf.Visible = False
        PnlVidos.Visible = False
        lblTemadescription.Visible = True
        lblTemadescription.Text = "Tema 3 : Condicionales para Programación"
        Dim nombreArchivo As String = "Audio\Tema3.wav"
        Dim rutaCompleta As String
        Dim dato As String

        rutaCompleta = Path.Combine(Directory.GetCurrentDirectory(), nombreArchivo)
        dato = rutaCompleta.ToString()

        AxWindowsMediaPlayer1.URL = dato
    End Sub

    Private Sub TmsAud2_Click(sender As Object, e As EventArgs) Handles TmsAud2.Click
        PnlAudio.Location = New Point(186, 81)
        PnlAudio.Visible = True
        PnlPdf.Visible = False
        PnlVidos.Visible = False
        lblTemadescription.Visible = True
        lblTemadescription.Text = "Tema 2 : Seguridad Informatica"
        Dim nombreArchivo As String = "Audio\Tema2.wav"
        Dim rutaCompleta As String
        Dim dato As String

        rutaCompleta = Path.Combine(Directory.GetCurrentDirectory(), nombreArchivo)
        dato = rutaCompleta.ToString()

        AxWindowsMediaPlayer1.URL = dato
    End Sub

    Private Sub btnSalir_Click(sender As Object, e As EventArgs) Handles btnSalir.Click
        Application.Exit()
    End Sub

    Private Sub btnRegistar_Click(sender As Object, e As EventArgs) Handles btnRegistar.Click
        Me.AlumnoTableAdapter.Insertar(TxtIdentificacion.Text, TxtNombre.Text, TxtApellido.Text, TxtCarrera.Text, TxtCorreo.Text)
        Me.AlumnoTableAdapter.Fill(Me.BdAlumnoDataSet.Alumno)
        MsgBox("Datos Ingresados")
        BorrarCamposs()
    End Sub

    Private Sub btnActualizar_Click(sender As Object, e As EventArgs) Handles btnActualizar.Click
        Me.AlumnoTableAdapter.Actualizar(TxtIdentificacion.Text, TxtNombre.Text, TxtApellido.Text, TxtCarrera.Text, TxtCorreo.Text, TxtIdentificacion.Text)
        Me.AlumnoTableAdapter.Fill(Me.BdAlumnoDataSet.Alumno)
        MsgBox("Se Actualizo el Registro")
        BorrarCamposs()
    End Sub

    Private Sub btnConsultar_Click(sender As Object, e As EventArgs) Handles btnConsultar.Click
        Me.AlumnoTableAdapter.Buscar(BdAlumnoDataSet.Alumno, TxtIdentificacion.Text)
        Me.AlumnoTableAdapter.Fill(Me.BdAlumnoDataSet.Alumno)
    End Sub

    Private Sub btnEliminar_Click(sender As Object, e As EventArgs) Handles btnEliminar.Click

        Me.AlumnoTableAdapter.Borrar(TxtIdentificacion.Text)
        Me.AlumnoTableAdapter.Fill(Me.BdAlumnoDataSet.Alumno)
        MsgBox("Se Elimino Registro")
        BorrarCamposs()
    End Sub

    Private Sub BorrarCamposs()
        TxtIdentificacion.Text = ""
        TxtNombre.Text = ""
        TxtApellido.Text = ""
        TxtCarrera.Text = ""
        TxtCorreo.Text = ""
    End Sub
End Class