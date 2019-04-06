Imports Challengeme.ApiCore
Imports Challengeme.Entities

Public Class frmModalCrearActividad
    Public _em As New ExceptionManagement

    Dim managerDeActividades As New ActividadManagement
    Private Sub frmModalCrearActividad_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CargarLista()
        cargarIdActividad()
        txtNombreActividad.Focus()
        txtNombreActividad.CharacterCasing = CharacterCasing.Upper
        txtDescripcionActividad.CharacterCasing = CharacterCasing.Upper
        Me.Left = 350
        Me.Top = 175
    End Sub
    Private Sub CargarLista()

        Try
            dgvListaActividades.Rows.Clear()

            Dim listaDeActividades = managerDeActividades.RetrieveAllActividades(Of Actividad)

            For Each actividad As Actividad In listaDeActividades

                Dim rowActividad =
                        {
                            actividad.IdActividad,
                            actividad.NombreActividad,
                            actividad.DescripcionActividad
                        }

                dgvListaActividades.Rows.Add(rowActividad)

            Next
        Catch ex As Exception
            _em.ManageException(ex)
        End Try

    End Sub
    Private Sub LimpiarCampos()

        txtIdActividad.Enabled = True

     
        txtNombreActividad.Text = ""
        txtDescripcionActividad.Text = ""
        cargarIdActividad()
        txtNombreActividad.Focus
    End Sub
    Private Sub cargarIdActividad()

        Try
            Dim Cod As Integer
            Dim listaId = managerDeActividades.RetrieveAllActividades(Of Actividad) 'igualo a la lista lo que encontró el procedimiento de listar

            For i = 0 To listaId.Count - 1 'hago el recorrido por la lista
                If(listaId.Item(i).Estado_Actividad="INACTIVO")Then
                    Cod = listaId.Item(i).IdActividad
                    txtIdActividad.Text = Cod + 1

                Else
                    Cod = listaId.Item(i).IdActividad

                End If
                
                'hace un recorrido por toda la lista y encuenta el ultimo codigo ingresado
            Next

            txtIdActividad.Text = Cod + 1 'a ese ultimo codigo ingresado le suma uno y ya tenemos el codigo sgte.
            txtIdActividad.Enabled = False
            txtNombreActividad.Focus()

        Catch ex As ChallengeMeException
            _em.ManageException(ex)

        End Try

    End Sub
    Private Sub dgvListaActividades_DoubleClick(sender As Object, e As EventArgs) Handles dgvListaActividades.DoubleClick

        Dim i As Integer
        i = dgvListaActividades.CurrentRow.Index

        txtIdActividad.Text = dgvListaActividades.Item(0, i).Value
        txtNombreActividad.Text = dgvListaActividades.Item(1, i).Value
        txtDescripcionActividad.Text = dgvListaActividades.Item(2, i).Value

        txtIdActividad.Enabled = False

    End Sub

    Private Sub btnGuardar_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click
        Dim n As New Actividad

        Try
            n.IdActividad = txtIdActividad.Text
            n.NombreActividad = txtNombreActividad.Text
            n.DescripcionActividad = txtDescripcionActividad.Text


            managerDeActividades.CreateActividad(n)
            MessageBox.Show("Actividad registrada con exito.", "FELICIDADES!", MessageBoxButtons.OK)


            LimpiarCampos()


        Catch ex As ChallengeMeException
            _em.ManageException(ex)
        End Try

        CargarLista()
    End Sub
End Class