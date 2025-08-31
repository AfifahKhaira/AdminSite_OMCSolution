<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ucSellers
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
        Dim Title1 As System.Windows.Forms.DataVisualization.Charting.Title = New System.Windows.Forms.DataVisualization.Charting.Title()
        Dim ChartArea2 As System.Windows.Forms.DataVisualization.Charting.ChartArea = New System.Windows.Forms.DataVisualization.Charting.ChartArea()
        Dim Legend2 As System.Windows.Forms.DataVisualization.Charting.Legend = New System.Windows.Forms.DataVisualization.Charting.Legend()
        Dim Series2 As System.Windows.Forms.DataVisualization.Charting.Series = New System.Windows.Forms.DataVisualization.Charting.Series()
        Dim Title2 As System.Windows.Forms.DataVisualization.Charting.Title = New System.Windows.Forms.DataVisualization.Charting.Title()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ucSellers))
        Me.Panel17 = New System.Windows.Forms.Panel()
        Me.Label71 = New System.Windows.Forms.Label()
        Me.Panel10 = New System.Windows.Forms.Panel()
        Me.Label67 = New System.Windows.Forms.Label()
        Me.Panel14 = New System.Windows.Forms.Panel()
        Me.Label68 = New System.Windows.Forms.Label()
        Me.btnRejectSelectedSeller = New System.Windows.Forms.Button()
        Me.Panel15 = New System.Windows.Forms.Panel()
        Me.Label69 = New System.Windows.Forms.Label()
        Me.btnApproveSelectedSeller = New System.Windows.Forms.Button()
        Me.chartSellerStatusPie = New System.Windows.Forms.DataVisualization.Charting.Chart()
        Me.Label57 = New System.Windows.Forms.Label()
        Me.btnExportToExcelSeller = New System.Windows.Forms.Button()
        Me.btnSuspendSelectedSeller = New System.Windows.Forms.Button()
        Me.chartSellerBarStatus = New System.Windows.Forms.DataVisualization.Charting.Chart()
        Me.dgvSellerList = New System.Windows.Forms.DataGridView()
        Me.txtSellerSearch = New System.Windows.Forms.TextBox()
        Me.Label63 = New System.Windows.Forms.Label()
        Me.Label64 = New System.Windows.Forms.Label()
        Me.Label61 = New System.Windows.Forms.Label()
        Me.Label62 = New System.Windows.Forms.Label()
        Me.cboSellerStatus = New System.Windows.Forms.ComboBox()
        Me.Panel17.SuspendLayout()
        Me.Panel10.SuspendLayout()
        Me.Panel14.SuspendLayout()
        Me.Panel15.SuspendLayout()
        CType(Me.chartSellerStatusPie, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.chartSellerBarStatus, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvSellerList, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel17
        '
        Me.Panel17.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(249, Byte), Integer), CType(CType(196, Byte), Integer))
        Me.Panel17.Controls.Add(Me.Label71)
        Me.Panel17.Location = New System.Drawing.Point(539, 92)
        Me.Panel17.Margin = New System.Windows.Forms.Padding(2)
        Me.Panel17.Name = "Panel17"
        Me.Panel17.Size = New System.Drawing.Size(238, 37)
        Me.Panel17.TabIndex = 39
        '
        'Label71
        '
        Me.Label71.AutoSize = True
        Me.Label71.BackColor = System.Drawing.Color.Transparent
        Me.Label71.Font = New System.Drawing.Font("Segoe UI", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label71.ForeColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(26, Byte), Integer), CType(CType(29, Byte), Integer))
        Me.Label71.Location = New System.Drawing.Point(71, 7)
        Me.Label71.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label71.Name = "Label71"
        Me.Label71.Size = New System.Drawing.Size(97, 20)
        Me.Label71.TabIndex = 1
        Me.Label71.Text = "Pending :   10"
        '
        'Panel10
        '
        Me.Panel10.BackColor = System.Drawing.Color.LightPink
        Me.Panel10.Controls.Add(Me.Label67)
        Me.Panel10.Location = New System.Drawing.Point(796, 92)
        Me.Panel10.Margin = New System.Windows.Forms.Padding(2)
        Me.Panel10.Name = "Panel10"
        Me.Panel10.Size = New System.Drawing.Size(238, 37)
        Me.Panel10.TabIndex = 36
        '
        'Label67
        '
        Me.Label67.AutoSize = True
        Me.Label67.BackColor = System.Drawing.Color.Transparent
        Me.Label67.Font = New System.Drawing.Font("Segoe UI", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label67.ForeColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(26, Byte), Integer), CType(CType(29, Byte), Integer))
        Me.Label67.Location = New System.Drawing.Point(65, 7)
        Me.Label67.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label67.Name = "Label67"
        Me.Label67.Size = New System.Drawing.Size(109, 20)
        Me.Label67.TabIndex = 1
        Me.Label67.Text = "Suspended :   5"
        '
        'Panel14
        '
        Me.Panel14.BackColor = System.Drawing.Color.LightGreen
        Me.Panel14.Controls.Add(Me.Label68)
        Me.Panel14.Location = New System.Drawing.Point(283, 92)
        Me.Panel14.Margin = New System.Windows.Forms.Padding(2)
        Me.Panel14.Name = "Panel14"
        Me.Panel14.Size = New System.Drawing.Size(238, 37)
        Me.Panel14.TabIndex = 34
        '
        'Label68
        '
        Me.Label68.AutoSize = True
        Me.Label68.BackColor = System.Drawing.Color.Transparent
        Me.Label68.Font = New System.Drawing.Font("Segoe UI", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label68.ForeColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(26, Byte), Integer), CType(CType(29, Byte), Integer))
        Me.Label68.Location = New System.Drawing.Point(72, 7)
        Me.Label68.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label68.Name = "Label68"
        Me.Label68.Size = New System.Drawing.Size(95, 20)
        Me.Label68.TabIndex = 1
        Me.Label68.Text = "Verified :   25"
        '
        'btnRejectSelectedSeller
        '
        Me.btnRejectSelectedSeller.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnRejectSelectedSeller.Location = New System.Drawing.Point(511, 667)
        Me.btnRejectSelectedSeller.Name = "btnRejectSelectedSeller"
        Me.btnRejectSelectedSeller.Size = New System.Drawing.Size(170, 30)
        Me.btnRejectSelectedSeller.TabIndex = 44
        Me.btnRejectSelectedSeller.Text = "Reject Selected"
        Me.btnRejectSelectedSeller.UseVisualStyleBackColor = True
        '
        'Panel15
        '
        Me.Panel15.BackColor = System.Drawing.Color.LightGray
        Me.Panel15.Controls.Add(Me.Label69)
        Me.Panel15.Location = New System.Drawing.Point(26, 92)
        Me.Panel15.Margin = New System.Windows.Forms.Padding(2)
        Me.Panel15.Name = "Panel15"
        Me.Panel15.Size = New System.Drawing.Size(238, 37)
        Me.Panel15.TabIndex = 32
        '
        'Label69
        '
        Me.Label69.AutoSize = True
        Me.Label69.BackColor = System.Drawing.Color.Transparent
        Me.Label69.Font = New System.Drawing.Font("Segoe UI", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label69.ForeColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(26, Byte), Integer), CType(CType(29, Byte), Integer))
        Me.Label69.Location = New System.Drawing.Point(57, 7)
        Me.Label69.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label69.Name = "Label69"
        Me.Label69.Size = New System.Drawing.Size(124, 20)
        Me.Label69.TabIndex = 1
        Me.Label69.Text = "Total Sellers :   40"
        '
        'btnApproveSelectedSeller
        '
        Me.btnApproveSelectedSeller.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnApproveSelectedSeller.Location = New System.Drawing.Point(335, 667)
        Me.btnApproveSelectedSeller.Name = "btnApproveSelectedSeller"
        Me.btnApproveSelectedSeller.Size = New System.Drawing.Size(170, 30)
        Me.btnApproveSelectedSeller.TabIndex = 43
        Me.btnApproveSelectedSeller.Text = "Approve Selected"
        Me.btnApproveSelectedSeller.UseVisualStyleBackColor = True
        '
        'chartSellerStatusPie
        '
        ChartArea1.Name = "ChartArea1"
        Me.chartSellerStatusPie.ChartAreas.Add(ChartArea1)
        Legend1.Name = "Legend1"
        Me.chartSellerStatusPie.Legends.Add(Legend1)
        Me.chartSellerStatusPie.Location = New System.Drawing.Point(539, 172)
        Me.chartSellerStatusPie.Margin = New System.Windows.Forms.Padding(2)
        Me.chartSellerStatusPie.Name = "chartSellerStatusPie"
        Series1.ChartArea = "ChartArea1"
        Series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie
        Series1.Legend = "Legend1"
        Series1.Name = "SellerStatusPieSeries"
        Me.chartSellerStatusPie.Series.Add(Series1)
        Me.chartSellerStatusPie.Size = New System.Drawing.Size(480, 178)
        Me.chartSellerStatusPie.TabIndex = 42
        Me.chartSellerStatusPie.Text = "Chart3"
        Title1.Name = "Title1"
        Title1.Text = "Seller Status Proportion"
        Me.chartSellerStatusPie.Titles.Add(Title1)
        '
        'Label57
        '
        Me.Label57.AutoSize = True
        Me.Label57.BackColor = System.Drawing.Color.Transparent
        Me.Label57.Font = New System.Drawing.Font("Segoe UI", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label57.ForeColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(26, Byte), Integer), CType(CType(29, Byte), Integer))
        Me.Label57.Location = New System.Drawing.Point(26, 398)
        Me.Label57.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label57.Name = "Label57"
        Me.Label57.Size = New System.Drawing.Size(92, 25)
        Me.Label57.TabIndex = 40
        Me.Label57.Text = "Seller List"
        '
        'btnExportToExcelSeller
        '
        Me.btnExportToExcelSeller.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnExportToExcelSeller.Location = New System.Drawing.Point(863, 667)
        Me.btnExportToExcelSeller.Name = "btnExportToExcelSeller"
        Me.btnExportToExcelSeller.Size = New System.Drawing.Size(170, 30)
        Me.btnExportToExcelSeller.TabIndex = 38
        Me.btnExportToExcelSeller.Text = "Export to Excel"
        Me.btnExportToExcelSeller.UseVisualStyleBackColor = True
        '
        'btnSuspendSelectedSeller
        '
        Me.btnSuspendSelectedSeller.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSuspendSelectedSeller.Location = New System.Drawing.Point(687, 667)
        Me.btnSuspendSelectedSeller.Name = "btnSuspendSelectedSeller"
        Me.btnSuspendSelectedSeller.Size = New System.Drawing.Size(170, 30)
        Me.btnSuspendSelectedSeller.TabIndex = 37
        Me.btnSuspendSelectedSeller.Text = "Suspend Selected"
        Me.btnSuspendSelectedSeller.UseVisualStyleBackColor = True
        '
        'chartSellerBarStatus
        '
        ChartArea2.Name = "ChartArea1"
        Me.chartSellerBarStatus.ChartAreas.Add(ChartArea2)
        Legend2.Name = "Legend1"
        Me.chartSellerBarStatus.Legends.Add(Legend2)
        Me.chartSellerBarStatus.Location = New System.Drawing.Point(42, 172)
        Me.chartSellerBarStatus.Margin = New System.Windows.Forms.Padding(2)
        Me.chartSellerBarStatus.Name = "chartSellerBarStatus"
        Series2.ChartArea = "ChartArea1"
        Series2.Legend = "Legend1"
        Series2.Name = "SellerStatusSeries"
        Me.chartSellerBarStatus.Series.Add(Series2)
        Me.chartSellerBarStatus.Size = New System.Drawing.Size(480, 178)
        Me.chartSellerBarStatus.TabIndex = 35
        Me.chartSellerBarStatus.Text = "Chart1"
        Title2.Name = "Title1"
        Title2.Text = "Seller Status Distribution"
        Me.chartSellerBarStatus.Titles.Add(Title2)
        '
        'dgvSellerList
        '
        Me.dgvSellerList.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvSellerList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvSellerList.Location = New System.Drawing.Point(26, 438)
        Me.dgvSellerList.Margin = New System.Windows.Forms.Padding(2)
        Me.dgvSellerList.Name = "dgvSellerList"
        Me.dgvSellerList.RowHeadersWidth = 51
        Me.dgvSellerList.RowTemplate.Height = 24
        Me.dgvSellerList.Size = New System.Drawing.Size(1008, 200)
        Me.dgvSellerList.TabIndex = 33
        '
        'txtSellerSearch
        '
        Me.txtSellerSearch.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtSellerSearch.Font = New System.Drawing.Font("Segoe UI", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSellerSearch.Location = New System.Drawing.Point(524, 397)
        Me.txtSellerSearch.Margin = New System.Windows.Forms.Padding(2)
        Me.txtSellerSearch.Name = "txtSellerSearch"
        Me.txtSellerSearch.Size = New System.Drawing.Size(162, 26)
        Me.txtSellerSearch.TabIndex = 29
        '
        'Label63
        '
        Me.Label63.AutoSize = True
        Me.Label63.BackColor = System.Drawing.Color.Transparent
        Me.Label63.Font = New System.Drawing.Font("Segoe UI", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label63.ForeColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(26, Byte), Integer), CType(CType(29, Byte), Integer))
        Me.Label63.Location = New System.Drawing.Point(26, 51)
        Me.Label63.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label63.Name = "Label63"
        Me.Label63.Padding = New System.Windows.Forms.Padding(0, 0, 0, 20)
        Me.Label63.Size = New System.Drawing.Size(219, 39)
        Me.Label63.TabIndex = 27
        Me.Label63.Text = "Manage sellers and their contents."
        '
        'Label64
        '
        Me.Label64.AutoSize = True
        Me.Label64.BackColor = System.Drawing.Color.Transparent
        Me.Label64.Font = New System.Drawing.Font("Segoe UI", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label64.ForeColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(26, Byte), Integer), CType(CType(29, Byte), Integer))
        Me.Label64.Location = New System.Drawing.Point(26, 20)
        Me.Label64.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label64.Name = "Label64"
        Me.Label64.Size = New System.Drawing.Size(67, 25)
        Me.Label64.TabIndex = 26
        Me.Label64.Text = "Sellers"
        '
        'Label61
        '
        Me.Label61.AutoSize = True
        Me.Label61.BackColor = System.Drawing.Color.Transparent
        Me.Label61.Font = New System.Drawing.Font("Segoe UI", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label61.ForeColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(26, Byte), Integer), CType(CType(29, Byte), Integer))
        Me.Label61.Image = CType(resources.GetObject("Label61.Image"), System.Drawing.Image)
        Me.Label61.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Label61.Location = New System.Drawing.Point(781, 399)
        Me.Label61.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label61.Name = "Label61"
        Me.Label61.Size = New System.Drawing.Size(86, 19)
        Me.Label61.TabIndex = 30
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
        Me.Label62.Location = New System.Drawing.Point(432, 399)
        Me.Label62.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label62.Name = "Label62"
        Me.Label62.Size = New System.Drawing.Size(88, 19)
        Me.Label62.TabIndex = 28
        Me.Label62.Text = "        Search :"
        Me.Label62.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'cboSellerStatus
        '
        Me.cboSellerStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboSellerStatus.Font = New System.Drawing.Font("Segoe UI", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboSellerStatus.FormattingEnabled = True
        Me.cboSellerStatus.Items.AddRange(New Object() {"All", "Verified", "Pending", "Suspended"})
        Me.cboSellerStatus.Location = New System.Drawing.Point(871, 396)
        Me.cboSellerStatus.Margin = New System.Windows.Forms.Padding(2)
        Me.cboSellerStatus.Name = "cboSellerStatus"
        Me.cboSellerStatus.Size = New System.Drawing.Size(163, 27)
        Me.cboSellerStatus.TabIndex = 45
        '
        'ucSellers
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(245, Byte), Integer), CType(CType(245, Byte), Integer), CType(CType(250, Byte), Integer))
        Me.Controls.Add(Me.cboSellerStatus)
        Me.Controls.Add(Me.Panel17)
        Me.Controls.Add(Me.Panel10)
        Me.Controls.Add(Me.Panel14)
        Me.Controls.Add(Me.btnRejectSelectedSeller)
        Me.Controls.Add(Me.Panel15)
        Me.Controls.Add(Me.btnApproveSelectedSeller)
        Me.Controls.Add(Me.chartSellerStatusPie)
        Me.Controls.Add(Me.Label57)
        Me.Controls.Add(Me.btnExportToExcelSeller)
        Me.Controls.Add(Me.btnSuspendSelectedSeller)
        Me.Controls.Add(Me.chartSellerBarStatus)
        Me.Controls.Add(Me.dgvSellerList)
        Me.Controls.Add(Me.Label61)
        Me.Controls.Add(Me.txtSellerSearch)
        Me.Controls.Add(Me.Label62)
        Me.Controls.Add(Me.Label63)
        Me.Controls.Add(Me.Label64)
        Me.Name = "ucSellers"
        Me.Padding = New System.Windows.Forms.Padding(24, 20, 24, 20)
        Me.Size = New System.Drawing.Size(1060, 720)
        Me.Panel17.ResumeLayout(False)
        Me.Panel17.PerformLayout()
        Me.Panel10.ResumeLayout(False)
        Me.Panel10.PerformLayout()
        Me.Panel14.ResumeLayout(False)
        Me.Panel14.PerformLayout()
        Me.Panel15.ResumeLayout(False)
        Me.Panel15.PerformLayout()
        CType(Me.chartSellerStatusPie, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.chartSellerBarStatus, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvSellerList, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Panel17 As Panel
    Friend WithEvents Label71 As Label
    Friend WithEvents Panel10 As Panel
    Friend WithEvents Label67 As Label
    Friend WithEvents Panel14 As Panel
    Friend WithEvents Label68 As Label
    Friend WithEvents btnRejectSelectedSeller As Button
    Friend WithEvents Panel15 As Panel
    Friend WithEvents Label69 As Label
    Friend WithEvents btnApproveSelectedSeller As Button
    Friend WithEvents chartSellerStatusPie As DataVisualization.Charting.Chart
    Friend WithEvents Label57 As Label
    Friend WithEvents btnExportToExcelSeller As Button
    Friend WithEvents btnSuspendSelectedSeller As Button
    Friend WithEvents chartSellerBarStatus As DataVisualization.Charting.Chart
    Friend WithEvents dgvSellerList As DataGridView
    Friend WithEvents Label61 As Label
    Friend WithEvents txtSellerSearch As TextBox
    Friend WithEvents Label62 As Label
    Friend WithEvents Label63 As Label
    Friend WithEvents Label64 As Label



    Private Sub chartSellerStats_Click(sender As Object, e As EventArgs) Handles chartSellerBarStatus.Click

    End Sub

    Friend WithEvents cboSellerStatus As ComboBox
End Class
