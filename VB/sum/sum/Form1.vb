Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim x As Integer = 5
        Dim y As Integer = 10
        Dim sum As Integer = x + y
        MessageBox.Show("The result = " & sum, "Integer addition")
    End Sub
End Class
