Imports MySql.Data.MySqlClient
Public Class PageOwner

    Dim ds As New DataSet
    Dim da As MySqlDataAdapter
    Dim conn As New MySqlConnection

    Public Property NamaOwner As String

    Sub koneksi()
        conn = New MySqlConnection("server= localhost" + ";user id=root" + "; 
                                        password=" + "; database=db_snaporder" + "")
        conn.Open()
    End Sub

    Private Sub TsKelolaAdmin_Click(sender As Object, e As EventArgs)
        MasterAdmin.Show()

    End Sub

    Private Sub TsReportTransaksi_Click(sender As Object, e As EventArgs)
        Report_Transaksi.Show()
    End Sub

    Private Sub TsKelolaTransaksi_Click(sender As Object, e As EventArgs)
        MasterTransaksi.Show()

    End Sub

    Private Sub TsLogout_Click(sender As Object, e As EventArgs)
        HomePage.Show()

    End Sub

    Private Sub TsMasterTransaksi_Click(sender As Object, e As EventArgs)
        MasterTransaksi.Show()

    End Sub

    Private Sub PageOwner_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub BtKelAdmin_Click(sender As Object, e As EventArgs) Handles BtKelAdmin.Click
        MasterAdmin.Show()
    End Sub

    Private Sub BtKelTransaksi_Click(sender As Object, e As EventArgs) Handles BtKelTransaksi.Click
        MasterTransaksi.Show()
    End Sub

    Private Sub BtLaporan_Click(sender As Object, e As EventArgs) Handles BtLaporan.Click
        Report_Transaksi.Show()
    End Sub

    Private Sub BtLogOut_Click(sender As Object, e As EventArgs) Handles BtLogOut.Click
        HomePage.Show()
        Me.Dispose()
    End Sub
End Class