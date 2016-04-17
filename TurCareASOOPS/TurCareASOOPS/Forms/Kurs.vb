Imports MySql.Data.MySqlClient
Public Class Kurs

    Public kursid() As String

    Private Sub Kurs_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'KursDataSet.pamelding_kurs' table. You can move, or remove it, as needed.
        Me.Pamelding_kursTableAdapter.Fill(Me.KursDataSet.pamelding_kurs)
        con.Dispose()
        DataGridView1.Visible = False
        ComboBox1.Visible = False
        DateTimePicker1.Format = DateTimePickerFormat.Custom
        DateTimePicker1.CustomFormat = "yyyy-MM-dd"
        Panel1.Visible = False
        Panel2.Visible = False
        Button3.Visible = False
        Button4.Visible = False

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Panel1.Visible = True

        Panel2.Visible = True
        Button3.Visible = True
        Button3.Text = "Registrer kurs"
        Label1.Text = "Kursinstruktør"
        Label2.Text = "Kursdato"
        Label3.Text = "Antall plasser"
        Label4.Text = "Sted"
        Label5.Text = "Type"
        Label6.Text = "Pris per deltaker"


    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim leder As String = TextBox1.Text
        Dim dato As Date = Format(DateTimePicker1.Value, "yyyy-MM-dd")
        Dim plasser As Integer = CInt(TextBox2.Text)
        Dim sted As String = TextBox3.Text
        Dim type As String = TextBox4.Text
        Dim pris As Integer = CInt(TextBox5.Text)

        Dim sporring As New Query

        Try
            sporring.sporring("INSERT INTO registrere_kurs (kurs_instruktor, kurs_dato, antall_plasser, ledige_plasser, kurs_sted, kurs_type, kurs_pris) VALUES ('" & leder & "', '" & DateTimePicker1.Text & "', '" & plasser & "', '" & plasser & "', '" & sted & "', '" & type & "', '" & pris & "');")
            MessageBox.Show("Registrering av kurs vellykket!")

        Catch ex As Exception
            MessageBox.Show("Feil: " & ex.Message)
        End Try



    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Panel1.Visible = False
        Panel2.Visible = False
        Button3.Visible = False


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
            Me.ComboBox1.Items.Clear()
            Me.ComboBox1.Items.AddRange(kurs.ToArray)

        Catch ex As System.Exception

            MessageBox.Show(ex.Message)

        End Try
        ComboBox1.Visible = True
        'Dim query As String
        'query = "SELECT person_fornavn, person_etternavn, person_epost, person_tlf, person_type FROM personer where person_type = 'Kunde'"
        'Dim DGview As New Dataset
        'DGview.dataset(query)
        'DataGridView1.DataSource = DGview.dataset(query)


    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged
        Button4.Text = "Meld på"
        Button4.Visible = True
        Me.KursDataSet.pamelding_kurs.Clear()
        kursid = ComboBox1.Text.Split(" ")

        DataGridView1.Visible = True

        'DataGridView1.Rows(0).Cells(2).Value = CInt(kursid(0))
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Try
            Me.Pamelding_kursTableAdapter.Update(Me.KursDataSet.pamelding_kurs)
            MessageBox.Show("Påmelding vellykket")
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try

    End Sub

    Private Sub dataGridView1_DefaultValuesNeeded(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewRowEventArgs) Handles DataGridView1.DefaultValuesNeeded

        e.Row.Cells("KursidDataGridViewTextBoxColumn").Value = kursid(0)


    End Sub
    Private Sub DataGridView1_RowsAdded(sender As Object, e As DataGridViewRowsAddedEventArgs) Handles DataGridView1.RowsAdded
        Try
            DataGridView1.Rows(e.RowIndex).Cells(2).ReadOnly = True
            DataGridView1.Rows(e.RowIndex).Cells(2).Value = CInt(kursid(0))
        Catch ex As Exception
        End Try

    End Sub


End Class