Imports MySql.Data.MySqlClient
Public Class RegistrerSalg
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

    Private Sub RegistrerSalg_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txtSelger.Text = LoginUser.bruker
        txtSelger.Enabled = False
    End Sub


    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnRegistrerSalg.Click
        Dim selgerid As String = txtSelger.Text
        Dim kundeid As String = txtKunde.Text
        Dim dato As String = txtDato.Text
        Dim vare As String = txtVare.Text
        Dim pris As String = txtPris.Text
        Dim antall As String = txtAntall.Text
        Try
            sporring("INSERT INTO salg (salg_selger_id, salg_kunde_id, salg_dato, salg_vare, salg_antall, salg_pris) VALUES ('" & selgerid & "', '" & kundeid & "', '" & dato & "', '" & vare & "', '" & antall & "', '" & pris & "');")
            MessageBox.Show("Registrering av salg vellykket!")
            txtKunde.Text = ""
            txtDato.Text = ""
            txtVare.Text = ""
            txtPris.Text = ""
            txtAntall.Text = ""
        Catch ex As Exception
            MessageBox.Show("Feil: " & ex.Message)
        End Try


    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Hide()
        meny.Show()

    End Sub



    Private Sub btnVarer_click(sender As Object, e As EventArgs) Handles btnVarer.Click
        SjekkLager.Show()
    End Sub

    Private Sub btnKunder_click(sender As Object, e As EventArgs) Handles btnKunder.Click
        ListUtKunder.Show()
    End Sub
End Class