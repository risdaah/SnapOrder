Imports MySql.Data.MySqlClient
Public Class MasterKategori
    Dim ds As New DataSet
    Dim da As MySqlDataAdapter
    Dim conn As New MySqlConnection
    Dim id_ktg As String = ""

    Sub koneksi()
        conn = New MySqlConnection("server= localhost" + ";user id=root" + "; 
                                        password=" + "; database=db_snaporder" + "")
        conn.Open()

    End Sub

    Private Sub MasterKategori_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.CenterToScreen()
        clear()
        koneksi()
    End Sub

    Private Sub MasterKategori_Activated(sender As Object, e As EventArgs) Handles MyBase.Activated
        koneksi()
        data_kategori()
        tampil_id()
    End Sub

    Sub clear()
        For Each ctr In Me.Controls
            If TypeOf ctr Is TextBox Then
                ctr.Text = ""
            End If
        Next
    End Sub

    Sub data_kategori()

        Try
            ds.Clear()
            Dim query As String = "SELECT id_kategori, kategori FROM tbl_kategori"
            da = New MySqlDataAdapter(query, conn)
            da.Fill(ds, "tbl_kategori")
            DgKategori.Rows.Clear()
            For i As Integer = 0 To ds.Tables("tbl_kategori").Rows.Count - 1
                DgKategori.Rows.Add(ds.Tables("tbl_kategori").Rows(i).Item(0).ToString,
                                    ds.Tables("tbl_kategori").Rows(i).Item(1).ToString)
            Next
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Terjadi Kesalahan", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

        Dim count As Integer = DgKategori.Rows.Count
        'LbJumlahItem.Text = "Jumlah Item: " & count.ToString()

        conn.Close()
    End Sub

    Sub tampil_id()
        ds.Clear()
        da = New MySqlDataAdapter("SELECT CASE
                                    WHEN MAX(CONVERT(SUBSTRING(id_kategori, 4), SIGNED)) IS NULL THEN 'KTG001'
                                    ELSE CONCAT('KTG', LPAD(MAX(CONVERT(SUBSTRING(id_kategori, 4), SIGNED)) + 1, 3, '0'))
                                    END AS next_id_kategori
                                FROM tbl_kategori;", conn)
        da.Fill(ds, "idktg")
        id_ktg = ds.Tables("idktg").Rows(0).Item(0).ToString
        TbIDKategori.Text = id_ktg
    End Sub



    Private Sub TsMasterMenu_Click(sender As Object, e As EventArgs)
        MasterMenu.Show()
        Me.Hide()
    End Sub

    Private Sub TsLogout_Click(sender As Object, e As EventArgs)
        HomePage.Show()
        Me.Hide()
        clear()
    End Sub

    Private Sub TsMasterTransaksi_Click(sender As Object, e As EventArgs)
        Me.Hide()
        MasterTransaksi.Show()
    End Sub

    Private Sub BtTambah_Click(sender As Object, e As EventArgs) Handles BtTambah.Click
        Dim cek As Boolean = True

        If TbKategori.Text = "" Then
            ErrorProvider1.SetError(TbKategori, "Data Tidak Boleh Kosong")
            cek = False
        End If

        If cek = True Then
            conn.Open()
            ds.Clear()
            da = New MySqlDataAdapter("insert into tbl_kategori values (?,?)", conn)
            da.SelectCommand.Parameters.AddWithValue("id_kategori", TbIDKategori.Text)
            da.SelectCommand.Parameters.AddWithValue("kategori", TbKategori.Text)
            da.Fill(ds, "kategori")
            ds.Clear()
            conn.Close()
            clear()
            data_kategori()
            tampil_id()
        End If
    End Sub

    Private Sub BtUbah_Click(sender As Object, e As EventArgs) Handles BtUbah.Click
        Dim idKategori As String = TbIDKategori.Text
        Dim kategoriMenu As String = TbKategori.Text

        Dim result As DialogResult = MessageBox.Show("Apakah Anda yakin ingin mengubah kategori " & kategoriMenu & " ini?",
                                                         "Konfirmasi", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

        If result = DialogResult.Yes Then

            da = New MySqlDataAdapter("UPDATE tbl_kategori SET kategori = @kategori WHERE id_kategori = @id_kategori", conn)
            da.SelectCommand.Parameters.AddWithValue("@kategori", kategoriMenu)
            da.SelectCommand.Parameters.AddWithValue("@id_kategori", idKategori)
            da.Fill(ds, "kategori")
            ds.Clear()
            data_kategori()
            clear()
            tampil_id()

            conn.Close()
        End If
    End Sub

    Private Sub DgKategori_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DgKategori.CellContentClick
        Dim selectedRow As DataGridViewRow = DgKategori.Rows(e.RowIndex)
        Dim dataKTG As String = selectedRow.Cells("kategori").Value.ToString

        ' Mengambil data dari kolom yang sesuai
        Dim idKategori As String = selectedRow.Cells("id_kategori").Value

        If e.ColumnIndex = DgKategori.Columns("ubah").Index AndAlso e.RowIndex >= 0 Then
            'Mengambil Data row
            TbIDKategori.Text = selectedRow.Cells("id_kategori").Value.ToString
            TbKategori.Text = selectedRow.Cells("kategori").Value.ToString

        ElseIf e.ColumnIndex = DgKategori.Columns("hapus").Index AndAlso e.RowIndex >= 0 Then

            Dim result As DialogResult = MessageBox.Show("Apakah Anda yakin ingin menghapus " & dataKTG & "?",
                                                 "Konfirmasi", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

            If result = DialogResult.Yes Then

                ' Menghapus baris yang sesuai dengan tombol "Remove" yang diklik
                DgKategori.Rows.RemoveAt(e.RowIndex)

                '' Menghapus data dari database
                da = New MySqlDataAdapter("DELETE FROM tbl_kategori WHERE id_kategori = @id_kategori", conn)
                da.SelectCommand.Parameters.AddWithValue("@id_kategori", idKategori)
                da.Fill(ds, "kategori")
                ds.Clear()
                clear()
                data_kategori()

            End If
        End If
    End Sub
End Class