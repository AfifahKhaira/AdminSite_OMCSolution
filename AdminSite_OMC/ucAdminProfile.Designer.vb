<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class ucAdminProfile
    Inherits System.Windows.Forms.UserControl

    'UserControl overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.pnlPersonalInformation = New System.Windows.Forms.Panel()
        Me.txtPhoneNumber = New System.Windows.Forms.MaskedTextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtEmail = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtLastName = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtFirstName = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.pnlChangePassword = New System.Windows.Forms.Panel()
        Me.btnLogin = New System.Windows.Forms.Button()
        Me.txtConfirmPassword = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.txtNewPassword = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtID = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.btnCopyUserID = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.btnNotifications = New System.Windows.Forms.Button()
        Me.picProfile = New System.Windows.Forms.PictureBox()
        Me.pnlPersonalInformation.SuspendLayout()
        Me.pnlChangePassword.SuspendLayout()
        CType(Me.picProfile, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'pnlPersonalInformation
        '
        Me.pnlPersonalInformation.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pnlPersonalInformation.Controls.Add(Me.txtPhoneNumber)
        Me.pnlPersonalInformation.Controls.Add(Me.Label5)
        Me.pnlPersonalInformation.Controls.Add(Me.txtEmail)
        Me.pnlPersonalInformation.Controls.Add(Me.Label4)
        Me.pnlPersonalInformation.Controls.Add(Me.txtLastName)
        Me.pnlPersonalInformation.Controls.Add(Me.Label3)
        Me.pnlPersonalInformation.Controls.Add(Me.txtFirstName)
        Me.pnlPersonalInformation.Controls.Add(Me.Label2)
        Me.pnlPersonalInformation.Controls.Add(Me.Label1)
        Me.pnlPersonalInformation.Location = New System.Drawing.Point(396, 28)
        Me.pnlPersonalInformation.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.pnlPersonalInformation.Name = "pnlPersonalInformation"
        Me.pnlPersonalInformation.Padding = New System.Windows.Forms.Padding(32, 25, 32, 25)
        Me.pnlPersonalInformation.Size = New System.Drawing.Size(919, 400)
        Me.pnlPersonalInformation.TabIndex = 1
        '
        'txtPhoneNumber
        '
        Me.txtPhoneNumber.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPhoneNumber.ForeColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer))
        Me.txtPhoneNumber.Location = New System.Drawing.Point(36, 329)
        Me.txtPhoneNumber.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtPhoneNumber.Mask = "(00)00-00000000"
        Me.txtPhoneNumber.Name = "txtPhoneNumber"
        Me.txtPhoneNumber.Size = New System.Drawing.Size(844, 39)
        Me.txtPhoneNumber.TabIndex = 9
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer))
        Me.Label5.Location = New System.Drawing.Point(36, 292)
        Me.Label5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(140, 25)
        Me.Label5.TabIndex = 7
        Me.Label5.Text = "Phone Number"
        '
        'txtEmail
        '
        Me.txtEmail.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtEmail.Location = New System.Drawing.Point(37, 225)
        Me.txtEmail.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtEmail.Name = "txtEmail"
        Me.txtEmail.Size = New System.Drawing.Size(843, 39)
        Me.txtEmail.TabIndex = 6
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer))
        Me.Label4.Location = New System.Drawing.Point(36, 188)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(130, 25)
        Me.Label4.TabIndex = 5
        Me.Label4.Text = "Email Address"
        '
        'txtLastName
        '
        Me.txtLastName.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtLastName.Location = New System.Drawing.Point(481, 121)
        Me.txtLastName.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtLastName.Name = "txtLastName"
        Me.txtLastName.Size = New System.Drawing.Size(399, 39)
        Me.txtLastName.TabIndex = 4
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer))
        Me.Label3.Location = New System.Drawing.Point(476, 84)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(100, 25)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "Last Name"
        '
        'txtFirstName
        '
        Me.txtFirstName.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtFirstName.Location = New System.Drawing.Point(36, 121)
        Me.txtFirstName.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtFirstName.Name = "txtFirstName"
        Me.txtFirstName.Size = New System.Drawing.Size(399, 39)
        Me.txtFirstName.TabIndex = 2
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer))
        Me.Label2.Location = New System.Drawing.Point(36, 84)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(102, 25)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "First Name"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(36, 25)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(235, 32)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Personal Information"
        '
        'pnlChangePassword
        '
        Me.pnlChangePassword.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pnlChangePassword.Controls.Add(Me.btnLogin)
        Me.pnlChangePassword.Controls.Add(Me.txtConfirmPassword)
        Me.pnlChangePassword.Controls.Add(Me.Label9)
        Me.pnlChangePassword.Controls.Add(Me.Label11)
        Me.pnlChangePassword.Controls.Add(Me.txtNewPassword)
        Me.pnlChangePassword.Controls.Add(Me.Label8)
        Me.pnlChangePassword.Location = New System.Drawing.Point(396, 458)
        Me.pnlChangePassword.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.pnlChangePassword.Name = "pnlChangePassword"
        Me.pnlChangePassword.Padding = New System.Windows.Forms.Padding(32, 25, 32, 25)
        Me.pnlChangePassword.Size = New System.Drawing.Size(919, 400)
        Me.pnlChangePassword.TabIndex = 2
        '
        'btnLogin
        '
        Me.btnLogin.BackColor = System.Drawing.Color.FromArgb(CType(CType(162, Byte), Integer), CType(CType(167, Byte), Integer), CType(CType(249, Byte), Integer))
        Me.btnLogin.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnLogin.ForeColor = System.Drawing.Color.White
        Me.btnLogin.Location = New System.Drawing.Point(35, 309)
        Me.btnLogin.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnLogin.Name = "btnLogin"
        Me.btnLogin.Size = New System.Drawing.Size(848, 62)
        Me.btnLogin.TabIndex = 16
        Me.btnLogin.Text = "Confirm"
        Me.btnLogin.UseVisualStyleBackColor = False
        '
        'txtConfirmPassword
        '
        Me.txtConfirmPassword.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtConfirmPassword.Location = New System.Drawing.Point(37, 225)
        Me.txtConfirmPassword.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtConfirmPassword.Name = "txtConfirmPassword"
        Me.txtConfirmPassword.Size = New System.Drawing.Size(843, 39)
        Me.txtConfirmPassword.TabIndex = 9
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer))
        Me.Label9.Location = New System.Drawing.Point(36, 188)
        Me.Label9.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(164, 25)
        Me.Label9.TabIndex = 8
        Me.Label9.Text = "Confirm Password"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer))
        Me.Label11.Location = New System.Drawing.Point(36, 84)
        Me.Label11.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(134, 25)
        Me.Label11.TabIndex = 6
        Me.Label11.Text = "New Password"
        '
        'txtNewPassword
        '
        Me.txtNewPassword.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNewPassword.Location = New System.Drawing.Point(36, 121)
        Me.txtNewPassword.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtNewPassword.Name = "txtNewPassword"
        Me.txtNewPassword.Size = New System.Drawing.Size(844, 39)
        Me.txtNewPassword.TabIndex = 5
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer))
        Me.Label8.Location = New System.Drawing.Point(36, 25)
        Me.Label8.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(200, 32)
        Me.Label8.TabIndex = 1
        Me.Label8.Text = "Change Password"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer))
        Me.Label6.Location = New System.Drawing.Point(68, 255)
        Me.Label6.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(245, 28)
        Me.Label6.TabIndex = 10
        Me.Label6.Text = "afifahkhaira25@gmail.com"
        '
        'txtID
        '
        Me.txtID.Cursor = System.Windows.Forms.Cursors.Default
        Me.txtID.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtID.Location = New System.Drawing.Point(73, 341)
        Me.txtID.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtID.Name = "txtID"
        Me.txtID.ReadOnly = True
        Me.txtID.Size = New System.Drawing.Size(183, 34)
        Me.txtID.TabIndex = 10
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer))
        Me.Label7.Location = New System.Drawing.Point(68, 311)
        Me.Label7.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(79, 28)
        Me.Label7.TabIndex = 11
        Me.Label7.Text = "User ID:"
        '
        'btnCopyUserID
        '
        Me.btnCopyUserID.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCopyUserID.Location = New System.Drawing.Point(265, 341)
        Me.btnCopyUserID.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btnCopyUserID.Name = "btnCopyUserID"
        Me.btnCopyUserID.Size = New System.Drawing.Size(100, 36)
        Me.btnCopyUserID.TabIndex = 12
        Me.btnCopyUserID.Text = "Copy"
        Me.btnCopyUserID.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.FlatAppearance.BorderSize = 0
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer))
        Me.Button1.Image = Global.AdminSite_OMC.My.Resources.Resources.password_icon
        Me.Button1.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Button1.Location = New System.Drawing.Point(52, 458)
        Me.Button1.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(293, 62)
        Me.Button1.TabIndex = 14
        Me.Button1.Text = "   Change Password         "
        Me.Button1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Button1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.Button1.UseVisualStyleBackColor = True
        '
        'btnNotifications
        '
        Me.btnNotifications.FlatAppearance.BorderSize = 0
        Me.btnNotifications.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnNotifications.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnNotifications.ForeColor = System.Drawing.Color.Red
        Me.btnNotifications.Image = Global.AdminSite_OMC.My.Resources.Resources.logout_icon
        Me.btnNotifications.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnNotifications.Location = New System.Drawing.Point(52, 535)
        Me.btnNotifications.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnNotifications.Name = "btnNotifications"
        Me.btnNotifications.Size = New System.Drawing.Size(293, 62)
        Me.btnNotifications.TabIndex = 13
        Me.btnNotifications.Text = "   Log Out                       "
        Me.btnNotifications.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnNotifications.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnNotifications.UseVisualStyleBackColor = True
        '
        'picProfile
        '
        Me.picProfile.Image = Global.AdminSite_OMC.My.Resources.Resources.admin_profile
        Me.picProfile.Location = New System.Drawing.Point(97, 28)
        Me.picProfile.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.picProfile.Name = "picProfile"
        Me.picProfile.Size = New System.Drawing.Size(200, 185)
        Me.picProfile.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.picProfile.TabIndex = 0
        Me.picProfile.TabStop = False
        '
        'ucAdminProfile
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(245, Byte), Integer), CType(CType(245, Byte), Integer), CType(CType(250, Byte), Integer))
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.btnNotifications)
        Me.Controls.Add(Me.btnCopyUserID)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.txtID)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.pnlChangePassword)
        Me.Controls.Add(Me.pnlPersonalInformation)
        Me.Controls.Add(Me.picProfile)
        Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Name = "ucAdminProfile"
        Me.Padding = New System.Windows.Forms.Padding(93, 25, 93, 25)
        Me.Size = New System.Drawing.Size(1413, 886)
        Me.pnlPersonalInformation.ResumeLayout(False)
        Me.pnlPersonalInformation.PerformLayout()
        Me.pnlChangePassword.ResumeLayout(False)
        Me.pnlChangePassword.PerformLayout()
        CType(Me.picProfile, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents picProfile As PictureBox
    Friend WithEvents pnlPersonalInformation As Panel
    Friend WithEvents pnlChangePassword As Panel
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents txtEmail As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents txtLastName As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents txtFirstName As TextBox
    Friend WithEvents txtPhoneNumber As MaskedTextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents txtID As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents btnCopyUserID As Button
    Friend WithEvents btnNotifications As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents Label11 As Label
    Friend WithEvents txtNewPassword As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents txtConfirmPassword As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents btnLogin As Button
End Class
