<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class ucEvents
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ucEvents))
        Me.cboOrganizer = New System.Windows.Forms.ComboBox()
        Me.dtpEventTo = New System.Windows.Forms.DateTimePicker()
        Me.Label78 = New System.Windows.Forms.Label()
        Me.dtpEventFrom = New System.Windows.Forms.DateTimePicker()
        Me.btnRejectSelectedEvent = New System.Windows.Forms.Button()
        Me.btnApproveSelectedEvent = New System.Windows.Forms.Button()
        Me.Label72 = New System.Windows.Forms.Label()
        Me.btnExportToExcelEvent = New System.Windows.Forms.Button()
        Me.dgvEventList = New System.Windows.Forms.DataGridView()
        Me.Panel11 = New System.Windows.Forms.Panel()
        Me.Label58 = New System.Windows.Forms.Label()
        Me.Panel12 = New System.Windows.Forms.Panel()
        Me.Label59 = New System.Windows.Forms.Label()
        Me.Panel13 = New System.Windows.Forms.Panel()
        Me.Label60 = New System.Windows.Forms.Label()
        Me.Panel16 = New System.Windows.Forms.Panel()
        Me.Label70 = New System.Windows.Forms.Label()
        Me.Label41 = New System.Windows.Forms.Label()
        Me.Label42 = New System.Windows.Forms.Label()
        Me.txtEventSearch = New System.Windows.Forms.TextBox()
        Me.Label61 = New System.Windows.Forms.Label()
        Me.Label62 = New System.Windows.Forms.Label()
        Me.Label79 = New System.Windows.Forms.Label()
        Me.Label77 = New System.Windows.Forms.Label()
        Me.cboEventStatus = New System.Windows.Forms.ComboBox()
        CType(Me.dgvEventList, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel11.SuspendLayout()
        Me.Panel12.SuspendLayout()
        Me.Panel13.SuspendLayout()
        Me.Panel16.SuspendLayout()
        Me.SuspendLayout()
        '
        'cboOrganizer
        '
        Me.cboOrganizer.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboOrganizer.Font = New System.Drawing.Font("Segoe UI", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboOrganizer.FormattingEnabled = True
        Me.cboOrganizer.Location = New System.Drawing.Point(156, 208)
        Me.cboOrganizer.Margin = New System.Windows.Forms.Padding(2)
        Me.cboOrganizer.Name = "cboOrganizer"
        Me.cboOrganizer.Size = New System.Drawing.Size(282, 27)
        Me.cboOrganizer.TabIndex = 62
        '
        'dtpEventTo
        '
        Me.dtpEventTo.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpEventTo.Location = New System.Drawing.Point(481, 168)
        Me.dtpEventTo.Name = "dtpEventTo"
        Me.dtpEventTo.Size = New System.Drawing.Size(270, 27)
        Me.dtpEventTo.TabIndex = 60
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
        Me.Label78.TabIndex = 59
        Me.Label78.Text = "to"
        Me.Label78.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'dtpEventFrom
        '
        Me.dtpEventFrom.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpEventFrom.Location = New System.Drawing.Point(156, 168)
        Me.dtpEventFrom.Name = "dtpEventFrom"
        Me.dtpEventFrom.Size = New System.Drawing.Size(270, 27)
        Me.dtpEventFrom.TabIndex = 58
        '
        'btnRejectSelectedEvent
        '
        Me.btnRejectSelectedEvent.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnRejectSelectedEvent.Location = New System.Drawing.Point(687, 546)
        Me.btnRejectSelectedEvent.Name = "btnRejectSelectedEvent"
        Me.btnRejectSelectedEvent.Size = New System.Drawing.Size(170, 30)
        Me.btnRejectSelectedEvent.TabIndex = 56
        Me.btnRejectSelectedEvent.Text = "Reject Selected"
        Me.btnRejectSelectedEvent.UseVisualStyleBackColor = True
        '
        'btnApproveSelectedEvent
        '
        Me.btnApproveSelectedEvent.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnApproveSelectedEvent.Location = New System.Drawing.Point(511, 546)
        Me.btnApproveSelectedEvent.Name = "btnApproveSelectedEvent"
        Me.btnApproveSelectedEvent.Size = New System.Drawing.Size(170, 30)
        Me.btnApproveSelectedEvent.TabIndex = 55
        Me.btnApproveSelectedEvent.Text = "Approve Selected"
        Me.btnApproveSelectedEvent.UseVisualStyleBackColor = True
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
        Me.Label72.Size = New System.Drawing.Size(91, 25)
        Me.Label72.TabIndex = 54
        Me.Label72.Text = "Event List"
        '
        'btnExportToExcelEvent
        '
        Me.btnExportToExcelEvent.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnExportToExcelEvent.Location = New System.Drawing.Point(863, 546)
        Me.btnExportToExcelEvent.Name = "btnExportToExcelEvent"
        Me.btnExportToExcelEvent.Size = New System.Drawing.Size(170, 30)
        Me.btnExportToExcelEvent.TabIndex = 53
        Me.btnExportToExcelEvent.Text = "Export to Excel"
        Me.btnExportToExcelEvent.UseVisualStyleBackColor = True
        '
        'dgvEventList
        '
        Me.dgvEventList.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvEventList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvEventList.Location = New System.Drawing.Point(26, 317)
        Me.dgvEventList.Margin = New System.Windows.Forms.Padding(2)
        Me.dgvEventList.Name = "dgvEventList"
        Me.dgvEventList.RowHeadersWidth = 51
        Me.dgvEventList.RowTemplate.Height = 24
        Me.dgvEventList.Size = New System.Drawing.Size(1008, 200)
        Me.dgvEventList.TabIndex = 52
        '
        'Panel11
        '
        Me.Panel11.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(249, Byte), Integer), CType(CType(196, Byte), Integer))
        Me.Panel11.Controls.Add(Me.Label58)
        Me.Panel11.Location = New System.Drawing.Point(540, 92)
        Me.Panel11.Margin = New System.Windows.Forms.Padding(2)
        Me.Panel11.Name = "Panel11"
        Me.Panel11.Size = New System.Drawing.Size(238, 37)
        Me.Panel11.TabIndex = 47
        '
        'Label58
        '
        Me.Label58.AutoSize = True
        Me.Label58.BackColor = System.Drawing.Color.Transparent
        Me.Label58.Font = New System.Drawing.Font("Segoe UI", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label58.ForeColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(26, Byte), Integer), CType(CType(29, Byte), Integer))
        Me.Label58.Location = New System.Drawing.Point(75, 7)
        Me.Label58.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label58.Name = "Label58"
        Me.Label58.Size = New System.Drawing.Size(89, 20)
        Me.Label58.TabIndex = 1
        Me.Label58.Text = "Pending :   8"
        '
        'Panel12
        '
        Me.Panel12.BackColor = System.Drawing.Color.LightPink
        Me.Panel12.Controls.Add(Me.Label59)
        Me.Panel12.Location = New System.Drawing.Point(796, 92)
        Me.Panel12.Margin = New System.Windows.Forms.Padding(2)
        Me.Panel12.Name = "Panel12"
        Me.Panel12.Size = New System.Drawing.Size(238, 37)
        Me.Panel12.TabIndex = 46
        '
        'Label59
        '
        Me.Label59.AutoSize = True
        Me.Label59.BackColor = System.Drawing.Color.Transparent
        Me.Label59.Font = New System.Drawing.Font("Segoe UI", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label59.ForeColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(26, Byte), Integer), CType(CType(29, Byte), Integer))
        Me.Label59.Location = New System.Drawing.Point(72, 7)
        Me.Label59.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label59.Name = "Label59"
        Me.Label59.Size = New System.Drawing.Size(94, 20)
        Me.Label59.TabIndex = 1
        Me.Label59.Text = "Rejected :   4"
        '
        'Panel13
        '
        Me.Panel13.BackColor = System.Drawing.Color.LightGreen
        Me.Panel13.Controls.Add(Me.Label60)
        Me.Panel13.Location = New System.Drawing.Point(282, 92)
        Me.Panel13.Margin = New System.Windows.Forms.Padding(2)
        Me.Panel13.Name = "Panel13"
        Me.Panel13.Size = New System.Drawing.Size(238, 37)
        Me.Panel13.TabIndex = 45
        '
        'Label60
        '
        Me.Label60.AutoSize = True
        Me.Label60.BackColor = System.Drawing.Color.Transparent
        Me.Label60.Font = New System.Drawing.Font("Segoe UI", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label60.ForeColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(26, Byte), Integer), CType(CType(29, Byte), Integer))
        Me.Label60.Location = New System.Drawing.Point(64, 7)
        Me.Label60.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label60.Name = "Label60"
        Me.Label60.Size = New System.Drawing.Size(110, 20)
        Me.Label60.TabIndex = 1
        Me.Label60.Text = "Approved :   40"
        '
        'Panel16
        '
        Me.Panel16.BackColor = System.Drawing.Color.LightGray
        Me.Panel16.Controls.Add(Me.Label70)
        Me.Panel16.Location = New System.Drawing.Point(26, 92)
        Me.Panel16.Margin = New System.Windows.Forms.Padding(2)
        Me.Panel16.Name = "Panel16"
        Me.Panel16.Size = New System.Drawing.Size(238, 37)
        Me.Panel16.TabIndex = 44
        '
        'Label70
        '
        Me.Label70.AutoSize = True
        Me.Label70.BackColor = System.Drawing.Color.Transparent
        Me.Label70.Font = New System.Drawing.Font("Segoe UI", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label70.ForeColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(26, Byte), Integer), CType(CType(29, Byte), Integer))
        Me.Label70.Location = New System.Drawing.Point(58, 7)
        Me.Label70.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label70.Name = "Label70"
        Me.Label70.Size = New System.Drawing.Size(123, 20)
        Me.Label70.TabIndex = 1
        Me.Label70.Text = "Total Events :   52"
        '
        'Label41
        '
        Me.Label41.AutoSize = True
        Me.Label41.BackColor = System.Drawing.Color.Transparent
        Me.Label41.Font = New System.Drawing.Font("Segoe UI", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label41.ForeColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(26, Byte), Integer), CType(CType(29, Byte), Integer))
        Me.Label41.Location = New System.Drawing.Point(26, 51)
        Me.Label41.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label41.Name = "Label41"
        Me.Label41.Padding = New System.Windows.Forms.Padding(0, 0, 0, 20)
        Me.Label41.Size = New System.Drawing.Size(300, 39)
        Me.Label41.TabIndex = 43
        Me.Label41.Text = "Manage upcoming, past, and submitted events."
        '
        'Label42
        '
        Me.Label42.AutoSize = True
        Me.Label42.BackColor = System.Drawing.Color.Transparent
        Me.Label42.Font = New System.Drawing.Font("Segoe UI", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label42.ForeColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(26, Byte), Integer), CType(CType(29, Byte), Integer))
        Me.Label42.Location = New System.Drawing.Point(26, 20)
        Me.Label42.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label42.Name = "Label42"
        Me.Label42.Size = New System.Drawing.Size(66, 25)
        Me.Label42.TabIndex = 42
        Me.Label42.Text = "Events"
        '
        'txtEventSearch
        '
        Me.txtEventSearch.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtEventSearch.Font = New System.Drawing.Font("Segoe UI", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtEventSearch.Location = New System.Drawing.Point(524, 276)
        Me.txtEventSearch.Margin = New System.Windows.Forms.Padding(2)
        Me.txtEventSearch.Name = "txtEventSearch"
        Me.txtEventSearch.Size = New System.Drawing.Size(162, 26)
        Me.txtEventSearch.TabIndex = 65
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
        Me.Label61.TabIndex = 66
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
        Me.Label62.Location = New System.Drawing.Point(432, 278)
        Me.Label62.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label62.Name = "Label62"
        Me.Label62.Size = New System.Drawing.Size(88, 19)
        Me.Label62.TabIndex = 64
        Me.Label62.Text = "        Search :"
        Me.Label62.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label79
        '
        Me.Label79.AutoSize = True
        Me.Label79.BackColor = System.Drawing.Color.Transparent
        Me.Label79.Font = New System.Drawing.Font("Segoe UI", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label79.ForeColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(26, Byte), Integer), CType(CType(29, Byte), Integer))
        Me.Label79.Image = Global.AdminSite_OMC.My.Resources.Resources.organizer_icon
        Me.Label79.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Label79.Location = New System.Drawing.Point(26, 211)
        Me.Label79.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label79.Name = "Label79"
        Me.Label79.Size = New System.Drawing.Size(108, 19)
        Me.Label79.TabIndex = 61
        Me.Label79.Text = "        Organizer :"
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
        Me.Label77.TabIndex = 57
        Me.Label77.Text = "        Date :"
        Me.Label77.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'cboEventStatus
        '
        Me.cboEventStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboEventStatus.Font = New System.Drawing.Font("Segoe UI", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboEventStatus.FormattingEnabled = True
        Me.cboEventStatus.Items.AddRange(New Object() {"All", "Approved", "Pending", "Rejected"})
        Me.cboEventStatus.Location = New System.Drawing.Point(871, 275)
        Me.cboEventStatus.Margin = New System.Windows.Forms.Padding(2)
        Me.cboEventStatus.Name = "cboEventStatus"
        Me.cboEventStatus.Size = New System.Drawing.Size(163, 27)
        Me.cboEventStatus.TabIndex = 68
        '
        'ucEvents
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(245, Byte), Integer), CType(CType(245, Byte), Integer), CType(CType(250, Byte), Integer))
        Me.Controls.Add(Me.cboEventStatus)
        Me.Controls.Add(Me.Label61)
        Me.Controls.Add(Me.txtEventSearch)
        Me.Controls.Add(Me.Label62)
        Me.Controls.Add(Me.cboOrganizer)
        Me.Controls.Add(Me.Label79)
        Me.Controls.Add(Me.dtpEventTo)
        Me.Controls.Add(Me.Label78)
        Me.Controls.Add(Me.dtpEventFrom)
        Me.Controls.Add(Me.Label77)
        Me.Controls.Add(Me.btnRejectSelectedEvent)
        Me.Controls.Add(Me.btnApproveSelectedEvent)
        Me.Controls.Add(Me.Label72)
        Me.Controls.Add(Me.btnExportToExcelEvent)
        Me.Controls.Add(Me.dgvEventList)
        Me.Controls.Add(Me.Panel11)
        Me.Controls.Add(Me.Panel12)
        Me.Controls.Add(Me.Panel13)
        Me.Controls.Add(Me.Panel16)
        Me.Controls.Add(Me.Label41)
        Me.Controls.Add(Me.Label42)
        Me.Name = "ucEvents"
        Me.Padding = New System.Windows.Forms.Padding(24, 20, 24, 20)
        Me.Size = New System.Drawing.Size(1060, 720)
        CType(Me.dgvEventList, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel11.ResumeLayout(False)
        Me.Panel11.PerformLayout()
        Me.Panel12.ResumeLayout(False)
        Me.Panel12.PerformLayout()
        Me.Panel13.ResumeLayout(False)
        Me.Panel13.PerformLayout()
        Me.Panel16.ResumeLayout(False)
        Me.Panel16.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents cboOrganizer As ComboBox
    Friend WithEvents Label79 As Label
    Friend WithEvents dtpEventTo As DateTimePicker
    Friend WithEvents Label78 As Label
    Friend WithEvents dtpEventFrom As DateTimePicker
    Friend WithEvents Label77 As Label
    Friend WithEvents btnRejectSelectedEvent As Button
    Friend WithEvents btnApproveSelectedEvent As Button
    Friend WithEvents Label72 As Label
    Friend WithEvents btnExportToExcelEvent As Button
    Friend WithEvents dgvEventList As DataGridView
    Friend WithEvents Panel11 As Panel
    Friend WithEvents Label58 As Label
    Friend WithEvents Panel12 As Panel
    Friend WithEvents Label59 As Label
    Friend WithEvents Panel13 As Panel
    Friend WithEvents Label60 As Label
    Friend WithEvents Panel16 As Panel
    Friend WithEvents Label70 As Label
    Friend WithEvents Label41 As Label
    Friend WithEvents Label42 As Label
    Friend WithEvents Label61 As Label
    Friend WithEvents txtEventSearch As TextBox
    Friend WithEvents Label62 As Label
    Friend WithEvents cboEventStatus As ComboBox
End Class
