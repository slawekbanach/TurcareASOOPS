Public Class Utleie
    'Dim tilkobling As New DBConnect

    Private Sub Utleie_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        con.Dispose()
        txtSelger.Text = LoginUser.bruker
        txtSelger.Enabled = False
        txtTotalpris.Enabled = False
        DateTimePicker1.Format = DateTimePickerFormat.Custom
        DateTimePicker1.CustomFormat = "dd/MM/yyyy"
        DateTimePicker2.Format = DateTimePickerFormat.Custom
        DateTimePicker2.CustomFormat = "dd/MM/yyyy"
    End Sub

    Private Sub btnRegistrerSalg_Click(sender As Object, e As EventArgs) Handles btnRegistrerSalg.Click

        Dim sporring As New Query

        Dim selgerid As String = txtSelger.Text
        Dim kundeid As String = txtKunde.Text
        Dim fradato As Date = DateTimePicker1.Value.ToString
        Dim tildato As Date = DateTimePicker2.Value.ToString

        Dim vare As String = txtVare.Text
        'Dim pris As Integer = txtPris.Text
        Dim totalpris As Integer = txtTotalpris.Text
        Try
            sporring.sporring("INSERT INTO utleie (utleie_selger_id, utleie_kunde_id, utleie_fra_dato, utleie_til_dato, utleie_vare, utleie_pris) VALUES ('" & selgerid & "', '" & kundeid & "', '" & fradato.ToShortDateString.ToString & "', '" & tildato.ToShortDateString.ToString & "', '" & vare & "', '" & totalpris & "');")
            MessageBox.Show("Registrering av utleie vellykket!")
            'txtKunde.Text = ""
            'txtVare.Text = ""
            'txtPris.Text = ""
            'txtTotalpris.Text = ""
        Catch ex As Exception
            MessageBox.Show("Feil: " & ex.Message)
        End Try

    End Sub

    'Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
    '    Dim fradato As Date = DateTimePicker1.Value
    '    Dim tildato As Date = DateTimePicker2.Value
    '    'Dim sluttpris As String = CInt(txtTotalpris.Text)
    '    Dim pris As Integer = txtPris.Text
    '    Dim antalldager As Integer = tildato.Subtract(fradato).Days
    '    txtTotalpris.Text = CInt(antalldager.ToString) * pris


    'End Sub

    Private Sub txtPris_TextChanged(sender As Object, e As EventArgs) Handles txtPris.TextChanged
        Dim fradato As Date = DateTimePicker1.Value
        Dim tildato As Date = DateTimePicker2.Value
        'Dim sluttpris As String = CInt(txtTotalpris.Text)
        Dim pris As Integer = txtPris.Text
        Dim antalldager As Int32 = tildato.Subtract(fradato).Days
        txtTotalpris.Text = CInt(antalldager.ToString) * pris
    End Sub
End Class