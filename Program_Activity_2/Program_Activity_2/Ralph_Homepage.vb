﻿Public Class Ralph_Homepage

    Private Sub RoundedBtn(ParamArray btnArr() As Button)


        For Each btn As Button In btnArr
            btn.FlatStyle = FlatStyle.Flat
            btn.FlatAppearance.BorderSize = 0
            btn.BackColor = Color.Indigo
            btn.ForeColor = Color.Cyan
            btn.FlatAppearance.MouseOverBackColor = Color.LightPink
            btn.FlatAppearance.MouseDownBackColor = Color.Crimson

            btn.Cursor = Cursors.Hand
            btn.Font = New Font("Showcard Gothic", 20, FontStyle.Bold)

            AddHandler btn.MouseEnter, Sub(s, e) btn.ForeColor = Color.Black
            AddHandler btn.MouseLeave, Sub(s, e) btn.ForeColor = Color.Cyan
            AddHandler btn.MouseDown, Sub(s, e) btn.ForeColor = Color.White
            AddHandler btn.MouseUp, Sub(s, e) btn.ForeColor = Color.Black

            Dim radius As New Drawing2D.GraphicsPath
            radius.StartFigure()

            ' Top-left
            radius.AddArc(New Rectangle(0, 0, 20, 20), 180, 90)
            radius.AddLine(10, 0, btn.Width - 20, 0)

            ' Top-right
            radius.AddArc(New Rectangle(btn.Width - 20, 0, 20, 20), -90, 90)
            radius.AddLine(btn.Width, 20, btn.Width, btn.Height - 10)

            ' Bottom-right
            radius.AddArc(New Rectangle(btn.Width - 25, btn.Height - 25, 25, 25), 0, 90)

            ' Bottom-left
            radius.AddLine(btn.Width - 10, btn.Width, 20, btn.Height)
            radius.AddArc(New Rectangle(0, btn.Height - 20, 20, 20), 90, 90)

            radius.CloseFigure()
            btn.Region = New Region(radius)
        Next
    End Sub


    Private Sub Ralph_Homepage_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        RoundedBtn(btn_exithome)
    End Sub

    Private Sub btn_exithome_Click(sender As Object, e As EventArgs) Handles btn_exithome.Click

        Ralph.onetime_users = {{"", ""}}
        MessageBox.Show("Clearing the database...", "Loading", MessageBoxButtons.OK, MessageBoxIcon.Information)

        Dim gotoForm As New Ralph()
        gotoForm.Show()
        Me.Hide()
    End Sub
End Class