﻿Imports MySql.Data.MySqlClient

Public Class LoginUser
    Public bruker As String


    Private Sub LoginUser_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim tilkobling As New DBConnect
        tilkobling.open()
    End Sub


    Private Sub btnAnsattlogin_Click_1(sender As Object, e As EventArgs) Handles btnAnsattlogin.Click
        bruker = txtAnsattbrukernavn.Text
        Dim brukernavn = txtAnsattbrukernavn.Text.Replace("'", "/")
        Dim passord = txtAnsattpassord.Text.Replace("'", "/")
        Dim sqlsporring = "Select * from personer where person_type = 'ansatt' and person_brukernavn='" & brukernavn & "' " & "and person_passord='" & passord & "'"
        Dim sql As New MySqlCommand(sqlsporring, con)
        Dim da As New MySqlDataAdapter
        Dim interntabell As New DataTable
        da.SelectCommand = sql
        da.Fill(interntabell)
        If interntabell.Rows.Count > 0 Then
            MessageBox.Show("Logget på som: " & brukernavn & " Trykk ok for å gå videre.")
            'Label1.Text = brukernavn
            'Label2.Visible = True
            Me.Hide()
            frmMain.Show()
        Else
            MsgBox("Feil brukernavn eller passord")
        End If

        txtAnsattbrukernavn.Text = ""
        txtAnsattpassord.Text = ""

    End Sub




End Class