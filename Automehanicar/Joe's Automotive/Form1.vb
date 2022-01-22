Option Strict On
Option Explicit On

Public Class Form1
    Const decPDV As Decimal = 0.17D                 ' PDV na dijelove
    Const decFILTER_KLIME As Decimal = 26D          ' Cijena zamjene filtera klime
    Const decFILTER_ZRAKA As Decimal = 18D          ' Cijena zamjene filtera zraka
    Const decMOTORNO_ULJE As Decimal = 30D          ' Cijena izmjene motrnog ulja
    Const decULJE_MJENJACA As Decimal = 80D         ' Cijena izmjene ulja mjenjaca
    Const decPREGLED As Decimal = 15D               ' Cijena pregleda vozila
    Const decIZMJENA_KOCNICA As Decimal = 100D      ' Cijena izmjene kocnica
    Const decGEOMETRIJA_TOCKOVA As Decimal = 20D    ' Cijena geometrije tockova

    Private Sub btnIzracunaj_Click(sender As Object, e As EventArgs) Handles btnIzracunaj.Click
        Dim decDijeloviCijena As Decimal            ' Cijena dijelova
        Dim decRadniciSati As Decimal               ' Cijena radnika po satu
        Dim decServisiIRadniciSati As Decimal       ' Ukupno servisa i sati radnika 
        Dim decPDVDijelova As Decimal               ' PDV na dijelove
        Dim decUkupno As Decimal                    ' Ukupno za plati

        If DijeloviCijenaValidni() And RadniciSatiValidni() Then
            ' Dohvaca cijenu dijelova.
            Decimal.TryParse(txtDijeloviCijena.Text, decDijeloviCijena)

            ' Dohvaca radne sate.
            Decimal.TryParse(txtRadniciSati.Text, decRadniciSati)

            ' Dohvaca ukupnu cijenu za servise i radne sate.
            decServisiIRadniciSati = IzmjenaFiltera() + ZamjenaUlja() + OstaloCijena() + CijenaRadnihSati(decRadniciSati)

            ' Dohvaca PDV dijelova
            decPDVDijelova = PDV(decDijeloviCijena)

            ' Dohvaca ukupnu cijenu za naplatiti klijentu.
            decUkupno = UkupnoZaNaplatiti(decServisiIRadniciSati, decDijeloviCijena, decPDVDijelova)

            ' Prikazuje detalje naplate formatirane u KM.
            lblServisiIRadnici.Text = decServisiIRadniciSati.ToString() + " KM"
            lblDijelovi.Text = decDijeloviCijena.ToString() + " KM"
            lblPDVZaDijelove.Text = decPDVDijelova.ToString() + " KM"
            lblZaPlatiti.Text = decUkupno.ToString() + " KM"
        End If

    End Sub

    Private Sub btnOcisti_Click(sender As Object, e As EventArgs) Handles btnOcisti.Click
        ' Ova procedura brise sve unose iz forme i postavlja ih na pocetne vrijednosti.
        OcisitiOdabirZamjeneFiltera()
        OcisitiOdabirZamjeneUlja()
        OcistiOdabirOstalihUsluga()
        OcistiDijeloviIRadnici()
        OcistiNaplatu()
    End Sub

    Private Sub btnIzlaz_Click(sender As Object, e As EventArgs) Handles btnIzlaz.Click
        ' Zatvara formu.
        Me.Close()
    End Sub

    Function DijeloviCijenaValidni() As Boolean
        ' Varijabla koja privremeno cuva vrijednost varijable txtDijeloviCijena.
        Dim decDijeloviPrivremenaVrijednost As Decimal

        ' Pokusaj konvertovati vrijednost koju je unio korisnik u decimalni tip.
        ' Ako se ne moze konvertovati prikazi poruku o gresci i vrati False vrijednost.
        If Not Decimal.TryParse(txtDijeloviCijena.Text, decDijeloviPrivremenaVrijednost) Then
            MessageBox.Show("Unesite brojčanu vrijednost za cijenu dijelova.")
            Return False
        End If


        ' Odredi da li je unesena vrijednost negativna.
        ' Ako jeste, prikazi poruku o gresci i vrati False vrijednost.
        If decDijeloviPrivremenaVrijednost < 0 Then
            MessageBox.Show("Unesite pozitivnu brojčanu vrijednost za cijenu dijelova.")
            Return False
        End If

        ' Ako je vrijednost ispravna vrati True.
        Return True
    End Function

    Function RadniciSatiValidni() As Boolean
        ' Varijabla koja privremeno cuva vrijednost varijable txtRadniciSati
        Dim decRadniciSatiPrivremenaVrijednost As Decimal

        ' Pokusaj konvertovati vrijednost koju je unio korisnik u decimalni tip.
        ' Ako se ne moze konvertovati prikazi poruku o gresci i vrati False vrijednost. 
        If Not Decimal.TryParse(txtRadniciSati.Text, decRadniciSatiPrivremenaVrijednost) Then
            MessageBox.Show("Unesite brojčanu vrijednost za radne sate.")
            Return False
        End If

        ' Odredi da li je unesena vrijednost negativna.
        ' Ako jeste, prikazi poruku o gresci i vrati False vrijednost.
        If decRadniciSatiPrivremenaVrijednost < 0 Then
            MessageBox.Show("Unesite pozitivnu vrijednost za radne sate")
            Return False
        End If

        ' Ako je vrijednost ispravna vrati True.
        Return True
    End Function

    Private Function IzmjenaFiltera() As Decimal
        ' Ova funkcija vraca cijenu izmjene filtera klime i zraka.
        Dim decCijenaIzmjeneFiltera As Decimal = 0D

        If chkFIlterKlime.Checked = True Then
            decCijenaIzmjeneFiltera += decFILTER_KLIME
        End If

        If chkFilterZraka.Checked = True Then
            decCijenaIzmjeneFiltera += decFILTER_ZRAKA
        End If

        Return decCijenaIzmjeneFiltera
    End Function

    Function ZamjenaUlja() As Decimal
        ' Ova funkcija vraca cijenu zamjene ulja motora i mjenjaca.
        Dim decCijenaZamjeneUlja As Decimal = 0D

        If chkMotornoUlje.Checked = True Then
            decCijenaZamjeneUlja += decMOTORNO_ULJE
        End If

        If chkUljeMjenjaca.Checked = True Then
            decCijenaZamjeneUlja += decULJE_MJENJACA
        End If

        Return decCijenaZamjeneUlja
    End Function

    Function OstaloCijena() As Decimal
        ' Ova funkcija vraca cijenu ostalih usluga. 
        Dim decCijenaOstalihUsluga As Decimal = 0D

        If chkPregledVozila.Checked = True Then
            decCijenaOstalihUsluga += decPREGLED
        End If

        If chkIzmjenaKocnica.Checked = True Then
            decCijenaOstalihUsluga += decIZMJENA_KOCNICA
        End If

        If chkGeometrijaTockova.Checked = True Then
            decCijenaOstalihUsluga += decGEOMETRIJA_TOCKOVA
        End If

        Return decCijenaOstalihUsluga
    End Function

    Function CijenaRadnihSati(ByVal decRadniSati As Decimal) As Decimal
        ' Ova funkcija prima vrijednost provedenih sati u radu i vraca cijenu za radne sate.
        Dim decRadniSatiCijena As Decimal
        decRadniSatiCijena = decRadniSati * 20

        ' Vrati cijenu radnih sati.
        Return decRadniSatiCijena
    End Function

    Function PDV(ByVal decDijelovi As Decimal) As Decimal
        ' Ova funkcija prima vrijednost cijene dijelova i vraca uvecanu za PDV.
        Return decDijelovi * decPDV
    End Function

    Function UkupnoZaNaplatiti(ByVal decServisiIRadnici As Decimal,
                          ByVal decDijelovi As Decimal,
                          ByVal decPDVnaDijelove As Decimal) As Decimal
        ' Ova funkcija vraca vrijednost ukupne naplate klijentu.
        Return decServisiIRadnici + decDijelovi + decPDVnaDijelove
    End Function

    Sub OcisitiOdabirZamjeneFiltera()
        ' Ova procedura vraca odabir zamjene filtera na pocetne vrijdnosti.
        chkFIlterKlime.Checked = False
        chkFilterZraka.Checked = False
    End Sub

    Sub OcisitiOdabirZamjeneUlja()
        ' Ova procedura vraca odabir zamjene ulja na pocetne vrijdnosti.
        chkMotornoUlje.Checked = False
        chkUljeMjenjaca.Checked = False
    End Sub

    Sub OcistiOdabirOstalihUsluga()
        ' Ova procedura restuje odabir ostalih usluga.
        chkPregledVozila.Checked = False
        chkIzmjenaKocnica.Checked = False
        chkGeometrijaTockova.Checked = False
    End Sub

    Sub OcistiDijeloviIRadnici()
        ' Ova procedura brise polja cijene dijelova i radnih sati.
        txtDijeloviCijena.Clear()
        txtRadniciSati.Clear()
    End Sub

    Sub OcistiNaplatu()
        ' Ova procedura brise svu naplatu.
        lblServisiIRadnici.Text = String.Empty
        lblDijelovi.Text = String.Empty
        lblPDVZaDijelove.Text = String.Empty
        lblZaPlatiti.Text = String.Empty
    End Sub


End Class
