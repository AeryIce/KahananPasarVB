Public Class FormLoading


	Private Sub FormLoading_Load(sender As Object, e As EventArgs) Handles MyBase.Load
		timerProgressBar.Start()
		timerlbAnalyze.Start()
		timerCloseWindows.Interval = 2000


	End Sub
	Private Sub timerProgressBar_Tick(sender As Object, e As EventArgs) Handles timerProgressBar.Tick
		If pbLoading.Value < 100 Then
			pbLoading.Value += 2
		Else

			If timerProgressBar.Interval < 200 Then

				FormMsgBox.Show()
			Else
				FormMsgBox.Close()


			End If
			timerProgressBar.Stop()
			timerCloseWindows.Start()

		End If



		'Me.Close()
		'timerProgressBar.Interval = 100
		'timerProgressBar.Start()

		'If timerProgressBar.Interval < 200 Then
		'	Me.Show()
		'Else
		'	Me.Close()
		'	timerProgressBar.Stop()
		'End If

	End Sub

	Private Sub timerlbAnalyze_Tick(sender As Object, e As EventArgs) Handles timerlbAnalyze.Tick
		lbAnalyze.Visible = Not lbAnalyze.Visible
	End Sub

	Private Sub timerCloseWindows_Tick(sender As Object, e As EventArgs) Handles timerCloseWindows.Tick
		Me.Close()
	End Sub


End Class