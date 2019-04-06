Imports Challengeme.ApiCore
Imports Challengeme.Entities

Public Class fmPermisos
    Public _em As New ExceptionManagement
    Private Sub fmPermisos_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        generaNumPermiso()
        listarPermisos()
        txtDescripcion.CharacterCasing = CharacterCasing.Upper

    End Sub
    Private Sub generaNumPermiso()
        Dim pm As New PermisosManagement
        Dim Cod As Integer
        Try
            Dim listaId = pm.RetrieveAlls(Of Permisos) 'igualo a la lista lo que encontró el procedimiento de listar
            For i As Integer = 0 To listaId.Count - 1 'hago el recorrido por la lista
                If(listaId.Item(i).Estado_Permiso="INACTIVO")Then
                    Cod = listaId.Item(i).IdPermiso
                Else
                    Cod = listaId.Item(i).IdPermiso
                End If
                
                'hace un recorrido por toda la lista y encuenta el ultimo codigo ingresado

            Next
            txtIdPermiso.Text = Cod + 1 'a ese ultimo codigo ingresado le suma uno y ya tenemos el codigo sgte.
            txtIdPermiso.Enabled = False

        Catch ex As ChallengeMeException
            _em.ManageException(ex)
        End Try


    End Sub

    Private Sub btnGuardar_Click(sender As Object, e As EventArgs)


    End Sub
    Private Sub listarPermisos()
        'hacer un listar con un list view
        'Dim pm As New PermisosManagement


        'Dim lista = pm.RetrieveAlls(Of Permisos)() 'igualo a la lista lo que encontró el procedimiento de listar

        'For i As Integer = 0 To lista.Count - 1 'hago el recorrido por la lista
        '    Dim lv = ListaPermisos.Items.Add(lista.Item(i).Id)
        '    lv.SubItems.Add(lista.Item(i).Nombre)
        '    lv.SubItems.Add(lista.Item(i).Descripcion)
        '    lv.SubItems.Add(lista.Item(i).Area)



        'Next
        '*******************************************************************
        'hacer el listar con un datagridview
        dgvPermisos.Rows.Clear()
        Dim m As New PermisosManagement
        Try
            Dim lista = m.RetrieveAlls(Of Permisos)()
            For Each elemento In lista
                Dim fila As String()
                fila = New String() {elemento.IdPermiso, elemento.Nombre, elemento.Descripcion,
                                     elemento.Area}
                dgvPermisos.Rows.Add(fila)
            Next

        Catch ex As ChallengeMeException
            _em.ManageException(ex)

        End Try

    End Sub

    Private Sub btnBuscar_Click(sender As Object, e As EventArgs)


    End Sub

    Private Sub txtNombre_TextChanged(sender As Object, e As EventArgs) 
        BuscarPermiso()
    End Sub
    Private Sub BuscarPermiso()
        Dim pm As New PermisosManagement
        Dim p As New Permisos


        If (Trim(cboPermiso.SelectedValue = "")) Then
            dgvPermisos.Rows.Clear()
            listarPermisos()

        Else
            p.Nombre = cboPermiso.SelectedItem
            Try
                Dim lista = pm.RetrieveByName(Of Permisos)(p)

                'For i As Integer = 0 To lista.Count - 1 'hago el recorrido por la lista
                'dgvPermisos.Rows.Clear()
                'Dim lv = dgvPermisos.Rows.Add(lista.Item(i).Id)
                'lv.SubItems.Add(lista.Item(i).Nombre)
                'lv.SubItems.Add(lista.Item(i).Descripcion)
                'lv.SubItems.Add(lista.Item(i).Are a)

                For Each elemento In lista
                    dgvPermisos.Rows.Clear()
                    Dim fila As String()
                    fila = New String() {elemento.IdPermiso, elemento.Nombre, elemento.Descripcion,
                                         elemento.Area}
                    dgvPermisos.Rows.Add(fila)

                Next

            Catch ex As ChallengeMeException
                _em.ManageException(ex)

            End Try


        End If
    End Sub


    Private Sub ListaPermisos_MouseClick(sender As Object, e As MouseEventArgs) Handles ListaPermisos.MouseClick
        If dgvPermisos.SelectedRows.Count > 0 Then ' ListaPermisos.SelectedItems.Count > 0 Then


            Dim i As Integer
            i = dgvPermisos.Rows(0).Selected ' ListaPermisos.SelectedIndices.Item(0)
            Dim IdPermiso = dgvPermisos.CurrentRow.Cells("Id").Value 'ListaPermisos.Items(i).SubItems(0).Text
            Dim Nombre = dgvPermisos.CurrentRow.Cells("NombreP").Value 'ListaPermisos.Items(i).SubItems(1).Text
            Dim Descripcion = dgvPermisos.CurrentRow.Cells("Descrip").Value 'ListaPermisos.Items(i).SubItems(2).Text
            Dim Area = dgvPermisos.CurrentRow.Cells("AreaP").Value 'ListaPermisos.Items(i).SubItems(3).Text
            txtIdPermiso.Enabled = False
           

            txtIdPermiso.Text = IdPermiso
            cboPermiso.Items.Clear()
            cboPermiso.Items.Add(Nombre)
            cboPermiso.SelectedIndex=0
            txtDescripcion.Text = Descripcion
            cboArea.Items.Add(Area)

        End If
    End Sub

    Private Sub btnLimpiar_Click(sender As Object, e As EventArgs)

    End Sub
    Private Sub dgvPermisos_MouseClick(sender As Object, e As MouseEventArgs) Handles dgvPermisos.MouseClick
        If dgvPermisos.Rows.Count > 0 Then 


            Dim i As Integer
            i = dgvPermisos.Rows(0).Selected 
            Dim IdPermiso = dgvPermisos.CurrentRow.Cells("Id").Value
            Dim Nombre = dgvPermisos.CurrentRow.Cells("NombreP").Value 
            Dim Descripcion = dgvPermisos.CurrentRow.Cells("Descrip").Value 
            Dim Area = dgvPermisos.CurrentRow.Cells("AreaP").Value 
            txtIdPermiso.Enabled = False
           

            txtIdPermiso.Text = IdPermiso
            cboPermiso.Items.Clear()
            cboPermiso.Items.Add(Nombre)
            cboPermiso.SelectedIndex=0
            txtDescripcion.Text = Descripcion
            cboArea.SelectedItem = Area
            txtModificar.Text = "MODIFICAR"


        End If
    End Sub

    Private Sub btnRoles_Click(sender As Object, e As EventArgs) 
        frmRoles.Show()
        Me.Hide()

    End Sub


    Private Sub ToolStripBtnNuevo_Click(sender As Object, e As EventArgs) Handles ToolStripBtnNuevo.Click
        cboPermiso.SelectedIndex=0
        txtDescripcion.Text = ""
        txtModificar.Text = ""
        ListaPermisos.Items.Clear()
        listarPermisos()
        generaNumPermiso()
        
    End Sub

    Private Sub ToolStripBtnSalvar_Click(sender As Object, e As EventArgs) Handles ToolStripBtnSalvar.Click
        Dim pm As New PermisosManagement
        Dim p As New Permisos

        erProveedorError.Clear()
        If (Trim(cboPermiso.Text="")) Then
            erProveedorError.SetError(cboPermiso, "Debe seleccionar el nombre de un permiso")
            'MessageBox.Show("Debe indicar el Nombre del Usuario que desea Guardar", "Atención..!", MessageBoxButtons.OK, MessageBoxIcon.Error)
            cboPermiso.Focus()
            Return

        End If
        If (Trim(txtDescripcion.Text = "")) Then
            erProveedorError.SetError(txtDescripcion, "La descripción del permiso no puede estar vacía")
            'MessageBox.Show("Debe indicar el Nombre del Usuario que desea Guardar", "Atención..!", MessageBoxButtons.OK, MessageBoxIcon.Error)
            txtDescripcion.Focus()
            Return

        End If
        If (Trim(cboArea.Text = "")) Then
            erProveedorError.SetError(cboArea, "Debe seleccionar el área al que desea aplicarle el permiso")
            'MessageBox.Show("Debe indicar el Nombre del Usuario que desea Guardar", "Atención..!", MessageBoxButtons.OK, MessageBoxIcon.Error)
            cboArea.Focus()
            Return

        End If
        p.IdPermiso = txtIdPermiso.Text
        p.Nombre = cboPermiso.SelectedItem
        p.Descripcion = txtDescripcion.Text
        p.Area = cboArea.SelectedItem

        Try
            pm.CreatePermiso(p)

        Catch ex As ChallengeMeException
            _em.ManageException(ex)
        End Try
        MessageBox.Show("Permiso creado satisfactoriamente", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Information)
        cboPermiso.SelectedIndex=0
        txtDescripcion.Text = ""
        ListaPermisos.Items.Clear()
        listarPermisos()
        generaNumPermiso()
       

        
        If (Trim(txtModificar.Text = "MODIFICAR")) Then
            modificar()
        End If
    End Sub

    Private Sub ToolStripBtnBuscar_Click(sender As Object, e As EventArgs) Handles ToolStripBtnBuscar.Click
        BuscarPermiso()
    End Sub

    Private Sub ToolStripBtnEliminar_Click(sender As Object, e As EventArgs) Handles ToolStripBtnEliminar.Click
        Dim pm As New PermisosManagement
        Dim p As New Permisos

        p.IdPermiso = txtIdPermiso.Text
        Try
            pm.Delete(p)
            MessageBox.Show("Permiso eliminado satisfactoriamente", "Atención..!", MessageBoxButtons.OK, MessageBoxIcon.Information)
            txtIdPermiso.Text = ""
           cboPermiso.SelectedIndex=0
            txtDescripcion.Text = ""
            cboArea.SelectedIndex = 0
           

        Catch ex As ChallengeMeException

            _em.ManageException(ex)

        End Try

        'ListaPermisos.Items.Clear()
        dgvPermisos.Rows.Clear()
        listarPermisos()
    End Sub

    Private Sub ToolStripBtnSalir_Click(sender As Object, e As EventArgs) Handles ToolStripBtnSalir.Click
        frmMenuSA.Show()
        Me.Close()


    End Sub
    Private Sub modificar()
        Dim pm As New PermisosManagement
        Dim p As New Permisos

        If (Trim(cboPermiso.Text = "")) Then
            MessageBox.Show("No puede dejar el campo Nombre vacío", "Atención..!", MessageBoxButtons.OK, MessageBoxIcon.Error)
            cboPermiso.Focus()

        Else

            If (Trim(txtDescripcion.Text = "")) Then
                MessageBox.Show("No puede dejar el campo Descripción vacío", "Atención..!", MessageBoxButtons.OK, MessageBoxIcon.Error)
                txtDescripcion.Focus()

            Else

                p.IdPermiso = txtIdPermiso.Text
                p.Nombre = cboPermiso.SelectedItem
                p.Descripcion = txtDescripcion.Text
                p.Area = cboArea.SelectedItem
                Try
                    pm.Update(p)
                    MessageBox.Show("Permiso Actualizado satisfactoriamente", "Atención..!", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    generaNumPermiso()
                   cboPermiso.SelectedIndex=0
                    txtDescripcion.Text = ""
                    cboArea.SelectedIndex = 0

                Catch ex As ChallengeMeException
                    _em.ManageException(ex)

                End Try

            End If

        End If

        'ListaPermisos.Items.Clear()
        dgvPermisos.Rows.Clear()
        listarPermisos()
        txtIdPermiso.Enabled = True
    End Sub

    Private Sub cboArea_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboArea.SelectedIndexChanged

    End Sub

    Private Sub cboPermiso_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboPermiso.SelectedIndexChanged

    End Sub
End Class