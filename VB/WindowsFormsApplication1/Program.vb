#Region "#Usings"
Imports System
Imports System.Windows.Forms
Imports DevExpress.XtraReports.UI
Imports DevExpress.XtraReports.UserDesigner
Imports System.ComponentModel
Imports DevExpress.XtraReports.Expressions
' ...
#End Region ' #Usings

Namespace WindowsFormsApplication1
#Region "#Program"
Friend NotInheritable Class Program

    Private Sub New()
    End Sub

    <STAThread> _
    Shared Sub Main()
        Application.EnableVisualStyles()
        Application.SetCompatibleTextRenderingDefault(False)

        ' Handle the static FilterComponentProperties event to filter the Property Grid. 
        AddHandler XtraReport.FilterComponentProperties, AddressOf XtraReport_FilterComponentProperties

        ' For the XRLabel control, hide the Background Color and Tag properties from the Expressions tab.
        ExpressionBindingDescriptor.HidePropertyDescriptions(GetType(XRLabel), "BackColor", "Tag")
        Application.Run(New Form1())
    End Sub

    Private Shared Sub XtraReport_FilterComponentProperties(ByVal sender As Object, ByVal e As FilterComponentPropertiesEventArgs)
        ' Hide the Scripts property for all report elements.
        HideProperty("Scripts", e)

        ' Hide the ReportSource and ReportSourceUrl properties for subreports.
        If TypeOf e.Component Is XRSubreport Then
            HideProperty("ReportSource", e)
            HideProperty("ReportSourceUrl", e)
        End If

        ' Hide the Name property for a specific label control.
        If TypeOf sender Is XtraReport1 AndAlso TypeOf e.Component Is XRControl AndAlso CType(e.Component, XRControl).Name = "label1" Then
            HideProperty("Name", e)
        End If

    End Sub

    Private Shared Sub HideProperty(ByVal propertyName As String, ByVal filterComponentProperties As FilterComponentPropertiesEventArgs)
        Dim oldPropertyDescriptor As PropertyDescriptor = TryCast(filterComponentProperties.Properties(propertyName), PropertyDescriptor)
        If oldPropertyDescriptor IsNot Nothing Then
            ' Substitute the current property descriptor 
            ' with a custom one with the BrowsableAttribute.No attribute.
            filterComponentProperties.Properties(propertyName) = TypeDescriptor.CreateProperty(oldPropertyDescriptor.ComponentType, oldPropertyDescriptor, New Attribute() { BrowsableAttribute.No })
        Else
            ' If the property descriptor cannot be substituted, 
            ' remove it from the Properties collection.
            filterComponentProperties.Properties.Remove(propertyName)
        End If
    End Sub
End Class
#End Region ' #Program
End Namespace
