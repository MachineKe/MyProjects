Imports System.Reflection.Metadata

Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Const pi As Single = 3.142
        Dim r, c, a As Single
        r = Val(TextBox1.Text)
        c = pi * r * 2
        a = pi * r * r

        TextBox2.Text = c
        TextBox3.Text = a

    End Sub

End Class
