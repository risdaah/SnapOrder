Imports MySql.Data.MySqlClient
Public Class MasterTransaksi

    Dim ds As New DataSet
    Dim da As MySqlDataAdapter
    Dim conn As New MySqlConnection

    Sub koneksi()
        conn = New MySqlConnection("server= localhost" + ";user id=root" + "; 
                                        password=" + "; database=db_snaporder" + "")
        conn.Open()
    End Sub

    Private Sub MasterTransaksi_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.CenterToScreen()
        koneksi()
        tampil_data()
        Dim total As Integer = 0
        For Each row As DataGridViewRow In DgMasterTransaksi.Rows
            If row.Cells("total").Value IsNot Nothing Then
                total += row.Cells("total").Value
            End If
        Next
        TbTotalPemasukan.Text = total
    End Sub

    Sub tampil_data()
        Try
            ds.Clear()
            da = New MySqlDataAdapter("SELECT * FROM tbl_transaksi;", conn)
            da.Fill(ds, "transaksi")
            DgMasterTransaksi.Rows.Clear()
            For i As Integer = 0 To ds.Tables("transaksi").Rows.Count - 1
                DgMasterTransaksi.Rows.Add(ds.Tables("transaksi").Rows(i).Item(0).ToString,
                                           ds.Tables("transaksi").Rows(i).Item(2).ToString,
                                           ds.Tables("transaksi").Rows(i).Item(4))
            Next
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Terjadi Kesalahan", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Public id As String
    Public nama As String
    Private Sub DgMasterTransaksi_DoubleClick(sender As Object, e As EventArgs) Handles DgMasterTransaksi.DoubleClick
        Try
            If DgMasterTransaksi.SelectedRows.Count > 0 Then
                Dim selectedRow As DataGridViewRow = DgMasterTransaksi.SelectedRows(0)
                id = selectedRow.Cells("id_transaksi").Value.ToString()
                nama = selectedRow.Cells("nama_pembeli").Value.ToString()
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Terjadi Kesalahan", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

        Me.Hide()
        DetailTransaksi.Show()

    End Sub

    Private Sub TsReportTransaksi_Click(sender As Object, e As EventArgs)
        Report_Transaksi.Show()
    End Sub

    Private Sub TsMasterMenu_Click(sender As Object, e As EventArgs)
        MasterMenu.Show()
        Me.Hide()
    End Sub

    Private Sub TsLogout_Click(sender As Object, e As EventArgs)
        HomePage.Show()
        Me.Hide()

    End Sub

    Private Sub DgMasterTransaksi_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DgMasterTransaksi.CellContentClick

    End Sub
End Class