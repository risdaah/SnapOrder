<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class MasterMenu
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.BukaFile = New System.Windows.Forms.OpenFileDialog()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TbIDMenu = New Guna.UI2.WinForms.Guna2TextBox()
        Me.TbIDKatMenu = New Guna.UI2.WinForms.Guna2TextBox()
        Me.BtnPilihGambar = New Guna.UI2.WinForms.Guna2Button()
        Me.CbKategoriMenu = New Guna.UI2.WinForms.Guna2ComboBox()
        Me.TbNamaMenu = New Guna.UI2.WinForms.Guna2TextBox()
        Me.TbHargaMenu = New Guna.UI2.WinForms.Guna2TextBox()
        Me.GambarMenu = New Guna.UI2.WinForms.Guna2PictureBox()
        Me.BtnTambahMenu = New Guna.UI2.WinForms.Guna2Button()
        Me.BtnUbahMenu = New Guna.UI2.WinForms.Guna2Button()
        Me.DgMenu = New Guna.UI2.WinForms.Guna2DataGridView()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TbStokMenu = New Guna.UI2.WinForms.Guna2TextBox()
        Me.id_menu = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.id_kategori_menu = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.nama_menu = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.gambar_menu = New System.Windows.Forms.DataGridViewImageColumn()
        Me.harga_menu = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Stok = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ubah = New System.Windows.Forms.DataGridViewButtonColumn()
        Me.hapus = New System.Windows.Forms.DataGridViewButtonColumn()
        CType(Me.GambarMenu, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DgMenu, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Nirmala UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(504, 105)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(99, 17)
        Me.Label7.TabIndex = 44
        Me.Label7.Text = "Kategori Menu"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Nirmala UI", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(26, 183)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(95, 20)
        Me.Label6.TabIndex = 34
        Me.Label6.Text = "Harga Menu"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Nirmala UI", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(26, 141)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(95, 20)
        Me.Label5.TabIndex = 32
        Me.Label5.Text = "Nama Menu"
        '
        'BukaFile
        '
        Me.BukaFile.FileName = "BukaFile"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Nirmala UI", 26.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(301, 21)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(278, 47)
        Me.Label1.TabIndex = 45
        Me.Label1.Text = "MASTER MENU"
        '
        'TbIDMenu
        '
        Me.TbIDMenu.BorderRadius = 6
        Me.TbIDMenu.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.TbIDMenu.DefaultText = ""
        Me.TbIDMenu.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.TbIDMenu.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.TbIDMenu.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.TbIDMenu.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.TbIDMenu.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.TbIDMenu.Font = New System.Drawing.Font("Nirmala UI", 9.0!)
        Me.TbIDMenu.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.TbIDMenu.Location = New System.Drawing.Point(29, 91)
        Me.TbIDMenu.Name = "TbIDMenu"
        Me.TbIDMenu.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.TbIDMenu.PlaceholderText = ""
        Me.TbIDMenu.SelectedText = ""
        Me.TbIDMenu.Size = New System.Drawing.Size(113, 26)
        Me.TbIDMenu.TabIndex = 46
        '
        'TbIDKatMenu
        '
        Me.TbIDKatMenu.BorderRadius = 6
        Me.TbIDKatMenu.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.TbIDKatMenu.DefaultText = ""
        Me.TbIDKatMenu.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.TbIDKatMenu.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.TbIDKatMenu.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.TbIDKatMenu.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.TbIDKatMenu.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.TbIDKatMenu.Font = New System.Drawing.Font("Nirmala UI", 9.0!)
        Me.TbIDKatMenu.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.TbIDKatMenu.Location = New System.Drawing.Point(163, 91)
        Me.TbIDKatMenu.Name = "TbIDKatMenu"
        Me.TbIDKatMenu.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.TbIDKatMenu.PlaceholderText = ""
        Me.TbIDKatMenu.ReadOnly = True
        Me.TbIDKatMenu.SelectedText = ""
        Me.TbIDKatMenu.Size = New System.Drawing.Size(113, 26)
        Me.TbIDKatMenu.TabIndex = 47
        '
        'BtnPilihGambar
        '
        Me.BtnPilihGambar.BorderRadius = 6
        Me.BtnPilihGambar.BorderThickness = 1
        Me.BtnPilihGambar.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.BtnPilihGambar.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.BtnPilihGambar.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.BtnPilihGambar.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.BtnPilihGambar.FillColor = System.Drawing.Color.White
        Me.BtnPilihGambar.Font = New System.Drawing.Font("Nirmala UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnPilihGambar.ForeColor = System.Drawing.Color.Black
        Me.BtnPilihGambar.Location = New System.Drawing.Point(758, 91)
        Me.BtnPilihGambar.Name = "BtnPilihGambar"
        Me.BtnPilihGambar.Size = New System.Drawing.Size(78, 26)
        Me.BtnPilihGambar.TabIndex = 48
        Me.BtnPilihGambar.Text = "PILIH"
        '
        'CbKategoriMenu
        '
        Me.CbKategoriMenu.BackColor = System.Drawing.Color.Transparent
        Me.CbKategoriMenu.BorderRadius = 6
        Me.CbKategoriMenu.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.CbKategoriMenu.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CbKategoriMenu.FocusedColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.CbKategoriMenu.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.CbKategoriMenu.Font = New System.Drawing.Font("Nirmala UI", 9.0!)
        Me.CbKategoriMenu.ForeColor = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(112, Byte), Integer))
        Me.CbKategoriMenu.ItemHeight = 30
        Me.CbKategoriMenu.Location = New System.Drawing.Point(466, 136)
        Me.CbKategoriMenu.Name = "CbKategoriMenu"
        Me.CbKategoriMenu.Size = New System.Drawing.Size(175, 36)
        Me.CbKategoriMenu.TabIndex = 49
        '
        'TbNamaMenu
        '
        Me.TbNamaMenu.BorderRadius = 8
        Me.TbNamaMenu.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.TbNamaMenu.DefaultText = ""
        Me.TbNamaMenu.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.TbNamaMenu.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.TbNamaMenu.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.TbNamaMenu.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.TbNamaMenu.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.TbNamaMenu.Font = New System.Drawing.Font("Nirmala UI", 9.0!)
        Me.TbNamaMenu.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.TbNamaMenu.Location = New System.Drawing.Point(125, 136)
        Me.TbNamaMenu.Name = "TbNamaMenu"
        Me.TbNamaMenu.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.TbNamaMenu.PlaceholderText = "Masukkan Nama Menu"
        Me.TbNamaMenu.SelectedText = ""
        Me.TbNamaMenu.Size = New System.Drawing.Size(246, 31)
        Me.TbNamaMenu.TabIndex = 50
        '
        'TbHargaMenu
        '
        Me.TbHargaMenu.BorderRadius = 8
        Me.TbHargaMenu.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.TbHargaMenu.DefaultText = ""
        Me.TbHargaMenu.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.TbHargaMenu.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.TbHargaMenu.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.TbHargaMenu.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.TbHargaMenu.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.TbHargaMenu.Font = New System.Drawing.Font("Nirmala UI", 9.0!)
        Me.TbHargaMenu.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.TbHargaMenu.Location = New System.Drawing.Point(125, 178)
        Me.TbHargaMenu.Name = "TbHargaMenu"
        Me.TbHargaMenu.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.TbHargaMenu.PlaceholderText = "Masukkan Harga Menu"
        Me.TbHargaMenu.SelectedText = ""
        Me.TbHargaMenu.Size = New System.Drawing.Size(246, 31)
        Me.TbHargaMenu.TabIndex = 51
        '
        'GambarMenu
        '
        Me.GambarMenu.BackColor = System.Drawing.Color.Transparent
        Me.GambarMenu.BackgroundImage = Global.SnapOrder.My.Resources.Resources.image_gallery
        Me.GambarMenu.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.GambarMenu.BorderRadius = 6
        Me.GambarMenu.FillColor = System.Drawing.Color.Transparent
        Me.GambarMenu.ImageRotate = 0!
        Me.GambarMenu.Location = New System.Drawing.Point(720, 123)
        Me.GambarMenu.Name = "GambarMenu"
        Me.GambarMenu.Size = New System.Drawing.Size(150, 150)
        Me.GambarMenu.TabIndex = 52
        Me.GambarMenu.TabStop = False
        '
        'BtnTambahMenu
        '
        Me.BtnTambahMenu.BorderColor = System.Drawing.Color.Transparent
        Me.BtnTambahMenu.BorderRadius = 6
        Me.BtnTambahMenu.BorderThickness = 1
        Me.BtnTambahMenu.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.BtnTambahMenu.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.BtnTambahMenu.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.BtnTambahMenu.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.BtnTambahMenu.FillColor = System.Drawing.Color.ForestGreen
        Me.BtnTambahMenu.Font = New System.Drawing.Font("Nirmala UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnTambahMenu.ForeColor = System.Drawing.Color.White
        Me.BtnTambahMenu.Location = New System.Drawing.Point(27, 243)
        Me.BtnTambahMenu.Name = "BtnTambahMenu"
        Me.BtnTambahMenu.Size = New System.Drawing.Size(100, 30)
        Me.BtnTambahMenu.TabIndex = 53
        Me.BtnTambahMenu.Text = "TAMBAH"
        '
        'BtnUbahMenu
        '
        Me.BtnUbahMenu.BorderColor = System.Drawing.Color.Transparent
        Me.BtnUbahMenu.BorderRadius = 6
        Me.BtnUbahMenu.BorderThickness = 1
        Me.BtnUbahMenu.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.BtnUbahMenu.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.BtnUbahMenu.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.BtnUbahMenu.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.BtnUbahMenu.FillColor = System.Drawing.Color.RoyalBlue
        Me.BtnUbahMenu.Font = New System.Drawing.Font("Nirmala UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnUbahMenu.ForeColor = System.Drawing.Color.White
        Me.BtnUbahMenu.Location = New System.Drawing.Point(163, 243)
        Me.BtnUbahMenu.Name = "BtnUbahMenu"
        Me.BtnUbahMenu.Size = New System.Drawing.Size(100, 30)
        Me.BtnUbahMenu.TabIndex = 54
        Me.BtnUbahMenu.Text = "UBAH"
        '
        'DgMenu
        '
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.DgMenu.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.DgMenu.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.None
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.Orange
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Nirmala UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DgMenu.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.DgMenu.ColumnHeadersHeight = 15
        Me.DgMenu.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing
        Me.DgMenu.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.id_menu, Me.id_kategori_menu, Me.nama_menu, Me.gambar_menu, Me.harga_menu, Me.Stok, Me.ubah, Me.hapus})
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Nirmala UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DgMenu.DefaultCellStyle = DataGridViewCellStyle3
        Me.DgMenu.GridColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.DgMenu.Location = New System.Drawing.Point(27, 297)
        Me.DgMenu.Name = "DgMenu"
        Me.DgMenu.RowHeadersVisible = False
        Me.DgMenu.Size = New System.Drawing.Size(897, 276)
        Me.DgMenu.TabIndex = 55
        Me.DgMenu.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White
        Me.DgMenu.ThemeStyle.AlternatingRowsStyle.Font = Nothing
        Me.DgMenu.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty
        Me.DgMenu.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty
        Me.DgMenu.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty
        Me.DgMenu.ThemeStyle.BackColor = System.Drawing.Color.White
        Me.DgMenu.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.DgMenu.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.Orange
        Me.DgMenu.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        Me.DgMenu.ThemeStyle.HeaderStyle.Font = New System.Drawing.Font("Nirmala UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DgMenu.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.Black
        Me.DgMenu.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing
        Me.DgMenu.ThemeStyle.HeaderStyle.Height = 15
        Me.DgMenu.ThemeStyle.ReadOnly = False
        Me.DgMenu.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White
        Me.DgMenu.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        Me.DgMenu.ThemeStyle.RowsStyle.Font = New System.Drawing.Font("Nirmala UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DgMenu.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        Me.DgMenu.ThemeStyle.RowsStyle.Height = 22
        Me.DgMenu.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.DgMenu.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Nirmala UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(519, 192)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(74, 17)
        Me.Label2.TabIndex = 56
        Me.Label2.Text = "Stok Menu"
        '
        'TbStokMenu
        '
        Me.TbStokMenu.BorderRadius = 6
        Me.TbStokMenu.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.TbStokMenu.DefaultText = ""
        Me.TbStokMenu.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.TbStokMenu.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.TbStokMenu.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.TbStokMenu.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.TbStokMenu.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.TbStokMenu.Font = New System.Drawing.Font("Nirmala UI", 9.0!)
        Me.TbStokMenu.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.TbStokMenu.Location = New System.Drawing.Point(490, 212)
        Me.TbStokMenu.Name = "TbStokMenu"
        Me.TbStokMenu.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.TbStokMenu.PlaceholderText = ""
        Me.TbStokMenu.SelectedText = ""
        Me.TbStokMenu.Size = New System.Drawing.Size(125, 26)
        Me.TbStokMenu.TabIndex = 57
        '
        'id_menu
        '
        Me.id_menu.HeaderText = "ID Menu"
        Me.id_menu.Name = "id_menu"
        '
        'id_kategori_menu
        '
        Me.id_kategori_menu.HeaderText = "ID Kategori Makanan"
        Me.id_kategori_menu.Name = "id_kategori_menu"
        Me.id_kategori_menu.Width = 150
        '
        'nama_menu
        '
        Me.nama_menu.HeaderText = "Nama Menu"
        Me.nama_menu.Name = "nama_menu"
        Me.nama_menu.Width = 130
        '
        'gambar_menu
        '
        Me.gambar_menu.FillWeight = 125.0!
        Me.gambar_menu.HeaderText = "Gambar Menu"
        Me.gambar_menu.Name = "gambar_menu"
        Me.gambar_menu.ReadOnly = True
        Me.gambar_menu.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.gambar_menu.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.gambar_menu.Width = 153
        '
        'harga_menu
        '
        Me.harga_menu.HeaderText = "Harga Menu"
        Me.harga_menu.Name = "harga_menu"
        '
        'Stok
        '
        Me.Stok.HeaderText = "stok"
        Me.Stok.Name = "Stok"
        Me.Stok.Width = 50
        '
        'ubah
        '
        Me.ubah.HeaderText = ""
        Me.ubah.Name = "ubah"
        Me.ubah.Text = "UBAH"
        Me.ubah.UseColumnTextForButtonValue = True
        Me.ubah.Width = 105
        '
        'hapus
        '
        Me.hapus.HeaderText = ""
        Me.hapus.Name = "hapus"
        Me.hapus.Text = "HAPUS"
        Me.hapus.UseColumnTextForButtonValue = True
        Me.hapus.Width = 105
        '
        'MasterMenu
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.MenuBar
        Me.ClientSize = New System.Drawing.Size(936, 595)
        Me.Controls.Add(Me.TbStokMenu)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.DgMenu)
        Me.Controls.Add(Me.BtnUbahMenu)
        Me.Controls.Add(Me.BtnTambahMenu)
        Me.Controls.Add(Me.GambarMenu)
        Me.Controls.Add(Me.TbHargaMenu)
        Me.Controls.Add(Me.TbNamaMenu)
        Me.Controls.Add(Me.CbKategoriMenu)
        Me.Controls.Add(Me.BtnPilihGambar)
        Me.Controls.Add(Me.TbIDKatMenu)
        Me.Controls.Add(Me.TbIDMenu)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Name = "MasterMenu"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "MasterMenu"
        CType(Me.GambarMenu, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DgMenu, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents BukaFile As OpenFileDialog
    Friend WithEvents Label1 As Label
    Friend WithEvents TbIDMenu As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents TbIDKatMenu As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents BtnPilihGambar As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents CbKategoriMenu As Guna.UI2.WinForms.Guna2ComboBox
    Friend WithEvents TbNamaMenu As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents TbHargaMenu As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents GambarMenu As Guna.UI2.WinForms.Guna2PictureBox
    Friend WithEvents BtnTambahMenu As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents BtnUbahMenu As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents DgMenu As Guna.UI2.WinForms.Guna2DataGridView
    Friend WithEvents Label2 As Label
    Friend WithEvents TbStokMenu As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents id_menu As DataGridViewTextBoxColumn
    Friend WithEvents id_kategori_menu As DataGridViewTextBoxColumn
    Friend WithEvents nama_menu As DataGridViewTextBoxColumn
    Friend WithEvents gambar_menu As DataGridViewImageColumn
    Friend WithEvents harga_menu As DataGridViewTextBoxColumn
    Friend WithEvents Stok As DataGridViewTextBoxColumn
    Friend WithEvents ubah As DataGridViewButtonColumn
    Friend WithEvents hapus As DataGridViewButtonColumn
End Class
