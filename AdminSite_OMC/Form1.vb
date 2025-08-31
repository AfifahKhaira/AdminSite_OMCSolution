Imports System.Data.OleDb

Public Class Form1
    Dim connString As String = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\afifa\source\repos\AdminSite_OMCSolution\LingoSign.accdb"

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        pnlLogin.Visible = True
        pcbSunbearWelcome2.Visible = True

        pnlForgotPassword.Visible = False
        pcbSunbearWrong2.Visible = False
    End Sub

    Private Sub lnkForgotPass_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles lnkForgotPass.LinkClicked
        pnlLogin.Visible = False
        pcbSunbearWelcome2.Visible = False

        pnlForgotPassword.Visible = True
        pcbSunbearWrong2.Visible = True
        txtEmailForgotPassword.Focus()
        txtEmailForgotPassword.Clear()
    End Sub

    Private Sub btnBackToLogin_Click(sender As Object, e As EventArgs) Handles btnBackToLogin.Click
        pnlForgotPassword.Visible = False
        pcbSunbearWrong2.Visible = False

        pnlLogin.Visible = True
        pcbSunbearWelcome2.Visible = True
        txtEmailUserID.Focus()
        txtEmailUserID.Clear()
        txtPassword.Clear()
    End Sub

    Private Sub txtEmailUserID_KeyDown(sender As Object, e As KeyEventArgs) Handles txtEmailUserID.KeyDown
        If e.KeyCode = Keys.Enter Then
            btnLogin.PerformClick()
        End If
    End Sub

    Private Sub txtPassword_KeyDown(sender As Object, e As KeyEventArgs) Handles txtPassword.KeyDown
        If e.KeyCode = Keys.Enter Then
            btnLogin.PerformClick()
        End If
    End Sub

    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        Dim input As String = txtEmailUserID.Text.Trim()
        Dim password As String = txtPassword.Text.Trim()

        If input = "" OrElse password = "" Then
            MessageBox.Show("Please enter both Email/UserID and Password.", "Login Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If

        Dim query As String = "SELECT * FROM Admin WHERE (Email = ? OR UserID = ?)"

        Using conn As New OleDbConnection(connString)
            Using cmd As New OleDbCommand(query, conn)
                cmd.Parameters.AddWithValue("?", input)
                cmd.Parameters.AddWithValue("?", input)

                conn.Open()
                Using reader As OleDbDataReader = cmd.ExecuteReader()
                    If reader.Read() Then
                        ' Read actual data from database
                        Dim dbEmail As String = reader("Email").ToString()
                        Dim dbUserID As String = reader("UserID").ToString()
                        Dim dbPassword As String = reader("Password").ToString()

                        ' Enforce case-sensitive matching
                        If (input = dbEmail Or input = dbUserID) AndAlso (password = dbPassword) Then
                            Dim dashboard As New Form4()
                            dashboard.Show()
                            Me.Hide()
                        Else
                            MessageBox.Show("Email/UserID or Password does not match (case-sensitive).", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Error)
                        End If
                    Else
                        MessageBox.Show("No admin account found with this Email/UserID.", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    End If
                End Using
            End Using
        End Using
    End Sub
End Class
