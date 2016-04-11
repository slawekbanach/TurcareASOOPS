Public Class Statistikk
    Private Sub Statistikk_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'g_oops_t4DataSet.salg' table. You can move, or remove it, as needed.
        Me.salgTableAdapter.Fill(Me.g_oops_t4DataSet.salg)

        Me.ReportViewer1.RefreshReport
    End Sub


End Class