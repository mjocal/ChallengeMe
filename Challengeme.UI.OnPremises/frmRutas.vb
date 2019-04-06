Imports System.ComponentModel
Imports System.Runtime.InteropServices
Imports Challengeme.ApiCore
Imports Challengeme.Entities
Imports GMap.NET
Imports GMap.NET.WindowsForms
Imports GMap.NET.WindowsForms.Markers

Public Class frmRutas

    Public _ExeptionManager As New ExceptionManagement
    Dim managerDeRutas As New RutaManagement
    Dim managerDePuntosDeRuta As New PuntoRutaManagement
    Dim listaDeRutas
    Private Sub OnFormLoad(sender As Object, e As EventArgs) Handles MyBase.Load
        cargarPermisos()
        txtIdPuntoRuta.Enabled = False

        LoadListaDeRutas()

        SendMessage(Me.txtDireccionRuta.Handle, &H1501, 0, "Lugar, Ciudad, Provincia, Pais")

        MapProviders.GMapProvider.UserAgent = "Challengeme"
        mapaRutas.MapProvider = GMap.NET.MapProviders.GoogleMapProvider.Instance
        GMap.NET.GMaps.Instance.Mode = GMap.NET.AccessMode.ServerOnly
        mapaRutas.ShowCenter = False
        mapaRutas.CanDragMap = True
        mapaRutas.DragButton = MouseButtons.Left
        mapaRutas.SetPositionByKeywords("Parque Central, San Jose, Costa Rica")

    End Sub

    <DllImport("user32.dll", CharSet:=CharSet.Auto)>
    Private Shared Function SendMessage(ByVal hWnd As IntPtr, ByVal msg As Integer, ByVal wParam As Integer, <MarshalAs(UnmanagedType.LPWStr)> ByVal lParam As String) As Int32
    End Function

    Private Sub ButtonIrALugar_Click(sender As Object, e As EventArgs) Handles ButtonIrALugar.Click
        Dim direccion As String

        direccion = txtDireccionRuta.Text

        mapaRutas.SetPositionByKeywords(direccion)
    End Sub

    Private Sub ButtonGuardarDireccion_Click(sender As Object, e As EventArgs) Handles ButtonGuardarDireccion.Click

        Try

            Dim ruta As New RutaEvento
            With ruta
                .idRuta = txtIdRuta.Text
                .nombreRuta = txtNombreRuta.Text
                .direccionRuta = txtDireccionRuta.Text
            End With

            managerDeRutas.CreateRuta(ruta)

            MessageBox.Show("La Ruta se ha creado con exito.", "Transaccon Exitosa!", MessageBoxButtons.OK)

            LoadListaDeRutas()

        Catch ex As ChallengeMeException

            _ExeptionManager.ManageException(ex)

        End Try

    End Sub

    'Carga todas las rutas de la base de datos
    Private Sub LoadListaDeRutas()
        Try

            listaDeRutas = managerDeRutas.RetrieveAll(Of RutaEvento)

        Catch ex As ChallengeMeException

        End Try

        LoadComboBoxRutas()

    End Sub

    Private Sub LoadComboBoxRutas()

        ComboBoxRutas.Items.Clear()

        If (listaDeRutas IsNot Nothing) Then

            For Each ruta As RutaEvento In listaDeRutas

                ComboBoxRutas.Items.Add(ruta.nombreRuta)

            Next

        End If

    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBoxRutas.SelectedIndexChanged

        For Each ruta In listaDeRutas

            If (ruta.nombreRuta Like ComboBoxRutas.SelectedItem) Then

                txtIdRuta.Text = ruta.idRuta
                txtNombreRuta.Text = ruta.nombreRuta
                txtDireccionRuta.Text = ruta.direccionRuta

                mapaRutas.SetPositionByKeywords(ruta.direccionRuta)

            End If
        Next
        LoadTablaPuntosRuta()
    End Sub

    Private Sub ButtonLimpiar_Click(sender As Object, e As EventArgs) Handles ButtonLimpiar.Click
        txtIdRuta.Text = ""
        txtNombreRuta.Text = ""
        txtDireccionRuta.Text = ""
    End Sub

    Private Sub ButtonModificarRuta_Click(sender As Object, e As EventArgs) Handles ButtonModificarRuta.Click

        Try
            Dim ruta As New RutaEvento
            With ruta
                .idRuta = txtIdRuta.Text
                .nombreRuta = txtNombreRuta.Text
                .direccionRuta = txtDireccionRuta.Text
            End With

            managerDeRutas.Update(ruta)

            MessageBox.Show("La Ruta se ha actualizado con exito.", "Transaccon Exitosa!", MessageBoxButtons.OK)

            LoadListaDeRutas()

        Catch ex As ChallengeMeException

            _ExeptionManager.ManageException(ex)

        End Try

    End Sub

    Private Sub ButtonBorrarRuta_Click(sender As Object, e As EventArgs) Handles ButtonBorrarRuta.Click
        If MsgBox("Esta seguro que desea borrar esta ruta?", MsgBoxStyle.YesNo, "Alerta!") = MsgBoxResult.Yes Then

            Try
                Dim ruta As New RutaEvento
                With ruta
                    .idRuta = txtIdRuta.Text
                    .nombreRuta = txtNombreRuta.Text
                    .direccionRuta = txtDireccionRuta.Text
                End With

                managerDeRutas.Delete(ruta)

                LoadListaDeRutas()

                MessageBox.Show("La Ruta se ha borrado con exito.", "Transaccon Exitosa!", MessageBoxButtons.OK)

            Catch ex As ChallengeMeException

                _ExeptionManager.ManageException(ex)

            End Try

        End If
    End Sub

    Private Sub LoadTablaPuntosRuta()
        mapaRutas.Overlays.Clear()
        Dim routes As GMapOverlay = New GMapOverlay("routes")
        Dim points As List(Of PointLatLng) = New List(Of PointLatLng)()
        Dim markers As GMapOverlay = New GMapOverlay("markers")


        DataGridViewPuntoRuta.Rows.Clear()

        Dim puntoRutaRetrieveObj As New PuntoRuta
        With puntoRutaRetrieveObj
            .idRuta = txtIdRuta.Text
        End With

        Dim listaDePuntosRuta = managerDePuntosDeRuta.RetrieveAllPuntoRutaByIdRuta(Of PuntoRuta)(puntoRutaRetrieveObj)

        For Each puntoRuta As PuntoRuta In listaDePuntosRuta

            Dim rowPuntoRuta = {
                puntoRuta.idPuntoRuta,
                puntoRuta.nombrePunto,
                puntoRuta.latitudRuta,
                puntoRuta.longitudRuta
                }

            points.Add(New PointLatLng(puntoRuta.latitudRuta, puntoRuta.longitudRuta))

            Dim marker As GMapMarker = New GMarkerGoogle(
                New PointLatLng(puntoRuta.latitudRuta, puntoRuta.longitudRuta),
                GMarkerGoogleType.red_dot)
            marker.ToolTipText = puntoRuta.nombrePunto
            marker.ToolTip.Fill = Brushes.Black
            marker.ToolTip.Foreground = Brushes.White
            marker.ToolTip.Stroke = Pens.Black
            marker.ToolTip.TextPadding = New Size(20, 20)
            markers.Markers.Add(marker)

            DataGridViewPuntoRuta.Rows.Add(rowPuntoRuta)
        Next

        Dim route As GMapRoute = New GMapRoute(points, "A walk in the park")
        route.Stroke = New Pen(Color.Green, 3)
        txtDistanciaTotal.Text = route.Distance()
        routes.Routes.Add(route)
        mapaRutas.Overlays.Add(routes)
        mapaRutas.Overlays.Add(markers)
        mapaRutas.Refresh()

        LimpiarFormularioPuntoRuta()

    End Sub

    Private Sub ButtonAgregarPunto_Click(sender As Object, e As EventArgs) Handles ButtonAgregarPunto.Click

        If (txtIdRuta.Text IsNot "") Then
            If (IsNumeric(txtLatitudPuntoRuta.Text) And IsNumeric(txtLongitudPuntoRuta.Text)) Then
                Dim puntoRuta As New PuntoRuta
                With puntoRuta
                    .idRuta = txtIdRuta.Text
                    .nombrePunto = txtNombrePuntoRuta.Text
                    .latitudRuta = txtLatitudPuntoRuta.Text
                    .longitudRuta = txtLongitudPuntoRuta.Text
                End With

                managerDePuntosDeRuta.CreatePuntoRuta(puntoRuta)
            Else
                MessageBox.Show("Los valores de latitud y longitud deben incluir solo numberos", "Alerta!", MessageBoxButtons.OK)
            End If



            MessageBox.Show("El Punto de Ruta se ha creado con exito.", "Transaccon Exitosa!", MessageBoxButtons.OK)

            LoadTablaPuntosRuta()

        Else
            MessageBox.Show("Favor seleccione o cree una ruta. El espacio ID Ruta debe contener un dato valido", "Alerta!", MessageBoxButtons.OK)
        End If
    End Sub

    Private Sub OnCellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridViewPuntoRuta.CellClick
        Try
            Dim fila As Integer = DataGridViewPuntoRuta.CurrentRow.Index
            txtIdPuntoRuta.Text = DataGridViewPuntoRuta(0, fila).Value.ToString()
            txtNombrePuntoRuta.Text = DataGridViewPuntoRuta(1, fila).Value.ToString()
            txtLatitudPuntoRuta.Text = DataGridViewPuntoRuta(2, fila).Value.ToString()
            txtLongitudPuntoRuta.Text = DataGridViewPuntoRuta(3, fila).Value.ToString()
        Catch ex As Exception

        End Try
    End Sub

    Private Sub ButtonLimpiarCampos_Click(sender As Object, e As EventArgs) Handles ButtonLimpiarCampos.Click
        LimpiarFormularioPuntoRuta()
    End Sub

    Private Sub ButtonModificarPunto_Click(sender As Object, e As EventArgs) Handles ButtonModificarPunto.Click

        If (txtIdRuta.Text IsNot "") Then
            Dim puntoRuta As New PuntoRuta
            With puntoRuta
                .idPuntoRuta = txtIdPuntoRuta.Text
                .idRuta = txtIdRuta.Text
                .nombrePunto = txtNombrePuntoRuta.Text
                .latitudRuta = txtLatitudPuntoRuta.Text
                .longitudRuta = txtLongitudPuntoRuta.Text
            End With

            managerDePuntosDeRuta.UpdatePuntoRuta(puntoRuta)

            MessageBox.Show("El Punto de Ruta se ha actualizado con exito.", "Transaccon Exitosa!", MessageBoxButtons.OK)

            LoadTablaPuntosRuta()

        Else
            MessageBox.Show("Favor seleccione o cree una ruta. El espacio ID Ruta debe contener un dato valido", "Alerta!", MessageBoxButtons.OK)
        End If

    End Sub

    Private Sub ButtonBorrarPunto_Click(sender As Object, e As EventArgs) Handles ButtonBorrarPunto.Click

        If MsgBox("Esta seguro que desea borrar este punto de ruta?", MsgBoxStyle.YesNo, "Alerta!") = MsgBoxResult.Yes Then

            If (txtIdRuta.Text IsNot "") Then
                Dim puntoRuta As New PuntoRuta
                With puntoRuta
                    .idPuntoRuta = txtIdPuntoRuta.Text
                    .idRuta = txtIdRuta.Text
                    .nombrePunto = txtNombrePuntoRuta.Text
                    .latitudRuta = txtLatitudPuntoRuta.Text
                    .longitudRuta = txtLongitudPuntoRuta.Text
                End With

                managerDePuntosDeRuta.DeletePuntoRuta(puntoRuta)

                MessageBox.Show("El Punto de Ruta se ha borrado con exito.", "Transaccon Exitosa!", MessageBoxButtons.OK)

                LoadTablaPuntosRuta()

            Else
                MessageBox.Show("Favor seleccione o cree una ruta. El espacio ID Ruta debe contener un dato valido", "Alerta!", MessageBoxButtons.OK)
            End If

        End If

    End Sub

    Private Sub LimpiarFormularioPuntoRuta()
        txtIdPuntoRuta.Text = ""
        txtNombrePuntoRuta.Text = ""
        txtLatitudPuntoRuta.Text = ""
        txtLongitudPuntoRuta.Text = ""
    End Sub

    Private Sub OnMouseClick(sender As Object, e As MouseEventArgs) Handles mapaRutas.MouseClick
        If (e.Button Like MouseButtons.Left) Then

            Dim latitud = mapaRutas.FromLocalToLatLng(e.X, e.Y).Lat
            Dim longitud = mapaRutas.FromLocalToLatLng(e.X, e.Y).Lng

            txtLatitudPuntoRuta.Text = latitud
            txtLongitudPuntoRuta.Text = longitud

        End If
    End Sub
    Private Sub cargarPermisos()
        Dim pm As New PermisosManagement
        Dim p As New Permisos

        Dim lista = pm.RetrieveAlls(Of Permisos)


        If (NOMBRE_ROL = "SA" Or NOMBRE_ROL = "ORGANIZADOR") Then
            ButtonGuardarDireccion.Enabled = True
            ButtonModificarRuta.Enabled=True
            ButtonBorrarRuta.Enabled=True
            ButtonLimpiar.Enabled=True
            

        Else
            For Each obj In lista
                If (obj.Area = "RUTAS") Then
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
                     ButtonGuardarDireccion.Enabled = True
                Else
                    If ( ButtonGuardarDireccion.Enabled = True) Then
                    Else
                         ButtonGuardarDireccion.Enabled = False

                    End If
                End If

                'If (lst.Item(j) = "BUSCAR") Then
                '    ToolStripBtnBuscar.Enabled = True

                'Else
                '    If (ToolStripBtnBuscar.Enabled = True) Then

                '    Else
                '        ToolStripBtnBuscar.Enabled = False

                '    End If
                'End If

                If (lst.Item(j) = "ACTUALIZAR") Then
                    ButtonModificarRuta.Enabled = True

                Else
                    If (ButtonModificarRuta.Enabled = True) Then

                    Else
                        ButtonModificarRuta.Enabled = False

                    End If
                End If

                If (lst.Item(j) = "ELIMINAR") Then
                     ButtonBorrarRuta.Enabled = True

                Else
                    If ( ButtonBorrarRuta.Enabled = True) Then

                    Else
                         ButtonBorrarRuta.Enabled = False

                    End If
                End If
            Next

        End If




    End Sub

End Class