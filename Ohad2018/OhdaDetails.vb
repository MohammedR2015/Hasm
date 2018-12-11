Imports System.Data.OleDb
Public Class OhdaDetails
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
        ComDate.DataSource = dsCOM.Tables("Custody")
        ComDate.DisplayMember = "DateCustody"
        ComNameCustody.DataSource = dsCOM.Tables("Custody")
        ComNameCustody.DisplayMember = "ManeyCustody"
        cls.conn.Close()
    End Sub

    Private Sub OhdaDetails_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            Connect_Table_Master()
            Me.CenterToScreen()
            ds.Clear()
            cls.conn.Open()

            cls.Adapter = New OleDbDataAdapter(cls.CustodyDetails, cls.conn) 'cls.
            cls.Adapter.Fill(ds, "Details")
            'Label9.DataBindings.Add("text", ds, "Details.IDcustody")
            TexIDRecord.DataBindings.Add("text", ds, "Details.IDRecord")
            TexMoneyOfCustody.DataBindings.Add("text", ds, "Details.MoneyOfCustody")
            TexDataOfCustody.DataBindings.Add("text", ds, "Details.DataOfCustody")
            ComTypeOfCusdoty.DataBindings.Add("text", ds, "Details.TypeOfCusdoty")
            DateOfCustody.DataBindings.Add("text", ds, "Details.DateOfCustody")
            TexNoticeCustody.DataBindings.Add("text", ds, "Details.NoticeCustody")
            Me.DataGridView1.DataSource = ds
            Me.DataGridView1.DataMember = "Details"
            With DataGridView1
                .Columns(0).HeaderText = "رقم السجل"
                .Columns(0).Width = 30
                .Columns(1).HeaderText = "رقم العهدة"
                .Columns(1).Width = 30
                .Columns(2).HeaderText = "المبلغ المصروف"
                .Columns(2).Width = 70
                .Columns(3).HeaderText = "بيانات الصرفيات"
                .Columns(3).Width = 280
                .Columns(4).HeaderText = "نوع الإثبات"
                .Columns(5).HeaderText = "التاريخ"
                .Columns(6).HeaderText = "ملاحظات"
                '.RowsDefaultCellStyle.BackColor = Color.Snow
                '.AlternatingRowsDefaultCellStyle.BackColor = Color.SlateGray
                .ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single
                .AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells)
            End With
            cls.conn.Close()

        Catch ex As Exception
            MessageBox.Show(ex.Message)
            cls.conn.Close()
        End Try

    End Sub

    Private Sub RefrishData()
        Try

            ds.Clear()
            cls.conn.Open()
            cls.Adapter = New OleDbDataAdapter(cls.CustodyDetails, cls.conn)
            cls.Adapter.Fill(ds, "Details")
            TexMoneyOfCustody.DataBindings.Clear()
            TexMoneyOfCustody.DataBindings.Add("text", ds, "Details.MoneyOfCustody")
            Me.DataGridView1.DataSource = ds
            Me.DataGridView1.DataMember = "Details"
            With DataGridView1
                .Columns(0).HeaderText = "رقم السجل"
                .Columns(0).Width = 30
                .Columns(1).HeaderText = "رقم العهدة"
                .Columns(1).Width = 30
                .Columns(2).HeaderText = "المبلغ المصروف"
                .Columns(2).Width = 70
                .Columns(3).HeaderText = "بيانات الصرفيات"
                .Columns(3).Width = 280
                .Columns(4).HeaderText = "نوع الإثبات"
                .Columns(5).HeaderText = "التاريخ"
                .Columns(6).HeaderText = "ملاحظات"
                '.RowsDefaultCellStyle.BackColor = Color.Snow
                '.AlternatingRowsDefaultCellStyle.BackColor = Color.SlateGray
                .ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single
                .AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells)
            End With
            cls.conn.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
            cls.conn.Close()

        End Try

    End Sub

    Private Sub ButNew_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButNew.Click
        'GBox.Visible = True
        TexMoneyOfCustody.DataBindings.Clear()
        TexMoneyOfCustody.Text = Nothing
        TexDataOfCustody.Text = Nothing
        TexNoticeCustody.Text = Nothing
        TexMoneyOfCustody.Focus()
    End Sub

    Private Sub ButSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButSave.Click
        Try
            If cls.conn.State = ConnectionState.Open Then cls.conn.Close()
            cls.TypeOfProsses = " الحــــفظ"
            cls.SaveCode = "insert into Details(IDcustody,MoneyOfCustody,DataOfCustody,TypeOfCusdoty,DateOfCustody,NoticeCustody)values('" & ComIDcustody.Text & "','" & TexMoneyOfCustody.Text & "','" & TexDataOfCustody.Text & "','" & ComTypeOfCusdoty.Text & "','" & DateOfCustody.Text & "','" & TexNoticeCustody.Text & " ')"
            cls.SaverDB()
            RefrishData()
            'GBox.Visible = False
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try

    End Sub

    Private Sub ButUpDate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButUpDate.Click
        Try
            If cls.conn.State = ConnectionState.Open Then cls.conn.Close()
            cls.TypeOfProsses = "التـــعديل"
            cls.SaveCode = "update Details set MoneyOfCustody='" & TexMoneyOfCustody.Text & "',DataOfCustody='" & TexDataOfCustody.Text & "',TypeOfCusdoty='" & ComTypeOfCusdoty.Text & "',DateOfCustody='" & DateOfCustody.Text & "',NoticeCustody='" & TexNoticeCustody.Text & "' where IDRecord=" & TexIDRecord.Text & ""
            cls.SaverDB()
            TexMoneyOfCustody.DataBindings.Clear()
            RefrishData()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub ButDelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButDelete.Click
        Try
            If cls.conn.State = ConnectionState.Open Then cls.conn.Close()
            cls.TypeOfProsses = "الحـــــذف"
            cls.SaveCode = "delete from Details where IDRecord=" & TexIDRecord.Text & ""
            cls.SaverDB()
            TexMoneyOfCustody.DataBindings.Clear()
            RefrishData()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub ButExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButExit.Click
        Me.Close()
    End Sub

    Private Sub ButAround_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButAround.Click

        RefrishData()
        'GBox.Visible = False

    End Sub

    Private Sub RefreshDataToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RefreshDataToolStripMenuItem.Click
        Connect_Table_Master()
        RefrishData()
    End Sub

    Private Sub ButMinimized_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButMinimized.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub

    Private Sub Panel1_Paint(ByVal sender As System.Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles Panel1.Paint

    End Sub
    Sub cearch(ByVal eles As String)
        ds.Clear()
        cls.conn.Open()
        cls.Adapter = New OleDbDataAdapter(eles, cls.conn)
        cls.Adapter.Fill(ds, "Details")
        cls.conn.Close()
    End Sub

    Private Sub ComCustodyName_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComCustodyName.SelectedIndexChanged
        'RefrishData()
    End Sub

    Private Sub TextBox1_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox1.TextChanged
        Try
            cearch("select *from Details where DataOfCustody like '%" & TextBox1.Text & "%'")
        Catch ex As Exception
            MessageBox.Show("لقد حدث خطاء أثناء عملية البحث ", "تحذير ", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign, "mspaint.chm")
        End Try
    End Sub
End Class