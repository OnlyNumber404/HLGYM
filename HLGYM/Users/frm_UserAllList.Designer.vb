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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.pnlTableCard = New System.Windows.Forms.Panel()
        Me.dgvUserList = New System.Windows.Forms.DataGridView()
        Me.UserID = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Username = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PasswordHash = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FullName = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Role = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.IsActive = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.IsDelete = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ContextMenuStrip1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.TambahUserToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.EditUserToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.HapusUserToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.pnlTableCard.SuspendLayout()
        CType(Me.dgvUserList, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ContextMenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'pnlTableCard
        '
        Me.pnlTableCard.BackColor = System.Drawing.Color.White
        Me.pnlTableCard.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pnlTableCard.Controls.Add(Me.dgvUserList)
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
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(15, Byte), Integer), CType(CType(23, Byte), Integer), CType(CType(42, Byte), Integer))
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(37, Byte), Integer), CType(CType(99, Byte), Integer), CType(CType(235, Byte), Integer))
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White
        Me.dgvUserList.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.dgvUserList.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvUserList.BackgroundColor = System.Drawing.Color.WhiteSmoke
        Me.dgvUserList.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.dgvUserList.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        Me.dgvUserList.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.DodgerBlue
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Segoe UI Semibold", 9.5!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.DodgerBlue
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvUserList.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.dgvUserList.ColumnHeadersHeight = 44
        Me.dgvUserList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.dgvUserList.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.UserID, Me.Username, Me.PasswordHash, Me.FullName, Me.Role, Me.IsActive, Me.IsDelete})
        Me.dgvUserList.ContextMenuStrip = Me.ContextMenuStrip1
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Segoe UI", 9.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(15, Byte), Integer), CType(CType(23, Byte), Integer), CType(CType(42, Byte), Integer))
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(37, Byte), Integer), CType(CType(99, Byte), Integer), CType(CType(235, Byte), Integer))
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvUserList.DefaultCellStyle = DataGridViewCellStyle3
        Me.dgvUserList.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgvUserList.EnableHeadersVisualStyles = False
        Me.dgvUserList.GridColor = System.Drawing.Color.FromArgb(CType(CType(241, Byte), Integer), CType(CType(245, Byte), Integer), CType(CType(249, Byte), Integer))
        Me.dgvUserList.Location = New System.Drawing.Point(12, 12)
        Me.dgvUserList.MultiSelect = False
        Me.dgvUserList.Name = "dgvUserList"
        Me.dgvUserList.ReadOnly = True
        Me.dgvUserList.RowHeadersVisible = False
        Me.dgvUserList.RowHeadersWidth = 51
        Me.dgvUserList.RowTemplate.Height = 40
        Me.dgvUserList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvUserList.Size = New System.Drawing.Size(726, 376)
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
        Me.PasswordHash.DataPropertyName = "PasswordHash"
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
        Me.IsDelete.DataPropertyName = "IsDelete"
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
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents pnlTableCard As System.Windows.Forms.Panel
    Friend WithEvents dgvUserList As System.Windows.Forms.DataGridView
    Friend WithEvents UserID As DataGridViewTextBoxColumn
    Friend WithEvents Username As DataGridViewTextBoxColumn
    Friend WithEvents PasswordHash As DataGridViewTextBoxColumn
    Friend WithEvents FullName As DataGridViewTextBoxColumn
    Friend WithEvents Role As DataGridViewTextBoxColumn
    Friend WithEvents IsActive As DataGridViewTextBoxColumn
    Friend WithEvents IsDelete As DataGridViewTextBoxColumn
    Friend WithEvents ContextMenuStrip1 As ContextMenuStrip
    Friend WithEvents TambahUserToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToolStripSeparator1 As ToolStripSeparator
    Friend WithEvents EditUserToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToolStripSeparator2 As ToolStripSeparator
    Friend WithEvents HapusUserToolStripMenuItem As ToolStripMenuItem
End Class
