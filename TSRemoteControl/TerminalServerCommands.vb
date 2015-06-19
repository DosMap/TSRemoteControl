Public Class TerminalServerCommands

    Private Const MAX_TIMEOUT_TO_CONNECT As Integer = 15


    Public Shared Function getActiveUsers(ByRef data As dsetGroupsAndServers,
                                          ByVal groupID As Guid,
                                          ByVal serverName As String) As List(Of UserInfo)
        If serverName = String.Empty Then
            Return getActiverUsersInGroup(data, groupID)
        Else
            Return getActiveUsersInTerminalServer(serverName)
        End If
    End Function

    Private Shared Function getActiverUsersInGroup(ByRef data As dsetGroupsAndServers,
                                                   ByVal groupID As Guid) As List(Of UserInfo)
        Dim userList As New List(Of UserInfo)

        'Find all the servers in the group
        Dim servers = (
            From s In data.servers
            Where s.groupId = groupID And s.DoNotTouch = False
            Select s.serverName
            ).ToList()

        For Each server In servers
            Dim tmpUsers = getActiveUsersInTerminalServer(server)
            If Not tmpUsers Is Nothing AndAlso tmpUsers.Count > 0 Then
                userList.AddRange(tmpUsers.ToArray())
            End If
        Next

        Return userList
    End Function

    Private Shared Function getActiveUsersInTerminalServer(ByVal tsName As String) As List(Of UserInfo)
        Dim resultList As New List(Of UserInfo)
        Dim strProcessResult As String = String.Empty
        Dim uInfo As UserInfo

        Try
            Dim manager As Cassia.ITerminalServicesManager = New Cassia.TerminalServicesManager()
            Using server As Cassia.ITerminalServer = manager.GetRemoteServer(tsName)
                server.Open()
                For Each session In server.GetSessions()
                    If session.UserName.Trim() <> String.Empty Then
                        uInfo = New UserInfo(session.UserName, session.SessionId, session.ClientName, session.ConnectionState.ToString(), tsName)
                        resultList.Add(uInfo)
                    End If
                Next
                server.Close()
            End Using

        Catch ex As Exception
            resultList.Clear()
        End Try

        Return resultList
    End Function

    Public Shared Function connectToTSUser(ByVal tsName As String, userId As Integer) As Boolean
        Dim retVal As Boolean

        Try
            Dim cmd As String = String.Format("mstsc /v:{0} /shadow:{1} /control /noconsentprompt", tsName, userId)
            Shell(cmd, AppWinStyle.Hide, True, MAX_TIMEOUT_TO_CONNECT)
            retVal = True
        Catch ex As Exception
            retVal = False
        End Try

        Return retVal
    End Function

    Public Shared Function closeUserSession(ByVal tsName As String, userId As Integer) As Boolean
        Dim retVal As Boolean

        Try
            Dim manager As Cassia.ITerminalServicesManager = New Cassia.TerminalServicesManager()
            Using server As Cassia.ITerminalServer = manager.GetRemoteServer(tsName)
                server.Open()

                server.GetSession(userId).Logoff()

                server.Close()
            End Using
            retVal = True
        Catch ex As Exception
            retVal = False
        End Try

        Return retVal
    End Function


    Public Shared Function sendMessageToUser(ByVal tsName As String, userId As Integer, messageText As String, messageSender As String) As Boolean
        Dim retVal As Boolean

        Try
            Dim manager As Cassia.ITerminalServicesManager = New Cassia.TerminalServicesManager()
            Using server As Cassia.ITerminalServer = manager.GetRemoteServer(tsName)
                server.Open()

                server.GetSession(userId).MessageBox(messageText, messageSender)

                server.Close()
            End Using
            retVal = True
        Catch ex As Exception
            retVal = False
        End Try

        Return retVal
    End Function

End Class
