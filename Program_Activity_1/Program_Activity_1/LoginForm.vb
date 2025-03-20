Imports System.Runtime.Serialization.Formatters

Public Class Ralph
    Private Sub RoundedBtn(ParamArray btnArr() As Button)


        For Each btn As Button In btnArr
            btn.FlatStyle = FlatStyle.Flat
            btn.FlatAppearance.BorderSize = 0
            btn.BackColor = Color.Indigo
            btn.ForeColor = Color.Cyan
            btn.FlatAppearance.MouseOverBackColor = Color.LightBlue
            btn.FlatAppearance.MouseDownBackColor = Color.DeepSkyBlue

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


    Private Sub RoundedBtn1(ParamArray btnArr1() As Button)

        For Each btn As Button In btnArr1
            btn.FlatStyle = FlatStyle.Flat
            btn.FlatAppearance.BorderSize = 0
            btn.BackColor = Color.DarkSlateBlue
            btn.ForeColor = Color.Cyan
            btn.FlatAppearance.MouseOverBackColor = Color.LightBlue
            btn.FlatAppearance.MouseDownBackColor = Color.DeepSkyBlue

            btn.Cursor = Cursors.Hand
            btn.Font = New Font("Showcard Gothic", 20, FontStyle.Bold)
            Dim iconBtn As FontAwesome.Sharp.IconButton = CType(btn, FontAwesome.Sharp.IconButton)
            iconBtn.IconColor = Color.Cyan


            AddHandler btn.MouseEnter, Sub(s, e)
                                           btn.ForeColor = Color.Black
                                           iconBtn.IconColor = Color.Black
                                       End Sub
            AddHandler btn.MouseLeave, Sub(s, e)
                                           btn.ForeColor = Color.Cyan
                                           iconBtn.IconColor = Color.Cyan
                                       End Sub
            AddHandler btn.MouseDown, Sub(s, e)
                                          btn.ForeColor = Color.MediumPurple
                                          iconBtn.IconColor = Color.MediumPurple
                                      End Sub
            AddHandler btn.MouseUp, Sub(s, e)
                                        btn.ForeColor = Color.Cyan
                                        iconBtn.IconColor = Color.Cyan
                                    End Sub

        Next
    End Sub



    Private Sub Ralph_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        RoundedBtn(btn_login)
        RoundedBtn1(btn_exit, btn_maximize, btn_minimize)


    End Sub

    Private Sub btn_exit_Click(sender As Object, e As EventArgs) Handles btn_exit.Click
        Application.Exit()
    End Sub

    Private Sub btn_maximize_Click(sender As Object, e As EventArgs) Handles btn_maximize.Click
        If Me.WindowState = FormWindowState.Maximized Then
            Me.WindowState = FormWindowState.Normal
        Else
            Me.WindowState = FormWindowState.Maximized
        End If
    End Sub

    Private Sub btn_minimize_Click(sender As Object, e As EventArgs) Handles btn_minimize.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub

    Public Shared onetime_users(,) As String = {
        {"akuunoro", "okama_style"}
    }

    Private Function ValidateUser(username As String, password As String) As Boolean

        For i As Integer = 0 To onetime_users.GetLength(0) - 1
            If onetime_users(i, 0) = username AndAlso onetime_users(i, 1) = password Then
                Return True
            End If
        Next
        Return False
    End Function

    Private Sub btn_login_Click(sender As Object, e As EventArgs) Handles btn_login.Click
        Dim username As String = tb_username.Text
        Dim password As String = tb_password.Text


        If ValidateUser(username, password) Then
            Dim gotoForm As New Ralph_Homepage()
            gotoForm.Show()
            Me.Hide()
        ElseIf String.IsNullOrEmpty(onetime_users(0, 0)) AndAlso String.IsNullOrEmpty(onetime_users(0, 1)) Then
            ErrorMsg1.Show()
        Else
            ErrorMsg2.Show()
        End If
    End Sub
End Class
