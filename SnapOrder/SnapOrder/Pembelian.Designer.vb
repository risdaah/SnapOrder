<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Pembelian
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.TbJenisTransaksi = New Guna.UI2.WinForms.Guna2TextBox()
        Me.BtPesan = New Guna.UI2.WinForms.Guna2Button()
        Me.TbInvoice2 = New Guna.UI2.WinForms.Guna2TextBox()
        Me.CbKategori2 = New Guna.UI2.WinForms.Guna2ComboBox()
        Me.TbNamaPembeli = New Guna.UI2.WinForms.Guna2TextBox()
        Me.BtBack = New Guna.UI2.WinForms.Guna2Button()
        Me.KeranjangDgv = New Guna.UI2.WinForms.Guna2DataGridView()
        Me.nama_menu = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.jumlah = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.subtotal = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.kurangmenu = New System.Windows.Forms.DataGridViewButtonColumn()
        Me.hapus = New System.Windows.Forms.DataGridViewButtonColumn()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.LbJenisTransaksi = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.tempatMenu = New System.Windows.Forms.FlowLayoutPanel()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.LbTotalBelanja = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.TbCatatan = New Guna.UI2.WinForms.Guna2TextBox()
        CType(Me.KeranjangDgv, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TbJenisTransaksi
        '
        Me.TbJenisTransaksi.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TbJenisTransaksi.BorderRadius = 6
        Me.TbJenisTransaksi.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.TbJenisTransaksi.DefaultText = ""
        Me.TbJenisTransaksi.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.TbJenisTransaksi.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.TbJenisTransaksi.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.TbJenisTransaksi.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.TbJenisTransaksi.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.TbJenisTransaksi.Font = New System.Drawing.Font("Nirmala UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TbJenisTransaksi.ForeColor = System.Drawing.Color.Black
        Me.TbJenisTransaksi.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.TbJenisTransaksi.Location = New System.Drawing.Point(679, 79)
        Me.TbJenisTransaksi.Name = "TbJenisTransaksi"
        Me.TbJenisTransaksi.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.TbJenisTransaksi.PlaceholderText = ""
        Me.TbJenisTransaksi.ReadOnly = True
        Me.TbJenisTransaksi.SelectedText = ""
        Me.TbJenisTransaksi.Size = New System.Drawing.Size(120, 20)
        Me.TbJenisTransaksi.TabIndex = 44
        Me.TbJenisTransaksi.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'BtPesan
        '
        Me.BtPesan.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BtPesan.BorderColor = System.Drawing.Color.Transparent
        Me.BtPesan.BorderRadius = 12
        Me.BtPesan.BorderThickness = 1
        Me.BtPesan.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.BtPesan.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.BtPesan.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.BtPesan.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.BtPesan.FillColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(66, Byte), Integer), CType(CType(37, Byte), Integer))
        Me.BtPesan.Font = New System.Drawing.Font("Nirmala UI", 12.0!, System.Drawing.FontStyle.Bold)
        Me.BtPesan.ForeColor = System.Drawing.Color.White
        Me.BtPesan.Location = New System.Drawing.Point(1038, 533)
        Me.BtPesan.Name = "BtPesan"
        Me.BtPesan.Size = New System.Drawing.Size(180, 45)
        Me.BtPesan.TabIndex = 43
        Me.BtPesan.Text = "PESAN"
        '
        'TbInvoice2
        '
        Me.TbInvoice2.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TbInvoice2.BorderRadius = 6
        Me.TbInvoice2.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.TbInvoice2.DefaultText = ""
        Me.TbInvoice2.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.TbInvoice2.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.TbInvoice2.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.TbInvoice2.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.TbInvoice2.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.TbInvoice2.Font = New System.Drawing.Font("Nirmala UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TbInvoice2.ForeColor = System.Drawing.Color.Black
        Me.TbInvoice2.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.TbInvoice2.Location = New System.Drawing.Point(1087, 79)
        Me.TbInvoice2.Name = "TbInvoice2"
        Me.TbInvoice2.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.TbInvoice2.PlaceholderText = ""
        Me.TbInvoice2.ReadOnly = True
        Me.TbInvoice2.SelectedText = ""
        Me.TbInvoice2.Size = New System.Drawing.Size(129, 20)
        Me.TbInvoice2.TabIndex = 42
        Me.TbInvoice2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'CbKategori2
        '
        Me.CbKategori2.BackColor = System.Drawing.Color.Transparent
        Me.CbKategori2.BorderRadius = 12
        Me.CbKategori2.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.CbKategori2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CbKategori2.FocusedColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.CbKategori2.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.CbKategori2.Font = New System.Drawing.Font("Nirmala UI", 12.0!)
        Me.CbKategori2.ForeColor = System.Drawing.Color.Black
        Me.CbKategori2.ItemHeight = 30
        Me.CbKategori2.Location = New System.Drawing.Point(36, 176)
        Me.CbKategori2.Name = "CbKategori2"
        Me.CbKategori2.Size = New System.Drawing.Size(601, 36)
        Me.CbKategori2.TabIndex = 41
        '
        'TbNamaPembeli
        '
        Me.TbNamaPembeli.BorderRadius = 12
        Me.TbNamaPembeli.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.TbNamaPembeli.DefaultText = ""
        Me.TbNamaPembeli.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.TbNamaPembeli.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.TbNamaPembeli.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.TbNamaPembeli.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.TbNamaPembeli.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.TbNamaPembeli.Font = New System.Drawing.Font("Nirmala UI", 12.0!)
        Me.TbNamaPembeli.ForeColor = System.Drawing.Color.Black
        Me.TbNamaPembeli.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.TbNamaPembeli.Location = New System.Drawing.Point(139, 104)
        Me.TbNamaPembeli.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.TbNamaPembeli.Name = "TbNamaPembeli"
        Me.TbNamaPembeli.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.TbNamaPembeli.PlaceholderText = "Masukkan Nama Anda"
        Me.TbNamaPembeli.SelectedText = ""
        Me.TbNamaPembeli.Size = New System.Drawing.Size(499, 32)
        Me.TbNamaPembeli.TabIndex = 40
        '
        'BtBack
        '
        Me.BtBack.BorderRadius = 8
        Me.BtBack.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.BtBack.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.BtBack.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.BtBack.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.BtBack.FillColor = System.Drawing.Color.Orange
        Me.BtBack.Font = New System.Drawing.Font("Nirmala UI", 12.0!, System.Drawing.FontStyle.Bold)
        Me.BtBack.ForeColor = System.Drawing.Color.Black
        Me.BtBack.Location = New System.Drawing.Point(37, 12)
        Me.BtBack.Name = "BtBack"
        Me.BtBack.Size = New System.Drawing.Size(100, 35)
        Me.BtBack.TabIndex = 39
        Me.BtBack.Text = "KEMBALI"
        '
        'KeranjangDgv
        '
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.White
        Me.KeranjangDgv.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.KeranjangDgv.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.KeranjangDgv.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.Orange
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.KeranjangDgv.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.KeranjangDgv.ColumnHeadersHeight = 15
        Me.KeranjangDgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing
        Me.KeranjangDgv.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.nama_menu, Me.jumlah, Me.subtotal, Me.kurangmenu, Me.hapus})
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.KeranjangDgv.DefaultCellStyle = DataGridViewCellStyle3
        Me.KeranjangDgv.GridColor = System.Drawing.Color.Silver
        Me.KeranjangDgv.Location = New System.Drawing.Point(679, 111)
        Me.KeranjangDgv.Name = "KeranjangDgv"
        Me.KeranjangDgv.RowHeadersVisible = False
        Me.KeranjangDgv.Size = New System.Drawing.Size(539, 290)
        Me.KeranjangDgv.TabIndex = 38
        Me.KeranjangDgv.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White
        Me.KeranjangDgv.ThemeStyle.AlternatingRowsStyle.Font = Nothing
        Me.KeranjangDgv.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty
        Me.KeranjangDgv.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty
        Me.KeranjangDgv.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty
        Me.KeranjangDgv.ThemeStyle.BackColor = System.Drawing.Color.White
        Me.KeranjangDgv.ThemeStyle.GridColor = System.Drawing.Color.Silver
        Me.KeranjangDgv.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.Orange
        Me.KeranjangDgv.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        Me.KeranjangDgv.ThemeStyle.HeaderStyle.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.KeranjangDgv.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.Black
        Me.KeranjangDgv.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing
        Me.KeranjangDgv.ThemeStyle.HeaderStyle.Height = 15
        Me.KeranjangDgv.ThemeStyle.ReadOnly = False
        Me.KeranjangDgv.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White
        Me.KeranjangDgv.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        Me.KeranjangDgv.ThemeStyle.RowsStyle.Font = New System.Drawing.Font("Nirmala UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.KeranjangDgv.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        Me.KeranjangDgv.ThemeStyle.RowsStyle.Height = 22
        Me.KeranjangDgv.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.KeranjangDgv.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        '
        'nama_menu
        '
        Me.nama_menu.FillWeight = 10.0!
        Me.nama_menu.HeaderText = "Menu"
        Me.nama_menu.Name = "nama_menu"
        '
        'jumlah
        '
        Me.jumlah.FillWeight = 5.0!
        Me.jumlah.HeaderText = "Jumlah"
        Me.jumlah.Name = "jumlah"
        '
        'subtotal
        '
        Me.subtotal.FillWeight = 6.0!
        Me.subtotal.HeaderText = "Subtotal"
        Me.subtotal.Name = "subtotal"
        '
        'kurangmenu
        '
        Me.kurangmenu.FillWeight = 3.979175!
        Me.kurangmenu.HeaderText = ""
        Me.kurangmenu.Name = "kurangmenu"
        Me.kurangmenu.Text = "—"
        Me.kurangmenu.UseColumnTextForButtonValue = True
        '
        'hapus
        '
        Me.hapus.FillWeight = 5.0!
        Me.hapus.HeaderText = ""
        Me.hapus.Name = "hapus"
        Me.hapus.Text = "HAPUS"
        Me.hapus.UseColumnTextForButtonValue = True
        '
        'Label7
        '
        Me.Label7.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Nirmala UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(1085, 55)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(131, 21)
        Me.Label7.TabIndex = 37
        Me.Label7.Text = "Nomor Pesanan"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Font = New System.Drawing.Font("Nirmala UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(32, 108)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(100, 21)
        Me.Label6.TabIndex = 36
        Me.Label6.Text = "Nama Anda"
        '
        'LbJenisTransaksi
        '
        Me.LbJenisTransaksi.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LbJenisTransaksi.AutoSize = True
        Me.LbJenisTransaksi.Font = New System.Drawing.Font("Nirmala UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LbJenisTransaksi.Location = New System.Drawing.Point(675, 55)
        Me.LbJenisTransaksi.Name = "LbJenisTransaksi"
        Me.LbJenisTransaksi.Size = New System.Drawing.Size(122, 21)
        Me.LbJenisTransaksi.TabIndex = 35
        Me.LbJenisTransaksi.Text = "Jenis Transaksi"
        '
        'Label5
        '
        Me.Label5.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Nirmala UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(673, 558)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(30, 21)
        Me.Label5.TabIndex = 34
        Me.Label5.Text = "Rp"
        '
        'Label4
        '
        Me.Label4.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Nirmala UI", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(673, 534)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(124, 25)
        Me.Label4.TabIndex = 33
        Me.Label4.Text = "Total Belanja"
        '
        'tempatMenu
        '
        Me.tempatMenu.AutoScroll = True
        Me.tempatMenu.Location = New System.Drawing.Point(37, 251)
        Me.tempatMenu.Name = "tempatMenu"
        Me.tempatMenu.Size = New System.Drawing.Size(601, 427)
        Me.tempatMenu.TabIndex = 32
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Nirmala UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(32, 227)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(54, 21)
        Me.Label3.TabIndex = 31
        Me.Label3.Text = "Menu"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Nirmala UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(32, 149)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(75, 21)
        Me.Label2.TabIndex = 30
        Me.Label2.Text = "Kategori"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Nirmala UI", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(31, 59)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(321, 30)
        Me.Label1.TabIndex = 29
        Me.Label1.Text = "Halo, Mau Makan Apa Hari Ini?"
        '
        'LbTotalBelanja
        '
        Me.LbTotalBelanja.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LbTotalBelanja.AutoSize = True
        Me.LbTotalBelanja.BackColor = System.Drawing.Color.Transparent
        Me.LbTotalBelanja.Font = New System.Drawing.Font("Nirmala UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LbTotalBelanja.Location = New System.Drawing.Point(722, 560)
        Me.LbTotalBelanja.Name = "LbTotalBelanja"
        Me.LbTotalBelanja.Size = New System.Drawing.Size(19, 21)
        Me.LbTotalBelanja.TabIndex = 45
        Me.LbTotalBelanja.Text = "0"
        '
        'Label8
        '
        Me.Label8.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.Color.Transparent
        Me.Label8.Font = New System.Drawing.Font("Nirmala UI", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(672, 429)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(80, 25)
        Me.Label8.TabIndex = 46
        Me.Label8.Text = "Catatan"
        '
        'TbCatatan
        '
        Me.TbCatatan.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TbCatatan.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.TbCatatan.DefaultText = ""
        Me.TbCatatan.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.TbCatatan.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.TbCatatan.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.TbCatatan.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.TbCatatan.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.TbCatatan.Font = New System.Drawing.Font("Nirmala UI", 12.0!)
        Me.TbCatatan.ForeColor = System.Drawing.Color.Black
        Me.TbCatatan.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.TbCatatan.Location = New System.Drawing.Point(677, 458)
        Me.TbCatatan.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.TbCatatan.Name = "TbCatatan"
        Me.TbCatatan.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.TbCatatan.PlaceholderText = "Tambahkan Catatan"
        Me.TbCatatan.SelectedText = ""
        Me.TbCatatan.Size = New System.Drawing.Size(541, 48)
        Me.TbCatatan.TabIndex = 47
        '
        'Pembelian
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.LightGoldenrodYellow
        Me.ClientSize = New System.Drawing.Size(1257, 702)
        Me.Controls.Add(Me.TbCatatan)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.LbTotalBelanja)
        Me.Controls.Add(Me.TbJenisTransaksi)
        Me.Controls.Add(Me.BtPesan)
        Me.Controls.Add(Me.TbInvoice2)
        Me.Controls.Add(Me.CbKategori2)
        Me.Controls.Add(Me.TbNamaPembeli)
        Me.Controls.Add(Me.BtBack)
        Me.Controls.Add(Me.KeranjangDgv)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.LbJenisTransaksi)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.tempatMenu)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Pembelian"
        Me.Text = "Pembelian"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.KeranjangDgv, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents TbJenisTransaksi As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents BtPesan As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents TbInvoice2 As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents CbKategori2 As Guna.UI2.WinForms.Guna2ComboBox
    Friend WithEvents TbNamaPembeli As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents BtBack As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents KeranjangDgv As Guna.UI2.WinForms.Guna2DataGridView
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents LbJenisTransaksi As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents tempatMenu As FlowLayoutPanel
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents LbTotalBelanja As Label
    Friend WithEvents nama_menu As DataGridViewTextBoxColumn
    Friend WithEvents jumlah As DataGridViewTextBoxColumn
    Friend WithEvents subtotal As DataGridViewTextBoxColumn
    Friend WithEvents kurangmenu As DataGridViewButtonColumn
    Friend WithEvents hapus As DataGridViewButtonColumn
    Friend WithEvents Label8 As Label
    Friend WithEvents TbCatatan As Guna.UI2.WinForms.Guna2TextBox
End Class
