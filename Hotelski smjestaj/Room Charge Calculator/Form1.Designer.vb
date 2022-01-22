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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnIzračunaj = New System.Windows.Forms.Button()
        Me.btnOcisti = New System.Windows.Forms.Button()
        Me.btnIzlaz = New System.Windows.Forms.Button()
        Me.lblDanasnjiDatum = New System.Windows.Forms.Label()
        Me.lblVrijeme = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.txtCijenaNocenja = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtBrojNocenja = New System.Windows.Forms.TextBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.txtOstalo = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtTVInternet = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtSobnaDostava = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.lblZaPlatiti = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.lblPDV = New System.Windows.Forms.Label()
        Me.lblUkupno = New System.Windows.Forms.Label()
        Me.lblOstaleUsluge = New System.Windows.Forms.Label()
        Me.lblNocenja = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.PeachPuff
        Me.Label1.Font = New System.Drawing.Font("Mistral", 26.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.DimGray
        Me.Label1.Location = New System.Drawing.Point(310, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(259, 42)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Hotel Internacional"
        '
        'btnIzračunaj
        '
        Me.btnIzračunaj.BackColor = System.Drawing.Color.PeachPuff
        Me.btnIzračunaj.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnIzračunaj.Location = New System.Drawing.Point(747, 433)
        Me.btnIzračunaj.Name = "btnIzračunaj"
        Me.btnIzračunaj.Size = New System.Drawing.Size(142, 40)
        Me.btnIzračunaj.TabIndex = 1
        Me.btnIzračunaj.Text = "Izračunaj troškove"
        Me.btnIzračunaj.UseVisualStyleBackColor = False
        '
        'btnOcisti
        '
        Me.btnOcisti.BackColor = System.Drawing.Color.PeachPuff
        Me.btnOcisti.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnOcisti.Location = New System.Drawing.Point(747, 488)
        Me.btnOcisti.Name = "btnOcisti"
        Me.btnOcisti.Size = New System.Drawing.Size(102, 35)
        Me.btnOcisti.TabIndex = 2
        Me.btnOcisti.Text = "Očisti formu"
        Me.btnOcisti.UseVisualStyleBackColor = False
        '
        'btnIzlaz
        '
        Me.btnIzlaz.BackColor = System.Drawing.Color.Bisque
        Me.btnIzlaz.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnIzlaz.Location = New System.Drawing.Point(747, 537)
        Me.btnIzlaz.Name = "btnIzlaz"
        Me.btnIzlaz.Size = New System.Drawing.Size(79, 37)
        Me.btnIzlaz.TabIndex = 3
        Me.btnIzlaz.Text = "Izlaz"
        Me.btnIzlaz.UseVisualStyleBackColor = False
        '
        'lblDanasnjiDatum
        '
        Me.lblDanasnjiDatum.BackColor = System.Drawing.Color.SeaShell
        Me.lblDanasnjiDatum.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDanasnjiDatum.Location = New System.Drawing.Point(176, 75)
        Me.lblDanasnjiDatum.Name = "lblDanasnjiDatum"
        Me.lblDanasnjiDatum.Size = New System.Drawing.Size(199, 18)
        Me.lblDanasnjiDatum.TabIndex = 4
        '
        'lblVrijeme
        '
        Me.lblVrijeme.BackColor = System.Drawing.Color.SeaShell
        Me.lblVrijeme.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblVrijeme.Location = New System.Drawing.Point(176, 101)
        Me.lblVrijeme.Name = "lblVrijeme"
        Me.lblVrijeme.Size = New System.Drawing.Size(199, 17)
        Me.lblVrijeme.TabIndex = 5
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.SeaShell
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(48, 77)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(103, 16)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "Današnji datum:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.SeaShell
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(95, 101)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(56, 16)
        Me.Label3.TabIndex = 7
        Me.Label3.Text = "Vrijeme:"
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.PeachPuff
        Me.GroupBox1.Controls.Add(Me.txtCijenaNocenja)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.txtBrojNocenja)
        Me.GroupBox1.Controls.Add(Me.Label14)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(464, 80)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(217, 100)
        Me.GroupBox1.TabIndex = 8
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Podaci o sobi"
        '
        'txtCijenaNocenja
        '
        Me.txtCijenaNocenja.Location = New System.Drawing.Point(110, 62)
        Me.txtCijenaNocenja.Name = "txtCijenaNocenja"
        Me.txtCijenaNocenja.Size = New System.Drawing.Size(66, 22)
        Me.txtCijenaNocenja.TabIndex = 18
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(6, 62)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(99, 16)
        Me.Label4.TabIndex = 17
        Me.Label4.Text = "Cijena noćenja:"
        '
        'txtBrojNocenja
        '
        Me.txtBrojNocenja.Location = New System.Drawing.Point(110, 31)
        Me.txtBrojNocenja.Name = "txtBrojNocenja"
        Me.txtBrojNocenja.Size = New System.Drawing.Size(66, 22)
        Me.txtBrojNocenja.TabIndex = 16
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(19, 31)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(85, 16)
        Me.Label14.TabIndex = 15
        Me.Label14.Text = "Broj noćenja:"
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.Color.Bisque
        Me.GroupBox2.Controls.Add(Me.txtOstalo)
        Me.GroupBox2.Controls.Add(Me.Label7)
        Me.GroupBox2.Controls.Add(Me.txtTVInternet)
        Me.GroupBox2.Controls.Add(Me.Label6)
        Me.GroupBox2.Controls.Add(Me.txtSobnaDostava)
        Me.GroupBox2.Controls.Add(Me.Label5)
        Me.GroupBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.Location = New System.Drawing.Point(714, 142)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(217, 119)
        Me.GroupBox2.TabIndex = 0
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Usluge"
        '
        'txtOstalo
        '
        Me.txtOstalo.Location = New System.Drawing.Point(116, 82)
        Me.txtOstalo.Name = "txtOstalo"
        Me.txtOstalo.Size = New System.Drawing.Size(76, 22)
        Me.txtOstalo.TabIndex = 21
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(68, 85)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(49, 16)
        Me.Label7.TabIndex = 20
        Me.Label7.Text = "Ostalo:"
        '
        'txtTVInternet
        '
        Me.txtTVInternet.Location = New System.Drawing.Point(116, 54)
        Me.txtTVInternet.Name = "txtTVInternet"
        Me.txtTVInternet.Size = New System.Drawing.Size(76, 22)
        Me.txtTVInternet.TabIndex = 19
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(30, 57)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(80, 16)
        Me.Label6.TabIndex = 18
        Me.Label6.Text = "TV i internet:"
        '
        'txtSobnaDostava
        '
        Me.txtSobnaDostava.Location = New System.Drawing.Point(116, 25)
        Me.txtSobnaDostava.Name = "txtSobnaDostava"
        Me.txtSobnaDostava.Size = New System.Drawing.Size(76, 22)
        Me.txtSobnaDostava.TabIndex = 17
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(10, 28)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(102, 16)
        Me.Label5.TabIndex = 16
        Me.Label5.Text = "Sobna dostava:"
        '
        'GroupBox3
        '
        Me.GroupBox3.BackColor = System.Drawing.Color.Bisque
        Me.GroupBox3.Controls.Add(Me.lblZaPlatiti)
        Me.GroupBox3.Controls.Add(Me.Label12)
        Me.GroupBox3.Controls.Add(Me.lblPDV)
        Me.GroupBox3.Controls.Add(Me.lblUkupno)
        Me.GroupBox3.Controls.Add(Me.lblOstaleUsluge)
        Me.GroupBox3.Controls.Add(Me.lblNocenja)
        Me.GroupBox3.Controls.Add(Me.Label11)
        Me.GroupBox3.Controls.Add(Me.Label10)
        Me.GroupBox3.Controls.Add(Me.Label9)
        Me.GroupBox3.Controls.Add(Me.Label8)
        Me.GroupBox3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox3.Location = New System.Drawing.Point(405, 433)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(314, 182)
        Me.GroupBox3.TabIndex = 9
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Plaćanje"
        '
        'lblZaPlatiti
        '
        Me.lblZaPlatiti.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblZaPlatiti.Location = New System.Drawing.Point(153, 144)
        Me.lblZaPlatiti.Name = "lblZaPlatiti"
        Me.lblZaPlatiti.Size = New System.Drawing.Size(100, 23)
        Me.lblZaPlatiti.TabIndex = 36
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(33, 145)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(63, 16)
        Me.Label12.TabIndex = 35
        Me.Label12.Text = "Za platitii:"
        '
        'lblPDV
        '
        Me.lblPDV.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblPDV.Location = New System.Drawing.Point(153, 113)
        Me.lblPDV.Name = "lblPDV"
        Me.lblPDV.Size = New System.Drawing.Size(100, 23)
        Me.lblPDV.TabIndex = 34
        '
        'lblUkupno
        '
        Me.lblUkupno.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblUkupno.Location = New System.Drawing.Point(153, 83)
        Me.lblUkupno.Name = "lblUkupno"
        Me.lblUkupno.Size = New System.Drawing.Size(100, 23)
        Me.lblUkupno.TabIndex = 33
        '
        'lblOstaleUsluge
        '
        Me.lblOstaleUsluge.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblOstaleUsluge.Location = New System.Drawing.Point(153, 53)
        Me.lblOstaleUsluge.Name = "lblOstaleUsluge"
        Me.lblOstaleUsluge.Size = New System.Drawing.Size(100, 23)
        Me.lblOstaleUsluge.TabIndex = 32
        '
        'lblNocenja
        '
        Me.lblNocenja.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblNocenja.Location = New System.Drawing.Point(153, 23)
        Me.lblNocenja.Name = "lblNocenja"
        Me.lblNocenja.Size = New System.Drawing.Size(100, 23)
        Me.lblNocenja.TabIndex = 31
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(58, 114)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(38, 16)
        Me.Label11.TabIndex = 29
        Me.Label11.Text = "PDV:"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(39, 84)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(57, 16)
        Me.Label10.TabIndex = 28
        Me.Label10.Text = "Ukupno:"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(47, 55)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(49, 16)
        Me.Label9.TabIndex = 27
        Me.Label9.Text = "Ostalo:"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(39, 24)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(61, 16)
        Me.Label8.TabIndex = 26
        Me.Label8.Text = "Noćenje:"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(-1, 0)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(956, 635)
        Me.PictureBox1.TabIndex = 10
        Me.PictureBox1.TabStop = False
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.Location = New System.Drawing.Point(945, 395)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(10, 20)
        Me.DateTimePicker1.TabIndex = 11
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(943, 627)
        Me.Controls.Add(Me.DateTimePicker1)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.lblVrijeme)
        Me.Controls.Add(Me.lblDanasnjiDatum)
        Me.Controls.Add(Me.btnIzlaz)
        Me.Controls.Add(Me.btnOcisti)
        Me.Controls.Add(Me.btnIzračunaj)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.PictureBox1)
        Me.Name = "Form1"
        Me.Text = "Hotelski smjestaj"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents btnIzračunaj As System.Windows.Forms.Button
    Friend WithEvents btnOcisti As System.Windows.Forms.Button
    Friend WithEvents btnIzlaz As System.Windows.Forms.Button
    Friend WithEvents lblDanasnjiDatum As System.Windows.Forms.Label
    Friend WithEvents lblVrijeme As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents txtCijenaNocenja As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txtBrojNocenja As System.Windows.Forms.TextBox
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents txtOstalo As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents txtTVInternet As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents txtSobnaDostava As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents lblZaPlatiti As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents lblPDV As System.Windows.Forms.Label
    Friend WithEvents lblUkupno As System.Windows.Forms.Label
    Friend WithEvents lblOstaleUsluge As System.Windows.Forms.Label
    Friend WithEvents lblNocenja As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents DateTimePicker1 As DateTimePicker
End Class
