<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class OrderList
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
        Dim resources As ComponentModel.ComponentResourceManager = New ComponentModel.ComponentResourceManager(GetType(OrderList))
        tblOrder = New DataGridView()
        itemID = New DataGridViewTextBoxColumn()
        orderID = New DataGridViewTextBoxColumn()
        prodName = New DataGridViewTextBoxColumn()
        itemQuantity = New DataGridViewTextBoxColumn()
        itemAmount = New DataGridViewTextBoxColumn()
        textOrder = New Button()
        PictureBox1 = New PictureBox()
        btnRefreshOrder = New Button()
        txtOrderID = New TextBox()
        txtQuantity = New TextBox()
        Label1 = New Label()
        Label2 = New Label()
        btndelOrder = New Button()
        Label3 = New Label()
        Label4 = New Label()
        Label5 = New Label()
        txtProdName = New TextBox()
        txtAmount = New TextBox()
        txtItem = New TextBox()
        Button1 = New Button()
        CType(tblOrder, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' tblOrder
        ' 
        tblOrder.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        tblOrder.Columns.AddRange(New DataGridViewColumn() {itemID, orderID, prodName, itemQuantity, itemAmount})
        tblOrder.Location = New Point(23, 134)
        tblOrder.Name = "tblOrder"
        tblOrder.RowTemplate.Height = 25
        tblOrder.Size = New Size(538, 392)
        tblOrder.TabIndex = 0
        ' 
        ' itemID
        ' 
        itemID.HeaderText = "Item ID"
        itemID.Name = "itemID"' 
        ' orderID
        ' 
        orderID.HeaderText = "Order ID"
        orderID.Name = "orderID"' 
        ' prodName
        ' 
        prodName.HeaderText = "Product Name"
        prodName.Name = "prodName"' 
        ' itemQuantity
        ' 
        itemQuantity.HeaderText = "Quantity"
        itemQuantity.Name = "itemQuantity"' 
        ' itemAmount
        ' 
        itemAmount.HeaderText = "Amount"
        itemAmount.Name = "itemAmount"' 
        ' textOrder
        ' 
        textOrder.BackColor = Color.FromArgb(CByte(255), CByte(128), CByte(0))
        textOrder.FlatStyle = FlatStyle.Popup
        textOrder.Font = New Font("Bookman Old Style", 12F, FontStyle.Regular, GraphicsUnit.Point)
        textOrder.Location = New Point(895, 34)
        textOrder.Name = "textOrder"
        textOrder.Size = New Size(53, 53)
        textOrder.TabIndex = 1
        textOrder.Text = "X"
        textOrder.UseVisualStyleBackColor = False
        ' 
        ' PictureBox1
        ' 
        PictureBox1.BackColor = Color.Transparent
        PictureBox1.BackgroundImage = CType(resources.GetObject("PictureBox1.BackgroundImage"), Image)
        PictureBox1.Location = New Point(580, 146)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(411, 390)
        PictureBox1.TabIndex = 14
        PictureBox1.TabStop = False
        ' 
        ' btnRefreshOrder
        ' 
        btnRefreshOrder.BackColor = Color.Silver
        btnRefreshOrder.FlatStyle = FlatStyle.Popup
        btnRefreshOrder.Font = New Font("Bookman Old Style", 9F, FontStyle.Regular, GraphicsUnit.Point)
        btnRefreshOrder.Location = New Point(846, 431)
        btnRefreshOrder.Name = "btnRefreshOrder"
        btnRefreshOrder.Size = New Size(127, 32)
        btnRefreshOrder.TabIndex = 15
        btnRefreshOrder.Text = "REFRESH"
        btnRefreshOrder.UseVisualStyleBackColor = False
        ' 
        ' txtOrderID
        ' 
        txtOrderID.Location = New Point(725, 222)
        txtOrderID.Name = "txtOrderID"
        txtOrderID.Size = New Size(254, 23)
        txtOrderID.TabIndex = 16
        ' 
        ' txtQuantity
        ' 
        txtQuantity.Location = New Point(725, 302)
        txtQuantity.Name = "txtQuantity"
        txtQuantity.Size = New Size(254, 23)
        txtQuantity.TabIndex = 17
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.BackColor = Color.Transparent
        Label1.Font = New Font("Bookman Old Style", 11.25F, FontStyle.Bold, GraphicsUnit.Point)
        Label1.ForeColor = Color.FromArgb(CByte(255), CByte(128), CByte(0))
        Label1.Location = New Point(580, 188)
        Label1.Name = "Label1"
        Label1.Size = New Size(73, 18)
        Label1.TabIndex = 18
        Label1.Text = "ITEM ID"' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.BackColor = Color.Transparent
        Label2.Font = New Font("Bookman Old Style", 11.25F, FontStyle.Bold, GraphicsUnit.Point)
        Label2.ForeColor = Color.FromArgb(CByte(255), CByte(128), CByte(0))
        Label2.Location = New Point(580, 227)
        Label2.Name = "Label2"
        Label2.Size = New Size(88, 18)
        Label2.TabIndex = 19
        Label2.Text = "ORDER ID"' 
        ' btndelOrder
        ' 
        btndelOrder.BackColor = Color.Silver
        btndelOrder.FlatStyle = FlatStyle.Popup
        btndelOrder.Font = New Font("Bookman Old Style", 9F, FontStyle.Regular, GraphicsUnit.Point)
        btndelOrder.Location = New Point(713, 431)
        btndelOrder.Name = "btndelOrder"
        btndelOrder.Size = New Size(127, 32)
        btndelOrder.TabIndex = 20
        btndelOrder.Text = "DELETE RECORD"
        btndelOrder.UseVisualStyleBackColor = False
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.BackColor = Color.Transparent
        Label3.Font = New Font("Bookman Old Style", 11.25F, FontStyle.Bold, GraphicsUnit.Point)
        Label3.ForeColor = Color.FromArgb(CByte(255), CByte(128), CByte(0))
        Label3.Location = New Point(580, 265)
        Label3.Name = "Label3"
        Label3.Size = New Size(139, 18)
        Label3.TabIndex = 21
        Label3.Text = "PRODUCT NAME"' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.BackColor = Color.Transparent
        Label4.Font = New Font("Bookman Old Style", 11.25F, FontStyle.Bold, GraphicsUnit.Point)
        Label4.ForeColor = Color.FromArgb(CByte(255), CByte(128), CByte(0))
        Label4.Location = New Point(580, 307)
        Label4.Name = "Label4"
        Label4.RightToLeft = RightToLeft.No
        Label4.Size = New Size(92, 18)
        Label4.TabIndex = 22
        Label4.Text = "QUANTITY"' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.BackColor = Color.Transparent
        Label5.Font = New Font("Bookman Old Style", 11.25F, FontStyle.Bold, GraphicsUnit.Point)
        Label5.ForeColor = Color.FromArgb(CByte(255), CByte(128), CByte(0))
        Label5.Location = New Point(580, 345)
        Label5.Name = "Label5"
        Label5.Size = New Size(79, 18)
        Label5.TabIndex = 23
        Label5.Text = "AMOUNT"' 
        ' txtProdName
        ' 
        txtProdName.Location = New Point(725, 260)
        txtProdName.Name = "txtProdName"
        txtProdName.Size = New Size(254, 23)
        txtProdName.TabIndex = 24
        ' 
        ' txtAmount
        ' 
        txtAmount.Location = New Point(725, 340)
        txtAmount.Name = "txtAmount"
        txtAmount.Size = New Size(254, 23)
        txtAmount.TabIndex = 25
        ' 
        ' txtItem
        ' 
        txtItem.Location = New Point(725, 183)
        txtItem.Name = "txtItem"
        txtItem.Size = New Size(254, 23)
        txtItem.TabIndex = 26
        ' 
        ' Button1
        ' 
        Button1.BackColor = Color.Silver
        Button1.FlatStyle = FlatStyle.Popup
        Button1.Font = New Font("Bookman Old Style", 9F, FontStyle.Regular, GraphicsUnit.Point)
        Button1.Location = New Point(580, 431)
        Button1.Name = "Button1"
        Button1.Size = New Size(127, 32)
        Button1.TabIndex = 27
        Button1.Text = "ADD RECORD"
        Button1.UseVisualStyleBackColor = False
        ' 
        ' OrderList
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), Image)
        BackgroundImageLayout = ImageLayout.None
        ClientSize = New Size(991, 538)
        Controls.Add(Button1)
        Controls.Add(txtItem)
        Controls.Add(txtAmount)
        Controls.Add(txtProdName)
        Controls.Add(Label5)
        Controls.Add(Label4)
        Controls.Add(Label3)
        Controls.Add(btndelOrder)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Controls.Add(txtQuantity)
        Controls.Add(txtOrderID)
        Controls.Add(btnRefreshOrder)
        Controls.Add(PictureBox1)
        Controls.Add(textOrder)
        Controls.Add(tblOrder)
        Name = "OrderList"
        Text = "OrderList"
        CType(tblOrder, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents tblOrder As DataGridView
    Friend WithEvents textOrder As Button
    Friend WithEvents itemID As DataGridViewTextBoxColumn
    Friend WithEvents orderID As DataGridViewTextBoxColumn
    Friend WithEvents prodName As DataGridViewTextBoxColumn
    Friend WithEvents itemQuantity As DataGridViewTextBoxColumn
    Friend WithEvents itemAmount As DataGridViewTextBoxColumn
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents btnRefreshOrder As Button
    Friend WithEvents txtOrderID As TextBox
    Friend WithEvents txtQuantity As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents btndelOrder As Button
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents txtProdName As TextBox
    Friend WithEvents txtAmount As TextBox
    Friend WithEvents txtItem As TextBox
    Friend WithEvents Button1 As Button
End Class
