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
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.radStariji = New System.Windows.Forms.RadioButton()
        Me.radStudenti = New System.Windows.Forms.RadioButton()
        Me.radDjeca = New System.Windows.Forms.RadioButton()
        Me.radOdrasli = New System.Windows.Forms.RadioButton()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.chkTrener = New System.Windows.Forms.CheckBox()
        Me.chkKarate = New System.Windows.Forms.CheckBox()
        Me.chkJoga = New System.Windows.Forms.CheckBox()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.txtMjeseci = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.lblUkupnaClanarina = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.lblMjesecnaClanarina = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.btnIzracunaj = New System.Windows.Forms.Button()
        Me.btnOcisti = New System.Windows.Forms.Button()
        Me.btnIzlaz = New System.Windows.Forms.Button()
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.lblPoruka = New System.Windows.Forms.ToolStripStatusLabel()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        Me.StatusStrip1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.IndianRed
        Me.GroupBox1.Controls.Add(Me.radStariji)
        Me.GroupBox1.Controls.Add(Me.radStudenti)
        Me.GroupBox1.Controls.Add(Me.radDjeca)
        Me.GroupBox1.Controls.Add(Me.radOdrasli)
        Me.GroupBox1.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.GroupBox1.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(200, 116)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Vrsta članstva"
        '
        'radStariji
        '
        Me.radStariji.AutoSize = True
        Me.radStariji.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.radStariji.Location = New System.Drawing.Point(13, 88)
        Me.radStariji.Name = "radStariji"
        Me.radStariji.Size = New System.Drawing.Size(86, 17)
        Me.radStariji.TabIndex = 3
        Me.radStariji.Text = "S&tarije osobe"
        Me.radStariji.UseVisualStyleBackColor = True
        '
        'radStudenti
        '
        Me.radStudenti.AutoSize = True
        Me.radStudenti.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.radStudenti.Location = New System.Drawing.Point(13, 65)
        Me.radStudenti.Name = "radStudenti"
        Me.radStudenti.Size = New System.Drawing.Size(64, 17)
        Me.radStudenti.TabIndex = 2
        Me.radStudenti.Text = "&Studenti"
        Me.radStudenti.UseVisualStyleBackColor = True
        '
        'radDjeca
        '
        Me.radDjeca.AutoSize = True
        Me.radDjeca.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.radDjeca.Location = New System.Drawing.Point(13, 42)
        Me.radDjeca.Name = "radDjeca"
        Me.radDjeca.Size = New System.Drawing.Size(107, 17)
        Me.radDjeca.TabIndex = 1
        Me.radDjeca.Text = "Djec&a (12 i mlađi)"
        Me.radDjeca.UseVisualStyleBackColor = True
        '
        'radOdrasli
        '
        Me.radOdrasli.AutoSize = True
        Me.radOdrasli.Checked = True
        Me.radOdrasli.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.radOdrasli.Location = New System.Drawing.Point(13, 19)
        Me.radOdrasli.Name = "radOdrasli"
        Me.radOdrasli.Size = New System.Drawing.Size(94, 17)
        Me.radOdrasli.TabIndex = 0
        Me.radOdrasli.TabStop = True
        Me.radOdrasli.Text = "Obična &Odrasli"
        Me.radOdrasli.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.Color.DarkSalmon
        Me.GroupBox2.Controls.Add(Me.chkTrener)
        Me.GroupBox2.Controls.Add(Me.chkKarate)
        Me.GroupBox2.Controls.Add(Me.chkJoga)
        Me.GroupBox2.Location = New System.Drawing.Point(137, 144)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(200, 97)
        Me.GroupBox2.TabIndex = 0
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Dodatni izbori"
        '
        'chkTrener
        '
        Me.chkTrener.AutoSize = True
        Me.chkTrener.Location = New System.Drawing.Point(10, 65)
        Me.chkTrener.Name = "chkTrener"
        Me.chkTrener.Size = New System.Drawing.Size(91, 17)
        Me.chkTrener.TabIndex = 2
        Me.chkTrener.Text = "&Privatni trener"
        Me.chkTrener.UseVisualStyleBackColor = True
        '
        'chkKarate
        '
        Me.chkKarate.AutoSize = True
        Me.chkKarate.Location = New System.Drawing.Point(10, 42)
        Me.chkKarate.Name = "chkKarate"
        Me.chkKarate.Size = New System.Drawing.Size(57, 17)
        Me.chkKarate.TabIndex = 1
        Me.chkKarate.Text = "&Karate"
        Me.chkKarate.UseVisualStyleBackColor = True
        '
        'chkJoga
        '
        Me.chkJoga.AutoSize = True
        Me.chkJoga.Location = New System.Drawing.Point(10, 19)
        Me.chkJoga.Name = "chkJoga"
        Me.chkJoga.Size = New System.Drawing.Size(49, 17)
        Me.chkJoga.TabIndex = 0
        Me.chkJoga.Text = "&Joga"
        Me.chkJoga.UseVisualStyleBackColor = True
        '
        'GroupBox3
        '
        Me.GroupBox3.BackColor = System.Drawing.Color.Moccasin
        Me.GroupBox3.Controls.Add(Me.txtMjeseci)
        Me.GroupBox3.Controls.Add(Me.Label1)
        Me.GroupBox3.Location = New System.Drawing.Point(277, 247)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(197, 87)
        Me.GroupBox3.TabIndex = 1
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Dužina članstva"
        '
        'txtMjeseci
        '
        Me.txtMjeseci.Location = New System.Drawing.Point(9, 51)
        Me.txtMjeseci.Name = "txtMjeseci"
        Me.txtMjeseci.Size = New System.Drawing.Size(100, 20)
        Me.txtMjeseci.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(8, 26)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(101, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Unesite broj mjeseci"
        '
        'GroupBox4
        '
        Me.GroupBox4.BackColor = System.Drawing.Color.YellowGreen
        Me.GroupBox4.Controls.Add(Me.lblUkupnaClanarina)
        Me.GroupBox4.Controls.Add(Me.Label2)
        Me.GroupBox4.Controls.Add(Me.lblMjesecnaClanarina)
        Me.GroupBox4.Controls.Add(Me.Label3)
        Me.GroupBox4.Location = New System.Drawing.Point(399, 350)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(200, 100)
        Me.GroupBox4.TabIndex = 2
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Mjesečna članarina"
        '
        'lblUkupnaClanarina
        '
        Me.lblUkupnaClanarina.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblUkupnaClanarina.Location = New System.Drawing.Point(81, 58)
        Me.lblUkupnaClanarina.Name = "lblUkupnaClanarina"
        Me.lblUkupnaClanarina.Size = New System.Drawing.Size(100, 23)
        Me.lblUkupnaClanarina.TabIndex = 3
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(27, 61)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(48, 13)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Ukupno:"
        '
        'lblMjesecnaClanarina
        '
        Me.lblMjesecnaClanarina.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblMjesecnaClanarina.Location = New System.Drawing.Point(81, 24)
        Me.lblMjesecnaClanarina.Name = "lblMjesecnaClanarina"
        Me.lblMjesecnaClanarina.Size = New System.Drawing.Size(100, 23)
        Me.lblMjesecnaClanarina.TabIndex = 1
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(19, 32)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(56, 13)
        Me.Label3.TabIndex = 0
        Me.Label3.Text = "Mjesečno:"
        '
        'btnIzracunaj
        '
        Me.btnIzracunaj.BackColor = System.Drawing.Color.DarkSalmon
        Me.btnIzracunaj.ForeColor = System.Drawing.SystemColors.ControlText
        Me.btnIzracunaj.Location = New System.Drawing.Point(25, 365)
        Me.btnIzracunaj.Name = "btnIzracunaj"
        Me.btnIzracunaj.Size = New System.Drawing.Size(75, 23)
        Me.btnIzracunaj.TabIndex = 3
        Me.btnIzracunaj.Text = "&Izračunaj"
        Me.btnIzracunaj.UseVisualStyleBackColor = False
        '
        'btnOcisti
        '
        Me.btnOcisti.BackColor = System.Drawing.Color.Yellow
        Me.btnOcisti.Location = New System.Drawing.Point(81, 398)
        Me.btnOcisti.Name = "btnOcisti"
        Me.btnOcisti.Size = New System.Drawing.Size(75, 23)
        Me.btnOcisti.TabIndex = 4
        Me.btnOcisti.Text = "&Očisti"
        Me.btnOcisti.UseVisualStyleBackColor = False
        '
        'btnIzlaz
        '
        Me.btnIzlaz.BackColor = System.Drawing.Color.YellowGreen
        Me.btnIzlaz.Location = New System.Drawing.Point(137, 427)
        Me.btnIzlaz.Name = "btnIzlaz"
        Me.btnIzlaz.Size = New System.Drawing.Size(75, 23)
        Me.btnIzlaz.TabIndex = 5
        Me.btnIzlaz.Text = "I&zlaz"
        Me.btnIzlaz.UseVisualStyleBackColor = False
        '
        'StatusStrip1
        '
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.lblPoruka})
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 469)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Size = New System.Drawing.Size(611, 22)
        Me.StatusStrip1.TabIndex = 6
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'lblPoruka
        '
        Me.lblPoruka.ForeColor = System.Drawing.Color.Firebrick
        Me.lblPoruka.Name = "lblPoruka"
        Me.lblPoruka.Size = New System.Drawing.Size(0, 17)
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.Fitness_Klub.My.Resources.Resources.Fitness_Klub
        Me.PictureBox1.Location = New System.Drawing.Point(0, -32)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(613, 510)
        Me.PictureBox1.TabIndex = 7
        Me.PictureBox1.TabStop = False
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.Location = New System.Drawing.Point(671, 183)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(200, 20)
        Me.DateTimePicker1.TabIndex = 8
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(611, 491)
        Me.Controls.Add(Me.DateTimePicker1)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Controls.Add(Me.btnIzlaz)
        Me.Controls.Add(Me.btnOcisti)
        Me.Controls.Add(Me.btnIzracunaj)
        Me.Controls.Add(Me.GroupBox4)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.PictureBox1)
        Me.Name = "Form1"
        Me.Text = "Fitness Club"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        Me.StatusStrip1.ResumeLayout(False)
        Me.StatusStrip1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
    Friend WithEvents radStariji As System.Windows.Forms.RadioButton
    Friend WithEvents radStudenti As System.Windows.Forms.RadioButton
    Friend WithEvents radDjeca As System.Windows.Forms.RadioButton
    Friend WithEvents radOdrasli As System.Windows.Forms.RadioButton
    Friend WithEvents chkTrener As System.Windows.Forms.CheckBox
    Friend WithEvents chkKarate As System.Windows.Forms.CheckBox
    Friend WithEvents chkJoga As System.Windows.Forms.CheckBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents btnIzracunaj As System.Windows.Forms.Button
    Friend WithEvents btnOcisti As System.Windows.Forms.Button
    Friend WithEvents btnIzlaz As System.Windows.Forms.Button
    Friend WithEvents txtMjeseci As System.Windows.Forms.TextBox
    Friend WithEvents lblUkupnaClanarina As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents lblMjesecnaClanarina As System.Windows.Forms.Label
    Friend WithEvents StatusStrip1 As System.Windows.Forms.StatusStrip
    Friend WithEvents lblPoruka As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents DateTimePicker1 As DateTimePicker
End Class
