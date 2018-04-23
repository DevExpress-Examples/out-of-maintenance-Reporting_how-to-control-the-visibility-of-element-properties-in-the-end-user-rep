# How to control the visibility of element properties in the End-User Report Designer


<p>This example illustrates how to hide properties of a report, its bands and controls from the End-User Report Designer's <strong>Properties</strong> panel<strong> </strong>by handling the <a href="https://documentation.devexpress.com/XtraReports/DevExpress.XtraReports.UI.XtraReport.FilterComponentProperties.event">XtraReport.FilterComponentProperties</a> event.</p>
Starting with v17.2, reports use <a href="https://documentation.devexpress.com/XtraReports/119236/Creating-Reports-in-Visual-Studio/Detailed-Guide-to-DevExpress-Reporting/Providing-Data-to-Reports/Data-Binding-Overview/Data-Binding-Modes">binding expressions</a>, which you can specify in the <strong>Properties </strong>panel's <strong>Expression </strong>tab. To hide properties from this tab, use the <strong>ExpressionBindingDescriptor.HidePropertyDescriptions </strong>method.

<br/>


