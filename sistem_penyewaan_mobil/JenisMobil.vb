Public Class JenisMobil

    Public Shared SelectedTableJenisMobil
    Public Sub New()
        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.

    End Sub

    'Button Tambah Jenis Mobil
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        TambahJenisMobil.Show()
    End Sub


    'Fungsi Menampilkan Data grid View Jenis MObil
    Private Sub ReloadDataTableDatabase()
        DGJenisMobil.DataSource = Home.DataJenisMobil.GetDataJenisMobilDatabase()
    End Sub

    'Menjalankan Fungsi Tampil Data Grid
    Private Sub JenisMobil_Activated(sender As Object, e As EventArgs) Handles Me.Activated
        ReloadDataTableDatabase()
    End Sub

    'Button Delete Jenis Mobil
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Home.DataJenisMobil.DeleteDataJenisMobilByIDDatabase(SelectedTableJenisMobil)
        ReloadDataTableDatabase()
    End Sub


    'Mengambil ID Jenis Mobil untuk dikirimkan ke Fungsi Delete Mobil
    Private Sub DGJenisMobil_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DGJenisMobil.CellClick
        Dim index As Integer = e.RowIndex
        Dim selectedRow As DataGridViewRow
        selectedRow = DGJenisMobil.Rows(index)

        SelectedTableJenisMobil = selectedRow.Cells(0).Value
    End Sub
End Class