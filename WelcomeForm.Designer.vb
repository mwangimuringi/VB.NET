<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class WelcomeForm
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        LoadObjectButton = New Button()
        ExitButton = New Button()
        SuspendLayout()
        ' 
        ' LoadObjectButton
        ' 
        LoadObjectButton.Font = New Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point)
        LoadObjectButton.Location = New Point(75, 177)
        LoadObjectButton.Name = "LoadObjectButton"
        LoadObjectButton.Size = New Size(142, 54)
        LoadObjectButton.TabIndex = 0
        LoadObjectButton.Text = "&Load Object Demo"
        LoadObjectButton.UseVisualStyleBackColor = True
        ' 
        ' ExitButton
        ' 
        ExitButton.Font = New Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point)
        ExitButton.Location = New Point(489, 177)
        ExitButton.Name = "ExitButton"
        ExitButton.Size = New Size(143, 54)
        ExitButton.TabIndex = 1
        ExitButton.Text = "E&xit"
        ExitButton.UseVisualStyleBackColor = True
        ' 
        ' WelcomeForm
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(761, 297)
        Controls.Add(ExitButton)
        Controls.Add(LoadObjectButton)
        Name = "WelcomeForm"
        Text = "Welcome Form"
        ResumeLayout(False)
    End Sub

    Friend WithEvents LoadObjectButton As Button
    Friend WithEvents ExitButton As Button

End Class
