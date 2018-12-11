<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class DataSwap
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(DataSwap))
        Me.DataGridView = New System.Windows.Forms.DataGridView
        Me.Label14 = New System.Windows.Forms.Label
        Me.ButExit = New System.Windows.Forms.Button
        Me.PictureBox1 = New System.Windows.Forms.PictureBox
        Me.TexECode = New System.Windows.Forms.TextBox
        Me.ButMinimized = New System.Windows.Forms.Button
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.Panel2 = New System.Windows.Forms.Panel
        Me.T1 = New System.Windows.Forms.TextBox
        Me.txtFirstName = New System.Windows.Forms.TextBox
        CType(Me.DataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'DataGridView
        '
        Me.DataGridView.AllowUserToAddRows = False
        Me.DataGridView.AllowUserToDeleteRows = False
        Me.DataGridView.AllowUserToResizeColumns = False
        Me.DataGridView.AllowUserToResizeRows = False
        Me.DataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.DataGridView.BackgroundColor = System.Drawing.Color.Lavender
        Me.DataGridView.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.DataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically
        Me.DataGridView.GridColor = System.Drawing.Color.Teal
        Me.DataGridView.Location = New System.Drawing.Point(2, 51)
        Me.DataGridView.Name = "DataGridView"
        Me.DataGridView.RowHeadersVisible = False
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.Aquamarine
        Me.DataGridView.RowsDefaultCellStyle = DataGridViewCellStyle1
        Me.DataGridView.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.Color.MintCream
        Me.DataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DataGridView.Size = New System.Drawing.Size(345, 233)
        Me.DataGridView.TabIndex = 363
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.BackColor = System.Drawing.Color.MintCream
        Me.Label14.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.ForeColor = System.Drawing.Color.Black
        Me.Label14.Location = New System.Drawing.Point(97, 8)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(136, 16)
        Me.Label14.TabIndex = 315
        Me.Label14.Text = "أختار العهدة المحول إلية"
        '
        'ButExit
        '
        Me.ButExit.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.ButExit.Location = New System.Drawing.Point(324, 3)
        Me.ButExit.Name = "ButExit"
        Me.ButExit.Size = New System.Drawing.Size(24, 21)
        Me.ButExit.TabIndex = 318
        Me.ButExit.Text = "X"
        Me.ButExit.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.ButExit.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.ButExit.UseVisualStyleBackColor = True
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
        'TexECode
        '
        Me.TexECode.ForeColor = System.Drawing.Color.Blue
        Me.TexECode.Location = New System.Drawing.Point(293, 29)
        Me.TexECode.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.TexECode.Name = "TexECode"
        Me.TexECode.ReadOnly = True
        Me.TexECode.Size = New System.Drawing.Size(55, 20)
        Me.TexECode.TabIndex = 355
        Me.TexECode.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'ButMinimized
        '
        Me.ButMinimized.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.ButMinimized.Location = New System.Drawing.Point(297, 3)
        Me.ButMinimized.Name = "ButMinimized"
        Me.ButMinimized.Size = New System.Drawing.Size(24, 21)
        Me.ButMinimized.TabIndex = 319
        Me.ButMinimized.Text = "-"
        Me.ButMinimized.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.ButMinimized.UseVisualStyleBackColor = True
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
        Me.Panel1.Size = New System.Drawing.Size(351, 28)
        Me.Panel1.TabIndex = 349
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.MintCream
        Me.Panel2.Controls.Add(Me.txtFirstName)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel2.Location = New System.Drawing.Point(0, 285)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(351, 28)
        Me.Panel2.TabIndex = 350
        '
        'T1
        '
        Me.T1.Enabled = False
        Me.T1.ForeColor = System.Drawing.Color.Blue
        Me.T1.Location = New System.Drawing.Point(236, 29)
        Me.T1.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.T1.Name = "T1"
        Me.T1.Size = New System.Drawing.Size(54, 20)
        Me.T1.TabIndex = 364
        Me.T1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtFirstName
        '
        Me.txtFirstName.Location = New System.Drawing.Point(130, 5)
        Me.txtFirstName.Name = "txtFirstName"
        Me.txtFirstName.Size = New System.Drawing.Size(100, 20)
        Me.txtFirstName.TabIndex = 365
        '
        'DataSwap
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(351, 313)
        Me.ControlBox = False
        Me.Controls.Add(Me.T1)
        Me.Controls.Add(Me.DataGridView)
        Me.Controls.Add(Me.TexECode)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Panel2)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "DataSwap"
        Me.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        CType(Me.DataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents DataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents ButExit As System.Windows.Forms.Button
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents TexECode As System.Windows.Forms.TextBox
    Friend WithEvents ButMinimized As System.Windows.Forms.Button
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents T1 As System.Windows.Forms.TextBox
    Friend WithEvents txtFirstName As System.Windows.Forms.TextBox
End Class
