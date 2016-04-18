Imports MySql.Data.MySqlClient
Public Class frmMain
    Dim tilkobling As New DBConnect
    Private Sub frmMain_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        '// laster inn lager // 
        Me.VareTableAdapter.Fill(Me.DatabaseDataSet.vare)
        '//////////

        '// laster inn pagePerson // 
        btnLeggTilAnsatt.Visible = False
        btnLeggTilKunde.Visible = False
        '///



    End Sub


    '//pageLager//
    Private Sub btnListUt_Click(sender As Object, e As EventArgs) Handles btnListUt.Click
        Dim query As String
        query = "SELECT vare_navn, vare_salg_utleie, vare_tilstand, vare_pris, vare_status, vare_antall FROM vare"
        Dim DGview As New Dataset
        DGview.dataset(query)
        dgvLager.DataSource = DGview.dataset(query)
    End Sub
    Private Sub btnSok_Click(sender As Object, e As EventArgs) Handles btnSok.Click
        Dim sok As String = txtsoek.Text
        Dim query As String
        query = "SELECT vare_navn, vare_salg_utleie, vare_tilstand, vare_pris, vare_status, vare_antall FROM vare where vare_navn like '%" & sok & "%';"
        Dim DGview As New Dataset
        DGview.dataset(query)
        dgvLager.DataSource = DGview.dataset(query)
    End Sub
    Private Sub btnLagreLager_Click(sender As Object, e As EventArgs) Handles btnLagreLager.Click
        Me.VareTableAdapter.Update(Me.DatabaseDataSet.vare)
    End Sub

    '//pageLager finito//

    '//pagePerson//
    Private Sub btnListUtAnsatte_Click(sender As Object, e As EventArgs) Handles btnListUtAnsatte.Click

        Me.PersonerTableAdapter.FillAnsatt(Me.DatabaseDataSet.personer)
        btnLeggTilAnsatt.Visible = True

    End Sub

    Private Sub btnsokperson_Click(sender As Object, e As EventArgs) Handles btnSokPerson.Click

        Dim sok As String = txtSoekPerson.Text
        Dim query As String
        query = "SELECT person_fornavn, person_etternavn, person_epost, person_tlf, person_type FROM personer where person_type not like 'Kunde' and (person_fornavn like '%" & sok & "%' or person_etternavn like '%" & sok & "%');"
        Dim DGview As New Dataset
        DGview.dataset(query)
        dgvPerson.DataSource = DGview.dataset(query)


    End Sub

    Private Sub btnListUtKunder_Click(sender As Object, e As EventArgs) Handles btnListUtKunder.Click
        Me.PersonerTableAdapter.FillKunde(Me.DatabaseDataSet.personer)
        btnLeggTilKunde.Visible = True
    End Sub

    Private Sub btnLeggTilAnsatt_Click(sender As Object, e As EventArgs) Handles btnLeggTilAnsatt.Click
        Try
            Me.PersonerTableAdapter.Update(Me.DatabaseDataSet.personer)
            MessageBox.Show("Den ansatte ble lagt til i databasen")
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub btnLeggTilKunde_Click(sender As Object, e As EventArgs) Handles btnLeggTilKunde.Click
        Try
            Me.PersonerTableAdapter.Update(Me.DatabaseDataSet.personer)
            MessageBox.Show("Kunden ble lagt til i databasen")
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub
End Class