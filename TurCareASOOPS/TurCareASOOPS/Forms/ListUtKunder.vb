
Public Class ListUtKunder

    Dim tilkobling As New DBConnect




    Private Sub btnTilbake_Click(sender As Object, e As EventArgs) Handles btnTilbake.Click
        Me.Hide()
        meny.Show()

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        Dim query As String
        query = "SELECT person_fornavn, person_etternavn, person_epost, person_tlf, person_type FROM personer where person_type = 'Kunde'"
        Dim DGview As New Dataset
        DGview.dataset(query)
        DataGridView1.DataSource = DGview.dataset(query)


    End Sub

    Private Sub btnSok_Click(sender As Object, e As EventArgs) Handles btnSok.Click

        Dim sok As String = txtsoek.Text

        Dim query As String
        query = "SELECT person_fornavn, person_etternavn, person_epost, person_tlf, person_type FROM personer where person_type = 'Kunde' and (person_fornavn like '%" & sok & "%' or person_etternavn like '%" & sok & "%');"
        Dim DGview As New Dataset
        DGview.dataset(query)
        DataGridView1.DataSource = DGview.dataset(query)

    End Sub

    Private Sub ListUtKunder_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class