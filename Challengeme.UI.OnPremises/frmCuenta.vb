Imports System.Security.Cryptography
Imports System.Text
Imports Challengeme.ApiCore
Imports Challengeme.Entities

Public Class frmCuenta
    Dim userManagement As New UserManagement
    Dim usrManagement As New UserManagement
    Dim passwords As  string 
    Public _em As New ExceptionManagement




    Private Sub btnCambiarContrasenia_Click(sender As Object, e As EventArgs) Handles btnCambiarContrasenia.Click
        Dim clave As String
        Dim password As String
        
        Dim P1 As String
        Dim P2 As String

        Dim user As New User
       
        'Dim NombreRol As String

       
       

         erProveedorError.Clear()

        Dim ueCodigo As New UnicodeEncoding()
        ' Objeto para instanciar las codificación
        Dim Md5 As New MD5CryptoServiceProvider()

        ' Calcula el valor hash de la cadena recibida
        Dim bHash() As Byte = Md5.ComputeHash(ueCodigo.GetBytes(txtContraseniaVieja.Text))
        password = Convert.ToBase64String(bHash)


        user.Pass_Usuario = password
        user.IdUsuario = USUARIO 'igualo el usuario a la instancia de la clase useraccount
        'para hacer el retrive all by id de la tabla useraccount y extraer el codigo del rol
        'especifico de ese usuario
        Try
              user = userManagement.Retrieve(user) 'hago la busqueda del usuario en la tabla de cuentas donde está guardado el password
        Catch ex As ChallengeMeException
            _em.ManageException(ex)
        End Try
      


        If (user Is Nothing) Then 'si la busqueda en la tabla de cuentas viene vacía significa que el usuario ingresado no existe
            
        Else
            clave = user.Pass_Usuario ' si existe el usuario extraigo la clave asociada a ese usuadio desde la tabla
            '  y  la dejo en una variable

            If (clave = password) Then 
                 '*********************************************
            'se pasan los valores de las cajas de texto
            'de las contraseñas a dos respectivas variables
            'con el fin de compararlas
            P1 = txtNuevaContrasenia.Text
            P2 = txtConfirmarContrasenia.Text
            If (P1 <> P2) Then
                erProveedorError.SetError(txtNuevaContrasenia, "Las contraseñas no coinciden, favor ingresarlas de nuevo")
                
                txtNuevaContrasenia.Text = ""
                txtConfirmarContrasenia.Text = ""
                txtNuevaContrasenia.Focus()
                Return
            
            End if
            '************************************************

            '++++++++++++++++++++++++++++++++++++++++++++

            'Inicia el código de encriptación de la contraseña
            Dim ueCodigos As New UnicodeEncoding()
            'Objeto para instanciar las codificación
            Dim Md5s As New MD5CryptoServiceProvider()
            'Calcula el valor hash de la cadena recibida->txtPassw
            Dim bHashs() As Byte = Md5.ComputeHash(ueCodigo.GetBytes(txtNuevaContrasenia.Text))
            'se toma en codigo ya encriptado del password recibido en la caja de texto
            'y se iguala a una variable llamada password que es la que va a ir a 
            'guardarse a la BD
             passwords = Convert.ToBase64String(bHashs)
           
            
            '+++++++++++++++++++++++++++++++++++++++++++++

            '********************************************
            
                ' MessageBox.Show($"El usuario con el Id [{txtId.Text}] ya existe en la Base de Datos", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Error)
                actualizarContraseniaUsuario()
                
           

               

            Else
                erProveedorError.SetError(txtContraseniaVieja, "La contraseña actual introducida es incorrecta, favor verificar")
                txtContraseniaVieja.Text = ""
                txtContraseniaVieja.Focus()
                Return
            End If


        End If
    End Sub
    Private sub actualizarContraseniaUsuario()
        
        Dim User As New User

        User.IdUsuario = USUARIO
        
        Try
             user=userManagement.Retrieve(user)
        Catch ex As ChallengeMeException
            _em.ManageException(ex)
        End Try
       

        If(user Is Nothing)Then


        Else
            User.Pass_Usuario=passwords
            Try
                usrManagement.Update(user)
            Catch ex As ChallengeMeException
                _em.ManageException(ex)
            End Try
            
            MessageBox.Show("Contraseña cambiada satisfactoriamente..!!","Atención",MessageBoxButtons.OK,MessageBoxIcon.Information)
            txtContraseniaVieja.Text=""
            txtNuevaContrasenia.Text=""
            txtConfirmarContrasenia.Text=""

        End If
    End sub

    Private Sub frmCuenta_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txtUsuario.Text=USUARIO
    End Sub
End Class