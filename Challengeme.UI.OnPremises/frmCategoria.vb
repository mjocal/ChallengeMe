Imports Challengeme.ApiCore
Imports Challengeme.Entities

Public Class frmCategoria

    Public _em As New ExceptionManagement

    Dim managerDeCategorias As New CategoriaManagement

    Private Sub frmCategoria_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CargarLista()
        txtIdCategoria.Focus()
        cargarPermisosCategoria()
        GenerarIdCategoria()
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

    Private Sub GenerarIdCategoria()
        Try
            Dim Cod As Integer
            Dim listaId = managerDeCategorias.RetrieveAllCategorias(Of Categoria) 

            For i = 0 To listaId.Count - 1 
                If(listaId.Item(i).Estado_Categoria="INACTIVO")Then
                    Cod = listaId.Item(i).IdCategoria

                Else
                    Cod = listaId.Item(i).IdCategoria
                End If
                

            Next
            txtIdCategoria.Text = Cod + 1 
            txtIdCategoria.Enabled = False
            txtNombreCategoria.Focus

        Catch ex As ChallengeMeException
            _em.ManageException(ex)

        End Try
    End Sub
    Private Sub LimpiarCampos()

        txtIdCategoria.Enabled = True

        txtIdCategoria.Text = ""
        txtNombreCategoria.Text = ""

        txtIdCategoria.Focus()
    End Sub
    Private Sub dgvListaCategorias_DoubleClick(sender As Object, e As EventArgs) Handles dgvListaCategorias.DoubleClick

        Dim i As Integer
        i = dgvListaCategorias.CurrentRow.Index

        txtIdCategoria.Text = dgvListaCategorias.Item(0, i).Value
        txtNombreCategoria.Text = dgvListaCategorias.Item(1, i).Value

        txtIdCategoria.Enabled = False
    End Sub

    Private Sub frmCategoria_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing

        If e.CloseReason = CloseReason.UserClosing Then
            Dim result As DialogResult = MessageBox.Show("Seguro que desea salir?", "ATENCION", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning)
            If result <> DialogResult.OK Then
                e.Cancel = True
            Else
                frmEvento.Show()
                Hide()
            End If
        End If

    End Sub
    Private sub cargarPermisosCategoria()
        Dim pm As New PermisosManagement
        Dim p As New Permisos

        Dim lista = pm.RetrieveAlls(Of Permisos)

        For Each obj In lista
            If (obj.Area = "CATEGORIA") Then
                cboPermisosCategoria.Items.Add(obj.Nombre)
            End If
        Next

        Dim listaPermisos As New List(Of String)

        For Each item As Object In cboPermisosCategoria.Items

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

            If(lst.Item(j)="BUSCAR")Then
                ToolStripBtnBuscar.Enabled=True

            Else
                If(ToolStripBtnBuscar.Enabled=True)Then

                Else
                   ToolStripBtnBuscar.Enabled=False

                End If
            End If

            If(lst.Item(j)="ACTUALIZAR")Then
                ToolStripBtnActualizar.Enabled=True

            Else
                If(ToolStripBtnActualizar.Enabled=True)Then

                Else
                    ToolStripBtnActualizar.Enabled=False

                End If
            End If

            If(lst.Item(j)="ELIMINAR")Then
                ToolStripBtnEliminar.Enabled=True

            Else
                If(ToolStripBtnEliminar.Enabled=True)Then

                Else
                    ToolStripBtnEliminar.Enabled=False

                End If
            End If
        Next
    End sub

    Private Sub ToolStripBtnGuardar_Click(sender As Object, e As EventArgs) Handles ToolStripBtnGuardar.Click
        
        Dim n As New Categoria
        Dim u As New Categoria       

        u.IdCategoria = txtIdCategoria.Text
        u = managerDeCategorias.RetrieveCategoria(u)

        Try
            If (u Is Nothing) Then
                n.IdCategoria = txtIdCategoria.Text
                n.NombreCategoria = txtNombreCategoria.Text

                If (txtIdCategoria.Text.Trim() = "" Or txtNombreCategoria.Text.Trim() = "") Then
                    MessageBox.Show("Por favor verifique que los campos 'ID' y 'Nombre' esten llenos.", "OOPS!", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Else
                    managerDeCategorias.CreateCategoria(n)
                    MessageBox.Show("Categoría registrada con exito.", "FELICIDADES!", MessageBoxButtons.OK)
                End If
            
                LimpiarCampos()

            Else
                MessageBox.Show($"La categoría con el Id {txtIdCategoria.Text} ya existe.", "OOPS!", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                txtIdCategoria.Text = ""
                txtIdCategoria.Focus()
            End If

        Catch ex As ChallengeMeException
            _em.ManageException(ex)
        End Try

        CargarLista()
    End Sub

    Private Sub ToolStripBtnBuscar_Click(sender As Object, e As EventArgs) Handles ToolStripBtnBuscar.Click
        
        Dim u As New Categoria

        u.IdCategoria = txtIdCategoria.Text
        u = managerDeCategorias.RetrieveCategoria(u)

        Try
            If (u Is Nothing) Then
                MessageBox.Show($"La categoría con el Id {txtIdCategoria.Text} no existe.", "OOPS!", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                txtIdCategoria.Text = ""
                txtIdCategoria.Focus()

            Else
                txtIdCategoria.Enabled = False
                txtNombreCategoria.Text = u.NombreCategoria

            End If

        Catch ex As ChallengeMeException

            _em.ManageException(ex)

        End Try
    End Sub

    Private Sub ToolStripBtnNuevo_Click(sender As Object, e As EventArgs) Handles ToolStripBtnNuevo.Click
        LimpiarCampos()
    End Sub

    Private Sub ToolStripBtnActualizar_Click(sender As Object, e As EventArgs) Handles ToolStripBtnActualizar.Click
        
        Dim u As New Categoria

        u.IdCategoria = txtIdCategoria.Text
        u = managerDeCategorias.RetrieveCategoria(u)

        Try
            If (u Is Nothing) Then
                MessageBox.Show($"La categoría con el Id {txtIdCategoria.Text} no existe.", "OOPS!", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                txtIdCategoria.Text = ""
                txtIdCategoria.Focus()

            Else
                txtIdCategoria.Enabled = False

                u.IdCategoria = txtIdCategoria.Text
                u.NombreCategoria = txtNombreCategoria.Text

                If (txtIdCategoria.Text.Trim() = "" Or txtNombreCategoria.Text.Trim() = "") Then
                    MessageBox.Show("Por favor verifique que los campos 'ID' y 'Nombre' esten llenos.", "OOPS!", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Else
                    managerDeCategorias.UpdateCategoria(u)
                    MessageBox.Show("Categoría actualizada con exito.", "FELICIDADES!", MessageBoxButtons.OK)
                End If

                LimpiarCampos()

            End If

        Catch ex As ChallengeMeException
            _em.ManageException(ex)

        End Try

        CargarLista()
    End Sub

    Private Sub ToolStripBtnEliminar_Click(sender As Object, e As EventArgs) Handles ToolStripBtnEliminar.Click
        
        Dim u As New Categoria

        u.IdCategoria = txtIdCategoria.Text
        u = managerDeCategorias.RetrieveCategoria(u)

        Try
            If (u Is Nothing) Then
                MessageBox.Show($"La categoría con el Id {txtIdCategoria.Text} no existe.", "OOPS!", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                txtIdCategoria.Text = ""
                txtIdCategoria.Focus()

            Else
                managerDeCategorias.DeleteCategoria(u)
                MessageBox.Show("Categoría eliminada con exito.", "FELICIDADES!", MessageBoxButtons.OK)

                LimpiarCampos()

            End If

        Catch ex As ChallengeMeException

            _em.ManageException(ex)

        End Try

        CargarLista()
    End Sub

    Private Sub ToolStripBtnSalir_Click(sender As Object, e As EventArgs) Handles ToolStripBtnSalir.Click
        
        frmEvento.Show()
        Close()
    End Sub
End Class