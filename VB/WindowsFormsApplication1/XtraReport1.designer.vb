Namespace WindowsFormsApplication1
    Partial Public Class XtraReport1
        ''' <summary>
        ''' Required designer variable.
        ''' </summary>
        Private components As System.ComponentModel.IContainer = Nothing

        ''' <summary> 
        ''' Clean up any resources being used.
        ''' </summary>
        ''' <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        Protected Overrides Sub Dispose(ByVal disposing As Boolean)
            If disposing AndAlso (components IsNot Nothing) Then
                components.Dispose()
            End If
            MyBase.Dispose(disposing)
        End Sub

        #Region "Designer generated code"

        ''' <summary>
        ''' Required method for Designer support - do not modify
        ''' the contents of this method with the code editor.
        ''' </summary>
        Private Sub InitializeComponent()
            Dim resources As New System.ComponentModel.ComponentResourceManager(GetType(XtraReport1))
            Me.Detail = New DevExpress.XtraReports.UI.DetailBand()
            Me.xrSubreport1 = New DevExpress.XtraReports.UI.XRSubreport()
            Me.xrRichText1 = New DevExpress.XtraReports.UI.XRRichText()
            Me.label1 = New DevExpress.XtraReports.UI.XRLabel()
            Me.TopMargin = New DevExpress.XtraReports.UI.TopMarginBand()
            Me.BottomMargin = New DevExpress.XtraReports.UI.BottomMarginBand()
            CType(Me.xrRichText1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me, System.ComponentModel.ISupportInitialize).BeginInit()
            ' 
            ' Detail
            ' 
            Me.Detail.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() { Me.xrSubreport1, Me.xrRichText1, Me.label1})
            Me.Detail.HeightF = 340.625F
            Me.Detail.Name = "Detail"
            Me.Detail.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F)
            Me.Detail.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
            ' 
            ' xrSubreport1
            ' 
            Me.xrSubreport1.LocationFloat = New DevExpress.Utils.PointFloat(9.99999F, 226F)
            Me.xrSubreport1.Name = "xrSubreport1"
            Me.xrSubreport1.ReportSource = New WindowsFormsApplication1.SubReport1()
            Me.xrSubreport1.SizeF = New System.Drawing.SizeF(629.9999F, 86.54169F)
            ' 
            ' xrRichText1
            ' 
            Me.xrRichText1.Font = New System.Drawing.Font("Tahoma", 9.75F)
            Me.xrRichText1.LocationFloat = New DevExpress.Utils.PointFloat(10.00001F, 113.5F)
            Me.xrRichText1.Name = "xrRichText1"
            Me.xrRichText1.SerializableRtfString = resources.GetString("xrRichText1.SerializableRtfString")
            Me.xrRichText1.SizeF = New System.Drawing.SizeF(630F, 93.16669F)
            Me.xrRichText1.StylePriority.UseFont = False
            ' 
            ' label1
            ' 
            Me.label1.Font = New System.Drawing.Font("Tahoma", 9.75F)
            Me.label1.LocationFloat = New DevExpress.Utils.PointFloat(10.00001F, 10.00001F)
            Me.label1.Multiline = True
            Me.label1.Name = "label1"
            Me.label1.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F)
            Me.label1.SizeF = New System.Drawing.SizeF(630F, 84.45832F)
            Me.label1.StylePriority.UseFont = False
            Me.label1.Text = resources.GetString("label1.Text")
            ' 
            ' TopMargin
            ' 
            Me.TopMargin.HeightF = 100F
            Me.TopMargin.Name = "TopMargin"
            Me.TopMargin.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F)
            Me.TopMargin.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
            ' 
            ' BottomMargin
            ' 
            Me.BottomMargin.HeightF = 100F
            Me.BottomMargin.Name = "BottomMargin"
            Me.BottomMargin.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F)
            Me.BottomMargin.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
            ' 
            ' XtraReport1
            ' 
            Me.Bands.AddRange(New DevExpress.XtraReports.UI.Band() { Me.Detail, Me.TopMargin, Me.BottomMargin})
            Me.Version = "17.2"
            CType(Me.xrRichText1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me, System.ComponentModel.ISupportInitialize).EndInit()

        End Sub

        #End Region

        Private Detail As DevExpress.XtraReports.UI.DetailBand
        Private TopMargin As DevExpress.XtraReports.UI.TopMarginBand
        Private BottomMargin As DevExpress.XtraReports.UI.BottomMarginBand
        Private label1 As DevExpress.XtraReports.UI.XRLabel
        Private xrRichText1 As DevExpress.XtraReports.UI.XRRichText
        Private xrSubreport1 As DevExpress.XtraReports.UI.XRSubreport
    End Class
End Namespace
