using DevExpress.DashboardCommon;
using DevExpress.DashboardWeb;
using System.IO;
using System.Threading;
using System.Xml.Linq;

namespace Storages {

    public class CustomDashboardFileStorage : DashboardFileStorage {
        public CustomDashboardFileStorage(string workingDirectory)
            : base(workingDirectory) {
        }

        public void SaveDashboard(string dashboardID, XDocument dashboardLayout, string parameter) {
            var dashboardPath = base.ResolveFileName(dashboardID);
            if (File.Exists(dashboardPath)) {
                Dashboard dashboard = new Dashboard();
                dashboard.LoadFromXDocument(dashboardLayout);
                XElement userData = new XElement("Root", new XElement("Parameter", parameter));
                dashboard.UserData = userData;
                dashboard.SaveToXml(dashboardPath);
            }
        }

        public XElement GetUserData(string dashboardID) {
            var dashboardPath = base.ResolveFileName(dashboardID);
            if (File.Exists(dashboardPath)) {
                Dashboard dashboard = new Dashboard();
                dashboard.LoadFromXml(dashboardPath);
                return dashboard.UserData;
            }
            return null;
        }
    }
}