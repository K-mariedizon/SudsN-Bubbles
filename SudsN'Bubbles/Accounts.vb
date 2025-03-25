Public Class Accounts
    Private Sub btnDashboard_Click(sender As Object, e As EventArgs) Handles btnDashboard.Click
        Dim dashboard As New adminDashboard
        dashboard.Show()
        Me.Hide()
    End Sub

    Private Sub btnC_Click(sender As Object, e As EventArgs) Handles btnC.Click
        Dim c As New Customer
        c.Show()
        Me.Hide()
    End Sub

    Private Sub btnP_Click(sender As Object, e As EventArgs) Handles btnP.Click
        Dim purchase As New Purchase
        purchase.Show()
        Me.Hide()
    End Sub

    Private Sub btnLogout_Click(sender As Object, e As EventArgs) Handles btnLogout.Click
        Dim logout As New Logout
        logout.Show()
    End Sub

End Class