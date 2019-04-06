Imports System

Public Class frmMenuSA
    
    Private Sub ToolStripBtnCrearPermisos_Click(sender As Object, e As EventArgs) Handles ToolStripBtnCrearPermisos.Click
         Dim permisos As New fmPermisos
         permisos.MdiParent=Me
         Me.SplitContainer1.Panel2.Controls.Add(permisos)
         permisos.Show() 
      '  fmPermisos.Show

    End Sub

    Private Sub ToolStripBtnCrearRoles_Click(sender As Object, e As EventArgs) Handles ToolStripBtnCrearRoles.Click

         Dim roles As New frmRoles
         roles.MdiParent=Me
         Me.SplitContainer1.Panel2.Controls.Add(roles)
         roles.Show()
        ' Users.Show
         'frmRoles.Show  
 


    End Sub

    Private Sub ToolStripBtnCrearUsuarios_Click(sender As Object, e As EventArgs) Handles ToolStripBtnCrearUsuarios.Click
        Dim usuarios As New users
        usuarios.MdiParent=Me
        Me.SplitContainer1.Panel2.Controls.Add(usuarios)
        usuarios.Show()
        ' Users.Show
 
    End Sub

    Private Sub ToolStripBtnSalir_Click(sender As Object, e As EventArgs) Handles ToolStripBtnSalir.Click

        frmDashBoard.Show()
        Me.Close()


    End Sub
End Class