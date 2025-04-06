<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class LogIn
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(LogIn))
        btnLogIn = New Button()
        passBox = New TextBox()
        nameBox = New TextBox()
        Label1 = New Label()
        UserName = New Label()
        Password = New Label()
        checkBoxSave = New CheckBox()
        Label2 = New Label()
        btPasswordVisible = New Button()
        SuspendLayout()
        ' 
        ' btnLogIn
        ' 
        btnLogIn.BackColor = Color.LimeGreen
        btnLogIn.Location = New Point(232, 370)
        btnLogIn.Margin = New Padding(4, 2, 4, 2)
        btnLogIn.Name = "btnLogIn"
        btnLogIn.Size = New Size(520, 59)
        btnLogIn.TabIndex = 1
        btnLogIn.Text = "Log in"
        btnLogIn.UseVisualStyleBackColor = False
        ' 
        ' passBox
        ' 
        passBox.Location = New Point(240, 223)
        passBox.Margin = New Padding(4, 2, 4, 2)
        passBox.Multiline = True
        passBox.Name = "passBox"
        passBox.PasswordChar = "*"c
        passBox.PlaceholderText = "Enter Password"
        passBox.Size = New Size(497, 40)
        passBox.TabIndex = 2
        passBox.Text = "hthhghh"
        passBox.UseWaitCursor = True
        ' 
        ' nameBox
        ' 
        nameBox.Location = New Point(233, 151)
        nameBox.Margin = New Padding(4, 2, 4, 2)
        nameBox.Multiline = True
        nameBox.Name = "nameBox"
        nameBox.PlaceholderText = "Enter UserName"
        nameBox.Size = New Size(497, 39)
        nameBox.TabIndex = 3
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(233, 165)
        Label1.Margin = New Padding(4, 0, 4, 0)
        Label1.Name = "Label1"
        Label1.Size = New Size(0, 25)
        Label1.TabIndex = 4
        ' 
        ' UserName
        ' 
        UserName.AutoSize = True
        UserName.BackColor = SystemColors.Control
        UserName.Location = New Point(85, 165)
        UserName.Margin = New Padding(4, 0, 4, 0)
        UserName.Name = "UserName"
        UserName.Size = New Size(111, 25)
        UserName.TabIndex = 5
        UserName.Text = "UserName"
        ' 
        ' Password
        ' 
        Password.AutoSize = True
        Password.BackColor = SystemColors.Control
        Password.Location = New Point(93, 238)
        Password.Margin = New Padding(4, 0, 4, 0)
        Password.Name = "Password"
        Password.Size = New Size(103, 25)
        Password.TabIndex = 6
        Password.Text = "Password"
        ' 
        ' checkBoxSave
        ' 
        checkBoxSave.AutoSize = True
        checkBoxSave.Location = New Point(233, 319)
        checkBoxSave.Name = "checkBoxSave"
        checkBoxSave.Size = New Size(180, 29)
        checkBoxSave.TabIndex = 9
        checkBoxSave.Text = "Remember me "
        checkBoxSave.UseVisualStyleBackColor = True
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.ForeColor = Color.Blue
        Label2.Location = New Point(572, 319)
        Label2.Name = "Label2"
        Label2.Size = New Size(18, 25)
        Label2.TabIndex = 10
        Label2.Text = " "
        ' 
        ' btPasswordVisible
        ' 
        btPasswordVisible.BackgroundImage = CType(resources.GetObject("btPasswordVisible.BackgroundImage"), Image)
        btPasswordVisible.BackgroundImageLayout = ImageLayout.Zoom
        btPasswordVisible.FlatAppearance.BorderSize = 0
        btPasswordVisible.FlatStyle = FlatStyle.Flat
        btPasswordVisible.Location = New Point(744, 223)
        btPasswordVisible.Name = "btPasswordVisible"
        btPasswordVisible.Size = New Size(61, 40)
        btPasswordVisible.TabIndex = 11
        btPasswordVisible.Text = "  "
        btPasswordVisible.UseVisualStyleBackColor = True
        ' 
        ' LogIn
        ' 
        AutoScaleDimensions = New SizeF(13F, 25F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(924, 536)
        Controls.Add(btPasswordVisible)
        Controls.Add(Label2)
        Controls.Add(checkBoxSave)
        Controls.Add(Password)
        Controls.Add(UserName)
        Controls.Add(Label1)
        Controls.Add(nameBox)
        Controls.Add(passBox)
        Controls.Add(btnLogIn)
        Font = New Font("Times New Roman", 11F, FontStyle.Bold, GraphicsUnit.Point)
        Margin = New Padding(4, 2, 4, 2)
        Name = "LogIn"
        Text = "  Log in form"
        ResumeLayout(False)
        PerformLayout()
    End Sub
    Friend WithEvents btnLogIn As Button
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents passBox As TextBox
    Friend WithEvents nameBox As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents UserName As Label
    Friend WithEvents Password As Label
    Friend WithEvents checkBoxSave As CheckBox
    Friend WithEvents Label2 As Label
    Friend WithEvents btPasswordVisible As Button

End Class


