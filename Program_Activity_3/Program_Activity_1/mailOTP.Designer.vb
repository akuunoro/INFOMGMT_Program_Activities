<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class mailOTP
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
        Me.txt_EnterEmail = New System.Windows.Forms.TextBox()
        Me.tb_email = New System.Windows.Forms.TextBox()
        Me.btn_sendemail = New FontAwesome.Sharp.IconButton()
        Me.SuspendLayout()
        '
        'txt_EnterEmail
        '
        Me.txt_EnterEmail.AcceptsReturn = True
        Me.txt_EnterEmail.AcceptsTab = True
        Me.txt_EnterEmail.BackColor = System.Drawing.Color.DarkSlateBlue
        Me.txt_EnterEmail.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txt_EnterEmail.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.txt_EnterEmail.Font = New System.Drawing.Font("Showcard Gothic", 19.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_EnterEmail.ForeColor = System.Drawing.Color.Aqua
        Me.txt_EnterEmail.ImeMode = System.Windows.Forms.ImeMode.Off
        Me.txt_EnterEmail.Location = New System.Drawing.Point(30, 133)
        Me.txt_EnterEmail.Margin = New System.Windows.Forms.Padding(0)
        Me.txt_EnterEmail.Name = "txt_EnterEmail"
        Me.txt_EnterEmail.ReadOnly = True
        Me.txt_EnterEmail.Size = New System.Drawing.Size(743, 41)
        Me.txt_EnterEmail.TabIndex = 51
        Me.txt_EnterEmail.TabStop = False
        Me.txt_EnterEmail.Text = "Enter your email address to get an OTP"
        Me.txt_EnterEmail.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.txt_EnterEmail.WordWrap = False
        '
        'tb_email
        '
        Me.tb_email.BackColor = System.Drawing.Color.MediumPurple
        Me.tb_email.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.tb_email.Font = New System.Drawing.Font("Gill Sans MT", 28.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tb_email.ForeColor = System.Drawing.Color.Cyan
        Me.tb_email.ImeMode = System.Windows.Forms.ImeMode.[On]
        Me.tb_email.Location = New System.Drawing.Point(119, 223)
        Me.tb_email.Margin = New System.Windows.Forms.Padding(0)
        Me.tb_email.Name = "tb_email"
        Me.tb_email.Size = New System.Drawing.Size(538, 62)
        Me.tb_email.TabIndex = 52
        Me.tb_email.TabStop = False
        '
        'btn_sendemail
        '
        Me.btn_sendemail.BackColor = System.Drawing.Color.Indigo
        Me.btn_sendemail.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.btn_sendemail.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_sendemail.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btn_sendemail.FlatAppearance.BorderSize = 0
        Me.btn_sendemail.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DeepSkyBlue
        Me.btn_sendemail.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightBlue
        Me.btn_sendemail.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_sendemail.Font = New System.Drawing.Font("Showcard Gothic", 19.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_sendemail.ForeColor = System.Drawing.Color.Cyan
        Me.btn_sendemail.IconChar = FontAwesome.Sharp.IconChar.None
        Me.btn_sendemail.IconColor = System.Drawing.Color.Cyan
        Me.btn_sendemail.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.btn_sendemail.Location = New System.Drawing.Point(254, 331)
        Me.btn_sendemail.Margin = New System.Windows.Forms.Padding(0)
        Me.btn_sendemail.Name = "btn_sendemail"
        Me.btn_sendemail.Size = New System.Drawing.Size(260, 69)
        Me.btn_sendemail.TabIndex = 53
        Me.btn_sendemail.Text = "Get OTP"
        Me.btn_sendemail.UseVisualStyleBackColor = False
        '
        'mailOTP
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.BackColor = System.Drawing.Color.DarkSlateBlue
        Me.ClientSize = New System.Drawing.Size(782, 553)
        Me.Controls.Add(Me.btn_sendemail)
        Me.Controls.Add(Me.tb_email)
        Me.Controls.Add(Me.txt_EnterEmail)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "mailOTP"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "mailOTP"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txt_EnterEmail As TextBox
    Friend WithEvents tb_email As TextBox
    Friend WithEvents btn_sendemail As FontAwesome.Sharp.IconButton
End Class
