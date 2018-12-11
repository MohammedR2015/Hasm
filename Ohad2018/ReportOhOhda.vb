Imports System.Data.OleDb
Imports CrystalDecisions.CrystalReports.Engine
Public Class ReportOhOhda
    Dim x, y As Integer
    Dim NewPoint As New System.Drawing.Point

    'Private Sub Panel1_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Panel1.MouseDown
    '    x = Control.MousePosition.X - Me.Location.X
    '    y = Control.MousePosition.Y - Me.Location.Y

    'End Sub

    'Private Sub Panel1_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Panel1.MouseMove
    '    If e.Button = Windows.Forms.MouseButtons.Left Then
    '        NewPoint = Control.MousePosition
    '        NewPoint.X -= (x)
    '        NewPoint.Y -= (y)
    '        Me.Location = NewPoint

    '    End If
    'End Sub
    Public dm As New OleDbDataAdapter
    Dim dbconnect As New OleDbConnection()
    Dim dbcommand As New OleDbCommand()
    Dim dss As DataSet = New DataSet()
    Dim cryRpt As New ReportDocument
    Public dpt As New OleDbDataAdapter
    Dim MAL As New DataSet
    Public ds As New DataSet
    Dim cls As New GeneralCodes
    Public dsCOM As New DataSet
    Public CustodyTables As String = " select * from Custody where Steat=false"

    Private Sub Connect_Table_Master()
        cls.conn.Open()
        dsCOM.Clear()
        cls.Adapter = New OleDbDataAdapter(CustodyTables, cls.conn)
        cls.Adapter.Fill(dsCOM, "Custody")
        ComIDcustody.DataSource = dsCOM.Tables("Custody")
        ComIDcustody.DisplayMember = "IDCustody"
        ComCustodyName.DataSource = dsCOM.Tables("Custody")
        ComCustodyName.DisplayMember = "NameCustody"

        cls.conn.Close()
    End Sub

    Private Sub ReportOhOhda_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Connect_Table_Master()
        Me.CenterToScreen()
    End Sub

    Private Sub ButAround_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButAround.Click

        If R1.Checked = True Then
            Try
                dss.Clear()
                VIEW_REPORT.CrystalReportViewer1.Show()
                VIEW_REPORT.CrystalReportViewer1.BringToFront()
                dbconnect.ConnectionString = "Provider=microsoft.ACE.OLEDB.12.0; DATA SOURCE=D:\HikmaP\OhdaDatabase\Hikma.ACCDB;JET OLEDB:Database PASSWORD=123abcking-"
                dbcommand.Connection = dbconnect
                dbconnect.Open()
                dbcommand.CommandText = "select * from Custodyking where IDCustody=" & ComIDcustody.Text & " order by DateOfCustody"
                Dim Adapter As OleDbDataAdapter = New OleDbDataAdapter(dbcommand.CommandText, dbconnect)
                Adapter.Fill(dss, "Custodyking")
                cryRpt.Load("D:\HikmaP\OhdaDatabase\OhdaRe.rpt")
                cryRpt.SetDataSource(dss)
                cryRpt.SetDatabaseLogon("Hikma", "123abcking-")
                VIEW_REPORT.CrystalReportViewer1.ReportSource = cryRpt
                VIEW_REPORT.CrystalReportViewer1.Refresh()
                dbcommand.ExecuteNonQuery()
                'VIEW_REPORT.MdiParent = PontStart
                VIEW_REPORT.Show()
                dbconnect.Close()
                Beep()
            Catch ex As Exception
                MsgBox(ex.Message, MsgBoxStyle.Critical + MessageBoxOptions.RightAlign, "EVENT ERROR")
                If dbconnect.State = ConnectionState.Open Then dbcommand.Clone()

            End Try
        ElseIf R2.Checked = True Then
            Try
                dss.Clear()
                VIEW_REPORT.CrystalReportViewer1.Show()
                VIEW_REPORT.CrystalReportViewer1.BringToFront()
                dbconnect.ConnectionString = "Provider=microsoft.ACE.OLEDB.12.0; DATA SOURCE=D:\HikmaP\OhdaDatabase\Hikma.ACCDB;JET OLEDB:Database PASSWORD=123abcking-"
                dbcommand.Connection = dbconnect
                dbconnect.Open()
                dbcommand.CommandText = "select * from Custodyking where IDCustody=" & ComIDcustody.Text & "and IDRecord Between " & TexNumber1.Text & " and " & TexNumber2.Text & ""
                Dim Adapter As OleDbDataAdapter = New OleDbDataAdapter(dbcommand.CommandText, dbconnect)
                Adapter.Fill(dss, "Custodyking")
                cryRpt.Load("D:\HikmaP\OhdaDatabase\OhdaRe.rpt")
                cryRpt.SetDataSource(dss)
                cryRpt.SetDatabaseLogon("Hikma", "123abcking-")
                VIEW_REPORT.CrystalReportViewer1.ReportSource = cryRpt
                VIEW_REPORT.CrystalReportViewer1.Refresh()
                dbcommand.ExecuteNonQuery()
                'VIEW_REPORT.MdiParent = PontStart
                VIEW_REPORT.Show()
                dbconnect.Close()
                Beep()
            Catch ex As Exception
                MsgBox(ex.Message, MsgBoxStyle.Critical + MessageBoxOptions.RightAlign, "EVENT ERROR")
                If dbconnect.State = ConnectionState.Open Then dbcommand.Clone()

            End Try
        Else
            MsgBox("أخـــــــــــــتر نوع التقرير المراد طباعته", MsgBoxStyle.Critical, "تــــحذيــــر ")
        End If

    End Sub

    'Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
    '    Try
    '        dss.Clear()
    '        VIEW_REPORT.CrystalReportViewer1.Show()
    '        VIEW_REPORT.CrystalReportViewer1.BringToFront()
    '        dbconnect.ConnectionString = "Provider=microsoft.ACE.OLEDB.12.0; DATA SOURCE=D:\HikmaP\OhdaDatabase\Hikma.ACCDB;JET OLEDB:Database PASSWORD=123abcking-"
    '        dbcommand.Connection = dbconnect
    '        dbconnect.Open()
    '        dbcommand.CommandText = "select * from Custodyking "
    '        Dim Adapter As OleDbDataAdapter = New OleDbDataAdapter(dbcommand.CommandText, dbconnect)
    '        Adapter.Fill(dss, "Custodyking")
    '        cryRpt.Load("D:\HikmaP\OhdaDatabase\OhdaRe1.rpt")
    '        cryRpt.SetDataSource(dss)
    '        cryRpt.SetDatabaseLogon("Hikma", "123abcking-")
    '        VIEW_REPORT.CrystalReportViewer1.ReportSource = cryRpt
    '        VIEW_REPORT.CrystalReportViewer1.Refresh()
    '        dbcommand.ExecuteNonQuery()
    '        'VIEW_REPORT.MdiParent = PontStart
    '        VIEW_REPORT.Show()
    '        dbconnect.Close()
    '        Beep()
    '    Catch ex As Exception
    '        MsgBox(ex.Message, MsgBoxStyle.Critical + MessageBoxOptions.RightAlign, "EVENT ERROR")
    '        If dbconnect.State = ConnectionState.Open Then dbcommand.Clone()

    '    End Try
    'End Sub

    Private Sub ButExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButExit.Click
        Me.Close()
    End Sub

    Private Sub ButMinimized_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButMinimized.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub
End Class