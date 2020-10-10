Public Class FG_periodik

    Private Sub FG_periodik_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'db_arsipDataSet.t_file' table. You can move, or remove it, as needed.
        Me.t_fileTableAdapter.Fill(Me.db_arsipDataSet.t_file)

        Me.ReportViewer1.RefreshReport()
    End Sub
End Class