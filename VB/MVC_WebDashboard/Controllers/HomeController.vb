Imports Microsoft.VisualBasic
Imports DevExpress.DashboardWeb
Imports Storages
Imports System
Imports System.Collections.Generic
Imports System.Linq
Imports System.Web
Imports System.Web.Mvc
Imports System.Xml.Linq

Namespace MVC_WebDashboard.Controllers
	Public Class HomeController
		Inherits Controller

		Public Function Index() As ActionResult
			Return View()
		End Function

		<ValidateInput(False)> _
		Public Function SaveDashboard(ByVal DashboardID As String, ByVal dashboardJSON As String, ByVal parameter As String) As ActionResult
			Dim dashboardDocument = DashboardJsonConverter.JsonToXml(dashboardJSON)
			Dim dashboardStorage As New CustomDashboardFileStorage("~/App_Data/Dashboards")
			dashboardStorage.SaveDashboard(DashboardID, dashboardDocument, parameter)
			Return New EmptyResult()
		End Function
		Public Function GetDashboardParameter(ByVal DashboardID As String, ByVal parameterName As String) As ActionResult
			Dim dashboardStorage As New CustomDashboardFileStorage("~/App_Data/Dashboards")
			Dim data As XElement = dashboardStorage.GetUserData(DashboardID)
			If data Is Nothing OrElse data.Element(parameterName) Is Nothing Then
				Return New EmptyResult()
			End If

			Return New JsonResult() With {.Data = data.Element(parameterName).Value}
		End Function
	End Class
End Namespace
