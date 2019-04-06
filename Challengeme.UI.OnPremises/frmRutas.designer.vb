<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmRutas
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.mapaRutas = New GMap.NET.WindowsForms.GMapControl()
        Me.txtDireccionRuta = New System.Windows.Forms.TextBox()
        Me.LabelLugar = New System.Windows.Forms.Label()
        Me.ButtonIrALugar = New System.Windows.Forms.Button()
        Me.MapaContainer = New System.Windows.Forms.GroupBox()
        Me.viewPoints = New System.Windows.Forms.GroupBox()
        Me.DataGridViewPuntoRuta = New System.Windows.Forms.DataGridView()
        Me.colIdPuntoRuta = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colNombrePunto = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colLongitud = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colLatitud = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ButtonGuardarDireccion = New System.Windows.Forms.Button()
        Me.GroupBoxDireccion = New System.Windows.Forms.GroupBox()
        Me.ButtonBorrarRuta = New System.Windows.Forms.Button()
        Me.ButtonModificarRuta = New System.Windows.Forms.Button()
        Me.txtNombreRuta = New System.Windows.Forms.TextBox()
        Me.LabelNombreRuta = New System.Windows.Forms.Label()
        Me.txtIdRuta = New System.Windows.Forms.TextBox()
        Me.GroupBoxRutasGuardadas = New System.Windows.Forms.GroupBox()
        Me.ButtonLimpiar = New System.Windows.Forms.Button()
        Me.ComboBoxRutas = New System.Windows.Forms.ComboBox()
        Me.GroupBoxPuntosRuta = New System.Windows.Forms.GroupBox()
        Me.LabelDistancia = New System.Windows.Forms.Label()
        Me.txtDistanciaTotal = New System.Windows.Forms.TextBox()
        Me.txtIdPuntoRuta = New System.Windows.Forms.TextBox()
        Me.ButtonLimpiarCampos = New System.Windows.Forms.Button()
        Me.ButtonBorrarPunto = New System.Windows.Forms.Button()
        Me.ButtonModificarPunto = New System.Windows.Forms.Button()
        Me.ButtonAgregarPunto = New System.Windows.Forms.Button()
        Me.txtLongitudPuntoRuta = New System.Windows.Forms.TextBox()
        Me.LabelLongitud = New System.Windows.Forms.Label()
        Me.txtLatitudPuntoRuta = New System.Windows.Forms.TextBox()
        Me.LabelLatitud = New System.Windows.Forms.Label()
        Me.txtNombrePuntoRuta = New System.Windows.Forms.TextBox()
        Me.LabelNombrePunto = New System.Windows.Forms.Label()
        Me.cboCargarPermisos = New System.Windows.Forms.ComboBox()
        Me.MapaContainer.SuspendLayout
        Me.viewPoints.SuspendLayout
        CType(Me.DataGridViewPuntoRuta,System.ComponentModel.ISupportInitialize).BeginInit
        Me.GroupBoxDireccion.SuspendLayout
        Me.GroupBoxRutasGuardadas.SuspendLayout
        Me.GroupBoxPuntosRuta.SuspendLayout
        Me.SuspendLayout
        '
        'mapaRutas
        '
        Me.mapaRutas.Bearing = 0!
        Me.mapaRutas.CanDragMap = true
        Me.mapaRutas.EmptyTileColor = System.Drawing.Color.Navy
        Me.mapaRutas.GrayScaleMode = false
        Me.mapaRutas.HelperLineOption = GMap.NET.WindowsForms.HelperLineOptions.DontShow
        Me.mapaRutas.LevelsKeepInMemmory = 5
        Me.mapaRutas.Location = New System.Drawing.Point(6, 19)
        Me.mapaRutas.MarkersEnabled = true
        Me.mapaRutas.MaxZoom = 18
        Me.mapaRutas.MinZoom = 2
        Me.mapaRutas.MouseWheelZoomEnabled = true
        Me.mapaRutas.MouseWheelZoomType = GMap.NET.MouseWheelZoomType.MousePositionAndCenter
        Me.mapaRutas.Name = "mapaRutas"
        Me.mapaRutas.NegativeMode = false
        Me.mapaRutas.PolygonsEnabled = true
        Me.mapaRutas.RetryLoadTile = 0
        Me.mapaRutas.RoutesEnabled = true
        Me.mapaRutas.ScaleMode = GMap.NET.WindowsForms.ScaleModes.[Integer]
        Me.mapaRutas.SelectedAreaFillColor = System.Drawing.Color.FromArgb(CType(CType(33,Byte),Integer), CType(CType(65,Byte),Integer), CType(CType(105,Byte),Integer), CType(CType(225,Byte),Integer))
        Me.mapaRutas.ShowTileGridLines = false
        Me.mapaRutas.Size = New System.Drawing.Size(924, 516)
        Me.mapaRutas.TabIndex = 0
        Me.mapaRutas.Zoom = 17R
        '
        'txtDireccionRuta
        '
        Me.txtDireccionRuta.Location = New System.Drawing.Point(74, 77)
        Me.txtDireccionRuta.Name = "txtDireccionRuta"
        Me.txtDireccionRuta.Size = New System.Drawing.Size(421, 20)
        Me.txtDireccionRuta.TabIndex = 1
        '
        'LabelLugar
        '
        Me.LabelLugar.AutoSize = true
        Me.LabelLugar.Location = New System.Drawing.Point(11, 80)
        Me.LabelLugar.Name = "LabelLugar"
        Me.LabelLugar.Size = New System.Drawing.Size(52, 13)
        Me.LabelLugar.TabIndex = 2
        Me.LabelLugar.Text = "Dirección"
        '
        'ButtonIrALugar
        '
        Me.ButtonIrALugar.Location = New System.Drawing.Point(501, 75)
        Me.ButtonIrALugar.Name = "ButtonIrALugar"
        Me.ButtonIrALugar.Size = New System.Drawing.Size(115, 23)
        Me.ButtonIrALugar.TabIndex = 3
        Me.ButtonIrALugar.Text = "Ir a esta dirección"
        Me.ButtonIrALugar.UseVisualStyleBackColor = true
        '
        'MapaContainer
        '
        Me.MapaContainer.Controls.Add(Me.mapaRutas)
        Me.MapaContainer.Location = New System.Drawing.Point(357, 248)
        Me.MapaContainer.Name = "MapaContainer"
        Me.MapaContainer.Size = New System.Drawing.Size(947, 541)
        Me.MapaContainer.TabIndex = 4
        Me.MapaContainer.TabStop = false
        Me.MapaContainer.Text = "Mapa"
        '
        'viewPoints
        '
        Me.viewPoints.Controls.Add(Me.DataGridViewPuntoRuta)
        Me.viewPoints.Location = New System.Drawing.Point(13, 248)
        Me.viewPoints.Name = "viewPoints"
        Me.viewPoints.Size = New System.Drawing.Size(338, 541)
        Me.viewPoints.TabIndex = 5
        Me.viewPoints.TabStop = false
        Me.viewPoints.Text = "Puntos de Ruta"
        '
        'DataGridViewPuntoRuta
        '
        Me.DataGridViewPuntoRuta.AccessibleRole = System.Windows.Forms.AccessibleRole.None
        Me.DataGridViewPuntoRuta.BackgroundColor = System.Drawing.SystemColors.ControlLightLight
        Me.DataGridViewPuntoRuta.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridViewPuntoRuta.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.colIdPuntoRuta, Me.colNombrePunto, Me.colLongitud, Me.colLatitud})
        Me.DataGridViewPuntoRuta.GridColor = System.Drawing.SystemColors.ControlDarkDark
        Me.DataGridViewPuntoRuta.Location = New System.Drawing.Point(6, 19)
        Me.DataGridViewPuntoRuta.Name = "DataGridViewPuntoRuta"
        Me.DataGridViewPuntoRuta.Size = New System.Drawing.Size(326, 516)
        Me.DataGridViewPuntoRuta.TabIndex = 0
        '
        'colIdPuntoRuta
        '
        Me.colIdPuntoRuta.HeaderText = "Id"
        Me.colIdPuntoRuta.Name = "colIdPuntoRuta"
        Me.colIdPuntoRuta.Width = 50
        '
        'colNombrePunto
        '
        Me.colNombrePunto.HeaderText = "Nombre"
        Me.colNombrePunto.Name = "colNombrePunto"
        Me.colNombrePunto.Width = 73
        '
        'colLongitud
        '
        Me.colLongitud.HeaderText = "Longitud"
        Me.colLongitud.Name = "colLongitud"
        Me.colLongitud.Width = 80
        '
        'colLatitud
        '
        Me.colLatitud.HeaderText = "Latitud"
        Me.colLatitud.Name = "colLatitud"
        Me.colLatitud.Width = 80
        '
        'ButtonGuardarDireccion
        '
        Me.ButtonGuardarDireccion.Enabled = false
        Me.ButtonGuardarDireccion.Location = New System.Drawing.Point(667, 20)
        Me.ButtonGuardarDireccion.Name = "ButtonGuardarDireccion"
        Me.ButtonGuardarDireccion.Size = New System.Drawing.Size(125, 29)
        Me.ButtonGuardarDireccion.TabIndex = 7
        Me.ButtonGuardarDireccion.Text = "Guardar  Ruta"
        Me.ButtonGuardarDireccion.UseVisualStyleBackColor = true
        '
        'GroupBoxDireccion
        '
        Me.GroupBoxDireccion.Controls.Add(Me.ButtonBorrarRuta)
        Me.GroupBoxDireccion.Controls.Add(Me.ButtonModificarRuta)
        Me.GroupBoxDireccion.Controls.Add(Me.txtNombreRuta)
        Me.GroupBoxDireccion.Controls.Add(Me.LabelNombreRuta)
        Me.GroupBoxDireccion.Controls.Add(Me.txtIdRuta)
        Me.GroupBoxDireccion.Controls.Add(Me.ButtonGuardarDireccion)
        Me.GroupBoxDireccion.Controls.Add(Me.ButtonIrALugar)
        Me.GroupBoxDireccion.Controls.Add(Me.txtDireccionRuta)
        Me.GroupBoxDireccion.Controls.Add(Me.LabelLugar)
        Me.GroupBoxDireccion.Location = New System.Drawing.Point(506, 23)
        Me.GroupBoxDireccion.Name = "GroupBoxDireccion"
        Me.GroupBoxDireccion.Size = New System.Drawing.Size(798, 129)
        Me.GroupBoxDireccion.TabIndex = 8
        Me.GroupBoxDireccion.TabStop = false
        Me.GroupBoxDireccion.Text = "Ruta"
        '
        'ButtonBorrarRuta
        '
        Me.ButtonBorrarRuta.Enabled = false
        Me.ButtonBorrarRuta.Location = New System.Drawing.Point(667, 90)
        Me.ButtonBorrarRuta.Name = "ButtonBorrarRuta"
        Me.ButtonBorrarRuta.Size = New System.Drawing.Size(125, 27)
        Me.ButtonBorrarRuta.TabIndex = 13
        Me.ButtonBorrarRuta.Text = "Borrar Ruta"
        Me.ButtonBorrarRuta.UseVisualStyleBackColor = true
        '
        'ButtonModificarRuta
        '
        Me.ButtonModificarRuta.Enabled = false
        Me.ButtonModificarRuta.Location = New System.Drawing.Point(667, 56)
        Me.ButtonModificarRuta.Name = "ButtonModificarRuta"
        Me.ButtonModificarRuta.Size = New System.Drawing.Size(125, 28)
        Me.ButtonModificarRuta.TabIndex = 12
        Me.ButtonModificarRuta.Text = "Modificar Ruta"
        Me.ButtonModificarRuta.UseVisualStyleBackColor = true
        '
        'txtNombreRuta
        '
        Me.txtNombreRuta.Location = New System.Drawing.Point(74, 32)
        Me.txtNombreRuta.Name = "txtNombreRuta"
        Me.txtNombreRuta.Size = New System.Drawing.Size(254, 20)
        Me.txtNombreRuta.TabIndex = 11
        '
        'LabelNombreRuta
        '
        Me.LabelNombreRuta.AutoSize = true
        Me.LabelNombreRuta.Location = New System.Drawing.Point(11, 39)
        Me.LabelNombreRuta.Name = "LabelNombreRuta"
        Me.LabelNombreRuta.Size = New System.Drawing.Size(44, 13)
        Me.LabelNombreRuta.TabIndex = 10
        Me.LabelNombreRuta.Text = "Nombre"
        '
        'txtIdRuta
        '
        Me.txtIdRuta.Location = New System.Drawing.Point(371, 32)
        Me.txtIdRuta.Name = "txtIdRuta"
        Me.txtIdRuta.Size = New System.Drawing.Size(124, 20)
        Me.txtIdRuta.TabIndex = 9
        Me.txtIdRuta.Visible = false
        '
        'GroupBoxRutasGuardadas
        '
        Me.GroupBoxRutasGuardadas.Controls.Add(Me.ButtonLimpiar)
        Me.GroupBoxRutasGuardadas.Controls.Add(Me.ComboBoxRutas)
        Me.GroupBoxRutasGuardadas.Location = New System.Drawing.Point(506, 158)
        Me.GroupBoxRutasGuardadas.Name = "GroupBoxRutasGuardadas"
        Me.GroupBoxRutasGuardadas.Size = New System.Drawing.Size(798, 84)
        Me.GroupBoxRutasGuardadas.TabIndex = 9
        Me.GroupBoxRutasGuardadas.TabStop = false
        Me.GroupBoxRutasGuardadas.Text = "Rutas Guardadas"
        '
        'ButtonLimpiar
        '
        Me.ButtonLimpiar.Location = New System.Drawing.Point(567, 32)
        Me.ButtonLimpiar.Name = "ButtonLimpiar"
        Me.ButtonLimpiar.Size = New System.Drawing.Size(125, 27)
        Me.ButtonLimpiar.TabIndex = 14
        Me.ButtonLimpiar.Text = "Limpiar"
        Me.ButtonLimpiar.UseVisualStyleBackColor = true
        '
        'ComboBoxRutas
        '
        Me.ComboBoxRutas.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBoxRutas.FormattingEnabled = true
        Me.ComboBoxRutas.Location = New System.Drawing.Point(77, 32)
        Me.ComboBoxRutas.Name = "ComboBoxRutas"
        Me.ComboBoxRutas.Size = New System.Drawing.Size(439, 21)
        Me.ComboBoxRutas.TabIndex = 0
        '
        'GroupBoxPuntosRuta
        '
        Me.GroupBoxPuntosRuta.Controls.Add(Me.LabelDistancia)
        Me.GroupBoxPuntosRuta.Controls.Add(Me.txtDistanciaTotal)
        Me.GroupBoxPuntosRuta.Controls.Add(Me.txtIdPuntoRuta)
        Me.GroupBoxPuntosRuta.Controls.Add(Me.ButtonLimpiarCampos)
        Me.GroupBoxPuntosRuta.Controls.Add(Me.ButtonBorrarPunto)
        Me.GroupBoxPuntosRuta.Controls.Add(Me.ButtonModificarPunto)
        Me.GroupBoxPuntosRuta.Controls.Add(Me.ButtonAgregarPunto)
        Me.GroupBoxPuntosRuta.Controls.Add(Me.txtLongitudPuntoRuta)
        Me.GroupBoxPuntosRuta.Controls.Add(Me.LabelLongitud)
        Me.GroupBoxPuntosRuta.Controls.Add(Me.txtLatitudPuntoRuta)
        Me.GroupBoxPuntosRuta.Controls.Add(Me.LabelLatitud)
        Me.GroupBoxPuntosRuta.Controls.Add(Me.txtNombrePuntoRuta)
        Me.GroupBoxPuntosRuta.Controls.Add(Me.LabelNombrePunto)
        Me.GroupBoxPuntosRuta.Location = New System.Drawing.Point(19, 23)
        Me.GroupBoxPuntosRuta.Name = "GroupBoxPuntosRuta"
        Me.GroupBoxPuntosRuta.Size = New System.Drawing.Size(481, 219)
        Me.GroupBoxPuntosRuta.TabIndex = 10
        Me.GroupBoxPuntosRuta.TabStop = false
        Me.GroupBoxPuntosRuta.Text = "Puntos de Ruta"
        '
        'LabelDistancia
        '
        Me.LabelDistancia.AutoSize = true
        Me.LabelDistancia.Location = New System.Drawing.Point(226, 42)
        Me.LabelDistancia.Name = "LabelDistancia"
        Me.LabelDistancia.Size = New System.Drawing.Size(78, 13)
        Me.LabelDistancia.TabIndex = 13
        Me.LabelDistancia.Text = "Distancia Total"
        '
        'txtDistanciaTotal
        '
        Me.txtDistanciaTotal.Location = New System.Drawing.Point(310, 39)
        Me.txtDistanciaTotal.Name = "txtDistanciaTotal"
        Me.txtDistanciaTotal.Size = New System.Drawing.Size(147, 20)
        Me.txtDistanciaTotal.TabIndex = 12
        '
        'txtIdPuntoRuta
        '
        Me.txtIdPuntoRuta.Location = New System.Drawing.Point(310, 109)
        Me.txtIdPuntoRuta.Name = "txtIdPuntoRuta"
        Me.txtIdPuntoRuta.Size = New System.Drawing.Size(147, 20)
        Me.txtIdPuntoRuta.TabIndex = 11
        Me.txtIdPuntoRuta.Visible = false
        '
        'ButtonLimpiarCampos
        '
        Me.ButtonLimpiarCampos.Location = New System.Drawing.Point(366, 158)
        Me.ButtonLimpiarCampos.Name = "ButtonLimpiarCampos"
        Me.ButtonLimpiarCampos.Size = New System.Drawing.Size(91, 36)
        Me.ButtonLimpiarCampos.TabIndex = 9
        Me.ButtonLimpiarCampos.Text = "Limpiar"
        Me.ButtonLimpiarCampos.UseVisualStyleBackColor = true
        '
        'ButtonBorrarPunto
        '
        Me.ButtonBorrarPunto.Location = New System.Drawing.Point(253, 158)
        Me.ButtonBorrarPunto.Name = "ButtonBorrarPunto"
        Me.ButtonBorrarPunto.Size = New System.Drawing.Size(91, 36)
        Me.ButtonBorrarPunto.TabIndex = 8
        Me.ButtonBorrarPunto.Text = "Borrar Punto"
        Me.ButtonBorrarPunto.UseVisualStyleBackColor = true
        '
        'ButtonModificarPunto
        '
        Me.ButtonModificarPunto.Location = New System.Drawing.Point(130, 158)
        Me.ButtonModificarPunto.Name = "ButtonModificarPunto"
        Me.ButtonModificarPunto.Size = New System.Drawing.Size(107, 36)
        Me.ButtonModificarPunto.TabIndex = 7
        Me.ButtonModificarPunto.Text = "Modificar Punto"
        Me.ButtonModificarPunto.UseVisualStyleBackColor = true
        '
        'ButtonAgregarPunto
        '
        Me.ButtonAgregarPunto.Location = New System.Drawing.Point(25, 158)
        Me.ButtonAgregarPunto.Name = "ButtonAgregarPunto"
        Me.ButtonAgregarPunto.Size = New System.Drawing.Size(87, 36)
        Me.ButtonAgregarPunto.TabIndex = 6
        Me.ButtonAgregarPunto.Text = "Agregar Punto"
        Me.ButtonAgregarPunto.UseVisualStyleBackColor = true
        '
        'txtLongitudPuntoRuta
        '
        Me.txtLongitudPuntoRuta.Location = New System.Drawing.Point(310, 81)
        Me.txtLongitudPuntoRuta.Name = "txtLongitudPuntoRuta"
        Me.txtLongitudPuntoRuta.Size = New System.Drawing.Size(147, 20)
        Me.txtLongitudPuntoRuta.TabIndex = 5
        '
        'LabelLongitud
        '
        Me.LabelLongitud.AutoSize = true
        Me.LabelLongitud.Location = New System.Drawing.Point(244, 84)
        Me.LabelLongitud.Name = "LabelLongitud"
        Me.LabelLongitud.Size = New System.Drawing.Size(48, 13)
        Me.LabelLongitud.TabIndex = 4
        Me.LabelLongitud.Text = "Longitud"
        '
        'txtLatitudPuntoRuta
        '
        Me.txtLatitudPuntoRuta.Location = New System.Drawing.Point(55, 81)
        Me.txtLatitudPuntoRuta.Name = "txtLatitudPuntoRuta"
        Me.txtLatitudPuntoRuta.Size = New System.Drawing.Size(150, 20)
        Me.txtLatitudPuntoRuta.TabIndex = 3
        '
        'LabelLatitud
        '
        Me.LabelLatitud.AutoSize = true
        Me.LabelLatitud.Location = New System.Drawing.Point(10, 88)
        Me.LabelLatitud.Name = "LabelLatitud"
        Me.LabelLatitud.Size = New System.Drawing.Size(39, 13)
        Me.LabelLatitud.TabIndex = 2
        Me.LabelLatitud.Text = "Latitud"
        '
        'txtNombrePuntoRuta
        '
        Me.txtNombrePuntoRuta.Location = New System.Drawing.Point(55, 39)
        Me.txtNombrePuntoRuta.Name = "txtNombrePuntoRuta"
        Me.txtNombrePuntoRuta.Size = New System.Drawing.Size(150, 20)
        Me.txtNombrePuntoRuta.TabIndex = 1
        '
        'LabelNombrePunto
        '
        Me.LabelNombrePunto.AutoSize = true
        Me.LabelNombrePunto.Location = New System.Drawing.Point(7, 39)
        Me.LabelNombrePunto.Name = "LabelNombrePunto"
        Me.LabelNombrePunto.Size = New System.Drawing.Size(44, 13)
        Me.LabelNombrePunto.TabIndex = 0
        Me.LabelNombrePunto.Text = "Nombre"
        '
        'cboCargarPermisos
        '
        Me.cboCargarPermisos.FormattingEnabled = true
        Me.cboCargarPermisos.Location = New System.Drawing.Point(-2, -4)
        Me.cboCargarPermisos.Name = "cboCargarPermisos"
        Me.cboCargarPermisos.Size = New System.Drawing.Size(23, 21)
        Me.cboCargarPermisos.TabIndex = 11
        Me.cboCargarPermisos.Visible = false
        '
        'frmRutas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6!, 13!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1329, 733)
        Me.Controls.Add(Me.cboCargarPermisos)
        Me.Controls.Add(Me.GroupBoxPuntosRuta)
        Me.Controls.Add(Me.GroupBoxRutasGuardadas)
        Me.Controls.Add(Me.GroupBoxDireccion)
        Me.Controls.Add(Me.viewPoints)
        Me.Controls.Add(Me.MapaContainer)
        Me.Name = "frmRutas"
        Me.Text = "Rutas"
        Me.MapaContainer.ResumeLayout(false)
        Me.viewPoints.ResumeLayout(false)
        CType(Me.DataGridViewPuntoRuta,System.ComponentModel.ISupportInitialize).EndInit
        Me.GroupBoxDireccion.ResumeLayout(false)
        Me.GroupBoxDireccion.PerformLayout
        Me.GroupBoxRutasGuardadas.ResumeLayout(false)
        Me.GroupBoxPuntosRuta.ResumeLayout(false)
        Me.GroupBoxPuntosRuta.PerformLayout
        Me.ResumeLayout(false)

End Sub

    Friend WithEvents mapaRutas As GMap.NET.WindowsForms.GMapControl
    Friend WithEvents txtDireccionRuta As TextBox
    Friend WithEvents LabelLugar As Label
    Friend WithEvents ButtonIrALugar As Button
    Friend WithEvents MapaContainer As GroupBox
    Friend WithEvents viewPoints As GroupBox
    Friend WithEvents DataGridViewPuntoRuta As DataGridView
    Friend WithEvents GroupBoxDireccion As GroupBox
    Friend WithEvents txtIdRuta As TextBox
    Friend WithEvents ButtonBorrarRuta As Button
    Friend WithEvents ButtonModificarRuta As Button
    Friend WithEvents txtNombreRuta As TextBox
    Friend WithEvents LabelNombreRuta As Label
    Friend WithEvents GroupBoxRutasGuardadas As GroupBox
    Friend WithEvents ComboBoxRutas As ComboBox
    Friend WithEvents GroupBoxPuntosRuta As GroupBox
    Friend WithEvents ButtonBorrarPunto As Button
    Friend WithEvents ButtonModificarPunto As Button
    Friend WithEvents ButtonAgregarPunto As Button
    Friend WithEvents txtLongitudPuntoRuta As TextBox
    Friend WithEvents LabelLongitud As Label
    Friend WithEvents txtLatitudPuntoRuta As TextBox
    Friend WithEvents LabelLatitud As Label
    Friend WithEvents txtNombrePuntoRuta As TextBox
    Friend WithEvents LabelNombrePunto As Label
    Friend WithEvents ButtonLimpiar As Button
    Friend WithEvents ButtonLimpiarCampos As Button
    Friend WithEvents txtIdPuntoRuta As TextBox
    Friend WithEvents colIdPuntoRuta As DataGridViewTextBoxColumn
    Friend WithEvents colNombrePunto As DataGridViewTextBoxColumn
    Friend WithEvents colLongitud As DataGridViewTextBoxColumn
    Friend WithEvents colLatitud As DataGridViewTextBoxColumn
    Friend WithEvents txtDistanciaTotal As TextBox
    Friend WithEvents LabelDistancia As Label
    Friend WithEvents ButtonGuardarDireccion As Button
    Friend WithEvents cboCargarPermisos As ComboBox
End Class
