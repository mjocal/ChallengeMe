<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmModalEventoProducto
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
        Me.dgvProductos = New System.Windows.Forms.DataGridView()
        Me.IdProducto = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Producto = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.IdPatrocinador = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Patrocinador = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Costo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtProducto = New System.Windows.Forms.TextBox()
        Me.txtCantidad = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtTotal = New System.Windows.Forms.TextBox()
        Me.txtCosto = New System.Windows.Forms.TextBox()
        Me.btnAgregar = New System.Windows.Forms.Button()
        Me.btnQuitar = New System.Windows.Forms.Button()
        Me.dgvProductosEvento = New System.Windows.Forms.DataGridView()
        Me.CodProducto = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Nom_Producto = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CodPatrocinador = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Nom_Patrocinador = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Cantidad = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TipoPatrocinio = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Total = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.erProveedorError = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.btnAgregarProducto = New System.Windows.Forms.Button()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.cboTipoPatrocinio = New System.Windows.Forms.ComboBox()
        Me.txtIdEvento = New System.Windows.Forms.TextBox()
        Me.ttpToolTip = New System.Windows.Forms.ToolTip(Me.components)
        Me.lblPatrocinador = New System.Windows.Forms.Label()
        Me.cboPatrocinador = New System.Windows.Forms.ComboBox()
        CType(Me.dgvProductos,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.dgvProductosEvento,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.erProveedorError,System.ComponentModel.ISupportInitialize).BeginInit
        Me.SuspendLayout
        '
        'dgvProductos
        '
        Me.dgvProductos.AllowUserToAddRows = false
        Me.dgvProductos.AllowUserToDeleteRows = false
        Me.dgvProductos.BackgroundColor = System.Drawing.Color.White
        Me.dgvProductos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvProductos.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IdProducto, Me.Producto, Me.IdPatrocinador, Me.Patrocinador, Me.Costo})
        Me.dgvProductos.Location = New System.Drawing.Point(52, 240)
        Me.dgvProductos.Name = "dgvProductos"
        Me.dgvProductos.ReadOnly = true
        Me.dgvProductos.Size = New System.Drawing.Size(445, 196)
        Me.dgvProductos.TabIndex = 0
        '
        'IdProducto
        '
        Me.IdProducto.HeaderText = "IdProducto"
        Me.IdProducto.Name = "IdProducto"
        Me.IdProducto.ReadOnly = true
        Me.IdProducto.Visible = false
        '
        'Producto
        '
        Me.Producto.HeaderText = "Producto"
        Me.Producto.Name = "Producto"
        Me.Producto.ReadOnly = true
        Me.Producto.Width = 200
        '
        'IdPatrocinador
        '
        Me.IdPatrocinador.HeaderText = "IdPatrocinador"
        Me.IdPatrocinador.Name = "IdPatrocinador"
        Me.IdPatrocinador.ReadOnly = true
        Me.IdPatrocinador.Visible = false
        '
        'Patrocinador
        '
        Me.Patrocinador.HeaderText = "Patrocinador"
        Me.Patrocinador.Name = "Patrocinador"
        Me.Patrocinador.ReadOnly = true
        '
        'Costo
        '
        Me.Costo.HeaderText = "Costo Producto"
        Me.Costo.Name = "Costo"
        Me.Costo.ReadOnly = true
        '
        'Label1
        '
        Me.Label1.AutoSize = true
        Me.Label1.Location = New System.Drawing.Point(53, 44)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(85, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Buscar producto"
        '
        'txtProducto
        '
        Me.txtProducto.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.txtProducto.Location = New System.Drawing.Point(144, 42)
        Me.txtProducto.Name = "txtProducto"
        Me.txtProducto.Size = New System.Drawing.Size(433, 24)
        Me.txtProducto.TabIndex = 2
        '
        'txtCantidad
        '
        Me.txtCantidad.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.txtCantidad.Location = New System.Drawing.Point(144, 110)
        Me.txtCantidad.Name = "txtCantidad"
        Me.txtCantidad.Size = New System.Drawing.Size(52, 24)
        Me.txtCantidad.TabIndex = 3
        '
        'Label2
        '
        Me.Label2.AutoSize = true
        Me.Label2.Location = New System.Drawing.Point(89, 115)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(49, 13)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Cantidad"
        '
        'Label3
        '
        Me.Label3.AutoSize = true
        Me.Label3.Location = New System.Drawing.Point(107, 156)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(31, 13)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Total"
        '
        'txtTotal
        '
        Me.txtTotal.Enabled = false
        Me.txtTotal.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.txtTotal.Location = New System.Drawing.Point(144, 149)
        Me.txtTotal.Name = "txtTotal"
        Me.txtTotal.Size = New System.Drawing.Size(103, 24)
        Me.txtTotal.TabIndex = 6
        '
        'txtCosto
        '
        Me.txtCosto.Location = New System.Drawing.Point(-9, 313)
        Me.txtCosto.Name = "txtCosto"
        Me.txtCosto.Size = New System.Drawing.Size(18, 20)
        Me.txtCosto.TabIndex = 7
        Me.txtCosto.Visible = false
        '
        'btnAgregar
        '
        Me.btnAgregar.Location = New System.Drawing.Point(459, 201)
        Me.btnAgregar.Name = "btnAgregar"
        Me.btnAgregar.Size = New System.Drawing.Size(34, 33)
        Me.btnAgregar.TabIndex = 8
        Me.btnAgregar.Text = ">>"
        Me.ttpToolTip.SetToolTip(Me.btnAgregar, "Agregar productos a la lista")
        Me.btnAgregar.UseVisualStyleBackColor = true
        '
        'btnQuitar
        '
        Me.btnQuitar.Location = New System.Drawing.Point(419, 201)
        Me.btnQuitar.Name = "btnQuitar"
        Me.btnQuitar.Size = New System.Drawing.Size(34, 33)
        Me.btnQuitar.TabIndex = 9
        Me.btnQuitar.Text = "<<"
        Me.ttpToolTip.SetToolTip(Me.btnQuitar, "Quitar productos de la lista")
        Me.btnQuitar.UseVisualStyleBackColor = true
        '
        'dgvProductosEvento
        '
        Me.dgvProductosEvento.AllowUserToAddRows = false
        Me.dgvProductosEvento.AllowUserToDeleteRows = false
        Me.dgvProductosEvento.BackgroundColor = System.Drawing.Color.White
        Me.dgvProductosEvento.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvProductosEvento.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.CodProducto, Me.Nom_Producto, Me.CodPatrocinador, Me.Nom_Patrocinador, Me.Cantidad, Me.TipoPatrocinio, Me.Total})
        Me.dgvProductosEvento.Location = New System.Drawing.Point(503, 240)
        Me.dgvProductosEvento.Name = "dgvProductosEvento"
        Me.dgvProductosEvento.ReadOnly = true
        Me.dgvProductosEvento.Size = New System.Drawing.Size(527, 195)
        Me.dgvProductosEvento.TabIndex = 10
        '
        'CodProducto
        '
        Me.CodProducto.HeaderText = "IdProducto"
        Me.CodProducto.Name = "CodProducto"
        Me.CodProducto.ReadOnly = true
        Me.CodProducto.Visible = false
        '
        'Nom_Producto
        '
        Me.Nom_Producto.HeaderText = "Producto"
        Me.Nom_Producto.Name = "Nom_Producto"
        Me.Nom_Producto.ReadOnly = true
        Me.Nom_Producto.Width = 200
        '
        'CodPatrocinador
        '
        Me.CodPatrocinador.HeaderText = "IdPatrocinador"
        Me.CodPatrocinador.Name = "CodPatrocinador"
        Me.CodPatrocinador.ReadOnly = true
        Me.CodPatrocinador.Visible = false
        '
        'Nom_Patrocinador
        '
        Me.Nom_Patrocinador.HeaderText = "Patrocinador"
        Me.Nom_Patrocinador.Name = "Nom_Patrocinador"
        Me.Nom_Patrocinador.ReadOnly = true
        '
        'Cantidad
        '
        Me.Cantidad.HeaderText = "Cantidad"
        Me.Cantidad.Name = "Cantidad"
        Me.Cantidad.ReadOnly = true
        Me.Cantidad.Width = 80
        '
        'TipoPatrocinio
        '
        Me.TipoPatrocinio.HeaderText = "Tipo Patrocinio"
        Me.TipoPatrocinio.Name = "TipoPatrocinio"
        Me.TipoPatrocinio.ReadOnly = true
        '
        'Total
        '
        Me.Total.HeaderText = "Total patrocinio"
        Me.Total.Name = "Total"
        Me.Total.ReadOnly = true
        '
        'erProveedorError
        '
        Me.erProveedorError.ContainerControl = Me
        '
        'Label5
        '
        Me.Label5.AutoSize = true
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.Label5.ForeColor = System.Drawing.SystemColors.ButtonShadow
        Me.Label5.Location = New System.Drawing.Point(52, 210)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(279, 24)
        Me.Label5.TabIndex = 57
        Me.Label5.Text = "Lista productos por patrocinador"
        '
        'Label6
        '
        Me.Label6.AutoSize = true
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.Label6.ForeColor = System.Drawing.SystemColors.ButtonShadow
        Me.Label6.Location = New System.Drawing.Point(509, 213)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(302, 24)
        Me.Label6.TabIndex = 58
        Me.Label6.Text = "Lista productos a agregar al evento"
        '
        'btnAgregarProducto
        '
        Me.btnAgregarProducto.Location = New System.Drawing.Point(904, 200)
        Me.btnAgregarProducto.Name = "btnAgregarProducto"
        Me.btnAgregarProducto.Size = New System.Drawing.Size(126, 38)
        Me.btnAgregarProducto.TabIndex = 59
        Me.btnAgregarProducto.Text = "Agregar al evento"
        Me.ttpToolTip.SetToolTip(Me.btnAgregarProducto, "Agrega los productos de la lista al formulario del Evento")
        Me.btnAgregarProducto.UseVisualStyleBackColor = true
        '
        'Label7
        '
        Me.Label7.AutoSize = true
        Me.Label7.Location = New System.Drawing.Point(61, 75)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(77, 13)
        Me.Label7.TabIndex = 60
        Me.Label7.Text = "Tipo patrocinio"
        '
        'cboTipoPatrocinio
        '
        Me.cboTipoPatrocinio.FormattingEnabled = true
        Me.cboTipoPatrocinio.Items.AddRange(New Object() {"MERCANCIA", "EFECTIVO"})
        Me.cboTipoPatrocinio.Location = New System.Drawing.Point(144, 72)
        Me.cboTipoPatrocinio.Name = "cboTipoPatrocinio"
        Me.cboTipoPatrocinio.Size = New System.Drawing.Size(166, 21)
        Me.cboTipoPatrocinio.TabIndex = 61
        '
        'txtIdEvento
        '
        Me.txtIdEvento.Location = New System.Drawing.Point(-9, 339)
        Me.txtIdEvento.Name = "txtIdEvento"
        Me.txtIdEvento.Size = New System.Drawing.Size(18, 20)
        Me.txtIdEvento.TabIndex = 62
        Me.txtIdEvento.Visible = false
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
        'lblPatrocinador
        '
        Me.lblPatrocinador.AutoSize = true
        Me.lblPatrocinador.Location = New System.Drawing.Point(350, 75)
        Me.lblPatrocinador.Name = "lblPatrocinador"
        Me.lblPatrocinador.Size = New System.Drawing.Size(67, 13)
        Me.lblPatrocinador.TabIndex = 63
        Me.lblPatrocinador.Text = "Patrocinador"
        '
        'cboPatrocinador
        '
        Me.cboPatrocinador.FormattingEnabled = true
        Me.cboPatrocinador.Location = New System.Drawing.Point(419, 72)
        Me.cboPatrocinador.Name = "cboPatrocinador"
        Me.cboPatrocinador.Size = New System.Drawing.Size(158, 21)
        Me.cboPatrocinador.TabIndex = 64
        '
        'frmModalEventoProducto
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6!, 13!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1042, 454)
        Me.Controls.Add(Me.cboPatrocinador)
        Me.Controls.Add(Me.lblPatrocinador)
        Me.Controls.Add(Me.txtIdEvento)
        Me.Controls.Add(Me.cboTipoPatrocinio)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.btnAgregarProducto)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.dgvProductosEvento)
        Me.Controls.Add(Me.btnQuitar)
        Me.Controls.Add(Me.btnAgregar)
        Me.Controls.Add(Me.txtCosto)
        Me.Controls.Add(Me.txtTotal)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtCantidad)
        Me.Controls.Add(Me.txtProducto)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.dgvProductos)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "frmModalEventoProducto"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
        Me.Text = "Modal evento producto"
        CType(Me.dgvProductos,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.dgvProductosEvento,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.erProveedorError,System.ComponentModel.ISupportInitialize).EndInit
        Me.ResumeLayout(false)
        Me.PerformLayout

End Sub

    Friend WithEvents dgvProductos As DataGridView
    Friend WithEvents Label1 As Label
    Friend WithEvents txtProducto As TextBox
    Friend WithEvents txtCantidad As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents txtTotal As TextBox
    Friend WithEvents txtCosto As TextBox
    Friend WithEvents btnAgregar As Button
    Friend WithEvents btnQuitar As Button
    Friend WithEvents dgvProductosEvento As DataGridView
    Friend WithEvents erProveedorError As ErrorProvider
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents btnAgregarProducto As Button
    Friend WithEvents Label7 As Label
    Friend WithEvents cboTipoPatrocinio As ComboBox
    Friend WithEvents txtIdEvento As TextBox
    Friend WithEvents IdProducto As DataGridViewTextBoxColumn
    Friend WithEvents Producto As DataGridViewTextBoxColumn
    Friend WithEvents IdPatrocinador As DataGridViewTextBoxColumn
    Friend WithEvents Patrocinador As DataGridViewTextBoxColumn
    Friend WithEvents Costo As DataGridViewTextBoxColumn
    Friend WithEvents ttpToolTip As ToolTip
    Friend WithEvents CodProducto As DataGridViewTextBoxColumn
    Friend WithEvents Nom_Producto As DataGridViewTextBoxColumn
    Friend WithEvents CodPatrocinador As DataGridViewTextBoxColumn
    Friend WithEvents Nom_Patrocinador As DataGridViewTextBoxColumn
    Friend WithEvents Cantidad As DataGridViewTextBoxColumn
    Friend WithEvents TipoPatrocinio As DataGridViewTextBoxColumn
    Friend WithEvents Total As DataGridViewTextBoxColumn
    Friend WithEvents cboPatrocinador As ComboBox
    Friend WithEvents lblPatrocinador As Label
End Class
