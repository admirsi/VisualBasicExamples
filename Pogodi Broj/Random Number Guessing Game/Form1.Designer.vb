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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnPogodi = New System.Windows.Forms.Button()
        Me.btnIzlaz = New System.Windows.Forms.Button()
        Me.BackgroundWorker1 = New System.ComponentModel.BackgroundWorker()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.lblBrojPogadjanja = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Gold
        Me.Label1.Font = New System.Drawing.Font("Monotype Corsiva", 26.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(18, 76)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(710, 43)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Pogodi broj od 1 do 100. Klikni ""Pogodi"" za početak igre."
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btnPogodi
        '
        Me.btnPogodi.BackColor = System.Drawing.Color.YellowGreen
        Me.btnPogodi.Font = New System.Drawing.Font("Monotype Corsiva", 26.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPogodi.Location = New System.Drawing.Point(120, 267)
        Me.btnPogodi.Name = "btnPogodi"
        Me.btnPogodi.Size = New System.Drawing.Size(221, 55)
        Me.btnPogodi.TabIndex = 2
        Me.btnPogodi.Text = "Pogodi broj"
        Me.btnPogodi.UseVisualStyleBackColor = False
        '
        'btnIzlaz
        '
        Me.btnIzlaz.BackColor = System.Drawing.Color.DarkOrange
        Me.btnIzlaz.Font = New System.Drawing.Font("Monotype Corsiva", 26.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnIzlaz.Location = New System.Drawing.Point(621, 484)
        Me.btnIzlaz.Name = "btnIzlaz"
        Me.btnIzlaz.Size = New System.Drawing.Size(107, 60)
        Me.btnIzlaz.TabIndex = 3
        Me.btnIzlaz.Text = "Izlaz"
        Me.btnIzlaz.UseVisualStyleBackColor = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Khaki
        Me.Label3.Font = New System.Drawing.Font("Monotype Corsiva", 27.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(112, 180)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(229, 45)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Broj pogađanja:"
        '
        'lblBrojPogadjanja
        '
        Me.lblBrojPogadjanja.BackColor = System.Drawing.Color.Gold
        Me.lblBrojPogadjanja.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblBrojPogadjanja.Font = New System.Drawing.Font("Monotype Corsiva", 21.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblBrojPogadjanja.Location = New System.Drawing.Point(379, 176)
        Me.lblBrojPogadjanja.Name = "lblBrojPogadjanja"
        Me.lblBrojPogadjanja.Size = New System.Drawing.Size(58, 49)
        Me.lblBrojPogadjanja.TabIndex = 3
        Me.lblBrojPogadjanja.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.PogodiBroj.My.Resources.Resources.PogodiBroj
        Me.PictureBox1.Location = New System.Drawing.Point(-3, -23)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(760, 596)
        Me.PictureBox1.TabIndex = 4
        Me.PictureBox1.TabStop = False
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(752, 568)
        Me.Controls.Add(Me.lblBrojPogadjanja)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.btnIzlaz)
        Me.Controls.Add(Me.btnPogodi)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.PictureBox1)
        Me.Name = "Form1"
        Me.Text = "Pogodi broj"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents btnPogodi As System.Windows.Forms.Button
    Friend WithEvents btnIzlaz As System.Windows.Forms.Button
    Friend WithEvents BackgroundWorker1 As System.ComponentModel.BackgroundWorker
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents lblBrojPogadjanja As System.Windows.Forms.Label
    Friend WithEvents PictureBox1 As PictureBox
End Class
