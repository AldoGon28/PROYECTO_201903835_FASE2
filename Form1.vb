Imports System.Data.SqlClient
Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles BtLogin.Click

        Dim MiCmd As SqlCommand
        Dim MiLector As SqlDataReader
        Dim nombreUsuario As String = txtUsername.Text


        Try
            MiCmd = Conexion.CreateCommand
            Dim Consulta As String = "SELECT * FROM usuario WHERE username= '" + nombreUsuario + "'"
            MiCmd.CommandText = Consulta


            Conexion.Open()
            MiLector = MiCmd.ExecuteReader()

            Do While MiLector.Read()

                Usr_id = MiLector.GetInt32(0).ToString
                Usr_Nombre = MiLector.GetString(1)
                Usr_Username = MiLector.GetString(2)
                Usr_Password = MiLector.GetString(3)
                Usr_Tipo = MiLector.GetString(4)
                Usr_Foto = MiLector.GetString(5)
            Loop

            'Console.WriteLine(txtUsername)
            If Not (Usr_Username = "") Then
                'MsgBox("Bienvenido" + Usr_Username)

                Form2.PictureBox3.Image = Image.FromFile(Usr_Foto)
                Form2.LbUsername.Text = Usr_Username

                Form2.Visible = True
                Me.Visible = False

            Else
                MsgBox("Usuario No Encontrado")
            End If

            Conexion.Close()
        Catch ex As Exception

        End Try

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles BtRegistrar.Click
        FormRegistro.Visible = True
        Me.Visible = False
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Try
            'Codigo que queremos ejecutar
            Conexion.Open()
            MsgBox("Conexión con la DataBase Exitosa")
            BtLogin.Enabled = True
            BtRegistrar.Enabled = True
            LbConexion.Text = "Conectado a la DB"
            Conexion.Close()
        Catch ex As Exception
            'Codigo que se ejecuta si falla
            MsgBox("Error al conectar con la DataBase")
        End Try
    End Sub

    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles Button1.Click
        If (MsgBox("¿DESEA SALIR?", vbQuestion + vbYesNo, "MENSAJE DE SALIDA") = vbYes) Then
            Me.Close()
            End
        End If
    End Sub
End Class
