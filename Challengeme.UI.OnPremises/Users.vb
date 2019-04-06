Imports System.Security.Cryptography
Imports System.Text
Imports Challengeme.ApiCore
Imports Challengeme.Entities

Public Class Users
    Public _em As New ExceptionManagement
    Private imageList As New ImageList With {.ImageSize = New Size(24, 24)}
    Private Sub BtnGuardar_Click(sender As Object, e As EventArgs) 


    End Sub

    Private Sub Users_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txtFecha.Text = DateTime.Now.ToString("dd/MM/yyyy")
        txtNombre.CharacterCasing = CharacterCasing.Upper
        txtDireccion.CharacterCasing = CharacterCasing.Upper
        cargarRol()
        listarUsuarios()
        cargarEmpresas()



    End Sub

    Private Sub TxtId_KeyPress(sender As Object, e As KeyPressEventArgs)
        If Not Char.IsDigit(e.KeyChar) And e.KeyChar <> vbBack And e.KeyChar <> ChrW(Keys.Enter) Then

            e.Handled = True

            MessageBox.Show("Introduzca sólo valores númericos", "Atención..!", MessageBoxButtons.OK, MessageBoxIcon.Error)

        End If
        If e.KeyChar = ChrW(Keys.Enter) Then
            5:          e.Handled = True
            6:          SendKeys.Send("{TAB}")
            7:      End If
    End Sub

    Private Sub TxtNombre_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtNombre.KeyPress
        If e.KeyChar = ChrW(Keys.Enter) Then
            5:          e.Handled = True
            6:          SendKeys.Send("{TAB}")
            7:      End If
    End Sub
    Private Sub MaskedTextBox1_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtId.KeyPress
        If e.KeyChar = ChrW(Keys.Enter) Then
            5:          e.Handled = True
            6:          SendKeys.Send("{TAB}")
            Buscar()

            7:      End If
    End Sub

    Private Sub Buscar()
        Dim m As New UserManagement
        Dim u As New User

        If txtId.MaskFull Then
            u.IdUsuario = txtId.Text

            Try
                u = m.Retrieve(u) 'la instancia del objeto la igualo a lo que encuentre el procedimiento de búsqueda
                'luego la instancia almacena lo que se encontró
            Catch ex As ChallengeMeException
                _em.ManageException(ex)
            End Try

            If (u Is Nothing) Then 'si el id ingresado no existe lo deja pasar para que se incluya

            Else
                txtNombre.Text = u.NombreUsuario 'pego en las respectivas cajas de texto la instancia con el atributo que le corresponde
                txtDireccion.Text = u.DirUsuario

                cboProvincia.Items.Clear()
                cboProvincia.Items.Add(u.Prov_Usuario)
                cboProvincia.SelectedIndex=0
                cboCanton.Items.Clear()
                cboCanton.Items.Add(u.Cant_Usuario)
                cboCanton.SelectedIndex=0
                cboDistrito.Items.Clear()
                cboDistrito.Items.Add(u.Dist_Usuario)
                cboCanton.SelectedIndex=0
                txtEmail.Text = u.Correo_Usuario
                mskFechaNacimiento.Text = u.FNac_Usuario
                picImgUsr.Image = u.Imagen_Usuario
                txtIdRolDos.Text=u.IdRole
                txtIdEmpresaDos.Text=u.IdEntidad
                
              
            End If

        Else
            MessageBox.Show("Debe digitar el Id del Usuario que desea Buscar", "Atención..!", MessageBoxButtons.OK, MessageBoxIcon.Error)
            txtId.Focus()


        End If
    End Sub

    Private Sub btnBuscar_Click(sender As Object, e As EventArgs) Handles MyBase.DoubleClick

    End Sub

    Private Sub btnListar_Click(sender As Object, e As EventArgs) Handles btnListar.Click
        listarUsuarios()
    End Sub
    Private Sub btnActualizar_Click(sender As Object, e As EventArgs) 



    End Sub
    Private Sub btnEliminar_Click_1(sender As Object, e As EventArgs) 



    End Sub
    Private Sub listarUsuarios()
        Try
            Dim m As New UserManagement
            Dim listaUsuarios = m.RetrieveAlls(Of User)() 'igualo a la lista lo que encontró el procedimiento de listar
            Dim resizedImage As Image

            dgvListarUsuarios.Rows.Clear()
            For Each user As User In listaUsuarios
                If (user.Imagen_Usuario IsNot Nothing) Then
                    resizedImage = (user.Imagen_Usuario).GetThumbnailImage(48, 48, Nothing, IntPtr.Zero)

                Else
                    resizedImage = Nothing

                End If

                Dim rowUsers =
                        {
                            user.IdUsuario,
                            user.NombreUsuario,
                            user.DirUsuario,
                            user.Prov_Usuario,
                            user.Cant_Usuario,
                            user.Dist_Usuario,
                            user.Correo_Usuario,
                            user.FNac_Usuario,
                            resizedImage,
                            user.IdRole,
                            user.IdEntidad
                        }

                dgvListarUsuarios.Rows.Add(rowUsers)
        

            Next

        Catch ex As ChallengeMeException
            _em.ManageException(ex)
        End Try


    End Sub

    Private Sub ListaUsuarios_MouseDoubleClick_1(sender As Object, e As MouseEventArgs)

    End Sub

    Private Sub ListaUsuarios_SelectedIndexChanged_1(sender As Object, e As EventArgs)

    End Sub

    Private Sub btnLimpiar_Click(sender As Object, e As EventArgs) 

    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub cboProvincia_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboProvincia.SelectedIndexChanged



    End Sub

    Private Sub cboCanton_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboCanton.SelectedIndexChanged


    End Sub

    Private Sub cboProvincia_MouseClick(sender As Object, e As MouseEventArgs) Handles cboProvincia.MouseClick
        cboProvincia.Items.Clear()
        cboProvincia.Items.Add("SAN JOSÉ")
        cboProvincia.Items.Add("ALAJUELA")
        cboProvincia.Items.Add("CARTAGO")
        cboProvincia.Items.Add("HEREDIA")
        cboProvincia.Items.Add("GUANACASTE")
        cboProvincia.Items.Add("PUNTARENAS")
        cboProvincia.Items.Add("LIMÓN")
    End Sub

    Private Sub cboCanton_MouseClick(sender As Object, e As MouseEventArgs) Handles cboCanton.MouseClick
        cboCanton.Items.Clear()
        If cboProvincia.SelectedItem = "SAN JOSÉ" Then
            cboCanton.Items.Add("San José")
            cboCanton.Items.Add("Escazú")
            cboCanton.Items.Add("Desamparados")
            cboCanton.Items.Add("Puriscal")
            cboCanton.Items.Add("Tarrazú")
            cboCanton.Items.Add("Aserrí")
            cboCanton.Items.Add("Mora")
            cboCanton.Items.Add("Goicoechea")
            cboCanton.Items.Add("Santa Ana")
            cboCanton.Items.Add("Alajuelita")
            cboCanton.Items.Add("Vásquez de Coronado")
            cboCanton.Items.Add("Acosta")
            cboCanton.Items.Add("Tibás")
            cboCanton.Items.Add("Moravia")
            cboCanton.Items.Add("Montes de Oca")
            cboCanton.Items.Add("Turrubares")
            cboCanton.Items.Add("Dota")
            cboCanton.Items.Add("Curridabat")
            cboCanton.Items.Add("Pérez Zeledón")
            cboCanton.Items.Add("León Córtes Castro")

        Else

            cboCanton.Items.Clear()
            If (cboProvincia.SelectedItem = "ALAJUELA") Then
                cboCanton.Items.Add("Alajuela")
                cboCanton.Items.Add("San Ramón")
                cboCanton.Items.Add("Grecia")
                cboCanton.Items.Add("San Mateo")
                cboCanton.Items.Add("Atenas")
                cboCanton.Items.Add("Naranjo")
                cboCanton.Items.Add("Palmares")
                cboCanton.Items.Add("Poás")
                cboCanton.Items.Add("Orotina")
                cboCanton.Items.Add("San Carlos")
                cboCanton.Items.Add("Zarcero")
                cboCanton.Items.Add("Valverde Vega")
                cboCanton.Items.Add("Upala")
                cboCanton.Items.Add("Los Chiles")
                cboCanton.Items.Add("Guatuso")

            Else
                cboCanton.Items.Clear()
                If (cboProvincia.SelectedItem = "CARTAGO") Then
                    cboCanton.Items.Add("Cartago")
                    cboCanton.Items.Add("La Unión")
                    cboCanton.Items.Add("Paraíso")
                    cboCanton.Items.Add("Jiménez")
                    cboCanton.Items.Add("Turrialba")
                    cboCanton.Items.Add("Alvarado")
                    cboCanton.Items.Add("Oreamuno")
                    cboCanton.Items.Add("El Guarco")
                Else
                    cboCanton.Items.Clear()
                    If (cboProvincia.SelectedItem = "HEREDIA") Then
                        cboCanton.Items.Add("Heredia")
                        cboCanton.Items.Add("Barva")
                        cboCanton.Items.Add("Santo Domingo")
                        cboCanton.Items.Add("Santa Bárbara")
                        cboCanton.Items.Add("San Rafael")
                        cboCanton.Items.Add("San Isidro")
                        cboCanton.Items.Add("Belén")
                        cboCanton.Items.Add("Flores")
                        cboCanton.Items.Add("San Pablo")
                        cboCanton.Items.Add("Sarapiquí")
                    Else
                        cboCanton.Items.Clear()
                        If (cboProvincia.SelectedItem = "GUANACASTE") Then
                            cboCanton.Items.Add("Liberia")
                            cboCanton.Items.Add("Nicoya")
                            cboCanton.Items.Add("Santa Cruz")
                            cboCanton.Items.Add("Bagaces")
                            cboCanton.Items.Add("Carrillo")
                            cboCanton.Items.Add("Cañas")
                            cboCanton.Items.Add("Abangares")
                            cboCanton.Items.Add("Tilarán")
                            cboCanton.Items.Add("Nandayure")
                            cboCanton.Items.Add("La Cruz")
                            cboCanton.Items.Add("Hojancha")

                        Else
                            cboCanton.Items.Clear()
                            If (cboProvincia.SelectedItem = "PUNTARENAS") Then
                                cboCanton.Items.Add("Puntarenas")
                                cboCanton.Items.Add("Esparza")
                                cboCanton.Items.Add("Buenos Aires")
                                cboCanton.Items.Add("Montes de Oro")
                                cboCanton.Items.Add("Osa")
                                cboCanton.Items.Add("Aguirre")
                                cboCanton.Items.Add("Golfito")
                                cboCanton.Items.Add("Coto Brus")
                                cboCanton.Items.Add("Parrita")
                                cboCanton.Items.Add("Corredores")
                                cboCanton.Items.Add("Garabito")

                            Else
                                cboCanton.Items.Clear()
                                If (cboProvincia.SelectedItem = "LIMÓN") Then
                                    cboCanton.Items.Add("Limón")
                                    cboCanton.Items.Add("Pococí")
                                    cboCanton.Items.Add("Siquirres")
                                    cboCanton.Items.Add("Talamanca")
                                    cboCanton.Items.Add("Matina")
                                    cboCanton.Items.Add("Guacimo")

                                End If
                            End If
                        End If
                    End If
                End If
            End If
        End If
    End Sub

    Private Sub cboDistrito_MouseClick(sender As Object, e As MouseEventArgs) Handles cboDistrito.MouseClick
        cboDistrito.Items.Clear()
        If (cboCanton.SelectedItem = "San José") Then
            cboDistrito.Items.Add("Carmen")
            cboDistrito.Items.Add("Merced")
            cboDistrito.Items.Add("Hospital")
            cboDistrito.Items.Add("Catedral")
            cboDistrito.Items.Add("Zapote")
            cboDistrito.Items.Add("San Francisco de Dos Ríos")
            cboDistrito.Items.Add("Uruca")
            cboDistrito.Items.Add("Mata Redonda")
            cboDistrito.Items.Add("Pavas")
            cboDistrito.Items.Add("Hatillo")
            cboDistrito.Items.Add("San Sebastián")

        Else
            If (cboCanton.SelectedItem = "Escazú") Then
                cboDistrito.Items.Add("Escazú")
                cboDistrito.Items.Add("San Antonio")
                cboDistrito.Items.Add("San Rafael")

            Else
                If (cboCanton.SelectedItem = "Desamparados") Then
                    cboDistrito.Items.Add("Desamparados")
                    cboDistrito.Items.Add("San Miguel")
                    cboDistrito.Items.Add("San Juan de Dios")
                    cboDistrito.Items.Add("San Rafael Arriba")
                    cboDistrito.Items.Add("San Antonio")
                    cboDistrito.Items.Add("Frailes")
                    cboDistrito.Items.Add("Patarrá")
                    cboDistrito.Items.Add("San Cristóbal")
                    cboDistrito.Items.Add("Rosario")
                    cboDistrito.Items.Add("Damas")
                    cboDistrito.Items.Add("San Rafael Abajo")
                    cboDistrito.Items.Add("Gravilias")
                    cboDistrito.Items.Add("Los Guido")

                Else
                    If (cboCanton.SelectedItem = "Puriscal") Then
                        cboDistrito.Items.Add("Santiago")
                        cboDistrito.Items.Add("Mercedes Sur")
                        cboDistrito.Items.Add("Barbacoas")
                        cboDistrito.Items.Add("Grifo Alto")
                        cboDistrito.Items.Add("San Rafael")
                        cboDistrito.Items.Add("Candelarita")
                        cboDistrito.Items.Add("Desamparaditos")
                        cboDistrito.Items.Add("San Antonio")
                        cboDistrito.Items.Add("Chires")

                    Else
                        If (cboCanton.SelectedItem = "Tarrazú") Then
                            cboDistrito.Items.Add("San Marcos")
                            cboDistrito.Items.Add("San Lorenzo")
                            cboDistrito.Items.Add("San Carlos")


                        Else
                            If (cboCanton.SelectedItem = "Aserrí") Then
                                cboDistrito.Items.Add("Aserrí")
                                cboDistrito.Items.Add("Tarbaca")
                                cboDistrito.Items.Add("Vuelta de Jorco")
                                cboDistrito.Items.Add("San Gabriel")
                                cboDistrito.Items.Add("Legua")
                                cboDistrito.Items.Add("Monterrey")
                                cboDistrito.Items.Add("Salitrillos")

                            Else
                                If (cboCanton.SelectedItem = "Mora") Then
                                    cboDistrito.Items.Add("Ciudad Colón")
                                    cboDistrito.Items.Add("Guayabo")
                                    cboDistrito.Items.Add("Tabarcia")
                                    cboDistrito.Items.Add("Piedras Negras")
                                    cboDistrito.Items.Add("Picagres")
                                    cboDistrito.Items.Add("Jaris")
                                    cboDistrito.Items.Add("Quitirrisí")

                                Else
                                    If (cboCanton.SelectedItem = "Goicoechea") Then
                                        cboDistrito.Items.Add("Guadalupe")
                                        cboDistrito.Items.Add("San Francisco")
                                        cboDistrito.Items.Add("Calle Blancos")
                                        cboDistrito.Items.Add("Mata de Plátano")
                                        cboDistrito.Items.Add("Ipís")
                                        cboDistrito.Items.Add("Rancho Redondo")
                                        cboDistrito.Items.Add("Purral")
                                    Else
                                        If (cboCanton.SelectedItem = "Santa Ana") Then
                                            cboDistrito.Items.Add("Santa Ana")
                                            cboDistrito.Items.Add("Salitral")
                                            cboDistrito.Items.Add("Pozos")
                                            cboDistrito.Items.Add("Uruca")
                                            cboDistrito.Items.Add("Piedades")
                                            cboDistrito.Items.Add("Brasil")
                                        Else
                                            If (cboCanton.SelectedItem = "Alajuelita") Then
                                                cboDistrito.Items.Add("Alajuelita")
                                                cboDistrito.Items.Add("San Josecito")
                                                cboDistrito.Items.Add("San Antonio")
                                                cboDistrito.Items.Add("Concepción")
                                                cboDistrito.Items.Add("San Felipe")
                                            Else
                                                If (cboCanton.SelectedItem = "Vásquez de Coronado") Then
                                                    cboDistrito.Items.Add("San Isidro")
                                                    cboDistrito.Items.Add("San Rafael")
                                                    cboDistrito.Items.Add("Dulce Nombre de Jesús")
                                                    cboDistrito.Items.Add("Patalillo")
                                                    cboDistrito.Items.Add("Cascajal")
                                                Else
                                                    If (cboCanton.SelectedItem = "Acosta") Then
                                                        cboDistrito.Items.Add("San Ignacio")
                                                        cboDistrito.Items.Add("Guaitil")
                                                        cboDistrito.Items.Add("Palmichal")
                                                        cboDistrito.Items.Add("Cangrejal")
                                                        cboDistrito.Items.Add("Sabanillas")

                                                    Else
                                                        If (cboCanton.SelectedItem = "Tibás") Then
                                                            cboDistrito.Items.Add("San Juan")
                                                            cboDistrito.Items.Add("Cinco Esquinas")
                                                            cboDistrito.Items.Add("Anselmo Llorente")
                                                            cboDistrito.Items.Add("León XIII")
                                                            cboDistrito.Items.Add("Colima")
                                                        Else
                                                            If (cboCanton.SelectedItem = "Moravia") Then
                                                                cboDistrito.Items.Add("San Vicente")
                                                                cboDistrito.Items.Add("San Jerónimo")
                                                                cboDistrito.Items.Add("Trinidad")
                                                            Else
                                                                If (cboCanton.SelectedItem = "Montes de Oca") Then
                                                                    cboDistrito.Items.Add("San Pedro")
                                                                    cboDistrito.Items.Add("Sabanilla")
                                                                    cboDistrito.Items.Add("Mercedes")
                                                                    cboDistrito.Items.Add("San Rafael")
                                                                Else
                                                                    If (cboCanton.SelectedItem = "Turrubares") Then
                                                                        cboDistrito.Items.Add("San Pablo")
                                                                        cboDistrito.Items.Add("San Pedro")
                                                                        cboDistrito.Items.Add("San Juan de Mata")
                                                                        cboDistrito.Items.Add("San Luis")
                                                                        cboDistrito.Items.Add("Carara")

                                                                    Else
                                                                        If (cboCanton.SelectedItem = "Dota") Then
                                                                            cboDistrito.Items.Add("Santa María")
                                                                            cboDistrito.Items.Add("Jardín")
                                                                            cboDistrito.Items.Add("Copey")
                                                                        Else
                                                                            If (cboCanton.SelectedItem = "Curridabat") Then
                                                                                cboDistrito.Items.Add("Curridabat")
                                                                                cboDistrito.Items.Add("Granadilla")
                                                                                cboDistrito.Items.Add("Sánchez")
                                                                                cboDistrito.Items.Add("Tirrases")
                                                                            Else
                                                                                If (cboCanton.SelectedItem = "Pérez Zeledón") Then
                                                                                    cboDistrito.Items.Add("San Isidro de El General")
                                                                                    cboDistrito.Items.Add("El General")
                                                                                    cboDistrito.Items.Add("Daniel Flores")
                                                                                    cboDistrito.Items.Add("Rivas")
                                                                                    cboDistrito.Items.Add("San Pedro")
                                                                                    cboDistrito.Items.Add("Platanares")
                                                                                    cboDistrito.Items.Add("Pejibaye")
                                                                                    cboDistrito.Items.Add("Cajón")
                                                                                    cboDistrito.Items.Add("Barú")
                                                                                    cboDistrito.Items.Add("Río Nuevo")
                                                                                    cboDistrito.Items.Add("Páramo")
                                                                                    cboDistrito.Items.Add("La Amistad")
                                                                                Else
                                                                                    If (cboCanton.SelectedItem = "León Cortés Castro") Then
                                                                                        cboDistrito.Items.Add("San Pablo")
                                                                                        cboDistrito.Items.Add("San Andrés")
                                                                                        cboDistrito.Items.Add("Llano Bonito")
                                                                                        cboDistrito.Items.Add("San Isidro")
                                                                                        cboDistrito.Items.Add("Santa Cruz")
                                                                                        cboDistrito.Items.Add("San Antonio")
                                                                                    Else
                                                                                        If (cboCanton.SelectedItem = "Alajuela") Then
                                                                                            cboDistrito.Items.Add("Alajuela")
                                                                                            cboDistrito.Items.Add("San José")
                                                                                            cboDistrito.Items.Add("Carrizal")
                                                                                            cboDistrito.Items.Add("San Antonio")
                                                                                            cboDistrito.Items.Add("Guácima")
                                                                                            cboDistrito.Items.Add("San Isidro")
                                                                                            cboDistrito.Items.Add("Sabanilla")
                                                                                            cboDistrito.Items.Add("San Rafael")
                                                                                            cboDistrito.Items.Add("Río Segundo")
                                                                                            cboDistrito.Items.Add("Desamparados")
                                                                                            cboDistrito.Items.Add("Turrúcares")
                                                                                            cboDistrito.Items.Add("Tambor")
                                                                                            cboDistrito.Items.Add("Garita")
                                                                                            cboDistrito.Items.Add("Sarapiquí")
                                                                                        Else
                                                                                            If (cboCanton.SelectedItem = "San Ramón") Then
                                                                                                cboDistrito.Items.Add("San Ramón")
                                                                                                cboDistrito.Items.Add("Santiago")
                                                                                                cboDistrito.Items.Add("San Juan")
                                                                                                cboDistrito.Items.Add("Piedades Norte")
                                                                                                cboDistrito.Items.Add("Piedades Sur")
                                                                                                cboDistrito.Items.Add("San Rafael")
                                                                                                cboDistrito.Items.Add("San Isidro")
                                                                                                cboDistrito.Items.Add("Ángeles")
                                                                                                cboDistrito.Items.Add("Alfaro")
                                                                                                cboDistrito.Items.Add("Volio")
                                                                                                cboDistrito.Items.Add("Concepción")
                                                                                                cboDistrito.Items.Add("Zapotal")
                                                                                                cboDistrito.Items.Add("Peñas Blancas")
                                                                                                cboDistrito.Items.Add("San Lorenzo4?")
                                                                                            Else
                                                                                                If (cboCanton.SelectedItem = "Grecia") Then
                                                                                                    cboDistrito.Items.Add("Grecia")
                                                                                                    cboDistrito.Items.Add("San Isidro")
                                                                                                    cboDistrito.Items.Add("San José")
                                                                                                    cboDistrito.Items.Add("Tacares")
                                                                                                    cboDistrito.Items.Add("Puente de Piedra")
                                                                                                    cboDistrito.Items.Add("Bolívar")

                                                                                                Else
                                                                                                    If (cboCanton.SelectedItem = "San Mateo") Then
                                                                                                        cboDistrito.Items.Add("Desmonte")
                                                                                                        cboDistrito.Items.Add("San Mateo")
                                                                                                        cboDistrito.Items.Add("Jesús María")
                                                                                                        cboDistrito.Items.Add("Labrador")
                                                                                                    Else
                                                                                                        If (cboCanton.SelectedItem = "Atenas") Then
                                                                                                            cboDistrito.Items.Add("Atenas")
                                                                                                            cboDistrito.Items.Add("Jesús")
                                                                                                            cboDistrito.Items.Add("Mercedes")
                                                                                                            cboDistrito.Items.Add("San Isidro")
                                                                                                            cboDistrito.Items.Add("Concepción")
                                                                                                            cboDistrito.Items.Add("San José")
                                                                                                            cboDistrito.Items.Add("Santa Eulalia")
                                                                                                            cboDistrito.Items.Add("Escobal")
                                                                                                        Else
                                                                                                            If (cboCanton.SelectedItem = "Naranjo") Then
                                                                                                                cboDistrito.Items.Add("Naranjo")
                                                                                                                cboDistrito.Items.Add("San Miguel")
                                                                                                                cboDistrito.Items.Add("San José")
                                                                                                                cboDistrito.Items.Add("Cirrí Sur")
                                                                                                                cboDistrito.Items.Add("San Jerónimo")
                                                                                                                cboDistrito.Items.Add("San Juan")
                                                                                                                cboDistrito.Items.Add("El Rosario")
                                                                                                                cboDistrito.Items.Add("Palmitos")

                                                                                                            Else
                                                                                                                If (cboCanton.SelectedItem = "Palmares") Then
                                                                                                                    cboDistrito.Items.Add("Palmares")
                                                                                                                    cboDistrito.Items.Add("Zaragoza")
                                                                                                                    cboDistrito.Items.Add("Buenos Aires")
                                                                                                                    cboDistrito.Items.Add("Santiago")
                                                                                                                    cboDistrito.Items.Add("Candelaria")
                                                                                                                    cboDistrito.Items.Add("Esquipulas")
                                                                                                                    cboDistrito.Items.Add("La Granja")
                                                                                                                Else
                                                                                                                    If (cboCanton.SelectedItem = "Poás") Then
                                                                                                                        cboDistrito.Items.Add("San Pedro")
                                                                                                                        cboDistrito.Items.Add("San Juan")
                                                                                                                        cboDistrito.Items.Add("San Rafael")
                                                                                                                        cboDistrito.Items.Add("Carrillos")
                                                                                                                        cboDistrito.Items.Add("Sabana Redonda")
                                                                                                                    Else
                                                                                                                        If (cboCanton.SelectedItem = "Orotina") Then
                                                                                                                            cboDistrito.Items.Add("Orotina")
                                                                                                                            cboDistrito.Items.Add("Mastate")
                                                                                                                            cboDistrito.Items.Add("Hacienda Vieja")
                                                                                                                            cboDistrito.Items.Add("Coyolar")
                                                                                                                        Else
                                                                                                                            If (cboCanton.SelectedItem = "San Carlos") Then
                                                                                                                                cboDistrito.Items.Add("Quesada")
                                                                                                                                cboDistrito.Items.Add("Florencia")
                                                                                                                                cboDistrito.Items.Add("Buenavista")
                                                                                                                                cboDistrito.Items.Add("Aguas Zarcas")
                                                                                                                                cboDistrito.Items.Add("Venecia")
                                                                                                                                cboDistrito.Items.Add("Pital")
                                                                                                                                cboDistrito.Items.Add("La Fortuna")
                                                                                                                                cboDistrito.Items.Add("La Tigra")
                                                                                                                                cboDistrito.Items.Add("La Palmera")
                                                                                                                                cboDistrito.Items.Add("Venado")
                                                                                                                                cboDistrito.Items.Add("Cutris")
                                                                                                                                cboDistrito.Items.Add("Monterrey")
                                                                                                                                cboDistrito.Items.Add("Pocosol")
                                                                                                                            Else
                                                                                                                                If (cboCanton.SelectedItem = "Zarcero") Then
                                                                                                                                    cboDistrito.Items.Add("Zarcero")
                                                                                                                                    cboDistrito.Items.Add("Laguna")
                                                                                                                                    cboDistrito.Items.Add("Tapezco")
                                                                                                                                    cboDistrito.Items.Add("Guadalupe")
                                                                                                                                    cboDistrito.Items.Add("Palmira")
                                                                                                                                    cboDistrito.Items.Add("Zapote")
                                                                                                                                    cboDistrito.Items.Add("Brisas")
                                                                                                                                Else
                                                                                                                                    If (cboCanton.SelectedItem = "Valverde Vega") Then
                                                                                                                                        cboDistrito.Items.Add("Sarchí Norte")
                                                                                                                                        cboDistrito.Items.Add("Sarchí Sur")
                                                                                                                                        cboDistrito.Items.Add("Toro Amarillo")
                                                                                                                                        cboDistrito.Items.Add("San Pedro")
                                                                                                                                        cboDistrito.Items.Add("Rodríguez")
                                                                                                                                    Else
                                                                                                                                        If (cboCanton.SelectedItem = "Upala") Then
                                                                                                                                            cboDistrito.Items.Add("Upala")
                                                                                                                                            cboDistrito.Items.Add("Aguas Claras")
                                                                                                                                            cboDistrito.Items.Add("San José (Pizote)")
                                                                                                                                            cboDistrito.Items.Add("Bijagua")
                                                                                                                                            cboDistrito.Items.Add("Delicias")
                                                                                                                                            cboDistrito.Items.Add("Dos Ríos")
                                                                                                                                            cboDistrito.Items.Add("Yolillal")
                                                                                                                                            cboDistrito.Items.Add("Canalete")
                                                                                                                                        Else
                                                                                                                                            If (cboCanton.SelectedItem = "Los Chiles") Then
                                                                                                                                                cboDistrito.Items.Add("Los Chiles")
                                                                                                                                                cboDistrito.Items.Add("Caño Negro")
                                                                                                                                                cboDistrito.Items.Add("El Amparo")
                                                                                                                                                cboDistrito.Items.Add("San Jorge")
                                                                                                                                            Else
                                                                                                                                                If (cboCanton.SelectedItem = "Guatuso") Then
                                                                                                                                                    cboDistrito.Items.Add("San Rafael")
                                                                                                                                                    cboDistrito.Items.Add("Buenavista")
                                                                                                                                                    cboDistrito.Items.Add("Cote")
                                                                                                                                                    cboDistrito.Items.Add("Katira")

                                                                                                                                                Else
                                                                                                                                                    If (cboCanton.SelectedItem = "Guatuso") Then
                                                                                                                                                    Else
                                                                                                                                                        If (cboCanton.SelectedItem = "Cartago") Then
                                                                                                                                                            cboDistrito.Items.Add("Occidental")
                                                                                                                                                            cboDistrito.Items.Add("Carmen")
                                                                                                                                                            cboDistrito.Items.Add("San Nicolás")
                                                                                                                                                            cboDistrito.Items.Add("Agua Caliente (San Francisco)")
                                                                                                                                                            cboDistrito.Items.Add("Guadalupe (Arenilla)")
                                                                                                                                                            cboDistrito.Items.Add("Corralillo")
                                                                                                                                                            cboDistrito.Items.Add("Tierra Blanca")
                                                                                                                                                            cboDistrito.Items.Add("Dulce Nombre")
                                                                                                                                                            cboDistrito.Items.Add("Llano Grande")
                                                                                                                                                            cboDistrito.Items.Add("Quebradilla")
                                                                                                                                                        Else
                                                                                                                                                            If (cboCanton.SelectedItem = "Paraíso") Then
                                                                                                                                                                cboDistrito.Items.Add("Paraíso")
                                                                                                                                                                cboDistrito.Items.Add("Santiago de Paraíso")
                                                                                                                                                                cboDistrito.Items.Add("Orosi")
                                                                                                                                                                cboDistrito.Items.Add("Cachí")
                                                                                                                                                                cboDistrito.Items.Add("Llanos de Santa Lucía")
                                                                                                                                                            Else
                                                                                                                                                                If (cboCanton.SelectedItem = "La Unión") Then
                                                                                                                                                                    cboDistrito.Items.Add("Tres Ríos")
                                                                                                                                                                    cboDistrito.Items.Add("San Diego")
                                                                                                                                                                    cboDistrito.Items.Add("San Juan")
                                                                                                                                                                    cboDistrito.Items.Add("San Rafael")
                                                                                                                                                                    cboDistrito.Items.Add("Concepción")
                                                                                                                                                                    cboDistrito.Items.Add("Dulce Nombre")
                                                                                                                                                                    cboDistrito.Items.Add("San Ramón")
                                                                                                                                                                    cboDistrito.Items.Add("Río Azul")
                                                                                                                                                                Else
                                                                                                                                                                    If (cboCanton.SelectedItem = "Jiménez") Then
                                                                                                                                                                        cboDistrito.Items.Add("Juan Viñas")
                                                                                                                                                                        cboDistrito.Items.Add("Tucurrique")
                                                                                                                                                                        cboDistrito.Items.Add("Pejibaye")
                                                                                                                                                                    Else
                                                                                                                                                                        If (cboCanton.SelectedItem = "Turrialba") Then
                                                                                                                                                                            cboDistrito.Items.Add("Turrialba")
                                                                                                                                                                            cboDistrito.Items.Add("La Suiza")
                                                                                                                                                                            cboDistrito.Items.Add("Peralta")
                                                                                                                                                                            cboDistrito.Items.Add("Santa Cruz")
                                                                                                                                                                            cboDistrito.Items.Add("Santa Teresita")
                                                                                                                                                                            cboDistrito.Items.Add("Pavones")
                                                                                                                                                                            cboDistrito.Items.Add("Tuis")
                                                                                                                                                                            cboDistrito.Items.Add("Tayutic")
                                                                                                                                                                            cboDistrito.Items.Add("Santa Rosa")
                                                                                                                                                                            cboDistrito.Items.Add("Tres Equis")
                                                                                                                                                                            cboDistrito.Items.Add("La Isabel")
                                                                                                                                                                            cboDistrito.Items.Add("Chirripó")

                                                                                                                                                                        Else
                                                                                                                                                                            If (cboCanton.SelectedItem = "Alvarado") Then
                                                                                                                                                                                cboDistrito.Items.Add("Pacayas")
                                                                                                                                                                                cboDistrito.Items.Add("Cervantes")
                                                                                                                                                                                cboDistrito.Items.Add("Capellades")
                                                                                                                                                                            Else
                                                                                                                                                                                If (cboCanton.SelectedItem = "Oreamuno") Then
                                                                                                                                                                                    cboDistrito.Items.Add("San Rafael")
                                                                                                                                                                                    cboDistrito.Items.Add("Cot")
                                                                                                                                                                                    cboDistrito.Items.Add("Potrero Cerrado")
                                                                                                                                                                                    cboDistrito.Items.Add("Cipreses")
                                                                                                                                                                                    cboDistrito.Items.Add("Santa Rosa")

                                                                                                                                                                                Else
                                                                                                                                                                                    If (cboCanton.SelectedItem = "El Guarco") Then
                                                                                                                                                                                        cboDistrito.Items.Add("Tejar")
                                                                                                                                                                                        cboDistrito.Items.Add("San Isidro")
                                                                                                                                                                                        cboDistrito.Items.Add("Tobosi")
                                                                                                                                                                                        cboDistrito.Items.Add("Patio de Agua")
                                                                                                                                                                                    Else
                                                                                                                                                                                        If (cboCanton.SelectedItem = "Heredia") Then
                                                                                                                                                                                            cboDistrito.Items.Add("Mercedes")
                                                                                                                                                                                            cboDistrito.Items.Add("San Francisco")
                                                                                                                                                                                            cboDistrito.Items.Add("Ulloa")
                                                                                                                                                                                            cboDistrito.Items.Add("Vara Blanca")
                                                                                                                                                                                        Else
                                                                                                                                                                                            If (cboCanton.SelectedItem = "Barva") Then
                                                                                                                                                                                                cboDistrito.Items.Add("Barva")
                                                                                                                                                                                                cboDistrito.Items.Add("San Pedro")
                                                                                                                                                                                                cboDistrito.Items.Add("San Pablo")
                                                                                                                                                                                                cboDistrito.Items.Add("San Roque")
                                                                                                                                                                                                cboDistrito.Items.Add("Santa Lucía")
                                                                                                                                                                                                cboDistrito.Items.Add("San José de la Montaña")
                                                                                                                                                                                            Else
                                                                                                                                                                                                If (cboCanton.SelectedItem = "Santo Domingo") Then
                                                                                                                                                                                                    cboDistrito.Items.Add("Santo Domingo")
                                                                                                                                                                                                    cboDistrito.Items.Add("San Vicente")
                                                                                                                                                                                                    cboDistrito.Items.Add("San Miguel")
                                                                                                                                                                                                    cboDistrito.Items.Add("Paracito")
                                                                                                                                                                                                    cboDistrito.Items.Add("Santo Tomás")
                                                                                                                                                                                                    cboDistrito.Items.Add("Santa Rosa")
                                                                                                                                                                                                    cboDistrito.Items.Add("Tures")
                                                                                                                                                                                                    cboDistrito.Items.Add("Pará")
                                                                                                                                                                                                Else
                                                                                                                                                                                                    If (cboCanton.SelectedItem = "Santa Bárbara") Then
                                                                                                                                                                                                        cboDistrito.Items.Add("Santa Bárbara")
                                                                                                                                                                                                        cboDistrito.Items.Add("San Pedro")
                                                                                                                                                                                                        cboDistrito.Items.Add("San Juan")
                                                                                                                                                                                                        cboDistrito.Items.Add("Jesús")
                                                                                                                                                                                                        cboDistrito.Items.Add("Santo Domingo")
                                                                                                                                                                                                        cboDistrito.Items.Add("Purabá")

                                                                                                                                                                                                    Else
                                                                                                                                                                                                        If (cboCanton.SelectedItem = "San Rafael") Then
                                                                                                                                                                                                            cboDistrito.Items.Add("San Rafael")
                                                                                                                                                                                                            cboDistrito.Items.Add("San Josecito")
                                                                                                                                                                                                            cboDistrito.Items.Add("Santiago")
                                                                                                                                                                                                            cboDistrito.Items.Add("Ángeles")
                                                                                                                                                                                                            cboDistrito.Items.Add("Concepción")
                                                                                                                                                                                                        Else
                                                                                                                                                                                                            If (cboCanton.SelectedItem = "San Isidro") Then
                                                                                                                                                                                                                cboDistrito.Items.Add("San Isidro")
                                                                                                                                                                                                                cboDistrito.Items.Add("San José")
                                                                                                                                                                                                                cboDistrito.Items.Add("Concepción")
                                                                                                                                                                                                                cboDistrito.Items.Add("San Francisco")

                                                                                                                                                                                                            Else
                                                                                                                                                                                                                If (cboCanton.SelectedItem = "Belén") Then
                                                                                                                                                                                                                    cboDistrito.Items.Add("San Antonio")
                                                                                                                                                                                                                    cboDistrito.Items.Add("La Ribera")
                                                                                                                                                                                                                    cboDistrito.Items.Add("La Asunción")

                                                                                                                                                                                                                Else
                                                                                                                                                                                                                    If (cboCanton.SelectedItem = "Flores") Then
                                                                                                                                                                                                                        cboDistrito.Items.Add("San Joaquín")
                                                                                                                                                                                                                        cboDistrito.Items.Add("Barrantes")
                                                                                                                                                                                                                        cboDistrito.Items.Add("Llorente")


                                                                                                                                                                                                                    Else
                                                                                                                                                                                                                        If (cboCanton.SelectedItem = "San Pablo") Then
                                                                                                                                                                                                                            cboDistrito.Items.Add("San Pablo")
                                                                                                                                                                                                                            cboDistrito.Items.Add("Rincón de Sabanilla")
                                                                                                                                                                                                                        Else
                                                                                                                                                                                                                            If (cboCanton.SelectedItem = "Sarapiquí") Then
                                                                                                                                                                                                                                cboDistrito.Items.Add("Puerto Viejo")
                                                                                                                                                                                                                                cboDistrito.Items.Add("La Virgen")
                                                                                                                                                                                                                                cboDistrito.Items.Add("Horquetas")
                                                                                                                                                                                                                                cboDistrito.Items.Add("Llanuras del Gaspar")
                                                                                                                                                                                                                                cboDistrito.Items.Add("Cureña")
                                                                                                                                                                                                                            Else
                                                                                                                                                                                                                                If (cboCanton.SelectedItem = "Liberia") Then
                                                                                                                                                                                                                                    cboDistrito.Items.Add("Liberia")
                                                                                                                                                                                                                                    cboDistrito.Items.Add("Cañas Dulces")
                                                                                                                                                                                                                                    cboDistrito.Items.Add("Mayorga")
                                                                                                                                                                                                                                    cboDistrito.Items.Add("Nacascolo")
                                                                                                                                                                                                                                    cboDistrito.Items.Add("Curubandé")
                                                                                                                                                                                                                                Else
                                                                                                                                                                                                                                    If (cboCanton.SelectedItem = "Nicoya") Then
                                                                                                                                                                                                                                        cboDistrito.Items.Add("Nicoya")
                                                                                                                                                                                                                                        cboDistrito.Items.Add("Mansión")
                                                                                                                                                                                                                                        cboDistrito.Items.Add("San Antonio")
                                                                                                                                                                                                                                        cboDistrito.Items.Add("Quebrada Honda")
                                                                                                                                                                                                                                        cboDistrito.Items.Add("Sámara")
                                                                                                                                                                                                                                        cboDistrito.Items.Add("Nosara")
                                                                                                                                                                                                                                        cboDistrito.Items.Add("Belén de Nosarita")

                                                                                                                                                                                                                                    Else
                                                                                                                                                                                                                                        If (cboCanton.SelectedItem = "Santa Cruz") Then
                                                                                                                                                                                                                                            cboDistrito.Items.Add("Santa Cruz")
                                                                                                                                                                                                                                            cboDistrito.Items.Add("Bolsón")
                                                                                                                                                                                                                                            cboDistrito.Items.Add("Veintisiete de Abril")
                                                                                                                                                                                                                                            cboDistrito.Items.Add("Tempate")
                                                                                                                                                                                                                                            cboDistrito.Items.Add("Cartagena")
                                                                                                                                                                                                                                            cboDistrito.Items.Add("Cuajiniquil")
                                                                                                                                                                                                                                            cboDistrito.Items.Add("Diriá")
                                                                                                                                                                                                                                            cboDistrito.Items.Add("Cabo Velas")
                                                                                                                                                                                                                                            cboDistrito.Items.Add("Tamarindo")
                                                                                                                                                                                                                                        Else
                                                                                                                                                                                                                                            If (cboCanton.SelectedItem = "Bagaces") Then
                                                                                                                                                                                                                                                cboDistrito.Items.Add("Bagaces")
                                                                                                                                                                                                                                                cboDistrito.Items.Add("La Fortuna")
                                                                                                                                                                                                                                                cboDistrito.Items.Add("Mogote")
                                                                                                                                                                                                                                                cboDistrito.Items.Add("Río Naranjo")

                                                                                                                                                                                                                                            Else
                                                                                                                                                                                                                                                If (cboCanton.SelectedItem = "Carrillo") Then
                                                                                                                                                                                                                                                    cboDistrito.Items.Add("Filadelfia")
                                                                                                                                                                                                                                                    cboDistrito.Items.Add("Palmira")
                                                                                                                                                                                                                                                    cboDistrito.Items.Add("Sardinal")
                                                                                                                                                                                                                                                    cboDistrito.Items.Add("Belén")

                                                                                                                                                                                                                                                Else
                                                                                                                                                                                                                                                    If (cboCanton.SelectedItem = "Cañas") Then
                                                                                                                                                                                                                                                        cboDistrito.Items.Add("Cañas")
                                                                                                                                                                                                                                                        cboDistrito.Items.Add("Palmira")
                                                                                                                                                                                                                                                        cboDistrito.Items.Add("San Miguel")
                                                                                                                                                                                                                                                        cboDistrito.Items.Add("Bebedero")
                                                                                                                                                                                                                                                        cboDistrito.Items.Add("Porozal")

                                                                                                                                                                                                                                                    Else
                                                                                                                                                                                                                                                        If (cboCanton.SelectedItem = "Abangares") Then
                                                                                                                                                                                                                                                            cboDistrito.Items.Add("Las Juntas")
                                                                                                                                                                                                                                                            cboDistrito.Items.Add("Sierra")
                                                                                                                                                                                                                                                            cboDistrito.Items.Add("San Juan")
                                                                                                                                                                                                                                                            cboDistrito.Items.Add("Colorado")


                                                                                                                                                                                                                                                        Else
                                                                                                                                                                                                                                                            If (cboCanton.SelectedItem = "Tilarán") Then
                                                                                                                                                                                                                                                                cboDistrito.Items.Add("Tilarán")
                                                                                                                                                                                                                                                                cboDistrito.Items.Add("Quebrada Grande")
                                                                                                                                                                                                                                                                cboDistrito.Items.Add("Tronadora")
                                                                                                                                                                                                                                                                cboDistrito.Items.Add("Santa Rosa")
                                                                                                                                                                                                                                                                cboDistrito.Items.Add("Líbano")
                                                                                                                                                                                                                                                                cboDistrito.Items.Add("Tierras Morenas")
                                                                                                                                                                                                                                                                cboDistrito.Items.Add("Arenal")

                                                                                                                                                                                                                                                            Else
                                                                                                                                                                                                                                                                If (cboCanton.SelectedItem = "Nandayure") Then
                                                                                                                                                                                                                                                                    cboDistrito.Items.Add("Carmona")
                                                                                                                                                                                                                                                                    cboDistrito.Items.Add("Santa Rita")
                                                                                                                                                                                                                                                                    cboDistrito.Items.Add("Zapotal")
                                                                                                                                                                                                                                                                    cboDistrito.Items.Add("San Pablo")
                                                                                                                                                                                                                                                                    cboDistrito.Items.Add("Porvenir")
                                                                                                                                                                                                                                                                    cboDistrito.Items.Add("Bejuco")


                                                                                                                                                                                                                                                                Else
                                                                                                                                                                                                                                                                    If (cboCanton.SelectedItem = "La Cruz") Then
                                                                                                                                                                                                                                                                        cboDistrito.Items.Add("La Cruz")
                                                                                                                                                                                                                                                                        cboDistrito.Items.Add("Santa Cecilia")
                                                                                                                                                                                                                                                                        cboDistrito.Items.Add("La Garita")
                                                                                                                                                                                                                                                                        cboDistrito.Items.Add("Santa Elena")
                                                                                                                                                                                                                                                                    Else
                                                                                                                                                                                                                                                                        If (cboCanton.SelectedItem = "Hojancha") Then
                                                                                                                                                                                                                                                                            cboDistrito.Items.Add("Hojancha")
                                                                                                                                                                                                                                                                            cboDistrito.Items.Add("Monte Romo")
                                                                                                                                                                                                                                                                            cboDistrito.Items.Add("Puerto Carrillo")
                                                                                                                                                                                                                                                                            cboDistrito.Items.Add("Huacas")
                                                                                                                                                                                                                                                                            cboDistrito.Items.Add("Matambú")
                                                                                                                                                                                                                                                                        Else
                                                                                                                                                                                                                                                                            If (cboCanton.SelectedItem = "Puntarenas") Then
                                                                                                                                                                                                                                                                                cboDistrito.Items.Add("Puntarenas")
                                                                                                                                                                                                                                                                                cboDistrito.Items.Add("Pitahaya")
                                                                                                                                                                                                                                                                                cboDistrito.Items.Add("Chomes")
                                                                                                                                                                                                                                                                                cboDistrito.Items.Add("Lepanto")
                                                                                                                                                                                                                                                                                cboDistrito.Items.Add("Paquera")
                                                                                                                                                                                                                                                                                cboDistrito.Items.Add("Manzanillo")
                                                                                                                                                                                                                                                                                cboDistrito.Items.Add("Guacimal")
                                                                                                                                                                                                                                                                                cboDistrito.Items.Add("Barranca")
                                                                                                                                                                                                                                                                                cboDistrito.Items.Add("Monteverde")
                                                                                                                                                                                                                                                                                cboDistrito.Items.Add("Isla del Coco")
                                                                                                                                                                                                                                                                                cboDistrito.Items.Add("Cóbano")
                                                                                                                                                                                                                                                                                cboDistrito.Items.Add("Chacarita")
                                                                                                                                                                                                                                                                                cboDistrito.Items.Add("Chira")
                                                                                                                                                                                                                                                                                cboDistrito.Items.Add("Acapulco")
                                                                                                                                                                                                                                                                                cboDistrito.Items.Add("El Roble")
                                                                                                                                                                                                                                                                                cboDistrito.Items.Add("Arancibia")


                                                                                                                                                                                                                                                                            Else
                                                                                                                                                                                                                                                                                If (cboCanton.SelectedItem = "Esparza") Then
                                                                                                                                                                                                                                                                                    cboDistrito.Items.Add("Espíritu Santo")
                                                                                                                                                                                                                                                                                    cboDistrito.Items.Add("San Juan Grande")
                                                                                                                                                                                                                                                                                    cboDistrito.Items.Add("Macacona")
                                                                                                                                                                                                                                                                                    cboDistrito.Items.Add("San Rafael")
                                                                                                                                                                                                                                                                                    cboDistrito.Items.Add("San Jerónimo")
                                                                                                                                                                                                                                                                                    cboDistrito.Items.Add("Caldera")


                                                                                                                                                                                                                                                                                Else
                                                                                                                                                                                                                                                                                    If (cboCanton.SelectedItem = "Buenos Aires") Then
                                                                                                                                                                                                                                                                                        cboDistrito.Items.Add("Buenos Aires")
                                                                                                                                                                                                                                                                                        cboDistrito.Items.Add("Volcán")
                                                                                                                                                                                                                                                                                        cboDistrito.Items.Add("Potrero Grande")
                                                                                                                                                                                                                                                                                        cboDistrito.Items.Add("Boruca")
                                                                                                                                                                                                                                                                                        cboDistrito.Items.Add("Pilas")
                                                                                                                                                                                                                                                                                        cboDistrito.Items.Add("Colinas")
                                                                                                                                                                                                                                                                                        cboDistrito.Items.Add("Chánguena")
                                                                                                                                                                                                                                                                                        cboDistrito.Items.Add("Biolley")
                                                                                                                                                                                                                                                                                        cboDistrito.Items.Add("Brunka")

                                                                                                                                                                                                                                                                                    Else
                                                                                                                                                                                                                                                                                        If (cboCanton.SelectedItem = "Montes de Oro") Then
                                                                                                                                                                                                                                                                                            cboDistrito.Items.Add("Miramar")
                                                                                                                                                                                                                                                                                            cboDistrito.Items.Add("La Unión")
                                                                                                                                                                                                                                                                                            cboDistrito.Items.Add("San Isidro")

                                                                                                                                                                                                                                                                                        Else
                                                                                                                                                                                                                                                                                            If (cboCanton.SelectedItem = "Osa") Then
                                                                                                                                                                                                                                                                                                cboDistrito.Items.Add("Cortés")
                                                                                                                                                                                                                                                                                                cboDistrito.Items.Add("Palmar")
                                                                                                                                                                                                                                                                                                cboDistrito.Items.Add("Sierpe")
                                                                                                                                                                                                                                                                                                cboDistrito.Items.Add("Bahía Ballena")
                                                                                                                                                                                                                                                                                                cboDistrito.Items.Add("Piedras Blancas")
                                                                                                                                                                                                                                                                                                cboDistrito.Items.Add("Bahía Drake")


                                                                                                                                                                                                                                                                                            Else
                                                                                                                                                                                                                                                                                                If (cboCanton.SelectedItem = "Quepos") Then
                                                                                                                                                                                                                                                                                                    cboDistrito.Items.Add("Quepos")
                                                                                                                                                                                                                                                                                                    cboDistrito.Items.Add("Savegre")
                                                                                                                                                                                                                                                                                                    cboDistrito.Items.Add("Naranjito")

                                                                                                                                                                                                                                                                                                Else
                                                                                                                                                                                                                                                                                                    If (cboCanton.SelectedItem = "Golfito") Then
                                                                                                                                                                                                                                                                                                        cboDistrito.Items.Add("Golfito")
                                                                                                                                                                                                                                                                                                        cboDistrito.Items.Add("Puerto Jiménez")
                                                                                                                                                                                                                                                                                                        cboDistrito.Items.Add("Guaycará")
                                                                                                                                                                                                                                                                                                        cboDistrito.Items.Add("Pavón")


                                                                                                                                                                                                                                                                                                    Else
                                                                                                                                                                                                                                                                                                        If (cboCanton.SelectedItem = "Coto Brus") Then
                                                                                                                                                                                                                                                                                                            cboDistrito.Items.Add("San Vito")
                                                                                                                                                                                                                                                                                                            cboDistrito.Items.Add("Sabalito")
                                                                                                                                                                                                                                                                                                            cboDistrito.Items.Add("Aguabuena")
                                                                                                                                                                                                                                                                                                            cboDistrito.Items.Add("Limoncito")
                                                                                                                                                                                                                                                                                                            cboDistrito.Items.Add("Pittier")
                                                                                                                                                                                                                                                                                                            cboDistrito.Items.Add("Gutiérrez Brown")

                                                                                                                                                                                                                                                                                                        Else
                                                                                                                                                                                                                                                                                                            If (cboCanton.SelectedItem = "Parrita") Then
                                                                                                                                                                                                                                                                                                                cboDistrito.Items.Add("Parrita")


                                                                                                                                                                                                                                                                                                            Else
                                                                                                                                                                                                                                                                                                                If (cboCanton.SelectedItem = "Corredores") Then
                                                                                                                                                                                                                                                                                                                    cboDistrito.Items.Add("Corredor")
                                                                                                                                                                                                                                                                                                                    cboDistrito.Items.Add("La Cuesta")
                                                                                                                                                                                                                                                                                                                    cboDistrito.Items.Add("Paso Canoas")
                                                                                                                                                                                                                                                                                                                    cboDistrito.Items.Add("Laurel")

                                                                                                                                                                                                                                                                                                                Else
                                                                                                                                                                                                                                                                                                                    If (cboCanton.SelectedItem = "Garabito") Then
                                                                                                                                                                                                                                                                                                                        cboDistrito.Items.Add("Jacó")
                                                                                                                                                                                                                                                                                                                        cboDistrito.Items.Add("Tárcoles")
                                                                                                                                                                                                                                                                                                                    Else
                                                                                                                                                                                                                                                                                                                        If (cboCanton.SelectedItem = "Limón") Then
                                                                                                                                                                                                                                                                                                                            cboDistrito.Items.Add("Limón")
                                                                                                                                                                                                                                                                                                                            cboDistrito.Items.Add("Valle La Estrella")
                                                                                                                                                                                                                                                                                                                            cboDistrito.Items.Add("Río Blanco")
                                                                                                                                                                                                                                                                                                                            cboDistrito.Items.Add("Matama")

                                                                                                                                                                                                                                                                                                                        Else
                                                                                                                                                                                                                                                                                                                            If (cboCanton.SelectedItem = "Pococí") Then
                                                                                                                                                                                                                                                                                                                                cboDistrito.Items.Add("Guápiles")
                                                                                                                                                                                                                                                                                                                                cboDistrito.Items.Add("Jiménez")
                                                                                                                                                                                                                                                                                                                                cboDistrito.Items.Add("La Rita")
                                                                                                                                                                                                                                                                                                                                cboDistrito.Items.Add("Roxana")
                                                                                                                                                                                                                                                                                                                                cboDistrito.Items.Add("Cariari")
                                                                                                                                                                                                                                                                                                                                cboDistrito.Items.Add("Colorado")
                                                                                                                                                                                                                                                                                                                                cboDistrito.Items.Add("La Colonia")

                                                                                                                                                                                                                                                                                                                            Else
                                                                                                                                                                                                                                                                                                                                If (cboCanton.SelectedItem = "Siquirres") Then
                                                                                                                                                                                                                                                                                                                                    cboDistrito.Items.Add("Siquirres")
                                                                                                                                                                                                                                                                                                                                    cboDistrito.Items.Add("Pacuarito")
                                                                                                                                                                                                                                                                                                                                    cboDistrito.Items.Add("Florida")
                                                                                                                                                                                                                                                                                                                                    cboDistrito.Items.Add("Germania")
                                                                                                                                                                                                                                                                                                                                    cboDistrito.Items.Add("Cairo")
                                                                                                                                                                                                                                                                                                                                    cboDistrito.Items.Add("Alegría")


                                                                                                                                                                                                                                                                                                                                Else
                                                                                                                                                                                                                                                                                                                                    If (cboCanton.SelectedItem = "Talamanca") Then
                                                                                                                                                                                                                                                                                                                                        cboDistrito.Items.Add("Bratsi")
                                                                                                                                                                                                                                                                                                                                        cboDistrito.Items.Add("Sixaola")
                                                                                                                                                                                                                                                                                                                                        cboDistrito.Items.Add("Cahuita")
                                                                                                                                                                                                                                                                                                                                        cboDistrito.Items.Add("Telire")


                                                                                                                                                                                                                                                                                                                                    Else
                                                                                                                                                                                                                                                                                                                                        If (cboCanton.SelectedItem = "Matina") Then
                                                                                                                                                                                                                                                                                                                                            cboDistrito.Items.Add("Matina")
                                                                                                                                                                                                                                                                                                                                            cboDistrito.Items.Add("Batán")
                                                                                                                                                                                                                                                                                                                                            cboDistrito.Items.Add("Carrandi")
                                                                                                                                                                                                                                                                                                                                        Else
                                                                                                                                                                                                                                                                                                                                            If (cboCanton.SelectedItem = "Guácimo") Then
                                                                                                                                                                                                                                                                                                                                                cboDistrito.Items.Add("Guácimo")
                                                                                                                                                                                                                                                                                                                                                cboDistrito.Items.Add("Mercedes")
                                                                                                                                                                                                                                                                                                                                                cboDistrito.Items.Add("Pocora")
                                                                                                                                                                                                                                                                                                                                                cboDistrito.Items.Add("Río Jiménez")
                                                                                                                                                                                                                                                                                                                                                cboDistrito.Items.Add("Duacarí")

                                                                                                                                                                                                                                                                                                                                            End If
                                                                                                                                                                                                                                                                                                                                        End If
                                                                                                                                                                                                                                                                                                                                    End If
                                                                                                                                                                                                                                                                                                                                End If
                                                                                                                                                                                                                                                                                                                            End If
                                                                                                                                                                                                                                                                                                                        End If
                                                                                                                                                                                                                                                                                                                    End If
                                                                                                                                                                                                                                                                                                                End If
                                                                                                                                                                                                                                                                                                            End If
                                                                                                                                                                                                                                                                                                        End If
                                                                                                                                                                                                                                                                                                    End If
                                                                                                                                                                                                                                                                                                End If
                                                                                                                                                                                                                                                                                            End If
                                                                                                                                                                                                                                                                                        End If
                                                                                                                                                                                                                                                                                    End If
                                                                                                                                                                                                                                                                                End If
                                                                                                                                                                                                                                                                            End If
                                                                                                                                                                                                                                                                        End If
                                                                                                                                                                                                                                                                    End If
                                                                                                                                                                                                                                                                End If
                                                                                                                                                                                                                                                            End If
                                                                                                                                                                                                                                                        End If
                                                                                                                                                                                                                                                    End If
                                                                                                                                                                                                                                                End If
                                                                                                                                                                                                                                            End If
                                                                                                                                                                                                                                        End If
                                                                                                                                                                                                                                    End If
                                                                                                                                                                                                                                End If
                                                                                                                                                                                                                            End If
                                                                                                                                                                                                                        End If
                                                                                                                                                                                                                    End If
                                                                                                                                                                                                                End If
                                                                                                                                                                                                            End If
                                                                                                                                                                                                        End If
                                                                                                                                                                                                    End If
                                                                                                                                                                                                End If
                                                                                                                                                                                            End If
                                                                                                                                                                                        End If
                                                                                                                                                                                    End If
                                                                                                                                                                                End If
                                                                                                                                                                            End If
                                                                                                                                                                        End If
                                                                                                                                                                    End If
                                                                                                                                                                End If
                                                                                                                                                            End If
                                                                                                                                                        End If
                                                                                                                                                    End If
                                                                                                                                                End If
                                                                                                                                            End If
                                                                                                                                        End If
                                                                                                                                    End If
                                                                                                                                End If
                                                                                                                            End If
                                                                                                                        End If
                                                                                                                    End If
                                                                                                                End If
                                                                                                            End If
                                                                                                        End If
                                                                                                    End If
                                                                                                End If
                                                                                            End If
                                                                                        End If
                                                                                    End If
                                                                                End If
                                                                            End If
                                                                        End If
                                                                    End If
                                                                End If
                                                            End If
                                                        End If
                                                    End If
                                                End If
                                            End If
                                        End If
                                    End If
                                End If
                            End If
                        End If
                    End If
                End If
            End If
        End If





    End Sub
    Private Sub cargarRol()
        Try
            Dim rm As New RolManagement
            Dim listaRoles = rm.RetrieveAlls(Of Rol)
            cboRoles.Items.Clear()
            For i = 0 To listaRoles.Count - 1
                cboRoles.Items.Add(listaRoles.Item(i).Nombre_Role)

            Next

        Catch ex As ChallengeMeException
            _em.ManageException(ex)
        End Try

    End Sub

    Private Sub cboRoles_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboRoles.SelectedIndexChanged

        Try
            Dim rm As New RolManagement
            Dim r As New Rol
            'agarra el nombre del rol que se ha seleccionado del combo de roles
            'y lo pasa a la varia r.Nomnbre_Role
            r.Nombre_Role = cboRoles.SelectedItem

            'se hace la búsqueda en la tabla de roles por medio del nombre del rol
            'para encontrar el id del rol asociado con el nombre del rol que el usuario ha seleccionado
            'del combobox                                                    
            Dim lista = rm.RetrieveByName(Of Rol)(r)
            For i = 0 To lista.Count - 1
                'por último se pasa a una caja de texto el id del rol encontrado a través del nombre
                'de ese rol para luego desde el evento change de la caja de texto txtCodRol
                'hacer una busqueda de ese idrol en la tabla TL_ROLE_PERMISO
                'y verificar los idpermisos asignados a ese idrol en dicha tabla para luego
                'hacer una busqueda de esos idpermisos encontrados en ROLE_PERMISO y que han sido
                'asignados a un idrol, en la tabla TBL_PERMISOS y hacer el join para traer el nombre
                'y el area del permiso que han sido aplicados a ese idrol.
                txtIdRol.Text = lista.Item(i).IdRol

            Next

        Catch ex As ChallengeMeException
            _em.ManageException(ex)

        End Try
    End Sub
    Private Sub cargarEmpresas()
        Dim em As New EntidadManagement
        Dim listaEmpresas = em.RetrieveAllEntidades(Of Entidad)
        cboEmpresa.Items.Clear()
        For i = 0 To listaEmpresas.Count - 1

            cboEmpresa.Items.Add(listaEmpresas.Item(i).NombreEntidad)

        Next
    End Sub

    Private Sub cboEmpresa_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboEmpresa.SelectedIndexChanged
        Try
            Dim em As New EntidadManagement
            Dim ent As New Entidad
            'agarra el nombre del rol que se ha seleccionado del combo de roles
            'y lo pasa a la varia r.Nomnbre_Role
            ent.NombreEntidad = cboEmpresa.Text

            'se hace la búsqueda en la tabla de roles por medio del nombre del rol
            'para encontrar el id del rol asociado con el nombre del rol que el usuario ha seleccionado
            'del combobox                                                    
            Dim listaEmpresas = em.RetrieveByName(Of Entidad)(ent)
            For i = 0 To listaEmpresas.Count - 1
                'por último se pasa a una caja de texto el id del rol encontrado a través del nombre
                'de ese rol para luego desde el evento change de la caja de texto txtCodRol
                'hacer una busqueda de ese idrol en la tabla TL_ROLE_PERMISO
                'y verificar los idpermisos asignados a ese idrol en dicha tabla para luego
                'hacer una busqueda de esos idpermisos encontrados en ROLE_PERMISO y que han sido
                'asignados a un idrol, en la tabla TBL_PERMISOS y hacer el join para traer el nombre
                'y el area del permiso que han sido aplicados a ese idrol.
                txtIdEmpresa.Text = listaEmpresas.Item(i).IdEntidad

            Next

        Catch ex As ChallengeMeException
            _em.ManageException(ex)

        End Try
    End Sub

    Private Sub btnImagen_Click(sender As Object, e As EventArgs) Handles btnImagen.Click
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
    Private Function convertPicBoxImageToByte(pbImage As PictureBox) As Byte()

        Dim ms As New System.IO.MemoryStream()
        pbImage.Image.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg)
        Return ms.ToArray()

    End Function

    Private Sub mskFechaNacimiento_MaskInputRejected(sender As Object, e As MaskInputRejectedEventArgs) Handles mskFechaNacimiento.MaskInputRejected

    End Sub

    Private Sub dgvListarUsuarios_CellContentClick(sender As Object, e As DataGridViewCellEventArgs)

    End Sub

    Private Sub Salir_Click(sender As Object, e As EventArgs) 


    End Sub

    Private Sub txtId_MaskInputRejected(sender As Object, e As MaskInputRejectedEventArgs) Handles txtId.MaskInputRejected

    End Sub
    Private Sub guardarUsuario()
        Dim um As New UserManagement
        Dim User As New User

        User.IdUsuario = txtId.Text
        User.NombreUsuario = txtNombre.Text
        User.DirUsuario = txtDireccion.Text
        User.Prov_Usuario = cboProvincia.SelectedItem
        User.Cant_Usuario = cboCanton.SelectedItem
        User.Dist_Usuario = cboDistrito.SelectedItem
        User.Correo_Usuario = txtEmail.Text
        User.Pass_Usuario = txtPasswordFinal.Text
        User.FNac_Usuario = mskFechaNacimiento.Text
        User.Imagen_Usuario = picImgUsr.Image
        User.FCreacion_Usuario = txtFecha.Text
        User.IdRole = txtIdRol.Text
        User.IdEntidad = txtIdEmpresa.Text
        Try
            'se llama al management para crear el usuario
            um.CreateUser(User)
            MessageBox.Show("Usuario creado Satisfactoriamente..!!", "Atención!", MessageBoxButtons.OK, MessageBoxIcon.Information)
            txtId.Text = ""
            txtNombre.Text = ""
            txtDireccion.Text = ""
            cboProvincia.SelectedIndex = 0
            cboCanton.SelectedIndex = 0
            cboDistrito.SelectedIndex = 0
            txtEmail.Text = ""
            txtPassw.Text = ""
            txtPassConfirm.Text = ""
            txtPasswordFinal.Text = ""
            mskFechaNacimiento.Text = ""
            picImgUsr.Image = Nothing
            txtIdRol.Text = ""
            txtIdEmpresa.Text = ""


            txtId.Focus()
        Catch ex As ChallengeMeException

            _em.ManageException(ex)
        End Try
    End Sub



    Private Sub txtDireccion_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtDireccion.KeyPress
        If e.KeyChar = ChrW(Keys.Enter) Then
            5:          e.Handled = True
            6:          SendKeys.Send("{TAB}")
            txtEmail.Focus()
            7:      End If
    End Sub

    Private Sub txtEmail_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtEmail.KeyPress
        If e.KeyChar = ChrW(Keys.Enter) Then
            5:          e.Handled = True
            6:          SendKeys.Send("{TAB}")
            7:      End If
    End Sub
    Private Sub dgvListarUsuarios_MouseClick(sender As Object, e As MouseEventArgs) Handles dgvListarUsuarios.MouseClick
        If dgvListarUsuarios.Rows.Count > 0 Then


            Dim i As Integer
            i = dgvListarUsuarios.Rows(0).Selected
            txtId.Text = dgvListarUsuarios.CurrentRow.Cells("IdUs").Value
            txtNombre.Text = dgvListarUsuarios.CurrentRow.Cells("Nombre").Value
            txtDireccion.Text = dgvListarUsuarios.CurrentRow.Cells("Dir").Value
            cboProvincia.Items.Clear()
            cboProvincia.Items.Add(dgvListarUsuarios.CurrentRow.Cells("Prov").Value)
            cboProvincia.SelectedIndex=0
            cboCanton.Items.Clear()
            cboCanton.Items.Add(dgvListarUsuarios.CurrentRow.Cells("Cant").Value)
            cboCanton.SelectedIndex=0
            cboDistrito.Items.Clear()
            cboDistrito.Items.Add(dgvListarUsuarios.CurrentRow.Cells("Dist").Value)
            cboDistrito.SelectedIndex=0
            txtEmail.Text = dgvListarUsuarios.CurrentRow.Cells("email").Value
            mskFechaNacimiento.Text = dgvListarUsuarios.CurrentRow.Cells("FNac").Value
            txtIdUsDos.Text = dgvListarUsuarios.CurrentRow.Cells("IdUs").Value
            txtIdRolDos.Text = dgvListarUsuarios.CurrentRow.Cells("IdRol").Value
            txtIdEmpresaDos.Text = dgvListarUsuarios.CurrentRow.Cells("IdEmpresa").Value
            txtId.Focus()



        End If
    End Sub

    Private Sub txtIdUsDos_TextChanged(sender As Object, e As EventArgs) Handles txtIdUsDos.TextChanged
        BuscarFoto()
    End Sub
    Private Sub BuscarFoto()
        Try
            Dim m As New UserManagement
            Dim u As New User

            u.IdUsuario = txtIdUsDos.Text

            u = m.Retrieve(u) 'igualo a la lista lo que encontró el procedimiento de listar
            picImgUsr.Image = u.Imagen_Usuario




        Catch ex As ChallengeMeException
            _em.ManageException(ex)
        End Try
    End Sub
    Private Sub buscarRolxId()
        Dim rm As New RolManagement
        Dim r As New Rol

        r.IdRol = txtIdRolDos.Text

        r = rm.Retrieve(r)

        cboRoles.Text = r.Nombre_Role

    End Sub
    Private Sub buscarEmpresaxId()
        Dim em As New EntidadManagement
        Dim e As New Entidad


        e.IdEntidad = txtIdEmpresaDos.Text

        e = em.RetrieveEntidad(e)

        cboEmpresa.Text = e.NombreEntidad
    End Sub

    Private Sub txtIdRolDos_TextChanged(sender As Object, e As EventArgs) Handles txtIdRolDos.TextChanged
        buscarRolxId()
    End Sub

    Private Sub txtIdEmpresaDos_TextChanged(sender As Object, e As EventArgs) Handles txtIdEmpresaDos.TextChanged
        buscarEmpresaxId()
    End Sub

    Private Sub ToolStripButton2_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub SeleccionarFotoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SeleccionarFotoToolStripMenuItem.Click
        btnImagen_Click(Me, e)
    End Sub

    Private Sub ToolStripBtnSalvar_Click(sender As Object, e As EventArgs) Handles ToolStripBtnSalvar.Click
        Dim m As New UserManagement
        Dim u As New User
        Dim user As New User


        Dim P1 As String
        Dim P2 As String

        erProveedorError.Clear()
        If txtId.MaskFull Then
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
            If (Trim(cboProvincia.SelectedIndex = -1)) Then
                erProveedorError.SetError(cboProvincia, "Debe seleccionar la Provincia para completar la Dirección")
                Return
            End if
            If (Trim(cboCanton.SelectedIndex = -1)) Then
                erProveedorError.SetError(cboCanton, "Debe seleccionar el Cantón para completar la Dirección")
                Return
                
            End If
            If (Trim(cboDistrito.SelectedIndex = -1)) Then
                erProveedorError.SetError(cboDistrito, "Debe seleccionar el Distrito para completar la Dirección")
                Return
                
            End if
            If (txtEmail.Text = "") Then
                erProveedorError.SetError(txtEmail, "Debe Indicar el Correo electrónico del Usuario")
                txtEmail.Focus()
                Return
            End if
            If (Trim(txtPassw.Text) = "") Then
                erProveedorError.SetError(txtPassw, "Debe de indicar una contraseña")
                txtPassw.Focus()
                Return
            End if
            If (Trim(txtPassConfirm.Text) = "") Then
                erProveedorError.SetError(txtPassConfirm, "Debe de indicar la contraseña de confirmación")
                txtPassConfirm.Focus()
                Return
            End if
            If (picImgUsr.Image Is Nothing) Then
                erProveedorError.SetError(picImgUsr, "Debe agregar una imagen a la cuenta")
               
                Return
            End if

            '*********************************************
            'se pasan los valores de las cajas de texto
            'de las contraseñas a dos respectivas variables
            'con el fin de compararlas
            P1 = txtPassw.Text
            P2 = txtPassConfirm.Text
            If (P1 <> P2) Then
                erProveedorError.SetError(txtPassw, "Las contraseñas no coinciden, favor ingresarlas de nuevo")
                
                txtPassw.Text = ""
                txtPassConfirm.Text = ""
                txtPassw.Focus()
                Return
            
            End if
            '************************************************

            '++++++++++++++++++++++++++++++++++++++++++++

            'Inicia el código de encriptación de la contraseña
            Dim ueCodigo As New UnicodeEncoding()
            'Objeto para instanciar las codificación
            Dim Md5 As New MD5CryptoServiceProvider()
            'Calcula el valor hash de la cadena recibida->txtPassw
            Dim bHash() As Byte = Md5.ComputeHash(ueCodigo.GetBytes(txtPassw.Text))
            'se toma en codigo ya encriptado del password recibido en la caja de texto
            'y se iguala a una variable llamada password que es la que va a ir a 
            'guardarse a la BD
            Dim password = Convert.ToBase64String(bHash)
            txtPasswordFinal.Text = password
            
            '+++++++++++++++++++++++++++++++++++++++++++++

            '********************************************
            'hago una búsqueda para ver si el id usuario ya 
            'existe en la base de datos
            'si ya existe no deja que se cree un usuario
            'repetido              
            Try
                u.IdUsuario = txtId.Text
                u = m.Retrieve(u)

            Catch ex As ChallengeMeException

                _em.ManageException(ex)

            End Try
            '********************************************
            If (u Is Nothing) Then
                'si la búsqueda dijo que el id usuario no existe
                guardarUsuario()

            Else
                ' MessageBox.Show($"El usuario con el Id [{txtId.Text}] ya existe en la Base de Datos", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Error)
                actualizarUsuario()
                
            End If

        Else
            erProveedorError.SetError(txtId, "Debe indicar el Id del Usuario que desea Guardar")
            
            txtId.Focus()

        End If
        dgvListarUsuarios.Rows.Clear()
        listarUsuarios()
        txtId.Focus()
    End Sub

    Private Sub ToolStripBtnNuevo_Click(sender As Object, e As EventArgs) Handles ToolStripBtnNuevo.Click
        txtId.Text = ""
        txtNombre.Text = ""
        txtDireccion.Text = ""
        txtIdRol.Text = ""
        txtIdEmpresa.Text = ""
        mskFechaNacimiento.Text = ""
        cboProvincia.Text=""
        cboCanton.Text=""
        cboDistrito.Text=""
        txtEmail.Text = ""
        txtPassw.Text = ""
        txtPassConfirm.Text = ""
        txtPasswordFinal.Text = ""
        cboRoles.SelectedIndex = 0
        cboEmpresa.SelectedIndex = 0
        txtIdRolDos.Text = ""
        txtIdEmpresaDos.Text = ""

        picImgUsr.Image = Nothing

        txtId.Focus()
    End Sub

    Private Sub ToolStripBtnBuscar_Click(sender As Object, e As EventArgs) Handles ToolStripBtnBuscar.Click
        Buscar()
    End Sub

    Private Sub ToolStripBtnEliminar_Click(sender As Object, e As EventArgs) Handles ToolStripBtnEliminar.Click
        Dim m As New UserManagement
        Dim u As New User

        If txtId.MaskFull Then
            u.IdUsuario = txtId.Text
            Try
                m.Delete(u)
            Catch ex As ChallengeMeException
                _em.ManageException(ex)
            End Try


            MessageBox.Show("Usuario eliminado satisfactoriamente", "Atención..!", MessageBoxButtons.OK, MessageBoxIcon.Information)
            txtId.Text = ""
            txtNombre.Text = ""
            txtDireccion.Text = ""

            cboProvincia.SelectedIndex = 0
            cboCanton.SelectedIndex = 0
            cboDistrito.SelectedIndex = 0
            txtEmail.Text = ""
            txtPassw.Text = ""
            txtPassConfirm.Text = ""
            mskFechaNacimiento.Text = ""
            picImgUsr.ResetText()
            txtIdRol.Text = ""
            txtIdEmpresa.Text = ""
            txtId.Focus()
        Else
            MessageBox.Show("Debe digitar el Id del Usuario que desea Eliminar y darle clic al botón de Buscar", "Atención..!", MessageBoxButtons.OK, MessageBoxIcon.Error)
            txtId.Focus()
        End If
        dgvListarUsuarios.Rows.Clear()
        listarUsuarios()
        txtId.Enabled = True
    End Sub

    Private Sub ToolStripBtnActualizar_Click(sender As Object, e As EventArgs) Handles ToolStripBtnActualizar.Click
        Dim m As New UserManagement
        Dim user As New User
        Dim P1 As String
        Dim P2 As String

        If txtId.MaskFull Then
            If (Trim(txtNombre.Text = "")) Then
                MessageBox.Show("Debe indicar el Nombre del Usuario que desea Guardar", "Atención..!", MessageBoxButtons.OK, MessageBoxIcon.Error)
                txtNombre.Focus()


            Else
                If (Trim(txtDireccion.Text = "")) Then
                    MessageBox.Show("Debe indicar el Apellido del Usuario que desea Guardar", "Atención..!", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    txtDireccion.Focus()


                Else
                    If (Trim(cboProvincia.SelectedIndex = -1)) Then
                        MessageBox.Show("Debe seleccionar la Provincia para completar la Dirección", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Error)

                    Else
                        If (Trim(cboCanton.SelectedIndex = -1)) Then
                            MessageBox.Show("Debe seleccionar el Cantón para completar la Dirección", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Error)

                        Else
                            If (Trim(cboDistrito.SelectedIndex = -1)) Then
                                MessageBox.Show("Debe seleccionar el Distrito para completar la Dirección", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Error)

                            Else
                                If (txtEmail.Text = "") Then
                                    MessageBox.Show("Debe Indicar el Correo electrónico del Usuario", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Error)
                                    txtEmail.Focus()

                                Else
                                    If (Trim(txtPassw.Text) = "") Then
                                        MessageBox.Show("Debe de indicar una contraseña", "Atención..!!", MessageBoxButtons.OK, MessageBoxIcon.Error)
                                        txtPassw.Focus()

                                    Else
                                        If (Trim(txtPassConfirm.Text) = "") Then
                                            MessageBox.Show("Debe de indicar la contraseña de confirmación", "Atención..!!", MessageBoxButtons.OK, MessageBoxIcon.Error)
                                            txtPassConfirm.Focus()

                                        Else
                                            '*********************************************
                                            'se pasan los valores de las cajas de texto
                                            'de las contraseñas a dos respectivas variables
                                            'con el fin de compararlas
                                            P1 = txtPassw.Text
                                            P2 = txtPassConfirm.Text
                                            If (P1 <> P2) Then
                                                MessageBox.Show("Las contraseñas no coinciden, favor ingresarlas de nuevo", "Atención..!!", MessageBoxButtons.OK, MessageBoxIcon.Error)
                                                txtPassw.Text = ""
                                                txtPassConfirm.Text = ""
                                                txtPassw.Focus()
                                                '************************************************

                                            Else
                                                '++++++++++++++++++++++++++++++++++++++++++++
                                                'Inicia el código de encriptación de la contraseña
                                                Dim ueCodigo As New UnicodeEncoding()
                                                ' Objeto para instanciar las codificación
                                                Dim Md5 As New MD5CryptoServiceProvider()
                                                'Calcula el valor hash de la cadena recibida->txtPassw
                                                Dim bHash() As Byte = Md5.ComputeHash(ueCodigo.GetBytes(txtPassw.Text))
                                                'se toma en codigo ya encriptado del password recibido en la caja de texto
                                                'y se iguala a una variable llamada password que es la que va a ir a 
                                                'guardarse a la BD
                                                Dim password = Convert.ToBase64String(bHash)
                                                '+++++++++++++++++++++++++++++++++++++++++++++
                                                '********************************************
                                                'hago una búsqueda para ver si el id usuario ya 
                                                'existe en la base de datos
                                                'si ya existe no deja que se cree un usuario
                                                'repetido              

                                                Try
                                                    user.IdUsuario = txtId.Text
                                                    user.NombreUsuario = txtNombre.Text
                                                    user.DirUsuario = txtDireccion.Text
                                                    user.Prov_Usuario = cboProvincia.SelectedItem
                                                    user.Cant_Usuario = cboCanton.SelectedItem
                                                    user.Dist_Usuario = cboDistrito.SelectedItem
                                                    user.Correo_Usuario = txtEmail.Text
                                                    user.Pass_Usuario = password
                                                    user.FNac_Usuario = mskFechaNacimiento.Text
                                                    user.Imagen_Usuario = picImgUsr.Image
                                                    user.FCreacion_Usuario = txtFecha.Text
                                                    user.IdRole = txtIdRol.Text
                                                    user.IdEntidad = txtIdEmpresa.Text
                                                    m.Update(user)

                                                Catch ex As ChallengeMeException
                                                    _em.ManageException(ex)

                                                End Try

                                                MessageBox.Show("Usuario Actualizado satisfactoriamente", "Atención..!", MessageBoxButtons.OK, MessageBoxIcon.Information)
                                                txtId.Text = ""
                                                txtNombre.Text = ""
                                                txtDireccion.Text = ""
                                                cboProvincia.SelectedIndex = 0
                                                cboCanton.SelectedIndex = 0
                                                cboDistrito.SelectedIndex = 0
                                                txtEmail.Text = ""
                                                txtPassw.Text = ""
                                                txtPassConfirm.Text = ""
                                                mskFechaNacimiento.Text = ""
                                                picImgUsr.ResetText()
                                                txtIdRol.Text = ""
                                                txtIdEmpresa.Text = ""

                                            End If

                                        End If


                                    End If

                                End If

                            End If

                        End If

                    End If

                End If

            End If


        Else
            MessageBox.Show("Debe digitar el Id del Usuario que desea actualizar y darle clic al botón de Buscar", "Atención..!", MessageBoxButtons.OK, MessageBoxIcon.Error)
            txtId.Focus()

        End If
        dgvListarUsuarios.Rows.Clear()
        listarUsuarios()
    End Sub

    Private Sub ToolStripBtn_Click(sender As Object, e As EventArgs) Handles ToolStripBtnSalir.Click
        frmMenuSA.Show()
        Me.Close()
    End Sub

    Private Sub ToolStrip1_ItemClicked(sender As Object, e As ToolStripItemClickedEventArgs) Handles ToolStrip1.ItemClicked

    End Sub

    Private Sub ttpToolTip_Popup(sender As Object, e As PopupEventArgs) Handles ttpToolTip.Popup

    End Sub
    Private sub actualizarUsuario()
        Dim um As New UserManagement
        Dim User As New User

        User.IdUsuario = txtId.Text
        User.NombreUsuario = txtNombre.Text
        User.DirUsuario = txtDireccion.Text
        User.Prov_Usuario = cboProvincia.SelectedItem
        User.Cant_Usuario = cboCanton.SelectedItem
        User.Dist_Usuario = cboDistrito.SelectedItem
        User.Correo_Usuario = txtEmail.Text
        User.Pass_Usuario = txtPasswordFinal.Text
        User.FNac_Usuario = mskFechaNacimiento.Text
        User.Imagen_Usuario = picImgUsr.Image
        User.FCreacion_Usuario = txtFecha.Text
        User.IdRole = txtIdRolDos.Text
        User.IdEntidad = txtIdEmpresaDos.Text
        Try
            'se llama al management para crear el usuario
            um.Update(User)
            MessageBox.Show("Usuario creado Satisfactoriamente..!!", "Atención!", MessageBoxButtons.OK, MessageBoxIcon.Information)
            txtId.Text = ""
            txtNombre.Text = ""
            txtDireccion.Text = ""
            cboProvincia.SelectedIndex = 0
            cboCanton.SelectedIndex = 0
            cboDistrito.SelectedIndex = 0
            txtEmail.Text = ""
            txtPassw.Text = ""
            txtPassConfirm.Text = ""
            txtPasswordFinal.Text = ""
            mskFechaNacimiento.Text = ""
            picImgUsr.Image = Nothing
            txtIdRol.Text = ""
            txtIdEmpresa.Text = ""


            txtId.Focus()
        Catch ex As ChallengeMeException

            _em.ManageException(ex)
        End Try
    End sub

    Private Sub cmsEscogerFotografia_Opening(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles cmsEscogerFotografia.Opening

    End Sub

    Private Sub picImgUsr_Click(sender As Object, e As EventArgs) Handles picImgUsr.Click

    End Sub

    Private Sub dgvListarUsuarios_CellContentClick_1(sender As Object, e As DataGridViewCellEventArgs) Handles dgvListarUsuarios.CellContentClick

    End Sub
End Class