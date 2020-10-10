Imports Microsoft.Reporting.WinForms
Public Class FR_Divisi

    Private Sub FR_Divisi_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'db_arsipDataSet.t_file' table. You can move, or remove it, as needed.
        Me.t_fileTableAdapter.Fill(Me.db_arsipDataSet.t_file)

        Me.ReportViewer1.RefreshReport()
        Me.ReportViewer1.RefreshReport()
    End Sub

    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click
        Dim pkelas As New ReportParameter("pdivisi", ComboBox1.Text)

        With Me
            .ReportViewer1.RefreshReport()
            .ReportViewer1.LocalReport.SetParameters(pkelas)
            .ReportViewer1.RefreshReport()
        End With
    End Sub

    Private Sub Button2_Click(sender As System.Object, e As System.EventArgs) Handles Button2.Click
        FG_Divisi.Show()
    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles ComboBox1.SelectedIndexChanged

    End Sub
End Class