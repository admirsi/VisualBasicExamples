Option Strict On
Option Explicit On

Public Class Form1

    Private Sub btnIzracunaj_Click(sender As Object, e As EventArgs) Handles btnIzracunaj.Click
        Dim decBaznaClanarina As Decimal           ' Bazna mjesecna clanarina
        Dim decUkupnaClanarina As Decimal          ' Ukupna clanarina
        Dim intMjeseci As Integer                  ' Broj mjeseci
        Dim blnUlazOK As Boolean = True            ' Ispravan unos podataka

        '  Konstante za baznu naplatu.
        Const decODRASLI_NAKNADA As Decimal = 40D
        Const decDJECA_NAKNADA As Decimal = 20D
        Const decSTUDENTI_NAKNADA As Decimal = 25D
        Const decSTARIJI_NAKNADA As Decimal = 30D

        '  Konstante za naplatu dodatnog izbora.
        Const decJOGA_NAKNADA As Decimal = 10D
        Const decKARATE_NAKNADA As Decimal = 30D
        Const decTRENER_NAKNADA As Decimal = 50D

        ' Provjeri i konvertuj broj mjeseci.
        lblPoruka.Text = String.Empty
        If Integer.TryParse(txtMjeseci.Text, intMjeseci) = False Then
            lblPoruka.Text = "Mjeseci moraju biti cijeli broj."
            blnUlazOK = False
        ElseIf intMjeseci < 1 Or intMjeseci > 24 Then
            ' Provjeri broj mjeseci.
            lblPoruka.Text = "Mjeseci moraju biti u rasponu od 1 do 24."
            blnUlazOK = False
        End If

        If blnUlazOK = True Then
            ' Odredi mjesecnu naknadu.
            If radOdrasli.Checked = True Then
                decBaznaClanarina = decODRASLI_NAKNADA
            ElseIf radDjeca.Checked = True Then
                decBaznaClanarina = decDJECA_NAKNADA
            ElseIf radStudenti.Checked = True Then
                decBaznaClanarina = decSTUDENTI_NAKNADA
            ElseIf radStariji.Checked = True Then
                decBaznaClanarina = decSTARIJI_NAKNADA
            End If

            ' Provjeri za dodatne izbore.
            If chkJoga.Checked = True Then
                decBaznaClanarina += decJOGA_NAKNADA
            End If

            If chkKarate.Checked = True Then
                decBaznaClanarina += decKARATE_NAKNADA
            End If

            If chkTrener.Checked = True Then
                decBaznaClanarina += decTRENER_NAKNADA
            End If

            ' Racuna ukupnu clanarinu.
            decUkupnaClanarina = decBaznaClanarina * intMjeseci

            ' Prikazuje naknade korisnika.
            lblMjesecnaClanarina.Text = decBaznaClanarina.ToString() + " KM"
            lblUkupnaClanarina.Text = decUkupnaClanarina.ToString() + " KM"

        End If

    End Sub

    Private Sub btnOcisti_Click(sender As Object, e As EventArgs) Handles btnOcisti.Click
        ' Vraca na pocetne postavke radio dugme, odabrano Odrasli.
        radOdrasli.Checked = True

        ' Odznacava odabir dodatnog izbora.
        chkJoga.Checked = False
        chkKarate.Checked = False
        chkTrener.Checked = False

        ' Brise broj mjeseci.
        txtMjeseci.Clear()

        lblMjesecnaClanarina.Text = String.Empty
        lblUkupnaClanarina.Text = String.Empty
        lblPoruka.Text = String.Empty

        ' Stavlja fokus na txtMjeseci.
        txtMjeseci.Focus()
    End Sub

    Private Sub btnIzlaz_Click(sender As Object, e As EventArgs) Handles btnIzlaz.Click
        ' Zatvara formu.
        Me.Close()
    End Sub

End Class
