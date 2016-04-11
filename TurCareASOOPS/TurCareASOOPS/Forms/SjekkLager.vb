﻿Imports System
Imports System.Data
Imports System.Data.SqlClient
Imports MySql.Data.MySqlClient


Public Class SjekkLager

    Dim tilkobling As New DBConnect



    Private Sub btnListUt_Click(sender As Object, e As EventArgs) Handles btnListUt.Click


        Dim query As String
        query = "SELECT vare_navn, vare_salg_utleie, vare_tilstand, vare_pris, vare_status, vare_antall FROM vare"
        Dim DGview As New Dataset
        DGview.dataset(query)
        DataGridView1.DataSource = DGview.dataset(query)






    End Sub

    Private Sub btnTilbake_Click(sender As Object, e As EventArgs) Handles btnTilbake.Click

        Me.Hide()
        meny.Show()

    End Sub

    Private Sub btnSok_Click(sender As Object, e As EventArgs) Handles btnSok.Click


        Dim sok As String = txtsoek.Text


        Dim query As String
        query = "SELECT vare_navn, vare_salg_utleie, vare_tilstand, vare_pris, vare_status, vare_antall FROM vare where vare_navn like '%" & sok & "%';"
        Dim DGview As New Dataset
        DGview.dataset(query)
        DataGridView1.DataSource = DGview.dataset(query)

    End Sub

    Private Sub SjekkLager_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'G_oops_t4DataSet.vare' table. You can move, or remove it, as needed.
        Me.VareTableAdapter.Fill(Me.G_oops_t4DataSet.vare)

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.VareTableAdapter.Update(Me.G_oops_t4DataSet.vare)
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.VareTableAdapter.InsertQuery()

    End Sub
End Class