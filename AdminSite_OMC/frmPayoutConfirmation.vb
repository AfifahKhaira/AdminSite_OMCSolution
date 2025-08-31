' Imports and Constructor
Imports System.Windows.Forms

Public Class frmPayoutConfirmation
    Private transactionID As String
    Private userName As String
    Private amount As Decimal

    Public Sub New(transID As String, uName As String, amt As Decimal)
        InitializeComponent()
        transactionID = transID
        userName = uName
        amount = amt
    End Sub

    Private Sub frmPayoutConfirmation_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lblTransactionID.Text = transactionID
        lblUserName.Text = userName
        lblAmount.Text = "RM " & amount.ToString("F2")
    End Sub

    Private Sub btnConfirm_Click(sender As Object, e As EventArgs) Handles btnConfirm.Click
        Me.DialogResult = DialogResult.OK
        Me.Close()
    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Me.DialogResult = DialogResult.Cancel
        Me.Close()
    End Sub
End Class
