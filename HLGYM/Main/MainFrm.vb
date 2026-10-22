Imports System.Windows.Forms
Imports MaterialSkin
Imports MaterialSkin.Controls

Public Class MainFrm

    Private currentChildForm As Form = Nothing
    Private currentNavButton As MaterialFlatButton = Nothing
    Private isAllowedToExit As Boolean = False
    Private WithEvents timerClock As New Timer()

    Sub New()
        InitializeComponent()

        ' Inisialisasi tema MaterialSkin
        SkinManager.AddFormToManage(Me)
        SkinManager.Theme = MaterialSkinManager.Themes.LIGHT
        SkinManager.ColorScheme = New ColorScheme(
            Primary.Blue800,
            Primary.Blue900,
            Primary.Blue500,
            Accent.LightBlue200,
            TextShade.WHITE
        )
        UpdateDateTime()
    End Sub

    Private Sub MainFrm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.WindowState = FormWindowState.Maximized
        Me.Sizable = False

        timerClock.Interval = 1000
        timerClock.Start()

        tabMain.SelectedTab = tabUserAllList
        ActivateNavButton(btnNavUserAllList)
        LoadUserListForm()
    End Sub

    Private Sub UpdateDateTime()
        lbDateTime.Text = "Date: " & DateTime.Now.ToShortDateString() & "   " & "Time: " & DateTime.Now.ToLongTimeString()
    End Sub

    Private Sub timerClock_Tick(sender As Object, e As EventArgs) Handles timerClock.Tick
        UpdateDateTime()
    End Sub


    Private Sub ActivateNavButton(navButton As MaterialFlatButton)
        If navButton Is Nothing Then Return

        If currentNavButton IsNot Nothing Then
            currentNavButton.Primary = False
        End If

        currentNavButton = navButton
        currentNavButton.Primary = True
    End Sub

    Private Sub LoadUserListForm()
        If currentChildForm IsNot Nothing Then Return

        Dim userListForm As New frm_UserAllList()
        currentChildForm = userListForm
        userListForm.TopLevel = False
        userListForm.FormBorderStyle = FormBorderStyle.None
        userListForm.Dock = DockStyle.Fill

        pnlUserListContainer.Controls.Clear()
        pnlUserListContainer.Controls.Add(userListForm)
        userListForm.BringToFront()
        userListForm.Show()
    End Sub


    Private Sub tabMain_SelectedIndexChanged(sender As Object, e As EventArgs) Handles tabMain.SelectedIndexChanged
        Select Case tabMain.SelectedIndex
            Case 0 ' User All List
                ActivateNavButton(btnNavUserAllList)
                LoadUserListForm()
            Case 1 ' Member
                ActivateNavButton(btnNavMember)
            Case 2 ' Membership
                ActivateNavButton(btnNavMembership)
            Case 3 ' Billing
                ActivateNavButton(btnNavBilling)
            Case 4 ' Membership Type
                ActivateNavButton(btnNavMembershipType)
            Case 5 ' Setting
                ActivateNavButton(btnNavSetting)
        End Select
    End Sub


    Private Sub btnNavUserAllList_Click(sender As Object, e As EventArgs) Handles btnNavUserAllList.Click
        tabMain.SelectedTab = tabUserAllList
    End Sub

    Private Sub btnNavMember_Click(sender As Object, e As EventArgs) Handles btnNavMember.Click
        tabMain.SelectedTab = tabMember
    End Sub

    Private Sub btnNavMembership_Click(sender As Object, e As EventArgs) Handles btnNavMembership.Click
        tabMain.SelectedTab = tabMembership
    End Sub

    Private Sub btnNavBilling_Click(sender As Object, e As EventArgs) Handles btnNavBilling.Click
        tabMain.SelectedTab = tabBilling
    End Sub

    Private Sub btnNavMembershipType_Click(sender As Object, e As EventArgs) Handles btnNavMembershipType.Click
        tabMain.SelectedTab = tabMembershipType
    End Sub

    Private Sub btnNavSetting_Click(sender As Object, e As EventArgs) Handles btnNavSetting.Click
        tabMain.SelectedTab = tabSetting
    End Sub


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
