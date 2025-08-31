Imports System.Data.OleDb
Imports System.Reflection.Emit

Public Class ucEvents
    Dim connString As String = ("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\afifa\source\repos\AdminSite_OMCSolution\LingoSign.accdb")

    Private Sub LoadEventsData()
        Dim dt As New DataTable()

        Using conn As New OleDbConnection(connString)
            Dim cmd As New OleDbCommand("SELECT * FROM Events", conn)
            conn.Open()
            dt.Load(cmd.ExecuteReader())
        End Using

        dgvEventList.DataSource = dt

        ' Count each status
        Dim total = dt.Rows.Count
        Dim approved = dt.Select("EventStatus = 'Approved'").Length
        Dim pending = dt.Select("EventStatus = 'Pending'").Length
        Dim rejected = dt.Select("EventStatus = 'Rejected'").Length

        ' Update labels
        Label70.Text = $"Total Events :   {total}"
        Label60.Text = $"Approved :   {approved}"
        Label58.Text = $"Pending :   {pending}"
        Label59.Text = $"Rejected :   {rejected}"
    End Sub
    Private Sub cboSellerStatus_SelectedIndexChanged(sender As Object, e As EventArgs)
        If dgvEventList.SelectedRows.Count = 0 Then
            MessageBox.Show("Please select an event from the list first.")
            cboEventStatus.SelectedIndex = -1
            Return
        End If

        ' Get selected seller ID
        Dim selectedID As Integer = dgvEventList.SelectedRows(0).Cells("ID").Value
        Dim selectedAction As String = cboEventStatus.SelectedItem.ToString()
        Dim newStatus As String = ""

        ' Determine the new status
        If selectedAction = "Approve" Then
            newStatus = "Approved"
        ElseIf selectedAction = "Reject" Then
            newStatus = "Rejected"
        Else
            Return
        End If

        ' Update the database
        Dim connString As String = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\wafi danish\OneDrive\Documents\OMC\Lingo_Sign\bin\Debug\LingoSign.accdb"
        Using conn As New OleDbConnection(connString)
            Dim cmd As New OleDbCommand("UPDATE Event SET EventStatus = ? WHERE ID = ?", conn)
            cmd.Parameters.AddWithValue("?", newStatus)
            cmd.Parameters.AddWithValue("?", selectedID)
            conn.Open()
            cmd.ExecuteNonQuery()
        End Using

        MessageBox.Show("Event status updated to '" & newStatus & "'", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)

        ' Refresh data
        LoadEventsData()
        cboEventStatus.SelectedIndex = -1
    End Sub
    'Private Sub dgvEventList_SelectionChanged(sender As Object, e As EventArgs) Handles dgvEventList.SelectionChanged
    '    If dgvEventList.SelectedRows.Count > 0 Then
    '        cboEventStatus.Enabled = True
    '    Else
    '        cboEventStatus.Enabled = False
    '    End If
    'End Sub
    Private Sub txtEventSearch_TextChanged(sender As Object, e As EventArgs) Handles txtEventSearch.TextChanged
        Dim keyword As String = txtEventSearch.Text.Trim().ToUpper()

        For Each row As DataGridViewRow In dgvEventList.Rows
            If row.IsNewRow Then Continue For

            Dim eventTitle As String = row.Cells("EventTitle").Value?.ToString().ToUpper()

            ' If search box is empty, show all rows
            If String.IsNullOrWhiteSpace(keyword) Then
                row.Visible = True
            Else
                ' Show only rows where EventTitle contains the keyword
                row.Visible = eventTitle.Contains(keyword)
            End If
        Next
    End Sub
    Private Sub ucEvents_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ApplyRoundedRegionToAll(Me)
        cboEventStatus.Items.Clear()
        cboEventStatus.Items.AddRange(New Object() {"Approve", "Reject"})
        dtpEventTo.Value = dtpEventFrom.Value
        LoadOrganizerList()

        LoadEventsData()
    End Sub
    Private Sub dtpEventFrom_ValueChanged(sender As Object, e As EventArgs) Handles dtpEventFrom.ValueChanged, dtpEventTo.ValueChanged
        ApplyEventDateFilter()
    End Sub

    Private Sub ApplyEventDateFilter()
        Dim startDate As Date = dtpEventFrom.Value.Date
        Dim endDate As Date = dtpEventTo.Value.Date

        ' Loop through each row in the DataGridView
        For Each row As DataGridViewRow In dgvEventList.Rows
            If row.IsNewRow Then Continue For

            Dim eventDateValue = row.Cells("EventDate").Value
            If IsDBNull(eventDateValue) OrElse Not IsDate(eventDateValue) Then
                row.Visible = False
                Continue For
            End If

            Dim eventDate As Date = Convert.ToDateTime(eventDateValue)

            ' Show based on filter:
            ' 1. If both dates are equal, treat as single-day filter
            ' 2. If dtpEventTo is greater, show within range
            If startDate = endDate Then
                row.Visible = (eventDate.Date = startDate)
            Else
                row.Visible = (eventDate >= startDate AndAlso eventDate <= endDate)
            End If
        Next
    End Sub
    Private Sub LoadOrganizerList()
        cboOrganizer.Items.Clear()
        cboOrganizer.Items.Add("All") ' Optional: show all option

        Dim ngoNames As New HashSet(Of String)

        ' Loop through dgvEventList to collect unique NGOName values
        For Each row As DataGridViewRow In dgvEventList.Rows
            If row.IsNewRow Then Continue For

            Dim ngoName As String = row.Cells("NGOName").Value?.ToString()
            If Not String.IsNullOrWhiteSpace(ngoName) Then
                ngoNames.Add(ngoName)
            End If
        Next

        ' Add to combobox
        For Each item In ngoNames
            cboOrganizer.Items.Add(item)
        Next

        cboOrganizer.SelectedIndex = 0 ' Default to "All"
    End Sub
    Private Sub cboOrganizer_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboOrganizer.SelectedIndexChanged
        Dim selectedOrganizer As String = cboOrganizer.SelectedItem.ToString()

        For Each row As DataGridViewRow In dgvEventList.Rows
            If row.IsNewRow Then Continue For

            Dim ngoName As String = row.Cells("NGOName").Value?.ToString()

            ' Show all if "All" selected
            If selectedOrganizer = "All" Then
                row.Visible = True
            Else
                row.Visible = (ngoName = selectedOrganizer)
            End If
        Next
    End Sub

    Private Sub btnApproveSelectedEvent_Click(sender As Object, e As EventArgs) Handles btnApproveSelectedEvent.Click
        UpdateSelectedStatus("Approved")
    End Sub

    Private Sub btnRejectSelectedEvent_Click(sender As Object, e As EventArgs) Handles btnRejectSelectedEvent.Click
        UpdateSelectedStatus("Rejected")
    End Sub

    Private Sub UpdateSelectedStatus(newStatus As String)
        If dgvEventList.SelectedRows.Count = 0 Then
            MessageBox.Show("Please select at least one seller.")
            Return
        End If

        Try
            connection.Open()

            For Each row As DataGridViewRow In dgvEventList.SelectedRows
                Dim sellerID As Integer = Convert.ToInt32(row.Cells("SellerID").Value)
                Dim cmd As New OleDbCommand("UPDATE Seller SET SellerStatus = ? WHERE SellerID = ?", connection)
                cmd.Parameters.AddWithValue("?", newStatus)
                cmd.Parameters.AddWithValue("?", sellerID)
                cmd.ExecuteNonQuery()
            Next

            MessageBox.Show("Status updated successfully.")
            LoadEventsData()
            FilterEvents()
        Catch ex As Exception
            MessageBox.Show("Error updating seller status: " & ex.Message)
        Finally
            connection.Close()
        End Try
    End Sub

    Private Sub FilterEvents()
        Dim keyword As String = txtEventSearch.Text.Trim()
        Dim selectedFilter As String = If(cboEventStatus.SelectedItem IsNot Nothing, cboEventStatus.SelectedItem.ToString(), "")

        Dim dt As New DataTable()
        Dim query As String = "SELECT * FROM [Event] WHERE 1=1"

        ' Apply status filter
        If selectedFilter = "Approved" Then
            query &= " AND SellerStatus = 'Approved'"
        ElseIf selectedFilter = "Pending" Then
            query &= " AND SellerStatus = 'Pending'"
        ElseIf selectedFilter = "Rejected" Then
            query &= " AND SellerStatus = 'Rejected'"
        End If

        ' Filter by keyword (Email)
        If keyword <> "" Then
            query &= " AND (Email LIKE ?)"
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

        dgvEventList.DataSource = dt



        '' Refresh status count and chart
        'Dim total = dt.Rows.Count
        'Dim approved = dt.Select("SellerStatus = 'Approved'").Length
        'Dim pending = dt.Select("SellerStatus = 'Pending'").Length
        'Dim rejected = dt.Select("SellerStatus = 'Rejected'").Length

        'Label69.Text = $"Total Sellers :   {total}"
        'Label68.Text = $"Approved :   {approved}"
        'Label71.Text = $"Pending :   {pending}"
        'Label67.Text = $"Suspended :   {rejected}"

        'UpdateEventStatusChart(approved, pending, suspended)
    End Sub


End Class