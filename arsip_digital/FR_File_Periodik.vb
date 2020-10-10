Imports Microsoft.Reporting.WinForms
Public Class FR_File_Periodik

    Private Sub FR_File_Periodik_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'db_arsipDataSet.t_file' table. You can move, or remove it, as needed.
        Me.t_fileTableAdapter.Fill(Me.db_arsipDataSet.t_file)


        Me.ReportViewer1.RefreshReport()
        Me.ReportViewer1.RefreshReport()
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

    Private Sub Button2_Click(sender As System.Object, e As System.EventArgs) Handles Button2.Click
        Dim dpinjam As New FG_periodik
        Dim pbulan As New ReportParameter("pjumlah1", Format(DateTimePicker1.Value, "yyyy-MM-dd"))
        Dim pbulan2 As New ReportParameter("pjumlah2", Format(DateTimePicker2.Value, "yyyy-MM-dd"))

        With dpinjam
            .ReportViewer1.RefreshReport()
            .ReportViewer1.LocalReport.SetParameters(pbulan)
            .ReportViewer1.LocalReport.SetParameters(pbulan2)
            .Show()
            .ReportViewer1.RefreshReport()
        End With
    End Sub

    Private Sub DateTimePicker1_ValueChanged(sender As System.Object, e As System.EventArgs) Handles DateTimePicker1.ValueChanged

    End Sub

    Private Sub DateTimePicker2_ValueChanged(sender As System.Object, e As System.EventArgs) Handles DateTimePicker2.ValueChanged

    End Sub
End Class