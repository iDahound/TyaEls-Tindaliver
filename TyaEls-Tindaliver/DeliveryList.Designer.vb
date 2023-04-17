<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class DeliveryList
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
        Dim resources As ComponentModel.ComponentResourceManager = New ComponentModel.ComponentResourceManager(GetType(DeliveryList))
        extDelivery = New Button()
        DataGridView1 = New DataGridView()
        orderID = New DataGridViewTextBoxColumn()
        cutomerID = New DataGridViewTextBoxColumn()
        dateOrdered = New DataGridViewTextBoxColumn()
        orderStatus = New DataGridViewTextBoxColumn()
        orderAmount = New DataGridViewTextBoxColumn()
        txtAmountDel = New TextBox()
        txtOrderStatusDel = New TextBox()
        txtCustomDel = New TextBox()
        txtOrderDel = New TextBox()
        btnRefreshDel = New Button()
        btnDeleteDel = New Button()
        Label4 = New Label()
        Label3 = New Label()
        Label2 = New Label()
        lblCustomerDel = New Label()
        lblDelOrder = New Label()
        DateTimePicker1 = New DateTimePicker()
        Button1 = New Button()
        btnUploadFile = New Button()
        CType(DataGridView1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' extDelivery
        ' 
        extDelivery.BackColor = Color.FromArgb(CByte(255), CByte(128), CByte(0))
        extDelivery.FlatStyle = FlatStyle.Popup
        extDelivery.Font = New Font("Bookman Old Style", 12F, FontStyle.Regular, GraphicsUnit.Point)
        extDelivery.Location = New Point(897, 33)
        extDelivery.Name = "extDelivery"
        extDelivery.Size = New Size(53, 53)
        extDelivery.TabIndex = 1
        extDelivery.Text = "X"
        extDelivery.UseVisualStyleBackColor = False
        ' 
        ' DataGridView1
        ' 
        DataGridView1.AllowUserToOrderColumns = True
        DataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridView1.Columns.AddRange(New DataGridViewColumn() {orderID, cutomerID, dateOrdered, orderStatus, orderAmount})
        DataGridView1.Location = New Point(12, 125)
        DataGridView1.Name = "DataGridView1"
        DataGridView1.RowTemplate.Height = 25
        DataGridView1.Size = New Size(566, 389)
        DataGridView1.TabIndex = 2
        ' 
        ' orderID
        ' 
        orderID.HeaderText = "Order ID"
        orderID.Name = "orderID"' 
        ' cutomerID
        ' 
        cutomerID.AutoSizeMode = DataGridViewAutoSizeColumnMode.None
        cutomerID.HeaderText = "Customer ID"
        cutomerID.Name = "cutomerID"
        cutomerID.Width = 112
        ' 
        ' dateOrdered
        ' 
        dateOrdered.HeaderText = "Date"
        dateOrdered.Name = "dateOrdered"' 
        ' orderStatus
        ' 
        orderStatus.HeaderText = "Order Status"
        orderStatus.Name = "orderStatus"' 
        ' orderAmount
        ' 
        orderAmount.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
        orderAmount.HeaderText = "Total Amount"
        orderAmount.Name = "orderAmount"' 
        ' txtAmountDel
        ' 
        txtAmountDel.Location = New Point(733, 350)
        txtAmountDel.Name = "txtAmountDel"
        txtAmountDel.Size = New Size(254, 23)
        txtAmountDel.TabIndex = 27
        ' 
        ' txtOrderStatusDel
        ' 
        txtOrderStatusDel.Location = New Point(733, 313)
        txtOrderStatusDel.Name = "txtOrderStatusDel"
        txtOrderStatusDel.Size = New Size(254, 23)
        txtOrderStatusDel.TabIndex = 26
        ' 
        ' txtCustomDel
        ' 
        txtCustomDel.Location = New Point(733, 241)
        txtCustomDel.Name = "txtCustomDel"
        txtCustomDel.Size = New Size(254, 23)
        txtCustomDel.TabIndex = 24
        ' 
        ' txtOrderDel
        ' 
        txtOrderDel.Location = New Point(733, 204)
        txtOrderDel.Name = "txtOrderDel"
        txtOrderDel.Size = New Size(254, 23)
        txtOrderDel.TabIndex = 23
        ' 
        ' btnRefreshDel
        ' 
        btnRefreshDel.BackColor = Color.Silver
        btnRefreshDel.FlatStyle = FlatStyle.Popup
        btnRefreshDel.Font = New Font("Bookman Old Style", 9F, FontStyle.Regular, GraphicsUnit.Point)
        btnRefreshDel.Location = New Point(670, 462)
        btnRefreshDel.Name = "btnRefreshDel"
        btnRefreshDel.Size = New Size(128, 32)
        btnRefreshDel.TabIndex = 22
        btnRefreshDel.Text = "REFRESH"
        btnRefreshDel.UseVisualStyleBackColor = False
        ' 
        ' btnDeleteDel
        ' 
        btnDeleteDel.BackColor = Color.Silver
        btnDeleteDel.FlatStyle = FlatStyle.Popup
        btnDeleteDel.Font = New Font("Bookman Old Style", 9F, FontStyle.Regular, GraphicsUnit.Point)
        btnDeleteDel.Location = New Point(804, 411)
        btnDeleteDel.Name = "btnDeleteDel"
        btnDeleteDel.Size = New Size(128, 32)
        btnDeleteDel.TabIndex = 21
        btnDeleteDel.Text = "DELETE RECORD"
        btnDeleteDel.UseVisualStyleBackColor = False
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.BackColor = Color.Transparent
        Label4.Font = New Font("Bookman Old Style", 11.25F, FontStyle.Bold, GraphicsUnit.Point)
        Label4.ForeColor = Color.FromArgb(CByte(255), CByte(128), CByte(0))
        Label4.Location = New Point(592, 355)
        Label4.Name = "Label4"
        Label4.Size = New Size(79, 18)
        Label4.TabIndex = 20
        Label4.Text = "AMOUNT"' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.BackColor = Color.Transparent
        Label3.Font = New Font("Bookman Old Style", 11.25F, FontStyle.Bold, GraphicsUnit.Point)
        Label3.ForeColor = Color.FromArgb(CByte(255), CByte(128), CByte(0))
        Label3.Location = New Point(592, 318)
        Label3.Name = "Label3"
        Label3.Size = New Size(135, 18)
        Label3.TabIndex = 19
        Label3.Text = "ORDER STATUS"' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.BackColor = Color.Transparent
        Label2.Font = New Font("Bookman Old Style", 11.25F, FontStyle.Bold, GraphicsUnit.Point)
        Label2.ForeColor = Color.FromArgb(CByte(255), CByte(128), CByte(0))
        Label2.Location = New Point(592, 280)
        Label2.Name = "Label2"
        Label2.Size = New Size(52, 18)
        Label2.TabIndex = 18
        Label2.Text = "DATE"' 
        ' lblCustomerDel
        ' 
        lblCustomerDel.AutoSize = True
        lblCustomerDel.BackColor = Color.Transparent
        lblCustomerDel.Font = New Font("Bookman Old Style", 11.25F, FontStyle.Bold, GraphicsUnit.Point)
        lblCustomerDel.ForeColor = Color.FromArgb(CByte(255), CByte(128), CByte(0))
        lblCustomerDel.Location = New Point(592, 246)
        lblCustomerDel.Name = "lblCustomerDel"
        lblCustomerDel.Size = New Size(123, 18)
        lblCustomerDel.TabIndex = 17
        lblCustomerDel.Text = "CUSTOMER ID"' 
        ' lblDelOrder
        ' 
        lblDelOrder.AutoSize = True
        lblDelOrder.BackColor = Color.Transparent
        lblDelOrder.Font = New Font("Bookman Old Style", 11.25F, FontStyle.Bold, GraphicsUnit.Point)
        lblDelOrder.ForeColor = Color.FromArgb(CByte(255), CByte(128), CByte(0))
        lblDelOrder.Location = New Point(592, 209)
        lblDelOrder.Name = "lblDelOrder"
        lblDelOrder.Size = New Size(88, 18)
        lblDelOrder.TabIndex = 16
        lblDelOrder.Text = "ORDER ID"' 
        ' DateTimePicker1
        ' 
        DateTimePicker1.Location = New Point(733, 280)
        DateTimePicker1.Name = "DateTimePicker1"
        DateTimePicker1.Size = New Size(254, 23)
        DateTimePicker1.TabIndex = 28
        ' 
        ' Button1
        ' 
        Button1.BackColor = Color.Silver
        Button1.FlatStyle = FlatStyle.Popup
        Button1.Font = New Font("Bookman Old Style", 9F, FontStyle.Regular, GraphicsUnit.Point)
        Button1.Location = New Point(670, 411)
        Button1.Name = "Button1"
        Button1.Size = New Size(128, 32)
        Button1.TabIndex = 29
        Button1.Text = "ADD RECORD"
        Button1.UseVisualStyleBackColor = False
        ' 
        ' btnUploadFile
        ' 
        btnUploadFile.BackColor = Color.Silver
        btnUploadFile.FlatStyle = FlatStyle.Popup
        btnUploadFile.Font = New Font("Bookman Old Style", 9F, FontStyle.Regular, GraphicsUnit.Point)
        btnUploadFile.Location = New Point(804, 462)
        btnUploadFile.Name = "btnUploadFile"
        btnUploadFile.Size = New Size(128, 32)
        btnUploadFile.TabIndex = 31
        btnUploadFile.Text = "UPLOAD FILE"
        btnUploadFile.UseVisualStyleBackColor = False
        ' 
        ' DeliveryList
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), Image)
        ClientSize = New Size(1000, 545)
        Controls.Add(btnUploadFile)
        Controls.Add(Button1)
        Controls.Add(DateTimePicker1)
        Controls.Add(txtAmountDel)
        Controls.Add(txtOrderStatusDel)
        Controls.Add(txtCustomDel)
        Controls.Add(txtOrderDel)
        Controls.Add(btnRefreshDel)
        Controls.Add(btnDeleteDel)
        Controls.Add(Label4)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(lblCustomerDel)
        Controls.Add(lblDelOrder)
        Controls.Add(DataGridView1)
        Controls.Add(extDelivery)
        Name = "DeliveryList"
        Text = "DeliveryList"
        CType(DataGridView1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents extDelivery As Button
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents orderID As DataGridViewTextBoxColumn
    Friend WithEvents cutomerID As DataGridViewTextBoxColumn
    Friend WithEvents dateOrdered As DataGridViewTextBoxColumn
    Friend WithEvents orderStatus As DataGridViewTextBoxColumn
    Friend WithEvents orderAmount As DataGridViewTextBoxColumn
    Friend WithEvents txtAmountDel As TextBox
    Friend WithEvents txtOrderStatusDel As TextBox
    Friend WithEvents txtCustomDel As TextBox
    Friend WithEvents txtOrderDel As TextBox
    Friend WithEvents btnRefreshDel As Button
    Friend WithEvents btnDeleteDel As Button
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents lblCustomerDel As Label
    Friend WithEvents lblDelOrder As Label
    Friend WithEvents DateTimePicker1 As DateTimePicker
    Friend WithEvents Button1 As Button
    Friend WithEvents btnUploadFile As Button
End Class
