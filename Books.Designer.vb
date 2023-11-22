<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Books
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
        Dim resources As ComponentModel.ComponentResourceManager = New ComponentModel.ComponentResourceManager(GetType(Books))
        Label9 = New Label()
        BLib = New Label()
        Label6 = New Label()
        Panel2 = New Panel()
        ResetBtn = New Button()
        BNameTb = New TextBox()
        DeleteBtn = New Button()
        BQuantityTb = New TextBox()
        EditBtn = New Button()
        Label2 = New Label()
        SaveBtn = New Button()
        Label3 = New Label()
        Label10 = New Label()
        Label4 = New Label()
        BPriceTb = New TextBox()
        BPublisherTb = New TextBox()
        BAuthorTb = New TextBox()
        Label5 = New Label()
        BooksDGV = New DataGridView()
        PictureBox1 = New PictureBox()
        PictureBox2 = New PictureBox()
        Label1 = New Label()
        Panel1 = New Panel()
        BackBtn = New Button()
        Panel2.SuspendLayout()
        CType(BooksDGV, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox2, ComponentModel.ISupportInitialize).BeginInit()
        Panel1.SuspendLayout()
        SuspendLayout()
        ' 
        ' Label9
        ' 
        Label9.AutoSize = True
        Label9.BackColor = Color.Transparent
        Label9.Font = New Font("Ebrima", 12F, FontStyle.Bold, GraphicsUnit.Point)
        Label9.ForeColor = Color.LightSalmon
        Label9.Location = New Point(390, 555)
        Label9.Name = "Label9"
        Label9.Size = New Size(51, 21)
        Label9.TabIndex = 11
        Label9.Text = "Reset"
        ' 
        ' BLib
        ' 
        BLib.AutoSize = True
        BLib.BackColor = Color.Transparent
        BLib.Font = New Font("Ebrima", 12F, FontStyle.Bold, GraphicsUnit.Point)
        BLib.ForeColor = Color.LightSalmon
        BLib.Location = New Point(380, 296)
        BLib.Name = "BLib"
        BLib.Size = New Size(86, 21)
        BLib.TabIndex = 12
        BLib.Text = "Books List"
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.BackColor = Color.Transparent
        Label6.Font = New Font("Ebrima", 12F, FontStyle.Bold, GraphicsUnit.Point)
        Label6.ForeColor = Color.LightSalmon
        Label6.Location = New Point(402, 1)
        Label6.Name = "Label6"
        Label6.Size = New Size(113, 21)
        Label6.TabIndex = 4
        Label6.Text = "Books Details"
        ' 
        ' Panel2
        ' 
        Panel2.Controls.Add(ResetBtn)
        Panel2.Controls.Add(BNameTb)
        Panel2.Controls.Add(DeleteBtn)
        Panel2.Controls.Add(BQuantityTb)
        Panel2.Controls.Add(EditBtn)
        Panel2.Controls.Add(Label2)
        Panel2.Controls.Add(SaveBtn)
        Panel2.Controls.Add(Label6)
        Panel2.Controls.Add(Label3)
        Panel2.Controls.Add(Label10)
        Panel2.Controls.Add(Label4)
        Panel2.Controls.Add(BPriceTb)
        Panel2.Controls.Add(BPublisherTb)
        Panel2.Controls.Add(BAuthorTb)
        Panel2.Controls.Add(Label5)
        Panel2.Location = New Point(-42, 61)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(925, 215)
        Panel2.TabIndex = 13
        ' 
        ' ResetBtn
        ' 
        ResetBtn.FlatAppearance.BorderSize = 0
        ResetBtn.ForeColor = Color.Black
        ResetBtn.Location = New Point(628, 166)
        ResetBtn.Name = "ResetBtn"
        ResetBtn.Size = New Size(99, 34)
        ResetBtn.TabIndex = 7
        ResetBtn.Text = "Reset"
        ResetBtn.UseVisualStyleBackColor = True
        ' 
        ' BNameTb
        ' 
        BNameTb.Location = New Point(63, 103)
        BNameTb.Name = "BNameTb"
        BNameTb.Size = New Size(145, 23)
        BNameTb.TabIndex = 2
        ' 
        ' DeleteBtn
        ' 
        DeleteBtn.FlatAppearance.BorderSize = 0
        DeleteBtn.ForeColor = Color.Black
        DeleteBtn.Location = New Point(468, 166)
        DeleteBtn.Name = "DeleteBtn"
        DeleteBtn.Size = New Size(99, 34)
        DeleteBtn.TabIndex = 7
        DeleteBtn.Text = "Delete"
        DeleteBtn.UseVisualStyleBackColor = True
        ' 
        ' BQuantityTb
        ' 
        BQuantityTb.Location = New Point(744, 103)
        BQuantityTb.Name = "BQuantityTb"
        BQuantityTb.Size = New Size(145, 23)
        BQuantityTb.TabIndex = 2
        ' 
        ' EditBtn
        ' 
        EditBtn.FlatAppearance.BorderSize = 0
        EditBtn.ForeColor = Color.Black
        EditBtn.Location = New Point(319, 166)
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
        Label2.Location = New Point(84, 41)
        Label2.Name = "Label2"
        Label2.Size = New Size(56, 21)
        Label2.TabIndex = 4
        Label2.Text = "Name"
        ' 
        ' SaveBtn
        ' 
        SaveBtn.FlatAppearance.BorderSize = 0
        SaveBtn.ForeColor = Color.Black
        SaveBtn.Location = New Point(167, 166)
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
        Label3.Location = New Point(262, 41)
        Label3.Name = "Label3"
        Label3.Size = New Size(63, 21)
        Label3.TabIndex = 4
        Label3.Text = "Author"
        ' 
        ' Label10
        ' 
        Label10.AutoSize = True
        Label10.BackColor = Color.Transparent
        Label10.Font = New Font("Ebrima", 12F, FontStyle.Bold, GraphicsUnit.Point)
        Label10.ForeColor = Color.LightSalmon
        Label10.Location = New Point(622, 41)
        Label10.Name = "Label10"
        Label10.Size = New Size(48, 21)
        Label10.TabIndex = 4
        Label10.Text = "Price"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.BackColor = Color.Transparent
        Label4.Font = New Font("Ebrima", 12F, FontStyle.Bold, GraphicsUnit.Point)
        Label4.ForeColor = Color.LightSalmon
        Label4.Location = New Point(422, 41)
        Label4.Name = "Label4"
        Label4.Size = New Size(82, 21)
        Label4.TabIndex = 4
        Label4.Text = "Publisher"
        ' 
        ' BPriceTb
        ' 
        BPriceTb.Location = New Point(595, 103)
        BPriceTb.Name = "BPriceTb"
        BPriceTb.Size = New Size(93, 23)
        BPriceTb.TabIndex = 2
        ' 
        ' BPublisherTb
        ' 
        BPublisherTb.Location = New Point(422, 103)
        BPublisherTb.Name = "BPublisherTb"
        BPublisherTb.Size = New Size(145, 23)
        BPublisherTb.TabIndex = 2
        ' 
        ' BAuthorTb
        ' 
        BAuthorTb.Location = New Point(262, 103)
        BAuthorTb.Name = "BAuthorTb"
        BAuthorTb.Size = New Size(145, 23)
        BAuthorTb.TabIndex = 2
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.BackColor = Color.Transparent
        Label5.Font = New Font("Ebrima", 12F, FontStyle.Bold, GraphicsUnit.Point)
        Label5.ForeColor = Color.LightSalmon
        Label5.Location = New Point(744, 41)
        Label5.Name = "Label5"
        Label5.Size = New Size(77, 21)
        Label5.TabIndex = 4
        Label5.Text = "Quantity"
        ' 
        ' BooksDGV
        ' 
        BooksDGV.BackgroundColor = Color.White
        BooksDGV.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        BooksDGV.Location = New Point(64, 335)
        BooksDGV.Name = "BooksDGV"
        BooksDGV.RowTemplate.Height = 25
        BooksDGV.Size = New Size(735, 154)
        BooksDGV.TabIndex = 14
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
        PictureBox2.Location = New Point(893, 7)
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
        Label1.Size = New Size(52, 21)
        Label1.TabIndex = 4
        Label1.Text = "Books"
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
        Panel1.Size = New Size(929, 40)
        Panel1.TabIndex = 10
        ' 
        ' BackBtn
        ' 
        BackBtn.FlatAppearance.BorderSize = 0
        BackBtn.ForeColor = Color.Black
        BackBtn.Location = New Point(367, 495)
        BackBtn.Name = "BackBtn"
        BackBtn.Size = New Size(99, 34)
        BackBtn.TabIndex = 7
        BackBtn.Text = "Back"
        BackBtn.UseVisualStyleBackColor = True
        ' 
        ' Books
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(929, 600)
        Controls.Add(Label9)
        Controls.Add(BLib)
        Controls.Add(Panel2)
        Controls.Add(BooksDGV)
        Controls.Add(Panel1)
        Controls.Add(BackBtn)
        FormBorderStyle = FormBorderStyle.None
        Name = "Books"
        Text = "Books"
        Panel2.ResumeLayout(False)
        Panel2.PerformLayout()
        CType(BooksDGV, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox2, ComponentModel.ISupportInitialize).EndInit()
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label9 As Label
    Friend WithEvents BLib As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Panel2 As Panel
    Friend WithEvents ResetBtn As Button
    Friend WithEvents BNameTb As TextBox
    Friend WithEvents DeleteBtn As Button
    Friend WithEvents BQuantityTb As TextBox
    Friend WithEvents EditBtn As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents SaveBtn As Button
    Friend WithEvents Label3 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents BPriceTb As TextBox
    Friend WithEvents BPublisherTb As TextBox
    Friend WithEvents BAuthorTb As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents BooksDGV As DataGridView
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents BackBtn As Button
End Class
