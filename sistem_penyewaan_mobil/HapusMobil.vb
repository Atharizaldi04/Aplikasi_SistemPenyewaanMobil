Public Class HapusMobil

    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()
        LbNama.Text = Mobil.SelectedTablePlatMobil
        ' Add any initialization after the InitializeComponent() call.

    End Sub

    'Btn Delete Mobil
    Private Sub BtnHapusKoleksi_Click(sender As Object, e As EventArgs) Handles BtnHapusKoleksi.Click
        Home.DataMobil.DeleteDataMobilByIDDatabase(Mobil.SelectedTableMobil)
        Me.Close()
    End Sub
End Class