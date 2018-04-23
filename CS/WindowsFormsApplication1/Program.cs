#region #Usings
using System;
using System.Windows.Forms;
using DevExpress.XtraReports.UI;
using DevExpress.XtraReports.UserDesigner;
using System.ComponentModel;
// ...
#endregion #Usings

namespace WindowsFormsApplication1 {
#region #Program
static class Program {
    /// <summary>
    /// The main entry point for the application.
    /// </summary>
    [STAThread]
    static void Main() {
        Application.EnableVisualStyles();
        Application.SetCompatibleTextRenderingDefault(false);

        // To define filtering rules for the Property Grid, 
        // handle the static FilterComponentProperties event.
        XtraReport.FilterComponentProperties += XtraReport_FilterComponentProperties;
        Application.Run(new Form1());
    }

    static void XtraReport_FilterComponentProperties(object sender, 
        FilterComponentPropertiesEventArgs e) {
        // The following line hides the Scripts property for all report elements.
        HideProperty("Scripts", e);

        // The following code hides the ReportSource property, 
        // for subreports to always contain only the pre-defined reports.
        if (e.Component is XRSubreport) {
            HideProperty("ReportSource", e);
            HideProperty("ReportSourceUrl", e);
        }

        // The following code hides some properties for a specific report element.
        if (sender is XtraReport1 && e.Component is XRControl && 
            ((XRControl)e.Component).Name == "label1") {
            HideProperty("Name", e);
            HideProperty("DataBindings", e);
        }
    }

    static void HideProperty(String propertyName, 
        FilterComponentPropertiesEventArgs filterComponentProperties) {
        PropertyDescriptor oldPropertyDescriptor = 
            filterComponentProperties.Properties[propertyName] as PropertyDescriptor;
        if (oldPropertyDescriptor != null) {
            // Substitute the current property descriptor 
            // with a custom one with the BrowsableAttribute.No attribute.
            filterComponentProperties.Properties[propertyName] = TypeDescriptor.CreateProperty(
                oldPropertyDescriptor.ComponentType,
                oldPropertyDescriptor,
                new Attribute[] { BrowsableAttribute.No });
        }
        else {
            // If the property descriptor can not be substituted, 
            // remove it from the Properties collection.
            filterComponentProperties.Properties.Remove(propertyName);
        }
    }
}
#endregion #Program
}
