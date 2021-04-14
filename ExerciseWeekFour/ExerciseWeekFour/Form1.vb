Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim result As DialogResult = MessageBox.Show("Have you receive yet the PTPTN?", "ExerciseWeekFour",
        MessageBoxButtons.YesNo)
        If (result = vbYes) Then
            Label2.Text = "Congratulations! Make sure to use it well.."
        Else
            Label3.Text = "PTPTN will be given out on 26th of April 2021..Thank you for waiting!"
        End If

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class
