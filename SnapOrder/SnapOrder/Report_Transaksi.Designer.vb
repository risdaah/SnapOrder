<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Report_Transaksi
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
        Me.CrystalReportViewer1 = New CrystalDecisions.Windows.Forms.CrystalReportViewer()
        Me.BtnTampilLaporanDariTanggal = New Guna.UI2.WinForms.Guna2Button()
        Me.PilihTgl = New Guna.UI2.WinForms.Guna2DateTimePicker()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.BtnTampilkanAllLaporan = New Guna.UI2.WinForms.Guna2Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.CbBulan = New Guna.UI2.WinForms.Guna2ComboBox()
        Me.CbTahun = New Guna.UI2.WinForms.Guna2ComboBox()
        Me.BtnTampilLaporanBln = New Guna.UI2.WinForms.Guna2Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'CrystalReportViewer1
        '
        Me.CrystalReportViewer1.ActiveViewIndex = -1
        Me.CrystalReportViewer1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.CrystalReportViewer1.Cursor = System.Windows.Forms.Cursors.Default
        Me.CrystalReportViewer1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.CrystalReportViewer1.Location = New System.Drawing.Point(0, 0)
        Me.CrystalReportViewer1.Name = "CrystalReportViewer1"
        Me.CrystalReportViewer1.Size = New System.Drawing.Size(801, 659)
        Me.CrystalReportViewer1.TabIndex = 0
        '
        'BtnTampilLaporanDariTanggal
        '
        Me.BtnTampilLaporanDariTanggal.BackColor = System.Drawing.Color.Transparent
        Me.BtnTampilLaporanDariTanggal.BorderRadius = 10
        Me.BtnTampilLaporanDariTanggal.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.BtnTampilLaporanDariTanggal.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.BtnTampilLaporanDariTanggal.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.BtnTampilLaporanDariTanggal.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.BtnTampilLaporanDariTanggal.FillColor = System.Drawing.Color.Orange
        Me.BtnTampilLaporanDariTanggal.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnTampilLaporanDariTanggal.ForeColor = System.Drawing.Color.Black
        Me.BtnTampilLaporanDariTanggal.Location = New System.Drawing.Point(55, 155)
        Me.BtnTampilLaporanDariTanggal.Name = "BtnTampilLaporanDariTanggal"
        Me.BtnTampilLaporanDariTanggal.Size = New System.Drawing.Size(84, 45)
        Me.BtnTampilLaporanDariTanggal.TabIndex = 3
        Me.BtnTampilLaporanDariTanggal.Text = "Tampilkan Laporan"
        '
        'PilihTgl
        '
        Me.PilihTgl.BackColor = System.Drawing.Color.Transparent
        Me.PilihTgl.BorderRadius = 5
        Me.PilihTgl.Checked = True
        Me.PilihTgl.FillColor = System.Drawing.SystemColors.ButtonFace
        Me.PilihTgl.Font = New System.Drawing.Font("Segoe UI Semibold", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PilihTgl.Format = System.Windows.Forms.DateTimePickerFormat.[Long]
        Me.PilihTgl.Location = New System.Drawing.Point(3, 106)
        Me.PilihTgl.MaxDate = New Date(9998, 12, 31, 0, 0, 0, 0)
        Me.PilihTgl.MinDate = New Date(1753, 1, 1, 0, 0, 0, 0)
        Me.PilihTgl.Name = "PilihTgl"
        Me.PilihTgl.Size = New System.Drawing.Size(197, 36)
        Me.PilihTgl.TabIndex = 4
        Me.PilihTgl.Value = New Date(2023, 12, 5, 9, 20, 25, 0)
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.White
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(22, 503)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(157, 42)
        Me.Label1.TabIndex = 8
        Me.Label1.Text = "Tampilkan Seluruh " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Laporan"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'BtnTampilkanAllLaporan
        '
        Me.BtnTampilkanAllLaporan.BackColor = System.Drawing.Color.Transparent
        Me.BtnTampilkanAllLaporan.BorderRadius = 10
        Me.BtnTampilkanAllLaporan.BorderStyle = System.Drawing.Drawing2D.DashStyle.Dash
        Me.BtnTampilkanAllLaporan.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.BtnTampilkanAllLaporan.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.BtnTampilkanAllLaporan.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.BtnTampilkanAllLaporan.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.BtnTampilkanAllLaporan.FillColor = System.Drawing.Color.SeaGreen
        Me.BtnTampilkanAllLaporan.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnTampilkanAllLaporan.ForeColor = System.Drawing.Color.White
        Me.BtnTampilkanAllLaporan.Location = New System.Drawing.Point(55, 548)
        Me.BtnTampilkanAllLaporan.Name = "BtnTampilkanAllLaporan"
        Me.BtnTampilkanAllLaporan.Size = New System.Drawing.Size(84, 45)
        Me.BtnTampilkanAllLaporan.TabIndex = 9
        Me.BtnTampilkanAllLaporan.Text = "Tampilkan Laporan"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.White
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(22, 51)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(156, 42)
        Me.Label2.TabIndex = 10
        Me.Label2.Text = "Tampilkan Laporan" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Sesuai Tanggal"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'CbBulan
        '
        Me.CbBulan.BackColor = System.Drawing.Color.Transparent
        Me.CbBulan.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.CbBulan.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CbBulan.FocusedColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.CbBulan.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.CbBulan.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.CbBulan.ForeColor = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(112, Byte), Integer))
        Me.CbBulan.ItemHeight = 30
        Me.CbBulan.Items.AddRange(New Object() {"Januari", "Februari", "Maret", "April", "Mei", "Juni", "Juli", "Agustus", "September", "Oktober", "November", "Desember"})
        Me.CbBulan.Location = New System.Drawing.Point(26, 312)
        Me.CbBulan.Name = "CbBulan"
        Me.CbBulan.Size = New System.Drawing.Size(140, 36)
        Me.CbBulan.TabIndex = 11
        '
        'CbTahun
        '
        Me.CbTahun.BackColor = System.Drawing.Color.Transparent
        Me.CbTahun.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.CbTahun.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CbTahun.FocusedColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.CbTahun.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.CbTahun.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.CbTahun.ForeColor = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(112, Byte), Integer))
        Me.CbTahun.ItemHeight = 30
        Me.CbTahun.Items.AddRange(New Object() {"2023", "2024", "2025"})
        Me.CbTahun.Location = New System.Drawing.Point(26, 364)
        Me.CbTahun.Name = "CbTahun"
        Me.CbTahun.Size = New System.Drawing.Size(140, 36)
        Me.CbTahun.TabIndex = 12
        '
        'BtnTampilLaporanBln
        '
        Me.BtnTampilLaporanBln.BackColor = System.Drawing.Color.Transparent
        Me.BtnTampilLaporanBln.BorderRadius = 10
        Me.BtnTampilLaporanBln.BorderStyle = System.Drawing.Drawing2D.DashStyle.Dash
        Me.BtnTampilLaporanBln.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.BtnTampilLaporanBln.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.BtnTampilLaporanBln.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.BtnTampilLaporanBln.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.BtnTampilLaporanBln.FillColor = System.Drawing.Color.RoyalBlue
        Me.BtnTampilLaporanBln.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnTampilLaporanBln.ForeColor = System.Drawing.Color.White
        Me.BtnTampilLaporanBln.Location = New System.Drawing.Point(55, 406)
        Me.BtnTampilLaporanBln.Name = "BtnTampilLaporanBln"
        Me.BtnTampilLaporanBln.Size = New System.Drawing.Size(84, 45)
        Me.BtnTampilLaporanBln.TabIndex = 13
        Me.BtnTampilLaporanBln.Text = "Tampilkan Laporan"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.White
        Me.Label3.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(6, 256)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(191, 42)
        Me.Label3.TabIndex = 14
        Me.Label3.Text = "Tampilkan Laporan" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Sesuai Bulan dan Tahun"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Report_Transaksi
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(801, 659)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.BtnTampilLaporanBln)
        Me.Controls.Add(Me.CbTahun)
        Me.Controls.Add(Me.CbBulan)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.BtnTampilkanAllLaporan)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.PilihTgl)
        Me.Controls.Add(Me.BtnTampilLaporanDariTanggal)
        Me.Controls.Add(Me.CrystalReportViewer1)
        Me.Name = "Report_Transaksi"
        Me.Text = "Report_Transaksi"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents CrystalReportViewer1 As CrystalDecisions.Windows.Forms.CrystalReportViewer
    Friend WithEvents BtnTampilLaporanDariTanggal As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents PilihTgl As Guna.UI2.WinForms.Guna2DateTimePicker
    Friend WithEvents Label1 As Label
    Friend WithEvents BtnTampilkanAllLaporan As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents Label2 As Label
    Friend WithEvents CbBulan As Guna.UI2.WinForms.Guna2ComboBox
    Friend WithEvents CbTahun As Guna.UI2.WinForms.Guna2ComboBox
    Friend WithEvents BtnTampilLaporanBln As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents Label3 As Label
End Class
