Imports System.Windows.Forms.VisualStyles.VisualStyleElement

Public Class ObjectDemoForm
    Private Sub ExitButton_Click(Sender As Object, e As EventArgs) Handles ExitButton.Click
        Me.Close()
    End Sub

    'FONT COLOR CODE
    Private Sub GreenRadioButton_CheckedChanged(Sender As Object, e As EventArgs) Handles GreenRadioButton.CheckedChanged
        If GreenRadioButton.Checked Then
            SampleTextBox.ForeColor = Color.Green
        End If
    End Sub
    Private Sub BlueRadioButton_CheckedChanged(Sender As Object, e As EventArgs) Handles BlueRadioButton.CheckedChanged
        If BlueRadioButton.Checked Then
            SampleTextBox.ForeColor = Color.Blue
        End If
    End Sub
    Private Sub RedRadioButton_CheckedChanged(Sender As Object, e As EventArgs) Handles RedRadioButton.CheckedChanged
        If RedRadioButton.Checked Then
            SampleTextBox.ForeColor = Color.Red
        End If
    End Sub

    'FONT STYLE CODE

    Private Sub CheckBoxFont_CheckedChanged(sender As Object, e As EventArgs) Handles ItalicCheckBox.CheckedChanged, BoldCheckBox.CheckedChanged, BoldItalicCheckBox.CheckedChanged
        ' Handle the CheckedChanged event for the radio buttons
        Dim selectedCheckBox As CheckBox = DirectCast(sender, CheckBox)

        ' Create a new font style based on the selected radio button
        Dim fontStyle As FontStyle = FontStyle.Regular
        If ItalicCheckBox.Checked Then
            fontStyle = FontStyle.Italic
        ElseIf BoldCheckBox.Checked Then
            fontStyle = FontStyle.Bold
        ElseIf BoldItalicCheckBox.Checked Then
            fontStyle = FontStyle.Bold.Italic
        End If

        ' Apply the new font style to the TextBox control (replace TextBox1 with your actual control name)
        SampleTextBox.Font = New Font(SampleTextBox.Font.FontFamily, SampleTextBox.Font.Size, fontStyle)
    End Sub

    'FONT CODE

    Private Sub RadioButtonFont_CheckedChanged(sender As Object, e As EventArgs)
        ' Handle the CheckedChanged event for the radio buttons
        Dim selectedRadioButton = DirectCast(sender, RadioButton)

        ' Set the font family based on the selected radio button
        Dim fontFamily As String
        Select Case selectedRadioButton.Name
            Case "GaramondRadioButton"
                fontFamily = "Garamond"
            Case "MagnetoRadioButton"
                fontFamily = "Magneto"
            Case "TahomaRadioButton"
                fontFamily = "Tahoma"
        End Select

        ' Create a new font with the selected family and keep the existing size and style
        Dim newSize = SampleTextBox.Font.Size
        Dim newStyle = SampleTextBox.Font.Style
        Dim newFont As New Font(fontFamily, newSize, newStyle)

        ' Apply the new font to the TextBox control (replace TextBox1 with your actual control name)
        SampleTextBox.Font = newFont
    End Sub

    'LOAD PICTURE CODE
    Private Sub LoadPictureButton_Click(sender As Object, e As EventArgs) Handles LoadPictureButton.Click
        Dim openFileDialog As New OpenFileDialog()
        openFileDialog.Filter = "Image Files|.bmp;.jpg;.jpeg;.png;*.gif"
        If openFileDialog.ShowDialog() = DialogResult.OK Then
            Dim imagePath As String = openFileDialog.FileName
            PictureBox.Image = Image.FromFile(imagePath)
        End If
    End Sub

    'Private Sub ObjectDemoForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    'End Sub
End Class