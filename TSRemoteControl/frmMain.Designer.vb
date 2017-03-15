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
        Me.panelHowToFilter = New System.Windows.Forms.Panel()
        Me.lblHowToFilter = New System.Windows.Forms.Label()
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
        Me.TheMenuStrip = New System.Windows.Forms.MenuStrip()
        Me.FileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ImportServersFileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExportServersFileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.HelpToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AboutThisApplicationToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.timerUserRefresh = New System.Windows.Forms.Timer(Me.components)
        Me.bgWorker = New System.ComponentModel.BackgroundWorker()
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
        Me.panelHowToFilter.SuspendLayout()
        Me.panelUsersTop.SuspendLayout()
        Me.userStatusStrip.SuspendLayout()
        Me.panelRightTop.SuspendLayout()
        Me.TheMenuStrip.SuspendLayout()
        Me.SuspendLayout()
        '
        'contentContainer
        '
        resources.ApplyResources(Me.contentContainer, "contentContainer")
        Me.contentContainer.Name = "contentContainer"
        '
        'contentContainer.Panel1
        '
        Me.contentContainer.Panel1.Controls.Add(Me.panelLeft)
        '
        'contentContainer.Panel2
        '
        Me.contentContainer.Panel2.Controls.Add(Me.panelRight)
        '
        'panelLeft
        '
        Me.panelLeft.Controls.Add(Me.SplitContainer2)
        resources.ApplyResources(Me.panelLeft, "panelLeft")
        Me.panelLeft.Name = "panelLeft"
        '
        'SplitContainer2
        '
        resources.ApplyResources(Me.SplitContainer2, "SplitContainer2")
        Me.SplitContainer2.Name = "SplitContainer2"
        '
        'SplitContainer2.Panel1
        '
        Me.SplitContainer2.Panel1.Controls.Add(Me.topLeftPanel)
        '
        'SplitContainer2.Panel2
        '
        Me.SplitContainer2.Panel2.Controls.Add(Me.bottomLeftPanel)
        '
        'topLeftPanel
        '
        Me.topLeftPanel.Controls.Add(Me.dgwGroups)
        Me.topLeftPanel.Controls.Add(Me.tlTopPanel)
        resources.ApplyResources(Me.topLeftPanel, "topLeftPanel")
        Me.topLeftPanel.Name = "topLeftPanel"
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
        resources.ApplyResources(Me.dgwGroups, "dgwGroups")
        Me.dgwGroups.GridColor = System.Drawing.Color.White
        Me.dgwGroups.MultiSelect = False
        Me.dgwGroups.Name = "dgwGroups"
        Me.dgwGroups.ReadOnly = True
        Me.dgwGroups.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        '
        'GroupIdDataGridViewTextBoxColumn
        '
        Me.GroupIdDataGridViewTextBoxColumn.DataPropertyName = "groupId"
        resources.ApplyResources(Me.GroupIdDataGridViewTextBoxColumn, "GroupIdDataGridViewTextBoxColumn")
        Me.GroupIdDataGridViewTextBoxColumn.Name = "GroupIdDataGridViewTextBoxColumn"
        Me.GroupIdDataGridViewTextBoxColumn.ReadOnly = True
        '
        'GroupNameDataGridViewTextBoxColumn
        '
        Me.GroupNameDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.GroupNameDataGridViewTextBoxColumn.DataPropertyName = "groupName"
        resources.ApplyResources(Me.GroupNameDataGridViewTextBoxColumn, "GroupNameDataGridViewTextBoxColumn")
        Me.GroupNameDataGridViewTextBoxColumn.Name = "GroupNameDataGridViewTextBoxColumn"
        Me.GroupNameDataGridViewTextBoxColumn.ReadOnly = True
        '
        'colEdit
        '
        resources.ApplyResources(Me.colEdit, "colEdit")
        Me.colEdit.Name = "colEdit"
        Me.colEdit.ReadOnly = True
        Me.colEdit.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.colEdit.Text = ""
        '
        'colDelete
        '
        resources.ApplyResources(Me.colDelete, "colDelete")
        Me.colDelete.Name = "colDelete"
        Me.colDelete.ReadOnly = True
        Me.colDelete.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.colDelete.Text = ""
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
        resources.ApplyResources(Me.tlTopPanel, "tlTopPanel")
        Me.tlTopPanel.Controls.Add(Me.lblGroups)
        Me.tlTopPanel.Controls.Add(Me.btnAddGroup)
        Me.tlTopPanel.Name = "tlTopPanel"
        '
        'lblGroups
        '
        Me.lblGroups.BackColor = System.Drawing.Color.Transparent
        resources.ApplyResources(Me.lblGroups, "lblGroups")
        Me.lblGroups.ForeColor = System.Drawing.Color.White
        Me.lblGroups.Name = "lblGroups"
        '
        'btnAddGroup
        '
        Me.btnAddGroup.BackgroundImage = Global.TSRemoteControl.My.Resources.Resources.add32
        resources.ApplyResources(Me.btnAddGroup, "btnAddGroup")
        Me.btnAddGroup.Name = "btnAddGroup"
        Me.toolTipsManager.SetToolTip(Me.btnAddGroup, resources.GetString("btnAddGroup.ToolTip"))
        Me.btnAddGroup.UseVisualStyleBackColor = True
        '
        'bottomLeftPanel
        '
        Me.bottomLeftPanel.Controls.Add(Me.dgwServers)
        Me.bottomLeftPanel.Controls.Add(Me.panelTopServers)
        resources.ApplyResources(Me.bottomLeftPanel, "bottomLeftPanel")
        Me.bottomLeftPanel.Name = "bottomLeftPanel"
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
        resources.ApplyResources(Me.dgwServers, "dgwServers")
        Me.dgwServers.MultiSelect = False
        Me.dgwServers.Name = "dgwServers"
        Me.dgwServers.ReadOnly = True
        Me.dgwServers.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect
        '
        'colGetUsers
        '
        resources.ApplyResources(Me.colGetUsers, "colGetUsers")
        Me.colGetUsers.Name = "colGetUsers"
        Me.colGetUsers.ReadOnly = True
        '
        'GroupIdDataGridViewTextBoxColumn1
        '
        Me.GroupIdDataGridViewTextBoxColumn1.DataPropertyName = "groupId"
        resources.ApplyResources(Me.GroupIdDataGridViewTextBoxColumn1, "GroupIdDataGridViewTextBoxColumn1")
        Me.GroupIdDataGridViewTextBoxColumn1.Name = "GroupIdDataGridViewTextBoxColumn1"
        Me.GroupIdDataGridViewTextBoxColumn1.ReadOnly = True
        '
        'ServerIdDataGridViewTextBoxColumn
        '
        Me.ServerIdDataGridViewTextBoxColumn.DataPropertyName = "serverId"
        resources.ApplyResources(Me.ServerIdDataGridViewTextBoxColumn, "ServerIdDataGridViewTextBoxColumn")
        Me.ServerIdDataGridViewTextBoxColumn.Name = "ServerIdDataGridViewTextBoxColumn"
        Me.ServerIdDataGridViewTextBoxColumn.ReadOnly = True
        '
        'ServerNameDataGridViewTextBoxColumn
        '
        Me.ServerNameDataGridViewTextBoxColumn.DataPropertyName = "serverName"
        Me.ServerNameDataGridViewTextBoxColumn.Name = "ServerNameDataGridViewTextBoxColumn"
        Me.ServerNameDataGridViewTextBoxColumn.ReadOnly = True
        resources.ApplyResources(Me.ServerNameDataGridViewTextBoxColumn, "ServerNameDataGridViewTextBoxColumn")
        '
        'ServerDisplayNameDataGridViewTextBoxColumn
        '
        Me.ServerDisplayNameDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.ServerDisplayNameDataGridViewTextBoxColumn.DataPropertyName = "serverDisplayName"
        resources.ApplyResources(Me.ServerDisplayNameDataGridViewTextBoxColumn, "ServerDisplayNameDataGridViewTextBoxColumn")
        Me.ServerDisplayNameDataGridViewTextBoxColumn.Name = "ServerDisplayNameDataGridViewTextBoxColumn"
        Me.ServerDisplayNameDataGridViewTextBoxColumn.ReadOnly = True
        '
        'colServerEdit
        '
        resources.ApplyResources(Me.colServerEdit, "colServerEdit")
        Me.colServerEdit.Name = "colServerEdit"
        Me.colServerEdit.ReadOnly = True
        '
        'colServerDelete
        '
        resources.ApplyResources(Me.colServerDelete, "colServerDelete")
        Me.colServerDelete.Name = "colServerDelete"
        Me.colServerDelete.ReadOnly = True
        '
        'bindingServersByGroup
        '
        Me.bindingServersByGroup.DataMember = "servers"
        Me.bindingServersByGroup.DataSource = Me.GroupsAndServersData
        Me.bindingServersByGroup.Sort = "serverDisplayName"
        '
        'panelTopServers
        '
        resources.ApplyResources(Me.panelTopServers, "panelTopServers")
        Me.panelTopServers.Controls.Add(Me.lblDetailTS)
        Me.panelTopServers.Controls.Add(Me.btnAddServer)
        Me.panelTopServers.Name = "panelTopServers"
        '
        'lblDetailTS
        '
        Me.lblDetailTS.BackColor = System.Drawing.Color.Transparent
        resources.ApplyResources(Me.lblDetailTS, "lblDetailTS")
        Me.lblDetailTS.ForeColor = System.Drawing.Color.White
        Me.lblDetailTS.Name = "lblDetailTS"
        '
        'btnAddServer
        '
        Me.btnAddServer.BackgroundImage = Global.TSRemoteControl.My.Resources.Resources.add32
        resources.ApplyResources(Me.btnAddServer, "btnAddServer")
        Me.btnAddServer.Name = "btnAddServer"
        Me.toolTipsManager.SetToolTip(Me.btnAddServer, resources.GetString("btnAddServer.ToolTip"))
        Me.btnAddServer.UseVisualStyleBackColor = True
        '
        'panelRight
        '
        Me.panelRight.Controls.Add(Me.dgwUsers)
        Me.panelRight.Controls.Add(Me.panelHowToFilter)
        Me.panelRight.Controls.Add(Me.panelUsersTop)
        Me.panelRight.Controls.Add(Me.userStatusStrip)
        Me.panelRight.Controls.Add(Me.panelRightTop)
        Me.panelRight.Controls.Add(Me.listUsers)
        resources.ApplyResources(Me.panelRight, "panelRight")
        Me.panelRight.Name = "panelRight"
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
        resources.ApplyResources(Me.dgwUsers, "dgwUsers")
        Me.dgwUsers.MultiSelect = False
        Me.dgwUsers.Name = "dgwUsers"
        Me.dgwUsers.ReadOnly = True
        Me.dgwUsers.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        '
        'colConnect
        '
        Me.colConnect.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        resources.ApplyResources(Me.colConnect, "colConnect")
        Me.colConnect.Name = "colConnect"
        Me.colConnect.ReadOnly = True
        Me.colConnect.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        '
        'TSName
        '
        Me.TSName.DataPropertyName = "TSName"
        resources.ApplyResources(Me.TSName, "TSName")
        Me.TSName.Name = "TSName"
        Me.TSName.ReadOnly = True
        '
        'colMessage
        '
        Me.colMessage.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        resources.ApplyResources(Me.colMessage, "colMessage")
        Me.colMessage.Name = "colMessage"
        Me.colMessage.ReadOnly = True
        Me.colMessage.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        '
        'UserName
        '
        Me.UserName.DataPropertyName = "UserName"
        resources.ApplyResources(Me.UserName, "UserName")
        Me.UserName.Name = "UserName"
        Me.UserName.ReadOnly = True
        '
        'UserId
        '
        Me.UserId.DataPropertyName = "UserId"
        resources.ApplyResources(Me.UserId, "UserId")
        Me.UserId.Name = "UserId"
        Me.UserId.ReadOnly = True
        '
        'UserState
        '
        Me.UserState.DataPropertyName = "UserState"
        resources.ApplyResources(Me.UserState, "UserState")
        Me.UserState.Name = "UserState"
        Me.UserState.ReadOnly = True
        '
        'PCName
        '
        Me.PCName.DataPropertyName = "PCName"
        resources.ApplyResources(Me.PCName, "PCName")
        Me.PCName.Name = "PCName"
        Me.PCName.ReadOnly = True
        '
        'colCloseSession
        '
        Me.colCloseSession.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        Me.colCloseSession.FillWeight = 97.46193!
        resources.ApplyResources(Me.colCloseSession, "colCloseSession")
        Me.colCloseSession.Name = "colCloseSession"
        Me.colCloseSession.ReadOnly = True
        Me.colCloseSession.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
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
        'panelHowToFilter
        '
        Me.panelHowToFilter.Controls.Add(Me.lblHowToFilter)
        resources.ApplyResources(Me.panelHowToFilter, "panelHowToFilter")
        Me.panelHowToFilter.Name = "panelHowToFilter"
        '
        'lblHowToFilter
        '
        resources.ApplyResources(Me.lblHowToFilter, "lblHowToFilter")
        Me.lblHowToFilter.Name = "lblHowToFilter"
        '
        'panelUsersTop
        '
        Me.panelUsersTop.Controls.Add(Me.txtFilter)
        Me.panelUsersTop.Controls.Add(Me.lblUserFilter)
        resources.ApplyResources(Me.panelUsersTop, "panelUsersTop")
        Me.panelUsersTop.Name = "panelUsersTop"
        '
        'txtFilter
        '
        resources.ApplyResources(Me.txtFilter, "txtFilter")
        Me.txtFilter.Name = "txtFilter"
        '
        'lblUserFilter
        '
        resources.ApplyResources(Me.lblUserFilter, "lblUserFilter")
        Me.lblUserFilter.Name = "lblUserFilter"
        '
        'userStatusStrip
        '
        Me.userStatusStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.userStatusLabel, Me.userRefreshProgessBar, Me.userRefreshCancelButton})
        resources.ApplyResources(Me.userStatusStrip, "userStatusStrip")
        Me.userStatusStrip.Name = "userStatusStrip"
        '
        'userStatusLabel
        '
        resources.ApplyResources(Me.userStatusLabel, "userStatusLabel")
        Me.userStatusLabel.Name = "userStatusLabel"
        '
        'userRefreshProgessBar
        '
        Me.userRefreshProgessBar.Name = "userRefreshProgessBar"
        resources.ApplyResources(Me.userRefreshProgessBar, "userRefreshProgessBar")
        '
        'userRefreshCancelButton
        '
        Me.userRefreshCancelButton.IsLink = True
        Me.userRefreshCancelButton.Name = "userRefreshCancelButton"
        resources.ApplyResources(Me.userRefreshCancelButton, "userRefreshCancelButton")
        '
        'panelRightTop
        '
        resources.ApplyResources(Me.panelRightTop, "panelRightTop")
        Me.panelRightTop.Controls.Add(Me.lblUsersPerServer)
        Me.panelRightTop.Controls.Add(Me.btnRefresh)
        Me.panelRightTop.Name = "panelRightTop"
        '
        'lblUsersPerServer
        '
        Me.lblUsersPerServer.BackColor = System.Drawing.Color.Transparent
        resources.ApplyResources(Me.lblUsersPerServer, "lblUsersPerServer")
        Me.lblUsersPerServer.ForeColor = System.Drawing.Color.White
        Me.lblUsersPerServer.Name = "lblUsersPerServer"
        '
        'btnRefresh
        '
        Me.btnRefresh.BackgroundImage = Global.TSRemoteControl.My.Resources.images.refresh32
        resources.ApplyResources(Me.btnRefresh, "btnRefresh")
        Me.btnRefresh.Name = "btnRefresh"
        Me.toolTipsManager.SetToolTip(Me.btnRefresh, resources.GetString("btnRefresh.ToolTip"))
        Me.btnRefresh.UseVisualStyleBackColor = True
        '
        'listUsers
        '
        resources.ApplyResources(Me.listUsers, "listUsers")
        Me.listUsers.Name = "listUsers"
        Me.listUsers.UseCompatibleStateImageBehavior = False
        '
        'toolTipsManager
        '
        Me.toolTipsManager.IsBalloon = True
        '
        'TheMenuStrip
        '
        Me.TheMenuStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem, Me.HelpToolStripMenuItem})
        resources.ApplyResources(Me.TheMenuStrip, "TheMenuStrip")
        Me.TheMenuStrip.Name = "TheMenuStrip"
        '
        'FileToolStripMenuItem
        '
        Me.FileToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ImportServersFileToolStripMenuItem, Me.ExportServersFileToolStripMenuItem, Me.ExitToolStripMenuItem})
        Me.FileToolStripMenuItem.Name = "FileToolStripMenuItem"
        resources.ApplyResources(Me.FileToolStripMenuItem, "FileToolStripMenuItem")
        '
        'ImportServersFileToolStripMenuItem
        '
        Me.ImportServersFileToolStripMenuItem.Name = "ImportServersFileToolStripMenuItem"
        resources.ApplyResources(Me.ImportServersFileToolStripMenuItem, "ImportServersFileToolStripMenuItem")
        '
        'ExportServersFileToolStripMenuItem
        '
        Me.ExportServersFileToolStripMenuItem.Name = "ExportServersFileToolStripMenuItem"
        resources.ApplyResources(Me.ExportServersFileToolStripMenuItem, "ExportServersFileToolStripMenuItem")
        '
        'ExitToolStripMenuItem
        '
        Me.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem"
        resources.ApplyResources(Me.ExitToolStripMenuItem, "ExitToolStripMenuItem")
        '
        'HelpToolStripMenuItem
        '
        Me.HelpToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AboutThisApplicationToolStripMenuItem})
        Me.HelpToolStripMenuItem.Name = "HelpToolStripMenuItem"
        resources.ApplyResources(Me.HelpToolStripMenuItem, "HelpToolStripMenuItem")
        '
        'AboutThisApplicationToolStripMenuItem
        '
        Me.AboutThisApplicationToolStripMenuItem.Name = "AboutThisApplicationToolStripMenuItem"
        resources.ApplyResources(Me.AboutThisApplicationToolStripMenuItem, "AboutThisApplicationToolStripMenuItem")
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
        'dlgOpenFile
        '
        resources.ApplyResources(Me.dlgOpenFile, "dlgOpenFile")
        '
        'dlgSaveFile
        '
        resources.ApplyResources(Me.dlgSaveFile, "dlgSaveFile")
        '
        'frmMain
        '
        resources.ApplyResources(Me, "$this")
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.contentContainer)
        Me.Controls.Add(Me.TheMenuStrip)
        Me.Name = "frmMain"
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
        Me.panelHowToFilter.ResumeLayout(False)
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
    Friend WithEvents TheMenuStrip As MenuStrip
    Friend WithEvents FileToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ExitToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents HelpToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AboutThisApplicationToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ImportServersFileToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents dlgOpenFile As OpenFileDialog
    Friend WithEvents ExportServersFileToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents dlgSaveFile As SaveFileDialog
    Friend WithEvents colCloseSession As DataGridViewButtonColumn
    Friend WithEvents PCName As DataGridViewTextBoxColumn
    Friend WithEvents UserState As DataGridViewTextBoxColumn
    Friend WithEvents UserId As DataGridViewTextBoxColumn
    Friend WithEvents UserName As DataGridViewTextBoxColumn
    Friend WithEvents colMessage As DataGridViewButtonColumn
    Friend WithEvents TSName As DataGridViewTextBoxColumn
    Friend WithEvents colConnect As DataGridViewButtonColumn
    Friend WithEvents panelHowToFilter As Panel
    Friend WithEvents lblHowToFilter As Label
End Class
