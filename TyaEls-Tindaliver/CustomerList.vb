Imports System.IO
Imports MySql.Data.MySqlClient

Public Class CustomerList
    Dim file
    Private Sub CustomerList_Load_1(sender As Object, e As EventArgs) Handles MyBase.Load
        Load_Data()
    End Sub

    Private Sub btnUpUs_Click(sender As Object, e As EventArgs) Handles btnUpUs.Click
        Dim openFileDialog1 As New OpenFileDialog()
        openFileDialog1.Filter = "CSV Files|*.csv"
        openFileDialog1.Title = "Select a CSV File"

        If openFileDialog1.ShowDialog() = System.Windows.Forms.DialogResult.OK Then
            Dim file As String = openFileDialog1.FileName
            file = openFileDialog1.FileName.ToString
            file = file.Replace("\", "/")

            With Me
                Call Connect_to_DB()
                Dim mycmd As New MySqlCommand
                Dim myreader As MySqlDataReader

                strSQL = "LOAD DATA INFILE '" & file & "'INTO TABLE customers FIELDS TERMINATED BY ',' lines terminated by '\r\n' ignore 1 lines;"

                mycmd.CommandText = strSQL
                mycmd.Connection = myconn
                mycmd.ExecuteNonQuery()

                Disconnect_to_DB()

            End With

        End If

        Load_Data()
    End Sub

    Public Sub Load_Data()
        DataGridView1.Rows.Clear()

        Dim query As String
        Dim mycommand As New MySqlCommand
        query = "SELECT * FROM customers"
        Connect_to_DB()

        With mycommand
            .Connection = myconn
            .CommandType = CommandType.Text
            .CommandText = query
        End With

        Dim myreader As MySqlDataReader
        myreader = mycommand.ExecuteReader
        While myreader.Read()
            DataGridView1.Rows.Add(New Object() {myreader.Item("customer_id"), myreader.Item("customer_name"), myreader.Item("customer_email"), myreader.Item("customer_phone"), myreader.Item("customer_address")})
        End While

        Disconnect_to_DB()
    End Sub

End Class