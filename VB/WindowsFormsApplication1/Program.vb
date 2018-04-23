Imports Microsoft.VisualBasic
#Region "#Usings"
Imports System
Imports System.Windows.Forms
Imports DevExpress.XtraReports.UI
Imports DevExpress.XtraReports.UserDesigner
Imports System.ComponentModel
' ...
#End Region ' #Usings

Namespace WindowsFormsApplication1
#Region "#Program"
Friend NotInheritable Class Program
    ''' <summary>
    ''' The main entry point for the application.
    ''' </summary>
    Private Sub New()
    End Sub
    <STAThread()> _
    Shared Sub Main()
        Application.EnableVisualStyles()
        Application.SetCompatibleTextRenderingDefault(False)

        ' To define filtering rules for the Property Grid, 
        ' handle the static FilterComponentProperties event.
        AddHandler XtraReport.FilterComponentProperties, _
            AddressOf XtraReport_FilterComponentProperties
        Application.Run(New Form1())
    End Sub

    Private Shared Sub XtraReport_FilterComponentProperties(ByVal sender As Object, _
    ByVal e As FilterComponentPropertiesEventArgs)
        ' The following line hides the Scripts property for all report elements.
        HideProperty("Scripts", e)

        ' The following code hides the ReportSource property, 
        ' for subreports to always contain only the pre-defined reports.
        If TypeOf e.Component Is XRSubreport Then
            HideProperty("ReportSource", e)
            HideProperty("ReportSourceUrl", e)
        End If

        ' The following code hides some properties for a specific report element.
        If TypeOf sender Is XtraReport1 AndAlso TypeOf e.Component Is XRControl _
            AndAlso (CType(e.Component, XRControl)).Name = "label1" Then
            HideProperty("Name", e)
            HideProperty("DataBindings", e)
        End If
    End Sub

    Private Shared Sub HideProperty(ByVal propertyName As String, _
    ByVal filterComponentProperties As FilterComponentPropertiesEventArgs)
        Dim oldPropertyDescriptor As PropertyDescriptor = _
            TryCast(filterComponentProperties.Properties(propertyName), PropertyDescriptor)
        If oldPropertyDescriptor IsNot Nothing Then
            ' Substitute the current property descriptor 
            ' with a custom one with the BrowsableAttribute.No attribute.
            filterComponentProperties.Properties(propertyName) = _
                TypeDescriptor.CreateProperty(oldPropertyDescriptor.ComponentType, _
                oldPropertyDescriptor, New Attribute() {BrowsableAttribute.No})
        Else
            ' If the property descriptor can not be substituted, 
            ' remove it from the Properties collection.
            filterComponentProperties.Properties.Remove(propertyName)
        End If
    End Sub
End Class
#End Region ' #Program
End Namespace
