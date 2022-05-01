Imports System.Data.SqlClient

Public Class FormRegistro

    Dim rutaFoto As String = ""

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        Dim nuevoUsr_Nombre As String = txtNomCompleto.Text
        Dim nuevoUsr_usarname As String = txtUsername.Text
        Dim nuevoUsr_pass1 As String = txtPass1.Text
        Dim nuevoUsr_pass2 As String = txtPass2.Text

        If (Not (nuevoUsr_Nombre = "") And Not (nuevoUsr_usarname = "") And Not (nuevoUsr_pass1 = "") And Not (nuevoUsr_pass2 = "")) Then

            If (nuevoUsr_pass1 = nuevoUsr_pass2) Then
                'MsgBox("Contraseñas Iguales")

                If (LongitudPassword(nuevoUsr_pass1) And ContieneNumero(nuevoUsr_pass1) And ContieneMayus(nuevoUsr_pass1) And ContieneSimbolos(nuevoUsr_pass1)) Then
                    MsgBox("Contraseña aceptada")

                    If Not (rutaFoto = "") Then
                        'Aqui en donde se registra  el Usuario
                        MsgBox("Datos aceptados")

                        Conexion.Open()
                        Try
                            Dim Consulta As String = "INSERT INTO usuario(nombre,username,password,tipo,foto) VALUES ('" + nuevoUsr_Nombre + "','" + nuevoUsr_usarname + "', '" + nuevoUsr_pass1 + "','Administrador','" + rutaFoto + "')"
                            Dim comando As SqlCommand
                            comando = New SqlCommand(Consulta, Conexion)
                            comando.ExecuteNonQuery()
                            MessageBox.Show("Los datos se guardaron Correctamente")

                        Catch ex As Exception

                        End Try
                        Conexion.Close()

                        Form1.Visible = True
                        Me.Visible = False

                    Else
                        MsgBox("Seleccione Una foto")
                    End If
                Else
                    MsgBox("Debe Contener al menos, 8 dígitos,1 Número, Una letra Mayúscula y al menos uno de los siguientes simbolos (@,%,#,!,*)")
                End If
            Else
                MsgBox("Las Contraseñas deben ser Iguales")
            End If

        Else
            MsgBox("INGRESE TODOS LOS CAMPOS")
        End If

        If (LongitudPassword(nuevoUsr_pass1) And ContieneNumero(nuevoUsr_pass1) And ContieneMayus(nuevoUsr_pass1) And ContieneSimbolos(nuevoUsr_pass1)) Then
            MsgBox("Contraseña aceptada")
        Else
            MsgBox("Debe Contener al menos, 8 dígitos,1 Número, Una letra Mayúscula y al menos uno de los siguientes simbolos (@,%,#,!,*)")
        End If





    End Sub

    Private Sub txtFoto_Click(sender As Object, e As EventArgs) Handles txtFoto.Click
        OpenFileDialog1.ShowDialog()
        rutaFoto = OpenFileDialog1.FileName()
        If Not (rutaFoto = "") Then

            lbRuta.Text = rutaFoto
        End If
    End Sub

    Private Sub btnRegresar_Click(sender As Object, e As EventArgs) Handles btnRegresar.Click
        Form1.Visible = True
        Me.Visible = False
    End Sub

    Function LongitudPassword(texto As String) As Boolean
        Dim resultado As Boolean = False
        If (texto.Length >= 8) Then
            resultado = True
        End If
        Return resultado
    End Function

    Function ContieneNumero(Texto As String) As Boolean
        Dim resultado As Boolean = False
        If (Texto.Contains("0") Or Texto.Contains("1") Or Texto.Contains("2") Or Texto.Contains("3") Or Texto.Contains("4") Or Texto.Contains("5") Or Texto.Contains("6") Or Texto.Contains("7") Or Texto.Contains("8") Or Texto.Contains("9")) Then
            resultado = True
        End If
        Return resultado

    End Function

    Function ContieneMayus(Texto As String) As Boolean
        Dim resultado As Boolean = False
        If (Texto.Contains("A") Or Texto.Contains("E") Or Texto.Contains("I") Or Texto.Contains("O") Or Texto.Contains("U")) Then
            resultado = True
        End If
        Return resultado
    End Function

    Function ContieneSimbolos(Texto As String) As Boolean
        Dim resultado As Boolean = False
        If (Texto.Contains("@") Or Texto.Contains("*") Or Texto.Contains("#") Or Texto.Contains("%") Or Texto.Contains("!")) Then
            resultado = True
        End If
        Return resultado
    End Function


End Class