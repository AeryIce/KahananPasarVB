Public Class FormMsgBox
	Private Sub FormMsgBox_Load(sender As Object, e As EventArgs) Handles MyBase.Load
		Me.timerMsgBox.Interval = 1000
		timerMsgBox.Start()
	End Sub

	Private Sub timerMsgBox_Tick(sender As Object, e As EventArgs) Handles timerMsgBox.Tick
		Me.Close()
	End Sub
End Class