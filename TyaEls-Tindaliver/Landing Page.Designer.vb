<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Landing_Page
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As ComponentModel.ComponentResourceManager = New ComponentModel.ComponentResourceManager(GetType(Landing_Page))
        btnOrders = New Button()
        btnCustomers = New Button()
        btnProducts = New Button()
        btnCategories = New Button()
        btnDeliveries = New Button()
        Button1 = New Button()
        SuspendLayout()
        ' 
        ' btnOrders
        ' 
        btnOrders.BackColor = Color.Silver
        btnOrders.FlatStyle = FlatStyle.Flat
        btnOrders.Font = New Font("Bookman Old Style", 9F, FontStyle.Regular, GraphicsUnit.Point)
        btnOrders.Location = New Point(41, 394)
        btnOrders.Name = "btnOrders"
        btnOrders.Size = New Size(174, 24)
        btnOrders.TabIndex = 0
        btnOrders.Text = "ORDERS"
        btnOrders.UseVisualStyleBackColor = False
        ' 
        ' btnCustomers
        ' 
        btnCustomers.BackColor = Color.Silver
        btnCustomers.FlatStyle = FlatStyle.Flat
        btnCustomers.Font = New Font("Bookman Old Style", 9F, FontStyle.Regular, GraphicsUnit.Point)
        btnCustomers.Location = New Point(230, 394)
        btnCustomers.Name = "btnCustomers"
        btnCustomers.Size = New Size(171, 24)
        btnCustomers.TabIndex = 1
        btnCustomers.Text = "CUSTOMERS"
        btnCustomers.UseVisualStyleBackColor = False
        ' 
        ' btnProducts
        ' 
        btnProducts.BackColor = Color.Silver
        btnProducts.FlatStyle = FlatStyle.Flat
        btnProducts.Font = New Font("Bookman Old Style", 9F, FontStyle.Regular, GraphicsUnit.Point)
        btnProducts.Location = New Point(418, 394)
        btnProducts.Name = "btnProducts"
        btnProducts.Size = New Size(176, 24)
        btnProducts.TabIndex = 2
        btnProducts.Text = "PRODUCTS"
        btnProducts.UseVisualStyleBackColor = False
        ' 
        ' btnCategories
        ' 
        btnCategories.BackColor = Color.Silver
        btnCategories.FlatStyle = FlatStyle.Flat
        btnCategories.Font = New Font("Bookman Old Style", 9F, FontStyle.Regular, GraphicsUnit.Point)
        btnCategories.Location = New Point(609, 394)
        btnCategories.Name = "btnCategories"
        btnCategories.Size = New Size(173, 24)
        btnCategories.TabIndex = 3
        btnCategories.Text = "CATEGORIES"
        btnCategories.UseVisualStyleBackColor = False
        ' 
        ' btnDeliveries
        ' 
        btnDeliveries.BackColor = Color.Silver
        btnDeliveries.FlatStyle = FlatStyle.Flat
        btnDeliveries.Font = New Font("Bookman Old Style", 9F, FontStyle.Regular, GraphicsUnit.Point)
        btnDeliveries.Location = New Point(798, 394)
        btnDeliveries.Name = "btnDeliveries"
        btnDeliveries.Size = New Size(175, 24)
        btnDeliveries.TabIndex = 4
        btnDeliveries.Text = "DELIVERIES"
        btnDeliveries.UseVisualStyleBackColor = False
        ' 
        ' Button1
        ' 
        Button1.AccessibleRole = AccessibleRole.None
        Button1.BackColor = Color.Silver
        Button1.FlatStyle = FlatStyle.Popup
        Button1.Font = New Font("Bookman Old Style", 9.75F, FontStyle.Regular, GraphicsUnit.Point)
        Button1.Location = New Point(880, 447)
        Button1.Name = "Button1"
        Button1.Size = New Size(83, 44)
        Button1.TabIndex = 5
        Button1.Text = "EXIT"
        Button1.UseVisualStyleBackColor = False
        ' 
        ' Landing_Page
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), Image)
        BackgroundImageLayout = ImageLayout.None
        ClientSize = New Size(1003, 541)
        Controls.Add(Button1)
        Controls.Add(btnDeliveries)
        Controls.Add(btnCategories)
        Controls.Add(btnProducts)
        Controls.Add(btnCustomers)
        Controls.Add(btnOrders)
        Name = "Landing_Page"
        Text = "Landing_Page"
        ResumeLayout(False)
    End Sub

    Friend WithEvents btnOrders As Button
    Friend WithEvents btnCustomers As Button
    Friend WithEvents btnProducts As Button
    Friend WithEvents btnCategories As Button
    Friend WithEvents btnDeliveries As Button
    Friend WithEvents Button1 As Button
End Class
