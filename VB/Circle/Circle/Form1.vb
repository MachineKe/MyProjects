Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Const pi As Single = 3.142
        Dim r, a, c As Single
        r = Val(TextBox1.Text)
        c = 2 * pi * r
        a = pi * r * r
        TextBox2.Text = c
        TextBox3.Text = a

    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged
    End Sub
End Class
