using System.Web.Routing;
using DevExpress.DashboardWeb;
using DevExpress.DashboardWeb.Mvc;
using Storages;
using System.Web;

public class DashboardConfig {
    public static void RegisterService(RouteCollection routes) {
        routes.MapDashboardRoute();
        DashboardConfigurator.Default.SetDashboardStorage(new CustomDashboardFileStorage(HttpContext.Current.Server.MapPath("~/App_Data/Dashboards")));
    }
}