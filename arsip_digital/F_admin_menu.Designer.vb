<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class F_admin_menu
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.FormDataToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.UploadToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AkuisisiDataToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.FormPenggunaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.InputDataToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LaporanToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.FormTahapanToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.FormRekapToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.RekapPeriodikToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.RekapDivisiToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.RekapTahapanToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.FormRekapPengunjungToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.RekapPeriodikToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.RekapUmurToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LogoutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Dock = System.Windows.Forms.DockStyle.Left
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FormDataToolStripMenuItem, Me.FormPenggunaToolStripMenuItem, Me.FormTahapanToolStripMenuItem, Me.FormRekapToolStripMenuItem, Me.FormRekapPengunjungToolStripMenuItem, Me.LogoutToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(187, 698)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'FormDataToolStripMenuItem
        '
        Me.FormDataToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.UploadToolStripMenuItem, Me.AkuisisiDataToolStripMenuItem})
        Me.FormDataToolStripMenuItem.Name = "FormDataToolStripMenuItem"
        Me.FormDataToolStripMenuItem.Size = New System.Drawing.Size(174, 24)
        Me.FormDataToolStripMenuItem.Text = "Form Data"
        '
        'UploadToolStripMenuItem
        '
        Me.UploadToolStripMenuItem.Name = "UploadToolStripMenuItem"
        Me.UploadToolStripMenuItem.Size = New System.Drawing.Size(163, 24)
        Me.UploadToolStripMenuItem.Text = "Lihat Data"
        '
        'AkuisisiDataToolStripMenuItem
        '
        Me.AkuisisiDataToolStripMenuItem.Name = "AkuisisiDataToolStripMenuItem"
        Me.AkuisisiDataToolStripMenuItem.Size = New System.Drawing.Size(163, 24)
        Me.AkuisisiDataToolStripMenuItem.Text = "Akuisisi Data"
        '
        'FormPenggunaToolStripMenuItem
        '
        Me.FormPenggunaToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.InputDataToolStripMenuItem, Me.LaporanToolStripMenuItem1})
        Me.FormPenggunaToolStripMenuItem.Name = "FormPenggunaToolStripMenuItem"
        Me.FormPenggunaToolStripMenuItem.Size = New System.Drawing.Size(174, 24)
        Me.FormPenggunaToolStripMenuItem.Text = "Form Pengguna"
        '
        'InputDataToolStripMenuItem
        '
        Me.InputDataToolStripMenuItem.Name = "InputDataToolStripMenuItem"
        Me.InputDataToolStripMenuItem.Size = New System.Drawing.Size(149, 24)
        Me.InputDataToolStripMenuItem.Text = "Input Data"
        '
        'LaporanToolStripMenuItem1
        '
        Me.LaporanToolStripMenuItem1.Name = "LaporanToolStripMenuItem1"
        Me.LaporanToolStripMenuItem1.Size = New System.Drawing.Size(149, 24)
        Me.LaporanToolStripMenuItem1.Text = "Konfirmasi"
        '
        'FormTahapanToolStripMenuItem
        '
        Me.FormTahapanToolStripMenuItem.Name = "FormTahapanToolStripMenuItem"
        Me.FormTahapanToolStripMenuItem.Size = New System.Drawing.Size(174, 24)
        Me.FormTahapanToolStripMenuItem.Text = "Form Tahapan"
        '
        'FormRekapToolStripMenuItem
        '
        Me.FormRekapToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.RekapPeriodikToolStripMenuItem, Me.RekapDivisiToolStripMenuItem, Me.RekapTahapanToolStripMenuItem})
        Me.FormRekapToolStripMenuItem.Name = "FormRekapToolStripMenuItem"
        Me.FormRekapToolStripMenuItem.Size = New System.Drawing.Size(174, 24)
        Me.FormRekapToolStripMenuItem.Text = "Form Rekap Arsip"
        '
        'RekapPeriodikToolStripMenuItem
        '
        Me.RekapPeriodikToolStripMenuItem.Name = "RekapPeriodikToolStripMenuItem"
        Me.RekapPeriodikToolStripMenuItem.Size = New System.Drawing.Size(178, 24)
        Me.RekapPeriodikToolStripMenuItem.Text = "Rekap Periodik"
        '
        'RekapDivisiToolStripMenuItem
        '
        Me.RekapDivisiToolStripMenuItem.Name = "RekapDivisiToolStripMenuItem"
        Me.RekapDivisiToolStripMenuItem.Size = New System.Drawing.Size(178, 24)
        Me.RekapDivisiToolStripMenuItem.Text = "Rekap Divisi"
        '
        'RekapTahapanToolStripMenuItem
        '
        Me.RekapTahapanToolStripMenuItem.Name = "RekapTahapanToolStripMenuItem"
        Me.RekapTahapanToolStripMenuItem.Size = New System.Drawing.Size(178, 24)
        Me.RekapTahapanToolStripMenuItem.Text = "Rekap Tahapan"
        '
        'FormRekapPengunjungToolStripMenuItem
        '
        Me.FormRekapPengunjungToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.RekapPeriodikToolStripMenuItem1, Me.RekapUmurToolStripMenuItem})
        Me.FormRekapPengunjungToolStripMenuItem.Name = "FormRekapPengunjungToolStripMenuItem"
        Me.FormRekapPengunjungToolStripMenuItem.Size = New System.Drawing.Size(174, 24)
        Me.FormRekapPengunjungToolStripMenuItem.Text = "Form Rekap Pengunjung"
        '
        'RekapPeriodikToolStripMenuItem1
        '
        Me.RekapPeriodikToolStripMenuItem1.Name = "RekapPeriodikToolStripMenuItem1"
        Me.RekapPeriodikToolStripMenuItem1.Size = New System.Drawing.Size(176, 24)
        Me.RekapPeriodikToolStripMenuItem1.Text = "Rekap Periodik"
        '
        'RekapUmurToolStripMenuItem
        '
        Me.RekapUmurToolStripMenuItem.Name = "RekapUmurToolStripMenuItem"
        Me.RekapUmurToolStripMenuItem.Size = New System.Drawing.Size(176, 24)
        Me.RekapUmurToolStripMenuItem.Text = "Rekap Umur"
        '
        'LogoutToolStripMenuItem
        '
        Me.LogoutToolStripMenuItem.Name = "LogoutToolStripMenuItem"
        Me.LogoutToolStripMenuItem.Size = New System.Drawing.Size(174, 24)
        Me.LogoutToolStripMenuItem.Text = "Logout"
        '
        'F_admin_menu
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.arsip_digital.My.Resources.Resources.bfaa9606_f029_467f_bc92_9d8e56d68086
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1172, 698)
        Me.Controls.Add(Me.MenuStrip1)
        Me.IsMdiContainer = True
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "F_admin_menu"
        Me.Text = "APLIKASI ARSIP DIGITAL KPU KOTA SUKABUMI"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents FormDataToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents UploadToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents FormPenggunaToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents InputDataToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents LaporanToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents FormTahapanToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents FormRekapToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents RekapPeriodikToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents RekapDivisiToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents RekapTahapanToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents FormRekapPengunjungToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents LogoutToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents RekapPeriodikToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents RekapUmurToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AkuisisiDataToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
End Class
