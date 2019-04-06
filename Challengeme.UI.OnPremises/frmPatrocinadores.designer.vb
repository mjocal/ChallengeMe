<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmPatrocinadores
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmPatrocinadores))
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.picLogo = New System.Windows.Forms.PictureBox()
        Me.cmsEscogerLogo = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.SeleccionarLogoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SalirToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ButtonUploadImage = New System.Windows.Forms.Button()
        Me.LabelLogo = New System.Windows.Forms.Label()
        Me.txtNombrePatrocinador = New System.Windows.Forms.TextBox()
        Me.txtIdPatrocinador = New System.Windows.Forms.TextBox()
        Me.LabelNombrePatrocinador = New System.Windows.Forms.Label()
        Me.dgvPatrocinadores = New System.Windows.Forms.DataGridView()
        Me.IdPatrocinador = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NombrePatrocinador = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.LogoPatrocinador = New System.Windows.Forms.DataGridViewImageColumn()
        Me.LabelIdPatrocinador = New System.Windows.Forms.Label()
        Me.GroupBoxDireccionEntidad = New System.Windows.Forms.GroupBox()
        Me.cboPermisosPatrocinadores = New System.Windows.Forms.ComboBox()
        Me.ToolStrip = New System.Windows.Forms.ToolStrip()
        Me.ToolStripBtnNuevo = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripBtnGuardar = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripBtnEliminar = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripBtnBuscar = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripBtnActualizar = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripBtnSalir = New System.Windows.Forms.ToolStripButton()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.dgvProductosEnPatrocinador = New System.Windows.Forms.DataGridView()
        Me.Producto = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Costo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.LinkLabel1 = New System.Windows.Forms.LinkLabel()
        Me.txtCodPatrocinador = New System.Windows.Forms.TextBox()
        Me.ttpToolTip = New System.Windows.Forms.ToolTip(Me.components)
        Me.erProveedorError = New System.Windows.Forms.ErrorProvider(Me.components)
        CType(Me.picLogo,System.ComponentModel.ISupportInitialize).BeginInit
        Me.cmsEscogerLogo.SuspendLayout
        CType(Me.dgvPatrocinadores,System.ComponentModel.ISupportInitialize).BeginInit
        Me.GroupBoxDireccionEntidad.SuspendLayout
        Me.ToolStrip.SuspendLayout
        CType(Me.dgvProductosEnPatrocinador,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.erProveedorError,System.ComponentModel.ISupportInitialize).BeginInit
        Me.SuspendLayout
        '
        'picLogo
        '
        Me.picLogo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.picLogo.ContextMenuStrip = Me.cmsEscogerLogo
        Me.picLogo.Location = New System.Drawing.Point(642, 34)
        Me.picLogo.Name = "picLogo"
        Me.picLogo.Size = New System.Drawing.Size(159, 127)
        Me.picLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picLogo.TabIndex = 19
        Me.picLogo.TabStop = false
        Me.ttpToolTip.SetToolTip(Me.picLogo, "Clic derecho para agregar logo ")
        '
        'cmsEscogerLogo
        '
        Me.cmsEscogerLogo.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.SeleccionarLogoToolStripMenuItem, Me.SalirToolStripMenuItem})
        Me.cmsEscogerLogo.Name = "cmsEscogerLogo"
        Me.cmsEscogerLogo.Size = New System.Drawing.Size(162, 48)
        '
        'SeleccionarLogoToolStripMenuItem
        '
        Me.SeleccionarLogoToolStripMenuItem.Name = "SeleccionarLogoToolStripMenuItem"
        Me.SeleccionarLogoToolStripMenuItem.Size = New System.Drawing.Size(161, 22)
        Me.SeleccionarLogoToolStripMenuItem.Text = "Seleccionar logo"
        '
        'SalirToolStripMenuItem
        '
        Me.SalirToolStripMenuItem.Name = "SalirToolStripMenuItem"
        Me.SalirToolStripMenuItem.Size = New System.Drawing.Size(161, 22)
        Me.SalirToolStripMenuItem.Text = "Salir"
        '
        'ButtonUploadImage
        '
        Me.ButtonUploadImage.Font = New System.Drawing.Font("Microsoft Sans Serif", 9!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.ButtonUploadImage.Location = New System.Drawing.Point(642, 167)
        Me.ButtonUploadImage.Name = "ButtonUploadImage"
        Me.ButtonUploadImage.Size = New System.Drawing.Size(159, 40)
        Me.ButtonUploadImage.TabIndex = 16
        Me.ButtonUploadImage.Text = "Agregar logo"
        Me.ttpToolTip.SetToolTip(Me.ButtonUploadImage, "Clic para agrear logo del patrocinador")
        Me.ButtonUploadImage.UseVisualStyleBackColor = true
        '
        'LabelLogo
        '
        Me.LabelLogo.AutoSize = true
        Me.LabelLogo.Font = New System.Drawing.Font("Microsoft Sans Serif", 9!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.LabelLogo.Location = New System.Drawing.Point(648, 15)
        Me.LabelLogo.Name = "LabelLogo"
        Me.LabelLogo.Size = New System.Drawing.Size(35, 15)
        Me.LabelLogo.TabIndex = 15
        Me.LabelLogo.Text = "Logo"
        '
        'txtNombrePatrocinador
        '
        Me.txtNombrePatrocinador.Font = New System.Drawing.Font("Microsoft Sans Serif", 9!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.txtNombrePatrocinador.Location = New System.Drawing.Point(111, 64)
        Me.txtNombrePatrocinador.Name = "txtNombrePatrocinador"
        Me.txtNombrePatrocinador.Size = New System.Drawing.Size(172, 21)
        Me.txtNombrePatrocinador.TabIndex = 2
        '
        'txtIdPatrocinador
        '
        Me.txtIdPatrocinador.Font = New System.Drawing.Font("Microsoft Sans Serif", 9!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.txtIdPatrocinador.Location = New System.Drawing.Point(111, 30)
        Me.txtIdPatrocinador.Name = "txtIdPatrocinador"
        Me.txtIdPatrocinador.Size = New System.Drawing.Size(172, 21)
        Me.txtIdPatrocinador.TabIndex = 1
        '
        'LabelNombrePatrocinador
        '
        Me.LabelNombrePatrocinador.AutoSize = true
        Me.LabelNombrePatrocinador.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.LabelNombrePatrocinador.Location = New System.Drawing.Point(56, 67)
        Me.LabelNombrePatrocinador.Name = "LabelNombrePatrocinador"
        Me.LabelNombrePatrocinador.Size = New System.Drawing.Size(44, 13)
        Me.LabelNombrePatrocinador.TabIndex = 1
        Me.LabelNombrePatrocinador.Text = "Nombre"
        '
        'dgvPatrocinadores
        '
        Me.dgvPatrocinadores.AllowUserToAddRows = false
        Me.dgvPatrocinadores.AllowUserToDeleteRows = false
        Me.dgvPatrocinadores.BackgroundColor = System.Drawing.Color.White
        Me.dgvPatrocinadores.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvPatrocinadores.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IdPatrocinador, Me.NombrePatrocinador, Me.LogoPatrocinador})
        Me.dgvPatrocinadores.Location = New System.Drawing.Point(54, 346)
        Me.dgvPatrocinadores.Name = "dgvPatrocinadores"
        Me.dgvPatrocinadores.ReadOnly = true
        Me.dgvPatrocinadores.Size = New System.Drawing.Size(840, 147)
        Me.dgvPatrocinadores.TabIndex = 4
        '
        'IdPatrocinador
        '
        Me.IdPatrocinador.HeaderText = "Id"
        Me.IdPatrocinador.Name = "IdPatrocinador"
        Me.IdPatrocinador.ReadOnly = true
        '
        'NombrePatrocinador
        '
        Me.NombrePatrocinador.HeaderText = "Nombre"
        Me.NombrePatrocinador.Name = "NombrePatrocinador"
        Me.NombrePatrocinador.ReadOnly = true
        Me.NombrePatrocinador.Width = 370
        '
        'LogoPatrocinador
        '
        Me.LogoPatrocinador.HeaderText = "Logo"
        Me.LogoPatrocinador.Name = "LogoPatrocinador"
        Me.LogoPatrocinador.ReadOnly = true
        Me.LogoPatrocinador.Width = 200
        '
        'LabelIdPatrocinador
        '
        Me.LabelIdPatrocinador.AutoSize = true
        Me.LabelIdPatrocinador.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.LabelIdPatrocinador.Location = New System.Drawing.Point(21, 34)
        Me.LabelIdPatrocinador.Name = "LabelIdPatrocinador"
        Me.LabelIdPatrocinador.Size = New System.Drawing.Size(84, 13)
        Me.LabelIdPatrocinador.TabIndex = 0
        Me.LabelIdPatrocinador.Text = "ID. Patrocinador"
        '
        'GroupBoxDireccionEntidad
        '
        Me.GroupBoxDireccionEntidad.Controls.Add(Me.picLogo)
        Me.GroupBoxDireccionEntidad.Controls.Add(Me.ButtonUploadImage)
        Me.GroupBoxDireccionEntidad.Controls.Add(Me.LabelLogo)
        Me.GroupBoxDireccionEntidad.Controls.Add(Me.txtNombrePatrocinador)
        Me.GroupBoxDireccionEntidad.Controls.Add(Me.txtIdPatrocinador)
        Me.GroupBoxDireccionEntidad.Controls.Add(Me.LabelNombrePatrocinador)
        Me.GroupBoxDireccionEntidad.Controls.Add(Me.LabelIdPatrocinador)
        Me.GroupBoxDireccionEntidad.Font = New System.Drawing.Font("Microsoft Sans Serif", 12!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.GroupBoxDireccionEntidad.Location = New System.Drawing.Point(54, 127)
        Me.GroupBoxDireccionEntidad.Name = "GroupBoxDireccionEntidad"
        Me.GroupBoxDireccionEntidad.Size = New System.Drawing.Size(840, 213)
        Me.GroupBoxDireccionEntidad.TabIndex = 3
        Me.GroupBoxDireccionEntidad.TabStop = false
        Me.GroupBoxDireccionEntidad.Text = "Patrocinadores"
        '
        'cboPermisosPatrocinadores
        '
        Me.cboPermisosPatrocinadores.FormattingEnabled = true
        Me.cboPermisosPatrocinadores.Location = New System.Drawing.Point(12, 9)
        Me.cboPermisosPatrocinadores.Name = "cboPermisosPatrocinadores"
        Me.cboPermisosPatrocinadores.Size = New System.Drawing.Size(10, 21)
        Me.cboPermisosPatrocinadores.TabIndex = 7
        Me.cboPermisosPatrocinadores.Visible = false
        '
        'ToolStrip
        '
        Me.ToolStrip.BackColor = System.Drawing.Color.White
        Me.ToolStrip.Dock = System.Windows.Forms.DockStyle.None
        Me.ToolStrip.Font = New System.Drawing.Font("Microsoft Sans Serif", 9!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.ToolStrip.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
        Me.ToolStrip.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.ToolStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripBtnNuevo, Me.ToolStripBtnGuardar, Me.ToolStripBtnEliminar, Me.ToolStripBtnBuscar, Me.ToolStripBtnActualizar, Me.ToolStripBtnSalir})
        Me.ToolStrip.Location = New System.Drawing.Point(54, 9)
        Me.ToolStrip.Name = "ToolStrip"
        Me.ToolStrip.RenderMode = System.Windows.Forms.ToolStripRenderMode.System
        Me.ToolStrip.Size = New System.Drawing.Size(482, 71)
        Me.ToolStrip.TabIndex = 52
        Me.ToolStrip.Text = "ToolStrip2"
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
        Me.ToolStripBtnBuscar.Visible = false
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
        Me.Label10.Location = New System.Drawing.Point(50, 84)
        Me.Label10.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(291, 24)
        Me.Label10.TabIndex = 59
        Me.Label10.Text = "Mantenimiento de patrocinadores"
        '
        'dgvProductosEnPatrocinador
        '
        Me.dgvProductosEnPatrocinador.AllowUserToAddRows = false
        Me.dgvProductosEnPatrocinador.AllowUserToDeleteRows = false
        Me.dgvProductosEnPatrocinador.BackgroundColor = System.Drawing.Color.White
        Me.dgvProductosEnPatrocinador.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvProductosEnPatrocinador.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Producto, Me.Costo})
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.White
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvProductosEnPatrocinador.DefaultCellStyle = DataGridViewCellStyle1
        Me.dgvProductosEnPatrocinador.Location = New System.Drawing.Point(54, 499)
        Me.dgvProductosEnPatrocinador.Name = "dgvProductosEnPatrocinador"
        Me.dgvProductosEnPatrocinador.ReadOnly = true
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.White
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvProductosEnPatrocinador.RowHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.dgvProductosEnPatrocinador.Size = New System.Drawing.Size(351, 106)
        Me.dgvProductosEnPatrocinador.TabIndex = 60
        '
        'Producto
        '
        Me.Producto.HeaderText = "Producto"
        Me.Producto.Name = "Producto"
        Me.Producto.ReadOnly = true
        Me.Producto.Width = 200
        '
        'Costo
        '
        Me.Costo.HeaderText = "Costo unitario"
        Me.Costo.Name = "Costo"
        Me.Costo.ReadOnly = true
        '
        'LinkLabel1
        '
        Me.LinkLabel1.AutoSize = true
        Me.LinkLabel1.Location = New System.Drawing.Point(57, 619)
        Me.LinkLabel1.Name = "LinkLabel1"
        Me.LinkLabel1.Size = New System.Drawing.Size(90, 13)
        Me.LinkLabel1.TabIndex = 61
        Me.LinkLabel1.TabStop = true
        Me.LinkLabel1.Text = "Agregar Producto"
        '
        'txtCodPatrocinador
        '
        Me.txtCodPatrocinador.Location = New System.Drawing.Point(12, 36)
        Me.txtCodPatrocinador.Name = "txtCodPatrocinador"
        Me.txtCodPatrocinador.Size = New System.Drawing.Size(15, 20)
        Me.txtCodPatrocinador.TabIndex = 62
        Me.txtCodPatrocinador.Visible = false
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
        'erProveedorError
        '
        Me.erProveedorError.ContainerControl = Me
        '
        'frmPatrocinadores
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6!, 13!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(942, 732)
        Me.Controls.Add(Me.txtCodPatrocinador)
        Me.Controls.Add(Me.LinkLabel1)
        Me.Controls.Add(Me.dgvProductosEnPatrocinador)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.ToolStrip)
        Me.Controls.Add(Me.cboPermisosPatrocinadores)
        Me.Controls.Add(Me.dgvPatrocinadores)
        Me.Controls.Add(Me.GroupBoxDireccionEntidad)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"),System.Drawing.Icon)
        Me.Name = "frmPatrocinadores"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.picLogo,System.ComponentModel.ISupportInitialize).EndInit
        Me.cmsEscogerLogo.ResumeLayout(false)
        CType(Me.dgvPatrocinadores,System.ComponentModel.ISupportInitialize).EndInit
        Me.GroupBoxDireccionEntidad.ResumeLayout(false)
        Me.GroupBoxDireccionEntidad.PerformLayout
        Me.ToolStrip.ResumeLayout(false)
        Me.ToolStrip.PerformLayout
        CType(Me.dgvProductosEnPatrocinador,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.erProveedorError,System.ComponentModel.ISupportInitialize).EndInit
        Me.ResumeLayout(false)
        Me.PerformLayout

End Sub
    Friend WithEvents picLogo As PictureBox
    Friend WithEvents ButtonUploadImage As Button
    Friend WithEvents LabelLogo As Label
    Friend WithEvents txtNombrePatrocinador As TextBox
    Friend WithEvents txtIdPatrocinador As TextBox
    Friend WithEvents LabelNombrePatrocinador As Label
    Friend WithEvents dgvPatrocinadores As DataGridView
    Friend WithEvents LabelIdPatrocinador As Label
    Friend WithEvents GroupBoxDireccionEntidad As GroupBox
    Friend WithEvents cboPermisosPatrocinadores As ComboBox
    Friend WithEvents ToolStrip As ToolStrip
    Friend WithEvents ToolStripBtnNuevo As ToolStripButton
    Friend WithEvents ToolStripBtnGuardar As ToolStripButton
    Friend WithEvents ToolStripBtnBuscar As ToolStripButton
    Friend WithEvents ToolStripBtnActualizar As ToolStripButton
    Friend WithEvents ToolStripBtnEliminar As ToolStripButton
    Friend WithEvents ToolStripBtnSalir As ToolStripButton
    Friend WithEvents Label10 As Label
    Friend WithEvents dgvProductosEnPatrocinador As DataGridView
    Friend WithEvents Producto As DataGridViewTextBoxColumn
    Friend WithEvents Costo As DataGridViewTextBoxColumn
    Friend WithEvents LinkLabel1 As LinkLabel
    Friend WithEvents txtCodPatrocinador As TextBox
    Friend WithEvents cmsEscogerLogo As ContextMenuStrip
    Friend WithEvents SeleccionarLogoToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SalirToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ttpToolTip As ToolTip
    Friend WithEvents erProveedorError As ErrorProvider
    Friend WithEvents IdPatrocinador As DataGridViewTextBoxColumn
    Friend WithEvents NombrePatrocinador As DataGridViewTextBoxColumn
    Friend WithEvents LogoPatrocinador As DataGridViewImageColumn
End Class
