
Imports Challengeme.ApiCore
Imports Challengeme.Entities
Imports Challengeme.Util
Imports MessagingToolkit.QRCode.Codec

Public Class frmInscripciones
    Dim managerDeInscripciones As New InscripcionManagement
    Dim managerDeEvento As New EventoManagement
    Dim managerDeUsuario As New UserManagement
    Dim CodUsuario As String
    Dim CodEvento As Integer
    Dim _em As New ExceptionManagement
    Dim NomEvento As String
    Dim NomUsuario As String

    Private Sub frmInscripciones_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lblFecha.Text = DateTime.Now.ToString("dd/MM/yyyy")
        cargarPermisos()
        generarIdInscripcion()

        cargarComboEvento()
        cargarComboUsuario()
        listarInscripciones()

    End Sub
    Private Function QuickResponseGenerator(input As String, qrlevel As Integer) As Image

        Dim bm As Bitmap

        Dim qr As QRCodeEncoder = New QRCodeEncoder()
        qr.QRCodeEncodeMode = QRCodeEncoder.ENCODE_MODE.BYTE
        qr.QRCodeErrorCorrect = QRCodeEncoder.ERROR_CORRECTION.L
        qr.QRCodeVersion = qrlevel
        bm = qr.Encode(input)



        Return bm

    End Function
    Private Sub generarIdInscripcion()
        Dim Cod As Integer

        Try
            Dim listaId = managerDeInscripciones.RetrieveAlls(Of Inscripcion) 'igualo a la lista lo que encontró el procedimiento de listar
            For i As Integer = 0 To listaId.Count - 1 'hago el recorrido por la lista
                If (listaId.Item(i).Estado_Inscripcion = "INACTIVO") Then
                    Cod = listaId.Item(i).IdInscripcion

                Else
                    Cod = listaId.Item(i).IdInscripcion
                End If

                'hace un recorrido por toda la lista y encuenta el ultimo codigo ingresado

            Next
            txtIdInscripcion.Text = Cod + 1 'a ese ultimo codigo ingresado le suma uno y ya tenemos el codigo sgte.
            txtIdInscripcion.Enabled = False

        Catch ex As ChallengeMeException
            _em.ManageException(ex)
        End Try





    End Sub
    Private Sub cargarComboEvento()
        Dim listaEventos = managerDeEvento.RetrieveAllEventos(Of Evento)

        For Each evento As Evento In listaEventos
            If (evento.Estado_Evento = "INACTIVO") Then

            Else
                cboEvento.Items.Add(evento.NombreEvento)

            End If


        Next
    End Sub
    Private Sub cargarComboUsuario()

        Dim listaUsuarios = managerDeUsuario.RetrieveAlls(Of User)

        For Each usuario As User In listaUsuarios

            cboUsuario.Items.Add(usuario.NombreUsuario)

        Next

    End Sub

    Private Sub cboUsuario_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboUsuario.SelectedIndexChanged
        Dim usuario As New User
        usuario.NombreUsuario = cboUsuario.Text

        Dim listaNombresUsuarios = managerDeUsuario.RetrieveByName(Of User)(usuario)

        For Each usuarios As User In listaNombresUsuarios
            If (usuario.NombreUsuario = cboUsuario.Text) Then
                CodUsuario = usuarios.IdUsuario
            End If

        Next

    End Sub

    Private Sub ToolStripBtnGuardar_Click(sender As Object, e As EventArgs) Handles ToolStripBtnGuardar.Click

        Dim inscripcion As New Inscripcion

        'SE VALIDA QUE LOS CAMPOS NO VAYAN VACÍOS
        erProveedorError.Clear()

        If (Trim(cboEvento.SelectedIndex = -1)) Then
            erProveedorError.SetError(cboEvento, "Debe seleccionar un evento de la lista")
            cboEvento.Focus()
            Return
        End If
        If (cboUsuario.SelectedIndex = -1) Then
            erProveedorError.SetError(cboUsuario, "Debe seleccionar el usuario que va a participar en el evento")
            cboUsuario.Focus()
            Return
        End If

        If (Trim(cboTipoInscripcion.SelectedIndex = -1)) Then
            erProveedorError.SetError(cboTipoInscripcion, "Debe seleccionar el tipo de inscripción para el evento")
            cboTipoInscripcion.Focus()
            Return
        End If

        inscripcion.IdInscripcion = txtIdInscripcion.Text
        inscripcion.IdEvento = CodEvento
        inscripcion.IdUsuario = CodUsuario
        inscripcion.FechaInscripcion = lblFecha.Text
        inscripcion.tipoInscripcion = cboTipoInscripcion.Text
        'genera el QR

        Dim Numero_Inscripcion As String = "Código Inscripción : "
        txtIdInscripcion.Text = cboEvento.Text & vbCrLf & cboUsuario.Text & vbCrLf & Numero_Inscripcion & txtIdInscripcion.Text

        pbQR.Image = QuickResponseGenerator(txtIdInscripcion.Text, 53)
        inscripcion.QRInscripcion = pbQR.Image

        managerDeInscripciones.CreateInscripcion(inscripcion)
        listarInscripciones()
        cboEvento.Text = ""
        cboUsuario.Text = ""
        cboTipoInscripcion.Text = ""
        generarIdInscripcion()
    End Sub

    Private Sub cboEvento_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboEvento.SelectedIndexChanged
        Dim evento As New Evento
        evento.NombreEvento = cboEvento.Text

        Dim listaEventos = managerDeEvento.RetrieveByName(Of Evento)(evento)

        For Each eventos As Evento In listaEventos
            If (eventos.NombreEvento = cboEvento.Text) Then
                CodEvento = eventos.IdEvento
            End If

        Next
    End Sub
    Private Sub listarInscripciones()
        'SE TRAE TODO LO QUE HAYA EN LA TABLA DE INSCRIPCIONES
        dgvListaInscripcionesEvento.Rows.Clear()
        Dim listaInscripciones = managerDeInscripciones.RetrieveAlls(Of Inscripcion)
        Dim resizedImage As Image

        For Each inscripcion As Inscripcion In listaInscripciones
            'PARA CADA INSCRIPCION HAGA
            If (inscripcion.QRInscripcion IsNot Nothing) Then
                resizedImage = (inscripcion.QRInscripcion).GetThumbnailImage(48, 48, Nothing, IntPtr.Zero)

            Else
                resizedImage = Nothing

            End If
            Dim eventos As New Evento
            'SE TOMA EL ID DEL EVENTO QUE ESTÁ GUARDADO EN LA TABLA DE INSCRIPCIONES
            eventos.IdEvento = inscripcion.IdEvento
            'SE MANDA A BUSCAR EL NOMBRE DEL EVENTO A TRAVES DE SU ID DIRECTAMENTE A LA TABLA
            'DE EVENTOS
            eventos = managerDeEvento.RetrieveEvento(eventos)
            'SE PEGA EL NOMBRE DEL EVENTO QUE COINCIDA CON EL ID BUSCADO
            ' EN LA VARIABLE NOMEVENTO PARA LUEGO MOSTRARLA EN EL GRID
            NomEvento = eventos.NombreEvento

            'CON USUARIO SE HACE LO MISMO QUE CON EL EVENTO
            '--- HECHO POR ERICK----
            Dim usuarios As New User
            usuarios.IdUsuario = inscripcion.IdUsuario
            usuarios = managerDeUsuario.Retrieve(usuarios)
            NomUsuario = usuarios.NombreUsuario

            dgvListaInscripcionesEvento.Rows.Add(inscripcion.IdInscripcion, inscripcion.IdEvento, NomEvento, inscripcion.IdUsuario, NomUsuario, inscripcion.tipoInscripcion, resizedImage)



        Next
    End Sub
    Private Sub cargarPermisos()

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
                If (obj.Area = "EVENTOS") Then
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

    Private Sub dgvListaInscripcionesEvento_MouseClick(sender As Object, e As MouseEventArgs) Handles dgvListaInscripcionesEvento.MouseClick
        Dim inscripion As New Inscripcion

        If dgvListaInscripcionesEvento.Rows.Count > 0 Then


            txtIdInscripcion.Text = (dgvListaInscripcionesEvento.CurrentRow.Cells("IdInscripcion").Value)

            cboEvento.Items.Clear()
            cboEvento.Items.Add(dgvListaInscripcionesEvento.CurrentRow.Cells("NombreEvento").Value)
            cboEvento.SelectedIndex = 0

            cboUsuario.Items.Clear()
            cboUsuario.Items.Add(dgvListaInscripcionesEvento.CurrentRow.Cells("Usuario").Value)
            cboUsuario.SelectedIndex = 0

            cboTipoInscripcion.Items.Clear()
            cboTipoInscripcion.Items.Add(dgvListaInscripcionesEvento.CurrentRow.Cells("TipoInscripcion").Value)
            cboTipoInscripcion.SelectedIndex = 0



            inscripion.IdInscripcion = txtIdInscripcion.Text

            inscripion = managerDeInscripciones.Retrieve(inscripion)

            pbQR.Image = inscripion.QRInscripcion



        End If
    End Sub

    Private Sub ToolStripBtnNuevo_Click(sender As Object, e As EventArgs) Handles ToolStripBtnNuevo.Click
        listarInscripciones()
        cboEvento.Text = ""
        cboUsuario.Text = ""
        cboTipoInscripcion.Text = ""
        pbQR.Image = Nothing
        generarIdInscripcion()
    End Sub

    Private Sub ToolStripBtnEliminar_Click(sender As Object, e As EventArgs) Handles ToolStripBtnEliminar.Click
        Dim inscripcion As New Inscripcion
        inscripcion.IdInscripcion = txtIdInscripcion.Text

        managerDeInscripciones.Delete(inscripcion)

        MessageBox.Show("Inscripción eliminada satisfactoriamente..!", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Information)
        listarInscripciones()
        cboEvento.Text = ""
        cboUsuario.Text = ""
        cboTipoInscripcion.Text = ""
        pbQR.Image = Nothing
        generarIdInscripcion()

    End Sub

    Private Sub ToolStripBtnActualizar_Click(sender As Object, e As EventArgs) Handles ToolStripBtnActualizar.Click
        Dim inscripcion As New Inscripcion

        inscripcion.IdInscripcion = txtIdInscripcion.Text
        inscripcion.IdEvento = CodEvento
        inscripcion.IdUsuario = CodUsuario
        inscripcion.FechaInscripcion = lblFecha.Text
        inscripcion.tipoInscripcion = cboTipoInscripcion.Text

        Dim Numero_Inscripcion As String = "Código Inscripción : "
        txtIdInscripcion.Text = cboEvento.Text & vbCrLf & cboUsuario.Text & vbCrLf & Numero_Inscripcion & txtIdInscripcion.Text

        pbQR.Image = QuickResponseGenerator(txtIdInscripcion.Text, 53)
        inscripcion.QRInscripcion = pbQR.Image

        managerDeInscripciones.Update(inscripcion)
        listarInscripciones()
        cboEvento.Text = ""
        cboUsuario.Text = ""
        cboTipoInscripcion.Text = ""
        generarIdInscripcion()
    End Sub

    Private Sub btnImprimir_Click(sender As Object, e As EventArgs) Handles btnImprimir.Click
        Dim idInscripcion As Integer = txtIdInscripcion.Text

        If (pbQR.Image Is Nothing) Then
            MessageBox.Show("Debe seleccionar una inscripción de la tabla para poder imprimirla", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Information)

        Else

            FrmReporteInscripciones.txtIdInscripcion.Text = txtIdInscripcion.Text 
            FrmReporteInscripciones.Show()

        End If


    End Sub
End Class