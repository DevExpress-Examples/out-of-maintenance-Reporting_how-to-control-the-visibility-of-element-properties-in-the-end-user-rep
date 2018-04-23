Imports Microsoft.VisualBasic
Imports System
Imports System.Windows.Forms
Imports DevExpress.XtraReports.UI
' ...

Namespace WindowsFormsApplication1
	Partial Public Class Form1
		Inherits Form
		Public Sub New()
			InitializeComponent()
		End Sub

        Private Sub button1_Click(ByVal sender As Object, _
                                  ByVal e As EventArgs) Handles button1.Click
            ' Create a new report instance.
            Dim report As New XtraReport1()

            ' Invoke the End-User Designer form for the report.
            Dim designTool As New ReportDesignTool(report)
            designTool.ShowDesignerDialog()
        End Sub

	End Class
End Namespace
