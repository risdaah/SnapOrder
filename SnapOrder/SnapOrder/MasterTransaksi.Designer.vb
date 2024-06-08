<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MasterTransaksi
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
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.DgMasterTransaksi = New Guna.UI2.WinForms.Guna2DataGridView()
        Me.id_transaksi = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.nama_pembeli = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.total = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TbTotalPemasukan = New Guna.UI2.WinForms.Guna2TextBox()
        CType(Me.DgMasterTransaksi, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label4
        '
        Me.Label4.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Nirmala UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(278, 397)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(182, 21)
        Me.Label4.TabIndex = 29
        Me.Label4.Text = "Total Pemasukan      Rp"
        '
        'Label1
        '
        Me.Label1.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Nirmala UI", 26.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(198, 23)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(296, 47)
        Me.Label1.TabIndex = 31
        Me.Label1.Text = "LIST TRANSAKSI"
        '
        'DgMasterTransaksi
        '
        DataGridViewCellStyle4.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.DgMasterTransaksi.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle4
        Me.DgMasterTransaksi.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.DgMasterTransaksi.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.None
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle5.BackColor = System.Drawing.Color.Orange
        DataGridViewCellStyle5.Font = New System.Drawing.Font("Nirmala UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle5.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DgMasterTransaksi.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle5
        Me.DgMasterTransaksi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing
        Me.DgMasterTransaksi.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.id_transaksi, Me.nama_pembeli, Me.total})
        DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle6.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle6.Font = New System.Drawing.Font("Nirmala UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle6.ForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        DataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        DataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DgMasterTransaksi.DefaultCellStyle = DataGridViewCellStyle6
        Me.DgMasterTransaksi.GridColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.DgMasterTransaksi.Location = New System.Drawing.Point(25, 105)
        Me.DgMasterTransaksi.Name = "DgMasterTransaksi"
        Me.DgMasterTransaksi.RowHeadersVisible = False
        Me.DgMasterTransaksi.RowTemplate.Height = 23
        Me.DgMasterTransaksi.Size = New System.Drawing.Size(652, 257)
        Me.DgMasterTransaksi.TabIndex = 32
        Me.DgMasterTransaksi.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White
        Me.DgMasterTransaksi.ThemeStyle.AlternatingRowsStyle.Font = Nothing
        Me.DgMasterTransaksi.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty
        Me.DgMasterTransaksi.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty
        Me.DgMasterTransaksi.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty
        Me.DgMasterTransaksi.ThemeStyle.BackColor = System.Drawing.Color.White
        Me.DgMasterTransaksi.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.DgMasterTransaksi.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.Orange
        Me.DgMasterTransaksi.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        Me.DgMasterTransaksi.ThemeStyle.HeaderStyle.Font = New System.Drawing.Font("Nirmala UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DgMasterTransaksi.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.Black
        Me.DgMasterTransaksi.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing
        Me.DgMasterTransaksi.ThemeStyle.HeaderStyle.Height = 23
        Me.DgMasterTransaksi.ThemeStyle.ReadOnly = False
        Me.DgMasterTransaksi.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White
        Me.DgMasterTransaksi.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        Me.DgMasterTransaksi.ThemeStyle.RowsStyle.Font = New System.Drawing.Font("Nirmala UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DgMasterTransaksi.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        Me.DgMasterTransaksi.ThemeStyle.RowsStyle.Height = 23
        Me.DgMasterTransaksi.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.DgMasterTransaksi.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        '
        'id_transaksi
        '
        Me.id_transaksi.HeaderText = "ID Transaksi"
        Me.id_transaksi.Name = "id_transaksi"
        Me.id_transaksi.Width = 200
        '
        'nama_pembeli
        '
        Me.nama_pembeli.HeaderText = "Nama Pembeli"
        Me.nama_pembeli.Name = "nama_pembeli"
        Me.nama_pembeli.Width = 250
        '
        'total
        '
        Me.total.HeaderText = "Total Beli"
        Me.total.Name = "total"
        Me.total.Width = 200
        '
        'TbTotalPemasukan
        '
        Me.TbTotalPemasukan.BorderRadius = 5
        Me.TbTotalPemasukan.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.TbTotalPemasukan.DefaultText = ""
        Me.TbTotalPemasukan.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.TbTotalPemasukan.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.TbTotalPemasukan.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.TbTotalPemasukan.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.TbTotalPemasukan.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.TbTotalPemasukan.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.TbTotalPemasukan.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.TbTotalPemasukan.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.TbTotalPemasukan.Location = New System.Drawing.Point(466, 394)
        Me.TbTotalPemasukan.Name = "TbTotalPemasukan"
        Me.TbTotalPemasukan.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.TbTotalPemasukan.PlaceholderText = ""
        Me.TbTotalPemasukan.ReadOnly = True
        Me.TbTotalPemasukan.SelectedText = ""
        Me.TbTotalPemasukan.Size = New System.Drawing.Size(210, 30)
        Me.TbTotalPemasukan.TabIndex = 33
        '
        'MasterTransaksi
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.MenuBar
        Me.ClientSize = New System.Drawing.Size(711, 452)
        Me.Controls.Add(Me.TbTotalPemasukan)
        Me.Controls.Add(Me.DgMasterTransaksi)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label4)
        Me.Name = "MasterTransaksi"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "MasterTransaksi"
        CType(Me.DgMasterTransaksi, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label4 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents DgMasterTransaksi As Guna.UI2.WinForms.Guna2DataGridView
    Friend WithEvents TbTotalPemasukan As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents id_transaksi As DataGridViewTextBoxColumn
    Friend WithEvents nama_pembeli As DataGridViewTextBoxColumn
    Friend WithEvents total As DataGridViewTextBoxColumn
End Class
