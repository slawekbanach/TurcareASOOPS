Imports MySql.Data.MySqlClient

Public Class LoginDB

    Public brukernavn As String
    Public passord As String
    Public servernavn As String
    Public oppkobling As New MySqlConnection

    Private Sub btnDBlogin_Click(sender As Object, e As EventArgs) Handles btnDBlogin.Click

        brukernavn = txtDBuser.Text
        passord = txtDBpassord.Text
        servernavn = "mysql.stud.iie.ntnu.no"
        oppkobling.ConnectionString = "Server=" & servernavn & ";" &
                                      "Database=" & brukernavn & ";" &
                                      "Uid=" & brukernavn & ";" &
                                      "Pwd=" & passord & ";"
        Try
            oppkobling.Open()
            MessageBox.Show("Du er logget inn")
            oppkobling.Close()
            Me.Hide()
            LoginUser.Show()
        Catch minerror As Exception
            MessageBox.Show("Noe gikk galt. " & minerror.Message)
        End Try

    End Sub

    'Private Sub LoginDB_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
    '    LoginUser.Show()
    'End Sub
End Class
