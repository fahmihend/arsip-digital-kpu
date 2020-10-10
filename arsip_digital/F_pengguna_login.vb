Imports MySql.Data.MySqlClient
Public Class F_pengguna_login
    Dim strSql As String
    Dim perintah As New MySqlCommand
    Dim DAdapter As New MySqlDataAdapter
    Dim DReader As MySqlDataReader
    Sub kosongkan()
        UsernameTextBox.Clear()
        PasswordTextBox.Clear()

    End Sub
    Private Sub F_pengguna_login_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        mainMySQL()
        kosongkan()
    End Sub

    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click
        Try
            ConMySQL = New MySqlConnection(constrMySQL)
            ConMySQL.Open()
            perintah = New MySqlCommand("select * from user where username='" & UsernameTextBox.Text & "' AND password= '" & PasswordTextBox.Text & "' AND level= '" & ComboBox1.Text & "'", ConMySQL)
            DReader = perintah.ExecuteReader
            If DReader.Read Then
                MsgBox("Login Berhasil")
                F_pengguna_menu.ToolStripStatusLabel1.Text = ComboBox1.Text
                F_pengguna_menu.Show()
                Me.Hide()

            Else
                MsgBox("login Gagal. Username, Password atau Level salah")
                UsernameTextBox.Focus()
            End If

            kosongkan()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs)
        Throw New NotImplementedException
    End Sub

    Private Sub Button2_Click(sender As System.Object, e As System.EventArgs) Handles Button2.Click
        F_pilih_login.Show()
        Me.Hide()
    End Sub

    Private Sub Button3_Click(sender As System.Object, e As System.EventArgs) Handles Button3.Click
        F_pengguna_registrasi.Show()
        Me.Hide()
    End Sub
End Class