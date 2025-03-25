<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Login
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Login))
        PictureBox1 = New PictureBox()
        PictureBox2 = New PictureBox()
        lblUser = New Label()
        Label2 = New Label()
        Label3 = New Label()
        PictureBox3 = New PictureBox()
        Panel3 = New Panel()
        txtUname = New TextBox()
        PictureBox4 = New PictureBox()
        txtPword = New TextBox()
        Panel1 = New Panel()
        btnLogin = New Button()
        Label4 = New Label()
        Label5 = New Label()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox2, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox3, ComponentModel.ISupportInitialize).BeginInit()
        Panel3.SuspendLayout()
        CType(PictureBox4, ComponentModel.ISupportInitialize).BeginInit()
        Panel1.SuspendLayout()
        SuspendLayout()
        ' 
        ' PictureBox1
        ' 
        PictureBox1.BackgroundImage = CType(resources.GetObject("PictureBox1.BackgroundImage"), Image)
        PictureBox1.Location = New Point(813, -3)
        PictureBox1.Margin = New Padding(4, 3, 4, 3)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(479, 813)
        PictureBox1.TabIndex = 0
        PictureBox1.TabStop = False
        ' 
        ' PictureBox2
        ' 
        PictureBox2.BackgroundImage = CType(resources.GetObject("PictureBox2.BackgroundImage"), Image)
        PictureBox2.Location = New Point(-328, -3)
        PictureBox2.Margin = New Padding(4, 3, 4, 3)
        PictureBox2.Name = "PictureBox2"
        PictureBox2.Size = New Size(337, 888)
        PictureBox2.TabIndex = 1
        PictureBox2.TabStop = False
        ' 
        ' lblUser
        ' 
        lblUser.AutoSize = True
        lblUser.BackColor = Color.FromArgb(CByte(22), CByte(120), CByte(243))
        lblUser.Font = New Font("Arial", 25.8000011F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblUser.ForeColor = Color.White
        lblUser.Location = New Point(861, 60)
        lblUser.Margin = New Padding(4, 0, 4, 0)
        lblUser.Name = "lblUser"
        lblUser.Size = New Size(166, 51)
        lblUser.TabIndex = 2
        lblUser.Text = "ADMIN"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Arial", 10.2F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label2.ForeColor = SystemColors.ControlDarkDark
        Label2.Location = New Point(133, 456)
        Label2.Margin = New Padding(4, 0, 4, 0)
        Label2.Name = "Label2"
        Label2.Size = New Size(88, 19)
        Label2.TabIndex = 5
        Label2.Text = "Username:"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Arial", 10.2F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label3.ForeColor = SystemColors.ControlDarkDark
        Label3.Location = New Point(133, 529)
        Label3.Margin = New Padding(4, 0, 4, 0)
        Label3.Name = "Label3"
        Label3.Size = New Size(80, 19)
        Label3.TabIndex = 6
        Label3.Text = "Password"
        ' 
        ' PictureBox3
        ' 
        PictureBox3.BackgroundImage = CType(resources.GetObject("PictureBox3.BackgroundImage"), Image)
        PictureBox3.Location = New Point(10, 4)
        PictureBox3.Margin = New Padding(4, 3, 4, 3)
        PictureBox3.Name = "PictureBox3"
        PictureBox3.Size = New Size(23, 25)
        PictureBox3.TabIndex = 7
        PictureBox3.TabStop = False
        ' 
        ' Panel3
        ' 
        Panel3.BorderStyle = BorderStyle.FixedSingle
        Panel3.Controls.Add(txtUname)
        Panel3.Controls.Add(PictureBox3)
        Panel3.Location = New Point(133, 478)
        Panel3.Margin = New Padding(4, 3, 4, 3)
        Panel3.Name = "Panel3"
        Panel3.Size = New Size(547, 33)
        Panel3.TabIndex = 10
        ' 
        ' txtUname
        ' 
        txtUname.BorderStyle = BorderStyle.None
        txtUname.Font = New Font("Arial", 10.8F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        txtUname.ForeColor = Color.DimGray
        txtUname.Location = New Point(41, 4)
        txtUname.Margin = New Padding(4, 3, 4, 3)
        txtUname.Name = "txtUname"
        txtUname.Size = New Size(491, 21)
        txtUname.TabIndex = 4
        ' 
        ' PictureBox4
        ' 
        PictureBox4.BackgroundImage = CType(resources.GetObject("PictureBox4.BackgroundImage"), Image)
        PictureBox4.Location = New Point(10, 4)
        PictureBox4.Margin = New Padding(4, 3, 4, 3)
        PictureBox4.Name = "PictureBox4"
        PictureBox4.Size = New Size(23, 25)
        PictureBox4.TabIndex = 8
        PictureBox4.TabStop = False
        ' 
        ' txtPword
        ' 
        txtPword.BorderStyle = BorderStyle.None
        txtPword.Font = New Font("Arial", 10.8F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        txtPword.ForeColor = Color.DimGray
        txtPword.Location = New Point(41, 4)
        txtPword.Margin = New Padding(4, 3, 4, 3)
        txtPword.Name = "txtPword"
        txtPword.Size = New Size(491, 21)
        txtPword.TabIndex = 4
        ' 
        ' Panel1
        ' 
        Panel1.BorderStyle = BorderStyle.FixedSingle
        Panel1.Controls.Add(txtPword)
        Panel1.Controls.Add(PictureBox4)
        Panel1.Location = New Point(133, 550)
        Panel1.Margin = New Padding(4, 3, 4, 3)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(547, 33)
        Panel1.TabIndex = 9
        ' 
        ' btnLogin
        ' 
        btnLogin.BackColor = Color.FromArgb(CByte(22), CByte(120), CByte(243))
        btnLogin.FlatStyle = FlatStyle.Flat
        btnLogin.Location = New Point(339, 614)
        btnLogin.Margin = New Padding(4, 3, 4, 3)
        btnLogin.Name = "btnLogin"
        btnLogin.Size = New Size(147, 34)
        btnLogin.TabIndex = 11
        btnLogin.Text = "Login"
        btnLogin.UseVisualStyleBackColor = False
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Cooper Black", 24F, FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        Label4.ForeColor = Color.FromArgb(CByte(31), CByte(69), CByte(112))
        Label4.Location = New Point(231, 133)
        Label4.Margin = New Padding(4, 0, 4, 0)
        Label4.Name = "Label4"
        Label4.Size = New Size(341, 46)
        Label4.TabIndex = 13
        Label4.Text = "Suds N' Bubbles"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("Arial", 10.8F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label5.ForeColor = Color.FromArgb(CByte(31), CByte(69), CByte(112))
        Label5.Location = New Point(302, 179)
        Label5.Margin = New Padding(4, 0, 4, 0)
        Label5.Name = "Label5"
        Label5.Size = New Size(198, 21)
        Label5.TabIndex = 14
        Label5.Text = "L U A N D R Y  S H O P"
        ' 
        ' Login
        ' 
        AutoScaleDimensions = New SizeF(10F, 19F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.White
        ClientSize = New Size(1289, 809)
        Controls.Add(Label5)
        Controls.Add(Label4)
        Controls.Add(btnLogin)
        Controls.Add(Panel3)
        Controls.Add(Panel1)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(lblUser)
        Controls.Add(PictureBox2)
        Controls.Add(PictureBox1)
        Font = New Font("Arial", 10.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        ForeColor = Color.White
        Margin = New Padding(4, 3, 4, 3)
        Name = "Login"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Form1"
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox2, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox3, ComponentModel.ISupportInitialize).EndInit()
        Panel3.ResumeLayout(False)
        Panel3.PerformLayout()
        CType(PictureBox4, ComponentModel.ISupportInitialize).EndInit()
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents lblUser As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents Panel3 As Panel
    Friend WithEvents txtUname As TextBox
    Friend WithEvents PictureBox4 As PictureBox
    Friend WithEvents txtPword As TextBox
    Friend WithEvents Panel1 As Panel
    Friend WithEvents btnLogin As Button
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label

End Class
