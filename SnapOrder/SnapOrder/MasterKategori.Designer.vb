<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class MasterKategori
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
        Me.components = New System.ComponentModel.Container()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.ErrorProvider1 = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TbKategori = New Guna.UI2.WinForms.Guna2TextBox()
        Me.TbIDKategori = New Guna.UI2.WinForms.Guna2TextBox()
        Me.BtTambah = New Guna.UI2.WinForms.Guna2Button()
        Me.BtUbah = New Guna.UI2.WinForms.Guna2Button()
        Me.DgKategori = New Guna.UI2.WinForms.Guna2DataGridView()
        Me.id_kategori = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.kategori = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ubah = New System.Windows.Forms.DataGridViewButtonColumn()
        Me.hapus = New System.Windows.Forms.DataGridViewButtonColumn()
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DgKategori, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Nirmala UI", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(19, 96)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(145, 25)
        Me.Label3.TabIndex = 18
        Me.Label3.Text = "Nama Kategori"
        '
        'ErrorProvider1
        '
        Me.ErrorProvider1.ContainerControl = Me
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Nirmala UI", 26.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(152, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(331, 47)
        Me.Label1.TabIndex = 26
        Me.Label1.Text = "KELOLA KATEGORI"
        '
        'TbKategori
        '
        Me.TbKategori.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.TbKategori.BorderRadius = 6
        Me.TbKategori.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.TbKategori.DefaultText = ""
        Me.TbKategori.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.TbKategori.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.TbKategori.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.TbKategori.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.TbKategori.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.TbKategori.Font = New System.Drawing.Font("Nirmala UI", 9.0!)
        Me.TbKategori.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.TbKategori.Location = New System.Drawing.Point(173, 92)
        Me.TbKategori.Name = "TbKategori"
        Me.TbKategori.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.TbKategori.PlaceholderText = "Masukkan Nama Kategori"
        Me.TbKategori.SelectedText = ""
        Me.TbKategori.Size = New System.Drawing.Size(200, 29)
        Me.TbKategori.TabIndex = 27
        '
        'TbIDKategori
        '
        Me.TbIDKategori.BorderRadius = 6
        Me.TbIDKategori.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.TbIDKategori.DefaultText = ""
        Me.TbIDKategori.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.TbIDKategori.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.TbIDKategori.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.TbIDKategori.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.TbIDKategori.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.TbIDKategori.Font = New System.Drawing.Font("Nirmala UI", 9.0!)
        Me.TbIDKategori.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.TbIDKategori.Location = New System.Drawing.Point(531, 92)
        Me.TbIDKategori.Name = "TbIDKategori"
        Me.TbIDKategori.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.TbIDKategori.PlaceholderText = ""
        Me.TbIDKategori.ReadOnly = True
        Me.TbIDKategori.SelectedText = ""
        Me.TbIDKategori.Size = New System.Drawing.Size(110, 29)
        Me.TbIDKategori.TabIndex = 28
        '
        'BtTambah
        '
        Me.BtTambah.BackColor = System.Drawing.Color.Transparent
        Me.BtTambah.BorderColor = System.Drawing.Color.Transparent
        Me.BtTambah.BorderRadius = 6
        Me.BtTambah.BorderThickness = 1
        Me.BtTambah.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.BtTambah.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.BtTambah.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.BtTambah.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.BtTambah.FillColor = System.Drawing.Color.ForestGreen
        Me.BtTambah.Font = New System.Drawing.Font("Nirmala UI", 9.75!, System.Drawing.FontStyle.Bold)
        Me.BtTambah.ForeColor = System.Drawing.Color.White
        Me.BtTambah.Location = New System.Drawing.Point(24, 150)
        Me.BtTambah.Name = "BtTambah"
        Me.BtTambah.Size = New System.Drawing.Size(104, 30)
        Me.BtTambah.TabIndex = 29
        Me.BtTambah.Text = "TAMBAH"
        '
        'BtUbah
        '
        Me.BtUbah.BorderColor = System.Drawing.Color.Transparent
        Me.BtUbah.BorderRadius = 6
        Me.BtUbah.BorderThickness = 1
        Me.BtUbah.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.BtUbah.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.BtUbah.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.BtUbah.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.BtUbah.FillColor = System.Drawing.Color.RoyalBlue
        Me.BtUbah.Font = New System.Drawing.Font("Nirmala UI", 9.75!, System.Drawing.FontStyle.Bold)
        Me.BtUbah.ForeColor = System.Drawing.Color.White
        Me.BtUbah.Location = New System.Drawing.Point(160, 150)
        Me.BtUbah.Name = "BtUbah"
        Me.BtUbah.Size = New System.Drawing.Size(104, 30)
        Me.BtUbah.TabIndex = 30
        Me.BtUbah.Text = "UBAH"
        '
        'DgKategori
        '
        Me.DgKategori.AllowUserToOrderColumns = True
        Me.DgKategori.AllowUserToResizeColumns = False
        DataGridViewCellStyle4.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.DgKategori.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle4
        Me.DgKategori.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.None
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle5.BackColor = System.Drawing.Color.Orange
        DataGridViewCellStyle5.Font = New System.Drawing.Font("Nirmala UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle5.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DgKategori.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle5
        Me.DgKategori.ColumnHeadersHeight = 15
        Me.DgKategori.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing
        Me.DgKategori.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.id_kategori, Me.kategori, Me.ubah, Me.hapus})
        DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle6.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle6.Font = New System.Drawing.Font("Nirmala UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle6.ForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        DataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        DataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DgKategori.DefaultCellStyle = DataGridViewCellStyle6
        Me.DgKategori.GridColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.DgKategori.Location = New System.Drawing.Point(21, 196)
        Me.DgKategori.Name = "DgKategori"
        Me.DgKategori.RowHeadersVisible = False
        Me.DgKategori.Size = New System.Drawing.Size(620, 250)
        Me.DgKategori.TabIndex = 31
        Me.DgKategori.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White
        Me.DgKategori.ThemeStyle.AlternatingRowsStyle.Font = Nothing
        Me.DgKategori.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty
        Me.DgKategori.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty
        Me.DgKategori.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty
        Me.DgKategori.ThemeStyle.BackColor = System.Drawing.Color.White
        Me.DgKategori.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.DgKategori.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.Orange
        Me.DgKategori.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        Me.DgKategori.ThemeStyle.HeaderStyle.Font = New System.Drawing.Font("Nirmala UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DgKategori.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.Black
        Me.DgKategori.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing
        Me.DgKategori.ThemeStyle.HeaderStyle.Height = 15
        Me.DgKategori.ThemeStyle.ReadOnly = False
        Me.DgKategori.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White
        Me.DgKategori.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        Me.DgKategori.ThemeStyle.RowsStyle.Font = New System.Drawing.Font("Nirmala UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DgKategori.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        Me.DgKategori.ThemeStyle.RowsStyle.Height = 22
        Me.DgKategori.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.DgKategori.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        '
        'id_kategori
        '
        Me.id_kategori.HeaderText = "ID Kategori"
        Me.id_kategori.Name = "id_kategori"
        Me.id_kategori.Width = 150
        '
        'kategori
        '
        Me.kategori.HeaderText = "Kategori"
        Me.kategori.Name = "kategori"
        Me.kategori.Width = 250
        '
        'ubah
        '
        Me.ubah.HeaderText = ""
        Me.ubah.Name = "ubah"
        Me.ubah.Text = "UBAH"
        Me.ubah.UseColumnTextForButtonValue = True
        Me.ubah.Width = 110
        '
        'hapus
        '
        Me.hapus.HeaderText = ""
        Me.hapus.Name = "hapus"
        Me.hapus.Text = "HAPUS"
        Me.hapus.UseColumnTextForButtonValue = True
        Me.hapus.Width = 110
        '
        'MasterKategori
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.MenuBar
        Me.ClientSize = New System.Drawing.Size(665, 473)
        Me.Controls.Add(Me.DgKategori)
        Me.Controls.Add(Me.BtUbah)
        Me.Controls.Add(Me.BtTambah)
        Me.Controls.Add(Me.TbIDKategori)
        Me.Controls.Add(Me.TbKategori)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label3)
        Me.Name = "MasterKategori"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "MasterKategori"
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DgKategori, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label3 As Label
    Friend WithEvents ErrorProvider1 As ErrorProvider
    Friend WithEvents Label1 As Label
    Friend WithEvents TbIDKategori As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents TbKategori As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents BtUbah As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents BtTambah As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents DgKategori As Guna.UI2.WinForms.Guna2DataGridView
    Friend WithEvents id_kategori As DataGridViewTextBoxColumn
    Friend WithEvents kategori As DataGridViewTextBoxColumn
    Friend WithEvents ubah As DataGridViewButtonColumn
    Friend WithEvents hapus As DataGridViewButtonColumn
End Class
