Public NotInheritable Class TurCareSplash




    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        ProgressBar1.Increment(10)
        If ProgressBar1.Value = 100 Then
            LoginUser.Show()
            Me.Close()
        End If
    End Sub


End Class
