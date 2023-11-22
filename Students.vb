Imports System.Data.SqlClient

Public Class Students

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click
        Application.Exit()

    End Sub

    Dim Con = New SqlConnection("Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\frank.addae\Documents\LibraryVBDatabase.mdf;Integrated Security=True;Connect Timeout=30")
    Private Sub DisplayStudents()
        Con.Open()
        Dim query = "Select * from StudentTbl"
        Dim adapter As SqlDataAdapter
        Dim cmd = New SqlCommand(query, Con)
        adapter = New SqlDataAdapter(cmd)
        Dim builder = New SqlCommandBuilder(adapter)
        Dim ds = New DataSet()
        adapter.Fill(ds)
        StudentsDGV.DataSource = ds.Tables(0)
        Con.Close()
    End Sub
    Private Sub Reset()
        StBox.Text = ""
        PhoneBox.Text = ""
        DepBox.Text = ""
        SemCombo.SelectedIndex = 0


    End Sub
    Private Sub StSaveBtn_Click(sender As Object, e As EventArgs) Handles StSaveBtn.Click
        If StBox.Text = "" Or DepBox.Text = "" Or SemCombo.SelectedIndex = -1 Or PhoneBox.Text = "" Then
            MsgBox("Missing Information")
        Else
            Con.Open()
            Dim query = "insert into StudentTbl values('" & StBox.Text & "','" & DepBox.Text & "','" & SemCombo.SelectedIndex.ToString() & "', " & PhoneBox.Text & ")"
            Dim cmd As SqlCommand
            cmd = New SqlCommand(query, Con)
            cmd.ExecuteNonQuery()
            MsgBox("Student Saved")
            Con.Close()
            DisplayStudents()
            Reset()
        End If
    End Sub

    Private Sub Students_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        DisplayStudents()

    End Sub

    Private Sub StResetBtn_Click(sender As Object, e As EventArgs) Handles StResetBtn.Click
        Reset()

    End Sub
    Dim key = 0
    Private Sub StudentsDGV_CellMouseClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles StudentsDGV.CellMouseClick
        Dim row As DataGridViewRow = StudentsDGV.Rows(e.RowIndex)
        StBox.Text = row.Cells(1).Value.ToString
        DepBox.Text = row.Cells(2).Value.ToString
        SemCombo.SelectedItem = row.Cells(3).Value.ToString
        PhoneBox.Text = row.Cells(4).Value.ToString



        If StBox.Text = "" Then
            key = 0
        Else
            key = Convert.ToInt32(row.Cells(0).Value.ToString)
        End If
    End Sub

    Private Sub StDeleteBtn_Click(sender As Object, e As EventArgs) Handles StDeleteBtn.Click
        If StBox.Text = "" Or DepBox.Text = "" Or SemCombo.SelectedIndex = -1 Or PhoneBox.Text = "" Then
            MsgBox("Missing Information")
        Else
            Con.Open()
            Dim query = "delete from StudentTbl where StId = " & key & ""
            Dim cmd As SqlCommand
            cmd = New SqlCommand(query, Con)
            cmd.ExecuteNonQuery()
            MsgBox("Book Deleted")
            Con.Close()
            DisplayStudents()
            Reset()
        End If
    End Sub

    Private Sub StEditBtn_Click(sender As Object, e As EventArgs) Handles StEditBtn.Click
        If StBox.Text = "" Or DepBox.Text = "" Or SemCombo.SelectedIndex = -1 Or PhoneBox.Text = "" Then
            MsgBox("Missing Information")
        Else
            Con.Open()
            Dim query = "Update StudentTbl set StName='" & StBox.Text & "',StDep ='" & DepBox.Text & "',StSem='" & SemCombo.SelectedValue & "',StPhone='" & PhoneBox.Text & "' where StId = '" & key & "'"
            Dim cmd As SqlCommand
            cmd = New SqlCommand(query, Con)
            cmd.ExecuteNonQuery()
            MsgBox("Book Edited")
            Con.Close()
            DisplayStudents()
            Reset()
        End If
    End Sub

    Private Sub BackBtn_Click(sender As Object, e As EventArgs) Handles BackBtn.Click
        Dim Obj = New MainForm
        Obj.Show()
        Me.Hide()

    End Sub
End Class