Imports System.Data.OleDb
Imports System.IO
Imports System.Windows.Forms.DataVisualization.Charting

Public Class ucSellers

    ' Connection string to the Access database
    Dim connString As String = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\afifa\source\repos\AdminSite_OMCSolution\LingoSign.accdb"

    Private Sub ucSellers_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ApplyRoundedRegionToAll(Me)

        cboSellerStatus.Items.Clear()
        cboSellerStatus.Items.AddRange(New Object() {"All", "Approved", "Pending", "Suspended"})
        cboSellerStatus.SelectedIndex = -1 ' No filter selected by default

        LoadSellerData()
    End Sub

    Private Sub LoadSellerData()
        Dim dt As New DataTable()

        Using conn As New OleDbConnection(connString)
            Dim cmd As New OleDbCommand("SELECT * FROM [Seller]", conn)
            conn.Open()
            dt.Load(cmd.ExecuteReader())
        End Using

        dgvSellerList.DataSource = dt

        ' Count each status
        Dim total = dt.Rows.Count
        Dim approved = dt.Select("SellerStatus = 'Approved'").Length
        Dim pending = dt.Select("SellerStatus = 'Pending'").Length
        Dim suspended = dt.Select("SellerStatus = 'Suspended'").Length

        ' Update labels
        Label69.Text = $"Total Sellers :   {total}"
        Label68.Text = $"Approved :   {approved}"
        Label71.Text = $"Pending :   {pending}"
        Label67.Text = $"Suspended :   {suspended}"

        ' Update bar chart
        UpdateSellerStatusChart(approved, pending, suspended)
    End Sub

    Private Sub UpdateSellerStatusChart(approved As Integer, pending As Integer, suspended As Integer)
        chartSellerBarStatus.Series(0).Points.Clear()
        chartSellerStatusPie.Series(0).Points.Clear()

        With chartSellerBarStatus.Series(0)
            .Points.AddXY("Approved", approved)
            .Points.AddXY("Pending", pending)
            .Points.AddXY("Suspended", suspended)

            .Points(0).Color = Color.LightGreen
            .Points(1).Color = Color.FromArgb(255, 255, 249, 196)
            .Points(2).Color = Color.LightPink

            For Each p As DataPoint In .Points
                p.BorderColor = Color.Gray
                p.BorderWidth = 1
            Next

            ' Add Pie Chart Points
            With chartSellerStatusPie.Series(0)
                .Points.AddXY("Approved", approved)
                .Points.AddXY("Pending", pending)
                .Points.AddXY("Suspended", suspended)

                ' Set individual sector colors
                .Points(0).Color = Color.LightGreen
                .Points(1).Color = Color.FromArgb(255, 255, 249, 196)
                .Points(2).Color = Color.LightPink
            End With
        End With
    End Sub

    Private Sub txtSellerSearch_TextChanged(sender As Object, e As EventArgs) Handles txtSellerSearch.TextChanged
        FilterSellers()
    End Sub

    Private Sub cboSellerStatus_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboSellerStatus.SelectedIndexChanged
        FilterSellers()
    End Sub

    Private Sub FilterSellers()
        Dim keyword As String = txtSellerSearch.Text.Trim()
        Dim selectedFilter As String = If(cboSellerStatus.SelectedItem IsNot Nothing, cboSellerStatus.SelectedItem.ToString(), "")

        Dim dt As New DataTable()
        Dim query As String = "SELECT * FROM [Seller] WHERE 1=1"

        ' Apply status filter
        If selectedFilter = "Approved" Then
            query &= " AND SellerStatus = 'Approved'"
        ElseIf selectedFilter = "Pending" Then
            query &= " AND SellerStatus = 'Pending'"
        ElseIf selectedFilter = "Suspended" Then
            query &= " AND SellerStatus = 'Suspended'"
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

        dgvSellerList.DataSource = dt



        ' Refresh status count and chart
        Dim total = dt.Rows.Count
        Dim approved = dt.Select("SellerStatus = 'Approved'").Length
        Dim pending = dt.Select("SellerStatus = 'Pending'").Length
        Dim suspended = dt.Select("SellerStatus = 'Suspended'").Length

        Label69.Text = $"Total Sellers :   {total}"
        Label68.Text = $"Approved :   {approved}"
        Label71.Text = $"Pending :   {pending}"
        Label67.Text = $"Suspended :   {suspended}"

        UpdateSellerStatusChart(approved, pending, suspended)
    End Sub

    Private Sub btnApproveSelectedSeller_Click(sender As Object, e As EventArgs) Handles btnApproveSelectedSeller.Click
        UpdateSelectedStatus("Approved")
    End Sub

    Private Sub btnRejectSelectedSeller_Click(sender As Object, e As EventArgs) Handles btnRejectSelectedSeller.Click
        UpdateSelectedStatus("Pending")
    End Sub

    Private Sub btnSuspendSelectedSeller_Click(sender As Object, e As EventArgs) Handles btnSuspendSelectedSeller.Click
        UpdateSelectedStatus("Suspended")
    End Sub

    Private Sub UpdateSelectedStatus(newStatus As String)
        If dgvSellerList.SelectedRows.Count = 0 Then
            MessageBox.Show("Please select at least one seller.")
            Return
        End If

        Try
            connection.Open()

            For Each row As DataGridViewRow In dgvSellerList.SelectedRows
                Dim sellerID As Integer = Convert.ToInt32(row.Cells("SellerID").Value)
                Dim cmd As New OleDbCommand("UPDATE Seller SET SellerStatus = ? WHERE SellerID = ?", connection)
                cmd.Parameters.AddWithValue("?", newStatus)
                cmd.Parameters.AddWithValue("?", sellerID)
                cmd.ExecuteNonQuery()
            Next

            MessageBox.Show("Status updated successfully.")
            LoadSellerData()
            FilterSellers()
        Catch ex As Exception
            MessageBox.Show("Error updating seller status: " & ex.Message)
        Finally
            connection.Close()
        End Try
    End Sub

    ' EXPORT TO CSV
    Private Sub btnExportToExcelSeller_Click(sender As Object, e As EventArgs) Handles btnExportToExcelSeller.Click
        Dim saveDialog As New SaveFileDialog With {
            .Filter = "CSV files (*.csv)|*.csv",
            .Title = "Export to CSV",
            .FileName = "SellerList.csv"
        }

        If saveDialog.ShowDialog() = DialogResult.OK Then
            Try
                Using writer As New StreamWriter(saveDialog.FileName)
                    ' Header
                    For i As Integer = 0 To dgvSellerList.Columns.Count - 1
                        writer.Write(dgvSellerList.Columns(i).HeaderText)
                        If i < dgvSellerList.Columns.Count - 1 Then writer.Write(",")
                    Next
                    writer.WriteLine()

                    ' Rows
                    For Each row As DataGridViewRow In dgvSellerList.Rows
                        For i As Integer = 0 To dgvSellerList.Columns.Count - 1
                            writer.Write(row.Cells(i).Value?.ToString())
                            If i < dgvSellerList.Columns.Count - 1 Then writer.Write(",")
                        Next
                        writer.WriteLine()
                    Next
                End Using

                MessageBox.Show("Export successful.")
            Catch ex As Exception
                MessageBox.Show("Export failed: " & ex.Message)
            End Try
        End If
    End Sub
End Class
