Public Class CHome
    Private Sub RoundedBtn(ParamArray btnArr() As Button)
        For Each btn As Button In btnArr
            btn.FlatStyle = FlatStyle.Flat
            btn.FlatAppearance.BorderSize = 0
            btn.BackColor = Color.Indigo
            btn.ForeColor = Color.Cyan
            btn.FlatAppearance.MouseOverBackColor = Color.LightBlue
            btn.FlatAppearance.MouseDownBackColor = Color.DeepSkyBlue

            btn.Cursor = Cursors.Hand
            btn.Font = New Font("Showcard Gothic", 20, FontStyle.Bold)

            AddHandler btn.MouseEnter, Sub(s, e) btn.ForeColor = Color.Black
            AddHandler btn.MouseLeave, Sub(s, e) btn.ForeColor = Color.Cyan
            AddHandler btn.MouseDown, Sub(s, e) btn.ForeColor = Color.White
            AddHandler btn.MouseUp, Sub(s, e) btn.ForeColor = Color.Black

            Dim radius As New Drawing2D.GraphicsPath
            radius.StartFigure()

            ' Top-left
            radius.AddArc(New Rectangle(0, 0, 20, 20), 180, 90)
            radius.AddLine(10, 0, btn.Width - 20, 0)

            ' Top-right
            radius.AddArc(New Rectangle(btn.Width - 20, 0, 20, 20), -90, 90)
            radius.AddLine(btn.Width, 20, btn.Width, btn.Height - 10)

            ' Bottom-right
            radius.AddArc(New Rectangle(btn.Width - 25, btn.Height - 25, 25, 25), 0, 90)

            ' Bottom-left
            radius.AddLine(btn.Width - 10, btn.Width, 20, btn.Height)
            radius.AddArc(New Rectangle(0, btn.Height - 20, 20, 20), 90, 90)

            radius.CloseFigure()
            btn.Region = New Region(radius)
        Next
    End Sub

    Private Sub RoundedBtn1(ParamArray btnArr1() As Button)

        For Each btn As Button In btnArr1
            btn.FlatStyle = FlatStyle.Flat
            btn.FlatAppearance.BorderSize = 0
            btn.BackColor = Color.DarkSlateBlue
            btn.ForeColor = Color.Cyan
            btn.FlatAppearance.MouseOverBackColor = Color.LightBlue
            btn.FlatAppearance.MouseDownBackColor = Color.DeepSkyBlue

            btn.Cursor = Cursors.Hand
            btn.Font = New Font("Arial Rounded MT", 10, FontStyle.Bold)
            Dim iconBtn As FontAwesome.Sharp.IconButton = CType(btn, FontAwesome.Sharp.IconButton)
            iconBtn.IconColor = Color.Cyan


            AddHandler btn.MouseEnter, Sub(s, e)
                                           btn.ForeColor = Color.Black
                                           iconBtn.IconColor = Color.Black
                                       End Sub
            AddHandler btn.MouseLeave, Sub(s, e)
                                           btn.ForeColor = Color.Cyan
                                           iconBtn.IconColor = Color.Cyan
                                       End Sub
            AddHandler btn.MouseDown, Sub(s, e)
                                          btn.ForeColor = Color.MediumPurple
                                          iconBtn.IconColor = Color.MediumPurple
                                      End Sub
            AddHandler btn.MouseUp, Sub(s, e)
                                        btn.ForeColor = Color.Cyan
                                        iconBtn.IconColor = Color.Cyan
                                    End Sub

        Next
    End Sub

    Private Sub btn_exit_Click(sender As Object, e As EventArgs) Handles btn_exit.Click
        Application.Exit()
    End Sub

    Private Sub btn_maximize_Click(sender As Object, e As EventArgs) Handles btn_maximize.Click
        If Me.WindowState = FormWindowState.Maximized Then
            Me.WindowState = FormWindowState.Normal
        Else
            Me.WindowState = FormWindowState.Maximized
        End If
    End Sub

    Private Sub btn_minimize_Click(sender As Object, e As EventArgs) Handles btn_minimize.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub

    Private Sub CHome_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        RoundedBtn1(btn_exit, btn_maximize, btn_minimize, btn_explorer, btn_file, btn_edit, btn_run,
        btn_compile, btn_debug, btn_project, btn_terminal)
    End Sub

    Private Sub rch_editor_TextChanged(sender As Object, e As EventArgs) Handles rch_editor.TextChanged
        Dim keywords As String() = {
            "keri", "elaan", "porlakang", "whaloo", "gow", "shwitcharoo", "casey", "breaktie",
            "conti-gow", "mainia", "includachuchu", "definasyon", "typak-typak", "koncha",
            "sizey", "chikahan", "kuhako", "totoo", "naks", "yan", "luh", "jowa", "ooohlala", "intey slayma"
        }

        Dim operators As String() = {
            "+", "-", "*", "/", "==", "!=", ">", "<", ">=", "<=", "&&", "||", "!", "=", "++", "--"
        }

        Dim specialChar As String() = {
            "{", "}", "[", "]", "(", ")", ";", ",", ":", "#", "/*", "*/", "//", """", """"
        }

        Dim dataTypes As String() = {
            "intey", "flotchi", "churva", "dobols", "daks", "juts", "waley", "trulaonaur", "stringy", "struwetch"
        }

        Dim functions As String() = {
            "chika", "sinetch", "slayma", "maligo", "liberate", "longyet", "copychurva", "compareshiii", "huwap",
            "opena", "clozay"
        }

        Dim standardLibraries As String() = {
            "stdparang.h", "salpakan.h", "stringy-chikahan.h", "doot.h", "math-churva.h", "filea.h", "memory-boost.h", "input-chika.h",
            "compareshiii-ops.h", "array-konti.h", "stdio-its.h", "consolea.h", "type-timing.h", "time-bomb.h", "cstdlib.h",
            "totoos-ops.h", "consoledat.h", "stdio-intriga.h", "standardlib-naks.h", "deconstruwa.h"
        }




        pb_numberline.Invalidate()


        Dim selectionStart As Integer = rch_editor.SelectionStart
        Dim selectionLength As Integer = rch_editor.SelectionLength


        rch_editor.SuspendLayout()


        rch_editor.SelectAll()
        rch_editor.SelectionColor = Color.Cyan


        For Each word As String In keywords
            Dim index As Integer = 0
            While index < rch_editor.TextLength
                index = rch_editor.Find(word, index, RichTextBoxFinds.MatchCase Or RichTextBoxFinds.WholeWord)
                If index = -1 Then Exit While

                rch_editor.SelectionStart = index
                rch_editor.SelectionLength = word.Length
                rch_editor.SelectionColor = Color.Red

                index += word.Length
            End While
        Next

        For Each word As String In operators
            Dim index As Integer = 0
            While index < rch_editor.TextLength
                index = rch_editor.Find(word, index, RichTextBoxFinds.MatchCase Or RichTextBoxFinds.WholeWord)
                If index = -1 Then Exit While

                rch_editor.SelectionStart = index
                rch_editor.SelectionLength = word.Length
                rch_editor.SelectionColor = Color.Yellow

                index += word.Length
            End While
        Next

        For Each word As String In specialChar
            Dim index As Integer = 0
            While index < rch_editor.TextLength
                index = rch_editor.Find(word, index, RichTextBoxFinds.MatchCase Or RichTextBoxFinds.WholeWord)
                If index = -1 Then Exit While

                rch_editor.SelectionStart = index
                rch_editor.SelectionLength = word.Length
                rch_editor.SelectionColor = Color.DeepPink

                index += word.Length
            End While
        Next

        For Each word As String In dataTypes

            Dim index As Integer = 0
            While index < rch_editor.TextLength
                index = rch_editor.Find(word, index, RichTextBoxFinds.MatchCase Or RichTextBoxFinds.WholeWord)
                If index = -1 Then Exit While

                rch_editor.SelectionStart = index
                rch_editor.SelectionLength = word.Length
                rch_editor.SelectionColor = Color.Green

                index += word.Length
            End While
        Next


        For Each word As String In functions

            Dim index As Integer = 0
            While index < rch_editor.TextLength
                index = rch_editor.Find(word, index, RichTextBoxFinds.MatchCase Or RichTextBoxFinds.WholeWord)
                If index = -1 Then Exit While

                rch_editor.SelectionStart = index
                rch_editor.SelectionLength = word.Length
                rch_editor.SelectionColor = Color.Blue

                index += word.Length
            End While
        Next

        For Each word As String In standardLibraries

            Dim index As Integer = 0
            While index < rch_editor.TextLength
                index = rch_editor.Find(word, index, RichTextBoxFinds.MatchCase Or RichTextBoxFinds.WholeWord)
                If index = -1 Then Exit While

                rch_editor.SelectionStart = index
                rch_editor.SelectionLength = word.Length
                rch_editor.SelectionColor = Color.Violet

                index += word.Length
            End While
        Next




        rch_editor.SelectionStart = selectionStart
        rch_editor.SelectionLength = selectionLength
        rch_editor.SelectionColor = Color.Cyan


        rch_editor.ResumeLayout()
    End Sub


    Private Sub rch_editor_VScroll(sender As Object, e As EventArgs) Handles rch_editor.VScroll
        pb_numberline.Invalidate()
    End Sub

    Private Sub rch_editor_SelectionChanged(sender As Object, e As EventArgs) Handles rch_editor.SelectionChanged
        pb_numberline.Invalidate()
    End Sub


    Private Sub pb_numberline_Paint(sender As Object, e As PaintEventArgs) Handles pb_numberline.Paint
        e.Graphics.Clear(Color.Black)

        Dim font As New Font("", 10)
        Dim brush As New SolidBrush(Color.Cyan)

        Dim firstIndex As Integer = rch_editor.GetCharIndexFromPosition(New Point(0, 0))
        Dim firstLine As Integer = rch_editor.GetLineFromCharIndex(firstIndex)
        Dim lineHeight As Integer = TextRenderer.MeasureText("A", font).Height

        Dim visibleLines As Integer = CInt(Math.Ceiling(pb_numberline.Height / lineHeight))

        For i As Integer = 0 To visibleLines
            Dim lineNumber As Integer = firstLine + i + 1
            Dim yPosition As Integer = (i * lineHeight) + (lineHeight \ 2) - (font.Height \ 2)


            Dim numberText As String = lineNumber.ToString()
            Dim textSize As SizeF = e.Graphics.MeasureString(numberText, font)
            Dim xPosition As Single = pb_numberline.Width - textSize.Width - 4

            e.Graphics.DrawString(numberText, font, brush, xPosition, yPosition)
        Next
    End Sub

    Private Sub lbl_explorer_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub
End Class
