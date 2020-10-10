Imports MySql.Data.MySqlClient
Public Class F_admin_upload
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
        Jenis_pemilihanTextBox.Text = ""
        Kode_naskah_dinasTextBox.Clear()
        Kode_biroTextBox.Clear()
        Kode_jabatanTextBox.Clear()
        Kode_wilayahTextBox.Clear()
        Kode_kearsipanTextBox.Clear()
        BulanTextBox.Text = ""
        TahunTextBox.Clear()
        Kode_kearsipanTextBox.Clear()
        FileTextBox.Clear()
        JenisTextBox.Text = ""
        IntisariTextBox.Clear()
        PutusanTextBox.Clear()
        KronologiTextBox.Clear()
        Kode_arsip_fasilitatisTextBox.Clear()
        Kode_arsip_substantifTextBox.Clear()
        KeteranganTextBox.Text = ""
        caridata.Clear()
        SampulTextBox.Clear()
        KotakTextBox.Clear()
        RakTextBox.Clear()
        StatusTextBox.Clear()
        IdTextBox.Enabled = False
        AxAcroPDF1.Refresh()

        b_simpan.Enabled = True
        b_hapus.Enabled = False
        b_ubah.Enabled = False

    End Sub
    Sub simpan()
        ConMySQL = New MySqlConnection(constrMySQL)
        ConMySQL.Open()
        Try
            pdf = FileTextBox.Text.Replace("\", "\\")
            Dim perintah As New MySqlCommand("insert into t_file" & _
                                    " values ('" & Format(TanggalDateTimePicker.Value, "yyyy-MM-dd") & _
                                    "','" & IdTextBox.Text & _
                                    "','" & Nama_fileTextBox.Text & _
                                    "','" & DivisiTextBox.Text & _
                                    "','" & TahapanTextBox.Text & _
                                    "','" & Jenis_pemilihanTextBox.Text & _
                                    "','" & Kode_naskah_dinasTextBox.Text & _
                                    "','" & Kode_biroTextBox.Text & _
                                    "','" & Kode_jabatanTextBox.Text & _
                                    "','" & Kode_wilayahTextBox.Text & _
                                    "','" & BulanTextBox.Text & _
                                    "','" & TahunTextBox.Text & _
                                    "','" & Kode_kearsipanTextBox.Text & _
                                    "','" & pdf & _
                                    "','" & JenisTextBox.Text & _
                                    "','" & IntisariTextBox.Text & _
                                    "','" & PutusanTextBox.Text & _
                                    "','" & KronologiTextBox.Text & _
                                    "','" & Kode_arsip_substantifTextBox.Text & _
                                    "','" & Kode_arsip_fasilitatisTextBox.Text & _
                                    "','" & "1" & _
                                    "','" & KeteranganTextBox.Text & _
                                    "','" & SampulTextBox.Text & _
                                    "','" & KotakTextBox.Text & _
                                    "','" & LantaiTextBox.Text & _
                                    "','" & RakTextBox.Text & _
                                    "','" & StatusTextBox.Text & _
                                    "')", ConMySQL)
            perintah.ExecuteNonQuery()
            MsgBox("Sukses", MsgBoxStyle.Information)

            ConMySQL.Close()
        Catch ex As Exception
            MsgBox("Data Tidak Bisa Disimpan", MsgBoxStyle.Information, "Pesan")
            ConMySQL.Close()
        End Try
    End Sub
    Sub ubah()
        ConMySQL = New MySqlConnection(constrMySQL)
        ConMySQL.Open()
        Try
            pdf = FileTextBox.Text.Replace("\", "\\")
            Dim perintah As New MySqlCommand("UPDATE t_file" & _
                                    " SET tanggal= '" & Format(TanggalDateTimePicker.Value, "yyyy-MM-dd") & _
                                    "', id= '" & IdTextBox.Text & _
                                    "', nama_file= '" & Nama_fileTextBox.Text & _
                                    "', divisi= '" & DivisiTextBox.Text & _
                                    "', tahapan= '" & TahapanTextBox.Text & _
                                    "', jenis_pemilihan= '" & Jenis_pemilihanTextBox.Text & _
                                    "', kode_naskah_dinas= '" & Kode_naskah_dinasTextBox.Text & _
                                    "', kode_biro= '" & Kode_biroTextBox.Text & _
                                    "', kode_jabatan= '" & Kode_jabatanTextBox.Text & _
                                    "', kode_wilayah= '" & Kode_wilayahTextBox.Text & _
                                    "', bulan= '" & BulanTextBox.Text & _
                                    "', tahun= '" & TahunTextBox.Text & _
                                    "', kode_kearsipan= '" & Kode_kearsipanTextBox.Text & _
                                    "', file= '" & pdf & _
                                    "', jenis= '" & JenisTextBox.Text & _
                                    "', intisari= '" & IntisariTextBox.Text & _
                                    "', putusan= '" & PutusanTextBox.Text & _
                                    "', kronologi= '" & KronologiTextBox.Text & _
                                    "', kode_arsip_substantif= '" & Kode_arsip_substantifTextBox.Text & _
                                    "', kode_arsip_fasilitatif= '" & Kode_arsip_fasilitatisTextBox.Text & _
                                    "', jumlah= '" & JumlahTextBox.Text & _
                                    "', keterangan= '" & KeteranganTextBox.Text & _
                                    "', sampul= '" & SampulTextBox.Text & _
                                    "', kotak= '" & KotakTextBox.Text & _
                                    "', lantai= '" & LantaiTextBox.Text & _
                                    "', rak= '" & RakTextBox.Text & _
                                    "', status= '" & StatusTextBox.Text & _
                                    "' WHERE id='" & IdTextBox.Text & "'", ConMySQL)
            perintah.ExecuteNonQuery()
            MsgBox("Sukses", MsgBoxStyle.Information)


            ConMySQL.Close()
        Catch ex As Exception
            MsgBox("Terdapat Kesalahan", MsgBoxStyle.Information, "Pesan")
            ConMySQL.Close()
        End Try
    End Sub

    Sub hapus()
        ConMySQL = New MySqlConnection(constrMySQL)
        ConMySQL.Open()
        Try
            Dim perintah As New MySqlCommand("delete from t_file" & _
                                             " WHERE id='" & IdTextBox.Text & "'", ConMySQL)
            perintah.ExecuteNonQuery()
            MsgBox("Sukses", MsgBoxStyle.Information)

            ConMySQL.Close()
        Catch ex As Exception
            MsgBox("Terdapat Kesalahan", MsgBoxStyle.Information, "Pesan")
            ConMySQL.Close()
        End Try
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
        Dim da As New MySqlDataAdapter("select * from t_file where status = '" & "1" & "'order by tanggal", ConMySQL)
        Dim dt As New DataTable
        da.Fill(dt)
        DataGridView1.DataSource = dt
        ConMySQL.Close()
    End Sub
    Sub tampiltahapan()
        ConMySQL = New MySqlConnection(constrMySQL)
        ConMySQL.Open()
        perintah = New MySqlCommand("select tahapan from t_tahapan where divisi = '" & DivisiTextBox.Text & "'", ConMySQL)
        DReader = perintah.ExecuteReader
        TahapanTextBox.Items.Clear()
        Do While DReader.Read
            TahapanTextBox.Items.Add(DReader.Item("tahapan"))
        Loop
        ConMySQL.Close()
    End Sub
    Sub tampildivisi()
        ConMySQL = New MySqlConnection(constrMySQL)
        ConMySQL.Open()
        perintah = New MySqlCommand("select distinct divisi from t_tahapan", ConMySQL)
        DReader = perintah.ExecuteReader
        DivisiTextBox.Items.Clear()
        Do While DReader.Read
            DivisiTextBox.Items.Add(DReader.Item("divisi"))
        Loop
        ConMySQL.Close()
    End Sub
    Sub kurangjumlahtahapan()

        ConMySQL = New MySqlConnection(constrMySQL)
        ConMySQL.Open()
        Try
            Dim perintah As New MySqlCommand("UPDATE t_tahapan" & _
                                    " SET jumlah= '" & Val(JumlahTextBox.Text) - 1 & _
                                    "' WHERE sub_tahapan='" & Sub_tahapanTextBox.Text & "'", ConMySQL)
            perintah.ExecuteNonQuery()
            MsgBox("Sukses", MsgBoxStyle.Information)


            ConMySQL.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
            ConMySQL.Close()
        End Try
    End Sub
    Sub tambahjumlahtahapan()
        ConMySQL = New MySqlConnection(constrMySQL)
        ConMySQL.Open()
        Try
            Dim perintah As New MySqlCommand("UPDATE t_tahapan" & _
                                    " SET jumlah= '" & Val(JumlahTextBox.Text) + 1 & _
                                    "' WHERE sub_tahapan='" & Sub_tahapanTextBox.Text & "'", ConMySQL)
            perintah.ExecuteNonQuery()
            MsgBox("Sukses", MsgBoxStyle.Information)


            ConMySQL.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
            ConMySQL.Close()
        End Try
    End Sub
    Private Sub T_fileBindingNavigatorSaveItem_Click(sender As System.Object, e As System.EventArgs)

    End Sub

    Private Sub F_admin_upload_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load

        mainMySQL()
        tampildata()
        tampildivisi()
        kosongkan()
    End Sub
    Private Sub Button4_Click(sender As System.Object, e As System.EventArgs) Handles Button4.Click

        OpenFileDialog1.ShowDialog()
        FileTextBox.Text = OpenFileDialog1.FileName
        AxAcroPDF1.src = FileTextBox.Text
    End Sub

    Private Sub b_databaru_Click(sender As System.Object, e As System.EventArgs) Handles b_databaru.Click
        kosongkan()
        tampildata()
    End Sub

    Private Sub b_simpan_Click(sender As System.Object, e As System.EventArgs) Handles b_simpan.Click
        If Nama_fileTextBox.Text = "" Then
            MsgBox("Nama File tidak boleh kosong", vbCritical, "Salah")
            Nama_fileTextBox.Focus()
        ElseIf DivisiTextBox.Text = "" Then
            MsgBox("Divisi tidak boleh kosong", vbCritical, "Salah")
            DivisiTextBox.Focus()
        ElseIf FileTextBox.Text = "" Then
            MsgBox("harap pilih file", vbCritical, "SALAH")
        ElseIf JenisTextBox.Text = "" Then
            MsgBox("jenis file tidak boleh kosong", vbCritical, "Salah")
            JenisTextBox.Focus()
        ElseIf IntisariTextBox.Text = "" Then
            MsgBox("Intisari harus di isi", vbCritical, "Salah")
            IntisariTextBox.Focus()
        ElseIf PutusanTextBox.Text = "" Then
            MsgBox("Putusan tidak boleh kosong", vbCritical, "Salah")
            PutusanTextBox.Focus()
        ElseIf KronologiTextBox.Text = "" Then
            MsgBox("Kronologi harus di isi", vbCritical, "Salah")
            KronologiTextBox.Focus()
        ElseIf KeteranganTextBox.Text = "" Then
            MsgBox("Kronologi harus di isi", vbCritical, "Salah")
            KeteranganTextBox.Focus()
        Else
            simpan()
            kosongkan()
        End If
        tampildata()

    End Sub

    Private Sub DataGridView1_CellDoubleClick(sender As Object, e As System.Windows.Forms.DataGridViewCellEventArgs)
       
    End Sub

    Private Sub FileTextBox_TextChanged(sender As System.Object, e As System.EventArgs)
        AxAcroPDF1.src = FileTextBox.Text
    End Sub

    Private Sub b_ubah_Click(sender As System.Object, e As System.EventArgs) Handles b_ubah.Click
        ubah()
        kosongkan()
        tampildata()

    End Sub
    Private Sub b_hapus_Click(sender As System.Object, e As System.EventArgs) Handles b_hapus.Click
        hapus()
        kosongkan()
        tampildata()
    End Sub
    Private Sub TahapanTextBox_TextChanged(sender As Object, e As System.EventArgs) Handles Jenis_pemilihanTextBox.TextChanged

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

    Private Sub DataGridView1_CellContentClick(sender As System.Object, e As System.Windows.Forms.DataGridViewCellEventArgs)

    End Sub

    Private Sub TahapanTextBox_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles Jenis_pemilihanTextBox.SelectedIndexChanged

    End Sub

    Private Sub AxAcroPDF1_Enter(sender As System.Object, e As System.EventArgs) Handles AxAcroPDF1.Enter

    End Sub

    Private Sub T_fileBindingNavigatorSaveItem_Click_1(sender As System.Object, e As System.EventArgs)

    End Sub

    Private Sub T_fileBindingNavigatorSaveItem_Click_2(sender As System.Object, e As System.EventArgs)

    End Sub

    Private Sub T_fileBindingNavigatorSaveItem_Click_3(sender As System.Object, e As System.EventArgs)

    End Sub

    Private Sub T_fileBindingNavigatorSaveItem_Click_4(sender As System.Object, e As System.EventArgs)

    End Sub

    Private Sub T_fileBindingNavigatorSaveItem_Click_5(sender As System.Object, e As System.EventArgs)


    End Sub

    Private Sub DataGridView1_CellContentClick_1(sender As System.Object, e As System.Windows.Forms.DataGridViewCellEventArgs)

    End Sub

    Private Sub DataGridView1_CellDoubleClick1(sender As Object, e As System.Windows.Forms.DataGridViewCellEventArgs)

    End Sub

    Private Sub T_fileBindingNavigatorSaveItem_Click_6(sender As System.Object, e As System.EventArgs)


    End Sub

    Private Sub DataGridView1_CellContentClick_2(sender As System.Object, e As System.Windows.Forms.DataGridViewCellEventArgs)

    End Sub

    Private Sub DataGridView1_CellDoubleClick2(sender As Object, e As System.Windows.Forms.DataGridViewCellEventArgs)

    End Sub

    Private Sub T_fileBindingNavigator_RefreshItems(sender As System.Object, e As System.EventArgs)

    End Sub

    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs)
        caridatanama()
    End Sub

    Private Sub DataGridView1_CellContentClick_3(sender As System.Object, e As System.Windows.Forms.DataGridViewCellEventArgs)

    End Sub

    Private Sub DataGridView1_CellDoubleClick3(sender As Object, e As System.Windows.Forms.DataGridViewCellEventArgs)

    End Sub

    Private Sub T_fileBindingNavigatorSaveItem_Click_7(sender As System.Object, e As System.EventArgs)


    End Sub

    Private Sub DataGridView1_CellContentClick_4(sender As System.Object, e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick

    End Sub

    Private Sub DataGridView1_CellDoubleClick4(sender As Object, e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView1.CellDoubleClick
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
            Kode_kearsipanTextBox.Text = gridbaris.Cells(12).Value.ToString
            FileTextBox.Text = gridbaris.Cells(13).Value.ToString
            JenisTextBox.Text = gridbaris.Cells(14).Value.ToString
            IntisariTextBox.Text = gridbaris.Cells(15).Value.ToString
            PutusanTextBox.Text = gridbaris.Cells(16).Value.ToString
            KronologiTextBox.Text = gridbaris.Cells(17).Value.ToString
            Kode_arsip_substantifTextBox.Text = gridbaris.Cells(18).Value.ToString
            Kode_arsip_fasilitatisTextBox.Text = gridbaris.Cells(19).Value.ToString
            JumlahTextBox.Text = gridbaris.Cells(20).Value.ToString
            KeteranganTextBox.Text = gridbaris.Cells(21).Value.ToString
            SampulTextBox.Text = gridbaris.Cells(22).Value.ToString
            KotakTextBox.Text = gridbaris.Cells(23).Value.ToString
            LantaiTextBox.Text = gridbaris.Cells(24).Value.ToString
            RakTextBox.Text = gridbaris.Cells(25).Value.ToString
            StatusTextBox.Text = gridbaris.Cells(26).Value.ToString
            AxAcroPDF1.src = FileTextBox.Text

            b_simpan.Enabled = False
            b_hapus.Enabled = True
            b_ubah.Enabled = True
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub T_fileBindingNavigatorSaveItem_Click_8(sender As System.Object, e As System.EventArgs)


    End Sub

    Private Sub DivisiTextBox_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles DivisiTextBox.SelectedIndexChanged

    End Sub

    Private Sub DivisiTextBox_TextChanged(sender As Object, e As System.EventArgs) Handles DivisiTextBox.TextChanged
        tampiltahapan()
    End Sub

    Private Sub T_fileBindingNavigatorSaveItem_Click_9(sender As System.Object, e As System.EventArgs)

    End Sub
End Class