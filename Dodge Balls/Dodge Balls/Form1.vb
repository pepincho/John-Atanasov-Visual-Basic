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

        Mycn = New OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\Users\Latchezar Mladenov\Desktop\Development\Visual Basic Projects\Dodge Balls\Bouncing Ball Animation\Users.mdb")
        Mycn.Open()

        SQLstr = "SELECT Username,Password FROM Users"

        Command = New OleDbCommand(SQLstr, Mycn)
        Dim asd As OleDbDataReader

        asd = Command.ExecuteReader()

        While (asd.Read() = True)
            If TextBox1.Text = asd("Username") And TextBox2.Text = asd("Password") Then

                Levels.Show()
                Me.Hide()
            End If
        End While
        Mycn.Close()



    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class