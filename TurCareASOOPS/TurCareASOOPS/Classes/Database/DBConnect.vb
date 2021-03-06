﻿Imports MySql.Data.MySqlClient

Public Class DBConnect

    Public Sub open()

        Try
            If con.State = ConnectionState.Closed Then
                con.ConnectionString = "DATABASE=" & database & ";" _
                  & "SERVER=" & server & ";user id=" & user _
                  & ";password=" & pass & ";charset=utf8"
                con.Open()
            End If

        Catch ex As Exception
            MessageBox.Show("Error Connecting to the database : " & ex.Message, "Error Database Server",
                            MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            End
        End Try
    End Sub

    Public Sub close()
        Try
            con.Close()
        Catch ex As MySqlException
            MessageBox.Show("Error closing the connection : " & ex.Message, "Error Database Server",
                            MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End Try
    End Sub

End Class
