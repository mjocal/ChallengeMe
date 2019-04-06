Imports Challengeme.ApiCore
Imports Challengeme.Entities

Public Class frmModalPremios
    Dim managerDePremios As New PremioManagement
    Dim managerDeEventoPremio As New EventoPremioManagement
    Dim Cod_Premio As Integer
    Public _em As New ExceptionManagement
    Public NumPremio As Integer
    Public NomPremio As String
    Public DescPremio As String
    Private Sub frmModalPremios_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        listarPremios()
        listarPremiosEnEvento()
        txtNombrePremio.CharacterCasing = CharacterCasing.Upper
        Me.Left = 300
        Me.Top = 175
    End Sub
    Private Sub listarPremios()
        dgvListaPremios.Rows.Clear()
        Dim listaPremios = managerDePremios.RetrieveAllPremios(Of Premio)

        For Each premio As Premio In listaPremios
            Dim rowPatrocinador =
                {
                premio.IdPremio,
                premio.NombrePremio,
                premio.DescripcionPremio
                }

            dgvListaPremios.Rows.Add(rowPatrocinador)

        Next
    End Sub
    Private Sub buscarPremios()
        Dim premios As New Premio


        If (Trim(txtNombrePremio.Text = "")) Then
            dgvListaPremios.Rows.Clear()
            listarPremios()

        Else
            premios.NombrePremio = txtNombrePremio.Text
            Try
                Dim lista = managerDePremios.RetrieveByName(Of Premio)(premios)


                For Each elemento In lista
                    dgvListaPremios.Rows.Clear()
                    Dim fila As String()
                    fila = New String() {elemento.IdPremio, elemento.NombrePremio, elemento.DescripcionPremio}
                    dgvListaPremios.Rows.Add(fila)

                Next

            Catch ex As ChallengeMeException
                _em.ManageException(ex)

            End Try


        End If
    End Sub

    Private Sub dgvListaPremios_MouseClick(sender As Object, e As MouseEventArgs) Handles dgvListaPremios.MouseClick
        If dgvListaPremios.Rows.Count > 0 Then


            NumPremio = dgvListaPremios.CurrentRow.Cells("IdPremio").Value
            NomPremio = dgvListaPremios.CurrentRow.Cells("Nombre").Value
            DescPremio = dgvListaPremios.CurrentRow.Cells("Descripcion").Value

            txtIdPremio.Text = dgvListaPremios.CurrentRow.Cells("IdPremio").Value



        End If
    End Sub

    Private Sub txtNombrePremio_TextChanged(sender As Object, e As EventArgs) Handles txtNombrePremio.TextChanged
        buscarPremios()
    End Sub

    Private Sub btnAgregar_Click(sender As Object, e As EventArgs) Handles btnAgregar.Click

        If (Trim(txtIdPremio.Text = "")) Then
            'se le obliga al usuario a seleccionar un premio de la lista para que sea agregado 
            MessageBox.Show("Debe seleccionar un premio de la lista", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Error)

        Else
            dgvPremioEvento.Rows.Add(NumPremio, NomPremio, DescPremio)


        End If


        txtIdPremio.Text = ""



    End Sub

    Private Sub btnQuitar_Click(sender As Object, e As EventArgs) Handles btnQuitar.Click
        Dim i As Integer
        Dim contador As Integer = 0
        'quito la fila del grid permisos y costo
        i = dgvPremioEvento.CurrentRow.Index
        dgvPremioEvento.Rows.RemoveAt(i)
        MessageBox.Show("Se ha quitado el premio de la lista de manera satisfactoria", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub

    Private Sub btnAgregarPremio_Click(sender As Object, e As EventArgs) Handles btnAgregarPremio.Click
        Dim eventoPremio As New EventoPremio
        Dim premioEvento As New EventoPremio

        For Each row As DataGridViewRow In dgvPremioEvento.Rows

            eventoPremio.IdPremio = CStr(row.Cells("CodPremio").Value)
            eventoPremio = managerDeEventoPremio.Retrieve(eventoPremio)

            If (eventoPremio Is Nothing) Then
                premioEvento.IdEvento = txtIdEvento.Text
                premioEvento.IdPremio = CStr(row.Cells("CodPremio").Value)
                managerDeEventoPremio.Create(eventoPremio)
            End If
        Next
        Me.Close()



    End Sub

    Private Sub lnkCrearPremios_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles lnkCrearPremios.LinkClicked
        Dim ModalCrearPremios = New frmModalCrearPremios()
        ModalCrearPremios.ShowDialog()
        listarPremios()

    End Sub
    Private Sub listarPremiosEnEvento()


        Dim eventoPremio As New EventoPremio


        If (Trim(txtIdEvento.Text <> "")) Then
            'Si el textbox codPatrocinador no está vacío significa que el usuario hizo clic en la
            'tabla de patrocinadores para ir a agregarle productos a ese codigo de patrocinador
            'entonces se hace una búsqueda en la tabla de patrocinadorproducto
            'para ver cuales productos están ligados a ese patrocinador en específico
            '---codigo hecho por Erick----

            eventoPremio.IdEvento = txtIdEvento.Text
            Dim listaEventoPremio = managerDeEventoPremio.RetrieveAllById(Of EventoPremio)(eventoPremio)
            'si la lista trae algo
            If (listaEventoPremio.Count > 0) Then
                dgvPremioEvento.Rows.Clear()
                For Each elemento As EventoPremio In listaEventoPremio
                    Dim premio As New Premio
                    Cod_Premio = elemento.IdPremio
                    premio.IdPremio = Cod_Premio

                    Dim listaPremios = managerDePremios.RetrieveAllById(Of Premio)(premio)
                    For Each premios As Premio In listaPremios

                        NomPremio = premios.NombrePremio
                        DescPremio = premios.DescripcionPremio

                    Next
                    'If (cboPremio.Items.Contains(NomPremio)) Then

                    ' Else
                    ' cboPremio.Items.Add(NomPremio)
                    dgvPremioEvento.Rows.Add(Cod_Premio, NomPremio, DescPremio)
                    quitarPremioDeListaPremios()
                    ' End If

                Next
                'Se agregan los datos al grid de productos

            End If
        End If
    End Sub
    Private Sub quitarPremioDeListaPremios()
        For Each row As DataGridViewRow In dgvListaPremios.Rows
            'PARA CADA FILA EN LA TABLA DE LISTA PRODUCTOS


            '--- HECHO POR ERICK-----
            If (row.Cells("IdPremio").Value = Cod_Premio) Then
                Dim i As Integer

                'quito la fila del grid 
                i = row.Index
                dgvListaPremios.Rows.RemoveAt(i)

            End If

        Next
    End Sub
End Class