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
        Me.radVelika = New System.Windows.Forms.RadioButton()
        Me.radMala = New System.Windows.Forms.RadioButton()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.chkSudzuka = New System.Windows.Forms.CheckBox()
        Me.chkPaprika = New System.Windows.Forms.CheckBox()
        Me.chkMasline = New System.Windows.Forms.CheckBox()
        Me.chkGljive = New System.Windows.Forms.CheckBox()
        Me.btnNaruci = New System.Windows.Forms.Button()
        Me.lblBrojNarudzbe = New System.Windows.Forms.Label()
        Me.lblZaPlatiti = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.Salmon
        Me.GroupBox1.Controls.Add(Me.radVelika)
        Me.GroupBox1.Controls.Add(Me.radMala)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft YaHei", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(87, 122)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(209, 86)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Odaberite veličinu"
        '
        'radVelika
        '
        Me.radVelika.AutoSize = True
        Me.radVelika.Location = New System.Drawing.Point(118, 40)
        Me.radVelika.Name = "radVelika"
        Me.radVelika.Size = New System.Drawing.Size(74, 25)
        Me.radVelika.TabIndex = 1
        Me.radVelika.TabStop = True
        Me.radVelika.Text = "Velika"
        Me.radVelika.UseVisualStyleBackColor = True
        '
        'radMala
        '
        Me.radMala.AutoSize = True
        Me.radMala.Location = New System.Drawing.Point(14, 39)
        Me.radMala.Name = "radMala"
        Me.radMala.Size = New System.Drawing.Size(66, 25)
        Me.radMala.TabIndex = 0
        Me.radMala.TabStop = True
        Me.radMala.Text = "Mala"
        Me.radMala.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.Color.PapayaWhip
        Me.GroupBox2.Controls.Add(Me.chkSudzuka)
        Me.GroupBox2.Controls.Add(Me.chkPaprika)
        Me.GroupBox2.Controls.Add(Me.chkMasline)
        Me.GroupBox2.Controls.Add(Me.chkGljive)
        Me.GroupBox2.Font = New System.Drawing.Font("Microsoft YaHei", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.Location = New System.Drawing.Point(349, 122)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(190, 163)
        Me.GroupBox2.TabIndex = 1
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Odaberite dodatke"
        '
        'chkSudzuka
        '
        Me.chkSudzuka.AutoSize = True
        Me.chkSudzuka.Location = New System.Drawing.Point(11, 123)
        Me.chkSudzuka.Name = "chkSudzuka"
        Me.chkSudzuka.Size = New System.Drawing.Size(94, 25)
        Me.chkSudzuka.TabIndex = 3
        Me.chkSudzuka.Text = "Sudžuka"
        Me.chkSudzuka.UseVisualStyleBackColor = True
        '
        'chkPaprika
        '
        Me.chkPaprika.AutoSize = True
        Me.chkPaprika.Location = New System.Drawing.Point(11, 92)
        Me.chkPaprika.Name = "chkPaprika"
        Me.chkPaprika.Size = New System.Drawing.Size(86, 25)
        Me.chkPaprika.TabIndex = 2
        Me.chkPaprika.Text = "Paprika"
        Me.chkPaprika.UseVisualStyleBackColor = True
        '
        'chkMasline
        '
        Me.chkMasline.AutoSize = True
        Me.chkMasline.Location = New System.Drawing.Point(11, 59)
        Me.chkMasline.Name = "chkMasline"
        Me.chkMasline.Size = New System.Drawing.Size(88, 25)
        Me.chkMasline.TabIndex = 1
        Me.chkMasline.Text = "Masline"
        Me.chkMasline.UseVisualStyleBackColor = True
        '
        'chkGljive
        '
        Me.chkGljive.AutoSize = True
        Me.chkGljive.Location = New System.Drawing.Point(11, 28)
        Me.chkGljive.Name = "chkGljive"
        Me.chkGljive.Size = New System.Drawing.Size(70, 25)
        Me.chkGljive.TabIndex = 0
        Me.chkGljive.Text = "Gljive"
        Me.chkGljive.UseVisualStyleBackColor = True
        '
        'btnNaruci
        '
        Me.btnNaruci.BackColor = System.Drawing.Color.YellowGreen
        Me.btnNaruci.Font = New System.Drawing.Font("Microsoft YaHei", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnNaruci.Location = New System.Drawing.Point(87, 251)
        Me.btnNaruci.Name = "btnNaruci"
        Me.btnNaruci.Size = New System.Drawing.Size(101, 34)
        Me.btnNaruci.TabIndex = 2
        Me.btnNaruci.Text = "Naruči"
        Me.btnNaruci.UseVisualStyleBackColor = False
        '
        'lblBrojNarudzbe
        '
        Me.lblBrojNarudzbe.Font = New System.Drawing.Font("Microsoft YaHei", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblBrojNarudzbe.Location = New System.Drawing.Point(83, 324)
        Me.lblBrojNarudzbe.Name = "lblBrojNarudzbe"
        Me.lblBrojNarudzbe.Size = New System.Drawing.Size(183, 23)
        Me.lblBrojNarudzbe.TabIndex = 3
        '
        'lblZaPlatiti
        '
        Me.lblZaPlatiti.BackColor = System.Drawing.Color.Gainsboro
        Me.lblZaPlatiti.Font = New System.Drawing.Font("Microsoft YaHei", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblZaPlatiti.Location = New System.Drawing.Point(82, 381)
        Me.lblZaPlatiti.Name = "lblZaPlatiti"
        Me.lblZaPlatiti.Size = New System.Drawing.Size(275, 23)
        Me.lblZaPlatiti.TabIndex = 4
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.Pizza.My.Resources.Resources.Pizza
        Me.PictureBox1.Location = New System.Drawing.Point(-4, -5)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(675, 495)
        Me.PictureBox1.TabIndex = 5
        Me.PictureBox1.TabStop = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.IndianRed
        Me.Label1.Font = New System.Drawing.Font("Jokerman", 26.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(198, 32)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(223, 51)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = "Pizza Party"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(660, 476)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.lblZaPlatiti)
        Me.Controls.Add(Me.lblBrojNarudzbe)
        Me.Controls.Add(Me.btnNaruci)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.PictureBox1)
        Me.Name = "Form1"
        Me.Text = "Pizza party"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents radVelika As RadioButton
    Friend WithEvents radMala As RadioButton
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents chkSudzuka As CheckBox
    Friend WithEvents chkPaprika As CheckBox
    Friend WithEvents chkMasline As CheckBox
    Friend WithEvents chkGljive As CheckBox
    Friend WithEvents btnNaruci As Button
    Friend WithEvents lblBrojNarudzbe As Label
    Friend WithEvents lblZaPlatiti As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label1 As Label
End Class
