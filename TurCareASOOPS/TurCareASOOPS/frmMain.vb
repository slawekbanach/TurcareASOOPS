Imports MySql.Data.MySqlClient
Public Class frmMain
    Dim tilkobling As New DBConnect
    Private Sub frmMain_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        '// Laster inn lager //

        Me.VareTableAdapter.Fill(Me.DatabaseDataSet.vare)

        '///////////////////////////


    End Sub
End Class