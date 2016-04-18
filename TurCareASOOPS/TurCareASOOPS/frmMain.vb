Imports MySql.Data.MySqlClient
Public Class frmMain
    Dim tilkobling As New DBConnect
    Public kundeid() As String
    Public varepris As Integer
    Public vareid() As Integer
    Private Sub frmMain_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        '// laster inn lager // 
        Me.VareTableAdapter.Fill(Me.DatabaseDataSet.vare)
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
        Catch ex As System.Exception
            MessageBox.Show(ex.Message)
        End Try

        '// loadfunksjon for salgsvarer //
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
        Catch ex As System.Exception
            MessageBox.Show(ex.Message)
        End Try


        '//


    End Sub


    '//pageLager//
    Private Sub btnListUt_Click(sender As Object, e As EventArgs) Handles btnListUt.Click
        Dim query As String
        query = "SELECT vare_navn, vare_salg_utleie, vare_tilstand, vare_pris, vare_status, vare_antall FROM vare"
        Dim DGview As New Dataset
        DGview.dataset(query)
        dgvLager.DataSource = DGview.dataset(query)
    End Sub
    Private Sub btnSok_Click(sender As Object, e As EventArgs) Handles btnSok.Click
        Dim sok As String = txtsoek.Text
        Dim query As String
        query = "SELECT vare_navn, vare_salg_utleie, vare_tilstand, vare_pris, vare_status, vare_antall FROM vare where vare_navn like '%" & sok & "%';"
        Dim DGview As New Dataset
        DGview.dataset(query)
        dgvLager.DataSource = DGview.dataset(query)
    End Sub
    Private Sub btnLagreLager_Click(sender As Object, e As EventArgs) Handles btnLagreLager.Click
        Me.VareTableAdapter.Update(Me.DatabaseDataSet.vare)
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
            'txtDatoSalg.Text = ""
            'txtPrisSalg.Text = ""
            'txtAntallSalg.Text = ""
        Catch ex As Exception
            MessageBox.Show("Feil: " & ex.Message)
        End Try
        MessageBox.Show("Registrering av salg vellykket!")

    End Sub

    Private Sub cmbVareSalg_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbVareSalg.SelectedIndexChanged

        Dim prisen As String() = cmbVareSalg.Text.Split(": ")
        txtEnhetsprisSalg.Text = CInt(prisen(1))


    End Sub

    Private Sub txtAntallSalg_TextChanged(sender As Object, e As EventArgs) Handles txtAntallSalg.TextChanged
        Dim enhetspris As Integer = CInt(txtEnhetsprisSalg.Text)
        Dim antall As Integer = CInt(txtAntallSalg.Text)
        txtPrisSalg.Text = CInt(enhetspris * antall)

    End Sub
End Class