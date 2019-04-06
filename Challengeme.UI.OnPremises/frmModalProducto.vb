Imports Challengeme.ApiCore
Imports Challengeme.Entities


Public Class frmModalProducto
    Dim _em As New ExceptionManagement
    Dim manejadorDeProductos As New ProductoManagement
    Dim manejadorPatrocinadorProducto As New PatrocinadorProductoManagement
    Public NomProducto As String
    Public CostoProducto As Double
    Public codPatrocinador As Integer
    Public codPermisoAquitar As Integer
    


    Private Sub frmModalProducto_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        listarProductos()
         txtProducto.CharacterCasing = CharacterCasing.Upper
         Me.Left = 350
         Me.Top=175

    End Sub
    Private Sub listarProductos()
        dgvProductos.Rows.Clear()

        Dim listaProductos = manejadorDeProductos.RetrieveAllProducto(Of Producto)


        For Each elemento As Producto In listaProductos

            Dim rowProducto = {
               elemento.IdProducto,
               elemento.NombreProducto,
               elemento.CostoProducto.ToString("00.00")
               }

            dgvProductos.Rows.Add(rowProducto)
        Next

    End Sub

    Private Sub btnPasarProducto_Click(sender As Object, e As EventArgs) Handles btnPasarProducto.Click
        If (Trim(txtIdProducto.Text = "")) Then
            'se le obliga al usuario a seleccionar un producto de la lista para que sea agregado 
            MessageBox.Show("Debe seleccionar un producto de la lista", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Error)

        Else
            dgvProductoAgregado.Rows.Add(txtIdProducto.Text, NomProducto, CostoProducto)
           

        End If


        txtIdProducto.Text = ""

    End Sub

    Private Sub dgvProductos_MouseClick(sender As Object, e As MouseEventArgs) Handles dgvProductos.MouseClick
        'If dgvProductos.SelectedItems.Count > 0 Then
        If dgvProductos.Rows.Count > 0 Then

            txtIdProducto.Text = dgvProductos.CurrentRow.Cells("Id_Producto").Value
            NomProducto = dgvProductos.CurrentRow.Cells("Producto").Value
            CostoProducto = dgvProductos.CurrentRow.Cells("Costo").Value




        End If

    End Sub

    Private Sub txtProducto_TextChanged(sender As Object, e As EventArgs) Handles txtProducto.TextChanged
        buscarProductoXNombre()
    End Sub
    Private Sub buscarProductoXNombre()
        Dim producto As New Producto
        If (Trim(txtProducto.Text = "")) Then
            dgvProductos.Rows.Clear()
            listarProductos()
        Else
            Try
                producto.NombreProducto = txtProducto.Text
                dgvProductos.Rows.Clear()
                Dim listaProductos = manejadorDeProductos.RetrieveByName(Of Producto)(producto)


                For Each elemento As Producto In listaProductos

                    Dim rowProducto = {
                        elemento.IdProducto,
                        elemento.NombreProducto,
                        elemento.CostoProducto
                       }
                    dgvProductos.Rows.Add(rowProducto)
                Next
            Catch ex As ChallengeMeException
                _em.ManageException(ex)
            End Try
        End If
    End Sub

    Private Sub btnAgregar_Click(sender As Object, e As EventArgs) Handles btnAgregar.Click

        Dim patrocinadorProducto As New PatrocinadorProducto
       

        For Each row As DataGridViewRow in dgvProductoAgregado.Rows
            If (Trim(txtCodPatrocinador.Text <> "")) Then
                patrocinadorProducto.idPatrocinador = txtCodPatrocinador.Text
                patrocinadorProducto.idProducto = CStr(row.Cells("IdProducto").Value)
                
                manejadorPatrocinadorProducto.Create(patrocinadorProducto)
               

            Else
                If (Trim(txtIdPatrocinador.Text <> "")) Then
                    patrocinadorProducto.idPatrocinador = txtIdPatrocinador.Text
                    patrocinadorProducto.idProducto = dgvProductoAgregado.CurrentRow.Cells("IdProducto").Value
                    manejadorPatrocinadorProducto.Create(patrocinadorProducto)

                End If

            End If



        Next 
        
        Me.Close()
    End Sub

    Private Sub btnSacarProducto_Click(sender As Object, e As EventArgs) Handles btnSacarProducto.Click
        Dim i As Integer
      
        'quito la fila del grid permisos y costo
        i = dgvProductoAgregado.CurrentRow.Index
        dgvProductoAgregado.Rows.RemoveAt(i)
        MessageBox.Show("Se ha quitado el producto de la lista de manera satisfactoria", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Information)

        'quito la fila del grid de patrocinador producto 
        'que es el que está invisible
       


      

    End Sub

    Private Sub dgvProductoAgregado_MouseClick(sender As Object, e As MouseEventArgs) Handles dgvProductoAgregado.MouseClick
        If dgvProductoAgregado.Rows.Count > 0 Then
            Dim i As Integer
            i = dgvProductoAgregado.CurrentRow.Index
            codPermisoAquitar = dgvProductoAgregado.CurrentRow.Cells("IdProducto").Value


        End If
    End Sub

    Private Sub lnkCrearProducto_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles lnkCrearProducto.LinkClicked
        Dim ModalCrearProductos = New frmModalCrearProducto()
        ModalCrearProductos.ShowDialog()
        listarProductos()
    End Sub
End Class