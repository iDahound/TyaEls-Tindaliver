<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
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
        Dim resources As ComponentModel.ComponentResourceManager = New ComponentModel.ComponentResourceManager(GetType(Form1))
        Button1 = New Button()
        txtUsername = New TextBox()
        txtPassword = New TextBox()
        SuspendLayout()
        ' 
        ' Button1
        ' 
        Button1.BackColor = Color.Transparent
        Button1.FlatStyle = FlatStyle.Popup
        Button1.Font = New Font("Bookman Old Style", 14.25F, FontStyle.Regular, GraphicsUnit.Point)
        Button1.Location = New Point(168, 421)
        Button1.Name = "Button1"
        Button1.Size = New Size(172, 37)
        Button1.TabIndex = 0
        Button1.Tag = "btnLogIn"
        Button1.Text = "LOG IN"
        Button1.UseVisualStyleBackColor = False
        ' 
        ' txtUsername
        ' 
        txtUsername.BackColor = Color.Silver
        txtUsername.BorderStyle = BorderStyle.None
        txtUsername.Font = New Font("Bookman Old Style", 9.75F, FontStyle.Regular, GraphicsUnit.Point)
        txtUsername.Location = New Point(71, 308)
        txtUsername.Name = "txtUsername"
        txtUsername.PlaceholderText = "Username"
        txtUsername.Size = New Size(364, 16)
        txtUsername.TabIndex = 1
        txtUsername.Tag = ""' 
        ' txtPassword
        ' 
        txtPassword.BackColor = Color.Silver
        txtPassword.BorderStyle = BorderStyle.None
        txtPassword.Font = New Font("Bookman Old Style", 9.75F, FontStyle.Regular, GraphicsUnit.Point)
        txtPassword.Location = New Point(71, 360)
        txtPassword.Name = "txtPassword"
        txtPassword.PasswordChar = "*"c
        txtPassword.PlaceholderText = "Password"
        txtPassword.Size = New Size(364, 16)
        txtPassword.TabIndex = 2
        txtPassword.Tag = ""' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), Image)
        BackgroundImageLayout = ImageLayout.None
        ClientSize = New Size(991, 536)
        Controls.Add(txtPassword)
        Controls.Add(txtUsername)
        Controls.Add(Button1)
        Name = "Form1"
        Text = "Log In"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Button1 As Button
    Friend WithEvents txtUsername As TextBox
    Friend WithEvents txtPassword As TextBox
End Class
