Imports System.Windows.Forms

Public Class frm_UserAllList
    Dim DTUsers As New DataTable
    Dim user As Users

    Sub New()
        InitializeComponent()
        LoadDataUsers()
    End Sub

    Public Sub LoadDataUsers()
        Try
            If My.Application.DBA IsNot Nothing Then
                DTUsers = My.Application.DBA.UserList()
                If DTUsers IsNot Nothing Then
                    ' Pertahankan sort kolom jika user pernah mengklik header kolom
                    If dgvUserList.SortedColumn IsNot Nothing AndAlso DTUsers.Columns.Contains(dgvUserList.SortedColumn.DataPropertyName) Then
                        Dim sortDir As String = If(dgvUserList.SortOrder = SortOrder.Descending, "DESC", "ASC")
                        DTUsers.DefaultView.Sort = dgvUserList.SortedColumn.DataPropertyName & " " & sortDir
                    End If

                    dgvUserList.DataSource = DTUsers.DefaultView
                    ApplySearchFilter()
                Else
                    UpdateUserCount()
                End If
            End If
        Catch ex As Exception
            MessageBox.Show("Gagal memuat data pengguna: " & ex.Message, "Error Data", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End Try
    End Sub

    Private Sub ApplySearchFilter()
        If DTUsers Is Nothing Then
            UpdateUserCount()
            Return
        End If

        Dim keyword As String = txtSearch.Text.Trim()
        If String.IsNullOrEmpty(keyword) Then
            DTUsers.DefaultView.RowFilter = String.Empty
        Else
            Dim safeKeyword As String = keyword.Replace("'", "''").Replace("[", "[[]").Replace("%", "[%]").Replace("*", "[*]")
            DTUsers.DefaultView.RowFilter = String.Format("Username LIKE '%{0}%' OR FullName LIKE '%{0}%'", safeKeyword)
        End If

        UpdateUserCount()
    End Sub

    Private Sub UpdateUserCount()
        If DTUsers IsNot Nothing AndAlso DTUsers.DefaultView IsNot Nothing Then
            Dim count As Integer = DTUsers.DefaultView.Count
            lblTotalUsers.Text = String.Format("({0} data)", count)
        Else
            lblTotalUsers.Text = "(0 data)"
        End If
    End Sub

    Private Sub txtSearch_TextChanged(sender As Object, e As EventArgs) Handles txtSearch.TextChanged
        ApplySearchFilter()
    End Sub

    Private Sub btnClearSearch_Click(sender As Object, e As EventArgs) Handles btnClearSearch.Click
        txtSearch.Clear()
        ApplySearchFilter()
        txtSearch.Focus()
    End Sub

    Private Sub txtSearch_KeyDown(sender As Object, e As KeyEventArgs) Handles txtSearch.KeyDown
        If e.KeyCode = Keys.Escape Then
            txtSearch.Clear()
            e.SuppressKeyPress = True
        End If
    End Sub

    Private Sub TambahUserToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles TambahUserToolStripMenuItem.Click
        Dim fUserInsert = New frmUserInsert(Me)
        fUserInsert.ShowDialog()
    End Sub

    Public Sub RefreshData()
        LoadDataUsers()
    End Sub

    Private Sub dgvUserList_MouseDown(sender As Object, e As MouseEventArgs) Handles dgvUserList.MouseDown
        If e.Button = MouseButtons.Right Then
            Dim HT As DataGridView.HitTestInfo = dgvUserList.HitTest(e.X, e.Y)

            If HT.Type = DataGridViewHitTestType.Cell AndAlso HT.RowIndex >= 0 Then
                dgvUserList.ClearSelection()
                dgvUserList.Rows(HT.RowIndex).Selected = True
                dgvUserList.CurrentCell = dgvUserList.Rows(HT.RowIndex).Cells(HT.ColumnIndex)

                Dim row As DataGridViewRow = dgvUserList.Rows(HT.RowIndex)
                user.UserID = If(IsDBNull(row.Cells("UserID").Value), 0, Convert.ToInt32(row.Cells("UserID").Value))
                user.Username = If(IsDBNull(row.Cells("Username").Value), "", row.Cells("Username").Value.ToString())
                user.FullName = If(IsDBNull(row.Cells("FullName").Value), "", row.Cells("FullName").Value.ToString())
                user.Role = If(IsDBNull(row.Cells("Role").Value), "", row.Cells("Role").Value.ToString())

                Dim valActive As Object = row.Cells("IsActive").Value
                If IsDBNull(valActive) OrElse valActive Is Nothing Then
                    user.IsActive = 0
                Else
                    Dim strActive As String = valActive.ToString().Trim()
                    If strActive.Equals("Aktif", StringComparison.OrdinalIgnoreCase) OrElse
                       strActive.Equals("True", StringComparison.OrdinalIgnoreCase) OrElse
                       strActive = "1" Then
                        user.IsActive = 1
                    Else
                        user.IsActive = 0
                    End If
                End If

                EditUserToolStripMenuItem.Enabled = True
                HapusUserToolStripMenuItem.Enabled = True
            Else
                user = New Users()
                EditUserToolStripMenuItem.Enabled = False
                HapusUserToolStripMenuItem.Enabled = False
            End If
        End If
    End Sub

    Private Sub HapusUserToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles HapusUserToolStripMenuItem.Click
        If user.UserID <= 0 Then
            MessageBox.Show("Pilih user yang ingin dihapus terlebih dahulu!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If

        Dim konfirmasi As DialogResult = MessageBox.Show(
            String.Format("Apakah Anda yakin ingin menghapus user '{0}' (ID: {1})?", user.Username, user.UserID),
            "Konfirmasi Hapus",
            MessageBoxButtons.YesNo,
            MessageBoxIcon.Question
        )

        If konfirmasi = DialogResult.Yes Then
            Dim hasil As String = My.Application.DBA.UserHapus(user.UserID)
            If hasil = "Sukses" Then
                MessageBox.Show("User berhasil dihapus!", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information)
                RefreshData()
            Else
                MessageBox.Show("Gagal menghapus user dari database.", "Error Hapus User", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        End If
    End Sub

End Class
