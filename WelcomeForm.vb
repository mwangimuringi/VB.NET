Public Class WelcomeForm
    Private Sub ExitButton_Click(Sender As Object, e As EventArgs) Handles ExitButton.Click
        Me.Close()
    End Sub
    Private Sub LoadObjectButton_Click(Sender As Object, e As EventArgs) Handles LoadObjectButton.Click
        Dim ObjectDemoForm As New ObjectDemoForm()
        ObjectDemoForm.Show()
    End Sub
    Private Sub WelcomeForm_Click(Sender As Object, e As EventArgs) Handles Me.Click
        Me.WindowState = FormWindowState.Maximized 'Maximize The Welcome Form
        Me.BackColor = Color.Red
    End Sub
End Class