<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frm_UserAllList
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
        Me.components = New System.ComponentModel.Container()
        Dim DataGridViewCellStyle7 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle8 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle9 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.pnlTableCard = New System.Windows.Forms.Panel()
        Me.dgvUserList = New System.Windows.Forms.DataGridView()
        Me.UserID = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Username = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PasswordHash = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FullName = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Role = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Gambar = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.IsActive = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.IsDelete = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ContextMenuStrip1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.TambahUserToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.EditUserToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.HapusUserToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.pnlSearchHeader = New System.Windows.Forms.Panel()
        Me.pnlTitleContainer = New System.Windows.Forms.Panel()
        Me.lblTitle = New System.Windows.Forms.Label()
        Me.lblTotalUsers = New System.Windows.Forms.Label()
        Me.pnlSearchAction = New System.Windows.Forms.Panel()
        Me.lblSearch = New System.Windows.Forms.Label()
        Me.txtSearch = New System.Windows.Forms.TextBox()
        Me.btnClearSearch = New System.Windows.Forms.Button()
        Me.pnlTableCard.SuspendLayout()
        CType(Me.dgvUserList, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ContextMenuStrip1.SuspendLayout()
        Me.pnlSearchHeader.SuspendLayout()
        Me.pnlTitleContainer.SuspendLayout()
        Me.pnlSearchAction.SuspendLayout()
        Me.SuspendLayout()
        '
        'pnlTableCard
        '
        Me.pnlTableCard.BackColor = System.Drawing.Color.White
        Me.pnlTableCard.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pnlTableCard.Controls.Add(Me.dgvUserList)
        Me.pnlTableCard.Controls.Add(Me.pnlSearchHeader)
        Me.pnlTableCard.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnlTableCard.Location = New System.Drawing.Point(24, 24)
        Me.pnlTableCard.Name = "pnlTableCard"
        Me.pnlTableCard.Padding = New System.Windows.Forms.Padding(12)
        Me.pnlTableCard.Size = New System.Drawing.Size(752, 402)
        Me.pnlTableCard.TabIndex = 0
        '
        'dgvUserList
        '
        Me.dgvUserList.AllowUserToAddRows = False
        Me.dgvUserList.AllowUserToDeleteRows = False
        Me.dgvUserList.AllowUserToResizeRows = False
        DataGridViewCellStyle7.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        DataGridViewCellStyle7.ForeColor = System.Drawing.Color.FromArgb(CType(CType(15, Byte), Integer), CType(CType(23, Byte), Integer), CType(CType(42, Byte), Integer))
        DataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(37, Byte), Integer), CType(CType(99, Byte), Integer), CType(CType(235, Byte), Integer))
        DataGridViewCellStyle7.SelectionForeColor = System.Drawing.Color.White
        Me.dgvUserList.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle7
        Me.dgvUserList.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvUserList.BackgroundColor = System.Drawing.Color.WhiteSmoke
        Me.dgvUserList.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.dgvUserList.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        Me.dgvUserList.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle8.BackColor = System.Drawing.Color.DodgerBlue
        DataGridViewCellStyle8.Font = New System.Drawing.Font("Segoe UI Semibold", 9.5!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle8.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.DodgerBlue
        DataGridViewCellStyle8.SelectionForeColor = System.Drawing.Color.White
        DataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvUserList.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle8
        Me.dgvUserList.ColumnHeadersHeight = 44
        Me.dgvUserList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.dgvUserList.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.UserID, Me.Username, Me.PasswordHash, Me.FullName, Me.Role, Me.Gambar, Me.IsActive, Me.IsDelete})
        Me.dgvUserList.ContextMenuStrip = Me.ContextMenuStrip1
        DataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle9.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle9.Font = New System.Drawing.Font("Segoe UI", 9.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle9.ForeColor = System.Drawing.Color.FromArgb(CType(CType(15, Byte), Integer), CType(CType(23, Byte), Integer), CType(CType(42, Byte), Integer))
        DataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(37, Byte), Integer), CType(CType(99, Byte), Integer), CType(CType(235, Byte), Integer))
        DataGridViewCellStyle9.SelectionForeColor = System.Drawing.Color.White
        DataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvUserList.DefaultCellStyle = DataGridViewCellStyle9
        Me.dgvUserList.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgvUserList.EnableHeadersVisualStyles = False
        Me.dgvUserList.GridColor = System.Drawing.Color.FromArgb(CType(CType(241, Byte), Integer), CType(CType(245, Byte), Integer), CType(CType(249, Byte), Integer))
        Me.dgvUserList.Location = New System.Drawing.Point(12, 58)
        Me.dgvUserList.MultiSelect = False
        Me.dgvUserList.Name = "dgvUserList"
        Me.dgvUserList.ReadOnly = True
        Me.dgvUserList.RowHeadersVisible = False
        Me.dgvUserList.RowHeadersWidth = 51
        Me.dgvUserList.RowTemplate.Height = 40
        Me.dgvUserList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvUserList.Size = New System.Drawing.Size(726, 330)
        Me.dgvUserList.TabIndex = 0
        '
        'UserID
        '
        Me.UserID.DataPropertyName = "UserID"
        Me.UserID.HeaderText = "ID"
        Me.UserID.MinimumWidth = 6
        Me.UserID.Name = "UserID"
        Me.UserID.ReadOnly = True
        '
        'Username
        '
        Me.Username.DataPropertyName = "Username"
        Me.Username.HeaderText = "Nama"
        Me.Username.MinimumWidth = 6
        Me.Username.Name = "Username"
        Me.Username.ReadOnly = True
        '
        'PasswordHash
        '
        Me.PasswordHash.HeaderText = "Password"
        Me.PasswordHash.MinimumWidth = 6
        Me.PasswordHash.Name = "PasswordHash"
        Me.PasswordHash.ReadOnly = True
        Me.PasswordHash.Visible = False
        '
        'FullName
        '
        Me.FullName.DataPropertyName = "FullName"
        Me.FullName.HeaderText = "Nama Panjang"
        Me.FullName.MinimumWidth = 6
        Me.FullName.Name = "FullName"
        Me.FullName.ReadOnly = True
        '
        'Role
        '
        Me.Role.DataPropertyName = "Role"
        Me.Role.HeaderText = "Role"
        Me.Role.MinimumWidth = 6
        Me.Role.Name = "Role"
        Me.Role.ReadOnly = True
        '
        'Gambar
        '
        Me.Gambar.HeaderText = "Profile"
        Me.Gambar.MinimumWidth = 6
        Me.Gambar.Name = "Gambar"
        Me.Gambar.ReadOnly = True
        Me.Gambar.Visible = False
        '
        'IsActive
        '
        Me.IsActive.DataPropertyName = "IsActive"
        Me.IsActive.HeaderText = "Status"
        Me.IsActive.MinimumWidth = 6
        Me.IsActive.Name = "IsActive"
        Me.IsActive.ReadOnly = True
        '
        'IsDelete
        '
        Me.IsDelete.HeaderText = "Delete"
        Me.IsDelete.MinimumWidth = 6
        Me.IsDelete.Name = "IsDelete"
        Me.IsDelete.ReadOnly = True
        Me.IsDelete.Visible = False
        '
        'ContextMenuStrip1
        '
        Me.ContextMenuStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.ContextMenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.TambahUserToolStripMenuItem, Me.ToolStripSeparator1, Me.EditUserToolStripMenuItem, Me.ToolStripSeparator2, Me.HapusUserToolStripMenuItem})
        Me.ContextMenuStrip1.Name = "ContextMenuStrip1"
        Me.ContextMenuStrip1.Size = New System.Drawing.Size(164, 88)
        '
        'TambahUserToolStripMenuItem
        '
        Me.TambahUserToolStripMenuItem.Name = "TambahUserToolStripMenuItem"
        Me.TambahUserToolStripMenuItem.Size = New System.Drawing.Size(163, 24)
        Me.TambahUserToolStripMenuItem.Text = "Tambah User"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(160, 6)
        '
        'EditUserToolStripMenuItem
        '
        Me.EditUserToolStripMenuItem.Name = "EditUserToolStripMenuItem"
        Me.EditUserToolStripMenuItem.Size = New System.Drawing.Size(163, 24)
        Me.EditUserToolStripMenuItem.Text = "Edit User"
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(160, 6)
        '
        'HapusUserToolStripMenuItem
        '
        Me.HapusUserToolStripMenuItem.Name = "HapusUserToolStripMenuItem"
        Me.HapusUserToolStripMenuItem.Size = New System.Drawing.Size(163, 24)
        Me.HapusUserToolStripMenuItem.Text = "Hapus User"
        '
        'pnlSearchHeader
        '
        Me.pnlSearchHeader.BackColor = System.Drawing.Color.White
        Me.pnlSearchHeader.Controls.Add(Me.pnlTitleContainer)
        Me.pnlSearchHeader.Controls.Add(Me.pnlSearchAction)
        Me.pnlSearchHeader.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnlSearchHeader.Location = New System.Drawing.Point(12, 12)
        Me.pnlSearchHeader.Name = "pnlSearchHeader"
        Me.pnlSearchHeader.Padding = New System.Windows.Forms.Padding(0, 0, 0, 8)
        Me.pnlSearchHeader.Size = New System.Drawing.Size(726, 46)
        Me.pnlSearchHeader.TabIndex = 1
        '
        'pnlTitleContainer
        '
        Me.pnlTitleContainer.AutoSize = True
        Me.pnlTitleContainer.BackColor = System.Drawing.Color.White
        Me.pnlTitleContainer.Controls.Add(Me.lblTitle)
        Me.pnlTitleContainer.Controls.Add(Me.lblTotalUsers)
        Me.pnlTitleContainer.Dock = System.Windows.Forms.DockStyle.Left
        Me.pnlTitleContainer.Location = New System.Drawing.Point(0, 0)
        Me.pnlTitleContainer.Name = "pnlTitleContainer"
        Me.pnlTitleContainer.Size = New System.Drawing.Size(221, 38)
        Me.pnlTitleContainer.TabIndex = 0
        '
        'lblTitle
        '
        Me.lblTitle.AutoSize = True
        Me.lblTitle.Font = New System.Drawing.Font("Segoe UI Semibold", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitle.ForeColor = System.Drawing.Color.FromArgb(CType(CType(15, Byte), Integer), CType(CType(23, Byte), Integer), CType(CType(42, Byte), Integer))
        Me.lblTitle.Location = New System.Drawing.Point(0, 8)
        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.Size = New System.Drawing.Size(157, 25)
        Me.lblTitle.TabIndex = 0
        Me.lblTitle.Text = "Daftar Pengguna"
        '
        'lblTotalUsers
        '
        Me.lblTotalUsers.AutoSize = True
        Me.lblTotalUsers.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTotalUsers.ForeColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(116, Byte), Integer), CType(CType(139, Byte), Integer))
        Me.lblTotalUsers.Location = New System.Drawing.Point(160, 12)
        Me.lblTotalUsers.Name = "lblTotalUsers"
        Me.lblTotalUsers.Size = New System.Drawing.Size(58, 20)
        Me.lblTotalUsers.TabIndex = 1
        Me.lblTotalUsers.Text = "(0 user)"
        '
        'pnlSearchAction
        '
        Me.pnlSearchAction.BackColor = System.Drawing.Color.White
        Me.pnlSearchAction.Controls.Add(Me.lblSearch)
        Me.pnlSearchAction.Controls.Add(Me.txtSearch)
        Me.pnlSearchAction.Controls.Add(Me.btnClearSearch)
        Me.pnlSearchAction.Dock = System.Windows.Forms.DockStyle.Right
        Me.pnlSearchAction.Location = New System.Drawing.Point(346, 0)
        Me.pnlSearchAction.Name = "pnlSearchAction"
        Me.pnlSearchAction.Size = New System.Drawing.Size(380, 38)
        Me.pnlSearchAction.TabIndex = 1
        '
        'lblSearch
        '
        Me.lblSearch.AutoSize = True
        Me.lblSearch.Font = New System.Drawing.Font("Segoe UI", 9.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSearch.ForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(85, Byte), Integer), CType(CType(105, Byte), Integer))
        Me.lblSearch.Location = New System.Drawing.Point(6, 8)
        Me.lblSearch.Name = "lblSearch"
        Me.lblSearch.Size = New System.Drawing.Size(87, 21)
        Me.lblSearch.TabIndex = 0
        Me.lblSearch.Text = "Cari Nama:"
        '
        'txtSearch
        '
        Me.txtSearch.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtSearch.Font = New System.Drawing.Font("Segoe UI", 9.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSearch.Location = New System.Drawing.Point(96, 5)
        Me.txtSearch.Name = "txtSearch"
        Me.txtSearch.Size = New System.Drawing.Size(206, 29)
        Me.txtSearch.TabIndex = 1
        '
        'btnClearSearch
        '
        Me.btnClearSearch.BackColor = System.Drawing.Color.FromArgb(CType(CType(241, Byte), Integer), CType(CType(245, Byte), Integer), CType(CType(249, Byte), Integer))
        Me.btnClearSearch.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnClearSearch.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(203, Byte), Integer), CType(CType(213, Byte), Integer), CType(CType(225, Byte), Integer))
        Me.btnClearSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnClearSearch.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClearSearch.ForeColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(65, Byte), Integer), CType(CType(85, Byte), Integer))
        Me.btnClearSearch.Location = New System.Drawing.Point(308, 5)
        Me.btnClearSearch.Name = "btnClearSearch"
        Me.btnClearSearch.Size = New System.Drawing.Size(66, 29)
        Me.btnClearSearch.TabIndex = 2
        Me.btnClearSearch.Text = "Reset"
        Me.btnClearSearch.UseVisualStyleBackColor = False
        '
        'frm_UserAllList
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(120.0!, 120.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(248, Byte), Integer), CType(CType(250, Byte), Integer), CType(CType(252, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.ControlBox = False
        Me.Controls.Add(Me.pnlTableCard)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frm_UserAllList"
        Me.Padding = New System.Windows.Forms.Padding(24)
        Me.Text = "Users"
        Me.pnlTableCard.ResumeLayout(False)
        CType(Me.dgvUserList, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ContextMenuStrip1.ResumeLayout(False)
        Me.pnlSearchHeader.ResumeLayout(False)
        Me.pnlSearchHeader.PerformLayout()
        Me.pnlTitleContainer.ResumeLayout(False)
        Me.pnlTitleContainer.PerformLayout()
        Me.pnlSearchAction.ResumeLayout(False)
        Me.pnlSearchAction.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents pnlTableCard As System.Windows.Forms.Panel
    Friend WithEvents pnlSearchHeader As System.Windows.Forms.Panel
    Friend WithEvents pnlTitleContainer As System.Windows.Forms.Panel
    Friend WithEvents lblTitle As System.Windows.Forms.Label
    Friend WithEvents lblTotalUsers As System.Windows.Forms.Label
    Friend WithEvents pnlSearchAction As System.Windows.Forms.Panel
    Friend WithEvents lblSearch As System.Windows.Forms.Label
    Friend WithEvents txtSearch As System.Windows.Forms.TextBox
    Friend WithEvents btnClearSearch As System.Windows.Forms.Button
    Friend WithEvents dgvUserList As System.Windows.Forms.DataGridView
    Friend WithEvents ContextMenuStrip1 As ContextMenuStrip
    Friend WithEvents TambahUserToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToolStripSeparator1 As ToolStripSeparator
    Friend WithEvents EditUserToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToolStripSeparator2 As ToolStripSeparator
    Friend WithEvents HapusUserToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents UserID As DataGridViewTextBoxColumn
    Friend WithEvents Username As DataGridViewTextBoxColumn
    Friend WithEvents PasswordHash As DataGridViewTextBoxColumn
    Friend WithEvents FullName As DataGridViewTextBoxColumn
    Friend WithEvents Role As DataGridViewTextBoxColumn
    Friend WithEvents Gambar As DataGridViewTextBoxColumn
    Friend WithEvents IsActive As DataGridViewTextBoxColumn
    Friend WithEvents IsDelete As DataGridViewTextBoxColumn
End Class
