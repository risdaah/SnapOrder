<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MasterOwner
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
        Dim DataGridViewCellStyle7 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle8 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle9 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.ErrorProvider1 = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.TbIDAdmin = New Guna.UI2.WinForms.Guna2TextBox()
        Me.TbNama = New Guna.UI2.WinForms.Guna2TextBox()
        Me.TbEmail = New Guna.UI2.WinForms.Guna2TextBox()
        Me.TbPassword = New Guna.UI2.WinForms.Guna2TextBox()
        Me.BtnUbahOwner = New Guna.UI2.WinForms.Guna2Button()
        Me.BtnTambahOwner = New Guna.UI2.WinForms.Guna2Button()
        Me.DgAdmin = New Guna.UI2.WinForms.Guna2DataGridView()
        Me.id_user = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.nama = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.password = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.email = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ubah = New System.Windows.Forms.DataGridViewButtonColumn()
        Me.hapus = New System.Windows.Forms.DataGridViewButtonColumn()
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DgAdmin, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label4
        '
        Me.Label4.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Nirmala UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(37, 189)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(81, 21)
        Me.Label4.TabIndex = 48
        Me.Label4.Text = "Password"
        '
        'Label2
        '
        Me.Label2.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Nirmala UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(37, 150)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(53, 21)
        Me.Label2.TabIndex = 46
        Me.Label2.Text = "Email"
        '
        'Label1
        '
        Me.Label1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Nirmala UI", 26.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(362, 15)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(304, 47)
        Me.Label1.TabIndex = 45
        Me.Label1.Text = "MASTER OWNER"
        '
        'Label3
        '
        Me.Label3.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Nirmala UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(37, 112)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(110, 21)
        Me.Label3.TabIndex = 39
        Me.Label3.Text = "Nama Owner"
        '
        'ErrorProvider1
        '
        Me.ErrorProvider1.ContainerControl = Me
        '
        'TbIDAdmin
        '
        Me.TbIDAdmin.BorderRadius = 6
        Me.TbIDAdmin.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.TbIDAdmin.DefaultText = ""
        Me.TbIDAdmin.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.TbIDAdmin.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.TbIDAdmin.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.TbIDAdmin.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.TbIDAdmin.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.TbIDAdmin.Font = New System.Drawing.Font("Nirmala UI", 9.0!)
        Me.TbIDAdmin.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.TbIDAdmin.Location = New System.Drawing.Point(40, 74)
        Me.TbIDAdmin.Name = "TbIDAdmin"
        Me.TbIDAdmin.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.TbIDAdmin.PlaceholderText = ""
        Me.TbIDAdmin.ReadOnly = True
        Me.TbIDAdmin.SelectedText = ""
        Me.TbIDAdmin.Size = New System.Drawing.Size(99, 26)
        Me.TbIDAdmin.TabIndex = 50
        '
        'TbNama
        '
        Me.TbNama.BorderRadius = 6
        Me.TbNama.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.TbNama.DefaultText = ""
        Me.TbNama.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.TbNama.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.TbNama.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.TbNama.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.TbNama.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.TbNama.Font = New System.Drawing.Font("Nirmala UI", 9.0!)
        Me.TbNama.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.TbNama.Location = New System.Drawing.Point(173, 112)
        Me.TbNama.Name = "TbNama"
        Me.TbNama.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.TbNama.PlaceholderText = "Masukkan Nama"
        Me.TbNama.SelectedText = ""
        Me.TbNama.Size = New System.Drawing.Size(340, 26)
        Me.TbNama.TabIndex = 51
        '
        'TbEmail
        '
        Me.TbEmail.BorderRadius = 6
        Me.TbEmail.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.TbEmail.DefaultText = ""
        Me.TbEmail.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.TbEmail.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.TbEmail.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.TbEmail.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.TbEmail.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.TbEmail.Font = New System.Drawing.Font("Nirmala UI", 9.0!)
        Me.TbEmail.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.TbEmail.Location = New System.Drawing.Point(173, 150)
        Me.TbEmail.Name = "TbEmail"
        Me.TbEmail.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.TbEmail.PlaceholderText = "Masukkan Email"
        Me.TbEmail.SelectedText = ""
        Me.TbEmail.Size = New System.Drawing.Size(340, 26)
        Me.TbEmail.TabIndex = 52
        '
        'TbPassword
        '
        Me.TbPassword.BorderRadius = 6
        Me.TbPassword.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.TbPassword.DefaultText = ""
        Me.TbPassword.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.TbPassword.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.TbPassword.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.TbPassword.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.TbPassword.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.TbPassword.Font = New System.Drawing.Font("Nirmala UI", 9.0!)
        Me.TbPassword.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.TbPassword.Location = New System.Drawing.Point(173, 189)
        Me.TbPassword.Name = "TbPassword"
        Me.TbPassword.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.TbPassword.PlaceholderText = "Masukkan Password"
        Me.TbPassword.SelectedText = ""
        Me.TbPassword.Size = New System.Drawing.Size(340, 26)
        Me.TbPassword.TabIndex = 53
        '
        'BtnUbahOwner
        '
        Me.BtnUbahOwner.BorderColor = System.Drawing.Color.RoyalBlue
        Me.BtnUbahOwner.BorderRadius = 8
        Me.BtnUbahOwner.BorderThickness = 1
        Me.BtnUbahOwner.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.BtnUbahOwner.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.BtnUbahOwner.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.BtnUbahOwner.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.BtnUbahOwner.FillColor = System.Drawing.Color.RoyalBlue
        Me.BtnUbahOwner.Font = New System.Drawing.Font("Nirmala UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnUbahOwner.ForeColor = System.Drawing.Color.White
        Me.BtnUbahOwner.Location = New System.Drawing.Point(34, 279)
        Me.BtnUbahOwner.Name = "BtnUbahOwner"
        Me.BtnUbahOwner.Size = New System.Drawing.Size(100, 26)
        Me.BtnUbahOwner.TabIndex = 54
        Me.BtnUbahOwner.Text = "UBAH"
        '
        'BtnTambahOwner
        '
        Me.BtnTambahOwner.BorderColor = System.Drawing.Color.ForestGreen
        Me.BtnTambahOwner.BorderRadius = 8
        Me.BtnTambahOwner.BorderThickness = 1
        Me.BtnTambahOwner.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.BtnTambahOwner.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.BtnTambahOwner.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.BtnTambahOwner.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.BtnTambahOwner.FillColor = System.Drawing.Color.ForestGreen
        Me.BtnTambahOwner.Font = New System.Drawing.Font("Nirmala UI", 9.0!, System.Drawing.FontStyle.Bold)
        Me.BtnTambahOwner.ForeColor = System.Drawing.Color.White
        Me.BtnTambahOwner.Location = New System.Drawing.Point(34, 234)
        Me.BtnTambahOwner.Name = "BtnTambahOwner"
        Me.BtnTambahOwner.Size = New System.Drawing.Size(100, 26)
        Me.BtnTambahOwner.TabIndex = 55
        Me.BtnTambahOwner.Text = "TAMBAH"
        '
        'DgAdmin
        '
        DataGridViewCellStyle7.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.DgAdmin.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle7
        Me.DgAdmin.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.None
        DataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle8.BackColor = System.Drawing.Color.Orange
        DataGridViewCellStyle8.Font = New System.Drawing.Font("Nirmala UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle8.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DgAdmin.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle8
        Me.DgAdmin.ColumnHeadersHeight = 15
        Me.DgAdmin.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing
        Me.DgAdmin.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.id_user, Me.nama, Me.password, Me.email, Me.ubah, Me.hapus})
        DataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle9.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle9.Font = New System.Drawing.Font("Nirmala UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle9.ForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        DataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle9.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        DataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DgAdmin.DefaultCellStyle = DataGridViewCellStyle9
        Me.DgAdmin.GridColor = System.Drawing.Color.LightGray
        Me.DgAdmin.Location = New System.Drawing.Point(173, 234)
        Me.DgAdmin.Name = "DgAdmin"
        Me.DgAdmin.RowHeadersVisible = False
        Me.DgAdmin.Size = New System.Drawing.Size(775, 216)
        Me.DgAdmin.TabIndex = 56
        Me.DgAdmin.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White
        Me.DgAdmin.ThemeStyle.AlternatingRowsStyle.Font = Nothing
        Me.DgAdmin.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty
        Me.DgAdmin.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty
        Me.DgAdmin.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty
        Me.DgAdmin.ThemeStyle.BackColor = System.Drawing.Color.White
        Me.DgAdmin.ThemeStyle.GridColor = System.Drawing.Color.LightGray
        Me.DgAdmin.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.Orange
        Me.DgAdmin.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        Me.DgAdmin.ThemeStyle.HeaderStyle.Font = New System.Drawing.Font("Nirmala UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DgAdmin.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.Black
        Me.DgAdmin.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing
        Me.DgAdmin.ThemeStyle.HeaderStyle.Height = 15
        Me.DgAdmin.ThemeStyle.ReadOnly = False
        Me.DgAdmin.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White
        Me.DgAdmin.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        Me.DgAdmin.ThemeStyle.RowsStyle.Font = New System.Drawing.Font("Nirmala UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DgAdmin.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        Me.DgAdmin.ThemeStyle.RowsStyle.Height = 22
        Me.DgAdmin.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.DgAdmin.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        '
        'id_user
        '
        Me.id_user.HeaderText = "ID User"
        Me.id_user.Name = "id_user"
        Me.id_user.Width = 95
        '
        'nama
        '
        Me.nama.HeaderText = "Nama"
        Me.nama.Name = "nama"
        Me.nama.Width = 200
        '
        'password
        '
        Me.password.HeaderText = "Password"
        Me.password.Name = "password"
        Me.password.Width = 130
        '
        'email
        '
        Me.email.HeaderText = "Email"
        Me.email.Name = "email"
        Me.email.Width = 150
        '
        'ubah
        '
        Me.ubah.HeaderText = ""
        Me.ubah.Name = "ubah"
        Me.ubah.Text = "UBAH"
        Me.ubah.UseColumnTextForButtonValue = True
        '
        'hapus
        '
        Me.hapus.HeaderText = ""
        Me.hapus.Name = "hapus"
        Me.hapus.Text = "HAPUS"
        Me.hapus.UseColumnTextForButtonValue = True
        '
        'MasterOwner
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.MenuBar
        Me.ClientSize = New System.Drawing.Size(989, 508)
        Me.Controls.Add(Me.DgAdmin)
        Me.Controls.Add(Me.BtnTambahOwner)
        Me.Controls.Add(Me.BtnUbahOwner)
        Me.Controls.Add(Me.TbPassword)
        Me.Controls.Add(Me.TbEmail)
        Me.Controls.Add(Me.TbNama)
        Me.Controls.Add(Me.TbIDAdmin)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label3)
        Me.Name = "MasterOwner"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "MasterOwner"
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DgAdmin, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label4 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents ErrorProvider1 As ErrorProvider
    Friend WithEvents TbPassword As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents TbEmail As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents TbNama As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents TbIDAdmin As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents BtnTambahOwner As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents BtnUbahOwner As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents DgAdmin As Guna.UI2.WinForms.Guna2DataGridView
    Friend WithEvents id_user As DataGridViewTextBoxColumn
    Friend WithEvents nama As DataGridViewTextBoxColumn
    Friend WithEvents password As DataGridViewTextBoxColumn
    Friend WithEvents email As DataGridViewTextBoxColumn
    Friend WithEvents ubah As DataGridViewButtonColumn
    Friend WithEvents hapus As DataGridViewButtonColumn
End Class
