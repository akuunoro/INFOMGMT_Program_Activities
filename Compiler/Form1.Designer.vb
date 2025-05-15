<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CHome
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
        Me.btn_minimize = New FontAwesome.Sharp.IconButton()
        Me.btn_maximize = New FontAwesome.Sharp.IconButton()
        Me.btn_exit = New FontAwesome.Sharp.IconButton()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.btn_search = New FontAwesome.Sharp.IconButton()
        Me.btn_terminal = New FontAwesome.Sharp.IconButton()
        Me.btn_explorer = New FontAwesome.Sharp.IconButton()
        Me.btn_project = New FontAwesome.Sharp.IconButton()
        Me.btn_debug = New FontAwesome.Sharp.IconButton()
        Me.btn_compile = New FontAwesome.Sharp.IconButton()
        Me.btn_run = New FontAwesome.Sharp.IconButton()
        Me.btn_edit = New FontAwesome.Sharp.IconButton()
        Me.btn_file = New FontAwesome.Sharp.IconButton()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.rch_editor = New System.Windows.Forms.RichTextBox()
        Me.pb_numberline = New System.Windows.Forms.PictureBox()
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.lbl_namefile = New System.Windows.Forms.Label()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.Panel6 = New System.Windows.Forms.Panel()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.pb_explorerlist = New System.Windows.Forms.PictureBox()
        Me.Panel7 = New System.Windows.Forms.Panel()
        Me.btn_addfile = New FontAwesome.Sharp.IconButton()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel1.SuspendLayout()
        Me.Panel4.SuspendLayout()
        CType(Me.pb_numberline, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel5.SuspendLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel6.SuspendLayout()
        CType(Me.pb_explorerlist, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel7.SuspendLayout()
        Me.SuspendLayout()
        '
        'btn_minimize
        '
        Me.btn_minimize.BackColor = System.Drawing.Color.DarkSlateBlue
        Me.btn_minimize.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_minimize.FlatAppearance.BorderSize = 0
        Me.btn_minimize.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_minimize.ForeColor = System.Drawing.Color.Cyan
        Me.btn_minimize.IconChar = FontAwesome.Sharp.IconChar.Minus
        Me.btn_minimize.IconColor = System.Drawing.Color.Cyan
        Me.btn_minimize.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.btn_minimize.IconSize = 25
        Me.btn_minimize.Location = New System.Drawing.Point(944, 1)
        Me.btn_minimize.Margin = New System.Windows.Forms.Padding(0)
        Me.btn_minimize.Name = "btn_minimize"
        Me.btn_minimize.Size = New System.Drawing.Size(65, 40)
        Me.btn_minimize.TabIndex = 0
        Me.btn_minimize.UseVisualStyleBackColor = False
        '
        'btn_maximize
        '
        Me.btn_maximize.BackColor = System.Drawing.Color.DarkSlateBlue
        Me.btn_maximize.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_maximize.FlatAppearance.BorderSize = 0
        Me.btn_maximize.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_maximize.ForeColor = System.Drawing.Color.Cyan
        Me.btn_maximize.IconChar = FontAwesome.Sharp.IconChar.Square
        Me.btn_maximize.IconColor = System.Drawing.Color.Cyan
        Me.btn_maximize.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.btn_maximize.IconSize = 25
        Me.btn_maximize.Location = New System.Drawing.Point(1009, -1)
        Me.btn_maximize.Margin = New System.Windows.Forms.Padding(0)
        Me.btn_maximize.Name = "btn_maximize"
        Me.btn_maximize.Size = New System.Drawing.Size(65, 40)
        Me.btn_maximize.TabIndex = 1
        Me.btn_maximize.UseVisualStyleBackColor = False
        '
        'btn_exit
        '
        Me.btn_exit.BackColor = System.Drawing.Color.DarkSlateBlue
        Me.btn_exit.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_exit.FlatAppearance.BorderSize = 0
        Me.btn_exit.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_exit.ForeColor = System.Drawing.Color.Cyan
        Me.btn_exit.IconChar = FontAwesome.Sharp.IconChar.X
        Me.btn_exit.IconColor = System.Drawing.Color.Cyan
        Me.btn_exit.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.btn_exit.IconSize = 25
        Me.btn_exit.Location = New System.Drawing.Point(1074, 1)
        Me.btn_exit.Margin = New System.Windows.Forms.Padding(0)
        Me.btn_exit.Name = "btn_exit"
        Me.btn_exit.Size = New System.Drawing.Size(65, 40)
        Me.btn_exit.TabIndex = 2
        Me.btn_exit.UseVisualStyleBackColor = False
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.DarkSlateBlue
        Me.Panel1.Controls.Add(Me.Panel3)
        Me.Panel1.Controls.Add(Me.Panel2)
        Me.Panel1.Controls.Add(Me.btn_search)
        Me.Panel1.Controls.Add(Me.btn_terminal)
        Me.Panel1.Controls.Add(Me.btn_explorer)
        Me.Panel1.Controls.Add(Me.btn_project)
        Me.Panel1.Controls.Add(Me.btn_debug)
        Me.Panel1.Controls.Add(Me.btn_exit)
        Me.Panel1.Controls.Add(Me.btn_compile)
        Me.Panel1.Controls.Add(Me.btn_minimize)
        Me.Panel1.Controls.Add(Me.btn_run)
        Me.Panel1.Controls.Add(Me.btn_maximize)
        Me.Panel1.Controls.Add(Me.btn_edit)
        Me.Panel1.Controls.Add(Me.btn_file)
        Me.Panel1.Location = New System.Drawing.Point(0, -1)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1139, 40)
        Me.Panel1.TabIndex = 3
        '
        'Panel3
        '
        Me.Panel3.Location = New System.Drawing.Point(6, 43)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(978, 233)
        Me.Panel3.TabIndex = 6
        '
        'Panel2
        '
        Me.Panel2.Location = New System.Drawing.Point(3, 43)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(200, 716)
        Me.Panel2.TabIndex = 7
        '
        'btn_search
        '
        Me.btn_search.BackColor = System.Drawing.Color.DarkSlateBlue
        Me.btn_search.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_search.FlatAppearance.BorderSize = 0
        Me.btn_search.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_search.Font = New System.Drawing.Font("Arial Rounded MT Bold", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_search.ForeColor = System.Drawing.Color.Cyan
        Me.btn_search.IconChar = FontAwesome.Sharp.IconChar.MagnifyingGlass
        Me.btn_search.IconColor = System.Drawing.Color.Cyan
        Me.btn_search.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.btn_search.IconSize = 25
        Me.btn_search.Location = New System.Drawing.Point(630, -1)
        Me.btn_search.Margin = New System.Windows.Forms.Padding(0)
        Me.btn_search.Name = "btn_search"
        Me.btn_search.Size = New System.Drawing.Size(54, 39)
        Me.btn_search.TabIndex = 11
        Me.btn_search.UseVisualStyleBackColor = False
        '
        'btn_terminal
        '
        Me.btn_terminal.BackColor = System.Drawing.Color.DarkSlateBlue
        Me.btn_terminal.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_terminal.FlatAppearance.BorderSize = 0
        Me.btn_terminal.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_terminal.Font = New System.Drawing.Font("Arial Rounded MT Bold", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_terminal.ForeColor = System.Drawing.Color.Cyan
        Me.btn_terminal.IconChar = FontAwesome.Sharp.IconChar.None
        Me.btn_terminal.IconColor = System.Drawing.Color.Cyan
        Me.btn_terminal.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.btn_terminal.IconSize = 25
        Me.btn_terminal.Location = New System.Drawing.Point(526, 1)
        Me.btn_terminal.Margin = New System.Windows.Forms.Padding(0)
        Me.btn_terminal.Name = "btn_terminal"
        Me.btn_terminal.Size = New System.Drawing.Size(104, 39)
        Me.btn_terminal.TabIndex = 10
        Me.btn_terminal.Text = "Terminal"
        Me.btn_terminal.UseVisualStyleBackColor = False
        '
        'btn_explorer
        '
        Me.btn_explorer.BackColor = System.Drawing.Color.DarkSlateBlue
        Me.btn_explorer.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_explorer.FlatAppearance.BorderSize = 0
        Me.btn_explorer.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_explorer.ForeColor = System.Drawing.Color.Cyan
        Me.btn_explorer.IconChar = FontAwesome.Sharp.IconChar.Navicon
        Me.btn_explorer.IconColor = System.Drawing.Color.Cyan
        Me.btn_explorer.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.btn_explorer.IconSize = 25
        Me.btn_explorer.Location = New System.Drawing.Point(0, 0)
        Me.btn_explorer.Margin = New System.Windows.Forms.Padding(0)
        Me.btn_explorer.Name = "btn_explorer"
        Me.btn_explorer.Size = New System.Drawing.Size(65, 40)
        Me.btn_explorer.TabIndex = 3
        Me.btn_explorer.UseVisualStyleBackColor = False
        '
        'btn_project
        '
        Me.btn_project.BackColor = System.Drawing.Color.DarkSlateBlue
        Me.btn_project.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_project.FlatAppearance.BorderSize = 0
        Me.btn_project.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_project.Font = New System.Drawing.Font("Arial Rounded MT Bold", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_project.ForeColor = System.Drawing.Color.Cyan
        Me.btn_project.IconChar = FontAwesome.Sharp.IconChar.None
        Me.btn_project.IconColor = System.Drawing.Color.Cyan
        Me.btn_project.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.btn_project.IconSize = 25
        Me.btn_project.Location = New System.Drawing.Point(438, -1)
        Me.btn_project.Margin = New System.Windows.Forms.Padding(0)
        Me.btn_project.Name = "btn_project"
        Me.btn_project.Size = New System.Drawing.Size(88, 39)
        Me.btn_project.TabIndex = 9
        Me.btn_project.Text = "Project"
        Me.btn_project.UseVisualStyleBackColor = False
        '
        'btn_debug
        '
        Me.btn_debug.BackColor = System.Drawing.Color.DarkSlateBlue
        Me.btn_debug.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_debug.FlatAppearance.BorderSize = 0
        Me.btn_debug.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_debug.Font = New System.Drawing.Font("Arial Rounded MT Bold", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_debug.ForeColor = System.Drawing.Color.Cyan
        Me.btn_debug.IconChar = FontAwesome.Sharp.IconChar.None
        Me.btn_debug.IconColor = System.Drawing.Color.Cyan
        Me.btn_debug.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.btn_debug.IconSize = 25
        Me.btn_debug.Location = New System.Drawing.Point(350, 1)
        Me.btn_debug.Margin = New System.Windows.Forms.Padding(0)
        Me.btn_debug.Name = "btn_debug"
        Me.btn_debug.Size = New System.Drawing.Size(88, 39)
        Me.btn_debug.TabIndex = 8
        Me.btn_debug.Text = "Debug"
        Me.btn_debug.UseVisualStyleBackColor = False
        '
        'btn_compile
        '
        Me.btn_compile.BackColor = System.Drawing.Color.DarkSlateBlue
        Me.btn_compile.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_compile.FlatAppearance.BorderSize = 0
        Me.btn_compile.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_compile.Font = New System.Drawing.Font("Arial Rounded MT Bold", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_compile.ForeColor = System.Drawing.Color.Cyan
        Me.btn_compile.IconChar = FontAwesome.Sharp.IconChar.None
        Me.btn_compile.IconColor = System.Drawing.Color.Cyan
        Me.btn_compile.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.btn_compile.IconSize = 25
        Me.btn_compile.Location = New System.Drawing.Point(259, 0)
        Me.btn_compile.Margin = New System.Windows.Forms.Padding(0)
        Me.btn_compile.Name = "btn_compile"
        Me.btn_compile.Size = New System.Drawing.Size(91, 39)
        Me.btn_compile.TabIndex = 7
        Me.btn_compile.Text = "Compile"
        Me.btn_compile.UseVisualStyleBackColor = False
        '
        'btn_run
        '
        Me.btn_run.BackColor = System.Drawing.Color.DarkSlateBlue
        Me.btn_run.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_run.FlatAppearance.BorderSize = 0
        Me.btn_run.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_run.Font = New System.Drawing.Font("Arial Rounded MT Bold", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_run.ForeColor = System.Drawing.Color.Cyan
        Me.btn_run.IconChar = FontAwesome.Sharp.IconChar.None
        Me.btn_run.IconColor = System.Drawing.Color.Cyan
        Me.btn_run.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.btn_run.IconSize = 25
        Me.btn_run.Location = New System.Drawing.Point(194, 0)
        Me.btn_run.Margin = New System.Windows.Forms.Padding(0)
        Me.btn_run.Name = "btn_run"
        Me.btn_run.Size = New System.Drawing.Size(65, 39)
        Me.btn_run.TabIndex = 6
        Me.btn_run.Text = "Run"
        Me.btn_run.UseVisualStyleBackColor = False
        '
        'btn_edit
        '
        Me.btn_edit.BackColor = System.Drawing.Color.DarkSlateBlue
        Me.btn_edit.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_edit.FlatAppearance.BorderSize = 0
        Me.btn_edit.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_edit.Font = New System.Drawing.Font("Arial Rounded MT Bold", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_edit.ForeColor = System.Drawing.Color.Cyan
        Me.btn_edit.IconChar = FontAwesome.Sharp.IconChar.None
        Me.btn_edit.IconColor = System.Drawing.Color.Cyan
        Me.btn_edit.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.btn_edit.IconSize = 25
        Me.btn_edit.Location = New System.Drawing.Point(129, 1)
        Me.btn_edit.Margin = New System.Windows.Forms.Padding(0)
        Me.btn_edit.Name = "btn_edit"
        Me.btn_edit.Size = New System.Drawing.Size(65, 39)
        Me.btn_edit.TabIndex = 5
        Me.btn_edit.Text = "Edit"
        Me.btn_edit.UseVisualStyleBackColor = False
        '
        'btn_file
        '
        Me.btn_file.BackColor = System.Drawing.Color.DarkSlateBlue
        Me.btn_file.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_file.FlatAppearance.BorderSize = 0
        Me.btn_file.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_file.Font = New System.Drawing.Font("Arial Rounded MT Bold", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_file.ForeColor = System.Drawing.Color.Cyan
        Me.btn_file.IconChar = FontAwesome.Sharp.IconChar.None
        Me.btn_file.IconColor = System.Drawing.Color.Cyan
        Me.btn_file.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.btn_file.IconSize = 25
        Me.btn_file.Location = New System.Drawing.Point(64, 1)
        Me.btn_file.Margin = New System.Windows.Forms.Padding(0)
        Me.btn_file.Name = "btn_file"
        Me.btn_file.Size = New System.Drawing.Size(65, 39)
        Me.btn_file.TabIndex = 4
        Me.btn_file.Text = "File"
        Me.btn_file.UseVisualStyleBackColor = False
        '
        'Panel4
        '
        Me.Panel4.BackColor = System.Drawing.Color.Teal
        Me.Panel4.Controls.Add(Me.rch_editor)
        Me.Panel4.Controls.Add(Me.pb_numberline)
        Me.Panel4.Location = New System.Drawing.Point(232, 66)
        Me.Panel4.Margin = New System.Windows.Forms.Padding(0)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(907, 689)
        Me.Panel4.TabIndex = 4
        '
        'rch_editor
        '
        Me.rch_editor.AcceptsTab = True
        Me.rch_editor.BackColor = System.Drawing.Color.Black
        Me.rch_editor.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.rch_editor.Dock = System.Windows.Forms.DockStyle.Fill
        Me.rch_editor.Font = New System.Drawing.Font("Courier New", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rch_editor.ForeColor = System.Drawing.Color.Cyan
        Me.rch_editor.Location = New System.Drawing.Point(41, 0)
        Me.rch_editor.Name = "rch_editor"
        Me.rch_editor.Size = New System.Drawing.Size(866, 689)
        Me.rch_editor.TabIndex = 1
        Me.rch_editor.Text = ""
        '
        'pb_numberline
        '
        Me.pb_numberline.BackColor = System.Drawing.Color.Black
        Me.pb_numberline.Dock = System.Windows.Forms.DockStyle.Left
        Me.pb_numberline.Location = New System.Drawing.Point(0, 0)
        Me.pb_numberline.Name = "pb_numberline"
        Me.pb_numberline.Size = New System.Drawing.Size(41, 689)
        Me.pb_numberline.TabIndex = 0
        Me.pb_numberline.TabStop = False
        '
        'Panel5
        '
        Me.Panel5.BackColor = System.Drawing.Color.Teal
        Me.Panel5.Controls.Add(Me.lbl_namefile)
        Me.Panel5.Controls.Add(Me.PictureBox2)
        Me.Panel5.Location = New System.Drawing.Point(232, 42)
        Me.Panel5.Margin = New System.Windows.Forms.Padding(0)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(907, 24)
        Me.Panel5.TabIndex = 5
        '
        'lbl_namefile
        '
        Me.lbl_namefile.AutoSize = True
        Me.lbl_namefile.BackColor = System.Drawing.Color.SlateGray
        Me.lbl_namefile.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lbl_namefile.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.lbl_namefile.Font = New System.Drawing.Font("Courier New", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_namefile.ForeColor = System.Drawing.Color.Yellow
        Me.lbl_namefile.Location = New System.Drawing.Point(0, 0)
        Me.lbl_namefile.Margin = New System.Windows.Forms.Padding(0)
        Me.lbl_namefile.Name = "lbl_namefile"
        Me.lbl_namefile.Size = New System.Drawing.Size(129, 20)
        Me.lbl_namefile.TabIndex = 1
        Me.lbl_namefile.Text = "Newfile.nggr"
        '
        'PictureBox2
        '
        Me.PictureBox2.BackColor = System.Drawing.Color.Black
        Me.PictureBox2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PictureBox2.Location = New System.Drawing.Point(0, 0)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Padding = New System.Windows.Forms.Padding(0, 0, 0, 8)
        Me.PictureBox2.Size = New System.Drawing.Size(907, 24)
        Me.PictureBox2.TabIndex = 0
        Me.PictureBox2.TabStop = False
        '
        'Panel6
        '
        Me.Panel6.BackColor = System.Drawing.Color.Teal
        Me.Panel6.Controls.Add(Me.Label2)
        Me.Panel6.Controls.Add(Me.pb_explorerlist)
        Me.Panel6.Location = New System.Drawing.Point(0, 108)
        Me.Panel6.Margin = New System.Windows.Forms.Padding(0)
        Me.Panel6.Name = "Panel6"
        Me.Panel6.Size = New System.Drawing.Size(229, 647)
        Me.Panel6.TabIndex = 6
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.LightSeaGreen
        Me.Label2.Font = New System.Drawing.Font("Courier New", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Yellow
        Me.Label2.Location = New System.Drawing.Point(2, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Padding = New System.Windows.Forms.Padding(0, 5, 100, 5)
        Me.Label2.Size = New System.Drawing.Size(229, 30)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Newfile.nggr"
        '
        'pb_explorerlist
        '
        Me.pb_explorerlist.BackColor = System.Drawing.Color.Black
        Me.pb_explorerlist.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pb_explorerlist.Location = New System.Drawing.Point(0, 0)
        Me.pb_explorerlist.Name = "pb_explorerlist"
        Me.pb_explorerlist.Size = New System.Drawing.Size(229, 647)
        Me.pb_explorerlist.TabIndex = 0
        Me.pb_explorerlist.TabStop = False
        '
        'Panel7
        '
        Me.Panel7.BackColor = System.Drawing.Color.Black
        Me.Panel7.Controls.Add(Me.btn_addfile)
        Me.Panel7.Controls.Add(Me.Label1)
        Me.Panel7.Location = New System.Drawing.Point(0, 42)
        Me.Panel7.Margin = New System.Windows.Forms.Padding(0)
        Me.Panel7.Name = "Panel7"
        Me.Panel7.Size = New System.Drawing.Size(229, 66)
        Me.Panel7.TabIndex = 1
        '
        'btn_addfile
        '
        Me.btn_addfile.BackColor = System.Drawing.Color.Black
        Me.btn_addfile.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_addfile.Dock = System.Windows.Forms.DockStyle.Right
        Me.btn_addfile.FlatAppearance.BorderSize = 0
        Me.btn_addfile.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_addfile.ForeColor = System.Drawing.Color.Cyan
        Me.btn_addfile.IconChar = FontAwesome.Sharp.IconChar.FileCirclePlus
        Me.btn_addfile.IconColor = System.Drawing.Color.Cyan
        Me.btn_addfile.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.btn_addfile.IconSize = 30
        Me.btn_addfile.Location = New System.Drawing.Point(175, 0)
        Me.btn_addfile.Name = "btn_addfile"
        Me.btn_addfile.Size = New System.Drawing.Size(54, 66)
        Me.btn_addfile.TabIndex = 1
        Me.btn_addfile.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Black
        Me.Label1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label1.Font = New System.Drawing.Font("Courier New", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Yellow
        Me.Label1.Location = New System.Drawing.Point(0, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(150, 31)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "EXPLORER"
        '
        'CHome
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.DarkTurquoise
        Me.ClientSize = New System.Drawing.Size(1140, 753)
        Me.Controls.Add(Me.Panel7)
        Me.Controls.Add(Me.Panel6)
        Me.Controls.Add(Me.Panel5)
        Me.Controls.Add(Me.Panel4)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "CHome"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Compiler"
        Me.Panel1.ResumeLayout(False)
        Me.Panel4.ResumeLayout(False)
        CType(Me.pb_numberline, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel5.ResumeLayout(False)
        Me.Panel5.PerformLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel6.ResumeLayout(False)
        Me.Panel6.PerformLayout()
        CType(Me.pb_explorerlist, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel7.ResumeLayout(False)
        Me.Panel7.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents btn_minimize As FontAwesome.Sharp.IconButton
    Friend WithEvents btn_maximize As FontAwesome.Sharp.IconButton
    Friend WithEvents btn_exit As FontAwesome.Sharp.IconButton
    Friend WithEvents Panel1 As Panel
    Friend WithEvents btn_explorer As FontAwesome.Sharp.IconButton
    Friend WithEvents btn_file As FontAwesome.Sharp.IconButton
    Friend WithEvents btn_edit As FontAwesome.Sharp.IconButton
    Friend WithEvents btn_debug As FontAwesome.Sharp.IconButton
    Friend WithEvents btn_project As FontAwesome.Sharp.IconButton
    Friend WithEvents btn_terminal As FontAwesome.Sharp.IconButton
    Friend WithEvents btn_search As FontAwesome.Sharp.IconButton
    Friend WithEvents btn_compile As FontAwesome.Sharp.IconButton
    Friend WithEvents btn_run As FontAwesome.Sharp.IconButton
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Panel4 As Panel
    Friend WithEvents Panel5 As Panel
    Friend WithEvents Panel6 As Panel
    Friend WithEvents rch_editor As RichTextBox
    Friend WithEvents pb_numberline As PictureBox
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents lbl_namefile As Label
    Friend WithEvents pb_explorerlist As PictureBox
    Friend WithEvents Panel7 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents btn_addfile As FontAwesome.Sharp.IconButton
    Friend WithEvents Label2 As Label
End Class
