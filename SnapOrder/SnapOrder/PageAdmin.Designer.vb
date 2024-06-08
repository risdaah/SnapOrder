<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class PageAdmin
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
        Me.BtKelKategori = New Guna.UI2.WinForms.Guna2Button()
        Me.BtKelMenu = New Guna.UI2.WinForms.Guna2Button()
        Me.BtLogOut = New Guna.UI2.WinForms.Guna2CircleButton()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Nirmala UI", 27.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(317, 120)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(230, 50)
        Me.Label1.TabIndex = 30
        Me.Label1.Text = "Halo Admin"
        '
        'BtKelKategori
        '
        Me.BtKelKategori.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.BtKelKategori.BackColor = System.Drawing.Color.Transparent
        Me.BtKelKategori.BorderRadius = 12
        Me.BtKelKategori.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.BtKelKategori.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.BtKelKategori.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.BtKelKategori.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.BtKelKategori.FillColor = System.Drawing.Color.White
        Me.BtKelKategori.Font = New System.Drawing.Font("Nirmala UI", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtKelKategori.ForeColor = System.Drawing.Color.Black
        Me.BtKelKategori.Location = New System.Drawing.Point(137, 235)
        Me.BtKelKategori.Name = "BtKelKategori"
        Me.BtKelKategori.Size = New System.Drawing.Size(250, 78)
        Me.BtKelKategori.TabIndex = 32
        Me.BtKelKategori.Text = "Kelola Kategori"
        '
        'BtKelMenu
        '
        Me.BtKelMenu.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.BtKelMenu.BackColor = System.Drawing.Color.Transparent
        Me.BtKelMenu.BorderRadius = 12
        Me.BtKelMenu.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.BtKelMenu.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.BtKelMenu.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.BtKelMenu.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.BtKelMenu.FillColor = System.Drawing.Color.White
        Me.BtKelMenu.Font = New System.Drawing.Font("Nirmala UI", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtKelMenu.ForeColor = System.Drawing.Color.Black
        Me.BtKelMenu.Location = New System.Drawing.Point(493, 235)
        Me.BtKelMenu.Name = "BtKelMenu"
        Me.BtKelMenu.Size = New System.Drawing.Size(250, 78)
        Me.BtKelMenu.TabIndex = 33
        Me.BtKelMenu.Text = "Kelola Menu"
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
        'PageAdmin
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Beige
        Me.BackgroundImage = Global.SnapOrder.My.Resources.Resources.Login__3_
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(850, 455)
        Me.Controls.Add(Me.BtLogOut)
        Me.Controls.Add(Me.BtKelMenu)
        Me.Controls.Add(Me.BtKelKategori)
        Me.Controls.Add(Me.Label1)
        Me.DoubleBuffered = True
        Me.Name = "PageAdmin"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "PageAdmin"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As Label
    Friend WithEvents BtKelKategori As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents BtKelMenu As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents BtLogOut As Guna.UI2.WinForms.Guna2CircleButton
End Class
