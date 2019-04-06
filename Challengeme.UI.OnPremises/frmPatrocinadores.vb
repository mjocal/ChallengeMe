Imports Challengeme.ApiCore
Imports Challengeme.Entities

Public Class frmPatrocinadores

    Public _em As New ExceptionManagement

    Dim managerDePatrocinadores As New PatrocinadorManagement
    Dim managerDePatrocinadorProducto As New PatrocinadorProductoManagement
    Dim managerDeProductos As New ProductoManagement
    Private imageList As New ImageList With {.ImageSize = New Size(24, 24)}

    Private Sub frmPatrocinadores_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CargarLista()
        cargarPermisosPatrocinadores()
        generaridPatrocinador()
        txtNombrePatrocinador.Focus()
        ' listarProductosAgregadosAlPatrocinador()
        txtNombrePatrocinador.CharacterCasing = CharacterCasing.Upper
        ToolStripBtnActualizar.Enabled = False
        ToolStripBtnEliminar.Enabled = False

    End Sub

    Private Sub CargarLista()

        dgvPatrocinadores.Rows.Clear()

        Dim listaDePatrocinadores = managerDePatrocinadores.RetrieveAllPatrocinadores(Of Patrocinador)

        Dim resizedImage As Image

        For Each Patrocinador As Patrocinador In listaDePatrocinadores

            If (Patrocinador.LogoPatrocinador IsNot Nothing) Then
                resizedImage = (Patrocinador.LogoPatrocinador).GetThumbnailImage(48, 48, Nothing, IntPtr.Zero)
            Else
                resizedImage = Nothing
            End If

            Dim rowPatrocinador =
                    {
                        Patrocinador.IdPatrocinador,
                        Patrocinador.NombrePatrocinador,
                        resizedImage
                    }

            dgvPatrocinadores.Rows.Add(rowPatrocinador)

        Next
    End Sub

    Private Sub ButtonUploadImage_Click(sender As Object, e As EventArgs) Handles ButtonUploadImage.Click
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

    Private Sub LimpiarCampos()
        'txtIdPatrocinador.Enabled = True

        txtIdPatrocinador.Text = ""
        txtNombrePatrocinador.Text = ""
       

        'picLogo.Dispose()
        txtIdPatrocinador.Focus()
    End Sub
    Private Sub cargarPermisosPatrocinadores()
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
                If (obj.Area = "PATROCINADORES") Then
                    cboPermisosPatrocinadores.Items.Add(obj.Nombre)
                End If
            Next

            Dim listaPermisos As New List(Of String)

            For Each item As Object In cboPermisosPatrocinadores.Items

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

    Private Sub ToolStripBtnSalvar_Click(sender As Object, e As EventArgs) Handles ToolStripBtnGuardar.Click
        Dim u As New Patrocinador
        erProveedorError.Clear()

        If (Trim(txtNombrePatrocinador.Text = "")) Then
            erProveedorError.SetError(txtNombrePatrocinador, "Debe indicar el nombre del patrocinador que desea Guardar")
            txtNombrePatrocinador.Focus()
            Return
        End If
        If (picLogo.Image Is Nothing) Then
            erProveedorError.SetError(picLogo, "Debe agregar un logo al patrocinador")

            Return
        End If



        Try


            u.IdPatrocinador = txtIdPatrocinador.Text
            u.NombrePatrocinador = txtNombrePatrocinador.Text
            u.LogoPatrocinador = picLogo.Image


            managerDePatrocinadores.CreatePatrocinador(u)

            'una vez creado el patrocinador se le obliga a que ligue productos a ese patrocinador
            'por lo que le pregunta inmediantamente después que guardó el patrocinador
            'si desea agregarle productos a ese patrocinador para mandarle al modal de productos
            'el idpatrocinador que se acaba de crear
            '----- funcionalidad creada por Erick-------
            Dim Resp As String = MessageBox.Show("Patrocinador registrado con éxito, desea ligar productos al patrocinador?", "Atención", MessageBoxButtons.YesNo, MessageBoxIcon.Information)
            If Resp = 6 Then
                frmModalProducto.Show()
                frmModalProducto.txtIdPatrocinador.Text = txtCodPatrocinador.Text

            Else
                'no hace nada y se queda en el formulario esperando a que se le asignen
                'permisos al rol

            End If




        Catch ex As ChallengeMeException

            _em.ManageException(ex)

        End Try

        CargarLista()
    End Sub

    Private Sub ToolStripBtnBuscar_Click(sender As Object, e As EventArgs) Handles ToolStripBtnBuscar.Click
        Dim u As New Patrocinador

        'Falta validar si el campo esta nulo que muestre error, porque se esta cayendo

        u.IdPatrocinador = txtIdPatrocinador.Text
        u = managerDePatrocinadores.RetrievePatrocinador(u)

        Try
            If (u Is Nothing) Then

                MessageBox.Show($"El patrocinador con el Id {txtIdPatrocinador.Text} no existe.", "OOPS!", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                txtIdPatrocinador.Text = ""
                txtIdPatrocinador.Focus()

            Else
                txtIdPatrocinador.Enabled = False
                txtNombrePatrocinador.Text = u.NombrePatrocinador

                picLogo.Image = u.LogoPatrocinador
            End If

        Catch ex As ChallengeMeException

            _em.ManageException(ex)

        End Try
    End Sub

    Private Sub ToolStripBtnActualizar_Click(sender As Object, e As EventArgs) Handles ToolStripBtnActualizar.Click
        Dim u As New Patrocinador

        erProveedorError.Clear()

        If (Trim(txtNombrePatrocinador.Text = "")) Then
            erProveedorError.SetError(txtNombrePatrocinador, "Debe indicar el nombre del patrocinador que desea Guardar")
            txtNombrePatrocinador.Focus()
            Return
        End If
        If (picLogo.Image Is Nothing) Then
            erProveedorError.SetError(picLogo, "Debe agregar un logo al patrocinador")

            Return
        End If

        Try



            u.IdPatrocinador = txtIdPatrocinador.Text
            u.NombrePatrocinador = txtNombrePatrocinador.Text

            u.LogoPatrocinador = picLogo.Image


            managerDePatrocinadores.UpdatePatrocinador(u)
            MessageBox.Show("Patrocinador actualizado con exito.", "FELICIDADES!", MessageBoxButtons.OK)


            LimpiarCampos()



        Catch ex As ChallengeMeException
            _em.ManageException(ex)

        End Try

        CargarLista()
        generaridPatrocinador()
         ToolStripBtnActualizar.Enabled = False
        ToolStripBtnEliminar.Enabled = False

    End Sub

    Private Sub ToolStripBtnNuevo_Click(sender As Object, e As EventArgs) Handles ToolStripBtnNuevo.Click
        LimpiarCampos()
    End Sub

    Private Sub ToolStripBtnSalir_Click(sender As Object, e As EventArgs) Handles ToolStripBtnSalir.Click
        frmDashBoard.Show()
        Close()
    End Sub


    Private Sub generaridPatrocinador()
        Try

            Dim Cod As Integer
            Dim listaId = managerDePatrocinadores.RetrieveAllPatrocinadores(Of Patrocinador) 'igualo a la lista lo que encontró el procedimiento de listar

            For i As Integer = 0 To listaId.Count - 1 'hago el recorrido por la lista
                If(listaId.Item(i).Estado_Patrocinador="INACTIVO")Then
                     Cod = listaId.Item(i).IdPatrocinador
                Else
                     Cod = listaId.Item(i).IdPatrocinador
                End If
               
                'hace un recorrido por toda la lista y encuenta el ultimo codigo ingresado

            Next
            txtIdPatrocinador.Text = Cod + 1 'a ese ultimo codigo ingresado le suma uno y ya tenemos el codigo sgte.
            txtIdPatrocinador.Enabled = False
            txtNombrePatrocinador.Focus()

        Catch ex As ChallengeMeException
            _em.ManageException(ex)

        End Try
    End Sub

    Private Sub ToolStripBtnEliminar_Click(sender As Object, e As EventArgs) Handles ToolStripBtnEliminar.Click

        Dim patrocinador As New Patrocinador
        

        patrocinador.IdPatrocinador = txtIdPatrocinador.Text
       

        patrocinador = managerDePatrocinadores.RetrievePatrocinador(patrocinador)

        Try
            If (patrocinador Is Nothing) Then
                MessageBox.Show($"El patrocinador con el Id {txtIdPatrocinador.Text} no existe.", "OOPS!", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                txtIdPatrocinador.Text = ""
                txtIdPatrocinador.Focus()

            Else
                managerDePatrocinadores.DeletePatrocinador(patrocinador)
                Dim patrocinadorProducto As New PatrocinadorProducto
                 patrocinadorProducto.idPatrocinador=txtIdPatrocinador.Text
                patrocinadorProducto=managerDePatrocinadorProducto.Retrieve(patrocinadorProducto)
                If(patrocinadorProducto Is Nothing)Then


                Else
                     managerDePatrocinadorProducto.Delete(patrocinadorProducto)

                End If
               
                MessageBox.Show("Patrocinador eliminado con éxito.", "FELICIDADES!", MessageBoxButtons.OK)

                LimpiarCampos()

            End If

        Catch ex As ChallengeMeException
            _em.ManageException(ex)

        End Try

        CargarLista()
        listarProductosAgregadosAlPatrocinador()
        generaridPatrocinador()
         ToolStripBtnActualizar.Enabled = False
        ToolStripBtnEliminar.Enabled = False

    End Sub
    Private Sub listarProductosAgregadosAlPatrocinador()
        dgvProductosEnPatrocinador.Rows.Clear()
        Dim patrocinadorProducto As New PatrocinadorProducto
        dgvProductosEnPatrocinador.Rows.Clear()
        If (Trim(txtCodPatrocinador.Text <> "")) Then
            'Si el textbox codPatrocinador no está vacío significa que el usuario hizo clic en la
            'tabla de patrocinadores para ir a agregarle productos a ese codigo de patrocinador
            'entonces se hace una búsqueda en la tabla de patrocinadorproducto
            'para ver cuales productos están ligados a ese patrocinador en específico
            '---codigo hecho por Erick----

            patrocinadorProducto.idPatrocinador = txtCodPatrocinador.Text
            Dim listaPatrocinadorProducto = managerDePatrocinadorProducto.RetrieveAllByIdPatrocinador(Of PatrocinadorProducto)(patrocinadorProducto)
            'si la lista trae algo
            If (listaPatrocinadorProducto.Count > 0) Then
                For Each elemento As PatrocinadorProducto In listaPatrocinadorProducto
                    Dim producto As New Producto
                    Dim idProducto = elemento.idProducto
                    producto.IdProducto = idProducto

                    Dim listaProductosAMostrar = managerDeProductos.RetrieveAllByIdProducto(Of Producto)(producto)
                    For Each productos As Producto In listaProductosAMostrar
                        Dim rowProducto = {
                        productos.NombreProducto,
                        productos.CostoProducto.ToString("00.00")
                        }




                        dgvProductosEnPatrocinador.Rows.Add(rowProducto)

                    Next


                Next

            Else



            End If


        Else
            'si no hizo clic en la tabla de patrocinadores, significa que el usuario está agregando un
            'nuevo usuario por lo que tenemos que obtener el idpatrocinador para poder hacer el retrive
            'filtrado por el idpatrocinador
            'por lo que tomamos el ultimo numero de patrocinador que sigue y le restamos uno
            'para saber cual fue el id patrocinador que se creó de último
            '--- codigo hecho por Erick----
            Dim idPatrocinador = txtIdPatrocinador.Text - 1
            patrocinadorProducto.idPatrocinador = idPatrocinador
            Dim listaPatrocinadorProducto = managerDePatrocinadorProducto.RetrieveAllByIdPatrocinador(Of PatrocinadorProducto)(patrocinadorProducto)
            'si la lista trae algo
            If (listaPatrocinadorProducto.Count > 0) Then
                For Each elemento As PatrocinadorProducto In listaPatrocinadorProducto
                    Dim producto As New Producto
                    Dim idProducto = elemento.idProducto
                    producto.IdProducto = idProducto

                    Dim listaProductosAMostrar = managerDeProductos.RetrieveAllByIdProducto(Of Producto)(producto)
                    For Each productos As Producto In listaProductosAMostrar
                        Dim rowProducto = {
                        productos.NombreProducto,
                        productos.CostoProducto
                        }




                        dgvProductosEnPatrocinador.Rows.Add(rowProducto)

                    Next


                Next

            End If



        End If







    End Sub

    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        If (Trim(txtCodPatrocinador.Text) = "") Then
            MessageBox.Show("Debe seleccionar un patrocinador de la lista haciendo doble clic sobre el patrocinador", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Error)

        Else
            Dim ModalProducto = New frmModalProducto()
            ModalProducto.txtCodPatrocinador.Text = txtCodPatrocinador.Text
            ModalProducto.ShowDialog()
            listarProductosAgregadosAlPatrocinador()
        End If

    End Sub

    Private Sub dgvPatrocinadores_MouseClick(sender As Object, e As MouseEventArgs) Handles dgvPatrocinadores.MouseClick
        If dgvPatrocinadores.Rows.Count > 0 Then
            Dim i As Integer
            i = dgvPatrocinadores.Rows(0).Selected
            txtCodPatrocinador.Text = dgvPatrocinadores.CurrentRow.Cells("IdPatrocinador").Value
            txtIdPatrocinador.Text = dgvPatrocinadores.CurrentRow.Cells("IdPatrocinador").Value
            txtNombrePatrocinador.Text = dgvPatrocinadores.CurrentRow.Cells("NombrePatrocinador").Value
            picLogo.Image = dgvPatrocinadores.CurrentRow.Cells("LogoPatrocinador").Value

        End If
        ToolStripBtnActualizar.Enabled = True
        ToolStripBtnEliminar.Enabled = True
    End Sub

    Private Sub dgvPatrocinadores_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvPatrocinadores.CellContentClick

    End Sub

    Private Sub dgvProductosEnPatrocinador_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvProductosEnPatrocinador.CellContentClick

    End Sub

    Private Sub frmPatrocinadores_MouseHover(sender As Object, e As EventArgs) Handles MyBase.MouseHover

    End Sub

    Private Sub frmPatrocinadores_ChangeUICues(sender As Object, e As UICuesEventArgs) Handles MyBase.ChangeUICues

    End Sub

    Private Sub frmPatrocinadores_MdiChildActivate(sender As Object, e As EventArgs) Handles MyBase.MdiChildActivate

    End Sub

    Private Sub SeleccionarLogoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SeleccionarLogoToolStripMenuItem.Click
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

    Private Sub txtCodPatrocinador_TextChanged(sender As Object, e As EventArgs) Handles txtCodPatrocinador.TextChanged

        listarProductosAgregadosAlPatrocinador()
    End Sub
End Class