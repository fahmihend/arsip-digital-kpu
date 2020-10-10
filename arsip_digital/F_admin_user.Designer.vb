<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class F_admin_user
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
        Dim DateLabel As System.Windows.Forms.Label
        Dim IdLabel As System.Windows.Forms.Label
        Dim UsernameLabel As System.Windows.Forms.Label
        Dim PasswordLabel As System.Windows.Forms.Label
        Dim LevelLabel As System.Windows.Forms.Label
        Dim Label1 As System.Windows.Forms.Label
        Dim Label2 As System.Windows.Forms.Label
        Me.DateDateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.IdTextBox = New System.Windows.Forms.TextBox()
        Me.UsernameTextBox = New System.Windows.Forms.TextBox()
        Me.PasswordTextBox = New System.Windows.Forms.TextBox()
        Me.b_hapus = New System.Windows.Forms.Button()
        Me.b_simpan = New System.Windows.Forms.Button()
        Me.b_databaru = New System.Windows.Forms.Button()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.b_ubah = New System.Windows.Forms.Button()
        Me.LevelTextBox = New System.Windows.Forms.ComboBox()
        DateLabel = New System.Windows.Forms.Label()
        IdLabel = New System.Windows.Forms.Label()
        UsernameLabel = New System.Windows.Forms.Label()
        PasswordLabel = New System.Windows.Forms.Label()
        LevelLabel = New System.Windows.Forms.Label()
        Label1 = New System.Windows.Forms.Label()
        Label2 = New System.Windows.Forms.Label()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DateLabel
        '
        DateLabel.AutoSize = True
        DateLabel.Location = New System.Drawing.Point(12, 66)
        DateLabel.Name = "DateLabel"
        DateLabel.Size = New System.Drawing.Size(40, 17)
        DateLabel.TabIndex = 1
        DateLabel.Text = "date:"
        '
        'IdLabel
        '
        IdLabel.AutoSize = True
        IdLabel.Location = New System.Drawing.Point(12, 95)
        IdLabel.Name = "IdLabel"
        IdLabel.Size = New System.Drawing.Size(23, 17)
        IdLabel.TabIndex = 3
        IdLabel.Text = "id:"
        '
        'UsernameLabel
        '
        UsernameLabel.AutoSize = True
        UsernameLabel.Location = New System.Drawing.Point(12, 121)
        UsernameLabel.Name = "UsernameLabel"
        UsernameLabel.Size = New System.Drawing.Size(75, 17)
        UsernameLabel.TabIndex = 5
        UsernameLabel.Text = "username:"
        '
        'PasswordLabel
        '
        PasswordLabel.AutoSize = True
        PasswordLabel.Location = New System.Drawing.Point(12, 149)
        PasswordLabel.Name = "PasswordLabel"
        PasswordLabel.Size = New System.Drawing.Size(72, 17)
        PasswordLabel.TabIndex = 7
        PasswordLabel.Text = "password:"
        '
        'LevelLabel
        '
        LevelLabel.AutoSize = True
        LevelLabel.Location = New System.Drawing.Point(12, 177)
        LevelLabel.Name = "LevelLabel"
        LevelLabel.Size = New System.Drawing.Size(41, 17)
        LevelLabel.TabIndex = 9
        LevelLabel.Text = "level:"
        '
        'Label1
        '
        Label1.AutoSize = True
        Label1.Location = New System.Drawing.Point(12, 235)
        Label1.Name = "Label1"
        Label1.Size = New System.Drawing.Size(78, 17)
        Label1.TabIndex = 57
        Label1.Text = "Cari Nama:"
        '
        'Label2
        '
        Label2.AutoSize = True
        Label2.Location = New System.Drawing.Point(390, 236)
        Label2.Name = "Label2"
        Label2.Size = New System.Drawing.Size(75, 17)
        Label2.TabIndex = 59
        Label2.Text = "Cari Level:"
        '
        'DateDateTimePicker
        '
        Me.DateDateTimePicker.Enabled = False
        Me.DateDateTimePicker.Location = New System.Drawing.Point(93, 62)
        Me.DateDateTimePicker.Name = "DateDateTimePicker"
        Me.DateDateTimePicker.Size = New System.Drawing.Size(200, 22)
        Me.DateDateTimePicker.TabIndex = 2
        '
        'IdTextBox
        '
        Me.IdTextBox.Enabled = False
        Me.IdTextBox.Location = New System.Drawing.Point(93, 90)
        Me.IdTextBox.Name = "IdTextBox"
        Me.IdTextBox.Size = New System.Drawing.Size(200, 22)
        Me.IdTextBox.TabIndex = 4
        '
        'UsernameTextBox
        '
        Me.UsernameTextBox.Location = New System.Drawing.Point(93, 118)
        Me.UsernameTextBox.Name = "UsernameTextBox"
        Me.UsernameTextBox.Size = New System.Drawing.Size(439, 22)
        Me.UsernameTextBox.TabIndex = 6
        '
        'PasswordTextBox
        '
        Me.PasswordTextBox.Location = New System.Drawing.Point(93, 146)
        Me.PasswordTextBox.Name = "PasswordTextBox"
        Me.PasswordTextBox.Size = New System.Drawing.Size(439, 22)
        Me.PasswordTextBox.TabIndex = 8
        '
        'b_hapus
        '
        Me.b_hapus.Location = New System.Drawing.Point(613, 183)
        Me.b_hapus.Margin = New System.Windows.Forms.Padding(4)
        Me.b_hapus.Name = "b_hapus"
        Me.b_hapus.Size = New System.Drawing.Size(139, 33)
        Me.b_hapus.TabIndex = 55
        Me.b_hapus.Text = "hapus"
        Me.b_hapus.UseVisualStyleBackColor = True
        '
        'b_simpan
        '
        Me.b_simpan.Location = New System.Drawing.Point(613, 101)
        Me.b_simpan.Margin = New System.Windows.Forms.Padding(4)
        Me.b_simpan.Name = "b_simpan"
        Me.b_simpan.Size = New System.Drawing.Size(139, 33)
        Me.b_simpan.TabIndex = 54
        Me.b_simpan.Text = "Simpan"
        Me.b_simpan.UseVisualStyleBackColor = True
        '
        'b_databaru
        '
        Me.b_databaru.Location = New System.Drawing.Point(613, 59)
        Me.b_databaru.Margin = New System.Windows.Forms.Padding(4)
        Me.b_databaru.Name = "b_databaru"
        Me.b_databaru.Size = New System.Drawing.Size(139, 33)
        Me.b_databaru.TabIndex = 53
        Me.b_databaru.Text = "Data Baru"
        Me.b_databaru.UseVisualStyleBackColor = True
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(13, 264)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.RowTemplate.Height = 24
        Me.DataGridView1.Size = New System.Drawing.Size(739, 403)
        Me.DataGridView1.TabIndex = 56
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(93, 235)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(281, 22)
        Me.TextBox1.TabIndex = 58
        '
        'TextBox2
        '
        Me.TextBox2.Location = New System.Drawing.Point(471, 236)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(281, 22)
        Me.TextBox2.TabIndex = 60
        '
        'b_ubah
        '
        Me.b_ubah.Location = New System.Drawing.Point(613, 142)
        Me.b_ubah.Margin = New System.Windows.Forms.Padding(4)
        Me.b_ubah.Name = "b_ubah"
        Me.b_ubah.Size = New System.Drawing.Size(139, 33)
        Me.b_ubah.TabIndex = 61
        Me.b_ubah.Text = "Ubah"
        Me.b_ubah.UseVisualStyleBackColor = True
        '
        'LevelTextBox
        '
        Me.LevelTextBox.Items.AddRange(New Object() {"Admin", "Program Data", "Teknis", "Umum", "SDM & Parmas", "Hukum", "Pengguna Umum"})
        Me.LevelTextBox.Location = New System.Drawing.Point(93, 177)
        Me.LevelTextBox.Name = "LevelTextBox"
        Me.LevelTextBox.Size = New System.Drawing.Size(175, 24)
        Me.LevelTextBox.TabIndex = 62
        '
        'F_admin_user
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.arsip_digital.My.Resources.Resources._6e8ec8f0_b5ea_4454_8266_48e3aacbc59c
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(769, 676)
        Me.Controls.Add(Me.LevelTextBox)
        Me.Controls.Add(Me.b_ubah)
        Me.Controls.Add(Label2)
        Me.Controls.Add(Me.TextBox2)
        Me.Controls.Add(Label1)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.b_hapus)
        Me.Controls.Add(Me.b_simpan)
        Me.Controls.Add(Me.b_databaru)
        Me.Controls.Add(DateLabel)
        Me.Controls.Add(Me.DateDateTimePicker)
        Me.Controls.Add(IdLabel)
        Me.Controls.Add(Me.IdTextBox)
        Me.Controls.Add(UsernameLabel)
        Me.Controls.Add(Me.UsernameTextBox)
        Me.Controls.Add(PasswordLabel)
        Me.Controls.Add(Me.PasswordTextBox)
        Me.Controls.Add(LevelLabel)
        Me.Name = "F_admin_user"
        Me.Text = "APLIKASI ARSIP DIGITAL KPU KOTA SUKABUMI"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents DateDateTimePicker As System.Windows.Forms.DateTimePicker
    Friend WithEvents IdTextBox As System.Windows.Forms.TextBox
    Friend WithEvents UsernameTextBox As System.Windows.Forms.TextBox
    Friend WithEvents PasswordTextBox As System.Windows.Forms.TextBox
    Friend WithEvents b_hapus As System.Windows.Forms.Button
    Friend WithEvents b_simpan As System.Windows.Forms.Button
    Friend WithEvents b_databaru As System.Windows.Forms.Button
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox2 As System.Windows.Forms.TextBox
    Friend WithEvents b_ubah As System.Windows.Forms.Button
    Friend WithEvents LevelTextBox As System.Windows.Forms.ComboBox

End Class
