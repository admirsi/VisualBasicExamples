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
        Me.txtBrojMjeseci = New System.Windows.Forms.TextBox()
        Me.txtIznosOtplate = New System.Windows.Forms.TextBox()
        Me.txtCijenaVozila = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.radPolovnoVozilo = New System.Windows.Forms.RadioButton()
        Me.radNovoVozilo = New System.Windows.Forms.RadioButton()
        Me.lblaKamatnaStopaProcenat = New System.Windows.Forms.Label()
        Me.lblGodisnjaKamatnaStopa = New System.Windows.Forms.Label()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.lstPrikaz = New System.Windows.Forms.ListBox()
        Me.lblPoruka = New System.Windows.Forms.Label()
        Me.btnIzracunaj = New System.Windows.Forms.Button()
        Me.btnOcisti = New System.Windows.Forms.Button()
        Me.btnIzlaz = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.GroupBox1.Controls.Add(Me.txtBrojMjeseci)
        Me.GroupBox1.Controls.Add(Me.txtIznosOtplate)
        Me.GroupBox1.Controls.Add(Me.txtCijenaVozila)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Tai Le", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(553, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(305, 159)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Informacije o plaćanju"
        '
        'txtBrojMjeseci
        '
        Me.txtBrojMjeseci.Location = New System.Drawing.Point(172, 118)
        Me.txtBrojMjeseci.Name = "txtBrojMjeseci"
        Me.txtBrojMjeseci.Size = New System.Drawing.Size(100, 28)
        Me.txtBrojMjeseci.TabIndex = 5
        '
        'txtIznosOtplate
        '
        Me.txtIznosOtplate.Location = New System.Drawing.Point(172, 75)
        Me.txtIznosOtplate.Name = "txtIznosOtplate"
        Me.txtIznosOtplate.Size = New System.Drawing.Size(100, 28)
        Me.txtIznosOtplate.TabIndex = 4
        '
        'txtCijenaVozila
        '
        Me.txtCijenaVozila.Location = New System.Drawing.Point(172, 37)
        Me.txtCijenaVozila.Name = "txtCijenaVozila"
        Me.txtCijenaVozila.Size = New System.Drawing.Size(100, 28)
        Me.txtCijenaVozila.TabIndex = 3
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(18, 121)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(97, 21)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Broj mjeseci:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(18, 78)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(115, 21)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Iznos pretplate:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(18, 40)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(100, 21)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Cijena vozila:"
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.GroupBox2.Controls.Add(Me.radPolovnoVozilo)
        Me.GroupBox2.Controls.Add(Me.radNovoVozilo)
        Me.GroupBox2.Controls.Add(Me.lblaKamatnaStopaProcenat)
        Me.GroupBox2.Controls.Add(Me.lblGodisnjaKamatnaStopa)
        Me.GroupBox2.Font = New System.Drawing.Font("Microsoft Tai Le", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.Location = New System.Drawing.Point(12, 400)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(355, 148)
        Me.GroupBox2.TabIndex = 1
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Informacije o vozilu"
        '
        'radPolovnoVozilo
        '
        Me.radPolovnoVozilo.AutoSize = True
        Me.radPolovnoVozilo.Location = New System.Drawing.Point(9, 67)
        Me.radPolovnoVozilo.Name = "radPolovnoVozilo"
        Me.radPolovnoVozilo.Size = New System.Drawing.Size(130, 25)
        Me.radPolovnoVozilo.TabIndex = 3
        Me.radPolovnoVozilo.TabStop = True
        Me.radPolovnoVozilo.Text = "Polovno vozilo"
        Me.radPolovnoVozilo.UseVisualStyleBackColor = True
        '
        'radNovoVozilo
        '
        Me.radNovoVozilo.AutoSize = True
        Me.radNovoVozilo.Location = New System.Drawing.Point(9, 36)
        Me.radNovoVozilo.Name = "radNovoVozilo"
        Me.radNovoVozilo.Size = New System.Drawing.Size(111, 25)
        Me.radNovoVozilo.TabIndex = 2
        Me.radNovoVozilo.TabStop = True
        Me.radNovoVozilo.Text = "Novo vozilo"
        Me.radNovoVozilo.UseVisualStyleBackColor = True
        '
        'lblaKamatnaStopaProcenat
        '
        Me.lblaKamatnaStopaProcenat.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblaKamatnaStopaProcenat.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblaKamatnaStopaProcenat.Location = New System.Drawing.Point(210, 115)
        Me.lblaKamatnaStopaProcenat.Name = "lblaKamatnaStopaProcenat"
        Me.lblaKamatnaStopaProcenat.Size = New System.Drawing.Size(51, 22)
        Me.lblaKamatnaStopaProcenat.TabIndex = 4
        '
        'lblGodisnjaKamatnaStopa
        '
        Me.lblGodisnjaKamatnaStopa.AutoSize = True
        Me.lblGodisnjaKamatnaStopa.Location = New System.Drawing.Point(6, 115)
        Me.lblGodisnjaKamatnaStopa.Name = "lblGodisnjaKamatnaStopa"
        Me.lblGodisnjaKamatnaStopa.Size = New System.Drawing.Size(177, 21)
        Me.lblGodisnjaKamatnaStopa.TabIndex = 3
        Me.lblGodisnjaKamatnaStopa.Text = "Godišnja kamatna stopa"
        '
        'GroupBox3
        '
        Me.GroupBox3.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.GroupBox3.Controls.Add(Me.lstPrikaz)
        Me.GroupBox3.Font = New System.Drawing.Font("Microsoft Tai Le", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox3.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(489, 357)
        Me.GroupBox3.TabIndex = 2
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Rate i kamatne stope"
        '
        'lstPrikaz
        '
        Me.lstPrikaz.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.lstPrikaz.Font = New System.Drawing.Font("Microsoft Tai Le", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lstPrikaz.FormattingEnabled = True
        Me.lstPrikaz.ItemHeight = 19
        Me.lstPrikaz.Location = New System.Drawing.Point(10, 21)
        Me.lstPrikaz.Name = "lstPrikaz"
        Me.lstPrikaz.Size = New System.Drawing.Size(473, 308)
        Me.lstPrikaz.TabIndex = 0
        '
        'lblPoruka
        '
        Me.lblPoruka.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.lblPoruka.Font = New System.Drawing.Font("Microsoft Tai Le", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPoruka.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lblPoruka.Location = New System.Drawing.Point(553, 190)
        Me.lblPoruka.Name = "lblPoruka"
        Me.lblPoruka.Size = New System.Drawing.Size(305, 29)
        Me.lblPoruka.TabIndex = 5
        '
        'btnIzracunaj
        '
        Me.btnIzracunaj.BackColor = System.Drawing.Color.LightSteelBlue
        Me.btnIzracunaj.Font = New System.Drawing.Font("Microsoft Tai Le", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnIzracunaj.Location = New System.Drawing.Point(768, 330)
        Me.btnIzracunaj.Name = "btnIzracunaj"
        Me.btnIzracunaj.Size = New System.Drawing.Size(90, 39)
        Me.btnIzracunaj.TabIndex = 6
        Me.btnIzracunaj.Text = "Izračunaj"
        Me.btnIzracunaj.UseVisualStyleBackColor = False
        '
        'btnOcisti
        '
        Me.btnOcisti.BackColor = System.Drawing.SystemColors.MenuBar
        Me.btnOcisti.Font = New System.Drawing.Font("Microsoft Tai Le", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnOcisti.Location = New System.Drawing.Point(768, 400)
        Me.btnOcisti.Name = "btnOcisti"
        Me.btnOcisti.Size = New System.Drawing.Size(90, 39)
        Me.btnOcisti.TabIndex = 7
        Me.btnOcisti.Text = "Očisti"
        Me.btnOcisti.UseVisualStyleBackColor = False
        '
        'btnIzlaz
        '
        Me.btnIzlaz.BackColor = System.Drawing.SystemColors.MenuBar
        Me.btnIzlaz.Font = New System.Drawing.Font("Microsoft Tai Le", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnIzlaz.Location = New System.Drawing.Point(768, 467)
        Me.btnIzlaz.Name = "btnIzlaz"
        Me.btnIzlaz.Size = New System.Drawing.Size(90, 39)
        Me.btnIzlaz.TabIndex = 8
        Me.btnIzlaz.Text = "Izlaz"
        Me.btnIzlaz.UseVisualStyleBackColor = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.AutoLizing.My.Resources.Resources.AutoLizing
        Me.PictureBox1.Location = New System.Drawing.Point(-5, -1)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(912, 611)
        Me.PictureBox1.TabIndex = 9
        Me.PictureBox1.TabStop = False
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(894, 599)
        Me.Controls.Add(Me.btnIzlaz)
        Me.Controls.Add(Me.btnOcisti)
        Me.Controls.Add(Me.btnIzracunaj)
        Me.Controls.Add(Me.lblPoruka)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.PictureBox1)
        Me.Name = "Form1"
        Me.Text = "Auto Lizing"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents txtBrojMjeseci As System.Windows.Forms.TextBox
    Friend WithEvents txtIznosOtplate As System.Windows.Forms.TextBox
    Friend WithEvents txtCijenaVozila As System.Windows.Forms.TextBox
    Friend WithEvents radPolovnoVozilo As System.Windows.Forms.RadioButton
    Friend WithEvents radNovoVozilo As System.Windows.Forms.RadioButton
    Friend WithEvents lstPrikaz As System.Windows.Forms.ListBox
    Friend WithEvents lblGodisnjaKamatnaStopa As System.Windows.Forms.Label
    Friend WithEvents lblaKamatnaStopaProcenat As System.Windows.Forms.Label
    Friend WithEvents lblPoruka As System.Windows.Forms.Label
    Friend WithEvents btnIzracunaj As System.Windows.Forms.Button
    Friend WithEvents btnOcisti As System.Windows.Forms.Button
    Friend WithEvents btnIzlaz As System.Windows.Forms.Button
    Friend WithEvents PictureBox1 As PictureBox
End Class
