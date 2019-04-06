Imports Challengeme.ApiCore
Imports Challengeme.Entities

Public Class frmActividad

    Public _em As New ExceptionManagement

    Dim managerDeActividades As New ActividadManagement

    Private Sub FrmActividad_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CargarLista()
        cargarIdActividad()
        txtNombreActividad.Focus()
        txtNombreActividad.CharacterCasing = CharacterCasing.Upper
        txtDescripcionActividad.CharacterCasing = CharacterCasing.Upper
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

        txtIdActividad.Text = ""
        txtNombreActividad.Text = ""
        txtDescripcionActividad.Text = ""

        txtNombreActividad.Focus()
    End Sub
    Private sub cargarIdActividad()
        
        Try      
            Dim Cod As Integer
            Dim listaId = managerDeActividades.RetrieveAllActividades(Of Actividad) 'igualo a la lista lo que encontró el procedimiento de listar

            For i = 0 To listaId.Count - 1 'hago el recorrido por la lista
                If(listaId.Item(i).Estado_Actividad="INACTIVO")Then
                    Cod = listaId.Item(i).IdActividad
                Else
                    Cod = listaId.Item(i).IdActividad
                End If
                
                'hace un recorrido por toda la lista y encuenta el ultimo codigo ingresado
            Next

            txtIdActividad.Text = Cod + 1 'a ese ultimo codigo ingresado le suma uno y ya tenemos el codigo sgte.
            txtIdActividad.Enabled = False
            txtNombreActividad.Focus

        Catch ex As ChallengeMeException
            _em.ManageException(ex)

        End Try

    End sub
    Private Sub FrmActividad_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing

        If e.CloseReason = CloseReason.UserClosing Then
            Dim result As DialogResult = MessageBox.Show("Seguro que desea salir?", "ATENCION", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning)
            If result <> DialogResult.OK Then
                e.Cancel = True
            Else
                frmEvento.Show()
                Close()
            End If
        End If

    End Sub
    Private Sub dgvListaActividades_DoubleClick(sender As Object, e As EventArgs) Handles dgvListaActividades.DoubleClick

        Dim i As Integer
        i = dgvListaActividades.CurrentRow.Index

        txtIdActividad.Text = dgvListaActividades.Item(0, i).Value
        txtNombreActividad.Text = dgvListaActividades.Item(1, i).Value
        txtDescripcionActividad.Text = dgvListaActividades.Item(2, i).Value

        txtIdActividad.Enabled = False

    End Sub

    Private Sub ToolStripBtnGuardar_Click(sender As Object, e As EventArgs) Handles ToolStripBtnGuardar.Click
        
        Dim n As New Actividad
        Dim u As New Actividad       

        u.IdActividad = txtIdActividad.Text
        u = managerDeActividades.RetrieveActividad(u)

        Try
            If (u Is Nothing) Then
                n.IdActividad = txtIdActividad.Text
                n.NombreActividad = txtNombreActividad.Text
                n.DescripcionActividad = txtDescripcionActividad.Text

                If (txtIdActividad.Text.Trim() = "" Or txtNombreActividad.Text.Trim() = "") Then
                    MessageBox.Show("Por favor verifique que los campos 'ID' y 'Nombre' esten llenos.", "OOPS!", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Else
                    managerDeActividades.CreateActividad(n)
                    MessageBox.Show("Actividad registrada con exito.", "FELICIDADES!", MessageBoxButtons.OK)
                End If
            
                LimpiarCampos()

            Else
                MessageBox.Show($"La actividad con el Id {txtIdActividad.Text} ya existe.", "OOPS!", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                txtIdActividad.Text = ""
                txtIdActividad.Focus()
            End If

        Catch ex As ChallengeMeException
            _em.ManageException(ex)
        End Try

        CargarLista()
    End Sub

    Private Sub ToolStripBtnBuscar_Click(sender As Object, e As EventArgs) Handles ToolStripBtnBuscar.Click
        
        Dim u As New Actividad

        u.IdActividad = txtIdActividad.Text
        u = managerDeActividades.RetrieveActividad(u)

        Try
            If (u Is Nothing) Then
                MessageBox.Show($"La actividad con el Id {txtIdActividad.Text} no existe.", "OOPS!", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                txtIdActividad.Text = ""
                txtIdActividad.Focus()

            Else
                txtIdActividad.Enabled = False
                txtNombreActividad.Text = u.NombreActividad
                txtDescripcionActividad.Text = u.DescripcionActividad

            End If

        Catch ex As ChallengeMeException

            _em.ManageException(ex)

        End Try
    End Sub

    Private Sub ToolStripBtnActualizar_Click(sender As Object, e As EventArgs) Handles ToolStripBtnActualizar.Click
        
        Dim u As New Actividad

        u.IdActividad = txtIdActividad.Text
        u = managerDeActividades.RetrieveActividad(u)

        Try
            If (u Is Nothing) Then
                MessageBox.Show($"La actividad con el Id {txtIdActividad.Text} no existe.", "OOPS!", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                txtIdActividad.Text = ""
                txtIdActividad.Focus()

            Else
                txtIdActividad.Enabled = False

                u.IdActividad = txtIdActividad.Text
                u.NombreActividad = txtNombreActividad.Text
                u.DescripcionActividad = txtDescripcionActividad.Text

                If (txtIdActividad.Text.Trim() = "" Or txtNombreActividad.Text.Trim() = "") Then
                    MessageBox.Show("Por favor verifique que los campos 'ID' y 'Nombre' esten llenos.", "OOPS!", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Else
                    managerDeActividades.UpdateActividad(u)
                    MessageBox.Show("Actividad actualizada con exito.", "FELICIDADES!", MessageBoxButtons.OK)
                End If

                LimpiarCampos()

            End If

        Catch ex As ChallengeMeException
            _em.ManageException(ex)

        End Try

        CargarLista()
    End Sub

    Private Sub ToolStripBtnEliminar_Click(sender As Object, e As EventArgs) Handles ToolStripBtnEliminar.Click
        
        Dim u As New Actividad

        u.IdActividad = txtIdActividad.Text
        u = managerDeActividades.RetrieveActividad(u)

        Try
            If (u Is Nothing) Then
                MessageBox.Show($"La actividad con el Id {txtIdActividad.Text} no existe.", "OOPS!", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                txtIdActividad.Text = ""
                txtIdActividad.Focus()

            Else
                managerDeActividades.DeleteActividad(u)
                MessageBox.Show("Actividad eliminada con éxito.", "FELICIDADES!", MessageBoxButtons.OK)

                LimpiarCampos()

            End If

        Catch ex As ChallengeMeException

            _em.ManageException(ex)

        End Try

        CargarLista()
    End Sub

    Private Sub ToolStripBtnNuevo_Click(sender As Object, e As EventArgs) Handles ToolStripBtnNuevo.Click
        LimpiarCampos()
    End Sub
    Private Sub ToolStripBtnSalir_Click(sender As Object, e As EventArgs) Handles ToolStripBtnSalir.Click
        frmEvento.Show()
        Close()
    End Sub

End Class