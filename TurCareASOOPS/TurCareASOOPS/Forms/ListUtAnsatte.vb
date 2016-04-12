﻿

Public Class ListUtAnsatte

    Dim tilkobling As New DBConnect


    Private Sub ListUtAnsatte_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'G_oops_t4DataSet.personer' table. You can move, or remove it, as needed.
        Me.PersonerTableAdapter.Fill(Me.G_oops_t4DataSet.personer)

    End Sub

    Private Sub btnTilbake_Click(sender As Object, e As EventArgs) Handles btnTilbake.Click
        Me.Hide()
        meny.Show()

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click


        Dim query As String
        query = "SELECT person_fornavn, person_etternavn, person_epost, person_tlf, person_type FROM personer where person_type not like 'Kunde'"
        Dim DGview As New Dataset
        DGview.dataset(query)
        DataGridView1.DataSource = DGview.dataset(query)




    End Sub

    Private Sub Søk_Click(sender As Object, e As EventArgs) Handles btnSok.Click

        Dim sok As String = txtSoek.Text
        Dim query As String
        query = "SELECT person_fornavn, person_etternavn, person_epost, person_tlf, person_type FROM personer where person_type not like 'Kunde' and (person_fornavn like '%" & sok & "%' or person_etternavn like '%" & sok & "%');"
        Dim DGview As New Dataset
        DGview.dataset(query)
        DataGridView1.DataSource = DGview.dataset(query)


    End Sub


End Class