Imports MySql.Data.MySqlClient
Public Class F_pengunjung_file
    Dim strSql As String
    Dim perintah As New MySqlCommand
    Dim DAdapter As New MySqlDataAdapter
    Dim DReader As MySqlDataReader
    Dim keterangantemp As String
    Dim pdf As String
    Sub kosongkan()
        TanggalDateTimePicker.Value = Now
        IdTextBox.Clear()
        Nama_fileTextBox.Clear()
        DivisiTextBox.Text = ""
        TahapanTextBox.Text = ""
        Kode_naskah_dinasTextBox.Clear()
        Kode_biroTextBox.Clear()
        Kode_jabatanTextBox.Clear()
        Kode_wilayahTextBox.Clear()
        BulanTextBox.Text = ""
        TahunTextBox.Clear()
        FileTextBox.Clear()
        JenisTextBox.Text = ""
        IntisariTextBox.Clear()
        PutusanTextBox.Clear()
        KronologiTextBox.Clear()
        Kode_arsip_fasilitatisTextBox.Clear()
        Kode_arsip_substantifTextBox.Clear()
        KeteranganTextBox.Text = ""
        caridata.Clear()
        RakTextBox.Clear()
        IdTextBox.Enabled = False
        AxAcroPDF1.Refresh()

    End Sub
    Sub caridatanama()
        ConMySQL = New MySqlConnection(constrMySQL)
        ConMySQL.Open()
        Dim da As New MySqlDataAdapter("select * from t_file where nama_file like '%" & caridata.Text & "%' AND status like '%" & "1" & "%' order by tanggal", ConMySQL)
        Dim dt As New DataTable
        da.Fill(dt)
        DataGridView1.DataSource = dt
        ConMySQL.Close()
    End Sub
    Sub caridatadivisi()
        ConMySQL = New MySqlConnection(constrMySQL)
        ConMySQL.Open()
        Dim da As New MySqlDataAdapter("select * from t_file where divisi like '%" & caridata.Text & "%' AND status like '%" & "1" & "%' order by tanggal", ConMySQL)
        Dim dt As New DataTable
        da.Fill(dt)
        DataGridView1.DataSource = dt
        ConMySQL.Close()
    End Sub
    Sub caridatajenis()
        ConMySQL = New MySqlConnection(constrMySQL)
        ConMySQL.Open()
        Dim da As New MySqlDataAdapter("select * from t_file where jenis like '%" & caridata.Text & "%' AND status like '%" & "1" & "%' order by tanggal", ConMySQL)
        Dim dt As New DataTable
        da.Fill(dt)
        DataGridView1.DataSource = dt
        ConMySQL.Close()
    End Sub
    Sub caridataintisari()
        ConMySQL = New MySqlConnection(constrMySQL)
        ConMySQL.Open()
        Dim da As New MySqlDataAdapter("select * from t_file where intisari like '%" & caridata.Text & "%' AND status like '%" & "1" & "%' order by tanggal", ConMySQL)
        Dim dt As New DataTable

        da.Fill(dt)
        DataGridView1.DataSource = dt
        ConMySQL.Close()
    End Sub
    Sub caridataputusan()
        ConMySQL = New MySqlConnection(constrMySQL)
        ConMySQL.Open()
        Dim da As New MySqlDataAdapter("select * from t_file where putusan like '%" & caridata.Text & "%' AND status like '%" & "1" & "%' order by tanggal", ConMySQL)
        Dim dt As New DataTable
        da.Fill(dt)
        DataGridView1.DataSource = dt
        ConMySQL.Close()
    End Sub
    Sub caridatakronologi()
        ConMySQL = New MySqlConnection(constrMySQL)
        ConMySQL.Open()
        Dim da As New MySqlDataAdapter("select * from t_file where kronologi like '%" & caridata.Text & "%' AND status like '%" & "1" & "%' order by tanggal", ConMySQL)
        Dim dt As New DataTable
        da.Fill(dt)
        DataGridView1.DataSource = dt
        ConMySQL.Close()
    End Sub
    Sub tampildata()
        ConMySQL = New MySqlConnection(constrMySQL)
        ConMySQL.Open()
        Dim da As New MySqlDataAdapter("select * from t_file where status = '" & "1" & "' AND keterangan = '" & "Umum" & "' order by tanggal", ConMySQL)
        Dim dt As New DataTable
        da.Fill(dt)
        DataGridView1.DataSource = dt
        ConMySQL.Close()
    End Sub

    Private Sub F_pengunjung_file_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load

        mainMySQL()
        tampildata()
    End Sub

    Private Sub DataGridView1_CellDoubleClick(sender As Object, e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView1.CellDoubleClick
        Try
            Dim gridbaris As DataGridViewRow = DataGridView1.Rows(e.RowIndex)
            TanggalDateTimePicker.Value = gridbaris.Cells(0).Value.ToString
            IdTextBox.Text = gridbaris.Cells(1).Value.ToString
            Nama_fileTextBox.Text = gridbaris.Cells(2).Value.ToString
            DivisiTextBox.Text = gridbaris.Cells(3).Value.ToString
            TahapanTextBox.Text = gridbaris.Cells(4).Value.ToString
            Jenis_pemilihanTextBox.Text = gridbaris.Cells(5).Value.ToString
            Kode_naskah_dinasTextBox.Text = gridbaris.Cells(6).Value.ToString
            Kode_biroTextBox.Text = gridbaris.Cells(7).Value.ToString
            Kode_jabatanTextBox.Text = gridbaris.Cells(8).Value.ToString
            Kode_wilayahTextBox.Text = gridbaris.Cells(9).Value.ToString
            BulanTextBox.Text = gridbaris.Cells(10).Value.ToString
            TahunTextBox.Text = gridbaris.Cells(11).Value.ToString
            FileTextBox.Text = gridbaris.Cells(12).Value.ToString
            JenisTextBox.Text = gridbaris.Cells(13).Value.ToString
            IntisariTextBox.Text = gridbaris.Cells(14).Value.ToString
            PutusanTextBox.Text = gridbaris.Cells(15).Value.ToString
            KronologiTextBox.Text = gridbaris.Cells(16).Value.ToString
            Kode_arsip_substantifTextBox.Text = gridbaris.Cells(17).Value.ToString
            Kode_arsip_fasilitatisTextBox.Text = gridbaris.Cells(18).Value.ToString
            JumlahTextBox.Text = gridbaris.Cells(19).Value.ToString
            KeteranganTextBox.Text = gridbaris.Cells(20).Value.ToString
            RakTextBox.Text = gridbaris.Cells(21).Value.ToString
            AxAcroPDF1.src = FileTextBox.Text


        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub Button6_Click(sender As System.Object, e As System.EventArgs) Handles Button6.Click
        If ComboBox1.Text = "Nama File" Then
            caridatanama()
        ElseIf ComboBox1.Text = "Jenis File" Then
            caridatajenis()
        ElseIf ComboBox1.Text = "Divisi" Then
            caridatadivisi()
        ElseIf ComboBox1.Text = "Intisari" Then
            caridataintisari()
        ElseIf ComboBox1.Text = "Putusan" Then
            caridataputusan()
        ElseIf ComboBox1.Text = "Kronologi" Then
            caridatakronologi()
        End If
    End Sub

    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click
        F_pilih_login.Show()
        Me.Hide()
    End Sub

    Private Sub T_fileBindingNavigatorSaveItem_Click(sender As System.Object, e As System.EventArgs)


    End Sub

    Private Sub b_databaru_Click(sender As System.Object, e As System.EventArgs) Handles b_databaru.Click
        kosongkan()
        tampildata()
    End Sub
End Class