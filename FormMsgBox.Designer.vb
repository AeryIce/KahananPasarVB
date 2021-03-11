<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormMsgBox
	Inherits System.Windows.Forms.Form

	'Form overrides dispose to clean up the component list.
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

	'Required by the Windows Form Designer
	Private components As System.ComponentModel.IContainer

	'NOTE: The following procedure is required by the Windows Form Designer
	'It can be modified using the Windows Form Designer.  
	'Do not modify it using the code editor.
	<System.Diagnostics.DebuggerStepThrough()> _
	Private Sub InitializeComponent()
		Me.components = New System.ComponentModel.Container()
		Me.lbMsgbox = New System.Windows.Forms.Label()
		Me.timerMsgBox = New System.Windows.Forms.Timer(Me.components)
		Me.SuspendLayout()
		'
		'lbMsgbox
		'
		Me.lbMsgbox.AutoSize = True
		Me.lbMsgbox.Location = New System.Drawing.Point(114, 21)
		Me.lbMsgbox.Name = "lbMsgbox"
		Me.lbMsgbox.Size = New System.Drawing.Size(92, 13)
		Me.lbMsgbox.TabIndex = 0
		Me.lbMsgbox.Text = "Process Complete"
		'
		'timerMsgBox
		'
		Me.timerMsgBox.Interval = 1000
		'
		'FormMsgBox
		'
		Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.BackColor = System.Drawing.Color.Aqua
		Me.ClientSize = New System.Drawing.Size(319, 56)
		Me.Controls.Add(Me.lbMsgbox)
		Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
		Me.Name = "FormMsgBox"
		Me.Opacity = 0.8R
		Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
		Me.Text = "FormMsgBox"
		Me.ResumeLayout(False)
		Me.PerformLayout()

	End Sub

	Friend WithEvents lbMsgbox As Label
	Friend WithEvents timerMsgBox As Timer
End Class
