Imports Challengeme.ApiCore
Imports Challengeme.Entities
Imports System.Text
Public Class frmProducto
    Public _em As New ExceptionManagement
    Dim productoManage As New ProductoManagement ' PONER NOMBRE SIGNIFICATIVO
    Dim producto As New Producto
    Dim permisosManage As New PermisosManagement
    Dim permiso As New Permisos
    Dim managerDePatrocinadorProducto As New PatrocinadorProductoManagement
    Private imageList As New ImageList With {.ImageSize = New Size(24, 24)}
    Private Sub CargarLista()

        dgvProducto.Rows.Clear()

        Dim listaProductos = productoManage.RetrieveAllProducto(Of Producto)

        Dim resizedImage As Image
        For Each elemento As Producto In listaProductos
            If (elemento.LogoProducto IsNot Nothing) Then
                resizedImage = (elemento.LogoProducto).GetThumbnailImage(48, 48, Nothing, IntPtr.Zero)
            Else
                resizedImage = Nothing
            End If
            Dim rowProducto = {
                elemento.IdProducto,
                elemento.NombreProducto,
                elemento.CostoProducto,
                resizedImage
                }
            dgvProducto.Rows.Add(rowProducto)
        Next
        '  LimpiarCampos()
    End Sub
    Private Sub LimpiarCampos()
        txtIDProducto.Text = ""
        txtNombreProducto.Text = ""
        txtCostoProducto.Text = ""
        'picLogoProducto = Nothing
        txtIDProducto.Focus()

    End Sub
    Private Sub btnAgregarLogo_Click(sender As Object, e As EventArgs) Handles btnAgregarLogo.Click
        Using OpenFileDialog1 As New OpenFileDialog()

            With OpenFileDialog1
                .CheckFileExists = True
                .ShowReadOnly = False
                .Filter = "All Files|*.*|Bitmap Files (*)|*.bmp;*.gif;*.jpg"
                .FilterIndex = 2

                If .ShowDialog = DialogResult.OK Then
                    ' Mostramos la imagen en el control PictureBox
                    picLogoProducto.ImageLocation = .FileName
                End If
            End With

        End Using
    End Sub
    Private Function VerificarCampos() As Boolean
        Dim var As Boolean = False

        'If (Trim(txtIDProducto.Text) = "") Then
        '    MessageBox.Show("El nombre del permiso no puede estar vacío", "Atención..!", MessageBoxButtons.OK, MessageBoxIcon.Error)
        '    txtNombre.Focus
        'End If

        Return var
    End Function
    Private Sub frmProducto_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        CargarLista()
        cargarPermisosProductos()
        generarIdProducto()
        ToolStripBtnActualizar.Enabled = False
        ToolStripBtnEliminar.Enabled = False
    End Sub
    'Events of the Forms
    'Only Numbers
    Private Sub txtIDProducto_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtIDProducto.KeyPress
       
    End Sub
    'Private Sub txtCostoProducto_KeyPress(sender As Object, e As KeyPressEventArgs)
    '    If Char.IsDigit(e.KeyChar) Then
    '        e.Handled = False
    '    ElseIf Char.IsControl(e.KeyChar) Then
    '        e.Handled = False
    '    ElseIf e.KeyChar = "." And Not txtCostoProducto.Text.IndexOf(".") Then
    '        e.Handled = True
    '    ElseIf e.KeyChar = "." Then
    '        e.Handled = False
    '    Else
    '        e.Handled = True
    '    End If
    'End Sub

    'Private Sub txtCantidadProducto_KeyPress(sender As Object, e As KeyPressEventArgs)
    '    If Char.IsDigit(e.KeyChar) Then
    '        e.Handled = False
    '    ElseIf Char.IsControl(e.KeyChar) Then
    '        e.Handled = False
    '    Else
    '        e.Handled = True
    '    End If
    'End Sub
    'Only Letters
    Private Sub txtNombreProducto_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtNombreProducto.KeyPress
       
    End Sub
    'Private Sub cbTipoProducto_SelectedIndexChanged(sender As Object, e As EventArgs)
    '    If cbTipoProducto.Text = "Efectivo" Then
    '        txtCantidadProducto.Enabled = False
    '        txtCantidadProducto.Text = 1
    '    Else
    '        txtCantidadProducto.Enabled = True
    '        txtCantidadProducto.Text = ""
    '    End If
    'End Sub
    Private Sub ToolStripBtnGuardar_Click(sender As Object, e As EventArgs) Handles ToolStripBtnGuardar.Click
        Dim nuevoProducto As New Producto
        erProveedorError.Clear()

        If (Trim(txtNombreProducto.Text = "")) Then
            erProveedorError.SetError(txtNombreProducto, "Debe indicar el nombre del producto que desea Guardar")
            txtNombreProducto.Focus()
            Return
        End If
        If (Trim(txtCostoProducto.Text = "")) Then
            erProveedorError.SetError(txtCostoProducto, "Debe indicar el costo del producto que desea Guardar")
            txtCostoProducto.Focus()
            Return
        End If

        If (picLogoProducto.Image Is Nothing) Then
            erProveedorError.SetError(picLogoProducto, "Debe agregar un logo al producto")

            Return
        End If

        ' producto.IdProducto = txtIDProducto.Text
        'producto = productoManage.RetrieveProducto(producto)

        Try

            'If (producto Is Nothing) Then

            nuevoProducto.IdProducto = txtIDProducto.Text
            nuevoProducto.NombreProducto = txtNombreProducto.Text
            nuevoProducto.CostoProducto = txtCostoProducto.Text
            nuevoProducto.LogoProducto = picLogoProducto.Image





            productoManage.CreateProducto(nuevoProducto)
            MessageBox.Show("Producto registrado con exito.", "FELICIDADES!", MessageBoxButtons.OK)
            ' End If


        Catch ex As ChallengeMeException

            _em.ManageException(ex)

        End Try
        'End If
        LimpiarCampos()
        CargarLista()
        generarIdProducto()
    End Sub
    Private Sub ToolStripBtnNuevo_Click(sender As Object, e As EventArgs) Handles ToolStripBtnNuevo.Click
        LimpiarCampos()
        CargarLista()
        ToolStripBtnActualizar.Enabled = False
        ToolStripBtnEliminar.Enabled = False
    End Sub
    Private Sub ToolStripBtnSalir_Click(sender As Object, e As EventArgs) Handles ToolStripBtnSalir.Click
        frmDashBoard.Show()
        Me.Close()
    End Sub
    Private Sub cargarPermisosProductos()


        Dim lista = permisosManage.RetrieveAlls(Of Permisos)

        If (NOMBRE_ROL = "SA" Or NOMBRE_ROL = "ORGANIZADOR") Then
            ToolStripBtnGuardar.Enabled = True
            ToolStripBtnNuevo.Enabled = True
            ToolStripBtnBuscar.Enabled = True
            ToolStripBtnActualizar.Enabled = True
            ToolStripBtnEliminar.Enabled = True

        Else
            For Each obj In lista
                If (obj.Area = "PRODUCTOS") Then
                    cboPermisosProductos.Items.Add(obj.Nombre)
                End If
            Next

            Dim listaPermisos As New List(Of String)

            For Each item As Object In cboPermisosProductos.Items

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
    Private Sub ToolStripBtnActualizar_Click(sender As Object, e As EventArgs) Handles ToolStripBtnActualizar.Click
        erProveedorError.Clear()

        If (Trim(txtNombreProducto.Text = "")) Then
            erProveedorError.SetError(txtNombreProducto, "Debe indicar el nombre del producto que desea Guardar")
            txtNombreProducto.Focus()
            Return
        End If
        If (Trim(txtCostoProducto.Text = "")) Then
            erProveedorError.SetError(txtCostoProducto, "Debe indicar el costo del producto que desea Guardar")
            txtCostoProducto.Focus()
            Return
        End If

        If (picLogoProducto.Image Is Nothing) Then
            erProveedorError.SetError(picLogoProducto, "Debe agregar un logo al producto")

            Return
        End If

        Try

            producto.NombreProducto = txtNombreProducto.Text
            producto.CostoProducto = txtCostoProducto.Text
            producto.LogoProducto = picLogoProducto.Image


            productoManage.UpdateProducto(producto)
            MessageBox.Show("Producto actualizado con exito.", "FELICIDADES!", MessageBoxButtons.OK)

            LimpiarCampos()

        Catch ex As ChallengeMeException
            _em.ManageException(ex)
        End Try

        LimpiarCampos()
        CargarLista()
         ToolStripBtnActualizar.Enabled = False
        ToolStripBtnEliminar.Enabled = False
    End Sub
    Private Sub ToolStripBtnEliminar_Click(sender As Object, e As EventArgs) Handles ToolStripBtnEliminar.Click
        Dim patrocinadorProducto As New PatrocinadorProducto
        erProveedorError.Clear()

        

        Dim result As Integer = MessageBox.Show("Desea Eliminar El Registro", "¡CONFIRMACIÓN!", MessageBoxButtons.YesNo)
        If result = DialogResult.No Then
            MessageBox.Show("Proceso Cancelado")
        ElseIf result = DialogResult.Yes Then
            producto.IdProducto = txtIDProducto.Text
            patrocinadorProducto.idProducto=txtIDProducto.Text
            producto = productoManage.RetrieveProducto(producto)
            Try
                If (producto Is Nothing) Then
                    MessageBox.Show($"El Producto con el Id {txtIDProducto.Text} no existe.", "OOPS!", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                    txtIDProducto.Text = ""
                    txtIDProducto.Focus()
                Else
                    productoManage.DeleteProducto(producto)
                    patrocinadorProducto=managerDePatrocinadorProducto.Retrieve(patrocinadorProducto)

                    If(patrocinadorProducto Is Nothing)Then


                    Else
                        managerDePatrocinadorProducto.Update(patrocinadorProducto)
                    End If
                    
                    MessageBox.Show("Producto eliminado con exito.", "FELICIDADES!", MessageBoxButtons.OK)
                    CargarLista()
                    LimpiarCampos()
                End If
            Catch ex As ChallengeMeException
                _em.ManageException(ex)
            End Try
        End If
        generarIdProducto()
        CargarLista()
         ToolStripBtnActualizar.Enabled = False
        ToolStripBtnEliminar.Enabled = False

    End Sub
    Private Sub dgvProducto_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvProducto.CellClick
        Try
            Dim fila As Integer = dgvProducto.CurrentRow.Index
            txtIDProducto.Text = dgvProducto(0, fila).Value.ToString()
            txtNombreProducto.Text = dgvProducto(1, fila).Value.ToString()
            txtCostoProducto.Text = dgvProducto(2, fila).Value.ToString()
            picLogoProducto.Image = dgvProducto(3, fila).Value
            ToolStripBtnActualizar.Enabled = True
            ToolStripBtnEliminar.Enabled = True
        Catch ex As Exception

        End Try

    End Sub
    Private Sub buscarProducto()
        Dim producto As New Producto
        
            Try
               
                dgvProducto.Rows.Clear()
                Dim listaProductos = productoManage.RetrieveByName(Of Producto)(producto)

                Dim resizedImage As Image
                For Each elemento As Producto In listaProductos
                    If (elemento.LogoProducto IsNot Nothing) Then
                        resizedImage = (elemento.LogoProducto).GetThumbnailImage(48, 48, Nothing, IntPtr.Zero)
                    Else
                        resizedImage = Nothing
                    End If
                    Dim rowProducto = {
                        elemento.IdProducto,
                        elemento.NombreProducto,
                        elemento.CostoProducto,
                        resizedImage
                        }
                    dgvProducto.Rows.Add(rowProducto)
                Next
            Catch ex As ChallengeMeException
                _em.ManageException(ex)
            End Try
       
    End Sub
    Private Sub txtBuscar_TextChanged(sender As Object, e As EventArgs) 
        buscarProducto()
    End Sub

    Private Sub txtCostoProducto_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtCostoProducto.KeyPress
        If Char.IsDigit(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        ElseIf e.KeyChar = "." And Not txtCostoProducto.Text.IndexOf(".") Then
            e.Handled = True
        ElseIf e.KeyChar = "." Then
            e.Handled = False
        Else
            e.Handled = True
        End If
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
                    picLogoProducto.ImageLocation = .FileName
                End If
            End With

        End Using
    End Sub
    Private Sub generarIdProducto()

        Dim Cod As Integer
        Try
            Dim listaId = productoManage.RetrieveAllProducto(Of Producto) 'igualo a la lista lo que encontró el procedimiento de listar
            For i As Integer = 0 To listaId.Count - 1 'hago el recorrido por la lista
                If(listaId.Item(i).Estado_Producto="INACTIVO")Then
                    Cod = listaId.Item(i).IdProducto

                Else
                     Cod = listaId.Item(i).IdProducto

                End If
               
                'hace un recorrido por toda la lista y encuenta el ultimo codigo ingresado

            Next
            txtIDProducto.Text = Cod + 1 'a ese ultimo codigo ingresado le suma uno y ya tenemos el codigo sgte.
            txtIDProducto.Enabled = False

        Catch ex As ChallengeMeException
            _em.ManageException(ex)
        End Try
    End Sub

    Private Sub pbLogo_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub dgvProducto_MouseClick(sender As Object, e As MouseEventArgs) Handles dgvProducto.MouseClick
        If dgvProducto.Rows.Count > 0 Then
            Dim i As Integer
            i = dgvProducto.Rows(0).Selected
            txtIDProducto.Text = dgvProducto.CurrentRow.Cells("Id_Producto").Value
            txtNombreProducto.Text = dgvProducto.CurrentRow.Cells("Nombre_Producto").Value
            txtCostoProducto.Text = dgvProducto.CurrentRow.Cells("Costo_Producto").Value
            picLogoProducto.Image = dgvProducto.CurrentRow.Cells("Logo_Producto").Value

        End If
        ToolStripBtnActualizar.Enabled = True
        ToolStripBtnEliminar.Enabled = True
    End Sub

    Private Sub txtNombreProducto_TextChanged(sender As Object, e As EventArgs) Handles txtNombreProducto.TextChanged

    End Sub
End Class