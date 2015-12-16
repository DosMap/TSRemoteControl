<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class dlgAbout
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(dlgAbout))
        Me.lblLink = New System.Windows.Forms.LinkLabel()
        Me.lblApplicationName = New System.Windows.Forms.Label()
        Me.lblText = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'lblLink
        '
        resources.ApplyResources(Me.lblLink, "lblLink")
        Me.lblLink.Name = "lblLink"
        Me.lblLink.TabStop = True
        '
        'lblApplicationName
        '
        resources.ApplyResources(Me.lblApplicationName, "lblApplicationName")
        Me.lblApplicationName.Name = "lblApplicationName"
        '
        'lblText
        '
        resources.ApplyResources(Me.lblText, "lblText")
        Me.lblText.Name = "lblText"
        '
        'dlgAbout
        '
        resources.ApplyResources(Me, "$this")
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.lblText)
        Me.Controls.Add(Me.lblApplicationName)
        Me.Controls.Add(Me.lblLink)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "dlgAbout"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblLink As LinkLabel
    Friend WithEvents lblApplicationName As Label
    Friend WithEvents lblText As Label
End Class
