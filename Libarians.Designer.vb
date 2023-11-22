<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Libarians
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
        Dim resources As ComponentModel.ComponentResourceManager = New ComponentModel.ComponentResourceManager(GetType(Libarians))
        Label7 = New Label()
        Label6 = New Label()
        Panel2 = New Panel()
        ResetBtn = New Button()
        LibName = New TextBox()
        DeleteBtn = New Button()
        LibPass = New TextBox()
        EditBtn = New Button()
        Label2 = New Label()
        SaveBtn = New Button()
        Label3 = New Label()
        LibPhone = New TextBox()
        Label5 = New Label()
        LibrarianDGV = New DataGridView()
        PictureBox1 = New PictureBox()
        PictureBox2 = New PictureBox()
        Label1 = New Label()
        Panel1 = New Panel()
        Button5 = New Button()
        Panel2.SuspendLayout()
        CType(LibrarianDGV, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox2, ComponentModel.ISupportInitialize).BeginInit()
        Panel1.SuspendLayout()
        SuspendLayout()
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.BackColor = Color.Transparent
        Label7.Font = New Font("Ebrima", 12F, FontStyle.Bold, GraphicsUnit.Point)
        Label7.ForeColor = Color.LightSalmon
        Label7.Location = New Point(304, 299)
        Label7.Name = "Label7"
        Label7.Size = New Size(115, 21)
        Label7.TabIndex = 12
        Label7.Text = "Librarians List"
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.BackColor = Color.Transparent
        Label6.Font = New Font("Ebrima", 12F, FontStyle.Bold, GraphicsUnit.Point)
        Label6.ForeColor = Color.LightSalmon
        Label6.Location = New Point(305, 5)
        Label6.Name = "Label6"
        Label6.Size = New Size(142, 21)
        Label6.TabIndex = 4
        Label6.Text = "Librarians Details"
        ' 
        ' Panel2
        ' 
        Panel2.Controls.Add(ResetBtn)
        Panel2.Controls.Add(LibName)
        Panel2.Controls.Add(DeleteBtn)
        Panel2.Controls.Add(LibPass)
        Panel2.Controls.Add(EditBtn)
        Panel2.Controls.Add(Label2)
        Panel2.Controls.Add(SaveBtn)
        Panel2.Controls.Add(Label6)
        Panel2.Controls.Add(Label3)
        Panel2.Controls.Add(LibPhone)
        Panel2.Controls.Add(Label5)
        Panel2.Location = New Point(37, 65)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(698, 220)
        Panel2.TabIndex = 13
        ' 
        ' ResetBtn
        ' 
        ResetBtn.FlatAppearance.BorderSize = 0
        ResetBtn.ForeColor = Color.Black
        ResetBtn.Location = New Point(526, 161)
        ResetBtn.Name = "ResetBtn"
        ResetBtn.Size = New Size(99, 34)
        ResetBtn.TabIndex = 7
        ResetBtn.Text = "Reset"
        ResetBtn.UseVisualStyleBackColor = True
        ' 
        ' LibName
        ' 
        LibName.Location = New Point(38, 98)
        LibName.Name = "LibName"
        LibName.Size = New Size(145, 23)
        LibName.TabIndex = 2
        ' 
        ' DeleteBtn
        ' 
        DeleteBtn.FlatAppearance.BorderSize = 0
        DeleteBtn.ForeColor = Color.Black
        DeleteBtn.Location = New Point(366, 161)
        DeleteBtn.Name = "DeleteBtn"
        DeleteBtn.Size = New Size(99, 34)
        DeleteBtn.TabIndex = 7
        DeleteBtn.Text = "Delete"
        DeleteBtn.UseVisualStyleBackColor = True
        ' 
        ' LibPass
        ' 
        LibPass.Location = New Point(480, 98)
        LibPass.Name = "LibPass"
        LibPass.Size = New Size(145, 23)
        LibPass.TabIndex = 2
        ' 
        ' EditBtn
        ' 
        EditBtn.FlatAppearance.BorderSize = 0
        EditBtn.ForeColor = Color.Black
        EditBtn.Location = New Point(217, 161)
        EditBtn.Name = "EditBtn"
        EditBtn.Size = New Size(99, 34)
        EditBtn.TabIndex = 7
        EditBtn.Text = "Edit"
        EditBtn.UseVisualStyleBackColor = True
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.BackColor = Color.Transparent
        Label2.Font = New Font("Ebrima", 12F, FontStyle.Bold, GraphicsUnit.Point)
        Label2.ForeColor = Color.LightSalmon
        Label2.Location = New Point(59, 36)
        Label2.Name = "Label2"
        Label2.Size = New Size(56, 21)
        Label2.TabIndex = 4
        Label2.Text = "Name"
        ' 
        ' SaveBtn
        ' 
        SaveBtn.FlatAppearance.BorderSize = 0
        SaveBtn.ForeColor = Color.Black
        SaveBtn.Location = New Point(65, 161)
        SaveBtn.Name = "SaveBtn"
        SaveBtn.Size = New Size(99, 34)
        SaveBtn.TabIndex = 7
        SaveBtn.Text = "Save"
        SaveBtn.UseVisualStyleBackColor = True
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.BackColor = Color.Transparent
        Label3.Font = New Font("Ebrima", 12F, FontStyle.Bold, GraphicsUnit.Point)
        Label3.ForeColor = Color.LightSalmon
        Label3.Location = New Point(480, 36)
        Label3.Name = "Label3"
        Label3.Size = New Size(82, 21)
        Label3.TabIndex = 4
        Label3.Text = "Password"
        ' 
        ' LibPhone
        ' 
        LibPhone.Location = New Point(237, 98)
        LibPhone.Name = "LibPhone"
        LibPhone.Size = New Size(145, 23)
        LibPhone.TabIndex = 2
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.BackColor = Color.Transparent
        Label5.Font = New Font("Ebrima", 12F, FontStyle.Bold, GraphicsUnit.Point)
        Label5.ForeColor = Color.LightSalmon
        Label5.Location = New Point(237, 36)
        Label5.Name = "Label5"
        Label5.Size = New Size(59, 21)
        Label5.TabIndex = 4
        Label5.Text = "Phone"
        ' 
        ' LibrarianDGV
        ' 
        LibrarianDGV.BackgroundColor = Color.White
        LibrarianDGV.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        LibrarianDGV.Location = New Point(114, 334)
        LibrarianDGV.Name = "LibrarianDGV"
        LibrarianDGV.RowTemplate.Height = 25
        LibrarianDGV.Size = New Size(522, 137)
        LibrarianDGV.TabIndex = 14
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), Image)
        PictureBox1.Location = New Point(12, 3)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(33, 33)
        PictureBox1.SizeMode = PictureBoxSizeMode.Zoom
        PictureBox1.TabIndex = 3
        PictureBox1.TabStop = False
        ' 
        ' PictureBox2
        ' 
        PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), Image)
        PictureBox2.Location = New Point(720, 9)
        PictureBox2.Name = "PictureBox2"
        PictureBox2.Size = New Size(24, 23)
        PictureBox2.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox2.TabIndex = 3
        PictureBox2.TabStop = False
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.BackColor = Color.Transparent
        Label1.Font = New Font("Ebrima", 12F, FontStyle.Regular, GraphicsUnit.Point)
        Label1.ForeColor = Color.White
        Label1.Location = New Point(51, 9)
        Label1.Name = "Label1"
        Label1.Size = New Size(79, 21)
        Label1.TabIndex = 4
        Label1.Text = "Librarians"
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = Color.LightSalmon
        Panel1.Controls.Add(PictureBox1)
        Panel1.Controls.Add(PictureBox2)
        Panel1.Controls.Add(Label1)
        Panel1.Dock = DockStyle.Top
        Panel1.Location = New Point(0, 0)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(754, 40)
        Panel1.TabIndex = 10
        ' 
        ' Button5
        ' 
        Button5.FlatAppearance.BorderSize = 0
        Button5.ForeColor = Color.Black
        Button5.Location = New Point(333, 511)
        Button5.Name = "Button5"
        Button5.Size = New Size(99, 34)
        Button5.TabIndex = 7
        Button5.Text = "Back"
        Button5.UseVisualStyleBackColor = True
        ' 
        ' Libarians
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(754, 557)
        Controls.Add(Label7)
        Controls.Add(Panel2)
        Controls.Add(LibrarianDGV)
        Controls.Add(Button5)
        Controls.Add(Panel1)
        FormBorderStyle = FormBorderStyle.None
        Name = "Libarians"
        Text = "Libarians"
        Panel2.ResumeLayout(False)
        Panel2.PerformLayout()
        CType(LibrarianDGV, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox2, ComponentModel.ISupportInitialize).EndInit()
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Panel2 As Panel
    Friend WithEvents ResetBtn As Button
    Friend WithEvents LibName As TextBox
    Friend WithEvents DeleteBtn As Button
    Friend WithEvents LibPass As TextBox
    Friend WithEvents EditBtn As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents SaveBtn As Button
    Friend WithEvents Label3 As Label
    Friend WithEvents LibPhone As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents LibrarianDGV As DataGridView
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Button5 As Button
End Class
