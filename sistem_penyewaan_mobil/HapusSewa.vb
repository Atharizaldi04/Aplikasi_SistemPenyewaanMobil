Public Class HapusSewa
    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        If Not String.IsNullOrEmpty(Home.DataSewa.foto_mobilProperty) Then
            PicFoto.Load(Home.DataSewa.foto_mobilProperty)
            PicFoto.SizeMode = PictureBoxSizeMode.StretchImage
        End If

        If Not String.IsNullOrEmpty(Home.DataSewa.foto_ktpProperty) Then
            PictKTP.Load(Home.DataSewa.foto_ktpProperty)
            PictKTP.SizeMode = PictureBoxSizeMode.StretchImage
        End If

        LblHargaSewa.Text = FormatCurrency(Home.DataSewa.hargaunitProperty)
        LblLamaSewa.Text = Home.DataSewa.lamaSewaProperty
        LblMerk.Text = Home.DataSewa.merkProperty
        LblNamaPenyewa.Text = Home.DataSewa.namaProperty
        LblNik.Text = Home.DataSewa.nikProperty
        LblPlatNomor.Text = Home.DataSewa.platNomorProperty
        LblRencanaKembali.Text = Home.DataSewa.rencana_pinjamProperty
        LblTglPinjam.Text = Home.DataSewa.tanggal_pinjamProperty
        LblTotalBiaya.Text = FormatCurrency(Home.DataSewa.total_biaya_SewaProperty)

        Home.DataRiwayatTransaksi.status_mobilProperty = "Tersedia"
        Home.DataRiwayatTransaksi.status_penyewaProperty = "Tersedia"

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        Home.DataMobil.UpdateStatusMobilByPlatDatabase(Sewa.SelectedIdMobil,
                                                     Home.DataRiwayatTransaksi.status_mobilProperty)

        Home.DataPenyewa.UpdateStatusPenyewaByNikDatabase(Sewa.SelectedIdPenyewa,
                                                         Home.DataRiwayatTransaksi.status_penyewaProperty)

        Home.DataSewa.DeleteDataSewalByIDDatabase(Sewa.SelectedTableSewa)
        Me.Close()
    End Sub
End Class