Option Strict On
Option Explicit On

Public Class Form1

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Dohvati trenutni datum i prikazi.
        lblDanasnjiDatum.Text = Now.ToString("D")

        ' Dohvati trenutno vrijeme i prikazi.
        lblVrijeme.Text = Now.ToString("T")

        ' Stavi fokus na broj nocenja.
        txtBrojNocenja.Select()
    End Sub

    Private Sub btnIzračunaj_Click(sender As Object, e As EventArgs) Handles btnIzračunaj.Click
        ' Varijable za racunanje troskova nocenja
        Dim decCijenaNocenja As Decimal             ' Ukupna cijena nocenja
        Dim decOstaleUsluge As Decimal              ' Naplata ostalih usluga
        Dim decUkupno As Decimal                    ' Ukupna cijena
        Dim decPDV As Decimal                       ' PDV
        Dim decZaPlatiti As Decimal                 ' Ukupno za platiti
        Const decPDVVrijednost As Decimal = 0.17D   ' PDV Vrijednost 

        Try
            ' Izracunaj cijenu nocenja i prikazi.
            decCijenaNocenja = CDec(txtBrojNocenja.Text) *
                CDec(txtCijenaNocenja.Text)
            lblNocenja.Text = decCijenaNocenja.ToString() + " KM"

            ' Izracunaj ostale usluge i prikazi.
            decOstaleUsluge = CDec(txtSobnaDostava.Text) +
                CDec(txtTVInternet.Text) +
                CDec(txtOstalo.Text)
            lblOstaleUsluge.Text = decOstaleUsluge.ToString() + " KM"

            ' Izracunaj ukupno troskve i prikazi.
            decUkupno = decCijenaNocenja + decOstaleUsluge
            lblUkupno.Text = decUkupno.ToString() + " KM"

            ' Calculate and display the tax. ' Izracunaj PDV i prikazi.
            decPDV = decUkupno * decPDVVrijednost
            lblPDV.Text = decPDV.ToString() + " KM"

            ' Izracunaj ukupno za platiti i prikazi.
            decZaPlatiti = decUkupno + decPDV
            lblZaPlatiti.Text = decZaPlatiti.ToString() + " KM"
        Catch
            ' Poruka o gresci
            MessageBox.Show("Svi unosi moraju biti numeričke vrijednosti.")
        End Try
    End Sub

    Private Sub btnOcisti_Click(sender As Object, e As EventArgs) Handles btnOcisti.Click
        ' Obrisi podatke o nocenju.
        txtBrojNocenja.Clear()
        txtCijenaNocenja.Clear()

        ' Obrisi ostale usluge.
        txtSobnaDostava.Clear()
        txtTVInternet.Clear()
        txtOstalo.Clear()

        ' Obrisi polja placanja.
        lblNocenja.Text = String.Empty
        lblOstaleUsluge.Text = String.Empty
        lblUkupno.Text = String.Empty
        lblPDV.Text = String.Empty
        lblZaPlatiti.Text = String.Empty

        ' Dohvati trenutni datum i prikazi.
        lblDanasnjiDatum.Text = Now.ToString("D")

        ' Dohvati trenutno vrijeme i prikazi.
        lblVrijeme.Text = Now.ToString("T")

        ' Stavi fokus na broj nocenja.
        txtBrojNocenja.Focus()
    End Sub

    Private Sub btnIzlaz_Click(sender As Object, e As EventArgs) Handles btnIzlaz.Click
        ' Zatvori formu.
        Me.Close()
    End Sub


End Class
