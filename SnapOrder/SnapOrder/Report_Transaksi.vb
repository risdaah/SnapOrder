Imports MySql.Data.MySqlClient
Imports System.Globalization

Public Class Report_Transaksi

    Dim conn As New MySqlConnection
    Dim da As New MySqlDataAdapter
    Dim ds As New DataSet

    Sub koneksi()
        conn = New MySqlConnection("server= localhost" + ";user id=root" + "; 
                                        password=" + "; database=db_snaporder" + "")
        conn.Open()
    End Sub

    Private Sub Report_Transaksi_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.CenterToScreen()
        koneksi()
    End Sub

    Sub tampil_laporan()
        Try
            da = New MySqlDataAdapter("SELECT * FROM tbl_transaksi", conn)
            da.Fill(ds, "laporan")
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Terjadi Kesalahan", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Sub tampil_laporan_dari_tanggal()
        Dim TglLaporan As DateTime = PilihTgl.Value
        Dim formattedDate As String = TglLaporan.ToString("yyyy-MM-dd")

        Try
            da = New MySqlDataAdapter("SELECT * FROM tbl_transaksi WHERE DATE(tanggal_transaksi)  ='" & formattedDate & "';", conn)
            da.Fill(ds, "laporan_tgl")
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Terjadi Kesalahan", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Sub tampil_laporan_dari_bulan_tahun()

        Dim selectedMonth As Integer = 0
        Dim selectedYear As Integer = Convert.ToInt32(CbTahun.SelectedItem)

        Select Case CbBulan.SelectedItem.ToString()
            Case "Januari"
                selectedMonth = "01"
            Case "Februari"
                selectedMonth = "02"
            Case "Maret"
                selectedMonth = "03"
            Case "April"
                selectedMonth = "04"
            Case "Mei"
                selectedMonth = "05"
            Case "Juni"
                selectedMonth = "06"
            Case "Juli"
                selectedMonth = "07"
            Case "Agustus"
                selectedMonth = "08"
            Case "September"
                selectedMonth = "09"
            Case "Oktober"
                selectedMonth = "10"
            Case "November"
                selectedMonth = "11"
            Case "Desember"
                selectedMonth = "12"
        End Select

        Dim formattedDate As String = selectedYear.ToString() & "-" & selectedMonth.ToString()

        Try
            da = New MySqlDataAdapter("Select * FROM tbl_transaksi WHERE DATE_FORMAT(tanggal_transaksi, '%Y-%m') = '" & formattedDate & "';", conn)
            da.Fill(ds, "laporan_bulan_tahun")
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Terjadi Kesalahan", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub

    Private Sub BtnTampilLaporanDariTanggal_Click(sender As Object, e As EventArgs) Handles BtnTampilLaporanDariTanggal.Click
        Try
            Dim myrpt As New LaporanTransaksi
            tampil_laporan_dari_tanggal()
            myrpt.SetDataSource(ds.Tables("laporan_tgl"))
            CrystalReportViewer1.ReportSource = Nothing
            CrystalReportViewer1.ReportSource = myrpt
        Catch ex As Exception
            MessageBox.Show("Error : " & ex.Message)
        End Try
    End Sub

    Private Sub BtnTampilkanAllLaporan_Click(sender As Object, e As EventArgs) Handles BtnTampilkanAllLaporan.Click
        Try
            Dim myrpt As New LaporanTransaksi
            tampil_laporan()
            myrpt.SetDataSource(ds.Tables("laporan"))
            CrystalReportViewer1.ReportSource = Nothing
            CrystalReportViewer1.ReportSource = myrpt
        Catch ex As Exception
            MessageBox.Show("Error : " & ex.Message)
        End Try
    End Sub

    Private Sub BtnTampilLaporanBln_Click(sender As Object, e As EventArgs) Handles BtnTampilLaporanBln.Click
        Try
            Dim myrpt As New LaporanTransaksi
            ds.Clear()
            tampil_laporan_dari_bulan_tahun()
            myrpt.SetDataSource(ds.Tables("laporan_bulan_tahun"))
            CrystalReportViewer1.ReportSource = Nothing
            CrystalReportViewer1.ReportSource = myrpt
        Catch ex As Exception
            MessageBox.Show("Error : " & ex.Message)
        End Try
    End Sub
End Class