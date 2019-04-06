<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmReporteInscripciones
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
        Me.ReportViewer1 = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.txtIdInscripcion = New System.Windows.Forms.TextBox()
        Me.SuspendLayout
        '
        'ReportViewer1
        '
        Me.ReportViewer1.Dock = System.Windows.Forms.DockStyle.Top
        Me.ReportViewer1.Location = New System.Drawing.Point(0, 0)
        Me.ReportViewer1.Name = "ReportViewer1"
        Me.ReportViewer1.ProcessingMode = Microsoft.Reporting.WinForms.ProcessingMode.Remote
        Me.ReportViewer1.ServerReport.ReportPath = "/ChallengeMe.UTIL_ReportItems/RP_02_INSCRIPCIONES.rdl"
        Me.ReportViewer1.ServerReport.ReportServerUrl = New System.Uri("http://localhost:8282/reportserver", System.UriKind.Absolute)
        Me.ReportViewer1.Size = New System.Drawing.Size(700, 582)
        Me.ReportViewer1.TabIndex = 0
        '
        'txtIdInscripcion
        '
        Me.txtIdInscripcion.Location = New System.Drawing.Point(47, 37)
        Me.txtIdInscripcion.Name = "txtIdInscripcion"
        Me.txtIdInscripcion.Size = New System.Drawing.Size(125, 20)
        Me.txtIdInscripcion.TabIndex = 1
        Me.txtIdInscripcion.Visible = false
        '
        'FrmReporteInscripciones
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6!, 13!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(700, 583)
        Me.Controls.Add(Me.txtIdInscripcion)
        Me.Controls.Add(Me.ReportViewer1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "FrmReporteInscripciones"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "FrmReporteInscripciones"
        Me.ResumeLayout(false)
        Me.PerformLayout

End Sub

    Friend WithEvents ReportViewer1 As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents txtIdInscripcion As TextBox
End Class
