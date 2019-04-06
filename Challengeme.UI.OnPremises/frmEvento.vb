Imports Challengeme.ApiCore
Imports Challengeme.Entities

Public Module EventoGlobals
    Public nombreDelEvento As String
    Public idDelEvento As Integer
End Module
Public Class frmEvento

    Public _em As New ExceptionManagement

    Dim managerDeUsuario As New UserManagement
    Dim managerDeEventos As New EventoManagement
    Dim managerDeEventoProducto As New EventoProductoManagement
    Dim managerDeCategorias As New CategoriaManagement
    Dim managerDePatrocinadores As New PatrocinadorManagement
    Dim managerDeProductos As New ProductoManagement
    Dim managerDeEventoActividad As New EventoActividadManagement
    Dim managerDeActividades As New ActividadManagement
    Dim managerDeEventoPremio As New EventoPremioManagement
    Dim managerDePremios As New PremioManagement
    Dim managerDeRutas As New RutaManagement
    Dim id_Patrocinador As Integer
    Public CodProducto As Integer
    Public NomProducto As String
    Public NomPatrocinador As String
    Public CodActividad As Integer
    Public NomActividad As String
    Public CodPremio As Integer
    Public NomPremio As String
    Public DescPremio As String
    Public Total As Decimal
    Public IdCategoria As Integer


    Private Sub frmEvento_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        cargarPermisos()
        CargarEntidad()
        CargarComboCategorias()
        CargarListaEventos()
        GenerarIdEvento()

        txtIdEntidad.Enabled = False
        txtIdEvento.Enabled = False
        txtNombreEvento.Focus()
        ToolStripBtnActualizar.Enabled = False
        ToolStripBtnEliminar.Enabled = False

        nombreDelEvento = txtNombreEvento.Text


    End Sub

    'METODOS
    Private Sub cargarPermisos()
        Dim pm As New PermisosManagement
        Dim p As New Permisos

        Dim lista = pm.RetrieveAlls(Of Permisos)


        If (NOMBRE_ROL = "SA" Or NOMBRE_ROL = "ORGANIZADOR") Then
            ToolStripBtnGuardar.Enabled = True
            ToolStripBtnNuevo.Enabled = True
            ToolStripBtnBuscar.Enabled = True
            ToolStripBtnActualizar.Enabled = True
            ToolStripBtnEliminar.Enabled = True

        Else
            For Each obj In lista
                If (obj.Area = "EVENTOS") Then
                    cboCargarPermisos.Items.Add(obj.Nombre)
                End If
            Next

            Dim listaPermisos As New List(Of String)

            For Each item As Object In cboCargarPermisos.Items

                listaPermisos.Add(CStr(item))

            Next

            Dim lst = listaPermisos

            For j As Integer = 0 To lst.Count - 1
                If (lst.Item(j) = "CREAR") Then
                    ToolStripBtnGuardar.Enabled = True
                Else
                    If (ToolStripBtnGuardar.Enabled = True) Then
                    Else
                        ToolStripBtnGuardar.Enabled = False

                    End If
                End If

                If (lst.Item(j) = "BUSCAR") Then
                    ToolStripBtnBuscar.Enabled = True

                Else
                    If (ToolStripBtnBuscar.Enabled = True) Then

                    Else
                        ToolStripBtnBuscar.Enabled = False

                    End If
                End If

                If (lst.Item(j) = "ACTUALIZAR") Then
                    ToolStripBtnActualizar.Enabled = True

                Else
                    If (ToolStripBtnActualizar.Enabled = True) Then

                    Else
                        ToolStripBtnActualizar.Enabled = False

                    End If
                End If

                If (lst.Item(j) = "ELIMINAR") Then
                    ToolStripBtnEliminar.Enabled = True

                Else
                    If (ToolStripBtnEliminar.Enabled = True) Then

                    Else
                        ToolStripBtnEliminar.Enabled = False

                    End If
                End If
            Next

        End If




    End Sub
    Private Sub CargarEntidad()

        Dim user As New User

        user.IdUsuario = USUARIO
        user = managerDeUsuario.Retrieve(user)
        txtIdEntidad.Text = user.IdEntidad

    End Sub
    Private Sub CargarComboCategorias()

        Dim u = managerDeCategorias.RetrieveAllCategorias(Of Categoria)
        For i = 0 To u.Count - 1
            If (cboxCategoria.Items.IndexOf(u.Item(i).NombreCategoria.ToString()) = -1) Then
                cboxCategoria.Items.Add(u.Item(i).NombreCategoria)
            End If
        Next
    End Sub
    Private Sub GenerarIdEvento()
        Try
            Dim cod As Integer
            Dim listaId = managerDeEventos.RetrieveAllEventos(Of Evento)

            For i = 0 To listaId.Count - 1
                If (listaId.Item(i).Estado_Evento = "INACTIVO") Then
                    cod = listaId.Item(i).IdEvento
                Else
                    cod = listaId.Item(i).IdEvento

                End If


            Next
            txtIdEvento.Text = cod + 1
            txtIdEvento.Enabled = False
            txtNombreEvento.Focus()

        Catch ex As ChallengeMeException
            _em.ManageException(ex)

        End Try
    End Sub

    Private Sub LimpiarCampos()

        ' Id evento ?
        txtNombreEvento.Text = ""
        txtDireccionEvento.Text = ""
        txtDescripcionEvento.Text = ""
        picLogo.Image = Nothing

        ' LA RUTA ??????
        cboxCategoria.Text = String.Empty
        txtCupoMaximo.Text = ""
        ' Id Entidad ?
        dateInicioEvento.Text = Date.Now.ToString("dd/MM/yyyy")
        dateFinalEvento.Text = Date.Now.ToString("dd/MM/yyyy")
        dateInicioInscripciones.Text = Date.Now.ToString("dd/MM/yyyy")
        dateFinalInscripciones.Text = Date.Now.ToString("dd/MM/yyyy")
        txtCostoInscripcion.Text = ""
        dgvActividades.Rows.Clear()
        dgvPremios.Rows.Clear()

        txtNombreEvento.Focus()
    End Sub
    Private Sub CargarListaEventos()
        Dim categoria As New Categoria
        dgvEventos.Rows.Clear()

        Dim listaDeEventos = managerDeEventos.RetrieveAllEventos(Of Evento)

        For Each evento As Evento In listaDeEventos
            If (evento.Estado_Evento = "INACTIVO") Then

            Else
                categoria.IdCategoria = evento.IdCategoria

                Dim listaCategorias = managerDeCategorias.RetrieveCategoria(categoria)


                Dim rowEvento =
                        {
                            evento.IdEvento,
                            evento.NombreEvento,
                            listaCategorias.NombreCategoria,
                            evento.FechaInicioEvento,
                            evento.UbicacionEvento
                        }

                dgvEventos.Rows.Add(rowEvento)

            End If



        Next
    End Sub

    Private Sub EliminarEvento()

        Dim u As New Evento

        u.IdEvento = txtIdEventoDos.Text
        u = managerDeEventos.RetrieveEvento(u)

        Try
            If (u Is Nothing) Then
                MessageBox.Show($"El evento con el Id {txtIdEvento.Text} no existe.", "OOPS!", MessageBoxButtons.OK, MessageBoxIcon.Warning)

            Else
                managerDeEventos.DeleteEvento(u)


                LimpiarCampos()

            End If

        Catch ex As ChallengeMeException

            _em.ManageException(ex)

        End Try

        CargarListaEventos()
    End Sub

    ' BOTONES
    Private Sub ToolStripBtnSalir_Click(sender As Object, e As EventArgs) Handles ToolStripBtnSalir.Click
        frmDashBoard.Show()
        Close()
    End Sub

    Private Sub ToolStripBtnGuardar_Click(sender As Object, e As EventArgs) Handles ToolStripBtnGuardar.Click
        Dim n As New Evento
        Dim u As New Evento

        u.IdEvento = txtIdEvento.Text
        u = managerDeEventos.RetrieveEvento(u)

        Try
            If (u Is Nothing) Then
                n.IdEvento = txtIdEvento.Text
                n.NombreEvento = txtNombreEvento.Text
                n.UbicacionEvento = txtDireccionEvento.Text
                n.DescripcionEvento = txtDescripcionEvento.Text
                n.LogoEvento = picLogo.Image

                n.IdCategoria = IdCategoria
                n.CupoEvento = txtCupoMaximo.Text
                n.IdEntidad = txtIdEntidad.Text
                n.FechaInicioEvento = dateInicioEvento.Text
                n.FechaFinalEvento = dateFinalEvento.Text
                n.FechaInicioInscripcion = dateInicioInscripciones.Text
                n.FechaFinalInscripcion = dateFinalInscripciones.Text
                n.CostoInscripcion = txtCostoInscripcion.Text
                '  n.Estado_Evento="ACTIVO"

                If (txtIdEvento.Text.Trim() = "" Or txtNombreEvento.Text.Trim() = "" Or cboxCategoria.SelectedItem = "") Then
                    MessageBox.Show("Por favor verifique que los campos 'ID', 'Nombre' y 'Categoría' esten llenos.", "OOPS!", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Else
                    managerDeEventos.CreateEvento(n)
                    MessageBox.Show("Evento registrado con éxito.", "FELICIDADES!", MessageBoxButtons.OK)
                End If

                LimpiarCampos()

            Else
                MessageBox.Show($"El evento con el Id {txtIdEvento.Text} ya existe.", "OOPS!", MessageBoxButtons.OK, MessageBoxIcon.Warning)

            End If

        Catch ex As ChallengeMeException
            _em.ManageException(ex)
        End Try

        CargarListaEventos()
        GenerarIdEvento()
    End Sub

    Private Sub ToolStripBtnBuscar_Click(sender As Object, e As EventArgs) Handles ToolStripBtnBuscar.Click

        Dim u As New Evento

        u.IdEvento = txtIdEvento.Text
        u = managerDeEventos.RetrieveEvento(u)

        Try
            If (u Is Nothing) Then
                MessageBox.Show($"El evento con el Id {txtIdEvento.Text} no existe.", "OOPS!", MessageBoxButtons.OK, MessageBoxIcon.Warning)

            Else
                txtIdEvento.Enabled = False
                txtNombreEvento.Text = u.NombreEvento
                txtDireccionEvento.Text = u.UbicacionEvento
                txtDescripcionEvento.Text = u.DescripcionEvento
                picLogo.Image = u.LogoEvento

                cboxCategoria.SelectedItem = u.IdCategoria
                txtCupoMaximo.Text = u.CupoEvento
                txtIdEntidad.Text = u.IdEntidad
                dateInicioEvento.Text = u.FechaInicioEvento
                dateFinalEvento.Text = u.FechaFinalEvento
                dateInicioInscripciones.Text = u.FechaInicioInscripcion
                dateFinalInscripciones.Text = u.FechaFinalInscripcion
                txtCostoInscripcion.Text = u.CostoInscripcion

            End If

        Catch ex As ChallengeMeException

            _em.ManageException(ex)

        End Try
    End Sub

    Private Sub ToolStripBtnActualizar_Click(sender As Object, e As EventArgs) Handles ToolStripBtnActualizar.Click

        Dim u As New Evento

        u.IdEvento = txtIdEvento.Text
        u = managerDeEventos.RetrieveEvento(u)

        Try
            If (u Is Nothing) Then
                MessageBox.Show($"El evento con el Id {txtIdEvento.Text} no existe.", "OOPS!", MessageBoxButtons.OK, MessageBoxIcon.Warning)

            Else
                txtIdEntidad.Enabled = False
                txtIdEvento.Enabled = False

                u.IdEvento = txtIdEvento.Text
                u.NombreEvento = txtNombreEvento.Text
                u.UbicacionEvento = txtDireccionEvento.Text
                u.DescripcionEvento = txtDescripcionEvento.Text
                u.LogoEvento = picLogo.Image

                u.IdCategoria = cboxCategoria.SelectedItem
                u.CupoEvento = txtCupoMaximo.Text
                u.IdEntidad = txtIdEntidad.Text
                u.FechaInicioInscripcion = dateInicioEvento.Text
                u.FechaFinalEvento = dateFinalEvento.Text
                u.FechaInicioInscripcion = dateInicioInscripciones.Text
                u.FechaFinalInscripcion = dateFinalInscripciones.Text
                u.CostoInscripcion = txtCostoInscripcion.Text

                If (txtIdEvento.Text.Trim() = "" Or txtNombreEvento.Text.Trim() = "" Or cboxCategoria.SelectedItem = "") Then
                    MessageBox.Show("Por favor verifique que los campos 'ID', 'Nombre' y 'Categoría' esten llenos.", "OOPS!", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Else
                    managerDeEventos.UpdateEvento(u)
                    MessageBox.Show("Evento actualizado con éxito.", "FELICIDADES!", MessageBoxButtons.OK)
                End If

                LimpiarCampos()

            End If

        Catch ex As ChallengeMeException
            _em.ManageException(ex)

        End Try

        CargarListaEventos()
        GenerarIdEvento()
        ToolStripBtnActualizar.Enabled = False
        ToolStripBtnEliminar.Enabled = False
    End Sub


    Private Sub ToolStripBtnNuevo_Click(sender As Object, e As EventArgs) Handles ToolStripBtnNuevo.Click
        LimpiarCampos()
    End Sub

    'Private Sub cboCargarPermisos_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboCargarPermisos.SelectedIndexChanged

    'End Sub

    Private Sub btnAgregarImagen_Click(sender As Object, e As EventArgs) Handles btnAgregarImagen.Click
        Using OpenFileDialog1 As New OpenFileDialog()

            With OpenFileDialog1
                .CheckFileExists = True
                .ShowReadOnly = False
                .Filter = "All Files|*.*|Bitmap Files (*)|*.bmp;*.gif;*.jpg"
                .FilterIndex = 2

                If .ShowDialog = DialogResult.OK Then
                    ' Se muestra la imagen en el control PictureBox
                    picLogo.ImageLocation = .FileName
                End If
            End With

        End Using
    End Sub

    ' GRIDS
    Private Sub lnkAgregarActividad_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles lnkAgregarActividad.LinkClicked
        Dim ModalActividades = New frmModalActividades()
        If (Trim(txtIdEventoDos.Text = "")) Then
            MessageBox.Show("Debe seleccionar un evento de la lista haciendo  clic sobre el Evento", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Error)

        Else
            ModalActividades.txtIdEvento.Text = txtIdEventoDos.Text
            ModalActividades.ShowDialog()
            listarActividadesAgregadas()

        End If

    End Sub

    Private Sub dgvActividades_DoubleClick(sender As Object, e As EventArgs) Handles dgvActividades.DoubleClick

        Dim row = dgvActividades.CurrentCell.RowIndex
        dgvActividades.Rows.RemoveAt(row)

    End Sub

    Private Sub lnkAgregarPatrocinador_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles lnkAgregarPatrocinador.LinkClicked
        Dim ModalEventoProducto = New frmModalEventoProducto()

        If (Trim(txtIdEventoDos.Text = "")) Then
            MessageBox.Show("Debe seleccionar un evento de la lista haciendo  clic sobre el Evento", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Error)

        Else
            ModalEventoProducto.txtIdEvento.Text = txtIdEventoDos.Text
            ModalEventoProducto.ShowDialog()
            listarProductosAgregadosAlEvento()

        End If

    End Sub

    Private Sub dgvPatrocinadores_DoubleClick(sender As Object, e As EventArgs) Handles dgvProductoEnEvento.DoubleClick

        Dim row = dgvProductoEnEvento.CurrentCell.RowIndex
        dgvProductoEnEvento.Rows.RemoveAt(row)

    End Sub

    Private Sub lnkAgregarPremio_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles lnkAgregarPremio.LinkClicked
        Dim ModalPremios = New frmModalPremios()

        If (Trim(txtIdEventoDos.Text = "")) Then
            MessageBox.Show("Debe seleccionar un evento de la lista haciendo  clic sobre el Evento", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Error)

        Else
            ModalPremios.txtIdEvento.Text = txtIdEventoDos.Text
            ModalPremios.ShowDialog()
            listarPremiosAgregados()

        End If





    End Sub

    Private Sub dgvPremios_DoubleClick(sender As Object, e As EventArgs) Handles dgvPremios.DoubleClick

        Dim row = dgvPremios.CurrentCell.RowIndex
        dgvPremios.Rows.RemoveAt(row)

    End Sub

    Private Sub listarProductosAgregadosAlEvento()


        Dim eventoProducto As New EventoProducto

        If (Trim(txtIdEventoDos.Text <> "")) Then
            'Si el textbox codPatrocinador no está vacío significa que el usuario hizo clic en la
            'tabla de patrocinadores para ir a agregarle productos a ese codigo de patrocinador
            'entonces se hace una búsqueda en la tabla de patrocinadorproducto
            'para ver cuales productos están ligados a ese patrocinador en específico
            '---codigo hecho por Erick----

            eventoProducto.IdEvento = txtIdEventoDos.Text
            Dim listaEventoProducto = managerDeEventoProducto.RetrieveAllEventoProductoByIdEvento(Of EventoProducto)(eventoProducto)
            'si la lista trae algo
            If (listaEventoProducto.Count > 0) Then
                dgvProductoEnEvento.Rows.Clear()
                For Each elemento As EventoProducto In listaEventoProducto
                    Dim producto As New Producto
                    CodProducto = elemento.IdProducto
                    producto.IdProducto = CodProducto

                    Dim patrocinador As New Patrocinador
                    id_Patrocinador = elemento.IdPatrocinador
                    patrocinador.IdPatrocinador = id_Patrocinador
                    Total = elemento.ValorTotalProducto

                    Dim listaProductos = managerDeProductos.RetrieveAllByIdProducto(Of Producto)(producto)
                    Dim listaPatrocinadores = managerDePatrocinadores.RetrieveAllPatrocinadoresById(Of Patrocinador)(patrocinador)
                    For Each productos As Producto In listaProductos

                        NomProducto = productos.NombreProducto

                        For Each patrocinadores As Patrocinador In listaPatrocinadores
                            NomPatrocinador = patrocinadores.NombrePatrocinador

                        Next
                    Next
                    If (cboIdProducto.Items.Contains(CodProducto) And cboIdPatrocinador.Items.Contains(id_Patrocinador)) Then

                    Else
                        cboIdProducto.Items.Add(CodProducto)
                        cboIdPatrocinador.Items.Add(id_Patrocinador)

                        dgvProductoEnEvento.Rows.Add(CodProducto, NomProducto, IdPatrocinador, NomPatrocinador, FormatNumber(Total, 2))

                    End If




                Next
                'Se agregan los datos al grid de productos

            End If
        End If

    End Sub

    Private Sub dgvEventos_MouseClick(sender As Object, e As MouseEventArgs) Handles dgvEventos.MouseClick
        If dgvEventos.Rows.Count > 0 Then
            Dim i As Integer
            i = dgvEventos.Rows(0).Selected
            txtIdEventoDos.Text = dgvEventos.CurrentRow.Cells("IdEvento").Value
            buscarEvento()
        End If
        ToolStripBtnActualizar.Enabled = True
        ToolStripBtnEliminar.Enabled = True
    End Sub

    Private Sub txtIdEventoDos_TextChanged(sender As Object, e As EventArgs) Handles txtIdEventoDos.TextChanged
        listarActividadesAgregadas()
        listarProductosAgregadosAlEvento()
        listarPremiosAgregados()

    End Sub

    Private Sub listarActividadesAgregadas()


        Dim eventoActividad As New EventoActividad


        If (Trim(txtIdEventoDos.Text <> "")) Then
            'Si el textbox codPatrocinador no está vacío significa que el usuario hizo clic en la
            'tabla de patrocinadores para ir a agregarle productos a ese codigo de patrocinador
            'entonces se hace una búsqueda en la tabla de patrocinadorproducto
            'para ver cuales productos están ligados a ese patrocinador en específico
            '---codigo hecho por Erick----

            eventoActividad.IdEvento = txtIdEventoDos.Text
            Dim listaEventoActividad = managerDeEventoActividad.RetrieveAllById(Of EventoActividad)(eventoActividad)
            'si la lista trae algo
            If (listaEventoActividad.Count > 0) Then
                For Each elemento As EventoActividad In listaEventoActividad
                    Dim actividad As New Actividad
                    CodActividad = elemento.IdActividad
                    actividad.IdActividad = CodActividad

                    Dim listaActividades = managerDeActividades.RetrieveAllById(Of Actividad)(actividad)
                    For Each actividades As Actividad In listaActividades

                        NomActividad = actividades.NombreActividad

                    Next
                    If (cboNombreActividad.Items.Contains(NomActividad)) Then

                    Else
                        cboNombreActividad.Items.Add(NomActividad)
                        dgvActividades.Rows.Clear()
                        dgvActividades.Rows.Add(CodActividad, NomActividad)

                    End If


                Next
                'Se agregan los datos al grid de productos

            End If
        End If
    End Sub
    Private Sub listarPremiosAgregados()


        Dim eventoPremio As New EventoPremio


        If (Trim(txtIdEventoDos.Text <> "")) Then
            'Si el textbox codPatrocinador no está vacío significa que el usuario hizo clic en la
            'tabla de patrocinadores para ir a agregarle productos a ese codigo de patrocinador
            'entonces se hace una búsqueda en la tabla de patrocinadorproducto
            'para ver cuales productos están ligados a ese patrocinador en específico
            '---codigo hecho por Erick----

            eventoPremio.IdEvento = txtIdEventoDos.Text
            Dim listaEventoPremio = managerDeEventoPremio.RetrieveAllById(Of EventoPremio)(eventoPremio)
            'si la lista trae algo
            If (listaEventoPremio.Count > 0) Then
                '  dgvPremios.Rows.Clear()
                For Each elemento As EventoPremio In listaEventoPremio
                    Dim premio As New Premio
                    CodPremio = elemento.IdPremio
                    premio.IdPremio = CodPremio

                    Dim listaPremios = managerDePremios.RetrieveAllById(Of Premio)(premio)
                    For Each premios As Premio In listaPremios

                        NomPremio = premios.NombrePremio
                        DescPremio = premios.DescripcionPremio

                    Next
                    If (cboPremio.Items.Contains(NomPremio)) Then

                    Else
                        cboPremio.Items.Add(NomPremio)
                        dgvPremios.Rows.Add(CodPremio, NomPremio, DescPremio)
                    End If

                Next
                'Se agregan los datos al grid de productos

            End If
        End If
    End Sub
    Private Sub eliminarActividadEvento()
        Dim eventoActividad As New EventoActividad

        eventoActividad.IdEvento = txtIdEventoDos.Text

        'Se utiliza update ya  que para este formulario se tiene que hacer dos eliminar
        'uno para  poner inactivas todas las actividades que tengan relacion con  las actividades
        ' ligados a un evento
        'y el otro para quitar una actividad en específico del evento ( en la tabla de actividades)
        managerDeEventoActividad.Update(eventoActividad)


    End Sub

    Private Sub eliminarProductoEvento()
        Dim eventoProducto As New EventoProducto

        eventoProducto.IdEvento = txtIdEventoDos.Text

        managerDeEventoProducto.UpdateEventoProducto(eventoProducto)

    End Sub

    Private Sub eliminarPremioEvento()
        Dim eventoPremio As New EventoPremio

        eventoPremio.IdEvento = txtIdEventoDos.Text

        managerDeEventoPremio.Update(eventoPremio)
    End Sub

    Private Sub ToolStripBtnEliminar_Click(sender As Object, e As EventArgs) Handles ToolStripBtnEliminar.Click
        'métodos que inactiva cada una de las actividades,productos y premios de las tablas intermedias entre 
        'el evento y ellas para que se haga el borrado lógico

        eliminarActividadEvento()
        eliminarProductoEvento()
        eliminarPremioEvento()
        EliminarEvento()
        'se listan las tablas de abajo una vez hecho el borrado lógico
        'para que no se muestre mas la información en las tablas
        listarActividadesAgregadas()
        listarProductosAgregadosAlEvento()
        listarPremiosAgregados()
        MessageBox.Show("Evento eliminado satisfactoriamente", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Information)
        CargarListaEventos()
        GenerarIdEvento()
        ToolStripBtnActualizar.Enabled = False
        ToolStripBtnEliminar.Enabled = False
    End Sub

    Private Sub dgvActividades_MouseClick(sender As Object, e As MouseEventArgs) Handles dgvActividades.MouseClick
        If dgvActividades.Rows.Count > 0 Then

            txtIdActividad.Text = dgvActividades.CurrentRow.Cells("IdActividad").Value


        End If
    End Sub

    Private Sub quitarActividadEvento()
        Dim eventoActividad As New EventoActividad

        eventoActividad.IdEvento = txtIdEventoDos.Text
        eventoActividad.IdActividad = txtIdActividad.Text

        managerDeEventoActividad.Delete(eventoActividad)



    End Sub

    Private Sub dgvProductoEnEvento_MouseClick(sender As Object, e As MouseEventArgs) Handles dgvProductoEnEvento.MouseClick
        If dgvProductoEnEvento.Rows.Count > 0 Then

            txtIdProducto.Text = dgvProductoEnEvento.CurrentRow.Cells("IdProducto").Value


        End If
    End Sub

    Private Sub LinkLabel2_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs)


    End Sub

    Private Sub lnkQuitarProductoEvento_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles lnkQuitarProductoEvento.LinkClicked
        Dim i As Integer

        'quito la fila del grid permisos y costo
        i = dgvProductoEnEvento.CurrentRow.Index
        dgvProductoEnEvento.Rows.RemoveAt(i)

        quitarProductoEvento()
        MessageBox.Show("Se ha quitado el producto de la lista de manera satisfactoria", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Information)

    End Sub
    Private Sub quitarProductoEvento()
        Dim eventoProducto As New EventoProducto

        eventoProducto.IdEvento = txtIdEventoDos.Text
        eventoProducto.IdProducto = txtIdProducto.Text

        managerDeEventoProducto.DeleteEventoProducto(eventoProducto)

    End Sub

    Private Sub lnkQuitarActividadEvento_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles lnkQuitarActividadEvento.LinkClicked
        Dim i As Integer

        'quito la fila del grid permisos y costo
        i = dgvActividades.CurrentRow.Index
        dgvActividades.Rows.RemoveAt(i)

        quitarActividadEvento()
        MessageBox.Show("Se ha quitado la actividad de la lista de manera satisfactoria", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub

    Private Sub dgvPremios_MouseClick(sender As Object, e As MouseEventArgs) Handles dgvPremios.MouseClick
        If dgvPremios.Rows.Count > 0 Then

            txtIdPremio.Text = dgvPremios.CurrentRow.Cells("IdPremio").Value


        End If
    End Sub

    Private Sub lnkQuitarPremioEvento_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles lnkQuitarPremioEvento.LinkClicked
        Dim i As Integer

        'quito la fila del grid permisos y costo
        i = dgvPremios.CurrentRow.Index
        dgvPremios.Rows.RemoveAt(i)

        quitarPremioEvento()
        MessageBox.Show("Se ha quitado el premio de la lista de manera satisfactoria", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub
    Private Sub quitarPremioEvento()
        Dim eventoPremio As New EventoPremio
        eventoPremio.IdEvento = txtIdEventoDos.Text
        eventoPremio.IdPremio = txtIdPremio.Text

        managerDeEventoPremio.Delete(eventoPremio)
    End Sub

    Private Sub txtIdActividad_TextChanged(sender As Object, e As EventArgs) Handles txtIdActividad.TextChanged

    End Sub

    Private Sub txtIdProducto_TextChanged(sender As Object, e As EventArgs) Handles txtIdProducto.TextChanged

    End Sub

    Private Sub txtIdPremio_TextChanged(sender As Object, e As EventArgs) Handles txtIdPremio.TextChanged

    End Sub
    Private Sub buscarEvento()
        'BUSCA UN EVENTO UNA VEZ QUE EL USUARIO DIO CLIC SOBRE UN EVENTO
        'EN LA TABLA
        'HECHO POR ERICK

        Dim evento As New Evento

        evento.IdEvento = txtIdEventoDos.Text

        evento = managerDeEventos.RetrieveEvento(evento)
        txtIdEvento.Text = evento.IdEvento
        txtNombreEvento.Text = evento.NombreEvento
        dateInicioEvento.Text = evento.FechaInicioEvento
        dateFinalEvento.Text = evento.FechaFinalEvento
        dateInicioInscripciones.Text = evento.FechaInicioInscripcion
        dateFinalInscripciones.Text = evento.FechaFinalInscripcion
        txtCupoMaximo.Text = evento.CupoEvento
        txtCostoInscripcion.Text = FormatNumber(evento.CostoInscripcion, 2)
        picLogo.Image = evento.LogoEvento
        txtDescripcionEvento.Text = evento.DescripcionEvento
        txtDireccionEvento.Text = evento.UbicacionEvento

        Dim categoria As New Categoria


        Dim listaDeEventos = managerDeEventos.RetrieveAllEventos(Of Evento)

        For Each eventos As Evento In listaDeEventos
            categoria.IdCategoria = eventos.IdCategoria

            Dim listaCategorias = managerDeCategorias.RetrieveCategoria(categoria)

            cboxCategoria.Items.Add(listaCategorias.NombreCategoria)
            cboxCategoria.SelectedIndex = 0
        Next


    End Sub

    Private Sub lnkAgregarCategoria_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles lnkAgregarCategoria.LinkClicked
        Dim Categoria = New frmModalCategoria()


        Categoria.ShowDialog()
        CargarComboCategorias()


    End Sub

    Private Sub cboxCategoria_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboxCategoria.SelectedIndexChanged
        Try

            Dim categoria As New Categoria
            'agarra el nombre del rol que se ha seleccionado del combo de roles
            'y lo pasa a la varia r.Nomnbre_Role
            categoria.NombreCategoria = cboxCategoria.Text

            'se hace la búsqueda en la tabla de roles por medio del nombre del rol
            'para encontrar el id del rol asociado con el nombre del rol que el usuario ha seleccionado
            'del combobox                                                    
            Dim listaCategoria = managerDeCategorias.RetrieveByName(Of Categoria)(categoria)
            For i = 0 To listaCategoria.Count - 1
                'por último se pasa a una caja de texto el id del rol encontrado a través del nombre
                'de ese rol para luego desde el evento change de la caja de texto txtCodRol
                'hacer una busqueda de ese idrol en la tabla TL_ROLE_PERMISO
                'y verificar los idpermisos asignados a ese idrol en dicha tabla para luego
                'hacer una busqueda de esos idpermisos encontrados en ROLE_PERMISO y que han sido
                'asignados a un idrol, en la tabla TBL_PERMISOS y hacer el join para traer el nombre
                'y el area del permiso que han sido aplicados a ese idrol.
                IdCategoria = listaCategoria.Item(i).IdCategoria

            Next

        Catch ex As ChallengeMeException
            _em.ManageException(ex)

        End Try





    End Sub

    Private Sub lnkAgregarRutas_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles lnkAgregarRutas.LinkClicked

        If (nombreDelEvento Like "") Then
            MessageBox.Show("Por favor seleccione el evento al cual desea agregar rutas", "Atencion !")
        Else

            Dim formEventoRuta = New frmEventoRuta()

            formEventoRuta.ShowDialog()
            CargarTablaDeRutasAsignadasAlEvento()

        End If

    End Sub

    Private Sub OnNombreDeEventoChanged(sender As Object, e As EventArgs) Handles txtNombreEvento.TextChanged
        nombreDelEvento = txtNombreEvento.Text
    End Sub

    Private Sub txtIdEvento_TextChanged(sender As Object, e As EventArgs) Handles txtIdEvento.TextChanged
        idDelEvento = txtIdEvento.Text
        CargarTablaDeRutasAsignadasAlEvento()
    End Sub

    Public Sub CargarTablaDeRutasAsignadasAlEvento()

        DataGridViewRutasDelEvento.Rows.Clear()

        Dim listaDeRutasAsignadasAlEvento As List(Of RutaEvento)

        Try
            listaDeRutasAsignadasAlEvento = managerDeRutas.RetrieveAllRutasByIdEvento(Of RutaEvento)(EventoGlobals.idDelEvento)

        Catch ex As ChallengeMeException

        End Try

        If (listaDeRutasAsignadasAlEvento IsNot Nothing) Then

            For Each rutaEvento As RutaEvento In listaDeRutasAsignadasAlEvento

                Dim rowRuta = {
                rutaEvento.idRuta,
                rutaEvento.nombreRuta,
                rutaEvento.direccionRuta
                }

                DataGridViewRutasDelEvento.Rows.Add(rowRuta)

            Next

        End If
    End Sub

End Class