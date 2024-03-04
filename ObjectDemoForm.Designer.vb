<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ObjectDemoForm
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        LoadPictureButton = New Button()
        ExitButton = New Button()
        GroupBox1 = New GroupBox()
        SampleTextBox = New TextBox()
        GroupBox2 = New GroupBox()
        TahomaRadioButton = New RadioButton()
        MagnetoRadioButton = New RadioButton()
        GaramondRadioButton = New RadioButton()
        GroupBox3 = New GroupBox()
        BoldItalicCheckBox = New CheckBox()
        BoldCheckBox = New CheckBox()
        ItalicCheckBox = New CheckBox()
        GroupBox4 = New GroupBox()
        RedRadioButton = New RadioButton()
        BlueRadioButton = New RadioButton()
        GreenRadioButton = New RadioButton()
        PictureBox = New PictureBox()
        GroupBox1.SuspendLayout()
        GroupBox2.SuspendLayout()
        GroupBox3.SuspendLayout()
        GroupBox4.SuspendLayout()
        CType(PictureBox, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' LoadPictureButton
        ' 
        LoadPictureButton.Font = New Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point)
        LoadPictureButton.Location = New Point(12, 260)
        LoadPictureButton.Name = "LoadPictureButton"
        LoadPictureButton.Size = New Size(159, 54)
        LoadPictureButton.TabIndex = 0
        LoadPictureButton.Text = "&Load Picture"
        LoadPictureButton.UseVisualStyleBackColor = True
        ' 
        ' ExitButton
        ' 
        ExitButton.Font = New Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point)
        ExitButton.Location = New Point(589, 260)
        ExitButton.Name = "ExitButton"
        ExitButton.Size = New Size(133, 54)
        ExitButton.TabIndex = 1
        ExitButton.Text = "E&xit"
        ExitButton.UseVisualStyleBackColor = True
        ' 
        ' GroupBox1
        ' 
        GroupBox1.Controls.Add(SampleTextBox)
        GroupBox1.Location = New Point(12, 12)
        GroupBox1.Name = "GroupBox1"
        GroupBox1.Size = New Size(254, 66)
        GroupBox1.TabIndex = 2
        GroupBox1.TabStop = False
        GroupBox1.Text = "Display Text"
        ' 
        ' SampleTextBox
        ' 
        SampleTextBox.Font = New Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point)
        SampleTextBox.Location = New Point(40, 22)
        SampleTextBox.Name = "SampleTextBox"
        SampleTextBox.Size = New Size(120, 27)
        SampleTextBox.TabIndex = 0
        SampleTextBox.Text = "Sample Test"
        ' 
        ' GroupBox2
        ' 
        GroupBox2.Controls.Add(TahomaRadioButton)
        GroupBox2.Controls.Add(MagnetoRadioButton)
        GroupBox2.Controls.Add(GaramondRadioButton)
        GroupBox2.Location = New Point(323, 12)
        GroupBox2.Name = "GroupBox2"
        GroupBox2.Size = New Size(411, 66)
        GroupBox2.TabIndex = 3
        GroupBox2.TabStop = False
        GroupBox2.Text = "Font"
        ' 
        ' TahomaRadioButton
        ' 
        TahomaRadioButton.AutoSize = True
        TahomaRadioButton.Location = New Point(286, 27)
        TahomaRadioButton.Name = "TahomaRadioButton"
        TahomaRadioButton.Size = New Size(67, 19)
        TahomaRadioButton.TabIndex = 2
        TahomaRadioButton.TabStop = True
        TahomaRadioButton.Text = "Tahoma"
        TahomaRadioButton.UseVisualStyleBackColor = True
        ' 
        ' MagnetoRadioButton
        ' 
        MagnetoRadioButton.AutoSize = True
        MagnetoRadioButton.Location = New Point(144, 27)
        MagnetoRadioButton.Name = "MagnetoRadioButton"
        MagnetoRadioButton.Size = New Size(73, 19)
        MagnetoRadioButton.TabIndex = 1
        MagnetoRadioButton.TabStop = True
        MagnetoRadioButton.Text = "Magneto"
        MagnetoRadioButton.UseVisualStyleBackColor = True
        ' 
        ' GaramondRadioButton
        ' 
        GaramondRadioButton.AutoSize = True
        GaramondRadioButton.Location = New Point(26, 26)
        GaramondRadioButton.Name = "GaramondRadioButton"
        GaramondRadioButton.Size = New Size(81, 19)
        GaramondRadioButton.TabIndex = 0
        GaramondRadioButton.TabStop = True
        GaramondRadioButton.Text = "Garamond"
        GaramondRadioButton.UseVisualStyleBackColor = True
        ' 
        ' GroupBox3
        ' 
        GroupBox3.Controls.Add(BoldItalicCheckBox)
        GroupBox3.Controls.Add(BoldCheckBox)
        GroupBox3.Controls.Add(ItalicCheckBox)
        GroupBox3.Location = New Point(372, 84)
        GroupBox3.Name = "GroupBox3"
        GroupBox3.Size = New Size(148, 167)
        GroupBox3.TabIndex = 4
        GroupBox3.TabStop = False
        GroupBox3.Text = "Font Style"
        ' 
        ' BoldItalicCheckBox
        ' 
        BoldItalicCheckBox.AutoSize = True
        BoldItalicCheckBox.Font = New Font("Segoe UI", 9.75F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point)
        BoldItalicCheckBox.Location = New Point(25, 119)
        BoldItalicCheckBox.Name = "BoldItalicCheckBox"
        BoldItalicCheckBox.Size = New Size(89, 21)
        BoldItalicCheckBox.TabIndex = 2
        BoldItalicCheckBox.Text = "Bold Italic"
        BoldItalicCheckBox.UseVisualStyleBackColor = True
        ' 
        ' BoldCheckBox
        ' 
        BoldCheckBox.AutoSize = True
        BoldCheckBox.Font = New Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point)
        BoldCheckBox.Location = New Point(22, 75)
        BoldCheckBox.Name = "BoldCheckBox"
        BoldCheckBox.Size = New Size(55, 21)
        BoldCheckBox.TabIndex = 1
        BoldCheckBox.Text = "Bold"
        BoldCheckBox.UseVisualStyleBackColor = True
        ' 
        ' ItalicCheckBox
        ' 
        ItalicCheckBox.AutoSize = True
        ItalicCheckBox.Font = New Font("Segoe UI", 9.75F, FontStyle.Italic, GraphicsUnit.Point)
        ItalicCheckBox.Location = New Point(18, 32)
        ItalicCheckBox.Name = "ItalicCheckBox"
        ItalicCheckBox.Size = New Size(53, 21)
        ItalicCheckBox.TabIndex = 0
        ItalicCheckBox.Text = "Italic"
        ItalicCheckBox.UseVisualStyleBackColor = True
        ' 
        ' GroupBox4
        ' 
        GroupBox4.Controls.Add(RedRadioButton)
        GroupBox4.Controls.Add(BlueRadioButton)
        GroupBox4.Controls.Add(GreenRadioButton)
        GroupBox4.Location = New Point(561, 84)
        GroupBox4.Name = "GroupBox4"
        GroupBox4.Size = New Size(173, 170)
        GroupBox4.TabIndex = 5
        GroupBox4.TabStop = False
        GroupBox4.Text = "Font Color"
        ' 
        ' RedRadioButton
        ' 
        RedRadioButton.AutoSize = True
        RedRadioButton.Location = New Point(41, 130)
        RedRadioButton.Name = "RedRadioButton"
        RedRadioButton.Size = New Size(45, 19)
        RedRadioButton.TabIndex = 2
        RedRadioButton.TabStop = True
        RedRadioButton.Text = "&Red"
        RedRadioButton.UseVisualStyleBackColor = True
        ' 
        ' BlueRadioButton
        ' 
        BlueRadioButton.AutoSize = True
        BlueRadioButton.Location = New Point(38, 74)
        BlueRadioButton.Name = "BlueRadioButton"
        BlueRadioButton.Size = New Size(48, 19)
        BlueRadioButton.TabIndex = 1
        BlueRadioButton.TabStop = True
        BlueRadioButton.Text = "&Blue"
        BlueRadioButton.UseVisualStyleBackColor = True
        ' 
        ' GreenRadioButton
        ' 
        GreenRadioButton.AutoSize = True
        GreenRadioButton.Location = New Point(38, 30)
        GreenRadioButton.Name = "GreenRadioButton"
        GreenRadioButton.Size = New Size(56, 19)
        GreenRadioButton.TabIndex = 0
        GreenRadioButton.TabStop = True
        GreenRadioButton.Text = "&Green"
        GreenRadioButton.UseVisualStyleBackColor = True
        ' 
        ' PictureBox
        ' 
        PictureBox.Location = New Point(24, 84)
        PictureBox.Name = "PictureBox"
        PictureBox.Size = New Size(242, 167)
        PictureBox.TabIndex = 6
        PictureBox.TabStop = False
        ' 
        ' ObjectDemoForm
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(765, 317)
        Controls.Add(PictureBox)
        Controls.Add(GroupBox4)
        Controls.Add(GroupBox3)
        Controls.Add(GroupBox2)
        Controls.Add(GroupBox1)
        Controls.Add(ExitButton)
        Controls.Add(LoadPictureButton)
        Name = "ObjectDemoForm"
        Text = "Object Demonstration"
        GroupBox1.ResumeLayout(False)
        GroupBox1.PerformLayout()
        GroupBox2.ResumeLayout(False)
        GroupBox2.PerformLayout()
        GroupBox3.ResumeLayout(False)
        GroupBox3.PerformLayout()
        GroupBox4.ResumeLayout(False)
        GroupBox4.PerformLayout()
        CType(PictureBox, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
    End Sub

    Friend WithEvents LoadPictureButton As Button
    Friend WithEvents ExitButton As Button
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents GroupBox4 As GroupBox
    Friend WithEvents PictureBox As PictureBox
    Friend WithEvents SampleTextBox As TextBox
    Friend WithEvents RedRadioButton As RadioButton
    Friend WithEvents BlueRadioButton As RadioButton
    Friend WithEvents GreenRadioButton As RadioButton
    Friend WithEvents TahomaRadioButton As RadioButton
    Friend WithEvents MagnetoRadioButton As RadioButton
    Friend WithEvents GaramondRadioButton As RadioButton
    Friend WithEvents BoldItalicCheckBox As CheckBox
    Friend WithEvents BoldCheckBox As CheckBox
    Friend WithEvents ItalicCheckBox As CheckBox
End Class
