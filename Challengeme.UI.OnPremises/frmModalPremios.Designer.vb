<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmModalPremios
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
        Me.dgvListaPremios = New System.Windows.Forms.DataGridView()
        Me.IdPremio = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Nombre = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Descripcion = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.txtNombrePremio = New System.Windows.Forms.TextBox()
        Me.LabelNombreEntidad = New System.Windows.Forms.Label()
        Me.txtIdEvento = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.dgvPremioEvento = New System.Windows.Forms.DataGridView()
        Me.CodPremio = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NombrePremio = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DescripcionPremio = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnQuitar = New System.Windows.Forms.Button()
        Me.btnAgregar = New System.Windows.Forms.Button()
        Me.btnAgregarPremio = New System.Windows.Forms.Button()
        Me.txtIdPremio = New System.Windows.Forms.TextBox()
        Me.ttpToolTip = New System.Windows.Forms.ToolTip(Me.components)
        Me.lnkCrearPremios = New System.Windows.Forms.LinkLabel()
        CType(Me.dgvListaPremios,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.dgvPremioEvento,System.ComponentModel.ISupportInitialize).BeginInit
        Me.SuspendLayout
        '
        'dgvListaPremios
        '
        Me.dgvListaPremios.AllowUserToAddRows = false
        Me.dgvListaPremios.AllowUserToDeleteRows = false
        Me.dgvListaPremios.BackgroundColor = System.Drawing.Color.White
        Me.dgvListaPremios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvListaPremios.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IdPremio, Me.Nombre, Me.Descripcion})
        Me.dgvListaPremios.Location = New System.Drawing.Point(33, 171)
        Me.dgvListaPremios.Margin = New System.Windows.Forms.Padding(2)
        Me.dgvListaPremios.Name = "dgvListaPremios"
        Me.dgvListaPremios.ReadOnly = true
        Me.dgvListaPremios.RowTemplate.Height = 24
        Me.dgvListaPremios.Size = New System.Drawing.Size(452, 141)
        Me.dgvListaPremios.TabIndex = 57
        '
        'IdPremio
        '
        Me.IdPremio.HeaderText = "IdPremio "
        Me.IdPremio.Name = "IdPremio"
        Me.IdPremio.ReadOnly = true
        Me.IdPremio.Visible = false
        Me.IdPremio.Width = 80
        '
        'Nombre
        '
        Me.Nombre.HeaderText = "Nombre"
        Me.Nombre.Name = "Nombre"
        Me.Nombre.ReadOnly = true
        Me.Nombre.Width = 200
        '
        'Descripcion
        '
        Me.Descripcion.HeaderText = "Descripción"
        Me.Descripcion.Name = "Descripcion"
        Me.Descripcion.ReadOnly = true
        Me.Descripcion.Width = 200
        '
        'txtNombrePremio
        '
        Me.txtNombrePremio.Font = New System.Drawing.Font("Open Sans", 9!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.txtNombrePremio.Location = New System.Drawing.Point(33, 93)
        Me.txtNombrePremio.Name = "txtNombrePremio"
        Me.txtNombrePremio.Size = New System.Drawing.Size(420, 24)
        Me.txtNombrePremio.TabIndex = 55
        '
        'LabelNombreEntidad
        '
        Me.LabelNombreEntidad.AutoSize = true
        Me.LabelNombreEntidad.Font = New System.Drawing.Font("Open Sans", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.LabelNombreEntidad.Location = New System.Drawing.Point(40, 70)
        Me.LabelNombreEntidad.Name = "LabelNombreEntidad"
        Me.LabelNombreEntidad.Size = New System.Drawing.Size(66, 20)
        Me.LabelNombreEntidad.TabIndex = 56
        Me.LabelNombreEntidad.Text = "Nombre"
        '
        'txtIdEvento
        '
        Me.txtIdEvento.Location = New System.Drawing.Point(-9, 314)
        Me.txtIdEvento.Name = "txtIdEvento"
        Me.txtIdEvento.Size = New System.Drawing.Size(32, 20)
        Me.txtIdEvento.TabIndex = 58
        Me.txtIdEvento.Visible = false
        '
        'Label5
        '
        Me.Label5.AutoSize = true
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.Label5.ForeColor = System.Drawing.SystemColors.ButtonShadow
        Me.Label5.Location = New System.Drawing.Point(40, 145)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(216, 24)
        Me.Label5.TabIndex = 59
        Me.Label5.Text = "Lista general de premios"
        '
        'dgvPremioEvento
        '
        Me.dgvPremioEvento.AllowUserToAddRows = false
        Me.dgvPremioEvento.AllowUserToDeleteRows = false
        Me.dgvPremioEvento.BackgroundColor = System.Drawing.Color.White
        Me.dgvPremioEvento.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvPremioEvento.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.CodPremio, Me.NombrePremio, Me.DescripcionPremio})
        Me.dgvPremioEvento.Location = New System.Drawing.Point(490, 172)
        Me.dgvPremioEvento.Name = "dgvPremioEvento"
        Me.dgvPremioEvento.ReadOnly = true
        Me.dgvPremioEvento.Size = New System.Drawing.Size(445, 139)
        Me.dgvPremioEvento.TabIndex = 60
        '
        'CodPremio
        '
        Me.CodPremio.HeaderText = "IdPremio"
        Me.CodPremio.Name = "CodPremio"
        Me.CodPremio.ReadOnly = true
        Me.CodPremio.Visible = false
        '
        'NombrePremio
        '
        Me.NombrePremio.HeaderText = "Premio"
        Me.NombrePremio.Name = "NombrePremio"
        Me.NombrePremio.ReadOnly = true
        Me.NombrePremio.Width = 200
        '
        'DescripcionPremio
        '
        Me.DescripcionPremio.HeaderText = "Descripción"
        Me.DescripcionPremio.Name = "DescripcionPremio"
        Me.DescripcionPremio.ReadOnly = true
        Me.DescripcionPremio.Width = 200
        '
        'Label1
        '
        Me.Label1.AutoSize = true
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ButtonShadow
        Me.Label1.Location = New System.Drawing.Point(490, 145)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(313, 24)
        Me.Label1.TabIndex = 61
        Me.Label1.Text = "Lista de premios a agregar al evento"
        '
        'btnQuitar
        '
        Me.btnQuitar.Location = New System.Drawing.Point(400, 134)
        Me.btnQuitar.Name = "btnQuitar"
        Me.btnQuitar.Size = New System.Drawing.Size(39, 32)
        Me.btnQuitar.TabIndex = 62
        Me.btnQuitar.Text = "<<"
        Me.ttpToolTip.SetToolTip(Me.btnQuitar, "Quita un premio de la lista de premios agregados")
        Me.btnQuitar.UseVisualStyleBackColor = true
        '
        'btnAgregar
        '
        Me.btnAgregar.Location = New System.Drawing.Point(445, 134)
        Me.btnAgregar.Name = "btnAgregar"
        Me.btnAgregar.Size = New System.Drawing.Size(39, 32)
        Me.btnAgregar.TabIndex = 63
        Me.btnAgregar.Text = ">>"
        Me.ttpToolTip.SetToolTip(Me.btnAgregar, "Agrega un premio a lista de premios para el evento")
        Me.btnAgregar.UseVisualStyleBackColor = true
        '
        'btnAgregarPremio
        '
        Me.btnAgregarPremio.Location = New System.Drawing.Point(825, 128)
        Me.btnAgregarPremio.Name = "btnAgregarPremio"
        Me.btnAgregarPremio.Size = New System.Drawing.Size(110, 38)
        Me.btnAgregarPremio.TabIndex = 64
        Me.btnAgregarPremio.Text = "Agregar a evento"
        Me.ttpToolTip.SetToolTip(Me.btnAgregarPremio, "Agrega los premios de la lista al evento")
        Me.btnAgregarPremio.UseVisualStyleBackColor = true
        '
        'txtIdPremio
        '
        Me.txtIdPremio.Location = New System.Drawing.Point(-9, 288)
        Me.txtIdPremio.Name = "txtIdPremio"
        Me.txtIdPremio.Size = New System.Drawing.Size(32, 20)
        Me.txtIdPremio.TabIndex = 65
        Me.txtIdPremio.Visible = false
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
        'lnkCrearPremios
        '
        Me.lnkCrearPremios.AutoSize = true
        Me.lnkCrearPremios.Location = New System.Drawing.Point(462, 96)
        Me.lnkCrearPremios.Name = "lnkCrearPremios"
        Me.lnkCrearPremios.Size = New System.Drawing.Size(71, 13)
        Me.lnkCrearPremios.TabIndex = 66
        Me.lnkCrearPremios.TabStop = true
        Me.lnkCrearPremios.Text = "Crear premios"
        '
        'frmModalPremios
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6!, 13!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1018, 346)
        Me.Controls.Add(Me.lnkCrearPremios)
        Me.Controls.Add(Me.txtIdPremio)
        Me.Controls.Add(Me.btnAgregarPremio)
        Me.Controls.Add(Me.btnAgregar)
        Me.Controls.Add(Me.btnQuitar)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.dgvPremioEvento)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.txtIdEvento)
        Me.Controls.Add(Me.dgvListaPremios)
        Me.Controls.Add(Me.txtNombrePremio)
        Me.Controls.Add(Me.LabelNombreEntidad)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "frmModalPremios"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Modal premios"
        CType(Me.dgvListaPremios,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.dgvPremioEvento,System.ComponentModel.ISupportInitialize).EndInit
        Me.ResumeLayout(false)
        Me.PerformLayout

End Sub

    Friend WithEvents dgvListaPremios As DataGridView
    Friend WithEvents txtNombrePremio As TextBox
    Friend WithEvents LabelNombreEntidad As Label
    Friend WithEvents txtIdEvento As TextBox
    Friend WithEvents IdPremio As DataGridViewTextBoxColumn
    Friend WithEvents Nombre As DataGridViewTextBoxColumn
    Friend WithEvents Descripcion As DataGridViewTextBoxColumn
    Friend WithEvents Label5 As Label
    Friend WithEvents dgvPremioEvento As DataGridView
    Friend WithEvents CodPremio As DataGridViewTextBoxColumn
    Friend WithEvents NombrePremio As DataGridViewTextBoxColumn
    Friend WithEvents DescripcionPremio As DataGridViewTextBoxColumn
    Friend WithEvents Label1 As Label
    Friend WithEvents btnQuitar As Button
    Friend WithEvents btnAgregar As Button
    Friend WithEvents btnAgregarPremio As Button
    Friend WithEvents txtIdPremio As TextBox
    Friend WithEvents ttpToolTip As ToolTip
    Friend WithEvents lnkCrearPremios As LinkLabel
End Class
