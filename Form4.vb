Imports MySql.Data.MySqlClient

Public Class Form4

    Dim conn As MySqlConnection
    Dim connString As String
    Dim cmd As New MySqlCommand
    Dim rd As MySqlDataReader

    Public Sub openconnection()

        connString = "SERVER=db43.grserver.gr;PORT=3306;DATABASE=maragos;UID=maragos;PASSWORD=Maragos1234!"
        conn = New MySqlConnection()

        conn.ConnectionString = connString
        conn.Open()

        If (conn.State = ConnectionState.Open) Then

            MsgBox("Connection Opened")

        End If
    End Sub



    Public Sub closeconnection()
        If (conn.State = ConnectionState.Open) Then
            conn.Close()
            MsgBox("Connection Closed")

        End If
    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Hide()
        Form1.Show()




    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        openconnection()
        Dim query As String
        query = "Select password from Table1 where username='" & TextBox1.Text & "' and secret_key= '" & TextBox2.Text & "' "

        cmd = New MySqlCommand(query, conn)
        rd = cmd.ExecuteReader()
        If (Not isEmpty(TextBox1.Text) And Not isEmpty(TextBox2.Text)) Then



            If (rd.HasRows) Then

                While (rd.Read())

                    MsgBox(" Ο κωδικός είναι: " & rd("password"))


                End While



            Else

                MsgBox("Δεν βρέθηκε κάποιος λογαριασμός με αυτό το username και φράση ασφαλείας", vbCritical)

            End If

        Else
            MsgBox("Πρέπει να συμπληρώσετε και τα δύο πεδία")

        End If



    End Sub
End Class