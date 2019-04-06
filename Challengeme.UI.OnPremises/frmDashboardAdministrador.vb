Imports Challengeme.ApiCore
Imports Challengeme.Entities

Public Class frmDashboardAdministrador
    Dim managerDeInscripcion As New InscripcionManagement
    Dim CodEventoInscripion As Integer
    Dim CodUsuarioInscripcion As String
    Dim CodPatrocinador As Integer
    Dim VarNombreEvento As String
    Dim VarNombreUsuario As String
    Dim managerDeEvento As New EventoManagement
    Dim managerDeUsuarios As New UserManagement
    Dim managerDePatrocinadores As New PatrocinadorManagement
    Dim managerDeEventoPatrocinador As New EventoPatrocinadorManagement
    Dim managerDeEventoProducto As New EventoProductoManagement
    Dim montoPatrocinio As Decimal
    Dim FechaInicioEvento As Date
    Dim CupoMaxEvento As Integer
    Dim PorcentajeInscrito As Double



    Private Sub frmDashboardAdministrador_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lblFechaActual.Text = DateTime.Today.ToString("dd/MMMM/yyyy")
        cargarEventoInscripciones()
    End Sub
    Private Sub cargarEventoInscripciones()
        Dim ContParticipante As Integer = 0
        Dim ContPatrocinador As Integer = 0
        Dim TotalPatrocinioEvento As Decimal = 0

        'PRIMERO SE BUSCAR TODO LO QUE HAY EN LA TABLA DE EVENTO 
        'PARA TRAER SOLO LOS EVENTOS CUYA FECHA DE INICIO 
        'AUN NO HAYA PASDO
        Dim lstEvento = managerDeEvento.RetrieveAllEventos(Of Evento)
        For Each fechaEvento As Evento In lstEvento
            'SI LA FECHA ACTUAL ES MAYOR A LA FECHA DE INICIO DE CUALQUIER EVENTO
            'ENTONCES DICHO EVENTO YA SE EFECTUÓ, POR LO TANTO NO DEBERIA DE LISTARSE
            'EN LA TABLA DE EVENTOS PROXIMOS
            FechaInicioEvento = fechaEvento.FechaInicioEvento
            If (lblFechaActual.Text > FechaInicioEvento) Then


            Else
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
                    If (cboCodEvento.Items.Contains(eventoInscripion.IdEvento)) Then


                    Else



                        Dim listaEventoProductoPatrocinador = managerDeEventoProducto.RetrieveAllEventoProducto(Of EventoProducto)
                        For Each eventoProductoPatrocinador As EventoProducto In listaEventoProductoPatrocinador

                            If (CodEventoInscripion = eventoProductoPatrocinador.IdEvento) Then
                                CodPatrocinador = eventoProductoPatrocinador.IdPatrocinador

                                montoPatrocinio = eventoProductoPatrocinador.ValorTotalProducto


                                Dim listaEventos = managerDeEvento.RetrieveAllEventos(Of Evento)
                                For Each evento As Evento In listaEventos

                                    If (CodEventoInscripion = evento.IdEvento) Then
                                        CupoMaxEvento = evento.CupoEvento
                                        VarNombreEvento = evento.NombreEvento
                                        If (cboEvento.Items.Contains(evento.NombreEvento)) Then


                                        Else
                                            cboEvento.Items.Add(evento.NombreEvento)
                                            cboCodEvento.Items.Add(evento.IdEvento)
                                        End If

                                    End If




                                Next
                                If (cboIdPatrocinador.Items.Contains(CodPatrocinador)) Then
                                    ContPatrocinador += 1

                                Else
                                    ContPatrocinador += 1
                                End If

                            End If
                            TotalPatrocinioEvento = TotalPatrocinioEvento + montoPatrocinio

                        Next
                        Dim listaUsuarios = managerDeUsuarios.RetrieveAlls(Of User)()
                        For Each usuario As User In listaUsuarios
                            If (CodUsuarioInscripcion = usuario.IdUsuario) Then
                                cboParticipante.Items.Add(usuario.NombreUsuario)
                                ContParticipante += 1

                            End If



                        Next
                        PorcentajeInscrito = FormatNumber(((ContParticipante * 100) / CupoMaxEvento), 2)


                        dgvListaParticipanteEvento.Rows.Add(VarNombreEvento, FechaInicioEvento,ContParticipante, CupoMaxEvento, PorcentajeInscrito, ContPatrocinador, FormatNumber(TotalPatrocinioEvento), 2)
                    End If

                Next


            End If




        Next

    End Sub


End Class