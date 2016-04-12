

Public Class ListUtAnsatte

    Dim tilkobling As New DBConnect


    Private Sub ListUtAnsatte_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'DatabaseDataSet.personer' table. You can move, or remove it, as needed.
        'Me.PersonerTableAdapter.FillAnsatt(Me.DatabaseDataSet.personer)
        Button2.Visible = False
        Button4.Visible = False


    End Sub

    Private Sub btnTilbake_Click(sender As Object, e As EventArgs) Handles btnTilbake.Click
        Me.Hide()
        meny.Show()

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        Me.PersonerTableAdapter.FillAnsatt(Me.DatabaseDataSet.personer)
        Button2.Visible = True

    End Sub

    Private Sub Søk_Click(sender As Object, e As EventArgs) Handles btnSok.Click

        Dim sok As String = txtSoek.Text
        Dim query As String
        query = "SELECT person_fornavn, person_etternavn, person_epost, person_tlf, person_type FROM personer where person_type not like 'Kunde' and (person_fornavn like '%" & sok & "%' or person_etternavn like '%" & sok & "%');"
        Dim DGview As New Dataset
        DGview.dataset(query)
        DataGridView1.DataSource = DGview.dataset(query)


    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Me.PersonerTableAdapter.FillKunde(Me.DatabaseDataSet.personer)
        Button4.Visible = True
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Try
            Me.PersonerTableAdapter.Update(Me.DatabaseDataSet.personer)
            MessageBox.Show("Den ansatte ble lagt til i databasen")
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Try
            Me.PersonerTableAdapter.Update(Me.DatabaseDataSet.personer)
            MessageBox.Show("Kunden ble lagt til i databasen")
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub
End Class