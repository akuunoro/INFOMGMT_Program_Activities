<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ErrorMsg1
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
        Me.txt_errorheader = New System.Windows.Forms.TextBox()
        Me.txt_errormsg = New System.Windows.Forms.TextBox()
        Me.btn_ok = New FontAwesome.Sharp.IconButton()
        Me.pic_box = New FontAwesome.Sharp.IconPictureBox()
        CType(Me.pic_box, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txt_errorheader
        '
        Me.txt_errorheader.BackColor = System.Drawing.Color.Thistle
        Me.txt_errorheader.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txt_errorheader.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.txt_errorheader.Dock = System.Windows.Forms.DockStyle.Top
        Me.txt_errorheader.Font = New System.Drawing.Font("Showcard Gothic", 19.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_errorheader.ForeColor = System.Drawing.Color.DarkRed
        Me.txt_errorheader.ImeMode = System.Windows.Forms.ImeMode.Off
        Me.txt_errorheader.Location = New System.Drawing.Point(0, 0)
        Me.txt_errorheader.Margin = New System.Windows.Forms.Padding(0)
        Me.txt_errorheader.Name = "txt_errorheader"
        Me.txt_errorheader.ReadOnly = True
        Me.txt_errorheader.Size = New System.Drawing.Size(382, 41)
        Me.txt_errorheader.TabIndex = 1
        Me.txt_errorheader.TabStop = False
        Me.txt_errorheader.Text = "DATABASE IS EMPTY!"
        Me.txt_errorheader.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txt_errormsg
        '
        Me.txt_errormsg.BackColor = System.Drawing.Color.Thistle
        Me.txt_errormsg.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txt_errormsg.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.txt_errormsg.Font = New System.Drawing.Font("Showcard Gothic", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_errormsg.ForeColor = System.Drawing.Color.DarkRed
        Me.txt_errormsg.ImeMode = System.Windows.Forms.ImeMode.Off
        Me.txt_errormsg.Location = New System.Drawing.Point(0, 69)
        Me.txt_errormsg.Margin = New System.Windows.Forms.Padding(0)
        Me.txt_errormsg.Name = "txt_errormsg"
        Me.txt_errormsg.ReadOnly = True
        Me.txt_errormsg.Size = New System.Drawing.Size(382, 31)
        Me.txt_errormsg.TabIndex = 2
        Me.txt_errormsg.TabStop = False
        Me.txt_errormsg.Text = "No User in the Database"
        Me.txt_errormsg.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'btn_ok
        '
        Me.btn_ok.BackColor = System.Drawing.Color.Thistle
        Me.btn_ok.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.btn_ok.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_ok.FlatAppearance.BorderSize = 0
        Me.btn_ok.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DeepSkyBlue
        Me.btn_ok.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightBlue
        Me.btn_ok.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_ok.Font = New System.Drawing.Font("Showcard Gothic", 19.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_ok.ForeColor = System.Drawing.Color.DarkRed
        Me.btn_ok.IconChar = FontAwesome.Sharp.IconChar.None
        Me.btn_ok.IconColor = System.Drawing.Color.Cyan
        Me.btn_ok.IconFont = FontAwesome.Sharp.IconFont.Solid
        Me.btn_ok.IconSize = 25
        Me.btn_ok.Location = New System.Drawing.Point(285, 292)
        Me.btn_ok.Margin = New System.Windows.Forms.Padding(0)
        Me.btn_ok.Name = "btn_ok"
        Me.btn_ok.Size = New System.Drawing.Size(73, 62)
        Me.btn_ok.TabIndex = 11
        Me.btn_ok.TabStop = False
        Me.btn_ok.Text = "Ok"
        Me.btn_ok.UseCompatibleTextRendering = True
        Me.btn_ok.UseVisualStyleBackColor = False
        '
        'pic_box
        '
        Me.pic_box.BackColor = System.Drawing.Color.DarkSlateBlue
        Me.pic_box.BackgroundImage = Global.Program_Activity_2.My.Resources.Resources.wolf_icon1
        Me.pic_box.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.pic_box.ErrorImage = Global.Program_Activity_2.My.Resources.Resources.wolf3
        Me.pic_box.ForeColor = System.Drawing.Color.Transparent
        Me.pic_box.IconChar = FontAwesome.Sharp.IconChar.None
        Me.pic_box.IconColor = System.Drawing.Color.Transparent
        Me.pic_box.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.pic_box.IconSize = 182
        Me.pic_box.InitialImage = Global.Program_Activity_2.My.Resources.Resources.wolf3
        Me.pic_box.Location = New System.Drawing.Point(23, 110)
        Me.pic_box.Margin = New System.Windows.Forms.Padding(0)
        Me.pic_box.Name = "pic_box"
        Me.pic_box.Size = New System.Drawing.Size(335, 182)
        Me.pic_box.TabIndex = 10
        Me.pic_box.TabStop = False
        '
        'ErrorMsg1
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.BackColor = System.Drawing.Color.Thistle
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.ClientSize = New System.Drawing.Size(382, 353)
        Me.Controls.Add(Me.btn_ok)
        Me.Controls.Add(Me.pic_box)
        Me.Controls.Add(Me.txt_errormsg)
        Me.Controls.Add(Me.txt_errorheader)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "ErrorMsg1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "ErrorMsg1"
        CType(Me.pic_box, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txt_errorheader As TextBox
    Friend WithEvents txt_errormsg As TextBox
    Friend WithEvents pic_box As FontAwesome.Sharp.IconPictureBox
    Friend WithEvents btn_ok As FontAwesome.Sharp.IconButton
End Class
