Public Class PageMaster
    Private Sub TsKelolaKategori_Click(sender As Object, e As EventArgs)
        MasterKategori.Show()

    End Sub

    Private Sub TsKelolaMenu_Click(sender As Object, e As EventArgs)
        MasterMenu.Show()

    End Sub

    Private Sub TsKelolaAdmin_Click(sender As Object, e As EventArgs)
        MasterAdmin.Show()

    End Sub

    Private Sub TsKelolaTransaksi_Click(sender As Object, e As EventArgs)
        MasterTransaksi.Show()

    End Sub

    Private Sub TsReportTransaksi_Click(sender As Object, e As EventArgs)
        Report_Transaksi.Show()

    End Sub

    Private Sub TsKelolaOwner_Click(sender As Object, e As EventArgs)
        MasterOwner.Show()
    End Sub

    Private Sub TsLogout_Click(sender As Object, e As EventArgs)
        HomePage.Show()
        Me.Hide()
    End Sub

    Private Sub BtKelKategori_Click(sender As Object, e As EventArgs) Handles BtKelKategori.Click
        MasterKategori.Show()
    End Sub

    Private Sub BtKelMenu_Click(sender As Object, e As EventArgs) Handles BtKelMenu.Click
        MasterMenu.Show()
    End Sub

    Private Sub BtKelOwner_Click(sender As Object, e As EventArgs) Handles BtKelOwner.Click
        MasterOwner.Show()
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