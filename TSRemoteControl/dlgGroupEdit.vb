Public Class dlgGroupEdit

    Private mName As String
    Public ReadOnly Property GroupName As String
        Get
            Return mName.Trim()
        End Get
    End Property

    Private Sub dlgGroupEdit_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txtName.Text = mName
    End Sub

    Public Shadows Function ShowDialog(Optional ByVal groupName As String = "") As DialogResult
        mName = groupName
        MyBase.ShowDialog()
        Return Me.DialogResult
    End Function

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Me.DialogResult = Windows.Forms.DialogResult.Cancel
        Me.Close()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnAccept.Click
        mName = txtName.Text.Trim
        Me.DialogResult = Windows.Forms.DialogResult.OK
        Me.Close()
    End Sub

End Class