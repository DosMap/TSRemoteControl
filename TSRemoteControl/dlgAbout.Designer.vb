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
        Me.lblLink = New System.Windows.Forms.LinkLabel()
        Me.lblApplicationName = New System.Windows.Forms.Label()
        Me.lblText = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'lblLink
        '
        Me.lblLink.AutoSize = True
        Me.lblLink.Location = New System.Drawing.Point(28, 107)
        Me.lblLink.Name = "lblLink"
        Me.lblLink.Size = New System.Drawing.Size(229, 13)
        Me.lblLink.TabIndex = 0
        Me.lblLink.TabStop = True
        Me.lblLink.Text = "https://github.com/DosMap/TSRemoteControl"
        '
        'lblApplicationName
        '
        Me.lblApplicationName.AutoSize = True
        Me.lblApplicationName.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblApplicationName.Location = New System.Drawing.Point(19, 13)
        Me.lblApplicationName.Name = "lblApplicationName"
        Me.lblApplicationName.Size = New System.Drawing.Size(247, 31)
        Me.lblApplicationName.TabIndex = 1
        Me.lblApplicationName.Text = "TSRemoteControl"
        '
        'lblText
        '
        Me.lblText.AutoSize = True
        Me.lblText.Location = New System.Drawing.Point(5, 63)
        Me.lblText.Name = "lblText"
        Me.lblText.Size = New System.Drawing.Size(274, 13)
        Me.lblText.TabIndex = 2
        Me.lblText.Text = "All the information about this application can be found at:"
        '
        'dlgAbout
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 141)
        Me.Controls.Add(Me.lblText)
        Me.Controls.Add(Me.lblApplicationName)
        Me.Controls.Add(Me.lblLink)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "dlgAbout"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "About this application"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblLink As LinkLabel
    Friend WithEvents lblApplicationName As Label
    Friend WithEvents lblText As Label
End Class
