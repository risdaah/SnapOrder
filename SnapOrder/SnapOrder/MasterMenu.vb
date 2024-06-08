Imports MySql.Data.MySqlClient
Imports System.IO
Public Class MasterMenu
    Dim ds As New DataSet
    Dim da As MySqlDataAdapter
    Dim conn As New MySqlConnection
    Dim id_mn As String = ""

    Sub koneksi()
        conn = New MySqlConnection("server= localhost" + ";user id=root" + "; 
                                        password=" + "; database=db_snaporder" + "")


    End Sub
    Private Sub TsMasterKategori_Click(sender As Object, e As EventArgs)
        MasterKategori.Show()
        Me.Hide()

    End Sub

    Private Sub TsLogout_Click(sender As Object, e As EventArgs)
        HomePage.Show()
        Me.Hide()
        clear()
    End Sub

    Private Sub MasterMenu_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.CenterToScreen()
        koneksi()

        data_menu()
        tampil_id_menu()
    End Sub

    Private Sub MasterMenu_Activated(sender As Object, e As EventArgs) Handles MyBase.Activated
        koneksi()

        tampil_kategori_menu()
        tampil_id_menu()
        data_menu()
    End Sub

    Sub data_menu()
        Try
            Dim query As String = "SELECT id_menu, id_kategori, nama_menu, gambar_menu, harga_menu, stok FROM tbl_menu"
            Dim adapter As New MySqlDataAdapter(query, conn)
            Dim datatable As New DataTable()
            adapter.Fill(datatable)

            For Each row As DataRow In datatable.Rows
                Dim id_menu As String = CStr(row("id_menu"))
                Dim id_kategori As String = CStr(row("id_kategori"))
                Dim namamenu As String = CStr(row("nama_menu"))
                Dim gambar As Byte() = DirectCast(row("gambar_menu"), Byte())
                Dim harga As Integer = CInt(row("harga_menu"))
                Dim stok As Integer = CInt(row("stok"))

                Dim image As Image = Nothing
                Using ms As New MemoryStream(gambar)
                    Try
                        image = Image.FromStream(ms)
                    Catch ex As ArgumentException
                        ' Jika gambar tidak valid, set image ke Nothing atau tangani sesuai kebutuhan
                        MessageBox.Show("Gambar tidak valid untuk ID Menu: " + id_menu)
                    End Try
                End Using

                DgMenu.Columns("gambar_menu").Width = 100
                DgMenu.RowTemplate.Height = 100

                DgMenu.Rows.Add(id_menu, id_kategori, namamenu, image, harga, stok)
            Next row

        Catch ex As Exception
            MessageBox.Show("Terjadi kesalahan saat menghubungkan ke database: " + ex.Message)
        Finally

            conn.Close()
        End Try

    End Sub

    Sub clear()
        For Each ctr In Me.Controls
            If TypeOf ctr Is TextBox Then
                ctr.Text = ""
            ElseIf TypeOf ctr Is ComboBox Then
                DirectCast(ctr, ComboBox).SelectedItem = Nothing
            End If
        Next
    End Sub

    Sub tampil_id_menu()
        ds.Clear()
        da = New MySqlDataAdapter("SELECT 
                                        CASE
                                            WHEN MAX(CONVERT(SUBSTRING(id_menu, 3), SIGNED)) IS NULL THEN 'MN001'
                                            ELSE CONCAT('MN', LPAD(MAX(CONVERT(SUBSTRING(id_menu, 3), SIGNED)) + 1, 3, '0'))
                                        END AS next_id_menu
                                    FROM tbl_menu;", conn)
        da.Fill(ds, "idmn")
        id_mn = ds.Tables("idmn").Rows(0).Item(0).ToString
        TbIDMenu.Text = id_mn
    End Sub

    Sub tampil_kategori_menu()

        koneksi()
        conn.Open()
        Dim query As String = "SELECT kategori FROM tbl_kategori"
        Dim command As New MySqlCommand(query, conn)

        Using reader As MySqlDataReader = command.ExecuteReader()
            CbKategoriMenu.Items.Clear()

            While reader.Read()
                Dim kategori As String = reader.GetString(0)
                CbKategoriMenu.Items.Add(kategori)
            End While
        End Using

    End Sub

    Private Sub CbKategoriMenu_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CbKategoriMenu.SelectedIndexChanged
        If CbKategoriMenu.SelectedItem IsNot Nothing Then
            Dim selectedKategori As String = CbKategoriMenu.SelectedItem.ToString()
            Dim idKategori As String = GetIDKategori(selectedKategori)

            TbIDKatMenu.Text = idKategori
        End If
    End Sub


    Private Function GetIDKategori(kategori As String) As String
        Dim idKategori As String = ""

        koneksi()
        conn.Open()
        Dim query As String = "SELECT id_kategori FROM tbl_kategori WHERE kategori = @kategori"
        Using command As MySqlCommand = New MySqlCommand(query, conn)
            command.Parameters.AddWithValue("@kategori", kategori)

            Dim reader As MySqlDataReader = command.ExecuteReader()

            If reader.Read() Then
                idKategori = reader.GetString("id_kategori")
            End If

            reader.Close()
        End Using


        Return idKategori
    End Function

    Private Sub BtnPilihGambar_Click(sender As Object, e As EventArgs) Handles BtnPilihGambar.Click
        Try
            With BukaFile
                .Filter = "Image Files|*.jpg"
                .FilterIndex = 1
            End With
            BukaFile.FileName = ""
            If BukaFile.ShowDialog = Windows.Forms.DialogResult.OK Then
                GambarMenu.Image = Image.FromFile(BukaFile.FileName)
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub

    Private Sub BtnTambahMenu_Click(sender As Object, e As EventArgs) Handles BtnTambahMenu.Click

        Dim idMenu As String = TbIDMenu.Text
        Dim idKategoriMenu As String = TbIDKatMenu.Text
        Dim namaMenu As String = TbNamaMenu.Text
        Dim hargaMenu As Integer = Integer.Parse(TbHargaMenu.Text)
        Dim stokMenu As Integer = Integer.Parse(TbStokMenu.Text)

        Dim image As Image = GambarMenu.Image

        Dim imageBytes As Byte() = Nothing
        If image IsNot Nothing Then
            Using ms As New MemoryStream()
                image.Save(ms, image.RawFormat)
                imageBytes = ms.ToArray()
            End Using
        End If

        Try
            Dim query As String = "INSERT INTO tbl_menu (id_menu, id_kategori, nama_menu, gambar_menu, harga_menu, stok) 
                                VALUES (@IdMenu, @IdKategori, @NamaMenu, @GambarMenu, @HargaMenu, @Stok)"
            Using command As New MySqlCommand(query, conn)
                command.Parameters.AddWithValue("@IdMenu", idMenu)
                command.Parameters.AddWithValue("@IdKategori", idKategoriMenu)
                command.Parameters.AddWithValue("@NamaMenu", namaMenu)
                command.Parameters.AddWithValue("@GambarMenu", imageBytes)
                command.Parameters.AddWithValue("@HargaMenu", hargaMenu)
                command.Parameters.AddWithValue("@Stok", stokMenu)
                command.ExecuteNonQuery()
            End Using

            MessageBox.Show("Data berhasil ditambahkan ke database.")

            conn.Close()

            clear()
            data_menu()
            tampil_id_menu()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub

    Private Sub DgMenu_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DgMenu.CellContentClick
        Dim selectedRow As DataGridViewRow = DgMenu.Rows(e.RowIndex)
        Dim dataMN As String = selectedRow.Cells("nama_menu").Value.ToString

        ' Mengambil data dari kolom yang sesuai
        Dim idMenu As String = selectedRow.Cells("id_menu").Value

        If e.ColumnIndex = DgMenu.Columns("ubah").Index AndAlso e.RowIndex >= 0 Then
            'Mengambil Data row
            TbIDMenu.Text = selectedRow.Cells("id_menu").Value.ToString
            TbIDKatMenu.Text = selectedRow.Cells("id_kategori_menu").Value.ToString
            TbNamaMenu.Text = selectedRow.Cells("nama_menu").Value.ToString
            TbHargaMenu.Text = selectedRow.Cells("harga_menu").Value
            TbStokMenu.Text = selectedRow.Cells("Stok").Value

        ElseIf e.ColumnIndex = DgMenu.Columns("hapus").Index AndAlso e.RowIndex >= 0 Then

            Dim result As DialogResult = MessageBox.Show("Apakah Anda yakin ingin menghapus " & dataMN & "?",
                                                 "Konfirmasi", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

            If result = DialogResult.Yes Then

                ' Menghapus baris yang sesuai dengan tombol "Remove" yang diklik
                DgMenu.Rows.RemoveAt(e.RowIndex)

                '' Menghapus data dari database
                da = New MySqlDataAdapter("DELETE FROM tbl_menu WHERE id_menu = @id_menu", conn)
                da.SelectCommand.Parameters.AddWithValue("@id_menu", idMenu)
                da.Fill(ds, "tbl_menu")
                ds.Clear()
                clear()
                data_menu()

            End If
        End If
    End Sub

    Private Sub BtnUbahMenu_Click(sender As Object, e As EventArgs) Handles BtnUbahMenu.Click
        Dim IDMenu As String = TbIDMenu.Text
        Dim IDKategori As String = TbIDKatMenu.Text
        Dim HGMenu As Integer = Convert.ToInt32(TbHargaMenu.Text)
        Dim NMMenu As String = TbNamaMenu.Text
        Dim GMenu As Image = GambarMenu.Image
        Dim SMenu As Integer = Convert.ToInt32(TbStokMenu.Text)

        Dim result As DialogResult = MessageBox.Show("Apakah Anda yakin ingin mengubah menu " & NMMenu & " ini?",
                                             "Konfirmasi", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

        If result = DialogResult.Yes Then
            conn.Open()
            Try
                Dim query As String = "UPDATE tbl_menu SET id_kategori = @id_kategori, nama_menu = @nama_menu, 
                                    harga_menu = @harga_menu, stok = @stok"

                ' kondisi untuk mengupdate gambar jika menu tidak kosong
                If GMenu IsNot Nothing Then
                    query += ", gambar_menu = @gambar_menu"
                End If

                query += " WHERE id_menu = @id_menu"

                Dim command As New MySqlCommand(query, conn)

                command.Parameters.AddWithValue("@id_kategori", IDKategori)
                command.Parameters.AddWithValue("@nama_menu", NMMenu)
                command.Parameters.AddWithValue("@harga_menu", HGMenu)
                command.Parameters.AddWithValue("@stok", SMenu)
                command.Parameters.AddWithValue("@id_menu", IDMenu)

                ' Mengonversi gambar menjadi byte array jika gambar ada
                If GMenu IsNot Nothing Then
                    Using ms As New MemoryStream()
                        GMenu.Save(ms, GMenu.RawFormat)
                        Dim imageBytes As Byte() = ms.ToArray()
                        command.Parameters.AddWithValue("@gambar_menu", imageBytes)
                    End Using
                End If


                command.ExecuteNonQuery()

                ds.Clear()
                clear()
                tampil_id_menu()
                data_menu()
            Catch ex As Exception
                MessageBox.Show("Terjadi kesalahan saat mengubah menu: " + ex.Message)
            Finally
                conn.Close()
            End Try
        End If
    End Sub

    Private Sub TsMasterTransaksi_Click(sender As Object, e As EventArgs)
        Me.Hide()
        MasterTransaksi.Show()
    End Sub

End Class