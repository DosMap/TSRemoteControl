<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class dlgTasks
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
        Me.dgvTasks = New System.Windows.Forms.DataGridView()
        Me.ServerDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SessionDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ProcessIdDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ProcessNameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TasksData = New TSRemoteControl.dsTasks()
        Me.btnKillTask = New System.Windows.Forms.Button()
        CType(Me.dgvTasks, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TasksData, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dgvTasks
        '
        Me.dgvTasks.AllowUserToAddRows = False
        Me.dgvTasks.AllowUserToDeleteRows = False
        Me.dgvTasks.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgvTasks.AutoGenerateColumns = False
        Me.dgvTasks.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvTasks.BackgroundColor = System.Drawing.Color.White
        Me.dgvTasks.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvTasks.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.ServerDataGridViewTextBoxColumn, Me.SessionDataGridViewTextBoxColumn, Me.ProcessIdDataGridViewTextBoxColumn, Me.ProcessNameDataGridViewTextBoxColumn})
        Me.dgvTasks.DataMember = "tasks"
        Me.dgvTasks.DataSource = Me.TasksData
        Me.dgvTasks.Location = New System.Drawing.Point(12, 12)
        Me.dgvTasks.Name = "dgvTasks"
        Me.dgvTasks.ReadOnly = True
        Me.dgvTasks.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvTasks.Size = New System.Drawing.Size(460, 308)
        Me.dgvTasks.TabIndex = 0
        '
        'ServerDataGridViewTextBoxColumn
        '
        Me.ServerDataGridViewTextBoxColumn.DataPropertyName = "Server"
        Me.ServerDataGridViewTextBoxColumn.HeaderText = "Server"
        Me.ServerDataGridViewTextBoxColumn.Name = "ServerDataGridViewTextBoxColumn"
        Me.ServerDataGridViewTextBoxColumn.ReadOnly = True
        '
        'SessionDataGridViewTextBoxColumn
        '
        Me.SessionDataGridViewTextBoxColumn.DataPropertyName = "Session"
        Me.SessionDataGridViewTextBoxColumn.HeaderText = "Session"
        Me.SessionDataGridViewTextBoxColumn.Name = "SessionDataGridViewTextBoxColumn"
        Me.SessionDataGridViewTextBoxColumn.ReadOnly = True
        '
        'ProcessIdDataGridViewTextBoxColumn
        '
        Me.ProcessIdDataGridViewTextBoxColumn.DataPropertyName = "ProcessId"
        Me.ProcessIdDataGridViewTextBoxColumn.HeaderText = "ProcessId"
        Me.ProcessIdDataGridViewTextBoxColumn.Name = "ProcessIdDataGridViewTextBoxColumn"
        Me.ProcessIdDataGridViewTextBoxColumn.ReadOnly = True
        '
        'ProcessNameDataGridViewTextBoxColumn
        '
        Me.ProcessNameDataGridViewTextBoxColumn.DataPropertyName = "ProcessName"
        Me.ProcessNameDataGridViewTextBoxColumn.HeaderText = "ProcessName"
        Me.ProcessNameDataGridViewTextBoxColumn.Name = "ProcessNameDataGridViewTextBoxColumn"
        Me.ProcessNameDataGridViewTextBoxColumn.ReadOnly = True
        '
        'TasksData
        '
        Me.TasksData.DataSetName = "dsTasks"
        Me.TasksData.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'btnKillTask
        '
        Me.btnKillTask.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnKillTask.Location = New System.Drawing.Point(397, 326)
        Me.btnKillTask.Name = "btnKillTask"
        Me.btnKillTask.Size = New System.Drawing.Size(75, 23)
        Me.btnKillTask.TabIndex = 1
        Me.btnKillTask.Text = "Kill task(s)"
        Me.btnKillTask.UseVisualStyleBackColor = True
        '
        'dlgTasks
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(484, 361)
        Me.Controls.Add(Me.btnKillTask)
        Me.Controls.Add(Me.dgvTasks)
        Me.Name = "dlgTasks"
        Me.Text = "Tasks manager"
        CType(Me.dgvTasks, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TasksData, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents dgvTasks As DataGridView
    Friend WithEvents TasksData As dsTasks
    Friend WithEvents ServerDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents SessionDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ProcessIdDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ProcessNameDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents btnKillTask As Button
End Class
