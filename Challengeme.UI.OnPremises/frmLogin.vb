Imports System.Security.Cryptography
Imports System.Text
Imports Challengeme.ApiCore
Imports Challengeme.Entities
Public Module GlobalVariables

    Public USUARIO As String
    Public NOMBRE_ROL As String
    Public listaProductosAgregados As New List(Of String)
 

End Module
Public Class frmLogin


    Private Sub btnSalir_Click(sender As Object, e As EventArgs) Handles btnSalir.Click
        Environment.Exit(0)
    End Sub

    Private Sub btnInicio_Click(sender As Object, e As EventArgs) Handles btnInicio.Click
        USUARIO = txtUsuario.Text
        
        IniciarSesion()
    End Sub

   


    Private Sub txtUsuario_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtUsuario.KeyPress
        If e.KeyChar = ChrW(Keys.Enter) Then

5:          e.Handled = True
6:          SendKeys.Send("{TAB}")


7:      End If
    End Sub

    Private Sub txtPassword_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtPassword.KeyPress
        If e.KeyChar = ChrW(Keys.Enter) Then

5:          e.Handled = True
6:          SendKeys.Send("{TAB}")
            IniciarSesion()

7:      End If
    End Sub

    Private Sub frmLogin_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Text = Me.Text + " " + Application.ProductName + ". Version " + Application.ProductVersion

    End Sub
    Private Sub IniciarSesion()
        Dim clave As String
        Dim password As String
        Dim um As New UserManagement
        Dim u As New User
        Dim rol As Integer
        'Dim NombreRol As String

        Dim rm As New RolManagement
        Dim r As New Rol

        Dim ueCodigo As New UnicodeEncoding()
        ' Objeto para instanciar las codificación
        Dim Md5 As New MD5CryptoServiceProvider()

        ' Calcula el valor hash de la cadena recibida
        Dim bHash() As Byte = Md5.ComputeHash(ueCodigo.GetBytes(txtPassword.Text))
        password = Convert.ToBase64String(bHash)

       
        u.Pass_Usuario = password
        u.IdUsuario = txtUsuario.Text 'igualo el usuario a la instancia de la clase useraccount
        'para hacer el retrive all by id de la tabla useraccount y extraer el codigo del rol
        'especifico de ese usuario

        u = um.Retrieve(u) 'hago la busqueda del usuario en la tabla de cuentas donde está guardado el password
       

        If (u Is Nothing) Then 'si la busqueda en la tabla de cuentas viene vacía significa que el usuario ingresado no existe
            MessageBox.Show("El usuario " + txtUsuario.Text + " aún no ha sido registrado", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Error)
            txtUsuario.Text = ""
            txtUsuario.Focus()
        Else
            clave = u.Pass_Usuario ' si existe el usuario extraigo la clave asociada a ese usuadio desde la tabla
            '  y  la dejo en una variable

            If (clave = password) Then ' si la clave extraída desde la tabla coincide 
                'con la clave que se está ingresando en el formulario
                'entonces el usario está habilitado para ingresar al sistem
                'lo que sigue es extraer el codigo del rol de ese usuario desde la tabla de usuarios
                'para luego ir a la tabla de roles y en base al codigo del rol de ese usuario
                'guardado en la tabla de usuarios, se hace una búsqueda en la tabla de roles
                'para verificar a través de los codigos de roles coincidentes, cual es el 
                'nombre del rol al que ese usuario pertence
                'se pasa el nombre del rol a una variable y se concatena esa variable
                'en un mesaje para darle la bienvenida al usuario con el tipo de rol que tiene

                rol = u.IdRole ' igualo a la variable rol , lo que encuentra el procedimiento
                'de acuerdo al usuario ingresado
                r.IdRol = rol
                r = rm.Retrieve(r)
                NOMBRE_ROL = r.Nombre_Role
                MessageBox.Show("Bienvenido usuario tipo " + NOMBRE_ROL)
                frmDashBoard.txtRol.Text=r.IdRol
                'frmDashBoard.lblNombreRol.Text=NOMBRE_ROL
                'frmDashBoard.USUARIO.Text=u.IdUsuario
                frmDashBoard.show()
                Me.Hide()

                

               
               


            Else
                MessageBox.Show("La contraseña introducida es incorrecta, favor verificar", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Error)
                txtPassword.Text = ""
                txtPassword.Focus()
            End If


        End If

    End sub

    Private Sub ToolTip1_Popup(sender As Object, e As PopupEventArgs) Handles ToolTip1.Popup

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) 
        frmMenuSA.show()
    End Sub
End Class