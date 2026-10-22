Public Class frm_UserEdit

    Public Sub New()
        InitializeComponent()
    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Close()
    End Sub

    Private Sub btnCloseHeader_Click(sender As Object, e As EventArgs) Handles btnCloseHeader.Click
        Close()
    End Sub

    Private Sub lnkChangePassword_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles lnkChangePassword.LinkClicked
        ' Form ganti password akan dibuka di sini saat formnya sudah dibuat
        ' Contoh:
        ' Dim frm As New frm_ChangePassword()
        ' frm.ShowDialog()
    End Sub

End Class
