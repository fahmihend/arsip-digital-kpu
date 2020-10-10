<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class F_admin_konfirmasi
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
        Dim LevelLabel As System.Windows.Forms.Label
        Dim Label1 As System.Windows.Forms.Label
        Dim DateLabel As System.Windows.Forms.Label
        Dim IdLabel As System.Windows.Forms.Label
        Dim UsernameLabel As System.Windows.Forms.Label
        Dim PasswordLabel As System.Windows.Forms.Label
        Me.LevelTextbox = New System.Windows.Forms.ComboBox()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.b_hapus = New System.Windows.Forms.Button()
        Me.b_simpan = New System.Windows.Forms.Button()
        Me.b_databaru = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.DateDateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.IdTextBox = New System.Windows.Forms.TextBox()
        Me.UsernameTextBox = New System.Windows.Forms.TextBox()
        Me.PasswordTextBox = New System.Windows.Forms.TextBox()
        LevelLabel = New System.Windows.Forms.Label()
        Label1 = New System.Windows.Forms.Label()
        DateLabel = New System.Windows.Forms.Label()
        IdLabel = New System.Windows.Forms.Label()
        UsernameLabel = New System.Windows.Forms.Label()
        PasswordLabel = New System.Windows.Forms.Label()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'LevelLabel
        '
        LevelLabel.AutoSize = True
        LevelLabel.Location = New System.Drawing.Point(33, 151)
        LevelLabel.Name = "LevelLabel"
        LevelLabel.Size = New System.Drawing.Size(41, 17)
        LevelLabel.TabIndex = 5
        LevelLabel.Text = "level:"
        '
        'Label1
        '
        Label1.AutoSize = True
        Label1.Location = New System.Drawing.Point(631, 38)
        Label1.Name = "Label1"
        Label1.Size = New System.Drawing.Size(71, 17)
        Label1.TabIndex = 76
        Label1.Text = "Cari Data:"
        '
        'DateLabel
        '
        DateLabel.AutoSize = True
        DateLabel.Location = New System.Drawing.Point(33, 40)
        DateLabel.Name = "DateLabel"
        DateLabel.Size = New System.Drawing.Size(40, 17)
        DateLabel.TabIndex = 77
        DateLabel.Text = "date:"
        '
        'IdLabel
        '
        IdLabel.AutoSize = True
        IdLabel.Location = New System.Drawing.Point(33, 67)
        IdLabel.Name = "IdLabel"
        IdLabel.Size = New System.Drawing.Size(23, 17)
        IdLabel.TabIndex = 79
        IdLabel.Text = "id:"
        '
        'UsernameLabel
        '
        UsernameLabel.AutoSize = True
        UsernameLabel.Location = New System.Drawing.Point(33, 95)
        UsernameLabel.Name = "UsernameLabel"
        UsernameLabel.Size = New System.Drawing.Size(75, 17)
        UsernameLabel.TabIndex = 81
        UsernameLabel.Text = "username:"
        '
        'PasswordLabel
        '
        PasswordLabel.AutoSize = True
        PasswordLabel.Location = New System.Drawing.Point(33, 123)
        PasswordLabel.Name = "PasswordLabel"
        PasswordLabel.Size = New System.Drawing.Size(72, 17)
        PasswordLabel.TabIndex = 83
        PasswordLabel.Text = "password:"
        '
        'LevelTextbox
        '
        Me.LevelTextbox.FormattingEnabled = True
        Me.LevelTextbox.Items.AddRange(New Object() {"Admin", "Program Data", "Teknis", "Umum", "SDM & Parmas", "Hukum", "Pengguna Umum"})
        Me.LevelTextbox.Location = New System.Drawing.Point(114, 151)
        Me.LevelTextbox.Name = "LevelTextbox"
        Me.LevelTextbox.Size = New System.Drawing.Size(121, 24)
        Me.LevelTextbox.TabIndex = 6
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(13, 201)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.RowTemplate.Height = 24
        Me.DataGridView1.Size = New System.Drawing.Size(902, 434)
        Me.DataGridView1.TabIndex = 7
        '
        'b_hapus
        '
        Me.b_hapus.Location = New System.Drawing.Point(448, 106)
        Me.b_hapus.Margin = New System.Windows.Forms.Padding(4)
        Me.b_hapus.Name = "b_hapus"
        Me.b_hapus.Size = New System.Drawing.Size(139, 33)
        Me.b_hapus.TabIndex = 64
        Me.b_hapus.Text = "hapus"
        Me.b_hapus.UseVisualStyleBackColor = True
        '
        'b_simpan
        '
        Me.b_simpan.Location = New System.Drawing.Point(448, 65)
        Me.b_simpan.Margin = New System.Windows.Forms.Padding(4)
        Me.b_simpan.Name = "b_simpan"
        Me.b_simpan.Size = New System.Drawing.Size(139, 33)
        Me.b_simpan.TabIndex = 63
        Me.b_simpan.Text = "Simpan"
        Me.b_simpan.UseVisualStyleBackColor = True
        '
        'b_databaru
        '
        Me.b_databaru.Location = New System.Drawing.Point(448, 23)
        Me.b_databaru.Margin = New System.Windows.Forms.Padding(4)
        Me.b_databaru.Name = "b_databaru"
        Me.b_databaru.Size = New System.Drawing.Size(139, 33)
        Me.b_databaru.TabIndex = 62
        Me.b_databaru.Text = "Data Baru"
        Me.b_databaru.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(714, 142)
        Me.Button3.Margin = New System.Windows.Forms.Padding(4)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(139, 33)
        Me.Button3.TabIndex = 75
        Me.Button3.Text = "Jenis"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(776, 101)
        Me.Button2.Margin = New System.Windows.Forms.Padding(4)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(139, 33)
        Me.Button2.TabIndex = 74
        Me.Button2.Text = "Divisi"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(629, 101)
        Me.Button1.Margin = New System.Windows.Forms.Padding(4)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(139, 33)
        Me.Button1.TabIndex = 73
        Me.Button1.Text = "Nama File"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(629, 65)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(286, 22)
        Me.TextBox1.TabIndex = 72
        '
        'DateDateTimePicker
        '
        Me.DateDateTimePicker.Enabled = False
        Me.DateDateTimePicker.Location = New System.Drawing.Point(114, 36)
        Me.DateDateTimePicker.Name = "DateDateTimePicker"
        Me.DateDateTimePicker.Size = New System.Drawing.Size(200, 22)
        Me.DateDateTimePicker.TabIndex = 78
        '
        'IdTextBox
        '
        Me.IdTextBox.Enabled = False
        Me.IdTextBox.Location = New System.Drawing.Point(114, 64)
        Me.IdTextBox.Name = "IdTextBox"
        Me.IdTextBox.Size = New System.Drawing.Size(200, 22)
        Me.IdTextBox.TabIndex = 80
        '
        'UsernameTextBox
        '
        Me.UsernameTextBox.Location = New System.Drawing.Point(114, 92)
        Me.UsernameTextBox.Name = "UsernameTextBox"
        Me.UsernameTextBox.Size = New System.Drawing.Size(200, 22)
        Me.UsernameTextBox.TabIndex = 82
        '
        'PasswordTextBox
        '
        Me.PasswordTextBox.Location = New System.Drawing.Point(114, 120)
        Me.PasswordTextBox.Name = "PasswordTextBox"
        Me.PasswordTextBox.Size = New System.Drawing.Size(200, 22)
        Me.PasswordTextBox.TabIndex = 84
        '
        'F_admin_konfirmasi
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.arsip_digital.My.Resources.Resources._6e8ec8f0_b5ea_4454_8266_48e3aacbc59c
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(935, 655)
        Me.Controls.Add(DateLabel)
        Me.Controls.Add(Me.DateDateTimePicker)
        Me.Controls.Add(IdLabel)
        Me.Controls.Add(Me.IdTextBox)
        Me.Controls.Add(UsernameLabel)
        Me.Controls.Add(Me.UsernameTextBox)
        Me.Controls.Add(PasswordLabel)
        Me.Controls.Add(Me.PasswordTextBox)
        Me.Controls.Add(Label1)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.b_hapus)
        Me.Controls.Add(Me.b_simpan)
        Me.Controls.Add(Me.b_databaru)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.LevelTextbox)
        Me.Controls.Add(LevelLabel)
        Me.Name = "F_admin_konfirmasi"
        Me.Text = "APLIKASI ARSIP DIGITAL KPU KOTA SUKABUMI"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents LevelTextbox As System.Windows.Forms.ComboBox
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents b_hapus As System.Windows.Forms.Button
    Friend WithEvents b_simpan As System.Windows.Forms.Button
    Friend WithEvents b_databaru As System.Windows.Forms.Button
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents DateDateTimePicker As System.Windows.Forms.DateTimePicker
    Friend WithEvents IdTextBox As System.Windows.Forms.TextBox
    Friend WithEvents UsernameTextBox As System.Windows.Forms.TextBox
    Friend WithEvents PasswordTextBox As System.Windows.Forms.TextBox
End Class
