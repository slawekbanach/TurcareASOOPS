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

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        Me.Hide()
        ListUtAnsatte.Show()
    End Sub

    Private Sub Button9_Click(sender As Object, e As EventArgs) Handles Button9.Click
        Me.Hide()
        ListUtKunder.Show()

    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Me.Hide()
        RegistrerSalg.show()
    End Sub
End Class