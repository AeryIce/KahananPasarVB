Public Class FormDashboard


	Private Sub FormDashboard_Load(sender As Object, e As EventArgs) Handles MyBase.Load
		cbMonth.Items.Add("Januari")
	End Sub
	Private Sub btClose_Click(sender As Object, e As EventArgs) Handles btClose.Click
		Me.Close()
	End Sub


End Class
