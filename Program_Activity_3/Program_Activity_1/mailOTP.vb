Imports System.Net
Imports System.Net.Mail



Public Class mailOTP



    Dim username As String = "marabilla.rr.bscs@gmail.com"
    Dim password As String = "npvu ufhk qhhu lbon"


    Public Function GenerateOTP() As String
        Dim rand As New Random()
        Return rand.Next(100000, 999999).ToString()
    End Function

    Private Sub sendOTP()
        Try
            Dim fromAddress As New MailAddress("noreply@marabilla.com", "Eme Eme Authentication")
            Dim toAddress As New MailAddress(tb_email.Text)
            Dim subject As String = "One-Time Password (OTP) Code"
            Dim body As String = String.Format("This is your One-Time Password Code: {0}", OTPmodule.OTPstored)

            Dim smtp As New SmtpClient()
            smtp.Host = "smtp.gmail.com"
            smtp.Port = 587
            smtp.EnableSsl = True
            smtp.Credentials = New NetworkCredential(username, password)
            Dim message As New MailMessage(fromAddress, toAddress)
            message.Subject = subject
            message.Body = body

            smtp.Send(message)


        Catch ex As Exception
            MsgBox("OTP Email failed to send: " & ex.Message)
        End Try
    End Sub
    Private Sub btn_sendemail_Click(sender As Object, e As EventArgs) Handles btn_sendemail.Click
        OTPmodule.OTPstored = GenerateOTP()
        sendOTP()
        VerifyOTP.Show()
        Me.Hide()
    End Sub

    Private Sub mailOTP_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class