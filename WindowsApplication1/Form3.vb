Public Class Form3
    Private Sub registerVoterButton_Click(sender As Object, e As EventArgs) Handles registerVoterButton.Click
        Form1.ShowDialog()
    End Sub

    Private Sub verifyVoterButton_Click(sender As Object, e As EventArgs) Handles verifyVoterButton.Click
        Form2.ShowDialog()
    End Sub

    Private Sub registerCandidateButton_Click(sender As Object, e As EventArgs) Handles registerCandidateButton.Click
        Form4.ShowDialog()
    End Sub
End Class