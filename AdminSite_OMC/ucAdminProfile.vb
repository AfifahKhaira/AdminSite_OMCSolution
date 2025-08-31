Imports System.Drawing.Drawing2D
Imports System.Runtime.InteropServices
Imports System.Windows.Forms.ComponentModel.Com2Interop
Public Class ucAdminProfile
    Private Sub AdminProfile_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        pnlChangePassword.Visible = False
        ApplyRoundedRegionToAll(Me)
        MakePictureBoxRound(picProfile)
        txtFirstName.Text = "Afifah"
        txtLastName.Text = "Khaira"
        txtEmail.Text = "afifahkhaira25@gmail.com"
        txtPhoneNumber.Text = "+60123456789"
        txtID.Text = "ADM001"
    End Sub


    Private Sub MakePictureBoxRound(pBox As PictureBox)
        Dim path As New GraphicsPath()
        path.AddEllipse(0, 0, pBox.Width, pBox.Height)
        pBox.Region = New Region(path)
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        '   picProfile.Image = Image.FromFile("C:\Path\To\Your\Image.jpg")
        MakePictureBoxRound(picProfile)
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        pnlChangePassword.Visible = True
    End Sub

    Private Sub btnNotifications_Click(sender As Object, e As EventArgs) Handles btnNotifications.Click
        Application.Exit()
    End Sub


End Class
