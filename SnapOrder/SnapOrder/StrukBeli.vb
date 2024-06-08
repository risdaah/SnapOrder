Imports MySql.Data.MySqlClient

Public Class StrukBeli

    Dim conn As New MySqlConnection
    Dim da As New MySqlDataAdapter
    Dim ds As New DataSet
    Public Property NoInvoice As String
    Public Property NamaCustomer As String
    Public Property Pembayaran As String


    Sub koneksi()
        conn = New MySqlConnection("Server=localhost;user id=root;password=;database=db_snaporder")
        conn.Open()
    End Sub

    Private Sub StrukBeli_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.CenterToScreen()
        koneksi()
    End Sub

    Sub tampil_struk()
        Try
            da = New MySqlDataAdapter("SELECT
                                            t.id_transaksi,
                                            t.nama_pembeli,
                                            t.catatan,
                                            m.nama_menu AS nama_menu,
                                            m.harga_menu AS harga_menu,
                                            dt.jumlah AS jumlah,
                                            dt.subtotal AS subtotal
                                       FROM
                                            tbl_transaksi t 
                                       JOIN 
                                            tbl_detailtransaksi dt ON t.id_transaksi = dt.id_transaksi
                                       LEFT JOIN
                                            tbl_menu m ON dt.id_menu = m.id_menu
                                       WHERE 
                                            dt.id_transaksi = @id_transaksi", conn)
            da.SelectCommand.Parameters.AddWithValue("@id_transaksi", NoInvoice)
            da.Fill(ds, "struk")
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Terjadi Kesalahan", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub StrukBeli_Activated(sender As Object, e As EventArgs) Handles MyBase.Activated
        ds.Clear()
        koneksi()
        Try
            Dim report As New NotaTransaksi

            tampil_struk()
            report.SetDataSource(ds.Tables("struk"))

            For Each paramField As CrystalDecisions.CrystalReports.Engine.ParameterFieldDefinition In report.ParameterFields
                Select Case paramField.Name
                    Case "nama_pembeli"
                        paramField.CurrentValues.Clear()
                        paramField.CurrentValues.AddValue(NamaCustomer)
                        report.DataDefinition.ParameterFields(paramField.Name).ApplyCurrentValues(paramField.CurrentValues)
                    Case "id_transaksi"
                        paramField.CurrentValues.Clear()
                        paramField.CurrentValues.AddValue(NoInvoice)
                        report.DataDefinition.ParameterFields(paramField.Name).ApplyCurrentValues(paramField.CurrentValues)
                End Select
            Next

            CrystalReportViewer1.ReportSource = report
        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message & vbCrLf & ex.StackTrace, "Crystal Reports Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
End Class