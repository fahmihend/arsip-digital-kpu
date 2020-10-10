Imports MySql.Data.MySqlClient
Public Class F_admin_login
    Dim strSql As String
    Dim perintah As New MySqlCommand
    Dim DAdapter As New MySqlDataAdapter
    Dim DReader As MySqlDataReader

    Sub kosongkan()
        UsernameTextBox.Clear()
        PasswordTextBox.Clear()

    End Sub

    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click
        Try
            ConMySQL = New MySqlConnection(constrMySQL)
            ConMySQL.Open()
            perintah = New MySqlCommand("select * from tb_admin where username='" & UsernameTextBox.Text & "' AND password= '" & PasswordTextBox.Text & "'", ConMySQL)
            DReader = perintah.ExecuteReader
            If DReader.Read Then
                MsgBox("Login Berhasil")

                F_admin_menu.Show()
                Me.Visible = False
            Else
                MsgBox("login Gagal, Username atau Password salah")
                UsernameTextBox.Focus()
            End If

            kosongkan()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub F_login_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        mainMySQL()
        kosongkan()
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        F_pilih_login.Show()
        Me.Hide()
    End Sub
End Class