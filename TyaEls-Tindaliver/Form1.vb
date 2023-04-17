Imports MySql.Data.MySqlClient
Public Class Form1
    Private Sub Button1_Click_(sender As Object, e As EventArgs) Handles Button1.Click

        With Me
            Call Connect_to_DB()
            Dim mycmd As New MySqlCommand
            Dim myreader As MySqlDataReader

            strSQL = "Select * from users where username = '" _
                & .txtUsername.Text & "' and password = md5('" _
                & .txtPassword.Text & "')"
            'MsgBox(strSQL)
            mycmd.CommandText = strSQL
            mycmd.Connection = myconn

            myreader = mycmd.ExecuteReader()
            If myreader.HasRows Then
                .Hide()
                Landing_Page.Show()
            Else
                MessageBox.Show("ERROR: Invalid Password or Username")
            End If
            Call Disconnect_to_DB()
        End With
    End Sub
End Class