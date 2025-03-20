<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Ralph
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
        Dim txt_loginTitle As System.Windows.Forms.TextBox
        Me.txt_username = New System.Windows.Forms.TextBox()
        Me.txt_password = New System.Windows.Forms.TextBox()
        Me.tb_username = New System.Windows.Forms.TextBox()
        Me.tb_password = New System.Windows.Forms.TextBox()
        Me.pic_licon = New FontAwesome.Sharp.IconPictureBox()
        Me.pic_box = New FontAwesome.Sharp.IconPictureBox()
        Me.btn_minimize = New FontAwesome.Sharp.IconButton()
        Me.btn_maximize = New FontAwesome.Sharp.IconButton()
        Me.btn_login = New FontAwesome.Sharp.IconButton()
        Me.btn_exit = New FontAwesome.Sharp.IconButton()
        txt_loginTitle = New System.Windows.Forms.TextBox()
        CType(Me.pic_licon, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pic_box, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txt_loginTitle
        '
        txt_loginTitle.AccessibleRole = System.Windows.Forms.AccessibleRole.None
        txt_loginTitle.BackColor = System.Drawing.Color.DarkSlateBlue
        txt_loginTitle.BorderStyle = System.Windows.Forms.BorderStyle.None
        txt_loginTitle.CausesValidation = False
        txt_loginTitle.Cursor = System.Windows.Forms.Cursors.Arrow
        txt_loginTitle.Font = New System.Drawing.Font("Showcard Gothic", 30.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        txt_loginTitle.ForeColor = System.Drawing.Color.Aqua
        txt_loginTitle.HideSelection = False
        txt_loginTitle.ImeMode = System.Windows.Forms.ImeMode.Off
        txt_loginTitle.Location = New System.Drawing.Point(92, 177)
        txt_loginTitle.Margin = New System.Windows.Forms.Padding(0)
        txt_loginTitle.Name = "txt_loginTitle"
        txt_loginTitle.ReadOnly = True
        txt_loginTitle.Size = New System.Drawing.Size(631, 62)
        txt_loginTitle.TabIndex = 0
        txt_loginTitle.TabStop = False
        txt_loginTitle.Text = "My 13th Reason"
        txt_loginTitle.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        txt_loginTitle.WordWrap = False
        '
        'txt_username
        '
        Me.txt_username.BackColor = System.Drawing.Color.DarkSlateBlue
        Me.txt_username.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txt_username.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.txt_username.Font = New System.Drawing.Font("Showcard Gothic", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_username.ForeColor = System.Drawing.Color.Aqua
        Me.txt_username.ImeMode = System.Windows.Forms.ImeMode.Off
        Me.txt_username.Location = New System.Drawing.Point(158, 241)
        Me.txt_username.Margin = New System.Windows.Forms.Padding(0)
        Me.txt_username.Name = "txt_username"
        Me.txt_username.ReadOnly = True
        Me.txt_username.Size = New System.Drawing.Size(157, 31)
        Me.txt_username.TabIndex = 0
        Me.txt_username.TabStop = False
        Me.txt_username.Text = "Username"
        Me.txt_username.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txt_password
        '
        Me.txt_password.BackColor = System.Drawing.Color.DarkSlateBlue
        Me.txt_password.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txt_password.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.txt_password.Font = New System.Drawing.Font("Showcard Gothic", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_password.ForeColor = System.Drawing.Color.Aqua
        Me.txt_password.ImeMode = System.Windows.Forms.ImeMode.Off
        Me.txt_password.Location = New System.Drawing.Point(158, 335)
        Me.txt_password.Margin = New System.Windows.Forms.Padding(0)
        Me.txt_password.Name = "txt_password"
        Me.txt_password.ReadOnly = True
        Me.txt_password.Size = New System.Drawing.Size(157, 31)
        Me.txt_password.TabIndex = 2
        Me.txt_password.TabStop = False
        Me.txt_password.Text = "Password"
        Me.txt_password.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'tb_username
        '
        Me.tb_username.BackColor = System.Drawing.Color.MediumPurple
        Me.tb_username.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.tb_username.Font = New System.Drawing.Font("Gill Sans MT", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tb_username.ForeColor = System.Drawing.Color.Cyan
        Me.tb_username.ImeMode = System.Windows.Forms.ImeMode.[On]
        Me.tb_username.Location = New System.Drawing.Point(167, 272)
        Me.tb_username.Margin = New System.Windows.Forms.Padding(0)
        Me.tb_username.Name = "tb_username"
        Me.tb_username.Size = New System.Drawing.Size(441, 54)
        Me.tb_username.TabIndex = 3
        Me.tb_username.TabStop = False
        '
        'tb_password
        '
        Me.tb_password.BackColor = System.Drawing.Color.MediumPurple
        Me.tb_password.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.tb_password.Font = New System.Drawing.Font("Gill Sans MT", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tb_password.ForeColor = System.Drawing.Color.Cyan
        Me.tb_password.ImeMode = System.Windows.Forms.ImeMode.[On]
        Me.tb_password.Location = New System.Drawing.Point(167, 366)
        Me.tb_password.Margin = New System.Windows.Forms.Padding(0)
        Me.tb_password.Name = "tb_password"
        Me.tb_password.Size = New System.Drawing.Size(441, 54)
        Me.tb_password.TabIndex = 4
        Me.tb_password.TabStop = False
        Me.tb_password.UseSystemPasswordChar = True
        '
        'pic_licon
        '
        Me.pic_licon.BackColor = System.Drawing.Color.DarkSlateBlue
        Me.pic_licon.BackgroundImage = Global.Program_Activity_1.My.Resources.Resources.wolf_icon
        Me.pic_licon.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.pic_licon.ErrorImage = Global.Program_Activity_1.My.Resources.Resources.wolf3
        Me.pic_licon.ForeColor = System.Drawing.Color.Transparent
        Me.pic_licon.IconChar = FontAwesome.Sharp.IconChar.None
        Me.pic_licon.IconColor = System.Drawing.Color.Transparent
        Me.pic_licon.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.pic_licon.IconSize = 62
        Me.pic_licon.InitialImage = Global.Program_Activity_1.My.Resources.Resources.wolf3
        Me.pic_licon.Location = New System.Drawing.Point(9, 0)
        Me.pic_licon.Margin = New System.Windows.Forms.Padding(0)
        Me.pic_licon.Name = "pic_licon"
        Me.pic_licon.Size = New System.Drawing.Size(82, 62)
        Me.pic_licon.TabIndex = 10
        Me.pic_licon.TabStop = False
        '
        'pic_box
        '
        Me.pic_box.BackColor = System.Drawing.Color.DarkSlateBlue
        Me.pic_box.BackgroundImage = Global.Program_Activity_1.My.Resources.Resources.wolf_icon1
        Me.pic_box.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.pic_box.ErrorImage = Global.Program_Activity_1.My.Resources.Resources.wolf3
        Me.pic_box.ForeColor = System.Drawing.Color.Transparent
        Me.pic_box.IconChar = FontAwesome.Sharp.IconChar.None
        Me.pic_box.IconColor = System.Drawing.Color.Transparent
        Me.pic_box.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.pic_box.IconSize = 94
        Me.pic_box.InitialImage = Global.Program_Activity_1.My.Resources.Resources.wolf3
        Me.pic_box.Location = New System.Drawing.Point(318, 80)
        Me.pic_box.Margin = New System.Windows.Forms.Padding(0)
        Me.pic_box.Name = "pic_box"
        Me.pic_box.Size = New System.Drawing.Size(169, 94)
        Me.pic_box.TabIndex = 9
        Me.pic_box.TabStop = False
        '
        'btn_minimize
        '
        Me.btn_minimize.BackColor = System.Drawing.Color.DarkSlateBlue
        Me.btn_minimize.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.btn_minimize.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_minimize.FlatAppearance.BorderSize = 0
        Me.btn_minimize.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DeepSkyBlue
        Me.btn_minimize.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightBlue
        Me.btn_minimize.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_minimize.Font = New System.Drawing.Font("Showcard Gothic", 19.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_minimize.ForeColor = System.Drawing.Color.Cyan
        Me.btn_minimize.IconChar = FontAwesome.Sharp.IconChar.Minus
        Me.btn_minimize.IconColor = System.Drawing.Color.Cyan
        Me.btn_minimize.IconFont = FontAwesome.Sharp.IconFont.Solid
        Me.btn_minimize.IconSize = 25
        Me.btn_minimize.Location = New System.Drawing.Point(564, 0)
        Me.btn_minimize.Margin = New System.Windows.Forms.Padding(0)
        Me.btn_minimize.Name = "btn_minimize"
        Me.btn_minimize.Size = New System.Drawing.Size(73, 62)
        Me.btn_minimize.TabIndex = 8
        Me.btn_minimize.TabStop = False
        Me.btn_minimize.UseVisualStyleBackColor = False
        '
        'btn_maximize
        '
        Me.btn_maximize.BackColor = System.Drawing.Color.DarkSlateBlue
        Me.btn_maximize.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.btn_maximize.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_maximize.FlatAppearance.BorderSize = 0
        Me.btn_maximize.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DeepSkyBlue
        Me.btn_maximize.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightBlue
        Me.btn_maximize.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_maximize.Font = New System.Drawing.Font("Showcard Gothic", 19.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_maximize.ForeColor = System.Drawing.Color.Cyan
        Me.btn_maximize.IconChar = FontAwesome.Sharp.IconChar.SquareFull
        Me.btn_maximize.IconColor = System.Drawing.Color.Cyan
        Me.btn_maximize.IconFont = FontAwesome.Sharp.IconFont.Solid
        Me.btn_maximize.IconSize = 25
        Me.btn_maximize.Location = New System.Drawing.Point(637, 0)
        Me.btn_maximize.Margin = New System.Windows.Forms.Padding(0)
        Me.btn_maximize.Name = "btn_maximize"
        Me.btn_maximize.Size = New System.Drawing.Size(73, 62)
        Me.btn_maximize.TabIndex = 7
        Me.btn_maximize.TabStop = False
        Me.btn_maximize.UseVisualStyleBackColor = False
        '
        'btn_login
        '
        Me.btn_login.BackColor = System.Drawing.Color.Indigo
        Me.btn_login.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.btn_login.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_login.FlatAppearance.BorderSize = 0
        Me.btn_login.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DeepSkyBlue
        Me.btn_login.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightBlue
        Me.btn_login.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_login.Font = New System.Drawing.Font("Showcard Gothic", 19.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_login.ForeColor = System.Drawing.Color.Cyan
        Me.btn_login.IconChar = FontAwesome.Sharp.IconChar.None
        Me.btn_login.IconColor = System.Drawing.Color.Black
        Me.btn_login.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.btn_login.Location = New System.Drawing.Point(318, 442)
        Me.btn_login.Name = "btn_login"
        Me.btn_login.Size = New System.Drawing.Size(133, 57)
        Me.btn_login.TabIndex = 5
        Me.btn_login.Text = "LOGIN"
        Me.btn_login.UseVisualStyleBackColor = False
        '
        'btn_exit
        '
        Me.btn_exit.BackColor = System.Drawing.Color.DarkSlateBlue
        Me.btn_exit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.btn_exit.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_exit.FlatAppearance.BorderSize = 0
        Me.btn_exit.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DeepSkyBlue
        Me.btn_exit.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightBlue
        Me.btn_exit.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_exit.Font = New System.Drawing.Font("Showcard Gothic", 19.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_exit.ForeColor = System.Drawing.Color.Cyan
        Me.btn_exit.IconChar = FontAwesome.Sharp.IconChar.X
        Me.btn_exit.IconColor = System.Drawing.Color.Cyan
        Me.btn_exit.IconFont = FontAwesome.Sharp.IconFont.Solid
        Me.btn_exit.IconSize = 25
        Me.btn_exit.Location = New System.Drawing.Point(710, 0)
        Me.btn_exit.Margin = New System.Windows.Forms.Padding(0)
        Me.btn_exit.Name = "btn_exit"
        Me.btn_exit.Size = New System.Drawing.Size(73, 62)
        Me.btn_exit.TabIndex = 6
        Me.btn_exit.TabStop = False
        Me.btn_exit.UseCompatibleTextRendering = True
        Me.btn_exit.UseVisualStyleBackColor = True
        '
        'Ralph
        '
        Me.AllowDrop = True
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 22.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.DarkSlateBlue
        Me.ClientSize = New System.Drawing.Size(782, 553)
        Me.Controls.Add(Me.pic_licon)
        Me.Controls.Add(Me.pic_box)
        Me.Controls.Add(Me.btn_minimize)
        Me.Controls.Add(Me.btn_maximize)
        Me.Controls.Add(Me.btn_login)
        Me.Controls.Add(Me.btn_exit)
        Me.Controls.Add(Me.tb_password)
        Me.Controls.Add(Me.tb_username)
        Me.Controls.Add(Me.txt_password)
        Me.Controls.Add(Me.txt_username)
        Me.Controls.Add(txt_loginTitle)
        Me.Font = New System.Drawing.Font("Gill Sans MT Condensed", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ForeColor = System.Drawing.Color.DarkRed
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.KeyPreview = True
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "Ralph"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Ralph.Login"
        CType(Me.pic_licon, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pic_box, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txt_username As TextBox
    Friend WithEvents txt_password As TextBox
    Friend WithEvents tb_username As TextBox
    Friend WithEvents tb_password As TextBox
    Friend WithEvents btn_login As FontAwesome.Sharp.IconButton
    Friend WithEvents btn_exit As FontAwesome.Sharp.IconButton
    Friend WithEvents btn_maximize As FontAwesome.Sharp.IconButton
    Friend WithEvents btn_minimize As FontAwesome.Sharp.IconButton
    Friend WithEvents pic_box As FontAwesome.Sharp.IconPictureBox
    Friend WithEvents pic_licon As FontAwesome.Sharp.IconPictureBox
End Class
