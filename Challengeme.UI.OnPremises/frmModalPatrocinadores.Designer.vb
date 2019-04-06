<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmModalPatrocinadores
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
        Me.txtNombrePatrocinador = New System.Windows.Forms.TextBox()
        Me.LabelNombrePatrocinador = New System.Windows.Forms.Label()
        Me.dgvPatrocinadores = New System.Windows.Forms.DataGridView()
        Me.ID = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Nombre = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Monto = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.dgvPatrocinadores,System.ComponentModel.ISupportInitialize).BeginInit
        Me.SuspendLayout
        '
        'txtNombrePatrocinador
        '
        Me.txtNombrePatrocinador.Font = New System.Drawing.Font("Microsoft Sans Serif", 9!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.txtNombrePatrocinador.Location = New System.Drawing.Point(151, 53)
        Me.txtNombrePatrocinador.Name = "txtNombrePatrocinador"
        Me.txtNombrePatrocinador.Size = New System.Drawing.Size(418, 21)
        Me.txtNombrePatrocinador.TabIndex = 4
        '
        'LabelNombrePatrocinador
        '
        Me.LabelNombrePatrocinador.AutoSize = true
        Me.LabelNombrePatrocinador.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.LabelNombrePatrocinador.Location = New System.Drawing.Point(96, 57)
        Me.LabelNombrePatrocinador.Name = "LabelNombrePatrocinador"
        Me.LabelNombrePatrocinador.Size = New System.Drawing.Size(44, 13)
        Me.LabelNombrePatrocinador.TabIndex = 3
        Me.LabelNombrePatrocinador.Text = "Nombre"
        '
        'dgvPatrocinadores
        '
        Me.dgvPatrocinadores.BackgroundColor = System.Drawing.Color.White
        Me.dgvPatrocinadores.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvPatrocinadores.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.ID, Me.Nombre, Me.Monto})
        Me.dgvPatrocinadores.Location = New System.Drawing.Point(63, 115)
        Me.dgvPatrocinadores.Name = "dgvPatrocinadores"
        Me.dgvPatrocinadores.Size = New System.Drawing.Size(553, 180)
        Me.dgvPatrocinadores.TabIndex = 5
        '
        'ID
        '
        Me.ID.HeaderText = "Id"
        Me.ID.Name = "ID"
        Me.ID.Visible = false
        '
        'Nombre
        '
        Me.Nombre.HeaderText = "Nombre"
        Me.Nombre.Name = "Nombre"
        Me.Nombre.Width = 350
        '
        'Monto
        '
        Me.Monto.HeaderText = "Monto"
        Me.Monto.Name = "Monto"
        Me.Monto.Width = 150
        '
        'frmModalPatrocinadores
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6!, 13!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(685, 358)
        Me.Controls.Add(Me.dgvPatrocinadores)
        Me.Controls.Add(Me.txtNombrePatrocinador)
        Me.Controls.Add(Me.LabelNombrePatrocinador)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "frmModalPatrocinadores"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Modal patrocinadores"
        CType(Me.dgvPatrocinadores,System.ComponentModel.ISupportInitialize).EndInit
        Me.ResumeLayout(false)
        Me.PerformLayout

End Sub

    Friend WithEvents txtNombrePatrocinador As TextBox
    Friend WithEvents LabelNombrePatrocinador As Label
    Friend WithEvents dgvPatrocinadores As DataGridView
    Friend WithEvents ID As DataGridViewTextBoxColumn
    Friend WithEvents Nombre As DataGridViewTextBoxColumn
    Friend WithEvents Monto As DataGridViewTextBoxColumn
End Class
