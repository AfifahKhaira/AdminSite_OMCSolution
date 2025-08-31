Imports System.Data.OleDb
Imports Excel = Microsoft.Office.Interop.Excel

Public Class ucReportsFeedbacks
    Dim connString As String = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\afifa\source\repos\AdminSite_OMCSolution\LingoSign.accdb"
    Dim dtFeedback As New DataTable()

    Private Sub ucReportsFeedbacks_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ApplyRoundedRegionToAll(Me)
        LoadFeedbackData()
    End Sub

    Private Sub LoadFeedbackData()
        dtFeedback.Clear()

        Using conn As New OleDbConnection(connString)
            Dim query As String = "SELECT * FROM Feedback"
            Dim adapter As New OleDbDataAdapter(query, conn)
            adapter.Fill(dtFeedback)
        End Using

        dgvReportFeedbackList.DataSource = dtFeedback
        UpdateSummaryLabels()
    End Sub

    Private Sub UpdateSummaryLabels()
        Dim total As Integer = dtFeedback.Rows.Count
        Dim unread As Integer = dtFeedback.Select("Status = 'Unread'").Length
        Dim inProgress As Integer = dtFeedback.Select("Status = 'In Progress'").Length
        Dim resolved As Integer = dtFeedback.Select("Status = 'Resolved'").Length

        Label94.Text = $"Total :   {total}"
        Label93.Text = $"Unread :   {unread}"
        Label91.Text = $"In Progress :   {inProgress}"
        Label92.Text = $"Resolved :   {resolved}"
    End Sub

    Private Sub txtReportsFeedbacksSearch_TextChanged(sender As Object, e As EventArgs) Handles txtReportsFeedbacksSearch.TextChanged
        ApplyFilter()
    End Sub

    Private Sub cboReportsFeedbacksStatus_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboReportsFeedbacksStatus.SelectedIndexChanged
        ApplyFilter()
    End Sub

    Private Sub ApplyFilter()
        Dim filter As String = ""
        Dim statusFilter As String = cboReportsFeedbacksStatus.Text.Trim()
        Dim searchText As String = txtReportsFeedbacksSearch.Text.Trim().Replace("'", "''")

        If Not String.IsNullOrEmpty(statusFilter) Then
            filter = $"Status = '{statusFilter}'"
        End If

        If Not String.IsNullOrEmpty(searchText) Then
            If Not String.IsNullOrEmpty(filter) Then
                filter &= " AND "
            End If
            filter &= $"(ID LIKE '%{searchText}%' OR Title LIKE '%{searchText}%' OR Message LIKE '%{searchText}%')"
        End If

        Dim dv As New DataView(dtFeedback)
        dv.RowFilter = filter
        dgvReportFeedbackList.DataSource = dv
    End Sub

    Private Sub btnReviewSelectedRF_Click(sender As Object, e As EventArgs) Handles btnReviewSelectedRF.Click
        If dgvReportFeedbackList.SelectedRows.Count = 0 Then
            MessageBox.Show("Please select a row to review.", "No Selection", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        Dim feedbackID As Integer = Convert.ToInt32(dgvReportFeedbackList.SelectedRows(0).Cells("FeedbackID").Value)

        Using conn As New OleDbConnection(connString)
            conn.Open()
            Dim cmd As New OleDbCommand("UPDATE Feedback SET Status = 'In Progress' WHERE FeedbackID = @id", conn)
            cmd.Parameters.AddWithValue("@id", feedbackID)
            cmd.ExecuteNonQuery()
        End Using

        MessageBox.Show("Feedback marked as In Progress.")
        LoadFeedbackData()
    End Sub

    Private Sub btnResolvedSelectedRF_Click(sender As Object, e As EventArgs) Handles btnResolvedSelectedRF.Click
        If dgvReportFeedbackList.SelectedRows.Count = 0 Then
            MessageBox.Show("Please select a row to mark as Resolved.", "No Selection", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        Dim feedbackID As Integer = Convert.ToInt32(dgvReportFeedbackList.SelectedRows(0).Cells("FeedbackID").Value)

        Using conn As New OleDbConnection(connString)
            conn.Open()
            Dim cmd As New OleDbCommand("UPDATE Feedback SET Status = 'Resolved' WHERE FeedbackID = @id", conn)
            cmd.Parameters.AddWithValue("@id", feedbackID)
            cmd.ExecuteNonQuery()
        End Using

        MessageBox.Show("Feedback marked as Resolved.")
        LoadFeedbackData()
    End Sub

    'Private Sub btnExportToExcelRF_Click(sender As Object, e As EventArgs) Handles btnExportToExcelRF.Click
    '    If dgvReportFeedbackList.Rows.Count = 0 Then
    '        MessageBox.Show("No data to export.")
    '        Return
    '    End If

    '    Dim excelApp As New Excel.Application
    '    Dim workbook = excelApp.Workbooks.Add()
    '    Dim worksheet = workbook.Sheets(1)

    '    ' Export headers
    '    For col = 0 To dgvReportFeedbackList.Columns.Count - 1
    '        worksheet.Cells(1, col + 1).Value = dgvReportFeedbackList.Columns(col).HeaderText
    '    Next

    '    ' Export rows
    '    For row = 0 To dgvReportFeedbackList.Rows.Count - 1
    '        For col = 0 To dgvReportFeedbackList.Columns.Count - 1
    '            worksheet.Cells(row + 2, col + 1).Value = dgvReportFeedbackList.Rows(row).Cells(col).Value?.ToString()
    '        Next
    '    Next

    '    excelApp.Visible = True
    'End Sub
End Class
