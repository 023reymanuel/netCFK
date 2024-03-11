<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class signup
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
        txtEmail = New TextBox()
        txtpassword = New TextBox()
        button = New Button()
        SuspendLayout()
        ' 
        ' txtEmail
        ' 
        txtEmail.Anchor = AnchorStyles.Top
        txtEmail.Location = New Point(207, 115)
        txtEmail.Multiline = True
        txtEmail.Name = "txtEmail"
        txtEmail.PlaceholderText = "Email Adress"
        txtEmail.Size = New Size(367, 53)
        txtEmail.TabIndex = 2
        ' 
        ' txtpassword
        ' 
        txtpassword.Anchor = AnchorStyles.Top
        txtpassword.Location = New Point(207, 216)
        txtpassword.Multiline = True
        txtpassword.Name = "txtpassword"
        txtpassword.PlaceholderText = "password"
        txtpassword.Size = New Size(367, 53)
        txtpassword.TabIndex = 3
        ' 
        ' button
        ' 
        button.Anchor = AnchorStyles.Top
        button.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        button.Location = New Point(219, 321)
        button.Name = "button"
        button.Size = New Size(367, 34)
        button.TabIndex = 4
        button.Text = "sign up"
        button.UseVisualStyleBackColor = True
        ' 
        ' signup
        ' 
        AutoScaleDimensions = New SizeF(10F, 25F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(button)
        Controls.Add(txtpassword)
        Controls.Add(txtEmail)
        Name = "signup"
        Text = "signup"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents txtEmail As TextBox
    Friend WithEvents txtpassword As TextBox
    Friend WithEvents button As Button
End Class
