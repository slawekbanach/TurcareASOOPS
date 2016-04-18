

Public Class ListUtAnsatte

    Dim tilkobling As New DBConnect


    Private Sub ListUtAnsatte_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'DatabaseDataSet.personer' table. You can move, or remove it, as needed.
        'Me.PersonerTableAdapter.FillAnsatt(Me.DatabaseDataSet.personer)
        btnLeggTilAnsatt.Visible = False
        btnLeggTilKunde.Visible = False


    End Sub

    Private Sub btnTilbake_Click(sender As Object, e As EventArgs) Handles btnTilbakePerson.Click
        Me.Hide()
        meny.Show()

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnListUtAnsatte.Click

        Me.PersonerTableAdapter.FillAnsatt(Me.DatabaseDataSet.personer)
        btnLeggTilAnsatt.Visible = True

    End Sub

    Private Sub Søk_Click(sender As Object, e As EventArgs) Handles btnSokPerson.Click

        Dim sok As String = txtSoekPerson.Text
        Dim query As String
        query = "SELECT person_fornavn, person_etternavn, person_epost, person_tlf, person_type FROM personer where person_type not like 'Kunde' and (person_fornavn like '%" & sok & "%' or person_etternavn like '%" & sok & "%');"
        Dim DGview As New Dataset
        DGview.dataset(query)
        dgvPerson.DataSource = DGview.dataset(query)


    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles btnListUtKunder.Click
        Me.PersonerTableAdapter.FillKunde(Me.DatabaseDataSet.personer)
        btnLeggTilKunde.Visible = True
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles btnLeggTilAnsatt.Click
        Try
            Me.PersonerTableAdapter.Update(Me.DatabaseDataSet.personer)
            MessageBox.Show("Den ansatte ble lagt til i databasen")
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles btnLeggTilKunde.Click
        Try
            Me.PersonerTableAdapter.Update(Me.DatabaseDataSet.personer)
            MessageBox.Show("Kunden ble lagt til i databasen")
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub
End Class