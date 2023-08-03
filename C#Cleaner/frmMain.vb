Imports System
Imports System.IO
Imports System.Linq
Imports System.Text
Imports System.Windows.Forms

Namespace CSharp_Cleaner
	Partial Public Class frmMain
		Inherits Form

		Private Shared ReadOnly LOCAL_APP_DATA_PATH As String = Environment.SpecialFolder.LocalApplicationData.GetPath()

		Public Sub New()
			InitializeComponent()
		End Sub

		Private Sub btnRefreshList_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnRefreshList.Click
			FillAppsListBox()
		End Sub

		Private Sub btnUninstall_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnUninstall.Click
			If MessageBox.Show(Me, String.Format("The following directories will be permanently deleted:" & ControlChars.Lf & "{0}", lstApps.SelectedItems.ToLines()), "Warning", MessageBoxButtons.OKCancel) = System.Windows.Forms.DialogResult.OK Then
				Try
					For Each item In lstApps.SelectedItems
						Directory.Delete(GetFullPath(item), True)
					Next item
				Catch ex As Exception
					MessageBox.Show(Me, ex.Message, "Error")
				Finally
					FillAppsListBox()
				End Try
			End If
		End Sub

		Private Sub frmMain_Load(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load
			FillAppsListBox()
		End Sub

		Private Sub lstApps_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs) Handles lstApps.SelectedIndexChanged
			btnUninstall.Enabled = (lstApps.SelectedIndices.Count > 0)
		End Sub

		Private Shared Function GetFullPath(ByVal path As Object) As String
			Return String.Format("{0}\{1}", LOCAL_APP_DATA_PATH, path)
		End Function

		Private Sub FillAppsListBox()
			lstApps.Items.Clear()
			lstApps.Items.AddRange(Directory.EnumerateDirectories(LOCAL_APP_DATA_PATH).[Select](AddressOf Path.GetFileName).ToArray())
		End Sub
	End Class

	Friend Module Extensions
		<System.Runtime.CompilerServices.Extension> _
		Friend Function GetPath(ByVal specialFolder As Environment.SpecialFolder) As String
			Return Environment.GetFolderPath(specialFolder)
		End Function

		<System.Runtime.CompilerServices.Extension> _
		Friend Function ToLines(ByVal objs As ListBox.SelectedObjectCollection) As String
			Dim sb As New StringBuilder()
			For Each s As String In objs
				sb.AppendLine(s)
			Next s
			Return sb.ToString()
		End Function
	End Module
End Namespace
