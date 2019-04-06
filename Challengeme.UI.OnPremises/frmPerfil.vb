Imports Challengeme.ApiCore
Imports Challengeme.Entities

Public Class frmPerfil
    Dim userManagement As New UserManagement
    Dim usrm As New UserManagement
    Public _em As New ExceptionManagement
    Private Sub frmPerfil_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txtNombre.CharacterCasing = CharacterCasing.Upper
        txtDireccion.CharacterCasing = CharacterCasing.Upper
        txtProvincia.CharacterCasing = CharacterCasing.Upper
        cargarInformacionUsuario()
    End Sub
    Private Sub cargarInformacionUsuario()
        Dim user As New User

        user.IdUsuario= USUARIO
        Try
             user=userManagement.Retrieve(user)
        Catch ex As ChallengeMeException
            _em.ManageException(ex)
        End Try
       

        txtNombre.Text=user.NombreUsuario
        txtDireccion.Text=user.DirUsuario
        txtProvincia.Text=user.Prov_Usuario
        txtCanton.Text=user.Cant_Usuario
        txtDistrito.Text=user.Dist_Usuario
        txtEmail.Text=user.Correo_Usuario
        txtFechaNacimiento.Text=user.FNac_Usuario


    End Sub

    Private Sub btnGuardar_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click
        Dim user As New User

        user.IdUsuario=USUARIO
        Try
              user=userManagement.Retrieve(user)
        Catch ex As ChallengeMeException
            _em.ManageException(ex)
        End Try
      
         erProveedorError.Clear()
        If(user Is Nothing )Then

        Else
            If (Trim(txtNombre.Text = "")) Then
                erProveedorError.SetError(txtNombre, "Debe indicar el Nombre del Usuario que desea Guardar")
                txtNombre.Focus()
                Return
            End If
            If (Trim(txtDireccion.Text = "")) Then
                erProveedorError.SetError(txtDireccion, "Debe indicar la Dirección del Usuario")
                txtDireccion.Focus()
                Return
            End If
            If (Trim(txtProvincia.Text="")) Then
                erProveedorError.SetError(txtProvincia, "Debe indicar la Provincia para completar la Dirección")
                Return
            End if
            If (Trim(txtCanton.Text="")) Then
                erProveedorError.SetError(txtCanton, "Debe indicar el Cantón para completar la Dirección")
                Return
                
            End If
            If (Trim(txtDistrito.Text="")) Then
                erProveedorError.SetError(txtDistrito, "Debe indicar el Distrito para completar la Dirección")
                Return
                
            End if
            If (txtEmail.Text = "") Then
                erProveedorError.SetError(txtEmail, "Debe indicar el Correo electrónico del Usuario")
                txtEmail.Focus()
                Return
            End if
             If (txtFechaNacimiento.Text = "") Then
                erProveedorError.SetError(txtEmail, "Debe indicar la fecha de nacimiento del Usuario")
                txtFechaNacimiento.Focus()
                Return
            End if

            user.NombreUsuario=txtNombre.Text
            user.DirUsuario=txtDireccion.Text
            user.Prov_Usuario=txtProvincia.Text
            user.Cant_Usuario=txtCanton.Text
            user.Dist_Usuario=txtDistrito.Text
            user.Correo_Usuario=txtEmail.Text
            user.FNac_Usuario=txtFechaNacimiento.Text
            Try
                usrm.Update(user)
            Catch ex As ChallengeMeException
                _em.ManageException(ex)
            End Try
            

            MessageBox.Show("Datos guardados satisfactoriamente..!!!","Atención",MessageBoxButtons.OKCancel,MessageBoxIcon.Information)
            buscarUsuario()
            txtNombre.Focus
        End If
    End Sub
    Private sub buscarUsuario()
        Dim user As New User

        user.IdUsuario=USUARIO
        Try
             user=userManagement.Retrieve(user)
        Catch ex As ChallengeMeException
            _em.ManageException(ex)
        End Try
       

        If(user Is Nothing )Then

        Else
            txtNombre.Text=user.NombreUsuario
            txtDireccion.Text=user.DirUsuario
            txtProvincia.Text=user.Prov_Usuario
            txtCanton.Text=user.Cant_Usuario
            txtDistrito.Text=user.Dist_Usuario
            txtEmail.Text=user.Correo_Usuario
            txtFechaNacimiento.Text=user.FNac_Usuario

        End if
    End sub

End Class