<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ErrorMsg2
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
        Me.txt_errorheader1 = New System.Windows.Forms.TextBox()
        Me.txt_errormsg1 = New System.Windows.Forms.TextBox()
        Me.btn_ok1 = New FontAwesome.Sharp.IconButton()
        Me.pic_box1 = New FontAwesome.Sharp.IconPictureBox()
        CType(Me.pic_box1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txt_errorheader1
        '
        Me.txt_errorheader1.BackColor = System.Drawing.Color.Thistle
        Me.txt_errorheader1.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txt_errorheader1.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.txt_errorheader1.Dock = System.Windows.Forms.DockStyle.Top
        Me.txt_errorheader1.Font = New System.Drawing.Font("Showcard Gothic", 19.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_errorheader1.ForeColor = System.Drawing.Color.DarkRed
        Me.txt_errorheader1.ImeMode = System.Windows.Forms.ImeMode.Off
        Me.txt_errorheader1.Location = New System.Drawing.Point(0, 0)
        Me.txt_errorheader1.Margin = New System.Windows.Forms.Padding(0)
        Me.txt_errorheader1.Name = "txt_errorheader1"
        Me.txt_errorheader1.ReadOnly = True
        Me.txt_errorheader1.Size = New System.Drawing.Size(382, 41)
        Me.txt_errorheader1.TabIndex = 2
        Me.txt_errorheader1.TabStop = False
        Me.txt_errorheader1.Text = "ERROR CREDENTIALS!"
        Me.txt_errorheader1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txt_errormsg1
        '
        Me.txt_errormsg1.BackColor = System.Drawing.Color.Thistle
        Me.txt_errormsg1.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txt_errormsg1.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.txt_errormsg1.Font = New System.Drawing.Font("Showcard Gothic", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_errormsg1.ForeColor = System.Drawing.Color.DarkRed
        Me.txt_errormsg1.ImeMode = System.Windows.Forms.ImeMode.Off
        Me.txt_errormsg1.Location = New System.Drawing.Point(0, 65)
        Me.txt_errormsg1.Margin = New System.Windows.Forms.Padding(0)
        Me.txt_errormsg1.Name = "txt_errormsg1"
        Me.txt_errormsg1.ReadOnly = True
        Me.txt_errormsg1.Size = New System.Drawing.Size(382, 31)
        Me.txt_errormsg1.TabIndex = 12
        Me.txt_errormsg1.TabStop = False
        Me.txt_errormsg1.Text = "Invalid Credentials"
        Me.txt_errormsg1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'btn_ok1
        '
        Me.btn_ok1.BackColor = System.Drawing.Color.Thistle
        Me.btn_ok1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.btn_ok1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_ok1.FlatAppearance.BorderSize = 0
        Me.btn_ok1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DeepSkyBlue
        Me.btn_ok1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightBlue
        Me.btn_ok1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_ok1.Font = New System.Drawing.Font("Showcard Gothic", 19.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_ok1.ForeColor = System.Drawing.Color.DarkRed
        Me.btn_ok1.IconChar = FontAwesome.Sharp.IconChar.None
        Me.btn_ok1.IconColor = System.Drawing.Color.Cyan
        Me.btn_ok1.IconFont = FontAwesome.Sharp.IconFont.Solid
        Me.btn_ok1.IconSize = 25
        Me.btn_ok1.Location = New System.Drawing.Point(285, 288)
        Me.btn_ok1.Margin = New System.Windows.Forms.Padding(0)
        Me.btn_ok1.Name = "btn_ok1"
        Me.btn_ok1.Size = New System.Drawing.Size(73, 62)
        Me.btn_ok1.TabIndex = 14
        Me.btn_ok1.TabStop = False
        Me.btn_ok1.Text = "Ok"
        Me.btn_ok1.UseCompatibleTextRendering = True
        Me.btn_ok1.UseVisualStyleBackColor = False
        '
        'pic_box1
        '
        Me.pic_box1.BackColor = System.Drawing.Color.DarkSlateBlue
        Me.pic_box1.BackgroundImage = Global.Program_Activity_1.My.Resources.Resources.wolf_icon1
        Me.pic_box1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.pic_box1.ErrorImage = Global.Program_Activity_1.My.Resources.Resources.wolf3
        Me.pic_box1.ForeColor = System.Drawing.Color.Transparent
        Me.pic_box1.IconChar = FontAwesome.Sharp.IconChar.None
        Me.pic_box1.IconColor = System.Drawing.Color.Transparent
        Me.pic_box1.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.pic_box1.IconSize = 182
        Me.pic_box1.InitialImage = Global.Program_Activity_1.My.Resources.Resources.wolf3
        Me.pic_box1.Location = New System.Drawing.Point(23, 106)
        Me.pic_box1.Margin = New System.Windows.Forms.Padding(0)
        Me.pic_box1.Name = "pic_box1"
        Me.pic_box1.Size = New System.Drawing.Size(335, 182)
        Me.pic_box1.TabIndex = 13
        Me.pic_box1.TabStop = False
        '
        'ErrorMsg2
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.BackColor = System.Drawing.Color.Thistle
        Me.ClientSize = New System.Drawing.Size(382, 353)
        Me.Controls.Add(Me.btn_ok1)
        Me.Controls.Add(Me.pic_box1)
        Me.Controls.Add(Me.txt_errormsg1)
        Me.Controls.Add(Me.txt_errorheader1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "ErrorMsg2"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "ErrorMsg2"
        CType(Me.pic_box1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txt_errorheader1 As TextBox
    Friend WithEvents btn_ok1 As FontAwesome.Sharp.IconButton
    Friend WithEvents pic_box1 As FontAwesome.Sharp.IconPictureBox
    Friend WithEvents txt_errormsg1 As TextBox
End Class
