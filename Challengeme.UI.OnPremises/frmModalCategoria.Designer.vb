<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmModalCategoria
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
        Me.dgvListaCategorias = New System.Windows.Forms.DataGridView()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.txtNombreCategoria = New System.Windows.Forms.TextBox()
        Me.txtIdCategoria = New System.Windows.Forms.TextBox()
        Me.LabelNombreEntidad = New System.Windows.Forms.Label()
        Me.LabelIdEntidad = New System.Windows.Forms.Label()
        Me.btnAgregar = New System.Windows.Forms.Button()
        Me.btnGuardar = New System.Windows.Forms.Button()
        Me.ttpToolTip = New System.Windows.Forms.ToolTip(Me.components)
        Me.erProveedorError = New System.Windows.Forms.ErrorProvider(Me.components)
        CType(Me.dgvListaCategorias,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.erProveedorError,System.ComponentModel.ISupportInitialize).BeginInit
        Me.SuspendLayout
        '
        'dgvListaCategorias
        '
        Me.dgvListaCategorias.AllowUserToAddRows = false
        Me.dgvListaCategorias.AllowUserToDeleteRows = false
        Me.dgvListaCategorias.BackgroundColor = System.Drawing.Color.White
        Me.dgvListaCategorias.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvListaCategorias.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column1, Me.Column2})
        Me.dgvListaCategorias.Location = New System.Drawing.Point(173, 149)
        Me.dgvListaCategorias.Margin = New System.Windows.Forms.Padding(2)
        Me.dgvListaCategorias.Name = "dgvListaCategorias"
        Me.dgvListaCategorias.ReadOnly = true
        Me.dgvListaCategorias.RowTemplate.Height = 24
        Me.dgvListaCategorias.Size = New System.Drawing.Size(327, 122)
        Me.dgvListaCategorias.TabIndex = 11
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
        'txtNombreCategoria
        '
        Me.txtNombreCategoria.Font = New System.Drawing.Font("Microsoft Sans Serif", 9!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.txtNombreCategoria.Location = New System.Drawing.Point(227, 89)
        Me.txtNombreCategoria.Name = "txtNombreCategoria"
        Me.txtNombreCategoria.Size = New System.Drawing.Size(171, 21)
        Me.txtNombreCategoria.TabIndex = 13
        '
        'txtIdCategoria
        '
        Me.txtIdCategoria.Font = New System.Drawing.Font("Microsoft Sans Serif", 9!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.txtIdCategoria.Location = New System.Drawing.Point(226, 56)
        Me.txtIdCategoria.Name = "txtIdCategoria"
        Me.txtIdCategoria.Size = New System.Drawing.Size(172, 21)
        Me.txtIdCategoria.TabIndex = 12
        '
        'LabelNombreEntidad
        '
        Me.LabelNombreEntidad.AutoSize = true
        Me.LabelNombreEntidad.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.LabelNombreEntidad.Location = New System.Drawing.Point(147, 90)
        Me.LabelNombreEntidad.Name = "LabelNombreEntidad"
        Me.LabelNombreEntidad.Size = New System.Drawing.Size(44, 13)
        Me.LabelNombreEntidad.TabIndex = 10
        Me.LabelNombreEntidad.Text = "Nombre"
        '
        'LabelIdEntidad
        '
        Me.LabelIdEntidad.AutoSize = true
        Me.LabelIdEntidad.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.LabelIdEntidad.Location = New System.Drawing.Point(147, 60)
        Me.LabelIdEntidad.Name = "LabelIdEntidad"
        Me.LabelIdEntidad.Size = New System.Drawing.Size(71, 13)
        Me.LabelIdEntidad.TabIndex = 9
        Me.LabelIdEntidad.Text = "ID. Categoría"
        '
        'btnAgregar
        '
        Me.btnAgregar.Location = New System.Drawing.Point(505, 149)
        Me.btnAgregar.Name = "btnAgregar"
        Me.btnAgregar.Size = New System.Drawing.Size(117, 41)
        Me.btnAgregar.TabIndex = 14
        Me.btnAgregar.Text = "Agregar al evento"
        Me.ttpToolTip.SetToolTip(Me.btnAgregar, "Agrega la nueva categoría al evento")
        Me.btnAgregar.UseVisualStyleBackColor = true
        '
        'btnGuardar
        '
        Me.btnGuardar.Location = New System.Drawing.Point(410, 53)
        Me.btnGuardar.Name = "btnGuardar"
        Me.btnGuardar.Size = New System.Drawing.Size(90, 37)
        Me.btnGuardar.TabIndex = 15
        Me.btnGuardar.Text = "Guardar"
        Me.ttpToolTip.SetToolTip(Me.btnGuardar, "Guarda una nueva categoría")
        Me.btnGuardar.UseVisualStyleBackColor = true
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
        'frmModalCategoria
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6!, 13!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(702, 315)
        Me.Controls.Add(Me.btnGuardar)
        Me.Controls.Add(Me.btnAgregar)
        Me.Controls.Add(Me.dgvListaCategorias)
        Me.Controls.Add(Me.txtNombreCategoria)
        Me.Controls.Add(Me.txtIdCategoria)
        Me.Controls.Add(Me.LabelNombreEntidad)
        Me.Controls.Add(Me.LabelIdEntidad)
        Me.Name = "frmModalCategoria"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
        Me.Text = "Modal categoría"
        CType(Me.dgvListaCategorias,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.erProveedorError,System.ComponentModel.ISupportInitialize).EndInit
        Me.ResumeLayout(false)
        Me.PerformLayout

End Sub

    Friend WithEvents dgvListaCategorias As DataGridView
    Friend WithEvents Column1 As DataGridViewTextBoxColumn
    Friend WithEvents Column2 As DataGridViewTextBoxColumn
    Friend WithEvents txtNombreCategoria As TextBox
    Friend WithEvents txtIdCategoria As TextBox
    Friend WithEvents LabelNombreEntidad As Label
    Friend WithEvents LabelIdEntidad As Label
    Friend WithEvents btnAgregar As Button
    Friend WithEvents btnGuardar As Button
    Friend WithEvents ttpToolTip As ToolTip
    Friend WithEvents erProveedorError As ErrorProvider
End Class
