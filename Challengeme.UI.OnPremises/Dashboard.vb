Imports Challengeme.ApiCore
Imports Challengeme.Entities

Public Class frmDashBoard

    Public _em As New ExceptionManagement
    Private imageList As New ImageList With {.ImageSize = New Size(24, 24)}
    Dim m As New UserManagement

    Private Sub BunifuImageButton2_Click(sender As Object, e As EventArgs)
        Environment.Exit(0)
    End Sub
    Private Sub frmDashBoard_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        buscarFoto()
        buscarRolUsuario()


    End Sub
    Private Sub buscarFoto()
        Try

            Dim u As New User

            u.IdUsuario = GlobalVariables.USUARIO 'VARIABLE GLOBAL ENTRE TODOS LOS FORMS QUE CONTIENE EL USUARIO!

            u = m.Retrieve(u) 'igualo a la lista lo que encontró el procedimiento de listar
            PictureBox1.Image = u.Imagen_Usuario

        Catch ex As ChallengeMeException
            _em.ManageException(ex)
        End Try
    End Sub

    Private Sub BunifuFlatButton6_Click(sender As Object, e As EventArgs)
        Application.Exit()
    End Sub

    Private Sub btnSalir_Click(sender As Object, e As EventArgs)
        Application.Exit()

    End Sub

    Private Sub btnMenuPermisos_Click(sender As Object, e As EventArgs)

        frmMenuSA.Show()
        Me.Close()

    End Sub
    Private Sub buscarRolUsuario()

        Dim u As New User

        Dim rm As New RolManagement
        Dim r As New Rol

        Dim rpm As New RolPermisoManagement
        Dim rp As New RolPermiso

        Dim listaPermisos As New List(Of Permisos)()

        u.IdUsuario = USUARIO
        lblNombreRol.Text = NOMBRE_ROL
        txtUSUARIO.Text = USUARIO
        'buscamos el usuario por el id usuarios para traernos todos los datos de ese usuario
        'que estan guardados en la tabla de usuarios
        u = m.Retrieve(u)

        If (u Is Nothing) Then


        Else
            'igualamos el id rol de la tabla rol, al campo id rol de la tabla usuario
            'para luego ir a la tabla rol y ver si ese idrol existe y si existe, traer el nombre
            'del rol que ese usuario tiene asignado
            r.IdRol = u.IdRole

            r = rm.Retrieve(r)

            If (NOMBRE_ROL = "SA" Or NOMBRE_ROL = "ORGANIZADOR") Then
                btnMenuPermisos.Visible = True
                btnEmpresas.Visible = True
                btnDashboard.Visible = True
                btnRutas.Enabled=True
                btnEventos.Enabled = True
                btnPatrocinadores.Enabled = True
                btnProductos.Enabled = True
                btnCategoria.Enabled = True
                btnPremios.Enabled = True
                btnEmpresas.Enabled = True
                btnRanking.Enabled = True
                btnInscripcion.Enabled = True
                btnActividades.Enabled = True
                botonDashboard()



            Else
                btnMenuPermisos.Visible = False
                btnEmpresas.Visible = False
                btnDashboard.Visible = False
                rp.IdRol = r.IdRol
                Dim listaRolPermiso = rpm.RetrieveAllByIdRol(Of RolPermiso)(rp)

                cboCargarAreas.Items.Clear()
                For Each rol In listaRolPermiso
                    Dim pm As New PermisosManagement
                    'Dim p As New Permisos
                    'p.IdPermiso = rol.IdPermiso
                    'hago la búsqueda de todos los permisos que pueda encontrar asociados con el 
                    'idpermiso que se le está pasando al método por parámetro
                    'y los dejo en una lista que posteriormente tengo que recorrer

                    listaPermisos = pm.RetrieveAlls(Of Permisos)




                    For i As Integer = 0 To listaPermisos.Count - 1 'hago el recorrido por la lista
                        If (rol.IdPermiso = listaPermisos(i).IdPermiso) Then



                            Dim a = listaPermisos.Item(i).Area


                            If (cboCargarAreas.Items.Contains(a)) Then

                            Else

                                'meto los valores de las areas que se va encontrando en un
                                'combobox para que me sea mas facil comprobar si el valor
                                'del area ya ha sido agregado tanto al listview como 
                                'al combo y de esta manera si el valor del area ya existe
                                'entonces no se agrega para que no hayan areas repetidas
                                'dentro de la lista
                                cboCargarAreas.Items.Add(listaPermisos.Item(i).Area)


                            End If

                        End If


                    Next

                Next

                Dim lista As New List(Of String)

                For Each item As Object In cboCargarAreas.Items

                    lista.Add(CStr(item))

                Next


                Dim lst = lista

                For j As Integer = 0 To lst.Count - 1
                    If (lst.Item(j) = "EVENTOS") Then
                        btnEventos.Enabled = True

                    Else

                        If (btnEventos.Enabled = True) Then

                        Else
                            btnEventos.Enabled = False


                        End If

                    End If


                    If (lst.Item(j) = "PRODUCTOS") Then
                        btnProductos.Enabled = True

                    Else
                        If (btnProductos.Enabled = True) Then


                        Else
                            btnProductos.Enabled = False
                        End If

                    End If

                    If (lst.Item(j) = "PATROCINADORES") Then
                        btnPatrocinadores.Enabled = True

                    Else
                        If (btnPatrocinadores.Enabled = True) Then


                        Else
                            btnPatrocinadores.Enabled = False
                        End If

                    End If

                    If (lst.Item(j) = "RANKING") Then
                        btnRanking.Enabled = True

                    Else
                        If (btnRanking.Enabled = True) Then


                        Else
                            btnRanking.Enabled = False
                        End If

                    End If

                    If (lst.Item(j) = "INSCRIPCIONES") Then
                        btnInscripcion.Enabled = True

                    Else
                        If (btnInscripcion.Enabled = True) Then


                        Else
                            btnInscripcion.Enabled = False
                        End If

                    End If

                    If (lst.Item(j) = "CATEGORIAS") Then
                        btnCategoria.Enabled = True

                    Else
                        If (btnCategoria.Enabled = True) Then


                        Else
                            btnCategoria.Enabled = False
                        End If

                    End If

                    If (lst.Item(j) = "ACTIVIDADES") Then
                        btnActividades.Enabled = True

                    Else
                        If (btnActividades.Enabled = True) Then


                        Else
                            btnActividades.Enabled = False
                        End If

                    End If
                     If (lst.Item(j) = "RUTAS") Then
                        btnRutas.Enabled = True

                    Else
                        If (btnRutas.Enabled = True) Then


                        Else
                            btnRutas.Enabled = False
                        End If

                    End If


                    If (lst.Item(j) = "PREMIOS") Then
                        btnPremios.Enabled = True

                    Else
                        If (btnPremios.Enabled = True) Then

                        Else
                            btnPremios.Enabled = False
                        End If

                    End If

                Next

            End If

        End If



    End Sub

    Private Sub btnEventos_Click(sender As Object, e As EventArgs) Handles btnEventos.Click
        Dim eventos As New frmEvento
        eventos.MdiParent = Me
        Me.Panel2.Controls.Add(eventos)
        eventos.Show()
    End Sub

    Private Sub btnEmpresas_Click(sender As Object, e As EventArgs)
        Dim entidad As New frmEntidad
        entidad.MdiParent = Me
        Me.Panel2.Controls.Add(entidad)
        entidad.Show()
    End Sub

    Private Sub btnSalir_Click_1(sender As Object, e As EventArgs) Handles btnSalir.Click
        Application.Exit()
    End Sub

    Private Sub btnPerfil_Click(sender As Object, e As EventArgs) Handles btnPerfil.Click
        frmActualizarPerfil.Show()
        Me.Close()
    End Sub

    Private Sub btnMenuPermisos_Click_1(sender As Object, e As EventArgs)
        frmMenuSA.Show()
        Me.Close()

    End Sub

    Private Sub btnProductos_Click(sender As Object, e As EventArgs) Handles btnProductos.Click
        Dim productos As New frmProducto
        productos.MdiParent = Me
        Me.Panel2.Controls.Add(productos)
        productos.Show()
    End Sub

    Private Sub btnActividades_Click(sender As Object, e As EventArgs) Handles btnActividades.Click
        Dim actividades As New frmActividad
        actividades.MdiParent = Me
        Me.Panel2.Controls.Add(actividades)
        actividades.Show()
    End Sub

    Private Sub btnPatrocinadores_Click(sender As Object, e As EventArgs) Handles btnPatrocinadores.Click
        Dim patrocinadores As New frmPatrocinadores
        patrocinadores.MdiParent = Me
        Me.Panel2.Controls.Add(patrocinadores)
        patrocinadores.Show()
    End Sub

    Private Sub btnPremios_Click(sender As Object, e As EventArgs) Handles btnPremios.Click
        Dim premios As New frmPremios
        premios.MdiParent = Me
        Me.Panel2.Controls.Add(premios)
        premios.Show()
    End Sub

    Private Sub btnRanking_Click(sender As Object, e As EventArgs) Handles btnRanking.Click
        Dim ranking As New frmRanking
        ranking.MdiParent = Me
        Me.Panel2.Controls.Add(ranking)
        ranking.Show()
    End Sub

    Private Sub btnInscripciones_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub btnInscripcion_Click(sender As Object, e As EventArgs) Handles btnInscripcion.Click
        Dim inscripciones As New frmInscripciones
        inscripciones.MdiParent = Me
        Me.Panel2.Controls.Add(inscripciones)
        inscripciones.Show()
    End Sub

    Private Sub btnCategorias_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub btnActividad_Click(sender As Object, e As EventArgs) Handles btnCategoria.Click
        Dim categorias As New frmCategoria
        categorias.MdiParent = Me
        Me.Panel2.Controls.Add(categorias)
        categorias.Show()
    End Sub

    Private Sub btnCerrar_Click(sender As Object, e As EventArgs) Handles btnCerrar.Click
        Application.Exit()
    End Sub

    Private Sub btnDashboard_Click(sender As Object, e As EventArgs) Handles btnDashboard.Click
        Dim formDashboardAdmin As New frmDashboardAdministrador
        formDashboardAdmin.MdiParent = Me
        Me.Panel2.Controls.Add(formDashboardAdmin)
        formDashboardAdmin.Show()
    End Sub


    Private Sub btnConfiguracion_MouseHover(sender As Object, e As EventArgs) Handles btnConfiguracion.MouseHover

        btnConfiguracion.ContextMenuStrip.Show(btnConfiguracion.PointToScreen(btn.Location))

    End Sub

    Private Sub mnsConfiguracion_ItemClicked(sender As Object, e As ToolStripItemClickedEventArgs) Handles mnsConfiguracion.ItemClicked

    End Sub

    Private Sub Panel2_MouseHover(sender As Object, e As EventArgs) Handles Panel2.MouseHover
        mnsConfiguracion.Visible = False
    End Sub

    Private Sub mnsConfiguracion_MouseHover(sender As Object, e As EventArgs) Handles mnsConfiguracion.MouseHover
        mnsConfiguracion_Click(Me, e)

    End Sub

    Private Sub ToolStripMenuItem1_Click_1(sender As Object, e As EventArgs) Handles ToolStripMenuItem1.Click

    End Sub

    Private Sub mnsConfiguracion_Click(sender As Object, e As EventArgs) Handles mnsConfiguracion.Click







    End Sub

    Private Sub ContextMenuStrip1_MouseHover(sender As Object, e As EventArgs) Handles ContextMenuStrip1.MouseHover

    End Sub

    Private Sub HolaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles HolaToolStripMenuItem.Click
        txtConfiguracion.Text = 1
        frmActualizarPerfil.Show()
        Me.Close()

    End Sub

    Private Sub CambiarContraseñaToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles CambiarContraseñaToolStripMenuItem1.Click
        txtConfiguracion.Text = 2
        frmActualizarPerfil.Show()
        Me.Close()
    End Sub

    Private Sub ActualizarFotoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ActualizarFotoToolStripMenuItem.Click
        txtConfiguracion.Text = 3
        frmActualizarPerfil.Show()
        Me.Close()
    End Sub

    Private Sub btnEmpresas_Click_1(sender As Object, e As EventArgs) Handles btnEmpresas.Click
        Dim empresas As New frmEntidad
        empresas.MdiParent = Me
        Me.Panel2.Controls.Add(empresas)
        empresas.Show()
    End Sub

    Private Sub btnMenuPermisos_Click_2(sender As Object, e As EventArgs) Handles btnMenuPermisos.Click
        frmMenuSA.Show()
        Me.Close()
    End Sub
    Private Sub botonDashboard()
        Dim formDashboardAdmin As New frmDashboardAdministrador
        formDashboardAdmin.MdiParent = Me
        Me.Panel2.Controls.Add(formDashboardAdmin)
        formDashboardAdmin.Show()
    End Sub

    Private Sub btnRutas_Click(sender As Object, e As EventArgs) Handles btnRutas.Click
         Dim rutas As New frmRutas
        rutas.MdiParent = Me
        Me.Panel2.Controls.Add(rutas)
        rutas.Show()
    End Sub
End Class