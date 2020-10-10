Imports MySql.Data.MySqlClient
Public Class F_pengunjung_absen
    Dim strSql As String
    Dim perintah As New MySqlCommand
    Dim DAdapter As New MySqlDataAdapter
    Dim DReader As MySqlDataReader
    Dim keterangantemp As String
    Sub kosongkan()
        TanggalDateTimePicker.Value = Now
        IdTextBox.Clear()
        Jenis_kelaminTextBox.Text = ""
        NamaTextBox.Clear()
        UmurTextBox.Clear()
        BasisTextBox.Text = ""
        IdTextBox.Enabled = False
    End Sub
    Sub simpan()
        ConMySQL = New MySqlConnection(constrMySQL)
        ConMySQL.Open()
        Try
            Dim perintah As New MySqlCommand("insert into t_pengunjung" & _
                                    " values ('" & Format(TanggalDateTimePicker.Value, "yyyy-MM-dd") & _
                                    "','" & IdTextBox.Text & _
                                    "','" & NamaTextBox.Text & _
                                    "','" & Jenis_kelaminTextBox.Text & _
                                    "','" & UmurTextBox.Text & _
                                    "','" & BasisTextBox.Text & _
                                    "','" & "1" & _
                                    "')", ConMySQL)
            perintah.ExecuteNonQuery()
            MsgBox("Sukses", MsgBoxStyle.Information)

            ConMySQL.Close()
        Catch ex As Exception
            MsgBox("Data Tidak Bisa Disimpan", MsgBoxStyle.Information, "Pesan")
            ConMySQL.Close()
        End Try
    End Sub
    Private Sub F_pengunjung_absen_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        mainMySQL()
        kosongkan()
    End Sub
    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click
        If jenis_kelaminTextBox.Text = "" Then
            MsgBox("NIK tidak boleh kosong", vbCritical, "Salah")
            jenis_kelaminTextBox.Focus()
        ElseIf NamaTextBox.Text = "" Then
            MsgBox("Nama tidak boleh kosong", vbCritical, "Salah")
            NamaTextBox.Focus()
        ElseIf UmurTextBox.Text = "" Then
            MsgBox("Umur tidak boleh kosong", vbCritical, "Salah")
            UmurTextBox.Focus()
        ElseIf BasisTextBox.Text = "" Then
            MsgBox("Basis harus di isi", vbCritical, "Salah")
            BasisTextBox.Focus()
        Else
            simpan()
            kosongkan()
            F_pengunjung_file.Show()
            Me.Hide()
        End If
    End Sub

    Private Sub Button2_Click(sender As System.Object, e As System.EventArgs) Handles Button2.Click
        F_pilih_login.Show()
        Me.Hide()

    End Sub

    Private Sub T_pengunjungBindingNavigatorSaveItem_Click(sender As System.Object, e As System.EventArgs)

    End Sub

    Private Sub T_pengunjungBindingNavigatorSaveItem_Click_1(sender As System.Object, e As System.EventArgs)

    End Sub
End Class