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
        Me.components = New System.ComponentModel.Container()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.radIntegralna = New System.Windows.Forms.RadioButton()
        Me.radBijela = New System.Windows.Forms.RadioButton()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.radMakijato = New System.Windows.Forms.RadioButton()
        Me.radKapucino = New System.Windows.Forms.RadioButton()
        Me.radObicnaKafa = New System.Windows.Forms.RadioButton()
        Me.radBezKafe = New System.Windows.Forms.RadioButton()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.chkSljiva = New System.Windows.Forms.CheckBox()
        Me.chkJagoda = New System.Windows.Forms.CheckBox()
        Me.chkBorovnica = New System.Windows.Forms.CheckBox()
        Me.chkMaslac = New System.Windows.Forms.CheckBox()
        Me.chkKremastiSir = New System.Windows.Forms.CheckBox()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.lblZaPlatiti = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.lblPDV = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.lblUkupno = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btnUkupnaCijena = New System.Windows.Forms.Button()
        Me.btnReset = New System.Windows.Forms.Button()
        Me.btnIzlaz = New System.Windows.Forms.Button()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.SeaShell
        Me.Label1.Font = New System.Drawing.Font("Times New Roman", 18.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(39, 18)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(146, 28)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Kafa i Peciva"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.SandyBrown
        Me.GroupBox1.Controls.Add(Me.radIntegralna)
        Me.GroupBox1.Controls.Add(Me.radBijela)
        Me.GroupBox1.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.GroupBox1.Location = New System.Drawing.Point(240, 27)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(200, 72)
        Me.GroupBox1.TabIndex = 1
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "OdaberiVeknu"
        '
        'radIntegralna
        '
        Me.radIntegralna.AutoSize = True
        Me.radIntegralna.Location = New System.Drawing.Point(9, 42)
        Me.radIntegralna.Name = "radIntegralna"
        Me.radIntegralna.Size = New System.Drawing.Size(118, 17)
        Me.radIntegralna.TabIndex = 1
        Me.radIntegralna.Text = "Integralna (1.50KM)"
        Me.ToolTip1.SetToolTip(Me.radIntegralna, "Click here to choose a whole wheat bagel.")
        Me.radIntegralna.UseVisualStyleBackColor = True
        '
        'radBijela
        '
        Me.radBijela.AutoSize = True
        Me.radBijela.Checked = True
        Me.radBijela.Location = New System.Drawing.Point(9, 19)
        Me.radBijela.Name = "radBijela"
        Me.radBijela.Size = New System.Drawing.Size(129, 17)
        Me.radBijela.TabIndex = 0
        Me.radBijela.TabStop = True
        Me.radBijela.Text = "Bijela vekna (1.30KM)"
        Me.ToolTip1.SetToolTip(Me.radBijela, "Click here to choose a white bagel.")
        Me.radBijela.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.Color.PeachPuff
        Me.GroupBox2.Controls.Add(Me.radMakijato)
        Me.GroupBox2.Controls.Add(Me.radKapucino)
        Me.GroupBox2.Controls.Add(Me.radObicnaKafa)
        Me.GroupBox2.Controls.Add(Me.radBezKafe)
        Me.GroupBox2.Location = New System.Drawing.Point(12, 294)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(200, 118)
        Me.GroupBox2.TabIndex = 0
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Želite li kafu?"
        '
        'radMakijato
        '
        Me.radMakijato.AutoSize = True
        Me.radMakijato.Location = New System.Drawing.Point(6, 88)
        Me.radMakijato.Name = "radMakijato"
        Me.radMakijato.Size = New System.Drawing.Size(111, 17)
        Me.radMakijato.TabIndex = 3
        Me.radMakijato.TabStop = True
        Me.radMakijato.Text = "Makijato (1.75KM)"
        Me.ToolTip1.SetToolTip(Me.radMakijato, "Click here to choose cafe au lait.")
        Me.radMakijato.UseVisualStyleBackColor = True
        '
        'radKapucino
        '
        Me.radKapucino.AutoSize = True
        Me.radKapucino.Location = New System.Drawing.Point(6, 65)
        Me.radKapucino.Name = "radKapucino"
        Me.radKapucino.Size = New System.Drawing.Size(116, 17)
        Me.radKapucino.TabIndex = 2
        Me.radKapucino.TabStop = True
        Me.radKapucino.Text = "Kapućino (2.00KM)"
        Me.ToolTip1.SetToolTip(Me.radKapucino, "Click here to choose cappuccino.")
        Me.radKapucino.UseVisualStyleBackColor = True
        '
        'radObicnaKafa
        '
        Me.radObicnaKafa.AutoSize = True
        Me.radObicnaKafa.Location = New System.Drawing.Point(6, 42)
        Me.radObicnaKafa.Name = "radObicnaKafa"
        Me.radObicnaKafa.Size = New System.Drawing.Size(129, 17)
        Me.radObicnaKafa.TabIndex = 1
        Me.radObicnaKafa.TabStop = True
        Me.radObicnaKafa.Text = "Obična kafa (1.25KM)"
        Me.ToolTip1.SetToolTip(Me.radObicnaKafa, "Click here to choosee regular coffee.")
        Me.radObicnaKafa.UseVisualStyleBackColor = True
        '
        'radBezKafe
        '
        Me.radBezKafe.AutoSize = True
        Me.radBezKafe.Location = New System.Drawing.Point(6, 19)
        Me.radBezKafe.Name = "radBezKafe"
        Me.radBezKafe.Size = New System.Drawing.Size(39, 17)
        Me.radBezKafe.TabIndex = 0
        Me.radBezKafe.TabStop = True
        Me.radBezKafe.Text = "Ne"
        Me.ToolTip1.SetToolTip(Me.radBezKafe, "Click here to choose no coffee?")
        Me.radBezKafe.UseVisualStyleBackColor = True
        '
        'GroupBox3
        '
        Me.GroupBox3.BackColor = System.Drawing.Color.Gold
        Me.GroupBox3.Controls.Add(Me.chkSljiva)
        Me.GroupBox3.Controls.Add(Me.chkJagoda)
        Me.GroupBox3.Controls.Add(Me.chkBorovnica)
        Me.GroupBox3.Controls.Add(Me.chkMaslac)
        Me.GroupBox3.Controls.Add(Me.chkKremastiSir)
        Me.GroupBox3.Location = New System.Drawing.Point(240, 105)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(200, 141)
        Me.GroupBox3.TabIndex = 0
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Odaberite namaz"
        '
        'chkSljiva
        '
        Me.chkSljiva.AutoSize = True
        Me.chkSljiva.Location = New System.Drawing.Point(9, 111)
        Me.chkSljiva.Name = "chkSljiva"
        Me.chkSljiva.Size = New System.Drawing.Size(140, 17)
        Me.chkSljiva.TabIndex = 4
        Me.chkSljiva.Text = "Džem od šljiva (0.75KM)"
        Me.ToolTip1.SetToolTip(Me.chkSljiva, "Click here to choose peach jelly.")
        Me.chkSljiva.UseVisualStyleBackColor = True
        '
        'chkJagoda
        '
        Me.chkJagoda.AutoSize = True
        Me.chkJagoda.Location = New System.Drawing.Point(9, 88)
        Me.chkJagoda.Name = "chkJagoda"
        Me.chkJagoda.Size = New System.Drawing.Size(149, 17)
        Me.chkJagoda.TabIndex = 3
        Me.chkJagoda.Text = "Džem od jagoda (0.75KM)"
        Me.ToolTip1.SetToolTip(Me.chkJagoda, "Click here to choose raspberry jam.")
        Me.chkJagoda.UseVisualStyleBackColor = True
        '
        'chkBorovnica
        '
        Me.chkBorovnica.AutoSize = True
        Me.chkBorovnica.Location = New System.Drawing.Point(9, 65)
        Me.chkBorovnica.Name = "chkBorovnica"
        Me.chkBorovnica.Size = New System.Drawing.Size(164, 17)
        Me.chkBorovnica.TabIndex = 2
        Me.chkBorovnica.Text = "Džem od borovnice (0.75KM)"
        Me.ToolTip1.SetToolTip(Me.chkBorovnica, "Click here to choose blueberry jam.")
        Me.chkBorovnica.UseVisualStyleBackColor = True
        '
        'chkMaslac
        '
        Me.chkMaslac.AutoSize = True
        Me.chkMaslac.Location = New System.Drawing.Point(9, 42)
        Me.chkMaslac.Name = "chkMaslac"
        Me.chkMaslac.Size = New System.Drawing.Size(106, 17)
        Me.chkMaslac.TabIndex = 1
        Me.chkMaslac.Text = "Maslac (0.25KM)"
        Me.ToolTip1.SetToolTip(Me.chkMaslac, "Click here to choose butter.")
        Me.chkMaslac.UseVisualStyleBackColor = True
        '
        'chkKremastiSir
        '
        Me.chkKremastiSir.AutoSize = True
        Me.chkKremastiSir.Location = New System.Drawing.Point(9, 19)
        Me.chkKremastiSir.Name = "chkKremastiSir"
        Me.chkKremastiSir.Size = New System.Drawing.Size(125, 17)
        Me.chkKremastiSir.TabIndex = 0
        Me.chkKremastiSir.Text = "Kremasti sir (0.50KM)"
        Me.ToolTip1.SetToolTip(Me.chkKremastiSir, "Click here to choose cream cheese.")
        Me.chkKremastiSir.UseVisualStyleBackColor = True
        '
        'GroupBox4
        '
        Me.GroupBox4.BackColor = System.Drawing.Color.YellowGreen
        Me.GroupBox4.Controls.Add(Me.lblZaPlatiti)
        Me.GroupBox4.Controls.Add(Me.Label6)
        Me.GroupBox4.Controls.Add(Me.lblPDV)
        Me.GroupBox4.Controls.Add(Me.Label4)
        Me.GroupBox4.Controls.Add(Me.lblUkupno)
        Me.GroupBox4.Controls.Add(Me.Label2)
        Me.GroupBox4.Location = New System.Drawing.Point(240, 252)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(200, 95)
        Me.GroupBox4.TabIndex = 0
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Cijena"
        '
        'lblZaPlatiti
        '
        Me.lblZaPlatiti.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblZaPlatiti.Location = New System.Drawing.Point(94, 65)
        Me.lblZaPlatiti.Name = "lblZaPlatiti"
        Me.lblZaPlatiti.Size = New System.Drawing.Size(50, 18)
        Me.lblZaPlatiti.TabIndex = 5
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(37, 66)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(50, 13)
        Me.Label6.TabIndex = 4
        Me.Label6.Text = "Za platiti:"
        '
        'lblPDV
        '
        Me.lblPDV.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblPDV.Location = New System.Drawing.Point(94, 42)
        Me.lblPDV.Name = "lblPDV"
        Me.lblPDV.Size = New System.Drawing.Size(50, 18)
        Me.lblPDV.TabIndex = 3
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(55, 43)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(32, 13)
        Me.Label4.TabIndex = 2
        Me.Label4.Text = "PDV:"
        '
        'lblUkupno
        '
        Me.lblUkupno.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblUkupno.Location = New System.Drawing.Point(94, 19)
        Me.lblUkupno.Name = "lblUkupno"
        Me.lblUkupno.Size = New System.Drawing.Size(50, 18)
        Me.lblUkupno.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(39, 21)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(48, 13)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Ukupno:"
        '
        'btnUkupnaCijena
        '
        Me.btnUkupnaCijena.Location = New System.Drawing.Point(273, 359)
        Me.btnUkupnaCijena.Name = "btnUkupnaCijena"
        Me.btnUkupnaCijena.Size = New System.Drawing.Size(125, 23)
        Me.btnUkupnaCijena.TabIndex = 2
        Me.btnUkupnaCijena.Text = "&Izracunaj Ukupno"
        Me.ToolTip1.SetToolTip(Me.btnUkupnaCijena, "Click here to calculate the total of the order.")
        Me.btnUkupnaCijena.UseVisualStyleBackColor = True
        '
        'btnReset
        '
        Me.btnReset.Location = New System.Drawing.Point(273, 385)
        Me.btnReset.Name = "btnReset"
        Me.btnReset.Size = New System.Drawing.Size(125, 23)
        Me.btnReset.TabIndex = 3
        Me.btnReset.Text = "&Obriši formu"
        Me.ToolTip1.SetToolTip(Me.btnReset, "Click Here to clear the form and start over.")
        Me.btnReset.UseVisualStyleBackColor = True
        '
        'btnIzlaz
        '
        Me.btnIzlaz.Location = New System.Drawing.Point(273, 411)
        Me.btnIzlaz.Name = "btnIzlaz"
        Me.btnIzlaz.Size = New System.Drawing.Size(125, 23)
        Me.btnIzlaz.TabIndex = 4
        Me.btnIzlaz.Text = "I&zađi"
        Me.ToolTip1.SetToolTip(Me.btnIzlaz, "Click here to exit.")
        Me.btnIzlaz.UseVisualStyleBackColor = True
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.Kafa_Peciva.My.Resources.Resources.KafaIPeciva
        Me.PictureBox1.Location = New System.Drawing.Point(1, -1)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(451, 452)
        Me.PictureBox1.TabIndex = 5
        Me.PictureBox1.TabStop = False
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(452, 446)
        Me.Controls.Add(Me.btnIzlaz)
        Me.Controls.Add(Me.btnReset)
        Me.Controls.Add(Me.btnUkupnaCijena)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox4)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.PictureBox1)
        Me.Name = "Form1"
        Me.Text = "Kafa i Peciva"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents radIntegralna As System.Windows.Forms.RadioButton
    Friend WithEvents radBijela As System.Windows.Forms.RadioButton
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents radObicnaKafa As System.Windows.Forms.RadioButton
    Friend WithEvents radBezKafe As System.Windows.Forms.RadioButton
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
    Friend WithEvents radMakijato As System.Windows.Forms.RadioButton
    Friend WithEvents radKapucino As System.Windows.Forms.RadioButton
    Friend WithEvents chkSljiva As System.Windows.Forms.CheckBox
    Friend WithEvents chkJagoda As System.Windows.Forms.CheckBox
    Friend WithEvents chkBorovnica As System.Windows.Forms.CheckBox
    Friend WithEvents chkMaslac As System.Windows.Forms.CheckBox
    Friend WithEvents chkKremastiSir As System.Windows.Forms.CheckBox
    Friend WithEvents lblZaPlatiti As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents lblPDV As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents lblUkupno As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents btnUkupnaCijena As System.Windows.Forms.Button
    Friend WithEvents btnReset As System.Windows.Forms.Button
    Friend WithEvents btnIzlaz As System.Windows.Forms.Button
    Friend WithEvents ToolTip1 As System.Windows.Forms.ToolTip
    Friend WithEvents PictureBox1 As PictureBox
End Class
