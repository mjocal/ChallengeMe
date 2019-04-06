Imports Challengeme.ApiCore
Imports Challengeme.Entities

Public Class frmModalEventoProducto
      Public _em As New ExceptionManagement
    Dim managerDePatProd As New PatrocinadorProductoManagement
    Dim ProductoManager As New ProductoManagement
    Dim PatrocinadorManager As New PatrocinadorManagement
    Dim eventoProductoManager As New EventoProductoManagement
    Dim Cod_Producto As Integer
    Dim Num_Patrocinador As Integer
    Dim Valor_Total As Decimal
    Public Num_Producto As Integer
    Public NomProducto As String
    Public monto As Decimal
    Public montoDos As Decimal
    Dim Nombre_Patrocinador As string
    Dim Costo_Producto As Decimal
    Public NomPatrocinador As String
    Public Codigo_Patrocinador As Integer
    Public TypePatrocinio As String
    Public CostoProd As Decimal

    Private Sub frmModalEventoProducto_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        listarPatrocinadorProducto()
        listarProductosAgregadosAlEvento()

        Me.Left = 300
        Me.Top = 175
        cboPatrocinador.Visible = False
        lblPatrocinador.Visible = False
    End Sub
    Private Sub listarPatrocinadorProducto()

        dgvProductos.Rows.Clear()

        Dim eventoProducto As New EventoProducto



        'Si el textbox codPatrocinador no está vacío significa que el usuario hizo clic en la
        'tabla de patrocinadores para ir a agregarle productos a ese codigo de patrocinador
        'entonces se hace una búsqueda en la tabla de patrocinadorproducto
        'para ver cuales productos están ligados a ese patrocinador en específico
        '---codigo hecho por Erick----


        Dim listaPatrocinadorProducto = managerDePatProd.RetrieveAlls(Of PatrocinadorProducto)
        'si la lista trae algo
        If (listaPatrocinadorProducto.Count > 0) Then
            For Each elemento As PatrocinadorProducto In listaPatrocinadorProducto
                Dim producto As New Producto
                Dim idProducto = elemento.idProducto
                producto.IdProducto = idProducto

                Dim patrocinador As New Patrocinador
                Dim idPatrocinador = elemento.idPatrocinador
                patrocinador.IdPatrocinador = idPatrocinador


                Dim listaProductos = ProductoManager.RetrieveAllByIdProducto(Of Producto)(producto)

                Dim listaPatrocinadores = PatrocinadorManager.RetrieveAllPatrocinadoresById(Of Patrocinador)(patrocinador)
                For Each productos As Producto In listaProductos

                    NomProducto = productos.NombreProducto
                    CostoProd = productos.CostoProducto
                    For Each patrocinadores As Patrocinador In listaPatrocinadores
                        NomPatrocinador = patrocinadores.NombrePatrocinador

                    Next
                Next
                dgvProductos.Rows.Add(idProducto, NomProducto, idPatrocinador, NomPatrocinador, FormatNumber(CostoProd, 2))
            Next
            'Se agregan los datos al grid de productos

        End If



    End Sub

    Private Sub dgvProductos_MouseClick(sender As Object, e As MouseEventArgs) Handles dgvProductos.MouseClick
        'If dgvProductos.SelectedItems.Count > 0 Then
        If dgvProductos.Rows.Count > 0 Then

            Cod_Producto = dgvProductos.CurrentRow.Cells("IdProducto").Value
            NomProducto = dgvProductos.CurrentRow.Cells("Producto").Value
            txtCosto.Text = dgvProductos.CurrentRow.Cells("Costo").Value
            Codigo_Patrocinador = dgvProductos.CurrentRow.Cells("IdPatrocinador").Value
            NomPatrocinador = dgvProductos.CurrentRow.Cells("Patrocinador").Value


            txtCantidad.Text = ""
            txtCantidad.Focus()

        End If
    End Sub


    Private Sub btnAgregar_Click(sender As Object, e As EventArgs) Handles btnAgregar.Click


        Dim cantidad As Integer
        erProveedorError.Clear()


        If (cboTipoPatrocinio.Text = "") Then
            erProveedorError.SetError(cboTipoPatrocinio, "Debe seleccionar el tipo de patrocinio")

            Return

        End If


        If (cboTipoPatrocinio.SelectedItem = "EFECTIVO") Then
            TypePatrocinio = cboTipoPatrocinio.Text


            If (cboPatrocinador.Text = "") Then
                erProveedorError.SetError(cboPatrocinador, "Debe seleccionar el patrocinador ")
                Return

            End If

            If (Trim(txtTotal.Text = "")) Then
                erProveedorError.SetError(txtTotal, "Debe indicar el monto del patrocinio en efectivo")
                txtTotal.Focus()

                Return

            End If
            dgvProductosEvento.Rows.Add(Cod_Producto, NomProducto, Codigo_Patrocinador, NomPatrocinador, cantidad, TypePatrocinio, FormatNumber(txtTotal.Text, 2))
            cboTipoPatrocinio.Text=""
            cboPatrocinador.Visible=True

        Else
            If (cboTipoPatrocinio.SelectedItem = "MERCANCIA") Then
                TypePatrocinio = cboTipoPatrocinio.Text
                If (Trim(txtCantidad.Text = "")) Then
                    erProveedorError.SetError(txtCantidad, "Debe indicar la cantidad de productos que va a ligar con el evento")
                    txtCantidad.Focus()

                    Return

                End If


                cantidad = CInt(txtCantidad.Text)
                monto = (cantidad * txtCosto.Text)


                txtTotal.Text = FormatNumber(monto, 2)

                dgvProductosEvento.Rows.Add(Cod_Producto, NomProducto, Codigo_Patrocinador, NomPatrocinador, cantidad, TypePatrocinio, FormatNumber(monto, 2))
                cboTipoPatrocinio.Text=""
                cboPatrocinador.Visible=False

            End If

        End If








    End Sub

    Private Sub txtCantidad_KeyPress(KeyAscii As Integer)
        If KeyAscii = 8 Then Exit Sub
        If KeyAscii = 13 Then
            KeyAscii = 0
            txtCantidad.Focus()
        Else
            If (UCase(Chr(KeyAscii)) Like "[!0-9,.]") Then
                KeyAscii = 0
            End If
        End If
    End Sub

    Private Sub btnAgregarProducto_Click(sender As Object, e As EventArgs) Handles btnAgregarProducto.Click
        Dim eventoProducto As New EventoProducto
        Dim productoEvento As New EventoProducto

        For Each row As DataGridViewRow In dgvProductosEvento.Rows

            eventoProducto.IdProducto = CStr(row.Cells("CodProducto").Value)

            eventoProducto = eventoProductoManager.RetrieveEventoProducto(eventoProducto)
            If (eventoProducto Is Nothing) Then
                productoEvento.IdProducto = CStr(row.Cells("CodProducto").Value)
                productoEvento.TipoPatrocinio = cboTipoPatrocinio.SelectedItem
                productoEvento.CantidadProducto = CStr(row.Cells("Cantidad").Value)
                productoEvento.ValorTotalProducto = CStr(row.Cells("Total").Value)
                productoEvento.IdEvento = txtIdEvento.Text
                productoEvento.IdPatrocinador = CStr(row.Cells("CodPatrocinador").Value)

                eventoProductoManager.CreateEventoProducto(eventoProducto)

            End If
        Next
        Me.Close()
    End Sub

    Private Sub btnQuitar_Click(sender As Object, e As EventArgs) Handles btnQuitar.Click
        Dim i As Integer
        Dim contador As Integer = 0
        'quito la fila del grid permisos y costo
        i = dgvProductosEvento.CurrentRow.Index
        dgvProductosEvento.Rows.RemoveAt(i)
        MessageBox.Show("Se ha quitado el Producto de la lista de manera satisfactoria", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Information)


    End Sub

    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click

    End Sub

    Private Sub txtTotal_TextChanged(sender As Object, e As EventArgs) Handles txtTotal.TextChanged

    End Sub

    Private Sub cboTipoPatrocinio_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboTipoPatrocinio.SelectedIndexChanged
        If (cboTipoPatrocinio.SelectedItem = "EFECTIVO") Then
            txtTotal.Enabled = True
            txtTotal.Focus()
            txtCantidad.Enabled = False
            cboPatrocinador.Visible = True
            lblPatrocinador.Visible = True
            Cod_Producto = 0
            NomProducto = "EFECTIVO"
            buscarTodosLosPatrocinadores()
        Else
            If (cboTipoPatrocinio.SelectedItem = "MERCANCIA") Then
                txtTotal.Enabled = False
                txtCantidad.Enabled = True
                txtCantidad.Focus()
                cboPatrocinador.Visible = False
                lblPatrocinador.Visible = False
            End If
        End If
    End Sub
    Private Sub buscarTodosLosPatrocinadores()
        Dim patrocinadores As New Patrocinador

        Dim listaPatrocinadores = PatrocinadorManager.RetrieveAllPatrocinadores(Of Patrocinador)

        cboPatrocinador.Items.Clear()
        For Each patrocinador As Patrocinador In listaPatrocinadores


            cboPatrocinador.Items.Add(patrocinador.NombrePatrocinador)
            Codigo_Patrocinador = patrocinador.IdPatrocinador

        Next

    End Sub

    Private Sub lblPatrocinador_Click(sender As Object, e As EventArgs) Handles lblPatrocinador.Click

    End Sub

    Private Sub cboPatrocinador_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboPatrocinador.SelectedIndexChanged

    End Sub
    Private Sub listarProductosAgregadosAlEvento()
        Dim eventoProducto As New EventoProducto

        If (Trim(txtIdEvento.Text <> "")) Then
            'Si el textbox codPatrocinador no está vacío significa que el usuario hizo clic en la
            'tabla de patrocinadores para ir a agregarle productos a ese codigo de patrocinador
            'entonces se hace una búsqueda en la tabla de patrocinadorproducto
            'para ver cuales productos están ligados a ese patrocinador en específico
            '---codigo hecho por Erick----

            eventoProducto.IdEvento = txtIdEvento.Text
            Dim listaEventoProducto = eventoProductoManager.RetrieveAllEventoProductoByIdEvento(Of EventoProducto)(eventoProducto)
            'si la lista trae algo
            If (listaEventoProducto.Count > 0) Then
                dgvProductosEvento.Rows.Clear()
                For Each elemento As EventoProducto In listaEventoProducto
                    Dim producto As New Producto
                    Num_Producto = elemento.IdProducto
                    producto.IdProducto = Num_Producto

                    Dim patrocinador As New Patrocinador
                    Num_Patrocinador = elemento.IdPatrocinador
                    patrocinador.IdPatrocinador = Num_Patrocinador
                    Valor_Total = elemento.ValorTotalProducto

                    Dim listaProductos = ProductoManager.RetrieveAllByIdProducto(Of Producto)(producto)
                    Dim listaPatrocinadores = PatrocinadorManager.RetrieveAllPatrocinadoresById(Of Patrocinador)(patrocinador)
                    For Each productos As Producto In listaProductos

                        NomProducto = productos.NombreProducto

                        For Each patrocinadores As Patrocinador In listaPatrocinadores
                            NomPatrocinador = patrocinadores.NombrePatrocinador

                        Next
                    Next
                    'If (cboIdProducto.Items.Contains(CodProducto) And cboIdPatrocinador.Items.Contains(id_Patrocinador)) Then

                    '  Else
                    'cboIdProducto.Items.Add(CodProducto)
                    'cboIdPatrocinador.Items.Add(id_Patrocinador)

                    dgvProductosEvento.Rows.Add(Num_Producto, NomProducto, Num_Patrocinador, NomPatrocinador, FormatNumber(Valor_Total, 2))
                    quitarProductoDeListaProductos()

                    '  End If


                Next
                'Se agregan los datos al grid de productos

            End If
        End If
    End Sub
    Private Sub quitarProductoDeListaProductos()
        'METODO PARA QUITAR DE MANERA AUTOMATICA
        'UN PRODUCTO DE LA LISTA DE PRODUCTOS DE LA IZQUIERDA




        For Each row As DataGridViewRow In dgvProductos.Rows
            'PARA CADA FILA EN LA TABLA DE LISTA PRODUCTOS


            '--- HECHO POR ERICK-----
            If (row.Cells("IdProducto").Value = Num_Producto And row.Cells("IdPatrocinador").Value= Num_Patrocinador) Then
                Dim i As Integer

                'quito la fila del grid 
                i = row.Index
                dgvProductos.Rows.RemoveAt(i)

            End If

        Next
    End Sub

    Private Sub txtProducto_TextChanged(sender As Object, e As EventArgs) Handles txtProducto.TextChanged
        buscarProducto()
    End Sub
    Private sub buscarProducto()
        'METODO QUE HACE UNA BUSQUEDA EN VARIAS TABLAS
        'COMENZANDO POR LA DE PRODUCTOS
        'PARA ENCONTRAR A TRAVES DEL NOMBRE DEL PRODUCTO QUE SE DIGITE EN LA CAJA DE TEXTO
        'TODA LA INFORMACION RELACIONADA CON EL NOMBRE DEL PATROCINADOR QUE POSEE ESE PRODUCTO
        'Y EL COSTO DE DICHO PRODUCTO
        '--- HECHO POR ERICK ----
        Dim producto As New Producto


        If (Trim(txtProducto.Text = "")) Then
            dgvProductos.Rows.Clear()
             listarPatrocinadorProducto()

        Else
            producto.NombreProducto = txtProducto.Text
            Try
                dgvProductos.Rows.Clear()
                Dim lstProductos = ProductoManager.RetrieveByName(Of Producto)(producto)


                For Each productos As Producto In lstProductos
                   Costo_Producto= productos.CostoProducto
                    Cod_Producto= productos.IdProducto

                    NomProducto=productos.NombreProducto

                    Dim listaPatrocinadorProducto = managerDePatProd.RetrieveAlls(Of PatrocinadorProducto)
                    For Each patrocinadorProd As PatrocinadorProducto In listaPatrocinadorProducto
                        If(productos.IdProducto = patrocinadorProd.idProducto)Then
                            Dim lstPatrocinadores = PatrocinadorManager.RetrieveAllPatrocinadores(Of Patrocinador)
                            For Each patroc As Patrocinador In lstPatrocinadores
                                If(patrocinadorProd.idPatrocinador = patroc.IdPatrocinador)Then
                                    Codigo_Patrocinador=patroc.IdPatrocinador
                                    Nombre_Patrocinador= patroc.NombrePatrocinador

                                End If
                            Next


                        End If
                    Next
                    dgvProductos.Rows.Add(Cod_Producto,NomProducto,Codigo_Patrocinador,Nombre_Patrocinador,Costo_Producto)

                Next

            Catch ex As ChallengeMeException
                _em.ManageException(ex)

            End Try


        End If
    End sub
End Class