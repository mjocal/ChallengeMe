<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmActualizarPerfil
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmActualizarPerfil))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.btnSalir = New System.Windows.Forms.Button()
        Me.btnCambiarImagen = New System.Windows.Forms.Button()
        Me.btnCuenta = New System.Windows.Forms.Button()
        Me.btnPerfil = New System.Windows.Forms.Button()
        Me.TrackBar1 = New System.Windows.Forms.TrackBar()
        Me.txtNombreRol = New System.Windows.Forms.TextBox()
        Me.txtUSUARIO = New System.Windows.Forms.TextBox()
        Me.lblNombreUsuario = New System.Windows.Forms.Label()
        Me.picImgUsr = New System.Windows.Forms.PictureBox()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.btnCerrar = New System.Windows.Forms.Button()
        Me.ttpToolTip = New System.Windows.Forms.ToolTip(Me.components)
        Me.Panel1.SuspendLayout
        CType(Me.TrackBar1,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.picImgUsr,System.ComponentModel.ISupportInitialize).BeginInit
        Me.Panel3.SuspendLayout
        Me.Panel4.SuspendLayout
        Me.SuspendLayout
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.MediumAquamarine
        Me.Panel1.Controls.Add(Me.btnSalir)
        Me.Panel1.Controls.Add(Me.btnCambiarImagen)
        Me.Panel1.Controls.Add(Me.btnCuenta)
        Me.Panel1.Controls.Add(Me.btnPerfil)
        Me.Panel1.Controls.Add(Me.TrackBar1)
        Me.Panel1.Controls.Add(Me.txtNombreRol)
        Me.Panel1.Controls.Add(Me.txtUSUARIO)
        Me.Panel1.Controls.Add(Me.lblNombreUsuario)
        Me.Panel1.Controls.Add(Me.picImgUsr)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(253, 663)
        Me.Panel1.TabIndex = 8
        '
        'btnSalir
        '
        Me.btnSalir.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnSalir.FlatAppearance.BorderColor = System.Drawing.Color.MediumAquamarine
        Me.btnSalir.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Navy
        Me.btnSalir.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSalir.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.btnSalir.ForeColor = System.Drawing.Color.White
        Me.btnSalir.Image = Global.Challengeme.UI.OnPremises.My.Resources.Resources.icons8_Exit_64
        Me.btnSalir.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnSalir.Location = New System.Drawing.Point(-1, 448)
        Me.btnSalir.Name = "btnSalir"
        Me.btnSalir.Size = New System.Drawing.Size(256, 58)
        Me.btnSalir.TabIndex = 16
        Me.btnSalir.Text = "                      Salir"
        Me.btnSalir.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnSalir.UseVisualStyleBackColor = true
        '
        'btnCambiarImagen
        '
        Me.btnCambiarImagen.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnCambiarImagen.FlatAppearance.BorderColor = System.Drawing.Color.MediumAquamarine
        Me.btnCambiarImagen.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Navy
        Me.btnCambiarImagen.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCambiarImagen.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.btnCambiarImagen.ForeColor = System.Drawing.Color.White
        Me.btnCambiarImagen.Image = Global.Challengeme.UI.OnPremises.My.Resources.Resources.icons8_Add_Camera_64
        Me.btnCambiarImagen.ImageAlign = System.Drawing.ContentAlignment.BottomLeft
        Me.btnCambiarImagen.Location = New System.Drawing.Point(-1, 386)
        Me.btnCambiarImagen.Name = "btnCambiarImagen"
        Me.btnCambiarImagen.Size = New System.Drawing.Size(256, 60)
        Me.btnCambiarImagen.TabIndex = 15
        Me.btnCambiarImagen.Text = "                       Cambiar imagen"
        Me.btnCambiarImagen.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnCambiarImagen.UseVisualStyleBackColor = true
        '
        'btnCuenta
        '
        Me.btnCuenta.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnCuenta.FlatAppearance.BorderColor = System.Drawing.Color.MediumAquamarine
        Me.btnCuenta.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Navy
        Me.btnCuenta.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCuenta.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.btnCuenta.ForeColor = System.Drawing.Color.White
        Me.btnCuenta.Image = Global.Challengeme.UI.OnPremises.My.Resources.Resources.icons8_Shopping_Cart_64
        Me.btnCuenta.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnCuenta.Location = New System.Drawing.Point(-1, 322)
        Me.btnCuenta.Name = "btnCuenta"
        Me.btnCuenta.Size = New System.Drawing.Size(256, 58)
        Me.btnCuenta.TabIndex = 14
        Me.btnCuenta.Text = "Cuenta"
        Me.btnCuenta.UseVisualStyleBackColor = true
        '
        'btnPerfil
        '
        Me.btnPerfil.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnPerfil.FlatAppearance.BorderColor = System.Drawing.Color.MediumAquamarine
        Me.btnPerfil.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Navy
        Me.btnPerfil.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnPerfil.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.btnPerfil.ForeColor = System.Drawing.Color.White
        Me.btnPerfil.Image = Global.Challengeme.UI.OnPremises.My.Resources.Resources.icons8_User_64
        Me.btnPerfil.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnPerfil.Location = New System.Drawing.Point(-1, 258)
        Me.btnPerfil.Name = "btnPerfil"
        Me.btnPerfil.Size = New System.Drawing.Size(256, 58)
        Me.btnPerfil.TabIndex = 13
        Me.btnPerfil.Text = "Mi perfil"
        Me.btnPerfil.UseVisualStyleBackColor = true
        '
        'TrackBar1
        '
        Me.TrackBar1.Location = New System.Drawing.Point(-18, 232)
        Me.TrackBar1.Name = "TrackBar1"
        Me.TrackBar1.Size = New System.Drawing.Size(282, 45)
        Me.TrackBar1.TabIndex = 12
        '
        'txtNombreRol
        '
        Me.txtNombreRol.BackColor = System.Drawing.Color.MediumAquamarine
        Me.txtNombreRol.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtNombreRol.Enabled = false
        Me.txtNombreRol.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.txtNombreRol.ForeColor = System.Drawing.Color.White
        Me.txtNombreRol.Location = New System.Drawing.Point(27, 209)
        Me.txtNombreRol.Name = "txtNombreRol"
        Me.txtNombreRol.Size = New System.Drawing.Size(191, 17)
        Me.txtNombreRol.TabIndex = 11
        Me.txtNombreRol.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtUSUARIO
        '
        Me.txtUSUARIO.BackColor = System.Drawing.Color.MediumAquamarine
        Me.txtUSUARIO.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtUSUARIO.Enabled = false
        Me.txtUSUARIO.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.txtUSUARIO.ForeColor = System.Drawing.Color.White
        Me.txtUSUARIO.Location = New System.Drawing.Point(27, 186)
        Me.txtUSUARIO.Name = "txtUSUARIO"
        Me.txtUSUARIO.Size = New System.Drawing.Size(196, 17)
        Me.txtUSUARIO.TabIndex = 10
        Me.txtUSUARIO.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'lblNombreUsuario
        '
        Me.lblNombreUsuario.AutoSize = true
        Me.lblNombreUsuario.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.lblNombreUsuario.ForeColor = System.Drawing.Color.White
        Me.lblNombreUsuario.Location = New System.Drawing.Point(23, 163)
        Me.lblNombreUsuario.Name = "lblNombreUsuario"
        Me.lblNombreUsuario.Size = New System.Drawing.Size(60, 18)
        Me.lblNombreUsuario.TabIndex = 9
        Me.lblNombreUsuario.Text = "Usuario"
        Me.lblNombreUsuario.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'picImgUsr
        '
        Me.picImgUsr.Location = New System.Drawing.Point(27, 12)
        Me.picImgUsr.Name = "picImgUsr"
        Me.picImgUsr.Size = New System.Drawing.Size(192, 138)
        Me.picImgUsr.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.picImgUsr.TabIndex = 8
        Me.picImgUsr.TabStop = false
        '
        'Panel2
        '
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel2.Location = New System.Drawing.Point(253, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(801, 663)
        Me.Panel2.TabIndex = 9
        '
        'Panel3
        '
        Me.Panel3.Controls.Add(Me.Panel4)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel3.Location = New System.Drawing.Point(253, 0)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(801, 51)
        Me.Panel3.TabIndex = 11
        '
        'Panel4
        '
        Me.Panel4.Controls.Add(Me.btnCerrar)
        Me.Panel4.Dock = System.Windows.Forms.DockStyle.Right
        Me.Panel4.Location = New System.Drawing.Point(729, 0)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(72, 51)
        Me.Panel4.TabIndex = 1
        '
        'btnCerrar
        '
        Me.btnCerrar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnCerrar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gainsboro
        Me.btnCerrar.ForeColor = System.Drawing.Color.White
        Me.btnCerrar.Image = Global.Challengeme.UI.OnPremises.My.Resources.Resources.X2
        Me.btnCerrar.Location = New System.Drawing.Point(16, 3)
        Me.btnCerrar.Name = "btnCerrar"
        Me.btnCerrar.Size = New System.Drawing.Size(39, 40)
        Me.btnCerrar.TabIndex = 143
        Me.ttpToolTip.SetToolTip(Me.btnCerrar, "Regresa al Dashboard principal")
        Me.btnCerrar.UseVisualStyleBackColor = true
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
        'frmActualizarPerfil
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6!, 13!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1054, 663)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"),System.Drawing.Icon)
        Me.IsMdiContainer = true
        Me.Name = "frmActualizarPerfil"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.Panel1.ResumeLayout(false)
        Me.Panel1.PerformLayout
        CType(Me.TrackBar1,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.picImgUsr,System.ComponentModel.ISupportInitialize).EndInit
        Me.Panel3.ResumeLayout(false)
        Me.Panel4.ResumeLayout(false)
        Me.ResumeLayout(false)

End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents TrackBar1 As TrackBar
    Friend WithEvents txtNombreRol As TextBox
    Friend WithEvents txtUSUARIO As TextBox
    Friend WithEvents lblNombreUsuario As Label
    Friend WithEvents picImgUsr As PictureBox
    Friend WithEvents Panel2 As Panel
    Friend WithEvents btnPerfil As Button
    Friend WithEvents btnCuenta As Button
    Friend WithEvents btnCambiarImagen As Button
    Friend WithEvents btnSalir As Button
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Panel4 As Panel
    Friend WithEvents btnCerrar As Button
    Friend WithEvents ttpToolTip As ToolTip
End Class
