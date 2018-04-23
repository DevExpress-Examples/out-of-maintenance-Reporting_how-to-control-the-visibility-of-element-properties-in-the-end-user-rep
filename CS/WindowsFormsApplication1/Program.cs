#region #Usings
using System;
using System.Windows.Forms;
using DevExpress.XtraReports.UI;
using DevExpress.XtraReports.UserDesigner;
using System.ComponentModel;
using DevExpress.XtraReports.Expressions;
// ...
#endregion #Usings

namespace WindowsFormsApplication1 {
#region #Program
static class Program {
    [STAThread]
    static void Main() {
        Application.EnableVisualStyles();
        Application.SetCompatibleTextRenderingDefault(false);

        // Handle the static FilterComponentProperties event to filter the Property Grid. 
        XtraReport.FilterComponentProperties += XtraReport_FilterComponentProperties;

        // For the XRLabel control, hide the Background Color and Tag properties from the Expressions tab.
        ExpressionBindingDescriptor.HidePropertyDescriptions(typeof(XRLabel), "BackColor", "Tag");
        Application.Run(new Form1());
    }

    static void XtraReport_FilterComponentProperties(object sender, 
        FilterComponentPropertiesEventArgs e) {
        // Hide the Scripts property for all report elements.
        HideProperty("Scripts", e);

        // Hide the ReportSource and ReportSourceUrl properties for subreports.
        if (e.Component is XRSubreport) {
            HideProperty("ReportSource", e);     
            HideProperty("ReportSourceUrl", e);    
        }  

        // Hide the Name property for a specific label control.
        if (sender is XtraReport1 && e.Component is XRControl && 
            ((XRControl)e.Component).Name == "label1") {
            HideProperty("Name", e);
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
            // If the property descriptor cannot be substituted, 
            // remove it from the Properties collection.
            filterComponentProperties.Properties.Remove(propertyName);
        }
    }
}
#endregion #Program
}
