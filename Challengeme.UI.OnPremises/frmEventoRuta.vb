Imports Challengeme.ApiCore
Imports Challengeme.Entities

Public Class frmEventoRuta
    Dim listaDeRutas As New List(Of RutaEvento)
    Dim listaDeRutasDisponibles As New List(Of RutaEvento)
    Dim listaDeRutasAsignadasAlEvento As New List(Of RutaEvento)
    Dim managerDeRutas As New RutaManagement
    Dim managerDeRutasDeEvento As New EventoRutaManagement

    Private Sub OnFormLoad(sender As Object, e As EventArgs) Handles MyBase.Load
        txtNombreEventoRuta.Text = EventoGlobals.nombreDelEvento
        CargarTablaDeRutasAsignadasAlEvento()
        cargarTablaDeRutasDisponibles()
    End Sub

    Private Sub cargarTablaDeRutasDisponibles()

        DataGridViewRutasDisponibles.Rows.Clear()

        Try

            listaDeRutas = managerDeRutas.RetrieveAll(Of RutaEvento)

            listaDeRutasDisponibles.Clear()

            CargarListaDeRutasDisponibles()

        Catch ex As ChallengeMeException

        End Try

        If (listaDeRutasDisponibles IsNot Nothing) Then

            For Each ruta As RutaEvento In listaDeRutasDisponibles

                Dim rowRuta = {
                ruta.idRuta,
                ruta.nombreRuta,
                ruta.direccionRuta
                }

                DataGridViewRutasDisponibles.Rows.Add(rowRuta)

            Next

        End If

    End Sub

    Private Sub CargarTablaDeRutasAsignadasAlEvento()

        DataGridViewRutasDelEvento.Rows.Clear()

        Try
            listaDeRutasAsignadasAlEvento.Clear()
            listaDeRutasAsignadasAlEvento = managerDeRutas.RetrieveAllRutasByIdEvento(Of RutaEvento)(EventoGlobals.idDelEvento)

        Catch ex As ChallengeMeException

        End Try

        If (listaDeRutasAsignadasAlEvento IsNot Nothing) Then

            For Each rutaEvento As RutaEvento In listaDeRutasAsignadasAlEvento

                Dim rowRuta = {
                rutaEvento.idRuta,
                rutaEvento.nombreRuta,
                rutaEvento.direccionRuta
                }

                DataGridViewRutasDelEvento.Rows.Add(rowRuta)

            Next

        End If
    End Sub


    Private Sub CargarListaDeRutasDisponibles()

        Dim ignorarRuta = False

        If (listaDeRutas IsNot Nothing) Then

            For Each rutaEvento As RutaEvento In listaDeRutas

                For Each row As DataGridViewRow In DataGridViewRutasDelEvento.Rows

                    If (rutaEvento.idRuta Like row.Cells(0).Value) Then
                        ignorarRuta = True
                        Exit For
                    End If

                Next

                If (ignorarRuta Like False) Then
                    listaDeRutasDisponibles.Add(rutaEvento)
                End If
                ignorarRuta = False
            Next

        End If

    End Sub

    Private Sub ButtonAgregar_Click(sender As Object, e As EventArgs) Handles ButtonAgregar.Click

        Dim listaDeRutasSeleccionadas = DataGridViewRutasDisponibles.SelectedRows

        If (Not listaDeRutasSeleccionadas.Count Like 0) Then
            For Each rutaSeleccionada As DataGridViewRow In listaDeRutasSeleccionadas

                Dim eventoRuta As New EventoRuta
                With eventoRuta
                    .IdEvento = EventoGlobals.idDelEvento
                    .IdRuta = rutaSeleccionada.Cells(0).Value
                End With

                Try
                    managerDeRutasDeEvento.CreateRelacionEventoRuta(eventoRuta)
                Catch ex As Exception

                End Try

            Next

            CargarTablaDeRutasAsignadasAlEvento()
            cargarTablaDeRutasDisponibles()

        Else

            MessageBox.Show("Por favor seleccione la fila completa de la ruta que desea agregar", "Atencion !")

        End If

    End Sub

    Private Sub ButtonQuitar_Click(sender As Object, e As EventArgs) Handles ButtonQuitar.Click

        Dim listaDeRutasSeleccionadas = DataGridViewRutasDelEvento.SelectedRows

        If (Not listaDeRutasSeleccionadas.Count Like 0) Then

            For Each rutaSeleccionada As DataGridViewRow In listaDeRutasSeleccionadas

                Dim eventoRuta As New EventoRuta
                With eventoRuta
                    .IdEvento = EventoGlobals.idDelEvento
                    .IdRuta = rutaSeleccionada.Cells(0).Value
                End With

                Try
                    managerDeRutasDeEvento.DeleteRelacionEventoRuta(eventoRuta)
                Catch ex As Exception

                End Try

            Next

            CargarTablaDeRutasAsignadasAlEvento()
            cargarTablaDeRutasDisponibles()

        Else

            MessageBox.Show("Por favor seleccione la fila completa de la ruta que desea eliminar", "Atencion !")

        End If

    End Sub

    Private Sub ButtonEventoRutaOk_Click(sender As Object, e As EventArgs) Handles ButtonEventoRutaOk.Click
        Me.Close()
    End Sub
End Class