<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmPerfil
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmPerfil))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.txtFechaNacimiento = New System.Windows.Forms.MaskedTextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtEmail = New System.Windows.Forms.TextBox()
        Me.txtDistrito = New System.Windows.Forms.TextBox()
        Me.txtCanton = New System.Windows.Forms.TextBox()
        Me.txtProvincia = New System.Windows.Forms.TextBox()
        Me.txtDireccion = New System.Windows.Forms.TextBox()
        Me.txtNombre = New System.Windows.Forms.TextBox()
        Me.btnGuardar = New System.Windows.Forms.Button()
        Me.erProveedorError = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.Panel1.SuspendLayout
        Me.GroupBox1.SuspendLayout
        CType(Me.erProveedorError,System.ComponentModel.ISupportInitialize).BeginInit
        Me.SuspendLayout
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.White
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(919, 93)
        Me.Panel1.TabIndex = 0
        '
        'Label2
        '
        Me.Label2.AutoSize = true
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.Label2.ForeColor = System.Drawing.SystemColors.AppWorkspace
        Me.Label2.Location = New System.Drawing.Point(415, 56)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(273, 24)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Verifica tu información personal"
        '
        'Label1
        '
        Me.Label1.AutoSize = true
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 18!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.Label1.Location = New System.Drawing.Point(496, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(108, 29)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Mi perfil"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.txtFechaNacimiento)
        Me.GroupBox1.Controls.Add(Me.Label9)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.txtEmail)
        Me.GroupBox1.Controls.Add(Me.txtDistrito)
        Me.GroupBox1.Controls.Add(Me.txtCanton)
        Me.GroupBox1.Controls.Add(Me.txtProvincia)
        Me.GroupBox1.Controls.Add(Me.txtDireccion)
        Me.GroupBox1.Controls.Add(Me.txtNombre)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(266, 115)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(667, 449)
        Me.GroupBox1.TabIndex = 1
        Me.GroupBox1.TabStop = false
        Me.GroupBox1.Text = "Información básica*"
        '
        'txtFechaNacimiento
        '
        Me.txtFechaNacimiento.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtFechaNacimiento.Location = New System.Drawing.Point(127, 403)
        Me.txtFechaNacimiento.Mask = "00/00/0000"
        Me.txtFechaNacimiento.Name = "txtFechaNacimiento"
        Me.txtFechaNacimiento.Size = New System.Drawing.Size(146, 17)
        Me.txtFechaNacimiento.TabIndex = 14
        Me.txtFechaNacimiento.ValidatingType = GetType(Date)
        '
        'Label9
        '
        Me.Label9.AutoSize = true
        Me.Label9.Location = New System.Drawing.Point(124, 382)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(145, 18)
        Me.Label9.TabIndex = 13
        Me.Label9.Text = "Fecha de nacimiento"
        '
        'Label8
        '
        Me.Label8.AutoSize = true
        Me.Label8.Location = New System.Drawing.Point(124, 322)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(45, 18)
        Me.Label8.TabIndex = 12
        Me.Label8.Text = "Email"
        '
        'Label7
        '
        Me.Label7.AutoSize = true
        Me.Label7.Location = New System.Drawing.Point(124, 266)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(55, 18)
        Me.Label7.TabIndex = 11
        Me.Label7.Text = "Distrito"
        '
        'Label6
        '
        Me.Label6.AutoSize = true
        Me.Label6.Location = New System.Drawing.Point(124, 208)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(56, 18)
        Me.Label6.TabIndex = 10
        Me.Label6.Text = "Cantón"
        '
        'Label5
        '
        Me.Label5.AutoSize = true
        Me.Label5.Location = New System.Drawing.Point(124, 148)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(69, 18)
        Me.Label5.TabIndex = 9
        Me.Label5.Text = "Provincia"
        '
        'Label4
        '
        Me.Label4.AutoSize = true
        Me.Label4.Location = New System.Drawing.Point(124, 89)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(71, 18)
        Me.Label4.TabIndex = 8
        Me.Label4.Text = "Dirección"
        '
        'Label3
        '
        Me.Label3.AutoSize = true
        Me.Label3.Location = New System.Drawing.Point(124, 26)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(62, 18)
        Me.Label3.TabIndex = 7
        Me.Label3.Text = "Nombre"
        '
        'txtEmail
        '
        Me.txtEmail.Font = New System.Drawing.Font("Microsoft Sans Serif", 12!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.txtEmail.Location = New System.Drawing.Point(127, 343)
        Me.txtEmail.Name = "txtEmail"
        Me.txtEmail.Size = New System.Drawing.Size(419, 26)
        Me.txtEmail.TabIndex = 5
        '
        'txtDistrito
        '
        Me.txtDistrito.Font = New System.Drawing.Font("Microsoft Sans Serif", 12!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.txtDistrito.Location = New System.Drawing.Point(127, 287)
        Me.txtDistrito.Name = "txtDistrito"
        Me.txtDistrito.Size = New System.Drawing.Size(419, 26)
        Me.txtDistrito.TabIndex = 4
        '
        'txtCanton
        '
        Me.txtCanton.Font = New System.Drawing.Font("Microsoft Sans Serif", 12!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.txtCanton.Location = New System.Drawing.Point(127, 229)
        Me.txtCanton.Name = "txtCanton"
        Me.txtCanton.Size = New System.Drawing.Size(419, 26)
        Me.txtCanton.TabIndex = 3
        '
        'txtProvincia
        '
        Me.txtProvincia.Font = New System.Drawing.Font("Microsoft Sans Serif", 12!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.txtProvincia.Location = New System.Drawing.Point(127, 169)
        Me.txtProvincia.Name = "txtProvincia"
        Me.txtProvincia.Size = New System.Drawing.Size(419, 26)
        Me.txtProvincia.TabIndex = 2
        '
        'txtDireccion
        '
        Me.txtDireccion.Font = New System.Drawing.Font("Microsoft Sans Serif", 12!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.txtDireccion.Location = New System.Drawing.Point(127, 110)
        Me.txtDireccion.Name = "txtDireccion"
        Me.txtDireccion.Size = New System.Drawing.Size(419, 26)
        Me.txtDireccion.TabIndex = 1
        '
        'txtNombre
        '
        Me.txtNombre.Font = New System.Drawing.Font("Microsoft Sans Serif", 12!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.txtNombre.Location = New System.Drawing.Point(127, 47)
        Me.txtNombre.Name = "txtNombre"
        Me.txtNombre.Size = New System.Drawing.Size(419, 26)
        Me.txtNombre.TabIndex = 40
        '
        'btnGuardar
        '
        Me.btnGuardar.BackColor = System.Drawing.Color.DodgerBlue
        Me.btnGuardar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.MidnightBlue
        Me.btnGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnGuardar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.btnGuardar.ForeColor = System.Drawing.Color.White
        Me.btnGuardar.Location = New System.Drawing.Point(532, 579)
        Me.btnGuardar.Name = "btnGuardar"
        Me.btnGuardar.Size = New System.Drawing.Size(146, 42)
        Me.btnGuardar.TabIndex = 2
        Me.btnGuardar.Text = "Guardar"
        Me.btnGuardar.UseVisualStyleBackColor = false
        '
        'erProveedorError
        '
        Me.erProveedorError.ContainerControl = Me
        '
        'frmPerfil
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6!, 13!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(919, 609)
        Me.Controls.Add(Me.btnGuardar)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"),System.Drawing.Icon)
        Me.Name = "frmPerfil"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Perfil"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.Panel1.ResumeLayout(false)
        Me.Panel1.PerformLayout
        Me.GroupBox1.ResumeLayout(false)
        Me.GroupBox1.PerformLayout
        CType(Me.erProveedorError,System.ComponentModel.ISupportInitialize).EndInit
        Me.ResumeLayout(false)

End Sub
    Friend WithEvents Label1 As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents txtEmail As TextBox
    Friend WithEvents txtDistrito As TextBox
    Friend WithEvents txtCanton As TextBox
    Friend WithEvents txtProvincia As TextBox
    Friend WithEvents txtDireccion As TextBox
    Friend WithEvents txtNombre As TextBox
    Friend WithEvents btnGuardar As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents txtFechaNacimiento As MaskedTextBox
    Friend WithEvents erProveedorError As ErrorProvider
    Friend WithEvents Panel1 As Panel
End Class
