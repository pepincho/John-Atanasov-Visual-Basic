Public Class Form4
    Dim xResult As Integer = 0
    Dim oResult As Integer = 0
    Dim isClicked() As Boolean = {True, True, True, True, True, True, True, True, True}


    Function check_win()
        If b1.Text = "X" And b2.Text = "X" And b3.Text = "X" Then
            b1.BackColor = Color.Red
            b2.BackColor = Color.Red
            b3.BackColor = Color.Red
            MessageBox.Show("Human wins!", "WINNER", System.Windows.Forms.MessageBoxButtons.OKCancel, MessageBoxIcon.Information)
            xResult += 1
            l_num_x.Text = xResult.ToString()
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
            For i As Integer = 0 To 8
                isClicked(i) = True
            Next

        ElseIf b1.Text = "O" And b2.Text = "O" And b3.Text = "O" Then
            b1.BackColor = Color.Red
            b2.BackColor = Color.Red
            b3.BackColor = Color.Red
            MessageBox.Show("Computer wins!", "WINNER", System.Windows.Forms.MessageBoxButtons.OKCancel, MessageBoxIcon.Information)
            oResult += 1
            l_num_o.Text = oResult.ToString()
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
            For i As Integer = 0 To 8
                isClicked(i) = True
            Next

        ElseIf b4.Text = "X" And b5.Text = "X" And b6.Text = "X" Then
            b4.BackColor = Color.Red
            b5.BackColor = Color.Red
            b6.BackColor = Color.Red
            MessageBox.Show("Human wins!", "WINNER", System.Windows.Forms.MessageBoxButtons.OKCancel, MessageBoxIcon.Information)
            xResult += 1
            l_num_x.Text = xResult.ToString()
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
            For i As Integer = 0 To 8
                isClicked(i) = True
            Next
        ElseIf b4.Text = "O" And b5.Text = "O" And b6.Text = "O" Then
            b4.BackColor = Color.Red
            b5.BackColor = Color.Red
            b6.BackColor = Color.Red
            MessageBox.Show("Computer wins!", "WINNER", System.Windows.Forms.MessageBoxButtons.OKCancel, MessageBoxIcon.Information)
            oResult += 1
            l_num_o.Text = oResult.ToString()
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
            For i As Integer = 0 To 8
                isClicked(i) = True
            Next
        ElseIf b7.Text = "X" And b8.Text = "X" And b9.Text = "X" Then
            b7.BackColor = Color.Red
            b8.BackColor = Color.Red
            b9.BackColor = Color.Red
            MessageBox.Show("Human wins!", "WINNER", System.Windows.Forms.MessageBoxButtons.OKCancel, MessageBoxIcon.Information)
            xResult += 1
            l_num_x.Text = xResult.ToString()
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
            For i As Integer = 0 To 8
                isClicked(i) = True
            Next
        ElseIf b7.Text = "O" And b8.Text = "O" And b9.Text = "O" Then
            b7.BackColor = Color.Red
            b8.BackColor = Color.Red
            b9.BackColor = Color.Red
            MessageBox.Show("Computer wins!", "WINNER", System.Windows.Forms.MessageBoxButtons.OKCancel, MessageBoxIcon.Information)
            oResult += 1
            l_num_o.Text = oResult.ToString()
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
            For i As Integer = 0 To 8
                isClicked(i) = True
            Next

        ElseIf b1.Text = "X" And b4.Text = "X" And b7.Text = "X" Then
            b1.BackColor = Color.Red
            b4.BackColor = Color.Red
            b7.BackColor = Color.Red
            MessageBox.Show("Human wins!", "WINNER", System.Windows.Forms.MessageBoxButtons.OKCancel, MessageBoxIcon.Information)
            xResult += 1
            l_num_x.Text = xResult.ToString()
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
            For i As Integer = 0 To 8
                isClicked(i) = True
            Next

        ElseIf b1.Text = "O" And b4.Text = "O" And b7.Text = "O" Then
            b1.BackColor = Color.Red
            b4.BackColor = Color.Red
            b7.BackColor = Color.Red
            MessageBox.Show("Computer wins!", "WINNER", System.Windows.Forms.MessageBoxButtons.OKCancel, MessageBoxIcon.Information)
            oResult += 1
            l_num_o.Text = oResult.ToString()
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
            For i As Integer = 0 To 8
                isClicked(i) = True
            Next

        ElseIf b2.Text = "X" And b5.Text = "X" And b8.Text = "X" Then
            b2.BackColor = Color.Red
            b5.BackColor = Color.Red
            b8.BackColor = Color.Red
            MessageBox.Show("Human wins!", "WINNER", System.Windows.Forms.MessageBoxButtons.OKCancel, MessageBoxIcon.Information)
            xResult += 1
            l_num_x.Text = xResult.ToString()
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
            For i As Integer = 0 To 8
                isClicked(i) = True
            Next

        ElseIf b2.Text = "O" And b5.Text = "O" And b8.Text = "O" Then
            b2.BackColor = Color.Red
            b5.BackColor = Color.Red
            b8.BackColor = Color.Red
            MessageBox.Show("Computer wins!", "WINNER", System.Windows.Forms.MessageBoxButtons.OKCancel, MessageBoxIcon.Information)
            oResult += 1
            l_num_o.Text = oResult.ToString()
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
            For i As Integer = 0 To 8
                isClicked(i) = True
            Next

        ElseIf b3.Text = "X" And b6.Text = "X" And b9.Text = "X" Then
            b3.BackColor = Color.Red
            b6.BackColor = Color.Red
            b9.BackColor = Color.Red
            MessageBox.Show("Human wins!", "WINNER", System.Windows.Forms.MessageBoxButtons.OKCancel, MessageBoxIcon.Information)
            xResult += 1
            l_num_x.Text = xResult.ToString()
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
            For i As Integer = 0 To 8
                isClicked(i) = True
            Next

        ElseIf b3.Text = "O" And b6.Text = "O" And b9.Text = "O" Then
            b3.BackColor = Color.Red
            b6.BackColor = Color.Red
            b9.BackColor = Color.Red
            MessageBox.Show("Computer wins!", "WINNER", System.Windows.Forms.MessageBoxButtons.OKCancel, MessageBoxIcon.Information)
            oResult += 1
            l_num_o.Text = oResult.ToString()
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
            For i As Integer = 0 To 8
                isClicked(i) = True
            Next

        ElseIf b1.Text = "X" And b5.Text = "X" And b9.Text = "X" Then
            b1.BackColor = Color.Red
            b5.BackColor = Color.Red
            b9.BackColor = Color.Red
            MessageBox.Show("Human wins!", "WINNER", System.Windows.Forms.MessageBoxButtons.OKCancel, MessageBoxIcon.Information)
            xResult += 1
            l_num_x.Text = xResult.ToString()
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
            For i As Integer = 0 To 8
                isClicked(i) = True
            Next

        ElseIf b1.Text = "O" And b5.Text = "O" And b9.Text = "O" Then
            b1.BackColor = Color.Red
            b5.BackColor = Color.Red
            b9.BackColor = Color.Red
            MessageBox.Show("Computer wins!", "WINNER", System.Windows.Forms.MessageBoxButtons.OKCancel, MessageBoxIcon.Information)
            oResult += 1
            l_num_o.Text = oResult.ToString()
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
            For i As Integer = 0 To 8
                isClicked(i) = True
            Next

        ElseIf b3.Text = "X" And b5.Text = "X" And b7.Text = "X" Then
            b3.BackColor = Color.Red
            b5.BackColor = Color.Red
            b7.BackColor = Color.Red
            MessageBox.Show("Human wins!", "WINNER", System.Windows.Forms.MessageBoxButtons.OKCancel, MessageBoxIcon.Information)
            xResult += 1
            l_num_x.Text = xResult.ToString()
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
            For i As Integer = 0 To 8
                isClicked(i) = True
            Next

        ElseIf b3.Text = "O" And b5.Text = "O" And b7.Text = "O" Then
            b3.BackColor = Color.Red
            b5.BackColor = Color.Red
            b7.BackColor = Color.Red
            MessageBox.Show("Computer wins!", "WINNER", System.Windows.Forms.MessageBoxButtons.OKCancel, MessageBoxIcon.Information)
            oResult += 1
            l_num_o.Text = oResult.ToString()
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
            For i As Integer = 0 To 8
                isClicked(i) = True
            Next

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
            For i As Integer = 0 To 8
                isClicked(i) = True
            Next
        End If
    End Function

    Function comp()
        Dim comp_counter As Integer = 0
        Dim human_counter As Integer = 0
        Dim btnArray() As System.Windows.Forms.Button = {b1, b2, b3, b4, b5, b6, b7, b8, b9}

        For i As Integer = 0 To 2
            If btnArray(i).Text = "O" Then
                comp_counter += 1
            End If
        Next

        If comp_counter = 2 Then
            For i As Integer = 0 To 2
                If btnArray(i).Text = "" Then
                    btnArray(i).Text = "O"
                    isClicked(i) = False
                    check_win()
                    Return 0
                End If
            Next
        End If

        comp_counter = 0

        For i As Integer = 3 To 5
            If btnArray(i).Text = "O" Then
                comp_counter += 1
            End If
        Next

        If comp_counter = 2 Then
            For i As Integer = 3 To 5
                If btnArray(i).Text = "" Then
                    btnArray(i).Text = "O"
                    isClicked(i) = False
                    check_win()
                    Return 0
                End If
            Next
        End If


        comp_counter = 0

        For i As Integer = 6 To 8
            If btnArray(i).Text = "O" Then
                comp_counter += 1
            End If
        Next

        If comp_counter = 2 Then
            For i As Integer = 6 To 8
                If btnArray(i).Text = "" Then
                    btnArray(i).Text = "O"
                    isClicked(i) = False
                    check_win()
                    Return 0
                End If
            Next
        End If

        comp_counter = 0


        For i As Integer = 0 To 8 Step 3
            If btnArray(i).Text = "O" Then
                comp_counter += 1
            End If
        Next

        If comp_counter = 2 Then
            For i As Integer = 0 To 8 Step 3
                If btnArray(i).Text = "" Then
                    btnArray(i).Text = "O"
                    isClicked(i) = False
                    check_win()
                    Return 0
                End If
            Next
        End If

        comp_counter = 0

        For i As Integer = 1 To 8 Step 3
           If btnArray(i).Text = "O" Then
                comp_counter += 1
            End If
        Next

        If comp_counter = 2 Then
            For i As Integer = 1 To 8 Step 3
                If btnArray(i).Text = "" Then
                    btnArray(i).Text = "O"
                    isClicked(i) = False
                    check_win()
                    Return 0
                End If
            Next
        End If

        comp_counter = 0

        For i As Integer = 2 To 8 Step 3
           If btnArray(i).Text = "O" Then
                comp_counter += 1
            End If
        Next

        If comp_counter = 2 Then
            For i As Integer = 2 To 8 Step 3
                If btnArray(i).Text = "" Then
                    btnArray(i).Text = "O"
                    isClicked(i) = False
                    check_win()
                    Return 0
                End If
            Next
        End If

        comp_counter = 0


        For i As Integer = 0 To 8 Step 4
            If btnArray(i).Text = "O" Then
                comp_counter += 1
            End If
        Next

        If comp_counter = 2 Then
            For i As Integer = 0 To 8 Step 4
                If btnArray(i).Text = "" Then
                    btnArray(i).Text = "O"
                    isClicked(i) = False
                    check_win()
                    Return 0
                End If
            Next
        End If

        comp_counter = 0

        For i As Integer = 2 To 6 Step 2
           If btnArray(i).Text = "O" Then
                comp_counter += 1
            End If
        Next

        If comp_counter = 2 Then
            For i As Integer = 2 To 6 Step 2
                If btnArray(i).Text = "" Then
                    btnArray(i).Text = "O"
                    isClicked(i) = False
                    check_win()
                    Return 0
                End If
            Next
        End If


        For i As Integer = 0 To 2
            If btnArray(i).Text = "X" Then
                human_counter += 1
            End If
        Next

        If human_counter = 2 Then
            For i As Integer = 0 To 2
                If btnArray(i).Text = "" Then
                    btnArray(i).Text = "O"
                    isClicked(i) = False
                    check_win()
                    Return 0
                End If
            Next
        End If

        human_counter = 0

        For i As Integer = 3 To 5
            If btnArray(i).Text = "X" Then
                human_counter += 1
            End If
        Next

        If human_counter = 2 Then
            For i As Integer = 3 To 5
                If btnArray(i).Text = "" Then
                    btnArray(i).Text = "O"
                    isClicked(i) = False
                    check_win()
                    Return 0
                End If
            Next
        End If


        human_counter = 0

        For i As Integer = 6 To 8
            If btnArray(i).Text = "X" Then
                human_counter += 1
            End If
        Next

        If human_counter = 2 Then
            For i As Integer = 6 To 8
                If btnArray(i).Text = "" Then
                    btnArray(i).Text = "O"
                    isClicked(i) = False
                    check_win()
                    Return 0
                End If
            Next
        End If

        human_counter = 0


        For i As Integer = 0 To 8 Step 3
            If btnArray(i).Text = "X" Then
                human_counter += 1
            End If
        Next

        If human_counter = 2 Then
            For i As Integer = 0 To 8 Step 3
                If btnArray(i).Text = "" Then
                    btnArray(i).Text = "O"
                    isClicked(i) = False
                    check_win()
                    Return 0
                End If
            Next
        End If

        human_counter = 0

        For i As Integer = 1 To 8 Step 3
            If btnArray(i).Text = "X" Then
                human_counter += 1
            End If
        Next

        If human_counter = 2 Then
            For i As Integer = 1 To 8 Step 3
                If btnArray(i).Text = "" Then
                    btnArray(i).Text = "O"
                    isClicked(i) = False
                    check_win()
                    Return 0
                End If
            Next
        End If

        human_counter = 0

        For i As Integer = 2 To 8 Step 3
            If btnArray(i).Text = "X" Then
                human_counter += 1
            End If
        Next

        If human_counter = 2 Then
            For i As Integer = 2 To 8 Step 3
                If btnArray(i).Text = "" Then
                    btnArray(i).Text = "O"
                    isClicked(i) = False
                    check_win()
                    Return 0
                End If
            Next
        End If

        human_counter = 0


        For i As Integer = 0 To 8 Step 4
            If btnArray(i).Text = "X" Then
                human_counter += 1
            End If
        Next

        If human_counter = 2 Then
            For i As Integer = 0 To 8 Step 4
                If btnArray(i).Text = "" Then
                    btnArray(i).Text = "O"
                    isClicked(i) = False
                    check_win()
                    Return 0
                End If
            Next
        End If

        human_counter = 0

        For i As Integer = 2 To 6 Step 2
            If btnArray(i).Text = "X" Then
                human_counter += 1
            End If
        Next

        If human_counter = 2 Then
            For i As Integer = 2 To 6 Step 2
                If btnArray(i).Text = "" Then
                    btnArray(i).Text = "O"
                    isClicked(i) = False
                    check_win()
                    Return 0
                End If
            Next
        End If

Looping:
        Randomize()
        Dim random_number As Integer = Int(Rnd() * 9)
        If isClicked(random_number) = True Then
            btnArray(random_number).Text = "O"
            isClicked(random_number) = False
            check_win()
        Else : GoTo Looping
        End If




    End Function

    Private Sub Form4_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load



    End Sub

    Private Sub b1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles b1.Click
        If isClicked(0) Then
            b1.Text = "X"
            isClicked(0) = False
            check_win()
            comp()
        End If
    End Sub

    Private Sub b2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles b2.Click
        If isClicked(1) Then
            b2.Text = "X"
            isClicked(1) = False
            check_win()
            comp()
        End If
    End Sub

    Private Sub b3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles b3.Click
        If isClicked(2) Then
            b3.Text = "X"
            isClicked(2) = False
            check_win()
            comp()
        End If
    End Sub

    Private Sub b4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles b4.Click
        If isClicked(3) Then
            b4.Text = "X"
            isClicked(3) = False
            check_win()
            comp()
        End If
    End Sub

    Private Sub b5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles b5.Click
        If isClicked(4) Then
            b5.Text = "X"
            isClicked(4) = False
            check_win()
            comp()
        End If
    End Sub

    Private Sub b6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles b6.Click
        If isClicked(5) Then
            b6.Text = "X"
            isClicked(5) = False
            check_win()
            comp()
        End If
    End Sub

    Private Sub b7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles b7.Click
        If isClicked(6) Then
            b7.Text = "X"
            isClicked(6) = False
            check_win()
            comp()
        End If
    End Sub

    Private Sub b8_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles b8.Click
        If isClicked(7) Then
            b8.Text = "X"
            isClicked(7) = False
            check_win()
            comp()
        End If
    End Sub

    Private Sub b9_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles b9.Click
        If isClicked(8) Then
            b9.Text = "X"
            isClicked(8) = False
            check_win()
            comp()
        End If
    End Sub

    Private Sub Form4_FormClosing(ByVal sender As System.Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles MyBase.FormClosing
        Application.Exit()
    End Sub
End Class