Public Class PoentMaster

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

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub Form1_Load_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        Me.CenterToScreen()
    End Sub

    Private Sub ButExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        End
    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        If OhdaMoney.CanFocus = True Then
            OhdaMoney.Focus()
            If OhdaMoney.WindowState = FormWindowState.Minimized Then
                OhdaMoney.WindowState = FormWindowState.Normal
            End If
        Else
            OhdaMoney.MdiParent = Mo
            OhdaMoney.Show()
            'OhdaMoney.Show()
        End If
    End Sub

    Private Sub Button18_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button18.Click
        If OhdaDetails.CanFocus = True Then
            OhdaDetails.Focus()
            If OhdaDetails.WindowState = FormWindowState.Minimized Then
                OhdaDetails.WindowState = FormWindowState.Normal
            End If
        Else
            'OhdaDetails.Show()
            OhdaDetails.MdiParent = Mo
            OhdaDetails.Show()
        End If


       
    End Sub

    Private Sub Button9_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        'End
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        'If Machen.CanFocus = True Then
        '    Machen.Focus()
        '    If Machen.WindowState = FormWindowState.Minimized Then
        '        Machen.WindowState = FormWindowState.Normal
        '    End If
        'Else
        '    Machen.MdiParent = Mo
        '    Machen.Show()

        'End If
    End Sub

    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click
        'If Order_panzen.CanFocus = True Then
        '    Order_panzen.Focus()
        '    If Order_panzen.WindowState = FormWindowState.Minimized Then
        '        Order_panzen.WindowState = FormWindowState.Normal
        '    End If
        'Else

        '    Order_panzen.MdiParent = Mo
        '    Order_panzen.Show()
        'End If
    End Sub

    Private Sub Button10_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button10.Click
        '
        If ReportOhOhda.CanFocus = True Then
            ReportOhOhda.Focus()
            If ReportOhOhda.WindowState = FormWindowState.Minimized Then
                ReportOhOhda.WindowState = FormWindowState.Normal
            End If
        Else
            ReportOhOhda.MdiParent = Mo
            ReportOhOhda.Show()

        End If
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click

        If SwapOhda.CanFocus = True Then
            SwapOhda.Focus()
            If SwapOhda.WindowState = FormWindowState.Minimized Then
                SwapOhda.WindowState = FormWindowState.Normal
            End If
        Else
            SwapOhda.MdiParent = Mo
            SwapOhda.Show()

        End If
    End Sub

    Private Sub Panel1_Paint(ByVal sender As System.Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles Panel1.Paint

    End Sub

    'Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
    '    If MessagMan.CanFocus = True Then
    '        MessagMan.Focus()
    '        If MessagMan.WindowState = FormWindowState.Minimized Then
    '            MessagMan.WindowState = FormWindowState.Normal
    '        End If
    '    Else
    '        MessagMan.MdiParent = Mo
    '        MessagMan.Show()
    '    End If
    'End Sub

    

    Private Sub Button6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button6.Click
        If InforamtionAboutOhad.CanFocus = True Then
            InforamtionAboutOhad.Focus()
            If InforamtionAboutOhad.WindowState = FormWindowState.Minimized Then
                InforamtionAboutOhad.WindowState = FormWindowState.Normal
            End If
        Else
            InforamtionAboutOhad.MdiParent = Mo
            InforamtionAboutOhad.Show()

        End If
    End Sub
End Class
