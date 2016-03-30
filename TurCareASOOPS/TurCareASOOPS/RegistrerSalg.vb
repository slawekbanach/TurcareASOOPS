
Public Class RegistrerSalg
    Dim tilkobling As New DBConnect

    Private Sub RegistrerSalg_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txtSelger.Text = LoginUser.bruker
        txtSelger.Enabled = False
    End Sub


    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnRegistrerSalg.Click
        Dim sporring As New Query

        Dim selgerid As String = txtSelger.Text
        Dim kundeid As String = txtKunde.Text
        Dim dato As String = txtDato.Text
        Dim vare As String = txtVare.Text
        Dim pris As String = txtPris.Text
        Dim antall As String = txtAntall.Text
        Try
            sporring.sporring("INSERT INTO salg (salg_selger_id, salg_kunde_id, salg_dato, salg_vare, salg_antall, salg_pris) VALUES ('" & selgerid & "', '" & kundeid & "', '" & dato & "', '" & vare & "', '" & antall & "', '" & pris & "');")
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