Public Class Form2

    Public Sub parenting(ByVal control1 As Object, ByVal control2 As Object)
        control1.parent = control2

    End Sub

    Private Sub Label2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Form1.Show()
        Me.Hide()
    End Sub

    Private Sub Form2_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.Text = "The Amazing Car"

        parenting(PictureBox4, PictureBox1)
        parenting(PictureBox3, PictureBox1)
        parenting(PictureBox2, PictureBox1)
    End Sub

    Private Sub Label1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub PictureBox3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub PictureBox2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox2.Click
        Form1.Show()
        Me.Hide()
    End Sub

    Private Sub PictureBox4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox4.Click
    End Sub

    Private Sub Form2_FormClosing(ByVal sender As System.Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles MyBase.FormClosing
        Application.Exit()
    End Sub

    Private Sub PictureBox3_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox3.Click
        My.Settings.Save()
        Application.Exit()
    End Sub

    Private Sub PictureBox1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox1.Click

    End Sub
End Class