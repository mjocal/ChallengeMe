<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class fmPermisos
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(fmPermisos))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtIdPermiso = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtDescripcion = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.cboArea = New System.Windows.Forms.ComboBox()
        Me.ListaPermisos = New System.Windows.Forms.ListView()
        Me.idRol = CType(New System.Windows.Forms.ColumnHeader(),System.Windows.Forms.ColumnHeader)
        Me.Nombre = CType(New System.Windows.Forms.ColumnHeader(),System.Windows.Forms.ColumnHeader)
        Me.Descripcion = CType(New System.Windows.Forms.ColumnHeader(),System.Windows.Forms.ColumnHeader)
        Me.Area = CType(New System.Windows.Forms.ColumnHeader(),System.Windows.Forms.ColumnHeader)
        Me.dgvPermisos = New System.Windows.Forms.DataGridView()
        Me.Id = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NombreP = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Descrip = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.AreaP = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ttToolTip = New System.Windows.Forms.ToolTip(Me.components)
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.ToolStripBtnNuevo = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripBtnSalvar = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripBtnBuscar = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripBtnActualizar = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripBtnEliminar = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripBtnSalir = New System.Windows.Forms.ToolStripButton()
        Me.txtModificar = New System.Windows.Forms.TextBox()
        Me.erProveedorError = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.Label10 = New System.Windows.Forms.Label()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.cboPermiso = New System.Windows.Forms.ComboBox()
        CType(Me.dgvPermisos,System.ComponentModel.ISupportInitialize).BeginInit
        Me.ToolStrip1.SuspendLayout
        CType(Me.erProveedorError,System.ComponentModel.ISupportInitialize).BeginInit
        Me.SuspendLayout
        '
        'Label1
        '
        Me.Label1.AutoSize = true
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.Label1.Location = New System.Drawing.Point(251, 110)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(58, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "ID.Permiso"
        '
        'txtIdPermiso
        '
        Me.txtIdPermiso.Font = New System.Drawing.Font("Microsoft Sans Serif", 12!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.txtIdPermiso.Location = New System.Drawing.Point(316, 110)
        Me.txtIdPermiso.Name = "txtIdPermiso"
        Me.txtIdPermiso.Size = New System.Drawing.Size(100, 26)
        Me.txtIdPermiso.TabIndex = 1
        Me.ttToolTip.SetToolTip(Me.txtIdPermiso, "Ingrese el Número de Permiso")
        '
        'Label2
        '
        Me.Label2.AutoSize = true
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.Label2.Location = New System.Drawing.Point(251, 152)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(44, 13)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Nombre"
        '
        'Label3
        '
        Me.Label3.AutoSize = true
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.Label3.Location = New System.Drawing.Point(251, 189)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(63, 13)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Descripcion"
        '
        'txtDescripcion
        '
        Me.txtDescripcion.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.txtDescripcion.Location = New System.Drawing.Point(316, 185)
        Me.txtDescripcion.Name = "txtDescripcion"
        Me.txtDescripcion.Size = New System.Drawing.Size(374, 20)
        Me.txtDescripcion.TabIndex = 5
        Me.ttToolTip.SetToolTip(Me.txtDescripcion, "Ingrese la descripción del Permiso")
        '
        'Label4
        '
        Me.Label4.AutoSize = true
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.Label4.Location = New System.Drawing.Point(251, 227)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(29, 13)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "Área"
        '
        'cboArea
        '
        Me.cboArea.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.cboArea.FormattingEnabled = true
        Me.cboArea.Items.AddRange(New Object() {"ACTIVIDADES", "EVENTOS", "PRODUCTOS", "PATROCINADORES", "CATEGORIAS", "PREMIOS", "RANKING", "INSCRIPCIONES", "RUTAS"})
        Me.cboArea.Location = New System.Drawing.Point(316, 223)
        Me.cboArea.Name = "cboArea"
        Me.cboArea.Size = New System.Drawing.Size(187, 21)
        Me.cboArea.TabIndex = 7
        Me.ttToolTip.SetToolTip(Me.cboArea, "Seleccione el Área para asignar el permiso")
        '
        'ListaPermisos
        '
        Me.ListaPermisos.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.idRol, Me.Nombre, Me.Descripcion, Me.Area})
        Me.ListaPermisos.FullRowSelect = true
        Me.ListaPermisos.GridLines = true
        Me.ListaPermisos.Location = New System.Drawing.Point(925, 417)
        Me.ListaPermisos.Name = "ListaPermisos"
        Me.ListaPermisos.Size = New System.Drawing.Size(33, 47)
        Me.ListaPermisos.TabIndex = 9
        Me.ListaPermisos.UseCompatibleStateImageBehavior = false
        Me.ListaPermisos.View = System.Windows.Forms.View.Details
        Me.ListaPermisos.Visible = false
        '
        'idRol
        '
        Me.idRol.Text = "ID.Permiso"
        Me.idRol.Width = 100
        '
        'Nombre
        '
        Me.Nombre.Text = "Nombre"
        Me.Nombre.Width = 200
        '
        'Descripcion
        '
        Me.Descripcion.Text = "Descripción"
        Me.Descripcion.Width = 200
        '
        'Area
        '
        Me.Area.Text = "Area"
        Me.Area.Width = 100
        '
        'dgvPermisos
        '
        Me.dgvPermisos.BackgroundColor = System.Drawing.Color.White
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(192,Byte),Integer), CType(CType(255,Byte),Integer), CType(CType(192,Byte),Integer))
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvPermisos.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.dgvPermisos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvPermisos.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Id, Me.NombreP, Me.Descrip, Me.AreaP})
        Me.dgvPermisos.EnableHeadersVisualStyles = false
        Me.dgvPermisos.Location = New System.Drawing.Point(316, 252)
        Me.dgvPermisos.Name = "dgvPermisos"
        Me.dgvPermisos.Size = New System.Drawing.Size(642, 274)
        Me.dgvPermisos.TabIndex = 10
        '
        'Id
        '
        Me.Id.HeaderText = "ID"
        Me.Id.Name = "Id"
        Me.Id.Visible = false
        '
        'NombreP
        '
        Me.NombreP.HeaderText = "Nombre"
        Me.NombreP.Name = "NombreP"
        Me.NombreP.Width = 150
        '
        'Descrip
        '
        Me.Descrip.HeaderText = "Descripcion"
        Me.Descrip.Name = "Descrip"
        Me.Descrip.Width = 300
        '
        'AreaP
        '
        Me.AreaP.HeaderText = "Area"
        Me.AreaP.Name = "AreaP"
        Me.AreaP.Width = 150
        '
        'ttToolTip
        '
        Me.ttToolTip.AutoPopDelay = 5000
        Me.ttToolTip.InitialDelay = 100
        Me.ttToolTip.IsBalloon = true
        Me.ttToolTip.ReshowDelay = 100
        Me.ttToolTip.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info
        Me.ttToolTip.ToolTipTitle = "Atención"
        '
        'ToolStrip1
        '
        Me.ToolStrip1.BackColor = System.Drawing.Color.White
        Me.ToolStrip1.Font = New System.Drawing.Font("Open Sans", 9!)
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripBtnNuevo, Me.ToolStripBtnSalvar, Me.ToolStripBtnBuscar, Me.ToolStripBtnActualizar, Me.ToolStripBtnEliminar, Me.ToolStripBtnSalir})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(1152, 71)
        Me.ToolStrip1.TabIndex = 51
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
        'ToolStripBtnSalvar
        '
        Me.ToolStripBtnSalvar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.ToolStripBtnSalvar.Image = CType(resources.GetObject("ToolStripBtnSalvar.Image"),System.Drawing.Image)
        Me.ToolStripBtnSalvar.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.ToolStripBtnSalvar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripBtnSalvar.Name = "ToolStripBtnSalvar"
        Me.ToolStripBtnSalvar.Size = New System.Drawing.Size(120, 68)
        Me.ToolStripBtnSalvar.Text = "Guardar"
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
        Me.ToolStripBtnActualizar.Visible = false
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
        Me.ToolStripBtnSalir.Image = CType(resources.GetObject("ToolStripBtnSalir.Image"),System.Drawing.Image)
        Me.ToolStripBtnSalir.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.ToolStripBtnSalir.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripBtnSalir.Name = "ToolStripBtnSalir"
        Me.ToolStripBtnSalir.Size = New System.Drawing.Size(100, 68)
        Me.ToolStripBtnSalir.Text = "Salir"
        Me.ToolStripBtnSalir.Visible = false
        '
        'txtModificar
        '
        Me.txtModificar.Location = New System.Drawing.Point(12, 94)
        Me.txtModificar.Name = "txtModificar"
        Me.txtModificar.Size = New System.Drawing.Size(41, 20)
        Me.txtModificar.TabIndex = 52
        Me.txtModificar.Visible = false
        '
        'erProveedorError
        '
        Me.erProveedorError.ContainerControl = Me
        '
        'Label10
        '
        Me.Label10.AutoSize = true
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.Label10.ForeColor = System.Drawing.SystemColors.ButtonShadow
        Me.Label10.Location = New System.Drawing.Point(250, 76)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(243, 24)
        Me.Label10.TabIndex = 53
        Me.Label10.Text = "Mantenimiento de permisos"
        '
        'ComboBox1
        '
        Me.ComboBox1.FormattingEnabled = true
        Me.ComboBox1.Location = New System.Drawing.Point(-15, -15)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(121, 21)
        Me.ComboBox1.TabIndex = 54
        Me.ComboBox1.Visible = false
        '
        'cboPermiso
        '
        Me.cboPermiso.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.cboPermiso.FormattingEnabled = true
        Me.cboPermiso.Items.AddRange(New Object() {"CREAR", "BUSCAR", "ELIMINAR", "ACTUALIZAR"})
        Me.cboPermiso.Location = New System.Drawing.Point(316, 148)
        Me.cboPermiso.Name = "cboPermiso"
        Me.cboPermiso.Size = New System.Drawing.Size(161, 21)
        Me.cboPermiso.TabIndex = 55
        '
        'fmPermisos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6!, 13!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1152, 572)
        Me.Controls.Add(Me.cboPermiso)
        Me.Controls.Add(Me.ComboBox1)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.txtModificar)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Controls.Add(Me.dgvPermisos)
        Me.Controls.Add(Me.ListaPermisos)
        Me.Controls.Add(Me.cboArea)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txtDescripcion)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtIdPermiso)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"),System.Drawing.Icon)
        Me.Name = "fmPermisos"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.dgvPermisos,System.ComponentModel.ISupportInitialize).EndInit
        Me.ToolStrip1.ResumeLayout(false)
        Me.ToolStrip1.PerformLayout
        CType(Me.erProveedorError,System.ComponentModel.ISupportInitialize).EndInit
        Me.ResumeLayout(false)
        Me.PerformLayout

End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents txtIdPermiso As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents txtDescripcion As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents cboArea As ComboBox
    Friend WithEvents ListaPermisos As ListView
    Friend WithEvents idRol As ColumnHeader
    Friend WithEvents Nombre As ColumnHeader
    Friend WithEvents Descripcion As ColumnHeader
    Friend WithEvents Area As ColumnHeader
    Friend WithEvents dgvPermisos As DataGridView
    Friend WithEvents Id As DataGridViewTextBoxColumn
    Friend WithEvents NombreP As DataGridViewTextBoxColumn
    Friend WithEvents Descrip As DataGridViewTextBoxColumn
    Friend WithEvents AreaP As DataGridViewTextBoxColumn
    Friend WithEvents ttToolTip As ToolTip
    Friend WithEvents ToolStrip1 As ToolStrip
    Friend WithEvents ToolStripBtnNuevo As ToolStripButton
    Friend WithEvents ToolStripBtnSalvar As ToolStripButton
    Friend WithEvents ToolStripBtnBuscar As ToolStripButton
    Friend WithEvents ToolStripBtnActualizar As ToolStripButton
    Friend WithEvents ToolStripBtnEliminar As ToolStripButton
    Friend WithEvents ToolStripBtnSalir As ToolStripButton
    Friend WithEvents txtModificar As TextBox
    Friend WithEvents erProveedorError As ErrorProvider
    Friend WithEvents Label10 As Label
    Friend WithEvents cboPermiso As ComboBox
    Friend WithEvents ComboBox1 As ComboBox
End Class
