<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmCuenta
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmCuenta))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.txtUsuario = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtConfirmarContrasenia = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtNuevaContrasenia = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtContraseniaVieja = New System.Windows.Forms.TextBox()
        Me.btnCambiarContrasenia = New System.Windows.Forms.Button()
        Me.erProveedorError = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.Panel1.SuspendLayout
        Me.GroupBox1.SuspendLayout
        Me.GroupBox2.SuspendLayout
        CType(Me.erProveedorError,System.ComponentModel.ISupportInitialize).BeginInit
        Me.SuspendLayout
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.White
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Font = New System.Drawing.Font("Open Sans", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1127, 115)
        Me.Panel1.TabIndex = 0
        '
        'Label2
        '
        Me.Label2.AutoSize = true
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.Label2.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.Label2.Location = New System.Drawing.Point(319, 73)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(470, 24)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Edita la configuración de tu contraseña y cambiala aquí"
        '
        'Label1
        '
        Me.Label1.AutoSize = true
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 18!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.Label1.Location = New System.Drawing.Point(475, 27)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(95, 29)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Cuenta"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.txtUsuario)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(328, 152)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(451, 126)
        Me.GroupBox1.TabIndex = 1
        Me.GroupBox1.TabStop = false
        Me.GroupBox1.Text = "Usuario"
        '
        'txtUsuario
        '
        Me.txtUsuario.BackColor = System.Drawing.Color.White
        Me.txtUsuario.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtUsuario.Enabled = false
        Me.txtUsuario.Location = New System.Drawing.Point(140, 54)
        Me.txtUsuario.Name = "txtUsuario"
        Me.txtUsuario.Size = New System.Drawing.Size(188, 19)
        Me.txtUsuario.TabIndex = 40
        '
        'Label3
        '
        Me.Label3.AutoSize = true
        Me.Label3.Location = New System.Drawing.Point(26, 53)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(108, 20)
        Me.Label3.TabIndex = 0
        Me.Label3.Text = "Tu usuario es:"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.Label6)
        Me.GroupBox2.Controls.Add(Me.txtConfirmarContrasenia)
        Me.GroupBox2.Controls.Add(Me.Label5)
        Me.GroupBox2.Controls.Add(Me.txtNuevaContrasenia)
        Me.GroupBox2.Controls.Add(Me.Label4)
        Me.GroupBox2.Controls.Add(Me.txtContraseniaVieja)
        Me.GroupBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.GroupBox2.Location = New System.Drawing.Point(329, 307)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(449, 258)
        Me.GroupBox2.TabIndex = 2
        Me.GroupBox2.TabStop = false
        Me.GroupBox2.Text = "Contraseña:*"
        '
        'Label6
        '
        Me.Label6.AutoSize = true
        Me.Label6.Location = New System.Drawing.Point(74, 175)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(222, 20)
        Me.Label6.TabIndex = 5
        Me.Label6.Text = "Escribe la contraseña otra vez"
        '
        'txtConfirmarContrasenia
        '
        Me.txtConfirmarContrasenia.Location = New System.Drawing.Point(71, 203)
        Me.txtConfirmarContrasenia.Name = "txtConfirmarContrasenia"
        Me.txtConfirmarContrasenia.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtConfirmarContrasenia.Size = New System.Drawing.Size(332, 26)
        Me.txtConfirmarContrasenia.TabIndex = 4
        '
        'Label5
        '
        Me.Label5.AutoSize = true
        Me.Label5.Location = New System.Drawing.Point(74, 106)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(209, 20)
        Me.Label5.TabIndex = 3
        Me.Label5.Text = "Escribe la contraseña nueva"
        '
        'txtNuevaContrasenia
        '
        Me.txtNuevaContrasenia.Location = New System.Drawing.Point(71, 132)
        Me.txtNuevaContrasenia.Name = "txtNuevaContrasenia"
        Me.txtNuevaContrasenia.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtNuevaContrasenia.Size = New System.Drawing.Size(337, 26)
        Me.txtNuevaContrasenia.TabIndex = 2
        '
        'Label4
        '
        Me.Label4.AutoSize = true
        Me.Label4.Location = New System.Drawing.Point(74, 37)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(209, 20)
        Me.Label4.TabIndex = 1
        Me.Label4.Text = "Escribe la contraseña actual"
        '
        'txtContraseniaVieja
        '
        Me.txtContraseniaVieja.Location = New System.Drawing.Point(71, 63)
        Me.txtContraseniaVieja.Name = "txtContraseniaVieja"
        Me.txtContraseniaVieja.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtContraseniaVieja.Size = New System.Drawing.Size(340, 26)
        Me.txtContraseniaVieja.TabIndex = 0
        '
        'btnCambiarContrasenia
        '
        Me.btnCambiarContrasenia.BackColor = System.Drawing.Color.DodgerBlue
        Me.btnCambiarContrasenia.FlatAppearance.MouseOverBackColor = System.Drawing.Color.MidnightBlue
        Me.btnCambiarContrasenia.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCambiarContrasenia.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.btnCambiarContrasenia.ForeColor = System.Drawing.Color.White
        Me.btnCambiarContrasenia.Location = New System.Drawing.Point(455, 572)
        Me.btnCambiarContrasenia.Name = "btnCambiarContrasenia"
        Me.btnCambiarContrasenia.Size = New System.Drawing.Size(218, 47)
        Me.btnCambiarContrasenia.TabIndex = 3
        Me.btnCambiarContrasenia.Text = "Cambiar la contraseña"
        Me.btnCambiarContrasenia.UseVisualStyleBackColor = false
        '
        'erProveedorError
        '
        Me.erProveedorError.ContainerControl = Me
        '
        'frmCuenta
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6!, 15!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1127, 733)
        Me.Controls.Add(Me.btnCambiarContrasenia)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Panel1)
        Me.Font = New System.Drawing.Font("Open Sans", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"),System.Drawing.Icon)
        Me.Name = "frmCuenta"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.Panel1.ResumeLayout(false)
        Me.Panel1.PerformLayout
        Me.GroupBox1.ResumeLayout(false)
        Me.GroupBox1.PerformLayout
        Me.GroupBox2.ResumeLayout(false)
        Me.GroupBox2.PerformLayout
        CType(Me.erProveedorError,System.ComponentModel.ISupportInitialize).EndInit
        Me.ResumeLayout(false)

End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents txtUsuario As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents Label6 As Label
    Friend WithEvents txtConfirmarContrasenia As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents txtNuevaContrasenia As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents txtContraseniaVieja As TextBox
    Friend WithEvents btnCambiarContrasenia As Button
    Friend WithEvents erProveedorError As ErrorProvider
End Class
