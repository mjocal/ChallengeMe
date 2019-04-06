Imports Challengeme.Entities

Public Class ExceptionManagement
    Public Sub ManageException(ByVal ex As ChallengeMeException)
        MessageBox.Show(ex.ErrorDescription, ex.ErrorBusinnesCode, MessageBoxButtons.OK, MessageBoxIcon.Error)
    End Sub

End Class
