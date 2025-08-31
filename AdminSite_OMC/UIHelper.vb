Imports System.Drawing.Drawing2D

Module UIHelper
    Public Sub ApplyRoundedRegion(panel As Panel, Optional radius As Integer = 30)
        If panel.Width <= 0 Or panel.Height <= 0 Then Exit Sub

        Dim path As New GraphicsPath()
        path.StartFigure()
        path.AddArc(0, 0, radius, radius, 180, 90)
        path.AddArc(panel.Width - radius, 0, radius, radius, 270, 90)
        path.AddArc(panel.Width - radius, panel.Height - radius, radius, radius, 0, 90)
        path.AddArc(0, panel.Height - radius, radius, radius, 90, 90)
        path.CloseFigure()

        panel.Region = New Region(path)
    End Sub

    Public Sub ApplyRoundedRegionToAll(container As Control, Optional radius As Integer = 30)
        For Each ctrl As Control In container.Controls
            If TypeOf ctrl Is Panel Then
                ApplyRoundedRegion(CType(ctrl, Panel), radius)
            End If
        Next
    End Sub

End Module
