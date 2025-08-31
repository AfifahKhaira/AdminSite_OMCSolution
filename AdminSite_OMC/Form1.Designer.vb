<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtEmailUserID = New System.Windows.Forms.TextBox()
        Me.txtPassword = New System.Windows.Forms.TextBox()
        Me.chkRemember = New System.Windows.Forms.CheckBox()
        Me.lnkForgotPass = New System.Windows.Forms.LinkLabel()
        Me.btnLogin = New System.Windows.Forms.Button()
        Me.pnlLogin = New System.Windows.Forms.Panel()
        Me.pcbSunbearWelcome = New System.Windows.Forms.PictureBox()
        Me.pnlForgotPassword = New System.Windows.Forms.Panel()
        Me.btnBackToLogin = New System.Windows.Forms.Button()
        Me.btnSendEmail = New System.Windows.Forms.Button()
        Me.txtEmailForgotPassword = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.pcbSunbearWrong = New System.Windows.Forms.PictureBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.pcbSunbearWelcome2 = New System.Windows.Forms.PictureBox()
        Me.pcbSunbearWrong2 = New System.Windows.Forms.PictureBox()
        Me.pnlLogin.SuspendLayout()
        CType(Me.pcbSunbearWelcome, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlForgotPassword.SuspendLayout()
        CType(Me.pcbSunbearWrong, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pcbSunbearWelcome2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pcbSunbearWrong2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(373, 60)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(127, 54)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Login"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Gray
        Me.Label2.Location = New System.Drawing.Point(299, 114)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(274, 25)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Please login to admin dashboard"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Segoe UI", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer))
        Me.Label3.Location = New System.Drawing.Point(169, 165)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(127, 25)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Email/User ID*"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Segoe UI", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer))
        Me.Label4.Location = New System.Drawing.Point(169, 246)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(95, 25)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Password*"
        '
        'txtEmailUserID
        '
        Me.txtEmailUserID.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtEmailUserID.Location = New System.Drawing.Point(175, 201)
        Me.txtEmailUserID.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtEmailUserID.Name = "txtEmailUserID"
        Me.txtEmailUserID.Size = New System.Drawing.Size(523, 34)
        Me.txtEmailUserID.TabIndex = 4
        '
        'txtPassword
        '
        Me.txtPassword.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPassword.Location = New System.Drawing.Point(175, 282)
        Me.txtPassword.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtPassword.Name = "txtPassword"
        Me.txtPassword.Size = New System.Drawing.Size(523, 34)
        Me.txtPassword.TabIndex = 5
        '
        'chkRemember
        '
        Me.chkRemember.AutoSize = True
        Me.chkRemember.Font = New System.Drawing.Font("Segoe UI", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkRemember.ForeColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer))
        Me.chkRemember.Location = New System.Drawing.Point(173, 340)
        Me.chkRemember.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.chkRemember.Name = "chkRemember"
        Me.chkRemember.Size = New System.Drawing.Size(116, 21)
        Me.chkRemember.TabIndex = 6
        Me.chkRemember.Text = "Remember me"
        Me.chkRemember.UseVisualStyleBackColor = True
        '
        'lnkForgotPass
        '
        Me.lnkForgotPass.Font = New System.Drawing.Font("Segoe UI", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lnkForgotPass.LinkColor = System.Drawing.Color.FromArgb(CType(CType(162, Byte), Integer), CType(CType(167, Byte), Integer), CType(CType(249, Byte), Integer))
        Me.lnkForgotPass.Location = New System.Drawing.Point(565, 327)
        Me.lnkForgotPass.Name = "lnkForgotPass"
        Me.lnkForgotPass.Size = New System.Drawing.Size(133, 42)
        Me.lnkForgotPass.TabIndex = 7
        Me.lnkForgotPass.TabStop = True
        Me.lnkForgotPass.Text = "Forgot password?"
        Me.lnkForgotPass.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'btnLogin
        '
        Me.btnLogin.BackColor = System.Drawing.Color.FromArgb(CType(CType(162, Byte), Integer), CType(CType(167, Byte), Integer), CType(CType(249, Byte), Integer))
        Me.btnLogin.Font = New System.Drawing.Font("Segoe UI", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnLogin.ForeColor = System.Drawing.Color.White
        Me.btnLogin.Location = New System.Drawing.Point(175, 385)
        Me.btnLogin.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnLogin.Name = "btnLogin"
        Me.btnLogin.Size = New System.Drawing.Size(523, 48)
        Me.btnLogin.TabIndex = 8
        Me.btnLogin.Text = "Login"
        Me.btnLogin.UseVisualStyleBackColor = False
        '
        'pnlLogin
        '
        Me.pnlLogin.BackColor = System.Drawing.Color.White
        Me.pnlLogin.Controls.Add(Me.btnLogin)
        Me.pnlLogin.Controls.Add(Me.lnkForgotPass)
        Me.pnlLogin.Controls.Add(Me.chkRemember)
        Me.pnlLogin.Controls.Add(Me.txtPassword)
        Me.pnlLogin.Controls.Add(Me.txtEmailUserID)
        Me.pnlLogin.Controls.Add(Me.Label4)
        Me.pnlLogin.Controls.Add(Me.Label3)
        Me.pnlLogin.Controls.Add(Me.Label2)
        Me.pnlLogin.Controls.Add(Me.Label1)
        Me.pnlLogin.Controls.Add(Me.pcbSunbearWelcome)
        Me.pnlLogin.Location = New System.Drawing.Point(420, 286)
        Me.pnlLogin.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.pnlLogin.Name = "pnlLogin"
        Me.pnlLogin.Size = New System.Drawing.Size(867, 492)
        Me.pnlLogin.TabIndex = 0
        '
        'pcbSunbearWelcome
        '
        Me.pcbSunbearWelcome.BackColor = System.Drawing.Color.Transparent
        Me.pcbSunbearWelcome.Image = Global.AdminSite_OMC.My.Resources.Resources.sunbear_welcome_picture
        Me.pcbSunbearWelcome.Location = New System.Drawing.Point(665, 101)
        Me.pcbSunbearWelcome.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.pcbSunbearWelcome.Name = "pcbSunbearWelcome"
        Me.pcbSunbearWelcome.Size = New System.Drawing.Size(300, 300)
        Me.pcbSunbearWelcome.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.pcbSunbearWelcome.TabIndex = 2
        Me.pcbSunbearWelcome.TabStop = False
        '
        'pnlForgotPassword
        '
        Me.pnlForgotPassword.BackColor = System.Drawing.Color.White
        Me.pnlForgotPassword.Controls.Add(Me.btnBackToLogin)
        Me.pnlForgotPassword.Controls.Add(Me.btnSendEmail)
        Me.pnlForgotPassword.Controls.Add(Me.txtEmailForgotPassword)
        Me.pnlForgotPassword.Controls.Add(Me.Label5)
        Me.pnlForgotPassword.Controls.Add(Me.Label6)
        Me.pnlForgotPassword.Controls.Add(Me.Label7)
        Me.pnlForgotPassword.Controls.Add(Me.pcbSunbearWrong)
        Me.pnlForgotPassword.Location = New System.Drawing.Point(420, 286)
        Me.pnlForgotPassword.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.pnlForgotPassword.Name = "pnlForgotPassword"
        Me.pnlForgotPassword.Size = New System.Drawing.Size(867, 492)
        Me.pnlForgotPassword.TabIndex = 12
        '
        'btnBackToLogin
        '
        Me.btnBackToLogin.BackColor = System.Drawing.Color.LightGray
        Me.btnBackToLogin.Font = New System.Drawing.Font("Segoe UI", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBackToLogin.ForeColor = System.Drawing.Color.White
        Me.btnBackToLogin.Location = New System.Drawing.Point(175, 332)
        Me.btnBackToLogin.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnBackToLogin.Name = "btnBackToLogin"
        Me.btnBackToLogin.Size = New System.Drawing.Size(523, 48)
        Me.btnBackToLogin.TabIndex = 11
        Me.btnBackToLogin.Text = "Back"
        Me.btnBackToLogin.UseVisualStyleBackColor = False
        '
        'btnSendEmail
        '
        Me.btnSendEmail.BackColor = System.Drawing.Color.FromArgb(CType(CType(162, Byte), Integer), CType(CType(167, Byte), Integer), CType(CType(249, Byte), Integer))
        Me.btnSendEmail.Font = New System.Drawing.Font("Segoe UI", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSendEmail.ForeColor = System.Drawing.Color.White
        Me.btnSendEmail.Location = New System.Drawing.Point(175, 385)
        Me.btnSendEmail.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnSendEmail.Name = "btnSendEmail"
        Me.btnSendEmail.Size = New System.Drawing.Size(523, 48)
        Me.btnSendEmail.TabIndex = 8
        Me.btnSendEmail.Text = "Send email"
        Me.btnSendEmail.UseVisualStyleBackColor = False
        '
        'txtEmailForgotPassword
        '
        Me.txtEmailForgotPassword.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtEmailForgotPassword.Location = New System.Drawing.Point(175, 230)
        Me.txtEmailForgotPassword.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtEmailForgotPassword.Name = "txtEmailForgotPassword"
        Me.txtEmailForgotPassword.Size = New System.Drawing.Size(523, 34)
        Me.txtEmailForgotPassword.TabIndex = 4
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Segoe UI", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer))
        Me.Label5.Location = New System.Drawing.Point(169, 193)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(54, 25)
        Me.Label5.TabIndex = 2
        Me.Label5.Text = "Email"
        '
        'Label6
        '
        Me.Label6.Font = New System.Drawing.Font("Segoe UI", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.Gray
        Me.Label6.Location = New System.Drawing.Point(255, 114)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(363, 64)
        Me.Label6.TabIndex = 1
        Me.Label6.Text = "Enter your email address to receive a code to reset your password"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Segoe UI", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer))
        Me.Label7.Location = New System.Drawing.Point(259, 60)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(357, 54)
        Me.Label7.TabIndex = 0
        Me.Label7.Text = "Forgot Password?"
        '
        'pcbSunbearWrong
        '
        Me.pcbSunbearWrong.BackColor = System.Drawing.Color.Transparent
        Me.pcbSunbearWrong.Image = Global.AdminSite_OMC.My.Resources.Resources.sunbear_wrong_picture
        Me.pcbSunbearWrong.Location = New System.Drawing.Point(665, 101)
        Me.pcbSunbearWrong.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.pcbSunbearWrong.Name = "pcbSunbearWrong"
        Me.pcbSunbearWrong.Size = New System.Drawing.Size(300, 300)
        Me.pcbSunbearWrong.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.pcbSunbearWrong.TabIndex = 10
        Me.pcbSunbearWrong.TabStop = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(0, 0)
        Me.PictureBox1.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(1707, 382)
        Me.PictureBox1.TabIndex = 1
        Me.PictureBox1.TabStop = False
        '
        'pcbSunbearWelcome2
        '
        Me.pcbSunbearWelcome2.BackColor = System.Drawing.Color.Transparent
        Me.pcbSunbearWelcome2.Image = Global.AdminSite_OMC.My.Resources.Resources.sunbear_welcome_picture
        Me.pcbSunbearWelcome2.Location = New System.Drawing.Point(1085, 386)
        Me.pcbSunbearWelcome2.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.pcbSunbearWelcome2.Name = "pcbSunbearWelcome2"
        Me.pcbSunbearWelcome2.Size = New System.Drawing.Size(300, 300)
        Me.pcbSunbearWelcome2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.pcbSunbearWelcome2.TabIndex = 9
        Me.pcbSunbearWelcome2.TabStop = False
        '
        'pcbSunbearWrong2
        '
        Me.pcbSunbearWrong2.BackColor = System.Drawing.Color.Transparent
        Me.pcbSunbearWrong2.Image = Global.AdminSite_OMC.My.Resources.Resources.sunbear_wrong_picture
        Me.pcbSunbearWrong2.Location = New System.Drawing.Point(1085, 386)
        Me.pcbSunbearWrong2.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.pcbSunbearWrong2.Name = "pcbSunbearWrong2"
        Me.pcbSunbearWrong2.Size = New System.Drawing.Size(300, 300)
        Me.pcbSunbearWrong2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.pcbSunbearWrong2.TabIndex = 13
        Me.pcbSunbearWrong2.TabStop = False
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(245, Byte), Integer), CType(CType(245, Byte), Integer), CType(CType(250, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1707, 886)
        Me.Controls.Add(Me.pnlLogin)
        Me.Controls.Add(Me.pnlForgotPassword)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.pcbSunbearWelcome2)
        Me.Controls.Add(Me.pcbSunbearWrong2)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Form1"
        Me.pnlLogin.ResumeLayout(False)
        Me.pnlLogin.PerformLayout()
        CType(Me.pcbSunbearWelcome, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlForgotPassword.ResumeLayout(False)
        Me.pnlForgotPassword.PerformLayout()
        CType(Me.pcbSunbearWrong, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pcbSunbearWelcome2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pcbSunbearWrong2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Panel2 As Panel
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents txtEmailUserID As TextBox
    Friend WithEvents txtPassword As TextBox
    Friend WithEvents chkRemember As CheckBox
    Friend WithEvents lnkForgotPass As LinkLabel
    Friend WithEvents btnLogin As Button
    Friend WithEvents pnlLogin As Panel
    Friend WithEvents pcbSunbearWelcome As PictureBox
    Friend WithEvents pcbSunbearWelcome2 As PictureBox
    Friend WithEvents pnlForgotPassword As Panel
    Friend WithEvents btnBackToLogin As Button
    Friend WithEvents btnSendEmail As Button
    Friend WithEvents txtEmailForgotPassword As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents pcbSunbearWrong As PictureBox
    Friend WithEvents pcbSunbearWrong2 As PictureBox
End Class
