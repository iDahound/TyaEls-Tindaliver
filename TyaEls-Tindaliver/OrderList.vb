Imports MySql.Data.MySqlClient

Public Class OrderList

    Private Sub OrderList_Load(sender As Object, e As EventArgs)
        tblOrder.Rows.Clear()

        Dim query As String
        Dim mycommand As New MySqlCommand
        query = "SELECT * FROM items_ordered INNER JOIN products ON items_ordered.product_id = products.product_id"
        Connect_to_DB()

        With mycommand
            .Connection = myconn
            .CommandType = CommandType.Text
            .CommandText = query
        End With

        Dim myreader As MySqlDataReader
        myreader = mycommand.ExecuteReader
        While myreader.Read()
            tblOrder.Rows.Add(New Object() {myreader.Item("item_id"), myreader.Item("order_id"), myreader.Item("product_name"), myreader.Item("item_quantity"), myreader.Item("product_price")})
        End While

        Disconnect_to_DB()
    End Sub

    Private Sub textOrder_Click(sender As Object, e As EventArgs) Handles textOrder.Click
        Me.Hide()
        Landing_Page.Show()
    End Sub

    Private Sub OrderList_Load_1(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class