Imports System.Data.SqlClient

''' <summary>
''' Form Login. Digunakan sebagai pintu masuk aplikasi bagi pegawai toko.
''' Control Inti:
''' - FieldUsername: text box untuk memasukkan username pengguna.
''' - FieldPassword: text box untuk memasukkan password pengguna.
''' - ButtonLogin: untuk menjalankan logika login.
''' - ButtonExit: menutup form login sekaligus menghentikan proses aplikasi (VBMarket.exe).
''' </summary>

Public Class FormLogin
    ' Fungsi untuk mengecek apakah input yang dimasukkan sudah valid
    Private Function IsInputValid()
        If FieldUsername.Text.Equals("") Then
            MsgBox("The field Username is required", vbObjectError, "Warning")
            Return False
        End If

        If FieldPassword.Text.Equals("") Then
            MsgBox("The field Password is required", vbObjectError, "Warning")
            Return False
        End If

        Return True
    End Function

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles ButtonExit.Click
        Dispose() ' menutup form ini
        Application.Exit() ' menghentikan proses aplikasi
    End Sub

    Private Sub FieldUsername_KeyUp(sender As Object, e As KeyEventArgs) Handles FieldUsername.KeyUp
        If e.KeyCode = Keys.Enter Then ' jika pengguna mengklik enter pada field username, maka field password akan teraktivasi
            FieldPassword.Select()
        End If
    End Sub

    Private Sub FieldPassword_KeyUp(sender As Object, e As KeyEventArgs) Handles FieldPassword.KeyUp
        If e.KeyCode = Keys.Enter Then ' jika pengguna mengklik enter pada field password, maka tombol login akan di klik secara otomatis
            ButtonLogin.PerformClick()
        End If
    End Sub

    Private Sub CheckBoxShowPassword_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBoxShowPassword.CheckedChanged
        If CheckBoxShowPassword.Checked Then ' untuk menampilkan karakter password secara utuh atau mengganti setiap karakter password tersebut dengan •
            FieldPassword.PasswordChar = ""
        Else
            FieldPassword.PasswordChar = "•"
        End If
    End Sub

    Private Sub ButtonLogin_Click(sender As Object, e As EventArgs) Handles ButtonLogin.Click
        Dim username As String = Trim(FieldUsername.Text) ' mendapatkan nilai username yang sudah di hapus kelebihan spasi di awal dan di akhir
        Dim password As String = Trim(FieldPassword.Text) ' sama juga untuk password
        Dim userRole As String = "" ' untuk pengecekan kondisi bagi pegawai

        If IsInputValid() Then ' hanya lakukan pengecekkan ke database jika semua input dinyatakan valid
            Try
                AppConnection.Open() ' membuka koneksi ke database
                SqlQuery = "SELECT * FROM Employee WHERE Username='" & username & "'" ' menyiapkan perintah sql untuk dijalankan
                Command = New SqlCommand(SqlQuery, AppConnection.Connection) ' memasangkan perintah sql tersebut kepada wrapper untuk menjalankan perintah sql
                DataReader = Command.ExecuteReader() ' memulai membaca data

                If DataReader.HasRows Then ' jika reader ada baris yang terbaca
                    While (DataReader.Read()) ' fungsi Read() digunakan untuk memajukan cursor DataReader ke baris selanjutnya
                        Dim salt As String = DataReader.Item("Salt") ' mengambil salt yang digunakan untuk melakukan hash data pengguna ini
                        Dim hashedPassword As String = SecurityHelper.HashPassword(password, salt, 10101, 70) ' melakukan hash password yang baru saja diinputkan pengguna melalui field password. Hash dilakukan dengan salt yang sama saat pengguna baru diciptakan
                        If hashedPassword = DataReader.Item("Password") Then ' menggunakan salt yang sama, jika input password yang sekarang sama dengan input password saat pertama kali pengguna diciptakan, maka hasil hash passwordnya akan sama juga
                            MsgBox("Login success!", vbInformation, "Info") ' menampilkan feedback bahwa login berhasil

                            EmployeeID = DataReader.Item("ID").ToString() ' menyimpan data pegawai yang sedang login untuk keperluan tracking?
                            userRole = DataReader.Item("Role").ToString() ' menyimpan role pegawai yang baru login untuk percabangan form

                            Hide()
                        Else
                            MsgBox("Password doesn't match", vbOKOnly, "Error")
                        End If
                    End While
                Else
                    MsgBox("The specified employee with username '" & username & "' not found", vbOKOnly, "Error")
                End If
            Catch ex As Exception
                MsgBox("Failed to run login operations: " & ex.Message)
            Finally
                AppConnection.Close()
            End Try
        End If

        If userRole = "admin" Then ' jika role-nya adalah admin
            FormAdmin.Show() ' tampilkan form admin
            FormAdmin.GetAdminInfo() ' tampilkan data-data admin yang relevan di form admin
        ElseIf userRole = "cashier" Then ' jika role-nya adalah kasir
            FormCashier.Show() ' tampilkan form kasir
            FormCashier.GetCashierData() ' tampilkan data-data kasir yang relevan di form admin
        End If
    End Sub
End Class