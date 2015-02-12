Public Class Form1

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click

        Dim a, b As Integer
        a = CInt(TextBox1.Text)

        Do While a > 0
            b = a Mod 2
            Label1.Text = b & Label1.Text
            a = a \ 2
        Loop

    End Sub
End Class
