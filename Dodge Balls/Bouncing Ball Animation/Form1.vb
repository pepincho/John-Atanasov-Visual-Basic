Imports System.Data.OleDb

Public Class Form1
    Private Sub TextBox1_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox1.TextChanged

    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Form2.Show()
        Me.Hide()
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim Mycn As OleDbConnection
        Dim Command As OleDbCommand
        Dim SQLstr As String

        Mycn = New OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\Users\Martin\Desktop\Project 3\Dodge Balls\Bouncing Ball Animation;")
        Mycn.Open()

        SQLstr = "SELECT Username,Password FROM Users"

        Command = New OleDbCommand(SQLstr, Mycn)
        Dim kurec As OleDbDataReader

        kurec = Command.ExecuteReader()

        While (kurec.Read() = True)
            If TextBox1.Text = kurec("Username") And TextBox2.Text = kurec("Password") Then
                MsgBox("Marto e programist")
                Mycn.Close()
                Levels.Show()
                Me.Hide()
            End If
        End While
        Mycn.Close()



    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class