Public Class Accounts
    Private Sub btnDashboard_Click(sender As Object, e As EventArgs) Handles btnDashboard.Click
        Dim dashboard As New adminDashboard
        dashboard.Show()
        Me.Hide()
    End Sub
End Class