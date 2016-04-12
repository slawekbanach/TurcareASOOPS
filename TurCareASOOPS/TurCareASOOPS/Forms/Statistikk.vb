Public Class Statistikk







    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Hide()
        meny.Show()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim query As String
        query = "SELECT COUNT( * ) FROM  salg"
        Dim DGview As New Dataset
        DGview.dataset(query)
        DataGridView1.DataSource = DGview.dataset(query)
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim query As String
        query = "SELECT salg_selger_id, COUNT( * ) , SUM( salg_antall * salg_pris ) 
FROM salg
GROUP BY salg_selger_id"
        Dim DGview As New Dataset
        DGview.dataset(query)
        DataGridView1.DataSource = DGview.dataset(query)
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Dim query As String
        query = "SELECT COUNT(*) FROM utleie"
        Dim DGview As New Dataset
        DGview.dataset(query)
        DataGridView1.DataSource = DGview.dataset(query)
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Dim query As String
        query = "SELECT utleie_selger_id, COUNT(*), sum(utleie_pris) FROM utleie
group by utleie_selger_id"
        Dim DGview As New Dataset
        DGview.dataset(query)
        DataGridView1.DataSource = DGview.dataset(query)
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        Dim query As String
        query = "SELECT SUM( salg_antall * salg_pris ) FROM  salg"
        Dim DGview As New Dataset
        DGview.dataset(query)
        DataGridView1.DataSource = DGview.dataset(query)
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        Dim query As String
        query = "SELECT SUM( utleie_pris ) FROM  `utleie`"
        Dim DGview As New Dataset
        DGview.dataset(query)
        DataGridView1.DataSource = DGview.dataset(query)
    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
        Dim query As String
        query = "SELECT SUM( salg_antall * salg_pris ) + SUM( utleie_pris ) 
FROM  `utleie` 
JOIN  `salg` ON salg_selger_id = utleie_selger_id"
        Dim DGview As New Dataset
        DGview.dataset(query)
        DataGridView1.DataSource = DGview.dataset(query)
    End Sub

    Private Sub Button9_Click(sender As Object, e As EventArgs) Handles Button9.Click
        Dim query As String
        query = "SELECT salg_vare, COUNT( * ) 
FROM salg
GROUP BY salg_vare"
        Dim DGview As New Dataset
        DGview.dataset(query)
        DataGridView1.DataSource = DGview.dataset(query)
    End Sub
End Class