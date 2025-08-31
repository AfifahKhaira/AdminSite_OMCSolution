<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ucNotifications
    Inherits System.Windows.Forms.UserControl

    'UserControl overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ucNotifications))
        Me.Panel26 = New System.Windows.Forms.Panel()
        Me.Label95 = New System.Windows.Forms.Label()
        Me.Panel27 = New System.Windows.Forms.Panel()
        Me.Label96 = New System.Windows.Forms.Label()
        Me.Panel28 = New System.Windows.Forms.Panel()
        Me.Label97 = New System.Windows.Forms.Label()
        Me.Panel29 = New System.Windows.Forms.Panel()
        Me.Label98 = New System.Windows.Forms.Label()
        Me.Label47 = New System.Windows.Forms.Label()
        Me.Label48 = New System.Windows.Forms.Label()
        Me.cboNotificationStatus = New System.Windows.Forms.ComboBox()
        Me.txtNotificationSearch = New System.Windows.Forms.TextBox()
        Me.cboAudience = New System.Windows.Forms.ComboBox()
        Me.dtpEventTo = New System.Windows.Forms.DateTimePicker()
        Me.Label78 = New System.Windows.Forms.Label()
        Me.dtpEventFrom = New System.Windows.Forms.DateTimePicker()
        Me.btnDeleteSelected = New System.Windows.Forms.Button()
        Me.btnSendSelectedNotification = New System.Windows.Forms.Button()
        Me.Label72 = New System.Windows.Forms.Label()
        Me.btnExportToExcelNotification = New System.Windows.Forms.Button()
        Me.dgvNotificationList = New System.Windows.Forms.DataGridView()
        Me.btnCreateNewNotification = New System.Windows.Forms.Button()
        Me.btnViewSelectedNotification = New System.Windows.Forms.Button()
        Me.Label61 = New System.Windows.Forms.Label()
        Me.Label62 = New System.Windows.Forms.Label()
        Me.Label79 = New System.Windows.Forms.Label()
        Me.Label77 = New System.Windows.Forms.Label()
        Me.Panel26.SuspendLayout()
        Me.Panel27.SuspendLayout()
        Me.Panel28.SuspendLayout()
        Me.Panel29.SuspendLayout()
        CType(Me.dgvNotificationList, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel26
        '
        Me.Panel26.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(249, Byte), Integer), CType(CType(196, Byte), Integer))
        Me.Panel26.Controls.Add(Me.Label95)
        Me.Panel26.Location = New System.Drawing.Point(540, 92)
        Me.Panel26.Margin = New System.Windows.Forms.Padding(2)
        Me.Panel26.Name = "Panel26"
        Me.Panel26.Size = New System.Drawing.Size(238, 37)
        Me.Panel26.TabIndex = 69
        '
        'Label95
        '
        Me.Label95.AutoSize = True
        Me.Label95.BackColor = System.Drawing.Color.Transparent
        Me.Label95.Font = New System.Drawing.Font("Segoe UI", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label95.ForeColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(26, Byte), Integer), CType(CType(29, Byte), Integer))
        Me.Label95.Location = New System.Drawing.Point(67, 7)
        Me.Label95.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label95.Name = "Label95"
        Me.Label95.Size = New System.Drawing.Size(105, 20)
        Me.Label95.TabIndex = 1
        Me.Label95.Text = "Scheduled :   3"
        '
        'Panel27
        '
        Me.Panel27.BackColor = System.Drawing.Color.LightPink
        Me.Panel27.Controls.Add(Me.Label96)
        Me.Panel27.Location = New System.Drawing.Point(796, 92)
        Me.Panel27.Margin = New System.Windows.Forms.Padding(2)
        Me.Panel27.Name = "Panel27"
        Me.Panel27.Size = New System.Drawing.Size(238, 37)
        Me.Panel27.TabIndex = 68
        '
        'Label96
        '
        Me.Label96.AutoSize = True
        Me.Label96.BackColor = System.Drawing.Color.Transparent
        Me.Label96.Font = New System.Drawing.Font("Segoe UI", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label96.ForeColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(26, Byte), Integer), CType(CType(29, Byte), Integer))
        Me.Label96.Location = New System.Drawing.Point(83, 7)
        Me.Label96.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label96.Name = "Label96"
        Me.Label96.Size = New System.Drawing.Size(73, 20)
        Me.Label96.TabIndex = 1
        Me.Label96.Text = "Sent :   22"
        '
        'Panel28
        '
        Me.Panel28.BackColor = System.Drawing.Color.LightGreen
        Me.Panel28.Controls.Add(Me.Label97)
        Me.Panel28.Location = New System.Drawing.Point(282, 92)
        Me.Panel28.Margin = New System.Windows.Forms.Padding(2)
        Me.Panel28.Name = "Panel28"
        Me.Panel28.Size = New System.Drawing.Size(238, 37)
        Me.Panel28.TabIndex = 67
        '
        'Label97
        '
        Me.Label97.AutoSize = True
        Me.Label97.BackColor = System.Drawing.Color.Transparent
        Me.Label97.Font = New System.Drawing.Font("Segoe UI", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label97.ForeColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(26, Byte), Integer), CType(CType(29, Byte), Integer))
        Me.Label97.Location = New System.Drawing.Point(81, 7)
        Me.Label97.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label97.Name = "Label97"
        Me.Label97.Size = New System.Drawing.Size(76, 20)
        Me.Label97.TabIndex = 1
        Me.Label97.Text = "Drafts :   5"
        '
        'Panel29
        '
        Me.Panel29.BackColor = System.Drawing.Color.LightGray
        Me.Panel29.Controls.Add(Me.Label98)
        Me.Panel29.Location = New System.Drawing.Point(26, 92)
        Me.Panel29.Margin = New System.Windows.Forms.Padding(2)
        Me.Panel29.Name = "Panel29"
        Me.Panel29.Size = New System.Drawing.Size(238, 37)
        Me.Panel29.TabIndex = 66
        '
        'Label98
        '
        Me.Label98.AutoSize = True
        Me.Label98.BackColor = System.Drawing.Color.Transparent
        Me.Label98.Font = New System.Drawing.Font("Segoe UI", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label98.ForeColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(26, Byte), Integer), CType(CType(29, Byte), Integer))
        Me.Label98.Location = New System.Drawing.Point(81, 7)
        Me.Label98.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label98.Name = "Label98"
        Me.Label98.Size = New System.Drawing.Size(77, 20)
        Me.Label98.TabIndex = 1
        Me.Label98.Text = "Total :   30"
        '
        'Label47
        '
        Me.Label47.AutoSize = True
        Me.Label47.BackColor = System.Drawing.Color.Transparent
        Me.Label47.Font = New System.Drawing.Font("Segoe UI", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label47.ForeColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(26, Byte), Integer), CType(CType(29, Byte), Integer))
        Me.Label47.Location = New System.Drawing.Point(26, 51)
        Me.Label47.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label47.Name = "Label47"
        Me.Label47.Padding = New System.Windows.Forms.Padding(0, 0, 0, 20)
        Me.Label47.Size = New System.Drawing.Size(244, 39)
        Me.Label47.TabIndex = 65
        Me.Label47.Text = "View, send, and manage system alerts."
        '
        'Label48
        '
        Me.Label48.AutoSize = True
        Me.Label48.BackColor = System.Drawing.Color.Transparent
        Me.Label48.Font = New System.Drawing.Font("Segoe UI", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label48.ForeColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(26, Byte), Integer), CType(CType(29, Byte), Integer))
        Me.Label48.Location = New System.Drawing.Point(26, 20)
        Me.Label48.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label48.Name = "Label48"
        Me.Label48.Size = New System.Drawing.Size(119, 25)
        Me.Label48.TabIndex = 64
        Me.Label48.Text = "Notifications"
        '
        'cboNotificationStatus
        '
        Me.cboNotificationStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboNotificationStatus.Font = New System.Drawing.Font("Segoe UI", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboNotificationStatus.FormattingEnabled = True
        Me.cboNotificationStatus.Items.AddRange(New Object() {"All", "Unread", "Sent", "Draft"})
        Me.cboNotificationStatus.Location = New System.Drawing.Point(871, 275)
        Me.cboNotificationStatus.Margin = New System.Windows.Forms.Padding(2)
        Me.cboNotificationStatus.Name = "cboNotificationStatus"
        Me.cboNotificationStatus.Size = New System.Drawing.Size(163, 27)
        Me.cboNotificationStatus.TabIndex = 85
        '
        'txtNotificationSearch
        '
        Me.txtNotificationSearch.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtNotificationSearch.Font = New System.Drawing.Font("Segoe UI", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNotificationSearch.Location = New System.Drawing.Point(571, 276)
        Me.txtNotificationSearch.Margin = New System.Windows.Forms.Padding(2)
        Me.txtNotificationSearch.Name = "txtNotificationSearch"
        Me.txtNotificationSearch.Size = New System.Drawing.Size(162, 26)
        Me.txtNotificationSearch.TabIndex = 83
        '
        'cboAudience
        '
        Me.cboAudience.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboAudience.Font = New System.Drawing.Font("Segoe UI", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboAudience.FormattingEnabled = True
        Me.cboAudience.Items.AddRange(New Object() {"All", "Users", "Sellers"})
        Me.cboAudience.Location = New System.Drawing.Point(156, 208)
        Me.cboAudience.Margin = New System.Windows.Forms.Padding(2)
        Me.cboAudience.Name = "cboAudience"
        Me.cboAudience.Size = New System.Drawing.Size(282, 27)
        Me.cboAudience.TabIndex = 81
        '
        'dtpEventTo
        '
        Me.dtpEventTo.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpEventTo.Location = New System.Drawing.Point(481, 168)
        Me.dtpEventTo.Name = "dtpEventTo"
        Me.dtpEventTo.Size = New System.Drawing.Size(270, 27)
        Me.dtpEventTo.TabIndex = 79
        '
        'Label78
        '
        Me.Label78.AutoSize = True
        Me.Label78.BackColor = System.Drawing.Color.Transparent
        Me.Label78.Font = New System.Drawing.Font("Segoe UI", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label78.ForeColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(26, Byte), Integer), CType(CType(29, Byte), Integer))
        Me.Label78.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Label78.Location = New System.Drawing.Point(443, 174)
        Me.Label78.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label78.Name = "Label78"
        Me.Label78.Size = New System.Drawing.Size(22, 19)
        Me.Label78.TabIndex = 78
        Me.Label78.Text = "to"
        Me.Label78.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'dtpEventFrom
        '
        Me.dtpEventFrom.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpEventFrom.Location = New System.Drawing.Point(156, 168)
        Me.dtpEventFrom.Name = "dtpEventFrom"
        Me.dtpEventFrom.Size = New System.Drawing.Size(270, 27)
        Me.dtpEventFrom.TabIndex = 77
        '
        'btnDeleteSelected
        '
        Me.btnDeleteSelected.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDeleteSelected.Location = New System.Drawing.Point(687, 546)
        Me.btnDeleteSelected.Name = "btnDeleteSelected"
        Me.btnDeleteSelected.Size = New System.Drawing.Size(170, 30)
        Me.btnDeleteSelected.TabIndex = 75
        Me.btnDeleteSelected.Text = "Delete Selected"
        Me.btnDeleteSelected.UseVisualStyleBackColor = True
        '
        'btnSendSelectedNotification
        '
        Me.btnSendSelectedNotification.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSendSelectedNotification.Location = New System.Drawing.Point(511, 546)
        Me.btnSendSelectedNotification.Name = "btnSendSelectedNotification"
        Me.btnSendSelectedNotification.Size = New System.Drawing.Size(170, 30)
        Me.btnSendSelectedNotification.TabIndex = 74
        Me.btnSendSelectedNotification.Text = "Send Selected"
        Me.btnSendSelectedNotification.UseVisualStyleBackColor = True
        '
        'Label72
        '
        Me.Label72.AutoSize = True
        Me.Label72.BackColor = System.Drawing.Color.Transparent
        Me.Label72.Font = New System.Drawing.Font("Segoe UI", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label72.ForeColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(26, Byte), Integer), CType(CType(29, Byte), Integer))
        Me.Label72.Location = New System.Drawing.Point(26, 277)
        Me.Label72.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label72.Name = "Label72"
        Me.Label72.Size = New System.Drawing.Size(144, 25)
        Me.Label72.TabIndex = 73
        Me.Label72.Text = "Notification List"
        '
        'btnExportToExcelNotification
        '
        Me.btnExportToExcelNotification.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnExportToExcelNotification.Location = New System.Drawing.Point(863, 546)
        Me.btnExportToExcelNotification.Name = "btnExportToExcelNotification"
        Me.btnExportToExcelNotification.Size = New System.Drawing.Size(170, 30)
        Me.btnExportToExcelNotification.TabIndex = 72
        Me.btnExportToExcelNotification.Text = "Export to Excel"
        Me.btnExportToExcelNotification.UseVisualStyleBackColor = True
        '
        'dgvNotificationList
        '
        Me.dgvNotificationList.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvNotificationList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvNotificationList.Location = New System.Drawing.Point(26, 317)
        Me.dgvNotificationList.Margin = New System.Windows.Forms.Padding(2)
        Me.dgvNotificationList.Name = "dgvNotificationList"
        Me.dgvNotificationList.RowHeadersWidth = 51
        Me.dgvNotificationList.RowTemplate.Height = 24
        Me.dgvNotificationList.Size = New System.Drawing.Size(1008, 200)
        Me.dgvNotificationList.TabIndex = 71
        '
        'btnCreateNewNotification
        '
        Me.btnCreateNewNotification.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCreateNewNotification.Location = New System.Drawing.Point(200, 272)
        Me.btnCreateNewNotification.Name = "btnCreateNewNotification"
        Me.btnCreateNewNotification.Size = New System.Drawing.Size(249, 30)
        Me.btnCreateNewNotification.TabIndex = 86
        Me.btnCreateNewNotification.Text = "Create New Notification"
        Me.btnCreateNewNotification.UseVisualStyleBackColor = True
        '
        'btnViewSelectedNotification
        '
        Me.btnViewSelectedNotification.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnViewSelectedNotification.Location = New System.Drawing.Point(335, 546)
        Me.btnViewSelectedNotification.Name = "btnViewSelectedNotification"
        Me.btnViewSelectedNotification.Size = New System.Drawing.Size(170, 30)
        Me.btnViewSelectedNotification.TabIndex = 87
        Me.btnViewSelectedNotification.Text = "View Selected"
        Me.btnViewSelectedNotification.UseVisualStyleBackColor = True
        '
        'Label61
        '
        Me.Label61.AutoSize = True
        Me.Label61.BackColor = System.Drawing.Color.Transparent
        Me.Label61.Font = New System.Drawing.Font("Segoe UI", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label61.ForeColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(26, Byte), Integer), CType(CType(29, Byte), Integer))
        Me.Label61.Image = CType(resources.GetObject("Label61.Image"), System.Drawing.Image)
        Me.Label61.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Label61.Location = New System.Drawing.Point(781, 278)
        Me.Label61.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label61.Name = "Label61"
        Me.Label61.Size = New System.Drawing.Size(86, 19)
        Me.Label61.TabIndex = 84
        Me.Label61.Text = "        Status :"
        Me.Label61.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label62
        '
        Me.Label62.AutoSize = True
        Me.Label62.BackColor = System.Drawing.Color.Transparent
        Me.Label62.Font = New System.Drawing.Font("Segoe UI", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label62.ForeColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(26, Byte), Integer), CType(CType(29, Byte), Integer))
        Me.Label62.Image = CType(resources.GetObject("Label62.Image"), System.Drawing.Image)
        Me.Label62.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Label62.Location = New System.Drawing.Point(479, 278)
        Me.Label62.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label62.Name = "Label62"
        Me.Label62.Size = New System.Drawing.Size(88, 19)
        Me.Label62.TabIndex = 82
        Me.Label62.Text = "        Search :"
        Me.Label62.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label79
        '
        Me.Label79.AutoSize = True
        Me.Label79.BackColor = System.Drawing.Color.Transparent
        Me.Label79.Font = New System.Drawing.Font("Segoe UI", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label79.ForeColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(26, Byte), Integer), CType(CType(29, Byte), Integer))
        Me.Label79.Image = CType(resources.GetObject("Label79.Image"), System.Drawing.Image)
        Me.Label79.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Label79.Location = New System.Drawing.Point(26, 211)
        Me.Label79.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label79.Name = "Label79"
        Me.Label79.Size = New System.Drawing.Size(104, 19)
        Me.Label79.TabIndex = 80
        Me.Label79.Text = "        Audience :"
        Me.Label79.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label77
        '
        Me.Label77.AutoSize = True
        Me.Label77.BackColor = System.Drawing.Color.Transparent
        Me.Label77.Font = New System.Drawing.Font("Segoe UI", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label77.ForeColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(26, Byte), Integer), CType(CType(29, Byte), Integer))
        Me.Label77.Image = Global.AdminSite_OMC.My.Resources.Resources.calendar_icon
        Me.Label77.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Label77.Location = New System.Drawing.Point(26, 174)
        Me.Label77.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label77.Name = "Label77"
        Me.Label77.Size = New System.Drawing.Size(77, 19)
        Me.Label77.TabIndex = 76
        Me.Label77.Text = "        Date :"
        Me.Label77.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'ucNotifications
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(245, Byte), Integer), CType(CType(245, Byte), Integer), CType(CType(250, Byte), Integer))
        Me.Controls.Add(Me.btnViewSelectedNotification)
        Me.Controls.Add(Me.btnCreateNewNotification)
        Me.Controls.Add(Me.cboNotificationStatus)
        Me.Controls.Add(Me.Label61)
        Me.Controls.Add(Me.txtNotificationSearch)
        Me.Controls.Add(Me.Label62)
        Me.Controls.Add(Me.cboAudience)
        Me.Controls.Add(Me.Label79)
        Me.Controls.Add(Me.dtpEventTo)
        Me.Controls.Add(Me.Label78)
        Me.Controls.Add(Me.dtpEventFrom)
        Me.Controls.Add(Me.Label77)
        Me.Controls.Add(Me.btnDeleteSelected)
        Me.Controls.Add(Me.btnSendSelectedNotification)
        Me.Controls.Add(Me.Label72)
        Me.Controls.Add(Me.btnExportToExcelNotification)
        Me.Controls.Add(Me.dgvNotificationList)
        Me.Controls.Add(Me.Panel26)
        Me.Controls.Add(Me.Panel27)
        Me.Controls.Add(Me.Panel28)
        Me.Controls.Add(Me.Panel29)
        Me.Controls.Add(Me.Label47)
        Me.Controls.Add(Me.Label48)
        Me.Name = "ucNotifications"
        Me.Padding = New System.Windows.Forms.Padding(24, 20, 24, 20)
        Me.Size = New System.Drawing.Size(1060, 720)
        Me.Panel26.ResumeLayout(False)
        Me.Panel26.PerformLayout()
        Me.Panel27.ResumeLayout(False)
        Me.Panel27.PerformLayout()
        Me.Panel28.ResumeLayout(False)
        Me.Panel28.PerformLayout()
        Me.Panel29.ResumeLayout(False)
        Me.Panel29.PerformLayout()
        CType(Me.dgvNotificationList, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Panel26 As Panel
    Friend WithEvents Label95 As Label
    Friend WithEvents Panel27 As Panel
    Friend WithEvents Label96 As Label
    Friend WithEvents Panel28 As Panel
    Friend WithEvents Label97 As Label
    Friend WithEvents Panel29 As Panel
    Friend WithEvents Label98 As Label
    Friend WithEvents Label47 As Label
    Friend WithEvents Label48 As Label
    Friend WithEvents cboNotificationStatus As ComboBox
    Friend WithEvents Label61 As Label
    Friend WithEvents txtNotificationSearch As TextBox
    Friend WithEvents Label62 As Label
    Friend WithEvents cboAudience As ComboBox
    Friend WithEvents Label79 As Label
    Friend WithEvents dtpEventTo As DateTimePicker
    Friend WithEvents Label78 As Label
    Friend WithEvents dtpEventFrom As DateTimePicker
    Friend WithEvents Label77 As Label
    Friend WithEvents btnDeleteSelected As Button
    Friend WithEvents btnSendSelectedNotification As Button
    Friend WithEvents Label72 As Label
    Friend WithEvents btnExportToExcelNotification As Button
    Friend WithEvents dgvNotificationList As DataGridView
    Friend WithEvents btnCreateNewNotification As Button
    Friend WithEvents btnViewSelectedNotification As Button
End Class
