Public Class VerifyOTP



    Private Sub VerifyOTP_Load(sender As Object, e As EventArgs) Handles MyBase.Load


    End Sub







    Private Sub txt_showOTP_TextChanged(sender As Object, e As EventArgs) Handles txt_showOTP.TextChanged


    End Sub

    Private Sub btn_verifyOTP_Click(sender As Object, e As EventArgs) Handles btn_verifyOTP.Click
        If tb_OTP.Text = OTPmodule.OTPstored Then
            Ralph_Homepage.Show()
            Me.Hide()
        Else
            MessageBox.Show("Invalid OTP!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub
End Class