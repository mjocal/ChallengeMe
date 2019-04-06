Imports Microsoft.Reporting.WinForms

Public Class FrmReporteInscripciones
    Private Sub FrmReporteInscripciones_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Left=300

        Dim idInscripcion = txtIdInscripcion.Text
        Me.ReportViewer1.ServerReport.ReportPath = "/ChallengeMe.UTIL_ReportItems/RP_02_INSCRIPCIONES"
        Me.ReportViewer1.ServerReport.ReportServerUrl = New System.Uri("http://localhost:8282/ReportServer")

        Dim parametros As New List(Of ReportParameter)
        parametros.Add(New ReportParameter("P_ID",idInscripcion , False))

        Me.ReportViewer1.ServerReport.SetParameters(parametros)
        Me.ReportViewer1.RefreshReport()
        Me.ReportViewer1.ProcessingMode = ProcessingMode.Remote
     
    End Sub

    Private Sub FrmReporteInscripciones_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing

    End Sub

    Private Sub txtIdInscripcion_TextChanged(sender As Object, e As EventArgs)


    End Sub
End Class