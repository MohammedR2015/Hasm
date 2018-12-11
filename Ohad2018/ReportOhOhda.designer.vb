<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ReportOhOhda
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ReportOhOhda))
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.ButMinimized = New System.Windows.Forms.Button
        Me.PictureBox1 = New System.Windows.Forms.PictureBox
        Me.ButExit = New System.Windows.Forms.Button
        Me.Label14 = New System.Windows.Forms.Label
        Me.Panel2 = New System.Windows.Forms.Panel
        Me.Label27 = New System.Windows.Forms.Label
        Me.ComCustodyName = New System.Windows.Forms.ComboBox
        Me.R1 = New System.Windows.Forms.RadioButton
        Me.R2 = New System.Windows.Forms.RadioButton
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.TexNumber2 = New System.Windows.Forms.TextBox
        Me.TexNumber1 = New System.Windows.Forms.TextBox
        Me.ButAround = New System.Windows.Forms.Button
        Me.ComIDcustody = New System.Windows.Forms.ComboBox
        Me.TabControl1 = New System.Windows.Forms.TabControl
        Me.TabPage1 = New System.Windows.Forms.TabPage
        Me.TabPage2 = New System.Windows.Forms.TabPage
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.MintCream
        Me.Panel1.Controls.Add(Me.ButMinimized)
        Me.Panel1.Controls.Add(Me.PictureBox1)
        Me.Panel1.Controls.Add(Me.ButExit)
        Me.Panel1.Controls.Add(Me.Label14)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(394, 28)
        Me.Panel1.TabIndex = 323
        '
        'ButMinimized
        '
        Me.ButMinimized.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.ButMinimized.Location = New System.Drawing.Point(338, 3)
        Me.ButMinimized.Name = "ButMinimized"
        Me.ButMinimized.Size = New System.Drawing.Size(24, 21)
        Me.ButMinimized.TabIndex = 319
        Me.ButMinimized.Text = "-"
        Me.ButMinimized.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.ButMinimized.UseVisualStyleBackColor = True
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.MintCream
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(3, 3)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(27, 22)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 316
        Me.PictureBox1.TabStop = False
        '
        'ButExit
        '
        Me.ButExit.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.ButExit.Location = New System.Drawing.Point(365, 3)
        Me.ButExit.Name = "ButExit"
        Me.ButExit.Size = New System.Drawing.Size(24, 21)
        Me.ButExit.TabIndex = 318
        Me.ButExit.Text = "X"
        Me.ButExit.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.ButExit.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.ButExit.UseVisualStyleBackColor = True
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.BackColor = System.Drawing.Color.MintCream
        Me.Label14.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.ForeColor = System.Drawing.Color.Black
        Me.Label14.Location = New System.Drawing.Point(122, 6)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(95, 16)
        Me.Label14.TabIndex = 315
        Me.Label14.Text = "طـــباعة التقارير "
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.MintCream
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel2.Location = New System.Drawing.Point(0, 264)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(394, 28)
        Me.Panel2.TabIndex = 324
        '
        'Label27
        '
        Me.Label27.AutoSize = True
        Me.Label27.Location = New System.Drawing.Point(287, 14)
        Me.Label27.Name = "Label27"
        Me.Label27.Size = New System.Drawing.Size(61, 13)
        Me.Label27.TabIndex = 330
        Me.Label27.Text = "اسم العهدة"
        '
        'ComCustodyName
        '
        Me.ComCustodyName.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComCustodyName.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.ComCustodyName.FormattingEnabled = True
        Me.ComCustodyName.Location = New System.Drawing.Point(67, 9)
        Me.ComCustodyName.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.ComCustodyName.Name = "ComCustodyName"
        Me.ComCustodyName.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.ComCustodyName.Size = New System.Drawing.Size(217, 21)
        Me.ComCustodyName.TabIndex = 329
        '
        'R1
        '
        Me.R1.AutoSize = True
        Me.R1.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.R1.Location = New System.Drawing.Point(242, 41)
        Me.R1.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.R1.Name = "R1"
        Me.R1.Size = New System.Drawing.Size(95, 23)
        Me.R1.TabIndex = 336
        Me.R1.Text = "كل العهدة"
        Me.R1.UseVisualStyleBackColor = True
        '
        'R2
        '
        Me.R2.AutoSize = True
        Me.R2.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.R2.Location = New System.Drawing.Point(238, 74)
        Me.R2.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.R2.Name = "R2"
        Me.R2.Size = New System.Drawing.Size(98, 23)
        Me.R2.TabIndex = 335
        Me.R2.TabStop = True
        Me.R2.Text = "رقم الصرف"
        Me.R2.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(126, 82)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(24, 13)
        Me.Label3.TabIndex = 334
        Me.Label3.Text = "إلى"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(203, 82)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(21, 13)
        Me.Label2.TabIndex = 333
        Me.Label2.Text = "من"
        '
        'TexNumber2
        '
        Me.TexNumber2.Location = New System.Drawing.Point(78, 79)
        Me.TexNumber2.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.TexNumber2.Name = "TexNumber2"
        Me.TexNumber2.Size = New System.Drawing.Size(45, 20)
        Me.TexNumber2.TabIndex = 332
        '
        'TexNumber1
        '
        Me.TexNumber1.Location = New System.Drawing.Point(155, 79)
        Me.TexNumber1.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.TexNumber1.Name = "TexNumber1"
        Me.TexNumber1.Size = New System.Drawing.Size(45, 20)
        Me.TexNumber1.TabIndex = 331
        '
        'ButAround
        '
        Me.ButAround.BackColor = System.Drawing.Color.GhostWhite
        Me.ButAround.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.ButAround.Location = New System.Drawing.Point(13, 134)
        Me.ButAround.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.ButAround.Name = "ButAround"
        Me.ButAround.Size = New System.Drawing.Size(88, 39)
        Me.ButAround.TabIndex = 343
        Me.ButAround.Text = "طبـــاعة"
        Me.ButAround.UseVisualStyleBackColor = False
        '
        'ComIDcustody
        '
        Me.ComIDcustody.BackColor = System.Drawing.Color.Beige
        Me.ComIDcustody.DropDownStyle = System.Windows.Forms.ComboBoxStyle.Simple
        Me.ComIDcustody.Enabled = False
        Me.ComIDcustody.ForeColor = System.Drawing.Color.BlueViolet
        Me.ComIDcustody.FormattingEnabled = True
        Me.ComIDcustody.Location = New System.Drawing.Point(13, 9)
        Me.ComIDcustody.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.ComIDcustody.Name = "ComIDcustody"
        Me.ComIDcustody.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.ComIDcustody.Size = New System.Drawing.Size(48, 21)
        Me.ComIDcustody.TabIndex = 344
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Location = New System.Drawing.Point(8, 34)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.TabControl1.RightToLeftLayout = True
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(382, 228)
        Me.TabControl1.TabIndex = 345
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.ComCustodyName)
        Me.TabPage1.Controls.Add(Me.ButAround)
        Me.TabPage1.Controls.Add(Me.ComIDcustody)
        Me.TabPage1.Controls.Add(Me.Label3)
        Me.TabPage1.Controls.Add(Me.R1)
        Me.TabPage1.Controls.Add(Me.Label2)
        Me.TabPage1.Controls.Add(Me.Label27)
        Me.TabPage1.Controls.Add(Me.TexNumber2)
        Me.TabPage1.Controls.Add(Me.TexNumber1)
        Me.TabPage1.Controls.Add(Me.R2)
        Me.TabPage1.Location = New System.Drawing.Point(4, 22)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(374, 202)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "طباعة العهدة"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'TabPage2
        '
        Me.TabPage2.Location = New System.Drawing.Point(4, 22)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(374, 202)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "-"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'ReportOhOhda
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.SkyBlue
        Me.ClientSize = New System.Drawing.Size(394, 292)
        Me.ControlBox = False
        Me.Controls.Add(Me.TabControl1)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Panel2)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "ReportOhOhda"
        Me.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents ButMinimized As System.Windows.Forms.Button
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents ButExit As System.Windows.Forms.Button
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents Label27 As System.Windows.Forms.Label
    Friend WithEvents ComCustodyName As System.Windows.Forms.ComboBox
    Friend WithEvents R1 As System.Windows.Forms.RadioButton
    Friend WithEvents R2 As System.Windows.Forms.RadioButton
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents TexNumber2 As System.Windows.Forms.TextBox
    Friend WithEvents TexNumber1 As System.Windows.Forms.TextBox
    Friend WithEvents ButAround As System.Windows.Forms.Button
    Friend WithEvents ComIDcustody As System.Windows.Forms.ComboBox
    Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
    Friend WithEvents TabPage1 As System.Windows.Forms.TabPage
    Friend WithEvents TabPage2 As System.Windows.Forms.TabPage
End Class
