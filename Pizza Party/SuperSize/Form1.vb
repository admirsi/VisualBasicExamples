Public Class Form1
    ' Globalna varijabla ukupnaCijena da sadrzi sve sto je odabrano
    Dim ukupnaCijena As Double
    Private Sub btnNaruci_Click(sender As Object, e As EventArgs) Handles btnNaruci.Click
        ' Dodavanje cijena dodataka na ukupnuCijenu
        If chkGljive.Checked Then
            ukupnaCijena += 2.95
        End If

        If chkMasline.Checked Then
            ukupnaCijena += 3.95
        End If

        If chkPaprika.Checked Then
            ukupnaCijena += 1.95
        End If

        If chkSudzuka.Checked Then
            ukupnaCijena += 2.5
        End If

        If radMala.Checked Then
            ukupnaCijena *= 1
        End If

        If radVelika.Checked Then
            ukupnaCijena *= 2
        End If
        ' Random varijabla 
        Dim randomVrijednost As New System.Random()
        Static brojNarudzbe As Integer = randomVrijednost.Next(100, 1001)
        ' Prikaz broja narudzbe 
        lblBrojNarudzbe.Text = "Naruždba br. " & brojNarudzbe
        ' PDV
        Dim PDV As Double = ukupnaCijena * 0.17
        ' Ukupno za platiti
        Dim zaPlatiti As Double = PDV + ukupnaCijena
        ' Prikazuje ukupnu cijenu za platiti u KM 

        lblZaPlatiti.Text = "Molimo platite: " & Math.Round(zaPlatiti, 2).ToString() + " KM"

    End Sub

End Class
