Public Class Form1

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub lnkForgotPass_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles lnkForgotPass.LinkClicked
        Dim nextForm As New Form2()
        nextForm.Show() ' Use ShowDialog() if you want it modal
        Me.Hide() ' Optional: hide the current form
    End Sub
End Class
