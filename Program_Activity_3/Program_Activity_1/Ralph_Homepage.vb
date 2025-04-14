Imports System.Data.SqlClient

Imports MySql.Data.MySqlClient

Public Class Ralph_Homepage
    Private Sub LoadUserData()
        Dim conn As New MySqlConnection("server=localhost;port=3308;userid=root;password=Takteka*_19;database=lab_act")
        Dim query As String = "SELECT * FROM users_info"
        Dim adapter As New MySqlDataAdapter(query, conn)
        Dim table As New DataTable()
        adapter.Fill(table)
        DataGridView1.DataSource = table
    End Sub

    Private Sub Data_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadUserData()
        With DataGridView1
            .AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill

            .DefaultCellStyle.BackColor = Color.DarkSlateBlue
            .DefaultCellStyle.ForeColor = Color.Cyan
            .DefaultCellStyle.SelectionBackColor = Color.DarkSlateBlue
            .DefaultCellStyle.SelectionForeColor = Color.DarkSlateBlue

            .ColumnHeadersDefaultCellStyle.BackColor = Color.Blue
            .ColumnHeadersDefaultCellStyle.ForeColor = Color.White
            .EnableHeadersVisualStyles = False

            .CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal
            .GridColor = Color.Black
        End With
    End Sub


    Private Sub LoadUsernamesToCombo()
        Dim conn As New MySqlConnection("server=localhost;port=3308;userid=root;password=Takteka*_19;database=lab_act")
        Dim cmd As New MySqlCommand("SELECT DISTINCT username FROM users_info", conn)
        Try
            conn.Open()
            Dim reader As MySqlDataReader = cmd.ExecuteReader()
            cmb_users.Items.Clear()
            While reader.Read()
                cmb_users.Items.Add(reader("username").ToString())
            End While
            cmb_users.Items.Insert(0, "All Users")
            cmb_users.SelectedIndex = 0
            conn.Close()
        Catch ex As Exception
            MessageBox.Show("Error loading users: " & ex.Message)
        End Try
    End Sub





    Private Sub StyleComboBox(cmb As ComboBox)
        cmb.BackColor = Color.MediumPurple
        cmb.ForeColor = Color.Cyan
        cmb.FlatStyle = FlatStyle.Flat
        cmb.Font = New Font("Arial", 12, FontStyle.Bold)
    End Sub









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
        RoundedBtn(btn_exithome, btn_search)
        StyleComboBox(cmb_users)
        LoadUserData()
        LoadUsernamesToCombo()

    End Sub

    Private Sub btn_exithome_Click(sender As Object, e As EventArgs) Handles btn_exithome.Click

        Ralph.onetime_users = {{"", ""}}
        MessageBox.Show("Clearing the database...", "Loading", MessageBoxButtons.OK, MessageBoxIcon.Information)

        Dim gotoForm As New Ralph()
        gotoForm.Show()
        Me.Hide()
    End Sub

    Private Sub pic_home_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub pic_hpicon18_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub pic_hpicon2_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub pic_hpicon1_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub pic_hpicon4_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub pic_hpicon5_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub pic_hpicon6_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub pic_hpicon3_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub pic_hpicon11_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub pic_hpicon26_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub pic_hpicon25_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub pic_hpicon27_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub pic_hpicon28_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub pic_hpicon29_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub pic_hpicon30_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick

    End Sub

    Private Sub btn_search_Click(sender As Object, e As EventArgs) Handles btn_search.Click
        If cmb_users.SelectedItem.ToString() = "All Users" Then
            LoadUserData()
            Return
        End If

        Dim selectedUser As String = cmb_users.SelectedItem.ToString()
        Dim conn As New MySqlConnection("server=localhost;port=3308;userid=root;password=Takteka*_19;database=lab_act")
        Dim query As String = "SELECT * FROM users_info WHERE username = @uname"
        Dim adapter As New MySqlDataAdapter(query, conn)
        adapter.SelectCommand.Parameters.AddWithValue("@uname", selectedUser)
        Dim table As New DataTable()
        adapter.Fill(table)
        DataGridView1.DataSource = table
    End Sub
End Class