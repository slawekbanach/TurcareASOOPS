Imports MySql.Data.MySqlClient
Public Class Dataset




    Public Function dataset(query As String)
        Dim command As MySqlCommand
        Dim SDA As New MySqlDataAdapter
        Dim dbdataset As New DataTable
        Dim bsource As New BindingSource


        Try
            command = New MySqlCommand(query, con)
            SDA.SelectCommand = command
            SDA.Fill(dbdataset)
            bsource.DataSource = dbdataset
            'DataGridView1.DataSource = bsource
            SDA.Update(dbdataset)
            Return bsource
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try


    End Function

End Class
