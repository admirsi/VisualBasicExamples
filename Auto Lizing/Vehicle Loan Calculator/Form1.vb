Option Strict On
Option Explicit On

Public Class Form1

    Const dblMJESECI_GODISNJE As Double = 12        ' Mjesci u godini
    Const dblNOVA_KAMATA As Double = 0.05           ' Kamatna stopa, nova auta
    Const dblPOLOVNA_KAMATA As Double = 0.08        ' Kamatna stopa, polovna auta

    Dim dblGodisnjaKamata As Double = dblNOVA_KAMATA    ' Varijabla cuva vrijednost godisnje kamatne stope

    Private Sub btnIzracunaj_Click(sender As Object, e As EventArgs) Handles btnIzracunaj.Click
        Dim dblCijenaVozila As Double               ' Cijena vozila
        Dim dblPretplata As Double                  ' Pretplata
        Dim intMjeseciZajma As Integer              ' Broj mjeseci za pozajmicu
        Dim dblPozajmica As Double                  ' Visina pozajmice
        Dim dblMjesecnaPlacanja As Double           ' Mjesecno placanje
        Dim dblKamata As Double                     ' Kamata za period zajma
        Dim dblGlavnica As Double                   ' Glavnica za period zajma
        Dim intBrojac As Integer                    ' Brojac za petlju
        Dim strPrikaz As String                     ' String za prikaz korisniku
        Dim blnUlazOk As Boolean = True             ' Varijabla za provjeru ulaznih vrijednosti

        ' Dohvati cijenu vozila i provjeri ispravnost podatka. 
        If Not Double.TryParse(txtCijenaVozila.Text, dblCijenaVozila) Then
            lblPoruka.Text = " Cijena vozila mora biti numericka vrijednost."
            blnUlazOk = False
        End If

        ' Dohvati pretplatu i provjeri ispravnost podatka.
        If Not Double.TryParse(txtIznosOtplate.Text, dblPretplata) Then
            lblPoruka.Text = "Pretplata mora biti numericka vrijednost."
            blnUlazOk = False
        End If

        ' Dohvati broj mjeseci i provjeri ispravnost podatka.
        If Not Integer.TryParse(txtBrojMjeseci.Text, intMjeseciZajma) Then
            lblPoruka.Text = "Mjeseci moraju biti numericka vrijednost."
            blnUlazOk = False
        End If

        If blnUlazOk = True Then
            ' Izracunaj visinu zajma i mjesecna placanja.
            dblPozajmica = dblCijenaVozila - dblPretplata
            dblMjesecnaPlacanja = Pmt(dblGodisnjaKamata / dblMJESECI_GODISNJE,
                                    intMjeseciZajma, -dblPozajmica)

            ' Ocisti prikaz i poruke o gresci.
            lstPrikaz.Items.Clear()
            lblPoruka.Text = String.Empty

            For intBrojac = 1 To intMjeseciZajma
                ' Izracunaj kamatu za period zajma.
                dblKamata = IPmt(dblGodisnjaKamata / dblMJESECI_GODISNJE,
                                   intBrojac, intMjeseciZajma, -dblPozajmica)

                ' Izracunaj glavnicu za period zajma.
                dblGlavnica = PPmt(dblGodisnjaKamata / dblMJESECI_GODISNJE,
                                    intBrojac, intMjeseciZajma, -dblPozajmica)

                ' Napravi String za prikaz otplate.
                strPrikaz = "Mjesec " & intBrojac.ToString()

                strPrikaz &= ": rata = " & dblMjesecnaPlacanja.ToString("n2")

                strPrikaz &= ", kamata = " & dblKamata.ToString("n2")

                strPrikaz &= ", glavnica = " & dblGlavnica.ToString("n2")


                ' Dodaj string na prikaz.
                lstPrikaz.Items.Add(strPrikaz)
            Next
        End If
    End Sub

    Private Sub btnOcisti_Click(sender As Object, e As EventArgs) Handles btnOcisti.Click
        ' Ocisiti formu, stavi pocetne vrijednosti 

        radNovoVozilo.Checked = True
        dblGodisnjaKamata = dblNOVA_KAMATA
        lblaKamatnaStopaProcenat.Text = dblNOVA_KAMATA.ToString()
        txtCijenaVozila.Clear()
        txtIznosOtplate.Clear()
        txtBrojMjeseci.Clear()
        lstPrikaz.Items.Clear()
        lblPoruka.Text = String.Empty

        ' Stavi fokus na txtCijenuVozila
        txtCijenaVozila.Focus()
    End Sub

    Private Sub btnIzlaz_Click(sender As Object, e As EventArgs) Handles btnIzlaz.Click
        ' Zatvori formu.
        Me.Close()
    End Sub

    Private Sub radNovoVozilo_CheckedChanged(sender As Object, e As EventArgs) Handles radNovoVozilo.CheckedChanged
        ' Ako je odabrano novo vozilo, korisnik odabire kamatnu stopu za novo vozilo.
        If radNovoVozilo.Checked = True Then
            dblGodisnjaKamata = dblNOVA_KAMATA
            lblaKamatnaStopaProcenat.Text = dblNOVA_KAMATA.ToString()
            lstPrikaz.Items.Clear()
        End If
    End Sub

    Private Sub radPolovnoVozilo_CheckedChanged(sender As Object, e As EventArgs) Handles radPolovnoVozilo.CheckedChanged
        ' Ako je odabrano polovno vozilo, korisnik odabire kamatnu stopu za polovno vozilo.
        If radPolovnoVozilo.Checked = True Then
            dblGodisnjaKamata = dblPOLOVNA_KAMATA
            lblaKamatnaStopaProcenat.Text = dblPOLOVNA_KAMATA.ToString()
            lstPrikaz.Items.Clear()
        End If
    End Sub


End Class