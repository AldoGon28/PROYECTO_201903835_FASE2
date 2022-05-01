<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.BtRegistrar = New System.Windows.Forms.Button()
        Me.BtLogin = New System.Windows.Forms.Button()
        Me.txtUsername = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.BackgroundWorker1 = New System.ComponentModel.BackgroundWorker()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.LbConexion = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Gold
        Me.Label3.Font = New System.Drawing.Font("MS PGothic", 10.0!, System.Drawing.FontStyle.Bold)
        Me.Label3.Location = New System.Drawing.Point(275, 184)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(73, 14)
        Me.Label3.TabIndex = 30
        Me.Label3.Text = "Username"
        '
        'BtRegistrar
        '
        Me.BtRegistrar.BackColor = System.Drawing.Color.Gold
        Me.BtRegistrar.Enabled = False
        Me.BtRegistrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtRegistrar.Font = New System.Drawing.Font("MS PGothic", 15.0!, System.Drawing.FontStyle.Bold)
        Me.BtRegistrar.ForeColor = System.Drawing.SystemColors.WindowText
        Me.BtRegistrar.Location = New System.Drawing.Point(341, 299)
        Me.BtRegistrar.Name = "BtRegistrar"
        Me.BtRegistrar.Size = New System.Drawing.Size(149, 56)
        Me.BtRegistrar.TabIndex = 29
        Me.BtRegistrar.Text = "Registrarse"
        Me.BtRegistrar.UseVisualStyleBackColor = False
        '
        'BtLogin
        '
        Me.BtLogin.BackColor = System.Drawing.Color.Gold
        Me.BtLogin.Enabled = False
        Me.BtLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtLogin.Font = New System.Drawing.Font("MS PGothic", 15.0!, System.Drawing.FontStyle.Bold)
        Me.BtLogin.ForeColor = System.Drawing.SystemColors.WindowText
        Me.BtLogin.Location = New System.Drawing.Point(341, 237)
        Me.BtLogin.Name = "BtLogin"
        Me.BtLogin.Size = New System.Drawing.Size(149, 56)
        Me.BtLogin.TabIndex = 28
        Me.BtLogin.Text = "Iniciar Sesión"
        Me.BtLogin.UseVisualStyleBackColor = False
        '
        'txtUsername
        '
        Me.txtUsername.Font = New System.Drawing.Font("MS PGothic", 15.0!, System.Drawing.FontStyle.Bold)
        Me.txtUsername.Location = New System.Drawing.Point(278, 154)
        Me.txtUsername.Name = "txtUsername"
        Me.txtUsername.Size = New System.Drawing.Size(279, 27)
        Me.txtUsername.TabIndex = 27
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Gold
        Me.Label1.Font = New System.Drawing.Font("MS PGothic", 36.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(255, 75)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(302, 48)
        Me.Label1.TabIndex = 26
        Me.Label1.Text = "Iniciar Sesión"
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = Global.PROYECTO_201903835.My.Resources.Resources.nota2
        Me.PictureBox2.Location = New System.Drawing.Point(146, 237)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(147, 122)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox2.TabIndex = 25
        Me.PictureBox2.TabStop = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.PROYECTO_201903835.My.Resources.Resources.Usuario
        Me.PictureBox1.Location = New System.Drawing.Point(459, 109)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(244, 279)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 24
        Me.PictureBox1.TabStop = False
        '
        'Button3
        '
        Me.Button3.BackColor = System.Drawing.Color.Crimson
        Me.Button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button3.Font = New System.Drawing.Font("MS PGothic", 15.0!, System.Drawing.FontStyle.Bold)
        Me.Button3.ForeColor = System.Drawing.SystemColors.Menu
        Me.Button3.Location = New System.Drawing.Point(12, 27)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(129, 31)
        Me.Button3.TabIndex = 31
        Me.Button3.Text = "Conexión"
        Me.Button3.UseVisualStyleBackColor = False
        '
        'LbConexion
        '
        Me.LbConexion.AutoSize = True
        Me.LbConexion.BackColor = System.Drawing.Color.SeaGreen
        Me.LbConexion.Font = New System.Drawing.Font("MS PGothic", 20.0!, System.Drawing.FontStyle.Bold)
        Me.LbConexion.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.LbConexion.Location = New System.Drawing.Point(12, 415)
        Me.LbConexion.Name = "LbConexion"
        Me.LbConexion.Size = New System.Drawing.Size(126, 27)
        Me.LbConexion.TabIndex = 32
        Me.LbConexion.Text = "Conexión"
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.Crimson
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Font = New System.Drawing.Font("MS PGothic", 15.0!, System.Drawing.FontStyle.Bold)
        Me.Button1.ForeColor = System.Drawing.SystemColors.Menu
        Me.Button1.Location = New System.Drawing.Point(712, 423)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(129, 31)
        Me.Button1.TabIndex = 33
        Me.Button1.Text = "Cerrar"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.ClientSize = New System.Drawing.Size(853, 466)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.LbConexion)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.BtRegistrar)
        Me.Controls.Add(Me.BtLogin)
        Me.Controls.Add(Me.txtUsername)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.PictureBox1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label3 As Label
    Friend WithEvents BtRegistrar As Button
    Friend WithEvents BtLogin As Button
    Friend WithEvents txtUsername As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents BackgroundWorker1 As System.ComponentModel.BackgroundWorker
    Friend WithEvents Button3 As Button
    Friend WithEvents LbConexion As Label
    Friend WithEvents Button1 As Button
End Class
