Imports System.Data.SqlClient

Public Class DBConnection
    ' Atribut koneksi yang digunakan oleh constructor SqlCommand
    Public ReadOnly Connection As New SqlConnection(My.Settings.ConnectionDB)

    ' Fungsi untuk membuka koneksi ke database
    Public Function Open()
        If ConnectionState.Closed Then ' jika status koneksi saat ini tertutup, maka buka
            Connection.Open()
        Else
            Connection.Close() ' jika sudah terbuka, tutup terlebih dahulu
            Connection.Open() ' kemudian buka lagi
        End If

        Return Connection ' kembalikan nilai koneksi yang sudah dibuka
    End Function

    ' Menutup koneksi jika sudah tidak dibutuhkan lagi
    Public Sub Close()
        Connection.Close()
    End Sub
End Class
