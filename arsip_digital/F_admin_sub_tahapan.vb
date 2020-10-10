Imports MySql.Data.MySqlClient
Public Class F_admin_sub_Sub_tahapan
    Dim strSql As String
    Dim perintah As New MySqlCommand
    Dim DAdapter As New MySqlDataAdapter
    Dim DReader As MySqlDataReader
    Dim keterangantemp As String
    Sub kosongkan()
        IdTextBox.Clear()
        TahapanTextBox.Text = ""
        Sub_tahapanTextBox.Clear()

        IdTextBox.Enabled = False

        b_simpan.Enabled = True
        b_hapus.Enabled = False
        b_ubah.Enabled = False

    End Sub
    Sub simpan()
        ConMySQL = New MySqlConnection(constrMySQL)
        ConMySQL.Open()
        Try
            Dim perintah As New MySqlCommand("insert into t_Sub_tahapan" & _
                                    " values ('" & IdTextBox.Text & _
                                    "','" & TahapanTextBox.Text & _
                                    "','" & Sub_tahapanTextBox.Text & _
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
            Dim perintah As New MySqlCommand("UPDATE t_Sub_tahapan" & _
                                    " SET id= '" & IdTextBox.Text & _
                                    "', tahapan= '" & TahapanTextBox.Text & _
                                    "', Sub_tahapan= '" & Sub_tahapanTextBox.Text & _
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
            Dim perintah As New MySqlCommand("delete from t_Sub_tahapan" & _
                                             " WHERE id='" & IdTextBox.Text & "'", ConMySQL)
            perintah.ExecuteNonQuery()
            MsgBox("Sukses", MsgBoxStyle.Information)

            ConMySQL.Close()
        Catch ex As Exception
            MsgBox("Terdapat Kesalahan", MsgBoxStyle.Information, "Pesan")
            ConMySQL.Close()
        End Try
    End Sub
    Sub caridataSub_tahapan()
        ConMySQL = New MySqlConnection(constrMySQL)
        ConMySQL.Open()
        Dim da As New MySqlDataAdapter("select * from t_sub_tahapan where tahapan like '%" & TextBox1.Text & "%'", ConMySQL)
        Dim dt As New DataTable
        da.Fill(dt)
        DataGridView1.DataSource = dt
        ConMySQL.Close()
    End Sub
    Sub caridatasub()
        ConMySQL = New MySqlConnection(constrMySQL)
        ConMySQL.Open()
        Dim da As New MySqlDataAdapter("select * from t_Sub_tahapan where sub_tahapan like '%" & TextBox1.Text & "%'", ConMySQL)
        Dim dt As New DataTable
        da.Fill(dt)
        DataGridView1.DataSource = dt
        ConMySQL.Close()
    End Sub
    Sub tampildata()
        ConMySQL = New MySqlConnection(constrMySQL)
        ConMySQL.Open()
        Dim da As New MySqlDataAdapter("select * from t_Sub_tahapan order by Sub_tahapan", ConMySQL)
        Dim dt As New DataTable
        da.Fill(dt)
        DataGridView1.DataSource = dt
        ConMySQL.Close()
    End Sub
    Sub tampiltahapan()
        ConMySQL = New MySqlConnection(constrMySQL)
        ConMySQL.Open()
        perintah = New MySqlCommand("select distinct tahapan from t_tahapan", ConMySQL)
        DReader = perintah.ExecuteReader
        TahapanTextBox.Items.Clear()
        Do While DReader.Read
            TahapanTextBox.Items.Add(DReader.Item("tahapan"))
        Loop
        ConMySQL.Close()
    End Sub
    Private Sub F_admin_sub_Sub_tahapan_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        mainMySQL()
        tampildata()
        tampiltahapan()
        kosongkan()
    End Sub
    Private Sub DataGridView1_CellDoubleClick(sender As Object, e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView1.CellDoubleClick
        Try
            Dim gridbaris As DataGridViewRow = DataGridView1.Rows(e.RowIndex)
            IdTextBox.Text = gridbaris.Cells(0).Value.ToString
            TahapanTextBox.Text = gridbaris.Cells(1).Value.ToString
            Sub_tahapanTextBox.Text = gridbaris.Cells(2).Value.ToString

            b_simpan.Enabled = False
            b_hapus.Enabled = True
            b_ubah.Enabled = True
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub Button2_Click(sender As System.Object, e As System.EventArgs)
        caridatasub()
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
End Class