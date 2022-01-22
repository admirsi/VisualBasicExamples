Option Strict On
Option Explicit On

Public Class Form1

    Private Sub btnPogodi_Click(sender As Object, e As EventArgs) Handles btnPogodi.Click
        Dim intBroj As Integer          ' Deklarisi integer varijablu
        Dim randBroj As New Random      ' Napravi slucajni broj

        Dim intBrojac As Integer = 0    ' Varijabla brojac, inicijalizirana na vrijednost 0
        Dim intPogodak As Integer       ' Varijabla cuva vrijednost broja koji unese korisnik, kao pokusaj pogodtka
        Dim strUnos As String           ' Varijabla za korisnicki input

        ' Kreira slucajni broj integer i dodjeljuje tu vrijednost varijabli intBroj
        intBroj = randBroj.Next(1, 100)

        ' Dohvati svaki pokusaj pogodka broja
        Do While intPogodak <> intBroj
            ' Dohvati broj koji pogadja korisnik.
            strUnos = InputBox("Unesite broj koji se pogađa.")


            ' Konvertuj korisnicki unos u integer.
            If Integer.TryParse(strUnos, intPogodak) Then
                ' Odredi da li je broj veci, manji ili jednak zamisljenom.
                If intPogodak > intBroj Then
                    MessageBox.Show("Broj je veći od zamišljenog. Pokušajte ponovo.")
                ElseIf intPogodak < intBroj Then
                    MessageBox.Show("Broj je manji od zamišljenog. Pokušajte ponovo.")
                ElseIf intPogodak = intBroj Then
                    MessageBox.Show("Broj je tačan. Pogodili ste. Bravo!!!")
                End If
                ' Dodaj vrijednost 1 brojacu
                intBrojac += 1
            Else
                ' Ispisi poruku o gresci ako je unos neispravan.
                MessageBox.Show("Unesite brojčanu vrijednost!")
            End If
        Loop
        ' Prikaži broj pogađanja.
        lblBrojPogadjanja.Text = intBrojac.ToString()
    End Sub

    Private Sub btnIzlaz_Click(sender As Object, e As EventArgs) Handles btnIzlaz.Click
        ' Zatvori formu.
        Me.Close()
    End Sub


End Class
