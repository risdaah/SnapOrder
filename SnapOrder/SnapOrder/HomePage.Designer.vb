<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class HomePage
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
        Dim Animation1 As Guna.UI2.AnimatorNS.Animation = New Guna.UI2.AnimatorNS.Animation()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(HomePage))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.PanelLog = New Guna.UI2.WinForms.Guna2ShadowPanel()
        Me.CbTampilkanPass = New Guna.UI2.WinForms.Guna2CheckBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.BtMasuk = New Guna.UI2.WinForms.Guna2Button()
        Me.TbPass = New Guna.UI2.WinForms.Guna2TextBox()
        Me.TbEmail = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.transisi = New Guna.UI2.WinForms.Guna2Transition()
        Me.Guna2CircleButton1 = New Guna.UI2.WinForms.Guna2CircleButton()
        Me.BtDineIn = New Guna.UI2.WinForms.Guna2Button()
        Me.BtTakeOut = New Guna.UI2.WinForms.Guna2Button()
        Me.PanelLog.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.transisi.SetDecoration(Me.Label1, Guna.UI2.AnimatorNS.DecorationType.None)
        Me.Label1.Font = New System.Drawing.Font("Nirmala UI", 27.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(213, 136)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(435, 100)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "MAU MAKAN DIMANA " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "HARI INI?"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'PanelLog
        '
        Me.PanelLog.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.PanelLog.BackColor = System.Drawing.Color.Transparent
        Me.PanelLog.Controls.Add(Me.CbTampilkanPass)
        Me.PanelLog.Controls.Add(Me.Label5)
        Me.PanelLog.Controls.Add(Me.BtMasuk)
        Me.PanelLog.Controls.Add(Me.TbPass)
        Me.PanelLog.Controls.Add(Me.TbEmail)
        Me.PanelLog.Controls.Add(Me.Label4)
        Me.PanelLog.Controls.Add(Me.Label3)
        Me.PanelLog.Controls.Add(Me.Label2)
        Me.transisi.SetDecoration(Me.PanelLog, Guna.UI2.AnimatorNS.DecorationType.None)
        Me.PanelLog.FillColor = System.Drawing.Color.White
        Me.PanelLog.Location = New System.Drawing.Point(161, 81)
        Me.PanelLog.Name = "PanelLog"
        Me.PanelLog.Radius = 15
        Me.PanelLog.ShadowColor = System.Drawing.Color.Black
        Me.PanelLog.Size = New System.Drawing.Size(535, 322)
        Me.PanelLog.TabIndex = 9
        Me.PanelLog.Visible = False
        '
        'CbTampilkanPass
        '
        Me.CbTampilkanPass.AutoSize = True
        Me.CbTampilkanPass.BackColor = System.Drawing.Color.White
        Me.CbTampilkanPass.CheckedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.CbTampilkanPass.CheckedState.BorderRadius = 0
        Me.CbTampilkanPass.CheckedState.BorderThickness = 0
        Me.CbTampilkanPass.CheckedState.FillColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.transisi.SetDecoration(Me.CbTampilkanPass, Guna.UI2.AnimatorNS.DecorationType.None)
        Me.CbTampilkanPass.Font = New System.Drawing.Font("Nirmala UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CbTampilkanPass.Location = New System.Drawing.Point(76, 211)
        Me.CbTampilkanPass.Name = "CbTampilkanPass"
        Me.CbTampilkanPass.Size = New System.Drawing.Size(145, 21)
        Me.CbTampilkanPass.TabIndex = 7
        Me.CbTampilkanPass.Text = "Tampilkan Password"
        Me.CbTampilkanPass.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(125, Byte), Integer), CType(CType(137, Byte), Integer), CType(CType(149, Byte), Integer))
        Me.CbTampilkanPass.UncheckedState.BorderRadius = 0
        Me.CbTampilkanPass.UncheckedState.BorderThickness = 0
        Me.CbTampilkanPass.UncheckedState.FillColor = System.Drawing.Color.FromArgb(CType(CType(125, Byte), Integer), CType(CType(137, Byte), Integer), CType(CType(149, Byte), Integer))
        Me.CbTampilkanPass.UseVisualStyleBackColor = False
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.transisi.SetDecoration(Me.Label5, Guna.UI2.AnimatorNS.DecorationType.None)
        Me.Label5.Font = New System.Drawing.Font("MS Reference Sans Serif", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.SystemColors.AppWorkspace
        Me.Label5.Location = New System.Drawing.Point(445, 21)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(35, 34)
        Me.Label5.TabIndex = 6
        Me.Label5.Text = "X"
        '
        'BtMasuk
        '
        Me.BtMasuk.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.BtMasuk.BorderRadius = 20
        Me.transisi.SetDecoration(Me.BtMasuk, Guna.UI2.AnimatorNS.DecorationType.None)
        Me.BtMasuk.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.BtMasuk.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.BtMasuk.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.BtMasuk.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.BtMasuk.FillColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(66, Byte), Integer), CType(CType(37, Byte), Integer))
        Me.BtMasuk.Font = New System.Drawing.Font("Nirmala UI", 14.25!, System.Drawing.FontStyle.Bold)
        Me.BtMasuk.ForeColor = System.Drawing.Color.White
        Me.BtMasuk.Location = New System.Drawing.Point(180, 257)
        Me.BtMasuk.Name = "BtMasuk"
        Me.BtMasuk.Size = New System.Drawing.Size(180, 41)
        Me.BtMasuk.TabIndex = 5
        Me.BtMasuk.Text = "Masuk"
        '
        'TbPass
        '
        Me.TbPass.BorderColor = System.Drawing.Color.FromArgb(CType(CType(239, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(229, Byte), Integer))
        Me.TbPass.BorderRadius = 12
        Me.TbPass.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.transisi.SetDecoration(Me.TbPass, Guna.UI2.AnimatorNS.DecorationType.None)
        Me.TbPass.DefaultText = ""
        Me.TbPass.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.TbPass.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.TbPass.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.TbPass.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.TbPass.FillColor = System.Drawing.Color.FromArgb(CType(CType(239, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(229, Byte), Integer))
        Me.TbPass.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.TbPass.Font = New System.Drawing.Font("Nirmala UI", 12.0!)
        Me.TbPass.ForeColor = System.Drawing.Color.Black
        Me.TbPass.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.TbPass.Location = New System.Drawing.Point(65, 170)
        Me.TbPass.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.TbPass.Name = "TbPass"
        Me.TbPass.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.TbPass.PlaceholderForeColor = System.Drawing.Color.DimGray
        Me.TbPass.PlaceholderText = "Kata Sandi"
        Me.TbPass.SelectedText = ""
        Me.TbPass.Size = New System.Drawing.Size(415, 33)
        Me.TbPass.TabIndex = 4
        '
        'TbEmail
        '
        Me.TbEmail.BorderColor = System.Drawing.Color.FromArgb(CType(CType(239, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(229, Byte), Integer))
        Me.TbEmail.BorderRadius = 12
        Me.TbEmail.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.transisi.SetDecoration(Me.TbEmail, Guna.UI2.AnimatorNS.DecorationType.None)
        Me.TbEmail.DefaultText = ""
        Me.TbEmail.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.TbEmail.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.TbEmail.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.TbEmail.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.TbEmail.FillColor = System.Drawing.Color.FromArgb(CType(CType(239, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(229, Byte), Integer))
        Me.TbEmail.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.TbEmail.Font = New System.Drawing.Font("Nirmala UI", 12.0!)
        Me.TbEmail.ForeColor = System.Drawing.Color.Black
        Me.TbEmail.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.TbEmail.Location = New System.Drawing.Point(65, 97)
        Me.TbEmail.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.TbEmail.Name = "TbEmail"
        Me.TbEmail.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.TbEmail.PlaceholderForeColor = System.Drawing.Color.DimGray
        Me.TbEmail.PlaceholderText = "Masukkan Email Anda"
        Me.TbEmail.SelectedText = ""
        Me.TbEmail.Size = New System.Drawing.Size(415, 33)
        Me.TbEmail.TabIndex = 3
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.transisi.SetDecoration(Me.Label4, Guna.UI2.AnimatorNS.DecorationType.None)
        Me.Label4.Font = New System.Drawing.Font("Nirmala UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(72, 146)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(76, 21)
        Me.Label4.TabIndex = 2
        Me.Label4.Text = "Password"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.transisi.SetDecoration(Me.Label3, Guna.UI2.AnimatorNS.DecorationType.None)
        Me.Label3.Font = New System.Drawing.Font("Nirmala UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(72, 73)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(48, 21)
        Me.Label3.TabIndex = 1
        Me.Label3.Text = "Email"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.transisi.SetDecoration(Me.Label2, Guna.UI2.AnimatorNS.DecorationType.None)
        Me.Label2.Font = New System.Drawing.Font("Nirmala UI", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(221, 23)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(88, 32)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "LOGIN"
        '
        'transisi
        '
        Me.transisi.AnimationType = Guna.UI2.AnimatorNS.AnimationType.Transparent
        Me.transisi.Cursor = Nothing
        Animation1.AnimateOnlyDifferences = True
        Animation1.BlindCoeff = CType(resources.GetObject("Animation1.BlindCoeff"), System.Drawing.PointF)
        Animation1.LeafCoeff = 0!
        Animation1.MaxTime = 1.0!
        Animation1.MinTime = 0!
        Animation1.MosaicCoeff = CType(resources.GetObject("Animation1.MosaicCoeff"), System.Drawing.PointF)
        Animation1.MosaicShift = CType(resources.GetObject("Animation1.MosaicShift"), System.Drawing.PointF)
        Animation1.MosaicSize = 0
        Animation1.Padding = New System.Windows.Forms.Padding(0)
        Animation1.RotateCoeff = 0!
        Animation1.RotateLimit = 0!
        Animation1.ScaleCoeff = CType(resources.GetObject("Animation1.ScaleCoeff"), System.Drawing.PointF)
        Animation1.SlideCoeff = CType(resources.GetObject("Animation1.SlideCoeff"), System.Drawing.PointF)
        Animation1.TimeCoeff = 0!
        Animation1.TransparencyCoeff = 1.0!
        Me.transisi.DefaultAnimation = Animation1
        '
        'Guna2CircleButton1
        '
        Me.Guna2CircleButton1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.transisi.SetDecoration(Me.Guna2CircleButton1, Guna.UI2.AnimatorNS.DecorationType.None)
        Me.Guna2CircleButton1.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.Guna2CircleButton1.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.Guna2CircleButton1.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.Guna2CircleButton1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.Guna2CircleButton1.FillColor = System.Drawing.Color.Transparent
        Me.Guna2CircleButton1.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.Guna2CircleButton1.ForeColor = System.Drawing.Color.White
        Me.Guna2CircleButton1.Image = CType(resources.GetObject("Guna2CircleButton1.Image"), System.Drawing.Image)
        Me.Guna2CircleButton1.ImageSize = New System.Drawing.Size(40, 40)
        Me.Guna2CircleButton1.Location = New System.Drawing.Point(777, 12)
        Me.Guna2CircleButton1.Name = "Guna2CircleButton1"
        Me.Guna2CircleButton1.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle
        Me.Guna2CircleButton1.Size = New System.Drawing.Size(50, 50)
        Me.Guna2CircleButton1.TabIndex = 10
        '
        'BtDineIn
        '
        Me.BtDineIn.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.BtDineIn.BackColor = System.Drawing.Color.Transparent
        Me.BtDineIn.BorderRadius = 12
        Me.transisi.SetDecoration(Me.BtDineIn, Guna.UI2.AnimatorNS.DecorationType.None)
        Me.BtDineIn.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.BtDineIn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.BtDineIn.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.BtDineIn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.BtDineIn.FillColor = System.Drawing.Color.White
        Me.BtDineIn.Font = New System.Drawing.Font("Nirmala UI", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtDineIn.ForeColor = System.Drawing.SystemColors.ControlText
        Me.BtDineIn.Image = Global.SnapOrder.My.Resources.Resources.dine_in
        Me.BtDineIn.ImageSize = New System.Drawing.Size(40, 40)
        Me.BtDineIn.Location = New System.Drawing.Point(193, 275)
        Me.BtDineIn.Name = "BtDineIn"
        Me.BtDineIn.Size = New System.Drawing.Size(166, 77)
        Me.BtDineIn.TabIndex = 11
        Me.BtDineIn.Text = "DINE IN"
        '
        'BtTakeOut
        '
        Me.BtTakeOut.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.BtTakeOut.BackColor = System.Drawing.Color.Transparent
        Me.BtTakeOut.BorderRadius = 12
        Me.transisi.SetDecoration(Me.BtTakeOut, Guna.UI2.AnimatorNS.DecorationType.None)
        Me.BtTakeOut.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.BtTakeOut.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.BtTakeOut.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.BtTakeOut.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.BtTakeOut.FillColor = System.Drawing.Color.White
        Me.BtTakeOut.Font = New System.Drawing.Font("Nirmala UI", 14.25!, System.Drawing.FontStyle.Bold)
        Me.BtTakeOut.ForeColor = System.Drawing.SystemColors.ControlText
        Me.BtTakeOut.Image = Global.SnapOrder.My.Resources.Resources.take_out
        Me.BtTakeOut.ImageSize = New System.Drawing.Size(40, 40)
        Me.BtTakeOut.Location = New System.Drawing.Point(507, 275)
        Me.BtTakeOut.Name = "BtTakeOut"
        Me.BtTakeOut.Size = New System.Drawing.Size(166, 77)
        Me.BtTakeOut.TabIndex = 12
        Me.BtTakeOut.Text = "TAKE OUT"
        '
        'HomePage
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Beige
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(839, 459)
        Me.Controls.Add(Me.Guna2CircleButton1)
        Me.Controls.Add(Me.PanelLog)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.BtDineIn)
        Me.Controls.Add(Me.BtTakeOut)
        Me.transisi.SetDecoration(Me, Guna.UI2.AnimatorNS.DecorationType.None)
        Me.DoubleBuffered = True
        Me.Name = "HomePage"
        Me.Text = "HomePage"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.PanelLog.ResumeLayout(False)
        Me.PanelLog.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As Label
    Friend WithEvents PanelLog As Guna.UI2.WinForms.Guna2ShadowPanel
    Friend WithEvents BtMasuk As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents TbPass As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents TbEmail As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents transisi As Guna.UI2.WinForms.Guna2Transition
    Friend WithEvents Label5 As Label
    Friend WithEvents Guna2CircleButton1 As Guna.UI2.WinForms.Guna2CircleButton
    Friend WithEvents CbTampilkanPass As Guna.UI2.WinForms.Guna2CheckBox
    Friend WithEvents BtDineIn As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents BtTakeOut As Guna.UI2.WinForms.Guna2Button
End Class
