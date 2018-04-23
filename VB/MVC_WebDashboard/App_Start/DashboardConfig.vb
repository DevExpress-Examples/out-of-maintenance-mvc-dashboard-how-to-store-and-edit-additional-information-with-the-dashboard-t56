Imports Microsoft.VisualBasic
Imports System.Web.Routing
Imports DevExpress.DashboardWeb
Imports DevExpress.DashboardWeb.Mvc
Imports Storages
Imports System.Web

Public Class DashboardConfig
	Public Shared Sub RegisterService(ByVal routes As RouteCollection)
		routes.MapDashboardRoute()
		DashboardConfigurator.Default.SetDashboardStorage(New CustomDashboardFileStorage(HttpContext.Current.Server.MapPath("~/App_Data/Dashboards")))
	End Sub
End Class