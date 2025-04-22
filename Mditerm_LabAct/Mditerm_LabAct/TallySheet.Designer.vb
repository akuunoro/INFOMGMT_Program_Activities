<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class TallySheet
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.btn_exit = New FontAwesome.Sharp.IconButton()
        Me.btn_maximize = New FontAwesome.Sharp.IconButton()
        Me.btn_minimize = New FontAwesome.Sharp.IconButton()
        Me.TXTNumber = New System.Windows.Forms.TextBox()
        Me.lb_count = New System.Windows.Forms.Label()
        Me.lb_sum = New System.Windows.Forms.Label()
        Me.txt_count = New System.Windows.Forms.TextBox()
        Me.txt_sum = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
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
        Me.btn_exit.Location = New System.Drawing.Point(800, 2)
        Me.btn_exit.Name = "btn_exit"
        Me.btn_exit.Size = New System.Drawing.Size(74, 44)
        Me.btn_exit.TabIndex = 11
        Me.btn_exit.UseVisualStyleBackColor = False
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
        Me.btn_maximize.Location = New System.Drawing.Point(725, 2)
        Me.btn_maximize.Name = "btn_maximize"
        Me.btn_maximize.Size = New System.Drawing.Size(75, 44)
        Me.btn_maximize.TabIndex = 10
        Me.btn_maximize.UseVisualStyleBackColor = False
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
        Me.btn_minimize.Location = New System.Drawing.Point(650, 2)
        Me.btn_minimize.Name = "btn_minimize"
        Me.btn_minimize.Size = New System.Drawing.Size(75, 44)
        Me.btn_minimize.TabIndex = 9
        Me.btn_minimize.UseVisualStyleBackColor = False
        '
        'TXTNumber
        '
        Me.TXTNumber.Font = New System.Drawing.Font("Arial Rounded MT Bold", 40.2!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TXTNumber.Location = New System.Drawing.Point(161, 159)
        Me.TXTNumber.Name = "TXTNumber"
        Me.TXTNumber.Size = New System.Drawing.Size(564, 85)
        Me.TXTNumber.TabIndex = 12
        '
        'lb_count
        '
        Me.lb_count.AutoSize = True
        Me.lb_count.Font = New System.Drawing.Font("Arial Rounded MT Bold", 25.2!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lb_count.ForeColor = System.Drawing.Color.Cyan
        Me.lb_count.Location = New System.Drawing.Point(136, 346)
        Me.lb_count.Margin = New System.Windows.Forms.Padding(0)
        Me.lb_count.Name = "lb_count"
        Me.lb_count.Size = New System.Drawing.Size(189, 49)
        Me.lb_count.TabIndex = 13
        Me.lb_count.Text = "COUNT:"
        '
        'lb_sum
        '
        Me.lb_sum.AutoSize = True
        Me.lb_sum.Font = New System.Drawing.Font("Arial Rounded MT Bold", 25.2!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lb_sum.ForeColor = System.Drawing.Color.Cyan
        Me.lb_sum.Location = New System.Drawing.Point(195, 415)
        Me.lb_sum.Margin = New System.Windows.Forms.Padding(0)
        Me.lb_sum.Name = "lb_sum"
        Me.lb_sum.Size = New System.Drawing.Size(130, 49)
        Me.lb_sum.TabIndex = 14
        Me.lb_sum.Text = "SUM:"
        Me.lb_sum.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txt_count
        '
        Me.txt_count.BackColor = System.Drawing.Color.DarkSlateBlue
        Me.txt_count.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txt_count.Font = New System.Drawing.Font("Arial Rounded MT Bold", 25.2!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_count.ForeColor = System.Drawing.Color.Cyan
        Me.txt_count.Location = New System.Drawing.Point(409, 346)
        Me.txt_count.Name = "txt_count"
        Me.txt_count.Size = New System.Drawing.Size(378, 49)
        Me.txt_count.TabIndex = 15
        '
        'txt_sum
        '
        Me.txt_sum.BackColor = System.Drawing.Color.DarkSlateBlue
        Me.txt_sum.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txt_sum.Font = New System.Drawing.Font("Arial Rounded MT Bold", 25.2!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_sum.ForeColor = System.Drawing.Color.Cyan
        Me.txt_sum.Location = New System.Drawing.Point(409, 415)
        Me.txt_sum.Name = "txt_sum"
        Me.txt_sum.Size = New System.Drawing.Size(378, 49)
        Me.txt_sum.TabIndex = 16
        '
        'TallySheet
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSize = True
        Me.BackColor = System.Drawing.Color.DarkSlateBlue
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.ClientSize = New System.Drawing.Size(874, 600)
        Me.Controls.Add(Me.txt_sum)
        Me.Controls.Add(Me.txt_count)
        Me.Controls.Add(Me.lb_sum)
        Me.Controls.Add(Me.lb_count)
        Me.Controls.Add(Me.TXTNumber)
        Me.Controls.Add(Me.btn_exit)
        Me.Controls.Add(Me.btn_maximize)
        Me.Controls.Add(Me.btn_minimize)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.MaximumSize = New System.Drawing.Size(900, 600)
        Me.Name = "TallySheet"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btn_exit As FontAwesome.Sharp.IconButton
    Friend WithEvents btn_maximize As FontAwesome.Sharp.IconButton
    Friend WithEvents btn_minimize As FontAwesome.Sharp.IconButton
    Friend WithEvents TXTNumber As TextBox
    Friend WithEvents lb_count As Label
    Friend WithEvents lb_sum As Label
    Friend WithEvents txt_count As TextBox
    Friend WithEvents txt_sum As TextBox
End Class
