<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class F_pengguna_file
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
        Dim Label2 As System.Windows.Forms.Label
        Dim Label1 As System.Windows.Forms.Label
        Dim JumlahLabel As System.Windows.Forms.Label
        Dim TahapanLabel1 As System.Windows.Forms.Label
        Dim StatusLabel As System.Windows.Forms.Label
        Dim RakLabel As System.Windows.Forms.Label
        Dim Kode_arsip_fasilitatisLabel As System.Windows.Forms.Label
        Dim Kode_arsip_substantifLabel As System.Windows.Forms.Label
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(F_pengguna_file))
        Me.AxAcroPDF1 = New AxAcroPDFLib.AxAcroPDF()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.Button6 = New System.Windows.Forms.Button()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.caridata = New System.Windows.Forms.TextBox()
        Me.JumlahTextBox = New System.Windows.Forms.TextBox()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.TahapanTextBox = New System.Windows.Forms.ComboBox()
        Me.StatusTextBox = New System.Windows.Forms.TextBox()
        Me.RakTextBox = New System.Windows.Forms.TextBox()
        Me.Kode_arsip_fasilitatisTextBox = New System.Windows.Forms.TextBox()
        Me.Kode_arsip_substantifTextBox = New System.Windows.Forms.TextBox()
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
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.b_ubah = New System.Windows.Forms.Button()
        Me.b_hapus = New System.Windows.Forms.Button()
        Me.b_simpan = New System.Windows.Forms.Button()
        Me.b_databaru = New System.Windows.Forms.Button()
        Label2 = New System.Windows.Forms.Label()
        Label1 = New System.Windows.Forms.Label()
        JumlahLabel = New System.Windows.Forms.Label()
        TahapanLabel1 = New System.Windows.Forms.Label()
        StatusLabel = New System.Windows.Forms.Label()
        RakLabel = New System.Windows.Forms.Label()
        Kode_arsip_fasilitatisLabel = New System.Windows.Forms.Label()
        Kode_arsip_substantifLabel = New System.Windows.Forms.Label()
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
        CType(Me.AxAcroPDF1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label2
        '
        Label2.AutoSize = True
        Label2.Location = New System.Drawing.Point(969, 167)
        Label2.Name = "Label2"
        Label2.Size = New System.Drawing.Size(163, 17)
        Label2.TabIndex = 162
        Label2.Text = "Pilih Kategori Pencarian:"
        '
        'Label1
        '
        Label1.AutoSize = True
        Label1.Location = New System.Drawing.Point(972, 234)
        Label1.Name = "Label1"
        Label1.Size = New System.Drawing.Size(71, 17)
        Label1.TabIndex = 136
        Label1.Text = "Cari Data:"
        '
        'JumlahLabel
        '
        JumlahLabel.AutoSize = True
        JumlahLabel.Location = New System.Drawing.Point(1036, 621)
        JumlahLabel.Name = "JumlahLabel"
        JumlahLabel.Size = New System.Drawing.Size(53, 17)
        JumlahLabel.TabIndex = 183
        JumlahLabel.Text = "jumlah:"
        JumlahLabel.Visible = False
        '
        'TahapanLabel1
        '
        TahapanLabel1.AutoSize = True
        TahapanLabel1.Location = New System.Drawing.Point(12, 123)
        TahapanLabel1.Name = "TahapanLabel1"
        TahapanLabel1.Size = New System.Drawing.Size(64, 17)
        TahapanLabel1.TabIndex = 275
        TahapanLabel1.Text = "tahapan:"
        '
        'StatusLabel
        '
        StatusLabel.AutoSize = True
        StatusLabel.Location = New System.Drawing.Point(820, 90)
        StatusLabel.Name = "StatusLabel"
        StatusLabel.Size = New System.Drawing.Size(50, 17)
        StatusLabel.TabIndex = 273
        StatusLabel.Text = "status:"
        '
        'RakLabel
        '
        RakLabel.AutoSize = True
        RakLabel.Location = New System.Drawing.Point(820, 62)
        RakLabel.Name = "RakLabel"
        RakLabel.Size = New System.Drawing.Size(32, 17)
        RakLabel.TabIndex = 271
        RakLabel.Text = "rak:"
        '
        'Kode_arsip_fasilitatisLabel
        '
        Kode_arsip_fasilitatisLabel.AutoSize = True
        Kode_arsip_fasilitatisLabel.Location = New System.Drawing.Point(820, 34)
        Kode_arsip_fasilitatisLabel.Name = "Kode_arsip_fasilitatisLabel"
        Kode_arsip_fasilitatisLabel.Size = New System.Drawing.Size(136, 17)
        Kode_arsip_fasilitatisLabel.TabIndex = 268
        Kode_arsip_fasilitatisLabel.Text = "kode arsip fasilitatis:"
        '
        'Kode_arsip_substantifLabel
        '
        Kode_arsip_substantifLabel.AutoSize = True
        Kode_arsip_substantifLabel.Location = New System.Drawing.Point(820, 6)
        Kode_arsip_substantifLabel.Name = "Kode_arsip_substantifLabel"
        Kode_arsip_substantifLabel.Size = New System.Drawing.Size(143, 17)
        Kode_arsip_substantifLabel.TabIndex = 267
        Kode_arsip_substantifLabel.Text = "kode arsip substantif:"
        '
        'Kode_jabatanLabel
        '
        Kode_jabatanLabel.AutoSize = True
        Kode_jabatanLabel.Location = New System.Drawing.Point(12, 235)
        Kode_jabatanLabel.Name = "Kode_jabatanLabel"
        Kode_jabatanLabel.Size = New System.Drawing.Size(94, 17)
        Kode_jabatanLabel.TabIndex = 265
        Kode_jabatanLabel.Text = "kode jabatan:"
        '
        'TahunLabel
        '
        TahunLabel.AutoSize = True
        TahunLabel.Location = New System.Drawing.Point(12, 314)
        TahunLabel.Name = "TahunLabel"
        TahunLabel.Size = New System.Drawing.Size(48, 17)
        TahunLabel.TabIndex = 262
        TahunLabel.Text = "tahun:"
        '
        'BulanLabel
        '
        BulanLabel.AutoSize = True
        BulanLabel.Location = New System.Drawing.Point(12, 287)
        BulanLabel.Name = "BulanLabel"
        BulanLabel.Size = New System.Drawing.Size(47, 17)
        BulanLabel.TabIndex = 260
        BulanLabel.Text = "bulan:"
        '
        'Kode_wilayahLabel
        '
        Kode_wilayahLabel.AutoSize = True
        Kode_wilayahLabel.Location = New System.Drawing.Point(12, 260)
        Kode_wilayahLabel.Name = "Kode_wilayahLabel"
        Kode_wilayahLabel.Size = New System.Drawing.Size(93, 17)
        Kode_wilayahLabel.TabIndex = 258
        Kode_wilayahLabel.Text = "kode wilayah:"
        '
        'Kode_biroLabel
        '
        Kode_biroLabel.AutoSize = True
        Kode_biroLabel.Location = New System.Drawing.Point(12, 203)
        Kode_biroLabel.Name = "Kode_biroLabel"
        Kode_biroLabel.Size = New System.Drawing.Size(71, 17)
        Kode_biroLabel.TabIndex = 257
        Kode_biroLabel.Text = "kode biro:"
        '
        'Kode_naskah_dinasLabel
        '
        Kode_naskah_dinasLabel.AutoSize = True
        Kode_naskah_dinasLabel.Location = New System.Drawing.Point(12, 178)
        Kode_naskah_dinasLabel.Name = "Kode_naskah_dinasLabel"
        Kode_naskah_dinasLabel.Size = New System.Drawing.Size(131, 17)
        Kode_naskah_dinasLabel.TabIndex = 255
        Kode_naskah_dinasLabel.Text = "kode naskah dinas:"
        '
        'TanggalLabel
        '
        TanggalLabel.AutoSize = True
        TanggalLabel.Location = New System.Drawing.Point(12, 9)
        TanggalLabel.Name = "TanggalLabel"
        TanggalLabel.Size = New System.Drawing.Size(59, 17)
        TanggalLabel.TabIndex = 233
        TanggalLabel.Text = "tanggal:"
        '
        'IdLabel
        '
        IdLabel.AutoSize = True
        IdLabel.Location = New System.Drawing.Point(12, 38)
        IdLabel.Name = "IdLabel"
        IdLabel.Size = New System.Drawing.Size(23, 17)
        IdLabel.TabIndex = 235
        IdLabel.Text = "id:"
        '
        'Nama_fileLabel
        '
        Nama_fileLabel.AutoSize = True
        Nama_fileLabel.Location = New System.Drawing.Point(12, 66)
        Nama_fileLabel.Name = "Nama_fileLabel"
        Nama_fileLabel.Size = New System.Drawing.Size(69, 17)
        Nama_fileLabel.TabIndex = 237
        Nama_fileLabel.Text = "nama file:"
        '
        'DivisiLabel
        '
        DivisiLabel.AutoSize = True
        DivisiLabel.Location = New System.Drawing.Point(12, 94)
        DivisiLabel.Name = "DivisiLabel"
        DivisiLabel.Size = New System.Drawing.Size(43, 17)
        DivisiLabel.TabIndex = 239
        DivisiLabel.Text = "divisi:"
        '
        'TahapanLabel
        '
        TahapanLabel.AutoSize = True
        TahapanLabel.Location = New System.Drawing.Point(12, 149)
        TahapanLabel.Name = "TahapanLabel"
        TahapanLabel.Size = New System.Drawing.Size(105, 17)
        TahapanLabel.TabIndex = 240
        TahapanLabel.Text = "jenis pemilihan:"
        '
        'FileLabel
        '
        FileLabel.AutoSize = True
        FileLabel.Location = New System.Drawing.Point(417, 11)
        FileLabel.Name = "FileLabel"
        FileLabel.Size = New System.Drawing.Size(30, 17)
        FileLabel.TabIndex = 241
        FileLabel.Text = "file:"
        '
        'JenisLabel
        '
        JenisLabel.AutoSize = True
        JenisLabel.Location = New System.Drawing.Point(417, 44)
        JenisLabel.Name = "JenisLabel"
        JenisLabel.Size = New System.Drawing.Size(41, 17)
        JenisLabel.TabIndex = 243
        JenisLabel.Text = "jenis:"
        '
        'IntisariLabel
        '
        IntisariLabel.AutoSize = True
        IntisariLabel.Location = New System.Drawing.Point(415, 110)
        IntisariLabel.Name = "IntisariLabel"
        IntisariLabel.Size = New System.Drawing.Size(53, 17)
        IntisariLabel.TabIndex = 244
        IntisariLabel.Text = "intisari:"
        '
        'PutusanLabel
        '
        PutusanLabel.AutoSize = True
        PutusanLabel.Location = New System.Drawing.Point(415, 174)
        PutusanLabel.Name = "PutusanLabel"
        PutusanLabel.Size = New System.Drawing.Size(63, 17)
        PutusanLabel.TabIndex = 245
        PutusanLabel.Text = "putusan:"
        '
        'KronologiLabel
        '
        KronologiLabel.AutoSize = True
        KronologiLabel.Location = New System.Drawing.Point(417, 239)
        KronologiLabel.Name = "KronologiLabel"
        KronologiLabel.Size = New System.Drawing.Size(70, 17)
        KronologiLabel.TabIndex = 246
        KronologiLabel.Text = "kronologi:"
        '
        'KeteranganLabel
        '
        KeteranganLabel.AutoSize = True
        KeteranganLabel.Location = New System.Drawing.Point(417, 72)
        KeteranganLabel.Name = "KeteranganLabel"
        KeteranganLabel.Size = New System.Drawing.Size(84, 17)
        KeteranganLabel.TabIndex = 247
        KeteranganLabel.Text = "keterangan:"
        '
        'AxAcroPDF1
        '
        Me.AxAcroPDF1.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.AxAcroPDF1.Enabled = True
        Me.AxAcroPDF1.Location = New System.Drawing.Point(12, 446)
        Me.AxAcroPDF1.Name = "AxAcroPDF1"
        Me.AxAcroPDF1.OcxState = CType(resources.GetObject("AxAcroPDF1.OcxState"), System.Windows.Forms.AxHost.State)
        Me.AxAcroPDF1.Size = New System.Drawing.Size(847, 267)
        Me.AxAcroPDF1.TabIndex = 77
        '
        'TextBox2
        '
        Me.TextBox2.Location = New System.Drawing.Point(985, 516)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(251, 22)
        Me.TextBox2.TabIndex = 78
        Me.TextBox2.Visible = False
        '
        'Button6
        '
        Me.Button6.Location = New System.Drawing.Point(975, 298)
        Me.Button6.Name = "Button6"
        Me.Button6.Size = New System.Drawing.Size(281, 40)
        Me.Button6.TabIndex = 161
        Me.Button6.Text = "Cari"
        Me.Button6.UseVisualStyleBackColor = True
        '
        'ComboBox1
        '
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Items.AddRange(New Object() {"Nama File", "Jenis File", "Divisi", "Intisari", "Putusan", "Kronologi"})
        Me.ComboBox1.Location = New System.Drawing.Point(972, 198)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(121, 24)
        Me.ComboBox1.TabIndex = 160
        '
        'caridata
        '
        Me.caridata.Location = New System.Drawing.Point(970, 261)
        Me.caridata.Name = "caridata"
        Me.caridata.Size = New System.Drawing.Size(286, 22)
        Me.caridata.TabIndex = 135
        '
        'JumlahTextBox
        '
        Me.JumlahTextBox.Location = New System.Drawing.Point(1095, 618)
        Me.JumlahTextBox.Name = "JumlahTextBox"
        Me.JumlahTextBox.Size = New System.Drawing.Size(100, 22)
        Me.JumlahTextBox.TabIndex = 184
        Me.JumlahTextBox.Visible = False
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(913, 581)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(176, 22)
        Me.TextBox1.TabIndex = 186
        Me.TextBox1.Visible = False
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'TahapanTextBox
        '
        Me.TahapanTextBox.FormattingEnabled = True
        Me.TahapanTextBox.Location = New System.Drawing.Point(118, 117)
        Me.TahapanTextBox.Name = "TahapanTextBox"
        Me.TahapanTextBox.Size = New System.Drawing.Size(283, 24)
        Me.TahapanTextBox.TabIndex = 276
        '
        'StatusTextBox
        '
        Me.StatusTextBox.Enabled = False
        Me.StatusTextBox.Location = New System.Drawing.Point(969, 87)
        Me.StatusTextBox.Name = "StatusTextBox"
        Me.StatusTextBox.Size = New System.Drawing.Size(100, 22)
        Me.StatusTextBox.TabIndex = 274
        Me.StatusTextBox.Text = "0"
        '
        'RakTextBox
        '
        Me.RakTextBox.Location = New System.Drawing.Point(969, 59)
        Me.RakTextBox.Name = "RakTextBox"
        Me.RakTextBox.Size = New System.Drawing.Size(176, 22)
        Me.RakTextBox.TabIndex = 272
        '
        'Kode_arsip_fasilitatisTextBox
        '
        Me.Kode_arsip_fasilitatisTextBox.Location = New System.Drawing.Point(969, 31)
        Me.Kode_arsip_fasilitatisTextBox.Name = "Kode_arsip_fasilitatisTextBox"
        Me.Kode_arsip_fasilitatisTextBox.Size = New System.Drawing.Size(176, 22)
        Me.Kode_arsip_fasilitatisTextBox.TabIndex = 270
        '
        'Kode_arsip_substantifTextBox
        '
        Me.Kode_arsip_substantifTextBox.Location = New System.Drawing.Point(969, 3)
        Me.Kode_arsip_substantifTextBox.Name = "Kode_arsip_substantifTextBox"
        Me.Kode_arsip_substantifTextBox.Size = New System.Drawing.Size(176, 22)
        Me.Kode_arsip_substantifTextBox.TabIndex = 269
        '
        'Kode_jabatanTextBox
        '
        Me.Kode_jabatanTextBox.Location = New System.Drawing.Point(157, 230)
        Me.Kode_jabatanTextBox.Name = "Kode_jabatanTextBox"
        Me.Kode_jabatanTextBox.Size = New System.Drawing.Size(244, 22)
        Me.Kode_jabatanTextBox.TabIndex = 266
        '
        'BulanTextBox
        '
        Me.BulanTextBox.FormattingEnabled = True
        Me.BulanTextBox.Items.AddRange(New Object() {"JANUARI", "FEBRUARI", "MARET", "APRIL", "MEI", "JUNI", "JULI", "AGUSTUS", "SEPTEMBER", "OKTOBER", "NOVEMBER", "DESEMBER"})
        Me.BulanTextBox.Location = New System.Drawing.Point(157, 283)
        Me.BulanTextBox.Name = "BulanTextBox"
        Me.BulanTextBox.Size = New System.Drawing.Size(121, 24)
        Me.BulanTextBox.TabIndex = 264
        '
        'TahunTextBox
        '
        Me.TahunTextBox.Location = New System.Drawing.Point(157, 311)
        Me.TahunTextBox.Name = "TahunTextBox"
        Me.TahunTextBox.Size = New System.Drawing.Size(244, 22)
        Me.TahunTextBox.TabIndex = 263
        '
        'Kode_wilayahTextBox
        '
        Me.Kode_wilayahTextBox.Location = New System.Drawing.Point(157, 257)
        Me.Kode_wilayahTextBox.Name = "Kode_wilayahTextBox"
        Me.Kode_wilayahTextBox.Size = New System.Drawing.Size(244, 22)
        Me.Kode_wilayahTextBox.TabIndex = 261
        '
        'Kode_biroTextBox
        '
        Me.Kode_biroTextBox.Location = New System.Drawing.Point(157, 203)
        Me.Kode_biroTextBox.Name = "Kode_biroTextBox"
        Me.Kode_biroTextBox.Size = New System.Drawing.Size(244, 22)
        Me.Kode_biroTextBox.TabIndex = 259
        '
        'Kode_naskah_dinasTextBox
        '
        Me.Kode_naskah_dinasTextBox.Location = New System.Drawing.Point(157, 175)
        Me.Kode_naskah_dinasTextBox.Name = "Kode_naskah_dinasTextBox"
        Me.Kode_naskah_dinasTextBox.Size = New System.Drawing.Size(244, 22)
        Me.Kode_naskah_dinasTextBox.TabIndex = 256
        '
        'Jenis_pemilihanTextBox
        '
        Me.Jenis_pemilihanTextBox.FormattingEnabled = True
        Me.Jenis_pemilihanTextBox.Location = New System.Drawing.Point(118, 145)
        Me.Jenis_pemilihanTextBox.Name = "Jenis_pemilihanTextBox"
        Me.Jenis_pemilihanTextBox.Size = New System.Drawing.Size(283, 24)
        Me.Jenis_pemilihanTextBox.TabIndex = 254
        '
        'KeteranganTextBox
        '
        Me.KeteranganTextBox.FormattingEnabled = True
        Me.KeteranganTextBox.Items.AddRange(New Object() {"Umum", "Internal"})
        Me.KeteranganTextBox.Location = New System.Drawing.Point(523, 71)
        Me.KeteranganTextBox.Name = "KeteranganTextBox"
        Me.KeteranganTextBox.Size = New System.Drawing.Size(262, 24)
        Me.KeteranganTextBox.TabIndex = 253
        '
        'JenisTextBox
        '
        Me.JenisTextBox.FormattingEnabled = True
        Me.JenisTextBox.Items.AddRange(New Object() {"Surat", "Surat Edaran", "Surat Keputusan", "Berita Acara"})
        Me.JenisTextBox.Location = New System.Drawing.Point(523, 41)
        Me.JenisTextBox.Name = "JenisTextBox"
        Me.JenisTextBox.Size = New System.Drawing.Size(262, 24)
        Me.JenisTextBox.TabIndex = 252
        '
        'DivisiTextBox
        '
        Me.DivisiTextBox.FormattingEnabled = True
        Me.DivisiTextBox.Location = New System.Drawing.Point(118, 89)
        Me.DivisiTextBox.Name = "DivisiTextBox"
        Me.DivisiTextBox.Size = New System.Drawing.Size(283, 24)
        Me.DivisiTextBox.TabIndex = 251
        '
        'KronologiTextBox
        '
        Me.KronologiTextBox.Location = New System.Drawing.Point(493, 239)
        Me.KronologiTextBox.Name = "KronologiTextBox"
        Me.KronologiTextBox.Size = New System.Drawing.Size(292, 56)
        Me.KronologiTextBox.TabIndex = 250
        Me.KronologiTextBox.Text = ""
        '
        'PutusanTextBox
        '
        Me.PutusanTextBox.Location = New System.Drawing.Point(493, 174)
        Me.PutusanTextBox.Name = "PutusanTextBox"
        Me.PutusanTextBox.Size = New System.Drawing.Size(292, 56)
        Me.PutusanTextBox.TabIndex = 249
        Me.PutusanTextBox.Text = ""
        '
        'IntisariTextBox
        '
        Me.IntisariTextBox.Location = New System.Drawing.Point(493, 110)
        Me.IntisariTextBox.Name = "IntisariTextBox"
        Me.IntisariTextBox.Size = New System.Drawing.Size(292, 56)
        Me.IntisariTextBox.TabIndex = 248
        Me.IntisariTextBox.Text = ""
        '
        'TanggalDateTimePicker
        '
        Me.TanggalDateTimePicker.Enabled = False
        Me.TanggalDateTimePicker.Location = New System.Drawing.Point(118, 6)
        Me.TanggalDateTimePicker.Name = "TanggalDateTimePicker"
        Me.TanggalDateTimePicker.Size = New System.Drawing.Size(200, 22)
        Me.TanggalDateTimePicker.TabIndex = 234
        '
        'IdTextBox
        '
        Me.IdTextBox.Enabled = False
        Me.IdTextBox.Location = New System.Drawing.Point(118, 34)
        Me.IdTextBox.Name = "IdTextBox"
        Me.IdTextBox.Size = New System.Drawing.Size(283, 22)
        Me.IdTextBox.TabIndex = 236
        '
        'Nama_fileTextBox
        '
        Me.Nama_fileTextBox.Location = New System.Drawing.Point(118, 62)
        Me.Nama_fileTextBox.Name = "Nama_fileTextBox"
        Me.Nama_fileTextBox.Size = New System.Drawing.Size(283, 22)
        Me.Nama_fileTextBox.TabIndex = 238
        '
        'FileTextBox
        '
        Me.FileTextBox.Enabled = False
        Me.FileTextBox.Location = New System.Drawing.Point(523, 7)
        Me.FileTextBox.Name = "FileTextBox"
        Me.FileTextBox.Size = New System.Drawing.Size(179, 22)
        Me.FileTextBox.TabIndex = 242
        '
        'Button4
        '
        Me.Button4.Location = New System.Drawing.Point(709, 6)
        Me.Button4.Margin = New System.Windows.Forms.Padding(4)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(76, 27)
        Me.Button4.TabIndex = 232
        Me.Button4.Text = "Pilih File"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'DataGridView1
        '
        Me.DataGridView1.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(12, 344)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.RowTemplate.Height = 24
        Me.DataGridView1.Size = New System.Drawing.Size(1244, 194)
        Me.DataGridView1.TabIndex = 277
        '
        'b_ubah
        '
        Me.b_ubah.Location = New System.Drawing.Point(817, 215)
        Me.b_ubah.Margin = New System.Windows.Forms.Padding(4)
        Me.b_ubah.Name = "b_ubah"
        Me.b_ubah.Size = New System.Drawing.Size(139, 35)
        Me.b_ubah.TabIndex = 281
        Me.b_ubah.Text = "Ubah"
        Me.b_ubah.UseVisualStyleBackColor = True
        '
        'b_hapus
        '
        Me.b_hapus.Location = New System.Drawing.Point(817, 256)
        Me.b_hapus.Margin = New System.Windows.Forms.Padding(4)
        Me.b_hapus.Name = "b_hapus"
        Me.b_hapus.Size = New System.Drawing.Size(139, 35)
        Me.b_hapus.TabIndex = 280
        Me.b_hapus.Text = "hapus"
        Me.b_hapus.UseVisualStyleBackColor = True
        '
        'b_simpan
        '
        Me.b_simpan.Location = New System.Drawing.Point(817, 174)
        Me.b_simpan.Margin = New System.Windows.Forms.Padding(4)
        Me.b_simpan.Name = "b_simpan"
        Me.b_simpan.Size = New System.Drawing.Size(139, 35)
        Me.b_simpan.TabIndex = 279
        Me.b_simpan.Text = "Simpan"
        Me.b_simpan.UseVisualStyleBackColor = True
        '
        'b_databaru
        '
        Me.b_databaru.Location = New System.Drawing.Point(817, 131)
        Me.b_databaru.Margin = New System.Windows.Forms.Padding(4)
        Me.b_databaru.Name = "b_databaru"
        Me.b_databaru.Size = New System.Drawing.Size(139, 35)
        Me.b_databaru.TabIndex = 278
        Me.b_databaru.Text = "Data Baru"
        Me.b_databaru.UseVisualStyleBackColor = True
        '
        'F_pengguna_file
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.arsip_digital.My.Resources.Resources._6e8ec8f0_b5ea_4454_8266_48e3aacbc59c
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1273, 797)
        Me.Controls.Add(Me.b_ubah)
        Me.Controls.Add(Me.b_hapus)
        Me.Controls.Add(Me.b_simpan)
        Me.Controls.Add(Me.b_databaru)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.TahapanTextBox)
        Me.Controls.Add(TahapanLabel1)
        Me.Controls.Add(StatusLabel)
        Me.Controls.Add(Me.StatusTextBox)
        Me.Controls.Add(RakLabel)
        Me.Controls.Add(Me.RakTextBox)
        Me.Controls.Add(Kode_arsip_fasilitatisLabel)
        Me.Controls.Add(Me.Kode_arsip_fasilitatisTextBox)
        Me.Controls.Add(Kode_arsip_substantifLabel)
        Me.Controls.Add(Me.Kode_arsip_substantifTextBox)
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
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(JumlahLabel)
        Me.Controls.Add(Me.JumlahTextBox)
        Me.Controls.Add(Label2)
        Me.Controls.Add(Me.Button6)
        Me.Controls.Add(Me.ComboBox1)
        Me.Controls.Add(Label1)
        Me.Controls.Add(Me.caridata)
        Me.Controls.Add(Me.AxAcroPDF1)
        Me.Controls.Add(Me.TextBox2)
        Me.Name = "F_pengguna_file"
        Me.Text = "APLIKASI ARSIP DIGITAL KPU KOTA SUKABUMI"
        CType(Me.AxAcroPDF1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents AxAcroPDF1 As AxAcroPDFLib.AxAcroPDF
    Friend WithEvents TextBox2 As System.Windows.Forms.TextBox
    Friend WithEvents Button6 As System.Windows.Forms.Button
    Friend WithEvents ComboBox1 As System.Windows.Forms.ComboBox
    Friend WithEvents caridata As System.Windows.Forms.TextBox
    Friend WithEvents JumlahTextBox As System.Windows.Forms.TextBox
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents OpenFileDialog1 As System.Windows.Forms.OpenFileDialog
    Friend WithEvents TahapanTextBox As System.Windows.Forms.ComboBox
    Friend WithEvents StatusTextBox As System.Windows.Forms.TextBox
    Friend WithEvents RakTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Kode_arsip_fasilitatisTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Kode_arsip_substantifTextBox As System.Windows.Forms.TextBox
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
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents b_ubah As System.Windows.Forms.Button
    Friend WithEvents b_hapus As System.Windows.Forms.Button
    Friend WithEvents b_simpan As System.Windows.Forms.Button
    Friend WithEvents b_databaru As System.Windows.Forms.Button
End Class
