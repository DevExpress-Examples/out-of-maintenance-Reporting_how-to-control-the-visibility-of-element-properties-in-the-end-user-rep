Namespace WindowsFormsApplication1
    Partial Public Class Form1
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

        #Region "Windows Form Designer generated code"

        ''' <summary>
        ''' Required method for Designer support - do not modify
        ''' the contents of this method with the code editor.
        ''' </summary>
        Private Sub InitializeComponent()
            Dim resources As New System.ComponentModel.ComponentResourceManager(GetType(Form1))
            Dim xrDesignPanelListener1 As New DevExpress.XtraReports.UserDesigner.XRDesignPanelListener()
            Me.xrDesignBarManager1 = New DevExpress.XtraReports.UserDesigner.XRDesignBarManager()
            Me.barDockControlTop = New DevExpress.XtraBars.BarDockControl()
            Me.barDockControlBottom = New DevExpress.XtraBars.BarDockControl()
            Me.barDockControlLeft = New DevExpress.XtraBars.BarDockControl()
            Me.barDockControlRight = New DevExpress.XtraBars.BarDockControl()
            Me.recentlyUsedItemsComboBox1 = New DevExpress.XtraReports.UserDesigner.RecentlyUsedItemsComboBox()
            Me.designRepositoryItemComboBox1 = New DevExpress.XtraReports.UserDesigner.DesignRepositoryItemComboBox()
            Me.reportDesigner1 = New DevExpress.XtraReports.UserDesigner.XRDesignMdiController()
            Me.button1 = New System.Windows.Forms.Button()
            CType(Me.xrDesignBarManager1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.recentlyUsedItemsComboBox1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.designRepositoryItemComboBox1, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
            ' 
            ' xrDesignBarManager1
            ' 
            Me.xrDesignBarManager1.DockControls.Add(Me.barDockControlTop)
            Me.xrDesignBarManager1.DockControls.Add(Me.barDockControlBottom)
            Me.xrDesignBarManager1.DockControls.Add(Me.barDockControlLeft)
            Me.xrDesignBarManager1.DockControls.Add(Me.barDockControlRight)
            Me.xrDesignBarManager1.FontNameBox = Me.recentlyUsedItemsComboBox1
            Me.xrDesignBarManager1.FontNameEdit = Nothing
            Me.xrDesignBarManager1.FontSizeBox = Me.designRepositoryItemComboBox1
            Me.xrDesignBarManager1.FontSizeEdit = Nothing
            Me.xrDesignBarManager1.Form = Me
            Me.xrDesignBarManager1.FormattingToolbar = Nothing
            Me.xrDesignBarManager1.HintStaticItem = Nothing
            Me.xrDesignBarManager1.ImageStream = (CType(resources.GetObject("xrDesignBarManager1.ImageStream"), DevExpress.Utils.ImageCollectionStreamer))
            Me.xrDesignBarManager1.LayoutToolbar = Nothing
            Me.xrDesignBarManager1.MaxItemId = 76
            Me.xrDesignBarManager1.Toolbar = Nothing
            Me.xrDesignBarManager1.TransparentEditors = True
            Me.xrDesignBarManager1.Updates.AddRange(New String() { "Toolbox"})
            Me.xrDesignBarManager1.ZoomItem = Nothing
            ' 
            ' barDockControlTop
            ' 
            Me.barDockControlTop.CausesValidation = False
            Me.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top
            Me.barDockControlTop.Location = New System.Drawing.Point(0, 0)
            Me.barDockControlTop.Size = New System.Drawing.Size(290, 0)
            ' 
            ' barDockControlBottom
            ' 
            Me.barDockControlBottom.CausesValidation = False
            Me.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom
            Me.barDockControlBottom.Location = New System.Drawing.Point(0, 209)
            Me.barDockControlBottom.Size = New System.Drawing.Size(290, 0)
            ' 
            ' barDockControlLeft
            ' 
            Me.barDockControlLeft.CausesValidation = False
            Me.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left
            Me.barDockControlLeft.Location = New System.Drawing.Point(0, 0)
            Me.barDockControlLeft.Size = New System.Drawing.Size(0, 209)
            ' 
            ' barDockControlRight
            ' 
            Me.barDockControlRight.CausesValidation = False
            Me.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right
            Me.barDockControlRight.Location = New System.Drawing.Point(290, 0)
            Me.barDockControlRight.Size = New System.Drawing.Size(0, 209)
            ' 
            ' recentlyUsedItemsComboBox1
            ' 
            Me.recentlyUsedItemsComboBox1.AppearanceDropDown.Font = New System.Drawing.Font("Tahoma", 11.25F)
            Me.recentlyUsedItemsComboBox1.AppearanceDropDown.Options.UseFont = True
            Me.recentlyUsedItemsComboBox1.AutoHeight = False
            Me.recentlyUsedItemsComboBox1.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() { New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
            Me.recentlyUsedItemsComboBox1.DropDownRows = 12
            Me.recentlyUsedItemsComboBox1.Name = "recentlyUsedItemsComboBox1"
            ' 
            ' designRepositoryItemComboBox1
            ' 
            Me.designRepositoryItemComboBox1.AutoHeight = False
            Me.designRepositoryItemComboBox1.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() { New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
            Me.designRepositoryItemComboBox1.Name = "designRepositoryItemComboBox1"
            ' 
            ' reportDesigner1
            ' 
            Me.reportDesigner1.ContainerControl = Nothing
            xrDesignPanelListener1.DesignControl = Me.xrDesignBarManager1
            Me.reportDesigner1.DesignPanelListeners.AddRange(New DevExpress.XtraReports.UserDesigner.XRDesignPanelListener() { xrDesignPanelListener1})
            Me.reportDesigner1.Form = Me
            ' 
            ' button1
            ' 
            Me.button1.Location = New System.Drawing.Point(69, 58)
            Me.button1.Name = "button1"
            Me.button1.Size = New System.Drawing.Size(148, 90)
            Me.button1.TabIndex = 4
            Me.button1.Text = "Run Designer"
            Me.button1.UseVisualStyleBackColor = True
            ' 
            ' Form1
            ' 
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.ClientSize = New System.Drawing.Size(290, 209)
            Me.Controls.Add(Me.button1)
            Me.Controls.Add(Me.barDockControlLeft)
            Me.Controls.Add(Me.barDockControlRight)
            Me.Controls.Add(Me.barDockControlBottom)
            Me.Controls.Add(Me.barDockControlTop)
            Me.Name = "Form1"
            Me.Text = "Form1"
            CType(Me.xrDesignBarManager1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.recentlyUsedItemsComboBox1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.designRepositoryItemComboBox1, System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)

        End Sub

        #End Region

        Private reportDesigner1 As DevExpress.XtraReports.UserDesigner.XRDesignMdiController
        Private xrDesignBarManager1 As DevExpress.XtraReports.UserDesigner.XRDesignBarManager
        Private barDockControlTop As DevExpress.XtraBars.BarDockControl
        Private barDockControlBottom As DevExpress.XtraBars.BarDockControl
        Private barDockControlLeft As DevExpress.XtraBars.BarDockControl
        Private barDockControlRight As DevExpress.XtraBars.BarDockControl
        Private WithEvents button1 As System.Windows.Forms.Button
        Private recentlyUsedItemsComboBox1 As DevExpress.XtraReports.UserDesigner.RecentlyUsedItemsComboBox
        Private designRepositoryItemComboBox1 As DevExpress.XtraReports.UserDesigner.DesignRepositoryItemComboBox

    End Class
End Namespace

