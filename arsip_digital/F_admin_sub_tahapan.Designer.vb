<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class F_admin_sub_Sub_tahapan
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
        Dim IdLabel As System.Windows.Forms.Label
        Dim TahapanLabel As System.Windows.Forms.Label
        Dim Sub_tahapanLabel As System.Windows.Forms.Label
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.b_ubah = New System.Windows.Forms.Button()
        Me.b_hapus = New System.Windows.Forms.Button()
        Me.b_simpan = New System.Windows.Forms.Button()
        Me.b_databaru = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.IdTextBox = New System.Windows.Forms.TextBox()
        Me.Sub_tahapanTextBox = New System.Windows.Forms.TextBox()
        Me.TahapanTextBox = New System.Windows.Forms.ComboBox()
        Label1 = New System.Windows.Forms.Label()
        IdLabel = New System.Windows.Forms.Label()
        TahapanLabel = New System.Windows.Forms.Label()
        Sub_tahapanLabel = New System.Windows.Forms.Label()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Label1.AutoSize = True
        Label1.Location = New System.Drawing.Point(463, 33)
        Label1.Name = "Label1"
        Label1.Size = New System.Drawing.Size(71, 17)
        Label1.TabIndex = 84
        Label1.Text = "Cari Data:"
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(461, 60)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(286, 22)
        Me.TextBox1.TabIndex = 81
        '
        'b_ubah
        '
        Me.b_ubah.Location = New System.Drawing.Point(219, 108)
        Me.b_ubah.Margin = New System.Windows.Forms.Padding(4)
        Me.b_ubah.Name = "b_ubah"
        Me.b_ubah.Size = New System.Drawing.Size(94, 33)
        Me.b_ubah.TabIndex = 80
        Me.b_ubah.Text = "Ubah"
        Me.b_ubah.UseVisualStyleBackColor = True
        '
        'b_hapus
        '
        Me.b_hapus.Location = New System.Drawing.Point(321, 108)
        Me.b_hapus.Margin = New System.Windows.Forms.Padding(4)
        Me.b_hapus.Name = "b_hapus"
        Me.b_hapus.Size = New System.Drawing.Size(94, 33)
        Me.b_hapus.TabIndex = 79
        Me.b_hapus.Text = "hapus"
        Me.b_hapus.UseVisualStyleBackColor = True
        '
        'b_simpan
        '
        Me.b_simpan.Location = New System.Drawing.Point(117, 108)
        Me.b_simpan.Margin = New System.Windows.Forms.Padding(4)
        Me.b_simpan.Name = "b_simpan"
        Me.b_simpan.Size = New System.Drawing.Size(94, 33)
        Me.b_simpan.TabIndex = 78
        Me.b_simpan.Text = "Simpan"
        Me.b_simpan.UseVisualStyleBackColor = True
        '
        'b_databaru
        '
        Me.b_databaru.Location = New System.Drawing.Point(15, 108)
        Me.b_databaru.Margin = New System.Windows.Forms.Padding(4)
        Me.b_databaru.Name = "b_databaru"
        Me.b_databaru.Size = New System.Drawing.Size(94, 33)
        Me.b_databaru.TabIndex = 77
        Me.b_databaru.Text = "Data Baru"
        Me.b_databaru.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(466, 107)
        Me.Button2.Margin = New System.Windows.Forms.Padding(4)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(286, 33)
        Me.Button2.TabIndex = 83
        Me.Button2.Text = "Sub Tahapan"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(15, 163)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.RowTemplate.Height = 24
        Me.DataGridView1.Size = New System.Drawing.Size(741, 332)
        Me.DataGridView1.TabIndex = 85
        '
        'IdLabel
        '
        IdLabel.AutoSize = True
        IdLabel.Location = New System.Drawing.Point(12, 20)
        IdLabel.Name = "IdLabel"
        IdLabel.Size = New System.Drawing.Size(23, 17)
        IdLabel.TabIndex = 86
        IdLabel.Text = "id:"
        '
        'IdTextBox
        '
        Me.IdTextBox.Enabled = False
        Me.IdTextBox.Location = New System.Drawing.Point(109, 17)
        Me.IdTextBox.Name = "IdTextBox"
        Me.IdTextBox.Size = New System.Drawing.Size(306, 22)
        Me.IdTextBox.TabIndex = 87
        '
        'TahapanLabel
        '
        TahapanLabel.AutoSize = True
        TahapanLabel.Location = New System.Drawing.Point(12, 48)
        TahapanLabel.Name = "TahapanLabel"
        TahapanLabel.Size = New System.Drawing.Size(64, 17)
        TahapanLabel.TabIndex = 88
        TahapanLabel.Text = "tahapan:"
        '
        'Sub_tahapanLabel
        '
        Sub_tahapanLabel.AutoSize = True
        Sub_tahapanLabel.Location = New System.Drawing.Point(12, 76)
        Sub_tahapanLabel.Name = "Sub_tahapanLabel"
        Sub_tahapanLabel.Size = New System.Drawing.Size(91, 17)
        Sub_tahapanLabel.TabIndex = 90
        Sub_tahapanLabel.Text = "sub tahapan:"
        '
        'Sub_tahapanTextBox
        '
        Me.Sub_tahapanTextBox.Location = New System.Drawing.Point(109, 73)
        Me.Sub_tahapanTextBox.Name = "Sub_tahapanTextBox"
        Me.Sub_tahapanTextBox.Size = New System.Drawing.Size(306, 22)
        Me.Sub_tahapanTextBox.TabIndex = 91
        '
        'TahapanTextBox
        '
        Me.TahapanTextBox.FormattingEnabled = True
        Me.TahapanTextBox.Location = New System.Drawing.Point(109, 41)
        Me.TahapanTextBox.Name = "TahapanTextBox"
        Me.TahapanTextBox.Size = New System.Drawing.Size(121, 24)
        Me.TahapanTextBox.TabIndex = 92
        '
        'F_admin_sub_Sub_tahapan
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(772, 507)
        Me.Controls.Add(Me.TahapanTextBox)
        Me.Controls.Add(IdLabel)
        Me.Controls.Add(Me.IdTextBox)
        Me.Controls.Add(TahapanLabel)
        Me.Controls.Add(Sub_tahapanLabel)
        Me.Controls.Add(Me.Sub_tahapanTextBox)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Label1)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.b_ubah)
        Me.Controls.Add(Me.b_hapus)
        Me.Controls.Add(Me.b_simpan)
        Me.Controls.Add(Me.b_databaru)
        Me.Name = "F_admin_sub_Sub_tahapan"
        Me.Text = "F_admin_sub_tahapan"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents b_ubah As System.Windows.Forms.Button
    Friend WithEvents b_hapus As System.Windows.Forms.Button
    Friend WithEvents b_simpan As System.Windows.Forms.Button
    Friend WithEvents b_databaru As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents IdTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Sub_tahapanTextBox As System.Windows.Forms.TextBox
    Friend WithEvents TahapanTextBox As System.Windows.Forms.ComboBox
End Class
