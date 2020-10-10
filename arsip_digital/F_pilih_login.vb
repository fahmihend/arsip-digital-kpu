Public Class F_pilih_login

    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click
        F_admin_login.Show()
        Me.Hide()

    End Sub

    Private Sub Button2_Click(sender As System.Object, e As System.EventArgs) Handles Button2.Click
        F_pengguna_login.Show()
        Me.Hide()
    End Sub

    Private Sub Button3_Click(sender As System.Object, e As System.EventArgs) Handles Button3.Click
        F_pengunjung_absen.Show()
        Me.Hide()
    End Sub
End Class