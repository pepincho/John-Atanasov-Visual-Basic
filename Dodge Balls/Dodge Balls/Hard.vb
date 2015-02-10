Imports Microsoft.VisualBasic.PowerPacks

Public Class Hard
    Dim balls(3) As OvalShape
    Dim MoveRight(3) As Boolean
    Dim MoveUp(3) As Boolean
    Dim Speed(3) As Integer
    Dim x As Integer

    Public scorecounter As Integer = 0

    Private Sub OvalShape1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OvalShape1.Click, OvalShape3.Click, OvalShape2.Click

    End Sub

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        For Me.x = 1 To 3
            If MoveRight(x) = True Then
                balls(x).Left += Speed(x)
            Else : balls(x).Left -= Speed(x)
            End If

            If MoveUp(x) = True Then
                balls(x).Top -= Speed(x)
            Else : balls(x).Top += Speed(x)
            End If

            If balls(x).Left <= Me.ClientRectangle.Left Then
                MoveRight(x) = True
            End If

            If balls(x).Left + OvalShape1.Width >= Me.ClientRectangle.Right Then
                MoveRight(x) = False
            End If

            If balls(x).Top <= Me.ClientRectangle.Top Then
                MoveUp(x) = False
            End If

            If balls(x).Top + OvalShape1.Height >= Me.ClientRectangle.Bottom Then
                MoveUp(x) = True
            End If
        Next

    End Sub

    Private Sub Form1_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles Me.KeyPress
        If Asc(e.KeyChar) = 97 And PictureBox2.Left > 0 Then
            PictureBox2.Left -= 13
        ElseIf Asc(e.KeyChar) = 100 And PictureBox2.Left < Me.Width - 50 Then
            PictureBox2.Left += 13
        ElseIf Asc(e.KeyChar) = 119 And PictureBox2.Top > 5 Then
            PictureBox2.Top -= 13
        ElseIf Asc(e.KeyChar) = 115 And PictureBox2.Top < Me.Height - 89 Then
            PictureBox2.Top += 13
        End If
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.DoubleBuffered = True
        balls(1) = OvalShape1
        balls(2) = OvalShape2
        balls(3) = OvalShape3

        MoveUp(1) = True
        MoveUp(2) = False
        MoveUp(3) = False

        MoveRight(1) = True
        MoveRight(2) = True
        MoveRight(3) = False

        For Me.x = 1 To 3
            Speed(x) = x
        Next


    End Sub

    Private Sub CheckTick_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckTick.Tick
        If PictureBox2.Bounds.IntersectsWith(OvalShape1.Bounds) Then
            Me.Close()
            MsgBox("Вие загубихте ! Изкарахте " + scorecounter.ToString + " точки !")
            Application.Exit()

        ElseIf PictureBox2.Bounds.IntersectsWith(OvalShape2.Bounds) Then
            Me.Close()
            MsgBox("Вие загубихте ! Изкарахте " + scorecounter.ToString + " точки !")
            Application.Exit()

        ElseIf PictureBox2.Bounds.IntersectsWith(OvalShape3.Bounds) Then
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
