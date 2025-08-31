Imports System.Data.OleDb
Imports System.Drawing.Drawing2D
Imports System.Windows.Forms.DataVisualization.Charting

Public Class Form4

    Private Sub Form4_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ResetSidebarUI()
        btnDashboards.PerformClick()
    End Sub

    Private Sub LoadUserControl(control As UserControl)
        pnlMainContainer.Controls.Clear()
        control.Dock = DockStyle.Fill
        pnlMainContainer.Controls.Add(control)
    End Sub

    Private Sub pcbLogo_MouseMove(sender As Object, e As MouseEventArgs) Handles pcbLogo.MouseMove
        Dim pb As PictureBox = CType(sender, PictureBox)
        If pb.Image Is Nothing Then Exit Sub

        Dim bmp As Bitmap = CType(pb.Image, Bitmap)
        Dim x = e.X
        Dim y = e.Y

        If x >= 0 AndAlso x < bmp.Width AndAlso y >= 0 AndAlso y < bmp.Height Then
            Dim pixel As Color = bmp.GetPixel(x, y)
            If pixel.A = 0 Then
                pb.Cursor = Cursors.Default
            Else
                pb.Cursor = Cursors.Hand
            End If
        Else
            pb.Cursor = Cursors.Default
        End If
    End Sub

    Private Sub NavigationButton_Click(sender As Object, e As EventArgs) _
        Handles btnDashboards.Click, btnUsers.Click, btnSellers.Click, btnEvents.Click, btnRevenue.Click, btnReportsFeedbacks.Click, btnNotifications.Click,
                btnHelpsSupports.Click, btnAdmin.Click

        ResetSidebarUI()

        Dim clickedButton As Button = CType(sender, Button)
        Dim selectedUC As UserControl = Nothing
        clickedButton.ForeColor = Color.FromArgb(26, 26, 29)

        Select Case clickedButton.Name
            Case "btnDashboards"
                selectedUC = New ucDashboard()
                clickedButton.Image = My.Resources.dashboard_active_icon
                clickedButton.BackColor = Color.FromArgb(162, 167, 249)
                pnlOnDashboardsBtn.Visible = False

            Case "btnUsers"
                selectedUC = New ucUsers()
                clickedButton.Image = My.Resources.users_active_icon
                clickedButton.BackColor = Color.FromArgb(162, 167, 249)
                pnlOnUsersBtn.Visible = False

            Case "btnSellers"
                selectedUC = New ucSellers()
                clickedButton.Image = My.Resources.seller_active_icon
                clickedButton.BackColor = Color.FromArgb(162, 167, 249)
                pnlOnSellersBtn.Visible = False

            Case "btnEvents"
                selectedUC = New ucEvents()
                clickedButton.Image = My.Resources.event_active_icon
                clickedButton.BackColor = Color.FromArgb(162, 167, 249)
                pnlOnEventsBtn.Visible = False

            Case "btnReportsFeedbacks"
                selectedUC = New ucReportsFeedbacks()
                clickedButton.Image = My.Resources.reportfeedback_active_icon
                clickedButton.BackColor = Color.FromArgb(162, 167, 249)
                pnlOnReportsFeedbacksBtn.Visible = False

            Case "btnNotifications"
                selectedUC = New ucNotifications()
                clickedButton.Image = My.Resources.notification_active_icon
                clickedButton.BackColor = Color.FromArgb(162, 167, 249)
                pnlOnNotificationsBtn.Visible = False

            Case "btnHelpsSupports"
                selectedUC = New ucHelpsSupports()
                clickedButton.Image = My.Resources.helpsupport_active_icon
                clickedButton.BackColor = Color.FromArgb(162, 167, 249)
                pnlOnHelpsSupportsBtn.Visible = False

            Case "btnRevenue"
                selectedUC = New ucRevenue()
                clickedButton.Image = My.Resources.revenue_active_icon
                clickedButton.BackColor = Color.FromArgb(162, 167, 249)
                pnlOnRevenueBtn.Visible = False

            Case "btnAdmin"
                selectedUC = New ucAdminProfile()
                clickedButton.Image = My.Resources.profile_active_icon
                clickedButton.BackColor = Color.FromArgb(162, 167, 249)
        End Select

        ' Load the selected user control into the main container
        If selectedUC IsNot Nothing Then
            LoadUserControl(selectedUC)
        End If
    End Sub

    Private Sub ResetSidebarUI()
        ' Reset all buttons to default icons
        btnDashboards.Image = My.Resources.dashboard_default_icon
        btnUsers.Image = My.Resources.users_default_icon
        btnSellers.Image = My.Resources.seller_default_icon
        btnEvents.Image = My.Resources.event_default_icon
        btnRevenue.Image = My.Resources.revenue_default_icon
        btnReportsFeedbacks.Image = My.Resources.reportfeedback_default_icon
        btnNotifications.Image = My.Resources.notification_default_icon
        btnHelpsSupports.Image = My.Resources.helpsupport_default_icon
        btnAdmin.Image = My.Resources.profile_default_icon
        ' Reset all buttons to default fore colors
        btnDashboards.ForeColor = Color.White
        btnUsers.ForeColor = Color.White
        btnSellers.ForeColor = Color.White
        btnEvents.ForeColor = Color.White
        btnRevenue.ForeColor = Color.White
        btnReportsFeedbacks.ForeColor = Color.White
        btnNotifications.ForeColor = Color.White
        btnHelpsSupports.ForeColor = Color.White
        btnAdmin.ForeColor = Color.White
        ' Reset all buttons to default back colors
        btnDashboards.BackColor = Color.FromArgb(26, 26, 29)
        btnUsers.BackColor = Color.FromArgb(26, 26, 29)
        btnSellers.BackColor = Color.FromArgb(26, 26, 29)
        btnEvents.BackColor = Color.FromArgb(26, 26, 29)
        btnRevenue.BackColor = Color.FromArgb(26, 26, 29)
        btnReportsFeedbacks.BackColor = Color.FromArgb(26, 26, 29)
        btnNotifications.BackColor = Color.FromArgb(26, 26, 29)
        btnHelpsSupports.BackColor = Color.FromArgb(26, 26, 29)
        btnAdmin.BackColor = Color.FromArgb(26, 26, 29)
        ' Reset all panel on buttons to visible
        pnlOnDashboardsBtn.Visible = True
        pnlOnUsersBtn.Visible = True
        pnlOnSellersBtn.Visible = True
        pnlOnEventsBtn.Visible = True
        pnlOnRevenueBtn.Visible = True
        pnlOnReportsFeedbacksBtn.Visible = True
        pnlOnNotificationsBtn.Visible = True
        pnlOnHelpsSupportsBtn.Visible = True
    End Sub

    Private Sub pcbLogo_Click(sender As Object, e As EventArgs) Handles pcbLogo.Click
        btnDashboards.PerformClick()
    End Sub

    Private Sub UcContents1_Load(sender As Object, e As EventArgs)

    End Sub

    Private Sub pnlMainContainer_Paint(sender As Object, e As PaintEventArgs) Handles pnlMainContainer.Paint

    End Sub
End Class
