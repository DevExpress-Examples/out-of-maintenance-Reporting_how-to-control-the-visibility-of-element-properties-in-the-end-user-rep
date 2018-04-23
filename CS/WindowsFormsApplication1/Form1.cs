using System;
using System.Windows.Forms;
using DevExpress.XtraReports.UI;
// ...

namespace WindowsFormsApplication1 {
    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e) {
            // Create a new report instance.
            XtraReport1 report = new XtraReport1();

            // Invoke the End-User Designer form for the report.
            ReportDesignTool designTool = new ReportDesignTool(report);
            designTool.ShowDesignerDialog();
        }

    }
}
