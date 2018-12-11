Public Class Mo

    Private Sub OpenWin_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OpenWin.Click
        PoentMaster.MdiParent = Me
        PoentMaster.Show()
    End Sub

    Private Sub Mo_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub الخــروجToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles الخــروجToolStripMenuItem.Click
        End
    End Sub

    Private Sub تصغيرالنافذةToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles تصغيرالنافذةToolStripMenuItem.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub
End Class