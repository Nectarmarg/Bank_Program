Imports System.Security.Cryptography
Imports System.Windows.Forms
Imports Google.Protobuf.WellKnownTypes
Imports MySql.Data.MySqlClient
Imports Mysqlx

Public Class Form2

    Dim conn As MySqlConnection
    Dim connString As String
    Dim cmd As New MySqlCommand
    Dim rd As MySqlDataReader

    Dim iban As Integer

    Dim id As Integer






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



    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Close()
        Form1.Show()

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click







        If (isEmpty(TextBox1.Text) Or isEmpty(TextBox2.Text) Or isEmpty(TextBox3.Text) Or isEmpty(TextBox4.Text) Or isEmpty(TextBox5.Text)) Then

            MsgBox("Πρέπει να συμπληρωθούν όλα τα πεδία", vbCritical)

        Else



            conn = New MySqlConnection()

            Dim query As String



            Dim iban As Integer
            Dim rnd As New Random()


            iban = rnd.Next(100000000, 200000000)










            query = "Insert into Table1(firstname,lastname,username,password,secret_key,iban) values ('" & TextBox1.Text & "','" & TextBox2.Text & "','" & TextBox3.Text & "','" & TextBox4.Text & "','" & TextBox5.Text & "','" & iban & "')"




            openconnection()

            Dim sql As String

            sql = "SELECT username  from  Table1  where username='" & TextBox3.Text & "' "

            cmd = New MySqlCommand(sql, conn)

            rd = cmd.ExecuteReader()




            If (rd.HasRows) Then
                MsgBox("Αυτό το username υπάρχει ήδη", vbCritical)
            Else









                If (conn.State = ConnectionState.Open) Then
                        conn.Close()


                    End If

                    If (conn.State = ConnectionState.Closed) Then
                        conn.Open()


                    End If

                    If (conn.State = ConnectionState.Open) Then
                    cmd = New MySqlCommand(query, conn)
                    cmd.ExecuteNonQuery()









                    MsgBox(" Τα στοιχεία εισάχθηκαν με επιτυχία")

                        Me.Close()
                        Form1.Show()




                    End If




                End If







            End If




    End Sub

    Private Sub ΚαθάρισμαΠεδίωνToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ΚαθάρισμαΠεδίωνToolStripMenuItem.Click
        TextBox1.Text = ""

        TextBox2.Text = ""

        TextBox3.Text = ""

        TextBox4.Text = ""

        TextBox5.Text = ""
    End Sub
End Class