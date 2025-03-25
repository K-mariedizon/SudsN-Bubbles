Public Class Customer

    Private Sub btnLogout_Click(sender As Object, e As EventArgs) Handles btnLogout.Click
        Dim logout As New Logout
        logout.Show()
    End Sub

    Private Sub btnDB_Click(sender As Object, e As EventArgs) Handles btnDB.Click
        Dim dashboard As New adminDashboard
        dashboard.Show()
        Me.Hide()
    End Sub

    Private Sub btnPurchase_Click(sender As Object, e As EventArgs) Handles btnPurchase.Click
        Dim purchase As New Purchase
        purchase.Show()
        Me.Hide()
    End Sub

    Private Sub btnAccount_Click(sender As Object, e As EventArgs) Handles btnAccount.Click
        Dim a As New Accounts
        a.Show()
        Me.Hide()
    End Sub
End Class