Imports System.Security.Cryptography

Public Class SecurityHelper
    ' Digunakan untuk membuat salt random sebagai salah satu input untuk hashing password
    ' nSalt: panjang byte salt
    Public Shared Function GenerateSalt(nSalt As Integer) As String
        Dim saltBytes = New Byte(nSalt) {} ' Menginisialisasi byte array untuk menampung random bytes

        RandomNumberGenerator.Create().GetBytes(saltBytes) ' Menggunakan kelas RandomNumberGenerator untuk mengisi array bytes tadi dengan angka random

        Return Convert.ToBase64String(saltBytes) ' Mengubah array byte tadi menjadi sebuah string dengan basis 64
    End Function

    ' Digunakan untuk membuat hash teks password berdasarkan salt tertentu
    ' - password: teks password yang akan di hash
    ' - salt: salt untuk mengacak hasil hash lebih lanjut, dibuat menggunakan GenerateSalt
    ' - nIterations: banyaknya iterasi atau perulangan untuk mengacak password
    ' - nHash: panjang hasil hash
    Public Shared Function HashPassword(password As String, salt As String, nIterations As Integer, nHash As Integer)
        Dim saltBytes = Convert.FromBase64String(salt)

        Using rfcDeriveBytes As New Rfc2898DeriveBytes(password, saltBytes, nIterations)
            Return Convert.ToBase64String(rfcDeriveBytes.GetBytes(nHash))
        End Using
    End Function
End Class