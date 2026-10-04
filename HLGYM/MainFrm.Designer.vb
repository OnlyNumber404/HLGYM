<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class MainFrm
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
        Me.pnlSidebar = New System.Windows.Forms.Panel()
        Me.pnlNavMenu = New System.Windows.Forms.Panel()
        Me.btnNavBilling = New System.Windows.Forms.Button()
        Me.btnNavMembershipType = New System.Windows.Forms.Button()
        Me.btnNavMembership = New System.Windows.Forms.Button()
        Me.btnNavMember = New System.Windows.Forms.Button()
        Me.btnNavUserList = New System.Windows.Forms.Button()
        Me.pnlSidebarBottom = New System.Windows.Forms.Panel()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.pnlBrand = New System.Windows.Forms.Panel()
        Me.lblBrandSub = New System.Windows.Forms.Label()
        Me.lblBrandName = New System.Windows.Forms.Label()
        Me.lblBrandIcon = New System.Windows.Forms.Label()
        Me.pnlHeader = New System.Windows.Forms.Panel()
        Me.btnHeaderExit = New System.Windows.Forms.Button()
        Me.lblHeaderUser = New System.Windows.Forms.Label()
        Me.lblTitle = New System.Windows.Forms.Label()
        Me.pnlContent = New System.Windows.Forms.Panel()
        Me.pnlSidebar.SuspendLayout()
        Me.pnlNavMenu.SuspendLayout()
        Me.pnlSidebarBottom.SuspendLayout()
        Me.pnlBrand.SuspendLayout()
        Me.pnlHeader.SuspendLayout()
        Me.SuspendLayout()
        '
        'pnlSidebar
        '
        Me.pnlSidebar.BackColor = System.Drawing.Color.FromArgb(CType(CType(21, Byte), Integer), CType(CType(24, Byte), Integer), CType(CType(33, Byte), Integer))
        Me.pnlSidebar.Controls.Add(Me.pnlNavMenu)
        Me.pnlSidebar.Controls.Add(Me.pnlSidebarBottom)
        Me.pnlSidebar.Controls.Add(Me.pnlBrand)
        Me.pnlSidebar.Dock = System.Windows.Forms.DockStyle.Left
        Me.pnlSidebar.Location = New System.Drawing.Point(0, 0)
        Me.pnlSidebar.Name = "pnlSidebar"
        Me.pnlSidebar.Size = New System.Drawing.Size(250, 800)
        Me.pnlSidebar.TabIndex = 0
        '
        'pnlNavMenu
        '
        Me.pnlNavMenu.AutoScroll = True
        Me.pnlNavMenu.Controls.Add(Me.btnNavBilling)
        Me.pnlNavMenu.Controls.Add(Me.btnNavMembershipType)
        Me.pnlNavMenu.Controls.Add(Me.btnNavMembership)
        Me.pnlNavMenu.Controls.Add(Me.btnNavMember)
        Me.pnlNavMenu.Controls.Add(Me.btnNavUserList)
        Me.pnlNavMenu.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnlNavMenu.Location = New System.Drawing.Point(0, 85)
        Me.pnlNavMenu.Name = "pnlNavMenu"
        Me.pnlNavMenu.Padding = New System.Windows.Forms.Padding(12, 10, 12, 10)
        Me.pnlNavMenu.Size = New System.Drawing.Size(250, 645)
        Me.pnlNavMenu.TabIndex = 1
        '
        'btnNavBilling
        '
        Me.btnNavBilling.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnNavBilling.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnNavBilling.FlatAppearance.BorderSize = 0
        Me.btnNavBilling.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnNavBilling.Font = New System.Drawing.Font("Segoe UI Semibold", 10.0!, System.Drawing.FontStyle.Bold)
        Me.btnNavBilling.ForeColor = System.Drawing.Color.FromArgb(CType(CType(150, Byte), Integer), CType(CType(156, Byte), Integer), CType(CType(175, Byte), Integer))
        Me.btnNavBilling.Location = New System.Drawing.Point(12, 194)
        Me.btnNavBilling.Margin = New System.Windows.Forms.Padding(0, 3, 0, 3)
        Me.btnNavBilling.Name = "btnNavBilling"
        Me.btnNavBilling.Padding = New System.Windows.Forms.Padding(15, 0, 0, 0)
        Me.btnNavBilling.Size = New System.Drawing.Size(226, 46)
        Me.btnNavBilling.TabIndex = 5
        Me.btnNavBilling.Text = "  💳   Billing List"
        Me.btnNavBilling.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnNavBilling.UseVisualStyleBackColor = True
        '
        'btnNavMembershipType
        '
        Me.btnNavMembershipType.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnNavMembershipType.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnNavMembershipType.FlatAppearance.BorderSize = 0
        Me.btnNavMembershipType.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnNavMembershipType.Font = New System.Drawing.Font("Segoe UI Semibold", 10.0!, System.Drawing.FontStyle.Bold)
        Me.btnNavMembershipType.ForeColor = System.Drawing.Color.FromArgb(CType(CType(150, Byte), Integer), CType(CType(156, Byte), Integer), CType(CType(175, Byte), Integer))
        Me.btnNavMembershipType.Location = New System.Drawing.Point(12, 148)
        Me.btnNavMembershipType.Margin = New System.Windows.Forms.Padding(0, 3, 0, 3)
        Me.btnNavMembershipType.Name = "btnNavMembershipType"
        Me.btnNavMembershipType.Padding = New System.Windows.Forms.Padding(15, 0, 0, 0)
        Me.btnNavMembershipType.Size = New System.Drawing.Size(226, 46)
        Me.btnNavMembershipType.TabIndex = 4
        Me.btnNavMembershipType.Text = "  👑   Membership Type"
        Me.btnNavMembershipType.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnNavMembershipType.UseVisualStyleBackColor = True
        '
        'btnNavMembership
        '
        Me.btnNavMembership.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnNavMembership.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnNavMembership.FlatAppearance.BorderSize = 0
        Me.btnNavMembership.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnNavMembership.Font = New System.Drawing.Font("Segoe UI Semibold", 10.0!, System.Drawing.FontStyle.Bold)
        Me.btnNavMembership.ForeColor = System.Drawing.Color.FromArgb(CType(CType(150, Byte), Integer), CType(CType(156, Byte), Integer), CType(CType(175, Byte), Integer))
        Me.btnNavMembership.Location = New System.Drawing.Point(12, 102)
        Me.btnNavMembership.Margin = New System.Windows.Forms.Padding(0, 3, 0, 3)
        Me.btnNavMembership.Name = "btnNavMembership"
        Me.btnNavMembership.Padding = New System.Windows.Forms.Padding(15, 0, 0, 0)
        Me.btnNavMembership.Size = New System.Drawing.Size(226, 46)
        Me.btnNavMembership.TabIndex = 3
        Me.btnNavMembership.Text = "  📅   Membership"
        Me.btnNavMembership.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnNavMembership.UseVisualStyleBackColor = True
        '
        'btnNavMember
        '
        Me.btnNavMember.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnNavMember.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnNavMember.FlatAppearance.BorderSize = 0
        Me.btnNavMember.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnNavMember.Font = New System.Drawing.Font("Segoe UI Semibold", 10.0!, System.Drawing.FontStyle.Bold)
        Me.btnNavMember.ForeColor = System.Drawing.Color.FromArgb(CType(CType(150, Byte), Integer), CType(CType(156, Byte), Integer), CType(CType(175, Byte), Integer))
        Me.btnNavMember.Location = New System.Drawing.Point(12, 56)
        Me.btnNavMember.Margin = New System.Windows.Forms.Padding(0, 3, 0, 3)
        Me.btnNavMember.Name = "btnNavMember"
        Me.btnNavMember.Padding = New System.Windows.Forms.Padding(15, 0, 0, 0)
        Me.btnNavMember.Size = New System.Drawing.Size(226, 46)
        Me.btnNavMember.TabIndex = 2
        Me.btnNavMember.Text = "  🏋   Member"
        Me.btnNavMember.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnNavMember.UseVisualStyleBackColor = True
        '
        'btnNavUserList
        '
        Me.btnNavUserList.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnNavUserList.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnNavUserList.FlatAppearance.BorderSize = 0
        Me.btnNavUserList.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnNavUserList.Font = New System.Drawing.Font("Segoe UI Semibold", 10.0!, System.Drawing.FontStyle.Bold)
        Me.btnNavUserList.ForeColor = System.Drawing.Color.FromArgb(CType(CType(150, Byte), Integer), CType(CType(156, Byte), Integer), CType(CType(175, Byte), Integer))
        Me.btnNavUserList.Location = New System.Drawing.Point(12, 10)
        Me.btnNavUserList.Margin = New System.Windows.Forms.Padding(0, 3, 0, 3)
        Me.btnNavUserList.Name = "btnNavUserList"
        Me.btnNavUserList.Padding = New System.Windows.Forms.Padding(15, 0, 0, 0)
        Me.btnNavUserList.Size = New System.Drawing.Size(226, 46)
        Me.btnNavUserList.TabIndex = 1
        Me.btnNavUserList.Text = "  👥   User List"
        Me.btnNavUserList.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnNavUserList.UseVisualStyleBackColor = True
        '
        'pnlSidebarBottom
        '
        Me.pnlSidebarBottom.Controls.Add(Me.btnExit)
        Me.pnlSidebarBottom.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.pnlSidebarBottom.Location = New System.Drawing.Point(0, 730)
        Me.pnlSidebarBottom.Name = "pnlSidebarBottom"
        Me.pnlSidebarBottom.Padding = New System.Windows.Forms.Padding(16, 12, 16, 16)
        Me.pnlSidebarBottom.Size = New System.Drawing.Size(250, 70)
        Me.pnlSidebarBottom.TabIndex = 2
        '
        'btnExit
        '
        Me.btnExit.BackColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(34, Byte), Integer), CType(CType(46, Byte), Integer))
        Me.btnExit.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnExit.Dock = System.Windows.Forms.DockStyle.Fill
        Me.btnExit.FlatAppearance.BorderSize = 0
        Me.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnExit.Font = New System.Drawing.Font("Segoe UI Semibold", 10.0!, System.Drawing.FontStyle.Bold)
        Me.btnExit.ForeColor = System.Drawing.Color.FromArgb(CType(CType(245, Byte), Integer), CType(CType(100, Byte), Integer), CType(CType(100, Byte), Integer))
        Me.btnExit.Location = New System.Drawing.Point(16, 12)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Padding = New System.Windows.Forms.Padding(15, 0, 0, 0)
        Me.btnExit.Size = New System.Drawing.Size(218, 42)
        Me.btnExit.TabIndex = 0
        Me.btnExit.Text = "  🚪   Exit Application"
        Me.btnExit.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnExit.UseVisualStyleBackColor = False
        '
        'pnlBrand
        '
        Me.pnlBrand.Controls.Add(Me.lblBrandSub)
        Me.pnlBrand.Controls.Add(Me.lblBrandName)
        Me.pnlBrand.Controls.Add(Me.lblBrandIcon)
        Me.pnlBrand.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnlBrand.Location = New System.Drawing.Point(0, 0)
        Me.pnlBrand.Name = "pnlBrand"
        Me.pnlBrand.Size = New System.Drawing.Size(250, 85)
        Me.pnlBrand.TabIndex = 0
        '
        'lblBrandSub
        '
        Me.lblBrandSub.AutoSize = True
        Me.lblBrandSub.Font = New System.Drawing.Font("Segoe UI", 7.5!)
        Me.lblBrandSub.ForeColor = System.Drawing.Color.FromArgb(CType(CType(120, Byte), Integer), CType(CType(126, Byte), Integer), CType(CType(145, Byte), Integer))
        Me.lblBrandSub.Location = New System.Drawing.Point(64, 49)
        Me.lblBrandSub.Name = "lblBrandSub"
        Me.lblBrandSub.Size = New System.Drawing.Size(145, 17)
        Me.lblBrandSub.TabIndex = 2
        Me.lblBrandSub.Text = "HLGYM MANAGEMENT"
        '
        'lblBrandName
        '
        Me.lblBrandName.AutoSize = True
        Me.lblBrandName.Font = New System.Drawing.Font("Segoe UI", 15.0!, System.Drawing.FontStyle.Bold)
        Me.lblBrandName.ForeColor = System.Drawing.Color.White
        Me.lblBrandName.Location = New System.Drawing.Point(62, 20)
        Me.lblBrandName.Name = "lblBrandName"
        Me.lblBrandName.Size = New System.Drawing.Size(111, 35)
        Me.lblBrandName.TabIndex = 1
        Me.lblBrandName.Text = "HL GYM"
        '
        'lblBrandIcon
        '
        Me.lblBrandIcon.AutoSize = True
        Me.lblBrandIcon.Font = New System.Drawing.Font("Segoe UI", 18.0!, System.Drawing.FontStyle.Bold)
        Me.lblBrandIcon.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(107, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.lblBrandIcon.Location = New System.Drawing.Point(22, 18)
        Me.lblBrandIcon.Name = "lblBrandIcon"
        Me.lblBrandIcon.Size = New System.Drawing.Size(60, 41)
        Me.lblBrandIcon.TabIndex = 0
        Me.lblBrandIcon.Text = "⚡"
        '
        'pnlHeader
        '
        Me.pnlHeader.BackColor = System.Drawing.Color.FromArgb(CType(CType(21, Byte), Integer), CType(CType(24, Byte), Integer), CType(CType(33, Byte), Integer))
        Me.pnlHeader.Controls.Add(Me.btnHeaderExit)
        Me.pnlHeader.Controls.Add(Me.lblHeaderUser)
        Me.pnlHeader.Controls.Add(Me.lblTitle)
        Me.pnlHeader.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnlHeader.Location = New System.Drawing.Point(250, 0)
        Me.pnlHeader.Name = "pnlHeader"
        Me.pnlHeader.Size = New System.Drawing.Size(950, 65)
        Me.pnlHeader.TabIndex = 1
        '
        'btnHeaderExit
        '
        Me.btnHeaderExit.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnHeaderExit.BackColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(34, Byte), Integer), CType(CType(46, Byte), Integer))
        Me.btnHeaderExit.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnHeaderExit.FlatAppearance.BorderSize = 0
        Me.btnHeaderExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnHeaderExit.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold)
        Me.btnHeaderExit.ForeColor = System.Drawing.Color.FromArgb(CType(CType(245, Byte), Integer), CType(CType(100, Byte), Integer), CType(CType(100, Byte), Integer))
        Me.btnHeaderExit.Location = New System.Drawing.Point(850, 16)
        Me.btnHeaderExit.Name = "btnHeaderExit"
        Me.btnHeaderExit.Size = New System.Drawing.Size(82, 34)
        Me.btnHeaderExit.TabIndex = 2
        Me.btnHeaderExit.Text = "✕  Exit"
        Me.btnHeaderExit.UseVisualStyleBackColor = False
        '
        'lblHeaderUser
        '
        Me.lblHeaderUser.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblHeaderUser.AutoSize = True
        Me.lblHeaderUser.Font = New System.Drawing.Font("Segoe UI", 9.5!)
        Me.lblHeaderUser.ForeColor = System.Drawing.Color.FromArgb(CType(CType(165, Byte), Integer), CType(CType(172, Byte), Integer), CType(CType(190, Byte), Integer))
        Me.lblHeaderUser.Location = New System.Drawing.Point(715, 24)
        Me.lblHeaderUser.Name = "lblHeaderUser"
        Me.lblHeaderUser.Size = New System.Drawing.Size(131, 21)
        Me.lblHeaderUser.TabIndex = 1
        Me.lblHeaderUser.Text = "👤  Super Admin"
        '
        'lblTitle
        '
        Me.lblTitle.AutoSize = True
        Me.lblTitle.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold)
        Me.lblTitle.ForeColor = System.Drawing.Color.White
        Me.lblTitle.Location = New System.Drawing.Point(25, 21)
        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.Size = New System.Drawing.Size(214, 28)
        Me.lblTitle.TabIndex = 0
        Me.lblTitle.Text = "HL GYM   /   User List"
        '
        'pnlContent
        '
        Me.pnlContent.BackColor = System.Drawing.Color.FromArgb(CType(CType(15, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(23, Byte), Integer))
        Me.pnlContent.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnlContent.Location = New System.Drawing.Point(250, 65)
        Me.pnlContent.Name = "pnlContent"
        Me.pnlContent.Size = New System.Drawing.Size(950, 735)
        Me.pnlContent.TabIndex = 2
        '
        'MainFrm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(15, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(23, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1200, 800)
        Me.ControlBox = False
        Me.Controls.Add(Me.pnlContent)
        Me.Controls.Add(Me.pnlHeader)
        Me.Controls.Add(Me.pnlSidebar)
        Me.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.KeyPreview = True
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "MainFrm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "HL GYM - Management System"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.pnlSidebar.ResumeLayout(False)
        Me.pnlNavMenu.ResumeLayout(False)
        Me.pnlSidebarBottom.ResumeLayout(False)
        Me.pnlBrand.ResumeLayout(False)
        Me.pnlBrand.PerformLayout()
        Me.pnlHeader.ResumeLayout(False)
        Me.pnlHeader.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents pnlSidebar As System.Windows.Forms.Panel
    Friend WithEvents pnlBrand As System.Windows.Forms.Panel
    Friend WithEvents lblBrandIcon As System.Windows.Forms.Label
    Friend WithEvents lblBrandName As System.Windows.Forms.Label
    Friend WithEvents lblBrandSub As System.Windows.Forms.Label
    Friend WithEvents pnlNavMenu As System.Windows.Forms.Panel
    Friend WithEvents btnNavUserList As System.Windows.Forms.Button
    Friend WithEvents btnNavMember As System.Windows.Forms.Button
    Friend WithEvents btnNavMembership As System.Windows.Forms.Button
    Friend WithEvents btnNavMembershipType As System.Windows.Forms.Button
    Friend WithEvents btnNavBilling As System.Windows.Forms.Button
    Friend WithEvents pnlSidebarBottom As System.Windows.Forms.Panel
    Friend WithEvents btnExit As System.Windows.Forms.Button
    Friend WithEvents pnlHeader As System.Windows.Forms.Panel
    Friend WithEvents lblTitle As System.Windows.Forms.Label
    Friend WithEvents lblHeaderUser As System.Windows.Forms.Label
    Friend WithEvents btnHeaderExit As System.Windows.Forms.Button
    Friend WithEvents pnlContent As System.Windows.Forms.Panel
End Class
