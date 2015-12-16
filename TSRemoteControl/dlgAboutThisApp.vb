Public NotInheritable Class dlgAboutThisApp

    Private Sub dlgAboutThisApp_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        Dim ApplicationTitle As String
        If My.Application.Info.Title <> "" Then
            ApplicationTitle = My.Application.Info.Title
        Else
            ApplicationTitle = System.IO.Path.GetFileNameWithoutExtension(My.Application.Info.AssemblyName)
        End If
        Me.Text = String.Format(My.Resources.dlgAboutThisApp_strings.about, ApplicationTitle)
        Me.LabelProductName.Text = My.Application.Info.ProductName
        Me.LabelVersion.Text = String.Format(My.Resources.dlgAboutThisApp_strings.version, My.Application.Info.Version.ToString)
        Me.LabelCopyright.Text = My.Application.Info.Copyright
        Me.TextBoxDescription.Text = My.Resources.dlgAboutThisApp_strings.description
    End Sub

    Private Sub OKButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OKButton.Click
        Me.Close()
    End Sub

    Private Sub linkToProject_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles linkToProject.LinkClicked
        Process.Start("https://github.com/DosMap/TSRemoteControl")
    End Sub
End Class
