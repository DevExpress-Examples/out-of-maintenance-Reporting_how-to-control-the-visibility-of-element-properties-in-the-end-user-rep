<!-- default badges list -->
![](https://img.shields.io/endpoint?url=https://codecentral.devexpress.com/api/v1/VersionRange/128599079/17.2.3%2B)
[![](https://img.shields.io/badge/Open_in_DevExpress_Support_Center-FF7200?style=flat-square&logo=DevExpress&logoColor=white)](https://supportcenter.devexpress.com/ticket/details/E4345)
[![](https://img.shields.io/badge/📖_How_to_use_DevExpress_Examples-e9f6fc?style=flat-square)](https://docs.devexpress.com/GeneralInformation/403183)
<!-- default badges end -->
<!-- default file list -->
*Files to look at*:

* [Form1.cs](./CS/WindowsFormsApplication1/Form1.cs) (VB: [Form1.vb](./VB/WindowsFormsApplication1/Form1.vb))
* **[Program.cs](./CS/WindowsFormsApplication1/Program.cs) (VB: [Program.vb](./VB/WindowsFormsApplication1/Program.vb))**
<!-- default file list end -->
# How to control the visibility of element properties in the End-User Report Designer


<p>This example illustrates how to hide properties of a report, its bands and controls from the End-User Report Designer's <strong>Properties</strong> panel<strong> </strong>by handling the <a href="https://documentation.devexpress.com/XtraReports/DevExpress.XtraReports.UI.XtraReport.FilterComponentProperties.event">XtraReport.FilterComponentProperties</a> event.</p>
Starting with v17.2, reports use <a href="https://documentation.devexpress.com/XtraReports/119236/Creating-Reports-in-Visual-Studio/Detailed-Guide-to-DevExpress-Reporting/Providing-Data-to-Reports/Data-Binding-Overview/Data-Binding-Modes">binding expressions</a>, which you can specify in the <strong>Properties </strong>panel's <strong>Expression </strong>tab. To hide properties from this tab, use the <strong>ExpressionBindingDescriptor.HidePropertyDescriptions </strong>method.

<br/>


