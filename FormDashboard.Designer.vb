﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FormDashboard
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
		Me.pnForm = New System.Windows.Forms.Panel()
		Me.btClose = New System.Windows.Forms.Button()
		Me.btMinimize = New System.Windows.Forms.Button()
		Me.btMaximize = New System.Windows.Forms.Button()
		Me.lbHeader = New System.Windows.Forms.Label()
		Me.gbHasilAnalisa = New System.Windows.Forms.GroupBox()
		Me.gbBestCust = New System.Windows.Forms.GroupBox()
		Me.DataGridView2 = New System.Windows.Forms.DataGridView()
		Me.gbBestDay = New System.Windows.Forms.GroupBox()
		Me.DataGridView1 = New System.Windows.Forms.DataGridView()
		Me.gbBestKAT = New System.Windows.Forms.GroupBox()
		Me.dgvBestKAT = New System.Windows.Forms.DataGridView()
		Me.gbAuthor = New System.Windows.Forms.GroupBox()
		Me.dgvBestAuthor = New System.Windows.Forms.DataGridView()
		Me.gbBestBuku = New System.Windows.Forms.GroupBox()
		Me.dgvBestBuku = New System.Windows.Forms.DataGridView()
		Me.gbCriteria = New System.Windows.Forms.GroupBox()
		Me.CbEndMonth = New System.Windows.Forms.ComboBox()
		Me.cbStartMonth = New System.Windows.Forms.ComboBox()
		Me.rbInterval = New System.Windows.Forms.RadioButton()
		Me.lbEndMonth = New System.Windows.Forms.Label()
		Me.lbPilihStartMonth = New System.Windows.Forms.Label()
		Me.cbMonth = New System.Windows.Forms.ComboBox()
		Me.rbMonth = New System.Windows.Forms.RadioButton()
		Me.rbAll = New System.Windows.Forms.RadioButton()
		Me.gbImport = New System.Windows.Forms.GroupBox()
		Me.btImport = New System.Windows.Forms.Button()
		Me.gbAnalisa = New System.Windows.Forms.GroupBox()
		Me.btEXE = New System.Windows.Forms.Button()
		Me.OFDImport = New System.Windows.Forms.OpenFileDialog()
		Me.timerOpenConnection = New System.Windows.Forms.Timer(Me.components)
		Me.pnForm.SuspendLayout()
		Me.gbHasilAnalisa.SuspendLayout()
		Me.gbBestCust.SuspendLayout()
		CType(Me.DataGridView2, System.ComponentModel.ISupportInitialize).BeginInit()
		Me.gbBestDay.SuspendLayout()
		CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
		Me.gbBestKAT.SuspendLayout()
		CType(Me.dgvBestKAT, System.ComponentModel.ISupportInitialize).BeginInit()
		Me.gbAuthor.SuspendLayout()
		CType(Me.dgvBestAuthor, System.ComponentModel.ISupportInitialize).BeginInit()
		Me.gbBestBuku.SuspendLayout()
		CType(Me.dgvBestBuku, System.ComponentModel.ISupportInitialize).BeginInit()
		Me.gbCriteria.SuspendLayout()
		Me.gbImport.SuspendLayout()
		Me.gbAnalisa.SuspendLayout()
		Me.SuspendLayout()
		'
		'pnForm
		'
		Me.pnForm.BackColor = System.Drawing.Color.RoyalBlue
		Me.pnForm.Controls.Add(Me.btClose)
		Me.pnForm.Controls.Add(Me.btMinimize)
		Me.pnForm.Controls.Add(Me.btMaximize)
		Me.pnForm.Dock = System.Windows.Forms.DockStyle.Top
		Me.pnForm.Location = New System.Drawing.Point(0, 0)
		Me.pnForm.Name = "pnForm"
		Me.pnForm.Size = New System.Drawing.Size(808, 33)
		Me.pnForm.TabIndex = 0
		'
		'btClose
		'
		Me.btClose.BackColor = System.Drawing.Color.SkyBlue
		Me.btClose.BackgroundImage = Global.KahananPasarVB.My.Resources.Resources.close_window_32px
		Me.btClose.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
		Me.btClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat
		Me.btClose.Location = New System.Drawing.Point(775, 0)
		Me.btClose.Name = "btClose"
		Me.btClose.Size = New System.Drawing.Size(33, 32)
		Me.btClose.TabIndex = 3
		Me.btClose.UseVisualStyleBackColor = False
		'
		'btMinimize
		'
		Me.btMinimize.BackColor = System.Drawing.Color.SkyBlue
		Me.btMinimize.BackgroundImage = Global.KahananPasarVB.My.Resources.Resources.minimize_window_32px
		Me.btMinimize.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
		Me.btMinimize.FlatStyle = System.Windows.Forms.FlatStyle.Flat
		Me.btMinimize.Location = New System.Drawing.Point(697, 0)
		Me.btMinimize.Name = "btMinimize"
		Me.btMinimize.Size = New System.Drawing.Size(33, 32)
		Me.btMinimize.TabIndex = 1
		Me.btMinimize.UseVisualStyleBackColor = False
		'
		'btMaximize
		'
		Me.btMaximize.BackColor = System.Drawing.Color.SkyBlue
		Me.btMaximize.BackgroundImage = Global.KahananPasarVB.My.Resources.Resources.maximize_window_32px
		Me.btMaximize.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
		Me.btMaximize.FlatStyle = System.Windows.Forms.FlatStyle.Flat
		Me.btMaximize.Location = New System.Drawing.Point(736, 0)
		Me.btMaximize.Name = "btMaximize"
		Me.btMaximize.Size = New System.Drawing.Size(33, 32)
		Me.btMaximize.TabIndex = 2
		Me.btMaximize.UseVisualStyleBackColor = False
		'
		'lbHeader
		'
		Me.lbHeader.AutoSize = True
		Me.lbHeader.Font = New System.Drawing.Font("Bookman Old Style", 14.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lbHeader.Location = New System.Drawing.Point(287, 34)
		Me.lbHeader.Name = "lbHeader"
		Me.lbHeader.Size = New System.Drawing.Size(195, 23)
		Me.lbHeader.TabIndex = 1
		Me.lbHeader.Text = "Kahanan Pasar v.1"
		'
		'gbHasilAnalisa
		'
		Me.gbHasilAnalisa.Controls.Add(Me.gbBestCust)
		Me.gbHasilAnalisa.Controls.Add(Me.gbBestDay)
		Me.gbHasilAnalisa.Controls.Add(Me.gbBestKAT)
		Me.gbHasilAnalisa.Controls.Add(Me.gbAuthor)
		Me.gbHasilAnalisa.Controls.Add(Me.gbBestBuku)
		Me.gbHasilAnalisa.FlatStyle = System.Windows.Forms.FlatStyle.Flat
		Me.gbHasilAnalisa.Location = New System.Drawing.Point(12, 60)
		Me.gbHasilAnalisa.Name = "gbHasilAnalisa"
		Me.gbHasilAnalisa.Size = New System.Drawing.Size(547, 487)
		Me.gbHasilAnalisa.TabIndex = 2
		Me.gbHasilAnalisa.TabStop = False
		'
		'gbBestCust
		'
		Me.gbBestCust.Controls.Add(Me.DataGridView2)
		Me.gbBestCust.Location = New System.Drawing.Point(264, 321)
		Me.gbBestCust.Name = "gbBestCust"
		Me.gbBestCust.Size = New System.Drawing.Size(273, 148)
		Me.gbBestCust.TabIndex = 3
		Me.gbBestCust.TabStop = False
		Me.gbBestCust.Text = "BEST CUST"
		'
		'DataGridView2
		'
		Me.DataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
		Me.DataGridView2.Location = New System.Drawing.Point(6, 19)
		Me.DataGridView2.Name = "DataGridView2"
		Me.DataGridView2.Size = New System.Drawing.Size(255, 123)
		Me.DataGridView2.TabIndex = 0
		'
		'gbBestDay
		'
		Me.gbBestDay.Controls.Add(Me.DataGridView1)
		Me.gbBestDay.Location = New System.Drawing.Point(6, 321)
		Me.gbBestDay.Name = "gbBestDay"
		Me.gbBestDay.Size = New System.Drawing.Size(252, 148)
		Me.gbBestDay.TabIndex = 2
		Me.gbBestDay.TabStop = False
		Me.gbBestDay.Text = "BESTDAY"
		'
		'DataGridView1
		'
		Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
		Me.DataGridView1.Location = New System.Drawing.Point(6, 19)
		Me.DataGridView1.Name = "DataGridView1"
		Me.DataGridView1.Size = New System.Drawing.Size(240, 123)
		Me.DataGridView1.TabIndex = 0
		'
		'gbBestKAT
		'
		Me.gbBestKAT.Controls.Add(Me.dgvBestKAT)
		Me.gbBestKAT.Location = New System.Drawing.Point(264, 167)
		Me.gbBestKAT.Name = "gbBestKAT"
		Me.gbBestKAT.Size = New System.Drawing.Size(273, 148)
		Me.gbBestKAT.TabIndex = 2
		Me.gbBestKAT.TabStop = False
		Me.gbBestKAT.Text = "KAT"
		'
		'dgvBestKAT
		'
		Me.dgvBestKAT.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
		Me.dgvBestKAT.Location = New System.Drawing.Point(6, 19)
		Me.dgvBestKAT.Name = "dgvBestKAT"
		Me.dgvBestKAT.Size = New System.Drawing.Size(255, 123)
		Me.dgvBestKAT.TabIndex = 0
		'
		'gbAuthor
		'
		Me.gbAuthor.Controls.Add(Me.dgvBestAuthor)
		Me.gbAuthor.Location = New System.Drawing.Point(6, 167)
		Me.gbAuthor.Name = "gbAuthor"
		Me.gbAuthor.Size = New System.Drawing.Size(252, 148)
		Me.gbAuthor.TabIndex = 1
		Me.gbAuthor.TabStop = False
		Me.gbAuthor.Text = "AUTHOR"
		'
		'dgvBestAuthor
		'
		Me.dgvBestAuthor.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
		Me.dgvBestAuthor.Location = New System.Drawing.Point(6, 19)
		Me.dgvBestAuthor.Name = "dgvBestAuthor"
		Me.dgvBestAuthor.Size = New System.Drawing.Size(240, 123)
		Me.dgvBestAuthor.TabIndex = 0
		'
		'gbBestBuku
		'
		Me.gbBestBuku.Controls.Add(Me.dgvBestBuku)
		Me.gbBestBuku.Location = New System.Drawing.Point(6, 19)
		Me.gbBestBuku.Name = "gbBestBuku"
		Me.gbBestBuku.Size = New System.Drawing.Size(531, 148)
		Me.gbBestBuku.TabIndex = 0
		Me.gbBestBuku.TabStop = False
		Me.gbBestBuku.Text = "BUKU"
		'
		'dgvBestBuku
		'
		Me.dgvBestBuku.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
		Me.dgvBestBuku.Location = New System.Drawing.Point(6, 19)
		Me.dgvBestBuku.Name = "dgvBestBuku"
		Me.dgvBestBuku.Size = New System.Drawing.Size(513, 123)
		Me.dgvBestBuku.TabIndex = 0
		'
		'gbCriteria
		'
		Me.gbCriteria.Controls.Add(Me.CbEndMonth)
		Me.gbCriteria.Controls.Add(Me.cbStartMonth)
		Me.gbCriteria.Controls.Add(Me.rbInterval)
		Me.gbCriteria.Controls.Add(Me.lbEndMonth)
		Me.gbCriteria.Controls.Add(Me.lbPilihStartMonth)
		Me.gbCriteria.Controls.Add(Me.cbMonth)
		Me.gbCriteria.Controls.Add(Me.rbMonth)
		Me.gbCriteria.Controls.Add(Me.rbAll)
		Me.gbCriteria.Location = New System.Drawing.Point(565, 60)
		Me.gbCriteria.Name = "gbCriteria"
		Me.gbCriteria.Size = New System.Drawing.Size(238, 140)
		Me.gbCriteria.TabIndex = 3
		Me.gbCriteria.TabStop = False
		Me.gbCriteria.Text = "Criteria"
		'
		'CbEndMonth
		'
		Me.CbEndMonth.FormattingEnabled = True
		Me.CbEndMonth.Location = New System.Drawing.Point(121, 106)
		Me.CbEndMonth.Name = "CbEndMonth"
		Me.CbEndMonth.Size = New System.Drawing.Size(110, 21)
		Me.CbEndMonth.TabIndex = 7
		'
		'cbStartMonth
		'
		Me.cbStartMonth.FormattingEnabled = True
		Me.cbStartMonth.Location = New System.Drawing.Point(2, 106)
		Me.cbStartMonth.Name = "cbStartMonth"
		Me.cbStartMonth.Size = New System.Drawing.Size(110, 21)
		Me.cbStartMonth.TabIndex = 6
		'
		'rbInterval
		'
		Me.rbInterval.AutoSize = True
		Me.rbInterval.Location = New System.Drawing.Point(6, 58)
		Me.rbInterval.Name = "rbInterval"
		Me.rbInterval.Size = New System.Drawing.Size(60, 17)
		Me.rbInterval.TabIndex = 5
		Me.rbInterval.TabStop = True
		Me.rbInterval.Text = "Interval"
		Me.rbInterval.UseVisualStyleBackColor = True
		'
		'lbEndMonth
		'
		Me.lbEndMonth.AutoSize = True
		Me.lbEndMonth.Location = New System.Drawing.Point(169, 82)
		Me.lbEndMonth.Name = "lbEndMonth"
		Me.lbEndMonth.Size = New System.Drawing.Size(16, 13)
		Me.lbEndMonth.TabIndex = 4
		Me.lbEndMonth.Text = "..."
		'
		'lbPilihStartMonth
		'
		Me.lbPilihStartMonth.AutoSize = True
		Me.lbPilihStartMonth.Location = New System.Drawing.Point(10, 82)
		Me.lbPilihStartMonth.Name = "lbPilihStartMonth"
		Me.lbPilihStartMonth.Size = New System.Drawing.Size(16, 13)
		Me.lbPilihStartMonth.TabIndex = 3
		Me.lbPilihStartMonth.Text = "..."
		'
		'cbMonth
		'
		Me.cbMonth.FormattingEnabled = True
		Me.cbMonth.Location = New System.Drawing.Point(2, 107)
		Me.cbMonth.Name = "cbMonth"
		Me.cbMonth.Size = New System.Drawing.Size(230, 21)
		Me.cbMonth.TabIndex = 2
		'
		'rbMonth
		'
		Me.rbMonth.AutoSize = True
		Me.rbMonth.Location = New System.Drawing.Point(6, 38)
		Me.rbMonth.Name = "rbMonth"
		Me.rbMonth.Size = New System.Drawing.Size(62, 17)
		Me.rbMonth.TabIndex = 1
		Me.rbMonth.TabStop = True
		Me.rbMonth.Text = "Monthly"
		Me.rbMonth.UseVisualStyleBackColor = True
		'
		'rbAll
		'
		Me.rbAll.AutoSize = True
		Me.rbAll.Location = New System.Drawing.Point(6, 19)
		Me.rbAll.Name = "rbAll"
		Me.rbAll.Size = New System.Drawing.Size(36, 17)
		Me.rbAll.TabIndex = 0
		Me.rbAll.TabStop = True
		Me.rbAll.Text = "All"
		Me.rbAll.UseVisualStyleBackColor = True
		'
		'gbImport
		'
		Me.gbImport.Controls.Add(Me.btImport)
		Me.gbImport.Location = New System.Drawing.Point(564, 204)
		Me.gbImport.Name = "gbImport"
		Me.gbImport.Size = New System.Drawing.Size(124, 91)
		Me.gbImport.TabIndex = 4
		Me.gbImport.TabStop = False
		Me.gbImport.Text = "Import"
		'
		'btImport
		'
		Me.btImport.BackgroundImage = Global.KahananPasarVB.My.Resources.Resources.data_recovery_26px
		Me.btImport.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
		Me.btImport.FlatStyle = System.Windows.Forms.FlatStyle.Flat
		Me.btImport.Location = New System.Drawing.Point(6, 19)
		Me.btImport.Name = "btImport"
		Me.btImport.Size = New System.Drawing.Size(112, 62)
		Me.btImport.TabIndex = 0
		Me.btImport.UseVisualStyleBackColor = True
		'
		'gbAnalisa
		'
		Me.gbAnalisa.Controls.Add(Me.btEXE)
		Me.gbAnalisa.Location = New System.Drawing.Point(694, 204)
		Me.gbAnalisa.Name = "gbAnalisa"
		Me.gbAnalisa.Size = New System.Drawing.Size(109, 91)
		Me.gbAnalisa.TabIndex = 5
		Me.gbAnalisa.TabStop = False
		Me.gbAnalisa.Text = ".EXE"
		'
		'btEXE
		'
		Me.btEXE.BackgroundImage = Global.KahananPasarVB.My.Resources.Resources.artificial_intelligence_30px
		Me.btEXE.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
		Me.btEXE.FlatStyle = System.Windows.Forms.FlatStyle.Flat
		Me.btEXE.Location = New System.Drawing.Point(9, 19)
		Me.btEXE.Name = "btEXE"
		Me.btEXE.Size = New System.Drawing.Size(94, 62)
		Me.btEXE.TabIndex = 2
		Me.btEXE.UseVisualStyleBackColor = True
		'
		'OFDImport
		'
		Me.OFDImport.FileName = "OrderComplete"
		'
		'FormDashboard
		'
		Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.BackColor = System.Drawing.Color.SkyBlue
		Me.ClientSize = New System.Drawing.Size(808, 565)
		Me.Controls.Add(Me.gbAnalisa)
		Me.Controls.Add(Me.gbImport)
		Me.Controls.Add(Me.gbCriteria)
		Me.Controls.Add(Me.gbHasilAnalisa)
		Me.Controls.Add(Me.lbHeader)
		Me.Controls.Add(Me.pnForm)
		Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
		Me.Name = "FormDashboard"
		Me.Opacity = 0.9R
		Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
		Me.Text = "FormDashboard"
		Me.pnForm.ResumeLayout(False)
		Me.gbHasilAnalisa.ResumeLayout(False)
		Me.gbBestCust.ResumeLayout(False)
		CType(Me.DataGridView2, System.ComponentModel.ISupportInitialize).EndInit()
		Me.gbBestDay.ResumeLayout(False)
		CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
		Me.gbBestKAT.ResumeLayout(False)
		CType(Me.dgvBestKAT, System.ComponentModel.ISupportInitialize).EndInit()
		Me.gbAuthor.ResumeLayout(False)
		CType(Me.dgvBestAuthor, System.ComponentModel.ISupportInitialize).EndInit()
		Me.gbBestBuku.ResumeLayout(False)
		CType(Me.dgvBestBuku, System.ComponentModel.ISupportInitialize).EndInit()
		Me.gbCriteria.ResumeLayout(False)
		Me.gbCriteria.PerformLayout()
		Me.gbImport.ResumeLayout(False)
		Me.gbAnalisa.ResumeLayout(False)
		Me.ResumeLayout(False)
		Me.PerformLayout()

	End Sub

	Friend WithEvents pnForm As Panel
	Friend WithEvents btMinimize As Button
	Friend WithEvents btMaximize As Button
	Friend WithEvents btClose As Button
	Friend WithEvents lbHeader As Label
	Friend WithEvents gbHasilAnalisa As GroupBox
	Friend WithEvents gbCriteria As GroupBox
	Friend WithEvents gbImport As GroupBox
	Friend WithEvents btImport As Button
	Friend WithEvents gbAnalisa As GroupBox
	Friend WithEvents btEXE As Button
	Friend WithEvents gbBestCust As GroupBox
	Friend WithEvents DataGridView2 As DataGridView
	Friend WithEvents gbBestDay As GroupBox
	Friend WithEvents DataGridView1 As DataGridView
	Friend WithEvents gbBestKAT As GroupBox
	Friend WithEvents dgvBestKAT As DataGridView
	Friend WithEvents gbAuthor As GroupBox
	Friend WithEvents dgvBestAuthor As DataGridView
	Friend WithEvents gbBestBuku As GroupBox
	Friend WithEvents dgvBestBuku As DataGridView
	Friend WithEvents rbMonth As RadioButton
	Friend WithEvents rbAll As RadioButton
	Friend WithEvents cbMonth As ComboBox
	Friend WithEvents OFDImport As OpenFileDialog
	Friend WithEvents lbPilihStartMonth As Label
	Friend WithEvents lbEndMonth As Label
	Friend WithEvents CbEndMonth As ComboBox
	Friend WithEvents cbStartMonth As ComboBox
	Friend WithEvents rbInterval As RadioButton
	Friend WithEvents timerOpenConnection As Timer
End Class
