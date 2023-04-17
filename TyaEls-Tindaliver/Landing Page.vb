Imports System.Windows

Public Class Landing_Page
    Private Sub bttnOrders_MouseEnter(sender As Object, e As EventArgs) Handles btnOrders.MouseEnter, btnOrders.MouseEnter
        btnOrders.BackColor = Color.Orange
    End Sub

    Private Sub bttnOrders_MouseLeave(sender As Object, e As EventArgs) Handles btnOrders.MouseLeave, btnOrders.MouseLeave
        btnOrders.BackColor = SystemColors.Control
    End Sub

    Private Sub bttnCustomers_MouseEnter(sender As Object, e As EventArgs) Handles btnCustomers.MouseEnter, btnCustomers.MouseEnter
        btnCustomers.BackColor = Color.Orange
    End Sub

    Private Sub bttnCustomers_MouseLeave(sender As Object, e As EventArgs) Handles btnCustomers.MouseLeave, btnCustomers.MouseLeave
        btnCustomers.BackColor = SystemColors.Control
    End Sub

    Private Sub bttnProducts_MouseEnter(sender As Object, e As EventArgs) Handles btnProducts.MouseEnter, btnProducts.MouseEnter
        btnProducts.BackColor = Color.Orange
    End Sub

    Private Sub bttnProducts_MouseLeave(sender As Object, e As EventArgs) Handles btnProducts.MouseLeave, btnProducts.MouseLeave
        btnProducts.BackColor = SystemColors.Control
    End Sub

    Private Sub bttnCategories_MouseEnte(sender As Object, e As EventArgs) Handles btnCategories.MouseEnter, btnCategories.MouseEnter
        btnCategories.BackColor = Color.Orange
    End Sub

    Private Sub bttnCategories_MouseLeave(sender As Object, e As EventArgs) Handles btnCategories.MouseLeave, btnCategories.MouseLeave
        btnCategories.BackColor = SystemColors.Control
    End Sub

    Private Sub bttnDeliveries_MouseEnter(sender As Object, e As EventArgs) Handles btnDeliveries.MouseEnter, btnDeliveries.MouseEnter
        btnDeliveries.BackColor = Color.Orange
    End Sub

    Private Sub bttnDeliveries_MouseLeave(sender As Object, e As EventArgs) Handles btnDeliveries.MouseLeave, btnDeliveries.MouseLeave
        btnDeliveries.BackColor = SystemColors.Control
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Close()
    End Sub

    Private Sub btnOrders_Click(sender As Object, e As EventArgs) Handles btnOrders.Click
        Dim nextPage As New OrderList
        nextPage.Show()
        Me.Hide()
    End Sub

    Private Sub btnCustomers_Click(sender As Object, e As EventArgs) Handles btnCustomers.Click
        Dim nextPage As New CustomerList
        nextPage.Show()
        Me.Hide()
    End Sub

    Private Sub btnProducts_Click(sender As Object, e As EventArgs) Handles btnProducts.Click
        Dim nextPage As New ProductsList
        nextPage.Show()
        Me.Hide()
    End Sub

    Private Sub btnCategories_Click(sender As Object, e As EventArgs) Handles btnCategories.Click
        Dim nextPage As New CategoryList
        nextPage.Show()
        Me.Hide()
    End Sub

    Private Sub btnDeliveries_Click(sender As Object, e As EventArgs) Handles btnDeliveries.Click
        Dim nextPage As New DeliveryList
        nextPage.Show()
        Me.Hide()
    End Sub

    Private Sub Landing_Page_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class