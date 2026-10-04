Imports System.Drawing
Imports System.Windows.Forms

Public Class MainFrm
    Private ReadOnly COLOR_NAV_ACTIVE_BG As Color = Color.FromArgb(255, 107, 0)      ' Warna Oren saat Nav aktif
    Private ReadOnly COLOR_NAV_ACTIVE_FG As Color = Color.White                      ' Warna teks saat Nav aktif
    Private ReadOnly COLOR_NAV_INACTIVE_BG As Color = Color.Transparent              ' Warna background nav normal (hitam/transparan)
    Private ReadOnly COLOR_NAV_INACTIVE_FG As Color = Color.FromArgb(150, 156, 175)  ' Warna teks nav normal (abu-abu)
    Private ReadOnly COLOR_NAV_HOVER As Color = Color.FromArgb(32, 36, 48)           ' Warna saat cursor diarahkan (hover)

    Private currentChildForm As Form = Nothing
    Private currentNavButton As Button = Nothing
    Private isAllowedToExit As Boolean = False

    Private Sub MainFrm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.FormBorderStyle = FormBorderStyle.None
        Me.WindowState = FormWindowState.Maximized

        OpenChildForm(New frm_UserAllList(), btnNavUserList, "User List")
    End Sub

    ''' <summary>
    ''' Mengubah warna tombol navigasi yang aktif menjadi OREN dan tombol lainnya kembali normal
    ''' </summary>
    Private Sub ActivateNavButton(navButton As Button, menuTitle As String)
        If navButton Is Nothing Then Return

        If currentNavButton IsNot Nothing Then
            currentNavButton.BackColor = COLOR_NAV_INACTIVE_BG
            currentNavButton.ForeColor = COLOR_NAV_INACTIVE_FG
            currentNavButton.FlatAppearance.MouseOverBackColor = COLOR_NAV_HOVER
        End If

        currentNavButton = navButton
        currentNavButton.BackColor = COLOR_NAV_ACTIVE_BG
        currentNavButton.ForeColor = COLOR_NAV_ACTIVE_FG
        currentNavButton.FlatAppearance.MouseOverBackColor = Color.FromArgb(255, 125, 25)

        lblTitle.Text = "HL GYM   /   " & menuTitle
    End Sub

    ''' <summary>
    ''' Membuka Child Form (seperti frm_UserAllList) ke dalam Panel Utama (pnlContent)
    ''' </summary>
    Public Sub OpenChildForm(childForm As Form, senderNav As Button, titleText As String)

        If currentChildForm IsNot Nothing Then
            currentChildForm.Close()
            currentChildForm.Dispose()
            currentChildForm = Nothing
        End If

        ActivateNavButton(senderNav, titleText)

        currentChildForm = childForm
        childForm.TopLevel = False
        childForm.FormBorderStyle = FormBorderStyle.None
        childForm.Dock = DockStyle.Fill
        pnlContent.Controls.Clear()
        pnlContent.Controls.Add(childForm)
        pnlContent.Tag = childForm
        childForm.BringToFront()
        childForm.Show()
    End Sub

    ' ===== EVENT TOMBOL NAVIGASI =====

    Private Sub btnNavUserList_Click(sender As Object, e As EventArgs) Handles btnNavUserList.Click
        OpenChildForm(New frm_UserAllList(), btnNavUserList, "User List")
    End Sub

    Private Sub btnNavMember_Click(sender As Object, e As EventArgs) Handles btnNavMember.Click
        ActivateNavButton(btnNavMember, "Member")
    End Sub

    Private Sub btnNavMebership_Click(sender As Object, e As EventArgs) Handles btnNavMembership.Click
        ActivateNavButton(btnNavMembership, "Membership")
    End Sub

    Private Sub btnNavMembershipType_Click(sender As Object, e As EventArgs) Handles btnNavMembershipType.Click
        ActivateNavButton(btnNavMembershipType, "Membership Type")
    End Sub

    Private Sub btnNavBilling_Click(sender As Object, e As EventArgs) Handles btnNavBilling.Click
        ActivateNavButton(btnNavBilling, "Billing List")
    End Sub


    ''' <summary>
    ''' Tombol Exit resmi untuk keluar dari aplikasi
    ''' </summary>
    Private Sub TriggerExit()
        Dim result As DialogResult = MessageBox.Show(
            "Apakah Anda yakin ingin keluar dari aplikasi HL GYM?",
            "Konfirmasi Keluar",
            MessageBoxButtons.YesNo,
            MessageBoxIcon.Question
        )

        If result = DialogResult.Yes Then
            isAllowedToExit = True
            Application.Exit()
        End If
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        TriggerExit()
    End Sub

    Private Sub btnHeaderExit_Click(sender As Object, e As EventArgs) Handles btnHeaderExit.Click
        TriggerExit()
    End Sub

    ''' <summary>
    ''' Mencegah form di-close melalui cara selain tombol Exit (misal Alt+F4)
    ''' </summary>
    Private Sub MainFrm_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        If isAllowedToExit Then
            Return
        End If

        If e.CloseReason = CloseReason.WindowsShutDown OrElse e.CloseReason = CloseReason.TaskManagerClosing Then
            Return
        End If

        e.Cancel = True
        TriggerExit()
    End Sub

End Class
