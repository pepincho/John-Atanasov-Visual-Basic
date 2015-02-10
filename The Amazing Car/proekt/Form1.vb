Public Class Form1
    Dim i As Integer = 0
    Dim j As Integer = 0
    Public scorecounter As Integer = 0
    Public k1 As Integer = 0

    Public Sub carmoving(ByVal control As PictureBox)
        If control.Left >= 570 Then
            control.Left = 336
            control.Top = 478
            Form4.Show()
            Form4.Text = "You crashed! The police came and asked you a question!"
            Me.Hide()
        ElseIf (control.Left <= 125) Then
            control.Left = 336
            control.Top = 478
            Form4.Show()
            Me.Hide()
        End If
    End Sub
    Private Sub Form1_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles Me.KeyPress
        If Asc(e.KeyChar) = 97 Then
            PictureBox2.Left -= 13
        ElseIf Asc(e.KeyChar) = 100 Then
            PictureBox2.Left += 13
        End If
        carmoving(PictureBox2)
       
    End Sub


    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.Text = "The Amazing Car"
        Police.Enabled = True
        Label2.Text = "Score: "
        Form2.parenting(PictureBox4, PictureBox1)
        Form2.parenting(PictureBox6, PictureBox1)
        Form2.parenting(PictureBox2, PictureBox1)

    End Sub

    Private Sub Tabela()
        i += 1
        If i = 4 Then
            Label1.Text = "Varna"
        ElseIf i = 7 Then
            Label1.Text = "Pleven"
        ElseIf i = 10 Then
            Label1.Text = "Sofia"
        ElseIf i = 13 Then
            Label1.Text = "Plovdiv"
        ElseIf i = 16 Then
            Label1.Text = "Burgas"
            i = 0
        End If
    End Sub

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Tabeli.Tick
        Tabela()
    End Sub

    Private Sub Policiq()
        j += 1
        If j < 10 Then
            PictureBox4.Visible = False
        ElseIf j = 10 Then
            PictureBox4.Visible = True
        ElseIf j = 11 Then
            Form4.Text = "The Police Stopped you! Answer the question!"
            Form4.Show()
            Me.Hide()
            j = 0

        End If
    End Sub

    Private Sub Police_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Police.Tick
        Policiq()
    End Sub

    Private Sub Form1_FormClosing(ByVal sender As Object, ByVal e As FormClosingEventArgs) Handles MyBase.FormClosing
        Application.Exit()
    End Sub

    Private Sub Scoree()
        scorecounter += 1
        Label2.Text = "Score: " & scorecounter
    End Sub
    Private Sub Timer1_Tick_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Score.Tick
        Scoree()
    End Sub

    Private Sub Kolite_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Kolite.Tick
        k1 += 1
        If k1 >= 100 Then
            PictureBox6.Visible = True
            PictureBox6.Height += 1
            PictureBox6.Width += 1
            PictureBox6.Top += 1
            PictureBox6.Left -= 1
        End If
        If k1 >= 600 Then
            PictureBox6.Visible = False
            PictureBox6.Left = 368
            PictureBox6.Top = 319
            PictureBox6.Height = 61
            PictureBox6.Width = 72
            k1 = 0
        End If

    End Sub

    Private Sub Check_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Check.Tick
        If PictureBox2.Bounds.IntersectsWith(PictureBox6.Bounds) Then
            PictureBox6.Visible = False
            PictureBox6.Left = 368
            PictureBox6.Top = 319
            PictureBox6.Height = 61
            PictureBox6.Width = 72
            k1 = 0
            Form4.Text = "You crashed! The police came and asked you a question!"
            Form4.Show()
            Me.Hide()
        End If

    End Sub

    Private Sub Pause_Tick(sender As Object, e As EventArgs) Handles Pause.Tick
        If Me.Visible = False Then
            Tabeli.Enabled = False
            Score.Enabled = False
            Kolite.Enabled = False
            Police.Enabled = False

        Else
            Tabeli.Enabled = True
            Score.Enabled = True
            Kolite.Enabled = True
            Police.Enabled = True

        End If

    End Sub

    Private Sub PictureBox1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox1.Click

    End Sub
End Class
