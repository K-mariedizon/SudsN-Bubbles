﻿Public Class Logout
    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        Me.Hide()
    End Sub

    Private Sub btnLogout_Click(sender As Object, e As EventArgs) Handles btnLogout.Click
        Application.Exit()
    End Sub

    Private Sub RoundButton(btn As Button)

        btn.FlatStyle = FlatStyle.Flat
        btn.FlatAppearance.BorderSize = 0
        btn.ForeColor = Color.White
        btn.Cursor = Cursors.Hand
        'btn.Font = New Font("Century Gothic", 12)

        Dim Raduis As New Drawing2D.GraphicsPath

        Raduis.StartFigure()
        'appends an elliptical arc to the current figure
        'left corner top
        Raduis.AddArc(New Rectangle(0, 0, 20, 20), 180, 90)
        'appends a line segment to the current figure
        Raduis.AddLine(10, 0, btn.Width - 20, 0)
        'appends an elliptical arc to the current figure
        'right corner top
        Raduis.AddArc(New Rectangle(btn.Width - 20, 0, 20, 20), -90, 90)
        'appends a line segment to the current figure
        Raduis.AddLine(btnLogout.Width, 20, btn.Width, btn.Height - 10)
        'appends an elliptical arc to the current figure
        'right corner buttom
        Raduis.AddArc(New Rectangle(btn.Width - 25, btn.Height - 25, 25, 25), 0, 90)
        'appends a line segment to the current figure
        'left corner bottom
        Raduis.AddLine(btn.Width - 10, btn.Width, 20, btn.Height)
        'appends an elliptical arc to the current figure
        Raduis.AddArc(New Rectangle(0, btn.Height - 20, 20, 20), 90, 90)
        'Close the current figure and start a new one.
        Raduis.CloseFigure()
        'set the window associated with the control
        btnLogout.Region = New Region(Raduis)
    End Sub

    Private Sub Logout_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        RoundButton(btnLogout)
    End Sub
End Class