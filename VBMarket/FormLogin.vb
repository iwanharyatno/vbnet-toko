Public Class FormLogin
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles ButtonExit.Click
        Dispose()
        Application.Exit()
    End Sub

    Private Sub FieldUsername_KeyUp(sender As Object, e As KeyEventArgs) Handles FieldUsername.KeyUp
        If e.KeyCode = Keys.Enter Then
            FieldPassword.Select()
        End If
    End Sub

    Private Sub FieldPassword_KeyUp(sender As Object, e As KeyEventArgs) Handles FieldPassword.KeyUp
        If e.KeyCode = Keys.Enter Then
            ButtonLogin.PerformClick()
        End If
    End Sub

    Private Sub CheckBoxShowPassword_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBoxShowPassword.CheckedChanged
        If CheckBoxShowPassword.Checked Then
            FieldPassword.PasswordChar = ""
        Else
            FieldPassword.PasswordChar = "*"
        End If
    End Sub
End Class