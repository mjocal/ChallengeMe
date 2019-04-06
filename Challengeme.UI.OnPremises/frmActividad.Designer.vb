<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmActividad
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmActividad))
        Me.dgvListaActividades = New System.Windows.Forms.DataGridView()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GroupBoxDireccionEntidad = New System.Windows.Forms.GroupBox()
        Me.txtDescripcionActividad = New System.Windows.Forms.TextBox()
        Me.txtNombreActividad = New System.Windows.Forms.TextBox()
        Me.txtIdActividad = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.LabelNombreEntidad = New System.Windows.Forms.Label()
        Me.LabelIdEntidad = New System.Windows.Forms.Label()
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.ToolStripBtnNuevo = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripBtnGuardar = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripBtnBuscar = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripBtnActualizar = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripBtnEliminar = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripBtnSalir = New System.Windows.Forms.ToolStripButton()
        Me.Label10 = New System.Windows.Forms.Label()
        CType(Me.dgvListaActividades,System.ComponentModel.ISupportInitialize).BeginInit
        Me.GroupBoxDireccionEntidad.SuspendLayout
        Me.ToolStrip1.SuspendLayout
        Me.SuspendLayout
        '
        'dgvListaActividades
        '
        Me.dgvListaActividades.AllowUserToAddRows = false
        Me.dgvListaActividades.AllowUserToDeleteRows = false
        Me.dgvListaActividades.BackgroundColor = System.Drawing.Color.White
        Me.dgvListaActividades.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvListaActividades.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column1, Me.Column2, Me.Column3})
        Me.dgvListaActividades.Location = New System.Drawing.Point(108, 294)
        Me.dgvListaActividades.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.dgvListaActividades.Name = "dgvListaActividades"
        Me.dgvListaActividades.ReadOnly = true
        Me.dgvListaActividades.RowTemplate.Height = 24
        Me.dgvListaActividades.Size = New System.Drawing.Size(557, 221)
        Me.dgvListaActividades.TabIndex = 8
        '
        'Column1
        '
        Me.Column1.HeaderText = "Id "
        Me.Column1.Name = "Column1"
        Me.Column1.ReadOnly = true
        Me.Column1.Width = 60
        '
        'Column2
        '
        Me.Column2.HeaderText = "Nombre"
        Me.Column2.Name = "Column2"
        Me.Column2.ReadOnly = true
        Me.Column2.Width = 150
        '
        'Column3
        '
        Me.Column3.HeaderText = "Descripcion"
        Me.Column3.Name = "Column3"
        Me.Column3.ReadOnly = true
        Me.Column3.Width = 300
        '
        'GroupBoxDireccionEntidad
        '
        Me.GroupBoxDireccionEntidad.Controls.Add(Me.txtDescripcionActividad)
        Me.GroupBoxDireccionEntidad.Controls.Add(Me.txtNombreActividad)
        Me.GroupBoxDireccionEntidad.Controls.Add(Me.txtIdActividad)
        Me.GroupBoxDireccionEntidad.Controls.Add(Me.Label1)
        Me.GroupBoxDireccionEntidad.Controls.Add(Me.LabelNombreEntidad)
        Me.GroupBoxDireccionEntidad.Controls.Add(Me.LabelIdEntidad)
        Me.GroupBoxDireccionEntidad.Font = New System.Drawing.Font("Microsoft Sans Serif", 12!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.GroupBoxDireccionEntidad.Location = New System.Drawing.Point(220, 102)
        Me.GroupBoxDireccionEntidad.Name = "GroupBoxDireccionEntidad"
        Me.GroupBoxDireccionEntidad.Size = New System.Drawing.Size(312, 173)
        Me.GroupBoxDireccionEntidad.TabIndex = 7
        Me.GroupBoxDireccionEntidad.TabStop = false
        Me.GroupBoxDireccionEntidad.Text = "Actividad"
        '
        'txtDescripcionActividad
        '
        Me.txtDescripcionActividad.Font = New System.Drawing.Font("Microsoft Sans Serif", 9!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.txtDescripcionActividad.Location = New System.Drawing.Point(94, 98)
        Me.txtDescripcionActividad.Multiline = true
        Me.txtDescripcionActividad.Name = "txtDescripcionActividad"
        Me.txtDescripcionActividad.Size = New System.Drawing.Size(173, 62)
        Me.txtDescripcionActividad.TabIndex = 2
        '
        'txtNombreActividad
        '
        Me.txtNombreActividad.Font = New System.Drawing.Font("Microsoft Sans Serif", 9!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.txtNombreActividad.Location = New System.Drawing.Point(94, 63)
        Me.txtNombreActividad.Name = "txtNombreActividad"
        Me.txtNombreActividad.Size = New System.Drawing.Size(173, 21)
        Me.txtNombreActividad.TabIndex = 1
        '
        'txtIdActividad
        '
        Me.txtIdActividad.Font = New System.Drawing.Font("Microsoft Sans Serif", 9!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.txtIdActividad.Location = New System.Drawing.Point(94, 30)
        Me.txtIdActividad.Name = "txtIdActividad"
        Me.txtIdActividad.Size = New System.Drawing.Size(172, 21)
        Me.txtIdActividad.TabIndex = 7
        '
        'Label1
        '
        Me.Label1.AutoSize = true
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.Label1.Location = New System.Drawing.Point(21, 102)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(63, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Descripcion"
        '
        'LabelNombreEntidad
        '
        Me.LabelNombreEntidad.AutoSize = true
        Me.LabelNombreEntidad.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.LabelNombreEntidad.Location = New System.Drawing.Point(21, 67)
        Me.LabelNombreEntidad.Name = "LabelNombreEntidad"
        Me.LabelNombreEntidad.Size = New System.Drawing.Size(44, 13)
        Me.LabelNombreEntidad.TabIndex = 1
        Me.LabelNombreEntidad.Text = "Nombre"
        '
        'LabelIdEntidad
        '
        Me.LabelIdEntidad.AutoSize = true
        Me.LabelIdEntidad.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.LabelIdEntidad.Location = New System.Drawing.Point(21, 33)
        Me.LabelIdEntidad.Name = "LabelIdEntidad"
        Me.LabelIdEntidad.Size = New System.Drawing.Size(68, 13)
        Me.LabelIdEntidad.TabIndex = 0
        Me.LabelIdEntidad.Text = "ID. Actividad"
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
        Me.ToolStrip1.Size = New System.Drawing.Size(732, 71)
        Me.ToolStrip1.TabIndex = 52
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'ToolStripBtnNuevo
        '
        Me.ToolStripBtnNuevo.BackColor = System.Drawing.Color.White
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
        Me.Label10.Location = New System.Drawing.Point(104, 67)
        Me.Label10.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(259, 24)
        Me.Label10.TabIndex = 59
        Me.Label10.Text = "Mantenimiento de actividades"
        '
        'frmActividad
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6!, 13!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(732, 564)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Controls.Add(Me.dgvListaActividades)
        Me.Controls.Add(Me.GroupBoxDireccionEntidad)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"),System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.Name = "frmActividad"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Actividades"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.dgvListaActividades,System.ComponentModel.ISupportInitialize).EndInit
        Me.GroupBoxDireccionEntidad.ResumeLayout(false)
        Me.GroupBoxDireccionEntidad.PerformLayout
        Me.ToolStrip1.ResumeLayout(false)
        Me.ToolStrip1.PerformLayout
        Me.ResumeLayout(false)
        Me.PerformLayout

End Sub

    Friend WithEvents dgvListaActividades As DataGridView
    Friend WithEvents GroupBoxDireccionEntidad As GroupBox
    Friend WithEvents txtDescripcionActividad As TextBox
    Friend WithEvents txtNombreActividad As TextBox
    Friend WithEvents txtIdActividad As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents LabelNombreEntidad As Label
    Friend WithEvents LabelIdEntidad As Label
    Friend WithEvents ToolStrip1 As ToolStrip
    Friend WithEvents ToolStripBtnNuevo As ToolStripButton
    Friend WithEvents ToolStripBtnGuardar As ToolStripButton
    Friend WithEvents ToolStripBtnBuscar As ToolStripButton
    Friend WithEvents ToolStripBtnActualizar As ToolStripButton
    Friend WithEvents ToolStripBtnEliminar As ToolStripButton
    Friend WithEvents ToolStripBtnSalir As ToolStripButton
    Friend WithEvents Column1 As DataGridViewTextBoxColumn
    Friend WithEvents Column2 As DataGridViewTextBoxColumn
    Friend WithEvents Column3 As DataGridViewTextBoxColumn
    Friend WithEvents Label10 As Label
End Class
