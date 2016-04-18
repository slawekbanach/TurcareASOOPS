Imports MySql.Data.MySqlClient
Public Class Utleie
    Public kundeid() As String
    Public varepris As Integer

    Private Sub Utleie_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        con.Dispose()
        txtSelger.Text = LoginUser.bruker
        txtSelger.Enabled = False
        txtTotalpris.Enabled = False
        DateTimePicker1.Format = DateTimePickerFormat.Custom
        DateTimePicker1.CustomFormat = "dd/MM/yyyy"
        DateTimePicker2.Format = DateTimePickerFormat.Custom
        DateTimePicker2.CustomFormat = "dd/MM/yyyy"

        '//// loadfunksjon for kunder ////
        Dim cmd As New MySqlCommand("SELECT person_id, person_fornavn, person_etternavn FROM personer where person_type = 'kunde'", con)
        Dim kunder As New List(Of String)
        Try
            con.Open()
            Dim rd As MySqlDataReader = cmd.ExecuteReader(CommandBehavior.CloseConnection)
            While rd.Read()
                Dim kundemedid As String = rd("person_id") & " " & rd("person_fornavn") & " " & rd("person_etternavn")
                Dim kundeid As Integer = rd("person_id")
                kunder.Add(kundemedid)
            End While
            rd.Close()
            con.Close()
            Me.cmbKunder.Items.Clear()
            Me.cmbKunder.Items.AddRange(kunder.ToArray)
        Catch ex As System.Exception
            MessageBox.Show(ex.Message)
        End Try
        '/////////////////////////

        '// loadfunksjon for varer //
        Dim cmd2 As New MySqlCommand("SELECT vare_navn, vare_pris FROM vare where vare_salg_utleie = 'utleie'", con)
        Dim varer As New List(Of String)
        Try
            con.Open()
            Dim rd As MySqlDataReader = cmd2.ExecuteReader(CommandBehavior.CloseConnection)
            While rd.Read()
                Dim vare As String = rd("vare_navn")
                varepris = rd("vare_pris")
                varer.Add(vare)
            End While
            rd.Close()
            con.Close()
            Me.cmbVarer.Items.Clear()
            Me.cmbVarer.Items.AddRange(varer.ToArray)
        Catch ex As System.Exception
            MessageBox.Show(ex.Message)
        End Try


    End Sub

    Private Sub btnRegistrerSalg_Click(sender As Object, e As EventArgs) Handles btnRegistrerSalg.Click

        Dim sporring As New Query

        Dim selgerid As String = txtSelger.Text

        Dim fradato As Date = DateTimePicker1.Value.ToString
        Dim tildato As Date = DateTimePicker2.Value.ToString
        kundeid = cmbKunder.Text.Split(" ")
        'vareid = cmbVarer.Text.Split(" ")

        Dim vare As String = cmbVarer.Text
        'Dim pris As Integer = txtPris.Text
        Dim totalpris As Integer = txtTotalpris.Text
        Try
            sporring.sporring("INSERT INTO utleie (utleie_selger_id, utleie_kunde_id, utleie_fra_dato, utleie_til_dato, utleie_vare, utleie_pris) VALUES ('" & selgerid & "', '" & kundeid(0) & "', '" & fradato.ToShortDateString.ToString & "', '" & tildato.ToShortDateString.ToString & "', '" & vare & "', '" & totalpris & "');")
            MessageBox.Show("Registrering av utleie vellykket!")
            'txtKunde.Text = ""
            'txtVare.Text = ""
            'txtPris.Text = ""
            'txtTotalpris.Text = ""
        Catch ex As Exception
            MessageBox.Show("Feil: " & ex.Message)
        End Try

    End Sub


    Private Sub txtPris_TextChanged(sender As Object, e As EventArgs) Handles txtPris.TextChanged
        Dim fradato As Date = DateTimePicker1.Value
        Dim tildato As Date = DateTimePicker2.Value
        'Dim sluttpris As String = CInt(txtTotalpris.Text)
        Dim pris As Integer = txtPris.Text
        Dim antalldager As Int32 = tildato.Subtract(fradato).Days
        txtTotalpris.Text = CInt(antalldager.ToString) * pris



    End Sub

    Private Sub cmbVarer_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbVarer.SelectedIndexChanged
        txtPris.Text = CInt(varepris)
    End Sub

    Private Sub DateTimePicker2_ValueChanged(sender As Object, e As EventArgs) Handles DateTimePicker2.ValueChanged
        Dim fradato As Date = DateTimePicker1.Value
        Dim tildato As Date = DateTimePicker2.Value
        'Dim sluttpris As String = CInt(txtTotalpris.Text)
        Dim pris As Integer = txtPris.Text
        Dim antalldager As Int32 = tildato.Subtract(fradato).Days
        txtTotalpris.Text = CInt(antalldager.ToString) * pris
    End Sub
End Class