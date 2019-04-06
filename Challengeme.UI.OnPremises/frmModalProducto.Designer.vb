<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmModalProducto
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
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.dgvProductos = New System.Windows.Forms.DataGridView()
        Me.Id_Producto = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Producto = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Costo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtProducto = New System.Windows.Forms.TextBox()
        Me.btnPasarProducto = New System.Windows.Forms.Button()
        Me.btnSacarProducto = New System.Windows.Forms.Button()
        Me.dgvProductoAgregado = New System.Windows.Forms.DataGridView()
        Me.IdProducto = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Nom_Producto = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Costo_Producto = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.btnAgregar = New System.Windows.Forms.Button()
        Me.txtCodPatrocinador = New System.Windows.Forms.TextBox()
        Me.txtIdPatrocinador = New System.Windows.Forms.TextBox()
        Me.txtIdProducto = New System.Windows.Forms.TextBox()
        Me.ttpToolTip = New System.Windows.Forms.ToolTip(Me.components)
        Me.lnkCrearProducto = New System.Windows.Forms.LinkLabel()
        CType(Me.dgvProductos,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.dgvProductoAgregado,System.ComponentModel.ISupportInitialize).BeginInit
        Me.SuspendLayout
        '
        'dgvProductos
        '
        Me.dgvProductos.AllowUserToAddRows = false
        Me.dgvProductos.AllowUserToDeleteRows = false
        Me.dgvProductos.BackgroundColor = System.Drawing.Color.White
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.White
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvProductos.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.dgvProductos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvProductos.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Id_Producto, Me.Producto, Me.Costo})
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.White
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvProductos.DefaultCellStyle = DataGridViewCellStyle2
        Me.dgvProductos.Location = New System.Drawing.Point(30, 73)
        Me.dgvProductos.Name = "dgvProductos"
        Me.dgvProductos.ReadOnly = true
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.White
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvProductos.RowHeadersDefaultCellStyle = DataGridViewCellStyle3
        Me.dgvProductos.Size = New System.Drawing.Size(303, 237)
        Me.dgvProductos.TabIndex = 0
        '
        'Id_Producto
        '
        Me.Id_Producto.HeaderText = "IdProducto"
        Me.Id_Producto.Name = "Id_Producto"
        Me.Id_Producto.ReadOnly = true
        Me.Id_Producto.Visible = false
        '
        'Producto
        '
        Me.Producto.HeaderText = "Producto"
        Me.Producto.Name = "Producto"
        Me.Producto.ReadOnly = true
        Me.Producto.Width = 150
        '
        'Costo
        '
        Me.Costo.HeaderText = "Costo"
        Me.Costo.Name = "Costo"
        Me.Costo.ReadOnly = true
        '
        'Label1
        '
        Me.Label1.AutoSize = true
        Me.Label1.Location = New System.Drawing.Point(27, 37)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(50, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Producto"
        '
        'txtProducto
        '
        Me.txtProducto.Location = New System.Drawing.Point(85, 34)
        Me.txtProducto.Name = "txtProducto"
        Me.txtProducto.Size = New System.Drawing.Size(247, 20)
        Me.txtProducto.TabIndex = 2
        '
        'btnPasarProducto
        '
        Me.btnPasarProducto.Location = New System.Drawing.Point(343, 78)
        Me.btnPasarProducto.Name = "btnPasarProducto"
        Me.btnPasarProducto.Size = New System.Drawing.Size(105, 33)
        Me.btnPasarProducto.TabIndex = 3
        Me.btnPasarProducto.Text = ">>"
        Me.ttpToolTip.SetToolTip(Me.btnPasarProducto, "Agrega un producto a la lista de productos para un patrocinador")
        Me.btnPasarProducto.UseVisualStyleBackColor = true
        '
        'btnSacarProducto
        '
        Me.btnSacarProducto.Location = New System.Drawing.Point(345, 125)
        Me.btnSacarProducto.Name = "btnSacarProducto"
        Me.btnSacarProducto.Size = New System.Drawing.Size(105, 33)
        Me.btnSacarProducto.TabIndex = 4
        Me.btnSacarProducto.Text = "<<"
        Me.ttpToolTip.SetToolTip(Me.btnSacarProducto, "Quita un producto de la lista")
        Me.btnSacarProducto.UseVisualStyleBackColor = true
        '
        'dgvProductoAgregado
        '
        Me.dgvProductoAgregado.AllowUserToAddRows = false
        Me.dgvProductoAgregado.AllowUserToDeleteRows = false
        Me.dgvProductoAgregado.BackgroundColor = System.Drawing.Color.White
        Me.dgvProductoAgregado.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvProductoAgregado.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IdProducto, Me.Nom_Producto, Me.Costo_Producto})
        Me.dgvProductoAgregado.Location = New System.Drawing.Point(459, 73)
        Me.dgvProductoAgregado.Name = "dgvProductoAgregado"
        Me.dgvProductoAgregado.ReadOnly = true
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        DataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.White
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvProductoAgregado.RowHeadersDefaultCellStyle = DataGridViewCellStyle4
        Me.dgvProductoAgregado.Size = New System.Drawing.Size(298, 234)
        Me.dgvProductoAgregado.TabIndex = 5
        '
        'IdProducto
        '
        Me.IdProducto.HeaderText = "IdProducto"
        Me.IdProducto.Name = "IdProducto"
        Me.IdProducto.ReadOnly = true
        Me.IdProducto.Visible = false
        '
        'Nom_Producto
        '
        Me.Nom_Producto.HeaderText = "Producto"
        Me.Nom_Producto.Name = "Nom_Producto"
        Me.Nom_Producto.ReadOnly = true
        Me.Nom_Producto.Width = 150
        '
        'Costo_Producto
        '
        Me.Costo_Producto.HeaderText = "Costo"
        Me.Costo_Producto.Name = "Costo_Producto"
        Me.Costo_Producto.ReadOnly = true
        '
        'btnAgregar
        '
        Me.btnAgregar.Location = New System.Drawing.Point(763, 74)
        Me.btnAgregar.Name = "btnAgregar"
        Me.btnAgregar.Size = New System.Drawing.Size(92, 36)
        Me.btnAgregar.TabIndex = 6
        Me.btnAgregar.Text = "Agregar"
        Me.ttpToolTip.SetToolTip(Me.btnAgregar, "Agrega los productos de la lista al formulario de patrocinadores")
        Me.btnAgregar.UseVisualStyleBackColor = true
        '
        'txtCodPatrocinador
        '
        Me.txtCodPatrocinador.Location = New System.Drawing.Point(-4, 433)
        Me.txtCodPatrocinador.Name = "txtCodPatrocinador"
        Me.txtCodPatrocinador.Size = New System.Drawing.Size(20, 20)
        Me.txtCodPatrocinador.TabIndex = 7
        Me.txtCodPatrocinador.Visible = false
        '
        'txtIdPatrocinador
        '
        Me.txtIdPatrocinador.Location = New System.Drawing.Point(-4, 459)
        Me.txtIdPatrocinador.Name = "txtIdPatrocinador"
        Me.txtIdPatrocinador.Size = New System.Drawing.Size(21, 20)
        Me.txtIdPatrocinador.TabIndex = 9
        Me.txtIdPatrocinador.Visible = false
        '
        'txtIdProducto
        '
        Me.txtIdProducto.Location = New System.Drawing.Point(-4, 407)
        Me.txtIdProducto.Name = "txtIdProducto"
        Me.txtIdProducto.Size = New System.Drawing.Size(19, 20)
        Me.txtIdProducto.TabIndex = 10
        Me.txtIdProducto.Visible = false
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
        'lnkCrearProducto
        '
        Me.lnkCrearProducto.AutoSize = true
        Me.lnkCrearProducto.Location = New System.Drawing.Point(337, 38)
        Me.lnkCrearProducto.Name = "lnkCrearProducto"
        Me.lnkCrearProducto.Size = New System.Drawing.Size(77, 13)
        Me.lnkCrearProducto.TabIndex = 11
        Me.lnkCrearProducto.TabStop = true
        Me.lnkCrearProducto.Text = "Crear producto"
        '
        'frmModalProducto
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6!, 13!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(871, 358)
        Me.Controls.Add(Me.lnkCrearProducto)
        Me.Controls.Add(Me.txtIdProducto)
        Me.Controls.Add(Me.txtIdPatrocinador)
        Me.Controls.Add(Me.txtCodPatrocinador)
        Me.Controls.Add(Me.btnAgregar)
        Me.Controls.Add(Me.dgvProductoAgregado)
        Me.Controls.Add(Me.btnSacarProducto)
        Me.Controls.Add(Me.btnPasarProducto)
        Me.Controls.Add(Me.txtProducto)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.dgvProductos)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "frmModalProducto"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
        Me.Text = "Modal producto"
        CType(Me.dgvProductos,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.dgvProductoAgregado,System.ComponentModel.ISupportInitialize).EndInit
        Me.ResumeLayout(false)
        Me.PerformLayout

End Sub

    Friend WithEvents dgvProductos As DataGridView
    Friend WithEvents Label1 As Label
    Friend WithEvents txtProducto As TextBox
    Friend WithEvents btnPasarProducto As Button
    Friend WithEvents btnSacarProducto As Button
    Friend WithEvents dgvProductoAgregado As DataGridView
    Friend WithEvents btnAgregar As Button
    Friend WithEvents txtCodPatrocinador As TextBox
    Friend WithEvents IdProducto As DataGridViewTextBoxColumn
    Friend WithEvents Nom_Producto As DataGridViewTextBoxColumn
    Friend WithEvents Costo_Producto As DataGridViewTextBoxColumn
    Friend WithEvents txtIdPatrocinador As TextBox
    Friend WithEvents txtIdProducto As TextBox
    Friend WithEvents Id_Producto As DataGridViewTextBoxColumn
    Friend WithEvents Producto As DataGridViewTextBoxColumn
    Friend WithEvents Costo As DataGridViewTextBoxColumn
    Friend WithEvents ttpToolTip As ToolTip
    Friend WithEvents lnkCrearProducto As LinkLabel
End Class
