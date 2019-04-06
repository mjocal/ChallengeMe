<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmEvento
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmEvento))
        Me.cboxCategoria = New System.Windows.Forms.ComboBox()
        Me.btnAgregarImagen = New System.Windows.Forms.Button()
        Me.LabelLogo = New System.Windows.Forms.Label()
        Me.txtDireccionEvento = New System.Windows.Forms.TextBox()
        Me.txtNombreEvento = New System.Windows.Forms.TextBox()
        Me.txtIdEvento = New System.Windows.Forms.TextBox()
        Me.LabelCorreoEntidad = New System.Windows.Forms.Label()
        Me.LabelTelefonoEntidad = New System.Windows.Forms.Label()
        Me.LabelDireccionEntidad = New System.Windows.Forms.Label()
        Me.LabelNombreComercialEntidad = New System.Windows.Forms.Label()
        Me.LabelTipoEntidad = New System.Windows.Forms.Label()
        Me.LabelNombreEntidad = New System.Windows.Forms.Label()
        Me.dgvEventos = New System.Windows.Forms.DataGridView()
        Me.IdEvento = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.LabelIdEntidad = New System.Windows.Forms.Label()
        Me.GroupBoxDireccionEntidad = New System.Windows.Forms.GroupBox()
        Me.lnkAgregarRutas = New System.Windows.Forms.LinkLabel()
        Me.lnkAgregarCategoria = New System.Windows.Forms.LinkLabel()
        Me.dateFinalInscripciones = New System.Windows.Forms.DateTimePicker()
        Me.dateFinalEvento = New System.Windows.Forms.DateTimePicker()
        Me.dateInicioInscripciones = New System.Windows.Forms.DateTimePicker()
        Me.dateInicioEvento = New System.Windows.Forms.DateTimePicker()
        Me.txtDescripcionEvento = New System.Windows.Forms.TextBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.lnkAgregarRuta = New System.Windows.Forms.LinkLabel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.picLogo = New System.Windows.Forms.PictureBox()
        Me.txtCupoMaximo = New System.Windows.Forms.TextBox()
        Me.txtCostoInscripcion = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtIdEntidad = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.PrintPreviewDialog1 = New System.Windows.Forms.PrintPreviewDialog()
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.ToolStripBtnNuevo = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripBtnGuardar = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripBtnBuscar = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripBtnActualizar = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripBtnEliminar = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripBtnSalir = New System.Windows.Forms.ToolStripButton()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.dgvActividades = New System.Windows.Forms.DataGridView()
        Me.IdActividad = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Nombre = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.lnkAgregarPatrocinador = New System.Windows.Forms.LinkLabel()
        Me.lnkAgregarActividad = New System.Windows.Forms.LinkLabel()
        Me.cboCargarPermisos = New System.Windows.Forms.ComboBox()
        Me.dgvPremios = New System.Windows.Forms.DataGridView()
        Me.IdPremio = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn16 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.lnkAgregarPremio = New System.Windows.Forms.LinkLabel()
        Me.dgvProductoEnEvento = New System.Windows.Forms.DataGridView()
        Me.IdProducto = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Producto = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.IdPatrocinador = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Patrocinador = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Monto = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.txtIdEventoDos = New System.Windows.Forms.TextBox()
        Me.txtIdActividad = New System.Windows.Forms.TextBox()
        Me.txtIdProducto = New System.Windows.Forms.TextBox()
        Me.lnkQuitarProductoEvento = New System.Windows.Forms.LinkLabel()
        Me.lnkQuitarActividadEvento = New System.Windows.Forms.LinkLabel()
        Me.txtIdPremio = New System.Windows.Forms.TextBox()
        Me.lnkQuitarPremioEvento = New System.Windows.Forms.LinkLabel()
        Me.txtIdRuta = New System.Windows.Forms.TextBox()
        Me.cboNombreActividad = New System.Windows.Forms.ComboBox()
        Me.cboIdProducto = New System.Windows.Forms.ComboBox()
        Me.cboIdPatrocinador = New System.Windows.Forms.ComboBox()
        Me.cboPremio = New System.Windows.Forms.ComboBox()
        Me.DataGridViewRutasDelEvento = New System.Windows.Forms.DataGridView()
        Me.colIdRutaEvento = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.LabelRutasDeEvento = New System.Windows.Forms.Label()
        CType(Me.dgvEventos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBoxDireccionEntidad.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picLogo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ToolStrip1.SuspendLayout()
        CType(Me.dgvActividades, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvPremios, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvProductoEnEvento, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridViewRutasDelEvento, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'cboxCategoria
        '
        Me.cboxCategoria.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboxCategoria.FormattingEnabled = True
        Me.cboxCategoria.Location = New System.Drawing.Point(150, 116)
        Me.cboxCategoria.Name = "cboxCategoria"
        Me.cboxCategoria.Size = New System.Drawing.Size(172, 23)
        Me.cboxCategoria.TabIndex = 18
        '
        'btnAgregarImagen
        '
        Me.btnAgregarImagen.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAgregarImagen.Location = New System.Drawing.Point(765, 133)
        Me.btnAgregarImagen.Name = "btnAgregarImagen"
        Me.btnAgregarImagen.Size = New System.Drawing.Size(128, 33)
        Me.btnAgregarImagen.TabIndex = 16
        Me.btnAgregarImagen.Text = "Agregar Logo"
        Me.btnAgregarImagen.UseVisualStyleBackColor = True
        '
        'LabelLogo
        '
        Me.LabelLogo.AutoSize = True
        Me.LabelLogo.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelLogo.Location = New System.Drawing.Point(799, 13)
        Me.LabelLogo.Name = "LabelLogo"
        Me.LabelLogo.Size = New System.Drawing.Size(35, 15)
        Me.LabelLogo.TabIndex = 15
        Me.LabelLogo.Text = "Logo"
        '
        'txtDireccionEvento
        '
        Me.txtDireccionEvento.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDireccionEvento.Location = New System.Drawing.Point(149, 203)
        Me.txtDireccionEvento.Name = "txtDireccionEvento"
        Me.txtDireccionEvento.Size = New System.Drawing.Size(599, 21)
        Me.txtDireccionEvento.TabIndex = 11
        '
        'txtNombreEvento
        '
        Me.txtNombreEvento.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNombreEvento.Location = New System.Drawing.Point(150, 88)
        Me.txtNombreEvento.Name = "txtNombreEvento"
        Me.txtNombreEvento.Size = New System.Drawing.Size(171, 21)
        Me.txtNombreEvento.TabIndex = 8
        '
        'txtIdEvento
        '
        Me.txtIdEvento.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtIdEvento.Location = New System.Drawing.Point(150, 61)
        Me.txtIdEvento.Name = "txtIdEvento"
        Me.txtIdEvento.Size = New System.Drawing.Size(172, 21)
        Me.txtIdEvento.TabIndex = 7
        '
        'LabelCorreoEntidad
        '
        Me.LabelCorreoEntidad.AutoSize = True
        Me.LabelCorreoEntidad.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelCorreoEntidad.Location = New System.Drawing.Point(383, 34)
        Me.LabelCorreoEntidad.Name = "LabelCorreoEntidad"
        Me.LabelCorreoEntidad.Size = New System.Drawing.Size(115, 13)
        Me.LabelCorreoEntidad.TabIndex = 6
        Me.LabelCorreoEntidad.Text = "Finalización del evento"
        '
        'LabelTelefonoEntidad
        '
        Me.LabelTelefonoEntidad.AutoSize = True
        Me.LabelTelefonoEntidad.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelTelefonoEntidad.Location = New System.Drawing.Point(46, 148)
        Me.LabelTelefonoEntidad.Name = "LabelTelefonoEntidad"
        Me.LabelTelefonoEntidad.Size = New System.Drawing.Size(86, 13)
        Me.LabelTelefonoEntidad.TabIndex = 5
        Me.LabelTelefonoEntidad.Text = "Inicio del Evento"
        '
        'LabelDireccionEntidad
        '
        Me.LabelDireccionEntidad.AutoSize = True
        Me.LabelDireccionEntidad.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelDireccionEntidad.Location = New System.Drawing.Point(81, 206)
        Me.LabelDireccionEntidad.Name = "LabelDireccionEntidad"
        Me.LabelDireccionEntidad.Size = New System.Drawing.Size(52, 13)
        Me.LabelDireccionEntidad.TabIndex = 4
        Me.LabelDireccionEntidad.Text = "Dirección"
        '
        'LabelNombreComercialEntidad
        '
        Me.LabelNombreComercialEntidad.AutoSize = True
        Me.LabelNombreComercialEntidad.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelNombreComercialEntidad.Location = New System.Drawing.Point(71, 179)
        Me.LabelNombreComercialEntidad.Name = "LabelNombreComercialEntidad"
        Me.LabelNombreComercialEntidad.Size = New System.Drawing.Size(63, 13)
        Me.LabelNombreComercialEntidad.TabIndex = 3
        Me.LabelNombreComercialEntidad.Text = "Descripción"
        '
        'LabelTipoEntidad
        '
        Me.LabelTipoEntidad.AutoSize = True
        Me.LabelTipoEntidad.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelTipoEntidad.Location = New System.Drawing.Point(85, 120)
        Me.LabelTipoEntidad.Name = "LabelTipoEntidad"
        Me.LabelTipoEntidad.Size = New System.Drawing.Size(54, 13)
        Me.LabelTipoEntidad.TabIndex = 2
        Me.LabelTipoEntidad.Text = "Categoría"
        '
        'LabelNombreEntidad
        '
        Me.LabelNombreEntidad.AutoSize = True
        Me.LabelNombreEntidad.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelNombreEntidad.Location = New System.Drawing.Point(92, 93)
        Me.LabelNombreEntidad.Name = "LabelNombreEntidad"
        Me.LabelNombreEntidad.Size = New System.Drawing.Size(44, 13)
        Me.LabelNombreEntidad.TabIndex = 1
        Me.LabelNombreEntidad.Text = "Nombre"
        '
        'dgvEventos
        '
        Me.dgvEventos.AllowUserToAddRows = False
        Me.dgvEventos.AllowUserToDeleteRows = False
        Me.dgvEventos.BackgroundColor = System.Drawing.Color.White
        Me.dgvEventos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvEventos.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IdEvento, Me.Column1, Me.Column2, Me.Column3, Me.Column4})
        Me.dgvEventos.Location = New System.Drawing.Point(35, 376)
        Me.dgvEventos.Name = "dgvEventos"
        Me.dgvEventos.ReadOnly = True
        Me.dgvEventos.Size = New System.Drawing.Size(498, 146)
        Me.dgvEventos.TabIndex = 4
        '
        'IdEvento
        '
        Me.IdEvento.HeaderText = "IdEvento"
        Me.IdEvento.Name = "IdEvento"
        Me.IdEvento.ReadOnly = True
        Me.IdEvento.Visible = False
        '
        'Column1
        '
        Me.Column1.HeaderText = "Nombre"
        Me.Column1.Name = "Column1"
        Me.Column1.ReadOnly = True
        Me.Column1.Width = 300
        '
        'Column2
        '
        Me.Column2.HeaderText = "Categoria"
        Me.Column2.Name = "Column2"
        Me.Column2.ReadOnly = True
        Me.Column2.Width = 200
        '
        'Column3
        '
        Me.Column3.HeaderText = "Fecha Inicio"
        Me.Column3.Name = "Column3"
        Me.Column3.ReadOnly = True
        '
        'Column4
        '
        Me.Column4.HeaderText = "Dirección"
        Me.Column4.Name = "Column4"
        Me.Column4.ReadOnly = True
        Me.Column4.Width = 370
        '
        'LabelIdEntidad
        '
        Me.LabelIdEntidad.AutoSize = True
        Me.LabelIdEntidad.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelIdEntidad.Location = New System.Drawing.Point(79, 65)
        Me.LabelIdEntidad.Name = "LabelIdEntidad"
        Me.LabelIdEntidad.Size = New System.Drawing.Size(58, 13)
        Me.LabelIdEntidad.TabIndex = 0
        Me.LabelIdEntidad.Text = "ID. Evento"
        '
        'GroupBoxDireccionEntidad
        '
        Me.GroupBoxDireccionEntidad.Controls.Add(Me.lnkAgregarRutas)
        Me.GroupBoxDireccionEntidad.Controls.Add(Me.lnkAgregarCategoria)
        Me.GroupBoxDireccionEntidad.Controls.Add(Me.dateFinalInscripciones)
        Me.GroupBoxDireccionEntidad.Controls.Add(Me.dateFinalEvento)
        Me.GroupBoxDireccionEntidad.Controls.Add(Me.dateInicioInscripciones)
        Me.GroupBoxDireccionEntidad.Controls.Add(Me.dateInicioEvento)
        Me.GroupBoxDireccionEntidad.Controls.Add(Me.txtDescripcionEvento)
        Me.GroupBoxDireccionEntidad.Controls.Add(Me.PictureBox1)
        Me.GroupBoxDireccionEntidad.Controls.Add(Me.lnkAgregarRuta)
        Me.GroupBoxDireccionEntidad.Controls.Add(Me.Label1)
        Me.GroupBoxDireccionEntidad.Controls.Add(Me.picLogo)
        Me.GroupBoxDireccionEntidad.Controls.Add(Me.cboxCategoria)
        Me.GroupBoxDireccionEntidad.Controls.Add(Me.btnAgregarImagen)
        Me.GroupBoxDireccionEntidad.Controls.Add(Me.LabelLogo)
        Me.GroupBoxDireccionEntidad.Controls.Add(Me.txtCupoMaximo)
        Me.GroupBoxDireccionEntidad.Controls.Add(Me.txtCostoInscripcion)
        Me.GroupBoxDireccionEntidad.Controls.Add(Me.txtDireccionEvento)
        Me.GroupBoxDireccionEntidad.Controls.Add(Me.Label7)
        Me.GroupBoxDireccionEntidad.Controls.Add(Me.txtNombreEvento)
        Me.GroupBoxDireccionEntidad.Controls.Add(Me.Label6)
        Me.GroupBoxDireccionEntidad.Controls.Add(Me.txtIdEntidad)
        Me.GroupBoxDireccionEntidad.Controls.Add(Me.txtIdEvento)
        Me.GroupBoxDireccionEntidad.Controls.Add(Me.Label9)
        Me.GroupBoxDireccionEntidad.Controls.Add(Me.Label8)
        Me.GroupBoxDireccionEntidad.Controls.Add(Me.LabelCorreoEntidad)
        Me.GroupBoxDireccionEntidad.Controls.Add(Me.LabelTelefonoEntidad)
        Me.GroupBoxDireccionEntidad.Controls.Add(Me.LabelDireccionEntidad)
        Me.GroupBoxDireccionEntidad.Controls.Add(Me.LabelNombreComercialEntidad)
        Me.GroupBoxDireccionEntidad.Controls.Add(Me.LabelTipoEntidad)
        Me.GroupBoxDireccionEntidad.Controls.Add(Me.Label11)
        Me.GroupBoxDireccionEntidad.Controls.Add(Me.LabelNombreEntidad)
        Me.GroupBoxDireccionEntidad.Controls.Add(Me.LabelIdEntidad)
        Me.GroupBoxDireccionEntidad.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBoxDireccionEntidad.Location = New System.Drawing.Point(38, 90)
        Me.GroupBoxDireccionEntidad.Name = "GroupBoxDireccionEntidad"
        Me.GroupBoxDireccionEntidad.Size = New System.Drawing.Size(1045, 243)
        Me.GroupBoxDireccionEntidad.TabIndex = 3
        Me.GroupBoxDireccionEntidad.TabStop = False
        '
        'lnkAgregarRutas
        '
        Me.lnkAgregarRutas.AutoSize = True
        Me.lnkAgregarRutas.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lnkAgregarRutas.Location = New System.Drawing.Point(938, 144)
        Me.lnkAgregarRutas.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lnkAgregarRutas.Name = "lnkAgregarRutas"
        Me.lnkAgregarRutas.Size = New System.Drawing.Size(70, 13)
        Me.lnkAgregarRutas.TabIndex = 62
        Me.lnkAgregarRutas.TabStop = True
        Me.lnkAgregarRutas.Text = "Administrar ..."
        '
        'lnkAgregarCategoria
        '
        Me.lnkAgregarCategoria.AutoSize = True
        Me.lnkAgregarCategoria.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lnkAgregarCategoria.Location = New System.Drawing.Point(327, 121)
        Me.lnkAgregarCategoria.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lnkAgregarCategoria.Name = "lnkAgregarCategoria"
        Me.lnkAgregarCategoria.Size = New System.Drawing.Size(56, 13)
        Me.lnkAgregarCategoria.TabIndex = 61
        Me.lnkAgregarCategoria.TabStop = True
        Me.lnkAgregarCategoria.Text = "Agregar ..."
        '
        'dateFinalInscripciones
        '
        Me.dateFinalInscripciones.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dateFinalInscripciones.Location = New System.Drawing.Point(514, 79)
        Me.dateFinalInscripciones.Margin = New System.Windows.Forms.Padding(2)
        Me.dateFinalInscripciones.Name = "dateFinalInscripciones"
        Me.dateFinalInscripciones.Size = New System.Drawing.Size(234, 21)
        Me.dateFinalInscripciones.TabIndex = 60
        '
        'dateFinalEvento
        '
        Me.dateFinalEvento.CalendarFont = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.dateFinalEvento.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dateFinalEvento.Location = New System.Drawing.Point(512, 27)
        Me.dateFinalEvento.Margin = New System.Windows.Forms.Padding(2)
        Me.dateFinalEvento.Name = "dateFinalEvento"
        Me.dateFinalEvento.Size = New System.Drawing.Size(236, 21)
        Me.dateFinalEvento.TabIndex = 60
        '
        'dateInicioInscripciones
        '
        Me.dateInicioInscripciones.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dateInicioInscripciones.Location = New System.Drawing.Point(513, 53)
        Me.dateInicioInscripciones.Margin = New System.Windows.Forms.Padding(2)
        Me.dateInicioInscripciones.Name = "dateInicioInscripciones"
        Me.dateInicioInscripciones.Size = New System.Drawing.Size(235, 21)
        Me.dateInicioInscripciones.TabIndex = 60
        '
        'dateInicioEvento
        '
        Me.dateInicioEvento.CalendarFont = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.dateInicioEvento.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dateInicioEvento.Location = New System.Drawing.Point(150, 146)
        Me.dateInicioEvento.Margin = New System.Windows.Forms.Padding(2)
        Me.dateInicioEvento.Name = "dateInicioEvento"
        Me.dateInicioEvento.Size = New System.Drawing.Size(241, 21)
        Me.dateInicioEvento.TabIndex = 60
        '
        'txtDescripcionEvento
        '
        Me.txtDescripcionEvento.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDescripcionEvento.Location = New System.Drawing.Point(149, 174)
        Me.txtDescripcionEvento.Margin = New System.Windows.Forms.Padding(2)
        Me.txtDescripcionEvento.Multiline = True
        Me.txtDescripcionEvento.Name = "txtDescripcionEvento"
        Me.txtDescripcionEvento.Size = New System.Drawing.Size(599, 21)
        Me.txtDescripcionEvento.TabIndex = 22
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(899, 34)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(128, 98)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 21
        Me.PictureBox1.TabStop = False
        '
        'lnkAgregarRuta
        '
        Me.lnkAgregarRuta.AutoSize = True
        Me.lnkAgregarRuta.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lnkAgregarRuta.Location = New System.Drawing.Point(799, 296)
        Me.lnkAgregarRuta.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lnkAgregarRuta.Name = "lnkAgregarRuta"
        Me.lnkAgregarRuta.Size = New System.Drawing.Size(56, 13)
        Me.lnkAgregarRuta.TabIndex = 59
        Me.lnkAgregarRuta.TabStop = True
        Me.lnkAgregarRuta.Text = "Agregar ..."
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(938, 13)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(33, 15)
        Me.Label1.TabIndex = 20
        Me.Label1.Text = "Ruta"
        '
        'picLogo
        '
        Me.picLogo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.picLogo.Location = New System.Drawing.Point(765, 33)
        Me.picLogo.Name = "picLogo"
        Me.picLogo.Size = New System.Drawing.Size(128, 98)
        Me.picLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picLogo.TabIndex = 19
        Me.picLogo.TabStop = False
        '
        'txtCupoMaximo
        '
        Me.txtCupoMaximo.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCupoMaximo.Location = New System.Drawing.Point(514, 105)
        Me.txtCupoMaximo.Name = "txtCupoMaximo"
        Me.txtCupoMaximo.Size = New System.Drawing.Size(234, 21)
        Me.txtCupoMaximo.TabIndex = 13
        '
        'txtCostoInscripcion
        '
        Me.txtCostoInscripcion.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCostoInscripcion.Location = New System.Drawing.Point(513, 132)
        Me.txtCostoInscripcion.Name = "txtCostoInscripcion"
        Me.txtCostoInscripcion.Size = New System.Drawing.Size(235, 21)
        Me.txtCostoInscripcion.TabIndex = 13
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(431, 109)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(70, 13)
        Me.Label7.TabIndex = 6
        Me.Label7.Text = "Cupo máximo"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(473, 136)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(34, 13)
        Me.Label6.TabIndex = 6
        Me.Label6.Text = "Costo"
        '
        'txtIdEntidad
        '
        Me.txtIdEntidad.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtIdEntidad.Location = New System.Drawing.Point(149, 34)
        Me.txtIdEntidad.Name = "txtIdEntidad"
        Me.txtIdEntidad.Size = New System.Drawing.Size(172, 21)
        Me.txtIdEntidad.TabIndex = 7
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(373, 85)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(126, 13)
        Me.Label9.TabIndex = 6
        Me.Label9.Text = "Finalización inscripciones"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(405, 59)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(96, 13)
        Me.Label8.TabIndex = 5
        Me.Label8.Text = "Inicio inscripciones"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(51, 37)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(86, 13)
        Me.Label11.TabIndex = 0
        Me.Label11.Text = "ID. Organización"
        '
        'PrintPreviewDialog1
        '
        Me.PrintPreviewDialog1.AutoScrollMargin = New System.Drawing.Size(0, 0)
        Me.PrintPreviewDialog1.AutoScrollMinSize = New System.Drawing.Size(0, 0)
        Me.PrintPreviewDialog1.ClientSize = New System.Drawing.Size(400, 300)
        Me.PrintPreviewDialog1.Enabled = True
        Me.PrintPreviewDialog1.Icon = CType(resources.GetObject("PrintPreviewDialog1.Icon"), System.Drawing.Icon)
        Me.PrintPreviewDialog1.Name = "PrintPreviewDialog1"
        Me.PrintPreviewDialog1.Visible = False
        '
        'ToolStrip1
        '
        Me.ToolStrip1.BackColor = System.Drawing.Color.White
        Me.ToolStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
        Me.ToolStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripBtnNuevo, Me.ToolStripBtnGuardar, Me.ToolStripBtnBuscar, Me.ToolStripBtnActualizar, Me.ToolStripBtnEliminar, Me.ToolStripBtnSalir})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.System
        Me.ToolStrip1.Size = New System.Drawing.Size(1167, 71)
        Me.ToolStrip1.TabIndex = 52
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'ToolStripBtnNuevo
        '
        Me.ToolStripBtnNuevo.Enabled = False
        Me.ToolStripBtnNuevo.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!)
        Me.ToolStripBtnNuevo.Image = CType(resources.GetObject("ToolStripBtnNuevo.Image"), System.Drawing.Image)
        Me.ToolStripBtnNuevo.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.ToolStripBtnNuevo.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripBtnNuevo.Name = "ToolStripBtnNuevo"
        Me.ToolStripBtnNuevo.Size = New System.Drawing.Size(110, 68)
        Me.ToolStripBtnNuevo.Text = "Nuevo"
        '
        'ToolStripBtnGuardar
        '
        Me.ToolStripBtnGuardar.Enabled = False
        Me.ToolStripBtnGuardar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!)
        Me.ToolStripBtnGuardar.Image = CType(resources.GetObject("ToolStripBtnGuardar.Image"), System.Drawing.Image)
        Me.ToolStripBtnGuardar.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.ToolStripBtnGuardar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripBtnGuardar.Name = "ToolStripBtnGuardar"
        Me.ToolStripBtnGuardar.Size = New System.Drawing.Size(120, 68)
        Me.ToolStripBtnGuardar.Text = "Guardar"
        '
        'ToolStripBtnBuscar
        '
        Me.ToolStripBtnBuscar.Enabled = False
        Me.ToolStripBtnBuscar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!)
        Me.ToolStripBtnBuscar.Image = CType(resources.GetObject("ToolStripBtnBuscar.Image"), System.Drawing.Image)
        Me.ToolStripBtnBuscar.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.ToolStripBtnBuscar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripBtnBuscar.Name = "ToolStripBtnBuscar"
        Me.ToolStripBtnBuscar.Size = New System.Drawing.Size(113, 68)
        Me.ToolStripBtnBuscar.Text = "Buscar"
        '
        'ToolStripBtnActualizar
        '
        Me.ToolStripBtnActualizar.Enabled = False
        Me.ToolStripBtnActualizar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!)
        Me.ToolStripBtnActualizar.Image = CType(resources.GetObject("ToolStripBtnActualizar.Image"), System.Drawing.Image)
        Me.ToolStripBtnActualizar.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.ToolStripBtnActualizar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripBtnActualizar.Name = "ToolStripBtnActualizar"
        Me.ToolStripBtnActualizar.Size = New System.Drawing.Size(128, 68)
        Me.ToolStripBtnActualizar.Text = "Actualizar"
        '
        'ToolStripBtnEliminar
        '
        Me.ToolStripBtnEliminar.Enabled = False
        Me.ToolStripBtnEliminar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!)
        Me.ToolStripBtnEliminar.Image = CType(resources.GetObject("ToolStripBtnEliminar.Image"), System.Drawing.Image)
        Me.ToolStripBtnEliminar.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.ToolStripBtnEliminar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripBtnEliminar.Name = "ToolStripBtnEliminar"
        Me.ToolStripBtnEliminar.Size = New System.Drawing.Size(121, 68)
        Me.ToolStripBtnEliminar.Text = "Eliminar"
        '
        'ToolStripBtnSalir
        '
        Me.ToolStripBtnSalir.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!)
        Me.ToolStripBtnSalir.Image = CType(resources.GetObject("ToolStripBtnSalir.Image"), System.Drawing.Image)
        Me.ToolStripBtnSalir.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.ToolStripBtnSalir.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripBtnSalir.Name = "ToolStripBtnSalir"
        Me.ToolStripBtnSalir.Size = New System.Drawing.Size(100, 68)
        Me.ToolStripBtnSalir.Text = "Salir"
        Me.ToolStripBtnSalir.Visible = False
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.SystemColors.ButtonShadow
        Me.Label10.Location = New System.Drawing.Point(37, 74)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(232, 24)
        Me.Label10.TabIndex = 53
        Me.Label10.Text = "Mantenimiento de eventos"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.SystemColors.ButtonShadow
        Me.Label2.Location = New System.Drawing.Point(37, 349)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(110, 24)
        Me.Label2.TabIndex = 54
        Me.Label2.Text = "Mis eventos"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.SystemColors.ButtonShadow
        Me.Label3.Location = New System.Drawing.Point(38, 525)
        Me.Label3.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(106, 24)
        Me.Label3.TabIndex = 56
        Me.Label3.Text = "Actividades"
        '
        'dgvActividades
        '
        Me.dgvActividades.AllowUserToAddRows = False
        Me.dgvActividades.AllowUserToDeleteRows = False
        Me.dgvActividades.BackgroundColor = System.Drawing.Color.White
        Me.dgvActividades.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvActividades.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IdActividad, Me.Nombre})
        Me.dgvActividades.Location = New System.Drawing.Point(35, 550)
        Me.dgvActividades.Margin = New System.Windows.Forms.Padding(2)
        Me.dgvActividades.Name = "dgvActividades"
        Me.dgvActividades.ReadOnly = True
        Me.dgvActividades.Size = New System.Drawing.Size(243, 127)
        Me.dgvActividades.TabIndex = 55
        '
        'IdActividad
        '
        Me.IdActividad.HeaderText = "IdActividad"
        Me.IdActividad.Name = "IdActividad"
        Me.IdActividad.ReadOnly = True
        Me.IdActividad.Visible = False
        '
        'Nombre
        '
        Me.Nombre.HeaderText = "Nombre"
        Me.Nombre.Name = "Nombre"
        Me.Nombre.ReadOnly = True
        Me.Nombre.Width = 200
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.SystemColors.ButtonShadow
        Me.Label4.Location = New System.Drawing.Point(287, 525)
        Me.Label4.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(225, 24)
        Me.Label4.TabIndex = 58
        Me.Label4.Text = "Productos patrocinadores"
        '
        'lnkAgregarPatrocinador
        '
        Me.lnkAgregarPatrocinador.AutoSize = True
        Me.lnkAgregarPatrocinador.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lnkAgregarPatrocinador.Location = New System.Drawing.Point(284, 683)
        Me.lnkAgregarPatrocinador.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lnkAgregarPatrocinador.Name = "lnkAgregarPatrocinador"
        Me.lnkAgregarPatrocinador.Size = New System.Drawing.Size(56, 13)
        Me.lnkAgregarPatrocinador.TabIndex = 59
        Me.lnkAgregarPatrocinador.TabStop = True
        Me.lnkAgregarPatrocinador.Text = "Agregar ..."
        '
        'lnkAgregarActividad
        '
        Me.lnkAgregarActividad.AutoSize = True
        Me.lnkAgregarActividad.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lnkAgregarActividad.Location = New System.Drawing.Point(35, 683)
        Me.lnkAgregarActividad.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lnkAgregarActividad.Name = "lnkAgregarActividad"
        Me.lnkAgregarActividad.Size = New System.Drawing.Size(56, 13)
        Me.lnkAgregarActividad.TabIndex = 59
        Me.lnkAgregarActividad.TabStop = True
        Me.lnkAgregarActividad.Text = "Agregar ..."
        '
        'cboCargarPermisos
        '
        Me.cboCargarPermisos.FormattingEnabled = True
        Me.cboCargarPermisos.Location = New System.Drawing.Point(12, 3)
        Me.cboCargarPermisos.Margin = New System.Windows.Forms.Padding(2)
        Me.cboCargarPermisos.Name = "cboCargarPermisos"
        Me.cboCargarPermisos.Size = New System.Drawing.Size(27, 21)
        Me.cboCargarPermisos.TabIndex = 60
        Me.cboCargarPermisos.Visible = False
        '
        'dgvPremios
        '
        Me.dgvPremios.AllowUserToAddRows = False
        Me.dgvPremios.AllowUserToDeleteRows = False
        Me.dgvPremios.BackgroundColor = System.Drawing.Color.White
        Me.dgvPremios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvPremios.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IdPremio, Me.DataGridViewTextBoxColumn16, Me.Column7})
        Me.dgvPremios.Location = New System.Drawing.Point(739, 550)
        Me.dgvPremios.Margin = New System.Windows.Forms.Padding(2)
        Me.dgvPremios.Name = "dgvPremios"
        Me.dgvPremios.ReadOnly = True
        Me.dgvPremios.Size = New System.Drawing.Size(344, 127)
        Me.dgvPremios.TabIndex = 57
        '
        'IdPremio
        '
        Me.IdPremio.HeaderText = "IdPremio"
        Me.IdPremio.Name = "IdPremio"
        Me.IdPremio.ReadOnly = True
        Me.IdPremio.Visible = False
        '
        'DataGridViewTextBoxColumn16
        '
        Me.DataGridViewTextBoxColumn16.HeaderText = "Nombre"
        Me.DataGridViewTextBoxColumn16.Name = "DataGridViewTextBoxColumn16"
        Me.DataGridViewTextBoxColumn16.ReadOnly = True
        Me.DataGridViewTextBoxColumn16.Width = 150
        '
        'Column7
        '
        Me.Column7.HeaderText = "Descripción"
        Me.Column7.Name = "Column7"
        Me.Column7.ReadOnly = True
        Me.Column7.Width = 150
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.SystemColors.ButtonShadow
        Me.Label5.Location = New System.Drawing.Point(799, 523)
        Me.Label5.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(79, 24)
        Me.Label5.TabIndex = 58
        Me.Label5.Text = "Premios"
        '
        'lnkAgregarPremio
        '
        Me.lnkAgregarPremio.AutoSize = True
        Me.lnkAgregarPremio.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lnkAgregarPremio.Location = New System.Drawing.Point(740, 683)
        Me.lnkAgregarPremio.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lnkAgregarPremio.Name = "lnkAgregarPremio"
        Me.lnkAgregarPremio.Size = New System.Drawing.Size(56, 13)
        Me.lnkAgregarPremio.TabIndex = 59
        Me.lnkAgregarPremio.TabStop = True
        Me.lnkAgregarPremio.Text = "Agregar ..."
        '
        'dgvProductoEnEvento
        '
        Me.dgvProductoEnEvento.AllowUserToAddRows = False
        Me.dgvProductoEnEvento.AllowUserToDeleteRows = False
        Me.dgvProductoEnEvento.BackgroundColor = System.Drawing.Color.White
        Me.dgvProductoEnEvento.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvProductoEnEvento.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IdProducto, Me.Producto, Me.IdPatrocinador, Me.Patrocinador, Me.Monto})
        Me.dgvProductoEnEvento.Location = New System.Drawing.Point(282, 551)
        Me.dgvProductoEnEvento.Margin = New System.Windows.Forms.Padding(2)
        Me.dgvProductoEnEvento.Name = "dgvProductoEnEvento"
        Me.dgvProductoEnEvento.ReadOnly = True
        Me.dgvProductoEnEvento.Size = New System.Drawing.Size(453, 127)
        Me.dgvProductoEnEvento.TabIndex = 61
        '
        'IdProducto
        '
        Me.IdProducto.HeaderText = "IdProducto"
        Me.IdProducto.Name = "IdProducto"
        Me.IdProducto.ReadOnly = True
        Me.IdProducto.Visible = False
        '
        'Producto
        '
        Me.Producto.HeaderText = "Producto"
        Me.Producto.Name = "Producto"
        Me.Producto.ReadOnly = True
        Me.Producto.Width = 200
        '
        'IdPatrocinador
        '
        Me.IdPatrocinador.HeaderText = "IdPatrocinador"
        Me.IdPatrocinador.Name = "IdPatrocinador"
        Me.IdPatrocinador.ReadOnly = True
        Me.IdPatrocinador.Visible = False
        '
        'Patrocinador
        '
        Me.Patrocinador.HeaderText = "Patrocinador"
        Me.Patrocinador.Name = "Patrocinador"
        Me.Patrocinador.ReadOnly = True
        '
        'Monto
        '
        Me.Monto.HeaderText = "Monto patrocinio"
        Me.Monto.Name = "Monto"
        Me.Monto.ReadOnly = True
        '
        'txtIdEventoDos
        '
        Me.txtIdEventoDos.Location = New System.Drawing.Point(91, 754)
        Me.txtIdEventoDos.Margin = New System.Windows.Forms.Padding(2)
        Me.txtIdEventoDos.Name = "txtIdEventoDos"
        Me.txtIdEventoDos.Size = New System.Drawing.Size(22, 20)
        Me.txtIdEventoDos.TabIndex = 62
        Me.txtIdEventoDos.Visible = False
        '
        'txtIdActividad
        '
        Me.txtIdActividad.Location = New System.Drawing.Point(32, 754)
        Me.txtIdActividad.Margin = New System.Windows.Forms.Padding(2)
        Me.txtIdActividad.Name = "txtIdActividad"
        Me.txtIdActividad.Size = New System.Drawing.Size(19, 20)
        Me.txtIdActividad.TabIndex = 63
        Me.txtIdActividad.Visible = False
        '
        'txtIdProducto
        '
        Me.txtIdProducto.Location = New System.Drawing.Point(54, 754)
        Me.txtIdProducto.Margin = New System.Windows.Forms.Padding(2)
        Me.txtIdProducto.Name = "txtIdProducto"
        Me.txtIdProducto.Size = New System.Drawing.Size(16, 20)
        Me.txtIdProducto.TabIndex = 65
        Me.txtIdProducto.Visible = False
        '
        'lnkQuitarProductoEvento
        '
        Me.lnkQuitarProductoEvento.AutoSize = True
        Me.lnkQuitarProductoEvento.Location = New System.Drawing.Point(344, 683)
        Me.lnkQuitarProductoEvento.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lnkQuitarProductoEvento.Name = "lnkQuitarProductoEvento"
        Me.lnkQuitarProductoEvento.Size = New System.Drawing.Size(44, 13)
        Me.lnkQuitarProductoEvento.TabIndex = 66
        Me.lnkQuitarProductoEvento.TabStop = True
        Me.lnkQuitarProductoEvento.Text = "Quitar..."
        '
        'lnkQuitarActividadEvento
        '
        Me.lnkQuitarActividadEvento.AutoSize = True
        Me.lnkQuitarActividadEvento.Location = New System.Drawing.Point(95, 683)
        Me.lnkQuitarActividadEvento.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lnkQuitarActividadEvento.Name = "lnkQuitarActividadEvento"
        Me.lnkQuitarActividadEvento.Size = New System.Drawing.Size(44, 13)
        Me.lnkQuitarActividadEvento.TabIndex = 67
        Me.lnkQuitarActividadEvento.TabStop = True
        Me.lnkQuitarActividadEvento.Text = "Quitar..."
        '
        'txtIdPremio
        '
        Me.txtIdPremio.Location = New System.Drawing.Point(72, 754)
        Me.txtIdPremio.Margin = New System.Windows.Forms.Padding(2)
        Me.txtIdPremio.Name = "txtIdPremio"
        Me.txtIdPremio.Size = New System.Drawing.Size(18, 20)
        Me.txtIdPremio.TabIndex = 68
        Me.txtIdPremio.Visible = False
        '
        'lnkQuitarPremioEvento
        '
        Me.lnkQuitarPremioEvento.AutoSize = True
        Me.lnkQuitarPremioEvento.Location = New System.Drawing.Point(800, 683)
        Me.lnkQuitarPremioEvento.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lnkQuitarPremioEvento.Name = "lnkQuitarPremioEvento"
        Me.lnkQuitarPremioEvento.Size = New System.Drawing.Size(44, 13)
        Me.lnkQuitarPremioEvento.TabIndex = 69
        Me.lnkQuitarPremioEvento.TabStop = True
        Me.lnkQuitarPremioEvento.Text = "Quitar..."
        '
        'txtIdRuta
        '
        Me.txtIdRuta.Location = New System.Drawing.Point(12, 90)
        Me.txtIdRuta.Name = "txtIdRuta"
        Me.txtIdRuta.Size = New System.Drawing.Size(19, 20)
        Me.txtIdRuta.TabIndex = 70
        Me.txtIdRuta.Text = "1"
        '
        'cboNombreActividad
        '
        Me.cboNombreActividad.FormattingEnabled = True
        Me.cboNombreActividad.Location = New System.Drawing.Point(119, 753)
        Me.cboNombreActividad.Name = "cboNombreActividad"
        Me.cboNombreActividad.Size = New System.Drawing.Size(19, 21)
        Me.cboNombreActividad.TabIndex = 71
        Me.cboNombreActividad.Visible = False
        '
        'cboIdProducto
        '
        Me.cboIdProducto.FormattingEnabled = True
        Me.cboIdProducto.Location = New System.Drawing.Point(144, 753)
        Me.cboIdProducto.Name = "cboIdProducto"
        Me.cboIdProducto.Size = New System.Drawing.Size(26, 21)
        Me.cboIdProducto.TabIndex = 72
        Me.cboIdProducto.Visible = False
        '
        'cboIdPatrocinador
        '
        Me.cboIdPatrocinador.FormattingEnabled = True
        Me.cboIdPatrocinador.Location = New System.Drawing.Point(176, 753)
        Me.cboIdPatrocinador.Name = "cboIdPatrocinador"
        Me.cboIdPatrocinador.Size = New System.Drawing.Size(14, 21)
        Me.cboIdPatrocinador.TabIndex = 73
        Me.cboIdPatrocinador.Visible = False
        '
        'cboPremio
        '
        Me.cboPremio.FormattingEnabled = True
        Me.cboPremio.Location = New System.Drawing.Point(195, 753)
        Me.cboPremio.Name = "cboPremio"
        Me.cboPremio.Size = New System.Drawing.Size(25, 21)
        Me.cboPremio.TabIndex = 74
        Me.cboPremio.Visible = False
        '
        'DataGridViewRutasDelEvento
        '
        Me.DataGridViewRutasDelEvento.BackgroundColor = System.Drawing.SystemColors.ControlLightLight
        Me.DataGridViewRutasDelEvento.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridViewRutasDelEvento.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.colIdRutaEvento, Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2})
        Me.DataGridViewRutasDelEvento.Location = New System.Drawing.Point(542, 376)
        Me.DataGridViewRutasDelEvento.Name = "DataGridViewRutasDelEvento"
        Me.DataGridViewRutasDelEvento.Size = New System.Drawing.Size(541, 144)
        Me.DataGridViewRutasDelEvento.TabIndex = 75
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
        'LabelRutasDeEvento
        '
        Me.LabelRutasDeEvento.AutoSize = True
        Me.LabelRutasDeEvento.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelRutasDeEvento.ForeColor = System.Drawing.SystemColors.ButtonShadow
        Me.LabelRutasDeEvento.Location = New System.Drawing.Point(546, 349)
        Me.LabelRutasDeEvento.Name = "LabelRutasDeEvento"
        Me.LabelRutasDeEvento.Size = New System.Drawing.Size(233, 24)
        Me.LabelRutasDeEvento.TabIndex = 76
        Me.LabelRutasDeEvento.Text = "Rutas Asignadas al Evento"
        '
        'frmEvento
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1167, 772)
        Me.Controls.Add(Me.LabelRutasDeEvento)
        Me.Controls.Add(Me.DataGridViewRutasDelEvento)
        Me.Controls.Add(Me.cboPremio)
        Me.Controls.Add(Me.cboIdPatrocinador)
        Me.Controls.Add(Me.cboIdProducto)
        Me.Controls.Add(Me.cboNombreActividad)
        Me.Controls.Add(Me.txtIdRuta)
        Me.Controls.Add(Me.lnkQuitarPremioEvento)
        Me.Controls.Add(Me.txtIdPremio)
        Me.Controls.Add(Me.lnkQuitarActividadEvento)
        Me.Controls.Add(Me.lnkQuitarProductoEvento)
        Me.Controls.Add(Me.txtIdProducto)
        Me.Controls.Add(Me.txtIdActividad)
        Me.Controls.Add(Me.txtIdEventoDos)
        Me.Controls.Add(Me.dgvProductoEnEvento)
        Me.Controls.Add(Me.cboCargarPermisos)
        Me.Controls.Add(Me.lnkAgregarActividad)
        Me.Controls.Add(Me.lnkAgregarPremio)
        Me.Controls.Add(Me.lnkAgregarPatrocinador)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.dgvPremios)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.dgvActividades)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Controls.Add(Me.dgvEventos)
        Me.Controls.Add(Me.GroupBoxDireccionEntidad)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.Name = "frmEvento"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.dgvEventos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBoxDireccionEntidad.ResumeLayout(False)
        Me.GroupBoxDireccionEntidad.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picLogo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        CType(Me.dgvActividades, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvPremios, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvProductoEnEvento, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridViewRutasDelEvento, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout

End Sub
    Friend WithEvents picLogo As PictureBox
    Friend WithEvents cboxCategoria As ComboBox
    Friend WithEvents btnAgregarImagen As Button
    Friend WithEvents LabelLogo As Label
    Friend WithEvents txtDireccionEvento As TextBox
    Friend WithEvents txtIdEvento As TextBox
    Friend WithEvents LabelCorreoEntidad As Label
    Friend WithEvents LabelTelefonoEntidad As Label
    Friend WithEvents LabelDireccionEntidad As Label
    Friend WithEvents LabelNombreComercialEntidad As Label
    Friend WithEvents LabelTipoEntidad As Label
    Friend WithEvents LabelNombreEntidad As Label
    Friend WithEvents dgvEventos As DataGridView
    Friend WithEvents LabelIdEntidad As Label
    Friend WithEvents GroupBoxDireccionEntidad As GroupBox
    Friend WithEvents txtDescripcionEvento As TextBox
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label1 As Label
    Friend WithEvents PrintPreviewDialog1 As PrintPreviewDialog
    Friend WithEvents ToolStrip1 As ToolStrip
    Friend WithEvents ToolStripBtnNuevo As ToolStripButton
    Friend WithEvents ToolStripBtnGuardar As ToolStripButton
    Friend WithEvents ToolStripBtnBuscar As ToolStripButton
    Friend WithEvents ToolStripBtnActualizar As ToolStripButton
    Friend WithEvents ToolStripBtnEliminar As ToolStripButton
    Friend WithEvents ToolStripBtnSalir As ToolStripButton
    Friend WithEvents Label10 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents dgvActividades As DataGridView
    Friend WithEvents Label4 As Label
    Friend WithEvents lnkAgregarPatrocinador As LinkLabel
    Friend WithEvents lnkAgregarActividad As LinkLabel
    Friend WithEvents cboCargarPermisos As ComboBox
    Friend WithEvents lnkAgregarRuta As LinkLabel
    Friend WithEvents dgvPremios As DataGridView
    Friend WithEvents Label5 As Label
    Friend WithEvents lnkAgregarPremio As LinkLabel
    Friend WithEvents txtCupoMaximo As TextBox
    Friend WithEvents txtCostoInscripcion As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents dateFinalInscripciones As DateTimePicker
    Friend WithEvents dateFinalEvento As DateTimePicker
    Friend WithEvents dateInicioInscripciones As DateTimePicker
    Friend WithEvents dateInicioEvento As DateTimePicker
    Friend WithEvents txtIdEntidad As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents lnkAgregarCategoria As LinkLabel
    Friend WithEvents dgvProductoEnEvento As DataGridView
    Friend WithEvents txtIdEventoDos As TextBox
    Friend WithEvents IdEvento As DataGridViewTextBoxColumn
    Friend WithEvents Column1 As DataGridViewTextBoxColumn
    Friend WithEvents Column2 As DataGridViewTextBoxColumn
    Friend WithEvents Column3 As DataGridViewTextBoxColumn
    Friend WithEvents Column4 As DataGridViewTextBoxColumn
    Friend WithEvents IdProducto As DataGridViewTextBoxColumn
    Friend WithEvents Producto As DataGridViewTextBoxColumn
    Friend WithEvents IdPatrocinador As DataGridViewTextBoxColumn
    Friend WithEvents Patrocinador As DataGridViewTextBoxColumn
    Friend WithEvents Monto As DataGridViewTextBoxColumn
    Friend WithEvents IdPremio As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn16 As DataGridViewTextBoxColumn
    Friend WithEvents Column7 As DataGridViewTextBoxColumn
    Friend WithEvents txtIdActividad As TextBox
    Friend WithEvents txtIdProducto As TextBox
    Friend WithEvents lnkQuitarProductoEvento As LinkLabel
    Friend WithEvents lnkQuitarActividadEvento As LinkLabel
    Friend WithEvents txtIdPremio As TextBox
    Friend WithEvents lnkQuitarPremioEvento As LinkLabel
    Friend WithEvents txtIdRuta As TextBox
    Friend WithEvents IdActividad As DataGridViewTextBoxColumn
    Friend WithEvents Nombre As DataGridViewTextBoxColumn
    Friend WithEvents cboNombreActividad As ComboBox
    Friend WithEvents cboIdProducto As ComboBox
    Friend WithEvents cboIdPatrocinador As ComboBox
    Friend WithEvents cboPremio As ComboBox
    Friend WithEvents lnkAgregarRutas As LinkLabel
    Friend WithEvents txtNombreEvento As TextBox
    Friend WithEvents DataGridViewRutasDelEvento As DataGridView
    Friend WithEvents colIdRutaEvento As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
    Friend WithEvents LabelRutasDeEvento As Label
End Class
