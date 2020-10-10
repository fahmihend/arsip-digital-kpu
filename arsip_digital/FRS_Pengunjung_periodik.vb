Imports Microsoft.Reporting.WinForms
Public Class FRS_Pengunjung_periodik

    Private Sub FRS_Pengunjung_periodik_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'db_arsipDataSet1.t_pengunjung' table. You can move, or remove it, as needed.
        Me.t_pengunjungTableAdapter.Fill(Me.db_arsipDataSet1.t_pengunjung)

        Me.ReportViewer1.RefreshReport()
    End Sub

    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click
        Dim pbulan As New ReportParameter("ptanggal1", Format(DateTimePicker1.Value, "yyyy-MM-dd"))
        Dim pbulan2 As New ReportParameter("ptanggal2", Format(DateTimePicker2.Value, "yyyy-MM-dd"))

        With Me
            .ReportViewer1.RefreshReport()
            .ReportViewer1.LocalReport.SetParameters(pbulan)
            .ReportViewer1.LocalReport.SetParameters(pbulan2)
            .ReportViewer1.RefreshReport()
        End With
    End Sub
End Class