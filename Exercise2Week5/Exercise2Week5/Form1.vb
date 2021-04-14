Public Class Form1

    Dim strNama As String
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim myval
        Dim strtxtbox As String
        strtxtbox = txtbox.Text
        myval = UCase(strtxtbox)
        LabelOutput.Text = myval
        LabelDate.Text = Format(Now, "Long date")
        LabelCurrency.Text = Format(250000, "RM#,##0.00")
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        strNama = "Ali"
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Label1.Text = strNama
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Dim strfirst As String
        Dim strsecond As String
        Dim strresult As String
        strfirst = txtbox2.Text
        strsecond = txtbox3.Text
        strresult = strfirst + strsecond
        Form2.Show()
        Label1.Text = strresult
    End Sub
End Class
