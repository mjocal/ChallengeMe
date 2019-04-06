<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmEventoRuta
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
        Me.GroupBoxEventoRuta = New System.Windows.Forms.GroupBox()
        Me.txtNombreEventoRuta = New System.Windows.Forms.TextBox()
        Me.LabelNombreEvento = New System.Windows.Forms.Label()
        Me.GroupBoxRutasDelEvento = New System.Windows.Forms.GroupBox()
        Me.DataGridViewRutasDelEvento = New System.Windows.Forms.DataGridView()
        Me.colIdRutaEvento = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GroupBoxControles = New System.Windows.Forms.GroupBox()
        Me.ButtonQuitar = New System.Windows.Forms.Button()
        Me.ButtonAgregar = New System.Windows.Forms.Button()
        Me.GroupBoxRutasDisponibles = New System.Windows.Forms.GroupBox()
        Me.DataGridViewRutasDisponibles = New System.Windows.Forms.DataGridView()
        Me.colIdRuta = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colNombreRuta = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colDireccionRuta = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ButtonEventoRutaOk = New System.Windows.Forms.Button()
        Me.GroupBoxEventoRuta.SuspendLayout()
        Me.GroupBoxRutasDelEvento.SuspendLayout()
        CType(Me.DataGridViewRutasDelEvento, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBoxControles.SuspendLayout()
        Me.GroupBoxRutasDisponibles.SuspendLayout()
        CType(Me.DataGridViewRutasDisponibles, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBoxEventoRuta
        '
        Me.GroupBoxEventoRuta.Controls.Add(Me.txtNombreEventoRuta)
        Me.GroupBoxEventoRuta.Controls.Add(Me.LabelNombreEvento)
        Me.GroupBoxEventoRuta.Location = New System.Drawing.Point(179, 21)
        Me.GroupBoxEventoRuta.Name = "GroupBoxEventoRuta"
        Me.GroupBoxEventoRuta.Size = New System.Drawing.Size(690, 68)
        Me.GroupBoxEventoRuta.TabIndex = 9
        Me.GroupBoxEventoRuta.TabStop = False
        Me.GroupBoxEventoRuta.Text = "Evento"
        '
        'txtNombreEventoRuta
        '
        Me.txtNombreEventoRuta.Location = New System.Drawing.Point(181, 28)
        Me.txtNombreEventoRuta.Name = "txtNombreEventoRuta"
        Me.txtNombreEventoRuta.ReadOnly = True
        Me.txtNombreEventoRuta.Size = New System.Drawing.Size(411, 20)
        Me.txtNombreEventoRuta.TabIndex = 4
        '
        'LabelNombreEvento
        '
        Me.LabelNombreEvento.AutoSize = True
        Me.LabelNombreEvento.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.LabelNombreEvento.Location = New System.Drawing.Point(77, 31)
        Me.LabelNombreEvento.Name = "LabelNombreEvento"
        Me.LabelNombreEvento.Size = New System.Drawing.Size(98, 13)
        Me.LabelNombreEvento.TabIndex = 3
        Me.LabelNombreEvento.Text = "Nombre del Evento"
        '
        'GroupBoxRutasDelEvento
        '
        Me.GroupBoxRutasDelEvento.Controls.Add(Me.DataGridViewRutasDelEvento)
        Me.GroupBoxRutasDelEvento.Location = New System.Drawing.Point(643, 106)
        Me.GroupBoxRutasDelEvento.Name = "GroupBoxRutasDelEvento"
        Me.GroupBoxRutasDelEvento.Size = New System.Drawing.Size(455, 441)
        Me.GroupBoxRutasDelEvento.TabIndex = 7
        Me.GroupBoxRutasDelEvento.TabStop = False
        Me.GroupBoxRutasDelEvento.Text = "Rutas Asignadas al Evento"
        '
        'DataGridViewRutasDelEvento
        '
        Me.DataGridViewRutasDelEvento.BackgroundColor = System.Drawing.SystemColors.ControlLightLight
        Me.DataGridViewRutasDelEvento.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridViewRutasDelEvento.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.colIdRutaEvento, Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2})
        Me.DataGridViewRutasDelEvento.Location = New System.Drawing.Point(22, 36)
        Me.DataGridViewRutasDelEvento.Name = "DataGridViewRutasDelEvento"
        Me.DataGridViewRutasDelEvento.Size = New System.Drawing.Size(408, 374)
        Me.DataGridViewRutasDelEvento.TabIndex = 0
        '
        'colIdRutaEvento
        '
        Me.colIdRutaEvento.HeaderText = "Id"
        Me.colIdRutaEvento.Name = "colIdRutaEvento"
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.HeaderText = "Nombre de la Ruta"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.Width = 200
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.HeaderText = "Direccion"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        Me.DataGridViewTextBoxColumn2.Width = 300
        '
        'GroupBoxControles
        '
        Me.GroupBoxControles.Controls.Add(Me.ButtonQuitar)
        Me.GroupBoxControles.Controls.Add(Me.ButtonAgregar)
        Me.GroupBoxControles.Location = New System.Drawing.Point(500, 195)
        Me.GroupBoxControles.Name = "GroupBoxControles"
        Me.GroupBoxControles.Size = New System.Drawing.Size(126, 195)
        Me.GroupBoxControles.TabIndex = 8
        Me.GroupBoxControles.TabStop = False
        Me.GroupBoxControles.Text = "Controles"
        '
        'ButtonQuitar
        '
        Me.ButtonQuitar.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!)
        Me.ButtonQuitar.Location = New System.Drawing.Point(14, 125)
        Me.ButtonQuitar.Name = "ButtonQuitar"
        Me.ButtonQuitar.Size = New System.Drawing.Size(99, 39)
        Me.ButtonQuitar.TabIndex = 1
        Me.ButtonQuitar.Text = "<<<"
        Me.ButtonQuitar.UseVisualStyleBackColor = True
        '
        'ButtonAgregar
        '
        Me.ButtonAgregar.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!)
        Me.ButtonAgregar.Location = New System.Drawing.Point(14, 39)
        Me.ButtonAgregar.Name = "ButtonAgregar"
        Me.ButtonAgregar.Size = New System.Drawing.Size(99, 39)
        Me.ButtonAgregar.TabIndex = 0
        Me.ButtonAgregar.Text = ">>>"
        Me.ButtonAgregar.UseVisualStyleBackColor = True
        '
        'GroupBoxRutasDisponibles
        '
        Me.GroupBoxRutasDisponibles.Controls.Add(Me.DataGridViewRutasDisponibles)
        Me.GroupBoxRutasDisponibles.Location = New System.Drawing.Point(27, 106)
        Me.GroupBoxRutasDisponibles.Name = "GroupBoxRutasDisponibles"
        Me.GroupBoxRutasDisponibles.Size = New System.Drawing.Size(455, 441)
        Me.GroupBoxRutasDisponibles.TabIndex = 6
        Me.GroupBoxRutasDisponibles.TabStop = False
        Me.GroupBoxRutasDisponibles.Text = "Rutas Disponibles"
        '
        'DataGridViewRutasDisponibles
        '
        Me.DataGridViewRutasDisponibles.BackgroundColor = System.Drawing.SystemColors.ControlLightLight
        Me.DataGridViewRutasDisponibles.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridViewRutasDisponibles.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.colIdRuta, Me.colNombreRuta, Me.colDireccionRuta})
        Me.DataGridViewRutasDisponibles.Location = New System.Drawing.Point(22, 36)
        Me.DataGridViewRutasDisponibles.Name = "DataGridViewRutasDisponibles"
        Me.DataGridViewRutasDisponibles.Size = New System.Drawing.Size(408, 374)
        Me.DataGridViewRutasDisponibles.TabIndex = 0
        '
        'colIdRuta
        '
        Me.colIdRuta.HeaderText = "Id"
        Me.colIdRuta.Name = "colIdRuta"
        '
        'colNombreRuta
        '
        Me.colNombreRuta.HeaderText = "Nombre de la Ruta"
        Me.colNombreRuta.Name = "colNombreRuta"
        Me.colNombreRuta.Width = 200
        '
        'colDireccionRuta
        '
        Me.colDireccionRuta.HeaderText = "Direccion"
        Me.colDireccionRuta.Name = "colDireccionRuta"
        Me.colDireccionRuta.Width = 300
        '
        'ButtonEventoRutaOk
        '
        Me.ButtonEventoRutaOk.Location = New System.Drawing.Point(989, 590)
        Me.ButtonEventoRutaOk.Name = "ButtonEventoRutaOk"
        Me.ButtonEventoRutaOk.Size = New System.Drawing.Size(109, 39)
        Me.ButtonEventoRutaOk.TabIndex = 10
        Me.ButtonEventoRutaOk.Text = "OK"
        Me.ButtonEventoRutaOk.UseVisualStyleBackColor = True
        '
        'frmEventoRuta
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1122, 642)
        Me.Controls.Add(Me.ButtonEventoRutaOk)
        Me.Controls.Add(Me.GroupBoxEventoRuta)
        Me.Controls.Add(Me.GroupBoxRutasDelEvento)
        Me.Controls.Add(Me.GroupBoxControles)
        Me.Controls.Add(Me.GroupBoxRutasDisponibles)
        Me.Name = "frmEventoRuta"
        Me.Text = "Administracion de las Rutas del Evento"
        Me.GroupBoxEventoRuta.ResumeLayout(False)
        Me.GroupBoxEventoRuta.PerformLayout()
        Me.GroupBoxRutasDelEvento.ResumeLayout(False)
        CType(Me.DataGridViewRutasDelEvento, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBoxControles.ResumeLayout(False)
        Me.GroupBoxRutasDisponibles.ResumeLayout(False)
        CType(Me.DataGridViewRutasDisponibles, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GroupBoxEventoRuta As GroupBox
    Friend WithEvents txtNombreEventoRuta As TextBox
    Friend WithEvents LabelNombreEvento As Label
    Friend WithEvents GroupBoxRutasDelEvento As GroupBox
    Friend WithEvents DataGridViewRutasDelEvento As DataGridView
    Friend WithEvents colIdRutaEvento As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
    Friend WithEvents GroupBoxControles As GroupBox
    Friend WithEvents ButtonQuitar As Button
    Friend WithEvents ButtonAgregar As Button
    Friend WithEvents GroupBoxRutasDisponibles As GroupBox
    Friend WithEvents DataGridViewRutasDisponibles As DataGridView
    Friend WithEvents colIdRuta As DataGridViewTextBoxColumn
    Friend WithEvents colNombreRuta As DataGridViewTextBoxColumn
    Friend WithEvents colDireccionRuta As DataGridViewTextBoxColumn
    Friend WithEvents ButtonEventoRutaOk As Button
End Class
