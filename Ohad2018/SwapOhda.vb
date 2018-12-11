Imports System.Data.OleDb
Imports System.IO
Public Class SwapOhda
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

    Public CustodyTables As String = " select * from Custody where Steat=false"
    
    Dim dsCOM1 As New DataSet
    Private Sub Connect_Table_Master1()
        cls.conn.Open()
        dsCOM1.Clear()
        cls.Adapter = New OleDbDataAdapter(CustodyTables, cls.conn)
        cls.Adapter.Fill(dsCOM1, "Custody")
        ComIDcustody1.DataSource = dsCOM1.Tables("Custody")
        ComIDcustody1.DisplayMember = "IDCustody"
        ComCustodyName1.DataSource = dsCOM1.Tables("Custody")
        ComCustodyName1.DisplayMember = "NameCustody"
        Mon.DataSource = dsCOM1.Tables("Custody")
        Mon.DisplayMember = "ManeyCustody"
        'ComboBox1
        ComboBox1.DataSource = dsCOM1.Tables("Custody")
        ComboBox1.DisplayMember = "NoticeCustody"
        cls.conn.Close()
    End Sub
    Private Sub SwapOhda_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        Connect_Table_Master1()
        Me.CenterToScreen()
    End Sub

    Private Sub ButExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButExit.Click
        Me.Close()
    End Sub
    


    Private Sub sel1()
        Dim ds As New DataSet
        ds.Clear()
        Dim CustodyDetails As String = "select * from Details where IDcustody=" & ComIDcustody1.Text & "" '" select * from Details where IDRecord=" & ComIDcustody.Text & ""
        Try
            ds.Clear()
            cls.conn.Open()
            cls.Adapter = New OleDbDataAdapter(CustodyDetails, cls.conn)
            cls.Adapter.Fill(ds, "Details")
            T1.DataBindings.Clear()
            T1.DataBindings.Add("text", ds, "Details.IDRecord")
            'T1.DataBindings.Clear()
            'T1.DataBindings.Add("text", ds, "Details.IDRecord")
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
            MessageBox.Show(ex.Message)
        End Try
        
    End Sub
   
    

   

    Private Sub ButNew_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButNew.Click
        sel1()
        Dim ds As New DataSet
        Dim CSum As String = " select sum(MoneyOfCustody) as sumer from Details where IDcustody=" & ComIDcustody1.Text & ""
        Try
            ds.Clear()
            cls.conn.Open()
            cls.Adapter = New OleDbDataAdapter(CSum, cls.conn)
            cls.Adapter.Fill(ds, "Details")
            SumMo.DataBindings.Clear()
            SumMo.DataBindings.Add("text", ds, "Details.Sumer")
           
           
            cls.conn.Close()

            Compe.Text = (Mon.Text) - (SumMo.Text)
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

   



    Private Sub SwapO_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SwapO.Click
        'If T1.Text = Nothing Then
        '    MsgBox("قم بتحديد السجل المراد تحويلة إلى عهدة أخري !", MsgBoxStyle.Critical, "تحذير ")
        'Else
        '    If Me.DataGridView1.RowCount > 0 Then
        '        Dim frm As New DataSwap
        '        frm.sEditType = "Exist"
        '        frm.txtFirstName.Tag = Me.DataGridView1.Item(0, Me.DataGridView1.CurrentRow.Index).Value
        '        frm.ShowDialog()
        '        frm = Nothing
        '    End If



        'End If

    End Sub

   
    Private Sub ButMinimized_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButMinimized.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub

    Private Sub Panel1_Paint(ByVal sender As System.Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles Panel1.Paint

    End Sub

    Private Sub ContextMenuStrip1_Opening(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles ContextMenuStrip1.Opening

    End Sub

    Private Sub DataGridView1_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick

    End Sub
End Class