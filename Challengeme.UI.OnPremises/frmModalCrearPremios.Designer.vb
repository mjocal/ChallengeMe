<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmModalCrearPremios
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
        Me.txtDescripcionPremio = New System.Windows.Forms.TextBox()
        Me.txtNombrePremio = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtIdPremio = New System.Windows.Forms.TextBox()
        Me.LabelNombreEntidad = New System.Windows.Forms.Label()
        Me.LabelIdEntidad = New System.Windows.Forms.Label()
        Me.dgvListaPremios = New System.Windows.Forms.DataGridView()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Descripcion = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.btnGuardar = New System.Windows.Forms.Button()
        Me.erProveedorError = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.ttpToolTip = New System.Windows.Forms.ToolTip(Me.components)
        CType(Me.dgvListaPremios,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.erProveedorError,System.ComponentModel.ISupportInitialize).BeginInit
        Me.SuspendLayout
        '
        'txtDescripcionPremio
        '
        Me.txtDescripcionPremio.Font = New System.Drawing.Font("Microsoft Sans Serif", 9!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.txtDescripcionPremio.Location = New System.Drawing.Point(273, 102)
        Me.txtDescripcionPremio.Margin = New System.Windows.Forms.Padding(2)
        Me.txtDescripcionPremio.Multiline = true
        Me.txtDescripcionPremio.Name = "txtDescripcionPremio"
        Me.txtDescripcionPremio.Size = New System.Drawing.Size(185, 64)
        Me.txtDescripcionPremio.TabIndex = 59
        '
        'txtNombrePremio
        '
        Me.txtNombrePremio.Font = New System.Drawing.Font("Microsoft Sans Serif", 9!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.txtNombrePremio.Location = New System.Drawing.Point(273, 72)
        Me.txtNombrePremio.Margin = New System.Windows.Forms.Padding(2)
        Me.txtNombrePremio.Name = "txtNombrePremio"
        Me.txtNombrePremio.Size = New System.Drawing.Size(185, 21)
        Me.txtNombrePremio.TabIndex = 56
        '
        'Label1
        '
        Me.Label1.AutoSize = true
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.Label1.Location = New System.Drawing.Point(207, 102)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(63, 13)
        Me.Label1.TabIndex = 57
        Me.Label1.Text = "Descripción"
        '
        'txtIdPremio
        '
        Me.txtIdPremio.Font = New System.Drawing.Font("Microsoft Sans Serif", 9!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.txtIdPremio.Location = New System.Drawing.Point(273, 43)
        Me.txtIdPremio.Margin = New System.Windows.Forms.Padding(2)
        Me.txtIdPremio.Name = "txtIdPremio"
        Me.txtIdPremio.Size = New System.Drawing.Size(185, 21)
        Me.txtIdPremio.TabIndex = 60
        '
        'LabelNombreEntidad
        '
        Me.LabelNombreEntidad.AutoSize = true
        Me.LabelNombreEntidad.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.LabelNombreEntidad.Location = New System.Drawing.Point(207, 72)
        Me.LabelNombreEntidad.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.LabelNombreEntidad.Name = "LabelNombreEntidad"
        Me.LabelNombreEntidad.Size = New System.Drawing.Size(44, 13)
        Me.LabelNombreEntidad.TabIndex = 58
        Me.LabelNombreEntidad.Text = "Nombre"
        '
        'LabelIdEntidad
        '
        Me.LabelIdEntidad.AutoSize = true
        Me.LabelIdEntidad.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.LabelIdEntidad.Location = New System.Drawing.Point(207, 45)
        Me.LabelIdEntidad.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.LabelIdEntidad.Name = "LabelIdEntidad"
        Me.LabelIdEntidad.Size = New System.Drawing.Size(56, 13)
        Me.LabelIdEntidad.TabIndex = 55
        Me.LabelIdEntidad.Text = "ID. Premio"
        '
        'dgvListaPremios
        '
        Me.dgvListaPremios.AllowUserToAddRows = false
        Me.dgvListaPremios.AllowUserToDeleteRows = false
        Me.dgvListaPremios.BackgroundColor = System.Drawing.Color.White
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvListaPremios.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.dgvListaPremios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvListaPremios.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column1, Me.Column2, Me.Descripcion})
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvListaPremios.DefaultCellStyle = DataGridViewCellStyle2
        Me.dgvListaPremios.Location = New System.Drawing.Point(87, 170)
        Me.dgvListaPremios.Margin = New System.Windows.Forms.Padding(2)
        Me.dgvListaPremios.Name = "dgvListaPremios"
        Me.dgvListaPremios.ReadOnly = true
        Me.dgvListaPremios.RowTemplate.Height = 24
        Me.dgvListaPremios.Size = New System.Drawing.Size(565, 190)
        Me.dgvListaPremios.TabIndex = 61
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
        'Descripcion
        '
        Me.Descripcion.HeaderText = "Descripción"
        Me.Descripcion.Name = "Descripcion"
        Me.Descripcion.ReadOnly = true
        Me.Descripcion.Width = 300
        '
        'btnGuardar
        '
        Me.btnGuardar.Location = New System.Drawing.Point(474, 43)
        Me.btnGuardar.Name = "btnGuardar"
        Me.btnGuardar.Size = New System.Drawing.Size(97, 38)
        Me.btnGuardar.TabIndex = 62
        Me.btnGuardar.Text = "Guardar"
        Me.ttpToolTip.SetToolTip(Me.btnGuardar, "Crea un nuevo premio")
        Me.btnGuardar.UseVisualStyleBackColor = true
        '
        'erProveedorError
        '
        Me.erProveedorError.ContainerControl = Me
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
        'frmModalCrearPremios
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6!, 13!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(663, 371)
        Me.Controls.Add(Me.btnGuardar)
        Me.Controls.Add(Me.txtDescripcionPremio)
        Me.Controls.Add(Me.txtNombrePremio)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtIdPremio)
        Me.Controls.Add(Me.LabelNombreEntidad)
        Me.Controls.Add(Me.LabelIdEntidad)
        Me.Controls.Add(Me.dgvListaPremios)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "frmModalCrearPremios"
        Me.Text = "Modal crear premios"
        CType(Me.dgvListaPremios,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.erProveedorError,System.ComponentModel.ISupportInitialize).EndInit
        Me.ResumeLayout(false)
        Me.PerformLayout

End Sub

    Friend WithEvents txtDescripcionPremio As TextBox
    Friend WithEvents txtNombrePremio As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents txtIdPremio As TextBox
    Friend WithEvents LabelNombreEntidad As Label
    Friend WithEvents LabelIdEntidad As Label
    Friend WithEvents dgvListaPremios As DataGridView
    Friend WithEvents Column1 As DataGridViewTextBoxColumn
    Friend WithEvents Column2 As DataGridViewTextBoxColumn
    Friend WithEvents Descripcion As DataGridViewTextBoxColumn
    Friend WithEvents btnGuardar As Button
    Friend WithEvents erProveedorError As ErrorProvider
    Friend WithEvents ttpToolTip As ToolTip
End Class
