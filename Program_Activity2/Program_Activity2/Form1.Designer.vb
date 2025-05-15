<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.LBLTitle = New System.Windows.Forms.Label()
        Me.ChK1 = New System.Windows.Forms.CheckBox()
        Me.ChK2 = New System.Windows.Forms.CheckBox()
        Me.ChK3 = New System.Windows.Forms.CheckBox()
        Me.CmdAnswer = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.LBLAnswer = New System.Windows.Forms.Label()
        Me.LBLAbuse = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'LBLTitle
        '
        Me.LBLTitle.AutoSize = True
        Me.LBLTitle.BackColor = System.Drawing.Color.Transparent
        Me.LBLTitle.Font = New System.Drawing.Font("Microsoft Sans Serif", 25.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LBLTitle.ForeColor = System.Drawing.Color.Cyan
        Me.LBLTitle.Location = New System.Drawing.Point(24, 46)
        Me.LBLTitle.Name = "LBLTitle"
        Me.LBLTitle.Size = New System.Drawing.Size(735, 51)
        Me.LBLTitle.TabIndex = 0
        Me.LBLTitle.Text = "Entry Criteria for 6 Form Computing"
        '
        'ChK1
        '
        Me.ChK1.AutoSize = True
        Me.ChK1.BackColor = System.Drawing.Color.Black
        Me.ChK1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ChK1.ForeColor = System.Drawing.Color.Cyan
        Me.ChK1.Location = New System.Drawing.Point(52, 131)
        Me.ChK1.Name = "ChK1"
        Me.ChK1.Size = New System.Drawing.Size(321, 29)
        Me.ChK1.TabIndex = 1
        Me.ChK1.Text = "Have you ever used a computer?"
        Me.ChK1.UseVisualStyleBackColor = False
        '
        'ChK2
        '
        Me.ChK2.AutoSize = True
        Me.ChK2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ChK2.ForeColor = System.Drawing.Color.Cyan
        Me.ChK2.Location = New System.Drawing.Point(52, 166)
        Me.ChK2.Name = "ChK2"
        Me.ChK2.Size = New System.Drawing.Size(372, 29)
        Me.ChK2.TabIndex = 2
        Me.ChK2.Text = "Can you write a letter on the computer?"
        Me.ChK2.UseVisualStyleBackColor = True
        '
        'ChK3
        '
        Me.ChK3.AutoSize = True
        Me.ChK3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ChK3.ForeColor = System.Drawing.Color.Cyan
        Me.ChK3.Location = New System.Drawing.Point(52, 201)
        Me.ChK3.Name = "ChK3"
        Me.ChK3.Size = New System.Drawing.Size(322, 29)
        Me.ChK3.TabIndex = 3
        Me.ChK3.Text = "Can you use a computer mouse?"
        Me.ChK3.UseVisualStyleBackColor = True
        '
        'CmdAnswer
        '
        Me.CmdAnswer.BackColor = System.Drawing.Color.SlateBlue
        Me.CmdAnswer.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.CmdAnswer.ForeColor = System.Drawing.Color.Cyan
        Me.CmdAnswer.Location = New System.Drawing.Point(516, 177)
        Me.CmdAnswer.Name = "CmdAnswer"
        Me.CmdAnswer.Size = New System.Drawing.Size(176, 53)
        Me.CmdAnswer.TabIndex = 4
        Me.CmdAnswer.Text = "Answer"
        Me.CmdAnswer.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.ForeColor = System.Drawing.Color.Cyan
        Me.Label1.Location = New System.Drawing.Point(516, 131)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(125, 16)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "Press a key to reset"
        '
        'LBLAnswer
        '
        Me.LBLAnswer.AllowDrop = True
        Me.LBLAnswer.AutoSize = True
        Me.LBLAnswer.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.LBLAnswer.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LBLAnswer.ForeColor = System.Drawing.Color.Cyan
        Me.LBLAnswer.Location = New System.Drawing.Point(45, 296)
        Me.LBLAnswer.Name = "LBLAnswer"
        Me.LBLAnswer.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.LBLAnswer.Size = New System.Drawing.Size(710, 32)
        Me.LBLAnswer.TabIndex = 6
        Me.LBLAnswer.Tag = ""
        Me.LBLAnswer.Text = "An advice will show up here based on your answers"
        Me.LBLAnswer.Visible = False
        '
        'LBLAbuse
        '
        Me.LBLAbuse.AutoSize = True
        Me.LBLAbuse.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LBLAbuse.ForeColor = System.Drawing.Color.Cyan
        Me.LBLAbuse.Location = New System.Drawing.Point(48, 356)
        Me.LBLAbuse.Name = "LBLAbuse"
        Me.LBLAbuse.Size = New System.Drawing.Size(59, 20)
        Me.LBLAbuse.TabIndex = 7
        Me.LBLAbuse.Text = "Label3"
        Me.LBLAbuse.Visible = False
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Black
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.LBLAbuse)
        Me.Controls.Add(Me.LBLAnswer)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.CmdAnswer)
        Me.Controls.Add(Me.ChK3)
        Me.Controls.Add(Me.ChK2)
        Me.Controls.Add(Me.ChK1)
        Me.Controls.Add(Me.LBLTitle)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents LBLTitle As Label
    Friend WithEvents ChK1 As CheckBox
    Friend WithEvents ChK2 As CheckBox
    Friend WithEvents ChK3 As CheckBox
    Friend WithEvents CmdAnswer As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents LBLAnswer As Label
    Friend WithEvents LBLAbuse As Label
End Class
