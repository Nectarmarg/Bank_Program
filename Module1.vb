Imports System.Windows.Forms
Imports MySql.Data.MySqlClient

Module Module1
    Dim conn As MySqlConnection
    Dim connString As String
    Dim cmd As New MySqlCommand
    Dim rd As MySqlDataReader

    Public firstname As String
    Public lastname As String
    Public username As String
    Public password As String
    Public secret_key As String
    Public euro As Integer



    Public id As Integer







    Public iban_ As Integer

    Public Function isEmpty(var)
        If (Trim(var) = "") Then

            Return True

        Else

            Return False

        End If



    End Function







End Module
