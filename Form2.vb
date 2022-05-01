Public Class Form2
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        Dim PassworIngresada = txtPass.Text
        If (PassworIngresada = Usr_Password) Then
            MsgBox("Login Exitoso")

            If (Usr_Tipo = "Administrador") Then
                Form4.Visible = True
                Me.Visible = False
            Else
                Form9.Visible = True
                Me.Visible = False
            End If
        Else
            MsgBox("Contraseña Incorrecta")
        End If


    End Sub


    Private Sub Button2_Click_1(sender As Object, e As EventArgs) Handles Button2.Click

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