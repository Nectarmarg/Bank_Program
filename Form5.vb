Imports MySql.Data.MySqlClient

Public Class Form5
    Dim conn As MySqlConnection
    Dim connString As String
    Dim cmd As New MySqlCommand
    Dim rd As MySqlDataReader

    Dim poso_katathesis As Integer = 0



    Private Sub Query_exit_aposindesi()


        Dim query As String

        query = "insert into aposindesi(iban,datetime) values('" & iban_ & "',now()) "

        cmd = New MySqlCommand(query, conn)
        cmd.ExecuteNonQuery()




    End Sub

    Private Sub closeconnection()
        If (conn.State = ConnectionState.Open) Then

            MsgBox("Ευχαριστούμε για την  προτίμηση σας!")

            conn.Close()


        End If
    End Sub

    Private Sub openconnection()

        connString = "SERVER=db43.grserver.gr;PORT=3306;DATABASE=maragos;UID=maragos;PASSWORD=Maragos1234!"
        conn = New MySqlConnection()

        conn.ConnectionString = connString
        conn.Open()

        If (conn.State = ConnectionState.Open) Then



        End If
    End Sub

    Private Sub Form5_Load(sender As Object, e As EventArgs) Handles MyBase.Load





    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Label10.Visible = True
        Label11.Visible = True
        TextBox1.Visible = True
        Button4.Visible = True

    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Me.Hide()
        Form1.Show()

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Hide()
        Form6.Show()
        TextBox1.Text = "0"
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click

        If Integer.TryParse(TextBox1.Text, poso_katathesis) And poso_katathesis > 0 Then

            Dim query As String
            openconnection()

            query = "update Table1  set euro=euro+'" & CInt(TextBox1.Text) & "' where username='" & username & "' and password= '" & password & "' "

            cmd = New MySqlCommand(query, conn)
            rd = cmd.ExecuteReader()

            rd.Close()

            query = "select firstname,lastname,iban,euro from Table1 where username='" & username & "'"

            MsgBox("Η κατάθεση είναι επιτυχής")
            openconnection()


            cmd = New MySqlCommand(query, conn)
            rd = cmd.ExecuteReader()



            If rd.HasRows Then
                rd.Read()

                Label2.Text = rd("firstname")
                Label3.Text = rd("lastname")
                Label5.Text = rd("iban")
                Label7.Text = rd("euro")
                euro = rd("euro")





                rd.Close()



            End If






            query = " insert into katathesi(poso_katathesis,iban,datetime) values('" & CInt(TextBox1.Text) & "','" & iban_ & "',now()) "


            cmd = New MySqlCommand(query, conn)
            cmd.ExecuteNonQuery()




        ElseIf (Not Integer.TryParse(TextBox1.Text, poso_katathesis)) Then
            MsgBox("Δώσε μόνο αριθμούς.", MsgBoxStyle.Critical)

        Else

            MsgBox("Δώσε αριθμό μεγαλύτερο του 0", MsgBoxStyle.Critical)
        End If
    End Sub



    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        closeconnection()

        openconnection()

        Query_exit_aposindesi()

        conn.Close()



        Me.Hide()
        Form3.Show()

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        openconnection()



        Dim query As String
        query = "select * from Table1 where username='" & username & "' "

        cmd = New MySqlCommand(query, conn)
        rd = cmd.ExecuteReader()

        If rd.HasRows Then
            While (rd.Read)
                Form7.ListBox1.Items.Add("")
                Form7.ListBox1.Items.Add("Όνομα πελάτη:" & rd("firstname"))
                Form7.ListBox1.Items.Add("Επίθετο πελάτη:" & rd("lastname"))

                Form7.ListBox1.Items.Add("IBAN πελάτη:" & rd("iban"))
                Form7.ListBox1.Items.Add("")

            End While

        End If

        conn.Close()

        openconnection()

        query = "select * from apli_sindesi where iban='" & iban_ & "'"

        cmd = New MySqlCommand(query, conn)
        rd = cmd.ExecuteReader()

        If rd.HasRows Then
            While (rd.Read)
                Form7.ListBox1.Items.Add("")
                Form7.ListBox1.Items.Add("Απλή σύνδεση")
                Form7.ListBox1.Items.Add("IBAN πελάτη:" & iban_)
                Form7.ListBox1.Items.Add("Ώρα σύνδεσης:" & rd("datetime"))
                Form7.ListBox1.Items.Add("")
            End While
        End If

        conn.Close()

        openconnection()

        query = "select * from katathesi where iban='" & iban_ & "'"

        cmd = New MySqlCommand(query, conn)
        rd = cmd.ExecuteReader()

        If rd.HasRows Then
            While (rd.Read)
                Form7.ListBox1.Items.Add("")
                Form7.ListBox1.Items.Add("Κατάθεση")
                Form7.ListBox1.Items.Add("IBAN πελάτη:" & rd("iban"))
                Form7.ListBox1.Items.Add("Ποσό κατάθεσης:" & rd("poso_katathesis") & "€")
                Form7.ListBox1.Items.Add("Ώρα σύνδεσης:" & rd("datetime"))
                Form7.ListBox1.Items.Add("")

            End While
        End If

        conn.Close()



        openconnection()

        query = "select * from analipsi where iban='" & iban_ & "'"

        cmd = New MySqlCommand(query, conn)
        rd = cmd.ExecuteReader()

        If rd.HasRows Then
            While (rd.Read)
                Form7.ListBox1.Items.Add("")
                Form7.ListBox1.Items.Add("Ανάληψη")
                Form7.ListBox1.Items.Add("IBAN πελάτη:" & rd("iban"))
                Form7.ListBox1.Items.Add("Ποσό ανάληψης:" & rd("poso_analipsis") & "€")
                Form7.ListBox1.Items.Add("Ώρα σύνδεσης:" & rd("datetime"))
                Form7.ListBox1.Items.Add("")

            End While
        End If

        conn.Close()


        openconnection()

        query = "select * from aposindesi where iban='" & iban_ & "'"

        cmd = New MySqlCommand(query, conn)
        rd = cmd.ExecuteReader()

        If rd.HasRows Then
            While (rd.Read)
                Form7.ListBox1.Items.Add("")
                Form7.ListBox1.Items.Add("Αποσύνδεση")
                Form7.ListBox1.Items.Add("IBAN πελάτη:" & rd("iban"))

                Form7.ListBox1.Items.Add("Ώρα αποσύνδεσης:" & rd("datetime"))
                Form7.ListBox1.Items.Add("")

            End While
        End If

        conn.Close()


        Me.Hide()
        Form7.Show()
        TextBox1.Text = "0"
    End Sub


End Class