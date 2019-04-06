<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmModalCrearActividad
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
        Me.txtDescripcionActividad = New System.Windows.Forms.TextBox()
        Me.txtNombreActividad = New System.Windows.Forms.TextBox()
        Me.txtIdActividad = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.LabelNombreEntidad = New System.Windows.Forms.Label()
        Me.LabelIdEntidad = New System.Windows.Forms.Label()
        Me.dgvListaActividades = New System.Windows.Forms.DataGridView()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.btnGuardar = New System.Windows.Forms.Button()
        Me.ttpToolTip = New System.Windows.Forms.ToolTip(Me.components)
        CType(Me.dgvListaActividades,System.ComponentModel.ISupportInitialize).BeginInit
        Me.SuspendLayout
        '
        'txtDescripcionActividad
        '
        Me.txtDescripcionActividad.Font = New System.Drawing.Font("Microsoft Sans Serif", 9!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.txtDescripcionActividad.Location = New System.Drawing.Point(295, 118)
        Me.txtDescripcionActividad.Multiline = true
        Me.txtDescripcionActividad.Name = "txtDescripcionActividad"
        Me.txtDescripcionActividad.Size = New System.Drawing.Size(173, 62)
        Me.txtDescripcionActividad.TabIndex = 13
        '
        'txtNombreActividad
        '
        Me.txtNombreActividad.Font = New System.Drawing.Font("Microsoft Sans Serif", 9!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.txtNombreActividad.Location = New System.Drawing.Point(295, 83)
        Me.txtNombreActividad.Name = "txtNombreActividad"
        Me.txtNombreActividad.Size = New System.Drawing.Size(173, 21)
        Me.txtNombreActividad.TabIndex = 10
        '
        'txtIdActividad
        '
        Me.txtIdActividad.Font = New System.Drawing.Font("Microsoft Sans Serif", 9!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.txtIdActividad.Location = New System.Drawing.Point(295, 50)
        Me.txtIdActividad.Name = "txtIdActividad"
        Me.txtIdActividad.Size = New System.Drawing.Size(172, 21)
        Me.txtIdActividad.TabIndex = 14
        '
        'Label1
        '
        Me.Label1.AutoSize = true
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.Label1.Location = New System.Drawing.Point(222, 122)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(63, 13)
        Me.Label1.TabIndex = 11
        Me.Label1.Text = "Descripcion"
        '
        'LabelNombreEntidad
        '
        Me.LabelNombreEntidad.AutoSize = true
        Me.LabelNombreEntidad.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.LabelNombreEntidad.Location = New System.Drawing.Point(222, 87)
        Me.LabelNombreEntidad.Name = "LabelNombreEntidad"
        Me.LabelNombreEntidad.Size = New System.Drawing.Size(44, 13)
        Me.LabelNombreEntidad.TabIndex = 12
        Me.LabelNombreEntidad.Text = "Nombre"
        '
        'LabelIdEntidad
        '
        Me.LabelIdEntidad.AutoSize = true
        Me.LabelIdEntidad.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.LabelIdEntidad.Location = New System.Drawing.Point(222, 53)
        Me.LabelIdEntidad.Name = "LabelIdEntidad"
        Me.LabelIdEntidad.Size = New System.Drawing.Size(68, 13)
        Me.LabelIdEntidad.TabIndex = 9
        Me.LabelIdEntidad.Text = "ID. Actividad"
        '
        'dgvListaActividades
        '
        Me.dgvListaActividades.AllowUserToAddRows = false
        Me.dgvListaActividades.AllowUserToDeleteRows = false
        Me.dgvListaActividades.BackgroundColor = System.Drawing.Color.White
        Me.dgvListaActividades.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvListaActividades.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column1, Me.Column2, Me.Column3})
        Me.dgvListaActividades.Location = New System.Drawing.Point(110, 221)
        Me.dgvListaActividades.Margin = New System.Windows.Forms.Padding(2)
        Me.dgvListaActividades.Name = "dgvListaActividades"
        Me.dgvListaActividades.ReadOnly = true
        Me.dgvListaActividades.RowTemplate.Height = 24
        Me.dgvListaActividades.Size = New System.Drawing.Size(557, 122)
        Me.dgvListaActividades.TabIndex = 15
        '
        'Column1
        '
        Me.Column1.HeaderText = "Id "
        Me.Column1.Name = "Column1"
        Me.Column1.ReadOnly = true
        Me.Column1.Width = 60
        '
        'Column2
        '
        Me.Column2.HeaderText = "Nombre"
        Me.Column2.Name = "Column2"
        Me.Column2.ReadOnly = true
        Me.Column2.Width = 150
        '
        'Column3
        '
        Me.Column3.HeaderText = "Descripcion"
        Me.Column3.Name = "Column3"
        Me.Column3.ReadOnly = true
        Me.Column3.Width = 300
        '
        'btnGuardar
        '
        Me.btnGuardar.Location = New System.Drawing.Point(473, 43)
        Me.btnGuardar.Name = "btnGuardar"
        Me.btnGuardar.Size = New System.Drawing.Size(88, 33)
        Me.btnGuardar.TabIndex = 16
        Me.btnGuardar.Text = "Guardar"
        Me.ttpToolTip.SetToolTip(Me.btnGuardar, "Crea una nueva actividad")
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
        'frmModalCrearActividad
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6!, 13!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(708, 386)
        Me.Controls.Add(Me.btnGuardar)
        Me.Controls.Add(Me.txtDescripcionActividad)
        Me.Controls.Add(Me.txtNombreActividad)
        Me.Controls.Add(Me.txtIdActividad)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.LabelNombreEntidad)
        Me.Controls.Add(Me.LabelIdEntidad)
        Me.Controls.Add(Me.dgvListaActividades)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "frmModalCrearActividad"
        Me.Text = "Modal crear actividad"
        CType(Me.dgvListaActividades,System.ComponentModel.ISupportInitialize).EndInit
        Me.ResumeLayout(false)
        Me.PerformLayout

End Sub

    Friend WithEvents txtDescripcionActividad As TextBox
    Friend WithEvents txtNombreActividad As TextBox
    Friend WithEvents txtIdActividad As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents LabelNombreEntidad As Label
    Friend WithEvents LabelIdEntidad As Label
    Friend WithEvents dgvListaActividades As DataGridView
    Friend WithEvents Column1 As DataGridViewTextBoxColumn
    Friend WithEvents Column2 As DataGridViewTextBoxColumn
    Friend WithEvents Column3 As DataGridViewTextBoxColumn
    Friend WithEvents btnGuardar As Button
    Friend WithEvents ttpToolTip As ToolTip
End Class
