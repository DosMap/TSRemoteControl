Public Class ProcessInfo

    Public Server As String
    Public SessionId As Integer
    Public ProcessId As Integer
    Public ProcessName As String

    Public Sub New()
        Server = String.Empty
        SessionId = 0
        ProcessId = 0
        ProcessName = String.Empty
    End Sub

    Public Sub New(ByVal pServer As String,
                   ByVal pSessionId As Integer,
                   ByVal pProcessId As Integer,
                   ByVal pProcessName As String)
        Server = pServer
        SessionId = pSessionId
        ProcessId = pProcessId
        ProcessName = pProcessName
    End Sub

End Class
