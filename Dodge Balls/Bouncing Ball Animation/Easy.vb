Public Class Easy
    Dim MoveRight As Boolean
    Dim MoveUp As Boolean

    Public scorecounter As Integer = 0

    Private Sub OvalShape1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OvalShape1.Click

    End Sub

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        If MoveRight = True Then
            OvalShape1.Left += 5
        Else : OvalShape1.Left -= 5
        End If

        If MoveUp = True Then
            OvalShape1.Top -= 5
        Else : OvalShape1.Top += 5
        End If

        If OvalShape1.Left <= Me.ClientRectangle.Left Then
            MoveRight = True
        End If

        If OvalShape1.Left + OvalShape1.Width >= Me.ClientRectangle.Right Then
            MoveRight = False
        End If

        If OvalShape1.Top <= Me.ClientRectangle.Top Then
            MoveUp = False
        End If

        If OvalShape1.Top + OvalShape1.Height >= Me.ClientRectangle.Bottom Then
            MoveUp = True
        End If

    End Sub

    Private Sub PictureBox1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox2.Click

    End Sub

    Private Sub Form1_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles Me.KeyPress
        If Asc(e.KeyChar) = 97 Then
            PictureBox2.Left -= 13
        ElseIf Asc(e.KeyChar) = 100 Then
            PictureBox2.Left += 13
        ElseIf Asc(e.KeyChar) = 119 Then
            PictureBox2.Top -= 13
        ElseIf Asc(e.KeyChar) = 115 Then
            PictureBox2.Top += 13
        End If
    End Sub

    Private Sub Form4_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.DoubleBuffered = True
    End Sub

    Private Sub CheckTick_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckTick.Tick
        If PictureBox2.Bounds.IntersectsWith(OvalShape1.Bounds) Then
            Me.Close()
            MsgBox("Вие загубихте ! Изкарахте " + scorecounter.ToString + " точки !")
            Application.Exit()
        End If
    End Sub

    Private Sub Pause_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Pause.Tick
        If Me.Visible = False Then
            CheckTick.Enabled = False
            Score.Enabled = False
        Else
            CheckTick.Enabled = True
        End If
    End Sub
    Private Sub Score_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Score.Tick
        scorecounter += 1
    End Sub
End Class
