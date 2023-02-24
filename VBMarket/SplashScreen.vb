''' <summary>
''' Form Splash Screen. Digunakan untuk memberi feedback loading aplikasi kepada pengguna.
''' Control Inti:
''' - ProgressBarTimeout: progress bar untuk menampilkan loading
''' - ProgressTimer: timer dengan interval 100 ms untuk mengupdate progressbar
''' </summary>

Public Class SplashScreen
    ' Menangani event timeout dari progresstimer
    Private Sub ProgressTimer_Tick(sender As Object, e As EventArgs) Handles ProgressTimer.Tick
        ProgressBarTimeout.Value += 5 ' menambah progres 5 persen setiap 100 ms
        If ProgressBarTimeout.Value = 100 Then
            ProgressTimer.Enabled = False

            FormLogin.Show()

            Hide()
        End If
    End Sub
End Class
