Public Class TallySheet

    Dim total As Double = 0
    Dim count As Integer = 0

    Private Sub btn_exit_Click(sender As Object, e As EventArgs) Handles btn_exit.Click
        Login.onetime_users = {{"", ""}}
        MessageBox.Show("Clearing the database...", "Loading", MessageBoxButtons.OK, MessageBoxIcon.Information)

        Dim gotoForm As New Login()
        gotoForm.Show()
        Me.Hide()
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

    Private Sub TXTNumber_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TXTNumber.KeyPress
        ' If the user presses Enter key
        If e.KeyChar = ChrW(Keys.Enter) Then
            e.Handled = True ' prevent ding sound

            ' Try to convert the input to a number
            Dim input As Double
            If Double.TryParse(TXTNumber.Text, input) Then
                total += input
                count += 1

                txt_sum.Text = total.ToString()
                txt_count.Text = count.ToString()

                TXTNumber.Clear()
            Else
                MessageBox.Show("Please enter a valid number.", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                TXTNumber.SelectAll()
            End If
        End If
    End Sub

End Class
