<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmRanking
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmRanking))
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.txtPosicion = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.cboParticipante = New System.Windows.Forms.ComboBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.cboEvento = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtIdRanking = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.dgvListaRanking = New System.Windows.Forms.DataGridView()
        Me.IdRanking = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.IdEvento = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NombreEvento = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.IdUsuario = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NombreUsuario = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Posicion = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.ToolStripBtnNuevo = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripBtnGuardar = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripBtnBuscar = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripBtnEliminar = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripBtnActualizar = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripBtnSalir = New System.Windows.Forms.ToolStripButton()
        Me.erProveedorError = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.txtIdEventoRanking = New System.Windows.Forms.TextBox()
        Me.txtIdUsuarioRanking = New System.Windows.Forms.TextBox()
        Me.cboCargarPermisos = New System.Windows.Forms.ComboBox()
        Me.GroupBox1.SuspendLayout
        CType(Me.dgvListaRanking,System.ComponentModel.ISupportInitialize).BeginInit
        Me.ToolStrip1.SuspendLayout
        CType(Me.erProveedorError,System.ComponentModel.ISupportInitialize).BeginInit
        Me.SuspendLayout
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.txtPosicion)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.cboParticipante)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.cboEvento)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.txtIdRanking)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(86, 99)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(682, 235)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = false
        Me.GroupBox1.Text = "Mantenimiento de las Posiciones de los participantes en los eventos"
        '
        'txtPosicion
        '
        Me.txtPosicion.Location = New System.Drawing.Point(209, 172)
        Me.txtPosicion.Name = "txtPosicion"
        Me.txtPosicion.Size = New System.Drawing.Size(69, 26)
        Me.txtPosicion.TabIndex = 7
        '
        'Label4
        '
        Me.Label4.AutoSize = true
        Me.Label4.Location = New System.Drawing.Point(26, 176)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(181, 20)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "Posición del Participante"
        '
        'cboParticipante
        '
        Me.cboParticipante.FormattingEnabled = true
        Me.cboParticipante.Location = New System.Drawing.Point(207, 127)
        Me.cboParticipante.Name = "cboParticipante"
        Me.cboParticipante.Size = New System.Drawing.Size(318, 28)
        Me.cboParticipante.TabIndex = 5
        '
        'Label3
        '
        Me.Label3.AutoSize = true
        Me.Label3.Location = New System.Drawing.Point(114, 130)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(93, 20)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Participante"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'cboEvento
        '
        Me.cboEvento.FormattingEnabled = true
        Me.cboEvento.Location = New System.Drawing.Point(207, 84)
        Me.cboEvento.Name = "cboEvento"
        Me.cboEvento.Size = New System.Drawing.Size(225, 28)
        Me.cboEvento.TabIndex = 3
        '
        'Label2
        '
        Me.Label2.AutoSize = true
        Me.Label2.Location = New System.Drawing.Point(148, 92)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(59, 20)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Evento"
        '
        'txtIdRanking
        '
        Me.txtIdRanking.Location = New System.Drawing.Point(207, 41)
        Me.txtIdRanking.Name = "txtIdRanking"
        Me.txtIdRanking.Size = New System.Drawing.Size(122, 26)
        Me.txtIdRanking.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = true
        Me.Label1.Location = New System.Drawing.Point(121, 43)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(86, 20)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Id.Ranking"
        '
        'dgvListaRanking
        '
        Me.dgvListaRanking.AllowUserToAddRows = false
        Me.dgvListaRanking.AllowUserToDeleteRows = false
        Me.dgvListaRanking.BackgroundColor = System.Drawing.Color.White
        Me.dgvListaRanking.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvListaRanking.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IdRanking, Me.IdEvento, Me.NombreEvento, Me.IdUsuario, Me.NombreUsuario, Me.Posicion})
        Me.dgvListaRanking.Location = New System.Drawing.Point(86, 340)
        Me.dgvListaRanking.Name = "dgvListaRanking"
        Me.dgvListaRanking.ReadOnly = true
        Me.dgvListaRanking.Size = New System.Drawing.Size(682, 113)
        Me.dgvListaRanking.TabIndex = 2
        '
        'IdRanking
        '
        Me.IdRanking.HeaderText = "IDRanking"
        Me.IdRanking.Name = "IdRanking"
        Me.IdRanking.ReadOnly = true
        Me.IdRanking.Visible = false
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
        'NombreUsuario
        '
        Me.NombreUsuario.HeaderText = "Usuario"
        Me.NombreUsuario.Name = "NombreUsuario"
        Me.NombreUsuario.ReadOnly = true
        Me.NombreUsuario.Width = 270
        '
        'Posicion
        '
        Me.Posicion.HeaderText = "Posición"
        Me.Posicion.Name = "Posicion"
        Me.Posicion.ReadOnly = true
        '
        'ToolStrip1
        '
        Me.ToolStrip1.BackColor = System.Drawing.Color.White
        Me.ToolStrip1.Dock = System.Windows.Forms.DockStyle.None
        Me.ToolStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripBtnNuevo, Me.ToolStripBtnGuardar, Me.ToolStripBtnBuscar, Me.ToolStripBtnEliminar, Me.ToolStripBtnActualizar, Me.ToolStripBtnSalir})
        Me.ToolStrip1.Location = New System.Drawing.Point(77, 9)
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
        'erProveedorError
        '
        Me.erProveedorError.ContainerControl = Me
        '
        'txtIdEventoRanking
        '
        Me.txtIdEventoRanking.Location = New System.Drawing.Point(23, 96)
        Me.txtIdEventoRanking.Name = "txtIdEventoRanking"
        Me.txtIdEventoRanking.Size = New System.Drawing.Size(54, 20)
        Me.txtIdEventoRanking.TabIndex = 54
        Me.txtIdEventoRanking.Visible = false
        '
        'txtIdUsuarioRanking
        '
        Me.txtIdUsuarioRanking.Location = New System.Drawing.Point(26, 137)
        Me.txtIdUsuarioRanking.Name = "txtIdUsuarioRanking"
        Me.txtIdUsuarioRanking.Size = New System.Drawing.Size(50, 20)
        Me.txtIdUsuarioRanking.TabIndex = 55
        Me.txtIdUsuarioRanking.Visible = false
        '
        'cboCargarPermisos
        '
        Me.cboCargarPermisos.FormattingEnabled = true
        Me.cboCargarPermisos.Location = New System.Drawing.Point(23, 183)
        Me.cboCargarPermisos.Name = "cboCargarPermisos"
        Me.cboCargarPermisos.Size = New System.Drawing.Size(64, 21)
        Me.cboCargarPermisos.TabIndex = 56
        Me.cboCargarPermisos.Visible = false
        '
        'frmRanking
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6!, 13!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(780, 513)
        Me.Controls.Add(Me.cboCargarPermisos)
        Me.Controls.Add(Me.txtIdUsuarioRanking)
        Me.Controls.Add(Me.txtIdEventoRanking)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Controls.Add(Me.dgvListaRanking)
        Me.Controls.Add(Me.GroupBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmRanking"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Ranking"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.GroupBox1.ResumeLayout(false)
        Me.GroupBox1.PerformLayout
        CType(Me.dgvListaRanking,System.ComponentModel.ISupportInitialize).EndInit
        Me.ToolStrip1.ResumeLayout(false)
        Me.ToolStrip1.PerformLayout
        CType(Me.erProveedorError,System.ComponentModel.ISupportInitialize).EndInit
        Me.ResumeLayout(false)
        Me.PerformLayout

End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents txtPosicion As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents cboParticipante As ComboBox
    Friend WithEvents Label3 As Label
    Friend WithEvents cboEvento As ComboBox
    Friend WithEvents Label2 As Label
    Friend WithEvents txtIdRanking As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents dgvListaRanking As DataGridView
    Friend WithEvents IdRanking As DataGridViewTextBoxColumn
    Friend WithEvents IdEvento As DataGridViewTextBoxColumn
    Friend WithEvents NombreEvento As DataGridViewTextBoxColumn
    Friend WithEvents IdUsuario As DataGridViewTextBoxColumn
    Friend WithEvents NombreUsuario As DataGridViewTextBoxColumn
    Friend WithEvents Posicion As DataGridViewTextBoxColumn
    Friend WithEvents ToolStrip1 As ToolStrip
    Friend WithEvents ToolStripBtnNuevo As ToolStripButton
    Friend WithEvents ToolStripBtnGuardar As ToolStripButton
    Friend WithEvents ToolStripBtnBuscar As ToolStripButton
    Friend WithEvents ToolStripBtnEliminar As ToolStripButton
    Friend WithEvents ToolStripBtnActualizar As ToolStripButton
    Friend WithEvents ToolStripBtnSalir As ToolStripButton
    Friend WithEvents erProveedorError As ErrorProvider
    Friend WithEvents txtIdUsuarioRanking As TextBox
    Friend WithEvents txtIdEventoRanking As TextBox
    Friend WithEvents cboCargarPermisos As ComboBox
End Class
