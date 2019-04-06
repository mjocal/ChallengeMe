<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmRoles
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmRoles))
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle7 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle10 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle11 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle12 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle8 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle9 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtIdRol = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtNombreRol = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtDescrRol = New System.Windows.Forms.TextBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.lstRolPermiso = New System.Windows.Forms.ListView()
        Me.IdRole = CType(New System.Windows.Forms.ColumnHeader(),System.Windows.Forms.ColumnHeader)
        Me.IdPermis = CType(New System.Windows.Forms.ColumnHeader(),System.Windows.Forms.ColumnHeader)
        Me.txtArea = New System.Windows.Forms.TextBox()
        Me.txtNomPermiso = New System.Windows.Forms.TextBox()
        Me.txtAreaABuscar = New System.Windows.Forms.TextBox()
        Me.txtIdPermiso = New System.Windows.Forms.TextBox()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.btnGuardar = New System.Windows.Forms.Button()
        Me.cboAreas = New System.Windows.Forms.ComboBox()
        Me.btnQuitar = New System.Windows.Forms.Button()
        Me.btnAgregarPermisos = New System.Windows.Forms.Button()
        Me.ListaPermisos = New System.Windows.Forms.ListView()
        Me.ID = CType(New System.Windows.Forms.ColumnHeader(),System.Windows.Forms.ColumnHeader)
        Me.Tipo = CType(New System.Windows.Forms.ColumnHeader(),System.Windows.Forms.ColumnHeader)
        Me.ListaAreas = New System.Windows.Forms.ListView()
        Me.Area = CType(New System.Windows.Forms.ColumnHeader(),System.Windows.Forms.ColumnHeader)
        Me.GroupBox5 = New System.Windows.Forms.GroupBox()
        Me.ListaPermisosXRol = New System.Windows.Forms.ListView()
        Me.IdPermiso = CType(New System.Windows.Forms.ColumnHeader(),System.Windows.Forms.ColumnHeader)
        Me.Permiso = CType(New System.Windows.Forms.ColumnHeader(),System.Windows.Forms.ColumnHeader)
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.dgvListaPermisos = New System.Windows.Forms.DataGridView()
        Me.NomPermiso = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.AreaP = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.txtCodRol = New System.Windows.Forms.TextBox()
        Me.cboRoles = New System.Windows.Forms.ComboBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.dgvListaRolesCreados = New System.Windows.Forms.DataGridView()
        Me.IDRol = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Rol = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Descripcion = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.txtModificar = New System.Windows.Forms.TextBox()
        Me.ttpToolTip = New System.Windows.Forms.ToolTip(Me.components)
        Me.erProveedorError = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.Label10 = New System.Windows.Forms.Label()
        Me.GroupBox2.SuspendLayout
        Me.GroupBox3.SuspendLayout
        Me.GroupBox5.SuspendLayout
        Me.GroupBox4.SuspendLayout
        CType(Me.dgvListaPermisos,System.ComponentModel.ISupportInitialize).BeginInit
        Me.GroupBox1.SuspendLayout
        CType(Me.dgvListaRolesCreados,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.erProveedorError,System.ComponentModel.ISupportInitialize).BeginInit
        Me.SuspendLayout
        '
        'Label1
        '
        Me.Label1.AutoSize = true
        Me.Label1.Location = New System.Drawing.Point(120, 22)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(51, 20)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "ID.rol:"
        '
        'txtIdRol
        '
        Me.txtIdRol.Font = New System.Drawing.Font("Microsoft Sans Serif", 12!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.txtIdRol.Location = New System.Drawing.Point(180, 19)
        Me.txtIdRol.Name = "txtIdRol"
        Me.txtIdRol.Size = New System.Drawing.Size(101, 26)
        Me.txtIdRol.TabIndex = 2
        '
        'Label2
        '
        Me.Label2.AutoSize = true
        Me.Label2.Location = New System.Drawing.Point(287, 22)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(69, 20)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Nombre:"
        '
        'txtNombreRol
        '
        Me.txtNombreRol.Font = New System.Drawing.Font("Microsoft Sans Serif", 12!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.txtNombreRol.Location = New System.Drawing.Point(363, 19)
        Me.txtNombreRol.Name = "txtNombreRol"
        Me.txtNombreRol.Size = New System.Drawing.Size(226, 26)
        Me.txtNombreRol.TabIndex = 0
        Me.ttpToolTip.SetToolTip(Me.txtNombreRol, "Ingrese el nombre del Rol")
        '
        'Label3
        '
        Me.Label3.AutoSize = true
        Me.Label3.Location = New System.Drawing.Point(81, 64)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(96, 20)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Descripción:"
        '
        'txtDescrRol
        '
        Me.txtDescrRol.Font = New System.Drawing.Font("Microsoft Sans Serif", 12!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.txtDescrRol.Location = New System.Drawing.Point(180, 61)
        Me.txtDescrRol.Name = "txtDescrRol"
        Me.txtDescrRol.Size = New System.Drawing.Size(663, 26)
        Me.txtDescrRol.TabIndex = 1
        Me.ttpToolTip.SetToolTip(Me.txtDescrRol, "Ingrese la descripción del Rol")
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.lstRolPermiso)
        Me.GroupBox2.Controls.Add(Me.txtDescrRol)
        Me.GroupBox2.Controls.Add(Me.Label3)
        Me.GroupBox2.Controls.Add(Me.txtNombreRol)
        Me.GroupBox2.Controls.Add(Me.Label2)
        Me.GroupBox2.Controls.Add(Me.txtIdRol)
        Me.GroupBox2.Controls.Add(Me.Label1)
        Me.GroupBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.GroupBox2.Location = New System.Drawing.Point(145, 30)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(1056, 101)
        Me.GroupBox2.TabIndex = 7
        Me.GroupBox2.TabStop = false
        Me.GroupBox2.Text = "Rol"
        '
        'lstRolPermiso
        '
        Me.lstRolPermiso.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.IdRole, Me.IdPermis})
        Me.lstRolPermiso.Location = New System.Drawing.Point(6, 42)
        Me.lstRolPermiso.Name = "lstRolPermiso"
        Me.lstRolPermiso.Size = New System.Drawing.Size(10, 25)
        Me.lstRolPermiso.TabIndex = 53
        Me.lstRolPermiso.UseCompatibleStateImageBehavior = false
        Me.lstRolPermiso.View = System.Windows.Forms.View.Details
        Me.lstRolPermiso.Visible = false
        '
        'IdRole
        '
        Me.IdRole.Text = "IdRol"
        '
        'IdPermis
        '
        Me.IdPermis.Text = "IdPermiso"
        '
        'txtArea
        '
        Me.txtArea.Location = New System.Drawing.Point(528, 137)
        Me.txtArea.Name = "txtArea"
        Me.txtArea.Size = New System.Drawing.Size(10, 20)
        Me.txtArea.TabIndex = 12
        Me.txtArea.Visible = false
        '
        'txtNomPermiso
        '
        Me.txtNomPermiso.Location = New System.Drawing.Point(562, 137)
        Me.txtNomPermiso.Name = "txtNomPermiso"
        Me.txtNomPermiso.Size = New System.Drawing.Size(10, 20)
        Me.txtNomPermiso.TabIndex = 11
        Me.txtNomPermiso.Visible = false
        '
        'txtAreaABuscar
        '
        Me.txtAreaABuscar.Location = New System.Drawing.Point(512, 137)
        Me.txtAreaABuscar.Name = "txtAreaABuscar"
        Me.txtAreaABuscar.Size = New System.Drawing.Size(10, 20)
        Me.txtAreaABuscar.TabIndex = 10
        Me.txtAreaABuscar.Visible = false
        '
        'txtIdPermiso
        '
        Me.txtIdPermiso.Location = New System.Drawing.Point(544, 137)
        Me.txtIdPermiso.Name = "txtIdPermiso"
        Me.txtIdPermiso.Size = New System.Drawing.Size(12, 20)
        Me.txtIdPermiso.TabIndex = 8
        Me.txtIdPermiso.Visible = false
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.btnGuardar)
        Me.GroupBox3.Controls.Add(Me.cboAreas)
        Me.GroupBox3.Controls.Add(Me.txtAreaABuscar)
        Me.GroupBox3.Controls.Add(Me.txtArea)
        Me.GroupBox3.Controls.Add(Me.txtNomPermiso)
        Me.GroupBox3.Controls.Add(Me.btnQuitar)
        Me.GroupBox3.Controls.Add(Me.txtIdPermiso)
        Me.GroupBox3.Controls.Add(Me.btnAgregarPermisos)
        Me.GroupBox3.Controls.Add(Me.ListaPermisos)
        Me.GroupBox3.Controls.Add(Me.ListaAreas)
        Me.GroupBox3.Controls.Add(Me.GroupBox5)
        Me.GroupBox3.Location = New System.Drawing.Point(145, 130)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(1056, 190)
        Me.GroupBox3.TabIndex = 8
        Me.GroupBox3.TabStop = false
        '
        'btnGuardar
        '
        Me.btnGuardar.Font = New System.Drawing.Font("Open Sans", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.btnGuardar.Image = CType(resources.GetObject("btnGuardar.Image"),System.Drawing.Image)
        Me.btnGuardar.Location = New System.Drawing.Point(906, 56)
        Me.btnGuardar.Name = "btnGuardar"
        Me.btnGuardar.Size = New System.Drawing.Size(141, 67)
        Me.btnGuardar.TabIndex = 16
        Me.btnGuardar.Text = "Guardar"
        Me.btnGuardar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.ttpToolTip.SetToolTip(Me.btnGuardar, "Asignar los permisos al rol")
        Me.btnGuardar.UseVisualStyleBackColor = true
        '
        'cboAreas
        '
        Me.cboAreas.FormattingEnabled = true
        Me.cboAreas.Location = New System.Drawing.Point(578, 137)
        Me.cboAreas.Name = "cboAreas"
        Me.cboAreas.Size = New System.Drawing.Size(11, 21)
        Me.cboAreas.TabIndex = 13
        Me.cboAreas.Visible = false
        '
        'btnQuitar
        '
        Me.btnQuitar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.btnQuitar.Location = New System.Drawing.Point(529, 84)
        Me.btnQuitar.Name = "btnQuitar"
        Me.btnQuitar.Size = New System.Drawing.Size(75, 31)
        Me.btnQuitar.TabIndex = 4
        Me.btnQuitar.Text = "<<"
        Me.btnQuitar.UseVisualStyleBackColor = true
        '
        'btnAgregarPermisos
        '
        Me.btnAgregarPermisos.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.btnAgregarPermisos.Location = New System.Drawing.Point(530, 38)
        Me.btnAgregarPermisos.Name = "btnAgregarPermisos"
        Me.btnAgregarPermisos.Size = New System.Drawing.Size(75, 30)
        Me.btnAgregarPermisos.TabIndex = 3
        Me.btnAgregarPermisos.Text = ">>"
        Me.btnAgregarPermisos.UseVisualStyleBackColor = true
        '
        'ListaPermisos
        '
        Me.ListaPermisos.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ID, Me.Tipo})
        Me.ListaPermisos.Font = New System.Drawing.Font("Microsoft Sans Serif", 12!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.ListaPermisos.FullRowSelect = true
        Me.ListaPermisos.GridLines = true
        Me.ListaPermisos.Location = New System.Drawing.Point(253, 38)
        Me.ListaPermisos.Name = "ListaPermisos"
        Me.ListaPermisos.Size = New System.Drawing.Size(253, 140)
        Me.ListaPermisos.TabIndex = 2
        Me.ListaPermisos.UseCompatibleStateImageBehavior = false
        Me.ListaPermisos.View = System.Windows.Forms.View.Details
        '
        'ID
        '
        Me.ID.Text = "Permiso"
        Me.ID.Width = 5
        '
        'Tipo
        '
        Me.Tipo.Text = "Permisos otorgados al área"
        Me.Tipo.Width = 250
        '
        'ListaAreas
        '
        Me.ListaAreas.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.Area})
        Me.ListaAreas.Font = New System.Drawing.Font("Microsoft Sans Serif", 12!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.ListaAreas.FullRowSelect = true
        Me.ListaAreas.GridLines = true
        Me.ListaAreas.Location = New System.Drawing.Point(22, 39)
        Me.ListaAreas.Name = "ListaAreas"
        Me.ListaAreas.Size = New System.Drawing.Size(205, 140)
        Me.ListaAreas.TabIndex = 1
        Me.ListaAreas.UseCompatibleStateImageBehavior = false
        Me.ListaAreas.View = System.Windows.Forms.View.Details
        '
        'Area
        '
        Me.Area.Text = "Áreas"
        Me.Area.Width = 200
        '
        'GroupBox5
        '
        Me.GroupBox5.Controls.Add(Me.ListaPermisosXRol)
        Me.GroupBox5.Font = New System.Drawing.Font("Microsoft Sans Serif", 12!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.GroupBox5.Location = New System.Drawing.Point(621, 9)
        Me.GroupBox5.Name = "GroupBox5"
        Me.GroupBox5.Size = New System.Drawing.Size(279, 175)
        Me.GroupBox5.TabIndex = 14
        Me.GroupBox5.TabStop = false
        Me.GroupBox5.Text = "Asignar permisos al rol"
        '
        'ListaPermisosXRol
        '
        Me.ListaPermisosXRol.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.IdPermiso, Me.Permiso})
        Me.ListaPermisosXRol.Font = New System.Drawing.Font("Microsoft Sans Serif", 12!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.ListaPermisosXRol.FullRowSelect = true
        Me.ListaPermisosXRol.GridLines = true
        Me.ListaPermisosXRol.Location = New System.Drawing.Point(9, 29)
        Me.ListaPermisosXRol.Name = "ListaPermisosXRol"
        Me.ListaPermisosXRol.Size = New System.Drawing.Size(252, 123)
        Me.ListaPermisosXRol.TabIndex = 0
        Me.ListaPermisosXRol.UseCompatibleStateImageBehavior = false
        Me.ListaPermisosXRol.View = System.Windows.Forms.View.Details
        '
        'IdPermiso
        '
        Me.IdPermiso.Text = "ID.Permiso"
        Me.IdPermiso.Width = 100
        '
        'Permiso
        '
        Me.Permiso.Text = "Permiso"
        Me.Permiso.Width = 150
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.dgvListaPermisos)
        Me.GroupBox4.Controls.Add(Me.txtCodRol)
        Me.GroupBox4.Controls.Add(Me.cboRoles)
        Me.GroupBox4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.GroupBox4.Location = New System.Drawing.Point(707, 328)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(494, 300)
        Me.GroupBox4.TabIndex = 9
        Me.GroupBox4.TabStop = false
        Me.GroupBox4.Text = "Lista de permisos por rol"
        '
        'dgvListaPermisos
        '
        Me.dgvListaPermisos.AccessibleRole = System.Windows.Forms.AccessibleRole.None
        Me.dgvListaPermisos.AllowUserToAddRows = false
        Me.dgvListaPermisos.AllowUserToDeleteRows = false
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.DodgerBlue
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White
        Me.dgvListaPermisos.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.dgvListaPermisos.BackgroundColor = System.Drawing.Color.White
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(CType(CType(192,Byte),Integer), CType(CType(255,Byte),Integer), CType(CType(192,Byte),Integer))
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.White
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Transparent
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvListaPermisos.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.dgvListaPermisos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvListaPermisos.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.NomPermiso, Me.AreaP})
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.White
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvListaPermisos.DefaultCellStyle = DataGridViewCellStyle3
        Me.dgvListaPermisos.EnableHeadersVisualStyles = false
        Me.dgvListaPermisos.GridColor = System.Drawing.SystemColors.ActiveBorder
        Me.dgvListaPermisos.Location = New System.Drawing.Point(33, 28)
        Me.dgvListaPermisos.Name = "dgvListaPermisos"
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        DataGridViewCellStyle4.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.DodgerBlue
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvListaPermisos.RowHeadersDefaultCellStyle = DataGridViewCellStyle4
        DataGridViewCellStyle5.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.Black
        Me.dgvListaPermisos.RowsDefaultCellStyle = DataGridViewCellStyle5
        Me.dgvListaPermisos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvListaPermisos.Size = New System.Drawing.Size(436, 254)
        Me.dgvListaPermisos.TabIndex = 2
        '
        'NomPermiso
        '
        Me.NomPermiso.HeaderText = "Permiso"
        Me.NomPermiso.Name = "NomPermiso"
        Me.NomPermiso.Width = 200
        '
        'AreaP
        '
        Me.AreaP.HeaderText = "Área"
        Me.AreaP.Name = "AreaP"
        Me.AreaP.Width = 200
        '
        'txtCodRol
        '
        Me.txtCodRol.Location = New System.Drawing.Point(478, 108)
        Me.txtCodRol.Name = "txtCodRol"
        Me.txtCodRol.Size = New System.Drawing.Size(10, 26)
        Me.txtCodRol.TabIndex = 1
        Me.txtCodRol.Visible = false
        '
        'cboRoles
        '
        Me.cboRoles.FormattingEnabled = true
        Me.cboRoles.Location = New System.Drawing.Point(475, 74)
        Me.cboRoles.Name = "cboRoles"
        Me.cboRoles.Size = New System.Drawing.Size(10, 28)
        Me.cboRoles.TabIndex = 0
        Me.cboRoles.Visible = false
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.dgvListaRolesCreados)
        Me.GroupBox1.Controls.Add(Me.txtModificar)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(145, 326)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(556, 302)
        Me.GroupBox1.TabIndex = 10
        Me.GroupBox1.TabStop = false
        Me.GroupBox1.Text = "Lista de roles creados"
        '
        'dgvListaRolesCreados
        '
        Me.dgvListaRolesCreados.AccessibleRole = System.Windows.Forms.AccessibleRole.None
        Me.dgvListaRolesCreados.AllowUserToAddRows = false
        Me.dgvListaRolesCreados.AllowUserToDeleteRows = false
        DataGridViewCellStyle6.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.DodgerBlue
        DataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.Black
        Me.dgvListaRolesCreados.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle6
        Me.dgvListaRolesCreados.BackgroundColor = System.Drawing.Color.White
        DataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle7.BackColor = System.Drawing.Color.FromArgb(CType(CType(192,Byte),Integer), CType(CType(255,Byte),Integer), CType(CType(192,Byte),Integer))
        DataGridViewCellStyle7.Font = New System.Drawing.Font("Microsoft Sans Serif", 12!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        DataGridViewCellStyle7.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.White
        DataGridViewCellStyle7.SelectionForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvListaRolesCreados.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle7
        Me.dgvListaRolesCreados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvListaRolesCreados.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IDRol, Me.Rol, Me.Descripcion})
        DataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle10.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle10.Font = New System.Drawing.Font("Microsoft Sans Serif", 12!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        DataGridViewCellStyle10.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle10.SelectionBackColor = System.Drawing.Color.Black
        DataGridViewCellStyle10.SelectionForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvListaRolesCreados.DefaultCellStyle = DataGridViewCellStyle10
        Me.dgvListaRolesCreados.EnableHeadersVisualStyles = false
        Me.dgvListaRolesCreados.GridColor = System.Drawing.SystemColors.ActiveBorder
        Me.dgvListaRolesCreados.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.dgvListaRolesCreados.Location = New System.Drawing.Point(8, 30)
        Me.dgvListaRolesCreados.Name = "dgvListaRolesCreados"
        DataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle11.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle11.Font = New System.Drawing.Font("Microsoft Sans Serif", 12!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        DataGridViewCellStyle11.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle11.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle11.SelectionForeColor = System.Drawing.Color.Transparent
        DataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvListaRolesCreados.RowHeadersDefaultCellStyle = DataGridViewCellStyle11
        DataGridViewCellStyle12.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle12.SelectionBackColor = System.Drawing.Color.White
        DataGridViewCellStyle12.SelectionForeColor = System.Drawing.Color.Black
        Me.dgvListaRolesCreados.RowsDefaultCellStyle = DataGridViewCellStyle12
        Me.dgvListaRolesCreados.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvListaRolesCreados.Size = New System.Drawing.Size(539, 254)
        Me.dgvListaRolesCreados.TabIndex = 0
        '
        'IDRol
        '
        Me.IDRol.HeaderText = "ID.Rol"
        Me.IDRol.Name = "IDRol"
        Me.IDRol.Visible = false
        Me.IDRol.Width = 80
        '
        'Rol
        '
        DataGridViewCellStyle8.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle8.SelectionForeColor = System.Drawing.Color.Black
        Me.Rol.DefaultCellStyle = DataGridViewCellStyle8
        Me.Rol.HeaderText = "Rol"
        Me.Rol.Name = "Rol"
        Me.Rol.Width = 150
        '
        'Descripcion
        '
        DataGridViewCellStyle9.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle9.SelectionForeColor = System.Drawing.Color.Black
        Me.Descripcion.DefaultCellStyle = DataGridViewCellStyle9
        Me.Descripcion.HeaderText = "Descripción"
        Me.Descripcion.Name = "Descripcion"
        Me.Descripcion.Width = 400
        '
        'txtModificar
        '
        Me.txtModificar.Location = New System.Drawing.Point(641, 71)
        Me.txtModificar.Name = "txtModificar"
        Me.txtModificar.Size = New System.Drawing.Size(48, 26)
        Me.txtModificar.TabIndex = 11
        Me.txtModificar.Visible = false
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
        'Label10
        '
        Me.Label10.AutoSize = true
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.Label10.ForeColor = System.Drawing.SystemColors.ButtonShadow
        Me.Label10.Location = New System.Drawing.Point(149, 6)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(207, 24)
        Me.Label10.TabIndex = 52
        Me.Label10.Text = "Mantenimiento de roles"
        '
        'frmRoles
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6!, 13!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1340, 686)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.GroupBox4)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"),System.Drawing.Icon)
        Me.Name = "frmRoles"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.GroupBox2.ResumeLayout(false)
        Me.GroupBox2.PerformLayout
        Me.GroupBox3.ResumeLayout(false)
        Me.GroupBox3.PerformLayout
        Me.GroupBox5.ResumeLayout(false)
        Me.GroupBox4.ResumeLayout(false)
        Me.GroupBox4.PerformLayout
        CType(Me.dgvListaPermisos,System.ComponentModel.ISupportInitialize).EndInit
        Me.GroupBox1.ResumeLayout(false)
        Me.GroupBox1.PerformLayout
        CType(Me.dgvListaRolesCreados,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.erProveedorError,System.ComponentModel.ISupportInitialize).EndInit
        Me.ResumeLayout(false)
        Me.PerformLayout

End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents txtIdRol As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents txtNombreRol As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents txtDescrRol As TextBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents ListaPermisosXRol As ListView
    Friend WithEvents txtIdPermiso As TextBox
    Friend WithEvents IdPermiso As ColumnHeader
    Friend WithEvents Permiso As ColumnHeader
    Friend WithEvents ListaPermisos As ListView
    Friend WithEvents Tipo As ColumnHeader
    Friend WithEvents ListaAreas As ListView
    Friend WithEvents Area As ColumnHeader
    Friend WithEvents txtAreaABuscar As TextBox
    Friend WithEvents txtNomPermiso As TextBox
    Friend WithEvents btnAgregarPermisos As Button
    Friend WithEvents ID As ColumnHeader
    Friend WithEvents btnQuitar As Button
    Friend WithEvents txtArea As TextBox
    Friend WithEvents GroupBox4 As GroupBox
    Friend WithEvents txtCodRol As TextBox
    Friend WithEvents cboRoles As ComboBox
    Friend WithEvents dgvListaPermisos As DataGridView
    Friend WithEvents cboAreas As ComboBox
    Friend WithEvents GroupBox5 As GroupBox
    Friend WithEvents btnGuardar As Button
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents dgvListaRolesCreados As DataGridView
    Friend WithEvents ttpToolTip As ToolTip
    Friend WithEvents txtModificar As TextBox
    Friend WithEvents erProveedorError As ErrorProvider
    Friend WithEvents Label10 As Label
    Friend WithEvents lstRolPermiso As ListView
    Friend WithEvents IdRole As ColumnHeader
    Friend WithEvents IdPermis As ColumnHeader
    Friend WithEvents IDRol As DataGridViewTextBoxColumn
    Friend WithEvents Rol As DataGridViewTextBoxColumn
    Friend WithEvents Descripcion As DataGridViewTextBoxColumn
    Friend WithEvents NomPermiso As DataGridViewTextBoxColumn
    Friend WithEvents AreaP As DataGridViewTextBoxColumn
End Class
