Imports MySql.Data.MySqlClient
Public Class Pembelian

    Dim cn As New MySqlConnection
    Dim cm As New MySqlCommand
    Dim dr As MySqlDataReader

    Dim ds As New DataSet
    Dim da As MySqlDataAdapter
    Dim invoice_transaksi As String = ""
    Dim tanggalTransaksi As String = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss")

    Private WithEvents pic As New PictureBox
    Private WithEvents namaMenu As New Label
    Private WithEvents hargaMenu As New Label

    Sub koneksi()
        cn = New MySqlConnection("Server=localhost;user id=root;password=;database=db_snaporder")
    End Sub

    Private Sub Pembelian_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.CenterToScreen()

        Try
            koneksi()
            tampil_kategori()
            invoice()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Terjadi Kesalahan", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Sub tampil_kategori()
        cn.Open()

        Dim query As String = "SELECT kategori FROM tbl_kategori"
        Dim command As New MySqlCommand(query, cn)

        Using reader As MySqlDataReader = command.ExecuteReader()
            CbKategori2.Items.Clear()

            While reader.Read()
                Dim kategori As String = reader.GetString(0)
                CbKategori2.Items.Add(kategori)
            End While
        End Using

        cn.Close()
    End Sub

    Private Sub CbKategori2_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CbKategori2.SelectedIndexChanged
        tempatMenu.Controls.Clear()
        tampil_menu(CbKategori2.SelectedItem.ToString())
    End Sub

    Public Sub SetText(text As String)
        TbJenisTransaksi.Text = text
    End Sub

    Sub tampil_menu(kategori As String)
        cn.Open()
        cm = New MySqlCommand("SELECT gambar_menu, nama_menu, harga_menu, id_menu FROM tbl_menu WHERE id_kategori = 
                                (SELECT id_kategori FROM tbl_kategori WHERE kategori = @kategori)", cn)
        cm.Parameters.AddWithValue("@kategori", kategori)
        dr = cm.ExecuteReader
        While dr.Read
            Dim len As Long = dr.GetBytes(0, 0, Nothing, 0, 0)
            Dim array(CInt(len)) As Byte
            dr.GetBytes(0, 0, array, 0, CInt(len))

            pic = New PictureBox
            pic.Width = 140
            pic.Height = 140
            pic.BackgroundImageLayout = ImageLayout.Stretch
            pic.Tag = dr.Item("id_menu").ToString

            namaMenu = New Label
            namaMenu.ForeColor = Color.Black
            namaMenu.BackColor = Color.FromArgb(249, 241, 240)
            namaMenu.Tag = dr.Item("id_menu").ToString

            hargaMenu = New Label
            hargaMenu.ForeColor = Color.Black
            hargaMenu.BackColor = Color.FromArgb(249, 241, 240)
            hargaMenu.Dock = DockStyle.Bottom
            hargaMenu.Tag = dr.Item("id_menu").ToString

            Dim ms As New System.IO.MemoryStream(array)
            ms.Write(array, 0, CInt(len))
            ms.Position = 0
            Dim bitmap As New System.Drawing.Bitmap(ms)
            pic.BackgroundImage = bitmap
            namaMenu.Text = dr.Item("nama_menu").ToString
            hargaMenu.Text = dr.Item("harga_menu").ToString

            pic.Controls.Add(namaMenu)
            pic.Controls.Add(hargaMenu)

            tempatMenu.Controls.Add(pic)
            AddHandler pic.Click, AddressOf pilihMenu
            AddHandler namaMenu.Click, AddressOf pilihMenu
            AddHandler hargaMenu.Click, AddressOf pilihMenu
        End While
        dr.Close()
        cn.Close()
    End Sub

    Public Sub pilihMenu(sender As Object, e As EventArgs)
        Try
            cn.Open()

            Dim id_menu As String = sender.Tag.ToString()

            Dim nama_menu As String
            da = New MySqlDataAdapter("SELECT nama_menu FROM tbl_menu WHERE id_menu = '" & id_menu & "'", cn)
            ds.Clear()
            da.Fill(ds, "nama_menu")
            If ds.Tables("nama_menu").Rows.Count > 0 Then
                nama_menu = ds.Tables("nama_menu").Rows(0).Item("nama_menu").ToString()
            Else
                cn.Close()
                MsgBox("Menu tidak ada", vbCritical)
                Return
            End If

            Dim harga As Integer = 0
            Dim stok As Integer = 0

            ' Ambil harga dan stok menu dari tabel tbl_menu
            da = New MySqlDataAdapter("SELECT harga_menu, stok FROM tbl_menu WHERE id_menu = '" & id_menu & "'", cn)
            ds.Clear()
            da.Fill(ds, "menu_detail")
            If ds.Tables("menu_detail").Rows.Count > 0 Then
                harga = Integer.Parse(ds.Tables("menu_detail").Rows(0).Item("harga_menu"))
                stok = Integer.Parse(ds.Tables("menu_detail").Rows(0).Item("stok"))
            Else
                cn.Close()
                MsgBox("Data menu tidak ditemukan", vbCritical)
                Return
            End If

            ' Cek apakah stok menu masih tersedia
            Dim jumlah As Integer = 1 ' Set jumlah awal menjadi 1
            Dim subtotal As Integer = jumlah * harga

            If jumlah > stok Then
                cn.Close()
                MsgBox("Maaf, stok menu telah habis", vbCritical)
                Return
            End If

            ' Cek apakah menu sudah ada di keranjang belanja
            Dim row As DataGridViewRow = KeranjangDgv.Rows _
    .Cast(Of DataGridViewRow)() _
    .FirstOrDefault(Function(r) r.Cells("nama_menu").Value IsNot Nothing AndAlso r.Cells("nama_menu").Value.ToString() = nama_menu)

            If row IsNot Nothing Then
                ' Jika menu sudah ada di keranjang, tambahkan jumlah
                If row.Cells("jumlah").Value IsNot Nothing AndAlso Integer.TryParse(row.Cells("jumlah").Value.ToString(), jumlah) Then
                    ' Cek apakah jumlah menu sudah mencapai stok yang tersedia
                    If jumlah >= stok Then
                        cn.Close()
                        MsgBox("Maaf, stok menu telah habis", vbCritical)
                        Return
                    End If

                    jumlah += 1
                    subtotal = jumlah * harga
                    row.Cells("jumlah").Value = jumlah
                    row.Cells("subtotal").Value = subtotal
                End If
            Else
                ' Jika menu belum ada di keranjang, tambahkan ke keranjang
                KeranjangDgv.Rows.Add(nama_menu, jumlah, subtotal)
            End If

            Dim total As Integer = 0
            For Each gridRow As DataGridViewRow In KeranjangDgv.Rows
                Dim subtotalCellValue = gridRow.Cells("Subtotal").Value
                Dim grand_total As Integer
                If subtotalCellValue IsNot Nothing AndAlso Integer.TryParse(subtotalCellValue.ToString(), grand_total) Then
                    total += grand_total
                End If
            Next

            LbTotalBelanja.Text = total.ToString()

            cn.Close()
        Catch ex As Exception
            cn.Close()
            MsgBox(ex.Message, vbCritical)
        End Try
    End Sub

    Sub invoice()
        ds.Clear()
        da = New MySqlDataAdapter("SELECT CASE WHEN MAX(CAST(SUBSTRING(id_transaksi, 5, 3) AS UNSIGNED)) IS NULL
                                    THEN 1 ELSE MAX(CAST(SUBSTRING(id_transaksi, 5, 3) AS UNSIGNED)) + 1 END AS nomor
                                    FROM ( SELECT MAX(CAST(SUBSTRING(id_transaksi, 9, 2) AS UNSIGNED)) AS bln,
                                                  MAX(CAST(SUBSTRING(id_transaksi, 12, 4) AS UNSIGNED)) AS thn,
                                                  id_transaksi FROM tbl_transaksi GROUP BY id_transaksi) a WHERE a.bln = MONTH(NOW()) AND a.thn = YEAR(NOW());", cn)
        da.Fill(ds, "invoice_transaksi")
        Dim nom As Integer
        nom = Integer.Parse(ds.Tables("invoice_transaksi").Rows(0).ItemArray(0))
        TbInvoice2.Text = "ODR/" & Format(nom, "0##") & "/" & Format(Now.Month, "0#") & "/" & Now.Year

    End Sub

    Private Sub KeranjangBelanja_CellContentClick(sender As Object, e As DataGridViewCellEventArgs)

    End Sub

    Private Sub BtPesan_Click(sender As Object, e As EventArgs) Handles BtPesan.Click
        Try
            ds.Clear()
            da = New MySqlDataAdapter("INSERT INTO tbl_transaksi (id_transaksi, jenis_transaksi, nama_pembeli, tanggal_transaksi, total, catatan) VALUES (?,?,?,?,?,?)", cn)
            da.SelectCommand.Parameters.AddWithValue("id_transaksi", TbInvoice2.Text)
            da.SelectCommand.Parameters.AddWithValue("jenis_transaksi", TbJenisTransaksi.Text)
            da.SelectCommand.Parameters.AddWithValue("nama_pembeli", TbNamaPembeli.Text)
            da.SelectCommand.Parameters.AddWithValue("tanggal_transaksi", tanggalTransaksi)
            da.SelectCommand.Parameters.AddWithValue("total", LbTotalBelanja.Text)
            da.SelectCommand.Parameters.AddWithValue("catatan", TbCatatan.Text)
            da.Fill(ds, "transaksi")
            ds.Clear()

            For i As Integer = 0 To KeranjangDgv.Rows.Count - 1
                Dim menu As String = KeranjangDgv.Rows(i).Cells("nama_menu").Value
                Dim menu_jumlah As String = KeranjangDgv.Rows(i).Cells("jumlah").Value
                Dim pesanan_subtotal As String = KeranjangDgv.Rows(i).Cells("subtotal").Value

                da = New MySqlDataAdapter("select id_menu from tbl_menu where nama_menu like @menu", cn)
                da.SelectCommand.Parameters.AddWithValue("@menu", menu)
                Dim menuDs As New DataSet()
                da.Fill(menuDs, "menu")

                If menuDs.Tables("menu").Rows.Count > 0 Then
                    Dim id_menu As String = menuDs.Tables("menu").Rows(0).Item("id_menu")
                    If Not (menu_jumlah = 0 OrElse pesanan_subtotal = 0) Then
                        da = New MySqlDataAdapter("INSERT INTO tbl_detailtransaksi (id_transaksi, id_menu, jumlah, subtotal) VALUES (?,?,?,?)", cn)
                        da.SelectCommand.Parameters.AddWithValue("id_transaksi", TbInvoice2.Text)
                        da.SelectCommand.Parameters.AddWithValue("id_menu", id_menu)
                        da.SelectCommand.Parameters.AddWithValue("jumlah", menu_jumlah)
                        da.SelectCommand.Parameters.AddWithValue("subtotal", pesanan_subtotal)
                        da.Fill(ds, "detailtransaksi")

                        ' Mengurangi stok menu
                        Dim updateStokQuery As String = "UPDATE tbl_menu SET stok = stok - ? WHERE id_menu = ?"
                        da = New MySqlDataAdapter(updateStokQuery, cn)
                        da.SelectCommand.Parameters.AddWithValue("stok", menu_jumlah)
                        da.SelectCommand.Parameters.AddWithValue("id_menu", id_menu)
                        da.Fill(ds, "updatestok")
                    End If
                End If
            Next

            KeranjangDgv.Rows.Clear()

            Dim StrukPembelian As New StrukBeli
            StrukPembelian.NoInvoice = TbInvoice2.Text
            StrukPembelian.NamaCustomer = TbNamaPembeli.Text


            LbTotalBelanja.Text = 0
            TbNamaPembeli.Text = ""
            TbCatatan.Text = ""
            MessageBox.Show("Transaksi Berhasil")

            StrukPembelian.Show()

        Catch ex As Exception
            cn.Close()
            MessageBox.Show(ex.Message, "Terjadi Kesalahan", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub KeranjangDgv_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles KeranjangDgv.CellContentClick

        'Mmemeriksa apakah button "Remove" yang diklik dan index>-0
        If e.ColumnIndex = KeranjangDgv.Columns("hapus").Index AndAlso e.RowIndex >= 0 AndAlso KeranjangDgv.Rows(e.RowIndex).Cells("jumlah").Value IsNot Nothing Then
            'Menghapus baris yang sesuai dengan tombol "Remove" yang diklik
            KeranjangDgv.Rows.RemoveAt(e.RowIndex)
        Else
            KeranjangDgv.Rows(e.RowIndex).Cells("hapus").ReadOnly = False
        End If

        If e.ColumnIndex = KeranjangDgv.Columns("kurangmenu").Index AndAlso e.RowIndex >= 0 Then
            ' Mengurangi jumlah pada kolom "jumlah" di baris yang sesuai dengan tombol "Remove" yang diklik
            Dim jumlah As Integer = Convert.ToInt32(KeranjangDgv.Rows(e.RowIndex).Cells("jumlah").Value)
            If jumlah > 0 Then
                jumlah -= 1
                KeranjangDgv.Rows(e.RowIndex).Cells("jumlah").Value = jumlah.ToString()
            End If

        Else

            KeranjangDgv.Rows(e.RowIndex).Cells("kurangmenu").ReadOnly = False

        End If


        Dim total As Integer = 0
        For Each row As DataGridViewRow In KeranjangDgv.Rows
            If row.Cells("subtotal").Value Is Nothing Then
                total += row.Cells("subtotal").Value
            End If
        Next

        Dim total2 As Integer = 0
        For Each gridRow As DataGridViewRow In KeranjangDgv.Rows
            Dim subtotalCellValue = gridRow.Cells("Subtotal").Value
            Dim grand_total As Integer
            If subtotalCellValue IsNot Nothing AndAlso Integer.TryParse(subtotalCellValue.ToString(), grand_total) Then
                total2 += grand_total
            End If
        Next

        LbTotalBelanja.Text = total2.ToString()
    End Sub

    Private Sub BtBack_Click(sender As Object, e As EventArgs) Handles BtBack.Click
        Me.Dispose()
        HomePage.Show()
    End Sub
End Class