Imports MySql.Data.MySqlClient
Imports Mysqlx

Public Class Form3

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

    Dim conn As MySqlConnection
    Dim connString As String
    Dim cmd As New MySqlCommand
    Dim rd As MySqlDataReader
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Close()
        Form1.Show()


    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click




        conn = New MySqlConnection()

        openconnection()
        Dim query As String


        query = "SELECT * from Table1 where username='" & TextBox1.Text & "' and password= '" & TextBox2.Text & "' "



        cmd = New MySqlCommand(query, conn)
        rd = cmd.ExecuteReader()

        If (Not isEmpty(TextBox1.Text) And Not isEmpty(TextBox2.Text)) Then


            If Not rd.HasRows Then
                MsgBox("Δεν βρέθηκε λογαριασμός", vbCritical)
            Else

                rd.Read()


                firstname = rd("firstname")
                lastname = rd("lastname")
                username = rd("username")
                password = rd("password")
                euro = rd("euro")
                iban_ = rd("iban")

                rd.Close()


                Dim check As String

                check = "insert into apli_sindesi (iban) values('" & iban_ & "')  "





                cmd.ExecuteNonQuery()


                conn.Close()

                conn.Open()

                cmd = New MySqlCommand(check, conn)

                cmd.ExecuteNonQuery()


                MsgBox("Καλωσορίσατε")

                Form5.Label2.Text = firstname
                Form5.Label3.Text = lastname
                Form5.Label5.Text = iban_
                Form5.Label7.Text = euro

                Me.Hide()
                Form5.Show()

                TextBox1.Text = ""
                TextBox2.Text = ""




            End If


        Else
            MsgBox("Πρέπει να εισάγετε όλα τα πεδία", vbCritical)
            TextBox1.Text = ""
            TextBox2.Text = ""

        End If








    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        Me.Hide()
        Form4.Show()
    End Sub

    Private Sub Form3_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class