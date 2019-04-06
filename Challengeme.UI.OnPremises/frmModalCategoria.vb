Imports Challengeme.ApiCore
Imports Challengeme.Entities

Public Class frmModalCategoria
    Public _em As New ExceptionManagement

    Dim managerDeCategorias As New CategoriaManagement
    Private Sub frmModalCategoria_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        GenerarIdCategoria()
        CargarLista()
        Me.Left = 400
        Me.Top = 175
    End Sub
    Private Sub GenerarIdCategoria()
        Try
            Dim Cod As Integer
            Dim listaId = managerDeCategorias.RetrieveAllCategorias(Of Categoria)

            For i = 0 To listaId.Count - 1
                Cod = listaId.Item(i).IdCategoria

            Next
            txtIdCategoria.Text = Cod + 1
            txtIdCategoria.Enabled = False
            txtNombreCategoria.Focus()

        Catch ex As ChallengeMeException
            _em.ManageException(ex)

        End Try
    End Sub

    Private Sub btnGuardar_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click
        Dim n As New Categoria
        Dim u As New Categoria


        erProveedorError.Clear()

        If (txtNombreCategoria.Text = "") Then
            erProveedorError.SetError(txtNombreCategoria, "El nombre de la categoría no puede estar vacío")

            Return
        End If

        n.IdCategoria = txtIdCategoria.Text
        n.NombreCategoria = txtNombreCategoria.Text

        Try


            managerDeCategorias.CreateCategoria(n)
            MessageBox.Show("Categoría registrada con exito.", "FELICIDADES!", MessageBoxButtons.OK)


            LimpiarCampos()



        Catch ex As ChallengeMeException
            _em.ManageException(ex)
        End Try

        CargarLista()
    End Sub
    Private Sub LimpiarCampos()

        txtIdCategoria.Enabled = True

        txtIdCategoria.Text = ""
        txtNombreCategoria.Text = ""

        txtIdCategoria.Focus()
    End Sub
    Private Sub CargarLista()

        dgvListaCategorias.Rows.Clear()

        Dim listaDeCategorias = managerDeCategorias.RetrieveAllCategorias(Of Categoria)

        For Each categoria As Categoria In listaDeCategorias

            Dim rowCategoria =
                    {
                        categoria.IdCategoria,
                        categoria.NombreCategoria
                    }

            dgvListaCategorias.Rows.Add(rowCategoria)

        Next
    End Sub

    Private Sub btnAgregar_Click(sender As Object, e As EventArgs) Handles btnAgregar.Click
        Me.Close()
    End Sub
End Class