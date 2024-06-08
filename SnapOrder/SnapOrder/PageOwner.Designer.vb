<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class PageOwner
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.BtKelTransaksi = New Guna.UI2.WinForms.Guna2Button()
        Me.BtLaporan = New Guna.UI2.WinForms.Guna2Button()
        Me.BtKelAdmin = New Guna.UI2.WinForms.Guna2Button()
        Me.BtLogOut = New Guna.UI2.WinForms.Guna2CircleButton()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Nirmala UI", 27.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(305, 102)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(229, 50)
        Me.Label1.TabIndex = 30
        Me.Label1.Text = "Halo Owner"
        '
        'BtKelTransaksi
        '
        Me.BtKelTransaksi.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.BtKelTransaksi.BackColor = System.Drawing.Color.Transparent
        Me.BtKelTransaksi.BorderRadius = 12
        Me.BtKelTransaksi.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.BtKelTransaksi.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.BtKelTransaksi.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.BtKelTransaksi.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.BtKelTransaksi.FillColor = System.Drawing.Color.White
        Me.BtKelTransaksi.Font = New System.Drawing.Font("Nirmala UI", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtKelTransaksi.ForeColor = System.Drawing.Color.Black
        Me.BtKelTransaksi.Location = New System.Drawing.Point(91, 311)
        Me.BtKelTransaksi.Name = "BtKelTransaksi"
        Me.BtKelTransaksi.Size = New System.Drawing.Size(256, 58)
        Me.BtKelTransaksi.TabIndex = 32
        Me.BtKelTransaksi.Text = "List Transaksi"
        '
        'BtLaporan
        '
        Me.BtLaporan.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.BtLaporan.BackColor = System.Drawing.Color.Transparent
        Me.BtLaporan.BorderColor = System.Drawing.Color.Transparent
        Me.BtLaporan.BorderRadius = 12
        Me.BtLaporan.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.BtLaporan.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.BtLaporan.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.BtLaporan.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.BtLaporan.FillColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.BtLaporan.Font = New System.Drawing.Font("Nirmala UI", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtLaporan.ForeColor = System.Drawing.Color.White
        Me.BtLaporan.Location = New System.Drawing.Point(475, 311)
        Me.BtLaporan.Name = "BtLaporan"
        Me.BtLaporan.Size = New System.Drawing.Size(256, 58)
        Me.BtLaporan.TabIndex = 33
        Me.BtLaporan.Text = "Laporan"
        '
        'BtKelAdmin
        '
        Me.BtKelAdmin.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.BtKelAdmin.BackColor = System.Drawing.Color.Transparent
        Me.BtKelAdmin.BorderRadius = 12
        Me.BtKelAdmin.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.BtKelAdmin.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.BtKelAdmin.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.BtKelAdmin.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.BtKelAdmin.FillColor = System.Drawing.Color.White
        Me.BtKelAdmin.Font = New System.Drawing.Font("Nirmala UI", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtKelAdmin.ForeColor = System.Drawing.Color.Black
        Me.BtKelAdmin.Location = New System.Drawing.Point(287, 203)
        Me.BtKelAdmin.Name = "BtKelAdmin"
        Me.BtKelAdmin.Size = New System.Drawing.Size(256, 58)
        Me.BtKelAdmin.TabIndex = 34
        Me.BtKelAdmin.Text = "Kelola Admin"
        '
        'BtLogOut
        '
        Me.BtLogOut.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BtLogOut.BackColor = System.Drawing.Color.Transparent
        Me.BtLogOut.BackgroundImage = Global.SnapOrder.My.Resources.Resources.logout
        Me.BtLogOut.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BtLogOut.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.BtLogOut.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.BtLogOut.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.BtLogOut.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.BtLogOut.FillColor = System.Drawing.Color.Transparent
        Me.BtLogOut.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.BtLogOut.ForeColor = System.Drawing.Color.White
        Me.BtLogOut.Location = New System.Drawing.Point(798, 12)
        Me.BtLogOut.Name = "BtLogOut"
        Me.BtLogOut.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle
        Me.BtLogOut.Size = New System.Drawing.Size(40, 40)
        Me.BtLogOut.TabIndex = 37
        '
        'PageOwner
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Beige
        Me.BackgroundImage = Global.SnapOrder.My.Resources.Resources.Login__3_
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(850, 455)
        Me.Controls.Add(Me.BtLogOut)
        Me.Controls.Add(Me.BtKelAdmin)
        Me.Controls.Add(Me.BtLaporan)
        Me.Controls.Add(Me.BtKelTransaksi)
        Me.Controls.Add(Me.Label1)
        Me.DoubleBuffered = True
        Me.Name = "PageOwner"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "PageOwner"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As Label
    Friend WithEvents BtKelTransaksi As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents BtLaporan As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents BtKelAdmin As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents BtLogOut As Guna.UI2.WinForms.Guna2CircleButton
End Class
