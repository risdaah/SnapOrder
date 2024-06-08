Imports MySql.Data.MySqlClient

Public Class HomePage
    Dim ds As New DataSet
    Dim da As MySqlDataAdapter
    Dim conn As New MySqlConnection
    Sub koneksi()
        conn = New MySqlConnection("server= localhost" + ";user id=root" + "; 
                                        password=" + "; database=db_snaporder" + "")

    End Sub

    Private Sub HomePage_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.CenterToScreen()
        koneksi()
        TbPass.UseSystemPasswordChar = True
    End Sub

    Private Sub BtnLogin_Click(sender As Object, e As EventArgs)
        transisi.ShowSync(PanelLog)
    End Sub

    Private Sub BtnDineIn_Click(sender As Object, e As EventArgs)
        Me.Hide()
        Dim PageMenu As New Pembelian()
        PageMenu.SetText("Dine In")
        PageMenu.Show()
    End Sub

    Private Sub BtnTakeOut_Click(sender As Object, e As EventArgs)
        Me.Hide()
        Dim PageMenu As New Pembelian()
        PageMenu.SetText("Take Out")
        PageMenu.Show()
    End Sub



    Private Sub BtMasuk_Click(sender As Object, e As EventArgs) Handles BtMasuk.Click
        Dim email As String = TbEmail.Text
        Dim password As String = TbPass.Text

        conn.Open()
        Dim query As String = "SELECT * FROM tbl_user WHERE email = @email AND password = @password"
        Dim command As New MySqlCommand(query, conn)
        command.Parameters.AddWithValue("@email", email)
        command.Parameters.AddWithValue("@password", password)

        Try
            Dim result As Object = command.ExecuteScalar()

            If result IsNot Nothing Then
                Dim id_user As String = result.ToString
                Dim ambilRole As String = "SELECT role FROM tbl_user WHERE id_user = @id_user"
                Dim roleCommand As New MySqlCommand(ambilRole, conn)
                roleCommand.Parameters.AddWithValue("@id_user", id_user)

                Dim ambilNama As String = "SELECT nama FROM tbl_user WHERE id_user = @id_user"
                Dim namaCommand As New MySqlCommand(ambilNama, conn)
                namaCommand.Parameters.AddWithValue("@id_user", id_user)

                Dim roleResult As Object = roleCommand.ExecuteScalar()
                Dim namaResult As Object = namaCommand.ExecuteScalar()

                If roleResult IsNot Nothing Then
                    Dim role As String = roleResult.ToString()

                    If role = "Master" Then
                        MessageBox.Show("Login berhasil sebagai Master!")



                        Me.Hide()
                        PageMaster.Show()

                    ElseIf role = "Admin" Then
                        MessageBox.Show("Login berhasil sebagai Admin!")

                        Me.Hide()
                        PageAdmin.Show()

                    ElseIf role = "Owner" Then
                        MessageBox.Show("Login berhasil sebagai Owner!")
                        Me.Hide()
                        PageOwner.Show()

                    Else
                        MessageBox.Show("Akun tidak ada!")

                    End If
                Else
                    MessageBox.Show("akun tidak ditemukan!")
                End If
            Else
                MessageBox.Show("Email atau password salah!")
            End If

        Catch ex As Exception
            MessageBox.Show("Terjadi kesalahan: " & ex.Message)

        Finally
            conn.Close()
        End Try

        TbEmail.ResetText()
        TbPass.ResetText()
    End Sub

    Private Sub Label5_Click(sender As Object, e As EventArgs) Handles Label5.Click
        transisi.HideSync(PanelLog)
    End Sub

    Private Sub Guna2CircleButton1_Click(sender As Object, e As EventArgs) Handles Guna2CircleButton1.Click
        transisi.ShowSync(PanelLog)
    End Sub

    Private Sub CbTampilkanPass_CheckedChanged(sender As Object, e As EventArgs) Handles CbTampilkanPass.CheckedChanged
        If TbPass.UseSystemPasswordChar = True Then
            TbPass.UseSystemPasswordChar = False
        Else
            TbPass.UseSystemPasswordChar = True
        End If

    End Sub

    Private Sub BtDineIn_Click(sender As Object, e As EventArgs)
        Me.Hide()
        Dim PageMenu As New Pembelian()
        PageMenu.SetText("Dine In")
        PageMenu.Show()
    End Sub

    Private Sub BtTakeOut_Click(sender As Object, e As EventArgs)
        Me.Hide()
        Dim PageMenu As New Pembelian()
        PageMenu.SetText("Take Out")
        PageMenu.Show()
    End Sub

    Private Sub BtDineIn_Click_1(sender As Object, e As EventArgs) Handles BtDineIn.Click
        Me.Hide()
        Dim PageMenu As New Pembelian()
        PageMenu.SetText("Dine In")
        PageMenu.Show()
    End Sub

    Private Sub BtTakeOut_Click_1(sender As Object, e As EventArgs) Handles BtTakeOut.Click
        Me.Hide()
        Dim PageMenu As New Pembelian()
        PageMenu.SetText("Take Out")
        PageMenu.Show()
    End Sub
End Class
