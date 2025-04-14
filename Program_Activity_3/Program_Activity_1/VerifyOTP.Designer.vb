<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class VerifyOTP
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
        Me.txt_showOTP = New System.Windows.Forms.TextBox()
        Me.tb_OTP = New System.Windows.Forms.TextBox()
        Me.btn_verifyOTP = New FontAwesome.Sharp.IconButton()
        Me.SuspendLayout()
        '
        'txt_showOTP
        '
        Me.txt_showOTP.AcceptsReturn = True
        Me.txt_showOTP.AcceptsTab = True
        Me.txt_showOTP.BackColor = System.Drawing.Color.DarkSlateBlue
        Me.txt_showOTP.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txt_showOTP.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.txt_showOTP.Font = New System.Drawing.Font("Showcard Gothic", 19.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_showOTP.ForeColor = System.Drawing.Color.Aqua
        Me.txt_showOTP.ImeMode = System.Windows.Forms.ImeMode.Off
        Me.txt_showOTP.Location = New System.Drawing.Point(99, 134)
        Me.txt_showOTP.Margin = New System.Windows.Forms.Padding(0)
        Me.txt_showOTP.Name = "txt_showOTP"
        Me.txt_showOTP.ReadOnly = True
        Me.txt_showOTP.Size = New System.Drawing.Size(618, 41)
        Me.txt_showOTP.TabIndex = 50
        Me.txt_showOTP.TabStop = False
        Me.txt_showOTP.Text = "ENTER THE OTP SENT TO YOUR EMAIL"
        Me.txt_showOTP.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.txt_showOTP.WordWrap = False
        '
        'tb_OTP
        '
        Me.tb_OTP.BackColor = System.Drawing.Color.MediumPurple
        Me.tb_OTP.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.tb_OTP.Font = New System.Drawing.Font("Gill Sans MT", 28.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tb_OTP.ForeColor = System.Drawing.Color.Cyan
        Me.tb_OTP.ImeMode = System.Windows.Forms.ImeMode.[On]
        Me.tb_OTP.Location = New System.Drawing.Point(122, 229)
        Me.tb_OTP.Margin = New System.Windows.Forms.Padding(0)
        Me.tb_OTP.Name = "tb_OTP"
        Me.tb_OTP.Size = New System.Drawing.Size(538, 62)
        Me.tb_OTP.TabIndex = 51
        Me.tb_OTP.TabStop = False
        '
        'btn_verifyOTP
        '
        Me.btn_verifyOTP.BackColor = System.Drawing.Color.Indigo
        Me.btn_verifyOTP.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.btn_verifyOTP.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_verifyOTP.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btn_verifyOTP.FlatAppearance.BorderSize = 0
        Me.btn_verifyOTP.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DeepSkyBlue
        Me.btn_verifyOTP.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightBlue
        Me.btn_verifyOTP.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_verifyOTP.Font = New System.Drawing.Font("Showcard Gothic", 19.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_verifyOTP.ForeColor = System.Drawing.Color.Cyan
        Me.btn_verifyOTP.IconChar = FontAwesome.Sharp.IconChar.None
        Me.btn_verifyOTP.IconColor = System.Drawing.Color.Cyan
        Me.btn_verifyOTP.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.btn_verifyOTP.Location = New System.Drawing.Point(247, 361)
        Me.btn_verifyOTP.Margin = New System.Windows.Forms.Padding(0)
        Me.btn_verifyOTP.Name = "btn_verifyOTP"
        Me.btn_verifyOTP.Size = New System.Drawing.Size(260, 69)
        Me.btn_verifyOTP.TabIndex = 49
        Me.btn_verifyOTP.Text = "Verify OTP"
        Me.btn_verifyOTP.UseVisualStyleBackColor = False
        '
        'VerifyOTP
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.BackColor = System.Drawing.Color.DarkSlateBlue
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.ClientSize = New System.Drawing.Size(782, 553)
        Me.Controls.Add(Me.tb_OTP)
        Me.Controls.Add(Me.txt_showOTP)
        Me.Controls.Add(Me.btn_verifyOTP)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "VerifyOTP"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "VerifyOTP"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btn_verifyOTP As FontAwesome.Sharp.IconButton
    Friend WithEvents tb_OTP As TextBox
    Friend WithEvents txt_showOTP As TextBox
End Class
