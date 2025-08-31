Imports System.Data.OleDb

Module DatabaseModule
    Public ReadOnly connectionString As String = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\afifa\source\repos\AdminSite_OMCSolution\LingoSign.accdb"
    Public connection As New OleDbConnection(connectionString)
End Module

