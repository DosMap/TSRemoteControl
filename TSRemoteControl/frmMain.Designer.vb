<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmMain
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
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

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmMain))
        Me.contentContainer = New System.Windows.Forms.SplitContainer()
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
        Me.colGetUsers = New System.Windows.Forms.DataGridViewButtonColumn()
        Me.GroupIdDataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ServerIdDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ServerNameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ServerDisplayNameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colServerEdit = New System.Windows.Forms.DataGridViewButtonColumn()
        Me.colServerDelete = New System.Windows.Forms.DataGridViewButtonColumn()
        Me.bindingServersByGroup = New System.Windows.Forms.BindingSource(Me.components)
        Me.panelTopServers = New System.Windows.Forms.Panel()
        Me.lblDetailTS = New System.Windows.Forms.Label()
        Me.btnAddServer = New System.Windows.Forms.Button()
        Me.panelRight = New System.Windows.Forms.Panel()
        Me.dgwUsers = New System.Windows.Forms.DataGridView()
        Me.colConnect = New System.Windows.Forms.DataGridViewButtonColumn()
        Me.TSName = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colMessage = New System.Windows.Forms.DataGridViewButtonColumn()
        Me.UserName = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.UserId = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.UserState = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PCName = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colCloseSession = New System.Windows.Forms.DataGridViewButtonColumn()
        Me.bindingUsers = New System.Windows.Forms.BindingSource(Me.components)
        Me.UsersData = New TSRemoteControl.dsetUsers()
        Me.panelUsersTop = New System.Windows.Forms.Panel()
        Me.txtFilter = New System.Windows.Forms.TextBox()
        Me.lblUserFilter = New System.Windows.Forms.Label()
        Me.userStatusStrip = New System.Windows.Forms.StatusStrip()
        Me.userStatusLabel = New System.Windows.Forms.ToolStripStatusLabel()
        Me.userRefreshProgessBar = New System.Windows.Forms.ToolStripProgressBar()
        Me.userRefreshCancelButton = New System.Windows.Forms.ToolStripStatusLabel()
        Me.panelRightTop = New System.Windows.Forms.Panel()
        Me.lblUsersPerServer = New System.Windows.Forms.Label()
        Me.btnRefresh = New System.Windows.Forms.Button()
        Me.listUsers = New System.Windows.Forms.ListView()
        Me.toolTipsManager = New System.Windows.Forms.ToolTip(Me.components)
        Me.timerUserRefresh = New System.Windows.Forms.Timer(Me.components)
        Me.bgWorker = New System.ComponentModel.BackgroundWorker()
        Me.TheMenuStrip = New System.Windows.Forms.MenuStrip()
        Me.FileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ImportServersFileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExportServersFileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.HelpToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AboutThisApplicationToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.dlgOpenFile = New System.Windows.Forms.OpenFileDialog()
        Me.dlgSaveFile = New System.Windows.Forms.SaveFileDialog()
        CType(Me.contentContainer, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.contentContainer.Panel1.SuspendLayout()
        Me.contentContainer.Panel2.SuspendLayout()
        Me.contentContainer.SuspendLayout()
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
        Me.panelTopServers.SuspendLayout()
        Me.panelRight.SuspendLayout()
        CType(Me.dgwUsers, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.bindingUsers, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UsersData, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.panelUsersTop.SuspendLayout()
        Me.userStatusStrip.SuspendLayout()
        Me.panelRightTop.SuspendLayout()
        Me.TheMenuStrip.SuspendLayout()
        Me.SuspendLayout()
        '
        'contentContainer
        '
        Me.contentContainer.Dock = System.Windows.Forms.DockStyle.Fill
        Me.contentContainer.Location = New System.Drawing.Point(0, 24)
        Me.contentContainer.Name = "contentContainer"
        '
        'contentContainer.Panel1
        '
        Me.contentContainer.Panel1.Controls.Add(Me.panelLeft)
        '
        'contentContainer.Panel2
        '
        Me.contentContainer.Panel2.Controls.Add(Me.panelRight)
        Me.contentContainer.Size = New System.Drawing.Size(1044, 732)
        Me.contentContainer.SplitterDistance = 348
        Me.contentContainer.TabIndex = 0
        '
        'panelLeft
        '
        Me.panelLeft.Controls.Add(Me.SplitContainer2)
        Me.panelLeft.Dock = System.Windows.Forms.DockStyle.Fill
        Me.panelLeft.Location = New System.Drawing.Point(0, 0)
        Me.panelLeft.Name = "panelLeft"
        Me.panelLeft.Size = New System.Drawing.Size(348, 732)
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
        Me.SplitContainer2.Size = New System.Drawing.Size(348, 732)
        Me.SplitContainer2.SplitterDistance = 263
        Me.SplitContainer2.TabIndex = 0
        '
        'topLeftPanel
        '
        Me.topLeftPanel.Controls.Add(Me.dgwGroups)
        Me.topLeftPanel.Controls.Add(Me.tlTopPanel)
        Me.topLeftPanel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.topLeftPanel.Location = New System.Drawing.Point(0, 0)
        Me.topLeftPanel.Name = "topLeftPanel"
        Me.topLeftPanel.Size = New System.Drawing.Size(348, 263)
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
        Me.dgwGroups.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.dgwGroups.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgwGroups.Size = New System.Drawing.Size(348, 231)
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
        Me.tlTopPanel.BackColor = System.Drawing.SystemColors.Control
        Me.tlTopPanel.BackgroundImage = CType(resources.GetObject("tlTopPanel.BackgroundImage"), System.Drawing.Image)
        Me.tlTopPanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.tlTopPanel.Controls.Add(Me.lblGroups)
        Me.tlTopPanel.Controls.Add(Me.btnAddGroup)
        Me.tlTopPanel.Dock = System.Windows.Forms.DockStyle.Top
        Me.tlTopPanel.Location = New System.Drawing.Point(0, 0)
        Me.tlTopPanel.Name = "tlTopPanel"
        Me.tlTopPanel.Size = New System.Drawing.Size(348, 32)
        Me.tlTopPanel.TabIndex = 3
        '
        'lblGroups
        '
        Me.lblGroups.BackColor = System.Drawing.Color.Transparent
        Me.lblGroups.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblGroups.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblGroups.ForeColor = System.Drawing.Color.White
        Me.lblGroups.Location = New System.Drawing.Point(0, 0)
        Me.lblGroups.Name = "lblGroups"
        Me.lblGroups.Size = New System.Drawing.Size(316, 32)
        Me.lblGroups.TabIndex = 2
        Me.lblGroups.Text = "Groups of Terminal Servers"
        Me.lblGroups.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'btnAddGroup
        '
        Me.btnAddGroup.BackgroundImage = Global.TSRemoteControl.My.Resources.Resources.add32
        Me.btnAddGroup.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnAddGroup.Dock = System.Windows.Forms.DockStyle.Right
        Me.btnAddGroup.Location = New System.Drawing.Point(316, 0)
        Me.btnAddGroup.Name = "btnAddGroup"
        Me.btnAddGroup.Size = New System.Drawing.Size(32, 32)
        Me.btnAddGroup.TabIndex = 3
        Me.toolTipsManager.SetToolTip(Me.btnAddGroup, "Add a new group")
        Me.btnAddGroup.UseVisualStyleBackColor = True
        '
        'bottomLeftPanel
        '
        Me.bottomLeftPanel.Controls.Add(Me.dgwServers)
        Me.bottomLeftPanel.Controls.Add(Me.panelTopServers)
        Me.bottomLeftPanel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.bottomLeftPanel.Location = New System.Drawing.Point(0, 0)
        Me.bottomLeftPanel.Name = "bottomLeftPanel"
        Me.bottomLeftPanel.Size = New System.Drawing.Size(348, 465)
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
        Me.dgwServers.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.colGetUsers, Me.GroupIdDataGridViewTextBoxColumn1, Me.ServerIdDataGridViewTextBoxColumn, Me.ServerNameDataGridViewTextBoxColumn, Me.ServerDisplayNameDataGridViewTextBoxColumn, Me.colServerEdit, Me.colServerDelete})
        Me.dgwServers.DataSource = Me.bindingServersByGroup
        Me.dgwServers.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgwServers.Location = New System.Drawing.Point(0, 32)
        Me.dgwServers.MultiSelect = False
        Me.dgwServers.Name = "dgwServers"
        Me.dgwServers.ReadOnly = True
        Me.dgwServers.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.dgwServers.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect
        Me.dgwServers.Size = New System.Drawing.Size(348, 433)
        Me.dgwServers.TabIndex = 4
        '
        'colGetUsers
        '
        Me.colGetUsers.HeaderText = ""
        Me.colGetUsers.MinimumWidth = 32
        Me.colGetUsers.Name = "colGetUsers"
        Me.colGetUsers.ReadOnly = True
        Me.colGetUsers.Width = 32
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
        Me.colServerEdit.MinimumWidth = 32
        Me.colServerEdit.Name = "colServerEdit"
        Me.colServerEdit.ReadOnly = True
        Me.colServerEdit.Width = 32
        '
        'colServerDelete
        '
        Me.colServerDelete.HeaderText = ""
        Me.colServerDelete.MinimumWidth = 32
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
        'panelTopServers
        '
        Me.panelTopServers.BackgroundImage = CType(resources.GetObject("panelTopServers.BackgroundImage"), System.Drawing.Image)
        Me.panelTopServers.Controls.Add(Me.lblDetailTS)
        Me.panelTopServers.Controls.Add(Me.btnAddServer)
        Me.panelTopServers.Dock = System.Windows.Forms.DockStyle.Top
        Me.panelTopServers.Location = New System.Drawing.Point(0, 0)
        Me.panelTopServers.Name = "panelTopServers"
        Me.panelTopServers.Size = New System.Drawing.Size(348, 32)
        Me.panelTopServers.TabIndex = 5
        '
        'lblDetailTS
        '
        Me.lblDetailTS.BackColor = System.Drawing.Color.Transparent
        Me.lblDetailTS.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblDetailTS.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDetailTS.ForeColor = System.Drawing.Color.White
        Me.lblDetailTS.Location = New System.Drawing.Point(0, 0)
        Me.lblDetailTS.Name = "lblDetailTS"
        Me.lblDetailTS.Size = New System.Drawing.Size(316, 32)
        Me.lblDetailTS.TabIndex = 4
        Me.lblDetailTS.Text = "Individual Servers in the group"
        Me.lblDetailTS.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'btnAddServer
        '
        Me.btnAddServer.BackgroundImage = Global.TSRemoteControl.My.Resources.Resources.add32
        Me.btnAddServer.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnAddServer.Dock = System.Windows.Forms.DockStyle.Right
        Me.btnAddServer.Location = New System.Drawing.Point(316, 0)
        Me.btnAddServer.Name = "btnAddServer"
        Me.btnAddServer.Size = New System.Drawing.Size(32, 32)
        Me.btnAddServer.TabIndex = 3
        Me.toolTipsManager.SetToolTip(Me.btnAddServer, "Add a new server")
        Me.btnAddServer.UseVisualStyleBackColor = True
        '
        'panelRight
        '
        Me.panelRight.Controls.Add(Me.dgwUsers)
        Me.panelRight.Controls.Add(Me.panelUsersTop)
        Me.panelRight.Controls.Add(Me.userStatusStrip)
        Me.panelRight.Controls.Add(Me.panelRightTop)
        Me.panelRight.Controls.Add(Me.listUsers)
        Me.panelRight.Dock = System.Windows.Forms.DockStyle.Fill
        Me.panelRight.Location = New System.Drawing.Point(0, 0)
        Me.panelRight.Name = "panelRight"
        Me.panelRight.Size = New System.Drawing.Size(692, 732)
        Me.panelRight.TabIndex = 1
        '
        'dgwUsers
        '
        Me.dgwUsers.AllowUserToAddRows = False
        Me.dgwUsers.AllowUserToDeleteRows = False
        Me.dgwUsers.AllowUserToResizeRows = False
        Me.dgwUsers.AutoGenerateColumns = False
        Me.dgwUsers.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgwUsers.BackgroundColor = System.Drawing.Color.White
        Me.dgwUsers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgwUsers.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.colConnect, Me.TSName, Me.colMessage, Me.UserName, Me.UserId, Me.UserState, Me.PCName, Me.colCloseSession})
        Me.dgwUsers.DataSource = Me.bindingUsers
        Me.dgwUsers.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgwUsers.Location = New System.Drawing.Point(0, 64)
        Me.dgwUsers.MultiSelect = False
        Me.dgwUsers.Name = "dgwUsers"
        Me.dgwUsers.ReadOnly = True
        Me.dgwUsers.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgwUsers.Size = New System.Drawing.Size(692, 646)
        Me.dgwUsers.TabIndex = 4
        '
        'colConnect
        '
        Me.colConnect.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        Me.colConnect.HeaderText = ""
        Me.colConnect.MinimumWidth = 32
        Me.colConnect.Name = "colConnect"
        Me.colConnect.ReadOnly = True
        Me.colConnect.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.colConnect.Width = 32
        '
        'TSName
        '
        Me.TSName.DataPropertyName = "TSName"
        Me.TSName.HeaderText = "Server"
        Me.TSName.Name = "TSName"
        Me.TSName.ReadOnly = True
        '
        'colMessage
        '
        Me.colMessage.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        Me.colMessage.HeaderText = ""
        Me.colMessage.MinimumWidth = 32
        Me.colMessage.Name = "colMessage"
        Me.colMessage.ReadOnly = True
        Me.colMessage.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.colMessage.Width = 32
        '
        'UserName
        '
        Me.UserName.DataPropertyName = "UserName"
        Me.UserName.HeaderText = "User"
        Me.UserName.Name = "UserName"
        Me.UserName.ReadOnly = True
        '
        'UserId
        '
        Me.UserId.DataPropertyName = "UserId"
        Me.UserId.HeaderText = "User ID"
        Me.UserId.Name = "UserId"
        Me.UserId.ReadOnly = True
        '
        'UserState
        '
        Me.UserState.DataPropertyName = "UserState"
        Me.UserState.HeaderText = "Connection state"
        Me.UserState.Name = "UserState"
        Me.UserState.ReadOnly = True
        '
        'PCName
        '
        Me.PCName.DataPropertyName = "PCName"
        Me.PCName.HeaderText = "Client PC"
        Me.PCName.Name = "PCName"
        Me.PCName.ReadOnly = True
        '
        'colCloseSession
        '
        Me.colCloseSession.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        Me.colCloseSession.FillWeight = 97.46193!
        Me.colCloseSession.HeaderText = ""
        Me.colCloseSession.MinimumWidth = 32
        Me.colCloseSession.Name = "colCloseSession"
        Me.colCloseSession.ReadOnly = True
        Me.colCloseSession.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.colCloseSession.Width = 32
        '
        'bindingUsers
        '
        Me.bindingUsers.AllowNew = True
        Me.bindingUsers.DataMember = "Users"
        Me.bindingUsers.DataSource = Me.UsersData
        '
        'UsersData
        '
        Me.UsersData.DataSetName = "dsetUsers"
        Me.UsersData.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'panelUsersTop
        '
        Me.panelUsersTop.Controls.Add(Me.txtFilter)
        Me.panelUsersTop.Controls.Add(Me.lblUserFilter)
        Me.panelUsersTop.Dock = System.Windows.Forms.DockStyle.Top
        Me.panelUsersTop.Location = New System.Drawing.Point(0, 32)
        Me.panelUsersTop.Name = "panelUsersTop"
        Me.panelUsersTop.Size = New System.Drawing.Size(692, 32)
        Me.panelUsersTop.TabIndex = 8
        '
        'txtFilter
        '
        Me.txtFilter.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtFilter.Location = New System.Drawing.Point(108, 6)
        Me.txtFilter.Name = "txtFilter"
        Me.txtFilter.Size = New System.Drawing.Size(572, 20)
        Me.txtFilter.TabIndex = 1
        '
        'lblUserFilter
        '
        Me.lblUserFilter.Location = New System.Drawing.Point(3, 5)
        Me.lblUserFilter.Name = "lblUserFilter"
        Me.lblUserFilter.Size = New System.Drawing.Size(99, 23)
        Me.lblUserFilter.TabIndex = 0
        Me.lblUserFilter.Text = "User name filter:"
        Me.lblUserFilter.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'userStatusStrip
        '
        Me.userStatusStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.userStatusLabel, Me.userRefreshProgessBar, Me.userRefreshCancelButton})
        Me.userStatusStrip.Location = New System.Drawing.Point(0, 710)
        Me.userStatusStrip.Name = "userStatusStrip"
        Me.userStatusStrip.Size = New System.Drawing.Size(692, 22)
        Me.userStatusStrip.TabIndex = 7
        '
        'userStatusLabel
        '
        Me.userStatusLabel.AutoSize = False
        Me.userStatusLabel.Name = "userStatusLabel"
        Me.userStatusLabel.Size = New System.Drawing.Size(200, 17)
        Me.userStatusLabel.Text = "Number of users:"
        Me.userStatusLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'userRefreshProgessBar
        '
        Me.userRefreshProgessBar.Name = "userRefreshProgessBar"
        Me.userRefreshProgessBar.Size = New System.Drawing.Size(200, 16)
        '
        'userRefreshCancelButton
        '
        Me.userRefreshCancelButton.IsLink = True
        Me.userRefreshCancelButton.Name = "userRefreshCancelButton"
        Me.userRefreshCancelButton.Size = New System.Drawing.Size(147, 17)
        Me.userRefreshCancelButton.Text = "Click to cancel the process"
        '
        'panelRightTop
        '
        Me.panelRightTop.BackgroundImage = CType(resources.GetObject("panelRightTop.BackgroundImage"), System.Drawing.Image)
        Me.panelRightTop.Controls.Add(Me.lblUsersPerServer)
        Me.panelRightTop.Controls.Add(Me.btnRefresh)
        Me.panelRightTop.Dock = System.Windows.Forms.DockStyle.Top
        Me.panelRightTop.Location = New System.Drawing.Point(0, 0)
        Me.panelRightTop.Name = "panelRightTop"
        Me.panelRightTop.Size = New System.Drawing.Size(692, 32)
        Me.panelRightTop.TabIndex = 5
        '
        'lblUsersPerServer
        '
        Me.lblUsersPerServer.BackColor = System.Drawing.Color.Transparent
        Me.lblUsersPerServer.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblUsersPerServer.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblUsersPerServer.ForeColor = System.Drawing.Color.White
        Me.lblUsersPerServer.Location = New System.Drawing.Point(0, 0)
        Me.lblUsersPerServer.Name = "lblUsersPerServer"
        Me.lblUsersPerServer.Size = New System.Drawing.Size(660, 32)
        Me.lblUsersPerServer.TabIndex = 4
        Me.lblUsersPerServer.Text = "Users connected to the selected servers"
        Me.lblUsersPerServer.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'btnRefresh
        '
        Me.btnRefresh.BackgroundImage = Global.TSRemoteControl.My.Resources.images.refresh32
        Me.btnRefresh.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnRefresh.Dock = System.Windows.Forms.DockStyle.Right
        Me.btnRefresh.Location = New System.Drawing.Point(660, 0)
        Me.btnRefresh.Name = "btnRefresh"
        Me.btnRefresh.Size = New System.Drawing.Size(32, 32)
        Me.btnRefresh.TabIndex = 5
        Me.toolTipsManager.SetToolTip(Me.btnRefresh, "Refresh users")
        Me.btnRefresh.UseVisualStyleBackColor = True
        '
        'listUsers
        '
        Me.listUsers.Dock = System.Windows.Forms.DockStyle.Fill
        Me.listUsers.Location = New System.Drawing.Point(0, 0)
        Me.listUsers.Name = "listUsers"
        Me.listUsers.Size = New System.Drawing.Size(692, 732)
        Me.listUsers.TabIndex = 2
        Me.listUsers.UseCompatibleStateImageBehavior = False
        '
        'toolTipsManager
        '
        Me.toolTipsManager.IsBalloon = True
        '
        'timerUserRefresh
        '
        Me.timerUserRefresh.Interval = 60000
        '
        'bgWorker
        '
        Me.bgWorker.WorkerReportsProgress = True
        Me.bgWorker.WorkerSupportsCancellation = True
        '
        'TheMenuStrip
        '
        Me.TheMenuStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem, Me.HelpToolStripMenuItem})
        Me.TheMenuStrip.Location = New System.Drawing.Point(0, 0)
        Me.TheMenuStrip.Name = "TheMenuStrip"
        Me.TheMenuStrip.Size = New System.Drawing.Size(1044, 24)
        Me.TheMenuStrip.TabIndex = 1
        Me.TheMenuStrip.Text = "MainMenu"
        '
        'FileToolStripMenuItem
        '
        Me.FileToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ImportServersFileToolStripMenuItem, Me.ExportServersFileToolStripMenuItem, Me.ExitToolStripMenuItem})
        Me.FileToolStripMenuItem.Name = "FileToolStripMenuItem"
        Me.FileToolStripMenuItem.Size = New System.Drawing.Size(37, 20)
        Me.FileToolStripMenuItem.Text = "&File"
        '
        'ImportServersFileToolStripMenuItem
        '
        Me.ImportServersFileToolStripMenuItem.Name = "ImportServersFileToolStripMenuItem"
        Me.ImportServersFileToolStripMenuItem.Size = New System.Drawing.Size(168, 22)
        Me.ImportServersFileToolStripMenuItem.Text = "&Import servers file"
        '
        'ExportServersFileToolStripMenuItem
        '
        Me.ExportServersFileToolStripMenuItem.Name = "ExportServersFileToolStripMenuItem"
        Me.ExportServersFileToolStripMenuItem.Size = New System.Drawing.Size(168, 22)
        Me.ExportServersFileToolStripMenuItem.Text = "E&xport servers file"
        '
        'ExitToolStripMenuItem
        '
        Me.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem"
        Me.ExitToolStripMenuItem.Size = New System.Drawing.Size(168, 22)
        Me.ExitToolStripMenuItem.Text = "&Exit"
        '
        'HelpToolStripMenuItem
        '
        Me.HelpToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AboutThisApplicationToolStripMenuItem})
        Me.HelpToolStripMenuItem.Name = "HelpToolStripMenuItem"
        Me.HelpToolStripMenuItem.Size = New System.Drawing.Size(44, 20)
        Me.HelpToolStripMenuItem.Text = "&Help"
        '
        'AboutThisApplicationToolStripMenuItem
        '
        Me.AboutThisApplicationToolStripMenuItem.Name = "AboutThisApplicationToolStripMenuItem"
        Me.AboutThisApplicationToolStripMenuItem.Size = New System.Drawing.Size(191, 22)
        Me.AboutThisApplicationToolStripMenuItem.Text = "&About this application"
        '
        'dlgOpenFile
        '
        Me.dlgOpenFile.Filter = "Config file | *.config"
        '
        'dlgSaveFile
        '
        Me.dlgSaveFile.Filter = "Config file |*.config"
        '
        'frmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1044, 756)
        Me.Controls.Add(Me.contentContainer)
        Me.Controls.Add(Me.TheMenuStrip)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmMain"
        Me.Text = "Remote control terminal server user sessions"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.contentContainer.Panel1.ResumeLayout(False)
        Me.contentContainer.Panel2.ResumeLayout(False)
        CType(Me.contentContainer, System.ComponentModel.ISupportInitialize).EndInit()
        Me.contentContainer.ResumeLayout(False)
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
        Me.panelTopServers.ResumeLayout(False)
        Me.panelRight.ResumeLayout(False)
        Me.panelRight.PerformLayout()
        CType(Me.dgwUsers, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.bindingUsers, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UsersData, System.ComponentModel.ISupportInitialize).EndInit()
        Me.panelUsersTop.ResumeLayout(False)
        Me.panelUsersTop.PerformLayout()
        Me.userStatusStrip.ResumeLayout(False)
        Me.userStatusStrip.PerformLayout()
        Me.panelRightTop.ResumeLayout(False)
        Me.TheMenuStrip.ResumeLayout(False)
        Me.TheMenuStrip.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents contentContainer As System.Windows.Forms.SplitContainer
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
    Friend WithEvents panelTopServers As System.Windows.Forms.Panel
    Friend WithEvents lblDetailTS As System.Windows.Forms.Label
    Friend WithEvents btnAddServer As System.Windows.Forms.Button
    Friend WithEvents dgwUsers As System.Windows.Forms.DataGridView
    Friend WithEvents timerUserRefresh As System.Windows.Forms.Timer
    Friend WithEvents panelRightTop As System.Windows.Forms.Panel
    Friend WithEvents lblUsersPerServer As System.Windows.Forms.Label
    Friend WithEvents btnRefresh As System.Windows.Forms.Button
    Friend WithEvents UsersData As TSRemoteControl.dsetUsers
    Friend WithEvents bgWorker As System.ComponentModel.BackgroundWorker
    Friend WithEvents userStatusStrip As StatusStrip
    Friend WithEvents userStatusLabel As ToolStripStatusLabel
    Friend WithEvents userRefreshProgessBar As ToolStripProgressBar
    Friend WithEvents userRefreshCancelButton As ToolStripStatusLabel
    Friend WithEvents colGetUsers As DataGridViewButtonColumn
    Friend WithEvents GroupIdDataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents ServerIdDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ServerNameDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ServerDisplayNameDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents colServerEdit As DataGridViewButtonColumn
    Friend WithEvents colServerDelete As DataGridViewButtonColumn
    Friend WithEvents bindingUsers As BindingSource
    Friend WithEvents panelUsersTop As Panel
    Friend WithEvents txtFilter As TextBox
    Friend WithEvents lblUserFilter As Label
    Friend WithEvents colConnect As DataGridViewButtonColumn
    Friend WithEvents TSName As DataGridViewTextBoxColumn
    Friend WithEvents colMessage As DataGridViewButtonColumn
    Friend WithEvents UserName As DataGridViewTextBoxColumn
    Friend WithEvents UserId As DataGridViewTextBoxColumn
    Friend WithEvents UserState As DataGridViewTextBoxColumn
    Friend WithEvents PCName As DataGridViewTextBoxColumn
    Friend WithEvents colCloseSession As DataGridViewButtonColumn
    Friend WithEvents TheMenuStrip As MenuStrip
    Friend WithEvents FileToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ExitToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents HelpToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AboutThisApplicationToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ImportServersFileToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents dlgOpenFile As OpenFileDialog
    Friend WithEvents ExportServersFileToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents dlgSaveFile As SaveFileDialog
End Class
