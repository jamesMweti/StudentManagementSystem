Public Class frmStudentDetails
    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click

        Dim answer As DialogResult

        answer = MessageBox.Show(
         "Are you sure you want to Quit?",
         "Quit",
         MessageBoxButtons.YesNo,
         MessageBoxIcon.Question
        )

        If answer = DialogResult.Yes Then
            Application.Exit()
            Exit Sub
        End If

    End Sub
End Class