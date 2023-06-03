Imports System.Security.Cryptography
Imports System.Text

Partial Public Class Md5Helper
    Public Function EncryptString(str As String) As String
        Dim md5 As MD5 = MD5.Create()
        Dim byteOld As Byte() = Encoding.UTF8.GetBytes(str)
        Dim byteNew As Byte() = md5.ComputeHash(byteOld)
        Dim sb As New StringBuilder
        For Each b As Byte In byteNew
            sb.Append(b.ToString("x2"))
        Next
        Return sb.ToString
    End Function
End Class
