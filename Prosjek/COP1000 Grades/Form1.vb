'Option Strict On
Option Explicit On

Public Class Form1

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Stavlja fokus na polje Aktivnost.
        txtAktivnost.Focus()
    End Sub

    Private Sub btnIzracunaj_Click(sender As Object, e As EventArgs) Handles btnIzracunaj.Click
        ' Deklarisane varijable za proracun ocjene
        Dim intKokolvij As Integer                      ' Bodovi iz kolokvija
        Dim intTest2 As Integer                         ' Bodovi iz test-a 2.
        Dim intAktivnost As Integer                     ' Bodovi iz aktivnosti
        Dim intPredavanje As Integer                    ' Bodovi iz pristustva na predavanju
        Dim intVjezbe As Integer                        ' Bodovi iz pristustva na vjezbama
        Dim intIntegralniIspit As Integer               ' Integralni ispit na popravnom roku
        Dim intSeminarskiRad As Integer                 ' Bodovi iz seminarskog rada

        Dim intMaksimalniBrojBodova As Integer = 100    ' Maksimalan broj bodova
        Dim intBrojOstvarenihBodova As Integer          ' Ukupno ostvarenih bodova
        Dim dblProcenatOcjene As Double                 ' OCjena izrazena u procentima

        Try
            ' Pokusaj citanja vrijednosti iz TextBox-ova
            intKokolvij = CInt(txtKolokvij.Text)
            intTest2 = CInt(txtTest2.Text)
            intAktivnost = CInt(txtAktivnost.Text)
            intPredavanje = CInt(txtPredavanje.Text)
            intVjezbe = CInt(txtVjezbe.Text)
            intIntegralniIspit = CInt(txtIntegralniIspit.Text)
            intSeminarskiRad = CInt(txtSeminarskiRad.Text)

            ' Izracun ukupnog broja bodova
            intBrojOstvarenihBodova = intKokolvij + intTest2 +
                intAktivnost + intPredavanje + intVjezbe +
                intIntegralniIspit + intSeminarskiRad

            ' Racunanje procenta ocjene
            dblProcenatOcjene = intBrojOstvarenihBodova / intMaksimalniBrojBodova

            lblMaksimalniBrojBodova.Text = CStr(intMaksimalniBrojBodova)
            lblUkupnoBodovaOstvareno.Text = CStr(intBrojOstvarenihBodova)

            ' Prikaz procenta ocjene
            lblProcenatOcjene.Text = dblProcenatOcjene.ToString("p")

        Catch
            ' Prikazi poruku o gresci
            MessageBox.Show("Greska: Svi unosi moraju biti numericke vrijednosti.")
        End Try
    End Sub

    Private Sub btnObrisi_Click(sender As Object, e As EventArgs) Handles btnObrisi.Click
        ' Ocisiti sva polja.
        txtKolokvij.Clear()
        txtTest2.Clear()
        txtAktivnost.Clear()
        txtPredavanje.Clear()
        txtVjezbe.Clear()
        txtIntegralniIspit.Clear()
        txtSeminarskiRad.Clear()

        lblMaksimalniBrojBodova.Text = String.Empty
        lblUkupnoBodovaOstvareno.Text = String.Empty
        lblProcenatOcjene.Text = String.Empty


        ' Stavi fokus na Aktivnost.
        txtAktivnost.Focus()
    End Sub

    Private Sub btnIzlaz_Click(sender As Object, e As EventArgs) Handles btnIzlaz.Click
        ' Izlaz iz forme.
        Me.Close()
    End Sub


End Class
