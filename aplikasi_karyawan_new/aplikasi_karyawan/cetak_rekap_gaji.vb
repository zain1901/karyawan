Imports CrystalDecisions.CrystalReports.Engine

Public Class cetak_rekap_gaji

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btncetak.Click
        Dim report_detail As New ReportDocument
        report_detail.load("..\..\cr_rekap_gaji.rpt")

        report_detail.setparametervalue("dari", dtpdari.Text)
        report_detail.setparametervalue("sampai", dtpsampai.Text)

        frm_cetak_rekapgaji.CrystalReportViewer1.ReportSource = report_detail
        frm_cetak_rekapgaji.CrystalReportViewer1.Refresh()
        frm_cetak_rekapgaji.Show()
    End Sub
End Class