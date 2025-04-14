<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Ralph_Homepage
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
        Me.btn_exithome = New FontAwesome.Sharp.IconButton()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.btn_search = New System.Windows.Forms.Button()
        Me.cmb_users = New System.Windows.Forms.ComboBox()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btn_exithome
        '
        Me.btn_exithome.BackColor = System.Drawing.Color.Indigo
        Me.btn_exithome.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.btn_exithome.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_exithome.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btn_exithome.FlatAppearance.BorderSize = 0
        Me.btn_exithome.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DeepSkyBlue
        Me.btn_exithome.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightBlue
        Me.btn_exithome.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_exithome.Font = New System.Drawing.Font("Showcard Gothic", 19.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_exithome.ForeColor = System.Drawing.Color.Cyan
        Me.btn_exithome.IconChar = FontAwesome.Sharp.IconChar.None
        Me.btn_exithome.IconColor = System.Drawing.Color.Cyan
        Me.btn_exithome.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.btn_exithome.Location = New System.Drawing.Point(335, 475)
        Me.btn_exithome.Name = "btn_exithome"
        Me.btn_exithome.Size = New System.Drawing.Size(137, 52)
        Me.btn_exithome.TabIndex = 48
        Me.btn_exithome.Text = "EXIT"
        Me.btn_exithome.UseVisualStyleBackColor = False
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToOrderColumns = True
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(21, 75)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.RowHeadersWidth = 51
        Me.DataGridView1.RowTemplate.Height = 24
        Me.DataGridView1.Size = New System.Drawing.Size(749, 383)
        Me.DataGridView1.TabIndex = 49
        '
        'btn_search
        '
        Me.btn_search.Location = New System.Drawing.Point(516, 22)
        Me.btn_search.Name = "btn_search"
        Me.btn_search.Size = New System.Drawing.Size(230, 47)
        Me.btn_search.TabIndex = 50
        Me.btn_search.Text = "Search"
        Me.btn_search.UseVisualStyleBackColor = True
        '
        'cmb_users
        '
        Me.cmb_users.Font = New System.Drawing.Font("Nirmala UI", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmb_users.FormattingEnabled = True
        Me.cmb_users.Location = New System.Drawing.Point(21, 22)
        Me.cmb_users.Name = "cmb_users"
        Me.cmb_users.Size = New System.Drawing.Size(334, 45)
        Me.cmb_users.TabIndex = 51
        '
        'Ralph_Homepage
        '
        Me.AllowDrop = True
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.BackColor = System.Drawing.Color.DarkSlateBlue
        Me.ClientSize = New System.Drawing.Size(782, 553)
        Me.Controls.Add(Me.cmb_users)
        Me.Controls.Add(Me.btn_search)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.btn_exithome)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Ralph_Homepage"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Ralph_Homepage"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btn_exithome As FontAwesome.Sharp.IconButton
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents btn_search As Button
    Friend WithEvents cmb_users As ComboBox
End Class
