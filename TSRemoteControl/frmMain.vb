Public Class frmMain

    Private Const GROUP_ID_CELL As Integer = 0
    Private Const GROUP_NAME_CELL As Integer = 1
    Private Const GROUP_EDIT_CELL As Integer = 2
    Private Const GROUP_DELETE_CELL As Integer = 3

    Private Const SERVER_GROUPID_CELL As Integer = 0
    Private Const SERVER_ID_CELL As Integer = 1
    Private Const SERVER_NAME_CELL As Integer = 2
    Private Const SERVER_EDIT_CELL As Integer = 4
    Private Const SERVER_DELETE_CELL As Integer = 5

    Private Const USER_CONNECT_CELL As Integer = 0
    Private Const USER_CLOSE_SESSION As Integer = 7
    Private Const USER_MESSAGE As Integer = 2

    Private mUserList As List(Of UserInfo)

    Public Sub New()

        ' Llamada necesaria para el diseñador.
        InitializeComponent()

        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().
    End Sub


#Region "Groups Grid"

    Private Sub dgwGroups_RowValidating(sender As Object, e As DataGridViewCellCancelEventArgs) Handles dgwGroups.RowValidating
        'If the row We are editing does not have an Id, stablish one.
        If dgwGroups.Rows(e.RowIndex).Cells(GROUP_ID_CELL).Value Is Nothing _
            OrElse IsDBNull(dgwGroups.Rows(e.RowIndex).Cells(GROUP_ID_CELL).Value) Then
            dgwGroups.Rows(e.RowIndex).Cells(GROUP_ID_CELL).Value = System.Guid.NewGuid()
        End If
    End Sub

    Private Sub dgwGroups_SelectionChanged(sender As Object, e As EventArgs) Handles dgwGroups.SelectionChanged
        'Set the filter of the server binding to show only the servers in the selected group
        If dgwGroups.SelectedRows.Count > 0 Then
            bindingServersByGroup.Filter = String.Format("groupId='{0}'",
                                                         CType(GroupsBindingSource.Current.row, dsetGroupsAndServers.groupsRow).groupId)
        End If
    End Sub

    Private Sub dgwGroups_CellPainting(sender As Object, e As DataGridViewCellPaintingEventArgs) Handles dgwGroups.CellPainting
        If e.ColumnIndex = GROUP_EDIT_CELL OrElse e.ColumnIndex = GROUP_DELETE_CELL AndAlso e.RowIndex >= 0 Then
            e.Paint(e.CellBounds, DataGridViewPaintParts.All)
            Dim img As Image = Nothing
            Select Case e.ColumnIndex
                Case GROUP_EDIT_CELL
                    img = CType(My.Resources.images.edit32, Image)
                Case GROUP_DELETE_CELL
                    img = CType(My.Resources.images.delete32, Image)
            End Select

            If Not img Is Nothing Then
                e.Graphics.DrawImage(img, e.CellBounds.Left + 10, e.CellBounds.Top + 5, 10, 10)
                'e.Graphics.DrawImage(img, e.CellBounds.Left + 2, e.CellBounds.Top + 2, e.CellBounds.Width - 5, e.CellBounds.Height - 5)
                e.Handled = True

            End If
        End If
    End Sub

    Private Sub dgwGroups_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgwGroups.CellClick
        Dim hasToDeleteGroup As Boolean = False

        If e.ColumnIndex = GROUP_EDIT_CELL OrElse e.ColumnIndex = GROUP_DELETE_CELL AndAlso e.RowIndex >= 0 Then
            Select Case e.ColumnIndex
                Case GROUP_EDIT_CELL
                    Using dlg As New dlgGroupEdit()
                        If dlg.ShowDialog(dgwGroups.Rows(e.RowIndex).Cells(GROUP_NAME_CELL).Value) = Windows.Forms.DialogResult.OK Then
                            dgwGroups.Rows(e.RowIndex).Cells(GROUP_NAME_CELL).Value = dlg.GroupName
                        End If
                    End Using
                Case GROUP_DELETE_CELL
                    'Check if the group we are trying to delete has servers.
                    Dim numberOfServersInGroup = (From g In GroupsAndServersData.servers
                                                 Where g.groupId = dgwGroups.Rows(e.RowIndex).Cells(GROUP_ID_CELL).Value
                                                 Select g.serverId).Count
                    If numberOfServersInGroup > 1 Then
                        'The group has servers, ask the user if he really want to delete this group
                        If MsgBox("The group you're trying to delete has servers. Do you want to continue and delete the group?",
                                  MsgBoxStyle.YesNo Or MsgBoxStyle.Question,
                                  "Question") = MsgBoxResult.Yes Then
                            hasToDeleteGroup = True
                        Else
                            hasToDeleteGroup = False
                        End If
                    Else
                        'The group does not have servers, we delete the group
                        hasToDeleteGroup = True
                    End If

                    If hasToDeleteGroup Then
                        Dim serversToDelete = (From g In GroupsAndServersData.servers
                                               Where g.groupId = dgwGroups.Rows(e.RowIndex).Cells(GROUP_ID_CELL).Value
                                               Select g.serverId).ToList
                        For Each s In serversToDelete
                            GroupsAndServersData.servers.FindByserverId(s).Delete()
                        Next
                        GroupsAndServersData.groups.FindBygroupId(dgwGroups.Rows(e.RowIndex).Cells(GROUP_ID_CELL).Value).Delete()
                    End If

            End Select

        End If
    End Sub

#End Region

#Region "Servers Grid"

    Private Sub dgwServers_CellPainting(sender As Object, e As DataGridViewCellPaintingEventArgs) Handles dgwServers.CellPainting
        If e.ColumnIndex = SERVER_EDIT_CELL OrElse e.ColumnIndex = SERVER_DELETE_CELL AndAlso e.RowIndex >= 0 Then
            e.Paint(e.CellBounds, DataGridViewPaintParts.All)
            Dim img As Image = Nothing
            Select Case e.ColumnIndex
                Case SERVER_EDIT_CELL
                    img = CType(My.Resources.images.edit32, Image)
                Case SERVER_DELETE_CELL
                    img = CType(My.Resources.images.delete32, Image)
            End Select

            If Not img Is Nothing Then
                e.Graphics.DrawImage(img, e.CellBounds.Left + 10, e.CellBounds.Top + 5, 10, 10)
                'e.Graphics.DrawImage(img, e.CellBounds.Left + 2, e.CellBounds.Top + 2, e.CellBounds.Width - 5, e.CellBounds.Height - 5)
                e.Handled = True
            End If
        End If
    End Sub

    Private Sub dgwServers_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgwServers.CellClick
        If e.ColumnIndex = SERVER_EDIT_CELL OrElse e.ColumnIndex = SERVER_DELETE_CELL AndAlso e.RowIndex >= 0 Then
            Select Case e.ColumnIndex
                Case SERVER_EDIT_CELL
                    Dim sId = dgwServers.Rows(e.RowIndex).Cells(SERVER_ID_CELL).Value
                    Dim serverRow = GroupsAndServersData.servers.FindByserverId(sId)
                    If Not serverRow.DoNotTouch Then
                        Using dlg As New dlgServerEdit()
                            If dlg.ShowDialog(serverRow.serverName, serverRow.serverDisplayName) = Windows.Forms.DialogResult.OK Then
                                serverRow.serverName = dlg.ServerName
                                serverRow.serverDisplayName = dlg.ServerDisplayName
                            End If
                        End Using
                    End If
                Case SERVER_DELETE_CELL
                    Dim sId = dgwServers.Rows(e.RowIndex).Cells(SERVER_ID_CELL).Value
                    Dim serverRow = GroupsAndServersData.servers.FindByserverId(sId)
                    If Not serverRow.DoNotTouch Then
                        serverRow.Delete()
                    End If
            End Select
        End If
    End Sub

    Private Sub dgwServers_SelectionChanged(sender As Object, e As EventArgs) Handles dgwServers.SelectionChanged
        refreshUsers()
    End Sub

#End Region

#Region "Users Grid"

    Private Sub initializeUsersGrid()

        dgwUsers.AutoGenerateColumns = False
        dgwUsers.DataSource = UsersData.Users


        Dim colConnect As New DataGridViewButtonColumn()
        colConnect.AutoSizeMode = DataGridViewAutoSizeColumnMode.None
        'colConnect.DataPropertyName = "UserState"
        colConnect.DisplayIndex = 0
        colConnect.HeaderText = ""
        colConnect.MinimumWidth = 32
        colConnect.Width = 32
        colConnect.Name = "colConnect"
        colConnect.Resizable = DataGridViewTriState.False
        colConnect.Visible = True
        colConnect.ReadOnly = True
        colConnect.ToolTipText = "Connect to user session"
        dgwUsers.Columns.Add(colConnect)

        Dim colTSName As New DataGridViewTextBoxColumn()
        colTSName.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
        colTSName.DataPropertyName = "TSName"
        colTSName.DisplayIndex = 1
        colTSName.HeaderText = "Server"
        colTSName.Width = 100
        colTSName.Name = "TSName"
        colTSName.Resizable = DataGridViewTriState.False
        colTSName.Visible = True
        colTSName.ReadOnly = True
        colTSName.SortMode = DataGridViewColumnSortMode.Automatic
        dgwUsers.Columns.Add(colTSName)

        Dim colMessage As New DataGridViewButtonColumn()
        colMessage.AutoSizeMode = DataGridViewAutoSizeColumnMode.None
        colMessage.DisplayIndex = 2
        colMessage.HeaderText = ""
        colMessage.MinimumWidth = 32
        colMessage.Width = 32
        colMessage.Name = "colMessage"
        colMessage.Resizable = DataGridViewTriState.False
        colMessage.Visible = True
        colMessage.ReadOnly = True
        colMessage.ToolTipText = "Send a message to user"
        dgwUsers.Columns.Add(colMessage)

        Dim colTSUser As New DataGridViewTextBoxColumn()
        colTSUser.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
        colTSUser.DataPropertyName = "UserName"
        colTSUser.DisplayIndex = 3
        colTSUser.HeaderText = "User"
        colTSUser.Width = 100
        colTSUser.Name = "UserName"
        colTSUser.Resizable = DataGridViewTriState.False
        colTSUser.Visible = True
        colTSUser.ReadOnly = True
        colTSUser.SortMode = DataGridViewColumnSortMode.Automatic
        dgwUsers.Columns.Add(colTSUser)

        Dim colTSUserId As New DataGridViewTextBoxColumn()
        colTSUserId.AutoSizeMode = DataGridViewAutoSizeColumnMode.None
        colTSUserId.DataPropertyName = "UserId"
        colTSUserId.DisplayIndex = 4
        colTSUserId.HeaderText = "User ID"
        colTSUserId.MinimumWidth = 100
        colTSUserId.Width = 100
        colTSUserId.Name = "UserId"
        colTSUserId.Resizable = DataGridViewTriState.False
        colTSUserId.Visible = True
        colTSUserId.ReadOnly = True
        colTSUserId.SortMode = DataGridViewColumnSortMode.Automatic
        dgwUsers.Columns.Add(colTSUserId)

        Dim colPCName As New DataGridViewTextBoxColumn()
        colPCName.AutoSizeMode = DataGridViewAutoSizeColumnMode.None
        colPCName.DataPropertyName = "PCName"
        colPCName.DisplayIndex = 5
        colPCName.HeaderText = "Client PC"
        colPCName.MinimumWidth = 100
        colPCName.Width = 100
        colPCName.Name = "PCName"
        colPCName.Resizable = DataGridViewTriState.False
        colPCName.Visible = True
        colPCName.ReadOnly = True
        colPCName.SortMode = DataGridViewColumnSortMode.Automatic
        dgwUsers.Columns.Add(colPCName)

        Dim colUserState As New DataGridViewTextBoxColumn()
        colUserState.AutoSizeMode = DataGridViewAutoSizeColumnMode.None
        colUserState.DataPropertyName = "UserState"
        colUserState.DisplayIndex = 6
        colUserState.HeaderText = "State"
        colUserState.MinimumWidth = 100
        colUserState.Width = 100
        colUserState.Name = "UserState"
        colUserState.Resizable = DataGridViewTriState.False
        colUserState.Visible = True
        colUserState.ReadOnly = True
        colUserState.SortMode = DataGridViewColumnSortMode.Automatic
        dgwUsers.Columns.Add(colUserState)

        Dim colCloseSession As New DataGridViewButtonColumn()
        colCloseSession.AutoSizeMode = DataGridViewAutoSizeColumnMode.None
        colCloseSession.DisplayIndex = 7
        colCloseSession.HeaderText = ""
        colCloseSession.MinimumWidth = 32
        colCloseSession.Width = 32
        colCloseSession.Name = "colCloseSession"
        colCloseSession.Resizable = DataGridViewTriState.False
        colCloseSession.Visible = True
        colCloseSession.ReadOnly = True
        colCloseSession.ToolTipText = "Close user session"
        dgwUsers.Columns.Add(colCloseSession)

    End Sub

    Private Sub dgwUsers_CellPainting(sender As Object, e As DataGridViewCellPaintingEventArgs) Handles dgwUsers.CellPainting
        If e.ColumnIndex = USER_CONNECT_CELL AndAlso e.RowIndex >= 0 Then
            e.Paint(e.CellBounds, DataGridViewPaintParts.All)
            Dim img As Image = Nothing
            img = CType(My.Resources.images.screen32, Image)

            If Not img Is Nothing Then
                'e.Graphics.DrawImage(img, e.CellBounds.Left + 10, e.CellBounds.Top + 5, 10, 10)
                e.Graphics.DrawImage(img, e.CellBounds.Left + 2, e.CellBounds.Top + 2, e.CellBounds.Width - 5, e.CellBounds.Height - 5)
                e.Handled = True
            End If
        End If

        If e.ColumnIndex = USER_MESSAGE Then
            e.Paint(e.CellBounds, DataGridViewPaintParts.All)
            Dim img As Image = Nothing
            If e.RowIndex >= 0 Then
                img = CType(My.Resources.images.message32, Image)
            Else
                img = CType(My.Resources.images.messageBlue32, Image)
            End If
            If Not img Is Nothing Then
                e.Graphics.DrawImage(img, e.CellBounds.Left + 2, e.CellBounds.Top + 2, e.CellBounds.Width - 5, e.CellBounds.Height - 5)
                e.Handled = True
            End If
        End If

        If e.ColumnIndex = USER_CLOSE_SESSION AndAlso e.RowIndex >= 0 Then
            e.Paint(e.CellBounds, DataGridViewPaintParts.All)
            Dim img As Image = Nothing
            img = CType(My.Resources.images.delete32, Image)

            If Not img Is Nothing Then
                e.Graphics.DrawImage(img, e.CellBounds.Left + 10, e.CellBounds.Top + 5, 10, 10)
                e.Handled = True
            End If
        End If
    End Sub

    Private Sub dgwUsers_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgwUsers.CellClick
        Select Case e.ColumnIndex
            Case USER_CONNECT_CELL
                TerminalServerCommands.connectToTSUser(dgwUsers.Rows(e.RowIndex).Cells("TSName").Value,
                                       dgwUsers.Rows(e.RowIndex).Cells("UserId").Value)

            Case USER_CLOSE_SESSION
                If TerminalServerCommands.closeUserSession(dgwUsers.Rows(e.RowIndex).Cells("TSName").Value,
                                                        dgwUsers.Rows(e.RowIndex).Cells("UserId").Value) Then
                    MsgBox("Session terminated", MsgBoxStyle.OkOnly Or MsgBoxStyle.Information, "Message")
                    refreshUsers()
                End If
            Case USER_MESSAGE
                Using dlg As New dlgMessage()
                    If dlg.ShowDialog() = Windows.Forms.DialogResult.OK Then
                        If e.RowIndex >= 0 Then
                            TerminalServerCommands.sendMessageToUser(dgwUsers.Rows(e.RowIndex).Cells("TSName").Value,
                                                                     dgwUsers.Rows(e.RowIndex).Cells("UserId").Value,
                                                                     dlg.Message,
                                                                     dlg.Sender)
                        Else
                            sendMessageToAllUsers(UsersData, dlg.Message, dlg.Sender)
                            'For Each r In dgwUsers.Rows
                            '    TerminalServerCommands.sendMessageToUser(r.Cells("TSName").Value,
                            '                                             r.Cells("UserId").Value,
                            '                                             dlg.Message,
                            '                                             dlg.Sender)
                            'Next
                        End If
                    End If
                End Using

        End Select

    End Sub

    Private Function sendMessageToAllUsers(data As dsetUsers, messageText As String, messageSender As String) As Boolean
        Dim tmpDicList As New Dictionary(Of String, List(Of Integer))
        Dim retVal As Boolean

        Try
            'Get each Terminal server with at least an entry in our list of users
            Dim terminalServerList = (From t In data.Users
                                     Select t.TSName).Distinct().ToList()

            For Each terminal In terminalServerList
                Dim listOfUsers = (From u In data.Users
                                 Select u.UserId).ToList()
                tmpDicList.Add(terminal, listOfUsers)
            Next

            retVal = TerminalServerCommands.sendMessageToUser(tmpDicList, messageText, messageSender)
        Catch ex As Exception
            retVal = False
        End Try
       
        Return retVal
    End Function

#End Region

    Private Sub btnAddGroup_Click(sender As Object, e As EventArgs) Handles btnAddGroup.Click
        Using dlgGroup As New dlgGroupEdit()
            If dlgGroup.ShowDialog() = Windows.Forms.DialogResult.OK Then
                Dim gRow = GroupsAndServersData.groups.AddgroupsRow(System.Guid.NewGuid(), dlgGroup.GroupName)
                'When We add a group, We automatically add a server entry to represent all the servers in the group
                GroupsAndServersData.servers.AddserversRow(gRow, System.Guid.NewGuid(), "", "<ALL SERVERS>", True)
            End If
        End Using
    End Sub

    Private Sub btnAddServer_Click(sender As Object, e As EventArgs) Handles btnAddServer.Click
        Using dlgServer As New dlgServerEdit()
            If dlgServer.ShowDialog() = Windows.Forms.DialogResult.OK Then
                Dim groupRow = GroupsAndServersData.groups.FindBygroupId(CType(GroupsBindingSource.Current.row, 
                                                                         dsetGroupsAndServers.groupsRow).groupId)
                GroupsAndServersData.servers.AddserversRow(groupRow,
                                                           System.Guid.NewGuid(),
                                                           dlgServer.ServerName,
                                                           dlgServer.ServerDisplayName,
                                                           False)
            End If
        End Using
    End Sub

    Private Sub frmMain_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        'Save the configuration to a XML file
        GroupsAndServersData.WriteXml(My.Computer.FileSystem.SpecialDirectories.MyDocuments & "\TSRemoteControl.config")
    End Sub

    Private Sub frmMain_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        If System.IO.File.Exists(My.Computer.FileSystem.SpecialDirectories.MyDocuments & "\TSRemoteControl.config") Then
            GroupsAndServersData.ReadXml(My.Computer.FileSystem.SpecialDirectories.MyDocuments & "\TSRemoteControl.config")
        End If

        initializeUsersGrid()
    End Sub

    Private Sub timerUserRefresh_Tick(sender As Object, e As EventArgs) Handles timerUserRefresh.Tick
        refreshUsers()
    End Sub

    Private Sub refreshUsers()
        For Each r In dgwServers.SelectedRows
            If Not mUserList Is Nothing Then
                mUserList.Clear()
            End If
            mUserList = TerminalServerCommands.getActiveUsers(GroupsAndServersData,
                                                              r.cells(SERVER_GROUPID_CELL).VALUE,
                                                              r.cells(SERVER_NAME_CELL).value)

            UsersData.Clear()
            For Each user In mUserList
                UsersData.Users.AddUsersRow(user.TSName, user.UserName, user.UserId, user.UserState, user.PCName)
            Next
            'dgwUsers.DataSource = mUserList
        Next
    End Sub

    Private Sub btnRefresh_Click(sender As Object, e As EventArgs) Handles btnRefresh.Click
        refreshUsers()
    End Sub

End Class
