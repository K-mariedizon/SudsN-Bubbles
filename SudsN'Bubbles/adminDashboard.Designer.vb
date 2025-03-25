<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class adminDashboard
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(adminDashboard))
        PictureBox1 = New PictureBox()
        PictureBox2 = New PictureBox()
        PictureBox3 = New PictureBox()
        Label1 = New Label()
        btnPurchase = New Button()
        btnAccount = New Button()
        btnLogout = New Button()
        btnService = New Button()
        btnCustomer = New Button()
        btnReport = New Button()
        PictureBox4 = New PictureBox()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox2, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox3, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox4, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' PictureBox1
        ' 
        PictureBox1.BackgroundImage = CType(resources.GetObject("PictureBox1.BackgroundImage"), Image)
        PictureBox1.Location = New Point(1, 0)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(72, 811)
        PictureBox1.TabIndex = 0
        PictureBox1.TabStop = False
        ' 
        ' PictureBox2
        ' 
        PictureBox2.BackColor = Color.White
        PictureBox2.BackgroundImage = CType(resources.GetObject("PictureBox2.BackgroundImage"), Image)
        PictureBox2.Location = New Point(64, 0)
        PictureBox2.Name = "PictureBox2"
        PictureBox2.Size = New Size(1226, 59)
        PictureBox2.TabIndex = 1
        PictureBox2.TabStop = False
        ' 
        ' PictureBox3
        ' 
        PictureBox3.BackgroundImage = CType(resources.GetObject("PictureBox3.BackgroundImage"), Image)
        PictureBox3.Location = New Point(-9, -2)
        PictureBox3.Name = "PictureBox3"
        PictureBox3.Size = New Size(82, 61)
        PictureBox3.TabIndex = 2
        PictureBox3.TabStop = False
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.BackColor = Color.FromArgb(CByte(252), CByte(252), CByte(252))
        Label1.Font = New Font("Arial Narrow", 19.2F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label1.ForeColor = SystemColors.ActiveCaptionText
        Label1.Location = New Point(79, 9)
        Label1.Name = "Label1"
        Label1.Size = New Size(148, 37)
        Label1.TabIndex = 3
        Label1.Text = "Dashboard"
        ' 
        ' btnPurchase
        ' 
        btnPurchase.BackColor = Color.White
        btnPurchase.BackgroundImage = CType(resources.GetObject("btnPurchase.BackgroundImage"), Image)
        btnPurchase.BackgroundImageLayout = ImageLayout.None
        btnPurchase.FlatStyle = FlatStyle.Flat
        btnPurchase.ForeColor = Color.Transparent
        btnPurchase.ImageAlign = ContentAlignment.TopLeft
        btnPurchase.Location = New Point(206, 262)
        btnPurchase.Name = "btnPurchase"
        btnPurchase.Size = New Size(230, 240)
        btnPurchase.TabIndex = 4
        btnPurchase.TextAlign = ContentAlignment.TopLeft
        btnPurchase.UseVisualStyleBackColor = False
        ' 
        ' btnAccount
        ' 
        btnAccount.BackColor = Color.FromArgb(CByte(252), CByte(252), CByte(252))
        btnAccount.BackgroundImage = CType(resources.GetObject("btnAccount.BackgroundImage"), Image)
        btnAccount.FlatStyle = FlatStyle.Flat
        btnAccount.ForeColor = Color.FromArgb(CByte(252), CByte(252), CByte(252))
        btnAccount.Location = New Point(16, 683)
        btnAccount.Name = "btnAccount"
        btnAccount.Size = New Size(36, 40)
        btnAccount.TabIndex = 5
        btnAccount.UseVisualStyleBackColor = False
        ' 
        ' btnLogout
        ' 
        btnLogout.BackColor = Color.FromArgb(CByte(252), CByte(252), CByte(252))
        btnLogout.BackgroundImage = CType(resources.GetObject("btnLogout.BackgroundImage"), Image)
        btnLogout.FlatStyle = FlatStyle.Flat
        btnLogout.ForeColor = Color.FromArgb(CByte(252), CByte(252), CByte(252))
        btnLogout.Location = New Point(16, 743)
        btnLogout.Name = "btnLogout"
        btnLogout.Size = New Size(38, 39)
        btnLogout.TabIndex = 6
        btnLogout.UseVisualStyleBackColor = False
        ' 
        ' btnService
        ' 
        btnService.BackColor = Color.White
        btnService.BackgroundImage = CType(resources.GetObject("btnService.BackgroundImage"), Image)
        btnService.BackgroundImageLayout = ImageLayout.None
        btnService.FlatStyle = FlatStyle.Flat
        btnService.ForeColor = Color.Transparent
        btnService.ImageAlign = ContentAlignment.TopLeft
        btnService.Location = New Point(695, 262)
        btnService.Name = "btnService"
        btnService.Size = New Size(227, 240)
        btnService.TabIndex = 7
        btnService.TextAlign = ContentAlignment.TopLeft
        btnService.UseVisualStyleBackColor = False
        ' 
        ' btnCustomer
        ' 
        btnCustomer.BackColor = Color.White
        btnCustomer.BackgroundImage = CType(resources.GetObject("btnCustomer.BackgroundImage"), Image)
        btnCustomer.BackgroundImageLayout = ImageLayout.None
        btnCustomer.FlatStyle = FlatStyle.Flat
        btnCustomer.ForeColor = Color.Transparent
        btnCustomer.ImageAlign = ContentAlignment.TopLeft
        btnCustomer.Location = New Point(452, 262)
        btnCustomer.Name = "btnCustomer"
        btnCustomer.Size = New Size(226, 240)
        btnCustomer.TabIndex = 8
        btnCustomer.TextAlign = ContentAlignment.TopLeft
        btnCustomer.UseVisualStyleBackColor = False
        ' 
        ' btnReport
        ' 
        btnReport.BackColor = Color.White
        btnReport.BackgroundImage = CType(resources.GetObject("btnReport.BackgroundImage"), Image)
        btnReport.BackgroundImageLayout = ImageLayout.None
        btnReport.FlatStyle = FlatStyle.Flat
        btnReport.ForeColor = Color.Transparent
        btnReport.ImageAlign = ContentAlignment.TopLeft
        btnReport.Location = New Point(939, 262)
        btnReport.Name = "btnReport"
        btnReport.Size = New Size(225, 240)
        btnReport.TabIndex = 9
        btnReport.TextAlign = ContentAlignment.TopLeft
        btnReport.UseVisualStyleBackColor = False
        ' 
        ' PictureBox4
        ' 
        PictureBox4.BackColor = Color.FromArgb(CByte(100), CByte(166), CByte(249))
        PictureBox4.BackgroundImage = CType(resources.GetObject("PictureBox4.BackgroundImage"), Image)
        PictureBox4.Location = New Point(269, 338)
        PictureBox4.Name = "PictureBox4"
        PictureBox4.Size = New Size(102, 68)
        PictureBox4.TabIndex = 10
        PictureBox4.TabStop = False
        ' 
        ' adminDashboard
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.White
        BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), Image)
        ClientSize = New Size(1289, 809)
        Controls.Add(PictureBox4)
        Controls.Add(btnReport)
        Controls.Add(btnCustomer)
        Controls.Add(btnService)
        Controls.Add(btnLogout)
        Controls.Add(btnAccount)
        Controls.Add(btnPurchase)
        Controls.Add(Label1)
        Controls.Add(PictureBox3)
        Controls.Add(PictureBox2)
        Controls.Add(PictureBox1)
        ForeColor = Color.White
        Name = "adminDashboard"
        StartPosition = FormStartPosition.CenterScreen
        Text = "adminDashboard"
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox2, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox3, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox4, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents Label1 As Label
    Friend WithEvents btnPurchase As Button
    Friend WithEvents btnAccount As Button
    Friend WithEvents btnLogout As Button
    Friend WithEvents btnService As Button
    Friend WithEvents btnCustomer As Button
    Friend WithEvents btnReport As Button
    Friend WithEvents PictureBox4 As PictureBox
End Class
