Imports System.Data.SqlClient

Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Try
            Dim conn As New SqlConnection("Data Source=Dell-G3\sqlexpress;Initial Catalog=Banking_System;Integrated Security=True")
            Dim obj As SqlDataReader
            conn.Open()
            Dim cmd As New SqlCommand("select * from User_Data where username = '" & TextBox1.Text & "'", conn)
            obj = cmd.ExecuteReader
            While obj.Read
                If obj.Item(1) = TextBox2.Text Then
                    MsgBox("Loged")
                End If
            End While
            conn.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try

    End Sub
End Class
