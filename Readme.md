<!-- default badges list -->
![](https://img.shields.io/endpoint?url=https://codecentral.devexpress.com/api/v1/VersionRange/128579393/18.2.3%2B)
[![](https://img.shields.io/badge/Open_in_DevExpress_Support_Center-FF7200?style=flat-square&logo=DevExpress&logoColor=white)](https://supportcenter.devexpress.com/ticket/details/T562011)
[![](https://img.shields.io/badge/📖_How_to_use_DevExpress_Examples-e9f6fc?style=flat-square)](https://docs.devexpress.com/GeneralInformation/403183)
<!-- default badges end -->
<!-- default file list -->
*Files to look at*:

* [DashboardConfig.cs](./CS/MVC_WebDashboard/App_Start/DashboardConfig.cs) (VB: [DashboardConfig.vb](./VB/MVC_WebDashboard/App_Start/DashboardConfig.vb))
* [HomeController.cs](./CS/MVC_WebDashboard/Controllers/HomeController.cs) (VB: [HomeController.vb](./VB/MVC_WebDashboard/Controllers/HomeController.vb))
* [CustomDashbboardStorage.cs](./CS/MVC_WebDashboard/Models/CustomDashbboardStorage.cs) (VB: [CustomDashbboardStorage.vb](./VB/MVC_WebDashboard/Models/CustomDashbboardStorage.vb))
* [_Layout.cshtml](./CS/MVC_WebDashboard/Views/Shared/_Layout.cshtml)
<!-- default file list end -->

# OBSOLETE: Dashboard for MVC - How to store and edit additional information with the dashboard

---
**UPDATED:** *The UserData mechanism is an obsolete approach. From v.20.1, use [Custom Properties](https://docs.devexpress.com/Dashboard/401702/web-dashboard/ui-elements-and-customization/create-custom-properties?p=netframework) to save data to the dashboard XML definition. Instead of UserData, you can save custom data not only for a dashboard, but also for dashboard items and its data items.*

---

<p>This example demonstrates how to store an additional dashboard description along with the dashboard layout. The dashboard description is displayed within the HTML textarea element and it is possible to edit it. This functionality is implemented by creating a custom Save button and a custom Dashboard Storage.</p>

<br/>

## More Examples

- [Dashboard Item Description - Custom Property](https://docs.devexpress.com/Dashboard/401709/web-dashboard/ui-elements-and-customization/create-custom-properties/dashboard-item-description-custom-property?p=netframework)
