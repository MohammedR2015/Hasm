Imports System.Data.OleDb
Public Class OhdaMoney
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
    Dim ds As New DataSet
    Dim cls As New GeneralCodes
   
    Private Sub RefreshData()
        ds.Clear()
        cls.conn.Open()
        cls.Adapter = New OleDbDataAdapter(cls.CustodyTable, cls.conn)
        cls.Adapter.Fill(ds, "Custody")
        TexECode.DataBindings.Clear()
        TexECode.DataBindings.Add("text", ds, "Custody.IDCustody")
        TexManeyCustody.DataBindings.Clear()
        TexManeyCustody.DataBindings.Add("text", ds, "Custody.ManeyCustody")
        TexCustody.DataBindings.Clear()
        TexCustody.DataBindings.Add("text", ds, "Custody.NameCustody")
        DateOfReceipt.DataBindings.Clear()
        DateOfReceipt.DataBindings.Add("text", ds, "Custody.DateCustody")
        TexEmployee.DataBindings.Clear()
        TexEmployee.DataBindings.Add("text", ds, "Custody.NameEmployees")
        TexNotice.DataBindings.Clear()
        TexNotice.DataBindings.Add("text", ds, "Custody.NoticeCustody")
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
            .Columns(4).HeaderText = "اسم الموظف"
            .Columns(5).HeaderText = "الحالة"
            .Columns(5).Width = 40
            .Columns(6).HeaderText = "ملاحظات"
            .Columns(6).Width = 200
            '.RowsDefaultCellStyle.BackColor = Color.MistyRose
            '.AlternatingRowsDefaultCellStyle.BackColor = Color.SlateGray
            .ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single
            .AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells)
        End With
        cls.conn.Close()
    End Sub

    Private Sub ButNew_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButNew.Click
        TexECode.Text = Nothing
        TexManeyCustody.Text = Nothing
        TexManeyCustody.DataBindings.Clear()
        TexCustody.Text = Nothing
        TexEmployee.Text = Nothing
        TexNotice.Text = Nothing
        TexManeyCustody.Focus()
    End Sub
    'Dim x As String = TF.Checked
    Private Sub ButSave_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButSave.Click
        If TexManeyCustody.Text = Nothing Or TexCustody.Text = Nothing Then
            MsgBox("هناك بيانات ناقصة ")
        Else
            Try
                cls.TypeOfProsses = " الحــــفظ"
                cls.SaveCode = "insert into Custody(ManeyCustody,NameCustody,DateCustody,NameEmployees,NoticeCustody)values('" & TexManeyCustody.Text & "','" & TexCustody.Text & "','" & DateOfReceipt.Text & "','" & TexEmployee.Text & "','" & TexNotice.Text & " ')"
                cls.SaverDB()
                RefreshData()
            Catch ex As Exception
                MessageBox.Show(ex.Message)
            End Try
        End If

    End Sub
    Private Sub ButUpDate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButUpDate.Click
        Try
            cls.TypeOfProsses = "التـــعديل"
            cls.SaveCode = "update Custody set ManeyCustody='" & TexManeyCustody.Text & "',NameCustody='" & TexCustody.Text & "',DateCustody='" & DateOfReceipt.Text & "',NameEmployees='" & TexEmployee.Text & "',NoticeCustody='" & TexNotice.Text & "' where IDCustody=" & TexECode.Text & ""
            cls.SaverDB()
            TexManeyCustody.DataBindings.Clear()
            RefreshData()

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub
    Private Sub ButDelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButDelete.Click
        Try
            cls.TypeOfProsses = "الحـــــذف"
            cls.SaveCode = "delete from Custody where IDCustody=" & TexECode.Text & ""
            cls.SaverDB()
            TexManeyCustody.DataBindings.Clear()
            RefreshData()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub
    Private Sub ButExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButExit.Click
        Me.Close()
    End Sub

    Private Sub ButAround_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButAround.Click
        RefreshData()
    End Sub

    Private Sub OhdaMoney_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.CenterToScreen()
        RefreshData()

    End Sub

    Private Sub ButMinimized_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButMinimized.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub

   

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Try
            cls.TypeOfProsses = "التـــعديل"
            cls.SaveCode = "update Custody set Steat=True where IDCustody=" & TexECode.Text & ""
            cls.SaverDB()
            TexManeyCustody.DataBindings.Clear()
            RefreshData()

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        Try
            cls.TypeOfProsses = "التـــعديل"
            cls.SaveCode = "update Custody set Steat=False where IDCustody=" & TexECode.Text & ""
            cls.SaverDB()
            TexManeyCustody.DataBindings.Clear()
            RefreshData()

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub
End Class