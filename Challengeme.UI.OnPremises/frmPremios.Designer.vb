<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmPremios
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmPremios))
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.ToolStripBtnSalir = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripBtnActualizar = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripBtnBuscar = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripBtnGuardar = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripBtnNuevo = New System.Windows.Forms.ToolStripButton()
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.ToolStripBtnEliminar = New System.Windows.Forms.ToolStripButton()
        Me.cboPermisosCategoria = New System.Windows.Forms.ComboBox()
        Me.txtUsuario = New System.Windows.Forms.TextBox()
        Me.dgvListaPremios = New System.Windows.Forms.DataGridView()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Descripcion = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GroupBoxDireccionEntidad = New System.Windows.Forms.GroupBox()
        Me.txtDescripcionPremio = New System.Windows.Forms.TextBox()
        Me.txtNombrePremio = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtIdPremio = New System.Windows.Forms.TextBox()
        Me.LabelNombreEntidad = New System.Windows.Forms.Label()
        Me.LabelIdEntidad = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.erProveedorError = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.ToolStrip1.SuspendLayout
        CType(Me.dgvListaPremios,System.ComponentModel.ISupportInitialize).BeginInit
        Me.GroupBoxDireccionEntidad.SuspendLayout
        CType(Me.erProveedorError,System.ComponentModel.ISupportInitialize).BeginInit
        Me.SuspendLayout
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
        'ToolStripBtnActualizar
        '
        Me.ToolStripBtnActualizar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9!)
        Me.ToolStripBtnActualizar.Image = CType(resources.GetObject("ToolStripBtnActualizar.Image"),System.Drawing.Image)
        Me.ToolStripBtnActualizar.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.ToolStripBtnActualizar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripBtnActualizar.Name = "ToolStripBtnActualizar"
        Me.ToolStripBtnActualizar.Size = New System.Drawing.Size(128, 68)
        Me.ToolStripBtnActualizar.Text = "Actualizar"
        '
        'ToolStripBtnBuscar
        '
        Me.ToolStripBtnBuscar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9!)
        Me.ToolStripBtnBuscar.Image = CType(resources.GetObject("ToolStripBtnBuscar.Image"),System.Drawing.Image)
        Me.ToolStripBtnBuscar.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.ToolStripBtnBuscar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripBtnBuscar.Name = "ToolStripBtnBuscar"
        Me.ToolStripBtnBuscar.Size = New System.Drawing.Size(113, 68)
        Me.ToolStripBtnBuscar.Text = "Buscar"
        '
        'ToolStripBtnGuardar
        '
        Me.ToolStripBtnGuardar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9!)
        Me.ToolStripBtnGuardar.Image = CType(resources.GetObject("ToolStripBtnGuardar.Image"),System.Drawing.Image)
        Me.ToolStripBtnGuardar.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.ToolStripBtnGuardar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripBtnGuardar.Name = "ToolStripBtnGuardar"
        Me.ToolStripBtnGuardar.Size = New System.Drawing.Size(120, 68)
        Me.ToolStripBtnGuardar.Text = "Guardar"
        '
        'ToolStripBtnNuevo
        '
        Me.ToolStripBtnNuevo.Font = New System.Drawing.Font("Microsoft Sans Serif", 9!)
        Me.ToolStripBtnNuevo.Image = CType(resources.GetObject("ToolStripBtnNuevo.Image"),System.Drawing.Image)
        Me.ToolStripBtnNuevo.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.ToolStripBtnNuevo.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripBtnNuevo.Name = "ToolStripBtnNuevo"
        Me.ToolStripBtnNuevo.Size = New System.Drawing.Size(110, 68)
        Me.ToolStripBtnNuevo.Text = "Nuevo"
        '
        'ToolStrip1
        '
        Me.ToolStrip1.BackColor = System.Drawing.Color.White
        Me.ToolStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
        Me.ToolStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripBtnNuevo, Me.ToolStripBtnGuardar, Me.ToolStripBtnBuscar, Me.ToolStripBtnActualizar, Me.ToolStripBtnEliminar, Me.ToolStripBtnSalir})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.System
        Me.ToolStrip1.Size = New System.Drawing.Size(688, 71)
        Me.ToolStrip1.TabIndex = 57
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'ToolStripBtnEliminar
        '
        Me.ToolStripBtnEliminar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9!)
        Me.ToolStripBtnEliminar.Image = CType(resources.GetObject("ToolStripBtnEliminar.Image"),System.Drawing.Image)
        Me.ToolStripBtnEliminar.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.ToolStripBtnEliminar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripBtnEliminar.Name = "ToolStripBtnEliminar"
        Me.ToolStripBtnEliminar.Size = New System.Drawing.Size(121, 68)
        Me.ToolStripBtnEliminar.Text = "Eliminar"
        '
        'cboPermisosCategoria
        '
        Me.cboPermisosCategoria.FormattingEnabled = true
        Me.cboPermisosCategoria.Location = New System.Drawing.Point(194, 275)
        Me.cboPermisosCategoria.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.cboPermisosCategoria.Name = "cboPermisosCategoria"
        Me.cboPermisosCategoria.Size = New System.Drawing.Size(18, 21)
        Me.cboPermisosCategoria.TabIndex = 56
        Me.cboPermisosCategoria.Visible = false
        '
        'txtUsuario
        '
        Me.txtUsuario.Location = New System.Drawing.Point(214, 276)
        Me.txtUsuario.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.txtUsuario.Name = "txtUsuario"
        Me.txtUsuario.Size = New System.Drawing.Size(16, 20)
        Me.txtUsuario.TabIndex = 55
        Me.txtUsuario.Visible = false
        '
        'dgvListaPremios
        '
        Me.dgvListaPremios.AllowUserToAddRows = false
        Me.dgvListaPremios.AllowUserToDeleteRows = false
        Me.dgvListaPremios.BackgroundColor = System.Drawing.Color.White
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvListaPremios.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.dgvListaPremios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvListaPremios.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column1, Me.Column2, Me.Descripcion})
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvListaPremios.DefaultCellStyle = DataGridViewCellStyle2
        Me.dgvListaPremios.Location = New System.Drawing.Point(100, 319)
        Me.dgvListaPremios.Margin = New System.Windows.Forms.Padding(2)
        Me.dgvListaPremios.Name = "dgvListaPremios"
        Me.dgvListaPremios.ReadOnly = true
        Me.dgvListaPremios.RowTemplate.Height = 24
        Me.dgvListaPremios.Size = New System.Drawing.Size(565, 108)
        Me.dgvListaPremios.TabIndex = 54
        '
        'Column1
        '
        Me.Column1.HeaderText = "Id "
        Me.Column1.Name = "Column1"
        Me.Column1.ReadOnly = true
        Me.Column1.Width = 80
        '
        'Column2
        '
        Me.Column2.HeaderText = "Nombre"
        Me.Column2.Name = "Column2"
        Me.Column2.ReadOnly = true
        Me.Column2.Width = 200
        '
        'Descripcion
        '
        Me.Descripcion.HeaderText = "Descripción"
        Me.Descripcion.Name = "Descripcion"
        Me.Descripcion.ReadOnly = true
        Me.Descripcion.Width = 300
        '
        'GroupBoxDireccionEntidad
        '
        Me.GroupBoxDireccionEntidad.Controls.Add(Me.txtDescripcionPremio)
        Me.GroupBoxDireccionEntidad.Controls.Add(Me.txtNombrePremio)
        Me.GroupBoxDireccionEntidad.Controls.Add(Me.Label1)
        Me.GroupBoxDireccionEntidad.Controls.Add(Me.txtIdPremio)
        Me.GroupBoxDireccionEntidad.Controls.Add(Me.LabelNombreEntidad)
        Me.GroupBoxDireccionEntidad.Controls.Add(Me.LabelIdEntidad)
        Me.GroupBoxDireccionEntidad.Font = New System.Drawing.Font("Microsoft Sans Serif", 12!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.GroupBoxDireccionEntidad.Location = New System.Drawing.Point(188, 107)
        Me.GroupBoxDireccionEntidad.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.GroupBoxDireccionEntidad.Name = "GroupBoxDireccionEntidad"
        Me.GroupBoxDireccionEntidad.Padding = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.GroupBoxDireccionEntidad.Size = New System.Drawing.Size(291, 167)
        Me.GroupBoxDireccionEntidad.TabIndex = 53
        Me.GroupBoxDireccionEntidad.TabStop = false
        Me.GroupBoxDireccionEntidad.Text = "Premios"
        '
        'txtDescripcionPremio
        '
        Me.txtDescripcionPremio.Font = New System.Drawing.Font("Microsoft Sans Serif", 9!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.txtDescripcionPremio.Location = New System.Drawing.Point(82, 86)
        Me.txtDescripcionPremio.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.txtDescripcionPremio.Multiline = true
        Me.txtDescripcionPremio.Name = "txtDescripcionPremio"
        Me.txtDescripcionPremio.Size = New System.Drawing.Size(185, 64)
        Me.txtDescripcionPremio.TabIndex = 2
        '
        'txtNombrePremio
        '
        Me.txtNombrePremio.Font = New System.Drawing.Font("Microsoft Sans Serif", 9!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.txtNombrePremio.Location = New System.Drawing.Point(82, 56)
        Me.txtNombrePremio.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.txtNombrePremio.Name = "txtNombrePremio"
        Me.txtNombrePremio.Size = New System.Drawing.Size(185, 21)
        Me.txtNombrePremio.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = true
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.Label1.Location = New System.Drawing.Point(16, 86)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(63, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Descripción"
        '
        'txtIdPremio
        '
        Me.txtIdPremio.Font = New System.Drawing.Font("Microsoft Sans Serif", 9!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.txtIdPremio.Location = New System.Drawing.Point(82, 27)
        Me.txtIdPremio.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.txtIdPremio.Name = "txtIdPremio"
        Me.txtIdPremio.Size = New System.Drawing.Size(185, 21)
        Me.txtIdPremio.TabIndex = 7
        '
        'LabelNombreEntidad
        '
        Me.LabelNombreEntidad.AutoSize = true
        Me.LabelNombreEntidad.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.LabelNombreEntidad.Location = New System.Drawing.Point(16, 56)
        Me.LabelNombreEntidad.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.LabelNombreEntidad.Name = "LabelNombreEntidad"
        Me.LabelNombreEntidad.Size = New System.Drawing.Size(44, 13)
        Me.LabelNombreEntidad.TabIndex = 1
        Me.LabelNombreEntidad.Text = "Nombre"
        '
        'LabelIdEntidad
        '
        Me.LabelIdEntidad.AutoSize = true
        Me.LabelIdEntidad.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.LabelIdEntidad.Location = New System.Drawing.Point(16, 29)
        Me.LabelIdEntidad.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.LabelIdEntidad.Name = "LabelIdEntidad"
        Me.LabelIdEntidad.Size = New System.Drawing.Size(56, 13)
        Me.LabelIdEntidad.TabIndex = 0
        Me.LabelIdEntidad.Text = "ID. Premio"
        '
        'Label10
        '
        Me.Label10.AutoSize = true
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.Label10.ForeColor = System.Drawing.SystemColors.ButtonShadow
        Me.Label10.Location = New System.Drawing.Point(96, 72)
        Me.Label10.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(234, 24)
        Me.Label10.TabIndex = 58
        Me.Label10.Text = "Mantenimiento de premios"
        '
        'erProveedorError
        '
        Me.erProveedorError.ContainerControl = Me
        '
        'frmPremios
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6!, 13!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(688, 455)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Controls.Add(Me.cboPermisosCategoria)
        Me.Controls.Add(Me.txtUsuario)
        Me.Controls.Add(Me.dgvListaPremios)
        Me.Controls.Add(Me.GroupBoxDireccionEntidad)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"),System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.Name = "frmPremios"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Premios"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.ToolStrip1.ResumeLayout(false)
        Me.ToolStrip1.PerformLayout
        CType(Me.dgvListaPremios,System.ComponentModel.ISupportInitialize).EndInit
        Me.GroupBoxDireccionEntidad.ResumeLayout(false)
        Me.GroupBoxDireccionEntidad.PerformLayout
        CType(Me.erProveedorError,System.ComponentModel.ISupportInitialize).EndInit
        Me.ResumeLayout(false)
        Me.PerformLayout

End Sub

    Friend WithEvents ToolStripBtnSalir As ToolStripButton
    Friend WithEvents ToolStripBtnActualizar As ToolStripButton
    Friend WithEvents ToolStripBtnBuscar As ToolStripButton
    Friend WithEvents ToolStripBtnGuardar As ToolStripButton
    Friend WithEvents ToolStripBtnNuevo As ToolStripButton
    Friend WithEvents ToolStrip1 As ToolStrip
    Friend WithEvents ToolStripBtnEliminar As ToolStripButton
    Friend WithEvents cboPermisosCategoria As ComboBox
    Friend WithEvents txtUsuario As TextBox
    Friend WithEvents dgvListaPremios As DataGridView
    Friend WithEvents GroupBoxDireccionEntidad As GroupBox
    Friend WithEvents txtNombrePremio As TextBox
    Friend WithEvents txtIdPremio As TextBox
    Friend WithEvents LabelNombreEntidad As Label
    Friend WithEvents LabelIdEntidad As Label
    Friend WithEvents txtDescripcionPremio As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Column1 As DataGridViewTextBoxColumn
    Friend WithEvents Column2 As DataGridViewTextBoxColumn
    Friend WithEvents Descripcion As DataGridViewTextBoxColumn
    Friend WithEvents erProveedorError As ErrorProvider
End Class
