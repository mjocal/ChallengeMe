<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmInscripciones
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmInscripciones))
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.btnImprimir = New System.Windows.Forms.Button()
        Me.cboTipoInscripcion = New System.Windows.Forms.ComboBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.pbQR = New System.Windows.Forms.PictureBox()
        Me.cboUsuario = New System.Windows.Forms.ComboBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.cboEvento = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtIdInscripcion = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lblFecha = New System.Windows.Forms.Label()
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.ToolStripBtnNuevo = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripBtnGuardar = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripBtnBuscar = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripBtnActualizar = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripBtnEliminar = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripBtnSalir = New System.Windows.Forms.ToolStripButton()
        Me.erProveedorError = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.dgvListaInscripcionesEvento = New System.Windows.Forms.DataGridView()
        Me.IdInscripcion = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.IdEvento = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NombreEvento = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.IdUsuario = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Usuario = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TipoInscripcion = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cboCargarPermisos = New System.Windows.Forms.ComboBox()
        Me.GroupBox1.SuspendLayout
        CType(Me.pbQR,System.ComponentModel.ISupportInitialize).BeginInit
        Me.ToolStrip1.SuspendLayout
        CType(Me.erProveedorError,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.dgvListaInscripcionesEvento,System.ComponentModel.ISupportInitialize).BeginInit
        Me.SuspendLayout
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.btnImprimir)
        Me.GroupBox1.Controls.Add(Me.cboTipoInscripcion)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.pbQR)
        Me.GroupBox1.Controls.Add(Me.cboUsuario)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.cboEvento)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.txtIdInscripcion)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(86, 125)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(683, 256)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = false
        Me.GroupBox1.Text = "Mantenimiento de inscripciones a eventos"
        '
        'btnImprimir
        '
        Me.btnImprimir.Location = New System.Drawing.Point(527, 189)
        Me.btnImprimir.Name = "btnImprimir"
        Me.btnImprimir.Size = New System.Drawing.Size(91, 41)
        Me.btnImprimir.TabIndex = 9
        Me.btnImprimir.Text = "Imprimir"
        Me.btnImprimir.UseVisualStyleBackColor = true
        '
        'cboTipoInscripcion
        '
        Me.cboTipoInscripcion.FormattingEnabled = true
        Me.cboTipoInscripcion.Items.AddRange(New Object() {"INDIVIDUAL", "GRUPAL"})
        Me.cboTipoInscripcion.Location = New System.Drawing.Point(232, 181)
        Me.cboTipoInscripcion.Name = "cboTipoInscripcion"
        Me.cboTipoInscripcion.Size = New System.Drawing.Size(205, 28)
        Me.cboTipoInscripcion.TabIndex = 8
        '
        'Label4
        '
        Me.Label4.AutoSize = true
        Me.Label4.Location = New System.Drawing.Point(105, 189)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(117, 20)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "Tipo inscripción"
        '
        'pbQR
        '
        Me.pbQR.Location = New System.Drawing.Point(500, 34)
        Me.pbQR.Name = "pbQR"
        Me.pbQR.Size = New System.Drawing.Size(177, 130)
        Me.pbQR.TabIndex = 6
        Me.pbQR.TabStop = false
        '
        'cboUsuario
        '
        Me.cboUsuario.FormattingEnabled = true
        Me.cboUsuario.Location = New System.Drawing.Point(232, 136)
        Me.cboUsuario.Name = "cboUsuario"
        Me.cboUsuario.Size = New System.Drawing.Size(261, 28)
        Me.cboUsuario.TabIndex = 5
        '
        'Label3
        '
        Me.Label3.AutoSize = true
        Me.Label3.Location = New System.Drawing.Point(158, 142)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(64, 20)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Usuario"
        '
        'cboEvento
        '
        Me.cboEvento.FormattingEnabled = true
        Me.cboEvento.Location = New System.Drawing.Point(230, 95)
        Me.cboEvento.Name = "cboEvento"
        Me.cboEvento.Size = New System.Drawing.Size(264, 28)
        Me.cboEvento.TabIndex = 3
        '
        'Label2
        '
        Me.Label2.AutoSize = true
        Me.Label2.Location = New System.Drawing.Point(163, 100)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(59, 20)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Evento"
        '
        'txtIdInscripcion
        '
        Me.txtIdInscripcion.Location = New System.Drawing.Point(228, 61)
        Me.txtIdInscripcion.Name = "txtIdInscripcion"
        Me.txtIdInscripcion.Size = New System.Drawing.Size(114, 26)
        Me.txtIdInscripcion.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = true
        Me.Label1.Location = New System.Drawing.Point(119, 64)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(103, 20)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Id.Inscripción"
        '
        'lblFecha
        '
        Me.lblFecha.AutoSize = true
        Me.lblFecha.Font = New System.Drawing.Font("Microsoft Sans Serif", 12!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.lblFecha.Location = New System.Drawing.Point(706, 82)
        Me.lblFecha.Name = "lblFecha"
        Me.lblFecha.Size = New System.Drawing.Size(57, 20)
        Me.lblFecha.TabIndex = 1
        Me.lblFecha.Text = "Label4"
        '
        'ToolStrip1
        '
        Me.ToolStrip1.BackColor = System.Drawing.Color.White
        Me.ToolStrip1.Dock = System.Windows.Forms.DockStyle.None
        Me.ToolStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripBtnNuevo, Me.ToolStripBtnGuardar, Me.ToolStripBtnBuscar, Me.ToolStripBtnActualizar, Me.ToolStripBtnEliminar, Me.ToolStripBtnSalir})
        Me.ToolStrip1.Location = New System.Drawing.Point(60, 9)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.System
        Me.ToolStrip1.Size = New System.Drawing.Size(482, 71)
        Me.ToolStrip1.TabIndex = 53
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
        'erProveedorError
        '
        Me.erProveedorError.ContainerControl = Me
        '
        'dgvListaInscripcionesEvento
        '
        Me.dgvListaInscripcionesEvento.AllowUserToAddRows = false
        Me.dgvListaInscripcionesEvento.AllowUserToDeleteRows = false
        Me.dgvListaInscripcionesEvento.BackgroundColor = System.Drawing.Color.White
        Me.dgvListaInscripcionesEvento.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvListaInscripcionesEvento.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IdInscripcion, Me.IdEvento, Me.NombreEvento, Me.IdUsuario, Me.Usuario, Me.TipoInscripcion})
        Me.dgvListaInscripcionesEvento.Location = New System.Drawing.Point(86, 407)
        Me.dgvListaInscripcionesEvento.Name = "dgvListaInscripcionesEvento"
        Me.dgvListaInscripcionesEvento.ReadOnly = true
        Me.dgvListaInscripcionesEvento.Size = New System.Drawing.Size(683, 186)
        Me.dgvListaInscripcionesEvento.TabIndex = 54
        '
        'IdInscripcion
        '
        Me.IdInscripcion.HeaderText = "IdInscripción"
        Me.IdInscripcion.Name = "IdInscripcion"
        Me.IdInscripcion.ReadOnly = true
        Me.IdInscripcion.Visible = false
        '
        'IdEvento
        '
        Me.IdEvento.HeaderText = "IdEvento"
        Me.IdEvento.Name = "IdEvento"
        Me.IdEvento.ReadOnly = true
        Me.IdEvento.Visible = false
        '
        'NombreEvento
        '
        Me.NombreEvento.HeaderText = "Evento"
        Me.NombreEvento.Name = "NombreEvento"
        Me.NombreEvento.ReadOnly = true
        Me.NombreEvento.Width = 270
        '
        'IdUsuario
        '
        Me.IdUsuario.HeaderText = "IdUsuario"
        Me.IdUsuario.Name = "IdUsuario"
        Me.IdUsuario.ReadOnly = true
        Me.IdUsuario.Visible = false
        '
        'Usuario
        '
        Me.Usuario.HeaderText = "Participante"
        Me.Usuario.Name = "Usuario"
        Me.Usuario.ReadOnly = true
        Me.Usuario.Width = 270
        '
        'TipoInscripcion
        '
        Me.TipoInscripcion.HeaderText = "Tipo Inscripcion"
        Me.TipoInscripcion.Name = "TipoInscripcion"
        Me.TipoInscripcion.ReadOnly = true
        '
        'cboCargarPermisos
        '
        Me.cboCargarPermisos.FormattingEnabled = true
        Me.cboCargarPermisos.Location = New System.Drawing.Point(7, 127)
        Me.cboCargarPermisos.Name = "cboCargarPermisos"
        Me.cboCargarPermisos.Size = New System.Drawing.Size(64, 21)
        Me.cboCargarPermisos.TabIndex = 55
        Me.cboCargarPermisos.Visible = false
        '
        'frmInscripciones
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6!, 13!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(822, 747)
        Me.Controls.Add(Me.cboCargarPermisos)
        Me.Controls.Add(Me.dgvListaInscripcionesEvento)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Controls.Add(Me.lblFecha)
        Me.Controls.Add(Me.GroupBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmInscripciones"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Inscripciones"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.GroupBox1.ResumeLayout(false)
        Me.GroupBox1.PerformLayout
        CType(Me.pbQR,System.ComponentModel.ISupportInitialize).EndInit
        Me.ToolStrip1.ResumeLayout(false)
        Me.ToolStrip1.PerformLayout
        CType(Me.erProveedorError,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.dgvListaInscripcionesEvento,System.ComponentModel.ISupportInitialize).EndInit
        Me.ResumeLayout(false)
        Me.PerformLayout

End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents cboUsuario As ComboBox
    Friend WithEvents Label3 As Label
    Friend WithEvents cboEvento As ComboBox
    Friend WithEvents Label2 As Label
    Friend WithEvents txtIdInscripcion As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents lblFecha As Label
    Friend WithEvents pbQR As PictureBox
    Friend WithEvents ToolStrip1 As ToolStrip
    Friend WithEvents ToolStripBtnNuevo As ToolStripButton
    Friend WithEvents ToolStripBtnGuardar As ToolStripButton
    Friend WithEvents ToolStripBtnBuscar As ToolStripButton
    Friend WithEvents ToolStripBtnEliminar As ToolStripButton
    Friend WithEvents ToolStripBtnActualizar As ToolStripButton
    Friend WithEvents ToolStripBtnSalir As ToolStripButton
    Friend WithEvents cboTipoInscripcion As ComboBox
    Friend WithEvents Label4 As Label
    Friend WithEvents erProveedorError As ErrorProvider
    Friend WithEvents dgvListaInscripcionesEvento As DataGridView
    Friend WithEvents cboCargarPermisos As ComboBox
    Friend WithEvents IdInscripcion As DataGridViewTextBoxColumn
    Friend WithEvents IdEvento As DataGridViewTextBoxColumn
    Friend WithEvents NombreEvento As DataGridViewTextBoxColumn
    Friend WithEvents IdUsuario As DataGridViewTextBoxColumn
    Friend WithEvents Usuario As DataGridViewTextBoxColumn
    Friend WithEvents TipoInscripcion As DataGridViewTextBoxColumn
    Friend WithEvents btnImprimir As Button
End Class
