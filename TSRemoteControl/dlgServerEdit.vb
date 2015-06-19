Public Class dlgServerEdit

    Private mServerName As String
    Private mServerDisplayName As String

    Public ReadOnly Property ServerName As String
        Get
            Return mServerName.Trim()
        End Get
    End Property

    Public ReadOnly Property ServerDisplayName As String
        Get
            Return mServerDisplayName
        End Get
    End Property

    Private Sub dlgServerEdit_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txtName.Text = mServerName
        txtDisplayName.Text = mServerDisplayName
    End Sub

    Public Shadows Function ShowDialog(Optional ByVal serverName As String = "",
                                       Optional ByVal serverDisplayName As String = "") As DialogResult
        mServerName = serverName
        mServerDisplayName = serverDisplayName
        MyBase.ShowDialog()
        Return Me.DialogResult
    End Function

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Me.DialogResult = Windows.Forms.DialogResult.Cancel
        Me.Close()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnAccept.Click
        mServerName = txtName.Text.Trim()
        mServerDisplayName = txtDisplayName.Text.Trim()
        Me.DialogResult = Windows.Forms.DialogResult.OK
        Me.Close()
    End Sub

End Class