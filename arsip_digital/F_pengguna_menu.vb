Public Class F_pengguna_menu

    Private Sub F_pengguna_menu_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub LihatDataToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles LihatDataToolStripMenuItem.Click
        F_pengguna_file.MdiParent = Me
        F_pengguna_file.TextBox1.Text = ToolStripStatusLabel1.Text
        'caripegawai
        F_pengguna_file.Show()
    End Sub

    Private Sub LogoutToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles LogoutToolStripMenuItem.Click
        F_pengguna_login.Show()
        Me.Hide()
    End Sub
End Class