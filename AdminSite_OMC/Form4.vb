Imports System.Drawing.Drawing2D

Public Class Form4
    Private Sub Form4_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        HideAllPages()
        pnlDashboardsPage.Visible = True
        PanelRegion()
    End Sub

    Private Sub PanelRegion()
        Dim radius As Integer = 30 ' change this for more or less curve
        Dim panelPath As New GraphicsPath()

        ' Create rounded rectangle path
        panelPath.StartFigure()
        panelPath.AddArc(0, 0, radius, radius, 180, 90) ' Top-left
        panelPath.AddArc(Panel1.Width - radius, 0, radius, radius, 270, 90) ' Top-right
        panelPath.AddArc(Panel1.Width - radius, Panel1.Height - radius, radius, radius, 0, 90) ' Bottom-right
        panelPath.AddArc(0, Panel1.Height - radius, radius, radius, 90, 90) ' Bottom-left
        panelPath.CloseFigure()

        ' Apply region
        Panel1.Region = New Region(panelPath)
        Panel2.Region = New Region(panelPath)
        Panel3.Region = New Region(panelPath)
        Panel4.Region = New Region(panelPath)
        Panel5.Region = New Region(panelPath)
        Panel6.Region = New Region(panelPath)
    End Sub

    Private Sub pcbLogo_MouseMove(sender As Object, e As MouseEventArgs) Handles pcbLogo.MouseMove
        Dim pb As PictureBox = CType(sender, PictureBox)

        If pb.Image Is Nothing Then Exit Sub

        Dim bmp As Bitmap = CType(pb.Image, Bitmap)

        ' Adjust coordinates based on PictureBox alignment
        Dim x = e.X
        Dim y = e.Y

        ' Check bounds
        If x >= 0 AndAlso x < bmp.Width AndAlso y >= 0 AndAlso y < bmp.Height Then
            Dim pixel As Color = bmp.GetPixel(x, y)

            ' Check if pixel is transparent
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
    Handles btnDashboards.Click, btnUsers.Click, btnSellers.Click, btnEvents.Click, btnContents.Click, btnReportsFeedbacks.Click, btnNotifications.Click, btnHelpsSupports.Click, btnSettings.Click, btnAdmin.Click

        ResetButtonColors()
        ResetForeColors()
        ResetButtonIcons()
        ShowAllPanelsOnBtn()
        HideAllPages()

        Dim clickedButton As Button = CType(sender, Button)
        clickedButton.ForeColor = Color.FromArgb(26, 26, 29)

        Select Case clickedButton.Name
            Case "btnDashboards"
                clickedButton.Image = My.Resources.dashboard_active_icon
                clickedButton.BackColor = Color.FromArgb(162, 167, 249)
                pnlOnDashboardsBtn.Visible = False
                pnlDashboardsPage.Visible = True
            Case "btnUsers"
                clickedButton.Image = My.Resources.users_active_icon
                clickedButton.BackColor = Color.FromArgb(162, 167, 249)
                pnlOnUsersBtn.Visible = False
                pnlUsersPage.Visible = True
            Case "btnSellers"
                clickedButton.Image = My.Resources.seller_active_icon
                clickedButton.BackColor = Color.FromArgb(162, 167, 249)
                pnlOnSellersBtn.Visible = False
                pnlSellersPage.Visible = True
            Case "btnEvents"
                clickedButton.Image = My.Resources.event_active_icon
                clickedButton.BackColor = Color.FromArgb(162, 167, 249)
                pnlOnEventsBtn.Visible = False
                pnlEventsPage.Visible = True
            Case "btnContents"
                clickedButton.Image = My.Resources.content_active_icon
                clickedButton.BackColor = Color.FromArgb(162, 167, 249)
                pnlOnContentsBtn.Visible = False
                pnlContentsPage.Visible = True
            Case "btnReportsFeedbacks"
                clickedButton.Image = My.Resources.reportfeedback_active_icon
                clickedButton.BackColor = Color.FromArgb(162, 167, 249)
                pnlOnReportsFeedbacksBtn.Visible = False
                pnlReportsFeedbacksPage.Visible = True
            Case "btnNotifications"
                clickedButton.Image = My.Resources.notification_active_icon
                clickedButton.BackColor = Color.FromArgb(162, 167, 249)
                pnlOnNotificationsBtn.Visible = False
                pnlNotificationsPage.Visible = True
            Case "btnHelpsSupports"
                clickedButton.Image = My.Resources.helpsupport_active_icon
                clickedButton.BackColor = Color.FromArgb(162, 167, 249)
                pnlOnHelpsSupportsBtn.Visible = False
                pnlHelpsSupportsPage.Visible = True
            Case "btnSettings"
                clickedButton.Image = My.Resources.setting_active_icon
                clickedButton.BackColor = Color.FromArgb(162, 167, 249)
                pnlOnSettingsBtn.Visible = False
                pnlSettingsPage.Visible = True
            Case "btnAdmin"
                'clickedButton.Image = My.Resources.admin_active_icon
                'clickedButton.BackColor = Color.FromArgb(162, 167, 249)
                pnlAdminPage.Visible = True
        End Select
    End Sub

    Private Sub ResetButtonIcons()
        btnDashboards.Image = My.Resources.dashboard_default_icon
        btnUsers.Image = My.Resources.users_default_icon
        btnSellers.Image = My.Resources.seller_default_icon
        btnEvents.Image = My.Resources.event_default_icon
        btnContents.Image = My.Resources.content_default_icon
        btnReportsFeedbacks.Image = My.Resources.reportfeedback_default_icon
        btnNotifications.Image = My.Resources.notification_default_icon
        btnHelpsSupports.Image = My.Resources.helpsupport_default_icon
        btnSettings.Image = My.Resources.setting_default_icon
    End Sub

    Private Sub ResetForeColors()
        btnDashboards.ForeColor = Color.White
        btnUsers.ForeColor = Color.White
        btnSellers.ForeColor = Color.White
        btnEvents.ForeColor = Color.White
        btnContents.ForeColor = Color.White
        btnReportsFeedbacks.ForeColor = Color.White
        btnNotifications.ForeColor = Color.White
        btnHelpsSupports.ForeColor = Color.White
        btnSettings.ForeColor = Color.White
    End Sub

    Private Sub ResetButtonColors()
        btnDashboards.BackColor = Color.FromArgb(26, 26, 29)
        btnUsers.BackColor = Color.FromArgb(26, 26, 29)
        btnSellers.BackColor = Color.FromArgb(26, 26, 29)
        btnEvents.BackColor = Color.FromArgb(26, 26, 29)
        btnContents.BackColor = Color.FromArgb(26, 26, 29)
        btnReportsFeedbacks.BackColor = Color.FromArgb(26, 26, 29)
        btnNotifications.BackColor = Color.FromArgb(26, 26, 29)
        btnHelpsSupports.BackColor = Color.FromArgb(26, 26, 29)
        btnSettings.BackColor = Color.FromArgb(26, 26, 29)
    End Sub

    Private Sub ShowAllPanelsOnBtn()
        pnlOnDashboardsBtn.Visible = True
        pnlOnUsersBtn.Visible = True
        pnlOnSellersBtn.Visible = True
        pnlOnEventsBtn.Visible = True
        pnlOnContentsBtn.Visible = True
        pnlOnReportsFeedbacksBtn.Visible = True
        pnlOnNotificationsBtn.Visible = True
        pnlOnHelpsSupportsBtn.Visible = True
        pnlOnSettingsBtn.Visible = True
    End Sub

    Private Sub HideAllPages()
        pnlDashboardsPage.Visible = False
        pnlUsersPage.Visible = False
        pnlSellersPage.Visible = False
        pnlEventsPage.Visible = False
        pnlContentsPage.Visible = False
        pnlReportsFeedbacksPage.Visible = False
        pnlNotificationsPage.Visible = False
        pnlHelpsSupportsPage.Visible = False
        pnlSettingsPage.Visible = False
        pnlAdminPage.Visible = False
    End Sub

    Private Sub pcbLogo_Click(sender As Object, e As EventArgs) Handles pcbLogo.Click
        HideAllPages()
        ResetButtonColors()
        ShowAllPanelsOnBtn()
        ResetForeColors()
        ResetButtonIcons()
        pnlDashboardsPage.Visible = True
    End Sub
End Class