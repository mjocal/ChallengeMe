<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMenuEventos
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
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.btnSalir = New System.Windows.Forms.Button()
        Me.btnEventos = New System.Windows.Forms.Button()
        Me.btnPremios = New System.Windows.Forms.Button()
        Me.btnPatrocinadores = New System.Windows.Forms.Button()
        Me.btnActividades = New System.Windows.Forms.Button()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Panel1.SuspendLayout
        Me.SuspendLayout
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.DodgerBlue
        Me.Panel1.Controls.Add(Me.btnSalir)
        Me.Panel1.Controls.Add(Me.btnEventos)
        Me.Panel1.Controls.Add(Me.btnPremios)
        Me.Panel1.Controls.Add(Me.btnPatrocinadores)
        Me.Panel1.Controls.Add(Me.btnActividades)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(377, 889)
        Me.Panel1.TabIndex = 1
        '
        'btnSalir
        '
        Me.btnSalir.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnSalir.FlatAppearance.BorderColor = System.Drawing.Color.DodgerBlue
        Me.btnSalir.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Navy
        Me.btnSalir.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSalir.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.btnSalir.ForeColor = System.Drawing.Color.White
        Me.btnSalir.Image = Global.Challengeme.UI.OnPremises.My.Resources.Resources.icons8_Exit_64
        Me.btnSalir.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnSalir.Location = New System.Drawing.Point(-1, 613)
        Me.btnSalir.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btnSalir.Name = "btnSalir"
        Me.btnSalir.Size = New System.Drawing.Size(377, 76)
        Me.btnSalir.TabIndex = 9
        Me.btnSalir.Text = "Volver al menú"
        Me.btnSalir.UseVisualStyleBackColor = true
        '
        'btnEventos
        '
        Me.btnEventos.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnEventos.FlatAppearance.BorderColor = System.Drawing.Color.DodgerBlue
        Me.btnEventos.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Navy
        Me.btnEventos.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnEventos.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.btnEventos.ForeColor = System.Drawing.Color.White
        Me.btnEventos.Image = Global.Challengeme.UI.OnPremises.My.Resources.Resources.icons8_Running_64
        Me.btnEventos.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnEventos.Location = New System.Drawing.Point(-1, 537)
        Me.btnEventos.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btnEventos.Name = "btnEventos"
        Me.btnEventos.Size = New System.Drawing.Size(377, 76)
        Me.btnEventos.TabIndex = 8
        Me.btnEventos.Text = "Eventos"
        Me.btnEventos.UseVisualStyleBackColor = true
        '
        'btnPremios
        '
        Me.btnPremios.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnPremios.FlatAppearance.BorderColor = System.Drawing.Color.DodgerBlue
        Me.btnPremios.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Navy
        Me.btnPremios.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnPremios.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.btnPremios.ForeColor = System.Drawing.Color.White
        Me.btnPremios.Image = Global.Challengeme.UI.OnPremises.My.Resources.Resources.icons8_Medal_First_Place_64
        Me.btnPremios.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnPremios.Location = New System.Drawing.Point(-1, 459)
        Me.btnPremios.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btnPremios.Name = "btnPremios"
        Me.btnPremios.Size = New System.Drawing.Size(377, 76)
        Me.btnPremios.TabIndex = 7
        Me.btnPremios.Text = "Premios"
        Me.btnPremios.UseVisualStyleBackColor = true
        '
        'btnPatrocinadores
        '
        Me.btnPatrocinadores.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnPatrocinadores.FlatAppearance.BorderColor = System.Drawing.Color.DodgerBlue
        Me.btnPatrocinadores.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Navy
        Me.btnPatrocinadores.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnPatrocinadores.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.btnPatrocinadores.ForeColor = System.Drawing.Color.White
        Me.btnPatrocinadores.Image = Global.Challengeme.UI.OnPremises.My.Resources.Resources.icons8_Handshake_64
        Me.btnPatrocinadores.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnPatrocinadores.Location = New System.Drawing.Point(-1, 383)
        Me.btnPatrocinadores.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btnPatrocinadores.Name = "btnPatrocinadores"
        Me.btnPatrocinadores.Size = New System.Drawing.Size(377, 76)
        Me.btnPatrocinadores.TabIndex = 6
        Me.btnPatrocinadores.Text = "Patrocinadores"
        Me.btnPatrocinadores.UseVisualStyleBackColor = true
        '
        'btnActividades
        '
        Me.btnActividades.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnActividades.FlatAppearance.BorderColor = System.Drawing.Color.DodgerBlue
        Me.btnActividades.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Navy
        Me.btnActividades.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnActividades.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.btnActividades.ForeColor = System.Drawing.Color.White
        Me.btnActividades.Image = Global.Challengeme.UI.OnPremises.My.Resources.Resources.icons8_News_Feed_64
        Me.btnActividades.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnActividades.Location = New System.Drawing.Point(-1, 308)
        Me.btnActividades.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btnActividades.Name = "btnActividades"
        Me.btnActividades.Size = New System.Drawing.Size(379, 76)
        Me.btnActividades.TabIndex = 5
        Me.btnActividades.Text = "Actividades"
        Me.btnActividades.UseVisualStyleBackColor = true
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.White
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel2.Location = New System.Drawing.Point(377, 0)
        Me.Panel2.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(594, 889)
        Me.Panel2.TabIndex = 2
        '
        'frmMenuEventos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8!, 16!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(971, 889)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.IsMdiContainer = true
        Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Name = "frmMenuEventos"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frmMenuEventos"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.Panel1.ResumeLayout(false)
        Me.ResumeLayout(false)

End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents btnSalir As Button
    Friend WithEvents btnEventos As Button
    Friend WithEvents btnPremios As Button
    Friend WithEvents btnPatrocinadores As Button
    Friend WithEvents btnActividades As Button
    Friend WithEvents Panel2 As Panel
End Class
