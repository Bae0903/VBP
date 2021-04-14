Public Class Form1


    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim number As Integer
        Dim total As Integer
        number = Microsoft.VisualBasic.InputBox("Time Table: ", "Message Entry Form", "Insert value", 500, 700)
        For i = 0 To 12 Step 1
            total = number * i
            Label1.Text = (number.ToString & " x " & i.ToString & " = " & total.ToString)
        Next


    End Sub
End Class
