Imports Microsoft.VisualBasic
Imports DevExpress.DashboardCommon
Imports DevExpress.DashboardWeb
Imports System.IO
Imports System.Threading
Imports System.Xml.Linq

Namespace Storages

	Public Class CustomDashboardFileStorage
		Inherits DashboardFileStorage
		Public Sub New(ByVal workingDirectory As String)
			MyBase.New(workingDirectory)
		End Sub

		Public Sub SaveDashboard(ByVal dashboardID As String, ByVal dashboardLayout As XDocument, ByVal parameter As String)
			Dim dashboardPath = MyBase.ResolveFileName(dashboardID)
			If File.Exists(dashboardPath) Then
				Dim dashboard As New Dashboard()
				dashboard.LoadFromXDocument(dashboardLayout)
				Dim userData As New XElement("Root", New XElement("Parameter", parameter))
				dashboard.UserData = userData
				dashboard.SaveToXml(dashboardPath)
			End If
		End Sub

		Public Function GetUserData(ByVal dashboardID As String) As XElement
			Dim dashboardPath = MyBase.ResolveFileName(dashboardID)
			If File.Exists(dashboardPath) Then
				Dim dashboard As New Dashboard()
				dashboard.LoadFromXml(dashboardPath)
				Return dashboard.UserData
			End If
			Return Nothing
		End Function
	End Class
End Namespace