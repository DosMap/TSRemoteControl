Public Class dlgMessage

    Private Sub dlgMessage_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txtSender.Text = My.User.Name
    End Sub


    Public ReadOnly Property Sender As String
        Get
            Return txtSender.Text.Trim
        End Get
    End Property

    Public ReadOnly Property Message As String
        Get
            Return txtMessage.Text.Trim
        End Get
    End Property

    Public Shadows Function ShowDialog() As DialogResult
        MyBase.ShowDialog()
        Return Me.DialogResult
    End Function


    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Me.DialogResult = Windows.Forms.DialogResult.Cancel
        Me.Close()
    End Sub


    Private Sub btnOK_Click(sender As Object, e As EventArgs) Handles btnOK.Click
        Me.DialogResult = Windows.Forms.DialogResult.OK
        Me.Close()
    End Sub

End Class