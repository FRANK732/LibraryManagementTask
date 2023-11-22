Public Class MainForm
    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click, Label2.Click, Label3.Click, Label4.Click, Label5.Click, Label6.Click

    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        Dim Obj = New Students
        Obj.Show()
        Me.Hide()

    End Sub

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click
        Dim Obj = New Books
        Obj.Show()
        Me.Hide()
    End Sub

    Private Sub LoginP_Click(sender As Object, e As EventArgs) Handles LoginP.Click
        Dim Obj = New Login
        Obj.Show()
        Me.Hide()
    End Sub
End Class