<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMain
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmMain))
        Me.SplitContainer1 = New System.Windows.Forms.SplitContainer()
        Me.panelLeft = New System.Windows.Forms.Panel()
        Me.SplitContainer2 = New System.Windows.Forms.SplitContainer()
        Me.topLeftPanel = New System.Windows.Forms.Panel()
        Me.dgwGroups = New System.Windows.Forms.DataGridView()
        Me.GroupIdDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GroupNameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colEdit = New System.Windows.Forms.DataGridViewButtonColumn()
        Me.colDelete = New System.Windows.Forms.DataGridViewButtonColumn()
        Me.GroupsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.GroupsAndServersData = New TSRemoteControl.dsetGroupsAndServers()
        Me.tlTopPanel = New System.Windows.Forms.Panel()
        Me.lblGroups = New System.Windows.Forms.Label()
        Me.btnAddGroup = New System.Windows.Forms.Button()
        Me.bottomLeftPanel = New System.Windows.Forms.Panel()
        Me.dgwServers = New System.Windows.Forms.DataGridView()
        Me.GroupIdDataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ServerIdDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ServerNameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ServerDisplayNameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colServerEdit = New System.Windows.Forms.DataGridViewButtonColumn()
        Me.colServerDelete = New System.Windows.Forms.DataGridViewButtonColumn()
        Me.bindingServersByGroup = New System.Windows.Forms.BindingSource(Me.components)
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.lblDetailTS = New System.Windows.Forms.Label()
        Me.btnAddServer = New System.Windows.Forms.Button()
        Me.panelRight = New System.Windows.Forms.Panel()
        Me.dgwUsers = New System.Windows.Forms.DataGridView()
        Me.panelRightTop = New System.Windows.Forms.Panel()
        Me.lblUsersPerServer = New System.Windows.Forms.Label()
        Me.btnRefresh = New System.Windows.Forms.Button()
        Me.listUsers = New System.Windows.Forms.ListView()
        Me.toolTipsManager = New System.Windows.Forms.ToolTip(Me.components)
        Me.timerUserRefresh = New System.Windows.Forms.Timer(Me.components)
        Me.UsersData = New TSRemoteControl.dsetUsers()
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.Panel2.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        Me.panelLeft.SuspendLayout()
        CType(Me.SplitContainer2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer2.Panel1.SuspendLayout()
        Me.SplitContainer2.Panel2.SuspendLayout()
        Me.SplitContainer2.SuspendLayout()
        Me.topLeftPanel.SuspendLayout()
        CType(Me.dgwGroups, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GroupsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GroupsAndServersData, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tlTopPanel.SuspendLayout()
        Me.bottomLeftPanel.SuspendLayout()
        CType(Me.dgwServers, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.bindingServersByGroup, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.panelRight.SuspendLayout()
        CType(Me.dgwUsers, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.panelRightTop.SuspendLayout()
        CType(Me.UsersData, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'SplitContainer1
        '
        Me.SplitContainer1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer1.Location = New System.Drawing.Point(0, 0)
        Me.SplitContainer1.Name = "SplitContainer1"
        '
        'SplitContainer1.Panel1
        '
        Me.SplitContainer1.Panel1.Controls.Add(Me.panelLeft)
        '
        'SplitContainer1.Panel2
        '
        Me.SplitContainer1.Panel2.Controls.Add(Me.panelRight)
        Me.SplitContainer1.Size = New System.Drawing.Size(1008, 730)
        Me.SplitContainer1.SplitterDistance = 336
        Me.SplitContainer1.TabIndex = 0
        '
        'panelLeft
        '
        Me.panelLeft.Controls.Add(Me.SplitContainer2)
        Me.panelLeft.Dock = System.Windows.Forms.DockStyle.Fill
        Me.panelLeft.Location = New System.Drawing.Point(0, 0)
        Me.panelLeft.Name = "panelLeft"
        Me.panelLeft.Size = New System.Drawing.Size(336, 730)
        Me.panelLeft.TabIndex = 0
        '
        'SplitContainer2
        '
        Me.SplitContainer2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer2.Location = New System.Drawing.Point(0, 0)
        Me.SplitContainer2.Name = "SplitContainer2"
        Me.SplitContainer2.Orientation = System.Windows.Forms.Orientation.Horizontal
        '
        'SplitContainer2.Panel1
        '
        Me.SplitContainer2.Panel1.Controls.Add(Me.topLeftPanel)
        '
        'SplitContainer2.Panel2
        '
        Me.SplitContainer2.Panel2.Controls.Add(Me.bottomLeftPanel)
        Me.SplitContainer2.Size = New System.Drawing.Size(336, 730)
        Me.SplitContainer2.SplitterDistance = 168
        Me.SplitContainer2.TabIndex = 0
        '
        'topLeftPanel
        '
        Me.topLeftPanel.Controls.Add(Me.dgwGroups)
        Me.topLeftPanel.Controls.Add(Me.tlTopPanel)
        Me.topLeftPanel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.topLeftPanel.Location = New System.Drawing.Point(0, 0)
        Me.topLeftPanel.Name = "topLeftPanel"
        Me.topLeftPanel.Size = New System.Drawing.Size(336, 168)
        Me.topLeftPanel.TabIndex = 0
        '
        'dgwGroups
        '
        Me.dgwGroups.AllowUserToAddRows = False
        Me.dgwGroups.AllowUserToDeleteRows = False
        Me.dgwGroups.AllowUserToResizeColumns = False
        Me.dgwGroups.AllowUserToResizeRows = False
        Me.dgwGroups.AutoGenerateColumns = False
        Me.dgwGroups.BackgroundColor = System.Drawing.Color.White
        Me.dgwGroups.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgwGroups.ColumnHeadersVisible = False
        Me.dgwGroups.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.GroupIdDataGridViewTextBoxColumn, Me.GroupNameDataGridViewTextBoxColumn, Me.colEdit, Me.colDelete})
        Me.dgwGroups.DataSource = Me.GroupsBindingSource
        Me.dgwGroups.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgwGroups.GridColor = System.Drawing.Color.White
        Me.dgwGroups.Location = New System.Drawing.Point(0, 32)
        Me.dgwGroups.MultiSelect = False
        Me.dgwGroups.Name = "dgwGroups"
        Me.dgwGroups.ReadOnly = True
        Me.dgwGroups.Size = New System.Drawing.Size(336, 136)
        Me.dgwGroups.TabIndex = 2
        '
        'GroupIdDataGridViewTextBoxColumn
        '
        Me.GroupIdDataGridViewTextBoxColumn.DataPropertyName = "groupId"
        Me.GroupIdDataGridViewTextBoxColumn.HeaderText = "groupId"
        Me.GroupIdDataGridViewTextBoxColumn.Name = "GroupIdDataGridViewTextBoxColumn"
        Me.GroupIdDataGridViewTextBoxColumn.ReadOnly = True
        Me.GroupIdDataGridViewTextBoxColumn.Visible = False
        '
        'GroupNameDataGridViewTextBoxColumn
        '
        Me.GroupNameDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.GroupNameDataGridViewTextBoxColumn.DataPropertyName = "groupName"
        Me.GroupNameDataGridViewTextBoxColumn.HeaderText = "Configured groups"
        Me.GroupNameDataGridViewTextBoxColumn.Name = "GroupNameDataGridViewTextBoxColumn"
        Me.GroupNameDataGridViewTextBoxColumn.ReadOnly = True
        '
        'colEdit
        '
        Me.colEdit.HeaderText = ""
        Me.colEdit.Name = "colEdit"
        Me.colEdit.ReadOnly = True
        Me.colEdit.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.colEdit.Text = ""
        Me.colEdit.ToolTipText = "Edit group"
        Me.colEdit.Width = 32
        '
        'colDelete
        '
        Me.colDelete.HeaderText = ""
        Me.colDelete.Name = "colDelete"
        Me.colDelete.ReadOnly = True
        Me.colDelete.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.colDelete.Text = ""
        Me.colDelete.ToolTipText = "Delete group"
        Me.colDelete.Width = 32
        '
        'GroupsBindingSource
        '
        Me.GroupsBindingSource.DataMember = "groups"
        Me.GroupsBindingSource.DataSource = Me.GroupsAndServersData
        Me.GroupsBindingSource.Sort = "groupName"
        '
        'GroupsAndServersData
        '
        Me.GroupsAndServersData.DataSetName = "dsetGroupsAndServers"
        Me.GroupsAndServersData.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'tlTopPanel
        '
        Me.tlTopPanel.Controls.Add(Me.lblGroups)
        Me.tlTopPanel.Controls.Add(Me.btnAddGroup)
        Me.tlTopPanel.Dock = System.Windows.Forms.DockStyle.Top
        Me.tlTopPanel.Location = New System.Drawing.Point(0, 0)
        Me.tlTopPanel.Name = "tlTopPanel"
        Me.tlTopPanel.Size = New System.Drawing.Size(336, 32)
        Me.tlTopPanel.TabIndex = 3
        '
        'lblGroups
        '
        Me.lblGroups.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblGroups.Location = New System.Drawing.Point(0, 0)
        Me.lblGroups.Name = "lblGroups"
        Me.lblGroups.Size = New System.Drawing.Size(304, 32)
        Me.lblGroups.TabIndex = 2
        Me.lblGroups.Text = "Groups of Terminal Servers"
        Me.lblGroups.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'btnAddGroup
        '
        Me.btnAddGroup.BackgroundImage = Global.TSRemoteControl.My.Resources.Resources.add32
        Me.btnAddGroup.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnAddGroup.Dock = System.Windows.Forms.DockStyle.Right
        Me.btnAddGroup.Location = New System.Drawing.Point(304, 0)
        Me.btnAddGroup.Name = "btnAddGroup"
        Me.btnAddGroup.Size = New System.Drawing.Size(32, 32)
        Me.btnAddGroup.TabIndex = 3
        Me.toolTipsManager.SetToolTip(Me.btnAddGroup, "Add a new group")
        Me.btnAddGroup.UseVisualStyleBackColor = True
        '
        'bottomLeftPanel
        '
        Me.bottomLeftPanel.Controls.Add(Me.dgwServers)
        Me.bottomLeftPanel.Controls.Add(Me.Panel1)
        Me.bottomLeftPanel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.bottomLeftPanel.Location = New System.Drawing.Point(0, 0)
        Me.bottomLeftPanel.Name = "bottomLeftPanel"
        Me.bottomLeftPanel.Size = New System.Drawing.Size(336, 558)
        Me.bottomLeftPanel.TabIndex = 0
        '
        'dgwServers
        '
        Me.dgwServers.AllowUserToAddRows = False
        Me.dgwServers.AllowUserToDeleteRows = False
        Me.dgwServers.AutoGenerateColumns = False
        Me.dgwServers.BackgroundColor = System.Drawing.Color.White
        Me.dgwServers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgwServers.ColumnHeadersVisible = False
        Me.dgwServers.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.GroupIdDataGridViewTextBoxColumn1, Me.ServerIdDataGridViewTextBoxColumn, Me.ServerNameDataGridViewTextBoxColumn, Me.ServerDisplayNameDataGridViewTextBoxColumn, Me.colServerEdit, Me.colServerDelete})
        Me.dgwServers.DataSource = Me.bindingServersByGroup
        Me.dgwServers.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgwServers.Location = New System.Drawing.Point(0, 32)
        Me.dgwServers.MultiSelect = False
        Me.dgwServers.Name = "dgwServers"
        Me.dgwServers.ReadOnly = True
        Me.dgwServers.Size = New System.Drawing.Size(336, 526)
        Me.dgwServers.TabIndex = 4
        '
        'GroupIdDataGridViewTextBoxColumn1
        '
        Me.GroupIdDataGridViewTextBoxColumn1.DataPropertyName = "groupId"
        Me.GroupIdDataGridViewTextBoxColumn1.HeaderText = "groupId"
        Me.GroupIdDataGridViewTextBoxColumn1.Name = "GroupIdDataGridViewTextBoxColumn1"
        Me.GroupIdDataGridViewTextBoxColumn1.ReadOnly = True
        Me.GroupIdDataGridViewTextBoxColumn1.Visible = False
        '
        'ServerIdDataGridViewTextBoxColumn
        '
        Me.ServerIdDataGridViewTextBoxColumn.DataPropertyName = "serverId"
        Me.ServerIdDataGridViewTextBoxColumn.HeaderText = "serverId"
        Me.ServerIdDataGridViewTextBoxColumn.Name = "ServerIdDataGridViewTextBoxColumn"
        Me.ServerIdDataGridViewTextBoxColumn.ReadOnly = True
        Me.ServerIdDataGridViewTextBoxColumn.Visible = False
        '
        'ServerNameDataGridViewTextBoxColumn
        '
        Me.ServerNameDataGridViewTextBoxColumn.DataPropertyName = "serverName"
        Me.ServerNameDataGridViewTextBoxColumn.HeaderText = "serverName"
        Me.ServerNameDataGridViewTextBoxColumn.Name = "ServerNameDataGridViewTextBoxColumn"
        Me.ServerNameDataGridViewTextBoxColumn.ReadOnly = True
        Me.ServerNameDataGridViewTextBoxColumn.Visible = False
        '
        'ServerDisplayNameDataGridViewTextBoxColumn
        '
        Me.ServerDisplayNameDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.ServerDisplayNameDataGridViewTextBoxColumn.DataPropertyName = "serverDisplayName"
        Me.ServerDisplayNameDataGridViewTextBoxColumn.HeaderText = "serverDisplayName"
        Me.ServerDisplayNameDataGridViewTextBoxColumn.Name = "ServerDisplayNameDataGridViewTextBoxColumn"
        Me.ServerDisplayNameDataGridViewTextBoxColumn.ReadOnly = True
        '
        'colServerEdit
        '
        Me.colServerEdit.HeaderText = ""
        Me.colServerEdit.Name = "colServerEdit"
        Me.colServerEdit.ReadOnly = True
        Me.colServerEdit.Width = 32
        '
        'colServerDelete
        '
        Me.colServerDelete.HeaderText = ""
        Me.colServerDelete.Name = "colServerDelete"
        Me.colServerDelete.ReadOnly = True
        Me.colServerDelete.Width = 32
        '
        'bindingServersByGroup
        '
        Me.bindingServersByGroup.DataMember = "servers"
        Me.bindingServersByGroup.DataSource = Me.GroupsAndServersData
        Me.bindingServersByGroup.Sort = "serverDisplayName"
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.lblDetailTS)
        Me.Panel1.Controls.Add(Me.btnAddServer)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(336, 32)
        Me.Panel1.TabIndex = 5
        '
        'lblDetailTS
        '
        Me.lblDetailTS.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblDetailTS.Location = New System.Drawing.Point(0, 0)
        Me.lblDetailTS.Name = "lblDetailTS"
        Me.lblDetailTS.Size = New System.Drawing.Size(304, 32)
        Me.lblDetailTS.TabIndex = 4
        Me.lblDetailTS.Text = "Individual Servers in the group"
        Me.lblDetailTS.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'btnAddServer
        '
        Me.btnAddServer.BackgroundImage = Global.TSRemoteControl.My.Resources.Resources.add32
        Me.btnAddServer.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnAddServer.Dock = System.Windows.Forms.DockStyle.Right
        Me.btnAddServer.Location = New System.Drawing.Point(304, 0)
        Me.btnAddServer.Name = "btnAddServer"
        Me.btnAddServer.Size = New System.Drawing.Size(32, 32)
        Me.btnAddServer.TabIndex = 3
        Me.toolTipsManager.SetToolTip(Me.btnAddServer, "Add a new group")
        Me.btnAddServer.UseVisualStyleBackColor = True
        '
        'panelRight
        '
        Me.panelRight.Controls.Add(Me.dgwUsers)
        Me.panelRight.Controls.Add(Me.panelRightTop)
        Me.panelRight.Controls.Add(Me.listUsers)
        Me.panelRight.Dock = System.Windows.Forms.DockStyle.Fill
        Me.panelRight.Location = New System.Drawing.Point(0, 0)
        Me.panelRight.Name = "panelRight"
        Me.panelRight.Size = New System.Drawing.Size(668, 730)
        Me.panelRight.TabIndex = 1
        '
        'dgwUsers
        '
        Me.dgwUsers.AllowUserToAddRows = False
        Me.dgwUsers.AllowUserToDeleteRows = False
        Me.dgwUsers.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgwUsers.BackgroundColor = System.Drawing.Color.White
        Me.dgwUsers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgwUsers.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgwUsers.Location = New System.Drawing.Point(0, 32)
        Me.dgwUsers.Name = "dgwUsers"
        Me.dgwUsers.ReadOnly = True
        Me.dgwUsers.Size = New System.Drawing.Size(668, 698)
        Me.dgwUsers.TabIndex = 4
        '
        'panelRightTop
        '
        Me.panelRightTop.Controls.Add(Me.lblUsersPerServer)
        Me.panelRightTop.Controls.Add(Me.btnRefresh)
        Me.panelRightTop.Dock = System.Windows.Forms.DockStyle.Top
        Me.panelRightTop.Location = New System.Drawing.Point(0, 0)
        Me.panelRightTop.Name = "panelRightTop"
        Me.panelRightTop.Size = New System.Drawing.Size(668, 32)
        Me.panelRightTop.TabIndex = 5
        '
        'lblUsersPerServer
        '
        Me.lblUsersPerServer.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblUsersPerServer.Location = New System.Drawing.Point(0, 0)
        Me.lblUsersPerServer.Name = "lblUsersPerServer"
        Me.lblUsersPerServer.Size = New System.Drawing.Size(636, 32)
        Me.lblUsersPerServer.TabIndex = 4
        Me.lblUsersPerServer.Text = "Individual Servers in the group"
        Me.lblUsersPerServer.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'btnRefresh
        '
        Me.btnRefresh.BackgroundImage = Global.TSRemoteControl.My.Resources.images.refresh32
        Me.btnRefresh.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnRefresh.Dock = System.Windows.Forms.DockStyle.Right
        Me.btnRefresh.Location = New System.Drawing.Point(636, 0)
        Me.btnRefresh.Name = "btnRefresh"
        Me.btnRefresh.Size = New System.Drawing.Size(32, 32)
        Me.btnRefresh.TabIndex = 5
        Me.toolTipsManager.SetToolTip(Me.btnRefresh, "Add a new group")
        Me.btnRefresh.UseVisualStyleBackColor = True
        '
        'listUsers
        '
        Me.listUsers.Dock = System.Windows.Forms.DockStyle.Fill
        Me.listUsers.Location = New System.Drawing.Point(0, 0)
        Me.listUsers.Name = "listUsers"
        Me.listUsers.Size = New System.Drawing.Size(668, 730)
        Me.listUsers.TabIndex = 2
        Me.listUsers.UseCompatibleStateImageBehavior = False
        '
        'timerUserRefresh
        '
        Me.timerUserRefresh.Interval = 60000
        '
        'UsersData
        '
        Me.UsersData.DataSetName = "dsetUsers"
        Me.UsersData.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'frmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1008, 730)
        Me.Controls.Add(Me.SplitContainer1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmMain"
        Me.Text = "Remote control terminal server user's session"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.SplitContainer1.Panel1.ResumeLayout(False)
        Me.SplitContainer1.Panel2.ResumeLayout(False)
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer1.ResumeLayout(False)
        Me.panelLeft.ResumeLayout(False)
        Me.SplitContainer2.Panel1.ResumeLayout(False)
        Me.SplitContainer2.Panel2.ResumeLayout(False)
        CType(Me.SplitContainer2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer2.ResumeLayout(False)
        Me.topLeftPanel.ResumeLayout(False)
        CType(Me.dgwGroups, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GroupsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GroupsAndServersData, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tlTopPanel.ResumeLayout(False)
        Me.bottomLeftPanel.ResumeLayout(False)
        CType(Me.dgwServers, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.bindingServersByGroup, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.panelRight.ResumeLayout(False)
        CType(Me.dgwUsers, System.ComponentModel.ISupportInitialize).EndInit()
        Me.panelRightTop.ResumeLayout(False)
        CType(Me.UsersData, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents SplitContainer1 As System.Windows.Forms.SplitContainer
    Friend WithEvents panelLeft As System.Windows.Forms.Panel
    Friend WithEvents SplitContainer2 As System.Windows.Forms.SplitContainer
    Friend WithEvents topLeftPanel As System.Windows.Forms.Panel
    Friend WithEvents bottomLeftPanel As System.Windows.Forms.Panel
    Friend WithEvents panelRight As System.Windows.Forms.Panel
    Friend WithEvents listUsers As System.Windows.Forms.ListView
    Friend WithEvents dgwGroups As System.Windows.Forms.DataGridView
    Friend WithEvents GroupsBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents GroupsAndServersData As TSRemoteControl.dsetGroupsAndServers
    Friend WithEvents dgwServers As System.Windows.Forms.DataGridView
    Friend WithEvents bindingServersByGroup As System.Windows.Forms.BindingSource
    Friend WithEvents tlTopPanel As System.Windows.Forms.Panel
    Friend WithEvents lblGroups As System.Windows.Forms.Label
    Friend WithEvents btnAddGroup As System.Windows.Forms.Button
    Friend WithEvents toolTipsManager As System.Windows.Forms.ToolTip
    Friend WithEvents GroupIdDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents GroupNameDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colEdit As System.Windows.Forms.DataGridViewButtonColumn
    Friend WithEvents colDelete As System.Windows.Forms.DataGridViewButtonColumn
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents lblDetailTS As System.Windows.Forms.Label
    Friend WithEvents btnAddServer As System.Windows.Forms.Button
    Friend WithEvents GroupIdDataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ServerIdDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ServerNameDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ServerDisplayNameDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colServerEdit As System.Windows.Forms.DataGridViewButtonColumn
    Friend WithEvents colServerDelete As System.Windows.Forms.DataGridViewButtonColumn
    Friend WithEvents dgwUsers As System.Windows.Forms.DataGridView
    Friend WithEvents timerUserRefresh As System.Windows.Forms.Timer
    Friend WithEvents panelRightTop As System.Windows.Forms.Panel
    Friend WithEvents lblUsersPerServer As System.Windows.Forms.Label
    Friend WithEvents btnRefresh As System.Windows.Forms.Button
    Friend WithEvents UsersData As TSRemoteControl.dsetUsers

End Class
