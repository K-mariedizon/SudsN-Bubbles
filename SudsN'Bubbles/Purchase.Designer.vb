<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Purchase
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Purchase))
        btnService = New Button()
        btnCustomer = New Button()
        btnPurchase = New Button()
        btnDB = New Button()
        Label3 = New Label()
        PictureBox7 = New PictureBox()
        PictureBox8 = New PictureBox()
        PictureBox9 = New PictureBox()
        btnLogout = New Button()
        btnAccount = New Button()
        dgCustomer = New DataGridView()
        PictureBox12 = New PictureBox()
        Panel3 = New Panel()
        txtSearch = New TextBox()
        PictureBox10 = New PictureBox()
        CType(PictureBox7, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox8, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox9, ComponentModel.ISupportInitialize).BeginInit()
        CType(dgCustomer, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox12, ComponentModel.ISupportInitialize).BeginInit()
        Panel3.SuspendLayout()
        CType(PictureBox10, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' btnService
        ' 
        btnService.BackColor = Color.Transparent
        btnService.BackgroundImage = CType(resources.GetObject("btnService.BackgroundImage"), Image)
        btnService.FlatStyle = FlatStyle.Flat
        btnService.ForeColor = Color.FromArgb(CByte(252), CByte(252), CByte(252))
        btnService.Location = New Point(17, 319)
        btnService.Name = "btnService"
        btnService.Size = New Size(34, 42)
        btnService.TabIndex = 37
        btnService.UseVisualStyleBackColor = False
        ' 
        ' btnCustomer
        ' 
        btnCustomer.BackColor = Color.Transparent
        btnCustomer.BackgroundImage = CType(resources.GetObject("btnCustomer.BackgroundImage"), Image)
        btnCustomer.FlatStyle = FlatStyle.Flat
        btnCustomer.ForeColor = Color.FromArgb(CByte(252), CByte(252), CByte(252))
        btnCustomer.Location = New Point(10, 242)
        btnCustomer.Name = "btnCustomer"
        btnCustomer.Size = New Size(50, 37)
        btnCustomer.TabIndex = 36
        btnCustomer.UseVisualStyleBackColor = False
        ' 
        ' btnPurchase
        ' 
        btnPurchase.BackColor = Color.Transparent
        btnPurchase.BackgroundImage = CType(resources.GetObject("btnPurchase.BackgroundImage"), Image)
        btnPurchase.FlatStyle = FlatStyle.Flat
        btnPurchase.ForeColor = Color.FromArgb(CByte(252), CByte(252), CByte(252))
        btnPurchase.Location = New Point(8, 151)
        btnPurchase.Name = "btnPurchase"
        btnPurchase.Size = New Size(55, 55)
        btnPurchase.TabIndex = 34
        btnPurchase.UseVisualStyleBackColor = False
        ' 
        ' btnDB
        ' 
        btnDB.BackColor = Color.Transparent
        btnDB.BackgroundImage = CType(resources.GetObject("btnDB.BackgroundImage"), Image)
        btnDB.FlatStyle = FlatStyle.Flat
        btnDB.ForeColor = Color.FromArgb(CByte(252), CByte(252), CByte(252))
        btnDB.Location = New Point(16, 83)
        btnDB.Name = "btnDB"
        btnDB.Size = New Size(37, 37)
        btnDB.TabIndex = 33
        btnDB.UseVisualStyleBackColor = False
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.BackColor = Color.FromArgb(CByte(252), CByte(252), CByte(252))
        Label3.Font = New Font("Arial Narrow", 19.2F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label3.ForeColor = SystemColors.ActiveCaptionText
        Label3.Location = New Point(78, 9)
        Label3.Name = "Label3"
        Label3.Size = New Size(218, 37)
        Label3.TabIndex = 32
        Label3.Text = "Purchase Details"
        ' 
        ' PictureBox7
        ' 
        PictureBox7.BackgroundImage = CType(resources.GetObject("PictureBox7.BackgroundImage"), Image)
        PictureBox7.Location = New Point(0, -2)
        PictureBox7.Name = "PictureBox7"
        PictureBox7.Size = New Size(72, 61)
        PictureBox7.TabIndex = 31
        PictureBox7.TabStop = False
        ' 
        ' PictureBox8
        ' 
        PictureBox8.BackColor = Color.White
        PictureBox8.BackgroundImage = CType(resources.GetObject("PictureBox8.BackgroundImage"), Image)
        PictureBox8.Location = New Point(63, 0)
        PictureBox8.Name = "PictureBox8"
        PictureBox8.Size = New Size(1226, 59)
        PictureBox8.TabIndex = 30
        PictureBox8.TabStop = False
        ' 
        ' PictureBox9
        ' 
        PictureBox9.BackgroundImage = CType(resources.GetObject("PictureBox9.BackgroundImage"), Image)
        PictureBox9.Location = New Point(0, 0)
        PictureBox9.Name = "PictureBox9"
        PictureBox9.Size = New Size(72, 811)
        PictureBox9.TabIndex = 29
        PictureBox9.TabStop = False
        ' 
        ' btnLogout
        ' 
        btnLogout.BackColor = Color.FromArgb(CByte(252), CByte(252), CByte(252))
        btnLogout.BackgroundImage = CType(resources.GetObject("btnLogout.BackgroundImage"), Image)
        btnLogout.FlatStyle = FlatStyle.Flat
        btnLogout.ForeColor = Color.FromArgb(CByte(252), CByte(252), CByte(252))
        btnLogout.Location = New Point(17, 739)
        btnLogout.Name = "btnLogout"
        btnLogout.Size = New Size(38, 39)
        btnLogout.TabIndex = 39
        btnLogout.UseVisualStyleBackColor = False
        ' 
        ' btnAccount
        ' 
        btnAccount.BackColor = Color.FromArgb(CByte(252), CByte(252), CByte(252))
        btnAccount.BackgroundImage = CType(resources.GetObject("btnAccount.BackgroundImage"), Image)
        btnAccount.FlatStyle = FlatStyle.Flat
        btnAccount.ForeColor = Color.FromArgb(CByte(252), CByte(252), CByte(252))
        btnAccount.Location = New Point(18, 680)
        btnAccount.Name = "btnAccount"
        btnAccount.Size = New Size(36, 40)
        btnAccount.TabIndex = 38
        btnAccount.UseVisualStyleBackColor = False
        ' 
        ' dgCustomer
        ' 
        dgCustomer.BackgroundColor = SystemColors.ButtonFace
        dgCustomer.BorderStyle = BorderStyle.None
        dgCustomer.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dgCustomer.Location = New Point(132, 187)
        dgCustomer.Name = "dgCustomer"
        dgCustomer.RowHeadersWidth = 51
        dgCustomer.Size = New Size(1085, 533)
        dgCustomer.TabIndex = 42
        ' 
        ' PictureBox12
        ' 
        PictureBox12.BackgroundImage = CType(resources.GetObject("PictureBox12.BackgroundImage"), Image)
        PictureBox12.Location = New Point(108, 161)
        PictureBox12.Name = "PictureBox12"
        PictureBox12.Size = New Size(1136, 585)
        PictureBox12.TabIndex = 41
        PictureBox12.TabStop = False
        ' 
        ' Panel3
        ' 
        Panel3.BorderStyle = BorderStyle.FixedSingle
        Panel3.Controls.Add(txtSearch)
        Panel3.Controls.Add(PictureBox10)
        Panel3.ForeColor = SystemColors.ControlDarkDark
        Panel3.Location = New Point(108, 109)
        Panel3.Margin = New Padding(4, 3, 4, 3)
        Panel3.Name = "Panel3"
        Panel3.Size = New Size(381, 33)
        Panel3.TabIndex = 40
        ' 
        ' txtSearch
        ' 
        txtSearch.BorderStyle = BorderStyle.None
        txtSearch.Font = New Font("Arial", 10.8F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        txtSearch.ForeColor = Color.DimGray
        txtSearch.Location = New Point(41, 4)
        txtSearch.Margin = New Padding(4, 3, 4, 3)
        txtSearch.Name = "txtSearch"
        txtSearch.Size = New Size(333, 21)
        txtSearch.TabIndex = 4
        ' 
        ' PictureBox10
        ' 
        PictureBox10.BackgroundImage = CType(resources.GetObject("PictureBox10.BackgroundImage"), Image)
        PictureBox10.Location = New Point(8, 3)
        PictureBox10.Name = "PictureBox10"
        PictureBox10.Size = New Size(26, 27)
        PictureBox10.TabIndex = 19
        PictureBox10.TabStop = False
        ' 
        ' Purchase
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.White
        ClientSize = New Size(1289, 809)
        Controls.Add(dgCustomer)
        Controls.Add(PictureBox12)
        Controls.Add(Panel3)
        Controls.Add(btnLogout)
        Controls.Add(btnAccount)
        Controls.Add(btnService)
        Controls.Add(btnCustomer)
        Controls.Add(btnPurchase)
        Controls.Add(btnDB)
        Controls.Add(Label3)
        Controls.Add(PictureBox7)
        Controls.Add(PictureBox8)
        Controls.Add(PictureBox9)
        Name = "Purchase"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Purchase"
        CType(PictureBox7, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox8, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox9, ComponentModel.ISupportInitialize).EndInit()
        CType(dgCustomer, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox12, ComponentModel.ISupportInitialize).EndInit()
        Panel3.ResumeLayout(False)
        Panel3.PerformLayout()
        CType(PictureBox10, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents btnService As Button
    Friend WithEvents btnCustomer As Button
    Friend WithEvents btnPurchase As Button
    Friend WithEvents btnDB As Button
    Friend WithEvents Label3 As Label
    Friend WithEvents PictureBox7 As PictureBox
    Friend WithEvents PictureBox8 As PictureBox
    Friend WithEvents PictureBox9 As PictureBox
    Friend WithEvents btnLogout As Button
    Friend WithEvents btnAccount As Button
    Friend WithEvents dgCustomer As DataGridView
    Friend WithEvents PictureBox12 As PictureBox
    Friend WithEvents Panel3 As Panel
    Friend WithEvents txtSearch As TextBox
    Friend WithEvents PictureBox10 As PictureBox
End Class
