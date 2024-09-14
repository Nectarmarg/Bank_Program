Imports MySql.Data.MySqlClient

Public Class Form7
    Dim conn As MySqlConnection
    Dim connString As String
    Dim cmd As New MySqlCommand
    Dim rd As MySqlDataReader

    Private Sub openconnection()

        connString = "SERVER=db43.grserver.gr;PORT=3306;DATABASE=maragos;UID=maragos;PASSWORD=Maragos1234!"
        conn = New MySqlConnection()

        conn.ConnectionString = connString
        conn.Open()

        If (conn.State = ConnectionState.Open) Then



        End If
    End Sub
    Private Sub Form7_Load(sender As Object, e As EventArgs) Handles MyBase.Load


    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Hide()
        Form5.Show()




    End Sub

    Private Sub ListBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListBox1.SelectedIndexChanged

    End Sub
End Class