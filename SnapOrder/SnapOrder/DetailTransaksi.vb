Imports MySql.Data.MySqlClient

Public Class DetailTransaksi

    Dim conn As MySqlConnection
    Dim da As New MySqlDataAdapter
    Dim ds As New DataSet

    Dim id_order As String = MasterTransaksi.id
    Dim nama_pemesan As String = MasterTransaksi.nama

    Sub koneksi()
        conn = New MySqlConnection("server= localhost" + ";user id=root" + "; 
                                        password=" + "; database=db_snaporder" + "")
        conn.Open()
    End Sub
    Private Sub DetailTransaksi_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.CenterToScreen()
    End Sub

    Sub tampil_data()
        ds.Clear()
        da = New MySqlDataAdapter(“SELECT
                                m.nama_menu AS nama_menu,
                                m.harga_menu AS harga_menu,
                                dt.jumlah AS jumlah,
                                dt.subtotal AS subtotal
                              FROM
                                tbl_transaksi t
                              JOIN
                                tbl_detailtransaksi dt ON t.id_transaksi = dt.id_transaksi
                              JOIN
                                tbl_menu m ON dt.id_menu = m.id_menu
                              WHERE dt.id_transaksi='" & id_order & "'", conn)
        da.Fill(ds, "detail")
        DgMenuItem.Rows.Clear()
        For i As Integer = 0 To ds.Tables("detail").Rows.Count - 1
            DgMenuItem.Rows.Add(ds.Tables("detail").Rows(i).ItemArray(0).ToString,
                                ds.Tables("detail").Rows(i).ItemArray(1).ToString,
                                ds.Tables("detail").Rows(i).ItemArray(2).ToString,
                                ds.Tables("detail").Rows(i).ItemArray(3).ToString)
        Next

    End Sub

    Private Sub DetailTransaksi_Activated(sender As Object, e As EventArgs) Handles MyBase.Activated
        koneksi()
        tampil_data()
        TbInvoice.Text = id_order
        TbNama_Pembeli.Text = nama_pemesan
        Dim total As Integer = 0
        For Each row As DataGridViewRow In DgMenuItem.Rows
            If row.Cells("SubTotal").Value IsNot Nothing Then
                total += row.Cells("SubTotal").Value
            End If
        Next

        TbTotalDetail.Text = total
    End Sub

    Private Sub BtnKeMasterTransaksi_Click(sender As Object, e As EventArgs) Handles BtnKeMasterTransaksi.Click
        MasterTransaksi.Show()
        Me.Dispose()
    End Sub


End Class