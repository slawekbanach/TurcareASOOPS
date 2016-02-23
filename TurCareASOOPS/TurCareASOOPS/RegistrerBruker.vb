Imports MySql.Data.MySqlClient

Public Class RegistrerBruker

    Public tilkobling = New MySqlConnection("Server=mysql.stud.iie.ntnu.no;Database=perkp;Uid=perkp;Pwd=passord123")

    Private Function sporring(ByVal sql As String) As DataTable
        Dim mydata As New DataTable
        Try
            tilkobling.Open()
            Dim kommando As New MySqlCommand(sql, tilkobling)
            Dim da As New MySqlDataAdapter
            da.SelectCommand = kommando
            da.Fill(mydata)
            tilkobling.Close()
        Catch ex As Exception
            MessageBox.Show("Noe gikk galt. " & ex.Message)
            tilkobling.Close()
        End Try
        Return mydata

    End Function

    Private Sub btnRegistrerBruker_Click(sender As Object, e As EventArgs) Handles btnRegistrerBruker.Click

        Dim brukernavn As String = txtRegistrerbrukernavn.Text
        Dim passord As String = txtregistrerpw.Text
        Dim passord2 As String = txtgjentapw.Text
        Dim typeansatt As String = ComboAnsattype.Text
        If passord = passord2 Then

            sporring("INSERT INTO brukere (brukernavn, passord, type) VALUES ('" & brukernavn & "', '" & passord & "', '" & typeansatt & "');")
            MessageBox.Show("Brukeren ble lagt til i databasen")
            txtRegistrerbrukernavn.Clear()
            txtregistrerpw.Clear()
            txtgjentapw.Clear()
            ComboAnsattype.ResetText()

        Else
            MessageBox.Show("Passordene er ikke like")
        End If

    End Sub
End Class