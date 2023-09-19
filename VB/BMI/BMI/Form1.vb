Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim m, h, bmi As Single
        m = Val(TextBox1.Text)
        h = Val(TextBox2.Text)
        bmi = m / h ^ 2
        TextBox3.Text = bmi

    End Sub
End Class
