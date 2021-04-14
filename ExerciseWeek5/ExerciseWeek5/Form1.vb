Public Class Form1

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim intJumlahPelajar As Integer
        Dim BilanganMakmal As Double
        Dim strResult As String
        intJumlahPelajar = JumlahPelajar.Value
        BilanganMakmal = (Math.Ceiling(intJumlahPelajar / 40))
        strResult = CInt(Int(BilanganMakmal))
        Label1.Text = strResult.ToString & " Makmal Diperlukan"
    End Sub

End Class
