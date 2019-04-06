Imports Challengeme.ApiCore
Imports Challengeme.Entities

Public Class frmActualizarPerfil
    Dim userManagement As New UserManagement
    Dim rolManagement As New RolManagement
    Dim rpm As New RolPermisoManagement
    Public _em As New ExceptionManagement
    Private imageList As New ImageList With {.ImageSize = New Size(24, 24)}
    Private Sub frmActualizarPerfil_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        buscarFoto()
        cargarRol()

        If(frmDashBoard.txtConfiguracion.Text="")Then
            btnPerfil_Click(Me,e)

        Else
            If(frmDashBoard.txtConfiguracion.Text=1)Then
            btnPerfil_click(Me,e)

        Else
            If(frmDashBoard.txtConfiguracion.Text=2)Then
                btnCuenta_Click(Me,e)

            Else
                If(frmDashBoard.txtConfiguracion.Text=3)Then
                    btnCambiarImagen_Click(Me,e)
                        
                End If
            End If

        End If

        End If
        
        
    End Sub
    Private Sub cargarRol()
        Dim user As New User
        Dim rol As New Rol
        Dim rp As New RolPermiso
        Dim listaPermisos As New List(Of Permisos)()

        user.IdUsuario = USUARIO
        txtNombreRol.Text = NOMBRE_ROL
        txtUSUARIO.Text = USUARIO
        'buscamos el usuario por el id usuarios para traernos todos los datos de ese usuario
        'que estan guardados en la tabla de usuarios
        user = userManagement.Retrieve(user)

        If (user Is Nothing) Then


        Else
            'igualamos el id rol de la tabla rol, al campo id rol de la tabla usuario
            'para luego ir a la tabla rol y ver si ese idrol existe y si existe, traer el nombre
            'del rol que ese usuario tiene asignado
            rol.IdRol = user.IdRole
            lblNombreUsuario.Text=user.NombreUsuario
            rol = rolManagement.Retrieve(rol)

        End if

    End Sub
    Private sub buscarFoto()
        Try

            Dim user As New User

            user.IdUsuario = USUARIO 'VARIABLE GLOBAL ENTRE TODOS LOS FORMS QUE CONTIENE EL USUARIO!

            user = userManagement.Retrieve(user) 'igualo a la lista lo que encontró el procedimiento de listar
            picImgUsr.Image = user.Imagen_Usuario

        Catch ex As ChallengeMeException
            _em.ManageException(ex)
        End Try
    End sub

    'Private Sub btnCambiarImagen_Click(sender As Object, e As EventArgs) 
    '    Using OpenFileDialog1 As New OpenFileDialog()

    '        With OpenFileDialog1
    '            .CheckFileExists = True
    '            .ShowReadOnly = False
    '            .Filter = "All Files|*.*|Bitmap Files (*)|*.bmp;*.gif;*.jpg"
    '            .FilterIndex = 2

    '            If .ShowDialog = DialogResult.OK Then
    '                ' Mostramos la imagen en el control PictureBox
    '                picImgUsr.ImageLocation = .FileName
    '            End If
    '        End With

    '    End Using
    'End Sub

    Private Sub btnPerfil_Click(sender As Object, e As EventArgs) Handles btnPerfil.Click
         Dim perfil As New frmPerfil
        perfil.MdiParent=Me
        Me.Panel2.Controls.Add(perfil)
        perfil.Show()
    End Sub

    Private Sub btnCuenta_Click(sender As Object, e As EventArgs) Handles btnCuenta.Click
         Dim cuenta As New frmCuenta
        cuenta.MdiParent=Me
        Me.Panel2.Controls.Add(cuenta)
        cuenta.Show()
    End Sub

    Private Sub btnCambiarImagen_Click(sender As Object, e As EventArgs) Handles btnCambiarImagen.Click
         Dim foto   As New frmFotografia
        foto.MdiParent=Me
        Me.Panel2.Controls.Add(foto)
        foto.Show()
    End Sub

    Private Sub btnSalir_Click(sender As Object, e As EventArgs) Handles btnSalir.Click
        frmDashBoard.show()
        Me.Close()
    End Sub

    Private Sub btnCerrar_Click(sender As Object, e As EventArgs) 
          frmDashBoard.show()
        Me.Close()
    End Sub

    Private Sub btnCerrar_Click_1(sender As Object, e As EventArgs) Handles btnCerrar.Click
          frmDashBoard.show()
        Me.Close()
    End Sub
End Class