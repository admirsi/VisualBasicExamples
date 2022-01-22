Option Strict On
Option Explicit On

Public Class Form1
    Dim slucajniBroj As Random = New Random()       ' Sliucajni broj je generisan u varijabli slucajniBroj
    Dim intNizBrojeva(9) As Integer                 ' Kreiran je niz brojeva od 10
    Private Sub btnBingoIzvlacenje_Click(sender As Object, e As EventArgs) Handles btnBingoIzvlacenje.Click
        ' Kada se klikne dugme pokrenu se se procedure GenerisiBrojeve i PrikaziBrojeve
        GenerisiBrojeve()
        PrikaziBrojeve()
    End Sub
    Private Sub btnNajveciBroj_Click(sender As Object, e As EventArgs) Handles btnNajveciBroj.Click
        ' Najveci broj je prikazan u labelu lblNajveciBroj
        lblNajveciBroj.Text = "Najveci broj je " & intNizBrojeva.Max
    End Sub
    Private Sub btnNajmanjBroj_Click(sender As Object, e As EventArgs) Handles btnNajmanjBroj.Click
        ' Najmanji broj je prikazan u labelu lblNajmanjiBroj
        lblNajmanjiBroj.Text = "Najmanji broj je " & intNizBrojeva.Min
    End Sub
    Public Sub GenerisiBrojeve()
        For i = 0 To 9
            intNizBrojeva(i) = slucajniBroj.Next(1, 101)  ' Generi se broj od 1 do 100
        Next
    End Sub
    Public Sub PrikaziBrojeve()
        lstBingoBrojevi.Items.Clear()   ' Brisu se vrijednosti iz listboxa lstBingoBrojevi
        lblNajveciBroj.Text = ""        ' Brise se label NajveciBroj
        lblNajmanjiBroj.Text = ""       ' Brise se label NajmanjiBroj
        For i = 0 To 9
            lstBingoBrojevi.Items.Add(intNizBrojeva(i)) ' Dodaju se 10 brojeva listbox-u 
        Next
    End Sub

End Class