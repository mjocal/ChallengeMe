Imports Challengeme.ApiCore
Imports Challengeme.Entities

Public Class frmModalActividades
    Inherits Form
    Dim managerDeActividades As New ActividadManagement
    Dim managerDeEventoActividad As New EventoActividadManagement
    Dim Cod_Actividad As Integer
    Dim Nom_Actividad As String
    Dim Desc_Actividad As String
    Public NumActividad As Integer
    Public NombreActividad As String
    Public Descripcionn As String
    Public _em As New ExceptionManagement
    Private Sub frmModalActividades_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        listarActividades()
        txtNombreActividad.CharacterCasing = CharacterCasing.Upper
        listarEventoActividad()

        Me.Left = 300
        Me.Top = 175
    End Sub

    Private Sub listarActividades()
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
    End Sub
    Private Sub buscarActividad()

        Dim actividad As New Actividad


        If (Trim(txtNombreActividad.Text = "")) Then
            dgvListaActividades.Rows.Clear()
            listarActividades()

        Else
            actividad.NombreActividad = txtNombreActividad.Text
            Try
                Dim lista = managerDeActividades.RetrieveByName(Of Actividad)(actividad)


                For Each elemento In lista
                    dgvListaActividades.Rows.Clear()
                    Dim fila As String()
                    fila = New String() {elemento.IdActividad, elemento.NombreActividad, elemento.DescripcionActividad}
                    dgvListaActividades.Rows.Add(fila)

                Next

            Catch ex As ChallengeMeException
                _em.ManageException(ex)

            End Try


        End If
    End Sub

    Private Sub txtNombreActividad_TextChanged(sender As Object, e As EventArgs) Handles txtNombreActividad.TextChanged
        buscarActividad()
    End Sub

    Private Sub dgvListaActividades_MouseDoubleClick(sender As Object, e As MouseEventArgs) Handles dgvListaActividades.MouseDoubleClick

    End Sub

    Private Sub dgvListaActividades_MouseClick(sender As Object, e As MouseEventArgs) Handles dgvListaActividades.MouseClick
        If dgvListaActividades.Rows.Count > 0 Then


            NumActividad = dgvListaActividades.CurrentRow.Cells("IdActividad").Value
            NombreActividad = dgvListaActividades.CurrentRow.Cells("Nombre").Value
            Descripcionn = dgvListaActividades.CurrentRow.Cells("Descripcion").Value

            txtIdActividad.Text = dgvListaActividades.CurrentRow.Cells("IdActividad").Value



        End If




    End Sub

    Private Sub frmModalActividades_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing

    End Sub

    Private Sub btnAgregar_Click(sender As Object, e As EventArgs) Handles btnAgregar.Click
        If (Trim(txtIdActividad.Text = "")) Then
            'se le obliga al usuario a seleccionar un producto de la lista para que sea agregado 
            MessageBox.Show("Debe seleccionar una actividad de la lista", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Error)

        Else
            dgvActividadEvento.Rows.Add(NumActividad, NombreActividad, Descripcionn)


        End If


        txtIdActividad.Text = ""



    End Sub

    Private Sub btnQuitar_Click(sender As Object, e As EventArgs) Handles btnQuitar.Click
        Dim i As Integer

        'quito la fila del grid permisos y costo
        i = dgvActividadEvento.CurrentRow.Index
        dgvActividadEvento.Rows.RemoveAt(i)
        MessageBox.Show("Se ha quitado la actividad de la lista de manera satisfactoria", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub

    Private Sub btnAgregarActividad_Click(sender As Object, e As EventArgs) Handles btnAgregarActividad.Click
        Dim eventoActividad As New EventoActividad
        Dim actividadEvento As New EventoActividad


        For Each row As DataGridViewRow In dgvActividadEvento.Rows
            'SE AGREGAN LAS ACTIVIDADES A ESTA TABLA PROVENIENTES DE LA
            'TABLA ANTERIOR

            eventoActividad.IdActividad = CStr(row.Cells("CodActividad").Value)

            eventoActividad = managerDeEventoActividad.Retrieve(eventoActividad)
            If (eventoActividad Is Nothing) Then

                actividadEvento.IdEvento = txtIdEvento.Text
                actividadEvento.IdActividad = CStr(row.Cells("CodActividad").Value)
                managerDeEventoActividad.Create(actividadEvento)

            End If




        Next
        Me.Close()
    End Sub

    Private Sub lnkCrearActividad_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles lnkCrearActividad.LinkClicked
        Dim ModalCrearActividades = New frmModalCrearActividad()
        ModalCrearActividades.ShowDialog()
        listarActividades()


    End Sub
    Private Sub listarEventoActividad()
        Dim eventoActividad As New EventoActividad


        If (Trim(txtIdEvento.Text <> "")) Then
            'Si el textbox codPatrocinador no está vacío significa que el usuario hizo clic en la
            'tabla de patrocinadores para ir a agregarle productos a ese codigo de patrocinador
            'entonces se hace una búsqueda en la tabla de patrocinadorproducto
            'para ver cuales productos están ligados a ese patrocinador en específico
            '---codigo hecho por Erick----

            eventoActividad.IdEvento = txtIdEvento.Text
            Dim listaEventoActividad = managerDeEventoActividad.RetrieveAllById(Of EventoActividad)(eventoActividad)
            'si la lista trae algo
            If (listaEventoActividad.Count > 0) Then
                dgvActividadEvento.Rows.Clear()
                For Each elemento As EventoActividad In listaEventoActividad
                    Dim actividad As New Actividad
                    Cod_Actividad = elemento.IdActividad
                    actividad.IdActividad = Cod_Actividad

                    Dim listaActividades = managerDeActividades.RetrieveAllById(Of Actividad)(actividad)
                    For Each actividades As Actividad In listaActividades

                        Nom_Actividad = actividades.NombreActividad
                        Desc_Actividad = actividades.DescripcionActividad

                    Next
                    ' If (cboNombreActividad.Items.Contains(NomActividad)) Then

                    '  Else
                    '  cboNombreActividad.Items.Add(NomActividad)

                    dgvActividadEvento.Rows.Add(Cod_Actividad, Nom_Actividad, Desc_Actividad)
                    quitarActividadDeListaDeActividades()

                    '  End If


                Next
                'Se agregan los datos al grid de productos

            End If
        End If
    End Sub
    Private Sub quitarActividadDeListaDeActividades()
        'METODO PARA QUITAR DE MANERA AUTOMATICA
        'UNA ACTIVIDAD DE LA LISTA DE ACTIVIDADES DE LA IZQUIERDA
        'EN CASO DE QUE ESA ACTIVIDAD YA HAYA SIGO AGREGADA AL EVENTO
        'Y EL USUARIO HAYA DECIDIDO VOLVER AL MODAL PARA AGREGAR OTRA ACTIVIDAD
        'LA ACTIVIDAD QUE YA HA SIDO AGREGADA AL EVENTO NO PUEDE SER AGREGADA DE NUEVO
        'Y APARECE LISTADA DE MANERA AUTOMATICA EN LA TABLA DE LAS ACTIVIDADES A AGREGAR
        'AL EVENTO



        For Each row As DataGridViewRow In dgvListaActividades.Rows
            'PARA CADA FILA EN LA TABLA DE LISTAACTIVIDADES

            'COMPARE EL VALOR QUE TIENE LA FILA IDACTIVIDAD Y SI ES IGUAL AL VALOR
            'DE LA VARIABLE COD_ACTIVIDAD (QUE YA ESTÁ LISTADA EN LA TABLA DE LA DERECHA)
            'ENTONCES INGRESA AL IF Y LE ASIGNA A LA VARIABLE i EL INDEX DE DICHA FILA
            'PARA QUE SE PROCEDA A REMOVERLA DE LA TABLA
            '--- HECHO POR ERICK-----
            If (row.Cells("IdActividad").Value = Cod_Actividad) Then
                Dim i As Integer

                'quito la fila del grid permisos y costo
                i = row.Index
                dgvListaActividades.Rows.RemoveAt(i)

            End If

        Next

    End Sub

End Class