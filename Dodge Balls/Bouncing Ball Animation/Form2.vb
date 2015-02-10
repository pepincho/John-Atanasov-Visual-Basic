Imports Bouncing_Ball_Animation.UsersDataSetTableAdapters

Imports System.Data.OleDb
Public Class Form2

    Public usersDS As New UsersDataSet()
    Public usersTA As New UsersDataSetTableAdapters.UsersTableAdapter()

    Dim Mycn As OleDbConnection
    Dim Command As OleDbCommand
    Dim SQLstr As String
    Dim icount As Integer

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click

        Mycn = New OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\Users\Martin\Desktop\Project 3\Dodge Balls\Bouncing Ball Animation\Users.mdb;")
        Mycn.Open()

        SQLstr = "INSERT INTO Users VALUES('" & TextBox1.Text & "','" & TextBox2.Text & "')"

        Command = New OleDbCommand(SQLstr, Mycn)
        icount = Command.ExecuteNonQuery
        MessageBox.Show("Регистрирахте се успешно!")
        Mycn.Close()
        Form1.Show()
        Me.Hide()

    End Sub

    Private Sub Form2_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
      
    End Sub
End Class