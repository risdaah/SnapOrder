Public Class PageAdmin


    Private Sub TsKelolaMenu_Click(sender As Object, e As EventArgs) 
        MasterMenu.Show()

    End Sub

    Private Sub TsKelolaKategori_Click(sender As Object, e As EventArgs) 
        MasterKategori.Show()

    End Sub

    Private Sub TsLogout_Click(sender As Object, e As EventArgs)
        HomePage.Show()

    End Sub

    Private Sub BtKelKategori_Click(sender As Object, e As EventArgs) Handles BtKelKategori.Click
        MasterKategori.Show()
    End Sub

    Private Sub BtKelMenu_Click(sender As Object, e As EventArgs) Handles BtKelMenu.Click
        MasterMenu.Show()
    End Sub

    Private Sub BtLogOut_Click(sender As Object, e As EventArgs) Handles BtLogOut.Click
        HomePage.Show()
        Me.Dispose()
    End Sub

End Class