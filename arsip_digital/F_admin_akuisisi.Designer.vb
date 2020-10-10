<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class F_admin_akuisisi
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
        Dim JumlahLabel As System.Windows.Forms.Label
        Dim Label1 As System.Windows.Forms.Label
        Dim Label2 As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(F_admin_akuisisi))
        Dim Kode_kearsipanLabel As System.Windows.Forms.Label
        Dim TahapanLabel1 As System.Windows.Forms.Label
        Dim Kode_jabatanLabel As System.Windows.Forms.Label
        Dim TahunLabel As System.Windows.Forms.Label
        Dim BulanLabel As System.Windows.Forms.Label
        Dim Kode_wilayahLabel As System.Windows.Forms.Label
        Dim Kode_biroLabel As System.Windows.Forms.Label
        Dim Kode_naskah_dinasLabel As System.Windows.Forms.Label
        Dim TanggalLabel As System.Windows.Forms.Label
        Dim IdLabel As System.Windows.Forms.Label
        Dim Nama_fileLabel As System.Windows.Forms.Label
        Dim DivisiLabel As System.Windows.Forms.Label
        Dim TahapanLabel As System.Windows.Forms.Label
        Dim FileLabel As System.Windows.Forms.Label
        Dim JenisLabel As System.Windows.Forms.Label
        Dim IntisariLabel As System.Windows.Forms.Label
        Dim PutusanLabel As System.Windows.Forms.Label
        Dim KronologiLabel As System.Windows.Forms.Label
        Dim KeteranganLabel As System.Windows.Forms.Label
        Dim LantaiLabel As System.Windows.Forms.Label
        Dim SampulLabel As System.Windows.Forms.Label
        Dim KotakLabel As System.Windows.Forms.Label
        Dim StatusLabel As System.Windows.Forms.Label
        Dim RakLabel As System.Windows.Forms.Label
        Dim Kode_arsip_fasilitatisLabel As System.Windows.Forms.Label
        Dim Kode_arsip_substantifLabel As System.Windows.Forms.Label
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.AxAcroPDF1 = New AxAcroPDFLib.AxAcroPDF()
        Me.JumlahTextBox = New System.Windows.Forms.TextBox()
        Me.b_simpan = New System.Windows.Forms.Button()
        Me.caridata = New System.Windows.Forms.TextBox()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.Button6 = New System.Windows.Forms.Button()
        Me.Kode_kearsipanTextBox = New System.Windows.Forms.TextBox()
        Me.TahapanTextBox = New System.Windows.Forms.ComboBox()
        Me.Kode_jabatanTextBox = New System.Windows.Forms.TextBox()
        Me.BulanTextBox = New System.Windows.Forms.ComboBox()
        Me.TahunTextBox = New System.Windows.Forms.TextBox()
        Me.Kode_wilayahTextBox = New System.Windows.Forms.TextBox()
        Me.Kode_biroTextBox = New System.Windows.Forms.TextBox()
        Me.Kode_naskah_dinasTextBox = New System.Windows.Forms.TextBox()
        Me.Jenis_pemilihanTextBox = New System.Windows.Forms.ComboBox()
        Me.KeteranganTextBox = New System.Windows.Forms.ComboBox()
        Me.JenisTextBox = New System.Windows.Forms.ComboBox()
        Me.DivisiTextBox = New System.Windows.Forms.ComboBox()
        Me.KronologiTextBox = New System.Windows.Forms.RichTextBox()
        Me.PutusanTextBox = New System.Windows.Forms.RichTextBox()
        Me.IntisariTextBox = New System.Windows.Forms.RichTextBox()
        Me.TanggalDateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.IdTextBox = New System.Windows.Forms.TextBox()
        Me.Nama_fileTextBox = New System.Windows.Forms.TextBox()
        Me.FileTextBox = New System.Windows.Forms.TextBox()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.LantaiTextBox = New System.Windows.Forms.TextBox()
        Me.SampulTextBox = New System.Windows.Forms.TextBox()
        Me.KotakTextBox = New System.Windows.Forms.TextBox()
        Me.StatusTextBox = New System.Windows.Forms.TextBox()
        Me.RakTextBox = New System.Windows.Forms.TextBox()
        Me.Kode_arsip_fasilitatisTextBox = New System.Windows.Forms.TextBox()
        Me.Kode_arsip_substantifTextBox = New System.Windows.Forms.TextBox()
        JumlahLabel = New System.Windows.Forms.Label()
        Label1 = New System.Windows.Forms.Label()
        Label2 = New System.Windows.Forms.Label()
        Kode_kearsipanLabel = New System.Windows.Forms.Label()
        TahapanLabel1 = New System.Windows.Forms.Label()
        Kode_jabatanLabel = New System.Windows.Forms.Label()
        TahunLabel = New System.Windows.Forms.Label()
        BulanLabel = New System.Windows.Forms.Label()
        Kode_wilayahLabel = New System.Windows.Forms.Label()
        Kode_biroLabel = New System.Windows.Forms.Label()
        Kode_naskah_dinasLabel = New System.Windows.Forms.Label()
        TanggalLabel = New System.Windows.Forms.Label()
        IdLabel = New System.Windows.Forms.Label()
        Nama_fileLabel = New System.Windows.Forms.Label()
        DivisiLabel = New System.Windows.Forms.Label()
        TahapanLabel = New System.Windows.Forms.Label()
        FileLabel = New System.Windows.Forms.Label()
        JenisLabel = New System.Windows.Forms.Label()
        IntisariLabel = New System.Windows.Forms.Label()
        PutusanLabel = New System.Windows.Forms.Label()
        KronologiLabel = New System.Windows.Forms.Label()
        KeteranganLabel = New System.Windows.Forms.Label()
        LantaiLabel = New System.Windows.Forms.Label()
        SampulLabel = New System.Windows.Forms.Label()
        KotakLabel = New System.Windows.Forms.Label()
        StatusLabel = New System.Windows.Forms.Label()
        RakLabel = New System.Windows.Forms.Label()
        Kode_arsip_fasilitatisLabel = New System.Windows.Forms.Label()
        Kode_arsip_substantifLabel = New System.Windows.Forms.Label()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AxAcroPDF1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'JumlahLabel
        '
        JumlahLabel.AutoSize = True
        JumlahLabel.Location = New System.Drawing.Point(1056, 620)
        JumlahLabel.Name = "JumlahLabel"
        JumlahLabel.Size = New System.Drawing.Size(53, 17)
        JumlahLabel.TabIndex = 185
        JumlahLabel.Text = "jumlah:"
        JumlahLabel.Visible = False
        '
        'Label1
        '
        Label1.AutoSize = True
        Label1.Location = New System.Drawing.Point(970, 241)
        Label1.Name = "Label1"
        Label1.Size = New System.Drawing.Size(71, 17)
        Label1.TabIndex = 136
        Label1.Text = "Cari Data:"
        '
        'Label2
        '
        Label2.AutoSize = True
        Label2.Location = New System.Drawing.Point(967, 174)
        Label2.Name = "Label2"
        Label2.Size = New System.Drawing.Size(163, 17)
        Label2.TabIndex = 162
        Label2.Text = "Pilih Kategori Pencarian:"
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(12, 346)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.RowTemplate.Height = 24
        Me.DataGridView1.Size = New System.Drawing.Size(1237, 220)
        Me.DataGridView1.TabIndex = 183
        '
        'AxAcroPDF1
        '
        Me.AxAcroPDF1.Enabled = True
        Me.AxAcroPDF1.Location = New System.Drawing.Point(9, 396)
        Me.AxAcroPDF1.Name = "AxAcroPDF1"
        Me.AxAcroPDF1.OcxState = CType(resources.GetObject("AxAcroPDF1.OcxState"), System.Windows.Forms.AxHost.State)
        Me.AxAcroPDF1.Size = New System.Drawing.Size(940, 312)
        Me.AxAcroPDF1.TabIndex = 184
        '
        'JumlahTextBox
        '
        Me.JumlahTextBox.Location = New System.Drawing.Point(1115, 617)
        Me.JumlahTextBox.Name = "JumlahTextBox"
        Me.JumlahTextBox.Size = New System.Drawing.Size(100, 22)
        Me.JumlahTextBox.TabIndex = 186
        Me.JumlahTextBox.Visible = False
        '
        'b_simpan
        '
        Me.b_simpan.Location = New System.Drawing.Point(811, 194)
        Me.b_simpan.Margin = New System.Windows.Forms.Padding(4)
        Me.b_simpan.Name = "b_simpan"
        Me.b_simpan.Size = New System.Drawing.Size(139, 35)
        Me.b_simpan.TabIndex = 132
        Me.b_simpan.Text = "Akuisisi"
        Me.b_simpan.UseVisualStyleBackColor = True
        '
        'caridata
        '
        Me.caridata.Location = New System.Drawing.Point(968, 268)
        Me.caridata.Name = "caridata"
        Me.caridata.Size = New System.Drawing.Size(286, 22)
        Me.caridata.TabIndex = 135
        '
        'ComboBox1
        '
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Items.AddRange(New Object() {"Nama File", "Jenis File", "Divisi", "Intisari", "Putusan", "Kronologi"})
        Me.ComboBox1.Location = New System.Drawing.Point(970, 205)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(121, 24)
        Me.ComboBox1.TabIndex = 160
        '
        'Button6
        '
        Me.Button6.Location = New System.Drawing.Point(973, 305)
        Me.Button6.Name = "Button6"
        Me.Button6.Size = New System.Drawing.Size(281, 36)
        Me.Button6.TabIndex = 161
        Me.Button6.Text = "Cari"
        Me.Button6.UseVisualStyleBackColor = True
        '
        'Kode_kearsipanLabel
        '
        Kode_kearsipanLabel.AutoSize = True
        Kode_kearsipanLabel.Location = New System.Drawing.Point(407, 16)
        Kode_kearsipanLabel.Name = "Kode_kearsipanLabel"
        Kode_kearsipanLabel.Size = New System.Drawing.Size(109, 17)
        Kode_kearsipanLabel.TabIndex = 224
        Kode_kearsipanLabel.Text = "kode kearsipan:"
        '
        'Kode_kearsipanTextBox
        '
        Me.Kode_kearsipanTextBox.Location = New System.Drawing.Point(529, 13)
        Me.Kode_kearsipanTextBox.Name = "Kode_kearsipanTextBox"
        Me.Kode_kearsipanTextBox.Size = New System.Drawing.Size(262, 22)
        Me.Kode_kearsipanTextBox.TabIndex = 225
        '
        'TahapanTextBox
        '
        Me.TahapanTextBox.FormattingEnabled = True
        Me.TahapanTextBox.Items.AddRange(New Object() {"Non Tahapan"})
        Me.TahapanTextBox.Location = New System.Drawing.Point(118, 126)
        Me.TahapanTextBox.Name = "TahapanTextBox"
        Me.TahapanTextBox.Size = New System.Drawing.Size(283, 24)
        Me.TahapanTextBox.TabIndex = 223
        '
        'TahapanLabel1
        '
        TahapanLabel1.AutoSize = True
        TahapanLabel1.Location = New System.Drawing.Point(12, 132)
        TahapanLabel1.Name = "TahapanLabel1"
        TahapanLabel1.Size = New System.Drawing.Size(64, 17)
        TahapanLabel1.TabIndex = 222
        TahapanLabel1.Text = "tahapan:"
        '
        'Kode_jabatanLabel
        '
        Kode_jabatanLabel.AutoSize = True
        Kode_jabatanLabel.Location = New System.Drawing.Point(12, 244)
        Kode_jabatanLabel.Name = "Kode_jabatanLabel"
        Kode_jabatanLabel.Size = New System.Drawing.Size(94, 17)
        Kode_jabatanLabel.TabIndex = 220
        Kode_jabatanLabel.Text = "kode jabatan:"
        '
        'Kode_jabatanTextBox
        '
        Me.Kode_jabatanTextBox.Location = New System.Drawing.Point(157, 239)
        Me.Kode_jabatanTextBox.Name = "Kode_jabatanTextBox"
        Me.Kode_jabatanTextBox.Size = New System.Drawing.Size(244, 22)
        Me.Kode_jabatanTextBox.TabIndex = 221
        '
        'BulanTextBox
        '
        Me.BulanTextBox.FormattingEnabled = True
        Me.BulanTextBox.Items.AddRange(New Object() {"JANUARI", "FEBRUARI", "MARET", "APRIL", "MEI", "JUNI", "JULI", "AGUSTUS", "SEPTEMBER", "OKTOBER", "NOVEMBER", "DESEMBER"})
        Me.BulanTextBox.Location = New System.Drawing.Point(157, 292)
        Me.BulanTextBox.Name = "BulanTextBox"
        Me.BulanTextBox.Size = New System.Drawing.Size(121, 24)
        Me.BulanTextBox.TabIndex = 219
        '
        'TahunLabel
        '
        TahunLabel.AutoSize = True
        TahunLabel.Location = New System.Drawing.Point(12, 323)
        TahunLabel.Name = "TahunLabel"
        TahunLabel.Size = New System.Drawing.Size(48, 17)
        TahunLabel.TabIndex = 217
        TahunLabel.Text = "tahun:"
        '
        'TahunTextBox
        '
        Me.TahunTextBox.Location = New System.Drawing.Point(157, 320)
        Me.TahunTextBox.Name = "TahunTextBox"
        Me.TahunTextBox.Size = New System.Drawing.Size(244, 22)
        Me.TahunTextBox.TabIndex = 218
        '
        'BulanLabel
        '
        BulanLabel.AutoSize = True
        BulanLabel.Location = New System.Drawing.Point(12, 296)
        BulanLabel.Name = "BulanLabel"
        BulanLabel.Size = New System.Drawing.Size(47, 17)
        BulanLabel.TabIndex = 215
        BulanLabel.Text = "bulan:"
        '
        'Kode_wilayahLabel
        '
        Kode_wilayahLabel.AutoSize = True
        Kode_wilayahLabel.Location = New System.Drawing.Point(12, 269)
        Kode_wilayahLabel.Name = "Kode_wilayahLabel"
        Kode_wilayahLabel.Size = New System.Drawing.Size(93, 17)
        Kode_wilayahLabel.TabIndex = 213
        Kode_wilayahLabel.Text = "kode wilayah:"
        '
        'Kode_wilayahTextBox
        '
        Me.Kode_wilayahTextBox.Location = New System.Drawing.Point(157, 266)
        Me.Kode_wilayahTextBox.Name = "Kode_wilayahTextBox"
        Me.Kode_wilayahTextBox.Size = New System.Drawing.Size(244, 22)
        Me.Kode_wilayahTextBox.TabIndex = 216
        '
        'Kode_biroLabel
        '
        Kode_biroLabel.AutoSize = True
        Kode_biroLabel.Location = New System.Drawing.Point(12, 212)
        Kode_biroLabel.Name = "Kode_biroLabel"
        Kode_biroLabel.Size = New System.Drawing.Size(71, 17)
        Kode_biroLabel.TabIndex = 212
        Kode_biroLabel.Text = "kode biro:"
        '
        'Kode_biroTextBox
        '
        Me.Kode_biroTextBox.Location = New System.Drawing.Point(157, 212)
        Me.Kode_biroTextBox.Name = "Kode_biroTextBox"
        Me.Kode_biroTextBox.Size = New System.Drawing.Size(244, 22)
        Me.Kode_biroTextBox.TabIndex = 214
        '
        'Kode_naskah_dinasLabel
        '
        Kode_naskah_dinasLabel.AutoSize = True
        Kode_naskah_dinasLabel.Location = New System.Drawing.Point(12, 187)
        Kode_naskah_dinasLabel.Name = "Kode_naskah_dinasLabel"
        Kode_naskah_dinasLabel.Size = New System.Drawing.Size(131, 17)
        Kode_naskah_dinasLabel.TabIndex = 210
        Kode_naskah_dinasLabel.Text = "kode naskah dinas:"
        '
        'Kode_naskah_dinasTextBox
        '
        Me.Kode_naskah_dinasTextBox.Location = New System.Drawing.Point(157, 184)
        Me.Kode_naskah_dinasTextBox.Name = "Kode_naskah_dinasTextBox"
        Me.Kode_naskah_dinasTextBox.Size = New System.Drawing.Size(244, 22)
        Me.Kode_naskah_dinasTextBox.TabIndex = 211
        '
        'Jenis_pemilihanTextBox
        '
        Me.Jenis_pemilihanTextBox.FormattingEnabled = True
        Me.Jenis_pemilihanTextBox.Location = New System.Drawing.Point(118, 154)
        Me.Jenis_pemilihanTextBox.Name = "Jenis_pemilihanTextBox"
        Me.Jenis_pemilihanTextBox.Size = New System.Drawing.Size(283, 24)
        Me.Jenis_pemilihanTextBox.TabIndex = 209
        '
        'KeteranganTextBox
        '
        Me.KeteranganTextBox.FormattingEnabled = True
        Me.KeteranganTextBox.Items.AddRange(New Object() {"Umum", "Internal"})
        Me.KeteranganTextBox.Location = New System.Drawing.Point(529, 100)
        Me.KeteranganTextBox.Name = "KeteranganTextBox"
        Me.KeteranganTextBox.Size = New System.Drawing.Size(262, 24)
        Me.KeteranganTextBox.TabIndex = 208
        '
        'JenisTextBox
        '
        Me.JenisTextBox.FormattingEnabled = True
        Me.JenisTextBox.Items.AddRange(New Object() {"Surat", "Surat Edaran", "Surat Keputusan", "Berita Acara"})
        Me.JenisTextBox.Location = New System.Drawing.Point(529, 70)
        Me.JenisTextBox.Name = "JenisTextBox"
        Me.JenisTextBox.Size = New System.Drawing.Size(262, 24)
        Me.JenisTextBox.TabIndex = 207
        '
        'DivisiTextBox
        '
        Me.DivisiTextBox.FormattingEnabled = True
        Me.DivisiTextBox.Location = New System.Drawing.Point(118, 98)
        Me.DivisiTextBox.Name = "DivisiTextBox"
        Me.DivisiTextBox.Size = New System.Drawing.Size(283, 24)
        Me.DivisiTextBox.TabIndex = 206
        '
        'KronologiTextBox
        '
        Me.KronologiTextBox.Location = New System.Drawing.Point(499, 284)
        Me.KronologiTextBox.Name = "KronologiTextBox"
        Me.KronologiTextBox.Size = New System.Drawing.Size(292, 56)
        Me.KronologiTextBox.TabIndex = 205
        Me.KronologiTextBox.Text = ""
        '
        'PutusanTextBox
        '
        Me.PutusanTextBox.Location = New System.Drawing.Point(499, 219)
        Me.PutusanTextBox.Name = "PutusanTextBox"
        Me.PutusanTextBox.Size = New System.Drawing.Size(292, 56)
        Me.PutusanTextBox.TabIndex = 204
        Me.PutusanTextBox.Text = ""
        '
        'IntisariTextBox
        '
        Me.IntisariTextBox.Location = New System.Drawing.Point(499, 155)
        Me.IntisariTextBox.Name = "IntisariTextBox"
        Me.IntisariTextBox.Size = New System.Drawing.Size(292, 56)
        Me.IntisariTextBox.TabIndex = 203
        Me.IntisariTextBox.Text = ""
        '
        'TanggalLabel
        '
        TanggalLabel.AutoSize = True
        TanggalLabel.Location = New System.Drawing.Point(12, 18)
        TanggalLabel.Name = "TanggalLabel"
        TanggalLabel.Size = New System.Drawing.Size(59, 17)
        TanggalLabel.TabIndex = 188
        TanggalLabel.Text = "tanggal:"
        '
        'TanggalDateTimePicker
        '
        Me.TanggalDateTimePicker.Enabled = False
        Me.TanggalDateTimePicker.Location = New System.Drawing.Point(118, 15)
        Me.TanggalDateTimePicker.Name = "TanggalDateTimePicker"
        Me.TanggalDateTimePicker.Size = New System.Drawing.Size(200, 22)
        Me.TanggalDateTimePicker.TabIndex = 189
        '
        'IdLabel
        '
        IdLabel.AutoSize = True
        IdLabel.Location = New System.Drawing.Point(12, 47)
        IdLabel.Name = "IdLabel"
        IdLabel.Size = New System.Drawing.Size(23, 17)
        IdLabel.TabIndex = 190
        IdLabel.Text = "id:"
        '
        'IdTextBox
        '
        Me.IdTextBox.Enabled = False
        Me.IdTextBox.Location = New System.Drawing.Point(118, 43)
        Me.IdTextBox.Name = "IdTextBox"
        Me.IdTextBox.Size = New System.Drawing.Size(283, 22)
        Me.IdTextBox.TabIndex = 191
        '
        'Nama_fileLabel
        '
        Nama_fileLabel.AutoSize = True
        Nama_fileLabel.Location = New System.Drawing.Point(12, 75)
        Nama_fileLabel.Name = "Nama_fileLabel"
        Nama_fileLabel.Size = New System.Drawing.Size(69, 17)
        Nama_fileLabel.TabIndex = 192
        Nama_fileLabel.Text = "nama file:"
        '
        'Nama_fileTextBox
        '
        Me.Nama_fileTextBox.Location = New System.Drawing.Point(118, 71)
        Me.Nama_fileTextBox.Name = "Nama_fileTextBox"
        Me.Nama_fileTextBox.Size = New System.Drawing.Size(283, 22)
        Me.Nama_fileTextBox.TabIndex = 193
        '
        'DivisiLabel
        '
        DivisiLabel.AutoSize = True
        DivisiLabel.Location = New System.Drawing.Point(12, 103)
        DivisiLabel.Name = "DivisiLabel"
        DivisiLabel.Size = New System.Drawing.Size(43, 17)
        DivisiLabel.TabIndex = 194
        DivisiLabel.Text = "divisi:"
        '
        'TahapanLabel
        '
        TahapanLabel.AutoSize = True
        TahapanLabel.Location = New System.Drawing.Point(12, 158)
        TahapanLabel.Name = "TahapanLabel"
        TahapanLabel.Size = New System.Drawing.Size(105, 17)
        TahapanLabel.TabIndex = 195
        TahapanLabel.Text = "jenis pemilihan:"
        '
        'FileLabel
        '
        FileLabel.AutoSize = True
        FileLabel.Location = New System.Drawing.Point(423, 45)
        FileLabel.Name = "FileLabel"
        FileLabel.Size = New System.Drawing.Size(30, 17)
        FileLabel.TabIndex = 196
        FileLabel.Text = "file:"
        '
        'FileTextBox
        '
        Me.FileTextBox.Enabled = False
        Me.FileTextBox.Location = New System.Drawing.Point(529, 41)
        Me.FileTextBox.Name = "FileTextBox"
        Me.FileTextBox.Size = New System.Drawing.Size(179, 22)
        Me.FileTextBox.TabIndex = 197
        '
        'JenisLabel
        '
        JenisLabel.AutoSize = True
        JenisLabel.Location = New System.Drawing.Point(423, 73)
        JenisLabel.Name = "JenisLabel"
        JenisLabel.Size = New System.Drawing.Size(41, 17)
        JenisLabel.TabIndex = 198
        JenisLabel.Text = "jenis:"
        '
        'IntisariLabel
        '
        IntisariLabel.AutoSize = True
        IntisariLabel.Location = New System.Drawing.Point(421, 155)
        IntisariLabel.Name = "IntisariLabel"
        IntisariLabel.Size = New System.Drawing.Size(53, 17)
        IntisariLabel.TabIndex = 199
        IntisariLabel.Text = "intisari:"
        '
        'PutusanLabel
        '
        PutusanLabel.AutoSize = True
        PutusanLabel.Location = New System.Drawing.Point(421, 219)
        PutusanLabel.Name = "PutusanLabel"
        PutusanLabel.Size = New System.Drawing.Size(63, 17)
        PutusanLabel.TabIndex = 200
        PutusanLabel.Text = "putusan:"
        '
        'KronologiLabel
        '
        KronologiLabel.AutoSize = True
        KronologiLabel.Location = New System.Drawing.Point(423, 284)
        KronologiLabel.Name = "KronologiLabel"
        KronologiLabel.Size = New System.Drawing.Size(70, 17)
        KronologiLabel.TabIndex = 201
        KronologiLabel.Text = "kronologi:"
        '
        'KeteranganLabel
        '
        KeteranganLabel.AutoSize = True
        KeteranganLabel.Location = New System.Drawing.Point(423, 101)
        KeteranganLabel.Name = "KeteranganLabel"
        KeteranganLabel.Size = New System.Drawing.Size(84, 17)
        KeteranganLabel.TabIndex = 202
        KeteranganLabel.Text = "keterangan:"
        '
        'Button4
        '
        Me.Button4.Location = New System.Drawing.Point(715, 40)
        Me.Button4.Margin = New System.Windows.Forms.Padding(4)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(76, 27)
        Me.Button4.TabIndex = 187
        Me.Button4.Text = "Pilih File"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'LantaiLabel
        '
        LantaiLabel.AutoSize = True
        LantaiLabel.Location = New System.Drawing.Point(1078, 122)
        LantaiLabel.Name = "LantaiLabel"
        LantaiLabel.Size = New System.Drawing.Size(46, 17)
        LantaiLabel.TabIndex = 238
        LantaiLabel.Text = "lantai:"
        '
        'LantaiTextBox
        '
        Me.LantaiTextBox.Location = New System.Drawing.Point(1130, 119)
        Me.LantaiTextBox.Name = "LantaiTextBox"
        Me.LantaiTextBox.Size = New System.Drawing.Size(100, 22)
        Me.LantaiTextBox.TabIndex = 239
        '
        'SampulLabel
        '
        SampulLabel.AutoSize = True
        SampulLabel.Location = New System.Drawing.Point(805, 71)
        SampulLabel.Name = "SampulLabel"
        SampulLabel.Size = New System.Drawing.Size(57, 17)
        SampulLabel.TabIndex = 235
        SampulLabel.Text = "sampul:"
        '
        'SampulTextBox
        '
        Me.SampulTextBox.Location = New System.Drawing.Point(957, 68)
        Me.SampulTextBox.Name = "SampulTextBox"
        Me.SampulTextBox.Size = New System.Drawing.Size(273, 22)
        Me.SampulTextBox.TabIndex = 237
        '
        'KotakLabel
        '
        KotakLabel.AutoSize = True
        KotakLabel.Location = New System.Drawing.Point(808, 98)
        KotakLabel.Name = "KotakLabel"
        KotakLabel.Size = New System.Drawing.Size(46, 17)
        KotakLabel.TabIndex = 234
        KotakLabel.Text = "kotak:"
        '
        'KotakTextBox
        '
        Me.KotakTextBox.Location = New System.Drawing.Point(957, 93)
        Me.KotakTextBox.Name = "KotakTextBox"
        Me.KotakTextBox.Size = New System.Drawing.Size(273, 22)
        Me.KotakTextBox.TabIndex = 236
        '
        'StatusLabel
        '
        StatusLabel.AutoSize = True
        StatusLabel.Location = New System.Drawing.Point(808, 150)
        StatusLabel.Name = "StatusLabel"
        StatusLabel.Size = New System.Drawing.Size(50, 17)
        StatusLabel.TabIndex = 232
        StatusLabel.Text = "status:"
        StatusLabel.Visible = False
        '
        'StatusTextBox
        '
        Me.StatusTextBox.Location = New System.Drawing.Point(957, 147)
        Me.StatusTextBox.Name = "StatusTextBox"
        Me.StatusTextBox.Size = New System.Drawing.Size(100, 22)
        Me.StatusTextBox.TabIndex = 233
        '
        'RakLabel
        '
        RakLabel.AutoSize = True
        RakLabel.Location = New System.Drawing.Point(808, 122)
        RakLabel.Name = "RakLabel"
        RakLabel.Size = New System.Drawing.Size(32, 17)
        RakLabel.TabIndex = 230
        RakLabel.Text = "rak:"
        '
        'RakTextBox
        '
        Me.RakTextBox.Location = New System.Drawing.Point(957, 119)
        Me.RakTextBox.Name = "RakTextBox"
        Me.RakTextBox.Size = New System.Drawing.Size(115, 22)
        Me.RakTextBox.TabIndex = 231
        '
        'Kode_arsip_fasilitatisLabel
        '
        Kode_arsip_fasilitatisLabel.AutoSize = True
        Kode_arsip_fasilitatisLabel.Location = New System.Drawing.Point(806, 44)
        Kode_arsip_fasilitatisLabel.Name = "Kode_arsip_fasilitatisLabel"
        Kode_arsip_fasilitatisLabel.Size = New System.Drawing.Size(136, 17)
        Kode_arsip_fasilitatisLabel.TabIndex = 227
        Kode_arsip_fasilitatisLabel.Text = "kode arsip fasilitatis:"
        '
        'Kode_arsip_fasilitatisTextBox
        '
        Me.Kode_arsip_fasilitatisTextBox.Location = New System.Drawing.Point(955, 41)
        Me.Kode_arsip_fasilitatisTextBox.Name = "Kode_arsip_fasilitatisTextBox"
        Me.Kode_arsip_fasilitatisTextBox.Size = New System.Drawing.Size(276, 22)
        Me.Kode_arsip_fasilitatisTextBox.TabIndex = 229
        '
        'Kode_arsip_substantifLabel
        '
        Kode_arsip_substantifLabel.AutoSize = True
        Kode_arsip_substantifLabel.Location = New System.Drawing.Point(806, 16)
        Kode_arsip_substantifLabel.Name = "Kode_arsip_substantifLabel"
        Kode_arsip_substantifLabel.Size = New System.Drawing.Size(143, 17)
        Kode_arsip_substantifLabel.TabIndex = 226
        Kode_arsip_substantifLabel.Text = "kode arsip substantif:"
        '
        'Kode_arsip_substantifTextBox
        '
        Me.Kode_arsip_substantifTextBox.Location = New System.Drawing.Point(955, 13)
        Me.Kode_arsip_substantifTextBox.Name = "Kode_arsip_substantifTextBox"
        Me.Kode_arsip_substantifTextBox.Size = New System.Drawing.Size(276, 22)
        Me.Kode_arsip_substantifTextBox.TabIndex = 228
        '
        'F_admin_akuisisi
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.arsip_digital.My.Resources.Resources._6e8ec8f0_b5ea_4454_8266_48e3aacbc59c
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1366, 797)
        Me.Controls.Add(LantaiLabel)
        Me.Controls.Add(Me.LantaiTextBox)
        Me.Controls.Add(SampulLabel)
        Me.Controls.Add(Me.SampulTextBox)
        Me.Controls.Add(KotakLabel)
        Me.Controls.Add(Me.KotakTextBox)
        Me.Controls.Add(StatusLabel)
        Me.Controls.Add(Me.StatusTextBox)
        Me.Controls.Add(RakLabel)
        Me.Controls.Add(Me.RakTextBox)
        Me.Controls.Add(Kode_arsip_fasilitatisLabel)
        Me.Controls.Add(Me.Kode_arsip_fasilitatisTextBox)
        Me.Controls.Add(Kode_arsip_substantifLabel)
        Me.Controls.Add(Me.Kode_arsip_substantifTextBox)
        Me.Controls.Add(Kode_kearsipanLabel)
        Me.Controls.Add(Me.Kode_kearsipanTextBox)
        Me.Controls.Add(Me.TahapanTextBox)
        Me.Controls.Add(TahapanLabel1)
        Me.Controls.Add(Kode_jabatanLabel)
        Me.Controls.Add(Me.Kode_jabatanTextBox)
        Me.Controls.Add(Me.BulanTextBox)
        Me.Controls.Add(TahunLabel)
        Me.Controls.Add(Me.TahunTextBox)
        Me.Controls.Add(BulanLabel)
        Me.Controls.Add(Kode_wilayahLabel)
        Me.Controls.Add(Me.Kode_wilayahTextBox)
        Me.Controls.Add(Kode_biroLabel)
        Me.Controls.Add(Me.Kode_biroTextBox)
        Me.Controls.Add(Kode_naskah_dinasLabel)
        Me.Controls.Add(Me.Kode_naskah_dinasTextBox)
        Me.Controls.Add(Me.Jenis_pemilihanTextBox)
        Me.Controls.Add(Me.KeteranganTextBox)
        Me.Controls.Add(Me.JenisTextBox)
        Me.Controls.Add(Me.DivisiTextBox)
        Me.Controls.Add(Me.KronologiTextBox)
        Me.Controls.Add(Me.PutusanTextBox)
        Me.Controls.Add(Me.IntisariTextBox)
        Me.Controls.Add(TanggalLabel)
        Me.Controls.Add(Me.TanggalDateTimePicker)
        Me.Controls.Add(IdLabel)
        Me.Controls.Add(Me.IdTextBox)
        Me.Controls.Add(Nama_fileLabel)
        Me.Controls.Add(Me.Nama_fileTextBox)
        Me.Controls.Add(DivisiLabel)
        Me.Controls.Add(TahapanLabel)
        Me.Controls.Add(FileLabel)
        Me.Controls.Add(Me.FileTextBox)
        Me.Controls.Add(JenisLabel)
        Me.Controls.Add(IntisariLabel)
        Me.Controls.Add(PutusanLabel)
        Me.Controls.Add(KronologiLabel)
        Me.Controls.Add(KeteranganLabel)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(JumlahLabel)
        Me.Controls.Add(Me.JumlahTextBox)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Label2)
        Me.Controls.Add(Me.Button6)
        Me.Controls.Add(Me.ComboBox1)
        Me.Controls.Add(Label1)
        Me.Controls.Add(Me.caridata)
        Me.Controls.Add(Me.b_simpan)
        Me.Controls.Add(Me.AxAcroPDF1)
        Me.Name = "F_admin_akuisisi"
        Me.Text = "F_admin_akuisisi"
        CType(Me.DataGridView1,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.AxAcroPDF1,System.ComponentModel.ISupportInitialize).EndInit
        Me.ResumeLayout(false)
        Me.PerformLayout

End Sub
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents AxAcroPDF1 As AxAcroPDFLib.AxAcroPDF
    Friend WithEvents JumlahTextBox As System.Windows.Forms.TextBox
    Friend WithEvents b_simpan As System.Windows.Forms.Button
    Friend WithEvents caridata As System.Windows.Forms.TextBox
    Friend WithEvents ComboBox1 As System.Windows.Forms.ComboBox
    Friend WithEvents Button6 As System.Windows.Forms.Button
    Friend WithEvents Kode_kearsipanTextBox As System.Windows.Forms.TextBox
    Friend WithEvents TahapanTextBox As System.Windows.Forms.ComboBox
    Friend WithEvents Kode_jabatanTextBox As System.Windows.Forms.TextBox
    Friend WithEvents BulanTextBox As System.Windows.Forms.ComboBox
    Friend WithEvents TahunTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Kode_wilayahTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Kode_biroTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Kode_naskah_dinasTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Jenis_pemilihanTextBox As System.Windows.Forms.ComboBox
    Friend WithEvents KeteranganTextBox As System.Windows.Forms.ComboBox
    Friend WithEvents JenisTextBox As System.Windows.Forms.ComboBox
    Friend WithEvents DivisiTextBox As System.Windows.Forms.ComboBox
    Friend WithEvents KronologiTextBox As System.Windows.Forms.RichTextBox
    Friend WithEvents PutusanTextBox As System.Windows.Forms.RichTextBox
    Friend WithEvents IntisariTextBox As System.Windows.Forms.RichTextBox
    Friend WithEvents TanggalDateTimePicker As System.Windows.Forms.DateTimePicker
    Friend WithEvents IdTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Nama_fileTextBox As System.Windows.Forms.TextBox
    Friend WithEvents FileTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Button4 As System.Windows.Forms.Button
    Friend WithEvents LantaiTextBox As System.Windows.Forms.TextBox
    Friend WithEvents SampulTextBox As System.Windows.Forms.TextBox
    Friend WithEvents KotakTextBox As System.Windows.Forms.TextBox
    Friend WithEvents StatusTextBox As System.Windows.Forms.TextBox
    Friend WithEvents RakTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Kode_arsip_fasilitatisTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Kode_arsip_substantifTextBox As System.Windows.Forms.TextBox
End Class
