<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Mo
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Mo))
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip
        Me.FilesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.OpenWin = New System.Windows.Forms.ToolStripMenuItem
        Me.تصغيرالنافذةToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.الصرفياتالقرطاسيةToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.الخــروجToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.BackColor = System.Drawing.Color.SkyBlue
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FilesToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(1408, 24)
        Me.MenuStrip1.TabIndex = 1
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'FilesToolStripMenuItem
        '
        Me.FilesToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.OpenWin, Me.تصغيرالنافذةToolStripMenuItem, Me.الصرفياتالقرطاسيةToolStripMenuItem, Me.الخــروجToolStripMenuItem})
        Me.FilesToolStripMenuItem.Name = "FilesToolStripMenuItem"
        Me.FilesToolStripMenuItem.Size = New System.Drawing.Size(42, 20)
        Me.FilesToolStripMenuItem.Text = "Files"
        '
        'OpenWin
        '
        Me.OpenWin.Image = CType(resources.GetObject("OpenWin.Image"), System.Drawing.Image)
        Me.OpenWin.Name = "OpenWin"
        Me.OpenWin.Size = New System.Drawing.Size(206, 22)
        Me.OpenWin.Text = "دخول إلى برنامج العهد"
        '
        'تصغيرالنافذةToolStripMenuItem
        '
        Me.تصغيرالنافذةToolStripMenuItem.Image = CType(resources.GetObject("تصغيرالنافذةToolStripMenuItem.Image"), System.Drawing.Image)
        Me.تصغيرالنافذةToolStripMenuItem.Name = "تصغيرالنافذةToolStripMenuItem"
        Me.تصغيرالنافذةToolStripMenuItem.Size = New System.Drawing.Size(206, 22)
        Me.تصغيرالنافذةToolStripMenuItem.Text = "تصغير النافذة "
        '
        'الصرفياتالقرطاسيةToolStripMenuItem
        '
        Me.الصرفياتالقرطاسيةToolStripMenuItem.Image = CType(resources.GetObject("الصرفياتالقرطاسيةToolStripMenuItem.Image"), System.Drawing.Image)
        Me.الصرفياتالقرطاسيةToolStripMenuItem.Name = "الصرفياتالقرطاسيةToolStripMenuItem"
        Me.الصرفياتالقرطاسيةToolStripMenuItem.Size = New System.Drawing.Size(206, 22)
        Me.الصرفياتالقرطاسيةToolStripMenuItem.Text = "دخول إلى صرفيات القرطاسية"
        '
        'الخــروجToolStripMenuItem
        '
        Me.الخــروجToolStripMenuItem.Image = CType(resources.GetObject("الخــروجToolStripMenuItem.Image"), System.Drawing.Image)
        Me.الخــروجToolStripMenuItem.Name = "الخــروجToolStripMenuItem"
        Me.الخــروجToolStripMenuItem.Size = New System.Drawing.Size(206, 22)
        Me.الخــروجToolStripMenuItem.Text = "الخــروج"
        '
        'Mo
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.BlanchedAlmond
        Me.ClientSize = New System.Drawing.Size(1408, 719)
        Me.ControlBox = False
        Me.Controls.Add(Me.MenuStrip1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.IsMdiContainer = True
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "Mo"
        Me.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.Text = "1"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents FilesToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents OpenWin As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents الخــروجToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents تصغيرالنافذةToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents الصرفياتالقرطاسيةToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
End Class
