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
        Me.btnBingoIzvlacenje = New System.Windows.Forms.Button()
        Me.btnNajveciBroj = New System.Windows.Forms.Button()
        Me.btnNajmanjBroj = New System.Windows.Forms.Button()
        Me.lstBingoBrojevi = New System.Windows.Forms.ListBox()
        Me.lblNajveciBroj = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.lblNajmanjiBroj = New System.Windows.Forms.Label()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnBingoIzvlacenje
        '
        Me.btnBingoIzvlacenje.BackColor = System.Drawing.Color.YellowGreen
        Me.btnBingoIzvlacenje.Font = New System.Drawing.Font("Showcard Gothic", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBingoIzvlacenje.ForeColor = System.Drawing.SystemColors.ControlText
        Me.btnBingoIzvlacenje.Location = New System.Drawing.Point(143, 24)
        Me.btnBingoIzvlacenje.Margin = New System.Windows.Forms.Padding(2)
        Me.btnBingoIzvlacenje.Name = "btnBingoIzvlacenje"
        Me.btnBingoIzvlacenje.Size = New System.Drawing.Size(169, 38)
        Me.btnBingoIzvlacenje.TabIndex = 0
        Me.btnBingoIzvlacenje.Text = "Bingo izvlačenje"
        Me.btnBingoIzvlacenje.UseVisualStyleBackColor = False
        '
        'btnNajveciBroj
        '
        Me.btnNajveciBroj.BackColor = System.Drawing.Color.SkyBlue
        Me.btnNajveciBroj.Font = New System.Drawing.Font("Lucida Handwriting", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnNajveciBroj.Location = New System.Drawing.Point(435, 93)
        Me.btnNajveciBroj.Margin = New System.Windows.Forms.Padding(2)
        Me.btnNajveciBroj.Name = "btnNajveciBroj"
        Me.btnNajveciBroj.Size = New System.Drawing.Size(169, 33)
        Me.btnNajveciBroj.TabIndex = 1
        Me.btnNajveciBroj.Text = "Najveći broj"
        Me.btnNajveciBroj.UseVisualStyleBackColor = False
        '
        'btnNajmanjBroj
        '
        Me.btnNajmanjBroj.BackColor = System.Drawing.Color.Goldenrod
        Me.btnNajmanjBroj.Font = New System.Drawing.Font("Lucida Handwriting", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnNajmanjBroj.Location = New System.Drawing.Point(435, 153)
        Me.btnNajmanjBroj.Margin = New System.Windows.Forms.Padding(2)
        Me.btnNajmanjBroj.Name = "btnNajmanjBroj"
        Me.btnNajmanjBroj.Size = New System.Drawing.Size(169, 33)
        Me.btnNajmanjBroj.TabIndex = 2
        Me.btnNajmanjBroj.Text = "Najmanji broj"
        Me.btnNajmanjBroj.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnNajmanjBroj.UseVisualStyleBackColor = False
        '
        'lstBingoBrojevi
        '
        Me.lstBingoBrojevi.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lstBingoBrojevi.BackColor = System.Drawing.Color.Beige
        Me.lstBingoBrojevi.Font = New System.Drawing.Font("Brush Script MT", 15.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lstBingoBrojevi.FormattingEnabled = True
        Me.lstBingoBrojevi.ItemHeight = 26
        Me.lstBingoBrojevi.Location = New System.Drawing.Point(269, 93)
        Me.lstBingoBrojevi.Margin = New System.Windows.Forms.Padding(2)
        Me.lstBingoBrojevi.Name = "lstBingoBrojevi"
        Me.lstBingoBrojevi.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.lstBingoBrojevi.Size = New System.Drawing.Size(43, 264)
        Me.lstBingoBrojevi.TabIndex = 3
        '
        'lblNajveciBroj
        '
        Me.lblNajveciBroj.AutoSize = True
        Me.lblNajveciBroj.BackColor = System.Drawing.Color.Turquoise
        Me.lblNajveciBroj.Font = New System.Drawing.Font("Segoe Print", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNajveciBroj.Location = New System.Drawing.Point(429, 268)
        Me.lblNajveciBroj.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblNajveciBroj.Name = "lblNajveciBroj"
        Me.lblNajveciBroj.Size = New System.Drawing.Size(0, 33)
        Me.lblNajveciBroj.TabIndex = 4
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.Bingo.My.Resources.Resources.Bingo
        Me.PictureBox1.Location = New System.Drawing.Point(-6, -6)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(739, 422)
        Me.PictureBox1.TabIndex = 5
        Me.PictureBox1.TabStop = False
        '
        'lblNajmanjiBroj
        '
        Me.lblNajmanjiBroj.AutoSize = True
        Me.lblNajmanjiBroj.BackColor = System.Drawing.Color.Gold
        Me.lblNajmanjiBroj.Font = New System.Drawing.Font("Segoe Print", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNajmanjiBroj.Location = New System.Drawing.Point(429, 322)
        Me.lblNajmanjiBroj.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblNajmanjiBroj.Name = "lblNajmanjiBroj"
        Me.lblNajmanjiBroj.Size = New System.Drawing.Size(0, 33)
        Me.lblNajmanjiBroj.TabIndex = 6
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(730, 411)
        Me.Controls.Add(Me.lblNajmanjiBroj)
        Me.Controls.Add(Me.lblNajveciBroj)
        Me.Controls.Add(Me.lstBingoBrojevi)
        Me.Controls.Add(Me.btnNajmanjBroj)
        Me.Controls.Add(Me.btnNajveciBroj)
        Me.Controls.Add(Me.btnBingoIzvlacenje)
        Me.Controls.Add(Me.PictureBox1)
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.Name = "Form1"
        Me.Text = "Bingo Izvacenje"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnBingoIzvlacenje As Button
    Friend WithEvents btnNajveciBroj As Button
    Friend WithEvents btnNajmanjBroj As Button
    Friend WithEvents lstBingoBrojevi As ListBox
    Friend WithEvents lblNajveciBroj As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents lblNajmanjiBroj As Label
End Class
