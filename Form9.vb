Public Class Form9
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Form10.Visible = True
        Me.Visible = False
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click

        Form11.ActualizarCanciones()
        Form11.Visible = True
        Me.Visible = False
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Form12.Visible = True
        Me.Visible = False
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) 
        Form4.Visible = True
        Me.Visible = False
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click

        Usr_id = ""
        Usr_Nombre = ""
        Usr_Username = ""
        Usr_Password = ""
        Usr_Tipo = ""
        Usr_Foto = ""

        Form1.Visible = True
        Me.Visible = False
    End Sub
End Class