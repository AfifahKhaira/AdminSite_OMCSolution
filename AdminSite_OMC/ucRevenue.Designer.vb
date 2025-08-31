<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ucRevenue
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
        Dim ChartArea1 As System.Windows.Forms.DataVisualization.Charting.ChartArea = New System.Windows.Forms.DataVisualization.Charting.ChartArea()
        Dim Legend1 As System.Windows.Forms.DataVisualization.Charting.Legend = New System.Windows.Forms.DataVisualization.Charting.Legend()
        Dim Series1 As System.Windows.Forms.DataVisualization.Charting.Series = New System.Windows.Forms.DataVisualization.Charting.Series()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ucRevenue))
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
        Me.chartRevenueTrend = New System.Windows.Forms.DataVisualization.Charting.Chart()
        Me.btnPayoutSelectedRevenue = New System.Windows.Forms.Button()
        Me.Label55 = New System.Windows.Forms.Label()
        Me.btnExportToExcelRevenue = New System.Windows.Forms.Button()
        Me.btnGenerateReportRevenue = New System.Windows.Forms.Button()
        Me.dgvRevenueRecords = New System.Windows.Forms.DataGridView()
        Me.cboRevenueStatus = New System.Windows.Forms.ComboBox()
        Me.txtRevenueSearch = New System.Windows.Forms.TextBox()
        Me.Label38 = New System.Windows.Forms.Label()
        Me.Label37 = New System.Windows.Forms.Label()
        Me.Panel26.SuspendLayout()
        Me.Panel27.SuspendLayout()
        Me.Panel28.SuspendLayout()
        Me.Panel29.SuspendLayout()
        CType(Me.chartRevenueTrend, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvRevenueRecords, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel26
        '
        Me.Panel26.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(249, Byte), Integer), CType(CType(196, Byte), Integer))
        Me.Panel26.Controls.Add(Me.Label95)
        Me.Panel26.Location = New System.Drawing.Point(540, 92)
        Me.Panel26.Margin = New System.Windows.Forms.Padding(2)
        Me.Panel26.Name = "Panel26"
        Me.Panel26.Size = New System.Drawing.Size(238, 55)
        Me.Panel26.TabIndex = 75
        '
        'Label95
        '
        Me.Label95.AutoSize = True
        Me.Label95.BackColor = System.Drawing.Color.Transparent
        Me.Label95.Font = New System.Drawing.Font("Segoe UI", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label95.ForeColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(26, Byte), Integer), CType(CType(29, Byte), Integer))
        Me.Label95.Location = New System.Drawing.Point(61, 7)
        Me.Label95.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label95.Name = "Label95"
        Me.Label95.Size = New System.Drawing.Size(116, 40)
        Me.Label95.TabIndex = 1
        Me.Label95.Text = "Pending Payouts" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "RM 1,200.00"
        Me.Label95.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Panel27
        '
        Me.Panel27.BackColor = System.Drawing.Color.LightPink
        Me.Panel27.Controls.Add(Me.Label96)
        Me.Panel27.Location = New System.Drawing.Point(796, 92)
        Me.Panel27.Margin = New System.Windows.Forms.Padding(2)
        Me.Panel27.Name = "Panel27"
        Me.Panel27.Size = New System.Drawing.Size(238, 55)
        Me.Panel27.TabIndex = 74
        '
        'Label96
        '
        Me.Label96.AutoSize = True
        Me.Label96.BackColor = System.Drawing.Color.Transparent
        Me.Label96.Font = New System.Drawing.Font("Segoe UI", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label96.ForeColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(26, Byte), Integer), CType(CType(29, Byte), Integer))
        Me.Label96.Location = New System.Drawing.Point(51, 7)
        Me.Label96.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label96.Name = "Label96"
        Me.Label96.Size = New System.Drawing.Size(137, 40)
        Me.Label96.TabIndex = 1
        Me.Label96.Text = "Completed Payouts" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "RM 17,800.00"
        Me.Label96.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Panel28
        '
        Me.Panel28.BackColor = System.Drawing.Color.LightGreen
        Me.Panel28.Controls.Add(Me.Label97)
        Me.Panel28.Location = New System.Drawing.Point(282, 92)
        Me.Panel28.Margin = New System.Windows.Forms.Padding(2)
        Me.Panel28.Name = "Panel28"
        Me.Panel28.Size = New System.Drawing.Size(238, 55)
        Me.Panel28.TabIndex = 73
        '
        'Label97
        '
        Me.Label97.AutoSize = True
        Me.Label97.BackColor = System.Drawing.Color.Transparent
        Me.Label97.Font = New System.Drawing.Font("Segoe UI", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label97.ForeColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(26, Byte), Integer), CType(CType(29, Byte), Integer))
        Me.Label97.Location = New System.Drawing.Point(58, 7)
        Me.Label97.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label97.Name = "Label97"
        Me.Label97.Size = New System.Drawing.Size(123, 40)
        Me.Label97.TabIndex = 1
        Me.Label97.Text = "Monthly Revenue" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "RM 4,500.00"
        Me.Label97.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Panel29
        '
        Me.Panel29.BackColor = System.Drawing.Color.LightGray
        Me.Panel29.Controls.Add(Me.Label98)
        Me.Panel29.Location = New System.Drawing.Point(26, 92)
        Me.Panel29.Margin = New System.Windows.Forms.Padding(2)
        Me.Panel29.Name = "Panel29"
        Me.Panel29.Size = New System.Drawing.Size(238, 55)
        Me.Panel29.TabIndex = 72
        '
        'Label98
        '
        Me.Label98.AutoSize = True
        Me.Label98.BackColor = System.Drawing.Color.Transparent
        Me.Label98.Font = New System.Drawing.Font("Segoe UI", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label98.ForeColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(26, Byte), Integer), CType(CType(29, Byte), Integer))
        Me.Label98.Location = New System.Drawing.Point(68, 7)
        Me.Label98.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label98.Name = "Label98"
        Me.Label98.Size = New System.Drawing.Size(102, 40)
        Me.Label98.TabIndex = 1
        Me.Label98.Text = "Total Revenue" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "RM 25,000.00"
        Me.Label98.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
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
        Me.Label47.Size = New System.Drawing.Size(222, 39)
        Me.Label47.TabIndex = 71
        Me.Label47.Text = "Summary of earnings and payouts."
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
        Me.Label48.Size = New System.Drawing.Size(83, 25)
        Me.Label48.TabIndex = 70
        Me.Label48.Text = "Revenue"
        '
        'chartRevenueTrend
        '
        ChartArea1.Name = "ChartArea1"
        Me.chartRevenueTrend.ChartAreas.Add(ChartArea1)
        Legend1.Name = "Legend1"
        Me.chartRevenueTrend.Legends.Add(Legend1)
        Me.chartRevenueTrend.Location = New System.Drawing.Point(42, 178)
        Me.chartRevenueTrend.Margin = New System.Windows.Forms.Padding(2)
        Me.chartRevenueTrend.Name = "chartRevenueTrend"
        Series1.ChartArea = "ChartArea1"
        Series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line
        Series1.Legend = "Legend1"
        Series1.Name = "Series1"
        Me.chartRevenueTrend.Series.Add(Series1)
        Me.chartRevenueTrend.Size = New System.Drawing.Size(648, 178)
        Me.chartRevenueTrend.TabIndex = 77
        Me.chartRevenueTrend.Text = "Revenue Trend (Monthly)"
        '
        'btnPayoutSelectedRevenue
        '
        Me.btnPayoutSelectedRevenue.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPayoutSelectedRevenue.Location = New System.Drawing.Point(511, 667)
        Me.btnPayoutSelectedRevenue.Name = "btnPayoutSelectedRevenue"
        Me.btnPayoutSelectedRevenue.Size = New System.Drawing.Size(170, 30)
        Me.btnPayoutSelectedRevenue.TabIndex = 90
        Me.btnPayoutSelectedRevenue.Text = "Payout Selected"
        Me.btnPayoutSelectedRevenue.UseVisualStyleBackColor = True
        '
        'Label55
        '
        Me.Label55.AutoSize = True
        Me.Label55.BackColor = System.Drawing.Color.Transparent
        Me.Label55.Font = New System.Drawing.Font("Segoe UI", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label55.ForeColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(26, Byte), Integer), CType(CType(29, Byte), Integer))
        Me.Label55.Location = New System.Drawing.Point(26, 398)
        Me.Label55.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label55.Name = "Label55"
        Me.Label55.Size = New System.Drawing.Size(154, 25)
        Me.Label55.TabIndex = 88
        Me.Label55.Text = "Revenue Records"
        '
        'btnExportToExcelRevenue
        '
        Me.btnExportToExcelRevenue.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnExportToExcelRevenue.Location = New System.Drawing.Point(863, 667)
        Me.btnExportToExcelRevenue.Name = "btnExportToExcelRevenue"
        Me.btnExportToExcelRevenue.Size = New System.Drawing.Size(170, 30)
        Me.btnExportToExcelRevenue.TabIndex = 87
        Me.btnExportToExcelRevenue.Text = "Export to Excel"
        Me.btnExportToExcelRevenue.UseVisualStyleBackColor = True
        '
        'btnGenerateReportRevenue
        '
        Me.btnGenerateReportRevenue.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnGenerateReportRevenue.Location = New System.Drawing.Point(687, 667)
        Me.btnGenerateReportRevenue.Name = "btnGenerateReportRevenue"
        Me.btnGenerateReportRevenue.Size = New System.Drawing.Size(170, 30)
        Me.btnGenerateReportRevenue.TabIndex = 86
        Me.btnGenerateReportRevenue.Text = "Generate Report"
        Me.btnGenerateReportRevenue.UseVisualStyleBackColor = True
        '
        'dgvRevenueRecords
        '
        Me.dgvRevenueRecords.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvRevenueRecords.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvRevenueRecords.Location = New System.Drawing.Point(26, 438)
        Me.dgvRevenueRecords.Margin = New System.Windows.Forms.Padding(2)
        Me.dgvRevenueRecords.Name = "dgvRevenueRecords"
        Me.dgvRevenueRecords.RowHeadersWidth = 51
        Me.dgvRevenueRecords.RowTemplate.Height = 24
        Me.dgvRevenueRecords.Size = New System.Drawing.Size(1008, 200)
        Me.dgvRevenueRecords.TabIndex = 85
        '
        'cboRevenueStatus
        '
        Me.cboRevenueStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboRevenueStatus.Font = New System.Drawing.Font("Segoe UI", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboRevenueStatus.FormattingEnabled = True
        Me.cboRevenueStatus.Items.AddRange(New Object() {"All", "Completed", "Pending"})
        Me.cboRevenueStatus.Location = New System.Drawing.Point(871, 396)
        Me.cboRevenueStatus.Margin = New System.Windows.Forms.Padding(2)
        Me.cboRevenueStatus.Name = "cboRevenueStatus"
        Me.cboRevenueStatus.Size = New System.Drawing.Size(163, 27)
        Me.cboRevenueStatus.TabIndex = 84
        '
        'txtRevenueSearch
        '
        Me.txtRevenueSearch.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtRevenueSearch.Font = New System.Drawing.Font("Segoe UI", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtRevenueSearch.Location = New System.Drawing.Point(524, 397)
        Me.txtRevenueSearch.Margin = New System.Windows.Forms.Padding(2)
        Me.txtRevenueSearch.Name = "txtRevenueSearch"
        Me.txtRevenueSearch.Size = New System.Drawing.Size(162, 26)
        Me.txtRevenueSearch.TabIndex = 82
        '
        'Label38
        '
        Me.Label38.AutoSize = True
        Me.Label38.BackColor = System.Drawing.Color.Transparent
        Me.Label38.Font = New System.Drawing.Font("Segoe UI", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label38.ForeColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(26, Byte), Integer), CType(CType(29, Byte), Integer))
        Me.Label38.Image = CType(resources.GetObject("Label38.Image"), System.Drawing.Image)
        Me.Label38.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Label38.Location = New System.Drawing.Point(781, 399)
        Me.Label38.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label38.Name = "Label38"
        Me.Label38.Size = New System.Drawing.Size(86, 19)
        Me.Label38.TabIndex = 83
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
        Me.Label37.Location = New System.Drawing.Point(432, 399)
        Me.Label37.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label37.Name = "Label37"
        Me.Label37.Size = New System.Drawing.Size(88, 19)
        Me.Label37.TabIndex = 81
        Me.Label37.Text = "        Search :"
        Me.Label37.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'ucRevenue
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(245, Byte), Integer), CType(CType(245, Byte), Integer), CType(CType(250, Byte), Integer))
        Me.Controls.Add(Me.btnPayoutSelectedRevenue)
        Me.Controls.Add(Me.Label55)
        Me.Controls.Add(Me.btnExportToExcelRevenue)
        Me.Controls.Add(Me.btnGenerateReportRevenue)
        Me.Controls.Add(Me.dgvRevenueRecords)
        Me.Controls.Add(Me.cboRevenueStatus)
        Me.Controls.Add(Me.Label38)
        Me.Controls.Add(Me.txtRevenueSearch)
        Me.Controls.Add(Me.Label37)
        Me.Controls.Add(Me.chartRevenueTrend)
        Me.Controls.Add(Me.Panel26)
        Me.Controls.Add(Me.Panel27)
        Me.Controls.Add(Me.Panel28)
        Me.Controls.Add(Me.Panel29)
        Me.Controls.Add(Me.Label47)
        Me.Controls.Add(Me.Label48)
        Me.Name = "ucRevenue"
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
        CType(Me.chartRevenueTrend, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvRevenueRecords, System.ComponentModel.ISupportInitialize).EndInit()
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
    Friend WithEvents chartRevenueTrend As DataVisualization.Charting.Chart
    Friend WithEvents btnPayoutSelectedRevenue As Button
    Friend WithEvents Label55 As Label
    Friend WithEvents btnExportToExcelRevenue As Button
    Friend WithEvents btnGenerateReportRevenue As Button
    Friend WithEvents dgvRevenueRecords As DataGridView
    Friend WithEvents cboRevenueStatus As ComboBox
    Friend WithEvents Label38 As Label
    Friend WithEvents txtRevenueSearch As TextBox
    Friend WithEvents Label37 As Label
End Class
