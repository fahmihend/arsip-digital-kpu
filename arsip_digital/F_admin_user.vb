Imports MySql.Data.MySqlClient
Public Class F_admin_user
    Dim strSql As String
    Dim perintah As New MySqlCommand
    Dim DAdapter As New MySqlDataAdapter
    Dim DReader As MySqlDataReader
    Dim keterangantemp As String
    Sub kosongkan()
        DateDateTimePicker.Value = Now
        IdTextBox.Clear()
        UsernameTextBox.Clear()
        PasswordTextBox.Clear()
        LevelTextBox.Text = ""
        IdTextBox.Enabled = False

        b_simpan.Enabled = True
        b_hapus.Enabled = False
        b_ubah.Enabled = False

    End Sub
    Sub simpan()
        ConMySQL = New MySqlConnection(constrMySQL)
        ConMySQL.Open()
        Try
            Dim perintah As New MySqlCommand("insert into user" & _
                                    " values ('" & Format(DateDateTimePicker.Value, "yyyy-MM-dd") & _
                                    "','" & IdTextBox.Text & _
                                    "','" & UsernameTextBox.Text & _
                                    "','" & PasswordTextBox.Text & _
                                    "','" & LevelTextBox.Text & _
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
            Dim perintah As New MySqlCommand("UPDATE user" & _
                                    " SET date= '" & Format(DateDateTimePicker.Value, "yyyy-MM-dd") & _
                                    "', id= '" & IdTextBox.Text & _
                                    "', username= '" & UsernameTextBox.Text & _
                                    "', password= '" & PasswordTextBox.Text & _
                                      "', level= '" & LevelTextBox.Text & _
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
            Dim perintah As New MySqlCommand("delete from user" & _
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
        Dim da As New MySqlDataAdapter("select * from user  where username like '%" & TextBox1.Text & "%'", ConMySQL)
        Dim dt As New DataTable
        da.Fill(dt)
        DataGridView1.DataSource = dt
        ConMySQL.Close()
    End Sub
    Sub caridatalevel()
        ConMySQL = New MySqlConnection(constrMySQL)
        ConMySQL.Open()
        Dim da As New MySqlDataAdapter("select * from user  where level like '%" & TextBox2.Text & "%'", ConMySQL)
        Dim dt As New DataTable
        da.Fill(dt)
        DataGridView1.DataSource = dt
        ConMySQL.Close()
    End Sub
    Sub tampildata()
        ConMySQL = New MySqlConnection(constrMySQL)
        ConMySQL.Open()
        Dim da As New MySqlDataAdapter("select * from user order by date", ConMySQL)
        Dim dt As New DataTable
        da.Fill(dt)
        DataGridView1.DataSource = dt
        ConMySQL.Close()
    End Sub

    Private Sub F_user_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        mainMySQL()
        kosongkan()
        tampildata()
    End Sub
    Private Sub DataGridView1_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick
        Try
            Dim gridbaris As DataGridViewRow = DataGridView1.Rows(e.RowIndex)
            DateDateTimePicker.Value = gridbaris.Cells(0).Value.ToString
            IdTextBox.Text = gridbaris.Cells(1).Value.ToString
            UsernameTextBox.Text = gridbaris.Cells(2).Value.ToString
            PasswordTextBox.Text = gridbaris.Cells(3).Value.ToString
            LevelTextBox.Text = gridbaris.Cells(4).Value.ToString

            b_simpan.Enabled = False
            b_hapus.Enabled = True
            b_ubah.Enabled = True
        Catch ex As Exception
            MsgBox("Terjadi Kesalahan", MsgBoxStyle.Critical)
        End Try
    End Sub

    Private Sub TextBox1_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox1.TextChanged
        caridatanama()
    End Sub

    Private Sub TextBox2_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox2.TextChanged
        caridatalevel()
    End Sub

    Private Sub b_simpan_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles b_simpan.Click
        If UsernameTextBox.Text = "" Then
            MsgBox("Data Tidak Lengkap", vbCritical, "Salah")
            UsernameTextBox.Focus()
        ElseIf PasswordTextBox.Text = "" Then
            MsgBox("Data Tidak Lengkap", vbCritical, "Salah")
            PasswordTextBox.Focus()
        ElseIf LevelTextBox.Text = "" Then
            MsgBox("Data Tidak Lengkap", vbCritical, "Salah")
            LevelTextBox.Focus()
        Else
            simpan()
        End If
        tampildata()
        kosongkan()
    End Sub

    Private Sub b_ubah_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles b_ubah.Click
        ubah()
        kosongkan()
        tampildata()

    End Sub

    Private Sub b_hapus_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles b_hapus.Click
        hapus()
        kosongkan()
        tampildata()

    End Sub

    Private Sub b_databaru_Click(sender As System.Object, e As System.EventArgs) Handles b_databaru.Click
        kosongkan()

    End Sub
End Class
