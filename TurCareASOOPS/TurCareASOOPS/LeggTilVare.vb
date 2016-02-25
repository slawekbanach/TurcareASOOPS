Imports MySql.Data.MySqlClient

Public Class LeggTilVare

    Public tilkobling = New MySqlConnection("Server=mysql.stud.iie.ntnu.no;Database=g_oops_t4;Uid=g_oops_t4;Pwd=passord123")

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

    Private Sub btnTilbake_Click(sender As Object, e As EventArgs) Handles btntilbake.Click
        Me.Hide()
        meny.Show()

    End Sub

    Private Sub btnLeggTilVare_Click(sender As Object, e As EventArgs) Handles btnLeggTilVare.Click

        Dim varenavn As String = txtVarenavn.Text
        Dim salgutleie As String = cmbSalgutleie.Text
        Dim varetilstand As String = cmbVaretilstand.Text
        Dim varepris As Integer = txtVarepris.Text
        Dim varetilbud As Double = txtVaretilbud.Text
        Dim varestatus As String = cmbVarestatus.Text
        Dim vareantall As Integer = txtVareantall.Text
        sporring("INSERT INTO vare (vare_navn, vare_salg_utleie, vare_tilstand, vare_pris, vare_tilbud, vare_status, vare_antall) VALUES ('" & varenavn & "', '" & salgutleie & "', '" & varetilstand & "', '" & varepris & "', '" & varetilbud & "', '" & varestatus & "', '" & vareantall & "');")

    End Sub
End Class