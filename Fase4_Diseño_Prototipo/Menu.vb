﻿Imports System.IO



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
        PnlQuiz.Visible = False
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
        PnlQuiz.Location = New Point(186, 67)

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
        PnlQuiz.Location = New Point(130, 67)
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
        lBrowser.Navigate("https://youtu.be/PGIFXHmw_js")


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
        AxAcroPDF1.src = dato
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


    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick

        Dim seg = --1
        Dim min As Integer
        Dim Minutos = min.ToString("00")
        Dim Segundo = seg.ToString("00")
        lblFecha.Text = DateTime.Now.ToLongDateString()

        If lblDatoFecha.Text = "00:00" Then

            If PnlQuiz.Visible = True Then


                Timer1.Stop()

                min = 2
                seg = 59

            End If

        End If


        lblDatoFecha.Text = Minutos + ":" + Segundo

    End Sub

    Private Sub btnTerminar_Click(sender As Object, e As EventArgs) Handles btnTerminar.Click
        Dim preg1, preg2, preg3, preg4, Notax, preg5 As Integer

        Notax = NotaQuiz()
        preg1 = PreguntaUno()
        preg2 = PreguntaDos()
        preg3 = PreguntaTres()
        preg4 = PreguntaCuatro()
        preg5 = PreguntaQuinta()

        If Notax < 5 Then
            If preg2 = 0 Then
                pnlPreg2.BackColor = Color.Red
            End If

            If preg3 = 0 Then
                pnlPreg3.BackColor = Color.Red
            End If

            If preg4 = 0 Then
                pnlPreg4.BackColor = Color.Red
            End If

            If preg5 = 0 Then
                pnlPreg5.BackColor = Color.Red
            End If

            If preg1 = 0 Then
                pnlPreg1.BackColor = Color.Red
            End If
            Notax = 0
        End If

        If (preg1 = 0 Or preg2 = 0 Or preg3 = 0 Or preg4 = 0 Or preg5 = 0) Then

            MsgBox("Deve diligernciar todos los Campos")

        Else
            NotaFinal()
            LimpiarCampos()
        End If

    End Sub
    Sub LimpiarCampos()

        RdbRta1_1.Checked = False
        RdbRta1_2.Checked = False
        RdbRta1_3.Checked = False
        RdbRta2_1.Checked = False
        RdbRta2_2.Checked = False
        RdbRta2_3.Checked = False
        RdbRta3_1.Checked = False
        RdbRta3_2.Checked = False
        RdbRta3_3.Checked = False
        RdbRta3_4.Checked = False
        RdbRta4_1.Checked = False
        RdbRta4_2.Checked = False
        RdbRta4_3.Checked = False
        RdbRta4_4.Checked = False
        RdbRta5_1.Checked = False
        RdbRta5_2.Checked = False
        RdbRta5_3.Checked = False

    End Sub
    Private Sub NotaFinal()
        Dim Notaxf As Integer
        Notaxf = 0
        Notaxf = NotaQuiz()

        If (Notaxf = 5) Then
            Timer1.Stop()
            MsgBox("Exelecnte... Aprobo el Quiz")

        Else

            Timer1.Stop()
            MsgBox("No aprobo el Quiz, vuelva a intentarlo")
            PnlQuiz.Visible = False


        End If

    End Sub

    Private Function NotaQuiz() As Integer
        Dim Nota = 0

        If RdbRta1_1.Checked = True Then
            Nota += 1
        End If

        If RdbRta1_1.Checked = True Then
            Nota += 1
        End If


        If RdbRta1_1.Checked = True Then
            Nota += 1
        End If


        If RdbRta1_1.Checked = True Then
            Nota += 1
        End If

        Return Nota

    End Function


    Private Function PreguntaUno() As Integer

        Dim Nota1 = 0
        If RdbRta1_1.Checked = True Then
            Nota1 += 1
        End If
        If RdbRta1_2.Checked = True Then
            Nota1 += 1
        End If
        If RdbRta1_3.Checked = True Then
            Nota1 += 1
        End If

        Return Nota1

    End Function

    Private Function PreguntaDos() As Integer

        Dim Nota1 = 0
        If RdbRta1_1.Checked = True Then
            Nota1 += 1
        End If
        If RdbRta1_2.Checked = True Then
            Nota1 += 1
        End If
        If RdbRta1_3.Checked = True Then
            Nota1 += 1
        End If

        Return Nota1

    End Function

    Private Function PreguntaTres() As Integer

        Dim Nota1 = 0
        If RdbRta3_1.Checked = True Then
            Nota1 += 1
        End If
        If RdbRta3_2.Checked = True Then
            Nota1 += 1
        End If
        If RdbRta3_3.Checked = True Then
            Nota1 += 1
        End If

        If RdbRta3_4.Checked = True Then
            Nota1 += 1
        End If

        Return Nota1

    End Function

    Private Function PreguntaCuatro() As Integer

        Dim Nota1 = 0
        If RdbRta4_1.Checked = True Then
            Nota1 += 1
        End If
        If RdbRta4_2.Checked = True Then
            Nota1 += 1
        End If
        If RdbRta4_3.Checked = True Then
            Nota1 += 1
        End If
        If RdbRta4_4.Checked = True Then
            Nota1 += 1
        End If
        Return Nota1

    End Function

    Private Function PreguntaQuinta() As Integer

        Dim Nota1 = 0
        If RdbRta5_1.Checked = True Then
            Nota1 += 1
        End If
        If RdbRta5_2.Checked = True Then
            Nota1 += 1
        End If
        If RdbRta5_3.Checked = True Then
            Nota1 += 1
        End If

        Return Nota1

    End Function

    Private Sub Panel3_Paint(sender As Object, e As PaintEventArgs) Handles PnlQuiz.Paint
        lblDatoFecha.Text = "03:00"
    End Sub

    Private Sub Menu_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        Timer1.Stop()
    End Sub

    Private Sub btnEvaTema2_Click(sender As Object, e As EventArgs) Handles btnEvaTema2.Click
        PnlAudio.Visible = False
        PnlPdf.Visible = False
        PnlVidos.Visible = False
        Timer1.Start()
        PnlQuiz.Visible = True

    End Sub
End Class