Imports System.Data.SqlClient

Public Class Libarians
    Dim Con = New SqlConnection("Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\frank.addae\Documents\LibraryVBDatabase.mdf;Integrated Security=True;Connect Timeout=30")
    Private Sub DisplayLibrarian()
        Con.Open()
        Dim query = "Select * from LibrarianTbl"
        Dim adapter As SqlDataAdapter
        Dim cmd = New SqlCommand(query, Con)
        adapter = New SqlDataAdapter(cmd)
        Dim builder = New SqlCommandBuilder(adapter)
        Dim ds = New DataSet()
        adapter.Fill(ds)
        LibrarianDGV.DataSource = ds.Tables(0)
        Con.Close()
    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles SaveBtn.Click
        If LibName.Text = "" Or LibPhone.Text = "" Or LibPass.Text = "" Then
            MsgBox("Missing Information")
        Else
            Con.Open()
            Dim query = "insert into LibrarianTbl values('" & LibName.Text & "', '" & LibPhone.Text & "', '" & LibPass.Text & "')"
            Dim cmd As SqlCommand
            cmd = New SqlCommand(query, Con)
            cmd.ExecuteNonQuery()
            MsgBox("Librarian Saved")
            Con.Close()
            DisplayLibrarian()
            Reset()
        End If
    End Sub
    Private Sub Reset()
        LibName.Text = ""
        LibPass.Text = ""
        LibPhone.Text = ""
        key = 0
    End Sub
    Private Sub ResetBtn_Click(sender As Object, e As EventArgs) Handles ResetBtn.Click
        Reset()

    End Sub
    Dim key = 0
    Private Sub DeleteBtn_Click(sender As Object, e As EventArgs) Handles DeleteBtn.Click
        If LibName.Text = "" Or LibPhone.Text = "" Or LibPass.Text = "" Then
            MsgBox("Missing Information")
        Else
            Con.Open()
            Dim query = "delete from LibrarianTbl where LbId = " & key & ""
            Dim cmd As SqlCommand
            cmd = New SqlCommand(query, Con)
            cmd.ExecuteNonQuery()
            MsgBox("Librarian Deleted")
            Con.Close()
            DisplayLibrarian()
            Reset()
        End If
    End Sub

    Private Sub EditBtn_Click(sender As Object, e As EventArgs) Handles EditBtn.Click
        If LibName.Text = "" Or LibPhone.Text = "" Or LibPass.Text = "" Then
            MsgBox("Missing Information")
        Else
            Con.Open()
            Dim query = "Update LibrarianTbl set LbName='" & LibName.Text & "',LbPhone ='" & LibPhone.Text & "',LbPass='" & LibPass.Text & "' where LbId = '" & key & "'"
            Dim cmd As SqlCommand
            cmd = New SqlCommand(query, Con)
            cmd.ExecuteNonQuery()
            MsgBox("Librarian Edited")
            Con.Close()
            DisplayLibrarian()
            Reset()
        End If
    End Sub

    Private Sub Libarians_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        DisplayLibrarian()

    End Sub

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click
        Application.Exit()

    End Sub

    Private Sub LibrarianDGV_CellMouseClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles LibrarianDGV.CellMouseClick
        Dim row As DataGridViewRow = LibrarianDGV.Rows(e.RowIndex)
        LibName.Text = row.Cells(1).Value.ToString
        LibPhone.Text = row.Cells(2).Value.ToString
        LibPass.Text = row.Cells(3).Value.ToString


        If LibName.Text = "" Then
            key = 0
        Else
            key = Convert.ToInt32(row.Cells(0).Value.ToString)
        End If
    End Sub
End Class