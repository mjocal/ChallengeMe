<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmDashboardAdministrador
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.dgvListaParticipanteEvento = New System.Windows.Forms.DataGridView()
        Me.NombreEvento = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FechaInicio = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CantidadPaticipantes = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Cupo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Porcentaje = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CantidadPatrocinadores = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Ingresos = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cboEvento = New System.Windows.Forms.ComboBox()
        Me.cboParticipante = New System.Windows.Forms.ComboBox()
        Me.cboIdPatrocinador = New System.Windows.Forms.ComboBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.lblFechaActual = New System.Windows.Forms.Label()
        Me.cboCodEvento = New System.Windows.Forms.ComboBox()
        CType(Me.dgvListaParticipanteEvento,System.ComponentModel.ISupportInitialize).BeginInit
        Me.SuspendLayout
        '
        'dgvListaParticipanteEvento
        '
        Me.dgvListaParticipanteEvento.AllowUserToAddRows = false
        Me.dgvListaParticipanteEvento.AllowUserToDeleteRows = false
        Me.dgvListaParticipanteEvento.BackgroundColor = System.Drawing.Color.White
        Me.dgvListaParticipanteEvento.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvListaParticipanteEvento.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.NombreEvento, Me.FechaInicio, Me.CantidadPaticipantes, Me.Cupo, Me.Porcentaje, Me.CantidadPatrocinadores, Me.Ingresos})
        Me.dgvListaParticipanteEvento.Location = New System.Drawing.Point(33, 111)
        Me.dgvListaParticipanteEvento.Name = "dgvListaParticipanteEvento"
        Me.dgvListaParticipanteEvento.ReadOnly = true
        Me.dgvListaParticipanteEvento.Size = New System.Drawing.Size(888, 149)
        Me.dgvListaParticipanteEvento.TabIndex = 3
        '
        'NombreEvento
        '
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.NombreEvento.DefaultCellStyle = DataGridViewCellStyle1
        Me.NombreEvento.HeaderText = "Evento"
        Me.NombreEvento.Name = "NombreEvento"
        Me.NombreEvento.ReadOnly = true
        Me.NombreEvento.Width = 270
        '
        'FechaInicio
        '
        Me.FechaInicio.HeaderText = "Fecha inicio evento"
        Me.FechaInicio.Name = "FechaInicio"
        Me.FechaInicio.ReadOnly = true
        '
        'CantidadPaticipantes
        '
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.CantidadPaticipantes.DefaultCellStyle = DataGridViewCellStyle2
        Me.CantidadPaticipantes.HeaderText = "Cantidad Paticipantes"
        Me.CantidadPaticipantes.Name = "CantidadPaticipantes"
        Me.CantidadPaticipantes.ReadOnly = true
        Me.CantidadPaticipantes.Width = 80
        '
        'Cupo
        '
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.Cupo.DefaultCellStyle = DataGridViewCellStyle3
        Me.Cupo.HeaderText = "Cupo"
        Me.Cupo.Name = "Cupo"
        Me.Cupo.ReadOnly = true
        '
        'Porcentaje
        '
        Me.Porcentaje.HeaderText = "% Participantes inscritos"
        Me.Porcentaje.Name = "Porcentaje"
        Me.Porcentaje.ReadOnly = true
        '
        'CantidadPatrocinadores
        '
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.CantidadPatrocinadores.DefaultCellStyle = DataGridViewCellStyle4
        Me.CantidadPatrocinadores.HeaderText = "Cantidad Patrocinadores"
        Me.CantidadPatrocinadores.Name = "CantidadPatrocinadores"
        Me.CantidadPatrocinadores.ReadOnly = true
        Me.CantidadPatrocinadores.Width = 90
        '
        'Ingresos
        '
        DataGridViewCellStyle5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.Ingresos.DefaultCellStyle = DataGridViewCellStyle5
        Me.Ingresos.HeaderText = "Ingresos por Patrocinio"
        Me.Ingresos.Name = "Ingresos"
        Me.Ingresos.ReadOnly = true
        '
        'cboEvento
        '
        Me.cboEvento.FormattingEnabled = true
        Me.cboEvento.Location = New System.Drawing.Point(19, 2)
        Me.cboEvento.Name = "cboEvento"
        Me.cboEvento.Size = New System.Drawing.Size(17, 21)
        Me.cboEvento.TabIndex = 11
        Me.cboEvento.Visible = false
        '
        'cboParticipante
        '
        Me.cboParticipante.FormattingEnabled = true
        Me.cboParticipante.Location = New System.Drawing.Point(12, 2)
        Me.cboParticipante.Name = "cboParticipante"
        Me.cboParticipante.Size = New System.Drawing.Size(16, 21)
        Me.cboParticipante.TabIndex = 12
        Me.cboParticipante.Visible = false
        '
        'cboIdPatrocinador
        '
        Me.cboIdPatrocinador.FormattingEnabled = true
        Me.cboIdPatrocinador.Location = New System.Drawing.Point(-1, 2)
        Me.cboIdPatrocinador.Name = "cboIdPatrocinador"
        Me.cboIdPatrocinador.Size = New System.Drawing.Size(14, 21)
        Me.cboIdPatrocinador.TabIndex = 13
        Me.cboIdPatrocinador.Visible = false
        '
        'Label3
        '
        Me.Label3.AutoSize = true
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.Label3.ForeColor = System.Drawing.SystemColors.ButtonShadow
        Me.Label3.Location = New System.Drawing.Point(29, 84)
        Me.Label3.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(923, 24)
        Me.Label3.TabIndex = 57
        Me.Label3.Text = "Próximos eventos con cantidad de personas inscritas y patrocinadores e ingresos p"& _ 
    "or concepto de patrocinio"
        '
        'lblFechaActual
        '
        Me.lblFechaActual.AutoSize = true
        Me.lblFechaActual.Location = New System.Drawing.Point(36, 45)
        Me.lblFechaActual.Name = "lblFechaActual"
        Me.lblFechaActual.Size = New System.Drawing.Size(39, 13)
        Me.lblFechaActual.TabIndex = 58
        Me.lblFechaActual.Text = "Label1"
        '
        'cboCodEvento
        '
        Me.cboCodEvento.FormattingEnabled = true
        Me.cboCodEvento.Location = New System.Drawing.Point(33, 2)
        Me.cboCodEvento.Name = "cboCodEvento"
        Me.cboCodEvento.Size = New System.Drawing.Size(13, 21)
        Me.cboCodEvento.TabIndex = 59
        Me.cboCodEvento.Visible = false
        '
        'frmDashboardAdministrador
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6!, 13!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(974, 437)
        Me.Controls.Add(Me.cboCodEvento)
        Me.Controls.Add(Me.lblFechaActual)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.cboIdPatrocinador)
        Me.Controls.Add(Me.cboParticipante)
        Me.Controls.Add(Me.cboEvento)
        Me.Controls.Add(Me.dgvListaParticipanteEvento)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmDashboardAdministrador"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Dashboard administrador"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.dgvListaParticipanteEvento,System.ComponentModel.ISupportInitialize).EndInit
        Me.ResumeLayout(false)
        Me.PerformLayout

End Sub

    Friend WithEvents dgvListaParticipanteEvento As DataGridView
    Friend WithEvents cboEvento As ComboBox
    Friend WithEvents cboParticipante As ComboBox
    Friend WithEvents cboIdPatrocinador As ComboBox
    Friend WithEvents Label3 As Label
    Friend WithEvents lblFechaActual As Label
    Friend WithEvents cboCodEvento As ComboBox
    Friend WithEvents NombreEvento As DataGridViewTextBoxColumn
    Friend WithEvents FechaInicio As DataGridViewTextBoxColumn
    Friend WithEvents CantidadPaticipantes As DataGridViewTextBoxColumn
    Friend WithEvents Cupo As DataGridViewTextBoxColumn
    Friend WithEvents Porcentaje As DataGridViewTextBoxColumn
    Friend WithEvents CantidadPatrocinadores As DataGridViewTextBoxColumn
    Friend WithEvents Ingresos As DataGridViewTextBoxColumn
End Class
