Public Class dlgTasks

    Private mUser As Integer
    Private mServer As String

    Public Sub New(pServer As String, pUser As Integer)

        ' Esta llamada es exigida por el diseñador.
        InitializeComponent()

        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().
        mServer = pServer
        mUser = pUser
    End Sub

    Private Sub dlgTasks_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim processList As List(Of ProcessInfo)
        processList = TerminalServerCommands.ListProcessesOfUser(mServer, mUser)
        For Each proc In processList
            TasksData.tasks.AddtasksRow(proc.Server, proc.SessionId, proc.ProcessId, proc.ProcessName)
        Next
    End Sub

    Private Sub btnKillTask_Click(sender As Object, e As EventArgs) Handles btnKillTask.Click
        Select Case dgvTasks.SelectedRows.Count
            Case 0
            Case 1
                If MsgBox(String.Format(My.Resources.dlgTasks_strings.killTask, dgvTasks.SelectedRows(0).Cells("ProcessName").Value),
                          MsgBoxStyle.YesNo) Then
                    TerminalServerCommands.KillProcess(dgvTasks.SelectedRows(0).Cells("Server").Value,
                                                       dgvTasks.SelectedRows(0).Cells("SessionId").Value,
                                                       dgvTasks.SelectedRows(0).Cells("ProcessId").Value)
                End If
            Case Else
        End Select

    End Sub

End Class