Imports MySql.Data.MySqlClient

Public Class Form6
    Dim conn As MySqlConnection
    Dim connString As String
    Dim cmd As New MySqlCommand
    Dim rd As MySqlDataReader

    Dim poso_meta_tin_analipsi As Integer

    Private Sub openconnection()

        connString = "SERVER=db43.grserver.gr;PORT=3306;DATABASE=maragos;UID=maragos;PASSWORD=Maragos1234!"
        conn = New MySqlConnection()

        conn.ConnectionString = connString
        conn.Open()

        If (conn.State = ConnectionState.Open) Then



        End If
    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If Integer.TryParse(TextBox1.Text, euro) And euro > 0 Then

            Dim query As String
            Try

                'Αρχή ελέγχου
                openconnection()

                query = "select * from  Table1 where username= '" & username & "' "
                cmd = New MySqlCommand(query, conn)
                rd = cmd.ExecuteReader

                If rd.HasRows Then
                    While rd.Read()
                        euro = rd("euro")
                    End While


                End If

                rd.Close()
                'Τέλος ελέγχου
                '

                'Αρχή Συναλλαγής
                openconnection()

                query = "update Table1 set euro=euro-'" & CInt(TextBox1.Text) & "' where username='" & username & "' and password= '" & password & "' "

                cmd = New MySqlCommand(query, conn)
                rd = cmd.ExecuteReader
                rd.Close()
                'Τέλος Συναλλαγής

                openconnection()



                query = "insert into analipsi(poso_analipsis,iban,datetime) values('" & CInt(TextBox1.Text) & "','" & iban_ & "',now())"

                cmd = New MySqlCommand(query, conn)
                rd = cmd.ExecuteReader

                conn.Close()


                openconnection()

                query = "select * from Table1 where username='" & username & "' "

                cmd = New MySqlCommand(query, conn)
                rd = cmd.ExecuteReader

                If rd.HasRows Then
                    While rd.Read
                        MsgBox("Επιτυχής ανάληψη.Το υπόλοιπο σας είναι:" & rd("euro") & "€")
                        poso_meta_tin_analipsi = rd("euro")
                    End While

                End If


            Catch ex As Exception
                MsgBox("Δεν μπορεί να γίνει ανάληψη ποσού μεγαλύτερου του υπολοίπου. Το υπόλοιπό σας  είναι:" & euro & "€")
            End Try






        ElseIf Not Integer.TryParse(TextBox1.Text, euro) Then
            MsgBox("Δώσε μόνο αριθμούς.", MsgBoxStyle.Critical)

        Else
            ' The input is not a valid number or is less than or equal to 0
            MsgBox("Δώσε αριθμό μεγαλύτερο του 0", MsgBoxStyle.Critical)

        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Hide()
        Form1.Show()

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Form5.Label7.Text = poso_meta_tin_analipsi
        Me.Hide()
        Form5.Show()


    End Sub


End Class