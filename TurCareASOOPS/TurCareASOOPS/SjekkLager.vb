Imports MySql.Data.MySqlClient


Public Class SjekkLager
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

    'Private Sub btnSoek_Click(sender As Object, e As EventArgs)

    '    Dim mydata As New DataTable
    '    Dim vare As String = txtsoek.Text
    '    Dim sporring = "Select * from vare where vare_navn = '" & vare & "'"
    '    Dim sql2 As New MySqlCommand(sporring, tilkobling)
    '    Dim da2 As New MySqlDataAdapter
    '    da2.SelectCommand = sql2
    '    da2.Fill(mydata)
    '    Dim varen1 = mydata.Rows(0).Item("vare_navn").ToString()
    '    Dim varen2 = mydata.Rows(0).Item("vare_id").ToString()
    '    Dim varen3 = mydata.Rows(0).Item("vare_pris").ToString()
    '    Dim varen4 = mydata.Rows(0).Item("vare_antall").ToString()
    '    With ListBox1.Items
    '        .Add("Navn" & vbTab & "ID" & vbTab & "Pris" & vbTab & "Antall")
    '        .Add("")
    '        .Add(varen1 & vbTab & varen2 & vbTab & varen3 & vbTab & varen4)
    '    End With


    'End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs)
        'ListBox1.Items.Clear()
    End Sub



    'Private Sub Button1_Click(sender As Object, e As EventArgs)

    '    Dim mydata As New DataTable
    '    mydata = sporring("SELECT vare_navn, vare_id, vare_pris, vare_antall, vare_salg_utleie FROM vare")

    '    Dim varenavn, vareid, varepris, vareantall, varesalgutleie As String

    '    ListBox1.Items.Add("Navn" & vbTab & "ID" & vbTab & "Pris" & vbTab & "Antall" & vbTab & "Salg/Utleie")
    '    ListBox1.Items.Add("")
    '    For Each rad As DataRow In mydata.Rows

    '        varenavn = rad("vare_navn")
    '        vareid = rad("vare_id")
    '        varepris = rad("vare_pris")
    '        vareantall = rad("vare_antall")
    '        varesalgutleie = rad("vare_salg_utleie")
    '        ListBox1.Items.Add(varenavn & vbTab & vareid & vbTab & varepris & vbTab & vareantall & vbTab & varesalgutleie)

    '    Next
    'End Sub

    Private Sub btnListUt_Click(sender As Object, e As EventArgs) Handles btnListUt.Click

        Dim SDA As New MySqlDataAdapter
        Dim dbdataset As New DataTable
        Dim bsource As New BindingSource

        Try
            tilkobling.open()
            Dim query As String
            query = "SELECT vare_navn, vare_salg_utleie, vare_tilstand, vare_pris, vare_status, vare_antall FROM vare"
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

    Private Sub btnTilbake_Click(sender As Object, e As EventArgs) Handles btnTilbake.Click

        Me.Hide()
        meny.Show()

    End Sub

    Private Sub btnSok_Click(sender As Object, e As EventArgs) Handles btnSok.Click

        Dim SDA As New MySqlDataAdapter
        Dim dbdataset As New DataTable
        Dim bsource As New BindingSource
        Dim sok As String = txtsoek.Text
        Try
            tilkobling.open()
            Dim query As String
            query = "SELECT vare_navn, vare_salg_utleie, vare_tilstand, vare_pris, vare_status, vare_antall FROM vare where vare_navn like '%" & sok & "%';"
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