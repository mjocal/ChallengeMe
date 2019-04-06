<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Users
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Users))
        Me.btnListar = New System.Windows.Forms.Button()
        Me.txtId = New System.Windows.Forms.MaskedTextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtDireccion = New System.Windows.Forms.TextBox()
        Me.txtNombre = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.cboCanton = New System.Windows.Forms.ComboBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.cboDistrito = New System.Windows.Forms.ComboBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.cboProvincia = New System.Windows.Forms.ComboBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txtEmail = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.txtPassw = New System.Windows.Forms.TextBox()
        Me.lblP2 = New System.Windows.Forms.Label()
        Me.txtPassConfirm = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.mskFechaNacimiento = New System.Windows.Forms.MaskedTextBox()
        Me.txtFecha = New System.Windows.Forms.TextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.cboRoles = New System.Windows.Forms.ComboBox()
        Me.txtIdRol = New System.Windows.Forms.TextBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.cboEmpresa = New System.Windows.Forms.ComboBox()
        Me.txtIdEmpresa = New System.Windows.Forms.TextBox()
        Me.txtPasswordFinal = New System.Windows.Forms.TextBox()
        Me.dgvListarUsuarios = New System.Windows.Forms.DataGridView()
        Me.IdUs = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Nombre = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Dir = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Prov = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Cant = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Dist = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.email = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FNac = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.img = New System.Windows.Forms.DataGridViewImageColumn()
        Me.IdRol = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.IdEmpresa = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.txtIdUsDos = New System.Windows.Forms.TextBox()
        Me.txtIdRolDos = New System.Windows.Forms.TextBox()
        Me.txtIdEmpresaDos = New System.Windows.Forms.TextBox()
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.ToolStripBtnNuevo = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripBtnSalvar = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripBtnBuscar = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripBtnActualizar = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripBtnEliminar = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripBtnSalir = New System.Windows.Forms.ToolStripButton()
        Me.cmsEscogerFotografia = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.SeleccionarFotoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SalirToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ttpToolTip = New System.Windows.Forms.ToolTip(Me.components)
        Me.btnImagen = New System.Windows.Forms.Button()
        Me.picImgUsr = New System.Windows.Forms.PictureBox()
        Me.erProveedorError = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.Label10 = New System.Windows.Forms.Label()
        CType(Me.dgvListarUsuarios,System.ComponentModel.ISupportInitialize).BeginInit
        Me.ToolStrip1.SuspendLayout
        Me.cmsEscogerFotografia.SuspendLayout
        CType(Me.picImgUsr,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.erProveedorError,System.ComponentModel.ISupportInitialize).BeginInit
        Me.SuspendLayout
        '
        'btnListar
        '
        Me.btnListar.Location = New System.Drawing.Point(25, 420)
        Me.btnListar.Name = "btnListar"
        Me.btnListar.Size = New System.Drawing.Size(75, 33)
        Me.btnListar.TabIndex = 19
        Me.btnListar.Text = "Listar"
        Me.btnListar.UseVisualStyleBackColor = true
        Me.btnListar.Visible = false
        '
        'txtId
        '
        Me.txtId.Font = New System.Drawing.Font("Open Sans", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.txtId.Location = New System.Drawing.Point(281, 102)
        Me.txtId.Mask = "0-0000-0000"
        Me.txtId.Name = "txtId"
        Me.txtId.Size = New System.Drawing.Size(73, 22)
        Me.txtId.TabIndex = 0
        Me.ttpToolTip.SetToolTip(Me.txtId, "Ingrese la cedula")
        '
        'Label4
        '
        Me.Label4.AutoSize = true
        Me.Label4.Location = New System.Drawing.Point(367, 105)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(67, 13)
        Me.Label4.TabIndex = 17
        Me.Label4.Text = "0-0000-0000"
        '
        'txtDireccion
        '
        Me.txtDireccion.Font = New System.Drawing.Font("Open Sans", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.txtDireccion.Location = New System.Drawing.Point(281, 154)
        Me.txtDireccion.Name = "txtDireccion"
        Me.txtDireccion.Size = New System.Drawing.Size(459, 22)
        Me.txtDireccion.TabIndex = 2
        Me.ttpToolTip.SetToolTip(Me.txtDireccion, "Ingrese la direccion")
        '
        'txtNombre
        '
        Me.txtNombre.Font = New System.Drawing.Font("Open Sans", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.txtNombre.Location = New System.Drawing.Point(281, 128)
        Me.txtNombre.Name = "txtNombre"
        Me.txtNombre.Size = New System.Drawing.Size(303, 22)
        Me.txtNombre.TabIndex = 1
        Me.ttpToolTip.SetToolTip(Me.txtNombre, "Ingrese el Nombre")
        '
        'Label3
        '
        Me.Label3.AutoSize = true
        Me.Label3.Font = New System.Drawing.Font("Open Sans", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.Label3.Location = New System.Drawing.Point(210, 158)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(63, 18)
        Me.Label3.TabIndex = 14
        Me.Label3.Text = "Dirección"
        '
        'Label2
        '
        Me.Label2.AutoSize = true
        Me.Label2.Font = New System.Drawing.Font("Open Sans", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.Label2.Location = New System.Drawing.Point(218, 132)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(58, 18)
        Me.Label2.TabIndex = 13
        Me.Label2.Text = "Nombre"
        '
        'Label1
        '
        Me.Label1.AutoSize = true
        Me.Label1.Font = New System.Drawing.Font("Open Sans", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.Label1.Location = New System.Drawing.Point(257, 102)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(21, 18)
        Me.Label1.TabIndex = 12
        Me.Label1.Text = "ID"
        '
        'Label5
        '
        Me.Label5.AutoSize = true
        Me.Label5.Font = New System.Drawing.Font("Open Sans", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.Label5.Location = New System.Drawing.Point(281, 181)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(63, 18)
        Me.Label5.TabIndex = 22
        Me.Label5.Text = "Provincia"
        '
        'cboCanton
        '
        Me.cboCanton.Font = New System.Drawing.Font("Open Sans", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.cboCanton.FormattingEnabled = true
        Me.cboCanton.Location = New System.Drawing.Point(440, 203)
        Me.cboCanton.Name = "cboCanton"
        Me.cboCanton.Size = New System.Drawing.Size(144, 23)
        Me.cboCanton.TabIndex = 4
        Me.ttpToolTip.SetToolTip(Me.cboCanton, "Seleccione el Cantón")
        '
        'Label6
        '
        Me.Label6.AutoSize = true
        Me.Label6.Font = New System.Drawing.Font("Open Sans", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.Label6.Location = New System.Drawing.Point(439, 181)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(52, 18)
        Me.Label6.TabIndex = 24
        Me.Label6.Text = "Cantón"
        '
        'cboDistrito
        '
        Me.cboDistrito.Font = New System.Drawing.Font("Open Sans", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.cboDistrito.FormattingEnabled = true
        Me.cboDistrito.Location = New System.Drawing.Point(591, 203)
        Me.cboDistrito.Name = "cboDistrito"
        Me.cboDistrito.Size = New System.Drawing.Size(215, 23)
        Me.cboDistrito.TabIndex = 5
        Me.ttpToolTip.SetToolTip(Me.cboDistrito, "Seleccione el Distrito")
        '
        'Label7
        '
        Me.Label7.AutoSize = true
        Me.Label7.Font = New System.Drawing.Font("Open Sans", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.Label7.Location = New System.Drawing.Point(591, 181)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(52, 18)
        Me.Label7.TabIndex = 26
        Me.Label7.Text = "Distrito"
        '
        'cboProvincia
        '
        Me.cboProvincia.Font = New System.Drawing.Font("Open Sans", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.cboProvincia.FormattingEnabled = true
        Me.cboProvincia.Location = New System.Drawing.Point(284, 202)
        Me.cboProvincia.Name = "cboProvincia"
        Me.cboProvincia.Size = New System.Drawing.Size(150, 23)
        Me.cboProvincia.TabIndex = 3
        Me.ttpToolTip.SetToolTip(Me.cboProvincia, "Seleccione la provincia")
        '
        'Label8
        '
        Me.Label8.AutoSize = true
        Me.Label8.Font = New System.Drawing.Font("Open Sans", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.Label8.Location = New System.Drawing.Point(238, 240)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(40, 18)
        Me.Label8.TabIndex = 28
        Me.Label8.Text = "Email"
        '
        'txtEmail
        '
        Me.txtEmail.Font = New System.Drawing.Font("Open Sans", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.txtEmail.Location = New System.Drawing.Point(284, 240)
        Me.txtEmail.Name = "txtEmail"
        Me.txtEmail.Size = New System.Drawing.Size(194, 22)
        Me.txtEmail.TabIndex = 6
        Me.ttpToolTip.SetToolTip(Me.txtEmail, "Ingrese el Correo Electrónico")
        '
        'Label9
        '
        Me.Label9.AutoSize = true
        Me.Label9.Font = New System.Drawing.Font("Open Sans", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.Label9.Location = New System.Drawing.Point(200, 279)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(80, 18)
        Me.Label9.TabIndex = 30
        Me.Label9.Text = "Contraseña:"
        '
        'txtPassw
        '
        Me.txtPassw.Font = New System.Drawing.Font("Open Sans", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.txtPassw.Location = New System.Drawing.Point(284, 275)
        Me.txtPassw.Name = "txtPassw"
        Me.txtPassw.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtPassw.Size = New System.Drawing.Size(194, 22)
        Me.txtPassw.TabIndex = 7
        Me.ttpToolTip.SetToolTip(Me.txtPassw, "Ingrese la Contraseña")
        '
        'lblP2
        '
        Me.lblP2.AutoSize = true
        Me.lblP2.Font = New System.Drawing.Font("Open Sans", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.lblP2.Location = New System.Drawing.Point(484, 278)
        Me.lblP2.Name = "lblP2"
        Me.lblP2.Size = New System.Drawing.Size(137, 18)
        Me.lblP2.TabIndex = 32
        Me.lblP2.Text = "Confirmar contaseña:"
        '
        'txtPassConfirm
        '
        Me.txtPassConfirm.Font = New System.Drawing.Font("Open Sans", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.txtPassConfirm.Location = New System.Drawing.Point(617, 277)
        Me.txtPassConfirm.Name = "txtPassConfirm"
        Me.txtPassConfirm.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtPassConfirm.Size = New System.Drawing.Size(203, 22)
        Me.txtPassConfirm.TabIndex = 8
        Me.ttpToolTip.SetToolTip(Me.txtPassConfirm, "Reingrese la Contraseña")
        '
        'Label11
        '
        Me.Label11.AutoSize = true
        Me.Label11.Font = New System.Drawing.Font("Open Sans", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.Label11.Location = New System.Drawing.Point(165, 314)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(116, 18)
        Me.Label11.TabIndex = 34
        Me.Label11.Text = "Fecha nacimiento:"
        '
        'mskFechaNacimiento
        '
        Me.mskFechaNacimiento.Font = New System.Drawing.Font("Open Sans", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.mskFechaNacimiento.Location = New System.Drawing.Point(284, 310)
        Me.mskFechaNacimiento.Mask = "00/00/0000"
        Me.mskFechaNacimiento.Name = "mskFechaNacimiento"
        Me.mskFechaNacimiento.Size = New System.Drawing.Size(70, 22)
        Me.mskFechaNacimiento.TabIndex = 9
        Me.ttpToolTip.SetToolTip(Me.mskFechaNacimiento, "Ingrese la fecha de nacimiento")
        Me.mskFechaNacimiento.ValidatingType = GetType(Date)
        '
        'txtFecha
        '
        Me.txtFecha.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.txtFecha.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtFecha.Font = New System.Drawing.Font("Microsoft Sans Serif", 12!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.txtFecha.Location = New System.Drawing.Point(819, 52)
        Me.txtFecha.Name = "txtFecha"
        Me.txtFecha.Size = New System.Drawing.Size(153, 19)
        Me.txtFecha.TabIndex = 38
        '
        'Label12
        '
        Me.Label12.AutoSize = true
        Me.Label12.Font = New System.Drawing.Font("Open Sans", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.Label12.Location = New System.Drawing.Point(252, 345)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(27, 18)
        Me.Label12.TabIndex = 39
        Me.Label12.Text = "Rol"
        '
        'cboRoles
        '
        Me.cboRoles.Font = New System.Drawing.Font("Open Sans", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.cboRoles.FormattingEnabled = true
        Me.cboRoles.Location = New System.Drawing.Point(284, 342)
        Me.cboRoles.Name = "cboRoles"
        Me.cboRoles.Size = New System.Drawing.Size(170, 23)
        Me.cboRoles.TabIndex = 10
        Me.ttpToolTip.SetToolTip(Me.cboRoles, "Seleccione el Rol")
        '
        'txtIdRol
        '
        Me.txtIdRol.Location = New System.Drawing.Point(25, 497)
        Me.txtIdRol.Name = "txtIdRol"
        Me.txtIdRol.Size = New System.Drawing.Size(100, 20)
        Me.txtIdRol.TabIndex = 41
        Me.txtIdRol.Visible = false
        '
        'Label13
        '
        Me.Label13.AutoSize = true
        Me.Label13.Font = New System.Drawing.Font("Open Sans", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.Label13.Location = New System.Drawing.Point(221, 378)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(60, 18)
        Me.Label13.TabIndex = 42
        Me.Label13.Text = "Empresa"
        '
        'cboEmpresa
        '
        Me.cboEmpresa.Font = New System.Drawing.Font("Open Sans", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.cboEmpresa.FormattingEnabled = true
        Me.cboEmpresa.Location = New System.Drawing.Point(284, 375)
        Me.cboEmpresa.Name = "cboEmpresa"
        Me.cboEmpresa.Size = New System.Drawing.Size(121, 23)
        Me.cboEmpresa.TabIndex = 11
        Me.ttpToolTip.SetToolTip(Me.cboEmpresa, "Seleccione la Empresa")
        '
        'txtIdEmpresa
        '
        Me.txtIdEmpresa.Location = New System.Drawing.Point(133, 448)
        Me.txtIdEmpresa.Name = "txtIdEmpresa"
        Me.txtIdEmpresa.Size = New System.Drawing.Size(100, 20)
        Me.txtIdEmpresa.TabIndex = 44
        Me.txtIdEmpresa.Visible = false
        '
        'txtPasswordFinal
        '
        Me.txtPasswordFinal.Location = New System.Drawing.Point(115, 402)
        Me.txtPasswordFinal.Name = "txtPasswordFinal"
        Me.txtPasswordFinal.Size = New System.Drawing.Size(81, 20)
        Me.txtPasswordFinal.TabIndex = 46
        Me.txtPasswordFinal.Visible = false
        '
        'dgvListarUsuarios
        '
        Me.dgvListarUsuarios.BackgroundColor = System.Drawing.Color.White
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(192,Byte),Integer), CType(CType(255,Byte),Integer), CType(CType(192,Byte),Integer))
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.White
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvListarUsuarios.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.dgvListarUsuarios.ColumnHeadersHeight = 30
        Me.dgvListarUsuarios.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IdUs, Me.Nombre, Me.Dir, Me.Prov, Me.Cant, Me.Dist, Me.email, Me.FNac, Me.img, Me.IdRol, Me.IdEmpresa})
        Me.dgvListarUsuarios.EnableHeadersVisualStyles = false
        Me.dgvListarUsuarios.Location = New System.Drawing.Point(284, 402)
        Me.dgvListarUsuarios.Name = "dgvListarUsuarios"
        Me.dgvListarUsuarios.Size = New System.Drawing.Size(670, 225)
        Me.dgvListarUsuarios.TabIndex = 12
        '
        'IdUs
        '
        Me.IdUs.HeaderText = "ID.Usuario"
        Me.IdUs.Name = "IdUs"
        '
        'Nombre
        '
        Me.Nombre.HeaderText = "Nombre"
        Me.Nombre.Name = "Nombre"
        Me.Nombre.Width = 150
        '
        'Dir
        '
        Me.Dir.HeaderText = "Dirección"
        Me.Dir.Name = "Dir"
        Me.Dir.Width = 300
        '
        'Prov
        '
        Me.Prov.HeaderText = "Provincia"
        Me.Prov.Name = "Prov"
        '
        'Cant
        '
        Me.Cant.HeaderText = "Cantón"
        Me.Cant.Name = "Cant"
        '
        'Dist
        '
        Me.Dist.HeaderText = "Distrito"
        Me.Dist.Name = "Dist"
        '
        'email
        '
        Me.email.HeaderText = "Email"
        Me.email.Name = "email"
        Me.email.Width = 200
        '
        'FNac
        '
        Me.FNac.HeaderText = "Fecha nacimiento"
        Me.FNac.Name = "FNac"
        Me.FNac.Width = 220
        '
        'img
        '
        Me.img.HeaderText = "Foto"
        Me.img.Name = "img"
        Me.img.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.img.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        '
        'IdRol
        '
        Me.IdRol.HeaderText = "ID.Rol"
        Me.IdRol.Name = "IdRol"
        '
        'IdEmpresa
        '
        Me.IdEmpresa.HeaderText = "ID.Empresa"
        Me.IdEmpresa.Name = "IdEmpresa"
        '
        'txtIdUsDos
        '
        Me.txtIdUsDos.Location = New System.Drawing.Point(23, 458)
        Me.txtIdUsDos.Name = "txtIdUsDos"
        Me.txtIdUsDos.Size = New System.Drawing.Size(100, 20)
        Me.txtIdUsDos.TabIndex = 47
        Me.txtIdUsDos.Visible = false
        '
        'txtIdRolDos
        '
        Me.txtIdRolDos.Location = New System.Drawing.Point(25, 534)
        Me.txtIdRolDos.Name = "txtIdRolDos"
        Me.txtIdRolDos.Size = New System.Drawing.Size(100, 20)
        Me.txtIdRolDos.TabIndex = 48
        Me.txtIdRolDos.Visible = false
        '
        'txtIdEmpresaDos
        '
        Me.txtIdEmpresaDos.Location = New System.Drawing.Point(133, 474)
        Me.txtIdEmpresaDos.Name = "txtIdEmpresaDos"
        Me.txtIdEmpresaDos.Size = New System.Drawing.Size(100, 20)
        Me.txtIdEmpresaDos.TabIndex = 49
        Me.txtIdEmpresaDos.Visible = false
        '
        'ToolStrip1
        '
        Me.ToolStrip1.BackColor = System.Drawing.Color.White
        Me.ToolStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripBtnNuevo, Me.ToolStripBtnSalvar, Me.ToolStripBtnBuscar, Me.ToolStripBtnActualizar, Me.ToolStripBtnEliminar, Me.ToolStripBtnSalir})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.System
        Me.ToolStrip1.Size = New System.Drawing.Size(1005, 71)
        Me.ToolStrip1.TabIndex = 50
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'ToolStripBtnNuevo
        '
        Me.ToolStripBtnNuevo.Font = New System.Drawing.Font("Open Sans", 9!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.ToolStripBtnNuevo.Image = CType(resources.GetObject("ToolStripBtnNuevo.Image"),System.Drawing.Image)
        Me.ToolStripBtnNuevo.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.ToolStripBtnNuevo.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripBtnNuevo.Name = "ToolStripBtnNuevo"
        Me.ToolStripBtnNuevo.Size = New System.Drawing.Size(112, 68)
        Me.ToolStripBtnNuevo.Text = "Nuevo"
        '
        'ToolStripBtnSalvar
        '
        Me.ToolStripBtnSalvar.Font = New System.Drawing.Font("Open Sans", 9!)
        Me.ToolStripBtnSalvar.Image = CType(resources.GetObject("ToolStripBtnSalvar.Image"),System.Drawing.Image)
        Me.ToolStripBtnSalvar.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.ToolStripBtnSalvar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripBtnSalvar.Name = "ToolStripBtnSalvar"
        Me.ToolStripBtnSalvar.Size = New System.Drawing.Size(123, 68)
        Me.ToolStripBtnSalvar.Text = "Guardar"
        '
        'ToolStripBtnBuscar
        '
        Me.ToolStripBtnBuscar.Font = New System.Drawing.Font("Open Sans", 9!)
        Me.ToolStripBtnBuscar.Image = CType(resources.GetObject("ToolStripBtnBuscar.Image"),System.Drawing.Image)
        Me.ToolStripBtnBuscar.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.ToolStripBtnBuscar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripBtnBuscar.Name = "ToolStripBtnBuscar"
        Me.ToolStripBtnBuscar.Size = New System.Drawing.Size(115, 68)
        Me.ToolStripBtnBuscar.Text = "Buscar"
        '
        'ToolStripBtnActualizar
        '
        Me.ToolStripBtnActualizar.Font = New System.Drawing.Font("Open Sans", 9!)
        Me.ToolStripBtnActualizar.Image = CType(resources.GetObject("ToolStripBtnActualizar.Image"),System.Drawing.Image)
        Me.ToolStripBtnActualizar.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.ToolStripBtnActualizar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripBtnActualizar.Name = "ToolStripBtnActualizar"
        Me.ToolStripBtnActualizar.Size = New System.Drawing.Size(132, 68)
        Me.ToolStripBtnActualizar.Text = "Actualizar"
        Me.ToolStripBtnActualizar.Visible = false
        '
        'ToolStripBtnEliminar
        '
        Me.ToolStripBtnEliminar.Font = New System.Drawing.Font("Open Sans", 9!)
        Me.ToolStripBtnEliminar.Image = CType(resources.GetObject("ToolStripBtnEliminar.Image"),System.Drawing.Image)
        Me.ToolStripBtnEliminar.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.ToolStripBtnEliminar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripBtnEliminar.Name = "ToolStripBtnEliminar"
        Me.ToolStripBtnEliminar.Size = New System.Drawing.Size(122, 68)
        Me.ToolStripBtnEliminar.Text = "Eliminar"
        '
        'ToolStripBtnSalir
        '
        Me.ToolStripBtnSalir.Font = New System.Drawing.Font("Open Sans", 9!)
        Me.ToolStripBtnSalir.Image = CType(resources.GetObject("ToolStripBtnSalir.Image"),System.Drawing.Image)
        Me.ToolStripBtnSalir.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.ToolStripBtnSalir.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripBtnSalir.Name = "ToolStripBtnSalir"
        Me.ToolStripBtnSalir.Size = New System.Drawing.Size(101, 68)
        Me.ToolStripBtnSalir.Text = "Salir"
        Me.ToolStripBtnSalir.Visible = false
        '
        'cmsEscogerFotografia
        '
        Me.cmsEscogerFotografia.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.SeleccionarFotoToolStripMenuItem, Me.SalirToolStripMenuItem})
        Me.cmsEscogerFotografia.Name = "cmsEscogerFotografia"
        Me.cmsEscogerFotografia.Size = New System.Drawing.Size(162, 48)
        '
        'SeleccionarFotoToolStripMenuItem
        '
        Me.SeleccionarFotoToolStripMenuItem.Name = "SeleccionarFotoToolStripMenuItem"
        Me.SeleccionarFotoToolStripMenuItem.Size = New System.Drawing.Size(161, 22)
        Me.SeleccionarFotoToolStripMenuItem.Text = "Seleccionar Foto"
        '
        'SalirToolStripMenuItem
        '
        Me.SalirToolStripMenuItem.Name = "SalirToolStripMenuItem"
        Me.SalirToolStripMenuItem.Size = New System.Drawing.Size(161, 22)
        Me.SalirToolStripMenuItem.Text = "Salir"
        '
        'ttpToolTip
        '
        Me.ttpToolTip.AutoPopDelay = 5000
        Me.ttpToolTip.InitialDelay = 100
        Me.ttpToolTip.IsBalloon = true
        Me.ttpToolTip.ReshowDelay = 100
        Me.ttpToolTip.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info
        Me.ttpToolTip.ToolTipTitle = "Atencion"
        '
        'btnImagen
        '
        Me.btnImagen.Font = New System.Drawing.Font("Open Sans", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.btnImagen.Image = CType(resources.GetObject("btnImagen.Image"),System.Drawing.Image)
        Me.btnImagen.Location = New System.Drawing.Point(841, 232)
        Me.btnImagen.Name = "btnImagen"
        Me.btnImagen.Size = New System.Drawing.Size(113, 100)
        Me.btnImagen.TabIndex = 19
        Me.btnImagen.Text = "Seleccionar imagen"
        Me.btnImagen.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.ttpToolTip.SetToolTip(Me.btnImagen, "Seleccionar fotografia")
        Me.btnImagen.UseVisualStyleBackColor = true
        '
        'picImgUsr
        '
        Me.picImgUsr.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.picImgUsr.ContextMenuStrip = Me.cmsEscogerFotografia
        Me.picImgUsr.Location = New System.Drawing.Point(820, 75)
        Me.picImgUsr.Name = "picImgUsr"
        Me.picImgUsr.Size = New System.Drawing.Size(153, 151)
        Me.picImgUsr.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picImgUsr.TabIndex = 36
        Me.picImgUsr.TabStop = false
        Me.ttpToolTip.SetToolTip(Me.picImgUsr, "clic derecho para seleccionar imagen")
        '
        'erProveedorError
        '
        Me.erProveedorError.ContainerControl = Me
        '
        'Label10
        '
        Me.Label10.AutoSize = true
        Me.Label10.Font = New System.Drawing.Font("Open Sans", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.Label10.ForeColor = System.Drawing.SystemColors.ButtonShadow
        Me.Label10.Location = New System.Drawing.Point(277, 66)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(261, 26)
        Me.Label10.TabIndex = 51
        Me.Label10.Text = "Mantenimiento de usuarios"
        '
        'Users
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6!, 13!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1005, 650)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Controls.Add(Me.txtIdEmpresaDos)
        Me.Controls.Add(Me.txtIdRolDos)
        Me.Controls.Add(Me.txtIdUsDos)
        Me.Controls.Add(Me.dgvListarUsuarios)
        Me.Controls.Add(Me.txtPasswordFinal)
        Me.Controls.Add(Me.txtIdEmpresa)
        Me.Controls.Add(Me.cboEmpresa)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.txtIdRol)
        Me.Controls.Add(Me.cboRoles)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.txtFecha)
        Me.Controls.Add(Me.btnImagen)
        Me.Controls.Add(Me.picImgUsr)
        Me.Controls.Add(Me.mskFechaNacimiento)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.txtPassConfirm)
        Me.Controls.Add(Me.lblP2)
        Me.Controls.Add(Me.txtPassw)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.txtEmail)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.cboProvincia)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.cboDistrito)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.cboCanton)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.btnListar)
        Me.Controls.Add(Me.txtId)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txtDireccion)
        Me.Controls.Add(Me.txtNombre)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Users"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.dgvListarUsuarios,System.ComponentModel.ISupportInitialize).EndInit
        Me.ToolStrip1.ResumeLayout(false)
        Me.ToolStrip1.PerformLayout
        Me.cmsEscogerFotografia.ResumeLayout(false)
        CType(Me.picImgUsr,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.erProveedorError,System.ComponentModel.ISupportInitialize).EndInit
        Me.ResumeLayout(false)
        Me.PerformLayout

End Sub
    Friend WithEvents btnListar As Button
    Friend WithEvents txtId As MaskedTextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents txtDireccion As TextBox
    Friend WithEvents txtNombre As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents cboCanton As ComboBox
    Friend WithEvents Label6 As Label
    Friend WithEvents cboDistrito As ComboBox
    Friend WithEvents Label7 As Label
    Friend WithEvents cboProvincia As ComboBox
    Friend WithEvents Label8 As Label
    Friend WithEvents txtEmail As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents txtPassw As TextBox
    Friend WithEvents lblP2 As Label
    Friend WithEvents txtPassConfirm As TextBox
    Friend WithEvents Label11 As Label
    Friend WithEvents mskFechaNacimiento As MaskedTextBox
    Friend WithEvents picImgUsr As PictureBox
    Friend WithEvents btnImagen As Button
    Friend WithEvents txtFecha As TextBox
    Friend WithEvents Label12 As Label
    Friend WithEvents cboRoles As ComboBox
    Friend WithEvents txtIdRol As TextBox
    Friend WithEvents Label13 As Label
    Friend WithEvents cboEmpresa As ComboBox
    Friend WithEvents txtIdEmpresa As TextBox
    Friend WithEvents txtPasswordFinal As TextBox
    Friend WithEvents dgvListarUsuarios As DataGridView
    Friend WithEvents txtIdUsDos As TextBox
    Friend WithEvents txtIdRolDos As TextBox
    Friend WithEvents txtIdEmpresaDos As TextBox
    Friend WithEvents ToolStrip1 As ToolStrip
    Friend WithEvents ToolStripBtnNuevo As ToolStripButton
    Friend WithEvents ToolStripBtnSalvar As ToolStripButton
    Friend WithEvents ttpToolTip As ToolTip
    Friend WithEvents erProveedorError As ErrorProvider
    Friend WithEvents cmsEscogerFotografia As ContextMenuStrip
    Friend WithEvents SeleccionarFotoToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SalirToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToolStripBtnBuscar As ToolStripButton
    Friend WithEvents ToolStripBtnActualizar As ToolStripButton
    Friend WithEvents ToolStripBtnEliminar As ToolStripButton
    Friend WithEvents ToolStripBtnSalir As ToolStripButton
    Friend WithEvents Label10 As Label
    Friend WithEvents IdUs As DataGridViewTextBoxColumn
    Friend WithEvents Nombre As DataGridViewTextBoxColumn
    Friend WithEvents Dir As DataGridViewTextBoxColumn
    Friend WithEvents Prov As DataGridViewTextBoxColumn
    Friend WithEvents Cant As DataGridViewTextBoxColumn
    Friend WithEvents Dist As DataGridViewTextBoxColumn
    Friend WithEvents email As DataGridViewTextBoxColumn
    Friend WithEvents FNac As DataGridViewTextBoxColumn
    Friend WithEvents img As DataGridViewImageColumn
    Friend WithEvents IdRol As DataGridViewTextBoxColumn
    Friend WithEvents IdEmpresa As DataGridViewTextBoxColumn
End Class
