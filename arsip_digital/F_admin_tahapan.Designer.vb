<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class F_admin_tahapan
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
        Dim Label1 As System.Windows.Forms.Label
        Dim IdLabel1 As System.Windows.Forms.Label
        Dim TahapanLabel As System.Windows.Forms.Label
        Dim JumlahLabel As System.Windows.Forms.Label
        Dim DivisiLabel As System.Windows.Forms.Label
        Me.b_ubah = New System.Windows.Forms.Button()
        Me.b_hapus = New System.Windows.Forms.Button()
        Me.b_simpan = New System.Windows.Forms.Button()
        Me.b_databaru = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.IdTextBox = New System.Windows.Forms.TextBox()
        Me.TahapanTextBox = New System.Windows.Forms.TextBox()
        Me.JumlahTextBox = New System.Windows.Forms.TextBox()
        Me.DivisiTextBox = New System.Windows.Forms.TextBox()
        Label1 = New System.Windows.Forms.Label()
        IdLabel1 = New System.Windows.Forms.Label()
        TahapanLabel = New System.Windows.Forms.Label()
        JumlahLabel = New System.Windows.Forms.Label()
        DivisiLabel = New System.Windows.Forms.Label()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Label1.AutoSize = True
        Label1.BackColor = System.Drawing.SystemColors.Control
        Label1.Location = New System.Drawing.Point(671, 27)
        Label1.Name = "Label1"
        Label1.Size = New System.Drawing.Size(71, 17)
        Label1.TabIndex = 76
        Label1.Text = "Cari Data:"
        '
        'IdLabel1
        '
        IdLabel1.AutoSize = True
        IdLabel1.Location = New System.Drawing.Point(24, 30)
        IdLabel1.Name = "IdLabel1"
        IdLabel1.Size = New System.Drawing.Size(23, 17)
        IdLabel1.TabIndex = 78
        IdLabel1.Text = "id:"
        '
        'TahapanLabel
        '
        TahapanLabel.AutoSize = True
        TahapanLabel.Location = New System.Drawing.Point(24, 90)
        TahapanLabel.Name = "TahapanLabel"
        TahapanLabel.Size = New System.Drawing.Size(64, 17)
        TahapanLabel.TabIndex = 80
        TahapanLabel.Text = "tahapan:"
        '
        'JumlahLabel
        '
        JumlahLabel.AutoSize = True
        JumlahLabel.Location = New System.Drawing.Point(64, 336)
        JumlahLabel.Name = "JumlahLabel"
        JumlahLabel.Size = New System.Drawing.Size(53, 17)
        JumlahLabel.TabIndex = 84
        JumlahLabel.Text = "jumlah:"
        '
        'DivisiLabel
        '
        DivisiLabel.AutoSize = True
        DivisiLabel.Location = New System.Drawing.Point(24, 57)
        DivisiLabel.Name = "DivisiLabel"
        DivisiLabel.Size = New System.Drawing.Size(43, 17)
        DivisiLabel.TabIndex = 86
        DivisiLabel.Text = "divisi:"
        '
        'b_ubah
        '
        Me.b_ubah.Location = New System.Drawing.Point(321, 116)
        Me.b_ubah.Margin = New System.Windows.Forms.Padding(4)
        Me.b_ubah.Name = "b_ubah"
        Me.b_ubah.Size = New System.Drawing.Size(139, 33)
        Me.b_ubah.TabIndex = 69
        Me.b_ubah.Text = "Ubah"
        Me.b_ubah.UseVisualStyleBackColor = True
        '
        'b_hapus
        '
        Me.b_hapus.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.b_hapus.Location = New System.Drawing.Point(468, 116)
        Me.b_hapus.Margin = New System.Windows.Forms.Padding(4)
        Me.b_hapus.Name = "b_hapus"
        Me.b_hapus.Size = New System.Drawing.Size(139, 33)
        Me.b_hapus.TabIndex = 68
        Me.b_hapus.Text = "hapus"
        Me.b_hapus.UseVisualStyleBackColor = True
        '
        'b_simpan
        '
        Me.b_simpan.Location = New System.Drawing.Point(174, 116)
        Me.b_simpan.Margin = New System.Windows.Forms.Padding(4)
        Me.b_simpan.Name = "b_simpan"
        Me.b_simpan.Size = New System.Drawing.Size(139, 33)
        Me.b_simpan.TabIndex = 67
        Me.b_simpan.Text = "Simpan"
        Me.b_simpan.UseVisualStyleBackColor = True
        '
        'b_databaru
        '
        Me.b_databaru.Location = New System.Drawing.Point(27, 116)
        Me.b_databaru.Margin = New System.Windows.Forms.Padding(4)
        Me.b_databaru.Name = "b_databaru"
        Me.b_databaru.Size = New System.Drawing.Size(139, 33)
        Me.b_databaru.TabIndex = 66
        Me.b_databaru.Text = "Data Baru"
        Me.b_databaru.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(669, 90)
        Me.Button1.Margin = New System.Windows.Forms.Padding(4)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(286, 33)
        Me.Button1.TabIndex = 73
        Me.Button1.Text = "Tahapan"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(669, 54)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(286, 22)
        Me.TextBox1.TabIndex = 72
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(15, 156)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.RowTemplate.Height = 24
        Me.DataGridView1.Size = New System.Drawing.Size(946, 516)
        Me.DataGridView1.TabIndex = 77
        '
        'IdTextBox
        '
        Me.IdTextBox.Enabled = False
        Me.IdTextBox.Location = New System.Drawing.Point(121, 27)
        Me.IdTextBox.Name = "IdTextBox"
        Me.IdTextBox.Size = New System.Drawing.Size(474, 22)
        Me.IdTextBox.TabIndex = 79
        '
        'TahapanTextBox
        '
        Me.TahapanTextBox.Location = New System.Drawing.Point(121, 87)
        Me.TahapanTextBox.Name = "TahapanTextBox"
        Me.TahapanTextBox.Size = New System.Drawing.Size(474, 22)
        Me.TahapanTextBox.TabIndex = 81
        '
        'JumlahTextBox
        '
        Me.JumlahTextBox.Enabled = False
        Me.JumlahTextBox.Location = New System.Drawing.Point(161, 333)
        Me.JumlahTextBox.Name = "JumlahTextBox"
        Me.JumlahTextBox.Size = New System.Drawing.Size(364, 22)
        Me.JumlahTextBox.TabIndex = 85
        '
        'DivisiTextBox
        '
        Me.DivisiTextBox.Location = New System.Drawing.Point(121, 55)
        Me.DivisiTextBox.Name = "DivisiTextBox"
        Me.DivisiTextBox.Size = New System.Drawing.Size(474, 22)
        Me.DivisiTextBox.TabIndex = 87
        '
        'F_admin_tahapan
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.arsip_digital.My.Resources.Resources._6e8ec8f0_b5ea_4454_8266_48e3aacbc59c
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(978, 684)
        Me.Controls.Add(DivisiLabel)
        Me.Controls.Add(Me.DivisiTextBox)
        Me.Controls.Add(IdLabel1)
        Me.Controls.Add(Me.IdTextBox)
        Me.Controls.Add(TahapanLabel)
        Me.Controls.Add(Me.TahapanTextBox)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Label1)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.b_ubah)
        Me.Controls.Add(Me.b_hapus)
        Me.Controls.Add(Me.b_simpan)
        Me.Controls.Add(Me.b_databaru)
        Me.Controls.Add(JumlahLabel)
        Me.Controls.Add(Me.JumlahTextBox)
        Me.Name = "F_admin_tahapan"
        Me.Text = "APLIKASI ARSIP DIGITAL KPU KOTA SUKABUMI"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents b_ubah As System.Windows.Forms.Button
    Friend WithEvents b_hapus As System.Windows.Forms.Button
    Friend WithEvents b_simpan As System.Windows.Forms.Button
    Friend WithEvents b_databaru As System.Windows.Forms.Button
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents IdTextBox As System.Windows.Forms.TextBox
    Friend WithEvents TahapanTextBox As System.Windows.Forms.TextBox
    Friend WithEvents JumlahTextBox As System.Windows.Forms.TextBox
    Friend WithEvents DivisiTextBox As System.Windows.Forms.TextBox
End Class
