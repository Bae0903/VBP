Public Class Form1

    Public Function InputBox(
      ByVal Prompt As String,
      Optional ByVal Title As String = "",
      Optional ByVal DefaultResponse As String = "",
      Optional ByVal Xpos As Integer = -1,
      Optional ByVal YPos As Integer = -1
) As String

    End Function

    Private Sub Button1_Click(ByVal sender As System.Object,
                                 ByVal e As System.EventArgs) _
                                 Handles Button1.Click
        InputBox("Enter Student's Date of Birth")
    End Sub


End Class
