<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class DetailTransaksi
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
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.BtnKeMasterTransaksi = New Guna.UI2.WinForms.Guna2Button()
        Me.TbInvoice = New Guna.UI2.WinForms.Guna2TextBox()
        Me.TbNama_Pembeli = New Guna.UI2.WinForms.Guna2TextBox()
        Me.DgMenuItem = New Guna.UI2.WinForms.Guna2DataGridView()
        Me.nama_menu = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.harga_menu = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.jumlah_menu = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SubTotal = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TbTotalDetail = New Guna.UI2.WinForms.Guna2TextBox()
        CType(Me.DgMenuItem, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label2
        '
        Me.Label2.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Nirmala UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(419, 458)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(83, 21)
        Me.Label2.TabIndex = 24
        Me.Label2.Text = "Total    Rp"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Nirmala UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(23, 70)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(98, 17)
        Me.Label1.TabIndex = 21
        Me.Label1.Text = "Nama Pembeli"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Nirmala UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(25, 26)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(69, 17)
        Me.Label4.TabIndex = 19
        Me.Label4.Text = "No. Order"
        '
        'BtnKeMasterTransaksi
        '
        Me.BtnKeMasterTransaksi.BorderRadius = 10
        Me.BtnKeMasterTransaksi.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.BtnKeMasterTransaksi.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.BtnKeMasterTransaksi.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.BtnKeMasterTransaksi.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.BtnKeMasterTransaksi.FillColor = System.Drawing.Color.RoyalBlue
        Me.BtnKeMasterTransaksi.Font = New System.Drawing.Font("Nirmala UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnKeMasterTransaksi.ForeColor = System.Drawing.Color.White
        Me.BtnKeMasterTransaksi.Location = New System.Drawing.Point(26, 453)
        Me.BtnKeMasterTransaksi.Name = "BtnKeMasterTransaksi"
        Me.BtnKeMasterTransaksi.Size = New System.Drawing.Size(165, 33)
        Me.BtnKeMasterTransaksi.TabIndex = 27
        Me.BtnKeMasterTransaksi.Text = "Ke Master Transaksi"
        '
        'TbInvoice
        '
        Me.TbInvoice.BorderRadius = 5
        Me.TbInvoice.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.TbInvoice.DefaultText = ""
        Me.TbInvoice.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.TbInvoice.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.TbInvoice.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.TbInvoice.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.TbInvoice.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.TbInvoice.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.TbInvoice.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.TbInvoice.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.TbInvoice.Location = New System.Drawing.Point(153, 22)
        Me.TbInvoice.Name = "TbInvoice"
        Me.TbInvoice.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.TbInvoice.PlaceholderText = ""
        Me.TbInvoice.ReadOnly = True
        Me.TbInvoice.SelectedText = ""
        Me.TbInvoice.Size = New System.Drawing.Size(242, 25)
        Me.TbInvoice.TabIndex = 28
        '
        'TbNama_Pembeli
        '
        Me.TbNama_Pembeli.BorderRadius = 5
        Me.TbNama_Pembeli.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.TbNama_Pembeli.DefaultText = ""
        Me.TbNama_Pembeli.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.TbNama_Pembeli.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.TbNama_Pembeli.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.TbNama_Pembeli.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.TbNama_Pembeli.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.TbNama_Pembeli.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.TbNama_Pembeli.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.TbNama_Pembeli.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.TbNama_Pembeli.Location = New System.Drawing.Point(153, 66)
        Me.TbNama_Pembeli.Name = "TbNama_Pembeli"
        Me.TbNama_Pembeli.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.TbNama_Pembeli.PlaceholderText = ""
        Me.TbNama_Pembeli.ReadOnly = True
        Me.TbNama_Pembeli.SelectedText = ""
        Me.TbNama_Pembeli.Size = New System.Drawing.Size(242, 25)
        Me.TbNama_Pembeli.TabIndex = 29
        '
        'DgMenuItem
        '
        DataGridViewCellStyle4.BackColor = System.Drawing.Color.White
        Me.DgMenuItem.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle4
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle5.BackColor = System.Drawing.Color.Orange
        DataGridViewCellStyle5.Font = New System.Drawing.Font("Nirmala UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle5.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DgMenuItem.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle5
        Me.DgMenuItem.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DgMenuItem.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.nama_menu, Me.harga_menu, Me.jumlah_menu, Me.SubTotal})
        DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle6.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle6.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle6.ForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        DataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        DataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DgMenuItem.DefaultCellStyle = DataGridViewCellStyle6
        Me.DgMenuItem.GridColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.DgMenuItem.Location = New System.Drawing.Point(26, 127)
        Me.DgMenuItem.Name = "DgMenuItem"
        Me.DgMenuItem.RowHeadersVisible = False
        Me.DgMenuItem.Size = New System.Drawing.Size(693, 286)
        Me.DgMenuItem.TabIndex = 30
        Me.DgMenuItem.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White
        Me.DgMenuItem.ThemeStyle.AlternatingRowsStyle.Font = Nothing
        Me.DgMenuItem.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty
        Me.DgMenuItem.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty
        Me.DgMenuItem.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty
        Me.DgMenuItem.ThemeStyle.BackColor = System.Drawing.Color.White
        Me.DgMenuItem.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.DgMenuItem.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.DgMenuItem.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        Me.DgMenuItem.ThemeStyle.HeaderStyle.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DgMenuItem.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White
        Me.DgMenuItem.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DgMenuItem.ThemeStyle.HeaderStyle.Height = 15
        Me.DgMenuItem.ThemeStyle.ReadOnly = False
        Me.DgMenuItem.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White
        Me.DgMenuItem.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        Me.DgMenuItem.ThemeStyle.RowsStyle.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DgMenuItem.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        Me.DgMenuItem.ThemeStyle.RowsStyle.Height = 22
        Me.DgMenuItem.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.DgMenuItem.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        '
        'nama_menu
        '
        Me.nama_menu.FillWeight = 200.0!
        Me.nama_menu.HeaderText = "Menu"
        Me.nama_menu.Name = "nama_menu"
        Me.nama_menu.ReadOnly = True
        '
        'harga_menu
        '
        Me.harga_menu.FillWeight = 150.0!
        Me.harga_menu.HeaderText = "Harga"
        Me.harga_menu.Name = "harga_menu"
        Me.harga_menu.ReadOnly = True
        '
        'jumlah_menu
        '
        Me.jumlah_menu.FillWeight = 150.0!
        Me.jumlah_menu.HeaderText = "Jumlah"
        Me.jumlah_menu.Name = "jumlah_menu"
        Me.jumlah_menu.ReadOnly = True
        '
        'SubTotal
        '
        Me.SubTotal.FillWeight = 150.0!
        Me.SubTotal.HeaderText = "SubTotal"
        Me.SubTotal.Name = "SubTotal"
        Me.SubTotal.ReadOnly = True
        '
        'TbTotalDetail
        '
        Me.TbTotalDetail.BorderRadius = 5
        Me.TbTotalDetail.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.TbTotalDetail.DefaultText = ""
        Me.TbTotalDetail.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.TbTotalDetail.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.TbTotalDetail.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.TbTotalDetail.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.TbTotalDetail.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.TbTotalDetail.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.TbTotalDetail.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.TbTotalDetail.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.TbTotalDetail.Location = New System.Drawing.Point(508, 458)
        Me.TbTotalDetail.Name = "TbTotalDetail"
        Me.TbTotalDetail.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.TbTotalDetail.PlaceholderText = ""
        Me.TbTotalDetail.ReadOnly = True
        Me.TbTotalDetail.SelectedText = ""
        Me.TbTotalDetail.Size = New System.Drawing.Size(211, 25)
        Me.TbTotalDetail.TabIndex = 31
        '
        'DetailTransaksi
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.MenuBar
        Me.ClientSize = New System.Drawing.Size(744, 515)
        Me.Controls.Add(Me.TbTotalDetail)
        Me.Controls.Add(Me.DgMenuItem)
        Me.Controls.Add(Me.TbNama_Pembeli)
        Me.Controls.Add(Me.TbInvoice)
        Me.Controls.Add(Me.BtnKeMasterTransaksi)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label4)
        Me.Name = "DetailTransaksi"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "DetailTransaksi"
        CType(Me.DgMenuItem, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents BtnKeMasterTransaksi As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents TbInvoice As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents TbNama_Pembeli As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents DgMenuItem As Guna.UI2.WinForms.Guna2DataGridView
    Friend WithEvents nama_menu As DataGridViewTextBoxColumn
    Friend WithEvents harga_menu As DataGridViewTextBoxColumn
    Friend WithEvents jumlah_menu As DataGridViewTextBoxColumn
    Friend WithEvents SubTotal As DataGridViewTextBoxColumn
    Friend WithEvents TbTotalDetail As Guna.UI2.WinForms.Guna2TextBox
End Class
