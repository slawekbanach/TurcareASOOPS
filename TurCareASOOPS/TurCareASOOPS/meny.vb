Public Class meny
    Private Sub btnLeggTilAnsatt_Click(sender As Object, e As EventArgs) Handles btnLeggTilAnsatt.Click
        Me.Hide()
        RegistrerBruker.Show()

    End Sub

    Private Sub btnLeggTilVare_Click(sender As Object, e As EventArgs) Handles btnLeggTilVare.Click
        Me.Hide()
        LeggTilVare.Show()
    End Sub

    Private Sub btnSjekkLager_Click(sender As Object, e As EventArgs) Handles btnSjekkLager.Click
        Me.Hide()
        SjekkLager.Show()

    End Sub
End Class