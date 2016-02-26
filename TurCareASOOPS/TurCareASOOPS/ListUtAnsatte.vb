Imports MySql.Data.MySqlClient

Public Class ListUtAnsatte
    Dim command As MySqlCommand
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


    Private Sub btnTilbake_Click(sender As Object, e As EventArgs) Handles btnTilbake.Click
        Me.Hide()
        meny.Show()

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        'Dim mydata As New DataTable
        'mydata = sporring("SELECT person_fornavn, person_etternavn, person_epost, person_tlf, person_type FROM personer")
        'Try
        '    Dim pfornavn, petternavn, pepost, ptlf, ptype As String

        '    ListBox1.Items.Add("Fornavn" & vbTab & "Etternavn" & vbTab & "E-Post" & vbTab & "Telefon" & vbTab & "Stilling")
        '    ListBox1.Items.Add("")
        '    For Each rad As DataRow In mydata.Rows

        '        pfornavn = rad("person_fornavn")
        '        petternavn = rad("person_etternavn")
        '        pepost = rad("person_epost")
        '        ptlf = rad("person_tlf")
        '        ptype = rad("person_type")
        '        ListBox1.Items.Add(pfornavn & vbTab & vbTab & vbTab & petternavn & vbTab & vbTab & vbTab & pepost & vbTab & vbTab & vbTab & ptlf & vbTab & vbTab & vbTab & ptype)

        '    Next
        'Catch ex As Exception
        '    MessageBox.Show(ex.Message)
        'End Try

        Dim SDA As New MySqlDataAdapter
        Dim dbdataset As New DataTable
        Dim bsource As New BindingSource

        Try
            tilkobling.open()
            Dim query As String
            query = "SELECT person_fornavn, person_etternavn, person_epost, person_tlf, person_type FROM personer where person_type not like 'Kunde'"
            command = New MySqlCommand(query, tilkobling)
            SDA.SelectCommand = command
            SDA.Fill(dbdataset)
            bsource.DataSource = dbdataset
            DataGridView1.DataSource = bsource
            SDA.Update(dbdataset)
            tilkobling.close()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            tilkobling.dispose()

        End Try

    End Sub

    Private Sub Søk_Click(sender As Object, e As EventArgs) Handles btnSok.Click
        Dim SDA As New MySqlDataAdapter
        Dim dbdataset As New DataTable
        Dim bsource As New BindingSource
        Dim sok As String = txtSoek.Text
        Try
            tilkobling.open()
            Dim query As String
            query = "SELECT person_fornavn, person_etternavn, person_epost, person_tlf, person_type FROM personer where person_type not like 'Kunde' and (person_fornavn like '%" & sok & "%' or person_etternavn like '%" & sok & "%');"
            command = New MySqlCommand(query, tilkobling)
            SDA.SelectCommand = command
            SDA.Fill(dbdataset)
            bsource.DataSource = dbdataset
            DataGridView1.DataSource = bsource
            SDA.Update(dbdataset)
            tilkobling.close()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            tilkobling.dispose()

        End Try
    End Sub
End Class