Imports MySql.Data.MySqlClient
Public Class DataJenisMobil

    'Deklarasi Data Jenis Mobil
    Private id_jenis_mobil As String
    Private jenis_mobil As String
    Private tanggal_input As String

    'Deklarasi Database
    Public Shared ID
    Private koleksiDataTable As New ArrayList()
    Public Shared dbConn As New MySqlConnection
    Public Shared sqlCommand As New MySqlCommand
    Public Shared sqlRead As MySqlDataReader
    Private sqlQuery As String
    Private server As String = "localhost"
    Private username As String = "root"
    Private password As String = " "
    Private database As String = "sistem_penyewaan_mobil"


    'Get Data Jenis Mobil dari Databse
    Public Function GetDataJenisMobilDatabase() As DataTable
        Dim result As New DataTable
        dbConn.ConnectionString = "server = " + server + " ;" + "user id = " + username + " ;" _
                                + "password = " + password + " ;" + "database = " + database
        dbConn.Open()
        sqlCommand.Connection = dbConn
        sqlCommand.CommandText = " SELECT id_jenis_mobil AS 'ID',
                                    jenis_mobil AS 'Jenis Mobil', 
                                    tanggal_input AS 'Tanggal Input'
                                    FROM db_jenismobil"
        sqlRead = sqlCommand.ExecuteReader

        result.Load(sqlRead)
        sqlRead.Close()
        dbConn.Close()
        Return result
    End Function

    'Menambahkan data Jenis Mobil ke Database
    Public Function AddDataJenisMobilDatabase(jenis_mobil As String,
                                              tanggal_input As String)

        dbConn.ConnectionString = "server = " + server + " ;" + "user id = " + username + " ;" _
                                + "password = " + password + " ;" + "database = " + database
        Try
            dbConn.Open()
            sqlCommand.Connection = dbConn
            sqlQuery = "INSERT INTO DB_JENISMOBIL(jenis_mobil, tanggal_input) VALUE('" _
            & jenis_mobil & "', '" _
            & tanggal_input & "')"

            Debug.WriteLine(sqlQuery)
            sqlCommand = New MySqlCommand(sqlQuery, dbConn)
            sqlRead = sqlCommand.ExecuteReader
            dbConn.Close()

            'Perpustakaan.sqlDt.Load(sqlRead)
            sqlRead.Close()
            dbConn.Close()

        Catch ex As Exception
            Return ex.Message
        Finally
            dbConn.Dispose()
        End Try
    End Function


    'Mengambil data jenis mobil dari database berdasarkan ID 
    Public Function GetDataJenisMobilByIDDatabase(ID As Integer) As List(Of String)
        Dim result As New List(Of String)

        dbConn.ConnectionString = "server = " + server + " ;" + "user id = " + username + " ;" _
                                + "password = " + password + " ;" + "database = " + database
        dbConn.Open()

        sqlCommand.Connection = dbConn
        sqlCommand.CommandText = "SELECT jenis_mobil, 
                                    tanggal_input
                                    FROM db_jenismobil
                                    WHERE id_jenis_mobil='" & ID & "'"

        sqlRead = sqlCommand.ExecuteReader
        While sqlRead.Read
            result.Add(sqlRead.GetString(0).ToString())
            result.Add(sqlRead.GetString(1).ToString())
            result.Add(sqlRead.GetString(2).ToString())
        End While
        sqlRead.Close()
        dbConn.Close()
        Return result
    End Function


    'Update Data Jenis Mobil
    Public Function UpdateDataJenisMobilByIDDatabase(ID As Integer,
                                                    jenis_mobil As String,
                                                    tanggal_input As String)

        dbConn.ConnectionString = "server = " + server + " ;" + "user id = " + username + " ;" _
                                + "password = " + password + " ;" + "database = " + database
        Try
            dbConn.Open()
            sqlCommand.Connection = dbConn
            sqlQuery = "UPDATE db_jenismobil SET " &
            "jenis_mobil = '" & jenis_mobil & "', " &
            "tanggal_input = '" & tanggal_input & "', " &
            "WHERE id_penyewa = '" & ID & "'"
            'Debug.WriteLine(sqlQuery)
            sqlCommand = New MySqlCommand(sqlQuery, dbConn)
            sqlRead = sqlCommand.ExecuteReader
            dbConn.Close()

            'Perpustakaan.sqlDt.Load(sqlRead)
            sqlRead.Close()
            dbConn.Close()

        Catch ex As Exception
            Return ex.Message
        Finally
            dbConn.Dispose()
        End Try
    End Function

    'Menghapus Data Jenis Mobil
    Public Function DeleteDataJenisMobilByIDDatabase(ID As Integer)
        dbConn.ConnectionString = "server = " + server + " ;" + "user id = " + username + " ;" _
                                + "password = " + password + " ;" + "database = " + database
        Try
            dbConn.Open()
            sqlCommand.Connection = dbConn
            sqlQuery = "DELETE FROM db_jenismobil " &
                        "WHERE id_jenis_mobil = '" & ID & "'"
            Debug.WriteLine(sqlQuery)
            sqlCommand = New MySqlCommand(sqlQuery, dbConn)
            sqlRead = sqlCommand.ExecuteReader
            dbConn.Close()

            'Perpustakaan.sqlDt.Load(sqlQuery)

            sqlRead.Close()
            dbConn.Close()
        Catch ex As Exception
            Return ex.Message
        Finally
            dbConn.Dispose()
        End Try
    End Function


    'Getter And Setter Data Jenis Mobil
    Public Property jenis_mobilProperty() As String
        Get
            Return jenis_mobil
        End Get
        Set(ByVal value As String)
            jenis_mobil = value
        End Set
    End Property

    Public Property tanggal_inputProperty() As String
        Get
            Return tanggal_input
        End Get
        Set(ByVal value As String)
            tanggal_input = value
        End Set
    End Property

End Class
