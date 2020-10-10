<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class F_pengunjung_absen
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
        Dim TanggalLabel As System.Windows.Forms.Label
        Dim IdLabel As System.Windows.Forms.Label
        Dim NamaLabel As System.Windows.Forms.Label
        Dim Jenis_kelaminLabel As System.Windows.Forms.Label
        Dim UmurLabel As System.Windows.Forms.Label
        Dim BasisLabel As System.Windows.Forms.Label
        Dim JumlahLabel As System.Windows.Forms.Label
        Dim Label1 As System.Windows.Forms.Label
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.TanggalDateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.IdTextBox = New System.Windows.Forms.TextBox()
        Me.NamaTextBox = New System.Windows.Forms.TextBox()
        Me.UmurTextBox = New System.Windows.Forms.TextBox()
        Me.JumlahTextBox = New System.Windows.Forms.TextBox()
        Me.BasisTextBox = New System.Windows.Forms.ComboBox()
        Me.Jenis_kelaminTextBox = New System.Windows.Forms.ComboBox()
        TanggalLabel = New System.Windows.Forms.Label()
        IdLabel = New System.Windows.Forms.Label()
        NamaLabel = New System.Windows.Forms.Label()
        Jenis_kelaminLabel = New System.Windows.Forms.Label()
        UmurLabel = New System.Windows.Forms.Label()
        BasisLabel = New System.Windows.Forms.Label()
        JumlahLabel = New System.Windows.Forms.Label()
        Label1 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'TanggalLabel
        '
        TanggalLabel.AutoSize = True
        TanggalLabel.Location = New System.Drawing.Point(47, 41)
        TanggalLabel.Name = "TanggalLabel"
        TanggalLabel.Size = New System.Drawing.Size(59, 17)
        TanggalLabel.TabIndex = 19
        TanggalLabel.Text = "tanggal:"
        '
        'IdLabel
        '
        IdLabel.AutoSize = True
        IdLabel.Location = New System.Drawing.Point(47, 68)
        IdLabel.Name = "IdLabel"
        IdLabel.Size = New System.Drawing.Size(23, 17)
        IdLabel.TabIndex = 21
        IdLabel.Text = "id:"
        '
        'NamaLabel
        '
        NamaLabel.AutoSize = True
        NamaLabel.Location = New System.Drawing.Point(47, 96)
        NamaLabel.Name = "NamaLabel"
        NamaLabel.Size = New System.Drawing.Size(47, 17)
        NamaLabel.TabIndex = 23
        NamaLabel.Text = "nama:"
        '
        'Jenis_kelaminLabel
        '
        Jenis_kelaminLabel.AutoSize = True
        Jenis_kelaminLabel.Location = New System.Drawing.Point(47, 124)
        Jenis_kelaminLabel.Name = "Jenis_kelaminLabel"
        Jenis_kelaminLabel.Size = New System.Drawing.Size(93, 17)
        Jenis_kelaminLabel.TabIndex = 25
        Jenis_kelaminLabel.Text = "jenis kelamin:"
        '
        'UmurLabel
        '
        UmurLabel.AutoSize = True
        UmurLabel.Location = New System.Drawing.Point(47, 152)
        UmurLabel.Name = "UmurLabel"
        UmurLabel.Size = New System.Drawing.Size(44, 17)
        UmurLabel.TabIndex = 27
        UmurLabel.Text = "umur:"
        '
        'BasisLabel
        '
        BasisLabel.AutoSize = True
        BasisLabel.Location = New System.Drawing.Point(47, 180)
        BasisLabel.Name = "BasisLabel"
        BasisLabel.Size = New System.Drawing.Size(45, 17)
        BasisLabel.TabIndex = 29
        BasisLabel.Text = "basis:"
        '
        'JumlahLabel
        '
        JumlahLabel.AutoSize = True
        JumlahLabel.Location = New System.Drawing.Point(47, 208)
        JumlahLabel.Name = "JumlahLabel"
        JumlahLabel.Size = New System.Drawing.Size(53, 17)
        JumlahLabel.TabIndex = 31
        JumlahLabel.Text = "jumlah:"
        JumlahLabel.Visible = False
        '
        'Label1
        '
        Label1.AutoSize = True
        Label1.Location = New System.Drawing.Point(270, 152)
        Label1.Name = "Label1"
        Label1.Size = New System.Drawing.Size(44, 17)
        Label1.TabIndex = 35
        Label1.Text = "tahun"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(78, 279)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(151, 84)
        Me.Button1.TabIndex = 15
        Me.Button1.Text = "Masuk"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(282, 279)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(151, 84)
        Me.Button2.TabIndex = 18
        Me.Button2.Text = "Batal"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'TanggalDateTimePicker
        '
        Me.TanggalDateTimePicker.Location = New System.Drawing.Point(146, 37)
        Me.TanggalDateTimePicker.Name = "TanggalDateTimePicker"
        Me.TanggalDateTimePicker.Size = New System.Drawing.Size(200, 22)
        Me.TanggalDateTimePicker.TabIndex = 20
        '
        'IdTextBox
        '
        Me.IdTextBox.Enabled = False
        Me.IdTextBox.Location = New System.Drawing.Point(146, 65)
        Me.IdTextBox.Name = "IdTextBox"
        Me.IdTextBox.Size = New System.Drawing.Size(200, 22)
        Me.IdTextBox.TabIndex = 22
        '
        'NamaTextBox
        '
        Me.NamaTextBox.Location = New System.Drawing.Point(146, 93)
        Me.NamaTextBox.Name = "NamaTextBox"
        Me.NamaTextBox.Size = New System.Drawing.Size(200, 22)
        Me.NamaTextBox.TabIndex = 24
        '
        'UmurTextBox
        '
        Me.UmurTextBox.Location = New System.Drawing.Point(146, 149)
        Me.UmurTextBox.Name = "UmurTextBox"
        Me.UmurTextBox.Size = New System.Drawing.Size(109, 22)
        Me.UmurTextBox.TabIndex = 28
        '
        'JumlahTextBox
        '
        Me.JumlahTextBox.Location = New System.Drawing.Point(146, 205)
        Me.JumlahTextBox.Name = "JumlahTextBox"
        Me.JumlahTextBox.Size = New System.Drawing.Size(200, 22)
        Me.JumlahTextBox.TabIndex = 32
        Me.JumlahTextBox.Text = "1"
        Me.JumlahTextBox.Visible = False
        '
        'BasisTextBox
        '
        Me.BasisTextBox.FormattingEnabled = True
        Me.BasisTextBox.Items.AddRange(New Object() {"Umum", "Pelajar", "Mahasiswa", "Instansi/Organisasi"})
        Me.BasisTextBox.Location = New System.Drawing.Point(146, 176)
        Me.BasisTextBox.Name = "BasisTextBox"
        Me.BasisTextBox.Size = New System.Drawing.Size(200, 24)
        Me.BasisTextBox.TabIndex = 33
        '
        'Jenis_kelaminTextBox
        '
        Me.Jenis_kelaminTextBox.FormattingEnabled = True
        Me.Jenis_kelaminTextBox.Items.AddRange(New Object() {"Laki-laki", "Perempuan"})
        Me.Jenis_kelaminTextBox.Location = New System.Drawing.Point(146, 119)
        Me.Jenis_kelaminTextBox.Name = "Jenis_kelaminTextBox"
        Me.Jenis_kelaminTextBox.Size = New System.Drawing.Size(200, 24)
        Me.Jenis_kelaminTextBox.TabIndex = 34
        '
        'F_pengunjung_absen
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.arsip_digital.My.Resources.Resources._6e8ec8f0_b5ea_4454_8266_48e3aacbc59c
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(520, 424)
        Me.Controls.Add(Label1)
        Me.Controls.Add(Me.Jenis_kelaminTextBox)
        Me.Controls.Add(Me.BasisTextBox)
        Me.Controls.Add(TanggalLabel)
        Me.Controls.Add(Me.TanggalDateTimePicker)
        Me.Controls.Add(IdLabel)
        Me.Controls.Add(Me.IdTextBox)
        Me.Controls.Add(NamaLabel)
        Me.Controls.Add(Me.NamaTextBox)
        Me.Controls.Add(Jenis_kelaminLabel)
        Me.Controls.Add(UmurLabel)
        Me.Controls.Add(Me.UmurTextBox)
        Me.Controls.Add(BasisLabel)
        Me.Controls.Add(JumlahLabel)
        Me.Controls.Add(Me.JumlahTextBox)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Name = "F_pengunjung_absen"
        Me.Text = "APLIKASI ARSIP DIGITAL KPU KOTA SUKABUMI"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents TanggalDateTimePicker As System.Windows.Forms.DateTimePicker
    Friend WithEvents IdTextBox As System.Windows.Forms.TextBox
    Friend WithEvents NamaTextBox As System.Windows.Forms.TextBox
    Friend WithEvents UmurTextBox As System.Windows.Forms.TextBox
    Friend WithEvents JumlahTextBox As System.Windows.Forms.TextBox
    Friend WithEvents BasisTextBox As System.Windows.Forms.ComboBox
    Friend WithEvents Jenis_kelaminTextBox As System.Windows.Forms.ComboBox
End Class
