Imports MySql.Data.MySqlClient
Public Class F_pengguna_registrasi
    Dim strSql As String
    Dim perintah As New MySqlCommand
    Dim DAdapter As New MySqlDataAdapter
    Dim DReader As MySqlDataReader
    Dim keterangantemp As String
    Sub kosongkan()

        UsernameTextBox.Clear()
        PasswordTextBox.Clear()
        LevelTextBox.Text = ""


        Button1.Enabled = True


    End Sub
    Sub simpan()
        ConMySQL = New MySqlConnection(constrMySQL)
        ConMySQL.Open()
        Try
            Dim perintah As New MySqlCommand("insert into tmp_user" & _
                                    " values ('" & Format(DateDateTimePicker.Value, "yyyy-MM-dd") & _
                                    "','" & IdTextBox.Text & _
                                    "','" & UsernameTextBox.Text & _
                                    "','" & PasswordTextBox.Text & _
                                    "','" & LevelTextBox.Text & _
                                    "')", ConMySQL)
            perintah.ExecuteNonQuery()
            MsgBox("Akun anda sukses diajukan, selanjutnya harap tunggu admin mengkonfirmasi akun anda", MsgBoxStyle.Information)

            ConMySQL.Close()
        Catch ex As Exception
            MsgBox("Username Telah Digunakan", MsgBoxStyle.Information, "Pesan")
            ConMySQL.Close()
        End Try
    End Sub
    Private Sub Tmp_userBindingNavigatorSaveItem_Click(sender As System.Object, e As System.EventArgs)

    End Sub

    Private Sub F_pengguna_registrasi_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load

        mainMySQL()
        kosongkan()

    End Sub

    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click
        simpan()
        kosongkan()

    End Sub

    Private Sub Tmp_userBindingNavigatorSaveItem_Click_1(sender As System.Object, e As System.EventArgs)

    End Sub

    Private Sub Button2_Click(sender As System.Object, e As System.EventArgs)
        F_admin_konfirmasi.Show()

    End Sub

    Private Sub Button2_Click_1(sender As System.Object, e As System.EventArgs) Handles Button2.Click
        Me.Hide()
        F_pengguna_login.Show()
    End Sub
End Class