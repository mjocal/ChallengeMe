<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmProducto
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmProducto))
        Me.gbProducto = New System.Windows.Forms.GroupBox()
        Me.picLogoProducto = New System.Windows.Forms.PictureBox()
        Me.cmsEscogerFotografia = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.SeleccionarLogoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SalirToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.txtCostoProducto = New System.Windows.Forms.TextBox()
        Me.lblCostoProducto = New System.Windows.Forms.Label()
        Me.dgvProducto = New System.Windows.Forms.DataGridView()
        Me.ID_PRODUCTO = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NOMBRE_PRODUCTO = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.COSTO_PRODUCTO = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.LOGO_PRODUCTO = New System.Windows.Forms.DataGridViewImageColumn()
        Me.lblLogo = New System.Windows.Forms.Label()
        Me.btnAgregarLogo = New System.Windows.Forms.Button()
        Me.txtNombreProducto = New System.Windows.Forms.TextBox()
        Me.lblNombreProducto = New System.Windows.Forms.Label()
        Me.txtIDProducto = New System.Windows.Forms.TextBox()
        Me.lblID_Producto = New System.Windows.Forms.Label()
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.ToolStripBtnNuevo = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripBtnGuardar = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripBtnBuscar = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripBtnEliminar = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripBtnActualizar = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripBtnSalir = New System.Windows.Forms.ToolStripButton()
        Me.cboPermisosProductos = New System.Windows.Forms.ComboBox()
        Me.ttpToolTip = New System.Windows.Forms.ToolTip(Me.components)
        Me.erProveedorError = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.gbProducto.SuspendLayout
        CType(Me.picLogoProducto,System.ComponentModel.ISupportInitialize).BeginInit
        Me.cmsEscogerFotografia.SuspendLayout
        CType(Me.dgvProducto,System.ComponentModel.ISupportInitialize).BeginInit
        Me.ToolStrip1.SuspendLayout
        CType(Me.erProveedorError,System.ComponentModel.ISupportInitialize).BeginInit
        Me.SuspendLayout
        '
        'gbProducto
        '
        Me.gbProducto.Controls.Add(Me.picLogoProducto)
        Me.gbProducto.Controls.Add(Me.txtCostoProducto)
        Me.gbProducto.Controls.Add(Me.lblCostoProducto)
        Me.gbProducto.Controls.Add(Me.dgvProducto)
        Me.gbProducto.Controls.Add(Me.lblLogo)
        Me.gbProducto.Controls.Add(Me.btnAgregarLogo)
        Me.gbProducto.Controls.Add(Me.txtNombreProducto)
        Me.gbProducto.Controls.Add(Me.lblNombreProducto)
        Me.gbProducto.Controls.Add(Me.txtIDProducto)
        Me.gbProducto.Controls.Add(Me.lblID_Producto)
        Me.gbProducto.Location = New System.Drawing.Point(36, 96)
        Me.gbProducto.Name = "gbProducto"
        Me.gbProducto.Size = New System.Drawing.Size(796, 490)
        Me.gbProducto.TabIndex = 0
        Me.gbProducto.TabStop = false
        Me.gbProducto.Text = "Registro de Productos"
        '
        'picLogoProducto
        '
        Me.picLogoProducto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.picLogoProducto.ContextMenuStrip = Me.cmsEscogerFotografia
        Me.picLogoProducto.Location = New System.Drawing.Point(606, 43)
        Me.picLogoProducto.Name = "picLogoProducto"
        Me.picLogoProducto.Size = New System.Drawing.Size(159, 111)
        Me.picLogoProducto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picLogoProducto.TabIndex = 28
        Me.picLogoProducto.TabStop = false
        Me.ttpToolTip.SetToolTip(Me.picLogoProducto, "Clic derecho para seleccionar logo")
        '
        'cmsEscogerFotografia
        '
        Me.cmsEscogerFotografia.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.SeleccionarLogoToolStripMenuItem, Me.SalirToolStripMenuItem})
        Me.cmsEscogerFotografia.Name = "cmsEscogerFotografia"
        Me.cmsEscogerFotografia.Size = New System.Drawing.Size(162, 48)
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
        'txtCostoProducto
        '
        Me.txtCostoProducto.Location = New System.Drawing.Point(175, 112)
        Me.txtCostoProducto.Name = "txtCostoProducto"
        Me.txtCostoProducto.Size = New System.Drawing.Size(172, 20)
        Me.txtCostoProducto.TabIndex = 3
        '
        'lblCostoProducto
        '
        Me.lblCostoProducto.AutoSize = true
        Me.lblCostoProducto.Location = New System.Drawing.Point(120, 121)
        Me.lblCostoProducto.Name = "lblCostoProducto"
        Me.lblCostoProducto.Size = New System.Drawing.Size(34, 13)
        Me.lblCostoProducto.TabIndex = 27
        Me.lblCostoProducto.Text = "Costo"
        '
        'dgvProducto
        '
        Me.dgvProducto.AllowUserToAddRows = false
        Me.dgvProducto.AllowUserToDeleteRows = false
        Me.dgvProducto.BackgroundColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvProducto.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.dgvProducto.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvProducto.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.ID_PRODUCTO, Me.NOMBRE_PRODUCTO, Me.COSTO_PRODUCTO, Me.LOGO_PRODUCTO})
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvProducto.DefaultCellStyle = DataGridViewCellStyle2
        Me.dgvProducto.Location = New System.Drawing.Point(110, 236)
        Me.dgvProducto.Name = "dgvProducto"
        Me.dgvProducto.ReadOnly = true
        Me.dgvProducto.Size = New System.Drawing.Size(499, 168)
        Me.dgvProducto.TabIndex = 22
        '
        'ID_PRODUCTO
        '
        Me.ID_PRODUCTO.HeaderText = "ID PRODDUCTO"
        Me.ID_PRODUCTO.Name = "ID_PRODUCTO"
        Me.ID_PRODUCTO.ReadOnly = true
        Me.ID_PRODUCTO.Visible = false
        '
        'NOMBRE_PRODUCTO
        '
        Me.NOMBRE_PRODUCTO.HeaderText = "Nombre"
        Me.NOMBRE_PRODUCTO.Name = "NOMBRE_PRODUCTO"
        Me.NOMBRE_PRODUCTO.ReadOnly = true
        Me.NOMBRE_PRODUCTO.Width = 250
        '
        'COSTO_PRODUCTO
        '
        Me.COSTO_PRODUCTO.HeaderText = "Costo"
        Me.COSTO_PRODUCTO.Name = "COSTO_PRODUCTO"
        Me.COSTO_PRODUCTO.ReadOnly = true
        '
        'LOGO_PRODUCTO
        '
        Me.LOGO_PRODUCTO.HeaderText = "Logo"
        Me.LOGO_PRODUCTO.Name = "LOGO_PRODUCTO"
        Me.LOGO_PRODUCTO.ReadOnly = true
        '
        'lblLogo
        '
        Me.lblLogo.AutoSize = true
        Me.lblLogo.Font = New System.Drawing.Font("Microsoft Sans Serif", 9!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.lblLogo.Location = New System.Drawing.Point(663, 12)
        Me.lblLogo.Name = "lblLogo"
        Me.lblLogo.Size = New System.Drawing.Size(35, 15)
        Me.lblLogo.TabIndex = 20
        Me.lblLogo.Text = "Logo"
        '
        'btnAgregarLogo
        '
        Me.btnAgregarLogo.Font = New System.Drawing.Font("Microsoft Sans Serif", 9!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.btnAgregarLogo.Image = Global.Challengeme.UI.OnPremises.My.Resources.Resources.SelectPicture
        Me.btnAgregarLogo.Location = New System.Drawing.Point(634, 169)
        Me.btnAgregarLogo.Name = "btnAgregarLogo"
        Me.btnAgregarLogo.Size = New System.Drawing.Size(112, 87)
        Me.btnAgregarLogo.TabIndex = 5
        Me.btnAgregarLogo.Text = "Seleccionar logo"
        Me.btnAgregarLogo.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnAgregarLogo.UseVisualStyleBackColor = true
        '
        'txtNombreProducto
        '
        Me.txtNombreProducto.Location = New System.Drawing.Point(175, 84)
        Me.txtNombreProducto.Name = "txtNombreProducto"
        Me.txtNombreProducto.Size = New System.Drawing.Size(264, 20)
        Me.txtNombreProducto.TabIndex = 2
        '
        'lblNombreProducto
        '
        Me.lblNombreProducto.AutoSize = true
        Me.lblNombreProducto.Location = New System.Drawing.Point(107, 91)
        Me.lblNombreProducto.Name = "lblNombreProducto"
        Me.lblNombreProducto.Size = New System.Drawing.Size(47, 13)
        Me.lblNombreProducto.TabIndex = 16
        Me.lblNombreProducto.Text = "Nombre "
        '
        'txtIDProducto
        '
        Me.txtIDProducto.Location = New System.Drawing.Point(175, 56)
        Me.txtIDProducto.Name = "txtIDProducto"
        Me.txtIDProducto.Size = New System.Drawing.Size(172, 20)
        Me.txtIDProducto.TabIndex = 1
        '
        'lblID_Producto
        '
        Me.lblID_Producto.AutoSize = true
        Me.lblID_Producto.Location = New System.Drawing.Point(90, 63)
        Me.lblID_Producto.Name = "lblID_Producto"
        Me.lblID_Producto.Size = New System.Drawing.Size(64, 13)
        Me.lblID_Producto.TabIndex = 1
        Me.lblID_Producto.Text = "ID Producto"
        '
        'ToolStrip1
        '
        Me.ToolStrip1.BackColor = System.Drawing.Color.White
        Me.ToolStrip1.Dock = System.Windows.Forms.DockStyle.None
        Me.ToolStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripBtnNuevo, Me.ToolStripBtnGuardar, Me.ToolStripBtnBuscar, Me.ToolStripBtnEliminar, Me.ToolStripBtnActualizar, Me.ToolStripBtnSalir})
        Me.ToolStrip1.Location = New System.Drawing.Point(36, 9)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.System
        Me.ToolStrip1.Size = New System.Drawing.Size(482, 71)
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
        Me.ToolStripBtnBuscar.Visible = false
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
        'cboPermisosProductos
        '
        Me.cboPermisosProductos.FormattingEnabled = true
        Me.cboPermisosProductos.Location = New System.Drawing.Point(12, 96)
        Me.cboPermisosProductos.Name = "cboPermisosProductos"
        Me.cboPermisosProductos.Size = New System.Drawing.Size(23, 21)
        Me.cboPermisosProductos.TabIndex = 53
        Me.cboPermisosProductos.Visible = false
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
        'frmProducto
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6!, 13!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(832, 613)
        Me.Controls.Add(Me.cboPermisosProductos)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Controls.Add(Me.gbProducto)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"),System.Drawing.Icon)
        Me.Name = "frmProducto"
        Me.Text = "Productos"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.gbProducto.ResumeLayout(false)
        Me.gbProducto.PerformLayout
        CType(Me.picLogoProducto,System.ComponentModel.ISupportInitialize).EndInit
        Me.cmsEscogerFotografia.ResumeLayout(false)
        CType(Me.dgvProducto,System.ComponentModel.ISupportInitialize).EndInit
        Me.ToolStrip1.ResumeLayout(false)
        Me.ToolStrip1.PerformLayout
        CType(Me.erProveedorError,System.ComponentModel.ISupportInitialize).EndInit
        Me.ResumeLayout(false)
        Me.PerformLayout

End Sub

    Friend WithEvents gbProducto As GroupBox
    Friend WithEvents txtIDProducto As TextBox
    Friend WithEvents lblID_Producto As Label
    Friend WithEvents btnAgregarLogo As Button
    Friend WithEvents txtNombreProducto As TextBox
    Friend WithEvents lblNombreProducto As Label
    Friend WithEvents lblLogo As Label
    Friend WithEvents ToolStrip1 As ToolStrip
    Friend WithEvents ToolStripBtnNuevo As ToolStripButton
    Friend WithEvents ToolStripBtnGuardar As ToolStripButton
    Friend WithEvents ToolStripBtnBuscar As ToolStripButton
    Friend WithEvents ToolStripBtnActualizar As ToolStripButton
    Friend WithEvents ToolStripBtnEliminar As ToolStripButton
    Friend WithEvents ToolStripBtnSalir As ToolStripButton
    Friend WithEvents cboPermisosProductos As ComboBox
    Friend WithEvents dgvProducto As DataGridView
    Friend WithEvents txtCostoProducto As TextBox
    Friend WithEvents lblCostoProducto As Label
    Friend WithEvents cmsEscogerFotografia As ContextMenuStrip
    Friend WithEvents SeleccionarLogoToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SalirToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ttpToolTip As ToolTip
    Friend WithEvents erProveedorError As ErrorProvider
    Friend WithEvents picLogoProducto As PictureBox
    Friend WithEvents ID_PRODUCTO As DataGridViewTextBoxColumn
    Friend WithEvents NOMBRE_PRODUCTO As DataGridViewTextBoxColumn
    Friend WithEvents COSTO_PRODUCTO As DataGridViewTextBoxColumn
    Friend WithEvents LOGO_PRODUCTO As DataGridViewImageColumn
End Class
