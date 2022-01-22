Option Strict On
Option Explicit On

Public Class Form1

    Const decPDV As Decimal = 0.17D             ' PDV
    Const decBIJELA_VEKNA As Decimal = 1.3D     ' Cijena bijele vekne 
    Const decINTEGRALNA As Decimal = 1.5D       ' Cijena integralne vekne
    Const decKREMASTI_SIR As Decimal = 0.5D     ' Cijena namza kremastog sira
    Const decMASLAC As Decimal = 0.25D          ' Cijena namaza maslaca
    Const decBOROVNICE As Decimal = 0.75D       ' Cijena namza dzema od borovnica
    Const decJAGODE As Decimal = 0.75D          ' Cijena namaza dzema od jagoda
    Const decSLJIVE As Decimal = 0.75D          ' Cijena namaza dzema od sljiva
    Const decOBICNA_KAFA As Decimal = 1.25D     ' Cijena obicne kafe
    Const decKAPUCINO As Decimal = 2D           ' Cijena kapucina
    Const decMAKIJATO As Decimal = 1.75D        ' Cijena makijata

    Private Sub btnUkupnaCijena_Click(sender As Object, e As EventArgs) Handles btnUkupnaCijena.Click
        ' Ova procedura racuna ukupnu cijenu narudzbe.
        Dim decUkupno As Decimal  ' Varijabla sadrzi Ukupno vrijednost
        Dim decPDV As Decimal       ' Varijabla sadrzi PDV vrijednost
        Dim decZaPlatiti As Decimal     ' Varijabla sadrzi ZaPlatiti vrijednost

        decUkupno = RacunajCijenuVekne() + RacunajCijenuNamaza() + RacunajCijenuKafe()
        decPDV = RacunajPDV(decUkupno)
        decZaPlatiti = decUkupno + decPDV

        lblUkupno.Text = decUkupno.ToString()
        lblPDV.Text = decPDV.ToString()
        lblZaPlatiti.Text = Math.Round(decZaPlatiti, 2).ToString() + " KM"
        'lblZaPlatiti.Text = decZaPlatiti.ToString()
    End Sub

    Private Sub btnReset_Click(sender As Object, e As EventArgs) Handles btnReset.Click
        ' Ova procedura vraca kontrole na pocetne vrijednosti.
        ResetujVekne()
        ResetujNamaze()
        ResetujKafe()
        ResetujCijene()
    End Sub

    Private Sub btnIzlaz_Click(sender As Object, e As EventArgs) Handles btnIzlaz.Click
        ' Zatvara formu.
        Me.Close()
    End Sub

    Function RacunajCijenuVekne() As Decimal
        ' Ova funkcija vraca cijenu odabrane vekne.
        Dim decVekna As Decimal

        If radBijela.Checked = True Then
            decVekna = decBIJELA_VEKNA
        Else
            decVekna = decINTEGRALNA
        End If

        Return decVekna
    End Function

    Function RacunajCijenuNamaza() As Decimal
        ' Ova funkcija vraca cijenu odabranih namaza.
        Dim decCijenaNamaza As Decimal = 0D

        If chkKremastiSir.Checked = True Then
            decCijenaNamaza += decKREMASTI_SIR
        End If

        If chkMaslac.Checked = True Then
            decCijenaNamaza += decMASLAC
        End If

        If chkBorovnica.Checked = True Then
            decCijenaNamaza += decBOROVNICE
        End If

        If chkJagoda.Checked = True Then
            decCijenaNamaza += decJAGODE
        End If

        If chkSljiva.Checked = True Then
            decCijenaNamaza += decSLJIVE
        End If

        Return decCijenaNamaza
    End Function

    Function RacunajCijenuKafe() As Decimal
        ' Ova funkcija vraca cijenu odabrane kafe.
        Dim decKafa As Decimal

        If radBezKafe.Checked = True Then
            decKafa = 0D
        ElseIf radObicnaKafa.Checked = True Then
            decKafa = decOBICNA_KAFA
        ElseIf radKapucino.Checked = True Then
            decKafa = decKAPUCINO
        ElseIf radMakijato.Checked = True Then
            decKafa = decMAKIJATO
        End If

        Return decKafa
    End Function

    Function RacunajPDV(ByVal decIznos As Decimal) As Decimal
        ' Ova funkcija prima iznos prodaje i vraca taj izos uvecan za PDV.
        Return decIznos * decPDV
    End Function

    Sub ResetujVekne()
        ' Ova procedura vraca vrijednost vekni na pocetne postavke.
        radBijela.Checked = True
    End Sub

    Sub ResetujNamaze()
        ' Ova procedura vraca vrijednost namaza na pocetne postavke.
        chkKremastiSir.Checked = False
        chkMaslac.Checked = False
        chkBorovnica.Checked = False
        chkJagoda.Checked = False
        chkSljiva.Checked = False
    End Sub

    Sub ResetujKafe()
        ' Ova procedura vraca vrijednost kafa na pocetne postavke.
        radBezKafe.Checked = True
    End Sub

    Sub ResetujCijene()
        ' Ova procedura brise cijene.
        lblUkupno.Text = String.Empty
        lblPDV.Text = String.Empty
        lblZaPlatiti.Text = String.Empty
    End Sub

End Class
