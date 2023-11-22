<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Students
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
        Dim resources As ComponentModel.ComponentResourceManager = New ComponentModel.ComponentResourceManager(GetType(Students))
        Panel1 = New Panel()
        PictureBox1 = New PictureBox()
        PictureBox2 = New PictureBox()
        Label1 = New Label()
        StBox = New TextBox()
        PhoneBox = New TextBox()
        DepBox = New TextBox()
        SemCombo = New ComboBox()
        Label2 = New Label()
        Label3 = New Label()
        Label4 = New Label()
        Label5 = New Label()
        StSaveBtn = New Button()
        StEditBtn = New Button()
        StDeleteBtn = New Button()
        StResetBtn = New Button()
        Panel2 = New Panel()
        Label6 = New Label()
        Label7 = New Label()
        StudentsDGV = New DataGridView()
        BackBtn = New Button()
        Panel1.SuspendLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox2, ComponentModel.ISupportInitialize).BeginInit()
        Panel2.SuspendLayout()
        CType(StudentsDGV, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
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
        Panel1.Size = New Size(934, 40)
        Panel1.TabIndex = 1
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
        PictureBox2.Location = New Point(897, 9)
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
        Label1.Size = New Size(71, 21)
        Label1.TabIndex = 4
        Label1.Text = "Students"
        ' 
        ' StBox
        ' 
        StBox.Location = New Point(63, 103)
        StBox.Name = "StBox"
        StBox.Size = New Size(145, 23)
        StBox.TabIndex = 2
        ' 
        ' PhoneBox
        ' 
        PhoneBox.Location = New Point(628, 103)
        PhoneBox.Name = "PhoneBox"
        PhoneBox.Size = New Size(145, 23)
        PhoneBox.TabIndex = 2
        ' 
        ' DepBox
        ' 
        DepBox.Location = New Point(240, 103)
        DepBox.Name = "DepBox"
        DepBox.Size = New Size(145, 23)
        DepBox.TabIndex = 2
        ' 
        ' SemCombo
        ' 
        SemCombo.FormattingEnabled = True
        SemCombo.Items.AddRange(New Object() {"1", "2", "3", "4", "5", "6", "7"})
        SemCombo.Location = New Point(426, 103)
        SemCombo.Name = "SemCombo"
        SemCombo.Size = New Size(160, 23)
        SemCombo.TabIndex = 3
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.BackColor = Color.Transparent
        Label2.Font = New Font("Ebrima", 12F, FontStyle.Bold, GraphicsUnit.Point)
        Label2.ForeColor = Color.LightSalmon
        Label2.Location = New Point(84, 41)
        Label2.Name = "Label2"
        Label2.Size = New Size(77, 21)
        Label2.TabIndex = 4
        Label2.Text = "Students"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.BackColor = Color.Transparent
        Label3.Font = New Font("Ebrima", 12F, FontStyle.Bold, GraphicsUnit.Point)
        Label3.ForeColor = Color.LightSalmon
        Label3.Location = New Point(262, 41)
        Label3.Name = "Label3"
        Label3.Size = New Size(102, 21)
        Label3.TabIndex = 4
        Label3.Text = "Department"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.BackColor = Color.Transparent
        Label4.Font = New Font("Ebrima", 12F, FontStyle.Bold, GraphicsUnit.Point)
        Label4.ForeColor = Color.LightSalmon
        Label4.Location = New Point(487, 41)
        Label4.Name = "Label4"
        Label4.Size = New Size(80, 21)
        Label4.TabIndex = 4
        Label4.Text = "Semester"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.BackColor = Color.Transparent
        Label5.Font = New Font("Ebrima", 12F, FontStyle.Bold, GraphicsUnit.Point)
        Label5.ForeColor = Color.LightSalmon
        Label5.Location = New Point(628, 41)
        Label5.Name = "Label5"
        Label5.Size = New Size(59, 21)
        Label5.TabIndex = 4
        Label5.Text = "Phone"
        ' 
        ' StSaveBtn
        ' 
        StSaveBtn.FlatAppearance.BorderSize = 0
        StSaveBtn.ForeColor = Color.Black
        StSaveBtn.Location = New Point(167, 166)
        StSaveBtn.Name = "StSaveBtn"
        StSaveBtn.Size = New Size(99, 34)
        StSaveBtn.TabIndex = 7
        StSaveBtn.Text = "Save"
        StSaveBtn.UseVisualStyleBackColor = True
        ' 
        ' StEditBtn
        ' 
        StEditBtn.FlatAppearance.BorderSize = 0
        StEditBtn.ForeColor = Color.Black
        StEditBtn.Location = New Point(319, 166)
        StEditBtn.Name = "StEditBtn"
        StEditBtn.Size = New Size(99, 34)
        StEditBtn.TabIndex = 7
        StEditBtn.Text = "Edit"
        StEditBtn.UseVisualStyleBackColor = True
        ' 
        ' StDeleteBtn
        ' 
        StDeleteBtn.FlatAppearance.BorderSize = 0
        StDeleteBtn.ForeColor = Color.Black
        StDeleteBtn.Location = New Point(468, 166)
        StDeleteBtn.Name = "StDeleteBtn"
        StDeleteBtn.Size = New Size(99, 34)
        StDeleteBtn.TabIndex = 7
        StDeleteBtn.Text = "Delete"
        StDeleteBtn.UseVisualStyleBackColor = True
        ' 
        ' StResetBtn
        ' 
        StResetBtn.FlatAppearance.BorderSize = 0
        StResetBtn.ForeColor = Color.Black
        StResetBtn.Location = New Point(628, 166)
        StResetBtn.Name = "StResetBtn"
        StResetBtn.Size = New Size(99, 34)
        StResetBtn.TabIndex = 7
        StResetBtn.Text = "Reset"
        StResetBtn.UseVisualStyleBackColor = True
        ' 
        ' Panel2
        ' 
        Panel2.Controls.Add(StResetBtn)
        Panel2.Controls.Add(StBox)
        Panel2.Controls.Add(StDeleteBtn)
        Panel2.Controls.Add(PhoneBox)
        Panel2.Controls.Add(StEditBtn)
        Panel2.Controls.Add(Label2)
        Panel2.Controls.Add(StSaveBtn)
        Panel2.Controls.Add(Label6)
        Panel2.Controls.Add(Label3)
        Panel2.Controls.Add(SemCombo)
        Panel2.Controls.Add(Label4)
        Panel2.Controls.Add(DepBox)
        Panel2.Controls.Add(Label5)
        Panel2.Location = New Point(65, 66)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(825, 233)
        Panel2.TabIndex = 8
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.BackColor = Color.Transparent
        Label6.Font = New Font("Ebrima", 12F, FontStyle.Bold, GraphicsUnit.Point)
        Label6.ForeColor = Color.LightSalmon
        Label6.Location = New Point(324, 0)
        Label6.Name = "Label6"
        Label6.Size = New Size(134, 21)
        Label6.TabIndex = 4
        Label6.Text = "Students Details"
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.BackColor = Color.Transparent
        Label7.Font = New Font("Ebrima", 12F, FontStyle.Bold, GraphicsUnit.Point)
        Label7.ForeColor = Color.LightSalmon
        Label7.Location = New Point(416, 321)
        Label7.Name = "Label7"
        Label7.Size = New Size(107, 21)
        Label7.TabIndex = 4
        Label7.Text = "Students List"
        ' 
        ' StudentsDGV
        ' 
        StudentsDGV.BackgroundColor = Color.White
        StudentsDGV.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        StudentsDGV.Location = New Point(144, 367)
        StudentsDGV.Name = "StudentsDGV"
        StudentsDGV.RowTemplate.Height = 25
        StudentsDGV.Size = New Size(608, 120)
        StudentsDGV.TabIndex = 15
        ' 
        ' BackBtn
        ' 
        BackBtn.FlatAppearance.BorderSize = 0
        BackBtn.ForeColor = Color.Black
        BackBtn.Location = New Point(375, 511)
        BackBtn.Name = "BackBtn"
        BackBtn.Size = New Size(99, 34)
        BackBtn.TabIndex = 16
        BackBtn.Text = "Back"
        BackBtn.UseVisualStyleBackColor = True
        ' 
        ' Students
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        AutoValidate = AutoValidate.Disable
        ClientSize = New Size(934, 589)
        Controls.Add(BackBtn)
        Controls.Add(StudentsDGV)
        Controls.Add(Panel2)
        Controls.Add(Panel1)
        Controls.Add(Label7)
        FormBorderStyle = FormBorderStyle.None
        Name = "Students"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Students"
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox2, ComponentModel.ISupportInitialize).EndInit()
        Panel2.ResumeLayout(False)
        Panel2.PerformLayout()
        CType(StudentsDGV, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents StBox As TextBox
    Friend WithEvents PhoneBox As TextBox
    Friend WithEvents DepBox As TextBox
    Friend WithEvents SemCombo As ComboBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents StSaveBtn As Button
    Friend WithEvents StEditBtn As Button
    Friend WithEvents StDeleteBtn As Button
    Friend WithEvents StResetBtn As Button
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents StudentsDGV As DataGridView
    Friend WithEvents BackBtn As Button
End Class
