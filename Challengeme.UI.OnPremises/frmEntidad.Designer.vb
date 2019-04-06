<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmEntidad
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
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmEntidad))
        Me.GroupBoxDireccionEntidad = New System.Windows.Forms.GroupBox()
        Me.picLogo = New System.Windows.Forms.PictureBox()
        Me.cmsEscogerFotografia = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.SeleccionarFotografíaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SalirToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.cboxTipo = New System.Windows.Forms.ComboBox()
        Me.ButtonUploadImage = New System.Windows.Forms.Button()
        Me.LabelLogo = New System.Windows.Forms.Label()
        Me.txtCorreoEntidad = New System.Windows.Forms.TextBox()
        Me.txtTelefonoEntidad = New System.Windows.Forms.TextBox()
        Me.txtDireccion = New System.Windows.Forms.TextBox()
        Me.txtNombreComercial = New System.Windows.Forms.TextBox()
        Me.txtNombreEntidad = New System.Windows.Forms.TextBox()
        Me.txtIdEntidad = New System.Windows.Forms.TextBox()
        Me.LabelCorreoEntidad = New System.Windows.Forms.Label()
        Me.LabelTelefonoEntidad = New System.Windows.Forms.Label()
        Me.LabelDireccionEntidad = New System.Windows.Forms.Label()
        Me.LabelNombreComercialEntidad = New System.Windows.Forms.Label()
        Me.LabelTipoEntidad = New System.Windows.Forms.Label()
        Me.LabelNombreEntidad = New System.Windows.Forms.Label()
        Me.LabelIdEntidad = New System.Windows.Forms.Label()
        Me.DataGridViewEntidades = New System.Windows.Forms.DataGridView()
        Me.colIdEntidad = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colNombreEntidad = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colTipoEntidad = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colNombreComercialEntidad = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colDireccionEntidad = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colTelefonoEntidad = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colLogoEntidad = New System.Windows.Forms.DataGridViewImageColumn()
        Me.colCorreoEntidad = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cboPermisosEntidad = New System.Windows.Forms.ComboBox()
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.ToolStripBtnNuevo = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripBtnGuardar = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripBtnBuscar = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripBtnActualizar = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripBtnEliminar = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripBtnSalir = New System.Windows.Forms.ToolStripButton()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.erProveedorError = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.ttpToolTip = New System.Windows.Forms.ToolTip(Me.components)
        Me.GroupBoxDireccionEntidad.SuspendLayout
        CType(Me.picLogo,System.ComponentModel.ISupportInitialize).BeginInit
        Me.cmsEscogerFotografia.SuspendLayout
        CType(Me.DataGridViewEntidades,System.ComponentModel.ISupportInitialize).BeginInit
        Me.ToolStrip1.SuspendLayout
        CType(Me.erProveedorError,System.ComponentModel.ISupportInitialize).BeginInit
        Me.SuspendLayout
        '
        'GroupBoxDireccionEntidad
        '
        Me.GroupBoxDireccionEntidad.Controls.Add(Me.picLogo)
        Me.GroupBoxDireccionEntidad.Controls.Add(Me.cboxTipo)
        Me.GroupBoxDireccionEntidad.Controls.Add(Me.ButtonUploadImage)
        Me.GroupBoxDireccionEntidad.Controls.Add(Me.LabelLogo)
        Me.GroupBoxDireccionEntidad.Controls.Add(Me.txtCorreoEntidad)
        Me.GroupBoxDireccionEntidad.Controls.Add(Me.txtTelefonoEntidad)
        Me.GroupBoxDireccionEntidad.Controls.Add(Me.txtDireccion)
        Me.GroupBoxDireccionEntidad.Controls.Add(Me.txtNombreComercial)
        Me.GroupBoxDireccionEntidad.Controls.Add(Me.txtNombreEntidad)
        Me.GroupBoxDireccionEntidad.Controls.Add(Me.txtIdEntidad)
        Me.GroupBoxDireccionEntidad.Controls.Add(Me.LabelCorreoEntidad)
        Me.GroupBoxDireccionEntidad.Controls.Add(Me.LabelTelefonoEntidad)
        Me.GroupBoxDireccionEntidad.Controls.Add(Me.LabelDireccionEntidad)
        Me.GroupBoxDireccionEntidad.Controls.Add(Me.LabelNombreComercialEntidad)
        Me.GroupBoxDireccionEntidad.Controls.Add(Me.LabelTipoEntidad)
        Me.GroupBoxDireccionEntidad.Controls.Add(Me.LabelNombreEntidad)
        Me.GroupBoxDireccionEntidad.Controls.Add(Me.LabelIdEntidad)
        Me.GroupBoxDireccionEntidad.Font = New System.Drawing.Font("Microsoft Sans Serif", 12!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.GroupBoxDireccionEntidad.Location = New System.Drawing.Point(34, 106)
        Me.GroupBoxDireccionEntidad.Margin = New System.Windows.Forms.Padding(2)
        Me.GroupBoxDireccionEntidad.Name = "GroupBoxDireccionEntidad"
        Me.GroupBoxDireccionEntidad.Padding = New System.Windows.Forms.Padding(2)
        Me.GroupBoxDireccionEntidad.Size = New System.Drawing.Size(630, 228)
        Me.GroupBoxDireccionEntidad.TabIndex = 0
        Me.GroupBoxDireccionEntidad.TabStop = false
        Me.GroupBoxDireccionEntidad.Text = "Entidades"
        '
        'picLogo
        '
        Me.picLogo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.picLogo.ContextMenuStrip = Me.cmsEscogerFotografia
        Me.picLogo.Location = New System.Drawing.Point(479, 30)
        Me.picLogo.Margin = New System.Windows.Forms.Padding(2)
        Me.picLogo.Name = "picLogo"
        Me.picLogo.Size = New System.Drawing.Size(137, 112)
        Me.picLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picLogo.TabIndex = 19
        Me.picLogo.TabStop = false
        Me.ttpToolTip.SetToolTip(Me.picLogo, "Clic derecho para agregar logo de la empresa")
        '
        'cmsEscogerFotografia
        '
        Me.cmsEscogerFotografia.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.SeleccionarFotografíaToolStripMenuItem, Me.SalirToolStripMenuItem})
        Me.cmsEscogerFotografia.Name = "cmsEscogerFotografia"
        Me.cmsEscogerFotografia.Size = New System.Drawing.Size(192, 48)
        '
        'SeleccionarFotografíaToolStripMenuItem
        '
        Me.SeleccionarFotografíaToolStripMenuItem.Name = "SeleccionarFotografíaToolStripMenuItem"
        Me.SeleccionarFotografíaToolStripMenuItem.Size = New System.Drawing.Size(191, 22)
        Me.SeleccionarFotografíaToolStripMenuItem.Text = "Seleccionar Fotografía"
        '
        'SalirToolStripMenuItem
        '
        Me.SalirToolStripMenuItem.Name = "SalirToolStripMenuItem"
        Me.SalirToolStripMenuItem.Size = New System.Drawing.Size(191, 22)
        Me.SalirToolStripMenuItem.Text = "Salir"
        '
        'cboxTipo
        '
        Me.cboxTipo.Font = New System.Drawing.Font("Microsoft Sans Serif", 9!)
        Me.cboxTipo.FormattingEnabled = true
        Me.cboxTipo.Location = New System.Drawing.Point(83, 80)
        Me.cboxTipo.Margin = New System.Windows.Forms.Padding(2)
        Me.cboxTipo.Name = "cboxTipo"
        Me.cboxTipo.Size = New System.Drawing.Size(130, 23)
        Me.cboxTipo.TabIndex = 18
        '
        'ButtonUploadImage
        '
        Me.ButtonUploadImage.Font = New System.Drawing.Font("Microsoft Sans Serif", 9!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.ButtonUploadImage.Location = New System.Drawing.Point(489, 146)
        Me.ButtonUploadImage.Margin = New System.Windows.Forms.Padding(2)
        Me.ButtonUploadImage.Name = "ButtonUploadImage"
        Me.ButtonUploadImage.Size = New System.Drawing.Size(113, 34)
        Me.ButtonUploadImage.TabIndex = 16
        Me.ButtonUploadImage.Text = "Agregar imagen"
        Me.ttpToolTip.SetToolTip(Me.ButtonUploadImage, "Agregar logo a la empresa")
        Me.ButtonUploadImage.UseVisualStyleBackColor = true
        '
        'LabelLogo
        '
        Me.LabelLogo.AutoSize = true
        Me.LabelLogo.Font = New System.Drawing.Font("Microsoft Sans Serif", 9!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.LabelLogo.Location = New System.Drawing.Point(526, 13)
        Me.LabelLogo.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.LabelLogo.Name = "LabelLogo"
        Me.LabelLogo.Size = New System.Drawing.Size(35, 15)
        Me.LabelLogo.TabIndex = 15
        Me.LabelLogo.Text = "Logo"
        '
        'txtCorreoEntidad
        '
        Me.txtCorreoEntidad.Font = New System.Drawing.Font("Microsoft Sans Serif", 9!)
        Me.txtCorreoEntidad.Location = New System.Drawing.Point(299, 78)
        Me.txtCorreoEntidad.Margin = New System.Windows.Forms.Padding(2)
        Me.txtCorreoEntidad.Name = "txtCorreoEntidad"
        Me.txtCorreoEntidad.Size = New System.Drawing.Size(142, 21)
        Me.txtCorreoEntidad.TabIndex = 13
        '
        'txtTelefonoEntidad
        '
        Me.txtTelefonoEntidad.Font = New System.Drawing.Font("Microsoft Sans Serif", 9!)
        Me.txtTelefonoEntidad.Location = New System.Drawing.Point(299, 54)
        Me.txtTelefonoEntidad.Margin = New System.Windows.Forms.Padding(2)
        Me.txtTelefonoEntidad.Name = "txtTelefonoEntidad"
        Me.txtTelefonoEntidad.Size = New System.Drawing.Size(142, 21)
        Me.txtTelefonoEntidad.TabIndex = 12
        '
        'txtDireccion
        '
        Me.txtDireccion.Font = New System.Drawing.Font("Microsoft Sans Serif", 9!)
        Me.txtDireccion.Location = New System.Drawing.Point(299, 21)
        Me.txtDireccion.Margin = New System.Windows.Forms.Padding(2)
        Me.txtDireccion.Name = "txtDireccion"
        Me.txtDireccion.Size = New System.Drawing.Size(142, 21)
        Me.txtDireccion.TabIndex = 11
        '
        'txtNombreComercial
        '
        Me.txtNombreComercial.Font = New System.Drawing.Font("Microsoft Sans Serif", 9!)
        Me.txtNombreComercial.Location = New System.Drawing.Point(83, 115)
        Me.txtNombreComercial.Margin = New System.Windows.Forms.Padding(2)
        Me.txtNombreComercial.Name = "txtNombreComercial"
        Me.txtNombreComercial.Size = New System.Drawing.Size(130, 21)
        Me.txtNombreComercial.TabIndex = 10
        '
        'txtNombreEntidad
        '
        Me.txtNombreEntidad.Font = New System.Drawing.Font("Microsoft Sans Serif", 9!)
        Me.txtNombreEntidad.Location = New System.Drawing.Point(83, 54)
        Me.txtNombreEntidad.Margin = New System.Windows.Forms.Padding(2)
        Me.txtNombreEntidad.Name = "txtNombreEntidad"
        Me.txtNombreEntidad.Size = New System.Drawing.Size(129, 21)
        Me.txtNombreEntidad.TabIndex = 8
        '
        'txtIdEntidad
        '
        Me.txtIdEntidad.Font = New System.Drawing.Font("Microsoft Sans Serif", 9!)
        Me.txtIdEntidad.Location = New System.Drawing.Point(83, 21)
        Me.txtIdEntidad.Margin = New System.Windows.Forms.Padding(2)
        Me.txtIdEntidad.Name = "txtIdEntidad"
        Me.txtIdEntidad.Size = New System.Drawing.Size(130, 21)
        Me.txtIdEntidad.TabIndex = 7
        '
        'LabelCorreoEntidad
        '
        Me.LabelCorreoEntidad.AutoSize = true
        Me.LabelCorreoEntidad.Font = New System.Drawing.Font("Microsoft Sans Serif", 8!)
        Me.LabelCorreoEntidad.Location = New System.Drawing.Point(240, 81)
        Me.LabelCorreoEntidad.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.LabelCorreoEntidad.Name = "LabelCorreoEntidad"
        Me.LabelCorreoEntidad.Size = New System.Drawing.Size(38, 13)
        Me.LabelCorreoEntidad.TabIndex = 6
        Me.LabelCorreoEntidad.Text = "Correo"
        '
        'LabelTelefonoEntidad
        '
        Me.LabelTelefonoEntidad.AutoSize = true
        Me.LabelTelefonoEntidad.Font = New System.Drawing.Font("Microsoft Sans Serif", 8!)
        Me.LabelTelefonoEntidad.Location = New System.Drawing.Point(240, 57)
        Me.LabelTelefonoEntidad.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.LabelTelefonoEntidad.Name = "LabelTelefonoEntidad"
        Me.LabelTelefonoEntidad.Size = New System.Drawing.Size(49, 13)
        Me.LabelTelefonoEntidad.TabIndex = 5
        Me.LabelTelefonoEntidad.Text = "Teléfono"
        '
        'LabelDireccionEntidad
        '
        Me.LabelDireccionEntidad.AutoSize = true
        Me.LabelDireccionEntidad.Font = New System.Drawing.Font("Microsoft Sans Serif", 8!)
        Me.LabelDireccionEntidad.Location = New System.Drawing.Point(240, 25)
        Me.LabelDireccionEntidad.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.LabelDireccionEntidad.Name = "LabelDireccionEntidad"
        Me.LabelDireccionEntidad.Size = New System.Drawing.Size(52, 13)
        Me.LabelDireccionEntidad.TabIndex = 4
        Me.LabelDireccionEntidad.Text = "Dirección"
        '
        'LabelNombreComercialEntidad
        '
        Me.LabelNombreComercialEntidad.AutoSize = true
        Me.LabelNombreComercialEntidad.Font = New System.Drawing.Font("Microsoft Sans Serif", 8!)
        Me.LabelNombreComercialEntidad.Location = New System.Drawing.Point(16, 113)
        Me.LabelNombreComercialEntidad.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.LabelNombreComercialEntidad.Name = "LabelNombreComercialEntidad"
        Me.LabelNombreComercialEntidad.Size = New System.Drawing.Size(52, 26)
        Me.LabelNombreComercialEntidad.TabIndex = 3
        Me.LabelNombreComercialEntidad.Text = "Nombre "&Global.Microsoft.VisualBasic.ChrW(13)&Global.Microsoft.VisualBasic.ChrW(10)&"comercial"
        '
        'LabelTipoEntidad
        '
        Me.LabelTipoEntidad.AutoSize = true
        Me.LabelTipoEntidad.Font = New System.Drawing.Font("Microsoft Sans Serif", 8!)
        Me.LabelTipoEntidad.Location = New System.Drawing.Point(16, 84)
        Me.LabelTipoEntidad.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.LabelTipoEntidad.Name = "LabelTipoEntidad"
        Me.LabelTipoEntidad.Size = New System.Drawing.Size(28, 13)
        Me.LabelTipoEntidad.TabIndex = 2
        Me.LabelTipoEntidad.Text = "Tipo"
        '
        'LabelNombreEntidad
        '
        Me.LabelNombreEntidad.AutoSize = true
        Me.LabelNombreEntidad.Font = New System.Drawing.Font("Microsoft Sans Serif", 8!)
        Me.LabelNombreEntidad.Location = New System.Drawing.Point(16, 57)
        Me.LabelNombreEntidad.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.LabelNombreEntidad.Name = "LabelNombreEntidad"
        Me.LabelNombreEntidad.Size = New System.Drawing.Size(44, 13)
        Me.LabelNombreEntidad.TabIndex = 1
        Me.LabelNombreEntidad.Text = "Nombre"
        '
        'LabelIdEntidad
        '
        Me.LabelIdEntidad.AutoSize = true
        Me.LabelIdEntidad.Font = New System.Drawing.Font("Microsoft Sans Serif", 8!)
        Me.LabelIdEntidad.Location = New System.Drawing.Point(16, 25)
        Me.LabelIdEntidad.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.LabelIdEntidad.Name = "LabelIdEntidad"
        Me.LabelIdEntidad.Size = New System.Drawing.Size(60, 13)
        Me.LabelIdEntidad.TabIndex = 0
        Me.LabelIdEntidad.Text = "ID. Entidad"
        '
        'DataGridViewEntidades
        '
        Me.DataGridViewEntidades.AllowUserToAddRows = false
        Me.DataGridViewEntidades.AllowUserToDeleteRows = false
        Me.DataGridViewEntidades.BackgroundColor = System.Drawing.Color.White
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridViewEntidades.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.DataGridViewEntidades.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridViewEntidades.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.colIdEntidad, Me.colNombreEntidad, Me.colTipoEntidad, Me.colNombreComercialEntidad, Me.colDireccionEntidad, Me.colTelefonoEntidad, Me.colLogoEntidad, Me.colCorreoEntidad})
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DataGridViewEntidades.DefaultCellStyle = DataGridViewCellStyle2
        Me.DataGridViewEntidades.Location = New System.Drawing.Point(33, 351)
        Me.DataGridViewEntidades.Margin = New System.Windows.Forms.Padding(2)
        Me.DataGridViewEntidades.Name = "DataGridViewEntidades"
        Me.DataGridViewEntidades.ReadOnly = true
        Me.DataGridViewEntidades.Size = New System.Drawing.Size(630, 228)
        Me.DataGridViewEntidades.TabIndex = 1
        '
        'colIdEntidad
        '
        Me.colIdEntidad.HeaderText = "Id"
        Me.colIdEntidad.Name = "colIdEntidad"
        Me.colIdEntidad.ReadOnly = true
        '
        'colNombreEntidad
        '
        Me.colNombreEntidad.HeaderText = "Nombre"
        Me.colNombreEntidad.Name = "colNombreEntidad"
        Me.colNombreEntidad.ReadOnly = true
        Me.colNombreEntidad.Width = 150
        '
        'colTipoEntidad
        '
        Me.colTipoEntidad.HeaderText = "Tipo"
        Me.colTipoEntidad.Name = "colTipoEntidad"
        Me.colTipoEntidad.ReadOnly = true
        Me.colTipoEntidad.Width = 110
        '
        'colNombreComercialEntidad
        '
        Me.colNombreComercialEntidad.HeaderText = "Nombre comercial"
        Me.colNombreComercialEntidad.Name = "colNombreComercialEntidad"
        Me.colNombreComercialEntidad.ReadOnly = true
        Me.colNombreComercialEntidad.Width = 150
        '
        'colDireccionEntidad
        '
        Me.colDireccionEntidad.HeaderText = "Dirección"
        Me.colDireccionEntidad.Name = "colDireccionEntidad"
        Me.colDireccionEntidad.ReadOnly = true
        '
        'colTelefonoEntidad
        '
        Me.colTelefonoEntidad.HeaderText = "Teléfono"
        Me.colTelefonoEntidad.Name = "colTelefonoEntidad"
        Me.colTelefonoEntidad.ReadOnly = true
        '
        'colLogoEntidad
        '
        Me.colLogoEntidad.HeaderText = "Logo"
        Me.colLogoEntidad.Name = "colLogoEntidad"
        Me.colLogoEntidad.ReadOnly = true
        '
        'colCorreoEntidad
        '
        Me.colCorreoEntidad.HeaderText = "Correo"
        Me.colCorreoEntidad.Name = "colCorreoEntidad"
        Me.colCorreoEntidad.ReadOnly = true
        Me.colCorreoEntidad.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.colCorreoEntidad.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.colCorreoEntidad.Width = 120
        '
        'cboPermisosEntidad
        '
        Me.cboPermisosEntidad.FormattingEnabled = true
        Me.cboPermisosEntidad.Location = New System.Drawing.Point(20, 298)
        Me.cboPermisosEntidad.Margin = New System.Windows.Forms.Padding(2)
        Me.cboPermisosEntidad.Name = "cboPermisosEntidad"
        Me.cboPermisosEntidad.Size = New System.Drawing.Size(41, 21)
        Me.cboPermisosEntidad.TabIndex = 4
        Me.cboPermisosEntidad.Visible = false
        '
        'ToolStrip1
        '
        Me.ToolStrip1.BackColor = System.Drawing.Color.White
        Me.ToolStrip1.Dock = System.Windows.Forms.DockStyle.None
        Me.ToolStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
        Me.ToolStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripBtnNuevo, Me.ToolStripBtnGuardar, Me.ToolStripBtnBuscar, Me.ToolStripBtnActualizar, Me.ToolStripBtnEliminar, Me.ToolStripBtnSalir})
        Me.ToolStrip1.Location = New System.Drawing.Point(34, 8)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.System
        Me.ToolStrip1.Size = New System.Drawing.Size(595, 71)
        Me.ToolStrip1.TabIndex = 52
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'ToolStripBtnNuevo
        '
        Me.ToolStripBtnNuevo.Enabled = false
        Me.ToolStripBtnNuevo.Font = New System.Drawing.Font("Microsoft Sans Serif", 9!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.ToolStripBtnNuevo.Image = CType(resources.GetObject("ToolStripBtnNuevo.Image"),System.Drawing.Image)
        Me.ToolStripBtnNuevo.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.ToolStripBtnNuevo.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripBtnNuevo.Name = "ToolStripBtnNuevo"
        Me.ToolStripBtnNuevo.Size = New System.Drawing.Size(110, 68)
        Me.ToolStripBtnNuevo.Text = "Nuevo"
        '
        'ToolStripBtnGuardar
        '
        Me.ToolStripBtnGuardar.Enabled = false
        Me.ToolStripBtnGuardar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9!)
        Me.ToolStripBtnGuardar.Image = CType(resources.GetObject("ToolStripBtnGuardar.Image"),System.Drawing.Image)
        Me.ToolStripBtnGuardar.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.ToolStripBtnGuardar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripBtnGuardar.Name = "ToolStripBtnGuardar"
        Me.ToolStripBtnGuardar.Size = New System.Drawing.Size(120, 68)
        Me.ToolStripBtnGuardar.Text = "Guardar"
        '
        'ToolStripBtnBuscar
        '
        Me.ToolStripBtnBuscar.Enabled = false
        Me.ToolStripBtnBuscar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9!)
        Me.ToolStripBtnBuscar.Image = CType(resources.GetObject("ToolStripBtnBuscar.Image"),System.Drawing.Image)
        Me.ToolStripBtnBuscar.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.ToolStripBtnBuscar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripBtnBuscar.Name = "ToolStripBtnBuscar"
        Me.ToolStripBtnBuscar.Size = New System.Drawing.Size(113, 68)
        Me.ToolStripBtnBuscar.Text = "Buscar"
        '
        'ToolStripBtnActualizar
        '
        Me.ToolStripBtnActualizar.Enabled = false
        Me.ToolStripBtnActualizar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9!)
        Me.ToolStripBtnActualizar.Image = CType(resources.GetObject("ToolStripBtnActualizar.Image"),System.Drawing.Image)
        Me.ToolStripBtnActualizar.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.ToolStripBtnActualizar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripBtnActualizar.Name = "ToolStripBtnActualizar"
        Me.ToolStripBtnActualizar.Size = New System.Drawing.Size(128, 68)
        Me.ToolStripBtnActualizar.Text = "Actualizar"
        '
        'ToolStripBtnEliminar
        '
        Me.ToolStripBtnEliminar.Enabled = false
        Me.ToolStripBtnEliminar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9!)
        Me.ToolStripBtnEliminar.Image = CType(resources.GetObject("ToolStripBtnEliminar.Image"),System.Drawing.Image)
        Me.ToolStripBtnEliminar.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.ToolStripBtnEliminar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripBtnEliminar.Name = "ToolStripBtnEliminar"
        Me.ToolStripBtnEliminar.Size = New System.Drawing.Size(121, 68)
        Me.ToolStripBtnEliminar.Text = "Eliminar"
        '
        'ToolStripBtnSalir
        '
        Me.ToolStripBtnSalir.Font = New System.Drawing.Font("Microsoft Sans Serif", 9!)
        Me.ToolStripBtnSalir.Image = CType(resources.GetObject("ToolStripBtnSalir.Image"),System.Drawing.Image)
        Me.ToolStripBtnSalir.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.ToolStripBtnSalir.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripBtnSalir.Name = "ToolStripBtnSalir"
        Me.ToolStripBtnSalir.Size = New System.Drawing.Size(100, 68)
        Me.ToolStripBtnSalir.Text = "Salir"
        Me.ToolStripBtnSalir.Visible = false
        '
        'Label10
        '
        Me.Label10.AutoSize = true
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.Label10.ForeColor = System.Drawing.SystemColors.ButtonShadow
        Me.Label10.Location = New System.Drawing.Point(31, 74)
        Me.Label10.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(249, 24)
        Me.Label10.TabIndex = 59
        Me.Label10.Text = "Mantenimiento de empresas"
        '
        'erProveedorError
        '
        Me.erProveedorError.ContainerControl = Me
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
        'frmEntidad
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6!, 13!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(674, 590)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Controls.Add(Me.cboPermisosEntidad)
        Me.Controls.Add(Me.DataGridViewEntidades)
        Me.Controls.Add(Me.GroupBoxDireccionEntidad)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"),System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.Name = "frmEntidad"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frmEntidad"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.GroupBoxDireccionEntidad.ResumeLayout(false)
        Me.GroupBoxDireccionEntidad.PerformLayout
        CType(Me.picLogo,System.ComponentModel.ISupportInitialize).EndInit
        Me.cmsEscogerFotografia.ResumeLayout(false)
        CType(Me.DataGridViewEntidades,System.ComponentModel.ISupportInitialize).EndInit
        Me.ToolStrip1.ResumeLayout(false)
        Me.ToolStrip1.PerformLayout
        CType(Me.erProveedorError,System.ComponentModel.ISupportInitialize).EndInit
        Me.ResumeLayout(false)
        Me.PerformLayout

End Sub

    Friend WithEvents GroupBoxDireccionEntidad As GroupBox
    Friend WithEvents LabelIdEntidad As Label
    Friend WithEvents LabelTipoEntidad As Label
    Friend WithEvents LabelNombreEntidad As Label
    Friend WithEvents LabelTelefonoEntidad As Label
    Friend WithEvents LabelDireccionEntidad As Label
    Friend WithEvents LabelNombreComercialEntidad As Label
    Friend WithEvents txtDireccion As TextBox
    Friend WithEvents txtNombreComercial As TextBox
    Friend WithEvents txtNombreEntidad As TextBox
    Friend WithEvents txtIdEntidad As TextBox
    Friend WithEvents LabelCorreoEntidad As Label
    Friend WithEvents LabelLogo As Label
    Friend WithEvents txtCorreoEntidad As TextBox
    Friend WithEvents txtTelefonoEntidad As TextBox
    Friend WithEvents cboxTipo As ComboBox
    Friend WithEvents ButtonUploadImage As Button
    Friend WithEvents DataGridViewEntidades As DataGridView
    Friend WithEvents picLogo As PictureBox
    Friend WithEvents cboPermisosEntidad As ComboBox
    Friend WithEvents ToolStrip1 As ToolStrip
    Friend WithEvents ToolStripBtnNuevo As ToolStripButton
    Friend WithEvents ToolStripBtnGuardar As ToolStripButton
    Friend WithEvents ToolStripBtnBuscar As ToolStripButton
    Friend WithEvents ToolStripBtnActualizar As ToolStripButton
    Friend WithEvents ToolStripBtnEliminar As ToolStripButton
    Friend WithEvents ToolStripBtnSalir As ToolStripButton
    Friend WithEvents colIdEntidad As DataGridViewTextBoxColumn
    Friend WithEvents colNombreEntidad As DataGridViewTextBoxColumn
    Friend WithEvents colTipoEntidad As DataGridViewTextBoxColumn
    Friend WithEvents colNombreComercialEntidad As DataGridViewTextBoxColumn
    Friend WithEvents colDireccionEntidad As DataGridViewTextBoxColumn
    Friend WithEvents colTelefonoEntidad As DataGridViewTextBoxColumn
    Friend WithEvents colLogoEntidad As DataGridViewImageColumn
    Friend WithEvents colCorreoEntidad As DataGridViewTextBoxColumn
    Friend WithEvents Label10 As Label
    Friend WithEvents erProveedorError As ErrorProvider
    Friend WithEvents cmsEscogerFotografia As ContextMenuStrip
    Friend WithEvents SeleccionarFotografíaToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SalirToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ttpToolTip As ToolTip
End Class
