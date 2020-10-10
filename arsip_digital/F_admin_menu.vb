Public Class F_admin_menu
    Private Sub TUTUPSEMUATAB()
        For Each aform As Form In Me.MdiChildren
            aform.Close()
        Next
    End Sub
    Private Sub UploadToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles UploadToolStripMenuItem.Click
        TUTUPSEMUATAB()
        Dim arsip As New F_admin_upload
        arsip.MdiParent = Me
        arsip.Show()
    End Sub

    Private Sub InputDataToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles InputDataToolStripMenuItem.Click
        TUTUPSEMUATAB()
        Dim arsip As New F_admin_user
        arsip.MdiParent = Me
        arsip.Show()
    End Sub
    Private Sub LaporanToolStripMenuItem1_Click(sender As System.Object, e As System.EventArgs) Handles LaporanToolStripMenuItem1.Click
        TUTUPSEMUATAB()
        Dim arsip As New F_admin_konfirmasi
        arsip.MdiParent = Me
        arsip.Show()
    End Sub

    Private Sub F_admin_menu_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub FormTahapanToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles FormTahapanToolStripMenuItem.Click
        TUTUPSEMUATAB()
        Dim arsip As New F_admin_tahapan()
        arsip.MdiParent = Me
        arsip.Show()
    End Sub

    Private Sub RekapPeriodikToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles RekapPeriodikToolStripMenuItem.Click
        TUTUPSEMUATAB()
        Dim arsip As New FR_File_Periodik()
        arsip.MdiParent = Me
        arsip.Show()
    End Sub

    Private Sub RekapDivisiToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles RekapDivisiToolStripMenuItem.Click
        TUTUPSEMUATAB()
        Dim arsip As New FR_Divisi()
        arsip.MdiParent = Me
        arsip.Show()
    End Sub

    Private Sub RekapTahapanToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles RekapTahapanToolStripMenuItem.Click
        TUTUPSEMUATAB()
        Dim arsip As New FR_Tahapan()
        arsip.MdiParent = Me
        arsip.Show()
    End Sub

    Private Sub LogoutToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs)

    End Sub

    Private Sub LogoutToolStripMenuItem_Click_1(sender As System.Object, e As System.EventArgs) Handles LogoutToolStripMenuItem.Click
        F_pilih_login.Show()
        Me.Hide()

    End Sub

    Private Sub RekapPeriodikToolStripMenuItem1_Click(sender As System.Object, e As System.EventArgs) Handles RekapPeriodikToolStripMenuItem1.Click
        TUTUPSEMUATAB()
        Dim arsip As New FR_pengunjung_periodik
        arsip.MdiParent = Me
        arsip.Show()
    End Sub

    Private Sub RekapUmurToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles RekapUmurToolStripMenuItem.Click
        TUTUPSEMUATAB()
        Dim arsip As New FR_Pengunjung_umur
        arsip.MdiParent = Me
        arsip.Show()
    End Sub

    Private Sub ServerToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs)
        TUTUPSEMUATAB()
        Dim arsip As New FR_Divisi
        arsip.MdiParent = Me
        arsip.Show()
    End Sub

    Private Sub FormRekapToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles FormRekapToolStripMenuItem.Click

    End Sub

    Private Sub AkuisisiDataToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles AkuisisiDataToolStripMenuItem.Click
        TUTUPSEMUATAB()
        Dim arsip As New F_admin_akuisisi
        arsip.MdiParent = Me
        arsip.Show()
    End Sub
End Class