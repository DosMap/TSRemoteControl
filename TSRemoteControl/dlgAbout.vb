Public Class dlgAbout
    Private Sub lblLink_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles lblLink.LinkClicked
        Process.Start("https://github.com/DosMap/TSRemoteControl")
    End Sub

End Class