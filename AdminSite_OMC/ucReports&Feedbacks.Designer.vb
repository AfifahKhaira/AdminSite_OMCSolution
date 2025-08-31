<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class ucReportsFeedbacks
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ucReportsFeedbacks))
        Me.Panel22 = New System.Windows.Forms.Panel()
        Me.Label91 = New System.Windows.Forms.Label()
        Me.Panel23 = New System.Windows.Forms.Panel()
        Me.Label92 = New System.Windows.Forms.Label()
        Me.Panel24 = New System.Windows.Forms.Panel()
        Me.Label93 = New System.Windows.Forms.Label()
        Me.Panel25 = New System.Windows.Forms.Panel()
        Me.Label94 = New System.Windows.Forms.Label()
        Me.btnReviewSelectedRF = New System.Windows.Forms.Button()
        Me.btnResolvedSelectedRF = New System.Windows.Forms.Button()
        Me.Label88 = New System.Windows.Forms.Label()
        Me.dgvReportFeedbackList = New System.Windows.Forms.DataGridView()
        Me.cboReportsFeedbacksStatus = New System.Windows.Forms.ComboBox()
        Me.txtReportsFeedbacksSearch = New System.Windows.Forms.TextBox()
        Me.Label45 = New System.Windows.Forms.Label()
        Me.Label46 = New System.Windows.Forms.Label()
        Me.btnExportToExcelRF = New System.Windows.Forms.Button()
        Me.Label89 = New System.Windows.Forms.Label()
        Me.Label90 = New System.Windows.Forms.Label()
        Me.Panel22.SuspendLayout()
        Me.Panel23.SuspendLayout()
        Me.Panel24.SuspendLayout()
        Me.Panel25.SuspendLayout()
        CType(Me.dgvReportFeedbackList, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel22
        '
        Me.Panel22.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(249, Byte), Integer), CType(CType(196, Byte), Integer))
        Me.Panel22.Controls.Add(Me.Label91)
        Me.Panel22.Location = New System.Drawing.Point(540, 92)
        Me.Panel22.Margin = New System.Windows.Forms.Padding(2)
        Me.Panel22.Name = "Panel22"
        Me.Panel22.Size = New System.Drawing.Size(238, 37)
        Me.Panel22.TabIndex = 75
        '
        'Label91
        '
        Me.Label91.AutoSize = True
        Me.Label91.BackColor = System.Drawing.Color.Transparent
        Me.Label91.Font = New System.Drawing.Font("Segoe UI", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label91.ForeColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(26, Byte), Integer), CType(CType(29, Byte), Integer))
        Me.Label91.Location = New System.Drawing.Point(65, 7)
        Me.Label91.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label91.Name = "Label91"
        Me.Label91.Size = New System.Drawing.Size(108, 20)
        Me.Label91.TabIndex = 1
        Me.Label91.Text = "In Progress :   8"
        '
        'Panel23
        '
        Me.Panel23.BackColor = System.Drawing.Color.LightPink
        Me.Panel23.Controls.Add(Me.Label92)
        Me.Panel23.Location = New System.Drawing.Point(796, 92)
        Me.Panel23.Margin = New System.Windows.Forms.Padding(2)
        Me.Panel23.Name = "Panel23"
        Me.Panel23.Size = New System.Drawing.Size(238, 37)
        Me.Panel23.TabIndex = 74
        '
        'Label92
        '
        Me.Label92.AutoSize = True
        Me.Label92.BackColor = System.Drawing.Color.Transparent
        Me.Label92.Font = New System.Drawing.Font("Segoe UI", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label92.ForeColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(26, Byte), Integer), CType(CType(29, Byte), Integer))
        Me.Label92.Location = New System.Drawing.Point(67, 7)
        Me.Label92.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label92.Name = "Label92"
        Me.Label92.Size = New System.Drawing.Size(104, 20)
        Me.Label92.TabIndex = 1
        Me.Label92.Text = "Resolved :   30"
        '
        'Panel24
        '
        Me.Panel24.BackColor = System.Drawing.Color.LightGreen
        Me.Panel24.Controls.Add(Me.Label93)
        Me.Panel24.Location = New System.Drawing.Point(282, 92)
        Me.Panel24.Margin = New System.Windows.Forms.Padding(2)
        Me.Panel24.Name = "Panel24"
        Me.Panel24.Size = New System.Drawing.Size(238, 37)
        Me.Panel24.TabIndex = 73
        '
        'Label93
        '
        Me.Label93.AutoSize = True
        Me.Label93.BackColor = System.Drawing.Color.Transparent
        Me.Label93.Font = New System.Drawing.Font("Segoe UI", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label93.ForeColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(26, Byte), Integer), CType(CType(29, Byte), Integer))
        Me.Label93.Location = New System.Drawing.Point(73, 7)
        Me.Label93.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label93.Name = "Label93"
        Me.Label93.Size = New System.Drawing.Size(92, 20)
        Me.Label93.TabIndex = 1
        Me.Label93.Text = "Unread :   12"
        '
        'Panel25
        '
        Me.Panel25.BackColor = System.Drawing.Color.LightGray
        Me.Panel25.Controls.Add(Me.Label94)
        Me.Panel25.Location = New System.Drawing.Point(26, 92)
        Me.Panel25.Margin = New System.Windows.Forms.Padding(2)
        Me.Panel25.Name = "Panel25"
        Me.Panel25.Size = New System.Drawing.Size(238, 37)
        Me.Panel25.TabIndex = 72
        '
        'Label94
        '
        Me.Label94.AutoSize = True
        Me.Label94.BackColor = System.Drawing.Color.Transparent
        Me.Label94.Font = New System.Drawing.Font("Segoe UI", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label94.ForeColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(26, Byte), Integer), CType(CType(29, Byte), Integer))
        Me.Label94.Location = New System.Drawing.Point(81, 7)
        Me.Label94.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label94.Name = "Label94"
        Me.Label94.Size = New System.Drawing.Size(77, 20)
        Me.Label94.TabIndex = 1
        Me.Label94.Text = "Total :   50"
        '
        'btnReviewSelectedRF
        '
        Me.btnReviewSelectedRF.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnReviewSelectedRF.Location = New System.Drawing.Point(511, 458)
        Me.btnReviewSelectedRF.Name = "btnReviewSelectedRF"
        Me.btnReviewSelectedRF.Size = New System.Drawing.Size(170, 30)
        Me.btnReviewSelectedRF.TabIndex = 71
        Me.btnReviewSelectedRF.Text = "Review Selected"
        Me.btnReviewSelectedRF.UseVisualStyleBackColor = True
        '
        'btnResolvedSelectedRF
        '
        Me.btnResolvedSelectedRF.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnResolvedSelectedRF.Location = New System.Drawing.Point(687, 458)
        Me.btnResolvedSelectedRF.Name = "btnResolvedSelectedRF"
        Me.btnResolvedSelectedRF.Size = New System.Drawing.Size(170, 30)
        Me.btnResolvedSelectedRF.TabIndex = 69
        Me.btnResolvedSelectedRF.Text = "Resolved Selected"
        Me.btnResolvedSelectedRF.UseVisualStyleBackColor = True
        '
        'Label88
        '
        Me.Label88.AutoSize = True
        Me.Label88.BackColor = System.Drawing.Color.Transparent
        Me.Label88.Font = New System.Drawing.Font("Segoe UI", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label88.ForeColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(26, Byte), Integer), CType(CType(29, Byte), Integer))
        Me.Label88.Location = New System.Drawing.Point(26, 189)
        Me.Label88.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label88.Name = "Label88"
        Me.Label88.Size = New System.Drawing.Size(204, 25)
        Me.Label88.TabIndex = 68
        Me.Label88.Text = "Report && Feedback List"
        '
        'dgvReportFeedbackList
        '
        Me.dgvReportFeedbackList.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvReportFeedbackList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvReportFeedbackList.Location = New System.Drawing.Point(26, 229)
        Me.dgvReportFeedbackList.Margin = New System.Windows.Forms.Padding(2)
        Me.dgvReportFeedbackList.Name = "dgvReportFeedbackList"
        Me.dgvReportFeedbackList.RowHeadersWidth = 51
        Me.dgvReportFeedbackList.RowTemplate.Height = 24
        Me.dgvReportFeedbackList.Size = New System.Drawing.Size(1008, 200)
        Me.dgvReportFeedbackList.TabIndex = 66
        '
        'cboReportsFeedbacksStatus
        '
        Me.cboReportsFeedbacksStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboReportsFeedbacksStatus.Font = New System.Drawing.Font("Segoe UI", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboReportsFeedbacksStatus.FormattingEnabled = True
        Me.cboReportsFeedbacksStatus.Items.AddRange(New Object() {"In Progress", "Unread", "Resolved"})
        Me.cboReportsFeedbacksStatus.Location = New System.Drawing.Point(871, 187)
        Me.cboReportsFeedbacksStatus.Margin = New System.Windows.Forms.Padding(2)
        Me.cboReportsFeedbacksStatus.Name = "cboReportsFeedbacksStatus"
        Me.cboReportsFeedbacksStatus.Size = New System.Drawing.Size(163, 27)
        Me.cboReportsFeedbacksStatus.TabIndex = 65
        '
        'txtReportsFeedbacksSearch
        '
        Me.txtReportsFeedbacksSearch.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtReportsFeedbacksSearch.Font = New System.Drawing.Font("Segoe UI", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtReportsFeedbacksSearch.Location = New System.Drawing.Point(524, 188)
        Me.txtReportsFeedbacksSearch.Margin = New System.Windows.Forms.Padding(2)
        Me.txtReportsFeedbacksSearch.Name = "txtReportsFeedbacksSearch"
        Me.txtReportsFeedbacksSearch.Size = New System.Drawing.Size(162, 26)
        Me.txtReportsFeedbacksSearch.TabIndex = 63
        '
        'Label45
        '
        Me.Label45.AutoSize = True
        Me.Label45.BackColor = System.Drawing.Color.Transparent
        Me.Label45.Font = New System.Drawing.Font("Segoe UI", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label45.ForeColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(26, Byte), Integer), CType(CType(29, Byte), Integer))
        Me.Label45.Location = New System.Drawing.Point(26, 51)
        Me.Label45.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label45.Name = "Label45"
        Me.Label45.Padding = New System.Windows.Forms.Padding(0, 0, 0, 20)
        Me.Label45.Size = New System.Drawing.Size(287, 39)
        Me.Label45.TabIndex = 61
        Me.Label45.Text = "Review content reports and user suggestions."
        '
        'Label46
        '
        Me.Label46.AutoSize = True
        Me.Label46.BackColor = System.Drawing.Color.Transparent
        Me.Label46.Font = New System.Drawing.Font("Segoe UI", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label46.ForeColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(26, Byte), Integer), CType(CType(29, Byte), Integer))
        Me.Label46.Location = New System.Drawing.Point(26, 20)
        Me.Label46.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label46.Name = "Label46"
        Me.Label46.Size = New System.Drawing.Size(187, 25)
        Me.Label46.TabIndex = 60
        Me.Label46.Text = "Reports && Feedbacks"
        '
        'btnExportToExcelRF
        '
        Me.btnExportToExcelRF.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnExportToExcelRF.Location = New System.Drawing.Point(863, 458)
        Me.btnExportToExcelRF.Name = "btnExportToExcelRF"
        Me.btnExportToExcelRF.Size = New System.Drawing.Size(170, 30)
        Me.btnExportToExcelRF.TabIndex = 76
        Me.btnExportToExcelRF.Text = "Export To Excel"
        Me.btnExportToExcelRF.UseVisualStyleBackColor = True
        '
        'Label89
        '
        Me.Label89.AutoSize = True
        Me.Label89.BackColor = System.Drawing.Color.Transparent
        Me.Label89.Font = New System.Drawing.Font("Segoe UI", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label89.ForeColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(26, Byte), Integer), CType(CType(29, Byte), Integer))
        Me.Label89.Image = CType(resources.GetObject("Label89.Image"), System.Drawing.Image)
        Me.Label89.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Label89.Location = New System.Drawing.Point(784, 190)
        Me.Label89.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label89.Name = "Label89"
        Me.Label89.Size = New System.Drawing.Size(86, 19)
        Me.Label89.TabIndex = 64
        Me.Label89.Text = "        Status :"
        Me.Label89.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label90
        '
        Me.Label90.AutoSize = True
        Me.Label90.BackColor = System.Drawing.Color.Transparent
        Me.Label90.Font = New System.Drawing.Font("Segoe UI", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label90.ForeColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(26, Byte), Integer), CType(CType(29, Byte), Integer))
        Me.Label90.Image = CType(resources.GetObject("Label90.Image"), System.Drawing.Image)
        Me.Label90.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Label90.Location = New System.Drawing.Point(433, 191)
        Me.Label90.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label90.Name = "Label90"
        Me.Label90.Size = New System.Drawing.Size(88, 19)
        Me.Label90.TabIndex = 62
        Me.Label90.Text = "        Search :"
        Me.Label90.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'ucReportsFeedbacks
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(245, Byte), Integer), CType(CType(245, Byte), Integer), CType(CType(250, Byte), Integer))
        Me.Controls.Add(Me.btnExportToExcelRF)
        Me.Controls.Add(Me.Panel22)
        Me.Controls.Add(Me.Panel23)
        Me.Controls.Add(Me.Panel24)
        Me.Controls.Add(Me.Panel25)
        Me.Controls.Add(Me.btnReviewSelectedRF)
        Me.Controls.Add(Me.btnResolvedSelectedRF)
        Me.Controls.Add(Me.Label88)
        Me.Controls.Add(Me.dgvReportFeedbackList)
        Me.Controls.Add(Me.cboReportsFeedbacksStatus)
        Me.Controls.Add(Me.Label89)
        Me.Controls.Add(Me.txtReportsFeedbacksSearch)
        Me.Controls.Add(Me.Label90)
        Me.Controls.Add(Me.Label45)
        Me.Controls.Add(Me.Label46)
        Me.Name = "ucReportsFeedbacks"
        Me.Padding = New System.Windows.Forms.Padding(24, 20, 24, 20)
        Me.Size = New System.Drawing.Size(1060, 720)
        Me.Panel22.ResumeLayout(False)
        Me.Panel22.PerformLayout()
        Me.Panel23.ResumeLayout(False)
        Me.Panel23.PerformLayout()
        Me.Panel24.ResumeLayout(False)
        Me.Panel24.PerformLayout()
        Me.Panel25.ResumeLayout(False)
        Me.Panel25.PerformLayout()
        CType(Me.dgvReportFeedbackList, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Panel22 As Panel
    Friend WithEvents Label91 As Label
    Friend WithEvents Panel23 As Panel
    Friend WithEvents Label92 As Label
    Friend WithEvents Panel24 As Panel
    Friend WithEvents Label93 As Label
    Friend WithEvents Panel25 As Panel
    Friend WithEvents Label94 As Label
    Friend WithEvents btnReviewSelectedRF As Button
    Friend WithEvents btnResolvedSelectedRF As Button
    Friend WithEvents Label88 As Label
    Friend WithEvents dgvReportFeedbackList As DataGridView
    Friend WithEvents cboReportsFeedbacksStatus As ComboBox
    Friend WithEvents Label89 As Label
    Friend WithEvents txtReportsFeedbacksSearch As TextBox
    Friend WithEvents Label90 As Label
    Friend WithEvents Label45 As Label
    Friend WithEvents Label46 As Label
    Friend WithEvents btnExportToExcelRF As Button

End Class
