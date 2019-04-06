Imports Challengeme.ApiCore
Imports Challengeme.Entities

Public Class frmRoles
    Public _em As New ExceptionManagement
    Private Sub btnSalir_Click(sender As Object, e As EventArgs)
        Environment.Exit(0)
    End Sub

    Private Sub frmRoles_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txtNombreRol.Focus()
        generarNumRol()
        ' listarRoles()
        cargarAreas()
        txtNombreRol.CharacterCasing = CharacterCasing.Upper
        txtDescrRol.CharacterCasing = CharacterCasing.Upper
        cargarPermiso()
        cargarRol()
        listarRolesCreados()


    End Sub
    Private Sub generarNumRol()
        Try
            Dim rm As New RolManagement
            Dim Cod As Integer
            Dim listaId = rm.RetrieveAlls(Of Rol) 'igualo a la lista lo que encontró el procedimiento de listar

            For i As Integer = 0 To listaId.Count - 1 'hago el recorrido por la lista
                Cod = listaId.Item(i).IdRol
                'hace un recorrido por toda la lista y encuenta el ultimo codigo ingresado



            Next
            txtIdRol.Text = Cod + 1 'a ese ultimo codigo ingresado le suma uno y ya tenemos el codigo sgte.
            txtIdRol.Enabled = False

        Catch ex As ChallengeMeException
            _em.ManageException(ex)

        End Try



    End Sub

    Private Sub listarRoles()
        Try
            Dim rm As New RolManagement
            Dim lista = rm.RetrieveAlls(Of Rol)() 'igualo a la lista lo que encontró el procedimiento de listar

            For i As Integer = 0 To lista.Count - 1 'hago el recorrido por la lista
                Dim lv = ListaPermisosXRol.Items.Add(lista.Item(i).IdRol)
                lv.SubItems.Add(lista.Item(i).Nombre_Role)
                lv.SubItems.Add(lista.Item(i).Descripcion_Role)
            Next

        Catch ex As ChallengeMeException
            _em.ManageException(ex)

        End Try

    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub cboPermisos_SelectedIndexChanged(sender As Object, e As EventArgs)
        'Dim pm As New PermisosManagement
        'Dim p As New Permisos


        'p.Nombre = cboPermisos.SelectedItem

        'Dim lista=pm.RetrieveByName(of Permisos)(p)

        'for i=0 to lista.Count-1

        '    txtIdPermiso.Text=lista.Item(i).Id
        'Next
    End Sub
    Private Sub cargarPermiso()
        'Dim pm As new PermisosManagement


        'Dim listaPermisos=pm.RetrieveAlls(Of Permisos)

        'for i= 0 To listaPermisos.Count -1
        '    cboPermisos.Items.Add(listaPermisos.Item(i).Nombre)
        'Next
    End Sub
    Private Sub cargarAreas()
        Try
            Dim pm As New PermisosManagement
            Dim lista = pm.RetrieveAlls(Of Permisos)() 'igualo a la lista lo que encontró el procedimiento de listar


            For i As Integer = 0 To lista.Count - 1 'hago el recorrido por la lista
                Dim a = lista.Item(i).Area

                ' 
                If (cboAreas.Items.Contains(a)) Then

                Else
                    ListaAreas.Items.Add(lista.Item(i).Area)
                    'meto los valores de las areas que se va encontrando en un
                    'combobox para que me sea mas facil comprobar si el valor
                    'del area ya ha sido agregado tanto al listview como 
                    'al combo y de esta manera si el valor del area ya existe
                    'entonces no se agrega para que no hayan areas repetidas
                    'dentro de la lista
                    cboAreas.Items.Add(lista.Item(i).Area)

                End If


            Next

        Catch ex As ChallengeMeException
            _em.ManageException(ex)

        End Try

    End Sub

    Private Sub ListaAreas_MouseClick(sender As Object, e As MouseEventArgs) Handles ListaAreas.MouseClick
        If ListaAreas.SelectedItems.Count > 0 Then

            Dim i As Integer
            i = ListaAreas.SelectedIndices.Item(0)
            Dim Area = ListaAreas.Items(i).SubItems(0).Text
            txtAreaABuscar.Text = Area

        End If
    End Sub
    Private Sub buscarPermisosPorArea()
        Try
            Dim pm As New PermisosManagement
            Dim lista = pm.RetrieveAlls(Of Permisos)() 'igualo a la lista lo que encontró el procedimiento de listar
            ListaPermisos.Items.Clear()
            For i As Integer = 0 To lista.Count - 1 'hago el recorrido por la lista

                Dim area = ListaPermisos.Items(lista.Item(i).Area)
                If (lista.Item(i).Area = txtAreaABuscar.Text) Then

                    Dim lv = ListaPermisos.Items.Add(lista.Item(i).IdPermiso)
                    lv.SubItems.Add(lista.Item(i).Nombre)

                End If

            Next

        Catch ex As ChallengeMeException
            _em.ManageException(ex)
        End Try

    End Sub

    Private Sub ListaPermisos_MouseClick(sender As Object, e As MouseEventArgs) Handles ListaPermisos.MouseClick
        If ListaPermisos.SelectedItems.Count > 0 Then
            Dim i As Integer
            i = ListaPermisos.SelectedIndices.Item(0)
            Dim IdPermiso = ListaPermisos.Items(i).SubItems(0).Text
            Dim NomPermiso = ListaPermisos.Items(i).SubItems(1).Text
            txtIdPermiso.Text = IdPermiso
            txtNomPermiso.Text = NomPermiso
        End If
    End Sub

    Private Sub txtAreaABuscar_TextChanged(sender As Object, e As EventArgs) Handles txtAreaABuscar.TextChanged
        buscarPermisosPorArea()
    End Sub

    Private Sub btnAgregarPermisos_Click(sender As Object, e As EventArgs) Handles btnAgregarPermisos.Click
        agregarPermisosAlRol()

    End Sub
    Private Sub agregarPermisosAlRol()
        Dim rm As New RolManagement
        Dim r As New Rol
        Dim rol As New Rol

        erProveedorError.Clear()
        If (Trim(txtIdPermiso.Text = "")) Then
            erProveedorError.SetError(txtIdPermiso, "Debe al menos seleccionar un permiso para agregarlo al rol")
            txtIdPermiso.Focus()
            Return

        End If
        If (Trim(txtNombreRol.Text = "")) Then
            erProveedorError.SetError(txtNombreRol, "El campo nombre rol no puede estar vacío")
            txtNombreRol.Focus()
            Return

        End If
        If (Trim(txtDescrRol.Text = "")) Then
            erProveedorError.SetError(txtDescrRol, "El campo Descripción rol no puede estar vacío")
            txtDescrRol.Focus()
            Return

        End If
        'llena el listview con el idrol y el idpermiso
        'para que cuando se de clic en el boton de guardar se haga un recorrido 
        'sobre este listview y se vayan guardando esos campos en la tabla
        'TBL_ROLE_PERMISO
        cargarlstRolPermiso()

            

    End Sub
    Private Sub cargarlstRolPermiso()
        Dim rpm As New RolPermisoManagement
        Dim rp As New RolPermiso

        Try
            Dim lvs = ListaPermisosXRol.Items.Add(txtIdPermiso.Text)
                lvs.SubItems.Add(txtNomPermiso.Text)

            Dim lv = lstRolPermiso.Items.Add(txtIdRol.Text)
            lv.SubItems.Add(txtIdPermiso.Text)
            txtIdPermiso.Text = ""
            txtNomPermiso.Text = ""


        Catch ex As ChallengeMeException
            _em.ManageException(ex)

        End Try


    End Sub
    Private Sub crearRol()
        Dim rm As New RolManagement
        Dim r As New Rol

        If (Trim(txtNombreRol.Text = "")) Then
            MessageBox.Show("El nombre del rol no puede estar vacío", "Atención..!", MessageBoxButtons.OK, MessageBoxIcon.Error)
            txtNombreRol.Focus()

        Else

            If (Trim(txtDescrRol.Text = "")) Then
                MessageBox.Show("La descripción del rol no puede estar vacía", "Atención..!", MessageBoxButtons.OK, MessageBoxIcon.Error)
                txtDescrRol.Focus()

            Else
                Try
                    r.IdRol = txtIdRol.Text
                    r.Nombre_Role = txtNombreRol.Text
                    r.Descripcion_Role = txtDescrRol.Text

                    rm.CreateRol(r)
                    'MessageBox.Show("Rol creado satisfactoriamente", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    'txtNombreRol.Text = ""
                    'txtDescrRol.Text = ""
                    'ListaPermisosXRol.Items.Clear()
                    'listarRoles()
                    'generarNumRol()
                    'txtNombreRol.Focus

                Catch ex As ChallengeMeException
                    _em.ManageException(ex)

                End Try


            End If

        End If
    End Sub

    Private Sub ListaPermisosXRol_MouseClick(sender As Object, e As MouseEventArgs) Handles ListaPermisosXRol.MouseClick
        If ListaPermisosXRol.SelectedItems.Count > 0 Then


            Dim i As Integer
            i = ListaPermisosXRol.SelectedIndices.Item(0)
            Dim IdPermiso = ListaPermisosXRol.Items(i).SubItems(0).Text
            txtIdPermiso.Text = IdPermiso

        End If
    End Sub

    Private Sub btnQuitar_Click(sender As Object, e As EventArgs) Handles btnQuitar.Click
        Dim rpm As New RolPermisoManagement
        Dim rp As New RolPermiso

        If (txtIdRol.Text = "") Then 'si la caja de texto del idrol está vacía significa que el usuario no ha dado clic en la tabla
            'para saber cual es el permiso que desea quitarle
            MessageBox.Show("Debe Seleccionar un permiso de la tabla para poder quitarlo", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Information)

        Else
            rp.IdRol = txtIdRol.Text
            rp.IdPermiso = txtIdPermiso.Text
            If ListaPermisosXRol.SelectedItems.Count > 0 Then
                Dim i As Integer
                i = ListaPermisosXRol.SelectedIndices.Item(0)
                ListaPermisosXRol.Items(i).Remove()


            End If
            Try
                rpm.Delete(rp)
                txtIdPermiso.Text = ""
                'ListaPermisosXRol.Items.Clear()
                'cargarPermisosXRol()

            Catch ex As ChallengeMeException
                _em.ManageException(ex)

            End Try

        End If



    End Sub
    Private Sub cargarRol()
        Try

            Dim rm As New RolManagement

            Dim listaRoles = rm.RetrieveAlls(Of Rol)

            cboRoles.Items.Clear()

            For i = 0 To listaRoles.Count - 1

                cboRoles.Items.Add(listaRoles.Item(i).Nombre_Role)

            Next
        Catch ex As ChallengeMeException
            _em.ManageException(ex)
        End Try


    End Sub

    Private Sub cboRoles_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboRoles.SelectedIndexChanged

        Try
            Dim rm As New RolManagement
            Dim r As New Rol
            'agarra el nombre del rol que se ha seleccionado del combo de roles
            'y lo pasa a la varia r.Nomnbre_Role
            r.Nombre_Role = cboRoles.Text

            'se hace la búsqueda en la tabla de roles por medio del nombre del rol
            'para encontrar el id del rol asociado con el nombre del rol que el usuario ha seleccionado
            'del combobox                                                    
            Dim lista = rm.RetrieveByName(Of Rol)(r)
            For i = 0 To lista.Count - 1
                'por último se pasa a una caja de texto el id del rol encontrado a través del nombre
                'de ese rol para luego desde el evento change de la caja de texto txtCodRol
                'hacer una busqueda de ese idrol en la tabla TL_ROLE_PERMISO
                'y verificar los idpermisos asignados a ese idrol en dicha tabla para luego
                'hacer una busqueda de esos idpermisos encontrados en ROLE_PERMISO y que han sido
                'asignados a un idrol, en la tabla TBL_PERMISOS y hacer el join para traer el nombre
                'y el area del permiso que han sido aplicados a ese idrol.
                txtCodRol.Text = lista.Item(i).IdRol
                listarPermisosPorRol()
            Next

        Catch ex As Exception
            _em.ManageException(ex)

        End Try

    End Sub

    Private Sub cboRoles_MouseClick(sender As Object, e As MouseEventArgs) Handles cboRoles.MouseClick
        cargarRol()
    End Sub

    Private Sub listarPermisosPorRol()
        Dim rpm As New RolPermisoManagement
        Dim rp As New RolPermiso
        Dim listaPermisos As New List(Of Permisos)()
        'primero pego el idrol que copié en una caja de texto(que se pegó en esa 
        '(caja de texto dependiendo del nombre del rol que se selecciona en el combobox)
        'en una varia rp.idrol para ir a buscar a la tabla TBL_ROLE_PERMISO
        'y verificar cuantos permisos tiene asociados ese idrol
        rp.IdRol = txtCodRol.Text

        'procedo a hacer la búsqueda y dejar lo encontrado en una variable listaRoles
        'para ver cuantas veces se repite ese mismo rol en la tabla TBL_ROLE_PERMISO
        'las veces que un mismo rol se repite en dicha tabla es equivalente a la cantidad
        'de permisos que ese rol tiene asociados
        Dim listaRolesPermisos = rpm.RetrieveAllByIdRol(Of RolPermiso)(rp)
        'hago un for para ir pegando cada uno de los idpermisos en una vairable
        'y que ese idpermiso me sirva para ir a buscar a través de él
        'cual es el nombre y el área de ese id permiso 
        'pero en la tabla TBL_PERMISOS
        dgvListaPermisos.Rows.Clear()
        For Each r In listaRolesPermisos
            ' Dim permiso = r.IdPermiso

            Dim pm As New PermisosManagement
            Dim p As New Permisos
            p.IdPermiso = r.IdPermiso

            'hago la búsqueda de todos los permisos que pueda encontrar asociados con el 
            'idpermiso que se le está pasando al método por parámetro
            'y los dejo en una lista que posteriormente tengo que recorrer
            listaPermisos = pm.RetrieveAllByIdPermiso(Of Permisos)(p)
            For Each elemento In listaPermisos

                Dim fila As String()
                fila = New String() {elemento.Nombre, elemento.Area}
                dgvListaPermisos.Rows.Add(fila)

            Next

        Next
        'para cada elemento encontrado en la lista
        'lo recorro y los voy insertando en el DBGRID
        'para saber cuales son los permisos asociados al rol que estoy buscando





    End Sub

    Private Sub txtCodRol_TextChanged(sender As Object, e As EventArgs) Handles txtCodRol.TextChanged
       
    End Sub

    Private Sub frmRoles_MouseHover(sender As Object, e As EventArgs) Handles MyBase.MouseHover

    End Sub

    Private Sub btnGuardar_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click
        Dim rolPermisoManagement As New RolPermisoManagement
        Dim rolPermiso As New RolPermiso

        If (Trim(txtModificar.Text = "MODIFICAR")) Then

             For i As Integer = 0 To lstRolPermiso.Items.Count - 1 
                rolPermiso.IdRol = lstRolPermiso.Items.Item(i).SubItems(0).Text
                rolPermiso.IdPermiso = lstRolPermiso.Items.Item(i).SubItems(1).Text
                'busca el id rol a ver si ya existe
                 rolPermisoManagement.CreateRolPermiso(rolPermiso)
                 
            Next i
           

           
            txtNombreRol.Text = ""
            txtDescrRol.Text = ""
            txtModificar.Text = ""
            ListaPermisos.Items.Clear()
            ListaPermisosXRol.Items.Clear()
            listarRolesCreados()
            generarNumRol()
            txtNombreRol.Focus()
            MessageBox.Show("Rol guardado Satisfactoriamente", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Else
           crearRol()


            For i As Integer = 0 To lstRolPermiso.Items.Count - 1 
                rolPermiso.IdRol = lstRolPermiso.Items.Item(i).SubItems(0).Text
                rolPermiso.IdPermiso = lstRolPermiso.Items.Item(i).SubItems(1).Text
                
                rolPermisoManagement.CreateRolPermiso(rolPermiso)
          
                
            Next i

            MessageBox.Show("Rol guardado Satisfactoriamente", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Information)
            txtNombreRol.Text = ""
            txtDescrRol.Text = ""
            txtModificar.Text = ""
            ListaPermisos.Items.Clear()
            lstRolPermiso.Clear()
            ListaPermisosXRol.Items.Clear()
            listarRolesCreados()
            generarNumRol()
            txtNombreRol.Focus()
        End If

    End Sub

    Private Sub btnSalir_Click_1(sender As Object, e As EventArgs) 
        Dim rm As New RolManagement
        Dim r As New Rol

        If (txtNombreRol.Text = "" And txtDescrRol.Text = "" Or txtModificar.Text = "MODIFICAR") Then
            'si el campo nombre y el campo descripcion están vacíos es porque
            'el usuario ni siquiera ha querido crear un rol nuevo
            'entonces se sale sin preguntar nada
            frmMenuSA.Show()
            Me.Close()

        Else
            Try
                r.IdRol = txtIdRol.Text
                If (ListaPermisosXRol.Items.Count = 0) Then
                    Dim Resp As String = MessageBox.Show("El rol que está tratando de crear no tiene permisos asignados, desea salir sin asignarle permisos a este rol?", "Atención", MessageBoxButtons.YesNo, MessageBoxIcon.Error)
                    If Resp = 6 Then
                        rm.Delete(r)
                        frmMenuSA.Show()
                        Me.Close()

                    Else
                        'no hace nada y se queda en el formulario esperando a que se le asignen
                        'permisos al rol

                    End If

                End If
            Catch ex As ChallengeMeException
                _em.ManageException(ex)

            End Try

        End If



    End Sub

    Private Sub txtArea_TextChanged(sender As Object, e As EventArgs) Handles txtArea.TextChanged

    End Sub

    Private Sub GroupBox2_Enter(sender As Object, e As EventArgs) Handles GroupBox2.Enter

    End Sub

    Private Sub txtIDBuscarRol_KeyPress(sender As Object, e As KeyPressEventArgs)
        If Char.IsDigit(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub

    Private Sub listarRolesCreados()


        Dim r As New RolManagement
        Try
            Dim lista = r.RetrieveAlls(Of Rol)()
            dgvListaRolesCreados.Rows.Clear()
            For Each elemento In lista
                Dim fila As String()
                fila = New String() {elemento.IdRol, elemento.Nombre_Role, elemento.Descripcion_Role}
                dgvListaRolesCreados.Rows.Add(fila)
            Next

        Catch ex As ChallengeMeException
            _em.ManageException(ex)

        End Try

    End Sub

    Private Sub dgvListaRolesCreados_MouseClick(sender As Object, e As MouseEventArgs) Handles dgvListaRolesCreados.MouseClick
        If dgvListaRolesCreados.Rows.Count > 0 Then


            Dim i As Integer
            i = dgvListaRolesCreados.Rows(0).Selected
            txtIdRol.Text = dgvListaRolesCreados.CurrentRow.Cells("IDRol").Value
            txtNombreRol.Text = dgvListaRolesCreados.CurrentRow.Cells("Rol").Value
            txtDescrRol.Text = dgvListaRolesCreados.CurrentRow.Cells("Descripcion").Value
            cboRoles.Items.Clear()
            cboRoles.Items.Add(dgvListaRolesCreados.CurrentRow.Cells("Rol").Value)
            cboRoles.SelectedIndex = 0
            txtModificar.Text = "MODIFICAR"



        End If
    End Sub

    Private Sub btnModificar_Click(sender As Object, e As EventArgs)




    End Sub

    Private Sub txtIdRol_TextChanged(sender As Object, e As EventArgs) Handles txtIdRol.TextChanged

    End Sub
    Private Sub modificar()
        Dim rm As New RolManagement
        Dim r As New Rol

        r.IdRol = txtIdRol.Text
        r.Nombre_Role = txtNombreRol.Text
        r.Descripcion_Role = txtDescrRol.Text
        Try
            rm.Update(r)
            MessageBox.Show("Rol modificado satisfactoriamente", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Information)
            generarNumRol()
            txtNombreRol.Text = ""
            txtDescrRol.Text = ""

            listarRolesCreados()
        Catch ex As ChallengeMeException
            _em.ManageException(ex)

        End Try
    End Sub

   
End Class