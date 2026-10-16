Public Class frm_UserAllList
    Dim DTUsers As New DataTable

    Sub New()
        InitializeComponent()
        Try
            If My.Application.DBA IsNot Nothing Then
                DTUsers = My.Application.DBA.UserList()
                If DTUsers IsNot Nothing Then
                    DTUsers.DefaultView.Sort = dgvUserList.Columns(0).DataPropertyName
                    dgvUserList.DataSource = DTUsers
                End If
            End If
        Catch ex As Exception
            MessageBox.Show("Gagal memuat data pengguna: " & ex.Message, "Error Data", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End Try
    End Sub

    Private Sub TambahUserToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles TambahUserToolStripMenuItem.Click
        Dim fUserInsert = New frmUserInsert(Me)
        fUserInsert.ShowDialog()
    End Sub
End Class