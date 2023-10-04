Public Class Form1
    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged, TextBox3.TextChanged

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim L As Double
        Dim H As Double
        Dim P As Double

        L = Val(TextBox1.Text)
        H = Val(TextBox2.Text)
        P = 2 * (L + H)
        TextBox3.Text = P
    End Sub
End Class
