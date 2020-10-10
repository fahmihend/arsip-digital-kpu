Imports MySql.Data.MySqlClient
Public Class F_admin_tahapan
    Dim strSql As String
    Dim perintah As New MySqlCommand
    Dim DAdapter As New MySqlDataAdapter
    Dim DReader As MySqlDataReader
    Dim keterangantemp As String
    Sub kosongkan()
        IdTextBox.Clear()
        DivisiTextBox.Clear()
        TahapanTextBox.Clear()

        IdTextBox.Enabled = False

        b_simpan.Enabled = True
        b_hapus.Enabled = False
        b_ubah.Enabled = False

    End Sub
    Sub simpan()
        ConMySQL = New MySqlConnection(constrMySQL)
        ConMySQL.Open()
        Try
            Dim perintah As New MySqlCommand("insert into t_tahapan" & _
                                    " values ('" & IdTextBox.Text & _
                                    "','" & DivisiTextBox.Text & _
                                    "','" & TahapanTextBox.Text & _
                                    "','" & "0" & _
                                    "')", ConMySQL)
            perintah.ExecuteNonQuery()
            MsgBox("Sukses", MsgBoxStyle.Information)

            ConMySQL.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
            ConMySQL.Close()
        End Try
    End Sub
    Sub ubah()
        ConMySQL = New MySqlConnection(constrMySQL)
        ConMySQL.Open()
        Try
            Dim perintah As New MySqlCommand("UPDATE t_tahapan" & _
                                    " SET id= '" & IdTextBox.Text & _
                                    "', tahapan= '" & TahapanTextBox.Text & _
                                    "', divisi= '" & DivisiTextBox.Text & _
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
            Dim perintah As New MySqlCommand("delete from t_tahapan" & _
                                             " WHERE id='" & IdTextBox.Text & "'", ConMySQL)
            perintah.ExecuteNonQuery()
            MsgBox("Sukses", MsgBoxStyle.Information)

            ConMySQL.Close()
        Catch ex As Exception
            MsgBox("Terdapat Kesalahan", MsgBoxStyle.Information, "Pesan")
            ConMySQL.Close()
        End Try
    End Sub
    Sub caridatatahapan()
        ConMySQL = New MySqlConnection(constrMySQL)
        ConMySQL.Open()
        Dim da As New MySqlDataAdapter("select * from t_tahapan where tahapan like '%" & TextBox1.Text & "%'", ConMySQL)
        Dim dt As New DataTable
        da.Fill(dt)
        DataGridView1.DataSource = dt
        ConMySQL.Close()
    End Sub
    Sub caridatadivisi()
        ConMySQL = New MySqlConnection(constrMySQL)
        ConMySQL.Open()
        Dim da As New MySqlDataAdapter("select * from t_tahapan where divisi like '%" & TextBox1.Text & "%'", ConMySQL)
        Dim dt As New DataTable
        da.Fill(dt)
        DataGridView1.DataSource = dt
        ConMySQL.Close()
    End Sub
    Sub tampildata()
        ConMySQL = New MySqlConnection(constrMySQL)
        ConMySQL.Open()
        Dim da As New MySqlDataAdapter("select id, divisi, tahapan from t_tahapan order by divisi", ConMySQL)
        Dim dt As New DataTable
        da.Fill(dt)
        DataGridView1.DataSource = dt
        ConMySQL.Close()
    End Sub
    Private Sub F_tahapan_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load


        mainMySQL()
        tampildata()
        kosongkan()
    End Sub
    Private Sub DataGridView1_CellDoubleClick(sender As Object, e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView1.CellDoubleClick
        Try
            Dim gridbaris As DataGridViewRow = DataGridView1.Rows(e.RowIndex)
            IdTextBox.Text = gridbaris.Cells(0).Value.ToString
            DivisiTextBox.Text = gridbaris.Cells(1).Value.ToString
            TahapanTextBox.Text = gridbaris.Cells(2).Value.ToString

            b_simpan.Enabled = False
            b_hapus.Enabled = True
            b_ubah.Enabled = True
        Catch ex As Exception
            MsgBox("Terjadi Kesalahan", MsgBoxStyle.Critical)
        End Try
    End Sub

    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click
        caridatatahapan()
    End Sub

    Private Sub Button2_Click(sender As System.Object, e As System.EventArgs)
        caridatadivisi()
    End Sub

    Private Sub b_databaru_Click(sender As System.Object, e As System.EventArgs) Handles b_databaru.Click
        kosongkan()
        tampildata()
    End Sub

    Private Sub b_simpan_Click(sender As System.Object, e As System.EventArgs) Handles b_simpan.Click
        simpan()
        kosongkan()
        tampildata()

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

    Private Sub T_tahapanBindingNavigatorSaveItem_Click(sender As System.Object, e As System.EventArgs)

    End Sub

    Private Sub T_tahapanBindingNavigatorSaveItem_Click_1(sender As System.Object, e As System.EventArgs)

    End Sub
End Class