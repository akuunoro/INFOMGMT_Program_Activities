<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Login
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
        Me.tb_username = New System.Windows.Forms.TextBox()
        Me.tb_password = New System.Windows.Forms.TextBox()
        Me.btn_minimize = New FontAwesome.Sharp.IconButton()
        Me.btn_maximize = New FontAwesome.Sharp.IconButton()
        Me.btn_exit = New FontAwesome.Sharp.IconButton()
        Me.btn_login = New FontAwesome.Sharp.IconButton()
        Me.SuspendLayout()
        '
        'tb_username
        '
        Me.tb_username.Font = New System.Drawing.Font("Arial Rounded MT Bold", 19.8!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tb_username.Location = New System.Drawing.Point(179, 161)
        Me.tb_username.Name = "tb_username"
        Me.tb_username.Size = New System.Drawing.Size(546, 46)
        Me.tb_username.TabIndex = 4
        '
        'tb_password
        '
        Me.tb_password.Font = New System.Drawing.Font("Arial Rounded MT Bold", 19.8!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tb_password.Location = New System.Drawing.Point(179, 230)
        Me.tb_password.Name = "tb_password"
        Me.tb_password.Size = New System.Drawing.Size(546, 46)
        Me.tb_password.TabIndex = 5
        Me.tb_password.UseSystemPasswordChar = True
        '
        'btn_minimize
        '
        Me.btn_minimize.BackColor = System.Drawing.Color.DarkSlateBlue
        Me.btn_minimize.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_minimize.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_minimize.ForeColor = System.Drawing.Color.DarkSlateBlue
        Me.btn_minimize.IconChar = FontAwesome.Sharp.IconChar.Minus
        Me.btn_minimize.IconColor = System.Drawing.Color.Cyan
        Me.btn_minimize.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.btn_minimize.Location = New System.Drawing.Point(650, 0)
        Me.btn_minimize.Name = "btn_minimize"
        Me.btn_minimize.Size = New System.Drawing.Size(75, 44)
        Me.btn_minimize.TabIndex = 6
        Me.btn_minimize.UseVisualStyleBackColor = False
        '
        'btn_maximize
        '
        Me.btn_maximize.BackColor = System.Drawing.Color.DarkSlateBlue
        Me.btn_maximize.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_maximize.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_maximize.ForeColor = System.Drawing.Color.DarkSlateBlue
        Me.btn_maximize.IconChar = FontAwesome.Sharp.IconChar.SquareFull
        Me.btn_maximize.IconColor = System.Drawing.Color.Cyan
        Me.btn_maximize.IconFont = FontAwesome.Sharp.IconFont.Solid
        Me.btn_maximize.IconSize = 25
        Me.btn_maximize.Location = New System.Drawing.Point(725, 0)
        Me.btn_maximize.Name = "btn_maximize"
        Me.btn_maximize.Size = New System.Drawing.Size(75, 44)
        Me.btn_maximize.TabIndex = 7
        Me.btn_maximize.UseVisualStyleBackColor = False
        '
        'btn_exit
        '
        Me.btn_exit.BackColor = System.Drawing.Color.DarkSlateBlue
        Me.btn_exit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.btn_exit.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_exit.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_exit.ForeColor = System.Drawing.Color.DarkSlateBlue
        Me.btn_exit.IconChar = FontAwesome.Sharp.IconChar.X
        Me.btn_exit.IconColor = System.Drawing.Color.Cyan
        Me.btn_exit.IconFont = FontAwesome.Sharp.IconFont.Solid
        Me.btn_exit.IconSize = 25
        Me.btn_exit.Location = New System.Drawing.Point(800, 0)
        Me.btn_exit.Name = "btn_exit"
        Me.btn_exit.Size = New System.Drawing.Size(74, 44)
        Me.btn_exit.TabIndex = 8
        Me.btn_exit.UseVisualStyleBackColor = False
        '
        'btn_login
        '
        Me.btn_login.BackColor = System.Drawing.Color.DarkSlateBlue
        Me.btn_login.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.btn_login.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_login.FlatAppearance.BorderSize = 3
        Me.btn_login.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_login.Font = New System.Drawing.Font("Rockwell Extra Bold", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_login.ForeColor = System.Drawing.Color.Cyan
        Me.btn_login.IconChar = FontAwesome.Sharp.IconChar.None
        Me.btn_login.IconColor = System.Drawing.Color.Cyan
        Me.btn_login.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.btn_login.Location = New System.Drawing.Point(295, 329)
        Me.btn_login.Name = "btn_login"
        Me.btn_login.Size = New System.Drawing.Size(261, 95)
        Me.btn_login.TabIndex = 9
        Me.btn_login.Text = "LOGIN"
        Me.btn_login.UseVisualStyleBackColor = False
        '
        'Login
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.DarkSlateBlue
        Me.ClientSize = New System.Drawing.Size(874, 532)
        Me.Controls.Add(Me.btn_login)
        Me.Controls.Add(Me.btn_exit)
        Me.Controls.Add(Me.btn_maximize)
        Me.Controls.Add(Me.btn_minimize)
        Me.Controls.Add(Me.tb_password)
        Me.Controls.Add(Me.tb_username)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Login"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Login"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents tb_username As TextBox
    Friend WithEvents tb_password As TextBox
    Friend WithEvents btn_minimize As FontAwesome.Sharp.IconButton
    Friend WithEvents btn_maximize As FontAwesome.Sharp.IconButton
    Friend WithEvents btn_exit As FontAwesome.Sharp.IconButton
    Friend WithEvents btn_login As FontAwesome.Sharp.IconButton
End Class
