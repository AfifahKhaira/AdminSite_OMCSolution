<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class ucUsers
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ucUsers))
        Dim ChartArea1 As System.Windows.Forms.DataVisualization.Charting.ChartArea = New System.Windows.Forms.DataVisualization.Charting.ChartArea()
        Dim Legend1 As System.Windows.Forms.DataVisualization.Charting.Legend = New System.Windows.Forms.DataVisualization.Charting.Legend()
        Dim Series1 As System.Windows.Forms.DataVisualization.Charting.Series = New System.Windows.Forms.DataVisualization.Charting.Series()
        Dim Title1 As System.Windows.Forms.DataVisualization.Charting.Title = New System.Windows.Forms.DataVisualization.Charting.Title()
        Dim ChartArea2 As System.Windows.Forms.DataVisualization.Charting.ChartArea = New System.Windows.Forms.DataVisualization.Charting.ChartArea()
        Dim Legend2 As System.Windows.Forms.DataVisualization.Charting.Legend = New System.Windows.Forms.DataVisualization.Charting.Legend()
        Dim Series2 As System.Windows.Forms.DataVisualization.Charting.Series = New System.Windows.Forms.DataVisualization.Charting.Series()
        Dim Title2 As System.Windows.Forms.DataVisualization.Charting.Title = New System.Windows.Forms.DataVisualization.Charting.Title()
        Dim ChartArea3 As System.Windows.Forms.DataVisualization.Charting.ChartArea = New System.Windows.Forms.DataVisualization.Charting.ChartArea()
        Dim Legend3 As System.Windows.Forms.DataVisualization.Charting.Legend = New System.Windows.Forms.DataVisualization.Charting.Legend()
        Dim Series3 As System.Windows.Forms.DataVisualization.Charting.Series = New System.Windows.Forms.DataVisualization.Charting.Series()
        Dim Title3 As System.Windows.Forms.DataVisualization.Charting.Title = New System.Windows.Forms.DataVisualization.Charting.Title()
        Me.btnDeleteSelectedUser = New System.Windows.Forms.Button()
        Me.Label55 = New System.Windows.Forms.Label()
        Me.btnExportToExcelUser = New System.Windows.Forms.Button()
        Me.dgvUserList = New System.Windows.Forms.DataGridView()
        Me.Panel9 = New System.Windows.Forms.Panel()
        Me.Label56 = New System.Windows.Forms.Label()
        Me.Panel8 = New System.Windows.Forms.Panel()
        Me.Label54 = New System.Windows.Forms.Label()
        Me.Panel7 = New System.Windows.Forms.Panel()
        Me.Label53 = New System.Windows.Forms.Label()
        Me.cboUserStatus = New System.Windows.Forms.ComboBox()
        Me.txtUserSearch = New System.Windows.Forms.TextBox()
        Me.Label74 = New System.Windows.Forms.Label()
        Me.Label75 = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label38 = New System.Windows.Forms.Label()
        Me.Label37 = New System.Windows.Forms.Label()
        Me.chartUserActivity = New System.Windows.Forms.DataVisualization.Charting.Chart()
        Me.chartUserLoginTrend = New System.Windows.Forms.DataVisualization.Charting.Chart()
        Me.chartUserType = New System.Windows.Forms.DataVisualization.Charting.Chart()
        CType(Me.dgvUserList, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel9.SuspendLayout()
        Me.Panel8.SuspendLayout()
        Me.Panel7.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.Panel3.SuspendLayout()
        CType(Me.chartUserActivity, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.chartUserLoginTrend, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.chartUserType, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnDeleteSelectedUser
        '
        Me.btnDeleteSelectedUser.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDeleteSelectedUser.Location = New System.Drawing.Point(916, 821)
        Me.btnDeleteSelectedUser.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btnDeleteSelectedUser.Name = "btnDeleteSelectedUser"
        Me.btnDeleteSelectedUser.Size = New System.Drawing.Size(227, 37)
        Me.btnDeleteSelectedUser.TabIndex = 44
        Me.btnDeleteSelectedUser.Text = "Delete Selected"
        Me.btnDeleteSelectedUser.UseVisualStyleBackColor = True
        '
        'Label55
        '
        Me.Label55.AutoSize = True
        Me.Label55.BackColor = System.Drawing.Color.Transparent
        Me.Label55.Font = New System.Drawing.Font("Segoe UI", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label55.ForeColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(26, Byte), Integer), CType(CType(29, Byte), Integer))
        Me.Label55.Location = New System.Drawing.Point(35, 490)
        Me.Label55.Name = "Label55"
        Me.Label55.Size = New System.Drawing.Size(101, 31)
        Me.Label55.TabIndex = 40
        Me.Label55.Text = "User List"
        '
        'btnExportToExcelUser
        '
        Me.btnExportToExcelUser.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnExportToExcelUser.Location = New System.Drawing.Point(1151, 821)
        Me.btnExportToExcelUser.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btnExportToExcelUser.Name = "btnExportToExcelUser"
        Me.btnExportToExcelUser.Size = New System.Drawing.Size(227, 37)
        Me.btnExportToExcelUser.TabIndex = 39
        Me.btnExportToExcelUser.Text = "Export to Excel"
        Me.btnExportToExcelUser.UseVisualStyleBackColor = True
        '
        'dgvUserList
        '
        Me.dgvUserList.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvUserList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvUserList.Location = New System.Drawing.Point(35, 539)
        Me.dgvUserList.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.dgvUserList.Name = "dgvUserList"
        Me.dgvUserList.RowHeadersWidth = 51
        Me.dgvUserList.RowTemplate.Height = 24
        Me.dgvUserList.Size = New System.Drawing.Size(1344, 246)
        Me.dgvUserList.TabIndex = 36
        '
        'Panel9
        '
        Me.Panel9.BackColor = System.Drawing.Color.LightPink
        Me.Panel9.Controls.Add(Me.Label56)
        Me.Panel9.Location = New System.Drawing.Point(577, 113)
        Me.Panel9.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Panel9.Name = "Panel9"
        Me.Panel9.Size = New System.Drawing.Size(260, 46)
        Me.Panel9.TabIndex = 35
        '
        'Label56
        '
        Me.Label56.AutoSize = True
        Me.Label56.BackColor = System.Drawing.Color.Transparent
        Me.Label56.Font = New System.Drawing.Font("Segoe UI", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label56.ForeColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(26, Byte), Integer), CType(CType(29, Byte), Integer))
        Me.Label56.Location = New System.Drawing.Point(72, 9)
        Me.Label56.Name = "Label56"
        Me.Label56.Size = New System.Drawing.Size(106, 25)
        Me.Label56.TabIndex = 1
        Me.Label56.Text = "Inactive :   7"
        '
        'Panel8
        '
        Me.Panel8.BackColor = System.Drawing.Color.LightGreen
        Me.Panel8.Controls.Add(Me.Label54)
        Me.Panel8.Location = New System.Drawing.Point(307, 113)
        Me.Panel8.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Panel8.Name = "Panel8"
        Me.Panel8.Size = New System.Drawing.Size(260, 46)
        Me.Panel8.TabIndex = 34
        '
        'Label54
        '
        Me.Label54.AutoSize = True
        Me.Label54.BackColor = System.Drawing.Color.Transparent
        Me.Label54.Font = New System.Drawing.Font("Segoe UI", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label54.ForeColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(26, Byte), Integer), CType(CType(29, Byte), Integer))
        Me.Label54.Location = New System.Drawing.Point(73, 9)
        Me.Label54.Name = "Label54"
        Me.Label54.Size = New System.Drawing.Size(104, 25)
        Me.Label54.TabIndex = 1
        Me.Label54.Text = "Active :   83"
        '
        'Panel7
        '
        Me.Panel7.BackColor = System.Drawing.Color.LightGray
        Me.Panel7.Controls.Add(Me.Label53)
        Me.Panel7.Location = New System.Drawing.Point(36, 113)
        Me.Panel7.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Panel7.Name = "Panel7"
        Me.Panel7.Size = New System.Drawing.Size(260, 46)
        Me.Panel7.TabIndex = 33
        '
        'Label53
        '
        Me.Label53.AutoSize = True
        Me.Label53.BackColor = System.Drawing.Color.Transparent
        Me.Label53.Font = New System.Drawing.Font("Segoe UI", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label53.ForeColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(26, Byte), Integer), CType(CType(29, Byte), Integer))
        Me.Label53.Location = New System.Drawing.Point(52, 9)
        Me.Label53.Name = "Label53"
        Me.Label53.Size = New System.Drawing.Size(141, 25)
        Me.Label53.TabIndex = 1
        Me.Label53.Text = "Total Users :   90"
        '
        'cboUserStatus
        '
        Me.cboUserStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboUserStatus.Font = New System.Drawing.Font("Segoe UI", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboUserStatus.FormattingEnabled = True
        Me.cboUserStatus.Items.AddRange(New Object() {"All", "Active", "Inactive", "Premium", "Basic"})
        Me.cboUserStatus.Location = New System.Drawing.Point(1161, 487)
        Me.cboUserStatus.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.cboUserStatus.Name = "cboUserStatus"
        Me.cboUserStatus.Size = New System.Drawing.Size(216, 31)
        Me.cboUserStatus.TabIndex = 32
        '
        'txtUserSearch
        '
        Me.txtUserSearch.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtUserSearch.Font = New System.Drawing.Font("Segoe UI", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtUserSearch.Location = New System.Drawing.Point(699, 489)
        Me.txtUserSearch.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtUserSearch.Name = "txtUserSearch"
        Me.txtUserSearch.Size = New System.Drawing.Size(215, 30)
        Me.txtUserSearch.TabIndex = 30
        '
        'Label74
        '
        Me.Label74.AutoSize = True
        Me.Label74.BackColor = System.Drawing.Color.Transparent
        Me.Label74.Font = New System.Drawing.Font("Segoe UI", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label74.ForeColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(26, Byte), Integer), CType(CType(29, Byte), Integer))
        Me.Label74.Location = New System.Drawing.Point(35, 63)
        Me.Label74.Name = "Label74"
        Me.Label74.Padding = New System.Windows.Forms.Padding(0, 0, 0, 25)
        Me.Label74.Size = New System.Drawing.Size(308, 48)
        Me.Label74.TabIndex = 28
        Me.Label74.Text = "Manage and monitor all user accounts."
        '
        'Label75
        '
        Me.Label75.AutoSize = True
        Me.Label75.BackColor = System.Drawing.Color.Transparent
        Me.Label75.Font = New System.Drawing.Font("Segoe UI", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label75.ForeColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(26, Byte), Integer), CType(CType(29, Byte), Integer))
        Me.Label75.Location = New System.Drawing.Point(35, 25)
        Me.Label75.Name = "Label75"
        Me.Label75.Padding = New System.Windows.Forms.Padding(0, 0, 0, 12)
        Me.Label75.Size = New System.Drawing.Size(70, 43)
        Me.Label75.TabIndex = 27
        Me.Label75.Text = "Users"
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.LightCyan
        Me.Panel2.Controls.Add(Me.Label1)
        Me.Panel2.Location = New System.Drawing.Point(1119, 113)
        Me.Panel2.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(260, 46)
        Me.Panel2.TabIndex = 37
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(26, Byte), Integer), CType(CType(29, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(67, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(83, 25)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Basic :   x"
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.LemonChiffon
        Me.Panel3.Controls.Add(Me.Label2)
        Me.Panel3.Location = New System.Drawing.Point(848, 113)
        Me.Panel3.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(260, 46)
        Me.Panel3.TabIndex = 36
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(26, Byte), Integer), CType(CType(29, Byte), Integer))
        Me.Label2.Location = New System.Drawing.Point(67, 9)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(115, 25)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Premium :   x"
        '
        'Label38
        '
        Me.Label38.AutoSize = True
        Me.Label38.BackColor = System.Drawing.Color.Transparent
        Me.Label38.Font = New System.Drawing.Font("Segoe UI", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label38.ForeColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(26, Byte), Integer), CType(CType(29, Byte), Integer))
        Me.Label38.Image = CType(resources.GetObject("Label38.Image"), System.Drawing.Image)
        Me.Label38.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Label38.Location = New System.Drawing.Point(1041, 491)
        Me.Label38.Name = "Label38"
        Me.Label38.Size = New System.Drawing.Size(105, 23)
        Me.Label38.TabIndex = 31
        Me.Label38.Text = "        Status :"
        Me.Label38.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label37
        '
        Me.Label37.AutoSize = True
        Me.Label37.BackColor = System.Drawing.Color.Transparent
        Me.Label37.Font = New System.Drawing.Font("Segoe UI", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label37.ForeColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(26, Byte), Integer), CType(CType(29, Byte), Integer))
        Me.Label37.Image = CType(resources.GetObject("Label37.Image"), System.Drawing.Image)
        Me.Label37.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Label37.Location = New System.Drawing.Point(576, 491)
        Me.Label37.Name = "Label37"
        Me.Label37.Size = New System.Drawing.Size(110, 23)
        Me.Label37.TabIndex = 29
        Me.Label37.Text = "        Search :"
        Me.Label37.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'chartUserActivity
        '
        ChartArea1.Name = "ChartArea1"
        Me.chartUserActivity.ChartAreas.Add(ChartArea1)
        Legend1.Name = "Legend1"
        Me.chartUserActivity.Legends.Add(Legend1)
        Me.chartUserActivity.Location = New System.Drawing.Point(933, 212)
        Me.chartUserActivity.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.chartUserActivity.Name = "chartUserActivity"
        Series1.ChartArea = "ChartArea1"
        Series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie
        Series1.Legend = "Legend1"
        Series1.Name = "ActivityStatus"
        Me.chartUserActivity.Series.Add(Series1)
        Me.chartUserActivity.Size = New System.Drawing.Size(425, 219)
        Me.chartUserActivity.TabIndex = 48
        Me.chartUserActivity.Text = "Chart3"
        Title1.Name = "Title1"
        Title1.Text = "User Activity Overview"
        Me.chartUserActivity.Titles.Add(Title1)
        '
        'chartUserLoginTrend
        '
        ChartArea2.Name = "ChartArea1"
        Me.chartUserLoginTrend.ChartAreas.Add(ChartArea2)
        Legend2.Name = "Legend1"
        Me.chartUserLoginTrend.Legends.Add(Legend2)
        Me.chartUserLoginTrend.Location = New System.Drawing.Point(493, 212)
        Me.chartUserLoginTrend.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.chartUserLoginTrend.Name = "chartUserLoginTrend"
        Series2.ChartArea = "ChartArea1"
        Series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line
        Series2.Legend = "Legend1"
        Series2.Name = "Logins"
        Me.chartUserLoginTrend.Series.Add(Series2)
        Me.chartUserLoginTrend.Size = New System.Drawing.Size(427, 219)
        Me.chartUserLoginTrend.TabIndex = 47
        Me.chartUserLoginTrend.Text = "Chart4"
        Title2.Name = "Title1"
        Title2.Text = "User Login Trend (Past 7 Days)"
        Me.chartUserLoginTrend.Titles.Add(Title2)
        '
        'chartUserType
        '
        ChartArea3.Name = "ChartArea1"
        Me.chartUserType.ChartAreas.Add(ChartArea3)
        Legend3.Name = "Legend1"
        Me.chartUserType.Legends.Add(Legend3)
        Me.chartUserType.Location = New System.Drawing.Point(56, 212)
        Me.chartUserType.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.chartUserType.Name = "chartUserType"
        Me.chartUserType.PaletteCustomColors = New System.Drawing.Color() {System.Drawing.Color.Silver, System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))}
        Series3.ChartArea = "ChartArea1"
        Series3.Legend = "Legend1"
        Series3.Name = "UserTypes"
        Me.chartUserType.Series.Add(Series3)
        Me.chartUserType.Size = New System.Drawing.Size(425, 219)
        Me.chartUserType.TabIndex = 46
        Me.chartUserType.Text = "Chart1"
        Title3.Name = "Title1"
        Title3.Text = "User Type Distribution"
        Me.chartUserType.Titles.Add(Title3)
        '
        'ucUsers
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(245, Byte), Integer), CType(CType(245, Byte), Integer), CType(CType(250, Byte), Integer))
        Me.Controls.Add(Me.chartUserActivity)
        Me.Controls.Add(Me.chartUserLoginTrend)
        Me.Controls.Add(Me.chartUserType)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.btnDeleteSelectedUser)
        Me.Controls.Add(Me.Label55)
        Me.Controls.Add(Me.btnExportToExcelUser)
        Me.Controls.Add(Me.dgvUserList)
        Me.Controls.Add(Me.Panel9)
        Me.Controls.Add(Me.Panel8)
        Me.Controls.Add(Me.Panel7)
        Me.Controls.Add(Me.cboUserStatus)
        Me.Controls.Add(Me.Label38)
        Me.Controls.Add(Me.txtUserSearch)
        Me.Controls.Add(Me.Label37)
        Me.Controls.Add(Me.Label74)
        Me.Controls.Add(Me.Label75)
        Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Name = "ucUsers"
        Me.Padding = New System.Windows.Forms.Padding(32, 25, 32, 25)
        Me.Size = New System.Drawing.Size(1413, 886)
        CType(Me.dgvUserList, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel9.ResumeLayout(False)
        Me.Panel9.PerformLayout()
        Me.Panel8.ResumeLayout(False)
        Me.Panel8.PerformLayout()
        Me.Panel7.ResumeLayout(False)
        Me.Panel7.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        CType(Me.chartUserActivity, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.chartUserLoginTrend, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.chartUserType, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnDeleteSelectedUser As Button
    Friend WithEvents Label55 As Label
    Friend WithEvents btnExportToExcelUser As Button
    Friend WithEvents dgvUserList As DataGridView
    Friend WithEvents Panel9 As Panel
    Friend WithEvents Label56 As Label
    Friend WithEvents Panel8 As Panel
    Friend WithEvents Label54 As Label
    Friend WithEvents Panel7 As Panel
    Friend WithEvents Label53 As Label
    Friend WithEvents cboUserStatus As ComboBox
    Friend WithEvents Label38 As Label
    Friend WithEvents txtUserSearch As TextBox
    Friend WithEvents Label37 As Label
    Friend WithEvents Label74 As Label
    Friend WithEvents Label75 As Label
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Label2 As Label
    Friend WithEvents chartUserActivity As DataVisualization.Charting.Chart
    Friend WithEvents chartUserLoginTrend As DataVisualization.Charting.Chart
    Friend WithEvents chartUserType As DataVisualization.Charting.Chart
End Class
