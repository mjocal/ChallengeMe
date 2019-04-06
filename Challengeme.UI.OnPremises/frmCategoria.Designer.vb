<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmCategoria
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmCategoria))
        Me.LabelIdEntidad = New System.Windows.Forms.Label()
        Me.LabelNombreEntidad = New System.Windows.Forms.Label()
        Me.txtIdCategoria = New System.Windows.Forms.TextBox()
        Me.txtNombreCategoria = New System.Windows.Forms.TextBox()
        Me.GroupBoxDireccionEntidad = New System.Windows.Forms.GroupBox()
        Me.dgvListaCategorias = New System.Windows.Forms.DataGridView()
        Me.txtUsuario = New System.Windows.Forms.TextBox()
        Me.cboPermisosCategoria = New System.Windows.Forms.ComboBox()
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.ToolStripBtnNuevo = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripBtnGuardar = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripBtnBuscar = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripBtnActualizar = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripBtnEliminar = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripBtnSalir = New System.Windows.Forms.ToolStripButton()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GroupBoxDireccionEntidad.SuspendLayout
        CType(Me.dgvListaCategorias,System.ComponentModel.ISupportInitialize).BeginInit
        Me.ToolStrip1.SuspendLayout
        Me.SuspendLayout
        '
        'LabelIdEntidad
        '
        Me.LabelIdEntidad.AutoSize = true
        Me.LabelIdEntidad.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.LabelIdEntidad.Location = New System.Drawing.Point(21, 33)
        Me.LabelIdEntidad.Name = "LabelIdEntidad"
        Me.LabelIdEntidad.Size = New System.Drawing.Size(71, 13)
        Me.LabelIdEntidad.TabIndex = 0
        Me.LabelIdEntidad.Text = "ID. Categoría"
        '
        'LabelNombreEntidad
        '
        Me.LabelNombreEntidad.AutoSize = true
        Me.LabelNombreEntidad.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.LabelNombreEntidad.Location = New System.Drawing.Point(21, 63)
        Me.LabelNombreEntidad.Name = "LabelNombreEntidad"
        Me.LabelNombreEntidad.Size = New System.Drawing.Size(44, 13)
        Me.LabelNombreEntidad.TabIndex = 1
        Me.LabelNombreEntidad.Text = "Nombre"
        '
        'txtIdCategoria
        '
        Me.txtIdCategoria.Font = New System.Drawing.Font("Microsoft Sans Serif", 9!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.txtIdCategoria.Location = New System.Drawing.Point(100, 29)
        Me.txtIdCategoria.Name = "txtIdCategoria"
        Me.txtIdCategoria.Size = New System.Drawing.Size(172, 21)
        Me.txtIdCategoria.TabIndex = 7
        '
        'txtNombreCategoria
        '
        Me.txtNombreCategoria.Font = New System.Drawing.Font("Microsoft Sans Serif", 9!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.txtNombreCategoria.Location = New System.Drawing.Point(101, 62)
        Me.txtNombreCategoria.Name = "txtNombreCategoria"
        Me.txtNombreCategoria.Size = New System.Drawing.Size(171, 21)
        Me.txtNombreCategoria.TabIndex = 8
        '
        'GroupBoxDireccionEntidad
        '
        Me.GroupBoxDireccionEntidad.Controls.Add(Me.txtNombreCategoria)
        Me.GroupBoxDireccionEntidad.Controls.Add(Me.txtIdCategoria)
        Me.GroupBoxDireccionEntidad.Controls.Add(Me.LabelNombreEntidad)
        Me.GroupBoxDireccionEntidad.Controls.Add(Me.LabelIdEntidad)
        Me.GroupBoxDireccionEntidad.Font = New System.Drawing.Font("Microsoft Sans Serif", 12!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.GroupBoxDireccionEntidad.Location = New System.Drawing.Point(166, 141)
        Me.GroupBoxDireccionEntidad.Name = "GroupBoxDireccionEntidad"
        Me.GroupBoxDireccionEntidad.Size = New System.Drawing.Size(327, 98)
        Me.GroupBoxDireccionEntidad.TabIndex = 4
        Me.GroupBoxDireccionEntidad.TabStop = false
        Me.GroupBoxDireccionEntidad.Text = "Categorías"
        '
        'dgvListaCategorias
        '
        Me.dgvListaCategorias.AllowUserToAddRows = false
        Me.dgvListaCategorias.AllowUserToDeleteRows = false
        Me.dgvListaCategorias.BackgroundColor = System.Drawing.Color.White
        Me.dgvListaCategorias.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvListaCategorias.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column1, Me.Column2})
        Me.dgvListaCategorias.Location = New System.Drawing.Point(166, 306)
        Me.dgvListaCategorias.Margin = New System.Windows.Forms.Padding(2)
        Me.dgvListaCategorias.Name = "dgvListaCategorias"
        Me.dgvListaCategorias.ReadOnly = true
        Me.dgvListaCategorias.RowTemplate.Height = 24
        Me.dgvListaCategorias.Size = New System.Drawing.Size(428, 185)
        Me.dgvListaCategorias.TabIndex = 5
        '
        'txtUsuario
        '
        Me.txtUsuario.Location = New System.Drawing.Point(205, 265)
        Me.txtUsuario.Name = "txtUsuario"
        Me.txtUsuario.Size = New System.Drawing.Size(20, 20)
        Me.txtUsuario.TabIndex = 6
        Me.txtUsuario.Visible = false
        '
        'cboPermisosCategoria
        '
        Me.cboPermisosCategoria.FormattingEnabled = true
        Me.cboPermisosCategoria.Location = New System.Drawing.Point(176, 264)
        Me.cboPermisosCategoria.Name = "cboPermisosCategoria"
        Me.cboPermisosCategoria.Size = New System.Drawing.Size(23, 21)
        Me.cboPermisosCategoria.TabIndex = 7
        Me.cboPermisosCategoria.Visible = false
        '
        'ToolStrip1
        '
        Me.ToolStrip1.BackColor = System.Drawing.Color.White
        Me.ToolStrip1.Dock = System.Windows.Forms.DockStyle.None
        Me.ToolStrip1.Font = New System.Drawing.Font("Open Sans", 9!)
        Me.ToolStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
        Me.ToolStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripBtnNuevo, Me.ToolStripBtnGuardar, Me.ToolStripBtnBuscar, Me.ToolStripBtnActualizar, Me.ToolStripBtnEliminar, Me.ToolStripBtnSalir})
        Me.ToolStrip1.Location = New System.Drawing.Point(30, 9)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.System
        Me.ToolStrip1.Size = New System.Drawing.Size(595, 71)
        Me.ToolStrip1.TabIndex = 52
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'ToolStripBtnNuevo
        '
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
        Me.ToolStripBtnGuardar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.ToolStripBtnGuardar.Image = CType(resources.GetObject("ToolStripBtnGuardar.Image"),System.Drawing.Image)
        Me.ToolStripBtnGuardar.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.ToolStripBtnGuardar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripBtnGuardar.Name = "ToolStripBtnGuardar"
        Me.ToolStripBtnGuardar.Size = New System.Drawing.Size(120, 68)
        Me.ToolStripBtnGuardar.Text = "Guardar"
        '
        'ToolStripBtnBuscar
        '
        Me.ToolStripBtnBuscar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.ToolStripBtnBuscar.Image = CType(resources.GetObject("ToolStripBtnBuscar.Image"),System.Drawing.Image)
        Me.ToolStripBtnBuscar.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.ToolStripBtnBuscar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripBtnBuscar.Name = "ToolStripBtnBuscar"
        Me.ToolStripBtnBuscar.Size = New System.Drawing.Size(113, 68)
        Me.ToolStripBtnBuscar.Text = "Buscar"
        '
        'ToolStripBtnActualizar
        '
        Me.ToolStripBtnActualizar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.ToolStripBtnActualizar.Image = CType(resources.GetObject("ToolStripBtnActualizar.Image"),System.Drawing.Image)
        Me.ToolStripBtnActualizar.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.ToolStripBtnActualizar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripBtnActualizar.Name = "ToolStripBtnActualizar"
        Me.ToolStripBtnActualizar.Size = New System.Drawing.Size(128, 68)
        Me.ToolStripBtnActualizar.Text = "Actualizar"
        '
        'ToolStripBtnEliminar
        '
        Me.ToolStripBtnEliminar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.ToolStripBtnEliminar.Image = CType(resources.GetObject("ToolStripBtnEliminar.Image"),System.Drawing.Image)
        Me.ToolStripBtnEliminar.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.ToolStripBtnEliminar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripBtnEliminar.Name = "ToolStripBtnEliminar"
        Me.ToolStripBtnEliminar.Size = New System.Drawing.Size(121, 68)
        Me.ToolStripBtnEliminar.Text = "Eliminar"
        '
        'ToolStripBtnSalir
        '
        Me.ToolStripBtnSalir.Font = New System.Drawing.Font("Microsoft Sans Serif", 9!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.ToolStripBtnSalir.Image = Global.Challengeme.UI.OnPremises.My.Resources.Resources.application_exit
        Me.ToolStripBtnSalir.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.ToolStripBtnSalir.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripBtnSalir.Name = "ToolStripBtnSalir"
        Me.ToolStripBtnSalir.Size = New System.Drawing.Size(84, 68)
        Me.ToolStripBtnSalir.Text = "Salir"
        Me.ToolStripBtnSalir.Visible = false
        '
        'Label10
        '
        Me.Label10.AutoSize = true
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.Label10.ForeColor = System.Drawing.SystemColors.ButtonShadow
        Me.Label10.Location = New System.Drawing.Point(26, 87)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(252, 24)
        Me.Label10.TabIndex = 54
        Me.Label10.Text = "Mantenimiento de categorías"
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
        Me.Column2.Width = 300
        '
        'frmCategoria
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6!, 13!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(708, 502)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Controls.Add(Me.cboPermisosCategoria)
        Me.Controls.Add(Me.txtUsuario)
        Me.Controls.Add(Me.dgvListaCategorias)
        Me.Controls.Add(Me.GroupBoxDireccionEntidad)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"),System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.Name = "frmCategoria"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Categorías"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.GroupBoxDireccionEntidad.ResumeLayout(false)
        Me.GroupBoxDireccionEntidad.PerformLayout
        CType(Me.dgvListaCategorias,System.ComponentModel.ISupportInitialize).EndInit
        Me.ToolStrip1.ResumeLayout(false)
        Me.ToolStrip1.PerformLayout
        Me.ResumeLayout(false)
        Me.PerformLayout

End Sub
    Friend WithEvents LabelIdEntidad As Label
    Friend WithEvents LabelNombreEntidad As Label
    Friend WithEvents txtIdCategoria As TextBox
    Friend WithEvents txtNombreCategoria As TextBox
    Friend WithEvents GroupBoxDireccionEntidad As GroupBox
    Friend WithEvents dgvListaCategorias As DataGridView
    Friend WithEvents txtUsuario As TextBox
    Friend WithEvents cboPermisosCategoria As ComboBox
    Friend WithEvents ToolStrip1 As ToolStrip
    Friend WithEvents ToolStripBtnNuevo As ToolStripButton
    Friend WithEvents ToolStripBtnGuardar As ToolStripButton
    Friend WithEvents ToolStripBtnBuscar As ToolStripButton
    Friend WithEvents ToolStripBtnActualizar As ToolStripButton
    Friend WithEvents ToolStripBtnEliminar As ToolStripButton
    Friend WithEvents ToolStripBtnSalir As ToolStripButton
    Friend WithEvents Label10 As Label
    Friend WithEvents Column1 As DataGridViewTextBoxColumn
    Friend WithEvents Column2 As DataGridViewTextBoxColumn
End Class
