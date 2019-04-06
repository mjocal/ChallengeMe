<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmFotografia
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmFotografia))
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.picImgUsr = New System.Windows.Forms.PictureBox()
        Me.cmsCambiarFotografia = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.SeleccionarFotoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SalirToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.btnCargarImagen = New System.Windows.Forms.Button()
        Me.lblFotografia = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.lblFotoDos = New System.Windows.Forms.Label()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.GroupBox1.SuspendLayout
        CType(Me.picImgUsr,System.ComponentModel.ISupportInitialize).BeginInit
        Me.cmsCambiarFotografia.SuspendLayout
        Me.Panel1.SuspendLayout
        Me.SuspendLayout
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.White
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.picImgUsr)
        Me.GroupBox1.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(188, 120)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(716, 246)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = false
        Me.GroupBox1.Text = "Vista previa de la imagen"
        '
        'Label1
        '
        Me.Label1.AutoSize = true
        Me.Label1.Font = New System.Drawing.Font("Open Sans", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.Label1.Location = New System.Drawing.Point(309, 221)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(186, 20)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Añadir o cambiar imagen:"
        '
        'picImgUsr
        '
        Me.picImgUsr.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.picImgUsr.ContextMenuStrip = Me.cmsCambiarFotografia
        Me.picImgUsr.Location = New System.Drawing.Point(223, 23)
        Me.picImgUsr.Name = "picImgUsr"
        Me.picImgUsr.Size = New System.Drawing.Size(348, 184)
        Me.picImgUsr.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.picImgUsr.TabIndex = 0
        Me.picImgUsr.TabStop = false
        Me.ToolTip1.SetToolTip(Me.picImgUsr, "Clic derecho para seleccionar imagen")
        '
        'cmsCambiarFotografia
        '
        Me.cmsCambiarFotografia.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.SeleccionarFotoToolStripMenuItem, Me.SalirToolStripMenuItem})
        Me.cmsCambiarFotografia.Name = "cmsCambiarFotografia"
        Me.cmsCambiarFotografia.Size = New System.Drawing.Size(162, 48)
        '
        'SeleccionarFotoToolStripMenuItem
        '
        Me.SeleccionarFotoToolStripMenuItem.Name = "SeleccionarFotoToolStripMenuItem"
        Me.SeleccionarFotoToolStripMenuItem.Size = New System.Drawing.Size(161, 22)
        Me.SeleccionarFotoToolStripMenuItem.Text = "Seleccionar Foto"
        '
        'SalirToolStripMenuItem
        '
        Me.SalirToolStripMenuItem.Name = "SalirToolStripMenuItem"
        Me.SalirToolStripMenuItem.Size = New System.Drawing.Size(161, 22)
        Me.SalirToolStripMenuItem.Text = "Salir"
        '
        'btnCargarImagen
        '
        Me.btnCargarImagen.BackColor = System.Drawing.Color.DodgerBlue
        Me.btnCargarImagen.FlatAppearance.MouseOverBackColor = System.Drawing.Color.MidnightBlue
        Me.btnCargarImagen.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCargarImagen.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.btnCargarImagen.ForeColor = System.Drawing.Color.White
        Me.btnCargarImagen.Location = New System.Drawing.Point(510, 390)
        Me.btnCargarImagen.Name = "btnCargarImagen"
        Me.btnCargarImagen.Size = New System.Drawing.Size(153, 40)
        Me.btnCargarImagen.TabIndex = 1
        Me.btnCargarImagen.Text = "Cargar imagen"
        Me.btnCargarImagen.UseVisualStyleBackColor = false
        '
        'lblFotografia
        '
        Me.lblFotografia.AutoSize = true
        Me.lblFotografia.Font = New System.Drawing.Font("Microsoft Sans Serif", 18!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.lblFotografia.Location = New System.Drawing.Point(504, 8)
        Me.lblFotografia.Name = "lblFotografia"
        Me.lblFotografia.Size = New System.Drawing.Size(122, 29)
        Me.lblFotografia.TabIndex = 3
        Me.lblFotografia.Text = "Fotografía"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.White
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.lblFotoDos)
        Me.Panel1.Controls.Add(Me.lblFotografia)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1069, 74)
        Me.Panel1.TabIndex = 3
        '
        'lblFotoDos
        '
        Me.lblFotoDos.AutoSize = true
        Me.lblFotoDos.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.lblFotoDos.ForeColor = System.Drawing.SystemColors.ButtonShadow
        Me.lblFotoDos.Location = New System.Drawing.Point(453, 39)
        Me.lblFotoDos.Name = "lblFotoDos"
        Me.lblFotoDos.Size = New System.Drawing.Size(241, 24)
        Me.lblFotoDos.TabIndex = 4
        Me.lblFotoDos.Text = "Añade una foto tuya al perfil"
        '
        'ToolTip1
        '
        Me.ToolTip1.AutoPopDelay = 5000
        Me.ToolTip1.InitialDelay = 100
        Me.ToolTip1.IsBalloon = true
        Me.ToolTip1.ReshowDelay = 100
        Me.ToolTip1.Tag = ""
        Me.ToolTip1.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info
        Me.ToolTip1.ToolTipTitle = "Atención"
        '
        'frmFotografia
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6!, 13!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1069, 454)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.btnCargarImagen)
        Me.Controls.Add(Me.GroupBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"),System.Drawing.Icon)
        Me.Name = "frmFotografia"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.GroupBox1.ResumeLayout(false)
        Me.GroupBox1.PerformLayout
        CType(Me.picImgUsr,System.ComponentModel.ISupportInitialize).EndInit
        Me.cmsCambiarFotografia.ResumeLayout(false)
        Me.Panel1.ResumeLayout(false)
        Me.Panel1.PerformLayout
        Me.ResumeLayout(false)

End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents picImgUsr As PictureBox
    Friend WithEvents btnCargarImagen As Button
    Friend WithEvents cmsCambiarFotografia As ContextMenuStrip
    Friend WithEvents SeleccionarFotoToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SalirToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents Label1 As Label
    Friend WithEvents lblFotografia As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents lblFotoDos As Label
    Friend WithEvents ToolTip1 As ToolTip
End Class
