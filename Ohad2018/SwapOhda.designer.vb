<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class SwapOhda
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
        Me.components = New System.ComponentModel.Container()
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(SwapOhda))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ComCustodyName1 = New System.Windows.Forms.ComboBox()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.ContextMenuStrip1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.SwapO = New System.Windows.Forms.ToolStripMenuItem()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.ButMinimized = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.ButExit = New System.Windows.Forms.Button()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Compe = New System.Windows.Forms.TextBox()
        Me.SumMo = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Mon = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.ComIDcustody1 = New System.Windows.Forms.ComboBox()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.T1 = New System.Windows.Forms.TextBox()
        Me.ButNew = New System.Windows.Forms.Button()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ContextMenuStrip1.SuspendLayout()
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(740, 40)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(56, 13)
        Me.Label1.TabIndex = 349
        Me.Label1.Text = "اسم العهدة"
        '
        'ComCustodyName1
        '
        Me.ComCustodyName1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComCustodyName1.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.ComCustodyName1.FormattingEnabled = True
        Me.ComCustodyName1.Location = New System.Drawing.Point(520, 35)
        Me.ComCustodyName1.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.ComCustodyName1.Name = "ComCustodyName1"
        Me.ComCustodyName1.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.ComCustodyName1.Size = New System.Drawing.Size(217, 21)
        Me.ComCustodyName1.TabIndex = 348
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.AllowUserToResizeColumns = False
        Me.DataGridView1.AllowUserToResizeRows = False
        Me.DataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.DataGridView1.BackgroundColor = System.Drawing.Color.Lavender
        Me.DataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.ContextMenuStrip = Me.ContextMenuStrip1
        Me.DataGridView1.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically
        Me.DataGridView1.GridColor = System.Drawing.Color.Teal
        Me.DataGridView1.Location = New System.Drawing.Point(2, 98)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.RowHeadersVisible = False
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.Aquamarine
        Me.DataGridView1.RowsDefaultCellStyle = DataGridViewCellStyle1
        Me.DataGridView1.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.Color.MintCream
        Me.DataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DataGridView1.Size = New System.Drawing.Size(799, 418)
        Me.DataGridView1.TabIndex = 347
        '
        'ContextMenuStrip1
        '
        Me.ContextMenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.SwapO})
        Me.ContextMenuStrip1.Name = "ContextMenuStrip1"
        Me.ContextMenuStrip1.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.ContextMenuStrip1.Size = New System.Drawing.Size(182, 48)
        '
        'SwapO
        '
        Me.SwapO.Image = CType(resources.GetObject("SwapO.Image"), System.Drawing.Image)
        Me.SwapO.Name = "SwapO"
        Me.SwapO.Size = New System.Drawing.Size(181, 22)
        Me.SwapO.Text = "تحويل العهدة المحددة"
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
        Me.Panel1.Size = New System.Drawing.Size(804, 28)
        Me.Panel1.TabIndex = 354
        '
        'ButMinimized
        '
        Me.ButMinimized.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.ButMinimized.Location = New System.Drawing.Point(750, 2)
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
        Me.ButExit.Location = New System.Drawing.Point(777, 2)
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
        Me.Label14.Location = New System.Drawing.Point(269, 7)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(121, 16)
        Me.Label14.TabIndex = 315
        Me.Label14.Text = "تــــحويل بين العـــــهد"
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.MintCream
        Me.Panel2.Controls.Add(Me.Label4)
        Me.Panel2.Controls.Add(Me.Compe)
        Me.Panel2.Controls.Add(Me.SumMo)
        Me.Panel2.Controls.Add(Me.Label3)
        Me.Panel2.Controls.Add(Me.Mon)
        Me.Panel2.Controls.Add(Me.Label2)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel2.Location = New System.Drawing.Point(0, 520)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(804, 28)
        Me.Panel2.TabIndex = 355
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(254, 8)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(71, 13)
        Me.Label4.TabIndex = 369
        Me.Label4.Text = "فـــارق العهدة"
        '
        'Compe
        '
        Me.Compe.Enabled = False
        Me.Compe.ForeColor = System.Drawing.Color.Blue
        Me.Compe.Location = New System.Drawing.Point(178, 4)
        Me.Compe.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Compe.Name = "Compe"
        Me.Compe.Size = New System.Drawing.Size(72, 20)
        Me.Compe.TabIndex = 368
        Me.Compe.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'SumMo
        '
        Me.SumMo.Enabled = False
        Me.SumMo.ForeColor = System.Drawing.Color.Blue
        Me.SumMo.Location = New System.Drawing.Point(328, 5)
        Me.SumMo.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.SumMo.Name = "SumMo"
        Me.SumMo.Size = New System.Drawing.Size(72, 20)
        Me.SumMo.TabIndex = 365
        Me.SumMo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(406, 8)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(122, 13)
        Me.Label3.TabIndex = 366
        Me.Label3.Text = "المبلغ المصروف من العهدة"
        '
        'Mon
        '
        Me.Mon.BackColor = System.Drawing.Color.Beige
        Me.Mon.DropDownStyle = System.Windows.Forms.ComboBoxStyle.Simple
        Me.Mon.Enabled = False
        Me.Mon.ForeColor = System.Drawing.Color.BlueViolet
        Me.Mon.FormattingEnabled = True
        Me.Mon.Location = New System.Drawing.Point(538, 4)
        Me.Mon.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Mon.Name = "Mon"
        Me.Mon.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.Mon.Size = New System.Drawing.Size(48, 21)
        Me.Mon.TabIndex = 367
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(590, 8)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(58, 13)
        Me.Label2.TabIndex = 364
        Me.Label2.Text = "مبلغ العهدة"
        '
        'ComIDcustody1
        '
        Me.ComIDcustody1.BackColor = System.Drawing.Color.Beige
        Me.ComIDcustody1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.Simple
        Me.ComIDcustody1.Enabled = False
        Me.ComIDcustody1.ForeColor = System.Drawing.Color.BlueViolet
        Me.ComIDcustody1.FormattingEnabled = True
        Me.ComIDcustody1.Location = New System.Drawing.Point(888, 31)
        Me.ComIDcustody1.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.ComIDcustody1.Name = "ComIDcustody1"
        Me.ComIDcustody1.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.ComIDcustody1.Size = New System.Drawing.Size(48, 21)
        Me.ComIDcustody1.TabIndex = 357
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        Me.Timer1.Interval = 1500
        '
        'T1
        '
        Me.T1.Enabled = False
        Me.T1.ForeColor = System.Drawing.Color.Blue
        Me.T1.Location = New System.Drawing.Point(812, 31)
        Me.T1.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.T1.Name = "T1"
        Me.T1.Size = New System.Drawing.Size(72, 20)
        Me.T1.TabIndex = 360
        Me.T1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'ButNew
        '
        Me.ButNew.BackColor = System.Drawing.Color.GhostWhite
        Me.ButNew.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.ButNew.Location = New System.Drawing.Point(411, 31)
        Me.ButNew.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.ButNew.Name = "ButNew"
        Me.ButNew.Size = New System.Drawing.Size(98, 28)
        Me.ButNew.TabIndex = 362
        Me.ButNew.Text = "عـــــرض البيانات"
        Me.ButNew.UseVisualStyleBackColor = False
        '
        'ComboBox1
        '
        Me.ComboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.Simple
        Me.ComboBox1.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Location = New System.Drawing.Point(2, 64)
        Me.ComboBox1.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.ComboBox1.Size = New System.Drawing.Size(790, 21)
        Me.ComboBox1.TabIndex = 363
        '
        'SwapOhda
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.SkyBlue
        Me.ClientSize = New System.Drawing.Size(804, 548)
        Me.ControlBox = False
        Me.Controls.Add(Me.ComboBox1)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.ButNew)
        Me.Controls.Add(Me.T1)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.ComIDcustody1)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.ComCustodyName1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "SwapOhda"
        Me.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ContextMenuStrip1.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents ComCustodyName1 As System.Windows.Forms.ComboBox
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents ButMinimized As System.Windows.Forms.Button
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents ButExit As System.Windows.Forms.Button
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents ComIDcustody1 As System.Windows.Forms.ComboBox
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents T1 As System.Windows.Forms.TextBox
    Friend WithEvents ButNew As System.Windows.Forms.Button
    Friend WithEvents ContextMenuStrip1 As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents SwapO As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents SumMo As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Mon As System.Windows.Forms.ComboBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Compe As System.Windows.Forms.TextBox
    Friend WithEvents ComboBox1 As ComboBox
End Class
