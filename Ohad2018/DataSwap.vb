Imports System.Data.OleDb
Public Class DataSwap
    Dim x, y As Integer
    Dim NewPoint As New System.Drawing.Point

    'Private Sub Panel1_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Panel1.MouseDown
    '    x = Control.MousePosition.X - Me.Location.X
    '    y = Control.MousePosition.Y - Me.Location.Y

    'End Sub
    'Public sEditType As String = String.Empty
    'Private Sub Panel1_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Panel1.MouseMove
    '    If e.Button = Windows.Forms.MouseButtons.Left Then
    '        NewPoint = Control.MousePosition
    '        NewPoint.X -= (x)
    '        NewPoint.Y -= (y)
    '        Me.Location = NewPoint

    '    End If
    'End Sub
    Dim ds As New DataSet
    Dim cls As New GeneralCodes
    Public CustodyTables As String = " select * from Custody where Steat=false"
    Private Sub RefreshData()
        ds.Clear()
        cls.conn.Open()
        cls.Adapter = New OleDbDataAdapter(CustodyTables, cls.conn)
        cls.Adapter.Fill(ds, "Custody")
        TexECode.DataBindings.Clear()
        TexECode.DataBindings.Add("text", ds, "Custody.IDCustody")
       
        Me.DataGridView.DataSource = ds
        Me.DataGridView.DataMember = "Custody"
        With DataGridView
            .Columns(0).HeaderText = "رقم العهد"
            .Columns(0).Visible = False
            .Columns(1).HeaderText = "مبلغ العهدة"
            .Columns(1).Width = 70

            .Columns(2).HeaderText = "اسم العهدة"
            .Columns(2).Width = 200
            .Columns(3).HeaderText = "تاريخ الإستلام"
            .Columns(3).Visible = False
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

   
    Private Sub ButExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButExit.Click
        Me.Close()
    End Sub

    Private Sub ButAround_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        RefreshData()
    End Sub

    

    Private Sub ButMinimized_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButMinimized.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub



   

    
    Private Sub DataSwap_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.CenterToScreen()
        RefreshData()
    End Sub

    Private Sub DataGridView_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView.CellContentClick

    End Sub

    Private Sub DataGridView_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles DataGridView.DoubleClick
        Try
            If cls.conn.State = ConnectionState.Open Then cls.conn.Close()
            cls.TypeOfProsses = "التـــعديل"
            cls.SaveCode = "update Details set IDcustody='" & TexECode.Text & "' where IDRecord=" & T1.Text & ""
            cls.SaverDB()
            Me.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub
End Class