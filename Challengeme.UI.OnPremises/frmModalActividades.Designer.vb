<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmModalActividades
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtNombreActividad = New System.Windows.Forms.TextBox()
        Me.dgvListaActividades = New System.Windows.Forms.DataGridView()
        Me.IdActividad = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Nombre = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Descripcion = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.dgvActividadEvento = New System.Windows.Forms.DataGridView()
        Me.CodActividad = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NomActividad = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DescripcionActividad = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.btnQuitar = New System.Windows.Forms.Button()
        Me.btnAgregar = New System.Windows.Forms.Button()
        Me.btnAgregarActividad = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtIdEvento = New System.Windows.Forms.TextBox()
        Me.txtIdActividad = New System.Windows.Forms.TextBox()
        Me.ttpToolTip = New System.Windows.Forms.ToolTip(Me.components)
        Me.lnkCrearActividad = New System.Windows.Forms.LinkLabel()
        CType(Me.dgvListaActividades,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.dgvActividadEvento,System.ComponentModel.ISupportInitialize).BeginInit
        Me.SuspendLayout
        '
        'Label1
        '
        Me.Label1.AutoSize = true
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.Label1.Location = New System.Drawing.Point(37, 70)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(123, 18)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Nombre actividad"
        '
        'txtNombreActividad
        '
        Me.txtNombreActividad.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.txtNombreActividad.Location = New System.Drawing.Point(175, 70)
        Me.txtNombreActividad.Name = "txtNombreActividad"
        Me.txtNombreActividad.Size = New System.Drawing.Size(266, 24)
        Me.txtNombreActividad.TabIndex = 1
        '
        'dgvListaActividades
        '
        Me.dgvListaActividades.AllowUserToAddRows = false
        Me.dgvListaActividades.AllowUserToDeleteRows = false
        Me.dgvListaActividades.BackgroundColor = System.Drawing.Color.White
        Me.dgvListaActividades.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvListaActividades.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IdActividad, Me.Nombre, Me.Descripcion})
        Me.dgvListaActividades.Location = New System.Drawing.Point(41, 153)
        Me.dgvListaActividades.Name = "dgvListaActividades"
        Me.dgvListaActividades.ReadOnly = true
        Me.dgvListaActividades.Size = New System.Drawing.Size(400, 155)
        Me.dgvListaActividades.TabIndex = 2
        '
        'IdActividad
        '
        Me.IdActividad.HeaderText = "IdActividad"
        Me.IdActividad.Name = "IdActividad"
        Me.IdActividad.ReadOnly = true
        Me.IdActividad.Visible = false
        '
        'Nombre
        '
        Me.Nombre.HeaderText = "Nombre"
        Me.Nombre.Name = "Nombre"
        Me.Nombre.ReadOnly = true
        Me.Nombre.Width = 150
        '
        'Descripcion
        '
        Me.Descripcion.HeaderText = "Descripción"
        Me.Descripcion.Name = "Descripcion"
        Me.Descripcion.ReadOnly = true
        Me.Descripcion.Width = 200
        '
        'Label3
        '
        Me.Label3.AutoSize = true
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.Label3.ForeColor = System.Drawing.SystemColors.ButtonShadow
        Me.Label3.Location = New System.Drawing.Point(49, 126)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(241, 24)
        Me.Label3.TabIndex = 57
        Me.Label3.Text = "Lista general de actividades"
        '
        'dgvActividadEvento
        '
        Me.dgvActividadEvento.AllowUserToAddRows = false
        Me.dgvActividadEvento.AllowUserToDeleteRows = false
        Me.dgvActividadEvento.BackgroundColor = System.Drawing.Color.White
        Me.dgvActividadEvento.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvActividadEvento.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.CodActividad, Me.NomActividad, Me.DescripcionActividad})
        Me.dgvActividadEvento.Location = New System.Drawing.Point(458, 153)
        Me.dgvActividadEvento.Name = "dgvActividadEvento"
        Me.dgvActividadEvento.ReadOnly = true
        Me.dgvActividadEvento.Size = New System.Drawing.Size(397, 155)
        Me.dgvActividadEvento.TabIndex = 58
        '
        'CodActividad
        '
        Me.CodActividad.HeaderText = "IdActividad"
        Me.CodActividad.Name = "CodActividad"
        Me.CodActividad.ReadOnly = true
        Me.CodActividad.Visible = false
        '
        'NomActividad
        '
        Me.NomActividad.HeaderText = "Actividad"
        Me.NomActividad.Name = "NomActividad"
        Me.NomActividad.ReadOnly = true
        Me.NomActividad.Width = 150
        '
        'DescripcionActividad
        '
        Me.DescripcionActividad.HeaderText = "Descricpción"
        Me.DescripcionActividad.Name = "DescripcionActividad"
        Me.DescripcionActividad.ReadOnly = true
        Me.DescripcionActividad.Width = 200
        '
        'btnQuitar
        '
        Me.btnQuitar.Location = New System.Drawing.Point(359, 118)
        Me.btnQuitar.Name = "btnQuitar"
        Me.btnQuitar.Size = New System.Drawing.Size(38, 29)
        Me.btnQuitar.TabIndex = 59
        Me.btnQuitar.Text = "<<"
        Me.ttpToolTip.SetToolTip(Me.btnQuitar, "Quita una actividad de la lista a agregar")
        Me.btnQuitar.UseVisualStyleBackColor = true
        '
        'btnAgregar
        '
        Me.btnAgregar.Location = New System.Drawing.Point(403, 118)
        Me.btnAgregar.Name = "btnAgregar"
        Me.btnAgregar.Size = New System.Drawing.Size(38, 29)
        Me.btnAgregar.TabIndex = 60
        Me.btnAgregar.Text = ">>"
        Me.ttpToolTip.SetToolTip(Me.btnAgregar, "Agrega una actividad a la lista del evento")
        Me.btnAgregar.UseVisualStyleBackColor = true
        '
        'btnAgregarActividad
        '
        Me.btnAgregarActividad.Location = New System.Drawing.Point(868, 153)
        Me.btnAgregarActividad.Name = "btnAgregarActividad"
        Me.btnAgregarActividad.Size = New System.Drawing.Size(116, 38)
        Me.btnAgregarActividad.TabIndex = 61
        Me.btnAgregarActividad.Text = "Agregar a evento"
        Me.ttpToolTip.SetToolTip(Me.btnAgregarActividad, "Agregas las actividades al evento")
        Me.btnAgregarActividad.UseVisualStyleBackColor = true
        '
        'Label2
        '
        Me.Label2.AutoSize = true
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.Label2.ForeColor = System.Drawing.SystemColors.ButtonShadow
        Me.Label2.Location = New System.Drawing.Point(468, 123)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(365, 24)
        Me.Label2.TabIndex = 62
        Me.Label2.Text = "Lista de actividades para agregar al evento"
        '
        'txtIdEvento
        '
        Me.txtIdEvento.Location = New System.Drawing.Point(-3, 314)
        Me.txtIdEvento.Name = "txtIdEvento"
        Me.txtIdEvento.Size = New System.Drawing.Size(24, 20)
        Me.txtIdEvento.TabIndex = 63
        Me.txtIdEvento.Visible = false
        '
        'txtIdActividad
        '
        Me.txtIdActividad.Location = New System.Drawing.Point(-3, 288)
        Me.txtIdActividad.Name = "txtIdActividad"
        Me.txtIdActividad.Size = New System.Drawing.Size(24, 20)
        Me.txtIdActividad.TabIndex = 64
        Me.txtIdActividad.Visible = false
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
        'lnkCrearActividad
        '
        Me.lnkCrearActividad.AutoSize = true
        Me.lnkCrearActividad.Location = New System.Drawing.Point(456, 74)
        Me.lnkCrearActividad.Name = "lnkCrearActividad"
        Me.lnkCrearActividad.Size = New System.Drawing.Size(78, 13)
        Me.lnkCrearActividad.TabIndex = 65
        Me.lnkCrearActividad.TabStop = true
        Me.lnkCrearActividad.Text = "Crear actividad"
        '
        'frmModalActividades
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6!, 13!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(996, 330)
        Me.Controls.Add(Me.lnkCrearActividad)
        Me.Controls.Add(Me.txtIdActividad)
        Me.Controls.Add(Me.txtIdEvento)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.btnAgregarActividad)
        Me.Controls.Add(Me.btnAgregar)
        Me.Controls.Add(Me.btnQuitar)
        Me.Controls.Add(Me.dgvActividadEvento)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.dgvListaActividades)
        Me.Controls.Add(Me.txtNombreActividad)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "frmModalActividades"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Modal actividades"
        CType(Me.dgvListaActividades,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.dgvActividadEvento,System.ComponentModel.ISupportInitialize).EndInit
        Me.ResumeLayout(false)
        Me.PerformLayout

End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents txtNombreActividad As TextBox
    Friend WithEvents dgvListaActividades As DataGridView
    Friend WithEvents IdActividad As DataGridViewTextBoxColumn
    Friend WithEvents Nombre As DataGridViewTextBoxColumn
    Friend WithEvents Descripcion As DataGridViewTextBoxColumn
    Friend WithEvents Label3 As Label
    Friend WithEvents dgvActividadEvento As DataGridView
    Friend WithEvents CodActividad As DataGridViewTextBoxColumn
    Friend WithEvents NomActividad As DataGridViewTextBoxColumn
    Friend WithEvents DescripcionActividad As DataGridViewTextBoxColumn
    Friend WithEvents btnQuitar As Button
    Friend WithEvents btnAgregar As Button
    Friend WithEvents btnAgregarActividad As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents txtIdEvento As TextBox
    Friend WithEvents txtIdActividad As TextBox
    Friend WithEvents ttpToolTip As ToolTip
    Friend WithEvents lnkCrearActividad As LinkLabel
End Class
