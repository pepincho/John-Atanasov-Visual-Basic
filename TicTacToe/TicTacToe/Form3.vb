Public Class Form3



    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        TextBox1.MaxLength = 5
        TextBox2.MaxLength = 5
        My.Settings.Default.player_1 = TextBox1.Text
        My.Settings.Default.player_2 = TextBox2.Text
        My.Settings.Save()
        Dim f1 As New Form1()
        f1.Show()
        Me.Hide()
    End Sub

    
    Private Sub TextBox2_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox2.TextChanged

    End Sub
End Class