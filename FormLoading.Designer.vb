<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FormLoading
	Inherits System.Windows.Forms.Form

	'Form overrides dispose to clean up the component list.
	<System.Diagnostics.DebuggerNonUserCode()>
	Protected Overrides Sub Dispose(ByVal disposing As Boolean)
		Try
			If disposing AndAlso components IsNot Nothing Then
				components.Dispose()
			End If
		Finally
			MyBase.Dispose(disposing)
		End Try
	End Sub

	'Required by the Windows Form Designer
	Private components As System.ComponentModel.IContainer

	'NOTE: The following procedure is required by the Windows Form Designer
	'It can be modified using the Windows Form Designer.  
	'Do not modify it using the code editor.
	<System.Diagnostics.DebuggerStepThrough()>
	Private Sub InitializeComponent()
		Me.components = New System.ComponentModel.Container()
		Me.gbProgressBar = New System.Windows.Forms.GroupBox()
		Me.lbAnalyze = New System.Windows.Forms.Label()
		Me.pbLoading = New System.Windows.Forms.ProgressBar()
		Me.timerProgressBar = New System.Windows.Forms.Timer(Me.components)
		Me.timerlbAnalyze = New System.Windows.Forms.Timer(Me.components)
		Me.timerCloseWindows = New System.Windows.Forms.Timer(Me.components)
		Me.gbProgressBar.SuspendLayout()
		Me.SuspendLayout()
		'
		'gbProgressBar
		'
		Me.gbProgressBar.Controls.Add(Me.lbAnalyze)
		Me.gbProgressBar.Controls.Add(Me.pbLoading)
		Me.gbProgressBar.FlatStyle = System.Windows.Forms.FlatStyle.Popup
		Me.gbProgressBar.Location = New System.Drawing.Point(12, 6)
		Me.gbProgressBar.Name = "gbProgressBar"
		Me.gbProgressBar.Size = New System.Drawing.Size(365, 85)
		Me.gbProgressBar.TabIndex = 0
		Me.gbProgressBar.TabStop = False
		'
		'lbAnalyze
		'
		Me.lbAnalyze.AutoSize = True
		Me.lbAnalyze.Location = New System.Drawing.Point(7, 20)
		Me.lbAnalyze.Name = "lbAnalyze"
		Me.lbAnalyze.Size = New System.Drawing.Size(53, 13)
		Me.lbAnalyze.TabIndex = 1
		Me.lbAnalyze.Text = "Analyze..."
		'
		'pbLoading
		'
		Me.pbLoading.Location = New System.Drawing.Point(6, 45)
		Me.pbLoading.Minimum = 10
		Me.pbLoading.Name = "pbLoading"
		Me.pbLoading.Size = New System.Drawing.Size(341, 23)
		Me.pbLoading.TabIndex = 0
		Me.pbLoading.Value = 10
		'
		'timerProgressBar
		'
		'
		'timerlbAnalyze
		'
		Me.timerlbAnalyze.Interval = 500
		'
		'timerCloseWindows
		'
		'
		'FormLoading
		'
		Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.BackColor = System.Drawing.Color.LightBlue
		Me.ClientSize = New System.Drawing.Size(390, 104)
		Me.Controls.Add(Me.gbProgressBar)
		Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
		Me.Name = "FormLoading"
		Me.Opacity = 0.8R
		Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
		Me.Text = "FormLoading"
		Me.gbProgressBar.ResumeLayout(False)
		Me.gbProgressBar.PerformLayout()
		Me.ResumeLayout(False)

	End Sub

	Friend WithEvents gbProgressBar As GroupBox
	Friend WithEvents lbAnalyze As Label
	Friend WithEvents pbLoading As ProgressBar
	Friend WithEvents timerProgressBar As Timer
	Friend WithEvents timerlbAnalyze As Timer
	Friend WithEvents timerCloseWindows As Timer
End Class
