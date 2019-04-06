<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmModalCrearProducto
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
        Me.picLogoProducto = New System.Windows.Forms.PictureBox()
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
        Me.btnGuardar = New System.Windows.Forms.Button()
        Me.erProveedorError = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.cmsEscogerFotografia = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.SeleccionarLogoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SalirToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ttpToolTip = New System.Windows.Forms.ToolTip(Me.components)
        CType(Me.picLogoProducto,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.dgvProducto,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.erProveedorError,System.ComponentModel.ISupportInitialize).BeginInit
        Me.cmsEscogerFotografia.SuspendLayout
        Me.SuspendLayout
        '
        'picLogoProducto
        '
        Me.picLogoProducto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.picLogoProducto.ContextMenuStrip = Me.cmsEscogerFotografia
        Me.picLogoProducto.Location = New System.Drawing.Point(477, 45)
        Me.picLogoProducto.Name = "picLogoProducto"
        Me.picLogoProducto.Size = New System.Drawing.Size(159, 111)
        Me.picLogoProducto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picLogoProducto.TabIndex = 38
        Me.picLogoProducto.TabStop = false
        Me.ttpToolTip.SetToolTip(Me.picLogoProducto, "Clic drecho para seleccionar logo")
        '
        'txtCostoProducto
        '
        Me.txtCostoProducto.Location = New System.Drawing.Point(205, 150)
        Me.txtCostoProducto.Name = "txtCostoProducto"
        Me.txtCostoProducto.Size = New System.Drawing.Size(172, 20)
        Me.txtCostoProducto.TabIndex = 32
        '
        'lblCostoProducto
        '
        Me.lblCostoProducto.AutoSize = true
        Me.lblCostoProducto.Location = New System.Drawing.Point(150, 159)
        Me.lblCostoProducto.Name = "lblCostoProducto"
        Me.lblCostoProducto.Size = New System.Drawing.Size(34, 13)
        Me.lblCostoProducto.TabIndex = 37
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
        Me.dgvProducto.Location = New System.Drawing.Point(137, 281)
        Me.dgvProducto.Name = "dgvProducto"
        Me.dgvProducto.ReadOnly = true
        Me.dgvProducto.Size = New System.Drawing.Size(499, 168)
        Me.dgvProducto.TabIndex = 36
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
        Me.lblLogo.Location = New System.Drawing.Point(528, 27)
        Me.lblLogo.Name = "lblLogo"
        Me.lblLogo.Size = New System.Drawing.Size(35, 15)
        Me.lblLogo.TabIndex = 35
        Me.lblLogo.Text = "Logo"
        '
        'btnAgregarLogo
        '
        Me.btnAgregarLogo.Font = New System.Drawing.Font("Microsoft Sans Serif", 9!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.btnAgregarLogo.Image = Global.Challengeme.UI.OnPremises.My.Resources.Resources.SelectPicture
        Me.btnAgregarLogo.Location = New System.Drawing.Point(496, 162)
        Me.btnAgregarLogo.Name = "btnAgregarLogo"
        Me.btnAgregarLogo.Size = New System.Drawing.Size(112, 87)
        Me.btnAgregarLogo.TabIndex = 33
        Me.btnAgregarLogo.Text = "Seleccionar logo"
        Me.btnAgregarLogo.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.ttpToolTip.SetToolTip(Me.btnAgregarLogo, "Seleccionar un logo para el producto")
        Me.btnAgregarLogo.UseVisualStyleBackColor = true
        '
        'txtNombreProducto
        '
        Me.txtNombreProducto.Location = New System.Drawing.Point(205, 122)
        Me.txtNombreProducto.Name = "txtNombreProducto"
        Me.txtNombreProducto.Size = New System.Drawing.Size(264, 20)
        Me.txtNombreProducto.TabIndex = 31
        '
        'lblNombreProducto
        '
        Me.lblNombreProducto.AutoSize = true
        Me.lblNombreProducto.Location = New System.Drawing.Point(137, 129)
        Me.lblNombreProducto.Name = "lblNombreProducto"
        Me.lblNombreProducto.Size = New System.Drawing.Size(47, 13)
        Me.lblNombreProducto.TabIndex = 34
        Me.lblNombreProducto.Text = "Nombre "
        '
        'txtIDProducto
        '
        Me.txtIDProducto.Location = New System.Drawing.Point(205, 94)
        Me.txtIDProducto.Name = "txtIDProducto"
        Me.txtIDProducto.Size = New System.Drawing.Size(172, 20)
        Me.txtIDProducto.TabIndex = 29
        '
        'lblID_Producto
        '
        Me.lblID_Producto.AutoSize = true
        Me.lblID_Producto.Location = New System.Drawing.Point(120, 101)
        Me.lblID_Producto.Name = "lblID_Producto"
        Me.lblID_Producto.Size = New System.Drawing.Size(64, 13)
        Me.lblID_Producto.TabIndex = 30
        Me.lblID_Producto.Text = "ID Producto"
        '
        'btnGuardar
        '
        Me.btnGuardar.Location = New System.Drawing.Point(384, 78)
        Me.btnGuardar.Name = "btnGuardar"
        Me.btnGuardar.Size = New System.Drawing.Size(84, 35)
        Me.btnGuardar.TabIndex = 39
        Me.btnGuardar.Text = "Guardar"
        Me.ttpToolTip.SetToolTip(Me.btnGuardar, "Crea un nuevo producto")
        Me.btnGuardar.UseVisualStyleBackColor = true
        '
        'erProveedorError
        '
        Me.erProveedorError.ContainerControl = Me
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
        'ttpToolTip
        '
        Me.ttpToolTip.AutoPopDelay = 5000
        Me.ttpToolTip.InitialDelay = 100
        Me.ttpToolTip.IsBalloon = true
        Me.ttpToolTip.ReshowDelay = 100
        Me.ttpToolTip.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info
        Me.ttpToolTip.ToolTipTitle = "Atención"
        '
        'frmModalCrearProducto
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6!, 13!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(713, 479)
        Me.Controls.Add(Me.btnGuardar)
        Me.Controls.Add(Me.picLogoProducto)
        Me.Controls.Add(Me.txtCostoProducto)
        Me.Controls.Add(Me.lblCostoProducto)
        Me.Controls.Add(Me.dgvProducto)
        Me.Controls.Add(Me.lblLogo)
        Me.Controls.Add(Me.btnAgregarLogo)
        Me.Controls.Add(Me.txtNombreProducto)
        Me.Controls.Add(Me.lblNombreProducto)
        Me.Controls.Add(Me.txtIDProducto)
        Me.Controls.Add(Me.lblID_Producto)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "frmModalCrearProducto"
        Me.Text = "Modal crear producto"
        CType(Me.picLogoProducto,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.dgvProducto,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.erProveedorError,System.ComponentModel.ISupportInitialize).EndInit
        Me.cmsEscogerFotografia.ResumeLayout(false)
        Me.ResumeLayout(false)
        Me.PerformLayout

End Sub

    Friend WithEvents picLogoProducto As PictureBox
    Friend WithEvents txtCostoProducto As TextBox
    Friend WithEvents lblCostoProducto As Label
    Friend WithEvents dgvProducto As DataGridView
    Friend WithEvents ID_PRODUCTO As DataGridViewTextBoxColumn
    Friend WithEvents NOMBRE_PRODUCTO As DataGridViewTextBoxColumn
    Friend WithEvents COSTO_PRODUCTO As DataGridViewTextBoxColumn
    Friend WithEvents LOGO_PRODUCTO As DataGridViewImageColumn
    Friend WithEvents lblLogo As Label
    Friend WithEvents btnAgregarLogo As Button
    Friend WithEvents txtNombreProducto As TextBox
    Friend WithEvents lblNombreProducto As Label
    Friend WithEvents txtIDProducto As TextBox
    Friend WithEvents lblID_Producto As Label
    Friend WithEvents btnGuardar As Button
    Friend WithEvents erProveedorError As ErrorProvider
    Friend WithEvents cmsEscogerFotografia As ContextMenuStrip
    Friend WithEvents SeleccionarLogoToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SalirToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ttpToolTip As ToolTip
End Class
