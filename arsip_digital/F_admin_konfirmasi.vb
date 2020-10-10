Imports MySql.Data.MySqlClient
Public Class F_admin_konfirmasi
    Dim strSql As String
    Dim perintah As New MySqlCommand
    Dim DAdapter As New MySqlDataAdapter
    Dim DReader As MySqlDataReader
    Dim keterangantemp As String
    Sub kosongkan()

        UsernameTextBox.Clear()
        PasswordTextBox.Clear()
        LevelTextBox.Text = ""


        b_simpan.Enabled = True
        b_hapus.Enabled = False

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
                                    "','" & LevelTextbox.Text & _
                                    "')", ConMySQL)
            perintah.ExecuteNonQuery()
            MsgBox("Sukses", MsgBoxStyle.Information)

            ConMySQL.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
            ConMySQL.Close()
        End Try
    End Sub
    Sub hapus()
        ConMySQL = New MySqlConnection(constrMySQL)
        ConMySQL.Open()
        Try
            Dim perintah As New MySqlCommand("delete from tmp_user" & _
                                             " WHERE username='" & UsernameTextBox.Text & "'", ConMySQL)
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
        Dim da As New MySqlDataAdapter("select * from tmp_user  where username like '%" & TextBox1.Text & "%'", ConMySQL)
        Dim dt As New DataTable
        da.Fill(dt)
        DataGridView1.DataSource = dt
        ConMySQL.Close()
    End Sub
    Sub caridatalevel()
        ConMySQL = New MySqlConnection(constrMySQL)
        ConMySQL.Open()
        Dim da As New MySqlDataAdapter("select * from tmp_user  where level like '%" & TextBox1.Text & "%'", ConMySQL)
        Dim dt As New DataTable
        da.Fill(dt)
        DataGridView1.DataSource = dt
        ConMySQL.Close()
    End Sub
    Sub tampildata()
        ConMySQL = New MySqlConnection(constrMySQL)
        ConMySQL.Open()
        Dim da As New MySqlDataAdapter("select * from tmp_user order by level", ConMySQL)
        Dim dt As New DataTable
        da.Fill(dt)
        DataGridView1.DataSource = dt
        ConMySQL.Close()
    End Sub
    Private Sub F_admin_konfirmasi_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load

        mainMySQL()
        tampildata()
        kosongkan()

    End Sub

    Private Sub DataGridView1_CellContentClick(sender As System.Object, e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick

    End Sub

    Private Sub DataGridView1_CellDoubleClick(sender As Object, e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView1.CellDoubleClick
        Try
            Dim gridbaris As DataGridViewRow = DataGridView1.Rows(e.RowIndex)
            DateDateTimePicker.Value = gridbaris.Cells(0).Value.ToString
            IdTextBox.Text = gridbaris.Cells(1).Value.ToString
            UsernameTextBox.Text = gridbaris.Cells(2).Value.ToString
            PasswordTextBox.Text = gridbaris.Cells(3).Value.ToString
            LevelTextbox.Text = gridbaris.Cells(4).Value.ToString

            b_simpan.Enabled = True
            b_hapus.Enabled = True
        Catch ex As Exception
            MsgBox("Terjadi Kesalahan", MsgBoxStyle.Critical)
        End Try
    End Sub

    Private Sub b_simpan_Click(sender As System.Object, e As System.EventArgs) Handles b_simpan.Click
        simpan()
        hapus()
        kosongkan()
        tampildata()

    End Sub

    Private Sub b_hapus_Click(sender As System.Object, e As System.EventArgs) Handles b_hapus.Click
        hapus()
        kosongkan()
        tampildata()

    End Sub

    Private Sub Tmp_userBindingNavigatorSaveItem_Click(sender As System.Object, e As System.EventArgs)


    End Sub

    Private Sub Tmp_userBindingNavigatorSaveItem_Click_1(sender As System.Object, e As System.EventArgs)


    End Sub
End Class