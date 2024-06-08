Imports MySql.Data.MySqlClient

Public Class MasterAdmin
    Dim ds As New DataSet
    Dim da As MySqlDataAdapter
    Dim conn As New MySqlConnection
    Dim id As String = ""

    Sub koneksi()
        conn = New MySqlConnection("server= localhost" + ";user id=root" + "; 
                                        password=" + "; database=db_snaporder" + "")
        conn.Open()

    End Sub

    Private Sub MasterAdmin_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.CenterToScreen()
        clear()
        koneksi()
        tampil_id()
    End Sub

    Private Sub MasterAdmin_Activated(sender As Object, e As EventArgs) Handles MyBase.Activated
        koneksi()
        data_admin()
        tampil_id()
    End Sub

    Private Sub TsPageOwner_Click(sender As Object, e As EventArgs)
        PageOwner.Show()
        Me.Hide()
    End Sub

    Private Sub TsReportTransaksi_Click(sender As Object, e As EventArgs)
        Report_Transaksi.Show()
        Me.Hide()
    End Sub

    Private Sub TsLogout_Click(sender As Object, e As EventArgs)
        HomePage.Show()
        Me.Hide()
    End Sub

    Sub clear()
        For Each ctr In Me.Controls
            If TypeOf ctr Is TextBox Then
                ctr.Text = ""
            End If
        Next
    End Sub

    Sub data_admin()

        Try
            ds.Clear()
            Dim query As String = "SELECT id_user, nama, password, email FROM tbl_user WHERE id_user LIKE '%ADM%'"
            da = New MySqlDataAdapter(query, conn)
            da.Fill(ds, "tbl_user")
            DgAdmin.Rows.Clear()
            For i As Integer = 0 To ds.Tables("tbl_user").Rows.Count - 1
                DgAdmin.Rows.Add(ds.Tables("tbl_user").Rows(i).Item(0).ToString,
                                    ds.Tables("tbl_user").Rows(i).Item(1).ToString,
                                    ds.Tables("tbl_user").Rows(i).Item(2).ToString,
                                    ds.Tables("tbl_user").Rows(i).Item(3).ToString)
            Next
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Terjadi Kesalahan", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

        conn.Close()
    End Sub

    Sub tampil_id()
        ds.Clear()
        da = New MySqlDataAdapter("Select Case When MAX(CONVERT(SUBSTRING(id_user, 4), SIGNED)) Is NULL Then 
                                    'ADM001' ELSE CONCAT('ADM', LPAD(MAX(CONVERT(SUBSTRING(id_user, 4), SIGNED)) + 1, 3, '0')) 
                                    END AS next_id_user FROM tbl_user WHERE id_user LIKE 'ADM%';", conn)
        da.Fill(ds, "id")
        id = ds.Tables("id").Rows(0).Item(0).ToString
        TbIDAdmin.Text = id
    End Sub

    Private Sub BtnTambahAdmin_Click(sender As Object, e As EventArgs) Handles BtnTambahAdmin.Click
        Dim cek As Boolean = True

        If TbNama.Text = "" Then
            ErrorProvider1.SetError(TbNama, "Data Tidak Boleh Kosong")
            cek = False
        End If

        Dim role As String = "Admin"

        If cek = True Then
            conn.Open()
            ds.Clear()
            da = New MySqlDataAdapter("insert into tbl_user values (?,?,?,?,?)", conn)
            da.SelectCommand.Parameters.AddWithValue("id_user", TbIDAdmin.Text)
            da.SelectCommand.Parameters.AddWithValue("nama", TbNama.Text)
            da.SelectCommand.Parameters.AddWithValue("password", TbPassword.Text)
            da.SelectCommand.Parameters.AddWithValue("email", TbEmail.Text)
            da.SelectCommand.Parameters.AddWithValue("role", role)
            da.Fill(ds, "admin")
            ds.Clear()
            conn.Close()
            clear()
            data_admin()
            tampil_id()
        End If
    End Sub

    Private Sub DgAdmin_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DgAdmin.CellContentClick
        Dim selectedRow As DataGridViewRow = DgAdmin.Rows(e.RowIndex)
        Dim dataAdm As String = selectedRow.Cells("nama").Value.ToString

        ' Mengambil data dari kolom yang sesuai
        Dim id_user As String = selectedRow.Cells("id_user").Value

        If e.ColumnIndex = DgAdmin.Columns("ubah").Index AndAlso e.RowIndex >= 0 Then
            'Mengambil Data row
            TbIDAdmin.Text = selectedRow.Cells("id_user").Value.ToString
            TbNama.Text = selectedRow.Cells("nama").Value.ToString
            TbEmail.Text = selectedRow.Cells("email").Value.ToString
            TbPassword.Text = selectedRow.Cells("password").Value.ToString

        ElseIf e.ColumnIndex = DgAdmin.Columns("hapus").Index AndAlso e.RowIndex >= 0 Then

            Dim result As DialogResult = MessageBox.Show("Apakah Anda yakin ingin menghapus " & dataAdm & "?",
                                                 "Konfirmasi", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

            If result = DialogResult.Yes Then

                ' Menghapus baris yang sesuai dengan tombol "Remove" yang diklik
                DgAdmin.Rows.RemoveAt(e.RowIndex)

                '' Menghapus data dari database
                da = New MySqlDataAdapter("DELETE FROM tbl_user WHERE id_user = @id_user", conn)
                da.SelectCommand.Parameters.AddWithValue("@id_user", id_user)
                da.Fill(ds, "admin")
                ds.Clear()
                clear()
                data_admin()

            End If
        End If
    End Sub

    Private Sub BtnUbahAdmin_Click(sender As Object, e As EventArgs) Handles BtnUbahAdmin.Click

        Dim idAdmin As String = TbIDAdmin.Text
        Dim namaAdmin As String = TbNama.Text
        Dim emailAdmin As String = TbEmail.Text
        Dim passwordAdmin As String = TbPassword.Text

        Dim result As DialogResult = MessageBox.Show("Apakah Anda yakin ingin mengubah kategori " & namaAdmin & " ini?",
                                                         "Konfirmasi", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

        If result = DialogResult.Yes Then

            da = New MySqlDataAdapter("UPDATE tbl_user SET nama = @nama, email = @email, password = @password WHERE id_user = @id_user", conn)
            da.SelectCommand.Parameters.AddWithValue("@id_user", idAdmin)
            da.SelectCommand.Parameters.AddWithValue("@nama", namaAdmin)
            da.SelectCommand.Parameters.AddWithValue("@email", emailAdmin)
            da.SelectCommand.Parameters.AddWithValue("@password", passwordAdmin)
            da.Fill(ds, "admin")
            ds.Clear()
            data_admin()
            clear()
            tampil_id()

            conn.Close()
        End If

    End Sub

End Class