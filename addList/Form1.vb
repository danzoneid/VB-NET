Public Class Form1
    Private Sub add_Click(sender As Object, e As EventArgs) Handles add.Click
        ListBox1.Items.Add(TextBox1.Text)
        MsgBox("a")
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        ListBox1.Items.Remove(ListBox1.Items)

    End Sub
End Class
