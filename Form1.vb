Public Class Form1

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Score1Plus1Button.Click
        Score1 += 1
        SetLabel()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Score1Minus1Button.Click
        Score1 -= 1
        SetLabel()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Score1SetButton.Click
        If IsNumeric(Score1TextBox.Text) Then
            Score1 = Score1TextBox.Text
            SetLabel()
        Else
            Score1TextBox.Text = "Error"
        End If
    End Sub

    Private Sub SetLabel()
        Score1Label.Text = Score1
        Score2Label.Text = Score2
        My.Computer.FileSystem.WriteAllText("score1.txt", Score1, False)
        My.Computer.FileSystem.WriteAllText("score2.txt", Score2, False)
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Score2Minus1Button.Click
        Score2 -= 1
        SetLabel()
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Score2PlusButton.Click
        Score2 += 1
        SetLabel()
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Score2SetButton.Click
        If IsNumeric(Score2TextBox.Text) Then
            Score2 = Score2TextBox.Text
            SetLabel()
        Else
            Score2TextBox.Text = "Error"
        End If
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles UpButton.Click
        Score1 += 1
        Score2 -= 1
        SetLabel()
    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles DownButton.Click
        Score1 -= 1
        Score2 += 1
        SetLabel()
    End Sub

    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox1.CheckedChanged
        TopMost = CheckBox1.Checked
        '
        'If CheckBox1.Checked Then
        '    CheckBox1.Font = New Font(CheckBox1.Font, FontStyle.Bold)
        'Else
        '    CheckBox1.Font = New Font(CheckBox1.Font, FontStyle.Regular)
        'End If
        '
    End Sub
End Class

Module Program

    Public Score1 As Integer
    Public Score2 As Integer

    Sub Main()
        Application.EnableVisualStyles()
        Application.SetCompatibleTextRenderingDefault(False)

        ' Read score files and set to 0 if they not contain an integer.
        Dim ScoreRead As String
        If My.Computer.FileSystem.FileExists("score1.txt") Then
            ScoreRead = My.Computer.FileSystem.ReadAllText("score1.txt")
            If Not Integer.TryParse(ScoreRead, Score1) Then
                Score1 = 0
                My.Computer.FileSystem.WriteAllText("score1.txt", 0, False)
            End If
        Else
            My.Computer.FileSystem.WriteAllText("score1.txt", 0, False)
        End If

        If My.Computer.FileSystem.FileExists("score2.txt") Then
            ScoreRead = My.Computer.FileSystem.ReadAllText("score2.txt")
            If Not Integer.TryParse(ScoreRead, Score2) Then
                Score2 = 0
                My.Computer.FileSystem.WriteAllText("score2.txt", 0, False)
            End If
        Else
            My.Computer.FileSystem.WriteAllText("score2.txt", 0, False)
        End If

        Application.Run(New Form1)
    End Sub

End Module