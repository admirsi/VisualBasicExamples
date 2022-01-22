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
        Me.lblPrikaz = New System.Windows.Forms.Label()
        Me.btnZamjeniSlova = New System.Windows.Forms.Button()
        Me.txtZamjenskaSlova = New System.Windows.Forms.TextBox()
        Me.lblPrompt3 = New System.Windows.Forms.Label()
        Me.txtSlovaZaPromijeniti = New System.Windows.Forms.TextBox()
        Me.lblPrompt2 = New System.Windows.Forms.Label()
        Me.txtRijec = New System.Windows.Forms.TextBox()
        Me.lblPrompt1 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblPrikaz
        '
        Me.lblPrikaz.BackColor = System.Drawing.Color.LemonChiffon
        Me.lblPrikaz.Font = New System.Drawing.Font("Microsoft Tai Le", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPrikaz.Location = New System.Drawing.Point(315, 240)
        Me.lblPrikaz.Name = "lblPrikaz"
        Me.lblPrikaz.Size = New System.Drawing.Size(249, 30)
        Me.lblPrikaz.TabIndex = 15
        '
        'btnZamjeniSlova
        '
        Me.btnZamjeniSlova.Font = New System.Drawing.Font("Microsoft Tai Le", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnZamjeniSlova.Location = New System.Drawing.Point(44, 240)
        Me.btnZamjeniSlova.Name = "btnZamjeniSlova"
        Me.btnZamjeniSlova.Size = New System.Drawing.Size(171, 31)
        Me.btnZamjeniSlova.TabIndex = 14
        Me.btnZamjeniSlova.Text = "Zamjeni slova"
        Me.btnZamjeniSlova.UseVisualStyleBackColor = True
        '
        'txtZamjenskaSlova
        '
        Me.txtZamjenskaSlova.Font = New System.Drawing.Font("Microsoft Tai Le", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtZamjenskaSlova.Location = New System.Drawing.Point(395, 150)
        Me.txtZamjenskaSlova.Name = "txtZamjenskaSlova"
        Me.txtZamjenskaSlova.Size = New System.Drawing.Size(169, 28)
        Me.txtZamjenskaSlova.TabIndex = 13
        '
        'lblPrompt3
        '
        Me.lblPrompt3.AutoSize = True
        Me.lblPrompt3.Font = New System.Drawing.Font("Microsoft Tai Le", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPrompt3.Location = New System.Drawing.Point(31, 151)
        Me.lblPrompt3.Name = "lblPrompt3"
        Me.lblPrompt3.Size = New System.Drawing.Size(214, 23)
        Me.lblPrompt3.TabIndex = 12
        Me.lblPrompt3.Text = "Unesite zamjenska slova"
        '
        'txtSlovaZaPromijeniti
        '
        Me.txtSlovaZaPromijeniti.Font = New System.Drawing.Font("Microsoft Tai Le", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSlovaZaPromijeniti.Location = New System.Drawing.Point(395, 106)
        Me.txtSlovaZaPromijeniti.Name = "txtSlovaZaPromijeniti"
        Me.txtSlovaZaPromijeniti.Size = New System.Drawing.Size(169, 28)
        Me.txtSlovaZaPromijeniti.TabIndex = 11
        '
        'lblPrompt2
        '
        Me.lblPrompt2.AutoSize = True
        Me.lblPrompt2.Font = New System.Drawing.Font("Microsoft Tai Le", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPrompt2.Location = New System.Drawing.Point(31, 107)
        Me.lblPrompt2.Name = "lblPrompt2"
        Me.lblPrompt2.Size = New System.Drawing.Size(324, 23)
        Me.lblPrompt2.TabIndex = 10
        Me.lblPrompt2.Text = "Unesite slova koja želite da zamjenite"
        '
        'txtRijec
        '
        Me.txtRijec.Font = New System.Drawing.Font("Microsoft Tai Le", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtRijec.Location = New System.Drawing.Point(395, 66)
        Me.txtRijec.Name = "txtRijec"
        Me.txtRijec.Size = New System.Drawing.Size(169, 28)
        Me.txtRijec.TabIndex = 9
        '
        'lblPrompt1
        '
        Me.lblPrompt1.AutoSize = True
        Me.lblPrompt1.Font = New System.Drawing.Font("Microsoft Tai Le", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPrompt1.Location = New System.Drawing.Point(31, 67)
        Me.lblPrompt1.Name = "lblPrompt1"
        Me.lblPrompt1.Size = New System.Drawing.Size(150, 23)
        Me.lblPrompt1.TabIndex = 8
        Me.lblPrompt1.Text = "Unesite recenicu"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.NovaRijec.My.Resources.Resources.slova
        Me.PictureBox1.Location = New System.Drawing.Point(-4, -9)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(613, 387)
        Me.PictureBox1.TabIndex = 16
        Me.PictureBox1.TabStop = False
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(600, 366)
        Me.Controls.Add(Me.lblPrikaz)
        Me.Controls.Add(Me.btnZamjeniSlova)
        Me.Controls.Add(Me.txtZamjenskaSlova)
        Me.Controls.Add(Me.lblPrompt3)
        Me.Controls.Add(Me.txtSlovaZaPromijeniti)
        Me.Controls.Add(Me.lblPrompt2)
        Me.Controls.Add(Me.txtRijec)
        Me.Controls.Add(Me.lblPrompt1)
        Me.Controls.Add(Me.PictureBox1)
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.Name = "Form1"
        Me.Text = "Nova rijec"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblPrikaz As Label
    Friend WithEvents btnZamjeniSlova As Button
    Friend WithEvents txtZamjenskaSlova As TextBox
    Friend WithEvents lblPrompt3 As Label
    Friend WithEvents txtSlovaZaPromijeniti As TextBox
    Friend WithEvents lblPrompt2 As Label
    Friend WithEvents txtRijec As TextBox
    Friend WithEvents lblPrompt1 As Label
    Friend WithEvents PictureBox1 As PictureBox
End Class
