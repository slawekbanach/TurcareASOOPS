Imports MySql.Data.MySqlClient
Public Class frmMain
    Dim tilkobling As New DBConnect
    Public kundeid() As String
    Public varepris As Integer
    'Public vareid() As Integer
    Public kursid() As String
    Public utleieid() As String

    Private Sub frmMain_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        If con.State = ConnectionState.Closed Then
            con.Open()
        End If

        '// laster inn lager //
        'Me.VareTableAdapter1.Fill(Me.VareData.vare)
        '//////////

        '// laster inn pagePerson //
        btnLeggTilAnsatt.Visible = False
        btnLeggTilKunde.Visible = False
        '///

        '// laster inn pageSalg //
        txtSelgerSalg.Text = LoginUser.bruker
        txtSelgerSalg.Enabled = False
        txtDatoSalg.Enabled = False
        txtPrisSalg.Enabled = False
        txtDatoSalg.Text = Date.Today.ToString("yyyy-MM-dd")

        '//// loadfunksjon for kunder ////
        Dim cmd As New MySqlCommand("SELECT person_id, person_fornavn, person_etternavn FROM personer where person_type = 'kunde'", con)
        Dim kunder As New List(Of String)

        Try

            Dim rd As MySqlDataReader = cmd.ExecuteReader(CommandBehavior.CloseConnection)

            While rd.Read()
                Dim kundemedid As String = rd("person_id") & " " & rd("person_fornavn") & " " & rd("person_etternavn")
                Dim kundeid As Integer = rd("person_id")
                kunder.Add(kundemedid)
            End While

            rd.Close()
            con.Close()
            Me.cmbKundeSalg.Items.Clear()
            Me.cmbKundeSalg.Items.AddRange(kunder.ToArray)

        Catch ex As Exception
            Dim trace = New System.Diagnostics.StackTrace(ex, True)
            MsgBox(ex.Message & vbCrLf & "Feilen ligger på linje:" & trace.GetFrame(0).GetFileLineNumber().ToString)
        End Try

        '// -----loadfunksjon for salgsvarer //
        Dim cmd2 As New MySqlCommand("SELECT vare_pris, vare_navn FROM vare where vare_salg_utleie = 'salg'", con)
        Dim varer As New List(Of String)

        Try

            con.Open()
            Dim rd As MySqlDataReader = cmd2.ExecuteReader(CommandBehavior.CloseConnection)

            While rd.Read()
                Dim vare As String = rd("vare_navn") & " - pris: " & rd("vare_pris")
                varepris = rd("vare_pris")
                varer.Add(vare)
            End While

            rd.Close()
            con.Close()
            Me.cmbVareSalg.Items.Clear()
            Me.cmbVareSalg.Items.AddRange(varer.ToArray)

        Catch ex As Exception
            Dim trace = New System.Diagnostics.StackTrace(ex, True)
            MsgBox(ex.Message & vbCrLf & "Error in ClaimFlag10 - Line number:" & trace.GetFrame(0).GetFileLineNumber().ToString)
        End Try
        '//

        '// laster inn utleie //
        txtSelger.Text = LoginUser.bruker
        txtSelger.Enabled = False
        txtTotalpris.Enabled = False
        dtpFraDatoUtleie.Format = DateTimePickerFormat.Custom
        dtpFraDatoUtleie.CustomFormat = "dd/MM/yyyy"
        dtpTilDatoUtleie.Format = DateTimePickerFormat.Custom
        dtpTilDatoUtleie.CustomFormat = "dd/MM/yyyy"

        '//// loadfunksjon for kunder ////
        Dim cmdKunderUtleie As New MySqlCommand("SELECT person_id, person_fornavn, person_etternavn FROM personer where person_type = 'kunde'", con)
        Dim kunderUtleie As New List(Of String)

        Try

            con.Open()
            Dim rd As MySqlDataReader = cmdKunderUtleie.ExecuteReader(CommandBehavior.CloseConnection)

            While rd.Read()
                Dim kundemedid As String = rd("person_id") & " " & rd("person_fornavn") & " " & rd("person_etternavn")
                Dim kundeid As Integer = rd("person_id")
                kunderUtleie.Add(kundemedid)
            End While

            rd.Close()
            con.Close()
            Me.cmbKunderUtleie.Items.Clear()
            Me.cmbKunderUtleie.Items.AddRange(kunderUtleie.ToArray)
        Catch ex As System.Exception
            MessageBox.Show(ex.Message)
        End Try
        '/////////////////////////

        '// loadfunksjon for varer //
        Dim cmdVarerUtleie As New MySqlCommand("SELECT vare_navn, vare_pris FROM vare where vare_salg_utleie = 'utleie'", con)
        Dim varerUtleie As New List(Of String)

        Try

            con.Open()
            Dim rd As MySqlDataReader = cmdVarerUtleie.ExecuteReader(CommandBehavior.CloseConnection)

            While rd.Read()
                Dim vare As String = rd("vare_navn")
                varepris = rd("vare_pris")
                varerUtleie.Add(vare)
            End While

            rd.Close()
            con.Close()
            Me.cmbVarerUtleie.Items.Clear()
            Me.cmbVarerUtleie.Items.AddRange(varerUtleie.ToArray)
        Catch ex As System.Exception
            MessageBox.Show(ex.Message)
        End Try


        '//Laster inn kurs//
        dgvKursdeltagereOversikt.Visible = False
        Me.Pamelding_kursTableAdapter.Fill(Me.KursDataSet.pamelding_kurs)
        con.Dispose()
        dgvKursMeldPa.Visible = False
        cmbVelgKurs.Visible = False
        dtpKursDato.Format = DateTimePickerFormat.Custom
        dtpKursDato.CustomFormat = "yyyy-MM-dd"
        panelKursLabels.Visible = False
        PanelKursTextboxes.Visible = False
        btnLagreKurs.Visible = False
        btnMeldPaDeltagerKurs.Visible = False
        dgvKursdeltagereOversikt.DefaultCellStyle.BackColor = Color.LightSkyBlue
        '//

        '//laster inn statistikk//
        dgvStatistikk.DefaultCellStyle.BackColor = Color.LightSkyBlue
        '//

    End Sub

    '//pageLager//
    Private Sub btnListUt_Click(sender As Object, e As EventArgs) Handles btnListUt.Click

        'Dim query As String

        'query = "SELECT vare_navn, vare_salg_utleie, vare_tilstand, vare_pris, vare_innkjopspris, vare_status, vare_antall FROM vare"

        'Dim DGview As New Dataset
        'DGview.dataset(query)
        'dgvLager.DataSource = DGview.dataset(query)
        Me.VareTableAdapter1.Fill(Me.VareData.vare)

    End Sub
    'Private Sub btnSok_Click(sender As Object, e As EventArgs)

    '    Dim sok As String = txtsoek.Text
    '    Dim query As String

    '    query = "SELECT vare_navn, vare_salg_utleie, vare_tilstand, vare_pris, vare_innkjopspris, vare_status, vare_antall FROM vare where vare_navn like '%" & sok & "%';"

    '    Dim DGview As New Dataset
    '    DGview.dataset(query)
    '    dgvLager.DataSource = DGview.dataset(query)

    'End Sub
    Private Sub btnLagreLager_Click(sender As Object, e As EventArgs) Handles btnLagreLager.Click

        Me.VareTableAdapter1.Update(Me.VareData.vare)

    End Sub

    '//pageLager finito//

    '//pagePerson//

    Private Sub btnListUtAnsatte_Click(sender As Object, e As EventArgs) Handles btnListUtAnsatte.Click

        Me.PersonerTableAdapter.FillAnsatt(Me.DatabaseDataSet.personer)
        btnLeggTilAnsatt.Visible = True

    End Sub

    Private Sub btnsokperson_Click(sender As Object, e As EventArgs) Handles btnSokPerson.Click

        Dim sok As String = txtSoekPerson.Text
        Dim query As String

        query = "SELECT person_fornavn, person_etternavn, person_epost, person_tlf, person_type FROM personer where person_type not like 'Kunde' and (person_fornavn like '%" & sok & "%' or person_etternavn like '%" & sok & "%');"

        Dim DGview As New Dataset
        DGview.dataset(query)
        dgvPerson.DataSource = DGview.dataset(query)

    End Sub

    Private Sub btnListUtKunder_Click(sender As Object, e As EventArgs) Handles btnListUtKunder.Click

        Me.PersonerTableAdapter.FillKunde(Me.DatabaseDataSet.personer)
        btnLeggTilKunde.Visible = True

    End Sub

    Private Sub btnLeggTilAnsatt_Click(sender As Object, e As EventArgs) Handles btnLeggTilAnsatt.Click

        Try

            Me.PersonerTableAdapter.Update(Me.DatabaseDataSet.personer)
            MessageBox.Show("Den ansatte ble lagt til i databasen")

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try

    End Sub

    Private Sub btnLeggTilKunde_Click(sender As Object, e As EventArgs) Handles btnLeggTilKunde.Click

        Try

            Me.PersonerTableAdapter.Update(Me.DatabaseDataSet.personer)
            MessageBox.Show("Kunden ble lagt til i databasen")

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub
    '//pagePerson finito//

    '//pageSalg//

    Private Sub txtAntallSalg_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtAntallSalg.KeyPress

        If Not Char.IsNumber(e.KeyChar) AndAlso Not Char.IsControl(e.KeyChar) Then e.KeyChar = ""

        'If Not Char.IsNumber(e.KeyChar) And Not Char.IsControl(e.KeyChar) Then
        '    e.KeyChar = ""
        'End If


    End Sub

    Private Sub btnRegistrerSalg_Click(sender As Object, e As EventArgs) Handles btnRegistrerSalg.Click
        Dim sporring As New Query

        Dim selgerid As String = txtSelgerSalg.Text
        Dim kundeid = cmbKundeSalg.Text.Split(" ")

        'datofeltet ligger i formload
        Dim vare() As String = cmbVareSalg.Text.Split(" ")
        Dim pris As Integer = CInt(txtPrisSalg.Text)
        Dim antall As Integer = CInt(txtAntallSalg.Text)

        Try

            sporring.sporring("INSERT INTO salg (salg_selger_id, salg_kunde_id, salg_dato, salg_vare, salg_antall, salg_pris) VALUES ('" & selgerid & "', '" & CInt(kundeid(0)) & "', '" & txtDatoSalg.Text & "', '" & vare(0) & "', '" & antall & "', '" & pris & "');")
            sporring.sporring("UPDATE vare SET vare_antall = (vare_antall - '" & antall & "')  WHERE vare_navn = '" & vare(0) & "';")
            MessageBox.Show("Registrering av salg vellykket!")

        Catch ex As Exception
            MessageBox.Show("Feil: " & ex.Message)
        End Try

    End Sub

    Private Sub cmbVareSalg_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbVareSalg.SelectedIndexChanged

        Dim prisen As String() = cmbVareSalg.Text.Split(": ")
        txtEnhetsprisSalg.Text = CInt(prisen(1))

    End Sub

    Private Sub txtAntallSalg_TextChanged(sender As Object, e As EventArgs) Handles txtAntallSalg.TextChanged

        If txtEnhetsprisSalg.Text = "" Then

            MsgBox("Vennligst velg vare først", MsgBoxStyle.Critical, "Penis")

        Else
            If txtAntallSalg.Text IsNot Nothing Then
                Try
                    txtPrisSalg.Text = CDbl(txtEnhetsprisSalg.Text * txtAntallSalg.Text)
                Catch ex As Exception
                End Try

            ElseIf txtAntallSalg Is Nothing Then

                'Do stuff

            End If

        End If
    End Sub

    '//pageSalg finito //

    '//pageUtleie//

    Private Sub btnRegistrerUtleie_Click(sender As Object, e As EventArgs) Handles btnRegistrerUtleie.Click

        Dim sporring As New Query

        Dim selgerid As String = txtSelger.Text

        Dim fradato As Date = dtpFraDatoUtleie.Value.ToString
        Dim tildato As Date = dtpTilDatoUtleie.Value.ToString
        kundeid = cmbKunderUtleie.Text.Split(" ")

        Dim vare As String = cmbVarerUtleie.Text
        Dim totalpris As Integer = txtTotalpris.Text

        Try
            sporring.sporring("INSERT INTO utleie (utleie_selger_id, utleie_kunde_id, utleie_fra_dato, utleie_til_dato, utleie_vare, utleie_pris, utleie_levert_tilbake) VALUES ('" & selgerid & "', '" & kundeid(0) & "', '" & fradato.ToShortDateString.ToString & "', '" & tildato.ToShortDateString.ToString & "', '" & vare & "', '" & totalpris & "', 'nei');")
            MessageBox.Show("Registrering av utleie vellykket!")

        Catch ex As Exception
            MessageBox.Show("Feil: " & ex.Message)
        End Try

    End Sub
    Private Sub txtPris_TextChanged(sender As Object, e As EventArgs) Handles txtPris.TextChanged

        Dim fradato As Date = dtpFraDatoUtleie.Value
        Dim tildato As Date = dtpTilDatoUtleie.Value
        'Dim sluttpris As String = CInt(txtTotalpris.Text)
        Dim pris As Integer = txtPris.Text
        Dim antalldager As Int32 = tildato.Subtract(fradato).Days
        txtTotalpris.Text = CInt(antalldager.ToString) * pris

    End Sub
    Private Sub cmbVarer_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbVarerUtleie.SelectedIndexChanged

        txtPris.Text = CInt(varepris)

    End Sub
    Private Sub dtpTilDatoUtleie_ValueChanged(sender As Object, e As EventArgs) Handles dtpTilDatoUtleie.ValueChanged
        Dim fradato As Date = dtpFraDatoUtleie.Value
        Dim tildato As Date = dtpTilDatoUtleie.Value
        'Dim sluttpris As String = CInt(txtTotalpris.Text)
        Dim pris As Integer = txtPris.Text
        Dim antalldager As Int32 = tildato.Subtract(fradato).Days
        txtTotalpris.Text = CInt(antalldager.ToString) * pris
    End Sub

    Private Sub btnLeverTilbake_Click(sender As Object, e As EventArgs) Handles btnLeverTilbake.Click

        utleieid = cmbUtleieTilbakelevering.Text.Split(" ")

        Dim sporring As New Query
        Try
            sporring.sporring("UPDATE utleie SET utleie_levert_tilbake= 'ja' WHERE utleie_id = '" & CInt(utleieid(0)) & "'")
            MessageBox.Show("Vare registrert som levert tilbake")
        Catch ex As Exception
            MessageBox.Show("Feil: " & ex.Message)
        End Try

    End Sub

    Private Sub btnOppdaterTilbakelevering_Click(sender As Object, e As EventArgs) Handles btnOppdaterTilbakelevering.Click

        Dim cmdVareLeverTilbake As New MySqlCommand("SELECT utleie_id, utleie_selger_id, utleie_kunde_id, utleie_fra_dato, utleie_til_dato, utleie_vare, utleie_pris FROM utleie ORDER BY utleie_id ASC", con)
        Dim vareLeverTilbake As New List(Of String)

        Try

            con.Open()
            Dim rd As MySqlDataReader = cmdVareLeverTilbake.ExecuteReader(CommandBehavior.CloseConnection)

            While rd.Read()
                Dim utleidVare As String = rd("utleie_id") & "  |  " & rd("utleie_vare") & "  |  Utleid av: " & rd("utleie_selger_id") & " til kunde med ID: " & rd("utleie_kunde_id") & "  |  Utleiedato: " & rd("utleie_fra_dato")
                vareLeverTilbake.Add(utleidVare)
            End While

            rd.Close()
            con.Close()
            Me.cmbUtleieTilbakelevering.Items.Clear()
            Me.cmbUtleieTilbakelevering.Items.AddRange(vareLeverTilbake.ToArray)
        Catch ex As System.Exception
            MessageBox.Show(ex.Message)
        End Try

    End Sub

    Private Sub btnOppdaterOversiktUtleie_Click(sender As Object, e As EventArgs) Handles btnOppdaterOversiktUtleie.Click

        Dim query As String

        query = "SELECT utleie_selger_id as 'Selger', utleie_kunde_id as 'Kunde', utleie_fra_dato as 'Fra', utleie_til_dato as 'Til', utleie_vare as 'Vare', utleie_pris as 'Pris', utleie_levert_tilbake as 'Returnert' FROM utleie ORDER BY utleie_fra_dato ASC"

        Dim DGview As New Dataset
        DGview.dataset(query)
        dgvUtleieOversikt.DataSource = DGview.dataset(query)

    End Sub


    '//pageUtleie finito//

    '//pageKurs //

    Private Sub btnRegistrerKurs_click(sender As Object, e As EventArgs) Handles btnRegistrerKurs.Click

        panelKursLabels.Visible = True
        dgvKursMeldPa.Visible = False
        dgvKursdeltagereOversikt.Visible = False
        PanelKursTextboxes.Visible = True
        btnLagreKurs.Visible = True
        btnMeldPaDeltagerKurs.Visible = False
        cmbVelgKurs.Visible = False
        btnLagreKurs.Text = "Registrer kurs"
        lblKursinstruktor.Text = "Kursinstruktør"
        lblKursdato.Text = "Kursdato"
        lblKursPlasser.Text = "Antall plasser"
        lblKursSted.Text = "Sted"
        lblKursType.Text = "Type"
        lblKursPris.Text = "Pris per deltaker"

    End Sub

    Private Sub btnLagreKurs_click(sender As Object, e As EventArgs) Handles btnLagreKurs.Click

        Dim leder As String = txtKursinstruktor.Text
        Dim dato As Date = Format(dtpKursDato.Value, "yyyy-MM-dd")
        Dim plasser As Integer = CInt(txtKursPlasser.Text)
        Dim sted As String = txtKursSted.Text
        Dim type As String = txtKursType.Text
        Dim pris As Integer = CInt(txtKursPris.Text)

        Dim sporring As New Query

        Try
            sporring.sporring("INSERT INTO registrere_kurs (kurs_instruktor, kurs_dato, antall_plasser, ledige_plasser, kurs_sted, kurs_type, kurs_pris) VALUES ('" & leder & "', '" & dtpKursDato.Text & "', '" & plasser & "', '" & plasser & "', '" & sted & "', '" & type & "', '" & pris & "');")

        Catch ex As Exception
            Dim trace = New System.Diagnostics.StackTrace(ex, True)
            MsgBox(ex.Message & vbCrLf & "Feil på linje:" & trace.GetFrame(0).GetFileLineNumber().ToString)
        End Try

        MessageBox.Show("Registrering av kurs vellykket!")
    End Sub

    Private Sub cmbVelgKurs_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbVelgKurs.SelectedIndexChanged

        btnMeldPaDeltagerKurs.Text = "Meld på"
        btnMeldPaDeltagerKurs.Visible = True
        Me.KursDataSet.pamelding_kurs.Clear()
        kursid = cmbVelgKurs.Text.Split(" ")

        dgvKursMeldPa.Visible = True

    End Sub

    Private Sub btnKursDeltagere_click(sender As Object, e As EventArgs) Handles btnMeldPaDeltagerKurs.Click

        dgvKursdeltagereOversikt.Visible = False

        Try

            Me.Pamelding_kursTableAdapter.Update(Me.KursDataSet.pamelding_kurs)
            MessageBox.Show("Påmelding vellykket")

        Catch ex As Exception
            Dim trace = New System.Diagnostics.StackTrace(ex, True)
            MsgBox(ex.Message & vbCrLf & "Error in ClaimFlag10 - Line number:" & trace.GetFrame(0).GetFileLineNumber().ToString)
        End Try

    End Sub

    Private Sub dgvKursMeldPa_DefaultValuesNeeded(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewRowEventArgs) Handles dgvKursMeldPa.DefaultValuesNeeded

        e.Row.Cells("KursidDataGridViewTextBoxColumn").Value = kursid(0)

    End Sub

    Private Sub btnVisPameldteKurs_Click(sender As Object, e As EventArgs) Handles btnVisPameldteKurs.Click

        dgvKursdeltagereOversikt.Visible = True
        cmbVelgKurs.Visible = False
        dgvKursMeldPa.Visible = False
        panelKursLabels.Visible = False
        PanelKursTextboxes.Visible = False
        btnLagreKurs.Visible = False
        btnMeldPaDeltagerKurs.Visible = False

        Dim query As String

        query = "SELECT pamelding_kurs.deltager_navn, pamelding_kurs.deltager_tlf, pamelding_kurs.kurs_id, registrere_kurs.kurs_type FROM pamelding_kurs, registrere_kurs where registrere_kurs.kurs_id = pamelding_kurs.kurs_id order by pamelding_kurs.kurs_id ASC"

        Dim DGview = New Dataset
        DGview.dataset(query)
        dgvKursdeltagereOversikt.DataSource = DGview.dataset(query)

    End Sub

    Private Sub btnLeggTilKursdeltager_Click(sender As Object, e As EventArgs) Handles btnLeggTilKursdeltager.Click

        panelKursLabels.Visible = False
        PanelKursTextboxes.Visible = False
        dgvKursdeltagereOversikt.Visible = False
        btnMeldPaDeltagerKurs.Visible = True
        btnLagreKurs.Visible = False

        Dim cmd As New MySqlCommand("SELECT kurs_id, kurs_type FROM registrere_kurs", con)
        Dim kurs As New List(Of String)

        Try

            con.Open()
            Dim rd As MySqlDataReader = cmd.ExecuteReader(CommandBehavior.CloseConnection)

            While rd.Read()

                Dim kursmedid As String = rd("kurs_id") & " " & rd("kurs_type")
                Dim kursid As Integer = rd("kurs_id")
                kurs.Add(kursmedid)

            End While

            rd.Close()
            con.Close()
            Me.cmbVelgKurs.Items.Clear()
            Me.cmbVelgKurs.Items.AddRange(kurs.ToArray)

        Catch ex As Exception
            Dim trace = New System.Diagnostics.StackTrace(ex, True)
            MsgBox(ex.Message & vbCrLf & "Error in ClaimFlag10 - Line number:" & trace.GetFrame(0).GetFileLineNumber().ToString)
        End Try

        cmbVelgKurs.Visible = True

    End Sub

    Private Sub dgvKursMeldPa_RowsAdded(sender As Object, e As DataGridViewRowsAddedEventArgs) Handles dgvKursMeldPa.RowsAdded

        Try
            dgvKursMeldPa.Rows(e.RowIndex).Cells(2).ReadOnly = True
            'dgvKursMeldPa.Rows(e.RowIndex).Cells(2).Value = CInt(kursid(0))

        Catch ex As Exception

            Dim trace = New System.Diagnostics.StackTrace(ex, True)
            MsgBox(ex.Message & vbCrLf & "Error in ClaimFlag10 - Line number:" & trace.GetFrame(0).GetFileLineNumber().ToString)
        End Try

    End Sub

    '--kurs validering--
    Private Sub txtKursinstruktor_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtKursinstruktor.KeyPress

        If Not ((Asc(e.KeyChar) = 8 OrElse e.KeyChar = " ") OrElse (e.KeyChar >= "A" AndAlso e.KeyChar <= "ø")) Then
            e.Handled = True
        End If
    End Sub

    Private Sub txtKursPlasser_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtKursPlasser.KeyPress
        If Asc(e.KeyChar) <> 8 Then
            If Asc(e.KeyChar) < 48 Or Asc(e.KeyChar) > 57 Then
                e.Handled = True
            End If
        End If
    End Sub

    Private Sub txtKursSted_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtKursSted.KeyPress

        If Not ((Asc(e.KeyChar) = 8 OrElse e.KeyChar = " ") OrElse (e.KeyChar >= "A" AndAlso e.KeyChar <= "ø")) Then
            e.Handled = True
        End If
    End Sub

    Private Sub txtKursType_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtKursType.KeyPress
        If Not ((Asc(e.KeyChar) = 8 OrElse e.KeyChar = " ") OrElse (e.KeyChar >= "A" AndAlso e.KeyChar <= "ø")) Then
            e.Handled = True
        End If
    End Sub

    Private Sub txtKursPris_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtKursPris.KeyPress
        If Asc(e.KeyChar) <> 8 Then
            If Asc(e.KeyChar) < 48 Or Asc(e.KeyChar) > 57 Then
                e.Handled = True
            End If
        End If
    End Sub

    '//pageKurs finito//

    '//pageStatistikk//

    Private Sub btnAntallSalgStatistikk_Click(sender As Object, e As EventArgs) Handles btnAntallSalgStatistikk.Click

        Dim query As String

        query = "SELECT COUNT( * ) as 'antall_salg' FROM  salg"

        Dim DGview As New Dataset
        DGview.dataset(query)
        dgvStatistikk.DataSource = DGview.dataset(query)

    End Sub

    Private Sub btnSalgPrSelgerStatistikk_Click(sender As Object, e As EventArgs) Handles btnSalgPrSelgerStatistikk.Click

        Dim query As String

        query = "SELECT salg_selger_id as 'Selger', COUNT( * ) as 'Antall_Salg' , SUM( salg_pris ) as 'Salgsinntekt'
                FROM salg
                GROUP BY salg_selger_id"

        Dim DGview As New Dataset
        DGview.dataset(query)
        dgvStatistikk.DataSource = DGview.dataset(query)

    End Sub

    Private Sub btnAntallUtleieStatistikk_Click(sender As Object, e As EventArgs) Handles btnAntallUtleieStatistikk.Click

        Dim query As String

        query = "SELECT COUNT(*) AS 'Utleie_Antall' FROM utleie"

        Dim DGview As New Dataset
        DGview.dataset(query)
        dgvStatistikk.DataSource = DGview.dataset(query)

    End Sub

    Private Sub btnUtleiePrSelgerStatistikk_Click(sender As Object, e As EventArgs) Handles btnUtleiePrSelgerStatistikk.Click

        Dim query As String

        query = "SELECT utleie_selger_id as 'Selger', COUNT(*) 'Utleie_Antall', sum(utleie_pris) as 'Utleieinntekt' FROM utleie
                 group by utleie_selger_id"

        Dim DGview As New Dataset
        DGview.dataset(query)
        dgvStatistikk.DataSource = DGview.dataset(query)

    End Sub

    Private Sub btnSalgInntektStatistikk_Click(sender As Object, e As EventArgs) Handles btnSalgInntektStatistikk.Click

        Dim query As String

        query = "SELECT SUM(salg_pris) as 'Salgsinntekt', SUM(vare_innkjopspris * salg_antall) as 'Innkjopspris', SUM( salg_pris - (vare_innkjopspris * salg_antall) ) as 'Fortjeneste' FROM  salg, vare where salg.salg_vare = vare.vare_navn"

        Dim DGview = New Dataset
        DGview.dataset(query)
        dgvStatistikk.DataSource = DGview.dataset(query)

    End Sub

    Private Sub btnUtleieInntektStatistikk_Click(sender As Object, e As EventArgs) Handles btnUtleieInntektStatistikk.Click

        Dim query As String

        query = "SELECT SUM( utleie_pris ) as 'Utleieinntekt_Totalt' FROM  `utleie`"

        Dim DGview As New Dataset
        DGview.dataset(query)
        dgvStatistikk.DataSource = DGview.dataset(query)

    End Sub

    Private Sub btnVarePopularStatistikk_Click(sender As Object, e As EventArgs) Handles btnVarePopularStatistikk.Click

        Dim query As String

        query = "SELECT salg_vare as 'Vare' , COUNT( * ) as 'Antall_Solgte'
                    FROM salg
                    GROUP BY salg_vare"
        Dim DGview As New Dataset
        DGview.dataset(query)
        dgvStatistikk.DataSource = DGview.dataset(query)
    End Sub

    '//pageStatistikk finito//

    '//pageLoggut//
    Private Sub btnLoggUt_Click(sender As Object, e As EventArgs) Handles btnLoggUt.Click

        Try

            Dim c As Form = Form.ActiveForm

            con.Close()
            con.Dispose()

            LoginUser.Show()

            c.Close()

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub

    Private Sub TabControl1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles TabControl1.SelectedIndexChanged
        If TabControl1.SelectedIndex = 7 Then

            Try

                Dim c As Form = Form.ActiveForm

                con.Close()
                con.Dispose()

                LoginUser.Show()

                c.Close()
                MessageBox.Show("Du er nå logget ut!")

            Catch ex As Exception
                MessageBox.Show(ex.Message)
            End Try

        End If

    End Sub

    Private Sub frmMain_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        con.Dispose()
    End Sub



    '//pageloggut finito//
End Class