Public Class SplashScreen
    Private Sub ProgressTimer_Tick(sender As Object, e As EventArgs) Handles ProgressTimer.Tick
        ProgressBarTimeout.Value += 5
        If ProgressBarTimeout.Value = 100 Then
            ProgressTimer.Enabled = False

            FormLogin.Show()

            Hide()
        End If
    End Sub
End Class
