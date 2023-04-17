<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CustomerList
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
        Dim resources As ComponentModel.ComponentResourceManager = New ComponentModel.ComponentResourceManager(GetType(CustomerList))
        extCustomer = New Button()
        DataGridView1 = New DataGridView()
        customerID = New DataGridViewTextBoxColumn()
        customerName = New DataGridViewTextBoxColumn()
        customerEmail = New DataGridViewTextBoxColumn()
        customerNum = New DataGridViewTextBoxColumn()
        customerAddress = New DataGridViewTextBoxColumn()
        txtCusPhone = New TextBox()
        txtCusAddress = New TextBox()
        txtCusEmail = New TextBox()
        txtCusName = New TextBox()
        txtCusID = New TextBox()
        btnExportCus = New Button()
        btnAppendCus = New Button()
        lblphonenumCUS = New Label()
        lblemailCUS = New Label()
        lbladdressCUS = New Label()
        lblfullnameCUS = New Label()
        lblcustomeridCUS = New Label()
        btnDelCus = New Button()
        btnUpUs = New Button()
        CType(DataGridView1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' extCustomer
        ' 
        extCustomer.BackColor = Color.FromArgb(CByte(255), CByte(128), CByte(0))
        extCustomer.FlatStyle = FlatStyle.Popup
        extCustomer.Font = New Font("Bookman Old Style", 12F, FontStyle.Regular, GraphicsUnit.Point)
        extCustomer.Location = New Point(898, 33)
        extCustomer.Name = "extCustomer"
        extCustomer.Size = New Size(53, 53)
        extCustomer.TabIndex = 0
        extCustomer.Text = "X"
        extCustomer.UseVisualStyleBackColor = False
        ' 
        ' DataGridView1
        ' 
        DataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridView1.Columns.AddRange(New DataGridViewColumn() {customerID, customerName, customerEmail, customerNum, customerAddress})
        DataGridView1.Location = New Point(14, 128)
        DataGridView1.Name = "DataGridView1"
        DataGridView1.RowTemplate.Height = 25
        DataGridView1.Size = New Size(606, 394)
        DataGridView1.TabIndex = 1
        ' 
        ' customerID
        ' 
        customerID.HeaderText = "Customer ID"
        customerID.Name = "customerID"
        customerID.Width = 80
        ' 
        ' customerName
        ' 
        customerName.HeaderText = "Full Name"
        customerName.Name = "customerName"' 
        ' customerEmail
        ' 
        customerEmail.HeaderText = "Email"
        customerEmail.Name = "customerEmail"' 
        ' customerNum
        ' 
        customerNum.HeaderText = "Phone Number"
        customerNum.Name = "customerNum"
        customerNum.Width = 120
        ' 
        ' customerAddress
        ' 
        customerAddress.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
        customerAddress.HeaderText = "Address"
        customerAddress.Name = "customerAddress"' 
        ' txtCusPhone
        ' 
        txtCusPhone.Location = New Point(683, 343)
        txtCusPhone.Name = "txtCusPhone"
        txtCusPhone.Size = New Size(254, 23)
        txtCusPhone.TabIndex = 27
        ' 
        ' txtCusAddress
        ' 
        txtCusAddress.Location = New Point(683, 401)
        txtCusAddress.Name = "txtCusAddress"
        txtCusAddress.Size = New Size(254, 23)
        txtCusAddress.TabIndex = 26
        ' 
        ' txtCusEmail
        ' 
        txtCusEmail.Location = New Point(683, 284)
        txtCusEmail.Name = "txtCusEmail"
        txtCusEmail.Size = New Size(254, 23)
        txtCusEmail.TabIndex = 25
        ' 
        ' txtCusName
        ' 
        txtCusName.Location = New Point(683, 228)
        txtCusName.Name = "txtCusName"
        txtCusName.Size = New Size(254, 23)
        txtCusName.TabIndex = 24
        ' 
        ' txtCusID
        ' 
        txtCusID.Location = New Point(683, 172)
        txtCusID.Name = "txtCusID"
        txtCusID.Size = New Size(254, 23)
        txtCusID.TabIndex = 23
        ' 
        ' btnExportCus
        ' 
        btnExportCus.BackColor = Color.Silver
        btnExportCus.FlatStyle = FlatStyle.Popup
        btnExportCus.Font = New Font("Bookman Old Style", 9F, FontStyle.Regular, GraphicsUnit.Point)
        btnExportCus.Location = New Point(658, 486)
        btnExportCus.Name = "btnExportCus"
        btnExportCus.Size = New Size(146, 32)
        btnExportCus.TabIndex = 22
        btnExportCus.Text = "EXPORT FILE"
        btnExportCus.UseVisualStyleBackColor = False
        ' 
        ' btnAppendCus
        ' 
        btnAppendCus.BackColor = Color.Silver
        btnAppendCus.FlatStyle = FlatStyle.Popup
        btnAppendCus.Font = New Font("Bookman Old Style", 9F, FontStyle.Regular, GraphicsUnit.Point)
        btnAppendCus.Location = New Point(658, 448)
        btnAppendCus.Name = "btnAppendCus"
        btnAppendCus.Size = New Size(146, 32)
        btnAppendCus.TabIndex = 21
        btnAppendCus.Text = "ADD RECORD"
        btnAppendCus.UseVisualStyleBackColor = False
        ' 
        ' lblphonenumCUS
        ' 
        lblphonenumCUS.AutoSize = True
        lblphonenumCUS.BackColor = Color.Transparent
        lblphonenumCUS.Font = New Font("Bookman Old Style", 11.25F, FontStyle.Bold, GraphicsUnit.Point)
        lblphonenumCUS.ForeColor = Color.FromArgb(CByte(255), CByte(128), CByte(0))
        lblphonenumCUS.Location = New Point(683, 322)
        lblphonenumCUS.Name = "lblphonenumCUS"
        lblphonenumCUS.Size = New Size(140, 18)
        lblphonenumCUS.TabIndex = 20
        lblphonenumCUS.Text = "PHONE NUMBER"' 
        ' lblemailCUS
        ' 
        lblemailCUS.AutoSize = True
        lblemailCUS.BackColor = Color.Transparent
        lblemailCUS.Font = New Font("Bookman Old Style", 11.25F, FontStyle.Bold, GraphicsUnit.Point)
        lblemailCUS.ForeColor = Color.FromArgb(CByte(255), CByte(128), CByte(0))
        lblemailCUS.Location = New Point(683, 263)
        lblemailCUS.Name = "lblemailCUS"
        lblemailCUS.Size = New Size(61, 18)
        lblemailCUS.TabIndex = 19
        lblemailCUS.Text = "EMAIL"' 
        ' lbladdressCUS
        ' 
        lbladdressCUS.AutoSize = True
        lbladdressCUS.BackColor = Color.Transparent
        lbladdressCUS.Font = New Font("Bookman Old Style", 11.25F, FontStyle.Bold, GraphicsUnit.Point)
        lbladdressCUS.ForeColor = Color.FromArgb(CByte(255), CByte(128), CByte(0))
        lbladdressCUS.Location = New Point(683, 380)
        lbladdressCUS.Name = "lbladdressCUS"
        lbladdressCUS.Size = New Size(84, 18)
        lbladdressCUS.TabIndex = 18
        lbladdressCUS.Text = "ADDRESS"' 
        ' lblfullnameCUS
        ' 
        lblfullnameCUS.AutoSize = True
        lblfullnameCUS.BackColor = Color.Transparent
        lblfullnameCUS.Font = New Font("Bookman Old Style", 11.25F, FontStyle.Bold, GraphicsUnit.Point)
        lblfullnameCUS.ForeColor = Color.FromArgb(CByte(255), CByte(128), CByte(0))
        lblfullnameCUS.Location = New Point(683, 207)
        lblfullnameCUS.Name = "lblfullnameCUS"
        lblfullnameCUS.Size = New Size(102, 18)
        lblfullnameCUS.TabIndex = 17
        lblfullnameCUS.Text = "FULL NAME"' 
        ' lblcustomeridCUS
        ' 
        lblcustomeridCUS.AutoSize = True
        lblcustomeridCUS.BackColor = Color.Transparent
        lblcustomeridCUS.Font = New Font("Bookman Old Style", 11.25F, FontStyle.Bold, GraphicsUnit.Point)
        lblcustomeridCUS.ForeColor = Color.FromArgb(CByte(255), CByte(128), CByte(0))
        lblcustomeridCUS.Location = New Point(683, 151)
        lblcustomeridCUS.Name = "lblcustomeridCUS"
        lblcustomeridCUS.Size = New Size(123, 18)
        lblcustomeridCUS.TabIndex = 16
        lblcustomeridCUS.Text = "CUSTOMER ID"' 
        ' btnDelCus
        ' 
        btnDelCus.BackColor = Color.Silver
        btnDelCus.FlatStyle = FlatStyle.Popup
        btnDelCus.Font = New Font("Bookman Old Style", 9F, FontStyle.Regular, GraphicsUnit.Point)
        btnDelCus.Location = New Point(813, 448)
        btnDelCus.Name = "btnDelCus"
        btnDelCus.Size = New Size(146, 32)
        btnDelCus.TabIndex = 28
        btnDelCus.Text = "DELETE RECORD"
        btnDelCus.UseVisualStyleBackColor = False
        ' 
        ' btnUpUs
        ' 
        btnUpUs.BackColor = Color.Silver
        btnUpUs.FlatStyle = FlatStyle.Popup
        btnUpUs.Font = New Font("Bookman Old Style", 9F, FontStyle.Regular, GraphicsUnit.Point)
        btnUpUs.Location = New Point(813, 486)
        btnUpUs.Name = "btnUpUs"
        btnUpUs.Size = New Size(146, 32)
        btnUpUs.TabIndex = 29
        btnUpUs.Text = "UPLOAD FILE"
        btnUpUs.UseVisualStyleBackColor = False
        ' 
        ' CustomerList
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), Image)
        ClientSize = New Size(989, 549)
        Controls.Add(btnUpUs)
        Controls.Add(btnDelCus)
        Controls.Add(txtCusPhone)
        Controls.Add(txtCusAddress)
        Controls.Add(txtCusEmail)
        Controls.Add(txtCusName)
        Controls.Add(txtCusID)
        Controls.Add(btnExportCus)
        Controls.Add(btnAppendCus)
        Controls.Add(lblphonenumCUS)
        Controls.Add(lblemailCUS)
        Controls.Add(lbladdressCUS)
        Controls.Add(lblfullnameCUS)
        Controls.Add(lblcustomeridCUS)
        Controls.Add(DataGridView1)
        Controls.Add(extCustomer)
        Name = "CustomerList"
        Text = "CustomerList"
        CType(DataGridView1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents extCustomer As Button
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents customerID As DataGridViewTextBoxColumn
    Friend WithEvents customerName As DataGridViewTextBoxColumn
    Friend WithEvents customerEmail As DataGridViewTextBoxColumn
    Friend WithEvents customerNum As DataGridViewTextBoxColumn
    Friend WithEvents customerAddress As DataGridViewTextBoxColumn
    Friend WithEvents txtCusPhone As TextBox
    Friend WithEvents txtCusAddress As TextBox
    Friend WithEvents txtCusEmail As TextBox
    Friend WithEvents txtCusName As TextBox
    Friend WithEvents txtCusID As TextBox
    Friend WithEvents btnExportCus As Button
    Friend WithEvents btnAppendCus As Button
    Friend WithEvents lblphonenumCUS As Label
    Friend WithEvents lblemailCUS As Label
    Friend WithEvents lbladdressCUS As Label
    Friend WithEvents lblfullnameCUS As Label
    Friend WithEvents lblcustomeridCUS As Label
    Friend WithEvents btnDelCus As Button
    Friend WithEvents btnUpUs As Button
End Class
