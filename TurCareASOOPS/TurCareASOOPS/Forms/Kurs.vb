Public Class Kurs


    Private Sub Kurs_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'DatabaseDataSet.vare' table. You can move, or remove it, as needed.
        Me.VareTableAdapter.Fill(Me.DatabaseDataSet.vare)
        DataGridView1.Visible = False
        ComboBox1.Visible = False
        DateTimePicker1.Format = DateTimePickerFormat.Custom
        DateTimePicker1.CustomFormat = "yyyy-MM-dd"
        Panel1.Visible = False
        Panel2.Visible = False
        Button3.Visible = False

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
        ComboBox1.Visible = True

        'Dim sporring As New Query
        'Try

        'Catch ex As Exception

        'End Try


    End Sub
End Class