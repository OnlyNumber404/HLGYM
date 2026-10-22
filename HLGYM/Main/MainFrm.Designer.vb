<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class MainFrm
    Inherits MaterialSkin.Controls.MaterialForm

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
        Me.tabMain = New MaterialSkin.Controls.MaterialTabControl()
        Me.tabUserAllList = New System.Windows.Forms.TabPage()
        Me.pnlUserListContainer = New System.Windows.Forms.Panel()
        Me.tabMember = New System.Windows.Forms.TabPage()
        Me.lblMemberInfo = New MaterialSkin.Controls.MaterialLabel()
        Me.tabMembership = New System.Windows.Forms.TabPage()
        Me.lblMembershipInfo = New MaterialSkin.Controls.MaterialLabel()
        Me.tabBilling = New System.Windows.Forms.TabPage()
        Me.lblBillingInfo = New MaterialSkin.Controls.MaterialLabel()
        Me.tabMembershipType = New System.Windows.Forms.TabPage()
        Me.lblMembershipTypeInfo = New MaterialSkin.Controls.MaterialLabel()
        Me.tabSetting = New System.Windows.Forms.TabPage()
        Me.lblSettingInfo = New MaterialSkin.Controls.MaterialLabel()
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.lbDateTime = New System.Windows.Forms.ToolStripStatusLabel()
        Me.lbDbStatus = New System.Windows.Forms.ToolStripStatusLabel()
        Me.pnlBody = New System.Windows.Forms.Panel()
        Me.pnlSidebar = New System.Windows.Forms.Panel()
        Me.pnlNavButtons = New System.Windows.Forms.Panel()
        Me.btnNavSetting = New MaterialSkin.Controls.MaterialFlatButton()
        Me.btnNavMembershipType = New MaterialSkin.Controls.MaterialFlatButton()
        Me.btnNavBilling = New MaterialSkin.Controls.MaterialFlatButton()
        Me.btnNavMembership = New MaterialSkin.Controls.MaterialFlatButton()
        Me.btnNavMember = New MaterialSkin.Controls.MaterialFlatButton()
        Me.btnNavUserAllList = New MaterialSkin.Controls.MaterialFlatButton()
        Me.pnlSidebarBottom = New System.Windows.Forms.Panel()
        Me.btnExit = New MaterialSkin.Controls.MaterialRaisedButton()
        Me.pnlBrand = New System.Windows.Forms.Panel()
        Me.lblBrandTitle = New MaterialSkin.Controls.MaterialLabel()
        Me.dividerSidebar = New MaterialSkin.Controls.MaterialDivider()
        Me.tabMain.SuspendLayout()
        Me.tabUserAllList.SuspendLayout()
        Me.tabMember.SuspendLayout()
        Me.tabMembership.SuspendLayout()
        Me.tabBilling.SuspendLayout()
        Me.tabMembershipType.SuspendLayout()
        Me.tabSetting.SuspendLayout()
        Me.StatusStrip1.SuspendLayout()
        Me.pnlBody.SuspendLayout()
        Me.pnlSidebar.SuspendLayout()
        Me.pnlNavButtons.SuspendLayout()
        Me.pnlSidebarBottom.SuspendLayout()
        Me.pnlBrand.SuspendLayout()
        Me.SuspendLayout()
        '
        'tabMain
        '
        Me.tabMain.Controls.Add(Me.tabUserAllList)
        Me.tabMain.Controls.Add(Me.tabMember)
        Me.tabMain.Controls.Add(Me.tabMembership)
        Me.tabMain.Controls.Add(Me.tabBilling)
        Me.tabMain.Controls.Add(Me.tabMembershipType)
        Me.tabMain.Controls.Add(Me.tabSetting)
        Me.tabMain.Depth = 0
        Me.tabMain.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tabMain.Location = New System.Drawing.Point(220, 0)
        Me.tabMain.MouseState = MaterialSkin.MouseState.HOVER
        Me.tabMain.Name = "tabMain"
        Me.tabMain.SelectedIndex = 0
        Me.tabMain.Size = New System.Drawing.Size(980, 778)
        Me.tabMain.TabIndex = 1
        '
        'tabUserAllList
        '
        Me.tabUserAllList.BackColor = System.Drawing.Color.White
        Me.tabUserAllList.Controls.Add(Me.pnlUserListContainer)
        Me.tabUserAllList.Location = New System.Drawing.Point(4, 29)
        Me.tabUserAllList.Name = "tabUserAllList"
        Me.tabUserAllList.Size = New System.Drawing.Size(972, 745)
        Me.tabUserAllList.TabIndex = 0
        Me.tabUserAllList.Text = "USER ALL LIST"
        '
        'pnlUserListContainer
        '
        Me.pnlUserListContainer.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnlUserListContainer.Location = New System.Drawing.Point(0, 0)
        Me.pnlUserListContainer.Name = "pnlUserListContainer"
        Me.pnlUserListContainer.Size = New System.Drawing.Size(972, 745)
        Me.pnlUserListContainer.TabIndex = 0
        '
        'tabMember
        '
        Me.tabMember.BackColor = System.Drawing.Color.White
        Me.tabMember.Controls.Add(Me.lblMemberInfo)
        Me.tabMember.Location = New System.Drawing.Point(4, 29)
        Me.tabMember.Name = "tabMember"
        Me.tabMember.Padding = New System.Windows.Forms.Padding(20)
        Me.tabMember.Size = New System.Drawing.Size(972, 743)
        Me.tabMember.TabIndex = 1
        Me.tabMember.Text = "MEMBER"
        '
        'lblMemberInfo
        '
        Me.lblMemberInfo.AutoSize = True
        Me.lblMemberInfo.Depth = 0
        Me.lblMemberInfo.Font = New System.Drawing.Font("Roboto", 11.0!)
        Me.lblMemberInfo.ForeColor = System.Drawing.Color.FromArgb(CType(CType(222, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.lblMemberInfo.Location = New System.Drawing.Point(20, 20)
        Me.lblMemberInfo.MouseState = MaterialSkin.MouseState.HOVER
        Me.lblMemberInfo.Name = "lblMemberInfo"
        Me.lblMemberInfo.Size = New System.Drawing.Size(169, 24)
        Me.lblMemberInfo.TabIndex = 0
        Me.lblMemberInfo.Text = "Modul Member HL"
        '
        'tabMembership
        '
        Me.tabMembership.BackColor = System.Drawing.Color.White
        Me.tabMembership.Controls.Add(Me.lblMembershipInfo)
        Me.tabMembership.Location = New System.Drawing.Point(4, 29)
        Me.tabMembership.Name = "tabMembership"
        Me.tabMembership.Padding = New System.Windows.Forms.Padding(20)
        Me.tabMembership.Size = New System.Drawing.Size(972, 743)
        Me.tabMembership.TabIndex = 2
        Me.tabMembership.Text = "MEMBERSHIP"
        '
        'lblMembershipInfo
        '
        Me.lblMembershipInfo.AutoSize = True
        Me.lblMembershipInfo.Depth = 0
        Me.lblMembershipInfo.Font = New System.Drawing.Font("Roboto", 11.0!)
        Me.lblMembershipInfo.ForeColor = System.Drawing.Color.FromArgb(CType(CType(222, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.lblMembershipInfo.Location = New System.Drawing.Point(20, 20)
        Me.lblMembershipInfo.MouseState = MaterialSkin.MouseState.HOVER
        Me.lblMembershipInfo.Name = "lblMembershipInfo"
        Me.lblMembershipInfo.Size = New System.Drawing.Size(205, 24)
        Me.lblMembershipInfo.TabIndex = 0
        Me.lblMembershipInfo.Text = "Modul Membership HL"
        '
        'tabBilling
        '
        Me.tabBilling.BackColor = System.Drawing.Color.White
        Me.tabBilling.Controls.Add(Me.lblBillingInfo)
        Me.tabBilling.Location = New System.Drawing.Point(4, 29)
        Me.tabBilling.Name = "tabBilling"
        Me.tabBilling.Padding = New System.Windows.Forms.Padding(20)
        Me.tabBilling.Size = New System.Drawing.Size(972, 743)
        Me.tabBilling.TabIndex = 3
        Me.tabBilling.Text = "BILLING"
        '
        'lblBillingInfo
        '
        Me.lblBillingInfo.AutoSize = True
        Me.lblBillingInfo.Depth = 0
        Me.lblBillingInfo.Font = New System.Drawing.Font("Roboto", 11.0!)
        Me.lblBillingInfo.ForeColor = System.Drawing.Color.FromArgb(CType(CType(222, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.lblBillingInfo.Location = New System.Drawing.Point(20, 20)
        Me.lblBillingInfo.MouseState = MaterialSkin.MouseState.HOVER
        Me.lblBillingInfo.Name = "lblBillingInfo"
        Me.lblBillingInfo.Size = New System.Drawing.Size(187, 24)
        Me.lblBillingInfo.TabIndex = 0
        Me.lblBillingInfo.Text = "Modul Billing List HL"
        '
        'tabMembershipType
        '
        Me.tabMembershipType.BackColor = System.Drawing.Color.White
        Me.tabMembershipType.Controls.Add(Me.lblMembershipTypeInfo)
        Me.tabMembershipType.Location = New System.Drawing.Point(4, 29)
        Me.tabMembershipType.Name = "tabMembershipType"
        Me.tabMembershipType.Padding = New System.Windows.Forms.Padding(20)
        Me.tabMembershipType.Size = New System.Drawing.Size(972, 743)
        Me.tabMembershipType.TabIndex = 4
        Me.tabMembershipType.Text = "MEMBERSHIP TYPE"
        '
        'lblMembershipTypeInfo
        '
        Me.lblMembershipTypeInfo.AutoSize = True
        Me.lblMembershipTypeInfo.Depth = 0
        Me.lblMembershipTypeInfo.Font = New System.Drawing.Font("Roboto", 11.0!)
        Me.lblMembershipTypeInfo.ForeColor = System.Drawing.Color.FromArgb(CType(CType(222, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.lblMembershipTypeInfo.Location = New System.Drawing.Point(20, 20)
        Me.lblMembershipTypeInfo.MouseState = MaterialSkin.MouseState.HOVER
        Me.lblMembershipTypeInfo.Name = "lblMembershipTypeInfo"
        Me.lblMembershipTypeInfo.Size = New System.Drawing.Size(251, 24)
        Me.lblMembershipTypeInfo.TabIndex = 0
        Me.lblMembershipTypeInfo.Text = "Modul Membership Type HL"
        '
        'tabSetting
        '
        Me.tabSetting.BackColor = System.Drawing.Color.White
        Me.tabSetting.Controls.Add(Me.lblSettingInfo)
        Me.tabSetting.Location = New System.Drawing.Point(4, 29)
        Me.tabSetting.Name = "tabSetting"
        Me.tabSetting.Padding = New System.Windows.Forms.Padding(20)
        Me.tabSetting.Size = New System.Drawing.Size(972, 743)
        Me.tabSetting.TabIndex = 5
        Me.tabSetting.Text = "SETTING"
        '
        'lblSettingInfo
        '
        Me.lblSettingInfo.AutoSize = True
        Me.lblSettingInfo.Depth = 0
        Me.lblSettingInfo.Font = New System.Drawing.Font("Roboto", 11.0!)
        Me.lblSettingInfo.ForeColor = System.Drawing.Color.FromArgb(CType(CType(222, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.lblSettingInfo.Location = New System.Drawing.Point(20, 20)
        Me.lblSettingInfo.MouseState = MaterialSkin.MouseState.HOVER
        Me.lblSettingInfo.Name = "lblSettingInfo"
        Me.lblSettingInfo.Size = New System.Drawing.Size(157, 24)
        Me.lblSettingInfo.TabIndex = 0
        Me.lblSettingInfo.Text = "Modul Setting HL"
        '
        'StatusStrip1
        '
        Me.StatusStrip1.BackColor = System.Drawing.Color.White
        Me.StatusStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.lbDateTime, Me.lbDbStatus})
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 778)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Size = New System.Drawing.Size(1200, 22)
        Me.StatusStrip1.TabIndex = 0
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'lbDateTime
        '
        Me.lbDateTime.Name = "lbDateTime"
        Me.lbDateTime.Size = New System.Drawing.Size(0, 18)
        '
        'lbDbStatus
        '
        Me.lbDbStatus.Name = "lbDbStatus"
        Me.lbDbStatus.Size = New System.Drawing.Size(0, 18)
        '
        'pnlBody
        '
        Me.pnlBody.Controls.Add(Me.tabMain)
        Me.pnlBody.Controls.Add(Me.pnlSidebar)
        Me.pnlBody.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnlBody.Location = New System.Drawing.Point(0, 0)
        Me.pnlBody.Name = "pnlBody"
        Me.pnlBody.Size = New System.Drawing.Size(1200, 778)
        Me.pnlBody.TabIndex = 2
        '
        'pnlSidebar
        '
        Me.pnlSidebar.BackColor = System.Drawing.Color.FromArgb(CType(CType(250, Byte), Integer), CType(CType(250, Byte), Integer), CType(CType(250, Byte), Integer))
        Me.pnlSidebar.Controls.Add(Me.pnlNavButtons)
        Me.pnlSidebar.Controls.Add(Me.pnlSidebarBottom)
        Me.pnlSidebar.Controls.Add(Me.pnlBrand)
        Me.pnlSidebar.Controls.Add(Me.dividerSidebar)
        Me.pnlSidebar.Dock = System.Windows.Forms.DockStyle.Left
        Me.pnlSidebar.Location = New System.Drawing.Point(0, 0)
        Me.pnlSidebar.Name = "pnlSidebar"
        Me.pnlSidebar.Size = New System.Drawing.Size(220, 778)
        Me.pnlSidebar.TabIndex = 0
        '
        'pnlNavButtons
        '
        Me.pnlNavButtons.AutoScroll = True
        Me.pnlNavButtons.Controls.Add(Me.btnNavSetting)
        Me.pnlNavButtons.Controls.Add(Me.btnNavMembershipType)
        Me.pnlNavButtons.Controls.Add(Me.btnNavBilling)
        Me.pnlNavButtons.Controls.Add(Me.btnNavMembership)
        Me.pnlNavButtons.Controls.Add(Me.btnNavMember)
        Me.pnlNavButtons.Controls.Add(Me.btnNavUserAllList)
        Me.pnlNavButtons.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnlNavButtons.Location = New System.Drawing.Point(0, 56)
        Me.pnlNavButtons.Name = "pnlNavButtons"
        Me.pnlNavButtons.Padding = New System.Windows.Forms.Padding(8, 6, 8, 6)
        Me.pnlNavButtons.Size = New System.Drawing.Size(219, 662)
        Me.pnlNavButtons.TabIndex = 1
        '
        'btnNavSetting
        '
        Me.btnNavSetting.AutoSize = True
        Me.btnNavSetting.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.btnNavSetting.Depth = 0
        Me.btnNavSetting.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnNavSetting.Location = New System.Drawing.Point(8, 186)
        Me.btnNavSetting.Margin = New System.Windows.Forms.Padding(0)
        Me.btnNavSetting.MouseState = MaterialSkin.MouseState.HOVER
        Me.btnNavSetting.Name = "btnNavSetting"
        Me.btnNavSetting.Primary = False
        Me.btnNavSetting.Size = New System.Drawing.Size(203, 36)
        Me.btnNavSetting.TabIndex = 5
        Me.btnNavSetting.Text = "Setting"
        Me.btnNavSetting.UseVisualStyleBackColor = True
        '
        'btnNavMembershipType
        '
        Me.btnNavMembershipType.AutoSize = True
        Me.btnNavMembershipType.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.btnNavMembershipType.Depth = 0
        Me.btnNavMembershipType.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnNavMembershipType.Location = New System.Drawing.Point(8, 150)
        Me.btnNavMembershipType.Margin = New System.Windows.Forms.Padding(0)
        Me.btnNavMembershipType.MouseState = MaterialSkin.MouseState.HOVER
        Me.btnNavMembershipType.Name = "btnNavMembershipType"
        Me.btnNavMembershipType.Primary = False
        Me.btnNavMembershipType.Size = New System.Drawing.Size(203, 36)
        Me.btnNavMembershipType.TabIndex = 4
        Me.btnNavMembershipType.Text = "Membership Type"
        Me.btnNavMembershipType.UseVisualStyleBackColor = True
        '
        'btnNavBilling
        '
        Me.btnNavBilling.AutoSize = True
        Me.btnNavBilling.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.btnNavBilling.Depth = 0
        Me.btnNavBilling.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnNavBilling.Location = New System.Drawing.Point(8, 114)
        Me.btnNavBilling.Margin = New System.Windows.Forms.Padding(0)
        Me.btnNavBilling.MouseState = MaterialSkin.MouseState.HOVER
        Me.btnNavBilling.Name = "btnNavBilling"
        Me.btnNavBilling.Primary = False
        Me.btnNavBilling.Size = New System.Drawing.Size(203, 36)
        Me.btnNavBilling.TabIndex = 3
        Me.btnNavBilling.Text = "Billing"
        Me.btnNavBilling.UseVisualStyleBackColor = True
        '
        'btnNavMembership
        '
        Me.btnNavMembership.AutoSize = True
        Me.btnNavMembership.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.btnNavMembership.Depth = 0
        Me.btnNavMembership.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnNavMembership.Location = New System.Drawing.Point(8, 78)
        Me.btnNavMembership.Margin = New System.Windows.Forms.Padding(0)
        Me.btnNavMembership.MouseState = MaterialSkin.MouseState.HOVER
        Me.btnNavMembership.Name = "btnNavMembership"
        Me.btnNavMembership.Primary = False
        Me.btnNavMembership.Size = New System.Drawing.Size(203, 36)
        Me.btnNavMembership.TabIndex = 2
        Me.btnNavMembership.Text = "Membership"
        Me.btnNavMembership.UseVisualStyleBackColor = True
        '
        'btnNavMember
        '
        Me.btnNavMember.AutoSize = True
        Me.btnNavMember.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.btnNavMember.Depth = 0
        Me.btnNavMember.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnNavMember.Location = New System.Drawing.Point(8, 42)
        Me.btnNavMember.Margin = New System.Windows.Forms.Padding(0)
        Me.btnNavMember.MouseState = MaterialSkin.MouseState.HOVER
        Me.btnNavMember.Name = "btnNavMember"
        Me.btnNavMember.Primary = False
        Me.btnNavMember.Size = New System.Drawing.Size(203, 36)
        Me.btnNavMember.TabIndex = 1
        Me.btnNavMember.Text = "Member"
        Me.btnNavMember.UseVisualStyleBackColor = True
        '
        'btnNavUserAllList
        '
        Me.btnNavUserAllList.AutoSize = True
        Me.btnNavUserAllList.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.btnNavUserAllList.Depth = 0
        Me.btnNavUserAllList.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnNavUserAllList.Location = New System.Drawing.Point(8, 6)
        Me.btnNavUserAllList.Margin = New System.Windows.Forms.Padding(0)
        Me.btnNavUserAllList.MouseState = MaterialSkin.MouseState.HOVER
        Me.btnNavUserAllList.Name = "btnNavUserAllList"
        Me.btnNavUserAllList.Primary = True
        Me.btnNavUserAllList.Size = New System.Drawing.Size(203, 36)
        Me.btnNavUserAllList.TabIndex = 0
        Me.btnNavUserAllList.Text = "User All List"
        Me.btnNavUserAllList.UseVisualStyleBackColor = True
        '
        'pnlSidebarBottom
        '
        Me.pnlSidebarBottom.Controls.Add(Me.btnExit)
        Me.pnlSidebarBottom.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.pnlSidebarBottom.Location = New System.Drawing.Point(0, 718)
        Me.pnlSidebarBottom.Name = "pnlSidebarBottom"
        Me.pnlSidebarBottom.Padding = New System.Windows.Forms.Padding(10)
        Me.pnlSidebarBottom.Size = New System.Drawing.Size(219, 60)
        Me.pnlSidebarBottom.TabIndex = 2
        '
        'btnExit
        '
        Me.btnExit.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.btnExit.Depth = 0
        Me.btnExit.Dock = System.Windows.Forms.DockStyle.Fill
        Me.btnExit.Location = New System.Drawing.Point(10, 10)
        Me.btnExit.MouseState = MaterialSkin.MouseState.HOVER
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Primary = True
        Me.btnExit.Size = New System.Drawing.Size(199, 40)
        Me.btnExit.TabIndex = 0
        Me.btnExit.Text = "Exit App"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'pnlBrand
        '
        Me.pnlBrand.Controls.Add(Me.lblBrandTitle)
        Me.pnlBrand.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnlBrand.Location = New System.Drawing.Point(0, 0)
        Me.pnlBrand.Name = "pnlBrand"
        Me.pnlBrand.Padding = New System.Windows.Forms.Padding(12, 16, 12, 10)
        Me.pnlBrand.Size = New System.Drawing.Size(219, 56)
        Me.pnlBrand.TabIndex = 0
        '
        'lblBrandTitle
        '
        Me.lblBrandTitle.AutoSize = True
        Me.lblBrandTitle.Depth = 0
        Me.lblBrandTitle.Font = New System.Drawing.Font("Roboto", 11.0!)
        Me.lblBrandTitle.ForeColor = System.Drawing.Color.FromArgb(CType(CType(222, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.lblBrandTitle.Location = New System.Drawing.Point(12, 18)
        Me.lblBrandTitle.MouseState = MaterialSkin.MouseState.HOVER
        Me.lblBrandTitle.Name = "lblBrandTitle"
        Me.lblBrandTitle.Size = New System.Drawing.Size(157, 24)
        Me.lblBrandTitle.TabIndex = 0
        Me.lblBrandTitle.Text = "⚡ HL GYM CLUB"
        '
        'dividerSidebar
        '
        Me.dividerSidebar.BackColor = System.Drawing.Color.FromArgb(CType(CType(31, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.dividerSidebar.Depth = 0
        Me.dividerSidebar.Dock = System.Windows.Forms.DockStyle.Right
        Me.dividerSidebar.Location = New System.Drawing.Point(219, 0)
        Me.dividerSidebar.MouseState = MaterialSkin.MouseState.HOVER
        Me.dividerSidebar.Name = "dividerSidebar"
        Me.dividerSidebar.Size = New System.Drawing.Size(1, 778)
        Me.dividerSidebar.TabIndex = 3
        '
        'MainFrm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1200, 800)
        Me.Controls.Add(Me.pnlBody)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Name = "MainFrm"
        Me.Sizable = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "HL GYM - Management System"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.tabMain.ResumeLayout(False)
        Me.tabUserAllList.ResumeLayout(False)
        Me.tabMember.ResumeLayout(False)
        Me.tabMember.PerformLayout()
        Me.tabMembership.ResumeLayout(False)
        Me.tabMembership.PerformLayout()
        Me.tabBilling.ResumeLayout(False)
        Me.tabBilling.PerformLayout()
        Me.tabMembershipType.ResumeLayout(False)
        Me.tabMembershipType.PerformLayout()
        Me.tabSetting.ResumeLayout(False)
        Me.tabSetting.PerformLayout()
        Me.StatusStrip1.ResumeLayout(False)
        Me.StatusStrip1.PerformLayout()
        Me.pnlBody.ResumeLayout(False)
        Me.pnlSidebar.ResumeLayout(False)
        Me.pnlNavButtons.ResumeLayout(False)
        Me.pnlNavButtons.PerformLayout()
        Me.pnlSidebarBottom.ResumeLayout(False)
        Me.pnlBrand.ResumeLayout(False)
        Me.pnlBrand.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents tabMain As MaterialSkin.Controls.MaterialTabControl
    Friend WithEvents tabUserAllList As System.Windows.Forms.TabPage
    Friend WithEvents tabMember As System.Windows.Forms.TabPage
    Friend WithEvents tabMembership As System.Windows.Forms.TabPage
    Friend WithEvents tabBilling As System.Windows.Forms.TabPage
    Friend WithEvents tabMembershipType As System.Windows.Forms.TabPage
    Friend WithEvents tabSetting As System.Windows.Forms.TabPage
    Friend WithEvents pnlBody As System.Windows.Forms.Panel
    Friend WithEvents pnlSidebar As System.Windows.Forms.Panel
    Friend WithEvents pnlBrand As System.Windows.Forms.Panel
    Friend WithEvents lblBrandTitle As MaterialSkin.Controls.MaterialLabel
    Friend WithEvents pnlNavButtons As System.Windows.Forms.Panel
    Friend WithEvents btnNavUserAllList As MaterialSkin.Controls.MaterialFlatButton
    Friend WithEvents btnNavMember As MaterialSkin.Controls.MaterialFlatButton
    Friend WithEvents btnNavMembership As MaterialSkin.Controls.MaterialFlatButton
    Friend WithEvents btnNavBilling As MaterialSkin.Controls.MaterialFlatButton
    Friend WithEvents btnNavMembershipType As MaterialSkin.Controls.MaterialFlatButton
    Friend WithEvents btnNavSetting As MaterialSkin.Controls.MaterialFlatButton
    Friend WithEvents pnlSidebarBottom As System.Windows.Forms.Panel
    Friend WithEvents btnExit As MaterialSkin.Controls.MaterialRaisedButton
    Friend WithEvents dividerSidebar As MaterialSkin.Controls.MaterialDivider
    Friend WithEvents pnlUserListContainer As System.Windows.Forms.Panel
    Friend WithEvents lblMemberInfo As MaterialSkin.Controls.MaterialLabel
    Friend WithEvents lblMembershipInfo As MaterialSkin.Controls.MaterialLabel
    Friend WithEvents lblBillingInfo As MaterialSkin.Controls.MaterialLabel
    Friend WithEvents lblMembershipTypeInfo As MaterialSkin.Controls.MaterialLabel
    Friend WithEvents lblSettingInfo As MaterialSkin.Controls.MaterialLabel
    Friend WithEvents StatusStrip1 As StatusStrip
    Friend WithEvents lbDateTime As ToolStripStatusLabel
    Friend WithEvents lbDbStatus As ToolStripStatusLabel
End Class
