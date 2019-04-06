Public Class frmMenuEventos
    Private Sub btnActividades_Click(sender As Object, e As EventArgs) Handles btnActividades.Click
        Dim actividades As New frmActividad
             actividades.MdiParent=Me
            Me.Panel2.Controls.Add(actividades)
            actividades.Show()
    End Sub

    Private Sub btnPatrocinadores_Click(sender As Object, e As EventArgs) Handles btnPatrocinadores.Click
        Dim patrocinadores As New frmPatrocinadores
             patrocinadores.MdiParent=Me
            Me.Panel2.Controls.Add(patrocinadores)
            patrocinadores.Show()
    End Sub

    Private Sub btnSalir_Click(sender As Object, e As EventArgs) Handles btnSalir.Click
        frmDashBoard.show()
        Me.Close()
    End Sub

    Private Sub btnPremios_Click(sender As Object, e As EventArgs) Handles btnPremios.Click
        Dim premios As New frmPremios
             premios.MdiParent=Me
            Me.Panel2.Controls.Add(premios)
            premios.Show()
    End Sub

    Private Sub btnEventos_Click(sender As Object, e As EventArgs) Handles btnEventos.Click
        Dim eventos As New frmEvento
             eventos.MdiParent=Me
            Me.Panel2.Controls.Add(eventos)
            eventos.Show()
    End Sub

    Private Sub frmMenuEventos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        btnEventos_Click(Me,e)
    End Sub
End Class