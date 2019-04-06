Imports Challengeme.ApiCore
Imports Challengeme.Entities

Public Class frmRanking
    Dim managerDeRanking As New RankingManagement
    Dim managerDeEvento As New EventoManagement
    Dim managerDeInscripcion As New InscripcionManagement
    Dim managerDeUsuarios As New UserManagement
    Public _em As New ExceptionManagement
    Dim CodEvento As Integer
    Dim CodEventoInscripion As Integer
    Dim CodUsuarioInscripcion As String
    Dim CodEventoRanking As Integer
    Dim CodUsuarioRanking As String
    Dim NombreEventoRanking As String
    Dim NombreParticipanteRanking As String

    Private Sub frmRanking_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CargarPermisos()
        generarIdRanking()
        listarRanking()
        cargarComboEventoInscripciones()
    End Sub
    Private Sub generarIdRanking()

        Dim Cod As Integer
        Try
            Dim listaId = managerDeRanking.RetrieveAlls(Of Ranking) 'igualo a la lista lo que encontró el procedimiento de listar
            For i As Integer = 0 To listaId.Count - 1 'hago el recorrido por la lista
                If (listaId.Item(i).Estado_Ranking = "INACTIVO") Then
                    Cod = listaId.Item(i).IdRanking
                Else
                    Cod = listaId.Item(i).IdRanking
                End If

                'hace un recorrido por toda la lista y encuenta el ultimo codigo ingresado

            Next
            txtIdRanking.Text = Cod + 1 'a ese ultimo codigo ingresado le suma uno y ya tenemos el codigo sgte.
            txtIdRanking.Enabled = False

        Catch ex As ChallengeMeException
            _em.ManageException(ex)
        End Try
    End Sub

    Private Sub ToolStripBtnNuevo_Click(sender As Object, e As EventArgs)
        txtPosicion.Text = ""
        generarIdRanking()
    End Sub
    Private Sub listarRanking()
        'SE LISTA TODO LO QUE HAY EN LA TABLA DE RANKING
        dgvListaRanking.Rows.Clear()
        Dim listaRanking = managerDeRanking.RetrieveAlls(Of Ranking)

        For Each ranking As Ranking In listaRanking
            'SE PASAN A LAS VARIABLES RESPECTIVAS
            'LOS IDEVENTO Y IDUSUARIO QUE EXISTEN EN 
            'LA TABLA RANKING
            'PARA IR A LAS RESPECTIVAS TABLAS DUEÑAS DE LOS ID Y TRAER LOS NOMBRES
            CodEventoRanking = ranking.IdEvento
            CodUsuarioRanking = ranking.IdUsuario

            'SE LISTA TODO LO QUE HAY EN EVENTO
            Dim listaEventoRanking = managerDeEvento.RetrieveAllEventos(Of Evento)()

            For Each eventoEncontrado As Evento In listaEventoRanking
                'SI EL IDEVENTO DE RANKING ES = AL ID EVENTO DE EVENTO
                If (CodEventoRanking = eventoEncontrado.IdEvento) Then
                    'ENTONCES SE LE PASA A LA VARIABLE NOMBREEVENTORANKING
                    'EL NOMBRRE ENCONTRADO EN LA TABLA EVENTO
                    NombreEventoRanking = eventoEncontrado.NombreEvento
                End If

                'SE LISTA TODO LO QUE HAY EN LA TABLA USUARIO
                Dim listaParticipantes = managerDeUsuarios.RetrieveAlls(Of User)()

                For Each participante As User In listaParticipantes
                    'SI EL IDUSUARIO DE LA TABLA RANKING ES = AL ID USUARIO
                    'DE LA TABLA USUARIOS

                    If (CodUsuarioRanking = participante.IdUsuario) Then
                        'SE PASA EL NOMBRE A LA VARIABLE NOMBREPARTICIPANTERANKING
                        'PARA TRAER EL NOMBRE RESPECTIVO DEL IDUSUARIO ALMACENADO EN LA TABLA
                        'RANKING
                        NombreParticipanteRanking = participante.NombreUsuario
                    End If


                Next
            Next
            '--- HECHO POR ERICK---
            dgvListaRanking.Rows.Add(ranking.IdRanking, ranking.IdEvento, NombreEventoRanking, ranking.IdUsuario, NombreParticipanteRanking, ranking.PosicionUsuario)

        Next

    End Sub

    Private Sub cargarComboEventoInscripciones()
        'SE HACE UN RETRIVE DE TODO LO QUE HAYA EN LA TABLA DE INSCRIPCIONES
        'PARA TRAER LOS ID DE LOS EVENTOS QUE YA TIENEN PARTICIPANTES ACTIVOS
        Dim listaEventosInscripciones = managerDeInscripcion.RetrieveAlls(Of Inscripcion)()

        '
        For Each eventoInscripion As Inscripcion In listaEventosInscripciones
            'PARA CADA ID EVENTO ENCONTRADO EN LA TABLA DE INSCRIPCIONES
            CodEventoInscripion = eventoInscripion.IdEvento
            CodUsuarioInscripcion = eventoInscripion.IdUsuario
            'VA Y BUSCA ESE ID EVENTO EN LA TABLA DE EVENTOS PARA POSTERIOR TRAER EL 
            'NOMBRE DE ESOS EVENTOS QUE YA EXISTEN EN LA TABLA DE INSCRIPCIONES
            Dim listaEventos = managerDeEvento.RetrieveAllEventos(Of Evento)()
            For Each evento As Evento In listaEventos
                If (CodEventoInscripion = evento.IdEvento) Then

                    If (cboEvento.Items.Contains(evento.NombreEvento)) Then


                    Else
                        cboEvento.Items.Add(evento.NombreEvento)

                    End If

                End If
                'DONDE EL ID EVENTO DE EVENTOS SEA IGUAL AL ID EVENTO DE TBL_INSCRIPCIONES
                'SE PEGA EL NOMBRE DE ESOS EVENTOS EN EL COMBO DE EVENTOS



                Dim listaUsuarios = managerDeUsuarios.RetrieveAlls(Of User)()
                For Each usuario As User In listaUsuarios
                    If (cboParticipante.Items.Contains(usuario.NombreUsuario)) Then


                    Else
                        cboParticipante.Items.Add(usuario.NombreUsuario)

                    End If

                Next

            Next

        Next

    End Sub

    Private Sub ToolStripBtnGuardar_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub ToolStripBtnGuardar_Click_1(sender As Object, e As EventArgs) Handles ToolStripBtnGuardar.Click
        Dim ranking As New Ranking

        erProveedorError.Clear()
        If (cboEvento.SelectedIndex = -1) Then
            erProveedorError.SetError(cboEvento, "Debe seleccionar el evento de participación")
            Return
        End If

        If (cboParticipante.SelectedIndex = -1) Then
            erProveedorError.SetError(cboParticipante, "Debe seleccionar el nombre del participante en el evento")
            Return
        End If
        If (Trim(txtPosicion.Text = "")) Then
            erProveedorError.SetError(txtPosicion, "Debe indicar la posición en un número entero en la que finalizó el participante")
            txtPosicion.Focus()
            Return
        End If

        ranking.IdRanking = txtIdRanking.Text
        ranking.IdEvento = txtIdEventoRanking.Text
        ranking.IdUsuario = txtIdUsuarioRanking.Text
        ranking.PosicionUsuario = txtPosicion.Text

        managerDeRanking.CreateRanking(ranking)

        limpiarCampos()
        listarRanking()
        generarIdRanking()


    End Sub

    Private Sub cboEvento_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboEvento.SelectedIndexChanged
        Dim evento As New Evento
        evento.NombreEvento = cboEvento.Text

        Dim listaEventos = managerDeEvento.RetrieveByName(Of Evento)(evento)

        For Each eventos As Evento In listaEventos
            If (eventos.NombreEvento = cboEvento.Text) Then
                txtIdEventoRanking.Text = eventos.IdEvento
            End If

        Next


    End Sub

    Private Sub cboParticipante_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboParticipante.SelectedIndexChanged
        Dim usuario As New User
        usuario.NombreUsuario = cboParticipante.Text

        Dim listaNombresUsuarios = managerDeUsuarios.RetrieveByName(Of User)(usuario)

        For Each usuarios As User In listaNombresUsuarios
            If (usuario.NombreUsuario = cboParticipante.Text) Then
                txtIdUsuarioRanking.Text = usuarios.IdUsuario
            End If

        Next
    End Sub
    Private Sub limpiarCampos()
        cboEvento.Text = ""
        cboParticipante.Text = ""
        txtPosicion.Text = ""

    End Sub

    Private Sub ToolStripBtnEliminar_Click(sender As Object, e As EventArgs) Handles ToolStripBtnEliminar.Click
        Dim ranking As New Ranking


        ranking.IdRanking = txtIdRanking.Text
        ranking = managerDeRanking.Retrieve(ranking)
        If (ranking Is Nothing) Then
            MessageBox.Show("Debe seleccionar una fila de la tabla para poder eliminar el ranking", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Error)

        Else
            managerDeRanking.Delete(ranking)
            limpiarCampos()
            generarIdRanking()
            listarRanking()

        End If


    End Sub

    Private Sub ToolStripBtnActualizar_Click(sender As Object, e As EventArgs) Handles ToolStripBtnActualizar.Click
        Dim ranking As New Ranking


        ranking.IdRanking = txtIdRanking.Text
        ranking = managerDeRanking.Retrieve(ranking)
        If (ranking Is Nothing) Then
            MessageBox.Show("Debe seleccionar una fila de la tabla para actualizar el ranking", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Error)

        Else

            erProveedorError.Clear()
            If (cboEvento.SelectedIndex = -1) Then
                erProveedorError.SetError(cboEvento, "Debe seleccionar el evento de participación")
                Return
            End If

            If (cboParticipante.SelectedIndex = -1) Then
                erProveedorError.SetError(cboParticipante, "Debe seleccionar el nombre del participante en el evento")
                Return
            End If
            If (Trim(txtPosicion.Text = "")) Then
                erProveedorError.SetError(txtPosicion, "Debe indicar la posición en un número entero en la que finalizó el participante")
                txtPosicion.Focus()
                Return
            End If

            ranking.IdRanking = txtIdRanking.Text
            ranking.IdEvento = txtIdEventoRanking.Text
            ranking.IdUsuario = txtIdUsuarioRanking.Text
            ranking.PosicionUsuario = txtPosicion.Text
            managerDeRanking.Update(ranking)
            limpiarCampos()
            generarIdRanking()
            listarRanking()

        End If
    End Sub

    Private Sub dgvListaRanking_MouseClick(sender As Object, e As MouseEventArgs) Handles dgvListaRanking.MouseClick

        If dgvListaRanking.Rows.Count > 0 Then

            txtIdRanking.Text = dgvListaRanking.CurrentRow.Cells("IdRanking").Value
            cboEvento.Items.Clear()
            cboEvento.Items.Add(dgvListaRanking.CurrentRow.Cells("NombreEvento").Value)
            cboEvento.SelectedIndex = 0
            cboParticipante.Items.Clear()
            cboParticipante.Items.Add(dgvListaRanking.CurrentRow.Cells("NombreUsuario").Value)
            cboParticipante.SelectedIndex = 0
            txtPosicion.Text = dgvListaRanking.CurrentRow.Cells("Posicion").Value



        End If
    End Sub

    Private Sub ToolStripBtnNuevo_Click_1(sender As Object, e As EventArgs) Handles ToolStripBtnNuevo.Click
        limpiarCampos()
    End Sub
    Private Sub CargarPermisos()
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
End Class