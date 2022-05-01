<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form6
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.txtNombre = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.listaArtistas = New System.Windows.Forms.ComboBox()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.listaCanciones = New System.Windows.Forms.ListBox()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.lbRuta = New System.Windows.Forms.Label()
        Me.Género = New System.Windows.Forms.Label()
        Me.txtGenero = New System.Windows.Forms.TextBox()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Gold
        Me.Label1.Font = New System.Drawing.Font("MS PGothic", 36.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(173, 37)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(455, 48)
        Me.Label1.TabIndex = 63
        Me.Label1.Text = "Gestionar Canciones"
        '
        'Button1
        '
        Me.Button1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.Button1.BackColor = System.Drawing.Color.Crimson
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Button1.Location = New System.Drawing.Point(637, 648)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(148, 46)
        Me.Button1.TabIndex = 65
        Me.Button1.Text = "Menpu de administrador"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'txtNombre
        '
        Me.txtNombre.Font = New System.Drawing.Font("MS PGothic", 18.0!, System.Drawing.FontStyle.Bold)
        Me.txtNombre.Location = New System.Drawing.Point(216, 112)
        Me.txtNombre.Name = "txtNombre"
        Me.txtNombre.Size = New System.Drawing.Size(341, 31)
        Me.txtNombre.TabIndex = 66
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Gold
        Me.Label2.Font = New System.Drawing.Font("MS PGothic", 10.0!, System.Drawing.FontStyle.Bold)
        Me.Label2.Location = New System.Drawing.Point(213, 95)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(58, 14)
        Me.Label2.TabIndex = 68
        Me.Label2.Text = "Nombre"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Gold
        Me.Label3.Font = New System.Drawing.Font("MS PGothic", 10.0!, System.Drawing.FontStyle.Bold)
        Me.Label3.Location = New System.Drawing.Point(216, 198)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(54, 14)
        Me.Label3.TabIndex = 69
        Me.Label3.Text = "Artista"
        '
        'Button2
        '
        Me.Button2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.Button2.BackColor = System.Drawing.Color.SeaGreen
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button2.Font = New System.Drawing.Font("MS PGothic", 18.0!, System.Drawing.FontStyle.Bold)
        Me.Button2.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Button2.Location = New System.Drawing.Point(336, 312)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(111, 40)
        Me.Button2.TabIndex = 70
        Me.Button2.Text = "Agregar"
        Me.Button2.UseVisualStyleBackColor = False
        '
        'Button3
        '
        Me.Button3.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.Button3.BackColor = System.Drawing.Color.Crimson
        Me.Button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button3.Font = New System.Drawing.Font("MS PGothic", 18.0!, System.Drawing.FontStyle.Bold)
        Me.Button3.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Button3.Location = New System.Drawing.Point(446, 589)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(111, 40)
        Me.Button3.TabIndex = 73
        Me.Button3.Text = "Eliminar"
        Me.Button3.UseVisualStyleBackColor = False
        '
        'listaArtistas
        '
        Me.listaArtistas.Font = New System.Drawing.Font("MS PGothic", 18.0!, System.Drawing.FontStyle.Bold)
        Me.listaArtistas.FormattingEnabled = True
        Me.listaArtistas.Location = New System.Drawing.Point(219, 215)
        Me.listaArtistas.Name = "listaArtistas"
        Me.listaArtistas.Size = New System.Drawing.Size(341, 32)
        Me.listaArtistas.TabIndex = 74
        '
        'Button4
        '
        Me.Button4.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.Button4.BackColor = System.Drawing.Color.LightSlateGray
        Me.Button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button4.Font = New System.Drawing.Font("MS PGothic", 13.0!, System.Drawing.FontStyle.Bold)
        Me.Button4.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Button4.Location = New System.Drawing.Point(216, 266)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(111, 40)
        Me.Button4.TabIndex = 76
        Me.Button4.Text = "Examinar"
        Me.Button4.UseVisualStyleBackColor = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.PROYECTO_201903835.My.Resources.Resources.Disco
        Me.PictureBox1.Location = New System.Drawing.Point(-53, 485)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(321, 300)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 77
        Me.PictureBox1.TabStop = False
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Gold
        Me.Label4.Font = New System.Drawing.Font("MS PGothic", 10.0!, System.Drawing.FontStyle.Bold)
        Me.Label4.Location = New System.Drawing.Point(219, 586)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(136, 14)
        Me.Label4.TabIndex = 78
        Me.Label4.Text = "Lista de Canciones"
        '
        'listaCanciones
        '
        Me.listaCanciones.FormattingEnabled = True
        Me.listaCanciones.Location = New System.Drawing.Point(219, 358)
        Me.listaCanciones.Name = "listaCanciones"
        Me.listaCanciones.Size = New System.Drawing.Size(338, 225)
        Me.listaCanciones.TabIndex = 79
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'lbRuta
        '
        Me.lbRuta.AutoSize = True
        Me.lbRuta.BackColor = System.Drawing.Color.LightSlateGray
        Me.lbRuta.Font = New System.Drawing.Font("MS PGothic", 10.0!, System.Drawing.FontStyle.Bold)
        Me.lbRuta.Location = New System.Drawing.Point(333, 292)
        Me.lbRuta.Name = "lbRuta"
        Me.lbRuta.Size = New System.Drawing.Size(51, 14)
        Me.lbRuta.TabIndex = 80
        Me.lbRuta.Text = "Ruta..."
        '
        'Género
        '
        Me.Género.AutoSize = True
        Me.Género.BackColor = System.Drawing.Color.Gold
        Me.Género.Font = New System.Drawing.Font("MS PGothic", 10.0!, System.Drawing.FontStyle.Bold)
        Me.Género.Location = New System.Drawing.Point(213, 147)
        Me.Género.Name = "Género"
        Me.Género.Size = New System.Drawing.Size(56, 14)
        Me.Género.TabIndex = 82
        Me.Género.Text = "Género"
        '
        'txtGenero
        '
        Me.txtGenero.Font = New System.Drawing.Font("MS PGothic", 18.0!, System.Drawing.FontStyle.Bold)
        Me.txtGenero.Location = New System.Drawing.Point(216, 164)
        Me.txtGenero.Name = "txtGenero"
        Me.txtGenero.Size = New System.Drawing.Size(341, 31)
        Me.txtGenero.TabIndex = 81
        '
        'Form6
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.ClientSize = New System.Drawing.Size(800, 706)
        Me.Controls.Add(Me.Género)
        Me.Controls.Add(Me.txtGenero)
        Me.Controls.Add(Me.lbRuta)
        Me.Controls.Add(Me.listaCanciones)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.listaArtistas)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtNombre)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form6"
        Me.Text = "2"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents txtNombre As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Button2 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents listaArtistas As ComboBox
    Friend WithEvents Button4 As Button
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label4 As Label
    Friend WithEvents listaCanciones As ListBox
    Friend WithEvents OpenFileDialog1 As OpenFileDialog
    Friend WithEvents lbRuta As Label
    Friend WithEvents Género As Label
    Friend WithEvents txtGenero As TextBox
End Class
