<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtKolokvij = New System.Windows.Forms.TextBox()
        Me.lblIntroPost = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.txtTest2 = New System.Windows.Forms.TextBox()
        Me.lblChapter1Test = New System.Windows.Forms.Label()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.txtSeminarskiRad = New System.Windows.Forms.TextBox()
        Me.lblChapter3Tutorial = New System.Windows.Forms.Label()
        Me.txtVjezbe = New System.Windows.Forms.TextBox()
        Me.lblChapter2Project = New System.Windows.Forms.Label()
        Me.txtPredavanje = New System.Windows.Forms.TextBox()
        Me.lblChapter2Tutorial = New System.Windows.Forms.Label()
        Me.txtAktivnost = New System.Windows.Forms.TextBox()
        Me.lblChapter2Test = New System.Windows.Forms.Label()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.txtIntegralniIspit = New System.Windows.Forms.TextBox()
        Me.lblChapter3Test = New System.Windows.Forms.Label()
        Me.GroupBox5 = New System.Windows.Forms.GroupBox()
        Me.lblProcenatOcjene = New System.Windows.Forms.Label()
        Me.lblUkupnoBodovaOstvareno = New System.Windows.Forms.Label()
        Me.lblMaksimalniBrojBodova = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.btnIzracunaj = New System.Windows.Forms.Button()
        Me.btnObrisi = New System.Windows.Forms.Button()
        Me.btnIzlaz = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        Me.GroupBox5.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.LightYellow
        Me.Label1.Font = New System.Drawing.Font("Microsoft Tai Le", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(135, 21)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(206, 30)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Predmetna ocjena"
        '
        'txtKolokvij
        '
        Me.txtKolokvij.Location = New System.Drawing.Point(104, 123)
        Me.txtKolokvij.Name = "txtKolokvij"
        Me.txtKolokvij.Size = New System.Drawing.Size(70, 20)
        Me.txtKolokvij.TabIndex = 1
        '
        'lblIntroPost
        '
        Me.lblIntroPost.AutoSize = True
        Me.lblIntroPost.Location = New System.Drawing.Point(9, 126)
        Me.lblIntroPost.Name = "lblIntroPost"
        Me.lblIntroPost.Size = New System.Drawing.Size(44, 13)
        Me.lblIntroPost.TabIndex = 0
        Me.lblIntroPost.Text = "Kolokvij"
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.Color.LightYellow
        Me.GroupBox2.Controls.Add(Me.txtTest2)
        Me.GroupBox2.Controls.Add(Me.lblChapter1Test)
        Me.GroupBox2.Location = New System.Drawing.Point(273, 84)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(166, 72)
        Me.GroupBox2.TabIndex = 2
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Bodovi osvojeni na testu 2."
        '
        'txtTest2
        '
        Me.txtTest2.Location = New System.Drawing.Point(83, 29)
        Me.txtTest2.Name = "txtTest2"
        Me.txtTest2.Size = New System.Drawing.Size(70, 20)
        Me.txtTest2.TabIndex = 1
        '
        'lblChapter1Test
        '
        Me.lblChapter1Test.AutoSize = True
        Me.lblChapter1Test.Location = New System.Drawing.Point(6, 32)
        Me.lblChapter1Test.Name = "lblChapter1Test"
        Me.lblChapter1Test.Size = New System.Drawing.Size(40, 13)
        Me.lblChapter1Test.TabIndex = 0
        Me.lblChapter1Test.Text = "Test 2."
        '
        'GroupBox3
        '
        Me.GroupBox3.BackColor = System.Drawing.Color.LightYellow
        Me.GroupBox3.Controls.Add(Me.txtSeminarskiRad)
        Me.GroupBox3.Controls.Add(Me.txtKolokvij)
        Me.GroupBox3.Controls.Add(Me.lblChapter3Tutorial)
        Me.GroupBox3.Controls.Add(Me.txtVjezbe)
        Me.GroupBox3.Controls.Add(Me.lblIntroPost)
        Me.GroupBox3.Controls.Add(Me.lblChapter2Project)
        Me.GroupBox3.Controls.Add(Me.txtPredavanje)
        Me.GroupBox3.Controls.Add(Me.lblChapter2Tutorial)
        Me.GroupBox3.Controls.Add(Me.txtAktivnost)
        Me.GroupBox3.Controls.Add(Me.lblChapter2Test)
        Me.GroupBox3.Location = New System.Drawing.Point(36, 79)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(196, 185)
        Me.GroupBox3.TabIndex = 2
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Predispitne aktivnosti"
        '
        'txtSeminarskiRad
        '
        Me.txtSeminarskiRad.Location = New System.Drawing.Point(104, 154)
        Me.txtSeminarskiRad.Name = "txtSeminarskiRad"
        Me.txtSeminarskiRad.Size = New System.Drawing.Size(70, 20)
        Me.txtSeminarskiRad.TabIndex = 3
        '
        'lblChapter3Tutorial
        '
        Me.lblChapter3Tutorial.AutoSize = True
        Me.lblChapter3Tutorial.Location = New System.Drawing.Point(9, 157)
        Me.lblChapter3Tutorial.Name = "lblChapter3Tutorial"
        Me.lblChapter3Tutorial.Size = New System.Drawing.Size(76, 13)
        Me.lblChapter3Tutorial.TabIndex = 2
        Me.lblChapter3Tutorial.Text = "Seminarski rad"
        '
        'txtVjezbe
        '
        Me.txtVjezbe.Location = New System.Drawing.Point(104, 91)
        Me.txtVjezbe.Name = "txtVjezbe"
        Me.txtVjezbe.Size = New System.Drawing.Size(70, 20)
        Me.txtVjezbe.TabIndex = 5
        '
        'lblChapter2Project
        '
        Me.lblChapter2Project.AutoSize = True
        Me.lblChapter2Project.Location = New System.Drawing.Point(9, 91)
        Me.lblChapter2Project.Name = "lblChapter2Project"
        Me.lblChapter2Project.Size = New System.Drawing.Size(39, 13)
        Me.lblChapter2Project.TabIndex = 4
        Me.lblChapter2Project.Text = "Vjezbe"
        '
        'txtPredavanje
        '
        Me.txtPredavanje.Location = New System.Drawing.Point(104, 57)
        Me.txtPredavanje.Name = "txtPredavanje"
        Me.txtPredavanje.Size = New System.Drawing.Size(70, 20)
        Me.txtPredavanje.TabIndex = 3
        '
        'lblChapter2Tutorial
        '
        Me.lblChapter2Tutorial.AutoSize = True
        Me.lblChapter2Tutorial.Location = New System.Drawing.Point(9, 60)
        Me.lblChapter2Tutorial.Name = "lblChapter2Tutorial"
        Me.lblChapter2Tutorial.Size = New System.Drawing.Size(61, 13)
        Me.lblChapter2Tutorial.TabIndex = 2
        Me.lblChapter2Tutorial.Text = "Predavanje"
        '
        'txtAktivnost
        '
        Me.txtAktivnost.Location = New System.Drawing.Point(104, 25)
        Me.txtAktivnost.Name = "txtAktivnost"
        Me.txtAktivnost.Size = New System.Drawing.Size(70, 20)
        Me.txtAktivnost.TabIndex = 1
        '
        'lblChapter2Test
        '
        Me.lblChapter2Test.AutoSize = True
        Me.lblChapter2Test.Location = New System.Drawing.Point(9, 28)
        Me.lblChapter2Test.Name = "lblChapter2Test"
        Me.lblChapter2Test.Size = New System.Drawing.Size(51, 13)
        Me.lblChapter2Test.TabIndex = 0
        Me.lblChapter2Test.Text = "Aktivnost"
        '
        'GroupBox4
        '
        Me.GroupBox4.BackColor = System.Drawing.Color.LightYellow
        Me.GroupBox4.Controls.Add(Me.txtIntegralniIspit)
        Me.GroupBox4.Controls.Add(Me.lblChapter3Test)
        Me.GroupBox4.Location = New System.Drawing.Point(273, 190)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(166, 74)
        Me.GroupBox4.TabIndex = 2
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Popravni ispit"
        '
        'txtIntegralniIspit
        '
        Me.txtIntegralniIspit.Location = New System.Drawing.Point(83, 25)
        Me.txtIntegralniIspit.Name = "txtIntegralniIspit"
        Me.txtIntegralniIspit.Size = New System.Drawing.Size(70, 20)
        Me.txtIntegralniIspit.TabIndex = 1
        '
        'lblChapter3Test
        '
        Me.lblChapter3Test.AutoSize = True
        Me.lblChapter3Test.Location = New System.Drawing.Point(6, 28)
        Me.lblChapter3Test.Name = "lblChapter3Test"
        Me.lblChapter3Test.Size = New System.Drawing.Size(71, 13)
        Me.lblChapter3Test.TabIndex = 0
        Me.lblChapter3Test.Text = "Integralni ispit"
        '
        'GroupBox5
        '
        Me.GroupBox5.BackColor = System.Drawing.Color.LightYellow
        Me.GroupBox5.Controls.Add(Me.lblProcenatOcjene)
        Me.GroupBox5.Controls.Add(Me.lblUkupnoBodovaOstvareno)
        Me.GroupBox5.Controls.Add(Me.lblMaksimalniBrojBodova)
        Me.GroupBox5.Controls.Add(Me.Label2)
        Me.GroupBox5.Controls.Add(Me.Label5)
        Me.GroupBox5.Controls.Add(Me.Label3)
        Me.GroupBox5.Location = New System.Drawing.Point(74, 300)
        Me.GroupBox5.Name = "GroupBox5"
        Me.GroupBox5.Size = New System.Drawing.Size(337, 134)
        Me.GroupBox5.TabIndex = 3
        Me.GroupBox5.TabStop = False
        Me.GroupBox5.Text = "Totals && Grade"
        '
        'lblProcenatOcjene
        '
        Me.lblProcenatOcjene.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblProcenatOcjene.Location = New System.Drawing.Point(133, 97)
        Me.lblProcenatOcjene.Name = "lblProcenatOcjene"
        Me.lblProcenatOcjene.Size = New System.Drawing.Size(100, 20)
        Me.lblProcenatOcjene.TabIndex = 1
        '
        'lblUkupnoBodovaOstvareno
        '
        Me.lblUkupnoBodovaOstvareno.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblUkupnoBodovaOstvareno.Location = New System.Drawing.Point(133, 64)
        Me.lblUkupnoBodovaOstvareno.Name = "lblUkupnoBodovaOstvareno"
        Me.lblUkupnoBodovaOstvareno.Size = New System.Drawing.Size(100, 20)
        Me.lblUkupnoBodovaOstvareno.TabIndex = 1
        '
        'lblMaksimalniBrojBodova
        '
        Me.lblMaksimalniBrojBodova.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblMaksimalniBrojBodova.Location = New System.Drawing.Point(133, 27)
        Me.lblMaksimalniBrojBodova.Name = "lblMaksimalniBrojBodova"
        Me.lblMaksimalniBrojBodova.Size = New System.Drawing.Size(100, 20)
        Me.lblMaksimalniBrojBodova.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(35, 100)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(85, 13)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Procenat ocjene"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(35, 64)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(87, 13)
        Me.Label5.TabIndex = 0
        Me.Label5.Text = "Ostvareni bodovi"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(35, 28)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(84, 13)
        Me.Label3.TabIndex = 0
        Me.Label3.Text = "Ukupno bodova"
        '
        'btnIzracunaj
        '
        Me.btnIzracunaj.AllowDrop = True
        Me.btnIzracunaj.Location = New System.Drawing.Point(74, 486)
        Me.btnIzracunaj.Name = "btnIzracunaj"
        Me.btnIzracunaj.Size = New System.Drawing.Size(75, 23)
        Me.btnIzracunaj.TabIndex = 4
        Me.btnIzracunaj.Text = "Izračunaj"
        Me.btnIzracunaj.UseVisualStyleBackColor = True
        '
        'btnObrisi
        '
        Me.btnObrisi.Location = New System.Drawing.Point(207, 486)
        Me.btnObrisi.Name = "btnObrisi"
        Me.btnObrisi.Size = New System.Drawing.Size(75, 23)
        Me.btnObrisi.TabIndex = 5
        Me.btnObrisi.Text = "Obriši"
        Me.btnObrisi.UseVisualStyleBackColor = True
        '
        'btnIzlaz
        '
        Me.btnIzlaz.Location = New System.Drawing.Point(336, 486)
        Me.btnIzlaz.Name = "btnIzlaz"
        Me.btnIzlaz.Size = New System.Drawing.Size(75, 23)
        Me.btnIzlaz.TabIndex = 6
        Me.btnIzlaz.Text = "Izlaz"
        Me.btnIzlaz.UseVisualStyleBackColor = True
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.Prosjek.My.Resources.Resources.PredmetnaOcjena
        Me.PictureBox1.Location = New System.Drawing.Point(0, -12)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(490, 599)
        Me.PictureBox1.TabIndex = 7
        Me.PictureBox1.TabStop = False
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(485, 586)
        Me.Controls.Add(Me.btnIzlaz)
        Me.Controls.Add(Me.btnObrisi)
        Me.Controls.Add(Me.btnIzracunaj)
        Me.Controls.Add(Me.GroupBox5)
        Me.Controls.Add(Me.GroupBox4)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.PictureBox1)
        Me.Name = "Form1"
        Me.Text = "Predmetna ocjena"
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        Me.GroupBox5.ResumeLayout(False)
        Me.GroupBox5.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtKolokvij As System.Windows.Forms.TextBox
    Friend WithEvents lblIntroPost As System.Windows.Forms.Label
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents txtTest2 As System.Windows.Forms.TextBox
    Friend WithEvents lblChapter1Test As System.Windows.Forms.Label
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents txtVjezbe As System.Windows.Forms.TextBox
    Friend WithEvents lblChapter2Project As System.Windows.Forms.Label
    Friend WithEvents txtPredavanje As System.Windows.Forms.TextBox
    Friend WithEvents lblChapter2Tutorial As System.Windows.Forms.Label
    Friend WithEvents txtAktivnost As System.Windows.Forms.TextBox
    Friend WithEvents lblChapter2Test As System.Windows.Forms.Label
    Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
    Friend WithEvents txtSeminarskiRad As System.Windows.Forms.TextBox
    Friend WithEvents lblChapter3Tutorial As System.Windows.Forms.Label
    Friend WithEvents txtIntegralniIspit As System.Windows.Forms.TextBox
    Friend WithEvents lblChapter3Test As System.Windows.Forms.Label
    Friend WithEvents GroupBox5 As System.Windows.Forms.GroupBox
    Friend WithEvents lblMaksimalniBrojBodova As System.Windows.Forms.Label
    Friend WithEvents lblUkupnoBodovaOstvareno As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents lblProcenatOcjene As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents btnIzracunaj As System.Windows.Forms.Button
    Friend WithEvents btnObrisi As System.Windows.Forms.Button
    Friend WithEvents btnIzlaz As System.Windows.Forms.Button
    Friend WithEvents PictureBox1 As PictureBox
End Class
