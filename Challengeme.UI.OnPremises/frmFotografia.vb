Imports Challengeme.ApiCore
Imports Challengeme.Entities

Public Class frmFotografia
    Dim um As New UserManagement
    Dim usrm As New UserManagement
    Public _em As New ExceptionManagement
    Private imageList As New ImageList With {.ImageSize = New Size(24, 24)}

    

    Private Sub btnCargarImagen_Click(sender As Object, e As EventArgs) Handles btnCargarImagen.Click
        Using OpenFileDialog1 As New OpenFileDialog()

            With OpenFileDialog1
                .CheckFileExists = True
                .ShowReadOnly = False
                .Filter = "All Files|*.*|Bitmap Files (*)|*.bmp;*.gif;*.jpg"
                .FilterIndex = 2

                If .ShowDialog = DialogResult.OK Then
                    ' Mostramos la imagen en el control PictureBox
                    picImgUsr.ImageLocation = .FileName
                    
                   
                End If
            End With

        End Using
        
    End Sub

    Private Sub SeleccionarFotoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SeleccionarFotoToolStripMenuItem.Click
        btnCargarImagen_Click(Me, e)

    End Sub

    Private Sub frmFotografia_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btnCerrar_Click(sender As Object, e As EventArgs)  
        
         updateFoto()
        Me.Close()
    End Sub
    Private Sub updateFoto()

        Dim user As New User


        user.IdUsuario = USUARIO

        Try
            user = um.Retrieve(user) 
        Catch ex As ChallengeMeException
            _em.ManageException(ex)
        End Try
       

        If (user Is Nothing) Then


        Else
            user.Imagen_Usuario = picImgUsr.Image
            Try
                 usrm.Update(user)
            Catch ex As ChallengeMeException
                _em.ManageException(ex)
            End Try
           


        End If






    End Sub
        

    Private Sub picImgUsr_LoadCompleted(sender As Object, e As System.ComponentModel.AsyncCompletedEventArgs) Handles picImgUsr.LoadCompleted
        'manda la foto a la foto de perfil del form de actualizar perfil
        frmActualizarPerfil.picImgUsr.Image = picImgUsr.Image
        'ingrese automaticamente al metodo de actualizar la foto del perfil del usuario 
        'una vez que se activa el evento load complete del picture box
        updateFoto()
    End Sub
End Class