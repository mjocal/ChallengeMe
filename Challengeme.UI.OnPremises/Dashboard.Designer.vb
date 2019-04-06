<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmDashBoard
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmDashBoard))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.lblNombreRol = New System.Windows.Forms.TextBox()
        Me.txtRol = New System.Windows.Forms.TextBox()
        Me.cboCargarAreas = New System.Windows.Forms.ComboBox()
        Me.btnPerfil = New System.Windows.Forms.Button()
        Me.txtUSUARIO = New System.Windows.Forms.TextBox()
        Me.TrackBar1 = New System.Windows.Forms.TrackBar()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.txtConfiguracion = New System.Windows.Forms.TextBox()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.btn = New System.Windows.Forms.Button()
        Me.mnsConfiguracion = New System.Windows.Forms.MenuStrip()
        Me.ToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.MiCuentaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CambiarContraseñaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AgregarFotografíaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ContextMenuStrip1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.ttpToolTip = New System.Windows.Forms.ToolTip(Me.components)
        Me.btnConfiguracion = New System.Windows.Forms.Button()
        Me.btnCerrar = New System.Windows.Forms.Button()
        Me.btnMenuPermisos = New System.Windows.Forms.Button()
        Me.btnEmpresas = New System.Windows.Forms.Button()
        Me.btnDashboard = New System.Windows.Forms.Button()
        Me.btnRutas = New System.Windows.Forms.Button()
        Me.btnCategoria = New System.Windows.Forms.Button()
        Me.btnInscripcion = New System.Windows.Forms.Button()
        Me.btnRanking = New System.Windows.Forms.Button()
        Me.btnPremios = New System.Windows.Forms.Button()
        Me.btnPatrocinadores = New System.Windows.Forms.Button()
        Me.btnEventos = New System.Windows.Forms.Button()
        Me.btnActividades = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.btnSalir = New System.Windows.Forms.Button()
        Me.btnProductos = New System.Windows.Forms.Button()
        Me.HolaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ActualizarFotoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CambiarContraseñaToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.CerrarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Panel1.SuspendLayout
        CType(Me.TrackBar1,System.ComponentModel.ISupportInitialize).BeginInit
        Me.Panel2.SuspendLayout
        Me.Panel3.SuspendLayout
        Me.Panel4.SuspendLayout
        Me.mnsConfiguracion.SuspendLayout
        Me.ContextMenuStrip1.SuspendLayout
        CType(Me.PictureBox1,System.ComponentModel.ISupportInitialize).BeginInit
        Me.SuspendLayout
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.DodgerBlue
        Me.Panel1.Controls.Add(Me.btnRutas)
        Me.Panel1.Controls.Add(Me.lblNombreRol)
        Me.Panel1.Controls.Add(Me.btnCategoria)
        Me.Panel1.Controls.Add(Me.btnInscripcion)
        Me.Panel1.Controls.Add(Me.btnRanking)
        Me.Panel1.Controls.Add(Me.btnPremios)
        Me.Panel1.Controls.Add(Me.btnPatrocinadores)
        Me.Panel1.Controls.Add(Me.btnEventos)
        Me.Panel1.Controls.Add(Me.btnActividades)
        Me.Panel1.Controls.Add(Me.txtRol)
        Me.Panel1.Controls.Add(Me.cboCargarAreas)
        Me.Panel1.Controls.Add(Me.btnPerfil)
        Me.Panel1.Controls.Add(Me.txtUSUARIO)
        Me.Panel1.Controls.Add(Me.PictureBox1)
        Me.Panel1.Controls.Add(Me.btnSalir)
        Me.Panel1.Controls.Add(Me.btnProductos)
        Me.Panel1.Controls.Add(Me.TrackBar1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(253, 756)
        Me.Panel1.TabIndex = 5
        '
        'lblNombreRol
        '
        Me.lblNombreRol.BackColor = System.Drawing.Color.DodgerBlue
        Me.lblNombreRol.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.lblNombreRol.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.lblNombreRol.ForeColor = System.Drawing.Color.White
        Me.lblNombreRol.Location = New System.Drawing.Point(34, 149)
        Me.lblNombreRol.Name = "lblNombreRol"
        Me.lblNombreRol.Size = New System.Drawing.Size(192, 15)
        Me.lblNombreRol.TabIndex = 138
        Me.lblNombreRol.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.ttpToolTip.SetToolTip(Me.lblNombreRol, "Rol de la cuenta")
        '
        'txtRol
        '
        Me.txtRol.Location = New System.Drawing.Point(3, 12)
        Me.txtRol.Name = "txtRol"
        Me.txtRol.Size = New System.Drawing.Size(26, 20)
        Me.txtRol.TabIndex = 130
        Me.txtRol.Visible = false
        '
        'cboCargarAreas
        '
        Me.cboCargarAreas.FormattingEnabled = true
        Me.cboCargarAreas.Location = New System.Drawing.Point(6, 38)
        Me.cboCargarAreas.Name = "cboCargarAreas"
        Me.cboCargarAreas.Size = New System.Drawing.Size(23, 21)
        Me.cboCargarAreas.TabIndex = 131
        Me.cboCargarAreas.Visible = false
        '
        'btnPerfil
        '
        Me.btnPerfil.BackColor = System.Drawing.SystemColors.MenuHighlight
        Me.btnPerfil.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnPerfil.FlatAppearance.BorderColor = System.Drawing.Color.DodgerBlue
        Me.btnPerfil.FlatAppearance.MouseOverBackColor = System.Drawing.Color.MidnightBlue
        Me.btnPerfil.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnPerfil.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.btnPerfil.ForeColor = System.Drawing.Color.White
        Me.btnPerfil.Location = New System.Drawing.Point(-3, 167)
        Me.btnPerfil.Name = "btnPerfil"
        Me.btnPerfil.Size = New System.Drawing.Size(260, 53)
        Me.btnPerfil.TabIndex = 117
        Me.btnPerfil.Text = "Actualizar Perfil"
        Me.ttpToolTip.SetToolTip(Me.btnPerfil, "Ver opciones de configuración de la cuenta")
        Me.btnPerfil.UseVisualStyleBackColor = false
        '
        'txtUSUARIO
        '
        Me.txtUSUARIO.BackColor = System.Drawing.Color.DodgerBlue
        Me.txtUSUARIO.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtUSUARIO.Enabled = false
        Me.txtUSUARIO.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.txtUSUARIO.ForeColor = System.Drawing.Color.White
        Me.txtUSUARIO.Location = New System.Drawing.Point(34, 126)
        Me.txtUSUARIO.Name = "txtUSUARIO"
        Me.txtUSUARIO.Size = New System.Drawing.Size(192, 17)
        Me.txtUSUARIO.TabIndex = 128
        Me.txtUSUARIO.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.ttpToolTip.SetToolTip(Me.txtUSUARIO, "Login de la cuenta")
        '
        'TrackBar1
        '
        Me.TrackBar1.AccessibleRole = System.Windows.Forms.AccessibleRole.None
        Me.TrackBar1.Enabled = false
        Me.TrackBar1.Location = New System.Drawing.Point(-21, 211)
        Me.TrackBar1.Name = "TrackBar1"
        Me.TrackBar1.Size = New System.Drawing.Size(288, 45)
        Me.TrackBar1.TabIndex = 129
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.White
        Me.Panel2.Controls.Add(Me.txtConfiguracion)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel2.Location = New System.Drawing.Point(253, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(618, 756)
        Me.Panel2.TabIndex = 6
        '
        'txtConfiguracion
        '
        Me.txtConfiguracion.Location = New System.Drawing.Point(-6, 77)
        Me.txtConfiguracion.Name = "txtConfiguracion"
        Me.txtConfiguracion.Size = New System.Drawing.Size(20, 20)
        Me.txtConfiguracion.TabIndex = 0
        Me.txtConfiguracion.Visible = false
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.Gainsboro
        Me.Panel3.Controls.Add(Me.Panel4)
        Me.Panel3.Controls.Add(Me.btnMenuPermisos)
        Me.Panel3.Controls.Add(Me.btnEmpresas)
        Me.Panel3.Controls.Add(Me.btnDashboard)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel3.Location = New System.Drawing.Point(253, 0)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(618, 71)
        Me.Panel3.TabIndex = 8
        '
        'Panel4
        '
        Me.Panel4.BackColor = System.Drawing.Color.Gainsboro
        Me.Panel4.Controls.Add(Me.btn)
        Me.Panel4.Controls.Add(Me.mnsConfiguracion)
        Me.Panel4.Controls.Add(Me.btnConfiguracion)
        Me.Panel4.Controls.Add(Me.btnCerrar)
        Me.Panel4.Dock = System.Windows.Forms.DockStyle.Right
        Me.Panel4.Location = New System.Drawing.Point(496, 0)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(122, 71)
        Me.Panel4.TabIndex = 141
        '
        'btn
        '
        Me.btn.FlatAppearance.BorderColor = System.Drawing.Color.Gainsboro
        Me.btn.Location = New System.Drawing.Point(7, 42)
        Me.btn.Name = "btn"
        Me.btn.Size = New System.Drawing.Size(33, 15)
        Me.btn.TabIndex = 144
        Me.btn.UseVisualStyleBackColor = true
        Me.btn.Visible = false
        '
        'mnsConfiguracion
        '
        Me.mnsConfiguracion.Dock = System.Windows.Forms.DockStyle.None
        Me.mnsConfiguracion.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripMenuItem1})
        Me.mnsConfiguracion.Location = New System.Drawing.Point(3, 38)
        Me.mnsConfiguracion.Name = "mnsConfiguracion"
        Me.mnsConfiguracion.Size = New System.Drawing.Size(30, 24)
        Me.mnsConfiguracion.TabIndex = 143
        Me.mnsConfiguracion.Visible = false
        '
        'ToolStripMenuItem1
        '
        Me.ToolStripMenuItem1.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.MiCuentaToolStripMenuItem, Me.CambiarContraseñaToolStripMenuItem, Me.AgregarFotografíaToolStripMenuItem})
        Me.ToolStripMenuItem1.Name = "ToolStripMenuItem1"
        Me.ToolStripMenuItem1.Size = New System.Drawing.Size(22, 20)
        Me.ToolStripMenuItem1.Text = "."
        '
        'MiCuentaToolStripMenuItem
        '
        Me.MiCuentaToolStripMenuItem.Name = "MiCuentaToolStripMenuItem"
        Me.MiCuentaToolStripMenuItem.Size = New System.Drawing.Size(211, 22)
        Me.MiCuentaToolStripMenuItem.Text = "Información de mi cuenta"
        '
        'CambiarContraseñaToolStripMenuItem
        '
        Me.CambiarContraseñaToolStripMenuItem.Name = "CambiarContraseñaToolStripMenuItem"
        Me.CambiarContraseñaToolStripMenuItem.Size = New System.Drawing.Size(211, 22)
        Me.CambiarContraseñaToolStripMenuItem.Text = "Cambiar contraseña"
        '
        'AgregarFotografíaToolStripMenuItem
        '
        Me.AgregarFotografíaToolStripMenuItem.Name = "AgregarFotografíaToolStripMenuItem"
        Me.AgregarFotografíaToolStripMenuItem.Size = New System.Drawing.Size(211, 22)
        Me.AgregarFotografíaToolStripMenuItem.Text = "Agregar fotografía"
        '
        'ContextMenuStrip1
        '
        Me.ContextMenuStrip1.AllowDrop = true
        Me.ContextMenuStrip1.DataBindings.Add(New System.Windows.Forms.Binding("Dock", Global.Challengeme.UI.OnPremises.My.MySettings.Default, "cms", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.ContextMenuStrip1.Dock = Global.Challengeme.UI.OnPremises.My.MySettings.Default.cms
        Me.ContextMenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.HolaToolStripMenuItem, Me.ActualizarFotoToolStripMenuItem, Me.CambiarContraseñaToolStripMenuItem1, Me.CerrarToolStripMenuItem})
        Me.ContextMenuStrip1.Name = "ContextMenuStrip1"
        Me.ContextMenuStrip1.Size = New System.Drawing.Size(274, 284)
        '
        'ttpToolTip
        '
        Me.ttpToolTip.AutoPopDelay = 5000
        Me.ttpToolTip.InitialDelay = 100
        Me.ttpToolTip.IsBalloon = true
        Me.ttpToolTip.ReshowDelay = 100
        Me.ttpToolTip.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info
        Me.ttpToolTip.ToolTipTitle = "Atención"
        '
        'btnConfiguracion
        '
        Me.btnConfiguracion.ContextMenuStrip = Me.ContextMenuStrip1
        Me.btnConfiguracion.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnConfiguracion.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkGray
        Me.btnConfiguracion.Image = Global.Challengeme.UI.OnPremises.My.Resources.Resources.configuracion1
        Me.btnConfiguracion.Location = New System.Drawing.Point(3, 10)
        Me.btnConfiguracion.Name = "btnConfiguracion"
        Me.btnConfiguracion.Size = New System.Drawing.Size(39, 40)
        Me.btnConfiguracion.TabIndex = 0
        Me.btnConfiguracion.UseVisualStyleBackColor = true
        '
        'btnCerrar
        '
        Me.btnCerrar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnCerrar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkGray
        Me.btnCerrar.ForeColor = System.Drawing.Color.White
        Me.btnCerrar.Image = Global.Challengeme.UI.OnPremises.My.Resources.Resources.X2
        Me.btnCerrar.Location = New System.Drawing.Point(72, 11)
        Me.btnCerrar.Name = "btnCerrar"
        Me.btnCerrar.Size = New System.Drawing.Size(39, 40)
        Me.btnCerrar.TabIndex = 142
        Me.ttpToolTip.SetToolTip(Me.btnCerrar, "Salir del programa")
        Me.btnCerrar.UseVisualStyleBackColor = true
        '
        'btnMenuPermisos
        '
        Me.btnMenuPermisos.BackColor = System.Drawing.Color.Gainsboro
        Me.btnMenuPermisos.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnMenuPermisos.FlatAppearance.BorderColor = System.Drawing.Color.Gainsboro
        Me.btnMenuPermisos.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkGray
        Me.btnMenuPermisos.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnMenuPermisos.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.btnMenuPermisos.ForeColor = System.Drawing.Color.White
        Me.btnMenuPermisos.Image = Global.Challengeme.UI.OnPremises.My.Resources.Resources.icons8_User_Group_Man_Man_641
        Me.btnMenuPermisos.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnMenuPermisos.Location = New System.Drawing.Point(310, 5)
        Me.btnMenuPermisos.Name = "btnMenuPermisos"
        Me.btnMenuPermisos.Padding = New System.Windows.Forms.Padding(0, 5, 0, 5)
        Me.btnMenuPermisos.Size = New System.Drawing.Size(185, 59)
        Me.btnMenuPermisos.TabIndex = 139
        Me.btnMenuPermisos.Text = "Crear Usuarios"
        Me.btnMenuPermisos.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.ttpToolTip.SetToolTip(Me.btnMenuPermisos, "Creación de permisos,roles y usuarios")
        Me.btnMenuPermisos.UseVisualStyleBackColor = false
        '
        'btnEmpresas
        '
        Me.btnEmpresas.BackColor = System.Drawing.Color.Gainsboro
        Me.btnEmpresas.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnEmpresas.Enabled = false
        Me.btnEmpresas.FlatAppearance.BorderColor = System.Drawing.Color.Gainsboro
        Me.btnEmpresas.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkGray
        Me.btnEmpresas.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnEmpresas.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.btnEmpresas.ForeColor = System.Drawing.Color.White
        Me.btnEmpresas.Image = Global.Challengeme.UI.OnPremises.My.Resources.Resources.icons8_Building_64
        Me.btnEmpresas.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnEmpresas.Location = New System.Drawing.Point(157, 5)
        Me.btnEmpresas.Name = "btnEmpresas"
        Me.btnEmpresas.Padding = New System.Windows.Forms.Padding(0, 5, 0, 5)
        Me.btnEmpresas.Size = New System.Drawing.Size(155, 59)
        Me.btnEmpresas.TabIndex = 138
        Me.btnEmpresas.Text = "Empresas"
        Me.btnEmpresas.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.ttpToolTip.SetToolTip(Me.btnEmpresas, "Creación de empresas")
        Me.btnEmpresas.UseVisualStyleBackColor = false
        '
        'btnDashboard
        '
        Me.btnDashboard.BackColor = System.Drawing.Color.Gainsboro
        Me.btnDashboard.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnDashboard.FlatAppearance.BorderColor = System.Drawing.Color.Gainsboro
        Me.btnDashboard.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkGray
        Me.btnDashboard.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnDashboard.Font = New System.Drawing.Font("Microsoft Sans Serif", 12!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.btnDashboard.ForeColor = System.Drawing.Color.White
        Me.btnDashboard.Image = Global.Challengeme.UI.OnPremises.My.Resources.Resources.icons8_Dashboard_64
        Me.btnDashboard.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnDashboard.Location = New System.Drawing.Point(4, 4)
        Me.btnDashboard.Name = "btnDashboard"
        Me.btnDashboard.Size = New System.Drawing.Size(155, 59)
        Me.btnDashboard.TabIndex = 137
        Me.btnDashboard.Text = "Dashboard"
        Me.btnDashboard.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.ttpToolTip.SetToolTip(Me.btnDashboard, "Dashboard de Administrador")
        Me.btnDashboard.UseVisualStyleBackColor = false
        '
        'btnRutas
        '
        Me.btnRutas.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnRutas.Enabled = false
        Me.btnRutas.FlatAppearance.BorderColor = System.Drawing.Color.DodgerBlue
        Me.btnRutas.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Navy
        Me.btnRutas.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnRutas.Font = New System.Drawing.Font("Microsoft Sans Serif", 12!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.btnRutas.ForeColor = System.Drawing.Color.White
        Me.btnRutas.Image = Global.Challengeme.UI.OnPremises.My.Resources.Resources.icons8_Rutas_64
        Me.btnRutas.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnRutas.Location = New System.Drawing.Point(-8, 649)
        Me.btnRutas.Name = "btnRutas"
        Me.btnRutas.Size = New System.Drawing.Size(265, 53)
        Me.btnRutas.TabIndex = 139
        Me.btnRutas.Text = "Rutas"
        Me.btnRutas.UseVisualStyleBackColor = true
        '
        'btnCategoria
        '
        Me.btnCategoria.BackColor = System.Drawing.Color.DodgerBlue
        Me.btnCategoria.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnCategoria.Enabled = false
        Me.btnCategoria.FlatAppearance.BorderColor = System.Drawing.Color.DodgerBlue
        Me.btnCategoria.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Navy
        Me.btnCategoria.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCategoria.Font = New System.Drawing.Font("Microsoft Sans Serif", 12!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.btnCategoria.ForeColor = System.Drawing.Color.White
        Me.btnCategoria.Image = Global.Challengeme.UI.OnPremises.My.Resources.Resources.icons8_News_Feed_64
        Me.btnCategoria.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnCategoria.Location = New System.Drawing.Point(-3, 330)
        Me.btnCategoria.Name = "btnCategoria"
        Me.btnCategoria.Size = New System.Drawing.Size(256, 53)
        Me.btnCategoria.TabIndex = 10
        Me.btnCategoria.Text = "Categorías"
        Me.ttpToolTip.SetToolTip(Me.btnCategoria, "Creación de categorías")
        Me.btnCategoria.UseVisualStyleBackColor = false
        '
        'btnInscripcion
        '
        Me.btnInscripcion.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnInscripcion.Enabled = false
        Me.btnInscripcion.FlatAppearance.BorderColor = System.Drawing.Color.DodgerBlue
        Me.btnInscripcion.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Navy
        Me.btnInscripcion.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnInscripcion.Font = New System.Drawing.Font("Microsoft Sans Serif", 12!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.btnInscripcion.ForeColor = System.Drawing.Color.White
        Me.btnInscripcion.Image = Global.Challengeme.UI.OnPremises.My.Resources.Resources.icons8_Registration_64
        Me.btnInscripcion.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnInscripcion.Location = New System.Drawing.Point(-3, 593)
        Me.btnInscripcion.Name = "btnInscripcion"
        Me.btnInscripcion.Size = New System.Drawing.Size(256, 53)
        Me.btnInscripcion.TabIndex = 137
        Me.btnInscripcion.Text = "Inscripciones"
        Me.ttpToolTip.SetToolTip(Me.btnInscripcion, "Incripciones a eventos")
        Me.btnInscripcion.UseVisualStyleBackColor = true
        '
        'btnRanking
        '
        Me.btnRanking.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnRanking.Enabled = false
        Me.btnRanking.FlatAppearance.BorderColor = System.Drawing.Color.DodgerBlue
        Me.btnRanking.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Navy
        Me.btnRanking.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnRanking.Font = New System.Drawing.Font("Microsoft Sans Serif", 12!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.btnRanking.ForeColor = System.Drawing.Color.White
        Me.btnRanking.Image = Global.Challengeme.UI.OnPremises.My.Resources.Resources.icons8_Leaderboard_64
        Me.btnRanking.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnRanking.Location = New System.Drawing.Point(-2, 542)
        Me.btnRanking.Name = "btnRanking"
        Me.btnRanking.Size = New System.Drawing.Size(256, 53)
        Me.btnRanking.TabIndex = 135
        Me.btnRanking.Text = "Ranking"
        Me.ttpToolTip.SetToolTip(Me.btnRanking, "Ingreso de las posiciones de los participante en los eventos")
        Me.btnRanking.UseVisualStyleBackColor = true
        '
        'btnPremios
        '
        Me.btnPremios.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnPremios.Enabled = false
        Me.btnPremios.FlatAppearance.BorderColor = System.Drawing.Color.DodgerBlue
        Me.btnPremios.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Navy
        Me.btnPremios.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnPremios.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.btnPremios.ForeColor = System.Drawing.Color.White
        Me.btnPremios.Image = Global.Challengeme.UI.OnPremises.My.Resources.Resources.icons8_Medal_First_Place_64
        Me.btnPremios.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnPremios.Location = New System.Drawing.Point(-2, 490)
        Me.btnPremios.Name = "btnPremios"
        Me.btnPremios.Size = New System.Drawing.Size(256, 53)
        Me.btnPremios.TabIndex = 134
        Me.btnPremios.Text = "Premios"
        Me.ttpToolTip.SetToolTip(Me.btnPremios, "Creación de premios")
        Me.btnPremios.UseVisualStyleBackColor = true
        '
        'btnPatrocinadores
        '
        Me.btnPatrocinadores.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnPatrocinadores.Enabled = false
        Me.btnPatrocinadores.FlatAppearance.BorderColor = System.Drawing.Color.DodgerBlue
        Me.btnPatrocinadores.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Navy
        Me.btnPatrocinadores.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnPatrocinadores.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.btnPatrocinadores.ForeColor = System.Drawing.Color.White
        Me.btnPatrocinadores.Image = Global.Challengeme.UI.OnPremises.My.Resources.Resources.icons8_Handshake_64
        Me.btnPatrocinadores.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnPatrocinadores.Location = New System.Drawing.Point(-3, 383)
        Me.btnPatrocinadores.Name = "btnPatrocinadores"
        Me.btnPatrocinadores.Size = New System.Drawing.Size(256, 53)
        Me.btnPatrocinadores.TabIndex = 133
        Me.btnPatrocinadores.Text = "                    Patrocinadores"
        Me.btnPatrocinadores.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.ttpToolTip.SetToolTip(Me.btnPatrocinadores, "Creación de patrocinadores")
        Me.btnPatrocinadores.UseVisualStyleBackColor = true
        '
        'btnEventos
        '
        Me.btnEventos.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnEventos.Enabled = false
        Me.btnEventos.FlatAppearance.BorderColor = System.Drawing.Color.DodgerBlue
        Me.btnEventos.FlatAppearance.MouseOverBackColor = System.Drawing.Color.MidnightBlue
        Me.btnEventos.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnEventos.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.btnEventos.ForeColor = System.Drawing.Color.White
        Me.btnEventos.Image = Global.Challengeme.UI.OnPremises.My.Resources.Resources.icons8_Running_64
        Me.btnEventos.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnEventos.Location = New System.Drawing.Point(-2, 277)
        Me.btnEventos.Name = "btnEventos"
        Me.btnEventos.Padding = New System.Windows.Forms.Padding(0, 5, 0, 5)
        Me.btnEventos.Size = New System.Drawing.Size(256, 53)
        Me.btnEventos.TabIndex = 120
        Me.btnEventos.Text = "                     Eventos                             "
        Me.btnEventos.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.ttpToolTip.SetToolTip(Me.btnEventos, "Creación de eventos")
        Me.btnEventos.UseVisualStyleBackColor = true
        '
        'btnActividades
        '
        Me.btnActividades.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnActividades.Enabled = false
        Me.btnActividades.FlatAppearance.BorderColor = System.Drawing.Color.DodgerBlue
        Me.btnActividades.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Navy
        Me.btnActividades.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnActividades.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.btnActividades.ForeColor = System.Drawing.Color.White
        Me.btnActividades.Image = Global.Challengeme.UI.OnPremises.My.Resources.Resources.icons8_Soccer_64
        Me.btnActividades.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnActividades.Location = New System.Drawing.Point(-3, 224)
        Me.btnActividades.Name = "btnActividades"
        Me.btnActividades.Size = New System.Drawing.Size(256, 53)
        Me.btnActividades.TabIndex = 132
        Me.btnActividades.Text = "Actividades"
        Me.ttpToolTip.SetToolTip(Me.btnActividades, "Creación de actividades")
        Me.btnActividades.UseVisualStyleBackColor = true
        '
        'PictureBox1
        '
        Me.PictureBox1.Location = New System.Drawing.Point(44, 12)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(175, 108)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 116
        Me.PictureBox1.TabStop = false
        Me.ttpToolTip.SetToolTip(Me.PictureBox1, "Imagen del usuario")
        '
        'btnSalir
        '
        Me.btnSalir.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnSalir.FlatAppearance.BorderColor = System.Drawing.Color.DodgerBlue
        Me.btnSalir.FlatAppearance.MouseOverBackColor = System.Drawing.Color.MidnightBlue
        Me.btnSalir.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSalir.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.btnSalir.ForeColor = System.Drawing.Color.White
        Me.btnSalir.Image = Global.Challengeme.UI.OnPremises.My.Resources.Resources.icons8_Exit_64
        Me.btnSalir.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnSalir.Location = New System.Drawing.Point(-3, 702)
        Me.btnSalir.Name = "btnSalir"
        Me.btnSalir.Padding = New System.Windows.Forms.Padding(0, 5, 0, 5)
        Me.btnSalir.Size = New System.Drawing.Size(256, 53)
        Me.btnSalir.TabIndex = 126
        Me.btnSalir.Text = "                       Salir                                     "
        Me.btnSalir.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.ttpToolTip.SetToolTip(Me.btnSalir, "Salir del programa")
        Me.btnSalir.UseVisualStyleBackColor = true
        '
        'btnProductos
        '
        Me.btnProductos.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnProductos.Enabled = false
        Me.btnProductos.FlatAppearance.BorderColor = System.Drawing.Color.DodgerBlue
        Me.btnProductos.FlatAppearance.MouseOverBackColor = System.Drawing.Color.MidnightBlue
        Me.btnProductos.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnProductos.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.btnProductos.ForeColor = System.Drawing.Color.White
        Me.btnProductos.Image = CType(resources.GetObject("btnProductos.Image"),System.Drawing.Image)
        Me.btnProductos.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnProductos.Location = New System.Drawing.Point(-3, 437)
        Me.btnProductos.Name = "btnProductos"
        Me.btnProductos.Padding = New System.Windows.Forms.Padding(0, 5, 0, 5)
        Me.btnProductos.Size = New System.Drawing.Size(256, 53)
        Me.btnProductos.TabIndex = 122
        Me.btnProductos.Text = "                      Productos                         "
        Me.btnProductos.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.ttpToolTip.SetToolTip(Me.btnProductos, "Creación de productos")
        Me.btnProductos.UseVisualStyleBackColor = true
        '
        'HolaToolStripMenuItem
        '
        Me.HolaToolStripMenuItem.Image = Global.Challengeme.UI.OnPremises.My.Resources.Resources.icons8_Shopping_Cart_64
        Me.HolaToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.HolaToolStripMenuItem.Name = "HolaToolStripMenuItem"
        Me.HolaToolStripMenuItem.Size = New System.Drawing.Size(273, 70)
        Me.HolaToolStripMenuItem.Text = "&Ver información de la cuenta"
        '
        'ActualizarFotoToolStripMenuItem
        '
        Me.ActualizarFotoToolStripMenuItem.Image = Global.Challengeme.UI.OnPremises.My.Resources.Resources.icons8_Add_Camera_64
        Me.ActualizarFotoToolStripMenuItem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.ActualizarFotoToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.ActualizarFotoToolStripMenuItem.Name = "ActualizarFotoToolStripMenuItem"
        Me.ActualizarFotoToolStripMenuItem.Size = New System.Drawing.Size(273, 70)
        Me.ActualizarFotoToolStripMenuItem.Text = "&Actualizar foto"
        '
        'CambiarContraseñaToolStripMenuItem1
        '
        Me.CambiarContraseñaToolStripMenuItem1.Image = Global.Challengeme.UI.OnPremises.My.Resources.Resources.icons8_User_64
        Me.CambiarContraseñaToolStripMenuItem1.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.CambiarContraseñaToolStripMenuItem1.Name = "CambiarContraseñaToolStripMenuItem1"
        Me.CambiarContraseñaToolStripMenuItem1.Size = New System.Drawing.Size(273, 70)
        Me.CambiarContraseñaToolStripMenuItem1.Text = "&Cambiar contraseña"
        '
        'CerrarToolStripMenuItem
        '
        Me.CerrarToolStripMenuItem.Image = Global.Challengeme.UI.OnPremises.My.Resources.Resources.icons8_Exit_64
        Me.CerrarToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.CerrarToolStripMenuItem.Name = "CerrarToolStripMenuItem"
        Me.CerrarToolStripMenuItem.Size = New System.Drawing.Size(273, 70)
        Me.CerrarToolStripMenuItem.Text = "&Cerrar"
        '
        'frmDashBoard
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6!, 13!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(871, 756)
        Me.ControlBox = false
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Icon = CType(resources.GetObject("$this.Icon"),System.Drawing.Icon)
        Me.IsMdiContainer = true
        Me.Name = "frmDashBoard"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.Panel1.ResumeLayout(false)
        Me.Panel1.PerformLayout
        CType(Me.TrackBar1,System.ComponentModel.ISupportInitialize).EndInit
        Me.Panel2.ResumeLayout(false)
        Me.Panel2.PerformLayout
        Me.Panel3.ResumeLayout(false)
        Me.Panel4.ResumeLayout(false)
        Me.Panel4.PerformLayout
        Me.mnsConfiguracion.ResumeLayout(false)
        Me.mnsConfiguracion.PerformLayout
        Me.ContextMenuStrip1.ResumeLayout(false)
        CType(Me.PictureBox1,System.ComponentModel.ISupportInitialize).EndInit
        Me.ResumeLayout(false)

End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents txtRol As TextBox
    Friend WithEvents cboCargarAreas As ComboBox
    Friend WithEvents TrackBar1 As TrackBar
    Friend WithEvents btnPerfil As Button
    Friend WithEvents txtUSUARIO As TextBox
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents btnSalir As Button
    Friend WithEvents btnProductos As Button
    Friend WithEvents btnEventos As Button
    Friend WithEvents btnActividades As Button
    Friend WithEvents btnPatrocinadores As Button
    Friend WithEvents btnPremios As Button
    Friend WithEvents btnRanking As Button
    Friend WithEvents btnInscripcion As Button
    Friend WithEvents btnCategoria As Button
    Friend WithEvents lblNombreRol As TextBox
    Friend WithEvents Panel3 As Panel
    Friend WithEvents btnMenuPermisos As Button
    Friend WithEvents btnEmpresas As Button
    Friend WithEvents btnDashboard As Button
    Friend WithEvents Panel4 As Panel
    Friend WithEvents btnCerrar As Button
    Friend WithEvents btnConfiguracion As Button
    Friend WithEvents mnsConfiguracion As MenuStrip
    Friend WithEvents ToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents MiCuentaToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CambiarContraseñaToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AgregarFotografíaToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ContextMenuStrip1 As ContextMenuStrip
    Friend WithEvents HolaToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents btn As Button
    Friend WithEvents CambiarContraseñaToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents ActualizarFotoToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CerrarToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents txtConfiguracion As TextBox
    Friend WithEvents ttpToolTip As ToolTip
    Friend WithEvents btnRutas As Button
End Class
