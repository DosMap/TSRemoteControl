Public Class TerminalServerCommands

    Private Const MAX_TIMEOUT_TO_CONNECT As Integer = 15


    Public Shared Function getActiveUsers(ByRef data As dsetGroupsAndServers,
                                          ByVal groupID As Guid,
                                          ByVal serverName As String,
                                          ByRef bgWorker As System.ComponentModel.BackgroundWorker) As List(Of UserInfo)
        If serverName = String.Empty Then
            Return getActiverUsersInGroup(data, groupID, bgWorker)
        Else
            Return getActiveUsersInTerminalServer(serverName)
        End If
    End Function

    Private Shared Function getActiverUsersInGroup(ByRef data As dsetGroupsAndServers,
                                                   ByVal groupID As Guid,
                                                   ByRef bgWorker As System.ComponentModel.BackgroundWorker) As List(Of UserInfo)
        Dim userList As New List(Of UserInfo)

        Dim numberOfServers As Integer
        Dim iterationCounter As Integer = 0
        'Find all the servers in the group
        Dim servers = (
            From s In data.servers
            Where s.groupId = groupID And s.DoNotTouch = False
            Select s.serverName
            ).ToList()

        numberOfServers = servers.Count()
        For Each server In servers
            'Check if we must cancel de process
            If bgWorker.CancellationPending Then
                bgWorker.CancelAsync()
                Exit For
            End If

            Dim tmpUsers = getActiveUsersInTerminalServer(server)
            If Not tmpUsers Is Nothing AndAlso tmpUsers.Count > 0 Then
                userList.AddRange(tmpUsers.ToArray())
            End If

            iterationCounter = iterationCounter + 1
            bgWorker.ReportProgress(CInt((CDbl(iterationCounter) / CDbl(numberOfServers)) * 100))
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


    Public Shared Function sendMessageToUser(userLists As Dictionary(Of String, List(Of Integer)),
                                             messageText As String,
                                             messageSender As String) As Boolean
        Dim retVal As Boolean

        Try
            Dim manager As Cassia.ITerminalServicesManager = New Cassia.TerminalServicesManager()

            For Each tsUserList In userLists.AsEnumerable()

                Using server As Cassia.ITerminalServer = manager.GetRemoteServer(tsUserList.Key)
                    server.Open()

                    For Each user In tsUserList.Value
                        server.GetSession(user).MessageBox(messageText, messageSender)
                    Next

                    server.Close()
                End Using
            Next

        Catch ex As Exception
            retVal = False
        End Try

        Return retVal
    End Function

    Public Shared Function sendMessageToUser(ByVal tsName As String,
                                             ByVal userId As Integer,
                                             ByVal messageText As String,
                                             ByVal messageSender As String) As Boolean
        Dim retVal As Boolean

        Try
            Dim tmpDicList As New Dictionary(Of String, List(Of Integer))
            Dim tmpList As New List(Of Integer)
            tmpList.Add(userId)
            tmpDicList.Add(tsName, tmpList)

            Return sendMessageToUser(tmpDicList, messageText, messageSender)


            'Dim manager As Cassia.ITerminalServicesManager = New Cassia.TerminalServicesManager()
            'Using server As Cassia.ITerminalServer = manager.GetRemoteServer(tsName)
            '    server.Open()

            '    server.GetSession(userId).MessageBox(messageText, messageSender)

            '    server.Close()
            'End Using
            'retVal = True
        Catch ex As Exception
            retVal = False
        End Try

        Return retVal
    End Function

    Public Shared Function ListProcessesOfUser(ByVal tsName As String, userId As Integer) As List(Of ProcessInfo)
        Dim manager As Cassia.ITerminalServicesManager = New Cassia.TerminalServicesManager()
        Dim processList As New List(Of ProcessInfo)

        Try
            Using server As Cassia.ITerminalServer = manager.GetRemoteServer(tsName)
                server.Open()

                Dim procList = server.GetSession(userId).GetProcesses()
                For Each proc In procList
                    processList.Add(New ProcessInfo(proc.Server.ServerName, proc.SessionId, proc.ProcessId, proc.ProcessName))
                Next
                server.Close()
            End Using

        Catch ex As Exception
            MsgBox(My.Resources.GenericStrings.getProcessError, MsgBoxStyle.Exclamation, My.Resources.GenericStrings.errorText)
        End Try

        Return processList
    End Function

    Public Shared Function KillProcess(ByVal tsName As String, sessionId As Integer, processId As Integer) As Boolean
        Dim manager As Cassia.ITerminalServicesManager = New Cassia.TerminalServicesManager()
        Dim result As Boolean = False

        Try
            Using server As Cassia.ITerminalServer = manager.GetRemoteServer(tsName)
                server.Open()

                server.GetProcess(processId).Kill()

                server.Close()
            End Using
            result = True
        Catch ex As Exception
            result = False
        End Try

        Return result
    End Function


End Class
