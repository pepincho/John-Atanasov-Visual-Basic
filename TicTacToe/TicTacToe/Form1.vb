Public Class Form1
    Dim isX As Boolean = True
    Dim isClicked1 As Boolean = True
    Dim isClicked2 As Boolean = True
    Dim isClicked3 As Boolean = True
    Dim isClicked4 As Boolean = True
    Dim isClicked5 As Boolean = True
    Dim isClicked6 As Boolean = True
    Dim isClicked7 As Boolean = True
    Dim isClicked8 As Boolean = True
    Dim isClicked9 As Boolean = True
    Dim xResult As Integer = 0
    Dim oResult As Integer = 0
    Dim player_1 As String = My.Settings.Default.player_1
    Dim player_2 As String = My.Settings.Default.player_2

    Private Sub b1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles b1.Click
        If isClicked1 Then
            If isX Then
                b1.Text = "X"
                isX = False
            Else : b1.Text = "O"
                isX = True
            End If

            isClicked1 = False

            If b1.Text = "X" And b2.Text = "X" And b3.Text = "X" Then
                b1.BackColor = Color.Red
                b2.BackColor = Color.Red
                b3.BackColor = Color.Red
                MessageBox.Show(player_1 + " wins!", "WINNER", System.Windows.Forms.MessageBoxButtons.OKCancel, MessageBoxIcon.Information)
                xResult += 1
                lNumx.Text = xResult.ToString()
                b1.BackColor = Color.FromKnownColor(KnownColor.Control)
                b1.UseVisualStyleBackColor = True
                b2.BackColor = Color.FromKnownColor(KnownColor.Control)
                b2.UseVisualStyleBackColor = True
                b3.BackColor = Color.FromKnownColor(KnownColor.Control)
                b3.UseVisualStyleBackColor = True
                b1.Text = ""
                b2.Text = ""
                b3.Text = ""
                b4.Text = ""
                b5.Text = ""
                b6.Text = ""
                b7.Text = ""
                b8.Text = ""
                b9.Text = ""
                isClicked1 = True
                isClicked2 = True
                isClicked3 = True
                isClicked4 = True
                isClicked5 = True
                isClicked6 = True
                isClicked7 = True
                isClicked8 = True
                isClicked9 = True

            ElseIf b1.Text = "O" And b2.Text = "O" And b3.Text = "O" Then
                b1.BackColor = Color.Red
                b2.BackColor = Color.Red
                b3.BackColor = Color.Red
                MessageBox.Show(player_2 + " wins!", "WINNER", System.Windows.Forms.MessageBoxButtons.OKCancel, MessageBoxIcon.Information)
                oResult += 1
                lNumo.Text = oResult.ToString()
                b1.BackColor = Color.FromKnownColor(KnownColor.Control)
                b1.UseVisualStyleBackColor = True
                b2.BackColor = Color.FromKnownColor(KnownColor.Control)
                b2.UseVisualStyleBackColor = True
                b3.BackColor = Color.FromKnownColor(KnownColor.Control)
                b3.UseVisualStyleBackColor = True
                b1.Text = ""
                b2.Text = ""
                b3.Text = ""
                b4.Text = ""
                b5.Text = ""
                b6.Text = ""
                b7.Text = ""
                b8.Text = ""
                b9.Text = ""
                isClicked1 = True
                isClicked2 = True
                isClicked3 = True
                isClicked4 = True
                isClicked5 = True
                isClicked6 = True
                isClicked7 = True
                isClicked8 = True
                isClicked9 = True

            ElseIf b4.Text = "X" And b5.Text = "X" And b6.Text = "X" Then
                b4.BackColor = Color.Red
                b5.BackColor = Color.Red
                b6.BackColor = Color.Red
                MessageBox.Show(player_1 + " wins!", "WINNER", System.Windows.Forms.MessageBoxButtons.OKCancel, MessageBoxIcon.Information)
                xResult += 1
                lNumx.Text = xResult.ToString()
                b4.BackColor = Color.FromKnownColor(KnownColor.Control)
                b4.UseVisualStyleBackColor = True
                b5.BackColor = Color.FromKnownColor(KnownColor.Control)
                b5.UseVisualStyleBackColor = True
                b6.BackColor = Color.FromKnownColor(KnownColor.Control)
                b6.UseVisualStyleBackColor = True
                b1.Text = ""
                b2.Text = ""
                b3.Text = ""
                b4.Text = ""
                b5.Text = ""
                b6.Text = ""
                b7.Text = ""
                b8.Text = ""
                b9.Text = ""
                isClicked1 = True
                isClicked2 = True
                isClicked3 = True
                isClicked4 = True
                isClicked5 = True
                isClicked6 = True
                isClicked7 = True
                isClicked8 = True
                isClicked9 = True
            ElseIf b4.Text = "O" And b5.Text = "O" And b6.Text = "O" Then
                b4.BackColor = Color.Red
                b5.BackColor = Color.Red
                b6.BackColor = Color.Red
                MessageBox.Show(player_2 + " wins!", "WINNER", System.Windows.Forms.MessageBoxButtons.OKCancel, MessageBoxIcon.Information)
                oResult += 1
                lNumo.Text = oResult.ToString()
                b4.BackColor = Color.FromKnownColor(KnownColor.Control)
                b4.UseVisualStyleBackColor = True
                b5.BackColor = Color.FromKnownColor(KnownColor.Control)
                b5.UseVisualStyleBackColor = True
                b6.BackColor = Color.FromKnownColor(KnownColor.Control)
                b6.UseVisualStyleBackColor = True
                b1.Text = ""
                b2.Text = ""
                b3.Text = ""
                b4.Text = ""
                b5.Text = ""
                b6.Text = ""
                b7.Text = ""
                b8.Text = ""
                b9.Text = ""
                isClicked1 = True
                isClicked2 = True
                isClicked3 = True
                isClicked4 = True
                isClicked5 = True
                isClicked6 = True
                isClicked7 = True
                isClicked8 = True
                isClicked9 = True
            ElseIf b7.Text = "X" And b8.Text = "X" And b9.Text = "X" Then
                b7.BackColor = Color.Red
                b8.BackColor = Color.Red
                b9.BackColor = Color.Red
                MessageBox.Show(player_1 + " wins!", "WINNER", System.Windows.Forms.MessageBoxButtons.OKCancel, MessageBoxIcon.Information)
                xResult += 1
                lNumx.Text = xResult.ToString()
                b7.BackColor = Color.FromKnownColor(KnownColor.Control)
                b7.UseVisualStyleBackColor = True
                b8.BackColor = Color.FromKnownColor(KnownColor.Control)
                b8.UseVisualStyleBackColor = True
                b9.BackColor = Color.FromKnownColor(KnownColor.Control)
                b9.UseVisualStyleBackColor = True
                b1.Text = ""
                b2.Text = ""
                b3.Text = ""
                b4.Text = ""
                b5.Text = ""
                b6.Text = ""
                b7.Text = ""
                b8.Text = ""
                b9.Text = ""
                isClicked1 = True
                isClicked2 = True
                isClicked3 = True
                isClicked4 = True
                isClicked5 = True
                isClicked6 = True
                isClicked7 = True
                isClicked8 = True
                isClicked9 = True
            ElseIf b7.Text = "O" And b8.Text = "O" And b9.Text = "O" Then
                b7.BackColor = Color.Red
                b8.BackColor = Color.Red
                b9.BackColor = Color.Red
                MessageBox.Show(player_2 + " wins!", "WINNER", System.Windows.Forms.MessageBoxButtons.OKCancel, MessageBoxIcon.Information)
                oResult += 1
                lNumo.Text = oResult.ToString()
                b7.BackColor = Color.FromKnownColor(KnownColor.Control)
                b7.UseVisualStyleBackColor = True
                b8.BackColor = Color.FromKnownColor(KnownColor.Control)
                b8.UseVisualStyleBackColor = True
                b9.BackColor = Color.FromKnownColor(KnownColor.Control)
                b9.UseVisualStyleBackColor = True
                b1.Text = ""
                b2.Text = ""
                b3.Text = ""
                b4.Text = ""
                b5.Text = ""
                b6.Text = ""
                b7.Text = ""
                b8.Text = ""
                b9.Text = ""
                isClicked1 = True
                isClicked2 = True
                isClicked3 = True
                isClicked4 = True
                isClicked5 = True
                isClicked6 = True
                isClicked7 = True
                isClicked8 = True
                isClicked9 = True

            ElseIf b1.Text = "X" And b4.Text = "X" And b7.Text = "X" Then
                b1.BackColor = Color.Red
                b4.BackColor = Color.Red
                b7.BackColor = Color.Red
                MessageBox.Show(player_1 + " wins!", "WINNER", System.Windows.Forms.MessageBoxButtons.OKCancel, MessageBoxIcon.Information)
                xResult += 1
                lNumx.Text = xResult.ToString()
                b1.BackColor = Color.FromKnownColor(KnownColor.Control)
                b1.UseVisualStyleBackColor = True
                b4.BackColor = Color.FromKnownColor(KnownColor.Control)
                b4.UseVisualStyleBackColor = True
                b7.BackColor = Color.FromKnownColor(KnownColor.Control)
                b7.UseVisualStyleBackColor = True
                b1.Text = ""
                b2.Text = ""
                b3.Text = ""
                b4.Text = ""
                b5.Text = ""
                b6.Text = ""
                b7.Text = ""
                b8.Text = ""
                b9.Text = ""
                isClicked1 = True
                isClicked2 = True
                isClicked3 = True
                isClicked4 = True
                isClicked5 = True
                isClicked6 = True
                isClicked7 = True
                isClicked8 = True
                isClicked9 = True

            ElseIf b1.Text = "O" And b4.Text = "O" And b7.Text = "O" Then
                b1.BackColor = Color.Red
                b4.BackColor = Color.Red
                b7.BackColor = Color.Red
                MessageBox.Show(player_2 + " wins!", "WINNER", System.Windows.Forms.MessageBoxButtons.OKCancel, MessageBoxIcon.Information)
                oResult += 1
                lNumo.Text = oResult.ToString()
                b1.BackColor = Color.FromKnownColor(KnownColor.Control)
                b1.UseVisualStyleBackColor = True
                b4.BackColor = Color.FromKnownColor(KnownColor.Control)
                b4.UseVisualStyleBackColor = True
                b7.BackColor = Color.FromKnownColor(KnownColor.Control)
                b7.UseVisualStyleBackColor = True
                b1.Text = ""
                b2.Text = ""
                b3.Text = ""
                b4.Text = ""
                b5.Text = ""
                b6.Text = ""
                b7.Text = ""
                b8.Text = ""
                b9.Text = ""
                isClicked1 = True
                isClicked2 = True
                isClicked3 = True
                isClicked4 = True
                isClicked5 = True
                isClicked6 = True
                isClicked7 = True
                isClicked8 = True
                isClicked9 = True

            ElseIf b2.Text = "X" And b5.Text = "X" And b8.Text = "X" Then
                b2.BackColor = Color.Red
                b5.BackColor = Color.Red
                b8.BackColor = Color.Red
                MessageBox.Show(player_1 + " wins!", "WINNER", System.Windows.Forms.MessageBoxButtons.OKCancel, MessageBoxIcon.Information)
                xResult += 1
                lNumx.Text = xResult.ToString()
                b2.BackColor = Color.FromKnownColor(KnownColor.Control)
                b2.UseVisualStyleBackColor = True
                b5.BackColor = Color.FromKnownColor(KnownColor.Control)
                b5.UseVisualStyleBackColor = True
                b8.BackColor = Color.FromKnownColor(KnownColor.Control)
                b8.UseVisualStyleBackColor = True
                b1.Text = ""
                b2.Text = ""
                b3.Text = ""
                b4.Text = ""
                b5.Text = ""
                b6.Text = ""
                b7.Text = ""
                b8.Text = ""
                b9.Text = ""
                isClicked1 = True
                isClicked2 = True
                isClicked3 = True
                isClicked4 = True
                isClicked5 = True
                isClicked6 = True
                isClicked7 = True
                isClicked8 = True
                isClicked9 = True

            ElseIf b2.Text = "O" And b5.Text = "O" And b8.Text = "O" Then
                b2.BackColor = Color.Red
                b5.BackColor = Color.Red
                b8.BackColor = Color.Red
                MessageBox.Show(player_2 + " wins!", "WINNER", System.Windows.Forms.MessageBoxButtons.OKCancel, MessageBoxIcon.Information)
                oResult += 1
                lNumo.Text = oResult.ToString()
                b2.BackColor = Color.FromKnownColor(KnownColor.Control)
                b2.UseVisualStyleBackColor = True
                b5.BackColor = Color.FromKnownColor(KnownColor.Control)
                b5.UseVisualStyleBackColor = True
                b8.BackColor = Color.FromKnownColor(KnownColor.Control)
                b8.UseVisualStyleBackColor = True
                b1.Text = ""
                b2.Text = ""
                b3.Text = ""
                b4.Text = ""
                b5.Text = ""
                b6.Text = ""
                b7.Text = ""
                b8.Text = ""
                b9.Text = ""
                isClicked1 = True
                isClicked2 = True
                isClicked3 = True
                isClicked4 = True
                isClicked5 = True
                isClicked6 = True
                isClicked7 = True
                isClicked8 = True
                isClicked9 = True

            ElseIf b3.Text = "X" And b6.Text = "X" And b9.Text = "X" Then
                b3.BackColor = Color.Red
                b6.BackColor = Color.Red
                b9.BackColor = Color.Red
                MessageBox.Show(player_1 + " wins!", "WINNER", System.Windows.Forms.MessageBoxButtons.OKCancel, MessageBoxIcon.Information)
                xResult += 1
                lNumx.Text = xResult.ToString()
                b3.BackColor = Color.FromKnownColor(KnownColor.Control)
                b3.UseVisualStyleBackColor = True
                b6.BackColor = Color.FromKnownColor(KnownColor.Control)
                b6.UseVisualStyleBackColor = True
                b9.BackColor = Color.FromKnownColor(KnownColor.Control)
                b9.UseVisualStyleBackColor = True
                b1.Text = ""
                b2.Text = ""
                b3.Text = ""
                b4.Text = ""
                b5.Text = ""
                b6.Text = ""
                b7.Text = ""
                b8.Text = ""
                b9.Text = ""
                isClicked1 = True
                isClicked2 = True
                isClicked3 = True
                isClicked4 = True
                isClicked5 = True
                isClicked6 = True
                isClicked7 = True
                isClicked8 = True
                isClicked9 = True

            ElseIf b3.Text = "O" And b6.Text = "O" And b9.Text = "O" Then
                b3.BackColor = Color.Red
                b6.BackColor = Color.Red
                b9.BackColor = Color.Red
                MessageBox.Show(player_2 + " wins!", "WINNER", System.Windows.Forms.MessageBoxButtons.OKCancel, MessageBoxIcon.Information)
                oResult += 1
                lNumo.Text = oResult.ToString()
                b3.BackColor = Color.FromKnownColor(KnownColor.Control)
                b3.UseVisualStyleBackColor = True
                b6.BackColor = Color.FromKnownColor(KnownColor.Control)
                b6.UseVisualStyleBackColor = True
                b9.BackColor = Color.FromKnownColor(KnownColor.Control)
                b9.UseVisualStyleBackColor = True
                b1.Text = ""
                b2.Text = ""
                b3.Text = ""
                b4.Text = ""
                b5.Text = ""
                b6.Text = ""
                b7.Text = ""
                b8.Text = ""
                b9.Text = ""
                isClicked1 = True
                isClicked2 = True
                isClicked3 = True
                isClicked4 = True
                isClicked5 = True
                isClicked6 = True
                isClicked7 = True
                isClicked8 = True
                isClicked9 = True

            ElseIf b1.Text = "X" And b5.Text = "X" And b9.Text = "X" Then
                b1.BackColor = Color.Red
                b5.BackColor = Color.Red
                b9.BackColor = Color.Red
                MessageBox.Show(player_1 + " wins!", "WINNER", System.Windows.Forms.MessageBoxButtons.OKCancel, MessageBoxIcon.Information)
                xResult += 1
                lNumx.Text = xResult.ToString()
                b1.BackColor = Color.FromKnownColor(KnownColor.Control)
                b1.UseVisualStyleBackColor = True
                b5.BackColor = Color.FromKnownColor(KnownColor.Control)
                b5.UseVisualStyleBackColor = True
                b9.BackColor = Color.FromKnownColor(KnownColor.Control)
                b9.UseVisualStyleBackColor = True
                b1.Text = ""
                b2.Text = ""
                b3.Text = ""
                b4.Text = ""
                b5.Text = ""
                b6.Text = ""
                b7.Text = ""
                b8.Text = ""
                b9.Text = ""
                isClicked1 = True
                isClicked2 = True
                isClicked3 = True
                isClicked4 = True
                isClicked5 = True
                isClicked6 = True
                isClicked7 = True
                isClicked8 = True
                isClicked9 = True

            ElseIf b1.Text = "O" And b5.Text = "O" And b9.Text = "O" Then
                b1.BackColor = Color.Red
                b5.BackColor = Color.Red
                b9.BackColor = Color.Red
                MessageBox.Show(player_2 + " wins!", "WINNER", System.Windows.Forms.MessageBoxButtons.OKCancel, MessageBoxIcon.Information)
                oResult += 1
                lNumo.Text = oResult.ToString()
                b1.BackColor = Color.FromKnownColor(KnownColor.Control)
                b1.UseVisualStyleBackColor = True
                b5.BackColor = Color.FromKnownColor(KnownColor.Control)
                b5.UseVisualStyleBackColor = True
                b9.BackColor = Color.FromKnownColor(KnownColor.Control)
                b9.UseVisualStyleBackColor = True
                b1.Text = ""
                b2.Text = ""
                b3.Text = ""
                b4.Text = ""
                b5.Text = ""
                b6.Text = ""
                b7.Text = ""
                b8.Text = ""
                b9.Text = ""
                isClicked1 = True
                isClicked2 = True
                isClicked3 = True
                isClicked4 = True
                isClicked5 = True
                isClicked6 = True
                isClicked7 = True
                isClicked8 = True
                isClicked9 = True

            ElseIf b3.Text = "X" And b5.Text = "X" And b7.Text = "X" Then
                b3.BackColor = Color.Red
                b5.BackColor = Color.Red
                b7.BackColor = Color.Red
                MessageBox.Show(player_1 + " wins!", "WINNER", System.Windows.Forms.MessageBoxButtons.OKCancel, MessageBoxIcon.Information)
                xResult += 1
                lNumx.Text = xResult.ToString()
                b3.BackColor = Color.FromKnownColor(KnownColor.Control)
                b3.UseVisualStyleBackColor = True
                b5.BackColor = Color.FromKnownColor(KnownColor.Control)
                b5.UseVisualStyleBackColor = True
                b7.BackColor = Color.FromKnownColor(KnownColor.Control)
                b7.UseVisualStyleBackColor = True
                b1.Text = ""
                b2.Text = ""
                b3.Text = ""
                b4.Text = ""
                b5.Text = ""
                b6.Text = ""
                b7.Text = ""
                b8.Text = ""
                b9.Text = ""
                isClicked1 = True
                isClicked2 = True
                isClicked3 = True
                isClicked4 = True
                isClicked5 = True
                isClicked6 = True
                isClicked7 = True
                isClicked8 = True
                isClicked9 = True

            ElseIf b3.Text = "O" And b5.Text = "O" And b7.Text = "O" Then
                b3.BackColor = Color.Red
                b5.BackColor = Color.Red
                b7.BackColor = Color.Red
                MessageBox.Show(player_2 + " wins!", "WINNER", System.Windows.Forms.MessageBoxButtons.OKCancel, MessageBoxIcon.Information)
                oResult += 1
                lNumo.Text = oResult.ToString()
                b3.BackColor = Color.FromKnownColor(KnownColor.Control)
                b3.UseVisualStyleBackColor = True
                b5.BackColor = Color.FromKnownColor(KnownColor.Control)
                b5.UseVisualStyleBackColor = True
                b7.BackColor = Color.FromKnownColor(KnownColor.Control)
                b7.UseVisualStyleBackColor = True
                b1.Text = ""
                b2.Text = ""
                b3.Text = ""
                b4.Text = ""
                b5.Text = ""
                b6.Text = ""
                b7.Text = ""
                b8.Text = ""
                b9.Text = ""
                isClicked1 = True
                isClicked2 = True
                isClicked3 = True
                isClicked4 = True
                isClicked5 = True
                isClicked6 = True
                isClicked7 = True
                isClicked8 = True
                isClicked9 = True

            ElseIf (b1.Text = "O" Or b1.Text = "X") And (b2.Text = "O" Or b2.Text = "X") And (b3.Text = "O" Or b3.Text = "X") And (b4.Text = "O" Or b4.Text = "X") And (b5.Text = "O" Or b5.Text = "X") And (b6.Text = "O" Or b6.Text = "X") And (b7.Text = "O" Or b7.Text = "X") And (b8.Text = "O" Or b8.Text = "X") And (b9.Text = "O" Or b9.Text = "X") Then
                MessageBox.Show("Draw !!!", "WINNER", System.Windows.Forms.MessageBoxButtons.OKCancel, MessageBoxIcon.Information)
                b1.Text = ""
                b2.Text = ""
                b3.Text = ""
                b4.Text = ""
                b5.Text = ""
                b6.Text = ""
                b7.Text = ""
                b8.Text = ""
                b9.Text = ""
                isClicked1 = True
                isClicked2 = True
                isClicked3 = True
                isClicked4 = True
                isClicked5 = True
                isClicked6 = True
                isClicked7 = True
                isClicked8 = True
                isClicked9 = True
            End If
        End If



    End Sub

    Private Sub b2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles b2.Click
        If isClicked2 Then
            If isX Then
                b2.Text = "X"
                isX = False

            Else : b2.Text = "O"
                isX = True
            End If
            isClicked2 = False
            If b1.Text = "X" And b2.Text = "X" And b3.Text = "X" Then
                b1.BackColor = Color.Red
                b2.BackColor = Color.Red
                b3.BackColor = Color.Red
                MessageBox.Show(player_1 + " wins!", "WINNER", System.Windows.Forms.MessageBoxButtons.OKCancel, MessageBoxIcon.Information)
                xResult += 1
                lNumx.Text = xResult.ToString()
                b1.BackColor = Color.FromKnownColor(KnownColor.Control)
                b1.UseVisualStyleBackColor = True
                b2.BackColor = Color.FromKnownColor(KnownColor.Control)
                b2.UseVisualStyleBackColor = True
                b3.BackColor = Color.FromKnownColor(KnownColor.Control)
                b3.UseVisualStyleBackColor = True
                b1.Text = ""
                b2.Text = ""
                b3.Text = ""
                b4.Text = ""
                b5.Text = ""
                b6.Text = ""
                b7.Text = ""
                b8.Text = ""
                b9.Text = ""
                isClicked1 = True
                isClicked2 = True
                isClicked3 = True
                isClicked4 = True
                isClicked5 = True
                isClicked6 = True
                isClicked7 = True
                isClicked8 = True
                isClicked9 = True

            ElseIf b1.Text = "O" And b2.Text = "O" And b3.Text = "O" Then
                b1.BackColor = Color.Red
                b2.BackColor = Color.Red
                b3.BackColor = Color.Red
                MessageBox.Show(player_2 + " wins!", "WINNER", System.Windows.Forms.MessageBoxButtons.OKCancel, MessageBoxIcon.Information)
                oResult += 1
                lNumo.Text = oResult.ToString()
                b1.BackColor = Color.FromKnownColor(KnownColor.Control)
                b1.UseVisualStyleBackColor = True
                b2.BackColor = Color.FromKnownColor(KnownColor.Control)
                b2.UseVisualStyleBackColor = True
                b3.BackColor = Color.FromKnownColor(KnownColor.Control)
                b3.UseVisualStyleBackColor = True
                b1.Text = ""
                b2.Text = ""
                b3.Text = ""
                b4.Text = ""
                b5.Text = ""
                b6.Text = ""
                b7.Text = ""
                b8.Text = ""
                b9.Text = ""
                isClicked1 = True
                isClicked2 = True
                isClicked3 = True
                isClicked4 = True
                isClicked5 = True
                isClicked6 = True
                isClicked7 = True
                isClicked8 = True
                isClicked9 = True

            ElseIf b4.Text = "X" And b5.Text = "X" And b6.Text = "X" Then
                b4.BackColor = Color.Red
                b5.BackColor = Color.Red
                b6.BackColor = Color.Red
                MessageBox.Show(player_1 + " wins!", "WINNER", System.Windows.Forms.MessageBoxButtons.OKCancel, MessageBoxIcon.Information)
                xResult += 1
                lNumx.Text = xResult.ToString()
                b4.BackColor = Color.FromKnownColor(KnownColor.Control)
                b4.UseVisualStyleBackColor = True
                b5.BackColor = Color.FromKnownColor(KnownColor.Control)
                b5.UseVisualStyleBackColor = True
                b6.BackColor = Color.FromKnownColor(KnownColor.Control)
                b6.UseVisualStyleBackColor = True
                b1.Text = ""
                b2.Text = ""
                b3.Text = ""
                b4.Text = ""
                b5.Text = ""
                b6.Text = ""
                b7.Text = ""
                b8.Text = ""
                b9.Text = ""
                isClicked1 = True
                isClicked2 = True
                isClicked3 = True
                isClicked4 = True
                isClicked5 = True
                isClicked6 = True
                isClicked7 = True
                isClicked8 = True
                isClicked9 = True
            ElseIf b4.Text = "O" And b5.Text = "O" And b6.Text = "O" Then
                b4.BackColor = Color.Red
                b5.BackColor = Color.Red
                b6.BackColor = Color.Red
                MessageBox.Show(player_2 + " wins!", "WINNER", System.Windows.Forms.MessageBoxButtons.OKCancel, MessageBoxIcon.Information)
                oResult += 1
                lNumo.Text = oResult.ToString()
                b4.BackColor = Color.FromKnownColor(KnownColor.Control)
                b4.UseVisualStyleBackColor = True
                b5.BackColor = Color.FromKnownColor(KnownColor.Control)
                b5.UseVisualStyleBackColor = True
                b6.BackColor = Color.FromKnownColor(KnownColor.Control)
                b6.UseVisualStyleBackColor = True
                b1.Text = ""
                b2.Text = ""
                b3.Text = ""
                b4.Text = ""
                b5.Text = ""
                b6.Text = ""
                b7.Text = ""
                b8.Text = ""
                b9.Text = ""
                isClicked1 = True
                isClicked2 = True
                isClicked3 = True
                isClicked4 = True
                isClicked5 = True
                isClicked6 = True
                isClicked7 = True
                isClicked8 = True
                isClicked9 = True
            ElseIf b7.Text = "X" And b8.Text = "X" And b9.Text = "X" Then
                b7.BackColor = Color.Red
                b8.BackColor = Color.Red
                b9.BackColor = Color.Red
                MessageBox.Show(player_1 + " wins!", "WINNER", System.Windows.Forms.MessageBoxButtons.OKCancel, MessageBoxIcon.Information)
                xResult += 1
                lNumx.Text = xResult.ToString()
                b7.BackColor = Color.FromKnownColor(KnownColor.Control)
                b7.UseVisualStyleBackColor = True
                b8.BackColor = Color.FromKnownColor(KnownColor.Control)
                b8.UseVisualStyleBackColor = True
                b9.BackColor = Color.FromKnownColor(KnownColor.Control)
                b9.UseVisualStyleBackColor = True
                b1.Text = ""
                b2.Text = ""
                b3.Text = ""
                b4.Text = ""
                b5.Text = ""
                b6.Text = ""
                b7.Text = ""
                b8.Text = ""
                b9.Text = ""
                isClicked1 = True
                isClicked2 = True
                isClicked3 = True
                isClicked4 = True
                isClicked5 = True
                isClicked6 = True
                isClicked7 = True
                isClicked8 = True
                isClicked9 = True
            ElseIf b7.Text = "O" And b8.Text = "O" And b9.Text = "O" Then
                b7.BackColor = Color.Red
                b8.BackColor = Color.Red
                b9.BackColor = Color.Red
                MessageBox.Show(player_2 + " wins!", "WINNER", System.Windows.Forms.MessageBoxButtons.OKCancel, MessageBoxIcon.Information)
                oResult += 1
                lNumo.Text = oResult.ToString()
                b7.BackColor = Color.FromKnownColor(KnownColor.Control)
                b7.UseVisualStyleBackColor = True
                b8.BackColor = Color.FromKnownColor(KnownColor.Control)
                b8.UseVisualStyleBackColor = True
                b9.BackColor = Color.FromKnownColor(KnownColor.Control)
                b9.UseVisualStyleBackColor = True
                b1.Text = ""
                b2.Text = ""
                b3.Text = ""
                b4.Text = ""
                b5.Text = ""
                b6.Text = ""
                b7.Text = ""
                b8.Text = ""
                b9.Text = ""
                isClicked1 = True
                isClicked2 = True
                isClicked3 = True
                isClicked4 = True
                isClicked5 = True
                isClicked6 = True
                isClicked7 = True
                isClicked8 = True
                isClicked9 = True

            ElseIf b1.Text = "X" And b4.Text = "X" And b7.Text = "X" Then
                b1.BackColor = Color.Red
                b4.BackColor = Color.Red
                b7.BackColor = Color.Red
                MessageBox.Show(player_1 + " wins!", "WINNER", System.Windows.Forms.MessageBoxButtons.OKCancel, MessageBoxIcon.Information)
                xResult += 1
                lNumx.Text = xResult.ToString()
                b1.BackColor = Color.FromKnownColor(KnownColor.Control)
                b1.UseVisualStyleBackColor = True
                b4.BackColor = Color.FromKnownColor(KnownColor.Control)
                b4.UseVisualStyleBackColor = True
                b7.BackColor = Color.FromKnownColor(KnownColor.Control)
                b7.UseVisualStyleBackColor = True
                b1.Text = ""
                b2.Text = ""
                b3.Text = ""
                b4.Text = ""
                b5.Text = ""
                b6.Text = ""
                b7.Text = ""
                b8.Text = ""
                b9.Text = ""
                isClicked1 = True
                isClicked2 = True
                isClicked3 = True
                isClicked4 = True
                isClicked5 = True
                isClicked6 = True
                isClicked7 = True
                isClicked8 = True
                isClicked9 = True

            ElseIf b1.Text = "O" And b4.Text = "O" And b7.Text = "O" Then
                b1.BackColor = Color.Red
                b4.BackColor = Color.Red
                b7.BackColor = Color.Red
                MessageBox.Show(player_2 + " wins!", "WINNER", System.Windows.Forms.MessageBoxButtons.OKCancel, MessageBoxIcon.Information)
                oResult += 1
                lNumo.Text = oResult.ToString()
                b1.BackColor = Color.FromKnownColor(KnownColor.Control)
                b1.UseVisualStyleBackColor = True
                b4.BackColor = Color.FromKnownColor(KnownColor.Control)
                b4.UseVisualStyleBackColor = True
                b7.BackColor = Color.FromKnownColor(KnownColor.Control)
                b7.UseVisualStyleBackColor = True
                b1.Text = ""
                b2.Text = ""
                b3.Text = ""
                b4.Text = ""
                b5.Text = ""
                b6.Text = ""
                b7.Text = ""
                b8.Text = ""
                b9.Text = ""
                isClicked1 = True
                isClicked2 = True
                isClicked3 = True
                isClicked4 = True
                isClicked5 = True
                isClicked6 = True
                isClicked7 = True
                isClicked8 = True
                isClicked9 = True

            ElseIf b2.Text = "X" And b5.Text = "X" And b8.Text = "X" Then
                b2.BackColor = Color.Red
                b5.BackColor = Color.Red
                b8.BackColor = Color.Red
                MessageBox.Show(player_1 + " wins!", "WINNER", System.Windows.Forms.MessageBoxButtons.OKCancel, MessageBoxIcon.Information)
                xResult += 1
                lNumx.Text = xResult.ToString()
                b2.BackColor = Color.FromKnownColor(KnownColor.Control)
                b2.UseVisualStyleBackColor = True
                b5.BackColor = Color.FromKnownColor(KnownColor.Control)
                b5.UseVisualStyleBackColor = True
                b8.BackColor = Color.FromKnownColor(KnownColor.Control)
                b8.UseVisualStyleBackColor = True
                b1.Text = ""
                b2.Text = ""
                b3.Text = ""
                b4.Text = ""
                b5.Text = ""
                b6.Text = ""
                b7.Text = ""
                b8.Text = ""
                b9.Text = ""
                isClicked1 = True
                isClicked2 = True
                isClicked3 = True
                isClicked4 = True
                isClicked5 = True
                isClicked6 = True
                isClicked7 = True
                isClicked8 = True
                isClicked9 = True

            ElseIf b2.Text = "O" And b5.Text = "O" And b8.Text = "O" Then
                b2.BackColor = Color.Red
                b5.BackColor = Color.Red
                b8.BackColor = Color.Red
                MessageBox.Show(player_2 + " wins!", "WINNER", System.Windows.Forms.MessageBoxButtons.OKCancel, MessageBoxIcon.Information)
                oResult += 1
                lNumo.Text = oResult.ToString()
                b2.BackColor = Color.FromKnownColor(KnownColor.Control)
                b2.UseVisualStyleBackColor = True
                b5.BackColor = Color.FromKnownColor(KnownColor.Control)
                b5.UseVisualStyleBackColor = True
                b8.BackColor = Color.FromKnownColor(KnownColor.Control)
                b8.UseVisualStyleBackColor = True
                b1.Text = ""
                b2.Text = ""
                b3.Text = ""
                b4.Text = ""
                b5.Text = ""
                b6.Text = ""
                b7.Text = ""
                b8.Text = ""
                b9.Text = ""
                isClicked1 = True
                isClicked2 = True
                isClicked3 = True
                isClicked4 = True
                isClicked5 = True
                isClicked6 = True
                isClicked7 = True
                isClicked8 = True
                isClicked9 = True

            ElseIf b3.Text = "X" And b6.Text = "X" And b9.Text = "X" Then
                b3.BackColor = Color.Red
                b6.BackColor = Color.Red
                b9.BackColor = Color.Red
                MessageBox.Show(player_1 + " wins!", "WINNER", System.Windows.Forms.MessageBoxButtons.OKCancel, MessageBoxIcon.Information)
                xResult += 1
                lNumx.Text = xResult.ToString()
                b3.BackColor = Color.FromKnownColor(KnownColor.Control)
                b3.UseVisualStyleBackColor = True
                b6.BackColor = Color.FromKnownColor(KnownColor.Control)
                b6.UseVisualStyleBackColor = True
                b9.BackColor = Color.FromKnownColor(KnownColor.Control)
                b9.UseVisualStyleBackColor = True
                b1.Text = ""
                b2.Text = ""
                b3.Text = ""
                b4.Text = ""
                b5.Text = ""
                b6.Text = ""
                b7.Text = ""
                b8.Text = ""
                b9.Text = ""
                isClicked1 = True
                isClicked2 = True
                isClicked3 = True
                isClicked4 = True
                isClicked5 = True
                isClicked6 = True
                isClicked7 = True
                isClicked8 = True
                isClicked9 = True

            ElseIf b3.Text = "O" And b6.Text = "O" And b9.Text = "O" Then
                b3.BackColor = Color.Red
                b6.BackColor = Color.Red
                b9.BackColor = Color.Red
                MessageBox.Show(player_2 + " wins!", "WINNER", System.Windows.Forms.MessageBoxButtons.OKCancel, MessageBoxIcon.Information)
                oResult += 1
                lNumo.Text = oResult.ToString()
                b3.BackColor = Color.FromKnownColor(KnownColor.Control)
                b3.UseVisualStyleBackColor = True
                b6.BackColor = Color.FromKnownColor(KnownColor.Control)
                b6.UseVisualStyleBackColor = True
                b9.BackColor = Color.FromKnownColor(KnownColor.Control)
                b9.UseVisualStyleBackColor = True
                b1.Text = ""
                b2.Text = ""
                b3.Text = ""
                b4.Text = ""
                b5.Text = ""
                b6.Text = ""
                b7.Text = ""
                b8.Text = ""
                b9.Text = ""
                isClicked1 = True
                isClicked2 = True
                isClicked3 = True
                isClicked4 = True
                isClicked5 = True
                isClicked6 = True
                isClicked7 = True
                isClicked8 = True
                isClicked9 = True

            ElseIf b1.Text = "X" And b5.Text = "X" And b9.Text = "X" Then
                b1.BackColor = Color.Red
                b5.BackColor = Color.Red
                b9.BackColor = Color.Red
                MessageBox.Show(player_1 + " wins!", "WINNER", System.Windows.Forms.MessageBoxButtons.OKCancel, MessageBoxIcon.Information)
                xResult += 1
                lNumx.Text = xResult.ToString()
                b1.BackColor = Color.FromKnownColor(KnownColor.Control)
                b1.UseVisualStyleBackColor = True
                b5.BackColor = Color.FromKnownColor(KnownColor.Control)
                b5.UseVisualStyleBackColor = True
                b9.BackColor = Color.FromKnownColor(KnownColor.Control)
                b9.UseVisualStyleBackColor = True
                b1.Text = ""
                b2.Text = ""
                b3.Text = ""
                b4.Text = ""
                b5.Text = ""
                b6.Text = ""
                b7.Text = ""
                b8.Text = ""
                b9.Text = ""
                isClicked1 = True
                isClicked2 = True
                isClicked3 = True
                isClicked4 = True
                isClicked5 = True
                isClicked6 = True
                isClicked7 = True
                isClicked8 = True
                isClicked9 = True

            ElseIf b1.Text = "O" And b5.Text = "O" And b9.Text = "O" Then
                b1.BackColor = Color.Red
                b5.BackColor = Color.Red
                b9.BackColor = Color.Red
                MessageBox.Show(player_2 + " wins!", "WINNER", System.Windows.Forms.MessageBoxButtons.OKCancel, MessageBoxIcon.Information)
                oResult += 1
                lNumo.Text = oResult.ToString()
                b1.BackColor = Color.FromKnownColor(KnownColor.Control)
                b1.UseVisualStyleBackColor = True
                b5.BackColor = Color.FromKnownColor(KnownColor.Control)
                b5.UseVisualStyleBackColor = True
                b9.BackColor = Color.FromKnownColor(KnownColor.Control)
                b9.UseVisualStyleBackColor = True
                b1.Text = ""
                b2.Text = ""
                b3.Text = ""
                b4.Text = ""
                b5.Text = ""
                b6.Text = ""
                b7.Text = ""
                b8.Text = ""
                b9.Text = ""
                isClicked1 = True
                isClicked2 = True
                isClicked3 = True
                isClicked4 = True
                isClicked5 = True
                isClicked6 = True
                isClicked7 = True
                isClicked8 = True
                isClicked9 = True

            ElseIf b3.Text = "X" And b5.Text = "X" And b7.Text = "X" Then
                b3.BackColor = Color.Red
                b5.BackColor = Color.Red
                b7.BackColor = Color.Red
                MessageBox.Show(player_1 + " wins!", "WINNER", System.Windows.Forms.MessageBoxButtons.OKCancel, MessageBoxIcon.Information)
                xResult += 1
                lNumx.Text = xResult.ToString()
                b3.BackColor = Color.FromKnownColor(KnownColor.Control)
                b3.UseVisualStyleBackColor = True
                b5.BackColor = Color.FromKnownColor(KnownColor.Control)
                b5.UseVisualStyleBackColor = True
                b7.BackColor = Color.FromKnownColor(KnownColor.Control)
                b7.UseVisualStyleBackColor = True
                b1.Text = ""
                b2.Text = ""
                b3.Text = ""
                b4.Text = ""
                b5.Text = ""
                b6.Text = ""
                b7.Text = ""
                b8.Text = ""
                b9.Text = ""
                isClicked1 = True
                isClicked2 = True
                isClicked3 = True
                isClicked4 = True
                isClicked5 = True
                isClicked6 = True
                isClicked7 = True
                isClicked8 = True
                isClicked9 = True

            ElseIf b3.Text = "O" And b5.Text = "O" And b7.Text = "O" Then
                b3.BackColor = Color.Red
                b5.BackColor = Color.Red
                b7.BackColor = Color.Red
                MessageBox.Show(player_2 + " wins!", "WINNER", System.Windows.Forms.MessageBoxButtons.OKCancel, MessageBoxIcon.Information)
                oResult += 1
                lNumo.Text = oResult.ToString()
                b3.BackColor = Color.FromKnownColor(KnownColor.Control)
                b3.UseVisualStyleBackColor = True
                b5.BackColor = Color.FromKnownColor(KnownColor.Control)
                b5.UseVisualStyleBackColor = True
                b7.BackColor = Color.FromKnownColor(KnownColor.Control)
                b7.UseVisualStyleBackColor = True
                b1.Text = ""
                b2.Text = ""
                b3.Text = ""
                b4.Text = ""
                b5.Text = ""
                b6.Text = ""
                b7.Text = ""
                b8.Text = ""
                b9.Text = ""
                isClicked1 = True
                isClicked2 = True
                isClicked3 = True
                isClicked4 = True
                isClicked5 = True
                isClicked6 = True
                isClicked7 = True
                isClicked8 = True
                isClicked9 = True

            ElseIf (b1.Text = "O" Or b1.Text = "X") And (b2.Text = "O" Or b2.Text = "X") And (b3.Text = "O" Or b3.Text = "X") And (b4.Text = "O" Or b4.Text = "X") And (b5.Text = "O" Or b5.Text = "X") And (b6.Text = "O" Or b6.Text = "X") And (b7.Text = "O" Or b7.Text = "X") And (b8.Text = "O" Or b8.Text = "X") And (b9.Text = "O" Or b9.Text = "X") Then
                MessageBox.Show("Draw !!!", "WINNER", System.Windows.Forms.MessageBoxButtons.OKCancel, MessageBoxIcon.Information)
                b1.Text = ""
                b2.Text = ""
                b3.Text = ""
                b4.Text = ""
                b5.Text = ""
                b6.Text = ""
                b7.Text = ""
                b8.Text = ""
                b9.Text = ""
                isClicked1 = True
                isClicked2 = True
                isClicked3 = True
                isClicked4 = True
                isClicked5 = True
                isClicked6 = True
                isClicked7 = True
                isClicked8 = True
                isClicked9 = True
            End If
        End If
    End Sub

    Private Sub b3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles b3.Click
        If isClicked3 Then
            If isX Then
                b3.Text = "X"
                isX = False

            Else : b3.Text = "O"
                isX = True
            End If
            isClicked3 = False
            If b1.Text = "X" And b2.Text = "X" And b3.Text = "X" Then
                b1.BackColor = Color.Red
                b2.BackColor = Color.Red
                b3.BackColor = Color.Red
                MessageBox.Show(player_1 + " wins!", "WINNER", System.Windows.Forms.MessageBoxButtons.OKCancel, MessageBoxIcon.Information)
                xResult += 1
                lNumx.Text = xResult.ToString()
                b1.BackColor = Color.FromKnownColor(KnownColor.Control)
                b1.UseVisualStyleBackColor = True
                b2.BackColor = Color.FromKnownColor(KnownColor.Control)
                b2.UseVisualStyleBackColor = True
                b3.BackColor = Color.FromKnownColor(KnownColor.Control)
                b3.UseVisualStyleBackColor = True
                b1.Text = ""
                b2.Text = ""
                b3.Text = ""
                b4.Text = ""
                b5.Text = ""
                b6.Text = ""
                b7.Text = ""
                b8.Text = ""
                b9.Text = ""
                isClicked1 = True
                isClicked2 = True
                isClicked3 = True
                isClicked4 = True
                isClicked5 = True
                isClicked6 = True
                isClicked7 = True
                isClicked8 = True
                isClicked9 = True

            ElseIf b1.Text = "O" And b2.Text = "O" And b3.Text = "O" Then
                b1.BackColor = Color.Red
                b2.BackColor = Color.Red
                b3.BackColor = Color.Red
                MessageBox.Show(player_2 + " wins!", "WINNER", System.Windows.Forms.MessageBoxButtons.OKCancel, MessageBoxIcon.Information)
                oResult += 1
                lNumo.Text = oResult.ToString()
                b1.BackColor = Color.FromKnownColor(KnownColor.Control)
                b1.UseVisualStyleBackColor = True
                b2.BackColor = Color.FromKnownColor(KnownColor.Control)
                b2.UseVisualStyleBackColor = True
                b3.BackColor = Color.FromKnownColor(KnownColor.Control)
                b3.UseVisualStyleBackColor = True
                b1.Text = ""
                b2.Text = ""
                b3.Text = ""
                b4.Text = ""
                b5.Text = ""
                b6.Text = ""
                b7.Text = ""
                b8.Text = ""
                b9.Text = ""
                isClicked1 = True
                isClicked2 = True
                isClicked3 = True
                isClicked4 = True
                isClicked5 = True
                isClicked6 = True
                isClicked7 = True
                isClicked8 = True
                isClicked9 = True

            ElseIf b4.Text = "X" And b5.Text = "X" And b6.Text = "X" Then
                b4.BackColor = Color.Red
                b5.BackColor = Color.Red
                b6.BackColor = Color.Red
                MessageBox.Show(player_1 + " wins!", "WINNER", System.Windows.Forms.MessageBoxButtons.OKCancel, MessageBoxIcon.Information)
                xResult += 1
                lNumx.Text = xResult.ToString()
                b4.BackColor = Color.FromKnownColor(KnownColor.Control)
                b4.UseVisualStyleBackColor = True
                b5.BackColor = Color.FromKnownColor(KnownColor.Control)
                b5.UseVisualStyleBackColor = True
                b6.BackColor = Color.FromKnownColor(KnownColor.Control)
                b6.UseVisualStyleBackColor = True
                b1.Text = ""
                b2.Text = ""
                b3.Text = ""
                b4.Text = ""
                b5.Text = ""
                b6.Text = ""
                b7.Text = ""
                b8.Text = ""
                b9.Text = ""
                isClicked1 = True
                isClicked2 = True
                isClicked3 = True
                isClicked4 = True
                isClicked5 = True
                isClicked6 = True
                isClicked7 = True
                isClicked8 = True
                isClicked9 = True
            ElseIf b4.Text = "O" And b5.Text = "O" And b6.Text = "O" Then
                b4.BackColor = Color.Red
                b5.BackColor = Color.Red
                b6.BackColor = Color.Red
                MessageBox.Show(player_2 + " wins!", "WINNER", System.Windows.Forms.MessageBoxButtons.OKCancel, MessageBoxIcon.Information)
                oResult += 1
                lNumo.Text = oResult.ToString()
                b4.BackColor = Color.FromKnownColor(KnownColor.Control)
                b4.UseVisualStyleBackColor = True
                b5.BackColor = Color.FromKnownColor(KnownColor.Control)
                b5.UseVisualStyleBackColor = True
                b6.BackColor = Color.FromKnownColor(KnownColor.Control)
                b6.UseVisualStyleBackColor = True
                b1.Text = ""
                b2.Text = ""
                b3.Text = ""
                b4.Text = ""
                b5.Text = ""
                b6.Text = ""
                b7.Text = ""
                b8.Text = ""
                b9.Text = ""
                isClicked1 = True
                isClicked2 = True
                isClicked3 = True
                isClicked4 = True
                isClicked5 = True
                isClicked6 = True
                isClicked7 = True
                isClicked8 = True
                isClicked9 = True
            ElseIf b7.Text = "X" And b8.Text = "X" And b9.Text = "X" Then
                b7.BackColor = Color.Red
                b8.BackColor = Color.Red
                b9.BackColor = Color.Red
                MessageBox.Show(player_1 + " wins!", "WINNER", System.Windows.Forms.MessageBoxButtons.OKCancel, MessageBoxIcon.Information)
                xResult += 1
                lNumx.Text = xResult.ToString()
                b7.BackColor = Color.FromKnownColor(KnownColor.Control)
                b7.UseVisualStyleBackColor = True
                b8.BackColor = Color.FromKnownColor(KnownColor.Control)
                b8.UseVisualStyleBackColor = True
                b9.BackColor = Color.FromKnownColor(KnownColor.Control)
                b9.UseVisualStyleBackColor = True
                b1.Text = ""
                b2.Text = ""
                b3.Text = ""
                b4.Text = ""
                b5.Text = ""
                b6.Text = ""
                b7.Text = ""
                b8.Text = ""
                b9.Text = ""
                isClicked1 = True
                isClicked2 = True
                isClicked3 = True
                isClicked4 = True
                isClicked5 = True
                isClicked6 = True
                isClicked7 = True
                isClicked8 = True
                isClicked9 = True
            ElseIf b7.Text = "O" And b8.Text = "O" And b9.Text = "O" Then
                b7.BackColor = Color.Red
                b8.BackColor = Color.Red
                b9.BackColor = Color.Red
                MessageBox.Show(player_2 + " wins!", "WINNER", System.Windows.Forms.MessageBoxButtons.OKCancel, MessageBoxIcon.Information)
                oResult += 1
                lNumo.Text = oResult.ToString()
                b7.BackColor = Color.FromKnownColor(KnownColor.Control)
                b7.UseVisualStyleBackColor = True
                b8.BackColor = Color.FromKnownColor(KnownColor.Control)
                b8.UseVisualStyleBackColor = True
                b9.BackColor = Color.FromKnownColor(KnownColor.Control)
                b9.UseVisualStyleBackColor = True
                b1.Text = ""
                b2.Text = ""
                b3.Text = ""
                b4.Text = ""
                b5.Text = ""
                b6.Text = ""
                b7.Text = ""
                b8.Text = ""
                b9.Text = ""
                isClicked1 = True
                isClicked2 = True
                isClicked3 = True
                isClicked4 = True
                isClicked5 = True
                isClicked6 = True
                isClicked7 = True
                isClicked8 = True
                isClicked9 = True

            ElseIf b1.Text = "X" And b4.Text = "X" And b7.Text = "X" Then
                b1.BackColor = Color.Red
                b4.BackColor = Color.Red
                b7.BackColor = Color.Red
                MessageBox.Show(player_1 + " wins!", "WINNER", System.Windows.Forms.MessageBoxButtons.OKCancel, MessageBoxIcon.Information)
                xResult += 1
                lNumx.Text = xResult.ToString()
                b1.BackColor = Color.FromKnownColor(KnownColor.Control)
                b1.UseVisualStyleBackColor = True
                b4.BackColor = Color.FromKnownColor(KnownColor.Control)
                b4.UseVisualStyleBackColor = True
                b7.BackColor = Color.FromKnownColor(KnownColor.Control)
                b7.UseVisualStyleBackColor = True
                b1.Text = ""
                b2.Text = ""
                b3.Text = ""
                b4.Text = ""
                b5.Text = ""
                b6.Text = ""
                b7.Text = ""
                b8.Text = ""
                b9.Text = ""
                isClicked1 = True
                isClicked2 = True
                isClicked3 = True
                isClicked4 = True
                isClicked5 = True
                isClicked6 = True
                isClicked7 = True
                isClicked8 = True
                isClicked9 = True

            ElseIf b1.Text = "O" And b4.Text = "O" And b7.Text = "O" Then
                b1.BackColor = Color.Red
                b4.BackColor = Color.Red
                b7.BackColor = Color.Red
                MessageBox.Show(player_2 + " wins!", "WINNER", System.Windows.Forms.MessageBoxButtons.OKCancel, MessageBoxIcon.Information)
                oResult += 1
                lNumo.Text = oResult.ToString()
                b1.BackColor = Color.FromKnownColor(KnownColor.Control)
                b1.UseVisualStyleBackColor = True
                b4.BackColor = Color.FromKnownColor(KnownColor.Control)
                b4.UseVisualStyleBackColor = True
                b7.BackColor = Color.FromKnownColor(KnownColor.Control)
                b7.UseVisualStyleBackColor = True
                b1.Text = ""
                b2.Text = ""
                b3.Text = ""
                b4.Text = ""
                b5.Text = ""
                b6.Text = ""
                b7.Text = ""
                b8.Text = ""
                b9.Text = ""
                isClicked1 = True
                isClicked2 = True
                isClicked3 = True
                isClicked4 = True
                isClicked5 = True
                isClicked6 = True
                isClicked7 = True
                isClicked8 = True
                isClicked9 = True

            ElseIf b2.Text = "X" And b5.Text = "X" And b8.Text = "X" Then
                b2.BackColor = Color.Red
                b5.BackColor = Color.Red
                b8.BackColor = Color.Red
                MessageBox.Show(player_1 + " wins!", "WINNER", System.Windows.Forms.MessageBoxButtons.OKCancel, MessageBoxIcon.Information)
                xResult += 1
                lNumx.Text = xResult.ToString()
                b2.BackColor = Color.FromKnownColor(KnownColor.Control)
                b2.UseVisualStyleBackColor = True
                b5.BackColor = Color.FromKnownColor(KnownColor.Control)
                b5.UseVisualStyleBackColor = True
                b8.BackColor = Color.FromKnownColor(KnownColor.Control)
                b8.UseVisualStyleBackColor = True
                b1.Text = ""
                b2.Text = ""
                b3.Text = ""
                b4.Text = ""
                b5.Text = ""
                b6.Text = ""
                b7.Text = ""
                b8.Text = ""
                b9.Text = ""
                isClicked1 = True
                isClicked2 = True
                isClicked3 = True
                isClicked4 = True
                isClicked5 = True
                isClicked6 = True
                isClicked7 = True
                isClicked8 = True
                isClicked9 = True

            ElseIf b2.Text = "O" And b5.Text = "O" And b8.Text = "O" Then
                b2.BackColor = Color.Red
                b5.BackColor = Color.Red
                b8.BackColor = Color.Red
                MessageBox.Show(player_2 + " wins!", "WINNER", System.Windows.Forms.MessageBoxButtons.OKCancel, MessageBoxIcon.Information)
                oResult += 1
                lNumo.Text = oResult.ToString()
                b2.BackColor = Color.FromKnownColor(KnownColor.Control)
                b2.UseVisualStyleBackColor = True
                b5.BackColor = Color.FromKnownColor(KnownColor.Control)
                b5.UseVisualStyleBackColor = True
                b8.BackColor = Color.FromKnownColor(KnownColor.Control)
                b8.UseVisualStyleBackColor = True
                b1.Text = ""
                b2.Text = ""
                b3.Text = ""
                b4.Text = ""
                b5.Text = ""
                b6.Text = ""
                b7.Text = ""
                b8.Text = ""
                b9.Text = ""
                isClicked1 = True
                isClicked2 = True
                isClicked3 = True
                isClicked4 = True
                isClicked5 = True
                isClicked6 = True
                isClicked7 = True
                isClicked8 = True
                isClicked9 = True

            ElseIf b3.Text = "X" And b6.Text = "X" And b9.Text = "X" Then
                b3.BackColor = Color.Red
                b6.BackColor = Color.Red
                b9.BackColor = Color.Red
                MessageBox.Show(player_1 + " wins!", "WINNER", System.Windows.Forms.MessageBoxButtons.OKCancel, MessageBoxIcon.Information)
                xResult += 1
                lNumx.Text = xResult.ToString()
                b3.BackColor = Color.FromKnownColor(KnownColor.Control)
                b3.UseVisualStyleBackColor = True
                b6.BackColor = Color.FromKnownColor(KnownColor.Control)
                b6.UseVisualStyleBackColor = True
                b9.BackColor = Color.FromKnownColor(KnownColor.Control)
                b9.UseVisualStyleBackColor = True
                b1.Text = ""
                b2.Text = ""
                b3.Text = ""
                b4.Text = ""
                b5.Text = ""
                b6.Text = ""
                b7.Text = ""
                b8.Text = ""
                b9.Text = ""
                isClicked1 = True
                isClicked2 = True
                isClicked3 = True
                isClicked4 = True
                isClicked5 = True
                isClicked6 = True
                isClicked7 = True
                isClicked8 = True
                isClicked9 = True

            ElseIf b3.Text = "O" And b6.Text = "O" And b9.Text = "O" Then
                b3.BackColor = Color.Red
                b6.BackColor = Color.Red
                b9.BackColor = Color.Red
                MessageBox.Show(player_2 + " wins!", "WINNER", System.Windows.Forms.MessageBoxButtons.OKCancel, MessageBoxIcon.Information)
                oResult += 1
                lNumo.Text = oResult.ToString()
                b3.BackColor = Color.FromKnownColor(KnownColor.Control)
                b3.UseVisualStyleBackColor = True
                b6.BackColor = Color.FromKnownColor(KnownColor.Control)
                b6.UseVisualStyleBackColor = True
                b9.BackColor = Color.FromKnownColor(KnownColor.Control)
                b9.UseVisualStyleBackColor = True
                b1.Text = ""
                b2.Text = ""
                b3.Text = ""
                b4.Text = ""
                b5.Text = ""
                b6.Text = ""
                b7.Text = ""
                b8.Text = ""
                b9.Text = ""
                isClicked1 = True
                isClicked2 = True
                isClicked3 = True
                isClicked4 = True
                isClicked5 = True
                isClicked6 = True
                isClicked7 = True
                isClicked8 = True
                isClicked9 = True

            ElseIf b1.Text = "X" And b5.Text = "X" And b9.Text = "X" Then
                b1.BackColor = Color.Red
                b5.BackColor = Color.Red
                b9.BackColor = Color.Red
                MessageBox.Show(player_1 + " wins!", "WINNER", System.Windows.Forms.MessageBoxButtons.OKCancel, MessageBoxIcon.Information)
                xResult += 1
                lNumx.Text = xResult.ToString()
                b1.BackColor = Color.FromKnownColor(KnownColor.Control)
                b1.UseVisualStyleBackColor = True
                b5.BackColor = Color.FromKnownColor(KnownColor.Control)
                b5.UseVisualStyleBackColor = True
                b9.BackColor = Color.FromKnownColor(KnownColor.Control)
                b9.UseVisualStyleBackColor = True
                b1.Text = ""
                b2.Text = ""
                b3.Text = ""
                b4.Text = ""
                b5.Text = ""
                b6.Text = ""
                b7.Text = ""
                b8.Text = ""
                b9.Text = ""
                isClicked1 = True
                isClicked2 = True
                isClicked3 = True
                isClicked4 = True
                isClicked5 = True
                isClicked6 = True
                isClicked7 = True
                isClicked8 = True
                isClicked9 = True

            ElseIf b1.Text = "O" And b5.Text = "O" And b9.Text = "O" Then
                b1.BackColor = Color.Red
                b5.BackColor = Color.Red
                b9.BackColor = Color.Red
                MessageBox.Show(player_2 + " wins!", "WINNER", System.Windows.Forms.MessageBoxButtons.OKCancel, MessageBoxIcon.Information)
                oResult += 1
                lNumo.Text = oResult.ToString()
                b1.BackColor = Color.FromKnownColor(KnownColor.Control)
                b1.UseVisualStyleBackColor = True
                b5.BackColor = Color.FromKnownColor(KnownColor.Control)
                b5.UseVisualStyleBackColor = True
                b9.BackColor = Color.FromKnownColor(KnownColor.Control)
                b9.UseVisualStyleBackColor = True
                b1.Text = ""
                b2.Text = ""
                b3.Text = ""
                b4.Text = ""
                b5.Text = ""
                b6.Text = ""
                b7.Text = ""
                b8.Text = ""
                b9.Text = ""
                isClicked1 = True
                isClicked2 = True
                isClicked3 = True
                isClicked4 = True
                isClicked5 = True
                isClicked6 = True
                isClicked7 = True
                isClicked8 = True
                isClicked9 = True

            ElseIf b3.Text = "X" And b5.Text = "X" And b7.Text = "X" Then
                b3.BackColor = Color.Red
                b5.BackColor = Color.Red
                b7.BackColor = Color.Red
                MessageBox.Show(player_1 + " wins!", "WINNER", System.Windows.Forms.MessageBoxButtons.OKCancel, MessageBoxIcon.Information)
                xResult += 1
                lNumx.Text = xResult.ToString()
                b3.BackColor = Color.FromKnownColor(KnownColor.Control)
                b3.UseVisualStyleBackColor = True
                b5.BackColor = Color.FromKnownColor(KnownColor.Control)
                b5.UseVisualStyleBackColor = True
                b7.BackColor = Color.FromKnownColor(KnownColor.Control)
                b7.UseVisualStyleBackColor = True
                b1.Text = ""
                b2.Text = ""
                b3.Text = ""
                b4.Text = ""
                b5.Text = ""
                b6.Text = ""
                b7.Text = ""
                b8.Text = ""
                b9.Text = ""
                isClicked1 = True
                isClicked2 = True
                isClicked3 = True
                isClicked4 = True
                isClicked5 = True
                isClicked6 = True
                isClicked7 = True
                isClicked8 = True
                isClicked9 = True

            ElseIf b3.Text = "O" And b5.Text = "O" And b7.Text = "O" Then
                b3.BackColor = Color.Red
                b5.BackColor = Color.Red
                b7.BackColor = Color.Red
                MessageBox.Show(player_2 + " wins!", "WINNER", System.Windows.Forms.MessageBoxButtons.OKCancel, MessageBoxIcon.Information)
                oResult += 1
                lNumo.Text = oResult.ToString()
                b3.BackColor = Color.FromKnownColor(KnownColor.Control)
                b3.UseVisualStyleBackColor = True
                b5.BackColor = Color.FromKnownColor(KnownColor.Control)
                b5.UseVisualStyleBackColor = True
                b7.BackColor = Color.FromKnownColor(KnownColor.Control)
                b7.UseVisualStyleBackColor = True
                b1.Text = ""
                b2.Text = ""
                b3.Text = ""
                b4.Text = ""
                b5.Text = ""
                b6.Text = ""
                b7.Text = ""
                b8.Text = ""
                b9.Text = ""
                isClicked1 = True
                isClicked2 = True
                isClicked3 = True
                isClicked4 = True
                isClicked5 = True
                isClicked6 = True
                isClicked7 = True
                isClicked8 = True
                isClicked9 = True

            ElseIf (b1.Text = "O" Or b1.Text = "X") And (b2.Text = "O" Or b2.Text = "X") And (b3.Text = "O" Or b3.Text = "X") And (b4.Text = "O" Or b4.Text = "X") And (b5.Text = "O" Or b5.Text = "X") And (b6.Text = "O" Or b6.Text = "X") And (b7.Text = "O" Or b7.Text = "X") And (b8.Text = "O" Or b8.Text = "X") And (b9.Text = "O" Or b9.Text = "X") Then
                MessageBox.Show("Draw !!!", "WINNER", System.Windows.Forms.MessageBoxButtons.OKCancel, MessageBoxIcon.Information)
                b1.Text = ""
                b2.Text = ""
                b3.Text = ""
                b4.Text = ""
                b5.Text = ""
                b6.Text = ""
                b7.Text = ""
                b8.Text = ""
                b9.Text = ""
                isClicked1 = True
                isClicked2 = True
                isClicked3 = True
                isClicked4 = True
                isClicked5 = True
                isClicked6 = True
                isClicked7 = True
                isClicked8 = True
                isClicked9 = True
            End If

        End If
    End Sub

    Private Sub b4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles b4.Click
        If isClicked4 Then
            If isX Then
                b4.Text = "X"
                isX = False

            Else : b4.Text = "O"
                isX = True
            End If
            isClicked4 = False
            If b1.Text = "X" And b2.Text = "X" And b3.Text = "X" Then
                b1.BackColor = Color.Red
                b2.BackColor = Color.Red
                b3.BackColor = Color.Red
                MessageBox.Show(player_1 + " wins!", "WINNER", System.Windows.Forms.MessageBoxButtons.OKCancel, MessageBoxIcon.Information)
                xResult += 1
                lNumx.Text = xResult.ToString()
                b1.BackColor = Color.FromKnownColor(KnownColor.Control)
                b1.UseVisualStyleBackColor = True
                b2.BackColor = Color.FromKnownColor(KnownColor.Control)
                b2.UseVisualStyleBackColor = True
                b3.BackColor = Color.FromKnownColor(KnownColor.Control)
                b3.UseVisualStyleBackColor = True
                b1.Text = ""
                b2.Text = ""
                b3.Text = ""
                b4.Text = ""
                b5.Text = ""
                b6.Text = ""
                b7.Text = ""
                b8.Text = ""
                b9.Text = ""
                isClicked1 = True
                isClicked2 = True
                isClicked3 = True
                isClicked4 = True
                isClicked5 = True
                isClicked6 = True
                isClicked7 = True
                isClicked8 = True
                isClicked9 = True

            ElseIf b1.Text = "O" And b2.Text = "O" And b3.Text = "O" Then
                b1.BackColor = Color.Red
                b2.BackColor = Color.Red
                b3.BackColor = Color.Red
                MessageBox.Show(player_2 + " wins!", "WINNER", System.Windows.Forms.MessageBoxButtons.OKCancel, MessageBoxIcon.Information)
                oResult += 1
                lNumo.Text = oResult.ToString()
                b1.BackColor = Color.FromKnownColor(KnownColor.Control)
                b1.UseVisualStyleBackColor = True
                b2.BackColor = Color.FromKnownColor(KnownColor.Control)
                b2.UseVisualStyleBackColor = True
                b3.BackColor = Color.FromKnownColor(KnownColor.Control)
                b3.UseVisualStyleBackColor = True
                b1.Text = ""
                b2.Text = ""
                b3.Text = ""
                b4.Text = ""
                b5.Text = ""
                b6.Text = ""
                b7.Text = ""
                b8.Text = ""
                b9.Text = ""
                isClicked1 = True
                isClicked2 = True
                isClicked3 = True
                isClicked4 = True
                isClicked5 = True
                isClicked6 = True
                isClicked7 = True
                isClicked8 = True
                isClicked9 = True

            ElseIf b4.Text = "X" And b5.Text = "X" And b6.Text = "X" Then
                b4.BackColor = Color.Red
                b5.BackColor = Color.Red
                b6.BackColor = Color.Red
                MessageBox.Show(player_1 + " wins!", "WINNER", System.Windows.Forms.MessageBoxButtons.OKCancel, MessageBoxIcon.Information)
                xResult += 1
                lNumx.Text = xResult.ToString()
                b4.BackColor = Color.FromKnownColor(KnownColor.Control)
                b4.UseVisualStyleBackColor = True
                b5.BackColor = Color.FromKnownColor(KnownColor.Control)
                b5.UseVisualStyleBackColor = True
                b6.BackColor = Color.FromKnownColor(KnownColor.Control)
                b6.UseVisualStyleBackColor = True
                b1.Text = ""
                b2.Text = ""
                b3.Text = ""
                b4.Text = ""
                b5.Text = ""
                b6.Text = ""
                b7.Text = ""
                b8.Text = ""
                b9.Text = ""
                isClicked1 = True
                isClicked2 = True
                isClicked3 = True
                isClicked4 = True
                isClicked5 = True
                isClicked6 = True
                isClicked7 = True
                isClicked8 = True
                isClicked9 = True
            ElseIf b4.Text = "O" And b5.Text = "O" And b6.Text = "O" Then
                b4.BackColor = Color.Red
                b5.BackColor = Color.Red
                b6.BackColor = Color.Red
                MessageBox.Show(player_2 + " wins!", "WINNER", System.Windows.Forms.MessageBoxButtons.OKCancel, MessageBoxIcon.Information)
                oResult += 1
                lNumo.Text = oResult.ToString()
                b4.BackColor = Color.FromKnownColor(KnownColor.Control)
                b4.UseVisualStyleBackColor = True
                b5.BackColor = Color.FromKnownColor(KnownColor.Control)
                b5.UseVisualStyleBackColor = True
                b6.BackColor = Color.FromKnownColor(KnownColor.Control)
                b6.UseVisualStyleBackColor = True
                b1.Text = ""
                b2.Text = ""
                b3.Text = ""
                b4.Text = ""
                b5.Text = ""
                b6.Text = ""
                b7.Text = ""
                b8.Text = ""
                b9.Text = ""
                isClicked1 = True
                isClicked2 = True
                isClicked3 = True
                isClicked4 = True
                isClicked5 = True
                isClicked6 = True
                isClicked7 = True
                isClicked8 = True
                isClicked9 = True
            ElseIf b7.Text = "X" And b8.Text = "X" And b9.Text = "X" Then
                b7.BackColor = Color.Red
                b8.BackColor = Color.Red
                b9.BackColor = Color.Red
                MessageBox.Show(player_1 + " wins!", "WINNER", System.Windows.Forms.MessageBoxButtons.OKCancel, MessageBoxIcon.Information)
                xResult += 1
                lNumx.Text = xResult.ToString()
                b7.BackColor = Color.FromKnownColor(KnownColor.Control)
                b7.UseVisualStyleBackColor = True
                b8.BackColor = Color.FromKnownColor(KnownColor.Control)
                b8.UseVisualStyleBackColor = True
                b9.BackColor = Color.FromKnownColor(KnownColor.Control)
                b9.UseVisualStyleBackColor = True
                b1.Text = ""
                b2.Text = ""
                b3.Text = ""
                b4.Text = ""
                b5.Text = ""
                b6.Text = ""
                b7.Text = ""
                b8.Text = ""
                b9.Text = ""
                isClicked1 = True
                isClicked2 = True
                isClicked3 = True
                isClicked4 = True
                isClicked5 = True
                isClicked6 = True
                isClicked7 = True
                isClicked8 = True
                isClicked9 = True
            ElseIf b7.Text = "O" And b8.Text = "O" And b9.Text = "O" Then
                b7.BackColor = Color.Red
                b8.BackColor = Color.Red
                b9.BackColor = Color.Red
                MessageBox.Show(player_2 + " wins!", "WINNER", System.Windows.Forms.MessageBoxButtons.OKCancel, MessageBoxIcon.Information)
                oResult += 1
                lNumo.Text = oResult.ToString()
                b7.BackColor = Color.FromKnownColor(KnownColor.Control)
                b7.UseVisualStyleBackColor = True
                b8.BackColor = Color.FromKnownColor(KnownColor.Control)
                b8.UseVisualStyleBackColor = True
                b9.BackColor = Color.FromKnownColor(KnownColor.Control)
                b9.UseVisualStyleBackColor = True
                b1.Text = ""
                b2.Text = ""
                b3.Text = ""
                b4.Text = ""
                b5.Text = ""
                b6.Text = ""
                b7.Text = ""
                b8.Text = ""
                b9.Text = ""
                isClicked1 = True
                isClicked2 = True
                isClicked3 = True
                isClicked4 = True
                isClicked5 = True
                isClicked6 = True
                isClicked7 = True
                isClicked8 = True
                isClicked9 = True

            ElseIf b1.Text = "X" And b4.Text = "X" And b7.Text = "X" Then
                b1.BackColor = Color.Red
                b4.BackColor = Color.Red
                b7.BackColor = Color.Red
                MessageBox.Show(player_1 + " wins!", "WINNER", System.Windows.Forms.MessageBoxButtons.OKCancel, MessageBoxIcon.Information)
                xResult += 1
                lNumx.Text = xResult.ToString()
                b1.BackColor = Color.FromKnownColor(KnownColor.Control)
                b1.UseVisualStyleBackColor = True
                b4.BackColor = Color.FromKnownColor(KnownColor.Control)
                b4.UseVisualStyleBackColor = True
                b7.BackColor = Color.FromKnownColor(KnownColor.Control)
                b7.UseVisualStyleBackColor = True
                b1.Text = ""
                b2.Text = ""
                b3.Text = ""
                b4.Text = ""
                b5.Text = ""
                b6.Text = ""
                b7.Text = ""
                b8.Text = ""
                b9.Text = ""
                isClicked1 = True
                isClicked2 = True
                isClicked3 = True
                isClicked4 = True
                isClicked5 = True
                isClicked6 = True
                isClicked7 = True
                isClicked8 = True
                isClicked9 = True

            ElseIf b1.Text = "O" And b4.Text = "O" And b7.Text = "O" Then
                b1.BackColor = Color.Red
                b4.BackColor = Color.Red
                b7.BackColor = Color.Red
                MessageBox.Show(player_2 + " wins!", "WINNER", System.Windows.Forms.MessageBoxButtons.OKCancel, MessageBoxIcon.Information)
                oResult += 1
                lNumo.Text = oResult.ToString()
                b1.BackColor = Color.FromKnownColor(KnownColor.Control)
                b1.UseVisualStyleBackColor = True
                b4.BackColor = Color.FromKnownColor(KnownColor.Control)
                b4.UseVisualStyleBackColor = True
                b7.BackColor = Color.FromKnownColor(KnownColor.Control)
                b7.UseVisualStyleBackColor = True
                b1.Text = ""
                b2.Text = ""
                b3.Text = ""
                b4.Text = ""
                b5.Text = ""
                b6.Text = ""
                b7.Text = ""
                b8.Text = ""
                b9.Text = ""
                isClicked1 = True
                isClicked2 = True
                isClicked3 = True
                isClicked4 = True
                isClicked5 = True
                isClicked6 = True
                isClicked7 = True
                isClicked8 = True
                isClicked9 = True

            ElseIf b2.Text = "X" And b5.Text = "X" And b8.Text = "X" Then
                b2.BackColor = Color.Red
                b5.BackColor = Color.Red
                b8.BackColor = Color.Red
                MessageBox.Show(player_1 + " wins!", "WINNER", System.Windows.Forms.MessageBoxButtons.OKCancel, MessageBoxIcon.Information)
                xResult += 1
                lNumx.Text = xResult.ToString()
                b2.BackColor = Color.FromKnownColor(KnownColor.Control)
                b2.UseVisualStyleBackColor = True
                b5.BackColor = Color.FromKnownColor(KnownColor.Control)
                b5.UseVisualStyleBackColor = True
                b8.BackColor = Color.FromKnownColor(KnownColor.Control)
                b8.UseVisualStyleBackColor = True
                b1.Text = ""
                b2.Text = ""
                b3.Text = ""
                b4.Text = ""
                b5.Text = ""
                b6.Text = ""
                b7.Text = ""
                b8.Text = ""
                b9.Text = ""
                isClicked1 = True
                isClicked2 = True
                isClicked3 = True
                isClicked4 = True
                isClicked5 = True
                isClicked6 = True
                isClicked7 = True
                isClicked8 = True
                isClicked9 = True

            ElseIf b2.Text = "O" And b5.Text = "O" And b8.Text = "O" Then
                b2.BackColor = Color.Red
                b5.BackColor = Color.Red
                b8.BackColor = Color.Red
                MessageBox.Show(player_2 + " wins!", "WINNER", System.Windows.Forms.MessageBoxButtons.OKCancel, MessageBoxIcon.Information)
                oResult += 1
                lNumo.Text = oResult.ToString()
                b2.BackColor = Color.FromKnownColor(KnownColor.Control)
                b2.UseVisualStyleBackColor = True
                b5.BackColor = Color.FromKnownColor(KnownColor.Control)
                b5.UseVisualStyleBackColor = True
                b8.BackColor = Color.FromKnownColor(KnownColor.Control)
                b8.UseVisualStyleBackColor = True
                b1.Text = ""
                b2.Text = ""
                b3.Text = ""
                b4.Text = ""
                b5.Text = ""
                b6.Text = ""
                b7.Text = ""
                b8.Text = ""
                b9.Text = ""
                isClicked1 = True
                isClicked2 = True
                isClicked3 = True
                isClicked4 = True
                isClicked5 = True
                isClicked6 = True
                isClicked7 = True
                isClicked8 = True
                isClicked9 = True

            ElseIf b3.Text = "X" And b6.Text = "X" And b9.Text = "X" Then
                b3.BackColor = Color.Red
                b6.BackColor = Color.Red
                b9.BackColor = Color.Red
                MessageBox.Show(player_1 + " wins!", "WINNER", System.Windows.Forms.MessageBoxButtons.OKCancel, MessageBoxIcon.Information)
                xResult += 1
                lNumx.Text = xResult.ToString()
                b3.BackColor = Color.FromKnownColor(KnownColor.Control)
                b3.UseVisualStyleBackColor = True
                b6.BackColor = Color.FromKnownColor(KnownColor.Control)
                b6.UseVisualStyleBackColor = True
                b9.BackColor = Color.FromKnownColor(KnownColor.Control)
                b9.UseVisualStyleBackColor = True
                b1.Text = ""
                b2.Text = ""
                b3.Text = ""
                b4.Text = ""
                b5.Text = ""
                b6.Text = ""
                b7.Text = ""
                b8.Text = ""
                b9.Text = ""
                isClicked1 = True
                isClicked2 = True
                isClicked3 = True
                isClicked4 = True
                isClicked5 = True
                isClicked6 = True
                isClicked7 = True
                isClicked8 = True
                isClicked9 = True

            ElseIf b3.Text = "O" And b6.Text = "O" And b9.Text = "O" Then
                b3.BackColor = Color.Red
                b6.BackColor = Color.Red
                b9.BackColor = Color.Red
                MessageBox.Show(player_2 + " wins!", "WINNER", System.Windows.Forms.MessageBoxButtons.OKCancel, MessageBoxIcon.Information)
                oResult += 1
                lNumo.Text = oResult.ToString()
                b3.BackColor = Color.FromKnownColor(KnownColor.Control)
                b3.UseVisualStyleBackColor = True
                b6.BackColor = Color.FromKnownColor(KnownColor.Control)
                b6.UseVisualStyleBackColor = True
                b9.BackColor = Color.FromKnownColor(KnownColor.Control)
                b9.UseVisualStyleBackColor = True
                b1.Text = ""
                b2.Text = ""
                b3.Text = ""
                b4.Text = ""
                b5.Text = ""
                b6.Text = ""
                b7.Text = ""
                b8.Text = ""
                b9.Text = ""
                isClicked1 = True
                isClicked2 = True
                isClicked3 = True
                isClicked4 = True
                isClicked5 = True
                isClicked6 = True
                isClicked7 = True
                isClicked8 = True
                isClicked9 = True

            ElseIf b1.Text = "X" And b5.Text = "X" And b9.Text = "X" Then
                b1.BackColor = Color.Red
                b5.BackColor = Color.Red
                b9.BackColor = Color.Red
                MessageBox.Show(player_1 + " wins!", "WINNER", System.Windows.Forms.MessageBoxButtons.OKCancel, MessageBoxIcon.Information)
                xResult += 1
                lNumx.Text = xResult.ToString()
                b1.BackColor = Color.FromKnownColor(KnownColor.Control)
                b1.UseVisualStyleBackColor = True
                b5.BackColor = Color.FromKnownColor(KnownColor.Control)
                b5.UseVisualStyleBackColor = True
                b9.BackColor = Color.FromKnownColor(KnownColor.Control)
                b9.UseVisualStyleBackColor = True
                b1.Text = ""
                b2.Text = ""
                b3.Text = ""
                b4.Text = ""
                b5.Text = ""
                b6.Text = ""
                b7.Text = ""
                b8.Text = ""
                b9.Text = ""
                isClicked1 = True
                isClicked2 = True
                isClicked3 = True
                isClicked4 = True
                isClicked5 = True
                isClicked6 = True
                isClicked7 = True
                isClicked8 = True
                isClicked9 = True

            ElseIf b1.Text = "O" And b5.Text = "O" And b9.Text = "O" Then
                b1.BackColor = Color.Red
                b5.BackColor = Color.Red
                b9.BackColor = Color.Red
                MessageBox.Show(player_2 + " wins!", "WINNER", System.Windows.Forms.MessageBoxButtons.OKCancel, MessageBoxIcon.Information)
                oResult += 1
                lNumo.Text = oResult.ToString()
                b1.BackColor = Color.FromKnownColor(KnownColor.Control)
                b1.UseVisualStyleBackColor = True
                b5.BackColor = Color.FromKnownColor(KnownColor.Control)
                b5.UseVisualStyleBackColor = True
                b9.BackColor = Color.FromKnownColor(KnownColor.Control)
                b9.UseVisualStyleBackColor = True
                b1.Text = ""
                b2.Text = ""
                b3.Text = ""
                b4.Text = ""
                b5.Text = ""
                b6.Text = ""
                b7.Text = ""
                b8.Text = ""
                b9.Text = ""
                isClicked1 = True
                isClicked2 = True
                isClicked3 = True
                isClicked4 = True
                isClicked5 = True
                isClicked6 = True
                isClicked7 = True
                isClicked8 = True
                isClicked9 = True

            ElseIf b3.Text = "X" And b5.Text = "X" And b7.Text = "X" Then
                b3.BackColor = Color.Red
                b5.BackColor = Color.Red
                b7.BackColor = Color.Red
                MessageBox.Show(player_1 + " wins!", "WINNER", System.Windows.Forms.MessageBoxButtons.OKCancel, MessageBoxIcon.Information)
                xResult += 1
                lNumx.Text = xResult.ToString()
                b3.BackColor = Color.FromKnownColor(KnownColor.Control)
                b3.UseVisualStyleBackColor = True
                b5.BackColor = Color.FromKnownColor(KnownColor.Control)
                b5.UseVisualStyleBackColor = True
                b7.BackColor = Color.FromKnownColor(KnownColor.Control)
                b7.UseVisualStyleBackColor = True
                b1.Text = ""
                b2.Text = ""
                b3.Text = ""
                b4.Text = ""
                b5.Text = ""
                b6.Text = ""
                b7.Text = ""
                b8.Text = ""
                b9.Text = ""
                isClicked1 = True
                isClicked2 = True
                isClicked3 = True
                isClicked4 = True
                isClicked5 = True
                isClicked6 = True
                isClicked7 = True
                isClicked8 = True
                isClicked9 = True

            ElseIf b3.Text = "O" And b5.Text = "O" And b7.Text = "O" Then
                b3.BackColor = Color.Red
                b5.BackColor = Color.Red
                b7.BackColor = Color.Red
                MessageBox.Show(player_2 + " wins!", "WINNER", System.Windows.Forms.MessageBoxButtons.OKCancel, MessageBoxIcon.Information)
                oResult += 1
                lNumo.Text = oResult.ToString()
                b3.BackColor = Color.FromKnownColor(KnownColor.Control)
                b3.UseVisualStyleBackColor = True
                b5.BackColor = Color.FromKnownColor(KnownColor.Control)
                b5.UseVisualStyleBackColor = True
                b7.BackColor = Color.FromKnownColor(KnownColor.Control)
                b7.UseVisualStyleBackColor = True
                b1.Text = ""
                b2.Text = ""
                b3.Text = ""
                b4.Text = ""
                b5.Text = ""
                b6.Text = ""
                b7.Text = ""
                b8.Text = ""
                b9.Text = ""
                isClicked1 = True
                isClicked2 = True
                isClicked3 = True
                isClicked4 = True
                isClicked5 = True
                isClicked6 = True
                isClicked7 = True
                isClicked8 = True
                isClicked9 = True

            ElseIf (b1.Text = "O" Or b1.Text = "X") And (b2.Text = "O" Or b2.Text = "X") And (b3.Text = "O" Or b3.Text = "X") And (b4.Text = "O" Or b4.Text = "X") And (b5.Text = "O" Or b5.Text = "X") And (b6.Text = "O" Or b6.Text = "X") And (b7.Text = "O" Or b7.Text = "X") And (b8.Text = "O" Or b8.Text = "X") And (b9.Text = "O" Or b9.Text = "X") Then
                MessageBox.Show("Draw !!!", "WINNER", System.Windows.Forms.MessageBoxButtons.OKCancel, MessageBoxIcon.Information)
                b1.Text = ""
                b2.Text = ""
                b3.Text = ""
                b4.Text = ""
                b5.Text = ""
                b6.Text = ""
                b7.Text = ""
                b8.Text = ""
                b9.Text = ""
                isClicked1 = True
                isClicked2 = True
                isClicked3 = True
                isClicked4 = True
                isClicked5 = True
                isClicked6 = True
                isClicked7 = True
                isClicked8 = True
                isClicked9 = True
            End If
        End If
    End Sub

    Private Sub b5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles b5.Click
        If isClicked5 Then
            If isX Then
                b5.Text = "X"
                isX = False

            Else : b5.Text = "O"
                isX = True
            End If
            isClicked5 = False
            If b1.Text = "X" And b2.Text = "X" And b3.Text = "X" Then
                b1.BackColor = Color.Red
                b2.BackColor = Color.Red
                b3.BackColor = Color.Red
                MessageBox.Show(player_1 + " wins!", "WINNER", System.Windows.Forms.MessageBoxButtons.OKCancel, MessageBoxIcon.Information)
                xResult += 1
                lNumx.Text = xResult.ToString()
                b1.BackColor = Color.FromKnownColor(KnownColor.Control)
                b1.UseVisualStyleBackColor = True
                b2.BackColor = Color.FromKnownColor(KnownColor.Control)
                b2.UseVisualStyleBackColor = True
                b3.BackColor = Color.FromKnownColor(KnownColor.Control)
                b3.UseVisualStyleBackColor = True
                b1.Text = ""
                b2.Text = ""
                b3.Text = ""
                b4.Text = ""
                b5.Text = ""
                b6.Text = ""
                b7.Text = ""
                b8.Text = ""
                b9.Text = ""
                isClicked1 = True
                isClicked2 = True
                isClicked3 = True
                isClicked4 = True
                isClicked5 = True
                isClicked6 = True
                isClicked7 = True
                isClicked8 = True
                isClicked9 = True

            ElseIf b1.Text = "O" And b2.Text = "O" And b3.Text = "O" Then
                b1.BackColor = Color.Red
                b2.BackColor = Color.Red
                b3.BackColor = Color.Red
                MessageBox.Show(player_2 + " wins!", "WINNER", System.Windows.Forms.MessageBoxButtons.OKCancel, MessageBoxIcon.Information)
                oResult += 1
                lNumo.Text = oResult.ToString()
                b1.BackColor = Color.FromKnownColor(KnownColor.Control)
                b1.UseVisualStyleBackColor = True
                b2.BackColor = Color.FromKnownColor(KnownColor.Control)
                b2.UseVisualStyleBackColor = True
                b3.BackColor = Color.FromKnownColor(KnownColor.Control)
                b3.UseVisualStyleBackColor = True
                b1.Text = ""
                b2.Text = ""
                b3.Text = ""
                b4.Text = ""
                b5.Text = ""
                b6.Text = ""
                b7.Text = ""
                b8.Text = ""
                b9.Text = ""
                isClicked1 = True
                isClicked2 = True
                isClicked3 = True
                isClicked4 = True
                isClicked5 = True
                isClicked6 = True
                isClicked7 = True
                isClicked8 = True
                isClicked9 = True

            ElseIf b4.Text = "X" And b5.Text = "X" And b6.Text = "X" Then
                b4.BackColor = Color.Red
                b5.BackColor = Color.Red
                b6.BackColor = Color.Red
                MessageBox.Show(player_1 + " wins!", "WINNER", System.Windows.Forms.MessageBoxButtons.OKCancel, MessageBoxIcon.Information)
                xResult += 1
                lNumx.Text = xResult.ToString()
                b4.BackColor = Color.FromKnownColor(KnownColor.Control)
                b4.UseVisualStyleBackColor = True
                b5.BackColor = Color.FromKnownColor(KnownColor.Control)
                b5.UseVisualStyleBackColor = True
                b6.BackColor = Color.FromKnownColor(KnownColor.Control)
                b6.UseVisualStyleBackColor = True
                b1.Text = ""
                b2.Text = ""
                b3.Text = ""
                b4.Text = ""
                b5.Text = ""
                b6.Text = ""
                b7.Text = ""
                b8.Text = ""
                b9.Text = ""
                isClicked1 = True
                isClicked2 = True
                isClicked3 = True
                isClicked4 = True
                isClicked5 = True
                isClicked6 = True
                isClicked7 = True
                isClicked8 = True
                isClicked9 = True
            ElseIf b4.Text = "O" And b5.Text = "O" And b6.Text = "O" Then
                b4.BackColor = Color.Red
                b5.BackColor = Color.Red
                b6.BackColor = Color.Red
                MessageBox.Show(player_2 + " wins!", "WINNER", System.Windows.Forms.MessageBoxButtons.OKCancel, MessageBoxIcon.Information)
                oResult += 1
                lNumo.Text = oResult.ToString()
                b4.BackColor = Color.FromKnownColor(KnownColor.Control)
                b4.UseVisualStyleBackColor = True
                b5.BackColor = Color.FromKnownColor(KnownColor.Control)
                b5.UseVisualStyleBackColor = True
                b6.BackColor = Color.FromKnownColor(KnownColor.Control)
                b6.UseVisualStyleBackColor = True
                b1.Text = ""
                b2.Text = ""
                b3.Text = ""
                b4.Text = ""
                b5.Text = ""
                b6.Text = ""
                b7.Text = ""
                b8.Text = ""
                b9.Text = ""
                isClicked1 = True
                isClicked2 = True
                isClicked3 = True
                isClicked4 = True
                isClicked5 = True
                isClicked6 = True
                isClicked7 = True
                isClicked8 = True
                isClicked9 = True
            ElseIf b7.Text = "X" And b8.Text = "X" And b9.Text = "X" Then
                b7.BackColor = Color.Red
                b8.BackColor = Color.Red
                b9.BackColor = Color.Red
                MessageBox.Show(player_1 + " wins!", "WINNER", System.Windows.Forms.MessageBoxButtons.OKCancel, MessageBoxIcon.Information)
                xResult += 1
                lNumx.Text = xResult.ToString()
                b7.BackColor = Color.FromKnownColor(KnownColor.Control)
                b7.UseVisualStyleBackColor = True
                b8.BackColor = Color.FromKnownColor(KnownColor.Control)
                b8.UseVisualStyleBackColor = True
                b9.BackColor = Color.FromKnownColor(KnownColor.Control)
                b9.UseVisualStyleBackColor = True
                b1.Text = ""
                b2.Text = ""
                b3.Text = ""
                b4.Text = ""
                b5.Text = ""
                b6.Text = ""
                b7.Text = ""
                b8.Text = ""
                b9.Text = ""
                isClicked1 = True
                isClicked2 = True
                isClicked3 = True
                isClicked4 = True
                isClicked5 = True
                isClicked6 = True
                isClicked7 = True
                isClicked8 = True
                isClicked9 = True
            ElseIf b7.Text = "O" And b8.Text = "O" And b9.Text = "O" Then
                b7.BackColor = Color.Red
                b8.BackColor = Color.Red
                b9.BackColor = Color.Red
                MessageBox.Show(player_2 + " wins!", "WINNER", System.Windows.Forms.MessageBoxButtons.OKCancel, MessageBoxIcon.Information)
                oResult += 1
                lNumo.Text = oResult.ToString()
                b7.BackColor = Color.FromKnownColor(KnownColor.Control)
                b7.UseVisualStyleBackColor = True
                b8.BackColor = Color.FromKnownColor(KnownColor.Control)
                b8.UseVisualStyleBackColor = True
                b9.BackColor = Color.FromKnownColor(KnownColor.Control)
                b9.UseVisualStyleBackColor = True
                b1.Text = ""
                b2.Text = ""
                b3.Text = ""
                b4.Text = ""
                b5.Text = ""
                b6.Text = ""
                b7.Text = ""
                b8.Text = ""
                b9.Text = ""
                isClicked1 = True
                isClicked2 = True
                isClicked3 = True
                isClicked4 = True
                isClicked5 = True
                isClicked6 = True
                isClicked7 = True
                isClicked8 = True
                isClicked9 = True

            ElseIf b1.Text = "X" And b4.Text = "X" And b7.Text = "X" Then
                b1.BackColor = Color.Red
                b4.BackColor = Color.Red
                b7.BackColor = Color.Red
                MessageBox.Show(player_1 + " wins!", "WINNER", System.Windows.Forms.MessageBoxButtons.OKCancel, MessageBoxIcon.Information)
                xResult += 1
                lNumx.Text = xResult.ToString()
                b1.BackColor = Color.FromKnownColor(KnownColor.Control)
                b1.UseVisualStyleBackColor = True
                b4.BackColor = Color.FromKnownColor(KnownColor.Control)
                b4.UseVisualStyleBackColor = True
                b7.BackColor = Color.FromKnownColor(KnownColor.Control)
                b7.UseVisualStyleBackColor = True
                b1.Text = ""
                b2.Text = ""
                b3.Text = ""
                b4.Text = ""
                b5.Text = ""
                b6.Text = ""
                b7.Text = ""
                b8.Text = ""
                b9.Text = ""
                isClicked1 = True
                isClicked2 = True
                isClicked3 = True
                isClicked4 = True
                isClicked5 = True
                isClicked6 = True
                isClicked7 = True
                isClicked8 = True
                isClicked9 = True

            ElseIf b1.Text = "O" And b4.Text = "O" And b7.Text = "O" Then
                b1.BackColor = Color.Red
                b4.BackColor = Color.Red
                b7.BackColor = Color.Red
                MessageBox.Show(player_2 + " wins!", "WINNER", System.Windows.Forms.MessageBoxButtons.OKCancel, MessageBoxIcon.Information)
                oResult += 1
                lNumo.Text = oResult.ToString()
                b1.BackColor = Color.FromKnownColor(KnownColor.Control)
                b1.UseVisualStyleBackColor = True
                b4.BackColor = Color.FromKnownColor(KnownColor.Control)
                b4.UseVisualStyleBackColor = True
                b7.BackColor = Color.FromKnownColor(KnownColor.Control)
                b7.UseVisualStyleBackColor = True
                b1.Text = ""
                b2.Text = ""
                b3.Text = ""
                b4.Text = ""
                b5.Text = ""
                b6.Text = ""
                b7.Text = ""
                b8.Text = ""
                b9.Text = ""
                isClicked1 = True
                isClicked2 = True
                isClicked3 = True
                isClicked4 = True
                isClicked5 = True
                isClicked6 = True
                isClicked7 = True
                isClicked8 = True
                isClicked9 = True

            ElseIf b2.Text = "X" And b5.Text = "X" And b8.Text = "X" Then
                b2.BackColor = Color.Red
                b5.BackColor = Color.Red
                b8.BackColor = Color.Red
                MessageBox.Show(player_1 + " wins!", "WINNER", System.Windows.Forms.MessageBoxButtons.OKCancel, MessageBoxIcon.Information)
                xResult += 1
                lNumx.Text = xResult.ToString()
                b2.BackColor = Color.FromKnownColor(KnownColor.Control)
                b2.UseVisualStyleBackColor = True
                b5.BackColor = Color.FromKnownColor(KnownColor.Control)
                b5.UseVisualStyleBackColor = True
                b8.BackColor = Color.FromKnownColor(KnownColor.Control)
                b8.UseVisualStyleBackColor = True
                b1.Text = ""
                b2.Text = ""
                b3.Text = ""
                b4.Text = ""
                b5.Text = ""
                b6.Text = ""
                b7.Text = ""
                b8.Text = ""
                b9.Text = ""
                isClicked1 = True
                isClicked2 = True
                isClicked3 = True
                isClicked4 = True
                isClicked5 = True
                isClicked6 = True
                isClicked7 = True
                isClicked8 = True
                isClicked9 = True

            ElseIf b2.Text = "O" And b5.Text = "O" And b8.Text = "O" Then
                b2.BackColor = Color.Red
                b5.BackColor = Color.Red
                b8.BackColor = Color.Red
                MessageBox.Show(player_2 + " wins!", "WINNER", System.Windows.Forms.MessageBoxButtons.OKCancel, MessageBoxIcon.Information)
                oResult += 1
                lNumo.Text = oResult.ToString()
                b2.BackColor = Color.FromKnownColor(KnownColor.Control)
                b2.UseVisualStyleBackColor = True
                b5.BackColor = Color.FromKnownColor(KnownColor.Control)
                b5.UseVisualStyleBackColor = True
                b8.BackColor = Color.FromKnownColor(KnownColor.Control)
                b8.UseVisualStyleBackColor = True
                b1.Text = ""
                b2.Text = ""
                b3.Text = ""
                b4.Text = ""
                b5.Text = ""
                b6.Text = ""
                b7.Text = ""
                b8.Text = ""
                b9.Text = ""
                isClicked1 = True
                isClicked2 = True
                isClicked3 = True
                isClicked4 = True
                isClicked5 = True
                isClicked6 = True
                isClicked7 = True
                isClicked8 = True
                isClicked9 = True

            ElseIf b3.Text = "X" And b6.Text = "X" And b9.Text = "X" Then
                b3.BackColor = Color.Red
                b6.BackColor = Color.Red
                b9.BackColor = Color.Red
                MessageBox.Show(player_1 + " wins!", "WINNER", System.Windows.Forms.MessageBoxButtons.OKCancel, MessageBoxIcon.Information)
                xResult += 1
                lNumx.Text = xResult.ToString()
                b3.BackColor = Color.FromKnownColor(KnownColor.Control)
                b3.UseVisualStyleBackColor = True
                b6.BackColor = Color.FromKnownColor(KnownColor.Control)
                b6.UseVisualStyleBackColor = True
                b9.BackColor = Color.FromKnownColor(KnownColor.Control)
                b9.UseVisualStyleBackColor = True
                b1.Text = ""
                b2.Text = ""
                b3.Text = ""
                b4.Text = ""
                b5.Text = ""
                b6.Text = ""
                b7.Text = ""
                b8.Text = ""
                b9.Text = ""
                isClicked1 = True
                isClicked2 = True
                isClicked3 = True
                isClicked4 = True
                isClicked5 = True
                isClicked6 = True
                isClicked7 = True
                isClicked8 = True
                isClicked9 = True

            ElseIf b3.Text = "O" And b6.Text = "O" And b9.Text = "O" Then
                b3.BackColor = Color.Red
                b6.BackColor = Color.Red
                b9.BackColor = Color.Red
                MessageBox.Show(player_2 + " wins!", "WINNER", System.Windows.Forms.MessageBoxButtons.OKCancel, MessageBoxIcon.Information)
                oResult += 1
                lNumo.Text = oResult.ToString()
                b3.BackColor = Color.FromKnownColor(KnownColor.Control)
                b3.UseVisualStyleBackColor = True
                b6.BackColor = Color.FromKnownColor(KnownColor.Control)
                b6.UseVisualStyleBackColor = True
                b9.BackColor = Color.FromKnownColor(KnownColor.Control)
                b9.UseVisualStyleBackColor = True
                b1.Text = ""
                b2.Text = ""
                b3.Text = ""
                b4.Text = ""
                b5.Text = ""
                b6.Text = ""
                b7.Text = ""
                b8.Text = ""
                b9.Text = ""
                isClicked1 = True
                isClicked2 = True
                isClicked3 = True
                isClicked4 = True
                isClicked5 = True
                isClicked6 = True
                isClicked7 = True
                isClicked8 = True
                isClicked9 = True

            ElseIf b1.Text = "X" And b5.Text = "X" And b9.Text = "X" Then
                b1.BackColor = Color.Red
                b5.BackColor = Color.Red
                b9.BackColor = Color.Red
                MessageBox.Show(player_1 + " wins!", "WINNER", System.Windows.Forms.MessageBoxButtons.OKCancel, MessageBoxIcon.Information)
                xResult += 1
                lNumx.Text = xResult.ToString()
                b1.BackColor = Color.FromKnownColor(KnownColor.Control)
                b1.UseVisualStyleBackColor = True
                b5.BackColor = Color.FromKnownColor(KnownColor.Control)
                b5.UseVisualStyleBackColor = True
                b9.BackColor = Color.FromKnownColor(KnownColor.Control)
                b9.UseVisualStyleBackColor = True
                b1.Text = ""
                b2.Text = ""
                b3.Text = ""
                b4.Text = ""
                b5.Text = ""
                b6.Text = ""
                b7.Text = ""
                b8.Text = ""
                b9.Text = ""
                isClicked1 = True
                isClicked2 = True
                isClicked3 = True
                isClicked4 = True
                isClicked5 = True
                isClicked6 = True
                isClicked7 = True
                isClicked8 = True
                isClicked9 = True

            ElseIf b1.Text = "O" And b5.Text = "O" And b9.Text = "O" Then
                b1.BackColor = Color.Red
                b5.BackColor = Color.Red
                b9.BackColor = Color.Red
                MessageBox.Show(player_2 + " wins!", "WINNER", System.Windows.Forms.MessageBoxButtons.OKCancel, MessageBoxIcon.Information)
                oResult += 1
                lNumo.Text = oResult.ToString()
                b1.BackColor = Color.FromKnownColor(KnownColor.Control)
                b1.UseVisualStyleBackColor = True
                b5.BackColor = Color.FromKnownColor(KnownColor.Control)
                b5.UseVisualStyleBackColor = True
                b9.BackColor = Color.FromKnownColor(KnownColor.Control)
                b9.UseVisualStyleBackColor = True
                b1.Text = ""
                b2.Text = ""
                b3.Text = ""
                b4.Text = ""
                b5.Text = ""
                b6.Text = ""
                b7.Text = ""
                b8.Text = ""
                b9.Text = ""
                isClicked1 = True
                isClicked2 = True
                isClicked3 = True
                isClicked4 = True
                isClicked5 = True
                isClicked6 = True
                isClicked7 = True
                isClicked8 = True
                isClicked9 = True

            ElseIf b3.Text = "X" And b5.Text = "X" And b7.Text = "X" Then
                b3.BackColor = Color.Red
                b5.BackColor = Color.Red
                b7.BackColor = Color.Red
                MessageBox.Show(player_1 + " wins!", "WINNER", System.Windows.Forms.MessageBoxButtons.OKCancel, MessageBoxIcon.Information)
                xResult += 1
                lNumx.Text = xResult.ToString()
                b3.BackColor = Color.FromKnownColor(KnownColor.Control)
                b3.UseVisualStyleBackColor = True
                b5.BackColor = Color.FromKnownColor(KnownColor.Control)
                b5.UseVisualStyleBackColor = True
                b7.BackColor = Color.FromKnownColor(KnownColor.Control)
                b7.UseVisualStyleBackColor = True
                b1.Text = ""
                b2.Text = ""
                b3.Text = ""
                b4.Text = ""
                b5.Text = ""
                b6.Text = ""
                b7.Text = ""
                b8.Text = ""
                b9.Text = ""
                isClicked1 = True
                isClicked2 = True
                isClicked3 = True
                isClicked4 = True
                isClicked5 = True
                isClicked6 = True
                isClicked7 = True
                isClicked8 = True
                isClicked9 = True

            ElseIf b3.Text = "O" And b5.Text = "O" And b7.Text = "O" Then
                b3.BackColor = Color.Red
                b5.BackColor = Color.Red
                b7.BackColor = Color.Red
                MessageBox.Show(player_2 + " wins!", "WINNER", System.Windows.Forms.MessageBoxButtons.OKCancel, MessageBoxIcon.Information)
                oResult += 1
                lNumo.Text = oResult.ToString()
                b3.BackColor = Color.FromKnownColor(KnownColor.Control)
                b3.UseVisualStyleBackColor = True
                b5.BackColor = Color.FromKnownColor(KnownColor.Control)
                b5.UseVisualStyleBackColor = True
                b7.BackColor = Color.FromKnownColor(KnownColor.Control)
                b7.UseVisualStyleBackColor = True
                b1.Text = ""
                b2.Text = ""
                b3.Text = ""
                b4.Text = ""
                b5.Text = ""
                b6.Text = ""
                b7.Text = ""
                b8.Text = ""
                b9.Text = ""
                isClicked1 = True
                isClicked2 = True
                isClicked3 = True
                isClicked4 = True
                isClicked5 = True
                isClicked6 = True
                isClicked7 = True
                isClicked8 = True
                isClicked9 = True

            ElseIf (b1.Text = "O" Or b1.Text = "X") And (b2.Text = "O" Or b2.Text = "X") And (b3.Text = "O" Or b3.Text = "X") And (b4.Text = "O" Or b4.Text = "X") And (b5.Text = "O" Or b5.Text = "X") And (b6.Text = "O" Or b6.Text = "X") And (b7.Text = "O" Or b7.Text = "X") And (b8.Text = "O" Or b8.Text = "X") And (b9.Text = "O" Or b9.Text = "X") Then
                MessageBox.Show("Draw !!!", "WINNER", System.Windows.Forms.MessageBoxButtons.OKCancel, MessageBoxIcon.Information)
                b1.Text = ""
                b2.Text = ""
                b3.Text = ""
                b4.Text = ""
                b5.Text = ""
                b6.Text = ""
                b7.Text = ""
                b8.Text = ""
                b9.Text = ""
                isClicked1 = True
                isClicked2 = True
                isClicked3 = True
                isClicked4 = True
                isClicked5 = True
                isClicked6 = True
                isClicked7 = True
                isClicked8 = True
                isClicked9 = True
            End If

        End If
    End Sub

    Private Sub b6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles b6.Click
        If isClicked6 Then
            If isX Then
                b6.Text = "X"
                isX = False

            Else : b6.Text = "O"
                isX = True
            End If
            isClicked6 = False
            If b1.Text = "X" And b2.Text = "X" And b3.Text = "X" Then
                b1.BackColor = Color.Red
                b2.BackColor = Color.Red
                b3.BackColor = Color.Red
                MessageBox.Show(player_1 + " wins!", "WINNER", System.Windows.Forms.MessageBoxButtons.OKCancel, MessageBoxIcon.Information)
                xResult += 1
                lNumx.Text = xResult.ToString()
                b1.BackColor = Color.FromKnownColor(KnownColor.Control)
                b1.UseVisualStyleBackColor = True
                b2.BackColor = Color.FromKnownColor(KnownColor.Control)
                b2.UseVisualStyleBackColor = True
                b3.BackColor = Color.FromKnownColor(KnownColor.Control)
                b3.UseVisualStyleBackColor = True
                b1.Text = ""
                b2.Text = ""
                b3.Text = ""
                b4.Text = ""
                b5.Text = ""
                b6.Text = ""
                b7.Text = ""
                b8.Text = ""
                b9.Text = ""
                isClicked1 = True
                isClicked2 = True
                isClicked3 = True
                isClicked4 = True
                isClicked5 = True
                isClicked6 = True
                isClicked7 = True
                isClicked8 = True
                isClicked9 = True

            ElseIf b1.Text = "O" And b2.Text = "O" And b3.Text = "O" Then
                b1.BackColor = Color.Red
                b2.BackColor = Color.Red
                b3.BackColor = Color.Red
                MessageBox.Show(player_2 + " wins!", "WINNER", System.Windows.Forms.MessageBoxButtons.OKCancel, MessageBoxIcon.Information)
                oResult += 1
                lNumo.Text = oResult.ToString()
                b1.BackColor = Color.FromKnownColor(KnownColor.Control)
                b1.UseVisualStyleBackColor = True
                b2.BackColor = Color.FromKnownColor(KnownColor.Control)
                b2.UseVisualStyleBackColor = True
                b3.BackColor = Color.FromKnownColor(KnownColor.Control)
                b3.UseVisualStyleBackColor = True
                b1.Text = ""
                b2.Text = ""
                b3.Text = ""
                b4.Text = ""
                b5.Text = ""
                b6.Text = ""
                b7.Text = ""
                b8.Text = ""
                b9.Text = ""
                isClicked1 = True
                isClicked2 = True
                isClicked3 = True
                isClicked4 = True
                isClicked5 = True
                isClicked6 = True
                isClicked7 = True
                isClicked8 = True
                isClicked9 = True

            ElseIf b4.Text = "X" And b5.Text = "X" And b6.Text = "X" Then
                b4.BackColor = Color.Red
                b5.BackColor = Color.Red
                b6.BackColor = Color.Red
                MessageBox.Show(player_1 + " wins!", "WINNER", System.Windows.Forms.MessageBoxButtons.OKCancel, MessageBoxIcon.Information)
                xResult += 1
                lNumx.Text = xResult.ToString()
                b4.BackColor = Color.FromKnownColor(KnownColor.Control)
                b4.UseVisualStyleBackColor = True
                b5.BackColor = Color.FromKnownColor(KnownColor.Control)
                b5.UseVisualStyleBackColor = True
                b6.BackColor = Color.FromKnownColor(KnownColor.Control)
                b6.UseVisualStyleBackColor = True
                b1.Text = ""
                b2.Text = ""
                b3.Text = ""
                b4.Text = ""
                b5.Text = ""
                b6.Text = ""
                b7.Text = ""
                b8.Text = ""
                b9.Text = ""
                isClicked1 = True
                isClicked2 = True
                isClicked3 = True
                isClicked4 = True
                isClicked5 = True
                isClicked6 = True
                isClicked7 = True
                isClicked8 = True
                isClicked9 = True
            ElseIf b4.Text = "O" And b5.Text = "O" And b6.Text = "O" Then
                b4.BackColor = Color.Red
                b5.BackColor = Color.Red
                b6.BackColor = Color.Red
                MessageBox.Show(player_2 + " wins!", "WINNER", System.Windows.Forms.MessageBoxButtons.OKCancel, MessageBoxIcon.Information)
                oResult += 1
                lNumo.Text = oResult.ToString()
                b4.BackColor = Color.FromKnownColor(KnownColor.Control)
                b4.UseVisualStyleBackColor = True
                b5.BackColor = Color.FromKnownColor(KnownColor.Control)
                b5.UseVisualStyleBackColor = True
                b6.BackColor = Color.FromKnownColor(KnownColor.Control)
                b6.UseVisualStyleBackColor = True
                b1.Text = ""
                b2.Text = ""
                b3.Text = ""
                b4.Text = ""
                b5.Text = ""
                b6.Text = ""
                b7.Text = ""
                b8.Text = ""
                b9.Text = ""
                isClicked1 = True
                isClicked2 = True
                isClicked3 = True
                isClicked4 = True
                isClicked5 = True
                isClicked6 = True
                isClicked7 = True
                isClicked8 = True
                isClicked9 = True
            ElseIf b7.Text = "X" And b8.Text = "X" And b9.Text = "X" Then
                b7.BackColor = Color.Red
                b8.BackColor = Color.Red
                b9.BackColor = Color.Red
                MessageBox.Show(player_1 + " wins!", "WINNER", System.Windows.Forms.MessageBoxButtons.OKCancel, MessageBoxIcon.Information)
                xResult += 1
                lNumx.Text = xResult.ToString()
                b7.BackColor = Color.FromKnownColor(KnownColor.Control)
                b7.UseVisualStyleBackColor = True
                b8.BackColor = Color.FromKnownColor(KnownColor.Control)
                b8.UseVisualStyleBackColor = True
                b9.BackColor = Color.FromKnownColor(KnownColor.Control)
                b9.UseVisualStyleBackColor = True
                b1.Text = ""
                b2.Text = ""
                b3.Text = ""
                b4.Text = ""
                b5.Text = ""
                b6.Text = ""
                b7.Text = ""
                b8.Text = ""
                b9.Text = ""
                isClicked1 = True
                isClicked2 = True
                isClicked3 = True
                isClicked4 = True
                isClicked5 = True
                isClicked6 = True
                isClicked7 = True
                isClicked8 = True
                isClicked9 = True
            ElseIf b7.Text = "O" And b8.Text = "O" And b9.Text = "O" Then
                b7.BackColor = Color.Red
                b8.BackColor = Color.Red
                b9.BackColor = Color.Red
                MessageBox.Show(player_2 + " wins!", "WINNER", System.Windows.Forms.MessageBoxButtons.OKCancel, MessageBoxIcon.Information)
                oResult += 1
                lNumo.Text = oResult.ToString()
                b7.BackColor = Color.FromKnownColor(KnownColor.Control)
                b7.UseVisualStyleBackColor = True
                b8.BackColor = Color.FromKnownColor(KnownColor.Control)
                b8.UseVisualStyleBackColor = True
                b9.BackColor = Color.FromKnownColor(KnownColor.Control)
                b9.UseVisualStyleBackColor = True
                b1.Text = ""
                b2.Text = ""
                b3.Text = ""
                b4.Text = ""
                b5.Text = ""
                b6.Text = ""
                b7.Text = ""
                b8.Text = ""
                b9.Text = ""
                isClicked1 = True
                isClicked2 = True
                isClicked3 = True
                isClicked4 = True
                isClicked5 = True
                isClicked6 = True
                isClicked7 = True
                isClicked8 = True
                isClicked9 = True

            ElseIf b1.Text = "X" And b4.Text = "X" And b7.Text = "X" Then
                b1.BackColor = Color.Red
                b4.BackColor = Color.Red
                b7.BackColor = Color.Red
                MessageBox.Show(player_1 + " wins!", "WINNER", System.Windows.Forms.MessageBoxButtons.OKCancel, MessageBoxIcon.Information)
                xResult += 1
                lNumx.Text = xResult.ToString()
                b1.BackColor = Color.FromKnownColor(KnownColor.Control)
                b1.UseVisualStyleBackColor = True
                b4.BackColor = Color.FromKnownColor(KnownColor.Control)
                b4.UseVisualStyleBackColor = True
                b7.BackColor = Color.FromKnownColor(KnownColor.Control)
                b7.UseVisualStyleBackColor = True
                b1.Text = ""
                b2.Text = ""
                b3.Text = ""
                b4.Text = ""
                b5.Text = ""
                b6.Text = ""
                b7.Text = ""
                b8.Text = ""
                b9.Text = ""
                isClicked1 = True
                isClicked2 = True
                isClicked3 = True
                isClicked4 = True
                isClicked5 = True
                isClicked6 = True
                isClicked7 = True
                isClicked8 = True
                isClicked9 = True

            ElseIf b1.Text = "O" And b4.Text = "O" And b7.Text = "O" Then
                b1.BackColor = Color.Red
                b4.BackColor = Color.Red
                b7.BackColor = Color.Red
                MessageBox.Show(player_2 + " wins!", "WINNER", System.Windows.Forms.MessageBoxButtons.OKCancel, MessageBoxIcon.Information)
                oResult += 1
                lNumo.Text = oResult.ToString()
                b1.BackColor = Color.FromKnownColor(KnownColor.Control)
                b1.UseVisualStyleBackColor = True
                b4.BackColor = Color.FromKnownColor(KnownColor.Control)
                b4.UseVisualStyleBackColor = True
                b7.BackColor = Color.FromKnownColor(KnownColor.Control)
                b7.UseVisualStyleBackColor = True
                b1.Text = ""
                b2.Text = ""
                b3.Text = ""
                b4.Text = ""
                b5.Text = ""
                b6.Text = ""
                b7.Text = ""
                b8.Text = ""
                b9.Text = ""
                isClicked1 = True
                isClicked2 = True
                isClicked3 = True
                isClicked4 = True
                isClicked5 = True
                isClicked6 = True
                isClicked7 = True
                isClicked8 = True
                isClicked9 = True

            ElseIf b2.Text = "X" And b5.Text = "X" And b8.Text = "X" Then
                b2.BackColor = Color.Red
                b5.BackColor = Color.Red
                b8.BackColor = Color.Red
                MessageBox.Show(player_1 + " wins!", "WINNER", System.Windows.Forms.MessageBoxButtons.OKCancel, MessageBoxIcon.Information)
                xResult += 1
                lNumx.Text = xResult.ToString()
                b2.BackColor = Color.FromKnownColor(KnownColor.Control)
                b2.UseVisualStyleBackColor = True
                b5.BackColor = Color.FromKnownColor(KnownColor.Control)
                b5.UseVisualStyleBackColor = True
                b8.BackColor = Color.FromKnownColor(KnownColor.Control)
                b8.UseVisualStyleBackColor = True
                b1.Text = ""
                b2.Text = ""
                b3.Text = ""
                b4.Text = ""
                b5.Text = ""
                b6.Text = ""
                b7.Text = ""
                b8.Text = ""
                b9.Text = ""
                isClicked1 = True
                isClicked2 = True
                isClicked3 = True
                isClicked4 = True
                isClicked5 = True
                isClicked6 = True
                isClicked7 = True
                isClicked8 = True
                isClicked9 = True

            ElseIf b2.Text = "O" And b5.Text = "O" And b8.Text = "O" Then
                b2.BackColor = Color.Red
                b5.BackColor = Color.Red
                b8.BackColor = Color.Red
                MessageBox.Show(player_2 + " wins!", "WINNER", System.Windows.Forms.MessageBoxButtons.OKCancel, MessageBoxIcon.Information)
                oResult += 1
                lNumo.Text = oResult.ToString()
                b2.BackColor = Color.FromKnownColor(KnownColor.Control)
                b2.UseVisualStyleBackColor = True
                b5.BackColor = Color.FromKnownColor(KnownColor.Control)
                b5.UseVisualStyleBackColor = True
                b8.BackColor = Color.FromKnownColor(KnownColor.Control)
                b8.UseVisualStyleBackColor = True
                b1.Text = ""
                b2.Text = ""
                b3.Text = ""
                b4.Text = ""
                b5.Text = ""
                b6.Text = ""
                b7.Text = ""
                b8.Text = ""
                b9.Text = ""
                isClicked1 = True
                isClicked2 = True
                isClicked3 = True
                isClicked4 = True
                isClicked5 = True
                isClicked6 = True
                isClicked7 = True
                isClicked8 = True
                isClicked9 = True

            ElseIf b3.Text = "X" And b6.Text = "X" And b9.Text = "X" Then
                b3.BackColor = Color.Red
                b6.BackColor = Color.Red
                b9.BackColor = Color.Red
                MessageBox.Show(player_1 + " wins!", "WINNER", System.Windows.Forms.MessageBoxButtons.OKCancel, MessageBoxIcon.Information)
                xResult += 1
                lNumx.Text = xResult.ToString()
                b3.BackColor = Color.FromKnownColor(KnownColor.Control)
                b3.UseVisualStyleBackColor = True
                b6.BackColor = Color.FromKnownColor(KnownColor.Control)
                b6.UseVisualStyleBackColor = True
                b9.BackColor = Color.FromKnownColor(KnownColor.Control)
                b9.UseVisualStyleBackColor = True
                b1.Text = ""
                b2.Text = ""
                b3.Text = ""
                b4.Text = ""
                b5.Text = ""
                b6.Text = ""
                b7.Text = ""
                b8.Text = ""
                b9.Text = ""
                isClicked1 = True
                isClicked2 = True
                isClicked3 = True
                isClicked4 = True
                isClicked5 = True
                isClicked6 = True
                isClicked7 = True
                isClicked8 = True
                isClicked9 = True

            ElseIf b3.Text = "O" And b6.Text = "O" And b9.Text = "O" Then
                b3.BackColor = Color.Red
                b6.BackColor = Color.Red
                b9.BackColor = Color.Red
                MessageBox.Show(player_2 + " wins!", "WINNER", System.Windows.Forms.MessageBoxButtons.OKCancel, MessageBoxIcon.Information)
                oResult += 1
                lNumo.Text = oResult.ToString()
                b3.BackColor = Color.FromKnownColor(KnownColor.Control)
                b3.UseVisualStyleBackColor = True
                b6.BackColor = Color.FromKnownColor(KnownColor.Control)
                b6.UseVisualStyleBackColor = True
                b9.BackColor = Color.FromKnownColor(KnownColor.Control)
                b9.UseVisualStyleBackColor = True
                b1.Text = ""
                b2.Text = ""
                b3.Text = ""
                b4.Text = ""
                b5.Text = ""
                b6.Text = ""
                b7.Text = ""
                b8.Text = ""
                b9.Text = ""
                isClicked1 = True
                isClicked2 = True
                isClicked3 = True
                isClicked4 = True
                isClicked5 = True
                isClicked6 = True
                isClicked7 = True
                isClicked8 = True
                isClicked9 = True

            ElseIf b1.Text = "X" And b5.Text = "X" And b9.Text = "X" Then
                b1.BackColor = Color.Red
                b5.BackColor = Color.Red
                b9.BackColor = Color.Red
                MessageBox.Show(player_1 + " wins!", "WINNER", System.Windows.Forms.MessageBoxButtons.OKCancel, MessageBoxIcon.Information)
                xResult += 1
                lNumx.Text = xResult.ToString()
                b1.BackColor = Color.FromKnownColor(KnownColor.Control)
                b1.UseVisualStyleBackColor = True
                b5.BackColor = Color.FromKnownColor(KnownColor.Control)
                b5.UseVisualStyleBackColor = True
                b9.BackColor = Color.FromKnownColor(KnownColor.Control)
                b9.UseVisualStyleBackColor = True
                b1.Text = ""
                b2.Text = ""
                b3.Text = ""
                b4.Text = ""
                b5.Text = ""
                b6.Text = ""
                b7.Text = ""
                b8.Text = ""
                b9.Text = ""
                isClicked1 = True
                isClicked2 = True
                isClicked3 = True
                isClicked4 = True
                isClicked5 = True
                isClicked6 = True
                isClicked7 = True
                isClicked8 = True
                isClicked9 = True

            ElseIf b1.Text = "O" And b5.Text = "O" And b9.Text = "O" Then
                b1.BackColor = Color.Red
                b5.BackColor = Color.Red
                b9.BackColor = Color.Red
                MessageBox.Show(player_2 + " wins!", "WINNER", System.Windows.Forms.MessageBoxButtons.OKCancel, MessageBoxIcon.Information)
                oResult += 1
                lNumo.Text = oResult.ToString()
                b1.BackColor = Color.FromKnownColor(KnownColor.Control)
                b1.UseVisualStyleBackColor = True
                b5.BackColor = Color.FromKnownColor(KnownColor.Control)
                b5.UseVisualStyleBackColor = True
                b9.BackColor = Color.FromKnownColor(KnownColor.Control)
                b9.UseVisualStyleBackColor = True
                b1.Text = ""
                b2.Text = ""
                b3.Text = ""
                b4.Text = ""
                b5.Text = ""
                b6.Text = ""
                b7.Text = ""
                b8.Text = ""
                b9.Text = ""
                isClicked1 = True
                isClicked2 = True
                isClicked3 = True
                isClicked4 = True
                isClicked5 = True
                isClicked6 = True
                isClicked7 = True
                isClicked8 = True
                isClicked9 = True

            ElseIf b3.Text = "X" And b5.Text = "X" And b7.Text = "X" Then
                b3.BackColor = Color.Red
                b5.BackColor = Color.Red
                b7.BackColor = Color.Red
                MessageBox.Show(player_1 + " wins!", "WINNER", System.Windows.Forms.MessageBoxButtons.OKCancel, MessageBoxIcon.Information)
                xResult += 1
                lNumx.Text = xResult.ToString()
                b3.BackColor = Color.FromKnownColor(KnownColor.Control)
                b3.UseVisualStyleBackColor = True
                b5.BackColor = Color.FromKnownColor(KnownColor.Control)
                b5.UseVisualStyleBackColor = True
                b7.BackColor = Color.FromKnownColor(KnownColor.Control)
                b7.UseVisualStyleBackColor = True
                b1.Text = ""
                b2.Text = ""
                b3.Text = ""
                b4.Text = ""
                b5.Text = ""
                b6.Text = ""
                b7.Text = ""
                b8.Text = ""
                b9.Text = ""
                isClicked1 = True
                isClicked2 = True
                isClicked3 = True
                isClicked4 = True
                isClicked5 = True
                isClicked6 = True
                isClicked7 = True
                isClicked8 = True
                isClicked9 = True

            ElseIf b3.Text = "O" And b5.Text = "O" And b7.Text = "O" Then
                b3.BackColor = Color.Red
                b5.BackColor = Color.Red
                b7.BackColor = Color.Red
                MessageBox.Show(player_2 + " wins!", "WINNER", System.Windows.Forms.MessageBoxButtons.OKCancel, MessageBoxIcon.Information)
                oResult += 1
                lNumo.Text = oResult.ToString()
                b3.BackColor = Color.FromKnownColor(KnownColor.Control)
                b3.UseVisualStyleBackColor = True
                b5.BackColor = Color.FromKnownColor(KnownColor.Control)
                b5.UseVisualStyleBackColor = True
                b7.BackColor = Color.FromKnownColor(KnownColor.Control)
                b7.UseVisualStyleBackColor = True
                b1.Text = ""
                b2.Text = ""
                b3.Text = ""
                b4.Text = ""
                b5.Text = ""
                b6.Text = ""
                b7.Text = ""
                b8.Text = ""
                b9.Text = ""
                isClicked1 = True
                isClicked2 = True
                isClicked3 = True
                isClicked4 = True
                isClicked5 = True
                isClicked6 = True
                isClicked7 = True
                isClicked8 = True
                isClicked9 = True

            ElseIf (b1.Text = "O" Or b1.Text = "X") And (b2.Text = "O" Or b2.Text = "X") And (b3.Text = "O" Or b3.Text = "X") And (b4.Text = "O" Or b4.Text = "X") And (b5.Text = "O" Or b5.Text = "X") And (b6.Text = "O" Or b6.Text = "X") And (b7.Text = "O" Or b7.Text = "X") And (b8.Text = "O" Or b8.Text = "X") And (b9.Text = "O" Or b9.Text = "X") Then
                MessageBox.Show("Draw !!!", "WINNER", System.Windows.Forms.MessageBoxButtons.OKCancel, MessageBoxIcon.Information)
                b1.Text = ""
                b2.Text = ""
                b3.Text = ""
                b4.Text = ""
                b5.Text = ""
                b6.Text = ""
                b7.Text = ""
                b8.Text = ""
                b9.Text = ""
                isClicked1 = True
                isClicked2 = True
                isClicked3 = True
                isClicked4 = True
                isClicked5 = True
                isClicked6 = True
                isClicked7 = True
                isClicked8 = True
                isClicked9 = True
            End If

        End If
    End Sub

    Private Sub b7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles b7.Click
        If isClicked7 Then
            If isX Then
                b7.Text = "X"
                isX = False

            Else : b7.Text = "O"
                isX = True
            End If
            isClicked7 = False
            If b1.Text = "X" And b2.Text = "X" And b3.Text = "X" Then
                b1.BackColor = Color.Red
                b2.BackColor = Color.Red
                b3.BackColor = Color.Red
                MessageBox.Show(player_1 + " wins!", "WINNER", System.Windows.Forms.MessageBoxButtons.OKCancel, MessageBoxIcon.Information)
                xResult += 1
                lNumx.Text = xResult.ToString()
                b1.BackColor = Color.FromKnownColor(KnownColor.Control)
                b1.UseVisualStyleBackColor = True
                b2.BackColor = Color.FromKnownColor(KnownColor.Control)
                b2.UseVisualStyleBackColor = True
                b3.BackColor = Color.FromKnownColor(KnownColor.Control)
                b3.UseVisualStyleBackColor = True
                b1.Text = ""
                b2.Text = ""
                b3.Text = ""
                b4.Text = ""
                b5.Text = ""
                b6.Text = ""
                b7.Text = ""
                b8.Text = ""
                b9.Text = ""
                isClicked1 = True
                isClicked2 = True
                isClicked3 = True
                isClicked4 = True
                isClicked5 = True
                isClicked6 = True
                isClicked7 = True
                isClicked8 = True
                isClicked9 = True

            ElseIf b1.Text = "O" And b2.Text = "O" And b3.Text = "O" Then
                b1.BackColor = Color.Red
                b2.BackColor = Color.Red
                b3.BackColor = Color.Red
                MessageBox.Show(player_2 + " wins!", "WINNER", System.Windows.Forms.MessageBoxButtons.OKCancel, MessageBoxIcon.Information)
                oResult += 1
                lNumo.Text = oResult.ToString()
                b1.BackColor = Color.FromKnownColor(KnownColor.Control)
                b1.UseVisualStyleBackColor = True
                b2.BackColor = Color.FromKnownColor(KnownColor.Control)
                b2.UseVisualStyleBackColor = True
                b3.BackColor = Color.FromKnownColor(KnownColor.Control)
                b3.UseVisualStyleBackColor = True
                b1.Text = ""
                b2.Text = ""
                b3.Text = ""
                b4.Text = ""
                b5.Text = ""
                b6.Text = ""
                b7.Text = ""
                b8.Text = ""
                b9.Text = ""
                isClicked1 = True
                isClicked2 = True
                isClicked3 = True
                isClicked4 = True
                isClicked5 = True
                isClicked6 = True
                isClicked7 = True
                isClicked8 = True
                isClicked9 = True

            ElseIf b4.Text = "X" And b5.Text = "X" And b6.Text = "X" Then
                b4.BackColor = Color.Red
                b5.BackColor = Color.Red
                b6.BackColor = Color.Red
                MessageBox.Show(player_1 + " wins!", "WINNER", System.Windows.Forms.MessageBoxButtons.OKCancel, MessageBoxIcon.Information)
                xResult += 1
                lNumx.Text = xResult.ToString()
                b4.BackColor = Color.FromKnownColor(KnownColor.Control)
                b4.UseVisualStyleBackColor = True
                b5.BackColor = Color.FromKnownColor(KnownColor.Control)
                b5.UseVisualStyleBackColor = True
                b6.BackColor = Color.FromKnownColor(KnownColor.Control)
                b6.UseVisualStyleBackColor = True
                b1.Text = ""
                b2.Text = ""
                b3.Text = ""
                b4.Text = ""
                b5.Text = ""
                b6.Text = ""
                b7.Text = ""
                b8.Text = ""
                b9.Text = ""
                isClicked1 = True
                isClicked2 = True
                isClicked3 = True
                isClicked4 = True
                isClicked5 = True
                isClicked6 = True
                isClicked7 = True
                isClicked8 = True
                isClicked9 = True
            ElseIf b4.Text = "O" And b5.Text = "O" And b6.Text = "O" Then
                b4.BackColor = Color.Red
                b5.BackColor = Color.Red
                b6.BackColor = Color.Red
                MessageBox.Show(player_2 + " wins!", "WINNER", System.Windows.Forms.MessageBoxButtons.OKCancel, MessageBoxIcon.Information)
                oResult += 1
                lNumo.Text = oResult.ToString()
                b4.BackColor = Color.FromKnownColor(KnownColor.Control)
                b4.UseVisualStyleBackColor = True
                b5.BackColor = Color.FromKnownColor(KnownColor.Control)
                b5.UseVisualStyleBackColor = True
                b6.BackColor = Color.FromKnownColor(KnownColor.Control)
                b6.UseVisualStyleBackColor = True
                b1.Text = ""
                b2.Text = ""
                b3.Text = ""
                b4.Text = ""
                b5.Text = ""
                b6.Text = ""
                b7.Text = ""
                b8.Text = ""
                b9.Text = ""
                isClicked1 = True
                isClicked2 = True
                isClicked3 = True
                isClicked4 = True
                isClicked5 = True
                isClicked6 = True
                isClicked7 = True
                isClicked8 = True
                isClicked9 = True
            ElseIf b7.Text = "X" And b8.Text = "X" And b9.Text = "X" Then
                b7.BackColor = Color.Red
                b8.BackColor = Color.Red
                b9.BackColor = Color.Red
                MessageBox.Show(player_1 + " wins!", "WINNER", System.Windows.Forms.MessageBoxButtons.OKCancel, MessageBoxIcon.Information)
                xResult += 1
                lNumx.Text = xResult.ToString()
                b7.BackColor = Color.FromKnownColor(KnownColor.Control)
                b7.UseVisualStyleBackColor = True
                b8.BackColor = Color.FromKnownColor(KnownColor.Control)
                b8.UseVisualStyleBackColor = True
                b9.BackColor = Color.FromKnownColor(KnownColor.Control)
                b9.UseVisualStyleBackColor = True
                b1.Text = ""
                b2.Text = ""
                b3.Text = ""
                b4.Text = ""
                b5.Text = ""
                b6.Text = ""
                b7.Text = ""
                b8.Text = ""
                b9.Text = ""
                isClicked1 = True
                isClicked2 = True
                isClicked3 = True
                isClicked4 = True
                isClicked5 = True
                isClicked6 = True
                isClicked7 = True
                isClicked8 = True
                isClicked9 = True
            ElseIf b7.Text = "O" And b8.Text = "O" And b9.Text = "O" Then
                b7.BackColor = Color.Red
                b8.BackColor = Color.Red
                b9.BackColor = Color.Red
                MessageBox.Show(player_2 + " wins!", "WINNER", System.Windows.Forms.MessageBoxButtons.OKCancel, MessageBoxIcon.Information)
                oResult += 1
                lNumo.Text = oResult.ToString()
                b7.BackColor = Color.FromKnownColor(KnownColor.Control)
                b7.UseVisualStyleBackColor = True
                b8.BackColor = Color.FromKnownColor(KnownColor.Control)
                b8.UseVisualStyleBackColor = True
                b9.BackColor = Color.FromKnownColor(KnownColor.Control)
                b9.UseVisualStyleBackColor = True
                b1.Text = ""
                b2.Text = ""
                b3.Text = ""
                b4.Text = ""
                b5.Text = ""
                b6.Text = ""
                b7.Text = ""
                b8.Text = ""
                b9.Text = ""
                isClicked1 = True
                isClicked2 = True
                isClicked3 = True
                isClicked4 = True
                isClicked5 = True
                isClicked6 = True
                isClicked7 = True
                isClicked8 = True
                isClicked9 = True

            ElseIf b1.Text = "X" And b4.Text = "X" And b7.Text = "X" Then
                b1.BackColor = Color.Red
                b4.BackColor = Color.Red
                b7.BackColor = Color.Red
                MessageBox.Show(player_1 + " wins!", "WINNER", System.Windows.Forms.MessageBoxButtons.OKCancel, MessageBoxIcon.Information)
                xResult += 1
                lNumx.Text = xResult.ToString()
                b1.BackColor = Color.FromKnownColor(KnownColor.Control)
                b1.UseVisualStyleBackColor = True
                b4.BackColor = Color.FromKnownColor(KnownColor.Control)
                b4.UseVisualStyleBackColor = True
                b7.BackColor = Color.FromKnownColor(KnownColor.Control)
                b7.UseVisualStyleBackColor = True
                b1.Text = ""
                b2.Text = ""
                b3.Text = ""
                b4.Text = ""
                b5.Text = ""
                b6.Text = ""
                b7.Text = ""
                b8.Text = ""
                b9.Text = ""
                isClicked1 = True
                isClicked2 = True
                isClicked3 = True
                isClicked4 = True
                isClicked5 = True
                isClicked6 = True
                isClicked7 = True
                isClicked8 = True
                isClicked9 = True

            ElseIf b1.Text = "O" And b4.Text = "O" And b7.Text = "O" Then
                b1.BackColor = Color.Red
                b4.BackColor = Color.Red
                b7.BackColor = Color.Red
                MessageBox.Show(player_2 + " wins!", "WINNER", System.Windows.Forms.MessageBoxButtons.OKCancel, MessageBoxIcon.Information)
                oResult += 1
                lNumo.Text = oResult.ToString()
                b1.BackColor = Color.FromKnownColor(KnownColor.Control)
                b1.UseVisualStyleBackColor = True
                b4.BackColor = Color.FromKnownColor(KnownColor.Control)
                b4.UseVisualStyleBackColor = True
                b7.BackColor = Color.FromKnownColor(KnownColor.Control)
                b7.UseVisualStyleBackColor = True
                b1.Text = ""
                b2.Text = ""
                b3.Text = ""
                b4.Text = ""
                b5.Text = ""
                b6.Text = ""
                b7.Text = ""
                b8.Text = ""
                b9.Text = ""
                isClicked1 = True
                isClicked2 = True
                isClicked3 = True
                isClicked4 = True
                isClicked5 = True
                isClicked6 = True
                isClicked7 = True
                isClicked8 = True
                isClicked9 = True

            ElseIf b2.Text = "X" And b5.Text = "X" And b8.Text = "X" Then
                b2.BackColor = Color.Red
                b5.BackColor = Color.Red
                b8.BackColor = Color.Red
                MessageBox.Show(player_1 + " wins!", "WINNER", System.Windows.Forms.MessageBoxButtons.OKCancel, MessageBoxIcon.Information)
                xResult += 1
                lNumx.Text = xResult.ToString()
                b2.BackColor = Color.FromKnownColor(KnownColor.Control)
                b2.UseVisualStyleBackColor = True
                b5.BackColor = Color.FromKnownColor(KnownColor.Control)
                b5.UseVisualStyleBackColor = True
                b8.BackColor = Color.FromKnownColor(KnownColor.Control)
                b8.UseVisualStyleBackColor = True
                b1.Text = ""
                b2.Text = ""
                b3.Text = ""
                b4.Text = ""
                b5.Text = ""
                b6.Text = ""
                b7.Text = ""
                b8.Text = ""
                b9.Text = ""
                isClicked1 = True
                isClicked2 = True
                isClicked3 = True
                isClicked4 = True
                isClicked5 = True
                isClicked6 = True
                isClicked7 = True
                isClicked8 = True
                isClicked9 = True

            ElseIf b2.Text = "O" And b5.Text = "O" And b8.Text = "O" Then
                b2.BackColor = Color.Red
                b5.BackColor = Color.Red
                b8.BackColor = Color.Red
                MessageBox.Show(player_2 + " wins!", "WINNER", System.Windows.Forms.MessageBoxButtons.OKCancel, MessageBoxIcon.Information)
                oResult += 1
                lNumo.Text = oResult.ToString()
                b2.BackColor = Color.FromKnownColor(KnownColor.Control)
                b2.UseVisualStyleBackColor = True
                b5.BackColor = Color.FromKnownColor(KnownColor.Control)
                b5.UseVisualStyleBackColor = True
                b8.BackColor = Color.FromKnownColor(KnownColor.Control)
                b8.UseVisualStyleBackColor = True
                b1.Text = ""
                b2.Text = ""
                b3.Text = ""
                b4.Text = ""
                b5.Text = ""
                b6.Text = ""
                b7.Text = ""
                b8.Text = ""
                b9.Text = ""
                isClicked1 = True
                isClicked2 = True
                isClicked3 = True
                isClicked4 = True
                isClicked5 = True
                isClicked6 = True
                isClicked7 = True
                isClicked8 = True
                isClicked9 = True

            ElseIf b3.Text = "X" And b6.Text = "X" And b9.Text = "X" Then
                b3.BackColor = Color.Red
                b6.BackColor = Color.Red
                b9.BackColor = Color.Red
                MessageBox.Show(player_1 + " wins!", "WINNER", System.Windows.Forms.MessageBoxButtons.OKCancel, MessageBoxIcon.Information)
                xResult += 1
                lNumx.Text = xResult.ToString()
                b3.BackColor = Color.FromKnownColor(KnownColor.Control)
                b3.UseVisualStyleBackColor = True
                b6.BackColor = Color.FromKnownColor(KnownColor.Control)
                b6.UseVisualStyleBackColor = True
                b9.BackColor = Color.FromKnownColor(KnownColor.Control)
                b9.UseVisualStyleBackColor = True
                b1.Text = ""
                b2.Text = ""
                b3.Text = ""
                b4.Text = ""
                b5.Text = ""
                b6.Text = ""
                b7.Text = ""
                b8.Text = ""
                b9.Text = ""
                isClicked1 = True
                isClicked2 = True
                isClicked3 = True
                isClicked4 = True
                isClicked5 = True
                isClicked6 = True
                isClicked7 = True
                isClicked8 = True
                isClicked9 = True

            ElseIf b3.Text = "O" And b6.Text = "O" And b9.Text = "O" Then
                b3.BackColor = Color.Red
                b6.BackColor = Color.Red
                b9.BackColor = Color.Red
                MessageBox.Show(player_2 + " wins!", "WINNER", System.Windows.Forms.MessageBoxButtons.OKCancel, MessageBoxIcon.Information)
                oResult += 1
                lNumo.Text = oResult.ToString()
                b3.BackColor = Color.FromKnownColor(KnownColor.Control)
                b3.UseVisualStyleBackColor = True
                b6.BackColor = Color.FromKnownColor(KnownColor.Control)
                b6.UseVisualStyleBackColor = True
                b9.BackColor = Color.FromKnownColor(KnownColor.Control)
                b9.UseVisualStyleBackColor = True
                b1.Text = ""
                b2.Text = ""
                b3.Text = ""
                b4.Text = ""
                b5.Text = ""
                b6.Text = ""
                b7.Text = ""
                b8.Text = ""
                b9.Text = ""
                isClicked1 = True
                isClicked2 = True
                isClicked3 = True
                isClicked4 = True
                isClicked5 = True
                isClicked6 = True
                isClicked7 = True
                isClicked8 = True
                isClicked9 = True

            ElseIf b1.Text = "X" And b5.Text = "X" And b9.Text = "X" Then
                b1.BackColor = Color.Red
                b5.BackColor = Color.Red
                b9.BackColor = Color.Red
                MessageBox.Show(player_1 + " wins!", "WINNER", System.Windows.Forms.MessageBoxButtons.OKCancel, MessageBoxIcon.Information)
                xResult += 1
                lNumx.Text = xResult.ToString()
                b1.BackColor = Color.FromKnownColor(KnownColor.Control)
                b1.UseVisualStyleBackColor = True
                b5.BackColor = Color.FromKnownColor(KnownColor.Control)
                b5.UseVisualStyleBackColor = True
                b9.BackColor = Color.FromKnownColor(KnownColor.Control)
                b9.UseVisualStyleBackColor = True
                b1.Text = ""
                b2.Text = ""
                b3.Text = ""
                b4.Text = ""
                b5.Text = ""
                b6.Text = ""
                b7.Text = ""
                b8.Text = ""
                b9.Text = ""
                isClicked1 = True
                isClicked2 = True
                isClicked3 = True
                isClicked4 = True
                isClicked5 = True
                isClicked6 = True
                isClicked7 = True
                isClicked8 = True
                isClicked9 = True

            ElseIf b1.Text = "O" And b5.Text = "O" And b9.Text = "O" Then
                b1.BackColor = Color.Red
                b5.BackColor = Color.Red
                b9.BackColor = Color.Red
                MessageBox.Show(player_2 + " wins!", "WINNER", System.Windows.Forms.MessageBoxButtons.OKCancel, MessageBoxIcon.Information)
                oResult += 1
                lNumo.Text = oResult.ToString()
                b1.BackColor = Color.FromKnownColor(KnownColor.Control)
                b1.UseVisualStyleBackColor = True
                b5.BackColor = Color.FromKnownColor(KnownColor.Control)
                b5.UseVisualStyleBackColor = True
                b9.BackColor = Color.FromKnownColor(KnownColor.Control)
                b9.UseVisualStyleBackColor = True
                b1.Text = ""
                b2.Text = ""
                b3.Text = ""
                b4.Text = ""
                b5.Text = ""
                b6.Text = ""
                b7.Text = ""
                b8.Text = ""
                b9.Text = ""
                isClicked1 = True
                isClicked2 = True
                isClicked3 = True
                isClicked4 = True
                isClicked5 = True
                isClicked6 = True
                isClicked7 = True
                isClicked8 = True
                isClicked9 = True

            ElseIf b3.Text = "X" And b5.Text = "X" And b7.Text = "X" Then
                b3.BackColor = Color.Red
                b5.BackColor = Color.Red
                b7.BackColor = Color.Red
                MessageBox.Show(player_1 + " wins!", "WINNER", System.Windows.Forms.MessageBoxButtons.OKCancel, MessageBoxIcon.Information)
                xResult += 1
                lNumx.Text = xResult.ToString()
                b3.BackColor = Color.FromKnownColor(KnownColor.Control)
                b3.UseVisualStyleBackColor = True
                b5.BackColor = Color.FromKnownColor(KnownColor.Control)
                b5.UseVisualStyleBackColor = True
                b7.BackColor = Color.FromKnownColor(KnownColor.Control)
                b7.UseVisualStyleBackColor = True
                b1.Text = ""
                b2.Text = ""
                b3.Text = ""
                b4.Text = ""
                b5.Text = ""
                b6.Text = ""
                b7.Text = ""
                b8.Text = ""
                b9.Text = ""
                isClicked1 = True
                isClicked2 = True
                isClicked3 = True
                isClicked4 = True
                isClicked5 = True
                isClicked6 = True
                isClicked7 = True
                isClicked8 = True
                isClicked9 = True

            ElseIf b3.Text = "O" And b5.Text = "O" And b7.Text = "O" Then
                b3.BackColor = Color.Red
                b5.BackColor = Color.Red
                b7.BackColor = Color.Red
                MessageBox.Show(player_2 + " wins!", "WINNER", System.Windows.Forms.MessageBoxButtons.OKCancel, MessageBoxIcon.Information)
                oResult += 1
                lNumo.Text = oResult.ToString()
                b3.BackColor = Color.FromKnownColor(KnownColor.Control)
                b3.UseVisualStyleBackColor = True
                b5.BackColor = Color.FromKnownColor(KnownColor.Control)
                b5.UseVisualStyleBackColor = True
                b7.BackColor = Color.FromKnownColor(KnownColor.Control)
                b7.UseVisualStyleBackColor = True
                b1.Text = ""
                b2.Text = ""
                b3.Text = ""
                b4.Text = ""
                b5.Text = ""
                b6.Text = ""
                b7.Text = ""
                b8.Text = ""
                b9.Text = ""
                isClicked1 = True
                isClicked2 = True
                isClicked3 = True
                isClicked4 = True
                isClicked5 = True
                isClicked6 = True
                isClicked7 = True
                isClicked8 = True
                isClicked9 = True

            ElseIf (b1.Text = "O" Or b1.Text = "X") And (b2.Text = "O" Or b2.Text = "X") And (b3.Text = "O" Or b3.Text = "X") And (b4.Text = "O" Or b4.Text = "X") And (b5.Text = "O" Or b5.Text = "X") And (b6.Text = "O" Or b6.Text = "X") And (b7.Text = "O" Or b7.Text = "X") And (b8.Text = "O" Or b8.Text = "X") And (b9.Text = "O" Or b9.Text = "X") Then
                MessageBox.Show("Draw !!!", "WINNER", System.Windows.Forms.MessageBoxButtons.OKCancel, MessageBoxIcon.Information)
                b1.Text = ""
                b2.Text = ""
                b3.Text = ""
                b4.Text = ""
                b5.Text = ""
                b6.Text = ""
                b7.Text = ""
                b8.Text = ""
                b9.Text = ""
                isClicked1 = True
                isClicked2 = True
                isClicked3 = True
                isClicked4 = True
                isClicked5 = True
                isClicked6 = True
                isClicked7 = True
                isClicked8 = True
                isClicked9 = True
            End If

        End If
    End Sub

    Private Sub b8_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles b8.Click
        If isClicked8 Then
            If isX Then
                b8.Text = "X"
                isX = False

            Else : b8.Text = "O"
                isX = True
            End If

            isClicked8 = False
            If b1.Text = "X" And b2.Text = "X" And b3.Text = "X" Then
                b1.BackColor = Color.Red
                b2.BackColor = Color.Red
                b3.BackColor = Color.Red
                MessageBox.Show(player_1 + " wins!", "WINNER", System.Windows.Forms.MessageBoxButtons.OKCancel, MessageBoxIcon.Information)
                xResult += 1
                lNumx.Text = xResult.ToString()
                b1.BackColor = Color.FromKnownColor(KnownColor.Control)
                b1.UseVisualStyleBackColor = True
                b2.BackColor = Color.FromKnownColor(KnownColor.Control)
                b2.UseVisualStyleBackColor = True
                b3.BackColor = Color.FromKnownColor(KnownColor.Control)
                b3.UseVisualStyleBackColor = True
                b1.Text = ""
                b2.Text = ""
                b3.Text = ""
                b4.Text = ""
                b5.Text = ""
                b6.Text = ""
                b7.Text = ""
                b8.Text = ""
                b9.Text = ""
                isClicked1 = True
                isClicked2 = True
                isClicked3 = True
                isClicked4 = True
                isClicked5 = True
                isClicked6 = True
                isClicked7 = True
                isClicked8 = True
                isClicked9 = True

            ElseIf b1.Text = "O" And b2.Text = "O" And b3.Text = "O" Then
                b1.BackColor = Color.Red
                b2.BackColor = Color.Red
                b3.BackColor = Color.Red
                MessageBox.Show(player_2 + " wins!", "WINNER", System.Windows.Forms.MessageBoxButtons.OKCancel, MessageBoxIcon.Information)
                oResult += 1
                lNumo.Text = oResult.ToString()
                b1.BackColor = Color.FromKnownColor(KnownColor.Control)
                b1.UseVisualStyleBackColor = True
                b2.BackColor = Color.FromKnownColor(KnownColor.Control)
                b2.UseVisualStyleBackColor = True
                b3.BackColor = Color.FromKnownColor(KnownColor.Control)
                b3.UseVisualStyleBackColor = True
                b1.Text = ""
                b2.Text = ""
                b3.Text = ""
                b4.Text = ""
                b5.Text = ""
                b6.Text = ""
                b7.Text = ""
                b8.Text = ""
                b9.Text = ""
                isClicked1 = True
                isClicked2 = True
                isClicked3 = True
                isClicked4 = True
                isClicked5 = True
                isClicked6 = True
                isClicked7 = True
                isClicked8 = True
                isClicked9 = True

            ElseIf b4.Text = "X" And b5.Text = "X" And b6.Text = "X" Then
                b4.BackColor = Color.Red
                b5.BackColor = Color.Red
                b6.BackColor = Color.Red
                MessageBox.Show(player_1 + " wins!", "WINNER", System.Windows.Forms.MessageBoxButtons.OKCancel, MessageBoxIcon.Information)
                xResult += 1
                lNumx.Text = xResult.ToString()
                b4.BackColor = Color.FromKnownColor(KnownColor.Control)
                b4.UseVisualStyleBackColor = True
                b5.BackColor = Color.FromKnownColor(KnownColor.Control)
                b5.UseVisualStyleBackColor = True
                b6.BackColor = Color.FromKnownColor(KnownColor.Control)
                b6.UseVisualStyleBackColor = True
                b1.Text = ""
                b2.Text = ""
                b3.Text = ""
                b4.Text = ""
                b5.Text = ""
                b6.Text = ""
                b7.Text = ""
                b8.Text = ""
                b9.Text = ""
                isClicked1 = True
                isClicked2 = True
                isClicked3 = True
                isClicked4 = True
                isClicked5 = True
                isClicked6 = True
                isClicked7 = True
                isClicked8 = True
                isClicked9 = True
            ElseIf b4.Text = "O" And b5.Text = "O" And b6.Text = "O" Then
                b4.BackColor = Color.Red
                b5.BackColor = Color.Red
                b6.BackColor = Color.Red
                MessageBox.Show(player_2 + " wins!", "WINNER", System.Windows.Forms.MessageBoxButtons.OKCancel, MessageBoxIcon.Information)
                oResult += 1
                lNumo.Text = oResult.ToString()
                b4.BackColor = Color.FromKnownColor(KnownColor.Control)
                b4.UseVisualStyleBackColor = True
                b5.BackColor = Color.FromKnownColor(KnownColor.Control)
                b5.UseVisualStyleBackColor = True
                b6.BackColor = Color.FromKnownColor(KnownColor.Control)
                b6.UseVisualStyleBackColor = True
                b1.Text = ""
                b2.Text = ""
                b3.Text = ""
                b4.Text = ""
                b5.Text = ""
                b6.Text = ""
                b7.Text = ""
                b8.Text = ""
                b9.Text = ""
                isClicked1 = True
                isClicked2 = True
                isClicked3 = True
                isClicked4 = True
                isClicked5 = True
                isClicked6 = True
                isClicked7 = True
                isClicked8 = True
                isClicked9 = True
            ElseIf b7.Text = "X" And b8.Text = "X" And b9.Text = "X" Then
                b7.BackColor = Color.Red
                b8.BackColor = Color.Red
                b9.BackColor = Color.Red
                MessageBox.Show(player_1 + " wins!", "WINNER", System.Windows.Forms.MessageBoxButtons.OKCancel, MessageBoxIcon.Information)
                xResult += 1
                lNumx.Text = xResult.ToString()
                b7.BackColor = Color.FromKnownColor(KnownColor.Control)
                b7.UseVisualStyleBackColor = True
                b8.BackColor = Color.FromKnownColor(KnownColor.Control)
                b8.UseVisualStyleBackColor = True
                b9.BackColor = Color.FromKnownColor(KnownColor.Control)
                b9.UseVisualStyleBackColor = True
                b1.Text = ""
                b2.Text = ""
                b3.Text = ""
                b4.Text = ""
                b5.Text = ""
                b6.Text = ""
                b7.Text = ""
                b8.Text = ""
                b9.Text = ""
                isClicked1 = True
                isClicked2 = True
                isClicked3 = True
                isClicked4 = True
                isClicked5 = True
                isClicked6 = True
                isClicked7 = True
                isClicked8 = True
                isClicked9 = True
            ElseIf b7.Text = "O" And b8.Text = "O" And b9.Text = "O" Then
                b7.BackColor = Color.Red
                b8.BackColor = Color.Red
                b9.BackColor = Color.Red
                MessageBox.Show(player_2 + " wins!", "WINNER", System.Windows.Forms.MessageBoxButtons.OKCancel, MessageBoxIcon.Information)
                oResult += 1
                lNumo.Text = oResult.ToString()
                b7.BackColor = Color.FromKnownColor(KnownColor.Control)
                b7.UseVisualStyleBackColor = True
                b8.BackColor = Color.FromKnownColor(KnownColor.Control)
                b8.UseVisualStyleBackColor = True
                b9.BackColor = Color.FromKnownColor(KnownColor.Control)
                b9.UseVisualStyleBackColor = True
                b1.Text = ""
                b2.Text = ""
                b3.Text = ""
                b4.Text = ""
                b5.Text = ""
                b6.Text = ""
                b7.Text = ""
                b8.Text = ""
                b9.Text = ""
                isClicked1 = True
                isClicked2 = True
                isClicked3 = True
                isClicked4 = True
                isClicked5 = True
                isClicked6 = True
                isClicked7 = True
                isClicked8 = True
                isClicked9 = True

            ElseIf b1.Text = "X" And b4.Text = "X" And b7.Text = "X" Then
                b1.BackColor = Color.Red
                b4.BackColor = Color.Red
                b7.BackColor = Color.Red
                MessageBox.Show(player_1 + " wins!", "WINNER", System.Windows.Forms.MessageBoxButtons.OKCancel, MessageBoxIcon.Information)
                xResult += 1
                lNumx.Text = xResult.ToString()
                b1.BackColor = Color.FromKnownColor(KnownColor.Control)
                b1.UseVisualStyleBackColor = True
                b4.BackColor = Color.FromKnownColor(KnownColor.Control)
                b4.UseVisualStyleBackColor = True
                b7.BackColor = Color.FromKnownColor(KnownColor.Control)
                b7.UseVisualStyleBackColor = True
                b1.Text = ""
                b2.Text = ""
                b3.Text = ""
                b4.Text = ""
                b5.Text = ""
                b6.Text = ""
                b7.Text = ""
                b8.Text = ""
                b9.Text = ""
                isClicked1 = True
                isClicked2 = True
                isClicked3 = True
                isClicked4 = True
                isClicked5 = True
                isClicked6 = True
                isClicked7 = True
                isClicked8 = True
                isClicked9 = True

            ElseIf b1.Text = "O" And b4.Text = "O" And b7.Text = "O" Then
                b1.BackColor = Color.Red
                b4.BackColor = Color.Red
                b7.BackColor = Color.Red
                MessageBox.Show(player_2 + " wins!", "WINNER", System.Windows.Forms.MessageBoxButtons.OKCancel, MessageBoxIcon.Information)
                oResult += 1
                lNumo.Text = oResult.ToString()
                b1.BackColor = Color.FromKnownColor(KnownColor.Control)
                b1.UseVisualStyleBackColor = True
                b4.BackColor = Color.FromKnownColor(KnownColor.Control)
                b4.UseVisualStyleBackColor = True
                b7.BackColor = Color.FromKnownColor(KnownColor.Control)
                b7.UseVisualStyleBackColor = True
                b1.Text = ""
                b2.Text = ""
                b3.Text = ""
                b4.Text = ""
                b5.Text = ""
                b6.Text = ""
                b7.Text = ""
                b8.Text = ""
                b9.Text = ""
                isClicked1 = True
                isClicked2 = True
                isClicked3 = True
                isClicked4 = True
                isClicked5 = True
                isClicked6 = True
                isClicked7 = True
                isClicked8 = True
                isClicked9 = True

            ElseIf b2.Text = "X" And b5.Text = "X" And b8.Text = "X" Then
                b2.BackColor = Color.Red
                b5.BackColor = Color.Red
                b8.BackColor = Color.Red
                MessageBox.Show(player_1 + " wins!", "WINNER", System.Windows.Forms.MessageBoxButtons.OKCancel, MessageBoxIcon.Information)
                xResult += 1
                lNumx.Text = xResult.ToString()
                b2.BackColor = Color.FromKnownColor(KnownColor.Control)
                b2.UseVisualStyleBackColor = True
                b5.BackColor = Color.FromKnownColor(KnownColor.Control)
                b5.UseVisualStyleBackColor = True
                b8.BackColor = Color.FromKnownColor(KnownColor.Control)
                b8.UseVisualStyleBackColor = True
                b1.Text = ""
                b2.Text = ""
                b3.Text = ""
                b4.Text = ""
                b5.Text = ""
                b6.Text = ""
                b7.Text = ""
                b8.Text = ""
                b9.Text = ""
                isClicked1 = True
                isClicked2 = True
                isClicked3 = True
                isClicked4 = True
                isClicked5 = True
                isClicked6 = True
                isClicked7 = True
                isClicked8 = True
                isClicked9 = True

            ElseIf b2.Text = "O" And b5.Text = "O" And b8.Text = "O" Then
                b2.BackColor = Color.Red
                b5.BackColor = Color.Red
                b8.BackColor = Color.Red
                MessageBox.Show(player_2 + " wins!", "WINNER", System.Windows.Forms.MessageBoxButtons.OKCancel, MessageBoxIcon.Information)
                oResult += 1
                lNumo.Text = oResult.ToString()
                b2.BackColor = Color.FromKnownColor(KnownColor.Control)
                b2.UseVisualStyleBackColor = True
                b5.BackColor = Color.FromKnownColor(KnownColor.Control)
                b5.UseVisualStyleBackColor = True
                b8.BackColor = Color.FromKnownColor(KnownColor.Control)
                b8.UseVisualStyleBackColor = True
                b1.Text = ""
                b2.Text = ""
                b3.Text = ""
                b4.Text = ""
                b5.Text = ""
                b6.Text = ""
                b7.Text = ""
                b8.Text = ""
                b9.Text = ""
                isClicked1 = True
                isClicked2 = True
                isClicked3 = True
                isClicked4 = True
                isClicked5 = True
                isClicked6 = True
                isClicked7 = True
                isClicked8 = True
                isClicked9 = True

            ElseIf b3.Text = "X" And b6.Text = "X" And b9.Text = "X" Then
                b3.BackColor = Color.Red
                b6.BackColor = Color.Red
                b9.BackColor = Color.Red
                MessageBox.Show(player_1 + " wins!", "WINNER", System.Windows.Forms.MessageBoxButtons.OKCancel, MessageBoxIcon.Information)
                xResult += 1
                lNumx.Text = xResult.ToString()
                b3.BackColor = Color.FromKnownColor(KnownColor.Control)
                b3.UseVisualStyleBackColor = True
                b6.BackColor = Color.FromKnownColor(KnownColor.Control)
                b6.UseVisualStyleBackColor = True
                b9.BackColor = Color.FromKnownColor(KnownColor.Control)
                b9.UseVisualStyleBackColor = True
                b1.Text = ""
                b2.Text = ""
                b3.Text = ""
                b4.Text = ""
                b5.Text = ""
                b6.Text = ""
                b7.Text = ""
                b8.Text = ""
                b9.Text = ""
                isClicked1 = True
                isClicked2 = True
                isClicked3 = True
                isClicked4 = True
                isClicked5 = True
                isClicked6 = True
                isClicked7 = True
                isClicked8 = True
                isClicked9 = True

            ElseIf b3.Text = "O" And b6.Text = "O" And b9.Text = "O" Then
                b3.BackColor = Color.Red
                b6.BackColor = Color.Red
                b9.BackColor = Color.Red
                MessageBox.Show(player_2 + " wins!", "WINNER", System.Windows.Forms.MessageBoxButtons.OKCancel, MessageBoxIcon.Information)
                oResult += 1
                lNumo.Text = oResult.ToString()
                b3.BackColor = Color.FromKnownColor(KnownColor.Control)
                b3.UseVisualStyleBackColor = True
                b6.BackColor = Color.FromKnownColor(KnownColor.Control)
                b6.UseVisualStyleBackColor = True
                b9.BackColor = Color.FromKnownColor(KnownColor.Control)
                b9.UseVisualStyleBackColor = True
                b1.Text = ""
                b2.Text = ""
                b3.Text = ""
                b4.Text = ""
                b5.Text = ""
                b6.Text = ""
                b7.Text = ""
                b8.Text = ""
                b9.Text = ""
                isClicked1 = True
                isClicked2 = True
                isClicked3 = True
                isClicked4 = True
                isClicked5 = True
                isClicked6 = True
                isClicked7 = True
                isClicked8 = True
                isClicked9 = True

            ElseIf b1.Text = "X" And b5.Text = "X" And b9.Text = "X" Then
                b1.BackColor = Color.Red
                b5.BackColor = Color.Red
                b9.BackColor = Color.Red
                MessageBox.Show(player_1 + " wins!", "WINNER", System.Windows.Forms.MessageBoxButtons.OKCancel, MessageBoxIcon.Information)
                xResult += 1
                lNumx.Text = xResult.ToString()
                b1.BackColor = Color.FromKnownColor(KnownColor.Control)
                b1.UseVisualStyleBackColor = True
                b5.BackColor = Color.FromKnownColor(KnownColor.Control)
                b5.UseVisualStyleBackColor = True
                b9.BackColor = Color.FromKnownColor(KnownColor.Control)
                b9.UseVisualStyleBackColor = True
                b1.Text = ""
                b2.Text = ""
                b3.Text = ""
                b4.Text = ""
                b5.Text = ""
                b6.Text = ""
                b7.Text = ""
                b8.Text = ""
                b9.Text = ""
                isClicked1 = True
                isClicked2 = True
                isClicked3 = True
                isClicked4 = True
                isClicked5 = True
                isClicked6 = True
                isClicked7 = True
                isClicked8 = True
                isClicked9 = True

            ElseIf b1.Text = "O" And b5.Text = "O" And b9.Text = "O" Then
                b1.BackColor = Color.Red
                b5.BackColor = Color.Red
                b9.BackColor = Color.Red
                MessageBox.Show(player_2 + " wins!", "WINNER", System.Windows.Forms.MessageBoxButtons.OKCancel, MessageBoxIcon.Information)
                oResult += 1
                lNumo.Text = oResult.ToString()
                b1.BackColor = Color.FromKnownColor(KnownColor.Control)
                b1.UseVisualStyleBackColor = True
                b5.BackColor = Color.FromKnownColor(KnownColor.Control)
                b5.UseVisualStyleBackColor = True
                b9.BackColor = Color.FromKnownColor(KnownColor.Control)
                b9.UseVisualStyleBackColor = True
                b1.Text = ""
                b2.Text = ""
                b3.Text = ""
                b4.Text = ""
                b5.Text = ""
                b6.Text = ""
                b7.Text = ""
                b8.Text = ""
                b9.Text = ""
                isClicked1 = True
                isClicked2 = True
                isClicked3 = True
                isClicked4 = True
                isClicked5 = True
                isClicked6 = True
                isClicked7 = True
                isClicked8 = True
                isClicked9 = True

            ElseIf b3.Text = "X" And b5.Text = "X" And b7.Text = "X" Then
                b3.BackColor = Color.Red
                b5.BackColor = Color.Red
                b7.BackColor = Color.Red
                MessageBox.Show(player_1 + " wins!", "WINNER", System.Windows.Forms.MessageBoxButtons.OKCancel, MessageBoxIcon.Information)
                xResult += 1
                lNumx.Text = xResult.ToString()
                b3.BackColor = Color.FromKnownColor(KnownColor.Control)
                b3.UseVisualStyleBackColor = True
                b5.BackColor = Color.FromKnownColor(KnownColor.Control)
                b5.UseVisualStyleBackColor = True
                b7.BackColor = Color.FromKnownColor(KnownColor.Control)
                b7.UseVisualStyleBackColor = True
                b1.Text = ""
                b2.Text = ""
                b3.Text = ""
                b4.Text = ""
                b5.Text = ""
                b6.Text = ""
                b7.Text = ""
                b8.Text = ""
                b9.Text = ""
                isClicked1 = True
                isClicked2 = True
                isClicked3 = True
                isClicked4 = True
                isClicked5 = True
                isClicked6 = True
                isClicked7 = True
                isClicked8 = True
                isClicked9 = True

            ElseIf b3.Text = "O" And b5.Text = "O" And b7.Text = "O" Then
                b3.BackColor = Color.Red
                b5.BackColor = Color.Red
                b7.BackColor = Color.Red
                MessageBox.Show(player_2 + " wins!", "WINNER", System.Windows.Forms.MessageBoxButtons.OKCancel, MessageBoxIcon.Information)
                oResult += 1
                lNumo.Text = oResult.ToString()
                b3.BackColor = Color.FromKnownColor(KnownColor.Control)
                b3.UseVisualStyleBackColor = True
                b5.BackColor = Color.FromKnownColor(KnownColor.Control)
                b5.UseVisualStyleBackColor = True
                b7.BackColor = Color.FromKnownColor(KnownColor.Control)
                b7.UseVisualStyleBackColor = True
                b1.Text = ""
                b2.Text = ""
                b3.Text = ""
                b4.Text = ""
                b5.Text = ""
                b6.Text = ""
                b7.Text = ""
                b8.Text = ""
                b9.Text = ""
                isClicked1 = True
                isClicked2 = True
                isClicked3 = True
                isClicked4 = True
                isClicked5 = True
                isClicked6 = True
                isClicked7 = True
                isClicked8 = True
                isClicked9 = True

            ElseIf (b1.Text = "O" Or b1.Text = "X") And (b2.Text = "O" Or b2.Text = "X") And (b3.Text = "O" Or b3.Text = "X") And (b4.Text = "O" Or b4.Text = "X") And (b5.Text = "O" Or b5.Text = "X") And (b6.Text = "O" Or b6.Text = "X") And (b7.Text = "O" Or b7.Text = "X") And (b8.Text = "O" Or b8.Text = "X") And (b9.Text = "O" Or b9.Text = "X") Then
                MessageBox.Show("Draw !!!", "WINNER", System.Windows.Forms.MessageBoxButtons.OKCancel, MessageBoxIcon.Information)
                b1.Text = ""
                b2.Text = ""
                b3.Text = ""
                b4.Text = ""
                b5.Text = ""
                b6.Text = ""
                b7.Text = ""
                b8.Text = ""
                b9.Text = ""
                isClicked1 = True
                isClicked2 = True
                isClicked3 = True
                isClicked4 = True
                isClicked5 = True
                isClicked6 = True
                isClicked7 = True
                isClicked8 = True
                isClicked9 = True
            End If


        End If
    End Sub

    Private Sub b9_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles b9.Click
        If isClicked9 Then
            If isX Then
                b9.Text = "X"
                isX = False

            Else : b9.Text = "O"
                isX = True
            End If
            isClicked9 = False
            If b1.Text = "X" And b2.Text = "X" And b3.Text = "X" Then
                b1.BackColor = Color.Red
                b2.BackColor = Color.Red
                b3.BackColor = Color.Red
                MessageBox.Show(player_1 + " wins!", "WINNER", System.Windows.Forms.MessageBoxButtons.OKCancel, MessageBoxIcon.Information)
                xResult += 1
                lNumx.Text = xResult.ToString()
                b1.BackColor = Color.FromKnownColor(KnownColor.Control)
                b1.UseVisualStyleBackColor = True
                b2.BackColor = Color.FromKnownColor(KnownColor.Control)
                b2.UseVisualStyleBackColor = True
                b3.BackColor = Color.FromKnownColor(KnownColor.Control)
                b3.UseVisualStyleBackColor = True
                b1.Text = ""
                b2.Text = ""
                b3.Text = ""
                b4.Text = ""
                b5.Text = ""
                b6.Text = ""
                b7.Text = ""
                b8.Text = ""
                b9.Text = ""
                isClicked1 = True
                isClicked2 = True
                isClicked3 = True
                isClicked4 = True
                isClicked5 = True
                isClicked6 = True
                isClicked7 = True
                isClicked8 = True
                isClicked9 = True

            ElseIf b1.Text = "O" And b2.Text = "O" And b3.Text = "O" Then
                b1.BackColor = Color.Red
                b2.BackColor = Color.Red
                b3.BackColor = Color.Red
                MessageBox.Show(player_2 + " wins!", "WINNER", System.Windows.Forms.MessageBoxButtons.OKCancel, MessageBoxIcon.Information)
                oResult += 1
                lNumo.Text = oResult.ToString()
                b1.BackColor = Color.FromKnownColor(KnownColor.Control)
                b1.UseVisualStyleBackColor = True
                b2.BackColor = Color.FromKnownColor(KnownColor.Control)
                b2.UseVisualStyleBackColor = True
                b3.BackColor = Color.FromKnownColor(KnownColor.Control)
                b3.UseVisualStyleBackColor = True
                b1.Text = ""
                b2.Text = ""
                b3.Text = ""
                b4.Text = ""
                b5.Text = ""
                b6.Text = ""
                b7.Text = ""
                b8.Text = ""
                b9.Text = ""
                isClicked1 = True
                isClicked2 = True
                isClicked3 = True
                isClicked4 = True
                isClicked5 = True
                isClicked6 = True
                isClicked7 = True
                isClicked8 = True
                isClicked9 = True

            ElseIf b4.Text = "X" And b5.Text = "X" And b6.Text = "X" Then
                b4.BackColor = Color.Red
                b5.BackColor = Color.Red
                b6.BackColor = Color.Red
                MessageBox.Show(player_1 + " wins!", "WINNER", System.Windows.Forms.MessageBoxButtons.OKCancel, MessageBoxIcon.Information)
                xResult += 1
                lNumx.Text = xResult.ToString()
                b4.BackColor = Color.FromKnownColor(KnownColor.Control)
                b4.UseVisualStyleBackColor = True
                b5.BackColor = Color.FromKnownColor(KnownColor.Control)
                b5.UseVisualStyleBackColor = True
                b6.BackColor = Color.FromKnownColor(KnownColor.Control)
                b6.UseVisualStyleBackColor = True
                b1.Text = ""
                b2.Text = ""
                b3.Text = ""
                b4.Text = ""
                b5.Text = ""
                b6.Text = ""
                b7.Text = ""
                b8.Text = ""
                b9.Text = ""
                isClicked1 = True
                isClicked2 = True
                isClicked3 = True
                isClicked4 = True
                isClicked5 = True
                isClicked6 = True
                isClicked7 = True
                isClicked8 = True
                isClicked9 = True
            ElseIf b4.Text = "O" And b5.Text = "O" And b6.Text = "O" Then
                b4.BackColor = Color.Red
                b5.BackColor = Color.Red
                b6.BackColor = Color.Red
                MessageBox.Show(player_2 + " wins!", "WINNER", System.Windows.Forms.MessageBoxButtons.OKCancel, MessageBoxIcon.Information)
                oResult += 1
                lNumo.Text = oResult.ToString()
                b4.BackColor = Color.FromKnownColor(KnownColor.Control)
                b4.UseVisualStyleBackColor = True
                b5.BackColor = Color.FromKnownColor(KnownColor.Control)
                b5.UseVisualStyleBackColor = True
                b6.BackColor = Color.FromKnownColor(KnownColor.Control)
                b6.UseVisualStyleBackColor = True
                b1.Text = ""
                b2.Text = ""
                b3.Text = ""
                b4.Text = ""
                b5.Text = ""
                b6.Text = ""
                b7.Text = ""
                b8.Text = ""
                b9.Text = ""
                isClicked1 = True
                isClicked2 = True
                isClicked3 = True
                isClicked4 = True
                isClicked5 = True
                isClicked6 = True
                isClicked7 = True
                isClicked8 = True
                isClicked9 = True
            ElseIf b7.Text = "X" And b8.Text = "X" And b9.Text = "X" Then
                b7.BackColor = Color.Red
                b8.BackColor = Color.Red
                b9.BackColor = Color.Red
                MessageBox.Show(player_1 + " wins!", "WINNER", System.Windows.Forms.MessageBoxButtons.OKCancel, MessageBoxIcon.Information)
                xResult += 1
                lNumx.Text = xResult.ToString()
                b7.BackColor = Color.FromKnownColor(KnownColor.Control)
                b7.UseVisualStyleBackColor = True
                b8.BackColor = Color.FromKnownColor(KnownColor.Control)
                b8.UseVisualStyleBackColor = True
                b9.BackColor = Color.FromKnownColor(KnownColor.Control)
                b9.UseVisualStyleBackColor = True
                b1.Text = ""
                b2.Text = ""
                b3.Text = ""
                b4.Text = ""
                b5.Text = ""
                b6.Text = ""
                b7.Text = ""
                b8.Text = ""
                b9.Text = ""
                isClicked1 = True
                isClicked2 = True
                isClicked3 = True
                isClicked4 = True
                isClicked5 = True
                isClicked6 = True
                isClicked7 = True
                isClicked8 = True
                isClicked9 = True
            ElseIf b7.Text = "O" And b8.Text = "O" And b9.Text = "O" Then
                b7.BackColor = Color.Red
                b8.BackColor = Color.Red
                b9.BackColor = Color.Red
                MessageBox.Show(player_2 + " wins!", "WINNER", System.Windows.Forms.MessageBoxButtons.OKCancel, MessageBoxIcon.Information)
                oResult += 1
                lNumo.Text = oResult.ToString()
                b7.BackColor = Color.FromKnownColor(KnownColor.Control)
                b7.UseVisualStyleBackColor = True
                b8.BackColor = Color.FromKnownColor(KnownColor.Control)
                b8.UseVisualStyleBackColor = True
                b9.BackColor = Color.FromKnownColor(KnownColor.Control)
                b9.UseVisualStyleBackColor = True
                b1.Text = ""
                b2.Text = ""
                b3.Text = ""
                b4.Text = ""
                b5.Text = ""
                b6.Text = ""
                b7.Text = ""
                b8.Text = ""
                b9.Text = ""
                isClicked1 = True
                isClicked2 = True
                isClicked3 = True
                isClicked4 = True
                isClicked5 = True
                isClicked6 = True
                isClicked7 = True
                isClicked8 = True
                isClicked9 = True

            ElseIf b1.Text = "X" And b4.Text = "X" And b7.Text = "X" Then
                b1.BackColor = Color.Red
                b4.BackColor = Color.Red
                b7.BackColor = Color.Red
                MessageBox.Show(player_1 + " wins!", "WINNER", System.Windows.Forms.MessageBoxButtons.OKCancel, MessageBoxIcon.Information)
                xResult += 1
                lNumx.Text = xResult.ToString()
                b1.BackColor = Color.FromKnownColor(KnownColor.Control)
                b1.UseVisualStyleBackColor = True
                b4.BackColor = Color.FromKnownColor(KnownColor.Control)
                b4.UseVisualStyleBackColor = True
                b7.BackColor = Color.FromKnownColor(KnownColor.Control)
                b7.UseVisualStyleBackColor = True
                b1.Text = ""
                b2.Text = ""
                b3.Text = ""
                b4.Text = ""
                b5.Text = ""
                b6.Text = ""
                b7.Text = ""
                b8.Text = ""
                b9.Text = ""
                isClicked1 = True
                isClicked2 = True
                isClicked3 = True
                isClicked4 = True
                isClicked5 = True
                isClicked6 = True
                isClicked7 = True
                isClicked8 = True
                isClicked9 = True

            ElseIf b1.Text = "O" And b4.Text = "O" And b7.Text = "O" Then
                b1.BackColor = Color.Red
                b4.BackColor = Color.Red
                b7.BackColor = Color.Red
                MessageBox.Show(player_2 + " wins!", "WINNER", System.Windows.Forms.MessageBoxButtons.OKCancel, MessageBoxIcon.Information)
                oResult += 1
                lNumo.Text = oResult.ToString()
                b1.BackColor = Color.FromKnownColor(KnownColor.Control)
                b1.UseVisualStyleBackColor = True
                b4.BackColor = Color.FromKnownColor(KnownColor.Control)
                b4.UseVisualStyleBackColor = True
                b7.BackColor = Color.FromKnownColor(KnownColor.Control)
                b7.UseVisualStyleBackColor = True
                b1.Text = ""
                b2.Text = ""
                b3.Text = ""
                b4.Text = ""
                b5.Text = ""
                b6.Text = ""
                b7.Text = ""
                b8.Text = ""
                b9.Text = ""
                isClicked1 = True
                isClicked2 = True
                isClicked3 = True
                isClicked4 = True
                isClicked5 = True
                isClicked6 = True
                isClicked7 = True
                isClicked8 = True
                isClicked9 = True

            ElseIf b2.Text = "X" And b5.Text = "X" And b8.Text = "X" Then
                b2.BackColor = Color.Red
                b5.BackColor = Color.Red
                b8.BackColor = Color.Red
                MessageBox.Show(player_1 + " wins!", "WINNER", System.Windows.Forms.MessageBoxButtons.OKCancel, MessageBoxIcon.Information)
                xResult += 1
                lNumx.Text = xResult.ToString()
                b2.BackColor = Color.FromKnownColor(KnownColor.Control)
                b2.UseVisualStyleBackColor = True
                b5.BackColor = Color.FromKnownColor(KnownColor.Control)
                b5.UseVisualStyleBackColor = True
                b8.BackColor = Color.FromKnownColor(KnownColor.Control)
                b8.UseVisualStyleBackColor = True
                b1.Text = ""
                b2.Text = ""
                b3.Text = ""
                b4.Text = ""
                b5.Text = ""
                b6.Text = ""
                b7.Text = ""
                b8.Text = ""
                b9.Text = ""
                isClicked1 = True
                isClicked2 = True
                isClicked3 = True
                isClicked4 = True
                isClicked5 = True
                isClicked6 = True
                isClicked7 = True
                isClicked8 = True
                isClicked9 = True

            ElseIf b2.Text = "O" And b5.Text = "O" And b8.Text = "O" Then
                b2.BackColor = Color.Red
                b5.BackColor = Color.Red
                b8.BackColor = Color.Red
                MessageBox.Show(player_2 + " wins!", "WINNER", System.Windows.Forms.MessageBoxButtons.OKCancel, MessageBoxIcon.Information)
                oResult += 1
                lNumo.Text = oResult.ToString()
                b2.BackColor = Color.FromKnownColor(KnownColor.Control)
                b2.UseVisualStyleBackColor = True
                b5.BackColor = Color.FromKnownColor(KnownColor.Control)
                b5.UseVisualStyleBackColor = True
                b8.BackColor = Color.FromKnownColor(KnownColor.Control)
                b8.UseVisualStyleBackColor = True
                b1.Text = ""
                b2.Text = ""
                b3.Text = ""
                b4.Text = ""
                b5.Text = ""
                b6.Text = ""
                b7.Text = ""
                b8.Text = ""
                b9.Text = ""
                isClicked1 = True
                isClicked2 = True
                isClicked3 = True
                isClicked4 = True
                isClicked5 = True
                isClicked6 = True
                isClicked7 = True
                isClicked8 = True
                isClicked9 = True

            ElseIf b3.Text = "X" And b6.Text = "X" And b9.Text = "X" Then
                b3.BackColor = Color.Red
                b6.BackColor = Color.Red
                b9.BackColor = Color.Red
                MessageBox.Show(player_1 + " wins!", "WINNER", System.Windows.Forms.MessageBoxButtons.OKCancel, MessageBoxIcon.Information)
                xResult += 1
                lNumx.Text = xResult.ToString()
                b3.BackColor = Color.FromKnownColor(KnownColor.Control)
                b3.UseVisualStyleBackColor = True
                b6.BackColor = Color.FromKnownColor(KnownColor.Control)
                b6.UseVisualStyleBackColor = True
                b9.BackColor = Color.FromKnownColor(KnownColor.Control)
                b9.UseVisualStyleBackColor = True
                b1.Text = ""
                b2.Text = ""
                b3.Text = ""
                b4.Text = ""
                b5.Text = ""
                b6.Text = ""
                b7.Text = ""
                b8.Text = ""
                b9.Text = ""
                isClicked1 = True
                isClicked2 = True
                isClicked3 = True
                isClicked4 = True
                isClicked5 = True
                isClicked6 = True
                isClicked7 = True
                isClicked8 = True
                isClicked9 = True

            ElseIf b3.Text = "O" And b6.Text = "O" And b9.Text = "O" Then
                b3.BackColor = Color.Red
                b6.BackColor = Color.Red
                b9.BackColor = Color.Red
                MessageBox.Show(player_2 + " wins!", "WINNER", System.Windows.Forms.MessageBoxButtons.OKCancel, MessageBoxIcon.Information)
                oResult += 1
                lNumo.Text = oResult.ToString()
                b3.BackColor = Color.FromKnownColor(KnownColor.Control)
                b3.UseVisualStyleBackColor = True
                b6.BackColor = Color.FromKnownColor(KnownColor.Control)
                b6.UseVisualStyleBackColor = True
                b9.BackColor = Color.FromKnownColor(KnownColor.Control)
                b9.UseVisualStyleBackColor = True
                b1.Text = ""
                b2.Text = ""
                b3.Text = ""
                b4.Text = ""
                b5.Text = ""
                b6.Text = ""
                b7.Text = ""
                b8.Text = ""
                b9.Text = ""
                isClicked1 = True
                isClicked2 = True
                isClicked3 = True
                isClicked4 = True
                isClicked5 = True
                isClicked6 = True
                isClicked7 = True
                isClicked8 = True
                isClicked9 = True

            ElseIf b1.Text = "X" And b5.Text = "X" And b9.Text = "X" Then
                b1.BackColor = Color.Red
                b5.BackColor = Color.Red
                b9.BackColor = Color.Red
                MessageBox.Show(player_1 + " wins!", "WINNER", System.Windows.Forms.MessageBoxButtons.OKCancel, MessageBoxIcon.Information)
                xResult += 1
                lNumx.Text = xResult.ToString()
                b1.BackColor = Color.FromKnownColor(KnownColor.Control)
                b1.UseVisualStyleBackColor = True
                b5.BackColor = Color.FromKnownColor(KnownColor.Control)
                b5.UseVisualStyleBackColor = True
                b9.BackColor = Color.FromKnownColor(KnownColor.Control)
                b9.UseVisualStyleBackColor = True
                b1.Text = ""
                b2.Text = ""
                b3.Text = ""
                b4.Text = ""
                b5.Text = ""
                b6.Text = ""
                b7.Text = ""
                b8.Text = ""
                b9.Text = ""
                isClicked1 = True
                isClicked2 = True
                isClicked3 = True
                isClicked4 = True
                isClicked5 = True
                isClicked6 = True
                isClicked7 = True
                isClicked8 = True
                isClicked9 = True

            ElseIf b1.Text = "O" And b5.Text = "O" And b9.Text = "O" Then
                b1.BackColor = Color.Red
                b5.BackColor = Color.Red
                b9.BackColor = Color.Red
                MessageBox.Show(player_2 + " wins!", "WINNER", System.Windows.Forms.MessageBoxButtons.OKCancel, MessageBoxIcon.Information)
                oResult += 1
                lNumo.Text = oResult.ToString()
                b1.BackColor = Color.FromKnownColor(KnownColor.Control)
                b1.UseVisualStyleBackColor = True
                b5.BackColor = Color.FromKnownColor(KnownColor.Control)
                b5.UseVisualStyleBackColor = True
                b9.BackColor = Color.FromKnownColor(KnownColor.Control)
                b9.UseVisualStyleBackColor = True
                b1.Text = ""
                b2.Text = ""
                b3.Text = ""
                b4.Text = ""
                b5.Text = ""
                b6.Text = ""
                b7.Text = ""
                b8.Text = ""
                b9.Text = ""
                isClicked1 = True
                isClicked2 = True
                isClicked3 = True
                isClicked4 = True
                isClicked5 = True
                isClicked6 = True
                isClicked7 = True
                isClicked8 = True
                isClicked9 = True

            ElseIf b3.Text = "X" And b5.Text = "X" And b7.Text = "X" Then
                b3.BackColor = Color.Red
                b5.BackColor = Color.Red
                b7.BackColor = Color.Red
                MessageBox.Show(player_1 + " wins!", "WINNER", System.Windows.Forms.MessageBoxButtons.OKCancel, MessageBoxIcon.Information)
                xResult += 1
                lNumx.Text = xResult.ToString()
                b3.BackColor = Color.FromKnownColor(KnownColor.Control)
                b3.UseVisualStyleBackColor = True
                b5.BackColor = Color.FromKnownColor(KnownColor.Control)
                b5.UseVisualStyleBackColor = True
                b7.BackColor = Color.FromKnownColor(KnownColor.Control)
                b7.UseVisualStyleBackColor = True
                b1.Text = ""
                b2.Text = ""
                b3.Text = ""
                b4.Text = ""
                b5.Text = ""
                b6.Text = ""
                b7.Text = ""
                b8.Text = ""
                b9.Text = ""
                isClicked1 = True
                isClicked2 = True
                isClicked3 = True
                isClicked4 = True
                isClicked5 = True
                isClicked6 = True
                isClicked7 = True
                isClicked8 = True
                isClicked9 = True

            ElseIf b3.Text = "O" And b5.Text = "O" And b7.Text = "O" Then
                b3.BackColor = Color.Red
                b5.BackColor = Color.Red
                b7.BackColor = Color.Red
                MessageBox.Show(player_2 + " wins!", "WINNER", System.Windows.Forms.MessageBoxButtons.OKCancel, MessageBoxIcon.Information)
                oResult += 1
                lNumo.Text = oResult.ToString()
                b3.BackColor = Color.FromKnownColor(KnownColor.Control)
                b3.UseVisualStyleBackColor = True
                b5.BackColor = Color.FromKnownColor(KnownColor.Control)
                b5.UseVisualStyleBackColor = True
                b7.BackColor = Color.FromKnownColor(KnownColor.Control)
                b7.UseVisualStyleBackColor = True
                b1.Text = ""
                b2.Text = ""
                b3.Text = ""
                b4.Text = ""
                b5.Text = ""
                b6.Text = ""
                b7.Text = ""
                b8.Text = ""
                b9.Text = ""
                isClicked1 = True
                isClicked2 = True
                isClicked3 = True
                isClicked4 = True
                isClicked5 = True
                isClicked6 = True
                isClicked7 = True
                isClicked8 = True
                isClicked9 = True

            ElseIf (b1.Text = "O" Or b1.Text = "X") And (b2.Text = "O" Or b2.Text = "X") And (b3.Text = "O" Or b3.Text = "X") And (b4.Text = "O" Or b4.Text = "X") And (b5.Text = "O" Or b5.Text = "X") And (b6.Text = "O" Or b6.Text = "X") And (b7.Text = "O" Or b7.Text = "X") And (b8.Text = "O" Or b8.Text = "X") And (b9.Text = "O" Or b9.Text = "X") Then
                MessageBox.Show("Draw !!!", "WINNER", System.Windows.Forms.MessageBoxButtons.OKCancel, MessageBoxIcon.Information)
                b1.Text = ""
                b2.Text = ""
                b3.Text = ""
                b4.Text = ""
                b5.Text = ""
                b6.Text = ""
                b7.Text = ""
                b8.Text = ""
                b9.Text = ""
                isClicked1 = True
                isClicked2 = True
                isClicked3 = True
                isClicked4 = True
                isClicked5 = True
                isClicked6 = True
                isClicked7 = True
                isClicked8 = True
                isClicked9 = True
            End If

        End If
    End Sub

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        lXwins.Text = player_1 + " wins"
        lOwins.Text = player_2 + " wins"
        lXwins.Left = lNumx.Left - lXwins.Width - 2

    End Sub


    Private Sub Form1_FormClosing(ByVal sender As System.Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles MyBase.FormClosing
        Application.Exit()
    End Sub
End Class
