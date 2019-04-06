<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmPagos
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
        Me.txtIdPago = New System.Windows.Forms.TextBox()
        Me.txtIdUsuario = New System.Windows.Forms.TextBox()
        Me.txtMetodo = New System.Windows.Forms.TextBox()
        Me.txtEstadoPago = New System.Windows.Forms.TextBox()
        Me.txtMontoPago = New System.Windows.Forms.TextBox()
        Me.txtImpuestoPago = New System.Windows.Forms.TextBox()
        Me.txtDescuento = New System.Windows.Forms.TextBox()
        Me.txtTotalPago = New System.Windows.Forms.TextBox()
        Me.LabelIdPago = New System.Windows.Forms.Label()
        Me.LabelIdUsuario = New System.Windows.Forms.Label()
        Me.LabelMetodoPago = New System.Windows.Forms.Label()
        Me.LabelEstadoPago = New System.Windows.Forms.Label()
        Me.LabelMontoPago = New System.Windows.Forms.Label()
        Me.LabelImpuestoPago = New System.Windows.Forms.Label()
        Me.LabelDescuentoPago = New System.Windows.Forms.Label()
        Me.LabelTotalPago = New System.Windows.Forms.Label()
        Me.txtDetallePago = New System.Windows.Forms.TextBox()
        Me.LabelDetallePago = New System.Windows.Forms.Label()
        Me.LabelFechaPago = New System.Windows.Forms.Label()
        Me.DateTimePickerFechaPago = New System.Windows.Forms.DateTimePicker()
        Me.GroupBoxDetallePagos = New System.Windows.Forms.GroupBox()
        Me.DataGridViewPagos = New System.Windows.Forms.DataGridView()
        Me.GroupBoxTablaPagos = New System.Windows.Forms.GroupBox()
        Me.colIdPago = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colIdUsuario = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colMetodoPago = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colMontoPago = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colDescuentoPago = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colImpuestoVentaPago = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colTotalPago = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colDetalle = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colFechaPago = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colEstadoPago = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GroupBoxDetallePagos.SuspendLayout
        CType(Me.DataGridViewPagos,System.ComponentModel.ISupportInitialize).BeginInit
        Me.GroupBoxTablaPagos.SuspendLayout
        Me.SuspendLayout
        '
        'txtIdPago
        '
        Me.txtIdPago.Location = New System.Drawing.Point(63, 28)
        Me.txtIdPago.Name = "txtIdPago"
        Me.txtIdPago.Size = New System.Drawing.Size(100, 20)
        Me.txtIdPago.TabIndex = 0
        '
        'txtIdUsuario
        '
        Me.txtIdUsuario.Location = New System.Drawing.Point(63, 67)
        Me.txtIdUsuario.Name = "txtIdUsuario"
        Me.txtIdUsuario.Size = New System.Drawing.Size(100, 20)
        Me.txtIdUsuario.TabIndex = 1
        '
        'txtMetodo
        '
        Me.txtMetodo.Location = New System.Drawing.Point(230, 28)
        Me.txtMetodo.Name = "txtMetodo"
        Me.txtMetodo.Size = New System.Drawing.Size(100, 20)
        Me.txtMetodo.TabIndex = 2
        '
        'txtEstadoPago
        '
        Me.txtEstadoPago.Location = New System.Drawing.Point(230, 70)
        Me.txtEstadoPago.Name = "txtEstadoPago"
        Me.txtEstadoPago.Size = New System.Drawing.Size(100, 20)
        Me.txtEstadoPago.TabIndex = 3
        '
        'txtMontoPago
        '
        Me.txtMontoPago.Location = New System.Drawing.Point(390, 28)
        Me.txtMontoPago.Name = "txtMontoPago"
        Me.txtMontoPago.Size = New System.Drawing.Size(100, 20)
        Me.txtMontoPago.TabIndex = 4
        '
        'txtImpuestoPago
        '
        Me.txtImpuestoPago.Location = New System.Drawing.Point(890, 26)
        Me.txtImpuestoPago.Name = "txtImpuestoPago"
        Me.txtImpuestoPago.Size = New System.Drawing.Size(83, 20)
        Me.txtImpuestoPago.TabIndex = 5
        '
        'txtDescuento
        '
        Me.txtDescuento.Location = New System.Drawing.Point(573, 28)
        Me.txtDescuento.Name = "txtDescuento"
        Me.txtDescuento.Size = New System.Drawing.Size(100, 20)
        Me.txtDescuento.TabIndex = 6
        '
        'txtTotalPago
        '
        Me.txtTotalPago.Location = New System.Drawing.Point(730, 27)
        Me.txtTotalPago.Name = "txtTotalPago"
        Me.txtTotalPago.Size = New System.Drawing.Size(100, 20)
        Me.txtTotalPago.TabIndex = 7
        '
        'LabelIdPago
        '
        Me.LabelIdPago.AutoSize = true
        Me.LabelIdPago.Location = New System.Drawing.Point(13, 29)
        Me.LabelIdPago.Name = "LabelIdPago"
        Me.LabelIdPago.Size = New System.Drawing.Size(44, 13)
        Me.LabelIdPago.TabIndex = 8
        Me.LabelIdPago.Text = "Id Ruta"
        '
        'LabelIdUsuario
        '
        Me.LabelIdUsuario.AutoSize = true
        Me.LabelIdUsuario.Location = New System.Drawing.Point(3, 70)
        Me.LabelIdUsuario.Name = "LabelIdUsuario"
        Me.LabelIdUsuario.Size = New System.Drawing.Size(55, 13)
        Me.LabelIdUsuario.TabIndex = 9
        Me.LabelIdUsuario.Text = "Id Usuario"
        '
        'LabelMetodoPago
        '
        Me.LabelMetodoPago.AutoSize = true
        Me.LabelMetodoPago.Location = New System.Drawing.Point(181, 31)
        Me.LabelMetodoPago.Name = "LabelMetodoPago"
        Me.LabelMetodoPago.Size = New System.Drawing.Size(43, 13)
        Me.LabelMetodoPago.TabIndex = 10
        Me.LabelMetodoPago.Text = "Método"
        '
        'LabelEstadoPago
        '
        Me.LabelEstadoPago.AutoSize = true
        Me.LabelEstadoPago.Location = New System.Drawing.Point(181, 73)
        Me.LabelEstadoPago.Name = "LabelEstadoPago"
        Me.LabelEstadoPago.Size = New System.Drawing.Size(40, 13)
        Me.LabelEstadoPago.TabIndex = 11
        Me.LabelEstadoPago.Text = "Estado"
        '
        'LabelMontoPago
        '
        Me.LabelMontoPago.AutoSize = true
        Me.LabelMontoPago.Location = New System.Drawing.Point(347, 30)
        Me.LabelMontoPago.Name = "LabelMontoPago"
        Me.LabelMontoPago.Size = New System.Drawing.Size(37, 13)
        Me.LabelMontoPago.TabIndex = 12
        Me.LabelMontoPago.Text = "Monto"
        '
        'LabelImpuestoPago
        '
        Me.LabelImpuestoPago.AutoSize = true
        Me.LabelImpuestoPago.Location = New System.Drawing.Point(834, 29)
        Me.LabelImpuestoPago.Name = "LabelImpuestoPago"
        Me.LabelImpuestoPago.Size = New System.Drawing.Size(50, 13)
        Me.LabelImpuestoPago.TabIndex = 13
        Me.LabelImpuestoPago.Text = "Impuesto"
        '
        'LabelDescuentoPago
        '
        Me.LabelDescuentoPago.AutoSize = true
        Me.LabelDescuentoPago.Location = New System.Drawing.Point(508, 30)
        Me.LabelDescuentoPago.Name = "LabelDescuentoPago"
        Me.LabelDescuentoPago.Size = New System.Drawing.Size(59, 13)
        Me.LabelDescuentoPago.TabIndex = 14
        Me.LabelDescuentoPago.Text = "Descuento"
        '
        'LabelTotalPago
        '
        Me.LabelTotalPago.AutoSize = true
        Me.LabelTotalPago.Location = New System.Drawing.Point(693, 31)
        Me.LabelTotalPago.Name = "LabelTotalPago"
        Me.LabelTotalPago.Size = New System.Drawing.Size(31, 13)
        Me.LabelTotalPago.TabIndex = 15
        Me.LabelTotalPago.Text = "Total"
        '
        'txtDetallePago
        '
        Me.txtDetallePago.Location = New System.Drawing.Point(649, 73)
        Me.txtDetallePago.Name = "txtDetallePago"
        Me.txtDetallePago.Size = New System.Drawing.Size(324, 20)
        Me.txtDetallePago.TabIndex = 16
        '
        'LabelDetallePago
        '
        Me.LabelDetallePago.AutoSize = true
        Me.LabelDetallePago.Location = New System.Drawing.Point(603, 76)
        Me.LabelDetallePago.Name = "LabelDetallePago"
        Me.LabelDetallePago.Size = New System.Drawing.Size(40, 13)
        Me.LabelDetallePago.TabIndex = 18
        Me.LabelDetallePago.Text = "Detalle"
        '
        'LabelFechaPago
        '
        Me.LabelFechaPago.AutoSize = true
        Me.LabelFechaPago.Location = New System.Drawing.Point(344, 76)
        Me.LabelFechaPago.Name = "LabelFechaPago"
        Me.LabelFechaPago.Size = New System.Drawing.Size(37, 13)
        Me.LabelFechaPago.TabIndex = 19
        Me.LabelFechaPago.Text = "Fecha"
        '
        'DateTimePickerFechaPago
        '
        Me.DateTimePickerFechaPago.Location = New System.Drawing.Point(390, 73)
        Me.DateTimePickerFechaPago.Name = "DateTimePickerFechaPago"
        Me.DateTimePickerFechaPago.Size = New System.Drawing.Size(200, 20)
        Me.DateTimePickerFechaPago.TabIndex = 20
        '
        'GroupBoxDetallePagos
        '
        Me.GroupBoxDetallePagos.Controls.Add(Me.txtMetodo)
        Me.GroupBoxDetallePagos.Controls.Add(Me.DateTimePickerFechaPago)
        Me.GroupBoxDetallePagos.Controls.Add(Me.txtIdPago)
        Me.GroupBoxDetallePagos.Controls.Add(Me.LabelFechaPago)
        Me.GroupBoxDetallePagos.Controls.Add(Me.txtIdUsuario)
        Me.GroupBoxDetallePagos.Controls.Add(Me.LabelDetallePago)
        Me.GroupBoxDetallePagos.Controls.Add(Me.txtEstadoPago)
        Me.GroupBoxDetallePagos.Controls.Add(Me.txtDetallePago)
        Me.GroupBoxDetallePagos.Controls.Add(Me.txtMontoPago)
        Me.GroupBoxDetallePagos.Controls.Add(Me.LabelTotalPago)
        Me.GroupBoxDetallePagos.Controls.Add(Me.txtImpuestoPago)
        Me.GroupBoxDetallePagos.Controls.Add(Me.LabelDescuentoPago)
        Me.GroupBoxDetallePagos.Controls.Add(Me.txtDescuento)
        Me.GroupBoxDetallePagos.Controls.Add(Me.LabelImpuestoPago)
        Me.GroupBoxDetallePagos.Controls.Add(Me.txtTotalPago)
        Me.GroupBoxDetallePagos.Controls.Add(Me.LabelMontoPago)
        Me.GroupBoxDetallePagos.Controls.Add(Me.LabelIdPago)
        Me.GroupBoxDetallePagos.Controls.Add(Me.LabelEstadoPago)
        Me.GroupBoxDetallePagos.Controls.Add(Me.LabelIdUsuario)
        Me.GroupBoxDetallePagos.Controls.Add(Me.LabelMetodoPago)
        Me.GroupBoxDetallePagos.Location = New System.Drawing.Point(12, 12)
        Me.GroupBoxDetallePagos.Name = "GroupBoxDetallePagos"
        Me.GroupBoxDetallePagos.Size = New System.Drawing.Size(987, 111)
        Me.GroupBoxDetallePagos.TabIndex = 21
        Me.GroupBoxDetallePagos.TabStop = false
        Me.GroupBoxDetallePagos.Text = "Detalle de Ruta"
        '
        'DataGridViewPagos
        '
        Me.DataGridViewPagos.BackgroundColor = System.Drawing.Color.White
        Me.DataGridViewPagos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridViewPagos.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.colIdPago, Me.colIdUsuario, Me.colMetodoPago, Me.colMontoPago, Me.colDescuentoPago, Me.colImpuestoVentaPago, Me.colTotalPago, Me.colDetalle, Me.colFechaPago, Me.colEstadoPago})
        Me.DataGridViewPagos.Location = New System.Drawing.Point(29, 19)
        Me.DataGridViewPagos.Name = "DataGridViewPagos"
        Me.DataGridViewPagos.Size = New System.Drawing.Size(934, 285)
        Me.DataGridViewPagos.TabIndex = 23
        '
        'GroupBoxTablaPagos
        '
        Me.GroupBoxTablaPagos.Controls.Add(Me.DataGridViewPagos)
        Me.GroupBoxTablaPagos.Location = New System.Drawing.Point(12, 129)
        Me.GroupBoxTablaPagos.Name = "GroupBoxTablaPagos"
        Me.GroupBoxTablaPagos.Size = New System.Drawing.Size(987, 310)
        Me.GroupBoxTablaPagos.TabIndex = 24
        Me.GroupBoxTablaPagos.TabStop = false
        Me.GroupBoxTablaPagos.Text = "Tabla Pagos"
        '
        'colIdPago
        '
        Me.colIdPago.HeaderText = "Id"
        Me.colIdPago.Name = "colIdPago"
        Me.colIdPago.Width = 70
        '
        'colIdUsuario
        '
        Me.colIdUsuario.HeaderText = "Id Usuario"
        Me.colIdUsuario.Name = "colIdUsuario"
        '
        'colMetodoPago
        '
        Me.colMetodoPago.HeaderText = "Método"
        Me.colMetodoPago.Name = "colMetodoPago"
        '
        'colMontoPago
        '
        Me.colMontoPago.HeaderText = "Monto"
        Me.colMontoPago.Name = "colMontoPago"
        Me.colMontoPago.Width = 70
        '
        'colDescuentoPago
        '
        Me.colDescuentoPago.HeaderText = "Descuento"
        Me.colDescuentoPago.Name = "colDescuentoPago"
        Me.colDescuentoPago.Width = 70
        '
        'colImpuestoVentaPago
        '
        Me.colImpuestoVentaPago.HeaderText = "I.V."
        Me.colImpuestoVentaPago.Name = "colImpuestoVentaPago"
        Me.colImpuestoVentaPago.Width = 76
        '
        'colTotalPago
        '
        Me.colTotalPago.HeaderText = "Total"
        Me.colTotalPago.Name = "colTotalPago"
        Me.colTotalPago.Width = 70
        '
        'colDetalle
        '
        Me.colDetalle.HeaderText = "Detalle"
        Me.colDetalle.Name = "colDetalle"
        Me.colDetalle.Width = 135
        '
        'colFechaPago
        '
        Me.colFechaPago.HeaderText = "Fecha"
        Me.colFechaPago.Name = "colFechaPago"
        '
        'colEstadoPago
        '
        Me.colEstadoPago.HeaderText = "Estado"
        Me.colEstadoPago.Name = "colEstadoPago"
        '
        'frmPagos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6!, 13!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1024, 451)
        Me.Controls.Add(Me.GroupBoxTablaPagos)
        Me.Controls.Add(Me.GroupBoxDetallePagos)
        Me.Name = "frmPagos"
        Me.Text = "Pagos"
        Me.GroupBoxDetallePagos.ResumeLayout(false)
        Me.GroupBoxDetallePagos.PerformLayout
        CType(Me.DataGridViewPagos,System.ComponentModel.ISupportInitialize).EndInit
        Me.GroupBoxTablaPagos.ResumeLayout(false)
        Me.ResumeLayout(false)

End Sub

    Friend WithEvents txtIdPago As TextBox
    Friend WithEvents txtIdUsuario As TextBox
    Friend WithEvents txtMetodo As TextBox
    Friend WithEvents txtEstadoPago As TextBox
    Friend WithEvents txtMontoPago As TextBox
    Friend WithEvents txtImpuestoPago As TextBox
    Friend WithEvents txtDescuento As TextBox
    Friend WithEvents txtTotalPago As TextBox
    Friend WithEvents LabelIdPago As Label
    Friend WithEvents LabelIdUsuario As Label
    Friend WithEvents LabelMetodoPago As Label
    Friend WithEvents LabelEstadoPago As Label
    Friend WithEvents LabelMontoPago As Label
    Friend WithEvents LabelImpuestoPago As Label
    Friend WithEvents LabelDescuentoPago As Label
    Friend WithEvents LabelTotalPago As Label
    Friend WithEvents txtDetallePago As TextBox
    Friend WithEvents LabelDetallePago As Label
    Friend WithEvents LabelFechaPago As Label
    Friend WithEvents DateTimePickerFechaPago As DateTimePicker
    Friend WithEvents GroupBoxDetallePagos As GroupBox
    Friend WithEvents DataGridViewPagos As DataGridView
    Friend WithEvents GroupBoxTablaPagos As GroupBox
    Friend WithEvents colIdPago As DataGridViewTextBoxColumn
    Friend WithEvents colIdUsuario As DataGridViewTextBoxColumn
    Friend WithEvents colMetodoPago As DataGridViewTextBoxColumn
    Friend WithEvents colMontoPago As DataGridViewTextBoxColumn
    Friend WithEvents colDescuentoPago As DataGridViewTextBoxColumn
    Friend WithEvents colImpuestoVentaPago As DataGridViewTextBoxColumn
    Friend WithEvents colTotalPago As DataGridViewTextBoxColumn
    Friend WithEvents colDetalle As DataGridViewTextBoxColumn
    Friend WithEvents colFechaPago As DataGridViewTextBoxColumn
    Friend WithEvents colEstadoPago As DataGridViewTextBoxColumn
End Class
