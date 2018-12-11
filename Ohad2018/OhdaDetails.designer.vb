<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class OhdaDetails
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(OhdaDetails))
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.ButMinimized = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.ButExit = New System.Windows.Forms.Button()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.ButAround = New System.Windows.Forms.Button()
        Me.ButUpDate = New System.Windows.Forms.Button()
        Me.ButSave = New System.Windows.Forms.Button()
        Me.ButNew = New System.Windows.Forms.Button()
        Me.Label27 = New System.Windows.Forms.Label()
        Me.ButDelete = New System.Windows.Forms.Button()
        Me.ComDate = New System.Windows.Forms.ComboBox()
        Me.ComIDcustody = New System.Windows.Forms.ComboBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.TexIDRecord = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.TexDataOfCustody = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ComCustodyName = New System.Windows.Forms.ComboBox()
        Me.ComTypeOfCusdoty = New System.Windows.Forms.ComboBox()
        Me.DateOfCustody = New System.Windows.Forms.DateTimePicker()
        Me.TexNoticeCustody = New System.Windows.Forms.TextBox()
        Me.TexMoneyOfCustody = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.GBox = New System.Windows.Forms.GroupBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.ComNameCustody = New System.Windows.Forms.ComboBox()
        Me.ContextMenuStrip1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.RefreshDataToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        Me.GBox.SuspendLayout()
        Me.ContextMenuStrip1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.Panel1.Size = New System.Drawing.Size(663, 28)
        Me.Panel1.TabIndex = 321
        '
        'ButMinimized
        '
        Me.ButMinimized.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.ButMinimized.Location = New System.Drawing.Point(596, 4)
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
        Me.ButExit.Location = New System.Drawing.Point(623, 4)
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
        Me.Label14.Location = New System.Drawing.Point(249, 5)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(112, 16)
        Me.Label14.TabIndex = 315
        Me.Label14.Text = "صــــرفيات العـــهــــد"
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.MintCream
        Me.Panel2.Controls.Add(Me.Label10)
        Me.Panel2.Controls.Add(Me.TextBox1)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel2.Location = New System.Drawing.Point(0, 489)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(663, 28)
        Me.Panel2.TabIndex = 322
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(149, 8)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(41, 13)
        Me.Label10.TabIndex = 108
        Me.Label10.Text = "بــحـــث"
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(5, 4)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(140, 20)
        Me.TextBox1.TabIndex = 0
        '
        'ButAround
        '
        Me.ButAround.BackColor = System.Drawing.Color.GhostWhite
        Me.ButAround.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.ButAround.Location = New System.Drawing.Point(8, 93)
        Me.ButAround.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.ButAround.Name = "ButAround"
        Me.ButAround.Size = New System.Drawing.Size(123, 32)
        Me.ButAround.TabIndex = 342
        Me.ButAround.Text = "تراجع"
        Me.ButAround.UseVisualStyleBackColor = False
        '
        'ButUpDate
        '
        Me.ButUpDate.BackColor = System.Drawing.Color.GhostWhite
        Me.ButUpDate.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.ButUpDate.Location = New System.Drawing.Point(8, 19)
        Me.ButUpDate.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.ButUpDate.Name = "ButUpDate"
        Me.ButUpDate.Size = New System.Drawing.Size(60, 32)
        Me.ButUpDate.TabIndex = 341
        Me.ButUpDate.Text = "تعديل"
        Me.ButUpDate.UseVisualStyleBackColor = False
        '
        'ButSave
        '
        Me.ButSave.BackColor = System.Drawing.Color.GhostWhite
        Me.ButSave.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.ButSave.Location = New System.Drawing.Point(71, 56)
        Me.ButSave.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.ButSave.Name = "ButSave"
        Me.ButSave.Size = New System.Drawing.Size(60, 32)
        Me.ButSave.TabIndex = 340
        Me.ButSave.Text = "حفظ"
        Me.ButSave.UseVisualStyleBackColor = False
        '
        'ButNew
        '
        Me.ButNew.BackColor = System.Drawing.Color.GhostWhite
        Me.ButNew.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.ButNew.Location = New System.Drawing.Point(71, 19)
        Me.ButNew.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.ButNew.Name = "ButNew"
        Me.ButNew.Size = New System.Drawing.Size(60, 32)
        Me.ButNew.TabIndex = 339
        Me.ButNew.Text = "جديد"
        Me.ButNew.UseVisualStyleBackColor = False
        '
        'Label27
        '
        Me.Label27.AutoSize = True
        Me.Label27.Location = New System.Drawing.Point(564, 40)
        Me.Label27.Name = "Label27"
        Me.Label27.Size = New System.Drawing.Size(56, 13)
        Me.Label27.TabIndex = 328
        Me.Label27.Text = "اسم العهدة"
        '
        'ButDelete
        '
        Me.ButDelete.BackColor = System.Drawing.Color.GhostWhite
        Me.ButDelete.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.ButDelete.Location = New System.Drawing.Point(8, 56)
        Me.ButDelete.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.ButDelete.Name = "ButDelete"
        Me.ButDelete.Size = New System.Drawing.Size(60, 32)
        Me.ButDelete.TabIndex = 338
        Me.ButDelete.Text = "حذف"
        Me.ButDelete.UseVisualStyleBackColor = False
        '
        'ComDate
        '
        Me.ComDate.DropDownStyle = System.Windows.Forms.ComboBoxStyle.Simple
        Me.ComDate.Enabled = False
        Me.ComDate.FormattingEnabled = True
        Me.ComDate.Location = New System.Drawing.Point(5, 116)
        Me.ComDate.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.ComDate.Name = "ComDate"
        Me.ComDate.Size = New System.Drawing.Size(93, 21)
        Me.ComDate.TabIndex = 104
        '
        'ComIDcustody
        '
        Me.ComIDcustody.BackColor = System.Drawing.Color.Beige
        Me.ComIDcustody.DropDownStyle = System.Windows.Forms.ComboBoxStyle.Simple
        Me.ComIDcustody.Enabled = False
        Me.ComIDcustody.ForeColor = System.Drawing.Color.BlueViolet
        Me.ComIDcustody.FormattingEnabled = True
        Me.ComIDcustody.Location = New System.Drawing.Point(15, 33)
        Me.ComIDcustody.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.ComIDcustody.Name = "ComIDcustody"
        Me.ComIDcustody.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.ComIDcustody.Size = New System.Drawing.Size(78, 21)
        Me.ComIDcustody.TabIndex = 98
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(21, 99)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(64, 13)
        Me.Label4.TabIndex = 103
        Me.Label4.Text = "تاريخ العهدة"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(27, 15)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(55, 13)
        Me.Label7.TabIndex = 105
        Me.Label7.Text = "رقم العهدة"
        '
        'TexIDRecord
        '
        Me.TexIDRecord.ForeColor = System.Drawing.Color.Blue
        Me.TexIDRecord.Location = New System.Drawing.Point(469, 91)
        Me.TexIDRecord.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.TexIDRecord.Name = "TexIDRecord"
        Me.TexIDRecord.ReadOnly = True
        Me.TexIDRecord.Size = New System.Drawing.Size(126, 20)
        Me.TexIDRecord.TabIndex = 333
        Me.TexIDRecord.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(600, 95)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(55, 13)
        Me.Label8.TabIndex = 332
        Me.Label8.Text = "رقم السجل"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(599, 152)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(63, 13)
        Me.Label6.TabIndex = 331
        Me.Label6.Text = "انواع الوثيقة"
        '
        'TexDataOfCustody
        '
        Me.TexDataOfCustody.ForeColor = System.Drawing.Color.Blue
        Me.TexDataOfCustody.Location = New System.Drawing.Point(319, 114)
        Me.TexDataOfCustody.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.TexDataOfCustody.Multiline = True
        Me.TexDataOfCustody.Name = "TexDataOfCustody"
        Me.TexDataOfCustody.Size = New System.Drawing.Size(276, 33)
        Me.TexDataOfCustody.TabIndex = 2
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(629, 123)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(32, 13)
        Me.Label1.TabIndex = 330
        Me.Label1.Text = "البيان"
        '
        'ComCustodyName
        '
        Me.ComCustodyName.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComCustodyName.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.ComCustodyName.FormattingEnabled = True
        Me.ComCustodyName.Location = New System.Drawing.Point(344, 35)
        Me.ComCustodyName.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.ComCustodyName.Name = "ComCustodyName"
        Me.ComCustodyName.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.ComCustodyName.Size = New System.Drawing.Size(217, 21)
        Me.ComCustodyName.TabIndex = 0
        '
        'ComTypeOfCusdoty
        '
        Me.ComTypeOfCusdoty.FormattingEnabled = True
        Me.ComTypeOfCusdoty.Items.AddRange(New Object() {"سند", "فاتورة", "إستلام"})
        Me.ComTypeOfCusdoty.Location = New System.Drawing.Point(319, 151)
        Me.ComTypeOfCusdoty.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.ComTypeOfCusdoty.Name = "ComTypeOfCusdoty"
        Me.ComTypeOfCusdoty.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.ComTypeOfCusdoty.Size = New System.Drawing.Size(276, 21)
        Me.ComTypeOfCusdoty.TabIndex = 3
        '
        'DateOfCustody
        '
        Me.DateOfCustody.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DateOfCustody.Location = New System.Drawing.Point(319, 175)
        Me.DateOfCustody.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.DateOfCustody.Name = "DateOfCustody"
        Me.DateOfCustody.Size = New System.Drawing.Size(276, 20)
        Me.DateOfCustody.TabIndex = 4
        '
        'TexNoticeCustody
        '
        Me.TexNoticeCustody.ForeColor = System.Drawing.Color.Blue
        Me.TexNoticeCustody.Location = New System.Drawing.Point(319, 198)
        Me.TexNoticeCustody.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.TexNoticeCustody.Name = "TexNoticeCustody"
        Me.TexNoticeCustody.Size = New System.Drawing.Size(276, 20)
        Me.TexNoticeCustody.TabIndex = 5
        '
        'TexMoneyOfCustody
        '
        Me.TexMoneyOfCustody.ForeColor = System.Drawing.Color.Blue
        Me.TexMoneyOfCustody.Location = New System.Drawing.Point(469, 68)
        Me.TexMoneyOfCustody.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.TexMoneyOfCustody.Name = "TexMoneyOfCustody"
        Me.TexMoneyOfCustody.Size = New System.Drawing.Size(126, 20)
        Me.TexMoneyOfCustody.TabIndex = 1
        Me.TexMoneyOfCustody.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(612, 200)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(45, 13)
        Me.Label5.TabIndex = 327
        Me.Label5.Text = "ملاحظات"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(599, 179)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(64, 13)
        Me.Label3.TabIndex = 326
        Me.Label3.Text = "تاريخ الصرف"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(614, 72)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(44, 13)
        Me.Label2.TabIndex = 325
        Me.Label2.Text = "المــــبلغ"
        '
        'GroupBox1
        '
        Me.GroupBox1.Enabled = False
        Me.GroupBox1.Location = New System.Drawing.Point(7, 55)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(652, 8)
        Me.GroupBox1.TabIndex = 335
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Visible = False
        '
        'GBox
        '
        Me.GBox.Controls.Add(Me.Label9)
        Me.GBox.Controls.Add(Me.ComNameCustody)
        Me.GBox.Controls.Add(Me.Label7)
        Me.GBox.Controls.Add(Me.ComDate)
        Me.GBox.Controls.Add(Me.ComIDcustody)
        Me.GBox.Controls.Add(Me.Label4)
        Me.GBox.Location = New System.Drawing.Point(14, 70)
        Me.GBox.Name = "GBox"
        Me.GBox.Size = New System.Drawing.Size(107, 143)
        Me.GBox.TabIndex = 343
        Me.GBox.TabStop = False
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(28, 57)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(55, 13)
        Me.Label9.TabIndex = 107
        Me.Label9.Text = "رقم العهدة"
        '
        'ComNameCustody
        '
        Me.ComNameCustody.BackColor = System.Drawing.Color.Beige
        Me.ComNameCustody.DropDownStyle = System.Windows.Forms.ComboBoxStyle.Simple
        Me.ComNameCustody.Enabled = False
        Me.ComNameCustody.ForeColor = System.Drawing.Color.BlueViolet
        Me.ComNameCustody.FormattingEnabled = True
        Me.ComNameCustody.Location = New System.Drawing.Point(15, 74)
        Me.ComNameCustody.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.ComNameCustody.Name = "ComNameCustody"
        Me.ComNameCustody.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.ComNameCustody.Size = New System.Drawing.Size(78, 21)
        Me.ComNameCustody.TabIndex = 106
        '
        'ContextMenuStrip1
        '
        Me.ContextMenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.RefreshDataToolStripMenuItem})
        Me.ContextMenuStrip1.Name = "ContextMenuStrip1"
        Me.ContextMenuStrip1.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.ContextMenuStrip1.Size = New System.Drawing.Size(160, 26)
        '
        'RefreshDataToolStripMenuItem
        '
        Me.RefreshDataToolStripMenuItem.Name = "RefreshDataToolStripMenuItem"
        Me.RefreshDataToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F5
        Me.RefreshDataToolStripMenuItem.Size = New System.Drawing.Size(159, 22)
        Me.RefreshDataToolStripMenuItem.Text = "Refresh Data"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.ButUpDate)
        Me.GroupBox2.Controls.Add(Me.ButSave)
        Me.GroupBox2.Controls.Add(Me.ButNew)
        Me.GroupBox2.Controls.Add(Me.ButDelete)
        Me.GroupBox2.Controls.Add(Me.ButAround)
        Me.GroupBox2.Location = New System.Drawing.Point(130, 70)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(138, 143)
        Me.GroupBox2.TabIndex = 344
        Me.GroupBox2.TabStop = False
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
        Me.DataGridView1.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically
        Me.DataGridView1.GridColor = System.Drawing.Color.Teal
        Me.DataGridView1.Location = New System.Drawing.Point(4, 221)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.RowHeadersVisible = False
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.Aquamarine
        Me.DataGridView1.RowsDefaultCellStyle = DataGridViewCellStyle2
        Me.DataGridView1.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.Color.MintCream
        Me.DataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DataGridView1.Size = New System.Drawing.Size(653, 265)
        Me.DataGridView1.TabIndex = 345
        '
        'OhdaDetails
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.SkyBlue
        Me.ClientSize = New System.Drawing.Size(663, 517)
        Me.ContextMenuStrip = Me.ContextMenuStrip1
        Me.ControlBox = False
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.GBox)
        Me.Controls.Add(Me.Label27)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.TexMoneyOfCustody)
        Me.Controls.Add(Me.TexNoticeCustody)
        Me.Controls.Add(Me.TexIDRecord)
        Me.Controls.Add(Me.DateOfCustody)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.ComTypeOfCusdoty)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.TexDataOfCustody)
        Me.Controls.Add(Me.ComCustodyName)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "OhdaDetails"
        Me.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.GBox.ResumeLayout(False)
        Me.GBox.PerformLayout()
        Me.ContextMenuStrip1.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents ButMinimized As System.Windows.Forms.Button
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents ButExit As System.Windows.Forms.Button
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents ButAround As System.Windows.Forms.Button
    Friend WithEvents ButUpDate As System.Windows.Forms.Button
    Friend WithEvents ButSave As System.Windows.Forms.Button
    Friend WithEvents ButNew As System.Windows.Forms.Button
    Friend WithEvents Label27 As System.Windows.Forms.Label
    Friend WithEvents ButDelete As System.Windows.Forms.Button
    Friend WithEvents ComDate As System.Windows.Forms.ComboBox
    Friend WithEvents ComIDcustody As System.Windows.Forms.ComboBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents TexIDRecord As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents TexDataOfCustody As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents ComCustodyName As System.Windows.Forms.ComboBox
    Friend WithEvents ComTypeOfCusdoty As System.Windows.Forms.ComboBox
    Friend WithEvents DateOfCustody As System.Windows.Forms.DateTimePicker
    Friend WithEvents TexNoticeCustody As System.Windows.Forms.TextBox
    Friend WithEvents TexMoneyOfCustody As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents GBox As System.Windows.Forms.GroupBox
    Friend WithEvents ContextMenuStrip1 As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents RefreshDataToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents ComNameCustody As System.Windows.Forms.ComboBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
End Class
