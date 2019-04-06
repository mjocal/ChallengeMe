<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmMenuSA
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmMenuSA))
        Me.tspPrincipal = New System.Windows.Forms.ToolStrip()
        Me.ToolStripBtnCrearPermisos = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripBtnCrearRoles = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripBtnCrearUsuarios = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripBtnSalir = New System.Windows.Forms.ToolStripButton()
        Me.SplitContainer1 = New System.Windows.Forms.SplitContainer()
        Me.tspPrincipal.SuspendLayout
        CType(Me.SplitContainer1,System.ComponentModel.ISupportInitialize).BeginInit
        Me.SplitContainer1.SuspendLayout
        Me.SuspendLayout
        '
        'tspPrincipal
        '
        Me.tspPrincipal.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
        Me.tspPrincipal.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripBtnCrearPermisos, Me.ToolStripBtnCrearRoles, Me.ToolStripBtnCrearUsuarios, Me.ToolStripBtnSalir})
        Me.tspPrincipal.Location = New System.Drawing.Point(0, 0)
        Me.tspPrincipal.Name = "tspPrincipal"
        Me.tspPrincipal.RenderMode = System.Windows.Forms.ToolStripRenderMode.System
        Me.tspPrincipal.Size = New System.Drawing.Size(767, 71)
        Me.tspPrincipal.TabIndex = 4
        Me.tspPrincipal.Text = "ToolStrip1"
        '
        'ToolStripBtnCrearPermisos
        '
        Me.ToolStripBtnCrearPermisos.Font = New System.Drawing.Font("Microsoft Sans Serif", 9!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.ToolStripBtnCrearPermisos.Image = CType(resources.GetObject("ToolStripBtnCrearPermisos.Image"),System.Drawing.Image)
        Me.ToolStripBtnCrearPermisos.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.ToolStripBtnCrearPermisos.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripBtnCrearPermisos.Name = "ToolStripBtnCrearPermisos"
        Me.ToolStripBtnCrearPermisos.Size = New System.Drawing.Size(159, 68)
        Me.ToolStripBtnCrearPermisos.Text = "Crear permisos"
        '
        'ToolStripBtnCrearRoles
        '
        Me.ToolStripBtnCrearRoles.Font = New System.Drawing.Font("Microsoft Sans Serif", 9!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.ToolStripBtnCrearRoles.Image = CType(resources.GetObject("ToolStripBtnCrearRoles.Image"),System.Drawing.Image)
        Me.ToolStripBtnCrearRoles.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.ToolStripBtnCrearRoles.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripBtnCrearRoles.Name = "ToolStripBtnCrearRoles"
        Me.ToolStripBtnCrearRoles.Size = New System.Drawing.Size(135, 68)
        Me.ToolStripBtnCrearRoles.Text = "Crear roles"
        '
        'ToolStripBtnCrearUsuarios
        '
        Me.ToolStripBtnCrearUsuarios.Font = New System.Drawing.Font("Microsoft Sans Serif", 9!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.ToolStripBtnCrearUsuarios.Image = CType(resources.GetObject("ToolStripBtnCrearUsuarios.Image"),System.Drawing.Image)
        Me.ToolStripBtnCrearUsuarios.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.ToolStripBtnCrearUsuarios.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripBtnCrearUsuarios.Name = "ToolStripBtnCrearUsuarios"
        Me.ToolStripBtnCrearUsuarios.Size = New System.Drawing.Size(155, 68)
        Me.ToolStripBtnCrearUsuarios.Text = "Crear usuarios"
        '
        'ToolStripBtnSalir
        '
        Me.ToolStripBtnSalir.Font = New System.Drawing.Font("Microsoft Sans Serif", 9!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.ToolStripBtnSalir.Image = CType(resources.GetObject("ToolStripBtnSalir.Image"),System.Drawing.Image)
        Me.ToolStripBtnSalir.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.ToolStripBtnSalir.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripBtnSalir.Name = "ToolStripBtnSalir"
        Me.ToolStripBtnSalir.Size = New System.Drawing.Size(100, 68)
        Me.ToolStripBtnSalir.Text = "Salir"
        '
        'SplitContainer1
        '
        Me.SplitContainer1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer1.Location = New System.Drawing.Point(0, 71)
        Me.SplitContainer1.Name = "SplitContainer1"
        Me.SplitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal
        Me.SplitContainer1.Panel1Collapsed = true
        '
        'SplitContainer1.Panel2
        '
        Me.SplitContainer1.Panel2.BackgroundImage = Global.Challengeme.UI.OnPremises.My.Resources.Resources.seguridad2
        Me.SplitContainer1.Panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.SplitContainer1.Size = New System.Drawing.Size(767, 404)
        Me.SplitContainer1.SplitterDistance = 255
        Me.SplitContainer1.TabIndex = 6
        '
        'frmMenuSA
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6!, 13!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(767, 475)
        Me.Controls.Add(Me.SplitContainer1)
        Me.Controls.Add(Me.tspPrincipal)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"),System.Drawing.Icon)
        Me.IsMdiContainer = true
        Me.Name = "frmMenuSA"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Menú para el Super Administrador y el Administrador"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.tspPrincipal.ResumeLayout(false)
        Me.tspPrincipal.PerformLayout
        CType(Me.SplitContainer1,System.ComponentModel.ISupportInitialize).EndInit
        Me.SplitContainer1.ResumeLayout(false)
        Me.ResumeLayout(false)
        Me.PerformLayout

End Sub
    Friend WithEvents tspPrincipal As ToolStrip
    Friend WithEvents ToolStripBtnCrearPermisos As ToolStripButton
    Friend WithEvents ToolStripBtnCrearRoles As ToolStripButton
    Friend WithEvents ToolStripBtnCrearUsuarios As ToolStripButton
    Friend WithEvents ToolStripBtnSalir As ToolStripButton
    Friend WithEvents SplitContainer1 As SplitContainer
End Class
