Imports System.Data.OleDb
Imports System.Windows.Forms.DataVisualization.Charting

Public Class ucUsers

    ' Connection string to the Access database
    Dim connString As String = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\afifa\source\repos\AdminSite_OMCSolution\LingoSign.accdb"

    Private Sub ucUsers_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ApplyRoundedRegionToAll(Me)

        cboUserStatus.Items.Clear()
        cboUserStatus.Items.AddRange(New Object() {"All", "Premium", "Basic"})
        cboUserStatus.SelectedIndex = -1 ' No filter selected by default

        LoadUserData()
    End Sub

    Private Sub LoadUserData()
        Dim dt As New DataTable()

        Using conn As New OleDbConnection(connString)
            Dim cmd As New OleDbCommand("SELECT * FROM [User]", conn)
            conn.Open()
            dt.Load(cmd.ExecuteReader())
        End Using

        dgvUserList.DataSource = dt

        ' Count each status
        Dim total = dt.Rows.Count
        Dim active As Integer = 0
        For Each row As DataRow In dt.Rows
            If row("DateAndTime") IsNot DBNull.Value Then
                Dim loginDate As DateTime = Convert.ToDateTime(row("DateAndTime"))
                If loginDate.Date = DateTime.Today Then
                    active += 1
                End If
            End If
        Next
        Dim inactive = total - active
        Dim premium = dt.Select("UserStatus = 'Premium'").Length
        Dim basic = dt.Select("UserStatus = 'basic'").Length

        ' Update labels
        Label53.Text = $"Total Users :   {total}"
        Label54.Text = $"Active :   {active}"
        Label56.Text = $"Inactive :   {inactive}"
        Label2.Text = $"Premium :   {premium}"
        Label1.Text = $"Basic :   {basic}"

        ' Update charts
        UpdateUserTypeChart(total, premium, basic)
        UpdateUserActivityPieChart(active, inactive)
        UpdateLoginTrendChart()
    End Sub

    Private Sub UpdateUserTypeChart(total As Integer, premium As Integer, basic As Integer)
        chartUserType.Series(0).Points.Clear()
        chartUserType.Series(0).Points.AddXY("Total", total)
        chartUserType.Series(0).Points.AddXY("Premium", premium)
        chartUserType.Series(0).Points.AddXY("Basic", basic)
        ' Set custom colors for each bar
        chartUserType.Series(0).Points(0).Color = Color.LightGray       ' Total
        chartUserType.Series(0).Points(1).Color = Color.LemonChiffon    ' Premium
        chartUserType.Series(0).Points(2).Color = Color.LightCyan       ' Basic

        With chartUserType.Series(0)
            .BorderColor = Color.Black       ' Border color
            .BorderWidth = 1                 ' Thickness of the border
            .BorderDashStyle = ChartDashStyle.Solid ' Optional: make it solid
        End With

    End Sub

    Private Sub UpdateUserActivityPieChart(active As Integer, inactive As Integer)
        chartUserActivity.Series.Clear()
        chartUserActivity.Series.Add("ActivityStatus")
        chartUserActivity.Series("ActivityStatus").ChartType = SeriesChartType.Pie
        chartUserActivity.Series("ActivityStatus").Points.AddXY("Active", active)
        chartUserActivity.Series("ActivityStatus").Points.AddXY("Inactive", inactive)
        chartUserActivity.Titles.Clear()
        chartUserActivity.Titles.Add("User Activity Overview")
        ' Clear old data
        chartUserActivity.Series(0).Points.Clear()

        ' Add data points (Active and Inactive)
        chartUserActivity.Series(0).Points.AddXY("Active", active)
        chartUserActivity.Series(0).Points.AddXY("Inactive", inactive)

        ' Set colors for each sector
        chartUserActivity.Series(0).Points(0).Color = Color.LightGreen   ' Active
        chartUserActivity.Series(0).Points(1).Color = Color.LightPink    ' Inactive

        chartUserActivity.Series(0).Label = "#PERCENT{P0}" ' Shows percent like 67%
        chartUserActivity.Series(0).LegendText = "#VALX"   ' Uses the label (Active/Inactive)

    End Sub

    Private Sub UpdateLoginTrendChart()
        chartUserLoginTrend.Series.Clear()
        chartUserLoginTrend.Series.Add("Logins")
        chartUserLoginTrend.Series("Logins").ChartType = SeriesChartType.Line
        chartUserLoginTrend.Titles.Clear()
        chartUserLoginTrend.Titles.Add("User Login Trend (Past 7 Days)")

        ' Initialize dictionary to hold date and count
        Dim loginCounts As New Dictionary(Of Date, Integer)
        For i As Integer = 6 To 0 Step -1
            Dim day As Date = DateTime.Today.AddDays(-i)
            loginCounts(day) = 0
        Next

        ' Count logins per date
        For Each row As DataRow In CType(dgvUserList.DataSource, DataTable).Rows
            If row("DateAndTime") IsNot DBNull.Value Then
                Dim loginDate As DateTime = Convert.ToDateTime(row("DateAndTime")).Date
                If loginCounts.ContainsKey(loginDate) Then
                    loginCounts(loginDate) += 1
                End If
            End If
        Next

        ' Add data to chart
        For Each kvp In loginCounts
            chartUserLoginTrend.Series("Logins").Points.AddXY(kvp.Key.ToString("MMM dd"), kvp.Value)
        Next
    End Sub

    Private Sub txtUserSearch_TextChanged(sender As Object, e As EventArgs) Handles txtUserSearch.TextChanged
        FilterUsers()
    End Sub

    Private Sub cboUserStatus_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboUserStatus.SelectedIndexChanged
        FilterUsers()
    End Sub

    Private Sub FilterUsers()
        Dim keyword As String = txtUserSearch.Text.Trim()
        Dim selectedFilter As String = If(cboUserStatus.SelectedItem IsNot Nothing, cboUserStatus.SelectedItem.ToString(), "")

        Dim dt As New DataTable()
        Dim query As String = "SELECT * FROM [User] WHERE 1=1"

        ' Filter by status (Premium / Basic)
        If selectedFilter = "All" Then

        End If
        If selectedFilter = "Premium" Then
            query &= " AND UserStatus = 'Premium'"
        ElseIf selectedFilter = "Basic" Then
            query &= " AND UserStatus = 'basic'"
        End If

        ' Filter by keyword (FirstName or Email)
        If keyword <> "" Then
            query &= " AND (FirstName LIKE ? OR Email LIKE ?)"
        End If

        Using conn As New OleDbConnection(connString)
            Using cmd As New OleDbCommand(query, conn)
                If keyword <> "" Then
                    cmd.Parameters.AddWithValue("?", "%" & keyword & "%")
                    cmd.Parameters.AddWithValue("?", "%" & keyword & "%")
                End If

                conn.Open()
                dt.Load(cmd.ExecuteReader())
            End Using
        End Using

        dgvUserList.DataSource = dt

        ' Refresh charts based on filtered data
        Dim total = dt.Rows.Count
        Dim active As Integer = 0
        For Each row As DataRow In dt.Rows
            If row("DateAndTime") IsNot DBNull.Value Then
                Dim loginDate As DateTime = Convert.ToDateTime(row("DateAndTime"))
                If loginDate.Date = DateTime.Today Then
                    active += 1
                End If
            End If
        Next
        Dim inactive = total - active
        Dim premium = dt.Select("UserStatus = 'Premium'").Length
        Dim basic = dt.Select("UserStatus = 'basic'").Length

        UpdateUserTypeChart(total, premium, basic)
        UpdateUserActivityPieChart(active, inactive)
        UpdateLoginTrendChart()
    End Sub


End Class
