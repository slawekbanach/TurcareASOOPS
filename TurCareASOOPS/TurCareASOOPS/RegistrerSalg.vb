Public Class RegistrerSalg
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim selgerid As String = TextBox1.Text
        Dim kundeid As String = TextBox2.Text
        Dim dato As String = TextBox3.Text
        Dim vare As String = TextBox4.Text
        Dim pris As String = TextBox5.Text



    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Hide()
        meny.Show()

    End Sub

    Private Sub TextBox3_TextChanged(sender As Object, e As EventArgs) Handles TextBox3.TextChanged

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        MessageBox.Show(LoginUser.bruker)
    End Sub
End Class