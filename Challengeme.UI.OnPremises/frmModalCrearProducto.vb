Imports Challengeme.ApiCore
Imports Challengeme.Entities

Public Class frmModalCrearProducto

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

    Private Sub frmModalCrearProducto_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        generarIdProducto()
        CargarLista()
        Me.Left = 300
        Me.Top = 100


    End Sub

    Private Sub btnGuardar_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click
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

    Private Sub dgvProducto_MouseClick(sender As Object, e As MouseEventArgs) Handles dgvProducto.MouseClick
        If dgvProducto.Rows.Count > 0 Then
            Dim i As Integer
            i = dgvProducto.Rows(0).Selected
            txtIDProducto.Text = dgvProducto.CurrentRow.Cells("Id_Producto").Value
            txtNombreProducto.Text = dgvProducto.CurrentRow.Cells("Nombre_Producto").Value
            txtCostoProducto.Text = dgvProducto.CurrentRow.Cells("Costo_Producto").Value
            picLogoProducto.Image = dgvProducto.CurrentRow.Cells("Logo_Producto").Value

        End If

    End Sub

    Private Sub txtCostoProducto_TextChanged(sender As Object, e As EventArgs) Handles txtCostoProducto.TextChanged

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
    Private Sub generarIdProducto()

        Dim Cod As Integer
        Try
            Dim listaId = productoManage.RetrieveAllProducto(Of Producto) 'igualo a la lista lo que encontró el procedimiento de listar
            For i As Integer = 0 To listaId.Count - 1 'hago el recorrido por la lista
                If (listaId.Item(i).Estado_Producto = "INACTIVO") Then
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
End Class