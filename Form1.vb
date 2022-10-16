Public Class Form1

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        score += 1
        SetLabel()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        score -= 1
        SetLabel()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        If IsNumeric(TextBox1.Text) Then
            score = TextBox1.Text
            SetLabel()
        Else
            TextBox1.Text = "Error"
        End If
    End Sub

    Private Sub SetLabel()
        Label1.Text = score
        My.Computer.FileSystem.WriteAllText("score.txt", score, False)
    End Sub

End Class

Module Program

    Public score As Integer
    Sub Main()
        Application.EnableVisualStyles()
        Application.SetCompatibleTextRenderingDefault(False)
        Dim ScoreRead As String
        ' Read score.txt and set to 0 if it does not contain an integer.
        If My.Computer.FileSystem.FileExists("score.txt") Then
            ScoreRead = My.Computer.FileSystem.ReadAllText("score.txt")
            If Not Integer.TryParse(ScoreRead, score) Then
                score = 0
                My.Computer.FileSystem.WriteAllText("score.txt", 0, False)
            End If
        Else
            My.Computer.FileSystem.WriteAllText("score.txt", 0, False)
        End If
        Application.Run(New Form1)
    End Sub

End Module