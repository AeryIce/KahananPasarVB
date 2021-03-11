Imports System.Data.SqlClient
Public Class FormDashboard

	Public Conn As SqlConnection
	Public Cmd As SqlCommand
	Public Dr As SqlDataReader
	Public Da As SqlDataAdapter
	Public Ds As DataSet

	Sub Konek()
		FormLoading.Show()
		FormLoading.lbAnalyze.Text = "Connecting..."
		Try
			Conn = New SqlConnection("Data Source = AERYICE-PC666\SQLEXPRESS; Initial Catalog = PIKABUK; Integrated Security = True")
			Conn.Open()

			FormMsgBox.lbMsgbox.Text = "Connected To Database"


		Catch ex As Exception
			FormMsgBox.lbMsgbox.Text = "Connection Failed!!"
		End Try

	End Sub
	Private Sub FormDashboard_Load(sender As Object, e As EventArgs) Handles MyBase.Load

		cbMonth.Visible = False
		cbStartMonth.Visible = False
		CbEndMonth.Visible = False
		lbPilihStartMonth.Visible = False
		lbEndMonth.Visible = False
		cbMonth.Items.Add("Januari")
		cbMonth.Items.Add("Februari")
		cbMonth.Items.Add("Maret")
		cbMonth.Items.Add("April")
		cbMonth.Items.Add("Mei")
		cbMonth.Items.Add("Juni")
		cbMonth.Items.Add("Juli")
		cbMonth.Items.Add("Agustus")
		cbMonth.Items.Add("September")
		cbMonth.Items.Add("Oktober")
		cbMonth.Items.Add("November")
		cbMonth.Items.Add("Desember")

		cbStartMonth.Items.Add("Januari")
		cbStartMonth.Items.Add("Februari")
		cbStartMonth.Items.Add("Maret")
		cbStartMonth.Items.Add("April")
		cbStartMonth.Items.Add("Mei")
		cbStartMonth.Items.Add("Juni")
		cbStartMonth.Items.Add("Juli")
		cbStartMonth.Items.Add("Agustus")
		cbStartMonth.Items.Add("September")
		cbStartMonth.Items.Add("Oktober")
		cbStartMonth.Items.Add("November")
		cbStartMonth.Items.Add("Desember")

		CbEndMonth.Items.Add("Januari")
		CbEndMonth.Items.Add("Februari")
		CbEndMonth.Items.Add("Maret")
		CbEndMonth.Items.Add("April")
		CbEndMonth.Items.Add("Mei")
		CbEndMonth.Items.Add("Juni")
		CbEndMonth.Items.Add("Juli")
		CbEndMonth.Items.Add("Agustus")
		CbEndMonth.Items.Add("September")
		CbEndMonth.Items.Add("Oktober")
		CbEndMonth.Items.Add("November")
		CbEndMonth.Items.Add("Desember")
		Me.timerOpenConnection.Start()
		Me.timerOpenConnection.Interval = 1000



	End Sub
	Private Sub btClose_Click(sender As Object, e As EventArgs) Handles btClose.Click
		Me.Close()
	End Sub

	Private Sub rbMonth_CheckedChanged(sender As Object, e As EventArgs) Handles rbMonth.CheckedChanged
		cbMonth.Visible = True
		cbStartMonth.Visible = False
		CbEndMonth.Visible = False
		lbPilihStartMonth.Visible = True
		lbPilihStartMonth.Text = "Pilih Bulan"
		lbEndMonth.Visible = False


	End Sub

	Private Sub rbAll_CheckedChanged(sender As Object, e As EventArgs) Handles rbAll.CheckedChanged
		cbMonth.Visible = False
		cbStartMonth.Visible = False
		CbEndMonth.Visible = False
		lbPilihStartMonth.Visible = False
		lbEndMonth.Visible = False
		cbMonth.Text = ""
		cbStartMonth.Text = ""
		CbEndMonth.Text = ""


	End Sub

	Private Sub rbInterval_CheckedChanged(sender As Object, e As EventArgs) Handles rbInterval.CheckedChanged
		cbMonth.Visible = False
		cbStartMonth.Visible = True
		CbEndMonth.Visible = True
		lbPilihStartMonth.Visible = True
		lbPilihStartMonth.Text = "Start"
		lbEndMonth.Visible = True
		lbEndMonth.Text = "End"

	End Sub

	Private Sub btImport_Click(sender As Object, e As EventArgs) Handles btImport.Click

	End Sub

	Private Sub timerOpenConnection_Tick(sender As Object, e As EventArgs) Handles timerOpenConnection.Tick
		Call Konek()
		timerOpenConnection.Stop()


	End Sub
End Class
