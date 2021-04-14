Public Class Form1
    Private Sub lblTeks_Click(sender As Object, e As EventArgs) Handles lblTeks.Click
        Dim strTeks As String
        Dim i As Integer
        i = 0
        strTeks = ""
        While i < 10
            For i = 0 To 9
                strTeks &= "contoh" & vbCrLf
            Next
            i += 1
        End While
        lblTeks.Text = strTeks
    End Sub
End Class
