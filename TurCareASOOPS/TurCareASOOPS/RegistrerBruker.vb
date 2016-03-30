
Public Class RegistrerBruker

    Dim tilkobling As New DBConnect

    Private Sub RegistrerBruker_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lblBrukernavn.Visible = False
        lblPw.Visible = False
        lblGjentaPW.Visible = False
        txtPW.Visible = False
        txtGjentaPw.Visible = False
        txtBrukernavn.Visible = False


    End Sub

    Private Sub btnRegistrerBruker_Click(sender As Object, e As EventArgs) Handles btnRegistrerBruker.Click

        Dim sporring As New Query

        Dim fornavn As String = txtFornavn.Text
        Dim etternavn As String = TxtEtternavn.Text
        Dim epost As String = txtEpost.Text
        Dim tlf As Integer = txtTlf.Text
        Dim adresse As String = txtAdresse.Text
        Dim postnr As Integer = txtPostNr.Text
        Dim poststed As String = txtPoststed.Text
        Dim brukernavn As String = txtBrukernavn.Text
        Dim passord As String = txtPW.Text
        Dim passord2 As String = txtGjentaPw.Text
        Dim ansatt As Integer = radioAnsatt.checked
        Dim kunde As Integer = radioKunde.Checked

        If radioAnsatt.Checked Then

            lblBrukernavn.Visible = True
            lblPw.Visible = True
            lblGjentaPW.Visible = True
            txtPW.Visible = True
            txtGjentaPw.Visible = True
            txtBrukernavn.Visible = True

            If passord = passord2 Then

                sporring.sporring("INSERT INTO personer (person_fornavn, person_etternavn, person_epost, person_tlf, person_adresse, person_postnr, person_poststed, person_type, person_brukernavn, person_passord) 
                VALUES ('" & fornavn & "', '" & etternavn & "', '" & epost & "', '" & tlf & "', '" & adresse & "', '" & postnr & "', '" & poststed & "', 'Ansatt', '" & brukernavn & "' , '" & passord & "');")
                MessageBox.Show("Ansatt ble lagt til i databasen")
            Else
                MessageBox.Show("passordene er ikke like")
            End If
        End If

        If radioKunde.Checked Then

            sporring.sporring("INSERT INTO personer (person_fornavn, person_etternavn, person_epost, person_tlf, person_adresse, person_postnr, person_poststed, person_type) 
                VALUES ('" & fornavn & "', '" & etternavn & "', '" & epost & "', '" & tlf & "', '" & adresse & "', '" & postnr & "', '" & poststed & "', 'Kunde');")
            MessageBox.Show("Kunden ble lagt til i databasen")
        End If


    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Hide()
        meny.Show()
    End Sub

    Private Sub radioAnsatt_CheckedChanged(sender As Object, e As EventArgs) Handles radioAnsatt.CheckedChanged
        If radioAnsatt.Checked Then
            lblBrukernavn.Visible = True
            lblPw.Visible = True
            lblGjentaPW.Visible = True
            txtPW.Visible = True
            txtGjentaPw.Visible = True
            txtBrukernavn.Visible = True
            btnRegistrerBruker.Text = "Registrer ansatt"
        End If
        If radioAnsatt.Checked = False Then
            lblBrukernavn.Visible = False
            lblPw.Visible = False
            lblGjentaPW.Visible = False
            txtPW.Visible = False
            txtGjentaPw.Visible = False
            txtBrukernavn.Visible = False
            btnRegistrerBruker.Text = "Registrer kunde"


        End If
    End Sub
End Class