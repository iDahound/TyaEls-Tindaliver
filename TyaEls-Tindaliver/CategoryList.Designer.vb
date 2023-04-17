<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CategoryList
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
        Dim resources As ComponentModel.ComponentResourceManager = New ComponentModel.ComponentResourceManager(GetType(CategoryList))
        extCategory = New Button()
        txtcatnameCAT = New TextBox()
        txtcatdesCAT = New TextBox()
        txtcatidCAT = New TextBox()
        btnRefreshCat = New Button()
        btnAppendCat = New Button()
        Label2 = New Label()
        Label1 = New Label()
        lblProdID = New Label()
        DataGridView1 = New DataGridView()
        categoryID = New DataGridViewTextBoxColumn()
        categoryName = New DataGridViewTextBoxColumn()
        categoryDescription = New DataGridViewTextBoxColumn()
        PictureBox1 = New PictureBox()
        btnDelCat = New Button()
        CType(DataGridView1, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' extCategory
        ' 
        extCategory.BackColor = Color.FromArgb(CByte(255), CByte(128), CByte(0))
        extCategory.FlatStyle = FlatStyle.Popup
        extCategory.Font = New Font("Bookman Old Style", 12F, FontStyle.Regular, GraphicsUnit.Point)
        extCategory.Location = New Point(897, 33)
        extCategory.Name = "extCategory"
        extCategory.Size = New Size(53, 53)
        extCategory.TabIndex = 1
        extCategory.Text = "X"
        extCategory.UseVisualStyleBackColor = False
        ' 
        ' txtcatnameCAT
        ' 
        txtcatnameCAT.Location = New Point(604, 373)
        txtcatnameCAT.Name = "txtcatnameCAT"
        txtcatnameCAT.Size = New Size(384, 23)
        txtcatnameCAT.TabIndex = 25
        ' 
        ' txtcatdesCAT
        ' 
        txtcatdesCAT.Location = New Point(602, 440)
        txtcatdesCAT.Name = "txtcatdesCAT"
        txtcatdesCAT.Size = New Size(386, 23)
        txtcatdesCAT.TabIndex = 24
        ' 
        ' txtcatidCAT
        ' 
        txtcatidCAT.Location = New Point(604, 303)
        txtcatidCAT.Name = "txtcatidCAT"
        txtcatidCAT.Size = New Size(384, 23)
        txtcatidCAT.TabIndex = 23
        ' 
        ' btnRefreshCat
        ' 
        btnRefreshCat.BackColor = Color.Silver
        btnRefreshCat.FlatStyle = FlatStyle.Popup
        btnRefreshCat.Font = New Font("Bookman Old Style", 9F, FontStyle.Regular, GraphicsUnit.Point)
        btnRefreshCat.Location = New Point(863, 170)
        btnRefreshCat.Name = "btnRefreshCat"
        btnRefreshCat.Size = New Size(125, 32)
        btnRefreshCat.TabIndex = 22
        btnRefreshCat.Text = "REFRESH"
        btnRefreshCat.UseVisualStyleBackColor = False
        ' 
        ' btnAppendCat
        ' 
        btnAppendCat.BackColor = Color.Silver
        btnAppendCat.FlatStyle = FlatStyle.Popup
        btnAppendCat.Font = New Font("Bookman Old Style", 9F, FontStyle.Regular, GraphicsUnit.Point)
        btnAppendCat.Location = New Point(602, 170)
        btnAppendCat.Name = "btnAppendCat"
        btnAppendCat.Size = New Size(125, 32)
        btnAppendCat.TabIndex = 21
        btnAppendCat.Text = "ADD RECORD"
        btnAppendCat.UseVisualStyleBackColor = False
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.BackColor = Color.Transparent
        Label2.Font = New Font("Bookman Old Style", 11.25F, FontStyle.Bold, GraphicsUnit.Point)
        Label2.ForeColor = Color.FromArgb(CByte(255), CByte(128), CByte(0))
        Label2.Location = New Point(604, 419)
        Label2.Name = "Label2"
        Label2.Size = New Size(119, 18)
        Label2.TabIndex = 18
        Label2.Text = "DESCRIPTION"' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.BackColor = Color.Transparent
        Label1.Font = New Font("Bookman Old Style", 11.25F, FontStyle.Bold, GraphicsUnit.Point)
        Label1.ForeColor = Color.FromArgb(CByte(255), CByte(128), CByte(0))
        Label1.Location = New Point(604, 342)
        Label1.Name = "Label1"
        Label1.Size = New Size(152, 18)
        Label1.TabIndex = 17
        Label1.Text = "CATEGORY NAME"' 
        ' lblProdID
        ' 
        lblProdID.AutoSize = True
        lblProdID.BackColor = Color.Transparent
        lblProdID.Font = New Font("Bookman Old Style", 11.25F, FontStyle.Bold, GraphicsUnit.Point)
        lblProdID.ForeColor = Color.FromArgb(CByte(255), CByte(128), CByte(0))
        lblProdID.Location = New Point(606, 282)
        lblProdID.Name = "lblProdID"
        lblProdID.Size = New Size(121, 18)
        lblProdID.TabIndex = 16
        lblProdID.Text = "CATEGORY ID"' 
        ' DataGridView1
        ' 
        DataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridView1.Columns.AddRange(New DataGridViewColumn() {categoryID, categoryName, categoryDescription})
        DataGridView1.Location = New Point(12, 136)
        DataGridView1.Name = "DataGridView1"
        DataGridView1.RowTemplate.Height = 25
        DataGridView1.Size = New Size(555, 382)
        DataGridView1.TabIndex = 28
        ' 
        ' categoryID
        ' 
        categoryID.HeaderText = "Category ID"
        categoryID.Name = "categoryID"' 
        ' categoryName
        ' 
        categoryName.HeaderText = "Category Name"
        categoryName.Name = "categoryName"
        categoryName.Width = 150
        ' 
        ' categoryDescription
        ' 
        categoryDescription.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
        categoryDescription.HeaderText = "Description"
        categoryDescription.Name = "categoryDescription"' 
        ' PictureBox1
        ' 
        PictureBox1.BackColor = Color.Transparent
        PictureBox1.BackgroundImage = CType(resources.GetObject("PictureBox1.BackgroundImage"), Image)
        PictureBox1.Location = New Point(592, 155)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(411, 390)
        PictureBox1.TabIndex = 29
        PictureBox1.TabStop = False
        ' 
        ' btnDelCat
        ' 
        btnDelCat.BackColor = Color.Silver
        btnDelCat.FlatStyle = FlatStyle.Popup
        btnDelCat.Font = New Font("Bookman Old Style", 9F, FontStyle.Regular, GraphicsUnit.Point)
        btnDelCat.Location = New Point(733, 170)
        btnDelCat.Name = "btnDelCat"
        btnDelCat.Size = New Size(125, 32)
        btnDelCat.TabIndex = 30
        btnDelCat.Text = "DELETE RECORD"
        btnDelCat.UseVisualStyleBackColor = False
        ' 
        ' CategoryList
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), Image)
        ClientSize = New Size(1000, 540)
        Controls.Add(btnDelCat)
        Controls.Add(DataGridView1)
        Controls.Add(txtcatnameCAT)
        Controls.Add(txtcatdesCAT)
        Controls.Add(txtcatidCAT)
        Controls.Add(btnRefreshCat)
        Controls.Add(btnAppendCat)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Controls.Add(lblProdID)
        Controls.Add(extCategory)
        Controls.Add(PictureBox1)
        Name = "CategoryList"
        Text = "CategoryList"
        CType(DataGridView1, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents extCategory As Button
    Friend WithEvents txtcatnameCAT As TextBox
    Friend WithEvents txtcatdesCAT As TextBox
    Friend WithEvents txtcatidCAT As TextBox
    Friend WithEvents btnRefreshCat As Button
    Friend WithEvents btnAppendCat As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents lblProdID As Label
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents categoryID As DataGridViewTextBoxColumn
    Friend WithEvents categoryName As DataGridViewTextBoxColumn
    Friend WithEvents categoryDescription As DataGridViewTextBoxColumn
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents btnDelCat As Button
End Class
