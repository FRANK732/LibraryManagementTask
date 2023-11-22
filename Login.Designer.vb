<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Login
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
        Dim resources As ComponentModel.ComponentResourceManager = New ComponentModel.ComponentResourceManager(GetType(Login))
        PictureBox1 = New PictureBox()
        Label1 = New Label()
        UNameBox = New TextBox()
        PassBox = New TextBox()
        Label2 = New Label()
        Label3 = New Label()
        Label4 = New Label()
        LoginBtn = New Button()
        Label5 = New Label()
        PictureBox2 = New PictureBox()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox2, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), Image)
        PictureBox1.Location = New Point(13, 61)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(122, 97)
        PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox1.TabIndex = 2
        PictureBox1.TabStop = False
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Dubai", 15.75F, FontStyle.Bold, GraphicsUnit.Point)
        Label1.ForeColor = Color.Coral
        Label1.Location = New Point(129, 9)
        Label1.Name = "Label1"
        Label1.Size = New Size(270, 36)
        Label1.TabIndex = 3
        Label1.Text = "Library Management System"
        ' 
        ' UNameBox
        ' 
        UNameBox.Location = New Point(257, 62)
        UNameBox.Name = "UNameBox"
        UNameBox.Size = New Size(142, 23)
        UNameBox.TabIndex = 4
        ' 
        ' PassBox
        ' 
        PassBox.Location = New Point(257, 111)
        PassBox.Name = "PassBox"
        PassBox.Size = New Size(142, 23)
        PassBox.TabIndex = 4
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(14, 142)
        Label2.Name = "Label2"
        Label2.Size = New Size(120, 15)
        Label2.TabIndex = 5
        Label2.Text = "  BOOKS LIBRARY       "
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Ebrima", 12F, FontStyle.Regular, GraphicsUnit.Point)
        Label3.ForeColor = Color.Coral
        Label3.Location = New Point(140, 62)
        Label3.Name = "Label3"
        Label3.Size = New Size(84, 21)
        Label3.TabIndex = 3
        Label3.Text = "UserName"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Ebrima", 12F, FontStyle.Regular, GraphicsUnit.Point)
        Label4.ForeColor = Color.Coral
        Label4.Location = New Point(140, 111)
        Label4.Name = "Label4"
        Label4.Size = New Size(77, 21)
        Label4.TabIndex = 3
        Label4.Text = "Password"
        ' 
        ' LoginBtn
        ' 
        LoginBtn.FlatAppearance.BorderSize = 0
        LoginBtn.ForeColor = Color.Black
        LoginBtn.Location = New Point(189, 151)
        LoginBtn.Name = "LoginBtn"
        LoginBtn.Size = New Size(86, 24)
        LoginBtn.TabIndex = 6
        LoginBtn.Text = "Login"
        LoginBtn.UseVisualStyleBackColor = True
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("Ebrima", 12F, FontStyle.Regular, GraphicsUnit.Point)
        Label5.ForeColor = Color.Coral
        Label5.Location = New Point(203, 182)
        Label5.Name = "Label5"
        Label5.Size = New Size(56, 21)
        Label5.TabIndex = 3
        Label5.Text = "Admin"
        ' 
        ' PictureBox2
        ' 
        PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), Image)
        PictureBox2.Location = New Point(418, 9)
        PictureBox2.Name = "PictureBox2"
        PictureBox2.Size = New Size(24, 23)
        PictureBox2.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox2.TabIndex = 2
        PictureBox2.TabStop = False
        ' 
        ' Login
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.White
        ClientSize = New Size(454, 212)
        Controls.Add(LoginBtn)
        Controls.Add(Label2)
        Controls.Add(PassBox)
        Controls.Add(UNameBox)
        Controls.Add(Label5)
        Controls.Add(Label4)
        Controls.Add(Label3)
        Controls.Add(Label1)
        Controls.Add(PictureBox2)
        Controls.Add(PictureBox1)
        ForeColor = Color.DarkOrange
        FormBorderStyle = FormBorderStyle.None
        Name = "Login"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Login"
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox2, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label1 As Label
    Friend WithEvents UNameBox As TextBox
    Friend WithEvents PassBox As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents LoginBtn As Button
    Friend WithEvents Label5 As Label
    Friend WithEvents PictureBox2 As PictureBox
End Class
