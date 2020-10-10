<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class F_pengguna_registrasi
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
        Dim DateLabel As System.Windows.Forms.Label
        Dim IdLabel As System.Windows.Forms.Label
        Dim UsernameLabel As System.Windows.Forms.Label
        Dim PasswordLabel As System.Windows.Forms.Label
        Me.Button1 = New System.Windows.Forms.Button()
        Me.LevelTextBox = New System.Windows.Forms.ComboBox()
        Me.DateDateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.IdTextBox = New System.Windows.Forms.TextBox()
        Me.UsernameTextBox = New System.Windows.Forms.TextBox()
        Me.PasswordTextBox = New System.Windows.Forms.TextBox()
        Me.Button2 = New System.Windows.Forms.Button()
        LevelLabel = New System.Windows.Forms.Label()
        DateLabel = New System.Windows.Forms.Label()
        IdLabel = New System.Windows.Forms.Label()
        UsernameLabel = New System.Windows.Forms.Label()
        PasswordLabel = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'LevelLabel
        '
        LevelLabel.AutoSize = True
        LevelLabel.Location = New System.Drawing.Point(25, 137)
        LevelLabel.Name = "LevelLabel"
        LevelLabel.Size = New System.Drawing.Size(41, 17)
        LevelLabel.TabIndex = 5
        LevelLabel.Text = "level:"
        '
        'DateLabel
        '
        DateLabel.AutoSize = True
        DateLabel.Location = New System.Drawing.Point(25, 28)
        DateLabel.Name = "DateLabel"
        DateLabel.Size = New System.Drawing.Size(40, 17)
        DateLabel.TabIndex = 9
        DateLabel.Text = "date:"
        '
        'IdLabel
        '
        IdLabel.AutoSize = True
        IdLabel.Location = New System.Drawing.Point(25, 55)
        IdLabel.Name = "IdLabel"
        IdLabel.Size = New System.Drawing.Size(23, 17)
        IdLabel.TabIndex = 11
        IdLabel.Text = "id:"
        '
        'UsernameLabel
        '
        UsernameLabel.AutoSize = True
        UsernameLabel.Location = New System.Drawing.Point(25, 83)
        UsernameLabel.Name = "UsernameLabel"
        UsernameLabel.Size = New System.Drawing.Size(75, 17)
        UsernameLabel.TabIndex = 13
        UsernameLabel.Text = "username:"
        '
        'PasswordLabel
        '
        PasswordLabel.AutoSize = True
        PasswordLabel.Location = New System.Drawing.Point(25, 111)
        PasswordLabel.Name = "PasswordLabel"
        PasswordLabel.Size = New System.Drawing.Size(72, 17)
        PasswordLabel.TabIndex = 15
        PasswordLabel.Text = "password:"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(126, 173)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(120, 48)
        Me.Button1.TabIndex = 7
        Me.Button1.Text = "Daftar"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'LevelTextBox
        '
        Me.LevelTextBox.FormattingEnabled = True
        Me.LevelTextBox.Items.AddRange(New Object() {"Program Data", "Teknis", "Umum", "SDM & Parmas", "Hukum", "Pengguna Umum"})
        Me.LevelTextBox.Location = New System.Drawing.Point(106, 137)
        Me.LevelTextBox.Name = "LevelTextBox"
        Me.LevelTextBox.Size = New System.Drawing.Size(223, 24)
        Me.LevelTextBox.TabIndex = 8
        '
        'DateDateTimePicker
        '
        Me.DateDateTimePicker.Enabled = False
        Me.DateDateTimePicker.Location = New System.Drawing.Point(106, 24)
        Me.DateDateTimePicker.Name = "DateDateTimePicker"
        Me.DateDateTimePicker.Size = New System.Drawing.Size(200, 22)
        Me.DateDateTimePicker.TabIndex = 10
        '
        'IdTextBox
        '
        Me.IdTextBox.Enabled = False
        Me.IdTextBox.Location = New System.Drawing.Point(106, 52)
        Me.IdTextBox.Name = "IdTextBox"
        Me.IdTextBox.Size = New System.Drawing.Size(375, 22)
        Me.IdTextBox.TabIndex = 12
        '
        'UsernameTextBox
        '
        Me.UsernameTextBox.Location = New System.Drawing.Point(106, 80)
        Me.UsernameTextBox.Name = "UsernameTextBox"
        Me.UsernameTextBox.Size = New System.Drawing.Size(375, 22)
        Me.UsernameTextBox.TabIndex = 14
        '
        'PasswordTextBox
        '
        Me.PasswordTextBox.Location = New System.Drawing.Point(106, 108)
        Me.PasswordTextBox.Name = "PasswordTextBox"
        Me.PasswordTextBox.Size = New System.Drawing.Size(375, 22)
        Me.PasswordTextBox.TabIndex = 16
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(281, 173)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(120, 48)
        Me.Button2.TabIndex = 17
        Me.Button2.Text = "Kembali"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'F_pengguna_registrasi
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.arsip_digital.My.Resources.Resources._6e8ec8f0_b5ea_4454_8266_48e3aacbc59c
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(506, 223)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(DateLabel)
        Me.Controls.Add(Me.DateDateTimePicker)
        Me.Controls.Add(IdLabel)
        Me.Controls.Add(Me.IdTextBox)
        Me.Controls.Add(UsernameLabel)
        Me.Controls.Add(Me.UsernameTextBox)
        Me.Controls.Add(PasswordLabel)
        Me.Controls.Add(Me.PasswordTextBox)
        Me.Controls.Add(Me.LevelTextBox)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(LevelLabel)
        Me.Name = "F_pengguna_registrasi"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "APLIKASI ARSIP DIGITAL KPU KOTA SUKABUMI"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents LevelTextBox As System.Windows.Forms.ComboBox
    Friend WithEvents DateDateTimePicker As System.Windows.Forms.DateTimePicker
    Friend WithEvents IdTextBox As System.Windows.Forms.TextBox
    Friend WithEvents UsernameTextBox As System.Windows.Forms.TextBox
    Friend WithEvents PasswordTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Button2 As System.Windows.Forms.Button
End Class
