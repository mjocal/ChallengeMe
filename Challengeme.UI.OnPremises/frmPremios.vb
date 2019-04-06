Imports Challengeme.ApiCore
Imports Challengeme.Entities

Public Class frmPremios

    Public _em As New ExceptionManagement
    Dim managerDePremios As New PremioManagement

    Private Sub frmPremios_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        generarIdPremio()
        listarPremios()
        txtNombrePremio.Focus()
        txtNombrePremio.CharacterCasing = CharacterCasing.Upper
        txtDescripcionPremio.CharacterCasing = CharacterCasing.Upper
    End Sub
    Private sub listarPremios()

       Try
            Dim listaPremios = managerDePremios.RetrieveAllPremios(Of Premio)

            dgvListaPremios.Rows.Clear()

            For Each premios In listaPremios

                Dim fila As String()

                fila = New string() {
                    premios.IdPremio,
                    premios.NombrePremio,
                    premios.DescripcionPremio
                }

                dgvListaPremios.Rows.Add(fila)

            Next

        Catch ex As ChallengeMeException
            _em.ManageException(ex)
        End Try              
        
    End sub
    Private Sub LimpiarCampos()

        txtIdPremio.Enabled = True

        txtIdPremio.Text = ""
        txtNombrePremio.Text = ""
        txtDescripcionPremio.Text = ""

        txtNombrePremio.Focus()
    End Sub
    Private Sub generarIdPremio()
        Try
            Dim Cod As Integer
            Dim listaId = managerDePremios.RetrieveAllPremios(Of Premio) 'igualo a la lista lo que encontró el procedimiento de listar

            For i = 0 To listaId.Count - 1 'hago el recorrido por la lista
                If(listaId.Item(i).Estado_Premio="INACTIVO")Then
                    Cod = listaId.Item(i).IdPremio
                Else
                    Cod = listaId.Item(i).IdPremio
                End If
                
                'hace un recorrido por toda la lista y encuenta el ultimo codigo ingresado

            Next
            txtIdPremio.Text = Cod + 1 'a ese ultimo codigo ingresado le suma uno y ya tenemos el codigo sgte.
            txtIdPremio.Enabled = False
            txtNombrePremio.Focus

        Catch ex As ChallengeMeException
            _em.ManageException(ex)

        End Try
    End Sub
    Private Sub dgvListaPremios_DoubleClick(sender As Object, e As EventArgs) Handles dgvListaPremios.DoubleClick

        Dim i As Integer
        i = dgvListaPremios.CurrentRow.Index

        txtIdPremio.Text = dgvListaPremios.Item(0, i).Value
        txtNombrePremio.Text = dgvListaPremios.Item(1, i).Value
        txtDescripcionPremio.Text = dgvListaPremios.Item(2, i).Value

        txtIdPremio.Enabled = False

    End Sub


    Private Sub ToolStripBtnGuardar_Click(sender As Object, e As EventArgs) Handles ToolStripBtnGuardar.Click

        Dim premio As New Premio
        erProveedorError.Clear()

        Try
            If (Trim(txtNombrePremio.Text="")) then
                erProveedorError.SetError (txtNombrePremio,"Debe indicar un nombre al premio")
                txtNombrePremio.Focus
                Return
            End If

            If (Trim(txtDescripcionPremio.Text="")) then
                erProveedorError.SetError (txtDescripcionPremio,"Debe indicar una descripción al premio")
                txtDescripcionPremio.Focus
                Return
            End If

            premio.IdPremio=txtIdPremio.Text
            premio.NombrePremio= txtNombrePremio.Text
            premio.DescripcionPremio=txtDescripcionPremio.Text

            managerDePremios.CreatePremio(premio)

            LimpiarCampos()
            generarIdPremio()

        Catch ex As ChallengeMeException
            _em.ManageException(ex)

        End Try
        
        listarPremios()

    End Sub
    Private Sub ToolStripBtnBuscar_Click(sender As Object, e As EventArgs) Handles ToolStripBtnBuscar.Click

        Dim premio As New Premio

        premio.IdPremio = txtIdPremio.Text
        premio = managerDePremios.RetrievePremio(premio)

        Try
            If (premio Is Nothing) Then
                MessageBox.Show($"El premio con el Id {txtIdPremio.Text} no existe.", "OOPS!", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                txtIdPremio.Text = ""
                txtIdPremio.Focus()

            Else
                txtIdPremio.Enabled = False
                txtNombrePremio.Text = premio.NombrePremio
                txtDescripcionPremio.Text = premio.DescripcionPremio

            End If

        Catch ex As ChallengeMeException
            _em.ManageException(ex)

        End Try
    End Sub
    Private Sub ToolStripBtnActualizar_Click(sender As Object, e As EventArgs) Handles ToolStripBtnActualizar.Click

        Dim premio As New Premio

        premio.IdPremio = txtIdPremio.Text
        premio = managerDePremios.RetrievePremio(premio)

        Try
            If (premio Is Nothing) Then
                MessageBox.Show($"El premio con el Id {txtIdPremio.Text} no existe.", "OOPS!", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                txtIdPremio.Text = ""
                txtIdPremio.Focus()

            Else
                txtIdPremio.Enabled = False

                premio.IdPremio = txtIdPremio.Text
                premio.NombrePremio = txtNombrePremio.Text
                premio.DescripcionPremio = txtDescripcionPremio.Text

                If (txtIdPremio.Text.Trim() = "" Or txtNombrePremio.Text.Trim() = "") Then
                    MessageBox.Show("Por favor verifique que los campos 'ID' y 'Nombre' esten llenos.", "OOPS!", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Else
                    managerDePremios.UpdatePremio(premio)
                    MessageBox.Show("Premio actualizado con éxito.", "FELICIDADES!", MessageBoxButtons.OK)
                End If

                LimpiarCampos()

            End If

        Catch ex As ChallengeMeException
            _em.ManageException(ex)

        End Try

        listarPremios()

    End Sub
    Private Sub ToolStripBtnEliminar_Click(sender As Object, e As EventArgs) Handles ToolStripBtnEliminar.Click

        Dim premio As New Premio

        premio.IdPremio = txtDescripcionPremio.Text
        premio = managerDePremios.RetrievePremio(premio)

        Try
            If (premio Is Nothing) Then
                MessageBox.Show($"El premio con el Id {txtIdPremio.Text} no existe.", "OOPS!", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                txtIdPremio.Text = ""
                txtIdPremio.Focus()

            Else
                managerDePremios.DeletePremio(premio)
                MessageBox.Show("Premio eliminado con éxito.", "FELICIDADES!", MessageBoxButtons.OK)

                LimpiarCampos()

            End If

        Catch ex As ChallengeMeException
            _em.ManageException(ex)

        End Try

        listarPremios()
    End Sub
    Private Sub ToolStripBtnNuevo_Click(sender As Object, e As EventArgs) Handles ToolStripBtnNuevo.Click
        'txtNombrePremio.Text=""
        'txtDescripcionPremio.Text=""
        'generarIdPremio()
        'listarPremios()
        LimpiarCampos()
    End Sub
    Private Sub ToolStripBtnSalir_Click(sender As Object, e As EventArgs) Handles ToolStripBtnSalir.Click
        frmEvento.Show()
        Close()
    End Sub

End Class