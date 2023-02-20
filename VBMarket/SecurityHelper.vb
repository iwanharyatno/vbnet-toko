Imports System.Security.Cryptography

Public Class SecurityHelper
    Public Shared Function GenerateSalt(nSalt As Integer) As String
        Dim saltBytes = New Byte(nSalt) {}

        RandomNumberGenerator.Create().GetBytes(saltBytes)

        Return Convert.ToBase64String(saltBytes)
    End Function

    Public Shared Function HashPassword(password As String, salt As String, nIterations As Integer, nHash As Integer)
        Dim saltBytes = Convert.FromBase64String(salt)

        Using rfcDeriveBytes As New Rfc2898DeriveBytes(password, saltBytes, nIterations)
            Return Convert.ToBase64String(rfcDeriveBytes.GetBytes(nHash))
        End Using
    End Function
End Class