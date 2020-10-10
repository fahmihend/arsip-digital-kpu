Imports MySql.Data.MySqlClient
Module ModuleKoneksi
    Public ConMySQL As MySqlConnection
    Public constrMySQL As String
    Public usertypeMySQL As String
    Public da As MySqlDataAdapter
    Public ds As DataSet
    Public cmd As MySqlCommand
    Public dr As MySqlDataReader
    Public str As String

    Public Sub mainMySQL()

        constrMySQL = My.Settings.Koneksi
        ConMySQL = New MySqlConnection(constrMySQL)
        Try
            ConMySQL.Open()
            'MsgBox("Server Connection is Open ! ")

            ConMySQL.Close()
        Catch ex As Exception
            MsgBox("Sorry Can not open connection ! ")

        End Try

    End Sub
End Module
