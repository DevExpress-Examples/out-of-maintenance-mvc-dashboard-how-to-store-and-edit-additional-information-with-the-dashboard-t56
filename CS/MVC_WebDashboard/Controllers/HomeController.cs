using DevExpress.DashboardWeb;
using Storages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Xml.Linq;

namespace MVC_WebDashboard.Controllers {
    public class HomeController : Controller {

        public ActionResult Index() {
            return View();
        }

        [ValidateInput(false)]
        public ActionResult SaveDashboard(string DashboardID, string dashboardJSON, string parameter) {
            var dashboardDocument = DashboardJsonConverter.JsonToXml(dashboardJSON);
            CustomDashboardFileStorage dashboardStorage = new CustomDashboardFileStorage(@"~/App_Data/Dashboards");
            dashboardStorage.SaveDashboard(DashboardID, dashboardDocument, parameter);
            return new EmptyResult();
        }
        public ActionResult GetDashboardParameter(string DashboardID, string parameterName) {
            CustomDashboardFileStorage dashboardStorage = new CustomDashboardFileStorage(@"~/App_Data/Dashboards");
            XElement data = dashboardStorage.GetUserData(DashboardID);
            if (data == null || data.Element(parameterName) == null)
                return new EmptyResult();

            return new JsonResult() { Data = data.Element(parameterName).Value };
        }
    }
}
