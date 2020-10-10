Imports Microsoft.Reporting.WinForms
Imports MySql.Data.MySqlClient
Public Class FR_Tahapan
    Dim strSql As String
    Dim perintah As New MySqlCommand
    Dim DAdapter As New MySqlDataAdapter
    Dim DReader As MySqlDataReader
    Sub tampiltahapan()
        ConMySQL = New MySqlConnection(constrMySQL)
        ConMySQL.Open()
        perintah = New MySqlCommand("select distinct tahapan from t_tahapan", ConMySQL)
        DReader = perintah.ExecuteReader
        ComboBox1.Items.Clear()
        Do While DReader.Read
            ComboBox1.Items.Add(DReader.Item("tahapan"))
        Loop
        ConMySQL.Close()
    End Sub
    Private Sub FR_Tahapan_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'db_arsipDataSet.t_file' table. You can move, or remove it, as needed.
        Me.t_fileTableAdapter.Fill(Me.db_arsipDataSet.t_file)

        Me.ReportViewer1.RefreshReport()
        mainMySQL()
        tampiltahapan()

    End Sub

    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click
        Dim pkelas As New ReportParameter("ptahapan", ComboBox1.Text)

        With Me
            .ReportViewer1.RefreshReport()
            .ReportViewer1.LocalReport.SetParameters(pkelas)
            .ReportViewer1.RefreshReport()
        End With
    End Sub

    Private Sub Button2_Click(sender As System.Object, e As System.EventArgs) Handles Button2.Click
        FG_Tahapan.Show()

    End Sub
End Class