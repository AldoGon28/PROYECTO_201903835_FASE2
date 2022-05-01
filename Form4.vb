Public Class Form4
    Private Sub Button5_Click_1(sender As Object, e As EventArgs) Handles Button5.Click
        Usr_id = ""
        Usr_Nombre = ""
        Usr_Username = ""
        Usr_Password = ""
        Usr_Tipo = ""
        Usr_Foto = ""

        Form1.Visible = True
        Me.Visible = False
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Form5.Visible = True
        Me.Visible = False
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Form6.ActualizarCanciones()
        Form6.ActualizarArtistas()

        Form6.Visible = True
        Me.Visible = False
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click

        Form7.ActualizarLista()

        Form7.Visible = True
        Me.Visible = False
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Form8.Visible = True
        Me.Visible = False
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs)
        Form9.Visible = True
        Me.Visible = False
    End Sub
End Class