Imports Challengeme.ApiCore
Imports Challengeme.Entities

Public Class frmEntidad

    Public _em As New ExceptionManagement

    Dim managerDeEntidades As New EntidadManagement

    Private imageList As New ImageList With {.ImageSize = New Size(24, 24)}

    Private Sub FrmEntidad_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CargarLista()
        CargarCombo()
        generarIdEntidad()
        txtNombreEntidad.Focus()
        cargarPermisosEntidad()
    End Sub

    Private Sub CargarCombo()

        Dim u = managerDeEntidades.RetrieveAllEntidades(Of Entidad)
        For i = 0 To u.Count - 1
            If (cboxTipo.Items.IndexOf(u.Item(i).TipoEntidad.ToString()) = -1) Then
                cboxTipo.Items.Add(u.Item(i).TipoEntidad)
            End If
        Next
    End Sub
    Private Sub CargarLista()

        DataGridViewEntidades.Rows.Clear()

        Dim listaDeEntidades = managerDeEntidades.RetrieveAllEntidades(Of Entidad)

        Dim resizedImage As Image

        For Each entidad As Entidad In listaDeEntidades

            If (entidad.LogoEntidad IsNot Nothing) Then
                resizedImage = (entidad.LogoEntidad).GetThumbnailImage(48, 48, Nothing, IntPtr.Zero)
            Else
                resizedImage = Nothing
            End If

            Dim rowEntidad =
            {
                entidad.IdEntidad,
                entidad.NombreEntidad,
                entidad.TipoEntidad,
                entidad.NombreComercialEntidad,
                entidad.DireccionEntidad,
                entidad.TelefonoEntidad,
                resizedImage,
                entidad.CorreoEntidad
            }

            DataGridViewEntidades.Rows.Add(rowEntidad)


        Next
    End Sub
    Private Sub LimpiarCampos()

        txtIdEntidad.Text = ""
        txtNombreEntidad.Text = ""
        cboxTipo.Text=""
        txtNombreComercial.Text = ""
        txtDireccion.Text = ""
        txtTelefonoEntidad.Text = ""

        'picLogo.Image = Nothing
        picLogo.Image= Nothing
        txtCorreoEntidad.Text = ""

        txtNombreEntidad.Focus()
    End Sub

    Private Sub FrmEntidad_UploadImage(sender As Object, e As EventArgs) Handles ButtonUploadImage.Click
        Using OpenFileDialog1 As New OpenFileDialog()

            With OpenFileDialog1
                .CheckFileExists = True
                .ShowReadOnly = False
                .Filter = "All Files|*.*|Bitmap Files (*)|*.bmp;*.gif;*.jpg"
                .FilterIndex = 2

                If .ShowDialog = DialogResult.OK Then
                    ' Mostramos la imagen en el control PictureBox
                    picLogo.ImageLocation = .FileName
                End If
            End With

        End Using
    End Sub
    'Private Sub FrmEntidad_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing

    '   ' If e.CloseReason = CloseReason.UserClosing Then
    '        Dim Resp As String =MessageBox.Show("Seguro que desea salir?", "ATENCION",MessageBoxButtons.YesNo,MessageBoxIcon.Warning)
    '                If Resp = 6 Then

    '        frmDashBoard.Show()
    '        'Me.Close()

    '    Else
    '                    'no hace nada y se queda en el formulario esperando a que se le asignen
    '                    'permisos al rol

    '                End If
    '        'Dim result As DialogResult = MessageBox.Show("Seguro que desea salir?", "ATENCION", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning)
    '        'If result <> DialogResult.OK Then
    '        '    e.Cancel = False
    '        'Else
    '        '    e.CloseReason=True 

    '        'End If
    '   ' End If

    'End Sub
    Private Sub DataGridViewEntidades_DoubleClick(sender As Object, e As EventArgs) Handles DataGridViewEntidades.DoubleClick

        Dim i As Integer
        i = DataGridViewEntidades.CurrentRow.Index
        txtIdEntidad.Text = DataGridViewEntidades.Item(0, i).Value
        txtNombreEntidad.Text = DataGridViewEntidades.Item(1, i).Value
        cboxTipo.Text = DataGridViewEntidades.Item(2, i).Value
        txtNombreComercial.Text = DataGridViewEntidades.Item(3, i).Value
        txtDireccion.Text = DataGridViewEntidades.Item(4, i).Value
        txtTelefonoEntidad.Text = DataGridViewEntidades.Item(5, i).Value
        picLogo.Image = DataGridViewEntidades.Item(6, i).Value
        txtCorreoEntidad.Text = DataGridViewEntidades.Item(7, i).Value

        txtIdEntidad.Enabled = False

    End Sub
    Private Sub cargarPermisosEntidad()
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
                If (obj.Area = "EMPRESA") Then
                    cboPermisosEntidad.Items.Add(obj.Nombre)
                End If
            Next

            Dim listaPermisos As New List(Of String)

            For Each item As Object In cboPermisosEntidad.Items

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

    Private Sub ToolStripBtnGuardar_Click(sender As Object, e As EventArgs) Handles ToolStripBtnGuardar.Click

        Dim n As New Entidad
        Dim u As New Entidad

        erProveedorError.Clear()
        If (Trim(txtNombreEntidad.Text = "")) Then
            erProveedorError.SetError(txtNombreEntidad, "El campo nombre de la empresa no puede estar vacío")
            'MessageBox.Show("Debe indicar el Nombre del Usuario que desea Guardar", "Atención..!", MessageBoxButtons.OK, MessageBoxIcon.Error)
            txtNombreEntidad.Focus()
            Return

        End If
        If (Trim(cboxTipo.Text = "")) Then
            erProveedorError.SetError(cboxTipo, "Debe seleccionar un tipo de empresa")
            'MessageBox.Show("Debe indicar el Nombre del Usuario que desea Guardar", "Atención..!", MessageBoxButtons.OK, MessageBoxIcon.Error)

            Return

        End If

        If (Trim(txtNombreComercial.Text = "")) Then
            erProveedorError.SetError(txtNombreComercial, "El campo nombre comercial no puede estar vacío")
            'MessageBox.Show("Debe indicar el Nombre del Usuario que desea Guardar", "Atención..!", MessageBoxButtons.OK, MessageBoxIcon.Error)
            txtNombreEntidad.Focus()
            Return

        End If
        If (Trim(txtDireccion.Text = "")) Then
            erProveedorError.SetError(txtDireccion, "El campo dirección no puede estar vacío")
            'MessageBox.Show("Debe indicar el Nombre del Usuario que desea Guardar", "Atención..!", MessageBoxButtons.OK, MessageBoxIcon.Error)
            txtDireccion.Focus()
            Return

        End If

        If (Trim(txtTelefonoEntidad.Text = "")) Then
            erProveedorError.SetError(txtTelefonoEntidad, "El campo teléfonono puede estar vacío")
            'MessageBox.Show("Debe indicar el Nombre del Usuario que desea Guardar", "Atención..!", MessageBoxButtons.OK, MessageBoxIcon.Error)
            txtNombreEntidad.Focus()
            Return

        End If
        If (picLogo.Image Is Nothing) Then
            erProveedorError.SetError(picLogo, "Debe agregar un logo de la empresa")
            Return

        End If
        If (Trim(txtCorreoEntidad.Text = "")) Then
            erProveedorError.SetError(txtCorreoEntidad, "El campo correo electrónico no puede estar vacío")
            'MessageBox.Show("Debe indicar el Nombre del Usuario que desea Guardar", "Atención..!", MessageBoxButtons.OK, MessageBoxIcon.Error)
            txtCorreoEntidad.Focus()
            Return

        End If

        Try

            'managerDeEntidades.CreateEntidad (New Entidad With 
            '{
            n.IdEntidad = txtIdEntidad.Text
            n.NombreEntidad = txtNombreEntidad.Text
            n.TipoEntidad = cboxTipo.Text
            n.NombreComercialEntidad = txtNombreComercial.Text
            n.DireccionEntidad = txtDireccion.Text
            n.TelefonoEntidad = txtTelefonoEntidad.Text
            n.LogoEntidad = picLogo.Image
            n.CorreoEntidad = txtCorreoEntidad.Text
            '})


            managerDeEntidades.CreateEntidad(n)
            MessageBox.Show("Organización registrada con exito.", "FELICIDADES!", MessageBoxButtons.OK)


            LimpiarCampos()


        Catch ex As ChallengeMeException
            _em.ManageException(ex)
        End Try

        CargarLista()
    End Sub

    Private Sub ToolStripBtnNuevo_Click(sender As Object, e As EventArgs) Handles ToolStripBtnNuevo.Click
        LimpiarCampos()
    End Sub

    Private Sub ToolStripBtnBuscar_Click(sender As Object, e As EventArgs) Handles ToolStripBtnBuscar.Click

        Dim u As New Entidad

        u.IdEntidad = txtIdEntidad.Text
        u = managerDeEntidades.RetrieveEntidad(u)

        Try
            If (u Is Nothing) Then
                MessageBox.Show($"La organización con el Id {txtIdEntidad.Text} no existe.", "OOPS!", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                txtIdEntidad.Text = ""
                txtIdEntidad.Focus()

            Else
                txtIdEntidad.Enabled = False
                txtNombreEntidad.Text = u.NombreEntidad
                cboxTipo.SelectedItem = u.TipoEntidad
                txtNombreComercial.Text = u.NombreComercialEntidad
                txtDireccion.Text = u.DireccionEntidad
                txtTelefonoEntidad.Text = u.TelefonoEntidad
                picLogo.Image = u.LogoEntidad
                txtCorreoEntidad.Text = u.CorreoEntidad

            End If

        Catch ex As ChallengeMeException

            _em.ManageException(ex)

        End Try
    End Sub

    Private Sub ToolStripBtnActualizar_Click(sender As Object, e As EventArgs) Handles ToolStripBtnActualizar.Click

        Dim u As New Entidad

        u.IdEntidad = txtIdEntidad.Text
        u = managerDeEntidades.RetrieveEntidad(u)

        Try
            If (u Is Nothing) Then
                MessageBox.Show($"La organización con el Id {txtIdEntidad.Text} no existe.", "OOPS!", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                txtIdEntidad.Text = ""
                txtIdEntidad.Focus()

            Else
                txtIdEntidad.Enabled = False

                u.IdEntidad = txtIdEntidad.Text
                u.NombreEntidad = txtNombreEntidad.Text
                u.TipoEntidad = cboxTipo.SelectedItem
                u.NombreComercialEntidad = txtNombreComercial.Text
                u.DireccionEntidad = txtDireccion.Text
                u.TelefonoEntidad = txtTelefonoEntidad.Text
                u.LogoEntidad = picLogo.Image
                u.CorreoEntidad = txtCorreoEntidad.Text

                If (txtIdEntidad.Text.Trim() = "" Or txtNombreEntidad.Text.Trim() = "" Or cboxTipo.SelectedItem = "") Then
                    MessageBox.Show("Por favor verifique que los campos 'ID', 'Nombre' y 'Tipo' esten llenos.", "OOPS!", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Else
                    managerDeEntidades.UpdateEntidad(u)
                    MessageBox.Show("Organización actualizada con exito.", "FELICIDADES!", MessageBoxButtons.OK)
                End If

                LimpiarCampos()

            End If

        Catch ex As ChallengeMeException
            _em.ManageException(ex)

        End Try

        CargarLista()
    End Sub

    Private Sub ToolStripBtnEliminar_Click(sender As Object, e As EventArgs) Handles ToolStripBtnEliminar.Click

        Dim u As New Entidad

        u.IdEntidad = txtIdEntidad.Text
        u = managerDeEntidades.RetrieveEntidad(u)

        Try
            If (u Is Nothing) Then
                MessageBox.Show($"La organización con el Id {txtIdEntidad.Text} no existe.", "OOPS!", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                txtIdEntidad.Text = ""
                txtIdEntidad.Focus()

            Else
                managerDeEntidades.DeleteEntidad(u)
                MessageBox.Show("Organización eliminada con exito.", "FELICIDADES!", MessageBoxButtons.OK)

                LimpiarCampos()

            End If

        Catch ex As ChallengeMeException

            _em.ManageException(ex)

        End Try

        CargarLista()
    End Sub

    Private Sub ToolStripBtnSalir_Click(sender As Object, e As EventArgs) Handles ToolStripBtnSalir.Click
        Me.Close()
    End Sub

    Private Sub picLogo_Click(sender As Object, e As EventArgs) Handles picLogo.Click

    End Sub
    Private Sub generarIdEntidad()

        Dim Cod As Integer
        Try
            Dim listaId = managerDeEntidades.RetrieveAllEntidades(Of Entidad) 'igualo a la lista lo que encontró el procedimiento de listar
            For i As Integer = 0 To listaId.Count - 1 'hago el recorrido por la lista
                If(listaId.Item(i).Estado_Entidad="INACTIVO")Then
                    Cod = listaId.Item(i).IdEntidad
                Else
                    Cod = listaId.Item(i).IdEntidad

                End If
                
                'hace un recorrido por toda la lista y encuenta el ultimo codigo ingresado

            Next
            txtIdEntidad.Text = Cod + 1 'a ese ultimo codigo ingresado le suma uno y ya tenemos el codigo sgte.
            txtIdEntidad.Enabled = False

        Catch ex As ChallengeMeException
            _em.ManageException(ex)
        End Try
    End Sub

    Private Sub SeleccionarFotografíaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SeleccionarFotografíaToolStripMenuItem.Click
        Using OpenFileDialog1 As New OpenFileDialog()

            With OpenFileDialog1
                .CheckFileExists = True
                .ShowReadOnly = False
                .Filter = "All Files|*.*|Bitmap Files (*)|*.bmp;*.gif;*.jpg"
                .FilterIndex = 2

                If .ShowDialog = DialogResult.OK Then
                    ' Mostramos la imagen en el control PictureBox
                    picLogo.ImageLocation = .FileName
                End If
            End With

        End Using
    End Sub
End Class