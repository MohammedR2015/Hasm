Imports System.Data.OleDb
Public Class InforamtionAboutOhad
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
    Dim cls As New GeneralCodes

    Private Sub sel1()
        Dim ds As New DataSet
        ds.Clear()
        Dim CustodyDetails As String = "select * from Details where IDcustody=" & T1.Text & "" '" select * from Details where IDRecord=" & ComIDcustody.Text & ""
        Try
            ds.Clear()
            cls.conn.Open()
            cls.Adapter = New OleDbDataAdapter(CustodyDetails, cls.conn)
            cls.Adapter.Fill(ds, "Details")
            Me.DataGridView1.DataSource = ds
            Me.DataGridView1.DataMember = "Details"
            With DataGridView1
                .Columns(0).HeaderText = "رقم السجل"
                .Columns(0).Visible = False
                .Columns(0).Width = 30
                .Columns(1).HeaderText = "رقم العهدة"
                .Columns(1).Visible = False
                .Columns(1).Width = 30
                .Columns(2).HeaderText = "المبلغ المصروف"
                .Columns(2).Width = 70
                .Columns(3).HeaderText = "بيانات الصرفيات"
                .Columns(3).Width = 280
                .Columns(4).HeaderText = "نوع الإثبات"
                .Columns(5).HeaderText = "التاريخ"
                .Columns(6).HeaderText = "ملاحظات"
                .ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single
                .AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells)
            End With
            cls.conn.Close()
        Catch ex As Exception
            'MessageBox.Show(ex.Message)
            cls.conn.Close()
        End Try
    End Sub
    Private Sub RefreshData()
        Dim ds As New DataSet
        ds.Clear()
        cls.conn.Open()
        cls.Adapter = New OleDbDataAdapter(cls.CustodyTable, cls.conn)
        cls.Adapter.Fill(ds, "Custody")
        T1.DataBindings.Clear()
        T1.DataBindings.Add("text", ds, "Custody.IDCustody")
        Me.DataGridView.DataSource = ds
        Me.DataGridView.DataMember = "Custody"
        With DataGridView
            .Columns(0).HeaderText = "رقم العهد"
            '.Columns(0).Visible = False
            .Columns(1).HeaderText = "مبلغ العهدة"
            .Columns(1).Width = 70
            .Columns(2).HeaderText = "اسم العهدة"
            .Columns(2).Width = 200
            .Columns(3).HeaderText = "تاريخ الإستلام"
            '.Columns(3).Visible = False
            .Columns(4).HeaderText = "اسم الموظف"
            .Columns(4).Visible = False
            .Columns(5).HeaderText = "الحالة"
            .Columns(5).Visible = False
            .Columns(5).Width = 40
            .Columns(6).HeaderText = "ملاحظات"
            .Columns(6).Visible = False
            .Columns(6).Width = 200
            '.RowsDefaultCellStyle.BackColor = Color.MistyRose
            '.AlternatingRowsDefaultCellStyle.BackColor = Color.SlateGray
            .ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single
            .AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells)
        End With
        cls.conn.Close()
    End Sub
    Private Sub tosum()
        Dim ds As New DataSet
        Dim CSum As String = " select sum(MoneyOfCustody) as sumer from Details where IDcustody=" & T1.Text & ""
        Try
            ds.Clear()
            cls.conn.Open()
            cls.Adapter = New OleDbDataAdapter(CSum, cls.conn)
            cls.Adapter.Fill(ds, "Details")
            SumMo.DataBindings.Clear()
            SumMo.DataBindings.Add("text", ds, "Details.Sumer")
            cls.conn.Close()

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub
    Private Sub tosum2()
        Dim ds As New DataSet
        Dim CSum As String = " select sum(MoneyOfCustody) as sumer from Details "
        Try
            ds.Clear()
            cls.conn.Open()
            cls.Adapter = New OleDbDataAdapter(CSum, cls.conn)
            cls.Adapter.Fill(ds, "Details")
            TextBox1.DataBindings.Clear()
            TextBox1.DataBindings.Add("text", ds, "Details.Sumer")
            cls.conn.Close()

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub
    Private Sub tosum3()
        Dim ds As New DataSet
        Dim CSum As String = " select sum(ManeyCustody) as sumer from custody "
        Try
            ds.Clear()
            cls.conn.Open()
            cls.Adapter = New OleDbDataAdapter(CSum, cls.conn)
            cls.Adapter.Fill(ds, "custody")
            TextBox3.DataBindings.Clear()
            TextBox3.DataBindings.Add("text", ds, "custody.Sumer")
            cls.conn.Close()

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub
    Private Sub InforamtionAboutOhad_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        RefreshData()
        Me.CenterToScreen()
    End Sub

    Private Sub T1_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles T1.TextChanged
        sel1()
        tosum()
        tosum2()
        tosum3()
    End Sub

    Private Sub Panel1_Paint(ByVal sender As System.Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles Panel1.Paint

    End Sub

    Private Sub ButExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButExit.Click
        Me.Close()
    End Sub

    Private Sub ButMinimized_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButMinimized.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub
End Class