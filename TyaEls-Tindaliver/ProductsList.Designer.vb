<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ProductsList
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
        Dim resources As ComponentModel.ComponentResourceManager = New ComponentModel.ComponentResourceManager(GetType(ProductsList))
        extProduct = New Button()
        DataGridView1 = New DataGridView()
        prodID = New DataGridViewTextBoxColumn()
        prodName = New DataGridViewTextBoxColumn()
        prodDescription = New DataGridViewTextBoxColumn()
        prodPrice = New DataGridViewTextBoxColumn()
        categoryID = New DataGridViewTextBoxColumn()
        lblProdID = New Label()
        Label1 = New Label()
        Label2 = New Label()
        Label3 = New Label()
        Label4 = New Label()
        btnAppendProd = New Button()
        btnRefreshProd = New Button()
        TextBox1 = New TextBox()
        TextBox2 = New TextBox()
        TextBox3 = New TextBox()
        TextBox4 = New TextBox()
        TextBox5 = New TextBox()
        btnDelProd = New Button()
        CType(DataGridView1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' extProduct
        ' 
        extProduct.BackColor = Color.FromArgb(CByte(255), CByte(128), CByte(0))
        extProduct.FlatStyle = FlatStyle.Popup
        extProduct.Font = New Font("Bookman Old Style", 12F, FontStyle.Regular, GraphicsUnit.Point)
        extProduct.Location = New Point(895, 34)
        extProduct.Name = "extProduct"
        extProduct.Size = New Size(53, 53)
        extProduct.TabIndex = 2
        extProduct.Text = "X"
        extProduct.UseVisualStyleBackColor = False
        ' 
        ' DataGridView1
        ' 
        DataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridView1.Columns.AddRange(New DataGridViewColumn() {prodID, prodName, prodDescription, prodPrice, categoryID})
        DataGridView1.Location = New Point(24, 132)
        DataGridView1.Name = "DataGridView1"
        DataGridView1.RowTemplate.Height = 25
        DataGridView1.Size = New Size(547, 403)
        DataGridView1.TabIndex = 3
        ' 
        ' prodID
        ' 
        prodID.HeaderText = "Product ID"
        prodID.Name = "prodID"' 
        ' prodName
        ' 
        prodName.HeaderText = "Product"
        prodName.Name = "prodName"' 
        ' prodDescription
        ' 
        prodDescription.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
        prodDescription.HeaderText = "Description"
        prodDescription.Name = "prodDescription"' 
        ' prodPrice
        ' 
        prodPrice.HeaderText = "Amount"
        prodPrice.Name = "prodPrice"' 
        ' categoryID
        ' 
        categoryID.HeaderText = "Category"
        categoryID.Name = "categoryID"
        categoryID.Resizable = DataGridViewTriState.True
        categoryID.SortMode = DataGridViewColumnSortMode.NotSortable
        ' 
        ' lblProdID
        ' 
        lblProdID.AutoSize = True
        lblProdID.BackColor = Color.Transparent
        lblProdID.Font = New Font("Bookman Old Style", 11.25F, FontStyle.Bold, GraphicsUnit.Point)
        lblProdID.ForeColor = Color.FromArgb(CByte(255), CByte(128), CByte(0))
        lblProdID.Location = New Point(592, 189)
        lblProdID.Name = "lblProdID"
        lblProdID.Size = New Size(108, 18)
        lblProdID.TabIndex = 4
        lblProdID.Text = "PRODUCT ID"' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.BackColor = Color.Transparent
        Label1.Font = New Font("Bookman Old Style", 11.25F, FontStyle.Bold, GraphicsUnit.Point)
        Label1.ForeColor = Color.FromArgb(CByte(255), CByte(128), CByte(0))
        Label1.Location = New Point(594, 226)
        Label1.Name = "Label1"
        Label1.Size = New Size(86, 18)
        Label1.TabIndex = 5
        Label1.Text = "PRODUCT"' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.BackColor = Color.Transparent
        Label2.Font = New Font("Bookman Old Style", 11.25F, FontStyle.Bold, GraphicsUnit.Point)
        Label2.ForeColor = Color.FromArgb(CByte(255), CByte(128), CByte(0))
        Label2.Location = New Point(592, 262)
        Label2.Name = "Label2"
        Label2.Size = New Size(119, 18)
        Label2.TabIndex = 6
        Label2.Text = "DESCRIPTION"' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.BackColor = Color.Transparent
        Label3.Font = New Font("Bookman Old Style", 11.25F, FontStyle.Bold, GraphicsUnit.Point)
        Label3.ForeColor = Color.FromArgb(CByte(255), CByte(128), CByte(0))
        Label3.Location = New Point(594, 298)
        Label3.Name = "Label3"
        Label3.Size = New Size(79, 18)
        Label3.TabIndex = 7
        Label3.Text = "AMOUNT"' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.BackColor = Color.Transparent
        Label4.Font = New Font("Bookman Old Style", 11.25F, FontStyle.Bold, GraphicsUnit.Point)
        Label4.ForeColor = Color.FromArgb(CByte(255), CByte(128), CByte(0))
        Label4.Location = New Point(594, 335)
        Label4.Name = "Label4"
        Label4.Size = New Size(99, 18)
        Label4.TabIndex = 8
        Label4.Text = "CATEGORY"' 
        ' btnAppendProd
        ' 
        btnAppendProd.BackColor = Color.Silver
        btnAppendProd.FlatStyle = FlatStyle.Popup
        btnAppendProd.Font = New Font("Bookman Old Style", 9F, FontStyle.Regular, GraphicsUnit.Point)
        btnAppendProd.Location = New Point(695, 396)
        btnAppendProd.Name = "btnAppendProd"
        btnAppendProd.Size = New Size(179, 32)
        btnAppendProd.TabIndex = 9
        btnAppendProd.Text = "ADD RECORD"
        btnAppendProd.UseVisualStyleBackColor = False
        ' 
        ' btnRefreshProd
        ' 
        btnRefreshProd.BackColor = Color.Silver
        btnRefreshProd.FlatStyle = FlatStyle.Popup
        btnRefreshProd.Font = New Font("Bookman Old Style", 9F, FontStyle.Regular, GraphicsUnit.Point)
        btnRefreshProd.Location = New Point(695, 472)
        btnRefreshProd.Name = "btnRefreshProd"
        btnRefreshProd.Size = New Size(179, 32)
        btnRefreshProd.TabIndex = 10
        btnRefreshProd.Text = "REFRESH"
        btnRefreshProd.UseVisualStyleBackColor = False
        ' 
        ' TextBox1
        ' 
        TextBox1.Location = New Point(728, 184)
        TextBox1.Name = "TextBox1"
        TextBox1.Size = New Size(254, 23)
        TextBox1.TabIndex = 11
        ' 
        ' TextBox2
        ' 
        TextBox2.Location = New Point(728, 221)
        TextBox2.Name = "TextBox2"
        TextBox2.Size = New Size(254, 23)
        TextBox2.TabIndex = 12
        ' 
        ' TextBox3
        ' 
        TextBox3.Location = New Point(728, 257)
        TextBox3.Name = "TextBox3"
        TextBox3.Size = New Size(254, 23)
        TextBox3.TabIndex = 13
        ' 
        ' TextBox4
        ' 
        TextBox4.Location = New Point(728, 293)
        TextBox4.Name = "TextBox4"
        TextBox4.Size = New Size(254, 23)
        TextBox4.TabIndex = 14
        ' 
        ' TextBox5
        ' 
        TextBox5.Location = New Point(728, 330)
        TextBox5.Name = "TextBox5"
        TextBox5.Size = New Size(254, 23)
        TextBox5.TabIndex = 15
        ' 
        ' btnDelProd
        ' 
        btnDelProd.BackColor = Color.Silver
        btnDelProd.FlatStyle = FlatStyle.Popup
        btnDelProd.Font = New Font("Bookman Old Style", 9F, FontStyle.Regular, GraphicsUnit.Point)
        btnDelProd.Location = New Point(695, 434)
        btnDelProd.Name = "btnDelProd"
        btnDelProd.Size = New Size(179, 32)
        btnDelProd.TabIndex = 16
        btnDelProd.Text = "DELETE RECORD"
        btnDelProd.UseVisualStyleBackColor = False
        ' 
        ' ProductsList
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), Image)
        ClientSize = New Size(994, 567)
        Controls.Add(btnDelProd)
        Controls.Add(TextBox5)
        Controls.Add(TextBox4)
        Controls.Add(TextBox3)
        Controls.Add(TextBox2)
        Controls.Add(TextBox1)
        Controls.Add(btnRefreshProd)
        Controls.Add(btnAppendProd)
        Controls.Add(Label4)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Controls.Add(lblProdID)
        Controls.Add(DataGridView1)
        Controls.Add(extProduct)
        Name = "ProductsList"
        Text = "ProductsList"
        CType(DataGridView1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents extProduct As Button
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents lblProdID As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents btnAppendProd As Button
    Friend WithEvents btnRefreshProd As Button
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents TextBox4 As TextBox
    Friend WithEvents TextBox5 As TextBox
    Friend WithEvents prodID As DataGridViewTextBoxColumn
    Friend WithEvents prodName As DataGridViewTextBoxColumn
    Friend WithEvents prodDescription As DataGridViewTextBoxColumn
    Friend WithEvents prodPrice As DataGridViewTextBoxColumn
    Friend WithEvents categoryID As DataGridViewTextBoxColumn
    Friend WithEvents btnDelProd As Button
End Class
