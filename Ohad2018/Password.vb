Public Class Password
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
    Private Sub Password_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.CenterToScreen()
    End Sub

   
    Private Sub OpenP_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OpenP.Click
        If Pss.Text = " " Then
            Me.Hide()
            Mo.Show()
        Else
            MsgBox("هناك خطاء في كلمة السر ", MsgBoxStyle.Critical, "تحذير")
        End If
    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        Close()
    End Sub
End Class