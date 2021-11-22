Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click
        If (TxtUser.Text = "Admin" And TxtClave.Text = "123") Then
            Dim Vtn As New Menu
            Vtn.Show()
            Call BorrarCampo()
            Me.WindowState = FormWindowState.Minimized
        Else
            MsgBox("Usuario es Admin, la Clave es 123")
            BorrarCampo()

        End If

    End Sub

    Private Sub BorrarCampo()
        TxtUser.Text = ""
        TxtClave.Text = ""
        TxtUser.Focus()
    End Sub

End Class
