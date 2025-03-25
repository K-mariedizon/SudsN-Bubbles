<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Logout
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
        Label2 = New Label()
        btnBack = New Button()
        btnLogout = New Button()
        SuspendLayout()
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Arial", 13.8F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label2.ForeColor = Color.Gray
        Label2.Location = New Point(56, 50)
        Label2.Margin = New Padding(4, 0, 4, 0)
        Label2.Name = "Label2"
        Label2.Size = New Size(200, 52)
        Label2.TabIndex = 6
        Label2.Text = "Once you're logout" & vbCrLf & " you can't go back"
        ' 
        ' btnBack
        ' 
        btnBack.BackColor = Color.Transparent
        btnBack.FlatStyle = FlatStyle.Flat
        btnBack.ForeColor = Color.DimGray
        btnBack.Location = New Point(71, 126)
        btnBack.Name = "btnBack"
        btnBack.Size = New Size(69, 31)
        btnBack.TabIndex = 7
        btnBack.Text = "Back"
        btnBack.UseVisualStyleBackColor = False
        ' 
        ' btnLogout
        ' 
        btnLogout.BackColor = Color.FromArgb(CByte(22), CByte(120), CByte(243))
        btnLogout.FlatStyle = FlatStyle.Flat
        btnLogout.ForeColor = Color.White
        btnLogout.Location = New Point(158, 126)
        btnLogout.Margin = New Padding(4, 3, 4, 3)
        btnLogout.Name = "btnLogout"
        btnLogout.Size = New Size(87, 31)
        btnLogout.TabIndex = 12
        btnLogout.Text = "Log Out"
        btnLogout.UseVisualStyleBackColor = False
        ' 
        ' Logout
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.White
        ClientSize = New Size(315, 199)
        Controls.Add(btnLogout)
        Controls.Add(btnBack)
        Controls.Add(Label2)
        MaximizeBox = False
        MinimizeBox = False
        Name = "Logout"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Logout"
        TopMost = True
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label2 As Label
    Friend WithEvents btnBack As Button
    Friend WithEvents btnLogout As Button
End Class
