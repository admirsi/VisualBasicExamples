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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.chkFilterZraka = New System.Windows.Forms.CheckBox()
        Me.chkFIlterKlime = New System.Windows.Forms.CheckBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.chkUljeMjenjaca = New System.Windows.Forms.CheckBox()
        Me.chkMotornoUlje = New System.Windows.Forms.CheckBox()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.chkGeometrijaTockova = New System.Windows.Forms.CheckBox()
        Me.chkIzmjenaKocnica = New System.Windows.Forms.CheckBox()
        Me.chkPregledVozila = New System.Windows.Forms.CheckBox()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.txtRadniciSati = New System.Windows.Forms.TextBox()
        Me.txtDijeloviCijena = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox5 = New System.Windows.Forms.GroupBox()
        Me.lblZaPlatiti = New System.Windows.Forms.Label()
        Me.lblPDVZaDijelove = New System.Windows.Forms.Label()
        Me.lblDijelovi = New System.Windows.Forms.Label()
        Me.lblServisiIRadnici = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.btnIzracunaj = New System.Windows.Forms.Button()
        Me.btnOcisti = New System.Windows.Forms.Button()
        Me.btnIzlaz = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        Me.GroupBox5.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.Wheat
        Me.GroupBox1.Controls.Add(Me.Label12)
        Me.GroupBox1.Controls.Add(Me.Label11)
        Me.GroupBox1.Controls.Add(Me.chkFilterZraka)
        Me.GroupBox1.Controls.Add(Me.chkFIlterKlime)
        Me.GroupBox1.Location = New System.Drawing.Point(117, 149)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(235, 73)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Zamjena filtera"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(142, 43)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(59, 13)
        Me.Label12.TabIndex = 3
        Me.Label12.Text = "(18.00 KM)"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(143, 20)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(59, 13)
        Me.Label11.TabIndex = 2
        Me.Label11.Text = "(26.00 KM)"
        '
        'chkFilterZraka
        '
        Me.chkFilterZraka.AutoSize = True
        Me.chkFilterZraka.Location = New System.Drawing.Point(21, 42)
        Me.chkFilterZraka.Name = "chkFilterZraka"
        Me.chkFilterZraka.Size = New System.Drawing.Size(78, 17)
        Me.chkFilterZraka.TabIndex = 1
        Me.chkFilterZraka.Text = "FIlter zraka"
        Me.chkFilterZraka.UseVisualStyleBackColor = True
        '
        'chkFIlterKlime
        '
        Me.chkFIlterKlime.AutoSize = True
        Me.chkFIlterKlime.Location = New System.Drawing.Point(21, 19)
        Me.chkFIlterKlime.Name = "chkFIlterKlime"
        Me.chkFIlterKlime.Size = New System.Drawing.Size(75, 17)
        Me.chkFIlterKlime.TabIndex = 0
        Me.chkFIlterKlime.Text = "Filter klime"
        Me.chkFIlterKlime.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.Color.Moccasin
        Me.GroupBox2.Controls.Add(Me.Label14)
        Me.GroupBox2.Controls.Add(Me.Label13)
        Me.GroupBox2.Controls.Add(Me.chkUljeMjenjaca)
        Me.GroupBox2.Controls.Add(Me.chkMotornoUlje)
        Me.GroupBox2.Location = New System.Drawing.Point(28, 44)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(226, 73)
        Me.GroupBox2.TabIndex = 0
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Izmjena ulja"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(144, 20)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(59, 13)
        Me.Label14.TabIndex = 3
        Me.Label14.Text = "(30.00 KM)"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(144, 42)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(59, 13)
        Me.Label13.TabIndex = 2
        Me.Label13.Text = "(80.00 KM)"
        '
        'chkUljeMjenjaca
        '
        Me.chkUljeMjenjaca.AutoSize = True
        Me.chkUljeMjenjaca.Location = New System.Drawing.Point(21, 42)
        Me.chkUljeMjenjaca.Name = "chkUljeMjenjaca"
        Me.chkUljeMjenjaca.Size = New System.Drawing.Size(89, 17)
        Me.chkUljeMjenjaca.TabIndex = 1
        Me.chkUljeMjenjaca.Text = "Ulje mjenjača"
        Me.chkUljeMjenjaca.UseVisualStyleBackColor = True
        '
        'chkMotornoUlje
        '
        Me.chkMotornoUlje.AutoSize = True
        Me.chkMotornoUlje.Location = New System.Drawing.Point(21, 19)
        Me.chkMotornoUlje.Name = "chkMotornoUlje"
        Me.chkMotornoUlje.Size = New System.Drawing.Size(84, 17)
        Me.chkMotornoUlje.TabIndex = 0
        Me.chkMotornoUlje.Text = "Motorno ulje"
        Me.chkMotornoUlje.UseVisualStyleBackColor = True
        '
        'GroupBox3
        '
        Me.GroupBox3.BackColor = System.Drawing.Color.Khaki
        Me.GroupBox3.Controls.Add(Me.Label17)
        Me.GroupBox3.Controls.Add(Me.Label16)
        Me.GroupBox3.Controls.Add(Me.Label15)
        Me.GroupBox3.Controls.Add(Me.chkGeometrijaTockova)
        Me.GroupBox3.Controls.Add(Me.chkIzmjenaKocnica)
        Me.GroupBox3.Controls.Add(Me.chkPregledVozila)
        Me.GroupBox3.Location = New System.Drawing.Point(28, 245)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(226, 97)
        Me.GroupBox3.TabIndex = 1
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Ostale usluge"
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Location = New System.Drawing.Point(144, 66)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(59, 13)
        Me.Label17.TabIndex = 5
        Me.Label17.Text = "(20.00 KM)"
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Location = New System.Drawing.Point(144, 43)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(65, 13)
        Me.Label16.TabIndex = 4
        Me.Label16.Text = "(100.00 KM)"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(144, 20)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(59, 13)
        Me.Label15.TabIndex = 3
        Me.Label15.Text = "(15.00 KM)"
        '
        'chkGeometrijaTockova
        '
        Me.chkGeometrijaTockova.AutoSize = True
        Me.chkGeometrijaTockova.Location = New System.Drawing.Point(21, 65)
        Me.chkGeometrijaTockova.Name = "chkGeometrijaTockova"
        Me.chkGeometrijaTockova.Size = New System.Drawing.Size(118, 17)
        Me.chkGeometrijaTockova.TabIndex = 2
        Me.chkGeometrijaTockova.Text = "Geometrija točkova"
        Me.chkGeometrijaTockova.UseVisualStyleBackColor = True
        '
        'chkIzmjenaKocnica
        '
        Me.chkIzmjenaKocnica.AutoSize = True
        Me.chkIzmjenaKocnica.Location = New System.Drawing.Point(21, 42)
        Me.chkIzmjenaKocnica.Name = "chkIzmjenaKocnica"
        Me.chkIzmjenaKocnica.Size = New System.Drawing.Size(103, 17)
        Me.chkIzmjenaKocnica.TabIndex = 1
        Me.chkIzmjenaKocnica.Text = "Izmjena kočnica"
        Me.chkIzmjenaKocnica.UseVisualStyleBackColor = True
        '
        'chkPregledVozila
        '
        Me.chkPregledVozila.AutoSize = True
        Me.chkPregledVozila.Location = New System.Drawing.Point(21, 19)
        Me.chkPregledVozila.Name = "chkPregledVozila"
        Me.chkPregledVozila.Size = New System.Drawing.Size(93, 17)
        Me.chkPregledVozila.TabIndex = 0
        Me.chkPregledVozila.Text = "Pregled Vozila"
        Me.chkPregledVozila.UseVisualStyleBackColor = True
        '
        'GroupBox4
        '
        Me.GroupBox4.BackColor = System.Drawing.Color.PeachPuff
        Me.GroupBox4.Controls.Add(Me.Label18)
        Me.GroupBox4.Controls.Add(Me.txtRadniciSati)
        Me.GroupBox4.Controls.Add(Me.txtDijeloviCijena)
        Me.GroupBox4.Controls.Add(Me.Label2)
        Me.GroupBox4.Controls.Add(Me.Label1)
        Me.GroupBox4.Location = New System.Drawing.Point(117, 370)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(235, 97)
        Me.GroupBox4.TabIndex = 2
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Dijelovi i radnici"
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Location = New System.Drawing.Point(133, 57)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(97, 13)
        Me.Label18.TabIndex = 4
        Me.Label18.Text = "(20.00 KM po satu)"
        '
        'txtRadniciSati
        '
        Me.txtRadniciSati.Location = New System.Drawing.Point(66, 54)
        Me.txtRadniciSati.Name = "txtRadniciSati"
        Me.txtRadniciSati.Size = New System.Drawing.Size(60, 20)
        Me.txtRadniciSati.TabIndex = 3
        '
        'txtDijeloviCijena
        '
        Me.txtDijeloviCijena.Location = New System.Drawing.Point(66, 28)
        Me.txtDijeloviCijena.Name = "txtDijeloviCijena"
        Me.txtDijeloviCijena.Size = New System.Drawing.Size(60, 20)
        Me.txtDijeloviCijena.TabIndex = 2
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(21, 57)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(43, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Radnici"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(21, 31)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(41, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Dijelovi"
        '
        'GroupBox5
        '
        Me.GroupBox5.BackColor = System.Drawing.Color.YellowGreen
        Me.GroupBox5.Controls.Add(Me.lblZaPlatiti)
        Me.GroupBox5.Controls.Add(Me.lblPDVZaDijelove)
        Me.GroupBox5.Controls.Add(Me.lblDijelovi)
        Me.GroupBox5.Controls.Add(Me.lblServisiIRadnici)
        Me.GroupBox5.Controls.Add(Me.Label6)
        Me.GroupBox5.Controls.Add(Me.Label5)
        Me.GroupBox5.Controls.Add(Me.Label4)
        Me.GroupBox5.Controls.Add(Me.Label3)
        Me.GroupBox5.Location = New System.Drawing.Point(473, 191)
        Me.GroupBox5.Name = "GroupBox5"
        Me.GroupBox5.Size = New System.Drawing.Size(226, 139)
        Me.GroupBox5.TabIndex = 3
        Me.GroupBox5.TabStop = False
        Me.GroupBox5.Text = "Ukupno"
        '
        'lblZaPlatiti
        '
        Me.lblZaPlatiti.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblZaPlatiti.Location = New System.Drawing.Point(101, 104)
        Me.lblZaPlatiti.Name = "lblZaPlatiti"
        Me.lblZaPlatiti.Size = New System.Drawing.Size(100, 20)
        Me.lblZaPlatiti.TabIndex = 7
        '
        'lblPDVZaDijelove
        '
        Me.lblPDVZaDijelove.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblPDVZaDijelove.Location = New System.Drawing.Point(101, 76)
        Me.lblPDVZaDijelove.Name = "lblPDVZaDijelove"
        Me.lblPDVZaDijelove.Size = New System.Drawing.Size(100, 20)
        Me.lblPDVZaDijelove.TabIndex = 6
        '
        'lblDijelovi
        '
        Me.lblDijelovi.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblDijelovi.Location = New System.Drawing.Point(101, 48)
        Me.lblDijelovi.Name = "lblDijelovi"
        Me.lblDijelovi.Size = New System.Drawing.Size(100, 20)
        Me.lblDijelovi.TabIndex = 5
        '
        'lblServisiIRadnici
        '
        Me.lblServisiIRadnici.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblServisiIRadnici.Location = New System.Drawing.Point(101, 20)
        Me.lblServisiIRadnici.Name = "lblServisiIRadnici"
        Me.lblServisiIRadnici.Size = New System.Drawing.Size(100, 20)
        Me.lblServisiIRadnici.TabIndex = 4
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(38, 107)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(47, 13)
        Me.Label6.TabIndex = 3
        Me.Label6.Text = "Za platiti"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(56, 76)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(29, 13)
        Me.Label5.TabIndex = 2
        Me.Label5.Text = "PDV"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(44, 49)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(41, 13)
        Me.Label4.TabIndex = 1
        Me.Label4.Text = "Dijelovi"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(18, 21)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(77, 13)
        Me.Label3.TabIndex = 0
        Me.Label3.Text = "Servisi i radnici"
        '
        'btnIzracunaj
        '
        Me.btnIzracunaj.BackColor = System.Drawing.Color.Tomato
        Me.btnIzracunaj.Location = New System.Drawing.Point(540, 358)
        Me.btnIzracunaj.Name = "btnIzracunaj"
        Me.btnIzracunaj.Size = New System.Drawing.Size(79, 30)
        Me.btnIzracunaj.TabIndex = 4
        Me.btnIzracunaj.Text = "Izracunaj"
        Me.btnIzracunaj.UseVisualStyleBackColor = False
        '
        'btnOcisti
        '
        Me.btnOcisti.BackColor = System.Drawing.Color.Gold
        Me.btnOcisti.Location = New System.Drawing.Point(540, 398)
        Me.btnOcisti.Name = "btnOcisti"
        Me.btnOcisti.Size = New System.Drawing.Size(79, 30)
        Me.btnOcisti.TabIndex = 5
        Me.btnOcisti.Text = "Ocisti"
        Me.btnOcisti.UseVisualStyleBackColor = False
        '
        'btnIzlaz
        '
        Me.btnIzlaz.BackColor = System.Drawing.Color.YellowGreen
        Me.btnIzlaz.Location = New System.Drawing.Point(540, 442)
        Me.btnIzlaz.Name = "btnIzlaz"
        Me.btnIzlaz.Size = New System.Drawing.Size(81, 30)
        Me.btnIzlaz.TabIndex = 6
        Me.btnIzlaz.Text = "Izlaz"
        Me.btnIzlaz.UseVisualStyleBackColor = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(-3, -1)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(749, 500)
        Me.PictureBox1.TabIndex = 7
        Me.PictureBox1.TabStop = False
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.Label7.Font = New System.Drawing.Font("Microsoft JhengHei", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(365, 44)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(203, 20)
        Me.Label7.TabIndex = 8
        Me.Label7.Text = "Automehaničarska radnja"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(741, 496)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.btnIzlaz)
        Me.Controls.Add(Me.btnOcisti)
        Me.Controls.Add(Me.btnIzracunaj)
        Me.Controls.Add(Me.GroupBox5)
        Me.Controls.Add(Me.GroupBox4)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.PictureBox1)
        Me.Name = "Form1"
        Me.Text = "Automehaničarska radnja"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
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
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents chkFilterZraka As System.Windows.Forms.CheckBox
    Friend WithEvents chkFIlterKlime As System.Windows.Forms.CheckBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents chkUljeMjenjaca As System.Windows.Forms.CheckBox
    Friend WithEvents chkMotornoUlje As System.Windows.Forms.CheckBox
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents chkGeometrijaTockova As System.Windows.Forms.CheckBox
    Friend WithEvents chkIzmjenaKocnica As System.Windows.Forms.CheckBox
    Friend WithEvents chkPregledVozila As System.Windows.Forms.CheckBox
    Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
    Friend WithEvents txtRadniciSati As System.Windows.Forms.TextBox
    Friend WithEvents txtDijeloviCijena As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents GroupBox5 As System.Windows.Forms.GroupBox
    Friend WithEvents lblZaPlatiti As System.Windows.Forms.Label
    Friend WithEvents lblPDVZaDijelove As System.Windows.Forms.Label
    Friend WithEvents lblDijelovi As System.Windows.Forms.Label
    Friend WithEvents lblServisiIRadnici As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents btnIzracunaj As System.Windows.Forms.Button
    Friend WithEvents btnOcisti As System.Windows.Forms.Button
    Friend WithEvents btnIzlaz As System.Windows.Forms.Button
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label7 As Label
End Class
