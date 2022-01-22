Public Class Form1
    Dim strOriginal As String
    Dim strZamjene As String
    Dim strNovi As String
    Dim strRijec As String
    Private Sub btnZamjeniSlova_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnZamjeniSlova.Click
        ' Korisnik pise rijeci i slovo koje hoce da zamijeni.
        ' Nova rijeci se prikazuju u labelu Prikaz
        strRijec = txtRijec.Text.ToLower
        strOriginal = txtSlovaZaPromijeniti.Text.ToLower
        strZamjene = txtZamjenskaSlova.Text.ToLower
        strNovi = strRijec.Replace(strOriginal, strZamjene)
        lblPrikaz.Text = strNovi
    End Sub
End Class
