<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FRS_Divisi
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
        Me.components = New System.ComponentModel.Container()
        Dim ReportDataSource1 As Microsoft.Reporting.WinForms.ReportDataSource = New Microsoft.Reporting.WinForms.ReportDataSource()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.ReportViewer1 = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.db_arsipDataSet = New arsip_digital.db_arsipDataSet()
        Me.t_fileBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.t_fileTableAdapter = New arsip_digital.db_arsipDataSetTableAdapters.t_fileTableAdapter()
        Me.db_arsipDataSet1 = New arsip_digital.db_arsipDataSet1()
        CType(Me.db_arsipDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.t_fileBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.db_arsipDataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ComboBox1
        '
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Items.AddRange(New Object() {"Program Data", "Teknis", "Umum", "SDM & Parmas", "Hukum"})
        Me.ComboBox1.Location = New System.Drawing.Point(13, 12)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(272, 24)
        Me.ComboBox1.TabIndex = 5
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(291, 11)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(121, 25)
        Me.Button1.TabIndex = 4
        Me.Button1.Text = "Cari"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'ReportViewer1
        '
        ReportDataSource1.Name = "DataSet1"
        ReportDataSource1.Value = Me.t_fileBindingSource
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource1)
        Me.ReportViewer1.LocalReport.ReportEmbeddedResource = "arsip_digital.ReportUserFileDivisi.rdlc"
        Me.ReportViewer1.Location = New System.Drawing.Point(13, 57)
        Me.ReportViewer1.Name = "ReportViewer1"
        Me.ReportViewer1.Size = New System.Drawing.Size(936, 410)
        Me.ReportViewer1.TabIndex = 6
        '
        'db_arsipDataSet
        '
        Me.db_arsipDataSet.DataSetName = "db_arsipDataSet"
        Me.db_arsipDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        't_fileBindingSource
        '
        Me.t_fileBindingSource.DataMember = "t_file"
        Me.t_fileBindingSource.DataSource = Me.db_arsipDataSet
        '
        't_fileTableAdapter
        '
        Me.t_fileTableAdapter.ClearBeforeFill = True
        '
        'db_arsipDataSet1
        '
        Me.db_arsipDataSet1.DataSetName = "db_arsipDataSet1"
        Me.db_arsipDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'FRS_Divisi
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.arsip_digital.My.Resources.Resources._6e8ec8f0_b5ea_4454_8266_48e3aacbc59c
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(961, 479)
        Me.Controls.Add(Me.ReportViewer1)
        Me.Controls.Add(Me.ComboBox1)
        Me.Controls.Add(Me.Button1)
        Me.Name = "FRS_Divisi"
        Me.Text = "FormR_server"
        CType(Me.db_arsipDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.t_fileBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.db_arsipDataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents ComboBox1 As System.Windows.Forms.ComboBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents ReportViewer1 As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents t_fileBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents db_arsipDataSet As arsip_digital.db_arsipDataSet
    Friend WithEvents t_fileTableAdapter As arsip_digital.db_arsipDataSetTableAdapters.t_fileTableAdapter
    Friend WithEvents db_arsipDataSet1 As arsip_digital.db_arsipDataSet1
End Class
