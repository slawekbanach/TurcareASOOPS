Imports MySql.Data.MySqlClient
Public Class Query

    Public Function sporring(ByVal sql As String) As DataTable
        Dim dt As New DataTable
        Try
            con.Open()
            Dim cmd As New MySqlCommand(sql, con)
            Dim da As New MySqlDataAdapter
            da.SelectCommand = cmd
            da.Fill(dt)
            con.Close()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "SQL Spørring feilet")
            con.Close()
        Finally
            con.Dispose()
        End Try
        Return dt

    End Function

End Class
