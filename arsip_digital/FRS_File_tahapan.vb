Imports Microsoft.Reporting.WinForms
Imports MySql.Data.MySqlClient
Public Class FRS_File_tahapan
    Dim strSql As String
    Dim perintah As New MySqlCommand
    Dim DAdapter As New MySqlDataAdapter
    Dim DReader As MySqlDataReader
    Sub tampiltahapan()
        ConMySQL = New MySqlConnection(constrMySQL)
        ConMySQL.Open()
        perintah = New MySqlCommand("select tahapan from t_tahapan", ConMySQL)
        DReader = perintah.ExecuteReader
        ComboBox1.Items.Clear()
        Do While DReader.Read
            ComboBox1.Items.Add(DReader.Item("tahapan"))
        Loop
        ConMySQL.Close()
    End Sub
    Private Sub FRS_File_tahapan1_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'db_arsipDataSet1.t_file' table. You can move, or remove it, as needed.
        Me.t_fileTableAdapter.Fill(Me.db_arsipDataSet1.t_file)

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
End Class