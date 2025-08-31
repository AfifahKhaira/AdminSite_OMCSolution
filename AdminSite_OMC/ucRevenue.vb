Imports System.Data.OleDb
Imports System.IO
Imports iTextSharp.text
Imports iTextSharp.text.pdf
Imports Excel = Microsoft.Office.Interop.Excel

Public Class ucRevenue
    Dim connectionString As String = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\afifa\source\repos\AdminSite_OMCSolution\LingoSign.accdb;"
    Dim revenueDataTable As New DataTable()

    Private Sub ucRevenue_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ApplyRoundedRegionToAll(Me)
        LoadRevenueData()
        UpdateRevenueChart()
    End Sub

    Private Sub LoadRevenueData()
        Dim query As String = "SELECT * FROM RevenueRecords"
        Using conn As New OleDbConnection(connectionString), cmd As New OleDbCommand(query, conn)
            Dim adapter As New OleDbDataAdapter(cmd)
            revenueDataTable.Clear()
            adapter.Fill(revenueDataTable)
            dgvRevenueRecords.DataSource = revenueDataTable
        End Using
    End Sub

    Private Sub txtRevenueSearch_TextChanged(sender As Object, e As EventArgs) Handles txtRevenueSearch.TextChanged
        Dim keyword As String = txtRevenueSearch.Text.Trim().Replace("'", "''")
        Dim filter As String = $"[TransactionID] LIKE '%{keyword}%' OR [SourceName] LIKE '%{keyword}%' OR [SourceType] LIKE '%{keyword}%'"
        Dim dv As New DataView(revenueDataTable)
        dv.RowFilter = filter
        dgvRevenueRecords.DataSource = dv
    End Sub

    Private Sub cboRevenueStatus_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboRevenueStatus.SelectedIndexChanged
        Dim filter As String = ""
        Select Case cboRevenueStatus.SelectedItem.ToString()
            Case "Pending"
                filter = "Status = 'Pending'"
            Case "Completed"
                filter = "Status = 'Completed'"
            Case Else
                filter = ""
        End Select

        Dim dv As New DataView(revenueDataTable)
        dv.RowFilter = filter
        dgvRevenueRecords.DataSource = dv
    End Sub

    Private Sub UpdateRevenueChart()
        chartRevenueTrend.Series(0).Points.Clear()
        Dim query As String = "SELECT FORMAT([TransactionDate], 'yyyy-mm') AS MonthYear, SUM([Net (RM)]) AS Total FROM RevenueRecords GROUP BY FORMAT([TransactionDate], 'yyyy-mm') ORDER BY FORMAT([TransactionDate], 'yyyy-mm')"

        Using conn As New OleDbConnection(connectionString), cmd As New OleDbCommand(query, conn)
            conn.Open()
            Dim reader As OleDbDataReader = cmd.ExecuteReader()
            While reader.Read()
                Dim month As String = reader("MonthYear").ToString()
                Dim total As Decimal = Convert.ToDecimal(reader("Total"))
                chartRevenueTrend.Series(0).Points.AddXY(month, total)
            End While
        End Using
    End Sub

    ' EXPORT TO EXCEL (CSV)
    Private Sub btnExportToExcelRevenue_Click(sender As Object, e As EventArgs) Handles btnExportToExcelRevenue.Click
        Dim saveDialog As New SaveFileDialog With {.Filter = "CSV files (*.csv)|*.csv", .Title = "Export to CSV", .FileName = "RevenueRecords.csv"}

        If saveDialog.ShowDialog() = DialogResult.OK Then
            Try
                Using writer As New StreamWriter(saveDialog.FileName)
                    For i As Integer = 0 To dgvRevenueRecords.Columns.Count - 1
                        writer.Write(dgvRevenueRecords.Columns(i).HeaderText)
                        If i < dgvRevenueRecords.Columns.Count - 1 Then writer.Write(",")
                    Next
                    writer.WriteLine()

                    For Each row As DataGridViewRow In dgvRevenueRecords.Rows
                        For i As Integer = 0 To dgvRevenueRecords.Columns.Count - 1
                            writer.Write(row.Cells(i).Value?.ToString())
                            If i < dgvRevenueRecords.Columns.Count - 1 Then writer.Write(",")
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

    ' GENERATE REPORT (PDF)
    Private Sub btnGenerateReportRevenue_Click(sender As Object, e As EventArgs) Handles btnGenerateReportRevenue.Click
        ExportRevenueRecordsToPDF()
    End Sub

    Private Sub ExportRevenueRecordsToPDF()
        Try
            Dim folderPath As String = "C:\Users\afifa\Documents\"
            Dim fileName As String = "RevenueRecords_" & DateTime.Now.ToString("yyyyMMdd_HHmmss") & ".pdf"
            Dim fullPath As String = Path.Combine(folderPath, fileName)

            Dim pdfDoc As New Document(PageSize.A4, 10.0F, 10.0F, 20.0F, 10.0F)
            PdfWriter.GetInstance(pdfDoc, New FileStream(fullPath, FileMode.Create))
            pdfDoc.Open()

            ' Title Section
            Dim titleFont As iTextSharp.text.Font = FontFactory.GetFont(FontFactory.HELVETICA_BOLD, 16)
            Dim subtitleFont As iTextSharp.text.Font = FontFactory.GetFont(FontFactory.HELVETICA, 10)

            pdfDoc.Add(New Paragraph("Revenue Report", titleFont))
            pdfDoc.Add(New Paragraph("Generated on: " & DateTime.Now.ToString(), subtitleFont))
            pdfDoc.Add(New Paragraph(Environment.NewLine))

            Dim normalFont As New iTextSharp.text.Font(FontFactory.GetFont(FontFactory.HELVETICA_BOLD, 10))
            pdfDoc.Add(New Paragraph("Revenue Report", titleFont))
            pdfDoc.Add(New Paragraph("Generated on: " & DateTime.Now.ToString(), normalFont))
            pdfDoc.Add(New Paragraph(Environment.NewLine))

            ' Table
            Dim pdfTable As New PdfPTable(dgvRevenueRecords.ColumnCount)
            pdfTable.WidthPercentage = 100

            ' Header
            For Each column As DataGridViewColumn In dgvRevenueRecords.Columns
                Dim cell As New PdfPCell(New Phrase(column.HeaderText, normalFont))
                cell.BackgroundColor = New iTextSharp.text.Color(211, 211, 211) ' Light gray RGB
                pdfTable.AddCell(cell)
            Next

            ' Rows
            For Each row As DataGridViewRow In dgvRevenueRecords.Rows
                If Not row.IsNewRow Then
                    For Each cell As DataGridViewCell In row.Cells
                        pdfTable.AddCell(New Phrase(If(cell.Value IsNot Nothing, cell.Value.ToString(), ""), normalFont))
                    Next
                End If
            Next

            pdfDoc.Add(pdfTable)
            pdfDoc.Close()

            MessageBox.Show("PDF file exported successfully to:" & vbCrLf & fullPath, "Export Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Catch ex As Exception
            MessageBox.Show("Error exporting to PDF: " & ex.Message, "Export Failed", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    ' PAYOUT SIMULATION
    Private Sub btnPayoutSelectedRevenue_Click(sender As Object, e As EventArgs) Handles btnPayoutSelectedRevenue.Click
        If dgvRevenueRecords.SelectedRows.Count = 0 Then
            MessageBox.Show("Please select a record to payout.")
            Return
        End If

        Dim selectedRow As DataGridViewRow = dgvRevenueRecords.SelectedRows(0)
        If selectedRow.Cells("Status").Value.ToString() <> "Pending" Then
            MessageBox.Show("Only pending transactions can be paid.")
            Return
        End If

        Dim transactionID As String = selectedRow.Cells("TransactionID").Value.ToString()
        Dim userName As String = selectedRow.Cells("SourceName").Value.ToString()
        Dim amount As Decimal = Convert.ToDecimal(selectedRow.Cells("Net (RM)").Value)

        Dim payoutForm As New frmPayoutConfirmation(transactionID, userName, amount)
        If payoutForm.ShowDialog() = DialogResult.OK Then
            Using conn As New OleDbConnection(connectionString)
                conn.Open()
                Dim updateCmd As New OleDbCommand("UPDATE RevenueRecords SET [Status] = ? WHERE [TransactionID] = ?", conn)
                updateCmd.Parameters.AddWithValue("?", "Completed")
                updateCmd.Parameters.AddWithValue("?", transactionID)
                updateCmd.ExecuteNonQuery()
            End Using
            LoadRevenueData()
            MessageBox.Show("Payout completed successfully.")
        End If
    End Sub
End Class
