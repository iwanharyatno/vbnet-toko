Imports System.Data.SqlClient

Module GlobalVariables
    Public AppConnection As New DBConnection() ' Sebuah abstraksi objek koneksi
    Public Command As SqlCommand ' Untuk menjalankan perintah sql
    Public DataAdapter As New SqlDataAdapter()
    Public DataReader As SqlDataReader ' Untuk membaca data hasil operasi INSERT
    Public SqlQuery As String ' Untuk menyimpan sintaks sql yang akan digunakan untuk query
    Public DataSet As New DataSet
    Public DataTable As DataTable ' Sebagai sebuah datasource untuk tabel atau combobox
    Public EmployeeID As String ' Untuk menyimpan data ID Pegawai yang sedang login selama aplikasi berjalan
End Module