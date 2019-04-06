Imports Challengeme.ApiCore
Imports Challengeme.Entities

Public Class frmModalPatrocinadores
    Dim manejadorDePatrocinadores As New PatrocinadorManagement
     Public _em As New ExceptionManagement
     Public Nombres As String
     Public Montos As Double
    Private Sub frmModalPatrocinadores_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        listarPatrocinadores()
         txtNombrePatrocinador.CharacterCasing = CharacterCasing.Upper
    End Sub
    Private Sub listarPatrocinadores()
        Dim listaPatrocinadores = manejadorDePatrocinadores.RetrieveAllPatrocinadores(Of Patrocinador)

       For Each patrocinador As Patrocinador In listaPatrocinadores
            Dim rowPatrocinador=
                {
                patrocinador.IdPatrocinador,
                patrocinador.NombrePatrocinador
                }
            dgvPatrocinadores.Rows.Add(rowPatrocinador)

       Next

    End Sub
    Private sub buscarPatrocinador()
        Dim patrocinador As New Patrocinador


        If (Trim(txtNombrePatrocinador.Text = "")) Then
            dgvPatrocinadores.Rows.Clear()
            listarPatrocinadores()

        Else
            patrocinador.NombrePatrocinador = txtNombrePatrocinador.Text
            Try
                Dim lista = manejadorDePatrocinadores.RetrieveByName(Of Patrocinador)(patrocinador)


                For Each elemento In lista
                    dgvPatrocinadores.Rows.Clear()
                    Dim fila As String()
                    fila = New String() {elemento.IdPatrocinador, elemento.NombrePatrocinador}
                    dgvPatrocinadores.Rows.Add(fila)

                Next

            Catch ex As ChallengeMeException
                _em.ManageException(ex)

            End Try


        End If
    End sub

    Private Sub txtNombrePatrocinador_TextChanged(sender As Object, e As EventArgs) Handles txtNombrePatrocinador.TextChanged
        buscarPatrocinador()
    End Sub

    Private Sub dgvPatrocinadores_MouseClick(sender As Object, e As MouseEventArgs) Handles dgvPatrocinadores.MouseClick
        If dgvPatrocinadores.Rows.Count > 0 Then


          
            Nombres = dgvPatrocinadores.CurrentRow.Cells("Nombre").Value
            Montos = dgvPatrocinadores.CurrentRow.Cells("Monto").Value


            Me.Close()

        End If
    End Sub
End Class