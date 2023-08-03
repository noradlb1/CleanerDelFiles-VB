Namespace CSharp_Cleaner
	Partial Public Class frmMain
		''' <summary>
		''' Required designer variable.
		''' </summary>
		Private components As System.ComponentModel.IContainer = Nothing

		''' <summary>
		''' Clean up any resources being used.
		''' </summary>
		''' <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		Protected Overrides Sub Dispose(ByVal disposing As Boolean)
			If disposing AndAlso (components IsNot Nothing) Then
				components.Dispose()
			End If
			MyBase.Dispose(disposing)
		End Sub

		#Region "Windows Form Designer generated code"

		''' <summary>
		''' Required method for Designer support - do not modify
		''' the contents of this method with the code editor.
		''' </summary>
		Private Sub InitializeComponent()
			Me.pnlActions = New System.Windows.Forms.Panel()
			Me.btnUninstall = New System.Windows.Forms.Button()
			Me.btnRefreshList = New System.Windows.Forms.Button()
			Me.lstApps = New System.Windows.Forms.ListBox()
			Me.pnlActions.SuspendLayout()
			Me.SuspendLayout()
			' 
			' pnlActions
			' 
			Me.pnlActions.Controls.Add(Me.btnUninstall)
			Me.pnlActions.Controls.Add(Me.btnRefreshList)
			Me.pnlActions.Dock = System.Windows.Forms.DockStyle.Top
			Me.pnlActions.Location = New System.Drawing.Point(1, 5)
			Me.pnlActions.Name = "pnlActions"
			Me.pnlActions.Size = New System.Drawing.Size(346, 35)
			Me.pnlActions.TabIndex = 1
			' 
			' btnUninstall
			' 
			Me.btnUninstall.Dock = System.Windows.Forms.DockStyle.Fill
			Me.btnUninstall.Enabled = False
			Me.btnUninstall.Location = New System.Drawing.Point(112, 0)
			Me.btnUninstall.Margin = New System.Windows.Forms.Padding(4)
			Me.btnUninstall.Name = "btnUninstall"
			Me.btnUninstall.Size = New System.Drawing.Size(234, 35)
			Me.btnUninstall.TabIndex = 3
			Me.btnUninstall.Text = "Uninstall selection"
			Me.btnUninstall.UseVisualStyleBackColor = True
'			Me.btnUninstall.Click += New System.EventHandler(Me.btnUninstall_Click)
			' 
			' btnRefreshList
			' 
			Me.btnRefreshList.Dock = System.Windows.Forms.DockStyle.Left
			Me.btnRefreshList.Location = New System.Drawing.Point(0, 0)
			Me.btnRefreshList.Margin = New System.Windows.Forms.Padding(4)
			Me.btnRefreshList.Name = "btnRefreshList"
			Me.btnRefreshList.Size = New System.Drawing.Size(112, 35)
			Me.btnRefreshList.TabIndex = 2
			Me.btnRefreshList.Text = "Refresh"
			Me.btnRefreshList.UseVisualStyleBackColor = True
'			Me.btnRefreshList.Click += New System.EventHandler(Me.btnRefreshList_Click)
			' 
			' lstApps
			' 
			Me.lstApps.Dock = System.Windows.Forms.DockStyle.Fill
			Me.lstApps.FormattingEnabled = True
			Me.lstApps.ItemHeight = 18
			Me.lstApps.Location = New System.Drawing.Point(1, 40)
			Me.lstApps.Name = "lstApps"
			Me.lstApps.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple
			Me.lstApps.Size = New System.Drawing.Size(346, 408)
			Me.lstApps.TabIndex = 0
'			Me.lstApps.SelectedIndexChanged += New System.EventHandler(Me.lstApps_SelectedIndexChanged)
			' 
			' frmMain
			' 
			Me.AutoScaleDimensions = New System.Drawing.SizeF(9F, 18F)
			Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
			Me.ClientSize = New System.Drawing.Size(348, 448)
			Me.Controls.Add(Me.lstApps)
			Me.Controls.Add(Me.pnlActions)
			Me.Font = New System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (CByte(0)))
			Me.Margin = New System.Windows.Forms.Padding(4)
			Me.Name = "frmMain"
			Me.Padding = New System.Windows.Forms.Padding(1, 5, 1, 0)
			Me.ShowIcon = False
			Me.Text = "C#Cleaner"
'			Me.Load += New System.EventHandler(Me.frmMain_Load)
			Me.pnlActions.ResumeLayout(False)
			Me.ResumeLayout(False)

		End Sub

		#End Region

		Private pnlActions As System.Windows.Forms.Panel
		Private WithEvents btnUninstall As System.Windows.Forms.Button
		Private WithEvents btnRefreshList As System.Windows.Forms.Button
		Private WithEvents lstApps As System.Windows.Forms.ListBox

	End Class
End Namespace

