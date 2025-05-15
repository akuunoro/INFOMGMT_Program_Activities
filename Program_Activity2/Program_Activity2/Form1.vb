Public Class Form1
    Dim intTotal As Integer


    Private Sub Form1_KeyPress(sender As Object, e As KeyPressEventArgs) Handles Me.KeyPress
        ResetForm()
    End Sub


    Private Sub CmdAnswer_Click(sender As Object, e As EventArgs) Handles CmdAnswer.Click
        intTotal = Convert.ToInt32(ChK1.Checked) + Convert.ToInt32(ChK2.Checked) + Convert.ToInt32(ChK3.Checked)

        LBLAnswer.Visible = True
        LBLAbuse.Visible = False

        If intTotal = 3 Then
            LBLAnswer.Text = "You will find 6com easy"
        ElseIf intTotal = 2 Then
            LBLAnswer.Text = "You will find 6com a good level to start at"
        ElseIf intTotal = 1 Then
            LBLAnswer.Text = "Sounds like 6xcs would suit you best"
        ElseIf intTotal = 0 Then
            LBLAnswer.Text = "Definitely attend a 6xcs class"
        End If

        If ChK3.Checked AndAlso Not ChK1.Checked Then
            LBLAbuse.Text = "Have another attempt"
            LBLAbuse.Visible = True
            LBLAnswer.Visible = False
        End If

        If ChK2.Checked AndAlso Not ChK1.Checked Then
            LBLAbuse.Text = "Maybe Gardening might be a better career"
            LBLAbuse.Visible = True
            LBLAnswer.Visible = False
        End If
    End Sub


    Private Sub ResetForm()
        ChK1.Checked = False
        ChK2.Checked = False
        ChK3.Checked = False
        LBLAnswer.Visible = False
        LBLAbuse.Visible = False
    End Sub


    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ResetForm()
        Me.KeyPreview = True
    End Sub
End Class
